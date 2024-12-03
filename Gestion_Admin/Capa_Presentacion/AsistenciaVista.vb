Public Class AsistenciaVista

    Private asistenciasLogica As New AsistenciasLogica()
    Private Sub AsistenciaVista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarAsistencias()
    End Sub

    Private Sub AsisteniaVista_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtpFecha.MinDate = New Date(2010, 1, 1)
        dtpFecha.MaxDate = Date.Now
        dtpFecha.Value = Date.Now
    End Sub


    ' Cargar todas las asistencias en el dt
    Private Sub CargarAsistencias()
        Try
            Dim dt As DataTable = AsistenciasLogica.ObtenerTodasLasAsistencias()

            ' Verificar si los datos se obtuvieron correctamente
            If dt.Rows.Count > 0 Then
                DataGridViewAsistencias.DataSource = dt
            Else
                MessageBox.Show("No se encontraron asistencias.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar asistencias: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBuscarNombre_Click(sender As Object, e As EventArgs) Handles btnBuscarNombre.Click
        Try
            Dim nombreEmpleado As String = txtBuscarEmpleado.Text.Trim()

            ' Verificar si el nombre no está vacío
            If String.IsNullOrEmpty(nombreEmpleado) Then
                MessageBox.Show("Por favor ingrese un nombre para buscar.")
                Return
            End If

            Dim dt As DataTable = asistenciasLogica.BuscarAsistenciaPorNombre(nombreEmpleado)

            ' Verificar si los datos se obtuvieron correctamente
            If dt.Rows.Count > 0 Then
                DataGridViewAsistencias.DataSource = dt
            Else
                MessageBox.Show("No se encontraron asistencias para el nombre ingresado.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al buscar asistencia: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBuscarFecha_Click(sender As Object, e As EventArgs) Handles btnBuscarFecha.Click
        Try
            Dim fecha As Date = dtpFecha.Value
            Dim dt As DataTable = asistenciasLogica.BuscarAsistenciaPorFecha(fecha)

            ' Verificar si los datos se obtuvieron correctamente
            If dt.Rows.Count > 0 Then
                DataGridViewAsistencias.DataSource = dt
            Else
                MessageBox.Show("No se encontraron asistencias para la fecha ingresada.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al buscar asistencia por fecha: " & ex.Message)
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

End Class