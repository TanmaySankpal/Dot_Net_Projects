Imports System.Data.SqlClient

Public Class Frm_Add_New_Menu
    Function clar_textbox()
        Tb_Menu_Category.Text = ""
        Cb_Menu_Type.SelectedIndex = -1
        Pb_Menu_Photo.Image = Nothing
        Tb_Breakfast_Charges.Text = ""
        Tb_IceCream_Charges.Text = ""
        Tb_Sweet_Charges.Text = ""
        Return 0
    End Function


    Private Sub Btn_Browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Browse.Click
        Comman_Class.brows(Pb_Menu_Photo.Image)
    End Sub

    Private Sub Btn_Menu_Event_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Menu_Event.Click
        Dim ms As New IO.MemoryStream

        getconnection()

        If Tb_Menu_Category.Text = "" Or Cb_Menu_Type.Text = "" Or Pb_Menu_Photo.Image Is Nothing Or Tb_Breakfast_Charges.Text = "" Or Tb_Vg_Starter_Charges.Text = "" Or Tb_NVg_Starter_Charges.Text = "" Or Tb_Vg_Lunch_Charges.Text = "" Or Tb_NVg_Lunch_Charges.Text = "" Or Tb_Vg_Dinner_Charges.Text = "" Or Tb_NVg_Dinner_Charges.Text = "" Or Tb_IceCream_Charges.Text = "" Or Tb_Sweet_Charges.Text = "" Then
            MessageBox.Show("Plese fill all the field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            Dim cmd As New SqlCommand("insert into DB_Table_Add_Menu values(@Tb_Menu_ID,@Cb_Menu_Type,@Tb_Menu_Category,@Pb_Menu_Photo,@Tb_Breakfast_Charges,@Tb_Vg_Starter_Charges,@Tb_NVg_Starter_Charges,@Tb_Vg_Lunch_Charges,@Tb_NVg_Lunch_Charges,@Tb_Vg_Dinner_Charges,@Tb_NVg_Dinner_Charges,@Tb_Sweet_Charges,@Tb_IceCream_Charges)", connection)

            Pb_Menu_Photo.Image.Save(ms, Pb_Menu_Photo.Image.RawFormat)

            cmd.Parameters.Add("@Tb_Menu_ID", SqlDbType.Int).Value = Tb_Menu_ID.Text
            cmd.Parameters.Add("@Cb_Menu_Type", SqlDbType.VarChar).Value = Cb_Menu_Type.Text
            cmd.Parameters.Add("@Tb_Menu_Category", SqlDbType.VarChar).Value = Tb_Menu_Category.Text
            cmd.Parameters.Add("@Pb_Menu_Photo", SqlDbType.Image).Value = ms.ToArray()
            cmd.Parameters.Add("@Tb_Breakfast_Charges", SqlDbType.Money).Value = Tb_Breakfast_Charges.Text
            cmd.Parameters.Add("@Tb_Vg_Starter_Charges", SqlDbType.Money).Value = Tb_Vg_Starter_Charges.Text
            cmd.Parameters.Add("@Tb_NVg_Starter_Charges", SqlDbType.Money).Value = Tb_NVg_Starter_Charges.Text
            cmd.Parameters.Add("@Tb_Vg_Lunch_Charges", SqlDbType.Money).Value = Tb_Vg_Lunch_Charges.Text
            cmd.Parameters.Add("@Tb_NVg_Lunch_Charges", SqlDbType.Money).Value = Tb_NVg_Lunch_Charges.Text
            cmd.Parameters.Add("@Tb_Vg_Dinner_Charges", SqlDbType.Money).Value = Tb_Vg_Dinner_Charges.Text
            cmd.Parameters.Add("@Tb_NVg_Dinner_Charges", SqlDbType.Money).Value = Tb_NVg_Dinner_Charges.Text
            cmd.Parameters.Add("@Tb_Sweet_Charges", SqlDbType.Money).Value = Tb_Sweet_Charges.Text
            cmd.Parameters.Add("@Tb_IceCream_Charges", SqlDbType.Money).Value = Tb_IceCream_Charges.Text

            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            If cmd.ExecuteNonQuery() = 1 Then
                MessageBox.Show("New Menu Added Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)

                clar_textbox()
                Tb_Menu_ID.Text = Auto_Increment("select count(M_ID)from DB_Table_Add_Menu ", 100)
            Else
                MessageBox.Show("Not Save")

            End If
        End If
        terminateconnection()

    End Sub

    Private Sub Btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancel.Click
       clar_textbox()

    End Sub

    Private Sub Frm_Add_New_Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tb_Menu_ID.Text = Auto_Increment("select count(M_ID)from DB_Table_Add_Menu ", 100)

    End Sub

    Private Sub Cb_Menu_Type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Menu_Type.SelectedIndexChanged
        If Cb_Menu_Type.Text = "Vegitarian" Then

            Tb_NVg_Dinner_Charges.Enabled = False
            Tb_NVg_Lunch_Charges.Enabled = False
            Tb_NVg_Starter_Charges.Enabled = False
            Tb_NVg_Dinner_Charges.Text = "0"
            Tb_NVg_Lunch_Charges.Text = "0"
            Tb_NVg_Starter_Charges.Text = "0"

            Tb_Vg_Dinner_Charges.Enabled = True
            Tb_Vg_Lunch_Charges.Enabled = True
            Tb_Vg_Starter_Charges.Enabled = True
            Tb_Vg_Dinner_Charges.Text = ""
            Tb_Vg_Lunch_Charges.Text = ""
            Tb_Vg_Starter_Charges.Text = ""

        ElseIf Cb_Menu_Type.Text = "Non-Vegitarian" Then
            Tb_Vg_Dinner_Charges.Enabled = False
            Tb_Vg_Lunch_Charges.Enabled = False
            Tb_Vg_Starter_Charges.Enabled = False
            Tb_Vg_Dinner_Charges.Text = "0"
            Tb_Vg_Lunch_Charges.Text = "0"
            Tb_Vg_Starter_Charges.Text = "0"

            Tb_NVg_Dinner_Charges.Enabled = True
            Tb_NVg_Lunch_Charges.Enabled = True
            Tb_NVg_Starter_Charges.Enabled = True
            Tb_NVg_Dinner_Charges.Text = ""
            Tb_NVg_Lunch_Charges.Text = ""
            Tb_NVg_Starter_Charges.Text = ""
        Else
            Tb_Vg_Dinner_Charges.Enabled = True
            Tb_Vg_Lunch_Charges.Enabled = True
            Tb_Vg_Starter_Charges.Enabled = True
            Tb_Vg_Dinner_Charges.Text = ""
            Tb_Vg_Lunch_Charges.Text = ""
            Tb_Vg_Starter_Charges.Text = ""

            Tb_NVg_Dinner_Charges.Enabled = True
            Tb_NVg_Lunch_Charges.Enabled = True
            Tb_NVg_Starter_Charges.Enabled = True
            Tb_NVg_Dinner_Charges.Text = ""
            Tb_NVg_Lunch_Charges.Text = ""
            Tb_NVg_Starter_Charges.Text = ""
        End If
    End Sub

    Private Sub Tb_Breakfast_Charges_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Breakfast_Charges.KeyPress
        Charlock(e)
    End Sub

    Private Sub Tb_Sweet_Charges_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Vg_Starter_Charges.KeyPress, Tb_Vg_Lunch_Charges.KeyPress, Tb_Vg_Dinner_Charges.KeyPress, Tb_Sweet_Charges.KeyPress, Tb_NVg_Starter_Charges.KeyPress, Tb_NVg_Lunch_Charges.KeyPress, Tb_NVg_Dinner_Charges.KeyPress
        Charlock(e)
    End Sub

    Private Sub Tb_IceCream_Charges_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_IceCream_Charges.KeyPress
        Charlock(e)
    End Sub

    Private Sub Tb_Menu_Category_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Menu_Category.KeyPress
        '  Charlock(e)
    End Sub
End Class