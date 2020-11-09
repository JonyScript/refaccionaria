<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbcliente = New System.Windows.Forms.ComboBox()
        Me.txtcodigoprod = New System.Windows.Forms.TextBox()
        Me.txtnombreprod = New System.Windows.Forms.TextBox()
        Me.txtcodigoven = New System.Windows.Forms.TextBox()
        Me.txtnombreven = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.btncliente = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btnremover = New System.Windows.Forms.Button()
        Me.btnregistro = New System.Windows.Forms.Button()
        Me.btnconfirmar = New System.Windows.Forms.Button()
        Me.btnnota = New System.Windows.Forms.Button()
        Me.btnfactura = New System.Windows.Forms.Button()
        Me.dgvexist = New System.Windows.Forms.DataGridView()
        Me.dgvventa = New System.Windows.Forms.DataGridView()
        Me.btnnuevaventa = New System.Windows.Forms.Button()
        CType(Me.dgvexist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvventa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(273, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(242, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Código"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(408, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre de producto"
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(1089, 29)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(39, 13)
        Me.lblfecha.TabIndex = 3
        Me.lblfecha.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(149, 314)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Código"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(301, 314)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nombre de producto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(629, 314)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Cantidad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(786, 578)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(41, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 24)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Existencias"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(41, 332)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 24)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Venta"
        '
        'cmbcliente
        '
        Me.cmbcliente.FormattingEnabled = True
        Me.cmbcliente.Location = New System.Drawing.Point(318, 29)
        Me.cmbcliente.Name = "cmbcliente"
        Me.cmbcliente.Size = New System.Drawing.Size(121, 21)
        Me.cmbcliente.TabIndex = 10
        '
        'txtcodigoprod
        '
        Me.txtcodigoprod.Location = New System.Drawing.Point(288, 88)
        Me.txtcodigoprod.Name = "txtcodigoprod"
        Me.txtcodigoprod.Size = New System.Drawing.Size(100, 20)
        Me.txtcodigoprod.TabIndex = 11
        '
        'txtnombreprod
        '
        Me.txtnombreprod.Location = New System.Drawing.Point(518, 88)
        Me.txtnombreprod.Name = "txtnombreprod"
        Me.txtnombreprod.Size = New System.Drawing.Size(242, 20)
        Me.txtnombreprod.TabIndex = 12
        '
        'txtcodigoven
        '
        Me.txtcodigoven.Location = New System.Drawing.Point(195, 305)
        Me.txtcodigoven.Name = "txtcodigoven"
        Me.txtcodigoven.Size = New System.Drawing.Size(70, 20)
        Me.txtcodigoven.TabIndex = 13
        '
        'txtnombreven
        '
        Me.txtnombreven.Location = New System.Drawing.Point(411, 305)
        Me.txtnombreven.Name = "txtnombreven"
        Me.txtnombreven.Size = New System.Drawing.Size(196, 20)
        Me.txtnombreven.TabIndex = 14
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(684, 305)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtcantidad.TabIndex = 15
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(823, 571)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(100, 20)
        Me.txttotal.TabIndex = 16
        '
        'btncliente
        '
        Me.btncliente.Location = New System.Drawing.Point(532, 32)
        Me.btncliente.Name = "btncliente"
        Me.btncliente.Size = New System.Drawing.Size(116, 23)
        Me.btncliente.TabIndex = 17
        Me.btncliente.Text = "Nuevo cliente"
        Me.btncliente.UseVisualStyleBackColor = True
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(817, 88)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar.TabIndex = 18
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(810, 303)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(113, 23)
        Me.btnagregar.TabIndex = 19
        Me.btnagregar.Text = "Agregar producto"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'btnremover
        '
        Me.btnremover.Location = New System.Drawing.Point(119, 559)
        Me.btnremover.Name = "btnremover"
        Me.btnremover.Size = New System.Drawing.Size(126, 23)
        Me.btnremover.TabIndex = 20
        Me.btnremover.Text = "Remover producto"
        Me.btnremover.UseVisualStyleBackColor = True
        '
        'btnregistro
        '
        Me.btnregistro.Location = New System.Drawing.Point(288, 559)
        Me.btnregistro.Name = "btnregistro"
        Me.btnregistro.Size = New System.Drawing.Size(126, 23)
        Me.btnregistro.TabIndex = 21
        Me.btnregistro.Text = "Ver registro de ventas"
        Me.btnregistro.UseVisualStyleBackColor = True
        '
        'btnconfirmar
        '
        Me.btnconfirmar.Location = New System.Drawing.Point(1034, 515)
        Me.btnconfirmar.Name = "btnconfirmar"
        Me.btnconfirmar.Size = New System.Drawing.Size(117, 23)
        Me.btnconfirmar.TabIndex = 22
        Me.btnconfirmar.Text = "Confirmar venta"
        Me.btnconfirmar.UseVisualStyleBackColor = True
        '
        'btnnota
        '
        Me.btnnota.Location = New System.Drawing.Point(1034, 543)
        Me.btnnota.Name = "btnnota"
        Me.btnnota.Size = New System.Drawing.Size(117, 23)
        Me.btnnota.TabIndex = 23
        Me.btnnota.Text = "Generar nota"
        Me.btnnota.UseVisualStyleBackColor = True
        '
        'btnfactura
        '
        Me.btnfactura.Location = New System.Drawing.Point(1034, 573)
        Me.btnfactura.Name = "btnfactura"
        Me.btnfactura.Size = New System.Drawing.Size(117, 23)
        Me.btnfactura.TabIndex = 24
        Me.btnfactura.Text = "Generar factura"
        Me.btnfactura.UseVisualStyleBackColor = True
        '
        'dgvexist
        '
        Me.dgvexist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvexist.Location = New System.Drawing.Point(174, 124)
        Me.dgvexist.Name = "dgvexist"
        Me.dgvexist.Size = New System.Drawing.Size(749, 150)
        Me.dgvexist.TabIndex = 25
        '
        'dgvventa
        '
        Me.dgvventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvventa.Location = New System.Drawing.Point(174, 356)
        Me.dgvventa.Name = "dgvventa"
        Me.dgvventa.Size = New System.Drawing.Size(749, 150)
        Me.dgvventa.TabIndex = 26
        '
        'btnnuevaventa
        '
        Me.btnnuevaventa.Location = New System.Drawing.Point(950, 421)
        Me.btnnuevaventa.Name = "btnnuevaventa"
        Me.btnnuevaventa.Size = New System.Drawing.Size(92, 23)
        Me.btnnuevaventa.TabIndex = 27
        Me.btnnuevaventa.Text = "Nueva venta"
        Me.btnnuevaventa.UseVisualStyleBackColor = True
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1242, 644)
        Me.Controls.Add(Me.btnnuevaventa)
        Me.Controls.Add(Me.dgvventa)
        Me.Controls.Add(Me.dgvexist)
        Me.Controls.Add(Me.btnfactura)
        Me.Controls.Add(Me.btnnota)
        Me.Controls.Add(Me.btnconfirmar)
        Me.Controls.Add(Me.btnregistro)
        Me.Controls.Add(Me.btnremover)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.btncliente)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.txtnombreven)
        Me.Controls.Add(Me.txtcodigoven)
        Me.Controls.Add(Me.txtnombreprod)
        Me.Controls.Add(Me.txtcodigoprod)
        Me.Controls.Add(Me.cmbcliente)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Ventas"
        Me.Text = "Ventas"
        CType(Me.dgvexist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvventa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblfecha As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbcliente As ComboBox
    Friend WithEvents txtcodigoprod As TextBox
    Friend WithEvents txtnombreprod As TextBox
    Friend WithEvents txtcodigoven As TextBox
    Friend WithEvents txtnombreven As TextBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents btncliente As Button
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents btnremover As Button
    Friend WithEvents btnregistro As Button
    Friend WithEvents btnconfirmar As Button
    Friend WithEvents btnnota As Button
    Friend WithEvents btnfactura As Button
    Friend WithEvents dgvexist As DataGridView
    Friend WithEvents dgvventa As DataGridView
    Friend WithEvents btnnuevaventa As Button
End Class
