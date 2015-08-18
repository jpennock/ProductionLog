Imports System.Data.OleDb
Imports System.Text
Imports MySql.Data.MySqlClient
Public Class LogOn 'The Login screen will check to see if the employee's PIN is found in the database. If it is, it will then verify if they have been clocked in (and not clocked out yet) 
    'this lets us continue working (even after they quit the program) without having to rely on saving files to the employee's computer.
    Dim ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\pcpserver\pl_share\PrimaLend\Collateral Management\Updates\Timelog.accdb"
    Dim SqlConnectionString As String = "Server=192.168.1.34; Database=TimeLogDB; User id=clerk; Password=12345;" 'NUC Database
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PasswordBox.KeyPress
        Dim EmpId As Integer = 0
        If e.KeyChar = Convert.ToChar(13) Then
            If PasswordBox.Text = "" Then 'if they didn't type anything in, don't continue
                Exit Sub
            Else
                Try 'Try to find their PIN                
                    Dim Query As String = "SELECT EmpID FROM PINS WHERE PIN=" & PasswordBox.Text
                    Dim PinAdapt As New MySqlDataAdapter(Query, SqlConnectionString)
                    Dim PINDT As New DataTable
                    PinAdapt.Fill(PINDT)
                    Dim TeamQuery As String = "Select iswolfpack from employee where empid='" & PINDT.Rows(0)(0) & "'"
                    Dim TeamAdapt As New MySqlDataAdapter(TeamQuery, SqlConnectionString)
                    Dim Teamtable As New DataTable
                    TeamAdapt.Fill(Teamtable)
                    If IsDBNull(PINDT.Rows(0)(0)) Then 'if the PIN isn't found, let them know and clear the SUB for them to try again.
                        MsgBox("Couldn't find you!", vbOKOnly, "Primalend Production Log")
                        Exit Sub
                    Else
                        Using connect As New MySqlConnection(SqlConnectionString)
                            Dim loginquery As String = "UPDATE Employee set islogin = '1' where empid = " & PINDT.Rows(0)(0)
                            Dim logincommand As New MySqlCommand(loginquery, connect)
                            connect.Open()
                            logincommand.ExecuteNonQuery()
                            connect.Close()
                        End Using
                        Dashboard.Show()
                        If Teamtable.Rows(0)(0) = 1 Or Teamtable.Rows(0)(0) = 9 Then
                            Dashboard.FlatButton1.Visible = True
                        Else
                            Dashboard.FlatButton1.Visible = False
                        End If
                        If Teamtable.Rows(0)(0) = 9 Then
                            Dashboard.OttoButton.Visible = True
                        Else
                            Dashboard.OttoButton.Visible = False
                        End If
                        Overwatch.EmpIDLabel.Text = PINDT.Rows(0)(0)
                        Dashboard.IDLabel.Text = PINDT.Rows(0)(0)
                        Me.Hide()
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If

        End If

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles PasswordBox.TextChanged

    End Sub
    Private Sub LogOn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class