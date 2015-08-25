Imports System
Imports System.IO
Imports System.Collections
Imports System.Text
Imports System.Data.OleDb
Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Imports System.Threading
Imports System.Net.Mail

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
                    JobCheckListBox.Items.Add(JobTable.Rows(i)(0).ToString & "-" & JobTable.Rows(i)(1).ToString & "-" & JobTable.Rows(i)(3) & "-" & JobTable.Rows(i)(4).ToString & "-" & JobTable.Rows(i)(5).ToString, True)
                Next
            ElseIf JobTable.Rows.Count < 2 Then 'Only one job? throw it in there too.
                For i = 0 To JobTable.Rows.Count - 1
                    JobCheckListBox.Items.Add(JobTable.Rows(i)(0).ToString & "-" & JobTable.Rows(i)(1).ToString & "-" & JobTable.Rows(i)(3) & "-" & JobTable.Rows(i)(4).ToString & "-" & JobTable.Rows(i)(5).ToString, True)
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
                'MsgBox(QueryBuilt.ToString)
                Using connector As New MySqlConnection(SqlConnectionString)
                    Dim updatecommand As New MySqlCommand(QueryBuilt.ToString, connector)
                    connector.Open()
                    updatecommand.ExecuteNonQuery()
                    connector.Close()
                End Using
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Please review the collateral and make sure you don't need an update", vbOKOnly, "Thanks")
        End If
    End Sub

    Private Sub OtherButton_Click(sender As Object, e As EventArgs) Handles OtherButton.Click
        ShowQuery.Show()
    End Sub

    Public Function MailIt(ByVal Body As String, ByVal emailto As String, ByVal IsHTML As Boolean)
        Try 'Try to send an email with the command results..

            Dim smtp_server As New SmtpClient
            Dim e_mail As New MailMessage()
            smtp_server.UseDefaultCredentials = False
            smtp_server.Credentials = New Net.NetworkCredential("ottoprimalend@gmail.com", "ottoprimalend1")
            smtp_server.Port = 587
            smtp_server.EnableSsl = True
            smtp_server.Host = "smtp.gmail.com"

            e_mail = New MailMessage
            e_mail.From = New MailAddress("ottoprimalend@gmail.com")
            e_mail.To.Add(emailto)
            e_mail.Subject = "Update Request"
            e_mail.IsBodyHtml = IsHTML
            e_mail.Body = Body
            smtp_server.Send(e_mail)
            'Otto.LogTextBox.AppendText(vbNewLine & "Sent an email to " & emailto & " @ " & TimeOfDay)
        Catch ex As Exception
            'Otto.LogTextBox.AppendText(vbNewLine & "Couldn't send an email to " & emailto & " @ " & TimeOfDay)
        End Try
        Return Nothing
    End Function

End Class