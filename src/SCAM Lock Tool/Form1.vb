Public Class Form1
    Private Sub OkBtn_Click(sender As Object, e As EventArgs) Handles OkBtn.Click
        Application.Exit()
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Application.Exit()
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        StartupKey.ShowDialog()
    End Sub
End Class
