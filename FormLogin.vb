Imports System.IO
Imports P_OtorVB.Models

Public Class FormLogin

    Private Async Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApiClient.Initialize()
        
        ' Initialize role selection
        cmbRole.SelectedIndex = 0
        UpdatePanelVisibility()

        ' Load Banner Image
        Dim imagePath As String = "G:\sanad\sources\P_OtorApp\assets\images\ejaza1.jpg"
        Try
            If File.Exists(imagePath) Then
                picBanner.Image = Image.FromFile(imagePath)
            Else
                ' Fallback: Set solid color or message if file not found
                picBanner.BackColor = Color.FromArgb(80, 60, 45)
            End If
        Catch ex As Exception
            picBanner.BackColor = Color.FromArgb(80, 60, 45)
        End Try

        ' Check Connection Status
        Await VerifyBackendConnectionAsync()
    End Sub

    Private Async Function VerifyBackendConnectionAsync() As Task
        Try
            lblStatus.Text = "جاري التحقق من الاتصال بالخادم..."
            lblStatus.ForeColor = Color.FromArgb(120, 100, 80)
            
            Dim status = Await ApiClient.GetPackageStatusAsync()
            
            lblStatus.Text = "متصل بالخادم بنجاح وبقاعدة بيانات Neon PostgreSQL"
            lblStatus.ForeColor = Color.Green
            btnLogin.Enabled = True
        Catch ex As Exception
            lblStatus.Text = "فشل الاتصال بالخادم. يرجى التأكد من تشغيل FastAPI Backend."
            lblStatus.ForeColor = Color.Red
            ' Enable anyway in case the user wants to retry or use Gallery (though API calls will fail)
            btnLogin.Enabled = True
        End Try
    End Function

    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged
        UpdatePanelVisibility()
    End Sub

    Private Sub UpdatePanelVisibility()
        pnlAdmin.Visible = (cmbRole.SelectedIndex = 0)
        pnlSheikh.Visible = (cmbRole.SelectedIndex = 1)
        pnlGallery.Visible = (cmbRole.SelectedIndex = 2)

        If cmbRole.SelectedIndex = 2 Then
            btnLogin.Text = "دخول للمعرض"
        Else
            btnLogin.Text = "تسجيل الدخول"
        End If
    End Sub

    Private Async Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            btnLogin.Enabled = False
            
            If cmbRole.SelectedIndex = 0 Then
                ' Admin Login
                Dim password = txtPassword.Text.Trim()
                If String.IsNullOrEmpty(password) Then
                    MessageBox.Show("يرجى إدخال كلمة المرور للمدير.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                Dim response = Await ApiClient.LoginAsync("admin", password:=password)
                If response IsNot Nothing AndAlso response.role = "admin" Then
                    Me.Hide()
                    Using frmMain = New FormMain()
                        frmMain.ShowDialog()
                    End Using
                    txtPassword.Clear()
                    ApiClient.SetAuthToken("") ' Clear token on return/logout
                    Me.Show()
                End If

            ElseIf cmbRole.SelectedIndex = 1 Then
                ' Sheikh Login
                Dim phone = txtPhone.Text.Trim()
                If String.IsNullOrEmpty(phone) Then
                    MessageBox.Show("يرجى إدخال رقم الهاتف المسجل للشيخ.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                Dim response = Await ApiClient.LoginAsync("sheikh", phone:=phone)
                If response IsNot Nothing AndAlso response.role = "sheikh" Then
                    Me.Hide()
                    Using frmSheikh = New FormSheikhDashboard(response.sheikh_id.Value, response.name)
                        frmSheikh.ShowDialog()
                    End Using
                    txtPhone.Clear()
                    ApiClient.SetAuthToken("") ' Clear token on return/logout
                    Me.Show()
                End If

            ElseIf cmbRole.SelectedIndex = 2 Then
                ' Gallery Mode (No credentials)
                Me.Hide()
                Using frmGallery = New FormGallery()
                    frmGallery.ShowDialog()
                End Using
                Me.Show()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "خطأ في تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            btnLogin.Enabled = True
        End Try

        Await VerifyBackendConnectionAsync()
    End Sub
End Class
