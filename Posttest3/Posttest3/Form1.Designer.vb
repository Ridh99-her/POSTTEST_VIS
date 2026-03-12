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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PicFoto = New PictureBox()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtTelpon = New TextBox()
        rbLaki = New RadioButton()
        rbPerempuan = New RadioButton()
        dtplahir = New DateTimePicker()
        btnBrowse = New Button()
        btnCetak = New Button()
        gbHobby = New GroupBox()
        chkMusic = New CheckBox()
        chkReading = New CheckBox()
        chkCoding = New CheckBox()
        chkGaming = New CheckBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtAlamat = New TextBox()
        Label5 = New Label()
        Panel1 = New Panel()
        Label6 = New Label()
        Panel2 = New Panel()
        CType(PicFoto, ComponentModel.ISupportInitialize).BeginInit()
        gbHobby.SuspendLayout()
        SuspendLayout()
        ' 
        ' PicFoto
        ' 
        PicFoto.Image = CType(resources.GetObject("PicFoto.Image"), Image)
        PicFoto.Location = New Point(22, 49)
        PicFoto.Name = "PicFoto"
        PicFoto.Size = New Size(144, 192)
        PicFoto.SizeMode = PictureBoxSizeMode.StretchImage
        PicFoto.TabIndex = 0
        PicFoto.TabStop = False
        PicFoto.UseWaitCursor = True
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(225, 67)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(100, 23)
        txtNama.TabIndex = 1
        txtNama.UseWaitCursor = True
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(225, 111)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(100, 23)
        txtUmur.TabIndex = 2
        txtUmur.UseWaitCursor = True
        ' 
        ' txtTelpon
        ' 
        txtTelpon.Location = New Point(223, 155)
        txtTelpon.Name = "txtTelpon"
        txtTelpon.Size = New Size(100, 23)
        txtTelpon.TabIndex = 3
        txtTelpon.UseWaitCursor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(517, 169)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(69, 19)
        rbLaki.TabIndex = 5
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-laki"
        rbLaki.UseVisualStyleBackColor = True
        rbLaki.UseWaitCursor = True
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(555, 194)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(86, 19)
        rbPerempuan.TabIndex = 6
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        rbPerempuan.UseWaitCursor = True
        ' 
        ' dtplahir
        ' 
        dtplahir.Format = DateTimePickerFormat.Short
        dtplahir.Location = New Point(170, 256)
        dtplahir.MaxDate = New Date(2026, 3, 25, 23, 59, 59, 0)
        dtplahir.Name = "dtplahir"
        dtplahir.Size = New Size(200, 23)
        dtplahir.TabIndex = 11
        dtplahir.UseWaitCursor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(197, 304)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(75, 23)
        btnBrowse.TabIndex = 13
        btnBrowse.Text = "Pilih Foto"
        btnBrowse.UseVisualStyleBackColor = True
        btnBrowse.UseWaitCursor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(313, 306)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(75, 23)
        btnCetak.TabIndex = 14
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = True
        btnCetak.UseWaitCursor = True
        ' 
        ' gbHobby
        ' 
        gbHobby.BackColor = SystemColors.ControlLightLight
        gbHobby.Controls.Add(chkMusic)
        gbHobby.Controls.Add(chkReading)
        gbHobby.Controls.Add(chkCoding)
        gbHobby.Controls.Add(chkGaming)
        gbHobby.Location = New Point(394, 229)
        gbHobby.Name = "gbHobby"
        gbHobby.Size = New Size(332, 129)
        gbHobby.TabIndex = 15
        gbHobby.TabStop = False
        gbHobby.Text = "Hobi"
        gbHobby.UseWaitCursor = True
        ' 
        ' chkMusic
        ' 
        chkMusic.AutoSize = True
        chkMusic.Location = New Point(180, 75)
        chkMusic.Name = "chkMusic"
        chkMusic.Size = New Size(103, 19)
        chkMusic.TabIndex = 14
        chkMusic.Text = "Dengerin Lagu"
        chkMusic.UseVisualStyleBackColor = True
        chkMusic.UseWaitCursor = True
        ' 
        ' chkReading
        ' 
        chkReading.AutoSize = True
        chkReading.Location = New Point(165, 32)
        chkReading.Name = "chkReading"
        chkReading.Size = New Size(79, 19)
        chkReading.TabIndex = 13
        chkReading.Text = "Membaca"
        chkReading.UseVisualStyleBackColor = True
        chkReading.UseWaitCursor = True
        ' 
        ' chkCoding
        ' 
        chkCoding.AutoSize = True
        chkCoding.Location = New Point(57, 33)
        chkCoding.Name = "chkCoding"
        chkCoding.Size = New Size(65, 19)
        chkCoding.TabIndex = 12
        chkCoding.Text = "Coding"
        chkCoding.UseVisualStyleBackColor = True
        chkCoding.UseWaitCursor = True
        ' 
        ' chkGaming
        ' 
        chkGaming.AutoSize = True
        chkGaming.Location = New Point(106, 75)
        chkGaming.Name = "chkGaming"
        chkGaming.Size = New Size(68, 19)
        chkGaming.TabIndex = 11
        chkGaming.Text = "Gaming"
        chkGaming.UseVisualStyleBackColor = True
        chkGaming.UseWaitCursor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(225, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 16
        Label1.Text = "Nama"
        Label1.UseWaitCursor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(223, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 15)
        Label2.TabIndex = 17
        Label2.Text = "Umur"
        Label2.UseWaitCursor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(223, 137)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 15)
        Label3.TabIndex = 18
        Label3.Text = "Telpon"
        Label3.UseWaitCursor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(223, 181)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 15)
        Label4.TabIndex = 19
        Label4.Text = "Alamat"
        Label4.UseWaitCursor = True
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(225, 199)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(100, 23)
        txtAlamat.TabIndex = 4
        txtAlamat.UseWaitCursor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(223, 229)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 15)
        Label5.TabIndex = 20
        Label5.Text = "Tanggal Lahir"
        Label5.UseWaitCursor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Location = New Point(12, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(790, 38)
        Panel1.TabIndex = 21
        Panel1.UseWaitCursor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(370, 49)
        Label6.Name = "Label6"
        Label6.Size = New Size(346, 22)
        Label6.TabIndex = 0
        Label6.Text = "SECURITY SERVICE WHITE WATER "
        Label6.TextAlign = ContentAlignment.TopCenter
        Label6.UseWaitCursor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.Location = New Point(-8, 410)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(810, 38)
        Panel2.TabIndex = 22
        Panel2.UseWaitCursor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel2)
        Controls.Add(Label6)
        Controls.Add(Panel1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(gbHobby)
        Controls.Add(btnCetak)
        Controls.Add(btnBrowse)
        Controls.Add(dtplahir)
        Controls.Add(rbPerempuan)
        Controls.Add(rbLaki)
        Controls.Add(txtAlamat)
        Controls.Add(txtTelpon)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(PicFoto)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pendaftaran Kartu Komunitas"
        UseWaitCursor = True
        CType(PicFoto, ComponentModel.ISupportInitialize).EndInit()
        gbHobby.ResumeLayout(False)
        gbHobby.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PicFoto As PictureBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtTelpon As TextBox
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents dtplahir As DateTimePicker
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents gbHobby As GroupBox
    Friend WithEvents chkMusic As CheckBox
    Friend WithEvents chkReading As CheckBox
    Friend WithEvents chkCoding As CheckBox
    Friend WithEvents chkGaming As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel

End Class
