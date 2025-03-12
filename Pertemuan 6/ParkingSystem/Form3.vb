Public Class FormLangganan
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Dim FormFormutama As New FormFormutama()
        FormFormutama.Show()
        Me.Hide()
    End Sub


    Private Sub Formlangganan_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

End Class