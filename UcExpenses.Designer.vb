<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcExpenses
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.dgvExpenses = New System.Windows.Forms.DataGridView()
        Me.lblExpensesHeader = New System.Windows.Forms.Label()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.grpCategories = New System.Windows.Forms.GroupBox()
        Me.dgvCategories = New System.Windows.Forms.DataGridView()
        Me.grpAddExpense = New System.Windows.Forms.GroupBox()
        Me.btnSaveExpense = New System.Windows.Forms.Button()
        Me.txtExpenseComment = New System.Windows.Forms.TextBox()
        Me.lblExpenseComment = New System.Windows.Forms.Label()
        Me.cmbExpenseCategory = New System.Windows.Forms.ComboBox()
        Me.lblExpenseCategory = New System.Windows.Forms.Label()
        Me.txtExpenseAmount = New System.Windows.Forms.TextBox()
        Me.lblExpenseAmount = New System.Windows.Forms.Label()
        Me.txtExpenseName = New System.Windows.Forms.TextBox()
        Me.lblExpenseName = New System.Windows.Forms.Label()
        Me.pnlLeft.SuspendLayout()
        CType(Me.dgvExpenses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRight.SuspendLayout()
        Me.grpCategories.SuspendLayout()
        CType(Me.dgvCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAddExpense.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlLeft
        '
        Me.pnlLeft.Controls.Add(Me.dgvExpenses)
        Me.pnlLeft.Controls.Add(Me.lblExpensesHeader)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlLeft.Size = New System.Drawing.Size(540, 640)
        Me.pnlLeft.TabIndex = 0
        '
        'dgvExpenses
        '
        Me.dgvExpenses.AllowUserToAddRows = False
        Me.dgvExpenses.AllowUserToDeleteRows = False
        Me.dgvExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvExpenses.BackgroundColor = System.Drawing.Color.White
        Me.dgvExpenses.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvExpenses.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvExpenses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvExpenses.Location = New System.Drawing.Point(10, 45)
        Me.dgvExpenses.MultiSelect = False
        Me.dgvExpenses.Name = "dgvExpenses"
        Me.dgvExpenses.ReadOnly = True
        Me.dgvExpenses.RowHeadersVisible = False
        Me.dgvExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvExpenses.Size = New System.Drawing.Size(520, 585)
        Me.dgvExpenses.TabIndex = 1
        '
        'lblExpensesHeader
        '
        Me.lblExpensesHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblExpensesHeader.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblExpensesHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lblExpensesHeader.Location = New System.Drawing.Point(10, 10)
        Me.lblExpensesHeader.Name = "lblExpensesHeader"
        Me.lblExpensesHeader.Size = New System.Drawing.Size(520, 35)
        Me.lblExpensesHeader.TabIndex = 0
        Me.lblExpensesHeader.Text = "قائمة المصروفات السابقة"
        Me.lblExpensesHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlRight
        '
        Me.pnlRight.BackColor = System.Drawing.Color.White
        Me.pnlRight.Controls.Add(Me.grpCategories)
        Me.pnlRight.Controls.Add(Me.grpAddExpense)
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlRight.Location = New System.Drawing.Point(540, 0)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlRight.Size = New System.Drawing.Size(360, 640)
        Me.pnlRight.TabIndex = 1
        '
        'grpCategories
        '
        Me.grpCategories.Controls.Add(Me.dgvCategories)
        Me.grpCategories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpCategories.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpCategories.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.grpCategories.Location = New System.Drawing.Point(10, 300)
        Me.grpCategories.Name = "grpCategories"
        Me.grpCategories.Padding = New System.Windows.Forms.Padding(10)
        Me.grpCategories.Size = New System.Drawing.Size(340, 330)
        Me.grpCategories.TabIndex = 1
        Me.grpCategories.TabStop = False
        Me.grpCategories.Text = "إجمالي المصروفات حسب التصنيف"
        '
        'dgvCategories
        '
        Me.dgvCategories.AllowUserToAddRows = False
        Me.dgvCategories.AllowUserToDeleteRows = False
        Me.dgvCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCategories.BackgroundColor = System.Drawing.Color.White
        Me.dgvCategories.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(32, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCategories.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCategories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCategories.Location = New System.Drawing.Point(10, 28)
        Me.dgvCategories.MultiSelect = False
        Me.dgvCategories.Name = "dgvCategories"
        Me.dgvCategories.ReadOnly = True
        Me.dgvCategories.RowHeadersVisible = False
        Me.dgvCategories.Size = New System.Drawing.Size(320, 292)
        Me.dgvCategories.TabIndex = 0
        '
        'grpAddExpense
        '
        Me.grpAddExpense.Controls.Add(Me.btnSaveExpense)
        Me.grpAddExpense.Controls.Add(Me.txtExpenseComment)
        Me.grpAddExpense.Controls.Add(Me.lblExpenseComment)
        Me.grpAddExpense.Controls.Add(Me.cmbExpenseCategory)
        Me.grpAddExpense.Controls.Add(Me.lblExpenseCategory)
        Me.grpAddExpense.Controls.Add(Me.txtExpenseAmount)
        Me.grpAddExpense.Controls.Add(Me.lblExpenseAmount)
        Me.grpAddExpense.Controls.Add(Me.txtExpenseName)
        Me.grpAddExpense.Controls.Add(Me.lblExpenseName)
        Me.grpAddExpense.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpAddExpense.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpAddExpense.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.grpAddExpense.Location = New System.Drawing.Point(10, 10)
        Me.grpAddExpense.Name = "grpAddExpense"
        Me.grpAddExpense.Size = New System.Drawing.Size(340, 290)
        Me.grpAddExpense.TabIndex = 0
        Me.grpAddExpense.TabStop = False
        Me.grpAddExpense.Text = "تسجيل مصروف جديد"
        '
        'btnSaveExpense
        '
        Me.btnSaveExpense.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnSaveExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveExpense.ForeColor = System.Drawing.Color.White
        Me.btnSaveExpense.Location = New System.Drawing.Point(20, 240)
        Me.btnSaveExpense.Name = "btnSaveExpense"
        Me.btnSaveExpense.Size = New System.Drawing.Size(180, 35)
        Me.btnSaveExpense.TabIndex = 8
        Me.btnSaveExpense.Text = "حفظ وإدخال المصروف"
        Me.btnSaveExpense.UseVisualStyleBackColor = False
        '
        'txtExpenseComment
        '
        Me.txtExpenseComment.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtExpenseComment.Location = New System.Drawing.Point(20, 160)
        Me.txtExpenseComment.Multiline = True
        Me.txtExpenseComment.Name = "txtExpenseComment"
        Me.txtExpenseComment.Size = New System.Drawing.Size(180, 60)
        Me.txtExpenseComment.TabIndex = 7
        '
        'lblExpenseComment
        '
        Me.lblExpenseComment.AutoSize = True
        Me.lblExpenseComment.Location = New System.Drawing.Point(220, 163)
        Me.lblExpenseComment.Name = "lblExpenseComment"
        Me.lblExpenseComment.Size = New System.Drawing.Size(56, 17)
        Me.lblExpenseComment.TabIndex = 6
        Me.lblExpenseComment.Text = "ملاحظة:"
        '
        'cmbExpenseCategory
        '
        Me.cmbExpenseCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExpenseCategory.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbExpenseCategory.FormattingEnabled = True
        Me.cmbExpenseCategory.Items.AddRange(New Object() {"مطبوعات", "شحن وتوصيل", "أوراق ومستندات", "رواتب ومكافآت", "عام وأخرى"})
        Me.cmbExpenseCategory.Location = New System.Drawing.Point(20, 120)
        Me.cmbExpenseCategory.Name = "cmbExpenseCategory"
        Me.cmbExpenseCategory.Size = New System.Drawing.Size(180, 25)
        Me.cmbExpenseCategory.TabIndex = 5
        '
        'lblExpenseCategory
        '
        Me.lblExpenseCategory.AutoSize = True
        Me.lblExpenseCategory.Location = New System.Drawing.Point(220, 123)
        Me.lblExpenseCategory.Name = "lblExpenseCategory"
        Me.lblExpenseCategory.Size = New System.Drawing.Size(58, 17)
        Me.lblExpenseCategory.TabIndex = 4
        Me.lblExpenseCategory.Text = "التصنيف:"
        '
        'txtExpenseAmount
        '
        Me.txtExpenseAmount.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtExpenseAmount.Location = New System.Drawing.Point(20, 80)
        Me.txtExpenseAmount.Name = "txtExpenseAmount"
        Me.txtExpenseAmount.Size = New System.Drawing.Size(180, 25)
        Me.txtExpenseAmount.TabIndex = 3
        Me.txtExpenseAmount.Text = "0"
        '
        'lblExpenseAmount
        '
        Me.lblExpenseAmount.AutoSize = True
        Me.lblExpenseAmount.Location = New System.Drawing.Point(220, 83)
        Me.lblExpenseAmount.Name = "lblExpenseAmount"
        Me.lblExpenseAmount.Size = New System.Drawing.Size(44, 17)
        Me.lblExpenseAmount.TabIndex = 2
        Me.lblExpenseAmount.Text = "المبلغ:"
        '
        'txtExpenseName
        '
        Me.txtExpenseName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtExpenseName.Location = New System.Drawing.Point(20, 40)
        Me.txtExpenseName.Name = "txtExpenseName"
        Me.txtExpenseName.Size = New System.Drawing.Size(180, 25)
        Me.txtExpenseName.TabIndex = 1
        '
        'lblExpenseName
        '
        Me.lblExpenseName.AutoSize = True
        Me.lblExpenseName.Location = New System.Drawing.Point(220, 43)
        Me.lblExpenseName.Name = "lblExpenseName"
        Me.lblExpenseName.Size = New System.Drawing.Size(95, 17)
        Me.lblExpenseName.TabIndex = 0
        Me.lblExpenseName.Text = "اسم المصروف:"
        '
        'UcExpenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlRight)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "UcExpenses"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Size = New System.Drawing.Size(900, 640)
        Me.pnlLeft.ResumeLayout(False)
        CType(Me.dgvExpenses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRight.ResumeLayout(False)
        Me.grpCategories.ResumeLayout(False)
        CType(Me.dgvCategories, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAddExpense.ResumeLayout(False)
        Me.grpAddExpense.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlLeft As Panel
    Friend WithEvents dgvExpenses As DataGridView
    Friend WithEvents lblExpensesHeader As Label
    Friend WithEvents pnlRight As Panel
    Friend WithEvents grpCategories As GroupBox
    Friend WithEvents dgvCategories As DataGridView
    Friend WithEvents grpAddExpense As GroupBox
    Friend WithEvents btnSaveExpense As Button
    Friend WithEvents txtExpenseComment As TextBox
    Friend WithEvents lblExpenseComment As Label
    Friend WithEvents cmbExpenseCategory As ComboBox
    Friend WithEvents lblExpenseCategory As Label
    Friend WithEvents txtExpenseAmount As TextBox
    Friend WithEvents lblExpenseAmount As Label
    Friend WithEvents txtExpenseName As TextBox
    Friend WithEvents lblExpenseName As Label
End Class
