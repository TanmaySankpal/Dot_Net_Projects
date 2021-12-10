<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Update_User
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
        Me.Lbl_Match = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_Not_Match = New System.Windows.Forms.Label()
        Me.lbl_Join_Date = New System.Windows.Forms.Label()
        Me.dtp_Join_Date = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txt_Mob_No = New System.Windows.Forms.TextBox()
        Me.Btn_View = New System.Windows.Forms.Button()
        Me.Cb_User_Role = New System.Windows.Forms.ComboBox()
        Me.lbl_Mob_No = New System.Windows.Forms.Label()
        Me.Tb_Confirm_Pass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_Address = New System.Windows.Forms.Label()
        Me.txt_Address = New System.Windows.Forms.TextBox()
        Me.Tb_User_Name = New System.Windows.Forms.TextBox()
        Me.lbl_first_Name = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tb_Password = New System.Windows.Forms.TextBox()
        Me.Lbl_Pass = New System.Windows.Forms.Label()
        Me.Tb_User_ID = New System.Windows.Forms.TextBox()
        Me.Lbl_User_Role = New System.Windows.Forms.Label()
        Me.Lbl_User_ID = New System.Windows.Forms.Label()
        Me.Lbl_User_Name = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Gb_Add_New_Employee = New System.Windows.Forms.GroupBox()
        Me.cmb_Position = New System.Windows.Forms.ComboBox()
        Me.lbl_Appointed_Position = New System.Windows.Forms.Label()
        Me.txt_Adhaar_No = New System.Windows.Forms.TextBox()
        Me.lbl_Adhaar_No = New System.Windows.Forms.Label()
        Me.txt_First_Name = New System.Windows.Forms.TextBox()
        Me.Gb_Add_New_User = New System.Windows.Forms.GroupBox()
        Me.lbl_Employee_Id = New System.Windows.Forms.Label()
        Me.txt_Employee_Id = New System.Windows.Forms.TextBox()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.Btn_Add_User = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Gb_Add_New_Employee.SuspendLayout()
        Me.Gb_Add_New_User.SuspendLayout()
        Me.SuspendLayout()
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Panel1.Location = New System.Drawing.Point(-98, -7)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2331, 146)
        Me.Panel1.TabIndex = 119
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
        Me.Label1.Size = New System.Drawing.Size(936, 98)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Update Employee/User"
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
        'lbl_Join_Date
        '
        Me.lbl_Join_Date.AutoSize = True
        Me.lbl_Join_Date.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.lbl_Join_Date.Location = New System.Drawing.Point(73, 166)
        Me.lbl_Join_Date.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Join_Date.Name = "lbl_Join_Date"
        Me.lbl_Join_Date.Size = New System.Drawing.Size(142, 38)
        Me.lbl_Join_Date.TabIndex = 167
        Me.lbl_Join_Date.Text = "Joining Date"
        '
        'dtp_Join_Date
        '
        Me.dtp_Join_Date.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.dtp_Join_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Join_Date.Location = New System.Drawing.Point(254, 159)
        Me.dtp_Join_Date.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_Join_Date.Name = "dtp_Join_Date"
        Me.dtp_Join_Date.Size = New System.Drawing.Size(486, 45)
        Me.dtp_Join_Date.TabIndex = 165
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.TextBox1.Location = New System.Drawing.Point(254, 275)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.MaxLength = 10
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(482, 39)
        Me.TextBox1.TabIndex = 169
        '
        'txt_Mob_No
        '
        Me.txt_Mob_No.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Mob_No.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.txt_Mob_No.Location = New System.Drawing.Point(254, 222)
        Me.txt_Mob_No.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Mob_No.MaxLength = 10
        Me.txt_Mob_No.Multiline = True
        Me.txt_Mob_No.Name = "txt_Mob_No"
        Me.txt_Mob_No.Size = New System.Drawing.Size(482, 39)
        Me.txt_Mob_No.TabIndex = 166
        '
        'Btn_View
        '
        Me.Btn_View.BackColor = System.Drawing.SystemColors.Window
        Me.Btn_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_View.Location = New System.Drawing.Point(635, 352)
        Me.Btn_View.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_View.Name = "Btn_View"
        Me.Btn_View.Size = New System.Drawing.Size(100, 45)
        Me.Btn_View.TabIndex = 124
        Me.Btn_View.Text = "View"
        Me.Btn_View.UseVisualStyleBackColor = False
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
        Me.Cb_User_Role.TabIndex = 115
        '
        'lbl_Mob_No
        '
        Me.lbl_Mob_No.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Mob_No.AutoSize = True
        Me.lbl_Mob_No.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.lbl_Mob_No.Location = New System.Drawing.Point(55, 225)
        Me.lbl_Mob_No.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Mob_No.Name = "lbl_Mob_No"
        Me.lbl_Mob_No.Size = New System.Drawing.Size(171, 38)
        Me.lbl_Mob_No.TabIndex = 168
        Me.lbl_Mob_No.Text = "Mobile Number"
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
        Me.Tb_Confirm_Pass.TabIndex = 123
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
        'lbl_Address
        '
        Me.lbl_Address.AutoSize = True
        Me.lbl_Address.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.lbl_Address.Location = New System.Drawing.Point(73, 101)
        Me.lbl_Address.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Address.Name = "lbl_Address"
        Me.lbl_Address.Size = New System.Drawing.Size(96, 38)
        Me.lbl_Address.TabIndex = 164
        Me.lbl_Address.Text = "Address"
        '
        'txt_Address
        '
        Me.txt_Address.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.txt_Address.Location = New System.Drawing.Point(249, 96)
        Me.txt_Address.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Address.Multiline = True
        Me.txt_Address.Name = "txt_Address"
        Me.txt_Address.Size = New System.Drawing.Size(495, 43)
        Me.txt_Address.TabIndex = 163
        '
        'Tb_User_Name
        '
        Me.Tb_User_Name.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_User_Name.Location = New System.Drawing.Point(251, 139)
        Me.Tb_User_Name.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_User_Name.MaxLength = 10
        Me.Tb_User_Name.Name = "Tb_User_Name"
        Me.Tb_User_Name.Size = New System.Drawing.Size(480, 45)
        Me.Tb_User_Name.TabIndex = 114
        '
        'lbl_first_Name
        '
        Me.lbl_first_Name.AutoSize = True
        Me.lbl_first_Name.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.lbl_first_Name.Location = New System.Drawing.Point(66, 27)
        Me.lbl_first_Name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_first_Name.Name = "lbl_first_Name"
        Me.lbl_first_Name.Size = New System.Drawing.Size(179, 38)
        Me.lbl_first_Name.TabIndex = 162
        Me.lbl_first_Name.Text = "Employee Name"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Label4.Location = New System.Drawing.Point(219, 225)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 38)
        Me.Label4.TabIndex = 170
        Me.Label4.Text = "1."
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
        Me.Tb_Password.TabIndex = 117
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
        Me.Tb_User_ID.TabIndex = 116
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
        Me.Lbl_User_ID.Location = New System.Drawing.Point(128, 54)
        Me.Lbl_User_ID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_User_ID.Name = "Lbl_User_ID"
        Me.Lbl_User_ID.Size = New System.Drawing.Size(95, 38)
        Me.Lbl_User_ID.TabIndex = 120
        Me.Lbl_User_ID.Text = "User ID"
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
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Label2.Location = New System.Drawing.Point(219, 276)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 38)
        Me.Label2.TabIndex = 171
        Me.Label2.Text = "2."
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
        Me.Gb_Add_New_Employee.Controls.Add(Me.lbl_first_Name)
        Me.Gb_Add_New_Employee.Controls.Add(Me.txt_First_Name)
        Me.Gb_Add_New_Employee.Enabled = False
        Me.Gb_Add_New_Employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Gb_Add_New_Employee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_Add_New_Employee.ForeColor = System.Drawing.Color.DarkBlue
        Me.Gb_Add_New_Employee.Location = New System.Drawing.Point(23, 219)
        Me.Gb_Add_New_Employee.Name = "Gb_Add_New_Employee"
        Me.Gb_Add_New_Employee.Size = New System.Drawing.Size(765, 469)
        Me.Gb_Add_New_Employee.TabIndex = 121
        Me.Gb_Add_New_Employee.TabStop = False
        Me.Gb_Add_New_Employee.Text = "#Update Employee"
        '
        'cmb_Position
        '
        Me.cmb_Position.BackColor = System.Drawing.Color.RoyalBlue
        Me.cmb_Position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Position.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.cmb_Position.FormattingEnabled = True
        Me.cmb_Position.Items.AddRange(New Object() {"Admin/Owner", "Manager", "Receptionist", "Worker"})
        Me.cmb_Position.Location = New System.Drawing.Point(258, 411)
        Me.cmb_Position.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_Position.Name = "cmb_Position"
        Me.cmb_Position.Size = New System.Drawing.Size(482, 46)
        Me.cmb_Position.TabIndex = 173
        '
        'lbl_Appointed_Position
        '
        Me.lbl_Appointed_Position.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Appointed_Position.AutoSize = True
        Me.lbl_Appointed_Position.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.lbl_Appointed_Position.Location = New System.Drawing.Point(46, 411)
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
        Me.txt_Adhaar_No.Location = New System.Drawing.Point(253, 338)
        Me.txt_Adhaar_No.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Adhaar_No.MaxLength = 12
        Me.txt_Adhaar_No.Name = "txt_Adhaar_No"
        Me.txt_Adhaar_No.Size = New System.Drawing.Size(482, 45)
        Me.txt_Adhaar_No.TabIndex = 172
        '
        'lbl_Adhaar_No
        '
        Me.lbl_Adhaar_No.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Adhaar_No.AutoSize = True
        Me.lbl_Adhaar_No.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.lbl_Adhaar_No.Location = New System.Drawing.Point(20, 341)
        Me.lbl_Adhaar_No.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Adhaar_No.Name = "lbl_Adhaar_No"
        Me.lbl_Adhaar_No.Size = New System.Drawing.Size(230, 38)
        Me.lbl_Adhaar_No.TabIndex = 174
        Me.lbl_Adhaar_No.Text = "Adhaar/Pan Number"
        '
        'txt_First_Name
        '
        Me.txt_First_Name.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.txt_First_Name.Location = New System.Drawing.Point(249, 24)
        Me.txt_First_Name.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_First_Name.Name = "txt_First_Name"
        Me.txt_First_Name.Size = New System.Drawing.Size(495, 45)
        Me.txt_First_Name.TabIndex = 160
        '
        'Gb_Add_New_User
        '
        Me.Gb_Add_New_User.Controls.Add(Me.Lbl_Not_Match)
        Me.Gb_Add_New_User.Controls.Add(Me.Lbl_Match)
        Me.Gb_Add_New_User.Controls.Add(Me.Btn_View)
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
        Me.Gb_Add_New_User.Location = New System.Drawing.Point(804, 156)
        Me.Gb_Add_New_User.Name = "Gb_Add_New_User"
        Me.Gb_Add_New_User.Size = New System.Drawing.Size(767, 539)
        Me.Gb_Add_New_User.TabIndex = 120
        Me.Gb_Add_New_User.TabStop = False
        Me.Gb_Add_New_User.Text = "#Update User"
        '
        'lbl_Employee_Id
        '
        Me.lbl_Employee_Id.AutoSize = True
        Me.lbl_Employee_Id.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.lbl_Employee_Id.Location = New System.Drawing.Point(90, 170)
        Me.lbl_Employee_Id.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Employee_Id.Name = "lbl_Employee_Id"
        Me.lbl_Employee_Id.Size = New System.Drawing.Size(145, 38)
        Me.lbl_Employee_Id.TabIndex = 163
        Me.lbl_Employee_Id.Text = "Employee ID"
        '
        'txt_Employee_Id
        '
        Me.txt_Employee_Id.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.txt_Employee_Id.Location = New System.Drawing.Point(273, 167)
        Me.txt_Employee_Id.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Employee_Id.Name = "txt_Employee_Id"
        Me.txt_Employee_Id.Size = New System.Drawing.Size(392, 45)
        Me.txt_Employee_Id.TabIndex = 162
        '
        'Btn_Search
        '
        Me.Btn_Search.BackColor = System.Drawing.SystemColors.Window
        Me.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Search.Location = New System.Drawing.Point(665, 167)
        Me.Btn_Search.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(100, 45)
        Me.Btn_Search.TabIndex = 164
        Me.Btn_Search.Text = "Search"
        Me.Btn_Search.UseVisualStyleBackColor = False
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Btn_Cancel.Enabled = False
        Me.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cancel.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Btn_Cancel.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_Cancel.Image = Global.WindowsApplication1.My.Resources.Resources.close_icon3
        Me.Btn_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cancel.Location = New System.Drawing.Point(804, 704)
        Me.Btn_Cancel.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(147, 66)
        Me.Btn_Cancel.TabIndex = 118
        Me.Btn_Cancel.Text = "Refresh"
        Me.Btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancel.UseVisualStyleBackColor = False
        '
        'Btn_Add_User
        '
        Me.Btn_Add_User.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Btn_Add_User.Enabled = False
        Me.Btn_Add_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Add_User.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Btn_Add_User.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_Add_User.Image = Global.WindowsApplication1.My.Resources.Resources.add_icon4
        Me.Btn_Add_User.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Add_User.Location = New System.Drawing.Point(481, 704)
        Me.Btn_Add_User.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Add_User.Name = "Btn_Add_User"
        Me.Btn_Add_User.Size = New System.Drawing.Size(307, 66)
        Me.Btn_Add_User.TabIndex = 117
        Me.Btn_Add_User.Text = "Update Employee/User"
        Me.Btn_Add_User.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Add_User.UseVisualStyleBackColor = False
        '
        'Frm_Update_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1584, 762)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_Search)
        Me.Controls.Add(Me.lbl_Employee_Id)
        Me.Controls.Add(Me.txt_Employee_Id)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Gb_Add_New_Employee)
        Me.Controls.Add(Me.Gb_Add_New_User)
        Me.Controls.Add(Me.Btn_Cancel)
        Me.Controls.Add(Me.Btn_Add_User)
        Me.Name = "Frm_Update_User"
        Me.Text = "Update User"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Gb_Add_New_Employee.ResumeLayout(False)
        Me.Gb_Add_New_Employee.PerformLayout()
        Me.Gb_Add_New_User.ResumeLayout(False)
        Me.Gb_Add_New_User.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Match As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Not_Match As System.Windows.Forms.Label
    Friend WithEvents lbl_Join_Date As System.Windows.Forms.Label
    Friend WithEvents dtp_Join_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Mob_No As System.Windows.Forms.TextBox
    Friend WithEvents Btn_View As System.Windows.Forms.Button
    Friend WithEvents Cb_User_Role As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Mob_No As System.Windows.Forms.Label
    Friend WithEvents Tb_Confirm_Pass As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_Address As System.Windows.Forms.Label
    Friend WithEvents txt_Address As System.Windows.Forms.TextBox
    Friend WithEvents Tb_User_Name As System.Windows.Forms.TextBox
    Friend WithEvents lbl_first_Name As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Tb_Password As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Pass As System.Windows.Forms.Label
    Friend WithEvents Tb_User_ID As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_User_Role As System.Windows.Forms.Label
    Friend WithEvents Lbl_User_ID As System.Windows.Forms.Label
    Friend WithEvents Lbl_User_Name As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Gb_Add_New_Employee As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_Position As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Appointed_Position As System.Windows.Forms.Label
    Friend WithEvents txt_Adhaar_No As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Adhaar_No As System.Windows.Forms.Label
    Friend WithEvents txt_First_Name As System.Windows.Forms.TextBox
    Friend WithEvents Gb_Add_New_User As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents Btn_Add_User As System.Windows.Forms.Button
    Friend WithEvents lbl_Employee_Id As System.Windows.Forms.Label
    Friend WithEvents txt_Employee_Id As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Search As System.Windows.Forms.Button
End Class
