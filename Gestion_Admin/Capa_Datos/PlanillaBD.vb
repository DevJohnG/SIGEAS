Imports System.Data.SqlClient

Public Class PlanillaBD
    Private connectionString As String = "Data Source=JOHN;Initial Catalog=SIGEAS;Integrated Security=True"

    Public Function ObtenerNominas() As DataTable
        Dim dt As New DataTable()

        ' Consulta para obtener los datos de la tabla Nominas
        Dim query As String = "SELECT n.IdNomina, n.IdCed, u.NombreCompleto, n.Mes, n.Año, " &
                              "n.HorasRegulares, n.HorasExtras, n.PagoHorasRegulares, n.PagoHorasExtras, " &
                              "n.SeguroSocial, n.SeguroEducativo, n.MontoFinal " &
                              "FROM Nominas n " &
                              "INNER JOIN Usuarios u ON n.IdCed = u.IdCed"

        Try
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al obtener las nóminas: " & ex.Message)
        End Try

        Return dt
    End Function

    Public Function BuscarNominaPorNombre(nombre As String) As DataTable
        Dim dt As New DataTable()
        Try
            ' Consulta SQL corregida (eliminando la columna 'Descuento')
            Dim query As String = "SELECT n.IdNomina, n.IdCed, u.NombreCompleto, n.Mes, n.Año, " &
                                  "n.HorasRegulares, n.HorasExtras, n.PagoHorasRegulares, n.PagoHorasExtras, " &
                                  "n.SeguroSocial, n.SeguroEducativo, n.MontoFinal " &
                                  "FROM Nominas n " &
                                  "JOIN Usuarios u ON n.IdCed = u.IdCed " &
                                  "WHERE u.NombreCompleto LIKE @Nombre"

            Using conn As New SqlConnection(connectionString)
                conn.Open()

                Using cmd As New SqlCommand(query, conn)
                    ' Agregamos el parámetro para el filtro de nombre
                    cmd.Parameters.AddWithValue("@Nombre", "%" & nombre & "%")

                    Dim adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al buscar la nómina por nombre: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Sub CalcularNominaMensual(mes As Integer, año As Integer)
        Try
            ' Consulta para ejecutar el procedimiento almacenado
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand("CalcularNominaMensual", connection)
                    command.CommandType = CommandType.StoredProcedure

                    ' Agregar los parámetros necesarios para el procedimiento almacenado
                    command.Parameters.AddWithValue("@Mes", mes)
                    command.Parameters.AddWithValue("@Año", año)

                    ' Abrir la conexión y ejecutar el procedimiento
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al ejecutar el procedimiento CalcularNominaMensual: " & ex.Message)
        End Try
    End Sub

End Class