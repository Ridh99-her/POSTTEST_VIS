<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        lblNamaHasil = New Label()
        lblUmurHasil = New Label()
        lblTglHasil = New Label()
        lblTelpHasil = New Label()
        lblJKHasil = New Label()
        lblHobbyHasil = New Label()
        lblAlamtHasil = New Label()
        picHasil = New Label()
        Panel1 = New Panel()
        Label6 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        PicFoto = New PictureBox()
        CType(PicFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblNamaHasil
        ' 
        lblNamaHasil.AutoSize = True
        lblNamaHasil.Location = New Point(167, 97)
        lblNamaHasil.Name = "lblNamaHasil"
        lblNamaHasil.Size = New Size(39, 15)
        lblNamaHasil.TabIndex = 1
        lblNamaHasil.Text = "Nama"
        ' 
        ' lblUmurHasil
        ' 
        lblUmurHasil.AutoSize = True
        lblUmurHasil.Location = New Point(167, 142)
        lblUmurHasil.Name = "lblUmurHasil"
        lblUmurHasil.Size = New Size(41, 15)
        lblUmurHasil.TabIndex = 2
        lblUmurHasil.Text = "Label3"
        ' 
        ' lblTglHasil
        ' 
        lblTglHasil.AutoSize = True
        lblTglHasil.Location = New Point(167, 181)
        lblTglHasil.Name = "lblTglHasil"
        lblTglHasil.Size = New Size(41, 15)
        lblTglHasil.TabIndex = 3
        lblTglHasil.Text = "Label4"
        ' 
        ' lblTelpHasil
        ' 
        lblTelpHasil.AutoSize = True
        lblTelpHasil.Location = New Point(167, 212)
        lblTelpHasil.Name = "lblTelpHasil"
        lblTelpHasil.Size = New Size(41, 15)
        lblTelpHasil.TabIndex = 4
        lblTelpHasil.Text = "Label5"
        ' 
        ' lblJKHasil
        ' 
        lblJKHasil.AutoSize = True
        lblJKHasil.Location = New Point(167, 238)
        lblJKHasil.Name = "lblJKHasil"
        lblJKHasil.Size = New Size(41, 15)
        lblJKHasil.TabIndex = 5
        lblJKHasil.Text = "Label1"
        ' 
        ' lblHobbyHasil
        ' 
        lblHobbyHasil.AutoSize = True
        lblHobbyHasil.Location = New Point(167, 268)
        lblHobbyHasil.Name = "lblHobbyHasil"
        lblHobbyHasil.Size = New Size(41, 15)
        lblHobbyHasil.TabIndex = 6
        lblHobbyHasil.Text = "Label2"
        ' 
        ' lblAlamtHasil
        ' 
        lblAlamtHasil.AutoSize = True
        lblAlamtHasil.Location = New Point(167, 300)
        lblAlamtHasil.Name = "lblAlamtHasil"
        lblAlamtHasil.Size = New Size(41, 15)
        lblAlamtHasil.TabIndex = 7
        lblAlamtHasil.Text = "Label1"
        ' 
        ' picHasil
        ' 
        picHasil.AutoSize = True
        picHasil.Location = New Point(267, 55)
        picHasil.Name = "picHasil"
        picHasil.Size = New Size(0, 15)
        picHasil.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Location = New Point(-25, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(827, 38)
        Panel1.TabIndex = 22
        Panel1.UseWaitCursor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(305, 55)
        Label6.Name = "Label6"
        Label6.Size = New Size(346, 22)
        Label6.TabIndex = 23
        Label6.Text = "SECURITY SERVICE WHITE WATER "
        Label6.TextAlign = ContentAlignment.TopCenter
        Label6.UseWaitCursor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(69, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 19)
        Label1.TabIndex = 24
        Label1.Text = "Operator "
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.Location = New Point(-8, 416)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(810, 38)
        Panel2.TabIndex = 25
        Panel2.UseWaitCursor = True
        ' 
        ' PicFoto
        ' 
        PicFoto.Image = CType(resources.GetObject("PicFoto.Image"), Image)
        PicFoto.Location = New Point(472, 114)
        PicFoto.Name = "PicFoto"
        PicFoto.Size = New Size(144, 192)
        PicFoto.SizeMode = PictureBoxSizeMode.StretchImage
        PicFoto.TabIndex = 27
        PicFoto.TabStop = False
        PicFoto.UseWaitCursor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PicFoto)
        Controls.Add(Panel2)
        Controls.Add(Label1)
        Controls.Add(Label6)
        Controls.Add(Panel1)
        Controls.Add(lblAlamtHasil)
        Controls.Add(lblHobbyHasil)
        Controls.Add(lblJKHasil)
        Controls.Add(lblTelpHasil)
        Controls.Add(lblTglHasil)
        Controls.Add(lblUmurHasil)
        Controls.Add(lblNamaHasil)
        Controls.Add(picHasil)
        Name = "Form2"
        Text = "Form2"
        CType(PicFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblNamaHasil As Label
    Friend WithEvents lblUmurHasil As Label
    Friend WithEvents lblTglHasil As Label
    Friend WithEvents lblTelpHasil As Label
    Friend WithEvents lblJKHasil As Label
    Friend WithEvents lblHobbyHasil As Label
    Friend WithEvents lblAlamtHasil As Label
    Friend WithEvents picHasil As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PicFoto As PictureBox
End Class
