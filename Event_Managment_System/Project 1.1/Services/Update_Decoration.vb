Imports System.Data.SqlClient
Imports System.IO

Public Class Frm_Update_Decoration
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim MS As New MemoryStream
    Function clear()
        Tb_Decoration_Category.Enabled = False
        Tb_Decoration_Charges.Enabled = False
        Tb_Decoration_Type.Enabled = False
        Pb_Decoration_Photo.Enabled = False
        Btn_Browse.Enabled = False
        Btn_Update_Decoration.Enabled = False
        Btn_Cancel.Enabled = False
        Tb_Decoration_ID.Enabled = True

        Tb_Decoration_Category.Text = ""
        Tb_Decoration_Charges.Text = ""
        Tb_Decoration_ID.Text = ""
        Tb_Decoration_Type.Text = ""
        Pb_Decoration_Photo.Image = Nothing
        Return 1
    End Function

    Private Sub Tb_Decoration_ID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Decoration_ID.KeyPress
        Charlock(e)
    End Sub

    Private Sub Tb_Decoration_Charges_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Decoration_Charges.KeyPress
        Charlock(e)
    End Sub

    Private Sub Btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Search.Click
        getconnection()
        If Tb_Decoration_ID.Text = "" Then
            MessageBox.Show("Please Enter id to search..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            cmd.Connection = connection
            cmd.CommandText = "select * from  DB_Table_Add_Decoration  where D_ID = " + Tb_Decoration_ID.Text + " "
            dr = cmd.ExecuteReader

            If dr.Read Then

                Tb_Decoration_Category.Text = dr("D_Category").ToString
                Tb_Decoration_Type.Text = dr("D_Type").ToString
                Tb_Decoration_Charges.Text = dr("D_Charges").ToString
                Pb_Decoration_Photo.Image = Comman_Class.view(dr("D_Photo"))

                Tb_Decoration_Category.Enabled = True
                Tb_Decoration_Charges.Enabled = True
                Tb_Decoration_ID.Enabled = False
                Tb_Decoration_Type.Enabled = True
                Pb_Decoration_Photo.Enabled = True
                Btn_Browse.Enabled = True
                Btn_Update_Decoration.Enabled = True
                Btn_Cancel.Enabled = True

            Else
                MessageBox.Show("Record Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If

        End If
        terminateconnection()

    End Sub

    Private Sub Btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancel.Click
        clear()
    End Sub

    Private Sub Btn_Browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Browse.Click
        Comman_Class.brows(Pb_Decoration_Photo.Image)
    End Sub

    Private Sub Btn_Update_Decoration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Update_Decoration.Click
        getconnection()
        cmd.Connection = connection
        Dim MST As New MemoryStream
        Dim BM As New Bitmap(Pb_Decoration_Photo.Image)

        cmd.CommandText = "update DB_Table_Add_Decoration set D_Type= '" + Tb_Decoration_Type.Text + "',D_Category='" + Tb_Decoration_Category.Text + "',D_Charges= " + Tb_Decoration_Charges.Text + ",D_Photo= @Pb_Decoration_Photo where D_ID= " + Tb_Decoration_ID.Text + " "

        If Tb_Decoration_Charges.Text = "" Or Tb_Decoration_Category.Text = "" Or Tb_Decoration_Type.Text = "" Or Pb_Decoration_Photo.Image Is Nothing Then

            MessageBox.Show("Plese fill all the field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            BM.Save(MST, Pb_Decoration_Photo.Image.RawFormat)
            cmd.Parameters.Add("Pb_Decoration_Photo", SqlDbType.Image).Value = MST.ToArray

            Dim i As Integer = cmd.ExecuteNonQuery

            If (i > 0) Then

                MessageBox.Show("Updated...", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clear()

            Else

                MessageBox.Show("Server is Connected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
        End If
        cmd.Parameters.Clear()
        terminateconnection()
    End Sub

End Class