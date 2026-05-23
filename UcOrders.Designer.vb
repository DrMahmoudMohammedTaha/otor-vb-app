<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcOrders
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
        Me.pnlTopPackage = New System.Windows.Forms.Panel()
        Me.btnStartPackage = New System.Windows.Forms.Button()
        Me.lblPackageStatus = New System.Windows.Forms.Label()
        Me.pnlFilters = New System.Windows.Forms.Panel()
        Me.rdoDeliver = New System.Windows.Forms.RadioButton()
        Me.rdoPost = New System.Windows.Forms.RadioButton()
        Me.rdoPrint = New System.Windows.Forms.RadioButton()
        Me.rdoDesign = New System.Windows.Forms.RadioButton()
        Me.rdoNext = New System.Windows.Forms.RadioButton()
        Me.rdoAll = New System.Windows.Forms.RadioButton()
        Me.rdoHistory = New System.Windows.Forms.RadioButton()
        Me.dgvOrders = New System.Windows.Forms.DataGridView()
        Me.pnlActions = New System.Windows.Forms.Panel()
        Me.btnManageContent = New System.Windows.Forms.Button()
        Me.btnUpdateState = New System.Windows.Forms.Button()
        Me.btnDeleteOrder = New System.Windows.Forms.Button()
        Me.btnEditOrder = New System.Windows.Forms.Button()
        Me.btnAddOrder = New System.Windows.Forms.Button()
        Me.cmbStateUpdate = New System.Windows.Forms.ComboBox()
        Me.lblChangeState = New System.Windows.Forms.Label()
        Me.pnlTopPackage.SuspendLayout()
        Me.pnlFilters.SuspendLayout()
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTopPackage
        '
        Me.pnlTopPackage.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.pnlTopPackage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTopPackage.Controls.Add(Me.btnStartPackage)
        Me.pnlTopPackage.Controls.Add(Me.lblPackageStatus)
        Me.pnlTopPackage.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopPackage.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopPackage.Name = "pnlTopPackage"
        Me.pnlTopPackage.Size = New System.Drawing.Size(900, 50)
        Me.pnlTopPackage.TabIndex = 0
        '
        'btnStartPackage
        '
        Me.btnStartPackage.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnStartPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStartPackage.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnStartPackage.ForeColor = System.Drawing.Color.White
        Me.btnStartPackage.Location = New System.Drawing.Point(10, 10)
        Me.btnStartPackage.Name = "btnStartPackage"
        Me.btnStartPackage.Size = New System.Drawing.Size(180, 28)
        Me.btnStartPackage.TabIndex = 1
        Me.btnStartPackage.Text = "بدء دفعة شحن جديدة"
        Me.btnStartPackage.UseVisualStyleBackColor = False
        '
        'lblPackageStatus
        '
        Me.lblPackageStatus.AutoSize = True
        Me.lblPackageStatus.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPackageStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lblPackageStatus.Location = New System.Drawing.Point(600, 15)
        Me.lblPackageStatus.Name = "lblPackageStatus"
        Me.lblPackageStatus.Size = New System.Drawing.Size(252, 17)
        Me.lblPackageStatus.TabIndex = 0
        Me.lblPackageStatus.Text = "لم يتم شحن أي دفعة حتى الآن (أو جاري التحميل)"
        '
        'pnlFilters
        '
        Me.pnlFilters.BackColor = System.Drawing.Color.White
        Me.pnlFilters.Controls.Add(Me.rdoHistory)
        Me.pnlFilters.Controls.Add(Me.rdoDeliver)
        Me.pnlFilters.Controls.Add(Me.rdoPost)
        Me.pnlFilters.Controls.Add(Me.rdoPrint)
        Me.pnlFilters.Controls.Add(Me.rdoDesign)
        Me.pnlFilters.Controls.Add(Me.rdoNext)
        Me.pnlFilters.Controls.Add(Me.rdoAll)
        Me.pnlFilters.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilters.Location = New System.Drawing.Point(0, 50)
        Me.pnlFilters.Name = "pnlFilters"
        Me.pnlFilters.Size = New System.Drawing.Size(900, 45)
        Me.pnlFilters.TabIndex = 1
        '
        'rdoDeliver
        '
        Me.rdoDeliver.AutoSize = True
        Me.rdoDeliver.Location = New System.Drawing.Point(340, 12)
        Me.rdoDeliver.Name = "rdoDeliver"
        Me.rdoDeliver.Size = New System.Drawing.Size(107, 21)
        Me.rdoDeliver.TabIndex = 5
        Me.rdoDeliver.Text = "DELIVER التسليم"
        Me.rdoDeliver.UseVisualStyleBackColor = True
        '
        'rdoPost
        '
        Me.rdoPost.AutoSize = True
        Me.rdoPost.Location = New System.Drawing.Point(470, 12)
        Me.rdoPost.Name = "rdoPost"
        Me.rdoPost.Size = New System.Drawing.Size(89, 21)
        Me.rdoPost.TabIndex = 4
        Me.rdoPost.Text = "POST الشحن"
        Me.rdoPost.UseVisualStyleBackColor = True
        '
        'rdoPrint
        '
        Me.rdoPrint.AutoSize = True
        Me.rdoPrint.Location = New System.Drawing.Point(580, 12)
        Me.rdoPrint.Name = "rdoPrint"
        Me.rdoPrint.Size = New System.Drawing.Size(95, 21)
        Me.rdoPrint.TabIndex = 3
        Me.rdoPrint.Text = "PRINT الطباعة"
        Me.rdoPrint.UseVisualStyleBackColor = True
        '
        'rdoDesign
        '
        Me.rdoDesign.AutoSize = True
        Me.rdoDesign.Location = New System.Drawing.Point(700, 12)
        Me.rdoDesign.Name = "rdoDesign"
        Me.rdoDesign.Size = New System.Drawing.Size(104, 21)
        Me.rdoDesign.TabIndex = 2
        Me.rdoDesign.Text = "DESIGN التصميم"
        Me.rdoDesign.UseVisualStyleBackColor = True
        '
        'rdoNext
        '
        Me.rdoNext.AutoSize = True
        Me.rdoNext.Location = New System.Drawing.Point(820, 12)
        Me.rdoNext.Name = "rdoNext"
        Me.rdoNext.Size = New System.Drawing.Size(89, 21)
        Me.rdoNext.TabIndex = 1
        Me.rdoNext.Text = "NEXT التالي"
        Me.rdoNext.UseVisualStyleBackColor = True
        '
        'rdoAll
        '
        Me.rdoAll.AutoSize = True
        Me.rdoAll.Checked = True
        Me.rdoAll.Location = New System.Drawing.Point(240, 12)
        Me.rdoAll.Name = "rdoAll"
        Me.rdoAll.Size = New System.Drawing.Size(78, 21)
        Me.rdoAll.TabIndex = 0
        Me.rdoAll.TabStop = True
        Me.rdoAll.Text = "كل الطلبات"
        Me.rdoAll.UseVisualStyleBackColor = True
        '
        'rdoHistory
        '
        Me.rdoHistory.AutoSize = True
        Me.rdoHistory.Location = New System.Drawing.Point(110, 12)
        Me.rdoHistory.Name = "rdoHistory"
        Me.rdoHistory.Size = New System.Drawing.Size(120, 21)
        Me.rdoHistory.TabIndex = 6
        Me.rdoHistory.Text = "HISTORY الأرشيف"
        Me.rdoHistory.UseVisualStyleBackColor = True
        '
        'dgvOrders
        '
        Me.dgvOrders.AllowUserToAddRows = False
        Me.dgvOrders.AllowUserToDeleteRows = False
        Me.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOrders.BackgroundColor = System.Drawing.Color.White
        Me.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOrders.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOrders.Location = New System.Drawing.Point(0, 95)
        Me.dgvOrders.MultiSelect = False
        Me.dgvOrders.Name = "dgvOrders"
        Me.dgvOrders.ReadOnly = True
        Me.dgvOrders.RowHeadersVisible = False
        Me.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOrders.Size = New System.Drawing.Size(900, 485)
        Me.dgvOrders.TabIndex = 2
        '
        'pnlActions
        '
        Me.pnlActions.BackColor = System.Drawing.Color.White
        Me.pnlActions.Controls.Add(Me.lblChangeState)
        Me.pnlActions.Controls.Add(Me.cmbStateUpdate)
        Me.pnlActions.Controls.Add(Me.btnManageContent)
        Me.pnlActions.Controls.Add(Me.btnUpdateState)
        Me.pnlActions.Controls.Add(Me.btnDeleteOrder)
        Me.pnlActions.Controls.Add(Me.btnEditOrder)
        Me.pnlActions.Controls.Add(Me.btnAddOrder)
        Me.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlActions.Location = New System.Drawing.Point(0, 580)
        Me.pnlActions.Name = "pnlActions"
        Me.pnlActions.Size = New System.Drawing.Size(900, 60)
        Me.pnlActions.TabIndex = 3
        '
        'btnManageContent
        '
        Me.btnManageContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnManageContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageContent.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnManageContent.ForeColor = System.Drawing.Color.White
        Me.btnManageContent.Location = New System.Drawing.Point(400, 12)
        Me.btnManageContent.Name = "btnManageContent"
        Me.btnManageContent.Size = New System.Drawing.Size(140, 35)
        Me.btnManageContent.TabIndex = 4
        Me.btnManageContent.Text = "إدارة الطلاب والشهادات"
        Me.btnManageContent.UseVisualStyleBackColor = False
        '
        'btnUpdateState
        '
        Me.btnUpdateState.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnUpdateState.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnUpdateState.ForeColor = System.Drawing.Color.White
        Me.btnUpdateState.Location = New System.Drawing.Point(10, 15)
        Me.btnUpdateState.Name = "btnUpdateState"
        Me.btnUpdateState.Size = New System.Drawing.Size(100, 28)
        Me.btnUpdateState.TabIndex = 3
        Me.btnUpdateState.Text = "تحديث الحالة"
        Me.btnUpdateState.UseVisualStyleBackColor = False
        '
        'btnDeleteOrder
        '
        Me.btnDeleteOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnDeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteOrder.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDeleteOrder.ForeColor = System.Drawing.Color.White
        Me.btnDeleteOrder.Location = New System.Drawing.Point(550, 12)
        Me.btnDeleteOrder.Name = "btnDeleteOrder"
        Me.btnDeleteOrder.Size = New System.Drawing.Size(100, 35)
        Me.btnDeleteOrder.TabIndex = 2
        Me.btnDeleteOrder.Text = "حذف الطلب"
        Me.btnDeleteOrder.UseVisualStyleBackColor = False
        '
        'btnEditOrder
        '
        Me.btnEditOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnEditOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditOrder.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnEditOrder.ForeColor = System.Drawing.Color.White
        Me.btnEditOrder.Location = New System.Drawing.Point(660, 12)
        Me.btnEditOrder.Name = "btnEditOrder"
        Me.btnEditOrder.Size = New System.Drawing.Size(100, 35)
        Me.btnEditOrder.TabIndex = 1
        Me.btnEditOrder.Text = "تعديل الطلب"
        Me.btnEditOrder.UseVisualStyleBackColor = False
        '
        'btnAddOrder
        '
        Me.btnAddOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddOrder.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddOrder.ForeColor = System.Drawing.Color.White
        Me.btnAddOrder.Location = New System.Drawing.Point(770, 12)
        Me.btnAddOrder.Name = "btnAddOrder"
        Me.btnAddOrder.Size = New System.Drawing.Size(120, 35)
        Me.btnAddOrder.TabIndex = 0
        Me.btnAddOrder.Text = "إضافة طلب جديد"
        Me.btnAddOrder.UseVisualStyleBackColor = False
        '
        'cmbStateUpdate
        '
        Me.cmbStateUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStateUpdate.FormattingEnabled = True
        Me.cmbStateUpdate.Items.AddRange(New Object() {"NEXT", "DESIGN", "PRINT", "POST", "DELIVER", "DONE"})
        Me.cmbStateUpdate.Location = New System.Drawing.Point(120, 16)
        Me.cmbStateUpdate.Name = "cmbStateUpdate"
        Me.cmbStateUpdate.Size = New System.Drawing.Size(120, 25)
        Me.cmbStateUpdate.TabIndex = 5
        '
        'lblChangeState
        '
        Me.lblChangeState.AutoSize = True
        Me.lblChangeState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblChangeState.Location = New System.Drawing.Point(250, 20)
        Me.lblChangeState.Name = "lblChangeState"
        Me.lblChangeState.Size = New System.Drawing.Size(68, 15)
        Me.lblChangeState.TabIndex = 6
        Me.lblChangeState.Text = "تغيير الحالة:"
        '
        'UcOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Controls.Add(Me.dgvOrders)
        Me.Controls.Add(Me.pnlActions)
        Me.Controls.Add(Me.pnlFilters)
        Me.Controls.Add(Me.pnlTopPackage)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "UcOrders"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Size = New System.Drawing.Size(900, 640)
        Me.pnlTopPackage.ResumeLayout(False)
        Me.pnlTopPackage.PerformLayout()
        Me.pnlFilters.ResumeLayout(False)
        Me.pnlFilters.PerformLayout()
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlActions.ResumeLayout(False)
        Me.pnlActions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTopPackage As Panel
    Friend WithEvents btnStartPackage As Button
    Friend WithEvents lblPackageStatus As Label
    Friend WithEvents pnlFilters As Panel
    Friend WithEvents rdoDeliver As RadioButton
    Friend WithEvents rdoPost As RadioButton
    Friend WithEvents rdoPrint As RadioButton
    Friend WithEvents rdoDesign As RadioButton
    Friend WithEvents rdoNext As RadioButton
    Friend WithEvents rdoAll As RadioButton
    Friend WithEvents dgvOrders As DataGridView
    Friend WithEvents pnlActions As Panel
    Friend WithEvents btnManageContent As Button
    Friend WithEvents btnUpdateState As Button
    Friend WithEvents btnDeleteOrder As Button
    Friend WithEvents btnEditOrder As Button
    Friend WithEvents btnAddOrder As Button
    Friend WithEvents lblChangeState As Label
    Friend WithEvents cmbStateUpdate As ComboBox
    Friend WithEvents rdoHistory As RadioButton
End Class
