<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Add_New_User
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.Btn_Add_User = New System.Windows.Forms.Button()
        Me.Gb_Add_New_User = New System.Windows.Forms.GroupBox()
        Me.Lbl_Not_Match = New System.Windows.Forms.Label()
        Me.Lbl_Match = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Cb_User_Role = New System.Windows.Forms.ComboBox()
        Me.Tb_Confirm_Pass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tb_User_Name = New System.Windows.Forms.TextBox()
        Me.Tb_Password = New System.Windows.Forms.TextBox()
        Me.Lbl_Pass = New System.Windows.Forms.Label()
        Me.Tb_User_ID = New System.Windows.Forms.TextBox()
        Me.Lbl_User_Role = New System.Windows.Forms.Label()
        Me.Lbl_User_ID = New System.Windows.Forms.Label()
        Me.Lbl_User_Name = New System.Windows.Forms.Label()
        Me.Gb_Add_New_Employee = New System.Windows.Forms.GroupBox()
        Me.cmb_Position = New System.Windows.Forms.ComboBox()
        Me.lbl_Appointed_Position = New System.Windows.Forms.Label()
        Me.txt_Adhaar_No = New System.Windows.Forms.TextBox()
        Me.lbl_Adhaar_No = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbl_Mob_No = New System.Windows.Forms.Label()
        Me.txt_Mob_No = New System.Windows.Forms.TextBox()
        Me.dtp_Join_Date = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Join_Date = New System.Windows.Forms.Label()
        Me.lbl_Address = New System.Windows.Forms.Label()
        Me.txt_Address = New System.Windows.Forms.TextBox()
        Me.lbl_Employee_Id = New System.Windows.Forms.Label()
        Me.txt_Employee_Id = New System.Windows.Forms.TextBox()
        Me.lbl_first_Name = New System.Windows.Forms.Label()
        Me.txt_First_Name = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Gb_Add_New_User.SuspendLayout()
        Me.Gb_Add_New_Employee.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Panel1.Location = New System.Drawing.Point(-109, -20)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2331, 146)
        Me.Panel1.TabIndex = 93
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 71.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label1.Location = New System.Drawing.Point(458, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1015, 98)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add New Employee/User"
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cancel.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Btn_Cancel.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_Cancel.Image = Global.WindowsApplication1.My.Resources.Resources.close_icon3
        Me.Btn_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cancel.Location = New System.Drawing.Point(793, 691)
        Me.Btn_Cancel.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(141, 66)
        Me.Btn_Cancel.TabIndex = 15
        Me.Btn_Cancel.Text = "Cancel"
        Me.Btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancel.UseVisualStyleBackColor = False
        '
        'Btn_Add_User
        '
        Me.Btn_Add_User.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Btn_Add_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Add_User.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Btn_Add_User.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_Add_User.Image = Global.WindowsApplication1.My.Resources.Resources.add_icon4
        Me.Btn_Add_User.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Add_User.Location = New System.Drawing.Point(498, 691)
        Me.Btn_Add_User.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Add_User.Name = "Btn_Add_User"
        Me.Btn_Add_User.Size = New System.Drawing.Size(279, 66)
        Me.Btn_Add_User.TabIndex = 14
        Me.Btn_Add_User.Text = "Add Employee/User"
        Me.Btn_Add_User.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Add_User.UseVisualStyleBackColor = False
        '
        'Gb_Add_New_User
        '
        Me.Gb_Add_New_User.Controls.Add(Me.Lbl_Not_Match)
        Me.Gb_Add_New_User.Controls.Add(Me.Lbl_Match)
        Me.Gb_Add_New_User.Controls.Add(Me.Button1)
        Me.Gb_Add_New_User.Controls.Add(Me.Cb_User_Role)
        Me.Gb_Add_New_User.Controls.Add(Me.Tb_Confirm_Pass)
        Me.Gb_Add_New_User.Controls.Add(Me.Label3)
        Me.Gb_Add_New_User.Controls.Add(Me.Tb_User_Name)
        Me.Gb_Add_New_User.Controls.Add(Me.Tb_Password)
        Me.Gb_Add_New_User.Controls.Add(Me.Lbl_Pass)
        Me.Gb_Add_New_User.Controls.Add(Me.Tb_User_ID)
        Me.Gb_Add_New_User.Controls.Add(Me.Lbl_User_Role)
        Me.Gb_Add_New_User.Controls.Add(Me.Lbl_User_ID)
        Me.Gb_Add_New_User.Controls.Add(Me.Lbl_User_Name)
        Me.Gb_Add_New_User.Enabled = False
        Me.Gb_Add_New_User.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_Add_New_User.Location = New System.Drawing.Point(793, 143)
        Me.Gb_Add_New_User.Name = "Gb_Add_New_User"
        Me.Gb_Add_New_User.Size = New System.Drawing.Size(767, 539)
        Me.Gb_Add_New_User.TabIndex = 115
        Me.Gb_Add_New_User.TabStop = False
        Me.Gb_Add_New_User.Text = "#Add New User"
        '
        'Lbl_Not_Match
        '
        Me.Lbl_Not_Match.AutoSize = True
        Me.Lbl_Not_Match.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Not_Match.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Not_Match.Location = New System.Drawing.Point(336, 498)
        Me.Lbl_Not_Match.Name = "Lbl_Not_Match"
        Me.Lbl_Not_Match.Size = New System.Drawing.Size(215, 24)
        Me.Lbl_Not_Match.TabIndex = 126
        Me.Lbl_Not_Match.Text = "Password Not Match.."
        Me.Lbl_Not_Match.Visible = False
        '
        'Lbl_Match
        '
        Me.Lbl_Match.AutoSize = True
        Me.Lbl_Match.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Match.ForeColor = System.Drawing.Color.Green
        Me.Lbl_Match.Location = New System.Drawing.Point(336, 498)
        Me.Lbl_Match.Name = "Lbl_Match"
        Me.Lbl_Match.Size = New System.Drawing.Size(175, 24)
        Me.Lbl_Match.TabIndex = 125
        Me.Lbl_Match.Text = "Password Match.."
        Me.Lbl_Match.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Window
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(635, 352)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 45)
        Me.Button1.TabIndex = 124
        Me.Button1.Text = "View"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Cb_User_Role
        '
        Me.Cb_User_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_User_Role.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Cb_User_Role.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Cb_User_Role.FormattingEnabled = True
        Me.Cb_User_Role.Items.AddRange(New Object() {"Admin/Owner", "Manager", "Receptionist"})
        Me.Cb_User_Role.Location = New System.Drawing.Point(245, 241)
        Me.Cb_User_Role.Margin = New System.Windows.Forms.Padding(4)
        Me.Cb_User_Role.MaxLength = 30
        Me.Cb_User_Role.Name = "Cb_User_Role"
        Me.Cb_User_Role.Size = New System.Drawing.Size(486, 46)
        Me.Cb_User_Role.TabIndex = 11
        '
        'Tb_Confirm_Pass
        '
        Me.Tb_Confirm_Pass.Enabled = False
        Me.Tb_Confirm_Pass.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Confirm_Pass.Location = New System.Drawing.Point(251, 451)
        Me.Tb_Confirm_Pass.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_Confirm_Pass.MaxLength = 8
        Me.Tb_Confirm_Pass.Name = "Tb_Confirm_Pass"
        Me.Tb_Confirm_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(36)
        Me.Tb_Confirm_Pass.Size = New System.Drawing.Size(480, 45)
        Me.Tb_Confirm_Pass.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Label3.Location = New System.Drawing.Point(32, 460)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 38)
        Me.Label3.TabIndex = 122
        Me.Label3.Text = "Confirm Password"
        '
        'Tb_User_Name
        '
        Me.Tb_User_Name.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_User_Name.Location = New System.Drawing.Point(251, 139)
        Me.Tb_User_Name.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_User_Name.MaxLength = 10
        Me.Tb_User_Name.Name = "Tb_User_Name"
        Me.Tb_User_Name.Size = New System.Drawing.Size(480, 45)
        Me.Tb_User_Name.TabIndex = 10
        '
        'Tb_Password
        '
        Me.Tb_Password.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Password.Location = New System.Drawing.Point(245, 352)
        Me.Tb_Password.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_Password.MaxLength = 8
        Me.Tb_Password.Name = "Tb_Password"
        Me.Tb_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(36)
        Me.Tb_Password.Size = New System.Drawing.Size(427, 45)
        Me.Tb_Password.TabIndex = 12
        '
        'Lbl_Pass
        '
        Me.Lbl_Pass.AutoSize = True
        Me.Lbl_Pass.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Pass.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Pass.Location = New System.Drawing.Point(126, 355)
        Me.Lbl_Pass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Pass.Name = "Lbl_Pass"
        Me.Lbl_Pass.Size = New System.Drawing.Size(112, 38)
        Me.Lbl_Pass.TabIndex = 121
        Me.Lbl_Pass.Text = "Password"
        '
        'Tb_User_ID
        '
        Me.Tb_User_ID.Enabled = False
        Me.Tb_User_ID.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_User_ID.Location = New System.Drawing.Point(245, 45)
        Me.Tb_User_ID.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_User_ID.Name = "Tb_User_ID"
        Me.Tb_User_ID.Size = New System.Drawing.Size(486, 45)
        Me.Tb_User_ID.TabIndex = 9
        '
        'Lbl_User_Role
        '
        Me.Lbl_User_Role.AutoSize = True
        Me.Lbl_User_Role.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_User_Role.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_User_Role.Location = New System.Drawing.Point(126, 245)
        Me.Lbl_User_Role.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_User_Role.Name = "Lbl_User_Role"
        Me.Lbl_User_Role.Size = New System.Drawing.Size(115, 38)
        Me.Lbl_User_Role.TabIndex = 119
        Me.Lbl_User_Role.Text = "User Role"
        '
        'Lbl_User_ID
        '
        Me.Lbl_User_ID.AutoSize = True
        Me.Lbl_User_ID.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_User_ID.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_User_ID.Location = New System.Drawing.Point(95, 54)
        Me.Lbl_User_ID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_User_ID.Name = "Lbl_User_ID"
        Me.Lbl_User_ID.Size = New System.Drawing.Size(145, 38)
        Me.Lbl_User_ID.TabIndex = 120
        Me.Lbl_User_ID.Text = "Employee ID"
        '
        'Lbl_User_Name
        '
        Me.Lbl_User_Name.AutoSize = True
        Me.Lbl_User_Name.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_User_Name.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_User_Name.Location = New System.Drawing.Point(128, 147)
        Me.Lbl_User_Name.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_User_Name.Name = "Lbl_User_Name"
        Me.Lbl_User_Name.Size = New System.Drawing.Size(129, 38)
        Me.Lbl_User_Name.TabIndex = 118
        Me.Lbl_User_Name.Text = "User Name"
        '
        'Gb_Add_New_Employee
        '
        Me.Gb_Add_New_Employee.Controls.Add(Me.cmb_Position)
        Me.Gb_Add_New_Employee.Controls.Add(Me.lbl_Appointed_Position)
        Me.Gb_Add_New_Employee.Controls.Add(Me.txt_Adhaar_No)
        Me.Gb_Add_New_Employee.Controls.Add(Me.lbl_Adhaar_No)
        Me.Gb_Add_New_Employee.Controls.Add(Me.Label2)
        Me.Gb_Add_New_Employee.Controls.Add(Me.Label4)
        Me.Gb_Add_New_Employee.Controls.Add(Me.TextBox1)
        Me.Gb_Add_New_Employee.Controls.Add(Me.lbl_Mob_No)
        Me.Gb_Add_New_Employee.Controls.Add(Me.txt_Mob_No)
        Me.Gb_Add_New_Employee.Controls.Add(Me.dtp_Join_Date)
        Me.Gb_Add_New_Employee.Controls.Add(Me.lbl_Join_Date)
        Me.Gb_Add_New_Employee.Controls.Add(Me.lbl_Address)
        Me.Gb_Add_New_Employee.Controls.Add(Me.txt_Address)
        Me.Gb_Add_New_Employee.Controls.Add(Me.lbl_Employee_Id)
        Me.Gb_Add_New_Employee.Controls.Add(Me.txt_Employee_Id)
        Me.Gb_Add_New_Employee.Controls.Add(Me.lbl_first_Name)
        Me.Gb_Add_New_Employee.Controls.Add(Me.txt_First_Name)
        Me.Gb_Add_New_Employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Gb_Add_New_Employee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_Add_New_Employee.ForeColor = System.Drawing.Color.DarkBlue
        Me.Gb_Add_New_Employee.Location = New System.Drawing.Point(12, 143)
        Me.Gb_Add_New_Employee.Name = "Gb_Add_New_Employee"
        Me.Gb_Add_New_Employee.Size = New System.Drawing.Size(765, 541)
        Me.Gb_Add_New_Employee.TabIndex = 116
        Me.Gb_Add_New_Employee.TabStop = False
        Me.Gb_Add_New_Employee.Text = "#Add New Employee"
        '
        'cmb_Position
        '
        Me.cmb_Position.BackColor = System.Drawing.Color.AliceBlue
        Me.cmb_Position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Position.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.cmb_Position.FormattingEnabled = True
        Me.cmb_Position.Items.AddRange(New Object() {"Admin/Owner", "Manager", "Receptionist", "Worker"})
        Me.cmb_Position.Location = New System.Drawing.Point(258, 474)
        Me.cmb_Position.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_Position.Name = "cmb_Position"
        Me.cmb_Position.Size = New System.Drawing.Size(482, 46)
        Me.cmb_Position.TabIndex = 8
        '
        'lbl_Appointed_Position
        '
        Me.lbl_Appointed_Position.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Appointed_Position.AutoSize = True
        Me.lbl_Appointed_Position.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.lbl_Appointed_Position.Location = New System.Drawing.Point(46, 474)
        Me.lbl_Appointed_Position.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Appointed_Position.Name = "lbl_Appointed_Position"
        Me.lbl_Appointed_Position.Size = New System.Drawing.Size(207, 38)
        Me.lbl_Appointed_Position.TabIndex = 175
        Me.lbl_Appointed_Position.Text = "Appointed Position"
        '
        'txt_Adhaar_No
        '
        Me.txt_Adhaar_No.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Adhaar_No.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.txt_Adhaar_No.Location = New System.Drawing.Point(253, 401)
        Me.txt_Adhaar_No.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Adhaar_No.MaxLength = 12
        Me.txt_Adhaar_No.Name = "txt_Adhaar_No"
        Me.txt_Adhaar_No.Size = New System.Drawing.Size(482, 45)
        Me.txt_Adhaar_No.TabIndex = 7
        '
        'lbl_Adhaar_No
        '
        Me.lbl_Adhaar_No.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Adhaar_No.AutoSize = True
        Me.lbl_Adhaar_No.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.lbl_Adhaar_No.Location = New System.Drawing.Point(20, 404)
        Me.lbl_Adhaar_No.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Adhaar_No.Name = "lbl_Adhaar_No"
        Me.lbl_Adhaar_No.Size = New System.Drawing.Size(230, 38)
        Me.lbl_Adhaar_No.TabIndex = 174
        Me.lbl_Adhaar_No.Text = "Adhaar/Pan Number"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Label2.Location = New System.Drawing.Point(219, 339)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 38)
        Me.Label2.TabIndex = 171
        Me.Label2.Text = "2."
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Label4.Location = New System.Drawing.Point(219, 288)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 38)
        Me.Label4.TabIndex = 170
        Me.Label4.Text = "1."
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.TextBox1.Location = New System.Drawing.Point(254, 338)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.MaxLength = 10
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(482, 39)
        Me.TextBox1.TabIndex = 6
        '
        'lbl_Mob_No
        '
        Me.lbl_Mob_No.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Mob_No.AutoSize = True
        Me.lbl_Mob_No.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.lbl_Mob_No.Location = New System.Drawing.Point(55, 288)
        Me.lbl_Mob_No.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Mob_No.Name = "lbl_Mob_No"
        Me.lbl_Mob_No.Size = New System.Drawing.Size(171, 38)
        Me.lbl_Mob_No.TabIndex = 168
        Me.lbl_Mob_No.Text = "Mobile Number"
        '
        'txt_Mob_No
        '
        Me.txt_Mob_No.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Mob_No.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.txt_Mob_No.Location = New System.Drawing.Point(254, 285)
        Me.txt_Mob_No.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Mob_No.MaxLength = 10
        Me.txt_Mob_No.Multiline = True
        Me.txt_Mob_No.Name = "txt_Mob_No"
        Me.txt_Mob_No.Size = New System.Drawing.Size(482, 39)
        Me.txt_Mob_No.TabIndex = 5
        '
        'dtp_Join_Date
        '
        Me.dtp_Join_Date.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.dtp_Join_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Join_Date.Location = New System.Drawing.Point(254, 222)
        Me.dtp_Join_Date.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_Join_Date.Name = "dtp_Join_Date"
        Me.dtp_Join_Date.Size = New System.Drawing.Size(486, 45)
        Me.dtp_Join_Date.TabIndex = 4
        '
        'lbl_Join_Date
        '
        Me.lbl_Join_Date.AutoSize = True
        Me.lbl_Join_Date.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.lbl_Join_Date.Location = New System.Drawing.Point(73, 229)
        Me.lbl_Join_Date.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Join_Date.Name = "lbl_Join_Date"
        Me.lbl_Join_Date.Size = New System.Drawing.Size(142, 38)
        Me.lbl_Join_Date.TabIndex = 167
        Me.lbl_Join_Date.Text = "Joining Date"
        '
        'lbl_Address
        '
        Me.lbl_Address.AutoSize = True
        Me.lbl_Address.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.lbl_Address.Location = New System.Drawing.Point(73, 164)
        Me.lbl_Address.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Address.Name = "lbl_Address"
        Me.lbl_Address.Size = New System.Drawing.Size(96, 38)
        Me.lbl_Address.TabIndex = 164
        Me.lbl_Address.Text = "Address"
        '
        'txt_Address
        '
        Me.txt_Address.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.txt_Address.Location = New System.Drawing.Point(249, 159)
        Me.txt_Address.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Address.MaxLength = 30
        Me.txt_Address.Multiline = True
        Me.txt_Address.Name = "txt_Address"
        Me.txt_Address.Size = New System.Drawing.Size(495, 43)
        Me.txt_Address.TabIndex = 3
        '
        'lbl_Employee_Id
        '
        Me.lbl_Employee_Id.AutoSize = True
        Me.lbl_Employee_Id.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.lbl_Employee_Id.Location = New System.Drawing.Point(66, 23)
        Me.lbl_Employee_Id.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Employee_Id.Name = "lbl_Employee_Id"
        Me.lbl_Employee_Id.Size = New System.Drawing.Size(145, 38)
        Me.lbl_Employee_Id.TabIndex = 161
        Me.lbl_Employee_Id.Text = "Employee ID"
        '
        'txt_Employee_Id
        '
        Me.txt_Employee_Id.Enabled = False
        Me.txt_Employee_Id.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.txt_Employee_Id.Location = New System.Drawing.Point(249, 20)
        Me.txt_Employee_Id.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Employee_Id.MaxLength = 10
        Me.txt_Employee_Id.Name = "txt_Employee_Id"
        Me.txt_Employee_Id.Size = New System.Drawing.Size(495, 45)
        Me.txt_Employee_Id.TabIndex = 1
        '
        'lbl_first_Name
        '
        Me.lbl_first_Name.AutoSize = True
        Me.lbl_first_Name.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.lbl_first_Name.Location = New System.Drawing.Point(66, 90)
        Me.lbl_first_Name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_first_Name.Name = "lbl_first_Name"
        Me.lbl_first_Name.Size = New System.Drawing.Size(179, 38)
        Me.lbl_first_Name.TabIndex = 162
        Me.lbl_first_Name.Text = "Employee Name"
        '
        'txt_First_Name
        '
        Me.txt_First_Name.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.txt_First_Name.Location = New System.Drawing.Point(249, 87)
        Me.txt_First_Name.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_First_Name.MaxLength = 30
        Me.txt_First_Name.Name = "txt_First_Name"
        Me.txt_First_Name.Size = New System.Drawing.Size(495, 45)
        Me.txt_First_Name.TabIndex = 2
        '
        'Frm_Add_New_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1584, 762)
        Me.ControlBox = False
        Me.Controls.Add(Me.Gb_Add_New_Employee)
        Me.Controls.Add(Me.Gb_Add_New_User)
        Me.Controls.Add(Me.Btn_Cancel)
        Me.Controls.Add(Me.Btn_Add_User)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_Add_New_User"
        Me.Text = "Add New User"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Gb_Add_New_User.ResumeLayout(False)
        Me.Gb_Add_New_User.PerformLayout()
        Me.Gb_Add_New_Employee.ResumeLayout(False)
        Me.Gb_Add_New_Employee.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents Btn_Add_User As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Gb_Add_New_User As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Not_Match As System.Windows.Forms.Label
    Friend WithEvents Lbl_Match As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Cb_User_Role As System.Windows.Forms.ComboBox
    Friend WithEvents Tb_Confirm_Pass As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Tb_User_Name As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Password As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Pass As System.Windows.Forms.Label
    Friend WithEvents Tb_User_ID As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_User_Role As System.Windows.Forms.Label
    Friend WithEvents Lbl_User_ID As System.Windows.Forms.Label
    Friend WithEvents Lbl_User_Name As System.Windows.Forms.Label
    Friend WithEvents Gb_Add_New_Employee As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_Position As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Appointed_Position As System.Windows.Forms.Label
    Friend WithEvents txt_Adhaar_No As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Adhaar_No As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Mob_No As System.Windows.Forms.Label
    Friend WithEvents txt_Mob_No As System.Windows.Forms.TextBox
    Friend WithEvents dtp_Join_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Join_Date As System.Windows.Forms.Label
    Friend WithEvents lbl_Address As System.Windows.Forms.Label
    Friend WithEvents txt_Address As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Employee_Id As System.Windows.Forms.Label
    Friend WithEvents txt_Employee_Id As System.Windows.Forms.TextBox
    Friend WithEvents lbl_first_Name As System.Windows.Forms.Label
    Friend WithEvents txt_First_Name As System.Windows.Forms.TextBox
End Class
