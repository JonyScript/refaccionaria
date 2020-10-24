Public Class Form1
    <Obsolete>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        getSetPrueba = TextBox1.Text
        MsgBox("boton presionado")
        insertaPais()
    End Sub

    Public Property getSetPrueba() As String
        Get
            Return id_pais
        End Get
        Set(ByVal Value As String)
            id_pais = Value
            MsgBox("id pais igual a " + id_pais)
        End Set
    End Property

    <Obsolete>
    Public Sub insertaPais()
        Dim strSql As String
        Dim xCnx As New Oracle
        ' Validamos que no falten datos en las variables, en caso contrario no se 
        ' permite hacer el insert
        If pais <> "" And id_pais <> "" Then
            ' Preparamos el query para insertar el registro

            strSql = "INSERT INTO prueba VALUES(" & id_pais & ", '" &
                                                      pais & "')"
            xCnx.objetoCommand(strSql)
            MsgBox("ai la llevas")
        Else
            MsgBox("Faltan datos para el pais, verifique !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
