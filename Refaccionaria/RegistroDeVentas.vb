Public Class RegistroDeVentas
    Private Sub RegistroDeVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim datagridext As New ClaseRegistroDeVentas()
        datagridext.PoblarDataGridVenta(DGVVentas)
        cnx.Close()
    End Sub
End Class