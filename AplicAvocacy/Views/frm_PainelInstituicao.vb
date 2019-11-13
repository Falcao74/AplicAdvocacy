Imports System.Globalization

Public Class frm_PainelInstituicao
    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        Close()
    End Sub
    Public Sub atualizaDados(filtro As String)
        Dim instituicaoDB As New InstituicaoDB()
        Dim colunas As DataGridViewColumn

        dgv_Instituicao.DataSource = instituicaoDB.Listar(filtro)
        dgv_Instituicao.Refresh()
        ' Colunas que não devem aparecer na consulta
        dgv_Instituicao.Columns(0).Visible = False
        dgv_Instituicao.Columns(3).Visible = False
        dgv_Instituicao.Columns(6).Visible = False
        dgv_Instituicao.Columns(7).Visible = False
        dgv_Instituicao.Columns(8).Visible = False

        ' Dimensionamento de colunas Nome e email
        For Each colunas In dgv_Instituicao.Columns
            If (colunas.DataPropertyName = "Nome") Then
                colunas.Width = 220
            ElseIf (colunas.DataPropertyName = "Email") Then
                colunas.Width = 200
            End If
        Next
    End Sub

    Private Sub frm_PainelInstituicao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        atualizaDados("")
        tbx_Pesquisar.Text = ""
    End Sub

    Private Sub btn_Pesquisar_Click(sender As Object, e As EventArgs) Handles btn_Pesquisar.Click
        atualizaDados(tbx_Pesquisar.Text)
    End Sub

    Private Sub dgv_Instituicao_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Instituicao.CellContentClick

        tbx_NomeEntidade.Text = dgv_Instituicao.CurrentCell.Value.ToString()   ' DataBindings.ToString()
    End Sub
End Class