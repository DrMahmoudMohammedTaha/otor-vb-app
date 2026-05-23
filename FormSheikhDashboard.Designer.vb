<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSheikhDashboard
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
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.pnlStats = New System.Windows.Forms.Panel()
        Me.pnlStatCerts = New System.Windows.Forms.Panel()
        Me.lblCertsCount = New System.Windows.Forms.Label()
        Me.lblCertsLabel = New System.Windows.Forms.Label()
        Me.pnlStatCost = New System.Windows.Forms.Panel()
        Me.lblEarned = New System.Windows.Forms.Label()
        Me.lblCostLabel = New System.Windows.Forms.Label()
        Me.pnlStatActive = New System.Windows.Forms.Panel()
        Me.lblActiveCount = New System.Windows.Forms.Label()
        Me.lblActiveLabel = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.tabActive = New System.Windows.Forms.TabPage()
        Me.dgvActiveOrders = New System.Windows.Forms.DataGridView()
        Me.tabHistory = New System.Windows.Forms.TabPage()
        Me.dgvHistoryOrders = New System.Windows.Forms.DataGridView()
        Me.btnViewOrderDetails = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.pnlStats.SuspendLayout()
        Me.pnlStatCerts.SuspendLayout()
        Me.pnlStatCost.SuspendLayout()
        Me.pnlStatActive.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.tabMain.SuspendLayout()
        Me.tabActive.SuspendLayout()
        CType(Me.dgvActiveOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabHistory.SuspendLayout()
        CType(Me.dgvHistoryOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.btnLogout)
        Me.pnlHeader.Controls.Add(Me.lblHeaderTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(984, 70)
        Me.pnlHeader.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(20, 18)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(120, 35)
        Me.btnLogout.TabIndex = 1
        Me.btnLogout.Text = "تسجيل الخروج"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lblHeaderTitle.Location = New System.Drawing.Point(500, 20)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(464, 30)
        Me.lblHeaderTitle.TabIndex = 0
        Me.lblHeaderTitle.Text = "بوابة الشيخ:"
        '
        'pnlStats
        '
        Me.pnlStats.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlStats.Controls.Add(Me.pnlStatCerts)
        Me.pnlStats.Controls.Add(Me.pnlStatCost)
        Me.pnlStats.Controls.Add(Me.pnlStatActive)
        Me.pnlStats.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlStats.Location = New System.Drawing.Point(0, 70)
        Me.pnlStats.Name = "pnlStats"
        Me.pnlStats.Size = New System.Drawing.Size(984, 110)
        Me.pnlStats.TabIndex = 1
        '
        'pnlStatCerts
        '
        Me.pnlStatCerts.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlStatCerts.BackColor = System.Drawing.Color.White
        Me.pnlStatCerts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlStatCerts.Controls.Add(Me.lblCertsCount)
        Me.pnlStatCerts.Controls.Add(Me.lblCertsLabel)
        Me.pnlStatCerts.Location = New System.Drawing.Point(120, 15)
        Me.pnlStatCerts.Name = "pnlStatCerts"
        Me.pnlStatCerts.Size = New System.Drawing.Size(240, 80)
        Me.pnlStatCerts.TabIndex = 2
        '
        'lblCertsCount
        '
        Me.lblCertsCount.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCertsCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lblCertsCount.Location = New System.Drawing.Point(3, 40)
        Me.lblCertsCount.Name = "lblCertsCount"
        Me.lblCertsCount.Size = New System.Drawing.Size(232, 30)
        Me.lblCertsCount.TabIndex = 1
        Me.lblCertsCount.Text = "0"
        Me.lblCertsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCertsLabel
        '
        Me.lblCertsLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCertsLabel.ForeColor = System.Drawing.Color.Gray
        Me.lblCertsLabel.Location = New System.Drawing.Point(3, 10)
        Me.lblCertsLabel.Name = "lblCertsLabel"
        Me.lblCertsLabel.Size = New System.Drawing.Size(232, 23)
        Me.lblCertsLabel.TabIndex = 0
        Me.lblCertsLabel.Text = "إجمالي الشهادات المنجزة"
        Me.lblCertsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlStatCost
        '
        Me.pnlStatCost.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlStatCost.BackColor = System.Drawing.Color.White
        Me.pnlStatCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlStatCost.Controls.Add(Me.lblEarned)
        Me.pnlStatCost.Controls.Add(Me.lblCostLabel)
        Me.pnlStatCost.Location = New System.Drawing.Point(372, 15)
        Me.pnlStatCost.Name = "pnlStatCost"
        Me.pnlStatCost.Size = New System.Drawing.Size(240, 80)
        Me.pnlStatCost.TabIndex = 1
        '
        'lblEarned
        '
        Me.lblEarned.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblEarned.ForeColor = System.Drawing.Color.Green
        Me.lblEarned.Location = New System.Drawing.Point(3, 40)
        Me.lblEarned.Name = "lblEarned"
        Me.lblEarned.Size = New System.Drawing.Size(232, 30)
        Me.lblEarned.TabIndex = 1
        Me.lblEarned.Text = "EGP 0.00"
        Me.lblEarned.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCostLabel
        '
        Me.lblCostLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCostLabel.ForeColor = System.Drawing.Color.Gray
        Me.lblCostLabel.Location = New System.Drawing.Point(3, 10)
        Me.lblCostLabel.Name = "lblCostLabel"
        Me.lblCostLabel.Size = New System.Drawing.Size(232, 23)
        Me.lblCostLabel.TabIndex = 0
        Me.lblCostLabel.Text = "التكلفة الكلية السابقة"
        Me.lblCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlStatActive
        '
        Me.pnlStatActive.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlStatActive.BackColor = System.Drawing.Color.White
        Me.pnlStatActive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlStatActive.Controls.Add(Me.lblActiveCount)
        Me.pnlStatActive.Controls.Add(Me.lblActiveLabel)
        Me.pnlStatActive.Location = New System.Drawing.Point(624, 15)
        Me.pnlStatActive.Name = "pnlStatActive"
        Me.pnlStatActive.Size = New System.Drawing.Size(240, 80)
        Me.pnlStatActive.TabIndex = 0
        '
        'lblActiveCount
        '
        Me.lblActiveCount.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblActiveCount.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblActiveCount.Location = New System.Drawing.Point(3, 40)
        Me.lblActiveCount.Name = "lblActiveCount"
        Me.lblActiveCount.Size = New System.Drawing.Size(232, 30)
        Me.lblActiveCount.TabIndex = 1
        Me.lblActiveCount.Text = "0"
        Me.lblActiveCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblActiveLabel
        '
        Me.lblActiveLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblActiveLabel.ForeColor = System.Drawing.Color.Gray
        Me.lblActiveLabel.Location = New System.Drawing.Point(3, 10)
        Me.lblActiveLabel.Name = "lblActiveLabel"
        Me.lblActiveLabel.Size = New System.Drawing.Size(232, 23)
        Me.lblActiveLabel.TabIndex = 0
        Me.lblActiveLabel.Text = "الطلبات النشطة حالياً"
        Me.lblActiveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.tabMain)
        Me.pnlMain.Controls.Add(Me.btnViewOrderDetails)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 180)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlMain.Size = New System.Drawing.Size(984, 461)
        Me.pnlMain.TabIndex = 2
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.tabActive)
        Me.tabMain.Controls.Add(Me.tabHistory)
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tabMain.Location = New System.Drawing.Point(20, 20)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(944, 376)
        Me.tabMain.TabIndex = 0
        '
        'tabActive
        '
        Me.tabActive.Controls.Add(Me.dgvActiveOrders)
        Me.tabActive.Location = New System.Drawing.Point(4, 26)
        Me.tabActive.Name = "tabActive"
        Me.tabActive.Padding = New System.Windows.Forms.Padding(10)
        Me.tabActive.Size = New System.Drawing.Size(936, 346)
        Me.tabActive.TabIndex = 0
        Me.tabActive.Text = "الطلبات النشطة حالياً"
        Me.tabActive.UseVisualStyleBackColor = True
        '
        'dgvActiveOrders
        '
        Me.dgvActiveOrders.AllowUserToAddRows = False
        Me.dgvActiveOrders.AllowUserToDeleteRows = False
        Me.dgvActiveOrders.BackgroundColor = System.Drawing.Color.White
        Me.dgvActiveOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActiveOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvActiveOrders.Location = New System.Drawing.Point(10, 10)
        Me.dgvActiveOrders.MultiSelect = False
        Me.dgvActiveOrders.Name = "dgvActiveOrders"
        Me.dgvActiveOrders.ReadOnly = True
        Me.dgvActiveOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvActiveOrders.Size = New System.Drawing.Size(916, 326)
        Me.dgvActiveOrders.TabIndex = 0
        '
        'tabHistory
        '
        Me.tabHistory.Controls.Add(Me.dgvHistoryOrders)
        Me.tabHistory.Location = New System.Drawing.Point(4, 26)
        Me.tabHistory.Name = "tabHistory"
        Me.tabHistory.Padding = New System.Windows.Forms.Padding(10)
        Me.tabHistory.Size = New System.Drawing.Size(936, 346)
        Me.tabHistory.TabIndex = 1
        Me.tabHistory.Text = "سجل الطلبات السابقة"
        Me.tabHistory.UseVisualStyleBackColor = True
        '
        'dgvHistoryOrders
        '
        Me.dgvHistoryOrders.AllowUserToAddRows = False
        Me.dgvHistoryOrders.AllowUserToDeleteRows = False
        Me.dgvHistoryOrders.BackgroundColor = System.Drawing.Color.White
        Me.dgvHistoryOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistoryOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvHistoryOrders.Location = New System.Drawing.Point(10, 10)
        Me.dgvHistoryOrders.MultiSelect = False
        Me.dgvHistoryOrders.Name = "dgvHistoryOrders"
        Me.dgvHistoryOrders.ReadOnly = True
        Me.dgvHistoryOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHistoryOrders.Size = New System.Drawing.Size(916, 326)
        Me.dgvHistoryOrders.TabIndex = 0
        '
        'btnViewOrderDetails
        '
        Me.btnViewOrderDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnViewOrderDetails.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnViewOrderDetails.FlatAppearance.BorderSize = 0
        Me.btnViewOrderDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewOrderDetails.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnViewOrderDetails.ForeColor = System.Drawing.Color.White
        Me.btnViewOrderDetails.Location = New System.Drawing.Point(20, 396)
        Me.btnViewOrderDetails.Name = "btnViewOrderDetails"
        Me.btnViewOrderDetails.Size = New System.Drawing.Size(944, 45)
        Me.btnViewOrderDetails.TabIndex = 1
        Me.btnViewOrderDetails.Text = "عرض وتدقيق أسماء الطلاب بالشهادات للطلب المحدد"
        Me.btnViewOrderDetails.UseVisualStyleBackColor = False
        '
        'FormSheikhDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 641)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlStats)
        Me.Controls.Add(Me.pnlHeader)
        Me.Name = "FormSheikhDashboard"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "عطور القرآن - بوابة الشيخ"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlStats.ResumeLayout(False)
        Me.pnlStatCerts.ResumeLayout(False)
        Me.pnlStatCost.ResumeLayout(False)
        Me.pnlStatActive.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.tabMain.ResumeLayout(False)
        Me.tabActive.ResumeLayout(False)
        CType(Me.dgvActiveOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabHistory.ResumeLayout(False)
        CType(Me.dgvHistoryOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents pnlStats As Panel
    Friend WithEvents pnlStatCerts As Panel
    Friend WithEvents lblCertsCount As Label
    Friend WithEvents lblCertsLabel As Label
    Friend WithEvents pnlStatCost As Panel
    Friend WithEvents lblEarned As Label
    Friend WithEvents lblCostLabel As Label
    Friend WithEvents pnlStatActive As Panel
    Friend WithEvents lblActiveCount As Label
    Friend WithEvents lblActiveLabel As Label
    Friend WithEvents pnlMain As Panel
    Friend WithEvents tabMain As TabControl
    Friend WithEvents tabActive As TabPage
    Friend WithEvents dgvActiveOrders As DataGridView
    Friend WithEvents tabHistory As TabPage
    Friend WithEvents dgvHistoryOrders As DataGridView
    Friend WithEvents btnViewOrderDetails As Button
End Class
