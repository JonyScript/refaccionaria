Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class registroDeProductos
    Private Sub registroDeProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Labelfecha.Text = Today
        DGVRproductos.ReadOnly = False
        llenarCombo(Medida, "Select codigoMedida, descripcion from medida", "codigoMedida", "descripcion")
        codigoMedida = Medida.SelectedValue
        llenarCombo(Marca, "Select codigoMarca, descripcion from marca", "codigoMarca", "descripcion")
        codigoMarca = Marca.SelectedValue

        Dim datagrid As New ClaseRegistroDeProductos()
        datagrid.PoblarDataGridRegistroDeProductos(DGVRproductos)
        cnx.Close()
        DGVRproductos.ReadOnly = False
    End Sub

    Private Sub Medida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Medida.SelectedIndexChanged
        Dim x, i As Integer
        codigoMedida = ""
        dir = Medida.Text
        i = 0
        x = 0

        For x = 0 To dir.Length - 1
            If dir.Chars(x) = " " Then


                Exit For
            End If
            i = i + 1
        Next

        For x = 1 To i
            codigoMedida = codigoMedida + Mid(dir, x, 1)
        Next x
    End Sub
    Private Sub Marca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Marca.SelectedIndexChanged
        Dim x, i As Integer
        codigoMarca = ""
        dir = Marca.Text
        i = 0
        x = 0

        For x = 0 To dir.Length - 1
            If dir.Chars(x) = " " Then


                Exit For
            End If
            i = i + 1
        Next

        For x = 1 To i
            codigoMarca = codigoMarca + Mid(dir, x, 1)
        Next x
    End Sub
    Private Sub AgregarProductos_Click(sender As Object, e As EventArgs) Handles AgregarProductos.Click
        If Codigo.Text = vbNullString Then
            MessageBox.Show("Capturar el codigo")
        ElseIf NombreDproducto.Text = vbNullString Then
            MessageBox.Show("Capturar nombre")
        ElseIf PrecioDeVenta.Text = vbNullString Then
            MessageBox.Show("Captura precio de venta")
        Else
            Dim user As New ClaseRegistroDeProductos(Codigo.Text, NombreDproducto.Text, Medida.SelectedValue, Marca.SelectedValue, PrecioDeVenta.Text, "existencia")
            'user.getSetCproducto = Codigo.Text
            'user.getSetNproducto = NombreDproducto.Text
            'user.getSetCmedida = Medida.Text
            'user.getSetCmarca = Marca.Text
            'user.getSetPrecio = PrecioDeVenta.Text

            If user.consultaUnProducto() = False Then
                'Si el prodcuto no está registrado, la inserta como una nuevo
                user.insertarProducto()
                Codigo.Clear()
                NombreDproducto.Clear()
                PrecioDeVenta.Clear()
            Else
                MessageBox.Show("El producto ya existe")
            End If
            cnx.Close()
        End If
        Dim datagrid As New ClaseRegistroDeProductos()
        datagrid.PoblarDataGridRegistroDeProductos(DGVRproductos)
        cnx.Close()
    End Sub
    Private Sub DGVRproductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVRproductos.CellClick
        Dim renglon As Integer

        'Al darle clic al renglón del DGV mostramos los datos en las cajas de texto
        'el valor de cada celda es pasado a la caja de texto o combo correspondiente
        renglon = DGVRproductos.CurrentCellAddress.Y
        Codigo.Text = DGVRproductos.Rows(renglon).Cells(0).Value
        NombreDproducto.Text = DGVRproductos.Rows(renglon).Cells(1).Value
        Medida.Text = DGVRproductos.Rows(renglon).Cells(2).Value
        Marca.Text = DGVRproductos.Rows(renglon).Cells(3).Value
        PrecioDeVenta.Text = DGVRproductos.Rows(renglon).Cells(4).Value
    End Sub

    Private Sub EliminarP_Click(sender As Object, e As EventArgs) Handles EliminarP.Click
        If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim user As New ClaseRegistroDeProductos(Codigo.Text, NombreDproducto.Text, Medida.SelectedValue, Marca.SelectedValue, PrecioDeVenta.Text, "existencia")
            'Verificmos que el pais se encuentre registrado
            If user.consultaUnProducto() = False Then
                MsgBox("No se puede eliminar el producto, verifique ...")
            Else
                'Llamamos al método que elimina el registro
                user.eliminarProducto()
                'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
                user.PoblarDataGridRegistroDeProductos(DGVRproductos)
                'Cerramos la conexión a la BD
                cnx.Close()
                Codigo.Clear()
                NombreDproducto.Clear()
                PrecioDeVenta.Clear()
            End If
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If puestoUsuario = 1 Then
            menuAdministrador.Show()
        ElseIf puestoUsuario = 2 Then
            menuVendedor.Show()
        End If
        Me.Close()
    End Sub
    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles limpiarP.Click
        Codigo.Clear()
        NombreDproducto.Clear()
        PrecioDeVenta.Clear()
    End Sub
    Private Sub ModificarP_Click(sender As Object, e As EventArgs) Handles ModificarP.Click
        Dim actualiza As New ClaseRegistroDeProductos(Codigo.Text, NombreDproducto.Text, Medida.SelectedValue, Marca.SelectedValue, PrecioDeVenta.Text, "existencia")
        If actualiza.consultaUnProductoUpdt() = True Then
            actualiza.actualizarProductos()
            actualiza.PoblarDataGridRegistroDeProductos(DGVRproductos)
            Codigo.Clear()
            NombreDproducto.Clear()
            PrecioDeVenta.Clear()
            cnx.Close()
        Else
            MsgBox("Este producto ya existe")
        End If

    End Sub
    Private Sub imprimirP_Click(sender As Object, e As EventArgs) Handles imprimirP.Click
        Try
            Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
            'Guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\refaccionaria\productos" & Replace(Labelfecha.Text, "/", "-") & ".pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF(doc)
            doc.Close()
            Process.Start(filename)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function

    Public Sub ExportarDatosPDF(ByVal document As Document)
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.
        Dim datatable As New PdfPTable(DGVRproductos.ColumnCount)
        'Se asignan las propiedades del .PDF
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(DGVRproductos)
        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT
        'Se crea el encabezado en el PDF.
        Dim encabezado As New Paragraph("Fecha: " & Labelfecha.Text & "", New Font(Font.Name = "Tahoma", 20, Font.Bold))
        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To DGVRproductos.ColumnCount - 1
            datatable.AddCell(DGVRproductos.Columns(i).HeaderText)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1  'Se generan las columnas del DataGridView.
        For i As Integer = 0 To DGVRproductos.RowCount - 2
            For j As Integer = 0 To DGVRproductos.ColumnCount - 1
                'If (j = 3) Then 'ubica la imagen en la columna 3 de datagridview
                'capturo la ruta de la imagen
                '   Dim RutaImage As String
                ' RutaImage = DGVNotas("ruta_imagen", i).Value
                ' 'Procedo a convertir la imagen de tipo itextsharp.text.image
                'Dim Img As Image = Image.GetInstance(RutaImage)
                ''agrego la imagen a la celda
                'datatable.AddCell(Img)
                'Else
                datatable.AddCell(DGVRproductos(j, i).Value.ToString())
                'End If
            Next
            datatable.CompleteRow()
        Next
        'Se agrega el PDFTable al documento.
        document.Add(encabezado)
        document.Add(datatable)
    End Sub
End Class