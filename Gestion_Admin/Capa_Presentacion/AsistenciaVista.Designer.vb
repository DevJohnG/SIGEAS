<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AsistenciaVista
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
        Me.btnVerTodos = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBuscarNombre = New System.Windows.Forms.Button()
        Me.txtBuscarEmpleado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewAsistencias = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnBuscarFecha = New System.Windows.Forms.Button()
        CType(Me.DataGridViewAsistencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVerTodos
        '
        Me.btnVerTodos.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnVerTodos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnVerTodos.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerTodos.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnVerTodos.Location = New System.Drawing.Point(524, 57)
        Me.btnVerTodos.Name = "btnVerTodos"
        Me.btnVerTodos.Size = New System.Drawing.Size(115, 23)
        Me.btnVerTodos.TabIndex = 11
        Me.btnVerTodos.Text = "Ver Todos"
        Me.btnVerTodos.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(303, 21)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Visualizar Asistencia de los empleados"
        '
        'btnBuscarNombre
        '
        Me.btnBuscarNombre.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnBuscarNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscarNombre.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarNombre.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBuscarNombre.Location = New System.Drawing.Point(406, 57)
        Me.btnBuscarNombre.Name = "btnBuscarNombre"
        Me.btnBuscarNombre.Size = New System.Drawing.Size(115, 23)
        Me.btnBuscarNombre.TabIndex = 9
        Me.btnBuscarNombre.Text = "Buscar"
        Me.btnBuscarNombre.UseVisualStyleBackColor = False
        '
        'txtBuscarEmpleado
        '
        Me.txtBuscarEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscarEmpleado.Location = New System.Drawing.Point(217, 57)
        Me.txtBuscarEmpleado.MaxLength = 15
        Me.txtBuscarEmpleado.Name = "txtBuscarEmpleado"
        Me.txtBuscarEmpleado.Size = New System.Drawing.Size(186, 20)
        Me.txtBuscarEmpleado.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Buscar empleado por nombre"
        '
        'DataGridViewAsistencias
        '
        Me.DataGridViewAsistencias.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridViewAsistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAsistencias.Location = New System.Drawing.Point(33, 142)
        Me.DataGridViewAsistencias.Name = "DataGridViewAsistencias"
        Me.DataGridViewAsistencias.Size = New System.Drawing.Size(601, 278)
        Me.DataGridViewAsistencias.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Buscar por fecha"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(141, 99)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha.TabIndex = 14
        '
        'btnBuscarFecha
        '
        Me.btnBuscarFecha.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnBuscarFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscarFecha.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarFecha.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBuscarFecha.Location = New System.Drawing.Point(347, 99)
        Me.btnBuscarFecha.Name = "btnBuscarFecha"
        Me.btnBuscarFecha.Size = New System.Drawing.Size(115, 23)
        Me.btnBuscarFecha.TabIndex = 15
        Me.btnBuscarFecha.Text = "Buscar"
        Me.btnBuscarFecha.UseVisualStyleBackColor = False
        '
        'AsistenciaVista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Gestion_Admin.My.Resources.Resources.fondo
        Me.ClientSize = New System.Drawing.Size(667, 482)
        Me.Controls.Add(Me.btnBuscarFecha)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewAsistencias)
        Me.Controls.Add(Me.btnVerTodos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnBuscarNombre)
        Me.Controls.Add(Me.txtBuscarEmpleado)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AsistenciaVista"
        Me.Text = "AsistenciaVista"
        CType(Me.DataGridViewAsistencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVerTodos As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBuscarNombre As Button
    Friend WithEvents txtBuscarEmpleado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridViewAsistencias As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents btnBuscarFecha As Button
End Class
