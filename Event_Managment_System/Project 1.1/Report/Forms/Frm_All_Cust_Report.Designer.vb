<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_All_Cust_Report
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
        Me.CR_All_Cust_updated = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Btn_View_All = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tb_Search_1 = New System.Windows.Forms.TextBox()
        Me.Tb_Search_2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CR_All_Cust_updated
        '
        Me.CR_All_Cust_updated.ActiveViewIndex = -1
        Me.CR_All_Cust_updated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CR_All_Cust_updated.Cursor = System.Windows.Forms.Cursors.Default
        Me.CR_All_Cust_updated.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CR_All_Cust_updated.Location = New System.Drawing.Point(0, 86)
        Me.CR_All_Cust_updated.Name = "CR_All_Cust_updated"
        Me.CR_All_Cust_updated.ShowLogo = False
        Me.CR_All_Cust_updated.Size = New System.Drawing.Size(1584, 676)
        Me.CR_All_Cust_updated.TabIndex = 0
        Me.CR_All_Cust_updated.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Btn_View_All
        '
        Me.Btn_View_All.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_View_All.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_View_All.Location = New System.Drawing.Point(1101, 35)
        Me.Btn_View_All.Name = "Btn_View_All"
        Me.Btn_View_All.Size = New System.Drawing.Size(100, 36)
        Me.Btn_View_All.TabIndex = 33
        Me.Btn_View_All.Text = "View All"
        Me.Btn_View_All.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(796, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 24)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "to"
        '
        'Tb_Search_1
        '
        Me.Tb_Search_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Tb_Search_1.Location = New System.Drawing.Point(645, 36)
        Me.Tb_Search_1.Name = "Tb_Search_1"
        Me.Tb_Search_1.Size = New System.Drawing.Size(141, 29)
        Me.Tb_Search_1.TabIndex = 31
        '
        'Tb_Search_2
        '
        Me.Tb_Search_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Tb_Search_2.Location = New System.Drawing.Point(834, 37)
        Me.Tb_Search_2.Name = "Tb_Search_2"
        Me.Tb_Search_2.Size = New System.Drawing.Size(141, 29)
        Me.Tb_Search_2.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(445, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(205, 24)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "search by Customer ID."
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(984, 36)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 36)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "Search"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, -623)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1584, 709)
        Me.CrystalReportViewer1.TabIndex = 27
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Frm_All_Cust_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1584, 762)
        Me.Controls.Add(Me.Btn_View_All)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tb_Search_1)
        Me.Controls.Add(Me.Tb_Search_2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.CR_All_Cust_updated)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Frm_All_Cust_Report"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CR_All_Cust_updated As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Btn_View_All As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Tb_Search_1 As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Search_2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
