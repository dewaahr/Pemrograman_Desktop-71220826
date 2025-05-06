Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmLaporan
    Private Sub btnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTutup.Click
        frmUtama.Show()
        Me.Hide()
    End Sub
    'Private Sub frmLaporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Me.ReportViewer1.RefreshReport()
    'End Sub

    Private Sub frmLaporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Isi data dan tampilkan laporan langsung saat form dibuka
        Try
            Dim ds As New DataSet1
            Dim myAdapter As New MySqlDataAdapter

            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If

            ' Ambil data dari MySQL
            'myAdapter.SelectCommand = New MySqlCommand("SELECT * FROM tblparkir", myConn)
            myAdapter.SelectCommand = New MySqlCommand("SELECT * FROM tblparkir WHERE DATE(waktu_masuk) = CURDATE()", myConn)

            myAdapter.Fill(ds.Tables(0))

            ' Konfigurasi ReportViewer
            ReportViewer1.Reset()
            ReportViewer1.ProcessingMode = ProcessingMode.Local
            ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1_LapParkir", ds.Tables(0)))

            ReportViewer1.DocumentMapCollapsed = True
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            MessageBox.Show("Gagal memuat laporan: " & ex.Message)
        End Try
    End Sub

    Private Sub btnLaporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLaporan.Click
        Dim ds As New DataSet1
        Dim myAdapter As New MySqlDataAdapter
        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If
        myAdapter.SelectCommand = New MySqlCommand("SELECT * FROM tblparkir", myConn)
        myAdapter.Fill(ds.Tables(0))

        ReportViewer1.Reset()
        ReportViewer1.ProcessingMode =
        Microsoft.Reporting.WinForms.ProcessingMode.Local
        ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory &
        "\Report1.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1_LapParkir", ds.Tables(0)))
        ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class