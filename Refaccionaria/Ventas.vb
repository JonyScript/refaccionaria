﻿Public Class Ventas
    Private codigoCliente As String

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblfecha.Text = Today
        dgvexist.ReadOnly = False
        dgvventa.ReadOnly = False

        llenarCombo(cmbcliente, "Select codigoCliente, nombre || ' ' || paterno || ' ' || materno as nombre from cliente", "codigoCliente", "Nombre")
        codigoCliente = cmbcliente.SelectedValue

        Dim datagridext As New ClaseVentas()
        datagridext.PoblarDataGridExist(dgvexist)
        cnx.Close()
    End Sub

    Private Sub dgvexist_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvexist.CellClick
        Dim renglon As Integer

        'Al darle clic al renglón del DGV mostramos los datos en las cajas de texto
        'el valor de cada celda es pasado a la caja de texto o combo correspondiente
        renglon = dgvexist.CurrentCellAddress.Y
        txtcodigoven.Text = dgvexist.Rows(renglon).Cells(0).Value
        txtnombreven.Text = dgvexist.Rows(renglon).Cells(1).Value
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Dim venta As New ClaseVentas()
        venta.insertarProducto(txtcodigoven.Text, txtcantidad.Text)
        venta.PoblarDataGridVentas(dgvventa)
        cnx.Close()
    End Sub

    Private Sub btnnuevaventa_Click(sender As Object, e As EventArgs) Handles btnnuevaventa.Click
        Dim venta As New ClaseVentas()
        venta.insertarVenta(codigoCliente)
        cnx.Close()
    End Sub

    Private Sub dgvventa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvventa.CellClick
        Dim renglon As Integer

        'Al darle clic al renglón del DGV mostramos los datos en las cajas de texto
        'el valor de cada celda es pasado a la caja de texto o combo correspondiente
        renglon = dgvexist.CurrentCellAddress.Y
        txtcodigoven.Text = dgvexist.Rows(renglon).Cells(0).Value
        txtnombreven.Text = dgvexist.Rows(renglon).Cells(1).Value
        txtnombreven.Text = dgvexist.Rows(renglon).Cells(4).Value
    End Sub

    Private Sub btnfactura_Click(sender As Object, e As EventArgs) Handles btnfactura.Click
        Dim webAddress As String = "https://www.factureya.com/Portal/Presentacion/Home/Index.aspx"
        Process.Start(webAddress)
    End Sub
End Class