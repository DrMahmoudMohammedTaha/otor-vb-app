<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGallery
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.lblSidebarHeader = New System.Windows.Forms.Label()
        Me.btnCategoryEjaza = New System.Windows.Forms.Button()
        Me.btnCategoryBackground = New System.Windows.Forms.Button()
        Me.btnCategoryCover = New System.Windows.Forms.Button()
        Me.btnCategoryCertificate = New System.Windows.Forms.Button()
        Me.btnCategoryTree = New System.Windows.Forms.Button()
        Me.btnCategoryStamp = New System.Windows.Forms.Button()
        Me.flpImages = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlHeader.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.btnBack)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1008, 70)
        Me.pnlHeader.TabIndex = 0
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(20, 15)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(140, 40)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "رجوع لصفحة الدخول"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(520, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(468, 35)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "معرض النماذج والتصاميم"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.lblSidebarHeader)
        Me.pnlSidebar.Controls.Add(Me.btnCategoryEjaza)
        Me.pnlSidebar.Controls.Add(Me.btnCategoryBackground)
        Me.pnlSidebar.Controls.Add(Me.btnCategoryCover)
        Me.pnlSidebar.Controls.Add(Me.btnCategoryCertificate)
        Me.pnlSidebar.Controls.Add(Me.btnCategoryTree)
        Me.pnlSidebar.Controls.Add(Me.btnCategoryStamp)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlSidebar.Location = New System.Drawing.Point(788, 70)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlSidebar.Size = New System.Drawing.Size(220, 659)
        Me.pnlSidebar.TabIndex = 1
        '
        'lblSidebarHeader
        '
        Me.lblSidebarHeader.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSidebarHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lblSidebarHeader.Location = New System.Drawing.Point(10, 15)
        Me.lblSidebarHeader.Name = "lblSidebarHeader"
        Me.lblSidebarHeader.Size = New System.Drawing.Size(200, 25)
        Me.lblSidebarHeader.TabIndex = 0
        Me.lblSidebarHeader.Text = "التصنيفات المتاحة"
        Me.lblSidebarHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCategoryEjaza
        '
        Me.btnCategoryEjaza.BackColor = System.Drawing.Color.White
        Me.btnCategoryEjaza.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnCategoryEjaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategoryEjaza.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCategoryEjaza.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnCategoryEjaza.Location = New System.Drawing.Point(10, 55)
        Me.btnCategoryEjaza.Name = "btnCategoryEjaza"
        Me.btnCategoryEjaza.Size = New System.Drawing.Size(200, 45)
        Me.btnCategoryEjaza.TabIndex = 1
        Me.btnCategoryEjaza.Tag = "1_ejaza"
        Me.btnCategoryEjaza.Text = "إجازات قرآنية"
        Me.btnCategoryEjaza.UseVisualStyleBackColor = False
        '
        'btnCategoryBackground
        '
        Me.btnCategoryBackground.BackColor = System.Drawing.Color.White
        Me.btnCategoryBackground.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnCategoryBackground.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategoryBackground.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCategoryBackground.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnCategoryBackground.Location = New System.Drawing.Point(10, 110)
        Me.btnCategoryBackground.Name = "btnCategoryBackground"
        Me.btnCategoryBackground.Size = New System.Drawing.Size(200, 45)
        Me.btnCategoryBackground.TabIndex = 2
        Me.btnCategoryBackground.Tag = "2_background"
        Me.btnCategoryBackground.Text = "خلفيات تصاميم"
        Me.btnCategoryBackground.UseVisualStyleBackColor = False
        '
        'btnCategoryCover
        '
        Me.btnCategoryCover.BackColor = System.Drawing.Color.White
        Me.btnCategoryCover.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnCategoryCover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategoryCover.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCategoryCover.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnCategoryCover.Location = New System.Drawing.Point(10, 165)
        Me.btnCategoryCover.Name = "btnCategoryCover"
        Me.btnCategoryCover.Size = New System.Drawing.Size(200, 45)
        Me.btnCategoryCover.TabIndex = 3
        Me.btnCategoryCover.Tag = "3_cover"
        Me.btnCategoryCover.Text = "أغلفة شهادات"
        Me.btnCategoryCover.UseVisualStyleBackColor = False
        '
        'btnCategoryCertificate
        '
        Me.btnCategoryCertificate.BackColor = System.Drawing.Color.White
        Me.btnCategoryCertificate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnCategoryCertificate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategoryCertificate.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCategoryCertificate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnCategoryCertificate.Location = New System.Drawing.Point(10, 220)
        Me.btnCategoryCertificate.Name = "btnCategoryCertificate"
        Me.btnCategoryCertificate.Size = New System.Drawing.Size(200, 45)
        Me.btnCategoryCertificate.TabIndex = 4
        Me.btnCategoryCertificate.Tag = "4_certificate"
        Me.btnCategoryCertificate.Text = "شهادات تقدير"
        Me.btnCategoryCertificate.UseVisualStyleBackColor = False
        '
        'btnCategoryTree
        '
        Me.btnCategoryTree.BackColor = System.Drawing.Color.White
        Me.btnCategoryTree.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnCategoryTree.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategoryTree.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCategoryTree.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnCategoryTree.Location = New System.Drawing.Point(10, 275)
        Me.btnCategoryTree.Name = "btnCategoryTree"
        Me.btnCategoryTree.Size = New System.Drawing.Size(200, 45)
        Me.btnCategoryTree.TabIndex = 5
        Me.btnCategoryTree.Tag = "5_tree"
        Me.btnCategoryTree.Text = "شجرات الأسانيد"
        Me.btnCategoryTree.UseVisualStyleBackColor = False
        '
        'btnCategoryStamp
        '
        Me.btnCategoryStamp.BackColor = System.Drawing.Color.White
        Me.btnCategoryStamp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnCategoryStamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategoryStamp.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCategoryStamp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnCategoryStamp.Location = New System.Drawing.Point(10, 330)
        Me.btnCategoryStamp.Name = "btnCategoryStamp"
        Me.btnCategoryStamp.Size = New System.Drawing.Size(200, 45)
        Me.btnCategoryStamp.TabIndex = 6
        Me.btnCategoryStamp.Tag = "6_stamp"
        Me.btnCategoryStamp.Text = "أختام وإمضاءات"
        Me.btnCategoryStamp.UseVisualStyleBackColor = False
        '
        'flpImages
        '
        Me.flpImages.AutoScroll = True
        Me.flpImages.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.flpImages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpImages.Location = New System.Drawing.Point(0, 70)
        Me.flpImages.Name = "flpImages"
        Me.flpImages.Padding = New System.Windows.Forms.Padding(15)
        Me.flpImages.Size = New System.Drawing.Size(788, 659)
        Me.flpImages.TabIndex = 2
        '
        'FormGallery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.flpImages)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.pnlHeader)
        Me.Name = "FormGallery"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "عطور القرآن - معرض النماذج والتصاميم"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlSidebar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents lblSidebarHeader As Label
    Friend WithEvents btnCategoryEjaza As Button
    Friend WithEvents btnCategoryBackground As Button
    Friend WithEvents btnCategoryCover As Button
    Friend WithEvents btnCategoryCertificate As Button
    Friend WithEvents btnCategoryTree As Button
    Friend WithEvents btnCategoryStamp As Button
    Friend WithEvents flpImages As FlowLayoutPanel
End Class
