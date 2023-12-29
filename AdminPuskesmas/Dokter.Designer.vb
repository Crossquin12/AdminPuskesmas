<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dokter
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
        lblIdDokter = New Label()
        lblIdJadwal = New Label()
        lblNamaDokter = New Label()
        lblSpesialisasi = New Label()
        lblNoTelp = New Label()
        txtIdDokter = New TextBox()
        txtNamaDokter = New TextBox()
        txtSpesialisasi = New TextBox()
        txtNoTelp = New TextBox()
        btnAdd = New Button()
        btnSave = New Button()
        btnDelete = New Button()
        btnHome = New Button()
        DataGridView1 = New DataGridView()
        ComboBox1 = New ComboBox()
        lblHariKerja = New Label()
        txtHariKerja = New TextBox()
        txtJamKerja = New TextBox()
        lblJamKerja = New Label()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblIdDokter
        ' 
        lblIdDokter.AutoSize = True
        lblIdDokter.Location = New Point(34, 28)
        lblIdDokter.Name = "lblIdDokter"
        lblIdDokter.Size = New Size(89, 25)
        lblIdDokter.TabIndex = 0
        lblIdDokter.Text = "ID Dokter"
        ' 
        ' lblIdJadwal
        ' 
        lblIdJadwal.AutoSize = True
        lblIdJadwal.Location = New Point(410, 31)
        lblIdJadwal.Name = "lblIdJadwal"
        lblIdJadwal.Size = New Size(87, 25)
        lblIdJadwal.TabIndex = 1
        lblIdJadwal.Text = "ID Jadwal"
        ' 
        ' lblNamaDokter
        ' 
        lblNamaDokter.AutoSize = True
        lblNamaDokter.Location = New Point(34, 65)
        lblNamaDokter.Name = "lblNamaDokter"
        lblNamaDokter.Size = New Size(118, 25)
        lblNamaDokter.TabIndex = 2
        lblNamaDokter.Text = "Nama Dokter"
        ' 
        ' lblSpesialisasi
        ' 
        lblSpesialisasi.AutoSize = True
        lblSpesialisasi.Location = New Point(34, 136)
        lblSpesialisasi.Name = "lblSpesialisasi"
        lblSpesialisasi.Size = New Size(100, 25)
        lblSpesialisasi.TabIndex = 3
        lblSpesialisasi.Text = "Spesialisasi"
        ' 
        ' lblNoTelp
        ' 
        lblNoTelp.AutoSize = True
        lblNoTelp.Location = New Point(34, 102)
        lblNoTelp.Name = "lblNoTelp"
        lblNoTelp.Size = New Size(125, 25)
        lblNoTelp.TabIndex = 4
        lblNoTelp.Text = "No. Telephone"
        ' 
        ' txtIdDokter
        ' 
        txtIdDokter.Location = New Point(181, 25)
        txtIdDokter.Name = "txtIdDokter"
        txtIdDokter.Size = New Size(150, 31)
        txtIdDokter.TabIndex = 5
        ' 
        ' txtNamaDokter
        ' 
        txtNamaDokter.Location = New Point(181, 62)
        txtNamaDokter.Name = "txtNamaDokter"
        txtNamaDokter.Size = New Size(150, 31)
        txtNamaDokter.TabIndex = 7
        ' 
        ' txtSpesialisasi
        ' 
        txtSpesialisasi.Location = New Point(181, 136)
        txtSpesialisasi.Name = "txtSpesialisasi"
        txtSpesialisasi.Size = New Size(150, 31)
        txtSpesialisasi.TabIndex = 8
        ' 
        ' txtNoTelp
        ' 
        txtNoTelp.Location = New Point(181, 99)
        txtNoTelp.Name = "txtNoTelp"
        txtNoTelp.Size = New Size(150, 31)
        txtNoTelp.TabIndex = 9
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(34, 197)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(112, 34)
        btnAdd.TabIndex = 10
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(181, 197)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(112, 34)
        btnSave.TabIndex = 11
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(330, 197)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(112, 34)
        btnDelete.TabIndex = 12
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnHome
        ' 
        btnHome.Location = New Point(475, 197)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(112, 34)
        btnHome.TabIndex = 13
        btnHome.Text = "Home"
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column5, Column4, Column6})
        DataGridView1.Location = New Point(12, 237)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(776, 201)
        DataGridView1.TabIndex = 14
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(548, 28)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(182, 33)
        ComboBox1.TabIndex = 15
        ' 
        ' lblHariKerja
        ' 
        lblHariKerja.AutoSize = True
        lblHariKerja.Location = New Point(410, 70)
        lblHariKerja.Name = "lblHariKerja"
        lblHariKerja.Size = New Size(87, 25)
        lblHariKerja.TabIndex = 16
        lblHariKerja.Text = "Hari Kerja"
        ' 
        ' txtHariKerja
        ' 
        txtHariKerja.Location = New Point(548, 67)
        txtHariKerja.Name = "txtHariKerja"
        txtHariKerja.Size = New Size(150, 31)
        txtHariKerja.TabIndex = 17
        ' 
        ' txtJamKerja
        ' 
        txtJamKerja.Location = New Point(548, 104)
        txtJamKerja.Name = "txtJamKerja"
        txtJamKerja.Size = New Size(150, 31)
        txtJamKerja.TabIndex = 18
        ' 
        ' lblJamKerja
        ' 
        lblJamKerja.AutoSize = True
        lblJamKerja.Location = New Point(410, 107)
        lblJamKerja.Name = "lblJamKerja"
        lblJamKerja.Size = New Size(86, 25)
        lblJamKerja.TabIndex = 19
        lblJamKerja.Text = "Jam Kerja"
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "ID"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.Width = 90
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Nama Dokter"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.Width = 150
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "No.Telp"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.Width = 150
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Spesialisasi"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.Width = 150
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Hari Kerja"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.Width = 150
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Jam Kerja"
        Column6.MinimumWidth = 8
        Column6.Name = "Column6"
        Column6.Width = 150
        ' 
        ' Dokter
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblJamKerja)
        Controls.Add(txtJamKerja)
        Controls.Add(txtHariKerja)
        Controls.Add(lblHariKerja)
        Controls.Add(ComboBox1)
        Controls.Add(DataGridView1)
        Controls.Add(btnHome)
        Controls.Add(btnDelete)
        Controls.Add(btnSave)
        Controls.Add(btnAdd)
        Controls.Add(txtNoTelp)
        Controls.Add(txtSpesialisasi)
        Controls.Add(txtNamaDokter)
        Controls.Add(txtIdDokter)
        Controls.Add(lblNoTelp)
        Controls.Add(lblSpesialisasi)
        Controls.Add(lblNamaDokter)
        Controls.Add(lblIdJadwal)
        Controls.Add(lblIdDokter)
        Name = "Dokter"
        Text = "Dokter"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblIdDokter As Label
    Friend WithEvents lblIdJadwal As Label
    Friend WithEvents lblNamaDokter As Label
    Friend WithEvents lblSpesialisasi As Label
    Friend WithEvents lblNoTelp As Label
    Friend WithEvents txtIdDokter As TextBox
    Friend WithEvents txtNamaDokter As TextBox
    Friend WithEvents txtSpesialisasi As TextBox
    Friend WithEvents txtNoTelp As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblHariKerja As Label
    Friend WithEvents txtHariKerja As TextBox
    Friend WithEvents txtJamKerja As TextBox
    Friend WithEvents lblJamKerja As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
