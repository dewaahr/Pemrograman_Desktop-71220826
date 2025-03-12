Public Class Form2
    Public Event TimerUpdated(ByVal totalSeconds As Integer)
    Private jam As Integer = 0
    Private menit As Integer = 0
    Private detik As Integer = 0

    Private Sub UpdateDisplay()
        lblJam.Text = jam.ToString("D2")
        lblMenit.Text = menit.ToString("D2")
        lblDetik.Text = detik.ToString("D2") ' Tambahkan pembaruan detik
    End Sub

    Private Sub buttonPlusJam_Click(sender As Object, e As EventArgs) Handles buttonPlusJam.Click
        If jam < 99 Then ' Batasi hingga 99 jam
            jam += 1
        End If
        UpdateDisplay()
    End Sub


    Private Sub buttonMinusJam_Click(sender As Object, e As EventArgs) Handles buttonMinusJam.Click
        If jam > 0 Then jam -= 1
        UpdateDisplay()
    End Sub

    Private Sub buttonPlusMenit_Click(sender As Object, e As EventArgs) Handles buttonPlusMenit.Click
        If menit < 59 Then
            menit += 1
        Else
            menit = 0
            jam += 1 ' Tambahkan 1 jam jika menit mencapai 60
        End If
        UpdateDisplay()
    End Sub


    Private Sub buttonMinusMenit_Click(sender As Object, e As EventArgs) Handles buttonMinusMenit.Click
        If menit > 0 Then
            menit -= 1
        ElseIf jam > 0 Then
            jam -= 1
            menit = 59
        End If
        UpdateDisplay()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        jam = 0
        menit = 0
        detik = 0 ' 🔹 Reset detik juga
        UpdateDisplay()
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Dim totalSeconds As Integer = (jam * 3600) + (menit * 60) + detik

        ' Cek apakah waktu valid (tidak 0)
        If totalSeconds = 0 Then
            MessageBox.Show("Silakan atur waktu terlebih dahulu sebelum melanjutkan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Kirim waktu dalam detik ke Form1
        RaiseEvent TimerUpdated(totalSeconds)
        Form1.Show()
        Me.Close()
    End Sub



    ' 🔹 Tombol Plus Detik (+1)
    Private Sub ButtonPlusDetik_Click(sender As Object, e As EventArgs) Handles ButtonPlusDetik.Click
        If detik < 59 Then
            detik += 1
        Else
            detik = 0
            If menit < 59 Then
                menit += 1
            Else
                menit = 0
                jam += 1
            End If
        End If
        UpdateDisplay()
    End Sub


    ' 🔹 Tombol Minus Detik (-1)
    Private Sub ButtonMinusDetik_Click(sender As Object, e As EventArgs) Handles ButtonMinusDetik.Click
        If detik > 0 Then
            detik -= 1
        ElseIf menit > 0 Or jam > 0 Then
            detik = 59
            If menit > 0 Then
                menit -= 1
            ElseIf jam > 0 Then
                jam -= 1
                menit = 59
            End If
        End If
        UpdateDisplay()
    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class
