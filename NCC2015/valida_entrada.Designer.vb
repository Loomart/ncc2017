<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class valida_entrada
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(valida_entrada))
        Me.updateIntervalTimer = New System.Windows.Forms.Timer(Me.components)
        Me.partnerPictureBox = New System.Windows.Forms.PictureBox()
        Me.partnerNameLbl = New System.Windows.Forms.Label()
        Me.partnerClassLbl = New System.Windows.Forms.Label()
        Me.validaQuitBtn = New System.Windows.Forms.Button()
        Me.reasonLbl = New System.Windows.Forms.Label()
        CType(Me.partnerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'updateIntervalTimer
        '
        Me.updateIntervalTimer.Enabled = True
        Me.updateIntervalTimer.Interval = 7000
        '
        'partnerPictureBox
        '
        Me.partnerPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.partnerPictureBox.Name = "partnerPictureBox"
        Me.partnerPictureBox.Size = New System.Drawing.Size(150, 150)
        Me.partnerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.partnerPictureBox.TabIndex = 0
        Me.partnerPictureBox.TabStop = False
        '
        'partnerNameLbl
        '
        Me.partnerNameLbl.BackColor = System.Drawing.Color.Transparent
        Me.partnerNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerNameLbl.ForeColor = System.Drawing.Color.Snow
        Me.partnerNameLbl.Location = New System.Drawing.Point(168, 34)
        Me.partnerNameLbl.Name = "partnerNameLbl"
        Me.partnerNameLbl.Size = New System.Drawing.Size(462, 37)
        Me.partnerNameLbl.TabIndex = 3
        Me.partnerNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'partnerClassLbl
        '
        Me.partnerClassLbl.BackColor = System.Drawing.Color.Transparent
        Me.partnerClassLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerClassLbl.ForeColor = System.Drawing.Color.Snow
        Me.partnerClassLbl.Location = New System.Drawing.Point(168, 91)
        Me.partnerClassLbl.Name = "partnerClassLbl"
        Me.partnerClassLbl.Size = New System.Drawing.Size(462, 37)
        Me.partnerClassLbl.TabIndex = 4
        Me.partnerClassLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'validaQuitBtn
        '
        Me.validaQuitBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.validaQuitBtn.Image = Global.NCC2015.My.Resources.Resources.Close_Window_24
        Me.validaQuitBtn.Location = New System.Drawing.Point(580, 227)
        Me.validaQuitBtn.Name = "validaQuitBtn"
        Me.validaQuitBtn.Size = New System.Drawing.Size(50, 50)
        Me.validaQuitBtn.TabIndex = 16
        Me.validaQuitBtn.UseVisualStyleBackColor = False
        '
        'reasonLbl
        '
        Me.reasonLbl.BackColor = System.Drawing.Color.Transparent
        Me.reasonLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reasonLbl.ForeColor = System.Drawing.Color.Snow
        Me.reasonLbl.Location = New System.Drawing.Point(12, 201)
        Me.reasonLbl.Name = "reasonLbl"
        Me.reasonLbl.Size = New System.Drawing.Size(562, 76)
        Me.reasonLbl.TabIndex = 17
        Me.reasonLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'valida_entrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(642, 287)
        Me.Controls.Add(Me.reasonLbl)
        Me.Controls.Add(Me.validaQuitBtn)
        Me.Controls.Add(Me.partnerClassLbl)
        Me.Controls.Add(Me.partnerNameLbl)
        Me.Controls.Add(Me.partnerPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "valida_entrada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loomart - SocGest"
        CType(Me.partnerPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents partnerPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents partnerNameLbl As System.Windows.Forms.Label
    Friend WithEvents partnerClassLbl As System.Windows.Forms.Label
    Friend WithEvents validaQuitBtn As Button
    Friend WithEvents updateIntervalTimer As Timer
    Friend WithEvents reasonLbl As Label
End Class
