Imports System.Data.OleDb
Imports System.Text
Imports System.Net.Mail
Imports MySql.Data.MySqlClient

Public Class Otto
    Dim ETitleCheck As Boolean = True
    Dim TitleTeamCheck As Boolean = True
    Dim VerificationOut As Boolean = True

    Dim FindSeconds As Integer = 0
    Dim FindFillError As Boolean = False
    Dim BatchesFound As Boolean = False
    Dim BatchLog As Integer = 0
    Dim FirstBatch As Boolean = False
    Dim AssignSeconds As Integer = 0
    Dim AssignFillError As Boolean = False
    Dim CleanSeconds As Integer = 0

    Dim SuccessSeconds As Integer = 0

    Dim AppData As String = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Primalend\"
    Dim ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & AppData & "Timelogz.accdb" 'Local resource with links

    Dim SqlConnectionString As String = "Server=192.168.1.34; Database=TimeLogDB; User id=clerk; Password=12345;" 'NUC Database <--Being used now

    'Dim ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\pcpserver\pl_share\PrimaLend\Collateral Management\Updates\Timelog.accdb" 'Shared DB file

    Dim BatchTable As New DataTable

    Dim ClockTable As New DataTable
    Dim LogTable As New DataTable

    Dim EmptyOffice As Boolean = False

    Dim ClockLog As Boolean = False 'If they are clocked and logged in both
    Dim OnlyClock As Boolean = False 'If they are only clocked in
    Dim DontAssign As Boolean = False 'Don't assign if someone is entering collateral. It causes some major problems when Otto assigns a batch while it's being made.

    Private Sub OttoToggle_CheckedChanged(sender As Object) Handles OttoToggle.CheckedChanged
        If OttoToggle.Checked = True Then
            OttoThoughtPicture.Visible = True
            If TimeOfDay > "6:00:00 AM" And TimeOfDay < "9:00:00 PM" Then
                FindCurrentStatusLabel.Text = "Checking the database for new collateral"
            Else
                FindCurrentStatusLabel.Text = "Pondering the meaning of life"
            End If
            Brain3StatusLabel.Text = "Stretching legs"
            AssignCurrentStatusLabel.Text = "Warming up"
            OttoFindTimer.Enabled = True
            OttoAssignTimer.Enabled = True
            OttoBrain3Timer.Enabled = True
            TitleAuditTimer.Enabled = True
            Try
                Using connection As New MySqlConnection(SqlConnectionString)
                    Dim OnQuery As String = "UPDATE Employee SET isLogin=True,isClockIn=True WHERE EmpID=14"
                    Dim OnCommand As New MySqlCommand(OnQuery, connection)
                    connection.Open()
                    OnCommand.ExecuteNonQuery()
                    connection.Close()
                End Using
            Catch ex As Exception
                'Msgbox("Couldn't show Otto as running, please talk to your administrator " & ex.ToString)
                LogTextBox.AppendText(vbNewLine & "Couldn't update the employee table @ " & TimeOfDay)
            End Try
        Else
            OttoThoughtPicture.Visible = False
            FindCurrentStatusLabel.Text = "Off"
            AssignCurrentStatusLabel.Text = "Off"
            Brain3StatusLabel.Text = "Off"
            LoggedInList.Items.Clear()
            ClockedInList.Items.Clear()
            OttoFindTimer.Enabled = False
            OttoAssignTimer.Enabled = False
            OttoBrain3Timer.Enabled = False
            TitleAuditTimer.Enabled = False
            Try
                Using connection As New MySqlConnection(SqlConnectionString)
                    Dim OnQuery As String = "UPDATE Employee SET isLogin=False,isClockIn=False WHERE EmpID=14"
                    Dim OnCommand As New MySqlCommand(OnQuery, connection)
                    connection.Open()
                    OnCommand.ExecuteNonQuery()
                    connection.Close()
                End Using
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub OttoFindTimer_Tick(sender As Object, e As EventArgs) Handles OttoFindTimer.Tick

        If FindFillError = False Then
            Try 'Find if ANY batches have been logged TODAY
                Dim NowTime As String = DateTime.Now.ToString("HH:mm:ss")
                Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")

                Dim query As String = "SELECT * From Batch WHERE DateReceived=" & NowDate
                Dim query2 As String = "SELECT * from Workflow WHERE Job='Collateral Reception' AND DateAssigned='" & NowDate & "'"
                Dim query3 As String = "SELECT * from Workflow WHERE Job='Collateral Reception' AND TimeStarted IS NOT NULL AND TimeCompleted IS NULL"
                Dim currentadat As New MySqlDataAdapter(query3, SqlConnectionString)
                Dim currenttable As New DataTable
                currentadat.Fill(currenttable)
                Dim todayreceive As New MySqlDataAdapter(query2, SqlConnectionString)
                Dim receivetable As New DataTable
                todayreceive.Fill(receivetable)
                Dim todaybatch As New MySqlDataAdapter(query, SqlConnectionString)
                Dim TodayTable As New DataTable
                todaybatch.Fill(TodayTable)
                'If currenttable.Rows.Count > 0 Then 'This would make otto not work if someone was making batches. We can now dump the whole batch in at once, so it shouldn't matter.
                'BatchLog += 1
                'OttoAssignTimer.Stop()
                'FindCurrentStatusLabel.Text = "Someone is currently making batches. I'll wait.."
                'If BatchLog < 2 Then
                ' LogTextBox.AppendText(vbNewLine & currenttable.Rows(0)(1) & " currently making batches @ " & TimeOfDay)
                ' End If
                'OttoFindTimer.Interval = 5000
                'FindSeconds += 1
                'FindCycleLabel.Text = FindSeconds
                'Exit Sub
                'else
                BatchLog = 0
                OttoAssignTimer.Enabled = True
                'end if
                If TodayTable.Rows.Count > 0 Or receivetable.Rows.Count > 0 Then
                    FirstBatch = False
                Else
                    FirstBatch = True
                End If
            Catch ex As Exception
                'MsgBox("Otto is struggling with the following: " & ex.ToString)
                LogTextBox.AppendText(vbNewLine & "Otto is struggling to work with the Batch table @ " & TimeOfDay)
            End Try

            If TimeOfDay > "6:00:00 AM" And TimeOfDay < "9:00:00 PM" Then
                Try
                    Dim query As String = "select BatchID,Dealership, Collateral, count(Collateral) as Remaining from batch where isassigned=false GROUP BY batchid,dealership,collateral"
                    Dim BatchAdapt As New MySqlDataAdapter(query, SqlConnectionString)
                    If FindSeconds > 0 Then
                        BatchTable.Clear()
                        BatchAdapt.Fill(BatchTable)
                    Else
                        BatchAdapt.Fill(BatchTable) ' Fill the table
                    End If

                    If BatchTable.Rows.Count < 1 Then 'Count the rows, if less than 1 then there isn't anything to work with.
                        BatchesFound = False
                    Else
                        BatchesFound = True
                    End If
                Catch ex As Exception
                    FindFillError = True
                    FindCurrentStatusLabel.Text = "ERROR!"
                    LogTextBox.AppendText(vbNewLine & "Error finding batches @ " & TimeOfDay)
                End Try
                If BatchesFound = False Then
                    FindCurrentStatusLabel.Text = "Nothing found, I'll work on something else and check back"
                    'LogTextBox.AppendText(vbNewLine & "No batches found @ " & TimeOfDay)
                    OttoFindTimer.Interval = 5000
                Else
                    FindCurrentStatusLabel.Text = "Batches found (" & BatchTable.Rows.Count & "), prepping information for assignment!"
                    LogTextBox.AppendText(vbNewLine & BatchTable.Rows.Count & " batches found @ " & TimeOfDay)
                    OttoFindTimer.Interval = 1000
                    OttoAssignTimer.Enabled = True
                End If
            Else
                FindCurrentStatusLabel.Text = "Snoozing"
                OttoFindTimer.Interval = 10000
            End If
        Else
            FindCurrentStatusLabel.Text = "I had an error looking for the batch data!"
            LogTextBox.AppendText(vbNewLine & "Error looking for batch data @ " & TimeOfDay & " THIS WILL PAUSE THE MAIN TIMERS")
            OttoFindTimer.Stop()
            OttoAssignTimer.Stop()
            OttoBrain3Timer.Stop()
            'Msgbox("Error looking at the batch info. PAUSING")
        End If
        'Find out which workers are clocked in and which are online to eventually distribute the batches properly.
        Try
            ClockedInList.Items.Clear()
            LoggedInList.Items.Clear()
            Dim ClockQuery As String = "SELECT EmpID from TimeClock WHERE TimeOut IS NULL ORDER BY EmpID"
            Dim LogQuery As String = "SELECT EmpID from Employee WHERE IsLogIn=True ORDER BY EmpID"
            Dim ClockAdapt As New MySqlDataAdapter(ClockQuery, SqlConnectionString)
            Dim LogAdapt As New MySqlDataAdapter(LogQuery, SqlConnectionString)
            ClockTable.Clear()
            LogTable.Clear()
            ClockAdapt.Fill(ClockTable)
            LogAdapt.Fill(LogTable)

            If ClockTable.Rows.Count < 1 Then
                FindCurrentStatusLabel.Text = "Wondering why no one is clocked in"
                LogTextBox.AppendText(vbNewLine & "No one clocked in @ " & TimeOfDay)
                If ClockedInList.Items.Contains("No one") Then

                Else
                    ClockedInList.Items.Add("No one")
                End If
            Else
                ClockedInList.Items.Clear()
                For i = 0 To ClockTable.Rows.Count - 1
                    If ClockTable.Rows(i)(0) <> 14 Then
                        If ClockedInList.Items.Contains(ClockTable.Rows(i)(0)) Then
                            GoTo NOCLOCK
                        Else
                            ClockedInList.Items.Add(ClockTable.Rows(i)(0))
                        End If
                    End If
                Next
