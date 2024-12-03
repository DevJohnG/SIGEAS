<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDig1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcedula = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnbIngresa = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(128, 283)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese su numero de cedula"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.BackColor = System.Drawing.Color.Transparent
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblFecha.Location = New System.Drawing.Point(123, 236)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(231, 24)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "Sabado. noviemebre 2023"
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(464, 242)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 3
        '
        'lblDig1
        '
        Me.lblDig1.AutoSize = True
        Me.lblDig1.BackColor = System.Drawing.Color.Transparent
        Me.lblDig1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDig1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblDig1.Location = New System.Drawing.Point(143, 162)
        Me.lblDig1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDig1.Name = "lblDig1"
        Me.lblDig1.Size = New System.Drawing.Size(194, 73)
        Me.lblDig1.TabIndex = 5
        Me.lblDig1.Text = "12:40"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(159, 88)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 36)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Bienvenido"
        '
        'txtcedula
        '
        Me.txtcedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcedula.Location = New System.Drawing.Point(137, 306)
        Me.txtcedula.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcedula.MaxLength = 15
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.Size = New System.Drawing.Size(199, 26)
        Me.txtcedula.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(196, 124)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "SIGEAS"
        '
        'btnbIngresa
        '
        Me.btnbIngresa.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnbIngresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbIngresa.ForeColor = System.Drawing.Color.DarkCyan
        Me.btnbIngresa.Location = New System.Drawing.Point(181, 344)
        Me.btnbIngresa.Margin = New System.Windows.Forms.Padding(2)
        Me.btnbIngresa.Name = "btnbIngresa"
        Me.btnbIngresa.Size = New System.Drawing.Size(104, 27)
        Me.btnbIngresa.TabIndex = 10
        Me.btnbIngresa.Text = "Ingresar"
        Me.btnbIngresa.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Semestral.My.Resources.Resources.Blue_Modern_Global_Network_Company_Logo__1_
        Me.ClientSize = New System.Drawing.Size(465, 493)
        Me.Controls.Add(Me.btnbIngresa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcedula)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblDig1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Login"
        Me.Text = "Sistema de Marcado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDig1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcedula As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnbIngresa As Button
End Class
