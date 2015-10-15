Imports System.Data.OleDb
Imports System.Text
Imports System.Net.Mail
Imports MySql.Data.MySqlClient

Public Class CollateralLog
    Dim SuccessSeconds As Integer = 0
    Dim ConnectionString As String = "Provider=Microsoft.ACE.OledbB.12.0;Data Source=\\pcpserver\pl_share\PrimaLend\Collateral Management\Updates\Timelog.accdb" 'Old access db
    Dim SqlConnectionString As String = "Server=192.168.1.34; Database=TimeLogDB; User id=clerk; Password=12345;" 'NUC Database
    Dim JobQuantity As Integer = 0

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim NeedUpdate As Integer = 0
        Dim UpdateDealer As String = DealershipComboBox.Text
        If MsgBox("Are you sure you'd like to add this batch?", vbYesNo, "Sure?") = MsgBoxResult.Yes Then
            Me.Enabled = False
            If ManualToggleCheckBox.CheckState = CheckState.Checked Then
                If MyCountBox.Text = ListCountBox.Text Then
                    Try 'insert all on the list at the same time, so otto can keep working without waiting for people to finish the reception job - TESTING
                        Dim NowTime As String = DateTime.Now.ToString("HH:mm:ss")
                        Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")
                        Dim QueryBuilt As New StringBuilder
                        QueryBuilt.Append("INSERT INTO Batch (BatchID,EmpID,Dealership,Collateral,VIN6,DateReceived,Timereceived) VALUES")
                        For i = 0 To CollateralList.Items.Count - 1
                            If i = CollateralList.Items.Count - 1 Then
                                QueryBuilt.Append("('" & BatchLabel.Text & "','" & Clerk.EmployeeID.Text & "','" & DealershipComboBox.Text & "','" & CollateralComboBox.Text & "','" & CollateralList.Items(i) & "','" & NowDate & "','" & NowTime & "');")
                            Else
                                QueryBuilt.Append("('" & BatchLabel.Text & "','" & Clerk.EmployeeID.Text & "','" & DealershipComboBox.Text & "','" & CollateralComboBox.Text & "','" & CollateralList.Items(i) & "','" & NowDate & "','" & NowTime & "'),")
                            End If
                            JobQuantity += 1 'collateral log job quantity
                        Next
                        Using Connection As New MySqlConnection(SqlConnectionString)
                            Dim command As New MySqlCommand(QueryBuilt.ToString, Connection)
                            Connection.Open()
                            command.ExecuteNonQuery()
                            Connection.Close()
                        End Using
                        CollateralList.Items.Clear()
                        DealershipComboBox.Enabled = True
                        DealershipComboBox.Text = ""
                        CollateralComboBox.Enabled = True
                        SuccessTimer.Enabled = True
                        MyCountBox.Enabled = True
                        MyCountBox.Text = ""
                        ListCountBox.Text = ""
                        Me.Enabled = True
                    Catch ex As Exception
                        MsgBox("couldn't add the batch: " & ex.ToString)
                    End Try
                Else
                    Me.Enabled = True
                    Exit Sub
                End If
            Else 'This is for the manual assignment check box version
                If MyCountBox.Text = ListCountBox.Text Then
                    Try 'insert all on the list at the same time, so otto can keep working without waiting for people to finish the reception job - TESTING
                        Dim NowTime As String = DateTime.Now.ToString("HH:mm:ss")
                        Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")
                        Dim QueryBuilt As New StringBuilder
                        QueryBuilt.Append("INSERT INTO Batch (BatchID,EmpID,Dealership,Collateral,VIN6,DateReceived,Timereceived,isassigned) VALUES")
                        For i = 0 To CollateralList.Items.Count - 1
                            If i = CollateralList.Items.Count - 1 Then
                                QueryBuilt.Append("('" & BatchLabel.Text & "','" & Clerk.EmployeeID.Text & "','" & DealershipComboBox.Text & "','" & CollateralComboBox.Text & "','" & CollateralList.Items(i) & "','" & NowDate & "','" & NowTime & "','1');")
                            Else
                                QueryBuilt.Append("('" & BatchLabel.Text & "','" & Clerk.EmployeeID.Text & "','" & DealershipComboBox.Text & "','" & CollateralComboBox.Text & "','" & CollateralList.Items(i) & "','" & NowDate & "','" & NowTime & "','1'),")
                            End If
                            JobQuantity += 1 'for the collateral log in job
                        Next
                        Using Connection As New MySqlConnection(SqlConnectionString)
                            Dim command As New MySqlCommand(QueryBuilt.ToString, Connection)
                            Connection.Open()
                            command.ExecuteNonQuery()
                            Connection.Close()
                        End Using
                        Try 'Make a job based on the new BATCH that you just uploaded
                            Dim NowJobTime As String = DateTime.Now.ToString("HH:mm:ss")
                            Dim NowJobDate As String = DateTime.Now.ToString("yyyy-MM-dd")
                            Dim JobTable As New DataTable
                            Dim Batchquery As String = "SELECT Dealership,Collateral,count(Collateral) as quantity,batchid  FROM `batch` WHERE batchid='" & BatchLabel.Text & "'"
                            Dim Batchadapt As New MySqlDataAdapter(Batchquery, SqlConnectionString)
                            Dim Batchtable As New DataTable
                            Batchadapt.Fill(Batchtable)
                            Dim Jobquery As String = "INSERT INTO workflow (EmpID,BatchID,DateAssigned,TimeAssigned,Dealer,Job,Quantity) VALUES('14','" & Batchtable.Rows(0)(3) & "','" & NowJobDate & "','" & NowJobTime & "','" & Batchtable.Rows(0)(0) & "','CIFR " & Batchtable.Rows(0)(1) & "','" & Batchtable.Rows(0)(2) & "');"
                            Using JobConnection As New MySqlConnection(SqlConnectionString)
                                Dim jobcommand As New MySqlCommand(Jobquery, JobConnection)
                                JobConnection.Open()
                                jobcommand.ExecuteNonQuery()
                                JobConnection.Close()
                            End Using
                        Catch ex As Exception
                            MsgBox("Couldn't add the batch: " & ex.ToString)
                        End Try
                        Try 'Now re-assign that new job.
                            Dim ReassignQuery As String = "Select JobID from workflow where batchid='" & BatchLabel.Text & "'"
                            Dim ReassignTable As New DataTable
                            Dim ReassignAdapt As New MySqlDataAdapter(ReassignQuery, SqlConnectionString)
                            ReassignAdapt.Fill(ReassignTable)
                            Reassign.Show()
                            Reassign.JobIdLabel.Text = ReassignTable.Rows(0)(0)
                        Catch ex As Exception
                            MsgBox("Error on the re-assign " & ex.ToString)
                        End Try
                        CollateralList.Items.Clear()
                        DealershipComboBox.Enabled = True
                        DealershipComboBox.Text = ""
                        CollateralComboBox.Enabled = True
                        SuccessTimer.Enabled = True
                        MyCountBox.Enabled = True
                        MyCountBox.Text = ""
                        ListCountBox.Text = ""
                        Me.Enabled = True
                    Catch ex As Exception
                        MsgBox("couldn't add the batch: " & ex.ToString)
                    End Try
                Else
                    Me.Enabled = True
                    Exit Sub
                End If
            End If

            'MsgBox(NeedUpdate)
            If NeedUpdate > 0 Then '12/10/14 Switched to VIN6 only for entering collateral, this functionality has been disabled for now.
                Try
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
                    e_mail.Subject = "Please update " & UpdateDealer
                    e_mail.IsBodyHtml = True
                    e_mail.Body = "<h2>Hello!</h2><br> I'm showing that we have received collateral for <b>" & UpdateDealer & "</b> and it isn't in their CIFR yet. Would you please update it? <br><br>  <h2>Thanks!</h2>"

                    smtp_server.Send(e_mail)

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                SuccessTimer.Enabled = True
            End If
        Else
            MsgBox("Counts must match. Did you miss something?", vbOKOnly, "Miss something?")
            Exit Sub
        End If

    End Sub

    Private Sub DoneButton_Click(sender As Object, e As EventArgs) Handles DoneButton.Click
        If MsgBox("Are you sure you are done?", vbYesNo, "Are you sure?") = MsgBoxResult.Yes Then 'Jessica's machine seems to have issues with this from time to time.
            Try
                Dim FinishQuery As String = "SELECT JobID from Workflow Where EmpID=" & Clerk.EmployeeID.Text & " AND Job='Collateral Reception' AND DateCompleted IS NULL"
                Dim FinishAdapt As New MySqlDataAdapter(FinishQuery, SqlConnectionString)
                Dim FinishTable As New DataTable
                FinishAdapt.Fill(FinishTable)

                Using connection As New MySqlConnection(SqlConnectionString)
                    Dim NowTime As String = DateTime.Now.ToString("HH:mm:ss")
                    Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")

                    Dim EndQuery As String = "UPDATE Workflow SET DateCompleted='" & NowDate & "',TimeCompleted='" & NowTime & "',Quantity='" & JobQuantity & "' WHERE JobID=" & FinishTable.Rows(0)(0)
                    Dim EndCommand As New MySqlCommand(EndQuery, connection)
                    connection.Open()
                    EndCommand.ExecuteNonQuery()
                    connection.Close()
                End Using

            Catch ex As Exception
                MsgBox("error: " & ex.ToString)
            End Try
            Me.Dispose()
        Else
            Exit Sub
        End If

    End Sub

    Private Sub CollateralLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Enabled = False
        Try
            Dim Query As String = "SELECT * From DealerName ORDER BY dealership ASC"
            Dim DealerAdapt As New MySqlDataAdapter(Query, SqlConnectionString)
            Dim DealerTable As New DataTable
            DealerAdapt.Fill(DealerTable)
            For i = 0 To DealerTable.Rows.Count - 1
                If DealerTable.Rows(i)(1) = "Primalend" Then
                    DealershipComboBox.Items.Add("")
                Else
                    DealershipComboBox.Items.Add(DealerTable.Rows(i)(1))
                End If
            Next
        Catch ex As Exception
            MsgBox("Couldn't load the dealer list " & ex.ToString)
        End Try
        Try
            Dim Query As String = "SELECT * From Collateral"
            Dim CollateralAdapt As New MySqlDataAdapter(Query, SqlConnectionString)
            Dim CollateralTable As New DataTable
            CollateralAdapt.Fill(CollateralTable)
            For i = 0 To CollateralTable.Rows.Count - 1
                CollateralComboBox.Items.Add(CollateralTable.Rows(i)(1))
            Next
        Catch ex As Exception
            MsgBox("Couldn't load the collateral types")
        End Try
        Try
            Dim Query As String = "SELECT ismonitored from employee where empid='" & Clerk.EmployeeID.Text & "'"
            Dim EmpAdapt As New MySqlDataAdapter(Query, SqlConnectionString)
            Dim EmpTable As New DataTable
            EmpAdapt.Fill(EmpTable)
            If EmpTable.Rows(0)(0) = "1" Then
                ManualToggleCheckBox.Visible = True
            Else
                ManualToggleCheckBox.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Enabled = True
    End Sub

    Private Sub DealershipComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DealershipComboBox.SelectedIndexChanged

    End Sub

    Private Sub DealershipComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles DealershipComboBox.SelectedValueChanged
        Dim rng As New Random
        Dim number As Integer = rng.Next(1, 1000)
        Dim digits As String = number.ToString("D3")
        Dim datedata As String = DateTime.Now.Month & DateTime.Now.Day & DateTime.Now.Minute
        If DealershipComboBox.Text = "" Then
            BatchLabel.Text = ""
            Exit Sub
        Else
            Dim Dealer As String = DealershipComboBox.Text.Replace(" ", "")
            Dim batchstring As String = Dealer(0) & Dealer(1) & Dealer(Dealer.Length - 2) & Dealer(Dealer.Length - 1) 'First 2 characters, last two characters.
            BatchLabel.Text = batchstring & datedata & digits
        End If
    End Sub

    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub

    Private Sub SuccessTimer_Tick(sender As Object, e As EventArgs) Handles SuccessTimer.Tick
        If SuccessSeconds > 5 Then
            SuccessLabel.Visible = False
            SuccessSeconds = 0
            SuccessTimer.Stop()
        Else
            SuccessLabel.Visible = True
            SuccessSeconds += 1
        End If
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        If MsgBox("Are you sure you want to remove this item from the list?", vbYesNo, "Remove item?") = MsgBoxResult.Yes Then
            CollateralList.Items.Remove(CollateralList.SelectedItem)
            ListCountBox.Text = CollateralList.Items.Count
        Else

        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CollateralBox.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            If CollateralBox.Text = "" Or DealershipComboBox.Text = "" Or CollateralComboBox.Text = "" Then
                Exit Sub
            ElseIf CollateralList.Items.Contains(CollateralBox.Text) Then
                MsgBox("Duplicate found", vbOKOnly, "Oops!")
                Exit Sub
            Else
                DealershipComboBox.Enabled = False
                CollateralComboBox.Enabled = False
                MyCountBox.Enabled = False
                CollateralList.Items.Insert(0, CollateralBox.Text)
                CollateralBox.Text = ""
            End If
            ListCountBox.Text = CollateralList.Items.Count
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles CollateralBox.TextChanged

    End Sub

    Private Sub TutorialPicture_Click(sender As Object, e As EventArgs) Handles TutorialPicture.Click
        Me.Enabled = False
        LogTutorial.Show()
    End Sub

    Private Sub CollateralList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CollateralList.SelectedIndexChanged

    End Sub

    Private Sub CollateralList_TextChanged(sender As Object, e As EventArgs) Handles CollateralList.TextChanged

    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        If MyCountBox.Enabled = False Then
            MyCountBox.Enabled = True
        End If
    End Sub

    Private Sub ReceivedDateCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ReceivedDateCheckBox.CheckedChanged
        If ReceivedDateCheckBox.Checked = True Then
            ReceivedDateTime.Visible = True
        Else
            ReceivedDateTime.Visible = False
        End If
    End Sub

    Private Sub ListCountBox_TextChanged(sender As Object, e As EventArgs) Handles ListCountBox.TextChanged

    End Sub

    Private Sub ManualCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ManualToggleCheckBox.CheckedChanged
       
    End Sub

    Private Sub ManualToggleCheckBox_Click(sender As Object, e As EventArgs) Handles ManualToggleCheckBox.Click
        If MsgBox("Are you sure you don't want this batch to be auto assigned?", vbYesNo, "Are you sure?") = MsgBoxResult.Yes Then
            ManualToggleCheckBox.CheckState = CheckState.Unchecked
        Else
            ManualToggleCheckBox.CheckState = CheckState.Checked
        End If
    End Sub

    Private Sub CollateralComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CollateralComboBox.SelectedIndexChanged

    End Sub
End Class