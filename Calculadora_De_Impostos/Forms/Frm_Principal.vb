Public Class Frm_Principal
    Private Sub SimplesNacionalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimplesNacionalToolStripMenuItem.Click
        Frm_SimplesNacional.MdiParent = Me
        Frm_SimplesNacional.Show()
    End Sub

    Private Sub PisCofinsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PisCofinsToolStripMenuItem.Click
        Frm_PisCofins.MdiParent = Me
        Frm_PisCofins.Show()
    End Sub

    Private Sub ProtegeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProtegeToolStripMenuItem.Click
        Frm_Protege.MdiParent = Me
        Frm_Protege.Show()
    End Sub

    Private Sub ICMSLucroPresumidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ICMSLucroPresumidoToolStripMenuItem.Click
        Frm_Icms.MdiParent = Me
        Frm_Icms.Show()
    End Sub

    Private Sub IRPJCSLLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IRPJCSLLToolStripMenuItem.Click
        Frm_IRPJ_CSLL.MdiParent = Me
        Frm_IRPJ_CSLL.Show()
    End Sub
End Class