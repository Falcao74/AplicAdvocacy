Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class ConexaoBanco

    Public conexao = "SERVER=ppiserver.database.windows.net;DATABASE=Advocacy;Uid=aldeias;Pwd=r8Dg[9I#B{pP0V5x3v4"
    Public SQLConection As New SqlConnection With {.ConnectionString = conexao}
    Public SQLCommand As New SqlCommand

    Public Function DadosConexao() As String
        Return conexao
    End Function

    Public Function TemConexao() As Boolean
        Try
            SQLConection.Open()
            SQLConection.Close()
            Return True
        Catch ex As Exception
            MsgBox("Erro de conexão: " & Chr(13) & ex.Message, "Aviso", vbCritical)
            Return False
        End Try
    End Function
End Class
