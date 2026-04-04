Public Class FormKartu

    Private Sub FormKartu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblNama.BackColor = Color.Transparent
        lblID.BackColor = Color.Transparent
        lblKomunitas.BackColor = Color.Transparent
        lblKontak.BackColor = Color.Transparent
        lblHobby.BackColor = Color.Transparent


        picFotoKartu.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

End Class