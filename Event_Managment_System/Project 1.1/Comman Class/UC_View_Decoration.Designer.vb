<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_View_Decoration
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Tb_Event_Charges = New System.Windows.Forms.TextBox()
        Me.Tb_Event_Category = New System.Windows.Forms.TextBox()
        Me.Tb_Event_Type = New System.Windows.Forms.TextBox()
        Me.Pb_UC_Picture = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lbl_Menu_Categary = New System.Windows.Forms.Label()
        Me.Lbl_Menu_Type = New System.Windows.Forms.Label()
        CType(Me.Pb_UC_Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tb_Event_Charges
        '
        Me.Tb_Event_Charges.Enabled = False
        Me.Tb_Event_Charges.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Tb_Event_Charges.Location = New System.Drawing.Point(222, 390)
        Me.Tb_Event_Charges.Name = "Tb_Event_Charges"
        Me.Tb_Event_Charges.Size = New System.Drawing.Size(135, 35)
        Me.Tb_Event_Charges.TabIndex = 66
        '
        'Tb_Event_Category
        '
        Me.Tb_Event_Category.Enabled = False
        Me.Tb_Event_Category.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Tb_Event_Category.Location = New System.Drawing.Point(221, 345)
        Me.Tb_Event_Category.Name = "Tb_Event_Category"
        Me.Tb_Event_Category.Size = New System.Drawing.Size(135, 35)
        Me.Tb_Event_Category.TabIndex = 64
        '
        'Tb_Event_Type
        '
        Me.Tb_Event_Type.Enabled = False
        Me.Tb_Event_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Tb_Event_Type.Location = New System.Drawing.Point(221, 304)
        Me.Tb_Event_Type.Name = "Tb_Event_Type"
        Me.Tb_Event_Type.Size = New System.Drawing.Size(135, 35)
        Me.Tb_Event_Type.TabIndex = 62
        '
        'Pb_UC_Picture
        '
        Me.Pb_UC_Picture.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Pb_UC_Picture.Location = New System.Drawing.Point(30, 12)
        Me.Pb_UC_Picture.Name = "Pb_UC_Picture"
        Me.Pb_UC_Picture.Size = New System.Drawing.Size(348, 286)
        Me.Pb_UC_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pb_UC_Picture.TabIndex = 60
        Me.Pb_UC_Picture.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 394)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 31)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Charges"
        '
        'Lbl_Menu_Categary
        '
        Me.Lbl_Menu_Categary.AutoSize = True
        Me.Lbl_Menu_Categary.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Menu_Categary.Location = New System.Drawing.Point(34, 349)
        Me.Lbl_Menu_Categary.Name = "Lbl_Menu_Categary"
        Me.Lbl_Menu_Categary.Size = New System.Drawing.Size(118, 31)
        Me.Lbl_Menu_Categary.TabIndex = 83
        Me.Lbl_Menu_Categary.Text = "Package"
        '
        'Lbl_Menu_Type
        '
        Me.Lbl_Menu_Type.AutoSize = True
        Me.Lbl_Menu_Type.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Menu_Type.Location = New System.Drawing.Point(3, 305)
        Me.Lbl_Menu_Type.Name = "Lbl_Menu_Type"
        Me.Lbl_Menu_Type.Size = New System.Drawing.Size(218, 31)
        Me.Lbl_Menu_Type.TabIndex = 82
        Me.Lbl_Menu_Type.Text = "Decoration Type"
        '
        'UC_View_Decoration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lbl_Menu_Categary)
        Me.Controls.Add(Me.Lbl_Menu_Type)
        Me.Controls.Add(Me.Tb_Event_Charges)
        Me.Controls.Add(Me.Tb_Event_Category)
        Me.Controls.Add(Me.Tb_Event_Type)
        Me.Controls.Add(Me.Pb_UC_Picture)
        Me.Name = "UC_View_Decoration"
        Me.Size = New System.Drawing.Size(409, 441)
        CType(Me.Pb_UC_Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tb_Event_Charges As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Event_Category As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Event_Type As System.Windows.Forms.TextBox
    Friend WithEvents Pb_UC_Picture As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Menu_Categary As System.Windows.Forms.Label
    Friend WithEvents Lbl_Menu_Type As System.Windows.Forms.Label

End Class
