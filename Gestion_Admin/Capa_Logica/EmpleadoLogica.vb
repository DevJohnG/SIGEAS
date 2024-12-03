Imports System.Data.SqlClient


Public Class EmpleadoLogica

    Private empleado As New EmpleadosBD()


    Public Function ValidarUsuario(cedula As String) As String
        If String.IsNullOrEmpty(cedula) Then
            Throw New Exception("La cédula no puede estar vacía.")
        End If

        Dim dt As DataTable = empleado.ObtenerUsuarioPorCedula(cedula)
        If dt.Rows.Count = 0 Then
            Throw New Exception("Usuario no encontrado.")
        End If

        Return dt.Rows(0)("NombreCompleto").ToString()
    End Function

    Public Function ObtenerListaEmpleados(Optional buscar As String = "") As DataTable
        Return empleado.ObtenerEmpleados(buscar)
    End Function

    Public Function VerificarAccesoAdministrador(cedula As String) As Boolean
        Return empleado.VerificarAccesoAdministrador(cedula)
    End Function


    Public Sub RegistrarEmpleado(cedula As String, nombre As String, salario As Decimal, contrato As String, idHorario As Integer, cargo As String)
        If String.IsNullOrEmpty(cedula) OrElse String.IsNullOrEmpty(nombre) OrElse salario <= 0 Then
            Throw New Exception("Todos los campos son obligatorios, y el salario debe ser mayor a 0.")
        End If

        empleado.InsertarEmpleado(cedula, nombre, salario, contrato, idHorario, cargo)
    End Sub

    Public Sub EliminarEmpleado(cedula As String)
        Try
            ' Validar que la cédula no esté vacía
            If String.IsNullOrEmpty(cedula) Then
                Throw New Exception("La cédula no puede estar vacía.")
            End If

            ' Llamar al método de la clase EmpleadosBD para eliminar el empleado
            empleado.EliminarEmpleadoBD(cedula)

        Catch ex As Exception
            Throw New Exception("Error al eliminar el empleado: " & ex.Message)
        End Try
    End Sub


End Class
