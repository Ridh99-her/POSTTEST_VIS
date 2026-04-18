Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim dt As DataTable

    Dim connString As String = "server=localhost;user id=root;password=;database=db_alutsista"


    Sub IsiComboKategori()
        Try
            conn = New MySqlConnection(connString)
            Dim query As String = "SELECT id_kategori, nama_kategori FROM tabel_kategori"
            da = New MySqlDataAdapter(query, conn)
            Dim dtKategori As New DataTable
            da.Fill(dtKategori)

            cmbJenis.DataSource = dtKategori
            cmbJenis.DisplayMember = "nama_kategori"
            cmbJenis.ValueMember = "id_kategori"

            cmbJenis.SelectedIndex = -1
        Catch ex As Exception
            MsgBox("Gagal Load Kategori: " & ex.Message)
        End Try
    End Sub


    Sub TampilData()
        Try
            conn = New MySqlConnection(connString)

            Dim query As String = "SELECT a.id, a.nama, k.nama_kategori AS jenis, a.status " &
                                 "FROM tabel_alutsista a " &
                                 "INNER JOIN tabel_kategori k ON a.id_kategori = k.id_kategori"

            da = New MySqlDataAdapter(query, conn)
            dt = New DataTable
            da.Fill(dt)
            dgvData.DataSource = dt
        Catch ex As Exception

            MsgBox("Gagal Tampil Data: " & ex.Message)
        End Try
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsiComboKategori()


        cmbStatus.Items.Clear()
        cmbStatus.Items.Add("Aktif")
        cmbStatus.Items.Add("Cadangan")
        cmbStatus.Items.Add("Perbaikan")

        TampilData()
    End Sub


    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If txtID.Text = "" Or txtNama.Text = "" Or cmbJenis.SelectedIndex = -1 Then
            MsgBox("Lengkapi data terlebih dahulu!")
            Exit Sub
        End If

        Try
            conn = New MySqlConnection(connString)
            conn.Open()


            Dim query As String = "INSERT INTO tabel_alutsista (id, nama, id_kategori, status) " &
                                 "VALUES (@id, @nama, @kat, @status)"

            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", txtID.Text)
            cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            cmd.Parameters.AddWithValue("@kat", cmbJenis.SelectedValue) ' Mengirim angka ID
            cmd.Parameters.AddWithValue("@status", cmbStatus.Text)

            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan!")


            txtID.Clear()
            txtNama.Clear()
            cmbJenis.SelectedIndex = -1

            TampilData()
            conn.Close()
        Catch ex As Exception
            MsgBox("Gagal Simpan: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class