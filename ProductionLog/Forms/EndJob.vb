'Imports System.Data.Oledb
Imports System.Net.Mail
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class EndJob
    Dim SqlConnectionString As String = "Server=192.168.1.34; Database=TimeLogDB; User id=clerk; Password=12345;" 'NUC Database
    Dim ConnectionString As String = "Provider=Microsoft.ACE.MySql.12.0;Data Source=\\pcpserver\pl_share\PrimaLend\Collateral Management\Updates\Timelog.accdb" 'Old Access DB


    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles PartialRadioButton.CheckedChanged
        If PartialRadioButton.Checked = True Then
            PartialQuantityBox.Visible = True
            PartialQuantityLabel.Visible = True
            QtyCompleteLabel.Visible = True
            CommentBox.Text = "Partially done "
        Else
            PartialQuantityBox.Text = ""
            PartialQuantityBox.Visible = False
            PartialQuantityLabel.Visible = False
            QtyCompleteLabel.Visible = False
        End If
    End Sub

    Private Sub EndJob_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Attempt to pull everything over from the clerk screen
        Clerk.Enabled = False
        Try
            If Clerk.VarianceCheckBox.Visible = True Then
                QaLabel.Text = "QA"
                If Clerk.VarianceCheckBox.Checked = True Then
                    VarianceLabel.Visible = True
                Else
                    VarianceLabel.Visible = False
                End If
            Else
                QaLabel.Text = ""
            End If
            EmpIDLabel.Text = Clerk.EmployeeID.Text
            JobIDBox.Text = Clerk.IDBox.Text
            DealerBox.Text = Clerk.DealerBox.Text
            JobBox.Text = Clerk.JobBox.Text
            JobQuantityBox.Text = Clerk.QuantityBox.Text
            BatchLabel.Text = Clerk.BatchIDLabel.Text
        Catch ex As Exception
            MsgBox("Couldn't find the Job information: " & ex.ToString)
        End Try

    End Sub

    Private Sub FinishButton_Click(sender As Object, e As EventArgs) Handles FinishButton.Click
        If PartialRadioButton.Checked = True And PartialQuantityBox.Text = "" Then
            Exit Sub
        End If
        If QaLabel.Text = "" Then
            If PartialRadioButton.Checked = True Then
                Dim QuantityRemain As Integer = 0
                QuantityRemain = JobQuantityBox.Text - PartialQuantityBox.Text
                'MsgBox(QuantityRemain)
                Try
                    Using connection As New MySqlConnection(SqlConnectionString)
                        Dim NowTime As String = Datetime.now.tostring("HH:mm:ss")
                        Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")

                        Dim FinishQuery As String = "UPDATE Workflow SET Variance=True,DateCompleted='" & NowDate & "',TimeCompleted='" & NowTime & "',Comment='" & CommentBox.Text & "' WHERE JobID=" & JobIDBox.Text
                        Dim FinishCommand As New MySqlCommand(FinishQuery, connection)
                        Dim WhoQA As String = "SELECT QAID,QABackup FROM Employee WHERE EmpID=" & EmpIDLabel.Text
                        Dim WhoAdapt As New MySqlDataAdapter(WhoQA, SqlConnectionString)
                        Dim WhoTable As New DataTable
                        WhoAdapt.Fill(WhoTable)
                        Dim partialquery As String = "INSERT INTO Workflow (EmpID,BatchID,DateAssigned,TimeAssigned,Dealer,Job,Quantity,Comment) VALUES('" & EmpIDLabel.Text & "','" & BatchLabel.Text & "','" & NowDate & "','" & NowTime & "','" & DealerBox.Text & "','" & JobBox.Text & "','" & QuantityRemain & "','" & CommentBox.Text & "');"
                        Dim partialcommand As New MySqlCommand(partialquery, connection)
                        Dim qaquery As String
                        qaquery = "INSERT INTO QA (JobID,EmpID,BatchID,Dealership,Job,RecordedQuantity,ActualQuantity,DateAssigned,Variance,VarianceApproval) VALUES ('" & JobIDBox.Text & "','" & WhoTable.Rows(0)(0) & "','" & BatchLabel.Text & "','" & DealerBox.Text & "','" & JobBox.Text & "','" & JobQuantityBox.Text & "','" & PartialQuantityBox.Text & "','" & NowDate & "',True,'Partially complete: " & PartialQuantityBox.Text & " done');"
                        'MsgBox(qaquery)
                        Dim QACommand As New MySqlCommand(qaquery, connection)
                        connection.Open()
                        ' QACommand.ExecuteNonQuery()
                        FinishCommand.ExecuteNonQuery()
                        partialcommand.ExecuteNonQuery()
                        connection.Close()
                    End Using

                    Clerk.SuccessLabel.Enabled = True
                    Clerk.Enabled = True
                    Clerk.JobList.Enabled = True
                    'Clerk.JobList.Items.RemoveAt(Clerk.JobList.SelectedIndex)
                    Clerk.IDBox.Text = ""
                    Clerk.JobBox.Text = ""
                    Clerk.DealerBox.Text = ""
                    Clerk.QuantityBox.Text = ""
                    Clerk.BatchComboBox.Items.Clear()
                    Clerk.BatchIDLabel.Text = ""
                    Clerk.LoginSuccessTimer.Enabled = True
                    Clerk.StartButton.Visible = True
                    Clerk.MyJobsRadio.Enabled = True
                    Clerk.QaJobsRadio.Enabled = True
                    Clerk.Reassignbutton.Visible = True
                    Clerk.JobTreeView.Enabled = True
                    Clerk.Refreshme()
                    Me.Dispose()

                Catch ex As Exception
                    SendError.Show()
                    SendError.EmpIDLabel.Text = EmpIDLabel.Text
                    SendError.ErrorRTB.Text = ex.ToString
                End Try

            ElseIf Big3RadioButton.Checked = True Then
                Try
                    Using connection As New MySqlConnection(SqlConnectionString)
                        Dim NowTime As String = Datetime.now.tostring("HH:mm:ss")
                        Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")

                        Dim FinishQuery As String = "UPDATE Workflow SET Variance=True,DateCompleted='" & NowDate & "',TimeCompleted='" & NowTime & "',Comment='" & CommentBox.Text & "' WHERE JobID=" & JobIDBox.Text
                        Dim FinishCommand As New MySqlCommand(FinishQuery, connection)
                        Dim WhoQA As String = "SELECT QAID,QABackup FROM Employee WHERE EmpID=" & EmpIDLabel.Text
                        Dim WhoAdapt As New MySqlDataAdapter(WhoQA, SqlConnectionString)
                        Dim WhoTable As New DataTable
                        WhoAdapt.Fill(WhoTable)
                        Dim partialquery As String = "INSERT INTO Workflow (EmpID,BatchID,DateAssigned,TimeAssigned,Dealer,Job,Quantity,Comment) VALUES('" & EmpIDLabel.Text & "','" & BatchLabel.Text & "','" & NowDate & "','" & NowTime & "','" & DealerBox.Text & "','" & JobBox.Text & "','" & JobQuantityBox.Text & "','" & CommentBox.Text & "');"
                        Dim partialcommand As New MySqlCommand(partialquery, connection)
                        Dim qaquery As String
                        qaquery = "INSERT INTO QA (JobID,EmpID,BatchID,Dealership,Job,RecordedQuantity,ActualQuantity,DateAssigned,Variance,VarianceApproval) VALUES ('" & JobIDBox.Text & "','" & WhoTable.Rows(0)(0) & "','" & BatchLabel.Text & "','" & DealerBox.Text & "','" & JobBox.Text & "','" & JobQuantityBox.Text & "','" & JobQuantityBox.Text & "','" & NowDate & "',True,'Big 5 Only');"
                        'MsgBox(qaquery)
                        Dim QACommand As New MySqlCommand(qaquery, connection)
                        connection.Open()
                        ' QACommand.ExecuteNonQuery()
                        FinishCommand.ExecuteNonQuery()
                        partialcommand.ExecuteNonQuery()
                        connection.Close()
                    End Using
                    Clerk.SuccessLabel.Enabled = True
                    Clerk.Enabled = True
                    Clerk.JobList.Enabled = True
                    'Clerk.JobList.Items.RemoveAt(Clerk.JobList.SelectedIndex)
                    Clerk.IDBox.Text = ""
                    Clerk.JobBox.Text = ""
                    Clerk.DealerBox.Text = ""
                    Clerk.QuantityBox.Text = ""
                    Clerk.BatchComboBox.Items.Clear()
                    Clerk.BatchIDLabel.Text = ""
                    Clerk.LoginSuccessTimer.Enabled = True
                    Clerk.StartButton.Visible = True
                    Clerk.MyJobsRadio.Enabled = True
                    Clerk.QaJobsRadio.Enabled = True
                    Clerk.JobTreeView.Enabled = True
                    Clerk.Reassignbutton.Visible = True
                    Clerk.Refreshme()
                    Me.Dispose()
                Catch ex As Exception
                    SendError.Show()
                    SendError.EmpIDLabel.Text = EmpIDLabel.Text
                    SendError.ErrorRTB.Text = ex.ToString
                End Try
            Else
                'Complete the job.. Completely.
                Try
                    Using connection As New MySqlConnection(SqlConnectionString)
                        Dim NowTime As String = Datetime.now.tostring("HH:mm:ss")
                        Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")

                        Dim FinishQuery As String = "UPDATE Workflow SET DateCompleted='" & NowDate & "',TimeCompleted='" & NowTime & "',Comment='" & CommentBox.Text & "' WHERE JobID=" & JobIDBox.Text
                        Dim FinishCommand As New MySqlCommand(FinishQuery, connection)
                        Dim WhoQA As String = "SELECT QAID,QABackup FROM Employee WHERE EmpID=" & EmpIDLabel.Text
                        Dim WhoAdapt As New MySqlDataAdapter(WhoQA, SqlConnectionString)
                        Dim WhoTable As New DataTable
                        WhoAdapt.Fill(WhoTable)
                        Dim qaquery As String = ""
                        qaquery = "INSERT INTO QA (JobID,EmpID,BatchID,Dealership,Job,RecordedQuantity,ActualQuantity,DateAssigned) VALUES ('" & JobIDBox.Text & "','" & WhoTable.Rows(0)(0) & "','" & BatchLabel.Text & "','" & DealerBox.Text & "','" & JobBox.Text & "','" & JobQuantityBox.Text & "','" & JobQuantityBox.Text & "','" & NowDate & "');"
                        'MsgBox(qaquery)
                        Dim QACommand As New MySqlCommand(qaquery, connection)
                        connection.Open()
                        If JobBox.Text <> "Labeling" Then
                            QACommand.ExecuteNonQuery()
                        End If
                        FinishCommand.ExecuteNonQuery()
                        connection.Close()
                    End Using
                    Clerk.SuccessLabel.Enabled = True
                    Clerk.Enabled = True
                    Clerk.JobList.Enabled = True
                    'Clerk.JobList.Items.RemoveAt(Clerk.JobList.SelectedIndex)
                    Clerk.IDBox.Text = ""
                    Clerk.JobBox.Text = ""
                    Clerk.DealerBox.Text = ""
                    Clerk.QuantityBox.Text = ""
                    Clerk.BatchComboBox.Items.Clear()
                    Clerk.BatchIDLabel.Text = ""
                    Clerk.LoginSuccessTimer.Enabled = True
                    Clerk.StartButton.Visible = True
                    Clerk.MyJobsRadio.Enabled = True
                    Clerk.QaJobsRadio.Enabled = True
                    Clerk.Reassignbutton.Visible = True
                    Clerk.JobTreeView.Enabled = True
                    Clerk.Refreshme()
                    Me.Dispose()
                Catch ex As Exception
                    SendError.Show()
                    SendError.EmpIDLabel.Text = EmpIDLabel.Text
                    SendError.ErrorRTB.Text = ex.ToString
                End Try
            End If
        Else 'QA JOB END
            Dim OriginalEmpID As Integer = 12
            Dim JobType As String = ""
            Dim Dealer As String = ""
            Dim Batch As String = ""
            Dim Quantity As Integer = 0
            Dim Contracts As Boolean = False
            Dim Neither As Boolean = False

            Try 'Find out which employee is being QA'd to give them the appropriate Labeling and Filing jobs?
                Dim IDQuery As String = "SELECT JOBID,Job,Dealership,BatchID,ActualQuantity from QA WHERE QAID=" & JobIDBox.Text
                Dim IDAdapt As New MySqlDataAdapter(IDQuery, SqlConnectionString)
                Dim IDTable As New DataTable
                IDAdapt.Fill(IDTable)
                Dim EmpQuery As String = "SELECT EmpID FROM Workflow Where JobID=" & IDTable.Rows(0)(0)
                Dim EmpAdapt As New MySqlDataAdapter(EmpQuery, SqlConnectionString)
                Dim EmpTable As New DataTable
                EmpAdapt.Fill(EmpTable)
                OriginalEmpID = EmpTable.Rows(0)(0)
                JobType = IDTable.Rows(0)(1)
                Dealer = IDTable.Rows(0)(2)
                Batch = IDTable.Rows(0)(3)
                Quantity = IDTable.Rows(0)(4)
                Dim Split As String() = JobType.Split(New Char() {" "c})

                If JobType = "CIFR Contracts" Or JobType = "CIFR Contract Exceptions" Or JobType = "CIFR Contract Modifications" Then
                    Contracts = True
                    Neither = False
                ElseIf Split(0) <> "CIFR" Then
                    Contracts = False
                    Neither = True
                Else
                    Contracts = False
                    Neither = False
                End If
                'MsgBox(Contracts & " " & Neither)
            Catch ex As Exception
                SendError.Show()
                SendError.EmpIDLabel.Text = EmpIDLabel.Text
                SendError.ErrorRTB.Text = ex.ToString
            End Try
            Try 'Update the job in the QA table
                Using Connection As New MySqlConnection(SqlConnectionString)
                    Dim NowTime As String = Datetime.now.tostring("HH:mm:ss")
                    Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")

                    Dim FinishQuery As String = "UPDATE QA Set DateCompleted='" & NowDate & "',TimeCompleted='" & NowTime & "',Comment='" & CommentBox.Text & "' WHERE QAID=" & JobIDBox.Text
                    Dim FinishCommand As New MySqlCommand(FinishQuery, Connection)
                    Connection.Open()
                    FinishCommand.ExecuteNonQuery()
                    Connection.Close()
                End Using
                Try ' Create a new job for the original employee to FILE/LABEL
                    If Contracts = True Then 'If it is contracts, set up a labeling job AND a filing job, else set up just the filing job.
                        Dim NowTime As String = Datetime.now.tostring("HH:mm:ss")
                        Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")
                        Dim NewFileQuery As String = "INSERT INTO WorkFlow (EmpID,DateAssigned,TimeAssigned,Dealer,Job,BatchID,Quantity) VALUES ('" & OriginalEmpID & "','" & NowDate & "','" & NowTime & "','" & Dealer & "','Labeling','" & Batch & "','" & Quantity & "');"
                        Dim NewLabelQuery As String = "INSERT INTO WorkFlow (EmpID,DateAssigned,TimeAssigned,Dealer,Job,BatchID,Quantity) VALUES ('" & OriginalEmpID & "','" & NowDate & "','" & NowTime & "','" & Dealer & "','Filing','" & Batch & "','" & Quantity & "');"
                        Using Connection As New MySqlConnection(SqlConnectionString)
                            Dim NewFileCommand As New MySqlCommand(NewFileQuery, Connection)
                            Dim NewLabelCommand As New MySqlCommand(NewLabelQuery, Connection)
                            Connection.Open()
                            NewFileCommand.ExecuteNonQuery()
                            NewLabelCommand.ExecuteNonQuery()
                            Connection.Close()
                        End Using
                    ElseIf Contracts = False And Neither = False Then
                        Dim NowTime As String = DateTime.Now.ToString("HH:mm:ss")
                        Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")

                        Dim JustFileQuery As String = "INSERT INTO WorkFlow (EmpID,DateAssigned,TimeAssigned,Dealer,Job,BatchID,Quantity) VALUES ('" & OriginalEmpID & "','" & NowDate & "','" & NowTime & "','" & Dealer & "','Filing','" & Batch & "','" & Quantity & "');"
                        Using Connection As New MySqlConnection(SqlConnectionString)
                            Dim justfilecommand As New MySqlCommand(JustFileQuery, Connection)
                            Connection.Open()
                            justfilecommand.ExecuteNonQuery()
                            Connection.Close()
                        End Using
                    End If
                Catch ex As Exception
                    SendError.Show()
                    SendError.EmpIDLabel.Text = EmpIDLabel.Text
                    SendError.ErrorRTB.Text = ex.ToString
                End Try

                Clerk.SuccessLabel.Enabled = True
                Clerk.Enabled = True
                'Clerk.QAList.Items.RemoveAt(Clerk.QAList.SelectedIndex)
                Clerk.QAList.Enabled = True
                Clerk.IDBox.Text = ""
                Clerk.JobBox.Text = ""
                Clerk.DealerBox.Text = ""
                Clerk.QuantityBox.Text = ""
                Clerk.BatchComboBox.Items.Clear()
                Clerk.BatchIDLabel.Text = ""
                Clerk.LoginSuccessTimer.Enabled = True
                Clerk.StartButton.Visible = True
                Clerk.MyJobsRadio.Enabled = True
                Clerk.QaJobsRadio.Enabled = True
                Clerk.Reassignbutton.Visible = True
                Clerk.JobTreeView.Enabled = True
                Clerk.Refreshme()
                Me.Dispose()

            Catch ex As Exception
                SendError.Show()
                SendError.EmpIDLabel.Text = EmpIDLabel.Text
                SendError.ErrorRTB.Text = ex.ToString
            End Try

        End If

        Clerk.InAJobLabel.Text = "True"

    End Sub

    Private Sub Big3RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles Big3RadioButton.CheckedChanged
        If Big3RadioButton.Checked = True Then
            CommentBox.Text = "Big 5 Only"
        End If
    End Sub

    Private Sub CompleteRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles CompleteRadioButton.CheckedChanged
        If CompleteRadioButton.Checked = True Then
            CommentBox.Enabled = True
            CommentBox.Text = ""
        End If
    End Sub
End Class