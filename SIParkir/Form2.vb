Public Class FormLaporanPendapatanAkhir
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FormFormutama As New frmUtama()
        FormFormutama.Show()
        Me.Hide()
    End Sub
    Private Sub Formlaporan_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

End Class