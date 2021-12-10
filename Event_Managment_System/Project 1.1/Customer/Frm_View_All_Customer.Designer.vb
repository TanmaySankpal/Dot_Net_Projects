<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_View_All_Customer
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
        Me.DG_View_All_Cust = New System.Windows.Forms.DataGridView()
        Me.Gb_Event_Detail = New System.Windows.Forms.GroupBox()
        Me.Btn_Refresh = New System.Windows.Forms.Button()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.Cb_Search_by = New System.Windows.Forms.ComboBox()
        Me.Tb_Bill_No = New System.Windows.Forms.TextBox()
        Me.Lbl_Bill_No = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Gb_View_Single_Customer.SuspendLayout()
        CType(Me.DG_View_All_Cust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_Event_Detail.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gb_View_Single_Customer
        '
        Me.Gb_View_Single_Customer.BackColor = System.Drawing.Color.Transparent
        Me.Gb_View_Single_Customer.Controls.Add(Me.DG_View_All_Cust)
        Me.Gb_View_Single_Customer.Controls.Add(Me.Gb_Event_Detail)
        Me.Gb_View_Single_Customer.Font = New System.Drawing.Font("Rockwell Condensed", 15.75!)
        Me.Gb_View_Single_Customer.ForeColor = System.Drawing.Color.Black
        Me.Gb_View_Single_Customer.Location = New System.Drawing.Point(28, 126)
        Me.Gb_View_Single_Customer.Name = "Gb_View_Single_Customer"
        Me.Gb_View_Single_Customer.Size = New System.Drawing.Size(1600, 700)
        Me.Gb_View_Single_Customer.TabIndex = 1
        Me.Gb_View_Single_Customer.TabStop = False
        Me.Gb_View_Single_Customer.Text = "#View Customer By"
        '
        'DG_View_All_Cust
        '
        Me.DG_View_All_Cust.AllowUserToAddRows = False
        Me.DG_View_All_Cust.AllowUserToDeleteRows = False
        Me.DG_View_All_Cust.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_View_All_Cust.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DG_View_All_Cust.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DG_View_All_Cust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_View_All_Cust.Location = New System.Drawing.Point(52, 139)
        Me.DG_View_All_Cust.Name = "DG_View_All_Cust"
        Me.DG_View_All_Cust.ReadOnly = True
        Me.DG_View_All_Cust.Size = New System.Drawing.Size(1484, 501)
        Me.DG_View_All_Cust.TabIndex = 2
        '
        'Gb_Event_Detail
        '
        Me.Gb_Event_Detail.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Gb_Event_Detail.Controls.Add(Me.Btn_Refresh)
        Me.Gb_Event_Detail.Controls.Add(Me.Btn_Search)
        Me.Gb_Event_Detail.Controls.Add(Me.Cb_Search_by)
        Me.Gb_Event_Detail.Controls.Add(Me.Tb_Bill_No)
        Me.Gb_Event_Detail.Controls.Add(Me.Lbl_Bill_No)
        Me.Gb_Event_Detail.ForeColor = System.Drawing.Color.Black
        Me.Gb_Event_Detail.Location = New System.Drawing.Point(52, 27)
        Me.Gb_Event_Detail.Name = "Gb_Event_Detail"
        Me.Gb_Event_Detail.Size = New System.Drawing.Size(1484, 102)
        Me.Gb_Event_Detail.TabIndex = 1
        Me.Gb_Event_Detail.TabStop = False
        '
        'Btn_Refresh
        '
        Me.Btn_Refresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Refresh.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Btn_Refresh.ForeColor = System.Drawing.Color.Cornsilk
        Me.Btn_Refresh.Image = Global.WindowsApplication1.My.Resources.Resources.update_icon
        Me.Btn_Refresh.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Btn_Refresh.Location = New System.Drawing.Point(1233, 43)
        Me.Btn_Refresh.Name = "Btn_Refresh"
        Me.Btn_Refresh.Size = New System.Drawing.Size(173, 42)
        Me.Btn_Refresh.TabIndex = 39
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
        Me.Btn_Search.Location = New System.Drawing.Point(1038, 41)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(173, 42)
        Me.Btn_Search.TabIndex = 38
        Me.Btn_Search.Text = "Search"
        Me.Btn_Search.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Search.UseVisualStyleBackColor = False
        '
        'Cb_Search_by
        '
        Me.Cb_Search_by.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Search_by.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Cb_Search_by.FormattingEnabled = True
        Me.Cb_Search_by.Items.AddRange(New Object() {"Customer ID", "Name", "Event Type", "Event Package"})
        Me.Cb_Search_by.Location = New System.Drawing.Point(295, 37)
        Me.Cb_Search_by.Name = "Cb_Search_by"
        Me.Cb_Search_by.Size = New System.Drawing.Size(253, 46)
        Me.Cb_Search_by.TabIndex = 37
        '
        'Tb_Bill_No
        '
        Me.Tb_Bill_No.Enabled = False
        Me.Tb_Bill_No.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Bill_No.Location = New System.Drawing.Point(614, 40)
        Me.Tb_Bill_No.Name = "Tb_Bill_No"
        Me.Tb_Bill_No.Size = New System.Drawing.Size(391, 45)
        Me.Tb_Bill_No.TabIndex = 34
        '
        'Lbl_Bill_No
        '
        Me.Lbl_Bill_No.AutoSize = True
        Me.Lbl_Bill_No.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Bill_No.Location = New System.Drawing.Point(114, 40)
        Me.Lbl_Bill_No.Name = "Lbl_Bill_No"
        Me.Lbl_Bill_No.Size = New System.Drawing.Size(137, 38)
        Me.Lbl_Bill_No.TabIndex = 18
        Me.Lbl_Bill_No.Text = "Select Type"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Panel1.Location = New System.Drawing.Point(-82, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1749, 119)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 72.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(567, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(874, 106)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "View All Customer"
        '
        'Frm_View_All_Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.engagement_event_management_500x500
        Me.ClientSize = New System.Drawing.Size(1584, 896)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Gb_View_Single_Customer)
        Me.Name = "Frm_View_All_Customer"
        Me.Text = "View All Customer"
        Me.Gb_View_Single_Customer.ResumeLayout(False)
        CType(Me.DG_View_All_Cust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_Event_Detail.ResumeLayout(False)
        Me.Gb_Event_Detail.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gb_View_Single_Customer As System.Windows.Forms.GroupBox
    Friend WithEvents Gb_Event_Detail As System.Windows.Forms.GroupBox
    Friend WithEvents Tb_Bill_No As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Bill_No As System.Windows.Forms.Label
    Friend WithEvents DG_View_All_Cust As System.Windows.Forms.DataGridView
    Friend WithEvents Cb_Search_by As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_Refresh As System.Windows.Forms.Button
    Friend WithEvents Btn_Search As System.Windows.Forms.Button
End Class
