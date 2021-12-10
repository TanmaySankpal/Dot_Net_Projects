<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Update_Menu
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
        Me.Cb_Menu_Type = New System.Windows.Forms.ComboBox()
        Me.Lbl_Event_Package = New System.Windows.Forms.Label()
        Me.Tb_Menu_Category = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tb_Menu_ID = New System.Windows.Forms.TextBox()
        Me.Lbl_Menu_ID = New System.Windows.Forms.Label()
        Me.Lbl_Menu_Type = New System.Windows.Forms.Label()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.Btn_Browse = New System.Windows.Forms.Button()
        Me.Pb_Menu_Photo = New System.Windows.Forms.PictureBox()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.Btn_Update_Menu = New System.Windows.Forms.Button()
        Me.Tb_IceCream_Charges = New System.Windows.Forms.TextBox()
        Me.Tb_Sweet_Charges = New System.Windows.Forms.TextBox()
        Me.Tb_NVg_Dinner_Charges = New System.Windows.Forms.TextBox()
        Me.Tb_Vg_Dinner_Charges = New System.Windows.Forms.TextBox()
        Me.Tb_NVg_Lunch_Charges = New System.Windows.Forms.TextBox()
        Me.Tb_Vg_Lunch_Charges = New System.Windows.Forms.TextBox()
        Me.Tb_NVg_Starter_Charges = New System.Windows.Forms.TextBox()
        Me.Tb_Vg_Starter_Charges = New System.Windows.Forms.TextBox()
        Me.Tb_Breakfast_Charges = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Pb_Menu_Photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cb_Menu_Type
        '
        Me.Cb_Menu_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Menu_Type.Enabled = False
        Me.Cb_Menu_Type.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Bold)
        Me.Cb_Menu_Type.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Cb_Menu_Type.FormattingEnabled = True
        Me.Cb_Menu_Type.Items.AddRange(New Object() {"Vegitarian", "Non-Vegitarian", "Vegitarian & Non-Vegitarian"})
        Me.Cb_Menu_Type.Location = New System.Drawing.Point(324, 294)
        Me.Cb_Menu_Type.Name = "Cb_Menu_Type"
        Me.Cb_Menu_Type.Size = New System.Drawing.Size(391, 46)
        Me.Cb_Menu_Type.TabIndex = 93
        '
        'Lbl_Event_Package
        '
        Me.Lbl_Event_Package.AutoSize = True
        Me.Lbl_Event_Package.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Event_Package.Location = New System.Drawing.Point(137, 401)
        Me.Lbl_Event_Package.Name = "Lbl_Event_Package"
        Me.Lbl_Event_Package.Size = New System.Drawing.Size(165, 38)
        Me.Lbl_Event_Package.TabIndex = 92
        Me.Lbl_Event_Package.Text = "Menu Package"
        '
        'Tb_Menu_Category
        '
        Me.Tb_Menu_Category.Enabled = False
        Me.Tb_Menu_Category.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Menu_Category.Location = New System.Drawing.Point(324, 393)
        Me.Tb_Menu_Category.Name = "Tb_Menu_Category"
        Me.Tb_Menu_Category.Size = New System.Drawing.Size(391, 49)
        Me.Tb_Menu_Category.TabIndex = 81
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
        Me.Panel1.TabIndex = 87
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 72.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label1.Location = New System.Drawing.Point(547, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(637, 106)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Update Menu"
        '
        'Tb_Menu_ID
        '
        Me.Tb_Menu_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Menu_ID.Location = New System.Drawing.Point(324, 193)
        Me.Tb_Menu_ID.Name = "Tb_Menu_ID"
        Me.Tb_Menu_ID.Size = New System.Drawing.Size(391, 49)
        Me.Tb_Menu_ID.TabIndex = 80
        '
        'Lbl_Menu_ID
        '
        Me.Lbl_Menu_ID.AutoSize = True
        Me.Lbl_Menu_ID.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Menu_ID.Location = New System.Drawing.Point(137, 193)
        Me.Lbl_Menu_ID.Name = "Lbl_Menu_ID"
        Me.Lbl_Menu_ID.Size = New System.Drawing.Size(104, 38)
        Me.Lbl_Menu_ID.TabIndex = 86
        Me.Lbl_Menu_ID.Text = "Menu ID"
        '
        'Lbl_Menu_Type
        '
        Me.Lbl_Menu_Type.AutoSize = True
        Me.Lbl_Menu_Type.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Menu_Type.Location = New System.Drawing.Point(137, 302)
        Me.Lbl_Menu_Type.Name = "Lbl_Menu_Type"
        Me.Lbl_Menu_Type.Size = New System.Drawing.Size(132, 38)
        Me.Lbl_Menu_Type.TabIndex = 85
        Me.Lbl_Menu_Type.Text = "Menu Type"
        '
        'Btn_Search
        '
        Me.Btn_Search.AutoSize = True
        Me.Btn_Search.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Search.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Search.Image = Global.WindowsApplication1.My.Resources.Resources.Knob_Search_icon
        Me.Btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Search.Location = New System.Drawing.Point(725, 197)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(100, 41)
        Me.Btn_Search.TabIndex = 94
        Me.Btn_Search.Text = "Search"
        Me.Btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Search.UseVisualStyleBackColor = False
        '
        'Btn_Browse
        '
        Me.Btn_Browse.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Btn_Browse.Enabled = False
        Me.Btn_Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Browse.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Browse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_Browse.Image = Global.WindowsApplication1.My.Resources.Resources.iconfinder_icon_101_folder_search_3146781
        Me.Btn_Browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Browse.Location = New System.Drawing.Point(1026, 426)
        Me.Btn_Browse.Name = "Btn_Browse"
        Me.Btn_Browse.Size = New System.Drawing.Size(256, 54)
        Me.Btn_Browse.TabIndex = 90
        Me.Btn_Browse.Text = "Browse Image"
        Me.Btn_Browse.UseVisualStyleBackColor = False
        '
        'Pb_Menu_Photo
        '
        Me.Pb_Menu_Photo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Pb_Menu_Photo.Enabled = False
        Me.Pb_Menu_Photo.Location = New System.Drawing.Point(840, 166)
        Me.Pb_Menu_Photo.Name = "Pb_Menu_Photo"
        Me.Pb_Menu_Photo.Size = New System.Drawing.Size(595, 313)
        Me.Pb_Menu_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pb_Menu_Photo.TabIndex = 89
        Me.Pb_Menu_Photo.TabStop = False
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Btn_Cancel.Enabled = False
        Me.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cancel.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Btn_Cancel.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_Cancel.Image = Global.WindowsApplication1.My.Resources.Resources.close_icon2
        Me.Btn_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cancel.Location = New System.Drawing.Point(762, 682)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(155, 54)
        Me.Btn_Cancel.TabIndex = 84
        Me.Btn_Cancel.Text = "Cancel "
        Me.Btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancel.UseVisualStyleBackColor = False
        '
        'Btn_Update_Menu
        '
        Me.Btn_Update_Menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Btn_Update_Menu.Enabled = False
        Me.Btn_Update_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Update_Menu.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Btn_Update_Menu.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_Update_Menu.Image = Global.WindowsApplication1.My.Resources.Resources.update_icon2
        Me.Btn_Update_Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Update_Menu.Location = New System.Drawing.Point(509, 682)
        Me.Btn_Update_Menu.Name = "Btn_Update_Menu"
        Me.Btn_Update_Menu.Size = New System.Drawing.Size(206, 54)
        Me.Btn_Update_Menu.TabIndex = 83
        Me.Btn_Update_Menu.Text = "Update Menu"
        Me.Btn_Update_Menu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Update_Menu.UseVisualStyleBackColor = False
        '
        'Tb_IceCream_Charges
        '
        Me.Tb_IceCream_Charges.Enabled = False
        Me.Tb_IceCream_Charges.Font = New System.Drawing.Font("Modern No. 20", 21.75!)
        Me.Tb_IceCream_Charges.Location = New System.Drawing.Point(1305, 541)
        Me.Tb_IceCream_Charges.Name = "Tb_IceCream_Charges"
        Me.Tb_IceCream_Charges.Size = New System.Drawing.Size(137, 39)
        Me.Tb_IceCream_Charges.TabIndex = 130
        '
        'Tb_Sweet_Charges
        '
        Me.Tb_Sweet_Charges.Enabled = False
        Me.Tb_Sweet_Charges.Font = New System.Drawing.Font("Modern No. 20", 21.75!)
        Me.Tb_Sweet_Charges.Location = New System.Drawing.Point(1137, 541)
        Me.Tb_Sweet_Charges.Name = "Tb_Sweet_Charges"
        Me.Tb_Sweet_Charges.Size = New System.Drawing.Size(137, 39)
        Me.Tb_Sweet_Charges.TabIndex = 129
        '
        'Tb_NVg_Dinner_Charges
        '
        Me.Tb_NVg_Dinner_Charges.Enabled = False
        Me.Tb_NVg_Dinner_Charges.Font = New System.Drawing.Font("Modern No. 20", 21.75!)
        Me.Tb_NVg_Dinner_Charges.Location = New System.Drawing.Point(983, 592)
        Me.Tb_NVg_Dinner_Charges.Name = "Tb_NVg_Dinner_Charges"
        Me.Tb_NVg_Dinner_Charges.Size = New System.Drawing.Size(137, 39)
        Me.Tb_NVg_Dinner_Charges.TabIndex = 128
        '
        'Tb_Vg_Dinner_Charges
        '
        Me.Tb_Vg_Dinner_Charges.Enabled = False
        Me.Tb_Vg_Dinner_Charges.Font = New System.Drawing.Font("Modern No. 20", 21.75!)
        Me.Tb_Vg_Dinner_Charges.Location = New System.Drawing.Point(983, 541)
        Me.Tb_Vg_Dinner_Charges.Name = "Tb_Vg_Dinner_Charges"
        Me.Tb_Vg_Dinner_Charges.Size = New System.Drawing.Size(137, 39)
        Me.Tb_Vg_Dinner_Charges.TabIndex = 127
        '
        'Tb_NVg_Lunch_Charges
        '
        Me.Tb_NVg_Lunch_Charges.Enabled = False
        Me.Tb_NVg_Lunch_Charges.Font = New System.Drawing.Font("Modern No. 20", 21.75!)
        Me.Tb_NVg_Lunch_Charges.Location = New System.Drawing.Point(819, 594)
        Me.Tb_NVg_Lunch_Charges.Name = "Tb_NVg_Lunch_Charges"
        Me.Tb_NVg_Lunch_Charges.Size = New System.Drawing.Size(137, 39)
        Me.Tb_NVg_Lunch_Charges.TabIndex = 126
        '
        'Tb_Vg_Lunch_Charges
        '
        Me.Tb_Vg_Lunch_Charges.Enabled = False
        Me.Tb_Vg_Lunch_Charges.Font = New System.Drawing.Font("Modern No. 20", 21.75!)
        Me.Tb_Vg_Lunch_Charges.Location = New System.Drawing.Point(819, 543)
        Me.Tb_Vg_Lunch_Charges.Name = "Tb_Vg_Lunch_Charges"
        Me.Tb_Vg_Lunch_Charges.Size = New System.Drawing.Size(137, 39)
        Me.Tb_Vg_Lunch_Charges.TabIndex = 125
        '
        'Tb_NVg_Starter_Charges
        '
        Me.Tb_NVg_Starter_Charges.Enabled = False
        Me.Tb_NVg_Starter_Charges.Font = New System.Drawing.Font("Modern No. 20", 21.75!)
        Me.Tb_NVg_Starter_Charges.Location = New System.Drawing.Point(657, 594)
        Me.Tb_NVg_Starter_Charges.Name = "Tb_NVg_Starter_Charges"
        Me.Tb_NVg_Starter_Charges.Size = New System.Drawing.Size(137, 39)
        Me.Tb_NVg_Starter_Charges.TabIndex = 124
        '
        'Tb_Vg_Starter_Charges
        '
        Me.Tb_Vg_Starter_Charges.Enabled = False
        Me.Tb_Vg_Starter_Charges.Font = New System.Drawing.Font("Modern No. 20", 21.75!)
        Me.Tb_Vg_Starter_Charges.Location = New System.Drawing.Point(657, 543)
        Me.Tb_Vg_Starter_Charges.Name = "Tb_Vg_Starter_Charges"
        Me.Tb_Vg_Starter_Charges.Size = New System.Drawing.Size(137, 39)
        Me.Tb_Vg_Starter_Charges.TabIndex = 123
        '
        'Tb_Breakfast_Charges
        '
        Me.Tb_Breakfast_Charges.Enabled = False
        Me.Tb_Breakfast_Charges.Font = New System.Drawing.Font("Modern No. 20", 21.75!)
        Me.Tb_Breakfast_Charges.Location = New System.Drawing.Point(308, 544)
        Me.Tb_Breakfast_Charges.Name = "Tb_Breakfast_Charges"
        Me.Tb_Breakfast_Charges.Size = New System.Drawing.Size(159, 39)
        Me.Tb_Breakfast_Charges.TabIndex = 122
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Modern No. 20", 21.75!)
        Me.Label11.Location = New System.Drawing.Point(1309, 491)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 31)
        Me.Label11.TabIndex = 121
        Me.Label11.Text = "Ice-Cream"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 21.75!)
        Me.Label10.Location = New System.Drawing.Point(1145, 491)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 31)
        Me.Label10.TabIndex = 120
        Me.Label10.Text = "Sweet"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 21.75!)
        Me.Label9.Location = New System.Drawing.Point(977, 491)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 31)
        Me.Label9.TabIndex = 119
        Me.Label9.Text = "Dinner"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 21.75!)
        Me.Label8.Location = New System.Drawing.Point(825, 491)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 31)
        Me.Label8.TabIndex = 118
        Me.Label8.Text = "Lunch"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 21.75!)
        Me.Label7.Location = New System.Drawing.Point(662, 491)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 31)
        Me.Label7.TabIndex = 117
        Me.Label7.Text = "Starters"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 21.75!)
        Me.Label6.Location = New System.Drawing.Point(318, 491)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 31)
        Me.Label6.TabIndex = 116
        Me.Label6.Text = "Breakfast"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(418, 594)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(229, 32)
        Me.Label4.TabIndex = 115
        Me.Label4.Text = "Non-Vegetarian"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(483, 548)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 32)
        Me.Label5.TabIndex = 114
        Me.Label5.Text = "Vegetarian"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1448, 551)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 23)
        Me.Label12.TabIndex = 113
        Me.Label12.Text = "Per Plate"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Label13.Location = New System.Drawing.Point(141, 544)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(161, 38)
        Me.Label13.TabIndex = 112
        Me.Label13.Text = "Menu Charges"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1126, 602)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 23)
        Me.Label2.TabIndex = 131
        Me.Label2.Text = "Per Plate"
        '
        'Frm_Update_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1584, 762)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
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
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Btn_Search)
        Me.Controls.Add(Me.Cb_Menu_Type)
        Me.Controls.Add(Me.Lbl_Event_Package)
        Me.Controls.Add(Me.Btn_Browse)
        Me.Controls.Add(Me.Tb_Menu_Category)
        Me.Controls.Add(Me.Pb_Menu_Photo)
        Me.Controls.Add(Me.Btn_Cancel)
        Me.Controls.Add(Me.Btn_Update_Menu)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Tb_Menu_ID)
        Me.Controls.Add(Me.Lbl_Menu_ID)
        Me.Controls.Add(Me.Lbl_Menu_Type)
        Me.Name = "Frm_Update_Menu"
        Me.Text = "Update_Menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Pb_Menu_Photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cb_Menu_Type As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_Event_Package As System.Windows.Forms.Label
    Friend WithEvents Btn_Browse As System.Windows.Forms.Button
    Friend WithEvents Tb_Menu_Category As System.Windows.Forms.TextBox
    Friend WithEvents Pb_Menu_Photo As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents Btn_Update_Menu As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Tb_Menu_ID As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Menu_ID As System.Windows.Forms.Label
    Friend WithEvents Lbl_Menu_Type As System.Windows.Forms.Label
    Friend WithEvents Btn_Search As System.Windows.Forms.Button
    Friend WithEvents Tb_IceCream_Charges As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Sweet_Charges As System.Windows.Forms.TextBox
    Friend WithEvents Tb_NVg_Dinner_Charges As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Vg_Dinner_Charges As System.Windows.Forms.TextBox
    Friend WithEvents Tb_NVg_Lunch_Charges As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Vg_Lunch_Charges As System.Windows.Forms.TextBox
    Friend WithEvents Tb_NVg_Starter_Charges As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Vg_Starter_Charges As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Breakfast_Charges As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
