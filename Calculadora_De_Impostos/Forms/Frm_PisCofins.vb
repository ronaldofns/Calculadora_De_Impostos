Public Class Frm_PisCofins
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Frm_PisCofins_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send("{Tab}")
    End Sub

    Private Sub TxtPISsTvlrSt_GotFocus(sender As Object, e As EventArgs) Handles TxtPISsTvlrSt.GotFocus
        SelecionaTudoNoElemento(TxtPISsTvlrSt)
    End Sub
    Private Sub TxtSTvlrSt_TextChanged(sender As Object, e As EventArgs) Handles TxtPISsTvlrSt.TextChanged
        Try
            FormataEmDecimalNoElemento(TxtPISsTvlrSt)
            If IsNumeric(TxtPisVbc.Text) And IsNumeric(TxtPisVcont.Text) And IsNumeric(TxtPISdevBc.Text) And IsNumeric(TxtPISsTvlrSt.Text) Then
                TxtVlrPIS.Text = FormatNumber((CDbl(TxtPisVcont.Text) - (CDbl(TxtPISdevBc.Text) + CDbl(TxtPISsTvlrSt.Text))) * (TxtAliquotaPis.Text / 100), 2, TriState.UseDefault)
                TxtVlrCofins.Text = FormatNumber((CDbl(TxtPisVcont.Text) - (CDbl(TxtPISdevBc.Text) + CDbl(TxtPISsTvlrSt.Text))) * (TxtAliquotaCofins.Text / 100), 2, TriState.UseDefault)
                Txt_Desoneracao.Text = FormatNumber((CDbl(TxtPisVcont.Text) - (CDbl(TxtPISdevBc.Text) + CDbl(TxtPISsTvlrSt.Text))) * (TxtAliquotaDesoneracao.Text / 100), 2, TriState.True)
            Else
                TxtVlrPIS.Text = "0,00"
                TxtVlrCofins.Text = "0,00"
                Txt_Desoneracao.Text = "0,00"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TxtPisVcont_GotFocus(sender As Object, e As EventArgs) Handles TxtPisVcont.GotFocus
        SelecionaTudoNoElemento(TxtPisVcont)
    End Sub

    Private Sub TxtPisVcont_TextChanged(sender As Object, e As EventArgs) Handles TxtPisVcont.TextChanged
        FormataEmDecimalNoElemento(TxtPisVcont)
        TxtSTvlrSt_TextChanged(sender, e)
    End Sub

    Private Sub TxtPisVbc_GotFocus(sender As Object, e As EventArgs) Handles TxtPisVbc.GotFocus
        SelecionaTudoNoElemento(TxtPisVbc)
    End Sub

    Private Sub TxtPisVbc_TextChanged(sender As Object, e As EventArgs) Handles TxtPisVbc.TextChanged
        FormataEmDecimalNoElemento(TxtPisVbc)
        TxtSTvlrSt_TextChanged(sender, e)
    End Sub

    Private Sub TxtPISdevBc_GotFocus(sender As Object, e As EventArgs) Handles TxtPISdevBc.GotFocus
        SelecionaTudoNoElemento(TxtPISdevBc)
    End Sub

    Private Sub TxtPISdevBc_TextChanged(sender As Object, e As EventArgs) Handles TxtPISdevBc.TextChanged
        Try
            FormataEmDecimalNoElemento(TxtPISdevBc)
            TxtSTvlrSt_TextChanged(sender, e)
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Frm_PisCofins_Load(sender As Object, e As EventArgs) Handles Me.Load
        TxtPisVcont.Focus()
    End Sub
End Class