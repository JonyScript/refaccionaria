<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AnalisisDeVentas
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
        Me.Vendidos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.back = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Ganancias = New System.Windows.Forms.DataGridView()
        Me.cb_mes = New System.Windows.Forms.ComboBox()
        Me.cb_anio = New System.Windows.Forms.ComboBox()
        Me.Mes = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Vendidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ganancias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Vendidos
        '
        Me.Vendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Vendidos.Location = New System.Drawing.Point(36, 118)
        Me.Vendidos.Name = "Vendidos"
        Me.Vendidos.ReadOnly = True
        Me.Vendidos.Size = New System.Drawing.Size(554, 268)
        Me.Vendidos.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(191, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Productos vendidos del mes"
        '
        'back
        '
        Me.back.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.Location = New System.Drawing.Point(12, 2)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(27, 31)
        Me.back.TabIndex = 29
        Me.back.Text = "⮌"
        Me.back.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(662, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ganancias totales del mes"
        '
        'Ganancias
        '
        Me.Ganancias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Ganancias.Location = New System.Drawing.Point(666, 118)
        Me.Ganancias.Name = "Ganancias"
        Me.Ganancias.ReadOnly = True
        Me.Ganancias.Size = New System.Drawing.Size(193, 268)
        Me.Ganancias.TabIndex = 1
        '
        'cb_mes
        '
        Me.cb_mes.FormattingEnabled = True
        Me.cb_mes.Location = New System.Drawing.Point(277, 27)
        Me.cb_mes.Name = "cb_mes"
        Me.cb_mes.Size = New System.Drawing.Size(121, 21)
        Me.cb_mes.TabIndex = 30
        '
        'cb_anio
        '
        Me.cb_anio.FormattingEnabled = True
        Me.cb_anio.Location = New System.Drawing.Point(459, 27)
        Me.cb_anio.Name = "cb_anio"
        Me.cb_anio.Size = New System.Drawing.Size(121, 21)
        Me.cb_anio.TabIndex = 31
        '
        'Mes
        '
        Me.Mes.AutoSize = True
        Me.Mes.Location = New System.Drawing.Point(244, 30)
        Me.Mes.Name = "Mes"
        Me.Mes.Size = New System.Drawing.Size(27, 13)
        Me.Mes.TabIndex = 32
        Me.Mes.Text = "Mes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(417, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Año"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(614, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Ver "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AnalisisDeVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 410)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Mes)
        Me.Controls.Add(Me.cb_anio)
        Me.Controls.Add(Me.cb_mes)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Ganancias)
        Me.Controls.Add(Me.Vendidos)
        Me.Name = "AnalisisDeVentas"
        Me.Text = "AnalisisDeVentas"
        CType(Me.Vendidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ganancias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Vendidos As DataGridView
    'Friend WithEvents OracleCommandBuilder1 As Oracle.ManagedDataAccess.Client.OracleCommandBuilder
    Friend WithEvents Label1 As Label
    Friend WithEvents back As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Ganancias As DataGridView
    Friend WithEvents cb_mes As ComboBox
    Friend WithEvents cb_anio As ComboBox
    Friend WithEvents Mes As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
