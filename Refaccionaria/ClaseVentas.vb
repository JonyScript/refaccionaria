Public Class ClaseVentas
    Private codigoCliente As String
    Private codigoUsuario As String
    Private fechaVenta As String
    Private totalVenta As String

    Private codigoVentaDetallada As String
    Private cantidadProducto As String

    Private codigoProducto As String
    Private codigoMedida As String
    Private nombreProducto As String
    Private precio As String
    Private existencia As String
    Private eliminado As String

    Public Sub New()
        codigoProducto = ""
        codigoMedida = ""
        nombreProducto = ""
        precio = ""
        existencia = ""
        eliminado = ""
        codigoVentaDetallada = ""
        cantidadProducto = ""
        codigoCliente = ""
        codigoUsuario = ""
        fechaVenta = ""
        totalVenta = ""
    End Sub

    Public Function getCodigoVenta() As Boolean
        ' Método para buscar a un usuario en párticular, para saber
        ' si es un nuevo usuario o uno existente
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        'Preparamos el query para buscar al usuario, con el dato
        'capturado en la caja de textos txt_usuario de la pantalla
        'FrmUsuarios
        strSQL = "SELECT max(codigoVenta)+1 as max FROM venta"
        getCodigoVenta = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("max")) Then
                codigoVenta = 1
            Else
                codigoVenta = CStr(xDT.Rows(0)("max"))
            End If
            getCodigoVenta = True
        End If
    End Function

    Public Function getCodigoVentaDetallada() As Boolean
        ' Método para buscar a un usuario en párticular, para saber
        ' si es un nuevo usuario o uno existente
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        'Preparamos el query para buscar al usuario, con el dato
        'capturado en la caja de textos txt_usuario de la pantalla
        'FrmUsuarios
        strSQL = "SELECT max(codigoVentaDetallada)+1 as max FROM ventaDetallada"
        getCodigoVentaDetallada = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("max")) Then
                codigoVentaDetallada = 1
            Else
                codigoVentaDetallada = CStr(xDT.Rows(0)("max"))
            End If
            getCodigoVentaDetallada = True
        End If
    End Function

    Public Sub insertarVenta(ByVal cdgcliente As String)
        Dim strSql As String
        Dim xCnx As New Oracle
        ' Validamos que no falten datos en las variables, en caso contrario no se 
        ' permite hacer el insert
        getCodigoVenta()
        codigoCliente = cdgcliente
        If codigoCliente <> "" And UsuarioConectado <> "" Then
            ' Preparamos el query para insertar el registro

            strSql = "INSERT INTO venta(codigoVenta, codigoCliente, codigoUsuario, fechaVenta) VALUES(" & codigoVenta & ", " & codigoCliente & ", '" & UsuarioConectado & "', '" & Today & "')"
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Falta seleccionar el cliente, verifique !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    Public Sub insertarProducto(ByVal cdgproducto As String, ByVal ctdproducto As String)
        Dim strSql As String
        Dim xCnx As New Oracle
        ' Validamos que no falten datos en las variables, en caso contrario no se 
        ' permite hacer el insert
        getCodigoVentaDetallada()
        codigoProducto = cdgproducto
        cantidadProducto = ctdproducto
        nombreProducto = "producto actual"
        If codigoProducto <> "" And nombreProducto <> "" And cantidadProducto <> "" Then
            ' Preparamos el query para insertar el registro

            strSql = "INSERT INTO ventaDetallada VALUES(" & codigoVentaDetallada & ", " & codigoProducto & ", " & codigoVenta & ", " & cantidadProducto & ")"
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos obligatorios de la venta, verifique !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub
    Public Function consultaProductos() As Object
        'Método para listar a todos los usuarios en el DGV
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "SELECT codigoProducto as codigo,nombreProducto as producto,descripcion as medida,precio as precio, existencia as existencia " &
                 "From producto, medida where producto.codigoMedida = medida.codigoMedida and eliminado = 0" & " Order By codigo"
        consultaProductos = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Function consultaVenta() As Object
        'Método para listar a todos los usuarios en el DGV
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "SELECT ventaDetallada.codigoProducto as codigo,nombreProducto as producto,descripcion as medida,precio as precio, cantidadProducto as cantidad " &
                 "From producto, medida, ventaDetallada, venta where producto.codigoMedida = medida.codigoMedida and producto.codigoProducto = ventaDetallada.codigoProducto " &
                 "and venta.codigoVenta = ventaDetallada.codigoVenta and eliminado = 0 and ventaDetallada.codigoVenta = " & codigoVenta & " Order By codigo"
        consultaVenta = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridExist(ByVal DGVExist As DataGridView)
        'Llamamos al método que obtiene los registros de los usuarios
        DGVExist.DataSource = consultaProductos()
        DGVExist.Refresh()
        'Establecer ancho de cada columna del DataGridView, el 
        'número de columnas del DGV debe ser igual al número
        'de atributos recuperados en el query del método
        'consultaTodosUsuarios
        DGVExist.Columns.Item(0).Width = 100
        DGVExist.Columns.Item(1).Width = 200
        DGVExist.Columns.Item(2).Width = 200
        DGVExist.Columns.Item(3).Width = 100
        DGVExist.Columns.Item(4).Width = 100

    End Sub

    Public Sub PoblarDataGridVentas(ByVal DGVVentas As DataGridView)
        'Llamamos al método que obtiene los registros de los usuarios
        DGVVentas.DataSource = consultaVenta()
        DGVVentas.Refresh()
        'Establecer ancho de cada columna del DataGridView, el 
        'número de columnas del DGV debe ser igual al número
        'de atributos recuperados en el query del método
        'consultaTodosUsuarios
        DGVVentas.Columns.Item(0).Width = 100
        DGVVentas.Columns.Item(1).Width = 200
        DGVVentas.Columns.Item(2).Width = 200
        DGVVentas.Columns.Item(3).Width = 100
        DGVVentas.Columns.Item(4).Width = 100

    End Sub

End Class
