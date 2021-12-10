<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Add_Enquiry
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
        Me.Lbl_Add_Enquiry = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lbl_Mobile_Number = New System.Windows.Forms.Label()
        Me.Lbl_Customer_Name = New System.Windows.Forms.Label()
        Me.Lbl_Enquiry_ID = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_Refresh = New System.Windows.Forms.Button()
        Me.Btn_Add_Enquiry = New System.Windows.Forms.Button()
        Me.Cb_Event_Package = New System.Windows.Forms.ComboBox()
        Me.Cb_Event_Type = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_Event_Type
        '
        Me.Lbl_Event_Type.AutoSize = True
        Me.Lbl_Event_Type.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Event_Type.Location = New System.Drawing.Point(281, 505)
        Me.Lbl_Event_Type.Name = "Lbl_Event_Type"
        Me.Lbl_Event_Type.Size = New System.Drawing.Size(168, 38)
        Me.Lbl_Event_Type.TabIndex = 44
        Me.Lbl_Event_Type.Text = "Event Package"
        '
        'Lbl_Event_Name
        '
        Me.Lbl_Event_Name.AutoSize = True
        Me.Lbl_Event_Name.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Event_Name.Location = New System.Drawing.Point(281, 437)
        Me.Lbl_Event_Name.Name = "Lbl_Event_Name"
        Me.Lbl_Event_Name.Size = New System.Drawing.Size(135, 38)
        Me.Lbl_Event_Name.TabIndex = 42
        Me.Lbl_Event_Name.Text = "Event Type"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.DateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.DateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.DateTimePicker1.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(529, 587)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(393, 45)
        Me.DateTimePicker1.TabIndex = 8
        '
        'Lbl_Event_Date
        '
        Me.Lbl_Event_Date.AutoSize = True
        Me.Lbl_Event_Date.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Event_Date.Location = New System.Drawing.Point(281, 596)
        Me.Lbl_Event_Date.Name = "Lbl_Event_Date"
        Me.Lbl_Event_Date.Size = New System.Drawing.Size(130, 38)
        Me.Lbl_Event_Date.TabIndex = 38
        Me.Lbl_Event_Date.Text = "Event Date"
        '
        'Lbl_Mob_No_2
        '
        Me.Lbl_Mob_No_2.AutoSize = True
        Me.Lbl_Mob_No_2.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Mob_No_2.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Mob_No_2.Location = New System.Drawing.Point(987, 355)
        Me.Lbl_Mob_No_2.Name = "Lbl_Mob_No_2"
        Me.Lbl_Mob_No_2.Size = New System.Drawing.Size(34, 38)
        Me.Lbl_Mob_No_2.TabIndex = 37
        Me.Lbl_Mob_No_2.Text = "2."
        '
        'Lbl_Mob_No_1
        '
        Me.Lbl_Mob_No_1.AutoSize = True
        Me.Lbl_Mob_No_1.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Mob_No_1.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Mob_No_1.Location = New System.Drawing.Point(536, 355)
        Me.Lbl_Mob_No_1.Name = "Lbl_Mob_No_1"
        Me.Lbl_Mob_No_1.Size = New System.Drawing.Size(34, 38)
        Me.Lbl_Mob_No_1.TabIndex = 36
        Me.Lbl_Mob_No_1.Text = "1."
        '
        'Tb_Adress
        '
        Me.Tb_Adress.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Adress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Tb_Adress.Location = New System.Drawing.Point(527, 274)
        Me.Tb_Adress.MaxLength = 50
        Me.Tb_Adress.Name = "Tb_Adress"
        Me.Tb_Adress.Size = New System.Drawing.Size(847, 45)
        Me.Tb_Adress.TabIndex = 3
        '
        'Tb_Mobile_Num_2
        '
        Me.Tb_Mobile_Num_2.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Mobile_Num_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Tb_Mobile_Num_2.Location = New System.Drawing.Point(1027, 350)
        Me.Tb_Mobile_Num_2.MaxLength = 10
        Me.Tb_Mobile_Num_2.Name = "Tb_Mobile_Num_2"
        Me.Tb_Mobile_Num_2.Size = New System.Drawing.Size(349, 45)
        Me.Tb_Mobile_Num_2.TabIndex = 5
        '
        'Tb_Mobile_Num_1
        '
        Me.Tb_Mobile_Num_1.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Mobile_Num_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Tb_Mobile_Num_1.Location = New System.Drawing.Point(594, 350)
        Me.Tb_Mobile_Num_1.MaxLength = 10
        Me.Tb_Mobile_Num_1.Name = "Tb_Mobile_Num_1"
        Me.Tb_Mobile_Num_1.Size = New System.Drawing.Size(328, 45)
        Me.Tb_Mobile_Num_1.TabIndex = 4
        '
        'Tb_Customer_ID
        '
        Me.Tb_Customer_ID.Enabled = False
        Me.Tb_Customer_ID.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Customer_ID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Tb_Customer_ID.Location = New System.Drawing.Point(529, 141)
        Me.Tb_Customer_ID.MaxLength = 5
        Me.Tb_Customer_ID.Name = "Tb_Customer_ID"
        Me.Tb_Customer_ID.Size = New System.Drawing.Size(393, 45)
        Me.Tb_Customer_ID.TabIndex = 1
        '
        'Tb_Customer_Name
        '
        Me.Tb_Customer_Name.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Customer_Name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Tb_Customer_Name.Location = New System.Drawing.Point(529, 210)
        Me.Tb_Customer_Name.MaxLength = 50
        Me.Tb_Customer_Name.Name = "Tb_Customer_Name"
        Me.Tb_Customer_Name.Size = New System.Drawing.Size(847, 45)
        Me.Tb_Customer_Name.TabIndex = 2
        '
        'Lbl_Add_Enquiry
        '
        Me.Lbl_Add_Enquiry.AutoSize = True
        Me.Lbl_Add_Enquiry.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Lbl_Add_Enquiry.Font = New System.Drawing.Font("Rockwell", 72.0!)
        Me.Lbl_Add_Enquiry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Lbl_Add_Enquiry.Location = New System.Drawing.Point(490, 0)
        Me.Lbl_Add_Enquiry.Name = "Lbl_Add_Enquiry"
        Me.Lbl_Add_Enquiry.Size = New System.Drawing.Size(852, 106)
        Me.Lbl_Add_Enquiry.TabIndex = 0
        Me.Lbl_Add_Enquiry.Text = "Add New Enquiry "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Label2.Location = New System.Drawing.Point(281, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 38)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Address"
        '
        'Lbl_Mobile_Number
        '
        Me.Lbl_Mobile_Number.AutoSize = True
        Me.Lbl_Mobile_Number.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Mobile_Number.Location = New System.Drawing.Point(281, 350)
        Me.Lbl_Mobile_Number.Name = "Lbl_Mobile_Number"
        Me.Lbl_Mobile_Number.Size = New System.Drawing.Size(171, 38)
        Me.Lbl_Mobile_Number.TabIndex = 32
        Me.Lbl_Mobile_Number.Text = "Mobile Number"
        '
        'Lbl_Customer_Name
        '
        Me.Lbl_Customer_Name.AutoSize = True
        Me.Lbl_Customer_Name.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Customer_Name.Location = New System.Drawing.Point(281, 210)
        Me.Lbl_Customer_Name.Name = "Lbl_Customer_Name"
        Me.Lbl_Customer_Name.Size = New System.Drawing.Size(176, 38)
        Me.Lbl_Customer_Name.TabIndex = 30
        Me.Lbl_Customer_Name.Text = "Customer Name"
        '
        'Lbl_Enquiry_ID
        '
        Me.Lbl_Enquiry_ID.AutoSize = True
        Me.Lbl_Enquiry_ID.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Enquiry_ID.Location = New System.Drawing.Point(281, 146)
        Me.Lbl_Enquiry_ID.Name = "Lbl_Enquiry_ID"
        Me.Lbl_Enquiry_ID.Size = New System.Drawing.Size(128, 38)
        Me.Lbl_Enquiry_ID.TabIndex = 28
        Me.Lbl_Enquiry_ID.Text = "Enquiry ID"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Lbl_Add_Enquiry)
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(-82, 14)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1749, 119)
        Me.Panel1.TabIndex = 26
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(994, 414)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 220)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Requirements/Suggetions"
        '
        'Btn_Refresh
        '
        Me.Btn_Refresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Refresh.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Btn_Refresh.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_Refresh.Image = Global.WindowsApplication1.My.Resources.Resources.update_icon
        Me.Btn_Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Refresh.Location = New System.Drawing.Point(638, 693)
        Me.Btn_Refresh.Name = "Btn_Refresh"
        Me.Btn_Refresh.Size = New System.Drawing.Size(199, 57)
        Me.Btn_Refresh.TabIndex = 11
        Me.Btn_Refresh.Text = "Refresh"
        Me.Btn_Refresh.UseVisualStyleBackColor = False
        '
        'Btn_Add_Enquiry
        '
        Me.Btn_Add_Enquiry.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Btn_Add_Enquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Add_Enquiry.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Btn_Add_Enquiry.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_Add_Enquiry.Image = Global.WindowsApplication1.My.Resources.Resources.add_icon2
        Me.Btn_Add_Enquiry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Add_Enquiry.Location = New System.Drawing.Point(857, 693)
        Me.Btn_Add_Enquiry.Name = "Btn_Add_Enquiry"
        Me.Btn_Add_Enquiry.Size = New System.Drawing.Size(224, 54)
        Me.Btn_Add_Enquiry.TabIndex = 12
        Me.Btn_Add_Enquiry.Text = "   Add Enquiry"
        Me.Btn_Add_Enquiry.UseVisualStyleBackColor = False
        '
        'Cb_Event_Package
        '
        Me.Cb_Event_Package.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Event_Package.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Cb_Event_Package.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Cb_Event_Package.FormattingEnabled = True
        Me.Cb_Event_Package.Location = New System.Drawing.Point(523, 501)
        Me.Cb_Event_Package.MaxLength = 30
        Me.Cb_Event_Package.Name = "Cb_Event_Package"
        Me.Cb_Event_Package.Size = New System.Drawing.Size(391, 46)
        Me.Cb_Event_Package.TabIndex = 7
        '
        'Cb_Event_Type
        '
        Me.Cb_Event_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Event_Type.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Cb_Event_Type.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Cb_Event_Type.FormattingEnabled = True
        Me.Cb_Event_Type.Items.AddRange(New Object() {"Birthday ", "Marriage ", "Party"})
        Me.Cb_Event_Type.Location = New System.Drawing.Point(523, 437)
        Me.Cb_Event_Type.MaxLength = 30
        Me.Cb_Event_Type.Name = "Cb_Event_Type"
        Me.Cb_Event_Type.Size = New System.Drawing.Size(391, 46)
        Me.Cb_Event_Type.TabIndex = 6
        '
        'Frm_Add_Enquiry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.MZH2
        Me.ClientSize = New System.Drawing.Size(1584, 762)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cb_Event_Package)
        Me.Controls.Add(Me.Cb_Event_Type)
        Me.Controls.Add(Me.Btn_Refresh)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Lbl_Event_Type)
        Me.Controls.Add(Me.Lbl_Event_Name)
        Me.Controls.Add(Me.Btn_Add_Enquiry)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Lbl_Event_Date)
        Me.Controls.Add(Me.Lbl_Mob_No_2)
        Me.Controls.Add(Me.Lbl_Mob_No_1)
        Me.Controls.Add(Me.Tb_Adress)
        Me.Controls.Add(Me.Tb_Mobile_Num_2)
        Me.Controls.Add(Me.Tb_Mobile_Num_1)
        Me.Controls.Add(Me.Tb_Customer_ID)
        Me.Controls.Add(Me.Tb_Customer_Name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lbl_Mobile_Number)
        Me.Controls.Add(Me.Lbl_Customer_Name)
        Me.Controls.Add(Me.Lbl_Enquiry_ID)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_Add_Enquiry"
        Me.Text = "Add Enquiry"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Event_Type As System.Windows.Forms.Label
    Friend WithEvents Lbl_Event_Name As System.Windows.Forms.Label
    Friend WithEvents Btn_Add_Enquiry As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_Event_Date As System.Windows.Forms.Label
    Friend WithEvents Lbl_Mob_No_2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Mob_No_1 As System.Windows.Forms.Label
    Friend WithEvents Tb_Adress As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Mobile_Num_2 As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Mobile_Num_1 As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Customer_ID As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Customer_Name As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Add_Enquiry As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Mobile_Number As System.Windows.Forms.Label
    Friend WithEvents Lbl_Customer_Name As System.Windows.Forms.Label
    Friend WithEvents Lbl_Enquiry_ID As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Refresh As System.Windows.Forms.Button
    Friend WithEvents Cb_Event_Package As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_Event_Type As System.Windows.Forms.ComboBox
End Class
