Imports System.Net.Mail
Imports MySql.Data.MySqlClient
Imports OpenPop.Pop3
Imports OpenPop.Mime
Imports System.Text
Imports System.IO
Imports System


Public Class OttoMail
    Dim MailSeconds As Integer = 0
    Dim DTMessage As New DataTable
    Dim SqlConnectionString As String = "Server=192.168.1.34; Database=TimeLogDB; User id=clerk; Password=12345;" 'NUC Database
    Dim ConnectionSchema As String = "server=192.168.1.34; Database=information_schema; User id=clerk; Password=12345" 'Schema to grab just the table names and columns (NOT USED)
    Dim ReturnCList As New List(Of String)() 'required for checkmail returns the command to the emails listed
    Dim BodyCList As New List(Of String)() 'required for checkmail gives the body of the email for command parsing

    Private Sub OttoMail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTMessage.Columns.Add("MessageNumber")
        DTMessage.Columns.Add("From")
        DTMessage.Columns.Add("Subject")
        DTMessage.Columns.Add("DateSent")
        DTMessage.Columns.Add("Body")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If MailSeconds >= 60 Then
            MailSeconds = 0
            CheckMail()
            CommandTimer.Enabled = True
            BBTimer.Enabled = True
        End If
        Try

        Catch ex As Exception

        End Try
        MailSeconds += 1
    End Sub
    Public Function CheckMail() '2 public variables required for this function, see above
        'If these are not passed (to check if the network is up) then it will skip the mail check process. Hopefully cutting back on error popups
        Dim ConnCheck As New MySqlConnection(SqlConnectionString)
        Dim ConnOpen As Boolean = False
        ConnCheck.Open()
        ConnOpen = ConnCheck.State()
        ConnCheck.Close()
        If ConnOpen = False Then
            Otto.LogTextBox.AppendText(vbNewLine & "Couldn't check mail due to lack of connection to the database. @ " & TimeOfDay)
            Return Nothing
            Exit Function
        End If
        If My.Computer.Network.Ping("192.168.1.10") Then
        Else
            Otto.LogTextBox.AppendText(vbNewLine & "Couldn't check mail due to lack of connection to the network (attempted to conact the fileserver). @ " & TimeOfDay)
            Return Nothing
            Exit Function
        End If
        'If these pass, then go on with the mail checking.
        Try
            ReturnCList.Clear()
            BodyCList.Clear()

            DTMessage.Clear()
            Dim Client As Pop3Client = New Pop3Client()
            Client.Connect("pop.gmail.com", 995, True)
            Client.Authenticate("ottoprimalend@gmail.com", "ottoprimalend1") 'very unsafe keeping the password hardcoded in.. tisk tisk...
            Dim MessageCount As Integer = Client.GetMessageCount()
            Dim StringToSplit As String = ""
            MCountLabel.Text = "Looks like I've got " & MessageCount & " messages."

            Dim Counter As Integer = 0
            Dim I As Integer = MessageCount
            Do While (I >= 1)
                Dim Message As Message = Client.GetMessage(I)
                Dim Body As MessagePart = Message.FindFirstPlainTextVersion()
                Dim DerString As String = ""
                If Body IsNot Nothing Then
                    DerString = Body.GetBodyAsText()
                Else
                    Body = Message.FindFirstHtmlVersion()
                    If Body IsNot Nothing Then
                        DerString = Body.GetBodyAsText()
                    End If
                End If

                DTMessage.Rows.Add()
                DTMessage.Rows((DTMessage.Rows.Count - 1))(0) = I
                DTMessage.Rows((DTMessage.Rows.Count - 1))(1) = Message.Headers.From.Address
                DTMessage.Rows((DTMessage.Rows.Count - 1))(2) = Message.Headers.Subject
                DTMessage.Rows((DTMessage.Rows.Count - 1))(3) = Message.Headers.DateSent
                DTMessage.Rows((DTMessage.Rows.Count - 1))(4) = DerString

                Dim emailA As String = ""
                Dim thefolder As String = "P:\Treasury Management\Funding\" & "20150806" & "\" & Message.Headers.From.Address.ToString & " " & Message.Headers.Subject & "\"
                'MsgBox(thefolder)
                'IF the email is TO a certain address (sent to a certain distribution list) then do the following:
                'funding@primalend.com receives a lot of attachments, this drops those into a nice organized area on the server.
                For Each objectItem As OpenPop.Mime.Header.RfcMailAddress In Message.Headers.[To]
                    emailA = objectItem.Address.ToString()
                    If emailA.ToLower = "funding@primalend.com" Then
                        For Each msgpart As MessagePart In Message.FindAllAttachments
                            Try
                                Dim DirtyItems() As String = {"/", ":", "\", "|", "<", ">", "?", "*"}
                                Dim eSubject As String = Message.Headers.Subject.ToString
                                Dim eSplit() As String = eSubject.Split(DirtyItems, StringSplitOptions.RemoveEmptyEntries)
                                eSubject = ""
                                For s = 0 To eSplit.Count - 1
                                    eSubject += eSplit(s) & " "
                                Next
                                'MsgBox(eSubject)
                                Dim NowTime As String = DateTime.Now.ToString("HHmmss")
                                Dim NowDate As String = DateTime.Now.ToString("yyyyMMdd")
                                If TimeOfDay <= "4:30:00 PM" Then
                                    NowDate = DateTime.Now.ToString("yyyyMMdd")
                                Else
                                    NowDate = DateTime.Now.AddDays(1).ToString("yyyyMMdd")
                                End If
                                Dim thefile = NowTime & msgpart.FileName
                                thefolder = "P:\Treasury Management\Funding\" & NowDate & "\" & Message.Headers.From.Address.ToString & " " & eSubject & "\"
                                Dim filetype = msgpart.ContentType
                                Dim contentid = msgpart.ContentId
                                System.IO.Directory.CreateDirectory(thefolder)
                                'Using sw As StreamWriter = File.CreateText(thebodypath)
                                '    sw.WriteLine(DerString)
                                'End Using
                                System.IO.File.WriteAllBytes(thefolder & thefile, msgpart.Body)
                                Otto.LogTextBox.AppendText(vbNewLine & "Attempted to download some funding attachments and emails. @ " & TimeOfDay)
                            Catch ex As Exception
                                MsgBox(ex.ToString)
                            End Try
                        Next
                    End If
                    'Scheduled reports, for the portal.primalend.com site
                    If emailA.ToLower = "scheduledreports@primalend.com" Then
                        For Each msgpart As MessagePart In Message.FindAllAttachments
                            Try
                                Dim eSubject As String = Message.Headers.Subject.ToString
                                Dim esplit() As String = eSubject.Split(New Char() {" "c})
                                Dim thefile = esplit(0) & "_" & msgpart.FileName
                                thefolder = "O:\feeds\"
                                Dim filetype = msgpart.ContentType
                                Dim contentid = msgpart.ContentId
                                System.IO.Directory.CreateDirectory(thefolder)
                                System.IO.File.WriteAllBytes(thefolder & thefile, msgpart.Body)
                                Otto.LogTextBox.AppendText(vbNewLine & "Attempted to download some funding attachments and emails. @ " & TimeOfDay)
                            Catch ex As Exception
                                MsgBox(ex.ToString)
                            End Try
                        Next
                    End If
                Next


                'MsgBox(System.IO.Directory.GetCurrentDirectory.ToString)

                'If the message is FROM a certain address, then do the following:

                If Message.Headers.From.Address.ToString.ToLower = "xerox_scan@ontarioautosales.com" Or Message.Headers.From.Address.ToString.ToLower = "xerox@ontarioautosales.com" Then
                    For Each msgpart As MessagePart In Message.FindAllAttachments
                        Try
                            Dim NowTime As String = DateTime.Now.ToString("HH mm ss")
                            Dim thefile = NowTime & msgpart.FileName
                            Dim filetype = msgpart.ContentType
                            Dim contentid = msgpart.ContentId
                            System.IO.File.WriteAllBytes("O:\ONTARIO UPLOADS" & "\" & thefile, msgpart.Body)
                            Otto.LogTextBox.AppendText(vbNewLine & "Ontario sent a scan in to collateral @ " & TimeOfDay)
                            'MsgBox("success: " & thefile & " " & filetype.ToString)
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try
                    Next
                End If

                If Message.Headers.From.Address.ToString.ToLower = "jpennock@primalend.com" Or Message.Headers.From.Address.ToString.ToLower = "jmpennock@primalend.com" Then
                    For Each msgpart As MessagePart In Message.FindAllAttachments
                        Try
                            Dim NowTime As String = DateTime.Now.ToString("HH mm ss")
                            Dim thefile = NowTime & msgpart.FileName
                            Dim filetype = msgpart.ContentType
                            Dim contentid = msgpart.ContentId
                            System.IO.File.WriteAllBytes("P:\SCANS\Otto" & "\" & thefile, msgpart.Body)
                            Otto.LogTextBox.AppendText(vbNewLine & "Found an attachment from " & Message.Headers.From.Address.ToString & " @ " & TimeOfDay)
                            'MsgBox("success: " & thefile & " " & filetype.ToString)
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try
                    Next
                End If

                Client.DeleteMessage(I) 'This should make it where we don't see the EMAIL again. Comment in and out to test multiples of the same email.
                I = I - 1
            Loop
            Client.Disconnect() 'These two have to be called in order for the delete functions to commit
            Client.Dispose() 'see above comment
            Try 'fill the from list
                FromList.Items.Clear()
                For a = 0 To DTMessage.Rows.Count - 1
                    FromList.Items.Add(DTMessage.Rows(a)(1))
                Next
            Catch ex As Exception
                FromList.Items.Add("Error")
            End Try
            Try 'fill the subject list
                SubjectList.Items.Clear()
                For a = 0 To DTMessage.Rows.Count - 1
                    SubjectList.Items.Add(DTMessage.Rows(a)(2))
                Next
            Catch ex As Exception
                SubjectList.Items.Add("Error")
            End Try
        Catch ex As Exception
            ' MsgBox(ex.ToString)
        End Try

        Try 'determine which dealerships have requested funding. IF there is funding, go ahead and update to show a funding request for TODAY
            Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")
            FundingList.Items.Clear()
            For a = 0 To FromList.Items.Count - 1
                Dim FundQuery As String = "Select Dealership from Contactlist where email='" & FromList.Items(a) & "'"
                Dim FundTable As New DataTable
                Dim FundAdapt As New MySqlDataAdapter(FundQuery, SqlConnectionString)
                FundAdapt.Fill(FundTable)
                If FundTable.Rows.Count > 0 Then
                    FundingList.Items.Add(FundTable.Rows(0)(0))
                End If
            Next

            For a = 0 To FundingList.Items.Count - 1
                Dim UpdateQuery As String = "Update Dealername set Fundingrequest='" & NowDate & "' WHERE Dealership='" & FundingList.Items(a) & "'"
                Using connection As New MySqlConnection(SqlConnectionString)
                    Dim command As New MySqlCommand(UpdateQuery, connection)
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                End Using
            Next
        Catch ex As Exception
            'MsgBox(ex.ToString)
            FundingList.Items.Add("Error")
        End Try
        Try 'Determine if anyone sent commands
            CommandList.Items.Clear()
            Dim ToBeSplit As String = ""
            For i = 0 To SubjectList.Items.Count - 1
                ToBeSplit = SubjectList.Items(i).ToString.ToLower
                Dim Split As String() = ToBeSplit.Split(New Char() {" "c})
                If Split(0) = "Command" Or Split(0) = "command" Or Split(0) = "cmd" Then
                    CommandList.Items.Add(Split(1))
                    ReturnCList.Add(DTMessage.Rows(i)(1))
                    BodyCList.Add(DTMessage.Rows(i)(4))
                ElseIf Split(1) = "otcmd" Then
                    CommandList.Items.Add(Split(2))
                    ReturnCList.Add(DTMessage.Rows(i)(1))
                    BodyCList.Add(DTMessage.Rows(i)(4))
                End If
            Next
        Catch ex As Exception
            '            MsgBox(ex.ToString)
        End Try
        Try 'determine if any borrowing bases have been sent out today.
            BBSentList.Items.Clear()
            Dim ToBeSplit As String = ""
            For i = 0 To SubjectList.Items.Count - 1
                ToBeSplit = SubjectList.Items(i).ToString
                Dim Split As String() = ToBeSplit.Split(New Char() {" "c})
                If Split(0) = "2015" Or Split(0) = "2014" Then
                    If Split.Count > 5 Then
                        BBSentList.Items.Add(Split(3) & " " & Split(4))
                    Else
                        BBSentList.Items.Add(Split(3))
                    End If
                End If
            Next

        Catch ex As Exception
            BBSentList.Items.Add("Issues")
            Otto.LogTextBox.AppendText(vbNewLine & "Had trouble setting up the bbsentlist @ " & TimeOfDay)
        End Try
        CheckLabel.Text += 1
        Return Nothing
    End Function

    Private Sub FlatToggle1_CheckedChanged(sender As Object) Handles FlatToggle1.CheckedChanged
        If FlatToggle1.Checked = True Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        CheckMail()
    End Sub

    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub

    Private Sub CommandTimer_Tick(sender As Object, e As EventArgs)


    End Sub
    Public Function DoCommand(Type As String)
        If Type = "@Refresh" Then
            MsgBox("Yay!")
        End If
        Return Nothing
    End Function

    Private Sub CommandTimer_Tick_1(sender As Object, e As EventArgs) Handles CommandTimer.Tick
        If CommandList.Items.Count < 1 Then
            Exit Sub
            CommandTimer.Stop()
            CommandLabel.Text += 1
        Else
            Dim CommandSet As New List(Of String)()
            For I = 0 To CommandList.Items.Count - 1
                CommandSet.Add(CommandList.Items(I))
            Next
            Dim Commandstrings As String() = CommandSet.ToArray
            Commander(Commandstrings)
            CommandTimer.Stop()
        End If
    End Sub
    Public Function Commander(ByVal CList As String())
        Dim BodyCommandList As String() = BodyCList.ToArray
        Dim ReturnCommandList As String() = ReturnCList.ToArray
        For I = 0 To CList.Count - 1
            If CList(I) = "@Query" Or CList(I) = "@query" Then
                Try
                    Dim Query As String = BodyCommandList(I).ToLower
                    Dim QueryCheck As String() = Query.Split(New Char() {" "c})
                    If QueryCheck(0) = "select" Then 'if it's to see items, no command is required.
                        Dim Results As String = ""
                        Dim Querytable As New DataTable
                        Dim Queryadapt As New MySqlDataAdapter(Query, SqlConnectionString)
                        Queryadapt.Fill(Querytable)
                        Results = "Results of the follwing query: " & Query & "<br><br>"
                        Results = "<Table style=""width:50%"">"
                        For ch = 0 To Querytable.Columns.Count - 1
                            Results = Results & "<th>" & Querytable.Columns(ch).ColumnName & "</th>"
                        Next
                        Results = Results & "<br>"
                        For q = 0 To Querytable.Rows.Count - 1
                            Results = Results & "<tr>"
                            For c = 0 To Querytable.Columns.Count - 1
                                Results = Results & "<td>" & Querytable.Rows(q)(c).ToString & "</td>"
                            Next
                            Results = Results & "</tr><br>"
                        Next
                        MailIt(Results, ReturnCommandList(I), True)
                        Otto.LogTextBox.AppendText(vbNewLine & ReturnCommandList(I) & " tried the following query: " & BodyCommandList(I) & " @ " & TimeOfDay)
                    Else
                        'Using Connection As New MySqlConnection(SqlConnectionString)
                        '    Dim Command As New MySqlCommand(Query, Connection)
                        '    Connection.Open()
                        '    Command.ExecuteNonQuery()
                        '    Connection.Close()
                        Query = Query & " Cannot be completed at this time."
                        MailIt(Query, ReturnCommandList(I), False)
                        Otto.LogTextBox.AppendText(vbNewLine & ReturnCommandList(I) & " attempted a naughty query! @ " & TimeOfDay)
                        'End Using
                    End If

                Catch ex As Exception
                    Dim Err As String = ex.ToString
                    MailIt(Err, ReturnCommandList(I), False)
                End Try
            ElseIf CList(I) = "@watch" Then 'this is how you can request reports on the metrics of each employee.
                Try
                    Dim Body As String = BodyCommandList(I).ToLower
                    Dim Split As String() = Body.Split(New Char() {" "c})
                    Otto.LogTextBox.AppendText(vbNewLine & Split(0))
                    Dim EmpID As String = ""
                    Try
                        Dim query As String = "select empid from employee where empfirst='" & Split(0).Trim() & "'"
                        Dim adapt As New MySqlDataAdapter(query, SqlConnectionString)
                        Dim table As New DataTable
                        adapt.Fill(table)
                        Otto.LogTextBox.AppendText(vbNewLine & query)
                        EmpID = table(0)(0)
                    Catch ex As Exception
                        Otto.LogTextBox.AppendText(vbNewLine & " had trouble finding an employee for a watch request @ " & TimeOfDay)
                        MailIt(ex.ToString, "jpennock@primalend.com", False)
                    End Try
                    Otto.RefreshWatch(EmpID, ReturnCommandList(I), Split(0).Trim())
                    Otto.LogTextBox.AppendText(vbNewLine & ReturnCommandList(I) & " requested a watch report @ " & TimeOfDay)
                Catch ex As Exception
                    Otto.LogTextBox.AppendText(vbNewLine & "had an issue with my watch refresh request @ " & TimeOfDay)
                    MailIt(ex.ToString, "jpennock@primalend.com", False)
                End Try
            ElseIf CList(I) = "#test" Then
                Try
                    MailIt("<h3>Welcome!</h3>Your PIN has been updated. Please keep it handy, since you will need it to log in to the production log and clock in for your time card!<br><p>Please follow these steps to install the production log</p><br><p><b>First the top of this email may be asking you to download pictures. PLEASE CLICK THAT SO YOU CAN FOLLOW THE STEPS. After, click this <a href=""file:///\\pcpserver\PL_Share\PrimaLend\Primalend Production Log\setup.exe"">link</a> to download the program</b></p><br>You'll see a window pop up like this:<br><img src=""file:///\\pcpserver\PL_Share\PrimaLend\Primalend Production Log\attachmentwindow.png""><p><b>Click the OPEN button</b></p><p>You'll then see a window like this (sometimes this takes a while, so please be patient as it loads)</p><img src=""file:///\\pcpserver\PL_Share\PrimaLend\Primalend production log\applicationinstallwindow.png""><p><b>Click the INSTALL button</b></p><p>After it installs, you'll see the main window</p><img src=""file:///\\pcpserver\PL_Share\PrimaLend\Primalend production log\dashboardwindow.png""><p><b>Click on the WORK QUEUE button</b></p><p>This is the main work window. You can Log in, see which jobs are in your queue and use it to clock in and out.</p><img src=""file:///\\pcpserver\PL_Share\PrimaLend\Primalend production log\workqueuewindow.png""><p><b>Go ahead and click LOGIN</b></p><p>A small window will pop up, where you can enter your PIN code and then press ENTER to complete the login process</p><img src=""file:///\\pcpserver\PL_Share\PrimaLend\Primalend production log\loginwindow.png""><p>You should now be logged into the program and ready to get to work. Make sure you press the REFRESH NOW button on the queue to see if anything has been added recently</p><h3>Have a great day!</h3>", ReturnCommandList(I), True)
                Catch ex As Exception
                    MailIt(ex.ToString, ReturnCommandList(I), False)
                End Try
            ElseIf CList(I) = "#pin" Then 'the # is a special OTTO command, it won't be listed in the help file, this is one for when people reply to OTTO's management emails
                Dim Errorstring As String = ""
                Try
                    Dim FirstPass As String() = BodyCommandList(I).Split(New Char() {"-"c})
                    Dim ThePin As String() = FirstPass(0).Split(New Char() {" "c})
                    Dim EmpTable As New DataTable
                    Dim EmpIDQuery As String = "SELECT EmpID from Employee where Email='" & ReturnCommandList(I) & "'"
                    Dim Adapt As New MySqlDataAdapter(EmpIDQuery, SqlConnectionString)
                    Adapt.Fill(EmpTable)
                    Dim PINQuery As String = "INSERT INTO PINS (EmpID,PIN) VALUES('" & EmpTable.Rows(0)(0) & "','" & ThePin(0) & "');"
                    Errorstring = ThePin(0) & "-" & PINQuery & " "
                    Using Connection As New MySqlConnection(SqlConnectionString)
                        Dim Update As New MySqlCommand(PINQuery, Connection)
                        Connection.Open()
                        Update.ExecuteNonQuery()
                        Connection.Close()
                    End Using
                    Dim Results = "<h3>Welcome!</h3>Your PIN has been updated. Please keep it handy, since you will need it to log in to the production log and clock in for your time card!<br><p>Please follow these steps to install the production log</p><br><p><b>First the top of this email may be asking you to download pictures. PLEASE CLICK THAT SO YOU CAN FOLLOW THE STEPS.<br>After, click this <a href=""file:///\\pcpserver\PL_Share\PrimaLend\Primalend Production Log\setup.exe"">link</a> to download the program</b></p><br>You'll see a window pop up like this:<br><img src=""file:///\\pcpserver\PL_Share\PrimaLend\Primalend Production Log\attachmentwindow.png""><p><b>Click the OPEN button</b></p><p>You'll then see a window like this (sometimes this takes a while, so please be patient as it loads)</p><img src=""file:///\\pcpserver\PL_Share\PrimaLend\Primalend production log\applicationinstallwindow.png""><p><b>Click the INSTALL button</b></p><p>After it installs, you'll see the main window</p><img src=""file:///\\pcpserver\PL_Share\PrimaLend\Primalend production log\dashboardwindow.png""><p><b>Click on the WORK QUEUE button</b></p><p>This is the main work window. You can Log in, see which jobs are in your queue and use it to clock in and out.</p><img src=""file:///\\pcpserver\PL_Share\PrimaLend\Primalend production log\workqueuewindow.png""><p><b>Go ahead and click LOGIN</b></p><p>A small window will pop up, where you can enter your PIN code and then press ENTER to complete the login process</p><img src=""file:///\\pcpserver\PL_Share\PrimaLend\Primalend production log\loginwindow.png""><p>You should now be logged into the program and ready to get to work. Make sure you press the REFRESH NOW button on the queue to see if anything has been added recently</p><h3>Have a great day!</h3>"
                    MailIt(Results, ReturnCommandList(I), True)
                    Otto.LogTextBox.AppendText(vbNewLine & "Updated the PIN for " & ReturnCommandList(I) & " @ " & TimeOfDay)
                Catch ex As Exception
                    MailIt(Errorstring & ex.ToString, "jpennock@primalend.com", False)
                    Otto.LogTextBox.AppendText(vbNewLine & "Error updating the PIN for " & ReturnCommandList(I) & " @ " & TimeOfDay)
                End Try

            ElseIf CList(I) = "@FundingRequest" Or CList(I) = "@Funding" Or CList(I) = "@funding" Or CList(I) = "@fundingrequest" Then
                Try
                    Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")
                    Dim SplitUp As String() = BodyCommandList(I).Split(New Char() {","c})
                    Dim Results As String = ""
                    For f = 0 To SplitUp.Count - 1
                        Dim UpdateQuery As String = "UPDATE Dealername Set FundingRequest='" & NowDate & "' WHERE Dealership='" & SplitUp(f).Trim & "'"
                        Using Connection As New MySqlConnection(SqlConnectionString)
                            Dim UpdateCommand As New MySqlCommand(UpdateQuery, Connection)
                            Connection.Open()
                            UpdateCommand.ExecuteNonQuery()
                            Connection.Close()
                        End Using
                        Results = Results & " " & UpdateQuery & vbNewLine
                    Next
                    Results = Results & vbNewLine & "Success"
                    MailIt(Results, ReturnCommandList(I), False)
                    Otto.LogTextBox.AppendText(vbNewLine & ReturnCommandList(I) & " set up funding requests for certain dealers @ " & TimeOfDay)
                Catch ex As Exception
                    MailIt(ex.ToString, ReturnCommandList(I), False)
                End Try
            ElseIf CList(I) = "@OpenJobs" Or CList(I) = "@openjobs" Or CList(I) = "@Openjobs" Then 'Return the open jobs
                Try
                    Dim TodayInt As Integer = DateTime.Today.DayOfWeek
                    Dim Query As String = "SELECT Workflow.JobID, Employee.EmpFirst AS Name, Workflow.DateAssigned, Workflow.TimeAssigned, Workflow.DateStarted, Workflow.TimeStarted, Workflow.DateCompleted, Workflow.TimeCompleted, Workflow.Dealer, Workflow.Job, Workflow.Quantity, Workflow.Comment FROM Workflow INNER JOIN Employee ON Workflow.EmpID=Employee.EmpID WHERE DateCompleted IS NULL ORDER BY Dealer" 'This is the grouped Job List
                    Dim Results As String = ""
                    Dim Querytable As New DataTable
                    Dim Queryadapt As New MySqlDataAdapter(Query, SqlConnectionString)
                    Queryadapt.Fill(Querytable)
                    Results = "<Table style=""width:50%"">"
                    For ch = 0 To Querytable.Columns.Count - 1
                        Results = Results & "<th>" & Querytable.Columns(ch).ColumnName & "</th>"
                    Next
                    Results = Results & "<br>"
                    For q = 0 To Querytable.Rows.Count - 1
                        Results = Results & "<tr>"
                        For c = 0 To Querytable.Columns.Count - 1
                            Results = Results & "<td>" & Querytable.Rows(q)(c).ToString & "</td>"
                        Next
                        Results = Results & "</tr><br>"
                    Next
                    MailIt(Results, ReturnCommandList(I), True)
                    Otto.LogTextBox.AppendText(vbNewLine & ReturnCommandList(I) & " checked the open workflow jobs @ " & TimeOfDay)
                Catch ex As Exception
                    MailIt(ex.ToString, ReturnCommandList(I), False)
                End Try
            ElseIf CList(I) = "@openqa" Then
                Try
                    Dim TodayInt As Integer = DateTime.Today.DayOfWeek
                    Dim Query As String = "SELECT QA.QAID, Employee.EmpFirst AS Name, QA.DateAssigned, QA.DateStarted, QA.TimeStarted, QA.DateCompleted, QA.TimeCompleted, QA.Dealership, QA.Job, QA.RecordedQuantity, QA.Comment FROM QA INNER JOIN Employee ON QA.EmpID=Employee.EmpID WHERE DateCompleted IS NULL ORDER BY Employee.Empfirst" 'This is the grouped Job List
                    Dim Results As String = ""
                    Dim Querytable As New DataTable
                    Dim Queryadapt As New MySqlDataAdapter(Query, SqlConnectionString)
                    Queryadapt.Fill(Querytable)
                    Results = "<Table style=""width:50%"">"
                    For ch = 0 To Querytable.Columns.Count - 1
                        Results = Results & "<th>" & Querytable.Columns(ch).ColumnName & "</th>"
                    Next
                    Results = Results & "<br>"
                    For q = 0 To Querytable.Rows.Count - 1
                        Results = Results & "<tr>"
                        For c = 0 To Querytable.Columns.Count - 1
                            Results = Results & "<td>" & Querytable.Rows(q)(c).ToString & "</td>"
                        Next
                        Results = Results & "</tr><br>"
                    Next
                    MailIt(Results, ReturnCommandList(I), True)
                    Otto.LogTextBox.AppendText(vbNewLine & ReturnCommandList(I) & " checked the open QA jobs @ " & TimeOfDay)
                Catch ex As Exception
                    MailIt(ex.ToString, ReturnCommandList(I), False)
                End Try
            ElseIf CList(I) = "@Schedule" Or CList(I) = "@schedule" Then 'Return the bb schedule
                Try
                    Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")
                    Dim TodayInt As Integer = DateTime.Today.DayOfWeek
                    Dim Query As String = "SELECT Dealership,BBSentDate as 'Last Sent' from Dealername WHERE Schedule='" & TodayInt & "' OR Schedule='0'"
                    Dim QueryCheck As String() = Query.Split(New Char() {" "c})
                    Dim Results As String = ""
                    Dim Querytable As New DataTable
                    Dim Queryadapt As New MySqlDataAdapter(Query, SqlConnectionString)
                    Queryadapt.Fill(Querytable)
                    Results = "<Table style=""width:50%"">"
                    For ch = 0 To Querytable.Columns.Count - 1
                        Results = Results & "<th>" & Querytable.Columns(ch).ColumnName & "</th>"
                    Next
                    Results = Results & "<br>"
                    For q = 0 To Querytable.Rows.Count - 1
                        Results = Results & "<tr>"
                        For c = 0 To Querytable.Columns.Count - 1
                            Results = Results & "<td>" & Querytable.Rows(q)(c).ToString & "</td>"
                        Next
                        Results = Results & "</tr><br>"
                    Next
                    MailIt(Results, ReturnCommandList(I), True)
                    Otto.LogTextBox.AppendText(vbNewLine & ReturnCommandList(I) & " checked the BB schedule @ " & TimeOfDay)
                Catch ex As Exception
                    MailIt(ex.ToString, ReturnCommandList(I), False)
                End Try
            ElseIf CList(I) = "@Hello" Or CList(I) = "@Howdy" Or CList(I) = "@Hi" Or CList(I) = "@Help" Or CList(I) = "@help" Or CList(I) = "@hello" Then
                Try
                    Dim ReturnMessage As String = "Hello.<br> Thanks for using my command options.<br>The following items can be used as commands: <br> @Funding or @FundingRequest: Put the names of the Dealerships that you'd like to set as funding requested in the body, separated by commas. (NO SIGNATURE PLEASE) <br>@OpenJobs: Return a table of the jobs not finished (@OpenQA is the list of open QA jobs)<br>@Schedule: Return a table of today's borrowing base schedule.<br>@Time: This will send back your timecard for the last 7 days.<br>@Query: Build a completely custom query (try @tables to see more info on that).<br> Just make an email with the subject Command @(Your Command Here) or cmd @(Your command here) and send it to me!<br><br><h3>Thanks!</h3>"
                    MailIt(ReturnMessage, ReturnCommandList(I), True)
                    Otto.LogTextBox.AppendText(vbNewLine & ReturnCommandList(I) & " said hello and got my auto response @ " & TimeOfDay)
                Catch ex As Exception
                    MailIt(ex.ToString, ReturnCommandList(I), False)
                End Try
            ElseIf CList(I) = "@timesheet" Or CList(I) = "@time" Or CList(I) = "@timecard" Or CList(I) = "@timeclock" Then 'return time card
                Try
                    Dim TodayInt As Integer = DateTime.Today.DayOfWeek
                    Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")
                    Dim Query As String = ""
                    If ReturnCommandList(I).ToLower = "eoffor@primalend.com" Then
                        Query = "SELECT Employee.Empfirst,Timeclock.Timein,Timeclock.Timeout,Timediff(Timeclock.TimeOut,Timeclock.TimeIn) AS Hours,Timeclock.ClockDate From TimeClock INNER JOIN Employee ON Timeclock.EmpID=Employee.EmpID WHERE TimeClock.ClockDate BETWEEN Date_Sub(Now(), INTERVAL 7 DAY) AND NOW();"
                    Else
                        Query = "SELECT Employee.Empfirst,Timeclock.Timein,Timeclock.Timeout,Timediff(Timeclock.TimeOut,Timeclock.TimeIn) AS Hours,Timeclock.ClockDate From TimeClock INNER JOIN Employee ON Timeclock.EmpID=Employee.EmpID WHERE Employee.Email ='" & ReturnCommandList(I) & "' AND TimeClock.ClockDate BETWEEN Date_Sub(Now(), INTERVAL 7 DAY) AND NOW();"
                    End If
                    Dim Results As String = ""
                    Dim Querytable As New DataTable
                    Dim Queryadapt As New MySqlDataAdapter(Query, SqlConnectionString)
                    Queryadapt.Fill(Querytable)
                    Results = "<Table style=""width:65%"">"
                    For ch = 0 To Querytable.Columns.Count - 1
                        Results = Results & "<th>" & Querytable.Columns(ch).ColumnName & "</th>"
                    Next
                    Results = Results & "<br>"
                    For q = 0 To Querytable.Rows.Count - 1
                        Results = Results & "<tr>"
                        For c = 0 To Querytable.Columns.Count - 1
                            Results = Results & "<td>" & Querytable.Rows(q)(c).ToString & "</td>"
                        Next
                        Results = Results & "</tr><br>"
                    Next
                    MailIt(Results, ReturnCommandList(I), True)
                    Otto.LogTextBox.AppendText(vbNewLine & ReturnCommandList(I) & " checked their time card @ " & TimeOfDay)
                Catch ex As Exception
                    MailIt(ex.ToString, ReturnCommandList(I), False)
                End Try
            ElseIf CList(I) = "@queryhelp" Or CList(I) = "@tables" Or CList(I) = "@tablelist" Then 'list of tables in our DB (minus the secret ones)
                Dim Results As String = "Hello!<br>The following is a list of the <b>TABLES</b> found in our database.<b><br>batch<br>contactlist<br>dealername<br>employee<br>extensions<br>jobname<br>occurrences<br>qa<br>timeclock<br>workflow<br></b>If you want to see the columns of a specific table, try emailing me cmd @tableinfo and put the table name in the body of your email.<br> <h3>Thanks!</h3>"
                MailIt(Results, ReturnCommandList(I), True)
                Otto.LogTextBox.AppendText(vbNewLine & ReturnCommandList(I) & " checked the table names @ " & TimeOfDay)
            ElseIf CList(I) = "@tableinfo" Then 'columns of a specific table
                Try
                    Dim table As String = BodyCommandList(I).ToLower
                    Dim Query As String = "SELECT * From " & table
                    Dim Results As String = ""
                    Dim Querytable As New DataTable
                    Dim Queryadapt As New MySqlDataAdapter(Query, SqlConnectionString)
                    Queryadapt.Fill(Querytable)
                    Results = "<Table style=""width:65%"">"
                    For ch = 0 To Querytable.Columns.Count - 1
                        Results = Results & "<th>" & Querytable.Columns(ch).ColumnName & ",</th>"
                    Next
                    MailIt(Results, ReturnCommandList(I), True)
                    Otto.LogTextBox.AppendText(vbNewLine & ReturnCommandList(I) & " checked the table info @ " & TimeOfDay)
                Catch ex As Exception
                    MailIt(ex.ToString, ReturnCommandList(I), False)
                End Try
            ElseIf CList(I) = "@ip" Then
                Try
                    Dim wb As New System.Net.WebClient
                    Dim s As String = wb.DownloadString("http://whatsmyip.us/showipsimple.php") 'this php form is literally just one line that says "console.write(yourip) or something :)
                    Dim results As String = "I'm pretty sure this is my external IP: " & s
                    MailIt(results, ReturnCommandList(I), False)
                    Otto.LogTextBox.AppendText(vbNewLine & ReturnCommandList(I) & " asked for the IP address @ " & TimeOfDay)
                Catch ex As Exception
                    MailIt(ex.ToString, ReturnCommandList(I), False)
                End Try
            Else
                Dim ReturnMessage As String = "Hello.<br> Thanks for using my command options.<br>The command you sent <b>(" & CList(I) & ")</b> is not a valid command right now.<br>The following items can be used as commands: <br> @Funding or @FundingRequest: Put the names of the Dealerships that you'd like to set as funding requested in the body, separated by commas. (NO SIGNATURE PLEASE) <br>@OpenJobs: Return a table of the jobs not finished (@OpenQA is the list of QA jobs that are open)<br>@Schedule: Return a table of today's borrowing base schedule.<br>@Time: This will send back your timecard for the last 7 days.<br>@Query: Build a completely custom query (try @tables to see more info on that).<br> Just make an email with the subject Command @(Your Command Here) or cmd @(Your command here) and send it to me!<br><br><h3>Thanks!</h3>"
                MailIt(ReturnMessage, ReturnCommandList(I), True)
                Otto.LogTextBox.AppendText(vbNewLine & ReturnCommandList(I) & " tried a command that didn't exist @ " & TimeOfDay)
            End If
        Next

        If BBTimer.Enabled = False Then
            BBTimer.Enabled = True
        End If
        If CommandTimer.Enabled = False Then
            CommandTimer.Enabled = True
        End If

        CommandList.Items.Clear()
        CommandLabel.Text += 1
        Return Nothing
    End Function
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
            e_mail.Subject = "Otto Command Results"
            e_mail.IsBodyHtml = IsHTML
            e_mail.Body = Body
            smtp_server.Send(e_mail)
            Otto.LogTextBox.AppendText(vbNewLine & "Sent an email to " & emailto & " @ " & TimeOfDay)
        Catch ex As Exception
            Otto.LogTextBox.AppendText(vbNewLine & "Couldn't send an email to " & emailto & " @ " & TimeOfDay)
        End Try
        Return Nothing
    End Function

    Private Sub BBTimer_Tick(sender As Object, e As EventArgs) Handles BBTimer.Tick
        Dim errorresult As String = ""
        If BBSentList.Items.Count < 1 Then
            Exit Sub
            BBTimer.Stop()
        Else
            Try
                Dim Results As String = ""
                Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")
                For I = 0 To BBSentList.Items.Count - 1
                    Dim UpdateQuery As String = ""
                    If BBSentList.Items(I) = "JR's" Then
                        UpdateQuery = "UPDATE Dealername SET BBSentDate='" & NowDate & "' WHERE Dealership='JRs'"
                    ElseIf BBSentList.Items(I).ToString.ToLower = "autoflex" Or BBSentList.Items(I) = "Autoflex" Then
                        UpdateQuery = "UPDATE Dealername SET BBSentDate='" & NowDate & "' WHERE Dealership='Auto Flex'"
                    ElseIf BBSentList.Items(I) = "200 &" Then
                        UpdateQuery = "UPDATE Dealername SET BBSentDate='" & NowDate & "' WHERE Dealership='200 & West'"
                    ElseIf BBSentList.Items(I) = "JAKC_JAR VP" Or BBSentList.Items(I) = "JAKC_JAR" Or BBSentList.Items(I) = "JAKC/JAR" Then
                        UpdateQuery = "UPDATE Dealername SET BBSentDate='" & NowDate & "' WHERE Dealership='JAKC' OR Dealership='JAR'"
                    ElseIf BBSentList.Items(I) = "AAA" Then
                        UpdateQuery = "UPDATE Dealername SET BBSentDate='" & NowDate & "' WHERE Dealership='Austin Auto'"
                    ElseIf BBSentList.Items(I) = "4 Your" Then
                        UpdateQuery = "UPDATE Dealername SET BBSentDate='" & NowDate & "' WHERE Dealership='4 Your Car'"
                    ElseIf BBSentList.Items(I) = "Approved Auto" Then
                        UpdateQuery = "UPDATE Dealername SET BBSentDate='" & NowDate & "' WHERE Dealership='Approved'"
                    ElseIf BBSentList.Items(I) = "Foreign Auto" Then
                        UpdateQuery = "UPDATE Dealername SET BBSentDate='" & NowDate & "' WHERE Dealership='Foreign'"
                    Else
                        UpdateQuery = "UPDATE Dealername SET BBSentDate='" & NowDate & "' WHERE Dealership='" & BBSentList.Items(I) & "'"
                    End If
                    Using Connection As New MySqlConnection(SqlConnectionString)
                        Dim UpdateCommand As New MySqlCommand(UpdateQuery, Connection)
                        Connection.Open()
                        UpdateCommand.ExecuteNonQuery()
                        Connection.Close()
                        Results = Results & " " & BBSentList.Items(I) & " " & UpdateQuery
                        errorresult = Results
                    End Using
                Next
                BBSentList.Items.Clear()
                Otto.LogTextBox.AppendText(vbNewLine & "Updated the BB Sent List FOR: " & Results & " @ " & TimeOfDay)
                'MailIt(Results, "jpennock@primalend.com", False)
                BBTimer.Stop()
            Catch ex As Exception
                Otto.LogTextBox.AppendText(vbNewLine & "Couldn't update the BBsent info for " & errorresult & " @ " & TimeOfDay)
                MailIt("Couldn't update the BBSENT LIST :" & ex.ToString, "jpennock@primalend.com", False)
            End Try
        End If
    End Sub
End Class