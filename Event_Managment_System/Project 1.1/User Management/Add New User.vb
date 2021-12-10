Public Class Frm_Add_New_User
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
        Return 1
    End Function
    Private Sub Frm_Add_New_User_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        'Tb_User_ID.Text = Auto_Increment("select count(U_ID)from Tb_User_Management ", 100)
        txt_Employee_Id.Text = Auto_Increment("select count(Em_ID)from Tb_Employee ", 100)

    End Sub

    Private Sub Btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancel.Click
        clear()
    End Sub
    Private Sub cmb_Position_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Position.Leave
        'Dim Response As MsgBoxResult
        'If cmb_Position.Text = "Worker" Then
        '    Gb_Add_New_User.Enabled = False
        'Else
        '    Response = MsgBox(" Are you sure you want to add User .. ", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Confirm")

        '    If Response = MsgBoxResult.No Then
        '        Gb_Add_New_User.Enabled = False
        '        clear()
        '        txt_Employee_Id.Text = Auto_Increment("select count(Em_ID)from Tb_Employee ", 100)
        '    ElseIf Response = MsgBoxResult.Yes Then
        '        Gb_Add_New_User.Enabled = True
        '    End If
        'End If
    End Sub
   
    Private Sub cmb_Position_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Position.SelectedIndexChanged
        If cmb_Position.Text = "" Then


        Else
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
                End If
            End If
        End If
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

    Private Sub Button1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseDown
        Tb_Password.PasswordChar = ""
    End Sub

    Private Sub Button1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseUp
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

    Private Sub TextBox1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.Leave

        If TextBox1.Text = "" Then
            TextBox1.Text = "0"
        Else
            Mobile_No(TextBox1.TextLength)
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Charlock(e)
    End Sub

    Private Sub Btn_Add_User_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Add_User.Click
        getconnection()



        '............Emp..................................................................................................
        cmd.Connection = connection
        If txt_First_Name.Text = "" Or txt_Address.Text = "" Or txt_Adhaar_No.Text = "" Or txt_Mob_No.Text = "" Or TextBox1.Text = "" Or cmb_Position.Text = "" Then
            MessageBox.Show("Plese fill all the field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            cmd.CommandText = "insert into Tb_Employee values (" & txt_Employee_Id.Text & ",'" & txt_First_Name.Text & "','" & txt_Address.Text & "','" & dtp_Join_Date.Text & "'," & txt_Mob_No.Text & "," & TextBox1.Text & ",'" & txt_Adhaar_No.Text & "','" & cmb_Position.Text & "' )"
            cmd.ExecuteNonQuery()
            cmd.Dispose()

        End If
        '........UserManagement............................................................................................................................................................................................................................................................
        If Gb_Add_New_User.Enabled = True Then
            cmd.Connection = connection
            If Tb_User_Name.Text = "" Or Tb_Password.Text = "" Or Tb_Confirm_Pass.Text = "" Or Cb_User_Role.Text = "" Then
                MessageBox.Show("Plese fill all the field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                cmd.CommandText = "insert into Tb_User_Management values (" & Tb_User_ID.Text & ",'" & Cb_User_Role.Text & "','" & Tb_User_Name.Text & "','" & Tb_Password.Text & "' )"
                cmd.ExecuteNonQuery()
                MsgBox("Record Saved Sucessfully")
                txt_Employee_Id.Text = Auto_Increment("select count(Em_ID)from Tb_Employee ", 100)
                clear()
                cmd.Dispose()
            End If

        Else
            MsgBox("Emplyee added Sucessfully")
            txt_Employee_Id.Text = Auto_Increment("select count(Em_ID)from Tb_Employee ", 100)
            clear()
        End If
    End Sub

End Class