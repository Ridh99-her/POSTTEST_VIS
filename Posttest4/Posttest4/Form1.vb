Imports System.IO

Public Class Form1


    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png"
            If ofd.ShowDialog() = DialogResult.OK Then
                picProfil.Image = Image.FromFile(ofd.FileName)
                picProfil.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End Using
    End Sub


    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click

        If txtNama.Text = "" Or txtID.Text = "" Or txtEmail.Text = "" Or txtAlamat.Text = "" Or cmbDivisi.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        If Not mskTelp.MaskFull Then
            MessageBox.Show("Format nomor telepon tidak sesuai!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        Dim minatTerpilih As String = ""
        Dim countMinat As Integer = 0
        For Each ctrl As Control In gbMinat.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim chk = DirectCast(ctrl, CheckBox)
                If chk.Checked Then
                    minatTerpilih &= chk.Text & ", "
                    countMinat += 1
                End If
            End If
        Next

        If countMinat = 0 Then
            MessageBox.Show("Pilih minimal satu Hobby!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        Dim tanya = MessageBox.Show("Konfirmasi cetak kartu?", "Cetak", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tanya = DialogResult.Yes Then
            Dim f2 As New FormKartu()

            f2.lblNama.Text = txtNama.Text.ToUpper()
            f2.lblID.Text = "ID: " & txtID.Text
            f2.lblKomunitas.Text = cmbDivisi.Text
            f2.lblKontak.Text = mskTelp.Text
            f2.lblHobby.Text = minatTerpilih.TrimEnd(", ".ToCharArray())

            If picProfil.Image IsNot Nothing Then
                f2.picFotoKartu.Image = picProfil.Image
            End If

            f2.Show()
        End If
    End Sub


    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim res = MessageBox.Show("Keluar dari aplikasi?", "Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If res = DialogResult.Yes Then Application.Exit()
    End Sub

End Class