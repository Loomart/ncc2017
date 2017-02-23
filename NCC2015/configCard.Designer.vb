<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class configCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(configCard))
        Me.cfgQuitBtn = New System.Windows.Forms.Button()
        Me.stopConfBtn = New System.Windows.Forms.Button()
        Me.readConfBtn = New System.Windows.Forms.Button()
        Me.requestConfBtn = New System.Windows.Forms.Button()
        Me.writeConfBtn = New System.Windows.Forms.Button()
        Me.serialConfBtn = New System.Windows.Forms.Label()
        Me.dataConfBtn = New System.Windows.Forms.Label()
        Me.numConfTxt = New System.Windows.Forms.TextBox()
        Me.dataConfLbl = New System.Windows.Forms.Label()
        Me.serialConfLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cfgQuitBtn
        '
        Me.cfgQuitBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.cfgQuitBtn.Image = Global.NCC2015.My.Resources.Resources.Close_Window_24
        Me.cfgQuitBtn.Location = New System.Drawing.Point(400, 131)
        Me.cfgQuitBtn.Name = "cfgQuitBtn"
        Me.cfgQuitBtn.Size = New System.Drawing.Size(50, 50)
        Me.cfgQuitBtn.TabIndex = 0
        Me.cfgQuitBtn.UseVisualStyleBackColor = False
        '
        'stopConfBtn
        '
        Me.stopConfBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.stopConfBtn.Location = New System.Drawing.Point(315, 131)
        Me.stopConfBtn.Name = "stopConfBtn"
        Me.stopConfBtn.Size = New System.Drawing.Size(79, 50)
        Me.stopConfBtn.TabIndex = 1
        Me.stopConfBtn.Text = "Parar"
        Me.stopConfBtn.UseVisualStyleBackColor = False
        '
        'readConfBtn
        '
        Me.readConfBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.readConfBtn.Location = New System.Drawing.Point(143, 131)
        Me.readConfBtn.Name = "readConfBtn"
        Me.readConfBtn.Size = New System.Drawing.Size(79, 50)
        Me.readConfBtn.TabIndex = 2
        Me.readConfBtn.Text = "Ler"
        Me.readConfBtn.UseVisualStyleBackColor = False
        '
        'requestConfBtn
        '
        Me.requestConfBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.requestConfBtn.Location = New System.Drawing.Point(57, 131)
        Me.requestConfBtn.Name = "requestConfBtn"
        Me.requestConfBtn.Size = New System.Drawing.Size(79, 50)
        Me.requestConfBtn.TabIndex = 3
        Me.requestConfBtn.Text = "Solicitar"
        Me.requestConfBtn.UseVisualStyleBackColor = False
        '
        'writeConfBtn
        '
        Me.writeConfBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.writeConfBtn.Location = New System.Drawing.Point(229, 131)
        Me.writeConfBtn.Name = "writeConfBtn"
        Me.writeConfBtn.Size = New System.Drawing.Size(79, 50)
        Me.writeConfBtn.TabIndex = 4
        Me.writeConfBtn.Text = "Escrever"
        Me.writeConfBtn.UseVisualStyleBackColor = False
        '
        'serialConfBtn
        '
        Me.serialConfBtn.AutoSize = True
        Me.serialConfBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.serialConfBtn.Location = New System.Drawing.Point(53, 92)
        Me.serialConfBtn.Name = "serialConfBtn"
        Me.serialConfBtn.Size = New System.Drawing.Size(78, 20)
        Me.serialConfBtn.TabIndex = 5
        Me.serialConfBtn.Text = "N. Serie:"
        '
        'dataConfBtn
        '
        Me.dataConfBtn.AutoSize = True
        Me.dataConfBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataConfBtn.Location = New System.Drawing.Point(65, 62)
        Me.dataConfBtn.Name = "dataConfBtn"
        Me.dataConfBtn.Size = New System.Drawing.Size(66, 20)
        Me.dataConfBtn.TabIndex = 6
        Me.dataConfBtn.Text = "Dados:"
        '
        'numConfTxt
        '
        Me.numConfTxt.Location = New System.Drawing.Point(57, 26)
        Me.numConfTxt.Name = "numConfTxt"
        Me.numConfTxt.Size = New System.Drawing.Size(393, 20)
        Me.numConfTxt.TabIndex = 7
        '
        'dataConfLbl
        '
        Me.dataConfLbl.AutoSize = True
        Me.dataConfLbl.Location = New System.Drawing.Point(143, 67)
        Me.dataConfLbl.Name = "dataConfLbl"
        Me.dataConfLbl.Size = New System.Drawing.Size(0, 13)
        Me.dataConfLbl.TabIndex = 8
        '
        'serialConfLbl
        '
        Me.serialConfLbl.AutoSize = True
        Me.serialConfLbl.Location = New System.Drawing.Point(143, 97)
        Me.serialConfLbl.Name = "serialConfLbl"
        Me.serialConfLbl.Size = New System.Drawing.Size(0, 13)
        Me.serialConfLbl.TabIndex = 9
        '
        'configCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(507, 194)
        Me.ControlBox = False
        Me.Controls.Add(Me.serialConfLbl)
        Me.Controls.Add(Me.dataConfLbl)
        Me.Controls.Add(Me.numConfTxt)
        Me.Controls.Add(Me.dataConfBtn)
        Me.Controls.Add(Me.serialConfBtn)
        Me.Controls.Add(Me.writeConfBtn)
        Me.Controls.Add(Me.requestConfBtn)
        Me.Controls.Add(Me.readConfBtn)
        Me.Controls.Add(Me.stopConfBtn)
        Me.Controls.Add(Me.cfgQuitBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "configCard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loomart - SocGest | Configurar Cartao"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cfgQuitBtn As Button
    Friend WithEvents stopConfBtn As Button
    Friend WithEvents readConfBtn As Button
    Friend WithEvents requestConfBtn As Button
    Friend WithEvents writeConfBtn As Button
    Friend WithEvents serialConfBtn As Label
    Friend WithEvents dataConfBtn As Label
    Friend WithEvents numConfTxt As TextBox
    Friend WithEvents dataConfLbl As Label
    Friend WithEvents serialConfLbl As Label
End Class
