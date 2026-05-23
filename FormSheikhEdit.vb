Imports P_OtorVB.Models

Public Class FormSheikhEdit
    Private editSheikh As Sheikh = Nothing
    Private isEditMode As Boolean = False

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        isEditMode = False
        Me.Text = "إضافة شيخ جديد"
    End Sub

    Public Sub New(sheikhToEdit As Sheikh)
        ' This call is required by the designer.
        InitializeComponent()
        editSheikh = sheikhToEdit
        isEditMode = True
        Me.Text = "تعديل بيانات الشيخ"
    End Sub

    Private Sub FormSheikhEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isEditMode AndAlso editSheikh IsNot Nothing Then
            txtName.Text = editSheikh.name
            txtPhone.Text = editSheikh.phone
            txtCountry.Text = editSheikh.country
            txtCity.Text = editSheikh.city
            txtAddress.Text = editSheikh.address
            txtReceiverName.Text = editSheikh.receiver_name
            txtInfo.Text = editSheikh.info
            txtComment.Text = editSheikh.comment
            
            If editSheikh.gender Then
                rdoMale.Checked = True
            Else
                rdoFemale.Checked = True
            End If
        End If
    End Sub

    Private Async Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sheikhName = txtName.Text.Trim()
        If String.IsNullOrEmpty(sheikhName) Then
            MessageBox.Show("يرجى إدخال اسم الشيخ.", "حقل مطلوب", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim target As Sheikh = If(isEditMode, editSheikh, New Sheikh())
        target.name = sheikhName
        target.phone = txtPhone.Text.Trim()
        target.country = txtCountry.Text.Trim()
        target.city = txtCity.Text.Trim()
        target.address = txtAddress.Text.Trim()
        target.receiver_name = txtReceiverName.Text.Trim()
        target.info = txtInfo.Text.Trim()
        target.comment = txtComment.Text.Trim()
        target.gender = rdoMale.Checked

        Try
            btnSave.Enabled = False
            If isEditMode Then
                Await ApiClient.UpdateSheikhAsync(target.id.Value, target)
            Else
                Await ApiClient.CreateSheikhAsync(target)
            End If
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show($"خطأ أثناء حفظ البيانات: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnSave.Enabled = True
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
