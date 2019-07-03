Imports System.Data.OleDb
Imports System.Math

Public Class Frm_SimplesNacional
    Public Funcoes As New ClsFuncoes
    Dim ANEXO As Integer
    Dim aliqEfetiva As Double = 0.00
    Private Sub Frm_SimplesNacional_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            TextBoxAno.Text = Year(Now)
            TextBoxUlt12Meses.Focus()
            Funcoes.preenche_combobox(ComboBoxMes, "SELECT mes FROM MES order by id_mes")
            Funcoes.preenche_combobox(ComboBoxAnexo, "SELECT DESCRICAO FROM PARTILHA_ANEXOS order by ID")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComboBoxAnexo_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxAnexo.SelectedValueChanged
        ANEXO = Funcoes.Consulta("SELECT ID FROM PARTILHA_ANEXOS WHERE DESCRICAO='" & ComboBoxAnexo.Text & "'")
        cboFaixa.Items.Clear()
        Funcoes.preenche_combobox(cboFaixa, "SELECT RBT12 FROM PARTILHA_SIMPLES_NACIONAL WHERE ANEXO = " & ANEXO & "")
    End Sub

    Private Sub CboFaixa_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboFaixa.SelectedValueChanged
        Try
            ConectaBanco()
            rs = New OleDbCommand("SELECT * FROM PARTILHA_SIMPLES_NACIONAL WHERE ANEXO = " & ANEXO & " AND RBT12='" & cboFaixa.Text & "' ", Oledb_conexao)
            reader = rs.ExecuteReader(CommandBehavior.SingleRow)
            reader.Read()
            TextBoxAliqBase.Text = reader.Item(2)
            txtDeducao.Text = reader.Item(3)
            TextBoxIRPJ.Text = reader.Item(5)
            TextBoxCSLL.Text = reader.Item(6)
            TextBoxCOFINS.Text = reader.Item(7)
            TextBoxPISPASEP.Text = reader.Item(8)
            TextBoxCPP.Text = reader.Item(9)
            TextBoxIPI.Text = reader.Item(10)
            TextBoxICMS.Text = reader.Item(11)
            TextBoxISS.Text = reader.Item(12)

            reader.Close()
            Oledb_conexao.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Try
            Label15.Text = "(" & TextBoxUlt12Meses.Text & " * (" & TextBoxAliqBase.Text & "%))" & " - " & txtDeducao.Text
            Label17.Text = TextBoxUlt12Meses.Text

            If TextBoxUlt12Meses.Text = "" Then MsgBox("Campo Faturameto 12 meses não pode ser vazio.", MsgBoxStyle.Critical, "Atenção!!!")
            If TextBoxAno.Text = "" Then MsgBox("Campo Ano não pode ser vazio.", MsgBoxStyle.Critical, "Atenção!!!")

            TextBoxVlrDas.Text = Format((TextBoxMensal.Text * txtAliqEfetiva.Text) / 100, "currency")

            TextBoxVlrIRPJ.Text = Format((TextBoxMensal.Text * TextBoxIRPJ.Text) / 100, "currency")
            TextBoxVlrCSLL.Text = Format((TextBoxMensal.Text * TextBoxCSLL.Text) / 100, "currency")
            TextBoxVlrCOFINS.Text = Format((TextBoxMensal.Text * TextBoxCOFINS.Text) / 100, "currency")
            TextBoxVlrPISPASEP.Text = Format((TextBoxMensal.Text * TextBoxPISPASEP.Text) / 100, "currency")
            TextBoxVlrCPP.Text = Format((TextBoxMensal.Text * TextBoxCPP.Text) / 100, "currency")
            TextBoxVlrICMS.Text = Format((TextBoxMensal.Text * TextBoxICMS.Text) / 100, "currency")
            TextBoxVlrIPI.Text = Format((TextBoxMensal.Text * TextBoxIPI.Text) / 100, "currency")
            TextBoxVlrISS.Text = Format((TextBoxMensal.Text * TextBoxISS.Text) / 100, "currency")



            ''Caso queira salvar em banco de dados essa função ja faz tudo pra vc basta inserir a instrução sql
            'Select Case MessageBox.Show("Deseja gravar na base de dados", "Gravando em base de dados.", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            '    Case System.Windows.Forms.DialogResult.Yes

            '        Funcoes.Insert_Update_Delete("***INSTRUCAO SQL***" &
            '                                     "Values()")
            '    Case System.Windows.Forms.DialogResult.No
            '        'Caso queira que aconteça algo caso seje não
            'End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub
    Private Sub TextBoxUlt12Meses_LostFocus(sender As Object, e As EventArgs) Handles TextBoxUlt12Meses.LostFocus
        Try
            aliqEfetiva = Round((((((TextBoxUlt12Meses.Text * TextBoxAliqBase.Text) / 100) - txtDeducao.Text)) / TextBoxUlt12Meses.Text) * 100, 4)
            txtAliqEfetiva.Text = aliqEfetiva

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmSimplesNacional2018_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send("{Tab}")
    End Sub

    Private Sub TextBoxUlt12Meses_GotFocus(sender As Object, e As EventArgs) Handles TextBoxUlt12Meses.GotFocus
        SelecionaTudoNoElemento(TextBoxUlt12Meses)
    End Sub

    Private Sub TextBoxUlt12Meses_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUlt12Meses.TextChanged
        FormataEmDecimalNoElemento(TextBoxUlt12Meses)
    End Sub

    Private Sub TextBoxMensal_GotFocus(sender As Object, e As EventArgs) Handles TextBoxMensal.GotFocus
        SelecionaTudoNoElemento(TextBoxMensal)
    End Sub

    Private Sub TextBoxMensal_TextChanged(sender As Object, e As EventArgs) Handles TextBoxMensal.TextChanged
        FormataEmDecimalNoElemento(TextBoxMensal)
    End Sub

    Private Sub TextBoxAno_GotFocus(sender As Object, e As EventArgs) Handles TextBoxAno.GotFocus
        SelecionaTudoNoElemento(TextBoxAno)
    End Sub

    Private Sub TextBoxMensal_LostFocus(sender As Object, e As EventArgs) Handles TextBoxMensal.LostFocus
        CboFaixa_SelectedValueChanged(sender, e)
        Try
            TextBoxIRPJ.Text = Round(((txtAliqEfetiva.Text * TextBoxIRPJ.Text) / 100), 2)
            TextBoxVlrIRPJ.Text = Format((TextBoxMensal.Text * TextBoxIRPJ.Text) / 100, "currency")
            TextBoxCSLL.Text = Round(((txtAliqEfetiva.Text * TextBoxCSLL.Text) / 100), 2)
            TextBoxVlrCSLL.Text = Format((TextBoxMensal.Text * TextBoxCSLL.Text) / 100, "currency")
            TextBoxCOFINS.Text = Round(((txtAliqEfetiva.Text * TextBoxCOFINS.Text) / 100), 2)
            TextBoxVlrCOFINS.Text = Format((TextBoxMensal.Text * TextBoxCOFINS.Text) / 100, "currency")
            TextBoxPISPASEP.Text = Round(((txtAliqEfetiva.Text * TextBoxPISPASEP.Text) / 100), 2)
            TextBoxVlrPISPASEP.Text = Format((TextBoxMensal.Text * TextBoxPISPASEP.Text) / 100, "currency")
            TextBoxCPP.Text = Round(((txtAliqEfetiva.Text * TextBoxCPP.Text) / 100), 2)
            TextBoxVlrCPP.Text = Format((TextBoxMensal.Text * TextBoxCPP.Text) / 100, "currency")
            TextBoxICMS.Text = Round(((txtAliqEfetiva.Text * TextBoxICMS.Text) / 100), 2)
            TextBoxVlrICMS.Text = Format((TextBoxMensal.Text * TextBoxICMS.Text) / 100, "currency")
            TextBoxIPI.Text = Round(((txtAliqEfetiva.Text * TextBoxIPI.Text) / 100), 2)
            TextBoxVlrIPI.Text = Format((TextBoxMensal.Text * TextBoxIPI.Text) / 100, "currency")
            TextBoxISS.Text = Round(((txtAliqEfetiva.Text * TextBoxISS.Text) / 100), 2)
            TextBoxVlrISS.Text = Format((TextBoxMensal.Text * TextBoxISS.Text) / 100, "currency")
        Catch ex As Exception
            MsgBox("Erro: " & ex.Message)
            Exit Sub
        End Try
    End Sub

End Class
