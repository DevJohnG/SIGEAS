<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PanelAdmin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PanelAdmin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.pnlOnRegistrar = New System.Windows.Forms.Panel()
        Me.pnlOnHorario = New System.Windows.Forms.Panel()
        Me.pnlOnEmpleado = New System.Windows.Forms.Panel()
        Me.pnlOnPlanilla = New System.Windows.Forms.Panel()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.PnlPrincipal = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAsistencia = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnMenuRegistrar = New System.Windows.Forms.Button()
        Me.BtnHorarios = New System.Windows.Forms.Button()
        Me.btnEmpleados = New System.Windows.Forms.Button()
        Me.btnPlanilla = New System.Windows.Forms.Button()
        Me.pnlLeft.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.PnlPrincipal.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(34, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 39)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Bienvenido"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.BackColor = System.Drawing.Color.Transparent
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblCedula.Location = New System.Drawing.Point(59, 139)
        Me.lblCedula.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(56, 19)
        Me.lblCedula.TabIndex = 6
        Me.lblCedula.Text = "Cedula"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblNombre.Location = New System.Drawing.Point(35, 115)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(64, 19)
        Me.lblNombre.TabIndex = 5
        Me.lblNombre.Text = "nombre"
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.DarkCyan
        Me.pnlLeft.Controls.Add(Me.Panel1)
        Me.pnlLeft.Controls.Add(Me.btnAsistencia)
        Me.pnlLeft.Controls.Add(Me.Button1)
        Me.pnlLeft.Controls.Add(Me.PictureBox1)
        Me.pnlLeft.Controls.Add(Me.lblNombre)
        Me.pnlLeft.Controls.Add(Me.lblCedula)
        Me.pnlLeft.Controls.Add(Me.pnlOnRegistrar)
        Me.pnlLeft.Controls.Add(Me.btnMenuRegistrar)
        Me.pnlLeft.Controls.Add(Me.pnlOnHorario)
        Me.pnlLeft.Controls.Add(Me.BtnHorarios)
        Me.pnlLeft.Controls.Add(Me.pnlOnEmpleado)
        Me.pnlLeft.Controls.Add(Me.btnEmpleados)
        Me.pnlLeft.Controls.Add(Me.pnlOnPlanilla)
        Me.pnlLeft.Controls.Add(Me.btnPlanilla)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(200, 472)
        Me.pnlLeft.TabIndex = 8
        '
        'pnlOnRegistrar
        '
        Me.pnlOnRegistrar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.pnlOnRegistrar.Location = New System.Drawing.Point(0, 179)
        Me.pnlOnRegistrar.Name = "pnlOnRegistrar"
        Me.pnlOnRegistrar.Size = New System.Drawing.Size(10, 41)
        Me.pnlOnRegistrar.TabIndex = 15
        '
        'pnlOnHorario
        '
        Me.pnlOnHorario.BackColor = System.Drawing.Color.DarkSlateGray
        Me.pnlOnHorario.Location = New System.Drawing.Point(0, 320)
        Me.pnlOnHorario.Name = "pnlOnHorario"
        Me.pnlOnHorario.Size = New System.Drawing.Size(10, 41)
        Me.pnlOnHorario.TabIndex = 13
        '
        'pnlOnEmpleado
        '
        Me.pnlOnEmpleado.BackColor = System.Drawing.Color.DarkSlateGray
        Me.pnlOnEmpleado.Location = New System.Drawing.Point(0, 273)
        Me.pnlOnEmpleado.Name = "pnlOnEmpleado"
        Me.pnlOnEmpleado.Size = New System.Drawing.Size(10, 41)
        Me.pnlOnEmpleado.TabIndex = 11
        '
        'pnlOnPlanilla
        '
        Me.pnlOnPlanilla.BackColor = System.Drawing.Color.DarkSlateGray
        Me.pnlOnPlanilla.Location = New System.Drawing.Point(0, 226)
        Me.pnlOnPlanilla.Name = "pnlOnPlanilla"
        Me.pnlOnPlanilla.Size = New System.Drawing.Size(10, 41)
        Me.pnlOnPlanilla.TabIndex = 10
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.DarkSlateGray
        Me.pnlTop.Controls.Add(Me.lblFecha)
        Me.pnlTop.Controls.Add(Me.lblHora)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(200, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(648, 32)
        Me.pnlTop.TabIndex = 9
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFecha.Location = New System.Drawing.Point(6, 9)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(86, 16)
        Me.lblFecha.TabIndex = 9
        Me.lblFecha.Text = "fecha de hoy"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.BackColor = System.Drawing.Color.Transparent
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblHora.Location = New System.Drawing.Point(597, 9)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(39, 16)
        Me.lblHora.TabIndex = 8
        Me.lblHora.Text = "06:03"
        '
        'PnlPrincipal
        '
        Me.PnlPrincipal.Controls.Add(Me.Label8)
        Me.PnlPrincipal.Controls.Add(Me.Label7)
        Me.PnlPrincipal.Controls.Add(Me.Label6)
        Me.PnlPrincipal.Controls.Add(Me.Label5)
        Me.PnlPrincipal.Controls.Add(Me.Label4)
        Me.PnlPrincipal.Controls.Add(Me.Label3)
        Me.PnlPrincipal.Controls.Add(Me.Label2)
        Me.PnlPrincipal.Controls.Add(Me.Label1)
        Me.PnlPrincipal.Location = New System.Drawing.Point(200, 32)
        Me.PnlPrincipal.Name = "PnlPrincipal"
        Me.PnlPrincipal.Size = New System.Drawing.Size(648, 440)
        Me.PnlPrincipal.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(578, 49)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Timer
        '
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(593, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "1. Gestión de Empleados: Registra nuevos empleados, actualiza información o visua" &
    "liza el historial de asistencia."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(409, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "2. Horarios: Configura y ajusta los horarios según las necesidades operativas."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(525, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "3. Planilla: Genera y administra las planillas de pago según los registros de asi" &
    "stencia y horas extras."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(41, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(409, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "4. Horarios: Configura y ajusta los horarios según las necesidades operativas."
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(38, 302)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(578, 33)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Recuerda que este panel es una herramienta clave para garantizar la eficiencia y " &
    "cumplimiento en la organización."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(38, 335)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(234, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "¡Gracias por tu dedicación y liderazgo!"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Location = New System.Drawing.Point(0, 367)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 41)
        Me.Panel1.TabIndex = 17
        '
        'btnAsistencia
        '
        Me.btnAsistencia.FlatAppearance.BorderSize = 0
        Me.btnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsistencia.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsistencia.ForeColor = System.Drawing.Color.White
        Me.btnAsistencia.Image = Global.Gestion_Admin.My.Resources.Resources.asistencia
        Me.btnAsistencia.Location = New System.Drawing.Point(0, 367)
        Me.btnAsistencia.Name = "btnAsistencia"
        Me.btnAsistencia.Size = New System.Drawing.Size(200, 41)
        Me.btnAsistencia.TabIndex = 18
        Me.btnAsistencia.Text = "   Asistencia"
        Me.btnAsistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAsistencia.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Image = Global.Gestion_Admin.My.Resources.Resources.salir
        Me.Button1.Location = New System.Drawing.Point(12, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 19)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Gestion_Admin.My.Resources.Resources.Blue_Modern_Global_Network_Company_Logo__2____copia
        Me.PictureBox1.Location = New System.Drawing.Point(63, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 73)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'btnMenuRegistrar
        '
        Me.btnMenuRegistrar.FlatAppearance.BorderSize = 0
        Me.btnMenuRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuRegistrar.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnMenuRegistrar.Image = Global.Gestion_Admin.My.Resources.Resources.Blue_Modern_Global_Network_Company_Logo__2_1
        Me.btnMenuRegistrar.Location = New System.Drawing.Point(0, 179)
        Me.btnMenuRegistrar.Name = "btnMenuRegistrar"
        Me.btnMenuRegistrar.Size = New System.Drawing.Size(200, 41)
        Me.btnMenuRegistrar.TabIndex = 16
        Me.btnMenuRegistrar.Text = "   Registrar "
        Me.btnMenuRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMenuRegistrar.UseVisualStyleBackColor = True
        '
        'BtnHorarios
        '
        Me.BtnHorarios.FlatAppearance.BorderSize = 0
        Me.BtnHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHorarios.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHorarios.ForeColor = System.Drawing.Color.White
        Me.BtnHorarios.Image = Global.Gestion_Admin.My.Resources.Resources.Blue_Modern_Global_Network_Company_Logo__3____copia
        Me.BtnHorarios.Location = New System.Drawing.Point(0, 320)
        Me.BtnHorarios.Name = "BtnHorarios"
        Me.BtnHorarios.Size = New System.Drawing.Size(200, 41)
        Me.BtnHorarios.TabIndex = 14
        Me.BtnHorarios.Text = "   Horarios"
        Me.BtnHorarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnHorarios.UseVisualStyleBackColor = True
        '
        'btnEmpleados
        '
        Me.btnEmpleados.FlatAppearance.BorderSize = 0
        Me.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpleados.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpleados.ForeColor = System.Drawing.Color.White
        Me.btnEmpleados.Image = Global.Gestion_Admin.My.Resources.Resources.Blue_Modern_Global_Network_Company_Logo__2____copia___copia___copia
        Me.btnEmpleados.Location = New System.Drawing.Point(0, 273)
        Me.btnEmpleados.Name = "btnEmpleados"
        Me.btnEmpleados.Size = New System.Drawing.Size(200, 41)
        Me.btnEmpleados.TabIndex = 12
        Me.btnEmpleados.Text = " Empleados"
        Me.btnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEmpleados.UseVisualStyleBackColor = True
        '
        'btnPlanilla
        '
        Me.btnPlanilla.FlatAppearance.BorderSize = 0
        Me.btnPlanilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlanilla.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlanilla.ForeColor = System.Drawing.Color.White
        Me.btnPlanilla.Image = Global.Gestion_Admin.My.Resources.Resources.Blue_Modern_Global_Network_Company_Logo
        Me.btnPlanilla.Location = New System.Drawing.Point(0, 226)
        Me.btnPlanilla.Name = "btnPlanilla"
        Me.btnPlanilla.Size = New System.Drawing.Size(200, 41)
        Me.btnPlanilla.TabIndex = 10
        Me.btnPlanilla.Text = "   Planilla"
        Me.btnPlanilla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPlanilla.UseVisualStyleBackColor = True
        '
        'PanelAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 472)
        Me.Controls.Add(Me.PnlPrincipal)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlLeft)
        Me.Name = "PanelAdmin"
        Me.Text = "Panel Administrador"
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.PnlPrincipal.ResumeLayout(False)
        Me.PnlPrincipal.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblCedula As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents pnlLeft As Panel
    Friend WithEvents btnPlanilla As Button
    Friend WithEvents pnlTop As Panel
    Friend WithEvents pnlOnPlanilla As Panel
    Friend WithEvents pnlOnEmpleado As Panel
    Friend WithEvents btnEmpleados As Button
    Friend WithEvents pnlOnRegistrar As Panel
    Friend WithEvents btnMenuRegistrar As Button
    Friend WithEvents pnlOnHorario As Panel
    Friend WithEvents BtnHorarios As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PnlPrincipal As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents lblHora As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents lblFecha As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAsistencia As Button
End Class
