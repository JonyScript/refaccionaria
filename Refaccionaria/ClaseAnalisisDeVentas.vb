Public Class ClaseAnalisisDeVentas
    Public Function consultaVentaPROD() As Object
        'Método para listar a todos los usuarios en el DGV
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "select ventadetallada.codigoproducto as Codigo, nombreproducto as producto, marca.descripcion as marca, sum(cantidadproducto) as vendidos, to_char(sum(cantidadproducto)*precio, 'fm99990.00') as Total " &
                 "From ventadetallada, producto, marca, venta where to_char(fechaventa, 'RR') ='" & AnalisisDeVentas.cb_anio.SelectedValue & "' and to_char(fechaventa, 'MM') = '" & AnalisisDeVentas.cb_mes.SelectedValue & "' and venta.codigoventa = ventadetallada.codigoventa and " &
                 "ventadetallada.codigoproducto = producto.codigoproducto and producto.codigomarca = marca.codigomarca " &
                 "group by ventadetallada.codigoproducto, producto.nombreproducto, producto.codigomarca, marca.descripcion, producto.precio order by sum(cantidadproducto) desc"
        consultaVentaPROD = xCnx.objetoDataAdapter(strSQL)
    End Function
    Public Function consultaVentaGAN() As Object
        'Método para listar a todos los usuarios en el DGV
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "select to_char(sum(totalventa), 'fm99990.00') as Ingresos from venta where to_char(fechaventa, 'RR') = '" & AnalisisDeVentas.cb_anio.SelectedValue & "' and to_char(fechaventa, 'MM') = '" & AnalisisDeVentas.cb_mes.SelectedValue & "'"
        consultaVentaGAN = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridVendidos(ByVal DGVVEN As DataGridView)

        'Llamamos al método que obtiene los registros de los usuarios
        DGVVEN.DataSource = consultaVentaPROD()
        DGVVEN.Refresh()
        'Establecer ancho de cada columna del DataGridView, el 
        'número de columnas del DGV debe ser igual al número
        'de atributos recuperados en el query del método
        'consultaTodosUsuarios
        DGVVEN.Columns.Item(0).Width = 100
        DGVVEN.Columns.Item(1).Width = 150
        DGVVEN.Columns.Item(2).Width = 100
        DGVVEN.Columns.Item(3).Width = 100
        DGVVEN.Columns.Item(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGVVEN.Columns.Item(4).Width = 60
        DGVVEN.Columns.Item(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Public Sub PoblarDataGridGanancias(ByVal DGVGAN As DataGridView)

        'Llamamos al método que obtiene los registros de los usuarios
        DGVGAN.DataSource = consultaVentaGAN()
        DGVGAN.Refresh()
        'Establecer ancho de cada columna del DataGridView, el 
        'número de columnas del DGV debe ser igual al número
        'de atributos recuperados en el query del método
        'consultaTodosUsuarios
        DGVGAN.Columns.Item(0).Width = 150
        DGVGAN.Columns.Item(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

End Class
