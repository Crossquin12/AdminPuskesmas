Imports System.Data.Odbc

Public Class Pasien
    Dim conn As OdbcConnection
    Dim dr As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim ds As DataSet
    Dim dt As DataTable
    Dim cmd As OdbcCommand

    Sub koneksi()
        conn = New OdbcConnection
        conn.ConnectionString = "dsn=db puskesmas"
        conn.Open()
    End Sub

    Public Function simpan() As Integer
        koneksi()
        Dim sql As String = "INSERT INTO tblpasien (ID_pasien, Nama_pasien, Tgl_lahir, Alamat, No_telepon, Jenis_kelamin, Riwayat) VALUES (?, ?, ?, ?, ?, ?, ?)"
        cmd = New OdbcCommand(sql, conn)

        cmd.Parameters.AddWithValue("@idPasien", txIdPasien.Text)
        cmd.Parameters.AddWithValue("@namaPasien", txNamaPasien.Text)
        cmd.Parameters.AddWithValue("@tanggalLahir", DateTimePicker1.Value)
        cmd.Parameters.AddWithValue("@alamat", txAlamat.Text)
        cmd.Parameters.AddWithValue("@noTelp", txNoTelp.Text)
        cmd.Parameters.AddWithValue("@jenisKelamin", ComboBox1.Text)
        cmd.Parameters.AddWithValue("@riwayat", txRiwayat.Text)

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
            da = New OdbcDataAdapter("SELECT * FROM tblpasien ORDER BY ID_pasien ASC", conn)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                DataGridView1.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6))
            Next
        Catch ex As Exception
            MsgBox("Menampilkan data Gagal")
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Sub simpan(unused As Integer)
        koneksi()
        Dim sql As String = "INSERT INTO tblpasien VALUES('" & txIdPasien.Text & "','" & txNamaPasien.Text & "','" & DateTimePicker1.Text & "','" & txAlamat.Text & "','" & txNoTelp.Text & "','" & ComboBox1.Text & "','" & txRiwayat.Text & "')"
        cmd = New OdbcCommand(sql, conn)

        Try
            Dim unused1 = MsgBox("Menyimpan data Berhasil", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Menyimpan data Gagal", vbInformation, "PERINGATAN")
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub Pasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tampil()
        ComboBox1.Items.AddRange({"Laki-laki", "Perempuan"})
    End Sub

    Private Sub btHome_Click(sender As Object, e As EventArgs) Handles btHome.Click
        MenuUtama.SendToBack()
    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        simpan()
        Tampil()
    End Sub

    Private Sub btDelete_Click(sender As Object, e As EventArgs) Handles btDelete.Click
        Dim a As String = If(DataGridView1.SelectedCells.Count > 0, DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString(), "")
        If String.IsNullOrEmpty(a) Then
            MsgBox("Data yang dihapus belum DIPILIH")
        ElseIf MessageBox.Show("Anda yakin menghapus data dengan ID_pasien = " & a & "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
            koneksi()
            cmd = New OdbcCommand("DELETE FROM tblpasien WHERE ID_pasien = ?", conn)
            cmd.Parameters.AddWithValue("@idPasien", a)
            Dim unused = cmd.ExecuteNonQuery()
            MsgBox("Menghapus Data BERHASIL", vbInformation, "INFORMASI")
            Tampil()
        End If
    End Sub

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        txIdPasien.Text = ""
        txNamaPasien.Text = ""
        DateTimePicker1.Text = ""
        txAlamat.Text = ""
        txNoTelp.Text = ""
        ComboBox1.Text = ""
        txRiwayat.Text = ""
        txIdPasien.Focus()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
