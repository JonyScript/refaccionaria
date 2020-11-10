Public Class ClaseRegistroDeProductos
    Private codigoProducto As String
    Private nombreProducto As String
    Private CMedida As String
    Private CMarca As String
    Private precio As String
    Private existencia As String

    'Private ElCorreo As String

    'Método constructor inicializa variables
    Public Sub New()
        codigoProducto = ""
        nombreProducto = ""
        CMedida = ""
        CMarca = ""
        precio = ""
        existencia = ""
    End Sub
    'Metodo constructor con valores proporcionados al instanciar el objeto
    Public Sub New(ByVal txtcodigoP As String,
                   ByVal txtnombreP As String, ByVal txtcodigoM As String,
                   ByVal txtcodigoMarca As String,
                   ByVal txtprecio As String, ByVal txtexistencia As String)
        'En estas variables recibimos los datos del formulario

        codigoProducto = txtcodigoP
        nombreProducto = txtnombreP
        CMedida = txtcodigoM
        CMarca = txtcodigoMarca
        precio = txtprecio
        existencia = txtexistencia


    End Sub

    'Metodos get y set
    Public Property getSetCproducto() As String
        Get
            Return codigoProducto
        End Get
        Set(ByVal Value As String)
            codigoProducto = Value
        End Set
    End Property
    Public Property getSetNproducto() As String 'String
        Get
            Return nombreProducto
        End Get
        Set(ByVal Value As String)
            nombreProducto = Value
        End Set
    End Property

    Public Property getSetCmedida() As String
        Get
            Return CMedida
        End Get
        Set(ByVal Value As String)
            CMedida = Value
        End Set
    End Property

    Public Property getSetCmarca() As String
        Get
            Return CMarca
        End Get
        Set(ByVal Value As String)
            CMarca = Value
        End Set
    End Property

    Public Property getSetPrecio() As String 'String
        Get
            Return precio
        End Get
        Set(ByVal Value As String)
            precio = Value
        End Set
    End Property

    Public Property getSetExistencia() As String 'String
        Get
            Return existencia
        End Get
        Set(ByVal Value As String)
            existencia = Value
        End Set
    End Property

    Public Sub insertarProducto()
        Dim strSql As String
        Dim xCnx As New Oracle
        ' Validamos que no falten datos en las variables, en caso contrario no se 
        ' permite hacer el insert
        If codigoProducto <> "" And CMedida <> "" And CMarca <> "" Then
            ' Preparamos el query para insertar el registro

            strSql = "INSERT INTO producto VALUES(" & codigoProducto & ",'" & nombreProducto & "', (Select codigoMedida from medida  where descripcion='" & CMedida & "'),(Select codigoMarca from marca  where descripcion='" & CMarca & "'), " & precio & ", 0,0)"
            xCnx.objetoCommand(strSql)
            MsgBox("Nuevo producto agregado")
        Else
            MsgBox("Faltan datos para el producto, verifique !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    Public Sub eliminarProducto()
        Dim strSql As String
        Dim xCnx As New Oracle
        'Validamos que ese alumno no esté Integrado en algún equipo

        If codigoProducto <> "" Then
            strSql = "UPDATE producto " &
                         "SET eliminado = 1 " &
                         "WHERE codigoProducto= '" & codigoProducto & "'"

            xCnx.objetoCommand(strSql)
            MsgBox("Producto eliminado")

        Else
            MsgBox("Faltan datos !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub
    Public Sub actualizarProductos()
        Dim strSql As String
        Dim xCnx As New Oracle
        ' Validamos que no falten datos en las variables, en caso contrario no se 
        ' permite hacer el Update
        If codigoProducto <> "" Then
            ' Preparamos el query para modificar el registro

            strSql = "UPDATE producto set nombreProducto='" & nombreProducto & "', " &
                     " codigoMedida =" & CMedida & ", " &
                     " codigoMarca =" & CMarca & ", " &
                     " precio = " & precio & " " &
                     " WHERE codigoProducto =" & codigoProducto & ""
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub
    Public Function consultaUnProducto() As Boolean
        ' Método para buscar a un usuario en párticular, para saber
        ' si es un nuevo usuario o uno existente
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        'Preparamos el query para buscar al usuario, con el dato
        'capturado en la caja de textos txt_usuario de la pantalla
        'FrmUsuarios
        strSQL = "SELECT * FROM producto " &
                 "WHERE codigoProducto= '" & codigoProducto & "' and eliminado = 0"
        consultaUnProducto = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("codigoProducto")) Then
                codigoProducto = 0
            Else
                codigoProducto = CStr(xDT.Rows(0)("codigoProducto"))
                ' codigoProducto = CStr(xDT.Rows(0)("codigoProducto"))
            End If
            consultaUnProducto = True
        End If
    End Function
    Public Function consultaTodosProductos() As Object
        'Método para listar a todos los usuarios en el DGV
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "SELECT codigoProducto as codigo,nombreProducto as producto,medida.descripcion as medida,marca.descripcion as marca, precio as precio, existencia as existencia" &
                 "  From producto, medida, marca where producto.codigoMedida = medida.codigoMedida and producto.codigoMarca = marca.codigoMarca and eliminado = 0" & " Order By codigo"
        consultaTodosProductos = xCnx.objetoDataAdapter(strSQL)
    End Function
    Public Sub PoblarDataGridRegistroDeProductos(ByVal DGVDProductos As DataGridView)
        'Llamamos al método que obtiene los registros de los usuarios
        DGVDProductos.DataSource = consultaTodosProductos()
        DGVDProductos.Refresh()
        'Establecer ancho de cada columna del DataGridView, el 
        'número de columnas del DGV debe ser igual al número
        'de atributos recuperados en el query del método
        'consultaTodosUsuarios
        DGVDProductos.Columns.Item(0).Width = 100
        DGVDProductos.Columns.Item(1).Width = 200
        DGVDProductos.Columns.Item(2).Width = 200
        DGVDProductos.Columns.Item(3).Width = 200
        DGVDProductos.Columns.Item(4).Width = 200

    End Sub
End Class
