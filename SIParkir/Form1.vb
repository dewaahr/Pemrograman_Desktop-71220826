Imports MySql.Data.MySqlClient

Public Class frmUtama


    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim sql As String
        Dim harga As Integer = 0
        Dim nomor As String = String.Empty

        If e.KeyCode = Keys.F1 Then
            jns = "Motor"
        ElseIf e.KeyCode = Keys.F2 Then
            jns = "Mobil"
        ElseIf e.KeyCode = Keys.F3 Then
            jns = "Taksi/Umum"
        ElseIf e.KeyCode = Keys.F4 Then
            jns = "Sepeda"
        ElseIf e.KeyCode = Keys.F5 Then
            jns = "Bus/Truk"
        End If

        lblInfoJenis.Text = jns

        If myConn.State = ConnectionState.Closed Then myConn.Open()

        If e.KeyCode = Keys.Return Then
            sql = "SELECT * FROM tblparkir WHERE no_plat='" & txtPlat.Text.ToUpper & "' AND waktu_keluar IS NULL AND DATE(`waktu_masuk`) = CURDATE()"

            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(sql, myConn)
            Else
                myCommand.CommandText = sql
            End If

            Dim hasil1 As MySqlDataReader = myCommand.ExecuteReader()

            If hasil1.HasRows Then
                If MessageBox.Show("Keluar dari Parkir?", "Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    hasil1.Read()
                    jns = hasil1("jenis").ToString
                    nomor = hasil1("id").ToString

                    Select Case jns
                        Case "Motor" : harga = 2000
                        Case "Mobil", "Taksi/Umum" : harga = 3000
                        Case "Sepeda" : harga = 1000
                        Case "Bus/Truk" : harga = 4000
                    End Select

                    If Not hasil1.IsClosed Then hasil1.Close()

                    sql = "UPDATE tblparkir SET waktu_keluar = CURRENT_TIMESTAMP(), harga = IF(CEIL((UNIX_TIMESTAMP(waktu_keluar) - UNIX_TIMESTAMP(waktu_masuk))/60/60) > 1, CEIL((UNIX_TIMESTAMP(waktu_keluar) - UNIX_TIMESTAMP(waktu_masuk))/60/60) * " & harga & ", " & harga & ") WHERE id = " & nomor
                    myCommand.CommandText = sql
                    myCommand.ExecuteNonQuery()

                    sql = "SELECT * FROM tblparkir WHERE id = " & nomor
                    myCommand.CommandText = sql
                    hasil1 = myCommand.ExecuteReader
                    hasil1.Read()
                    lblHarga.Text = "Rp. " & hasil1("harga").ToString
                    If Not hasil1.IsClosed Then hasil1.Close()
                    MsgBox("Sukses Keluar!")
                    jns = String.Empty
                End If
            Else
                If jns = String.Empty Then
                    MsgBox("Masukkan jenis kendaraan berikut:" & vbCrLf & lblJenis.Text)
                    hasil1.Close()
                    Exit Sub
                End If

                sql = "INSERT INTO tblparkir(no_plat, jenis, user) VALUES ('" & txtPlat.Text.ToUpper & "', '" & lblInfoJenis.Text & "', '" & pengguna & "')"
                If Not hasil1.IsClosed Then hasil1.Close()
                myCommand.CommandText = sql
                myCommand.ExecuteNonQuery()
                jns = String.Empty
            End If
        End If

        lblPlat.Text = txtPlat.Text.ToUpper
        RefreshGrid()
        HitungJumlah()
        If myConn.State = ConnectionState.Open Then myConn.Close()
    End Sub

    Private Sub LaporanPendapatanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPendapatanToolStripMenuItem.Click
        Dim frmLap As New frmLaporan
        frmLap.Show()
        Me.Hide()

    End Sub


    Public Sub RefreshGrid()

        Dim i As Integer = 0
        DataGridView1.Rows.Clear()
        Dim sql As String = "SELECT * FROM tblparkir WHERE DATE(`waktu_masuk`) = CURDATE()"
        If myConn.State = ConnectionState.Closed Then myConn.Open()
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sql, myConn)
        Else
            myCommand.CommandText = sql
        End If

        myDataReader = myCommand.ExecuteReader

        If myDataReader.HasRows Then
            While myDataReader.Read()
                DataGridView1.Rows.Add(myDataReader("no_plat"), myDataReader("waktu_masuk"), myDataReader("waktu_keluar"), myDataReader("harga"), myDataReader("jenis"), myDataReader("id"))
                i += 1
            End While
        End If

        If Not myDataReader.IsClosed Then myDataReader.Close()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If MessageBox.Show("Delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Dim sql As String = "DELETE FROM tblparkir WHERE id=" & DataGridView1.CurrentRow.Cells(5).Value.ToString
            MsgBox(sql)
            If myConn.State = ConnectionState.Closed Then myConn.Open()
            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(sql, myConn)
            Else
                myCommand.CommandText = sql
            End If

            Dim hasil As Integer = myCommand.ExecuteNonQuery
            If hasil = 1 Then
                MsgBox("Delete success!")
                RefreshGrid()
                HitungJumlah()
            End If
        End If
    End Sub

    Public Sub HitungJumlah()

        ' Implementasi logika perhitungan jumlah data atau pendapatan parkir.
        ' Misalnya menghitung total kendaraan yang masuk hari ini:
        Dim sql As String = "SELECT COUNT(*) FROM tblparkir WHERE DATE(waktu_masuk) = CURDATE()"

        If myConn.State = ConnectionState.Closed Then myConn.Open()

        Dim cmd As New MySqlCommand(sql, myConn)
        Dim hasil As Object = cmd.ExecuteScalar()

        lblJmlKendaraan.Text = "Total kendaraan hari ini: " & If(hasil Is DBNull.Value, "0", hasil.ToString())
    End Sub

    Private Sub AturProflToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AturProflToolStripMenuItem.Click
        OpenForm(Me, frmProfil)
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        OpenForm(Me, frmLogin)
    End Sub

    Private Sub frmUtama_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub LanggananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LanggananToolStripMenuItem.Click
        OpenForm(Me, frmLangganan)
    End Sub
    Private Sub BantuanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BantuanToolStripMenuItem1.Click
        MessageBox.Show("Cara Menggunakan Aplikasi Parkir:" & vbCrLf & vbCrLf &
                        "1. Masukkan plat nomor kendaraan di kolom input." & vbCrLf &
                        "2. Tekan tombol berikut untuk memilih jenis kendaraan:" & vbCrLf &
                        "   - F1: Motor" & vbCrLf &
                        "   - F2: Mobil" & vbCrLf &
                        "   - F3: Taksi/Umum" & vbCrLf &
                        "   - F4: Sepeda" & vbCrLf &
                        "   - F5: Bus/Truk" & vbCrLf &
                        "3. Tekan ENTER untuk menyimpan kendaraan masuk." & vbCrLf &
                        "4. Untuk kendaraan keluar, masukkan plat nomor dan tekan ENTER." & vbCrLf &
                        "5. Cek total pendapatan parkir di menu 'Laporan Pendapatan'." & vbCrLf &
                        "6. Klik 'Delete' untuk menghapus data kendaraan tertentu." & vbCrLf &
                        "7. Gunakan menu 'Logout' untuk keluar dari aplikasi." & vbCrLf & vbCrLf &
                        "Untuk bantuan lebih lanjut, hubungi admin.", "Bantuan Penggunaan", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub frmUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class

