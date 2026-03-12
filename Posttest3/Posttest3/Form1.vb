Public Class Form1

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim OpenFile As New OpenFileDialog
        OpenFile.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        If OpenFile.ShowDialog = DialogResult.OK Then
            PicFoto.Image = Image.FromFile(OpenFile.FileName)
            PicFoto.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub


    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        Dim f2 As New Form2


        f2.picHasil.Image = PicFoto.Image


        f2.lblNamaHasil.Text = txtNama.Text
        f2.lblUmurHasil.Text = txtUmur.Text
        f2.lblTglHasil.Text = dtplahir.Value.ToString("dd/MM/yyyy")
        f2.lblTelpHasil.Text = txtTelpon.Text
        f2.lblAlamtHasil.Text = txtAlamat.Text


        If rbLaki.Checked Then
            f2.lblJKHasil.Text = "Laki-Laki"
        ElseIf rbPerempuan.Checked Then
            f2.lblJKHasil.Text = "Perempuan"
        End If


        Dim hobi As String = ""

        For Each ctrl As Control In gbHobby.Controls
            If TypeOf ctrl Is CheckBox Then
                If DirectCast(ctrl, CheckBox).Checked Then
                    hobi &= DirectCast(ctrl, CheckBox).Text & ", "
                End If
            End If
        Next

        f2.lblHobbyHasil.Text = hobi.TrimEnd(", ".ToCharArray())


        f2.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PicFoto_Click(sender As Object, e As EventArgs) Handles PicFoto.Click

    End Sub
End Class