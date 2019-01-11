<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbltime = New System.Windows.Forms.Label()
        Me.BunifuFlatButton5 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker3 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker4 = New System.ComponentModel.BackgroundWorker()
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Logout = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.create_account = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_dashboard = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.create_account_panel = New System.Windows.Forms.Panel()
        Me.cbo_status = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txt_confirm_password = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txt_password = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txt_uname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txt_fname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.cbo_position = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.create_account_panel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Arial Unicode MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(105, 111)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(111, 25)
        Me.BunifuCustomLabel4.TabIndex = 6
        Me.BunifuCustomLabel4.Text = "Username :"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Arial Unicode MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(77, 179)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(80, 28)
        Me.BunifuCustomLabel1.TabIndex = 4
        Me.BunifuCustomLabel1.Text = "ADMIN"
        '
        'Timer1
        '
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.Location = New System.Drawing.Point(681, 4)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(51, 20)
        Me.lbltime.TabIndex = 8
        Me.lbltime.Text = "lbltime"
        '
        'BunifuFlatButton5
        '
        Me.BunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton5.BorderRadius = 0
        Me.BunifuFlatButton5.ButtonText = "Cancel"
        Me.BunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.Iconimage = Nothing
        Me.BunifuFlatButton5.Iconimage_right = Nothing
        Me.BunifuFlatButton5.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton5.Iconimage_Selected = Nothing
        Me.BunifuFlatButton5.IconMarginLeft = 0
        Me.BunifuFlatButton5.IconMarginRight = 0
        Me.BunifuFlatButton5.IconRightVisible = True
        Me.BunifuFlatButton5.IconRightZoom = 0R
        Me.BunifuFlatButton5.IconVisible = True
        Me.BunifuFlatButton5.IconZoom = 90.0R
        Me.BunifuFlatButton5.IsTab = False
        Me.BunifuFlatButton5.Location = New System.Drawing.Point(445, 395)
        Me.BunifuFlatButton5.Name = "BunifuFlatButton5"
        Me.BunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton5.selected = False
        Me.BunifuFlatButton5.Size = New System.Drawing.Size(144, 48)
        Me.BunifuFlatButton5.TabIndex = 12
        Me.BunifuFlatButton5.Text = "Cancel"
        Me.BunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton5.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton5.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.lbldate)
        Me.Panel3.Controls.Add(Me.lbltime)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(227, -1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(765, 24)
        Me.Panel3.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(549, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Date: "
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(593, 4)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(51, 20)
        Me.lbldate.TabIndex = 10
        Me.lbldate.Text = "lbldate"
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(0, 30)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(766, 208)
        Me.Panel4.TabIndex = 7
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 0
        Me.BunifuFlatButton3.ButtonText = "Save"
        Me.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Iconimage = Nothing
        Me.BunifuFlatButton3.Iconimage_right = Nothing
        Me.BunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton3.Iconimage_Selected = Nothing
        Me.BunifuFlatButton3.IconMarginLeft = 0
        Me.BunifuFlatButton3.IconMarginRight = 0
        Me.BunifuFlatButton3.IconRightVisible = True
        Me.BunifuFlatButton3.IconRightZoom = 0R
        Me.BunifuFlatButton3.IconVisible = True
        Me.BunifuFlatButton3.IconZoom = 90.0R
        Me.BunifuFlatButton3.IsTab = False
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(278, 395)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(144, 48)
        Me.BunifuFlatButton3.TabIndex = 11
        Me.BunifuFlatButton3.Text = "Save"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Arial Unicode MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(126, 277)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(90, 25)
        Me.BunifuCustomLabel6.TabIndex = 9
        Me.BunifuCustomLabel6.Text = "Position :"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Arial Unicode MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(111, 57)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(105, 25)
        Me.BunifuCustomLabel2.TabIndex = 3
        Me.BunifuCustomLabel2.Text = "Fullname : "
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel1.Controls.Add(Me.BunifuFlatButton2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Logout)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Controls.Add(Me.create_account)
        Me.Panel1.Controls.Add(Me.btn_dashboard)
        Me.Panel1.Location = New System.Drawing.Point(-2, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(229, 509)
        Me.Panel1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(209, 162)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Logout
        '
        Me.Logout.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Logout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Logout.BackColor = System.Drawing.Color.Transparent
        Me.Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Logout.BorderRadius = 0
        Me.Logout.ButtonText = "Logout"
        Me.Logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Logout.DisabledColor = System.Drawing.Color.Gray
        Me.Logout.Iconcolor = System.Drawing.Color.Transparent
        Me.Logout.Iconimage = CType(resources.GetObject("Logout.Iconimage"), System.Drawing.Image)
        Me.Logout.Iconimage_right = Nothing
        Me.Logout.Iconimage_right_Selected = Nothing
        Me.Logout.Iconimage_Selected = Nothing
        Me.Logout.IconMarginLeft = 0
        Me.Logout.IconMarginRight = 0
        Me.Logout.IconRightVisible = True
        Me.Logout.IconRightZoom = 0R
        Me.Logout.IconVisible = True
        Me.Logout.IconZoom = 90.0R
        Me.Logout.IsTab = False
        Me.Logout.Location = New System.Drawing.Point(68, 461)
        Me.Logout.Name = "Logout"
        Me.Logout.Normalcolor = System.Drawing.Color.Transparent
        Me.Logout.OnHovercolor = System.Drawing.Color.Transparent
        Me.Logout.OnHoverTextColor = System.Drawing.Color.White
        Me.Logout.selected = False
        Me.Logout.Size = New System.Drawing.Size(92, 34)
        Me.Logout.TabIndex = 5
        Me.Logout.Text = "Logout"
        Me.Logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Logout.Textcolor = System.Drawing.Color.Black
        Me.Logout.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'create_account
        '
        Me.create_account.Activecolor = System.Drawing.Color.MediumSeaGreen
        Me.create_account.BackColor = System.Drawing.Color.Transparent
        Me.create_account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.create_account.BorderRadius = 0
        Me.create_account.ButtonText = "Create Account"
        Me.create_account.Cursor = System.Windows.Forms.Cursors.Hand
        Me.create_account.DisabledColor = System.Drawing.Color.Gray
        Me.create_account.Iconcolor = System.Drawing.Color.Transparent
        Me.create_account.Iconimage = CType(resources.GetObject("create_account.Iconimage"), System.Drawing.Image)
        Me.create_account.Iconimage_right = Nothing
        Me.create_account.Iconimage_right_Selected = Nothing
        Me.create_account.Iconimage_Selected = Nothing
        Me.create_account.IconMarginLeft = 35
        Me.create_account.IconMarginRight = 0
        Me.create_account.IconRightVisible = True
        Me.create_account.IconRightZoom = 0R
        Me.create_account.IconVisible = True
        Me.create_account.IconZoom = 90.0R
        Me.create_account.IsTab = False
        Me.create_account.Location = New System.Drawing.Point(0, 301)
        Me.create_account.Name = "create_account"
        Me.create_account.Normalcolor = System.Drawing.Color.Transparent
        Me.create_account.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.create_account.OnHoverTextColor = System.Drawing.Color.White
        Me.create_account.selected = False
        Me.create_account.Size = New System.Drawing.Size(229, 58)
        Me.create_account.TabIndex = 3
        Me.create_account.Text = "Create Account"
        Me.create_account.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.create_account.Textcolor = System.Drawing.Color.Black
        Me.create_account.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_dashboard
        '
        Me.btn_dashboard.Activecolor = System.Drawing.Color.MediumSeaGreen
        Me.btn_dashboard.BackColor = System.Drawing.Color.Transparent
        Me.btn_dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_dashboard.BorderRadius = 0
        Me.btn_dashboard.ButtonText = "Dashboard"
        Me.btn_dashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_dashboard.DisabledColor = System.Drawing.Color.Gray
        Me.btn_dashboard.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_dashboard.Iconimage = CType(resources.GetObject("btn_dashboard.Iconimage"), System.Drawing.Image)
        Me.btn_dashboard.Iconimage_right = Nothing
        Me.btn_dashboard.Iconimage_right_Selected = Nothing
        Me.btn_dashboard.Iconimage_Selected = Nothing
        Me.btn_dashboard.IconMarginLeft = 30
        Me.btn_dashboard.IconMarginRight = 0
        Me.btn_dashboard.IconRightVisible = True
        Me.btn_dashboard.IconRightZoom = 0R
        Me.btn_dashboard.IconVisible = True
        Me.btn_dashboard.IconZoom = 90.0R
        Me.btn_dashboard.IsTab = False
        Me.btn_dashboard.Location = New System.Drawing.Point(3, 245)
        Me.btn_dashboard.Name = "btn_dashboard"
        Me.btn_dashboard.Normalcolor = System.Drawing.Color.Transparent
        Me.btn_dashboard.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_dashboard.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_dashboard.selected = False
        Me.btn_dashboard.Size = New System.Drawing.Size(226, 62)
        Me.btn_dashboard.TabIndex = 1
        Me.btn_dashboard.Text = "Dashboard"
        Me.btn_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_dashboard.Textcolor = System.Drawing.Color.Black
        Me.btn_dashboard.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'create_account_panel
        '
        Me.create_account_panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.create_account_panel.BackColor = System.Drawing.Color.LavenderBlush
        Me.create_account_panel.Controls.Add(Me.cbo_status)
        Me.create_account_panel.Controls.Add(Me.BunifuCustomLabel7)
        Me.create_account_panel.Controls.Add(Me.txt_confirm_password)
        Me.create_account_panel.Controls.Add(Me.BunifuCustomLabel5)
        Me.create_account_panel.Controls.Add(Me.txt_password)
        Me.create_account_panel.Controls.Add(Me.BunifuCustomLabel3)
        Me.create_account_panel.Controls.Add(Me.txt_uname)
        Me.create_account_panel.Controls.Add(Me.txt_fname)
        Me.create_account_panel.Controls.Add(Me.cbo_position)
        Me.create_account_panel.Controls.Add(Me.BunifuFlatButton5)
        Me.create_account_panel.Controls.Add(Me.BunifuFlatButton3)
        Me.create_account_panel.Controls.Add(Me.BunifuCustomLabel6)
        Me.create_account_panel.Controls.Add(Me.BunifuCustomLabel4)
        Me.create_account_panel.Controls.Add(Me.BunifuCustomLabel2)
        Me.create_account_panel.Location = New System.Drawing.Point(227, 22)
        Me.create_account_panel.Name = "create_account_panel"
        Me.create_account_panel.Size = New System.Drawing.Size(766, 484)
        Me.create_account_panel.TabIndex = 5
        '
        'cbo_status
        '
        Me.cbo_status.BackColor = System.Drawing.Color.Transparent
        Me.cbo_status.BorderRadius = 3
        Me.cbo_status.DisabledColor = System.Drawing.Color.Gray
        Me.cbo_status.ForeColor = System.Drawing.Color.White
        Me.cbo_status.Items = New String() {"Active", "Inactive"}
        Me.cbo_status.Location = New System.Drawing.Point(238, 326)
        Me.cbo_status.Name = "cbo_status"
        Me.cbo_status.NomalColor = System.Drawing.Color.Gray
        Me.cbo_status.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.cbo_status.selectedIndex = -1
        Me.cbo_status.Size = New System.Drawing.Size(379, 35)
        Me.cbo_status.TabIndex = 21
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Arial Unicode MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(140, 336)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(76, 25)
        Me.BunifuCustomLabel7.TabIndex = 20
        Me.BunifuCustomLabel7.Text = "Status :"
        '
        'txt_confirm_password
        '
        Me.txt_confirm_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_confirm_password.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_confirm_password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_confirm_password.HintForeColor = System.Drawing.Color.Empty
        Me.txt_confirm_password.HintText = ""
        Me.txt_confirm_password.isPassword = True
        Me.txt_confirm_password.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_confirm_password.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_confirm_password.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_confirm_password.LineThickness = 3
        Me.txt_confirm_password.Location = New System.Drawing.Point(238, 209)
        Me.txt_confirm_password.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_confirm_password.Name = "txt_confirm_password"
        Me.txt_confirm_password.Size = New System.Drawing.Size(379, 33)
        Me.txt_confirm_password.TabIndex = 19
        Me.txt_confirm_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Arial Unicode MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(37, 217)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(179, 25)
        Me.BunifuCustomLabel5.TabIndex = 18
        Me.BunifuCustomLabel5.Text = "Confirm Password :"
        '
        'txt_password
        '
        Me.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_password.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_password.HintForeColor = System.Drawing.Color.Empty
        Me.txt_password.HintText = ""
        Me.txt_password.isPassword = True
        Me.txt_password.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_password.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_password.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_password.LineThickness = 3
        Me.txt_password.Location = New System.Drawing.Point(238, 157)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(379, 33)
        Me.txt_password.TabIndex = 17
        Me.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Arial Unicode MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(108, 165)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(108, 25)
        Me.BunifuCustomLabel3.TabIndex = 16
        Me.BunifuCustomLabel3.Text = "Password :"
        '
        'txt_uname
        '
        Me.txt_uname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_uname.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_uname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_uname.HintForeColor = System.Drawing.Color.Empty
        Me.txt_uname.HintText = ""
        Me.txt_uname.isPassword = False
        Me.txt_uname.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_uname.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_uname.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_uname.LineThickness = 3
        Me.txt_uname.Location = New System.Drawing.Point(238, 103)
        Me.txt_uname.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_uname.Name = "txt_uname"
        Me.txt_uname.Size = New System.Drawing.Size(379, 33)
        Me.txt_uname.TabIndex = 15
        Me.txt_uname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_fname
        '
        Me.txt_fname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_fname.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_fname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_fname.HintForeColor = System.Drawing.Color.Empty
        Me.txt_fname.HintText = ""
        Me.txt_fname.isPassword = False
        Me.txt_fname.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_fname.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_fname.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_fname.LineThickness = 3
        Me.txt_fname.Location = New System.Drawing.Point(238, 49)
        Me.txt_fname.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(379, 33)
        Me.txt_fname.TabIndex = 14
        Me.txt_fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'cbo_position
        '
        Me.cbo_position.BackColor = System.Drawing.Color.Transparent
        Me.cbo_position.BorderRadius = 3
        Me.cbo_position.DisabledColor = System.Drawing.Color.Gray
        Me.cbo_position.ForeColor = System.Drawing.Color.White
        Me.cbo_position.Items = New String() {"Admin", "User"}
        Me.cbo_position.Location = New System.Drawing.Point(238, 267)
        Me.cbo_position.Name = "cbo_position"
        Me.cbo_position.NomalColor = System.Drawing.Color.Gray
        Me.cbo_position.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.cbo_position.selectedIndex = -1
        Me.cbo_position.Size = New System.Drawing.Size(379, 35)
        Me.cbo_position.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(288, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(222, 33)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "D A S H B O A R D"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(226, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(767, 485)
        Me.Panel2.TabIndex = 10
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.MediumSeaGreen
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "Settings"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = CType(resources.GetObject("BunifuFlatButton2.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 30
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 90.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(3, 365)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(226, 58)
        Me.BunifuFlatButton2.TabIndex = 8
        Me.BunifuFlatButton2.Text = "Settings"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.Black
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(991, 505)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.create_account_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.create_account_panel.ResumeLayout(False)
        Me.create_account_panel.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbltime As Label
    Friend WithEvents BunifuFlatButton5 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker4 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents btn_dashboard As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Logout As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents create_account As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents create_account_panel As Panel
    Friend WithEvents txt_uname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txt_fname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents cbo_position As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents txt_confirm_password As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txt_password As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cbo_status As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
End Class
