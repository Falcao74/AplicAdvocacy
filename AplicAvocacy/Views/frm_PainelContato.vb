Public Class frm_PainelContato
    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        Close()
    End Sub

    Private Sub frm_PainelContato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim contatoDB As New ContatoDB()

        dgv_Contato.DataSource = contatoDB.Listar()
        'dgv_Contato.Columns(0).Visible = False

    End Sub
End Class