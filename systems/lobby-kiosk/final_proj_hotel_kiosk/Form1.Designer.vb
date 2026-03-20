<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.sidebar = New System.Windows.Forms.Panel()
        Me.voucher_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.footandbev_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.room_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.LOGO = New System.Windows.Forms.Label()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ads = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.logopic = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.sidebar.SuspendLayout()
        CType(Me.ads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logopic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sidebar
        '
        Me.sidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.sidebar.Controls.Add(Me.voucher_btn)
        Me.sidebar.Controls.Add(Me.footandbev_btn)
        Me.sidebar.Controls.Add(Me.room_btn)
        Me.sidebar.Controls.Add(Me.LOGO)
        Me.sidebar.Controls.Add(Me.logopic)
        Me.sidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidebar.Location = New System.Drawing.Point(0, 0)
        Me.sidebar.Name = "sidebar"
        Me.sidebar.Size = New System.Drawing.Size(203, 961)
        Me.sidebar.TabIndex = 0
        '
        'voucher_btn
        '
        Me.voucher_btn.BorderRadius = 15
        Me.voucher_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.voucher_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.voucher_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.voucher_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.voucher_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.voucher_btn.Font = New System.Drawing.Font("Aksioma DEMO", 15.75!, System.Drawing.FontStyle.Bold)
        Me.voucher_btn.ForeColor = System.Drawing.Color.White
        Me.voucher_btn.Location = New System.Drawing.Point(6, 350)
        Me.voucher_btn.Name = "voucher_btn"
        Me.voucher_btn.Size = New System.Drawing.Size(188, 72)
        Me.voucher_btn.TabIndex = 2
        Me.voucher_btn.Text = "Redeem Voucher"
        '
        'footandbev_btn
        '
        Me.footandbev_btn.BorderRadius = 15
        Me.footandbev_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.footandbev_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.footandbev_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.footandbev_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.footandbev_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.footandbev_btn.Font = New System.Drawing.Font("Aksioma DEMO", 15.75!, System.Drawing.FontStyle.Bold)
        Me.footandbev_btn.ForeColor = System.Drawing.Color.White
        Me.footandbev_btn.Location = New System.Drawing.Point(6, 260)
        Me.footandbev_btn.Name = "footandbev_btn"
        Me.footandbev_btn.Size = New System.Drawing.Size(188, 72)
        Me.footandbev_btn.TabIndex = 2
        Me.footandbev_btn.Text = "Food && Beverages"
        '
        'room_btn
        '
        Me.room_btn.BorderRadius = 15
        Me.room_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.room_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.room_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.room_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.room_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.room_btn.Font = New System.Drawing.Font("Aksioma DEMO", 15.75!, System.Drawing.FontStyle.Bold)
        Me.room_btn.ForeColor = System.Drawing.Color.White
        Me.room_btn.Location = New System.Drawing.Point(6, 165)
        Me.room_btn.Name = "room_btn"
        Me.room_btn.Size = New System.Drawing.Size(188, 72)
        Me.room_btn.TabIndex = 2
        Me.room_btn.Text = "Rooms && Accommodation"
        '
        'LOGO
        '
        Me.LOGO.AutoSize = True
        Me.LOGO.Font = New System.Drawing.Font("HEROEAU ELEGANT DEMO", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOGO.ForeColor = System.Drawing.Color.White
        Me.LOGO.Location = New System.Drawing.Point(27, 93)
        Me.LOGO.Name = "LOGO"
        Me.LOGO.Size = New System.Drawing.Size(157, 38)
        Me.LOGO.TabIndex = 1
        Me.LOGO.Text = "LUXENTRIX"
        '
        'timer1
        '
        Me.timer1.Interval = 2000
        '
        'ads
        '
        Me.ads.BackColor = System.Drawing.Color.Transparent
        Me.ads.ErrorImage = Nothing
        Me.ads.Image = Global.final_proj_hotel_kiosk.My.Resources.Resources.ad1
        Me.ads.ImageRotate = 0!
        Me.ads.InitialImage = CType(resources.GetObject("ads.InitialImage"), System.Drawing.Image)
        Me.ads.Location = New System.Drawing.Point(200, 0)
        Me.ads.Name = "ads"
        Me.ads.Size = New System.Drawing.Size(652, 961)
        Me.ads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ads.TabIndex = 1
        Me.ads.TabStop = False
        '
        'logopic
        '
        Me.logopic.Dock = System.Windows.Forms.DockStyle.Top
        Me.logopic.FillColor = System.Drawing.Color.DimGray
        Me.logopic.Image = CType(resources.GetObject("logopic.Image"), System.Drawing.Image)
        Me.logopic.ImageRotate = 0!
        Me.logopic.Location = New System.Drawing.Point(0, 0)
        Me.logopic.Name = "logopic"
        Me.logopic.Size = New System.Drawing.Size(203, 131)
        Me.logopic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logopic.TabIndex = 0
        Me.logopic.TabStop = False
        '
        'landingpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(851, 961)
        Me.Controls.Add(Me.ads)
        Me.Controls.Add(Me.sidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "landingpage"
        Me.Text = "Form1"
        Me.sidebar.ResumeLayout(False)
        Me.sidebar.PerformLayout()
        CType(Me.ads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logopic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sidebar As Panel
    Friend WithEvents logopic As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents ads As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents LOGO As Label
    Friend WithEvents room_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents timer1 As Timer
    Friend WithEvents footandbev_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents voucher_btn As Guna.UI2.WinForms.Guna2Button
End Class
