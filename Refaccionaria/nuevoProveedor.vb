Public Class nuevoProveedor
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If formPrev = "ventas" Then
            Ventas.Show()
        ElseIf puestoUsuario = 1 Then
            menuAdministrador.Show()
        ElseIf puestoUsuario = 2 Then
            menuVendedor.Show()
        End If
        Me.Close()
    End Sub

    Private Sub RegistroDeProvedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVProveedores.ReadOnly = False
        Dim datagrid As New ClaseRegistroDeProveedor()
        datagrid.PoblarDataGridRegistroDeProveedores(DGVProveedores)
        cnx.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If name_txt.Text = vbNullString Then
            MessageBox.Show("Capturar nombre")
        ElseIf tel_txt.Text = vbNullString Then
            MessageBox.Show("Capturar telefono")
        Else
            Dim cliente As New ClaseRegistroDeProveedor(name_txt.Text, tel_txt.Text, mail_txt.Text, dir_txt.Text)
            cliente.getSetnombreC = name_txt.Text
            cliente.getSettelefonoC = tel_txt.Text
            cliente.getSetmailC = mail_txt.Text
            cliente.getSetdireccionC = dir_txt.Text

            If cliente.consultaUnProveedor() = False Then
                'Si el prodcuto no está registrado, la inserta como una nuevo
                cliente.insertarProveedor()
                name_txt.Clear()
                tel_txt.Clear()
                mail_txt.Clear()
                dir_txt.Clear()
            Else
                MessageBox.Show("El proovedor ya existe, verifique los datos")
            End If
            cnx.Close()
        End If
        Dim datagrid As New ClaseRegistroDeProveedor()
        datagrid.PoblarDataGridRegistroDeProveedores(DGVProveedores)
        cnx.Close()
    End Sub

    Private Sub DGVClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVProveedores.CellClick
        Dim renglon As Integer
        renglon = DGVProveedores.CurrentCellAddress.Y
        telprev = DGVProveedores.Rows(renglon).Cells(2).Value
        name_txt.Text = DGVProveedores.Rows(renglon).Cells(1).Value
        tel_txt.Text = DGVProveedores.Rows(renglon).Cells(2).Value
        mail_txt.Text = DGVProveedores.Rows(renglon).Cells(3).Value
        dir_txt.Text = DGVProveedores.Rows(renglon).Cells(4).Value
    End Sub

    Private Sub tel_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tel_txt.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo puede digitar numeros")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim actualiza As New ClaseRegistroDeProveedor(name_txt.Text, telprev, mail_txt.Text, dir_txt.Text)
        actualiza.actualizaProveedor()
        actualiza.PoblarDataGridRegistroDeProveedores(DGVProveedores)
        cnx.Close()
        name_txt.Clear()
        tel_txt.Clear()
        dir_txt.Clear()
        mail_txt.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim cliente As New ClaseRegistroDeProveedor(name_txt.Text, tel_txt.Text, mail_txt.Text, dir_txt.Text)
            'Verificmos que el cliente se encuentre registrado
            If cliente.consultaUnProveedor() = False Then
                MsgBox("No se puede eliminar un proovedor, verifique ...")
            Else
                'Llamamos al método que elimina el registro
                cliente.eliminarProveedor()
                'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
                cliente.PoblarDataGridRegistroDeProveedores(DGVProveedores)
                'Cerramos la conexión a la BD
                cnx.Close()
                name_txt.Clear()
                tel_txt.Clear()
                dir_txt.Clear()
                mail_txt.Clear()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        name_txt.Clear()
        tel_txt.Clear()
        dir_txt.Clear()
        mail_txt.Clear()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        CompraDeProductos.Show()
        Me.Close()

    End Sub
End Class