
Imports MySql.Data.MySqlClient

Public Class Form1

    Dim connString As String = "server=localhost;user id=root;password=;database=db_alutsista"
    Dim conn As MySqlConnection
    Dim dtAlutsista As New DataTable

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TampilData()
    End Sub


    Sub TampilData()
        Try
            conn = New MySqlConnection(connString)
            Dim da As New MySqlDataAdapter("SELECT * FROM tabel_alutsista", conn)
            dtAlutsista = New DataTable
            da.Fill(dtAlutsista)
            dgvAlutsista.DataSource = dtAlutsista
            UpdateDashboard()
        Catch ex As Exception

            MessageBox.Show("Koneksi Gagal! Pastikan MySQL di XAMPP sudah RUNNING. Error: " & ex.Message)
        End Try
    End Sub


    Sub UpdateDashboard()
        Dim total As Integer = dtAlutsista.Rows.Count

        Dim jmlLeopard = dtAlutsista.Select("nama LIKE '%Leopard%'").Length
        Dim jmlK2 = dtAlutsista.Select("nama LIKE '%K2%'").Length

        lblTotal.Text = "TOTAL: " & total & " UNIT"
        lblSummary.Text = "Leopard: " & jmlLeopard & vbCrLf & "K2 Black Panther: " & jmlK2
    End Sub


    Sub ClearInput()
        txtID.Clear()
        txtNama.Clear()
        txtID.Focus()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Try
            conn = New MySqlConnection(connString)

            Dim cmd As New MySqlCommand("INSERT INTO tabel_alutsista VALUES (@id, @nama, @jenis, @status)", conn)
            cmd.Parameters.AddWithValue("@id", txtID.Text)
            cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            cmd.Parameters.AddWithValue("@jenis", cmbJenis.Text)
            cmd.Parameters.AddWithValue("@status", cmbStatus.Text)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            TampilData()
            ClearInput()
            MessageBox.Show("Data Alutsista Berhasil Disimpan!")
        Catch ex As Exception
            MessageBox.Show("Gagal Simpan: " & ex.Message)
        End Try
    End Sub


    Private Sub dgvAlutsista_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvAlutsista.CellFormatting

        If e.ColumnIndex = 3 AndAlso e.Value IsNot Nothing Then
            Dim status As String = e.Value.ToString()
            If status = "Aktif" Then
                e.CellStyle.BackColor = Color.LightBlue
            ElseIf status = "Maintenance" Then
                e.CellStyle.BackColor = Color.Yellow
            End If
        End If
    End Sub
End Class