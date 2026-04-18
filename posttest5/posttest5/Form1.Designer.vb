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
        txtID = New TextBox()
        txtSearch = New TextBox()
        txtNama = New TextBox()
        cmbJenis = New ComboBox()
        cmbStatus = New ComboBox()
        GroupBox1 = New GroupBox()
        lblSummary = New Label()
        btnHapus = New Button()
        btnClear = New Button()
        btnSimpan = New Button()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        dgvData = New DataGridView()
        colNama = New DataGridViewTextBoxColumn()
        colID = New DataGridViewTextBoxColumn()
        colJenis = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        lblTotal = New Label()
        GroupBox1.SuspendLayout()
        CType(dgvData, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(219, 133)
        txtID.Margin = New Padding(4, 5, 4, 5)
        txtID.Name = "txtID"
        txtID.Size = New Size(141, 31)
        txtID.TabIndex = 0
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(346, 405)
        txtSearch.Margin = New Padding(4, 5, 4, 5)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(351, 31)
        txtSearch.TabIndex = 1
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(219, 68)
        txtNama.Margin = New Padding(4, 5, 4, 5)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(141, 31)
        txtNama.TabIndex = 2
        ' 
        ' cmbJenis
        ' 
        cmbJenis.FormattingEnabled = True
        cmbJenis.Location = New Point(693, 68)
        cmbJenis.Margin = New Padding(4, 5, 4, 5)
        cmbJenis.Name = "cmbJenis"
        cmbJenis.Size = New Size(171, 33)
        cmbJenis.TabIndex = 3
        ' 
        ' cmbStatus
        ' 
        cmbStatus.FormattingEnabled = True
        cmbStatus.Location = New Point(693, 150)
        cmbStatus.Margin = New Padding(4, 5, 4, 5)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(171, 33)
        cmbStatus.TabIndex = 4
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lblSummary)
        GroupBox1.Controls.Add(btnHapus)
        GroupBox1.Controls.Add(btnClear)
        GroupBox1.Controls.Add(btnSimpan)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtID)
        GroupBox1.Controls.Add(txtSearch)
        GroupBox1.Controls.Add(cmbStatus)
        GroupBox1.Controls.Add(txtNama)
        GroupBox1.Controls.Add(cmbJenis)
        GroupBox1.FlatStyle = FlatStyle.Popup
        GroupBox1.ForeColor = SystemColors.ControlText
        GroupBox1.Location = New Point(144, 20)
        GroupBox1.Margin = New Padding(4, 5, 4, 5)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 5, 4, 5)
        GroupBox1.Size = New Size(917, 485)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' lblSummary
        ' 
        lblSummary.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSummary.Location = New Point(449, 455)
        lblSummary.Margin = New Padding(4, 0, 4, 0)
        lblSummary.Name = "lblSummary"
        lblSummary.Size = New Size(149, 35)
        lblSummary.TabIndex = 14
        lblSummary.Text = "Label7"
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(591, 310)
        btnHapus.Margin = New Padding(4, 5, 4, 5)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(107, 38)
        btnHapus.TabIndex = 12
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(383, 310)
        btnClear.Margin = New Padding(4, 5, 4, 5)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(107, 38)
        btnClear.TabIndex = 11
        btnClear.Text = "Kosongkan"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(171, 310)
        btnSimpan.Margin = New Padding(4, 5, 4, 5)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(107, 38)
        btnSimpan.TabIndex = 10
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(204, 410)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 25)
        Label5.TabIndex = 9
        Label5.Text = "Cari"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(556, 155)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 25)
        Label4.TabIndex = 8
        Label4.Text = "Status"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(566, 73)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 25)
        Label3.TabIndex = 7
        Label3.Text = "Jenis"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(34, 73)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(192, 25)
        Label2.TabIndex = 6
        Label2.Text = "Nama Kendaraan"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(34, 133)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(158, 25)
        Label1.TabIndex = 5
        Label1.Text = "ID Kendaraan"
        ' 
        ' dgvData
        ' 
        dgvData.AllowUserToAddRows = False
        dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvData.Columns.AddRange(New DataGridViewColumn() {colNama, colID, colJenis, colStatus})
        dgvData.Location = New Point(144, 515)
        dgvData.Margin = New Padding(4, 5, 4, 5)
        dgvData.Name = "dgvData"
        dgvData.ReadOnly = True
        dgvData.RowHeadersWidth = 62
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.Size = New Size(941, 345)
        dgvData.TabIndex = 6
        ' 
        ' colNama
        ' 
        colNama.DataPropertyName = "NAMA"
        colNama.HeaderText = "Nama Kendaraan"
        colNama.MinimumWidth = 8
        colNama.Name = "colNama"
        colNama.ReadOnly = True
        ' 
        ' colID
        ' 
        colID.DataPropertyName = "ID"
        colID.HeaderText = "ID Unit"
        colID.MinimumWidth = 8
        colID.Name = "colID"
        colID.ReadOnly = True
        ' 
        ' colJenis
        ' 
        colJenis.DataPropertyName = "JENIS"
        colJenis.HeaderText = "Jenis"
        colJenis.MinimumWidth = 8
        colJenis.Name = "colJenis"
        colJenis.ReadOnly = True
        ' 
        ' colStatus
        ' 
        colStatus.DataPropertyName = "STATUS"
        colStatus.HeaderText = "Status Operasional"
        colStatus.MinimumWidth = 8
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotal.Location = New Point(559, 885)
        lblTotal.Margin = New Padding(4, 0, 4, 0)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(80, 25)
        lblTotal.TabIndex = 13
        lblTotal.Text = "Label6"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        ClientSize = New Size(1190, 1050)
        Controls.Add(dgvData)
        Controls.Add(lblTotal)
        Controls.Add(GroupBox1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form1"
        Text = "Pendataan Alusista"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvData, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents cmbJenis As ComboBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents colNama As DataGridViewTextBoxColumn
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colJenis As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents lblSummary As Label
    Friend WithEvents lblTotal As Label

End Class
