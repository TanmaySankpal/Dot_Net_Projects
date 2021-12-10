Imports System.Data.SqlClient

Public Class Frm_Bill_search
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Tb_Search.Text = "" Then
            MessageBox.Show("Please Enter id to search..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            getconnection()
            Dim dt As New DataTable()
            cmd = New SqlCommand("select * from Tb_Personal_info where Cust_id=" + Tb_Search.Text + "", connection)
            Dim adp As New SqlDataAdapter(cmd)
            adp.Fill(dt)

            Dim dt2 As New DataTable()
            'cmd = New SqlCommand("select * from Tb_Event_Charges  where Cust_id=1001", connection)
            cmd = New SqlCommand("select * from Tb_Event_Charges  where Cust_id=" + Tb_Search.Text + "", connection)
            adp = New SqlDataAdapter(cmd)
            adp.Fill(dt2)

            Dim dt3 As New DataTable()
            cmd = New SqlCommand("select * from Tb_Services where Cust_id=" + Tb_Search.Text + "", connection)
            adp = New SqlDataAdapter(cmd)
            adp.Fill(dt3)

            terminateconnection()

            Dim rpt As New CR_Bill_Search
            rpt.Database.Tables("Tb_Personal_info").SetDataSource(dt)
            rpt.Database.Tables("Tb_Event_Charges").SetDataSource(dt2)
            rpt.Database.Tables("Tb_Services").SetDataSource(dt3)


            CR_Bill.ReportSource = Nothing
            CR_Bill.ReportSource = rpt

            cmd.Dispose()
            adp.Dispose()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Tb_Search.Text = ""
        CR_Bill.ReportSource = Nothing

    End Sub
End Class