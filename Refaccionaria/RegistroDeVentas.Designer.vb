<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroDeVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DGVVentas = New System.Windows.Forms.DataGridView()
        Me.DGVDetallada = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DGVVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVDetallada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVVentas
        '
        Me.DGVVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVVentas.Location = New System.Drawing.Point(16, 76)
        Me.DGVVentas.Name = "DGVVentas"
        Me.DGVVentas.Size = New System.Drawing.Size(896, 150)
        Me.DGVVentas.TabIndex = 0
        '
        'DGVDetallada
        '
        Me.DGVDetallada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDetallada.Location = New System.Drawing.Point(16, 296)
        Me.DGVDetallada.Name = "DGVDetallada"
        Me.DGVDetallada.Size = New System.Drawing.Size(896, 150)
        Me.DGVDetallada.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ventas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Detalle de la venta"
        '
        'RegistroDeVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 503)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVDetallada)
        Me.Controls.Add(Me.DGVVentas)
        Me.Name = "RegistroDeVentas"
        Me.Text = "RegistroDeVentas"
        CType(Me.DGVVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVDetallada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVVentas As DataGridView
    Friend WithEvents DGVDetallada As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
