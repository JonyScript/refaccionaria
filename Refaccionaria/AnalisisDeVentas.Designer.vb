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
        Me.masvendidos = New System.Windows.Forms.DataGridView()
        Me.menosvendidos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.back = New System.Windows.Forms.Button()
        CType(Me.masvendidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.menosvendidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'masvendidos
        '
        Me.masvendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.masvendidos.Location = New System.Drawing.Point(12, 39)
        Me.masvendidos.Name = "masvendidos"
        Me.masvendidos.Size = New System.Drawing.Size(541, 210)
        Me.masvendidos.TabIndex = 0
        '
        'menosvendidos
        '
        Me.menosvendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.menosvendidos.Location = New System.Drawing.Point(12, 285)
        Me.menosvendidos.Name = "menosvendidos"
        Me.menosvendidos.Size = New System.Drawing.Size(541, 202)
        Me.menosvendidos.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(201, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Productos más vendidos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(192, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Productos menos vendidos"
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
        'AnalisisDeVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 499)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.menosvendidos)
        Me.Controls.Add(Me.masvendidos)
        Me.Name = "AnalisisDeVentas"
        Me.Text = "AnalisisDeVentas"
        CType(Me.masvendidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.menosvendidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents masvendidos As DataGridView
    Friend WithEvents menosvendidos As DataGridView
    'Friend WithEvents OracleCommandBuilder1 As Oracle.ManagedDataAccess.Client.OracleCommandBuilder
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents back As Button
End Class
