Imports System.Data.SqlClient

Public Class Frm_Update_User
    Dim dr As SqlDataReader
    Dim cnt As Integer

    Function clear()

        Tb_User_Name.Text = ""
        Cb_User_Role.SelectedIndex = -1
        Tb_Password.Text = ""
        Tb_Confirm_Pass.Text = ""
        Tb_Confirm_Pass.Enabled = False
        Lbl_Not_Match.Visible = False
        Lbl_Match.Visible = False

        txt_Address.Text = ""
        txt_Adhaar_No.Text = ""
        txt_First_Name.Text = ""
        txt_Mob_No.Text = ""
        TextBox1.Text = ""
        cmb_Position.SelectedIndex = -1
        dtp_Join_Date.Text = ""
        Tb_User_ID.Text = ""
        cnt = 1
        Return 1
    End Function

    Private Sub cmb_Position_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Position.SelectedIndexChanged
        If cnt <> 1 Then
            If cmb_Position.Text <> "" Then
                Dim Response As MsgBoxResult
                If cmb_Position.Text = "Worker" Then
                    Gb_Add_New_User.Enabled = False
                Else
                    Response = MsgBox(" Are you sure you want to add User .. ", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Confirm")

                    If Response = MsgBoxResult.No Then
                        Gb_Add_New_User.Enabled = False
                    ElseIf Response = MsgBoxResult.Yes Then
                        Gb_Add_New_User.Enabled = True
                        Tb_User_ID.Text = Val(txt_Employee_Id.Text)
                        cnt = 3
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txt_Employee_Id_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Employee_Id.Leave
        clear()
        Gb_Add_New_Employee.Enabled = False
        Gb_Add_New_User.Enabled = False
        Btn_Add_User.Enabled = False
        Btn_Cancel.Enabled = False
    End Sub

    Private Sub Tb_Confirm_Pass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Confirm_Pass.TextChanged
        If Tb_Password.Text = Tb_Confirm_Pass.Text Then
            Lbl_Match.Visible = True
            Lbl_Not_Match.Visible = False
        Else
            Lbl_Not_Match.Visible = True
            Lbl_Match.Visible = False
        End If
    End Sub

    Private Sub Btn_View_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Btn_View.MouseDown
        Tb_Password.PasswordChar = ""
    End Sub

    Private Sub Btn_View_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Btn_View.MouseUp
        Tb_Password.PasswordChar = "$"
    End Sub

    Private Sub Tb_Password_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Password.TextChanged
        Tb_Confirm_Pass.Enabled = True
    End Sub

    Private Sub txt_Mob_No_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Mob_No.Leave
        Mobile_No(txt_Mob_No.TextLength)
    End Sub

    Private Sub txt_Mob_No_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Mob_No.KeyPress
        Charlock(e)
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Charlock(e)
    End Sub

    Private Sub txt_Adhaar_No_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Adhaar_No.Leave
        If TextBox1.Text = "" Then
            TextBox1.Text = "0"
        Else
            Mobile_No(TextBox1.TextLength)
        End If
    End Sub

    Private Sub Btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Search.Click
        Try
            getconnection()
            If txt_Employee_Id.Text = "" Then
                MessageBox.Show("Please Enter id to search..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                'cmd.Connection = connection
                cmd = New SqlCommand("select * from Tb_Employee where Em_ID = " + txt_Employee_Id.Text + "", connection)
                dr = cmd.ExecuteReader
                If dr.Read() Then
                    txt_First_Name.Text = dr("Em_Name").ToString
                    txt_Address.Text = dr("Em_Address").ToString
                    dtp_Join_Date.Text = dr("Joining_Date").ToString
                    txt_Mob_No.Text = dr("Mobile_1").ToString
                    TextBox1.Text = dr("Mobile_2").ToString
                    txt_Adhaar_No.Text = dr("Adhar_Pan").ToString
                    cmb_Position.Text = dr("Position").ToString
                    Gb_Add_New_Employee.Enabled = True
                    dr.Close()
                    cmd.Dispose()

                    Btn_Add_User.Enabled = True
                    Btn_Cancel.Enabled = True


                    cmd = New SqlCommand("select * from Tb_User_Management where U_ID = " + txt_Employee_Id.Text + "", connection)
                    dr = cmd.ExecuteReader
                    If dr.Read() Then
                        Tb_User_ID.Text = dr("U_ID").ToString
                        Cb_User_Role.Text = dr("U_Role").ToString
                        Tb_User_Name.Text = dr("U_Name").ToString
                        Tb_Password.Text = dr("U_Password").ToString
                        Gb_Add_New_User.Enabled = True
                    Else
                        Gb_Add_New_User.Enabled = False
                    End If
                    cnt = 2
                Else
                    MessageBox.Show("Record Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If

            terminateconnection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub Btn_Add_User_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Add_User.Click
        getconnection()
        If txt_First_Name.Text = "" Or txt_Address.Text = "" Or txt_Adhaar_No.Text = "" Or txt_Mob_No.Text = "" Or TextBox1.Text = "" Or cmb_Position.Text = "" Then
            MessageBox.Show("Plese fill all the field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            cmd = New SqlCommand("Update Tb_Employee Set Em_Name ='" + txt_First_Name.Text + "',Em_Address='" + txt_Address.Text + "',Joining_Date='" + dtp_Join_Date.Text + "',Mobile_1=" + txt_Mob_No.Text + ",Mobile_2=" + TextBox1.Text + ",Adhar_Pan='" + txt_Adhaar_No.Text + "',Position='" + cmb_Position.Text + "' Where Em_ID=" + txt_Employee_Id.Text + "", connection)
            cmd.ExecuteNonQuery()
            'MsgBox("Record U Sucessfully")
            cmd.Dispose()
        End If

        If Gb_Add_New_User.Enabled = True Then
            If Tb_User_Name.Text = "" Or Tb_Password.Text = "" Or Tb_Confirm_Pass.Text = "" Or Cb_User_Role.Text = "" Then
                MessageBox.Show("Plese fill all the field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If cnt = 3 Then
                    cmd.CommandText = "insert into Tb_User_Management values (" & Tb_User_ID.Text & ",'" & Cb_User_Role.Text & "','" & Tb_User_Name.Text & "','" & Tb_Password.Text & "' )"
                    cmd.ExecuteNonQuery()
                    MsgBox("Record Update/Saved Sucessfully")
                    txt_Employee_Id.Text = ""
                    clear()
                    cmd.Dispose()
                Else
                Tb_User_ID.Text = Val(txt_Employee_Id.Text)
                cmd = New SqlCommand("Update Tb_User_Management Set U_Role ='" + Cb_User_Role.Text + "',U_Name='" + Tb_User_Name.Text + "',U_Password='" + Tb_Password.Text + "' Where U_ID=" + txt_Employee_Id.Text + "", connection)
                cmd.ExecuteNonQuery()
                MsgBox("Record U Sucessfully")
                clear()
                txt_Employee_Id.Text = ""
                cmd.Dispose()
                End If
            End If
        Else
            MsgBox("Record U Sucessfully")
            clear()
            txt_Employee_Id.Text = ""
        End If

        terminateconnection()
    End Sub

    Private Sub Btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancel.Click
        clear()
        txt_Employee_Id.Text = ""
    End Sub

End Class