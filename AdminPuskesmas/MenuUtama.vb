Public Class MenuUtama

    Private Sub MenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnPasien_Click(sender As Object, e As EventArgs) Handles BtnPasien.Click
        Pasien.Show()
    End Sub

    Private Sub btnPendaftaran_Click(sender As Object, e As EventArgs) Handles btnPendaftaran.Click
        FilePasien.Show()
    End Sub

    Private Sub btnRekamMedis_Click(sender As Object, e As EventArgs) Handles btnRekamMedis.Click
        RekamMedis.Show()
    End Sub

    Private Sub btnDokter_Click(sender As Object, e As EventArgs) Handles btnDokter.Click
        Dokter.Show()
    End Sub

    Private Sub btnJadwalDokter_Click(sender As Object, e As EventArgs) Handles btnJadwalDokter.Click
        JadwalDokter.Show()
    End Sub

    Private Sub btnPembayaran_Click(sender As Object, e As EventArgs) Handles btnPembayaran.Click
        Pembayaran.Show()
    End Sub

    Private Sub btnObat_Click(sender As Object, e As EventArgs) Handles btnObat.Click
        Obat.Show()
    End Sub

    Private Sub btnPoli_Click(sender As Object, e As EventArgs) Handles btnPoli.Click
        Poli.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DetailrekamMedis.Show()
    End Sub
End Class