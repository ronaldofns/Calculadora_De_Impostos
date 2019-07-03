Imports System.Data.OleDb

Friend Module Mdl_Variaveis
    Public Funcoes As New ClsFuncoes
    Public reader As OleDb.OleDbDataReader
    Public Oledb_conexao As New OleDb.OleDbConnection
    Public rs As New OleDb.OleDbCommand
    Public str_conexao As String





    'Variaves CORREIOS preços e prazos
    Public tipoEnvio As Integer
    Public codigoFormatoInt As Integer
    Public comprimentoDecimal As Decimal
    Public alturaDecimal As Decimal
    Public larguraDecimal As Decimal
    Public diametroDecimal As Decimal
    Public valorDeclaradoDecimal As Decimal
    Public peso As Decimal
    Public maoPropria As String
    Public avisoRecebimento As String
    Public cepOrigem As String
    Public cepDestino As String



End Module
