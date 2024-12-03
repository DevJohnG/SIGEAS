Public Class HorarioVista

    Private horarioLogica As New HorarioLogica()

    Private Sub HorarioVista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarHorarios()
    End Sub


    ' Método para cargar los horarios en el DataGridView
    Private Sub CargarHorarios()
        Try
            Dim dtHorarios As DataTable = HorarioLogica.ObtenerHorarios()
            DataGridViewHorario.DataSource = dtHorarios
        Catch ex As Exception
            MessageBox.Show("Error al cargar los horarios: " & ex.Message)
        End Try
    End Sub

    ' Evento para agregar un nuevo horario
    Private Sub btnAgregarHorario_Click(sender As Object, e As EventArgs) Handles btnAgregarHorario.Click
        Try
            ' Obtener valores del formulario
            Dim descripcion As String = txtDescripcion.Text.Trim()
            Dim horaInicio As TimeSpan = dtpHoraInicio.Value.TimeOfDay
            Dim horaFin As TimeSpan = dtpHoraFin.Value.TimeOfDay

            ' Validar campos
            If String.IsNullOrEmpty(descripcion) Then
                MessageBox.Show("El nombre del horario es obligatorio.")
                Return
            End If

            If horaInicio >= horaFin Then
                MessageBox.Show("La hora de inicio debe ser menor que la hora de fin.")
                Return
            End If

            ' Llamar a la lógica para insertar el horario
            Dim horarioLogica As New HorarioLogica()
            horarioLogica.InsertarHorario(descripcion, horaInicio, horaFin)

            MessageBox.Show("Horario registrado exitosamente.")
        Catch ex As Exception
            MessageBox.Show("Error al agregar el horario: " & ex.Message)
        End Try
    End Sub

    ' Evento para actualizar los horarios manualmente
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        CargarHorarios()
    End Sub

    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged

        Dim texto As String = txtDescripcion.Text

        If texto.StartsWith(" ") Then
            MessageBox.Show("La descripción no puede comenzar con un espacio en blanco.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDescripcion.Text = texto.TrimStart()
            txtDescripcion.SelectionStart = txtDescripcion.Text.Length
            Exit Sub
        End If

        Dim caracteresValidos As String = " abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
        For Each c As Char In texto
            If Not caracteresValidos.Contains(c) Then
                MessageBox.Show("La descripción solo puede contener dígitos, letras en mayúscula o el carácter '-'.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtDescripcion.Text = texto.Remove(texto.Length - 1)
                txtDescripcion.SelectionStart = txtDescripcion.Text.Length
                Exit Sub
            End If
        Next

        If texto.Contains("  ") Then
            MessageBox.Show("La descripción no puede contener dos espacios consecutivos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDescripcion.Text = texto.Replace("  ", " ")
            txtDescripcion.SelectionStart = txtDescripcion.Text.Length
        End If
    End Sub

End Class