Public Class ClaseRegistroDeProveedor
    Private codigoProveedor As String
    Private nombre As String
    Private telefono As String
    Private mail As String
    Private direccion As String

    Public Sub New()
        nombre = ""
        telefono = ""
        mail = ""
        direccion = ""
    End Sub

    Public Sub New(ByVal txtnombreP As String,
               ByVal txttelefonoP As String, ByVal txtmailP As String,
               ByVal txtdireccionP As String)
        nombre = txtnombreP
        telefono = txttelefonoP
        mail = txtmailP
        direccion = txtdireccionP

    End Sub
    Public Property getScodigoC() As String
        Get
            Return codigoProveedor
        End Get
        Set(ByVal Value As String)
            codigoProveedor = Value
        End Set
    End Property

    Public Property getSetnombreC() As String
        Get
            Return nombre
        End Get
        Set(ByVal Value As String)
            nombre = Value
        End Set
    End Property

    Public Property getSettelefonoC() As String
        Get
            Return telefono
        End Get
        Set(ByVal Value As String)
            telefono = Value
        End Set
    End Property

    Public Property getSetmailC() As String
        Get
            Return mail
        End Get
        Set(ByVal Value As String)
            mail = Value
        End Set
    End Property

    Public Property getSetdireccionC() As String
        Get
            Return direccion
        End Get
        Set(ByVal Value As String)
            direccion = Value
        End Set
    End Property

    Public Sub insertarProveedor()
        Dim strSql As String
        Dim xCnx As New Oracle
        ' Validamos que no falten datos en las variables, en caso contrario no se 
        ' permite hacer el insert
        If nombre <> "" And telefono <> "" And mail <> "" And direccion <> "" Then
            strSql = "INSERT INTO proveedor VALUES((Select count(codigoProveedor)+1 from proveedor), '" & nombre & "'," & telefono & ", '" & mail & "', '" & direccion & "', 0)"
            xCnx.objetoCommand(strSql)
            MsgBox("Nuevo proveedor registrado")
        ElseIf nombre <> "" And telefono <> "" And mail <> "" Then
            strSql = "INSERT INTO proveedor VALUES((Select count(codigoProveedor)+1 from proveedor), '" & nombre & "'," & telefono & ", '" & mail & "',' - ', 0)"
            xCnx.objetoCommand(strSql)
            MsgBox("Nuevo proveedor registrado")
        ElseIf nombre <> "" And telefono <> "" And direccion <> "" Then
            strSql = "INSERT INTO proveedor VALUES((Select count(codigoProveedor)+1 from proveedor), '" & nombre & "'," & telefono & ",' - ', '" & direccion & "', 0)"
            xCnx.objetoCommand(strSql)
            MsgBox("Nuevo proveedor registrado")
        ElseIf nombre <> "" And telefono <> "" Then
            strSql = "INSERT INTO proveedor VALUES((Select count(codigoProveedor)+1 from proveedor), '" & nombre & "'," & telefono & ", ' - ', ' - ', 0)"
            xCnx.objetoCommand(strSql)
            MsgBox("Nuevo proveedor registrado")
        Else
            MsgBox("Faltan datos obligatorios, verifique", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    Public Sub actualizaProveedor()
        Dim strSql As String
        Dim xCnx As New Oracle
        ' Validamos que no falten datos en las variables, en caso contrario no se 
        ' permite hacer el Update
        If nombre <> "" And telefono <> "" And mail <> "" And direccion <> "" Then
            strSql = "UPDATE proveedor set nombre ='" & nombre & "', " &
                         " telefono = " & telefono & ", " &
                         " mail ='" & mail & "'," &
                         " direccion ='" & direccion & "' " &
                         " WHERE telefono = " & telprev
            xCnx.objetoCommand(strSql)
        ElseIf mail = "" And direccion = "" Then
            strSql = "UPDATE proveedor set nombre ='" & nombre & "', " &
                         " telefono = " & telefono & " " &
                         " WHERE telefono = " & telprev
            xCnx.objetoCommand(strSql)
        ElseIf direccion = "" Then
            strSql = "UPDATE proveedor set nombre ='" & nombre & "', " &
                         " telefono = " & telefono & ", " &
                         " mail ='" & mail & "' " &
                         " WHERE telefono = " & telprev
            xCnx.objetoCommand(strSql)
        ElseIf mail = "" Then
            strSql = "UPDATE proveedor set nombre ='" & nombre & "', " &
                         " telefono = " & telefono & ", " &
                         " direccion ='" & direccion & "' " &
                         " WHERE telefono = " & telprev
            xCnx.objetoCommand(strSql)
        ElseIf nombre = "" Then
            MsgBox("No se puede actualizar, datos obligatorios")
        ElseIf telefono = "" Then
            MsgBox("No se puede actualizar, datos obligatorios")
        End If
    End Sub

    Public Sub eliminarProveedor()
        Dim strSql As String
        Dim xCnx As New Oracle
        'Validamos que ese alumno no esté Integrado en algún equipo

        If telefono <> "" Then

            strSql = "UPDATE proveedor " &
                     "SET eliminado = 1 " &
                     "WHERE telefono= " & telefono & ""

            xCnx.objetoCommand(strSql)
            MsgBox("Usuario eliminado")
        Else
            MsgBox("Faltan datos !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    Public Function consultaUnProveedor() As Boolean
        ' Método para buscar a un usuario en párticular, para saber
        ' si es un nuevo usuario o uno existente
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        'Preparamos el query para buscar al usuario, con el dato
        'capturado en la caja de textos txt_usuario de la pantalla
        'FrmUsuarios
        strSQL = "SELECT * FROM proveedor " &
                 "WHERE telefono = " & telefono & " and eliminado = 0"
        consultaUnProveedor = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("telefono")) Then
                telefono = 0
            Else
                telefono = CStr(xDT.Rows(0)("telefono"))
            End If
            consultaUnProveedor = True
        End If
    End Function

    Public Function consultaTodosProveedor() As Object
        'Método para listar a todos los usuarios en el DGV
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "SELECT codigoProveedor as codigo , nombre as Nombre, telefono, mail as Correo, direccion" &
                 " From proveedor where eliminado = 0 order By codigoProveedor"
        consultaTodosProveedor = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridRegistroDeProveedores(ByVal DGVProovedores As DataGridView)
        'Llamamos al método que obtiene los registros de los usuarios
        DGVProovedores.DataSource = consultaTodosProveedor()
        DGVProovedores.Refresh()
        'Establecer ancho de cada columna del DataGridView, el 
        'número de columnas del DGV debe ser igual al número
        'de atributos recuperados en el query del método
        'consultaTodosUsuarios
        DGVProovedores.Columns.Item(0).Width = 60
        DGVProovedores.Columns.Item(1).Width = 100
        DGVProovedores.Columns.Item(2).Width = 100
        DGVProovedores.Columns.Item(3).Width = 100

    End Sub
End Class
