<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOrderEdit
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
        Me.lblSheikh = New System.Windows.Forms.Label()
        Me.cmbSheikh = New System.Windows.Forms.ComboBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.cmbState = New System.Windows.Forms.ComboBox()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.lblPaid = New System.Windows.Forms.Label()
        Me.txtPaid = New System.Windows.Forms.TextBox()
        Me.lblRest = New System.Windows.Forms.Label()
        Me.txtRest = New System.Windows.Forms.TextBox()
        Me.lblContents = New System.Windows.Forms.Label()
        Me.txtContents = New System.Windows.Forms.TextBox()
        Me.lblDegree = New System.Windows.Forms.Label()
        Me.txtDegree = New System.Windows.Forms.TextBox()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.grpShipping = New System.Windows.Forms.GroupBox()
        Me.txtShipAddress = New System.Windows.Forms.TextBox()
        Me.lblShipAddress = New System.Windows.Forms.Label()
        Me.txtShipCity = New System.Windows.Forms.TextBox()
        Me.lblShipCity = New System.Windows.Forms.Label()
        Me.txtShipCountry = New System.Windows.Forms.TextBox()
        Me.lblShipCountry = New System.Windows.Forms.Label()
        Me.txtShipPhone = New System.Windows.Forms.TextBox()
        Me.lblShipPhone = New System.Windows.Forms.Label()
        Me.txtShipReceiver = New System.Windows.Forms.TextBox()
        Me.lblShipReceiver = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpShipping.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSheikh
        '
        Me.lblSheikh.AutoSize = True
        Me.lblSheikh.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSheikh.Location = New System.Drawing.Point(620, 20)
        Me.lblSheikh.Name = "lblSheikh"
        Me.lblSheikh.Size = New System.Drawing.Size(43, 17)
        Me.lblSheikh.TabIndex = 0
        Me.lblSheikh.Text = "الشيخ:"
        '
        'cmbSheikh
        '
        Me.cmbSheikh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSheikh.FormattingEnabled = True
        Me.cmbSheikh.Location = New System.Drawing.Point(330, 17)
        Me.cmbSheikh.Name = "cmbSheikh"
        Me.cmbSheikh.Size = New System.Drawing.Size(270, 25)
        Me.cmbSheikh.TabIndex = 1
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblState.Location = New System.Drawing.Point(260, 20)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(41, 17)
        Me.lblState.TabIndex = 2
        Me.lblState.Text = "الحالة:"
        '
        'cmbState
        '
        Me.cmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbState.FormattingEnabled = True
        Me.cmbState.Items.AddRange(New Object() {"NEXT", "DESIGN", "PRINT", "POST", "DELIVER"})
        Me.cmbState.Location = New System.Drawing.Point(20, 17)
        Me.cmbState.Name = "cmbState"
        Me.cmbState.Size = New System.Drawing.Size(220, 25)
        Me.cmbState.TabIndex = 3
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCost.Location = New System.Drawing.Point(620, 60)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(49, 17)
        Me.lblCost.TabIndex = 4
        Me.lblCost.Text = "التكلفة:"
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(470, 57)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(130, 25)
        Me.txtCost.TabIndex = 5
        Me.txtCost.Text = "0"
        '
        'lblPaid
        '
        Me.lblPaid.AutoSize = True
        Me.lblPaid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPaid.Location = New System.Drawing.Point(410, 60)
        Me.lblPaid.Name = "lblPaid"
        Me.lblPaid.Size = New System.Drawing.Size(56, 17)
        Me.lblPaid.TabIndex = 6
        Me.lblPaid.Text = "المدفوع:"
        '
        'txtPaid
        '
        Me.txtPaid.Location = New System.Drawing.Point(270, 57)
        Me.txtPaid.Name = "txtPaid"
        Me.txtPaid.Size = New System.Drawing.Size(130, 25)
        Me.txtPaid.TabIndex = 7
        Me.txtPaid.Text = "0"
        '
        'lblRest
        '
        Me.lblRest.AutoSize = True
        Me.lblRest.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRest.Location = New System.Drawing.Point(170, 60)
        Me.lblRest.Name = "lblRest"
        Me.lblRest.Size = New System.Drawing.Size(55, 17)
        Me.lblRest.TabIndex = 8
        Me.lblRest.Text = "المتبقي:"
        '
        'txtRest
        '
        Me.txtRest.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtRest.Enabled = False
        Me.txtRest.Location = New System.Drawing.Point(20, 57)
        Me.txtRest.Name = "txtRest"
        Me.txtRest.Size = New System.Drawing.Size(130, 25)
        Me.txtRest.TabIndex = 9
        Me.txtRest.Text = "0"
        '
        'lblContents
        '
        Me.lblContents.AutoSize = True
        Me.lblContents.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblContents.Location = New System.Drawing.Point(620, 100)
        Me.lblContents.Name = "lblContents"
        Me.lblContents.Size = New System.Drawing.Size(69, 17)
        Me.lblContents.TabIndex = 10
        Me.lblContents.Text = "المحتويات:"
        '
        'txtContents
        '
        Me.txtContents.Location = New System.Drawing.Point(230, 97)
        Me.txtContents.Name = "txtContents"
        Me.txtContents.Size = New System.Drawing.Size(370, 25)
        Me.txtContents.TabIndex = 11
        '
        'lblDegree
        '
        Me.lblDegree.AutoSize = True
        Me.lblDegree.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDegree.Location = New System.Drawing.Point(170, 100)
        Me.lblDegree.Name = "lblDegree"
        Me.lblDegree.Size = New System.Drawing.Size(52, 17)
        Me.lblDegree.TabIndex = 12
        Me.lblDegree.Text = "الترتيب:"
        '
        'txtDegree
        '
        Me.txtDegree.Location = New System.Drawing.Point(20, 97)
        Me.txtDegree.Name = "txtDegree"
        Me.txtDegree.Size = New System.Drawing.Size(130, 25)
        Me.txtDegree.TabIndex = 13
        Me.txtDegree.Text = "0"
        '
        'lblComment
        '
        Me.lblComment.AutoSize = True
        Me.lblComment.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblComment.Location = New System.Drawing.Point(620, 140)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(56, 17)
        Me.lblComment.TabIndex = 14
        Me.lblComment.Text = "ملاحظة:"
        '
        'txtComment
        '
        Me.txtComment.Location = New System.Drawing.Point(20, 137)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(580, 50)
        Me.txtComment.TabIndex = 15
        '
        'grpShipping
        '
        Me.grpShipping.Controls.Add(Me.txtShipAddress)
        Me.grpShipping.Controls.Add(Me.lblShipAddress)
        Me.grpShipping.Controls.Add(Me.txtShipCity)
        Me.grpShipping.Controls.Add(Me.lblShipCity)
        Me.grpShipping.Controls.Add(Me.txtShipCountry)
        Me.grpShipping.Controls.Add(Me.lblShipCountry)
        Me.grpShipping.Controls.Add(Me.txtShipPhone)
        Me.grpShipping.Controls.Add(Me.lblShipPhone)
        Me.grpShipping.Controls.Add(Me.txtShipReceiver)
        Me.grpShipping.Controls.Add(Me.lblShipReceiver)
        Me.grpShipping.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpShipping.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.grpShipping.Location = New System.Drawing.Point(20, 200)
        Me.grpShipping.Name = "grpShipping"
        Me.grpShipping.Size = New System.Drawing.Size(650, 180)
        Me.grpShipping.TabIndex = 16
        Me.grpShipping.TabStop = False
        Me.grpShipping.Text = "تفاصيل الشحن والتسليم"
        '
        'txtShipAddress
        '
        Me.txtShipAddress.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtShipAddress.Location = New System.Drawing.Point(20, 140)
        Me.txtShipAddress.Name = "txtShipAddress"
        Me.txtShipAddress.Size = New System.Drawing.Size(500, 25)
        Me.txtShipAddress.TabIndex = 9
        '
        'lblShipAddress
        '
        Me.lblShipAddress.AutoSize = True
        Me.lblShipAddress.Location = New System.Drawing.Point(540, 143)
        Me.lblShipAddress.Name = "lblShipAddress"
        Me.lblShipAddress.Size = New System.Drawing.Size(51, 17)
        Me.lblShipAddress.TabIndex = 8
        Me.lblShipAddress.Text = "العنوان:"
        '
        'txtShipCity
        '
        Me.txtShipCity.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtShipCity.Location = New System.Drawing.Point(20, 100)
        Me.txtShipCity.Name = "txtShipCity"
        Me.txtShipCity.Size = New System.Drawing.Size(180, 25)
        Me.txtShipCity.TabIndex = 7
        '
        'lblShipCity
        '
        Me.lblShipCity.AutoSize = True
        Me.lblShipCity.Location = New System.Drawing.Point(220, 103)
        Me.lblShipCity.Name = "lblShipCity"
        Me.lblShipCity.Size = New System.Drawing.Size(53, 17)
        Me.lblShipCity.TabIndex = 6
        Me.lblShipCity.Text = "المدينة:"
        '
        'txtShipCountry
        '
        Me.txtShipCountry.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtShipCountry.Location = New System.Drawing.Point(340, 100)
        Me.txtShipCountry.Name = "txtShipCountry"
        Me.txtShipCountry.Size = New System.Drawing.Size(180, 25)
        Me.txtShipCountry.TabIndex = 5
        '
        'lblShipCountry
        '
        Me.lblShipCountry.AutoSize = True
        Me.lblShipCountry.Location = New System.Drawing.Point(540, 103)
        Me.lblShipCountry.Name = "lblShipCountry"
        Me.lblShipCountry.Size = New System.Drawing.Size(43, 17)
        Me.lblShipCountry.TabIndex = 4
        Me.lblShipCountry.Text = "الدولة:"
        '
        'txtShipPhone
        '
        Me.txtShipPhone.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtShipPhone.Location = New System.Drawing.Point(20, 60)
        Me.txtShipPhone.Name = "txtShipPhone"
        Me.txtShipPhone.Size = New System.Drawing.Size(180, 25)
        Me.txtShipPhone.TabIndex = 3
        '
        'lblShipPhone
        '
        Me.lblShipPhone.AutoSize = True
        Me.lblShipPhone.Location = New System.Drawing.Point(220, 63)
        Me.lblShipPhone.Name = "lblShipPhone"
        Me.lblShipPhone.Size = New System.Drawing.Size(73, 17)
        Me.lblShipPhone.TabIndex = 2
        Me.lblShipPhone.Text = "رقم الهاتف:"
        '
        'txtShipReceiver
        '
        Me.txtShipReceiver.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtShipReceiver.Location = New System.Drawing.Point(340, 60)
        Me.txtShipReceiver.Name = "txtShipReceiver"
        Me.txtShipReceiver.Size = New System.Drawing.Size(180, 25)
        Me.txtShipReceiver.TabIndex = 1
        '
        'lblShipReceiver
        '
        Me.lblShipReceiver.AutoSize = True
        Me.lblShipReceiver.Location = New System.Drawing.Point(540, 63)
        Me.lblShipReceiver.Name = "lblShipReceiver"
        Me.lblShipReceiver.Size = New System.Drawing.Size(89, 17)
        Me.lblShipReceiver.TabIndex = 0
        Me.lblShipReceiver.Text = "اسم المستلم:"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(360, 400)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 35)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "حفظ الطلب"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(220, 400)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 35)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "إلغاء"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'FormOrderEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(700, 460)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grpShipping)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.lblComment)
        Me.Controls.Add(Me.txtDegree)
        Me.Controls.Add(Me.lblDegree)
        Me.Controls.Add(Me.txtContents)
        Me.Controls.Add(Me.lblContents)
        Me.Controls.Add(Me.txtRest)
        Me.Controls.Add(Me.lblRest)
        Me.Controls.Add(Me.txtPaid)
        Me.Controls.Add(Me.lblPaid)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.cmbState)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.cmbSheikh)
        Me.Controls.Add(Me.lblSheikh)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormOrderEdit"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "بيانات الطلب"
        Me.grpShipping.ResumeLayout(False)
        Me.grpShipping.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSheikh As Label
    Friend WithEvents cmbSheikh As ComboBox
    Friend WithEvents lblState As Label
    Friend WithEvents cmbState As ComboBox
    Friend WithEvents lblCost As Label
    Friend WithEvents txtCost As TextBox
    Friend WithEvents lblPaid As Label
    Friend WithEvents txtPaid As TextBox
    Friend WithEvents lblRest As Label
    Friend WithEvents txtRest As TextBox
    Friend WithEvents lblContents As Label
    Friend WithEvents txtContents As TextBox
    Friend WithEvents lblDegree As Label
    Friend WithEvents txtDegree As TextBox
    Friend WithEvents lblComment As Label
    Friend WithEvents txtComment As TextBox
    Friend WithEvents grpShipping As GroupBox
    Friend WithEvents txtShipAddress As TextBox
    Friend WithEvents lblShipAddress As Label
    Friend WithEvents txtShipCity As TextBox
    Friend WithEvents lblShipCity As Label
    Friend WithEvents txtShipCountry As TextBox
    Friend WithEvents lblShipCountry As Label
    Friend WithEvents txtShipPhone As TextBox
    Friend WithEvents lblShipPhone As Label
    Friend WithEvents txtShipReceiver As TextBox
    Friend WithEvents lblShipReceiver As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
