<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class startupKey
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(startupKey))
        Me.cancelStartupBtn = New System.Windows.Forms.Button()
        Me.okStartupBtn = New System.Windows.Forms.Button()
        Me.sysPasswStartupBox = New System.Windows.Forms.GroupBox()
        Me.sysPasswStartupSystemRadio = New System.Windows.Forms.RadioButton()
        Me.sysPasswStartupFloppyRadio = New System.Windows.Forms.RadioButton()
        Me.sysPasswStartupRadio = New System.Windows.Forms.RadioButton()
        Me.passwStartupBox = New System.Windows.Forms.GroupBox()
        Me.passwStartupConfirmLabel = New System.Windows.Forms.Label()
        Me.passwStartupConfirmTextBox = New System.Windows.Forms.TextBox()
        Me.passwStartupLabel = New System.Windows.Forms.Label()
        Me.passwStartupTextBox = New System.Windows.Forms.TextBox()
        Me.passwStartupDescLabel = New System.Windows.Forms.Label()
        Me.passwStartupRadio = New System.Windows.Forms.RadioButton()
        Me.sysPasswStartupBox.SuspendLayout()
        Me.passwStartupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'cancelStartupBtn
        '
        Me.cancelStartupBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelStartupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cancelStartupBtn.Location = New System.Drawing.Point(166, 315)
        Me.cancelStartupBtn.Name = "cancelStartupBtn"
        Me.cancelStartupBtn.Size = New System.Drawing.Size(70, 24)
        Me.cancelStartupBtn.TabIndex = 2
        Me.cancelStartupBtn.Text = "Cancel"
        Me.cancelStartupBtn.UseVisualStyleBackColor = True
        '
        'okStartupBtn
        '
        Me.okStartupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.okStartupBtn.Location = New System.Drawing.Point(90, 315)
        Me.okStartupBtn.Name = "okStartupBtn"
        Me.okStartupBtn.Size = New System.Drawing.Size(70, 24)
        Me.okStartupBtn.TabIndex = 3
        Me.okStartupBtn.Text = "OK"
        Me.okStartupBtn.UseVisualStyleBackColor = True
        '
        'sysPasswStartupBox
        '
        Me.sysPasswStartupBox.Controls.Add(Me.sysPasswStartupSystemRadio)
        Me.sysPasswStartupBox.Controls.Add(Me.sysPasswStartupFloppyRadio)
        Me.sysPasswStartupBox.Controls.Add(Me.sysPasswStartupRadio)
        Me.sysPasswStartupBox.Enabled = False
        Me.sysPasswStartupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.sysPasswStartupBox.Location = New System.Drawing.Point(12, 161)
        Me.sysPasswStartupBox.Name = "sysPasswStartupBox"
        Me.sysPasswStartupBox.Size = New System.Drawing.Size(298, 132)
        Me.sysPasswStartupBox.TabIndex = 6
        Me.sysPasswStartupBox.TabStop = False
        '
        'sysPasswStartupSystemRadio
        '
        Me.sysPasswStartupSystemRadio.AutoSize = True
        Me.sysPasswStartupSystemRadio.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.sysPasswStartupSystemRadio.Checked = True
        Me.sysPasswStartupSystemRadio.Enabled = False
        Me.sysPasswStartupSystemRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sysPasswStartupSystemRadio.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.sysPasswStartupSystemRadio.Location = New System.Drawing.Point(25, 72)
        Me.sysPasswStartupSystemRadio.Name = "sysPasswStartupSystemRadio"
        Me.sysPasswStartupSystemRadio.Size = New System.Drawing.Size(253, 56)
        Me.sysPasswStartupSystemRadio.TabIndex = 9
        Me.sysPasswStartupSystemRadio.TabStop = True
        Me.sysPasswStartupSystemRadio.Text = "Store Startup Key Locally" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Stores a key as part of the operating system," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and no " &
    "interaction is required during system" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "start."
        Me.sysPasswStartupSystemRadio.UseVisualStyleBackColor = True
        '
        'sysPasswStartupFloppyRadio
        '
        Me.sysPasswStartupFloppyRadio.AutoSize = True
        Me.sysPasswStartupFloppyRadio.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.sysPasswStartupFloppyRadio.Enabled = False
        Me.sysPasswStartupFloppyRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sysPasswStartupFloppyRadio.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.sysPasswStartupFloppyRadio.Location = New System.Drawing.Point(25, 23)
        Me.sysPasswStartupFloppyRadio.Name = "sysPasswStartupFloppyRadio"
        Me.sysPasswStartupFloppyRadio.Size = New System.Drawing.Size(251, 43)
        Me.sysPasswStartupFloppyRadio.TabIndex = 8
        Me.sysPasswStartupFloppyRadio.Text = "Store Startup Key on Floppy Disk" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Requires a floppy disk to be inserted during" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "s" &
    "ystem start."
        Me.sysPasswStartupFloppyRadio.UseVisualStyleBackColor = True
        '
        'sysPasswStartupRadio
        '
        Me.sysPasswStartupRadio.AutoSize = True
        Me.sysPasswStartupRadio.Enabled = False
        Me.sysPasswStartupRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sysPasswStartupRadio.Location = New System.Drawing.Point(6, 0)
        Me.sysPasswStartupRadio.Name = "sysPasswStartupRadio"
        Me.sysPasswStartupRadio.Size = New System.Drawing.Size(168, 17)
        Me.sysPasswStartupRadio.TabIndex = 7
        Me.sysPasswStartupRadio.Text = "System Generated Password"
        Me.sysPasswStartupRadio.UseVisualStyleBackColor = True
        '
        'passwStartupBox
        '
        Me.passwStartupBox.Controls.Add(Me.passwStartupConfirmLabel)
        Me.passwStartupBox.Controls.Add(Me.passwStartupConfirmTextBox)
        Me.passwStartupBox.Controls.Add(Me.passwStartupLabel)
        Me.passwStartupBox.Controls.Add(Me.passwStartupTextBox)
        Me.passwStartupBox.Controls.Add(Me.passwStartupDescLabel)
        Me.passwStartupBox.Controls.Add(Me.passwStartupRadio)
        Me.passwStartupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.passwStartupBox.Location = New System.Drawing.Point(12, 12)
        Me.passwStartupBox.Name = "passwStartupBox"
        Me.passwStartupBox.Size = New System.Drawing.Size(298, 132)
        Me.passwStartupBox.TabIndex = 5
        Me.passwStartupBox.TabStop = False
        '
        'passwStartupConfirmLabel
        '
        Me.passwStartupConfirmLabel.AutoSize = True
        Me.passwStartupConfirmLabel.Location = New System.Drawing.Point(22, 92)
        Me.passwStartupConfirmLabel.Name = "passwStartupConfirmLabel"
        Me.passwStartupConfirmLabel.Size = New System.Drawing.Size(51, 13)
        Me.passwStartupConfirmLabel.TabIndex = 6
        Me.passwStartupConfirmLabel.Text = "Confirm:"
        '
        'passwStartupConfirmTextBox
        '
        Me.passwStartupConfirmTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.passwStartupConfirmTextBox.Location = New System.Drawing.Point(87, 90)
        Me.passwStartupConfirmTextBox.MaxLength = 24
        Me.passwStartupConfirmTextBox.Name = "passwStartupConfirmTextBox"
        Me.passwStartupConfirmTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwStartupConfirmTextBox.Size = New System.Drawing.Size(205, 22)
        Me.passwStartupConfirmTextBox.TabIndex = 1
        Me.passwStartupConfirmTextBox.WordWrap = False
        '
        'passwStartupLabel
        '
        Me.passwStartupLabel.AutoSize = True
        Me.passwStartupLabel.Location = New System.Drawing.Point(22, 64)
        Me.passwStartupLabel.Name = "passwStartupLabel"
        Me.passwStartupLabel.Size = New System.Drawing.Size(59, 13)
        Me.passwStartupLabel.TabIndex = 4
        Me.passwStartupLabel.Text = "Password:"
        '
        'passwStartupTextBox
        '
        Me.passwStartupTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.passwStartupTextBox.Location = New System.Drawing.Point(87, 62)
        Me.passwStartupTextBox.MaxLength = 24
        Me.passwStartupTextBox.Name = "passwStartupTextBox"
        Me.passwStartupTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwStartupTextBox.Size = New System.Drawing.Size(205, 22)
        Me.passwStartupTextBox.TabIndex = 0
        Me.passwStartupTextBox.WordWrap = False
        '
        'passwStartupDescLabel
        '
        Me.passwStartupDescLabel.AutoSize = True
        Me.passwStartupDescLabel.Location = New System.Drawing.Point(22, 20)
        Me.passwStartupDescLabel.Name = "passwStartupDescLabel"
        Me.passwStartupDescLabel.Size = New System.Drawing.Size(262, 26)
        Me.passwStartupDescLabel.TabIndex = 2
        Me.passwStartupDescLabel.Text = "Requires a password to be entered during system" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "start."
        '
        'passwStartupRadio
        '
        Me.passwStartupRadio.AutoSize = True
        Me.passwStartupRadio.Checked = True
        Me.passwStartupRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.passwStartupRadio.Location = New System.Drawing.Point(6, 0)
        Me.passwStartupRadio.Name = "passwStartupRadio"
        Me.passwStartupRadio.Size = New System.Drawing.Size(114, 17)
        Me.passwStartupRadio.TabIndex = 4
        Me.passwStartupRadio.TabStop = True
        Me.passwStartupRadio.Text = "Password Startup"
        Me.passwStartupRadio.UseVisualStyleBackColor = True
        '
        'startupKey
        '
        Me.AcceptButton = Me.okStartupBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CancelButton = Me.cancelStartupBtn
        Me.ClientSize = New System.Drawing.Size(322, 351)
        Me.Controls.Add(Me.passwStartupBox)
        Me.Controls.Add(Me.sysPasswStartupBox)
        Me.Controls.Add(Me.cancelStartupBtn)
        Me.Controls.Add(Me.okStartupBtn)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "startupKey"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Tag = "startupForm"
        Me.Text = "Startup Key"
        Me.sysPasswStartupBox.ResumeLayout(False)
        Me.sysPasswStartupBox.PerformLayout()
        Me.passwStartupBox.ResumeLayout(False)
        Me.passwStartupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cancelStartupBtn As Button
    Friend WithEvents okStartupBtn As Button
    Friend WithEvents sysPasswStartupBox As GroupBox
    Friend WithEvents sysPasswStartupSystemRadio As RadioButton
    Friend WithEvents sysPasswStartupFloppyRadio As RadioButton
    Friend WithEvents sysPasswStartupRadio As RadioButton
    Friend WithEvents passwStartupBox As GroupBox
    Friend WithEvents passwStartupConfirmLabel As Label
    Friend WithEvents passwStartupConfirmTextBox As TextBox
    Friend WithEvents passwStartupLabel As Label
    Friend WithEvents passwStartupTextBox As TextBox
    Friend WithEvents passwStartupDescLabel As Label
    Friend WithEvents passwStartupRadio As RadioButton
End Class
