Public Class ClaseCompras
    Private codigoUsuario As String
    Private codigoProveedor As String
    Private precioCompra As String
    Private fechaCompra As String
    'Private codigoCompra As String
    Private totalCompra As String

    Private codigoCompraDetallada As String
    Private cantidadProducto As String

    Private codigoProducto As String
    Private codigoMedida As String
    Private nombreProducto As String
    Private precio As String
    Private existencia As String

    Public Sub New()
        precioCompra = ""
        codigoProveedor = ""
        'codigoCompra = ""
        codigoProducto = ""
        codigoMedida = ""
        nombreProducto = ""
        precio = ""
        existencia = ""
        codigoCompraDetallada = ""
        cantidadProducto = ""
        codigoUsuario = ""
        fechaCompra = ""
        totalCompra = ""
    End Sub

    Public Function getCodigoCompra() As Boolean
        ' Método para buscar a un usuario en párticular, para saber
        ' si es un nuevo usuario o uno existente
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        'Preparamos el query para buscar al usuario, con el dato
        'capturado en la caja de textos txt_usuario de la pantalla
        'FrmUsuarios
        strSQL = "SELECT max(codigoCompra)+1 as max FROM compra"
        getCodigoCompra = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("max")) Then
                codigoCompra = 1
            Else
                codigoCompra = CStr(xDT.Rows(0)("max"))
            End If
            getCodigoCompra = True
        End If
    End Function

    Public Function getExistencia(ByVal cdgproducto As String) As Boolean
        ' Método para buscar a un usuario en párticular, para saber
        ' si es un nuevo usuario o uno existente
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        'Preparamos el query para buscar al usuario, con el dato
        'capturado en la caja de textos txt_usuario de la pantalla
        'FrmUsuarios
        strSQL = "SELECT existencia FROM producto WHERE codigoProducto = " & cdgproducto
        getExistencia = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("existencia")) Then
                existencia = 0
            Else
                existencia = CStr(xDT.Rows(0)("existencia"))
        End If
        getExistencia = True
        End If
    End Function

    Public Function getCodigoCompraDetallada() As Boolean
        ' Método para buscar a un usuario en párticular, para saber
        ' si es un nuevo usuario o uno existente
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        'Preparamos el query para buscar al usuario, con el dato
        'capturado en la caja de textos txt_usuario de la pantalla
        'FrmUsuarios
        strSQL = "SELECT max(codigoCompraDetallada)+1 as max FROM compraDetallada"
        getCodigoCompraDetallada = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("max")) Then
                codigoCompraDetallada = 1
            Else
                codigoCompraDetallada = CStr(xDT.Rows(0)("max"))
            End If
            getCodigoCompraDetallada = True
        End If
    End Function

    Public Sub insertarCompra(ByVal cdgproveedor As String)
        Dim strSql As String
        Dim xCnx As New Oracle
        ' Validamos que no falten datos en las variables, en caso contrario no se 
        ' permite hacer el insert
        getCodigoCompra()
        codigoProveedor = cdgproveedor
        proveedorGlobal = cdgproveedor
        If codigoProveedor <> "" And UsuarioConectado <> "" Then
            ' Preparamos el query para insertar el registro
            strSql = "INSERT INTO compra(codigoCompra, codigoProveedor, codigoUsuario, fechaCompra) VALUES(" & codigoCompra & ", " & codigoProveedor & ", '" & UsuarioConectado & "', '" & Today & "')"
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Falta seleccionar el proveedor, verifique !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    Public Sub agregarExistencia(ByVal cantidadproducto As String, ByVal cdgproducto As String)
        'sub para reducir existencias del inventario al insertar un producto en la venta
        Dim strSql As String
        Dim xCnx As New Oracle
        ' Validamos que no falten datos en las variables, en caso contrario no se 
        ' permite hacer el update
        If cantidadproducto <> "" And cdgproducto <> "" Then
            ' Preparamos el query para insertar el registro

            strSql = "update producto set existencia = existencia+" & cantidadproducto & " where codigoProducto = " & cdgproducto
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Error al agregar a la existencia del producto !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    Public Sub insertarProducto(ByVal cdgproducto As String, ByVal ctdproducto As String, ByVal ctdprecioCompra As String)
        Dim strSql As String
        Dim xCnx As New Oracle
        ' Validamos que no falten datos en las variables, en caso contrario no se 
        ' permite hacer el insert
        getCodigoCompraDetallada()
        codigoProducto = cdgproducto
        cantidadProducto = ctdproducto
        precioCompra = ctdprecioCompra
        nombreProducto = "producto actual"
        If codigoProducto <> "" And nombreProducto <> "" And cantidadProducto <> "" Then
            ' Preparamos el query para insertar el registro
            getExistencia(codigoProducto)
            If CInt(cantidadProducto) <= CInt(existencia) Then
                strSql = "INSERT INTO compraDetallada VALUES(" & codigoCompraDetallada & ", " & codigoProducto & ", " & codigoCompra & "," & precioCompra & ", " & cantidadProducto & ")"
                xCnx.objetoCommand(strSql)
                agregarExistencia(cantidadProducto, codigoProducto)
                'Else
                'MsgBox("No hay existencias suficientes, verifique !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
            ElseIf CInt(cantidadProducto) >= CInt(existencia) Then
                strSql = "INSERT INTO compraDetallada VALUES(" & codigoCompraDetallada & ", " & codigoProducto & ", " & codigoCompra & "," & precioCompra & ", " & cantidadProducto & ")"
                xCnx.objetoCommand(strSql)
                agregarExistencia(cantidadProducto, codigoProducto)
            End If
        Else
            MsgBox("Faltan datos obligatorios de la compra, verifique !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    Public Sub devolverExistencia(ByVal cantidadproducto As String, ByVal cdgproducto As String)
        'sub para devolver existencias del inventario en caso de eliminar producto de la venta / venta no realizada
        Dim strSql As String
        Dim xCnx As New Oracle
        ' Validamos que no falten datos en las variables, en caso contrario no se 
        ' permite hacer el update
        If cantidadproducto <> "" And cdgproducto <> "" Then
            ' Preparamos el query para insertar el registro

            strSql = "update producto set existencia = existencia-" & cantidadproducto & " where codigoProducto = " & cdgproducto
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Error al agregar la existencia del producto !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    Public Sub eliminarProducto(ByVal cdgprod As String, ByVal ctdprod As String)
        'Eliminar productos de una venta / eliminar registros de ventadetallada
        Dim strSql As String
        Dim xCnx As New Oracle
        ' Validamos que no falten datos en las variables, en caso contrario no se 
        ' permite hacer el insert
        codigoProducto = cdgprod
        cantidadProducto = ctdprod
        If codigoProducto <> "" And cantidadProducto <> "" Then
            strSql = "delete from compraDetallada where codigoCompra = " & codigoCompra & " and codigoProducto = " & codigoProducto & " and cantidadProducto = " & cantidadProducto
            xCnx.objetoCommand(strSql)
            devolverExistencia(cantidadProducto, codigoProducto)
        Else
            MsgBox("No hay producto seleccionado de la compra, verifique !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    Public Function consultaUnProducto(ByVal cdgproducto As String) As Boolean
        ' Método para buscar a un usuario en párticular, para saber
        ' si es un nuevo usuario o uno existente
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        'Preparamos el query para buscar al usuario, con el dato
        'capturado en la caja de textos txt_usuario de la pantalla
        'FrmUsuarios
        strSQL = "SELECT * FROM compraDetallada " &
                 "WHERE codigoCompra= " & codigoCompra & " and codigoproducto= " & cdgproducto
        consultaUnProducto = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            consultaUnProducto = True
        End If
    End Function

    Public Function consultaProductos() As Object
        'Método para listar a todos los usuarios en el DGV
        Dim strSQL As String
        Dim xCnx As New Oracle
        If CompraDeProductos.txtcodigoprod.Text <> "" Then
            strSQL = "SELECT codigoProducto as codigo,nombreProducto as producto,marca.descripcion as marca,medida.descripcion as medida,to_char(precio, 'fm99990.00') as precio, existencia as existencia " &
                 "From producto, medida, marca where producto.codigoMedida = medida.codigoMedida and producto.codigoMarca = Marca.codigoMarca and eliminado = 0 and codigoProducto = " & CompraDeProductos.txtcodigoprod.Text & " Order By codigo"
            consultaProductos = xCnx.objetoDataAdapter(strSQL)
        ElseIf CompraDeProductos.txtnombreprod.Text <> "" Then
            strSQL = "SELECT codigoProducto as codigo,nombreProducto as producto,marca.descripcion as marca,medida.descripcion as medida,to_char(precio, 'fm99990.00') as precio, existencia as existencia " &
                 "From producto, medida, marca where producto.codigoMedida = medida.codigoMedida and producto.codigoMarca = Marca.codigoMarca and eliminado = 0 and nombreProducto = '" & CompraDeProductos.txtnombreprod.Text & "' Order By codigo"
            consultaProductos = xCnx.objetoDataAdapter(strSQL)
        Else
            strSQL = "SELECT codigoProducto as codigo,nombreProducto as producto,marca.descripcion as marca,medida.descripcion as medida,to_char(precio, 'fm99990.00') as precio, existencia as existencia " &
                 "From producto, medida, marca where producto.codigoMedida = medida.codigoMedida and producto.codigoMarca = Marca.codigoMarca and eliminado = 0" & " Order By codigo"
            consultaProductos = xCnx.objetoDataAdapter(strSQL)
        End If
    End Function
    Public Function consultaCompra() As Object
        '   Método para listar a todos los usuarios en el DGV
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "SELECT compraDetallada.codigoProducto as codigo,nombreProducto as producto,marca.descripcion as marca, medida.descripcion as medida,to_char(precioCompra, 'fm99990.00') as precio, cantidadProducto as cantidad, to_char(precioCompra * cantidadProducto, 'fm99990.00') as importe " &
                     "From producto, medida, compraDetallada, compra, marca where producto.codigoMarca = marca.codigoMarca and producto.codigoMedida = medida.codigoMedida and producto.codigoProducto = compraDetallada.codigoProducto " &
                     "and compra.codigoCompra = compraDetallada.codigoCompra and eliminado = 0 and compraDetallada.codigoCompra = " & codigoCompra & " Order By codigo"
        consultaCompra = xCnx.objetoDataAdapter(strSQL)
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
        strSQL = "SELECT to_char(sum(cantidadproducto * precioCompra), 'fm99990.00') as total FROM compraDetallada, producto " &
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

    Public Sub insertarTotal(ByVal total As String)
        'sub para devolver existencias del inventario en caso de eliminar producto de la venta / venta no realizada
        Dim strSql As String
        Dim xCnx As New Oracle
        ' Validamos que no falten datos en las variables, en caso contrario no se 
        ' permite hacer el update
        If total <> "" Then
            ' Preparamos el query para insertar el registro

            strSql = "update compra set totalCompra = " & total & " where codigoCompra = " & codigoCompra
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Error al insertar el total del producto !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    Public Sub PoblarDataGridExist2(ByVal DGVExist2 As DataGridView)
        'Llamamos al método que obtiene los registros de los usuarios
        DGVExist2.DataSource = consultaProductos()
        DGVExist2.Refresh()
        'Establecer ancho de cada columna del DataGridView, el 
        'número de columnas del DGV debe ser igual al número
        'de atributos recuperados en el query del método
        'consultaTodosUsuarios
        DGVExist2.Columns.Item(0).Width = 100
        DGVExist2.Columns.Item(1).Width = 200
        DGVExist2.Columns.Item(2).Width = 100
        DGVExist2.Columns.Item(3).Width = 200
        DGVExist2.Columns.Item(4).Width = 200
        DGVExist2.Columns.Item(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVExist2.Columns.Item(5).Width = 100
        DGVExist2.Columns.Item(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

    End Sub

    Public Sub PoblarDataGridCompra(ByVal DGVCompra As DataGridView)

        'Llamamos al método que obtiene los registros de los usuarios
        DGVCompra.DataSource = consultaCompra()
        DGVCompra.Refresh()
        'Establecer ancho de cada columna del DataGridView, el 
        'número de columnas del DGV debe ser igual al número
        'de atributos recuperados en el query del método
        'consultaTodosUsuarios
        DGVCompra.Columns.Item(0).Width = 100
        DGVCompra.Columns.Item(1).Width = 200
        DGVCompra.Columns.Item(2).Width = 100
        DGVCompra.Columns.Item(3).Width = 100
        DGVCompra.Columns.Item(4).Width = 100
        DGVCompra.Columns.Item(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVCompra.Columns.Item(5).Width = 100
        DGVCompra.Columns.Item(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVCompra.Columns.Item(6).Width = 100
        DGVCompra.Columns.Item(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub
End Class
