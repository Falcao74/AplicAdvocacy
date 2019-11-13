Imports System.Collections.ObjectModel
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Linq.Expressions
Imports System.Text
Imports AplicAvocacy.AdvocacyDataSetTableAdapters

Public Class ContatoDB
    Dim conexao As SqlConnection
    Dim comando As SqlCommand
    Dim banco As New ConexaoBanco()

    Sub New()
        conexao = New SqlConnection With {.ConnectionString = banco.DadosConexao()}
    End Sub

    Public Sub Incluir(umContato As Contato)
        Try
            comando = New SqlCommand(
            "INSERT INTO Adv_Contatos (Contato, Fone1, Fone2, eMail, Cargo, CNPJ, idOrgao, Obs)" &
            "VALUES (@nome, @fone1, @fone2, @email, @cargo, @cnpj, @idOrgao, @obs);", conexao)

            comando.Parameters.AddWithValue("@nome", umContato.Nome)
            comando.Parameters.AddWithValue("@fone1", umContato.Fone1)
            comando.Parameters.AddWithValue("@fone2", umContato.Fone2)
            comando.Parameters.AddWithValue("@email", umContato.Email)
            comando.Parameters.AddWithValue("@cargo", umContato.Cargo)
            comando.Parameters.AddWithValue("@cnpj", umContato.Cnpj)
            ' TODO tem de terminar ===>>>> comando.Parameters.AddWithValue("@idOrgao", umContato. CAMPO DO ÓRGÃO QUE PERTENCE)
            comando.Parameters.AddWithValue("@obs", umContato.Obs)

            ' Abrindo o Banco e executando a rotina de gravação de um novo contato
            conexao.Open()
            comando.ExecuteNonQuery()
            conexao.Close()

        Catch ex As Exception
            MsgBox("Erro ao Incluir o contato no banco de dados" & Chr(13) & ex.Message, "Aviso de Erro !", vbCritical)
        End Try
    End Sub

    Public Sub Excluir(umContato As Contato)
        Try
            comando = New SqlCommand("DELETE FROM Adv_Contatos WHERE CNPJ = @cnpj;", conexao)

            comando.Parameters.AddWithValue("@cnpj", umContato.Cnpj)

            ' Abrindo o Banco e executando a rotina de gravação de um novo contato
            conexao.Open()
            comando.ExecuteNonQuery()
            conexao.Close()

        Catch ex As Exception
            MsgBox("Erro ao Excluir o contado do banco de dados" & Chr(13) & ex.Message, "Aviso de Erro !", vbCritical)
        End Try
    End Sub

    Public Sub Alterar(umContato As Contato)
        Try
            comando = New SqlCommand(
                "UPDATE Adv_Contatos SET Contato = @contato, Fone1 = @fone1, Fone2 = @fone2, eMail = @email, Cargo = @cargo, idOrgao = @idOrgao, Obs = @obs 
                WHERE CNPJ = @cnpj", conexao)

            comando.Parameters.AddWithValue("@nome", umContato.Nome)
            comando.Parameters.AddWithValue("@fone1", umContato.Fone1)
            comando.Parameters.AddWithValue("@fone2", umContato.Fone2)
            comando.Parameters.AddWithValue("@email", umContato.Email)
            comando.Parameters.AddWithValue("@cargo", umContato.Cargo)
            comando.Parameters.AddWithValue("@cnpj", umContato.Cnpj)
            ' TODO tem de terminar ===>>>> comando.Parameters.AddWithValue("@idOrgao", umContato. CAMPO DO ÓRGÃO QUE PERTENCE)
            comando.Parameters.AddWithValue("@obs", umContato.Obs)

            ' Abrindo o Banco e executando a rotina de gravação de um novo contato
            conexao.Open()
            comando.ExecuteNonQuery()
            conexao.Close()

        Catch ex As Exception
            MsgBox("Erro ao atualizar o contato no banco de dados" & Chr(13) & ex.Message, "Aviso de Erro !", vbCritical)
        End Try
    End Sub

    Public Function Listar() ' Esta função recebe o nome como filtro para a lista, caso seja necessário
        Dim listaContato As New List(Of Contato)
        Dim dataReader As SqlDataReader

        comando = New SqlCommand("SELECT * FROM Adv_Contatos", conexao)
        Try

            conexao.Open()
            dataReader = comando.ExecuteReader()

            If (dataReader.HasRows) Then
                While (dataReader.Read())
                    listaContato.Add(New Contato(
                             CInt(dataReader("id_Contato")),
                             Convert.ToString(dataReader("Contato")),
                             Convert.ToString(dataReader("CNPJ")),
                             Convert.ToString(dataReader("Fone1")),
                             Convert.ToString(dataReader("Fone2")),
                             Convert.ToString(dataReader("Cargo")),
                             Convert.ToString(dataReader("eMail")),
                             Convert.ToString(dataReader("Obs"))))
                End While
            End If
        Catch ex As Exception
            MsgBox("Erro de dataReader " & Chr(13) & ex.Message, "Erro", vbCritical)
        End Try
        conexao.Close()

        Return listaContato

    End Function

End Class
