Public Class Marcas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If marcatxt.Text = vbNullString Then
            MessageBox.Show("Capturar el nombre de la nueva marca")
        Else
            Dim user As New ClaseMarcas(marcatxt.Text)
            If user.consultaUnaMarca() = False Then
                'Si el prodcuto no está registrado, la inserta como una nuevo
                user.insertarMarca()
                marcatxt.Clear()
                MessageBox.Show("Marca agregada correctamente")
            Else
                MessageBox.Show("La marca ya existe")
            End If
        End If

    End Sub

    Private Sub btnatras_Click(sender As Object, e As EventArgs) Handles btnatras.Click
        registroDeProductos.Show()
        Me.Close()
    End Sub
End Class