Public Class Form1
    Private Sub okBtn_Click(sender As Object, e As EventArgs) Handles okBtn.Click
        Application.Exit()
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Application.Exit()
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        startupKey.ShowDialog()
    End Sub
End Class
