<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login_form))
        Me.username_lbl = New System.Windows.Forms.Label()
        Me.password_lbl = New System.Windows.Forms.Label()
        Me.username_txt = New System.Windows.Forms.TextBox()
        Me.password_txt = New System.Windows.Forms.TextBox()
        Me.login_btn = New System.Windows.Forms.Button()
        Me.sair_fake_login_btn = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.sair_fake_login_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'username_lbl
        '
        Me.username_lbl.AutoSize = True
        Me.username_lbl.Location = New System.Drawing.Point(39, 107)
        Me.username_lbl.Name = "username_lbl"
        Me.username_lbl.Size = New System.Drawing.Size(108, 19)
        Me.username_lbl.TabIndex = 4
        Me.username_lbl.Text = "Utilizador:"
        '
        'password_lbl
        '
        Me.password_lbl.AutoSize = True
        Me.password_lbl.Location = New System.Drawing.Point(12, 140)
        Me.password_lbl.Name = "password_lbl"
        Me.password_lbl.Size = New System.Drawing.Size(135, 19)
        Me.password_lbl.TabIndex = 5
        Me.password_lbl.Text = "Palavra-Passe:"
        '
        'username_txt
        '
        Me.username_txt.Location = New System.Drawing.Point(153, 104)
        Me.username_txt.Name = "username_txt"
        Me.username_txt.Size = New System.Drawing.Size(209, 26)
        Me.username_txt.TabIndex = 0
        '
        'password_txt
        '
        Me.password_txt.Location = New System.Drawing.Point(153, 137)
        Me.password_txt.Name = "password_txt"
        Me.password_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_txt.Size = New System.Drawing.Size(209, 26)
        Me.password_txt.TabIndex = 1
        '
        'login_btn
        '
        Me.login_btn.AutoSize = True
        Me.login_btn.BackColor = System.Drawing.SystemColors.Menu
        Me.login_btn.Image = Global.NCC2015.My.Resources.Resources.login
        Me.login_btn.Location = New System.Drawing.Point(380, 130)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(38, 38)
        Me.login_btn.TabIndex = 2
        Me.login_btn.UseVisualStyleBackColor = False
        '
        'sair_fake_login_btn
        '
        Me.sair_fake_login_btn.Location = New System.Drawing.Point(405, -8)
        Me.sair_fake_login_btn.Name = "sair_fake_login_btn"
        Me.sair_fake_login_btn.Size = New System.Drawing.Size(24, 26)
        Me.sair_fake_login_btn.TabIndex = 7
        Me.sair_fake_login_btn.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.NCC2015.My.Resources.Resources.logo_lumart
        Me.PictureBox2.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.PictureBox1.Image = Global.NCC2015.My.Resources.Resources.logo_ncc
        Me.PictureBox1.Location = New System.Drawing.Point(153, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'login_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(425, 173)
        Me.ControlBox = False
        Me.Controls.Add(Me.sair_fake_login_btn)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.password_txt)
        Me.Controls.Add(Me.username_txt)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.password_lbl)
        Me.Controls.Add(Me.username_lbl)
        Me.Controls.Add(Me.login_btn)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "login_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loomart - SocGest 2017| Login"
        CType(Me.sair_fake_login_btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents login_btn As System.Windows.Forms.Button
    Friend WithEvents username_lbl As System.Windows.Forms.Label
    Friend WithEvents password_lbl As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents username_txt As System.Windows.Forms.TextBox
    Friend WithEvents password_txt As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents sair_fake_login_btn As System.Windows.Forms.PictureBox
End Class
