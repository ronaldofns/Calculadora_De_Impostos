Imports System.IO

Module Mdl_Conexao
    Public conn As New OleDb.OleDbConnection
    Public Sub ConectaBanco()
        Try
            str_conexao = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & Application.StartupPath & "\Dados\Dados.mdb"
            Oledb_conexao.ConnectionString = str_conexao
            Oledb_conexao.Open()
        Catch ex As Exception
            MsgBox("Conexão não estabelecida!" & vbCrLf & ex.Message)
            'End
        End Try
    End Sub
    Public Sub SelecionaTudoNoElemento(ByVal Obj As Object)
        Obj.SelectAll()
    End Sub
    Public Sub FormataEmDecimalNoElemento(ByRef txt As TextBox)
        Dim n As String = String.Empty
        Dim v As Double = 0
        Try
            n = txt.Text.Replace(",", "").Replace(".", "")
            If n.Equals("") Then n = "000"
            n = n.PadLeft(3, "0")
            If n.Length > 3 And n.Substring(0, 1) = "0" Then n = n.Substring(1, n.Length - 1)
            v = Convert.ToDouble(n) / 100
            txt.Text = String.Format("{0:N}", v)
            txt.SelectionStart = txt.Text.Length
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "TextBoxMoeda")
        End Try
    End Sub
    Public Function IDMES(ByVal OBJ As Object) As Integer

        Select Case OBJ
            Case "JANEIRO"
                OBJ = 1
            Case "FEVEREIRO"
                OBJ = 2
            Case "MARÇO"
                OBJ = 3
            Case "ABRIL"
                OBJ = 4
            Case "MAIO"
                OBJ = 5
            Case "JUNHO"
                OBJ = 6
            Case "JULHO"
                OBJ = 7
            Case "AGOSTO"
                OBJ = 8
            Case "SETEMBRO"
                OBJ = 9
            Case "OUTUBRO"
                OBJ = 10
            Case "NOVEMBRO"
                OBJ = 11
            Case "DEZEMBRO"
                OBJ = 12
        End Select

        Return OBJ
    End Function


    Public Sub ConnectSinal()

        'Dim nome_arquivo_ini As String = nomeArquivoINI()

        Try
            str_conexao = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\SINAL600\Sinal600.mdb; Jet OLEDB:Database Password=Sinal2007"
            conn.ConnectionString = str_conexao
            conn.Open()
        Catch ex As Exception
            MsgBox("Conexão não estabelecida!" & vbCrLf & ex.Message)
            'End
        End Try

    End Sub


End Module
