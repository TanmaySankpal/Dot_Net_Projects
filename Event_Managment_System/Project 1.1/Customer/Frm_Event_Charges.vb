Imports System.Data.SqlClient

Public Class Frm_Event_Charges
    Dim Total As Double
    Dim Total_1 As Double
    Dim Total_2 As Double
    Dim Total_3 As Double
    Function Discount()
        'Tb_Total.Text = Val(Tb_Event_Charges.Text) + Val(Tb_Menu_Charges.Text) + Val(Tb_Decoration_Charges.Text) + Val(Tb_Venue_Charges.Text)
        If Tb_GST.Text <> "" Or Tb_GST.Text = "0" Then
            'Total = Val(Tb_Event_Charges.Text) + Val(Tb_Menu_Charges.Text) + Val(Tb_Decoration_Charges.Text) + Val(Tb_Venue_Charges.Text)
            Total_2 = Total_3 * ((100 - Val(Tb_Discount.Text)) / 100)
            Tb_Total.Text = Total_2
        Else
            Total = Val(Tb_Event_Charges.Text) + Val(Tb_Menu_Charges.Text) + Val(Tb_Decoration_Charges.Text) + Val(Tb_Venue_Charges.Text)
            Total_2 = Total * ((100 - Val(Tb_Discount.Text)) / 100)
            Tb_Total.Text = Total_2
        End If
        Return 1
    End Function
    Function GST()
        If Tb_Discount.Text <> "" Or Tb_Discount.Text = "0" Then
            Total_1 = Val(Tb_Event_Charges.Text) + Val(Tb_Menu_Charges.Text) + Val(Tb_Decoration_Charges.Text) + Val(Tb_Venue_Charges.Text)
            Total_3 = Total_1 * ((100 + Val(Tb_GST.Text)) / 100)
            'Tb_Total.Text = Total_1 * ((100 + Val(Tb_GST.Text)) / 100)
            Tb_Total.Text = Total_3
        Else
            Total = Val(Tb_Event_Charges.Text) + Val(Tb_Menu_Charges.Text) + Val(Tb_Decoration_Charges.Text) + Val(Tb_Venue_Charges.Text)
            Total_3 = Total_2 * ((100 + Val(Tb_GST.Text)) / 100)
            Tb_Total.Text = Total_3
        End If
        Return 1
    End Function
    Public Function Event_Charges_clear()
        Tb_Decoration_Charges.Text = ""
        Tb_Discount.Text = ""
        Tb_Event_Charges.Text = ""
        Tb_GST.Text = ""
        Tb_Menu_Charges.Text = ""
        Tb_Total.Text = ""
        Tb_Venue_Charges.Text = ""
        Tb_Paid.Text = ""
        Tb_Remaning.Text = ""
        Return 1
    End Function

    Private Sub Frm_Event_Charges_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        getconnection()
        Tb_Bill_No.Text = Frm_Add_New_Customer.Tb_Customer_ID.Text
        Tb_Discount.Text = "0"
        Tb_GST.Text = "0"
        Tb_Venue_Charges.Text = "0"
        Tb_Paid.Text = "0"

        Dim dr As SqlDataReader

        Dim command As New SqlCommand("select E_Charges from DB_Table_Add_Event where E_Type= '" + Frm_Add_New_Customer.Cb_Event_Type.Text + "' And E_Category = '" + Frm_Add_New_Customer.Cb_Event_Package.Text + "' ", connection)
        dr = command.ExecuteReader
        Dim chrge As Double

        If dr.Read() Then
            chrge = dr("E_Charges").ToString

        End If
        Tb_Event_Charges.Text = chrge
        dr.Close()
        command.Dispose()
        chrge = 0


        Tb_Menu_Charges.Text = Frm_Booking_Event.Menu_charge.ToString


        '................................................................................
        chrge = Val(Tb_Event_Charges.Text) + Val(Tb_Menu_Charges.Text) + Val(Tb_Decoration_Charges.Text)
        Tb_Total.Text = chrge
        '....................................................................................
        Total = Val(Tb_Event_Charges.Text) + Val(Tb_Menu_Charges.Text) + Val(Tb_Decoration_Charges.Text) + Val(Tb_Venue_Charges.Text)
        Total_1 = Val(Tb_Event_Charges.Text) + Val(Tb_Menu_Charges.Text) + Val(Tb_Decoration_Charges.Text) + Val(Tb_Venue_Charges.Text)


        terminateconnection()
    End Sub

    Private Sub Tb_Venue_Charges_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Venue_Charges.TextChanged
        Tb_Total.Text = Val(Tb_Event_Charges.Text) + Val(Tb_Menu_Charges.Text) + Val(Tb_Decoration_Charges.Text) + Val(Tb_Venue_Charges.Text)
    End Sub

    Private Sub Tb_GST_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_GST.TextChanged
        GST()

    End Sub

    Private Sub Tb_Paid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Paid.TextChanged
        Tb_Remaning.Text = Val(Tb_Total.Text) - Val(Tb_Paid.Text)
    End Sub

    Private Sub Tb_Discount_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Discount.TextChanged
        Discount()
    End Sub

    Private Sub Tb_Remaning_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Remaning.TextChanged
        If Tb_Paid.Text = "" And Tb_Paid.Text = "0" Then
            Tb_Remaning.Text = Val(Tb_Total.Text)
        Else
            Tb_Remaning.Text = Val(Tb_Total.Text) - Val(Tb_Paid.Text)
        End If
    End Sub

    Private Sub Tb_GST_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_GST.Leave
        If Tb_GST.Text = "" Then
            Tb_GST.Text = "0"
        End If
    End Sub

    Private Sub Tb_Discount_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Discount.Leave
        If Tb_Discount.Text = "" Then
            Tb_Discount.Text = "0"
        End If
    End Sub

    Private Sub Tb_Venue_Charges_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Venue_Charges.Leave
        If Tb_Venue_Charges.Text = "" Then
            Tb_Venue_Charges.Text = "0"
        End If
    End Sub

    Private Sub Tb_Paid_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Paid.Leave
        If Tb_Paid.Text = "" Then
            Tb_Paid.Text = "0"
        End If
    End Sub

    Private Sub Tb_Total_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Total.TextChanged
        Tb_Remaning.Text = Tb_Total.Text
    End Sub

    Private Sub Tb_Venue_Charges_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Venue_Charges.KeyPress
        Charlock(e)
    End Sub

    Private Sub Tb_GST_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_GST.KeyPress

        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) And Asc(ch) <> 8 And Asc(ch) <> 46 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Tb_Discount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Discount.KeyPress
        Charlock(e)
    End Sub

    Private Sub Tb_Paid_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Paid.KeyPress
        Charlock(e)
    End Sub

    Private Sub Btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancel.Click
        Me.Hide()
        Frm_Add_New_Customer.MdiParent = MDI_Main_Form
        Frm_Add_New_Customer.WindowState = FormWindowState.Maximized
        Frm_Add_New_Customer.Show()

        Event_Charges_clear()

        Frm_Add_New_Customer.Cust_cnt = 2
        Frm_Add_New_Customer.Cust_Clear()

        Frm_Booking_Event.cntt = 2
        Frm_Booking_Event.Book_clear()


    End Sub

    Private Sub Btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Back.Click
        Me.Hide()
        Frm_Booking_Event.MdiParent = MDI_Main_Form
        Frm_Booking_Event.WindowState = FormWindowState.Maximized
        Frm_Booking_Event.Show()
    End Sub

    Private Sub Btn_Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Refresh.Click
        Event_Charges_clear()
    End Sub

    Private Sub Btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Save.Click
        Dim Response As MsgBoxResult
        If Tb_Bill_No.Text = "" Then
            MessageBox.Show("Plese fill all the field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            getconnection()
            
                cmd = New SqlCommand("insert into Tb_Event_Charges(Cust_id,Bill_No,E_Charges,M_Charges,V__Charges,D_Charges,GST,Disscount,Total,Paid,Remaning) values (" & Comman_Class.Cust_id & ", " & Tb_Bill_No.Text & "," & Tb_Event_Charges.Text & "," & Tb_Menu_Charges.Text & "," & Tb_Venue_Charges.Text & "," & Tb_Decoration_Charges.Text & "," & Tb_GST.Text & "," & Tb_Discount.Text & "," & Tb_Total.Text & "," & Tb_Paid.Text & "," & Tb_Remaning.Text & ")", connection)
                cmd.ExecuteNonQuery()

            ''''''''''''''''''''''''''''''''''''''''''''''''Bill'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Response = MsgBox("Record Saved Sucessfully,You want to print Bill..", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Confirm")

            If Response = MsgBoxResult.Yes Then

                Dim dt As New DataTable()
                cmd = New SqlCommand("select * from Tb_Personal_info where Cust_id=" + Tb_Bill_No.Text + "", connection)
                Dim adp As New SqlDataAdapter(cmd)
                adp.Fill(dt)

                Dim dt2 As New DataTable()
                cmd = New SqlCommand("select * from Tb_Event_Charges  where Cust_id=" + Tb_Bill_No.Text + "", connection)
                adp = New SqlDataAdapter(cmd)
                adp.Fill(dt2)

                Dim dt3 As New DataTable()
                cmd = New SqlCommand("select * from Tb_Services where Cust_id=" + Tb_Bill_No.Text + "", connection)
                adp = New SqlDataAdapter(cmd)
                adp.Fill(dt3)

                Dim rpt As New CR_Bill_Search
                rpt.Database.Tables("Tb_Personal_info").SetDataSource(dt)
                rpt.Database.Tables("Tb_Event_Charges").SetDataSource(dt2)
                rpt.Database.Tables("Tb_Services").SetDataSource(dt3)


                Frm_Bill_print.CRV_Bill_Print.ReportSource = Nothing
                Frm_Bill_print.CRV_Bill_Print.ReportSource = rpt

                Me.Hide()
                Frm_Bill_print.MdiParent = MDI_Main_Form
                Frm_Bill_print.WindowState = FormWindowState.Maximized
                Frm_Bill_print.Show()

                cmd.Dispose()
                adp.Dispose()

            Else

                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                'MsgBox("Record Saved Sucessfully")
                Me.Hide()
                Frm_Add_New_Customer.MdiParent = MDI_Main_Form
                Frm_Add_New_Customer.WindowState = FormWindowState.Maximized
                Frm_Add_New_Customer.Show()

            End If
            cmd.Dispose()
            terminateconnection()
            Frm_Add_New_Customer.Cust_cnt = 1
            Frm_Add_New_Customer.Cust_Clear()

            Frm_Booking_Event.cntt = 1
            Frm_Booking_Event.Book_clear()

            Event_Charges_clear()

            getconnection()
            Frm_Add_New_Customer.Tb_Customer_ID.Text = Auto_Increment("select count(Cust_id)from Tb_Personal_info ", 1001)
            Frm_Add_New_Customer.Cust_cnt = 1
            terminateconnection()

        End If

    End Sub
   
    Private Sub Gb_Other_Charges_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gb_Other_Charges.Enter
        Tb_Discount.Enabled = True
    End Sub
End Class