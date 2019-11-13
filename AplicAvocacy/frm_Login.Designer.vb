<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Login
    Inherits Modelo

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnl_Login = New MetroFramework.Controls.MetroPanel()
        Me.tbx_Login = New MetroFramework.Controls.MetroTextBox()
        Me.tbx_Senha = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.btn_Sair = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.btn_Entrar = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Login.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AplicAvocacy.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(6, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(216, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'pnl_Login
        '
        Me.pnl_Login.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_Login.Controls.Add(Me.PictureBox2)
        Me.pnl_Login.Controls.Add(Me.tbx_Login)
        Me.pnl_Login.Controls.Add(Me.tbx_Senha)
        Me.pnl_Login.Controls.Add(Me.MetroLabel2)
        Me.pnl_Login.Controls.Add(Me.btn_Sair)
        Me.pnl_Login.Controls.Add(Me.MetroLabel3)
        Me.pnl_Login.Controls.Add(Me.btn_Entrar)
        Me.pnl_Login.HorizontalScrollbarBarColor = True
        Me.pnl_Login.HorizontalScrollbarHighlightOnWheel = False
        Me.pnl_Login.HorizontalScrollbarSize = 10
        Me.pnl_Login.Location = New System.Drawing.Point(77, 108)
        Me.pnl_Login.Name = "pnl_Login"
        Me.pnl_Login.Size = New System.Drawing.Size(469, 175)
        Me.pnl_Login.TabIndex = 7
        Me.pnl_Login.VerticalScrollbarBarColor = True
        Me.pnl_Login.VerticalScrollbarHighlightOnWheel = False
        Me.pnl_Login.VerticalScrollbarSize = 10
        '
        'tbx_Login
        '
        '
        '
        '
        Me.tbx_Login.CustomButton.Image = Nothing
        Me.tbx_Login.CustomButton.Location = New System.Drawing.Point(143, 1)
        Me.tbx_Login.CustomButton.Name = ""
        Me.tbx_Login.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbx_Login.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbx_Login.CustomButton.TabIndex = 1
        Me.tbx_Login.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbx_Login.CustomButton.UseSelectable = True
        Me.tbx_Login.CustomButton.Visible = False
        Me.tbx_Login.Lines = New String() {"Login"}
        Me.tbx_Login.Location = New System.Drawing.Point(67, 50)
        Me.tbx_Login.MaxLength = 32767
        Me.tbx_Login.Name = "tbx_Login"
        Me.tbx_Login.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbx_Login.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbx_Login.SelectedText = ""
        Me.tbx_Login.SelectionLength = 0
        Me.tbx_Login.SelectionStart = 0
        Me.tbx_Login.ShortcutsEnabled = True
        Me.tbx_Login.Size = New System.Drawing.Size(165, 23)
        Me.tbx_Login.TabIndex = 1
        Me.tbx_Login.Text = "Login"
        Me.tbx_Login.UseSelectable = True
        Me.tbx_Login.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbx_Login.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tbx_Senha
        '
        '
        '
        '
        Me.tbx_Senha.CustomButton.Image = Nothing
        Me.tbx_Senha.CustomButton.Location = New System.Drawing.Point(143, 1)
        Me.tbx_Senha.CustomButton.Name = ""
        Me.tbx_Senha.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbx_Senha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbx_Senha.CustomButton.TabIndex = 1
        Me.tbx_Senha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbx_Senha.CustomButton.UseSelectable = True
        Me.tbx_Senha.CustomButton.Visible = False
        Me.tbx_Senha.Lines = New String() {"Senha"}
        Me.tbx_Senha.Location = New System.Drawing.Point(67, 82)
        Me.tbx_Senha.MaxLength = 32767
        Me.tbx_Senha.Name = "tbx_Senha"
        Me.tbx_Senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbx_Senha.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbx_Senha.SelectedText = ""
        Me.tbx_Senha.SelectionLength = 0
        Me.tbx_Senha.SelectionStart = 0
        Me.tbx_Senha.ShortcutsEnabled = True
        Me.tbx_Senha.Size = New System.Drawing.Size(165, 23)
        Me.tbx_Senha.TabIndex = 2
        Me.tbx_Senha.Text = "Senha"
        Me.tbx_Senha.UseSelectable = True
        Me.tbx_Senha.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbx_Senha.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(3, 51)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Login"
        '
        'btn_Sair
        '
        Me.btn_Sair.Location = New System.Drawing.Point(67, 119)
        Me.btn_Sair.Name = "btn_Sair"
        Me.btn_Sair.Size = New System.Drawing.Size(75, 23)
        Me.btn_Sair.TabIndex = 4
        Me.btn_Sair.Text = "Sair"
        Me.btn_Sair.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(3, 83)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(44, 19)
        Me.MetroLabel3.TabIndex = 2
        Me.MetroLabel3.Text = "Senha"
        '
        'btn_Entrar
        '
        Me.btn_Entrar.Location = New System.Drawing.Point(157, 119)
        Me.btn_Entrar.Name = "btn_Entrar"
        Me.btn_Entrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Entrar.TabIndex = 3
        Me.btn_Entrar.Text = "Entrar"
        Me.btn_Entrar.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(519, 29)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(86, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "AplicAvocacy"
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(256, 23)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(192, 132)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 367)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pnl_Login)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "frm_Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Login.ResumeLayout(False)
        Me.pnl_Login.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_Entrar As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_Sair As MetroFramework.Controls.MetroButton
    Friend WithEvents tbx_Login As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbx_Senha As MetroFramework.Controls.MetroTextBox
    Friend WithEvents pnl_Login As MetroFramework.Controls.MetroPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
