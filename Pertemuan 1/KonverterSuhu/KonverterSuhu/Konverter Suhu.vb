Public Class Form1
    Private Sub ButtonConvert_Click(sender As Object, e As EventArgs) Handles ButtonConvert.Click

        Dim celcius, fahrenheit, reamur, kelvin As Double
        celcius = Val(valCelc.Text)
        fahrenheit = 9 / 5 * (celcius) + 32
        reamur = 4 / 5 * (celcius)
        kelvin = celcius + 273
        val1.Text = CStr(fahrenheit)
        val3.Text = CStr(kelvin)
        val2.Text = CStr(reamur)

    End Sub
End Class
