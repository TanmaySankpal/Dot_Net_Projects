<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Update_Event
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
        Me.Btn_Browse = New System.Windows.Forms.Button()
        Me.Tb_Event_Category = New System.Windows.Forms.TextBox()
        Me.Pb_Add_Photo = New System.Windows.Forms.PictureBox()
        Me.Tb_Event_Type = New System.Windows.Forms.TextBox()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.Btn_Add_Event = New System.Windows.Forms.Button()
        Me.Tb_Event_Charges = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tb_Event_ID = New System.Windows.Forms.TextBox()
        Me.Lbl_Event_Categary = New System.Windows.Forms.Label()
        Me.Lbl_Event_No = New System.Windows.Forms.Label()
        Me.Lbl_Event_Type = New System.Windows.Forms.Label()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.Tb_Bill_No = New System.Windows.Forms.TextBox()
        Me.Lbl_Bill_No = New System.Windows.Forms.Label()
        CType(Me.Pb_Add_Photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_Browse
        '
        Me.Btn_Browse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Browse.Location = New System.Drawing.Point(1070, 500)
        Me.Btn_Browse.Name = "Btn_Browse"
        Me.Btn_Browse.Size = New System.Drawing.Size(131, 43)
        Me.Btn_Browse.TabIndex = 70
        Me.Btn_Browse.Text = "Browse"
        Me.Btn_Browse.UseVisualStyleBackColor = True
        '
        'Tb_Event_Category
        '
        Me.Tb_Event_Category.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Event_Category.Location = New System.Drawing.Point(348, 386)
        Me.Tb_Event_Category.Name = "Tb_Event_Category"
        Me.Tb_Event_Category.Size = New System.Drawing.Size(391, 49)
        Me.Tb_Event_Category.TabIndex = 60
        '
        'Pb_Add_Photo
        '
        Me.Pb_Add_Photo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Pb_Add_Photo.Location = New System.Drawing.Point(840, 166)
        Me.Pb_Add_Photo.Name = "Pb_Add_Photo"
        Me.Pb_Add_Photo.Size = New System.Drawing.Size(595, 313)
        Me.Pb_Add_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pb_Add_Photo.TabIndex = 69
        Me.Pb_Add_Photo.TabStop = False
        '
        'Tb_Event_Type
        '
        Me.Tb_Event_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Event_Type.Location = New System.Drawing.Point(348, 307)
        Me.Tb_Event_Type.Name = "Tb_Event_Type"
        Me.Tb_Event_Type.Size = New System.Drawing.Size(391, 49)
        Me.Tb_Event_Type.TabIndex = 59
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Bold)
        Me.Btn_Cancel.Location = New System.Drawing.Point(684, 582)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(198, 54)
        Me.Btn_Cancel.TabIndex = 63
        Me.Btn_Cancel.Text = "Cancel"
        Me.Btn_Cancel.UseVisualStyleBackColor = True
        '
        'Btn_Add_Event
        '
        Me.Btn_Add_Event.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Bold)
        Me.Btn_Add_Event.Location = New System.Drawing.Point(371, 582)
        Me.Btn_Add_Event.Name = "Btn_Add_Event"
        Me.Btn_Add_Event.Size = New System.Drawing.Size(198, 54)
        Me.Btn_Add_Event.TabIndex = 62
        Me.Btn_Add_Event.Text = "Update"
        Me.Btn_Add_Event.UseVisualStyleBackColor = True
        '
        'Tb_Event_Charges
        '
        Me.Tb_Event_Charges.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Event_Charges.Location = New System.Drawing.Point(348, 473)
        Me.Tb_Event_Charges.Name = "Tb_Event_Charges"
        Me.Tb_Event_Charges.Size = New System.Drawing.Size(391, 49)
        Me.Tb_Event_Charges.TabIndex = 61
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(87, 473)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 38)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Event Charges"
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
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 71.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label1.Location = New System.Drawing.Point(539, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(580, 98)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Update Event"
        '
        'Tb_Event_ID
        '
        Me.Tb_Event_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Event_ID.Location = New System.Drawing.Point(348, 224)
        Me.Tb_Event_ID.Name = "Tb_Event_ID"
        Me.Tb_Event_ID.Size = New System.Drawing.Size(391, 49)
        Me.Tb_Event_ID.TabIndex = 58
        '
        'Lbl_Event_Categary
        '
        Me.Lbl_Event_Categary.AutoSize = True
        Me.Lbl_Event_Categary.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Event_Categary.Location = New System.Drawing.Point(87, 386)
        Me.Lbl_Event_Categary.Name = "Lbl_Event_Categary"
        Me.Lbl_Event_Categary.Size = New System.Drawing.Size(258, 38)
        Me.Lbl_Event_Categary.TabIndex = 65
        Me.Lbl_Event_Categary.Text = "Event Category"
        '
        'Lbl_Event_No
        '
        Me.Lbl_Event_No.AutoSize = True
        Me.Lbl_Event_No.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Event_No.Location = New System.Drawing.Point(87, 224)
        Me.Lbl_Event_No.Name = "Lbl_Event_No"
        Me.Lbl_Event_No.Size = New System.Drawing.Size(166, 38)
        Me.Lbl_Event_No.TabIndex = 66
        Me.Lbl_Event_No.Text = "Event ID"
        '
        'Lbl_Event_Type
        '
        Me.Lbl_Event_Type.AutoSize = True
        Me.Lbl_Event_Type.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Event_Type.Location = New System.Drawing.Point(87, 307)
        Me.Lbl_Event_Type.Name = "Lbl_Event_Type"
        Me.Lbl_Event_Type.Size = New System.Drawing.Size(199, 38)
        Me.Lbl_Event_Type.TabIndex = 64
        Me.Lbl_Event_Type.Text = "Event Type"
        '
        'Btn_Search
        '
        Me.Btn_Search.Location = New System.Drawing.Point(761, 152)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(57, 42)
        Me.Btn_Search.TabIndex = 73
        Me.Btn_Search.Text = "Search"
        Me.Btn_Search.UseVisualStyleBackColor = True
        '
        'Tb_Bill_No
        '
        Me.Tb_Bill_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Bill_No.Location = New System.Drawing.Point(348, 148)
        Me.Tb_Bill_No.Name = "Tb_Bill_No"
        Me.Tb_Bill_No.Size = New System.Drawing.Size(391, 49)
        Me.Tb_Bill_No.TabIndex = 72
        '
        'Lbl_Bill_No
        '
        Me.Lbl_Bill_No.AutoSize = True
        Me.Lbl_Bill_No.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Bill_No.Location = New System.Drawing.Point(87, 152)
        Me.Lbl_Bill_No.Name = "Lbl_Bill_No"
        Me.Lbl_Bill_No.Size = New System.Drawing.Size(166, 38)
        Me.Lbl_Bill_No.TabIndex = 71
        Me.Lbl_Bill_No.Text = "Event ID"
        '
        'Frm_Update_Event
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1584, 762)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_Search)
        Me.Controls.Add(Me.Tb_Bill_No)
        Me.Controls.Add(Me.Lbl_Bill_No)
        Me.Controls.Add(Me.Btn_Browse)
        Me.Controls.Add(Me.Tb_Event_Category)
        Me.Controls.Add(Me.Pb_Add_Photo)
        Me.Controls.Add(Me.Tb_Event_Type)
        Me.Controls.Add(Me.Btn_Cancel)
        Me.Controls.Add(Me.Btn_Add_Event)
        Me.Controls.Add(Me.Tb_Event_Charges)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Tb_Event_ID)
        Me.Controls.Add(Me.Lbl_Event_Categary)
        Me.Controls.Add(Me.Lbl_Event_No)
        Me.Controls.Add(Me.Lbl_Event_Type)
        Me.Name = "Frm_Update_Event"
        Me.Text = "Frm Update Event"
        CType(Me.Pb_Add_Photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Browse As System.Windows.Forms.Button
    Friend WithEvents Tb_Event_Category As System.Windows.Forms.TextBox
    Friend WithEvents Pb_Add_Photo As System.Windows.Forms.PictureBox
    Friend WithEvents Tb_Event_Type As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents Btn_Add_Event As System.Windows.Forms.Button
    Friend WithEvents Tb_Event_Charges As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Tb_Event_ID As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Event_Categary As System.Windows.Forms.Label
    Friend WithEvents Lbl_Event_No As System.Windows.Forms.Label
    Friend WithEvents Lbl_Event_Type As System.Windows.Forms.Label
    Friend WithEvents Btn_Search As System.Windows.Forms.Button
    Friend WithEvents Tb_Bill_No As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Bill_No As System.Windows.Forms.Label
End Class
