Imports System.Data.OleDb
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class Clerk
    Dim JobListSelected As Boolean = False
    Dim SuccessSeconds As Integer = 0
    Dim StillHere As Boolean = False
    Dim QueueTable As New DataTable
    'Dim ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\pcpserver\pl_share\PrimaLend\Collateral Management\Updates\Timelog.accdb" 'Shared DB file
    Dim AppData As String = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Primalend\"
    Dim ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & AppData & "Timelogz.accdb" 'Local resource with links
    Dim SqlConnectionString As String = "Server=192.168.1.34; Database=TimeLogDB; User id=clerk; Password=12345;" 'NUC Database
    Dim JOBInfoTable As New DataTable
    Dim QAInfoTable As New DataTable
    Dim SelectedNode As TreeNode
    Dim InAJob As Boolean = False





    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        LogOn.Show()
    End Sub

    Private Sub Clerk_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed

    End Sub

    Private Sub Clerk_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub Clerk_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub Clerk_Load(sender As Object, e As EventArgs) Handles Me.Load
        JobTreeView.Nodes.Clear()
        JobTreeView.Nodes.Add("Funding")
        JobTreeView.Nodes.Add("BB")
        JobTreeView.Nodes.Add("Collateral")
        JobTreeView.Nodes.Add("QA")
        Try
            EmployeeID.Text = Dashboard.IDLabel.Text
            Dim ClockTable As New DataTable
            Dim ClockQuery As String = "SELECT * From TimeClock where TimeOut is null and EmpID = '" & EmployeeID.Text & "'"
            Dim ClockAdapt As New MySqlDataAdapter(ClockQuery, SqlConnectionString)
            ClockAdapt.Fill(ClockTable)
            If ClockTable.Rows.Count > 0 Then
                ClockTimeLabel.Text = ClockTable.Rows(0)(2).ToString
                ClockInButton.Visible = False
                ClockInButton.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub LoginSuccessTimer_Tick(sender As Object, e As EventArgs) Handles LoginSuccessTimer.Tick
        If SuccessSeconds >= 10 Then
            SuccessLabel.Visible = False
            SuccessSeconds = 0
            LoginSuccessTimer.Stop()
        Else
            SuccessLabel.Visible = True
            SuccessSeconds += 1
        End If

    End Sub

    Private Sub ClockInButton_Click(sender As Object, e As EventArgs) Handles ClockInButton.Click
        If LoginButton.Visible = True Then
            Exit Sub
        Else
            Try
                Using Connection As New MySqlConnection(SqlConnectionString)
                    Dim NowTime As String = DateTime.Now.ToString("HH:mm:ss")
                    Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")

                    Dim Query As String = "INSERT INTO TimeClock (EmpID,TimeIn,ClockDate) VALUES ('" & EmployeeID.Text & "','" & NowTime & "','" & NowDate & "');"
                    Dim TimeCommand As New MySqlCommand(Query, Connection)
                    Connection.Open()
                    TimeCommand.ExecuteNonQuery()
                    Connection.Close()
                End Using
                Try
                    Using isClockConnect As New MySqlConnection(SqlConnectionString)
                        Dim Query As String = "UPDATE Employee SET isClockIn=True WHERE EmpID=" & EmployeeID.Text
                        Dim ClockIn As New MySqlCommand(Query, isClockConnect)
                        isClockConnect.Open()
                        ClockIn.ExecuteNonQuery()
                        isClockConnect.Close()
                    End Using
                Catch ex As Exception
                    MsgBox("Had trouble letting the server know you were clocked in. Please let your administrator know! " & ex.ToString)
                End Try
                ClockTimeLabel.Text = TimeOfDay
                ClockInButton.Enabled = False
                ClockInButton.Visible = False
                LoginSuccessTimer.Enabled = True
            Catch ex As Exception
                SendError.Show()
                SendError.EmpIDLabel.Text = EmployeeID.Text
                SendError.ErrorRTB.Text = ex.ToString
            End Try
            ShowButton.Visible = True
        End If

    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        If ClockInButton.Enabled = False Then
            MsgBox("Please clock out before logging out", vbOKOnly, "Oops!")
        Else
            Try
                Using Connection As New MySqlConnection(SqlConnectionString)
                    Dim LoginQuery As String = "UPDATE Employee SET IsLogin=0 WHERE EmpID=" & EmployeeID.Text
                    Dim LoginCommand As New MySqlCommand(LoginQuery, Connection)
                    Connection.Open()
                    LoginCommand.ExecuteNonQuery()
                    Connection.Close()
                End Using
            Catch ex As Exception
                SendError.Show()
                SendError.EmpIDLabel.Text = EmployeeID.Text
                SendError.ErrorRTB.Text = ex.ToString
            End Try
            EmployeeID.Text = 0
            LoginSuccessTimer.Enabled = True
            LogoutButton.Visible = False
            LoginButton.Visible = True
        End If
    End Sub

    Private Sub ClockOutButton_Click(sender As Object, e As EventArgs) Handles ClockOutButton.Click
        If ClockInButton.Enabled = True Then
            Exit Sub
        Else
            ShowButton.Visible = False
            Try
                Using connection As New MySqlConnection(SqlConnectionString)
                    Dim NowTime As String = Datetime.now.tostring("HH:mm:ss")
                    Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")
                    Dim Query As String = "UPDATE TimeClock SET TimeOut='" & NowTime & "' WHERE EmpID=" & EmployeeID.Text & " AND TimeOut IS NULL"
                    Dim TimeoutCommand As New MySqlCommand(Query, connection)
                    connection.Open()
                    TimeoutCommand.ExecuteNonQuery()
                    connection.Close()
                End Using
                Try
                    Using isClockConnect As New MySqlConnection(SqlConnectionString)
                        Dim Query As String = "UPDATE Employee SET isClockIn=False WHERE EmpID=" & EmployeeID.Text
                        Dim ClockIn As New MySqlCommand(Query, isClockConnect)
                        isClockConnect.Open()
                        ClockIn.ExecuteNonQuery()
                        isClockConnect.Close()
                    End Using
                Catch ex As Exception
                    MsgBox("Had trouble letting the server know you were clocked out. Please let your administrator know! " & ex.ToString)
                End Try
                ClockTimeLabel.Text = ""
                ClockInButton.Enabled = True
                ClockInButton.Visible = True
                LoginSuccessTimer.Enabled = True
                QueueTimer.Stop()
            Catch ex As Exception
                SendError.Show()
                SendError.EmpIDLabel.Text = EmployeeID.Text
                SendError.ErrorRTB.Text = ex.ToString
            End Try

        End If
    End Sub

    Private Sub FlatToggle1_CheckedChanged(sender As Object)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'REFRESH
        Refreshme()
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles ShowButton.Click 'Collateral Reception window
        If MsgBox("Are you sure you'd like to receive collateral?", vbYesNo, "Are you sure?") = MsgBoxResult.Yes Then
            If ClockInButton.Visible = True Then
                MsgBox("Please clock in before attempting to log collateral")
            Else
                Try 'Check to see if there is an Otto collateral reception job
                    Dim LogQuery As String = "Select JobID From Workflow Where Job='Collateral Reception' AND TimeAssigned IS NULL"
                    Dim LogAdapt As New MySqlDataAdapter(LogQuery, SqlConnectionString)
                    Dim LogTable As New DataTable
                    LogAdapt.Fill(LogTable)

                    If LogTable.Rows.Count < 1 Then 'If there isn't make your own Job
                        Using Connection As New MySqlConnection(SqlConnectionString)
                            Dim NowTime As String = Datetime.now.tostring("HH:mm:ss")
                            Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")
                            Dim NewJobQuery As String = "INSERT INTO Workflow (EmpID,DateAssigned,TimeAssigned,TimeStarted,Dealer,Job,DateStarted) VALUES ('" & EmployeeID.Text & "','" & NowDate & "','" & NowTime & "','" & NowTime & "','Primalend','Collateral Reception','" & NowDate & "');"
                            Dim NewComand As New MySqlCommand(NewJobQuery, Connection)
                            Connection.Open()
                            NewComand.ExecuteNonQuery()
                            Connection.Close()
                        End Using
                        CollateralLog.Show()
                    Else
                        Using UpdateConnection As New MySqlConnection(SqlConnectionString) 'if there is, update the one that was made already!
                            Dim NowTime As String = Datetime.now.tostring("HH:mm:ss")
                            Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")
                            Dim UpdateJob As String = "UPDATE Workflow SET EmpID='" & EmployeeID.Text & "',TimeAssigned='" & NowTime & "',DateStarted='" & NowDate & "',TimeStarted='" & NowTime & "' WHERE JOBID=" & LogTable.Rows(0)(0)
                            Dim UpdateCommand As New MySqlCommand(UpdateJob, UpdateConnection)
                            UpdateConnection.Open()
                            UpdateCommand.ExecuteNonQuery()
                            UpdateConnection.Close()
                        End Using
                        CollateralLog.Show() 'Show the reception log afterwards :)
                    End If

                Catch ex As Exception
                    SendError.Show()
                    SendError.EmpIDLabel.Text = EmployeeID.Text
                    SendError.ErrorRTB.Text = ex.ToString
                End Try

            End If
        Else
            Exit Sub
        End If


    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click 'start job
        If DealerBox.Text = "" Or JobBox.Text = "" Then
            MsgBox("Please reselect the job number, the info did not populate.", vbOKOnly, "Oops!")
            Exit Sub
        End If
        If ClockTimeLabel.Text = "" Then
            MsgBox("Can't start job: Did you clock in?", vbOKOnly, "Oops!")
            Exit Sub
        ElseIf JobListSelected = True Then
            If MsgBox("Are you sure you'd like to start this job?", vbYesNo, "Are you sure?") = vbNo Then
                Exit Sub
            End If
            StartButton.Visible = False
            Try
                InAJob = True
                InAJobLabel.Text = "True"
                JobList.Enabled = False
                QAList.Enabled = False
                MyJobsRadio.Enabled = False
                QaJobsRadio.Enabled = False


                Using Connection As New MySqlConnection(SqlConnectionString) 'Start the job selected
                    Dim NowTime As String = DateTime.Now.ToString("HH:mm:ss")
                    Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")
                    Dim JobQuery As String = "Update WorkFlow SET TimeStarted='" & NowTime & "',DateStarted='" & NowDate & "' WHERE JobID=" & IDBox.Text
                    Dim JobCommand As New MySqlCommand(JobQuery, Connection)
                    Connection.Open()
                    JobCommand.ExecuteNonQuery()
                    Connection.Close()
                End Using


                'If (JobBox.Text = "CIFR Contracts" Or JobBox.Text = "CIFR Contract Titles") And DealerBox.Text = "Auto Flex" Then 'This will open the CIFR window for Autoflex - Currently will be used for testing
                '    TheCIFR.DealerNameLabel.Text = DealerBox.Text
                '    TheCIFR.Show()
                'End If

            Catch ex As Exception
                SendError.Show()
                SendError.EmpIDLabel.Text = EmployeeID.Text
                SendError.ErrorRTB.Text = ex.ToString
            End Try
            If JobBox.Text = "Collateral Reception" Then
                CollateralLog.Show()
                ShowButton.Visible = True
            Else
                Exit Sub
            End If
        Else
            StartButton.Visible = False
            Try
                JobList.Enabled = False
                QAList.Enabled = False
                MyJobsRadio.Enabled = False
                QaJobsRadio.Enabled = False

                Using Connection As New MySqlConnection(SqlConnectionString)
                    Dim NowTime As String = DateTime.Now.ToString("HH:mm:ss")
                    Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")
                    Dim QAQuery As String = "Update QA SET DateStarted='" & NowDate & "',TimeStarted='" & NowTime & "' WHERE QAID=" & IDBox.Text
                    Dim QACommand As New MySqlCommand(QAQuery, Connection)
                    Connection.Open()
                    QACommand.ExecuteNonQuery()
                    Connection.Close()
                End Using
            Catch ex As Exception
                SendError.Show()
                SendError.EmpIDLabel.Text = EmployeeID.Text
                SendError.ErrorRTB.Text = ex.ToString
            End Try

        End If

    End Sub

    Private Sub JobList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles JobList.SelectedIndexChanged
        If JobList.SelectedIndex = -1 Then
            Exit Sub
        Else
            IDBox.Text = JobList.SelectedItem
        End If
    End Sub

    Private Sub QAList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles QAList.SelectedIndexChanged
        If QAList.SelectedIndex = -1 Then
            Exit Sub
        Else
            IDBox.Text = QAList.SelectedItem
        End If
    End Sub

    Private Sub EndButton_Click(sender As Object, e As EventArgs) Handles EndButton.Click
        If MsgBox("Are you sure you'd like to end this job?", vbYesNo, "Are you sure?") = vbNo Then
            Exit Sub
        End If
        If StartButton.Visible = True Then
            Exit Sub
        ElseIf StartButton.Visible = False Then
            EndJob.Show()
        End If
    End Sub

    Private Sub QueueTimer_Tick(sender As Object, e As EventArgs) Handles QueueTimer.Tick
        Refreshme()
    End Sub

    Private Sub IDBox_TextChanged(sender As Object, e As EventArgs) Handles IDBox.TextChanged
        'Job INFO
        If IDBox.Text = "" Then
            Exit Sub
        End If

        'If InAJob = True Then
        '    AQtyLabel.Visible = False
        '    ActualQuantityBox.Visible = False
        '    VarianceCheckBox.Visible = False
        '    Try
        '        MyJobsRadio.Checked = True
        '        JOBInfoTable.Clear()
        '        Dim JobQuery As String = "SELECT BatchID,Dealer,Job,Quantity,DateAssigned,timestarted FROM Workflow WHERE JobID=" & IDBox.Text
        '        Dim JobAdapt As New MySqlDataAdapter(JobQuery, SqlConnectionString)
        '        JobAdapt.Fill(JOBInfoTable)
        '        If IsDBNull(JOBInfoTable.Rows(0)(0)) Then
        '            BatchIDLabel.Text = ""
        '        Else
        '            BatchIDLabel.Text = JOBInfoTable.Rows(0)(0)
        '        End If
        '        DealerBox.Text = JOBInfoTable.Rows(0)(1)
        '        JobBox.Text = JOBInfoTable.Rows(0)(2)
        '        QuantityBox.Text = JOBInfoTable.Rows(0)(3)
        '        DateLabel.Text = JOBInfoTable.Rows(0)(4)
        '        MsgBox(JOBInfoTable.Rows(0)(5))
        '        If IsDBNull(JOBInfoTable.Rows(0)(5)) Then
        '            StartButton.Visible = True
        '        Else
        '            StartButton.Visible = False
        '        End If
        '        Exit Sub
        '    Catch ex As Exception
        '        BatchComboBox.Items.Add("Error" & ex.ToString)
        '    End Try
        'End If

        Dim whatnode As TreeNode
        whatnode = JobTreeView.SelectedNode.Parent
        If whatnode.Text = "QA" Then 'If it's a QA job, look in the QA stuffs
            Try
                QaJobsRadio.Checked = True
                Dim QAInfoTable As New DataTable
                Dim QAQuery As String = "SELECT BatchID,Dealership,Job,RecordedQuantity,ActualQuantity,Variance,VarianceApproval,DateAssigned,timestarted FROM QA where QAID='" & IDBox.Text & "'"
                Dim QAAdapt As New MySqlDataAdapter(QAQuery, SqlConnectionString)
                QAAdapt.Fill(QAInfoTable)

                If QAInfoTable.Rows.Count > 0 Then
                    ActualQuantityBox.Visible = True
                    VarianceCheckBox.Visible = True
                    AQtyLabel.Visible = True
                    BatchIDLabel.Text = QAInfoTable.Rows(0)(0)
                    DealerBox.Text = QAInfoTable.Rows(0)(1)
                    JobBox.Text = QAInfoTable.Rows(0)(2)
                    QuantityBox.Text = QAInfoTable.Rows(0)(3)
                    If QAInfoTable.Rows(0)(5) = "1" Then
                        VarianceCheckBox.Checked = True
                        VariancePopUp.Show()
                        If IsDBNull(QAInfoTable.Rows(0)(6)) Then
                            VariancePopUp.VarianceIssueLabel.Text = ""
                        Else
                            VariancePopUp.VarianceIssueLabel.Text = QAInfoTable.Rows(0)(6)
                        End If
                    Else
                        VarianceCheckBox.Checked = False
                    End If
                    ActualQuantityBox.Text = QAInfoTable.Rows(0)(4)
                    DateLabel.Text = QAInfoTable.Rows(0)(7)
                Else
                    ActualQuantityBox.Visible = True
                    VarianceCheckBox.Visible = True
                    BatchIDLabel.Text = ""
                    DealerBox.Text = "Nothing Here"
                    JobBox.Text = "Nothing Here"
                    QuantityBox.Text = ""
                    ActualQuantityBox.Text = ""
                    DateLabel.Text = ""
                End If

            Catch ex As Exception
                SendError.Show()
                SendError.EmpIDLabel.Text = EmployeeID.Text
                SendError.ErrorRTB.Text = ex.ToString
            End Try
            Try 'Now fill the batch info (if applicable)
                Dim BatchQuery As String = "SELECT VIN6 from Batch where BatchID='" & BatchIDLabel.Text & "'"
                Dim BatchAdapt As New MySqlDataAdapter(BatchQuery, SqlConnectionString)
                Dim BatchTable As New DataTable
                BatchAdapt.Fill(BatchTable)
                BatchComboBox.Items.Clear()
                For i = 0 To BatchTable.Rows.Count - 1
                    BatchComboBox.Items.Add(BatchTable.Rows(i)(0))
                Next

            Catch ex As Exception
                BatchComboBox.Items.Clear()
                BatchComboBox.Items.Add("Nothing here")
            End Try

        Else
            AQtyLabel.Visible = False
            ActualQuantityBox.Visible = False
            VarianceCheckBox.Visible = False
            If IDBox.Text = "BB" Or IDBox.Text = "Funding" Or IDBox.Text = "QA" Or IDBox.Text = "Collateral" Or IDBox.Text = "" Then
                BatchIDLabel.Text = ""
                DealerBox.Text = ""
                JobBox.Text = ""
                QuantityBox.Text = ""
                DateLabel.Text = ""
                Exit Sub
            Else
                Try
                    MyJobsRadio.Checked = True
                    JOBInfoTable.Clear()
                    Dim JobQuery As String = "SELECT BatchID,Dealer,Job,Quantity,DateAssigned,TimeStarted FROM Workflow WHERE JobID=" & IDBox.Text
                    Dim JobAdapt As New MySqlDataAdapter(JobQuery, SqlConnectionString)
                    JobAdapt.Fill(JOBInfoTable)
                    If IsDBNull(JOBInfoTable.Rows(0)(0)) Then
                        BatchIDLabel.Text = ""
                    Else
                        BatchIDLabel.Text = JOBInfoTable.Rows(0)(0)
                    End If
                    DealerBox.Text = JOBInfoTable.Rows(0)(1)
                    JobBox.Text = JOBInfoTable.Rows(0)(2)
                    QuantityBox.Text = JOBInfoTable.Rows(0)(3)
                    DateLabel.Text = JOBInfoTable.Rows(0)(4)
                    If IsDBNull(JOBInfoTable.Rows(0)(5)) Then
                        StartButton.Visible = True
                    Else
                        StartButton.Visible = False
                    End If

                Catch ex As Exception
                    SendError.Show()
                    SendError.EmpIDLabel.Text = EmployeeID.Text
                    SendError.ErrorRTB.Text = ex.ToString
                End Try
                Try 'Now fill the batch info (if applicable)
                    Dim BatchQuery As String = "SELECT VIN6 from Batch where BatchID='" & BatchIDLabel.Text & "'"
                    Dim BatchAdapt As New MySqlDataAdapter(BatchQuery, SqlConnectionString)
                    Dim BatchTable As New DataTable
                    BatchAdapt.Fill(BatchTable)
                    BatchComboBox.Items.Clear()
                    For i = 0 To BatchTable.Rows.Count - 1
                        BatchComboBox.Items.Add(BatchTable.Rows(i)(0))
                    Next

                Catch ex As Exception
                    BatchComboBox.Items.Clear()
                    BatchComboBox.Items.Add("Nothing here")
                End Try
            End If
        End If

    End Sub

    Private Sub JobList_SelectedValueChanged(sender As Object, e As EventArgs) Handles JobList.SelectedValueChanged

    End Sub

    Private Sub FlatButton1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub MyJobsRadio_CheckedChanged(sender As Object)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles MyJobsRadio.CheckedChanged
        If MyJobsRadio.Checked = True Then
            JobListSelected = True
            QAList.SelectedIndex = -1
            QAList.Enabled = False
            JobList.Enabled = True
        Else
            JobListSelected = False
            JobList.SelectedIndex = -1
            QAList.Enabled = True
            JobList.Enabled = False
        End If
    End Sub

    Private Sub AutoRefreshToggle_CheckedChanged(sender As Object) Handles AutoRefreshToggle.CheckedChanged
        If AutoRefreshToggle.Checked = True Then
            QueueTimer.Enabled = True
        Else
            QueueTimer.Enabled = False
        End If
    End Sub

    Private Sub FlatButton1_Click_2(sender As Object, e As EventArgs) Handles Reassignbutton.Click
        If IDBox.Text = "" Then
            MsgBox("Can't re-assign a job that doesn't exist", vbOKOnly, "Oops!")
            Exit Sub
        ElseIf StartButton.Visible = True Then
            Reassign.Show()
            If QaJobsRadio.Checked = True Then
                Reassign.QALabel.Visible = True
            Else
                Reassign.QALabel.Visible = False
            End If
            Reassign.JobIdLabel.Text = IDBox.Text
        Else
            Reassign.Show()
            If QaJobsRadio.Checked = True Then
                Reassign.QALabel.Visible = True
            Else
                Reassign.QALabel.Visible = False
            End If
            Reassign.JobIdLabel.Text = ReAssignLabel.Text
        End If
    End Sub

    Private Sub JobTreeView_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles JobTreeView.AfterSelect
        Try
            SelectedNode = JobTreeView.SelectedNode
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Try
            Dim WhatParent As TreeNode
            WhatParent = JobTreeView.SelectedNode.Parent
            If WhatParent Is Nothing Then
                Exit Sub
            ElseIf WhatParent.Text = "QA" Then
                QaJobsRadio.Checked = True
            Else
                MyJobsRadio.Checked = True
            End If
            If StartButton.Visible = False Then
                Dim ReassignID As String() = e.Node.Text.Split(New Char() {"-"c})
                ReAssignLabel.Text = ReassignID(0)
                Exit Sub
            End If
            Dim ID As String() = e.Node.Text.Split(New Char() {"-"c})
            IDBox.Text = ID(0)
        Catch ex As Exception
            SendError.Show()
            SendError.EmpIDLabel.Text = EmployeeID.Text
            SendError.ErrorRTB.Text = ex.ToString
        End Try
    End Sub

    Public Function Refreshme()
        Try
            Using Connection As New MySqlConnection(SqlConnectionString)
                Connection.Open()
                Connection.Close()
            End Using
        Catch ex As Exception
            JobTreeView.Nodes.Clear()
            JobTreeView.Nodes.Add("Connection Lost")
            Return Nothing
            Exit Function
        End Try
        If InAJobLabel.Text = "False" Then
            InAJob = False
        Else
            InAJob = True
        End If
        If JobTreeView.Enabled = False Then
            Return Nothing
            Exit Function
        End If
        If ClockTimeLabel.Text = "" And QueueTimer.Enabled = True Then
            Return Nothing
            Exit Function
        End If
        If ClockTimeLabel.Text = "" Then
            Return Nothing
            Exit Function
        End If

        Try 'Prioritized jobs in treeview
            Dim NoFund As Boolean = False
            Dim NoBB As Boolean = False
            Dim NoCol As Boolean = False
            JobTreeView.Nodes.Clear()
            JobTreeView.Nodes.Add("Funding")
            JobTreeView.Nodes.Add("BB")
            JobTreeView.Nodes.Add("Collateral")
            JobTreeView.Nodes.Add("QA")
            Dim FundingTable As New DataTable
            Dim BBTable As New DataTable
            Dim CollatTable As New DataTable
            Dim NowTime As String = DateTime.Now.ToString("HH:mm:ss")
            Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")
            Dim Todayint As Integer = DateTime.Today.DayOfWeek
            Dim BBQuery As String = "SELECT Dealership from dealername where (schedule='" & Todayint & "' or schedule='0') AND (fundingrequest <> '" & NowDate & "' or fundingrequest IS NULL)"
            Dim FundingQuery As String = "SELECT Dealership from dealername where fundingrequest='" & NowDate & "'"
            Dim CollateralQuery As String = "SELECT Dealership from dealername where (fundingrequest <> '" & NowDate & "' or fundingrequest IS NULL) and (schedule <>'" & Todayint & "' and isactive='1' and schedule <>'0')"
            Dim BBAdapt As New MySqlDataAdapter(BBQuery, SqlConnectionString)
            Dim FundingAdapt As New MySqlDataAdapter(FundingQuery, SqlConnectionString)
            Dim CollateralAdapt As New MySqlDataAdapter(CollateralQuery, SqlConnectionString)
            BBAdapt.Fill(BBTable)
            If BBTable.Rows.Count < 1 Then
                NoBB = True
            End If
            FundingAdapt.Fill(FundingTable)
            If FundingTable.Rows.Count < 1 Then
                NoFund = True
            End If
            CollateralAdapt.Fill(CollatTable)
            If CollatTable.Rows.Count < 1 Then
                NoCol = True
            End If
            'Now set up a table for the 3 types, and then put them in node form
            Dim BBJobTable As New DataTable
            Dim FundingJobTable As New DataTable
            Dim CollatJobTable As New DataTable
            Dim QATable As New DataTable
            'set up the borrowing base schedule jobs
            Dim BBJobquery(BBTable.Rows.Count) As String
            If NoBB = False Then
                For i = 0 To BBTable.Rows.Count - 1
                    BBJobquery(i) = "SELECT JobID,dealer,timestarted from workflow where Dealer='" & BBTable.Rows(i)(0) & "' AND EmpID='" & EmployeeID.Text & "' AND DateCompleted IS NULL"
                    Dim Adapt As New MySqlDataAdapter(BBJobquery(i), SqlConnectionString)
                    Adapt.Fill(BBJobTable)
                Next
                For i = 0 To BBJobTable.Rows.Count - 1
                    Dim TheNode As TreeNode
                    TheNode = JobTreeView.Nodes(1)
                    If IsDBNull(BBJobTable.Rows(i)(2)) Then
                        TheNode.Nodes.Add(BBJobTable.Rows(i)(0) & "-" & BBJobTable(i)(1))
                    Else
                        TheNode.Nodes.Add(BBJobTable.Rows(i)(0) & "-" & BBJobTable(i)(1) & "-Started")
                    End If

                Next
            End If

            'set up the funding request schedule jobs
            If NoFund = False Then
                Dim FundingJobQuery(FundingTable.Rows.Count) As String
                For i = 0 To FundingTable.Rows.Count - 1
                    FundingJobQuery(i) = "SELECT JobID,dealer,timestarted from workflow where Dealer='" & FundingTable.Rows(i)(0) & "' AND EmpID='" & EmployeeID.Text & "' AND DateCompleted IS NULL"
                    Dim Adapt As New MySqlDataAdapter(FundingJobQuery(i), SqlConnectionString)
                    Adapt.Fill(FundingJobTable)
                Next
                For i = 0 To FundingJobTable.Rows.Count - 1
                    Dim TheNode As TreeNode
                    TheNode = JobTreeView.Nodes(0)
                    If IsDBNull(FundingJobTable(i)(2)) Then
                        TheNode.Nodes.Add(FundingJobTable.Rows(i)(0) & "-" & FundingJobTable.Rows(i)(1))
                    Else
                        TheNode.Nodes.Add(FundingJobTable.Rows(i)(0) & "-" & FundingJobTable.Rows(i)(1) & "-Started")
                    End If
                Next
            End If
            'set up the rest of the jobs
            If NoCol = False Then
                Dim CollatJobQuery(CollatTable.Rows.Count) As String
                For i = 0 To CollatTable.Rows.Count - 1
                    CollatJobQuery(i) = "SELECT JobID,dealer,timestarted from workflow where Dealer='" & CollatTable.Rows(i)(0) & "' AND EmpID='" & EmployeeID.Text & "' AND DateCompleted IS NULL"
                    Dim Adapt As New MySqlDataAdapter(CollatJobQuery(i), SqlConnectionString)
                    Adapt.Fill(CollatJobTable)
                Next
                For i = 0 To CollatJobTable.Rows.Count - 1
                    Dim TheNode As TreeNode
                    TheNode = JobTreeView.Nodes(2)
                    If IsDBNull(CollatJobTable(i)(2)) Then
                        TheNode.Nodes.Add(CollatJobTable.Rows(i)(0) & "-" & CollatJobTable.Rows(i)(1))
                    Else
                        TheNode.Nodes.Add(CollatJobTable.Rows(i)(0) & "-" & CollatJobTable.Rows(i)(1) & "-Started")
                    End If

                Next
            End If
            'set up the QA jobs
            Dim QAQuery As String = "SELECT QAID,dealership From QA where EmpID='" & EmployeeID.Text & "' AND DateCompleted IS NULL"
            Dim QAAdapt As New MySqlDataAdapter(QAQuery, SqlConnectionString)
            Dim QAJobTable As New DataTable
            QAAdapt.Fill(QAJobTable)
            If QAJobTable.Rows.Count > 0 Then
                For i = 0 To QAJobTable.Rows.Count - 1
                    Dim TheNode As TreeNode
                    TheNode = JobTreeView.Nodes(3)
                    TheNode.Nodes.Add(QAJobTable.Rows(i)(0) & "-" & QAJobTable.Rows(i)(1))
                Next
            End If
            '            LoginSuccessTimer.Enabled = True
            JobTreeView.ExpandAll()
            JobTreeView.Nodes(3).Collapse()
        Catch ex As Exception
            SendError.Show()
            SendError.EmpIDLabel.Text = EmployeeID.Text
            SendError.ErrorRTB.Text = ex.ToString
        End Try
        If Not IsNothing(SelectedNode) Then
            JobTreeView.SelectedNode = SelectedNode 'attempt to stay on the previously selected item
        End If
        'If InAJob = False Then 'can't figure the inajob function out yet...
        '    Try 'check to see if they are currently in a job (if the job was closed before)
        '        Dim InAJob As String = "SELECT JobID,Dealer,Job,Quantity from Workflow where Timestarted IS NOT NULL and DateCompleted IS NULL and empid='" & EmployeeID.Text & "'"
        '        Dim InaJobTable As New DataTable
        '        Dim InaJobAdapt As New MySqlDataAdapter(InAJob, SqlConnectionString)
        '        InaJobAdapt.Fill(InaJobTable)
        '        If InaJobTable.Rows.Count > 0 Then
        '            'MsgBox(InaJobTable.Rows(0)(0))
        '            InAJob = True
        '            IDBox.Text = InaJobTable.Rows(0)(0)
        '        End If
        '    Catch ex As Exception
        '        MsgBox(ex.ToString)
        '    End Try
        'End If
        Return Nothing
    End Function

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If BatchComboBox.Items.Count > 0 Then
            Try
                Dim Clippy As New StringBuilder
                For i = 0 To BatchComboBox.Items.Count - 1
                    Clippy.Append(" " & BatchComboBox.Items(i).ToString)
                Next
                Clipboard.SetText(Clippy.ToString)
            Catch ex As Exception
                SendError.Show()
                SendError.EmpIDLabel.Text = EmployeeID.Text
                SendError.ErrorRTB.Text = ex.ToString
            End Try
        End If
    End Sub

    Private Sub FlatButton1_Click_3(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Me.Dispose()
        Dashboard.CollateralButton.Enabled = True
    End Sub
End Class