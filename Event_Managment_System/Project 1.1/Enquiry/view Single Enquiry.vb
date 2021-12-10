Imports System.Data.SqlClient

Public Class Frm_view_Single_Enquiry
    Dim dr As SqlDataReader
    Dim cmd As New SqlCommand
    Function clear()
        Tb_Customer_ID.Text = ""
        Tb_Customer_Name.Text = ""
        Tb_Mobile_Num_1.Text = ""
        Tb_Mobile_Num_2.Text = ""
        Tb_Adress.Text = ""
        Cb_Event_Package.Text = ""
        Cb_Event_Type.SelectedIndex = -1
        RichTextBox1.Text = ""
        DateTimePicker1.Text = ""

        Tb_Customer_Name.Enabled = False
        Tb_Mobile_Num_1.Enabled = False
        Tb_Mobile_Num_2.Enabled = False
        Tb_Adress.Enabled = False
        Cb_Event_Package.Enabled = False
        Cb_Event_Type.Enabled = False
        RichTextBox1.Enabled = False
        DateTimePicker1.Enabled = False
        Btn_Refresh.Enabled = False
        Btn_Update.Enabled = False
        Btn_Search.Enabled = True
        Return 1
    End Function

    Private Sub Frm_view_Single_Enquiry_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Btn_Refresh.PerformClick()
        getconnection()
        Dim command As New SqlCommand("select Distinct(E_Type) from DB_Table_Add_Event", connection)

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        Cb_Event_Type.DataSource = table

        Cb_Event_Type.DisplayMember = "E_Type"
        terminateconnection()
    End Sub

    Private Sub Tb_Customer_ID_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Customer_ID.Leave
        If Tb_Customer_ID.Text = "" Then
            clear()
        End If
    End Sub

    Private Sub Tb_Mobile_Num_1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Mobile_Num_1.KeyPress
        Charlock(e)
    End Sub

    Private Sub Tb_Mobile_Num_2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Mobile_Num_2.KeyPress
        Charlock(e)
    End Sub

    Private Sub Tb_Customer_ID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Customer_ID.KeyPress
        Charlock(e)
    End Sub

    Private Sub Tb_Mobile_Num_1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Mobile_Num_1.Leave
        Mobile_No(Tb_Mobile_Num_1.TextLength)
    End Sub

    Private Sub Tb_Mobile_Num_2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Mobile_Num_2.Leave
        Mobile_No(Tb_Mobile_Num_2.TextLength)
    End Sub

    Private Sub Tb_Customer_Name_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Customer_Name.KeyPress
        Numlock(e)
    End Sub

    Private Sub Btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Search.Click
        getconnection()

        If Tb_Customer_ID.Text = "" Then
            MessageBox.Show("Please Enter id to search..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            cmd.Connection = connection
            cmd.CommandText = "select * from  Tb_Enquiry  where Eq_ID = " + Tb_Customer_ID.Text + " "

            dr = cmd.ExecuteReader

            If dr.Read() Then

                Tb_Customer_Name.Text = dr("Eq_Name").ToString
                Tb_Mobile_Num_1.Text = dr("Eq_Mob_1").ToString
                Tb_Mobile_Num_2.Text = dr("Eq_Mob_2").ToString
                Tb_Adress.Text = dr("Eq_Address").ToString
                Cb_Event_Type.Text = dr("E_Type").ToString
                Cb_Event_Package.Text = dr("E_Package").ToString
                RichTextBox1.Text = dr("Suggetion").ToString
                DateTimePicker1.Text = dr("E_Date").ToString


                Tb_Customer_Name.Enabled = True
                Tb_Mobile_Num_1.Enabled = True
                Tb_Mobile_Num_2.Enabled = True
                Tb_Adress.Enabled = True
                Cb_Event_Package.Enabled = True
                Cb_Event_Type.Enabled = True
                RichTextBox1.Enabled = True
                DateTimePicker1.Enabled = True
                Btn_Refresh.Enabled = True
                Btn_Update.Enabled = True
                GroupBox1.Enabled = True
                'Btn_Search.Enabled = False        

            Else
                MessageBox.Show("Record Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
        terminateconnection()
    End Sub

    Private Sub Btn_Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Refresh.Click
        clear()
        Btn_Search.Enabled = True
    End Sub

    Private Sub Btn_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Update.Click
        If Tb_Mobile_Num_2.Text = "" Then
            Tb_Mobile_Num_2.Text = 0
        End If

        getconnection()
        If Tb_Adress.Text = "" Or Tb_Customer_Name.Text = "" Or Tb_Mobile_Num_1.Text = "" Or Cb_Event_Package.Text = "" Or Cb_Event_Type.Text = "" Then
            MessageBox.Show("Plese fill all the field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim cmd As New SqlCommand("update Tb_Enquiry Set Eq_Name='" + Tb_Customer_Name.Text + "',Eq_Address='" + Tb_Adress.Text + "',Eq_Mob_1=" + Tb_Mobile_Num_1.Text + ",Eq_Mob_2=" + Tb_Mobile_Num_2.Text + ",E_Type='" + Cb_Event_Type.Text + "',E_Package='" + Cb_Event_Package.Text + "',E_Date='" + DateTimePicker1.Text + "',Suggetion='" + RichTextBox1.Text + "' Where Eq_ID=" + Tb_Customer_ID.Text + "", connection)

            If connection.State = ConnectionState.Closed Then
                getconnection()
            End If

            If cmd.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Update Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clear()

            Else
                MessageBox.Show("Not Save")

            End If
        End If
        terminateconnection()
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
End Class