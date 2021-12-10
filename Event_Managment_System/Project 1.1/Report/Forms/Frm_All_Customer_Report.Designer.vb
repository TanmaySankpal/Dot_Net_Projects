<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_All_Customer_Report
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tb_Search_2 = New System.Windows.Forms.TextBox()
        Me.Tb_Search_1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_View_All = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 53)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1584, 709)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(984, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 36)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(484, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "search by Bill No."
        '
        'Tb_Search_2
        '
        Me.Tb_Search_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Tb_Search_2.Location = New System.Drawing.Point(834, 24)
        Me.Tb_Search_2.Name = "Tb_Search_2"
        Me.Tb_Search_2.Size = New System.Drawing.Size(141, 29)
        Me.Tb_Search_2.TabIndex = 6
        '
        'Tb_Search_1
        '
        Me.Tb_Search_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Tb_Search_1.Location = New System.Drawing.Point(645, 23)
        Me.Tb_Search_1.Name = "Tb_Search_1"
        Me.Tb_Search_1.Size = New System.Drawing.Size(141, 29)
        Me.Tb_Search_1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(796, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "to"
        '
        'Btn_View_All
        '
        Me.Btn_View_All.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_View_All.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_View_All.Location = New System.Drawing.Point(1101, 22)
        Me.Btn_View_All.Name = "Btn_View_All"
        Me.Btn_View_All.Size = New System.Drawing.Size(100, 36)
        Me.Btn_View_All.TabIndex = 9
        Me.Btn_View_All.Text = "View All"
        Me.Btn_View_All.UseVisualStyleBackColor = True
        '
        'Frm_All_Customer_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1584, 762)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_View_All)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tb_Search_1)
        Me.Controls.Add(Me.Tb_Search_2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "Frm_All_Customer_Report"
        Me.Text = "Frm_All_Customer_Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Tb_Search_2 As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Search_1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_View_All As System.Windows.Forms.Button
End Class
