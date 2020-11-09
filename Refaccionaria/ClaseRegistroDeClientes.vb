﻿Public Class ClaseRegistroDeClientes
    Private codigoCliente As String
    Private nombre As String
    Private paterno As String
    Private materno As String
    Private telefono As String
    Private RFC As String
    Private direccion As String
    Private mail As String

    Public Sub New()
        codigoCliente = ""
        nombre = ""
        paterno = ""
        materno = ""
        telefono = ""
        RFC = ""
        direccion = ""
        mail = ""
    End Sub

    Public Sub New(ByVal txtnombreC As String,
                   ByVal txtpaternoC As String, ByVal txtmaternoC As String,
                   ByVal txttelefonoC As String, ByVal txtRFC As String,
                   ByVal txtdireccionC As String, ByVal txtmailC As String)

        nombre = txtnombreC
        paterno = txtpaternoC
        materno = txtmaternoC
        telefono = txttelefonoC
        RFC = txtRFC
        direccion = txtdireccionC
        mail = txtmailC

    End Sub

    Public Property getSetnombreC() As String
        Get
            Return nombre
        End Get
        Set(ByVal Value As String)
            nombre = Value
        End Set
    End Property
    Public Property getSetpaternoC() As String
        Get
            Return paterno
        End Get
        Set(ByVal Value As String)
            paterno = Value
        End Set
    End Property
    Public Property getSetmaternoC() As String
        Get
            Return materno
        End Get
        Set(ByVal Value As String)
            materno = Value
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
    Public Property getSetRFC() As String
        Get
            Return RFC
        End Get
        Set(ByVal Value As String)
            RFC = Value
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
    Public Property getSetmailC() As String
        Get
            Return mail
        End Get
        Set(ByVal Value As String)
            mail = Value
        End Set
    End Property

    Public Sub insertarCliente()
        Dim strSql As String
        Dim xCnx As New Oracle
        ' Validamos que no falten datos en las variables, en caso contrario no se 
        ' permite hacer el insert
        If nombre <> "" And paterno <> "" And materno <> "" And telefono <> "" And RFC <> "" And direccion <> "" And mail <> "" Then
            strSql = "INSERT INTO cliente VALUES((Select count(codigoCliente)+1 from cliente), '" & nombre & "', '" & paterno & "', '" & materno & "', " & telefono & ",'" & RFC & "', '" & direccion & "', '" & mail & "')"
            xCnx.objetoCommand(strSql)
            MsgBox("Nuevo cliente registrado")
        ElseIf nombre <> "" And paterno <> "" And materno <> "" And telefono <> "" And RFC <> "" And direccion <> "" Then
            strSql = "INSERT INTO cliente(codigoCliente, nombre, paterno, materno, telefono, RFC, direccion)VALUES((Select count(codigoCliente)+1 from cliente), '" & nombre & "', '" & paterno & "', '" & materno & "', " & telefono & ",'" & RFC & "', '" & direccion & "')"
            xCnx.objetoCommand(strSql)
            MsgBox("Nuevo cliente registrado")
        ElseIf nombre <> "" And paterno <> "" And materno <> "" And telefono <> "" And RFC <> "" And mail <> "" Then
            strSql = "INSERT INTO cliente(codigoCliente, nombre, paterno, materno, telefono, RFC, mail)VALUES((Select count(codigoCliente)+1 from cliente), '" & nombre & "', '" & paterno & "', '" & materno & "', " & telefono & ",'" & RFC & "', '" & mail & "')"
            xCnx.objetoCommand(strSql)
            MsgBox("Nuevo cliente registrado")
        ElseIf nombre <> "" And paterno <> "" And materno <> "" And telefono <> "" And direccion <> "" And mail <> "" Then
            strSql = "INSERT INTO cliente(codigoCliente, nombre, paterno, materno, telefono, direccion, mail)VALUES((Select count(codigoCliente)+1 from cliente), '" & nombre & "', '" & paterno & "', '" & materno & "', " & telefono & ",'" & direccion & "', '" & mail & "')"
            xCnx.objetoCommand(strSql)
            MsgBox("Nuevo cliente registrado")
        ElseIf nombre <> "" And paterno <> "" And materno <> "" And telefono <> "" And RFC <> "" Then
            strSql = "INSERT INTO cliente(codigoCliente, nombre, paterno, materno, telefono, RFC)VALUES((Select count(codigoCliente)+1 from cliente), '" & nombre & "', '" & paterno & "', '" & materno & "', " & telefono & ",'" & RFC & "')"
            xCnx.objetoCommand(strSql)
            MsgBox("Nuevo cliente registrado")
        ElseIf nombre <> "" And paterno <> "" And materno <> "" And telefono <> "" And direccion <> "" Then
            strSql = "INSERT INTO cliente(codigoCliente, nombre, paterno, materno, telefono, direccion)VALUES((Select count(codigoCliente)+1 from cliente), '" & nombre & "', '" & paterno & "', '" & materno & "', " & telefono & ",'" & direccion & "')"
            xCnx.objetoCommand(strSql)
            MsgBox("Nuevo cliente registrado")
        ElseIf nombre <> "" And paterno <> "" And materno <> "" And telefono <> "" And mail <> "" Then
            strSql = "INSERT INTO cliente(codigoCliente, nombre, paterno, materno, telefono, mail)VALUES((Select count(codigoCliente)+1 from cliente), '" & nombre & "', '" & paterno & "', '" & materno & "', " & telefono & ", '" & mail & "')"
            xCnx.objetoCommand(strSql)
            MsgBox("Nuevo cliente registrado")
        ElseIf nombre <> "" And paterno <> "" And materno <> "" And telefono <> "" Then
            strSql = "INSERT INTO cliente(codigoCliente, nombre, paterno, materno, telefono)VALUES((Select count(codigoCliente)+1 from cliente), '" & nombre & "', '" & paterno & "', '" & materno & "', " & telefono & ")"
            xCnx.objetoCommand(strSql)
            MsgBox("Nuevo cliente registrado")
        Else
            MsgBox("Faltan datos obligatorios, verifique", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub
    Public Function consultaUnCliente() As Boolean
        ' Método para buscar a un usuario en párticular, para saber
        ' si es un nuevo usuario o uno existente
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        'Preparamos el query para buscar al usuario, con el dato
        'capturado en la caja de textos txt_usuario de la pantalla
        'FrmUsuarios
        strSQL = "SELECT * FROM cliente " &
                 "WHERE telefono = '" & telefono & "'"
        consultaUnCliente = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("telefono")) Then
                telefono = 0
            Else
                telefono = CStr(xDT.Rows(0)("telefono"))
            End If
            consultaUnCliente = True
        End If
    End Function
    Public Function consultaTodosClientes() As Object
        'Método para listar a todos los usuarios en el DGV
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "SELECT codigoCliente as Codigo, nombre as Nombre, paterno as Paterno, materno as Materno, telefono, rfc, direccion, mail as Correo" &
                 " From cliente order By codigoCliente"
        consultaTodosClientes = xCnx.objetoDataAdapter(strSQL)
    End Function
    Public Sub PoblarDataGridRegistroDeClientes(ByVal DGVUsuarios As DataGridView)
        'Llamamos al método que obtiene los registros de los usuarios
        DGVUsuarios.DataSource = consultaTodosClientes()
        DGVUsuarios.Refresh()
        'Establecer ancho de cada columna del DataGridView, el 
        'número de columnas del DGV debe ser igual al número
        'de atributos recuperados en el query del método
        'consultaTodosUsuarios
        DGVUsuarios.Columns.Item(0).Width = 100
        DGVUsuarios.Columns.Item(1).Width = 100
        DGVUsuarios.Columns.Item(2).Width = 150
        DGVUsuarios.Columns.Item(3).Width = 150
        DGVUsuarios.Columns.Item(4).Width = 150
        DGVUsuarios.Columns.Item(5).Width = 150
        DGVUsuarios.Columns.Item(6).Width = 150
        DGVUsuarios.Columns.Item(7).Width = 150
    End Sub
End Class
