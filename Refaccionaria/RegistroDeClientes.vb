Public Class RegistroDeClientes
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If puestoUsuario = 1 Then
            menuAdministrador.Show()
        ElseIf puestoUsuario = 2 Then
            menuVendedor.Show()
        End If
        Me.Close()
    End Sub

    Private Sub RegistroDeClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVClientes.ReadOnly = False


        Dim datagrid As New ClaseRegistroDeClientes()
        datagrid.PoblarDataGridRegistroDeClientes(DGVClientes)
        cnx.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If name_txt.Text = vbNullString Then
            MessageBox.Show("Capturar nombre")
        ElseIf pat_txt.Text = vbNullString Then
            MessageBox.Show("Capturar apellido paterno")
        ElseIf mat_txt.Text = vbNullString Then
            MessageBox.Show("Capturar apellido materno")
        ElseIf tel_txt.Text = vbNullString Then
            MessageBox.Show("Capturar telefono")
        Else
            Dim cliente As New ClaseRegistroDeClientes(name_txt.Text, pat_txt.Text, mat_txt.Text, tel_txt.Text, rfc_txt.Text, dir_txt.Text, mail_txt.Text)
            cliente.getSetnombreC = name_txt.Text
            cliente.getSetpaternoC = pat_txt.Text
            cliente.getSetmaternoC = mat_txt.Text
            cliente.getSettelefonoC = tel_txt.Text
            cliente.getSetRFC = rfc_txt.Text
            cliente.getSetdireccionC = dir_txt.Text
            cliente.getSetmailC = mail_txt.Text

            If cliente.consultaUnCliente() = False Then
                'Si el prodcuto no está registrado, la inserta como una nuevo
                cliente.insertarCliente()
                name_txt.Clear()
                mat_txt.Clear()
                pat_txt.Clear()
                tel_txt.Clear()
                rfc_txt.Clear()
                dir_txt.Clear()
                mail_txt.Clear()
            Else
                MessageBox.Show("El cliente ya existe, verifique los datos")
            End If
            cnx.Close()
        End If
        Dim datagrid As New ClaseRegistroDeClientes()
        datagrid.PoblarDataGridRegistroDeClientes(DGVClientes)
        cnx.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DGVClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVClientes.CellClick
        Dim renglon As Integer
        renglon = DGVClientes.CurrentCellAddress.Y
        name_txt.Text = DGVClientes.Rows(renglon).Cells(1).Value
        pat_txt.Text = DGVClientes.Rows(renglon).Cells(2).Value
        mat_txt.Text = DGVClientes.Rows(renglon).Cells(3).Value
        tel_txt.Text = DGVClientes.Rows(renglon).Cells(4).Value
        rfc_txt.Text = DGVClientes.Rows(renglon).Cells(5).Value
        dir_txt.Text = DGVClientes.Rows(renglon).Cells(6).Value
        mail_txt.Text = DGVClientes.Rows(renglon).Cells(7).Value
    End Sub

    Private Sub tel_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tel_txt.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo puede digitar numeros")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim actualiza As New ClaseRegistroDeClientes(name_txt.Text, pat_txt.Text, mat_txt.Text, tel_txt.Text, rfc_txt.Text, dir_txt.Text, mail_txt.Text)
        actualiza.actualizaCliente()
        actualiza.PoblarDataGridRegistroDeClientes(DGVClientes)
        cnx.Close()
    End Sub

    Private Sub DGVClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVClientes.CellContentClick

    End Sub
End Class