﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_de_usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro_de_usuarios))
        Me.username_txt = New System.Windows.Forms.TextBox()
        Me.nombre_txt = New System.Windows.Forms.TextBox()
        Me.ap_txt = New System.Windows.Forms.TextBox()
        Me.am_txt = New System.Windows.Forms.TextBox()
        Me.pass_txt = New System.Windows.Forms.TextBox()
        Me.pass2_txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbx_rol = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DGVUsuarios = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'username_txt
        '
        Me.username_txt.Location = New System.Drawing.Point(132, 24)
        Me.username_txt.Name = "username_txt"
        Me.username_txt.Size = New System.Drawing.Size(175, 20)
        Me.username_txt.TabIndex = 0
        '
        'nombre_txt
        '
        Me.nombre_txt.Location = New System.Drawing.Point(132, 77)
        Me.nombre_txt.Name = "nombre_txt"
        Me.nombre_txt.Size = New System.Drawing.Size(175, 20)
        Me.nombre_txt.TabIndex = 1
        '
        'ap_txt
        '
        Me.ap_txt.Location = New System.Drawing.Point(132, 110)
        Me.ap_txt.Name = "ap_txt"
        Me.ap_txt.Size = New System.Drawing.Size(175, 20)
        Me.ap_txt.TabIndex = 2
        '
        'am_txt
        '
        Me.am_txt.Location = New System.Drawing.Point(132, 140)
        Me.am_txt.Name = "am_txt"
        Me.am_txt.Size = New System.Drawing.Size(175, 20)
        Me.am_txt.TabIndex = 3
        '
        'pass_txt
        '
        Me.pass_txt.Location = New System.Drawing.Point(132, 172)
        Me.pass_txt.Name = "pass_txt"
        Me.pass_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pass_txt.Size = New System.Drawing.Size(175, 20)
        Me.pass_txt.TabIndex = 4
        '
        'pass2_txt
        '
        Me.pass2_txt.Location = New System.Drawing.Point(132, 205)
        Me.pass2_txt.Name = "pass2_txt"
        Me.pass2_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pass2_txt.Size = New System.Drawing.Size(175, 20)
        Me.pass2_txt.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nombre de usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Apellido materno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Nombre(s)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Apellido paterno"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(65, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Contraseña"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Confirmar contraseña"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(103, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Rol"
        '
        'cbx_rol
        '
        Me.cbx_rol.FormattingEnabled = True
        Me.cbx_rol.Location = New System.Drawing.Point(132, 50)
        Me.cbx_rol.Name = "cbx_rol"
        Me.cbx_rol.Size = New System.Drawing.Size(175, 21)
        Me.cbx_rol.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(341, 165)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(363, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 124)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'DGVUsuarios
        '
        Me.DGVUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVUsuarios.Location = New System.Drawing.Point(12, 253)
        Me.DGVUsuarios.Name = "DGVUsuarios"
        Me.DGVUsuarios.Size = New System.Drawing.Size(515, 185)
        Me.DGVUsuarios.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(212, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Usuarios registrados"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(433, 165)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.Location = New System.Drawing.Point(1, 0)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(27, 31)
        Me.back.TabIndex = 22
        Me.back.Text = "⮌"
        Me.back.UseVisualStyleBackColor = True
        '
        'Registro_de_usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 450)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DGVUsuarios)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbx_rol)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pass2_txt)
        Me.Controls.Add(Me.pass_txt)
        Me.Controls.Add(Me.am_txt)
        Me.Controls.Add(Me.ap_txt)
        Me.Controls.Add(Me.nombre_txt)
        Me.Controls.Add(Me.username_txt)
        Me.Name = "Registro_de_usuarios"
        Me.Text = "Registro de usuarios"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents username_txt As TextBox
    Friend WithEvents nombre_txt As TextBox
    Friend WithEvents ap_txt As TextBox
    Friend WithEvents am_txt As TextBox
    Friend WithEvents pass_txt As TextBox
    Friend WithEvents pass2_txt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbx_rol As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DGVUsuarios As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents back As Button
End Class
