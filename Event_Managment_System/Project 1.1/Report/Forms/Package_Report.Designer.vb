<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Package_Report
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Cb_Event_Package = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cb_Event_Type = New System.Windows.Forms.ComboBox()
        Me.CRV_Package = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1020, 14)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 29)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(579, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 24)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Package Name:"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(906, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 29)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Cb_Event_Package
        '
        Me.Cb_Event_Package.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Cb_Event_Package.FormattingEnabled = True
        Me.Cb_Event_Package.Location = New System.Drawing.Point(726, 13)
        Me.Cb_Event_Package.Name = "Cb_Event_Package"
        Me.Cb_Event_Package.Size = New System.Drawing.Size(174, 32)
        Me.Cb_Event_Package.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(262, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 24)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Event Name:"
        '
        'Cb_Event_Type
        '
        Me.Cb_Event_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Cb_Event_Type.FormattingEnabled = True
        Me.Cb_Event_Type.Location = New System.Drawing.Point(399, 13)
        Me.Cb_Event_Type.Name = "Cb_Event_Type"
        Me.Cb_Event_Type.Size = New System.Drawing.Size(174, 32)
        Me.Cb_Event_Type.TabIndex = 30
        '
        'CRV_Package
        '
        Me.CRV_Package.ActiveViewIndex = -1
        Me.CRV_Package.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV_Package.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV_Package.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CRV_Package.Location = New System.Drawing.Point(0, 51)
        Me.CRV_Package.Name = "CRV_Package"
        Me.CRV_Package.Size = New System.Drawing.Size(1584, 711)
        Me.CRV_Package.TabIndex = 31
        '
        'Frm_Package_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1584, 762)
        Me.ControlBox = False
        Me.Controls.Add(Me.CRV_Package)
        Me.Controls.Add(Me.Cb_Event_Type)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cb_Event_Package)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Frm_Package_Report"
        Me.Text = "v"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Cb_Event_Package As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cb_Event_Type As System.Windows.Forms.ComboBox
    Friend WithEvents CRV_Package As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
