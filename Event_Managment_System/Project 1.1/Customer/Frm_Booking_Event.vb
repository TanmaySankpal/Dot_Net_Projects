Imports System.Data.SqlClient

Public Class Frm_Booking_Event
    Public cntt As Integer = 0
    Public Menu_charge As Integer = 0
    Public Decoration_charge As Integer = 0
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
        'TextBox2.Text = Menu_charge
        'TextBox2.Text = (Val(Bf_charge) * Val(Cb_NOP_Breakfast.Text)) + (Val(Vg_Starter_charge) * Val(Cb_NOP_Vg_Starter.Text)) + (Val(NV_Starter_charge) * Val(Cb_NOP_NVg_Starter.Text)) + (Val(Lunch_Charge) * Val(Cb_NOP_Vg_Lunch.Text)) + (Val(NV_Lunch_Charge) * Val(Cb_NOP_NVg_Lunch.Text)) + (Val(Dinner_Charge) * Val(Cb_NOP_Vg_Dinner.Text)) + (Val(NV_Dinner_Charge) * Val(Cb_NOP_NVg_Dinner.Text)) + (Val(Sweet_Charge) * Val(Cb_NOP_Sweet.Text)) + (Val(Ice_Charge) * Val(Cb_NOP_IceCrem.Text))
        command2.Dispose()
        drr.Close()
        'terminateconnection()
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
        Frm_Event_Charges.Tb_Decoration_Charges.Text = D_chrge
        dr.Close()
        command.Dispose()
        'chrge = 0
        Return 1
    End Function
    Private Sub Frm_Booking_Event_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getconnection()
        cntt = 1
        terminateconnection()
    End Sub
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
        Cb_Decoration_Categary.SelectedIndex = -1
        Cb_Light_Music.SelectedIndex = -1
        Cb_No_Of_Chairs.SelectedIndex = -1
        Cb_No_Of_Sofa.SelectedIndex = -1
        Cb_No_Of_Flowers.SelectedIndex = -1

        getconnection()

        If cntt = 2 Then
            cmd = New SqlCommand("Delete from Tb_Services where Cust_id = " & Comman_Class.Cust_id & "", connection)
            cmd.ExecuteNonQuery()
            'MsgBox("Booking Remove Suceesss")
            Frm_Event_Charges.Event_Charges_clear()
        End If

        terminateconnection()
        Return 1
    End Function
    Private Sub Cb_Menu_Services_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Menu_Services.CheckedChanged
        If Cb_Menu_Services.Checked = True Then
            Gb_Services.Enabled = True
            Cb_NOP_Breakfast.SelectedIndex = 0
            Cb_NOP_IceCrem.SelectedIndex = 0
            Cb_NOP_NVg_Dinner.SelectedIndex = 0
            Cb_NOP_NVg_Lunch.SelectedIndex = 0
            Cb_NOP_NVg_Starter.SelectedIndex = 0
            Cb_NOP_Sweet.SelectedIndex = 0
            Cb_NOP_Vg_Dinner.SelectedIndex = 0
            Cb_NOP_Vg_Lunch.SelectedIndex = 0
            Cb_NOP_NVg_Starter.SelectedIndex = 0
            Cb_NOP_Vg_Starter.SelectedIndex = 0
        Else
            Gb_Services.Enabled = False
            Cb_Menu_Type.SelectedIndex = -1
            Cb_Menu_Categary.SelectedIndex = -1
            Cb_NOP_Breakfast.SelectedIndex = -1
            Cb_NOP_IceCrem.SelectedIndex = -1
            Cb_NOP_NVg_Dinner.SelectedIndex = -1
            Cb_NOP_NVg_Lunch.SelectedIndex = -1
            Cb_NOP_NVg_Starter.SelectedIndex = -1
            Cb_NOP_Sweet.SelectedIndex = -1
            Cb_NOP_Vg_Dinner.SelectedIndex = -1
            Cb_NOP_Vg_Lunch.SelectedIndex = -1
            Cb_NOP_NVg_Starter.SelectedIndex = -1
            Cb_NOP_Vg_Starter.SelectedIndex = -1

            Cb_Breakfast.Checked = False
            Cb_Starters.Checked = False
            Cb_Dinner.Checked = False
            Cb_IceCream.Checked = False
            Cb_Lunch.Checked = False
            Cb_Sweet.Checked = False

        End If
    End Sub
    Private Sub Cb_Decoration_Services_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Decoration_Services.CheckedChanged
        If Cb_Decoration_Services.Checked = True Then
            Gb_Deco_Services.Enabled = True
            Cb_No_Of_Chairs.SelectedIndex = 0
            Cb_No_Of_Sofa.SelectedIndex = 0
            Cb_No_Of_Flowers.SelectedIndex = 0
        Else
            Gb_Deco_Services.Enabled = False
            Cb_Decoration_Categary.SelectedIndex = -1
            Cb_Light_Music.SelectedIndex = -1
            Cb_No_Of_Chairs.SelectedIndex = -1
            Cb_No_Of_Sofa.SelectedIndex = -1
            Cb_No_Of_Flowers.SelectedIndex = -1

        End If
    End Sub
    Private Sub Chkb_Breakfast_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Breakfast.CheckedChanged
        If Cb_Breakfast.Checked = True Then
            Cb_NOP_Breakfast.Enabled = True
            Cb_NOP_Breakfast.SelectedIndex = 0
            '.................................................................................................................
           
            '............................................................................................................
        Else
            Cb_NOP_Breakfast.Enabled = False
            Cb_NOP_Breakfast.SelectedIndex = -0
        End If
    End Sub
    Private Sub Cb_Starters_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Starters.CheckedChanged
        If Cb_Starters.Checked = True Then
            If Cb_Menu_Type.Text = "Vegitarian" Then
                Cb_NOP_NVg_Starter.Enabled = False
                Cb_NOP_Vg_Starter.Enabled = True
                Cb_NOP_Vg_Starter.SelectedIndex = 0
            ElseIf Cb_Menu_Type.Text = "Non-Vegitarian" Then
                Cb_NOP_NVg_Starter.Enabled = True
                Cb_NOP_Vg_Starter.Enabled = False
                Cb_NOP_NVg_Starter.SelectedIndex = 0
            Else
                Cb_NOP_NVg_Starter.Enabled = True
                Cb_NOP_Vg_Starter.Enabled = True
                Cb_NOP_NVg_Starter.SelectedIndex = 0
                Cb_NOP_Vg_Starter.SelectedIndex = 0
            End If
        Else
            Cb_NOP_NVg_Starter.Enabled = False
            Cb_NOP_Vg_Starter.Enabled = False
            Cb_NOP_NVg_Starter.SelectedIndex = 0
            Cb_NOP_Vg_Starter.SelectedIndex = 0
        End If
    End Sub
    Private Sub Cb_Lunch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Lunch.CheckedChanged
        If Cb_Lunch.Checked = True Then
            If Cb_Menu_Type.Text = "Vegitarian" Then
                Cb_NOP_NVg_Lunch.Enabled = False
                Cb_NOP_Vg_Lunch.Enabled = True
                Cb_NOP_Vg_Lunch.SelectedIndex = 0
            ElseIf Cb_Menu_Type.Text = "Non-Vegitarian" Then
                Cb_NOP_NVg_Lunch.Enabled = True
                Cb_NOP_Vg_Lunch.Enabled = False
                Cb_NOP_NVg_Lunch.SelectedIndex = 0
            Else
                Cb_NOP_NVg_Lunch.Enabled = True
                Cb_NOP_Vg_Lunch.Enabled = True
                Cb_NOP_Vg_Lunch.SelectedIndex = 0
                Cb_NOP_NVg_Lunch.SelectedIndex = 0
            End If
        Else
            Cb_NOP_NVg_Lunch.Enabled = False
            Cb_NOP_Vg_Lunch.Enabled = False
            Cb_NOP_Vg_Lunch.SelectedIndex = 0
            Cb_NOP_NVg_Lunch.SelectedIndex = 0
        End If
    End Sub
    Private Sub Cb_Dinner_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Dinner.CheckedChanged
        If Cb_Dinner.Checked = True Then
            If Cb_Menu_Type.Text = "Vegitarian" Then
                Cb_NOP_NVg_Dinner.Enabled = False
                Cb_NOP_Vg_Dinner.Enabled = True
                Cb_NOP_Vg_Dinner.SelectedIndex = 0
            ElseIf Cb_Menu_Type.Text = "Non-Vegitarian" Then
                Cb_NOP_NVg_Dinner.Enabled = True
                Cb_NOP_Vg_Dinner.Enabled = False
                Cb_NOP_NVg_Dinner.SelectedIndex = 0
            Else
                Cb_NOP_NVg_Dinner.Enabled = True
                Cb_NOP_Vg_Dinner.Enabled = True
                Cb_NOP_Vg_Dinner.SelectedIndex = 0
                Cb_NOP_NVg_Dinner.SelectedIndex = 0
            End If
        Else
            Cb_NOP_NVg_Dinner.Enabled = False
            Cb_NOP_Vg_Dinner.Enabled = False
            Cb_NOP_Vg_Dinner.SelectedIndex = 0
            Cb_NOP_NVg_Dinner.SelectedIndex = 0
        End If
    End Sub
    Private Sub Cb_Sweet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Sweet.CheckedChanged
        If Cb_Sweet.Checked = True Then
            Cb_NOP_Sweet.Enabled = True
            Cb_NOP_Sweet.SelectedIndex = 0
        Else
            Cb_NOP_Sweet.Enabled = False
            Cb_NOP_Sweet.SelectedIndex = 0
        End If
    End Sub
    Private Sub Cb_IceCream_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_IceCream.CheckedChanged
        If Cb_IceCream.Checked = True Then
            Cb_NOP_IceCrem.Enabled = True
            Cb_NOP_IceCrem.SelectedIndex = 0
        Else
            Cb_NOP_IceCrem.Enabled = False
            Cb_NOP_IceCrem.SelectedIndex = 0
        End If
    End Sub
    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter
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
    End Sub
    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter
        getconnection()
        Dim command As New SqlCommand("select Distinct(D_Category) From DB_Table_Add_Decoration", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        Cb_Decoration_Categary.DataSource = table
        Cb_Decoration_Categary.DisplayMember = "D_Category"
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
    End Sub
    Private Sub Btn_Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Refresh.Click
        Book_clear()
        
    End Sub
    Private Sub Btn_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Next.Click
        getconnection()

        If cntt = 1 Then
            If Cb_Menu_Services.Checked = False And Cb_Decoration_Services.Checked = False Then

                If Tb_Venue.Text = "" Or Cb_Venue_Type.Text = "" Then
                    MessageBox.Show("Please fill all the field..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    cmd = New SqlCommand("insert into Tb_Services(Cust_id,Venue,V_Type) values ( " & Comman_Class.Cust_id & ",'" & Tb_Venue.Text & "','" & Cb_Venue_Type.Text & "')", connection)
                    cmd.ExecuteNonQuery()

                    Me.Hide()
                    Frm_Event_Charges.MdiParent = MDI_Main_Form
                    Frm_Event_Charges.WindowState = FormWindowState.Maximized
                    Frm_Event_Charges.Show()
                    ' MsgBox("Record Saved Sucessfully")
                    cntt = 2
                    cmd.Dispose()

                End If
                '...................................................................................................................................................................................................
            ElseIf Cb_Decoration_Services.Checked = False Then
                If Tb_Venue.Text = "" Or Cb_Venue_Type.Text = "" Then
                    MessageBox.Show("Plese fill all the field...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ElseIf Cb_Breakfast.Checked = False And Cb_Dinner.Checked = False And Cb_Lunch.Checked = False And Cb_Starters.Checked = False And Cb_IceCream.Checked = False And Cb_Sweet.Checked = False Then
                    MessageBox.Show("Plese Select at lest one Menu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    cmd = New SqlCommand("insert into Tb_Services(Cust_id,Venue,V_Type,M_Type,M_Package,Breakfast,V_Starters,Nv_Starters,V_Lunch,Nv_Lunch,V_Dinner,Nv_Dinner,Icecream,Sweet) values (" & Comman_Class.Cust_id & ",'" & Tb_Venue.Text & "','" & Cb_Venue_Type.Text & "','" & Cb_Menu_Type.Text & "','" & Cb_Menu_Categary.Text & "'," & Cb_NOP_Breakfast.Text & "," & Cb_NOP_Vg_Starter.Text & "," & Cb_NOP_NVg_Starter.Text & "," & Cb_NOP_Vg_Lunch.Text & "," & Cb_NOP_NVg_Lunch.Text & "," & Cb_NOP_Vg_Dinner.Text & "," & Cb_NOP_NVg_Dinner.Text & "," & Cb_NOP_IceCrem.Text & "," & Cb_NOP_Sweet.Text & ")", connection)
                    cmd.ExecuteNonQuery()

                    All_Menu_Charge()

                    Me.Hide()
                    Frm_Event_Charges.MdiParent = MDI_Main_Form
                    Frm_Event_Charges.WindowState = FormWindowState.Maximized
                    Frm_Event_Charges.Show()
                    ' MsgBox("Record Saved Sucessfully")
                    '.....................................................................................................

                    '.....................................................................................................
                    cntt = 2
                    cmd.Dispose()
                End If
                '....................................................................................................................................................................................................................
            ElseIf Cb_Menu_Services.Checked = False Then
                If Tb_Venue.Text = "" Or Cb_Venue_Type.Text = "" Then
                    MessageBox.Show("Plese fill all the field...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    cmd = New SqlCommand("insert into Tb_Services(Cust_id,Venue,V_Type,D_Categary,LM_Type,Chairs,Sofa,Flowers) values (" & Comman_Class.Cust_id & ",'" & Tb_Venue.Text & "','" & Cb_Venue_Type.Text & "','" & Cb_Decoration_Categary.Text & "','" & Cb_Light_Music.Text & "'," & Cb_No_Of_Chairs.Text & "," & Cb_No_Of_Sofa.Text & "," & Cb_No_Of_Flowers.Text & ")", connection)
                    cmd.ExecuteNonQuery()

                    All_Decoration_Charge()

                    Me.Hide()
                    Frm_Event_Charges.MdiParent = MDI_Main_Form
                    Frm_Event_Charges.WindowState = FormWindowState.Maximized
                    Frm_Event_Charges.Show()
                    ' MsgBox("Record Saved Sucessfully")
                    cntt = 2
                    cmd.Dispose()
                End If
                '..........................................................................................................................................................................................................................
            Else
                If Tb_Venue.Text = "" Or Cb_Venue_Type.Text = "" Then
                    MessageBox.Show("Plese fill all the field...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                ElseIf Cb_Breakfast.Checked = False And Cb_Dinner.Checked = False And Cb_Lunch.Checked = False And Cb_Starters.Checked = False And Cb_IceCream.Checked = False And Cb_Sweet.Checked = False Then
                    MessageBox.Show("Plese Select at lest one Menu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                Else
                    cmd = New SqlCommand("insert into Tb_Services(Cust_id,Venue,V_Type,M_Type,M_Package,Breakfast,V_Starters,Nv_Starters,V_Lunch,Nv_Lunch,V_Dinner,Nv_Dinner,Icecream,Sweet,D_Categary,LM_Type,Chairs,Sofa,Flowers) values (" & Comman_Class.Cust_id & ",'" & Tb_Venue.Text & "','" & Cb_Venue_Type.Text & "','" & Cb_Menu_Type.Text & "','" & Cb_Menu_Categary.Text & "'," & Cb_NOP_Breakfast.Text & "," & Cb_NOP_Vg_Starter.Text & "," & Cb_NOP_NVg_Starter.Text & "," & Cb_NOP_Vg_Lunch.Text & "," & Cb_NOP_NVg_Lunch.Text & "," & Cb_NOP_Vg_Dinner.Text & "," & Cb_NOP_NVg_Dinner.Text & "," & Cb_NOP_IceCrem.Text & "," & Cb_NOP_Sweet.Text & ",'" & Cb_Decoration_Categary.Text & "','" & Cb_Light_Music.Text & "'," & Cb_No_Of_Chairs.Text & "," & Cb_No_Of_Sofa.Text & "," & Cb_No_Of_Flowers.Text & " )", connection)
                    cmd.ExecuteNonQuery()

                    All_Menu_Charge()
                    All_Decoration_Charge()

                    Me.Hide()
                    Frm_Event_Charges.MdiParent = MDI_Main_Form
                    Frm_Event_Charges.WindowState = FormWindowState.Maximized
                    Frm_Event_Charges.Show()
                    'MsgBox("Record Saved Sucessfully")
                    cntt = 2
                    cmd.Dispose()
                End If
            End If


            '.........................Update...........................................................................................................................................................................................................
        Else


            If Cb_Menu_Services.Checked = False And Cb_Decoration_Services.Checked = False Then

                If Tb_Venue.Text = "" Or Cb_Venue_Type.Text = "" Then
                    MessageBox.Show("Please fill all the field..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    cmd = New SqlCommand("Update Tb_Services set Venue='" & Tb_Venue.Text & "',V_Type='" & Cb_Venue_Type.Text & "' where Cust_id=" & Comman_Class.Cust_id & " ", connection)
                    cmd.ExecuteNonQuery()
                    All_Menu_Charge()
                    All_Decoration_Charge()
                    Me.Hide()
                    Frm_Event_Charges.MdiParent = MDI_Main_Form
                    Frm_Event_Charges.WindowState = FormWindowState.Maximized
                    Frm_Event_Charges.Show()
                    'MsgBox("Record U Sucessfully")
                    cmd.Dispose()
                End If
                '...................................................................................................................................................................................................
            ElseIf Cb_Decoration_Services.Checked = False Then
                If Tb_Venue.Text = "" Or Cb_Venue_Type.Text = "" Then
                    MessageBox.Show("Plese fill all the field...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ElseIf Cb_Breakfast.Checked = False And Cb_Dinner.Checked = False And Cb_Lunch.Checked = False And Cb_Starters.Checked = False And Cb_IceCream.Checked = False And Cb_Sweet.Checked = False Then
                    MessageBox.Show("Plese Select at lest one Menu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    cmd = New SqlCommand("Update Tb_Services set Venue='" & Tb_Venue.Text & "',V_Type='" & Cb_Venue_Type.Text & "', M_Type='" & Cb_Menu_Type.Text & "',M_Package='" & Cb_Menu_Categary.Text & "',Breakfast=" & Cb_NOP_Breakfast.Text & ",V_Starters=" & Cb_NOP_Vg_Starter.Text & ",Nv_Starters=" & Cb_NOP_NVg_Starter.Text & ",V_Lunch =" & Cb_NOP_Vg_Lunch.Text & ",Nv_Lunch=" & Cb_NOP_NVg_Lunch.Text & ",V_Dinner=" & Cb_NOP_Vg_Dinner.Text & ",Nv_Dinner=" & Cb_NOP_NVg_Dinner.Text & ",Icecream=" & Cb_NOP_IceCrem.Text & ",Sweet=" & Cb_NOP_Sweet.Text & " where Cust_id=" & Comman_Class.Cust_id & " ", connection)

                    cmd.ExecuteNonQuery()

                    All_Menu_Charge()
                    All_Decoration_Charge()
                    Me.Hide()
                    Frm_Event_Charges.MdiParent = MDI_Main_Form
                    Frm_Event_Charges.WindowState = FormWindowState.Maximized
                    Frm_Event_Charges.Show()
                    'MsgBox("Record U Sucessfully")
                    cmd.Dispose()
                End If
                '....................................................................................................................................................................................................................
            ElseIf Cb_Menu_Services.Checked = False Then
                If Tb_Venue.Text = "" Or Cb_Venue_Type.Text = "" Then
                    MessageBox.Show("Plese fill all the field...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    cmd = New SqlCommand("Update Tb_Services set Venue='" & Tb_Venue.Text & "',V_Type='" & Cb_Venue_Type.Text & "',D_Categary='" & Cb_Decoration_Categary.Text & "',LM_Type='" & Cb_Light_Music.Text & "',Chairs=" & Cb_No_Of_Chairs.Text & ",Sofa=" & Cb_No_Of_Sofa.Text & ",Flowers=" & Cb_No_Of_Flowers.Text & " where Cust_id=" & Comman_Class.Cust_id & " ", connection)
                    cmd.ExecuteNonQuery()
                    All_Menu_Charge()
                    All_Decoration_Charge()
                    Me.Hide()
                    Frm_Event_Charges.MdiParent = MDI_Main_Form
                    Frm_Event_Charges.WindowState = FormWindowState.Maximized
                    Frm_Event_Charges.Show()
                    'MsgBox("Record U Sucessfully")
                    cmd.Dispose()
                End If
                '..........................................................................................................................................................................................................................
            Else
                If Tb_Venue.Text = "" Or Cb_Venue_Type.Text = "" Then
                    MessageBox.Show("Plese fill all the field...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                ElseIf Cb_Breakfast.Checked = False And Cb_Dinner.Checked = False And Cb_Lunch.Checked = False And Cb_Starters.Checked = False And Cb_IceCream.Checked = False And Cb_Sweet.Checked = False Then
                    MessageBox.Show("Plese Select at lest one Menu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                Else
                    cmd = New SqlCommand("Update Tb_Services set Venue='" & Tb_Venue.Text & "',V_Type='" & Cb_Venue_Type.Text & "', M_Type='" & Cb_Menu_Type.Text & "',M_Package='" & Cb_Menu_Categary.Text & "',Breakfast=" & Cb_NOP_Breakfast.Text & ",V_Starters=" & Cb_NOP_Vg_Starter.Text & ",Nv_Starters=" & Cb_NOP_NVg_Starter.Text & ",V_Lunch =" & Cb_NOP_Vg_Lunch.Text & ",Nv_Lunch=" & Cb_NOP_NVg_Lunch.Text & ",V_Dinner=" & Cb_NOP_Vg_Dinner.Text & ",Nv_Dinner=" & Cb_NOP_NVg_Dinner.Text & ",Icecream=" & Cb_NOP_IceCrem.Text & ",Sweet=" & Cb_NOP_Sweet.Text & ",D_Categary='" & Cb_Decoration_Categary.Text & "',LM_Type='" & Cb_Light_Music.Text & "',Chairs=" & Cb_No_Of_Chairs.Text & ",Sofa=" & Cb_No_Of_Sofa.Text & ",Flowers=" & Cb_No_Of_Flowers.Text & " where Cust_id=" & Comman_Class.Cust_id & " ", connection)

                    cmd.ExecuteNonQuery()

                    All_Menu_Charge()
                    All_Decoration_Charge()
                    Me.Hide()
                    Frm_Event_Charges.MdiParent = MDI_Main_Form
                    Frm_Event_Charges.WindowState = FormWindowState.Maximized
                    Frm_Event_Charges.Show()
                    'MsgBox("Record U Sucessfully")
                    cmd.Dispose()
                End If


            End If

        End If

        terminateconnection()
        '.................................................................................................

        '....................................................................................................................


    End Sub
    Private Sub Btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Back.Click
        Me.Hide()
        Frm_Add_New_Customer.MdiParent = MDI_Main_Form
        Frm_Add_New_Customer.WindowState = FormWindowState.Maximized
        Frm_Add_New_Customer.Show()
    End Sub
    Private Sub Btn_Cancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancel.Click
        Book_clear()
        Frm_Add_New_Customer.Cust_cnt = 2
        Frm_Add_New_Customer.Cust_Clear()

        Me.Hide()
        Book_clear()
        Frm_Add_New_Customer.MdiParent = MDI_Main_Form
        Frm_Add_New_Customer.WindowState = FormWindowState.Maximized
        Frm_Add_New_Customer.Show()
    End Sub

    
    Private Sub Cb_NOP_Breakfast_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cb_NOP_Vg_Starter.KeyPress, Cb_NOP_Vg_Lunch.KeyPress, Cb_NOP_Vg_Dinner.KeyPress, Cb_NOP_Sweet.KeyPress, Cb_NOP_NVg_Starter.KeyPress, Cb_NOP_NVg_Lunch.KeyPress, Cb_NOP_NVg_Dinner.KeyPress, Cb_NOP_IceCrem.KeyPress, Cb_NOP_Breakfast.KeyPress, Cb_No_Of_Sofa.KeyPress, Cb_No_Of_Flowers.KeyPress, Cb_No_Of_Chairs.KeyPress
        Charlock(e)
    End Sub
End Class