Imports MySql.Data.MySqlClient

Public Class Form2
    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TampilData()
    End Sub

    Sub TampilData()
        Call BukaKoneksi()
        da = New MySqlDataAdapter("SELECT * FROM tabel_barang", conn)
        ds = New DataSet
        da.Fill(ds, "tabel_barang")
        DataGridView1.DataSource = ds.Tables("tabel_barang")
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KondisiAwal()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Data belum lengkap!")
        Else
            Call BukaKoneksi()
            Dim simpan As String = "INSERT INTO tabel_barang VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')"
            cmd = New MySqlCommand(simpan, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan")
            KondisiAwal()
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub


    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Call BukaKoneksi()
        da = New MySqlDataAdapter("SELECT * FROM tabel_barang WHERE nama_barang LIKE '%" & TextBox3.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds, "tabel_barang")
        DataGridView1.DataSource = ds.Tables("tabel_barang")
    End Sub
End Class