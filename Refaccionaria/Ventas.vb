Public Class Ventas
    Private codigoCliente As String

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formPrev = "ventas"
        lblfecha.Text = Today
        dgvexist.ReadOnly = False
        dgvventa.ReadOnly = False

        llenarCombo(cmbcliente, "Select codigoCliente, nombre || ' ' || paterno || ' ' || materno as nombre from cliente where eliminado = 0", "codigoCliente", "Nombre")
        codigoCliente = cmbcliente.SelectedValue

        'botones y controles inicialmente escondidos / desactivados
        btnagregar.Enabled = False
        btnremover.Enabled = False
        btnnota.Enabled = False
        btnfactura.Enabled = False
        btnconfirmar.Enabled = False
        dgvventa.Hide()

        Dim datagridext As New ClaseVentas()
        datagridext.PoblarDataGridExist(dgvexist)
        cnx.Close()
    End Sub

    Private Sub dgvexist_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvexist.CellClick
        txtcantidad.Clear()
        Dim renglon As Integer

        'Al darle clic al renglón del DGV mostramos los datos en las cajas de texto
        'el valor de cada celda es pasado a la caja de texto o combo correspondiente
        renglon = dgvexist.CurrentCellAddress.Y
        txtcodigoven.Text = dgvexist.Rows(renglon).Cells(0).Value
        txtnombreven.Text = dgvexist.Rows(renglon).Cells(1).Value
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        'boton para agregar productos a una venta / agregar registros a venta detallada
        Dim venta As New ClaseVentas()
        If venta.consultaUnProducto(txtcodigoven.Text) = False Then
            venta.insertarProducto(txtcodigoven.Text, txtcantidad.Text)
        Else
            MsgBox("Este producto ya ha sido insertado en la venta actual")
        End If

        venta.PoblarDataGridVentas(dgvventa)
        venta.PoblarDataGridExist(dgvexist)
        cnx.Close()
        txtcantidad.Clear()
        txtcodigoven.Clear()
        txtnombreven.Clear()
        txttotal.Text = venta.getTotal
    End Sub

    Private Sub btnnuevaventa_Click(sender As Object, e As EventArgs) Handles btnnuevaventa.Click

        'activar inicialmente escondidos
        btnagregar.Enabled = True
        btnnuevaventa.Enabled = False
        btnconfirmar.Enabled = True
        dgvventa.Show()
        codigoCliente = cmbcliente.SelectedValue

        Dim venta As New ClaseVentas()
        venta.insertarVenta(codigoCliente)
        cnx.Close()
    End Sub

    Private Sub dgvventa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvventa.CellClick
        btnremover.Enabled = True
        Dim renglon As Integer

        'Al darle clic al renglón del DGV mostramos los datos en las cajas de texto
        'el valor de cada celda es pasado a la caja de texto o combo correspondiente
        renglon = dgvventa.CurrentCellAddress.Y
        txtcodigoven.Text = dgvventa.Rows(renglon).Cells(0).Value
        txtnombreven.Text = dgvventa.Rows(renglon).Cells(1).Value
        txtcantidad.Text = dgvventa.Rows(renglon).Cells(5).Value
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        If puestoUsuario = 1 Then
            menuAdministrador.Show()
        ElseIf puestoUsuario = 2 Then
            menuVendedor.Show()
        End If
        Me.Close()
    End Sub

    Private Sub btnfactura_Click(sender As Object, e As EventArgs) Handles btnfactura.Click
        'boton para generar facturas abre navegador en pagina de factureya, pendiente de añadir credenciales de inicio de sesion de la refaccionaria
        Dim webAddress As String = "https://www.factureya.com/Portal/Presentacion/Home/Index.aspx"
        Process.Start(webAddress)
    End Sub

    Private Sub btnconfirmar_Click(sender As Object, e As EventArgs) Handles btnconfirmar.Click
        'al confirmar venta se desactiva el boton para agregar y remover productos
        btnagregar.Enabled = False
        btnremover.Enabled = False
        btnnuevaventa.Enabled = True
        btnnota.Enabled = True
        btnfactura.Enabled = True
        btnconfirmar.Enabled = False
        Dim venta As New ClaseVentas()
        txttotal.Text = venta.getTotal()
        venta.insertarTotal(venta.getTotal())
        cnx.Close()
    End Sub

    Private Sub btnremover_Click(sender As Object, e As EventArgs) Handles btnremover.Click
        Dim venta As New ClaseVentas()
        venta.eliminarProducto(txtcodigoven.Text, txtcantidad.Text)
        venta.PoblarDataGridExist(dgvexist)
        venta.PoblarDataGridVentas(dgvventa)
        cnx.Close()
        btnremover.Enabled = False
        txtcantidad.Clear()
        txtcodigoven.Clear()
        txtnombreven.Clear()
    End Sub

    Private Sub btnnota_Click(sender As Object, e As EventArgs) Handles btnnota.Click
        cnx.Close()
        Notas.Show()
        Me.Close()
    End Sub

    Private Sub btnregistro_Click(sender As Object, e As EventArgs) Handles btnregistro.Click
        cnx.Close()
        RegistroDeVentas.Show()
        Me.Close()
    End Sub

    Private Sub cmbcliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcliente.SelectedIndexChanged
        'If formPrev = "1" Then
        'llenarCombo(cmbcliente, "Select codigoCliente, nombre || ' ' || paterno || ' ' || materno as nombre from cliente where eliminado = 0", "codigoCliente", "Nombre")
        'codigoCliente = cmbcliente.SelectedValue
        'End If
    End Sub

    Private Sub btncliente_Click(sender As Object, e As EventArgs) Handles btncliente.Click
        cnx.Close()
        RegistroDeClientes.Show()
        Me.Close()
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim venta As New ClaseVentas()
        venta.PoblarDataGridExist(dgvexist)
        txtcodigoprod.Clear()
        txtnombreprod.Clear()
    End Sub
End Class