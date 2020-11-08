Public Class Ventas
    Private codigoCliente As String

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblfecha.Text = Today
        dgvexist.ReadOnly = False
        dgvventa.ReadOnly = False

        llenarCombo(cmbcliente, "Select codigoCliente, nombre || ' ' || paterno || ' ' || materno as nombre from cliente", "codigoCliente", "Nombre")
        codigoCliente = cmbcliente.SelectedValue

        Dim datagridext As New ClaseVentas()
        datagridext.PoblarDataGridExist(dgvexist)
        cnx.Close()
    End Sub

    Private Sub dgvexist_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvexist.CellClick
        Dim renglon As Integer

        'Al darle clic al renglón del DGV mostramos los datos en las cajas de texto
        'el valor de cada celda es pasado a la caja de texto o combo correspondiente
        renglon = dgvexist.CurrentCellAddress.Y
        txtcodigoven.Text = dgvexist.Rows(renglon).Cells(0).Value
        txtnombreven.Text = dgvexist.Rows(renglon).Cells(1).Value
    End Sub
End Class