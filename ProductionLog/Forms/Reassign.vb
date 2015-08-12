Imports MySql.Data.MySqlClient
Imports System.Net.Mail

Public Class Reassign
    Dim SqlConnectionString As String = "Server=192.168.1.34; Database=TimeLogDB; User id=clerk; Password=12345;" 'NUC Database
    Dim EmpTable As New DataTable
    Dim FromTable As New DataTable

    Private Sub Reassign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If Clerk.QaJobsRadio.Checked = True Then
        '    QALabel.Visible = True
        'Else
        '    QALabel.Visible = False
        'End If
        'Clerk.Enabled = False
        'If Clerk.StartButton.Visible = True Then
        '    JobIdLabel.Text = Clerk.IDBox.Text
        'Else
        '    Dim Noder As TreeNode
        '    Noder = Clerk.JobTreeView.SelectedNode
        '    Dim ID As String() = Noder.Text.Split(New Char() {"-"})
        '    JobIdLabel.Text = ID(0)
        'End If

        Try 'Load the combo boxes
            Dim SqlString As String = "SELECT Empfirst,EmpID,Email from Employee"
            Dim SqlAdapt As New MySqlDataAdapter(SqlString, SqlConnectionString)
            SqlAdapt.Fill(EmpTable)
            'Dim FromString As String = "SELECT Empfirst from Employee WHERE Empid='" & Clerk.EmployeeID.Text & "'"
            'Dim FromAdapt As New MySqlDataAdapter(FromString, SqlConnectionString)
            'FromAdapt.Fill(FromTable)

            If EmpTable.Rows.Count > 0 Then
                For i = 0 To EmpTable.Rows.Count - 1
                    EmpComboBox.Items.Add(EmpTable.Rows(i)(0))
                Next
            End If
        Catch ex As Exception
            SendError.Show()
            SendError.EmpIDLabel.Text = "14"
            SendError.ErrorRTB.Text = ex.ToString
        End Try

    End Sub

    Private Sub EmpComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EmpComboBox.SelectedIndexChanged
        Try
            EmpIDBox.Text = EmpTable.Rows(EmpComboBox.SelectedIndex)(1)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Dim QA As Boolean = False
        If MsgBox("Are you sure you'd like to reassign?", vbYesNo, "Are you sure?") = MsgBoxResult.Yes Then
            If EmpIDBox.Text = "" Then
                MsgBox("Select someone to reassign to please", vbOKOnly, "Oops!")
                Exit Sub
            Else
                Try ' attempt to re-assign the job
                    Dim UpdateSql As String = ""
                    If QALabel.Visible = True Then
                        UpdateSql = "UPDATE QA set EmpID='" & EmpIDBox.Text & "' WHERE QAID='" & JobIdLabel.Text & "'"
                        QA = True
                    Else
                        UpdateSql = "UPDATE Workflow set EmpID='" & EmpIDBox.Text & "' WHERE JobID='" & JobIdLabel.Text & "'"
                        QA = False
                    End If
                    Using Connection As New MySqlConnection(SqlConnectionString)
                        Dim Command As New MySqlCommand(UpdateSql, Connection)
                        Connection.Open()
                        Command.ExecuteNonQuery()
                        Connection.Close()
                    End Using
                    ' Try
                    'Dim smtp_server As New SmtpClient
                    'Dim e_mail As New MailMessage()
                    'smtp_server.UseDefaultCredentials = False
                    'smtp_server.Credentials = New Net.NetworkCredential("ottoprimalend@gmail.com", "ottoprimalend1")
                    'smtp_server.Port = 587
                    'smtp_server.EnableSsl = True
                    'smtp_server.Host = "smtp.gmail.com"
                    '
                    '                    e_mail = New MailMessage
                    '                    e_mail.From = New MailAddress("ottoprimalend@gmail.com")
                    '                    e_mail.To.Add(EmpTable.Rows(EmpComboBox.SelectedIndex)(2))
                    '                    e_mail.CC.Add("gprudencio@primalend.com")
                    '                    e_mail.Subject = "Job re-assign!"
                    '                    e_mail.Priority = MailPriority.High
                    '                    e_mail.IsBodyHtml = False
                    '                    e_mail.Body = "Job: " & JobIdLabel.Text & " was re-assigned to: " & EmpComboBox.Text & " from: " & FromTable.Rows(0)(0)
                    '                    smtp_server.Send(e_mail)
                    '
                    '                    If QA = False Then
                    ' 'Clerk.JobList.Items.RemoveAt(Clerk.JobList.SelectedIndex)
                    ' Else
                    ' 'Clerk.QAList.Items.RemoveAt(Clerk.QAList.SelectedIndex)
                    ' End If
                    'Clerk.Refreshme()
                    Clerk.LoginSuccessTimer.Enabled = True
                    Clerk.Enabled = True
                    'Catch ex As Exception
                    '    MsgBox(ex.ToString)
                    'End Try
                    Me.Dispose()
                    Clerk.Refreshme()
                    Whiteboard.Refresher()
                Catch ex As Exception
                    SendError.Show()
                    SendError.EmpIDLabel.Text = "14"
                    SendError.ErrorRTB.Text = ex.ToString
                End Try
            End If
        End If
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        Clerk.Refreshme()
        Clerk.Enabled = True
        Me.Dispose()
    End Sub
End Class