
Public Class PlanillaLogica
    Private planilla As New PlanillaBD()

    ' Método para obtener las nóminas desde la base de datos
    Public Function ObtenerNominas() As DataTable
        Try
            ' Llamamos al método de la capa de datos para obtener las nóminas
            Return planilla.ObtenerNominas()
        Catch ex As Exception
            Throw New Exception("Error al obtener las nóminas: " & ex.Message)
        End Try
    End Function

    Public Function BuscarNominaPorNombre(nombre As String) As DataTable
        Try
            ' Llamamos al método de la capa de datos para obtener las nóminas filtradas por nombre
            Return planilla.BuscarNominaPorNombre(nombre)
        Catch ex As Exception
            Throw New Exception("Error al buscar la nómina por nombre: " & ex.Message)
        End Try
    End Function

    Public Sub CalcularNominaMensual(mes As Integer, año As Integer)
        Try
            ' Llamamos al método de la capa de datos para ejecutar el procedimiento almacenado
            planilla.CalcularNominaMensual(mes, año)
        Catch ex As Exception
            Throw New Exception("Error al ejecutar el procedimiento CalcularNominaMensual: " & ex.Message)
        End Try
    End Sub


End Class
