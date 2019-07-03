Public Class Frm_IRPJ_CSLL
    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        On Error Resume Next
        Dim BASE As Double
        Dim ADICIONAL As Double
        '-------------------------------------------------------------'
        'csll
        TextBoxBaseCSLL.Text = Format(CDbl(TextBoxBCCSLL.Text * (TxtAliquotaBaseCSLL.Text / 100)), "#.#0")
        TextBoxVlrCSLL.Text = Format(CDbl(TextBoxBaseCSLL.Text * (TxtAliquotaCSLL.Text / 100)), "#.#0")
        '-------------------------------------------------------------'
        'irpj
        TextBoxBaseIRPJ.Text = Format(CDbl(TextBoxBCIRPJ.Text * (TxtAliquotaBaseIRPJ.Text / 100)), "#.#0")
        BASE = TextBoxBaseIRPJ.Text * (TxtAliquotaIRPJ.Text / 100)
        ADICIONAL = CDbl((TextBoxBaseIRPJ.Text - 60000) * (TxtAliquotaAdicional.Text / 100))
        TextBoxAdicional10.Text = CDbl(ADICIONAL)
        TextBoxIPIAbatimento.Text = CDbl(TextBoxIPIsobEntradas.Text)
        TextBoxVlrIRPJ.Text = Format(CDbl(((BASE + ADICIONAL) - TextBoxIPIsobEntradas.Text)), "#.#0")

        'Select Case MessageBox.Show("Deseja salvar este cálculo " _
        '    & Microsoft.VisualBasic.ControlChars.CrLf & "na base de dados?", "Salvando....", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        '    Case System.Windows.Forms.DialogResult.Yes
        '        If Len(MaskedTextBoxExercicio.Text) < 7 Then
        '            MsgBox("**Exercício não pode ser vazio!", MsgBoxStyle.Critical, "Atenção!")
        '            MaskedTextBoxExercicio.Focus()
        '        Else
        '            Funcoes.Insert_Update_Delete("insert into NF_BD_IMPOSTOS_TRIMESTRAIS(ID_FILIAL, ID_MES, ANO, TOTAL_BRUTO_VENDAS, IPI_VENDAS, ICMS_RET_VENDAS, TOTAL_DEVOLUCOES, IPI_DEVOLUCOES, ICMS_RET_DEVOLUCOES, IPI_ENTRADAS, BASE_CSLL, BASE_IRPJ, ADICIONAL_10, VLR_IMPOSTO_CSLL, VLR_IMPOSTO_IRPJ) " &
        '                                         "values('40','" & Mid$(MaskedTextBoxExercicio.Text, 1, 2) & "','" & Mid$(MaskedTextBoxExercicio.Text, 4, 4) & "','" & Replace(TextBoxTotalVendas.Text, ",", ".") & "','" &
        '                                                  Replace(TextBoxIPIvendas.Text, ",", ".") & "','" & Replace(TextBoxICMSretVendas.Text, ",", ".") & "','" & Replace(TextBoxTotalDevolucoes.Text, ",", ".") & "','" & Replace(TextBoxIPIDevolucoes.Text, ",", ".") & "','" &
        '                                                  Replace(TextBoxICMSretDevolucoes.Text, ",", ".") & "','" & Replace(TextBoxIPIsobEntradas.Text, ",", ".") & "','" & Replace(TextBoxBaseCSLL.Text, ",", ".") & "','" & Replace(TextBoxBaseIRPJ.Text, ",", ".") & "','" &
        '                                                  Replace(TextBoxAdicional10.Text, ",", ".") & "','" & Replace(TextBoxVlrCSLL.Text, ",", ".") & "','" & Replace(TextBoxVlrIRPJ.Text, ",", ".") & "')")
        '            MsgBox("Salvo com sucesso!", MsgBoxStyle.Information, "Aviso!!!")
        '        End If
        '    Case System.Windows.Forms.DialogResult.No

        'End Select



    End Sub

    Private Sub Frm_IRPJ_CSLL_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send("{Tab}")
    End Sub

    Private Sub TextBoxIPIsobEntradas_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxIPIsobEntradas.GotFocus
        SelecionaTudoNoElemento(TextBoxIPIsobEntradas)
    End Sub

    Private Sub TextBoxIPIsobEntradas_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxIPIsobEntradas.LostFocus
        On Error Resume Next

        TextBoxBCCSLL.Text = ((TextBoxTotalVendas.Text - TextBoxIPIvendas.Text - TextBoxICMSretVendas.Text) - (TextBoxTotalDevolucoes.Text - TextBoxIPIDevolucoes.Text - TextBoxICMSretDevolucoes.Text))
        TextBoxBCIRPJ.Text = ((TextBoxTotalVendas.Text - TextBoxIPIvendas.Text - TextBoxICMSretVendas.Text) - (TextBoxTotalDevolucoes.Text - TextBoxIPIDevolucoes.Text - TextBoxICMSretDevolucoes.Text))
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub TextBoxTotalVendas_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxTotalVendas.GotFocus
        SelecionaTudoNoElemento(TextBoxTotalVendas)
    End Sub

    Private Sub TextBoxIPIvendas_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxIPIvendas.GotFocus
        SelecionaTudoNoElemento(TextBoxIPIvendas)
    End Sub

    Private Sub TextBoxICMSretVendas_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxICMSretVendas.GotFocus
        SelecionaTudoNoElemento(TextBoxICMSretVendas)
    End Sub

    Private Sub TextBoxTotalDevolucoes_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxTotalDevolucoes.GotFocus
        SelecionaTudoNoElemento(TextBoxTotalDevolucoes)
    End Sub

    Private Sub TextBoxIPIDevolucoes_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxIPIDevolucoes.GotFocus
        SelecionaTudoNoElemento(TextBoxIPIDevolucoes)
    End Sub

    Private Sub TextBoxICMSretDevolucoes_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxICMSretDevolucoes.GotFocus
        SelecionaTudoNoElemento(TextBoxICMSretDevolucoes)
    End Sub

    Private Sub Frm_IRPJ_CSLL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MaskedTextBoxExercicio.Focus()
    End Sub

    Private Sub TextBoxTotalVendas_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTotalVendas.TextChanged
        FormataEmDecimalNoElemento(TextBoxTotalVendas)
    End Sub

    Private Sub TextBoxIPIvendas_TextChanged(sender As Object, e As EventArgs) Handles TextBoxIPIvendas.TextChanged
        FormataEmDecimalNoElemento(TextBoxIPIvendas)
    End Sub

    Private Sub TextBoxICMSretVendas_TextChanged(sender As Object, e As EventArgs) Handles TextBoxICMSretVendas.TextChanged
        FormataEmDecimalNoElemento(TextBoxICMSretVendas)
    End Sub

    Private Sub TextBoxTotalDevolucoes_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTotalDevolucoes.TextChanged
        FormataEmDecimalNoElemento(TextBoxTotalDevolucoes)
    End Sub

    Private Sub TextBoxIPIDevolucoes_TextChanged(sender As Object, e As EventArgs) Handles TextBoxIPIDevolucoes.TextChanged
        FormataEmDecimalNoElemento(TextBoxIPIDevolucoes)
    End Sub

    Private Sub TextBoxICMSretDevolucoes_TextChanged(sender As Object, e As EventArgs) Handles TextBoxICMSretDevolucoes.TextChanged
        FormataEmDecimalNoElemento(TextBoxICMSretDevolucoes)
    End Sub

    Private Sub TextBoxIPIsobEntradas_TextChanged(sender As Object, e As EventArgs) Handles TextBoxIPIsobEntradas.TextChanged
        FormataEmDecimalNoElemento(TextBoxIPIsobEntradas)
    End Sub

End Class