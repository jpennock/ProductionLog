Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class Whiteboard
    Dim RightClicked As Boolean = False
    Dim isQA As Boolean = False
    Dim ContextID As String = ""
    Dim ContextJob As String = ""
    Dim SqlConnectionString As String = "Server=192.168.1.34; Database=TimeLogDB; User id=clerk; Password=12345;" 'NUC Database
    Private Sub Whiteboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Refresher()
        Catch ex As Exception

        End Try
    End Sub
    Public Function Refresher()
        Try
            JobsTreeView.Nodes.Clear()
            ScheduleTreeview.Nodes.Clear()
            CollateralTreeView.Nodes.Clear()
            CollateralTreeView.Nodes.Add("Contracts")
            CollateralTreeView.Nodes.Add("Contract Corrections")
            CollateralTreeView.Nodes.Add("Contract Modifications")
            CollateralTreeView.Nodes.Add("Contract Titles")
            CollateralTreeView.Nodes.Add("Floor Titles")
            CollateralTreeView.Nodes.Add("Auction Slips")
            JobsTreeView.Nodes.Add("Contracts")
            JobsTreeView.Nodes.Add("Contract Corrections")
            JobsTreeView.Nodes.Add("Contract Modifications")
            JobsTreeView.Nodes.Add("Contract Titles")
            JobsTreeView.Nodes.Add("Floor Titles")
            JobsTreeView.Nodes.Add("Auction Slips")
            JobsTreeView.Nodes.Add("QA")

            ScheduleTreeview.Nodes.Add("Funding Requested")
            ScheduleTreeview.Nodes.Add("Borrowing Base")
            Try 'fill the Schedule with Funding requests and borrowing bases
                Dim NowTime As String = DateTime.Now.ToString("HH:mm:ss")
                Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")
                Dim Todayint As Integer = DateTime.Today.DayOfWeek
                Dim FundQuery As String = "SELECT Dealership,BBSentDate from dealername where fundingrequest='" & NowDate & "'"
                Dim FundTable As New DataTable
                Dim FundAdapt As New MySqlDataAdapter(FundQuery, SqlConnectionString)
                Dim BBQuery As String = "SELECT Dealership,BBSentDate from dealername where (schedule='" & Todayint & "' or schedule='0') AND (fundingrequest <> '" & NowDate & "' or fundingrequest IS NULL)"
                Dim BBTable As New DataTable
                Dim BBAdapt As New MySqlDataAdapter(BBQuery, SqlConnectionString)
                FundAdapt.Fill(FundTable)
                BBAdapt.Fill(BBTable)
                If FundTable.Rows.Count > 0 Then
                    Dim FundNode As TreeNode = ScheduleTreeview.Nodes(0)
                    For i = 0 To FundTable.Rows.Count - 1
                        If IsDBNull(FundTable.Rows(i)(1)) Then
                            FundNode.Nodes.Add(FundTable.Rows(i)(0))
                        ElseIf FundTable.Rows(i)(1) <> NowDate Then
                            FundNode.Nodes.Add(FundTable.Rows(i)(0))
                        Else
                            FundNode.Nodes.Add(FundTable.Rows(i)(0) & " - (Sent)")
                        End If
                    Next
                End If
                If BBTable.Rows.Count > 0 Then
                    Dim BBNode As TreeNode = ScheduleTreeview.Nodes(1)
                    For i = 0 To BBTable.Rows.Count - 1
                        If IsDBNull(BBTable.Rows(i)(1)) Then
                            BBNode.Nodes.Add(BBTable.Rows(i)(0))
                        ElseIf BBTable.Rows(i)(1) <> NowDate Then
                            BBNode.Nodes.Add(BBTable.Rows(i)(0))
                        Else
                            BBNode.Nodes.Add(BBTable.Rows(i)(0) & " - (Sent)")
                        End If
                    Next
                End If
                ScheduleTreeview.ExpandAll()
            Catch ex As Exception
                SendError.Show()
                SendError.EmpIDLabel.Text = "14"
                SendError.ErrorRTB.Text = ex.ToString
            End Try

            Try 'Load up the collateral tree
                Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")
                Dim BatchQuery As String = "SELECT Dealership,Collateral,Count(Collateral) FROM Batch WHERE DateReceived='" & NowDate & "' GROUP BY Dealership,Collateral"
                If TrackBar1.Value > 1 Then
                    BatchQuery = "SELECT Dealership,Collateral,Count(Collateral) FROM Batch WHERE Datereceived BETWEEN Date_Sub(Now(), INTERVAL " & TrackBar1.Value + 1 & " DAY) AND Now() GROUP BY Dealership,Collateral"
                Else
                    BatchQuery = "SELECT Dealership,Collateral,Count(Collateral) FROM Batch WHERE DateReceived='" & NowDate & "' GROUP BY Dealership,Collateral"
                End If
                Dim Workquery As String = "SELECT Workflow.JobID, Employee.EmpFirst AS Name, Workflow.DateAssigned, Workflow.TimeAssigned, Workflow.DateStarted, Workflow.TimeStarted, Workflow.DateCompleted, Workflow.TimeCompleted, Workflow.Dealer, Workflow.Job, Workflow.Quantity, Workflow.Comment FROM Workflow INNER JOIN Employee ON Workflow.EmpID=Employee.EmpID WHERE Job LIKE '%CIFR%' AND DateCompleted IS NULL ORDER BY Dealer" 'This is the grouped Job List
                Dim MinQuery As String = "SELECT Min(DateAssigned) From Workflow Where DateCompleted IS NULL AND Job LIKE '%CIFR%'"
                Dim MinAdapt As New MySqlDataAdapter(MinQuery, SqlConnectionString)
                Dim MinTable As New DataTable
                MinAdapt.Fill(MinTable)
                MinDateLabel.Text = "Oldest Date: " & MinTable.Rows(0)(0)
                Dim Batch1Adapt As New MySqlDataAdapter(BatchQuery, SqlConnectionString)  'The real one
                Dim BatchAdapt As New MySqlDataAdapter(Workquery, SqlConnectionString) ' The test one
                Dim BatchTable As New DataTable
                Dim Batch1Table As New DataTable
                BatchAdapt.Fill(BatchTable)
                Batch1Adapt.Fill(Batch1Table)
                If BatchTable.Rows.Count > 0 Then

                    For i = 0 To Batch1Table.Rows.Count - 1
                        If Batch1Table.Rows(i)(1) = "Contracts" Then
                            Dim Noder As TreeNode = CollateralTreeView.Nodes(0)
                            Noder.Nodes.Add(Batch1Table.Rows(i)(0) & ": " & Batch1Table.Rows(i)(2))
                        ElseIf Batch1Table.Rows(i)(1) = "Contract Corrections" Then
                            Dim Noder As TreeNode = CollateralTreeView.Nodes(1)
                            Noder.Nodes.Add(Batch1Table.Rows(i)(0) & ": " & Batch1Table.Rows(i)(2))
                        ElseIf Batch1Table.Rows(i)(1) = "Contract Modifications" Then
                            Dim Noder As TreeNode = CollateralTreeView.Nodes(2)
                            Noder.Nodes.Add(Batch1Table.Rows(i)(0) & ": " & Batch1Table.Rows(i)(2))
                        ElseIf Batch1Table.Rows(i)(1) = "Contract Titles" Then
                            Dim Noder As TreeNode = CollateralTreeView.Nodes(3)
                            Noder.Nodes.Add(Batch1Table.Rows(i)(0) & ": " & Batch1Table.Rows(i)(2))
                        ElseIf Batch1Table.Rows(i)(1) = "Floor Titles" Then
                            Dim Noder As TreeNode = CollateralTreeView.Nodes(4)
                            Noder.Nodes.Add(Batch1Table.Rows(i)(0) & ": " & Batch1Table.Rows(i)(2))
                        ElseIf Batch1Table.Rows(i)(1) = "Auction Slips" Then
                            Dim Noder As TreeNode = CollateralTreeView.Nodes(5)
                            Noder.Nodes.Add(Batch1Table.Rows(i)(0) & ": " & Batch1Table.Rows(i)(2))
                        End If
                    Next
                    'fill up the job tree
                    For i = 0 To BatchTable.Rows.Count - 1
                        Dim ToBeSplit As String = BatchTable.Rows(i)(9)
                        Dim TheSplit As String() = ToBeSplit.Split(New Char() {" "c})
                        If TheSplit.Count < 3 Then
                            Dim Noder As TreeNode = JobsTreeView.Nodes(0)
                            Noder.Nodes.Add(BatchTable.Rows(i)(0) & "-" & BatchTable.Rows(i)(8) & " - " & BatchTable.Rows(i)(10) & " - " & BatchTable.Rows(i)(1) & " (" & BatchTable.Rows(i)(11) & ")")
                        ElseIf TheSplit(2) = "Corrections" Then
                            Dim Noder As TreeNode = JobsTreeView.Nodes(1)
                            Noder.Nodes.Add(BatchTable.Rows(i)(0) & "-" & BatchTable.Rows(i)(8) & " - " & BatchTable.Rows(i)(10) & " - " & BatchTable.Rows(i)(1) & " (" & BatchTable.Rows(i)(11) & ")")
                        ElseIf TheSplit(2) = "Modifications" Then
                            Dim Noder As TreeNode = JobsTreeView.Nodes(2)
                            Noder.Nodes.Add(BatchTable.Rows(i)(0) & "-" & BatchTable.Rows(i)(8) & " - " & BatchTable.Rows(i)(10) & " - " & BatchTable.Rows(i)(1) & " (" & BatchTable.Rows(i)(11) & ")")
                        ElseIf TheSplit(1) = "Contract" Then
                            Dim Noder As TreeNode = JobsTreeView.Nodes(3)
                            Noder.Nodes.Add(BatchTable.Rows(i)(0) & "-" & BatchTable.Rows(i)(8) & " - " & BatchTable.Rows(i)(10) & " - " & BatchTable.Rows(i)(1) & " (" & BatchTable.Rows(i)(11) & ")")
                        ElseIf TheSplit(1) = "Floor" Then
                            Dim Noder As TreeNode = JobsTreeView.Nodes(4)
                            Noder.Nodes.Add(BatchTable.Rows(i)(0) & "-" & BatchTable.Rows(i)(8) & " - " & BatchTable.Rows(i)(10) & " - " & BatchTable.Rows(i)(1) & " (" & BatchTable.Rows(i)(11) & ")")
                        ElseIf TheSplit(1) = "Auction" Then
                            Dim Noder As TreeNode = JobsTreeView.Nodes(5)
                            Noder.Nodes.Add(BatchTable.Rows(i)(0) & "-" & BatchTable.Rows(i)(8) & " - " & BatchTable.Rows(i)(10) & " - " & BatchTable.Rows(i)(1) & " (" & BatchTable.Rows(i)(11) & ")")
                        End If
                    Next
                    'fill up the QA section
                    Dim QAquery As String = "Select QA.qaid,employee.empfirst,qa.jobid,qa.comment from qa inner join employee on qa.empid=employee.empid where datecompleted IS NULL"
                    Dim QAAdapt As New MySqlDataAdapter(QAquery, SqlConnectionString)
                    Dim QATable As New DataTable
                    QAAdapt.Fill(QATable)
                    For i = 0 To QATable.Rows.Count - 1
                        Dim noder As TreeNode = JobsTreeView.Nodes(6)
                        noder.Nodes.Add(QATable.Rows(i)(0) & "-" & QATable.Rows(i)(1) & "-" & QATable.Rows(i)(2) & " (" & QATable.Rows(i)(3) & ")")
                    Next
                    JobsTreeView.ExpandAll()
                    JobsTreeView.Nodes(6).Collapse()
                End If
                CollateralTreeView.ExpandAll()
            Catch ex As Exception
                SendError.Show()
                SendError.EmpIDLabel.Text = "14"
                SendError.ErrorRTB.Text = ex.ToString
            End Try

        Catch ex As Exception
            SendError.Show()
            SendError.EmpIDLabel.Text = "14"
            SendError.ErrorRTB.Text = ex.ToString
        End Try
        Return Nothing
    End Function

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Me.Dispose()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Refresher()
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        Refresher()
    End Sub

    Private Sub UpdateTrackBar_Scroll(sender As Object, e As EventArgs) Handles UpdateTrackBar.Scroll
        Dim Numero As Integer = 0
        Try
            Numero = UpdateTrackBar.Value * 10
            Timer1.Interval = Numero * 1000
            Updatinglabel.Text = "Refreshing every " & (Timer1.Interval / 1000) & " seconds."
        Catch ex As Exception
            SendError.Show()
            SendError.EmpIDLabel.Text = "14"
            SendError.ErrorRTB.Text = ex.ToString
        End Try

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Try
            If TrackBar1.Value > 1 Then
                CollatDayLabel.Text = "Collateral last " & TrackBar1.Value & " days:"
            Else
                CollatDayLabel.Text = "Collateral Today:"
            End If
        Catch ex As Exception
            SendError.Show()
            SendError.EmpIDLabel.Text = "14"
            SendError.ErrorRTB.Text = ex.ToString
        End Try
    End Sub

    Private Sub JobsTreeView_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles JobsTreeView.AfterSelect
        Dim SelectedNode As TreeNode
        Try
            SelectedNode = JobsTreeView.SelectedNode
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Try
            Dim WhatParent As TreeNode
            WhatParent = JobsTreeView.SelectedNode.Parent
            If WhatParent Is Nothing Then
                Exit Sub
            ElseIf WhatParent.Text = "QA" Then
                isQA = True
            End If
            Dim ID As String() = e.Node.Text.Split(New Char() {"-"c})
            ContextID = ID(0)
            ContextJob = e.Node.Text
        Catch ex As Exception
            SendError.Show()
            SendError.EmpIDLabel.Text = "14"
            SendError.ErrorRTB.Text = ex.ToString
        End Try
        
    End Sub

    Private Sub JobsTreeView_MouseClick(sender As Object, e As MouseEventArgs) Handles JobsTreeView.MouseClick

    End Sub

    Private Sub JobsTreeView_MouseUp(sender As Object, e As MouseEventArgs) Handles JobsTreeView.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(CType(sender, Control), e.Location)
        End If
    End Sub

    Private Sub JobsTreeView_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles JobsTreeView.NodeMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            JobsTreeView.SelectedNode = e.Node
            RightClicked = True
        End If
    End Sub

    Private Sub ReAssignToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReAssignToolStripMenuItem.Click
        Try 'this allows the currently selected job to be re-assigned from the viewer window
            Reassign.Show()
            Reassign.JobIdLabel.Text = ContextID
            If isQA = True Then
                Reassign.QALabel.Visible = True
            Else
                Reassign.QALabel.Visible = False
            End If
        Catch ex As Exception
            SendError.Show()
            SendError.EmpIDLabel.Text = "14"
            SendError.ErrorRTB.Text = ex.ToString
        End Try
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        Clipboard.SetText(ContextJob.ToString) 'this allows the current job to be copied to the clipboard
    End Sub
End Class