<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Icms
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Icms))
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TxtICMdifAliq = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtVlrICM = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtICMded = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtICMsldDev = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtICMsldAnt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtICMestDeb = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtICMoutCred = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtICMcred = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtICMestCred = New System.Windows.Forms.TextBox()
        Me.TxtICMoutDeb = New System.Windows.Forms.TextBox()
        Me.TxtICMDeb = New System.Windows.Forms.TextBox()
        Me.TxtICMcompCons = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Control
        Me.Panel6.Controls.Add(Me.TxtICMdifAliq)
        Me.Panel6.Controls.Add(Me.Label22)
        Me.Panel6.Location = New System.Drawing.Point(6, 51)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(117, 38)
        Me.Panel6.TabIndex = 24
        '
        'TxtICMdifAliq
        '
        Me.TxtICMdifAliq.Enabled = False
        Me.TxtICMdifAliq.Location = New System.Drawing.Point(6, 13)
        Me.TxtICMdifAliq.Name = "TxtICMdifAliq"
        Me.TxtICMdifAliq.Size = New System.Drawing.Size(100, 20)
        Me.TxtICMdifAliq.TabIndex = 4
        Me.TxtICMdifAliq.Text = "0,00"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(3, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(113, 13)
        Me.Label22.TabIndex = 3
        Me.Label22.Text = "Diferencial de Aliquota"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.TxtVlrICM)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.TxtICMded)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.TxtICMsldDev)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Location = New System.Drawing.Point(345, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(105, 115)
        Me.Panel3.TabIndex = 30
        '
        'TxtVlrICM
        '
        Me.TxtVlrICM.Enabled = False
        Me.TxtVlrICM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVlrICM.ForeColor = System.Drawing.Color.Red
        Me.TxtVlrICM.Location = New System.Drawing.Point(2, 91)
        Me.TxtVlrICM.Name = "TxtVlrICM"
        Me.TxtVlrICM.Size = New System.Drawing.Size(100, 20)
        Me.TxtVlrICM.TabIndex = 27
        Me.TxtVlrICM.Text = "0,00"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 75)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(93, 13)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "Impos. a Recolher"
        '
        'TxtICMded
        '
        Me.TxtICMded.Location = New System.Drawing.Point(2, 52)
        Me.TxtICMded.Name = "TxtICMded"
        Me.TxtICMded.Size = New System.Drawing.Size(100, 20)
        Me.TxtICMded.TabIndex = 25
        Me.TxtICMded.Text = "0,00"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 36)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 13)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Deduções"
        '
        'TxtICMsldDev
        '
        Me.TxtICMsldDev.Enabled = False
        Me.TxtICMsldDev.Location = New System.Drawing.Point(2, 13)
        Me.TxtICMsldDev.Name = "TxtICMsldDev"
        Me.TxtICMsldDev.Size = New System.Drawing.Size(100, 20)
        Me.TxtICMsldDev.TabIndex = 23
        Me.TxtICMsldDev.Text = "0,00"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 13)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Saldo Devedor"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.TxtICMsldAnt)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.TxtICMestDeb)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.TxtICMoutCred)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.TxtICMcred)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Location = New System.Drawing.Point(237, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(105, 155)
        Me.Panel2.TabIndex = 29
        '
        'TxtICMsldAnt
        '
        Me.TxtICMsldAnt.Location = New System.Drawing.Point(2, 130)
        Me.TxtICMsldAnt.Name = "TxtICMsldAnt"
        Me.TxtICMsldAnt.Size = New System.Drawing.Size(100, 20)
        Me.TxtICMsldAnt.TabIndex = 20
        Me.TxtICMsldAnt.Text = "0,00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(3, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Saldo Anterior"
        '
        'TxtICMestDeb
        '
        Me.TxtICMestDeb.Location = New System.Drawing.Point(3, 91)
        Me.TxtICMestDeb.Name = "TxtICMestDeb"
        Me.TxtICMestDeb.Size = New System.Drawing.Size(100, 20)
        Me.TxtICMestDeb.TabIndex = 18
        Me.TxtICMestDeb.Text = "0,00"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(3, 75)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 13)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Estorno/Débito"
        '
        'TxtICMoutCred
        '
        Me.TxtICMoutCred.Location = New System.Drawing.Point(2, 52)
        Me.TxtICMoutCred.Name = "TxtICMoutCred"
        Me.TxtICMoutCred.Size = New System.Drawing.Size(100, 20)
        Me.TxtICMoutCred.TabIndex = 16
        Me.TxtICMoutCred.Text = "0,00"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(3, 36)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 13)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Outros Créditos"
        '
        'TxtICMcred
        '
        Me.TxtICMcred.Location = New System.Drawing.Point(2, 13)
        Me.TxtICMcred.Name = "TxtICMcred"
        Me.TxtICMcred.Size = New System.Drawing.Size(100, 20)
        Me.TxtICMcred.TabIndex = 14
        Me.TxtICMcred.Text = "0,00"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Crédito"
        '
        'TxtICMestCred
        '
        Me.TxtICMestCred.Location = New System.Drawing.Point(128, 103)
        Me.TxtICMestCred.Name = "TxtICMestCred"
        Me.TxtICMestCred.Size = New System.Drawing.Size(100, 20)
        Me.TxtICMestCred.TabIndex = 28
        Me.TxtICMestCred.Text = "0,00"
        '
        'TxtICMoutDeb
        '
        Me.TxtICMoutDeb.Location = New System.Drawing.Point(128, 64)
        Me.TxtICMoutDeb.Name = "TxtICMoutDeb"
        Me.TxtICMoutDeb.Size = New System.Drawing.Size(100, 20)
        Me.TxtICMoutDeb.TabIndex = 27
        Me.TxtICMoutDeb.Text = "0,00"
        '
        'TxtICMDeb
        '
        Me.TxtICMDeb.Location = New System.Drawing.Point(128, 25)
        Me.TxtICMDeb.Name = "TxtICMDeb"
        Me.TxtICMDeb.Size = New System.Drawing.Size(100, 20)
        Me.TxtICMDeb.TabIndex = 26
        Me.TxtICMDeb.Text = "0,00"
        '
        'TxtICMcompCons
        '
        Me.TxtICMcompCons.Location = New System.Drawing.Point(6, 25)
        Me.TxtICMcompCons.Name = "TxtICMcompCons"
        Me.TxtICMcompCons.Size = New System.Drawing.Size(117, 20)
        Me.TxtICMcompCons.TabIndex = 23
        Me.TxtICMcompCons.Text = "0,00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(3, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Compras/consumo"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(126, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(105, 115)
        Me.Panel1.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(0, 75)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Estorno/crédito"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(0, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Outros Debitos"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Débito"
        '
        'Frm_Icms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 180)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TxtICMestCred)
        Me.Controls.Add(Me.TxtICMoutDeb)
        Me.Controls.Add(Me.TxtICMDeb)
        Me.Controls.Add(Me.TxtICMcompCons)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Frm_Icms"
        Me.Text = "Calculadora de ICMS (No Lucro Presumido)"
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel6 As Panel
    Friend WithEvents TxtICMdifAliq As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TxtVlrICM As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtICMded As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtICMsldDev As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtICMsldAnt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtICMestDeb As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtICMoutCred As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtICMcred As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtICMestCred As TextBox
    Friend WithEvents TxtICMoutDeb As TextBox
    Friend WithEvents TxtICMDeb As TextBox
    Friend WithEvents TxtICMcompCons As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
End Class
