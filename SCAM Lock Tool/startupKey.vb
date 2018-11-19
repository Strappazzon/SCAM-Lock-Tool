Public Class startupKey
    Private Sub startupKey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Enabled = False
        passwStartupTextBox.Select()
    End Sub

    Private Sub startupKey_Closing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        Form1.Enabled = True
        Form1.Show()
    End Sub

    Private Sub cancelStartupBtn_Click(sender As Object, e As EventArgs) Handles cancelStartupBtn.Click
        Close()
        Form1.Enabled = True
        Form1.Show()
    End Sub

    Private Sub okStartupBtn_Click(sender As Object, e As EventArgs) Handles okStartupBtn.Click
        If passwStartupTextBox.Text = "" Then
            MessageBox.Show("The password cannot be empty.",
            "System Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error,
            MessageBoxDefaultButton.Button1)
        ElseIf passwStartupTextBox.Text = "hunter2" And passwStartupConfirmTextBox.Text = "hunter2" Then
            MessageBox.Show("The Account Database Startup Key was changed.",
            "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1)
            Application.Exit()
        ElseIf passwStartupTextBox.Text = passwStartupConfirmTextBox.Text Then
            Dim result As Integer = MessageBox.Show("An error occurred while scamming this user with the password '" & passwStartupTextBox.Text & "'", "System Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            If result = DialogResult.Retry Or result = DialogResult.Cancel Then
                Threading.Thread.Sleep(1500)
                Dim WikiLink As New ProcessStartInfo With {
                    .FileName = "iexplore.exe",
                    .Arguments = "https://en.wikipedia.org/wiki/Technical_support_scam"
                }
                Process.Start(WikiLink)
                Application.Exit()
            End If
        ElseIf passwStartupTextBox.Text IsNot passwStartupConfirmTextBox.Text Then
            MessageBox.Show("The passwords entered do not match." & ControlChars.NewLine & "Please re-enter the passwords.",
                "System Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1)
                passwStartupTextBox.Clear()
                passwStartupConfirmTextBox.Clear()
            End If
    End Sub
End Class