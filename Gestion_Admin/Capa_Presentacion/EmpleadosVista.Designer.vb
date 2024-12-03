<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpleadosVista
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
        Me.txtBuscarEmpleado = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.DataGridViewEmpleados = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnVerTodos = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCedUser = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        CType(Me.DataGridViewEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(237, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 25)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Buscar empleado por nombre"
        '
        'txtBuscarEmpleado
        '
        Me.txtBuscarEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscarEmpleado.Location = New System.Drawing.Point(207, 54)
        Me.txtBuscarEmpleado.MaxLength = 50
        Me.txtBuscarEmpleado.Name = "txtBuscarEmpleado"
        Me.txtBuscarEmpleado.Size = New System.Drawing.Size(186, 20)
        Me.txtBuscarEmpleado.TabIndex = 2
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBuscar.Location = New System.Drawing.Point(396, 54)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(115, 23)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'DataGridViewEmpleados
        '
        Me.DataGridViewEmpleados.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewEmpleados.GridColor = System.Drawing.Color.DarkSlateGray
        Me.DataGridViewEmpleados.Location = New System.Drawing.Point(23, 137)
        Me.DataGridViewEmpleados.Name = "DataGridViewEmpleados"
        Me.DataGridViewEmpleados.ReadOnly = True
        Me.DataGridViewEmpleados.Size = New System.Drawing.Size(606, 266)
        Me.DataGridViewEmpleados.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(278, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Visualizar Empleados en el Sistema"
        '
        'btnVerTodos
        '
        Me.btnVerTodos.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnVerTodos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnVerTodos.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerTodos.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnVerTodos.Location = New System.Drawing.Point(514, 54)
        Me.btnVerTodos.Name = "btnVerTodos"
        Me.btnVerTodos.Size = New System.Drawing.Size(115, 23)
        Me.btnVerTodos.TabIndex = 6
        Me.btnVerTodos.Text = "Ver Todos"
        Me.btnVerTodos.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Eliminar empleado"
        '
        'txtCedUser
        '
        Me.txtCedUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCedUser.Location = New System.Drawing.Point(143, 89)
        Me.txtCedUser.MaxLength = 15
        Me.txtCedUser.Name = "txtCedUser"
        Me.txtCedUser.Size = New System.Drawing.Size(186, 20)
        Me.txtCedUser.TabIndex = 8
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEliminar.Location = New System.Drawing.Point(335, 87)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(115, 23)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'EmpleadosVista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.BackgroundImage = Global.Gestion_Admin.My.Resources.Resources.fondo
        Me.ClientSize = New System.Drawing.Size(667, 482)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.txtCedUser)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnVerTodos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridViewEmpleados)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscarEmpleado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EmpleadosVista"
        Me.Text = "EmpleadosVista"
        CType(Me.DataGridViewEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBuscarEmpleado As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents DataGridViewEmpleados As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents btnVerTodos As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCedUser As TextBox
    Friend WithEvents btnEliminar As Button
End Class
