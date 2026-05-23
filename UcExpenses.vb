Imports P_OtorVB.Models

Public Class UcExpenses
    Private expensesList As New List(Of Expense)()
    Private categorySummaries As New List(Of ExpenseCategory)()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub UcExpenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbExpenseCategory.SelectedIndex = 0
        LoadExpensesData()
    End Sub

    Public Async Sub LoadExpensesData()
        Try
            ' 1. Load all expenses
            expensesList = Await ApiClient.GetExpensesAsync()
            dgvExpenses.DataSource = Nothing
            dgvExpenses.AutoGenerateColumns = False
            dgvExpenses.Columns.Clear()

            Dim colId = New DataGridViewTextBoxColumn With {
                .DataPropertyName = "id",
                .HeaderText = "رقم المعاملة",
                .Width = 60
            }
            Dim colName = New DataGridViewTextBoxColumn With {
                .DataPropertyName = "expense",
                .HeaderText = "اسم المصروف",
                .Width = 150
            }
            Dim colCategory = New DataGridViewTextBoxColumn With {
                .DataPropertyName = "category",
                .HeaderText = "التصنيف",
                .Width = 100
            }
            Dim colAmount = New DataGridViewTextBoxColumn With {
                .DataPropertyName = "amount",
                .HeaderText = "المبلغ",
                .Width = 80
            }
            Dim colDate = New DataGridViewTextBoxColumn With {
                .DataPropertyName = "due_date",
                .HeaderText = "التاريخ",
                .Width = 120
            }

            dgvExpenses.Columns.AddRange(colId, colName, colCategory, colAmount, colDate)
            dgvExpenses.DataSource = expensesList

            ' 2. Load categories sums
            categorySummaries = Await ApiClient.GetExpenseCategoriesAsync()
            dgvCategories.DataSource = Nothing
            dgvCategories.AutoGenerateColumns = False
            dgvCategories.Columns.Clear()

            Dim colCat = New DataGridViewTextBoxColumn With {
                .DataPropertyName = "category",
                .HeaderText = "التصنيف",
                .Width = 150
            }
            Dim colTotal = New DataGridViewTextBoxColumn With {
                .DataPropertyName = "total",
                .HeaderText = "إجمالي المنصرف",
                .Width = 120
            }

            dgvCategories.Columns.AddRange(colCat, colTotal)
            dgvCategories.DataSource = categorySummaries

        Catch ex As Exception
            MessageBox.Show($"خطأ أثناء تحميل بيانات المالية: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async Sub btnSaveExpense_Click(sender As Object, e As EventArgs) Handles btnSaveExpense.Click
        Dim expName = txtExpenseName.Text.Trim()
        If String.IsNullOrEmpty(expName) Then
            MessageBox.Show("يرجى إدخال اسم المصروف أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim amountVal As Double = 0.0
        If Not Double.TryParse(txtExpenseAmount.Text, amountVal) OrElse amountVal <= 0 Then
            MessageBox.Show("يرجى إدخال مبلغ صحيح أكبر من الصفر.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim newExpense As New Expense With {
            .expense = expName,
            .amount = amountVal,
            .category = cmbExpenseCategory.SelectedItem.ToString(),
            .comment = txtExpenseComment.Text.Trim(),
            .due_date = DateTime.now()
        }

        Try
            btnSaveExpense.Enabled = False
            Dim result = Await ApiClient.CreateExpenseAsync(newExpense)
            
            MessageBox.Show("تم تسجيل المصروف بنجاح وتحديث الصندوق.", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            
            ' Clear inputs
            txtExpenseName.Clear()
            txtExpenseAmount.Text = "0"
            txtExpenseComment.Clear()
            cmbExpenseCategory.SelectedIndex = 0

            ' Refresh lists
            LoadExpensesData()
        Catch ex As Exception
            MessageBox.Show($"تعذر تسجيل المصروف: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            btnSaveExpense.Enabled = True
        End Try
    End Sub
End Class
