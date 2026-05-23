Imports P_OtorVB.Models

Public Class UcSheikhs
    Private allSheikhs As New List(Of Sheikh)()
    Private selectedSheikh As Sheikh = Nothing

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Async Sub LoadSheikhsList()
        Try
            allSheikhs = Await ApiClient.GetSheikhsAsync()
            FilterSheikhs()
        Catch ex As Exception
            MessageBox.Show($"خطأ أثناء تحميل قائمة الشيوخ: {ex.Message}", "خطأ اتصال", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FilterSheikhs()
        Dim search = txtSearch.Text.Trim().ToLower()
        Dim filtered = allSheikhs

        If Not String.IsNullOrEmpty(search) Then
            filtered = allSheikhs.Where(Function(s) s.name.ToLower().Contains(search) OrElse
                                                     (s.phone IsNot Nothing AndAlso s.phone.Contains(search)) OrElse
                                                     (s.city IsNot Nothing AndAlso s.city.ToLower().Contains(search))).ToList()
        End If

        dgvSheikhs.DataSource = Nothing
        dgvSheikhs.AutoGenerateColumns = False

        dgvSheikhs.Columns.Clear()

        Dim colId = New DataGridViewTextBoxColumn With {
            .DataPropertyName = "id",
            .HeaderText = "المعرف",
            .Width = 60
        }
        Dim colName = New DataGridViewTextBoxColumn With {
            .DataPropertyName = "name",
            .HeaderText = "الاسم الكمل",
            .Width = 200
        }
        Dim colPhone = New DataGridViewTextBoxColumn With {
            .DataPropertyName = "phone",
            .HeaderText = "رقم الهاتف",
            .Width = 120
        }
        Dim colCity = New DataGridViewTextBoxColumn With {
            .DataPropertyName = "city",
            .HeaderText = "المدينة / المحافظة",
            .Width = 120
        }

        dgvSheikhs.Columns.AddRange(colId, colName, colPhone, colCity)
        dgvSheikhs.DataSource = filtered
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        FilterSheikhs()
    End Sub

    Private Async Sub dgvSheikhs_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSheikhs.SelectionChanged
        If dgvSheikhs.SelectedRows.Count > 0 Then
            Dim row = dgvSheikhs.SelectedRows(0)
            Dim sheikhId = Convert.ToInt32(row.Cells(0).Value)
            selectedSheikh = allSheikhs.FirstOrDefault(Function(s) s.id = sheikhId)

            If selectedSheikh IsNot Nothing Then
                btnCall.Enabled = Not String.IsNullOrEmpty(selectedSheikh.phone)
                Await UpdateSheikhStatsAsync(sheikhId)
            End If
        Else
            selectedSheikh = Nothing
            btnCall.Enabled = False
            lblSheikhBio.Text = "يرجى تحديد شيخ لعرض تفاصيله"
            lblTotalCost.Text = "التكلفة الكلية السابقة: 0"
            lblTotalCerts.Text = "إجمالي الشهادات المنجزة: 0"
            lblActiveOrders.Text = "الطلبات النشطة حالياً: 0"
        End If
    End Sub

    Private Async Function UpdateSheikhStatsAsync(id As Integer) As Task
        Try
            ' Load static text
            lblSheikhBio.Text = $"{selectedSheikh.name}{vbCrLf}" &
                               $"الهاتف: {selectedSheikh.phone}{vbCrLf}" &
                               $"العنوان: {selectedSheikh.address}, {selectedSheikh.city}, {selectedSheikh.country}{vbCrLf}" &
                               $"ملاحظات: {selectedSheikh.comment}"

            ' Load stats dynamically from API
            Dim stats = Await ApiClient.GetSheikhStatsAsync(id)
            lblTotalCost.Text = $"التكلفة الكلية السابقة: EGP {stats.total_historical_cost:N2}"
            lblTotalCerts.Text = $"إجمالي الشهادات المنجزة: {stats.total_historical_items}"
            lblActiveOrders.Text = $"الطلبات النشطة حالياً: {stats.active_orders_count}"
        Catch ex As Exception
            ' Fallback if stats fail
            lblTotalCost.Text = "التكلفة الكلية السابقة: خطأ في التحميل"
        End Try
    End Function

    Private Sub btnAddSheikh_Click(sender As Object, e As EventArgs) Handles btnAddSheikh.Click
        Using frm = New FormSheikhEdit()
            If frm.ShowDialog() = DialogResult.OK Then
                LoadSheikhsList()
            End If
        End Using
    End Sub

    Private Sub btnEditSheikh_Click(sender As Object, e As EventArgs) Handles btnEditSheikh.Click
        If selectedSheikh Is Nothing Then
            MessageBox.Show("يرجى تحديد شيخ أولاً للتعديل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using frm = New FormSheikhEdit(selectedSheikh)
            If frm.ShowDialog() = DialogResult.OK Then
                LoadSheikhsList()
            End If
        End Using
    End Sub

    Private Async Sub btnDeleteSheikh_Click(sender As Object, e As EventArgs) Handles btnDeleteSheikh.Click
        If selectedSheikh Is Nothing Then
            MessageBox.Show("يرجى تحديد شيخ أولاً للحذف.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim res = MessageBox.Show($"هل أنت متأكد من حذف الشيخ '{selectedSheikh.name}'؟ لا يمكن التراجع عن هذا الإجراء.", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If res = DialogResult.Yes Then
            Try
                Dim ok = Await ApiClient.DeleteSheikhAsync(selectedSheikh.id.Value)
                If ok Then
                    MessageBox.Show("تم حذف الشيخ بنجاح.", "تم الإجراء", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadSheikhsList()
                Else
                    MessageBox.Show("خطأ أثناء حذف الشيخ.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show($"حدث خطأ أثناء الحذف: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Async Sub btnOpenFolder_Click(sender As Object, e As EventArgs) Handles btnOpenFolder.Click
        If selectedSheikh Is Nothing Then
            MessageBox.Show("يرجى تحديد شيخ أولاً لفتح مجلده.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim ok = Await ApiClient.OpenSheikhFolderAsync(selectedSheikh.name)
            If Not ok Then
                MessageBox.Show("فشل فتح المجلد على الخادم المحلي.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show($"حدث خطأ: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCall_Click(sender As Object, e As EventArgs) Handles btnCall.Click
        If selectedSheikh Is Nothing OrElse String.IsNullOrEmpty(selectedSheikh.phone) Then
            MessageBox.Show("لا يوجد رقم هاتف للاتصال به.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim phoneUri = $"tel:{selectedSheikh.phone.Trim()}"
            Dim psi = New ProcessStartInfo(phoneUri) With {
                .UseShellExecute = True
            }
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show($"فشل بدء الاتصال الهاتفي: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
