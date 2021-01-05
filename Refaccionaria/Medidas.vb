Public Class Medidas
    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If medidatxt.Text = vbNullString Then
            MessageBox.Show("Capturar el nombre de la nueva marca")
        Else
            Dim user As New ClaseMedidas(medidatxt.Text)
            If user.consultaUnaMedida() = False Then
                'Si el prodcuto no está registrado, la inserta como una nuevo
                user.insertarMedida()
                medidatxt.Clear()
                MessageBox.Show("Medida agregada correctamente")
            Else
                MessageBox.Show("La medida ya existe")
            End If
        End If

    End Sub

    Private Sub btnmedidas_Click(sender As Object, e As EventArgs) Handles btnmedidas.Click
        registroDeProductos.Show()
        Me.Close()
    End Sub
End Class