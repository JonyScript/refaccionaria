Public Class registroDeProductos
    Private Sub registroDeProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVRproductos.ReadOnly = False

        llenarCombo(Medida, "Select codigoMedida, descripcion from medida", "codigoMedida", "descripcion")
        codigoRol = Medida.SelectedValue

        Dim datagrid As New ClaseRegistroDeproductos()
        datagrid.PoblarDataGridRegistroDeUsuarios(DGVRproductos)
        cnx.Close()
    End Sub
    Private Sub Medida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Medida.SelectedIndexChanged
        Dim x, i As Integer
        codigoMedida = ""
        dir = Medida.Text
        i = 0
        x = 0

        For x = 0 To dir.Length - 1
            If dir.Chars(x) = " " Then


                Exit For
            End If
            i = i + 1
        Next

        For x = 1 To i
            codigoMedida = codigoMedida + Mid(dir, x, 1)
        Next x
    End Sub
    Private Sub AgregarProductos_Click(sender As Object, e As EventArgs) Handles AgregarProductos.Click
        If Codigo.Text = vbNullString Then
            MessageBox.Show("Capturar el codigo")
        ElseIf NombreDproducto.Text = vbNullString Then
            MessageBox.Show("Capturar nombre")
        ElseIf PrecioDeVenta.Text = vbNullString Then
            MessageBox.Show("Captura precio de venta")
        Else
            Dim user As New ClaseRegistroDeProductos(username_txt.Text, cbx_rol.Text, nombre_txt.Text, ap_txt.Text, am_txt.Text, pass_txt.Text)
            user.getSetUsuario = username_txt.Text
                user.getSetrol = cbx_rol.Text
                user.getSetnombre = nombre_txt.Text
                user.getSetpaterno = ap_txt.Text
                user.getSetmaterno = am_txt.Text
                user.getSetcontrasena = pass_txt.Text

                If user.consultaUnUsuario() = False Then
                    'Si el usuario no está registrado, la inserta como una nuevo
                    user.insertarUsuario()
                    username_txt.Clear()
                    nombre_txt.Clear()
                    ap_txt.Clear()
                    am_txt.Clear()
                    pass_txt.Clear()
                    pass2_txt.Clear()
                Else
                    MessageBox.Show("El id del usuario ya existe")
                End If
                cnx.Close()
            Else
                MessageBox.Show("Las contraseñas no son iguales")
            End If
            Dim datagrid As New ClaseRegistroDeUsuarios()
            datagrid.PoblarDataGridRegistroDeUsuarios(DGVUsuarios)
            cnx.Close()
        End If
    End Sub
End Class