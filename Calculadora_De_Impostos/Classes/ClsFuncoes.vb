Option Strict Off
Option Explicit On
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO

Public Class ClsFuncoes
    Dim lvwColumn As ColumnHeader
    Dim itmListItem As ListViewItem
    Public Sub preenche_combobox(ByVal combo As Object, ByVal sql As String)
        Try
            Dim lista As New AutoCompleteStringCollection
            Dim shtCntr As Object
            combo.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            combo.AutoCompleteSource = AutoCompleteSource.CustomSource
            If Oledb_conexao.State = ConnectionState.Closed Then
                'MsgBox("Conexão perdida com o servidor, tente novamente.", MsgBoxStyle.Critical, "Estado Conexão!")
                ConectaBanco()
                'Exit Sub
            End If

            rs = New OleDbCommand(sql, Oledb_conexao)
            Dim dados As OleDbDataReader = rs.ExecuteReader
            'Combo.Items.Clear()
            Do While dados.Read
                For shtCntr = 0 To dados.FieldCount() - 1
                    If dados.IsDBNull(shtCntr) Then
                        lista.Add("")
                        combo.Items.Add("")
                    Else
                        lista.Add(dados.Item(shtCntr).ToString)
                        combo.Items.Add(dados.Item(shtCntr).ToString)
                    End If
                Next shtCntr
            Loop
            combo.AutoCompleteCustomSource = lista
            Oledb_conexao.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub preenche_listbox(ByVal List As ListBox, ByVal sql As String)
        Try
            Dim shtCntr As Object
            List.Items.Clear()
            If Oledb_conexao.State = ConnectionState.Closed Then
                'MsgBox("Conexão perdida com o servidor, tente novamente.", MsgBoxStyle.Critical, "Estado Conexão!")
                ConectaBanco()
                'Exit Sub
            End If

            rs = New OleDbCommand(sql, Oledb_conexao)
            Dim dados As OleDbDataReader = rs.ExecuteReader
            'Combo.Items.Clear()
            Do While dados.Read
                For shtCntr = 0 To dados.FieldCount() - 1
                    If dados.IsDBNull(shtCntr) Then
                        List.Items.Add("")
                    Else
                        List.Items.Add(dados.Item(shtCntr).ToString)
                    End If
                Next shtCntr
            Loop
            Oledb_conexao.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub completa_textbox(ByVal Txt As Object, ByVal SQL As String)
        Dim lista As New AutoCompleteStringCollection
        Dim shtCntr As Object
        Txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Txt.AutoCompleteSource = AutoCompleteSource.CustomSource
        If Oledb_conexao.State = ConnectionState.Closed Then
            ' MsgBox("Conexão perdida com o servidor, tente novamente.", MsgBoxStyle.Critical, "Estado Conexão!")
            ConectaBanco()
            'Exit Sub
        End If
        rs = New OleDbCommand(SQL, Oledb_conexao)
        Dim dados As OleDbDataReader = rs.ExecuteReader
        Do While dados.Read
            For shtCntr = 0 To dados.FieldCount() - 1
                If dados.IsDBNull(shtCntr) Then
                    lista.Add("")
                Else
                    lista.Add(dados.Item(shtCntr).ToString)
                End If
            Next shtCntr
        Loop
        If lista.Count <> 0 Then Txt.AutoCompleteCustomSource = lista
        Oledb_conexao.Close()
    End Sub



    Public Sub Insert_Update_Delete(ByVal SQL As String)
        Try
            If Oledb_conexao.State = ConnectionState.Closed Then
                ' MsgBox("Conexão perdida com o servidor, tente novamente.", MsgBoxStyle.Critical, "Estado Conexão!")
                ConectaBanco()
                'xit Sub
            End If
            rs = New OleDbCommand(SQL, Oledb_conexao)
            rs.ExecuteNonQuery()
            'MsgBox("Comando executado...", MsgBoxStyle.Exclamation, "Aviso!")
            Oledb_conexao.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub PreencheListView(ByRef ltv As ListView, ByVal sql As String)
        Try

            If Oledb_conexao.State = ConnectionState.Closed Then
                'MsgBox("Conexão perdida com o servidor, tente novamente.", MsgBoxStyle.Critical, "Estado Conexão!")
                ConectaBanco()
                'Exit Sub
            End If
            rs = New OleDbCommand(sql, Oledb_conexao)

            Dim dados As OleDbDataReader = rs.ExecuteReader
            Dim shtCntr As Object
            Dim incremento As Integer = 0
            ltv.Clear()
            For shtCntr = 0 To dados.FieldCount() - 1
                lvwColumn = New ColumnHeader()
                lvwColumn.Text = dados.GetName(shtCntr)
                ltv.Columns.Add(lvwColumn.Text, (Len(lvwColumn.Text) * 12), HorizontalAlignment.Left)
            Next

            Do While dados.Read
                itmListItem = New ListViewItem()
                itmListItem.Text = dados(0)

                For shtCntr = 1 To dados.FieldCount() - 1
                    If dados.IsDBNull(shtCntr) Then
                        itmListItem.SubItems.Add("")
                    Else
                        itmListItem.SubItems.Add(dados.Item(shtCntr).ToString)
                        ltv.AutoResizeColumn(shtCntr, ColumnHeaderAutoResizeStyle.HeaderSize)
                    End If
                Next shtCntr

                ltv.Items.Add(itmListItem)
            Loop
            AlternarCoresdeFundoList(ltv, Color.Beige, Color.White)
            dados.Close()
            Oledb_conexao.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub AlternarCoresdeFundoList(ByVal lst As ListView, ByVal color1 As Color, ByVal color2 As Color)

        For Each item As ListViewItem In lst.Items
            If (item.Index Mod 2) = 0 Then
                item.BackColor = color1
            Else
                item.BackColor = color2
            End If
        Next
    End Sub
    Public Function Consulta(ByVal Sql As String) As String

        If Oledb_conexao.State = ConnectionState.Closed Then
            'MsgBox("Conexão perdida com o servidor, tente novamente.", MsgBoxStyle.Critical, "Estado Conexão!")
            ConectaBanco()
            'Exit Function
        End If
        rs = New OleDbCommand(Sql, Oledb_conexao)

        Return rs.ExecuteScalar
        Oledb_conexao.Close()
    End Function

    Function SoLETRAS(ByVal KeyAscii As Integer) As Integer
        'Transformar letras minusculas em Maiúsculas
        KeyAscii = Asc(UCase(Chr(KeyAscii)))
        ' Intercepta um código ASCII recebido e admite somente letras
        If InStr("AÃÁBCÇDEÉÊFGHIÍJKLMNOÓPQRSTUÚVWXYZ", Chr(KeyAscii)) = 0 Then
            SoLETRAS = 0
        Else
            SoLETRAS = KeyAscii
        End If

        ' teclas adicionais permitidas
        If KeyAscii = 8 Then SoLETRAS = KeyAscii ' Backspace
        If KeyAscii = 13 Then SoLETRAS = KeyAscii ' Enter
        If KeyAscii = 32 Then SoLETRAS = KeyAscii ' Espace
    End Function


    Function SoNumeros(ByVal Keyascii As Short) As Short

        'insira este comando no evento Keypress do textBox


        '        Dim keyascii As Short = CShort(Asc(e.keychar))
        '        keyascii = CShort(SoNumeros(keyascii))
        '        If keyascii = 0 Then
        '        e.handled = True
        '        End If

        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SoNumeros = 0
        Else
            SoNumeros = Keyascii
        End If

        Select Case Keyascii
            Case 8
                SoNumeros = Keyascii
            Case 13
                SoNumeros = Keyascii
            Case 32
                SoNumeros = Keyascii
        End Select
    End Function

    Public Function validaData(ByVal pDataHoraCriacaoInicial As String, obj As Object) As Boolean
        Dim toParametros As Integer = 1
        Dim expressao As String = pDataHoraCriacaoInicial.ToString()
        'expressao = expressao.Trim()

        If expressao = "  /  /" Then

        Else
            If (expressao.Length < 10) Then
                MsgBox("Data Invalida, verifique!", MsgBoxStyle.Critical, "Aviso!")
                obj.focus
                Return False
            Else
                For i As Integer = 0 To expressao.Length - 1

                    'Posicao de 30 a 39 na tabela ASCII são numeros de 0 a 9' 
                    For posicao As Integer = 30 To 39
                        Dim valor As Char = expressao(i)
                        'Se o valor na posicao do indice da expressao NÃO for um numero '
                        'e se caso o indice estiver na posicao 2 e nao tiver uma barra '
                        'ou caso o indice estiver na posicao 5 e nao tiver uma barra'
                        'Retornar Falso'
                        If ((Not (expressao(i).Equals(posicao) And expressao(2).Equals(Chr(47)) Or expressao(5).Equals(Chr(47))))) Then
                            Return False
                        End If

                        If (i <> 2 And i <> 5) Then
                            If (valor < Chr(48) Or valor > Chr(57)) Then
                                Return False
                            End If
                        End If
                    Next posicao
                Next i
            End If
        End If
        Return True
    End Function
End Class

