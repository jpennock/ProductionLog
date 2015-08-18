Imports MySql.Data.MySqlClient
Imports System.Text

Public Class DBA
    Dim SqlConnectionString As String = "Server=192.168.1.34; Database=TimeLogDB; User id=clerk; Password=12345; Convert zero datetime=True;" 'NUC Database
    Dim VinTable As New DataTable
    Private Sub DBA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try 'Attempt to load of the Dealership and Collateral Combo Boxes.
            Dim DealerQuery As String = "SELECT DealerID,Dealership from dealername where isactive = '1' order by Dealership ASC"
            Dim CollateralQuery As String = "SELECT CollateralType from Collateral"
            Dim DealerAdapt As New MySqlDataAdapter(DealerQuery, SqlConnectionString)
            Dim CollateralAdapt As New MySqlDataAdapter(CollateralQuery, SqlConnectionString)
            Dim Dealertable As New DataTable
            Dim Collateraltable As New DataTable
            DealerAdapt.Fill(Dealertable)
            CollateralAdapt.Fill(Collateraltable)
            With DealershipComboBox
                .DataSource = Dealertable
                .ValueMember = "DealerID"
                .DisplayMember = "Dealership"
            End With
            With CollateralComboBox
                .DataSource = Collateraltable
                .ValueMember = "CollateralType"
                .DisplayMember = "CollateralType"
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Me.Dispose()
    End Sub

    Private Sub DealershipComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DealershipComboBox.SelectedIndexChanged
        Try
            If DealershipComboBox.SelectedIndex > 0 Then
                VinTable.Clear()
                Dim VINQuery As String = "Select * from vins where dealerid = '" & DealershipComboBox.SelectedValue & "'"
                'MsgBox(VINQuery)
                Dim VinAdapt As New MySqlDataAdapter(VINQuery, SqlConnectionString)
                VinAdapt.Fill(VinTable)
                With FullVinComboBox
                    .DataSource = VinTable
                    .DisplayMember = "VIN"
                    .ValueMember = "VIN"
                End With
                BatchIDMaker()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub VinTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VinTextBox.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            'MsgBox(FullVinComboBox.SelectedValue)
            If VinTextBox.Text = "" Or DealershipComboBox.Text = "" Or CollateralComboBox.Text = "" Then
                Exit Sub
            Else
                DealershipComboBox.Enabled = False
                CollateralComboBox.Enabled = False
                If FullVinComboBox.SelectedValue <> "" Then
                    If CollateralList.Items.Contains(FullVinComboBox.SelectedValue.ToString) Then
                        MsgBox("Vin already in list.", vbOKOnly, "Oops!")
                        Exit Sub
                    End If
                    CollateralList.Items.Insert(0, FullVinComboBox.SelectedValue.ToString)
                Else
                    If CollateralList.Items.Contains(VinTextBox.Text) Then
                        MsgBox("Vin already in list.", vbOKOnly, "Oops!")
                        Exit Sub
                    End If
                    CollateralList.Items.Insert(0, VinTextBox.Text)
                End If
                VinTextBox.Text = ""
            End If
            CountBox.Text = CollateralList.Items.Count
        End If
    End Sub

    Private Sub VinTextBox_TextChanged(sender As Object, e As EventArgs) Handles VinTextBox.TextChanged
        Try
            If VinTextBox.Text = "" Then
                Exit Sub
            Else
                VinTable.DefaultView.RowFilter = "VIN Like '%" & VinTextBox.Text & "%'"
                With FullVinComboBox
                    .DataSource = VinTable
                    .DisplayMember = "VIN"
                    .ValueMember = "VIN"
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If CollateralList.Items.Count < 1 Or BatchIDLabel.Text = "" Then
            Exit Sub
        Else
            Try
                Dim NowTime As String = DateTime.Now.ToString("HH:mm:ss")
                Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")
                Dim QueryBuilt As New StringBuilder
                QueryBuilt.Append("INSERT INTO Batch (BatchID,EmpID,Dealership,Collateral,VIN6,DateReceived,Timereceived) VALUES")
                For i = 0 To CollateralList.Items.Count - 1
                    If i = CollateralList.Items.Count - 1 Then
                        QueryBuilt.Append("('" & BatchIDLabel.Text & "','" & Dashboard.IDLabel.Text & "','" & DealershipComboBox.Text & "','" & CollateralComboBox.Text & "','" & CollateralList.Items(i) & "','" & NowDate & "','" & NowTime & "');")
                    Else
                        QueryBuilt.Append("('" & BatchIDLabel.Text & "','" & Dashboard.IDLabel.Text & "','" & DealershipComboBox.Text & "','" & CollateralComboBox.Text & "','" & CollateralList.Items(i) & "','" & NowDate & "','" & NowTime & "'),")
                    End If
                Next
                Using Connection As New MySqlConnection(SqlConnectionString)
                    Dim command As New MySqlCommand(QueryBuilt.ToString, Connection)
                    Connection.Open()
                    command.ExecuteNonQuery()
                    Connection.Close()
                End Using
                CollateralList.Items.Clear()
                BatchIDLabel.Text = ""
                BatchIDMaker()
                DealershipComboBox.Enabled = True
                DealershipComboBox.Text = ""
                CollateralComboBox.Enabled = True
                SuccessTimer.Enabled = True
                CountBox.Enabled = True
                CountBox.Text = ""
                Me.Enabled = True
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        Try
            CollateralList.Items.RemoveAt(CollateralList.SelectedIndex)
            CountBox.Text = CollateralList.Items.Count
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Function BatchIDMaker()
        Dim rng As New Random
        Dim number As Integer = rng.Next(1, 1000)
        Dim digits As String = number.ToString("D3")
        Dim datedata As String = DateTime.Now.Month & DateTime.Now.Day & DateTime.Now.Minute
        If DealershipComboBox.Text = "" Then
            BatchIDLabel.Text = ""
            Return Nothing
            Exit Function
        Else
            Dim Dealer As String = DealershipComboBox.Text.Replace(" ", "")
            Dim batchstring As String = Dealer(0) & Dealer(1) & Dealer(Dealer.Length - 2) & Dealer(Dealer.Length - 1) 'First 2 characters, last two characters.
            BatchIDLabel.Text = batchstring & datedata & digits
        End If
        Return Nothing
    End Function

End Class
