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

            Dim loginForm As New Login()
            loginForm.Show()
        End If

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class