<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class view_timetable
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(view_timetable))
        Me.timetableGridView = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timetable_day = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timetable_since = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timetable_until = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deleteRowBtn = New System.Windows.Forms.Button()
        Me.timetableViewCloseBtn = New System.Windows.Forms.Button()
        CType(Me.timetableGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timetableGridView
        '
        Me.timetableGridView.AllowUserToAddRows = False
        Me.timetableGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.timetableGridView.BackgroundColor = System.Drawing.Color.White
        Me.timetableGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.timetableGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.timetableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.timetableGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.timetable_day, Me.timetable_since, Me.timetable_until})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.timetableGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.timetableGridView.Location = New System.Drawing.Point(12, 12)
        Me.timetableGridView.Name = "timetableGridView"
        Me.timetableGridView.ReadOnly = True
        Me.timetableGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.timetableGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.timetableGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.timetableGridView.Size = New System.Drawing.Size(714, 249)
        Me.timetableGridView.TabIndex = 0
        '
        'ID
        '
        Me.ID.DataPropertyName = "id"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'timetable_day
        '
        Me.timetable_day.DataPropertyName = "day"
        Me.timetable_day.HeaderText = "Dia"
        Me.timetable_day.Name = "timetable_day"
        Me.timetable_day.ReadOnly = True
        '
        'timetable_since
        '
        Me.timetable_since.DataPropertyName = "begin"
        Me.timetable_since.HeaderText = "Inicio"
        Me.timetable_since.Name = "timetable_since"
        Me.timetable_since.ReadOnly = True
        '
        'timetable_until
        '
        Me.timetable_until.DataPropertyName = "end"
        Me.timetable_until.HeaderText = "Fim"
        Me.timetable_until.Name = "timetable_until"
        Me.timetable_until.ReadOnly = True
        '
        'deleteRowBtn
        '
        Me.deleteRowBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.deleteRowBtn.Image = Global.NCC2015.My.Resources.Resources.Delete_24
        Me.deleteRowBtn.Location = New System.Drawing.Point(620, 267)
        Me.deleteRowBtn.Name = "deleteRowBtn"
        Me.deleteRowBtn.Size = New System.Drawing.Size(50, 50)
        Me.deleteRowBtn.TabIndex = 2
        Me.deleteRowBtn.UseVisualStyleBackColor = False
        '
        'timetableViewCloseBtn
        '
        Me.timetableViewCloseBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.timetableViewCloseBtn.Image = Global.NCC2015.My.Resources.Resources.Close_Window_24
        Me.timetableViewCloseBtn.Location = New System.Drawing.Point(676, 267)
        Me.timetableViewCloseBtn.Name = "timetableViewCloseBtn"
        Me.timetableViewCloseBtn.Size = New System.Drawing.Size(50, 50)
        Me.timetableViewCloseBtn.TabIndex = 1
        Me.timetableViewCloseBtn.UseVisualStyleBackColor = False
        '
        'view_timetable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(738, 322)
        Me.ControlBox = False
        Me.Controls.Add(Me.deleteRowBtn)
        Me.Controls.Add(Me.timetableViewCloseBtn)
        Me.Controls.Add(Me.timetableGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "view_timetable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loomart - SocGest | Ver Horario"
        CType(Me.timetableGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents timetableGridView As System.Windows.Forms.DataGridView
    Friend WithEvents timetableViewCloseBtn As System.Windows.Forms.Button
    Friend WithEvents deleteRowBtn As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents timetable_day As DataGridViewTextBoxColumn
    Friend WithEvents timetable_since As DataGridViewTextBoxColumn
    Friend WithEvents timetable_until As DataGridViewTextBoxColumn
End Class
