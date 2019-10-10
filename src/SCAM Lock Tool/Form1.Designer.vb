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
        Me.descriptionLabel = New System.Windows.Forms.Label()
        Me.disabledEncryption = New System.Windows.Forms.RadioButton()
        Me.enabledEncryption = New System.Windows.Forms.RadioButton()
        Me.okBtn = New System.Windows.Forms.Button()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.syskeyMainIcon = New System.Windows.Forms.PictureBox()
        CType(Me.syskeyMainIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'descriptionLabel
        '
        Me.descriptionLabel.AutoSize = True
        Me.descriptionLabel.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.descriptionLabel.Location = New System.Drawing.Point(85, 15)
        Me.descriptionLabel.Name = "descriptionLabel"
        Me.descriptionLabel.Size = New System.Drawing.Size(263, 91)
        Me.descriptionLabel.TabIndex = 1
        Me.descriptionLabel.Text = "This tool will allow you to configure the Accounts" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Database to enable additional" &
    " encryption, further" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "protecting the database from compromise." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Once enabled" &
    ", this encryption cannot be" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "disabled."
        '
        'disabledEncryption
        '
        Me.disabledEncryption.AutoSize = True
        Me.disabledEncryption.Enabled = False
        Me.disabledEncryption.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.disabledEncryption.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.disabledEncryption.Location = New System.Drawing.Point(88, 118)
        Me.disabledEncryption.Name = "disabledEncryption"
        Me.disabledEncryption.Size = New System.Drawing.Size(127, 17)
        Me.disabledEncryption.TabIndex = 1
        Me.disabledEncryption.TabStop = True
        Me.disabledEncryption.Text = "Encryption Disabled"
        Me.disabledEncryption.UseVisualStyleBackColor = True
        '
        'enabledEncryption
        '
        Me.enabledEncryption.AutoSize = True
        Me.enabledEncryption.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.enabledEncryption.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.enabledEncryption.Location = New System.Drawing.Point(88, 141)
        Me.enabledEncryption.Name = "enabledEncryption"
        Me.enabledEncryption.Size = New System.Drawing.Size(124, 17)
        Me.enabledEncryption.TabIndex = 2
        Me.enabledEncryption.TabStop = True
        Me.enabledEncryption.Text = "Encryption Enabled"
        Me.enabledEncryption.UseVisualStyleBackColor = True
        '
        'okBtn
        '
        Me.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.okBtn.Location = New System.Drawing.Point(70, 170)
        Me.okBtn.Name = "okBtn"
        Me.okBtn.Size = New System.Drawing.Size(70, 24)
        Me.okBtn.TabIndex = 3
        Me.okBtn.Text = "OK"
        Me.okBtn.UseVisualStyleBackColor = True
        '
        'updateBtn
        '
        Me.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.updateBtn.Location = New System.Drawing.Point(222, 170)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(70, 24)
        Me.updateBtn.TabIndex = 5
        Me.updateBtn.Text = "Update"
        Me.updateBtn.UseVisualStyleBackColor = True
        '
        'cancelBtn
        '
        Me.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cancelBtn.Location = New System.Drawing.Point(146, 170)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(70, 24)
        Me.cancelBtn.TabIndex = 4
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'syskeyMainIcon
        '
        Me.syskeyMainIcon.Image = Global.syskey.My.Resources.Resources.syskey
        Me.syskeyMainIcon.Location = New System.Drawing.Point(15, 15)
        Me.syskeyMainIcon.Name = "syskeyMainIcon"
        Me.syskeyMainIcon.Size = New System.Drawing.Size(64, 64)
        Me.syskeyMainIcon.TabIndex = 0
        Me.syskeyMainIcon.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CancelButton = Me.cancelBtn
        Me.ClientSize = New System.Drawing.Size(367, 206)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.updateBtn)
        Me.Controls.Add(Me.okBtn)
        Me.Controls.Add(Me.enabledEncryption)
        Me.Controls.Add(Me.disabledEncryption)
        Me.Controls.Add(Me.descriptionLabel)
        Me.Controls.Add(Me.syskeyMainIcon)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(383, 245)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Securing Windows Account Database"
        CType(Me.syskeyMainIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents syskeyMainIcon As PictureBox
    Friend WithEvents descriptionLabel As Label
    Friend WithEvents disabledEncryption As RadioButton
    Friend WithEvents enabledEncryption As RadioButton
    Friend WithEvents okBtn As Button
    Friend WithEvents updateBtn As Button
    Friend WithEvents cancelBtn As Button
End Class
