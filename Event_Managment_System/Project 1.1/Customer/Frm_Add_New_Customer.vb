Imports System.Data.SqlClient
Public Class Frm_Add_New_Customer
    Public Cust_cnt As Integer = 0
    Function Cust_Clear()
        Tb_Adress.Text = ""
        Tb_Customer_Name.Text = ""
        Tb_Mobile_Num_1.Text = ""
        Tb_Mobile_Num_2.Text = ""
        Tb_Event_Name.Text = ""
        Cb_Event_Type.SelectedIndex = -1
        Cb_Event_Type.SelectedIndex = -1
        Cb_No_Of_Persons.SelectedIndex = -1
        Cb_No_Of_Persons.Text = ""
        DTP_Start.Text = ""
        DTP_Stop.Text = ""
        DateTimePicker1.Text = ""

        If Cust_cnt = 2 Then
            Frm_Booking_Event.Book_clear()
            getconnection()
            'cmd = New SqlCommand("Delete from Tb_Personal_info  where Cust_id = " & Comman_Class.Cust_id & "", connection)

            cmd = New SqlCommand("Delete from Tb_Personal_info  where Cust_id = " & Tb_Customer_ID.Text & "", connection)
            cmd.ExecuteNonQuery()
            'MsgBox("Record Deleted Sucessfully")

            terminateconnection()
        End If
        Return 1
    End Function
    Private Sub Frm_Add_New_Customer_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getconnection()
        Tb_Customer_ID.Text = Auto_Increment("select count(Cust_id)from Tb_Personal_info ", 1001)
        Cust_cnt = 1
        terminateconnection()
    End Sub
    Private Sub Frm_Add_New_Customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Timer1.Enabled = True
        getconnection()
        Tb_Customer_ID.Text = Auto_Increment("select count(Cust_id)from Tb_Personal_info ", 1001)
        Cust_cnt = 1

        terminateconnection()
    End Sub
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Frm_Booking_Event.MdiParent = MDI_Main_Form
        Frm_Booking_Event.WindowState = FormWindowState.Maximized
        Frm_Booking_Event.Show()
    End Sub
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
        If Tb_Mobile_Num_2.Text = "" Then
            Tb_Mobile_Num_2.Text = 0
        End If
        getconnection()


        Dim command As New SqlCommand("select Distinct(E_Type) from DB_Table_Add_Event ", connection)

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        Cb_Event_Type.DataSource = table

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
    Private Sub Tb_Customer_Name_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Customer_Name.KeyPress
        Numlock(e)
    End Sub
    Private Sub Tb_Mobile_Num_1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Mobile_Num_1.KeyPress
        Charlock(e)
    End Sub
    Private Sub Tb_Mobile_Num_2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb_Mobile_Num_2.KeyPress
        Charlock(e)
    End Sub
    Private Sub Tb_Mobile_Num_1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Mobile_Num_1.Leave
        Mobile_No(Tb_Mobile_Num_1.TextLength)
    End Sub
    Private Sub Tb_Mobile_Num_2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Mobile_Num_2.Leave
        Mobile_No(Tb_Mobile_Num_2.TextLength)
    End Sub
    Private Sub Btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MDI_Main_Form.Show()
        Me.Hide()
    End Sub
    Private Sub Btn_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Next.Click
        getconnection()
        Comman_Class.Cust_id = Tb_Customer_ID.Text

        cmd.Connection = connection
        If Tb_Customer_Name.Text = "" Or Tb_Adress.Text = "" Or Tb_Mobile_Num_1.Text = "" Or Tb_Event_Name.Text = "" Or Cb_Event_Package.Text = "" Or Cb_Event_Type.Text = "" Or Cb_No_Of_Persons.Text = "" Then
            MessageBox.Show("Plese fill all the field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            If Date.Today > DateTimePicker1.Value Then
                MsgBox("Please Check Date...")

            ElseIf DTP_Start.Value > DTP_Stop.Value Then
                MsgBox("Please Check Time...")
            ElseIf DTP_Start.Value = DTP_Stop.Value Then
                MsgBox("Please Check Time...")


            Else
                Me.Hide()
                Frm_Booking_Event.MdiParent = MDI_Main_Form
                Frm_Booking_Event.WindowState = FormWindowState.Maximized
                Frm_Booking_Event.Show()

                If Cust_cnt = 1 Then
                    'cmd = New SqlCommand("insert into Tb_Personal_info values (" & Tb_Customer_ID.Text & ",'" & Tb_Customer_Name.Text & "','" & Tb_Adress.Text & "'," & Tb_Mobile_Num_1.Text & "," & Tb_Mobile_Num_2.Text & ",'" & Tb_Event_Name.Text & "','" & Cb_Event_Type.Text & "','" & Cb_Event_Package.Text & "'," & Cb_No_Of_Persons.Text & ",'" & DateTimePicker1.Text & "','" & DTP_Start.Text & "','" & DTP_Stop.Text & "' )", connection)
                    cmd.CommandText = "insert into Tb_Personal_info values (" & Tb_Customer_ID.Text & ",'" & Tb_Customer_Name.Text & "','" & Tb_Adress.Text & "'," & Tb_Mobile_Num_1.Text & "," & Tb_Mobile_Num_2.Text & ",'" & Tb_Event_Name.Text & "','" & Cb_Event_Type.Text & "','" & Cb_Event_Package.Text & "'," & Cb_No_Of_Persons.Text & ",'" & DateTimePicker1.Text & "','" & DTP_Start.Text & "','" & DTP_Stop.Text & "' )"
                    cmd.ExecuteNonQuery()
                    'MsgBox("Record Saved Sucessfully")
                    Cust_cnt = 2
                    cmd.Dispose()
                Else
                    '  cmd = New SqlCommand("Update Tb_Personal_info Set Cust_Name = '" & Tb_Customer_Name.Text & "',Cust_Address= '" & Tb_Adress.Text & "',Cust_Mo_1= " & Tb_Mobile_Num_1.Text & ",Cust_Mo_2= " & Tb_Mobile_Num_2.Text & ",E_Name='" & Tb_Event_Name.Text & "',E_Type='" & Cb_Event_Type.Text & "',E_Package='" & Cb_Event_Package.Text & "',E_NOP=" & Cb_No_Of_Persons.Text & ",E_Date='" & DateTimePicker1.Text & "',E_Time_Start='" & DTP_Start.Text & "',E_Time_Stop='" & DTP_Stop.Text & "' where Cust_id = " & Tb_Customer_ID.Text & " )", connection)
                    cmd = New SqlCommand("Update Tb_Personal_info Set Cust_Name = '" + Tb_Customer_Name.Text + "',Cust_Address= '" + Tb_Adress.Text + "',Cust_Mo_1= " + Tb_Mobile_Num_1.Text + ",Cust_Mo_2= " + Tb_Mobile_Num_2.Text + ",E_Name='" + Tb_Event_Name.Text + "',E_Type='" + Cb_Event_Type.Text + "',E_Package='" + Cb_Event_Package.Text + "',E_NOP=" + Cb_No_Of_Persons.Text + ",E_Date='" + DateTimePicker1.Text + "',E_Time_Start='" + DTP_Start.Text + "',E_Time_Stop='" + DTP_Stop.Text + "' where Cust_id = " + Tb_Customer_ID.Text + "", connection)
                    cmd.ExecuteNonQuery()
                    ' MsgBox("Record U Sucessfully")

                    cmd.Dispose()
                End If
            End If


        End If

        'MDI_Main_Form.MenuStrip.Enabled = False
        terminateconnection()
    End Sub
    Private Sub Btn_Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Refresh.Click
        Cust_Clear()
    End Sub
    
    Private Sub Cb_No_Of_Persons_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cb_No_Of_Persons.KeyPress
        Charlock(e)
    End Sub

    Private Sub DateTimePicker1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.Leave
        getconnection()
        Dim dr As SqlDataReader
        cmd = New SqlCommand("SELECT E_Date FROM Tb_Personal_info", connection)
        dr = cmd.ExecuteReader
        While dr.Read
            If DateTimePicker1.Text = dr("E_Date") Then
                MsgBox("This Date is alrady booked....!")
            End If
        End While

        terminateconnection()
    End Sub
End Class

