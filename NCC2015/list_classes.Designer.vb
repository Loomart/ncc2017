<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class list_classes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(list_classes))
        Me.listClassBebe = New System.Windows.Forms.Button()
        Me.listClassCrianca = New System.Windows.Forms.Button()
        Me.listClassAdulto = New System.Windows.Forms.Button()
        Me.listClassManutencao = New System.Windows.Forms.Button()
        Me.listClassCompeticao = New System.Windows.Forms.Button()
        Me.listClassHidro = New System.Windows.Forms.Button()
        Me.listClassesQuitBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listClassBebe
        '
        Me.listClassBebe.BackColor = System.Drawing.SystemColors.Menu
        Me.listClassBebe.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listClassBebe.Location = New System.Drawing.Point(12, 12)
        Me.listClassBebe.Name = "listClassBebe"
        Me.listClassBebe.Size = New System.Drawing.Size(214, 54)
        Me.listClassBebe.TabIndex = 0
        Me.listClassBebe.Text = "Bébé"
        Me.listClassBebe.UseVisualStyleBackColor = False
        '
        'listClassCrianca
        '
        Me.listClassCrianca.BackColor = System.Drawing.SystemColors.Menu
        Me.listClassCrianca.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listClassCrianca.Location = New System.Drawing.Point(232, 12)
        Me.listClassCrianca.Name = "listClassCrianca"
        Me.listClassCrianca.Size = New System.Drawing.Size(214, 54)
        Me.listClassCrianca.TabIndex = 1
        Me.listClassCrianca.Text = "Criança"
        Me.listClassCrianca.UseVisualStyleBackColor = False
        '
        'listClassAdulto
        '
        Me.listClassAdulto.BackColor = System.Drawing.SystemColors.Menu
        Me.listClassAdulto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listClassAdulto.Location = New System.Drawing.Point(12, 72)
        Me.listClassAdulto.Name = "listClassAdulto"
        Me.listClassAdulto.Size = New System.Drawing.Size(214, 54)
        Me.listClassAdulto.TabIndex = 2
        Me.listClassAdulto.Text = "Adulto"
        Me.listClassAdulto.UseVisualStyleBackColor = False
        '
        'listClassManutencao
        '
        Me.listClassManutencao.BackColor = System.Drawing.SystemColors.Menu
        Me.listClassManutencao.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listClassManutencao.Location = New System.Drawing.Point(232, 72)
        Me.listClassManutencao.Name = "listClassManutencao"
        Me.listClassManutencao.Size = New System.Drawing.Size(214, 54)
        Me.listClassManutencao.TabIndex = 3
        Me.listClassManutencao.Text = "Manutenção"
        Me.listClassManutencao.UseVisualStyleBackColor = False
        '
        'listClassCompeticao
        '
        Me.listClassCompeticao.BackColor = System.Drawing.SystemColors.Menu
        Me.listClassCompeticao.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listClassCompeticao.Location = New System.Drawing.Point(232, 132)
        Me.listClassCompeticao.Name = "listClassCompeticao"
        Me.listClassCompeticao.Size = New System.Drawing.Size(214, 54)
        Me.listClassCompeticao.TabIndex = 4
        Me.listClassCompeticao.Text = "Competição"
        Me.listClassCompeticao.UseVisualStyleBackColor = False
        '
        'listClassHidro
        '
        Me.listClassHidro.BackColor = System.Drawing.SystemColors.Menu
        Me.listClassHidro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listClassHidro.Location = New System.Drawing.Point(12, 132)
        Me.listClassHidro.Name = "listClassHidro"
        Me.listClassHidro.Size = New System.Drawing.Size(214, 54)
        Me.listClassHidro.TabIndex = 5
        Me.listClassHidro.Text = "Hidroginástica"
        Me.listClassHidro.UseVisualStyleBackColor = False
        '
        'listClassesQuitBtn
        '
        Me.listClassesQuitBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.listClassesQuitBtn.Image = Global.NCC2015.My.Resources.Resources.Close_Window_24
        Me.listClassesQuitBtn.Location = New System.Drawing.Point(396, 192)
        Me.listClassesQuitBtn.Name = "listClassesQuitBtn"
        Me.listClassesQuitBtn.Size = New System.Drawing.Size(50, 50)
        Me.listClassesQuitBtn.TabIndex = 20
        Me.listClassesQuitBtn.UseVisualStyleBackColor = False
        '
        'list_classes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(461, 257)
        Me.ControlBox = False
        Me.Controls.Add(Me.listClassesQuitBtn)
        Me.Controls.Add(Me.listClassHidro)
        Me.Controls.Add(Me.listClassCompeticao)
        Me.Controls.Add(Me.listClassManutencao)
        Me.Controls.Add(Me.listClassAdulto)
        Me.Controls.Add(Me.listClassCrianca)
        Me.Controls.Add(Me.listClassBebe)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "list_classes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loomart - SocGest | Lista de Classes"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents listClassBebe As Button
    Friend WithEvents listClassCrianca As Button
    Friend WithEvents listClassAdulto As Button
    Friend WithEvents listClassManutencao As Button
    Friend WithEvents listClassCompeticao As Button
    Friend WithEvents listClassHidro As Button
    Friend WithEvents listClassesQuitBtn As Button
End Class
