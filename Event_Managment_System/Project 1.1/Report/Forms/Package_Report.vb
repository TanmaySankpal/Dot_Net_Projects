Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class Frm_Package_Report


    Private Sub Frm_Package_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getconnection()

        Dim command As New SqlCommand("select Distinct(E_Type) from DB_Table_Add_Event ", connection)

        Dim adapter_1 As New SqlDataAdapter(command)

        Dim table_1 As New DataTable()

        adapter_1.Fill(table_1)

        Cb_Event_Type.DataSource = table_1

        Cb_Event_Type.DisplayMember = "E_Type"

        terminateconnection()
    End Sub

    Private Sub Cb_Event_Type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Event_Type.SelectedIndexChanged
        getconnection()


        Dim command As New SqlCommand("select E_Category from DB_Table_Add_Event where E_Type= '" + Cb_Event_Type.Text + "' ", connection)

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        Cb_Event_Package.DataSource = table

        Cb_Event_Package.DisplayMember = "E_Category"

        terminateconnection()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        getconnection()
        Dim dr As SqlDataReader
        Dim cnt As Integer = 0
        Dim Charges As Integer = 0
        Dim Total As Integer = 0


        cmd = New SqlCommand("select * from DB_Table_Add_Event where E_Type='" + Cb_Event_Type.Text + "' and E_Category='" + Cb_Event_Package.Text + "'", connection)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        dr = cmd.ExecuteReader
        If (dr.Read()) Then
            Charges = dr("E_Charges")
        End If
        dr.Close()
        cmd.Dispose()
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim dt2 As New DataTable()
        cmd = New SqlCommand("select count(Cust_id) as Cust_id from Tb_Personal_info where E_Type='" + Cb_Event_Type.Text + "' and E_Package='" + Cb_Event_Package.Text + "'", connection)
        da = New SqlDataAdapter(cmd)
        da.Fill(dt2)

        cnt = cmd.ExecuteScalar()

        terminateconnection()
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Total = Charges * cnt





        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim rpt As New CR_Package1()
        rpt.Database.Tables("DB_Table_Add_Event").SetDataSource(dt)
        rpt.Database.Tables("Tb_Personal_info").SetDataSource(dt2)

        CRV_Package.ReportSource = Nothing
        CRV_Package.ReportSource = rpt


        cmd.Dispose()


    End Sub

    Private Function Total() As Object
        Throw New NotImplementedException
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CRV_Package.ReportSource = Nothing

    End Sub
End Class