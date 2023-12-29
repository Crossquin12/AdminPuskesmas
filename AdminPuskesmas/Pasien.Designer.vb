<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pasien
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
        lbIdPasien = New Label()
        lbNamaPasien = New Label()
        lbTglLahir = New Label()
        lbAlamat = New Label()
        lbNoTelp = New Label()
        lbJenisKelamin = New Label()
        lbRiwayat = New Label()
        txIdPasien = New TextBox()
        txNamaPasien = New TextBox()
        txAlamat = New TextBox()
        txNoTelp = New TextBox()
        txRiwayat = New TextBox()
        ComboBox1 = New ComboBox()
        btAdd = New Button()
        btSave = New Button()
        btDelete = New Button()
        btHome = New Button()
        DateTimePicker1 = New DateTimePicker()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbIdPasien
        ' 
        lbIdPasien.AutoSize = True
        lbIdPasien.Location = New Point(40, 38)
        lbIdPasien.Name = "lbIdPasien"
        lbIdPasien.Size = New Size(84, 25)
        lbIdPasien.TabIndex = 0
        lbIdPasien.Text = "ID Pasien"
        ' 
        ' lbNamaPasien
        ' 
        lbNamaPasien.AutoSize = True
        lbNamaPasien.Location = New Point(40, 75)
        lbNamaPasien.Name = "lbNamaPasien"
        lbNamaPasien.Size = New Size(113, 25)
        lbNamaPasien.TabIndex = 1
        lbNamaPasien.Text = "Nama Pasien"
        ' 
        ' lbTglLahir
        ' 
        lbTglLahir.AutoSize = True
        lbTglLahir.Location = New Point(40, 114)
        lbTglLahir.Name = "lbTglLahir"
        lbTglLahir.Size = New Size(115, 25)
        lbTglLahir.TabIndex = 2
        lbTglLahir.Text = "Tanggal Lahir"
        ' 
        ' lbAlamat
        ' 
        lbAlamat.AutoSize = True
        lbAlamat.Location = New Point(40, 149)
        lbAlamat.Name = "lbAlamat"
        lbAlamat.Size = New Size(68, 25)
        lbAlamat.TabIndex = 3
        lbAlamat.Text = "Alamat"
        ' 
        ' lbNoTelp
        ' 
        lbNoTelp.AutoSize = True
        lbNoTelp.Location = New Point(382, 38)
        lbNoTelp.Name = "lbNoTelp"
        lbNoTelp.Size = New Size(101, 25)
        lbNoTelp.TabIndex = 4
        lbNoTelp.Text = "No.Telepon"
        ' 
        ' lbJenisKelamin
        ' 
        lbJenisKelamin.AutoSize = True
        lbJenisKelamin.Location = New Point(382, 87)
        lbJenisKelamin.Name = "lbJenisKelamin"
        lbJenisKelamin.Size = New Size(116, 25)
        lbJenisKelamin.TabIndex = 5
        lbJenisKelamin.Text = "Jenis Kelamin"
        ' 
        ' lbRiwayat
        ' 
        lbRiwayat.AutoSize = True
        lbRiwayat.Location = New Point(382, 139)
        lbRiwayat.Name = "lbRiwayat"
        lbRiwayat.Size = New Size(73, 25)
        lbRiwayat.TabIndex = 6
        lbRiwayat.Text = "Riwayat"
        ' 
        ' txIdPasien
        ' 
        txIdPasien.Location = New Point(166, 35)
        txIdPasien.Name = "txIdPasien"
        txIdPasien.Size = New Size(150, 31)
        txIdPasien.TabIndex = 7
        ' 
        ' txNamaPasien
        ' 
        txNamaPasien.Location = New Point(166, 72)
        txNamaPasien.Name = "txNamaPasien"
        txNamaPasien.Size = New Size(150, 31)
        txNamaPasien.TabIndex = 8
        ' 
        ' txAlamat
        ' 
        txAlamat.Location = New Point(166, 146)
        txAlamat.Name = "txAlamat"
        txAlamat.Size = New Size(150, 31)
        txAlamat.TabIndex = 10
        ' 
        ' txNoTelp
        ' 
        txNoTelp.Location = New Point(501, 35)
        txNoTelp.Name = "txNoTelp"
        txNoTelp.Size = New Size(150, 31)
        txNoTelp.TabIndex = 11
        ' 
        ' txRiwayat
        ' 
        txRiwayat.Location = New Point(501, 136)
        txRiwayat.Name = "txRiwayat"
        txRiwayat.Size = New Size(150, 31)
        txRiwayat.TabIndex = 13
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(501, 84)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(182, 33)
        ComboBox1.TabIndex = 14
        ' 
        ' btAdd
        ' 
        btAdd.Location = New Point(52, 190)
        btAdd.Name = "btAdd"
        btAdd.Size = New Size(112, 34)
        btAdd.TabIndex = 15
        btAdd.Text = "Add"
        btAdd.UseVisualStyleBackColor = True
        ' 
        ' btSave
        ' 
        btSave.Location = New Point(187, 190)
        btSave.Name = "btSave"
        btSave.Size = New Size(112, 34)
        btSave.TabIndex = 16
        btSave.Text = "Save"
        btSave.UseVisualStyleBackColor = True
        ' 
        ' btDelete
        ' 
        btDelete.Location = New Point(326, 190)
        btDelete.Name = "btDelete"
        btDelete.Size = New Size(112, 34)
        btDelete.TabIndex = 17
        btDelete.Text = "Delete"
        btDelete.UseVisualStyleBackColor = True
        ' 
        ' btHome
        ' 
        btHome.Location = New Point(467, 190)
        btHome.Name = "btHome"
        btHome.Size = New Size(112, 34)
        btHome.TabIndex = 18
        btHome.Text = "Home"
        btHome.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CustomFormat = "dd-MM-yyyy"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(166, 109)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(189, 31)
        DateTimePicker1.TabIndex = 19
        DateTimePicker1.Value = New Date(2023, 12, 26, 0, 0, 0, 0)
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7})
        DataGridView1.Location = New Point(12, 230)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(776, 213)
        DataGridView1.TabIndex = 20
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "ID Pasien"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.Width = 150
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Nama"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.Width = 150
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Tanggal Lahir"
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
        Column5.HeaderText = "No.Telpon"
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
        Column7.HeaderText = "Riwayat"
        Column7.MinimumWidth = 8
        Column7.Name = "Column7"
        Column7.Width = 150
        ' 
        ' Pasien
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(DateTimePicker1)
        Controls.Add(btHome)
        Controls.Add(btDelete)
        Controls.Add(btSave)
        Controls.Add(btAdd)
        Controls.Add(ComboBox1)
        Controls.Add(txRiwayat)
        Controls.Add(txNoTelp)
        Controls.Add(txAlamat)
        Controls.Add(txNamaPasien)
        Controls.Add(txIdPasien)
        Controls.Add(lbRiwayat)
        Controls.Add(lbJenisKelamin)
        Controls.Add(lbNoTelp)
        Controls.Add(lbAlamat)
        Controls.Add(lbTglLahir)
        Controls.Add(lbNamaPasien)
        Controls.Add(lbIdPasien)
        Name = "Pasien"
        Text = "Pasien"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbIdPasien As Label
    Friend WithEvents lbNamaPasien As Label
    Friend WithEvents lbTglLahir As Label
    Friend WithEvents lbAlamat As Label
    Friend WithEvents lbNoTelp As Label
    Friend WithEvents lbJenisKelamin As Label
    Friend WithEvents lbRiwayat As Label
    Friend WithEvents txIdPasien As TextBox
    Friend WithEvents txNamaPasien As TextBox
    Private txAlamat As TextBox
    Private txNoTelp As TextBox
    Private txRiwayat As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btAdd As Button
    Friend WithEvents btSave As Button
    Friend WithEvents btDelete As Button
    Friend WithEvents btHome As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
