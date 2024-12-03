Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class index
    Private Sub index_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar1.Increment(10)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            Me.Hide()

            Dim loginForm As New LoginAdministracion()
            loginForm.Show()
        End If

    End Sub

End Class