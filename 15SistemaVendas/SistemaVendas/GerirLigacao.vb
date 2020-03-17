Imports System.Data.OleDb

Public Class GerirLigacao

    'declarar um objeto privado e estático para definir a ligação
    Private Shared ligacao As New OleDbConnection

    'declarar um procedimento público para iniciar a ligação
    Public Shared Sub IniciarLigacao(ByVal DadosLigacao As String)

        ligacao = New OleDbConnection(DadosLigacao)
        ligacao.Open()

    End Sub

    'declarar um procedimento público para executar o comando SQL
    Public Shared Sub ExecutarCmdSQL(ByVal comando As String)

        Try
            Dim cmdSql As New OleDbCommand(comando, ligacao)
            cmdSql.ExecuteNonQuery()

        Catch ex As Exception
            Dim msg = "Aconteceu um erro de execução." & vbNewLine & comando & vbNewLine
            Dim botoes = MessageBoxButtons.OK
            Dim icone = MessageBoxIcon.Error
            MessageBox.Show(msg & ex.Message, "ERRO", botoes, icone)
        End Try

    End Sub

    'declarar função que vai obter os dados resultantes do comando SQL 
    Public Shared Function obterDados(ByVal comando As String) As DataSet

        Dim resultado As New DataSet
        Try
            Dim adaptador As New OleDbDataAdapter(comando, ligacao)
            'passa os dados da instrução sql para o resultado
            adaptador.Fill(resultado)
            adaptador.Dispose()

        Catch ex As Exception
            Dim msg = "Aconteceu um erro ao obter dados." & vbNewLine & comando & vbNewLine
            Dim botoes = MessageBoxButtons.OK
            Dim icone = MessageBoxIcon.Error
            MessageBox.Show(msg & ex.Message, "ERRO", botoes, icone)
        End Try

        Return resultado
    End Function

    Public Shared Sub atualizarGrelha(ByVal comando As String,
                                      ByVal grid As DataGridView)

        Dim resultado As New DataTable()
        Try
            Dim adaptador As New OleDbDataAdapter(comando, ligacao)
            'passa os dados da instrução sql para o resultado
            adaptador.Fill(resultado)
            adaptador.Dispose()
            grid.DataSource = resultado.DefaultView

        Catch ex As Exception
            Dim msg = "Aconteceu um erro ao exibir dados." & vbNewLine & comando & vbNewLine
            Dim botoes = MessageBoxButtons.OK
            Dim icone = MessageBoxIcon.Error
            MessageBox.Show(msg & ex.Message, "ERRO", botoes, icone)
        End Try

    End Sub

End Class

