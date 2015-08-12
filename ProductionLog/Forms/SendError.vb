Imports MySql.Data.MySqlClient
Public Class SendError
    Dim SqlConnectionString As String = "Server=192.168.1.34; Database=TimeLogDB; User id=clerk; Password=12345;" 'NUC Database <--Being used now
    Dim Email As String = ""
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SendButton.Click
        Try
            Dim ToBeCleaned As String = ErrorRTB.Text
            Dim Cleaned As String() = ToBeCleaned.Split(New Char() {"'"c})

            ErrorRTB.Clear()
            For i = 0 To Cleaned.Count - 1
                ErrorRTB.AppendText(Cleaned(i))
            Next

            Dim CommentToClean As String = CommentBox.Text
            Dim CleanComment As String() = CommentToClean.Split(New Char() {"'"c})

            CommentBox.Clear()

            For i = 0 To CleanComment.Count - 1
                CommentBox.AppendText(CleanComment(i))
            Next

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Try
            Dim NowTime As String = DateTime.Now.ToString("HH:mm:ss")
            Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")
            Dim SendMe As String = ErrorRTB.Text
            Dim Comment As String = CommentBox.Text
            Using connection As New MySqlConnection(SqlConnectionString)
                Dim Query As String = "INSERT INTO BugTracker (EmpID,LogDate,BugMessage,Comment,LogVersion) VALUES('" & EmpIDLabel.Text & "','" & NowDate & "','" & SendMe & "','" & Comment & "','" & VersionLabel.Text & "')"
                Dim Command As New MySqlCommand(Query, connection)
                connection.Open()
                Command.ExecuteNonQuery()
                connection.Close()
            End Using
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub SendError_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Using Connection As New MySqlConnection(SqlConnectionString)
                Connection.Open()
                CheckBox1.Checked = True
                Connection.Close()
            End Using
            VersionLabel.Text = Dashboard.VersionLabel.Text
        Catch ex As Exception
            CheckBox1.Checked = False
            SendButton.Enabled = False
            NoButton.Visible = True
        End Try
        
    End Sub
End Class