<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class voucher
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(voucher))
        Me.sidebar = New System.Windows.Forms.Panel()
        Me.voucher_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.footandbev_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.room_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.LOGO = New System.Windows.Forms.Label()
        Me.logopic = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.total_balance = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.number_of_items = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.sidebar.SuspendLayout()
        CType(Me.logopic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
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
        Me.sidebar.TabIndex = 2
        '
        'voucher_btn
        '
        Me.voucher_btn.BorderRadius = 15
        Me.voucher_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.voucher_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.voucher_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.voucher_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.voucher_btn.FillColor = System.Drawing.Color.White
        Me.voucher_btn.Font = New System.Drawing.Font("Aksioma DEMO", 15.75!, System.Drawing.FontStyle.Bold)
        Me.voucher_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(84, Byte), Integer))
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
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Guna2Panel2.Controls.Add(Me.total_balance)
        Me.Guna2Panel2.Controls.Add(Me.Label19)
        Me.Guna2Panel2.Controls.Add(Me.Label20)
        Me.Guna2Panel2.Controls.Add(Me.number_of_items)
        Me.Guna2Panel2.Controls.Add(Me.Label21)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel2.Location = New System.Drawing.Point(203, 875)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(648, 86)
        Me.Guna2Panel2.TabIndex = 6
        '
        'total_balance
        '
        Me.total_balance.AutoSize = True
        Me.total_balance.Font = New System.Drawing.Font("Aksioma DEMO", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_balance.ForeColor = System.Drawing.Color.Black
        Me.total_balance.Location = New System.Drawing.Point(583, 37)
        Me.total_balance.Name = "total_balance"
        Me.total_balance.Size = New System.Drawing.Size(32, 19)
        Me.total_balance.TabIndex = 7
        Me.total_balance.Text = "₱0"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Aksioma DEMO", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(6, 17)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(66, 39)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "🏨"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Aksioma DEMO", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(74, 56)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(120, 15)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Tap to view details"
        '
        'number_of_items
        '
        Me.number_of_items.AutoSize = True
        Me.number_of_items.Font = New System.Drawing.Font("Aksioma DEMO", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.number_of_items.ForeColor = System.Drawing.Color.Black
        Me.number_of_items.Location = New System.Drawing.Point(74, 36)
        Me.number_of_items.Name = "number_of_items"
        Me.number_of_items.Size = New System.Drawing.Size(52, 15)
        Me.number_of_items.TabIndex = 4
        Me.number_of_items.Text = "0 Items"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Aksioma DEMO", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(74, 17)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(103, 15)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "Booking Details:"
        '
        'voucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.sidebar)
        Me.Name = "voucher"
        Me.Size = New System.Drawing.Size(851, 961)
        Me.sidebar.ResumeLayout(False)
        Me.sidebar.PerformLayout()
        CType(Me.logopic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents sidebar As Panel
    Friend WithEvents voucher_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents footandbev_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents room_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LOGO As Label
    Friend WithEvents logopic As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents total_balance As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents number_of_items As Label
    Friend WithEvents Label21 As Label
End Class
