Public Class RegistroDeVentas
    Private cdgVenta As String
    Private Sub RegistroDeVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim datagridext As New ClaseRegistroDeVentas()
        datagridext.PoblarDataGridVenta(DGVVentas)
        cnx.Close()
    End Sub

    Private Sub dgvventas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVVentas.CellClick
        Dim renglon As Integer

        'Al darle clic al renglón del DGV mostramos los datos en las cajas de texto
        'el valor de cada celda es pasado a la caja de texto o combo correspondiente
        renglon = DGVVentas.CurrentCellAddress.Y
        cdgVenta = DGVVentas.Rows(renglon).Cells(0).Value
        Dim datagridext As New ClaseRegistroDeVentas()
        datagridext.PoblarDataGridVentaDetallada(DGVDetallada, cdgVenta)
        cnx.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Ventas.Show()
        Me.Close()
    End Sub

    Private Sub DGVVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVVentas.CellContentClick

    End Sub
End Class