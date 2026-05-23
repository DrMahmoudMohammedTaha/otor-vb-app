Imports P_OtorVB.Models
Imports System.Text.Json

Public Class UcOrders
    Private selectedOrder As Order = Nothing
    Private currentFilter As String = "ALL"

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub UcOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load package and orders
        LoadPackageStatus()
        LoadOrdersList()

        ' Setup radio button event handlers
        AddHandler rdoAll.CheckedChanged, AddressOf FilterChanged
        AddHandler rdoNext.CheckedChanged, AddressOf FilterChanged
        AddHandler rdoDesign.CheckedChanged, AddressOf FilterChanged
        AddHandler rdoPrint.CheckedChanged, AddressOf FilterChanged
        AddHandler rdoPost.CheckedChanged, AddressOf FilterChanged
        AddHandler rdoDeliver.CheckedChanged, AddressOf FilterChanged
        AddHandler rdoHistory.CheckedChanged, AddressOf FilterChanged

        cmbStateUpdate.SelectedIndex = 0
    End Sub

    Public Async Sub LoadPackageStatus()
        Try
            Dim status = Await ApiClient.GetPackageStatusAsync()
            If status IsNot Nothing AndAlso status.last_date.HasValue Then
                lblPackageStatus.Text = $"مر {status.days_elapsed} يوم منذ شحن آخر دفعة ({status.last_date.Value.ToString("yyyy/MM/dd")})"
            Else
                lblPackageStatus.Text = "لم يتم شحن أي دفعة من قبل."
            End If
        Catch ex As Exception
            lblPackageStatus.Text = "تعذر تحميل حالة الدفعة."
        End Try
    End Sub

    Public Async Sub LoadOrdersList()
        Try
            Dim orders As List(Of Order)
            If currentFilter = "HISTORY" Then
                orders = Await ApiClient.GetOrderHistoryAsync()
            Else
                orders = Await ApiClient.GetOrdersAsync(currentFilter)
            End If
            
            dgvOrders.DataSource = Nothing
            dgvOrders.AutoGenerateColumns = False
            dgvOrders.Columns.Clear()

            Dim colId = New DataGridViewTextBoxColumn With {
                .DataPropertyName = "id",
                .HeaderText = "رقم الطلب",
                .Width = 80
            }
            Dim colSheikh = New DataGridViewTextBoxColumn With {
                .DataPropertyName = "sheikh_name",
                .HeaderText = "الشيخ",
                .Width = 180
            }
            Dim colState = New DataGridViewTextBoxColumn With {
                .DataPropertyName = "state",
                .HeaderText = "الحالة",
                .Width = 90
            }
            Dim colContents = New DataGridViewTextBoxColumn With {
                .DataPropertyName = "contents",
                .HeaderText = "المحتويات",
                .Width = 200
            }
            Dim colCost = New DataGridViewTextBoxColumn With {
                .DataPropertyName = "cost",
                .HeaderText = "التكلفة",
                .Width = 90
            }
            Dim colPaid = New DataGridViewTextBoxColumn With {
                .DataPropertyName = "paid",
                .HeaderText = "المدفوع",
                .Width = 90
            }
            Dim colRest = New DataGridViewTextBoxColumn With {
                .DataPropertyName = "rest",
                .HeaderText = "المتبقي",
                .Width = 90
            }
            Dim colCity = New DataGridViewTextBoxColumn With {
                .DataPropertyName = "sheikh_city",
                .HeaderText = "المدينة",
                .Width = 100
            }

            dgvOrders.Columns.AddRange(colId, colSheikh, colState, colContents, colCost, colPaid, colRest, colCity)
            dgvOrders.DataSource = orders

            ' Clear selection
            selectedOrder = Nothing
        Catch ex As Exception
            MessageBox.Show($"خطأ أثناء تحميل الطلبات: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FilterChanged(sender As Object, e As EventArgs)
        Dim rdo = DirectCast(sender, RadioButton)
        If rdo.Checked Then
            If rdo Is rdoAll Then currentFilter = "ALL"
            If rdo Is rdoNext Then currentFilter = "NEXT"
            If rdo Is rdoDesign Then currentFilter = "DESIGN"
            If rdo Is rdoPrint Then currentFilter = "PRINT"
            If rdo Is rdoPost Then currentFilter = "POST"
            If rdo Is rdoDeliver Then currentFilter = "DELIVER"
            If rdo Is rdoHistory Then currentFilter = "HISTORY"

            LoadOrdersList()
        End If
    End Sub

    Private Sub dgvOrders_SelectionChanged(sender As Object, e As EventArgs) Handles dgvOrders.SelectionChanged
        If dgvOrders.SelectedRows.Count > 0 Then
            Dim row = dgvOrders.SelectedRows(0)
            selectedOrder = DirectCast(row.DataBoundItem, Order)
            
            ' Pre-populate state combo box matching current state
            Dim idx = cmbStateUpdate.Items.IndexOf(selectedOrder.state.ToUpper())
            If idx >= 0 Then
                cmbStateUpdate.SelectedIndex = idx
            End If
        Else
            selectedOrder = Nothing
        End If
    End Sub

    Private Async Sub btnStartPackage_Click(sender As Object, e As EventArgs) Handles btnStartPackage.Click
        Dim res = MessageBox.Show("هل تريد بدء احتساب شحنة/دفعة جديدة اليوم؟ سيؤدي ذلك لتصفير عداد الأيام.", "بدء شحنة جديدة", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = DialogResult.Yes Then
            Try
                Dim ok = Await ApiClient.StartNewPackageAsync()
                If ok Then
                    MessageBox.Show("تم تسجيل بدء الدفعة بنجاح.", "تم الإجراء", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadPackageStatus()
                End If
            Catch ex As Exception
                MessageBox.Show($"خطأ أثناء بدء الدفعة: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click
        Using frm = New FormOrderEdit()
            If frm.ShowDialog() = DialogResult.OK Then
                LoadOrdersList()
            End If
        End Using
    End Sub

    Private Sub btnEditOrder_Click(sender As Object, e As EventArgs) Handles btnEditOrder.Click
        If selectedOrder Is Nothing Then
            MessageBox.Show("يرجى تحديد طلب للتعديل أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If currentFilter = "HISTORY" Then
            MessageBox.Show("لا يمكن تعديل الطلبات المؤرشفة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using frm = New FormOrderEdit(selectedOrder)
            If frm.ShowDialog() = DialogResult.OK Then
                LoadOrdersList()
            End If
        End Using
    End Sub

    Private Async Sub btnDeleteOrder_Click(sender As Object, e As EventArgs) Handles btnDeleteOrder.Click
        If selectedOrder Is Nothing Then
            MessageBox.Show("يرجى تحديد طلب للحذف أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If currentFilter = "HISTORY" Then
            MessageBox.Show("لا يمكن حذف الطلبات المؤرشفة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim res = MessageBox.Show($"هل أنت متأكد من حذف الطلب رقم {selectedOrder.id} والشهادات التابعة له؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If res = DialogResult.Yes Then
            Try
                Dim ok = Await ApiClient.DeleteOrderAsync(selectedOrder.id.Value)
                If ok Then
                    MessageBox.Show("تم حذف الطلب والشهادات بنجاح.", "تم الإجراء", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadOrdersList()
                Else
                    MessageBox.Show("خطأ أثناء الحذف.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show($"حدث خطأ أثناء الحذف: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Async Sub btnUpdateState_Click(sender As Object, e As EventArgs) Handles btnUpdateState.Click
        If selectedOrder Is Nothing Then
            MessageBox.Show("يرجى تحديد طلب لتحديث حالته أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If currentFilter = "HISTORY" Then
            MessageBox.Show("لا يمكن تعديل حالة الطلبات المؤرشفة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim newState = cmbStateUpdate.SelectedItem.ToString()
        Try
            btnUpdateState.Enabled = False
            Dim result = Await ApiClient.UpdateOrderStateAsync(selectedOrder.id.Value, newState)
            
            Dim status = result.GetProperty("status").GetString()
            If status = "state_coerced_to_deliver" Then
                MessageBox.Show("تنبيه: تم تحويل حالة الطلب إلى DELIVER (بدلاً من المكتمل) نظراً لوجود مبالغ متبقية غير مدفوعة للشيخ.", "تنبيه الدفع", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If status = "archived" Then
                    MessageBox.Show("الطلب مكتمل ومدفوع بالكامل. تم نقله إلى الأرشيف التاريخي بنجاح.", "تم الأرشفة", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("تم تحديث حالة الطلب بنجاح.", "تم الإجراء", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

            LoadOrdersList()
        Catch ex As Exception
            MessageBox.Show($"خطأ أثناء تحديث الحالة: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            btnUpdateState.Enabled = True
        End Try
    End Sub

    Private Sub btnManageContent_Click(sender As Object, e As EventArgs) Handles btnManageContent.Click
        If selectedOrder Is Nothing Then
            MessageBox.Show("يرجى تحديد طلب لإدارة شهاداته أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim readOnlyMode As Boolean = (currentFilter = "HISTORY")
        Using frm = New FormOrderContent(selectedOrder, readOnlyMode)
            frm.ShowDialog()
            ' Reload orders list because content management can change things
            LoadOrdersList()
        End Using
    End Sub
End Class
