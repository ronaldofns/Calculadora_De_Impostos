<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_SimplesNacional
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_SimplesNacional))
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxVlrISS = New System.Windows.Forms.TextBox()
        Me.TextBoxISS = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxVlrCSLL = New System.Windows.Forms.TextBox()
        Me.TextBoxVlrIPI = New System.Windows.Forms.TextBox()
        Me.TextBoxVlrICMS = New System.Windows.Forms.TextBox()
        Me.TextBoxVlrCPP = New System.Windows.Forms.TextBox()
        Me.TextBoxVlrPISPASEP = New System.Windows.Forms.TextBox()
        Me.TextBoxVlrCOFINS = New System.Windows.Forms.TextBox()
        Me.TextBoxVlrIRPJ = New System.Windows.Forms.TextBox()
        Me.TextBoxCSLL = New System.Windows.Forms.TextBox()
        Me.TextBoxIPI = New System.Windows.Forms.TextBox()
        Me.TextBoxICMS = New System.Windows.Forms.TextBox()
        Me.TextBoxCPP = New System.Windows.Forms.TextBox()
        Me.TextBoxPISPASEP = New System.Windows.Forms.TextBox()
        Me.TextBoxCOFINS = New System.Windows.Forms.TextBox()
        Me.TextBoxIRPJ = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblIRPJ = New System.Windows.Forms.Label()
        Me.GroupBoxValorDAS = New System.Windows.Forms.GroupBox()
        Me.txtAliqEfetiva = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.TextBoxVlrDas = New System.Windows.Forms.TextBox()
        Me.TextBoxAliqBase = New System.Windows.Forms.TextBox()
        Me.lblAliqBase = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxMes = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxAno = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.txtDeducao = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboFaixa = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxAnexo = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblFatMensal = New System.Windows.Forms.Label()
        Me.TextBoxMensal = New System.Windows.Forms.TextBox()
        Me.TextBoxUlt12Meses = New System.Windows.Forms.TextBox()
        Me.lblUlt12Meses = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxValorDAS.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(415, 120)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(110, 13)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Alíquota Efetiva ="
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(526, 128)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(211, 20)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "RBT12"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(523, 106)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(214, 20)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "(RBT12 x (Aliq %)) - Ded"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(520, 115)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(217, 13)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "______________________________"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxVlrISS)
        Me.GroupBox1.Controls.Add(Me.TextBoxISS)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TextBoxVlrCSLL)
        Me.GroupBox1.Controls.Add(Me.TextBoxVlrIPI)
        Me.GroupBox1.Controls.Add(Me.TextBoxVlrICMS)
        Me.GroupBox1.Controls.Add(Me.TextBoxVlrCPP)
        Me.GroupBox1.Controls.Add(Me.TextBoxVlrPISPASEP)
        Me.GroupBox1.Controls.Add(Me.TextBoxVlrCOFINS)
        Me.GroupBox1.Controls.Add(Me.TextBoxVlrIRPJ)
        Me.GroupBox1.Controls.Add(Me.TextBoxCSLL)
        Me.GroupBox1.Controls.Add(Me.TextBoxIPI)
        Me.GroupBox1.Controls.Add(Me.TextBoxICMS)
        Me.GroupBox1.Controls.Add(Me.TextBoxCPP)
        Me.GroupBox1.Controls.Add(Me.TextBoxPISPASEP)
        Me.GroupBox1.Controls.Add(Me.TextBoxCOFINS)
        Me.GroupBox1.Controls.Add(Me.TextBoxIRPJ)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.lblIRPJ)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 156)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(739, 88)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alíquotas referente a faturamento mensal."
        '
        'TextBoxVlrISS
        '
        Me.TextBoxVlrISS.Enabled = False
        Me.TextBoxVlrISS.Location = New System.Drawing.Point(598, 58)
        Me.TextBoxVlrISS.Name = "TextBoxVlrISS"
        Me.TextBoxVlrISS.ReadOnly = True
        Me.TextBoxVlrISS.Size = New System.Drawing.Size(81, 20)
        Me.TextBoxVlrISS.TabIndex = 41
        Me.TextBoxVlrISS.Text = "0,00"
        '
        'TextBoxISS
        '
        Me.TextBoxISS.Enabled = False
        Me.TextBoxISS.Location = New System.Drawing.Point(597, 32)
        Me.TextBoxISS.Name = "TextBoxISS"
        Me.TextBoxISS.ReadOnly = True
        Me.TextBoxISS.Size = New System.Drawing.Size(42, 20)
        Me.TextBoxISS.TabIndex = 40
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(609, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 12)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "ISS"
        '
        'TextBoxVlrCSLL
        '
        Me.TextBoxVlrCSLL.Enabled = False
        Me.TextBoxVlrCSLL.Location = New System.Drawing.Point(91, 58)
        Me.TextBoxVlrCSLL.Name = "TextBoxVlrCSLL"
        Me.TextBoxVlrCSLL.ReadOnly = True
        Me.TextBoxVlrCSLL.Size = New System.Drawing.Size(81, 20)
        Me.TextBoxVlrCSLL.TabIndex = 23
        Me.TextBoxVlrCSLL.Text = "0,00"
        '
        'TextBoxVlrIPI
        '
        Me.TextBoxVlrIPI.Enabled = False
        Me.TextBoxVlrIPI.Location = New System.Drawing.Point(514, 58)
        Me.TextBoxVlrIPI.Name = "TextBoxVlrIPI"
        Me.TextBoxVlrIPI.ReadOnly = True
        Me.TextBoxVlrIPI.Size = New System.Drawing.Size(81, 20)
        Me.TextBoxVlrIPI.TabIndex = 38
        Me.TextBoxVlrIPI.Text = "0,00"
        '
        'TextBoxVlrICMS
        '
        Me.TextBoxVlrICMS.Enabled = False
        Me.TextBoxVlrICMS.Location = New System.Drawing.Point(430, 58)
        Me.TextBoxVlrICMS.Name = "TextBoxVlrICMS"
        Me.TextBoxVlrICMS.ReadOnly = True
        Me.TextBoxVlrICMS.Size = New System.Drawing.Size(81, 20)
        Me.TextBoxVlrICMS.TabIndex = 35
        Me.TextBoxVlrICMS.Text = "0,00"
        '
        'TextBoxVlrCPP
        '
        Me.TextBoxVlrCPP.Enabled = False
        Me.TextBoxVlrCPP.Location = New System.Drawing.Point(345, 58)
        Me.TextBoxVlrCPP.Name = "TextBoxVlrCPP"
        Me.TextBoxVlrCPP.ReadOnly = True
        Me.TextBoxVlrCPP.Size = New System.Drawing.Size(81, 20)
        Me.TextBoxVlrCPP.TabIndex = 32
        Me.TextBoxVlrCPP.Text = "0,00"
        '
        'TextBoxVlrPISPASEP
        '
        Me.TextBoxVlrPISPASEP.Enabled = False
        Me.TextBoxVlrPISPASEP.Location = New System.Drawing.Point(260, 58)
        Me.TextBoxVlrPISPASEP.Name = "TextBoxVlrPISPASEP"
        Me.TextBoxVlrPISPASEP.ReadOnly = True
        Me.TextBoxVlrPISPASEP.Size = New System.Drawing.Size(81, 20)
        Me.TextBoxVlrPISPASEP.TabIndex = 29
        Me.TextBoxVlrPISPASEP.Text = "0,00"
        '
        'TextBoxVlrCOFINS
        '
        Me.TextBoxVlrCOFINS.Enabled = False
        Me.TextBoxVlrCOFINS.Location = New System.Drawing.Point(175, 58)
        Me.TextBoxVlrCOFINS.Name = "TextBoxVlrCOFINS"
        Me.TextBoxVlrCOFINS.ReadOnly = True
        Me.TextBoxVlrCOFINS.Size = New System.Drawing.Size(81, 20)
        Me.TextBoxVlrCOFINS.TabIndex = 26
        Me.TextBoxVlrCOFINS.Text = "0,00"
        '
        'TextBoxVlrIRPJ
        '
        Me.TextBoxVlrIRPJ.Enabled = False
        Me.TextBoxVlrIRPJ.Location = New System.Drawing.Point(7, 58)
        Me.TextBoxVlrIRPJ.Name = "TextBoxVlrIRPJ"
        Me.TextBoxVlrIRPJ.ReadOnly = True
        Me.TextBoxVlrIRPJ.Size = New System.Drawing.Size(81, 20)
        Me.TextBoxVlrIRPJ.TabIndex = 20
        Me.TextBoxVlrIRPJ.Text = "0,00"
        '
        'TextBoxCSLL
        '
        Me.TextBoxCSLL.Enabled = False
        Me.TextBoxCSLL.Location = New System.Drawing.Point(90, 32)
        Me.TextBoxCSLL.Name = "TextBoxCSLL"
        Me.TextBoxCSLL.ReadOnly = True
        Me.TextBoxCSLL.Size = New System.Drawing.Size(42, 20)
        Me.TextBoxCSLL.TabIndex = 22
        '
        'TextBoxIPI
        '
        Me.TextBoxIPI.Enabled = False
        Me.TextBoxIPI.Location = New System.Drawing.Point(513, 32)
        Me.TextBoxIPI.Name = "TextBoxIPI"
        Me.TextBoxIPI.ReadOnly = True
        Me.TextBoxIPI.Size = New System.Drawing.Size(42, 20)
        Me.TextBoxIPI.TabIndex = 37
        '
        'TextBoxICMS
        '
        Me.TextBoxICMS.Enabled = False
        Me.TextBoxICMS.Location = New System.Drawing.Point(429, 32)
        Me.TextBoxICMS.Name = "TextBoxICMS"
        Me.TextBoxICMS.ReadOnly = True
        Me.TextBoxICMS.Size = New System.Drawing.Size(42, 20)
        Me.TextBoxICMS.TabIndex = 34
        '
        'TextBoxCPP
        '
        Me.TextBoxCPP.Enabled = False
        Me.TextBoxCPP.Location = New System.Drawing.Point(344, 32)
        Me.TextBoxCPP.Name = "TextBoxCPP"
        Me.TextBoxCPP.ReadOnly = True
        Me.TextBoxCPP.Size = New System.Drawing.Size(42, 20)
        Me.TextBoxCPP.TabIndex = 31
        '
        'TextBoxPISPASEP
        '
        Me.TextBoxPISPASEP.Enabled = False
        Me.TextBoxPISPASEP.Location = New System.Drawing.Point(259, 32)
        Me.TextBoxPISPASEP.Name = "TextBoxPISPASEP"
        Me.TextBoxPISPASEP.ReadOnly = True
        Me.TextBoxPISPASEP.Size = New System.Drawing.Size(42, 20)
        Me.TextBoxPISPASEP.TabIndex = 28
        '
        'TextBoxCOFINS
        '
        Me.TextBoxCOFINS.Enabled = False
        Me.TextBoxCOFINS.Location = New System.Drawing.Point(174, 32)
        Me.TextBoxCOFINS.Name = "TextBoxCOFINS"
        Me.TextBoxCOFINS.ReadOnly = True
        Me.TextBoxCOFINS.Size = New System.Drawing.Size(42, 20)
        Me.TextBoxCOFINS.TabIndex = 25
        '
        'TextBoxIRPJ
        '
        Me.TextBoxIRPJ.Enabled = False
        Me.TextBoxIRPJ.Location = New System.Drawing.Point(6, 32)
        Me.TextBoxIRPJ.Name = "TextBoxIRPJ"
        Me.TextBoxIRPJ.ReadOnly = True
        Me.TextBoxIRPJ.Size = New System.Drawing.Size(42, 20)
        Me.TextBoxIRPJ.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(525, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 12)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "IPI"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(433, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 12)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "ICMS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(352, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 12)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "CPP"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(256, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 12)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "PIS/PASEP"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(175, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 12)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "COFINS"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(96, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 12)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "CSLL"
        '
        'lblIRPJ
        '
        Me.lblIRPJ.AutoSize = True
        Me.lblIRPJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIRPJ.Location = New System.Drawing.Point(14, 16)
        Me.lblIRPJ.Name = "lblIRPJ"
        Me.lblIRPJ.Size = New System.Drawing.Size(26, 12)
        Me.lblIRPJ.TabIndex = 18
        Me.lblIRPJ.Text = "IRPJ"
        '
        'GroupBoxValorDAS
        '
        Me.GroupBoxValorDAS.Controls.Add(Me.txtAliqEfetiva)
        Me.GroupBoxValorDAS.Controls.Add(Me.Label3)
        Me.GroupBoxValorDAS.Controls.Add(Me.Label9)
        Me.GroupBoxValorDAS.Controls.Add(Me.btnSair)
        Me.GroupBoxValorDAS.Controls.Add(Me.btnCalcular)
        Me.GroupBoxValorDAS.Controls.Add(Me.TextBoxVlrDas)
        Me.GroupBoxValorDAS.Controls.Add(Me.TextBoxAliqBase)
        Me.GroupBoxValorDAS.Controls.Add(Me.lblAliqBase)
        Me.GroupBoxValorDAS.Location = New System.Drawing.Point(497, 3)
        Me.GroupBoxValorDAS.Name = "GroupBoxValorDAS"
        Me.GroupBoxValorDAS.Size = New System.Drawing.Size(245, 100)
        Me.GroupBoxValorDAS.TabIndex = 19
        Me.GroupBoxValorDAS.TabStop = False
        Me.GroupBoxValorDAS.Text = "Valor DAS"
        '
        'txtAliqEfetiva
        '
        Me.txtAliqEfetiva.Enabled = False
        Me.txtAliqEfetiva.Location = New System.Drawing.Point(6, 75)
        Me.txtAliqEfetiva.Name = "txtAliqEfetiva"
        Me.txtAliqEfetiva.ReadOnly = True
        Me.txtAliqEfetiva.Size = New System.Drawing.Size(42, 20)
        Me.txtAliqEfetiva.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Aliq. Efetiva"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(51, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Valor DAS"
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(178, 59)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(64, 23)
        Me.btnSair.TabIndex = 22
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(178, 32)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(64, 23)
        Me.btnCalcular.TabIndex = 21
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'TextBoxVlrDas
        '
        Me.TextBoxVlrDas.Enabled = False
        Me.TextBoxVlrDas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.TextBoxVlrDas.ForeColor = System.Drawing.Color.Blue
        Me.TextBoxVlrDas.Location = New System.Drawing.Point(54, 32)
        Me.TextBoxVlrDas.Name = "TextBoxVlrDas"
        Me.TextBoxVlrDas.ReadOnly = True
        Me.TextBoxVlrDas.Size = New System.Drawing.Size(120, 29)
        Me.TextBoxVlrDas.TabIndex = 20
        '
        'TextBoxAliqBase
        '
        Me.TextBoxAliqBase.Enabled = False
        Me.TextBoxAliqBase.Location = New System.Drawing.Point(6, 32)
        Me.TextBoxAliqBase.Name = "TextBoxAliqBase"
        Me.TextBoxAliqBase.ReadOnly = True
        Me.TextBoxAliqBase.Size = New System.Drawing.Size(42, 20)
        Me.TextBoxAliqBase.TabIndex = 16
        '
        'lblAliqBase
        '
        Me.lblAliqBase.AutoSize = True
        Me.lblAliqBase.Location = New System.Drawing.Point(3, 16)
        Me.lblAliqBase.Name = "lblAliqBase"
        Me.lblAliqBase.Size = New System.Drawing.Size(27, 13)
        Me.lblAliqBase.TabIndex = 15
        Me.lblAliqBase.Text = "Aliq."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBoxMes)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextBoxAno)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(377, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(114, 100)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Periodo"
        '
        'ComboBoxMes
        '
        Me.ComboBoxMes.FormattingEnabled = True
        Me.ComboBoxMes.Location = New System.Drawing.Point(6, 32)
        Me.ComboBoxMes.Name = "ComboBoxMes"
        Me.ComboBoxMes.Size = New System.Drawing.Size(100, 21)
        Me.ComboBoxMes.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Ano"
        '
        'TextBoxAno
        '
        Me.TextBoxAno.Location = New System.Drawing.Point(6, 71)
        Me.TextBoxAno.Name = "TextBoxAno"
        Me.TextBoxAno.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAno.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Mes Referente"
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.txtDeducao)
        Me.GroupBox.Controls.Add(Me.Label2)
        Me.GroupBox.Controls.Add(Me.cboFaixa)
        Me.GroupBox.Controls.Add(Me.Label1)
        Me.GroupBox.Controls.Add(Me.ComboBoxAnexo)
        Me.GroupBox.Controls.Add(Me.Label11)
        Me.GroupBox.Controls.Add(Me.lblFatMensal)
        Me.GroupBox.Controls.Add(Me.TextBoxMensal)
        Me.GroupBox.Controls.Add(Me.TextBoxUlt12Meses)
        Me.GroupBox.Controls.Add(Me.lblUlt12Meses)
        Me.GroupBox.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(368, 147)
        Me.GroupBox.TabIndex = 17
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Faturamento"
        '
        'txtDeducao
        '
        Me.txtDeducao.Enabled = False
        Me.txtDeducao.Location = New System.Drawing.Point(4, 110)
        Me.txtDeducao.Name = "txtDeducao"
        Me.txtDeducao.Size = New System.Drawing.Size(84, 20)
        Me.txtDeducao.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Dedução"
        '
        'cboFaixa
        '
        Me.cboFaixa.FormattingEnabled = True
        Me.cboFaixa.Location = New System.Drawing.Point(4, 70)
        Me.cboFaixa.Name = "cboFaixa"
        Me.cboFaixa.Size = New System.Drawing.Size(252, 21)
        Me.cboFaixa.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Faixa"
        '
        'ComboBoxAnexo
        '
        Me.ComboBoxAnexo.FormattingEnabled = True
        Me.ComboBoxAnexo.Location = New System.Drawing.Point(4, 33)
        Me.ComboBoxAnexo.Name = "ComboBoxAnexo"
        Me.ComboBoxAnexo.Size = New System.Drawing.Size(252, 21)
        Me.ComboBoxAnexo.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Anexo para Calculo"
        '
        'lblFatMensal
        '
        Me.lblFatMensal.AutoSize = True
        Me.lblFatMensal.Location = New System.Drawing.Point(256, 56)
        Me.lblFatMensal.Name = "lblFatMensal"
        Me.lblFatMensal.Size = New System.Drawing.Size(62, 13)
        Me.lblFatMensal.TabIndex = 9
        Me.lblFatMensal.Text = "Fat. Mensal"
        '
        'TextBoxMensal
        '
        Me.TextBoxMensal.Location = New System.Drawing.Point(259, 72)
        Me.TextBoxMensal.Name = "TextBoxMensal"
        Me.TextBoxMensal.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMensal.TabIndex = 10
        Me.TextBoxMensal.Text = "0,00"
        '
        'TextBoxUlt12Meses
        '
        Me.TextBoxUlt12Meses.Location = New System.Drawing.Point(259, 33)
        Me.TextBoxUlt12Meses.Name = "TextBoxUlt12Meses"
        Me.TextBoxUlt12Meses.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxUlt12Meses.TabIndex = 8
        Me.TextBoxUlt12Meses.Text = "0,00"
        '
        'lblUlt12Meses
        '
        Me.lblUlt12Meses.AutoSize = True
        Me.lblUlt12Meses.Location = New System.Drawing.Point(247, 17)
        Me.lblUlt12Meses.Name = "lblUlt12Meses"
        Me.lblUlt12Meses.Size = New System.Drawing.Size(115, 13)
        Me.lblUlt12Meses.TabIndex = 7
        Me.lblUlt12Meses.Text = "Ult. 12 Meses (RBT12)"
        '
        'Frm_SimplesNacional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 250)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBoxValorDAS)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Frm_SimplesNacional"
        Me.Text = "Calculadora do Simples Nacional"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBoxValorDAS.ResumeLayout(False)
        Me.GroupBoxValorDAS.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Private WithEvents GroupBox1 As GroupBox
    Private WithEvents TextBoxVlrISS As TextBox
    Private WithEvents TextBoxISS As TextBox
    Private WithEvents Label10 As Label
    Private WithEvents TextBoxVlrCSLL As TextBox
    Private WithEvents TextBoxVlrIPI As TextBox
    Private WithEvents TextBoxVlrICMS As TextBox
    Private WithEvents TextBoxVlrCPP As TextBox
    Private WithEvents TextBoxVlrPISPASEP As TextBox
    Private WithEvents TextBoxVlrCOFINS As TextBox
    Private WithEvents TextBoxVlrIRPJ As TextBox
    Private WithEvents TextBoxCSLL As TextBox
    Private WithEvents TextBoxIPI As TextBox
    Private WithEvents TextBoxICMS As TextBox
    Private WithEvents TextBoxCPP As TextBox
    Private WithEvents TextBoxPISPASEP As TextBox
    Private WithEvents TextBoxCOFINS As TextBox
    Private WithEvents TextBoxIRPJ As TextBox
    Private WithEvents Label6 As Label
    Private WithEvents Label5 As Label
    Private WithEvents Label4 As Label
    Private WithEvents Label12 As Label
    Private WithEvents Label13 As Label
    Private WithEvents Label14 As Label
    Private WithEvents lblIRPJ As Label
    Private WithEvents GroupBoxValorDAS As GroupBox
    Private WithEvents txtAliqEfetiva As TextBox
    Private WithEvents Label3 As Label
    Private WithEvents Label9 As Label
    Private WithEvents btnSair As Button
    Private WithEvents btnCalcular As Button
    Private WithEvents TextBoxVlrDas As TextBox
    Private WithEvents TextBoxAliqBase As TextBox
    Private WithEvents lblAliqBase As Label
    Private WithEvents GroupBox2 As GroupBox
    Private WithEvents ComboBoxMes As ComboBox
    Private WithEvents Label7 As Label
    Private WithEvents TextBoxAno As TextBox
    Private WithEvents Label8 As Label
    Private WithEvents GroupBox As GroupBox
    Private WithEvents txtDeducao As TextBox
    Private WithEvents Label2 As Label
    Private WithEvents cboFaixa As ComboBox
    Private WithEvents Label1 As Label
    Private WithEvents ComboBoxAnexo As ComboBox
    Private WithEvents Label11 As Label
    Private WithEvents lblFatMensal As Label
    Private WithEvents TextBoxMensal As TextBox
    Private WithEvents TextBoxUlt12Meses As TextBox
    Private WithEvents lblUlt12Meses As Label
End Class
