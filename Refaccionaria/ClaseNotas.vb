Public Class ClaseNotas
    Private total As String
    Private fecha As String
    Private cliente As String

    Public Function consultaNota() As Object
        'Método para listar a todos los usuarios en el DGV
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "SELECT ventaDetallada.codigoProducto as codigo,nombreProducto as producto,marca.descripcion as marca, medida.descripcion as medida,precio as precio, cantidadProducto as cantidad, precio * cantidadProducto as importe " &
                 "From producto, medida, ventaDetallada, venta, marca where producto.codigoMarca = marca.codigoMarca and producto.codigoMedida = medida.codigoMedida and producto.codigoProducto = ventaDetallada.codigoProducto " &
                 "and venta.codigoVenta = ventaDetallada.codigoVenta and eliminado = 0 and ventaDetallada.codigoVenta = " & codigoVenta & " Order By codigo"
        consultaNota = xCnx.objetoDataAdapter(strSQL)
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
        strSQL = "SELECT sum(cantidadproducto * precio) as total FROM ventadetallada, producto " &
            "where ventadetallada.codigoproducto = producto.codigoproducto and codigoventa = " & codigoVenta
        getTotal = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("total")) Then
                total = 1
            Else
                total = CStr(xDT.Rows(0)("total"))
                Return total
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
        strSQL = "SELECT fechaventa as fecha FROM venta " &
            "where codigoventa = " & codigoVenta
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

    Public Function getCliente() As String
        ' Método para buscar a un usuario en párticular, para saber
        ' si es un nuevo usuario o uno existente
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        'Preparamos el query para buscar al usuario, con el dato
        'capturado en la caja de textos txt_usuario de la pantalla
        'FrmUsuarios
        strSQL = "Select nombre || ' ' || paterno || ' ' || materno as nombre from cliente " &
            "where codigocliente = " & clienteGlobal
        getCliente = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("nombre")) Then
                cliente = 1
            Else
                cliente = CStr(xDT.Rows(0)("nombre"))
                Return cliente
            End If
            getCliente = True
        End If
    End Function

    Public Sub PoblarDataGridNotas(ByVal DGVDNotas As DataGridView)

        'Llamamos al método que obtiene los registros de los usuarios
        DGVDNotas.DataSource = consultaNota()
        DGVDNotas.Refresh()
        'Establecer ancho de cada columna del DataGridView, el 
        'número de columnas del DGV debe ser igual al número
        'de atributos recuperados en el query del método
        'consultaTodosUsuarios
        DGVDNotas.Columns.Item(0).Width = 100
        DGVDNotas.Columns.Item(1).Width = 200
        DGVDNotas.Columns.Item(2).Width = 100
        DGVDNotas.Columns.Item(3).Width = 100
        DGVDNotas.Columns.Item(4).Width = 100
        DGVDNotas.Columns.Item(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVDNotas.Columns.Item(5).Width = 100
        DGVDNotas.Columns.Item(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVDNotas.Columns.Item(6).Width = 100
        DGVDNotas.Columns.Item(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

End Class
