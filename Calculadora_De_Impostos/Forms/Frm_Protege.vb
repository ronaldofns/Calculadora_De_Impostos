Public Class Frm_Protege
    Private Sub Frm_Protege_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Exec_calcProtege()
        Try
            LblCalcProtege.Text = CStr("Exemplo calculo 1 " & FormatNumber(((CDbl(TxtProtVIsen.Text) * (TxtAliquotaEstadual.Text / 100)) * (TxtAliquotaOutorgado.Text / 100)), 2, TriState.UseDefault) &
                Microsoft.VisualBasic.Chr(13) & "Exemplo calculo 2 " & Microsoft.VisualBasic.Chr(13) & FormatNumber((CDbl(TxtProtCOut.Text) * (TxtAliquotaOutorgado.Text / 100)), 2, TriState.UseDefault))
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TxtProtVIsen_TextChanged(sender As Object, e As EventArgs) Handles TxtProtVIsen.TextChanged
        Try
            FormataEmDecimalNoElemento(TxtProtVIsen)
            Exec_calcProtege()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TxtProtVenFEstado_TextChanged(sender As Object, e As EventArgs) Handles TxtProtVenFEstado.TextChanged
        Try
            FormataEmDecimalNoElemento(TxtProtVenFEstado)
            TxtProtCOut_TextChanged(sender, e)
            Exec_calcProtege()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TxtProtCOut_TextChanged(sender As Object, e As EventArgs) Handles TxtProtCOut.TextChanged
        Try
            FormataEmDecimalNoElemento(TxtProtCOut)
            TxtProtCOut.Text = FormatNumber((CDbl(TxtProtVenFEstado.Text) * (TxtAliquotaAdicional.Text / 100)), 2, TriState.UseDefault)
            TxtVlrProtege.Text = FormatCurrency(((CDbl(TxtProtVIsen.Text) * (TxtAliquotaEstadual.Text / 100)) * (TxtAliquotaOutorgado.Text / 100)) + (CDbl(TxtProtCOut.Text) * (TxtAliquotaOutorgado.Text / 100)), 2, TriState.UseDefault)
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TxtVlrProtege_TextChanged(sender As Object, e As EventArgs) Handles TxtVlrProtege.TextChanged
        FormataEmDecimalNoElemento(TxtVlrProtege)
    End Sub

    Private Sub Frm_Protege_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send("{Tab}")
    End Sub

    Private Sub TxtAliquotaOutorgado_TextChanged(sender As Object, e As EventArgs) Handles TxtAliquotaOutorgado.TextChanged
        FormataEmDecimalNoElemento(TxtAliquotaOutorgado)
    End Sub

    Private Sub TxtAliquotaEstadual_TextChanged(sender As Object, e As EventArgs) Handles TxtAliquotaEstadual.TextChanged
        FormataEmDecimalNoElemento(TxtAliquotaEstadual)
    End Sub

    Private Sub TxtAliquotaAdicional_TextChanged(sender As Object, e As EventArgs) Handles TxtAliquotaAdicional.TextChanged
        FormataEmDecimalNoElemento(TxtAliquotaAdicional)
    End Sub
End Class