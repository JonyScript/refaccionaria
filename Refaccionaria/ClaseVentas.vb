Public Class ClaseVentas
    Private codigoVenta As String
    Private codigocliente As String
    Private codigoUsuario As String
    Private fechaVenta As String
    Private totalVenta As String

    Private codigoVentaDetallada As String
    Private cantidadProducto As String

    Private codigoProducto As String
    Private codigoMedida As String
    Private nombreProducto As String
    Private precio As String
    Private existencia As String
    Private eliminado As String

    Public Sub New()
        codigoProducto = ""
        codigoMedida = ""
        nombreProducto = ""
        precio = ""
        existencia = ""
        eliminado = ""
        codigoVentaDetallada = ""
        cantidadProducto = ""
        codigoVenta = ""
        codigocliente = ""
        codigoUsuario = ""
        fechaVenta = ""
        totalVenta = ""
    End Sub

    Public Function consultaProductos() As Object
        'Método para listar a todos los usuarios en el DGV
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "SELECT codigoProducto as codigo,nombreProducto as producto,descripcion as medida,precio as precio, existencia as existencia" &
                 "  From producto, medida where producto.codigoMedida = medida.codigoMedida and eliminado = 0" & " Order By codigo"
        consultaProductos = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridExist(ByVal DGVExist As DataGridView)
        'Llamamos al método que obtiene los registros de los usuarios
        DGVExist.DataSource = consultaProductos()
        DGVExist.Refresh()
        'Establecer ancho de cada columna del DataGridView, el 
        'número de columnas del DGV debe ser igual al número
        'de atributos recuperados en el query del método
        'consultaTodosUsuarios
        DGVExist.Columns.Item(0).Width = 100
        DGVExist.Columns.Item(1).Width = 200
        DGVExist.Columns.Item(2).Width = 200
        DGVExist.Columns.Item(3).Width = 100
        DGVExist.Columns.Item(4).Width = 100

    End Sub

End Class
