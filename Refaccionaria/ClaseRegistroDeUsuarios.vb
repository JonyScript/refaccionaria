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
End Class
