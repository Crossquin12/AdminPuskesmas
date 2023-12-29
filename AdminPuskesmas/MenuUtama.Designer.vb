<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
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
        btnPendaftaran = New Button()
        BtnPasien = New Button()
        btnPoli = New Button()
        btnDokter = New Button()
        btnJadwalDokter = New Button()
        btnRekamMedis = New Button()
        btnObat = New Button()
        btnPembayaran = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' btnPendaftaran
        ' 
        btnPendaftaran.Location = New Point(55, 56)
        btnPendaftaran.Name = "btnPendaftaran"
        btnPendaftaran.Size = New Size(131, 34)
        btnPendaftaran.TabIndex = 0
        btnPendaftaran.Text = "File Pasien"
        btnPendaftaran.UseVisualStyleBackColor = True
        ' 
        ' BtnPasien
        ' 
        BtnPasien.Location = New Point(251, 56)
        BtnPasien.Name = "BtnPasien"
        BtnPasien.Size = New Size(131, 34)
        BtnPasien.TabIndex = 1
        BtnPasien.Text = "Pasien"
        BtnPasien.UseVisualStyleBackColor = True
        ' 
        ' btnPoli
        ' 
        btnPoli.Location = New Point(55, 111)
        btnPoli.Name = "btnPoli"
        btnPoli.Size = New Size(131, 34)
        btnPoli.TabIndex = 2
        btnPoli.Text = "Poli"
        btnPoli.UseVisualStyleBackColor = True
        ' 
        ' btnDokter
        ' 
        btnDokter.Location = New Point(251, 111)
        btnDokter.Name = "btnDokter"
        btnDokter.Size = New Size(131, 34)
        btnDokter.TabIndex = 3
        btnDokter.Text = "Dokter"
        btnDokter.UseVisualStyleBackColor = True
        ' 
        ' btnJadwalDokter
        ' 
        btnJadwalDokter.Location = New Point(55, 168)
        btnJadwalDokter.Name = "btnJadwalDokter"
        btnJadwalDokter.Size = New Size(131, 34)
        btnJadwalDokter.TabIndex = 4
        btnJadwalDokter.Text = "Jadwal Dokter"
        btnJadwalDokter.UseVisualStyleBackColor = True
        ' 
        ' btnRekamMedis
        ' 
        btnRekamMedis.Location = New Point(251, 168)
        btnRekamMedis.Name = "btnRekamMedis"
        btnRekamMedis.Size = New Size(131, 34)
        btnRekamMedis.TabIndex = 5
        btnRekamMedis.Text = "Rekam Medis"
        btnRekamMedis.UseVisualStyleBackColor = True
        ' 
        ' btnObat
        ' 
        btnObat.Location = New Point(55, 224)
        btnObat.Name = "btnObat"
        btnObat.Size = New Size(131, 34)
        btnObat.TabIndex = 6
        btnObat.Text = "Obat"
        btnObat.UseVisualStyleBackColor = True
        ' 
        ' btnPembayaran
        ' 
        btnPembayaran.Location = New Point(251, 224)
        btnPembayaran.Name = "btnPembayaran"
        btnPembayaran.Size = New Size(131, 34)
        btnPembayaran.TabIndex = 7
        btnPembayaran.Text = "Pembayaran"
        btnPembayaran.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(132, 264)
        Button1.Name = "Button1"
        Button1.Size = New Size(200, 34)
        Button1.TabIndex = 8
        Button1.Text = "Detail Rekam Medis"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' MenuUtama
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(538, 337)
        Controls.Add(Button1)
        Controls.Add(btnPembayaran)
        Controls.Add(btnObat)
        Controls.Add(btnRekamMedis)
        Controls.Add(btnJadwalDokter)
        Controls.Add(btnDokter)
        Controls.Add(btnPoli)
        Controls.Add(BtnPasien)
        Controls.Add(btnPendaftaran)
        Name = "MenuUtama"
        Text = "Home"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnPendaftaran As Button
    Friend WithEvents BtnPasien As Button
    Friend WithEvents btnPoli As Button
    Friend WithEvents btnDokter As Button
    Friend WithEvents btnJadwalDokter As Button
    Friend WithEvents btnRekamMedis As Button
    Friend WithEvents btnObat As Button
    Friend WithEvents btnPembayaran As Button
    Friend WithEvents Button1 As Button
End Class
