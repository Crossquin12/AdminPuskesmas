<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailrekamMedis
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
        lblIdRekamMedis = New Label()
        lblPoli = New Label()
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
        Label1 = New Label()
        txtDiagnosa = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        txtNamaPoli = New TextBox()
        Label2 = New Label()
        lblNamaPoli = New Label()
        lblNamaDokter = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        txtKodeRekam = New TextBox()
        lblKode = New Label()
        txtNamaDokter = New TextBox()
        txtKeluhan = New TextBox()
        lblKeluhan = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblIdRekamMedis
        ' 
        lblIdRekamMedis.AutoSize = True
        lblIdRekamMedis.Location = New Point(39, 81)
        lblIdRekamMedis.Name = "lblIdRekamMedis"
        lblIdRekamMedis.Size = New Size(141, 25)
        lblIdRekamMedis.TabIndex = 0
        lblIdRekamMedis.Text = "ID Rekam Medis"
        ' 
        ' lblPoli
        ' 
        lblPoli.AutoSize = True
        lblPoli.Location = New Point(451, 42)
        lblPoli.Name = "lblPoli"
        lblPoli.Size = New Size(63, 25)
        lblPoli.TabIndex = 1
        lblPoli.Text = "ID Poli"
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(39, 211)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(112, 34)
        btnAdd.TabIndex = 4
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(39, 251)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(112, 34)
        btnSave.TabIndex = 5
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(267, 211)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(112, 34)
        btnDelete.TabIndex = 6
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnHome
        ' 
        btnHome.Location = New Point(267, 251)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(112, 34)
        btnHome.TabIndex = 7
        btnHome.Text = "Home"
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        DataGridView1.Location = New Point(12, 301)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(731, 209)
        DataGridView1.TabIndex = 8
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Kode Rekam Medis"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.Width = 150
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Tanggal Perawatan"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.Width = 150
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Keluhan"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.Width = 150
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Nama Poli"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.Width = 150
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Dokter"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.Width = 150
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Diagnosa"
        Column6.MinimumWidth = 8
        Column6.Name = "Column6"
        Column6.Width = 150
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(39, 116)
        Label1.Name = "Label1"
        Label1.Size = New Size(158, 25)
        Label1.TabIndex = 9
        Label1.Text = "Tanggal Perawatan"
        ' 
        ' txtDiagnosa
        ' 
        txtDiagnosa.Location = New Point(558, 149)
        txtDiagnosa.Name = "txtDiagnosa"
        txtDiagnosa.Size = New Size(185, 31)
        txtDiagnosa.TabIndex = 11
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(219, 112)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(185, 31)
        DateTimePicker1.TabIndex = 12
        ' 
        ' txtNamaPoli
        ' 
        txtNamaPoli.Location = New Point(558, 76)
        txtNamaPoli.Name = "txtNamaPoli"
        txtNamaPoli.Size = New Size(185, 31)
        txtNamaPoli.TabIndex = 14
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(451, 152)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 25)
        Label2.TabIndex = 18
        Label2.Text = "Diagnosa "
        ' 
        ' lblNamaPoli
        ' 
        lblNamaPoli.AutoSize = True
        lblNamaPoli.Location = New Point(451, 81)
        lblNamaPoli.Name = "lblNamaPoli"
        lblNamaPoli.Size = New Size(92, 25)
        lblNamaPoli.TabIndex = 20
        lblNamaPoli.Text = "Nama Poli"
        ' 
        ' lblNamaDokter
        ' 
        lblNamaDokter.AutoSize = True
        lblNamaDokter.Location = New Point(451, 116)
        lblNamaDokter.Name = "lblNamaDokter"
        lblNamaDokter.Size = New Size(66, 25)
        lblNamaDokter.TabIndex = 21
        lblNamaDokter.Text = "Dokter"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(219, 73)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(182, 33)
        ComboBox1.TabIndex = 23
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(558, 39)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(182, 33)
        ComboBox2.TabIndex = 24
        ' 
        ' txtKodeRekam
        ' 
        txtKodeRekam.Location = New Point(219, 36)
        txtKodeRekam.Name = "txtKodeRekam"
        txtKodeRekam.Size = New Size(185, 31)
        txtKodeRekam.TabIndex = 25
        ' 
        ' lblKode
        ' 
        lblKode.AutoSize = True
        lblKode.Location = New Point(39, 42)
        lblKode.Name = "lblKode"
        lblKode.Size = New Size(164, 25)
        lblKode.TabIndex = 26
        lblKode.Text = "Kode Rekam Medis"
        ' 
        ' txtNamaDokter
        ' 
        txtNamaDokter.Location = New Point(558, 112)
        txtNamaDokter.Name = "txtNamaDokter"
        txtNamaDokter.Size = New Size(185, 31)
        txtNamaDokter.TabIndex = 27
        ' 
        ' txtKeluhan
        ' 
        txtKeluhan.Location = New Point(219, 149)
        txtKeluhan.Name = "txtKeluhan"
        txtKeluhan.Size = New Size(185, 31)
        txtKeluhan.TabIndex = 28
        ' 
        ' lblKeluhan
        ' 
        lblKeluhan.AutoSize = True
        lblKeluhan.Location = New Point(39, 152)
        lblKeluhan.Name = "lblKeluhan"
        lblKeluhan.Size = New Size(74, 25)
        lblKeluhan.TabIndex = 29
        lblKeluhan.Text = "Keluhan"
        ' 
        ' DetailrekamMedis
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(753, 522)
        Controls.Add(lblKeluhan)
        Controls.Add(txtKeluhan)
        Controls.Add(txtNamaDokter)
        Controls.Add(lblKode)
        Controls.Add(txtKodeRekam)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(lblNamaDokter)
        Controls.Add(lblNamaPoli)
        Controls.Add(Label2)
        Controls.Add(txtNamaPoli)
        Controls.Add(DateTimePicker1)
        Controls.Add(txtDiagnosa)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Controls.Add(btnHome)
        Controls.Add(btnDelete)
        Controls.Add(btnSave)
        Controls.Add(btnAdd)
        Controls.Add(lblPoli)
        Controls.Add(lblIdRekamMedis)
        Name = "DetailrekamMedis"
        Text = "Detail Rekam Medis"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblIdRekamMedis As Label
    Friend WithEvents lblPoli As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDiagnosa As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtNamaPoli As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNamaPoli As Label
    Friend WithEvents lblNamaDokter As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents txtKodeRekam As TextBox
    Friend WithEvents lblKode As Label
    Friend WithEvents txtNamaDokter As TextBox
    Friend WithEvents txtKeluhan As TextBox
    Friend WithEvents lblKeluhan As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
