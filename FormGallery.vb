Imports System.IO

Public Class FormGallery
    Private categoryButtons As List(Of Button)

    Private Sub FormGallery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize category buttons list
        categoryButtons = New List(Of Button) From {
            btnCategoryEjaza,
            btnCategoryBackground,
            btnCategoryCover,
            btnCategoryCertificate,
            btnCategoryTree,
            btnCategoryStamp
        }

        ' Register Click events for all category buttons
        For Each btn In categoryButtons
            AddHandler btn.Click, AddressOf CategoryButton_Click
        Next

        ' Default select the first category (Quranic Ejazas)
        If categoryButtons.Count > 0 Then
            SelectCategory(categoryButtons(0))
        End If

        ' Load Facebook and WhatsApp icons
        Try
            Dim fbPath As String = Path.Combine(Application.StartupPath, "facebook.png")
            Dim waPath As String = Path.Combine(Application.StartupPath, "whatsapp.png")
            If File.Exists(fbPath) Then
                picFacebook.Image = Image.FromFile(fbPath)
            End If
            If File.Exists(waPath) Then
                picWhatsApp.Image = Image.FromFile(waPath)
            End If

            Dim tooltip As New ToolTip()
            tooltip.SetToolTip(picFacebook, "تابعنا على فيسبوك")
            tooltip.SetToolTip(picWhatsApp, "تواصل معنا عبر واتساب")
        Catch ex As Exception
            ' Fail silently
        End Try
    End Sub

    Private Sub CategoryButton_Click(sender As Object, e As EventArgs)
        Dim btn = DirectCast(sender, Button)
        SelectCategory(btn)
    End Sub

    Private Sub SelectCategory(selectedBtn As Button)
        ' Update buttons styling
        For Each btn In categoryButtons
            If btn Is selectedBtn Then
                btn.BackColor = Color.FromArgb(176, 124, 51)
                btn.ForeColor = Color.White
            Else
                btn.BackColor = Color.White
                btn.ForeColor = Color.FromArgb(62, 47, 32)
            End If
        Next

        ' Load images for the selected folder
        If selectedBtn.Tag IsNot Nothing Then
            Dim folderName = selectedBtn.Tag.ToString()
            LoadImagesFromFolder(folderName)
        End If
    End Sub

    Private Sub LoadImagesFromFolder(folderName As String)
        ' Clean up previous controls and dispose their images to prevent memory leaks
        For Each ctrl As Control In flpImages.Controls
            If TypeOf ctrl Is PictureBox Then
                Dim oldPic = DirectCast(ctrl, PictureBox)
                If oldPic.Image IsNot Nothing Then
                    oldPic.Image.Dispose()
                End If
            End If
            ctrl.Dispose()
        Next
        flpImages.Controls.Clear()

        ' Resolve physical path
        Dim basePath As String = "G:\sanad\sources\P_OtorApp\assets\gallery"
        Dim targetPath = Path.Combine(basePath, folderName)

        If Not Directory.Exists(targetPath) Then
            MessageBox.Show($"المجلد غير موجود: {targetPath}", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' List images matching common formats
            Dim files = Directory.EnumerateFiles(targetPath, "*.*") _
                .Where(Function(f) f.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) OrElse
                                   f.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) OrElse
                                   f.EndsWith(".png", StringComparison.OrdinalIgnoreCase)) _
                .ToList()

            flpImages.SuspendLayout()

            For Each file In files
                Dim pic = New PictureBox With {
                    .Width = 160,
                    .Height = 160,
                    .Margin = New Padding(10),
                    .BackColor = Color.White,
                    .Padding = New Padding(5),
                    .SizeMode = PictureBoxSizeMode.Zoom,
                    .Cursor = Cursors.Hand,
                    .Tag = file
                }

                Try
                    ' Load thumbnail image
                    pic.Image = Image.FromFile(file)
                Catch
                    Continue For
                End Try

                AddHandler pic.Click, AddressOf PictureBox_Click
                flpImages.Controls.Add(pic)
            Next

            flpImages.ResumeLayout()
        Catch ex As Exception
            MessageBox.Show($"حدث خطأ أثناء تحميل النماذج: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PictureBox_Click(sender As Object, e As EventArgs)
        Dim pic = DirectCast(sender, PictureBox)
        Dim imagePath = pic.Tag.ToString()

        If File.Exists(imagePath) Then
            Try
                ' Create fullscreen borderless form
                Dim viewerForm = New Form() With {
                    .Text = "معاينة الصورة - اضغط ESC أو انقر للإغلاق",
                    .WindowState = FormWindowState.Maximized,
                    .BackColor = Color.Black,
                    .RightToLeft = RightToLeft.No,
                    .StartPosition = FormStartPosition.CenterScreen,
                    .FormBorderStyle = FormBorderStyle.None,
                    .KeyPreview = True
                }

                Dim viewerPic = New PictureBox() With {
                    .Image = Image.FromFile(imagePath),
                    .Dock = DockStyle.Fill,
                    .SizeMode = PictureBoxSizeMode.Zoom
                }

                ' Interactive closing actions
                AddHandler viewerPic.Click, Sub() viewerForm.Close()
                AddHandler viewerForm.KeyDown, Sub(s, ke)
                                                  If ke.KeyCode = Keys.Escape Then viewerForm.Close()
                                               End Sub

                viewerForm.Controls.Add(viewerPic)
                viewerForm.ShowDialog()

                ' Release system locks on the image
                If viewerPic.Image IsNot Nothing Then
                    viewerPic.Image.Dispose()
                End If
            Catch ex As Exception
                MessageBox.Show($"فشل فتح الصورة: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub picFacebook_Click(sender As Object, e As EventArgs) Handles picFacebook.Click
        Try
            Dim sInfo As New System.Diagnostics.ProcessStartInfo("https://www.facebook.com/OtorAlQuran") With {
                .UseShellExecute = True
            }
            System.Diagnostics.Process.Start(sInfo)
        Catch ex As Exception
            MessageBox.Show("تعذر فتح رابط فيسبوك: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub picWhatsApp_Click(sender As Object, e As EventArgs) Handles picWhatsApp.Click
        Try
            Dim sInfo As New System.Diagnostics.ProcessStartInfo("https://wa.me/201015192541") With {
                .UseShellExecute = True
            }
            System.Diagnostics.Process.Start(sInfo)
        Catch ex As Exception
            MessageBox.Show("تعذر فتح رابط واتساب: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
