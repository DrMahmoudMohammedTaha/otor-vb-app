<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcSheikhs
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.dgvSheikhs = New System.Windows.Forms.DataGridView()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.grpStats = New System.Windows.Forms.GroupBox()
        Me.lblActiveOrders = New System.Windows.Forms.Label()
        Me.lblTotalCerts = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblSheikhBio = New System.Windows.Forms.Label()
        Me.pnlActions = New System.Windows.Forms.Panel()
        Me.btnOpenFolder = New System.Windows.Forms.Button()
        Me.btnCall = New System.Windows.Forms.Button()
        Me.btnDeleteSheikh = New System.Windows.Forms.Button()
        Me.btnEditSheikh = New System.Windows.Forms.Button()
        Me.btnAddSheikh = New System.Windows.Forms.Button()
        Me.pnlLeft.SuspendLayout()
        CType(Me.dgvSheikhs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSearch.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        Me.grpStats.SuspendLayout()
        Me.pnlActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlLeft
        '
        Me.pnlLeft.Controls.Add(Me.dgvSheikhs)
        Me.pnlLeft.Controls.Add(Me.pnlSearch)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlLeft.Size = New System.Drawing.Size(550, 640)
        Me.pnlLeft.TabIndex = 0
        '
        'dgvSheikhs
        '
        Me.dgvSheikhs.AllowUserToAddRows = False
        Me.dgvSheikhs.AllowUserToDeleteRows = False
        Me.dgvSheikhs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSheikhs.BackgroundColor = System.Drawing.Color.White
        Me.dgvSheikhs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSheikhs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSheikhs.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSheikhs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSheikhs.Location = New System.Drawing.Point(10, 60)
        Me.dgvSheikhs.MultiSelect = False
        Me.dgvSheikhs.Name = "dgvSheikhs"
        Me.dgvSheikhs.ReadOnly = True
        Me.dgvSheikhs.RowHeadersVisible = False
        Me.dgvSheikhs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSheikhs.Size = New System.Drawing.Size(530, 570)
        Me.dgvSheikhs.TabIndex = 1
        '
        'pnlSearch
        '
        Me.pnlSearch.Controls.Add(Me.lblSearch)
        Me.pnlSearch.Controls.Add(Me.txtSearch)
        Me.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearch.Location = New System.Drawing.Point(10, 10)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(530, 50)
        Me.pnlSearch.TabIndex = 0
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSearch.Location = New System.Drawing.Point(460, 14)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(65, 19)
        Me.lblSearch.TabIndex = 1
        Me.lblSearch.Text = "بحث سريع:"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSearch.Location = New System.Drawing.Point(10, 10)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(430, 27)
        Me.txtSearch.TabIndex = 0
        '
        'pnlRight
        '
        Me.pnlRight.BackColor = System.Drawing.Color.White
        Me.pnlRight.Controls.Add(Me.grpStats)
        Me.pnlRight.Controls.Add(Me.pnlActions)
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlRight.Location = New System.Drawing.Point(550, 0)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlRight.Size = New System.Drawing.Size(350, 640)
        Me.pnlRight.TabIndex = 1
        '
        'grpStats
        '
        Me.grpStats.Controls.Add(Me.lblActiveOrders)
        Me.grpStats.Controls.Add(Me.lblTotalCerts)
        Me.grpStats.Controls.Add(Me.lblTotalCost)
        Me.grpStats.Controls.Add(Me.lblSheikhBio)
        Me.grpStats.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpStats.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpStats.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.grpStats.Location = New System.Drawing.Point(10, 10)
        Me.grpStats.Name = "grpStats"
        Me.grpStats.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grpStats.Size = New System.Drawing.Size(330, 420)
        Me.grpStats.TabIndex = 0
        Me.grpStats.TabStop = False
        Me.grpStats.Text = "بيانات وإحصائيات الشيخ"
        '
        'lblActiveOrders
        '
        Me.lblActiveOrders.AutoSize = True
        Me.lblActiveOrders.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblActiveOrders.Location = New System.Drawing.Point(20, 240)
        Me.lblActiveOrders.Name = "lblActiveOrders"
        Me.lblActiveOrders.Size = New System.Drawing.Size(127, 19)
        Me.lblActiveOrders.TabIndex = 3
        Me.lblActiveOrders.Text = "الطلبات النشطة حالياً: 0"
        '
        'lblTotalCerts
        '
        Me.lblTotalCerts.AutoSize = True
        Me.lblTotalCerts.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTotalCerts.Location = New System.Drawing.Point(20, 200)
        Me.lblTotalCerts.Name = "lblTotalCerts"
        Me.lblTotalCerts.Size = New System.Drawing.Size(149, 19)
        Me.lblTotalCerts.TabIndex = 2
        Me.lblTotalCerts.Text = "إجمالي الشهادات المنجزة: 0"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTotalCost.Location = New System.Drawing.Point(20, 160)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(136, 19)
        Me.lblTotalCost.TabIndex = 1
        Me.lblTotalCost.Text = "التكلفة الكلية السابقة: 0"
        '
        'lblSheikhBio
        '
        Me.lblSheikhBio.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSheikhBio.Location = New System.Drawing.Point(20, 40)
        Me.lblSheikhBio.Name = "lblSheikhBio"
        Me.lblSheikhBio.Size = New System.Drawing.Size(290, 100)
        Me.lblSheikhBio.TabIndex = 0
        Me.lblSheikhBio.Text = "يرجى تحديد شيخ لعرض تفاصيله"
        '
        'pnlActions
        '
        Me.pnlActions.Controls.Add(Me.btnOpenFolder)
        Me.pnlActions.Controls.Add(Me.btnCall)
        Me.pnlActions.Controls.Add(Me.btnDeleteSheikh)
        Me.pnlActions.Controls.Add(Me.btnEditSheikh)
        Me.pnlActions.Controls.Add(Me.btnAddSheikh)
        Me.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlActions.Location = New System.Drawing.Point(10, 390)
        Me.pnlActions.Name = "pnlActions"
        Me.pnlActions.Size = New System.Drawing.Size(330, 240)
        Me.pnlActions.TabIndex = 1
        '
        'btnOpenFolder
        '
        Me.btnOpenFolder.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnOpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenFolder.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnOpenFolder.ForeColor = System.Drawing.Color.White
        Me.btnOpenFolder.Location = New System.Drawing.Point(10, 170)
        Me.btnOpenFolder.Name = "btnOpenFolder"
        Me.btnOpenFolder.Size = New System.Drawing.Size(310, 40)
        Me.btnOpenFolder.TabIndex = 3
        Me.btnOpenFolder.Text = "فتح مجلد ملفات الشيخ"
        Me.btnOpenFolder.UseVisualStyleBackColor = False
        '
        'btnCall
        '
        Me.btnCall.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCall.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCall.ForeColor = System.Drawing.Color.White
        Me.btnCall.Location = New System.Drawing.Point(10, 125)
        Me.btnCall.Name = "btnCall"
        Me.btnCall.Size = New System.Drawing.Size(310, 35)
        Me.btnCall.TabIndex = 4
        Me.btnCall.Text = "اتصال هاتفياً بالشيخ"
        Me.btnCall.UseVisualStyleBackColor = False
        '
        'btnDeleteSheikh
        '
        Me.btnDeleteSheikh.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnDeleteSheikh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteSheikh.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDeleteSheikh.ForeColor = System.Drawing.Color.White
        Me.btnDeleteSheikh.Location = New System.Drawing.Point(10, 85)
        Me.btnDeleteSheikh.Name = "btnDeleteSheikh"
        Me.btnDeleteSheikh.Size = New System.Drawing.Size(310, 35)
        Me.btnDeleteSheikh.TabIndex = 2
        Me.btnDeleteSheikh.Text = "حذف الشيخ الحالي"
        Me.btnDeleteSheikh.UseVisualStyleBackColor = False
        '
        'btnEditSheikh
        '
        Me.btnEditSheikh.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnEditSheikh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditSheikh.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnEditSheikh.ForeColor = System.Drawing.Color.White
        Me.btnEditSheikh.Location = New System.Drawing.Point(10, 45)
        Me.btnEditSheikh.Name = "btnEditSheikh"
        Me.btnEditSheikh.Size = New System.Drawing.Size(310, 35)
        Me.btnEditSheikh.TabIndex = 1
        Me.btnEditSheikh.Text = "تعديل بيانات الشيخ"
        Me.btnEditSheikh.UseVisualStyleBackColor = False
        '
        'btnAddSheikh
        '
        Me.btnAddSheikh.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btnAddSheikh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSheikh.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddSheikh.ForeColor = System.Drawing.Color.White
        Me.btnAddSheikh.Location = New System.Drawing.Point(10, 5)
        Me.btnAddSheikh.Name = "btnAddSheikh"
        Me.btnAddSheikh.Size = New System.Drawing.Size(310, 35)
        Me.btnAddSheikh.TabIndex = 0
        Me.btnAddSheikh.Text = "إضافة شيخ جديد"
        Me.btnAddSheikh.UseVisualStyleBackColor = False
        '
        'UcSheikhs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlRight)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "UcSheikhs"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Size = New System.Drawing.Size(900, 640)
        Me.pnlLeft.ResumeLayout(False)
        CType(Me.dgvSheikhs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.pnlRight.ResumeLayout(False)
        Me.grpStats.ResumeLayout(False)
        Me.grpStats.PerformLayout()
        Me.pnlActions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlLeft As Panel
    Friend WithEvents dgvSheikhs As DataGridView
    Friend WithEvents pnlSearch As Panel
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents pnlRight As Panel
    Friend WithEvents grpStats As GroupBox
    Friend WithEvents lblSheikhBio As Label
    Friend WithEvents lblActiveOrders As Label
    Friend WithEvents lblTotalCerts As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents pnlActions As Panel
    Friend WithEvents btnOpenFolder As Button
    Friend WithEvents btnDeleteSheikh As Button
    Friend WithEvents btnEditSheikh As Button
    Friend WithEvents btnAddSheikh As Button
    Friend WithEvents btnCall As Button
End Class
