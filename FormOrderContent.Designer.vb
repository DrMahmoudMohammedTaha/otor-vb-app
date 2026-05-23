<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOrderContent
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.tabList = New System.Windows.Forms.TabPage()
        Me.dgvItems = New System.Windows.Forms.DataGridView()
        Me.pnlItemActions = New System.Windows.Forms.Panel()
        Me.btnDeleteItem = New System.Windows.Forms.Button()
        Me.btnEditItem = New System.Windows.Forms.Button()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.tabBulk = New System.Windows.Forms.TabPage()
        Me.btnProcessBulk = New System.Windows.Forms.Button()
        Me.lblBulkHelp = New System.Windows.Forms.Label()
        Me.txtBulkText = New System.Windows.Forms.TextBox()
        Me.tabMain.SuspendLayout()
        Me.tabList.SuspendLayout()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlItemActions.SuspendLayout()
        Me.tabBulk.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(830, 45)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "إدارة تفاصيل الشهادات للطلب"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.tabList)
        Me.tabMain.Controls.Add(Me.tabBulk)
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.Location = New System.Drawing.Point(0, 45)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.RightToLeftLayout = True
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(830, 485)
        Me.tabMain.TabIndex = 1
        '
        'tabList
        '
        Me.tabList.Controls.Add(Me.dgvItems)
        Me.tabList.Controls.Add(Me.pnlItemActions)
        Me.tabList.Location = New System.Drawing.Point(4, 26)
        Me.tabList.Name = "tabList"
        Me.tabList.Padding = New System.Windows.Forms.Padding(3)
        Me.tabList.Size = New System.Drawing.Size(822, 455)
        Me.tabList.TabIndex = 0
        Me.tabList.Text = "قائمة الشهادات"
        Me.tabList.UseVisualStyleBackColor = True
        '
        'dgvItems
        '
        Me.dgvItems.AllowUserToAddRows = False
        Me.dgvItems.AllowUserToDeleteRows = False
        Me.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvItems.BackgroundColor = System.Drawing.Color.White
        Me.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvItems.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvItems.Location = New System.Drawing.Point(3, 3)
        Me.dgvItems.MultiSelect = False
        Me.dgvItems.Name = "dgvItems"
        Me.dgvItems.ReadOnly = True
        Me.dgvItems.RowHeadersVisible = False
        Me.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItems.Size = New System.Drawing.Size(816, 399)
        Me.dgvItems.TabIndex = 0
        '
        'pnlItemActions
        '
        Me.pnlItemActions.Controls.Add(Me.btnDeleteItem)
        Me.pnlItemActions.Controls.Add(Me.btnEditItem)
        Me.pnlItemActions.Controls.Add(Me.btnAddItem)
        Me.pnlItemActions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlItemActions.Location = New System.Drawing.Point(3, 402)
        Me.pnlItemActions.Name = "pnlItemActions"
        Me.pnlItemActions.Size = New System.Drawing.Size(816, 50)
        Me.pnlItemActions.TabIndex = 1
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDeleteItem.ForeColor = System.Drawing.Color.White
        Me.btnDeleteItem.Location = New System.Drawing.Point(450, 8)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(100, 35)
        Me.btnDeleteItem.TabIndex = 2
        Me.btnDeleteItem.Text = "حذف"
        Me.btnDeleteItem.UseVisualStyleBackColor = False
        '
        'btnEditItem
        '
        Me.btnEditItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnEditItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnEditItem.ForeColor = System.Drawing.Color.White
        Me.btnEditItem.Location = New System.Drawing.Point(560, 8)
        Me.btnEditItem.Name = "btnEditItem"
        Me.btnEditItem.Size = New System.Drawing.Size(100, 35)
        Me.btnEditItem.TabIndex = 1
        Me.btnEditItem.Text = "تعديل"
        Me.btnEditItem.UseVisualStyleBackColor = False
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAddItem.ForeColor = System.Drawing.Color.White
        Me.btnAddItem.Location = New System.Drawing.Point(670, 8)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(120, 35)
        Me.btnAddItem.TabIndex = 0
        Me.btnAddItem.Text = "إضافة طالب"
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'tabBulk
        '
        Me.tabBulk.Controls.Add(Me.btnProcessBulk)
        Me.tabBulk.Controls.Add(Me.lblBulkHelp)
        Me.tabBulk.Controls.Add(Me.txtBulkText)
        Me.tabBulk.Location = New System.Drawing.Point(4, 24)
        Me.tabBulk.Name = "tabBulk"
        Me.tabBulk.Padding = New System.Windows.Forms.Padding(10)
        Me.tabBulk.Size = New System.Drawing.Size(822, 457)
        Me.tabBulk.TabIndex = 1
        Me.tabBulk.Text = "إدخال جماعي سريع"
        Me.tabBulk.UseVisualStyleBackColor = True
        '
        'btnProcessBulk
        '
        Me.btnProcessBulk.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnProcessBulk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcessBulk.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnProcessBulk.ForeColor = System.Drawing.Color.White
        Me.btnProcessBulk.Location = New System.Drawing.Point(20, 390)
        Me.btnProcessBulk.Name = "btnProcessBulk"
        Me.btnProcessBulk.Size = New System.Drawing.Size(200, 45)
        Me.btnProcessBulk.TabIndex = 2
        Me.btnProcessBulk.Text = "تنفيذ الاستيراد الجماعي"
        Me.btnProcessBulk.UseVisualStyleBackColor = False
        '
        'lblBulkHelp
        '
        Me.lblBulkHelp.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblBulkHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblBulkHelp.Location = New System.Drawing.Point(240, 385)
        Me.lblBulkHelp.Name = "lblBulkHelp"
        Me.lblBulkHelp.Size = New System.Drawing.Size(560, 60)
        Me.lblBulkHelp.TabIndex = 1
        Me.lblBulkHelp.Text = "طريقة الإدخال: الصق قائمة الطلاب بحيث يكون كل طالب في سطر مستقل." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "تنسيق السطر: اسم" & _
    " الطالب - الجنس - معلومات إضافية - الرواية" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "مثال: محمد أحمد - ذكر - من محافظة القاهرة" & _
    " - حفص عن عاصم"
        '
        'txtBulkText
        '
        Me.txtBulkText.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtBulkText.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBulkText.Location = New System.Drawing.Point(10, 10)
        Me.txtBulkText.Multiline = True
        Me.txtBulkText.Name = "txtBulkText"
        Me.txtBulkText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtBulkText.Size = New System.Drawing.Size(802, 360)
        Me.txtBulkText.TabIndex = 0
        '
        'FormOrderContent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(830, 530)
        Me.Controls.Add(Me.tabMain)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormOrderContent"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "إدارة الشهادات"
        Me.tabMain.ResumeLayout(False)
        Me.tabList.ResumeLayout(False)
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlItemActions.ResumeLayout(False)
        Me.tabBulk.ResumeLayout(False)
        Me.tabBulk.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents tabMain As TabControl
    Friend WithEvents tabList As TabPage
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents pnlItemActions As Panel
    Friend WithEvents btnDeleteItem As Button
    Friend WithEvents btnEditItem As Button
    Friend WithEvents btnAddItem As Button
    Friend WithEvents tabBulk As TabPage
    Friend WithEvents btnProcessBulk As Button
    Friend WithEvents lblBulkHelp As Label
    Friend WithEvents txtBulkText As TextBox
End Class
