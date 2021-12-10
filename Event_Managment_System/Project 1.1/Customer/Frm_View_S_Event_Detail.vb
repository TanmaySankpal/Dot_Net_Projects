Imports System.Data.SqlClient

Public Class Frm_View_S_Event_Detail
    Public Menu_charge As Integer = 0
    Public Decoration_charge As Integer = 0
    Public Venue_cnt As Integer = 0
    Dim cust_id As Integer = Frm_View_Single_Customer.Tb_Bill_No.Text
    Function clear_menu()
        Cb_Breakfast.Checked = False
        Cb_Starters.Checked = False
        Cb_Lunch.Checked = False
        Cb_Dinner.Checked = False
        Cb_Sweet.Checked = False
        Cb_IceCream.Checked = False
        Cb_NOP_Breakfast.SelectedIndex = -1
        Cb_NOP_IceCrem.SelectedIndex = -1
        Cb_NOP_NVg_Dinner.SelectedIndex = -1
        Cb_NOP_NVg_Lunch.SelectedIndex = -1
        Cb_NOP_NVg_Starter.SelectedIndex = -1
        Cb_NOP_Sweet.SelectedIndex = -1
        Cb_NOP_Vg_Dinner.SelectedIndex = -1
        Cb_NOP_Vg_Lunch.SelectedIndex = -1
        Cb_NOP_Vg_Starter.SelectedIndex = -1
        Gb_Services.Enabled = False
        Cb_Menu_Type.SelectedIndex = -1
        Cb_Menu_Categary.SelectedIndex = -1
        Return 1
    End Function

    Function All_Menu_Charge()
        'getconnection()
        Dim drr As SqlDataReader

        Dim command2 As New SqlCommand("select Bf_Charges,Vg_Starter_Charges,NVg_Starter_Charges,Vg_Lunch_Charges,NVg_Lunch_Charges,Vg_Dinner_Charges,NVg_Dinner_Charges,Sweet_Charges,IceCream_Charges from DB_Table_Add_Menu where M_Type= '" + Cb_Menu_Type.Text + "' And M_Category = '" + Cb_Menu_Categary.Text + "' ", connection)
        drr = command2.ExecuteReader
        Dim Bf_charge As Double
        Dim Vg_Starter_charge As Double
        Dim NV_Starter_charge As Double
        Dim Lunch_Charge As Double
        Dim NV_Lunch_Charge As Double
        Dim Dinner_Charge As Double
        Dim NV_Dinner_Charge As Double
        Dim Sweet_Charge As Double
        Dim Ice_Charge As Double

        If drr.Read() Then
            Bf_charge = drr("Bf_Charges").ToString
            Vg_Starter_charge = drr("Vg_Starter_Charges").ToString
            NV_Starter_charge = drr("NVg_Starter_Charges").ToString
            Lunch_Charge = drr("Vg_Lunch_Charges").ToString
            NV_Lunch_Charge = drr("NVg_Lunch_Charges").ToString
            Dinner_Charge = drr("Vg_Dinner_Charges").ToString
            NV_Dinner_Charge = drr("NVg_Dinner_Charges").ToString
            Sweet_Charge = drr("Sweet_Charges").ToString
            Ice_Charge = drr("IceCream_Charges").ToString

        End If
        Menu_charge = (Val(Bf_charge) * Val(Cb_NOP_Breakfast.Text)) + (Val(Vg_Starter_charge) * Val(Cb_NOP_Vg_Starter.Text)) + (Val(NV_Starter_charge) * Val(Cb_NOP_NVg_Starter.Text)) + (Val(Lunch_Charge) * Val(Cb_NOP_Vg_Lunch.Text)) + (Val(NV_Lunch_Charge) * Val(Cb_NOP_NVg_Lunch.Text)) + (Val(Dinner_Charge) * Val(Cb_NOP_Vg_Dinner.Text)) + (Val(NV_Dinner_Charge) * Val(Cb_NOP_NVg_Dinner.Text)) + (Val(Sweet_Charge) * Val(Cb_NOP_Sweet.Text)) + (Val(Ice_Charge) * Val(Cb_NOP_IceCrem.Text))
        Frm_View_S_Event_Charges.Tb_Menu_Charges.Text = Menu_charge

        command2.Dispose()
        drr.Close()

        Return 1
    End Function

    Function All_Decoration_Charge()
        Dim dr As SqlDataReader

        Dim command As New SqlCommand("select D_Charges from DB_Table_Add_Decoration where D_Category= '" + Cb_Decoration_Categary.Text + "' And D_Type = '" + Cb_Light_Music.Text + "' ", connection)
        dr = command.ExecuteReader
        Dim D_chrge As Double

        If dr.Read() Then
            D_chrge = dr("D_Charges").ToString

        End If
        Frm_View_S_Event_Charges.Tb_Decoration_Charges.Text = D_chrge
        Decoration_charge = D_chrge
        dr.Close()
        command.Dispose()

        Return 1
    End Function

    Public Function Book_clear()
        Tb_Venue.Text = ""
        Cb_Venue_Type.SelectedIndex = -1
        Cb_Menu_Services.Checked = False
        Cb_Menu_Type.SelectedIndex = -1
        Cb_Menu_Categary.SelectedIndex = -1
        Cb_Breakfast.Checked = False
        Cb_Dinner.Checked = False
        Cb_IceCream.Checked = False
        Cb_Lunch.Checked = False
        Cb_Sweet.Checked = False
        Cb_NOP_Breakfast.SelectedIndex = -1
        Cb_NOP_IceCrem.SelectedIndex = -1
        Cb_NOP_NVg_Dinner.SelectedIndex = -1
        Cb_NOP_NVg_Lunch.SelectedIndex = -1
        Cb_NOP_NVg_Starter.SelectedIndex = -1
        Cb_NOP_Sweet.SelectedIndex = -1
        Cb_NOP_Vg_Dinner.SelectedIndex = -1
        Cb_NOP_Vg_Lunch.SelectedIndex = -1
        Cb_NOP_Vg_Starter.SelectedIndex = -1

        Cb_Decoration_Services.Checked = False
        Cb_Decoration_Categary.Text = ""
        Cb_Light_Music.Text = ""
        Cb_No_Of_Chairs.SelectedIndex = -1
        Cb_No_Of_Sofa.SelectedIndex = -1
        Cb_No_Of_Flowers.SelectedIndex = -1
        Return 1
    End Function

    Private Sub Frm_View_S_Event_Detail_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        getconnection()
        Dim cust_id As Integer = Frm_View_Single_Customer.Tb_Bill_No.Text
        Dim dr As SqlDataReader
        cmd = New SqlCommand("select * from Tb_Services where cust_id = " & cust_id & "", connection)

        dr = cmd.ExecuteReader()

        If dr.Read() Then
            Tb_Venue.Text = dr("Venue").ToString
            Cb_Venue_Type.Text = dr("V_Type").ToString
            Cb_Menu_Type.Text = dr("M_Type").ToString
            Cb_Menu_Categary.Text = dr("M_Package").ToString
            Cb_NOP_Breakfast.Text = dr("Breakfast").ToString
            Cb_NOP_Vg_Starter.Text = dr("V_Starters").ToString
            Cb_NOP_NVg_Starter.Text = dr("Nv_Starters").ToString
            Cb_NOP_Vg_Lunch.Text = dr("V_Lunch").ToString
            Cb_NOP_NVg_Lunch.Text = dr("Nv_Lunch").ToString
            Cb_NOP_Vg_Dinner.Text = dr("V_Dinner").ToString
            Cb_NOP_NVg_Dinner.Text = dr("Nv_Dinner").ToString
            Cb_NOP_IceCrem.Text = dr("Icecream").ToString
            Cb_NOP_Sweet.Text = dr("Sweet").ToString
            Cb_Decoration_Categary.Text = dr("D_Categary").ToString
            Cb_Light_Music.Text = dr("LM_Type").ToString
            Cb_No_Of_Chairs.Text = dr("Chairs").ToString
            Cb_No_Of_Sofa.Text = dr("Sofa").ToString
            Cb_No_Of_Flowers.Text = dr("Flowers").ToString

        End If
        cmd.Dispose()
        dr.Close()
        terminateconnection()
    End Sub

    Private Sub Gb_Services_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gb_Services.Enter
        getconnection()
        Dim command As New SqlCommand("select Distinct(M_Type) from DB_Table_Add_Menu", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        Cb_Menu_Type.DataSource = table
        Cb_Menu_Type.DisplayMember = "M_Type"
        'Cb_Menu_Type.ValueMember = "M_ID"
        terminateconnection()
    End Sub

    Private Sub Gb_Deco_Services_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gb_Deco_Services.Enter
        getconnection()
        Dim command As New SqlCommand("select Distinct(D_Category) From DB_Table_Add_Decoration", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        Cb_Decoration_Categary.DataSource = table
        Cb_Decoration_Categary.DisplayMember = "D_Category"
    End Sub

    Private Sub Cb_Menu_Type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Menu_Type.SelectedIndexChanged
        getconnection()
        Dim command As New SqlCommand("select M_Category from DB_Table_Add_Menu where M_Type= '" + Cb_Menu_Type.Text + "' ", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        Cb_Menu_Categary.DataSource = table
        Cb_Menu_Categary.DisplayMember = "M_Category"
        'Cb_Menu_Categary.ValueMember = "M_ID"
        terminateconnection()

        Cb_Breakfast.Checked = False
        Cb_Starters.Checked = False
        Cb_Lunch.Checked = False
        Cb_Dinner.Checked = False
        Cb_Sweet.Checked = False
        Cb_IceCream.Checked = False
        Cb_NOP_Breakfast.Text = 0
        Cb_NOP_Vg_Starter.Text = 0
        Cb_NOP_NVg_Starter.Text = 0
        Cb_NOP_Vg_Lunch.Text = 0
        Cb_NOP_NVg_Lunch.Text = 0
        Cb_NOP_Vg_Dinner.Text = 0
        Cb_NOP_NVg_Dinner.Text = 0
        Cb_NOP_IceCrem.Text = 0
        Cb_NOP_Sweet.Text = 0
    End Sub

    Private Sub Cb_Decoration_Categary_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Decoration_Categary.SelectedIndexChanged
        getconnection()
        Dim command As New SqlCommand("select D_Type from DB_Table_Add_Decoration where D_Category= '" + Cb_Decoration_Categary.Text + "' ", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        Cb_Light_Music.DataSource = table
        Cb_Light_Music.DisplayMember = "D_Type"
        terminateconnection()

        Cb_No_Of_Chairs.SelectedIndex = 0
        Cb_No_Of_Sofa.SelectedIndex = 0
        Cb_No_Of_Flowers.SelectedIndex = 0

    End Sub

    Private Sub Cb_Menu_Categary_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Menu_Categary.SelectedIndexChanged
        Cb_Menu_Services.Checked = True
    End Sub

    Private Sub Cb_Menu_Services_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Menu_Services.CheckedChanged
        If Cb_Menu_Services.Checked = True Then
            Gb_Services.Enabled = True
        Else
            clear_menu()
        End If
    End Sub

    'Private Sub Cb_NOP_Breakfast_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_NOP_Breakfast.SelectedIndexChanged
    '    Cb_Breakfast.Checked = True
    'End Sub

    'Private Sub Cb_NOP_NVg_Starter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_NOP_NVg_Starter.SelectedIndexChanged
    '    Cb_Starters.Checked = True
    'End Sub

    'Private Sub Cb_NOP_Vg_Starter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_NOP_Vg_Starter.SelectedIndexChanged
    '    Cb_Starters.Checked = True
    'End Sub

    'Private Sub Cb_NOP_NVg_Lunch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_NOP_NVg_Lunch.SelectedIndexChanged
    '    Cb_Lunch.Checked = True
    'End Sub

    'Private Sub Cb_NOP_Vg_Lunch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_NOP_Vg_Lunch.SelectedIndexChanged
    '    Cb_Lunch.Checked = True
    'End Sub

    'Private Sub Cb_NOP_NVg_Dinner_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_NOP_NVg_Dinner.SelectedIndexChanged
    '    Cb_Dinner.Checked = True
    'End Sub

    'Private Sub Cb_NOP_Vg_Dinner_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_NOP_Vg_Dinner.SelectedIndexChanged
    '    Cb_Dinner.Checked = True
    'End Sub

    'Private Sub Cb_NOP_Sweet_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_NOP_Sweet.SelectedIndexChanged
    '    Cb_Sweet.Checked = True
    'End Sub

    'Private Sub Cb_NOP_IceCrem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_NOP_IceCrem.SelectedIndexChanged
    '    Cb_IceCream.Checked = True
    'End Sub

    Private Sub Cb_Breakfast_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Breakfast.CheckedChanged
        If Cb_Breakfast.Checked = True Then
            Cb_NOP_Breakfast.Enabled = True
        Else
            Cb_NOP_Breakfast.Enabled = False
        End If
    End Sub

    Private Sub Cb_Lunch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Lunch.CheckedChanged
        If Cb_Lunch.Checked = True Then
            If Cb_Menu_Type.Text = "Vegitarian" Then
                Cb_NOP_Vg_Lunch.Enabled = True
                Cb_NOP_NVg_Lunch.Enabled = False
            ElseIf Cb_Menu_Type.Text = "Non-Vegitarian" Then
                Cb_NOP_Vg_Lunch.Enabled = False
                Cb_NOP_NVg_Lunch.Enabled = True
            Else
                Cb_NOP_Vg_Lunch.Enabled = True
                Cb_NOP_NVg_Lunch.Enabled = True
            End If
        Else
            Cb_NOP_Vg_Lunch.Enabled = False
            Cb_NOP_NVg_Lunch.Enabled = False
            Cb_NOP_Vg_Lunch.SelectedIndex = -1
            Cb_NOP_NVg_Lunch.SelectedIndex = -1
        End If
    End Sub

    Private Sub Cb_Dinner_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Dinner.CheckedChanged
        If Cb_Dinner.Checked = True Then
            If Cb_Menu_Type.Text = "Vegitarian" Then
                Cb_NOP_Vg_Dinner.Enabled = True
                Cb_NOP_NVg_Dinner.Enabled = False
            ElseIf Cb_Menu_Type.Text = "Non-Vegitarian" Then
                Cb_NOP_Vg_Dinner.Enabled = False
                Cb_NOP_NVg_Dinner.Enabled = True
            Else
                Cb_NOP_Vg_Dinner.Enabled = True
                Cb_NOP_NVg_Dinner.Enabled = True
            End If
        Else
            Cb_NOP_Vg_Dinner.Enabled = False
            Cb_NOP_NVg_Dinner.Enabled = False
            Cb_NOP_Vg_Dinner.SelectedIndex = -1
            Cb_NOP_NVg_Dinner.SelectedIndex = -1
        End If
    End Sub

    Private Sub Cb_Sweet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Sweet.CheckedChanged
        If Cb_Sweet.Checked = True Then
            Cb_NOP_Sweet.Enabled = True
        Else
            Cb_NOP_Sweet.Enabled = False
        End If
    End Sub

    Private Sub Cb_IceCream_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_IceCream.CheckedChanged
        If Cb_IceCream.Checked = True Then
            Cb_NOP_IceCrem.Enabled = True
        Else
            Cb_NOP_IceCrem.Enabled = False
        End If
    End Sub

    Private Sub Cb_Starters_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Starters.CheckedChanged
        If Cb_Starters.Checked = True Then
            If Cb_Menu_Type.Text = "Vegitarian" Then
                Cb_NOP_Vg_Starter.Enabled = True
                Cb_NOP_NVg_Starter.Enabled = False
            ElseIf Cb_Menu_Type.Text = "Non-Vegitarian" Then
                Cb_NOP_Vg_Starter.Enabled = False
                Cb_NOP_NVg_Starter.Enabled = True
            Else
                Cb_NOP_Vg_Starter.Enabled = True
                Cb_NOP_NVg_Starter.Enabled = True
            End If
        Else
            Cb_NOP_Vg_Starter.Enabled = False
            Cb_NOP_NVg_Starter.Enabled = False
            Cb_NOP_Vg_Starter.SelectedIndex = -1
            Cb_NOP_NVg_Starter.SelectedIndex = -1
        End If
    End Sub

    Private Sub Cb_Light_Music_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Light_Music.SelectedIndexChanged
        If Cb_Light_Music.Text <> "" Then
            Cb_Decoration_Services.Checked = True
        End If

    End Sub

    Private Sub Cb_Decoration_Services_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Decoration_Services.CheckedChanged
        If Cb_Decoration_Services.Checked = True Then
            Gb_Deco_Services.Enabled = True
        Else
            Gb_Deco_Services.Enabled = False
            Cb_Decoration_Categary.Text = ""
            Cb_Light_Music.Text = ""
            Cb_No_Of_Chairs.SelectedIndex = -1
            Cb_No_Of_Sofa.SelectedIndex = -1
            Cb_No_Of_Flowers.SelectedIndex = -1
        End If
    End Sub

    Private Sub Btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Back.Click
        Me.Hide()
        Frm_View_Single_Customer.MdiParent = MDI_Main_Form
        Frm_View_Single_Customer.WindowState = FormWindowState.Maximized
        Frm_View_Single_Customer.Show()
        Book_clear()
    End Sub

    Private Sub Btn_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Next.Click
        Me.Hide()
        Frm_View_S_Event_Charges.MdiParent = MDI_Main_Form
        Frm_View_S_Event_Charges.WindowState = FormWindowState.Maximized
        Frm_View_S_Event_Charges.Show()
        Book_clear()
    End Sub

    Private Sub Btn_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Update.Click
        getconnection()

         
        If Cb_Menu_Services.Checked = False And Cb_Decoration_Services.Checked = False Then
            Cb_Menu_Type.Text = ""
            Cb_Menu_Categary.Text = ""
            Cb_NOP_Breakfast.Text = 0
            Cb_NOP_Vg_Starter.Text = 0
            Cb_NOP_NVg_Starter.Text = 0
            Cb_NOP_Vg_Lunch.Text = 0
            Cb_NOP_NVg_Lunch.Text = 0
            Cb_NOP_Vg_Dinner.Text = 0
            Cb_NOP_NVg_Dinner.Text = 0
            Cb_NOP_IceCrem.Text = 0
            Cb_NOP_Sweet.Text = 0
            Cb_Decoration_Categary.Text = ""
            Cb_Light_Music.Text = ""
            Cb_No_Of_Chairs.Text = 0
            Cb_No_Of_Sofa.Text = 0
            Cb_No_Of_Flowers.Text = 0
        End If
        '...................................................................................................................................................................................................
        If Cb_Decoration_Services.Checked = False Then
            Cb_Decoration_Categary.Text = ""
            Cb_Light_Music.Text = ""
            Cb_No_Of_Chairs.Text = 0
            Cb_No_Of_Sofa.Text = 0
            Cb_No_Of_Flowers.Text = 0

        End If
        '....................................................................................................................................................................................................................
        If Cb_Menu_Services.Checked = False Then
            Cb_Menu_Type.Text = ""
            Cb_Menu_Categary.Text = ""
            Cb_NOP_Breakfast.Text = 0
            Cb_NOP_Vg_Starter.Text = 0
            Cb_NOP_NVg_Starter.Text = 0
            Cb_NOP_Vg_Lunch.Text = 0
            Cb_NOP_NVg_Lunch.Text = 0
            Cb_NOP_Vg_Dinner.Text = 0
            Cb_NOP_NVg_Dinner.Text = 0
            Cb_NOP_IceCrem.Text = 0
            Cb_NOP_Sweet.Text = 0

        End If
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If Tb_Venue.Text = "" Or Cb_Venue_Type.Text = "" Then
            MessageBox.Show("Plese fill Venue field...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '....................................................................................................................................................................................................
            If Cb_Menu_Services.Checked = True Then
                If Cb_Breakfast.Checked = False And Cb_Dinner.Checked = False And Cb_Lunch.Checked = False And Cb_Starters.Checked = False And Cb_IceCream.Checked = False And Cb_Sweet.Checked = False Then
                    MessageBox.Show("Plese Select at lest one Menu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
            '...........................................................................................................................................................................................................
        Else
            cmd = New SqlCommand("Update Tb_Services set Venue='" & Tb_Venue.Text & "',V_Type='" & Cb_Venue_Type.Text & "',M_Type='" & Cb_Menu_Type.Text & "',M_Package='" & Cb_Menu_Categary.Text & "',Breakfast=" & Cb_NOP_Breakfast.Text & ",V_Starters=" & Cb_NOP_Vg_Starter.Text & ",Nv_Starters=" & Cb_NOP_NVg_Starter.Text & ",V_Lunch =" & Cb_NOP_Vg_Lunch.Text & ",Nv_Lunch=" & Cb_NOP_NVg_Lunch.Text & ",V_Dinner=" & Cb_NOP_Vg_Dinner.Text & ",Nv_Dinner=" & Cb_NOP_NVg_Dinner.Text & ",Icecream=" & Cb_NOP_IceCrem.Text & ",Sweet=" & Cb_NOP_Sweet.Text & ",D_Categary='" & Cb_Decoration_Categary.Text & "',LM_Type='" & Cb_Light_Music.Text & "',Chairs=" & Cb_No_Of_Chairs.Text & ",Sofa=" & Cb_No_Of_Sofa.Text & ",Flowers=" & Cb_No_Of_Flowers.Text & " where cust_id = " & cust_id & "", connection)

            cmd.ExecuteNonQuery()

            All_Menu_Charge()
            All_Decoration_Charge()

            MsgBox("Record Updated Sucessfully")
            Frm_View_Single_Customer.Update_Cnt = 2
            All_Decoration_Charge()
            All_Menu_Charge()
            TextBox2.Text = Decoration_charge
            TextBox1.Text = Menu_charge


            cmd.Dispose()
        End If

        terminateconnection()
    End Sub

    Private Sub Tb_Venue_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Venue.Enter
        Venue_cnt = 1
    End Sub
End Class