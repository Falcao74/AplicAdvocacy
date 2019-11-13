Imports MetroFramework

Public Class frm_PainelUsuario
    Private Sub CadUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles btn_CadastrarUsuario.Click
        MetroMessageBox.Show(Owner, "Usuário Cadastrado com sucesso!", "Cadastro", MessageBoxIcon.Asterisk)

    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        Close()
    End Sub
End Class