NOCLOCK:
            End If
            If LogTable.Rows.Count < 1 Then
                If EmptyOffice = False Then
                    FindCurrentStatusLabel.Text = "Doesn't look like anyone is on their queue."
                    EmptyOffice = True
                    LogTextBox.AppendText(vbNewLine & "No one logged in @ " & TimeOfDay)
                Else
                    GoTo NOLOG
                End If

            Else
                LoggedInList.Items.Clear()
                For i = 0 To LogTable.Rows.Count - 1
                    If LogTable.Rows(i)(0) <> 14 Then
                        If LoggedInList.Items.Contains(LogTable.Rows(i)(0)) Then
                            GoTo NOLOG
                        Else
                            LoggedInList.Items.Add(LogTable.Rows(i)(0))
                        End If
                    End If
                Next
NOLOG:
                EmptyOffice = False
            End If
        Catch ex As Exception
            'Msgbox(ex.ToString)
            LogTextBox.AppendText(vbNewLine & "Error checking to see if anyone is logged in or out @ " & TimeOfDay)
        End Try

        FindSeconds += 1
        FindCycleLabel.Text = FindSeconds
    End Sub

    Private Sub Otto_Load(sender As Object, e As EventArgs) Handles Me.Load
        If OttoToggle.Checked = False Then
            LoggedInList.Items.Clear()
            ClockedInList.Items.Clear()
            FindCurrentStatusLabel.Text = "Off"
            AssignCurrentStatusLabel.Text = "Off"
            Brain3StatusLabel.Text = "Off"
            LogTextBox.AppendText("Otto opened @ " & TimeOfDay)
        End If
    End Sub

    Private Sub OttoAssignTimer_Tick(sender As Object, e As EventArgs) Handles OttoAssignTimer.Tick
        Dim Primary As Boolean = False

        If BatchTable.Rows.Count < 1 Then
            AssignCurrentStatusLabel.Text = "Snoozing"
        Else
            AssignCurrentStatusLabel.Text = "Taking the batches out of the oven and making jobs!"
            LogTextBox.AppendText(vbNewLine & "Found batches @ " & TimeOfDay)
            Try
                OttoFindTimer.Stop()
                For i = 0 To BatchTable.Rows.Count - 1
                    Dim Query As String
                    If BatchTable.Rows(i)(2) = "Contracts" Or BatchTable.Rows(i)(2) = "Contract Modifications" Or BatchTable.Rows(i)(2) = "Contract Corrections" Then
                        Query = "select PrimaryContract,SecondaryContract from DealerName where Dealership='" & BatchTable.Rows(i)(1) & "'"
                    Else
                        Query = "select PrimaryTitle,SecondaryTitle from DealerName where Dealership='" & BatchTable.Rows(i)(1) & "'"
                    End If

                    Dim AssignTable As New DataTable
                    Dim AssignAdapt As New MySqlDataAdapter(Query, SqlConnectionString)
                    AssignAdapt.Fill(AssignTable)

                    Using AssignConnection As New MySqlConnection(SqlConnectionString)
                        'Check to see if the primary is clocked in AND logged in
                        Dim Empid As Integer
                        If ClockedInList.Items.Contains(AssignTable.Rows(0)(0)) And LoggedInList.Items.Contains(AssignTable.Rows(0)(0)) Then
                            Empid = AssignTable.Rows(0)(0)
                            Primary = True
                        ElseIf ClockedInList.Items.Contains(AssignTable.Rows(0)(1)) And LoggedInList.Items.Contains(AssignTable.Rows(0)(1)) Then
                            Empid = AssignTable.Rows(0)(1)
                            Primary = False
                        Else
                            Empid = 12
                        End If

                        Dim NowTime As String = DateTime.Now.ToString("HH:mm:ss")
                        Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")

                        Dim BatchID As String = BatchTable.Rows(i)(0)
                        Dim Dealer As String = BatchTable.Rows(i)(1)
                        Dim Job As String = "CIFR " & BatchTable.Rows(i)(2)
                        Dim Quantiy As Integer = BatchTable.Rows(i)(3)
                        Dim AssignQuery As String = "INSERT INTO WorkFlow (DateAssigned,TimeAssigned,EmpID,BatchID,Dealer,Job,Quantity) VALUES('" & NowDate & "','" & NowTime & "'," & Empid & ",'" & BatchID & "','" & Dealer & "','" & Job & "'," & Quantiy & ");"
                        Dim BatchAssignQuery As String = "UPDATE Batch SET isAssigned=True WHERE BatchID='" & BatchID & "'"
                        Dim BatchAssignCommand As New MySqlCommand(BatchAssignQuery, AssignConnection)
                        Dim AssignCommand As New MySqlCommand(AssignQuery, AssignConnection)
                        AssignConnection.Open()
                        AssignCommand.ExecuteNonQuery()
                        BatchAssignCommand.ExecuteNonQuery()
                        AssignConnection.Close()
                        If Primary = True Then
                            LogTextBox.AppendText(vbNewLine & "Job for batch: " & BatchID & " assigned to: " & Empid & " @ " & TimeOfDay)
                        Else
                            LogTextBox.AppendText(vbNewLine & "Job for batch: " & BatchID & " assigned to(secondary): " & Empid & " @ " & TimeOfDay)
                        End If

                    End Using
                Next
                OttoFindTimer.Enabled = True
                AssignCurrentStatusLabel.Text = "(" & BatchTable.Rows.Count & ") jobs assigned!"
                BatchTable.Clear()
            Catch ex As Exception
                AssignCurrentStatusLabel.Text = "ERROR"
                LogTextBox.AppendText(vbNewLine & "Error in assigning jobs:" & TimeOfDay)
                'Msgbox(ex.ToString)
            End Try

        End If
        'If FirstBatch = True Then 'If there haven't been any batches logged in for the day, set up a collateral reception job.
        'Try
        'Dim NowTime As String = DateTime.Now.ToString("HH:mm:ss")
        'Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")

        'Using Connection As New MySqlConnection(SqlConnectionString)
        ' Dim FirstQuery As String = "INSERT INTO WorkFlow (DateAssigned,Dealer,Job) VALUES ('" & NowDate & "','Primalend','Collateral Reception');"
        ' Dim FirstCommand As New MySqlCommand(FirstQuery, Connection)
        ' Connection.Open()
        ' FirstCommand.ExecuteNonQuery()
        ' Connection.Close()
        ' End Using
        ' FirstBatch = False
        ' Catch ex As Exception
        ' 'Msgbox("Otto had troulbe setting up the first reception job: " & ex.ToString)
        ' LogTextBox.AppendText(vbNewLine & "First reception job error " & TimeOfDay)
        ' End Try
        ' AssignCurrentStatusLabel.Text = "Just set up the first collateral reception job"
        ' LogTextBox.AppendText(vbNewLine & "First collateral job set up for the day @ " & TimeOfDay)
        ' End If
        AssignSeconds += 1
        AssignCycleLabel.Text = AssignSeconds
        OttoAssignTimer.Stop()
    End Sub

    Private Sub OttoBrain3Timer_Tick(sender As Object, e As EventArgs) Handles OttoBrain3Timer.Tick 'Clean up timer. Checks to see what is in Gina's "queue" and then re-assigns as necessary
        If TimeOfDay > "6:00:00 AM" And TimeOfDay < "5:00:00 PM" Then
            Brain3StatusLabel.Text = "Looking for items to clean up"
            Dim PrimaryOn As Boolean = False
            Dim SecondaryOn As Boolean = False
            Dim CheckQuery As String = "SELECT Dealer,Job,JobID from WorkFlow where EmpID=12 AND DateCompleted IS NULL"
            Dim CheckAdapt As New MySqlDataAdapter(CheckQuery, SqlConnectionString)
            Dim Checktable As New DataTable
            Dim PrimaryQuery As String = ""

            Try
                CheckAdapt.Fill(Checktable)

                If Checktable.Rows.Count < 1 Then
                    Brain3StatusLabel.Text = "Trying to find thumbs to tiwddle"
                Else
                    For i = 0 To Checktable.Rows.Count - 1
                        If Checktable.Rows(i)(1) = "CIFR Contracts" Or Checktable.Rows(i)(1) = "CIFR Contract Modifications" Or Checktable.Rows(i)(1) = "CIFR Contract Corrections" Or Checktable.Rows(i)(1) = "Verification" Then
                            PrimaryQuery = "Select PrimaryContract,SecondaryContract from Dealername Where Dealership='" & Checktable.Rows(i)(0) & "'"
                        Else
                            PrimaryQuery = "Select PrimaryTitle,SecondaryTitle from Dealername Where Dealership='" & Checktable.Rows(i)(0) & "'"
                        End If

                        Dim UpdateTable As New DataTable
                        Dim UpdateAdapt As New MySqlDataAdapter(PrimaryQuery, SqlConnectionString)
                        UpdateAdapt.Fill(UpdateTable)

                        Try
                            If LoggedInList.Items.Contains(UpdateTable.Rows(0)(0)) Then
                                PrimaryOn = True
                            Else
                                PrimaryOn = False
                            End If
                            If LoggedInList.Items.Contains(UpdateTable.Rows(0)(1)) Then
                                SecondaryOn = True
                            Else
                                SecondaryOn = False
                            End If
                        Catch ex As Exception
                            LogTextBox.AppendText(vbNewLine & "Error on brain3 checktable")
                        End Try

                        Dim Pint As Integer = 0
                        Dim Sint As Integer = 0

                        If PrimaryOn = False And SecondaryOn = False Then
                            GoTo Neither
                        Else
                            If PrimaryOn = True Then
                                Using Connection As New MySqlConnection(SqlConnectionString)
                                    Dim UpdateQuery As String = "UPDATE Workflow SET EmpID=" & UpdateTable.Rows(0)(0) & " WHERE JobID=" & Checktable.Rows(i)(2)
                                    Dim UpdateCommand As New MySqlCommand(UpdateQuery, Connection)
                                    Connection.Open()
                                    UpdateCommand.ExecuteNonQuery()
                                    Connection.Close()
                                End Using
                                Pint += 1
                                Brain3StatusLabel.Text = "Updated (" & Pint & ") Jobs to their primary clerks"
                                LogTextBox.AppendText(vbNewLine & "Updated job " & Checktable.Rows(i)(2) & " gave it to (primary) : " & UpdateTable.Rows(0)(1) & "@ " & TimeOfDay)
                            ElseIf SecondaryOn = True And PrimaryOn = False Then
                                Using Connection As New MySqlConnection(SqlConnectionString)
                                    Dim UpdateQuery As String = "UPDATE Workflow SET EmpID=" & UpdateTable.Rows(0)(1) & " WHERE JobID=" & Checktable.Rows(i)(2)
                                    Dim UpdateCommand As New MySqlCommand(UpdateQuery, Connection)
                                    Connection.Open()
                                    UpdateCommand.ExecuteNonQuery()
                                    Connection.Close()
                                End Using
                                Sint += 1
                                Brain3StatusLabel.Text = "Jobs assigned to secondary clerks (" & Sint & ")"
                                LogTextBox.AppendText(vbNewLine & "Updated job " & Checktable.Rows(i)(2) & " gave it to (secondary) : " & UpdateTable.Rows(0)(1) & "@ " & TimeOfDay)
                            End If
                        End If
