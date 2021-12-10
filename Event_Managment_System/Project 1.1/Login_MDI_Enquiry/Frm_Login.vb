Imports System.Data.SqlClient

Public Class Frm_Login
    Function clear_texbox()
        Tb_Password.Text = ""
        Tb_Username.Text = ""
        Return 1
    End Function
    Private Sub Btn_Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Login.Click

        If Tb_Username.Text = "" And Tb_Password.Text <> "" Then
            MessageBox.Show("Please Enter User Name...", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Tb_Password.Text = "" And Tb_Username.Text <> "" Then
            MessageBox.Show("Please Enter Password...", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Tb_Username.Text = "" And Tb_Password.Text = "" Then
            MessageBox.Show("Please Enter UserName/Password...", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            getconnection()
            Dim dr As SqlDataReader
            Dim cmd As New SqlCommand
            Dim name As String

            cmd.Connection = connection
            cmd.CommandText = "select *from Tb_User_Management where U_Name='" + Tb_Username.Text + "' and U_Password='" + Tb_Password.Text + "'"

            dr = cmd.ExecuteReader

            If dr.Read() Then
                name = dr("U_Name").ToString

                If dr("U_Role").ToString = "Manager" Then
                    MDI_Main_Form.ReporToolStripMenuItem.Visible = False
                ElseIf dr("U_Role").ToString = "Receptionist" Then
                    MDI_Main_Form.ReporToolStripMenuItem.Visible = False
                    MDI_Main_Form.UpdateServicesToolStripMenuItem.Visible = False
                    MDI_Main_Form.UpdateEventToolStripMenuItem.Visible = False
                    MDI_Main_Form.AddNewEventToolStripMenuItem.Visible = False
                    MDI_Main_Form.PackagesToolStripMenuItem1.Visible = False
                    MDI_Main_Form.UserManagementToolStripMenuItem.Visible = False
                End If

                MessageBox.Show("Welcome " + dr("U_Role").ToString + "", "Student Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                MDI_Main_Form.Show()
                Me.Hide()
                MDI_Main_Form.Timer1.Enabled = True
                MDI_Main_Form.Timer2.Enabled = True
                MDI_Main_Form.PB_MDI.Show()
                clear_texbox()
                Tb_Username.Focus()
            Else
                Dim Response As MsgBoxResult

                Response = MsgBox("invalid User name and password", CType(MsgBoxStyle.Question + MsgBoxStyle.RetryCancel, MsgBoxStyle), "Login")

                If Response = MsgBoxResult.Retry Then
                    clear_texbox()
                    Me.Show()
                Else
                    Me.Close()
                End If

            End If

            terminateconnection()
        End If
    End Sub

    Private Sub Btn_View_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Btn_View.MouseDown
        Tb_Password.PasswordChar = ""
    End Sub

    Private Sub Btn_View_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Btn_View.MouseUp
        Tb_Password.PasswordChar = "$"
    End Sub
End Class
