Public Class FrmPrincipal

    Private Sub FATURASToolStripMenuItem_Click(sender As Object, e As EventArgs) _
            Handles FATURASToolStripMenuItem.Click

        Dim f As New FrmFatura
        Me.Hide()
        f.ShowDialog()

    End Sub

    Private Sub PRODUTOSToolStripMenuItem_Click(sender As Object, e As EventArgs) _
            Handles PRODUTOSToolStripMenuItem.Click

        Dim f As New FrmProduto
        Me.Hide()
        f.ShowDialog()

    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) _
                Handles MyBase.Load

        GerirLigacao.IniciarLigacao(My.Settings.VendasDBConnectionString)

    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) _
            Handles SairToolStripMenuItem.Click

        Application.Exit()

    End Sub

    Private Sub FrmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        MySplash.Close()

    End Sub
End Class
