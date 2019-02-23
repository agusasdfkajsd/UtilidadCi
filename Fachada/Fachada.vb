Public Class Fachada
    Private Shared instancia As Fachada

    Public Shared Function GetInstancia() As Fachada
        If instancia Is Nothing Then
            instancia = New Fachada()
        End If
        Return instancia
    End Function

    Public Function Verificar(ced As String) As Char
        Dim a As Verificacion = New Verificacion()
        REM V INDICA VERDADERO, L INDICA ERROR EN EL LARGO, D INDICA ERROR EN EL DIGITO Y X INDICA ERROR DESCONOCIDO
        Dim tempStatus As Integer = a.verificacion(ced)
        If tempStatus = 1 Then
            Return "v"
        ElseIf tempStatus = 0 Then
            Return "l"
        ElseIf tempStatus = 2 Then
            Return "d"
        End If
    End Function

    Public Function generarCedula() As String
        Dim a As Generador = New Generador()
        Return a.generar()
    End Function

    Public Function generarDigito(ced As String) As String
        Dim a As Verificacion = New Verificacion()
        Return a.DigitoVerificador(ced + "1")
    End Function

End Class
