Public Class MySplash

    Dim MyTimer As Integer

    Private Sub MySplash_Load(sender As Object, e As EventArgs) Handles Me.Load

        TimerControl.Start()

    End Sub

    Private Sub TimerControl_Tick(sender As Object, e As EventArgs) Handles TimerControl.Tick

        MyTimer += 1
        Me.Opacity -= 0.05
        If MyTimer = 3 Then
            Me.Hide() 'esconder este form
            FrmPrincipal.Show() 'mostrar o form da aplicação
            TimerControl.Stop()
        End If

    End Sub
End Class