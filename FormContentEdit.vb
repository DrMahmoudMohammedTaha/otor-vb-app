Imports P_OtorVB.Models

Public Class FormContentEdit
    Private currentOrderId As Integer
    Private editItem As ContentItem = Nothing
    Private isEditMode As Boolean = False

    Public Sub New(orderId As Integer)
        InitializeComponent()
        currentOrderId = orderId
        isEditMode = False
        Me.Text = "إضافة شهادة جديدة"
    End Sub

    Public Sub New(orderId As Integer, itemToEdit As ContentItem)
        InitializeComponent()
        currentOrderId = orderId
        editItem = itemToEdit
        isEditMode = True
        Me.Text = "تعديل بيانات الشهادة"
    End Sub

    Private Sub FormContentEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbStudentGender.SelectedIndex = 0
        cmbType.SelectedIndex = 0

        If isEditMode AndAlso editItem IsNot Nothing Then
            txtStudentName.Text = editItem.student_name
            
            Dim gIdx = cmbStudentGender.Items.IndexOf(editItem.student_gender)
            If gIdx >= 0 Then cmbStudentGender.SelectedIndex = gIdx
            
            txtStudentInfo.Text = editItem.student_info
            txtQeraa.Text = editItem.qeraa
            txtCost.Text = editItem.cost.ToString()
            txtComment.Text = editItem.comment

            Dim tIdx = cmbType.Items.IndexOf(editItem.type.ToUpper())
            If tIdx >= 0 Then cmbType.SelectedIndex = tIdx
        End If
    End Sub

    Private Async Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sName = txtStudentName.Text.Trim()
        If String.IsNullOrEmpty(sName) Then
            MessageBox.Show("يرجى إدخال اسم الطالب.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim costVal As Double = 0.0
        Double.TryParse(txtCost.Text, costVal)

        Dim target = If(isEditMode, editItem, New ContentItem())
        target.order_id = currentOrderId
        target.student_name = sName
        target.student_gender = cmbStudentGender.SelectedItem.ToString()
        target.student_info = txtStudentInfo.Text.Trim()
        target.qeraa = txtQeraa.Text.Trim()
        target.cost = costVal
        target.comment = txtComment.Text.Trim()
        target.type = cmbType.SelectedItem.ToString()

        Try
            btnSave.Enabled = False
            If isEditMode Then
                Await ApiClient.UpdateContentAsync(target.id.Value, target)
            Else
                Await ApiClient.CreateContentAsync(target)
            End If
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show($"حدث خطأ أثناء الحفظ: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnSave.Enabled = True
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
