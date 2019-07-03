<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_PisCofins
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_PisCofins))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Txt_Desoneracao = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.TxtVlrCofins = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtVlrPIS = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtPISsTvlrSt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtPISdevBc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtPisVbc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPisVcont = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TxtAliquotaDesoneracao = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtAliquotaCofins = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtAliquotaPis = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.TabControl1.Size = New System.Drawing.Size(499, 218)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.Panel4)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(491, 192)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Pis/Cofins"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Txt_Desoneracao)
        Me.Panel4.Controls.Add(Me.Label38)
        Me.Panel4.Controls.Add(Me.TxtVlrCofins)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.TxtVlrPIS)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Location = New System.Drawing.Point(3, 74)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(282, 113)
        Me.Panel4.TabIndex = 11
        '
        'Txt_Desoneracao
        '
        Me.Txt_Desoneracao.Enabled = False
        Me.Txt_Desoneracao.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Txt_Desoneracao.Location = New System.Drawing.Point(154, 21)
        Me.Txt_Desoneracao.Name = "Txt_Desoneracao"
        Me.Txt_Desoneracao.Size = New System.Drawing.Size(121, 29)
        Me.Txt_Desoneracao.TabIndex = 17
        Me.Txt_Desoneracao.Text = "0,00"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(151, 5)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(100, 13)
        Me.Label38.TabIndex = 16
        Me.Label38.Text = "Desoneração Folha"
        '
        'TxtVlrCofins
        '
        Me.TxtVlrCofins.Enabled = False
        Me.TxtVlrCofins.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.TxtVlrCofins.Location = New System.Drawing.Point(6, 77)
        Me.TxtVlrCofins.Name = "TxtVlrCofins"
        Me.TxtVlrCofins.Size = New System.Drawing.Size(130, 29)
        Me.TxtVlrCofins.TabIndex = 15
        Me.TxtVlrCofins.Text = "0,00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Valor Cofins"
        '
        'TxtVlrPIS
        '
        Me.TxtVlrPIS.Enabled = False
        Me.TxtVlrPIS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.TxtVlrPIS.Location = New System.Drawing.Point(6, 21)
        Me.TxtVlrPIS.Name = "TxtVlrPIS"
        Me.TxtVlrPIS.Size = New System.Drawing.Size(130, 29)
        Me.TxtVlrPIS.TabIndex = 13
        Me.TxtVlrPIS.Text = "0,00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Valor PIS"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.TxtPISsTvlrSt)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(350, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(129, 62)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Subs. Tributaria (Total)"
        '
        'TxtPISsTvlrSt
        '
        Me.TxtPISsTvlrSt.Location = New System.Drawing.Point(6, 32)
        Me.TxtPISsTvlrSt.Name = "TxtPISsTvlrSt"
        Me.TxtPISsTvlrSt.Size = New System.Drawing.Size(100, 20)
        Me.TxtPISsTvlrSt.TabIndex = 10
        Me.TxtPISsTvlrSt.Text = "0,00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Valor ST"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TxtPISdevBc)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(228, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(116, 62)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Devoluçoes(Total)"
        '
        'TxtPISdevBc
        '
        Me.TxtPISdevBc.Location = New System.Drawing.Point(6, 32)
        Me.TxtPISdevBc.Name = "TxtPISdevBc"
        Me.TxtPISdevBc.Size = New System.Drawing.Size(100, 20)
        Me.TxtPISdevBc.TabIndex = 7
        Me.TxtPISdevBc.Text = "0,00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Valor Base de Cálculo"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TxtPisVbc)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtPisVcont)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(219, 62)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vendas (Total)"
        '
        'TxtPisVbc
        '
        Me.TxtPisVbc.Location = New System.Drawing.Point(112, 32)
        Me.TxtPisVbc.Name = "TxtPisVbc"
        Me.TxtPisVbc.Size = New System.Drawing.Size(100, 20)
        Me.TxtPisVbc.TabIndex = 4
        Me.TxtPisVbc.Text = "0,00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(109, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Valor Base de Cálculo"
        '
        'TxtPisVcont
        '
        Me.TxtPisVcont.Location = New System.Drawing.Point(6, 32)
        Me.TxtPisVcont.Name = "TxtPisVcont"
        Me.TxtPisVcont.Size = New System.Drawing.Size(100, 20)
        Me.TxtPisVcont.TabIndex = 3
        Me.TxtPisVcont.Text = "0,00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Valor Contábil"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.TxtAliquotaDesoneracao)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.TxtAliquotaCofins)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.TxtAliquotaPis)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(491, 192)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Configurações de Alíquotas"
        '
        'TxtAliquotaDesoneracao
        '
        Me.TxtAliquotaDesoneracao.Location = New System.Drawing.Point(6, 97)
        Me.TxtAliquotaDesoneracao.Name = "TxtAliquotaDesoneracao"
        Me.TxtAliquotaDesoneracao.Size = New System.Drawing.Size(61, 20)
        Me.TxtAliquotaDesoneracao.TabIndex = 5
        Me.TxtAliquotaDesoneracao.Text = "1,00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(167, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Alíquota desoneração da folha(%)"
        '
        'TxtAliquotaCofins
        '
        Me.TxtAliquotaCofins.Location = New System.Drawing.Point(6, 58)
        Me.TxtAliquotaCofins.Name = "TxtAliquotaCofins"
        Me.TxtAliquotaCofins.Size = New System.Drawing.Size(61, 20)
        Me.TxtAliquotaCofins.TabIndex = 3
        Me.TxtAliquotaCofins.Text = "3,00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Alíquota Cofins(%)"
        '
        'TxtAliquotaPis
        '
        Me.TxtAliquotaPis.Location = New System.Drawing.Point(6, 19)
        Me.TxtAliquotaPis.Name = "TxtAliquotaPis"
        Me.TxtAliquotaPis.Size = New System.Drawing.Size(61, 20)
        Me.TxtAliquotaPis.TabIndex = 1
        Me.TxtAliquotaPis.Text = "0,65"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Alíquota Pis(%)"
        '
        'Frm_PisCofins
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 218)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Frm_PisCofins"
        Me.Text = "Calculadora Pis e Cofins (No Lucro Presumido)"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Txt_Desoneracao As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents TxtVlrCofins As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtVlrPIS As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtPISsTvlrSt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtPISdevBc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtPisVbc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtPisVcont As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TxtAliquotaCofins As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtAliquotaPis As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtAliquotaDesoneracao As TextBox
    Friend WithEvents Label9 As Label
End Class
