Imports System
Imports System.IO
Imports System.Collections
Imports System.Text
Imports System.Data.OleDb
Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Imports System.Threading
Imports System.Net.Mail
Public Class ShowQuery
    Dim SqlConnectionString As String = "Server=192.168.1.34; Database=TimeLogDB; User id=clerk; Password=12345;" 'NUC Database
    Dim Dealer As String = ""
    Dim Clerk As String = ""
    Dim ClerkEmail As String = ""
    <DllImport("user32.dll", SetLastError:=True)> _
    Private Shared Function SetWindowPos(ByVal hWnd As IntPtr, ByVal hWndInsertAfter As IntPtr, ByVal X As Integer, ByVal Y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal uFlags As Integer) As Boolean
    End Function

    Private Const SWP_NOSIZE As Integer = &H1
    Private Const SWP_NOMOVE As Integer = &H2

    Private Shared ReadOnly HWND_TOPMOST As New IntPtr(-1)
    Private Shared ReadOnly HWND_NOTOPMOST As New IntPtr(-2)

    Public Function MakeTopMost()
        SetWindowPos(Me.Handle(), HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE Or SWP_NOSIZE)
        Return Nothing
    End Function

    Public Function MakeNormal()
        SetWindowPos(Me.Handle(), HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOMOVE Or SWP_NOSIZE)

        Return Nothing
    End Function
    Private Sub ShowQuery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MakeTopMost()
            Dim ClerkQuery As String = "Select empfirst,email from employee where empid=" & Overwatch.EmpIDLabel.Text
            Dim ClerkAdapt As New MySqlDataAdapter(ClerkQuery, SqlConnectionString)
            Dim ClerkTable As New DataTable
            ClerkAdapt.Fill(ClerkTable)
            If ClerkTable.Rows.Count > 0 Then
                Clerk = ClerkTable.Rows(0)(0).ToString
                ClerkEmail = ClerkTable.Rows(0)(1).ToString
            End If
            Dim JobArray(FileCabinetPopup.JobCheckListBox.CheckedItems.Count - 1) As String
            For i = 0 To FileCabinetPopup.JobCheckListBox.CheckedItems.Count - 1
                If FileCabinetPopup.JobCheckListBox.GetItemChecked(i) = True Then
                    Dim ToSplit As String = FileCabinetPopup.JobCheckListBox.Items(i).ToString
                    Dim Split() As String = ToSplit.Split(New Char() {"-"c})
                    JobArray(i) = Split(0)
                End If
            Next
            For i = 0 To JobArray.Count - 1
                Dim idtable As New DataTable
                Dim idquery As String = "Select BatchID,dealer from workflow where jobid=" & JobArray(i)
                Dim idadapt As New MySqlDataAdapter(idquery, SqlConnectionString)
                idadapt.Fill(idtable)
                If idtable.Rows.Count > 0 Then
                    Dealer = idtable.Rows(0)(1).ToString
                    Dim VINtable As New DataTable
                    Dim VINquery As String = "select vin6,collateral from batch where batchid='" & idtable.Rows(0)(0).ToString & "' order by collateral ASC"
                    Dim VINadapt As New MySqlDataAdapter(VINquery, SqlConnectionString)
                    VINadapt.Fill(VINtable)
                    If VINtable.Rows.Count > 0 Then
                        For c = 0 To VINtable.Rows.Count - 1
                            VINCheckList.Items.Add(VINtable.Rows(c)(0).ToString & " - " & VINtable.Rows(c)(1).ToString, True)
                        Next
                    End If
                End If
            Next
        Catch ex As Exception

        End Try
        VINCheckList.Focus()
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Try
            FinishIt()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

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
            e_mail.Subject = "Update Request for " & Dealer
            e_mail.IsBodyHtml = IsHTML
            e_mail.Body = Body
            smtp_server.Send(e_mail)
            'Otto.LogTextBox.AppendText(vbNewLine & "Sent an email to " & emailto & " @ " & TimeOfDay)
        Catch ex As Exception
            'Otto.LogTextBox.AppendText(vbNewLine & "Couldn't send an email to " & emailto & " @ " & TimeOfDay)
        End Try
        Return Nothing
    End Function

    Public Function FinishIt()
        Try
            Label1.Text = "Sending an Email to your Account Manager"
            FlatButton1.Enabled = False
            Dim DealerQuery As String = "Select isEtitle from Dealername where dealership='" & Dealer & "'"
            Dim DealerAdapt As New MySqlDataAdapter(DealerQuery, SqlConnectionString)
            Dim DealerTable As New DataTable
            DealerAdapt.Fill(DealerTable)
            If DealerTable.Rows.Count > 0 Then
                Dim AMQuery As String = "Select employee.Empfirst,employee.email,accountmanager.empid,accountmanager.teamID from accountmanager INNER JOIN employee on accountmanager.empid=employee.empid where teamid=" & DealerTable.Rows(0)(0)
                Dim AMAdapt As New MySqlDataAdapter(AMQuery, SqlConnectionString)
                Dim AMTable As New DataTable
                AMAdapt.Fill(AMTable)
                If AMTable.Rows.Count > 0 Then
                    Dim AccountManager As String = AMTable.Rows(0)(0).ToString
                    Dim EmailTo As String = AMTable.Rows(0)(1).ToString
                    Dim HTMLBody As New StringBuilder
                    HTMLBody.Append("<p>Hey " & AccountManager & ",</p><br/><p>The following VIN(S) couldn't be found in the Borrowing Base:</p>")
                    Dim IsHTML As Boolean = True
                    For i = 0 To VINCheckList.Items.Count - 1
                        If VINCheckList.GetItemChecked(i) = True Then
                            HTMLBody.Append("<p>" & VINCheckList.Items(i).ToString & "<br/>")
                        End If
                    Next
                    HTMLBody.Append("<p>If you could please update and let " & Clerk & " know when it's done.<br/><h3>Thanks! :)</h3>")
                    'MsgBox("mail")
                    MailIt(HTMLBody.ToString, EmailTo & "," & ClerkEmail, IsHTML)
                    Me.Dispose()
                    FileCabinetPopup.Dispose()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.Dispose()
        End Try
        Return Nothing
    End Function

    Private Sub VINCheckList_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VINCheckList.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            FinishIt()
        End If
    End Sub

    Private Sub VINCheckList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VINCheckList.SelectedIndexChanged

    End Sub
End Class