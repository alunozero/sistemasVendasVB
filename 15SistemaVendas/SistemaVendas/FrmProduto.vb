Public Class FrmProduto

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) _
                    Handles btnFechar.Click
        FrmPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) _
                    Handles btnNovo.Click

        'limpar todos os controlos
        limparRegisto()

        ''preencher a grelha com os produtos
        'atualizarGrid()

    End Sub

    Private Sub limparRegisto()
        txtCodigo.ResetText()
        txtDescricao.ResetText()
        cbUnidade.SelectedIndex = -1
        cbIVA.SelectedIndex = -1
        txtPreco.ResetText()
        txtDescricao.Focus()
    End Sub

    Private Sub atualizarGrid()
        Dim cmdSql As String = "SELECT * FROM Produtos"
        Dim dsRegistos As DataSet = GerirLigacao.obterDados(cmdSql)
        GrelhaProdutos.DataSource = dsRegistos.Tables(0)
    End Sub

    Private Sub FrmProduto_Load(sender As Object, e As EventArgs) _
                Handles MyBase.Load

        'limpar todos os controlos
        limparRegisto()
        'preencher a grelha com os produtos
        atualizarGrid()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) _
                Handles btnGuardar.Click

        Dim cmdSql As String
        Dim msg As String = ""
        'MsgBox(Val(txtCodigo.Text))

        'verificar os controlos estão devidamente preenchidos
        If Len(txtDescricao.Text) > 2 And cbUnidade.SelectedItem <> "" And
            cbIVA.SelectedItem <> "" And Val(txtPreco.Text) > 0 Then


            'verificar se é um novo registo através do numero contido no controlo
            If Val(txtCodigo.Text) = 0 Then
                cmdSql = "INSERT INTO Produtos (Descricao, Unidade, TaxaIva, ValorUnitario) " &
                     "VALUES ('" & txtDescricao.Text & "', '" &
                                   cbUnidade.SelectedItem & "', '" &
                                   Val(cbIVA.SelectedItem) & "', " &
                                   Replace(txtPreco.Text.ToString, ",", ".") & ")"

                msg = "Inserido novo produto com sucesso."

            Else
                'através do numero contido no controlo atualizar o registo do produto
                cmdSql = "UPDATE Produtos SET " &
                            "Descricao = '" & txtDescricao.Text & "'" &
                            ", Unidade = '" & cbUnidade.SelectedItem & "'" &
                            ", TaxaIVA = " & Val(cbIVA.SelectedItem) &
                            ", ValorUnitario = " & Replace(txtPreco.Text, ",", ".") &
                            " WHERE Codigo = " & Val(txtCodigo.Text)

                msg = "Atualizado registo do produto com sucesso."

            End If

            GerirLigacao.ExecutarCmdSQL(cmdSql)

            Dim titulo = "Guardar"
            Dim botoes = MessageBoxButtons.OK
            Dim icone = MessageBoxIcon.Information
            MessageBox.Show(msg, titulo, botoes, icone)

        Else
            Beep()
        End If

        atualizarGrid()

    End Sub

    Private Sub GrelhaProdutos_SelectionChanged(sender As Object, e As EventArgs) _
            Handles GrelhaProdutos.SelectionChanged

        If GrelhaProdutos.RowCount <> 0 Then
            If GrelhaProdutos.SelectedRows.Count > 0 Then
                txtCodigo.Text = GrelhaProdutos.SelectedRows(0).Cells("Codigo").Value
                txtDescricao.Text = GrelhaProdutos.SelectedRows(0).Cells("Descricao").Value
                cbUnidade.SelectedItem = GrelhaProdutos.SelectedRows(0).Cells("Unidade").Value
                cbIVA.SelectedItem = GrelhaProdutos.SelectedRows(0).Cells("TaxaIVA").Value.ToString
                txtPreco.Text = GrelhaProdutos.SelectedRows(0).Cells("ValorUnitario").Value
            Else
                txtCodigo.Text = GrelhaProdutos.Rows(0).Cells("Codigo").Value
                txtDescricao.Text = GrelhaProdutos.Rows(0).Cells("Descricao").Value
                cbUnidade.SelectedItem = GrelhaProdutos.Rows(0).Cells("Unidade").Value
                cbIVA.SelectedItem = GrelhaProdutos.Rows(0).Cells("TaxaIVA").Value.ToString
                txtPreco.Text = GrelhaProdutos.Rows(0).Cells("ValorUnitario").Value
            End If
        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) _
                Handles btnEliminar.Click
        'será necessário verificar se foi faturado algum produto
        Dim msg As String = ""
        Dim titulo = "Eliminar"
        Dim botoes = MessageBoxButtons.OK

        Dim codigo As Integer = Val(txtCodigo.Text)
        Dim produto As String = txtDescricao.Text
        Dim cmdSql As String
        If codigo > 0 Then
            cmdSql = "SELECT NumeroFatura, CodigoProduto FROM DetalheFatura " &
                        "WHERE CodigoProduto = " & codigo

            Dim ds As DataSet = GerirLigacao.obterDados(cmdSql)

            'saber o numero de registos devolvidos
            If ds.Tables(0).Rows.Count = 0 Then
                'preparar para eliminar
                msg = "Deseja eliminar o produto " & codigo & " " & produto & "?"
                botoes = MessageBoxButtons.YesNo
                Dim icone = MessageBoxIcon.Question

                If MessageBox.Show(msg, titulo, botoes, icone) = DialogResult.Yes Then
                    'eliminar após confirmação
                    cmdSql = "DELETE FROM Produtos WHERE Codigo = " & codigo
                    GerirLigacao.ExecutarCmdSQL(cmdSql)
                    atualizarGrid()
                End If

            Else
                'já existem registos de faturas
                msg = "Não é possível eliminar " & codigo & " " &
                    produto & "." & vbNewLine &
                    "Existem registos de faturação efetuatos para o produto."
                Dim icone = MessageBoxIcon.Warning
                MessageBox.Show(msg, titulo, botoes, icone)

            End If
        Else
            'nenhum registo de produto selecionado para eliminar
            msg = "Não foi selecionado nenhum registo para eliminar."
            Dim icone = MessageBoxIcon.Exclamation
            MessageBox.Show(msg, titulo, botoes, icone)
        End If
    End Sub
End Class