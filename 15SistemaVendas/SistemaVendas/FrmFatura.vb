Public Class FrmFatura

    'limpa os dados gerais da Fatura
    Private Sub limparFatura()
        txtNumero.ResetText()
        txtCliente.ResetText()
        dataFatura.Value = Now
        txtTotal.ResetText()
    End Sub

    'limpa os dados detalhados da Fatura
    Private Sub limparDetalheFatura()
        txtCodProduto.ResetText()
        txtProduto.ResetText()
        txtUnidade.ResetText()
        txtQTD.ResetText()
        txtIVA.ResetText()
        txtPreco.ResetText()
    End Sub

    Private Sub atualizarGrid(ByVal nrFatura As String)

        'faz uma pesquisa conjunta nas tabelas
        Dim cmdSql As String = "SELECT DetalheFatura.CodigoProduto, " &
            "Produtos.Descricao, Produtos.Unidade, DetalheFatura.Quantidade, " &
            "DetalheFatura.ValorUnitario, DetalheFatura.TaxaIVA, " &
            "DetalheFatura.ValorTotal FROM Produtos INNER JOIN " &
            "DetalheFatura ON Produtos.Codigo = DetalheFatura.CodigoProduto " &
            "WHERE NumeroFatura = " & CInt(nrFatura)

        Dim dsDetalhe As DataSet = GerirLigacao.obterDados(cmdSql)

        GrelhaProdutos.DataSource = dsDetalhe.Tables(0)

        If GrelhaProdutos.Rows.Count > 0 Then
            txtCodProduto.Text = dsDetalhe.Tables(0).Rows(0).Item("CodigoProduto")
            txtProduto.Text = dsDetalhe.Tables(0).Rows(0).Item("Descricao")
            txtUnidade.Text = dsDetalhe.Tables(0).Rows(0).Item("Unidade")
            txtQTD.Text = dsDetalhe.Tables(0).Rows(0).Item("Quantidade")
            txtPreco.Text = dsDetalhe.Tables(0).Rows(0).Item("ValorUnitario")
            txtIVA.Text = dsDetalhe.Tables(0).Rows(0).Item("TaxaIva")
            txtValorTotal.Text = dsDetalhe.Tables(0).Rows(0).Item("ValorTotal")

            With GrelhaProdutos
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                With .Columns(0)
                    .HeaderCell.Value = "Cód."
                    .Width = 75
                End With

                With .Columns(1)
                    .HeaderCell.Value = "Descrição"
                    .Width = 275
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                End With

                With .Columns(2)
                    .HeaderCell.Value = "Un."
                    .Width = 75
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                End With

                With .Columns(3)
                    .HeaderCell.Value = "Qtd."
                    .Width = 50
                End With

                With .Columns(4)
                    .HeaderCell.Value = "Preço"
                    .Width = 125
                End With

                With .Columns(5)
                    .HeaderCell.Value = "IVA"
                    .Width = 50
                End With

                With .Columns(6)
                    .HeaderCell.Value = "Sub Total"
                    .Width = 125
                End With

            End With
                Else
            limparDetalheFatura()
        End If
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) _
                Handles btnNovo.Click

        'limpar todos os controlos
        limparFatura()
        limparDetalheFatura()
        GrelhaProdutos.DataSource = Nothing
        txtCliente.Focus()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) _
                Handles btnGuardar.Click

        Dim cmdSql As String
        'verificar se é um novo registo
        If txtNumero.Text = "" Then
            txtValorTotal.Text = 0
            cmdSql = "INSERT INTO Fatura (Cliente, Data, ValorTotal) " &
                "VALUES ('" & txtCliente.Text & "', #" &
                dataFatura.Value.ToString("dd/MM/yyyy") & "#, " &
                Replace(txtValorTotal.Text.ToString, ",", ".") & ")"

            GerirLigacao.ExecutarCmdSQL(cmdSql)

            'selecionar a última linha do registo de faturas
            cmdSql = "SELECT TOP 1 Numero FROM Fatura ORDER BY Numero DESC"
            Dim r As DataSet = GerirLigacao.obterDados(cmdSql)
            txtNumero.Text = r.Tables(0).Rows(0).Item("Numero")
            txtNrFatura.Text = txtNumero.Text

            Dim msg = "Fatura guardada com sucesso."
            Dim titulo = "Guardar"
            Dim botoes = MessageBoxButtons.OK
            Dim icone = MessageBoxIcon.Information
            MessageBox.Show(msg, titulo, botoes, icone)
        Else
            Beep()
        End If

    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) _
                Handles btnFechar.Click

        FrmPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) _
                Handles btnEliminar.Click

        Dim msg = "Confirma a eliminação deste registo de Fatura?"
        Dim titulo = "Eliminar Fatura"
        Dim botoes = MessageBoxButtons.YesNo
        Dim icone = MessageBoxIcon.Question

        If MessageBox.Show(msg, titulo, botoes, icone) = DialogResult.Yes Then

            Dim cmdSql = "DELETE FROM DetalheFatura WHERE NumeroFatura =" &
                txtNrFatura.Text & " AND CodigoProduto = " & txtCodProduto.Text

            GerirLigacao.ExecutarCmdSQL(cmdSql)

            limparFatura()
            limparDetalheFatura()
            GrelhaProdutos.DataSource = Nothing
        End If
    End Sub

    Private Sub btnAdicionarItem_Click(sender As Object, e As EventArgs) _
                Handles btnAdicionarItem.Click

        limparDetalheFatura()
        txtCodProduto.Focus()

    End Sub

    Private Sub btnProcuraProduto_Click(sender As Object, e As EventArgs) _
                Handles btnProcuraProduto.Click

        Dim cmdSql As String = "SELECT * FROM Produtos WHERE Codigo = " &
                (txtCodProduto.Text)

        Dim ds As DataSet = GerirLigacao.obterDados(cmdSql)

        'se existir o produto, passar do DataSet para o form
        If ds.Tables(0).Rows.Count > 0 Then

            txtProduto.Text = ds.Tables(0).Rows(0).Item("Descricao")
            txtUnidade.Text = ds.Tables(0).Rows(0).Item("Unidade")
            txtIVA.Text = ds.Tables(0).Rows(0).Item("TaxaIVA")
            txtPreco.Text = ds.Tables(0).Rows(0).Item("ValorUnitario")
            txtQTD.Text = 0
            txtValorTotal.Text = 0

        Else
            Dim msg = "Código de produto não existente."
            Dim titulo = "Procurar"
            Dim botoes = MessageBoxButtons.OK
            Dim icone = MessageBoxIcon.Information
            MessageBox.Show(msg, titulo, botoes, icone)
        End If

    End Sub

    Private Sub btnProcuraFatura_Click(sender As Object, e As EventArgs) _
                Handles btnProcuraFatura.Click

        'fazer consulta com número de fatura inserida no campo de procura
        Dim cmdSql As String = "SELECT * FROM Fatura WHERE Numero = " &
                CInt(txtNrFatura.Text)

        Dim ds As DataSet = GerirLigacao.obterDados(cmdSql)

        'se existir a fatura, passar do DataSet para o form
        If ds.Tables(0).Rows.Count > 0 Then
            txtNumero.Text = ds.Tables(0).Rows(0).Item("Numero")
            txtCliente.Text = ds.Tables(0).Rows(0).Item("Cliente")
            dataFatura.Value = ds.Tables(0).Rows(0).Item("Data")
            txtTotal.Text = ds.Tables(0).Rows(0).Item("ValorTotal")
            'txtTotal.Text = FormatCurrency(ds.Tables(0).Rows(0).Item("ValorTotal"), 2, TriState.True)

            atualizarGrid(txtNumero.Text)

        Else
            limparFatura()
            limparDetalheFatura()
            Dim msg = "Número de Fatura não encontrada."
            Dim titulo = "Procurar"
            Dim botoes = MessageBoxButtons.OK
            Dim icone = MessageBoxIcon.Information
            MessageBox.Show(msg, titulo, botoes, icone)
        End If

    End Sub

    Private Sub GrelhaProdutos_SelectionChanged(sender As Object, e As EventArgs) _
        Handles GrelhaProdutos.SelectionChanged


        If GrelhaProdutos.RowCount <> 0 Then

            If GrelhaProdutos.SelectedRows.Count > 0 Then
                txtCodProduto.Text = GrelhaProdutos.SelectedRows(0).Cells("CodigoProduto").Value
                txtProduto.Text = GrelhaProdutos.SelectedRows(0).Cells("Descricao").Value
                txtUnidade.Text = GrelhaProdutos.SelectedRows(0).Cells("Unidade").Value
                txtQTD.Text = GrelhaProdutos.SelectedRows(0).Cells("Quantidade").Value
                txtPreco.Text = GrelhaProdutos.SelectedRows(0).Cells("ValorUnitario").Value
                txtIVA.Text = GrelhaProdutos.SelectedRows(0).Cells("TaxaIVA").Value
                txtValorTotal.Text = GrelhaProdutos.SelectedRows(0).Cells("ValorTotal").Value
            Else
                txtCodProduto.Text = GrelhaProdutos.Rows(0).Cells("CodigoProduto").Value
                txtProduto.Text = GrelhaProdutos.Rows(0).Cells("Descricao").Value
                txtUnidade.Text = GrelhaProdutos.Rows(0).Cells("Unidade").Value
                txtQTD.Text = GrelhaProdutos.Rows(0).Cells("Quantidade").Value
                txtPreco.Text = GrelhaProdutos.Rows(0).Cells("ValorUnitario").Value
                txtIVA.Text = GrelhaProdutos.Rows(0).Cells("TaxaIVA").Value
                txtValorTotal.Text = GrelhaProdutos.Rows(0).Cells("ValorTotal").Value
            End If
        End If
    End Sub

    Private Sub txtQTD_TextChanged(sender As Object, e As EventArgs) _
                Handles txtQTD.TextChanged, txtPreco.TextChanged

        'quando a quantidade é alterada o valor total é recalculado
        'quando o preço unitário é alterado o valor total é recalculado
        'atenção o separador de casas decimais (,) que deve ser (.) 
        txtValorTotal.Text =
            CDbl(Replace(txtQTD.Text, ".", ",")) *
            CDbl(Replace(txtPreco.Text, ".", ","))

    End Sub

    Private Sub btnGuardarItem_Click(sender As Object, e As EventArgs) _
            Handles btnGuardarItem.Click

        Dim existe As Boolean
        Dim sSQL As String

        If IsNumeric(txtNrFatura.Text) Then
            For i = 0 To GrelhaProdutos.Rows.Count - 1

                'verifica se o produto já foi adicionado à fatura
                If txtCodProduto.Text =
                    GrelhaProdutos.Rows(i).Cells("CodigoProduto").Value Then

                    'sai do ciclo se encontrou um registo com o produto
                    existe = True
                    Exit For
                End If
            Next

            'se foi encontrado o produto vai atualizar o registo,
            'senão vai inserir um novo registo de detalhe com os
            'valores dos campos do groupbox de produtos 

            If existe Then
                'atualizar o registo 
                sSQL = "UPDATE DetalheFatura SET " &
                    "Quantidade = " & Replace(txtQTD.Text, ",", ".") &
                    ", TaxaIVA = " & CInt(txtIVA.Text) &
                    ", ValorUnitario = " & Replace(txtPreco.Text, ",", ".") &
                    ", ValorTotal = " & Replace(txtValorTotal.Text, ",", ".") &
                    " WHERE NumeroFatura = " & Val(txtNumero.Text) &
                    " AND CodigoProduto = " & Val(txtCodProduto.Text)

            Else
                'inserir novo registo
                If Len(txtProduto.Text) = 0 Then
                    Beep()
                    MsgBox("Beep")
                    Exit Sub
                End If

                sSQL = "INSERT INTO DetalheFatura (NumeroFatura, CodigoProduto, " &
                    " Quantidade, ValorUnitario, TaxaIVA, ValorTotal) VALUES (" &
                    CInt(txtNumero.Text) & ", " &
                    CInt(txtCodProduto.Text) & ", " &
                    CInt(txtQTD.Text) & ", " &
                    Replace(CDbl(txtPreco.Text), ",", ".") & ", " &
                    CInt(txtIVA.Text) & ", " &
                    Replace(CDbl(txtValorTotal.Text), ",", ".") & ")"
            End If

            GerirLigacao.ExecutarCmdSQL(sSQL)

            'saber qual o valor total faturado
            sSQL = "SELECT SUM(ValorTotal) FROM DetalheFatura WHERE NumeroFatura = " &
                CInt(txtNumero.Text)

            Dim r As DataSet = GerirLigacao.obterDados(sSQL)

            'atualizar a futura
            sSQL = "UPDATE Fatura SET ValorTotal = " &
                Replace(r.Tables(0).Rows(0).Item(0).ToString, ",", ".") &
                " WHERE Numero = " & CInt(txtNumero.Text)

            GerirLigacao.ExecutarCmdSQL(sSQL)

            'atualizar valores no formulário
            txtTotal.Text = FormatCurrency(r.Tables(0).Rows(0).Item(0), 2, TriState.True)
            atualizarGrid(txtNumero.Text)

            Dim msg = "Item guardado com sucesso."
            Dim titulo = "Guardar"
            Dim botoes = MessageBoxButtons.OK
            Dim icone = MessageBoxIcon.Information
            MessageBox.Show(msg, titulo, botoes, icone)
        Else
            Beep()
        End If
    End Sub

    Private Sub btnRemoverItem_Click(sender As Object, e As EventArgs) _
                Handles btnRemoverItem.Click

        Dim msg = "Remover este produto do registo de compra?"
        Dim titulo = "Remover"
        Dim botoes = MessageBoxButtons.YesNo
        Dim icone = MessageBoxIcon.Question

        If MessageBox.Show(msg, titulo, botoes, icone) = DialogResult.Yes Then
            Dim sSQL As String
            'elininar o registo de detalhe
            sSQL = "DELETE FROM DetalheFatura WHERE CodigoProduto = " &
                CInt(txtCodProduto.Text) & " AND  NumeroFatura = " &
                CInt(txtNumero.Text)

            GerirLigacao.ExecutarCmdSQL(sSQL)

            sSQL = "SELECT SUM(ValorTotal) FROM DetalheFatura " &
                    "WHERE NumeroFatura = " & CInt(txtNumero.Text)

            Dim r As DataSet = GerirLigacao.obterDados(sSQL)

            'atualizar a fatura
            sSQL = "UPDATE Fatura SET ValorTotal = " &
                Replace(r.Tables(0).Rows(0).Item(0), ",", ".") &
                " WHERE Numero = " & CInt(txtNumero.Text)

            GerirLigacao.ExecutarCmdSQL(sSQL)

            'atualizar valores no formulário
            txtTotal.Text = FormatCurrency(r.Tables(0).Rows(0).Item(0), 2, TriState.True)
            atualizarGrid(txtNumero.Text)

        End If
    End Sub

    Private Sub FrmFatura_Load(sender As Object, e As EventArgs) _
            Handles MyBase.Load

        txtNrFatura.Focus()
    End Sub

End Class