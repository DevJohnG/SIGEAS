<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SistemaMarcado
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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.btnMarcarEntrada = New System.Windows.Forms.Button()
        Me.btnMarcarSalida = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(142, 88)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(69, 20)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "nombre"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.BackColor = System.Drawing.Color.Transparent
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.ForeColor = System.Drawing.Color.White
        Me.lblCedula.Location = New System.Drawing.Point(142, 108)
        Me.lblCedula.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(65, 20)
        Me.lblCedula.TabIndex = 1
        Me.lblCedula.Text = "Cedula"
        '
        'btnMarcarEntrada
        '
        Me.btnMarcarEntrada.BackColor = System.Drawing.Color.CadetBlue
        Me.btnMarcarEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarcarEntrada.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMarcarEntrada.Location = New System.Drawing.Point(131, 191)
        Me.btnMarcarEntrada.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnMarcarEntrada.Name = "btnMarcarEntrada"
        Me.btnMarcarEntrada.Size = New System.Drawing.Size(155, 37)
        Me.btnMarcarEntrada.TabIndex = 2
        Me.btnMarcarEntrada.Text = "Marcar Entrada"
        Me.btnMarcarEntrada.UseVisualStyleBackColor = False
        '
        'btnMarcarSalida
        '
        Me.btnMarcarSalida.BackColor = System.Drawing.Color.CadetBlue
        Me.btnMarcarSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarcarSalida.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMarcarSalida.Location = New System.Drawing.Point(131, 245)
        Me.btnMarcarSalida.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnMarcarSalida.Name = "btnMarcarSalida"
        Me.btnMarcarSalida.Size = New System.Drawing.Size(155, 37)
        Me.btnMarcarSalida.TabIndex = 3
        Me.btnMarcarSalida.Text = "Marcar salida"
        Me.btnMarcarSalida.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(134, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Bienvenido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(109, 165)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Que disfrute su jornada"
        '
        'SistemaMarcado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Semestral.My.Resources.Resources.Blue_Modern_Global_Network_Company_Logo__1_
        Me.ClientSize = New System.Drawing.Size(408, 479)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMarcarSalida)
        Me.Controls.Add(Me.btnMarcarEntrada)
        Me.Controls.Add(Me.lblCedula)
        Me.Controls.Add(Me.lblNombre)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "SistemaMarcado"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombre As Label
    Friend WithEvents lblCedula As Label
    Friend WithEvents btnMarcarEntrada As Button
    Friend WithEvents btnMarcarSalida As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
