Imports P_OtorVB.Models

Public Class FormOrderContent
    Private targetOrder As Order
    Private contentItems As New List(Of ContentItem)()
    Private selectedItem As ContentItem = Nothing

    Private isReadOnly As Boolean = False

    Public Sub New(order As Order, Optional isReadOnly As Boolean = False)
        InitializeComponent()
        targetOrder = order
        Me.isReadOnly = isReadOnly
        lblTitle.Text = If(isReadOnly, $"معاينة شهادات الطلب رقم {order.id} للشيخ {order.sheikh_name}", $"إدارة شهادات الطلب رقم {order.id} للشيخ {order.sheikh_name}")
    End Sub

    Private Sub FormOrderContent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isReadOnly Then
            pnlItemActions.Visible = False
            tabMain.TabPages.Remove(tabBulk)
        End If
        LoadContentItems()
    End Sub

    Public Async Sub LoadContentItems()
        Try
            contentItems = Await ApiClient.GetContentsAsync(targetOrder.id.Value)
            
            dgvItems.DataSource = Nothing
            dgvItems.AutoGenerateColumns = False
            dgvItems.Columns.Clear()

            Dim colId = New DataGridViewTextBoxColumn With {
                .DataPropertyName = "id",
                .HeaderText = "المعرف",
                .Width = 60
            }
            Dim colStudent = New DataGridViewTextBoxColumn With {
                .DataPropertyName = "student_name",
                .HeaderText = "اسم الطالب / الطالبة",
                .Width = 180
            }
            Dim colGender = New DataGridViewTextBoxColumn With {
                .DataPropertyName = "student_gender",
                .HeaderText = "الجنس",
                .Width = 80
            }
            Dim colInfo = New DataGridViewTextBoxColumn With {
                .DataPropertyName = "student_info",
                .HeaderText = "بيانات السند",
                .Width = 150
            }
            Dim colQeraa = New DataGridViewTextBoxColumn With {
                .DataPropertyName = "qeraa",
                .HeaderText = "القراءة / الرواية",
                .Width = 150
            }
            Dim colCost = New DataGridViewTextBoxColumn With {
                .DataPropertyName = "cost",
                .HeaderText = "التكلفة",
                .Width = 80
            }
            Dim colComment = New DataGridViewTextBoxColumn With {
                .DataPropertyName = "comment",
                .HeaderText = "ملاحظات",
                .Width = 120
            }

            dgvItems.Columns.AddRange(colId, colStudent, colGender, colInfo, colQeraa, colCost, colComment)
            dgvItems.DataSource = contentItems
            
            selectedItem = Nothing
        Catch ex As Exception
            MessageBox.Show($"خطأ أثناء تحميل عناصر الطلب: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvItems_SelectionChanged(sender As Object, e As EventArgs) Handles dgvItems.SelectionChanged
        If dgvItems.SelectedRows.Count > 0 Then
            Dim row = dgvItems.SelectedRows(0)
            selectedItem = DirectCast(row.DataBoundItem, ContentItem)
        Else
            selectedItem = Nothing
        End If
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Using frm = New FormContentEdit(targetOrder.id.Value)
            If frm.ShowDialog() = DialogResult.OK Then
                LoadContentItems()
            End If
        End Using
    End Sub

    Private Sub btnEditItem_Click(sender As Object, e As EventArgs) Handles btnEditItem.Click
        If selectedItem Is Nothing Then
            MessageBox.Show("يرجى تحديد عنصر للتعديل أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using frm = New FormContentEdit(targetOrder.id.Value, selectedItem)
            If frm.ShowDialog() = DialogResult.OK Then
                LoadContentItems()
            End If
        End Using
    End Sub

    Private Async Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click
        If selectedItem Is Nothing Then
            MessageBox.Show("يرجى تحديد عنصر للحذف أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim res = MessageBox.Show($"هل تريد حذف شهادة الطالب '{selectedItem.student_name}'؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = DialogResult.Yes Then
            Try
                Dim ok = Await ApiClient.DeleteContentAsync(selectedItem.id.Value)
                If ok Then
                    MessageBox.Show("تم حذف الشهادة بنجاح.", "تم الإجراء", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadContentItems()
                End If
            Catch ex As Exception
                MessageBox.Show($"حدث خطأ أثناء الحذف: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Async Sub btnProcessBulk_Click(sender As Object, e As EventArgs) Handles btnProcessBulk.Click
        Dim bulkText = txtBulkText.Text.Trim()
        If String.IsNullOrEmpty(bulkText) Then
            MessageBox.Show("يرجى إدخال أسماء الطلاب أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            btnProcessBulk.Enabled = False
            Dim count = Await ApiClient.BulkInsertContentAsync(targetOrder.id.Value, bulkText)
            MessageBox.Show($"تم استيراد وإضافة عدد ({count}) شهادة بنجاح.", "نجاح الاستيراد الجماعي", MessageBoxButtons.OK, MessageBoxIcon.Information)
            
            txtBulkText.Clear()
            tabMain.SelectedTab = tabList
            LoadContentItems()
        Catch ex As Exception
            MessageBox.Show($"فشل الاستيراد الجماعي: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            btnProcessBulk.Enabled = True
        End Try
    End Sub
End Class
