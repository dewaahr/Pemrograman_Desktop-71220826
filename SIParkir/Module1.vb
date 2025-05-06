Module Program
    Public Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        Dim mainForm As New frmUtama()
        Application.Run(mainForm) ' Pastikan aplikasi hanya berjalan jika form utama masih ada
    End Sub
End Module
