<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKartu
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
        lblNama = New Label()
        lblID = New Label()
        lblKomunitas = New Label()
        lblKontak = New Label()
        lblHobby = New Label()
        picFotoKartu = New PictureBox()
        btnTutup = New Button()
        Label1 = New Label()
        CType(picFotoKartu, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()

        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblNama.Location = New Point(170, 180)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(68, 21)
        lblNama.TabIndex = 5
        lblNama.Text = "[Nama]"

        lblID.AutoSize = True
        lblID.Location = New Point(170, 210)
        lblID.Name = "lblID"
        lblID.Size = New Size(26, 15)
        lblID.TabIndex = 4
        lblID.Text = "[ID]"

        lblKomunitas.AutoSize = True
        lblKomunitas.Location = New Point(170, 240)
        lblKomunitas.Name = "lblKomunitas"
        lblKomunitas.Size = New Size(72, 15)
        lblKomunitas.TabIndex = 3
        lblKomunitas.Text = "[Komunitas]"

        lblKontak.AutoSize = True
        lblKontak.Location = New Point(170, 275)
        lblKontak.Name = "lblKontak"
        lblKontak.Size = New Size(52, 15)
        lblKontak.TabIndex = 2
        lblKontak.Text = "[Kontak]"

        lblHobby.AutoSize = True
        lblHobby.Location = New Point(170, 305)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(51, 15)
        lblHobby.TabIndex = 1
        lblHobby.Text = "[Hobby]"

        picFotoKartu.BorderStyle = BorderStyle.FixedSingle
        picFotoKartu.Location = New Point(25, 180)
        picFotoKartu.Name = "picFotoKartu"
        picFotoKartu.Size = New Size(120, 150)
        picFotoKartu.SizeMode = PictureBoxSizeMode.StretchImage
        picFotoKartu.TabIndex = 6
        picFotoKartu.TabStop = False

        btnTutup.Location = New Point(150, 500)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(150, 40)
        btnTutup.TabIndex = 0
        btnTutup.Text = "Tutup Kartu"

        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 27.75F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(-2, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(440, 45)
        Label1.TabIndex = 7
        Label1.Text = "KARTU TANDA ANGGOTA"

        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(450, 600)
        Controls.Add(Label1)
        Controls.Add(btnTutup)
        Controls.Add(lblHobby)
        Controls.Add(lblKontak)
        Controls.Add(lblKomunitas)
        Controls.Add(lblID)
        Controls.Add(lblNama)
        Controls.Add(picFotoKartu)
        Name = "FormKartu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kartu Anggota"
        CType(picFotoKartu, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub


    Public WithEvents lblNama As System.Windows.Forms.Label
    Public WithEvents lblID As System.Windows.Forms.Label
    Public WithEvents lblKomunitas As System.Windows.Forms.Label
    Public WithEvents lblKontak As System.Windows.Forms.Label
    Public WithEvents lblHobby As System.Windows.Forms.Label
    Public WithEvents picFotoKartu As System.Windows.Forms.PictureBox
    Public WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label

End Class