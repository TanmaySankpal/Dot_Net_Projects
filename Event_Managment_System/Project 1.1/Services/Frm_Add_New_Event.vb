Imports System.Data.SqlClient

Public Class Frm_Add_New_Event

    Function clear_tb()
        Tb_Event_Charges.Text = ""
        Tb_Event_Category.Text = ""
        Cb_Event_Type.SelectedIndex = -1
        Pb_Add_Photo.Image = Nothing
        Return 1
    End Function

    Private Sub Frm_Add_New_Event_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tb_Event_ID.Text = Auto_Increment("select count(E_id)from DB_Table_Add_Event ", 100)
    End Sub

    Private Sub Tb_Event_Charges_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Event_Charges.KeyPress
        Charlock(e)
    End Sub

    Private Sub Btn_Add_Event_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Add_Event.Click
        Dim ms As New IO.MemoryStream

        getconnection()


        If Tb_Event_Category.Text = "" Or Tb_Event_Charges.Text = "" Or Cb_Event_Type.Text = "" Or Pb_Add_Photo.Image Is Nothing Then

            MessageBox.Show("Plese fill all the field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            Dim cmd As New SqlCommand("insert into DB_Table_Add_Event(E_id,E_Type,E_Category,E_Charges,E_Photo)values(@Tb_Event_ID,@Cb_Event_Type,@Tb_Event_Category,@Tb_Event_Charges,@Pb_Add_Photo)", connection)

            Pb_Add_Photo.Image.Save(ms, Pb_Add_Photo.Image.RawFormat)

            cmd.Parameters.Add("@Tb_Event_ID", SqlDbType.Int).Value = Tb_Event_ID.Text
            cmd.Parameters.Add("@Cb_Event_Type", SqlDbType.VarChar).Value = Cb_Event_Type.Text
            cmd.Parameters.Add("@Tb_Event_Category", SqlDbType.VarChar).Value = Tb_Event_Category.Text
            cmd.Parameters.Add("@Tb_Event_Charges", SqlDbType.Int).Value = Tb_Event_Charges.Text
            cmd.Parameters.Add("@Pb_Add_Photo", SqlDbType.Image).Value = ms.ToArray()


            If connection.State = ConnectionState.Closed Then
                getconnection()
            End If

            If cmd.ExecuteNonQuery() = 1 Then
                MessageBox.Show("New Event Added Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clear_tb()

                Tb_Event_ID.Text = Auto_Increment("select count(E_id)from DB_Table_Add_Event ", 100)
            Else
                MessageBox.Show("Not Save")

            End If
        End If
        terminateconnection()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Comman_Class.brows(Pb_Add_Photo.Image)
    End Sub

    Private Sub Btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancel.Click
        clear_tb()
    End Sub

    Private Sub Btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
    End Sub


End Class