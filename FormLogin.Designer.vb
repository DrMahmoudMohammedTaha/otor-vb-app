<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.picBanner = New System.Windows.Forms.PictureBox()
        Me.pnlLoginControls = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.cmbRole = New System.Windows.Forms.ComboBox()
        Me.pnlAdmin = New System.Windows.Forms.Panel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.pnlSheikh = New System.Windows.Forms.Panel()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.pnlGallery = New System.Windows.Forms.Panel()
        Me.lblGalleryInfo = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLoginControls.SuspendLayout()
        Me.pnlAdmin.SuspendLayout()
        Me.pnlSheikh.SuspendLayout()
        Me.pnlGallery.SuspendLayout()
        Me.SuspendLayout()
        '
        'picBanner
        '
        Me.picBanner.Dock = System.Windows.Forms.DockStyle.Right
        Me.picBanner.Location = New System.Drawing.Point(430, 0)
        Me.picBanner.Name = "picBanner"
        Me.picBanner.Size = New System.Drawing.Size(320, 441)
        Me.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBanner.TabIndex = 0
        Me.picBanner.TabStop = False
        '
        'pnlLoginControls
        '
        Me.pnlLoginControls.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.pnlLoginControls.Controls.Add(Me.lblStatus)
        Me.pnlLoginControls.Controls.Add(Me.btnLogin)
        Me.pnlLoginControls.Controls.Add(Me.pnlAdmin)
        Me.pnlLoginControls.Controls.Add(Me.pnlSheikh)
        Me.pnlLoginControls.Controls.Add(Me.pnlGallery)
        Me.pnlLoginControls.Controls.Add(Me.cmbRole)
        Me.pnlLoginControls.Controls.Add(Me.lblRole)
        Me.pnlLoginControls.Controls.Add(Me.lblSubtitle)
        Me.pnlLoginControls.Controls.Add(Me.lblTitle)
        Me.pnlLoginControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLoginControls.Location = New System.Drawing.Point(0, 0)
        Me.pnlLoginControls.Name = "pnlLoginControls"
        Me.pnlLoginControls.Size = New System.Drawing.Size(430, 441)
        Me.pnlLoginControls.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(12, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(406, 50)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "عطور القرآن"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubtitle
        '
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblSubtitle.Location = New System.Drawing.Point(12, 70)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(406, 23)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "نظام إدارة الإجازات والشهادات"
        Me.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lblRole.Location = New System.Drawing.Point(321, 110)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(78, 19)
        Me.lblRole.TabIndex = 2
        Me.lblRole.Text = "نوع الحساب"
        '
        'cmbRole
        '
        Me.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRole.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbRole.FormattingEnabled = True
        Me.cmbRole.Items.AddRange(New Object() {"مدير النظام", "شيخ مقرأة", "معرض المنتجات"})
        Me.cmbRole.Location = New System.Drawing.Point(40, 132)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New System.Drawing.Size(350, 28)
        Me.cmbRole.TabIndex = 3
        '
        'pnlAdmin
        '
        Me.pnlAdmin.Controls.Add(Me.txtPassword)
        Me.pnlAdmin.Controls.Add(Me.lblPassword)
        Me.pnlAdmin.Location = New System.Drawing.Point(40, 180)
        Me.pnlAdmin.Name = "pnlAdmin"
        Me.pnlAdmin.Size = New System.Drawing.Size(350, 80)
        Me.pnlAdmin.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPassword.Location = New System.Drawing.Point(0, 30)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(350, 27)
        Me.txtPassword.TabIndex = 1
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(266, 8)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(81, 19)
        Me.lblPassword.TabIndex = 0
        Me.lblPassword.Text = "كلمة المرور"
        '
        'pnlSheikh
        '
        Me.pnlSheikh.Controls.Add(Me.txtPhone)
        Me.pnlSheikh.Controls.Add(Me.lblPhone)
        Me.pnlSheikh.Location = New System.Drawing.Point(40, 180)
        Me.pnlSheikh.Name = "pnlSheikh"
        Me.pnlSheikh.Size = New System.Drawing.Size(350, 80)
        Me.pnlSheikh.TabIndex = 5
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPhone.Location = New System.Drawing.Point(0, 30)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(350, 27)
        Me.txtPhone.TabIndex = 1
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lblPhone.Location = New System.Drawing.Point(220, 8)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(127, 19)
        Me.lblPhone.TabIndex = 0
        Me.lblPhone.Text = "رقم الهاتف المسجل"
        '
        'pnlGallery
        '
        Me.pnlGallery.Controls.Add(Me.lblGalleryInfo)
        Me.pnlGallery.Location = New System.Drawing.Point(40, 180)
        Me.pnlGallery.Name = "pnlGallery"
        Me.pnlGallery.Size = New System.Drawing.Size(350, 80)
        Me.pnlGallery.TabIndex = 6
        '
        'lblGalleryInfo
        '
        Me.lblGalleryInfo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGalleryInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblGalleryInfo.Location = New System.Drawing.Point(0, 10)
        Me.lblGalleryInfo.Name = "lblGalleryInfo"
        Me.lblGalleryInfo.Size = New System.Drawing.Size(350, 60)
        Me.lblGalleryInfo.TabIndex = 0
        Me.lblGalleryInfo.Text = "دخول مباشر للمعرض لمشاهدة نماذج من تصاميم وعينات الإجازات، شهادات التقدير، الأغلفة، الأختام، وشجرات الأسانيد."
        Me.lblGalleryInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(40, 290)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(350, 45)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "تسجيل الدخول"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(12, 355)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(406, 40)
        Me.lblStatus.TabIndex = 8
        Me.lblStatus.Text = "جاري التحقق من الاتصال بالخادم..."
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 441)
        Me.Controls.Add(Me.pnlLoginControls)
        Me.Controls.Add(Me.picBanner)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FormLogin"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "عطور القرآن - تسجيل الدخول"
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLoginControls.ResumeLayout(False)
        Me.pnlLoginControls.PerformLayout()
        Me.pnlAdmin.ResumeLayout(False)
        Me.pnlAdmin.PerformLayout()
        Me.pnlSheikh.ResumeLayout(False)
        Me.pnlSheikh.PerformLayout()
        Me.pnlGallery.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picBanner As PictureBox
    Friend WithEvents pnlLoginControls As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents pnlAdmin As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents pnlSheikh As Panel
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents pnlGallery As Panel
    Friend WithEvents lblGalleryInfo As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblStatus As Label
End Class
