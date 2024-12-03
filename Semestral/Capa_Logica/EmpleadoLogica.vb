Imports System.Data.SqlClient

Public Class EmpleadoLogica

    Private cnn As New UsuariosDB()

    ' Validar cédula y obtener datos del usuario
    Public Function ValidarUsuario(cedula As String) As String
        If String.IsNullOrEmpty(cedula) Then
            Throw New Exception("La cédula no puede estar vacía.")
        End If

        Dim dt As DataTable = cnn.ObtenerUsuarioPorCedula(cedula)
        If dt.Rows.Count = 0 Then
            Throw New Exception("Usuario no encontrado.")
        End If

        Return dt.Rows(0)("NombreCompleto").ToString()
    End Function


End Class
