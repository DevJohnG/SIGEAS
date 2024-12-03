<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlanillaVista
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
        Me.DataGridViewPlanilla = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnVerTodos = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscarEmpleado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCalcularPlanilla = New System.Windows.Forms.Button()
        Me.txtAño = New System.Windows.Forms.TextBox()
        CType(Me.DataGridViewPlanilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewPlanilla
        '
        Me.DataGridViewPlanilla.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridViewPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPlanilla.Location = New System.Drawing.Point(20, 138)
        Me.DataGridViewPlanilla.Name = "DataGridViewPlanilla"
        Me.DataGridViewPlanilla.ReadOnly = True
        Me.DataGridViewPlanilla.Size = New System.Drawing.Size(619, 224)
        Me.DataGridViewPlanilla.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(229, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Visualizar Planilla Quincenal"
        '
        'btnVerTodos
        '
        Me.btnVerTodos.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnVerTodos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnVerTodos.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerTodos.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnVerTodos.Location = New System.Drawing.Point(518, 53)
        Me.btnVerTodos.Name = "btnVerTodos"
        Me.btnVerTodos.Size = New System.Drawing.Size(115, 23)
        Me.btnVerTodos.TabIndex = 10
        Me.btnVerTodos.Text = "Ver Todos"
        Me.btnVerTodos.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBuscar.Location = New System.Drawing.Point(400, 53)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(115, 23)
        Me.btnBuscar.TabIndex = 9
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtBuscarEmpleado
        '
        Me.txtBuscarEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscarEmpleado.Location = New System.Drawing.Point(211, 53)
        Me.txtBuscarEmpleado.Name = "txtBuscarEmpleado"
        Me.txtBuscarEmpleado.Size = New System.Drawing.Size(186, 20)
        Me.txtBuscarEmpleado.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Buscar empleado por nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Calcular Planila del Mes:"
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(175, 96)
        Me.txtMes.MaxLength = 2
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(35, 20)
        Me.txtMes.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(216, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "del Año:"
        '
        'btnCalcularPlanilla
        '
        Me.btnCalcularPlanilla.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnCalcularPlanilla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCalcularPlanilla.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcularPlanilla.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCalcularPlanilla.Location = New System.Drawing.Point(318, 96)
        Me.btnCalcularPlanilla.Name = "btnCalcularPlanilla"
        Me.btnCalcularPlanilla.Size = New System.Drawing.Size(115, 23)
        Me.btnCalcularPlanilla.TabIndex = 14
        Me.btnCalcularPlanilla.Text = "Generar"
        Me.btnCalcularPlanilla.UseVisualStyleBackColor = False
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(277, 96)
        Me.txtAño.MaxLength = 4
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(35, 20)
        Me.txtAño.TabIndex = 15
        '
        'PlanillaVista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Gestion_Admin.My.Resources.Resources.fondo
        Me.ClientSize = New System.Drawing.Size(651, 443)
        Me.Controls.Add(Me.txtAño)
        Me.Controls.Add(Me.btnCalcularPlanilla)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnVerTodos)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscarEmpleado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridViewPlanilla)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PlanillaVista"
        Me.Text = "PlanillaVista"
        CType(Me.DataGridViewPlanilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewPlanilla As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents btnVerTodos As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscarEmpleado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMes As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCalcularPlanilla As Button
    Friend WithEvents txtAño As TextBox
End Class
