Imports System
Imports System.IO
Imports System.Collections
Imports System.Text
Imports System.Data.OleDb
Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Imports System.Threading
Public Class FileCabinetPopup

    Dim SqlConnectionString As String = "Server=192.168.1.34; Database=TimeLogDB; User id=clerk; Password=12345;" 'NUC Database <--Being used now
    <DllImport("user32.dll", SetLastError:=True)> _
    Private Shared Function SetWindowPos(ByVal hWnd As IntPtr, ByVal hWndInsertAfter As IntPtr, ByVal X As Integer, ByVal Y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal uFlags As Integer) As Boolean
    End Function

    Private Const SWP_NOSIZE As Integer = &H1
    Private Const SWP_NOMOVE As Integer = &H2

    Private Shared ReadOnly HWND_TOPMOST As New IntPtr(-1)
    Private Shared ReadOnly HWND_NOTOPMOST As New IntPtr(-2)

    Public Function MakeTopMost()
        SetWindowPos(Me.Handle(), HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE Or SWP_NOSIZE)
        Return Nothing
    End Function

    Public Function MakeNormal()
        SetWindowPos(Me.Handle(), HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOMOVE Or SWP_NOSIZE)

        Return Nothing
    End Function
    Private Sub FileCabinetPopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeTopMost()
        Try
            EmpIDLabel.Text = Dashboard.IDLabel.Text
            Dim JobTable As New DataTable
            Dim JobQuery As String = "SELECT JobID,BatchID,DateAssigned,Dealer,Job,Quantity From workflow where dealer='" & Overwatch.BBComboBox.Items(Overwatch.BBComboBox.SelectedIndex).ToString & "' and job like '%CIFR%' and datecompleted is null and datestarted is null"
            Dim JobAdapt As New MySqlDataAdapter(JobQuery, SqlConnectionString)
            JobAdapt.Fill(JobTable)
            If JobTable.Rows.Count > 1 Then 'If there is more than one CIFR job available.
                For i = 0 To JobTable.Rows.Count - 1
                    JobCheckListBox.Items.Add(JobTable.Rows(i)(0).ToString & "-" & JobTable.Rows(i)(1).ToString & "-" & JobTable.Rows(i)(3) & "-" & JobTable.Rows(i)(4).ToString & "-" & JobTable.Rows(i)(5).ToString)
                Next
                For c = JobCheckListBox.Items.Count - 1 To 0 Step -1
                    JobCheckListBox.SetItemChecked(c, True)
                Next
            ElseIf JobTable.Rows.Count = 1 Then 'If there is only the one CIFR job available, assign that one.
                For i = 0 To JobTable.Rows.Count - 1
                    JobCheckListBox.Items.Add(JobTable.Rows(i)(0).ToString & "-" & JobTable.Rows(i)(1).ToString & "-" & JobTable.Rows(i)(3) & "-" & JobTable.Rows(i)(4).ToString & "-" & JobTable.Rows(i)(5).ToString)
                Next
                For c = JobCheckListBox.Items.Count - 1 To 0 Step -1
                    JobCheckListBox.SetItemChecked(c, True)
                Next
            Else
                Me.Dispose()
            End If
            StartButton.Focus()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub XButton_Click(sender As Object, e As EventArgs) Handles XButton.Click
        Me.Dispose()
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click 'This button lets you start all the checked jobs (all jobs are checked by default)
        If MsgBox("Do you need this CIFR to be updated before you begin these jobs?", vbYesNo, "Please verify") = MsgBoxResult.No Then
            Try 'If they have alread checked that no update is required, then go ahead and build the update query to set the date and time started for all the jobs.
                Dim QueryBuilt As New StringBuilder()
                Dim NowTime As String = DateTime.Now.ToString("HH:mm:ss")
                Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")
                QueryBuilt.Append("UPDATE Workflow Set Empid=" & EmpIDLabel.Text & " ,DateStarted='" & NowDate & "' ,timestarted='" & NowTime & "' WHERE ")

                For i = 0 To JobCheckListBox.CheckedItems.Count - 1
                    If JobCheckListBox.GetItemChecked(i) = True Then
                        If i < JobCheckListBox.CheckedItems.Count - 1 Then
                            Dim ToSplit As String = JobCheckListBox.Items(i).ToString
                            Dim Split() As String = ToSplit.Split(New Char() {"-"c})
                            QueryBuilt.Append("JOBID='" & Split(0).ToString & "' OR ")
                        Else
                            Dim ToSplit As String = JobCheckListBox.Items(i).ToString
                            Dim Split() As String = ToSplit.Split(New Char() {"-"c})
                            QueryBuilt.Append("JOBID='" & Split(0).ToString & "'")
                        End If
                    End If
                Next
                MsgBox(QueryBuilt.ToString)


            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Please review the collateral and make sure you don't need an update", vbOKOnly, "Thanks")
        End If
    End Sub

    Private Sub OtherButton_Click(sender As Object, e As EventArgs) Handles OtherButton.Click
        Try
            If MsgBox("Have you verified all files are not found in the CIFR?", vbYesNo, "Please verify") = MsgBoxResult.Yes Then
            Else
                MsgBox("Please check through all files before asking for an update", vbOKOnly, "Thanks")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class