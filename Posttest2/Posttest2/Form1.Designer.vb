<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        btnTambah = New Button()
        Label1 = New Label()
        txtGenre = New TextBox()
        txtJudulTambah = New TextBox()
        GroupBox2 = New GroupBox()
        btnHapus = New Button()
        Label3 = New Label()
        txtJudulHapus = New TextBox()
        ListBoxBuku = New ListBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(btnTambah)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtGenre)
        GroupBox1.Controls.Add(txtJudulTambah)
        GroupBox1.Location = New Point(12, 25)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(219, 136)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tambah Buku"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 15)
        Label2.TabIndex = 2
        Label2.Text = "Genre"
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.DarkSeaGreen
        btnTambah.FlatStyle = FlatStyle.Flat
        btnTambah.Location = New Point(107, 107)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(75, 23)
        btnTambah.TabIndex = 1
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 15)
        Label1.TabIndex = 1
        Label1.Text = "Judul buku"
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(82, 61)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(100, 23)
        txtGenre.TabIndex = 2
        ' 
        ' txtJudulTambah
        ' 
        txtJudulTambah.Location = New Point(82, 22)
        txtJudulTambah.Name = "txtJudulTambah"
        txtJudulTambah.Size = New Size(100, 23)
        txtJudulTambah.TabIndex = 1
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnHapus)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(txtJudulHapus)
        GroupBox2.Location = New Point(329, 25)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(249, 130)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hapus Buku"
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.DarkSeaGreen
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Location = New Point(155, 101)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(75, 23)
        btnHapus.TabIndex = 2
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(27, 37)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 15)
        Label3.TabIndex = 1
        Label3.Text = "Judul"
        ' 
        ' txtJudulHapus
        ' 
        txtJudulHapus.Location = New Point(130, 38)
        txtJudulHapus.Name = "txtJudulHapus"
        txtJudulHapus.Size = New Size(100, 23)
        txtJudulHapus.TabIndex = 0
        ' 
        ' ListBoxBuku
        ' 
        ListBoxBuku.FormattingEnabled = True
        ListBoxBuku.Location = New Point(181, 186)
        ListBoxBuku.Name = "ListBoxBuku"
        ListBoxBuku.Size = New Size(173, 124)
        ListBoxBuku.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(605, 307)
        Controls.Add(ListBoxBuku)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        ForeColor = Color.White
        Name = "Form1"
        Text = "Perpustakaan yang dijanjikan 3000 tahun lalu"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtJudulTambah As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtJudulHapus As TextBox
    Friend WithEvents ListBoxBuku As ListBox

End Class
