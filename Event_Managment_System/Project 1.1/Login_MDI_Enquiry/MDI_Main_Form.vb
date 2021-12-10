Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class MDI_Main_Form

    Private Sub ViewAllEnquriesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewAllEnquriesToolStripMenuItem1.Click
        Frm_Add_Enquiry.MdiParent = Me
        Frm_Add_Enquiry.WindowState = FormWindowState.Maximized
        Frm_Add_Enquiry.Show()
        PB_MDI.Visible = False
    End Sub

    Private Sub ViewSingleEnquiryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewSingleEnquiryToolStripMenuItem1.Click
        Frm_view_Single_Enquiry.MdiParent = Me
        Frm_view_Single_Enquiry.WindowState = FormWindowState.Maximized
        Frm_view_Single_Enquiry.Show()
        PB_MDI.Visible = False
    End Sub

    Private Sub ViewAllEnquriesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewAllEnquriesToolStripMenuItem2.Click
        Frm_View_all_Enquiries.MdiParent = Me
        Frm_View_all_Enquiries.WindowState = FormWindowState.Maximized
        Frm_View_all_Enquiries.Show()
        PB_MDI.Visible = False
    End Sub

    Private Sub AddNewCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewCustomerToolStripMenuItem.Click
        Frm_Add_New_Customer.MdiParent = Me
        Frm_Add_New_Customer.WindowState = FormWindowState.Maximized
        Frm_Add_New_Customer.Show()
        PB_MDI.Hide()

    End Sub

    Private Sub ViewSingleCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewSingleCustomerToolStripMenuItem.Click
        Frm_View_Single_Customer.MdiParent = Me
        Frm_View_Single_Customer.WindowState = FormWindowState.Maximized
        Frm_View_Single_Customer.Show()
        PB_MDI.Hide()
    End Sub

    Private Sub ViewAllCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewAllCustomerToolStripMenuItem.Click
        Frm_View_All_Customer.MdiParent = Me
        Frm_View_All_Customer.WindowState = FormWindowState.Maximized
        Frm_View_All_Customer.Show()
        PB_MDI.Hide()

    End Sub

    Private Sub AddNewEventToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewEventToolStripMenuItem.Click
        Frm_Add_New_Event.MdiParent = Me
        Frm_Add_New_Event.WindowState = FormWindowState.Maximized
        Frm_Add_New_Event.Show()
        PB_MDI.Hide()
    End Sub

    Private Sub ViewEventToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewEventToolStripMenuItem.Click
        Frm_View_Event.MdiParent = Me
        Frm_View_Event.WindowState = FormWindowState.Maximized
        Frm_View_Event.Show()
        PB_MDI.Hide()
    End Sub

    Private Sub MenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuToolStripMenuItem.Click
        Frm_Add_New_Menu.MdiParent = Me
        Frm_Add_New_Menu.WindowState = FormWindowState.Maximized
        Frm_Add_New_Menu.Show()
        PB_MDI.Hide()
    End Sub

    Private Sub MenuServicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuServicesToolStripMenuItem.Click
        Frm_View_Menu.MdiParent = Me
        Frm_View_Menu.WindowState = FormWindowState.Maximized
        Frm_View_Menu.Show()
        PB_MDI.Hide()
    End Sub

    Private Sub DecorationServicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecorationServicesToolStripMenuItem.Click
        Frm_Add_New_Decoration.MdiParent = Me
        Frm_Add_New_Decoration.WindowState = FormWindowState.Maximized
        Frm_Add_New_Decoration.Show()
        PB_MDI.Hide()
    End Sub

    Private Sub DecorationServicesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecorationServicesToolStripMenuItem1.Click
        Frm_View_Decoration.MdiParent = Me
        Frm_View_Decoration.WindowState = FormWindowState.Maximized
        Frm_View_Decoration.Show()
        PB_MDI.Hide()
    End Sub

    Private Sub UpdateEventToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateEventToolStripMenuItem.Click
        Frm_Update_Event.MdiParent = Me
        Frm_Update_Event.WindowState = FormWindowState.Maximized
        Frm_Update_Event.Show()
        PB_MDI.Hide()
    End Sub

    Private Sub CaluculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MyApp As New System.Diagnostics.ProcessStartInfo("Calc")
        Process.Start(MyApp)
    End Sub

    Private Sub NotepadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MyApp As New System.Diagnostics.ProcessStartInfo("Notepad")
        Process.Start(MyApp)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Lbl_Date_Time.Text = Date.Now.ToString("dd-MMM-yyyy hh:mm:ss")

    End Sub

    Private Sub MDI_Main_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Label1.Text = "p1" Then
            PB_MDI.Image = WindowsApplication1.My.Resources.Event_Management1
            Label1.Text = "p2"
        ElseIf Label1.Text = "p2" Then
            PB_MDI.Image = WindowsApplication1.My.Resources.bg_2
            Label1.Text = "p3"

        ElseIf Label1.Text = "p3" Then
            PB_MDI.Image = WindowsApplication1.My.Resources.MZH
            Label1.Text = "p4"
        Else
            PB_MDI.Image = WindowsApplication1.My.Resources.shubhaarambh_event
            Label1.Text = "p1"
        End If
    End Sub

    Private Sub UpdateMenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateMenuToolStripMenuItem.Click
        Frm_Update_Menu.MdiParent = Me
        Frm_Update_Menu.WindowState = FormWindowState.Maximized
        Frm_Update_Menu.Show()
        PB_MDI.Hide()
    End Sub

    Private Sub UpdateDecorationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateDecorationToolStripMenuItem.Click
        Frm_Update_Decoration.MdiParent = Me
        Frm_Update_Decoration.WindowState = FormWindowState.Maximized
        Frm_Update_Decoration.Show()
        PB_MDI.Hide()
    End Sub

    Private Sub EnquiryStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Frm_Enquiry_Status.MdiParent = Me
        Frm_Enquiry_Status.WindowState = FormWindowState.Maximized
        Frm_Enquiry_Status.Show()
        PB_MDI.Visible = False
    End Sub

    Private Sub AddNewUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewUserToolStripMenuItem.Click
        Frm_Add_New_User.MdiParent = Me
        Frm_Add_New_User.WindowState = FormWindowState.Maximized
        Frm_Add_New_User.Show()
        PB_MDI.Visible = False
    End Sub

    Private Sub UpdateUserToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateUserToolStripMenuItem.Click
        Frm_Update_User.MdiParent = Me
        Frm_Update_User.WindowState = FormWindowState.Maximized
        Frm_Update_User.Show()
        PB_MDI.Visible = False
    End Sub

    Private Sub ViewAllUsersToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewAllUsersToolStripMenuItem.Click
        Frm_View_All_Employee.MdiParent = Me
        Frm_View_All_Employee.WindowState = FormWindowState.Maximized
        Frm_View_All_Employee.Show()
        PB_MDI.Visible = False
    End Sub

    Private Sub ViewAllUsersToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewAllUsersToolStripMenuItem1.Click
        Frm_View_All_User.MdiParent = Me
        Frm_View_All_User.WindowState = FormWindowState.Maximized
        Frm_View_All_User.Show()
        PB_MDI.Visible = False
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If Frm_Add_New_Customer.Cust_cnt > 1 Then
            Dim Response As MsgBoxResult

            Response = MsgBox(" Are you sure you want to logout without saving customer event details.. ", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Confirm")

            If Response = MsgBoxResult.Yes Then
                If Frm_Booking_Event.cntt > 1 Then
                    Frm_Booking_Event.Book_clear()
                End If
                Frm_Add_New_Customer.Cust_Clear()
                Frm_Add_New_Customer.Cust_cnt = 0
                Me.Hide()
                Frm_Login.Show()
            ElseIf Response = MsgBoxResult.No Then
                Me.Show()
            End If

        ElseIf Frm_View_Single_Customer.Update_Cnt >= 1 Then
            Dim Response_1 As MsgBoxResult

            Response_1 = MsgBox("Doesn't exit Without Saving Update,Are You Want Save....", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Confirm")

            If Response_1 = MsgBoxResult.Yes Then
                Frm_View_S_Event_Charges.MdiParent = Me
                Frm_View_S_Event_Charges.WindowState = FormWindowState.Maximized
                Frm_View_S_Event_Charges.Show()
                Frm_View_S_Event_Detail.Book_clear()
            ElseIf Response_1 = MsgBoxResult.No Then
                Me.Show()
            End If
        Else
            Dim Response As MsgBoxResult

            Response = MsgBox(" Are you sure you want to logout .. ", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Confirm")

            If Response = MsgBoxResult.Yes Then
                Me.Hide()
                Frm_Login.Show()
                Frm_Add_New_Customer.Cust_Clear()
                Frm_View_Single_Customer.Clear()
            ElseIf Response = MsgBoxResult.No Then
                Me.Show()
            End If
        End If
    End Sub

    Private Sub MDI_Main_Form_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Frm_Add_New_Customer.Cust_cnt > 1 Then
            Dim Response As MsgBoxResult

            Response = MsgBox(" Are you sure you want to close without saving customer event details.. ", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Confirm")

            If Response = MsgBoxResult.Yes Then
                If Frm_Booking_Event.cntt > 1 Then
                    Frm_Booking_Event.Book_clear()
                End If
                Frm_Add_New_Customer.Cust_Clear()
            ElseIf Response = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If
        '.............update......................................................................................................................................................................................................
        If Frm_View_Single_Customer.Update_Cnt >= 1 Then
            Dim Response_1 As MsgBoxResult

            Response_1 = MsgBox("Doesn't exit Without Saving Update,Are You Want Save....", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), "Confirm")

            If Response_1 = MsgBoxResult.Yes Then
                e.Cancel = True
                Frm_View_S_Event_Charges.MdiParent = Me
                Frm_View_S_Event_Charges.WindowState = FormWindowState.Maximized
                Frm_View_S_Event_Charges.Show()
                Frm_View_S_Event_Detail.Book_clear()
            ElseIf Response_1 = MsgBoxResult.No Then
                e.Cancel = True

            End If
        End If

    End Sub

    Private Sub AllCustomerReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllCustomerReportToolStripMenuItem.Click
        Frm_Bill_search.Close()
        Frm_All_Customer_Report.MdiParent = Me
        Frm_All_Customer_Report.WindowState = FormWindowState.Maximized
        Frm_All_Customer_Report.Show()
        PB_MDI.Visible = False
    End Sub

    Private Sub CaluculatorToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaluculatorToolStripMenuItem.Click
        Dim MyApp As New System.Diagnostics.ProcessStartInfo("Calc")
        Process.Start(MyApp)
    End Sub

    Private Sub NotepadToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotepadToolStripMenuItem.Click
        Dim MyApp As New System.Diagnostics.ProcessStartInfo("Notepad")
        Process.Start(MyApp)
    End Sub

    Private Sub ALLCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ALLCustomerToolStripMenuItem.Click
        Frm_All_Cust_Report.MdiParent = Me
        Frm_All_Cust_Report.WindowState = FormWindowState.Maximized
        Frm_All_Cust_Report.Show()
        PB_MDI.Visible = False

    End Sub

    Private Sub BillCustToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillCustToolStripMenuItem.Click
        Frm_Package_Report.MdiParent = Me
        Frm_Package_Report.WindowState = FormWindowState.Maximized
        Frm_Package_Report.Show()
        PB_MDI.Visible = False
    End Sub

    Private Sub FrmPackageReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrmPackageReportToolStripMenuItem.Click
        Frm_All_Customer_Report.Close()
        Frm_Bill_search.MdiParent = Me
        Frm_Bill_search.WindowState = FormWindowState.Maximized
        Frm_Bill_search.Show()
        PB_MDI.Visible = False
    End Sub
End Class
