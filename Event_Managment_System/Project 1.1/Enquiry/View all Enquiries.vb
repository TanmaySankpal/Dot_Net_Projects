Imports System.Data.SqlClient
Public Class Frm_View_all_Enquiries
    Private Sub Frm_View_all_Enquiries_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        getconnection()
        Cb_Search_By.SelectedIndex = -1
        Tb_Bill_No.Text = ""
        Tb_Bill_No.Enabled = False
        cmd = New SqlCommand("Select * from Tb_Enquiry", connection)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()

        da.Fill(dt)
        DG_View_All_Enquires.DataSource = dt

        cmd.Dispose()
        terminateconnection()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Search_By.SelectedIndexChanged
        Tb_Bill_No.Enabled = True

    End Sub
    Private Sub Btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Search.Click
        If Tb_Bill_No.Text = "" Then
            MessageBox.Show("Please Select type to search..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            getconnection()
            If Cb_Search_By.Text = "Enquiry ID" Then
                cmd = New SqlCommand("SELECT Tb_Enquiry.Eq_ID,Tb_Enquiry.Eq_Name,Tb_Enquiry.Eq_Address,Tb_Enquiry.Eq_Mob_1,Tb_Enquiry.Eq_Mob_2,Tb_Enquiry.E_Type,Tb_Enquiry.E_Package,Tb_Enquiry.E_Date,Tb_Enquiry.Suggetion from Tb_Enquiry WHERE (Tb_Enquiry.Eq_ID =" + Tb_Bill_No.Text + ")", connection)
            ElseIf Cb_Search_By.Text = "Name" Then
                cmd = New SqlCommand("SELECT Tb_Enquiry.Eq_ID,Tb_Enquiry.Eq_Name,Tb_Enquiry.Eq_Address,Tb_Enquiry.Eq_Mob_1,Tb_Enquiry.Eq_Mob_2,Tb_Enquiry.E_Type,Tb_Enquiry.E_Package,Tb_Enquiry.E_Date,Tb_Enquiry.Suggetion from Tb_Enquiry WHERE (Tb_Enquiry.Eq_Name ='" + Tb_Bill_No.Text + "')", connection)
            ElseIf Cb_Search_By.Text = "Event Type" Then
                cmd = New SqlCommand("SELECT Tb_Enquiry.Eq_ID,Tb_Enquiry.Eq_Name,Tb_Enquiry.Eq_Address,Tb_Enquiry.Eq_Mob_1,Tb_Enquiry.Eq_Mob_2,Tb_Enquiry.E_Type,Tb_Enquiry.E_Package,Tb_Enquiry.E_Date,Tb_Enquiry.Suggetion from Tb_Enquiry WHERE (Tb_Enquiry.E_Type ='" + Tb_Bill_No.Text + "')", connection)
            ElseIf Cb_Search_By.Text = "Event Package" Then
                cmd = New SqlCommand("SELECT Tb_Enquiry.Eq_ID,Tb_Enquiry.Eq_Name,Tb_Enquiry.Eq_Address,Tb_Enquiry.Eq_Mob_1,Tb_Enquiry.Eq_Mob_2,Tb_Enquiry.E_Type,Tb_Enquiry.E_Package,Tb_Enquiry.E_Date,Tb_Enquiry.Suggetion from Tb_Enquiry WHERE (Tb_Enquiry.E_Package ='" + Tb_Bill_No.Text + "')", connection)

            Else
                MessageBox.Show("Record Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()

            da.Fill(dt)
            DG_View_All_Enquires.DataSource = dt

            cmd.Dispose()
            terminateconnection()
        End If
    End Sub
    Private Sub Btn_Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Refresh.Click

        getconnection()
        cmd = New SqlCommand("Select * from Tb_Enquiry", connection)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()

        da.Fill(dt)
        DG_View_All_Enquires.DataSource = dt
        Cb_Search_By.SelectedIndex = -1
        Tb_Bill_No.Text = ""
        Tb_Bill_No.Enabled = False


        cmd.Dispose()
        terminateconnection()
    End Sub

    Private Sub Tb_Bill_No_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Bill_No.KeyPress
        If Cb_Search_By.Text = "Enquiry ID" Then
            Charlock(e)
        End If
    End Sub

    Private Sub Cb_Search_By_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Search_By.Enter
        Tb_Bill_No.Text = ""
        Tb_Bill_No.Enabled = False

    End Sub
End Class