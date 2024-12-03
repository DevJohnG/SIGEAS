Public Class HorarioLogica

    Private horario As New HorarioBD()


    Public Function TraerHorarios() As DataTable
        Return horario.TraerHorarios()
    End Function

    ' Método para obtener los horarios
    Public Sub InsertarHorario(descripcion As String, horaInicio As TimeSpan, horaFin As TimeSpan)
        If String.IsNullOrEmpty(descripcion) Then
            Throw New Exception("El nombre del horario es obligatorio.")
        End If

        If horaInicio >= horaFin Then
            Throw New Exception("La hora de inicio debe ser menor que la hora de fin.")
        End If

        Dim horarioBD As New HorarioBD()
        horarioBD.InsertarHorario(descripcion, horaInicio, horaFin)
    End Sub


    ' Método para obtener los horarios
    Public Function ObtenerHorarios() As DataTable
        Return horario.ObtenerHorarios()
    End Function

End Class
