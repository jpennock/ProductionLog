Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class Manager
    Dim SqlConnectionString As String = "Server=192.168.1.34; Database=TimeLogDB; User id=clerk; Password=12345;" 'NUC Database
    Dim UpdateTable As New DataTable 'Use this to update the treeviews after the initial data dump
    Dim FundTable As New DataTable ' use this for the funding tree
    Dim BBTable As New DataTable ' use this for the borrowing base tree
    Dim WorkTable As New DataTable 'use this for the CIFR work tree
    Dim FrozenTable As New DataTable 'use this for DO NOT FUND list


    Private Sub Manager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim NowTime As String = DateTime.Now.ToString("HH:mm:ss")
            Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")
            Dim Todayint As Integer = DateTime.Today.DayOfWeek
            Dim FundQuery As String = "SELECT Dealership,BBSentDate from dealername where fundingrequest='" & NowDate & "'"
            Dim FundAdapt As New MySqlDataAdapter(FundQuery, SqlConnectionString)
            Dim BBQuery As String = "SELECT Dealership,BBSentDate from dealername where (schedule='" & Todayint & "' or schedule='0') AND (fundingrequest <> '" & NowDate & "' or fundingrequest IS NULL) and isactive=1"
            Dim BBAdapt As New MySqlDataAdapter(BBQuery, SqlConnectionString)
            Dim FrozenQuery As String = "SELECT Dealership from dealername where isFrozen=1 and isactive='1'"
            Dim FrozenAdapt As New MySqlDataAdapter(FrozenQuery, SqlConnectionString)
            FrozenAdapt.Fill(FrozenTable)
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
            If FrozenTable.Rows.Count > 0 Then
                Dim FrozenNode As TreeNode = ScheduleTreeview.Nodes(2)
                FrozenNode.ForeColor = Color.Red
                For i = 0 To FrozenTable.Rows.Count - 1
                    FrozenNode.Nodes.Add(FrozenTable(i)(0))
                Next
                For i = 0 To FrozenNode.Nodes.Count - 1
                    FrozenNode.Nodes(i).ForeColor = Color.Red
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
            BatchQuery = "SELECT Dealership,Collateral,Count(Collateral) FROM Batch WHERE DateReceived='" & NowDate & "' GROUP BY Dealership,Collateral"
            Dim Workquery As String = "SELECT Workflow.JobID, Employee.EmpFirst AS Name, Workflow.DateAssigned, Workflow.TimeAssigned, Workflow.DateStarted, Workflow.TimeStarted, Workflow.DateCompleted, Workflow.TimeCompleted, Workflow.Dealer, Workflow.Job, Workflow.Quantity, Workflow.Comment FROM Workflow INNER JOIN Employee ON Workflow.EmpID=Employee.EmpID WHERE Job LIKE '%CIFR%' AND DateCompleted IS NULL ORDER BY Dealer" 'This is the grouped Job List
            Dim MinQuery As String = "SELECT Min(DateAssigned) From Workflow Where DateCompleted IS NULL AND Job LIKE '%CIFR%'"
            Dim MinAdapt As New MySqlDataAdapter(MinQuery, SqlConnectionString)
            Dim MinTable As New DataTable
            MinAdapt.Fill(MinTable)
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
            End If
            CollateralTreeView.ExpandAll()
        Catch ex As Exception
            SendError.Show()
            SendError.EmpIDLabel.Text = "14"
            SendError.ErrorRTB.Text = ex.ToString
        End Try
        Try
            Dim ClientQuery As String = "SELECT workflow.Dealer,employee.EmpFirst as Clerk from workflow inner join employee on workflow.EmpID = employee.EmpID where workflow.Job like '%CIFR%' and workflow.DateCompleted is null group by workflow.Dealer ORDER BY `workflow`.`Dealer` ASC"
            Dim WorkAdapt As New MySqlDataAdapter(ClientQuery, SqlConnectionString)
            WorkAdapt.Fill(WorkTable)
            If WorkTable.Rows.Count > 0 Then
                For i = 0 To WorkTable.Rows.Count - 1
                    Dim Noder As TreeNode = WorkTree.Nodes(0)
                    Noder.Nodes.Add(WorkTable(i)(0) & " - " & WorkTable(i)(1))
                Next
            End If
            WorkTree.ExpandAll()
        Catch ex As Exception
            SendError.Show()
            SendError.EmpIDLabel.Text = "14"
            SendError.ErrorRTB.Text = ex.ToString
        End Try


    End Sub
    Private Sub XButton_Click(sender As Object, e As EventArgs) Handles XButton.Click
        Me.Dispose()
    End Sub
    Private Sub TestTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs)
        'Try
        '    If TestListBox.Items.Count > 0 Then
        '        Dim fundnode As TreeNode = ScheduleTreeview.Nodes(0)
        '        Dim fundtable As New DataTable
        '        fundtable.Columns.Add("list")
        '        fundtable.Columns.Add("remove")
        '        Dim listtable As New DataTable
        '        listtable.Columns.Add("list")
        '        listtable.Columns.Add("checked")
        '        For i = 0 To TestListBox.Items.Count - 1
        '        Next
        '        For i = 0 To fundnode.Nodes.Count - 1
        '            fundtable.Rows.Add(fundnode.Nodes(i).Text.ToString)
        '        Next
        '        For i = 0 To fundtable.Rows.Count - 1
        '            Dim checkit As String = fundtable.Rows(i)(0).ToString
        '            For l = TestListBox.Items.Count - 1 To 0 Step -1
        '                If checkit = TestListBox.Items(l).ToString Then
        '                    TestListBox.Items.RemoveAt(l)
        '                    fundtable.Rows(i)(1) = "t"
        '                End If
        '            Next
        '        Next
        '        For i = fundtable.Rows.Count - 1 To 0 Step -1
        '            If IsDBNull(fundtable.Rows(i)(1)) Then
        '                fundnode.Nodes.RemoveAt(i)
        '                'MsgBox(fundtable.Rows(i)(0).ToString)
        '            Else

        '            End If
        '        Next
        '        For i = 0 To TestListBox.Items.Count - 1
        '            fundnode.Nodes.Add(TestListBox.Items(i).ToString)
        '        Next
        '        TestListBox.Items.Clear()
        '        ScheduleTreeview.ExpandAll()
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try

        Try

        Catch ex As Exception

        End Try

    End Sub

    Private Function Refreshme()

        Return Nothing
    End Function
End Class
