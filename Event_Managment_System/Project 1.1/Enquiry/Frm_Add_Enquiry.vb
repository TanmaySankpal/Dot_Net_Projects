Imports System.Data.SqlClient

Public Class Frm_Add_Enquiry
    Function clear()
        Tb_Customer_Name.Text = ""
        Tb_Mobile_Num_1.Text = ""
        Tb_Mobile_Num_2.Text = ""
        Tb_Adress.Text = ""
        Cb_Event_Package.SelectedIndex = -1
        Cb_Event_Type.SelectedIndex = -1
        RichTextBox1.Text = ""
        DateTimePicker1.Text = ""
        Return 1
    End Function

    Private Sub Frm_Add_Enquiry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getconnection()

        Dim command As New SqlCommand("select Distinct(E_Type) from DB_Table_Add_Event", connection)

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()
        Tb_Customer_ID.Text = Auto_Increment("select count(Eq_ID)from Tb_Enquiry ", 1001)


        adapter.Fill(table)

        Cb_Event_Type.DataSource = table

        Cb_Event_Type.DisplayMember = "E_Type"

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


    Private Sub Tb_Mobile_Num_1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Mobile_Num_1.KeyPress
        Charlock(e)
    End Sub

    Private Sub Tb_Mobile_Num_2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Mobile_Num_2.KeyPress
        Charlock(e)
    End Sub

    Private Sub Tb_Customer_ID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Customer_ID.KeyPress
        Charlock(e)
    End Sub

    Private Sub Tb_Customer_Name_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Customer_Name.KeyPress
        Numlock(e)
    End Sub

    Private Sub Tb_Mobile_Num_1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Mobile_Num_1.Leave
        Mobile_No(Tb_Mobile_Num_1.TextLength)
    End Sub

    Private Sub Tb_Mobile_Num_2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Mobile_Num_2.Leave
        Mobile_No(Tb_Mobile_Num_2.TextLength)
    End Sub

    Private Sub Btn_Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Refresh.Click
        clear()
    End Sub

    Private Sub Btn_Add_Enquiry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Add_Enquiry.Click
        If Tb_Mobile_Num_2.Text = "" Then
            Tb_Mobile_Num_2.Text = 0
        End If

        getconnection()
        If Tb_Adress.Text = "" Or Tb_Customer_Name.Text = "" Or Tb_Mobile_Num_1.Text = "" Or Cb_Event_Package.Text = "" Or Cb_Event_Type.Text = "" Then
            MessageBox.Show("Plese fill all the field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim cmd As New SqlCommand("insert into Tb_Enquiry values(" + Tb_Customer_ID.Text + ",'" + Tb_Customer_Name.Text + "','" + Tb_Adress.Text + "'," + Tb_Mobile_Num_1.Text + "," + Tb_Mobile_Num_2.Text + ",'" + Cb_Event_Type.Text + "','" + Cb_Event_Package.Text + "','" + DateTimePicker1.Text + "','" + RichTextBox1.Text + "') ", connection)

            If connection.State = ConnectionState.Closed Then
                getconnection()
            End If

            If cmd.ExecuteNonQuery() = 1 Then
                MessageBox.Show("New Enquiry Added Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clear()
                Tb_Customer_ID.Text = Auto_Increment("select count(Eq_ID)from Tb_Enquiry ", 1001)

            Else
                MessageBox.Show("Not Save")

            End If
        End If
        terminateconnection()
    End Sub

    End Class