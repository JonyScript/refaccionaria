
Imports Oracle.ManagedDataAccess.Client

Module Globales
    Public cnx As OracleConnection
    Public UsuarioConectado As String
    Public dir As String
    Public puestoUsuario As String
    Public nombreUsuarioConectado As String
    Public codigoRol As String
    Public userActual As String
    Public dir2 As String
    Public dir3 As String
    Public dir4 As String
    Public dir5 As String
    Public dir6 As String
    Public id_empleado As String
    Public id_cliente As String
    Public id_costo As String
    Public remitente As String
    Public destinatario As String
    Public id_estadopaq As String
    Public id_motivo As String
    Public codigoMedida As String
    Public codigoMarca As String
    Public codigoVenta As String

    Public clienteGlobal As String

    Dim dt As Date = Today


    Public Sub llenarCombo(ByRef combo As ComboBox, ByVal consulta As String, ByVal valor As String, ByVal display As String)
        Dim xCnx As New Oracle
        combo.DataSource = xCnx.objetoDataAdapter(consulta)
        combo.DisplayMember = display
        combo.ValueMember = valor
    End Sub

    Public Sub valorCombo(ByRef combo As ComboBox, ByVal valor As String)
        combo.ValueMember = valor
    End Sub

    '    Public Conexion As OracleConnection

    '    Public Sub AbrirConexion()
    '       Conexion = New OracleConnection
    '      Conexion.ConnectionString = "User Id=system;Password=loshuevos123;Data Source=localhost:1521/XE; "
    '     Conexion.Open()
    'End Sub

End Module
