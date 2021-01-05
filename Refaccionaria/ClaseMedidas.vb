Public Class ClaseMedidas
    Private medida As String
    Private codigo As String

    Public Sub New()
        medida = ""
    End Sub

    Public Sub New(ByVal txtmedida As String)
        medida = txtmedida
    End Sub

    Public Property getSmedida() As String
        Get
            Return medida
        End Get
        Set(ByVal Value As String)
            medida = Value
        End Set
    End Property

    Public Function consultaUnaMedida() As Boolean
        ' Método para buscar a un usuario en párticular, para saber
        ' si es un nuevo usuario o uno existente
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        'Preparamos el query para buscar al usuario, con el dato
        'capturado en la caja de textos txt_usuario de la pantalla
        'FrmUsuarios
        strSQL = "SELECT * FROM medida " &
                 "WHERE descripcion = '" & medida & "'"
        consultaUnaMedida = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("descripcion")) Then
                medida = 0
            Else
                medida = CStr(xDT.Rows(0)("descripcion"))
            End If
            consultaUnaMedida = True
        End If
    End Function

    Public Function getCodigoMedida() As Boolean
        ' Método para buscar a un usuario en párticular, para saber
        ' si es un nuevo usuario o uno existente
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        'Preparamos el query para buscar al usuario, con el dato
        'capturado en la caja de textos txt_usuario de la pantalla
        'FrmUsuarios
        strSQL = "SELECT max(codigoMedida)+1 as max FROM medida"
        getCodigoMedida = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("max")) Then
                codigo = 1
            Else
                codigo = CStr(xDT.Rows(0)("max"))
            End If
            getCodigoMedida = True
        End If
    End Function

    Public Sub insertarMedida()
        Dim strSql As String
        Dim xCnx As New Oracle
        ' Validamos que no falten datos en las variables, en caso contrario no se 
        ' permite hacer el insert
        getCodigoMedida()
        If codigo <> "" And medida <> "" Then
            ' Preparamos el query para insertar el registro
            strSql = "INSERT INTO medida VALUES(" & codigo & ", '" & medida & "')"
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos, verifique !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

End Class
