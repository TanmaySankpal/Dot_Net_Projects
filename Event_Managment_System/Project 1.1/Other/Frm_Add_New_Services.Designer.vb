<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Add_New_Services
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cb_NOP_Dinner = New System.Windows.Forms.ComboBox()
        Me.Cb_NOP_Lunch = New System.Windows.Forms.ComboBox()
        Me.Cb_NOP_Breakfast = New System.Windows.Forms.ComboBox()
        Me.Lbl_No_Of_People = New System.Windows.Forms.Label()
        Me.Chkb_Dinner = New System.Windows.Forms.CheckBox()
        Me.Chkb_Lunch = New System.Windows.Forms.CheckBox()
        Me.Chkb_Breakfast = New System.Windows.Forms.CheckBox()
        Me.Cb_Menu_Categary = New System.Windows.Forms.ComboBox()
        Me.Cb_Menu_Type = New System.Windows.Forms.ComboBox()
        Me.Lbl_Menu_Categary = New System.Windows.Forms.Label()
        Me.Lbl_Menu_Type = New System.Windows.Forms.Label()
        Me.Tb_Event_No = New System.Windows.Forms.TextBox()
        Me.Lbl_Event_No = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1584, 862)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Cb_NOP_Dinner)
        Me.TabPage1.Controls.Add(Me.Cb_NOP_Lunch)
        Me.TabPage1.Controls.Add(Me.Cb_NOP_Breakfast)
        Me.TabPage1.Controls.Add(Me.Lbl_No_Of_People)
        Me.TabPage1.Controls.Add(Me.Chkb_Dinner)
        Me.TabPage1.Controls.Add(Me.Chkb_Lunch)
        Me.TabPage1.Controls.Add(Me.Chkb_Breakfast)
        Me.TabPage1.Controls.Add(Me.Cb_Menu_Categary)
        Me.TabPage1.Controls.Add(Me.Cb_Menu_Type)
        Me.TabPage1.Controls.Add(Me.Lbl_Menu_Categary)
        Me.TabPage1.Controls.Add(Me.Lbl_Menu_Type)
        Me.TabPage1.Controls.Add(Me.Tb_Event_No)
        Me.TabPage1.Controls.Add(Me.Lbl_Event_No)
        Me.TabPage1.Location = New System.Drawing.Point(4, 47)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1576, 811)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Add Menu Services"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Violet
        Me.GroupBox1.Location = New System.Drawing.Point(42, 386)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1451, 353)
        Me.GroupBox1.TabIndex = 76
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "All Menu"
        '
        'Cb_NOP_Dinner
        '
        Me.Cb_NOP_Dinner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_NOP_Dinner.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.Cb_NOP_Dinner.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Cb_NOP_Dinner.FormattingEnabled = True
        Me.Cb_NOP_Dinner.Items.AddRange(New Object() {"50", "100", "150", "200", "400", "800", "1000"})
        Me.Cb_NOP_Dinner.Location = New System.Drawing.Point(687, 329)
        Me.Cb_NOP_Dinner.Name = "Cb_NOP_Dinner"
        Me.Cb_NOP_Dinner.Size = New System.Drawing.Size(106, 47)
        Me.Cb_NOP_Dinner.TabIndex = 75
        '
        'Cb_NOP_Lunch
        '
        Me.Cb_NOP_Lunch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_NOP_Lunch.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.Cb_NOP_Lunch.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Cb_NOP_Lunch.FormattingEnabled = True
        Me.Cb_NOP_Lunch.Items.AddRange(New Object() {"50", "100", "150", "200", "400", "800", "1000"})
        Me.Cb_NOP_Lunch.Location = New System.Drawing.Point(530, 329)
        Me.Cb_NOP_Lunch.Name = "Cb_NOP_Lunch"
        Me.Cb_NOP_Lunch.Size = New System.Drawing.Size(106, 47)
        Me.Cb_NOP_Lunch.TabIndex = 74
        '
        'Cb_NOP_Breakfast
        '
        Me.Cb_NOP_Breakfast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_NOP_Breakfast.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.Cb_NOP_Breakfast.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Cb_NOP_Breakfast.FormattingEnabled = True
        Me.Cb_NOP_Breakfast.Items.AddRange(New Object() {"50", "100", "150", "200", "400", "800", "1000"})
        Me.Cb_NOP_Breakfast.Location = New System.Drawing.Point(336, 324)
        Me.Cb_NOP_Breakfast.Name = "Cb_NOP_Breakfast"
        Me.Cb_NOP_Breakfast.Size = New System.Drawing.Size(106, 47)
        Me.Cb_NOP_Breakfast.TabIndex = 73
        '
        'Lbl_No_Of_People
        '
        Me.Lbl_No_Of_People.AutoSize = True
        Me.Lbl_No_Of_People.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Bold)
        Me.Lbl_No_Of_People.Location = New System.Drawing.Point(45, 324)
        Me.Lbl_No_Of_People.Name = "Lbl_No_Of_People"
        Me.Lbl_No_Of_People.Size = New System.Drawing.Size(228, 38)
        Me.Lbl_No_Of_People.TabIndex = 72
        Me.Lbl_No_Of_People.Text = "No.Of People"
        '
        'Chkb_Dinner
        '
        Me.Chkb_Dinner.AutoSize = True
        Me.Chkb_Dinner.Location = New System.Drawing.Point(687, 281)
        Me.Chkb_Dinner.Name = "Chkb_Dinner"
        Me.Chkb_Dinner.Size = New System.Drawing.Size(151, 42)
        Me.Chkb_Dinner.TabIndex = 71
        Me.Chkb_Dinner.Text = "Dinner"
        Me.Chkb_Dinner.UseVisualStyleBackColor = True
        '
        'Chkb_Lunch
        '
        Me.Chkb_Lunch.AutoSize = True
        Me.Chkb_Lunch.Location = New System.Drawing.Point(530, 281)
        Me.Chkb_Lunch.Name = "Chkb_Lunch"
        Me.Chkb_Lunch.Size = New System.Drawing.Size(141, 42)
        Me.Chkb_Lunch.TabIndex = 70
        Me.Chkb_Lunch.Text = "Lunch"
        Me.Chkb_Lunch.UseVisualStyleBackColor = True
        '
        'Chkb_Breakfast
        '
        Me.Chkb_Breakfast.AutoSize = True
        Me.Chkb_Breakfast.Location = New System.Drawing.Point(333, 281)
        Me.Chkb_Breakfast.Name = "Chkb_Breakfast"
        Me.Chkb_Breakfast.Size = New System.Drawing.Size(191, 42)
        Me.Chkb_Breakfast.TabIndex = 69
        Me.Chkb_Breakfast.Text = "Breakfast"
        Me.Chkb_Breakfast.UseVisualStyleBackColor = True
        '
        'Cb_Menu_Categary
        '
        Me.Cb_Menu_Categary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Menu_Categary.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.Cb_Menu_Categary.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Cb_Menu_Categary.FormattingEnabled = True
        Me.Cb_Menu_Categary.Items.AddRange(New Object() {"Regular", "Premium", "Platinum"})
        Me.Cb_Menu_Categary.Location = New System.Drawing.Point(333, 215)
        Me.Cb_Menu_Categary.Name = "Cb_Menu_Categary"
        Me.Cb_Menu_Categary.Size = New System.Drawing.Size(460, 47)
        Me.Cb_Menu_Categary.TabIndex = 68
        '
        'Cb_Menu_Type
        '
        Me.Cb_Menu_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Menu_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.Cb_Menu_Type.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Cb_Menu_Type.FormattingEnabled = True
        Me.Cb_Menu_Type.Items.AddRange(New Object() {"Vegitarian", "Non-Vegitarian", "Vegitarian & Non-Vegitarian"})
        Me.Cb_Menu_Type.Location = New System.Drawing.Point(333, 144)
        Me.Cb_Menu_Type.Name = "Cb_Menu_Type"
        Me.Cb_Menu_Type.Size = New System.Drawing.Size(460, 47)
        Me.Cb_Menu_Type.TabIndex = 67
        '
        'Lbl_Menu_Categary
        '
        Me.Lbl_Menu_Categary.AutoSize = True
        Me.Lbl_Menu_Categary.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Menu_Categary.Location = New System.Drawing.Point(45, 228)
        Me.Lbl_Menu_Categary.Name = "Lbl_Menu_Categary"
        Me.Lbl_Menu_Categary.Size = New System.Drawing.Size(222, 34)
        Me.Lbl_Menu_Categary.TabIndex = 66
        Me.Lbl_Menu_Categary.Text = "Menu Category"
        '
        'Lbl_Menu_Type
        '
        Me.Lbl_Menu_Type.AutoSize = True
        Me.Lbl_Menu_Type.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Menu_Type.Location = New System.Drawing.Point(45, 155)
        Me.Lbl_Menu_Type.Name = "Lbl_Menu_Type"
        Me.Lbl_Menu_Type.Size = New System.Drawing.Size(182, 36)
        Me.Lbl_Menu_Type.TabIndex = 65
        Me.Lbl_Menu_Type.Text = "Menu Type"
        '
        'Tb_Event_No
        '
        Me.Tb_Event_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Event_No.Location = New System.Drawing.Point(333, 67)
        Me.Tb_Event_No.Name = "Tb_Event_No"
        Me.Tb_Event_No.Size = New System.Drawing.Size(460, 49)
        Me.Tb_Event_No.TabIndex = 64
        '
        'Lbl_Event_No
        '
        Me.Lbl_Event_No.AutoSize = True
        Me.Lbl_Event_No.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Event_No.Location = New System.Drawing.Point(54, 67)
        Me.Lbl_Event_No.Name = "Lbl_Event_No"
        Me.Lbl_Event_No.Size = New System.Drawing.Size(163, 38)
        Me.Lbl_Event_No.TabIndex = 63
        Me.Lbl_Event_No.Text = "Menu ID"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 47)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1576, 811)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Add Decoration Services"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 47)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1576, 811)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Frm_Add_New_Services
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1584, 862)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Frm_Add_New_Services"
        Me.Text = "Add New Services"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Tb_Event_No As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Event_No As System.Windows.Forms.Label
    Friend WithEvents Cb_NOP_Dinner As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_NOP_Lunch As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_NOP_Breakfast As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_No_Of_People As System.Windows.Forms.Label
    Friend WithEvents Chkb_Dinner As System.Windows.Forms.CheckBox
    Friend WithEvents Chkb_Lunch As System.Windows.Forms.CheckBox
    Friend WithEvents Chkb_Breakfast As System.Windows.Forms.CheckBox
    Friend WithEvents Cb_Menu_Categary As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_Menu_Type As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_Menu_Categary As System.Windows.Forms.Label
    Friend WithEvents Lbl_Menu_Type As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
End Class
