Imports System
Imports System.IO
Imports System.Collections
Imports System.Text
Imports System.Data.OleDb
Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Imports System.Threading
Imports System.Net.Mail

Public Class FileCabinetPopup

    Dim SqlConnectionString As String = "Server=192.168.1.34; Database=TimeLogDB; User id=clerk; Password=12345;" 'NUC Database <--Being used now
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
    Private Sub FileCabinetPopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub XButton_Click(sender As Object, e As EventArgs) Handles XButton.Click
        Me.Dispose()
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click

    End Sub

    Private Sub OtherButton_Click(sender As Object, e As EventArgs) Handles OtherButton.Click

    End Sub

    Public Function MailIt(ByVal Body As String, ByVal emailto As String, ByVal IsHTML As Boolean)
        Try 'Try to send an email with the command results..

            Dim smtp_server As New SmtpClient
            Dim e_mail As New MailMessage()
            smtp_server.UseDefaultCredentials = False
            smtp_server.Credentials = New Net.NetworkCredential("jpennock@primalend.com", "Addington1!")
            smtp_server.Port = 587
            smtp_server.EnableSsl = True
            smtp_server.Host = "smtp.office365.com"

            e_mail = New MailMessage
            e_mail.From = New MailAddress("otto@primalend.com")
            e_mail.To.Add(emailto)
            e_mail.Subject = "Update Request"
            e_mail.IsBodyHtml = IsHTML
            e_mail.Body = Body
            smtp_server.Send(e_mail)
            'Otto.LogTextBox.AppendText(vbNewLine & "Sent an email to " & emailto & " @ " & TimeOfDay)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return Nothing
    End Function

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click

    End Sub
End Class