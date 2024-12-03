
Public Class EmpleadosVista

    Private empleado As New EmpleadoLogica()

    Private Sub EmpleadosVista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarEmpleados("")
    End Sub

    Private Sub CargarEmpleados(buscar As String)
        Try
            ' Obtener la lista de empleados desde la lógica, con o sin filtro
            Dim dtEmpleados As DataTable = empleado.ObtenerListaEmpleados(buscar)

            ' Verificar si se obtuvieron datos
            If dtEmpleados IsNot Nothing AndAlso dtEmpleados.Rows.Count > 0 Then
                DataGridViewEmpleados.DataSource = dtEmpleados
            Else
                MessageBox.Show("No se encontraron empleados.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar los empleados: " & ex.Message)
        End Try
    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim buscar As String = txtBuscarEmpleado.Text.Trim()
        CargarEmpleados(buscar)
    End Sub

    Private Sub btnVerTodos_Click(sender As Object, e As EventArgs) Handles btnVerTodos.Click
        CargarEmpleados("")
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Dim texto As String = txtCedUser.Text

        If texto.EndsWith("-") Then
            MessageBox.Show("La cédula no puede terminar con un '-'.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCedUser.Text = texto.TrimStart()
            txtCedUser.SelectionStart = txtCedUser.Text.Length
            Exit Sub
        End If

        Try
            ' Obtener la cédula ingresada
            Dim cedula As String = txtCedUser.Text.Trim()

            ' Verificar si se ingresó una cédula
            If String.IsNullOrEmpty(cedula) Then
                MessageBox.Show("Por favor, ingrese una cédula válida.")
                Return
            End If

            ' Llamar al método de lógica para eliminar al empleado
            empleado.EliminarEmpleado(cedula)

            ' Mostrar mensaje de éxito
            MessageBox.Show("Empleado eliminado correctamente.")

            ' Recargar la tabla de empleados
            CargarEmpleados("") ' Vacío para cargar todos los empleados

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub txtBuscarEmpleado_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarEmpleado.TextChanged
        Dim texto As String = txtBuscarEmpleado.Text

        If texto.StartsWith(" ") Then
            MessageBox.Show("El nombre no puede comenzar con un espacio en blanco.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBuscarEmpleado.Text = texto.TrimStart()
            txtBuscarEmpleado.SelectionStart = txtBuscarEmpleado.Text.Length
            Exit Sub
        End If

        Dim caracteresValidos As String = " abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
        For Each c As Char In texto
            If Not caracteresValidos.Contains(c) Then
                MessageBox.Show("El nombre solo puede contener dígitos, letras en mayúscula o el carácter '-'.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtBuscarEmpleado.Text = texto.Remove(texto.Length - 1)
                txtBuscarEmpleado.SelectionStart = txtBuscarEmpleado.Text.Length
                Exit Sub
            End If
        Next

        If texto.Contains("  ") Then
            MessageBox.Show("el nombre no puede contener dos espacios consecutivos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBuscarEmpleado.Text = texto.Replace("  ", " ")
            txtBuscarEmpleado.SelectionStart = txtBuscarEmpleado.Text.Length
        End If
    End Sub

    Private Sub txtCedUser_TextChanged(sender As Object, e As EventArgs) Handles txtCedUser.TextChanged
        Dim texto As String = txtCedUser.Text

        If texto.StartsWith(" ") Then
            MessageBox.Show("La cédula no puede comenzar con un espacio en blanco.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCedUser.Text = texto.TrimStart()
            txtCedUser.SelectionStart = txtCedUser.Text.Length
            Exit Sub
        End If

        If texto.StartsWith("-") Then
            MessageBox.Show("La cédula no puede comenzar con un '-'", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCedUser.Text = texto.TrimStart()
            txtCedUser.Text = texto.Replace("-", "")
            txtCedUser.SelectionStart = txtCedUser.Text.Length
            Exit Sub
        End If

        Dim caracteresValidos As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-"
        For Each c As Char In texto
            If Not caracteresValidos.Contains(c) Then
                MessageBox.Show("La cédula solo puede contener dígitos, letras en mayúscula o el carácter '-'.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtCedUser.Text = texto.Remove(texto.Length - 1)
                txtCedUser.SelectionStart = txtCedUser.Text.Length
                Exit Sub
            End If
        Next

        If texto.Contains("--") Then
            MessageBox.Show("el nombre no puede contener dos espacios consecutivos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCedUser.Text = texto.Replace("--", "-")
            txtCedUser.SelectionStart = txtCedUser.Text.Length
        End If

    End Sub

End Class