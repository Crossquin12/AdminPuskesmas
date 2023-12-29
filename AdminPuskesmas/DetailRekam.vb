Imports System.Data.Odbc

Public Class DetailrekamMedis
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
        Dim sql As String = "INSERT INTO tbldetailrekam (Kode_rekamMedis, ID_rekamMedis, Tanggal_perawatan, Keluhan, ID_poli, Nama_poli, Nama_dokter, Diagnosa) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
        cmd = New OdbcCommand(sql, conn)

        cmd.Parameters.AddWithValue("@kodeRekamMedis", txtKodeRekam.Text)
        cmd.Parameters.AddWithValue("@idRekamMedis", ComboBox1.Text)
        cmd.Parameters.AddWithValue("@tanggalPerawatan", DateTimePicker1.Value)
        cmd.Parameters.AddWithValue("@keluhan", txtKeluhan.Text)
        cmd.Parameters.AddWithValue("@idPoli", ComboBox2.Text)
        cmd.Parameters.AddWithValue("@namaPoli", txtNamaPoli.Text)
        cmd.Parameters.AddWithValue("@namaDokter", txtNamaDokter.Text)
        cmd.Parameters.AddWithValue("@diagnosa", txtDiagnosa.Text)

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
            da = New OdbcDataAdapter("SELECT Kode_rekamMedis, Tanggal_perawatan, Keluhan, Nama_poli, Nama_dokter, Diagnosa FROM tbldetailrekam ORDER BY Kode_rekamMedis ASC", conn)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                DataGridView1.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5))
            Next
        Catch ex As Exception
            MsgBox("Menampilkan data Gagal. Error: " & ex.Message, vbCritical, "Error")
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub


    Sub tampilRekamMedis()
        koneksi()
        cmd = New OdbcCommand("Select ID_rekamMedis FROM tblrekammedis", conn)
        dr = cmd.ExecuteReader
        ComboBox1.Items.Clear()
        Do While dr.Read
            ComboBox1.Items.Add(dr.Item("ID_rekamMedis"))
        Loop
        dr.Close()
    End Sub

    Sub tampilPoli()
        koneksi()
        cmd = New OdbcCommand("Select ID_poli FROM tblpoli", conn)
        dr = cmd.ExecuteReader
        ComboBox2.Items.Clear()
        Do While dr.Read
            ComboBox2.Items.Add(dr.Item("ID_poli"))
        Loop
        dr.Close()
    End Sub

    Private Sub DetailrekamMedis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tampil()
        tampilRekamMedis()
        tampilPoli()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        koneksi()
        cmd = New OdbcCommand("Select * FROM tblrekammedis WHERE ID_rekamMedis='" & ComboBox1.Text & "'", conn)

        Try
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                DateTimePicker1.Text = dr("tgl_perawatan").ToString()
                txtKeluhan.Text = dr("Keluhan").ToString()
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

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        koneksi()
        cmd = New OdbcCommand("SELECT * FROM tblpoli WHERE ID_poli='" & ComboBox2.Text & "'", conn)

        Try
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                txtNamaPoli.Text = dr("Nama_poli").ToString()
                txtNamaDokter.Text = dr("Nama_dokter").ToString()
                txtDiagnosa.Text = dr("Diagnosa").ToString()
            Else
                MsgBox("Poli Tidak ditemukan")
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
        txtKodeRekam.Text = ""
        ComboBox1.Text = ""
        DateTimePicker1.Text = ""
        txtKeluhan.Text = ""
        ComboBox2.Text = ""
        txtNamaPoli.Text = ""
        txtNamaDokter.Text = ""
        txtDiagnosa.Text = ""
        txtKodeRekam.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        simpan()
        Tampil()
        tampilRekamMedis()
        tampilPoli()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim a As String = If(DataGridView1.SelectedCells.Count > 0, DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString(), "")
        If String.IsNullOrEmpty(a) Then
            MsgBox("Data yang dihapus belum DIPILIH")
        ElseIf MessageBox.Show("Anda yakin menghapus data dengan Kode_rekammedis = " & a & "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
            koneksi()
            cmd = New OdbcCommand("DELETE FROM tbldetailrekam WHERE Kode_rekammedis = ?", conn)
            cmd.Parameters.AddWithValue("@kodeRekammedis", a)
            cmd.ExecuteNonQuery()
            MsgBox("Menghapus Data BERHASIL", vbInformation, "INFORMASI")
            Tampil()
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        MenuUtama.SendToBack()
    End Sub

End Class
