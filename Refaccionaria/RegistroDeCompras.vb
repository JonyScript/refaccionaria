Public Class RegistroDeCompras
    Private cdgCompra As String
    Private Sub RegistroDeCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim datagridtext As New ClaseRegistroDeCompras()
        datagridtext.PoblarDataGridCompra(DGVCompras)
        cnx.Close()
    End Sub

    Private Sub dgvcompras_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCompras.CellClick
        Dim renglon As Integer

        'Al darle clic al renglón del DGV mostramos los datos en las cajas de texto
        'el valor de cada celda es pasado a la caja de texto o combo correspondiente
        renglon = DGVCompras.CurrentCellAddress.Y
        cdgCompra = DGVCompras.Rows(renglon).Cells(0).Value
        Dim datagridext As New ClaseRegistroDeCompras()
        datagridext.PoblarDataGridCompraDetallada(DGVCDetallada, cdgCompra)
        cnx.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CompraDeProductos.Show()
        Me.Close()
    End Sub
End Class