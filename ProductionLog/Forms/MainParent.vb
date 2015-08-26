Imports System.Text
Imports System.Data.OleDb
Imports System
Imports System.IO
Imports System.Collections

Public Class MainParent

    Private Sub MainParent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FormSkin1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FileButton_Click(sender As Object, e As EventArgs) Handles FileButton.Click
        Dim Filechoice As String = ""
        Dim ExcelConnect As String = ""
        If OpenF.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Filechoice = OpenF.FileName

            ExcelConnect = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & Filechoice & ";Extended Properties=""Excel 12.0 Xml"";"
            Dim ExcelQuery As String = "Select * from [Sheet1$]"
            Dim ExcelAdapt As New OleDbDataAdapter(ExcelQuery, ExcelConnect)
            Dim ExcelTable As New DataTable
            ExcelAdapt.Fill(ExcelTable)
            Try
                If ExcelTable.Rows.Count > 0 Then
                    UploadDGV.DataSource = ExcelTable
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class
