<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registroDeProductos
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
        Me.DGVRproductos = New System.Windows.Forms.DataGridView()
        Me.AgregarProductos = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Medida = New System.Windows.Forms.ComboBox()
        Me.NombreDproducto = New System.Windows.Forms.TextBox()
        Me.PrecioDeVenta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Codigo = New System.Windows.Forms.TextBox()
        CType(Me.DGVRproductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVRproductos
        '
        Me.DGVRproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRproductos.Location = New System.Drawing.Point(89, 86)
        Me.DGVRproductos.Name = "DGVRproductos"
        Me.DGVRproductos.Size = New System.Drawing.Size(882, 188)
        Me.DGVRproductos.TabIndex = 0
        '
        'AgregarProductos
        '
        Me.AgregarProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgregarProductos.Location = New System.Drawing.Point(477, 398)
        Me.AgregarProductos.Name = "AgregarProductos"
        Me.AgregarProductos.Size = New System.Drawing.Size(105, 45)
        Me.AgregarProductos.TabIndex = 6
        Me.AgregarProductos.Text = "Agregar Productos"
        Me.AgregarProductos.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(239, 398)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 45)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Eliminar producto"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(979, 164)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 45)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Generar PDF"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(758, 398)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 45)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Modificar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(979, 518)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(95, 43)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "Comprar productos"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(415, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(247, 29)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Registro de productos"
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(12, 9)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(36, 29)
        Me.Button7.TabIndex = 12
        Me.Button7.Text = "⮌"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(196, 322)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Nombre del producto:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(489, 323)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Medida:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(705, 326)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Precio de venta:"
        '
        'Medida
        '
        Me.Medida.FormattingEnabled = True
        Me.Medida.Location = New System.Drawing.Point(560, 324)
        Me.Medida.Name = "Medida"
        Me.Medida.Size = New System.Drawing.Size(121, 21)
        Me.Medida.TabIndex = 16
        '
        'NombreDproducto
        '
        Me.NombreDproducto.Location = New System.Drawing.Point(363, 324)
        Me.NombreDproducto.Name = "NombreDproducto"
        Me.NombreDproducto.Size = New System.Drawing.Size(100, 20)
        Me.NombreDproducto.TabIndex = 17
        '
        'PrecioDeVenta
        '
        Me.PrecioDeVenta.Location = New System.Drawing.Point(829, 326)
        Me.PrecioDeVenta.Name = "PrecioDeVenta"
        Me.PrecioDeVenta.Size = New System.Drawing.Size(162, 20)
        Me.PrecioDeVenta.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 322)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Codigo:"
        '
        'Codigo
        '
        Me.Codigo.Location = New System.Drawing.Point(132, 324)
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Size = New System.Drawing.Size(58, 20)
        Me.Codigo.TabIndex = 20
        '
        'registroDeProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 573)
        Me.Controls.Add(Me.Codigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PrecioDeVenta)
        Me.Controls.Add(Me.NombreDproducto)
        Me.Controls.Add(Me.Medida)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.AgregarProductos)
        Me.Controls.Add(Me.DGVRproductos)
        Me.Name = "registroDeProductos"
        Me.Text = "Registro de productos"
        CType(Me.DGVRproductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVRproductos As DataGridView
    Friend WithEvents AgregarProductos As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Medida As ComboBox
    Friend WithEvents NombreDproducto As TextBox
    Friend WithEvents PrecioDeVenta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Codigo As TextBox
End Class
