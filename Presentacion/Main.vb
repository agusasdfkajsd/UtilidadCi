Public Class Main
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint



    End Sub

    Private Sub AccionSalir(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub

    Private Sub VerifClick(sender As Object, e As EventArgs) Handles Verif.Click
        Dim tempStatus As Char
        Try
            tempStatus = Fachada.GetInstancia.Verificar(campo.Text)
        Catch
            MsgBox("La cédula sólo puede contener números y la misma debe ser de 8 dígitos", MsgBoxStyle.Critical, "Error")
        End Try

        If tempStatus = "l" Then
            MsgBox("La cédula sólo puede contener números y la misma debe ser de 8 dígitos", MsgBoxStyle.Critical, "Error")
        End If
        If tempStatus = "v" Then
            mensaje.Text = "Cédula válida"
        ElseIf tempStatus = "d" Then
            mensaje.Text = "Cédula inválida"
        End If

    End Sub

    Private Sub GenerarClick(sender As Object, e As EventArgs) Handles generar.Click
        campo.Clear()
        campo.Text = Fachada.GetInstancia.generarCedula
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles mensaje.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub limpiarClick(sender As Object, e As EventArgs) Handles limpiar.Click
        campo.Clear()
        mensaje.Text = ""
    End Sub

    Private Sub generarDigito_Click(sender As Object, e As EventArgs) Handles generarDigito.Click
        If campo.Text.Length < 7 Then
            MsgBox("La cédula ingresada no es válida", MsgBoxStyle.Critical, "Error")
        Else
            If campo.Text.Length = 7 Then
                Try
                    campo.Text += Fachada.GetInstancia.generarDigito(campo.Text)
                Catch
                    MsgBox("La cédula ingresada no es válida", MsgBoxStyle.Critical, "Error")
                End Try
            Else
                MsgBox("El dígito ya se ha generado o la cédula ingresada no es válida", MsgBoxStyle.Information, "Advertencia")
            End If
        End If
    End Sub
End Class
