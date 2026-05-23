Imports P_OtorVB.Models

Public Class FormOrderEdit
    Private editOrder As Order = Nothing
    Private isEditMode As Boolean = False
    Private allSheikhs As New List(Of Sheikh)()
    Private isInitializing As Boolean = True

    Public Sub New()
        InitializeComponent()
        isEditMode = False
        Me.Text = "إضافة طلب جديد"
    End Sub

    Public Sub New(orderToEdit As Order)
        InitializeComponent()
        editOrder = orderToEdit
        isEditMode = True
        Me.Text = "تعديل الطلب الحالي"
    End Sub

    Private Async Sub FormOrderEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isInitializing = True
        cmbState.SelectedIndex = 0

        ' Load Sheikhs for combo box
        Try
            allSheikhs = Await ApiClient.GetSheikhsAsync()
            cmbSheikh.DataSource = allSheikhs
            cmbSheikh.DisplayMember = "name"
            cmbSheikh.ValueMember = "id"
        Catch ex As Exception
            MessageBox.Show("تعذر تحميل قائمة الشيوخ.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Bind events for cost/paid change
        AddHandler txtCost.TextChanged, AddressOf CostOrPaidChanged
        AddHandler txtPaid.TextChanged, AddressOf CostOrPaidChanged

        If isEditMode AndAlso editOrder IsNot Nothing Then
            cmbSheikh.SelectedValue = editOrder.sheikh_id
            
            Dim idx = cmbState.Items.IndexOf(editOrder.state.ToUpper())
            If idx >= 0 Then cmbState.SelectedIndex = idx

            txtCost.Text = editOrder.cost.ToString()
            txtPaid.Text = editOrder.paid.ToString()
            txtRest.Text = editOrder.rest.ToString("N2")
            txtContents.Text = editOrder.contents
            txtDegree.Text = editOrder.degree.ToString()
            txtComment.Text = editOrder.comment

            txtShipReceiver.Text = editOrder.p_receiver
            txtShipPhone.Text = editOrder.p_phone
            txtShipCountry.Text = editOrder.p_country
            txtShipCity.Text = editOrder.p_city
            txtShipAddress.Text = editOrder.p_address
        Else
            ' Select first sheikh or set null
            If cmbSheikh.Items.Count > 0 Then
                cmbSheikh.SelectedIndex = 0
                LoadSheikhDefaults(DirectCast(cmbSheikh.SelectedItem, Sheikh))
            End If
            RecalculateRest()
        End If

        isInitializing = False
    End Sub

    Private Sub CostOrPaidChanged(sender As Object, e As EventArgs)
        RecalculateRest()
    End Sub

    Private Sub RecalculateRest()
        Dim cost As Double = 0.0
        Dim paid As Double = 0.0
        Double.TryParse(txtCost.Text, cost)
        Double.TryParse(txtPaid.Text, paid)
        txtRest.Text = (cost - paid).ToString("N2")
    End Sub

    Private Sub cmbSheikh_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSheikh.SelectedIndexChanged
        If Not isInitializing AndAlso Not isEditMode Then
            Dim selected = DirectCast(cmbSheikh.SelectedItem, Sheikh)
            If selected IsNot Nothing Then
                LoadSheikhDefaults(selected)
            End If
        End If
    End Sub

    Private Sub LoadSheikhDefaults(sheikh As Sheikh)
        txtShipReceiver.Text = If(String.IsNullOrEmpty(sheikh.receiver_name), sheikh.name, sheikh.receiver_name)
        txtShipPhone.Text = sheikh.phone
        txtShipCountry.Text = sheikh.country
        txtShipCity.Text = sheikh.city
        txtShipAddress.Text = sheikh.address
    End Sub

    Private Async Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cmbSheikh.SelectedValue Is Nothing Then
            MessageBox.Show("يرجى اختيار الشيخ.", "حقل مطلوب", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim costVal As Double = 0.0
        Dim paidVal As Double = 0.0
        Dim degreeVal As Double = 0.0
        Double.TryParse(txtCost.Text, costVal)
        Double.TryParse(txtPaid.Text, paidVal)
        Double.TryParse(txtDegree.Text, degreeVal)

        Dim target = If(isEditMode, editOrder, New Order())
        target.sheikh_id = Convert.ToInt32(cmbSheikh.SelectedValue)
        target.sheikh_name = DirectCast(cmbSheikh.SelectedItem, Sheikh).name
        target.state = cmbState.SelectedItem.ToString()
        target.cost = costVal
        target.paid = paidVal
        target.rest = costVal - paidVal
        target.contents = txtContents.Text.Trim()
        target.degree = degreeVal
        target.comment = txtComment.Text.Trim()

        target.p_receiver = txtShipReceiver.Text.Trim()
        target.p_phone = txtShipPhone.Text.Trim()
        target.p_country = txtShipCountry.Text.Trim()
        target.p_city = txtShipCity.Text.Trim()
        target.p_address = txtShipAddress.Text.Trim()

        Try
            btnSave.Enabled = False
            If isEditMode Then
                Await ApiClient.UpdateOrderAsync(target.id.Value, target)
            Else
                Await ApiClient.CreateOrderAsync(target)
            End If
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show($"خطأ أثناء حفظ الطلب: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnSave.Enabled = True
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
