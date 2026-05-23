Imports System.Globalization
Imports P_OtorVB.Models

Public Class FormSheikhDashboard
    Private sheikhId As Integer
    Private initialSheikhName As String
    Private activeOrders As New List(Of Order)()
    Private historyOrders As New List(Of Order)()

    Public Sub New(sheikhId As Integer, sheikhName As String)
        InitializeComponent()
        Me.sheikhId = sheikhId
        Me.initialSheikhName = sheikhName
        lblHeaderTitle.Text = $"بوابة الشيخ: {sheikhName}"
    End Sub

    Private Async Sub FormSheikhDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadSheikhInfoAndStatsAsync()
        Await LoadOrdersAsync()
    End Sub

    Private Async Function LoadSheikhInfoAndStatsAsync() As Task
        Try
            ' 1. Load full sheikh details
            Dim sheikh = Await ApiClient.GetSheikhAsync(sheikhId)
            If sheikh IsNot Nothing Then
                Dim details As String = $"بوابة الشيخ: {sheikh.name}"
                If Not String.IsNullOrEmpty(sheikh.phone) Then
                    details &= $" | هاتف: {sheikh.phone}"
                End If
                If Not String.IsNullOrEmpty(sheikh.address) OrElse Not String.IsNullOrEmpty(sheikh.city) Then
                    details &= $" | العنوان: {sheikh.address} {sheikh.city} {sheikh.country}"
                End If
                lblHeaderTitle.Text = details
            End If

            ' 2. Load stats
            Dim stats = Await ApiClient.GetSheikhStatsAsync(sheikhId)
            If stats IsNot Nothing Then
                lblActiveCount.Text = stats.active_orders_count.ToString()
                lblEarned.Text = $"EGP {stats.total_historical_cost:N2}"
                lblCertsCount.Text = stats.total_historical_items.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show($"خطأ أثناء تحميل بيانات الشيخ وإحصائياته: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Async Function LoadOrdersAsync() As Task
        Try
            ' 1. Load active orders
            activeOrders = Await ApiClient.GetOrdersAsync(state:="ALL", sheikhId:=sheikhId)
            SetupActiveOrdersGrid()

            ' 2. Load history orders
            historyOrders = Await ApiClient.GetOrderHistoryAsync(sheikhId:=sheikhId)
            SetupHistoryOrdersGrid()
        Catch ex As Exception
            MessageBox.Show($"خطأ أثناء تحميل الطلبات: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub SetupActiveOrdersGrid()
        dgvActiveOrders.DataSource = Nothing
        dgvActiveOrders.AutoGenerateColumns = False
        dgvActiveOrders.Columns.Clear()

        Dim colId = New DataGridViewTextBoxColumn With {
            .DataPropertyName = "id",
            .HeaderText = "رقم الطلب",
            .Width = 100
        }
        Dim colState = New DataGridViewTextBoxColumn With {
            .DataPropertyName = "state",
            .HeaderText = "الحالة",
            .Width = 120
        }
        Dim colCost = New DataGridViewTextBoxColumn With {
            .DataPropertyName = "cost",
            .HeaderText = "التكلفة الكلية",
            .Width = 120
        }
        Dim colPaid = New DataGridViewTextBoxColumn With {
            .DataPropertyName = "paid",
            .HeaderText = "المدفوع",
            .Width = 120
        }
        Dim colRest = New DataGridViewTextBoxColumn With {
            .DataPropertyName = "rest",
            .HeaderText = "المتبقي",
            .Width = 120
        }
        Dim colComment = New DataGridViewTextBoxColumn With {
            .DataPropertyName = "comment",
            .HeaderText = "ملاحظات",
            .Width = 250
        }
        Dim colDate = New DataGridViewTextBoxColumn With {
            .DataPropertyName = "insert_date",
            .HeaderText = "تاريخ الطلب",
            .Width = 150
        }

        dgvActiveOrders.Columns.AddRange(colId, colState, colCost, colPaid, colRest, colComment, colDate)
        dgvActiveOrders.DataSource = activeOrders
    End Sub

    Private Sub SetupHistoryOrdersGrid()
        dgvHistoryOrders.DataSource = Nothing
        dgvHistoryOrders.AutoGenerateColumns = False
        dgvHistoryOrders.Columns.Clear()

        Dim colId = New DataGridViewTextBoxColumn With {
            .DataPropertyName = "id",
            .HeaderText = "رقم الطلب",
            .Width = 100
        }
        Dim colState = New DataGridViewTextBoxColumn With {
            .DataPropertyName = "state",
            .HeaderText = "الحالة",
            .Width = 120
        }
        Dim colCost = New DataGridViewTextBoxColumn With {
            .DataPropertyName = "cost",
            .HeaderText = "التكلفة الكلية",
            .Width = 120
        }
        Dim colPaid = New DataGridViewTextBoxColumn With {
            .DataPropertyName = "paid",
            .HeaderText = "المدفوع",
            .Width = 120
        }
        Dim colRest = New DataGridViewTextBoxColumn With {
            .DataPropertyName = "rest",
            .HeaderText = "المتبقي",
            .Width = 120
        }
        Dim colComment = New DataGridViewTextBoxColumn With {
            .DataPropertyName = "comment",
            .HeaderText = "ملاحظات",
            .Width = 250
        }
        Dim colDate = New DataGridViewTextBoxColumn With {
            .DataPropertyName = "update_date",
            .HeaderText = "تاريخ الإنجاز والنشاط",
            .Width = 150
        }

        dgvHistoryOrders.Columns.AddRange(colId, colState, colCost, colPaid, colRest, colComment, colDate)
        dgvHistoryOrders.DataSource = historyOrders
    End Sub

    Private Sub btnViewOrderDetails_Click(sender As Object, e As EventArgs) Handles btnViewOrderDetails.Click
        Dim selectedOrder As Order = Nothing

        If tabMain.SelectedTab Is tabActive Then
            If dgvActiveOrders.SelectedRows.Count > 0 Then
                selectedOrder = DirectCast(dgvActiveOrders.SelectedRows(0).DataBoundItem, Order)
            End If
        ElseIf tabMain.SelectedTab Is tabHistory Then
            If dgvHistoryOrders.SelectedRows.Count > 0 Then
                selectedOrder = DirectCast(dgvHistoryOrders.SelectedRows(0).DataBoundItem, Order)
            End If
        End If

        If selectedOrder Is Nothing Then
            MessageBox.Show("يرجى تحديد طلب من القائمة أولاً لعرض تفاصيل الشهادات.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using frm = New FormOrderContent(selectedOrder, isReadOnly:=True)
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class
