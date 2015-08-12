Public Class VerifyStillHere
    Dim seconds As Integer = 0
    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        AreYouHere.Stop()
        Dashboard.StillHere.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub AreYouHere_Tick(sender As Object, e As EventArgs) Handles AreYouHere.Tick
        If seconds > 7200 Then

            Dashboard.Dispose()
        End If
        seconds += 1
    End Sub

    Private Sub VerifyStillHere_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub
End Class