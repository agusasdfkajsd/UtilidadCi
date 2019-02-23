Public Class Generador
    Inherits Verificacion
    Private cedulaArry(7) As String
    Private cedulaString As String
    Private digitoVerif As Integer

    Function generar() As String
        Dim rd As New Random()
        For i As Integer = 1 To 7
            cedulaArry(i) = rd.Next(1, 10)
            cedulaString += String.Concat(cedulaArry(i))
        Next
        digitoVerif = DigitoVerificador(cedulaString + "1")
        cedulaString += String.Concat(digitoVerif)
        Return cedulaString
    End Function

End Class
