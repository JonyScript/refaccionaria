Public Class menuAdministrador
    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        cnx.Close()
        Ventas.Show()
        Me.Close()
    End Sub

    Private Sub btnRegistroDeClientes_Click(sender As Object, e As EventArgs) Handles btnRegistroDeClientes.Click
        cnx.Close()
        RegistroDeClientes.Show()
        Me.Close()
    End Sub

    Private Sub btnRegistroDeProductos_Click(sender As Object, e As EventArgs) Handles btnRegistroDeProductos.Click
        cnx.Close()
        registroDeProductos.Show()
        Me.Close()
    End Sub

    Private Sub btnRegistroDeUsuarios_Click(sender As Object, e As EventArgs) Handles btnRegistroDeUsuarios.Click
        cnx.Close()
        Registro_de_usuarios.Show()
        Me.Hide()
    End Sub

    Private Sub btnCompraDeProductos_Click(sender As Object, e As EventArgs) Handles btnCompraDeProductos.Click
        cnx.Close()
        'compraDeProductos.Show()
        'Me.Close()
    End Sub

    Private Sub btnAnalisisDeVentas_Click(sender As Object, e As EventArgs) Handles btnAnalisisDeVentas.Click
        cnx.Close()
        'analisisDeVentas.Show()
        'Me.Close()
    End Sub

    Private Sub menuAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFecha.Text = Today
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Autenticación_de_usuarios.Show()
        Me.Close()
    End Sub
End Class