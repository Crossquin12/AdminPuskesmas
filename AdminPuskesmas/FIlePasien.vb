Imports System.Data.Odbc
Imports System.Drawing.Printing

Public Class FilePasien
    Dim conn As OdbcConnection
    Dim cmd As OdbcCommand
    Dim dr As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim dt As DataTable
    Dim YourPrintDocument As New PrintDocument

    Sub koneksi()
        conn = New OdbcConnection("dsn=db puskesmas")
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
    End Sub

    Private Sub FilePasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            koneksi()
            ComboBox1.Items.Clear()
            cmd = New OdbcCommand("SELECT No_tr FROM tblpembayaran", conn)
            dr = cmd.ExecuteReader()

            Do While dr.Read()
                ComboBox1.Items.Add(dr("No_tr").ToString())
            Loop

            dr.Close()

            conn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            koneksi()
            ComboBox1.Items.Clear()

            cmd = New OdbcCommand("SELECT No_tr FROM tblpembayaran", conn)
            dr = cmd.ExecuteReader()
            Do While dr.Read()
                ComboBox1.Items.Add(dr("No_tr").ToString())
            Loop
            dr.Close()
            If ComboBox1.Items.Contains(ComboBox1.Text) Then
                cmd = New OdbcCommand("SELECT * FROM tblpembayaran WHERE No_tr='" & ComboBox1.Text & "'", conn)
                dr = cmd.ExecuteReader()

                If dr.Read() Then
                    lblNama.Text = dr("Nama_pasien").ToString()
                    lblTglLahir.Text = dr("Tgl_lahir").ToString()
                    lblAlamat.Text = dr("Alamat").ToString()
                    lblNoTelp.Text = dr("No_telepon").ToString()
                    lblJenisKelamin.Text = dr("Jenis_kelamin").ToString()
                    lblTglPerawatan.Text = dr("Tanggal_perawatan").ToString()
                    lblKeluhan.Text = dr("Keluhan").ToString()
                    lblNamaPoli.Text = dr("Nama_poli").ToString()
                    lblDokter.Text = dr("Nama_dokter").ToString()
                    lblDiagnosa.Text = dr("Diagnosa").ToString()
                    lblResepObat.Text = dr("Deskripsi_obat").ToString()
                    lblHarga.Text = dr("Harga").ToString()
                Else
                    MsgBox("Data Tidak ditemukan")
                End If
                dr.Close()
            Else
                MsgBox("No_tr tidak valid.")
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical, "Error")
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        ' Menetapkan PrintDocument ke event PrintPage
        AddHandler YourPrintDocument.PrintPage, AddressOf PrintDocument_PrintPage

        ' Menampilkan dialog cetak
        Dim printDialog As New PrintDialog()
        printDialog.Document = YourPrintDocument
        If printDialog.ShowDialog() = DialogResult.OK Then
            ' Mencetak
            YourPrintDocument.Print()
        End If
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs)
        ' Menggambar isi form pada kertas
        Dim bmp As New Bitmap(Me.Width, Me.Height)
        Me.DrawToBitmap(bmp, New Rectangle(0, 0, Me.Width, Me.Height))
        e.Graphics.DrawImage(bmp, 0, 0)
    End Sub
End Class
