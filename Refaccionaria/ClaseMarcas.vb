Public Class ClaseMarcas
    Private marca As String
    Private codigo As String

    Public Sub New()
        marca = ""
    End Sub

    Public Sub New(ByVal txtmarca As String)
        marca = txtmarca
    End Sub

    Public Property getSmarca() As String
        Get
            Return marca
        End Get
        Set(ByVal Value As String)
            marca = Value
        End Set
    End Property

    Public Function consultaUnaMarca() As Boolean
        ' Método para buscar a un usuario en párticular, para saber
        ' si es un nuevo usuario o uno existente
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        'Preparamos el query para buscar al usuario, con el dato
        'capturado en la caja de textos txt_usuario de la pantalla
        'FrmUsuarios
        strSQL = "SELECT * FROM marca " &
                 "WHERE descripcion = '" & marca & "'"
        consultaUnaMarca = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("descripcion")) Then
                marca = 0
            Else
                marca = CStr(xDT.Rows(0)("descripcion"))
            End If
            consultaUnaMarca = True
        End If
    End Function

    Public Function getCodigoMarca() As Boolean
        ' Método para buscar a un usuario en párticular, para saber
        ' si es un nuevo usuario o uno existente
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        'Preparamos el query para buscar al usuario, con el dato
        'capturado en la caja de textos txt_usuario de la pantalla
        'FrmUsuarios
        strSQL = "SELECT max(codigoMarca)+1 as max FROM marca"
        getCodigoMarca = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("max")) Then
                codigo = 1
            Else
                codigo = CStr(xDT.Rows(0)("max"))
            End If
            getCodigoMarca = True
        End If
    End Function

    Public Sub insertarMarca()
        Dim strSql As String
        Dim xCnx As New Oracle
        ' Validamos que no falten datos en las variables, en caso contrario no se 
        ' permite hacer el insert
        getCodigoMarca()
        If codigo <> "" And marca <> "" Then
            ' Preparamos el query para insertar el registro
            strSql = "INSERT INTO marca VALUES(" & codigo & ", '" & marca & "')"
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos, verifique !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

End Class
