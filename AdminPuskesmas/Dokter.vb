Imports System.Data.Odbc

Public Class Dokter
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

    Public Function simpan() As Integer
        koneksi()
        Dim sql As String = "INSERT INTO tbdokter VALUES (?, ?, ?, ?, ?, ?)"
        cmd = New OdbcCommand(sql, conn)

        cmd.Parameters.AddWithValue("@idDokter", txtIdDokter.Text)
        cmd.Parameters.AddWithValue("@namaDokter", txtNamaDokter.Text)
        cmd.Parameters.AddWithValue("@noTelp", txtNoTelp.Text)
        cmd.Parameters.AddWithValue("@spesialis", txtSpesialisasi.Text)
        cmd.Parameters.AddWithValue("@hariKerja", txtHariKerja.Text)
        cmd.Parameters.AddWithValue("@jamKerja", txtJamKerja.Text)

        Try
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MsgBox("Menyimpan data Berhasil", vbInformation, "INFORMASI")
            Else
                MsgBox("Menyimpan data Gagal", vbCritical, "PERINGATAN")
            End If
            Return rowsAffected
        Catch ex As OdbcException
            MsgBox("Odbc Exception: " & ex.Message, vbCritical, "PERINGATAN")
            Return -1
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Function

    Sub Tampil()
        DataGridView1.Rows.Clear()
        Try
            koneksi()
            da = New OdbcDataAdapter("SELECT * FROM tbdokter ORDER BY ID_dokter ASC", conn)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                DataGridView1.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5))
            Next
        Catch ex As Exception
            MsgBox("Menampilkan data Gagal")
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Sub tampiljadwal()
        koneksi()
        cmd = New OdbcCommand("SELECT ID_jadwalDokter FROM tbljadwaldokter", conn)
        dr = cmd.ExecuteReader
        ComboBox1.Items.Clear()
        Do While dr.Read
            ComboBox1.Items.Add(dr.Item("ID_jadwalDokter"))
        Loop
        dr.Close()
    End Sub

    Private Sub Dokter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tampil()
        tampiljadwal()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        koneksi()
        cmd = New OdbcCommand("SELECT * FROM tbljadwaldokter WHERE ID_jadwalDokter='" & ComboBox1.Text & "'", conn)

        Try
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                txtHariKerja.Text = dr("Hari_kerja").ToString()
                txtJamKerja.Text = dr("Jam_Kerja").ToString()
            Else
                MsgBox("Jadwal Tidak ditemukan")
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

    Sub simpan(unused As Integer)
        koneksi()
        Dim sql As String = "INSERT INTO tbdokter (ID_dokter, Nama_dokter, No_telpon, Spesialisasi, Hari_kerja, Jam_kerja) VALUES('" & txtIdDokter.Text & "','" & txtNamaDokter.Text & "','" & txtNoTelp.Text & "','" & txtSpesialisasi.Text & "','" & txtHariKerja.Text & "','" & txtJamKerja.Text & "')"
        cmd = New OdbcCommand(sql, conn)

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Menyimpan data Berhasil", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Menyimpan data Gagal", vbInformation, "PERINGATAN")
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtIdDokter.Text = ""
        txtNamaDokter.Text = ""
        txtNoTelp.Text = ""
        ComboBox1.Text = ""
        txtSpesialisasi.Text = ""
        txtHariKerja.Text = ""
        txtJamKerja.Text = ""
        txtIdDokter.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        simpan()
        Tampil()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim a As String = If(DataGridView1.SelectedCells.Count > 0, DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString(), "")
        If String.IsNullOrEmpty(a) Then
            MsgBox("Data yang dihapus belum DIPILIH")
        ElseIf MessageBox.Show("Anda yakin menghapus data dengan ID_dokter = " & a & "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
            koneksi()
            cmd = New OdbcCommand("DELETE FROM tbdokter WHERE ID_dokter = ?", conn)
            cmd.Parameters.AddWithValue("@idDokter", a)
            cmd.ExecuteNonQuery()
            MsgBox("Menghapus Data BERHASIL", vbInformation, "INFORMASI")
            Tampil()
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        MenuUtama.SendToBack()
    End Sub
End Class
