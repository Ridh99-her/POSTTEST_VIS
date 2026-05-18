Imports MySql.Data.MySqlClient

Public Class Form3
    Sub TampilMonitoring()
        Call BukaKoneksi()

        da = New MySqlDataAdapter("SELECT * FROM tabel_monitoring", conn)
        ds = New DataSet
        da.Fill(ds, "tabel_monitoring")
        DataGridView1.DataSource = ds.Tables("tabel_monitoring")
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilMonitoring()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()
        Me.Hide()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class