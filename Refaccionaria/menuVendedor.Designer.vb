<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class menuVendedor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnAnalisisDeVentas2 = New System.Windows.Forms.Button()
        Me.btnCompraDeProductos2 = New System.Windows.Forms.Button()
        Me.btnRegistroDeClientes2 = New System.Windows.Forms.Button()
        Me.btnVentas2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblfecha2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAnalisisDeVentas2
        '
        Me.btnAnalisisDeVentas2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnalisisDeVentas2.Location = New System.Drawing.Point(172, 342)
        Me.btnAnalisisDeVentas2.Name = "btnAnalisisDeVentas2"
        Me.btnAnalisisDeVentas2.Size = New System.Drawing.Size(189, 44)
        Me.btnAnalisisDeVentas2.TabIndex = 11
        Me.btnAnalisisDeVentas2.Text = "Análisis de ventas"
        Me.btnAnalisisDeVentas2.UseVisualStyleBackColor = True
        '
        'btnCompraDeProductos2
        '
        Me.btnCompraDeProductos2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompraDeProductos2.Location = New System.Drawing.Point(172, 287)
        Me.btnCompraDeProductos2.Name = "btnCompraDeProductos2"
        Me.btnCompraDeProductos2.Size = New System.Drawing.Size(189, 42)
        Me.btnCompraDeProductos2.TabIndex = 10
        Me.btnCompraDeProductos2.Text = "Compra de productos"
        Me.btnCompraDeProductos2.UseVisualStyleBackColor = True
        '
        'btnRegistroDeClientes2
        '
        Me.btnRegistroDeClientes2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistroDeClientes2.Location = New System.Drawing.Point(172, 228)
        Me.btnRegistroDeClientes2.Name = "btnRegistroDeClientes2"
        Me.btnRegistroDeClientes2.Size = New System.Drawing.Size(189, 44)
        Me.btnRegistroDeClientes2.TabIndex = 7
        Me.btnRegistroDeClientes2.Text = "Registro de clientes"
        Me.btnRegistroDeClientes2.UseVisualStyleBackColor = True
        '
        'btnVentas2
        '
        Me.btnVentas2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas2.Location = New System.Drawing.Point(172, 173)
        Me.btnVentas2.Name = "btnVentas2"
        Me.btnVentas2.Size = New System.Drawing.Size(189, 40)
        Me.btnVentas2.TabIndex = 6
        Me.btnVentas2.Text = "Ventas"
        Me.btnVentas2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(187, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 31)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "¡Bienvenido!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(142, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 31)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "¿Que desea realizar?"
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(425, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Cerrar sesion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblfecha2
        '
        Me.lblfecha2.AutoSize = True
        Me.lblfecha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha2.Location = New System.Drawing.Point(23, 15)
        Me.lblfecha2.Name = "lblfecha2"
        Me.lblfecha2.Size = New System.Drawing.Size(57, 20)
        Me.lblfecha2.TabIndex = 15
        Me.lblfecha2.Text = "Label3"
        '
        'menuVendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 467)
        Me.Controls.Add(Me.lblfecha2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAnalisisDeVentas2)
        Me.Controls.Add(Me.btnCompraDeProductos2)
        Me.Controls.Add(Me.btnRegistroDeClientes2)
        Me.Controls.Add(Me.btnVentas2)
        Me.Name = "menuVendedor"
        Me.Text = "Menú"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAnalisisDeVentas2 As Button
    Friend WithEvents btnCompraDeProductos2 As Button
    Friend WithEvents btnRegistroDeClientes2 As Button
    Friend WithEvents btnVentas2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblfecha2 As Label
End Class
