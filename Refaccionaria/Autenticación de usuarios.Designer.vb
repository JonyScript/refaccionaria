<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Autenticación_de_usuarios
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreDeUsuario = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.btnIniciarSesion = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Refaccionaria.My.Resources.Resources.inicio
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(254, 255)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(315, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre de usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(315, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contraseña"
        '
        'txtNombreDeUsuario
        '
        Me.txtNombreDeUsuario.Location = New System.Drawing.Point(318, 80)
        Me.txtNombreDeUsuario.Name = "txtNombreDeUsuario"
        Me.txtNombreDeUsuario.Size = New System.Drawing.Size(150, 20)
        Me.txtNombreDeUsuario.TabIndex = 3
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(318, 131)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(150, 20)
        Me.txtContraseña.TabIndex = 4
        '
        'btnIniciarSesion
        '
        Me.btnIniciarSesion.Location = New System.Drawing.Point(342, 174)
        Me.btnIniciarSesion.Name = "btnIniciarSesion"
        Me.btnIniciarSesion.Size = New System.Drawing.Size(105, 23)
        Me.btnIniciarSesion.TabIndex = 5
        Me.btnIniciarSesion.Text = "Iniciar sesión"
        Me.btnIniciarSesion.UseVisualStyleBackColor = True
        '
        'Autenticación_de_usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 284)
        Me.Controls.Add(Me.btnIniciarSesion)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtNombreDeUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Autenticación_de_usuarios"
        Me.Text = "Autenticación_de_usuarios"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreDeUsuario As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents btnIniciarSesion As Button
End Class
