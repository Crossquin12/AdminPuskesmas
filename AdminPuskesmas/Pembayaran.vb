Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Pembayaran
    Dim conn As OdbcConnection
    Dim cmd As OdbcCommand
    Dim dr As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim dt As DataTable

    Sub koneksi()
        conn = New OdbcConnection("dsn=db puskesmas")
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
    End Sub

    Sub simpan()
        koneksi()
        Dim sql As String = "INSERT INTO tblpembayaran (No_tr, ID_pasien, Nama_pasien, Tgl_lahir, Alamat, No_telepon, Jenis_kelamin, Kode_detailrekam, Tanggal_perawatan, Keluhan, Nama_poli, Nama_dokter, Diagnosa, ID_obat, Nama_obat, Deskripsi_obat, Harga) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        cmd = New OdbcCommand(sql, conn)

        cmd.Parameters.AddWithValue("@noTr", txtNoTr.Text)
        cmd.Parameters.AddWithValue("@idPasien", cmbPasien.Text)
        cmd.Parameters.AddWithValue("@namaPasien", txtNamaPasien.Text)
        cmd.Parameters.AddWithValue("@tanggalPerawatan", DateTimePicker1.Text)
        cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text)
        cmd.Parameters.AddWithValue("@noTelp", txtNoTelp.Text)
        cmd.Parameters.AddWithValue("@jenisKelamin", txtJenisKelamin.Text)
        cmd.Parameters.AddWithValue("@idMedis", CmbMedis.Text)
        cmd.Parameters.AddWithValue("@tglPerawatan", DateTimePicker2.Text)
        cmd.Parameters.AddWithValue("@keluhan", txtKeluhan.Text)
        cmd.Parameters.AddWithValue("@namaPoli", txtNamaPoli.Text)
        cmd.Parameters.AddWithValue("@dokter", txtDokter.Text)
        cmd.Parameters.AddWithValue("@diagnosa", txtDiagnosa.Text)
        cmd.Parameters.AddWithValue("@idObat", CmbObat.Text)
        cmd.Parameters.AddWithValue("@namaObat", txtNamaObat.Text)
        cmd.Parameters.AddWithValue("@desObat", txtDesObat.Text)
        cmd.Parameters.AddWithValue("@harga", txtHarga.Text)

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Menyimpan data Berhasil", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Menyimpan data Gagal. Error: " & ex.Message, vbInformation, "PERINGATAN")
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Sub Tampil()
        DataGridView1.Rows.Clear()
        Try
            koneksi()
            da = New OdbcDataAdapter("SELECT No_tr, Nama_pasien, Tgl_lahir, Alamat, No_telepon, Jenis_kelamin, Tanggal_perawatan, Keluhan, Nama_poli, Nama_dokter, Diagnosa, Nama_obat, Deskripsi_obat, Harga FROM tblpembayaran ORDER BY No_tr ASC", conn)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                DataGridView1.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9), row(10), row(11), row(12), row(13))
            Next
        Catch ex As Exception
            MsgBox("Menampilkan data Gagal. Error: " & ex.Message, vbCritical, "Error")
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Sub tampilPasien()
        koneksi()
        cmd = New OdbcCommand("Select ID_pasien FROM tblpasien", conn)
        dr = cmd.ExecuteReader
        cmbPasien.Items.Clear()
        Do While dr.Read
            cmbPasien.Items.Add(dr.Item("ID_pasien"))
        Loop
        dr.Close()
    End Sub

    Sub tampilMedis()
        koneksi()
        cmd = New OdbcCommand("Select Kode_rekammedis FROM tbldetailrekam", conn)
        dr = cmd.ExecuteReader
        CmbMedis.Items.Clear()
        Do While dr.Read
            CmbMedis.Items.Add(dr.Item("Kode_rekammedis"))
        Loop
        dr.Close()
    End Sub

    Sub tampilObat()
        koneksi()
        cmd = New OdbcCommand("Select ID_obat FROM tblobat", conn)
        dr = cmd.ExecuteReader
        CmbObat.Items.Clear()
        Do While dr.Read
            CmbObat.Items.Add(dr.Item("ID_obat"))
        Loop
        dr.Close()
    End Sub

    Private Sub Pembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tampil()
        tampilPasien()
        tampilMedis()
        tampilObat()
    End Sub

    Private Sub cmbPasien_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPasien.SelectedIndexChanged
        koneksi()
        cmd = New OdbcCommand("Select * FROM tblpasien WHERE ID_pasien='" & cmbPasien.Text & "'", conn)

        Try
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                txtNamaPasien.Text = dr("Nama_pasien").ToString()
                DateTimePicker1.Text = dr("Tgl_lahir").ToString()
                txtAlamat.Text = dr("Alamat").ToString()
                txtNoTelp.Text = dr("No_telepon").ToString()
                txtJenisKelamin.Text = dr("Jenis_kelamin").ToString()
            Else
                MsgBox("Pasien Tidak ditemukan")
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical, "Error")
        Finally
            dr.Close()
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub CmbMedis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMedis.SelectedIndexChanged
        koneksi()
        cmd = New OdbcCommand("Select * FROM tbldetailrekam WHERE Kode_rekammedis ='" & CmbMedis.Text & "'", conn)

        Try
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                DateTimePicker2.Text = dr("Tanggal_perawatan").ToString()
                txtKeluhan.Text = dr("Keluhan").ToString()
                txtNamaPoli.Text = dr("Nama_poli").ToString()
                txtDokter.Text = dr("Nama_dokter").ToString()
                txtDiagnosa.Text = dr("Diagnosa").ToString()
            Else
                MsgBox("Rekam Medis Tidak ditemukan")
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical, "Error")
        Finally
            dr.Close()
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub CmbObat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbObat.SelectedIndexChanged
        koneksi()
        cmd = New OdbcCommand("Select * FROM tblobat WHERE ID_obat ='" & CmbObat.Text & "'", conn)

        Try
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                txtNamaObat.Text = dr("Nama_obat").ToString()
                txtDesObat.Text = dr("Deskripsi_obat").ToString()
                txtHarga.Text = dr("Harga_obat").ToString()
            Else
                MsgBox("Obat Tidak ditemukan")
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical, "Error")
        Finally
            dr.Close()
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtNoTr.Text = ""
        cmbPasien.Text = ""
        txtNamaPasien.Text = ""
        DateTimePicker1.Text = ""
        txtAlamat.Text = ""
        txtNoTelp.Text = ""
        txtJenisKelamin.Text = ""
        CmbMedis.Text = ""
        DateTimePicker2.Text = ""
        txtKeluhan.Text = ""
        txtNamaPoli.Text = ""
        txtDokter.Text = ""
        txtDiagnosa.Text = ""
        CmbObat.Text = ""
        txtNamaObat.Text = ""
        txtDesObat.Text = ""
        txtHarga.Text = ""
        txtNoTr.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        simpan()
        Tampil()
        tampilPasien()
        tampilMedis()
        tampilObat()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim a As String = If(DataGridView1.SelectedCells.Count > 0, DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString(), "")
        If String.IsNullOrEmpty(a) Then
            MsgBox("Data yang dihapus belum DIPILIH")
        ElseIf MessageBox.Show("Anda yakin menghapus data dengan No_Tr = " & a & "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
            koneksi()
            cmd = New OdbcCommand("DELETE FROM tblpembayaran WHERE No_Tr = ?", conn)
            cmd.Parameters.AddWithValue("@noTr", a)
            cmd.ExecuteNonQuery()
            MsgBox("Menghapus Data BERHASIL", vbInformation, "INFORMASI")
            Tampil()
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        MenuUtama.SendToBack()
    End Sub
End Class