Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Linq.Expressions
Imports System.Text
Imports AplicAvocacy.ConexaoBanco

Public Class InstituicaoDB
    Dim conexao As SqlConnection
    Dim comando As SqlCommand
    Dim banco As New ConexaoBanco()

    Sub New()
        conexao = New SqlConnection With {.ConnectionString = banco.DadosConexao()}
    End Sub

    Public Sub Incluir(umaInstituicao As Instituicao)
        Try
            comando = New SqlCommand(
            "INSERT INTO Adv_Instituicoes (NomeInstit, email, Site, Fone1, Fone2, Esfera, idMunicipio, Obs) " &
            "Values (@nome, @email, @site, @fone1, @fone2, @esfera, @idMunicipio, @obs);", conexao)

            comando.Parameters.AddWithValue("@nome", umaInstituicao.Nome)
            comando.Parameters.AddWithValue("@email", umaInstituicao.Email)
            comando.Parameters.AddWithValue("@site", umaInstituicao.Site)
            comando.Parameters.AddWithValue("@fone1", umaInstituicao.Fone1)
            comando.Parameters.AddWithValue("@fone2", umaInstituicao.Fone2)
            comando.Parameters.AddWithValue("@esfera", umaInstituicao.Esfera)
            comando.Parameters.AddWithValue("@idMunicipio", umaInstituicao.IdMunicipio)
            comando.Parameters.AddWithValue("@obs", umaInstituicao.Obs)

            conexao.Open()
            comando.ExecuteNonQuery()
            conexao.Close()

        Catch ex As Exception
            MsgBox("Erro ao Incluir A Instituição no banco de dados" & Chr(13) & ex.Message, "Aviso de Erro !", vbCritical)
        End Try
    End Sub

    Public Sub Excluir(umaInstituicao As Instituicao)
        Try
            comando = New SqlCommand("DELETE FROM Adv_Instituicoes WHERE idInstit = @id", conexao)

            comando.Parameters.AddWithValue("@id", umaInstituicao.Id)

            conexao.Open()
            comando.ExecuteNonQuery()
            conexao.Close()

        Catch ex As Exception
            MsgBox("Erro ao Excluir a Instituição do banco de dados" & Chr(13) & ex.Message, "Aviso de Erro !", vbCritical)
        End Try
    End Sub

    Public Sub Alterar(umaInstituicao As Instituicao)
        Try
            comando = New SqlCommand(
                "UPDATE Adv_Instituicoes SET NomeInstit = @nome, email = @email, Site = @site, Fone1 = @fone1, Fone2 = @fone2, 
                Esfera = @esfera, IdMunicipio = @idMunicipio, Obs = @obs WHERE idInstit = @id;", conexao)

            comando.Parameters.AddWithValue("@nome", umaInstituicao.Nome)
            comando.Parameters.AddWithValue("@email", umaInstituicao.Email)
            comando.Parameters.AddWithValue("@site", umaInstituicao.Site)
            comando.Parameters.AddWithValue("@fone1", umaInstituicao.Fone1)
            comando.Parameters.AddWithValue("@fone2", umaInstituicao.Fone2)
            comando.Parameters.AddWithValue("@esfera", umaInstituicao.Esfera)
            comando.Parameters.AddWithValue("@idMunicipio", umaInstituicao.IdMunicipio)
            comando.Parameters.AddWithValue("@obs", umaInstituicao.Obs)
            comando.Parameters.AddWithValue("@id", umaInstituicao.Id)

            conexao.Open()
            comando.ExecuteNonQuery()
            conexao.Close()

        Catch ex As Exception
            MsgBox("Erro ao Alterar a Instituição do banco de dados" & Chr(13) & ex.Message, "Aviso de Erro !", vbCritical)
        End Try
    End Sub

    Public Function Listar()
        Dim listaInstituicao As New List(Of Instituicao)
        Dim dataReader As SqlDataReader


        comando = New SqlCommand("SELECT * From Adv_Instituicoes", conexao)
        Try
            conexao.Open()
            dataReader = comando.ExecuteReader()
            If (dataReader.HasRows) Then

                While (dataReader.Read())
                    listaInstituicao.Add(New Instituicao(
                    CInt(dataReader(0).ToString()),
                    Convert.ToString(dataReader(1)),
                    Convert.ToString(dataReader(2)),
                    Convert.ToString(dataReader(3)),
                    Convert.ToString(dataReader(4)),
                    Convert.ToString(dataReader(5)),
                    Convert.ToChar(dataReader(6)),
                    Convert.ToString(dataReader(7)),
                    Convert.ToString(dataReader(8)))
                    )
                End While
            End If
        Catch ex As Exception
            MsgBox("Erro de dataReader " & Chr(13) & ex.Message, "Erro", vbCritical)
        End Try
        conexao.Close()

        Return listaInstituicao

    End Function
End Class
