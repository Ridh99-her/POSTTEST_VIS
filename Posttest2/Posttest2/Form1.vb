Public Class Form1


    Private Function ApakahBukuAda(ByVal judul As String) As Boolean
        Return daftarBuku.Contains(judul)
    End Function


    Private Sub RefreshList(ByVal listBox As ListBox)
        listBox.Items.Clear()
        For Each buku In daftarBuku
            listBox.Items.Add(buku)
        Next
    End Sub


    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim judul As String = txtJudulTambah.Text
        Dim genre As String = txtGenre.Text

        If judul <> "" And genre <> "" Then
            Dim dataLengkap As String = $"{judul} ({genre})"


            daftarBuku.Add(dataLengkap)


            RefreshList(ListBoxBuku)


            txtJudulTambah.Clear()
            txtGenre.Clear()
        Else
            MessageBox.Show("Mohon isi Judul dan Genre!")
        End If
    End Sub


    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim cariJudul As String = txtJudulHapus.Text
        Dim ditemukan As Boolean = False


        For i As Integer = daftarBuku.Count - 1 To 0 Step -1

            If daftarBuku(i).ToLower().StartsWith(cariJudul.ToLower()) Then
                daftarBuku.RemoveAt(i)
                ditemukan = True
            End If
        Next

        If ditemukan Then
            RefreshList(ListBoxBuku)
            txtJudulHapus.Clear()
            MessageBox.Show("Buku berhasil dihapus.")
        Else
            MessageBox.Show("Buku tidak ditemukan!")
        End If
    End Sub

End Class