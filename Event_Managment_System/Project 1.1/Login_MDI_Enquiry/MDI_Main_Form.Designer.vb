<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDI_Main_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDI_Main_Form))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Lbl_Date_Time = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.EnquiryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAllEnquriesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewSingleEnquiryToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAllEnquriesToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewSingleCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAllCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewEventToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewEventToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateEventToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PackagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PackagesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecorationServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PackagesToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecorationServicesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateDecorationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllCustomerReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ALLCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BillCustToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FrmPackageReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAllUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAllUsersToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaluculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotepadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PB_MDI = New System.Windows.Forms.PictureBox()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_MDI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 840)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1584, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'Lbl_Date_Time
        '
        Me.Lbl_Date_Time.AutoSize = True
        Me.Lbl_Date_Time.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lbl_Date_Time.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, System.Drawing.FontStyle.Italic)
        Me.Lbl_Date_Time.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Lbl_Date_Time.Location = New System.Drawing.Point(1229, 3)
        Me.Lbl_Date_Time.Name = "Lbl_Date_Time"
        Me.Lbl_Date_Time.Size = New System.Drawing.Size(135, 39)
        Me.Lbl_Date_Time.TabIndex = 24
        Me.Lbl_Date_Time.Text = "Date Time"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(1553, 811)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "p1"
        Me.Label1.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 2000
        '
        'MenuStrip
        '
        Me.MenuStrip.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnquiryToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.EventsToolStripMenuItem, Me.PackagesToolStripMenuItem, Me.UserManagementToolStripMenuItem, Me.ReporToolStripMenuItem, Me.OtherToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1584, 47)
        Me.MenuStrip.TabIndex = 6
        Me.MenuStrip.Text = "MenuStrip"
        '
        'EnquiryToolStripMenuItem
        '
        Me.EnquiryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewAllEnquriesToolStripMenuItem1, Me.ViewSingleEnquiryToolStripMenuItem1, Me.ViewAllEnquriesToolStripMenuItem2})
        Me.EnquiryToolStripMenuItem.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnquiryToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.EnquiryToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.images__9_
        Me.EnquiryToolStripMenuItem.Name = "EnquiryToolStripMenuItem"
        Me.EnquiryToolStripMenuItem.Size = New System.Drawing.Size(139, 43)
        Me.EnquiryToolStripMenuItem.Text = "Enquiry"
        '
        'ViewAllEnquriesToolStripMenuItem1
        '
        Me.ViewAllEnquriesToolStripMenuItem1.ForeColor = System.Drawing.Color.Blue
        Me.ViewAllEnquriesToolStripMenuItem1.Image = Global.WindowsApplication1.My.Resources.Resources.download__6_3
        Me.ViewAllEnquriesToolStripMenuItem1.Name = "ViewAllEnquriesToolStripMenuItem1"
        Me.ViewAllEnquriesToolStripMenuItem1.Size = New System.Drawing.Size(430, 44)
        Me.ViewAllEnquriesToolStripMenuItem1.Text = "Add New Enquiry"
        '
        'ViewSingleEnquiryToolStripMenuItem1
        '
        Me.ViewSingleEnquiryToolStripMenuItem1.ForeColor = System.Drawing.Color.Blue
        Me.ViewSingleEnquiryToolStripMenuItem1.Image = Global.WindowsApplication1.My.Resources.Resources.images__2_7
        Me.ViewSingleEnquiryToolStripMenuItem1.Name = "ViewSingleEnquiryToolStripMenuItem1"
        Me.ViewSingleEnquiryToolStripMenuItem1.Size = New System.Drawing.Size(430, 44)
        Me.ViewSingleEnquiryToolStripMenuItem1.Text = "View/Update Single Enquiry"
        '
        'ViewAllEnquriesToolStripMenuItem2
        '
        Me.ViewAllEnquriesToolStripMenuItem2.ForeColor = System.Drawing.Color.Blue
        Me.ViewAllEnquriesToolStripMenuItem2.Image = Global.WindowsApplication1.My.Resources.Resources.download__5_2
        Me.ViewAllEnquriesToolStripMenuItem2.Name = "ViewAllEnquriesToolStripMenuItem2"
        Me.ViewAllEnquriesToolStripMenuItem2.Size = New System.Drawing.Size(430, 44)
        Me.ViewAllEnquriesToolStripMenuItem2.Text = "View All Enquries"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewCustomerToolStripMenuItem, Me.ViewSingleCustomerToolStripMenuItem, Me.ViewAllCustomerToolStripMenuItem})
        Me.CustomerToolStripMenuItem.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.CustomerToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.images__8_1
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(151, 43)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'AddNewCustomerToolStripMenuItem
        '
        Me.AddNewCustomerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AddNewCustomerToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.download__3_
        Me.AddNewCustomerToolStripMenuItem.Name = "AddNewCustomerToolStripMenuItem"
        Me.AddNewCustomerToolStripMenuItem.Size = New System.Drawing.Size(442, 44)
        Me.AddNewCustomerToolStripMenuItem.Text = "Add New Customer"
        '
        'ViewSingleCustomerToolStripMenuItem
        '
        Me.ViewSingleCustomerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ViewSingleCustomerToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.images__11_
        Me.ViewSingleCustomerToolStripMenuItem.Name = "ViewSingleCustomerToolStripMenuItem"
        Me.ViewSingleCustomerToolStripMenuItem.Size = New System.Drawing.Size(442, 44)
        Me.ViewSingleCustomerToolStripMenuItem.Text = "View/Update Single Customer"
        '
        'ViewAllCustomerToolStripMenuItem
        '
        Me.ViewAllCustomerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ViewAllCustomerToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.download__5_
        Me.ViewAllCustomerToolStripMenuItem.Name = "ViewAllCustomerToolStripMenuItem"
        Me.ViewAllCustomerToolStripMenuItem.Size = New System.Drawing.Size(442, 44)
        Me.ViewAllCustomerToolStripMenuItem.Text = "View All Customer"
        '
        'EventsToolStripMenuItem
        '
        Me.EventsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewEventToolStripMenuItem, Me.ViewEventToolStripMenuItem, Me.UpdateEventToolStripMenuItem})
        Me.EventsToolStripMenuItem.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EventsToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.EventsToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.download2
        Me.EventsToolStripMenuItem.Name = "EventsToolStripMenuItem"
        Me.EventsToolStripMenuItem.Size = New System.Drawing.Size(125, 43)
        Me.EventsToolStripMenuItem.Text = "Events"
        '
        'AddNewEventToolStripMenuItem
        '
        Me.AddNewEventToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AddNewEventToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.images__12_
        Me.AddNewEventToolStripMenuItem.Name = "AddNewEventToolStripMenuItem"
        Me.AddNewEventToolStripMenuItem.Size = New System.Drawing.Size(281, 44)
        Me.AddNewEventToolStripMenuItem.Text = "Add New Event"
        '
        'ViewEventToolStripMenuItem
        '
        Me.ViewEventToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ViewEventToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.images__2_1
        Me.ViewEventToolStripMenuItem.Name = "ViewEventToolStripMenuItem"
        Me.ViewEventToolStripMenuItem.Size = New System.Drawing.Size(281, 44)
        Me.ViewEventToolStripMenuItem.Text = "View Event"
        '
        'UpdateEventToolStripMenuItem
        '
        Me.UpdateEventToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UpdateEventToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.download__7_
        Me.UpdateEventToolStripMenuItem.Name = "UpdateEventToolStripMenuItem"
        Me.UpdateEventToolStripMenuItem.Size = New System.Drawing.Size(281, 44)
        Me.UpdateEventToolStripMenuItem.Text = "Update Event"
        '
        'PackagesToolStripMenuItem
        '
        Me.PackagesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PackagesToolStripMenuItem1, Me.PackagesToolStripMenuItem2, Me.UpdateServicesToolStripMenuItem})
        Me.PackagesToolStripMenuItem.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PackagesToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.PackagesToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.download__2_2
        Me.PackagesToolStripMenuItem.Name = "PackagesToolStripMenuItem"
        Me.PackagesToolStripMenuItem.Size = New System.Drawing.Size(135, 43)
        Me.PackagesToolStripMenuItem.Text = "Services"
        '
        'PackagesToolStripMenuItem1
        '
        Me.PackagesToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.DecorationServicesToolStripMenuItem})
        Me.PackagesToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PackagesToolStripMenuItem1.Image = Global.WindowsApplication1.My.Resources.Resources.download__9_
        Me.PackagesToolStripMenuItem1.Name = "PackagesToolStripMenuItem1"
        Me.PackagesToolStripMenuItem1.Size = New System.Drawing.Size(277, 44)
        Me.PackagesToolStripMenuItem1.Text = "Add Service"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.images__13_
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(372, 44)
        Me.MenuToolStripMenuItem.Text = "Add Menu Services"
        '
        'DecorationServicesToolStripMenuItem
        '
        Me.DecorationServicesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DecorationServicesToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.download__6_
        Me.DecorationServicesToolStripMenuItem.Name = "DecorationServicesToolStripMenuItem"
        Me.DecorationServicesToolStripMenuItem.Size = New System.Drawing.Size(372, 44)
        Me.DecorationServicesToolStripMenuItem.Text = "Add Decoration Services"
        '
        'PackagesToolStripMenuItem2
        '
        Me.PackagesToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuServicesToolStripMenuItem, Me.DecorationServicesToolStripMenuItem1})
        Me.PackagesToolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PackagesToolStripMenuItem2.Image = Global.WindowsApplication1.My.Resources.Resources.images__2_2
        Me.PackagesToolStripMenuItem2.Name = "PackagesToolStripMenuItem2"
        Me.PackagesToolStripMenuItem2.Size = New System.Drawing.Size(277, 44)
        Me.PackagesToolStripMenuItem2.Text = "View Services"
        '
        'MenuServicesToolStripMenuItem
        '
        Me.MenuServicesToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.download__5_1
        Me.MenuServicesToolStripMenuItem.Name = "MenuServicesToolStripMenuItem"
        Me.MenuServicesToolStripMenuItem.Size = New System.Drawing.Size(385, 44)
        Me.MenuServicesToolStripMenuItem.Text = "View Menu Services"
        '
        'DecorationServicesToolStripMenuItem1
        '
        Me.DecorationServicesToolStripMenuItem1.Image = Global.WindowsApplication1.My.Resources.Resources.images__14_
        Me.DecorationServicesToolStripMenuItem1.Name = "DecorationServicesToolStripMenuItem1"
        Me.DecorationServicesToolStripMenuItem1.Size = New System.Drawing.Size(385, 44)
        Me.DecorationServicesToolStripMenuItem1.Text = "View Decoration Services"
        '
        'UpdateServicesToolStripMenuItem
        '
        Me.UpdateServicesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateMenuToolStripMenuItem, Me.UpdateDecorationToolStripMenuItem})
        Me.UpdateServicesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UpdateServicesToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.update_icon1
        Me.UpdateServicesToolStripMenuItem.Name = "UpdateServicesToolStripMenuItem"
        Me.UpdateServicesToolStripMenuItem.Size = New System.Drawing.Size(277, 44)
        Me.UpdateServicesToolStripMenuItem.Text = "Update Services"
        '
        'UpdateMenuToolStripMenuItem
        '
        Me.UpdateMenuToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.Other_Update_Metro_icon2
        Me.UpdateMenuToolStripMenuItem.Name = "UpdateMenuToolStripMenuItem"
        Me.UpdateMenuToolStripMenuItem.Size = New System.Drawing.Size(313, 44)
        Me.UpdateMenuToolStripMenuItem.Text = "Update Menu"
        '
        'UpdateDecorationToolStripMenuItem
        '
        Me.UpdateDecorationToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.services_portfolio_icon1
        Me.UpdateDecorationToolStripMenuItem.Name = "UpdateDecorationToolStripMenuItem"
        Me.UpdateDecorationToolStripMenuItem.Size = New System.Drawing.Size(313, 44)
        Me.UpdateDecorationToolStripMenuItem.Text = "Update Decoration"
        '
        'UserManagementToolStripMenuItem
        '
        Me.UserManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllCustomerReportToolStripMenuItem, Me.ALLCustomerToolStripMenuItem, Me.BillCustToolStripMenuItem, Me.FrmPackageReportToolStripMenuItem})
        Me.UserManagementToolStripMenuItem.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserManagementToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.UserManagementToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.images__6_
        Me.UserManagementToolStripMenuItem.Name = "UserManagementToolStripMenuItem"
        Me.UserManagementToolStripMenuItem.Size = New System.Drawing.Size(122, 43)
        Me.UserManagementToolStripMenuItem.Text = "Report"
        '
        'AllCustomerReportToolStripMenuItem
        '
        Me.AllCustomerReportToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.images__6_1
        Me.AllCustomerReportToolStripMenuItem.Name = "AllCustomerReportToolStripMenuItem"
        Me.AllCustomerReportToolStripMenuItem.Size = New System.Drawing.Size(284, 44)
        Me.AllCustomerReportToolStripMenuItem.Text = "Charges Report"
        '
        'ALLCustomerToolStripMenuItem
        '
        Me.ALLCustomerToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.Add_User_icon1
        Me.ALLCustomerToolStripMenuItem.Name = "ALLCustomerToolStripMenuItem"
        Me.ALLCustomerToolStripMenuItem.Size = New System.Drawing.Size(284, 44)
        Me.ALLCustomerToolStripMenuItem.Text = "Customer Report"
        '
        'BillCustToolStripMenuItem
        '
        Me.BillCustToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.Apps_accessories_calculator_icon__1_
        Me.BillCustToolStripMenuItem.Name = "BillCustToolStripMenuItem"
        Me.BillCustToolStripMenuItem.Size = New System.Drawing.Size(284, 44)
        Me.BillCustToolStripMenuItem.Text = "Package Report"
        '
        'FrmPackageReportToolStripMenuItem
        '
        Me.FrmPackageReportToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.Actions_view_split_left_right_icon
        Me.FrmPackageReportToolStripMenuItem.Name = "FrmPackageReportToolStripMenuItem"
        Me.FrmPackageReportToolStripMenuItem.Size = New System.Drawing.Size(284, 44)
        Me.FrmPackageReportToolStripMenuItem.Text = "Bill Report"
        '
        'ReporToolStripMenuItem
        '
        Me.ReporToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewUserToolStripMenuItem, Me.UpdateUserToolStripMenuItem, Me.ViewAllUsersToolStripMenuItem, Me.ViewAllUsersToolStripMenuItem1})
        Me.ReporToolStripMenuItem.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReporToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.Pay_Per_Click_icon1
        Me.ReporToolStripMenuItem.Name = "ReporToolStripMenuItem"
        Me.ReporToolStripMenuItem.Size = New System.Drawing.Size(376, 43)
        Me.ReporToolStripMenuItem.Text = "Employee/User Management"
        '
        'AddNewUserToolStripMenuItem
        '
        Me.AddNewUserToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.AddNewUserToolStripMenuItem.Name = "AddNewUserToolStripMenuItem"
        Me.AddNewUserToolStripMenuItem.Size = New System.Drawing.Size(387, 44)
        Me.AddNewUserToolStripMenuItem.Text = "Add New Employee/User"
        '
        'UpdateUserToolStripMenuItem
        '
        Me.UpdateUserToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.UpdateUserToolStripMenuItem.Name = "UpdateUserToolStripMenuItem"
        Me.UpdateUserToolStripMenuItem.Size = New System.Drawing.Size(387, 44)
        Me.UpdateUserToolStripMenuItem.Text = "Update Employee/User"
        '
        'ViewAllUsersToolStripMenuItem
        '
        Me.ViewAllUsersToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.ViewAllUsersToolStripMenuItem.Name = "ViewAllUsersToolStripMenuItem"
        Me.ViewAllUsersToolStripMenuItem.Size = New System.Drawing.Size(387, 44)
        Me.ViewAllUsersToolStripMenuItem.Text = "View All Employee"
        '
        'ViewAllUsersToolStripMenuItem1
        '
        Me.ViewAllUsersToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control
        Me.ViewAllUsersToolStripMenuItem1.ForeColor = System.Drawing.Color.Blue
        Me.ViewAllUsersToolStripMenuItem1.Name = "ViewAllUsersToolStripMenuItem1"
        Me.ViewAllUsersToolStripMenuItem1.Size = New System.Drawing.Size(387, 44)
        Me.ViewAllUsersToolStripMenuItem1.Text = "View All Users"
        '
        'OtherToolStripMenuItem
        '
        Me.OtherToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CaluculatorToolStripMenuItem, Me.NotepadToolStripMenuItem})
        Me.OtherToolStripMenuItem.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OtherToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.OtherToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.download__4_1
        Me.OtherToolStripMenuItem.Name = "OtherToolStripMenuItem"
        Me.OtherToolStripMenuItem.Size = New System.Drawing.Size(109, 43)
        Me.OtherToolStripMenuItem.Text = "Other"
        '
        'CaluculatorToolStripMenuItem
        '
        Me.CaluculatorToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CaluculatorToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.Apps_accessories_calculator_icon3
        Me.CaluculatorToolStripMenuItem.Name = "CaluculatorToolStripMenuItem"
        Me.CaluculatorToolStripMenuItem.Size = New System.Drawing.Size(212, 44)
        Me.CaluculatorToolStripMenuItem.Text = "Calculator"
        '
        'NotepadToolStripMenuItem
        '
        Me.NotepadToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NotepadToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.notepad_icon
        Me.NotepadToolStripMenuItem.Name = "NotepadToolStripMenuItem"
        Me.NotepadToolStripMenuItem.Size = New System.Drawing.Size(212, 44)
        Me.NotepadToolStripMenuItem.Text = "Notepad"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.Apps_session_logout_icon
        Me.PictureBox1.Location = New System.Drawing.Point(1499, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'PB_MDI
        '
        Me.PB_MDI.Image = Global.WindowsApplication1.My.Resources.Resources.Event_Management
        Me.PB_MDI.Location = New System.Drawing.Point(0, 46)
        Me.PB_MDI.Name = "PB_MDI"
        Me.PB_MDI.Size = New System.Drawing.Size(1592, 796)
        Me.PB_MDI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_MDI.TabIndex = 25
        Me.PB_MDI.TabStop = False
        '
        'MDI_Main_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1584, 862)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PB_MDI)
        Me.Controls.Add(Me.Lbl_Date_Time)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "MDI_Main_Form"
        Me.Text = "Main Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_MDI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents Lbl_Date_Time As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents EnquiryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewSingleCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewAllCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EventsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewEventToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewEventToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateEventToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PackagesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PackagesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DecorationServicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PackagesToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuServicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DecorationServicesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateServicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateDecorationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PB_MDI As System.Windows.Forms.PictureBox
    Friend WithEvents ViewAllEnquriesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewSingleEnquiryToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewAllEnquriesToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewAllUsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CaluculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotepadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewAllUsersToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllCustomerReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ALLCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BillCustToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FrmPackageReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
