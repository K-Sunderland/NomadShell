<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Password
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Password))
        Me.pwInput = New System.Windows.Forms.TextBox()
        Me.unlockBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'pwInput
        '
        Me.pwInput.Location = New System.Drawing.Point(68, 46)
        Me.pwInput.Name = "pwInput"
        Me.pwInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pwInput.Size = New System.Drawing.Size(100, 23)
        Me.pwInput.TabIndex = 0
        '
        'unlockBtn
        '
        Me.unlockBtn.Location = New System.Drawing.Point(77, 75)
        Me.unlockBtn.Name = "unlockBtn"
        Me.unlockBtn.Size = New System.Drawing.Size(75, 23)
        Me.unlockBtn.TabIndex = 1
        Me.unlockBtn.Text = "Unlock"
        Me.unlockBtn.UseVisualStyleBackColor = True
        '
        'Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowText
        Me.ClientSize = New System.Drawing.Size(236, 137)
        Me.Controls.Add(Me.unlockBtn)
        Me.Controls.Add(Me.pwInput)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pwInput As TextBox
    Friend WithEvents unlockBtn As Button
End Class
