Imports System.Data.SqlClient

Public Class Frm_All_Customer_Report

    Private Sub Frm_All_Customer_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       

    End Sub

    Private Sub Btn_View_All_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_View_All.Click
        Tb_Search_1.Text = ""
        Tb_Search_2.Text = ""
        getconnection()
        Dim dt As New DataTable()
        cmd = New SqlCommand("select * from Tb_Event_Charges", connection)
        Dim adp As New SqlDataAdapter(cmd)
        adp.Fill(dt)
        Dim rpt As New CR_All_Cust
        rpt.Database.Tables("Tb_Event_Charges").SetDataSource(dt)
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.ReportSource = rpt
        cmd.Dispose()
        adp.Dispose()
        terminateconnection()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Tb_Search_1.Text < Tb_Search_2.Text Then
            getconnection()
            Dim cr As New CR_All_Cust
            Dim ds As New DataSet
            cmd = New SqlCommand("select * from Tb_Event_Charges where Bill_No between '" + Tb_Search_1.Text + "'And'" + Tb_Search_2.Text + "'", connection)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(ds, "Tb_Event_Charges")
            cr.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = Nothing
            CrystalReportViewer1.ReportSource = cr
            terminateconnection()
        Else
            MsgBox("Invalid Search...", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Frm_All_Customer_Report_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        getconnection()
        Dim cr As New CR_All_Cust
        Dim ds As New DataSet
        cmd = New SqlCommand("select * from Tb_Event_Charges", connection)
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(ds, "Tb_Event_Charges")
        cr.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.ReportSource = cr
        terminateconnection()
    End Sub

    
End Class