<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarUsuario
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
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lbl = New System.Windows.Forms.Label()
        Me.txtSalario = New System.Windows.Forms.TextBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Cedula = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmBoxContrato = New System.Windows.Forms.ComboBox()
        Me.cmBoxCargo = New System.Windows.Forms.ComboBox()
        Me.cmBoxHorario = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRegistrar.Location = New System.Drawing.Point(250, 323)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(140, 38)
        Me.btnRegistrar.TabIndex = 27
        Me.btnRegistrar.Text = "Registrar Empleado"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.BackColor = System.Drawing.Color.Transparent
        Me.lbl6.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.ForeColor = System.Drawing.Color.Black
        Me.lbl6.Location = New System.Drawing.Point(358, 249)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(43, 16)
        Me.lbl6.TabIndex = 25
        Me.lbl6.Text = "Cargo"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.BackColor = System.Drawing.Color.Transparent
        Me.lbl5.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.ForeColor = System.Drawing.Color.Black
        Me.lbl5.Location = New System.Drawing.Point(76, 249)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(54, 16)
        Me.lbl5.TabIndex = 23
        Me.lbl5.Text = "Horario"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.BackColor = System.Drawing.Color.Transparent
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.Black
        Me.lbl3.Location = New System.Drawing.Point(77, 196)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(93, 16)
        Me.lbl3.TabIndex = 19
        Me.lbl3.Text = "Tipo Contrato"
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Location = New System.Drawing.Point(359, 159)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(200, 20)
        Me.txtNombre.TabIndex = 18
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.BackColor = System.Drawing.Color.Transparent
        Me.lbl.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.Black
        Me.lbl.Location = New System.Drawing.Point(357, 140)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(121, 16)
        Me.lbl.TabIndex = 17
        Me.lbl.Text = "Nombre Completo"
        '
        'txtSalario
        '
        Me.txtSalario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSalario.Location = New System.Drawing.Point(359, 215)
        Me.txtSalario.MaxLength = 7
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.Size = New System.Drawing.Size(200, 20)
        Me.txtSalario.TabIndex = 16
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.Color.Transparent
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.Black
        Me.lbl2.Location = New System.Drawing.Point(357, 196)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(81, 16)
        Me.lbl2.TabIndex = 15
        Me.lbl2.Text = "Salario Base"
        '
        'txtCedula
        '
        Me.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCedula.Location = New System.Drawing.Point(79, 159)
        Me.txtCedula.MaxLength = 15
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(200, 20)
        Me.txtCedula.TabIndex = 29
        '
        'Cedula
        '
        Me.Cedula.AutoSize = True
        Me.Cedula.BackColor = System.Drawing.Color.Transparent
        Me.Cedula.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cedula.ForeColor = System.Drawing.Color.Black
        Me.Cedula.Location = New System.Drawing.Point(78, 140)
        Me.Cedula.Name = "Cedula"
        Me.Cedula.Size = New System.Drawing.Size(49, 16)
        Me.Cedula.TabIndex = 28
        Me.Cedula.Text = "Cedula"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 20)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = " Formulario de Registro de Usuarios"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(484, 43)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Por favor, asegúrate de completar todos los campos requeridos correctamente antes" &
    " de guardar la información."
        '
        'cmBoxContrato
        '
        Me.cmBoxContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmBoxContrato.FormattingEnabled = True
        Me.cmBoxContrato.Items.AddRange(New Object() {"Indefinido", "Definido", "Temporal", "Servicio Profesional"})
        Me.cmBoxContrato.Location = New System.Drawing.Point(79, 215)
        Me.cmBoxContrato.Name = "cmBoxContrato"
        Me.cmBoxContrato.Size = New System.Drawing.Size(200, 21)
        Me.cmBoxContrato.TabIndex = 32
        '
        'cmBoxCargo
        '
        Me.cmBoxCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmBoxCargo.FormattingEnabled = True
        Me.cmBoxCargo.Items.AddRange(New Object() {"Operador", "Auxiliar", "Adminitrador", "Supervisor", "Gerente", "Asistente", "Colaborador"})
        Me.cmBoxCargo.Location = New System.Drawing.Point(359, 268)
        Me.cmBoxCargo.Name = "cmBoxCargo"
        Me.cmBoxCargo.Size = New System.Drawing.Size(201, 21)
        Me.cmBoxCargo.TabIndex = 33
        '
        'cmBoxHorario
        '
        Me.cmBoxHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmBoxHorario.FormattingEnabled = True
        Me.cmBoxHorario.Items.AddRange(New Object() {"1 ", "2 ", "3 "})
        Me.cmBoxHorario.Location = New System.Drawing.Point(79, 268)
        Me.cmBoxHorario.Name = "cmBoxHorario"
        Me.cmBoxHorario.Size = New System.Drawing.Size(200, 21)
        Me.cmBoxHorario.TabIndex = 34
        '
        'RegistrarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Gestion_Admin.My.Resources.Resources.fondo
        Me.ClientSize = New System.Drawing.Size(651, 443)
        Me.Controls.Add(Me.cmBoxHorario)
        Me.Controls.Add(Me.cmBoxCargo)
        Me.Controls.Add(Me.cmBoxContrato)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.Cedula)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.txtSalario)
        Me.Controls.Add(Me.lbl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegistrarUsuario"
        Me.Text = "RegistrarUsuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRegistrar As Button
    Friend WithEvents lbl6 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lbl As Label
    Friend WithEvents txtSalario As TextBox
    Friend WithEvents lbl2 As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents Cedula As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmBoxContrato As ComboBox
    Friend WithEvents cmBoxCargo As ComboBox
    Friend WithEvents cmBoxHorario As ComboBox
End Class
