Imports System.Data.SqlClient

Public Class AsistenciaDB
    Private connectionString As String = "Data Source=JOHN;Initial Catalog=SIGEAS;Integrated Security=True"

    ' Método para registrar asistencia (entrada o salida)
    Public Sub RegistrarAsistencia(cedula As String, tipo As String, hora As DateTime)
        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String

                If tipo = "Entrada" Then
                    query = "INSERT INTO Asistencias (IdCed, Fecha, HoraEntrada) VALUES (@Cedula, @Fecha, @Hora)"
                ElseIf tipo = "Salida" Then
                    query = "UPDATE Asistencias SET HoraSalida = @Hora WHERE IdCed = @Cedula AND Fecha = @Fecha"
                End If

                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Cedula", cedula)
                command.Parameters.AddWithValue("@Fecha", hora.Date)
                command.Parameters.AddWithValue("@Hora", hora)

                connection.Open()
                command.ExecuteNonQuery()
            End Using
        Catch ex As SqlException
            Throw New Exception("Error al registrar asistencia: " & ex.Message)
        End Try
    End Sub

    ' Método para verificar si existe una entrada previa
    Public Function ObtenerAsistenciaPorFecha(cedula As String, fecha As Date) As DataTable
        Dim dt As New DataTable()
        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "SELECT HoraEntrada, HoraSalida FROM Asistencias WHERE IdCed = @Cedula AND Fecha = @Fecha"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Cedula", cedula)
                command.Parameters.AddWithValue("@Fecha", fecha)
                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(dt)
            End Using
        Catch ex As SqlException
            Throw New Exception("Error al verificar asistencia: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Sub CalcularHorasExtras(cedula As String, fecha As Date)
        Try
            Using connection As New SqlConnection(connectionString)
                Dim cmd As New SqlCommand("CalcularHorasExtras", connection)
                cmd.CommandType = CommandType.StoredProcedure

                ' Agregar parámetros
                cmd.Parameters.AddWithValue("@IdCed", cedula)
                cmd.Parameters.AddWithValue("@Fecha", fecha)

                ' Abrir conexión y ejecutar
                connection.Open()
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As SqlException
            Throw New Exception("Error al calcular horas extras: " & ex.Message)
        End Try
    End Sub





End Class

