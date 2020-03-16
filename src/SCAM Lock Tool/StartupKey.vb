Public Class StartupKey
    Private Sub StartupKey_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Clear typed password(s) when closing this form
        PasswordStartupTxtBox.Clear()
        PasswordStartupConfirmTxtBox.Clear()
    End Sub

    Private Sub PasswordStartupRadioBtn_CheckedChanged(sender As Object, e As EventArgs) Handles PasswordStartupRadioBtn.CheckedChanged
        If PasswordStartupRadioBtn.Checked = True Then
            PasswordStartupTxtBox.Enabled = True
            PasswordStartupConfirmTxtBox.Enabled = True

            SystemPasswordStartupRadioBtn.Checked = False
            SystemPasswordStartupFloppyRadioBtn.Checked = False
            SystemPasswordStartupSystemRadioBtn.Checked = False
            SystemPasswordStartupFloppyRadioBtn.Enabled = False
            SystemPasswordStartupSystemRadioBtn.Enabled = False
        End If
    End Sub

    Private Sub SystemPasswordStartupRadioBtn_CheckedChanged(sender As Object, e As EventArgs) Handles SystemPasswordStartupRadioBtn.CheckedChanged
        If SystemPasswordStartupRadioBtn.Checked = True Then
            PasswordStartupRadioBtn.Checked = False
            PasswordStartupTxtBox.Enabled = False
            PasswordStartupConfirmTxtBox.Enabled = False

            SystemPasswordStartupRadioBtn.Checked = True
            SystemPasswordStartupFloppyRadioBtn.Enabled = True
            SystemPasswordStartupSystemRadioBtn.Enabled = True
            SystemPasswordStartupFloppyRadioBtn.Checked = False
            SystemPasswordStartupSystemRadioBtn.Checked = True
        End If
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Close()
    End Sub

    Private Sub OkBtn_Click(sender As Object, e As EventArgs) Handles OkBtn.Click
        If SystemPasswordStartupSystemRadioBtn.Checked = True Then
            Close()
        ElseIf SystemPasswordStartupFloppyRadioBtn.Checked = True Then
            MessageBox.Show("Insert a disk into drive A: that will be used to save the Startup Key.", "Save Startup Key", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        Else
            If PasswordStartupTxtBox.Text <> "" AndAlso PasswordStartupConfirmTxtBox.Text <> "" Then
                If PasswordStartupTxtBox.Text = PasswordStartupConfirmTxtBox.Text Then
                    'Check SCAM Lock Tool behavior settings
                    Select Case Parser.GetBehavior()
                        Case 1
                            '1 = Error, open Wikipedia.
                            MessageBox.Show(Parser.GetCustomMessage(), "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
