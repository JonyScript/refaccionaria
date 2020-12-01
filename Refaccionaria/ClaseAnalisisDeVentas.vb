Public Class ClaseAnalisisDeVentas
    Public Function consultaVentaMAX() As Object
        'Método para listar a todos los usuarios en el DGV
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "select ventadetallada.codigoproducto as codigo, nombreproducto as producto, marca.descripcion as marca, sum(cantidadproducto) as vendidos " &
                 "From ventadetallada, producto, marca where ventadetallada.codigoproducto = producto.codigoproducto and producto.codigomarca = marca.codigomarca " &
                 "group by ventadetallada.codigoproducto, producto.nombreproducto, producto.codigomarca, marca.descripcion having sum(cantidadproducto) >= 10"
        consultaVentaMAX = xCnx.objetoDataAdapter(strSQL)
    End Function
    Public Function consultaVentaMIN() As Object
        'Método para listar a todos los usuarios en el DGV
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "select ventadetallada.codigoproducto as codigo, nombreproducto as producto, marca.descripcion as marca, sum(cantidadproducto) as vendidos " &
                 "From ventadetallada, producto, marca where ventadetallada.codigoproducto = producto.codigoproducto and producto.codigomarca = marca.codigomarca " &
                 "group by ventadetallada.codigoproducto, producto.nombreproducto, producto.codigomarca, marca.descripcion having sum(cantidadproducto) <= 9"
        consultaVentaMIN = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridMAS(ByVal DGVMIN As DataGridView)

        'Llamamos al método que obtiene los registros de los usuarios
        DGVMIN.DataSource = consultaVentaMAX()
        DGVMIN.Refresh()
        'Establecer ancho de cada columna del DataGridView, el 
        'número de columnas del DGV debe ser igual al número
        'de atributos recuperados en el query del método
        'consultaTodosUsuarios
        DGVMIN.Columns.Item(0).Width = 100
        DGVMIN.Columns.Item(1).Width = 200
        DGVMIN.Columns.Item(2).Width = 100
        DGVMIN.Columns.Item(3).Width = 100
    End Sub

    Public Sub PoblarDataGridMENOS(ByVal DGVMAX As DataGridView)

        'Llamamos al método que obtiene los registros de los usuarios
        DGVMAX.DataSource = consultaVentaMIN()
        DGVMAX.Refresh()
        'Establecer ancho de cada columna del DataGridView, el 
        'número de columnas del DGV debe ser igual al número
        'de atributos recuperados en el query del método
        'consultaTodosUsuarios
        DGVMAX.Columns.Item(0).Width = 100
        DGVMAX.Columns.Item(1).Width = 200
        DGVMAX.Columns.Item(2).Width = 100
        DGVMAX.Columns.Item(3).Width = 100
    End Sub

End Class
