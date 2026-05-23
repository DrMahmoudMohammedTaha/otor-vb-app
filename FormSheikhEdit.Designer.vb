<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSheikhEdit
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.rdoMale = New System.Windows.Forms.RadioButton()
        Me.rdoFemale = New System.Windows.Forms.RadioButton()
        Me.lblReceiverName = New System.Windows.Forms.Label()
        Me.txtReceiverName = New System.Windows.Forms.TextBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(380, 20)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(81, 17)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "الاسم الكامل:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(20, 17)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(340, 25)
        Me.txtName.TabIndex = 1
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPhone.Location = New System.Drawing.Point(380, 60)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(73, 17)
        Me.lblPhone.TabIndex = 2
        Me.lblPhone.Text = "رقم الهاتف:"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(20, 57)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(340, 25)
        Me.txtPhone.TabIndex = 3
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCountry.Location = New System.Drawing.Point(380, 100)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(43, 17)
        Me.lblCountry.TabIndex = 4
        Me.lblCountry.Text = "الدولة:"
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(20, 97)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(340, 25)
        Me.txtCountry.TabIndex = 5
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCity.Location = New System.Drawing.Point(380, 140)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(53, 17)
        Me.lblCity.TabIndex = 6
        Me.lblCity.Text = "المدينة:"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(20, 137)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(340, 25)
        Me.txtCity.TabIndex = 7
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAddress.Location = New System.Drawing.Point(380, 180)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(51, 17)
        Me.lblAddress.TabIndex = 8
        Me.lblAddress.Text = "العنوان:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(20, 177)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(340, 25)
        Me.txtAddress.TabIndex = 9
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGender.Location = New System.Drawing.Point(380, 220)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(49, 17)
        Me.lblGender.TabIndex = 10
        Me.lblGender.Text = "الجنس:"
        '
        'rdoMale
        '
        Me.rdoMale.AutoSize = True
        Me.rdoMale.Checked = True
        Me.rdoMale.Location = New System.Drawing.Point(290, 218)
        Me.rdoMale.Name = "rdoMale"
        Me.rdoMale.Size = New System.Drawing.Size(53, 21)
        Me.rdoMale.TabIndex = 11
        Me.rdoMale.TabStop = True
        Me.rdoMale.Text = "معلم"
        Me.rdoMale.UseVisualStyleBackColor = True
        '
        'rdoFemale
        '
        Me.rdoFemale.AutoSize = True
        Me.rdoFemale.Location = New System.Drawing.Point(200, 218)
        Me.rdoFemale.Name = "rdoFemale"
        Me.rdoFemale.Size = New System.Drawing.Size(57, 21)
        Me.rdoFemale.TabIndex = 12
        Me.rdoFemale.Text = "معلمة"
        Me.rdoFemale.UseVisualStyleBackColor = True
        '
        'lblReceiverName
        '
        Me.lblReceiverName.AutoSize = True
        Me.lblReceiverName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblReceiverName.Location = New System.Drawing.Point(380, 260)
        Me.lblReceiverName.Name = "lblReceiverName"
        Me.lblReceiverName.Size = New System.Drawing.Size(89, 17)
        Me.lblReceiverName.TabIndex = 13
        Me.lblReceiverName.Text = "اسم المستلم:"
        '
        'txtReceiverName
        '
        Me.txtReceiverName.Location = New System.Drawing.Point(20, 257)
        Me.txtReceiverName.Name = "txtReceiverName"
        Me.txtReceiverName.Size = New System.Drawing.Size(340, 25)
        Me.txtReceiverName.TabIndex = 14
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblInfo.Location = New System.Drawing.Point(380, 300)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(65, 17)
        Me.lblInfo.TabIndex = 15
        Me.lblInfo.Text = "معلومات:"
        '
        'txtInfo
        '
        Me.txtInfo.Location = New System.Drawing.Point(20, 297)
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.Size = New System.Drawing.Size(340, 60)
        Me.txtInfo.TabIndex = 16
        '
        'lblComment
        '
        Me.lblComment.AutoSize = True
        Me.lblComment.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblComment.Location = New System.Drawing.Point(380, 370)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(56, 17)
        Me.lblComment.TabIndex = 17
        Me.lblComment.Text = "ملاحظة:"
        '
        'txtComment
        '
        Me.txtComment.Location = New System.Drawing.Point(20, 367)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(340, 60)
        Me.txtComment.TabIndex = 18
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(240, 445)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 35)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "حفظ"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(100, 445)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 35)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "إلغاء"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'FormSheikhEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(480, 500)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.lblComment)
        Me.Controls.Add(Me.txtInfo)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.txtReceiverName)
        Me.Controls.Add(Me.lblReceiverName)
        Me.Controls.Add(Me.rdoFemale)
        Me.Controls.Add(Me.rdoMale)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.lblCountry)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormSheikhEdit"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "بيانات الشيخ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblCountry As Label
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents lblCity As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents rdoMale As RadioButton
    Friend WithEvents rdoFemale As RadioButton
    Friend WithEvents lblReceiverName As Label
    Friend WithEvents txtReceiverName As TextBox
    Friend WithEvents lblInfo As Label
    Friend WithEvents txtInfo As TextBox
    Friend WithEvents lblComment As Label
    Friend WithEvents txtComment As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
