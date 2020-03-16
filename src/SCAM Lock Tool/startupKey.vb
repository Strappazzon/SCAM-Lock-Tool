Public Class startupKey
    Public cmdArgs = Environment.GetCommandLineArgs()

    Private Sub passwStartupRadio_CheckedChanged(sender As Object, e As EventArgs) Handles passwStartupRadio.CheckedChanged
        If passwStartupRadio.Checked = True Then
            passwStartupTextBox.Enabled = True
            passwStartupConfirmTextBox.Enabled = True

            sysPasswStartupRadio.Checked = False
            sysPasswStartupFloppyRadio.Checked = False
            sysPasswStartupSystemRadio.Checked = False
            sysPasswStartupFloppyRadio.Enabled = False
            sysPasswStartupSystemRadio.Enabled = False
        End If
    End Sub

    Private Sub sysPasswStartupRadio_CheckedChanged(sender As Object, e As EventArgs) Handles sysPasswStartupRadio.CheckedChanged
        If sysPasswStartupRadio.Checked = True Then
            passwStartupRadio.Checked = False
            passwStartupTextBox.Enabled = False
            passwStartupConfirmTextBox.Enabled = False

            sysPasswStartupRadio.Checked = True
            sysPasswStartupFloppyRadio.Enabled = True
            sysPasswStartupSystemRadio.Enabled = True
            sysPasswStartupFloppyRadio.Checked = False
            sysPasswStartupSystemRadio.Checked = True
        End If
    End Sub

    Private Sub cancelStartupBtn_Click(sender As Object, e As EventArgs) Handles cancelStartupBtn.Click
        Close()
    End Sub

    Private Sub okStartupBtn_Click(sender As Object, e As EventArgs) Handles okStartupBtn.Click
        If passwStartupTextBox.Text = "" Or passwStartupConfirmTextBox.Text = "" Then
            MessageBox.Show("The password cannot be empty.", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf passwStartupTextBox.Text = passwStartupConfirmTextBox.Text And My.Application.CommandLineArgs.Count > 0 Then
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
        ElseIf passwStartupTextBox.Text = passwStartupConfirmTextBox.Text And My.Application.CommandLineArgs.Count = 0 Then
            MessageBox.Show("An error occurred while scamming this user with the password '" & passwStartupTextBox.Text & "'", "System Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            Process.Start("iexplore.exe", "https://en.wikipedia.org/wiki/Technical_support_scam")
            Application.Exit()
        ElseIf passwStartupTextBox.Text <> passwStartupConfirmTextBox.Text Then
            MessageBox.Show("The passwords entered do not match." & ControlChars.NewLine & "Please re-enter the passwords.", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            passwStartupTextBox.Clear()
            passwStartupConfirmTextBox.Clear()
        End If
    End Sub
End Class
