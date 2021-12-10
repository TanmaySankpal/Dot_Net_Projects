Imports System.Data.SqlClient
Imports System.IO

Public Class Frm_Update_Menu
    Dim dr As SqlDataReader
    Dim cmd As New SqlCommand
    Dim MS As New MemoryStream
    Function clear()
        Tb_Menu_Category.Text = ""
        Tb_Breakfast_Charges.Text = ""
        Tb_IceCream_Charges.Text = ""
        Tb_Sweet_Charges.Text = ""
        Tb_Menu_ID.Text = ""
        Cb_Menu_Type.SelectedIndex = -1
        Pb_Menu_Photo.Image = Nothing

        Btn_Browse.Enabled = False
        Btn_Update_Menu.Enabled = False
        Tb_Menu_Category.Enabled = False
        Tb_Menu_ID.Enabled = False
        Tb_Menu_ID.Enabled = True
        Cb_Menu_Type.Enabled = False
        Btn_Cancel.Enabled = False

        Return 1
    End Function

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

    Private Sub Tb_Menu_ID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Menu_ID.KeyPress
        Charlock(e)
    End Sub

    Private Sub Tb_Breakfast_Charges_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Charlock(e)
    End Sub

    Private Sub Tb_IceCream_Charges_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Vg_Starter_Charges.KeyPress, Tb_Vg_Lunch_Charges.KeyPress, Tb_Vg_Dinner_Charges.KeyPress, Tb_Sweet_Charges.KeyPress, Tb_NVg_Starter_Charges.KeyPress, Tb_NVg_Lunch_Charges.KeyPress, Tb_NVg_Dinner_Charges.KeyPress, Tb_IceCream_Charges.KeyPress
        Charlock(e)
    End Sub

    Private Sub Tb_Breakfast_Charges_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Breakfast_Charges.KeyPress
        Charlock(e)
    End Sub

    Private Sub Btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Search.Click
        getconnection()
        If Tb_Menu_ID.Text = "" Then
            MessageBox.Show("Please Enter id to search..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            cmd.Connection = connection
            cmd.CommandText = "select * from  DB_Table_Add_Menu  where M_id = " + Tb_Menu_ID.Text + " "

            dr = cmd.ExecuteReader

            If dr.Read() Then

                Tb_Menu_ID.Text = dr("M_ID").ToString
                Cb_Menu_Type.Text = dr("M_Type").ToString
                Tb_Menu_Category.Text = dr("M_Category").ToString
                Pb_Menu_Photo.Image = Comman_Class.view(dr("M_Photo"))
                Tb_Breakfast_Charges.Text = dr("Bf_Charges").ToString
                Tb_Vg_Starter_Charges.Text = dr("Vg_Starter_Charges").ToString
                Tb_NVg_Starter_Charges.Text = dr("NVg_Starter_Charges").ToString
                Tb_Vg_Lunch_Charges.Text = dr("Vg_Lunch_Charges").ToString
                Tb_NVg_Lunch_Charges.Text = dr("NVg_Lunch_Charges").ToString
                Tb_Vg_Dinner_Charges.Text = dr("Vg_Dinner_Charges").ToString
                Tb_NVg_Dinner_Charges.Text = dr("NVg_Dinner_Charges").ToString
                Tb_Sweet_Charges.Text = dr("Sweet_Charges").ToString
                Tb_IceCream_Charges.Text = dr("IceCream_Charges").ToString



                Btn_Browse.Enabled = True
                Btn_Update_Menu.Enabled = True
                Btn_Cancel.Enabled = True
                Tb_Menu_Category.Enabled = True
                Cb_Menu_Type.Enabled = True
                Tb_Menu_ID.Enabled = False
                Tb_Breakfast_Charges.Enabled = True
                Tb_IceCream_Charges.Enabled = True
                Tb_Sweet_Charges.Enabled = True


                If Cb_Menu_Type.Text = "Vegitarian" Then
                    Tb_Vg_Dinner_Charges.Enabled = True
                    Tb_Vg_Lunch_Charges.Enabled = True
                    Tb_Vg_Starter_Charges.Enabled = True
                    Tb_NVg_Dinner_Charges.Text = "0"
                    Tb_NVg_Lunch_Charges.Text = "0"
                    Tb_NVg_Starter_Charges.Text = "0"

                ElseIf Cb_Menu_Type.Text = "Non-Vegitarian" Then
                    Tb_NVg_Dinner_Charges.Enabled = True
                    Tb_NVg_Lunch_Charges.Enabled = True
                    Tb_NVg_Starter_Charges.Enabled = True
                    Tb_Vg_Dinner_Charges.Text = "0"
                    Tb_Vg_Lunch_Charges.Text = "0"
                    Tb_Vg_Starter_Charges.Text = "0"

                ElseIf Cb_Menu_Type.Text = "Vegitarian & Non-Vegitarian" Then
                    Tb_Vg_Dinner_Charges.Enabled = True
                    Tb_Vg_Lunch_Charges.Enabled = True
                    Tb_Vg_Starter_Charges.Enabled = True
                    Tb_NVg_Dinner_Charges.Enabled = True
                    Tb_NVg_Lunch_Charges.Enabled = True
                    Tb_NVg_Starter_Charges.Enabled = True



                Else
                    MessageBox.Show("Record Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End If
            End If
        End If
        terminateconnection()
    End Sub

    Private Sub Btn_Browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Browse.Click
        Comman_Class.brows(Pb_Menu_Photo.Image)
    End Sub

    Private Sub Btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancel.Click
        clear()
    End Sub

    Private Sub Btn_Update_Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Update_Menu.Click
        getconnection()
        cmd.Connection = connection
        Dim MST As New MemoryStream
        Dim BM As New Bitmap(Pb_Menu_Photo.Image)

        cmd.CommandText = "update DB_Table_Add_Menu set M_Type= '" + Cb_Menu_Type.Text + "',M_Category='" + Tb_Menu_Category.Text + "',M_Photo=@Pb_Menu_Photo,Bf_Charges=" + Tb_Breakfast_Charges.Text + ",Vg_Starter_Charges=" + Tb_Vg_Starter_Charges.Text + ",NVg_Starter_Charges=" + Tb_NVg_Starter_Charges.Text + ",Vg_Lunch_Charges=" + Tb_Vg_Lunch_Charges.Text + ",NVg_Lunch_Charges=" + Tb_NVg_Lunch_Charges.Text + ",Vg_Dinner_Charges=" + Tb_Vg_Dinner_Charges.Text + ",NVg_Dinner_Charges=" + Tb_NVg_Dinner_Charges.Text + ",Sweet_Charges=" + Tb_Sweet_Charges.Text + ",IceCream_Charges=" + Tb_IceCream_Charges.Text + " where M_ID=" + Tb_Menu_ID.Text + " "

        If Tb_Menu_Category.Text = "" Or Cb_Menu_Type.Text = "" Or Pb_Menu_Photo.Image Is Nothing Or Tb_Breakfast_Charges.Text = "" Or Tb_Vg_Starter_Charges.Text = "" Or Tb_NVg_Starter_Charges.Text = "" Or Tb_Vg_Lunch_Charges.Text = "" Or Tb_NVg_Lunch_Charges.Text = "" Or Tb_Vg_Dinner_Charges.Text = "" Or Tb_NVg_Dinner_Charges.Text = "" Or Tb_IceCream_Charges.Text = "" Or Tb_Sweet_Charges.Text = "" Then
            MessageBox.Show("Plese fill all the field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            BM.Save(MST, Pb_Menu_Photo.Image.RawFormat)
            cmd.Parameters.Add("Pb_Menu_Photo", SqlDbType.Image).Value = MST.ToArray
            Dim i As Integer = cmd.ExecuteNonQuery

            If (i > 0) Then

                MessageBox.Show("Updated...", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clear()

            Else

                MessageBox.Show("Server is Connected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
        End If
        MST.Dispose()
        BM.Dispose()
        cmd.Parameters.Clear()
        terminateconnection()
    End Sub

End Class
