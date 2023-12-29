Imports System.Data.Odbc
Public Class Login
    Dim conn As OdbcConnection
    Dim dr As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim ds As DataSet
    Dim dt As DataTable
    Dim cmd As OdbcCommand
    Sub koneksi()
        Dim sql As String = "Driver{Mysql 3.3.0 driver};database=dbpuskesmas;server=localhost;uid=root "
        cmd = New OdbcCommand(sql, conn)
        Try
            conn = New OdbcConnection("Dsn=db puskesmas")
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Koneksi Gagal", ex.Message)
        End Try
    End Sub
    Private Sub lblUsername_Click(sender As Object, e As EventArgs) Handles lblUsername.Click

    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Username atau Password tidak boleh kosong!")
        Else
            Call koneksi()
            Dim query As String = "SELECT * FROM tblLogin WHERE username='" & txtUsername.Text & "' AND password='" & txtPassword.Text & "'"
            cmd = New OdbcCommand(query, conn)
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                MsgBox("Login berhasil!")
                MenuUtama.Show()
            Else
                MsgBox("Username atau Password salah!")
            End If

            dr.Close()
            conn.Close()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class
