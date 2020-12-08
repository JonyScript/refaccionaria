Public Class ClaseRegistroDeVentas
    Public Function consultaVenta() As Object
        'Método para listar a todos los usuarios en el DGV
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "SELECT venta.codigoVenta as codigo, totalVenta as total, cliente.nombre || ' ' || cliente.paterno || ' ' || cliente.materno as cliente, " &
                 "usuario.nombre || ' ' || usuario.paterno || ' ' || usuario.materno as vendedor, fechaVenta as fecha " &
                 "From venta, usuario, cliente where venta.codigoCliente = cliente.codigoCliente and " &
                 "venta.codigoUsuario = usuario.codigoUsuario and usuario.eliminado = 0 and cliente.eliminado = 0 Order By codigo"
        consultaVenta = xCnx.objetoDataAdapter(strSQL)
    End Function
    Public Function consultaVentaDetallada(ByVal cdg As String) As Object
        'Método para listar a todos los usuarios en el DGV
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "SELECT ventaDetallada.codigoProducto as codigo,nombreProducto as producto,marca.descripcion as marca, medida.descripcion as medida,precio as precio, cantidadProducto as cantidad, precio * cantidadProducto as importe " &
                 "From producto, medida, ventaDetallada, venta, marca where producto.codigoMarca = marca.codigoMarca and producto.codigoMedida = medida.codigoMedida and producto.codigoProducto = ventaDetallada.codigoProducto " &
                 "and venta.codigoVenta = ventaDetallada.codigoVenta and eliminado = 0 and venta.codigoVenta = " & cdg & " Order By codigo"
        consultaVentaDetallada = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridVenta(ByVal DGVDVenta As DataGridView)

        'Llamamos al método que obtiene los registros de los usuarios
        DGVDVenta.DataSource = consultaVenta()
        DGVDVenta.Refresh()
        'Establecer ancho de cada columna del DataGridView, el 
        'número de columnas del DGV debe ser igual al número
        'de atributos recuperados en el query del método
        'consultaTodosUsuarios
        DGVDVenta.Columns.Item(0).Width = 100
        DGVDVenta.Columns.Item(1).Width = 200
        DGVDVenta.Columns.Item(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVDVenta.Columns.Item(2).Width = 100
        DGVDVenta.Columns.Item(3).Width = 100
        DGVDVenta.Columns.Item(4).Width = 100
    End Sub

    Public Sub PoblarDataGridVentaDetallada(ByVal DGVDProd As DataGridView, ByVal cdg As String)

        'Llamamos al método que obtiene los registros de los usuarios
        DGVDProd.DataSource = consultaVentaDetallada(cdg)
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
