Imports MySql.Data.MySqlClient

Module ModuleKoneksi
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public dr As MySqlDataReader
    ' Sesuaikan nama database dengan milikmu
    Public str As String = "server=localhost;user id=root;password=;database=db_inventaris"

    Public Sub BukaKoneksi()
        Try
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi Database Gagal: " & ex.Message)
        End Try
    End Sub
End Module