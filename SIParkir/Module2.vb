Module ModuleNavigation
    ' Fungsi untuk berpindah antar form
    Public Sub OpenForm(currentForm As Form, targetForm As Form)
        targetForm.Show()
        currentForm.Hide()
    End Sub
End Module
