Public Class FormFormutama


    Private Sub LanggananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LanggananToolStripMenuItem.Click
        Dim FormLangganan As New FormLangganan()
        FormLangganan.Show()
        Me.Hide()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        Dim FormLaporanPendapatanAkhir As New FormLaporanPendapatanAkhir()
        FormLaporanPendapatanAkhir.Show()
        Me.Hide()
    End Sub



    Private Sub FormUtama_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
