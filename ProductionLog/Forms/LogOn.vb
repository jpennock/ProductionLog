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
                Try 'Try to find their PIN in the DB
                    Dim Query As String = "SELECT EmpID FROM PINS WHERE PIN=" & PasswordBox.Text
                    Dim PinAdapt As New MySqlDataAdapter(Query, SqlConnectionString)
                    Dim PINDT As New DataTable
                    PinAdapt.Fill(PINDT)
                    If IsDBNull(PINDT.Rows(0)(0)) Then 'if the PIN isn't found, let them know and clear the SUB for them to try again.
                        MsgBox("Couldn't find you!", vbOKOnly, "Primalend Production Log")
                        Exit Sub
                    Else
                        Clerk.EmployeeID.Text = PINDT.Rows(0)(0)
                        Dashboard.IDLabel.Text = Clerk.EmployeeID.Text
                        Clerk.LoginButton.Visible = False
                        Clerk.LogoutButton.Visible = True
                        Try 'Check to see if they are clocked in still
                            Dim ClockQuery As String = "SELECT * From TimeClock Where EmpID=" & PINDT.Rows(0)(0) & " AND TimeOut IS NULL"
                            Dim ClockAdapt As New MySqlDataAdapter(ClockQuery, SqlConnectionString)
                            Dim ClockDT As New DataTable
                            ClockAdapt.Fill(ClockDT)
                            'MsgBox(ClockDT.Rows.Count) This was checking the row count for the following lines of code.
                            If ClockDT.Rows.Count < 1 Then 'if there isn't an entry for an open timeclock then just log in
                                Clerk.LoginSuccessTimer.Enabled = True
                                Me.Dispose()
                                'clerk.refreshme()
                            Else 'else, display the timeclock information to the employee
                                Clerk.ClockInButton.Enabled = False
                                Clerk.ClockInButton.Visible = False
                                Clerk.ClockTimeLabel.Text = ClockDT.Rows(0)(2).ToString
                                Clerk.LoginSuccessTimer.Enabled = True
                                Clerk.ShowButton.Visible = True
                                ''clerk.refreshme()
                                Me.Dispose()
                            End If
                            Try
                                Using Connection As New MySqlConnection(SqlConnectionString)
                                    Dim LoginQuery As String = "UPDATE Employee SET IsLogin=True WHERE EmpID=" & Clerk.EmployeeID.Text
                                    Dim LoginCommand As New MySqlCommand(LoginQuery, Connection)
                                    Connection.Open()
                                    LoginCommand.ExecuteNonQuery()
                                    Connection.Close()
                                End Using
                                'clerk.refreshme()
                            Catch ex As Exception
                                MsgBox("Had trouble showing you as logged in on the server, please let your manager know " & ex.ToString)
                            End Try
                        Catch ex As Exception
                            Clerk.LoginSuccessTimer.Enabled = True
                            'Clerk.QueueTimer.Enabled = True
                            Me.Dispose()
                        End Try
                    End If
                    'clerk.refreshme()
                Catch ex As Exception
                    MsgBox("Couldn't find you!", vbOKOnly, "Oops!")
                    Exit Sub
                End Try
            End If
        End If
        

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles PasswordBox.TextChanged

    End Sub

    Private Sub LogOn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class