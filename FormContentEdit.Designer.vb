<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormContentEdit
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
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.lblStudentGender = New System.Windows.Forms.Label()
        Me.cmbStudentGender = New System.Windows.Forms.ComboBox()
        Me.lblStudentInfo = New System.Windows.Forms.Label()
        Me.txtStudentInfo = New System.Windows.Forms.TextBox()
        Me.lblQeraa = New System.Windows.Forms.Label()
        Me.txtQeraa = New System.Windows.Forms.TextBox()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblStudentName.Location = New System.Drawing.Point(360, 20)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(81, 17)
        Me.lblStudentName.TabIndex = 0
        Me.lblStudentName.Text = "اسم الطالب:"
        '
        'txtStudentName
        '
        Me.txtStudentName.Location = New System.Drawing.Point(20, 17)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(320, 25)
        Me.txtStudentName.TabIndex = 1
        '
        'lblStudentGender
        '
        Me.lblStudentGender.AutoSize = True
        Me.lblStudentGender.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblStudentGender.Location = New System.Drawing.Point(360, 60)
        Me.lblStudentGender.Name = "lblStudentGender"
        Me.lblStudentGender.Size = New System.Drawing.Size(49, 17)
        Me.lblStudentGender.TabIndex = 2
        Me.lblStudentGender.Text = "الجنس:"
        '
        'cmbStudentGender
        '
        Me.cmbStudentGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStudentGender.FormattingEnabled = True
        Me.cmbStudentGender.Items.AddRange(New Object() {"ذكر", "أنثى", "معلم", "معلمة"})
        Me.cmbStudentGender.Location = New System.Drawing.Point(20, 57)
        Me.cmbStudentGender.Name = "cmbStudentGender"
        Me.cmbStudentGender.Size = New System.Drawing.Size(320, 25)
        Me.cmbStudentGender.TabIndex = 3
        '
        'lblStudentInfo
        '
        Me.lblStudentInfo.AutoSize = True
        Me.lblStudentInfo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblStudentInfo.Location = New System.Drawing.Point(360, 100)
        Me.lblStudentInfo.Name = "lblStudentInfo"
        Me.lblStudentInfo.Size = New System.Drawing.Size(77, 17)
        Me.lblStudentInfo.TabIndex = 4
        Me.lblStudentInfo.Text = "بيانات السند:"
        '
        'txtStudentInfo
        '
        Me.txtStudentInfo.Location = New System.Drawing.Point(20, 97)
        Me.txtStudentInfo.Name = "txtStudentInfo"
        Me.txtStudentInfo.Size = New System.Drawing.Size(320, 25)
        Me.txtStudentInfo.TabIndex = 5
        '
        'lblQeraa
        '
        Me.lblQeraa.AutoSize = True
        Me.lblQeraa.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblQeraa.Location = New System.Drawing.Point(360, 140)
        Me.lblQeraa.Name = "lblQeraa"
        Me.lblQeraa.Size = New System.Drawing.Size(98, 17)
        Me.lblQeraa.TabIndex = 6
        Me.lblQeraa.Text = "القراءة / الرواية:"
        '
        'txtQeraa
        '
        Me.txtQeraa.Location = New System.Drawing.Point(20, 137)
        Me.txtQeraa.Name = "txtQeraa"
        Me.txtQeraa.Size = New System.Drawing.Size(320, 25)
        Me.txtQeraa.TabIndex = 7
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCost.Location = New System.Drawing.Point(360, 180)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(49, 17)
        Me.lblCost.TabIndex = 8
        Me.lblCost.Text = "التكلفة:"
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(20, 177)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(320, 25)
        Me.txtCost.TabIndex = 9
        Me.txtCost.Text = "0"
        '
        'lblComment
        '
        Me.lblComment.AutoSize = True
        Me.lblComment.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblComment.Location = New System.Drawing.Point(360, 220)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(56, 17)
        Me.lblComment.TabIndex = 10
        Me.lblComment.Text = "ملاحظة:"
        '
        'txtComment
        '
        Me.txtComment.Location = New System.Drawing.Point(20, 217)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(320, 45)
        Me.txtComment.TabIndex = 11
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblType.Location = New System.Drawing.Point(360, 275)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(39, 17)
        Me.lblType.TabIndex = 12
        Me.lblType.Text = "النوع:"
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"EJAZA", "OTHER"})
        Me.cmbType.Location = New System.Drawing.Point(20, 272)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(320, 25)
        Me.cmbType.TabIndex = 13
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(220, 320)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 35)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "حفظ"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(90, 320)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 35)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "إلغاء"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'FormContentEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(460, 380)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.lblComment)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.txtQeraa)
        Me.Controls.Add(Me.lblQeraa)
        Me.Controls.Add(Me.txtStudentInfo)
        Me.Controls.Add(Me.lblStudentInfo)
        Me.Controls.Add(Me.cmbStudentGender)
        Me.Controls.Add(Me.lblStudentGender)
        Me.Controls.Add(Me.txtStudentName)
        Me.Controls.Add(Me.lblStudentName)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormContentEdit"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "بيانات الشهادة"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStudentName As Label
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents lblStudentGender As Label
    Friend WithEvents cmbStudentGender As ComboBox
    Friend WithEvents lblStudentInfo As Label
    Friend WithEvents txtStudentInfo As TextBox
    Friend WithEvents lblQeraa As Label
    Friend WithEvents txtQeraa As TextBox
    Friend WithEvents lblCost As Label
    Friend WithEvents txtCost As TextBox
    Friend WithEvents lblComment As Label
    Friend WithEvents txtComment As TextBox
    Friend WithEvents lblType As Label
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
