<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class search_partner
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
        Me.searchPartnerTxt = New System.Windows.Forms.TextBox()
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'searchPartnerTxt
        '
        Me.searchPartnerTxt.Location = New System.Drawing.Point(32, 21)
        Me.searchPartnerTxt.Name = "searchPartnerTxt"
        Me.searchPartnerTxt.Size = New System.Drawing.Size(50, 20)
        Me.searchPartnerTxt.TabIndex = 0
        '
        'searchBtn
        '
        Me.searchBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.searchBtn.Image = Global.NCC2015.My.Resources.Resources.Search_24
        Me.searchBtn.Location = New System.Drawing.Point(88, 12)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(36, 36)
        Me.searchBtn.TabIndex = 1
        Me.searchBtn.UseVisualStyleBackColor = False
        '
        'closeBtn
        '
        Me.closeBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.closeBtn.Image = Global.NCC2015.My.Resources.Resources.Close_Window_24
        Me.closeBtn.Location = New System.Drawing.Point(130, 12)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(36, 36)
        Me.closeBtn.TabIndex = 1
        Me.closeBtn.UseVisualStyleBackColor = False
        '
        'search_partner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(203, 61)
        Me.ControlBox = False
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.searchBtn)
        Me.Controls.Add(Me.searchPartnerTxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "search_partner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loomart - SocGest | Procurar Sócio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents searchPartnerTxt As TextBox
    Friend WithEvents searchBtn As Button
    Friend WithEvents closeBtn As Button
End Class
