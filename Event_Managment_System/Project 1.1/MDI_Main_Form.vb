Imports System.Windows.Forms

Public Class MDI_Main_Form
    Private Sub AddCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddCustomerToolStripMenuItem.Click
        Frm_Add_New_Customer.MdiParent = Me
        Frm_Add_New_Customer.WindowState = FormWindowState.Maximized
        Frm_Add_New_Customer.Show()

    End Sub

    Private Sub UpdadeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdadeToolStripMenuItem.Click
        Frm_View_Single_Customer.MdiParent = Me
        Frm_View_Single_Customer.WindowState = FormWindowState.Maximized
        Frm_View_Single_Customer.Show()

    End Sub
End Class
