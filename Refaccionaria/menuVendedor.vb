Public Class menuVendedor
    Private Sub btnVentas2_Click(sender As Object, e As EventArgs) Handles btnVentas2.Click
        cnx.Close()
        'ventas.Show()
        'Me.Close()
    End Sub

    Private Sub btnRegistroDeClientes2_Click(sender As Object, e As EventArgs) Handles btnRegistroDeClientes2.Click
        cnx.Close()
        RegistroDeClientes.Show()
        Me.Close()
    End Sub

    Private Sub btnCompraDeProductos2_Click(sender As Object, e As EventArgs) Handles btnCompraDeProductos2.Click
        cnx.Close()
        'compraDeProductos.Show()
        'Me.Close()
    End Sub

    Private Sub btnAnalisisDeVentas2_Click(sender As Object, e As EventArgs) Handles btnAnalisisDeVentas2.Click
        cnx.Close()
        'analisisDeVentas.Show()
        'Me.Close()
    End Sub

    Private Sub MenuVendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class