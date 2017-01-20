<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class medic_form
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
        Me.medicCardNumberLbl = New System.Windows.Forms.Label()
        Me.medicEntityLbl = New System.Windows.Forms.Label()
        Me.medicCardTxt = New System.Windows.Forms.TextBox()
        Me.medicEntityTxt = New System.Windows.Forms.TextBox()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'medicCardNumberLbl
        '
        Me.medicCardNumberLbl.AutoSize = True
        Me.medicCardNumberLbl.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.medicCardNumberLbl.Location = New System.Drawing.Point(12, 36)
        Me.medicCardNumberLbl.Name = "medicCardNumberLbl"
        Me.medicCardNumberLbl.Size = New System.Drawing.Size(132, 16)
        Me.medicCardNumberLbl.TabIndex = 3
        Me.medicCardNumberLbl.Text = "N. Cartao Medico:"
        '
        'medicEntityLbl
        '
        Me.medicEntityLbl.AutoSize = True
        Me.medicEntityLbl.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.medicEntityLbl.Location = New System.Drawing.Point(70, 73)
        Me.medicEntityLbl.Name = "medicEntityLbl"
        Me.medicEntityLbl.Size = New System.Drawing.Size(74, 16)
        Me.medicEntityLbl.TabIndex = 4
        Me.medicEntityLbl.Text = "Entidade:"
        '
        'medicCardTxt
        '
        Me.medicCardTxt.Location = New System.Drawing.Point(150, 35)
        Me.medicCardTxt.Name = "medicCardTxt"
        Me.medicCardTxt.Size = New System.Drawing.Size(319, 20)
        Me.medicCardTxt.TabIndex = 5
        '
        'medicEntityTxt
        '
        Me.medicEntityTxt.Location = New System.Drawing.Point(150, 72)
        Me.medicEntityTxt.Name = "medicEntityTxt"
        Me.medicEntityTxt.Size = New System.Drawing.Size(319, 20)
        Me.medicEntityTxt.TabIndex = 6
        '
        'closeBtn
        '
        Me.closeBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.closeBtn.Image = Global.NCC2015.My.Resources.Resources.Close_Window_24
        Me.closeBtn.Location = New System.Drawing.Point(433, 113)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(36, 36)
        Me.closeBtn.TabIndex = 7
        Me.closeBtn.UseVisualStyleBackColor = False
        '
        'saveBtn
        '
        Me.saveBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.saveBtn.Image = Global.NCC2015.My.Resources.Resources.Save_24
        Me.saveBtn.Location = New System.Drawing.Point(391, 113)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(36, 36)
        Me.saveBtn.TabIndex = 8
        Me.saveBtn.UseVisualStyleBackColor = False
        '
        'medic_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(478, 158)
        Me.ControlBox = False
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.medicEntityTxt)
        Me.Controls.Add(Me.medicCardTxt)
        Me.Controls.Add(Me.medicEntityLbl)
        Me.Controls.Add(Me.medicCardNumberLbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "medic_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loomart - SocGest | Adicionar Info. Medica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents medicCardNumberLbl As Label
    Friend WithEvents medicEntityLbl As Label
    Friend WithEvents medicCardTxt As TextBox
    Friend WithEvents medicEntityTxt As TextBox
    Friend WithEvents closeBtn As Button
    Friend WithEvents saveBtn As Button
End Class
