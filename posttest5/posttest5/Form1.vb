Imports MySql.Data.MySqlClient

Public Class Form1

    Dim connString As String = "server=localhost;user id=root;password=;database=db_alutsista"
    Dim conn As MySqlConnection
    Dim dtAlutsista As New DataTable

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbJenis.Items.Clear()
        cmbJenis.Items.Add("Tank")
        cmbJenis.Items.Add("Pesawat Tempur")
        cmbJenis.Items.Add("Kapal Perang")
        cmbJenis.Items.Add("Rudal")


        cmbStatus.Items.Clear()
        cmbStatus.Items.Add("Aktif")
        cmbStatus.Items.Add("Maintenance")
        cmbStatus.Items.Add("Non-Aktif")

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
            MessageBox.Show("Koneksi Gagal! Pastikan MySQL di XAMPP sudah RUNNING." & vbCrLf & "Error: " & ex.Message)
        End Try
    End Sub

    Sub UpdateDashboard()

        If dtAlutsista IsNot Nothing AndAlso dtAlutsista.Rows.Count > 0 Then
            Dim total As Integer = dtAlutsista.Rows.Count

            Dim jmlLeopard = dtAlutsista.Select("nama LIKE '%Leopard%'").Length
            Dim jmlK2 = dtAlutsista.Select("nama LIKE '%K2%'").Length

            lblTotal.Text = "TOTAL: " & total & " UNIT"
            lblSummary.Text = "Leopard: " & jmlLeopard & vbCrLf & "K2 Black Panther: " & jmlK2
        Else
            lblTotal.Text = "TOTAL: 0 UNIT"
            lblSummary.Text = "Leopard: 0" & vbCrLf & "K2 Black Panther: 0"
        End If
    End Sub

    Sub ClearInput()
        txtID.Clear()
        txtNama.Clear()
        cmbJenis.SelectedIndex = -1
        cmbStatus.SelectedIndex = -1
        txtID.Focus()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If txtID.Text = "" Or txtNama.Text = "" Or cmbJenis.Text = "" Or cmbStatus.Text = "" Then
            MessageBox.Show("Mohon lengkapi semua data sebelum simpan!")
            Exit Sub
        End If

        Try
            conn = New MySqlConnection(connString)

            Dim cmd As New MySqlCommand("INSERT INTO tabel_alutsista (id, nama, jenis, status) VALUES (@id, @nama, @jenis, @status)", conn)

            cmd.Parameters.AddWithValue("@id", txtID.Text)
            cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            cmd.Parameters.AddWithValue("@jenis", cmbJenis.Text)
            cmd.Parameters.AddWithValue("@status", cmbStatus.Text)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()


            TampilData()
            ClearInput()
            MessageBox.Show("Data Alutsista Berhasil Disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Gagal Simpan ke Database! Error: " & ex.Message)
        Finally

            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub dgvAlutsista_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvAlutsista.CellFormatting

        If e.ColumnIndex = 3 AndAlso e.Value IsNot Nothing Then
            Dim status As String = e.Value.ToString()
            If status = "Aktif" Then
                e.CellStyle.BackColor = Color.LightGreen
                e.CellStyle.ForeColor = Color.Black
            ElseIf status = "Maintenance" Then
                e.CellStyle.BackColor = Color.Yellow
                e.CellStyle.ForeColor = Color.Black
            ElseIf status = "Non-Aktif" Then
                e.CellStyle.BackColor = Color.LightPink
            End If
        End If
    End Sub
End Class