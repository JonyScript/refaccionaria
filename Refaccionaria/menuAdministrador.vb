﻿Public Class menuAdministrador
    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        cnx.Close()
        'ventas.Show()
        'Me.Close()
    End Sub

    Private Sub btnRegistroDeClientes_Click(sender As Object, e As EventArgs) Handles btnRegistroDeClientes.Click
        cnx.Close()
        'registroDeClientes.Show()
        'Me.Close()
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

    End Sub
End Class