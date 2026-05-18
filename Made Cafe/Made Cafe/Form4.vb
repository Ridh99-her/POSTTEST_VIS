Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Bisa diisi kodingan untuk memanggil data detail
    End Sub

    ' Tombol Kembali ke Monitoring (Form 3)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()
    End Sub

    ' Jika ingin menambahkan fungsi cetak sederhana
    Private Sub ButtonCetak_Click(sender As Object, e As EventArgs)
        ' Print Dialog atau Print Preview bisa diletakkan di sini
        MsgBox("Fungsi cetak sedang disiapkan...")
    End Sub
End Class