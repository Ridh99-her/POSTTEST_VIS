<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Panel1 = New Panel()
        TextBox1 = New TextBox()
        Label2 = New Label()
        ComboBox1 = New ComboBox()
        Button2 = New Button()
        Button1 = New Button()
        Label5 = New Label()
        NumericUpDown1 = New NumericUpDown()
        TextBox3 = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Panel1.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(NumericUpDown1)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(82, 36)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(603, 291)
        Panel1.TabIndex = 0
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(191, 183)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(232, 23)
        TextBox1.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ButtonFace
        Label2.Font = New Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(59, 187)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 19)
        Label2.TabIndex = 11
        Label2.Text = " Total Harga"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(191, 79)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(232, 23)
        ComboBox1.TabIndex = 10
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Button2.Font = New Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(481, 245)
        Button2.Name = "Button2"
        Button2.Size = New Size(100, 31)
        Button2.TabIndex = 9
        Button2.Text = "Cetak"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Button1.Font = New Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(19, 245)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 31)
        Button1.TabIndex = 1
        Button1.Text = "Kembali"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ButtonFace
        Label5.Font = New Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(59, 154)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 19)
        Label5.TabIndex = 8
        Label5.Text = "Jumlah Menu"
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(191, 150)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(232, 23)
        NumericUpDown1.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(191, 112)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(232, 23)
        TextBox3.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ButtonFace
        Label4.Font = New Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(59, 116)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 19)
        Label4.TabIndex = 3
        Label4.Text = "Harga Menu"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ButtonFace
        Label3.Font = New Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(59, 83)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 19)
        Label3.TabIndex = 2
        Label3.Text = "Nama Menu"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Label1.Font = New Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(201, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(194, 25)
        Label1.TabIndex = 0
        Label1.Text = "Transaksi Pesanan"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(183, 225)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(240, 150)
        DataGridView1.TabIndex = 13
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(792, 408)
        Controls.Add(Panel1)
        Name = "Form3"
        Text = "Form3"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