Neither:

                    Next
                    CleanSeconds += 1
                    CleanCycleLabel.Text = CleanSeconds
                End If
            Catch ex As Exception
                'Msgbox("I couldn't do the following: " & ex.ToString)
                LogTextBox.AppendText(vbNewLine & "Error cleaning up (re assigning jobs from Gina) @ " & TimeOfDay)
            End Try
        Else
            Brain3StatusLabel.Text = "Looking for food"
        End If

    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Try 'Try to send an email with the LOG text

            Dim smtp_server As New SmtpClient
            Dim e_mail As New MailMessage()
            smtp_server.UseDefaultCredentials = False
            smtp_server.Credentials = New Net.NetworkCredential("ottoprimalend@gmail.com", "ottoprimalend1")
            smtp_server.Port = 587
            smtp_server.EnableSsl = True
            smtp_server.Host = "smtp.gmail.com"

            e_mail = New MailMessage
            e_mail.From = New MailAddress("ottoprimalend@gmail.com")
            e_mail.To.Add("jpennock@primalend.com")
            e_mail.Subject = "Log Export"
            e_mail.IsBodyHtml = False
            e_mail.Body = LogTextBox.Text
            smtp_server.Send(e_mail)
            SuccessTimer.Enabled = True
        Catch ex As Exception
            LogTextBox.AppendText(vbNewLine & "Couldn't export @ " & TimeOfDay)
        End Try
    End Sub

    Private Sub SuccessTimer_Tick(sender As Object, e As EventArgs) Handles SuccessTimer.Tick
        If SuccessSeconds > 5 Then
            SuccessTimer.Stop()
            SuccessLabel.Visible = False
        Else
            SuccessLabel.Visible = True
            SuccessSeconds += 1
        End If
    End Sub

    Private Sub MailButton_Click(sender As Object, e As EventArgs) Handles MailButton.Click
        OttoMail.Show()
    End Sub

    Private Sub OttoOverWatch_Tick(sender As Object, e As EventArgs)

    End Sub
    Public Function RefreshWatch(ByVal EmpID As String, Optional ByVal Email As String = "jpennock@primalend.com", Optional ByVal Name As String = "Test") 'used to refresh the overwatch portion (analyzing metrics)
        Dim TestRow As Integer = 0
        Dim MIDList As New List(Of String)
        Dim Results As String = "Test"
        Dim TestResults As New StringBuilder
        Dim StpWatch As New Stopwatch

        Try 'All of these items are adjustable. For example, changing the report to check for 7 days instead of thirty is as easy as changing the SQL query to do 7 day intervals
            StpWatch.Start()
            Dim WatchQuery As String = "SELECT EmpID,EmpFirst,email from employee WHERE isMonitored='1'"
            Dim WatchTable As New DataTable
            Dim Moniteradapt As New MySqlDataAdapter(WatchQuery, SqlConnectionString)
            Dim StartedJobQuery As String = "SELECT workflow.jobid,workflow.empid,workflow.batchid,workflow.dealer,workflow.job,workflow.quantity,time_to_sec(timediff(curtime(),workflow.timestarted))/60/60 as Hours,metrics.ItemsxHour FROM workflow inner join metrics on workflow.job = metrics.Job WHERE timestarted is not null and datecompleted is null order by workflow.empid"
            Dim StartedJobTable As New DataTable
            Dim FinishedJobQuery As String = "SELECT workflow.jobid,workflow.empid,workflow.batchid,workflow.dealer,workflow.job,workflow.quantity,time_to_sec(timediff(workflow.timecompleted,workflow.timestarted))/60/60 as Hours,metrics.ItemsxHour FROM workflow inner join metrics on workflow.job = metrics.Job WHERE timestarted is not null and datecompleted is not null and TimeCompleted is not null order by workflow.empid"
            Dim FinishedJobTable As New DataTable
            Dim FinishedJobAdapt As New MySqlDataAdapter(FinishedJobQuery, SqlConnectionString)
            Dim Jobadapt As New MySqlDataAdapter(StartedJobQuery, SqlConnectionString)
            'Metric Table
            Dim MetricQuery As String = "SELECT * From Metrics"
            Dim MetricTable As New DataTable
            Dim MetricAdapt As New MySqlDataAdapter(MetricQuery, SqlConnectionString)
            MetricAdapt.Fill(MetricTable)

            'Ocurrence table for 1 on 1
            Dim Occurrence As String = "Select OccurrenceDate,OccurrenceType,Comments From Occurrences where empid='" & EmpID & "'"
            Dim OccurrenceAdapt As New MySqlDataAdapter(Occurrence, SqlConnectionString)
            Dim OccurrenceTable As New DataTable
            OccurrenceAdapt.Fill(OccurrenceTable)

            'Time clock information.
            Dim TimeClock As String = "SELECT Employee.Empfirst,Timeclock.Timein,Timeclock.Timeout,Timediff(Timeclock.TimeOut,Timeclock.TimeIn) AS Hours,Timeclock.ClockDate From TimeClock INNER JOIN Employee ON Timeclock.EmpID=Employee.EmpID WHERE Employee.Empid='" & EmpID & "' AND TimeClock.ClockDate BETWEEN Date_Sub(Now(), INTERVAL 7 DAY) AND NOW();"
            Dim TimeAdapt As New MySqlDataAdapter(TimeClock, SqlConnectionString)
            Dim TimeTable As New DataTable
            TimeAdapt.Fill(TimeTable)

            'Separate metric queries
            Dim CIFRLateStart As String = "SELECT jobid,empid,Dealer,job,Quantity,DateAssigned,DateStarted from workflow where DateAssigned <> DateStarted and empid='" & EmpID & "' and job like '%cifr%' and workflow.datestarted between Date_sub(Now(), INTERVAL 30 DAY) AND NOW()" 'add time before 3 PM
            Dim CLateTable As New DataTable
            Dim Contract As String = "SELECT workflow.jobid,workflow.empid,workflow.batchid,workflow.dealer,workflow.job,workflow.quantity,time_to_sec(timediff(workflow.timecompleted,workflow.timestarted))/60/60 as Hours,metrics.ItemsxHour FROM workflow inner join metrics on workflow.job = metrics.Job WHERE timestarted is not null and datecompleted is not null and TimeCompleted is not null and workflow.job='CIFR Contracts' and quantity > 0 and empid='" & EmpID & "' and workflow.datestarted between Date_sub(Now(), INTERVAL 30 DAY) AND NOW() order by workflow.empid"
            Dim CTable As New DataTable
            Dim ContractTitle As String = "SELECT workflow.jobid,workflow.empid,workflow.batchid,workflow.dealer,workflow.job,workflow.quantity,time_to_sec(timediff(workflow.timecompleted,workflow.timestarted))/60/60 as Hours,metrics.ItemsxHour FROM workflow inner join metrics on workflow.job = metrics.Job WHERE timestarted is not null and datecompleted is not null and TimeCompleted is not null and workflow.job='CIFR Contract Titles' and quantity > 0 and empid='" & EmpID & "' and workflow.datestarted between Date_sub(Now(), INTERVAL 30 DAY) AND NOW() order by workflow.empid"
            Dim CTTable As New DataTable
            Dim FloorTitle As String = "SELECT workflow.jobid,workflow.empid,workflow.batchid,workflow.dealer,workflow.job,workflow.quantity,time_to_sec(timediff(workflow.timecompleted,workflow.timestarted))/60/60 as Hours,metrics.ItemsxHour FROM workflow inner join metrics on workflow.job = metrics.Job WHERE timestarted is not null and datecompleted is not null and TimeCompleted is not null and workflow.job='CIFR Floor Titles' and quantity > 0 and empid='" & EmpID & "' and workflow.datestarted between Date_sub(Now(), INTERVAL 30 DAY) AND NOW() order by workflow.empid"
            Dim FTTable As New DataTable
            Dim AuctionSlip As String = "SELECT workflow.jobid,workflow.empid,workflow.batchid,workflow.dealer,workflow.job,workflow.quantity,time_to_sec(timediff(workflow.timecompleted,workflow.timestarted))/60/60 as Hours,metrics.ItemsxHour FROM workflow inner join metrics on workflow.job = metrics.Job WHERE timestarted is not null and datecompleted is not null and TimeCompleted is not null and workflow.job='CIFR Auction Slips' and quantity > 0 and empid='" & EmpID & "' and workflow.datestarted between Date_sub(Now(), INTERVAL 30 DAY) AND NOW() order by workflow.empid"
            Dim ASTable As New DataTable
            Dim Labeling As String = "SELECT workflow.jobid,workflow.empid,workflow.batchid,workflow.dealer,workflow.job,workflow.quantity,time_to_sec(timediff(workflow.timecompleted,workflow.timestarted))/60/60 as Hours,metrics.ItemsxHour FROM workflow inner join metrics on workflow.job = metrics.Job WHERE timestarted is not null and datecompleted is not null and TimeCompleted is not null and workflow.job='Labeling' and quantity > 0 and empid='" & EmpID & "' and workflow.datestarted between Date_sub(Now(), INTERVAL 30 DAY) AND NOW() order by workflow.empid"
            Dim LTable As New DataTable
            Dim Filing As String = "SELECT workflow.jobid,workflow.empid,workflow.batchid,workflow.dealer,workflow.job,workflow.quantity,time_to_sec(timediff(workflow.timecompleted,workflow.timestarted))/60/60 as Hours,metrics.ItemsxHour FROM workflow inner join metrics on workflow.job = metrics.Job WHERE timestarted is not null and datecompleted is not null and TimeCompleted is not null and workflow.job='Filing' and quantity > 0 and empid='" & EmpID & "' and workflow.datestarted between Date_sub(Now(), INTERVAL 30 DAY) AND NOW() order by workflow.empid"
            Dim FTable As New DataTable
            Dim PullRequest As String = "SELECT workflow.jobid,workflow.empid,workflow.batchid,workflow.dealer,workflow.job,workflow.quantity,time_to_sec(timediff(workflow.timecompleted,workflow.timestarted))/60/60 as Hours,metrics.ItemsxHour FROM workflow inner join metrics on workflow.job = metrics.Job WHERE timestarted is not null and datecompleted is not null and TimeCompleted is not null and workflow.job='PUll Requests' and quantity > 0 and empid='" & EmpID & "' and workflow.datestarted between Date_sub(Now(), INTERVAL 30 DAY) AND NOW() order by workflow.empid"
            Dim PRTable As New DataTable
            Dim Verification As String = "SELECT workflow.jobid,workflow.empid,workflow.batchid,workflow.dealer,workflow.job,workflow.quantity,time_to_sec(timediff(workflow.timecompleted,workflow.timestarted))/60/60 as Hours,metrics.ItemsxHour FROM workflow inner join metrics on workflow.job = metrics.Job WHERE timestarted is not null and datecompleted is not null and TimeCompleted is not null and workflow.job='Verification' and quantity > 0 and empid='" & EmpID & "' and workflow.datestarted between Date_sub(Now(), INTERVAL 30 DAY) AND NOW() order by workflow.empid"
            Dim VTable As New DataTable
            Dim CollateralReception As String = "SELECT workflow.jobid,workflow.empid,workflow.batchid,workflow.dealer,workflow.job,workflow.quantity,time_to_sec(timediff(workflow.timecompleted,workflow.timestarted))/60/60 as Hours,metrics.ItemsxHour FROM workflow inner join metrics on workflow.job = metrics.Job WHERE timestarted is not null and datecompleted is not null and TimeCompleted is not null and workflow.job='Collateral Reception' and quantity > 0 and empid='" & EmpID & "' and workflow.datestarted between Date_sub(Now(), INTERVAL 30 DAY) AND NOW() order by workflow.empid"
            Dim CRTable As New DataTable

            TestResults.Append("<h3>Employee Analysis Report</h3><p><i>This report is still in beta testing</i><p><br><b>" & Name.Trim.ToUpperInvariant & "</b>'s results are as follows:")
            Dim Lateadapt As New MySqlDataAdapter(CIFRLateStart, SqlConnectionString)
            Lateadapt.Fill(CLateTable)
            Dim CAdapt As New MySqlDataAdapter(Contract, SqlConnectionString)
            CAdapt.Fill(CTable)
            Dim CTAdapt As New MySqlDataAdapter(ContractTitle, SqlConnectionString)
            CTAdapt.Fill(CTTable)
            Dim FTAdapt As New MySqlDataAdapter(FloorTitle, SqlConnectionString)
            FTAdapt.Fill(FTTable)
            Dim ASAdapt As New MySqlDataAdapter(AuctionSlip, SqlConnectionString)
            ASAdapt.Fill(ASTable)
            Dim LAdapt As New MySqlDataAdapter(Labeling, SqlConnectionString)
            LAdapt.Fill(LTable)
            Dim FAdapt As New MySqlDataAdapter(Filing, SqlConnectionString)
            FAdapt.Fill(FTable)
            Dim PRAdapt As New MySqlDataAdapter(PullRequest, SqlConnectionString)
            PRAdapt.Fill(PRTable)
            Dim VAdapt As New MySqlDataAdapter(Verification, SqlConnectionString)
            VAdapt.Fill(VTable)
            Dim CRAdapt As New MySqlDataAdapter(CollateralReception, SqlConnectionString)
            CRAdapt.Fill(CRTable)

            Dim LateTotal = 0
            Dim ContractTotal = 0
            Dim ContractSlow As Integer = 0
            Dim Contractitletotal As Integer = 0
            Dim ContractTitleSlow As Integer = 0
            Dim FloorTitleTotal As Integer = 0
            Dim FloorTitleSlow As Integer = 0
            Dim AuctionSlipTotal As Integer = 0
            Dim AuctionSlipSlow As Integer = 0
            Dim LabelingTotal As Integer = 0
            Dim LabelingSlow As Integer = 0
            Dim FilingTotal As Integer = 0
            Dim FIlingSlow As Integer = 0
            Dim PullTotal As Integer = 0
            Dim PullSlow As Integer = 0
            Dim VerificationTotal As Integer = 0
            Dim VerificationSlow As Integer = 0
            Dim CollateralTotal As Integer = 0
            Dim CollateralSlow As Integer = 0
            Dim ThirtyDays As DateTime = Now.AddDays(-CInt(30)).ToShortDateString

            TestResults.Append("<p><i>Data between " & ThirtyDays & " and Today (last 30 days)</i></p>")

            If CTable.Rows.Count > 0 Then
                ContractTotal = CTable.Rows.Count
                For i = 0 To CTable.Rows.Count - 1
                    Dim Qty As Double = CTable(i)(5)
                    Dim Hrs As Double = CTable(i)(6)
                    Dim Metric As Double = CTable(i)(7)
                    If Qty / Hrs < Metric Then
                        ContractSlow += 1
                    End If
                Next
                TestResults.Append("<p>Total CIFR Contract Jobs: " & ContractTotal & ".<br>Percentage that were performed <b>BELOW</b> the metric: " & Math.Round(ContractSlow / ContractTotal * 100, 2) & "%. <b>SCORE: </b>" & Math.Round(100 - (ContractSlow / ContractTotal * 100), 2) & "%</p>")
            End If
            If CTTable.Rows.Count > 0 Then
                Contractitletotal = CTTable.Rows.Count
                For i = 0 To CTTable.Rows.Count - 1
                    Dim Qty As Double = CTTable(i)(5)
                    Dim Hrs As Double = CTTable(i)(6)
                    Dim Metric As Double = CTTable(i)(7)
                    If Qty / Hrs < Metric Then
                        ContractTitleSlow += 1
                    End If
                Next
                TestResults.Append("<p>Total CIFR Contract Title Jobs: " & Contractitletotal & ".<br>Percentage that were performed <b>BELOW</b> the metric: " & Math.Round(ContractTitleSlow / Contractitletotal * 100, 2) & "%. <b>SCORE: </b>" & Math.Round(100 - (ContractTitleSlow / Contractitletotal * 100), 2) & "%</p>")
            End If
            If FTTable.Rows.Count > 0 Then
                FloorTitleTotal = FTTable.Rows.Count
                For i = 0 To FTTable.Rows.Count - 1
                    Dim Qty As Double = FTTable(i)(5)
                    Dim Hrs As Double = FTTable(i)(6)
                    Dim Metric As Double = FTTable(i)(7)
                    If Qty / Hrs < Metric Then
                        FloorTitleSlow += 1
                    End If
                Next
                TestResults.Append("<p>Total CIFR Floor Title Jobs: " & FloorTitleTotal & ".<br>Percentage that were performed <b>BELOW</b> the metric: " & Math.Round(FloorTitleSlow / FloorTitleTotal * 100, 2) & "%. <b>SCORE: </b>" & Math.Round(100 - (FloorTitleSlow / FloorTitleTotal * 100), 2) & "%</p>")
            End If
            If ASTable.Rows.Count > 0 Then
                AuctionSlipTotal = ASTable.Rows.Count
                For i = 0 To ASTable.Rows.Count - 1
                    Dim Qty As Double = ASTable(i)(5)
                    Dim Hrs As Double = ASTable(i)(6)
                    Dim Metric As Double = ASTable(i)(7)
                    If Qty / Hrs < Metric Then
                        AuctionSlipSlow += 1
                    End If
                Next
                TestResults.Append("<p>Total CIFR Auction Slip Jobs: " & AuctionSlipTotal & ".<br>Percentage that were performed <b>BELOW</b> the metric: " & Math.Round(AuctionSlipSlow / AuctionSlipTotal * 100, 2) & "%. <b>SCORE: </b>" & Math.Round(100 - (AuctionSlipSlow / AuctionSlipTotal * 100), 2) & "%.</p>")
            End If
            If LTable.Rows.Count > 0 Then
                LabelingTotal = LTable.Rows.Count
                For i = 9 To LTable.Rows.Count - 1
                    Dim Qty As Double = LTable(i)(5)
                    Dim Hrs As Double = LTable(i)(6)
                    Dim Metric As Double = LTable(i)(7)
                    If Qty / Hrs < Metric Then
                        LabelingSlow += 1
                    End If
                Next
                TestResults.Append("<p>Total Labeling Jobs: " & LabelingTotal & ".<br>Percentage that were performed <b>BELOW</b> the metric: " & Math.Round(LabelingSlow / LabelingTotal * 100, 2) & "%. <b>SCORE: </b>" & Math.Round(100 - (LabelingSlow / LabelingTotal * 100), 2) & "%.</p>")
            End If
            If FTable.Rows.Count > 0 Then
                FilingTotal = FTable.Rows.Count
                For i = 0 To FTable.Rows.Count - 1
                    Dim Qty As Double = FTable(i)(5)
                    Dim Hrs As Double = FTable(i)(6)
                    Dim Metric As Double = FTable(i)(7)
                    If Qty / Hrs < Metric Then
                        FIlingSlow += 1
                    End If
                Next
                TestResults.Append("<p>Total Filing Jobs: " & FilingTotal & ".<br>Percentage that were performed <b>BELOW</b> the metric: " & Math.Round(FIlingSlow / FilingTotal * 100, 2) & "%. <b>SCORE: </b>" & Math.Round(100 - (FIlingSlow / FilingTotal * 100), 2) & "%.</p>")
            End If
            If PRTable.Rows.Count > 0 Then
                PullTotal = PRTable.Rows.Count
                For i = 0 To PRTable.Rows.Count - 1
                    Dim Qty As Double = PRTable(i)(5)
                    Dim Hrs As Double = PRTable(i)(6)
                    Dim Metric As Double = PRTable(i)(7)
                    If Qty / Hrs < Metric Then
                        PullSlow += 1
                    End If
                Next
                TestResults.Append("<p>Total Pull Request Jobs: " & PullTotal & ".<br>Percentage that were performed <b>BELOW</b> the metric: " & Math.Round(PullSlow / PullTotal * 100, 2) & "%. <b>SCORE: </b>" & Math.Round(100 - (PullSlow / PullTotal * 100), 2) & "%.</p>")
            End If
            If VTable.Rows.Count > 0 Then
                VerificationTotal = VTable.Rows.Count
                For i = 0 To VTable.Rows.Count - 1
                    Dim Qty As Double = VTable(i)(5)
                    Dim Hrs As Double = VTable(i)(6)
                    Dim Metric As Double = VTable(i)(7)
                    If Qty / Hrs < Metric Then
                        VerificationSlow += 1
                    End If
                Next
                TestResults.Append("<p>Total Verification Jobs: " & VerificationTotal & ".<br>Percentage that were performed <b>BELOW</b> the metric: " & Math.Round(VerificationSlow / VerificationTotal * 100, 2) & "%. <b>SCORE: </b>" & Math.Round(100 - (VerificationSlow / VerificationTotal * 100), 2) & "%.</p>")
            End If
            If CRTable.Rows.Count > 0 Then
                CollateralTotal = CRTable.Rows.Count
                For i = 0 To CRTable.Rows.Count - 1
                    Dim Qty As Double = CRTable(i)(5)
                    Dim Hrs As Double = CRTable(i)(6)
                    Dim Metric As Double = CRTable(i)(7)
                    If Qty / Hrs < Metric Then
                        CollateralSlow += 1
                    End If
                Next
                TestResults.Append("<p>Total Collateral Reception Jobs: " & CollateralTotal & ".<br>Percentage that were performed <b>BELOW</b> the metric: " & Math.Round(CollateralSlow / CollateralTotal * 100, 2) & "%. <b>SCORE: </b>" & Math.Round(100 - (CollateralSlow / CollateralTotal * 100), 2) & "%.</p>")
            End If
            If CLateTable.Rows.Count > 0 Then
                LateTotal = CLateTable.Rows.Count
                TestResults.Append("<p>Total CIFR Jobs that were started 1 or more days after assignment: " & LateTotal & "</p>")
            End If
            If TimeTable.Rows.Count > 0 Then
                TestResults.Append("<br><h3>Time Clock</h3><p><i>Last 7 days</i></p><p>")
                TestResults.Append("<Table style=""width:45%"">")
                TestResults.Append("<th>Time In</th><th>Time Out</th><th>Hours</th><th>Clock Date</th>")
                For i = 0 To TimeTable.Rows.Count - 1
                    TestResults.Append("<tr><td>" & TimeTable(i)(1).ToString & "</td><td>" & TimeTable(i)(2).ToString & "</td><td>" & TimeTable(i)(3).ToString & "</td><td>" & TimeTable(i)(4) & "</td><td>")
                Next
                TestResults.Append("</table>")
            End If
            If OccurrenceTable.Rows.Count > 0 Then
                TestResults.Append("<br><h3>Logged Occurrences:</h3><p>")
                TestResults.Append("<Table style=""width:50%"">")
                For i = 0 To OccurrenceTable.Rows.Count - 1
                    TestResults.Append("<tr><td>" & OccurrenceTable(i)(0) & "</td><td>" & OccurrenceTable(i)(1) & "</td><td>" & OccurrenceTable(i)(2) & "</td>")
                Next
                TestResults.Append("</table>")
            End If
            ' TestResults.Append("<h3>Metrics:</h3>")
            'If MetricTable.Rows.Count > 0 Then
            'TestResults.Append("<Table style=""width:45%"">")
            'TestResults.Append("<th>Job</th><th>Minutes Per Item</th><th>Items per Hour</th>")
            'For i = 0 To MetricTable.Rows.Count - 1
            ' TestResults.Append("<tr><td>" & MetricTable(i)(1) & "</td><td>" & MetricTable(i)(2) & "</td><td>" & MetricTable(i)(3) & "</td>")
            ' Next
            ' TestResults.Append("</table>")
            ' End If

            StpWatch.Stop()
            TestResults.Append("<br><br><h3>Thanks for using this report.</h3><br><p><i>Please send an email to timelog@primalend.com with suggestions and comments. This report took " & StpWatch.ElapsedMilliseconds & " milliseconds to run</i></p>")

            Moniteradapt.Fill(WatchTable) 'Who is being monitored?
            Jobadapt.Fill(StartedJobTable) 'How many hours have jobs been running (that aren't finished) (today)?
            FinishedJobAdapt.Fill(FinishedJobTable) 'How many hours did jobs take (today)?
            'MetricAdapt.Fill(MetricTable) 'What are the metrics?
            If WatchTable.Rows.Count < 1 Then
                Return Nothing
                Exit Function
            Else
                Try 'Now do something with this information - 
                    MonitorList.Items.Clear()
                    OKList.Items.Clear()
                    SLOWList.Items.Clear()
                    For i = 0 To WatchTable.Rows.Count - 1
                        MonitorList.Items.Add(WatchTable(i)(0) & "-" & WatchTable(i)(1))
                        MIDList.Add(WatchTable(i)(0))
                    Next
                    For i = 0 To StartedJobTable.Rows.Count - 1
                        Dim Quantity As Double = StartedJobTable(i)(5)
                        Dim Hours As Double = StartedJobTable(i)(6)
                        Dim FastorSlow As Double = Quantity / Hours
                        If FastorSlow >= StartedJobTable(i)(7) Then
                            OKList.Items.Add(StartedJobTable(i)(1) & "-" & StartedJobTable(i)(0) & "-S")
                        Else
                            SLOWList.Items.Add(StartedJobTable(i)(1) & "-" & StartedJobTable(i)(0) & "-S")
                        End If
                    Next
                    For i = 0 To FinishedJobTable.Rows.Count - 1
                        Dim Quantity As Double = FinishedJobTable(i)(5)
                        Dim Hours As Double = FinishedJobTable(i)(6)
                        Dim FastorSlow As Double = Quantity / Hours
                        'MsgBox(FastorSlow & " VS " & FinishedJobTable(i)(7))
                        If FastorSlow >= FinishedJobTable(i)(7) Then
                            OKList.Items.Add(FinishedJobTable(i)(1) & "-" & FinishedJobTable(i)(0) & "-C")
                        Else
                            SLOWList.Items.Add(FinishedJobTable(i)(1) & "-" & FinishedJobTable(i)(0) & "-C")
                        End If
                        TestRow += 1
                    Next
                    Dim OKCount As Integer = 0
                    Dim SlowCount As Integer = 0
                    For i = 0 To OKList.Items.Count - 1
                        Dim Tobesplit As String = OKList.Items(i)
                        Dim Split As String() = Tobesplit.Split(New Char() {"-"c})
                        If Split(0) = EmpID Then
                            OKCount += 1
                        End If
                    Next
                    For i = 0 To SLOWList.Items.Count - 1
                        Dim Tobesplit As String = SLOWList.Items(i)
                        Dim Split As String() = Tobesplit.Split(New Char() {"-"c})
                        If Split(0) = EmpID Then
                            SlowCount += 1
                        End If
                    Next
                    Dim Total As Integer = SlowCount + OKCount
                    Results = "<h3>Hello</h3><p>Total workflow jobs for <b>" & Name & ": " & Total & ".</b><br>Percentage of jobs that performed <b>BELOW</b> metrics: <b>" & Math.Round(SlowCount / Total * 100, 2) & "%</b>"
                Catch ex As Exception
                    MsgBox(ex.ToString & " @ row " & TestRow)
                    LogTextBox.AppendText(vbNewLine & "had trouble showing how everyone is doing @ " & TimeOfDay)
                End Try
            End If
            If EmpID = 1 Then
            Else
                OttoMail.MailIt(TestResults.ToString, Email, True)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            LogTextBox.AppendText(vbNewLine & "had an issue with my overwatch ability (filling the tables) @ " & TimeOfDay)
        End Try
        Return Nothing
    End Function

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        RefreshWatch(1, "jpennock@primalend.com", "joe") 'test the watch thingy
    End Sub

    Private Sub TitleAuditTimer_Tick(sender As Object, e As EventArgs) Handles TitleAuditTimer.Tick
        If ETitleCheck = False Then 'Set up the e-title check jobs 2 days before the BB (I think sending them to GINA will work best, then whoever logs on first PRIMARY or SECONDARY will get the job and can re-assign from there)
            Try
                Dim Todayint As Integer = DateTime.Today.DayOfWeek 'day of the week in integer form (0-6)
                Dim Query As String = "SELECT Dealership,schedule,isetitle,titleauditcomplete from Dealername where isetitle='1' and titleauditcomplete='1'"
                Dim Table As New DataTable
                Dim Adapt As New MySqlDataAdapter(Query, SqlConnectionString)
                Adapt.Fill(Table)
                If Table.Rows.Count > 0 Then
                    For i = 0 To Table.Rows.Count - 1
                        If Table(i)(1) = "0" Then
                            If Todayint = 1 Then
                                Dim NowTime As String = DateTime.Now.ToString("HH:mm:ss")
                                Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")
                                Dim InsertZero As String = "INSERT INTO Workflow (EmpID,BatchID,DateAssigned,TimeAssigned,Dealer,Job,Quantity) VALUES('12','EVerify(" & Todayint & ")','" & NowDate & "','" & NowTime & "','" & Table(i)(0) & "','Title Verifications','1');"
                                Using Connection As New MySqlConnection(SqlConnectionString)
                                    Dim Command As New MySqlCommand(InsertZero, Connection)
                                    Connection.Open()
                                    Command.ExecuteNonQuery()
                                    Connection.Close()
                                End Using
                            End If
                        ElseIf Todayint = Table(i)(1) - 2 Then
                            Dim NowTime As String = DateTime.Now.ToString("HH:mm:ss")
                            Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")
                            Dim InsertOther As String = "INSERT INTO Workflow (EmpID,BatchID,DateAssigned,TimeAssigned,Dealer,Job,Quantity"
                        End If
                    Next
                End If
                LogTextBox.AppendText(vbNewLine & "assigned e-title verification jobs @ " & TimeOfDay)
                ETitleCheck = True
            Catch ex As Exception
                LogTextBox.AppendText(vbNewLine & "couldn't assign e-title review job @ " & TimeOfDay)
            End Try
        Else
            If TimeOfDay = "12:00:00 AM" Then
                ETitleCheck = False
            End If
        End If
        If TitleTeamCheck = False Then 'set up jobs for the title team to check the google drive for any request from dealerships to do TMRs
            Try
                Dim NowTime As String = DateTime.Now.ToString("HH:mm:ss")
                Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")
                Dim TeamInsert As String = "INSERT INTO Workflow (Empid,DateAssigned,TimeAssigned,Job,Dealer,Quantity) Values('2','" & NowDate & "','" & NowTime & "','Check Google Drive','Primalend','1'),('9','" & NowDate & "','" & NowTime & "','Check Google Drive','Primalend','1'),('13','" & NowDate & "','" & NowTime & "','Check Google Drive','Primalend','1');"
                Using Connection As New MySqlConnection(SqlConnectionString)
                    Dim Command As New MySqlCommand(TeamInsert, Connection)
                    Connection.Open()
                    Command.ExecuteNonQuery()
                    Connection.Close()
                End Using
                TitleTeamCheck = True
                LogTextBox.AppendText(vbNewLine & "set up the title team's Google Drive Check job @ " & TimeOfDay)
            Catch ex As Exception
                MsgBox(ex.ToString)
                LogTextBox.AppendText(vbNewLine & "had trouble with the title team's job set up @ " & TimeOfDay)
            End Try
        Else
            If TimeOfDay = "12:00:00 AM" Then
                Try
                    TitleTeamCheck = False
                Catch ex As Exception

                End Try
            End If
        End If
        If VerificationOut = False Then 'set up the verifications for the borrowing bases (1 day before the borrowing base)
            Try
                Dim QueryBuilt As New StringBuilder
                Dim DayInt As Integer = DateTime.Today.DayOfWeek
                Dim CheckDayInt As Integer = 0
                If DayInt + 1 = 7 Then
                    CheckDayInt = 0
                Else
                    CheckDayInt = DayInt + 1
                End If
                LogTextBox.AppendText(vbNewLine & "checkdayint = " & CheckDayInt)
                Dim VerifyQuery As String = "Select Dealership,schedule from dealername where isactive='1' and schedule='" & CheckDayInt & "'"
                Dim VerifyTable As New DataTable
                Dim VerifyAdapt As New MySqlDataAdapter(VerifyQuery, SqlConnectionString)
                VerifyAdapt.Fill(VerifyTable)
                Dim NowTime As String = DateTime.Now.ToString("HH:mm:ss")
                Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")
                'LogTextBox.AppendText(vbNewLine & "Filled the table. and it has " & VerifyTable.Rows.Count & " rows")
                If VerifyTable.Rows.Count > 0 Then
                    QueryBuilt.Append("INSERT INTO Workflow (EmpID,Dealer,Job,DateAssigned,TimeAssigned,Quantity,BatchID) Values")
                    For i = 0 To VerifyTable.Rows.Count - 1
                        If i = VerifyTable.Rows.Count - 1 Then
                            QueryBuilt.Append("('12','" & VerifyTable(i)(0) & "','" & "Verification','" & NowDate & "','" & NowTime & "','1','Verify(" & CheckDayInt & ")');")
                        Else
                            QueryBuilt.Append("('12','" & VerifyTable(i)(0) & "','" & "Verification','" & NowDate & "','" & NowTime & "','1','Verify(" & CheckDayInt & ")'),")
                        End If
                    Next
                    Using Connection As New MySqlConnection(SqlConnectionString)
                        Dim Command As New MySqlCommand(QueryBuilt.ToString, Connection)
                        Connection.Open()
                        Command.ExecuteNonQuery()
                        LogTextBox.AppendText(vbNewLine & QueryBuilt.ToString)
                        Connection.Close()
                    End Using
                    LogTextBox.AppendText(vbNewLine & "Set up the verifications ")
                End If
                VerificationOut = True
            Catch ex As Exception
                MsgBox(ex.ToString)
                LogTextBox.AppendText(vbNewLine & "couldn't set up verifications @ " & TimeOfDay)
            End Try
        Else
            If TimeOfDay = "12:00:00 AM" Then
                VerificationOut = False
            End If
        End If
    End Sub
End Class