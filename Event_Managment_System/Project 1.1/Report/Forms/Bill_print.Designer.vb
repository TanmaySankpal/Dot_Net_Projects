<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Bill_print
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
        Me.CRV_Bill_Print = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CRV_Bill_Print
        '
        Me.CRV_Bill_Print.ActiveViewIndex = -1
        Me.CRV_Bill_Print.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV_Bill_Print.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV_Bill_Print.Dock = System.Windows.Forms.DockStyle.Top
        Me.CRV_Bill_Print.Location = New System.Drawing.Point(0, 0)
        Me.CRV_Bill_Print.Name = "CRV_Bill_Print"
        Me.CRV_Bill_Print.Size = New System.Drawing.Size(1584, 687)
        Me.CRV_Bill_Print.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(717, 701)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(413, 55)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Frm_Bill_print
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1584, 762)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CRV_Bill_Print)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Bill_print"
        Me.Text = "Bill_print"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRV_Bill_Print As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
