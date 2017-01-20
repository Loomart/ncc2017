<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class class_list
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(class_list))
        Me.listClassCloseBtn = New System.Windows.Forms.Button()
        Me.closeToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Loopartnerclass1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ncc_2015DataSet = New NCC2015.ncc_2015DataSet()
        Me.Loo_partner_class1TableAdapter = New NCC2015.ncc_2015DataSetTableAdapters.loo_partner_class1TableAdapter()
        Me.PartneridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PartnernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesdeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Loopartnerclass1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ncc_2015DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listClassCloseBtn
        '
        Me.listClassCloseBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.listClassCloseBtn.Image = Global.NCC2015.My.Resources.Resources.Close_Window_24
        Me.listClassCloseBtn.Location = New System.Drawing.Point(580, 546)
        Me.listClassCloseBtn.Name = "listClassCloseBtn"
        Me.listClassCloseBtn.Size = New System.Drawing.Size(50, 50)
        Me.listClassCloseBtn.TabIndex = 1
        Me.closeToolTip.SetToolTip(Me.listClassCloseBtn, "Fechar Janela")
        Me.listClassCloseBtn.UseVisualStyleBackColor = False
        '
        'closeToolTip
        '
        Me.closeToolTip.AutomaticDelay = 0
        Me.closeToolTip.AutoPopDelay = 5500
        Me.closeToolTip.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.closeToolTip.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.closeToolTip.InitialDelay = 0
        Me.closeToolTip.ReshowDelay = 110
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PartneridDataGridViewTextBoxColumn, Me.PartnernameDataGridViewTextBoxColumn, Me.DiaDataGridViewTextBoxColumn, Me.DesdeDataGridViewTextBoxColumn, Me.AteDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Loopartnerclass1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(618, 520)
        Me.DataGridView1.TabIndex = 2
        '
        'Loopartnerclass1BindingSource
        '
        Me.Loopartnerclass1BindingSource.DataMember = "loo_partner_class1"
        Me.Loopartnerclass1BindingSource.DataSource = Me.Ncc_2015DataSet
        '
        'Ncc_2015DataSet
        '
        Me.Ncc_2015DataSet.DataSetName = "ncc_2015DataSet"
        Me.Ncc_2015DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Loo_partner_class1TableAdapter
        '
        Me.Loo_partner_class1TableAdapter.ClearBeforeFill = True
        '
        'PartneridDataGridViewTextBoxColumn
        '
        Me.PartneridDataGridViewTextBoxColumn.DataPropertyName = "partner_id"
        Me.PartneridDataGridViewTextBoxColumn.HeaderText = "Número de Sócio"
        Me.PartneridDataGridViewTextBoxColumn.Name = "PartneridDataGridViewTextBoxColumn"
        Me.PartneridDataGridViewTextBoxColumn.ReadOnly = True
        Me.PartneridDataGridViewTextBoxColumn.Width = 138
        '
        'PartnernameDataGridViewTextBoxColumn
        '
        Me.PartnernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PartnernameDataGridViewTextBoxColumn.DataPropertyName = "partner_name"
        Me.PartnernameDataGridViewTextBoxColumn.HeaderText = "Nome"
        Me.PartnernameDataGridViewTextBoxColumn.Name = "PartnernameDataGridViewTextBoxColumn"
        Me.PartnernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiaDataGridViewTextBoxColumn
        '
        Me.DiaDataGridViewTextBoxColumn.DataPropertyName = "dia"
        Me.DiaDataGridViewTextBoxColumn.HeaderText = "Dia"
        Me.DiaDataGridViewTextBoxColumn.Name = "DiaDataGridViewTextBoxColumn"
        Me.DiaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DesdeDataGridViewTextBoxColumn
        '
        Me.DesdeDataGridViewTextBoxColumn.DataPropertyName = "desde"
        Me.DesdeDataGridViewTextBoxColumn.HeaderText = "Desde"
        Me.DesdeDataGridViewTextBoxColumn.Name = "DesdeDataGridViewTextBoxColumn"
        Me.DesdeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AteDataGridViewTextBoxColumn
        '
        Me.AteDataGridViewTextBoxColumn.DataPropertyName = "ate"
        Me.AteDataGridViewTextBoxColumn.HeaderText = "Até"
        Me.AteDataGridViewTextBoxColumn.Name = "AteDataGridViewTextBoxColumn"
        Me.AteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'class_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(650, 608)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.listClassCloseBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "class_list"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loomart - SocGest | Lista de Classes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Loopartnerclass1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ncc_2015DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents listClassCloseBtn As Button
    Friend WithEvents closeToolTip As ToolTip
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Loopartnerclass1BindingSource As BindingSource
    Friend WithEvents Ncc_2015DataSet As ncc_2015DataSet
    Friend WithEvents Loo_partner_class1TableAdapter As ncc_2015DataSetTableAdapters.loo_partner_class1TableAdapter
    Friend WithEvents PartneridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PartnernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DesdeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
