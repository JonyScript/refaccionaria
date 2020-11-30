Public Class ClaseNotasCompras
    Private totalCompra As String
    Private fecha As String
    Private proveedor As String

    Public Function consultaNotaC() As Object
        '   Método para listar a todos los usuarios en el DGV
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "SELECT compraDetallada.codigoProducto as codigo,nombreProducto as producto,marca.descripcion as marca, medida.descripcion as medida,precioCompra as precio, cantidadProducto as cantidad, precioCompra * cantidadProducto as importe " &
                     "From producto, medida, compraDetallada, compra, marca where producto.codigoMarca = marca.codigoMarca and producto.codigoMedida = medida.codigoMedida and producto.codigoProducto = compraDetallada.codigoProducto " &
                     "and compra.codigoCompra = compraDetallada.codigoCompra and eliminado = 0 and compraDetallada.codigoCompra = " & codigoCompra & " Order By codigo"
        consultaNotaC = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Function getTotal() As String
        ' Método para buscar a un usuario en párticular, para saber
        ' si es un nuevo usuario o uno existente
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        'Preparamos el query para buscar al usuario, con el dato
        'capturado en la caja de textos txt_usuario de la pantalla
        'FrmUsuarios
        strSQL = "SELECT sum(cantidadproducto * precioCompra) as total FROM compraDetallada, producto " &
            "where compraDetallada.codigoproducto = producto.codigoproducto and codigocompra = " & codigoCompra
        getTotal = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("total")) Then
                totalCompra = 1
            Else
                totalCompra = CStr(xDT.Rows(0)("total"))
                Return totalCompra
            End If
            getTotal = True
        End If
    End Function

    Public Function getFecha() As String
        ' Método para buscar a un usuario en párticular, para saber
        ' si es un nuevo usuario o uno existente
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        'Preparamos el query para buscar al usuario, con el dato
        'capturado en la caja de textos txt_usuario de la pantalla
        'FrmUsuarios
        strSQL = "SELECT fechacompra as fecha FROM compra " &
            "where codigocompra = " & codigoCompra
        getFecha = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("fecha")) Then
                fecha = 1
            Else
                fecha = CStr(xDT.Rows(0)("fecha"))
                Return fecha
            End If
            getFecha = True
        End If
    End Function

    Public Function getProveedor() As String
        ' Método para buscar a un usuario en párticular, para saber
        ' si es un nuevo usuario o uno existente
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        'Preparamos el query para buscar al usuario, con el dato
        'capturado en la caja de textos txt_usuario de la pantalla
        'FrmUsuarios
        strSQL = "Select nombre as nombre from proveedor " &
            "where codigoProveedor = " & proveedorGlobal
        getProveedor = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("nombre")) Then
                proveedor = 1
            Else
                proveedor = CStr(xDT.Rows(0)("nombre"))
                Return proveedor
            End If
            getProveedor = True
        End If
    End Function

    Public Sub PoblarDataGridNotasCompras(ByVal DGVDNotasCompras As DataGridView)

        'Llamamos al método que obtiene los registros de los usuarios
        DGVDNotasCompras.DataSource = consultaNotaC()
        DGVDNotasCompras.Refresh()
        'Establecer ancho de cada columna del DataGridView, el 
        'número de columnas del DGV debe ser igual al número
        'de atributos recuperados en el query del método
        'consultaTodosUsuarios
        DGVDNotasCompras.Columns.Item(0).Width = 100
        DGVDNotasCompras.Columns.Item(1).Width = 200
        DGVDNotasCompras.Columns.Item(2).Width = 100
        DGVDNotasCompras.Columns.Item(3).Width = 100
        DGVDNotasCompras.Columns.Item(4).Width = 100
        DGVDNotasCompras.Columns.Item(5).Width = 100
        DGVDNotasCompras.Columns.Item(6).Width = 100
    End Sub
End Class
