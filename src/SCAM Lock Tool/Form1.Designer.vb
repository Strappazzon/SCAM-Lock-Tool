<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.DisabledEncryptionRadioBtn = New System.Windows.Forms.RadioButton()
        Me.EnabledEncryptionRadioBtn = New System.Windows.Forms.RadioButton()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.SyskeyIcon = New System.Windows.Forms.PictureBox()
        CType(Me.SyskeyIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.DescriptionLabel.Location = New System.Drawing.Point(85, 15)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(263, 91)
        Me.DescriptionLabel.TabIndex = 1
        Me.DescriptionLabel.Text = "This tool will allow you to configure the Accounts" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Database to enable additional" &
    " encryption, further" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "protecting the database from compromise." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Once enabled" &
    ", this encryption cannot be" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "disabled."
        '
        'DisabledEncryptionRadioBtn
        '
        Me.DisabledEncryptionRadioBtn.AutoSize = True
        Me.DisabledEncryptionRadioBtn.Enabled = False
        Me.DisabledEncryptionRadioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DisabledEncryptionRadioBtn.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.DisabledEncryptionRadioBtn.Location = New System.Drawing.Point(88, 118)
        Me.DisabledEncryptionRadioBtn.Name = "DisabledEncryptionRadioBtn"
        Me.DisabledEncryptionRadioBtn.Size = New System.Drawing.Size(127, 17)
        Me.DisabledEncryptionRadioBtn.TabIndex = 1
        Me.DisabledEncryptionRadioBtn.TabStop = True
        Me.DisabledEncryptionRadioBtn.Text = "Encryption Disabled"
        Me.DisabledEncryptionRadioBtn.UseVisualStyleBackColor = True
        '
        'EnabledEncryptionRadioBtn
        '
        Me.EnabledEncryptionRadioBtn.AutoSize = True
        Me.EnabledEncryptionRadioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EnabledEncryptionRadioBtn.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.EnabledEncryptionRadioBtn.Location = New System.Drawing.Point(88, 141)
        Me.EnabledEncryptionRadioBtn.Name = "EnabledEncryptionRadioBtn"
        Me.EnabledEncryptionRadioBtn.Size = New System.Drawing.Size(124, 17)
        Me.EnabledEncryptionRadioBtn.TabIndex = 2
        Me.EnabledEncryptionRadioBtn.TabStop = True
        Me.EnabledEncryptionRadioBtn.Text = "Encryption Enabled"
        Me.EnabledEncryptionRadioBtn.UseVisualStyleBackColor = True
        '
        'OkBtn
        '
        Me.OkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OkBtn.Location = New System.Drawing.Point(70, 170)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(70, 24)
        Me.OkBtn.TabIndex = 3
        Me.OkBtn.Text = "OK"
        Me.OkBtn.UseVisualStyleBackColor = True
        '
        'UpdateBtn
        '
        Me.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.UpdateBtn.Location = New System.Drawing.Point(222, 170)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(70, 24)
        Me.UpdateBtn.TabIndex = 5
        Me.UpdateBtn.Text = "Update"
        Me.UpdateBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CancelBtn.Location = New System.Drawing.Point(146, 170)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(70, 24)
        Me.CancelBtn.TabIndex = 4
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'SyskeyIcon
        '
        Me.SyskeyIcon.Image = Global.syskey.My.Resources.Resources.syskey
        Me.SyskeyIcon.Location = New System.Drawing.Point(15, 15)
        Me.SyskeyIcon.Name = "SyskeyIcon"
        Me.SyskeyIcon.Size = New System.Drawing.Size(64, 64)
        Me.SyskeyIcon.TabIndex = 0
        Me.SyskeyIcon.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CancelButton = Me.CancelBtn
        Me.ClientSize = New System.Drawing.Size(367, 206)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.UpdateBtn)
        Me.Controls.Add(Me.OkBtn)
        Me.Controls.Add(Me.EnabledEncryptionRadioBtn)
        Me.Controls.Add(Me.DisabledEncryptionRadioBtn)
        Me.Controls.Add(Me.DescriptionLabel)
        Me.Controls.Add(Me.SyskeyIcon)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(383, 245)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Securing Windows Account Database"
        CType(Me.SyskeyIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SyskeyIcon As PictureBox
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents DisabledEncryptionRadioBtn As RadioButton
    Friend WithEvents EnabledEncryptionRadioBtn As RadioButton
    Friend WithEvents OkBtn As Button
    Friend WithEvents UpdateBtn As Button
    Friend WithEvents CancelBtn As Button
End Class
