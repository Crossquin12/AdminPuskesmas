Imports System.Data.Odbc

Public Class Poli
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
        Dim sql As String = "INSERT INTO tblpoli VALUES (?, ?, ?, ?, ?)"
        cmd = New OdbcCommand(sql, conn)

        cmd.Parameters.AddWithValue("@idPoli", txtIdPoli.Text)
        cmd.Parameters.AddWithValue("@namaPoli", ComboBox1.Text)
        cmd.Parameters.AddWithValue("@namaDokter", txtNamaDokter.Text)
        cmd.Parameters.AddWithValue("@spesialisasi", txtSpesialisasi.Text)
        cmd.Parameters.AddWithValue("@diagnosaDokter", txtDiagnosa.Text)

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
            da = New OdbcDataAdapter("SELECT * FROM tblpoli ORDER BY ID_poli ASC", conn)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                DataGridView1.Rows.Add(row(0), row(1), row(2), row(3), row(4))
            Next
        Catch ex As Exception
            MsgBox("Menampilkan data Gagal")
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Sub tampilDokter()
        koneksi()
        cmd = New OdbcCommand("SELECT ID_dokter FROM tbdokter", conn)
        dr = cmd.ExecuteReader
        ComboBox2.Items.Clear()
        Do While dr.Read
            ComboBox2.Items.Add(dr.Item("ID_dokter"))
        Loop
        dr.Close()
    End Sub

    Private Sub Poli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tampil()
        tampilDokter()
        ComboBox1.Items.AddRange({"Poli Umum", "Poli THT", "Poli Jantung", "Poli Paru", "Poli Penyakit Dalam"})

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        koneksi()
        cmd = New OdbcCommand("SELECT * FROM tbdokter WHERE ID_dokter='" & ComboBox2.Text & "'", conn)

        Try
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                txtNamaDokter.Text = dr("Nama_dokter").ToString()
                txtSpesialisasi.Text = dr("Spesialisasi").ToString()
            Else
                MsgBox("Dokter Tidak ditemukan")
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
        txtIdPoli.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        txtNamaDokter.Text = ""
        txtSpesialisasi.Text = ""
        txtDiagnosa.Text = ""
        txtIdPoli.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        simpan()
        Tampil()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim a As String = If(DataGridView1.SelectedCells.Count > 0, DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString(), "")
        If String.IsNullOrEmpty(a) Then
            MsgBox("Data yang dihapus belum DIPILIH")
        ElseIf MessageBox.Show("Anda yakin menghapus data dengan ID_poli = " & a & "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
            koneksi()
            cmd = New OdbcCommand("DELETE FROM tblpoli WHERE ID_poli = ?", conn)
            cmd.Parameters.AddWithValue("@idPoli", a)
            cmd.ExecuteNonQuery()
            MsgBox("Menghapus Data BERHASIL", vbInformation, "INFORMASI")
            Tampil()
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        MenuUtama.SendToBack()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblKataDokter.Click

    End Sub
End Class
