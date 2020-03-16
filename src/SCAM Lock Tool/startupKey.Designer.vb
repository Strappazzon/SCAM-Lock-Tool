<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StartupKey
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartupKey))
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.SystemPasswordStartupContainer = New System.Windows.Forms.GroupBox()
        Me.SystemPasswordStartupSystemRadioBtn = New System.Windows.Forms.RadioButton()
        Me.SystemPasswordStartupFloppyRadioBtn = New System.Windows.Forms.RadioButton()
        Me.SystemPasswordStartupRadioBtn = New System.Windows.Forms.RadioButton()
        Me.PasswordStartupContainer = New System.Windows.Forms.GroupBox()
        Me.PasswordStartupConfirmLabel = New System.Windows.Forms.Label()
        Me.PasswordStartupConfirmTxtBox = New System.Windows.Forms.TextBox()
        Me.PasswordStartupLabel = New System.Windows.Forms.Label()
        Me.PasswordStartupTxtBox = New System.Windows.Forms.TextBox()
        Me.PasswordStartupDescriptionLabel = New System.Windows.Forms.Label()
        Me.PasswordStartupRadioBtn = New System.Windows.Forms.RadioButton()
        Me.SystemPasswordStartupContainer.SuspendLayout()
        Me.PasswordStartupContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'CancelBtn
        '
        Me.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CancelBtn.Location = New System.Drawing.Point(166, 315)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(70, 24)
        Me.CancelBtn.TabIndex = 2
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'OkBtn
        '
        Me.OkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OkBtn.Location = New System.Drawing.Point(90, 315)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(70, 24)
        Me.OkBtn.TabIndex = 3
        Me.OkBtn.Text = "OK"
        Me.OkBtn.UseVisualStyleBackColor = True
        '
        'SystemPasswordStartupContainer
        '
        Me.SystemPasswordStartupContainer.Controls.Add(Me.SystemPasswordStartupSystemRadioBtn)
        Me.SystemPasswordStartupContainer.Controls.Add(Me.SystemPasswordStartupFloppyRadioBtn)
        Me.SystemPasswordStartupContainer.Controls.Add(Me.SystemPasswordStartupRadioBtn)
        Me.SystemPasswordStartupContainer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SystemPasswordStartupContainer.Location = New System.Drawing.Point(12, 161)
        Me.SystemPasswordStartupContainer.Name = "SystemPasswordStartupContainer"
        Me.SystemPasswordStartupContainer.Size = New System.Drawing.Size(298, 132)
        Me.SystemPasswordStartupContainer.TabIndex = 6
        Me.SystemPasswordStartupContainer.TabStop = False
        '
        'SystemPasswordStartupSystemRadioBtn
        '
        Me.SystemPasswordStartupSystemRadioBtn.AutoSize = True
        Me.SystemPasswordStartupSystemRadioBtn.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.SystemPasswordStartupSystemRadioBtn.Checked = True
        Me.SystemPasswordStartupSystemRadioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SystemPasswordStartupSystemRadioBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.SystemPasswordStartupSystemRadioBtn.Location = New System.Drawing.Point(25, 72)
        Me.SystemPasswordStartupSystemRadioBtn.Name = "SystemPasswordStartupSystemRadioBtn"
        Me.SystemPasswordStartupSystemRadioBtn.Size = New System.Drawing.Size(253, 56)
        Me.SystemPasswordStartupSystemRadioBtn.TabIndex = 9
        Me.SystemPasswordStartupSystemRadioBtn.TabStop = True
        Me.SystemPasswordStartupSystemRadioBtn.Text = "Store Startup Key Locally" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Stores a key as part of the operating system," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and no " &
    "interaction is required during system" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "start."
        Me.SystemPasswordStartupSystemRadioBtn.UseVisualStyleBackColor = True
        '
        'SystemPasswordStartupFloppyRadioBtn
        '
        Me.SystemPasswordStartupFloppyRadioBtn.AutoSize = True
        Me.SystemPasswordStartupFloppyRadioBtn.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.SystemPasswordStartupFloppyRadioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SystemPasswordStartupFloppyRadioBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.SystemPasswordStartupFloppyRadioBtn.Location = New System.Drawing.Point(25, 23)
        Me.SystemPasswordStartupFloppyRadioBtn.Name = "SystemPasswordStartupFloppyRadioBtn"
        Me.SystemPasswordStartupFloppyRadioBtn.Size = New System.Drawing.Size(251, 43)
        Me.SystemPasswordStartupFloppyRadioBtn.TabIndex = 8
        Me.SystemPasswordStartupFloppyRadioBtn.Text = "Store Startup Key on Floppy Disk" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Requires a floppy disk to be inserted during" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "s" &
    "ystem start."
        Me.SystemPasswordStartupFloppyRadioBtn.UseVisualStyleBackColor = True
        '
        'SystemPasswordStartupRadioBtn
        '
        Me.SystemPasswordStartupRadioBtn.AutoSize = True
        Me.SystemPasswordStartupRadioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SystemPasswordStartupRadioBtn.Location = New System.Drawing.Point(6, 0)
        Me.SystemPasswordStartupRadioBtn.Name = "SystemPasswordStartupRadioBtn"
        Me.SystemPasswordStartupRadioBtn.Size = New System.Drawing.Size(168, 17)
        Me.SystemPasswordStartupRadioBtn.TabIndex = 7
        Me.SystemPasswordStartupRadioBtn.Text = "System Generated Password"
        Me.SystemPasswordStartupRadioBtn.UseVisualStyleBackColor = True
        '
        'PasswordStartupContainer
        '
        Me.PasswordStartupContainer.Controls.Add(Me.PasswordStartupConfirmLabel)
        Me.PasswordStartupContainer.Controls.Add(Me.PasswordStartupConfirmTxtBox)
        Me.PasswordStartupContainer.Controls.Add(Me.PasswordStartupLabel)
        Me.PasswordStartupContainer.Controls.Add(Me.PasswordStartupTxtBox)
        Me.PasswordStartupContainer.Controls.Add(Me.PasswordStartupDescriptionLabel)
        Me.PasswordStartupContainer.Controls.Add(Me.PasswordStartupRadioBtn)
        Me.PasswordStartupContainer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PasswordStartupContainer.Location = New System.Drawing.Point(12, 12)
        Me.PasswordStartupContainer.Name = "PasswordStartupContainer"
        Me.PasswordStartupContainer.Size = New System.Drawing.Size(298, 132)
        Me.PasswordStartupContainer.TabIndex = 5
        Me.PasswordStartupContainer.TabStop = False
        '
        'PasswordStartupConfirmLabel
        '
        Me.PasswordStartupConfirmLabel.AutoSize = True
        Me.PasswordStartupConfirmLabel.Location = New System.Drawing.Point(22, 92)
        Me.PasswordStartupConfirmLabel.Name = "PasswordStartupConfirmLabel"
        Me.PasswordStartupConfirmLabel.Size = New System.Drawing.Size(51, 13)
        Me.PasswordStartupConfirmLabel.TabIndex = 6
        Me.PasswordStartupConfirmLabel.Text = "Confirm:"
        '
        'PasswordStartupConfirmTxtBox
        '
        Me.PasswordStartupConfirmTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PasswordStartupConfirmTxtBox.Enabled = False
        Me.PasswordStartupConfirmTxtBox.Location = New System.Drawing.Point(87, 90)
        Me.PasswordStartupConfirmTxtBox.MaxLength = 24
        Me.PasswordStartupConfirmTxtBox.Name = "PasswordStartupConfirmTxtBox"
        Me.PasswordStartupConfirmTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordStartupConfirmTxtBox.Size = New System.Drawing.Size(205, 22)
        Me.PasswordStartupConfirmTxtBox.TabIndex = 1
        Me.PasswordStartupConfirmTxtBox.WordWrap = False
        '
        'PasswordStartupLabel
        '
        Me.PasswordStartupLabel.AutoSize = True
        Me.PasswordStartupLabel.Location = New System.Drawing.Point(22, 64)
        Me.PasswordStartupLabel.Name = "PasswordStartupLabel"
        Me.PasswordStartupLabel.Size = New System.Drawing.Size(59, 13)
        Me.PasswordStartupLabel.TabIndex = 4
        Me.PasswordStartupLabel.Text = "Password:"
        '
        'PasswordStartupTxtBox
        '
        Me.PasswordStartupTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PasswordStartupTxtBox.Enabled = False
        Me.PasswordStartupTxtBox.Location = New System.Drawing.Point(87, 62)
        Me.PasswordStartupTxtBox.MaxLength = 24
        Me.PasswordStartupTxtBox.Name = "PasswordStartupTxtBox"
        Me.PasswordStartupTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordStartupTxtBox.Size = New System.Drawing.Size(205, 22)
        Me.PasswordStartupTxtBox.TabIndex = 0
        Me.PasswordStartupTxtBox.WordWrap = False
        '
        'PasswordStartupDescriptionLabel
        '
        Me.PasswordStartupDescriptionLabel.AutoSize = True
        Me.PasswordStartupDescriptionLabel.Location = New System.Drawing.Point(22, 20)
        Me.PasswordStartupDescriptionLabel.Name = "PasswordStartupDescriptionLabel"
        Me.PasswordStartupDescriptionLabel.Size = New System.Drawing.Size(262, 26)
        Me.PasswordStartupDescriptionLabel.TabIndex = 2
        Me.PasswordStartupDescriptionLabel.Text = "Requires a password to be entered during system" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "start."
        '
        'PasswordStartupRadioBtn
        '
        Me.PasswordStartupRadioBtn.AutoSize = True
        Me.PasswordStartupRadioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PasswordStartupRadioBtn.Location = New System.Drawing.Point(6, 0)
        Me.PasswordStartupRadioBtn.Name = "PasswordStartupRadioBtn"
        Me.PasswordStartupRadioBtn.Size = New System.Drawing.Size(114, 17)
        Me.PasswordStartupRadioBtn.TabIndex = 4
        Me.PasswordStartupRadioBtn.Text = "Password Startup"
        Me.PasswordStartupRadioBtn.UseVisualStyleBackColor = True
        '
        'StartupKey
        '
        Me.AcceptButton = Me.OkBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CancelButton = Me.CancelBtn
        Me.ClientSize = New System.Drawing.Size(322, 351)
        Me.Controls.Add(Me.PasswordStartupContainer)
        Me.Controls.Add(Me.SystemPasswordStartupContainer)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.OkBtn)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StartupKey"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Tag = "startupForm"
        Me.Text = "Startup Key"
        Me.SystemPasswordStartupContainer.ResumeLayout(False)
        Me.SystemPasswordStartupContainer.PerformLayout()
        Me.PasswordStartupContainer.ResumeLayout(False)
        Me.PasswordStartupContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CancelBtn As Button
    Friend WithEvents OkBtn As Button
    Friend WithEvents SystemPasswordStartupContainer As GroupBox
    Friend WithEvents SystemPasswordStartupSystemRadioBtn As RadioButton
    Friend WithEvents SystemPasswordStartupFloppyRadioBtn As RadioButton
    Friend WithEvents SystemPasswordStartupRadioBtn As RadioButton
    Friend WithEvents PasswordStartupContainer As GroupBox
    Friend WithEvents PasswordStartupConfirmLabel As Label
    Friend WithEvents PasswordStartupConfirmTxtBox As TextBox
    Friend WithEvents PasswordStartupLabel As Label
    Friend WithEvents PasswordStartupTxtBox As TextBox
    Friend WithEvents PasswordStartupDescriptionLabel As Label
    Friend WithEvents PasswordStartupRadioBtn As RadioButton
End Class
