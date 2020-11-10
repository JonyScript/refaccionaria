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
            menuAdministrador.Show()
            Me.Hide()
        ElseIf puestoUsuario = 2 Then
            cnx.Close()
            menuVendedor.Show()
            Me.Hide()
        End If
        txtNombreDeUsuario.Clear()
        txtContraseña.Clear()
    End Sub

    Private Sub TxtContraseña_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged

    End Sub

    Private Sub Autenticación_de_usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class