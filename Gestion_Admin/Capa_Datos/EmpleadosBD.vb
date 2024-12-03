Imports System.Data.SqlClient

Public Class EmpleadosBD


    Private connectionString As String = "Data Source=JOHN;Initial Catalog=SIGEAS;Integrated Security=True"
    Public Function ObtenerEmpleados(Optional buscar As String = "") As DataTable
        Dim dt As New DataTable()
        Dim query As String

        ' Si se proporciona un término de búsqueda, usamos LIKE para filtrar por nombre
        If String.IsNullOrEmpty(buscar) Then
            query = "SELECT IdCed AS Cédula, NombreCompleto AS Nombre, SalarioBase AS Salario, TipoContrato AS Contrato, Cargo, Turno AS Turno, IdHorario AS Horario, FechaRegistro As Fecha_de_Registro  FROM Usuarios"
        Else
            query = "SELECT IdCed AS Cédula, NombreCompleto AS Nombre, SalarioBase AS Salario, TipoContrato AS Contrato, Cargo, Turno AS Turno, IdHorario AS Horario, FechaRegistro AS Fecha_de_Registro FROM Usuarios WHERE NombreCompleto LIKE @Buscar"
        End If

        Try
            Using connection As New SqlConnection(connectionString)
                Dim command As New SqlCommand(query, connection)

                ' Si hay un término de búsqueda, agregamos el parámetro
                If Not String.IsNullOrEmpty(buscar) Then
                    command.Parameters.AddWithValue("@Buscar", "%" & buscar & "%")
                End If

                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(dt)
            End Using
        Catch ex As SqlException
            Throw New Exception("Error al obtener la lista de empleados: " & ex.Message)
        End Try

        Return dt
    End Function




    Public Function ObtenerEmpleadosPorNombre(Optional buscar As String = "") As DataTable
        Dim dt As New DataTable()

        ' Definir la consulta SQL
        Dim query As String

        ' Si se proporciona un término de búsqueda, usamos LIKE para filtrar por nombre
        If String.IsNullOrEmpty(buscar) Then
            query = "SELECT IdCed, NombreCompleto, Cargo, TipoContrato FROM Usuarios"
        Else
            query = "SELECT IdCed, NombreCompleto, Cargo, TipoContrato FROM Usuarios WHERE NombreCompleto LIKE @Buscar"
        End If

        ' Conexión y ejecución de la consulta
        Try
            Using connection As New SqlConnection(connectionString)
                Dim command As New SqlCommand(query, connection)

                ' Si hay un término de búsqueda, agregamos el parámetro
                If Not String.IsNullOrEmpty(buscar) Then
                    command.Parameters.AddWithValue("@Buscar", "%" & buscar & "%")
                End If

                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(dt)
            End Using
        Catch ex As SqlException
            Throw New Exception("Error al obtener la lista de empleados: " & ex.Message)
        End Try

        Return dt
    End Function

    ' Obtener datos del usuario por cédula
    Public Function ObtenerUsuarioPorCedula(cedula As String) As DataTable
            Dim dt As New DataTable()
            Try
                Using connection As New SqlConnection(connectionString)
                    Dim query As String = "SELECT NombreCompleto FROM Usuarios WHERE IdCed = @Cedula"
                    Dim command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Cedula", cedula)
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(dt)
                End Using
            Catch ex As SqlException
                Throw New Exception("Error al obtener el usuario: " & ex.Message)
            End Try
            Return dt
        End Function
    Public Function VerificarAccesoAdministrador(cedula As String) As Boolean
        Try
            Using connection As New SqlConnection(connectionString)
                Dim cmd As New SqlCommand("VerificarAccesoAdministrador", connection)
                cmd.CommandType = CommandType.StoredProcedure

                ' Agregar parámetro
                cmd.Parameters.AddWithValue("@IdCed", cedula)

                ' Abrir conexión y ejecutar
                connection.Open()

                ' Leer el valor de la respuesta (1 o 0)
                Dim acceso As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                ' Si acceso es 1, es un administrador
                If acceso = 1 Then
                    Return True
                Else
                    Return False
                End If
            End Using
        Catch ex As SqlException
            Throw New Exception("Error al verificar acceso: " & ex.Message)
        End Try
    End Function

    ' Método para insertar un nuevo empleado en la base de datos
    Public Sub InsertarEmpleado(cedula As String, nombre As String, salario As Decimal, contrato As String, idHorario As Integer, cargo As String)
        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "INSERT INTO Usuarios (IdCed, NombreCompleto, SalarioBase, TipoContrato, IdHorario, Cargo) " &
                                      "VALUES (@Cedula, @Nombre, @Salario, @Contrato, @IdHorario, @Cargo)"
                Dim command As New SqlCommand(query, connection)

                ' Agregar parámetros para prevenir inyección SQL
                command.Parameters.AddWithValue("@Cedula", cedula)
                command.Parameters.AddWithValue("@Nombre", nombre)
                command.Parameters.AddWithValue("@Salario", salario)
                command.Parameters.AddWithValue("@Contrato", contrato)
                command.Parameters.AddWithValue("@IdHorario", idHorario)
                command.Parameters.AddWithValue("@Cargo", cargo)

                ' Abrir conexión y ejecutar consulta
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        Catch ex As SqlException
            Throw New Exception("Error al registrar empleado: " & ex.Message)
        End Try
    End Sub

    Public Sub EliminarEmpleadoBD(cedula As String)
        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "DELETE FROM Usuarios WHERE IdCed = @Cedula"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Cedula", cedula)
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected = 0 Then
                        Throw New Exception("No se encontró un empleado con la cédula ingresada.")
                    End If
                End Using
            End Using
        Catch ex As SqlException
            Throw New Exception("Error al eliminar empleado: " & ex.Message)
        End Try
    End Sub

End Class
