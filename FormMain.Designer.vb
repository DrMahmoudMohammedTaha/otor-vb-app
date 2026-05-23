<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.lblAppTitle = New System.Windows.Forms.Label()
        Me.btnOrders = New System.Windows.Forms.Button()
        Me.btnSheikhs = New System.Windows.Forms.Button()
        Me.btnExpenses = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.lblConnectionStatus = New System.Windows.Forms.Label()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.lblAppTitle)
        Me.pnlSidebar.Controls.Add(Me.btnOrders)
        Me.pnlSidebar.Controls.Add(Me.btnSheikhs)
        Me.pnlSidebar.Controls.Add(Me.btnExpenses)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlSidebar.Location = New System.Drawing.Point(900, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(200, 700)
        Me.pnlSidebar.TabIndex = 0
        '
        'lblAppTitle
        '
        Me.lblAppTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAppTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lblAppTitle.Location = New System.Drawing.Point(0, 20)
        Me.lblAppTitle.Name = "lblAppTitle"
        Me.lblAppTitle.Size = New System.Drawing.Size(200, 45)
        Me.lblAppTitle.TabIndex = 0
        Me.lblAppTitle.Text = "عطور القرآن"
        Me.lblAppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnOrders
        '
        Me.btnOrders.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnOrders.FlatAppearance.BorderSize = 0
        Me.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrders.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnOrders.ForeColor = System.Drawing.Color.White
        Me.btnOrders.Location = New System.Drawing.Point(0, 100)
        Me.btnOrders.Name = "btnOrders"
        Me.btnOrders.Size = New System.Drawing.Size(200, 50)
        Me.btnOrders.TabIndex = 1
        Me.btnOrders.Text = "الطلبات والشهادات"
        Me.btnOrders.UseVisualStyleBackColor = False
        '
        'btnSheikhs
        '
        Me.btnSheikhs.BackColor = System.Drawing.Color.Transparent
        Me.btnSheikhs.FlatAppearance.BorderSize = 0
        Me.btnSheikhs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSheikhs.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSheikhs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnSheikhs.Location = New System.Drawing.Point(0, 160)
        Me.btnSheikhs.Name = "btnSheikhs"
        Me.btnSheikhs.Size = New System.Drawing.Size(200, 50)
        Me.btnSheikhs.TabIndex = 2
        Me.btnSheikhs.Text = "شيوخ المقارئ"
        Me.btnSheikhs.UseVisualStyleBackColor = True
        '
        'btnExpenses
        '
        Me.btnExpenses.BackColor = System.Drawing.Color.Transparent
        Me.btnExpenses.FlatAppearance.BorderSize = 0
        Me.btnExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExpenses.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnExpenses.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnExpenses.Location = New System.Drawing.Point(0, 220)
        Me.btnExpenses.Name = "btnExpenses"
        Me.btnExpenses.Size = New System.Drawing.Size(200, 50)
        Me.btnExpenses.TabIndex = 3
        Me.btnExpenses.Text = "المصروفات والمالية"
        Me.btnExpenses.UseVisualStyleBackColor = True
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.lblConnectionStatus)
        Me.pnlHeader.Controls.Add(Me.lblHeaderTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(900, 60)
        Me.pnlHeader.TabIndex = 1
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.AutoSize = True
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lblHeaderTitle.Location = New System.Drawing.Point(20, 18)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(153, 25)
        Me.lblHeaderTitle.TabIndex = 0
        Me.lblHeaderTitle.Text = "إدارة طلبات الشيخ"
        '
        'pnlContainer
        '
        Me.pnlContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContainer.Location = New System.Drawing.Point(0, 60)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(900, 640)
        Me.pnlContainer.TabIndex = 2
        '
        'lblConnectionStatus
        '
        Me.lblConnectionStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblConnectionStatus.ForeColor = System.Drawing.Color.Green
        Me.lblConnectionStatus.Location = New System.Drawing.Point(600, 20)
        Me.lblConnectionStatus.Name = "lblConnectionStatus"
        Me.lblConnectionStatus.Size = New System.Drawing.Size(280, 23)
        Me.lblConnectionStatus.TabIndex = 1
        Me.lblConnectionStatus.Text = "متصل بقاعدة البيانات Neon PostgreSQL"
        Me.lblConnectionStatus.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 700)
        Me.Controls.Add(Me.pnlContainer)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "FormMain"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "عطور القرآن - نظام إدارة الإجازات والشهادات"
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents lblAppTitle As Label
    Friend WithEvents btnOrders As Button
    Friend WithEvents btnSheikhs As Button
    Friend WithEvents btnExpenses As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents pnlContainer As Panel
    Friend WithEvents lblConnectionStatus As Label
End Class
