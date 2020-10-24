Public Class Autenticación_de_usuarios
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        Dim usuario As New ClaseLogin(txtNombreDeUsuario.Text, txtContraseña.Text)
        If usuario.consultausuario() = False Then
            MsgBox("Usuario no registrado", MsgBoxStyle.Information)
            cnx.Close()
        ElseIf puestoUsuario = 1 Then
            cnx.Close()
            MsgBox("administrador")
            'menuadministrador.show()
            'Me.Close()
        ElseIf puestoUsuario = 2 Then
            cnx.Close()
            MsgBox("vendedor")
            'menuvendedor.show()
            'Me.Close()
        End If

    End Sub

    Private Sub TxtContraseña_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged

    End Sub
End Class