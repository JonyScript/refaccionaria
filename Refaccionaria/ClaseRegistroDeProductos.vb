Public Class ClaseRegistroDeProductos
    Private codigoProducto As String
    Private codigoMedida As String
    Private nombreProducto As String
    Private precio As String
    Private existencia As String

    'Private ElCorreo As String

    'Método constructor inicializa variables
    Public Sub New()
        codigoProducto = ""
        codigoMedida = ""
        nombreProducto = ""
        precio = ""
        existencia = ""
    End Sub
    'Metodo constructor con valores proporcionados al instanciar el objeto
    Public Sub New(ByVal txtcodigoP As String,
                   ByVal txtcodigoM As String, ByVal txtnombreP As String,
                   ByVal txtprecio As String, ByVal txtexistencia As String,)
        'En estas variables recibimos los datos del formulario

        codigoProducto = txtcodigoP
        codigoMedida = txtcodigoM
        nombreProducto = txtnombreP
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

    Public Property getSetCmedida() As String
        Get
            Return codigoMedida
        End Get
        Set(ByVal Value As String)
            codigoMedida = Value
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
        If codigoProducto <> "" And codigoMedida <> "" Then
            ' Preparamos el query para insertar el registro

            strSql = "INSERT INTO usuario VALUES('" & codigoProducto & "',(Select codigoRol from rol where descripcion='" & rol & "'), '" & nombre & "', '" & paterno & "', '" & materno & "', prueba.cryptf('" & contrasena & "'), 0)"
            xCnx.objetoCommand(strSql)
            MsgBox("Nuevo usuario agregado")
        Else
            MsgBox("Faltan datos para el usuario, verifique !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    Public Sub eliminarUsuario()
        Dim strSql As String
        Dim xCnx As New Oracle
        'Validamos que ese alumno no esté Integrado en algún equipo

        If codigoUsuario <> "" Then
            If rol = 1 Then
                MsgBox("No puede eliminar a otro administrador")
            Else
                strSql = "UPDATE usuario " &
                         "SET eliminado = 1 " &
                         "WHERE codigoUsuario= '" & codigoUsuario & "'"

                xCnx.objetoCommand(strSql)
                MsgBox("Usuario eliminado")
            End If
        Else
            MsgBox("Faltan datos !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub
    Public Sub actualizaUsuario()
        Dim strSql As String
        Dim xCnx As New Oracle
        ' Validamos que no falten datos en las variables, en caso contrario no se 
        ' permite hacer el Update
        If codigoUsuario <> "" Then
            ' Preparamos el query para modificar el registro

            strSql = "UPDATE usuario set codigoRol =" & codigoRol & ", " &
                     " nombre =" & nombre & ", " &
                     " paterno = " & paterno & ", " &
                     " materno =" & materno & "," &
                     " contrasena = " & contrasena & " , " &
                     " WHERE codigoUsuario =" & Registro_de_usuarios.username_txt.Text
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub
    Public Function consultaUnUsuario() As Boolean
        ' Método para buscar a un usuario en párticular, para saber
        ' si es un nuevo usuario o uno existente
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        'Preparamos el query para buscar al usuario, con el dato
        'capturado en la caja de textos txt_usuario de la pantalla
        'FrmUsuarios
        strSQL = "SELECT * FROM usuario " &
                 "WHERE codigoUsuario= '" & Registro_de_usuarios.username_txt.Text & "' and eliminado = 0"
        consultaUnUsuario = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("codigoUsuario")) Then
                codigoUsuario = 0
            Else
                Registro_de_usuarios.username_txt.Text = CStr(xDT.Rows(0)("codigoUsuario"))
                codigoUsuario = CStr(xDT.Rows(0)("codigoUsuario"))
            End If
            consultaUnUsuario = True
        End If
    End Function
    Public Function consultaTodosUsuarios() As Object
        'Método para listar a todos los usuarios en el DGV
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "SELECT codigoUsuario as Codigo, descripcion as Rol, nombre as Nombre, paterno as Paterno, materno as Materno" &
                 "  From usuario, rol where usuario.codigorol = rol.codigorol and eliminado = 0" & " Order By rol"
        consultaTodosUsuarios = xCnx.objetoDataAdapter(strSQL)
    End Function
    Public Sub PoblarDataGridRegistroDeUsuarios(ByVal DGVUsuarios As DataGridView)
        'Llamamos al método que obtiene los registros de los usuarios
        DGVUsuarios.DataSource = consultaTodosUsuarios()
        DGVUsuarios.Refresh()
        'Establecer ancho de cada columna del DataGridView, el 
        'número de columnas del DGV debe ser igual al número
        'de atributos recuperados en el query del método
        'consultaTodosUsuarios
        DGVUsuarios.Columns.Item(0).Width = 100
        DGVUsuarios.Columns.Item(0).Width = 100
        DGVUsuarios.Columns.Item(0).Width = 100
        DGVUsuarios.Columns.Item(0).Width = 100
        DGVUsuarios.Columns.Item(0).Width = 100

    End Sub
End Class
