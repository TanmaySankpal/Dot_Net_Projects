Imports System.Data.SqlClient

Public Class Frm_View_All_Customer
    Private Sub Frm_View_All_Customer_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        getconnection()
        cmd = New SqlCommand("SELECT Tb_Personal_info.Cust_id, Tb_Personal_info.Cust_Name, Tb_Personal_info.Cust_Address, Tb_Personal_info.Cust_Mo_1, Tb_Personal_info.Cust_Mo_2,Tb_Personal_info.E_Name, Tb_Personal_info.E_Type, Tb_Personal_info.E_Package, Tb_Services.Venue, Tb_Services.V_Type,Tb_Services.M_Type, Tb_Services.M_Package, Tb_Services.D_Categary, Tb_Services.LM_Type FROM Tb_Personal_info FULL OUTER JOIN Tb_Services ON Tb_Personal_info.Cust_id = Tb_Services.Cust_id", connection)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()

        da.Fill(dt)
        DG_View_All_Cust.DataSource = dt

        cmd.Dispose()
        terminateconnection()
    End Sub
   
    Private Sub Cb_Search_by_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Search_by.Enter
        Tb_Bill_No.Text = ""
        Tb_Bill_No.Enabled = False
    End Sub

    Private Sub Tb_Bill_No_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Bill_No.KeyPress
        If Cb_Search_by.Text = "Customer ID" Then
            Charlock(e)
        End If
    End Sub

    Private Sub Btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Search.Click
        If Tb_Bill_No.Text = "" Then
            MessageBox.Show("Please Select type to search..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            getconnection()
            If Cb_Search_by.Text = "Customer ID" Then
                cmd = New SqlCommand("SELECT Tb_Personal_info.Cust_id, Tb_Personal_info.Cust_Name, Tb_Personal_info.Cust_Address, Tb_Personal_info.Cust_Mo_1, Tb_Personal_info.Cust_Mo_2,Tb_Personal_info.E_Name, Tb_Personal_info.E_Type, Tb_Personal_info.E_Package, Tb_Services.Venue, Tb_Services.V_Type, Tb_Services.M_Type,Tb_Services.M_Package, Tb_Services.D_Categary, Tb_Services.LM_Type FROM Tb_Personal_info FULL OUTER JOIN Tb_Services ON Tb_Personal_info.Cust_id = Tb_Services.Cust_id WHERE (Tb_Personal_info.Cust_id =" + Tb_Bill_No.Text + ")", connection)
            ElseIf Cb_Search_by.Text = "Name" Then
                cmd = New SqlCommand("SELECT Tb_Personal_info.Cust_id, Tb_Personal_info.Cust_Name, Tb_Personal_info.Cust_Address, Tb_Personal_info.Cust_Mo_1, Tb_Personal_info.Cust_Mo_2,Tb_Personal_info.E_Name, Tb_Personal_info.E_Type, Tb_Personal_info.E_Package, Tb_Services.Venue, Tb_Services.V_Type, Tb_Services.M_Type,Tb_Services.M_Package, Tb_Services.D_Categary, Tb_Services.LM_Type FROM Tb_Personal_info FULL OUTER JOIN Tb_Services ON Tb_Personal_info.Cust_id = Tb_Services.Cust_id WHERE (Tb_Personal_info.Cust_Name ='" + Tb_Bill_No.Text + "')", connection)
            ElseIf Cb_Search_by.Text = "Event Type" Then
                cmd = New SqlCommand("SELECT Tb_Personal_info.Cust_id, Tb_Personal_info.Cust_Name, Tb_Personal_info.Cust_Address, Tb_Personal_info.Cust_Mo_1, Tb_Personal_info.Cust_Mo_2,Tb_Personal_info.E_Name, Tb_Personal_info.E_Type, Tb_Personal_info.E_Package, Tb_Services.Venue, Tb_Services.V_Type, Tb_Services.M_Type,Tb_Services.M_Package, Tb_Services.D_Categary, Tb_Services.LM_Type FROM Tb_Personal_info FULL OUTER JOIN Tb_Services ON Tb_Personal_info.Cust_id = Tb_Services.Cust_id WHERE (Tb_Personal_info.E_Type ='" + Tb_Bill_No.Text + "')", connection)
            ElseIf Cb_Search_by.Text = "Event Package" Then
                cmd = New SqlCommand("SELECT Tb_Personal_info.Cust_id, Tb_Personal_info.Cust_Name, Tb_Personal_info.Cust_Address, Tb_Personal_info.Cust_Mo_1, Tb_Personal_info.Cust_Mo_2,Tb_Personal_info.E_Name, Tb_Personal_info.E_Type, Tb_Personal_info.E_Package, Tb_Services.Venue, Tb_Services.V_Type, Tb_Services.M_Type,Tb_Services.M_Package, Tb_Services.D_Categary, Tb_Services.LM_Type FROM Tb_Personal_info FULL OUTER JOIN Tb_Services ON Tb_Personal_info.Cust_id = Tb_Services.Cust_id WHERE (Tb_Personal_info.E_Package ='" + Tb_Bill_No.Text + "')", connection)

            Else
                MessageBox.Show("Record Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()

            da.Fill(dt)
            DG_View_All_Cust.DataSource = dt

            cmd.Dispose()
            terminateconnection()
        End If
    End Sub

    Private Sub Cb_Search_by_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Search_by.SelectedIndexChanged
        Tb_Bill_No.Enabled = True
        
    End Sub

    Private Sub Btn_Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Refresh.Click
        getconnection()
        cmd = New SqlCommand("SELECT Tb_Personal_info.Cust_id, Tb_Personal_info.Cust_Name, Tb_Personal_info.Cust_Address, Tb_Personal_info.Cust_Mo_1, Tb_Personal_info.Cust_Mo_2,Tb_Personal_info.E_Name, Tb_Personal_info.E_Type, Tb_Personal_info.E_Package, Tb_Services.Venue, Tb_Services.V_Type,Tb_Services.M_Type, Tb_Services.M_Package, Tb_Services.D_Categary, Tb_Services.LM_Type FROM Tb_Personal_info FULL OUTER JOIN Tb_Services ON Tb_Personal_info.Cust_id = Tb_Services.Cust_id", connection)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()

        da.Fill(dt)
        DG_View_All_Cust.DataSource = dt
        Cb_Search_by.SelectedIndex = -1
        Tb_Bill_No.Text = ""
        Tb_Bill_No.Enabled = False

        cmd.Dispose()
        terminateconnection()
    End Sub
End Class