Imports Oracle.ManagedDataAccess.Client

Public Class ClaseLogin
    'hola clase prueba
    'El pepe
    Private usuario As String
    Private contrasena As String

    Public Sub New()
        usuario = ""
        contrasena = ""
    End Sub

    Public Sub New(ByVal usu As String, ByVal con As String)
        'Aquí recibimos los datos
        usuario = usu
        contrasena = con
    End Sub

    Public Function consultausuario() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT * FROM usuario " &
               "WHERE codigousuario ='" & usuario & "' and contrasena ='" & contrasena & "'"
        consultausuario = False

        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then

            If IsDBNull(xDT.Rows(0)("contrasena")) Then
                contrasena = ""
            Else
                contrasena = CStr(xDT.Rows(0)("contrasena"))
                nombreUsuarioConectado = CStr(xDT.Rows(0)("nombre")) & " " & CStr(xDT.Rows(0)("paterno")) & " " & CStr(xDT.Rows(0)("materno"))
                UsuarioConectado = CStr(xDT.Rows(0)("codigousuario"))
                puestoUsuario = CStr(xDT.Rows(0)("codigorol"))
            End If
            consultausuario = True
        End If
    End Function

End Class
