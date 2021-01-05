<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Medidas
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
        Me.btnmedidas = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.medidatxt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnmedidas
        '
        Me.btnmedidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmedidas.Location = New System.Drawing.Point(12, 12)
        Me.btnmedidas.Name = "btnmedidas"
        Me.btnmedidas.Size = New System.Drawing.Size(40, 29)
        Me.btnmedidas.TabIndex = 0
        Me.btnmedidas.Text = "⮌"
        Me.btnmedidas.UseVisualStyleBackColor = True
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(161, 90)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.btnagregar.TabIndex = 1
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Unidad de la medida:"
        '
        'medidatxt
        '
        Me.medidatxt.Location = New System.Drawing.Point(161, 53)
        Me.medidatxt.MaxLength = 30
        Me.medidatxt.Name = "medidatxt"
        Me.medidatxt.Size = New System.Drawing.Size(198, 20)
        Me.medidatxt.TabIndex = 3
        '
        'Medidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 144)
        Me.Controls.Add(Me.medidatxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.btnmedidas)
        Me.Name = "Medidas"
        Me.Text = "Medidas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnmedidas As Button
    Friend WithEvents btnagregar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents medidatxt As TextBox
End Class
