Imports System.Data.SqlClient


Public Class HorarioBD

    Private connectionString As String = "Data Source=JOHN;Initial Catalog=SIGEAS;Integrated Security=True"

    Public Function TraerHorarios() As DataTable
        Dim dt As New DataTable()

        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "SELECT IdHorario, Descripcion FROM Horarios"
                Dim command As New SqlCommand(query, connection)
                Dim adapter As New SqlDataAdapter(command)

                connection.Open()
                adapter.Fill(dt) ' Llenar el DataTable con los datos de la consulta
            End Using
        Catch ex As SqlException
            Throw New Exception("Error al obtener horarios: " & ex.Message)
        End Try

        Return dt
    End Function

    Public Sub InsertarHorario(descripcion As String, horaInicio As TimeSpan, horaFin As TimeSpan)
        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "INSERT INTO Horarios (Descripcion, HoraInicio, HoraFin) VALUES (@Descripcion, @HoraInicio, @HoraFin)"
                Dim command As New SqlCommand(query, connection)

                ' Agregar parámetros para prevenir inyección SQL
                command.Parameters.AddWithValue("@Descripcion", descripcion)
                command.Parameters.AddWithValue("@HoraInicio", horaInicio.ToString("c")) ' Formato de TimeSpan
                command.Parameters.AddWithValue("@HoraFin", horaFin.ToString("c"))

                connection.Open()
                command.ExecuteNonQuery()
            End Using
        Catch ex As SqlException
            Throw New Exception("Error al registrar el horario: " & ex.Message)
        End Try
    End Sub

    ' Método para obtener la lista de horarios
    Public Function ObtenerHorarios() As DataTable
        Dim dt As New DataTable()
        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "SELECT IdHorario, Descripcion AS Descripcion, HoraInicio AS Hora_Entrada, HoraFin AS Hora_Salida FROM Horarios"
                Dim adapter As New SqlDataAdapter(query, connection)
                adapter.Fill(dt)
            End Using
        Catch ex As SqlException
            Throw New Exception("Error al obtener los horarios: " & ex.Message)
        End Try
        Return dt
    End Function


End Class
