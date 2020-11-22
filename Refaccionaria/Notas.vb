Public Class Notas
    Private Sub Notas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nota As New ClaseNotas()
        nota.PoblarDataGridNotas(DGVNotas)
        txtcdgventa.Text = codigoVenta
        txtfecha.Text = nota.getFecha()
        txtcliente.Text = nota.getCliente()
        txtvendedor.Text = nombreUsuarioConectado
        txttotal.Text = nota.getTotal()
        cnx.Close()
    End Sub
    Private Sub print_Click(sender As Object, e As EventArgs) Handles print.Click
    End Sub
End Class