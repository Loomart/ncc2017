<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class despesas_proveitos_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(despesas_proveitos_form))
        Me.despesasQuitBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'despesasQuitBtn
        '
        Me.despesasQuitBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.despesasQuitBtn.Image = Global.NCC2015.My.Resources.Resources.Close_Window_24
        Me.despesasQuitBtn.Location = New System.Drawing.Point(722, 499)
        Me.despesasQuitBtn.Name = "despesasQuitBtn"
        Me.despesasQuitBtn.Size = New System.Drawing.Size(50, 50)
        Me.despesasQuitBtn.TabIndex = 19
        Me.despesasQuitBtn.UseVisualStyleBackColor = False
        '
        'despesas_proveitos_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.despesasQuitBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "despesas_proveitos_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loomart - SocGest | Despesas e Proveitos"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents despesasQuitBtn As Button
End Class
