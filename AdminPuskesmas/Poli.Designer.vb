<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Poli
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
        lblIdPoli = New Label()
        lblNamaPoli = New Label()
        lblIdDokter = New Label()
        txtIdPoli = New TextBox()
        ComboBox1 = New ComboBox()
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
        ComboBox2 = New ComboBox()
        txtNamaDokter = New TextBox()
        txtSpesialisasi = New TextBox()
        lblNamaDokter = New Label()
        lblSpesialisasi = New Label()
        lblKataDokter = New Label()
        txtDiagnosa = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblIdPoli
        ' 
        lblIdPoli.AutoSize = True
        lblIdPoli.Location = New Point(39, 36)
        lblIdPoli.Name = "lblIdPoli"
        lblIdPoli.Size = New Size(63, 25)
        lblIdPoli.TabIndex = 0
        lblIdPoli.Text = "ID Poli"
        ' 
        ' lblNamaPoli
        ' 
        lblNamaPoli.AutoSize = True
        lblNamaPoli.Location = New Point(39, 73)
        lblNamaPoli.Name = "lblNamaPoli"
        lblNamaPoli.Size = New Size(92, 25)
        lblNamaPoli.TabIndex = 1
        lblNamaPoli.Text = "Nama Poli"
        ' 
        ' lblIdDokter
        ' 
        lblIdDokter.AutoSize = True
        lblIdDokter.Location = New Point(42, 112)
        lblIdDokter.Name = "lblIdDokter"
        lblIdDokter.Size = New Size(89, 25)
        lblIdDokter.TabIndex = 2
        lblIdDokter.Text = "ID Dokter"
        ' 
        ' txtIdPoli
        ' 
        txtIdPoli.Location = New Point(195, 33)
        txtIdPoli.Name = "txtIdPoli"
        txtIdPoli.Size = New Size(351, 31)
        txtIdPoli.TabIndex = 3
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(195, 70)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(351, 33)
        ComboBox1.TabIndex = 5
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(19, 262)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(112, 34)
        btnAdd.TabIndex = 6
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(146, 262)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(112, 34)
        btnSave.TabIndex = 7
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(289, 262)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(112, 34)
        btnDelete.TabIndex = 8
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnHome
        ' 
        btnHome.Location = New Point(434, 262)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(112, 34)
        btnHome.TabIndex = 9
        btnHome.Text = "Home"
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        DataGridView1.Location = New Point(12, 311)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(789, 230)
        DataGridView1.TabIndex = 10
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "ID"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.Width = 150
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Nama Poli"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.Width = 150
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Nama Dokter"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.Width = 150
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Spesialisasi"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.Width = 150
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Diagnosa Dokter"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.Width = 200
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(196, 109)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(351, 33)
        ComboBox2.TabIndex = 11
        ' 
        ' txtNamaDokter
        ' 
        txtNamaDokter.Location = New Point(195, 148)
        txtNamaDokter.Name = "txtNamaDokter"
        txtNamaDokter.Size = New Size(351, 31)
        txtNamaDokter.TabIndex = 12
        ' 
        ' txtSpesialisasi
        ' 
        txtSpesialisasi.Location = New Point(195, 185)
        txtSpesialisasi.Name = "txtSpesialisasi"
        txtSpesialisasi.Size = New Size(351, 31)
        txtSpesialisasi.TabIndex = 13
        ' 
        ' lblNamaDokter
        ' 
        lblNamaDokter.AutoSize = True
        lblNamaDokter.Location = New Point(42, 151)
        lblNamaDokter.Name = "lblNamaDokter"
        lblNamaDokter.Size = New Size(118, 25)
        lblNamaDokter.TabIndex = 14
        lblNamaDokter.Text = "Nama Dokter"
        ' 
        ' lblSpesialisasi
        ' 
        lblSpesialisasi.AutoSize = True
        lblSpesialisasi.Location = New Point(42, 188)
        lblSpesialisasi.Name = "lblSpesialisasi"
        lblSpesialisasi.Size = New Size(100, 25)
        lblSpesialisasi.TabIndex = 15
        lblSpesialisasi.Text = "Spesialisasi"
        ' 
        ' lblKataDokter
        ' 
        lblKataDokter.AutoSize = True
        lblKataDokter.Location = New Point(42, 225)
        lblKataDokter.Name = "lblKataDokter"
        lblKataDokter.Size = New Size(92, 25)
        lblKataDokter.TabIndex = 16
        lblKataDokter.Text = "Diagnosa "
        ' 
        ' txtDiagnosa
        ' 
        txtDiagnosa.Location = New Point(195, 222)
        txtDiagnosa.Name = "txtDiagnosa"
        txtDiagnosa.Size = New Size(351, 31)
        txtDiagnosa.TabIndex = 17
        ' 
        ' Poli
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(813, 553)
        Controls.Add(txtDiagnosa)
        Controls.Add(lblKataDokter)
        Controls.Add(lblSpesialisasi)
        Controls.Add(lblNamaDokter)
        Controls.Add(txtSpesialisasi)
        Controls.Add(txtNamaDokter)
        Controls.Add(ComboBox2)
        Controls.Add(DataGridView1)
        Controls.Add(btnHome)
        Controls.Add(btnDelete)
        Controls.Add(btnSave)
        Controls.Add(btnAdd)
        Controls.Add(ComboBox1)
        Controls.Add(txtIdPoli)
        Controls.Add(lblIdDokter)
        Controls.Add(lblNamaPoli)
        Controls.Add(lblIdPoli)
        Name = "Poli"
        Text = "Poli"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblIdPoli As Label
    Friend WithEvents lblNamaPoli As Label
    Friend WithEvents lblIdDokter As Label
    Friend WithEvents txtIdPoli As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents txtNamaDokter As TextBox
    Friend WithEvents txtSpesialisasi As TextBox
    Friend WithEvents lblNamaDokter As Label
    Friend WithEvents lblSpesialisasi As Label
    Friend WithEvents lblKataDokter As Label
    Friend WithEvents txtDiagnosa As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
