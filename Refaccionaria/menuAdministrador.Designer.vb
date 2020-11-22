<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuAdministrador
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
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnRegistroDeClientes = New System.Windows.Forms.Button()
        Me.btnRegistroDeProductos = New System.Windows.Forms.Button()
        Me.btnRegistroDeUsuarios = New System.Windows.Forms.Button()
        Me.btnCompraDeProductos = New System.Windows.Forms.Button()
        Me.btnAnalisisDeVentas = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        'Me.OracleCommand1 = New Oracle.ManagedDataAccess.Client.OracleCommand()
        Me.SuspendLayout()
        '
        'btnVentas
        '
        Me.btnVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.Location = New System.Drawing.Point(144, 167)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(176, 71)
        Me.btnVentas.TabIndex = 0
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.UseVisualStyleBackColor = True
        '
        'btnRegistroDeClientes
        '
        Me.btnRegistroDeClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistroDeClientes.Location = New System.Drawing.Point(144, 255)
        Me.btnRegistroDeClientes.Name = "btnRegistroDeClientes"
        Me.btnRegistroDeClientes.Size = New System.Drawing.Size(176, 71)
        Me.btnRegistroDeClientes.TabIndex = 1
        Me.btnRegistroDeClientes.Text = "Registro de clientes"
        Me.btnRegistroDeClientes.UseVisualStyleBackColor = True
        '
        'btnRegistroDeProductos
        '
        Me.btnRegistroDeProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistroDeProductos.Location = New System.Drawing.Point(144, 343)
        Me.btnRegistroDeProductos.Name = "btnRegistroDeProductos"
        Me.btnRegistroDeProductos.Size = New System.Drawing.Size(176, 71)
        Me.btnRegistroDeProductos.TabIndex = 2
        Me.btnRegistroDeProductos.Text = "Registro de productos"
        Me.btnRegistroDeProductos.UseVisualStyleBackColor = True
        '
        'btnRegistroDeUsuarios
        '
        Me.btnRegistroDeUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistroDeUsuarios.Location = New System.Drawing.Point(460, 167)
        Me.btnRegistroDeUsuarios.Name = "btnRegistroDeUsuarios"
        Me.btnRegistroDeUsuarios.Size = New System.Drawing.Size(176, 71)
        Me.btnRegistroDeUsuarios.TabIndex = 3
        Me.btnRegistroDeUsuarios.Text = "Registro de usuarios"
        Me.btnRegistroDeUsuarios.UseVisualStyleBackColor = True
        '
        'btnCompraDeProductos
        '
        Me.btnCompraDeProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompraDeProductos.Location = New System.Drawing.Point(460, 255)
        Me.btnCompraDeProductos.Name = "btnCompraDeProductos"
        Me.btnCompraDeProductos.Size = New System.Drawing.Size(177, 71)
        Me.btnCompraDeProductos.TabIndex = 4
        Me.btnCompraDeProductos.Text = "Compra de productos"
        Me.btnCompraDeProductos.UseVisualStyleBackColor = True
        '
        'btnAnalisisDeVentas
        '
        Me.btnAnalisisDeVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnalisisDeVentas.Location = New System.Drawing.Point(460, 343)
        Me.btnAnalisisDeVentas.Name = "btnAnalisisDeVentas"
        Me.btnAnalisisDeVentas.Size = New System.Drawing.Size(176, 71)
        Me.btnAnalisisDeVentas.TabIndex = 5
        Me.btnAnalisisDeVentas.Text = "Análisis de ventas"
        Me.btnAnalisisDeVentas.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(257, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 31)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "¿Que desea realizar?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(305, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 31)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "¡Bienvenido!"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(12, 19)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(57, 20)
        Me.lblFecha.TabIndex = 16
        Me.lblFecha.Text = "Label3"
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(700, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Cerrar sesion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OracleCommand1
        '
        ' Me.OracleCommand1.Transaction = Nothing
        '
        'menuAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 486)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAnalisisDeVentas)
        Me.Controls.Add(Me.btnCompraDeProductos)
        Me.Controls.Add(Me.btnRegistroDeUsuarios)
        Me.Controls.Add(Me.btnRegistroDeProductos)
        Me.Controls.Add(Me.btnRegistroDeClientes)
        Me.Controls.Add(Me.btnVentas)
        Me.Name = "menuAdministrador"
        Me.Text = "Menú"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVentas As Button
    Friend WithEvents btnRegistroDeClientes As Button
    Friend WithEvents btnRegistroDeProductos As Button
    Friend WithEvents btnRegistroDeUsuarios As Button
    Friend WithEvents btnCompraDeProductos As Button
    Friend WithEvents btnAnalisisDeVentas As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents Button1 As Button
    ' Private WithEvents OracleCommand1 As Oracle.ManagedDataAccess.Client.OracleCommand
End Class
