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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tb_Event_Package = New System.Windows.Forms.TextBox()
        Me.Tb_Event_Charges = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tb_Event_ID = New System.Windows.Forms.TextBox()
        Me.Lbl_Event_No = New System.Windows.Forms.Label()
        Me.Lbl_Event_Package = New System.Windows.Forms.Label()
        Me.Lbl_Event_Type = New System.Windows.Forms.Label()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.Btn_Browse = New System.Windows.Forms.Button()
        Me.Pb_Add_Photo = New System.Windows.Forms.PictureBox()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.Btn_Update_Event = New System.Windows.Forms.Button()
        Me.Cb_Event_Type = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.Pb_Add_Photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(723, 422)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 29)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Per Day"
        '
        'Tb_Event_Package
        '
        Me.Tb_Event_Package.Enabled = False
        Me.Tb_Event_Package.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Event_Package.Location = New System.Drawing.Point(348, 327)
        Me.Tb_Event_Package.Name = "Tb_Event_Package"
        Me.Tb_Event_Package.Size = New System.Drawing.Size(369, 45)
        Me.Tb_Event_Package.TabIndex = 4
        '
        'Tb_Event_Charges
        '
        Me.Tb_Event_Charges.Enabled = False
        Me.Tb_Event_Charges.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Event_Charges.Location = New System.Drawing.Point(348, 414)
        Me.Tb_Event_Charges.Name = "Tb_Event_Charges"
        Me.Tb_Event_Charges.Size = New System.Drawing.Size(369, 45)
        Me.Tb_Event_Charges.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Label2.Location = New System.Drawing.Point(144, 417)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 38)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Event Charges"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Panel1.Location = New System.Drawing.Point(-82, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1749, 119)
        Me.Panel1.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label1.Location = New System.Drawing.Point(546, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(640, 106)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Update Event"
        '
        'Tb_Event_ID
        '
        Me.Tb_Event_ID.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Tb_Event_ID.Location = New System.Drawing.Point(348, 165)
        Me.Tb_Event_ID.Name = "Tb_Event_ID"
        Me.Tb_Event_ID.Size = New System.Drawing.Size(369, 45)
        Me.Tb_Event_ID.TabIndex = 1
        '
        'Lbl_Event_No
        '
        Me.Lbl_Event_No.AutoSize = True
        Me.Lbl_Event_No.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Event_No.Location = New System.Drawing.Point(144, 165)
        Me.Lbl_Event_No.Name = "Lbl_Event_No"
        Me.Lbl_Event_No.Size = New System.Drawing.Size(107, 38)
        Me.Lbl_Event_No.TabIndex = 71
        Me.Lbl_Event_No.Text = "Event ID"
        '
        'Lbl_Event_Package
        '
        Me.Lbl_Event_Package.AutoSize = True
        Me.Lbl_Event_Package.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Event_Package.Location = New System.Drawing.Point(144, 327)
        Me.Lbl_Event_Package.Name = "Lbl_Event_Package"
        Me.Lbl_Event_Package.Size = New System.Drawing.Size(168, 38)
        Me.Lbl_Event_Package.TabIndex = 70
        Me.Lbl_Event_Package.Text = "Event Package"
        '
        'Lbl_Event_Type
        '
        Me.Lbl_Event_Type.AutoSize = True
        Me.Lbl_Event_Type.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Lbl_Event_Type.Location = New System.Drawing.Point(144, 248)
        Me.Lbl_Event_Type.Name = "Lbl_Event_Type"
        Me.Lbl_Event_Type.Size = New System.Drawing.Size(135, 38)
        Me.Lbl_Event_Type.TabIndex = 69
        Me.Lbl_Event_Type.Text = "Event Type"
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
        Me.Btn_Search.Location = New System.Drawing.Point(734, 169)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(100, 41)
        Me.Btn_Search.TabIndex = 2
        Me.Btn_Search.Text = "Search"
        Me.Btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Search.UseVisualStyleBackColor = False
        '
        'Btn_Browse
        '
        Me.Btn_Browse.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Btn_Browse.Enabled = False
        Me.Btn_Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Browse.Font = New System.Drawing.Font("Rockwell", 11.25!)
        Me.Btn_Browse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_Browse.Image = Global.WindowsApplication1.My.Resources.Resources.iconfinder_icon_101_folder_search_314678
        Me.Btn_Browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Browse.Location = New System.Drawing.Point(1094, 439)
        Me.Btn_Browse.Name = "Btn_Browse"
        Me.Btn_Browse.Size = New System.Drawing.Size(131, 43)
        Me.Btn_Browse.TabIndex = 6
        Me.Btn_Browse.Text = "   Browse"
        Me.Btn_Browse.UseVisualStyleBackColor = False
        '
        'Pb_Add_Photo
        '
        Me.Pb_Add_Photo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Pb_Add_Photo.Enabled = False
        Me.Pb_Add_Photo.Location = New System.Drawing.Point(850, 169)
        Me.Pb_Add_Photo.Name = "Pb_Add_Photo"
        Me.Pb_Add_Photo.Size = New System.Drawing.Size(595, 313)
        Me.Pb_Add_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pb_Add_Photo.TabIndex = 74
        Me.Pb_Add_Photo.TabStop = False
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Btn_Cancel.Enabled = False
        Me.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cancel.Font = New System.Drawing.Font("Rockwell", 24.0!)
        Me.Btn_Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Cancel.Image = Global.WindowsApplication1.My.Resources.Resources.close_icon
        Me.Btn_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cancel.Location = New System.Drawing.Point(793, 523)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(198, 54)
        Me.Btn_Cancel.TabIndex = 8
        Me.Btn_Cancel.Text = "Cancel   "
        Me.Btn_Cancel.UseVisualStyleBackColor = False
        '
        'Btn_Update_Event
        '
        Me.Btn_Update_Event.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Btn_Update_Event.Enabled = False
        Me.Btn_Update_Event.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Update_Event.Font = New System.Drawing.Font("Rockwell", 24.0!)
        Me.Btn_Update_Event.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Update_Event.Image = Global.WindowsApplication1.My.Resources.Resources.Other_Update_Metro_icon
        Me.Btn_Update_Event.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Update_Event.Location = New System.Drawing.Point(498, 523)
        Me.Btn_Update_Event.Name = "Btn_Update_Event"
        Me.Btn_Update_Event.Size = New System.Drawing.Size(275, 54)
        Me.Btn_Update_Event.TabIndex = 7
        Me.Btn_Update_Event.Text = "Update Event"
        Me.Btn_Update_Event.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Update_Event.UseVisualStyleBackColor = False
        '
        'Cb_Event_Type
        '
        Me.Cb_Event_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Event_Type.Enabled = False
        Me.Cb_Event_Type.Font = New System.Drawing.Font("Rockwell Condensed", 24.0!)
        Me.Cb_Event_Type.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Cb_Event_Type.FormattingEnabled = True
        Me.Cb_Event_Type.Items.AddRange(New Object() {"Birthday ", "Marriage ", "Party"})
        Me.Cb_Event_Type.Location = New System.Drawing.Point(348, 245)
        Me.Cb_Event_Type.MaxLength = 30
        Me.Cb_Event_Type.Name = "Cb_Event_Type"
        Me.Cb_Event_Type.Size = New System.Drawing.Size(369, 46)
        Me.Cb_Event_Type.TabIndex = 79
        '
        'Frm_Update_Event
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1584, 762)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cb_Event_Type)
        Me.Controls.Add(Me.Btn_Search)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Btn_Browse)
        Me.Controls.Add(Me.Tb_Event_Package)
        Me.Controls.Add(Me.Pb_Add_Photo)
        Me.Controls.Add(Me.Btn_Cancel)
        Me.Controls.Add(Me.Btn_Update_Event)
        Me.Controls.Add(Me.Tb_Event_Charges)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Tb_Event_ID)
        Me.Controls.Add(Me.Lbl_Event_No)
        Me.Controls.Add(Me.Lbl_Event_Package)
        Me.Controls.Add(Me.Lbl_Event_Type)
        Me.Name = "Frm_Update_Event"
        Me.Text = "Update Event"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Pb_Add_Photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Btn_Browse As System.Windows.Forms.Button
    Friend WithEvents Tb_Event_Package As System.Windows.Forms.TextBox
    Friend WithEvents Pb_Add_Photo As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents Btn_Update_Event As System.Windows.Forms.Button
    Friend WithEvents Tb_Event_Charges As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Tb_Event_ID As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Event_No As System.Windows.Forms.Label
    Friend WithEvents Lbl_Event_Package As System.Windows.Forms.Label
    Friend WithEvents Lbl_Event_Type As System.Windows.Forms.Label
    Friend WithEvents Btn_Search As System.Windows.Forms.Button
    Friend WithEvents Cb_Event_Type As System.Windows.Forms.ComboBox
End Class
