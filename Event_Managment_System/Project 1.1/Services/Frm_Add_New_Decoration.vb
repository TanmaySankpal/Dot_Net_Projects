Imports System.Data.SqlClient

Public Class Frm_Add_New_Decoration

    Function clear_Tb()
        Tb_Decoration_Category.Text = ""
        Tb_Decoration_Charges.Text = ""
        Tb_Decoration_Type.Text = ""
        Pb_Decoration_Photo.Image = Nothing
        Return 1
    End Function

    Private Sub Frm_Add_New_Decoration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tb_Decoration_ID.Text = Auto_Increment("select count(D_ID)from DB_Table_Add_Decoration ", 100)

    End Sub

    Private Sub Tb_Decoration_Charges_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Decoration_Charges.KeyPress
        Charlock(e)
    End Sub

    Private Sub Btn_Browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Browse.Click
        Comman_Class.brows(Pb_Decoration_Photo.Image)
    End Sub

    Private Sub Btn_Menu_Event_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Menu_Event.Click
        Dim ms As New IO.MemoryStream

        getconnection()
        If Tb_Decoration_Category.Text = "" Or Tb_Decoration_Charges.Text = "" Or Tb_Decoration_Type.Text = "" Or Pb_Decoration_Photo.Image Is Nothing Then
            MessageBox.Show("Plese fill all the field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            Dim cmd As New SqlCommand("insert into DB_Table_Add_Decoration(D_id,D_Type,D_Category,D_Charges,D_Photo)values(@Tb_Decoration_ID,@Tb_Decoration_Type,@Tb_Decoration_Category,@Tb_Decoration_Charges,@Pb_Decoration_Photo)", connection)

            Pb_Decoration_Photo.Image.Save(ms, Pb_Decoration_Photo.Image.RawFormat)

            cmd.Parameters.Add("@Tb_Decoration_ID", SqlDbType.Int).Value = Tb_Decoration_ID.Text
            cmd.Parameters.Add("@Tb_Decoration_Type", SqlDbType.VarChar).Value = Tb_Decoration_Type.Text
            cmd.Parameters.Add("@Tb_Decoration_Category", SqlDbType.VarChar).Value = Tb_Decoration_Category.Text
            cmd.Parameters.Add("@Tb_Decoration_Charges", SqlDbType.Int).Value = Tb_Decoration_Charges.Text
            cmd.Parameters.Add("@Pb_Decoration_Photo", SqlDbType.Image).Value = ms.ToArray()


            If connection.State = ConnectionState.Closed Then
                getconnection()
            End If

            If cmd.ExecuteNonQuery() = 1 Then
                MessageBox.Show("New Decoration Added Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clear_Tb()
                Tb_Decoration_ID.Text = Auto_Increment("select count(D_ID)from DB_Table_Add_Decoration ", 100)


            Else
                MessageBox.Show("Not Save")

            End If
        End If
        terminateconnection()
    End Sub

    Private Sub Btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancel.Click
        clear_Tb()
    End Sub

End Class