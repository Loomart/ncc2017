<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class doPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(doPayment))
        Me.paymentQuitBtn = New System.Windows.Forms.Button()
        Me.paymentValueTxt = New System.Windows.Forms.TextBox()
        Me.paymentValueLbl = New System.Windows.Forms.Label()
        Me.paymentSaveBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'paymentQuitBtn
        '
        Me.paymentQuitBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.paymentQuitBtn.Image = Global.NCC2015.My.Resources.Resources.Close_Window_24
        Me.paymentQuitBtn.Location = New System.Drawing.Point(236, 61)
        Me.paymentQuitBtn.Name = "paymentQuitBtn"
        Me.paymentQuitBtn.Size = New System.Drawing.Size(50, 50)
        Me.paymentQuitBtn.TabIndex = 15
        Me.paymentQuitBtn.UseVisualStyleBackColor = False
        '
        'paymentValueTxt
        '
        Me.paymentValueTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentValueTxt.Location = New System.Drawing.Point(174, 7)
        Me.paymentValueTxt.Multiline = True
        Me.paymentValueTxt.Name = "paymentValueTxt"
        Me.paymentValueTxt.Size = New System.Drawing.Size(92, 40)
        Me.paymentValueTxt.TabIndex = 16
        '
        'paymentValueLbl
        '
        Me.paymentValueLbl.AutoSize = True
        Me.paymentValueLbl.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentValueLbl.Location = New System.Drawing.Point(13, 13)
        Me.paymentValueLbl.Name = "paymentValueLbl"
        Me.paymentValueLbl.Size = New System.Drawing.Size(155, 26)
        Me.paymentValueLbl.TabIndex = 18
        Me.paymentValueLbl.Text = "Valor a Pagar:"
        '
        'paymentSaveBtn
        '
        Me.paymentSaveBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.paymentSaveBtn.Image = Global.NCC2015.My.Resources.Resources.Save_24
        Me.paymentSaveBtn.Location = New System.Drawing.Point(180, 61)
        Me.paymentSaveBtn.Name = "paymentSaveBtn"
        Me.paymentSaveBtn.Size = New System.Drawing.Size(50, 50)
        Me.paymentSaveBtn.TabIndex = 19
        Me.paymentSaveBtn.UseVisualStyleBackColor = False
        '
        'doPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(294, 121)
        Me.ControlBox = False
        Me.Controls.Add(Me.paymentSaveBtn)
        Me.Controls.Add(Me.paymentValueLbl)
        Me.Controls.Add(Me.paymentValueTxt)
        Me.Controls.Add(Me.paymentQuitBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "doPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loomart - SocGest | Pagamento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents paymentQuitBtn As Button
    Friend WithEvents paymentValueTxt As TextBox
    Friend WithEvents paymentValueLbl As Label
    Friend WithEvents paymentSaveBtn As Button
End Class
