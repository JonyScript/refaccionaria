﻿Public Class menuVendedor
    Private Sub btnVentas2_Click(sender As Object, e As EventArgs) Handles btnVentas2.Click
        cnx.Close()
        Ventas.Show()
        Me.Close()
    End Sub

    Private Sub btnRegistroDeClientes2_Click(sender As Object, e As EventArgs) Handles btnRegistroDeClientes2.Click
        cnx.Close()
        RegistroDeClientes.Show()
        Me.Close()
    End Sub

    Private Sub btnCompraDeProductos2_Click(sender As Object, e As EventArgs) Handles btnCompraDeProductos2.Click
        cnx.Close()
        CompraDeProductos.Show()
        Me.Close()
    End Sub

    Private Sub btnAnalisisDeVentas2_Click(sender As Object, e As EventArgs) Handles btnAnalisisDeVentas2.Click
        cnx.Close()
        AnalisisDeVentas.Show()
        Me.Close()
    End Sub

    Private Sub MenuVendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblfecha2.Text = Today

    End Sub

    Private Sub CerrarSesion_Click(sender As Object, e As EventArgs)
        Autenticación_de_usuarios.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Autenticación_de_usuarios.Show()
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblfecha2.Click

    End Sub
End Class