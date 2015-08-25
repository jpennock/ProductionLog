﻿'*********************************************************************************************************************************************
'                                           Primalend Production Log
'                                            Creator: Joe Pennock
'                                       Date Started: (New project) 12/1/2014
'Although the original Timelog is working, it is becoming a bit too buggy and inefficient. This new project 
'aims to reduce overall bugs, increase efficiency, aesthetics and data collection performance. The manual job selector
'will not be included from the start in this new program, and limited to NO file saving capabilities will be built in (a cause of many bugs in the prior version)
'Update LOG:
'12/22/14 Mysql server set up and running. Much quicker transactions. Also allowing employees to re-assign jobs as they see fit, with just an email notifying them of the change.
'**********************************************************************************************************************************************
Imports System.Text
Imports System
Imports System.IO
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class Dashboard
    Dim ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\pcpserver\pl_share\PrimaLend\Collateral Management\Updates\Timelog.accdb"
    Dim SqlConnectionString As String = "Server=192.168.1.34; Database=TimeLogDB; User id=clerk; Password=12345;" 'NUC Database
    Dim StillHya As Boolean = False



    Private Sub Dashboard_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed

    End Sub
    Private Sub Dashboard_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub Dashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub Dashboard_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Private Sub Dashboard_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.F1 Then
            Viewer.Show()
        End If
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try 'Test the mysql connection, to see if I need to convert completely this weekend :) (8/18/15 Don't remember why I wrote this first part, but I like keeping it here.)
            Using Connection As New MySqlConnection(SqlConnectionString)
                Connection.Open()
                Connection.Close()
            End Using

            Dim teamquery As String = "Select iswolfpack from employee where empid=" & IDLabel.Text
            Dim teamadapt As New MySqlDataAdapter(teamquery, SqlConnectionString)
            Dim teamtable As New DataTable
            teamadapt.Fill(teamtable)

            If teamtable.Rows.Count > 0 Then
                If teamtable.Rows(0)(0) = 1 Or teamtable.Rows(0)(0) = 9 Then
                    Overwatch.Show()
                End If
            End If

            'Overwatch.Show() 'remove this comment line to enable the palantir


            'Dim Table As New DataTable
            'Dim Query As String = "SELECT BugMessage from BugTracker where BugID='1'"
            'Dim Adapt As New MySqlDataAdapter(Query, SqlConnectionString)
            'Adapt.Fill(Table)
            'If Table.Rows.Count > 0 Then

            'End If


        Catch ex As Exception
            SendError.Show()
            SendError.EmpIDLabel.Text = "14"
            SendError.ErrorRTB.Text = ex.ToString
        End Try

    End Sub

    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub

    Private Sub CollateralButton_Click(sender As Object, e As EventArgs) Handles CollateralButton.Click
        Clerk.Show()
        CollateralButton.Enabled = False
    End Sub

    Private Sub FlatClose1_Click(sender As Object, e As EventArgs) Handles FlatClose1.Click
        If Clerk.EmployeeID.Text = "0" Then
            Me.Dispose()
            Exit Sub
        Else
            Try
                Using Connection As New MySqlConnection(SqlConnectionString)
                    Dim LoginQuery As String = "UPDATE Employee SET IsLogin=False WHERE EmpID=" & Clerk.EmployeeID.Text
                    Dim LoginCommand As New MySqlCommand(LoginQuery, Connection)
                    Connection.Open()
                    LoginCommand.ExecuteNonQuery()
                    Connection.Close()
                End Using
                Me.Dispose()
            Catch ex As Exception
                MsgBox("Had trouble showing you as logged out on the server, please let your manager know " & ex.ToString)
                Me.Dispose()
            End Try
        End If
    End Sub

    Private Sub OttoButton_Click(sender As Object, e As EventArgs) Handles OttoButton.Click
        Otto.Show()
    End Sub

    Private Sub ManagerButton_Click(sender As Object, e As EventArgs) Handles ManagerButton.Click
        Try
            Dim Query As String = "SELECT * FROM `employee` where isMonitored=1"
            Dim TeamAdapt As New MySqlDataAdapter(Query, SqlConnectionString)
            Dim TeamTable As New DataTable
            TeamAdapt.Fill(TeamTable)
            If TeamTable.Rows.Count > 0 Then
                For i = 0 To TeamTable.Rows.Count - 1
                    If IDLabel.Text = TeamTable.Rows(i)(0).ToString Then
                        'MsgBox(TeamTable.Rows(i)(0).ToString & " " & IDLabel.Text)
                        TeamLead.Show()
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub WhiteboardButton_Click(sender As Object, e As EventArgs) Handles WhiteboardButton.Click 'Pull Requests
        If IDLabel.Text = 0 Then
            MsgBox("Log in through the work queue")
        Else
            Try
                Dim NowTime As String = DateTime.Now.ToString("HH:mm:ss")
                Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")

                Dim NewJobQuery As String = "INSERT INTO Workflow (EmpID,DateAssigned,TimeAssigned,TimeStarted,Dealer,Job,DateStarted) VALUES ('" & IDLabel.Text & "','" & NowDate & "','" & NowTime & "','" & NowTime & "','Primalend','Pull Requests','" & NowDate & "');"
                Using Connection As New MySqlConnection(SqlConnectionString)
                    Dim NewCommand As New MySqlCommand(NewJobQuery, Connection)
                    Connection.Open()
                    NewCommand.ExecuteNonQuery()
                    Connection.Close()
                End Using
                PullRequest.Show()
            Catch ex As Exception
                MsgBox("Couldn't start the job, get Joe please! : " & ex.ToString)
                Exit Sub
            End Try
        End If

    End Sub

    Private Sub StillHere_Tick(sender As Object, e As EventArgs) Handles StillHere.Tick
        If Application.OpenForms().OfType(Of Otto).Any Then
            Exit Sub
        End If
        If TimeOfDay = "3:00:00 PM" Then
            MsgBox("Don't forget to start locking up those filing cabinets!", vbOKOnly, "Yay!")
        End If
        If TimeOfDay = "5:00:00 PM" Or TimeOfDay = "8:30:00 PM" Then
            VerifyStillHere.Show()
            StillHere.Stop()
        ElseIf TimeOfDay = "11:59:00 PM" Then
            Me.Dispose()
        End If
    End Sub

    Private Sub FormSkin1_KeyUp(sender As Object, e As KeyEventArgs) Handles FormSkin1.KeyUp
        If e.KeyCode = Keys.F1 Then
            Viewer.Show()
        End If
    End Sub

    Private Sub ViewButton_Click(sender As Object, e As EventArgs) Handles ViewButton.Click
        If IDLabel.Text = "1" Then
            Manager.Show()
        Else
            Whiteboard.Show()
        End If

    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlatButton1_Click_1(sender As Object, e As EventArgs)
        'Viewer.Show()
    End Sub

    Private Sub FlatButton1_Click_2(sender As Object, e As EventArgs) Handles FlatButton1.Click
        'Manager.Show()
        'Overwatch.Show()
        DBA.Show()
        'MsgBox(DateTime.Today.DayOfWeek)

    End Sub
End Class