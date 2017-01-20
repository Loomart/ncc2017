<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pagamentos_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pagamentos_form))
        Me.pagamentosQuitBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'pagamentosQuitBtn
        '
        Me.pagamentosQuitBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.pagamentosQuitBtn.Image = Global.NCC2015.My.Resources.Resources.Close_Window_24
        Me.pagamentosQuitBtn.Location = New System.Drawing.Point(529, 266)
        Me.pagamentosQuitBtn.Name = "pagamentosQuitBtn"
        Me.pagamentosQuitBtn.Size = New System.Drawing.Size(50, 50)
        Me.pagamentosQuitBtn.TabIndex = 20
        Me.pagamentosQuitBtn.UseVisualStyleBackColor = False
        '
        'pagamentos_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(603, 355)
        Me.ControlBox = False
        Me.Controls.Add(Me.pagamentosQuitBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "pagamentos_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loomart - SocGest | Pagamentos"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pagamentosQuitBtn As Button
End Class
