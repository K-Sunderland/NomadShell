<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NomadShell
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NomadShell))
        Me.unlock = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.launchEos = New System.Windows.Forms.Button()
        Me.launchArtnet = New System.Windows.Forms.Button()
        Me.logout = New System.Windows.Forms.Button()
        Me.powerOff = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'unlock
        '
        Me.unlock.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.unlock.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.unlock.FlatAppearance.BorderSize = 2
        Me.unlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.unlock.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.unlock.Location = New System.Drawing.Point(45, 362)
        Me.unlock.Name = "unlock"
        Me.unlock.Size = New System.Drawing.Size(111, 45)
        Me.unlock.TabIndex = 0
        Me.unlock.Text = "Unlock "
        Me.unlock.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(180, 180)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'launchEos
        '
        Me.launchEos.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.launchEos.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.launchEos.FlatAppearance.BorderSize = 2
        Me.launchEos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.launchEos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.launchEos.Location = New System.Drawing.Point(214, 29)
        Me.launchEos.Name = "launchEos"
        Me.launchEos.Size = New System.Drawing.Size(111, 45)
        Me.launchEos.TabIndex = 2
        Me.launchEos.Text = "Launch EOS"
        Me.launchEos.UseVisualStyleBackColor = False
        '
        'launchArtnet
        '
        Me.launchArtnet.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.launchArtnet.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.launchArtnet.FlatAppearance.BorderSize = 2
        Me.launchArtnet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.launchArtnet.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.launchArtnet.Location = New System.Drawing.Point(214, 92)
        Me.launchArtnet.Name = "launchArtnet"
        Me.launchArtnet.Size = New System.Drawing.Size(111, 45)
        Me.launchArtnet.TabIndex = 3
        Me.launchArtnet.Text = "Launch Artnet "
        Me.launchArtnet.UseVisualStyleBackColor = False
        '
        'logout
        '
        Me.logout.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.logout.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.logout.FlatAppearance.BorderSize = 2
        Me.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.logout.Location = New System.Drawing.Point(45, 234)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(111, 45)
        Me.logout.TabIndex = 4
        Me.logout.Text = "Log Off"
        Me.logout.UseMnemonic = False
        Me.logout.UseVisualStyleBackColor = False
        '
        'powerOff
        '
        Me.powerOff.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.powerOff.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.powerOff.FlatAppearance.BorderSize = 2
        Me.powerOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.powerOff.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.powerOff.Location = New System.Drawing.Point(45, 299)
        Me.powerOff.Name = "powerOff"
        Me.powerOff.Size = New System.Drawing.Size(111, 45)
        Me.powerOff.TabIndex = 5
        Me.powerOff.Text = "Power Off"
        Me.powerOff.UseMnemonic = False
        Me.powerOff.UseVisualStyleBackColor = False
        '
        'NomadShell
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowText
        Me.ClientSize = New System.Drawing.Size(372, 445)
        Me.Controls.Add(Me.powerOff)
        Me.Controls.Add(Me.logout)
        Me.Controls.Add(Me.launchArtnet)
        Me.Controls.Add(Me.launchEos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.unlock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NomadShell"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nomad Shell"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents unlock As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents launchEos As Button
    Friend WithEvents launchArtnet As Button
    Friend WithEvents logout As Button
    Friend WithEvents powerOff As Button
End Class
