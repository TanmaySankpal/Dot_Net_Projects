﻿Imports System.Data.SqlClient

Public Class Frm_View_All_User

    Private Sub Cb_Search_By_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Search_By.Enter
        Tb_Select_type.Text = ""
        Tb_Select_type.Enabled = False

    End Sub

    Private Sub Tb_Select_type_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Select_type.KeyPress
        If Cb_Search_By.Text = "User ID" Then
            Charlock(e)
        End If
    End Sub

    Private Sub Cb_Search_By_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Search_By.SelectedIndexChanged
        Tb_Select_type.Enabled = True
    End Sub

    Private Sub Frm_View_All_User_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        getconnection()
        cmd = New SqlCommand("SELECT * from Tb_User_Management", connection)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()

        da.Fill(dt)
        DG_View_All_Users.DataSource = dt

        cmd.Dispose()
        terminateconnection()
    End Sub

    Private Sub Btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Search.Click
        If Tb_Select_type.Text = "" Then
            MessageBox.Show("Please Select type to search..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            getconnection()
            If Cb_Search_By.Text = "User ID" Then
                cmd = New SqlCommand("SELECT * from Tb_User_Management WHERE U_ID =" + Tb_Select_type.Text + "", connection)
            ElseIf Cb_Search_By.Text = "User Name" Then
                cmd = New SqlCommand("SELECT * from Tb_User_Management WHERE U_Name ='" + Tb_Select_type.Text + "'", connection)
            ElseIf Cb_Search_By.Text = "User Role" Then
                cmd = New SqlCommand("SELECT * from Tb_User_Management WHERE U_Role ='" + Tb_Select_type.Text + "'", connection)

            Else
                MessageBox.Show("Record Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()

            da.Fill(dt)
            DG_View_All_Users.DataSource = dt

            cmd.Dispose()
            terminateconnection()
        End If
    End Sub

    Private Sub Btn_Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Refresh.Click
        getconnection()
        cmd = New SqlCommand("SELECT * from Tb_User_Management", connection)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()

        da.Fill(dt)
        DG_View_All_Users.DataSource = dt
        Cb_Search_By.SelectedIndex = -1
        Tb_Select_type.Text = ""
        Tb_Select_type.Enabled = False

        cmd.Dispose()
        terminateconnection()
    End Sub

End Class