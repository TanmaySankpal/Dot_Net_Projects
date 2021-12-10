<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_view_Single_Enquiry
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
        Me.Lbl_Event_Type = New System.Windows.Forms.Label()
        Me.Lbl_Mobile_Number = New System.Windows.Forms.Label()
        Me.Lbl_Customer_Name = New System.Windows.Forms.Label()
        Me.Lbl_Enquiry_ID = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lbl_Add_Enquiry = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Cb_Event_Package = New System.Windows.Forms.ComboBox()
        Me.Cb_Event_Type = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lbl_Event_Name = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_Event_Date = New System.Windows.Forms.Label()
        Me.Lbl_Mob_No_2 = New System.Windows.Forms.Label()
        Me.Lbl_Mob_No_1 = New System.Windows.Forms.Label()
        Me.Tb_Adress = New System.Windows.Forms.TextBox()
        Me.Tb_Mobile_Num_2 = New System.Windows.Forms.TextBox()
        Me.Tb_Mobile_Num_1 = New System.Windows.Forms.TextBox()
        Me.Tb_Customer_ID = New System.Windows.Forms.TextBox()
        Me.Tb_Customer_Name = New System.Windows.Forms.TextBox()
        Me.Btn_Update = New System.Windows.Forms.Button()
        Me.Btn_Refresh = New System.Windows.Forms.Button()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_Event_Type
        '
        Me.Lbl_Event_Type.AutoSize = True
        Me.Lbl_Event_Type.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Event_Type.Location = New System.Drawing.Point(281, 494)
        Me.Lbl_Event_Type.Name = "Lbl_Event_Type"
        Me.Lbl_Event_Type.Size = New System.Drawing.Size(168, 38)
        Me.Lbl_Event_Type.TabIndex = 65
        Me.Lbl_Event_Type.Text = "Event Package"
        '
        'Lbl_Mobile_Number
        '
        Me.Lbl_Mobile_Number.AutoSize = True
        Me.Lbl_Mobile_Number.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Mobile_Number.Location = New System.Drawing.Point(281, 339)
        Me.Lbl_Mobile_Number.Name = "Lbl_Mobile_Number"
        Me.Lbl_Mobile_Number.Size = New System.Drawing.Size(171, 38)
        Me.Lbl_Mobile_Number.TabIndex = 59
        Me.Lbl_Mobile_Number.Text = "Mobile Number"
        '
        'Lbl_Customer_Name
        '
        Me.Lbl_Customer_Name.AutoSize = True
        Me.Lbl_Customer_Name.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Customer_Name.Location = New System.Drawing.Point(281, 199)
        Me.Lbl_Customer_Name.Name = "Lbl_Customer_Name"
        Me.Lbl_Customer_Name.Size = New System.Drawing.Size(176, 38)
        Me.Lbl_Customer_Name.TabIndex = 58
        Me.Lbl_Customer_Name.Text = "Customer Name"
        '
        'Lbl_Enquiry_ID
        '
        Me.Lbl_Enquiry_ID.AutoSize = True
        Me.Lbl_Enquiry_ID.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Enquiry_ID.Location = New System.Drawing.Point(281, 135)
        Me.Lbl_Enquiry_ID.Name = "Lbl_Enquiry_ID"
        Me.Lbl_Enquiry_ID.Size = New System.Drawing.Size(128, 38)
        Me.Lbl_Enquiry_ID.TabIndex = 57
        Me.Lbl_Enquiry_ID.Text = "Enquiry ID"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Lbl_Add_Enquiry)
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(-82, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1749, 119)
        Me.Panel1.TabIndex = 56
        '
        'Lbl_Add_Enquiry
        '
        Me.Lbl_Add_Enquiry.AutoSize = True
        Me.Lbl_Add_Enquiry.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Lbl_Add_Enquiry.Font = New System.Drawing.Font("Rockwell", 72.0!)
        Me.Lbl_Add_Enquiry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Lbl_Add_Enquiry.Location = New System.Drawing.Point(490, 0)
        Me.Lbl_Add_Enquiry.Name = "Lbl_Add_Enquiry"
        Me.Lbl_Add_Enquiry.Size = New System.Drawing.Size(969, 106)
        Me.Lbl_Add_Enquiry.TabIndex = 0
        Me.Lbl_Add_Enquiry.Text = "View Single Enquiry "
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.RichTextBox1.Location = New System.Drawing.Point(6, 23)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(368, 187)
        Me.RichTextBox1.TabIndex = 10
        Me.RichTextBox1.Text = ""
        '
        'Cb_Event_Package
        '
        Me.Cb_Event_Package.Enabled = False
        Me.Cb_Event_Package.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Cb_Event_Package.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Cb_Event_Package.FormattingEnabled = True
        Me.Cb_Event_Package.Location = New System.Drawing.Point(523, 490)
        Me.Cb_Event_Package.MaxLength = 30
        Me.Cb_Event_Package.Name = "Cb_Event_Package"
        Me.Cb_Event_Package.Size = New System.Drawing.Size(391, 46)
        Me.Cb_Event_Package.TabIndex = 51
        '
        'Cb_Event_Type
        '
        Me.Cb_Event_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Event_Type.Enabled = False
        Me.Cb_Event_Type.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Cb_Event_Type.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Cb_Event_Type.FormattingEnabled = True
        Me.Cb_Event_Type.Items.AddRange(New Object() {"Birthday ", "Marriage ", "Party"})
        Me.Cb_Event_Type.Location = New System.Drawing.Point(523, 426)
        Me.Cb_Event_Type.MaxLength = 30
        Me.Cb_Event_Type.Name = "Cb_Event_Type"
        Me.Cb_Event_Type.Size = New System.Drawing.Size(391, 46)
        Me.Cb_Event_Type.TabIndex = 50
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(994, 403)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 220)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Requirements/Suggetions"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Label2.Location = New System.Drawing.Point(281, 268)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 38)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Address"
        '
        'Lbl_Event_Name
        '
        Me.Lbl_Event_Name.AutoSize = True
        Me.Lbl_Event_Name.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Event_Name.Location = New System.Drawing.Point(281, 426)
        Me.Lbl_Event_Name.Name = "Lbl_Event_Name"
        Me.Lbl_Event_Name.Size = New System.Drawing.Size(135, 38)
        Me.Lbl_Event_Name.TabIndex = 64
        Me.Lbl_Event_Name.Text = "Event Type"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.DateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.DateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(529, 576)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(393, 45)
        Me.DateTimePicker1.TabIndex = 52
        '
        'Lbl_Event_Date
        '
        Me.Lbl_Event_Date.AutoSize = True
        Me.Lbl_Event_Date.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Event_Date.Location = New System.Drawing.Point(281, 585)
        Me.Lbl_Event_Date.Name = "Lbl_Event_Date"
        Me.Lbl_Event_Date.Size = New System.Drawing.Size(130, 38)
        Me.Lbl_Event_Date.TabIndex = 63
        Me.Lbl_Event_Date.Text = "Event Date"
        '
        'Lbl_Mob_No_2
        '
        Me.Lbl_Mob_No_2.AutoSize = True
        Me.Lbl_Mob_No_2.Enabled = False
        Me.Lbl_Mob_No_2.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Mob_No_2.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Mob_No_2.Location = New System.Drawing.Point(987, 344)
        Me.Lbl_Mob_No_2.Name = "Lbl_Mob_No_2"
        Me.Lbl_Mob_No_2.Size = New System.Drawing.Size(34, 38)
        Me.Lbl_Mob_No_2.TabIndex = 62
        Me.Lbl_Mob_No_2.Text = "2."
        '
        'Lbl_Mob_No_1
        '
        Me.Lbl_Mob_No_1.AutoSize = True
        Me.Lbl_Mob_No_1.Enabled = False
        Me.Lbl_Mob_No_1.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Mob_No_1.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Mob_No_1.Location = New System.Drawing.Point(536, 344)
        Me.Lbl_Mob_No_1.Name = "Lbl_Mob_No_1"
        Me.Lbl_Mob_No_1.Size = New System.Drawing.Size(34, 38)
        Me.Lbl_Mob_No_1.TabIndex = 61
        Me.Lbl_Mob_No_1.Text = "1."
        '
        'Tb_Adress
        '
        Me.Tb_Adress.Enabled = False
        Me.Tb_Adress.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Adress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Tb_Adress.Location = New System.Drawing.Point(527, 263)
        Me.Tb_Adress.MaxLength = 50
        Me.Tb_Adress.Name = "Tb_Adress"
        Me.Tb_Adress.Size = New System.Drawing.Size(847, 45)
        Me.Tb_Adress.TabIndex = 47
        '
        'Tb_Mobile_Num_2
        '
        Me.Tb_Mobile_Num_2.Enabled = False
        Me.Tb_Mobile_Num_2.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Mobile_Num_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Tb_Mobile_Num_2.Location = New System.Drawing.Point(1027, 339)
        Me.Tb_Mobile_Num_2.MaxLength = 10
        Me.Tb_Mobile_Num_2.Name = "Tb_Mobile_Num_2"
        Me.Tb_Mobile_Num_2.Size = New System.Drawing.Size(349, 45)
        Me.Tb_Mobile_Num_2.TabIndex = 49
        '
        'Tb_Mobile_Num_1
        '
        Me.Tb_Mobile_Num_1.Enabled = False
        Me.Tb_Mobile_Num_1.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Mobile_Num_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Tb_Mobile_Num_1.Location = New System.Drawing.Point(594, 339)
        Me.Tb_Mobile_Num_1.MaxLength = 10
        Me.Tb_Mobile_Num_1.Name = "Tb_Mobile_Num_1"
        Me.Tb_Mobile_Num_1.Size = New System.Drawing.Size(328, 45)
        Me.Tb_Mobile_Num_1.TabIndex = 48
        '
        'Tb_Customer_ID
        '
        Me.Tb_Customer_ID.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Customer_ID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Tb_Customer_ID.Location = New System.Drawing.Point(529, 130)
        Me.Tb_Customer_ID.MaxLength = 5
        Me.Tb_Customer_ID.Name = "Tb_Customer_ID"
        Me.Tb_Customer_ID.Size = New System.Drawing.Size(393, 45)
        Me.Tb_Customer_ID.TabIndex = 45
        '
        'Tb_Customer_Name
        '
        Me.Tb_Customer_Name.Enabled = False
        Me.Tb_Customer_Name.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Customer_Name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Tb_Customer_Name.Location = New System.Drawing.Point(529, 199)
        Me.Tb_Customer_Name.MaxLength = 50
        Me.Tb_Customer_Name.Name = "Tb_Customer_Name"
        Me.Tb_Customer_Name.Size = New System.Drawing.Size(847, 45)
        Me.Tb_Customer_Name.TabIndex = 46
        '
        'Btn_Update
        '
        Me.Btn_Update.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Btn_Update.Enabled = False
        Me.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Update.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Btn_Update.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_Update.Image = Global.WindowsApplication1.My.Resources.Resources.add_icon6
        Me.Btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Update.Location = New System.Drawing.Point(927, 682)
        Me.Btn_Update.Name = "Btn_Update"
        Me.Btn_Update.Size = New System.Drawing.Size(200, 54)
        Me.Btn_Update.TabIndex = 84
        Me.Btn_Update.Text = "Update"
        Me.Btn_Update.UseVisualStyleBackColor = False
        '
        'Btn_Refresh
        '
        Me.Btn_Refresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Btn_Refresh.Enabled = False
        Me.Btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Refresh.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Btn_Refresh.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_Refresh.Image = Global.WindowsApplication1.My.Resources.Resources.update_icon
        Me.Btn_Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Refresh.Location = New System.Drawing.Point(715, 682)
        Me.Btn_Refresh.Name = "Btn_Refresh"
        Me.Btn_Refresh.Size = New System.Drawing.Size(199, 57)
        Me.Btn_Refresh.TabIndex = 54
        Me.Btn_Refresh.Text = "Refresh"
        Me.Btn_Refresh.UseVisualStyleBackColor = False
        '
        'Btn_Search
        '
        Me.Btn_Search.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Search.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Btn_Search.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_Search.Image = Global.WindowsApplication1.My.Resources.Resources.Knob_Search_icon2
        Me.Btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Search.Location = New System.Drawing.Point(947, 128)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(144, 48)
        Me.Btn_Search.TabIndex = 55
        Me.Btn_Search.Text = "Search"
        Me.Btn_Search.UseVisualStyleBackColor = False
        '
        'Frm_view_Single_Enquiry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1584, 762)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_Update)
        Me.Controls.Add(Me.Lbl_Event_Type)
        Me.Controls.Add(Me.Lbl_Mobile_Number)
        Me.Controls.Add(Me.Lbl_Customer_Name)
        Me.Controls.Add(Me.Lbl_Enquiry_ID)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Cb_Event_Package)
        Me.Controls.Add(Me.Cb_Event_Type)
        Me.Controls.Add(Me.Btn_Refresh)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lbl_Event_Name)
        Me.Controls.Add(Me.Btn_Search)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Lbl_Event_Date)
        Me.Controls.Add(Me.Lbl_Mob_No_2)
        Me.Controls.Add(Me.Lbl_Mob_No_1)
        Me.Controls.Add(Me.Tb_Adress)
        Me.Controls.Add(Me.Tb_Mobile_Num_2)
        Me.Controls.Add(Me.Tb_Mobile_Num_1)
        Me.Controls.Add(Me.Tb_Customer_ID)
        Me.Controls.Add(Me.Tb_Customer_Name)
        Me.Name = "Frm_view_Single_Enquiry"
        Me.Text = "view_Single_Enquiry"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Event_Type As System.Windows.Forms.Label
    Friend WithEvents Lbl_Mobile_Number As System.Windows.Forms.Label
    Friend WithEvents Lbl_Customer_Name As System.Windows.Forms.Label
    Friend WithEvents Lbl_Enquiry_ID As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Lbl_Add_Enquiry As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Cb_Event_Package As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_Event_Type As System.Windows.Forms.ComboBox
    Friend WithEvents Btn_Refresh As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Event_Name As System.Windows.Forms.Label
    Friend WithEvents Btn_Search As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_Event_Date As System.Windows.Forms.Label
    Friend WithEvents Lbl_Mob_No_2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Mob_No_1 As System.Windows.Forms.Label
    Friend WithEvents Tb_Adress As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Mobile_Num_2 As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Mobile_Num_1 As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Customer_ID As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Customer_Name As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Update As System.Windows.Forms.Button
End Class
