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

End Class