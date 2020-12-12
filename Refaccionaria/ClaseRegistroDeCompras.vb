Public Class ClaseRegistroDeCompras

    Public Function consultaCompra() As Object
        'Método para listar a todos los usuarios en el DGV
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "SELECT compra.codigoCompra as codigo, to_char(totalCompra, 'fm99990.00') as total, proveedor.nombre as proveedor, " &
                 "usuario.nombre || ' ' || usuario.paterno || ' ' || usuario.materno as vendedor, fechaCompra as fecha " &
                 "From compra, usuario, proveedor where compra.codigoProveedor = proveedor.codigoProveedor and " &
                 "compra.codigoUsuario = usuario.codigoUsuario and usuario.eliminado = 0 and proveedor.eliminado = 0 Order By codigo"
        consultaCompra = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Function consultaCompraDetallada(ByVal cdg As String) As Object
        'Método para listar a todos los usuarios en el DGV
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "SELECT compraDetallada.codigoProducto as codigo,nombreProducto as producto,marca.descripcion as marca, medida.descripcion as medida,to_char(precioCompra, 'fm99990.00') as precio, cantidadProducto as cantidad, to_char(precioCompra * cantidadProducto, 'fm99990.00') as importe " &
                 "From producto, medida, compraDetallada, compra, marca where producto.codigoMarca = marca.codigoMarca and producto.codigoMedida = medida.codigoMedida and producto.codigoProducto = compraDetallada.codigoProducto " &
                 "and compra.codigoCompra = compraDetallada.codigoCompra and eliminado = 0 and compra.codigoCompra = " & cdg & " Order By codigo"
        consultaCompraDetallada = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridCompra(ByVal DGVDCompra As DataGridView)

        'Llamamos al método que obtiene los registros de los usuarios
        DGVDCompra.DataSource = consultaCompra()
        DGVDCompra.Refresh()
        'Establecer ancho de cada columna del DataGridView, el 
        'número de columnas del DGV debe ser igual al número
        'de atributos recuperados en el query del método
        'consultaTodosUsuarios
        DGVDCompra.Columns.Item(0).Width = 150
        DGVDCompra.Columns.Item(1).Width = 150
        DGVDCompra.Columns.Item(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVDCompra.Columns.Item(2).Width = 150
        DGVDCompra.Columns.Item(3).Width = 150
        DGVDCompra.Columns.Item(4).Width = 150
    End Sub

    Public Sub PoblarDataGridCompraDetallada(ByVal DGVDProd As DataGridView, ByVal cdg As String)

        'Llamamos al método que obtiene los registros de los usuarios
        DGVDProd.DataSource = consultaCompraDetallada(cdg)
        DGVDProd.Refresh()
        'Establecer ancho de cada columna del DataGridView, el 
        'número de columnas del DGV debe ser igual al número
        'de atributos recuperados en el query del método
        'consultaTodosUsuarios
        DGVDProd.Columns.Item(0).Width = 100
        DGVDProd.Columns.Item(1).Width = 200
        DGVDProd.Columns.Item(2).Width = 100
        DGVDProd.Columns.Item(3).Width = 100
        DGVDProd.Columns.Item(4).Width = 100
        DGVDProd.Columns.Item(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVDProd.Columns.Item(5).Width = 100
        DGVDProd.Columns.Item(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVDProd.Columns.Item(6).Width = 100
        DGVDProd.Columns.Item(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub
End Class
