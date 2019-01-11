<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.brnCancel = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnLogin = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUname = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtPass = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.SuspendLayout()
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DarkGreen
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DarkGreen
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DarkGreen
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DarkGreen
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(368, 434)
        Me.BunifuGradientPanel1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(394, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Password: "
        '
        'brnCancel
        '
        Me.brnCancel.ActiveBorderThickness = 1
        Me.brnCancel.ActiveCornerRadius = 20
        Me.brnCancel.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.brnCancel.ActiveForecolor = System.Drawing.Color.MediumSeaGreen
        Me.brnCancel.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.brnCancel.BackColor = System.Drawing.Color.DarkSlateGray
        Me.brnCancel.BackgroundImage = CType(resources.GetObject("brnCancel.BackgroundImage"), System.Drawing.Image)
        Me.brnCancel.ButtonText = "Cancel"
        Me.brnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.brnCancel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brnCancel.ForeColor = System.Drawing.Color.SeaGreen
        Me.brnCancel.IdleBorderThickness = 1
        Me.brnCancel.IdleCornerRadius = 20
        Me.brnCancel.IdleFillColor = System.Drawing.Color.SeaGreen
        Me.brnCancel.IdleForecolor = System.Drawing.Color.White
        Me.brnCancel.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.brnCancel.Location = New System.Drawing.Point(394, 306)
        Me.brnCancel.Margin = New System.Windows.Forms.Padding(5)
        Me.brnCancel.Name = "brnCancel"
        Me.brnCancel.Size = New System.Drawing.Size(298, 50)
        Me.brnCancel.TabIndex = 3
        Me.brnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLogin
        '
        Me.btnLogin.ActiveBorderThickness = 1
        Me.btnLogin.ActiveCornerRadius = 20
        Me.btnLogin.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnLogin.ActiveForecolor = System.Drawing.Color.MediumSeaGreen
        Me.btnLogin.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnLogin.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnLogin.BackgroundImage = CType(resources.GetObject("btnLogin.BackgroundImage"), System.Drawing.Image)
        Me.btnLogin.ButtonText = "Login"
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.IdleBorderThickness = 1
        Me.btnLogin.IdleCornerRadius = 20
        Me.btnLogin.IdleFillColor = System.Drawing.Color.SeaGreen
        Me.btnLogin.IdleForecolor = System.Drawing.Color.White
        Me.btnLogin.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnLogin.Location = New System.Drawing.Point(396, 246)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(5)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(297, 50)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(393, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Username: "
        '
        'txtUname
        '
        Me.txtUname.BackColor = System.Drawing.Color.Snow
        Me.txtUname.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtUname.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUname.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtUname.BorderThickness = 1
        Me.txtUname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUname.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtUname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUname.isPassword = False
        Me.txtUname.Location = New System.Drawing.Point(395, 102)
        Me.txtUname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUname.Name = "txtUname"
        Me.txtUname.Size = New System.Drawing.Size(298, 44)
        Me.txtUname.TabIndex = 5
        Me.txtUname.Text = "admin"
        Me.txtUname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.Snow
        Me.txtPass.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtPass.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPass.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtPass.BorderThickness = 1
        Me.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPass.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPass.isPassword = True
        Me.txtPass.Location = New System.Drawing.Point(396, 175)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(298, 44)
        Me.txtPass.TabIndex = 6
        Me.txtPass.Text = "admin"
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(714, 434)
        Me.Controls.Add(Me.txtUname)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.brnCancel)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents brnCancel As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogin As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUname As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtPass As Bunifu.Framework.UI.BunifuMetroTextbox
End Class
