Imports System.Data.SqlClient
Public Class Frm_View_Single_Customer
    Dim dr As SqlDataReader
    Public id_search As Integer
    Public Event_Charges As Double
    Public Update_Cnt As Integer
    Function Clear()
        Tb_Bill_No.Text = ""
        clearAllTxtbo(Gb_Personal_Deatail)
        clearAllTxtbo(GroupBox1)
        Cb_Event_Package.SelectedIndex = -1
        Cb_Event_Type.SelectedIndex = -1
        Cb_No_Of_Persons.SelectedIndex = -1
        DTP_Start.Text = ""
        DTP_Stop.Text = ""
        DateTimePicker1.Text = ""
        Btn_Charges_Detail.Enabled = False
        Btn_Event_Detail.Enabled = False
        Btn_Update.Enabled = False
        Tb_Bill_No.Enabled = True
        Gb_Personal_Deatail.Enabled = False
        GroupBox1.Enabled = False
        Update_Cnt = 0
        Return 1
    End Function
    Private Sub Frm_View_Single_Customer_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        getconnection()
        If Tb_Bill_No.Text <> "" Then
            'cmd.Connection = connection
            cmd = New SqlCommand("select * from Tb_Personal_info where Cust_id = " + Tb_Bill_No.Text + "", connection)
            dr = cmd.ExecuteReader
            If dr.Read() Then
                Tb_Customer_Name.Text = dr("Cust_Name").ToString
                Tb_Adress.Text = dr("Cust_Address").ToString
                Tb_Mobile_Num_1.Text = dr("Cust_Mo_1").ToString
                Tb_Mobile_Num_2.Text = dr("Cust_Mo_2").ToString
                Tb_Event_Name.Text = dr("E_Name").ToString
                Cb_Event_Type.Text = dr("E_Type").ToString
                Cb_Event_Package.Text = dr("E_Package").ToString
                Cb_No_Of_Persons.Text = dr("E_NOP").ToString
                DateTimePicker1.Text = dr("E_Date").ToString
                DTP_Start.Text = dr("E_Time_Start").ToString
                DTP_Stop.Text = dr("E_Time_Stop").ToString
                dr.Close()
            End If
        End If
        terminateconnection()
    End Sub
    Private Sub Tb_Bill_No_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Bill_No.KeyPress
        Charlock(e)
    End Sub
    Private Sub Tb_Bill_No_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Bill_No.Leave
        If Tb_Bill_No.Text = "" Then
            Clear()
            Frm_View_S_Event_Detail.Book_clear()
        End If
    End Sub
    Private Sub Cb_Event_Type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Event_Type.SelectedIndexChanged
        getconnection()
        Dim command As New SqlCommand("select E_Category from DB_Table_Add_Event where E_Type= '" + Cb_Event_Type.Text + "' ", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        Cb_Event_Package.DataSource = table
        Cb_Event_Package.DisplayMember = "E_Category"
        terminateconnection()
    End Sub
    Private Sub Tb_Mobile_Num_1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Mobile_Num_1.KeyPress
        Charlock(e)
    End Sub
    Private Sub Tb_Mobile_Num_2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Mobile_Num_2.KeyPress
        Charlock(e)
    End Sub
    Private Sub Tb_Customer_Name_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Customer_Name.KeyPress
        Numlock(e)
    End Sub

    Private Sub Tb_Mobile_Num_1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Mobile_Num_1.Leave
        Mobile_No(Tb_Mobile_Num_1.TextLength)
    End Sub

    Private Sub Tb_Mobile_Num_2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Mobile_Num_2.Leave
        Mobile_No(Tb_Mobile_Num_1.TextLength)
    End Sub

    Private Sub Btn_Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Refresh.Click
        If Update_Cnt > 1 Then
            Dim Response_1 As MsgBoxResult

            Response_1 = MsgBox("Doesn't Refresh Without Saving Update,Are You Want Save....", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Confirm")

            If Response_1 = MsgBoxResult.Yes Then
                Frm_View_S_Event_Charges.MdiParent = MDI_Main_Form
                Frm_View_S_Event_Charges.WindowState = FormWindowState.Maximized
                Frm_View_S_Event_Charges.Show()

            ElseIf Response_1 = MsgBoxResult.No Then
                Me.Show()
            End If

        Else
            Clear()
        End If

    End Sub
    Private Sub Btn_Event_Detail_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Event_Detail.Click
        If Tb_Bill_No.Text = "" Then
            MessageBox.Show("Please Enter id to search..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Clear()
        Else
            Comman_Class.S_Cust_id = Tb_Bill_No.Text
            Me.Hide()
            Frm_View_S_Event_Detail.MdiParent = MDI_Main_Form
            Frm_View_S_Event_Detail.WindowState = FormWindowState.Maximized
            Frm_View_S_Event_Detail.Show()
        End If
    End Sub
    Private Sub Btn_Charges_Detail_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Charges_Detail.Click
        If Tb_Bill_No.Text = "" Then
            MessageBox.Show("Please Enter id to search..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Clear()
        Else
            Comman_Class.S_Cust_id = Tb_Bill_No.Text
            Me.Hide()
            Frm_View_S_Event_Charges.MdiParent = MDI_Main_Form
            Frm_View_S_Event_Charges.WindowState = FormWindowState.Maximized
            Frm_View_S_Event_Charges.Show()
        End If
    End Sub
    Private Sub Btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Search.Click
        getconnection()
        If Tb_Bill_No.Text = "" Then
            MessageBox.Show("Please Enter id to search..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            'cmd.Connection = connection
            cmd = New SqlCommand("select * from Tb_Personal_info where Cust_id = " + Tb_Bill_No.Text + "", connection)
            dr = cmd.ExecuteReader
            If dr.Read() Then
                Tb_Customer_Name.Text = dr("Cust_Name").ToString
                Tb_Adress.Text = dr("Cust_Address").ToString
                Tb_Mobile_Num_1.Text = dr("Cust_Mo_1").ToString
                Tb_Mobile_Num_2.Text = dr("Cust_Mo_2").ToString
                Tb_Event_Name.Text = dr("E_Name").ToString
                Cb_Event_Type.Text = dr("E_Type").ToString
                Cb_Event_Package.Text = dr("E_Package").ToString
                Cb_No_Of_Persons.Text = dr("E_NOP").ToString
                DateTimePicker1.Text = dr("E_Date").ToString
                DTP_Start.Text = dr("E_Time_Start").ToString
                DTP_Stop.Text = dr("E_Time_Stop").ToString
                id_search = Tb_Bill_No.Text
                dr.Close()
                Btn_Event_Detail.Enabled = True
                Btn_Charges_Detail.Enabled = True
                Btn_Update.Enabled = True

                Gb_Personal_Deatail.Enabled = True
                GroupBox1.Enabled = True
            Else
                MessageBox.Show("Record Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
        terminateconnection()
    End Sub
    Private Sub Btn_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Update.Click
        getconnection()
        cmd = New SqlCommand("Update Tb_Personal_info Set Cust_Name = '" + Tb_Customer_Name.Text + "',Cust_Address= '" + Tb_Adress.Text + "',Cust_Mo_1= " + Tb_Mobile_Num_1.Text + ",Cust_Mo_2= " + Tb_Mobile_Num_2.Text + ",E_Name='" + Tb_Event_Name.Text + "',E_Type='" + Cb_Event_Type.Text + "',E_Package='" + Cb_Event_Package.Text + "',E_NOP=" + Cb_No_Of_Persons.Text + ",E_Date='" + DateTimePicker1.Text + "',E_Time_Start='" + DTP_Start.Text + "',E_Time_Stop='" + DTP_Stop.Text + "' where Cust_id = " + Tb_Bill_No.Text + "", connection)
        cmd.ExecuteNonQuery()
        MsgBox("Record U Sucessfully")
        Update_Cnt = 2
        Dim dr As SqlDataReader

        Dim command As New SqlCommand("select E_Charges from DB_Table_Add_Event where E_Type= '" + Cb_Event_Type.Text + "' And E_Category = '" + Cb_Event_Package.Text + "' ", connection)
        dr = command.ExecuteReader
        Dim chrge As Double

        If dr.Read() Then
            chrge = dr("E_Charges").ToString

        End If
        Event_Charges = chrge
        dr.Close()
        command.Dispose()
        'chrge = 0

        cmd.Dispose()
        terminateconnection()
    End Sub

    Private Sub DateTimePicker1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.Leave
        getconnection()
        Dim dr As SqlDataReader
        cmd = New SqlCommand("SELECT E_Date FROM Tb_Personal_info", connection)
        dr = cmd.ExecuteReader
        While dr.Read
            If DateTimePicker1.Text = dr("E_Date") Then
                MsgBox("This Date is alrady booked....!")


            End If
        End While

        terminateconnection()
    End Sub
End Class