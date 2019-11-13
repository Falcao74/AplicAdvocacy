Imports System.Globalization

Public Class frm_PainelInstituicao
    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        Close()
    End Sub

    Private Sub frm_PainelInstituicao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim instituicaoDB As New InstituicaoDB()

        dgv_Instituicao.DataSource = instituicaoDB.Listar()

    End Sub
End Class