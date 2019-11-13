<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MenuPrincipal
    Inherits Modelo

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_MenuPrincipal))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsm_BtnCadastros = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsmi_CadContato = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_CadInstituicao = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_CadUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_BtnRelatorios = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsm_BtnMalaDireta = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsm_BtnProjetos = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsm_BtnAjuda = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsm_BtnFerramentas = New System.Windows.Forms.ToolStripDropDownButton()
        Me.BlocoDeNotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalendárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_BtnSair = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_BtnCadastros, Me.tsm_BtnRelatorios, Me.tsm_BtnMalaDireta, Me.tsm_BtnProjetos, Me.tsm_BtnAjuda, Me.tsm_BtnFerramentas, Me.tsm_BtnSair})
        Me.ToolStrip1.Location = New System.Drawing.Point(20, 60)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(760, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsm_BtnCadastros
        '
        Me.tsm_BtnCadastros.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_CadContato, Me.tsmi_CadInstituicao, Me.tsmi_CadUsuario})
        Me.tsm_BtnCadastros.Image = CType(resources.GetObject("tsm_BtnCadastros.Image"), System.Drawing.Image)
        Me.tsm_BtnCadastros.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsm_BtnCadastros.Name = "tsm_BtnCadastros"
        Me.tsm_BtnCadastros.Size = New System.Drawing.Size(88, 22)
        Me.tsm_BtnCadastros.Text = "&Cadastros"
        '
        'tsmi_CadContato
        '
        Me.tsmi_CadContato.Image = CType(resources.GetObject("tsmi_CadContato.Image"), System.Drawing.Image)
        Me.tsmi_CadContato.Name = "tsmi_CadContato"
        Me.tsmi_CadContato.Size = New System.Drawing.Size(180, 22)
        Me.tsmi_CadContato.Text = "C&ontatos"
        '
        'tsmi_CadInstituicao
        '
        Me.tsmi_CadInstituicao.Image = CType(resources.GetObject("tsmi_CadInstituicao.Image"), System.Drawing.Image)
        Me.tsmi_CadInstituicao.Name = "tsmi_CadInstituicao"
        Me.tsmi_CadInstituicao.Size = New System.Drawing.Size(180, 22)
        Me.tsmi_CadInstituicao.Text = "&Instituições"
        '
        'tsmi_CadUsuario
        '
        Me.tsmi_CadUsuario.Image = CType(resources.GetObject("tsmi_CadUsuario.Image"), System.Drawing.Image)
        Me.tsmi_CadUsuario.Name = "tsmi_CadUsuario"
        Me.tsmi_CadUsuario.Size = New System.Drawing.Size(180, 22)
        Me.tsmi_CadUsuario.Text = "&Usuários"
        '
        'tsm_BtnRelatorios
        '
        Me.tsm_BtnRelatorios.Image = CType(resources.GetObject("tsm_BtnRelatorios.Image"), System.Drawing.Image)
        Me.tsm_BtnRelatorios.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsm_BtnRelatorios.Name = "tsm_BtnRelatorios"
        Me.tsm_BtnRelatorios.Size = New System.Drawing.Size(88, 22)
        Me.tsm_BtnRelatorios.Text = "&Relatórios"
        '
        'tsm_BtnMalaDireta
        '
        Me.tsm_BtnMalaDireta.Image = CType(resources.GetObject("tsm_BtnMalaDireta.Image"), System.Drawing.Image)
        Me.tsm_BtnMalaDireta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsm_BtnMalaDireta.Name = "tsm_BtnMalaDireta"
        Me.tsm_BtnMalaDireta.Size = New System.Drawing.Size(96, 22)
        Me.tsm_BtnMalaDireta.Text = "&Mala Direta"
        '
        'tsm_BtnProjetos
        '
        Me.tsm_BtnProjetos.Image = CType(resources.GetObject("tsm_BtnProjetos.Image"), System.Drawing.Image)
        Me.tsm_BtnProjetos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsm_BtnProjetos.Name = "tsm_BtnProjetos"
        Me.tsm_BtnProjetos.Size = New System.Drawing.Size(79, 22)
        Me.tsm_BtnProjetos.Text = "&Projetos"
        '
        'tsm_BtnAjuda
        '
        Me.tsm_BtnAjuda.Image = CType(resources.GetObject("tsm_BtnAjuda.Image"), System.Drawing.Image)
        Me.tsm_BtnAjuda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsm_BtnAjuda.Name = "tsm_BtnAjuda"
        Me.tsm_BtnAjuda.Size = New System.Drawing.Size(67, 22)
        Me.tsm_BtnAjuda.Text = "&Ajuda"
        '
        'tsm_BtnFerramentas
        '
        Me.tsm_BtnFerramentas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BlocoDeNotasToolStripMenuItem, Me.CalculadoraToolStripMenuItem, Me.CalendárioToolStripMenuItem, Me.ExcelToolStripMenuItem, Me.WordToolStripMenuItem})
        Me.tsm_BtnFerramentas.Image = CType(resources.GetObject("tsm_BtnFerramentas.Image"), System.Drawing.Image)
        Me.tsm_BtnFerramentas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsm_BtnFerramentas.Name = "tsm_BtnFerramentas"
        Me.tsm_BtnFerramentas.Size = New System.Drawing.Size(101, 22)
        Me.tsm_BtnFerramentas.Text = "&Ferramentas"
        '
        'BlocoDeNotasToolStripMenuItem
        '
        Me.BlocoDeNotasToolStripMenuItem.Image = CType(resources.GetObject("BlocoDeNotasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BlocoDeNotasToolStripMenuItem.Name = "BlocoDeNotasToolStripMenuItem"
        Me.BlocoDeNotasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BlocoDeNotasToolStripMenuItem.Text = "Bloco de Notas"
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.Image = CType(resources.GetObject("CalculadoraToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'CalendárioToolStripMenuItem
        '
        Me.CalendárioToolStripMenuItem.Image = CType(resources.GetObject("CalendárioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CalendárioToolStripMenuItem.Name = "CalendárioToolStripMenuItem"
        Me.CalendárioToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CalendárioToolStripMenuItem.Text = "Calendário"
        '
        'ExcelToolStripMenuItem
        '
        Me.ExcelToolStripMenuItem.Image = CType(resources.GetObject("ExcelToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExcelToolStripMenuItem.Name = "ExcelToolStripMenuItem"
        Me.ExcelToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExcelToolStripMenuItem.Text = "Excel"
        '
        'WordToolStripMenuItem
        '
        Me.WordToolStripMenuItem.Image = CType(resources.GetObject("WordToolStripMenuItem.Image"), System.Drawing.Image)
        Me.WordToolStripMenuItem.Name = "WordToolStripMenuItem"
        Me.WordToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.WordToolStripMenuItem.Text = "Word"
        '
        'tsm_BtnSair
        '
        Me.tsm_BtnSair.Image = CType(resources.GetObject("tsm_BtnSair.Image"), System.Drawing.Image)
        Me.tsm_BtnSair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsm_BtnSair.Name = "tsm_BtnSair"
        Me.tsm_BtnSair.Size = New System.Drawing.Size(46, 22)
        Me.tsm_BtnSair.Text = "&Sair"
        '
        'frm_MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.ToolStrip1)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_MenuPrincipal"
        Me.Text = "Menu Principal"
        Me.TransparencyKey = System.Drawing.Color.Empty
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsm_BtnSair As ToolStripButton
    Friend WithEvents tsm_BtnCadastros As ToolStripDropDownButton
    Friend WithEvents tsmi_CadUsuario As ToolStripMenuItem
    Friend WithEvents tsmi_CadInstituicao As ToolStripMenuItem
    Friend WithEvents tsmi_CadContato As ToolStripMenuItem
    Friend WithEvents tsmi_CadEntidadeFederal As ToolStripMenuItem
    Friend WithEvents tsm_BtnRelatorios As ToolStripDropDownButton
    Friend WithEvents tsm_BtnMalaDireta As ToolStripDropDownButton
    Friend WithEvents tsm_BtnProjetos As ToolStripDropDownButton
    Friend WithEvents tsm_BtnAjuda As ToolStripDropDownButton
    Friend WithEvents tsm_BtnFerramentas As ToolStripDropDownButton
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlocoDeNotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalendárioToolStripMenuItem As ToolStripMenuItem
End Class
