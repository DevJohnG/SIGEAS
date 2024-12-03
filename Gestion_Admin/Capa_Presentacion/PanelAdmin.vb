Public Class PanelAdmin

    Private cedUsuario As String
    Private Sub PanelAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer.Interval = 1000
        Timer.Start()
    End Sub


    ' Método para cargar datos del usuario
    Public Sub CargarUsuario(cedula As String, nombre As String)
        cedUsuario = cedula
        lblCedula.Text = cedula
        lblNombre.Text = nombre
    End Sub

    Private Sub btnMenuRegistrar_Click(sender As Object, e As EventArgs) Handles btnMenuRegistrar.Click
        switchPanel(RegistrarUsuario)
    End Sub

    Sub switchPanel(ByVal panel1 As Form)

        PnlPrincipal.Controls.Clear()
        panel1.TopLevel = False
        PnlPrincipal.Controls.Add(panel1)
        panel1.Show()
    End Sub

    Private Sub btnPlanilla_Click(sender As Object, e As EventArgs) Handles btnPlanilla.Click
        switchPanel(PlanillaVista)
    End Sub

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        switchPanel(EmpleadosVista)
    End Sub

    Private Sub BtnHorarios_Click(sender As Object, e As EventArgs) Handles BtnHorarios.Click
        switchPanel(HorarioVista)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoginAdministracion.Show()
        Me.Hide()

    End Sub

    Private Sub btnAsistencia_Click(sender As Object, e As EventArgs) Handles btnAsistencia.Click
        switchPanel(AsistenciaVista)
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        lblHora.Text = DateTime.Now.ToString("hh:mm")
        lblFecha.Text = DateTime.Now.ToString("dddd, dd, MMMM yyyy")
    End Sub

End Class
