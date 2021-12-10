Imports System.Data.SqlClient

Public Class Frm_All_Cust_Report
    Private Sub Frm_All_Cust_Report_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        getconnection()
        Dim dt As New DataTable()
        cmd = New SqlCommand("select * from Tb_Personal_info", connection)
        Dim adp As New SqlDataAdapter(cmd)
        adp.Fill(dt)


        terminateconnection()

        Dim rpt As New CR_All_Cust_update()
        rpt.Database.Tables("Tb_Personal_info").SetDataSource(dt)


        CR_All_Cust_updated.ReportSource = Nothing
        CR_All_Cust_updated.ReportSource = rpt

        cmd.Dispose()
        adp.Dispose()
    End Sub

    Private Sub Btn_View_All_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_View_All.Click
        Tb_Search_1.Text = ""
        Tb_Search_2.Text = ""

        getconnection()
        Dim dt As New DataTable()
        cmd = New SqlCommand("select * from Tb_Personal_info", connection)
        Dim adp As New SqlDataAdapter(cmd)
        adp.Fill(dt)
        terminateconnection()
        Dim rpt As New CR_All_Cust_update()
        rpt.Database.Tables("Tb_Personal_info").SetDataSource(dt)
        CR_All_Cust_updated.ReportSource = Nothing
        CR_All_Cust_updated.ReportSource = rpt
        cmd.Dispose()
        adp.Dispose()
        terminateconnection()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Tb_Search_1.Text < Tb_Search_2.Text Then
            getconnection()
            Dim dt As New DataTable()
            cmd = New SqlCommand("select * from Tb_Personal_info where Cust_id between '" + Tb_Search_1.Text + "'And'" + Tb_Search_2.Text + "'", connection)
            Dim adp As New SqlDataAdapter(cmd)
            adp.Fill(dt)
            terminateconnection()

            Dim rpt As New CR_All_Cust_update()
            rpt.Database.Tables("Tb_Personal_info").SetDataSource(dt)
            CR_All_Cust_updated.ReportSource = Nothing
            CR_All_Cust_updated.ReportSource = rpt

            cmd.Dispose()
            adp.Dispose()
            terminateconnection()
        Else
            MsgBox("Invalid Search...", MsgBoxStyle.Information)
        End If
    End Sub

   
End Class