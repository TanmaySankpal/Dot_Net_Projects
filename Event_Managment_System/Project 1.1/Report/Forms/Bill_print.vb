Public Class Frm_Bill_print

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Frm_Add_New_Customer.MdiParent = MDI_Main_Form
        Frm_Add_New_Customer.WindowState = FormWindowState.Maximized
        Frm_Add_New_Customer.Show()
    End Sub
End Class