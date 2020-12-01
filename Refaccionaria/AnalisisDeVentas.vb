Public Class AnalisisDeVentas
    Private Sub AnalisisDeVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim datagridext As New ClaseAnalisisDeVentas()
        datagridext.PoblarDataGridMAS(masvendidos)
        datagridext.PoblarDataGridMENOS(menosvendidos)
        cnx.Close()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles back.Click
        If puestoUsuario = 1 Then
            menuAdministrador.Show()
        ElseIf puestoUsuario = 2 Then
            menuVendedor.Show()
        End If
        Me.Close()
    End Sub
End Class