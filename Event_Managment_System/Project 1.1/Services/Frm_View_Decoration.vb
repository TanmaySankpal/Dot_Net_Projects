Imports System.Data.SqlClient
Imports System.IO
Public Class Frm_View_Decoration
    Private Sub Frm_View_Decoration_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Dim cmd As New SqlCommand
        Dim connection As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Project1.1;Integrated Security=True")
        connection.Open()
        Dim x As Integer = 100
        Dim y As Integer = 150
        Dim cnt As Integer = 1
        Dim dr As SqlDataReader
        Dim ms As New MemoryStream
        Dim cm As New SqlCommand("select * from DB_Table_Add_Decoration", connection)
        dr = cm.ExecuteReader()
        While dr.Read()
            Dim obj = New UC_View_Decoration
            obj.Location = New System.Drawing.Point(x, y)
            obj.Tb_Event_Category.Text = dr("D_Category").ToString
            obj.Tb_Event_Type.Text = dr("D_Type").ToString
            obj.Tb_Event_Charges.Text = dr("D_Charges").ToString
            obj.Pb_UC_Picture.Image = Comman_Class.view(dr("D_Photo"))
            Me.Controls.Add(obj)
            x = x + 500
            cnt = cnt + 1
            If cnt > 3 Then
                cnt = 1
                y = y + 500
                x = 100
            End If
        End While
        connection.Close()
    End Sub
    Private Sub Frm_View_Decoration_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        Me.Controls.Clear()

        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1584, 119)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 71.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label1.Location = New System.Drawing.Point(539, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(705, 98)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "View Decoration"
        '
        'Frm_View_Decoration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1584, 762)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_View_Decoration"
        Me.Text = "View Decoration"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

End Class