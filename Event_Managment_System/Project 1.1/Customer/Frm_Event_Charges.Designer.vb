<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Event_Charges
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
        Me.Lbl_Bill_No = New System.Windows.Forms.Label()
        Me.Gb_Event_Detail = New System.Windows.Forms.GroupBox()
        Me.Tb_Decoration_Charges = New System.Windows.Forms.TextBox()
        Me.Tb_Menu_Charges = New System.Windows.Forms.TextBox()
        Me.Lbl_Decoration_Charges = New System.Windows.Forms.Label()
        Me.Lbl_Menu_Charges = New System.Windows.Forms.Label()
        Me.Tb_Venue_Charges = New System.Windows.Forms.TextBox()
        Me.Lbl_Venue_Charges = New System.Windows.Forms.Label()
        Me.Tb_Event_Charges = New System.Windows.Forms.TextBox()
        Me.Lbl_Event_Charges = New System.Windows.Forms.Label()
        Me.Tb_Bill_No = New System.Windows.Forms.TextBox()
        Me.Gb_Event_Charges = New System.Windows.Forms.GroupBox()
        Me.Btn_Refresh = New System.Windows.Forms.Button()
        Me.Btn_Back = New System.Windows.Forms.Button()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.Gb_Total = New System.Windows.Forms.GroupBox()
        Me.Tb_Remaning = New System.Windows.Forms.TextBox()
        Me.Tb_Paid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tb_Total = New System.Windows.Forms.TextBox()
        Me.Lbl_Total = New System.Windows.Forms.Label()
        Me.Gb_Other_Charges = New System.Windows.Forms.GroupBox()
        Me.Tb_Discount = New System.Windows.Forms.TextBox()
        Me.Tb_GST = New System.Windows.Forms.TextBox()
        Me.Lbl_Discount = New System.Windows.Forms.Label()
        Me.Lbl_GST = New System.Windows.Forms.Label()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.Gb_Event_Detail.SuspendLayout()
        Me.Gb_Event_Charges.SuspendLayout()
        Me.Gb_Total.SuspendLayout()
        Me.Gb_Other_Charges.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_Bill_No
        '
        Me.Lbl_Bill_No.AutoSize = True
        Me.Lbl_Bill_No.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Bill_No.Location = New System.Drawing.Point(63, 35)
        Me.Lbl_Bill_No.Name = "Lbl_Bill_No"
        Me.Lbl_Bill_No.Size = New System.Drawing.Size(87, 38)
        Me.Lbl_Bill_No.TabIndex = 18
        Me.Lbl_Bill_No.Text = "Bill No"
        '
        'Gb_Event_Detail
        '
        Me.Gb_Event_Detail.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Gb_Event_Detail.Controls.Add(Me.Tb_Decoration_Charges)
        Me.Gb_Event_Detail.Controls.Add(Me.Tb_Menu_Charges)
        Me.Gb_Event_Detail.Controls.Add(Me.Lbl_Decoration_Charges)
        Me.Gb_Event_Detail.Controls.Add(Me.Lbl_Menu_Charges)
        Me.Gb_Event_Detail.Controls.Add(Me.Tb_Venue_Charges)
        Me.Gb_Event_Detail.Controls.Add(Me.Lbl_Venue_Charges)
        Me.Gb_Event_Detail.Controls.Add(Me.Tb_Event_Charges)
        Me.Gb_Event_Detail.Controls.Add(Me.Lbl_Event_Charges)
        Me.Gb_Event_Detail.Controls.Add(Me.Tb_Bill_No)
        Me.Gb_Event_Detail.Controls.Add(Me.Lbl_Bill_No)
        Me.Gb_Event_Detail.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Gb_Event_Detail.ForeColor = System.Drawing.Color.Black
        Me.Gb_Event_Detail.Location = New System.Drawing.Point(36, 52)
        Me.Gb_Event_Detail.Name = "Gb_Event_Detail"
        Me.Gb_Event_Detail.Size = New System.Drawing.Size(1425, 239)
        Me.Gb_Event_Detail.TabIndex = 0
        Me.Gb_Event_Detail.TabStop = False
        '
        'Tb_Decoration_Charges
        '
        Me.Tb_Decoration_Charges.Enabled = False
        Me.Tb_Decoration_Charges.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Decoration_Charges.Location = New System.Drawing.Point(965, 170)
        Me.Tb_Decoration_Charges.Name = "Tb_Decoration_Charges"
        Me.Tb_Decoration_Charges.Size = New System.Drawing.Size(356, 45)
        Me.Tb_Decoration_Charges.TabIndex = 7
        Me.Tb_Decoration_Charges.Text = "0"
        '
        'Tb_Menu_Charges
        '
        Me.Tb_Menu_Charges.Enabled = False
        Me.Tb_Menu_Charges.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Menu_Charges.Location = New System.Drawing.Point(311, 170)
        Me.Tb_Menu_Charges.Name = "Tb_Menu_Charges"
        Me.Tb_Menu_Charges.Size = New System.Drawing.Size(391, 45)
        Me.Tb_Menu_Charges.TabIndex = 4
        Me.Tb_Menu_Charges.Text = "0"
        '
        'Lbl_Decoration_Charges
        '
        Me.Lbl_Decoration_Charges.AutoSize = True
        Me.Lbl_Decoration_Charges.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Decoration_Charges.Location = New System.Drawing.Point(741, 173)
        Me.Lbl_Decoration_Charges.Name = "Lbl_Decoration_Charges"
        Me.Lbl_Decoration_Charges.Size = New System.Drawing.Size(213, 38)
        Me.Lbl_Decoration_Charges.TabIndex = 41
        Me.Lbl_Decoration_Charges.Text = "Decoration Charges"
        '
        'Lbl_Menu_Charges
        '
        Me.Lbl_Menu_Charges.AutoSize = True
        Me.Lbl_Menu_Charges.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Menu_Charges.Location = New System.Drawing.Point(63, 170)
        Me.Lbl_Menu_Charges.Name = "Lbl_Menu_Charges"
        Me.Lbl_Menu_Charges.Size = New System.Drawing.Size(161, 38)
        Me.Lbl_Menu_Charges.TabIndex = 40
        Me.Lbl_Menu_Charges.Text = "Menu Charges"
        '
        'Tb_Venue_Charges
        '
        Me.Tb_Venue_Charges.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Venue_Charges.Location = New System.Drawing.Point(965, 102)
        Me.Tb_Venue_Charges.Name = "Tb_Venue_Charges"
        Me.Tb_Venue_Charges.Size = New System.Drawing.Size(356, 45)
        Me.Tb_Venue_Charges.TabIndex = 6
        Me.Tb_Venue_Charges.Text = "0"
        '
        'Lbl_Venue_Charges
        '
        Me.Lbl_Venue_Charges.AutoSize = True
        Me.Lbl_Venue_Charges.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Venue_Charges.Location = New System.Drawing.Point(741, 108)
        Me.Lbl_Venue_Charges.Name = "Lbl_Venue_Charges"
        Me.Lbl_Venue_Charges.Size = New System.Drawing.Size(167, 38)
        Me.Lbl_Venue_Charges.TabIndex = 38
        Me.Lbl_Venue_Charges.Text = "Venue Charges"
        '
        'Tb_Event_Charges
        '
        Me.Tb_Event_Charges.Enabled = False
        Me.Tb_Event_Charges.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Event_Charges.Location = New System.Drawing.Point(311, 105)
        Me.Tb_Event_Charges.Name = "Tb_Event_Charges"
        Me.Tb_Event_Charges.Size = New System.Drawing.Size(391, 45)
        Me.Tb_Event_Charges.TabIndex = 3
        Me.Tb_Event_Charges.Text = "0"
        '
        'Lbl_Event_Charges
        '
        Me.Lbl_Event_Charges.AutoSize = True
        Me.Lbl_Event_Charges.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Event_Charges.Location = New System.Drawing.Point(60, 105)
        Me.Lbl_Event_Charges.Name = "Lbl_Event_Charges"
        Me.Lbl_Event_Charges.Size = New System.Drawing.Size(164, 38)
        Me.Lbl_Event_Charges.TabIndex = 35
        Me.Lbl_Event_Charges.Text = "Event Charges"
        '
        'Tb_Bill_No
        '
        Me.Tb_Bill_No.Enabled = False
        Me.Tb_Bill_No.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Bill_No.Location = New System.Drawing.Point(311, 28)
        Me.Tb_Bill_No.Name = "Tb_Bill_No"
        Me.Tb_Bill_No.Size = New System.Drawing.Size(391, 45)
        Me.Tb_Bill_No.TabIndex = 1
        '
        'Gb_Event_Charges
        '
        Me.Gb_Event_Charges.BackColor = System.Drawing.Color.Transparent
        Me.Gb_Event_Charges.Controls.Add(Me.Btn_Refresh)
        Me.Gb_Event_Charges.Controls.Add(Me.Btn_Back)
        Me.Gb_Event_Charges.Controls.Add(Me.Btn_Save)
        Me.Gb_Event_Charges.Controls.Add(Me.Gb_Total)
        Me.Gb_Event_Charges.Controls.Add(Me.Gb_Other_Charges)
        Me.Gb_Event_Charges.Controls.Add(Me.Btn_Cancel)
        Me.Gb_Event_Charges.Controls.Add(Me.Gb_Event_Detail)
        Me.Gb_Event_Charges.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Gb_Event_Charges.ForeColor = System.Drawing.Color.White
        Me.Gb_Event_Charges.Location = New System.Drawing.Point(26, 11)
        Me.Gb_Event_Charges.Name = "Gb_Event_Charges"
        Me.Gb_Event_Charges.Size = New System.Drawing.Size(1532, 739)
        Me.Gb_Event_Charges.TabIndex = 39
        Me.Gb_Event_Charges.TabStop = False
        Me.Gb_Event_Charges.Text = "Event Charges"
        '
        'Btn_Refresh
        '
        Me.Btn_Refresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Refresh.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Btn_Refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Refresh.Image = Global.WindowsApplication1.My.Resources.Resources.Apps_Rotate_Right_icon
        Me.Btn_Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Refresh.Location = New System.Drawing.Point(529, 670)
        Me.Btn_Refresh.Name = "Btn_Refresh"
        Me.Btn_Refresh.Size = New System.Drawing.Size(189, 51)
        Me.Btn_Refresh.TabIndex = 38
        Me.Btn_Refresh.Text = "Refresh"
        Me.Btn_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Refresh.UseVisualStyleBackColor = False
        '
        'Btn_Back
        '
        Me.Btn_Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Back.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Btn_Back.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_Back.Image = Global.WindowsApplication1.My.Resources.Resources.Apps_Go_Left_icon__1_3
        Me.Btn_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Back.Location = New System.Drawing.Point(370, 670)
        Me.Btn_Back.Name = "Btn_Back"
        Me.Btn_Back.Size = New System.Drawing.Size(153, 51)
        Me.Btn_Back.TabIndex = 14
        Me.Btn_Back.Text = "    Back"
        Me.Btn_Back.UseVisualStyleBackColor = False
        '
        'Btn_Save
        '
        Me.Btn_Save.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Save.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Btn_Save.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_Save.Image = Global.WindowsApplication1.My.Resources.Resources.add_icon5
        Me.Btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Save.Location = New System.Drawing.Point(915, 670)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(153, 51)
        Me.Btn_Save.TabIndex = 15
        Me.Btn_Save.Text = "Save"
        Me.Btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Save.UseVisualStyleBackColor = False
        '
        'Gb_Total
        '
        Me.Gb_Total.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Gb_Total.Controls.Add(Me.Tb_Remaning)
        Me.Gb_Total.Controls.Add(Me.Tb_Paid)
        Me.Gb_Total.Controls.Add(Me.Label2)
        Me.Gb_Total.Controls.Add(Me.Label1)
        Me.Gb_Total.Controls.Add(Me.Tb_Total)
        Me.Gb_Total.Controls.Add(Me.Lbl_Total)
        Me.Gb_Total.Font = New System.Drawing.Font("Rockwell Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_Total.ForeColor = System.Drawing.Color.Black
        Me.Gb_Total.Location = New System.Drawing.Point(36, 458)
        Me.Gb_Total.Name = "Gb_Total"
        Me.Gb_Total.Size = New System.Drawing.Size(1425, 177)
        Me.Gb_Total.TabIndex = 3
        Me.Gb_Total.TabStop = False
        Me.Gb_Total.Text = "#Total"
        '
        'Tb_Remaning
        '
        Me.Tb_Remaning.Enabled = False
        Me.Tb_Remaning.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Remaning.Location = New System.Drawing.Point(894, 110)
        Me.Tb_Remaning.Name = "Tb_Remaning"
        Me.Tb_Remaning.Size = New System.Drawing.Size(356, 45)
        Me.Tb_Remaning.TabIndex = 12
        Me.Tb_Remaning.Text = "0"
        '
        'Tb_Paid
        '
        Me.Tb_Paid.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Paid.Location = New System.Drawing.Point(894, 47)
        Me.Tb_Paid.Name = "Tb_Paid"
        Me.Tb_Paid.Size = New System.Drawing.Size(356, 45)
        Me.Tb_Paid.TabIndex = 11
        Me.Tb_Paid.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Label2.Location = New System.Drawing.Point(741, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 38)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Remaning"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Label1.Location = New System.Drawing.Point(741, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 38)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Paid"
        '
        'Tb_Total
        '
        Me.Tb_Total.Enabled = False
        Me.Tb_Total.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Total.Location = New System.Drawing.Point(311, 54)
        Me.Tb_Total.Name = "Tb_Total"
        Me.Tb_Total.Size = New System.Drawing.Size(391, 45)
        Me.Tb_Total.TabIndex = 10
        Me.Tb_Total.Text = "0"
        '
        'Lbl_Total
        '
        Me.Lbl_Total.AutoSize = True
        Me.Lbl_Total.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Total.Location = New System.Drawing.Point(156, 54)
        Me.Lbl_Total.Name = "Lbl_Total"
        Me.Lbl_Total.Size = New System.Drawing.Size(68, 38)
        Me.Lbl_Total.TabIndex = 42
        Me.Lbl_Total.Text = "Total"
        '
        'Gb_Other_Charges
        '
        Me.Gb_Other_Charges.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Gb_Other_Charges.Controls.Add(Me.Tb_Discount)
        Me.Gb_Other_Charges.Controls.Add(Me.Tb_GST)
        Me.Gb_Other_Charges.Controls.Add(Me.Lbl_Discount)
        Me.Gb_Other_Charges.Controls.Add(Me.Lbl_GST)
        Me.Gb_Other_Charges.Font = New System.Drawing.Font("Rockwell Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_Other_Charges.ForeColor = System.Drawing.Color.Black
        Me.Gb_Other_Charges.Location = New System.Drawing.Point(36, 323)
        Me.Gb_Other_Charges.Name = "Gb_Other_Charges"
        Me.Gb_Other_Charges.Size = New System.Drawing.Size(1425, 109)
        Me.Gb_Other_Charges.TabIndex = 2
        Me.Gb_Other_Charges.TabStop = False
        Me.Gb_Other_Charges.Text = "#Other Charges"
        '
        'Tb_Discount
        '
        Me.Tb_Discount.Enabled = False
        Me.Tb_Discount.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Discount.Location = New System.Drawing.Point(894, 42)
        Me.Tb_Discount.MaxLength = 2
        Me.Tb_Discount.Name = "Tb_Discount"
        Me.Tb_Discount.Size = New System.Drawing.Size(356, 45)
        Me.Tb_Discount.TabIndex = 9
        Me.Tb_Discount.Text = "0"
        '
        'Tb_GST
        '
        Me.Tb_GST.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_GST.Location = New System.Drawing.Point(311, 42)
        Me.Tb_GST.MaxLength = 3
        Me.Tb_GST.Name = "Tb_GST"
        Me.Tb_GST.Size = New System.Drawing.Size(391, 45)
        Me.Tb_GST.TabIndex = 8
        Me.Tb_GST.Text = "0"
        '
        'Lbl_Discount
        '
        Me.Lbl_Discount.AutoSize = True
        Me.Lbl_Discount.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Discount.Location = New System.Drawing.Point(741, 49)
        Me.Lbl_Discount.Name = "Lbl_Discount"
        Me.Lbl_Discount.Size = New System.Drawing.Size(102, 38)
        Me.Lbl_Discount.TabIndex = 42
        Me.Lbl_Discount.Text = "Discount"
        '
        'Lbl_GST
        '
        Me.Lbl_GST.AutoSize = True
        Me.Lbl_GST.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_GST.Location = New System.Drawing.Point(156, 42)
        Me.Lbl_GST.Name = "Lbl_GST"
        Me.Lbl_GST.Size = New System.Drawing.Size(56, 38)
        Me.Lbl_GST.TabIndex = 41
        Me.Lbl_GST.Text = "GST"
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cancel.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Btn_Cancel.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_Cancel.Image = Global.WindowsApplication1.My.Resources.Resources.close_icon4
        Me.Btn_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancel.Location = New System.Drawing.Point(724, 670)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(187, 51)
        Me.Btn_Cancel.TabIndex = 13
        Me.Btn_Cancel.Text = "    Cancel"
        Me.Btn_Cancel.UseVisualStyleBackColor = False
        '
        'Frm_Event_Charges
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.shubhaarambh_event3
        Me.ClientSize = New System.Drawing.Size(1584, 762)
        Me.ControlBox = False
        Me.Controls.Add(Me.Gb_Event_Charges)
        Me.Name = "Frm_Event_Charges"
        Me.Text = "Event Charges"
        Me.Gb_Event_Detail.ResumeLayout(False)
        Me.Gb_Event_Detail.PerformLayout()
        Me.Gb_Event_Charges.ResumeLayout(False)
        Me.Gb_Total.ResumeLayout(False)
        Me.Gb_Total.PerformLayout()
        Me.Gb_Other_Charges.ResumeLayout(False)
        Me.Gb_Other_Charges.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_Save As System.Windows.Forms.Button
    Friend WithEvents Lbl_Bill_No As System.Windows.Forms.Label
    Friend WithEvents Gb_Event_Detail As System.Windows.Forms.GroupBox
    Friend WithEvents Gb_Event_Charges As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents Tb_Event_Charges As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Event_Charges As System.Windows.Forms.Label
    Friend WithEvents Tb_Bill_No As System.Windows.Forms.TextBox
    Friend WithEvents Gb_Other_Charges As System.Windows.Forms.GroupBox
    Friend WithEvents Tb_Decoration_Charges As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Menu_Charges As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Decoration_Charges As System.Windows.Forms.Label
    Friend WithEvents Lbl_Menu_Charges As System.Windows.Forms.Label
    Friend WithEvents Tb_Venue_Charges As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Venue_Charges As System.Windows.Forms.Label
    Friend WithEvents Gb_Total As System.Windows.Forms.GroupBox
    Friend WithEvents Tb_Total As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Total As System.Windows.Forms.Label
    Friend WithEvents Tb_Discount As System.Windows.Forms.TextBox
    Friend WithEvents Tb_GST As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Discount As System.Windows.Forms.Label
    Friend WithEvents Lbl_GST As System.Windows.Forms.Label
    Friend WithEvents Tb_Remaning As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Paid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_Back As System.Windows.Forms.Button
    Friend WithEvents Btn_Refresh As System.Windows.Forms.Button
End Class
