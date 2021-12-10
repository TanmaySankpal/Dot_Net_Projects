<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_View_Single_Customer
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
        Me.Gb_View_Single_Customer = New System.Windows.Forms.GroupBox()
        Me.Btn_Charges_Detail = New System.Windows.Forms.Button()
        Me.Gb_view_Customer = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DTP_Stop = New System.Windows.Forms.DateTimePicker()
        Me.DTP_Start = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_To = New System.Windows.Forms.Label()
        Me.Cb_Event_Package = New System.Windows.Forms.ComboBox()
        Me.Lbl_Event_Categary = New System.Windows.Forms.Label()
        Me.Lbl_Event_Time = New System.Windows.Forms.Label()
        Me.Cb_No_Of_Persons = New System.Windows.Forms.ComboBox()
        Me.Lbl_No_Of_Persons = New System.Windows.Forms.Label()
        Me.Tb_Event_Name = New System.Windows.Forms.TextBox()
        Me.Lbl_Event_Type = New System.Windows.Forms.Label()
        Me.Cb_Event_Type = New System.Windows.Forms.ComboBox()
        Me.Lbl_Event_Name = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_Event_Date = New System.Windows.Forms.Label()
        Me.Gb_Personal_Deatail = New System.Windows.Forms.GroupBox()
        Me.Lbl_Mob_No_2 = New System.Windows.Forms.Label()
        Me.Lbl_Mob_No_1 = New System.Windows.Forms.Label()
        Me.Tb_Adress = New System.Windows.Forms.TextBox()
        Me.Tb_Mobile_Num_2 = New System.Windows.Forms.TextBox()
        Me.Tb_Mobile_Num_1 = New System.Windows.Forms.TextBox()
        Me.Tb_Customer_Name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lbl_Mobile_Number = New System.Windows.Forms.Label()
        Me.Lbl_Customer_Name = New System.Windows.Forms.Label()
        Me.Btn_Event_Detail = New System.Windows.Forms.Button()
        Me.Gb_Cust_id = New System.Windows.Forms.GroupBox()
        Me.Btn_Update = New System.Windows.Forms.Button()
        Me.Btn_Refresh = New System.Windows.Forms.Button()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.Tb_Bill_No = New System.Windows.Forms.TextBox()
        Me.Lbl_Bill_No = New System.Windows.Forms.Label()
        Me.Gb_View_Single_Customer.SuspendLayout()
        Me.Gb_view_Customer.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Gb_Personal_Deatail.SuspendLayout()
        Me.Gb_Cust_id.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gb_View_Single_Customer
        '
        Me.Gb_View_Single_Customer.BackColor = System.Drawing.Color.Transparent
        Me.Gb_View_Single_Customer.Controls.Add(Me.Btn_Charges_Detail)
        Me.Gb_View_Single_Customer.Controls.Add(Me.Gb_view_Customer)
        Me.Gb_View_Single_Customer.Controls.Add(Me.Btn_Event_Detail)
        Me.Gb_View_Single_Customer.Controls.Add(Me.Gb_Cust_id)
        Me.Gb_View_Single_Customer.Font = New System.Drawing.Font("Rockwell Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_View_Single_Customer.ForeColor = System.Drawing.Color.White
        Me.Gb_View_Single_Customer.Location = New System.Drawing.Point(22, 25)
        Me.Gb_View_Single_Customer.Name = "Gb_View_Single_Customer"
        Me.Gb_View_Single_Customer.Size = New System.Drawing.Size(1529, 765)
        Me.Gb_View_Single_Customer.TabIndex = 0
        Me.Gb_View_Single_Customer.TabStop = False
        Me.Gb_View_Single_Customer.Text = "View Single Customer"
        '
        'Btn_Charges_Detail
        '
        Me.Btn_Charges_Detail.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Btn_Charges_Detail.Enabled = False
        Me.Btn_Charges_Detail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Charges_Detail.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Btn_Charges_Detail.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_Charges_Detail.Image = Global.WindowsApplication1.My.Resources.Resources.Pay_Per_Click_icon
        Me.Btn_Charges_Detail.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Charges_Detail.Location = New System.Drawing.Point(798, 693)
        Me.Btn_Charges_Detail.Name = "Btn_Charges_Detail"
        Me.Btn_Charges_Detail.Size = New System.Drawing.Size(231, 58)
        Me.Btn_Charges_Detail.TabIndex = 46
        Me.Btn_Charges_Detail.Text = "Charges Detail  "
        Me.Btn_Charges_Detail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Charges_Detail.UseVisualStyleBackColor = False
        '
        'Gb_view_Customer
        '
        Me.Gb_view_Customer.BackColor = System.Drawing.Color.Transparent
        Me.Gb_view_Customer.Controls.Add(Me.GroupBox1)
        Me.Gb_view_Customer.Controls.Add(Me.Gb_Personal_Deatail)
        Me.Gb_view_Customer.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Gb_view_Customer.ForeColor = System.Drawing.Color.Transparent
        Me.Gb_view_Customer.Location = New System.Drawing.Point(52, 132)
        Me.Gb_view_Customer.Name = "Gb_view_Customer"
        Me.Gb_view_Customer.Size = New System.Drawing.Size(1425, 533)
        Me.Gb_view_Customer.TabIndex = 2
        Me.Gb_view_Customer.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.DTP_Stop)
        Me.GroupBox1.Controls.Add(Me.DTP_Start)
        Me.GroupBox1.Controls.Add(Me.Lbl_To)
        Me.GroupBox1.Controls.Add(Me.Cb_Event_Package)
        Me.GroupBox1.Controls.Add(Me.Lbl_Event_Categary)
        Me.GroupBox1.Controls.Add(Me.Lbl_Event_Time)
        Me.GroupBox1.Controls.Add(Me.Cb_No_Of_Persons)
        Me.GroupBox1.Controls.Add(Me.Lbl_No_Of_Persons)
        Me.GroupBox1.Controls.Add(Me.Tb_Event_Name)
        Me.GroupBox1.Controls.Add(Me.Lbl_Event_Type)
        Me.GroupBox1.Controls.Add(Me.Cb_Event_Type)
        Me.GroupBox1.Controls.Add(Me.Lbl_Event_Name)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Lbl_Event_Date)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Rockwell Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(1, 299)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1423, 225)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "#Event Detail"
        '
        'DTP_Stop
        '
        Me.DTP_Stop.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.DTP_Stop.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTP_Stop.Location = New System.Drawing.Point(1230, 169)
        Me.DTP_Stop.Name = "DTP_Stop"
        Me.DTP_Stop.Size = New System.Drawing.Size(186, 45)
        Me.DTP_Stop.TabIndex = 66
        '
        'DTP_Start
        '
        Me.DTP_Start.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.DTP_Start.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTP_Start.Location = New System.Drawing.Point(1020, 167)
        Me.DTP_Start.Name = "DTP_Start"
        Me.DTP_Start.Size = New System.Drawing.Size(167, 45)
        Me.DTP_Start.TabIndex = 65
        '
        'Lbl_To
        '
        Me.Lbl_To.AutoSize = True
        Me.Lbl_To.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_To.Location = New System.Drawing.Point(1193, 174)
        Me.Lbl_To.Name = "Lbl_To"
        Me.Lbl_To.Size = New System.Drawing.Size(42, 38)
        Me.Lbl_To.TabIndex = 64
        Me.Lbl_To.Text = "To"
        '
        'Cb_Event_Package
        '
        Me.Cb_Event_Package.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Event_Package.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Cb_Event_Package.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Cb_Event_Package.FormattingEnabled = True
        Me.Cb_Event_Package.Location = New System.Drawing.Point(377, 164)
        Me.Cb_Event_Package.Name = "Cb_Event_Package"
        Me.Cb_Event_Package.Size = New System.Drawing.Size(391, 46)
        Me.Cb_Event_Package.TabIndex = 62
        '
        'Lbl_Event_Categary
        '
        Me.Lbl_Event_Categary.AutoSize = True
        Me.Lbl_Event_Categary.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Event_Categary.Location = New System.Drawing.Point(142, 161)
        Me.Lbl_Event_Categary.Name = "Lbl_Event_Categary"
        Me.Lbl_Event_Categary.Size = New System.Drawing.Size(174, 38)
        Me.Lbl_Event_Categary.TabIndex = 61
        Me.Lbl_Event_Categary.Text = "Event Category"
        '
        'Lbl_Event_Time
        '
        Me.Lbl_Event_Time.AutoSize = True
        Me.Lbl_Event_Time.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Event_Time.Location = New System.Drawing.Point(849, 161)
        Me.Lbl_Event_Time.Name = "Lbl_Event_Time"
        Me.Lbl_Event_Time.Size = New System.Drawing.Size(135, 38)
        Me.Lbl_Event_Time.TabIndex = 58
        Me.Lbl_Event_Time.Text = "Event Time"
        '
        'Cb_No_Of_Persons
        '
        Me.Cb_No_Of_Persons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_No_Of_Persons.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Cb_No_Of_Persons.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Cb_No_Of_Persons.FormattingEnabled = True
        Me.Cb_No_Of_Persons.Items.AddRange(New Object() {"50", "100", "150", "200", "400", "800", "1000"})
        Me.Cb_No_Of_Persons.Location = New System.Drawing.Point(1051, 39)
        Me.Cb_No_Of_Persons.Name = "Cb_No_Of_Persons"
        Me.Cb_No_Of_Persons.Size = New System.Drawing.Size(275, 46)
        Me.Cb_No_Of_Persons.TabIndex = 56
        '
        'Lbl_No_Of_Persons
        '
        Me.Lbl_No_Of_Persons.AutoSize = True
        Me.Lbl_No_Of_Persons.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_No_Of_Persons.Location = New System.Drawing.Point(849, 47)
        Me.Lbl_No_Of_Persons.Name = "Lbl_No_Of_Persons"
        Me.Lbl_No_Of_Persons.Size = New System.Drawing.Size(156, 38)
        Me.Lbl_No_Of_Persons.TabIndex = 57
        Me.Lbl_No_Of_Persons.Text = "No.Of Persons"
        '
        'Tb_Event_Name
        '
        Me.Tb_Event_Name.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Event_Name.Location = New System.Drawing.Point(377, 32)
        Me.Tb_Event_Name.Name = "Tb_Event_Name"
        Me.Tb_Event_Name.Size = New System.Drawing.Size(391, 45)
        Me.Tb_Event_Name.TabIndex = 48
        '
        'Lbl_Event_Type
        '
        Me.Lbl_Event_Type.AutoSize = True
        Me.Lbl_Event_Type.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Event_Type.Location = New System.Drawing.Point(142, 100)
        Me.Lbl_Event_Type.Name = "Lbl_Event_Type"
        Me.Lbl_Event_Type.Size = New System.Drawing.Size(135, 38)
        Me.Lbl_Event_Type.TabIndex = 53
        Me.Lbl_Event_Type.Text = "Event Type"
        '
        'Cb_Event_Type
        '
        Me.Cb_Event_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Event_Type.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Cb_Event_Type.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Cb_Event_Type.FormattingEnabled = True
        Me.Cb_Event_Type.Items.AddRange(New Object() {"Birthday ", "Marriage ", "Party"})
        Me.Cb_Event_Type.Location = New System.Drawing.Point(377, 100)
        Me.Cb_Event_Type.Name = "Cb_Event_Type"
        Me.Cb_Event_Type.Size = New System.Drawing.Size(391, 46)
        Me.Cb_Event_Type.TabIndex = 49
        '
        'Lbl_Event_Name
        '
        Me.Lbl_Event_Name.AutoSize = True
        Me.Lbl_Event_Name.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Event_Name.Location = New System.Drawing.Point(142, 32)
        Me.Lbl_Event_Name.Name = "Lbl_Event_Name"
        Me.Lbl_Event_Name.Size = New System.Drawing.Size(141, 38)
        Me.Lbl_Event_Name.TabIndex = 52
        Me.Lbl_Event_Name.Text = "Event Name"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarForeColor = System.Drawing.Color.DarkGreen
        Me.DateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.DateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.DateTimePicker1.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(1051, 105)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(275, 45)
        Me.DateTimePicker1.TabIndex = 50
        '
        'Lbl_Event_Date
        '
        Me.Lbl_Event_Date.AutoSize = True
        Me.Lbl_Event_Date.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Event_Date.Location = New System.Drawing.Point(849, 105)
        Me.Lbl_Event_Date.Name = "Lbl_Event_Date"
        Me.Lbl_Event_Date.Size = New System.Drawing.Size(130, 38)
        Me.Lbl_Event_Date.TabIndex = 51
        Me.Lbl_Event_Date.Text = "Event Date"
        '
        'Gb_Personal_Deatail
        '
        Me.Gb_Personal_Deatail.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Gb_Personal_Deatail.Controls.Add(Me.Lbl_Mob_No_2)
        Me.Gb_Personal_Deatail.Controls.Add(Me.Lbl_Mob_No_1)
        Me.Gb_Personal_Deatail.Controls.Add(Me.Tb_Adress)
        Me.Gb_Personal_Deatail.Controls.Add(Me.Tb_Mobile_Num_2)
        Me.Gb_Personal_Deatail.Controls.Add(Me.Tb_Mobile_Num_1)
        Me.Gb_Personal_Deatail.Controls.Add(Me.Tb_Customer_Name)
        Me.Gb_Personal_Deatail.Controls.Add(Me.Label2)
        Me.Gb_Personal_Deatail.Controls.Add(Me.Lbl_Mobile_Number)
        Me.Gb_Personal_Deatail.Controls.Add(Me.Lbl_Customer_Name)
        Me.Gb_Personal_Deatail.Enabled = False
        Me.Gb_Personal_Deatail.Font = New System.Drawing.Font("Rockwell Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_Personal_Deatail.ForeColor = System.Drawing.Color.Black
        Me.Gb_Personal_Deatail.Location = New System.Drawing.Point(1, 6)
        Me.Gb_Personal_Deatail.Name = "Gb_Personal_Deatail"
        Me.Gb_Personal_Deatail.Size = New System.Drawing.Size(1423, 272)
        Me.Gb_Personal_Deatail.TabIndex = 50
        Me.Gb_Personal_Deatail.TabStop = False
        Me.Gb_Personal_Deatail.Text = "#Personal Detail"
        '
        'Lbl_Mob_No_2
        '
        Me.Lbl_Mob_No_2.AutoSize = True
        Me.Lbl_Mob_No_2.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Mob_No_2.Location = New System.Drawing.Point(895, 184)
        Me.Lbl_Mob_No_2.Name = "Lbl_Mob_No_2"
        Me.Lbl_Mob_No_2.Size = New System.Drawing.Size(34, 38)
        Me.Lbl_Mob_No_2.TabIndex = 22
        Me.Lbl_Mob_No_2.Text = "2."
        '
        'Lbl_Mob_No_1
        '
        Me.Lbl_Mob_No_1.AutoSize = True
        Me.Lbl_Mob_No_1.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Mob_No_1.Location = New System.Drawing.Point(446, 184)
        Me.Lbl_Mob_No_1.Name = "Lbl_Mob_No_1"
        Me.Lbl_Mob_No_1.Size = New System.Drawing.Size(34, 38)
        Me.Lbl_Mob_No_1.TabIndex = 21
        Me.Lbl_Mob_No_1.Text = "1."
        '
        'Tb_Adress
        '
        Me.Tb_Adress.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Adress.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Tb_Adress.Location = New System.Drawing.Point(437, 114)
        Me.Tb_Adress.MaxLength = 50
        Me.Tb_Adress.Name = "Tb_Adress"
        Me.Tb_Adress.Size = New System.Drawing.Size(847, 45)
        Me.Tb_Adress.TabIndex = 16
        '
        'Tb_Mobile_Num_2
        '
        Me.Tb_Mobile_Num_2.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Mobile_Num_2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Tb_Mobile_Num_2.Location = New System.Drawing.Point(945, 179)
        Me.Tb_Mobile_Num_2.MaxLength = 10
        Me.Tb_Mobile_Num_2.Name = "Tb_Mobile_Num_2"
        Me.Tb_Mobile_Num_2.Size = New System.Drawing.Size(341, 45)
        Me.Tb_Mobile_Num_2.TabIndex = 20
        '
        'Tb_Mobile_Num_1
        '
        Me.Tb_Mobile_Num_1.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Mobile_Num_1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Tb_Mobile_Num_1.Location = New System.Drawing.Point(504, 179)
        Me.Tb_Mobile_Num_1.MaxLength = 10
        Me.Tb_Mobile_Num_1.Name = "Tb_Mobile_Num_1"
        Me.Tb_Mobile_Num_1.Size = New System.Drawing.Size(328, 45)
        Me.Tb_Mobile_Num_1.TabIndex = 19
        '
        'Tb_Customer_Name
        '
        Me.Tb_Customer_Name.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Customer_Name.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Tb_Customer_Name.Location = New System.Drawing.Point(439, 50)
        Me.Tb_Customer_Name.MaxLength = 50
        Me.Tb_Customer_Name.Name = "Tb_Customer_Name"
        Me.Tb_Customer_Name.Size = New System.Drawing.Size(847, 45)
        Me.Tb_Customer_Name.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Label2.Location = New System.Drawing.Point(201, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 38)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Address"
        '
        'Lbl_Mobile_Number
        '
        Me.Lbl_Mobile_Number.AutoSize = True
        Me.Lbl_Mobile_Number.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Mobile_Number.Location = New System.Drawing.Point(194, 190)
        Me.Lbl_Mobile_Number.Name = "Lbl_Mobile_Number"
        Me.Lbl_Mobile_Number.Size = New System.Drawing.Size(171, 38)
        Me.Lbl_Mobile_Number.TabIndex = 17
        Me.Lbl_Mobile_Number.Text = "Mobile Number"
        '
        'Lbl_Customer_Name
        '
        Me.Lbl_Customer_Name.AutoSize = True
        Me.Lbl_Customer_Name.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Customer_Name.Location = New System.Drawing.Point(194, 50)
        Me.Lbl_Customer_Name.Name = "Lbl_Customer_Name"
        Me.Lbl_Customer_Name.Size = New System.Drawing.Size(176, 38)
        Me.Lbl_Customer_Name.TabIndex = 15
        Me.Lbl_Customer_Name.Text = "Customer Name"
        '
        'Btn_Event_Detail
        '
        Me.Btn_Event_Detail.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Btn_Event_Detail.Enabled = False
        Me.Btn_Event_Detail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Event_Detail.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Btn_Event_Detail.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_Event_Detail.Image = Global.WindowsApplication1.My.Resources.Resources.services_portfolio_icon
        Me.Btn_Event_Detail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Event_Detail.Location = New System.Drawing.Point(518, 693)
        Me.Btn_Event_Detail.Name = "Btn_Event_Detail"
        Me.Btn_Event_Detail.Size = New System.Drawing.Size(238, 58)
        Me.Btn_Event_Detail.TabIndex = 45
        Me.Btn_Event_Detail.Text = "    Services Detail"
        Me.Btn_Event_Detail.UseVisualStyleBackColor = False
        '
        'Gb_Cust_id
        '
        Me.Gb_Cust_id.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Gb_Cust_id.Controls.Add(Me.Btn_Update)
        Me.Gb_Cust_id.Controls.Add(Me.Btn_Refresh)
        Me.Gb_Cust_id.Controls.Add(Me.Btn_Search)
        Me.Gb_Cust_id.Controls.Add(Me.Tb_Bill_No)
        Me.Gb_Cust_id.Controls.Add(Me.Lbl_Bill_No)
        Me.Gb_Cust_id.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Gb_Cust_id.ForeColor = System.Drawing.Color.Black
        Me.Gb_Cust_id.Location = New System.Drawing.Point(52, 34)
        Me.Gb_Cust_id.Name = "Gb_Cust_id"
        Me.Gb_Cust_id.Size = New System.Drawing.Size(1425, 92)
        Me.Gb_Cust_id.TabIndex = 1
        Me.Gb_Cust_id.TabStop = False
        '
        'Btn_Update
        '
        Me.Btn_Update.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Btn_Update.Enabled = False
        Me.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Update.Font = New System.Drawing.Font("Rockwell Condensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Update.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_Update.Image = Global.WindowsApplication1.My.Resources.Resources.add_icon1
        Me.Btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Update.Location = New System.Drawing.Point(1249, 31)
        Me.Btn_Update.Name = "Btn_Update"
        Me.Btn_Update.Size = New System.Drawing.Size(166, 42)
        Me.Btn_Update.TabIndex = 39
        Me.Btn_Update.Text = "  Update"
        Me.Btn_Update.UseVisualStyleBackColor = False
        '
        'Btn_Refresh
        '
        Me.Btn_Refresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Refresh.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Btn_Refresh.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_Refresh.Image = Global.WindowsApplication1.My.Resources.Resources.update_icon
        Me.Btn_Refresh.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Btn_Refresh.Location = New System.Drawing.Point(1062, 31)
        Me.Btn_Refresh.Name = "Btn_Refresh"
        Me.Btn_Refresh.Size = New System.Drawing.Size(173, 42)
        Me.Btn_Refresh.TabIndex = 36
        Me.Btn_Refresh.Text = "Refresh"
        Me.Btn_Refresh.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Refresh.UseVisualStyleBackColor = False
        '
        'Btn_Search
        '
        Me.Btn_Search.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Search.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Btn_Search.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_Search.Image = Global.WindowsApplication1.My.Resources.Resources.Knob_Search_icon1
        Me.Btn_Search.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Btn_Search.Location = New System.Drawing.Point(873, 31)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(173, 42)
        Me.Btn_Search.TabIndex = 35
        Me.Btn_Search.Text = "Search"
        Me.Btn_Search.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Search.UseVisualStyleBackColor = False
        '
        'Tb_Bill_No
        '
        Me.Tb_Bill_No.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Bill_No.Location = New System.Drawing.Point(438, 28)
        Me.Tb_Bill_No.Name = "Tb_Bill_No"
        Me.Tb_Bill_No.Size = New System.Drawing.Size(391, 45)
        Me.Tb_Bill_No.TabIndex = 34
        '
        'Lbl_Bill_No
        '
        Me.Lbl_Bill_No.AutoSize = True
        Me.Lbl_Bill_No.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Bill_No.Location = New System.Drawing.Point(144, 33)
        Me.Lbl_Bill_No.Name = "Lbl_Bill_No"
        Me.Lbl_Bill_No.Size = New System.Drawing.Size(142, 38)
        Me.Lbl_Bill_No.TabIndex = 18
        Me.Lbl_Bill_No.Text = "Customer ID"
        '
        'Frm_View_Single_Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.shubhaarambh_event4
        Me.ClientSize = New System.Drawing.Size(1584, 862)
        Me.ControlBox = False
        Me.Controls.Add(Me.Gb_View_Single_Customer)
        Me.Name = "Frm_View_Single_Customer"
        Me.Text = "View Single Customer"
        Me.Gb_View_Single_Customer.ResumeLayout(False)
        Me.Gb_view_Customer.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Gb_Personal_Deatail.ResumeLayout(False)
        Me.Gb_Personal_Deatail.PerformLayout()
        Me.Gb_Cust_id.ResumeLayout(False)
        Me.Gb_Cust_id.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gb_View_Single_Customer As System.Windows.Forms.GroupBox
    Friend WithEvents Gb_view_Customer As System.Windows.Forms.GroupBox
    Friend WithEvents Gb_Cust_id As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Refresh As System.Windows.Forms.Button
    Friend WithEvents Btn_Search As System.Windows.Forms.Button
    Friend WithEvents Tb_Bill_No As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Bill_No As System.Windows.Forms.Label
    Friend WithEvents Btn_Update As System.Windows.Forms.Button
    Friend WithEvents Btn_Charges_Detail As System.Windows.Forms.Button
    Friend WithEvents Btn_Event_Detail As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Cb_Event_Package As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_Event_Categary As System.Windows.Forms.Label
    Friend WithEvents Lbl_Event_Time As System.Windows.Forms.Label
    Friend WithEvents Cb_No_Of_Persons As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_No_Of_Persons As System.Windows.Forms.Label
    Friend WithEvents Tb_Event_Name As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Event_Type As System.Windows.Forms.Label
    Friend WithEvents Cb_Event_Type As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_Event_Name As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_Event_Date As System.Windows.Forms.Label
    Friend WithEvents Gb_Personal_Deatail As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Mob_No_2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Mob_No_1 As System.Windows.Forms.Label
    Friend WithEvents Tb_Adress As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Mobile_Num_2 As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Mobile_Num_1 As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Customer_Name As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Mobile_Number As System.Windows.Forms.Label
    Friend WithEvents Lbl_Customer_Name As System.Windows.Forms.Label
    Friend WithEvents DTP_Stop As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP_Start As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_To As System.Windows.Forms.Label
End Class
