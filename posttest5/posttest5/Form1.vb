Public Class Form1

    Dim dtAlutsista As New DataTable

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SetupComboBoxes()


        If dtAlutsista.Columns.Count = 0 Then
            dtAlutsista.Columns.Add("ID")
            dtAlutsista.Columns.Add("NAMA")
            dtAlutsista.Columns.Add("JENIS")
            dtAlutsista.Columns.Add("STATUS")
        End If

        dtAlutsista.Rows.Add("V-001", "Leopard 2RI", "Main Battle Tank", "Aktif")
        dtAlutsista.Rows.Add("V-002", "Leopard 2A4", "Main Battle Tank", "Reserve")
        dtAlutsista.Rows.Add("V-003", "K2 Black Panther", "Main Battle Tank", "Aktif")
        dtAlutsista.Rows.Add("V-004", "K21 IFV", "IFV (Infantry Fighting Vehicle)", "Maintenance")
        dtAlutsista.Rows.Add("V-005", "Harimau Medium Tank", "Medium Tank", "Aktif")


        dgvAlutsista.AutoGenerateColumns = False
        dgvAlutsista.DataSource = dtAlutsista


        UpdateDashboard()
    End Sub

    Sub SetupComboBoxes()
        cmbJenis.Items.Clear()
        cmbJenis.Items.AddRange({"Main Battle Tank", "APC (Armored Personnel Carrier)", "IFV (Infantry Fighting Vehicle)", "Self-Propelled Artillery", "Medium Tank"})

        cmbStatus.Items.Clear()
        cmbStatus.Items.AddRange({"Aktif", "Reserve", "Maintenance"})

        cmbJenis.SelectedIndex = 0
        cmbStatus.SelectedIndex = 0
    End Sub

    Sub UpdateDashboard()

        Dim total As Integer = dtAlutsista.Rows.Count


        Dim jmlLeopard = dtAlutsista.Select("NAMA LIKE '%Leopard%'").Length
        Dim jmlK2 = dtAlutsista.Select("NAMA LIKE '%K2 %' OR NAMA LIKE 'K2 %'").Length
        Dim jmlK21 = dtAlutsista.Select("NAMA LIKE '%K21%'").Length
        Dim jmlMedium = dtAlutsista.Select("JENIS = 'Medium Tank'").Length

        lblTotal.Text = "TOTAL ALUTSISTA: " & total & " UNIT"

        lblSummary.Text = "STATISTIK KEKUATAN:" & vbCrLf &
                         "----------------------------" & vbCrLf &
                         "• MBT Leopard 2 : " & jmlLeopard & " Unit" & vbCrLf &
                         "• MBT K2 Panther : " & jmlK2 & " Unit" & vbCrLf &
                         "• IFV K21        : " & jmlK21 & " Unit" & vbCrLf &
                         "• Medium Tank    : " & jmlMedium & " Unit"
    End Sub


    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtID.Text = "" Or txtNama.Text = "" Then
            MessageBox.Show("Mohon lengkapi ID dan Nama unit!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        dtAlutsista.Rows.Add(txtID.Text, txtNama.Text, cmbJenis.Text, cmbStatus.Text)
        UpdateDashboard()
        ClearInput()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dgvAlutsista.SelectedRows.Count > 0 Then
            Dim nama = dgvAlutsista.SelectedRows(0).Cells(1).Value.ToString()
            If MessageBox.Show("Hapus unit " & nama & "?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                dgvAlutsista.Rows.RemoveAt(dgvAlutsista.SelectedRows(0).Index)
                UpdateDashboard()
            End If
        End If
    End Sub


    Private Sub dgvAlutsista_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvAlutsista.CellFormatting
        If e.ColumnIndex = 3 AndAlso e.Value IsNot Nothing Then
            Dim status As String = e.Value.ToString()
            Dim row As DataGridViewRow = dgvAlutsista.Rows(e.RowIndex)

            Select Case status
                Case "Aktif" : row.DefaultCellStyle.BackColor = Color.LightBlue
                Case "Reserve" : row.DefaultCellStyle.BackColor = Color.LightGreen
                Case "Maintenance" : row.DefaultCellStyle.BackColor = Color.Yellow
            End Select
        End If
    End Sub


    Private Sub dgvAlutsista_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlutsista.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvAlutsista.Rows(e.RowIndex)
            txtID.Text = row.Cells(0).Value.ToString()
            txtNama.Text = row.Cells(1).Value.ToString()
            cmbJenis.Text = row.Cells(2).Value.ToString()
            cmbStatus.Text = row.Cells(3).Value.ToString()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        dtAlutsista.DefaultView.RowFilter = String.Format("NAMA LIKE '%{0}%'", txtSearch.Text)
    End Sub

    Sub ClearInput()
        txtID.Clear() : txtNama.Clear()
        cmbJenis.SelectedIndex = 0 : cmbStatus.SelectedIndex = 0
        txtID.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInput()
    End Sub
End Class