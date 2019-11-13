Imports System.Diagnostics
Public Class frm_MenuPrincipal
    Dim msg As String

    Private Sub FecharFormsFilhos()
        For Each F In Me.MdiChildren
            F.Close()
        Next
    End Sub

    Private Sub tsm_BtnSair_Click(sender As Object, e As EventArgs) Handles tsm_BtnSair.Click
        frm_Login.Close()
        Close()
    End Sub

    Private Sub tsm_BtnCadastros_Click(sender As Object, e As EventArgs) Handles tsm_BtnCadastros.Click

    End Sub

    Private Sub tsmi_CadUsuario_Click(sender As Object, e As EventArgs) Handles tsmi_CadUsuario.Click
        FecharFormsFilhos()
        frm_PainelUsuario.MdiParent = Me
        frm_PainelUsuario.Show()
        frm_PainelUsuario.Dock = DockStyle.Fill
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub tsmi_CadEntidadeMunicipal_Click(sender As Object, e As EventArgs) Handles tsmi_CadInstituicao.Click
        FecharFormsFilhos()
        frm_PainelInstituicao.MdiParent = Me
        frm_PainelInstituicao.Show()
        frm_PainelInstituicao.Dock = DockStyle.Fill
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub tsmi_CadContato_Click(sender As Object, e As EventArgs) Handles tsmi_CadContato.Click
        FecharFormsFilhos()
        frm_PainelContato.MdiParent = Me
        frm_PainelContato.Show()
        frm_PainelContato.Dock = DockStyle.Fill
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Process.Start("calc")
    End Sub

    Private Sub BlocoDeNotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlocoDeNotasToolStripMenuItem.Click
        Process.Start("notepad")
    End Sub

    Private Sub ExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcelToolStripMenuItem.Click
        Process.Start("Excel.exe")
    End Sub

    Private Sub WordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordToolStripMenuItem.Click
        Process.Start("winword.exe")
    End Sub

End Class