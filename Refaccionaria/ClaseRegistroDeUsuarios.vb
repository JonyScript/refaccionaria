Public Class ClaseRegistroDeUsuarios
    Private codigoUsuario As String
    Private nombre As String
    Private paterno As String
    Private materno As String
    Private contrasena As String
    Private rol As String

    'Private ElCorreo As String

    'Método constructor inicializa variables
    Public Sub New()
        codigoUsuario = ""
        nombre = ""
        paterno = ""
        materno = ""
        contrasena = ""
        rol = ""

    End Sub
    'Metodo constructor con valores proporcionados al instanciar el objeto
    Public Sub New(ByVal txtuser As String,
                   ByVal txtnom As String, ByVal txtpat As String,
                   ByVal txtmat As String, ByVal txtcontra As String,
                   ByVal txtrol As String)
        'En estas variables recibimos los datos del formulario

        codigoUsuario = txtuser
        nombre = txtnom
        paterno = txtpat
        materno = txtmat
        contrasena = txtcontra
        rol = txtrol


    End Sub

    'Metodos get y set
    Public Property getSetUsuario() As String
        Get
            Return codigoUsuario
        End Get
        Set(ByVal Value As String)
            codigoUsuario = Value
        End Set
    End Property

    Public Property getSetnombre() As String
        Get
            Return nombre
        End Get
        Set(ByVal Value As String)
            nombre = Value
        End Set
    End Property

    Public Property getSetpaterno() As String
        Get
            Return paterno
        End Get
        Set(ByVal Value As String)
            paterno = Value
        End Set
    End Property

    Public Property getSetmaterno() As String 'String
        Get
            Return materno
        End Get
        Set(ByVal Value As String)
            materno = Value
        End Set
    End Property

    Public Property getSetcontrasena() As String 'String
        Get
            Return contrasena
        End Get
        Set(ByVal Value As String)
            contrasena = Value
        End Set
    End Property

    Public Property getSetrol() As String 'String
        Get
            Return rol
        End Get
        Set(ByVal Value As String)
            rol = Value
        End Set
    End Property

    Public Sub insertarUsuario()
        Dim strSql As String
        Dim xCnx As New Oracle
        ' Validamos que no falten datos en las variables, en caso contrario no se 
        ' permite hacer el insert
        If codigoUsuario <> "" And nombre <> "" Then
            ' Preparamos el query para insertar el registro

            strSql = "INSERT INTO usuario VALUES('" & codigoUsuario & "',(Select codigoRol from rol where descripcion='" & rol & "'), '" & nombre & "', '" & paterno & "', '" & materno & "', prueba.cryptf('" & contrasena & "'), 0)"
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
        If codigoUsuario = "" Then
            MsgBox("Faltan datos !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        ElseIf userActual = Registro_de_usuarios.username_txt.Text Then
            ' Preparamos el query para modificar el registro
            If contrasena = "" Then
                strSql = "UPDATE usuario set codigoRol =" & rol & ", " &
                     " nombre ='" & nombre & "', " &
                     " paterno = '" & paterno & "', " &
                     " materno = '" & materno & "' " &
                     " WHERE codigoUsuario = '" & Registro_de_usuarios.username_txt.Text & "'"
                xCnx.objetoCommand(strSql)
            Else

                strSql = "UPDATE usuario set codigoRol =" & rol & ", " &
                     " nombre ='" & nombre & "', " &
                     " paterno = '" & paterno & "', " &
                     " materno = '" & materno & "'," &
                     " contrasena = prueba.cryptf('" & contrasena & "')  " &
                     " WHERE codigoUsuario = '" & Registro_de_usuarios.username_txt.Text & "'"
                xCnx.objetoCommand(strSql)
            End If
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
