Public Class LogTutorial

    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        Tutorial1.Visible = False
        Tutorial2.visible = True


    End Sub

    Private Sub DoneButton_Click(sender As Object, e As EventArgs) Handles DoneButton.Click
        CollateralLog.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        Tutorial2.Visible = False
        Tutorial3.Visible = True
    End Sub

    Private Sub CollateralBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CollateralBox.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            If CollateralBox.Text = "" Or DealershipComboBox.Text = "" Or CollateralComboBox.Text = "" Then
                Exit Sub
            Else
                DealershipComboBox.Enabled = False
                CollateralComboBox.Enabled = False
                CollateralList.Items.Add(CollateralBox.Text)
                CollateralBox.Text = ""
            End If
        End If
    End Sub

    Private Sub CollateralBox_TextChanged(sender As Object, e As EventArgs) Handles CollateralBox.TextChanged

    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click
        Tutorial3.Visible = False
        Tutorial4.Visible = True
    End Sub

    Private Sub FlatButton5_Click(sender As Object, e As EventArgs) Handles FlatButton5.Click
        Tutorial4.Visible = False
        Tutorial5.Visible = True
    End Sub

    Private Sub FlatButton6_Click(sender As Object, e As EventArgs) Handles FlatButton6.Click
        Tutorial5.Visible = False
        Tutorial6.Visible = True
    End Sub

    Private Sub FlatButton7_Click(sender As Object, e As EventArgs) Handles FlatButton7.Click
        Tutorial6.Visible = False
        EndTutorial.Visible = True
        EndTutorial2.Visible = True
        EndTutorial3.Visible = True
        EndTutorial4.Visible = True

    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        If MsgBox("Are you sure you want to remove this item from the list?", vbYesNo, "Remove item?") = MsgBoxResult.Yes Then
            CollateralList.Items.Remove(CollateralList.SelectedItem)
        Else

        End If
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        CollateralList.Items.Clear()
        DealershipComboBox.Enabled = True
        CollateralComboBox.Enabled = True
    End Sub
End Class