Public Class registroDeProductos
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AgregarProducto.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ModificarProducto.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        menuAdministrador.Show()
        Me.Close()
    End Sub
End Class