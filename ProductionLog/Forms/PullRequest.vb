Imports System.Data.OleDb
Imports System.Text
Imports MySql.Data.MySqlClient
Public Class PullRequest
    'Dim ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\pcpserver\pl_share\PrimaLend\Collateral Management\Updates\Timelog.accdb" 'Shared DB file
    Dim AppData As String = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Primalend\"
    Dim ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & AppData & "Timelogz.accdb" 'Local resource with links
    Dim SqlConnectionString As String = "Server=192.168.1.34; Database=TimeLogDB; User id=clerk; Password=12345;" 'NUC Database

    Dim MainTable As New DataTable
    Dim DiffDate As Boolean = False
    Dim TotalReturn As Integer = 0
    Dim SuccessSeconds As Integer = 0
    Dim MegaComment As String = ""
    Private Sub PullRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Please remember, this does not CIFR out any of these items.", vbOKOnly, "Remember!")
        IDLabel.Text = Dashboard.IDLabel.Text
        Try
            Dim MainQuery As String = "SELECT UniqueID,DateReceived,Dealership,Collateral,VIN6,isReturned FROM Batch ORDER BY DateReceived"
            Dim MainAdapt As New MySqlDataAdapter(MainQuery, SqlConnectionString)
            MainAdapt.Fill(MainTable)
            If MainTable.Rows.Count < 1 Then
                ErrorLabel.Visible = True
            Else
                PullDGV.DataSource = MainTable
            End If
        Catch ex As Exception
            SendError.Show()
            SendError.EmpIDLabel.Text = IDLabel.Text
            SendError.ErrorRTB.Text = ex.ToString
        End Try
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        If MsgBox("Are you sure you want to finish?", vbYesNo, "Are you sure?") = vbYes Then
            Try
                Dim NowTime As String = Datetime.now.tostring("HH:mm:ss")
                Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")

                Dim Lookup As String = "SELECT JobID From Workflow Where EmpID=" & IDLabel.Text & " AND Job='Pull Requests' AND DateCompleted IS NULL"
                Dim LookupAdapt As New MySqlDataAdapter(Lookup, SqlConnectionString)
                Dim LookupTable As New DataTable
                LookupAdapt.Fill(LookupTable)
                Dim EndJob As String = "UPDATE Workflow SET TimeCompleted='" & NowTime & "',DateCompleted='" & NowDate & "',Comment='UniqueIDs changed:" & MegaComment & "',Quantity='" & TotalReturn & "' WHERE JobID=" & LookupTable.Rows(0)(0)
                Using Connection As New MySqlConnection(SqlConnectionString)
                    Dim Command As New MySqlCommand(EndJob, Connection)
                    Connection.Open()
                    Command.ExecuteNonQuery()
                    Connection.Close()
                End Using
                Me.Dispose()
            Catch ex As Exception
                SendError.Show()
                SendError.EmpIDLabel.Text = IDLabel.Text
                SendError.ErrorRTB.Text = ex.ToString
            End Try
        End If
    End Sub

    Private Sub Vin6Box_TextChanged(sender As Object, e As EventArgs) Handles Vin6Box.TextChanged
        Try
            MainTable.DefaultView.RowFilter = "vin6 like '%" & Vin6Box.Text & "%'"
            PullDGV.DataSource = MainTable
        Catch ex As Exception
            SendError.Show()
            SendError.EmpIDLabel.Text = IDLabel.Text
            SendError.ErrorRTB.Text = ex.ToString
        End Try
    End Sub

    Private Sub PullDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PullDGV.CellContentClick

    End Sub

    Private Sub PullDGV_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles PullDGV.CellValueChanged
        Dim CellX As Integer
        Dim CellY As Integer
        CellX = PullDGV.CurrentCellAddress.X
        CellY = PullDGV.CurrentCellAddress.Y
        Try
            If EditList.Items.Contains(PullDGV.Rows(CellY).Cells(0).Value.ToString) Then
                Exit Sub
            Else
                EditList.Items.Add(PullDGV.Rows(CellY).Cells(0).Value.ToString)
            End If
        Catch ex As Exception
            SendError.Show()
            SendError.EmpIDLabel.Text = IDLabel.Text
            SendError.ErrorRTB.Text = ex.ToString
        End Try
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        EditList.Items.RemoveAt(EditList.SelectedIndex)
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        Dim Sql(EditList.Items.Count - 1) As String
        Try
            Dim NowTime As String = Datetime.now.tostring("HH:mm:ss")
            Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")

            If DiffDate = False Then
                For i = 0 To EditList.Items.Count - 1
                    Sql(i) = "UPDATE Batch SET DateReturned='" & NowDate & "',IsReturned=True, ReturnedBy='" & IDLabel.Text & "' WHERE UniqueID=" & EditList.Items(i)
                Next
            Else

                For i = 0 To EditList.Items.Count - 1
                    Sql(i) = "UPDATE Batch SET DateReturned='" & DateReturnPick.Value.ToString("yyyy-MM-dd") & "',isReturned=True, ReturnedBy='" & IDLabel.Text & "' WHERE UniqueID=" & EditList.Items(i)
                Next
            End If
            Using connection As New MySqlConnection(SqlConnectionString)
                connection.Open()
                For i = 0 To EditList.Items.Count - 1
                    Dim Command As New MySqlCommand(Sql(i), connection)
                    Command.ExecuteNonQuery()
                    TotalReturn += 1
                    MegaComment = MegaComment & " " & EditList.Items(i).ToString
                Next
                connection.Close()
            End Using
            SuccessTimer.Enabled = True
            EditList.Items.Clear()
        Catch ex As Exception
            SendError.Show()
            SendError.EmpIDLabel.Text = IDLabel.Text
            SendError.ErrorRTB.Text = ex.ToString
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            DateReturnPick.Visible = True
            DiffDate = True
        Else
            DateReturnPick.Visible = False
            DiffDate = False
        End If
    End Sub

    Private Sub SuccessTimer_Tick(sender As Object, e As EventArgs) Handles SuccessTimer.Tick
        If SuccessSeconds > 5 Then
            SuccessSeconds = 0
            SuccessLabel.Visible = False
            SuccessTimer.Stop()
        Else
            SuccessLabel.Visible = True
            SuccessSeconds += 1
        End If
    End Sub
End Class