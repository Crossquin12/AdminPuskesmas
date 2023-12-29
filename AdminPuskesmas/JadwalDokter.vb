Imports System.Data.Odbc

Public Class JadwalDokter
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
        Dim sql As String = "INSERT INTO tbljadwaldokter VALUES (?, ?, ?)"
        cmd = New OdbcCommand(sql, conn)

        cmd.Parameters.AddWithValue("@idJadwalDokter", txtIdJadwal.Text)
        cmd.Parameters.AddWithValue("@hariKerja", CmbHari.Text)
        cmd.Parameters.AddWithValue("@jamKerja", CmbJam.Text)

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
            da = New OdbcDataAdapter("SELECT * FROM tbljadwaldokter ORDER BY ID_jadwalDokter ASC", conn)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                DataGridView1.Rows.Add(row(0), row(1), row(2))
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
        Dim sql As String = "INSERT INTO tbljadwaldokter VALUES('" & txtIdJadwal.Text & "','" & CmbHari.Text & "','" & CmbJam.Text & "')"
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

    Private Sub JadwalDokter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tampil()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        MenuUtama.SendToBack()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        simpan()
        Tampil()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim a As String = If(DataGridView1.SelectedCells.Count > 0, DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString(), "")
        If String.IsNullOrEmpty(a) Then
            MsgBox("Data yang dihapus belum DIPILIH")
        ElseIf MessageBox.Show("Anda yakin menghapus data dengan ID_jadwalDokter = " & a & "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
            koneksi()
            cmd = New OdbcCommand("DELETE FROM tbljadwaldokter WHERE ID_jadwalDokter = ?", conn)
            cmd.Parameters.AddWithValue("@idJadwalDokter", a)
            Dim unused = cmd.ExecuteNonQuery()
            MsgBox("Menghapus Data BERHASIL", vbInformation, "INFORMASI")
            Tampil()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtIdJadwal.Text = ""
        CmbHari.Text = ""
        CmbJam.Text = ""
        txtIdJadwal.Focus()
    End Sub
End Class
