Imports MySql.Data.MySqlClient
Imports System.Text

Public Class DBA
    Dim SqlConnectionString As String = "Server=192.168.1.34; Database=TimeLogDB; User id=clerk; Password=12345; Convert zero datetime=True;" 'NUC Database
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RunQuery(RichTextBox1.Text)
    End Sub

    Private Sub DBA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Using Connection As New MySqlConnection(SqlConnectionString)
                Connection.Open()
                ConnectionLabel.Text = "Open"
                Connection.Close()
            End Using
        Catch ex As Exception
            MsgBox("Couldn't connect " & ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RunCommand(RichTextBox1.Text)
    End Sub
    Public Function RunQuery(ByVal Query As String)
        Try
            Dim Adapter As New MySqlDataAdapter(Query, SqlConnectionString)
            Dim Table As New DataTable
            Adapter.Fill(Table)
            ShowQuery.Show()
            ShowQuery.ResultsDGV.DataSource = Table
        Catch ex As Exception

        End Try
        Return Nothing
    End Function
    Public Function RunCommand(ByVal Query As String)
        If MsgBox("Are you sure you'd like to execute this query? NO UNDO", vbYesNo, "Are you sure?") = MsgBoxResult.Yes Then
            Try
                Using connection As New MySqlConnection(SqlConnectionString)
                    Dim command As New MySqlCommand(Query, connection)
                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                End Using
                RichTextBox1.Clear()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        Return Nothing
    End Function

    Private Sub RichTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RichTextBox1.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            RunQuery(RichTextBox1.Text)
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        
    End Sub
End Class