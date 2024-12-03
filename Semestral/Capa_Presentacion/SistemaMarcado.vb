
Imports System.Data.SqlClient

Public Class SistemaMarcado

    Private asistenciaLogica As New AsistenciaLogica()
    Private cedUsuario As String

    ' Método para cargar datos del usuario
    Public Sub CargarUsuario(cedula As String, nombre As String)
        cedUsuario = cedula
        lblCedula.Text = cedula
        lblNombre.Text = nombre
    End Sub

    ' Botón para registrar entrada
    Private Sub btnMarcarEntrada_Click(sender As Object, e As EventArgs) Handles btnMarcarEntrada.Click
        Try
            Dim horaActual As DateTime = DateTime.Now
            asistenciaLogica.RegistrarAsistencia(cedUsuario, "Entrada", horaActual)
            MessageBox.Show("Entrada registrada correctamente.")

            ' Regresar al formulario inicial
            Dim login As New Login()
            login.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Botón para registrar salida
    Private Sub btnMarcarSalida_Click(sender As Object, e As EventArgs) Handles btnMarcarSalida.Click
        Try
            Dim horaActual As DateTime = DateTime.Now
            asistenciaLogica.RegistrarAsistencia(cedUsuario, "Salida", horaActual)
            MessageBox.Show("Salida registrada correctamente.")


            ' Calcular horas extras
            asistenciaLogica.CalcularHorasExtras(lblCedula.Text, horaActual.Date)
            MessageBox.Show("Salida registrada y horas extras calculadas correctamente.")

            ' Regresar al formulario inicial
            Dim Login As New Login()
            Login.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SistemaMarcado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class