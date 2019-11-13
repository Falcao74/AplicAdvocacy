Public Class frm_Login
    Dim SQL As New ConexaoBanco

    Private Sub frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btn_Sair_Click(sender As Object, e As EventArgs) Handles btn_Sair.Click
        Close()
    End Sub

    Private Sub btn_Entrar_Click(sender As Object, e As EventArgs) Handles btn_Entrar.Click
        Me.Hide()
        frm_MenuPrincipal.Show()
    End Sub


End Class
