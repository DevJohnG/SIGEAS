Imports System.Data.SqlClient
Public Class AsistenciasBD

    Private connectionString As String = "Data Source=JOHN;Initial Catalog=SIGEAS;Integrated Security=True"

    Public Function ObtenerTodasLasAsistencias() As DataTable
        Dim dt As New DataTable()
        Try
            ' Consulta para obtener todas las asistencias
            Dim query As String = "SELECT a.IdAsistencia, a.IdCed, a.Fecha, a.HoraEntrada, a.HoraSalida, " &
                                  "a.HorasRegulares, a.HorasExtras, u.NombreCompleto " &
                                  "FROM Asistencias a " &
                                  "JOIN Usuarios u ON a.IdCed = u.IdCed"

            ' Usar la conexión definida
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    Dim adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al obtener las asistencias: " & ex.Message)
        End Try
        Return dt
    End Function

    ' Método para buscar asistencia por nombre
    Public Function BuscarAsistenciaPorNombre(nombre As String) As DataTable
        Dim dt As New DataTable()
        Try
            ' Consulta para buscar por nombre de usuario
            Dim query As String = "SELECT a.IdAsistencia, a.IdCed, a.Fecha, a.HoraEntrada, a.HoraSalida, " &
                                  "a.HorasRegulares, a.HorasExtras,  u.NombreCompleto " &
                                  "FROM Asistencias a " &
                                  "JOIN Usuarios u ON a.IdCed = u.IdCed " &
                                  "WHERE u.NombreCompleto LIKE @Nombre"

            ' Usar la conexión definida
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Nombre", "%" & nombre & "%")
                    Dim adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al buscar asistencia por nombre: " & ex.Message)
        End Try
        Return dt
    End Function

    ' Método para buscar asistencia por fecha
    Public Function BuscarAsistenciaPorFecha(fecha As Date) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                ' Consulta para buscar por fecha
                Dim query As String = "SELECT a.IdAsistencia, a.IdCed, a.Fecha, a.HoraEntrada, a.HoraSalida, " &
                                      "a.HorasRegulares, a.HorasExtras, a.EsDiaFestivo, a.TipoExtra, u.NombreCompleto " &
                                      "FROM Asistencias a " &
                                      "JOIN Usuarios u ON a.IdCed = u.IdCed " &
                                      "WHERE a.Fecha = @Fecha"

                Using cmd As New SqlCommand(query, conn)
                    ' Convertir la fecha a formato compatible con SQL
                    cmd.Parameters.AddWithValue("@Fecha", fecha.ToString("yyyy-MM-dd"))

                    Dim adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al buscar asistencia por fecha: " & ex.Message)
        End Try
        Return dt
    End Function

End Class
