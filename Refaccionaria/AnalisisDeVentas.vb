Public Class AnalisisDeVentas
    Private Sub AnalisisDeVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        llenarCombo(cb_mes, "Select codigomes, descripcion from mes", "codigomes", "descripcion")

        llenarCombo(cb_anio, "Select codigoanio from anio", "codigoanio", "codigoanio")


    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles back.Click
        If puestoUsuario = 1 Then
            menuAdministrador.Show()
        ElseIf puestoUsuario = 2 Then
            menuVendedor.Show()
        End If
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim datagridext As New ClaseAnalisisDeVentas()
        datagridext.PoblarDataGridVendidos(Vendidos)
        datagridext.PoblarDataGridGanancias(Ganancias)
        cnx.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class