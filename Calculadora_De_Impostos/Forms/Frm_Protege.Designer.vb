<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Protege
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Protege))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TxtProtVenFEstado = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LblCalcProtege = New System.Windows.Forms.Label()
        Me.TxtVlrProtege = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtProtCOut = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtProtVIsen = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TxtAliquotaAdicional = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtAliquotaEstadual = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtAliquotaOutorgado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(275, 187)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.TxtProtVenFEstado)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.Panel5)
        Me.TabPage1.Controls.Add(Me.TxtProtCOut)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(267, 161)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Calcular Protege"
        '
        'TxtProtVenFEstado
        '
        Me.TxtProtVenFEstado.ForeColor = System.Drawing.Color.Black
        Me.TxtProtVenFEstado.Location = New System.Drawing.Point(9, 87)
        Me.TxtProtVenFEstado.Name = "TxtProtVenFEstado"
        Me.TxtProtVenFEstado.Size = New System.Drawing.Size(100, 20)
        Me.TxtProtVenFEstado.TabIndex = 19
        Me.TxtProtVenFEstado.Text = "0,00"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(6, 71)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(101, 13)
        Me.Label21.TabIndex = 18
        Me.Label21.Text = "Vendas fora/estado"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.Controls.Add(Me.LblCalcProtege)
        Me.Panel5.Controls.Add(Me.TxtVlrProtege)
        Me.Panel5.Controls.Add(Me.Label20)
        Me.Panel5.ForeColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(145, 12)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(113, 141)
        Me.Panel5.TabIndex = 17
        '
        'LblCalcProtege
        '
        Me.LblCalcProtege.Location = New System.Drawing.Point(3, 10)
        Me.LblCalcProtege.Name = "LblCalcProtege"
        Me.LblCalcProtege.Size = New System.Drawing.Size(107, 85)
        Me.LblCalcProtege.TabIndex = 2
        Me.LblCalcProtege.Text = "Calculo"
        '
        'TxtVlrProtege
        '
        Me.TxtVlrProtege.Enabled = False
        Me.TxtVlrProtege.Location = New System.Drawing.Point(6, 118)
        Me.TxtVlrProtege.Name = "TxtVlrProtege"
        Me.TxtVlrProtege.Size = New System.Drawing.Size(100, 20)
        Me.TxtVlrProtege.TabIndex = 1
        Me.TxtVlrProtege.Text = "0,00"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(3, 102)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 13)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Valor Protege"
        '
        'TxtProtCOut
        '
        Me.TxtProtCOut.Enabled = False
        Me.TxtProtCOut.ForeColor = System.Drawing.Color.Black
        Me.TxtProtCOut.Location = New System.Drawing.Point(9, 130)
        Me.TxtProtCOut.Name = "TxtProtCOut"
        Me.TxtProtCOut.Size = New System.Drawing.Size(100, 20)
        Me.TxtProtCOut.TabIndex = 16
        Me.TxtProtCOut.Text = "0,00"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(6, 114)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(93, 13)
        Me.Label19.TabIndex = 15
        Me.Label19.Text = "Crédito Outorgado"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtProtVIsen)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(136, 62)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Saídas(Insentas)"
        '
        'TxtProtVIsen
        '
        Me.TxtProtVIsen.Location = New System.Drawing.Point(6, 32)
        Me.TxtProtVIsen.Name = "TxtProtVIsen"
        Me.TxtProtVIsen.Size = New System.Drawing.Size(100, 20)
        Me.TxtProtVIsen.TabIndex = 1
        Me.TxtProtVIsen.Text = "0,00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Valor isentas n/Tributadas"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.TxtAliquotaAdicional)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.TxtAliquotaEstadual)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.TxtAliquotaOutorgado)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(267, 161)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Configuração de Alíquotas"
        '
        'TxtAliquotaAdicional
        '
        Me.TxtAliquotaAdicional.ForeColor = System.Drawing.Color.Black
        Me.TxtAliquotaAdicional.Location = New System.Drawing.Point(6, 97)
        Me.TxtAliquotaAdicional.Name = "TxtAliquotaAdicional"
        Me.TxtAliquotaAdicional.Size = New System.Drawing.Size(44, 20)
        Me.TxtAliquotaAdicional.TabIndex = 16
        Me.TxtAliquotaAdicional.Text = "0,00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(3, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Alíquota Adicional(%)"
        '
        'TxtAliquotaEstadual
        '
        Me.TxtAliquotaEstadual.ForeColor = System.Drawing.Color.Black
        Me.TxtAliquotaEstadual.Location = New System.Drawing.Point(6, 58)
        Me.TxtAliquotaEstadual.Name = "TxtAliquotaEstadual"
        Me.TxtAliquotaEstadual.Size = New System.Drawing.Size(44, 20)
        Me.TxtAliquotaEstadual.TabIndex = 14
        Me.TxtAliquotaEstadual.Text = "17,00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Alíquota Estadual(%)"
        '
        'TxtAliquotaOutorgado
        '
        Me.TxtAliquotaOutorgado.ForeColor = System.Drawing.Color.Black
        Me.TxtAliquotaOutorgado.Location = New System.Drawing.Point(6, 19)
        Me.TxtAliquotaOutorgado.Name = "TxtAliquotaOutorgado"
        Me.TxtAliquotaOutorgado.Size = New System.Drawing.Size(44, 20)
        Me.TxtAliquotaOutorgado.TabIndex = 12
        Me.TxtAliquotaOutorgado.Text = "15,00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Alíquota Crédito Outorgado(%)"
        '
        'Frm_Protege
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 186)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Frm_Protege"
        Me.Text = "Calculadora do Protege"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TxtProtVenFEstado As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents LblCalcProtege As Label
    Friend WithEvents TxtVlrProtege As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TxtProtCOut As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtProtVIsen As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TxtAliquotaOutorgado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtAliquotaEstadual As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtAliquotaAdicional As TextBox
    Friend WithEvents Label3 As Label
End Class
