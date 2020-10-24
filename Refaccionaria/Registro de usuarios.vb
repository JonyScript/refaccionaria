Public Class Registro_de_usuarios
    Private Sub Registro_de_usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCombo(cbx_rol, "Select codigoRol, descripcion as Rol from rol", "codigoRol", "Descripcion")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

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
            Dim paq As New ClasePaquetes(txt_id_paq.Text)
            paq.getSetPaquete = txt_id_paq.Text

            If paq.consultaUnPaquete() = False Then
                'Si el usuario no está registrado, la inserta como una nuevo
                paq.insertaPaquete()
            Else
                MessageBox.Show("El id del paquete ya existe !!")
            End If
            paq.PoblarDataGridPaquetes(DGVPaquete)
            cnx.Close()
        End If
    End Sub
End Class