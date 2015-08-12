Imports System.Net.Mail
Imports MySql.Data.MySqlClient
Imports OpenPop.Pop3
Imports OpenPop.Mime
Imports System.Text
Public Class TeamLead
    Dim SqlConnectionString As String = "Server=192.168.1.34; Database=TimeLogDB; User id=clerk; Password=12345;" 'NUC Database
    Dim SuccessSeconds As Integer = 0
    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Me.Dispose()
    End Sub

    Private Sub TeamLead_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EmpIDLabel.Text = Dashboard.IDLabel.Text
        BatchIDLabel.Text = "Manual(" & EmpIDLabel.Text & ")"
        Try 'Initial fill of the combo boxes, etc.
            Dim EmployeeTable As New DataTable
            Dim DealerTable As New DataTable
            Dim JobTypeTable As New DataTable
            Dim EmpQUery As String = "SELECT EmpID,EmpFirst from Employee"
            Dim DealerQuery As String = "SELECT Dealership from Dealername ORDER BY Dealership"
            Dim JobTypeQuery As String = "SELECT JobType from Jobname"
            Dim EmpAdapt As New MySqlDataAdapter(EmpQUery, SqlConnectionString)
            Dim DealerAdapt As New MySqlDataAdapter(DealerQuery, SqlConnectionString)
            Dim JobTypeAdapt As New MySqlDataAdapter(JobTypeQuery, SqlConnectionString)
            EmpAdapt.Fill(EmployeeTable)
            DealerAdapt.Fill(DealerTable)
            JobTypeAdapt.Fill(JobTypeTable)

            For i = 0 To EmployeeTable.Rows.Count - 1
                EmployeeComboBox.Items.Add(EmployeeTable.Rows(i)(0) & "-" & EmployeeTable.Rows(i)(1))
                OccurrenceEmployeeComboBox.Items.Add(EmployeeTable.Rows(i)(0) & "-" & EmployeeTable.Rows(i)(1))
            Next

            For i = 0 To DealerTable.Rows.Count - 1
                DealerComboBox.Items.Add(DealerTable.Rows(i)(0))
            Next

            For i = 0 To JobTypeTable.Rows.Count - 1
                JobComboBox.Items.Add(JobTypeTable.Rows(i)(0))
            Next

        Catch ex As Exception

        End Try

    End Sub

    Private Sub JobAssignButton_Click(sender As Object, e As EventArgs) Handles JobAssignButton.Click
        If DealerComboBox.Text = "" Or EmployeeComboBox.Text = "" Or JobComboBox.Text = "" Then
            Exit Sub
        End If
        Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")
        Dim NowTime As String = DateTime.Now.ToString("HH:mm:ss")
        Dim ToBeSplit As String = EmployeeComboBox.Text
        Dim Split As String() = ToBeSplit.Split(New Char() {"-"c})
        If MsgBox("Are you sure you'd like to assign " & JobComboBox.Text & " to " & Split(1), vbYesNo, "Are you sure?") = vbYes Then
            Try
                Dim AddQuery As String = "INSERT INTO Workflow (EmpID,BatchID,DateAssigned,TimeAssigned,Dealer,Job,Quantity,Comment) VALUES('" & Split(0) & "','" & BatchIDLabel.Text & "','" & NowDate & "','" & NowTime & "','" & DealerComboBox.Text & "','" & JobComboBox.Text & "','" & QuantityBox.Text & "','" & JobCommentBox.Text & "');"
                Using connection As New MySqlConnection(SqlConnectionString)
                    Dim Insert As New MySqlCommand(AddQuery, connection)
                    connection.Open()
                    Insert.ExecuteNonQuery()
                    connection.Close()
                End Using
                DealerComboBox.Text = ""
                JobComboBox.Text = ""
                EmployeeComboBox.Text = ""
                QuantityBox.Text = "1"
                JobCommentBox.Text = ""
                SuccessTimer.Enabled = True
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click

        Refreshme()


    End Sub

    Public Function Refreshme()
        Dim LogTable As New DataTable
        Dim Logquery As String = "SELECT EmpID,Empfirst from Employee where islogin='1' and isclockin='1' Order By Empfirst"
        Dim LogAdapt As New MySqlDataAdapter(Logquery, SqlConnectionString)
        Dim WorkflowTable As New DataTable
        Dim WFQuery As String = "SELECT Workflow.JobID,Workflow.Dealer,Employee.Empfirst,workflow.job,workflow.dateassigned,workflow.timestarted from Workflow inner join employee ON workflow.empid=employee.empid where datecompleted is null order by employee.empfirst"
        Dim QATable As New DataTable
        Dim QAQuery As String = "SELECT QA.QAID,QA.Dealership,Employee.Empfirst from QA inner join employee on qa.empid=employee.empid where timestarted is null and datecompleted is null order by employee.empfirst"
        Dim WFAdapt As New MySqlDataAdapter(WFQuery, SqlConnectionString)
        Dim QAAdapt As New MySqlDataAdapter(QAQuery, SqlConnectionString)
        Dim EmpTable As New DataTable
        Dim EmpQUery As String = "SELECT EmpID,EmpFirst,ismonitored from Employee order by empfirst"
        Dim EmpAdapt As New MySqlDataAdapter(EmpQUery, SqlConnectionString)
        WorkFlowList.Items.Clear()
        QAList.Items.Clear()
        OpenJobsList.Items.Clear()
        ClockAndLogList.Items.Clear()
        MonitorEmpList.Items.Clear()

        Try
            LogAdapt.Fill(LogTable)
            EmpAdapt.Fill(EmpTable)
            WFAdapt.Fill(WorkflowTable)
            QAAdapt.Fill(QATable)
            For i = 0 To WorkflowTable.Rows.Count - 1
                WorkFlowList.Items.Add(WorkflowTable.Rows(i)(0) & "-" & WorkflowTable.Rows(i)(1) & "-" & WorkflowTable.Rows(i)(2))
                If IsDBNull(WorkflowTable(i)(5)) Then
                    OpenJobsList.Items.Add(WorkflowTable.Rows(i)(2) & "-" & WorkflowTable.Rows(i)(0) & "-" & WorkflowTable.Rows(i)(1) & "-" & WorkflowTable.Rows(i)(3) & "-" & WorkflowTable.Rows(i)(4))
                Else
                    OpenJobsList.Items.Add(WorkflowTable.Rows(i)(2) & "-" & WorkflowTable.Rows(i)(0) & "-" & WorkflowTable.Rows(i)(1) & "-" & WorkflowTable.Rows(i)(3) & "-" & WorkflowTable.Rows(i)(4) & "-CURRENT JOB")
                End If

            Next
            For i = 0 To QATable.Rows.Count - 1
                QAList.Items.Add(QATable.Rows(i)(0) & "-" & QATable.Rows(i)(1) & "-" & QATable.Rows(i)(2))
            Next
            For i = 0 To EmpTable.Rows.Count - 1
                WFEmployeeList.Items.Add(EmpTable.Rows(i)(1) & "-" & EmpTable.Rows(i)(0))
                QAEmployeeList.Items.Add(EmpTable.Rows(i)(1) & "-" & EmpTable.Rows(i)(0))
                If EmpTable(i)(2) = "1" Then
                    MonitorEmpList.Items.Add(EmpTable.Rows(i)(1) & "-" & EmpTable.Rows(i)(0) & "-Team Lead")
                Else
                    MonitorEmpList.Items.Add(EmpTable.Rows(i)(1) & "-" & EmpTable.Rows(i)(0))
                End If

            Next
            For i = 0 To LogTable.Rows.Count - 1
                ClockAndLogList.Items.Add(LogTable.Rows(i)(1) & "-" & LogTable.Rows(i)(0))
            Next
        Catch ex As Exception
            SendError.Show()
            SendError.EmpIDLabel.Text = EmpIDLabel.Text
            SendError.ErrorRTB.Text = ex.ToString
        End Try

        Return Nothing
    End Function

    Private Sub EmpLastBox_TextChanged(sender As Object, e As EventArgs) Handles EmpLastBox.TextChanged

    End Sub

    Private Sub EmailBox_GotFocus(sender As Object, e As EventArgs) Handles EmailBox.GotFocus
        If EmpFirstBox.Text = "" Or EmpLastBox.Text = "" Then
            Exit Sub
        Else
            EmailBox.Text = EmpFirstBox.Text.Substring(0, 1) & EmpLastBox.Text & "@primalend.com"
        End If
    End Sub

    Private Sub EmailBox_TextChanged(sender As Object, e As EventArgs) Handles EmailBox.TextChanged

    End Sub

    Public Function MailIt(ByVal Subject As String, ByVal emailto As String, ByVal IsHTML As Boolean, Optional ByVal Body As String = "")
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
            e_mail.Subject = Subject
            e_mail.IsBodyHtml = IsHTML
            e_mail.Body = Body
            smtp_server.Send(e_mail)
            Otto.LogTextBox.AppendText(vbNewLine & "Sent an email to " & emailto & " @ " & TimeOfDay)
        Catch ex As Exception
            Otto.LogTextBox.AppendText(vbNewLine & "Couldn't send an email to " & emailto & " @ " & TimeOfDay)
        End Try
        Return Nothing
    End Function

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        If EmailBox.Text = "" Then
            Exit Sub
        End If
        Try
            FlatButton2.Enabled = False
            Dim InsertQuery As String = "INSERT INTO Employee (Empfirst,Emplast,Email) VALUES('" & EmpFirstBox.Text & "','" & EmpLastBox.Text & "','" & EmailBox.Text & "');"
            Using connection As New MySqlConnection(SqlConnectionString)
                Dim Command As New MySqlCommand(InsertQuery, connection)
                connection.Open()
                Command.ExecuteNonQuery()
                connection.Close()
            End Using
            MailIt("OTCMD #PIN PLEASE REPLY", EmailBox.Text, False, "-Please Reply to this email with your desired 6 to 8 digit PIN in the BODY of the email (only put the PIN number in the body please)")
            FlatButton2.Enabled = True
            EmpFirstBox.Text = ""
            EmpLastBox.Text = ""
            EmailBox.Text = ""
            SuccessTimer.Enabled = True
        Catch ex As Exception
            SendError.Show()
            SendError.EmpIDLabel.Text = EmpIDLabel.Text
            SendError.ErrorRTB.Text = ex.ToString
            FlatButton2.Enabled = True
        End Try
    End Sub

    Private Sub SuccessTimer_Tick(sender As Object, e As EventArgs) Handles SuccessTimer.Tick

        If SuccessSeconds > 6 Then
            SuccessLabel.Visible = False
            SuccessTimer.Stop()
            SuccessSeconds = 0
        Else
            SuccessLabel.Visible = True
            SuccessSeconds += 1
        End If
        

    End Sub

    Private Sub WFReassignButton_Click(sender As Object, e As EventArgs) Handles WFReassignButton.Click
        If WorkFlowList.SelectedIndex < 0 Then
            Exit Sub
        End If
        If MsgBox("Are you sure that you'd like to reassign these " & WorkFlowList.SelectedItems.Count & " jobs?", vbYesNo, "Are you sure?") = vbYes Then
            If WFEmployeeList.SelectedIndex > -1 Then
                Try
                    Dim u As Integer = 0
                    Dim EmpID As String = ""
                    Dim ToBeSplit As String = WFEmployeeList.SelectedItem
                    Dim Split As String() = ToBeSplit.Split(New Char() {"-"})
                    Dim Update(WorkFlowList.SelectedItems.Count) As String
                    EmpID = Split(1)
                    For Each JobID As String In WorkFlowList.SelectedItems
                        Dim JobSplit As String() = JobID.Split(New Char() {"-"})
                        Update(u) = "UPDATE Workflow set EmpID='" & EmpID & "' where JOBID='" & JobSplit(0) & "'"
                        u += 1
                    Next
                    Using connection As New MySqlConnection(SqlConnectionString)
                        connection.Open()
                        For i = 0 To Update.Count - 1
                            If Update(i) <> "" Then
                                'MsgBox(Update(i))
                                Dim command As New MySqlCommand(Update(i), connection)
                                command.ExecuteNonQuery()
                            End If
                        Next
                        connection.Close()
                    End Using
                    Refreshme()
                    SuccessTimer.Enabled = True
                Catch ex As Exception
                    SendError.Show()
                    SendError.EmpIDLabel.Text = EmpIDLabel.Text
                    SendError.ErrorRTB.Text = ex.ToString
                End Try
            Else
                MsgBox("Please select an employee to assign these jobs to.")
            End If
        End If

    End Sub

    Private Sub QAReassignButton_Click(sender As Object, e As EventArgs) Handles QAReassignButton.Click
        If QAList.SelectedIndex < 0 Then
            Exit Sub
        End If
        If MsgBox("Are you sure you want to re-assign these " & QAList.SelectedItems.Count & " QA jobs?", vbYesNo, "Are you sure?") = vbYes Then
            If QAEmployeeList.SelectedIndex > -1 Then
                Try
                    Dim u As Integer = 0
                    Dim EmpID As String = ""
                    Dim ToBeSplit As String = QAEmployeeList.SelectedItem
                    Dim Split As String() = ToBeSplit.Split(New Char() {"-"})
                    Dim Update(QAList.SelectedItems.Count) As String
                    EmpID = Split(1)
                    For Each JobID As String In QAList.SelectedItems
                        Dim JobSplit As String() = JobID.Split(New Char() {"-"})
                        Update(u) = "UPDATE QA set EmpID='" & EmpID & "' where QAID='" & JobSplit(0) & "'"
                        u += 1
                    Next
                    Using connection As New MySqlConnection(SqlConnectionString)
                        connection.Open()
                        For i = 0 To Update.Count - 1
                            If Update(i) <> "" Then
                                'MsgBox(Update(i))
                                Dim command As New MySqlCommand(Update(i), connection)
                                command.ExecuteNonQuery()
                            End If
                        Next
                        connection.Close()
                    End Using
                    Refreshme()
                    SuccessTimer.Enabled = True
                Catch ex As Exception
                    SendError.Show()
                    SendError.EmpIDLabel.Text = EmpIDLabel.Text
                    SendError.ErrorRTB.Text = ex.ToString
                End Try
            Else
                MsgBox("Please select an employee to assign these QA jobs to.")
            End If

        End If
    End Sub

    Private Sub OccurrenceButton_Click(sender As Object, e As EventArgs) Handles OccurrenceButton.Click
        If OccurrenceEmployeeComboBox.Text = "" Then
            Exit Sub
        End If
        If MsgBox("Are you sure you'd like to log this occurrence?", vbYesNo, "Are you sure?") = vbYes Then
            Try
                Dim Tobesplit As String = OccurrenceEmployeeComboBox.Text
                Dim Split As String() = Tobesplit.Split(New Char() {"-"})
                Dim Empid As String = Split(0)
                Dim Query As String = "INSERT INTO Occurrences (occurrencedate,occurrencetype,empid,comments,loggedby) VALUES('" & OccurrenceDate.Text & "','" & OccurrenceComboBox.Text & "','" & Empid & "','" & OccurrenceCommentBox.Text & "','" & EmpIDLabel.Text & "');"
                Using Connection As New MySqlConnection(SqlConnectionString)
                    Dim command As New MySqlCommand(Query, Connection)
                    Connection.Open()
                    command.ExecuteNonQuery()
                    Connection.Close()
                End Using
                SuccessTimer.Enabled = True

            Catch ex As Exception
                SendError.Show()
                SendError.EmpIDLabel.Text = EmpIDLabel.Text
                SendError.ErrorRTB.Text = ex.ToString
            End Try
        End If
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        Try
            Dim ToBeSplit As String = MonitorEmpList.SelectedItem
            Dim Split As String() = ToBeSplit.Split(New Char() {"-"})

            Dim UpdaetQuery As String = "UPDATE Employee Set isMonitored='1' where EmpID='" & Split(1) & "'"
            Using Connection As New MySqlConnection(SqlConnectionString)
                Dim command As New MySqlCommand(UpdaetQuery, Connection)
                Connection.Open()
                command.ExecuteNonQuery()
                Connection.Close()
            End Using
            Refreshme()
            SuccessTimer.Enabled = True
        Catch ex As Exception
            SendError.Show()
            SendError.EmpIDLabel.Text = EmpIDLabel.Text
            SendError.ErrorRTB.Text = ex.ToString
        End Try

    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click
        Try
            Dim ToBeSplit As String = MonitorEmpList.SelectedItem
            Dim Split As String() = ToBeSplit.Split(New Char() {"-"})

            Dim UpdaetQuery As String = "UPDATE Employee Set isMonitored='0' where EmpID='" & Split(1) & "'"
            Using Connection As New MySqlConnection(SqlConnectionString)
                Dim command As New MySqlCommand(UpdaetQuery, Connection)
                Connection.Open()
                command.ExecuteNonQuery()
                Connection.Close()
            End Using
            Refreshme()
            SuccessTimer.Enabled = True
        Catch ex As Exception
            SendError.Show()
            SendError.EmpIDLabel.Text = EmpIDLabel.Text
            SendError.ErrorRTB.Text = ex.ToString
        End Try
    End Sub
End Class