Public Class AsistenciasLogica

    Private asistencias As New AsistenciasBD()

    ' Método para obtener todas las asistencias
    Public Function ObtenerTodasLasAsistencias() As DataTable
        Try
            Return asistencias.ObtenerTodasLasAsistencias()
        Catch ex As Exception
            Throw New Exception("No se pudo obtener la lista completa de asistencias: " & ex.Message)
        End Try
    End Function

    ' Método para buscar asistencia por nombre
    Public Function BuscarAsistenciaPorNombre(nombre As String) As DataTable
        Try
            Return asistencias.BuscarAsistenciaPorNombre(nombre)
        Catch ex As Exception
            Throw New Exception("Error al buscar asistencia por nombre: " & ex.Message)
        End Try
    End Function

    ' Método para buscar asistencia por fecha
    Public Function BuscarAsistenciaPorFecha(fecha As Date) As DataTable
        Try
            Return asistencias.BuscarAsistenciaPorFecha(fecha)
        Catch ex As Exception
            Throw New Exception("Error al buscar asistencia por fecha: " & ex.Message)
        End Try
    End Function
End Class
