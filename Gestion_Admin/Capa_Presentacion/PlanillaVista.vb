Public Class PlanillaVista

    Private planillaLogica As New PlanillaBD()

    Private Sub PlanillaVista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Obtener los datos de las nóminas desde la capa lógica
            Dim dtNomina As DataTable = planillaLogica.ObtenerNominas()

            ' Verificar si se obtuvieron datos
            If dtNomina IsNot Nothing AndAlso dtNomina.Rows.Count > 0 Then
                ' Asignar los datos al DataGridView
                DataGridViewPlanilla.DataSource = dtNomina
            Else
                MessageBox.Show("No se encontraron registros de nómina.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar las nóminas: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            ' Obtener el nombre desde el TextBox
            Dim nombre As String = txtBuscarEmpleado.Text.Trim()

            ' Llamar al método BuscarNominaPorNombre de la capa lógica
            Dim dtNomina As DataTable = planillaLogica.BuscarNominaPorNombre(nombre)

            ' Verificar si se obtuvieron datos
            If dtNomina IsNot Nothing AndAlso dtNomina.Rows.Count > 0 Then
                ' Asignar los datos al DataGridView
                DataGridViewPlanilla.DataSource = dtNomina
            Else
                MessageBox.Show("No se encontraron registros de nómina para el nombre ingresado.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al buscar la nómina por nombre: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCalcularPlanilla_Click(sender As Object, e As EventArgs) Handles btnCalcularPlanilla.Click

        Dim texto As String = txtAño.Text

        If Not String.IsNullOrEmpty(texto) Then
            Dim anio As Integer = Convert.ToInt32(texto)
            If anio < 2010 OrElse anio > 2024 Then
                MessageBox.Show("El año debe estar entre 2010 y la actualidad.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtAño.Text = ""
                Exit Sub
            End If
        End If

        Try

            Dim mes As Integer = CInt(txtMes.Text)
            Dim año As Integer = CInt(txtAño.Text)
            Dim dtNomina As DataTable = planillaLogica.ObtenerNominas()


            planillaLogica.CalcularNominaMensual(mes, año)
            DataGridViewPlanilla.DataSource = dtNomina

            MessageBox.Show("La nómina ha sido calculada correctamente.")
        Catch ex As Exception
            MessageBox.Show("Error al calcular la nómina: " & ex.Message)
        End Try
    End Sub

    Private Sub btnVerTodos_Click(sender As Object, e As EventArgs) Handles btnVerTodos.Click
        Dim dtNomina As DataTable = planillaLogica.ObtenerNominas()
        DataGridViewPlanilla.DataSource = dtNomina
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

    Private Sub txtMes_TextChanged(sender As Object, e As EventArgs) Handles txtMes.TextChanged
        Dim texto As String = txtMes.Text

        If texto.StartsWith(" ") Then
            MessageBox.Show("La cédula no puede comenzar con un espacio en blanco.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtMes.Text = texto.TrimStart()
            txtMes.SelectionStart = txtMes.Text.Length
            Exit Sub
        End If

        Dim caracteresValidos As String = "0123456789"
        For Each c As Char In texto
            If Not caracteresValidos.Contains(c) Then
                MessageBox.Show("El salario solo puede contener números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtMes.Text = texto.Remove(texto.Length - 1)
                txtMes.SelectionStart = txtMes.Text.Length
                Exit Sub
            End If
        Next

        If Not String.IsNullOrEmpty(texto) Then
            Dim mes As Integer = Convert.ToInt32(texto)
            If mes < 1 OrElse mes > 12 Then
                MessageBox.Show("El mes debe estar entre 1 y 12.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtMes.Text = ""
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtAño_TextChanged(sender As Object, e As EventArgs) Handles txtAño.TextChanged
        Dim texto As String = txtAño.Text

        If texto.StartsWith(" ") Then
            MessageBox.Show("La cédula no puede comenzar con un espacio en blanco.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAño.Text = texto.TrimStart()
            txtAño.SelectionStart = txtAño.Text.Length
            Exit Sub
        End If

        Dim caracteresValidos As String = "0123456789"
        For Each c As Char In texto
            If Not caracteresValidos.Contains(c) Then
                MessageBox.Show("El salario solo puede contener números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtAño.Text = texto.Remove(texto.Length - 1)
                txtAño.SelectionStart = txtAño.Text.Length
                Exit Sub
            End If
        Next

    End Sub
End Class
