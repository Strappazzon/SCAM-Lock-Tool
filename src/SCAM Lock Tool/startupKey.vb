Public Class startupKey
    Public cmdArgs = Environment.GetCommandLineArgs()

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
        If passwStartupTextBox.Text = "" Or passwStartupConfirmTextBox.Text = "" Then
            MessageBox.Show("The password cannot be empty.", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf passwStartupTextBox.Text = passwStartupConfirmTextBox.Text Then
            Try
                If cmdArgs(1) = "--no-wikipedia" Then
                    MessageBox.Show("An error occurred while changing the Account Database Startup Key", "System Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                ElseIf cmdArgs(1) = "--no-error" Xor cmdArgs(1) = "--success" Then
                    MessageBox.Show("The Account Database Startup Key was changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Application.Exit()
                Else
                    MessageBox.Show("An error occurred while scamming this user with the password '" & passwStartupTextBox.Text & "'", "System Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                    Process.Start("iexplore.exe", "https://en.wikipedia.org/wiki/Technical_support_scam")
                    Application.Exit()
                End If
            Catch ex As IndexOutOfRangeException
                MessageBox.Show("An error occurred while scamming this user with the password '" & passwStartupTextBox.Text & "'", "System Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                Process.Start("iexplore.exe", "https://en.wikipedia.org/wiki/Technical_support_scam")
                Application.Exit()
            End Try
        ElseIf passwStartupTextBox.Text <> passwStartupConfirmTextBox.Text Then
            MessageBox.Show("The passwords entered do not match." & ControlChars.NewLine & "Please re-enter the passwords.", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            passwStartupTextBox.Clear()
            passwStartupConfirmTextBox.Clear()
        End If
    End Sub
End Class
