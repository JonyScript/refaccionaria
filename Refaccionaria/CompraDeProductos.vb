Public Class CompraDeProductos
    Private codigoProveedor As String

    Private Sub Compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formPrev = "compras"
        lblfecha.Text = Today
        dgvexist2.ReadOnly = False
        dgvcompra.ReadOnly = False

        llenarCombo(cmbproovedor, "Select codigoProveedor, nombre as nombre from proveedor where eliminado = 0", "codigoProveedor", "Nombre")
        codigoProveedor = cmbproovedor.SelectedValue

        'botones y controles inicialmente escondidos / desactivados
        btnagregar.Enabled = False
        btnremover.Enabled = False
        btnnota.Enabled = False
        btnfactura.Enabled = False
        btnconfirmar.Enabled = False
        dgvcompra.Hide()

        Dim datagridext As New ClaseCompras()
        datagridext.PoblarDataGridExist2(dgvexist2)
        cnx.Close()
    End Sub

    Private Sub dgvexist_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvexist2.CellClick
        txtcantidad.Clear()
        Dim renglon As Integer

        'Al darle clic al renglón del DGV mostramos los datos en las cajas de texto
        'el valor de cada celda es pasado a la caja de texto o combo correspondiente
        renglon = dgvexist2.CurrentCellAddress.Y
        txtcodigocom.Text = dgvexist2.Rows(renglon).Cells(0).Value
        txtnombrecom.Text = dgvexist2.Rows(renglon).Cells(1).Value
        PrecioVenta.Text = dgvexist2.Rows(renglon).Cells(4).Value
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        'boton para agregar productos a una venta / agregar registros a compra detallada
        Dim compra As New ClaseCompras()
        If compra.consultaUnProducto(txtcodigocom.Text) = False Then
            compra.insertarProducto(txtcodigocom.Text, txtcantidad.Text, PrecioCompra.Text)
        Else
            MsgBox("Este producto ya ha sido insertado en la venta actual")
        End If

        compra.PoblarDataGridCompra(dgvcompra)
        compra.PoblarDataGridExist2(dgvexist2)
        cnx.Close()
        txtcantidad.Clear()
        txtcodigocom.Clear()
        txtnombrecom.Clear()
        PrecioCompra.Clear()
        PrecioVenta.Clear()
        txttotal.Text = compra.getTotal
    End Sub
    'cmbproovedor
    ' Private Sub btnnuevacompra_Click(sender As Object, e As EventArgs) Handles btnnuevacompra.Click
    '    'activar inicialmente escondidos
    '   btnagregar.Enabled = True
    '  btnnuevacompra.Enabled = False
    ' btnconfirmar.Enabled = True
    'dgvcompra.Show()
    'codigoProveedor = cmbproovedor.SelectedValue

    '    Dim compra As New ClaseCompras()
    '       compra.insertarCompra(codigoProveedor)
    '      cnx.Close()
    ' End Sub
    Private Sub cmbproovedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbproovedor.DropDownClosed
        btnagregar.Enabled = True
        'btnnuevaventa.Enabled = False
        btnconfirmar.Enabled = True
        dgvcompra.Show()
        codigoProveedor = cmbproovedor.SelectedValue

        Dim compra As New ClaseCompras()
        compra.insertarCompra(codigoProveedor)
        cnx.Close()
    End Sub
    Private Sub dgvcompra_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcompra.CellClick
        btnremover.Enabled = True
        Dim renglon As Integer

        'Al darle clic al renglón del DGV mostramos los datos en las cajas de texto
        'el valor de cada celda es pasado a la caja de texto o combo correspondiente
        renglon = dgvcompra.CurrentCellAddress.Y
        txtcodigocom.Text = dgvcompra.Rows(renglon).Cells(0).Value
        txtnombrecom.Text = dgvcompra.Rows(renglon).Cells(1).Value
        txtcantidad.Text = dgvcompra.Rows(renglon).Cells(5).Value
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        If puestoUsuario = 1 Then
            menuAdministrador.Show()
        ElseIf puestoUsuario = 2 Then
            menuVendedor.Show()
        End If
        Me.Close()
    End Sub

    Private Sub btnfactura_Click(sender As Object, e As EventArgs) Handles btnfactura.Click
        'boton para generar facturas abre navegador en pagina de factureya, pendiente de añadir credenciales de inicio de sesion de la refaccionaria
        Dim webAddress As String = "https://www.factureya.com/Portal/Presentacion/Home/Index.aspx"
        Process.Start(webAddress)
    End Sub

    Private Sub btnconfirmar_Click(sender As Object, e As EventArgs) Handles btnconfirmar.Click
        'al confirmar venta se desactiva el boton para agregar y remover productos
        btnagregar.Enabled = False
        btnremover.Enabled = False
        btnnota.Enabled = True
        btnfactura.Enabled = True
        btnconfirmar.Enabled = False
        Dim compra As New ClaseCompras()
        txttotal.Text = compra.getTotal()
        compra.insertarTotal(compra.getTotal())
        cnx.Close()
    End Sub
    Private Sub btnremover_Click(sender As Object, e As EventArgs) Handles btnremover.Click
        Dim compras As New ClaseCompras()
        compras.eliminarProducto(txtcodigocom.Text, txtcantidad.Text)
        compras.PoblarDataGridExist2(dgvexist2)
        compras.PoblarDataGridCompra(dgvcompra)
        cnx.Close()
        btnremover.Enabled = False
        txtcantidad.Clear()
        txtcodigocom.Clear()
        txtnombrecom.Clear()
        PrecioCompra.Clear()
        PrecioVenta.Clear()

    End Sub

    Private Sub btnnota_Click(sender As Object, e As EventArgs) Handles btnnota.Click
        cnx.Close()
        NotasCompra.Show()
        Me.Close()
    End Sub

    Private Sub btnregistro_Click(sender As Object, e As EventArgs) Handles btnregistro.Click
        cnx.Close()
        RegistroDeCompras.Show()
        Me.Close()
    End Sub

    Private Sub btncliente_Click(sender As Object, e As EventArgs) Handles btnproveedor.Click
        cnx.Close()
        nuevoProveedor.Show()
        Me.Close()
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim compra As New ClaseCompras()
        compra.PoblarDataGridExist2(dgvexist2)
        txtcodigoprod.Clear()
        txtnombreprod.Clear()
        PrecioCompra.Clear()
        PrecioVenta.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        registroDeProductos.Show()
        Me.Close()

    End Sub
End Class