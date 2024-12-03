Public Class RegistrarUsuario

    Private empleado As New EmpleadoLogica()
    Private horarioLogica As New HorarioLogica()


    Private Sub RegistrarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Llenar el ComboBox con los horarios disponibles
            Dim dtHorarios As DataTable = horarioLogica.ObtenerHorarios()
            cmBoxHorario.DataSource = dtHorarios
            cmBoxHorario.DisplayMember = "Descripcion" ' Mostrar descripción
            cmBoxHorario.ValueMember = "IdHorario"    ' Usar IdHorario como valor
            cmBoxHorario.SelectedIndex = -1           ' No seleccionar ningún valor inicialmente
        Catch ex As Exception
            MessageBox.Show("Error al cargar horarios: " & ex.Message)
        End Try
    End Sub

    ' Evento del botón para registrar un empleado
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim texto As String = txtCedula.Text

        If texto.EndsWith("-") Then
            MessageBox.Show("La cédula no puede terminar con un '-'.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCedula.Text = texto.TrimStart()
            txtCedula.SelectionStart = txtCedula.Text.Length
            Exit Sub
        End If

        Try
            If String.IsNullOrEmpty(txtCedula.Text) OrElse
               String.IsNullOrEmpty(txtNombre.Text) OrElse
               String.IsNullOrEmpty(txtSalario.Text) OrElse
               cmBoxContrato.SelectedIndex = -1 OrElse
               cmBoxCargo.SelectedIndex = -1 OrElse
               cmBoxHorario.SelectedIndex = -1 Then
                MessageBox.Show("Por favor, complete todos los campos.")
                Return
            End If

            ' Capturar los datos del formulario
            Dim cedula As String = txtCedula.Text
            Dim nombre As String = txtNombre.Text
            Dim salario As Decimal = Decimal.Parse(txtSalario.Text)

            ' Obtener valores seleccionados de los cmBox
            Dim contrato As String = cmBoxContrato.SelectedItem.ToString()
            Dim cargo As String = cmBoxCargo.SelectedItem.ToString()
            Dim idHorario As Integer = Integer.Parse(cmBoxHorario.SelectedValue.ToString())
            empleado.RegistrarEmpleado(cedula, nombre, salario, contrato, idHorario, cargo)

            MessageBox.Show("Empleado registrado correctamente.")
            LimpiarFormulario()

        Catch ex As FormatException
            MessageBox.Show("Error en el formato de los datos. Verifique los campos numéricos.")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    ' Método para limpiar los campos del formulario
    Private Sub LimpiarFormulario()
        txtCedula.Clear()
        txtNombre.Clear()
        txtSalario.Clear()
        cmBoxContrato.SelectedIndex = -1
        cmBoxCargo.SelectedIndex = -1
        cmBoxHorario.SelectedIndex = -1
    End Sub

    Private Sub txtCedula_TextChanged(sender As Object, e As EventArgs) Handles txtCedula.TextChanged
        Dim texto As String = txtCedula.Text

        If texto.StartsWith(" ") Then
            MessageBox.Show("La cédula no puede comenzar con un espacio en blanco.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCedula.Text = texto.TrimStart()
            txtCedula.SelectionStart = txtCedula.Text.Length
            Exit Sub
        End If

        If texto.StartsWith("-") Then
            MessageBox.Show("La cédula no puede comenzar con un '-'", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCedula.Text = texto.TrimStart()
            txtCedula.Text = texto.Replace("-", "")
            txtCedula.SelectionStart = txtCedula.Text.Length
            Exit Sub
        End If

        Dim caracteresValidos As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-"
        For Each c As Char In texto
            If Not caracteresValidos.Contains(c) Then
                MessageBox.Show("La cédula solo puede contener dígitos, letras en mayúscula o el carácter '-'.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtCedula.Text = texto.Remove(texto.Length - 1)
                txtCedula.SelectionStart = txtCedula.Text.Length
                Exit Sub
            End If
        Next

        If texto.Contains("--") Then
            MessageBox.Show("el nombre no puede contener dos espacios consecutivos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCedula.Text = texto.Replace("--", "-")
            txtCedula.SelectionStart = txtCedula.Text.Length
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        Dim texto As String = txtNombre.Text

        If texto.StartsWith(" ") Then
            MessageBox.Show("El nombre no puede comenzar con un espacio en blanco.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombre.Text = texto.TrimStart()
            txtNombre.SelectionStart = txtNombre.Text.Length
            Exit Sub
        End If

        Dim caracteresValidos As String = " abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
        For Each c As Char In texto
            If Not caracteresValidos.Contains(c) Then
                MessageBox.Show("El nombre solo puede contener dígitos, letras en mayúscula o el carácter '-'.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtNombre.Text = texto.Remove(texto.Length - 1)
                txtNombre.SelectionStart = txtNombre.Text.Length
                Exit Sub
            End If
        Next

        If texto.Contains("  ") Then
            MessageBox.Show("el nombre no puede contener dos espacios consecutivos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombre.Text = texto.Replace("  ", " ")
            txtNombre.SelectionStart = txtNombre.Text.Length
        End If
    End Sub

    Private Sub txtSalario_TextChanged(sender As Object, e As EventArgs) Handles txtSalario.TextChanged
        Dim texto As String = txtSalario.Text

        If texto.StartsWith(" ") Then
            MessageBox.Show("El salario no puede comenzar con un espacio en blanco.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSalario.Text = texto.TrimStart()
            txtSalario.SelectionStart = txtSalario.Text.Length
            Exit Sub
        End If

        If texto.StartsWith(".") Then
            MessageBox.Show("El salario no puede comenzar con un punto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSalario.Text = texto.TrimStart()
            txtSalario.Text = texto.Replace(".", "")
            txtSalario.SelectionStart = txtSalario.Text.Length
            Exit Sub
        End If

        Dim caracteresValidos As String = "0123456789."
        For Each c As Char In texto
            If Not caracteresValidos.Contains(c) Then
                MessageBox.Show("El salario solo puede contener números o '.'", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtSalario.Text = texto.Remove(texto.Length - 1)
                txtSalario.SelectionStart = txtSalario.Text.Length
                Exit Sub
            End If
        Next

        If texto.Contains("..") Then
            MessageBox.Show("el nombre no puede contener dos espacios consecutivos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSalario.Text = texto.Replace("..", ".")
            txtSalario.SelectionStart = txtSalario.Text.Length
        End If
    End Sub

End Class