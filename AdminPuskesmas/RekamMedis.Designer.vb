<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RekamMedis
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
        lblTglPerawatan = New Label()
        lblDiagnosa = New Label()
        lblKeluhan = New Label()
        txtIdRekamMedis = New TextBox()
        txtKeluhan = New TextBox()
        txtKeterangan = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        btnAdd = New Button()
        btnSave = New Button()
        btnDelete = New Button()
        btnHome = New Button()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblIdRekamMedis
        ' 
        lblIdRekamMedis.AutoSize = True
        lblIdRekamMedis.Location = New Point(43, 33)
        lblIdRekamMedis.Name = "lblIdRekamMedis"
        lblIdRekamMedis.Size = New Size(141, 25)
        lblIdRekamMedis.TabIndex = 0
        lblIdRekamMedis.Text = "ID Rekam Medis"
        ' 
        ' lblTglPerawatan
        ' 
        lblTglPerawatan.AutoSize = True
        lblTglPerawatan.Location = New Point(43, 87)
        lblTglPerawatan.Name = "lblTglPerawatan"
        lblTglPerawatan.Size = New Size(158, 25)
        lblTglPerawatan.TabIndex = 1
        lblTglPerawatan.Text = "Tanggal Perawatan"
        ' 
        ' lblDiagnosa
        ' 
        lblDiagnosa.AutoSize = True
        lblDiagnosa.Location = New Point(43, 198)
        lblDiagnosa.Name = "lblDiagnosa"
        lblDiagnosa.Size = New Size(101, 25)
        lblDiagnosa.TabIndex = 2
        lblDiagnosa.Text = "Keterangan"
        ' 
        ' lblKeluhan
        ' 
        lblKeluhan.AutoSize = True
        lblKeluhan.Location = New Point(43, 145)
        lblKeluhan.Name = "lblKeluhan"
        lblKeluhan.Size = New Size(128, 25)
        lblKeluhan.TabIndex = 3
        lblKeluhan.Text = "Keluhan Pasien"
        ' 
        ' txtIdRekamMedis
        ' 
        txtIdRekamMedis.Location = New Point(234, 33)
        txtIdRekamMedis.Name = "txtIdRekamMedis"
        txtIdRekamMedis.Size = New Size(188, 31)
        txtIdRekamMedis.TabIndex = 4
        ' 
        ' txtKeluhan
        ' 
        txtKeluhan.Location = New Point(234, 142)
        txtKeluhan.Name = "txtKeluhan"
        txtKeluhan.Size = New Size(188, 31)
        txtKeluhan.TabIndex = 5
        ' 
        ' txtKeterangan
        ' 
        txtKeterangan.Location = New Point(234, 195)
        txtKeterangan.Name = "txtKeterangan"
        txtKeterangan.Size = New Size(188, 31)
        txtKeterangan.TabIndex = 6
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(234, 82)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(188, 31)
        DateTimePicker1.TabIndex = 7
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(475, 33)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(112, 34)
        btnAdd.TabIndex = 8
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(475, 73)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(112, 34)
        btnSave.TabIndex = 9
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(475, 113)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(112, 34)
        btnDelete.TabIndex = 10
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnHome
        ' 
        btnHome.Location = New Point(475, 153)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(112, 34)
        btnHome.TabIndex = 11
        btnHome.Text = "Home"
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        DataGridView1.Location = New Point(12, 232)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(776, 206)
        DataGridView1.TabIndex = 12
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
        Column3.Width = 200
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Keterangan"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.Width = 214
        ' 
        ' RekamMedis
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(btnHome)
        Controls.Add(btnDelete)
        Controls.Add(btnSave)
        Controls.Add(btnAdd)
        Controls.Add(DateTimePicker1)
        Controls.Add(txtKeterangan)
        Controls.Add(txtKeluhan)
        Controls.Add(txtIdRekamMedis)
        Controls.Add(lblKeluhan)
        Controls.Add(lblDiagnosa)
        Controls.Add(lblTglPerawatan)
        Controls.Add(lblIdRekamMedis)
        Name = "RekamMedis"
        Text = "Rekam Medis"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblIdRekamMedis As Label
    Friend WithEvents lblTglPerawatan As Label
    Friend WithEvents lblDiagnosa As Label
    Friend WithEvents lblKeluhan As Label
    Friend WithEvents txtIdRekamMedis As TextBox
    Friend WithEvents txtKeluhan As TextBox
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
