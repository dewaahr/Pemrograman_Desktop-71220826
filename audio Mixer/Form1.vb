Imports NAudio.CoreAudioApi
Imports NAudio.CoreAudioApi.Interfaces
Imports System.Diagnostics

Public Class Form1
    Dim enumerator As New MMDeviceEnumerator()
    Dim outputDevices As MMDeviceCollection
    Dim inputDevices As MMDeviceCollection
    Dim selectedOutputDevice As MMDevice
    Dim selectedInputDevice As MMDevice
    Dim appSessions As New Dictionary(Of String, AudioSessionControl)
    Dim capture As New NAudio.Wave.WasapiLoopbackCapture()
    Private fadeOutTimer As New Timer()
    Private targetVolume As Single
    Private remainingTime As Integer
    Private WithEvents TimerAudioProgress As New Timer()


    Private progressAudio As New ProgressBar()



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        ' Ambil daftar perangkat output (speaker/headphone) yang aktif
        outputDevices = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active)
        capture.StartRecording()
        For Each dev As MMDevice In outputDevices
            ComboBoxOutputDevice.Items.Add(dev.FriendlyName)
        Next

        ' Ambil daftar perangkat input (microphone) yang aktif
        inputDevices = enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active)
        For Each dev As MMDevice In inputDevices
            inputdvc.Items.Add(dev.FriendlyName)
        Next

        ' Pilih perangkat pertama jika ada
        If ComboBoxOutputDevice.Items.Count > 0 Then
            ComboBoxOutputDevice.SelectedIndex = 0
        End If
        If inputdvc.Items.Count > 0 Then
            inputdvc.SelectedIndex = 0
        End If

        ' Atur volume perangkat output awal dengan validasi
        selectedOutputDevice = outputDevices(ComboBoxOutputDevice.SelectedIndex)
        volume.Minimum = 0
        volume.Maximum = 100
        Dim vol As Integer = CInt(selectedOutputDevice.AudioEndpointVolume.MasterVolumeLevelScalar * 100)
        volume.Value = Math.Max(volume.Minimum, Math.Min(volume.Maximum, vol))
        volumeindex.Text = volume.Value & "%"

        ' Atur volume perangkat input awal ke MAX (100%)
        selectedInputDevice = inputDevices(inputdvc.SelectedIndex)
        selectedInputDevice.AudioEndpointVolume.MasterVolumeLevelScalar = 1.0F ' 100%

        ' Atur TrackBar volume aplikasi
        TrackBarApp1.Minimum = 0
        TrackBarApp1.Maximum = 100
        TrackBarApp2.Minimum = 0
        TrackBarApp2.Maximum = 100
        TrackBarApp1.Value = 100
        TrackBarApp2.Value = 100

        'deteksiapps
        TimerAppDetect.Interval = 2000 ' 1000 = 1 detik
        AddHandler TimerAppDetect.Tick, AddressOf TimerAppDetect_Tick
        TimerAppDetect.Start()




        ' Mulai timer untuk mendeteksi aplikasi pemutar audio
        Timer1.Interval = 2000 ' 1000 = 1 detik


        'timer button
        fadeOutTimer.Interval = 500 ' Setiap 500ms
        AddHandler fadeOutTimer.Tick, AddressOf FadeOutAudio


        ' Timer untuk memperbarui progress bar audio
        TimerAudioProgress.Interval = 100 ' Update setiap 100ms
        AddHandler TimerAudioProgress.Tick, AddressOf UpdateAudioProgress
        TimerAudioProgress.Start()


        ' Tambahkan ProgressBar ke Form saat Load
        progressAudio = New CustomProgressBar()
        With progressAudio
            .Size = New Size(250, 20)
            .Location = New Point(80, 120) '16, 149
            .Minimum = 0
            .Maximum = 100
            .Value = 0
        End With

        Me.Controls.Add(progressAudio)



    End Sub

    Private Sub UpdateAudioProgress(sender As Object, e As EventArgs)
        If selectedOutputDevice IsNot Nothing Then
            ' Ambil level audio saat ini (0.0 - 1.0)
            Dim audioLevel As Single = selectedOutputDevice.AudioMeterInformation.MasterPeakValue

            ' Ubah menjadi nilai 0 - 100 untuk ProgressBar
            Dim progressValue As Integer = CInt(audioLevel * 100)

            ' Pastikan nilai dalam batas ProgressBar
            progressAudio.Value = Math.Max(0, Math.Min(100, progressValue))
        End If
    End Sub


    Private Sub TimerAppDetect_Tick(sender As Object, e As EventArgs)
        Dim activeApps As New List(Of String)
        appSessions.Clear() ' Hapus daftar sesi sebelumnya

        Try
            Dim sessions = selectedOutputDevice.AudioSessionManager.Sessions
            For i As Integer = 0 To sessions.Count - 1
                Dim session = sessions(i)

                ' Pastikan sesi aktif dan memiliki audio
                If session.State = AudioSessionState.AudioSessionStateActive Then
                    Try
                        Dim process As Process = Process.GetProcessById(session.GetProcessID)
                        activeApps.Add(process.ProcessName)
                        appSessions(process.ProcessName) = session ' Simpan sesi
                    Catch ex As Exception
                        Continue For ' Jika gagal mengambil ID proses, lanjutkan
                    End Try
                End If
            Next
        Catch ex As Exception
            activeApps.Clear()
        End Try

        ' Perbarui label aplikasi yang sedang memutar audio
        ' Sembunyikan label dan TrackBar jika tidak ada aplikasi yang memutar audio
        If activeApps.Count > 0 Then
            VApp.Text = activeApps(0)
            VApp.Visible = True
            TrackBarApp1.Visible = True
        Else
            VApp.Text = "Playing: -"
            VApp.Visible = False
            TrackBarApp1.Visible = False
        End If

        If activeApps.Count > 1 Then
            VApp2.Text = activeApps(1)
            VApp2.Visible = True
            TrackBarApp2.Visible = True
        Else
            VApp2.Text = "Playing: -"
            VApp2.Visible = False
            TrackBarApp2.Visible = False
        End If

    End Sub


    Private Sub ComboBoxOutputDevice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxOutputDevice.SelectedIndexChanged
        selectedOutputDevice = outputDevices(ComboBoxOutputDevice.SelectedIndex)
        Dim vol As Integer = CInt(selectedOutputDevice.AudioEndpointVolume.MasterVolumeLevelScalar * 100)
        If vol > volume.Maximum Then vol = volume.Maximum
        If vol < volume.Minimum Then vol = volume.Minimum
        volume.Value = vol
        volumeindex.Text = volume.Value & "%"
    End Sub

    Private Sub volume_Scroll(sender As Object, e As EventArgs) Handles volume.Scroll
        If selectedOutputDevice IsNot Nothing Then
            Dim volumeLevel As Single = volume.Value / 100.0F
            selectedOutputDevice.AudioEndpointVolume.MasterVolumeLevelScalar = volumeLevel
            volumeindex.Text = volume.Value & "%"
        End If
    End Sub

    Private Sub inputdvc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles inputdvc.SelectedIndexChanged
        selectedInputDevice = inputDevices(inputdvc.SelectedIndex)
        selectedInputDevice.AudioEndpointVolume.MasterVolumeLevelScalar = 1.0F ' 100%
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If remainingTime > 0 Then
            remainingTime -= 1

            ' Hitung jam, menit, dan detik yang benar
            Dim hours As Integer = remainingTime \ 3600
            Dim minutes As Integer = (remainingTime Mod 3600) \ 60
            Dim secs As Integer = remainingTime Mod 60

            ' Perbarui tampilan label
            timermusic.Text = $"Timer: {hours:D2}.{minutes:D2}.{secs:D2}"
        Else
            Timer1.Stop()
            targetVolume = 0.0F
            fadeOutTimer.Start()
        End If
    End Sub


    ' Mengubah volume aplikasi pertama (VApp) dengan TrackBar
    Private Sub TrackBarApp1_Scroll(sender As Object, e As EventArgs) Handles TrackBarApp1.Scroll
        If appSessions.ContainsKey(VApp.Text) Then
            Dim session = appSessions(VApp.Text)
            session.SimpleAudioVolume.Volume = TrackBarApp1.Value / 100.0F
        End If
    End Sub

    ' Mengubah volume aplikasi kedua (VApp2) dengan TrackBar
    Private Sub TrackBarApp2_Scroll(sender As Object, e As EventArgs) Handles TrackBarApp2.Scroll
        If appSessions.ContainsKey(VApp2.Text) Then
            Dim session = appSessions(VApp2.Text)
            session.SimpleAudioVolume.Volume = TrackBarApp2.Value / 100.0F
        End If
    End Sub

    Private Sub FadeOutAudio(sender As Object, e As EventArgs)
        If selectedOutputDevice IsNot Nothing Then
            Dim currentVolume As Single = selectedOutputDevice.AudioEndpointVolume.MasterVolumeLevelScalar
            If currentVolume > targetVolume Then
                currentVolume -= 0.05F
                If currentVolume < targetVolume Then currentVolume = targetVolume
                selectedOutputDevice.AudioEndpointVolume.MasterVolumeLevelScalar = currentVolume
                volume.Value = CInt(currentVolume * 100)
                volumeindex.Text = volume.Value & "%"
            Else
                fadeOutTimer.Stop()
            End If
        End If
    End Sub
    Private Sub UpdateTimerLabel()
        If remainingTime > 0 Then
            Dim hours As Integer = remainingTime \ 3600
            Dim minutes As Integer = (remainingTime Mod 3600) \ 60
            Dim seconds As Integer = remainingTime Mod 60
            timermusic.Text = $"Timer: {hours:D2}:{minutes:D2}:{seconds:D2}" ' Pakai ":" agar formatnya seperti jam biasa (hh:mm:ss)


            remainingTime -= 1
        Else
            Timer1.Stop()
            targetVolume = 0.0F
            fadeOutTimer.Start()
        End If
    End Sub






    Private Sub ButtonTimer_Click(sender As Object, e As EventArgs) Handles ButtonTimer.Click
        Dim form2 As New Form2()
        AddHandler form2.TimerUpdated, AddressOf UpdateTimer
        AddHandler form2.FormClosed, Sub(sender2, e2) Me.Show() ' Tampilkan Form1 kembali saat Form2 ditutup
        form2.Show()
        Me.Hide()

    End Sub



    Private Sub UpdateTimer(seconds As Integer)
        remainingTime = seconds
        Dim hours As Integer = remainingTime \ 3600
        Dim minutes As Integer = (remainingTime Mod 3600) \ 60
        Dim secs As Integer = remainingTime Mod 60
        timermusic.Text = $"Timer: {hours:D2}:{minutes:D2}:{secs:D2}"

        If remainingTime > 0 Then
            Timer1.Interval = 1000 ' Update setiap detik
            Timer1.Start()
        Else
            targetVolume = 0.0F
            fadeOutTimer.Interval = remainingTime * 10 ' 🔹 Perbaiki kesalahan di sini
            fadeOutTimer.Start()
        End If
    End Sub



End Class



Public Class CustomProgressBar
    Inherits ProgressBar

    Public Sub New()
        Me.SetStyle(ControlStyles.UserPaint, True) ' Aktifkan custom rendering
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics
        Dim rect As Rectangle = Me.ClientRectangle
        Dim fillRect As New Rectangle(0, 0, CInt(rect.Width * (Me.Value / 100.0)), rect.Height)

        ' Warna latar belakang
        g.FillRectangle(Brushes.White, rect)

        ' Warna bar (Orange)
        g.FillRectangle(Brushes.Orange, fillRect)
    End Sub

    ' Metode untuk memperbarui tampilan ProgressBar
    Public Sub UpdateProgress(value As Integer)
        Me.Value = Math.Max(Me.Minimum, Math.Min(Me.Maximum, value))
        Me.Invalidate() ' Paksa redraw
    End Sub
End Class
