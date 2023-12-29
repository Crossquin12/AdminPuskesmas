Imports System.Data.Odbc

Public Class RekamMedis
    Dim conn As OdbcConnection
    Dim da As OdbcDataAdapter
    Dim dt As DataTable
    Dim cmd As OdbcCommand

    Sub koneksi()
        conn = New OdbcConnection("dsn=db puskesmas")
        conn.Open()
    End Sub

    Public Function Simpan() As Integer
        koneksi()
        Dim sql As String = "INSERT INTO tblrekammedis VALUES (?, ?, ?, ?)"
        cmd = New OdbcCommand(sql, conn)

        cmd.Parameters.AddWithValue("@idRekamMedis", txtIdRekamMedis.Text)
        cmd.Parameters.AddWithValue("@tanggalPerawatan", DateTimePicker1.Value)
        cmd.Parameters.AddWithValue("@keluhan", txtKeluhan.Text)
        cmd.Parameters.AddWithValue("@keterangan", txtKeterangan.Text)

        Try
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MsgBox("Menyimpan data Berhasil", vbInformation, "INFORMASI")
            Else
                MsgBox("Menyimpan data Gagal", vbCritical, "PERINGATAN")
            End If
            Return rowsAffected
        Catch ex As Exception
            MsgBox("Terjadi kesalahan saat menyimpan data: " & ex.Message, vbCritical, "PERINGATAN")
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
            da = New OdbcDataAdapter("SELECT * FROM tblrekammedis ORDER BY ID_rekamMedis ASC", conn)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                DataGridView1.Rows.Add(row(0), row(1), row(2), row(3))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan data Gagal")
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        MenuUtama.SendToBack()
    End Sub

    Private Sub RekamMedis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tampil()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Simpan()
        Tampil()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtIdRekamMedis.Text = ""
        txtKeluhan.Text = ""
        txtKeterangan.Text = ""
        txtIdRekamMedis.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim a As String = If(DataGridView1.SelectedCells.Count > 0, DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString(), "")
        If String.IsNullOrEmpty(a) Then
            MsgBox("Data yang dihapus belum DIPILIH")
        ElseIf MessageBox.Show("Anda yakin menghapus data dengan ID_rekamMedis = " & a & "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
            koneksi()
            cmd = New OdbcCommand("DELETE FROM tblrekammedis WHERE ID_rekamMedis = ?", conn)
            cmd.Parameters.AddWithValue("@idRekamMedis", a)
            Dim unused = cmd.ExecuteNonQuery()
            MsgBox("Menghapus Data BERHASIL", vbInformation, "INFORMASI")
            Tampil()
        End If
    End Sub
End Class
