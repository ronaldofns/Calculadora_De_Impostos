<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_IRPJ_CSLL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_IRPJ_CSLL))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBoxDemonstrativoDeCalculo = New System.Windows.Forms.GroupBox()
        Me.GroupBoxExercicio = New System.Windows.Forms.GroupBox()
        Me.MaskedTextBoxExercicio = New System.Windows.Forms.MaskedTextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.lblValorIRPJ = New System.Windows.Forms.Label()
        Me.TextBoxVlrIRPJ = New System.Windows.Forms.TextBox()
        Me.TextBoxIPIAbatimento = New System.Windows.Forms.TextBox()
        Me.lblIPIAAbater = New System.Windows.Forms.Label()
        Me.lblAdicional10 = New System.Windows.Forms.Label()
        Me.TextBoxAdicional10 = New System.Windows.Forms.TextBox()
        Me.TextBoxBaseIRPJ = New System.Windows.Forms.TextBox()
        Me.lblBaseIRPJ = New System.Windows.Forms.Label()
        Me.TextBoxVlrCSLL = New System.Windows.Forms.TextBox()
        Me.lblValorCSLL = New System.Windows.Forms.Label()
        Me.TextBoxBaseCSLL = New System.Windows.Forms.TextBox()
        Me.lblBaseCSLL = New System.Windows.Forms.Label()
        Me.TextBoxBCIRPJ = New System.Windows.Forms.TextBox()
        Me.lblBaseDeCalcIRPJ = New System.Windows.Forms.Label()
        Me.TextBoxBCCSLL = New System.Windows.Forms.TextBox()
        Me.lblBaseDeCalcCSLL = New System.Windows.Forms.Label()
        Me.GroupBoxOperacoesDeVendas = New System.Windows.Forms.GroupBox()
        Me.TextBoxIPIsobEntradas = New System.Windows.Forms.TextBox()
        Me.lblIPISobEntradas = New System.Windows.Forms.Label()
        Me.TextBoxICMSretDevolucoes = New System.Windows.Forms.TextBox()
        Me.lblICMSRetidoDevolucoes = New System.Windows.Forms.Label()
        Me.TextBoxIPIDevolucoes = New System.Windows.Forms.TextBox()
        Me.lblIPIDeDevolucoes = New System.Windows.Forms.Label()
        Me.TextBoxTotalDevolucoes = New System.Windows.Forms.TextBox()
        Me.lblTotalDevolucoes = New System.Windows.Forms.Label()
        Me.TextBoxICMSretVendas = New System.Windows.Forms.TextBox()
        Me.lblICMSRetidoVendas = New System.Windows.Forms.Label()
        Me.TextBoxIPIvendas = New System.Windows.Forms.TextBox()
        Me.lblIPISobVendas = New System.Windows.Forms.Label()
        Me.TextBoxTotalVendas = New System.Windows.Forms.TextBox()
        Me.lblTotalDasVendas = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtAliquotaAdicional = New System.Windows.Forms.TextBox()
        Me.TxtAliquotaBaseIRPJ = New System.Windows.Forms.TextBox()
        Me.TxtAliquotaBaseCSLL = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtAliquotaIRPJ = New System.Windows.Forms.TextBox()
        Me.TxtAliquotaCSLL = New System.Windows.Forms.TextBox()
        Me.lbl = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBoxDemonstrativoDeCalculo.SuspendLayout()
        Me.GroupBoxExercicio.SuspendLayout()
        Me.GroupBoxOperacoesDeVendas.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(658, 222)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.GroupBoxDemonstrativoDeCalculo)
        Me.TabPage1.Controls.Add(Me.GroupBoxOperacoesDeVendas)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(650, 196)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "IRPJ/CSLL"
        '
        'GroupBoxDemonstrativoDeCalculo
        '
        Me.GroupBoxDemonstrativoDeCalculo.Controls.Add(Me.GroupBoxExercicio)
        Me.GroupBoxDemonstrativoDeCalculo.Controls.Add(Me.btnSair)
        Me.GroupBoxDemonstrativoDeCalculo.Controls.Add(Me.btnCalcular)
        Me.GroupBoxDemonstrativoDeCalculo.Controls.Add(Me.lblValorIRPJ)
        Me.GroupBoxDemonstrativoDeCalculo.Controls.Add(Me.TextBoxVlrIRPJ)
        Me.GroupBoxDemonstrativoDeCalculo.Controls.Add(Me.TextBoxIPIAbatimento)
        Me.GroupBoxDemonstrativoDeCalculo.Controls.Add(Me.lblIPIAAbater)
        Me.GroupBoxDemonstrativoDeCalculo.Controls.Add(Me.lblAdicional10)
        Me.GroupBoxDemonstrativoDeCalculo.Controls.Add(Me.TextBoxAdicional10)
        Me.GroupBoxDemonstrativoDeCalculo.Controls.Add(Me.TextBoxBaseIRPJ)
        Me.GroupBoxDemonstrativoDeCalculo.Controls.Add(Me.lblBaseIRPJ)
        Me.GroupBoxDemonstrativoDeCalculo.Controls.Add(Me.TextBoxVlrCSLL)
        Me.GroupBoxDemonstrativoDeCalculo.Controls.Add(Me.lblValorCSLL)
        Me.GroupBoxDemonstrativoDeCalculo.Controls.Add(Me.TextBoxBaseCSLL)
        Me.GroupBoxDemonstrativoDeCalculo.Controls.Add(Me.lblBaseCSLL)
        Me.GroupBoxDemonstrativoDeCalculo.Controls.Add(Me.TextBoxBCIRPJ)
        Me.GroupBoxDemonstrativoDeCalculo.Controls.Add(Me.lblBaseDeCalcIRPJ)
        Me.GroupBoxDemonstrativoDeCalculo.Controls.Add(Me.TextBoxBCCSLL)
        Me.GroupBoxDemonstrativoDeCalculo.Controls.Add(Me.lblBaseDeCalcCSLL)
        Me.GroupBoxDemonstrativoDeCalculo.Location = New System.Drawing.Point(243, 6)
        Me.GroupBoxDemonstrativoDeCalculo.Name = "GroupBoxDemonstrativoDeCalculo"
        Me.GroupBoxDemonstrativoDeCalculo.Size = New System.Drawing.Size(402, 187)
        Me.GroupBoxDemonstrativoDeCalculo.TabIndex = 5
        Me.GroupBoxDemonstrativoDeCalculo.TabStop = False
        Me.GroupBoxDemonstrativoDeCalculo.Text = "Demonstrativo de Cálculo"
        '
        'GroupBoxExercicio
        '
        Me.GroupBoxExercicio.Controls.Add(Me.MaskedTextBoxExercicio)
        Me.GroupBoxExercicio.Controls.Add(Me.lbl1)
        Me.GroupBoxExercicio.Location = New System.Drawing.Point(308, 11)
        Me.GroupBoxExercicio.Name = "GroupBoxExercicio"
        Me.GroupBoxExercicio.Size = New System.Drawing.Size(88, 48)
        Me.GroupBoxExercicio.TabIndex = 22
        Me.GroupBoxExercicio.TabStop = False
        Me.GroupBoxExercicio.Text = "Exercício."
        '
        'MaskedTextBoxExercicio
        '
        Me.MaskedTextBoxExercicio.Location = New System.Drawing.Point(10, 15)
        Me.MaskedTextBoxExercicio.Mask = "##/####"
        Me.MaskedTextBoxExercicio.Name = "MaskedTextBoxExercicio"
        Me.MaskedTextBoxExercicio.Size = New System.Drawing.Size(52, 20)
        Me.MaskedTextBoxExercicio.TabIndex = 0
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.ForeColor = System.Drawing.Color.Red
        Me.lbl1.Location = New System.Drawing.Point(1, 15)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(11, 13)
        Me.lbl1.TabIndex = 1
        Me.lbl1.Text = "*"
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(294, 155)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(103, 23)
        Me.btnSair.TabIndex = 20
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(186, 155)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(103, 23)
        Me.btnCalcular.TabIndex = 19
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'lblValorIRPJ
        '
        Me.lblValorIRPJ.AutoSize = True
        Me.lblValorIRPJ.Location = New System.Drawing.Point(315, 96)
        Me.lblValorIRPJ.Name = "lblValorIRPJ"
        Me.lblValorIRPJ.Size = New System.Drawing.Size(78, 13)
        Me.lblValorIRPJ.TabIndex = 18
        Me.lblValorIRPJ.Text = "<<< Valor IRPJ"
        '
        'TextBoxVlrIRPJ
        '
        Me.TextBoxVlrIRPJ.Enabled = False
        Me.TextBoxVlrIRPJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.TextBoxVlrIRPJ.Location = New System.Drawing.Point(189, 96)
        Me.TextBoxVlrIRPJ.Name = "TextBoxVlrIRPJ"
        Me.TextBoxVlrIRPJ.Size = New System.Drawing.Size(121, 29)
        Me.TextBoxVlrIRPJ.TabIndex = 17
        '
        'TextBoxIPIAbatimento
        '
        Me.TextBoxIPIAbatimento.Enabled = False
        Me.TextBoxIPIAbatimento.Location = New System.Drawing.Point(83, 132)
        Me.TextBoxIPIAbatimento.Name = "TextBoxIPIAbatimento"
        Me.TextBoxIPIAbatimento.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxIPIAbatimento.TabIndex = 16
        '
        'lblIPIAAbater
        '
        Me.lblIPIAAbater.AutoSize = True
        Me.lblIPIAAbater.Location = New System.Drawing.Point(6, 132)
        Me.lblIPIAAbater.Name = "lblIPIAAbater"
        Me.lblIPIAAbater.Size = New System.Drawing.Size(62, 13)
        Me.lblIPIAAbater.TabIndex = 15
        Me.lblIPIAAbater.Text = "IPI a abater"
        '
        'lblAdicional10
        '
        Me.lblAdicional10.AutoSize = True
        Me.lblAdicional10.Location = New System.Drawing.Point(6, 109)
        Me.lblAdicional10.Name = "lblAdicional10"
        Me.lblAdicional10.Size = New System.Drawing.Size(73, 13)
        Me.lblAdicional10.TabIndex = 14
        Me.lblAdicional10.Text = "Adicional 10%"
        '
        'TextBoxAdicional10
        '
        Me.TextBoxAdicional10.Enabled = False
        Me.TextBoxAdicional10.Location = New System.Drawing.Point(83, 109)
        Me.TextBoxAdicional10.Name = "TextBoxAdicional10"
        Me.TextBoxAdicional10.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAdicional10.TabIndex = 13
        '
        'TextBoxBaseIRPJ
        '
        Me.TextBoxBaseIRPJ.Enabled = False
        Me.TextBoxBaseIRPJ.Location = New System.Drawing.Point(83, 86)
        Me.TextBoxBaseIRPJ.Name = "TextBoxBaseIRPJ"
        Me.TextBoxBaseIRPJ.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxBaseIRPJ.TabIndex = 11
        '
        'lblBaseIRPJ
        '
        Me.lblBaseIRPJ.AutoSize = True
        Me.lblBaseIRPJ.Location = New System.Drawing.Point(6, 86)
        Me.lblBaseIRPJ.Name = "lblBaseIRPJ"
        Me.lblBaseIRPJ.Size = New System.Drawing.Size(57, 13)
        Me.lblBaseIRPJ.TabIndex = 10
        Me.lblBaseIRPJ.Text = "Base IRPJ"
        '
        'TextBoxVlrCSLL
        '
        Me.TextBoxVlrCSLL.Enabled = False
        Me.TextBoxVlrCSLL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.TextBoxVlrCSLL.Location = New System.Drawing.Point(189, 63)
        Me.TextBoxVlrCSLL.Name = "TextBoxVlrCSLL"
        Me.TextBoxVlrCSLL.Size = New System.Drawing.Size(121, 29)
        Me.TextBoxVlrCSLL.TabIndex = 9
        '
        'lblValorCSLL
        '
        Me.lblValorCSLL.AutoSize = True
        Me.lblValorCSLL.Location = New System.Drawing.Point(315, 62)
        Me.lblValorCSLL.Name = "lblValorCSLL"
        Me.lblValorCSLL.Size = New System.Drawing.Size(81, 13)
        Me.lblValorCSLL.TabIndex = 8
        Me.lblValorCSLL.Text = "<<< Valor CSLL"
        '
        'TextBoxBaseCSLL
        '
        Me.TextBoxBaseCSLL.Enabled = False
        Me.TextBoxBaseCSLL.Location = New System.Drawing.Point(83, 63)
        Me.TextBoxBaseCSLL.Name = "TextBoxBaseCSLL"
        Me.TextBoxBaseCSLL.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxBaseCSLL.TabIndex = 5
        '
        'lblBaseCSLL
        '
        Me.lblBaseCSLL.AutoSize = True
        Me.lblBaseCSLL.Location = New System.Drawing.Point(6, 63)
        Me.lblBaseCSLL.Name = "lblBaseCSLL"
        Me.lblBaseCSLL.Size = New System.Drawing.Size(60, 13)
        Me.lblBaseCSLL.TabIndex = 4
        Me.lblBaseCSLL.Text = "Base CSLL"
        '
        'TextBoxBCIRPJ
        '
        Me.TextBoxBCIRPJ.Enabled = False
        Me.TextBoxBCIRPJ.Location = New System.Drawing.Point(199, 39)
        Me.TextBoxBCIRPJ.Name = "TextBoxBCIRPJ"
        Me.TextBoxBCIRPJ.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxBCIRPJ.TabIndex = 3
        '
        'lblBaseDeCalcIRPJ
        '
        Me.lblBaseDeCalcIRPJ.AutoSize = True
        Me.lblBaseDeCalcIRPJ.Location = New System.Drawing.Point(4, 43)
        Me.lblBaseDeCalcIRPJ.Name = "lblBaseDeCalcIRPJ"
        Me.lblBaseDeCalcIRPJ.Size = New System.Drawing.Size(194, 13)
        Me.lblBaseDeCalcIRPJ.TabIndex = 2
        Me.lblBaseDeCalcIRPJ.Text = "Total p/ Determinação Base IRPJ >>>>"
        '
        'TextBoxBCCSLL
        '
        Me.TextBoxBCCSLL.Enabled = False
        Me.TextBoxBCCSLL.Location = New System.Drawing.Point(199, 16)
        Me.TextBoxBCCSLL.Name = "TextBoxBCCSLL"
        Me.TextBoxBCCSLL.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxBCCSLL.TabIndex = 1
        '
        'lblBaseDeCalcCSLL
        '
        Me.lblBaseDeCalcCSLL.AutoSize = True
        Me.lblBaseDeCalcCSLL.Location = New System.Drawing.Point(3, 16)
        Me.lblBaseDeCalcCSLL.Name = "lblBaseDeCalcCSLL"
        Me.lblBaseDeCalcCSLL.Size = New System.Drawing.Size(197, 13)
        Me.lblBaseDeCalcCSLL.TabIndex = 0
        Me.lblBaseDeCalcCSLL.Text = "Total p/ Determinação Base CSLL >>>>"
        '
        'GroupBoxOperacoesDeVendas
        '
        Me.GroupBoxOperacoesDeVendas.Controls.Add(Me.TextBoxIPIsobEntradas)
        Me.GroupBoxOperacoesDeVendas.Controls.Add(Me.lblIPISobEntradas)
        Me.GroupBoxOperacoesDeVendas.Controls.Add(Me.TextBoxICMSretDevolucoes)
        Me.GroupBoxOperacoesDeVendas.Controls.Add(Me.lblICMSRetidoDevolucoes)
        Me.GroupBoxOperacoesDeVendas.Controls.Add(Me.TextBoxIPIDevolucoes)
        Me.GroupBoxOperacoesDeVendas.Controls.Add(Me.lblIPIDeDevolucoes)
        Me.GroupBoxOperacoesDeVendas.Controls.Add(Me.TextBoxTotalDevolucoes)
        Me.GroupBoxOperacoesDeVendas.Controls.Add(Me.lblTotalDevolucoes)
        Me.GroupBoxOperacoesDeVendas.Controls.Add(Me.TextBoxICMSretVendas)
        Me.GroupBoxOperacoesDeVendas.Controls.Add(Me.lblICMSRetidoVendas)
        Me.GroupBoxOperacoesDeVendas.Controls.Add(Me.TextBoxIPIvendas)
        Me.GroupBoxOperacoesDeVendas.Controls.Add(Me.lblIPISobVendas)
        Me.GroupBoxOperacoesDeVendas.Controls.Add(Me.TextBoxTotalVendas)
        Me.GroupBoxOperacoesDeVendas.Controls.Add(Me.lblTotalDasVendas)
        Me.GroupBoxOperacoesDeVendas.Location = New System.Drawing.Point(3, 6)
        Me.GroupBoxOperacoesDeVendas.Name = "GroupBoxOperacoesDeVendas"
        Me.GroupBoxOperacoesDeVendas.Size = New System.Drawing.Size(234, 187)
        Me.GroupBoxOperacoesDeVendas.TabIndex = 4
        Me.GroupBoxOperacoesDeVendas.TabStop = False
        Me.GroupBoxOperacoesDeVendas.Text = "Operações de Vendas"
        '
        'TextBoxIPIsobEntradas
        '
        Me.TextBoxIPIsobEntradas.Location = New System.Drawing.Point(128, 158)
        Me.TextBoxIPIsobEntradas.Name = "TextBoxIPIsobEntradas"
        Me.TextBoxIPIsobEntradas.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxIPIsobEntradas.TabIndex = 13
        Me.TextBoxIPIsobEntradas.Text = "0,00"
        '
        'lblIPISobEntradas
        '
        Me.lblIPISobEntradas.AutoSize = True
        Me.lblIPISobEntradas.Location = New System.Drawing.Point(3, 157)
        Me.lblIPISobEntradas.Name = "lblIPISobEntradas"
        Me.lblIPISobEntradas.Size = New System.Drawing.Size(85, 13)
        Me.lblIPISobEntradas.TabIndex = 12
        Me.lblIPISobEntradas.Text = "IPI sob Entradas"
        '
        'TextBoxICMSretDevolucoes
        '
        Me.TextBoxICMSretDevolucoes.Location = New System.Drawing.Point(128, 135)
        Me.TextBoxICMSretDevolucoes.Name = "TextBoxICMSretDevolucoes"
        Me.TextBoxICMSretDevolucoes.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxICMSretDevolucoes.TabIndex = 11
        Me.TextBoxICMSretDevolucoes.Text = "0,00"
        '
        'lblICMSRetidoDevolucoes
        '
        Me.lblICMSRetidoDevolucoes.AutoSize = True
        Me.lblICMSRetidoDevolucoes.Location = New System.Drawing.Point(3, 135)
        Me.lblICMSRetidoDevolucoes.Name = "lblICMSRetidoDevolucoes"
        Me.lblICMSRetidoDevolucoes.Size = New System.Drawing.Size(125, 13)
        Me.lblICMSRetidoDevolucoes.TabIndex = 10
        Me.lblICMSRetidoDevolucoes.Text = "ICMS retido(Devoluções)"
        '
        'TextBoxIPIDevolucoes
        '
        Me.TextBoxIPIDevolucoes.Location = New System.Drawing.Point(128, 112)
        Me.TextBoxIPIDevolucoes.Name = "TextBoxIPIDevolucoes"
        Me.TextBoxIPIDevolucoes.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxIPIDevolucoes.TabIndex = 9
        Me.TextBoxIPIDevolucoes.Text = "0,00"
        '
        'lblIPIDeDevolucoes
        '
        Me.lblIPIDeDevolucoes.AutoSize = True
        Me.lblIPIDeDevolucoes.Location = New System.Drawing.Point(3, 112)
        Me.lblIPIDeDevolucoes.Name = "lblIPIDeDevolucoes"
        Me.lblIPIDeDevolucoes.Size = New System.Drawing.Size(95, 13)
        Me.lblIPIDeDevolucoes.TabIndex = 8
        Me.lblIPIDeDevolucoes.Text = "IPI de Devoluções"
        '
        'TextBoxTotalDevolucoes
        '
        Me.TextBoxTotalDevolucoes.Location = New System.Drawing.Point(128, 89)
        Me.TextBoxTotalDevolucoes.Name = "TextBoxTotalDevolucoes"
        Me.TextBoxTotalDevolucoes.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTotalDevolucoes.TabIndex = 7
        Me.TextBoxTotalDevolucoes.Text = "0,00"
        '
        'lblTotalDevolucoes
        '
        Me.lblTotalDevolucoes.AutoSize = True
        Me.lblTotalDevolucoes.Location = New System.Drawing.Point(3, 90)
        Me.lblTotalDevolucoes.Name = "lblTotalDevolucoes"
        Me.lblTotalDevolucoes.Size = New System.Drawing.Size(91, 13)
        Me.lblTotalDevolucoes.TabIndex = 6
        Me.lblTotalDevolucoes.Text = "Total Devoluções"
        '
        'TextBoxICMSretVendas
        '
        Me.TextBoxICMSretVendas.Location = New System.Drawing.Point(128, 66)
        Me.TextBoxICMSretVendas.Name = "TextBoxICMSretVendas"
        Me.TextBoxICMSretVendas.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxICMSretVendas.TabIndex = 5
        Me.TextBoxICMSretVendas.Text = "0,00"
        '
        'lblICMSRetidoVendas
        '
        Me.lblICMSRetidoVendas.AutoSize = True
        Me.lblICMSRetidoVendas.Location = New System.Drawing.Point(3, 66)
        Me.lblICMSRetidoVendas.Name = "lblICMSRetidoVendas"
        Me.lblICMSRetidoVendas.Size = New System.Drawing.Size(125, 13)
        Me.lblICMSRetidoVendas.TabIndex = 4
        Me.lblICMSRetidoVendas.Text = "ICMS retido(Devoluções)"
        '
        'TextBoxIPIvendas
        '
        Me.TextBoxIPIvendas.Location = New System.Drawing.Point(128, 43)
        Me.TextBoxIPIvendas.Name = "TextBoxIPIvendas"
        Me.TextBoxIPIvendas.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxIPIvendas.TabIndex = 3
        Me.TextBoxIPIvendas.Text = "0,00"
        '
        'lblIPISobVendas
        '
        Me.lblIPISobVendas.AutoSize = True
        Me.lblIPISobVendas.Location = New System.Drawing.Point(6, 43)
        Me.lblIPISobVendas.Name = "lblIPISobVendas"
        Me.lblIPISobVendas.Size = New System.Drawing.Size(78, 13)
        Me.lblIPISobVendas.TabIndex = 2
        Me.lblIPISobVendas.Text = "IPI sob vendas"
        '
        'TextBoxTotalVendas
        '
        Me.TextBoxTotalVendas.Location = New System.Drawing.Point(128, 20)
        Me.TextBoxTotalVendas.Name = "TextBoxTotalVendas"
        Me.TextBoxTotalVendas.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTotalVendas.TabIndex = 1
        Me.TextBoxTotalVendas.Text = "0,00"
        '
        'lblTotalDasVendas
        '
        Me.lblTotalDasVendas.AutoSize = True
        Me.lblTotalDasVendas.Location = New System.Drawing.Point(3, 20)
        Me.lblTotalDasVendas.Name = "lblTotalDasVendas"
        Me.lblTotalDasVendas.Size = New System.Drawing.Size(89, 13)
        Me.lblTotalDasVendas.TabIndex = 0
        Me.lblTotalDasVendas.Text = "Total das vendas"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.TxtAliquotaAdicional)
        Me.TabPage2.Controls.Add(Me.TxtAliquotaBaseIRPJ)
        Me.TabPage2.Controls.Add(Me.TxtAliquotaBaseCSLL)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.TxtAliquotaIRPJ)
        Me.TabPage2.Controls.Add(Me.TxtAliquotaCSLL)
        Me.TabPage2.Controls.Add(Me.lbl)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(650, 196)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Configurações de Alíquotas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "<-- Aplica sobre a Base"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "<-- Aplica na Base"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "<-- Aplica sobre a Base"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "<-- Aplica na Base"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Alíquotas Adicional(%)"
        '
        'TxtAliquotaAdicional
        '
        Me.TxtAliquotaAdicional.Location = New System.Drawing.Point(9, 174)
        Me.TxtAliquotaAdicional.Name = "TxtAliquotaAdicional"
        Me.TxtAliquotaAdicional.Size = New System.Drawing.Size(32, 20)
        Me.TxtAliquotaAdicional.TabIndex = 19
        Me.TxtAliquotaAdicional.Text = "10"
        '
        'TxtAliquotaBaseIRPJ
        '
        Me.TxtAliquotaBaseIRPJ.Location = New System.Drawing.Point(9, 106)
        Me.TxtAliquotaBaseIRPJ.Name = "TxtAliquotaBaseIRPJ"
        Me.TxtAliquotaBaseIRPJ.Size = New System.Drawing.Size(32, 20)
        Me.TxtAliquotaBaseIRPJ.TabIndex = 18
        Me.TxtAliquotaBaseIRPJ.Text = "8"
        '
        'TxtAliquotaBaseCSLL
        '
        Me.TxtAliquotaBaseCSLL.Location = New System.Drawing.Point(9, 32)
        Me.TxtAliquotaBaseCSLL.Name = "TxtAliquotaBaseCSLL"
        Me.TxtAliquotaBaseCSLL.Size = New System.Drawing.Size(32, 20)
        Me.TxtAliquotaBaseCSLL.TabIndex = 17
        Me.TxtAliquotaBaseCSLL.Text = "12"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Alíquotas IRPJ(%)"
        '
        'TxtAliquotaIRPJ
        '
        Me.TxtAliquotaIRPJ.Location = New System.Drawing.Point(9, 132)
        Me.TxtAliquotaIRPJ.Name = "TxtAliquotaIRPJ"
        Me.TxtAliquotaIRPJ.Size = New System.Drawing.Size(32, 20)
        Me.TxtAliquotaIRPJ.TabIndex = 15
        Me.TxtAliquotaIRPJ.Text = "15"
        '
        'TxtAliquotaCSLL
        '
        Me.TxtAliquotaCSLL.Location = New System.Drawing.Point(9, 58)
        Me.TxtAliquotaCSLL.Name = "TxtAliquotaCSLL"
        Me.TxtAliquotaCSLL.Size = New System.Drawing.Size(32, 20)
        Me.TxtAliquotaCSLL.TabIndex = 14
        Me.TxtAliquotaCSLL.Text = "9"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(6, 17)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(95, 13)
        Me.lbl.TabIndex = 13
        Me.lbl.Text = "Alíquotas CSLL(%)"
        '
        'Frm_IRPJ_CSLL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 223)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Frm_IRPJ_CSLL"
        Me.Text = "Calculadora de IRPJ e CSLL"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBoxDemonstrativoDeCalculo.ResumeLayout(False)
        Me.GroupBoxDemonstrativoDeCalculo.PerformLayout()
        Me.GroupBoxExercicio.ResumeLayout(False)
        Me.GroupBoxExercicio.PerformLayout()
        Me.GroupBoxOperacoesDeVendas.ResumeLayout(False)
        Me.GroupBoxOperacoesDeVendas.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Private WithEvents Label2 As Label
    Private WithEvents TxtAliquotaAdicional As TextBox
    Private WithEvents TxtAliquotaBaseIRPJ As TextBox
    Private WithEvents TxtAliquotaBaseCSLL As TextBox
    Private WithEvents Label1 As Label
    Private WithEvents TxtAliquotaIRPJ As TextBox
    Private WithEvents TxtAliquotaCSLL As TextBox
    Private WithEvents lbl As Label
    Private WithEvents Label5 As Label
    Private WithEvents Label6 As Label
    Private WithEvents Label4 As Label
    Private WithEvents Label3 As Label
    Private WithEvents GroupBoxDemonstrativoDeCalculo As GroupBox
    Private WithEvents GroupBoxExercicio As GroupBox
    Private WithEvents MaskedTextBoxExercicio As MaskedTextBox
    Private WithEvents lbl1 As Label
    Private WithEvents btnSair As Button
    Private WithEvents btnCalcular As Button
    Private WithEvents lblValorIRPJ As Label
    Private WithEvents TextBoxVlrIRPJ As TextBox
    Private WithEvents TextBoxIPIAbatimento As TextBox
    Private WithEvents lblIPIAAbater As Label
    Private WithEvents lblAdicional10 As Label
    Private WithEvents TextBoxAdicional10 As TextBox
    Private WithEvents TextBoxBaseIRPJ As TextBox
    Private WithEvents lblBaseIRPJ As Label
    Private WithEvents TextBoxVlrCSLL As TextBox
    Private WithEvents lblValorCSLL As Label
    Private WithEvents TextBoxBaseCSLL As TextBox
    Private WithEvents lblBaseCSLL As Label
    Private WithEvents TextBoxBCIRPJ As TextBox
    Private WithEvents lblBaseDeCalcIRPJ As Label
    Private WithEvents TextBoxBCCSLL As TextBox
    Private WithEvents lblBaseDeCalcCSLL As Label
    Private WithEvents GroupBoxOperacoesDeVendas As GroupBox
    Private WithEvents TextBoxIPIsobEntradas As TextBox
    Private WithEvents lblIPISobEntradas As Label
    Private WithEvents TextBoxICMSretDevolucoes As TextBox
    Private WithEvents lblICMSRetidoDevolucoes As Label
    Private WithEvents TextBoxIPIDevolucoes As TextBox
    Private WithEvents lblIPIDeDevolucoes As Label
    Private WithEvents TextBoxTotalDevolucoes As TextBox
    Private WithEvents lblTotalDevolucoes As Label
    Private WithEvents TextBoxICMSretVendas As TextBox
    Private WithEvents lblICMSRetidoVendas As Label
    Private WithEvents TextBoxIPIvendas As TextBox
    Private WithEvents lblIPISobVendas As Label
    Private WithEvents TextBoxTotalVendas As TextBox
    Private WithEvents lblTotalDasVendas As Label
End Class
