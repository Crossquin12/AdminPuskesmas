<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pembayaran
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
        lblNoTr = New Label()
        txtNoTr = New TextBox()
        btnAdd = New Button()
        btnSave = New Button()
        btnDelete = New Button()
        btnHome = New Button()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Column12 = New DataGridViewTextBoxColumn()
        Column13 = New DataGridViewTextBoxColumn()
        txtNoTelp = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        txtNamaPasien = New TextBox()
        cmbPasien = New ComboBox()
        Label3 = New Label()
        txtAlamat = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        CmbMedis = New ComboBox()
        DateTimePicker2 = New DateTimePicker()
        txtKeluhan = New TextBox()
        txtNamaPoli = New TextBox()
        txtDokter = New TextBox()
        txtDiagnosa = New TextBox()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label20 = New Label()
        CmbObat = New ComboBox()
        txtNamaObat = New TextBox()
        txtHarga = New TextBox()
        txtDesObat = New RichTextBox()
        txtJenisKelamin = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblNoTr
        ' 
        lblNoTr.AutoSize = True
        lblNoTr.Location = New Point(22, 32)
        lblNoTr.Name = "lblNoTr"
        lblNoTr.Size = New Size(115, 25)
        lblNoTr.TabIndex = 0
        lblNoTr.Text = "No. Transaksi"
        ' 
        ' txtNoTr
        ' 
        txtNoTr.Location = New Point(149, 26)
        txtNoTr.Name = "txtNoTr"
        txtNoTr.Size = New Size(188, 31)
        txtNoTr.TabIndex = 4
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(50, 418)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(112, 34)
        btnAdd.TabIndex = 8
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(188, 418)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(112, 34)
        btnSave.TabIndex = 9
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(331, 418)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(112, 34)
        btnDelete.TabIndex = 10
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnHome
        ' 
        btnHome.Location = New Point(473, 418)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(112, 34)
        btnHome.TabIndex = 11
        btnHome.Text = "Home"
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12, Column13})
        DataGridView1.Location = New Point(12, 458)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(1083, 203)
        DataGridView1.TabIndex = 12
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "No.Tr"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.Width = 75
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Nama Pasien"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.Width = 150
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Tgl Lahir"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.Width = 150
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Alamat"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.Width = 150
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "No.Telp"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.Width = 150
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Jenis Kelamin"
        Column6.MinimumWidth = 8
        Column6.Name = "Column6"
        Column6.Width = 150
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Tanggal Perawatan"
        Column7.MinimumWidth = 8
        Column7.Name = "Column7"
        Column7.Width = 150
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Keluhan"
        Column8.MinimumWidth = 8
        Column8.Name = "Column8"
        Column8.Width = 150
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "Nama Poli"
        Column9.MinimumWidth = 8
        Column9.Name = "Column9"
        Column9.Width = 150
        ' 
        ' Column10
        ' 
        Column10.HeaderText = "Nama Dokter"
        Column10.MinimumWidth = 8
        Column10.Name = "Column10"
        Column10.Width = 150
        ' 
        ' Column11
        ' 
        Column11.HeaderText = "Nama Obat"
        Column11.MinimumWidth = 8
        Column11.Name = "Column11"
        Column11.Width = 150
        ' 
        ' Column12
        ' 
        Column12.HeaderText = "Deskripsi Obat"
        Column12.MinimumWidth = 8
        Column12.Name = "Column12"
        Column12.Width = 150
        ' 
        ' Column13
        ' 
        Column13.HeaderText = "Harga"
        Column13.MinimumWidth = 8
        Column13.Name = "Column13"
        Column13.Width = 150
        ' 
        ' txtNoTelp
        ' 
        txtNoTelp.Location = New Point(149, 309)
        txtNoTelp.Name = "txtNoTelp"
        txtNoTelp.Size = New Size(188, 31)
        txtNoTelp.TabIndex = 13
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ControlDark
        Label1.Location = New Point(22, 125)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 25)
        Label1.TabIndex = 14
        Label1.Text = "Data Pasien"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 162)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 25)
        Label2.TabIndex = 15
        Label2.Text = "ID Pasien"
        ' 
        ' txtNamaPasien
        ' 
        txtNamaPasien.Location = New Point(149, 198)
        txtNamaPasien.Name = "txtNamaPasien"
        txtNamaPasien.Size = New Size(188, 31)
        txtNamaPasien.TabIndex = 16
        ' 
        ' cmbPasien
        ' 
        cmbPasien.FormattingEnabled = True
        cmbPasien.Location = New Point(149, 159)
        cmbPasien.Name = "cmbPasien"
        cmbPasien.Size = New Size(188, 33)
        cmbPasien.TabIndex = 24
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 201)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 25)
        Label3.TabIndex = 25
        Label3.Text = "Nama Pasien"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(149, 272)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(188, 31)
        txtAlamat.TabIndex = 26
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(149, 235)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(188, 31)
        DateTimePicker1.TabIndex = 28
        DateTimePicker1.Value = New Date(2023, 12, 26, 0, 0, 0, 0)
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(22, 240)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 25)
        Label4.TabIndex = 29
        Label4.Text = "Tanggal Lahir"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(22, 275)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 25)
        Label5.TabIndex = 30
        Label5.Text = "Alamat"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(22, 312)
        Label6.Name = "Label6"
        Label6.Size = New Size(101, 25)
        Label6.TabIndex = 31
        Label6.Text = "No.Telepon"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(22, 349)
        Label7.Name = "Label7"
        Label7.Size = New Size(116, 25)
        Label7.TabIndex = 32
        Label7.Text = "Jenis Kelamin"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.ControlDark
        Label8.Location = New Point(360, 125)
        Label8.Name = "Label8"
        Label8.Size = New Size(60, 25)
        Label8.TabIndex = 33
        Label8.Text = "Medis"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(360, 162)
        Label9.Name = "Label9"
        Label9.Size = New Size(83, 25)
        Label9.TabIndex = 34
        Label9.Text = "ID Medis"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(360, 201)
        Label10.Name = "Label10"
        Label10.Size = New Size(158, 25)
        Label10.TabIndex = 35
        Label10.Text = "Tanggal Perawatan"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(360, 240)
        Label11.Name = "Label11"
        Label11.Size = New Size(74, 25)
        Label11.TabIndex = 36
        Label11.Text = "Keluhan"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(360, 275)
        Label12.Name = "Label12"
        Label12.Size = New Size(92, 25)
        Label12.TabIndex = 37
        Label12.Text = "Nama Poli"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(360, 312)
        Label13.Name = "Label13"
        Label13.Size = New Size(66, 25)
        Label13.TabIndex = 38
        Label13.Text = "Dokter"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(360, 349)
        Label14.Name = "Label14"
        Label14.Size = New Size(87, 25)
        Label14.TabIndex = 39
        Label14.Text = "Diagnosa"
        ' 
        ' CmbMedis
        ' 
        CmbMedis.FormattingEnabled = True
        CmbMedis.Location = New Point(520, 159)
        CmbMedis.Name = "CmbMedis"
        CmbMedis.Size = New Size(188, 33)
        CmbMedis.TabIndex = 40
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(520, 198)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(188, 31)
        DateTimePicker2.TabIndex = 41
        ' 
        ' txtKeluhan
        ' 
        txtKeluhan.Location = New Point(520, 237)
        txtKeluhan.Name = "txtKeluhan"
        txtKeluhan.Size = New Size(188, 31)
        txtKeluhan.TabIndex = 42
        ' 
        ' txtNamaPoli
        ' 
        txtNamaPoli.Location = New Point(520, 274)
        txtNamaPoli.Name = "txtNamaPoli"
        txtNamaPoli.Size = New Size(188, 31)
        txtNamaPoli.TabIndex = 43
        ' 
        ' txtDokter
        ' 
        txtDokter.Location = New Point(520, 311)
        txtDokter.Name = "txtDokter"
        txtDokter.Size = New Size(188, 31)
        txtDokter.TabIndex = 44
        ' 
        ' txtDiagnosa
        ' 
        txtDiagnosa.Location = New Point(520, 348)
        txtDiagnosa.Name = "txtDiagnosa"
        txtDiagnosa.Size = New Size(188, 31)
        txtDiagnosa.TabIndex = 45
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = SystemColors.ControlDark
        Label15.Location = New Point(728, 125)
        Label15.Name = "Label15"
        Label15.Size = New Size(52, 25)
        Label15.TabIndex = 46
        Label15.Text = "Obat"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(728, 162)
        Label16.Name = "Label16"
        Label16.Size = New Size(75, 25)
        Label16.TabIndex = 47
        Label16.Text = "ID Obat"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(728, 201)
        Label17.Name = "Label17"
        Label17.Size = New Size(104, 25)
        Label17.TabIndex = 48
        Label17.Text = "Nama Obat"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(728, 240)
        Label18.Name = "Label18"
        Label18.Size = New Size(129, 25)
        Label18.TabIndex = 49
        Label18.Text = "Deskripsi Obat"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(728, 349)
        Label20.Name = "Label20"
        Label20.Size = New Size(60, 25)
        Label20.TabIndex = 51
        Label20.Text = "Harga"
        ' 
        ' CmbObat
        ' 
        CmbObat.FormattingEnabled = True
        CmbObat.Location = New Point(859, 159)
        CmbObat.Name = "CmbObat"
        CmbObat.Size = New Size(232, 33)
        CmbObat.TabIndex = 52
        ' 
        ' txtNamaObat
        ' 
        txtNamaObat.Location = New Point(859, 198)
        txtNamaObat.Name = "txtNamaObat"
        txtNamaObat.Size = New Size(232, 31)
        txtNamaObat.TabIndex = 53
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(859, 349)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(232, 31)
        txtHarga.TabIndex = 54
        ' 
        ' txtDesObat
        ' 
        txtDesObat.Location = New Point(859, 235)
        txtDesObat.Name = "txtDesObat"
        txtDesObat.Size = New Size(232, 102)
        txtDesObat.TabIndex = 55
        txtDesObat.Text = ""
        ' 
        ' txtJenisKelamin
        ' 
        txtJenisKelamin.Location = New Point(149, 346)
        txtJenisKelamin.Name = "txtJenisKelamin"
        txtJenisKelamin.Size = New Size(188, 31)
        txtJenisKelamin.TabIndex = 56
        ' 
        ' Pembayaran
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1107, 673)
        Controls.Add(txtJenisKelamin)
        Controls.Add(txtDesObat)
        Controls.Add(txtHarga)
        Controls.Add(txtNamaObat)
        Controls.Add(CmbObat)
        Controls.Add(Label20)
        Controls.Add(Label18)
        Controls.Add(Label17)
        Controls.Add(Label16)
        Controls.Add(Label15)
        Controls.Add(txtDiagnosa)
        Controls.Add(txtDokter)
        Controls.Add(txtNamaPoli)
        Controls.Add(txtKeluhan)
        Controls.Add(DateTimePicker2)
        Controls.Add(CmbMedis)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(DateTimePicker1)
        Controls.Add(txtAlamat)
        Controls.Add(Label3)
        Controls.Add(cmbPasien)
        Controls.Add(txtNamaPasien)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtNoTelp)
        Controls.Add(DataGridView1)
        Controls.Add(btnHome)
        Controls.Add(btnDelete)
        Controls.Add(btnSave)
        Controls.Add(btnAdd)
        Controls.Add(txtNoTr)
        Controls.Add(lblNoTr)
        Name = "Pembayaran"
        Text = "Pembayaran"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNoTr As Label
    Friend WithEvents txtNoTr As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtNoTelp As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNamaPasien As TextBox
    Friend WithEvents cmbPasien As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents CmbMedis As ComboBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents txtKeluhan As TextBox
    Friend WithEvents txtNamaPoli As TextBox
    Friend WithEvents txtDokter As TextBox
    Friend WithEvents txtDiagnosa As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents CmbObat As ComboBox
    Friend WithEvents txtNamaObat As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtDesObat As RichTextBox
    Friend WithEvents txtJenisKelamin As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
End Class
