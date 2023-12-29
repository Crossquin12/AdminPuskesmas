<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JadwalDokter
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
        lblIdJadwal = New Label()
        lblHariKerja = New Label()
        lblJamKerja = New Label()
        txtIdJadwal = New TextBox()
        btnAdd = New Button()
        btnSave = New Button()
        btnDelete = New Button()
        btnHome = New Button()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        CmbHari = New ComboBox()
        CmbJam = New ComboBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblIdJadwal
        ' 
        lblIdJadwal.AutoSize = True
        lblIdJadwal.Location = New Point(25, 21)
        lblIdJadwal.Name = "lblIdJadwal"
        lblIdJadwal.Size = New Size(146, 25)
        lblIdJadwal.TabIndex = 0
        lblIdJadwal.Text = "ID Jadwal Dokter"
        ' 
        ' lblHariKerja
        ' 
        lblHariKerja.AutoSize = True
        lblHariKerja.Location = New Point(25, 76)
        lblHariKerja.Name = "lblHariKerja"
        lblHariKerja.Size = New Size(87, 25)
        lblHariKerja.TabIndex = 1
        lblHariKerja.Text = "Hari Kerja"
        ' 
        ' lblJamKerja
        ' 
        lblJamKerja.AutoSize = True
        lblJamKerja.Location = New Point(25, 139)
        lblJamKerja.Name = "lblJamKerja"
        lblJamKerja.Size = New Size(86, 25)
        lblJamKerja.TabIndex = 2
        lblJamKerja.Text = "Jam Kerja"
        ' 
        ' txtIdJadwal
        ' 
        txtIdJadwal.Location = New Point(195, 18)
        txtIdJadwal.Name = "txtIdJadwal"
        txtIdJadwal.Size = New Size(220, 31)
        txtIdJadwal.TabIndex = 3
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(25, 201)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(112, 34)
        btnAdd.TabIndex = 6
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(166, 201)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(112, 34)
        btnSave.TabIndex = 7
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(316, 201)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(112, 34)
        btnDelete.TabIndex = 8
        btnDelete.Text = "Delete"
        btnDelete.TextAlign = ContentAlignment.BottomCenter
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnHome
        ' 
        btnHome.Location = New Point(449, 201)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(112, 34)
        btnHome.TabIndex = 9
        btnHome.Text = "Home"
        btnHome.TextAlign = ContentAlignment.BottomCenter
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3})
        DataGridView1.Location = New Point(25, 241)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(513, 197)
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
        Column2.HeaderText = "Hari Kerja"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.Width = 150
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Jam Kerja"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.Width = 150
        ' 
        ' CmbHari
        ' 
        CmbHari.FormattingEnabled = True
        CmbHari.Items.AddRange(New Object() {"Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", "Minggu"})
        CmbHari.Location = New Point(195, 73)
        CmbHari.Name = "CmbHari"
        CmbHari.Size = New Size(232, 33)
        CmbHari.TabIndex = 53
        ' 
        ' CmbJam
        ' 
        CmbJam.FormattingEnabled = True
        CmbJam.Items.AddRange(New Object() {"06.00-11.00", "11.00-16.00", "16.00-21.00"})
        CmbJam.Location = New Point(195, 136)
        CmbJam.Name = "CmbJam"
        CmbJam.Size = New Size(232, 33)
        CmbJam.TabIndex = 54
        ' 
        ' JadwalDokter
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(588, 450)
        Controls.Add(CmbJam)
        Controls.Add(CmbHari)
        Controls.Add(DataGridView1)
        Controls.Add(btnHome)
        Controls.Add(btnDelete)
        Controls.Add(btnSave)
        Controls.Add(btnAdd)
        Controls.Add(txtIdJadwal)
        Controls.Add(lblJamKerja)
        Controls.Add(lblHariKerja)
        Controls.Add(lblIdJadwal)
        Name = "JadwalDokter"
        Text = "Jadwal Dokter"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblIdJadwal As Label
    Friend WithEvents lblHariKerja As Label
    Friend WithEvents lblJamKerja As Label
    Friend WithEvents txtIdJadwal As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents CmbHari As ComboBox
    Friend WithEvents CmbJam As ComboBox
End Class
