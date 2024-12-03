﻿Imports System.Data.SqlClient

Public Class LoginAdministracion

    Private empleadoLogica As New EmpleadoLogica()

    Private Sub LoginAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer.Interval = 1000
        Timer.Start()
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        lblFecha.Text = DateTime.Now.ToString("dddd, dd, MMMM yyyy")
        lblDig1.Text = DateTime.Now.ToString("hh:mm")
    End Sub

    Private Sub btnbIngresa_Click(sender As Object, e As EventArgs) Handles btnbIngresa.Click
        Dim texto As String = txtcedula.Text

        If texto.EndsWith("-") Then
            MessageBox.Show("La cédula no puede terminar con un '-'.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtcedula.Text = texto.TrimStart()
            txtcedula.SelectionStart = txtcedula.Text.Length
            Exit Sub
        End If

        Try
            Dim cedula As String = txtcedula.Text
            Dim nombre As String = empleadoLogica.ValidarUsuario(cedula)

            Me.Hide()

            ' Verificar si el usuario es administrador
            If empleadoLogica.VerificarAccesoAdministrador(cedula) Then
                ' Si es administrador, abrir el panel de administración
                Dim panelAdmin As New PanelAdmin()
                panelAdmin.CargarUsuario(cedula, nombre)
                panelAdmin.Show()
                Me.Hide()  ' Ocultar el formulario de login
            Else
                ' Si no es administrador, mostrar mensaje de error
                MessageBox.Show("Acceso denegado. No tienes permisos de administrador.")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtcedula_TextChanged(sender As Object, e As EventArgs) Handles txtcedula.TextChanged

        Dim texto As String = txtcedula.Text

        If texto.StartsWith(" ") Then
            MessageBox.Show("La cédula no puede comenzar con un espacio en blanco.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtcedula.Text = texto.TrimStart()
            txtcedula.SelectionStart = txtcedula.Text.Length
            Exit Sub
        End If

        If texto.StartsWith("-") Then
            MessageBox.Show("La cédula no puede comenzar con un '-'", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtcedula.Text = texto.TrimStart()
            txtcedula.Text = texto.Replace("-", "")
            txtcedula.SelectionStart = txtcedula.Text.Length
            Exit Sub
        End If

        Dim caracteresValidos As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-"
        For Each c As Char In texto
            If Not caracteresValidos.Contains(c) Then
                MessageBox.Show("La cédula solo puede contener dígitos, letras en mayúscula o el carácter '-'.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtcedula.Text = texto.Remove(texto.Length - 1)
                txtcedula.SelectionStart = txtcedula.Text.Length
                Exit Sub
            End If
        Next

        If texto.Contains("--") Then
            MessageBox.Show("el nombre no puede contener dos espacios consecutivos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtcedula.Text = texto.Replace("--", "-")
            txtcedula.SelectionStart = txtcedula.Text.Length
        End If

    End Sub
End Class