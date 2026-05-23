Imports P_OtorVB.Models

Public Class FormMain
    Private ucOrders As UcOrders
    Private ucSheikhs As UcSheikhs
    Private ucExpenses As UcExpenses

    Private Async Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApiClient.Initialize()
        
        ' Initialize User Controls
        ucOrders = New UcOrders()
        ucSheikhs = New UcSheikhs()
        ucExpenses = New UcExpenses()

        ' Set default view
        ShowUserControl(ucOrders)
        UpdateButtonHighlight(btnOrders)

        ' Verify API connection
        Await VerifyConnectionAsync()
    End Sub

    Private Async Function VerifyConnectionAsync() As Task
        Try
            lblConnectionStatus.Text = "جاري التحقق من الاتصال بالخادم..."
            lblConnectionStatus.ForeColor = Color.Orange

            Dim status = Await ApiClient.GetPackageStatusAsync()
            
            lblConnectionStatus.Text = "متصل بقاعدة البيانات Neon PostgreSQL عبر FastAPI"
            lblConnectionStatus.ForeColor = Color.Green
        Catch ex As Exception
            lblConnectionStatus.Text = "فشل الاتصال بخادم FastAPI (تأكد من تشغيل الباكيند)"
            lblConnectionStatus.ForeColor = Color.Red
        End Try
    End Function

    Private Sub ShowUserControl(uc As UserControl)
        pnlContainer.Controls.Clear()
        uc.Dock = DockStyle.Fill
        pnlContainer.Controls.Add(uc)
    End Sub

    Private Sub UpdateButtonHighlight(activeButton As Button)
        ' Reset all buttons
        For Each ctrl In pnlSidebar.Controls
            If TypeOf ctrl Is Button Then
                Dim btn = DirectCast(ctrl, Button)
                btn.BackColor = Color.Transparent
                btn.ForeColor = Color.FromArgb(200, 180, 160)
            End If
        Next

        ' Highlight active button
        activeButton.BackColor = Color.FromArgb(80, 60, 45)
        activeButton.ForeColor = Color.White
    End Sub

    Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnOrders.Click
        lblHeaderTitle.Text = "إدارة طلبات الشيخ والشهادات"
        ShowUserControl(ucOrders)
        UpdateButtonHighlight(btnOrders)
    End Sub

    Private Sub btnSheikhs_Click(sender As Object, e As EventArgs) Handles btnSheikhs.Click
        lblHeaderTitle.Text = "شيوخ المقارئ والدليل"
        ShowUserControl(ucSheikhs)
        UpdateButtonHighlight(btnSheikhs)
        ucSheikhs.LoadSheikhsList()
    End Sub

    Private Sub btnExpenses_Click(sender As Object, e As EventArgs) Handles btnExpenses.Click
        lblHeaderTitle.Text = "إدارة المصروفات وحساب الصندوق"
        ShowUserControl(ucExpenses)
        UpdateButtonHighlight(btnExpenses)
        ucExpenses.LoadExpensesData()
    End Sub
End Class
