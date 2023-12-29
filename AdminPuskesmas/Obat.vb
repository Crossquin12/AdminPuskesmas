Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Obat
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
        Dim sql As String = "INSERT INTO tblobat VALUES (?, ?, ?, ?)"
        cmd = New OdbcCommand(sql, conn)
        cmd.Parameters.AddWithValue("@idObat", txtIdObat.Text)
        cmd.Parameters.AddWithValue("@paketObat", txtNamaObat.Text)
        cmd.Parameters.AddWithValue("@hargaObat", txtHargaObat.Text)
        cmd.Parameters.AddWithValue("@deskripsiObat", txtDesObat.Text)

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
            da = New OdbcDataAdapter("SELECT * FROM tblobat ORDER BY ID_obat ASC", conn)
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

    Sub simpan(unused As Integer)
        koneksi()
        Dim sql As String = "INSERT INTO tblobat (ID_obat, Nama_obat, Harga_obat, Deskripsi_obat) VALUES('" & txtIdObat.Text & "','" & txtNamaObat.Text & "','" & txtHargaObat.Text & "','" & txtDesObat.Text & "')"
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

    Private Sub Obat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tampil()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtIdObat.Text = ""
        txtNamaObat.Text = ""
        txtHargaObat.Text = ""
        txtDesObat.Text = ""
        txtIdObat.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        simpan()
        Tampil()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim a As String = If(DataGridView1.SelectedCells.Count > 0, DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString(), "")
        If String.IsNullOrEmpty(a) Then
            MsgBox("Data yang dihapus belum DIPILIH")
        ElseIf MessageBox.Show("Anda yakin menghapus data dengan ID_obat = " & a & "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
            koneksi()
            cmd = New OdbcCommand("DELETE FROM tblobat WHERE ID_obat = ?", conn)
            cmd.Parameters.AddWithValue("@idObat", a)
            cmd.ExecuteNonQuery()
            MsgBox("Menghapus Data BERHASIL", vbInformation, "INFORMASI")
            Tampil()
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        MenuUtama.SendToBack()
    End Sub
End Class