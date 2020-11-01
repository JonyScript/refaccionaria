Public Class Registro_de_usuarios
    Private Sub Registro_de_usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVUsuarios.ReadOnly = False

        llenarCombo(cbx_rol, "Select codigoRol, descripcion from rol", "codigoRol", "descripcion")
        codigoRol = cbx_rol.SelectedValue

        Dim datagrid As New ClaseRegistroDeUsuarios()
        datagrid.PoblarDataGridRegistroDeUsuarios(DGVUsuarios)
        cnx.Close()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_rol.SelectedIndexChanged
        Dim x, i As Integer
        puestoUsuario = ""
        dir = cbx_rol.Text
        i = 0
        x = 0

        For x = 0 To dir.Length - 1
            If dir.Chars(x) = " " Then


                Exit For
            End If
            i = i + 1
        Next

        For x = 1 To i
            puestoUsuario = puestoUsuario + Mid(dir, x, 1)
        Next x
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If username_txt.Text = vbNullString Then
            MessageBox.Show("Capturar el nombre de usuario")
        ElseIf nombre_txt.Text = vbNullString Then
            MessageBox.Show("Capturar nombre")
        ElseIf ap_txt.Text = vbNullString Then
            MessageBox.Show("Capturar apellido paterno")
        ElseIf am_txt.Text = vbNullString Then
            MessageBox.Show("Capturar apellido materno")
        ElseIf pass_txt.Text = vbNullString Then
            MessageBox.Show("Capturar contraseña")
        ElseIf pass2_txt.Text = vbNullString Then
            MessageBox.Show("Capturar confirmación de contraseña")
        ElseIf cbx_rol.Text = vbNullString Then
            MessageBox.Show("Capturar rol de usuario")
        Else
            If (pass_txt.Text = pass2_txt.Text) Then
                Dim user As New ClaseRegistroDeUsuarios(username_txt.Text, cbx_rol.Text, nombre_txt.Text, ap_txt.Text, am_txt.Text, pass_txt.Text)
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVUsuarios.CellContentClick

    End Sub

    Private Sub DGVUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVUsuarios.CellClick
        Dim renglon As Integer

        'Al darle clic al renglón del DGV mostramos los datos en las cajas de texto
        'el valor de cada celda es pasado a la caja de texto o combo correspondiente
        renglon = DGVUsuarios.CurrentCellAddress.Y
        userActual = DGVUsuarios.Rows(renglon).Cells(0).Value
        username_txt.Text = DGVUsuarios.Rows(renglon).Cells(0).Value
        cbx_rol.Text = DGVUsuarios.Rows(renglon).Cells(1).Value
        nombre_txt.Text = DGVUsuarios.Rows(renglon).Cells(2).Value
        ap_txt.Text = DGVUsuarios.Rows(renglon).Cells(3).Value
        am_txt.Text = DGVUsuarios.Rows(renglon).Cells(4).Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim user As New ClaseRegistroDeUsuarios(username_txt.Text, nombre_txt.Text, ap_txt.Text, am_txt.Text, pass_txt.Text, cbx_rol.SelectedValue)
            'Verificmos que el pais se encuentre registrado
            If user.consultaUnUsuario() = False Then
                MsgBox("No se puede eliminar al usuario, verifique ...")
            Else
                'Llamamos al método que elimina el registro
                user.eliminarUsuario()
                'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
                user.PoblarDataGridRegistroDeUsuarios(DGVUsuarios)
                'Cerramos la conexión a la BD
                cnx.Close()
                username_txt.Clear()
                nombre_txt.Clear()
                ap_txt.Clear()
                am_txt.Clear()
                pass_txt.Clear()
                pass2_txt.Clear()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles back.Click
        cnx.Close()
        menuAdministrador.Show()
        Me.Hide()
    End Sub

    Private Sub username_txt_TextChanged(sender As Object, e As EventArgs) Handles username_txt.TextChanged

    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        username_txt.Clear()
        nombre_txt.Clear()
        ap_txt.Clear()
        am_txt.Clear()
        pass_txt.Clear()
        pass2_txt.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim actualiza As New ClaseRegistroDeUsuarios(username_txt.Text, nombre_txt.Text, ap_txt.Text, am_txt.Text, pass_txt.Text, cbx_rol.SelectedValue)
        actualiza.actualizaUsuario()
        actualiza.PoblarDataGridRegistroDeUsuarios(DGVUsuarios)
        cnx.Close()
    End Sub
End Class