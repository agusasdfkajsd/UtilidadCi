Public Class Verificacion
    Private digito As Integer
    Public Function verificacion(ced As String) As Integer
        If ced.Length <> 8 Then
            Return 0
        End If
        Dim sum As Integer = (Integer.Parse(ced.Chars(0)) * 8) + (Integer.Parse(ced.Chars(1)) * 1) + (Integer.Parse(ced.Chars(2)) * 2) + (Integer.Parse(ced.Chars(3)) * 3) + (Integer.Parse(ced.Chars(4)) * 4) + (Integer.Parse(ced.Chars(5)) * 7) + (Integer.Parse(ced.Chars(6)) * 6) Mod 10
        Dim a As String = ced.ElementAt(0)
        Dim modII As Integer = sum Mod 10
        digito = modII
        If modII = Integer.Parse(ced.Chars(7)) Then
            Return 1
        Else
            Return 2
        End If
    End Function

    Public Function DigitoVerificador(ced As String)
        verificacion(ced)
        Return digito
    End Function

End Class
