<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_PainelInstituicao
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_PainelInstituicao))
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.tbx_NomeEntidade = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.btn_CadastrarEntidade = New MetroFramework.Controls.MetroButton()
        Me.btn_Cancelar = New MetroFramework.Controls.MetroButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MetroTextBox3 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox4 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox5 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.AdvInstituicoesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdvocacyDataSet1 = New AplicAvocacy.AdvocacyDataSet()
        Me.dgv_Instituicao = New System.Windows.Forms.DataGridView()
        Me.tbx_Pesquisar = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.btn_Pesquisar = New MetroFramework.Controls.MetroButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvInstituicoesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvocacyDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Instituicao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(18, 123)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(120, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Nome da Entidade"
        '
        'tbx_NomeEntidade
        '
        '
        '
        '
        Me.tbx_NomeEntidade.CustomButton.Image = Nothing
        Me.tbx_NomeEntidade.CustomButton.Location = New System.Drawing.Point(175, 1)
        Me.tbx_NomeEntidade.CustomButton.Name = ""
        Me.tbx_NomeEntidade.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbx_NomeEntidade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbx_NomeEntidade.CustomButton.TabIndex = 1
        Me.tbx_NomeEntidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbx_NomeEntidade.CustomButton.UseSelectable = True
        Me.tbx_NomeEntidade.CustomButton.Visible = False
        Me.tbx_NomeEntidade.Lines = New String(-1) {}
        Me.tbx_NomeEntidade.Location = New System.Drawing.Point(148, 119)
        Me.tbx_NomeEntidade.MaxLength = 32767
        Me.tbx_NomeEntidade.Name = "tbx_NomeEntidade"
        Me.tbx_NomeEntidade.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbx_NomeEntidade.PromptText = "Entidade"
        Me.tbx_NomeEntidade.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbx_NomeEntidade.SelectedText = ""
        Me.tbx_NomeEntidade.SelectionLength = 0
        Me.tbx_NomeEntidade.SelectionStart = 0
        Me.tbx_NomeEntidade.ShortcutsEnabled = True
        Me.tbx_NomeEntidade.Size = New System.Drawing.Size(197, 23)
        Me.tbx_NomeEntidade.TabIndex = 1
        Me.tbx_NomeEntidade.UseSelectable = True
        Me.tbx_NomeEntidade.WaterMark = "Entidade"
        Me.tbx_NomeEntidade.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbx_NomeEntidade.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(-1, 182)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(143, 19)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Unidade da Federação"
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 23
        Me.MetroComboBox1.Items.AddRange(New Object() {"Acre ", "Alagoas ", "Amapá ", "Amazonas ", "Bahia ", "Ceará ", "Distrito Federal ", "Espírito Santo ", "Goiás ", "Maranhão ", "Mato Grosso ", "Mato Grosso do Sul ", "Minas Gerais ", "Pará ", "Paraíba ", "Paraná ", "Pernambuco ", "Piauí ", "Rio de Janeiro ", "Rio Grande do Norte ", "Rio Grande do Sul ", "Rondônia ", "Roraima ", "Santa Catarina ", "São Paulo ", "Sergipe ", "Tocantins "})
        Me.MetroComboBox1.Location = New System.Drawing.Point(148, 177)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(197, 29)
        Me.MetroComboBox1.TabIndex = 3
        Me.MetroComboBox1.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(99, 213)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(40, 19)
        Me.MetroLabel3.TabIndex = 4
        Me.MetroLabel3.Text = "CNPJ"
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = Nothing
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(175, 1)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(148, 213)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.PromptText = "xx.xxx.xxx/xxxx-xx"
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.ShortcutsEnabled = True
        Me.MetroTextBox1.Size = New System.Drawing.Size(197, 23)
        Me.MetroTextBox1.TabIndex = 5
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMark = "xx.xxx.xxx/xxxx-xx"
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTextBox2
        '
        '
        '
        '
        Me.MetroTextBox2.CustomButton.Image = Nothing
        Me.MetroTextBox2.CustomButton.Location = New System.Drawing.Point(175, 1)
        Me.MetroTextBox2.CustomButton.Name = ""
        Me.MetroTextBox2.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox2.CustomButton.TabIndex = 1
        Me.MetroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox2.CustomButton.UseSelectable = True
        Me.MetroTextBox2.CustomButton.Visible = False
        Me.MetroTextBox2.Lines = New String(-1) {}
        Me.MetroTextBox2.Location = New System.Drawing.Point(148, 242)
        Me.MetroTextBox2.MaxLength = 32767
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox2.PromptText = "xx.xxx.xxx/xxxx-xx"
        Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox2.SelectedText = ""
        Me.MetroTextBox2.SelectionLength = 0
        Me.MetroTextBox2.SelectionStart = 0
        Me.MetroTextBox2.ShortcutsEnabled = True
        Me.MetroTextBox2.Size = New System.Drawing.Size(197, 23)
        Me.MetroTextBox2.TabIndex = 7
        Me.MetroTextBox2.UseSelectable = True
        Me.MetroTextBox2.WaterMark = "xx.xxx.xxx/xxxx-xx"
        Me.MetroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(75, 242)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(64, 19)
        Me.MetroLabel4.TabIndex = 6
        Me.MetroLabel4.Text = "Endereço"
        '
        'btn_CadastrarEntidade
        '
        Me.btn_CadastrarEntidade.Location = New System.Drawing.Point(267, 329)
        Me.btn_CadastrarEntidade.Name = "btn_CadastrarEntidade"
        Me.btn_CadastrarEntidade.Size = New System.Drawing.Size(78, 30)
        Me.btn_CadastrarEntidade.TabIndex = 8
        Me.btn_CadastrarEntidade.Text = "Cadastrar"
        Me.btn_CadastrarEntidade.UseSelectable = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(183, 329)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(78, 30)
        Me.btn_Cancelar.TabIndex = 9
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseSelectable = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(267, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'MetroTextBox3
        '
        '
        '
        '
        Me.MetroTextBox3.CustomButton.Image = Nothing
        Me.MetroTextBox3.CustomButton.Location = New System.Drawing.Point(175, 1)
        Me.MetroTextBox3.CustomButton.Name = ""
        Me.MetroTextBox3.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox3.CustomButton.TabIndex = 1
        Me.MetroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox3.CustomButton.UseSelectable = True
        Me.MetroTextBox3.CustomButton.Visible = False
        Me.MetroTextBox3.Lines = New String(-1) {}
        Me.MetroTextBox3.Location = New System.Drawing.Point(148, 148)
        Me.MetroTextBox3.MaxLength = 32767
        Me.MetroTextBox3.Name = "MetroTextBox3"
        Me.MetroTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox3.PromptText = "Vínculo Municipal"
        Me.MetroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox3.SelectedText = ""
        Me.MetroTextBox3.SelectionLength = 0
        Me.MetroTextBox3.SelectionStart = 0
        Me.MetroTextBox3.ShortcutsEnabled = True
        Me.MetroTextBox3.Size = New System.Drawing.Size(197, 23)
        Me.MetroTextBox3.TabIndex = 13
        Me.MetroTextBox3.UseSelectable = True
        Me.MetroTextBox3.WaterMark = "Vínculo Municipal"
        Me.MetroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox3.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(29, 148)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(109, 19)
        Me.MetroLabel5.TabIndex = 12
        Me.MetroLabel5.Text = "Órgão Vinculado"
        '
        'MetroTextBox4
        '
        '
        '
        '
        Me.MetroTextBox4.CustomButton.Image = Nothing
        Me.MetroTextBox4.CustomButton.Location = New System.Drawing.Point(39, 1)
        Me.MetroTextBox4.CustomButton.Name = ""
        Me.MetroTextBox4.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox4.CustomButton.TabIndex = 1
        Me.MetroTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox4.CustomButton.UseSelectable = True
        Me.MetroTextBox4.CustomButton.Visible = False
        Me.MetroTextBox4.Lines = New String(-1) {}
        Me.MetroTextBox4.Location = New System.Drawing.Point(148, 271)
        Me.MetroTextBox4.MaxLength = 32767
        Me.MetroTextBox4.Name = "MetroTextBox4"
        Me.MetroTextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox4.PromptText = "xx.xxx-xxx"
        Me.MetroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox4.SelectedText = ""
        Me.MetroTextBox4.SelectionLength = 0
        Me.MetroTextBox4.SelectionStart = 0
        Me.MetroTextBox4.ShortcutsEnabled = True
        Me.MetroTextBox4.Size = New System.Drawing.Size(61, 23)
        Me.MetroTextBox4.TabIndex = 15
        Me.MetroTextBox4.UseSelectable = True
        Me.MetroTextBox4.WaterMark = "xx.xxx-xxx"
        Me.MetroTextBox4.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox4.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(106, 271)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(33, 19)
        Me.MetroLabel6.TabIndex = 14
        Me.MetroLabel6.Text = "CEP"
        '
        'MetroTextBox5
        '
        '
        '
        '
        Me.MetroTextBox5.CustomButton.Image = Nothing
        Me.MetroTextBox5.CustomButton.Location = New System.Drawing.Point(175, 1)
        Me.MetroTextBox5.CustomButton.Name = ""
        Me.MetroTextBox5.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox5.CustomButton.TabIndex = 1
        Me.MetroTextBox5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox5.CustomButton.UseSelectable = True
        Me.MetroTextBox5.CustomButton.Visible = False
        Me.MetroTextBox5.Lines = New String(-1) {}
        Me.MetroTextBox5.Location = New System.Drawing.Point(148, 300)
        Me.MetroTextBox5.MaxLength = 32767
        Me.MetroTextBox5.Name = "MetroTextBox5"
        Me.MetroTextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox5.PromptText = "entidade@entidade.org"
        Me.MetroTextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox5.SelectedText = ""
        Me.MetroTextBox5.SelectionLength = 0
        Me.MetroTextBox5.SelectionStart = 0
        Me.MetroTextBox5.ShortcutsEnabled = True
        Me.MetroTextBox5.Size = New System.Drawing.Size(197, 23)
        Me.MetroTextBox5.TabIndex = 17
        Me.MetroTextBox5.UseSelectable = True
        Me.MetroTextBox5.WaterMark = "entidade@entidade.org"
        Me.MetroTextBox5.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox5.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(92, 300)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(47, 19)
        Me.MetroLabel7.TabIndex = 16
        Me.MetroLabel7.Text = "E-Mail"
        '
        'AdvocacyDataSet1
        '
        Me.AdvocacyDataSet1.DataSetName = "AdvocacyDataSet"
        Me.AdvocacyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgv_Instituicao
        '
        Me.dgv_Instituicao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Instituicao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Instituicao.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.dgv_Instituicao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Instituicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Instituicao.Location = New System.Drawing.Point(351, 71)
        Me.dgv_Instituicao.Name = "dgv_Instituicao"
        Me.dgv_Instituicao.Size = New System.Drawing.Size(661, 480)
        Me.dgv_Instituicao.TabIndex = 18
        '
        'tbx_Pesquisar
        '
        '
        '
        '
        Me.tbx_Pesquisar.CustomButton.Image = Nothing
        Me.tbx_Pesquisar.CustomButton.Location = New System.Drawing.Point(175, 1)
        Me.tbx_Pesquisar.CustomButton.Name = ""
        Me.tbx_Pesquisar.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbx_Pesquisar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbx_Pesquisar.CustomButton.TabIndex = 1
        Me.tbx_Pesquisar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbx_Pesquisar.CustomButton.UseSelectable = True
        Me.tbx_Pesquisar.CustomButton.Visible = False
        Me.tbx_Pesquisar.Lines = New String(-1) {}
        Me.tbx_Pesquisar.Location = New System.Drawing.Point(722, 29)
        Me.tbx_Pesquisar.MaxLength = 32767
        Me.tbx_Pesquisar.Name = "tbx_Pesquisar"
        Me.tbx_Pesquisar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbx_Pesquisar.PromptText = "Digite o termo a ser pesquisado"
        Me.tbx_Pesquisar.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbx_Pesquisar.SelectedText = ""
        Me.tbx_Pesquisar.SelectionLength = 0
        Me.tbx_Pesquisar.SelectionStart = 0
        Me.tbx_Pesquisar.ShortcutsEnabled = True
        Me.tbx_Pesquisar.Size = New System.Drawing.Size(197, 23)
        Me.tbx_Pesquisar.TabIndex = 19
        Me.tbx_Pesquisar.UseSelectable = True
        Me.tbx_Pesquisar.WaterMark = "Digite o termo a ser pesquisado"
        Me.tbx_Pesquisar.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbx_Pesquisar.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(653, 31)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(63, 19)
        Me.MetroLabel8.TabIndex = 20
        Me.MetroLabel8.Text = "Pesquisar"
        '
        'btn_Pesquisar
        '
        Me.btn_Pesquisar.BackgroundImage = CType(resources.GetObject("btn_Pesquisar.BackgroundImage"), System.Drawing.Image)
        Me.btn_Pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Pesquisar.Location = New System.Drawing.Point(925, 24)
        Me.btn_Pesquisar.Name = "btn_Pesquisar"
        Me.btn_Pesquisar.Size = New System.Drawing.Size(34, 33)
        Me.btn_Pesquisar.TabIndex = 21
        Me.btn_Pesquisar.UseSelectable = True
        '
        'frm_PainelInstituicao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 548)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_Pesquisar)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.tbx_Pesquisar)
        Me.Controls.Add(Me.dgv_Instituicao)
        Me.Controls.Add(Me.MetroTextBox5)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroTextBox4)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroTextBox3)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_CadastrarEntidade)
        Me.Controls.Add(Me.MetroTextBox2)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroTextBox1)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroComboBox1)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.tbx_NomeEntidade)
        Me.Controls.Add(Me.MetroLabel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_PainelInstituicao"
        Me.Text = "Cadastro de Instituições"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvInstituicoesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvocacyDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Instituicao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tbx_NomeEntidade As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_CadastrarEntidade As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_Cancelar As MetroFramework.Controls.MetroButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MetroTextBox3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox4 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox5 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents AdvInstituicoesBindingSource2 As BindingSource
    Friend WithEvents AdvocacyDataSet1 As AdvocacyDataSet
    Friend WithEvents dgv_Instituicao As DataGridView
    Friend WithEvents tbx_Pesquisar As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_Pesquisar As MetroFramework.Controls.MetroButton
End Class
