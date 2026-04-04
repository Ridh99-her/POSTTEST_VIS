<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        txtNama = New TextBox()
        txtID = New TextBox()
        cmbDivisi = New ComboBox()
        TabPage2 = New TabPage()
        mskTelp = New MaskedTextBox()
        txtEmail = New TextBox()
        txtAlamat = New TextBox()
        TabPage3 = New TabPage()
        picProfil = New PictureBox()
        btnBrowse = New Button()
        gbMinat = New GroupBox()
        CheckBox6 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnSimpanCetak = New Button()
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        CType(picProfil, ComponentModel.ISupportInitialize).BeginInit()
        gbMinat.SuspendLayout()
        SuspendLayout()

        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, SimpanDataToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(484, 24)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"

        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(74, 20)
        InputDataToolStripMenuItem.Text = "Input Data"

        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(86, 20)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"

        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(52, 20)
        KeluarToolStripMenuItem.Text = "Keluar"

        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(12, 36)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(460, 350)
        TabControl1.TabIndex = 1

        TabPage1.Controls.Add(txtNama)
        TabPage1.Controls.Add(txtID)
        TabPage1.Controls.Add(cmbDivisi)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Size = New Size(452, 322)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"

        txtNama.Location = New Point(20, 30)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Masukkan Nama Lengkap"
        txtNama.Size = New Size(200, 23)
        txtNama.TabIndex = 0


        txtID.Location = New Point(20, 70)
        txtID.Name = "txtID"
        txtID.PlaceholderText = "Masukkan ID Anggota"
        txtID.Size = New Size(200, 23)
        txtID.TabIndex = 1

        cmbDivisi.Items.AddRange(New Object() {"Web Developer", "Mobile Dev", "UI/UX Designer", "Cyber Security"})
        cmbDivisi.Location = New Point(20, 110)
        cmbDivisi.Name = "cmbDivisi"
        cmbDivisi.Size = New Size(200, 23)
        cmbDivisi.TabIndex = 2

        TabPage2.Controls.Add(mskTelp)
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Controls.Add(txtAlamat)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Size = New Size(452, 322)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak"

        mskTelp.Location = New Point(20, 30)
        mskTelp.Mask = "0000-0000-0000"
        mskTelp.Name = "mskTelp"
        mskTelp.Size = New Size(200, 23)
        mskTelp.TabIndex = 0

        txtEmail.Location = New Point(20, 70)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email@domain.com"
        txtEmail.Size = New Size(200, 23)
        txtEmail.TabIndex = 1

        txtAlamat.Location = New Point(20, 110)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(200, 60)
        txtAlamat.TabIndex = 2

        TabPage3.Controls.Add(picProfil)
        TabPage3.Controls.Add(btnBrowse)
        TabPage3.Controls.Add(gbMinat)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(452, 322)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Lainnya"

        picProfil.BorderStyle = BorderStyle.FixedSingle
        picProfil.Location = New Point(20, 20)
        picProfil.Name = "picProfil"
        picProfil.Size = New Size(100, 100)
        picProfil.TabIndex = 0
        picProfil.TabStop = False

        btnBrowse.Location = New Point(130, 97)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(75, 23)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Pilih Foto"

        gbMinat.Controls.Add(CheckBox6)
        gbMinat.Controls.Add(CheckBox5)
        gbMinat.Controls.Add(CheckBox4)
        gbMinat.Controls.Add(CheckBox3)
        gbMinat.Controls.Add(CheckBox2)
        gbMinat.Controls.Add(CheckBox1)
        gbMinat.Location = New Point(20, 140)
        gbMinat.Name = "gbMinat"
        gbMinat.Size = New Size(400, 100)
        gbMinat.TabIndex = 2
        gbMinat.TabStop = False
        gbMinat.Text = "Pilih Hobby / Minat"

        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(236, 47)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(68, 19)
        CheckBox6.TabIndex = 5
        CheckBox6.Text = "Gaming"
        CheckBox6.UseVisualStyleBackColor = True

        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(230, 19)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(96, 19)
        CheckBox5.TabIndex = 4
        CheckBox5.Text = "UI/UX Design"
        CheckBox5.UseVisualStyleBackColor = True

        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(128, 46)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(88, 19)
        CheckBox4.TabIndex = 3
        CheckBox4.Text = "Networking"
        CheckBox4.UseVisualStyleBackColor = True

        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(125, 21)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(90, 19)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "Video Editor"
        CheckBox3.UseVisualStyleBackColor = True

        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(5, 46)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(61, 19)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "Music "
        CheckBox2.UseVisualStyleBackColor = True

        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(6, 22)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(65, 19)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Coding"
        CheckBox1.UseVisualStyleBackColor = True

        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 23)
        Label1.TabIndex = 0

        Label2.Location = New Point(0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 23)
        Label2.TabIndex = 0

        Label3.Location = New Point(0, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 23)
        Label3.TabIndex = 0

        btnSimpanCetak.Location = New Point(12, 400)
        btnSimpanCetak.Name = "btnSimpanCetak"
        btnSimpanCetak.Size = New Size(460, 40)
        btnSimpanCetak.TabIndex = 0
        btnSimpanCetak.Text = "SIMPAN DAN CETAK KARTU"

        ClientSize = New Size(484, 461)
        Controls.Add(btnSimpanCetak)
        Controls.Add(TabControl1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Aplikasi Pendaftaran Komunitas IT"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        CType(picProfil, ComponentModel.ISupportInitialize).EndInit()
        gbMinat.ResumeLayout(False)
        gbMinat.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents cmbDivisi As ComboBox
    Friend WithEvents mskTelp As MaskedTextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents picProfil As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents gbMinat As GroupBox
    Friend WithEvents btnSimpanCetak As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
End Class