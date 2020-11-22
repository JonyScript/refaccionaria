Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class Notas
    Private Sub Notas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nota As New ClaseNotas()
        nota.PoblarDataGridNotas(DGVNotas)
        txtcdgventa.Text = codigoVenta
        txtfecha.Text = nota.getFecha()
        txtcliente.Text = nota.getCliente()
        txtvendedor.Text = nombreUsuarioConectado
        txttotal.Text = nota.getTotal()
        cnx.Close()
    End Sub

    Private Sub print_Click(sender As Object, e As EventArgs) Handles print.Click
        'PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        'PrintForm1.Print()

        Try
            Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
            'Guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\notas\venta" & txtcdgventa.Text & ".pdf"
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
        Dim datatable As New PdfPTable(DGVNotas.ColumnCount)
        'Se asignan las propiedades del .PDF
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(DGVNotas)
        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT
        'Se crea el encabezado en el PDF.
        Dim encabezado As New Paragraph("VENTA NUMERO " & txtcdgventa.Text & "", New Font(Font.Name = "Tahoma", 20, Font.Bold))
        Dim vendedor As New Paragraph("Atendido por: " & txtvendedor.Text & "", New Font(Font.Name = "Tahoma", 14, Font.Bold))
        Dim fecha As New Paragraph("Fecha: " & txtfecha.Text & "", New Font(Font.Name = "Tahoma", 14, Font.Bold))
        Dim cliente As New Paragraph("Cliente: " & txtcliente.Text & "", New Font(Font.Name = "Tahoma", 14, Font.Bold))
        Dim total As New Paragraph("Total: " & txttotal.Text & "", New Font(Font.Name = "Tahoma", 14, Font.Bold))
        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To DGVNotas.ColumnCount - 1
            datatable.AddCell(DGVNotas.Columns(i).HeaderText)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1  'Se generan las columnas del DataGridView.
        For i As Integer = 0 To DGVNotas.RowCount - 2
            For j As Integer = 0 To DGVNotas.ColumnCount - 1
                'If (j = 3) Then 'ubica la imagen en la columna 3 de datagridview
                'capturo la ruta de la imagen
                '   Dim RutaImage As String
                ' RutaImage = DGVNotas("ruta_imagen", i).Value
                ' 'Procedo a convertir la imagen de tipo itextsharp.text.image
                'Dim Img As Image = Image.GetInstance(RutaImage)
                ''agrego la imagen a la celda
                'datatable.AddCell(Img)
                'Else
                datatable.AddCell(DGVNotas(j, i).Value.ToString())
                'End If
            Next
            datatable.CompleteRow()
        Next
        'Se agrega el PDFTable al documento.
        document.Add(encabezado)
        document.Add(fecha)
        document.Add(cliente)
        document.Add(vendedor)
        document.Add(datatable)
        document.Add(total)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Ventas.Show()
        Me.Close()
    End Sub
End Class