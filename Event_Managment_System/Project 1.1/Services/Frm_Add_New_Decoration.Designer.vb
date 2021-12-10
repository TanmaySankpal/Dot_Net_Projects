<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Add_New_Decoration
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
        Me.Tb_Decoration_Category = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tb_Decoration_Type = New System.Windows.Forms.TextBox()
        Me.Tb_Decoration_Charges = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Tb_Decoration_ID = New System.Windows.Forms.TextBox()
        Me.Lbl_Menu_Categary = New System.Windows.Forms.Label()
        Me.Lbl_Menu_ID = New System.Windows.Forms.Label()
        Me.Lbl_Menu_Type = New System.Windows.Forms.Label()
        Me.Btn_Browse = New System.Windows.Forms.Button()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.Btn_Menu_Event = New System.Windows.Forms.Button()
        Me.Pb_Decoration_Photo = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.Pb_Decoration_Photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tb_Decoration_Category
        '
        Me.Tb_Decoration_Category.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Decoration_Category.Location = New System.Drawing.Point(348, 243)
        Me.Tb_Decoration_Category.Name = "Tb_Decoration_Category"
        Me.Tb_Decoration_Category.Size = New System.Drawing.Size(391, 45)
        Me.Tb_Decoration_Category.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 71.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label1.Location = New System.Drawing.Point(535, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(863, 98)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add New Decoration"
        '
        'Tb_Decoration_Type
        '
        Me.Tb_Decoration_Type.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Decoration_Type.Location = New System.Drawing.Point(348, 326)
        Me.Tb_Decoration_Type.Name = "Tb_Decoration_Type"
        Me.Tb_Decoration_Type.Size = New System.Drawing.Size(391, 45)
        Me.Tb_Decoration_Type.TabIndex = 72
        '
        'Tb_Decoration_Charges
        '
        Me.Tb_Decoration_Charges.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Decoration_Charges.Location = New System.Drawing.Point(344, 416)
        Me.Tb_Decoration_Charges.Name = "Tb_Decoration_Charges"
        Me.Tb_Decoration_Charges.Size = New System.Drawing.Size(391, 45)
        Me.Tb_Decoration_Charges.TabIndex = 74
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Label2.Location = New System.Drawing.Point(50, 423)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 38)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Decoration Charges"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Panel1.Location = New System.Drawing.Point(-86, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1749, 119)
        Me.Panel1.TabIndex = 80
        '
        'Tb_Decoration_ID
        '
        Me.Tb_Decoration_ID.Enabled = False
        Me.Tb_Decoration_ID.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Decoration_ID.Location = New System.Drawing.Point(344, 167)
        Me.Tb_Decoration_ID.Name = "Tb_Decoration_ID"
        Me.Tb_Decoration_ID.Size = New System.Drawing.Size(391, 45)
        Me.Tb_Decoration_ID.TabIndex = 71
        Me.Tb_Decoration_ID.Text = "1"
        '
        'Lbl_Menu_Categary
        '
        Me.Lbl_Menu_Categary.AutoSize = True
        Me.Lbl_Menu_Categary.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Menu_Categary.Location = New System.Drawing.Point(50, 329)
        Me.Lbl_Menu_Categary.Name = "Lbl_Menu_Categary"
        Me.Lbl_Menu_Categary.Size = New System.Drawing.Size(225, 38)
        Me.Lbl_Menu_Categary.TabIndex = 78
        Me.Lbl_Menu_Categary.Text = "Light && Music Type"
        '
        'Lbl_Menu_ID
        '
        Me.Lbl_Menu_ID.AutoSize = True
        Me.Lbl_Menu_ID.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Menu_ID.Location = New System.Drawing.Point(51, 167)
        Me.Lbl_Menu_ID.Name = "Lbl_Menu_ID"
        Me.Lbl_Menu_ID.Size = New System.Drawing.Size(156, 38)
        Me.Lbl_Menu_ID.TabIndex = 79
        Me.Lbl_Menu_ID.Text = "Decoration ID"
        '
        'Lbl_Menu_Type
        '
        Me.Lbl_Menu_Type.AutoSize = True
        Me.Lbl_Menu_Type.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Menu_Type.Location = New System.Drawing.Point(50, 250)
        Me.Lbl_Menu_Type.Name = "Lbl_Menu_Type"
        Me.Lbl_Menu_Type.Size = New System.Drawing.Size(223, 38)
        Me.Lbl_Menu_Type.TabIndex = 77
        Me.Lbl_Menu_Type.Text = "Decoration Category"
        '
        'Btn_Browse
        '
        Me.Btn_Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Browse.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Browse.Image = Global.WindowsApplication1.My.Resources.Resources.iconfinder_icon_101_folder_search_3146781
        Me.Btn_Browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Browse.Location = New System.Drawing.Point(1054, 486)
        Me.Btn_Browse.Name = "Btn_Browse"
        Me.Btn_Browse.Size = New System.Drawing.Size(212, 43)
        Me.Btn_Browse.TabIndex = 83
        Me.Btn_Browse.Text = "     Browse Image"
        Me.Btn_Browse.UseVisualStyleBackColor = True
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cancel.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Btn_Cancel.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_Cancel.Image = Global.WindowsApplication1.My.Resources.Resources.close_icon3
        Me.Btn_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cancel.Location = New System.Drawing.Point(682, 525)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(198, 54)
        Me.Btn_Cancel.TabIndex = 76
        Me.Btn_Cancel.Text = "Cancel"
        Me.Btn_Cancel.UseVisualStyleBackColor = False
        '
        'Btn_Menu_Event
        '
        Me.Btn_Menu_Event.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Btn_Menu_Event.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Menu_Event.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Btn_Menu_Event.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_Menu_Event.Image = Global.WindowsApplication1.My.Resources.Resources.add_icon4
        Me.Btn_Menu_Event.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Menu_Event.Location = New System.Drawing.Point(348, 525)
        Me.Btn_Menu_Event.Name = "Btn_Menu_Event"
        Me.Btn_Menu_Event.Size = New System.Drawing.Size(308, 54)
        Me.Btn_Menu_Event.TabIndex = 75
        Me.Btn_Menu_Event.Text = "Add Decoration"
        Me.Btn_Menu_Event.UseVisualStyleBackColor = False
        '
        'Pb_Decoration_Photo
        '
        Me.Pb_Decoration_Photo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Pb_Decoration_Photo.Location = New System.Drawing.Point(836, 167)
        Me.Pb_Decoration_Photo.Name = "Pb_Decoration_Photo"
        Me.Pb_Decoration_Photo.Size = New System.Drawing.Size(595, 313)
        Me.Pb_Decoration_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pb_Decoration_Photo.TabIndex = 82
        Me.Pb_Decoration_Photo.TabStop = False
        '
        'Frm_Add_New_Decoration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1584, 762)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_Browse)
        Me.Controls.Add(Me.Tb_Decoration_Category)
        Me.Controls.Add(Me.Btn_Cancel)
        Me.Controls.Add(Me.Btn_Menu_Event)
        Me.Controls.Add(Me.Pb_Decoration_Photo)
        Me.Controls.Add(Me.Tb_Decoration_Type)
        Me.Controls.Add(Me.Tb_Decoration_Charges)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Tb_Decoration_ID)
        Me.Controls.Add(Me.Lbl_Menu_Categary)
        Me.Controls.Add(Me.Lbl_Menu_ID)
        Me.Controls.Add(Me.Lbl_Menu_Type)
        Me.Name = "Frm_Add_New_Decoration"
        Me.Text = "Add New Decoration"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Pb_Decoration_Photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Browse As System.Windows.Forms.Button
    Friend WithEvents Tb_Decoration_Category As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents Btn_Menu_Event As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Pb_Decoration_Photo As System.Windows.Forms.PictureBox
    Friend WithEvents Tb_Decoration_Type As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Decoration_Charges As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Tb_Decoration_ID As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Menu_Categary As System.Windows.Forms.Label
    Friend WithEvents Lbl_Menu_ID As System.Windows.Forms.Label
    Friend WithEvents Lbl_Menu_Type As System.Windows.Forms.Label
End Class
