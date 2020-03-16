Public Class startupKey
    Private Sub startupKey_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Clear typed password(s) when closing this form
        passwStartupTextBox.Clear()
        passwStartupConfirmTextBox.Clear()
    End Sub

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
        If sysPasswStartupSystemRadio.Checked = True Then
            Close()
        ElseIf sysPasswStartupFloppyRadio.Checked = True Then
            MessageBox.Show("Insert a disk into drive A: that will be used to save the Startup Key.", "Save Startup Key", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        Else
            If passwStartupTextBox.Text <> "" AndAlso passwStartupConfirmTextBox.Text <> "" Then
                If passwStartupTextBox.Text = passwStartupConfirmTextBox.Text Then
                    'Check SCAM Lock Tool behavior settings
                    Select Case Parser.GetBehavior()
                        Case 1
                            '1 = Error, open Wikipedia.
                            MessageBox.Show("An error occurred while attempting to scam this user.", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Process.Start("https://en.wikipedia.org/wiki/Technical_support_scam")
                            Application.Exit()
                        Case 2
                            '2 = Success.
                            MessageBox.Show("The Account Database Startup Key was changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Application.Exit()
                        Case Else
                            '0 = Default. Error, don't open Wikipedia.
                            MessageBox.Show("An error occurred while changing the Account Database Startup Key.", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Select
                Else
                    MessageBox.Show("The passwords entered do not match." & Environment.NewLine & "Please re-enter the passwords.", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("The password cannot be empty.", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class
