Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class ConexaoBanco

    Public conexao = "SERVER={YOUR_SERVER};DATABASE=Advocacy;Uid={YOUR_USER};Pwd={YOUR_PASSWORD}"
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
