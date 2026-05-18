Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim tanya As MsgBoxResult = MsgBox("Apakah anda yakin ingin keluar?", MsgBoxStyle.YesNo, "Konfirmasi")
        If tanya = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class