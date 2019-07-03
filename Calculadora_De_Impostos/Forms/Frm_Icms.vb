Public Class Frm_Icms
    Public Sub Exec_calcIcms1()
        Try
            TxtICMsldDev.Text = FormatNumber((CDbl(TxtICMDeb.Text) + CDbl(TxtICMoutDeb.Text) + CDbl(TxtICMestCred.Text)) - (CDbl(TxtICMcred.Text) + CDbl(TxtICMoutCred.Text) + CDbl(TxtICMestDeb.Text) + CDbl(TxtICMsldAnt.Text)), 2, TriState.UseDefault)
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub Exec_calcIcms2()
        Try
            TxtVlrICM.Text = "R$ " & FormatNumber(CDbl(TxtICMsldDev.Text) - CDbl(TxtICMded.Text), 2, TriState.UseDefault)
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtICMcompCons_TextChanged(sender As Object, e As EventArgs) Handles TxtICMcompCons.TextChanged
        FormataEmDecimalNoElemento(TxtICMcompCons)
        TxtICMdifAliq.Text = FormatNumber(CDbl(TxtICMcompCons.Text * 0.1), 2, TriState.UseDefault)
    End Sub

    Private Sub TxtICMDeb_TextChanged(sender As Object, e As EventArgs) Handles TxtICMDeb.TextChanged
        FormataEmDecimalNoElemento(TxtICMDeb)
        Exec_calcIcms1()
    End Sub

    Private Sub TxtICMoutDeb_TextChanged(sender As Object, e As EventArgs) Handles TxtICMoutDeb.TextChanged
        FormataEmDecimalNoElemento(TxtICMoutDeb)
        Exec_calcIcms1()
    End Sub

    Private Sub TxtICMestCred_TextChanged(sender As Object, e As EventArgs) Handles TxtICMestCred.TextChanged
        FormataEmDecimalNoElemento(TxtICMestCred)
        Exec_calcIcms1()
    End Sub

    Private Sub TxtICMcred_TextChanged(sender As Object, e As EventArgs) Handles TxtICMcred.TextChanged
        FormataEmDecimalNoElemento(TxtICMcred)
        Exec_calcIcms1()
    End Sub

    Private Sub TxtICMoutCred_TextChanged(sender As Object, e As EventArgs) Handles TxtICMoutCred.TextChanged
        FormataEmDecimalNoElemento(TxtICMoutCred)
        Exec_calcIcms1()
    End Sub

    Private Sub TxtICMestDeb_TextChanged(sender As Object, e As EventArgs) Handles TxtICMestDeb.TextChanged
        FormataEmDecimalNoElemento(TxtICMestDeb)
        Exec_calcIcms1()
    End Sub

    Private Sub TxtICMsldDev_TextChanged(sender As Object, e As EventArgs) Handles TxtICMsldDev.TextChanged
        FormataEmDecimalNoElemento(TxtICMsldDev)
    End Sub

    Private Sub TxtICMded_TextChanged(sender As Object, e As EventArgs) Handles TxtICMded.TextChanged
        FormataEmDecimalNoElemento(TxtICMded)
        Exec_calcIcms2()
    End Sub

    Private Sub TxtVlrICM_TextChanged(sender As Object, e As EventArgs) Handles TxtVlrICM.TextChanged
        FormataEmDecimalNoElemento(TxtVlrICM)
    End Sub

    Private Sub TxtICMsldAnt_TextChanged(sender As Object, e As EventArgs) Handles TxtICMsldAnt.TextChanged
        FormataEmDecimalNoElemento(TxtICMsldAnt)
        Exec_calcIcms1()
    End Sub

    Private Sub Frm_Icms_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send("{Tab}")
    End Sub
End Class