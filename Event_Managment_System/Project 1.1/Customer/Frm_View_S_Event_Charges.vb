Imports System.Data.SqlClient

Public Class Frm_View_S_Event_Charges
    Dim cnt As Integer
    Dim total As Double
    Dim Total_1 As Double
    Dim Total_2 As Double
    Dim Total_3 As Double

    Function Enable()
        If Frm_View_S_Event_Detail.Venue_cnt >= 1 Then
            Tb_Venue_Charges.Enabled = True
        End If

        Return 1
    End Function

    Function Discount()
        If Tb_GST.Text <> "" Or Tb_GST.Text = "0" Then
            Total_2 = Total_3 * ((100 - Val(Tb_Discount.Text)) / 100)
            Tb_Total.Text = Total_2
        Else
            total = Val(Tb_Event_Charges.Text) + Val(Tb_Menu_Charges.Text) + Val(Tb_Decoration_Charges.Text) + Val(Tb_Venue_Charges.Text)
            Total_2 = total * ((100 - Val(Tb_Discount.Text)) / 100)
            Tb_Total.Text = Total_2
        End If
        Return 1
    End Function
    Function GST()
        If Tb_Discount.Text <> "" Or Tb_Discount.Text = "0" Then
            Total_1 = Val(Tb_Event_Charges.Text) + Val(Tb_Menu_Charges.Text) + Val(Tb_Decoration_Charges.Text) + Val(Tb_Venue_Charges.Text)
            Total_3 = Total_1 * ((100 + Val(Tb_GST.Text)) / 100)

            Tb_Total.Text = Total_3
        Else
            total = Val(Tb_Event_Charges.Text) + Val(Tb_Menu_Charges.Text) + Val(Tb_Decoration_Charges.Text) + Val(Tb_Venue_Charges.Text)
            Total_3 = Total_2 * ((100 + Val(Tb_GST.Text)) / 100)
            Tb_Total.Text = Total_3
        End If
        Return 1
    End Function

    Private Sub Frm_View_S_Event_Charges_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        getconnection()
        Dim cust_id As Integer = Frm_View_Single_Customer.Tb_Bill_No.Text
        Enable()
        Dim dr As SqlDataReader
        cmd = New SqlCommand("select * from Tb_Event_Charges where cust_id = " & cust_id & "", connection)
        dr = cmd.ExecuteReader()

        If dr.Read() Then
            Tb_Bill_No.Text = dr("Bill_No").ToString
            Tb_Event_Charges.Text = dr("E_Charges").ToString
            Tb_Menu_Charges.Text = dr("M_Charges").ToString
            Tb_Venue_Charges.Text = dr("V__Charges").ToString
            Tb_Decoration_Charges.Text = dr("D_Charges").ToString
            Tb_GST.Text = dr("GST").ToString
            Tb_Discount.Text = dr("Disscount").ToString
            Tb_Total.Text = dr("Total").ToString
            Tb_Paid.Text = dr("Paid").ToString
            Tb_Remaning.Text = dr("Remaning").ToString

            Tb_Decoration_Charges.Text = Frm_View_S_Event_Detail.Decoration_charge
            Tb_Menu_Charges.Text = Frm_View_S_Event_Detail.Menu_charge
            Tb_Event_Charges.Text = Frm_View_Single_Customer.Event_Charges

        End If
        cmd.Dispose()
        dr.Close()

        If Frm_View_Single_Customer.Update_Cnt >= 1 Then
            total = Val(Tb_Event_Charges.Text) + Val(Tb_Menu_Charges.Text) + Val(Tb_Decoration_Charges.Text) + Val(Tb_Venue_Charges.Text)
            Total_1 = Val(Tb_Event_Charges.Text) + Val(Tb_Menu_Charges.Text) + Val(Tb_Decoration_Charges.Text) + Val(Tb_Venue_Charges.Text)
            Tb_Total.Text = Val(total)
            Tb_Remaning.Text = Val(Tb_Total.Text) - Val(Tb_Paid.Text)
            GST()
            Discount()
            cnt = 1
        End If

        terminateconnection()
    End Sub

    Private Sub Tb_Venue_Charges_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Venue_Charges.KeyPress
        Charlock(e)

    End Sub

    Private Sub Tb_GST_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_GST.KeyPress
        Charlock(e)
    End Sub

    Private Sub Tb_Discount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Discount.KeyPress
        Charlock(e)
    End Sub

    Private Sub Tb_Paid_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Paid.KeyPress
        Charlock(e)
    End Sub

    Private Sub Tb_GST_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_GST.TextChanged
        'If cnt >= 1 Then
        '    GST()
        'End If
    End Sub

    Private Sub Tb_Discount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Discount.TextChanged

        'If cnt >= 1 Then
        '    Discount()
        'End If
    End Sub

    Private Sub Btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancel.Click
        Me.Hide()
        Frm_View_Single_Customer.MdiParent = MDI_Main_Form
        Frm_View_Single_Customer.WindowState = FormWindowState.Maximized
        Frm_View_Single_Customer.Show()
    End Sub

    Private Sub Btn_Event_Detail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Event_Detail.Click
        Me.Hide()
        Frm_View_S_Event_Detail.MdiParent = MDI_Main_Form
        Frm_View_S_Event_Detail.WindowState = FormWindowState.Maximized
        Frm_View_S_Event_Detail.Show()
    End Sub


    Private Sub Btn_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Update.Click
        Frm_View_Single_Customer.Update_Cnt = 0
        Frm_View_Single_Customer.Clear()
        Frm_View_Single_Customer.MdiParent = MDI_Main_Form
        Frm_View_Single_Customer.WindowState = FormWindowState.Maximized
        Frm_View_Single_Customer.Show()

    End Sub

    Private Sub Tb_Venue_Charges_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Venue_Charges.TextChanged
        If Tb_Venue_Charges.Enabled Then
            Tb_Total.Text = Val(total)
            Tb_Remaning.Text = Val(Tb_Total.Text) - Val(Tb_Paid.Text)
            GST()
            Discount()

        End If
    End Sub

    Private Sub Tb_Remaning_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Remaning.TextChanged
        Dim temp As Double
        temp = Val(Tb_Remaning.Text)
        If Val(Tb_Remaning.Text) < 0 Then
            Lbl_Refund.Visible = True
            Lbl_Rem.Visible = False
            Tb_Remaning.Text = -(temp)
        Else
            Lbl_Refund.Visible = False
            Lbl_Rem.Visible = True
        End If
    End Sub

End Class