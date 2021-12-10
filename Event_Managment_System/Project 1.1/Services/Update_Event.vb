Imports System.Data.SqlClient
Imports System.IO
Public Class Frm_Update_Event
    Dim dr As SqlDataReader
    Dim cmd As New SqlCommand
    Dim ms As New MemoryStream

    Function claer()
        Tb_Event_Charges.Text = ""
        Tb_Event_ID.Text = ""
        Tb_Event_Package.Text = ""
        Cb_Event_Type.SelectedIndex = -1
        Pb_Add_Photo.Image = Nothing

        Tb_Event_Charges.Enabled = False
        Tb_Event_ID.Enabled = True
        Tb_Event_Package.Enabled = False
        Cb_Event_Type.Enabled = False
        Btn_Browse.Enabled = False
        Btn_Update_Event.Enabled = False
        Btn_Cancel.Enabled = False
        Return 1
    End Function

    Private Sub Tb_Event_ID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Event_ID.KeyPress
        Charlock(e)
    End Sub

    Private Sub Tb_Event_Charges_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Event_Charges.KeyPress
        Charlock(e)
    End Sub

    Private Sub Btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Search.Click

        getconnection()
        If Tb_Event_ID.Text = "" Then
            MessageBox.Show("Please Enter id to search..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            cmd.Connection = connection
            cmd.CommandText = "select * from  DB_Table_Add_Event  where E_id = " + Tb_Event_ID.Text + " "

            dr = cmd.ExecuteReader

            If dr.Read() Then
                Cb_Event_Type.Text = dr("E_Type").ToString
                Tb_Event_Package.Text = dr("E_Category").ToString
                Tb_Event_Charges.Text = dr("E_Charges").ToString
                Pb_Add_Photo.Image = Comman_Class.view(dr("E_Photo"))

                Tb_Event_Charges.Enabled = True
                Tb_Event_ID.Enabled = False
                Tb_Event_Package.Enabled = True
                Cb_Event_Type.Enabled = True
                Btn_Browse.Enabled = True
                Btn_Update_Event.Enabled = True
                Btn_Cancel.Enabled = True
            Else
                MessageBox.Show("Record Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
        End If

        terminateconnection()
    End Sub

    Private Sub Btn_Browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Browse.Click
        Comman_Class.brows(Pb_Add_Photo.Image)
    End Sub

    Private Sub Btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancel.Click
        claer()
    End Sub

    Private Sub Btn_Update_Event_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Update_Event.Click
        getconnection()
        cmd.Connection = connection
        Dim MT As New MemoryStream
        Dim BM As New Bitmap(Pb_Add_Photo.Image)

        cmd.CommandText = "update DB_Table_Add_Event set E_Type= '" + Cb_Event_Type.Text + "',E_Category='" + Tb_Event_Package.Text + "',E_Charges= " + Tb_Event_Charges.Text + ",E_Photo=@Pb_Add_Photo where E_id= " + Tb_Event_ID.Text + " "

        If Tb_Event_Package.Text = "" Or Tb_Event_Charges.Text = "" Or Cb_Event_Type.Text = "" Or Pb_Add_Photo.Image Is Nothing Then

            MessageBox.Show("Plese fill all the field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            BM.Save(MT, Pb_Add_Photo.Image.RawFormat)
            cmd.Parameters.Add("Pb_Add_Photo", SqlDbType.Image).Value = MT.ToArray

            Dim i As Integer = cmd.ExecuteNonQuery

            If (i > 0) Then

                MessageBox.Show("Updated...", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                claer()

            Else

                MessageBox.Show("Server is Connected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
        End If
        MT.Dispose()
        BM.Dispose()
        cmd.Parameters.Clear()
        terminateconnection()
    End Sub

End Class