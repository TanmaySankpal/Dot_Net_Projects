<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Login
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Tb_Username = New System.Windows.Forms.TextBox()
        Me.Lbl_Username = New System.Windows.Forms.Label()
        Me.Lbl_Password = New System.Windows.Forms.Label()
        Me.Tb_Password = New System.Windows.Forms.TextBox()
        Me.Btn_Login = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Btn_View = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Tb_Username
        '
        Me.Tb_Username.BackColor = System.Drawing.Color.Azure
        Me.Tb_Username.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Tb_Username.Location = New System.Drawing.Point(211, 288)
        Me.Tb_Username.MaxLength = 10
        Me.Tb_Username.Name = "Tb_Username"
        Me.Tb_Username.Size = New System.Drawing.Size(257, 36)
        Me.Tb_Username.TabIndex = 26
        '
        'Lbl_Username
        '
        Me.Lbl_Username.AutoSize = True
        Me.Lbl_Username.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Username.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Username.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lbl_Username.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Username.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Lbl_Username.Location = New System.Drawing.Point(44, 289)
        Me.Lbl_Username.Name = "Lbl_Username"
        Me.Lbl_Username.Size = New System.Drawing.Size(140, 33)
        Me.Lbl_Username.TabIndex = 27
        Me.Lbl_Username.Text = "Username"
        '
        'Lbl_Password
        '
        Me.Lbl_Password.AutoSize = True
        Me.Lbl_Password.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Password.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Password.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lbl_Password.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Password.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Lbl_Password.Location = New System.Drawing.Point(44, 336)
        Me.Lbl_Password.Name = "Lbl_Password"
        Me.Lbl_Password.Size = New System.Drawing.Size(133, 33)
        Me.Lbl_Password.TabIndex = 29
        Me.Lbl_Password.Text = "Password"
        '
        'Tb_Password
        '
        Me.Tb_Password.BackColor = System.Drawing.Color.Azure
        Me.Tb_Password.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Password.ForeColor = System.Drawing.Color.Black
        Me.Tb_Password.Location = New System.Drawing.Point(211, 330)
        Me.Tb_Password.MaxLength = 8
        Me.Tb_Password.Name = "Tb_Password"
        Me.Tb_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(36)
        Me.Tb_Password.Size = New System.Drawing.Size(221, 36)
        Me.Tb_Password.TabIndex = 28
        '
        'Btn_Login
        '
        Me.Btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Login.Font = New System.Drawing.Font("Rockwell", 24.0!)
        Me.Btn_Login.ForeColor = System.Drawing.Color.DeepPink
        Me.Btn_Login.Location = New System.Drawing.Point(164, 399)
        Me.Btn_Login.Name = "Btn_Login"
        Me.Btn_Login.Size = New System.Drawing.Size(145, 55)
        Me.Btn_Login.TabIndex = 30
        Me.Btn_Login.Text = "Login"
        Me.Btn_Login.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.band_baaja_baaraat_2
        Me.PictureBox1.Location = New System.Drawing.Point(28, -18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(424, 300)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(369, -3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(81, 44)
        Me.Panel2.TabIndex = 11
        '
        'Btn_View
        '
        Me.Btn_View.BackColor = System.Drawing.SystemColors.Window
        Me.Btn_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_View.Location = New System.Drawing.Point(423, 330)
        Me.Btn_View.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_View.Name = "Btn_View"
        Me.Btn_View.Size = New System.Drawing.Size(45, 36)
        Me.Btn_View.TabIndex = 125
        Me.Btn_View.Text = "View"
        Me.Btn_View.UseVisualStyleBackColor = False
        '
        'Frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(480, 467)
        Me.Controls.Add(Me.Btn_View)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Btn_Login)
        Me.Controls.Add(Me.Tb_Username)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Tb_Password)
        Me.Controls.Add(Me.Lbl_Username)
        Me.Controls.Add(Me.Lbl_Password)
        Me.ForeColor = System.Drawing.Color.DarkCyan
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Tb_Username As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Username As System.Windows.Forms.Label
    Friend WithEvents Lbl_Password As System.Windows.Forms.Label
    Friend WithEvents Tb_Password As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Login As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Btn_View As System.Windows.Forms.Button

End Class
