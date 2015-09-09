Imports System.Text
Imports MySql.Data.MySqlClient

Public Class TheCIFR
    Dim SuccessSeconds As Integer = 0
    Dim SqlConnectionString As String = "Server=192.168.1.34; Database=TimeLogDB; User id=clerk; Password=12345; Convert zero datetime=True;" 'NUC Database 'CONVERT ZERO DATE TIME NEEDED FOR CIFR


    Private Sub TheCIFR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim DealerQuery As String = "Select Dealership from Dealername where isactive = 1 order by dealership ASC"
            Dim DealerAdapt As New MySqlDataAdapter(DealerQuery, SqlConnectionString)
            Dim Dealertable As New DataTable
            DealerAdapt.Fill(Dealertable)
            If Dealertable.Rows.Count > 0 Then
                With DealerComboBox
                    .DataSource = Dealertable
                    .ValueMember = "Dealership"
                    .DisplayMember = "Dealership"
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        If TrackingTextBox.Text = "" Then
            TrackingTextBox.Focus()
            Exit Sub
        End If

        Try
            If MailTreeVIew.Nodes.Count > 0 Then
                Dim Test As Boolean = False
                For i = 0 To MailTreeVIew.Nodes.Count - 1
                    Dim TestNode As TreeNode = MailTreeVIew.Nodes(i)
                    'MsgBox(TestNode.Text)
                    If TestNode.Text = DealerComboBox.SelectedValue Then
                        Test = True
                    End If
                    If Test = True Then
                        TestNode.Nodes.Add(TrackingTextBox.Text)
                        GoTo DONE
                    End If
                Next
                If Test = False Then
                    MailTreeVIew.Nodes.Add(DealerComboBox.SelectedValue)
                    Dim NewNode As TreeNode = MailTreeVIew.Nodes(MailTreeVIew.Nodes.Count - 1)
                    NewNode.Nodes.Add(TrackingTextBox.Text)
                End If
DONE:
            Else
                MailTreeVIew.Nodes.Add(DealerComboBox.SelectedValue)
                Dim NewNode As TreeNode = MailTreeVIew.Nodes(0)
                NewNode.Nodes.Add(TrackingTextBox.Text)
            End If
            MailTreeVIew.ExpandAll()
            TrackingTextBox.Text = ""
            SuccessTimer.Start()
            TrackingTextBox.Focus()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub SuccessTimer_Tick(sender As Object, e As EventArgs) Handles SuccessTimer.Tick
        If SuccessSeconds < 5 Then
            SuccessLabel.Visible = True
            SuccessSeconds += 1
        Else
            SuccessLabel.Visible = False
            SuccessSeconds = 0
            SuccessTimer.Stop()
        End If
    End Sub

    Private Sub DealerComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DealerComboBox.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            If TrackingTextBox.Text = "" Then
                TrackingTextBox.Focus()
                Exit Sub
            End If

            Try
                If MailTreeVIew.Nodes.Count > 0 Then
                    Dim Test As Boolean = False
                    For i = 0 To MailTreeVIew.Nodes.Count - 1
                        Dim TestNode As TreeNode = MailTreeVIew.Nodes(i)
                        'MsgBox(TestNode.Text)
                        If TestNode.Text = DealerComboBox.SelectedValue Then
                            Test = True
                        End If
                        If Test = True Then
                            TestNode.Nodes.Add(TrackingTextBox.Text)
                            GoTo DONE
                        End If
                    Next
                    If Test = False Then
                        MailTreeVIew.Nodes.Add(DealerComboBox.SelectedValue)
                        Dim NewNode As TreeNode = MailTreeVIew.Nodes(MailTreeVIew.Nodes.Count - 1)
                        NewNode.Nodes.Add(TrackingTextBox.Text)
                    End If
DONE:
                Else
                    MailTreeVIew.Nodes.Add(DealerComboBox.SelectedValue)
                    Dim NewNode As TreeNode = MailTreeVIew.Nodes(0)
                    NewNode.Nodes.Add(TrackingTextBox.Text)
                End If
                MailTreeVIew.ExpandAll()
                TrackingTextBox.Text = ""
                SuccessTimer.Start()
                TrackingTextBox.Focus()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub MailTreeVIew_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles MailTreeVIew.AfterSelect

    End Sub

    Private Sub MailTreeVIew_MouseUp(sender As Object, e As MouseEventArgs) Handles MailTreeVIew.MouseUp

    End Sub
End Class