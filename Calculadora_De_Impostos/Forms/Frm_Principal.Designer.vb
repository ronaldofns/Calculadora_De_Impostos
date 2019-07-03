<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ImpostosNacionaisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimplesNacionalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ICMSLucroPresumidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProtegeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PisCofinsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpostosFederaisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IRPJCSLLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImpostosNacionaisToolStripMenuItem, Me.ImpostosFederaisToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(988, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ImpostosNacionaisToolStripMenuItem
        '
        Me.ImpostosNacionaisToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SimplesNacionalToolStripMenuItem, Me.ICMSLucroPresumidoToolStripMenuItem, Me.ProtegeToolStripMenuItem, Me.PisCofinsToolStripMenuItem})
        Me.ImpostosNacionaisToolStripMenuItem.Name = "ImpostosNacionaisToolStripMenuItem"
        Me.ImpostosNacionaisToolStripMenuItem.Size = New System.Drawing.Size(123, 20)
        Me.ImpostosNacionaisToolStripMenuItem.Text = "Impostos Nacionais"
        '
        'SimplesNacionalToolStripMenuItem
        '
        Me.SimplesNacionalToolStripMenuItem.Image = CType(resources.GetObject("SimplesNacionalToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SimplesNacionalToolStripMenuItem.Name = "SimplesNacionalToolStripMenuItem"
        Me.SimplesNacionalToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.SimplesNacionalToolStripMenuItem.Text = "Simples Nacional"
        '
        'ICMSLucroPresumidoToolStripMenuItem
        '
        Me.ICMSLucroPresumidoToolStripMenuItem.Image = Global.Calculadora_De_Impostos.My.Resources.Resources.ICMS
        Me.ICMSLucroPresumidoToolStripMenuItem.Name = "ICMSLucroPresumidoToolStripMenuItem"
        Me.ICMSLucroPresumidoToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ICMSLucroPresumidoToolStripMenuItem.Text = "ICMS Lucro Presumido"
        '
        'ProtegeToolStripMenuItem
        '
        Me.ProtegeToolStripMenuItem.Image = Global.Calculadora_De_Impostos.My.Resources.Resources.protege
        Me.ProtegeToolStripMenuItem.Name = "ProtegeToolStripMenuItem"
        Me.ProtegeToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ProtegeToolStripMenuItem.Text = "Protege"
        '
        'PisCofinsToolStripMenuItem
        '
        Me.PisCofinsToolStripMenuItem.Image = Global.Calculadora_De_Impostos.My.Resources.Resources.pisCofins
        Me.PisCofinsToolStripMenuItem.Name = "PisCofinsToolStripMenuItem"
        Me.PisCofinsToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.PisCofinsToolStripMenuItem.Text = "Pis/Cofins"
        '
        'ImpostosFederaisToolStripMenuItem
        '
        Me.ImpostosFederaisToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IRPJCSLLToolStripMenuItem})
        Me.ImpostosFederaisToolStripMenuItem.Name = "ImpostosFederaisToolStripMenuItem"
        Me.ImpostosFederaisToolStripMenuItem.Size = New System.Drawing.Size(114, 20)
        Me.ImpostosFederaisToolStripMenuItem.Text = "Impostos Federais"
        '
        'IRPJCSLLToolStripMenuItem
        '
        Me.IRPJCSLLToolStripMenuItem.Image = Global.Calculadora_De_Impostos.My.Resources.Resources.irpj
        Me.IRPJCSLLToolStripMenuItem.Name = "IRPJCSLLToolStripMenuItem"
        Me.IRPJCSLLToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.IRPJCSLLToolStripMenuItem.Text = "IRPJ/CSLL"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 707)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(988, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(657, 17)
        Me.ToolStripStatusLabel1.Text = "Calculadora de impostos: By RonaldoFNS versão OPEN SOURCE. Para efeito de estudos" &
    ", e melhorias favor contribuir!"
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Calculadora_De_Impostos.My.Resources.Resources.logo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(988, 729)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frm_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora de Impostos Nacional e Federal (By RonaldoFNS)"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ImpostosNacionaisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimplesNacionalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ICMSLucroPresumidoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProtegeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PisCofinsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImpostosFederaisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IRPJCSLLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
