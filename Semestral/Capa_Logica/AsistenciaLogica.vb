Imports System.Data.SqlClient

Public Class AsistenciaLogica

    Private cnn As New AsistenciaDB()

    Public Sub RegistrarAsistencia(cedula As String, tipo As String, hora As DateTime)
        If String.IsNullOrEmpty(cedula) Then
            Throw New Exception("La cédula no puede estar vacía.")
        End If

        ' Validación para determinar si la entrada o salida es válida
        If tipo = "Entrada" Then
            ValidarEntrada(cedula, hora) ' Validar antes de registrar la entrada
            cnn.RegistrarAsistencia(cedula, tipo, hora) ' Registrar entrada
        ElseIf tipo = "Salida" Then
            ValidarSalida(cedula, hora) ' Validar antes de registrar la salida
            cnn.RegistrarAsistencia(cedula, tipo, hora) ' Registrar salida
        Else
            Throw New Exception("El tipo de asistencia debe ser 'Entrada' o 'Salida'.")
        End If
    End Sub

    ' Validar si el usuario puede marcar una entrada
    Private Sub ValidarEntrada(cedula As String, hora As DateTime)
        ' Consultar si ya existe una entrada sin salida para la fecha actual
        Dim asistencia As DataTable = cnn.ObtenerAsistenciaPorFecha(cedula, hora.Date)

        If asistencia.Rows.Count > 0 Then
            ' Si hay una entrada sin salida, no se puede marcar otra entrada
            If Not IsDBNull(asistencia.Rows(0)("HoraEntrada")) AndAlso IsDBNull(asistencia.Rows(0)("HoraSalida")) Then
                Throw New Exception(" Ya ha registrado una entrada.")
            End If
        End If
    End Sub

    ' Validar si el usuario puede marcar una salida
    Private Sub ValidarSalida(cedula As String, hora As DateTime)
        ' Consultar si existe una entrada registrada para la fecha actual
        Dim asistencia As DataTable = cnn.ObtenerAsistenciaPorFecha(cedula, hora.Date)

        ' Si no hay entrada registrada, no puede marcar una salida
        If asistencia.Rows.Count = 0 OrElse IsDBNull(asistencia.Rows(0)("HoraEntrada")) Then
            Throw New Exception("Debe marcar una entrada antes de registrar una salida.")
        End If

        ' Si ya hay una salida registrada, no puede registrar otra salida
        If Not IsDBNull(asistencia.Rows(0)("HoraSalida")) Then
            Throw New Exception("La salida ya fue registrada anteriormente.")
        End If
    End Sub

    Public Sub CalcularHorasExtras(cedula As String, fecha As Date)

        If String.IsNullOrEmpty(cedula) Then
            Throw New Exception("La cédula no puede estar vacía.")
        End If
        cnn.CalcularHorasExtras(cedula, fecha)
    End Sub



End Class
