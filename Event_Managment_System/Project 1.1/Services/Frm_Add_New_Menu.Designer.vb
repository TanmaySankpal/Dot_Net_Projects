<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Add_New_Menu
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
        Me.Tb_Menu_Category = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tb_Menu_ID = New System.Windows.Forms.TextBox()
        Me.Lbl_Menu_ID = New System.Windows.Forms.Label()
        Me.Lbl_Menu_Type = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lbl_Event_Package = New System.Windows.Forms.Label()
        Me.Btn_Browse = New System.Windows.Forms.Button()
        Me.Pb_Menu_Photo = New System.Windows.Forms.PictureBox()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.Btn_Menu_Event = New System.Windows.Forms.Button()
        Me.Cb_Menu_Type = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Tb_Breakfast_Charges = New System.Windows.Forms.TextBox()
        Me.Tb_Vg_Starter_Charges = New System.Windows.Forms.TextBox()
        Me.Tb_NVg_Starter_Charges = New System.Windows.Forms.TextBox()
        Me.Tb_Vg_Lunch_Charges = New System.Windows.Forms.TextBox()
        Me.Tb_NVg_Lunch_Charges = New System.Windows.Forms.TextBox()
        Me.Tb_Vg_Dinner_Charges = New System.Windows.Forms.TextBox()
        Me.Tb_NVg_Dinner_Charges = New System.Windows.Forms.TextBox()
        Me.Tb_Sweet_Charges = New System.Windows.Forms.TextBox()
        Me.Tb_IceCream_Charges = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Pb_Menu_Photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tb_Menu_Category
        '
        Me.Tb_Menu_Category.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Menu_Category.Location = New System.Drawing.Point(324, 418)
        Me.Tb_Menu_Category.Name = "Tb_Menu_Category"
        Me.Tb_Menu_Category.Size = New System.Drawing.Size(391, 49)
        Me.Tb_Menu_Category.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Label2.Location = New System.Drawing.Point(141, 571)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 38)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Menu Charges"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Panel1.Location = New System.Drawing.Point(-82, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1749, 119)
        Me.Panel1.TabIndex = 67
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 72.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label1.Location = New System.Drawing.Point(547, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(726, 106)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Add New Menu"
        '
        'Tb_Menu_ID
        '
        Me.Tb_Menu_ID.Enabled = False
        Me.Tb_Menu_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Menu_ID.Location = New System.Drawing.Point(324, 179)
        Me.Tb_Menu_ID.Name = "Tb_Menu_ID"
        Me.Tb_Menu_ID.Size = New System.Drawing.Size(391, 49)
        Me.Tb_Menu_ID.TabIndex = 58
        Me.Tb_Menu_ID.Text = "1"
        '
        'Lbl_Menu_ID
        '
        Me.Lbl_Menu_ID.AutoSize = True
        Me.Lbl_Menu_ID.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Menu_ID.Location = New System.Drawing.Point(137, 179)
        Me.Lbl_Menu_ID.Name = "Lbl_Menu_ID"
        Me.Lbl_Menu_ID.Size = New System.Drawing.Size(104, 38)
        Me.Lbl_Menu_ID.TabIndex = 66
        Me.Lbl_Menu_ID.Text = "Menu ID"
        '
        'Lbl_Menu_Type
        '
        Me.Lbl_Menu_Type.AutoSize = True
        Me.Lbl_Menu_Type.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Menu_Type.Location = New System.Drawing.Point(137, 304)
        Me.Lbl_Menu_Type.Name = "Lbl_Menu_Type"
        Me.Lbl_Menu_Type.Size = New System.Drawing.Size(132, 38)
        Me.Lbl_Menu_Type.TabIndex = 64
        Me.Lbl_Menu_Type.Text = "Menu Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1448, 578)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 23)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Per Plate"
        '
        'Lbl_Event_Package
        '
        Me.Lbl_Event_Package.AutoSize = True
        Me.Lbl_Event_Package.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Event_Package.Location = New System.Drawing.Point(137, 426)
        Me.Lbl_Event_Package.Name = "Lbl_Event_Package"
        Me.Lbl_Event_Package.Size = New System.Drawing.Size(167, 38)
        Me.Lbl_Event_Package.TabIndex = 78
        Me.Lbl_Event_Package.Text = "Package Name"
        '
        'Btn_Browse
        '
        Me.Btn_Browse.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Btn_Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Browse.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Browse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_Browse.Image = Global.WindowsApplication1.My.Resources.Resources.iconfinder_icon_101_folder_search_3146781
        Me.Btn_Browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Browse.Location = New System.Drawing.Point(1018, 425)
        Me.Btn_Browse.Name = "Btn_Browse"
        Me.Btn_Browse.Size = New System.Drawing.Size(256, 54)
        Me.Btn_Browse.TabIndex = 70
        Me.Btn_Browse.Text = "Browse Image"
        Me.Btn_Browse.UseVisualStyleBackColor = False
        '
        'Pb_Menu_Photo
        '
        Me.Pb_Menu_Photo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Pb_Menu_Photo.Location = New System.Drawing.Point(840, 166)
        Me.Pb_Menu_Photo.Name = "Pb_Menu_Photo"
        Me.Pb_Menu_Photo.Size = New System.Drawing.Size(595, 313)
        Me.Pb_Menu_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pb_Menu_Photo.TabIndex = 69
        Me.Pb_Menu_Photo.TabStop = False
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cancel.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Btn_Cancel.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_Cancel.Image = Global.WindowsApplication1.My.Resources.Resources.close_icon2
        Me.Btn_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cancel.Location = New System.Drawing.Point(774, 697)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(155, 54)
        Me.Btn_Cancel.TabIndex = 63
        Me.Btn_Cancel.Text = "Cancel "
        Me.Btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancel.UseVisualStyleBackColor = False
        '
        'Btn_Menu_Event
        '
        Me.Btn_Menu_Event.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Btn_Menu_Event.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Menu_Event.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Btn_Menu_Event.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_Menu_Event.Image = Global.WindowsApplication1.My.Resources.Resources.add_icon3
        Me.Btn_Menu_Event.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Menu_Event.Location = New System.Drawing.Point(517, 697)
        Me.Btn_Menu_Event.Name = "Btn_Menu_Event"
        Me.Btn_Menu_Event.Size = New System.Drawing.Size(198, 54)
        Me.Btn_Menu_Event.TabIndex = 62
        Me.Btn_Menu_Event.Text = "  Add Menu"
        Me.Btn_Menu_Event.UseVisualStyleBackColor = False
        '
        'Cb_Menu_Type
        '
        Me.Cb_Menu_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Menu_Type.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Bold)
        Me.Cb_Menu_Type.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Cb_Menu_Type.FormattingEnabled = True
        Me.Cb_Menu_Type.Items.AddRange(New Object() {"Vegitarian", "Non-Vegitarian", "Vegitarian & Non-Vegitarian"})
        Me.Cb_Menu_Type.Location = New System.Drawing.Point(324, 296)
        Me.Cb_Menu_Type.Name = "Cb_Menu_Type"
        Me.Cb_Menu_Type.Size = New System.Drawing.Size(391, 46)
        Me.Cb_Menu_Type.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(418, 621)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(229, 32)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Non-Vegetarian"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(483, 575)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 32)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Vegetarian"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 21.75!)
        Me.Label6.Location = New System.Drawing.Point(318, 518)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 31)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "Breakfast"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 21.75!)
        Me.Label7.Location = New System.Drawing.Point(662, 518)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 31)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "Starters"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 21.75!)
        Me.Label8.Location = New System.Drawing.Point(825, 518)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 31)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "Lunch"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 21.75!)
        Me.Label9.Location = New System.Drawing.Point(977, 518)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 31)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "Dinner"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 21.75!)
        Me.Label10.Location = New System.Drawing.Point(1145, 518)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 31)
        Me.Label10.TabIndex = 101
        Me.Label10.Text = "Sweet"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Modern No. 20", 21.75!)
        Me.Label11.Location = New System.Drawing.Point(1309, 518)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 31)
        Me.Label11.TabIndex = 102
        Me.Label11.Text = "Ice-Cream"
        '
        'Tb_Breakfast_Charges
        '
        Me.Tb_Breakfast_Charges.Font = New System.Drawing.Font("Modern No. 20", 21.75!)
        Me.Tb_Breakfast_Charges.Location = New System.Drawing.Point(308, 571)
        Me.Tb_Breakfast_Charges.Name = "Tb_Breakfast_Charges"
        Me.Tb_Breakfast_Charges.Size = New System.Drawing.Size(159, 39)
        Me.Tb_Breakfast_Charges.TabIndex = 103
        '
        'Tb_Vg_Starter_Charges
        '
        Me.Tb_Vg_Starter_Charges.Font = New System.Drawing.Font("Modern No. 20", 21.75!)
        Me.Tb_Vg_Starter_Charges.Location = New System.Drawing.Point(657, 570)
        Me.Tb_Vg_Starter_Charges.Name = "Tb_Vg_Starter_Charges"
        Me.Tb_Vg_Starter_Charges.Size = New System.Drawing.Size(137, 39)
        Me.Tb_Vg_Starter_Charges.TabIndex = 104
        '
        'Tb_NVg_Starter_Charges
        '
        Me.Tb_NVg_Starter_Charges.Font = New System.Drawing.Font("Modern No. 20", 21.75!)
        Me.Tb_NVg_Starter_Charges.Location = New System.Drawing.Point(657, 621)
        Me.Tb_NVg_Starter_Charges.Name = "Tb_NVg_Starter_Charges"
        Me.Tb_NVg_Starter_Charges.Size = New System.Drawing.Size(137, 39)
        Me.Tb_NVg_Starter_Charges.TabIndex = 105
        '
        'Tb_Vg_Lunch_Charges
        '
        Me.Tb_Vg_Lunch_Charges.Font = New System.Drawing.Font("Modern No. 20", 21.75!)
        Me.Tb_Vg_Lunch_Charges.Location = New System.Drawing.Point(819, 570)
        Me.Tb_Vg_Lunch_Charges.Name = "Tb_Vg_Lunch_Charges"
        Me.Tb_Vg_Lunch_Charges.Size = New System.Drawing.Size(137, 39)
        Me.Tb_Vg_Lunch_Charges.TabIndex = 106
        '
        'Tb_NVg_Lunch_Charges
        '
        Me.Tb_NVg_Lunch_Charges.Font = New System.Drawing.Font("Modern No. 20", 21.75!)
        Me.Tb_NVg_Lunch_Charges.Location = New System.Drawing.Point(819, 621)
        Me.Tb_NVg_Lunch_Charges.Name = "Tb_NVg_Lunch_Charges"
        Me.Tb_NVg_Lunch_Charges.Size = New System.Drawing.Size(137, 39)
        Me.Tb_NVg_Lunch_Charges.TabIndex = 107
        '
        'Tb_Vg_Dinner_Charges
        '
        Me.Tb_Vg_Dinner_Charges.Font = New System.Drawing.Font("Modern No. 20", 21.75!)
        Me.Tb_Vg_Dinner_Charges.Location = New System.Drawing.Point(983, 568)
        Me.Tb_Vg_Dinner_Charges.Name = "Tb_Vg_Dinner_Charges"
        Me.Tb_Vg_Dinner_Charges.Size = New System.Drawing.Size(137, 39)
        Me.Tb_Vg_Dinner_Charges.TabIndex = 108
        '
        'Tb_NVg_Dinner_Charges
        '
        Me.Tb_NVg_Dinner_Charges.Font = New System.Drawing.Font("Modern No. 20", 21.75!)
        Me.Tb_NVg_Dinner_Charges.Location = New System.Drawing.Point(983, 619)
        Me.Tb_NVg_Dinner_Charges.Name = "Tb_NVg_Dinner_Charges"
        Me.Tb_NVg_Dinner_Charges.Size = New System.Drawing.Size(137, 39)
        Me.Tb_NVg_Dinner_Charges.TabIndex = 109
        '
        'Tb_Sweet_Charges
        '
        Me.Tb_Sweet_Charges.Font = New System.Drawing.Font("Modern No. 20", 21.75!)
        Me.Tb_Sweet_Charges.Location = New System.Drawing.Point(1137, 568)
        Me.Tb_Sweet_Charges.Name = "Tb_Sweet_Charges"
        Me.Tb_Sweet_Charges.Size = New System.Drawing.Size(137, 39)
        Me.Tb_Sweet_Charges.TabIndex = 110
        '
        'Tb_IceCream_Charges
        '
        Me.Tb_IceCream_Charges.Font = New System.Drawing.Font("Modern No. 20", 21.75!)
        Me.Tb_IceCream_Charges.Location = New System.Drawing.Point(1305, 568)
        Me.Tb_IceCream_Charges.Name = "Tb_IceCream_Charges"
        Me.Tb_IceCream_Charges.Size = New System.Drawing.Size(137, 39)
        Me.Tb_IceCream_Charges.TabIndex = 111
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1147, 629)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 23)
        Me.Label12.TabIndex = 112
        Me.Label12.Text = "Per Plate"
        '
        'Frm_Add_New_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1584, 762)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Tb_IceCream_Charges)
        Me.Controls.Add(Me.Tb_Sweet_Charges)
        Me.Controls.Add(Me.Tb_NVg_Dinner_Charges)
        Me.Controls.Add(Me.Tb_Vg_Dinner_Charges)
        Me.Controls.Add(Me.Tb_NVg_Lunch_Charges)
        Me.Controls.Add(Me.Tb_Vg_Lunch_Charges)
        Me.Controls.Add(Me.Tb_NVg_Starter_Charges)
        Me.Controls.Add(Me.Tb_Vg_Starter_Charges)
        Me.Controls.Add(Me.Tb_Breakfast_Charges)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Cb_Menu_Type)
        Me.Controls.Add(Me.Lbl_Event_Package)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Btn_Browse)
        Me.Controls.Add(Me.Tb_Menu_Category)
        Me.Controls.Add(Me.Pb_Menu_Photo)
        Me.Controls.Add(Me.Btn_Cancel)
        Me.Controls.Add(Me.Btn_Menu_Event)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Tb_Menu_ID)
        Me.Controls.Add(Me.Lbl_Menu_ID)
        Me.Controls.Add(Me.Lbl_Menu_Type)
        Me.Name = "Frm_Add_New_Menu"
        Me.Text = "Add New Menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Pb_Menu_Photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Browse As System.Windows.Forms.Button
    Friend WithEvents Tb_Menu_Category As System.Windows.Forms.TextBox
    Friend WithEvents Pb_Menu_Photo As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents Btn_Menu_Event As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Tb_Menu_ID As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Menu_ID As System.Windows.Forms.Label
    Friend WithEvents Lbl_Menu_Type As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Event_Package As System.Windows.Forms.Label
    Friend WithEvents Cb_Menu_Type As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Tb_Breakfast_Charges As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Vg_Starter_Charges As System.Windows.Forms.TextBox
    Friend WithEvents Tb_NVg_Starter_Charges As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Vg_Lunch_Charges As System.Windows.Forms.TextBox
    Friend WithEvents Tb_NVg_Lunch_Charges As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Vg_Dinner_Charges As System.Windows.Forms.TextBox
    Friend WithEvents Tb_NVg_Dinner_Charges As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Sweet_Charges As System.Windows.Forms.TextBox
    Friend WithEvents Tb_IceCream_Charges As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
