<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main_form))
        Me.adiciona_socio_btn = New System.Windows.Forms.Button()
        Me.altera_socio_btn = New System.Windows.Forms.Button()
        Me.ficha_incricao_btn = New System.Windows.Forms.Button()
        Me.classes_btn = New System.Windows.Forms.Button()
        Me.depesas_proveitos_btn = New System.Windows.Forms.Button()
        Me.pagamentos_btn = New System.Windows.Forms.Button()
        Me.sair_btn = New System.Windows.Forms.Button()
        Me.admin_btn = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mainToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'adiciona_socio_btn
        '
        Me.adiciona_socio_btn.BackColor = System.Drawing.SystemColors.Menu
        Me.adiciona_socio_btn.Image = Global.NCC2015.My.Resources.Resources.add_socio
        Me.adiciona_socio_btn.Location = New System.Drawing.Point(18, 181)
        Me.adiciona_socio_btn.Name = "adiciona_socio_btn"
        Me.adiciona_socio_btn.Size = New System.Drawing.Size(62, 55)
        Me.adiciona_socio_btn.TabIndex = 2
        Me.mainToolTip.SetToolTip(Me.adiciona_socio_btn, "Adicionar Sócio")
        Me.adiciona_socio_btn.UseVisualStyleBackColor = False
        '
        'altera_socio_btn
        '
        Me.altera_socio_btn.BackColor = System.Drawing.SystemColors.Menu
        Me.altera_socio_btn.Image = Global.NCC2015.My.Resources.Resources.change_user
        Me.altera_socio_btn.Location = New System.Drawing.Point(80, 181)
        Me.altera_socio_btn.Name = "altera_socio_btn"
        Me.altera_socio_btn.Size = New System.Drawing.Size(62, 55)
        Me.altera_socio_btn.TabIndex = 3
        Me.mainToolTip.SetToolTip(Me.altera_socio_btn, "Alterar Sócio")
        Me.altera_socio_btn.UseVisualStyleBackColor = False
        '
        'ficha_incricao_btn
        '
        Me.ficha_incricao_btn.BackColor = System.Drawing.SystemColors.Menu
        Me.ficha_incricao_btn.Image = Global.NCC2015.My.Resources.Resources.ficha_inscricao
        Me.ficha_incricao_btn.Location = New System.Drawing.Point(142, 181)
        Me.ficha_incricao_btn.Name = "ficha_incricao_btn"
        Me.ficha_incricao_btn.Size = New System.Drawing.Size(62, 55)
        Me.ficha_incricao_btn.TabIndex = 4
        Me.mainToolTip.SetToolTip(Me.ficha_incricao_btn, "Ver Fichas de Inscrição")
        Me.ficha_incricao_btn.UseVisualStyleBackColor = False
        '
        'classes_btn
        '
        Me.classes_btn.BackColor = System.Drawing.SystemColors.Menu
        Me.classes_btn.Image = Global.NCC2015.My.Resources.Resources.classes
        Me.classes_btn.Location = New System.Drawing.Point(204, 181)
        Me.classes_btn.Name = "classes_btn"
        Me.classes_btn.Size = New System.Drawing.Size(62, 55)
        Me.classes_btn.TabIndex = 5
        Me.mainToolTip.SetToolTip(Me.classes_btn, "Listar Classes")
        Me.classes_btn.UseVisualStyleBackColor = False
        '
        'depesas_proveitos_btn
        '
        Me.depesas_proveitos_btn.BackColor = System.Drawing.SystemColors.Menu
        Me.depesas_proveitos_btn.Image = Global.NCC2015.My.Resources.Resources.despesas_proveito
        Me.depesas_proveitos_btn.Location = New System.Drawing.Point(266, 181)
        Me.depesas_proveitos_btn.Name = "depesas_proveitos_btn"
        Me.depesas_proveitos_btn.Size = New System.Drawing.Size(62, 55)
        Me.depesas_proveitos_btn.TabIndex = 6
        Me.mainToolTip.SetToolTip(Me.depesas_proveitos_btn, "Despesas / Proveitos")
        Me.depesas_proveitos_btn.UseVisualStyleBackColor = False
        '
        'pagamentos_btn
        '
        Me.pagamentos_btn.BackColor = System.Drawing.SystemColors.Menu
        Me.pagamentos_btn.Image = Global.NCC2015.My.Resources.Resources.pagamentos
        Me.pagamentos_btn.Location = New System.Drawing.Point(18, 242)
        Me.pagamentos_btn.Name = "pagamentos_btn"
        Me.pagamentos_btn.Size = New System.Drawing.Size(62, 55)
        Me.pagamentos_btn.TabIndex = 7
        Me.mainToolTip.SetToolTip(Me.pagamentos_btn, "Pagamentos")
        Me.pagamentos_btn.UseVisualStyleBackColor = False
        '
        'sair_btn
        '
        Me.sair_btn.BackColor = System.Drawing.SystemColors.Menu
        Me.sair_btn.Image = Global.NCC2015.My.Resources.Resources.sair
        Me.sair_btn.Location = New System.Drawing.Point(266, 242)
        Me.sair_btn.Name = "sair_btn"
        Me.sair_btn.Size = New System.Drawing.Size(62, 55)
        Me.sair_btn.TabIndex = 11
        Me.mainToolTip.SetToolTip(Me.sair_btn, "Sair")
        Me.sair_btn.UseVisualStyleBackColor = False
        '
        'admin_btn
        '
        Me.admin_btn.BackColor = System.Drawing.SystemColors.Menu
        Me.admin_btn.Image = Global.NCC2015.My.Resources.Resources.administrar
        Me.admin_btn.Location = New System.Drawing.Point(204, 242)
        Me.admin_btn.Name = "admin_btn"
        Me.admin_btn.Size = New System.Drawing.Size(62, 55)
        Me.admin_btn.TabIndex = 10
        Me.mainToolTip.SetToolTip(Me.admin_btn, "Configurar")
        Me.admin_btn.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.Menu
        Me.Button8.Enabled = False
        Me.Button8.Image = Global.NCC2015.My.Resources.Resources.invalido
        Me.Button8.Location = New System.Drawing.Point(142, 242)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(62, 55)
        Me.Button8.TabIndex = 9
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.Menu
        Me.Button7.Enabled = False
        Me.Button7.Image = Global.NCC2015.My.Resources.Resources.invalido
        Me.Button7.Location = New System.Drawing.Point(80, 242)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(62, 55)
        Me.Button7.TabIndex = 8
        Me.Button7.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(-2, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 19)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.NCC2015.My.Resources.Resources.logo_ncc
        Me.PictureBox1.Location = New System.Drawing.Point(53, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(239, 143)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.mainToolTip.SetToolTip(Me.PictureBox1, "25 anos a cortar líquido :)")
        '
        'mainToolTip
        '
        Me.mainToolTip.AutomaticDelay = 0
        Me.mainToolTip.AutoPopDelay = 5500
        Me.mainToolTip.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.mainToolTip.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.mainToolTip.InitialDelay = 0
        Me.mainToolTip.ReshowDelay = 0
        '
        'main_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(344, 315)
        Me.ControlBox = False
        Me.Controls.Add(Me.sair_btn)
        Me.Controls.Add(Me.admin_btn)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.pagamentos_btn)
        Me.Controls.Add(Me.depesas_proveitos_btn)
        Me.Controls.Add(Me.classes_btn)
        Me.Controls.Add(Me.ficha_incricao_btn)
        Me.Controls.Add(Me.altera_socio_btn)
        Me.Controls.Add(Me.adiciona_socio_btn)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "main_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loomart - SocGest"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents adiciona_socio_btn As System.Windows.Forms.Button
    Friend WithEvents altera_socio_btn As System.Windows.Forms.Button
    Friend WithEvents ficha_incricao_btn As System.Windows.Forms.Button
    Friend WithEvents classes_btn As System.Windows.Forms.Button
    Friend WithEvents depesas_proveitos_btn As System.Windows.Forms.Button
    Friend WithEvents pagamentos_btn As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents admin_btn As System.Windows.Forms.Button
    Friend WithEvents sair_btn As System.Windows.Forms.Button
    Friend WithEvents mainToolTip As ToolTip
End Class
