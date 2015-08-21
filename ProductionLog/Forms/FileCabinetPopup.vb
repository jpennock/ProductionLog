Imports System
Imports System.IO
Imports System.Collections
Imports System.Text
Imports System.Data.OleDb
Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Imports System.Threading
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
        MakeTopMost()
        Try
            Dim JobTable As New DataTable
            Dim JobQuery As String = "SELECT JobID,BatchID,DateAssigned,Dealer,Job,Quantity From workflow where dealer='" & Overwatch.BBComboBox.Items(Overwatch.BBComboBox.SelectedIndex).ToString & "' and job like '%CIFR%' and datecompleted is null"
            Dim JobAdapt As New MySqlDataAdapter(JobQuery, SqlConnectionString)
            JobAdapt.Fill(JobTable)
            If JobTable.Rows.Count > 1 Then 'If there is more than one CIFR job available.
                For i = 0 To JobTable.Rows.Count - 1
                    JobCheckListBox.Items.Add(JobTable.Rows(i)(0).ToString & "-" & JobTable.Rows(i)(1).ToString & "-" & JobTable.Rows(i)(3) & "-" & JobTable.Rows(i)(4).ToString)
                Next
                For c = JobCheckListBox.Items.Count - 1 To 0 Step -1
                    JobCheckListBox.SetItemChecked(c, True)
                Next
            ElseIf JobTable.Rows.Count = 1 Then 'If there is only the one CIFR job available, assign that one.
                'MsgBox("Just one")
            End If
            StartButton.Focus()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub XButton_Click(sender As Object, e As EventArgs) Handles XButton.Click
        Me.Dispose()
    End Sub
End Class