Imports System.Text
Imports System.Data.OleDb
Imports System
Imports System.IO
Imports System.Collections
Imports MySql.Data.MySqlClient

Public Class MainParent
    Dim SqlConnectionString As String = "Server=192.168.1.34; Database=TimeLogDB; User id=clerk; Password=12345; Convert zero datetime=True;" 'NUC Database
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

    Private Sub UploadButton_Click(sender As Object, e As EventArgs) Handles UploadButton.Click
        Dim QueryBuilt As New StringBuilder
        Try
            QueryBuilt.Append("INSERT INTO vins (VIN,DealerID,Year,Make,Model,Name,Branch,Stock) VALUES")
            ProgressBar1.Maximum = UploadDGV.Rows.Count
            For i = 0 To UploadDGV.Rows.Count - 1
                If i < UploadDGV.Rows.Count - 1 Then
                    QueryBuilt.Append("('" & UploadDGV.Rows(i).Cells(0).Value & "','" & UploadDGV.Rows(i).Cells(1).Value & "','" & UploadDGV.Rows(i).Cells(2).Value & "','" & UploadDGV.Rows(i).Cells(3).Value & "','" & UploadDGV.Rows(i).Cells(4).Value & "','" & UploadDGV.Rows(i).Cells(5).Value & "','" & UploadDGV.Rows(i).Cells(6).Value & "','" & UploadDGV.Rows(i).Cells(7).Value & "'),")
                Else
                    QueryBuilt.Append("('" & UploadDGV.Rows(i).Cells(0).Value & "','" & UploadDGV.Rows(i).Cells(1).Value & "','" & UploadDGV.Rows(i).Cells(2).Value & "','" & UploadDGV.Rows(i).Cells(3).Value & "','" & UploadDGV.Rows(i).Cells(4).Value & "','" & UploadDGV.Rows(i).Cells(5).Value & "','" & UploadDGV.Rows(i).Cells(6).Value & "','" & UploadDGV.Rows(i).Cells(7).Value & "');")
                End If
                ProgressBar1.Value += 1
            Next
            MsgBox("FIN")
            Using Connector As New MySqlConnection(SqlConnectionString)
                Dim commander As New MySqlCommand(QueryBuilt.ToString, Connector)
                MsgBox("Please standby")
                Connector.Open()
                commander.ExecuteNonQuery()
                Connector.Close()
                MsgBox("Done")
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
