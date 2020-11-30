<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CompraDeProductos
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
        Me.back = New System.Windows.Forms.Button()
        Me.btnnuevacompra = New System.Windows.Forms.Button()
        Me.dgvcompra = New System.Windows.Forms.DataGridView()
        Me.dgvexist2 = New System.Windows.Forms.DataGridView()
        Me.btnfactura = New System.Windows.Forms.Button()
        Me.btnnota = New System.Windows.Forms.Button()
        Me.btnconfirmar = New System.Windows.Forms.Button()
        Me.btnregistro = New System.Windows.Forms.Button()
        Me.btnremover = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txtnombrecom = New System.Windows.Forms.TextBox()
        Me.txtcodigocom = New System.Windows.Forms.TextBox()
        Me.txtnombreprod = New System.Windows.Forms.TextBox()
        Me.txtcodigoprod = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnproveedor = New System.Windows.Forms.Button()
        Me.cmbproovedor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PrecioCompra = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvcompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvexist2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'back
        '
        Me.back.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.Location = New System.Drawing.Point(12, 5)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(27, 31)
        Me.back.TabIndex = 55
        Me.back.Text = "⮌"
        Me.back.UseVisualStyleBackColor = True
        '
        'btnnuevacompra
        '
        Me.btnnuevacompra.Location = New System.Drawing.Point(1068, 521)
        Me.btnnuevacompra.Name = "btnnuevacompra"
        Me.btnnuevacompra.Size = New System.Drawing.Size(117, 23)
        Me.btnnuevacompra.TabIndex = 54
        Me.btnnuevacompra.Text = "Nueva compra"
        Me.btnnuevacompra.UseVisualStyleBackColor = True
        '
        'dgvcompra
        '
        Me.dgvcompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcompra.Location = New System.Drawing.Point(206, 350)
        Me.dgvcompra.Name = "dgvcompra"
        Me.dgvcompra.Size = New System.Drawing.Size(977, 150)
        Me.dgvcompra.TabIndex = 53
        '
        'dgvexist2
        '
        Me.dgvexist2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvexist2.Location = New System.Drawing.Point(206, 118)
        Me.dgvexist2.Name = "dgvexist2"
        Me.dgvexist2.Size = New System.Drawing.Size(977, 150)
        Me.dgvexist2.TabIndex = 52
        '
        'btnfactura
        '
        Me.btnfactura.Location = New System.Drawing.Point(1068, 608)
        Me.btnfactura.Name = "btnfactura"
        Me.btnfactura.Size = New System.Drawing.Size(117, 23)
        Me.btnfactura.TabIndex = 51
        Me.btnfactura.Text = "Generar factura"
        Me.btnfactura.UseVisualStyleBackColor = True
        '
        'btnnota
        '
        Me.btnnota.Location = New System.Drawing.Point(1068, 579)
        Me.btnnota.Name = "btnnota"
        Me.btnnota.Size = New System.Drawing.Size(117, 23)
        Me.btnnota.TabIndex = 50
        Me.btnnota.Text = "Generar nota"
        Me.btnnota.UseVisualStyleBackColor = True
        '
        'btnconfirmar
        '
        Me.btnconfirmar.Location = New System.Drawing.Point(1068, 550)
        Me.btnconfirmar.Name = "btnconfirmar"
        Me.btnconfirmar.Size = New System.Drawing.Size(117, 23)
        Me.btnconfirmar.TabIndex = 49
        Me.btnconfirmar.Text = "Confirmar compra"
        Me.btnconfirmar.UseVisualStyleBackColor = True
        '
        'btnregistro
        '
        Me.btnregistro.Location = New System.Drawing.Point(320, 553)
        Me.btnregistro.Name = "btnregistro"
        Me.btnregistro.Size = New System.Drawing.Size(126, 23)
        Me.btnregistro.TabIndex = 48
        Me.btnregistro.Text = "Ver registro de compras"
        Me.btnregistro.UseVisualStyleBackColor = True
        '
        'btnremover
        '
        Me.btnremover.Location = New System.Drawing.Point(151, 553)
        Me.btnremover.Name = "btnremover"
        Me.btnremover.Size = New System.Drawing.Size(126, 23)
        Me.btnremover.TabIndex = 47
        Me.btnremover.Text = "Remover producto"
        Me.btnremover.UseVisualStyleBackColor = True
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(1068, 302)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(113, 23)
        Me.btnagregar.TabIndex = 46
        Me.btnagregar.Text = "Agregar producto"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(849, 82)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar.TabIndex = 45
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'txttotal
        '
        Me.txttotal.Enabled = False
        Me.txttotal.Location = New System.Drawing.Point(868, 556)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(100, 20)
        Me.txttotal.TabIndex = 43
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(911, 309)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtcantidad.TabIndex = 42
        '
        'txtnombrecom
        '
        Me.txtnombrecom.Enabled = False
        Me.txtnombrecom.Location = New System.Drawing.Point(450, 309)
        Me.txtnombrecom.Name = "txtnombrecom"
        Me.txtnombrecom.Size = New System.Drawing.Size(196, 20)
        Me.txtnombrecom.TabIndex = 41
        '
        'txtcodigocom
        '
        Me.txtcodigocom.Enabled = False
        Me.txtcodigocom.Location = New System.Drawing.Point(264, 309)
        Me.txtcodigocom.Name = "txtcodigocom"
        Me.txtcodigocom.Size = New System.Drawing.Size(70, 20)
        Me.txtcodigocom.TabIndex = 40
        '
        'txtnombreprod
        '
        Me.txtnombreprod.Location = New System.Drawing.Point(550, 82)
        Me.txtnombreprod.Name = "txtnombreprod"
        Me.txtnombreprod.Size = New System.Drawing.Size(242, 20)
        Me.txtnombreprod.TabIndex = 39
        '
        'txtcodigoprod
        '
        Me.txtcodigoprod.Location = New System.Drawing.Point(320, 82)
        Me.txtcodigoprod.Name = "txtcodigoprod"
        Me.txtcodigoprod.Size = New System.Drawing.Size(100, 20)
        Me.txtcodigoprod.TabIndex = 38
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(107, 402)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 24)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Compra"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(73, 179)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 24)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Existencias"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(831, 563)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(856, 312)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Cantidad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(340, 312)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Nombre de producto"
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(1125, 72)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(39, 13)
        Me.lblfecha.TabIndex = 31
        Me.lblfecha.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(440, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Nombre de producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(274, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Código"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(218, 312)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Código"
        '
        'btnproveedor
        '
        Me.btnproveedor.Location = New System.Drawing.Point(541, 28)
        Me.btnproveedor.Name = "btnproveedor"
        Me.btnproveedor.Size = New System.Drawing.Size(116, 23)
        Me.btnproveedor.TabIndex = 58
        Me.btnproveedor.Text = "Nuevo proveedor"
        Me.btnproveedor.UseVisualStyleBackColor = True
        '
        'cmbproovedor
        '
        Me.cmbproovedor.FormattingEnabled = True
        Me.cmbproovedor.Location = New System.Drawing.Point(378, 28)
        Me.cmbproovedor.Name = "cmbproovedor"
        Me.cmbproovedor.Size = New System.Drawing.Size(121, 21)
        Me.cmbproovedor.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(317, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Proveedor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(663, 313)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Precio compra:"
        '
        'PrecioCompra
        '
        Me.PrecioCompra.Location = New System.Drawing.Point(744, 310)
        Me.PrecioCompra.Name = "PrecioCompra"
        Me.PrecioCompra.Size = New System.Drawing.Size(100, 20)
        Me.PrecioCompra.TabIndex = 62
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1189, 182)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 23)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "Nuevo producto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CompraDeProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1314, 651)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PrecioCompra)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbproovedor)
        Me.Controls.Add(Me.btnproveedor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.btnnuevacompra)
        Me.Controls.Add(Me.dgvcompra)
        Me.Controls.Add(Me.dgvexist2)
        Me.Controls.Add(Me.btnfactura)
        Me.Controls.Add(Me.btnnota)
        Me.Controls.Add(Me.btnconfirmar)
        Me.Controls.Add(Me.btnregistro)
        Me.Controls.Add(Me.btnremover)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.txtnombrecom)
        Me.Controls.Add(Me.txtcodigocom)
        Me.Controls.Add(Me.txtnombreprod)
        Me.Controls.Add(Me.txtcodigoprod)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.Label3)
        Me.Name = "CompraDeProductos"
        Me.Text = "CompraDeProductos"
        CType(Me.dgvcompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvexist2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents back As Button
    Friend WithEvents btnnuevacompra As Button
    Friend WithEvents dgvcompra As DataGridView
    Friend WithEvents dgvexist2 As DataGridView
    Friend WithEvents btnfactura As Button
    Friend WithEvents btnnota As Button
    Friend WithEvents btnconfirmar As Button
    Friend WithEvents btnregistro As Button
    Friend WithEvents btnremover As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents btnbuscar As Button
    Friend WithEvents txttotal As TextBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents txtnombrecom As TextBox
    Friend WithEvents txtcodigocom As TextBox
    Friend WithEvents txtnombreprod As TextBox
    Friend WithEvents txtcodigoprod As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblfecha As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnproveedor As Button
    Friend WithEvents cmbproovedor As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PrecioCompra As TextBox
    Friend WithEvents Button1 As Button
End Class
