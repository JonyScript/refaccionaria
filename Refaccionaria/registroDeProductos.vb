Public Class registroDeProductos
    Private Sub registroDeProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVRproductos.ReadOnly = False

        llenarCombo(Medida, "Select codigoMedida, descripcion from medida", "codigoMedida", "descripcion")
        codigoMedida = Medida.SelectedValue

        Dim datagrid As New ClaseRegistroDeproductos()
        datagrid.PoblarDataGridRegistroDeProductos(DGVRproductos)
        cnx.Close()
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
    Private Sub AgregarProductos_Click(sender As Object, e As EventArgs) Handles AgregarProductos.Click
        If Codigo.Text = vbNullString Then
            MessageBox.Show("Capturar el codigo")
        ElseIf NombreDproducto.Text = vbNullString Then
            MessageBox.Show("Capturar nombre")
        ElseIf PrecioDeVenta.Text = vbNullString Then
            MessageBox.Show("Captura precio de venta")
        Else
            Dim user As New ClaseRegistroDeProductos(Codigo.Text, Medida.SelectedValue, NombreDproducto.Text, PrecioDeVenta.Text, "existencia")
            user.getSetCproducto = Codigo.Text
            user.getSetCmedida = Medida.Text
            user.getSetNproducto = NombreDproducto.Text
            user.getSetPrecio = PrecioDeVenta.Text

            If user.consultaUnProducto() = False Then
                'Si el prodcuto no está registrado, la inserta como una nuevo
                user.insertarProducto()
                Codigo.Clear()
                NombreDproducto.Clear()
                PrecioDeVenta.Clear()
            Else
                MessageBox.Show("El id del producto ya existe")
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
        Medida.Text = DGVRproductos.Rows(renglon).Cells(1).Value
        NombreDproducto.Text = DGVRproductos.Rows(renglon).Cells(2).Value
        PrecioDeVenta.Text = DGVRproductos.Rows(renglon).Cells(3).Value
    End Sub

    Private Sub EliminarP_Click(sender As Object, e As EventArgs) Handles EliminarP.Click
        If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim user As New ClaseRegistroDeProductos(Codigo.Text, Medida.SelectedValue, NombreDproducto.Text, PrecioDeVenta.Text, "existencia")
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
        menuAdministrador.Show()
        Me.Close()
    End Sub
    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles limpiarP.Click
        Codigo.Clear()
        NombreDproducto.Clear()
        PrecioDeVenta.Clear()
    End Sub
    Private Sub ModificarP_Click(sender As Object, e As EventArgs) Handles ModificarP.Click
        Dim actualiza As New ClaseRegistroDeProductos(Codigo.Text, Medida.SelectedValue, NombreDproducto.Text, PrecioDeVenta.Text, "existencia")
        actualiza.actualizarProductos()
        actualiza.PoblarDataGridRegistroDeProductos(DGVRproductos)
        Codigo.Clear()
        NombreDproducto.Clear()
        PrecioDeVenta.Clear()
        cnx.Close()
    End Sub
End Class