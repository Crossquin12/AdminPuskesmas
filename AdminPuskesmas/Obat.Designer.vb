<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Obat
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
        lblIdObat = New Label()
        lblNamaObat = New Label()
        lblDesObat = New Label()
        lblHargaObat = New Label()
        txtIdObat = New TextBox()
        txtNamaObat = New TextBox()
        txtHargaObat = New TextBox()
        txtDesObat = New RichTextBox()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        btnAdd = New Button()
        btnDelete = New Button()
        btnSave = New Button()
        btnHome = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblIdObat
        ' 
        lblIdObat.AutoSize = True
        lblIdObat.Location = New Point(35, 32)
        lblIdObat.Name = "lblIdObat"
        lblIdObat.Size = New Size(75, 25)
        lblIdObat.TabIndex = 0
        lblIdObat.Text = "ID Obat"
        ' 
        ' lblNamaObat
        ' 
        lblNamaObat.AutoSize = True
        lblNamaObat.Location = New Point(35, 91)
        lblNamaObat.Name = "lblNamaObat"
        lblNamaObat.Size = New Size(104, 25)
        lblNamaObat.TabIndex = 1
        lblNamaObat.Text = "Nama Obat"
        ' 
        ' lblDesObat
        ' 
        lblDesObat.AutoSize = True
        lblDesObat.Location = New Point(385, 29)
        lblDesObat.Name = "lblDesObat"
        lblDesObat.Size = New Size(129, 25)
        lblDesObat.TabIndex = 2
        lblDesObat.Text = "Deskripsi Obat"
        ' 
        ' lblHargaObat
        ' 
        lblHargaObat.AutoSize = True
        lblHargaObat.Location = New Point(35, 157)
        lblHargaObat.Name = "lblHargaObat"
        lblHargaObat.Size = New Size(105, 25)
        lblHargaObat.TabIndex = 3
        lblHargaObat.Text = "Harga Obat"
        ' 
        ' txtIdObat
        ' 
        txtIdObat.Location = New Point(199, 29)
        txtIdObat.Name = "txtIdObat"
        txtIdObat.Size = New Size(150, 31)
        txtIdObat.TabIndex = 5
        ' 
        ' txtNamaObat
        ' 
        txtNamaObat.Location = New Point(199, 88)
        txtNamaObat.Name = "txtNamaObat"
        txtNamaObat.Size = New Size(150, 31)
        txtNamaObat.TabIndex = 6
        ' 
        ' txtHargaObat
        ' 
        txtHargaObat.Location = New Point(199, 154)
        txtHargaObat.Name = "txtHargaObat"
        txtHargaObat.Size = New Size(150, 31)
        txtHargaObat.TabIndex = 8
        ' 
        ' txtDesObat
        ' 
        txtDesObat.Location = New Point(385, 57)
        txtDesObat.Name = "txtDesObat"
        txtDesObat.Size = New Size(368, 149)
        txtDesObat.TabIndex = 10
        txtDesObat.Text = ""
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column5})
        DataGridView1.Location = New Point(12, 255)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(776, 183)
        DataGridView1.TabIndex = 11
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
        Column2.HeaderText = "Nama Obat"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.Width = 180
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Harga "
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.Width = 150
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Deskripsi Obat"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.Width = 282
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(48, 212)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(112, 34)
        btnAdd.TabIndex = 12
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(402, 212)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(112, 34)
        btnDelete.TabIndex = 13
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(226, 212)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(112, 34)
        btnSave.TabIndex = 14
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnHome
        ' 
        btnHome.Location = New Point(578, 212)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(112, 34)
        btnHome.TabIndex = 15
        btnHome.Text = "Home"
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' Obat
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnHome)
        Controls.Add(btnSave)
        Controls.Add(btnDelete)
        Controls.Add(btnAdd)
        Controls.Add(DataGridView1)
        Controls.Add(txtDesObat)
        Controls.Add(txtHargaObat)
        Controls.Add(txtNamaObat)
        Controls.Add(txtIdObat)
        Controls.Add(lblHargaObat)
        Controls.Add(lblDesObat)
        Controls.Add(lblNamaObat)
        Controls.Add(lblIdObat)
        Name = "Obat"
        Text = "Obat"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblIdObat As Label
    Friend WithEvents lblNamaObat As Label
    Friend WithEvents lblDesObat As Label
    Friend WithEvents lblHargaObat As Label
    Friend WithEvents txtIdObat As TextBox
    Friend WithEvents txtNamaObat As TextBox
    Friend WithEvents txtHargaObat As TextBox
    Friend WithEvents txtDesObat As RichTextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
