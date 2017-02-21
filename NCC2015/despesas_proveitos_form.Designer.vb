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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(despesas_proveitos_form))
        Me.despesas = New System.Windows.Forms.Button()
        Me.despesasQuitBtn = New System.Windows.Forms.Button()
        Me.Ncc_2015DataSet = New NCC2015.ncc_2015DataSet()
        Me.Loo_expenseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Loo_expenseTableAdapter = New NCC2015.ncc_2015DataSetTableAdapters.loo_expenseTableAdapter()
        Me.TableAdapterManager = New NCC2015.ncc_2015DataSetTableAdapters.TableAdapterManager()
        Me.Loo_expenseDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Ncc_2015DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Loo_expenseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Loo_expenseDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'despesas
        '
        Me.despesas.BackColor = System.Drawing.SystemColors.Menu
        Me.despesas.Image = Global.NCC2015.My.Resources.Resources.Add_List_32
        Me.despesas.Location = New System.Drawing.Point(666, 507)
        Me.despesas.Name = "despesas"
        Me.despesas.Size = New System.Drawing.Size(50, 50)
        Me.despesas.TabIndex = 20
        Me.despesas.UseVisualStyleBackColor = False
        '
        'despesasQuitBtn
        '
        Me.despesasQuitBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.despesasQuitBtn.Image = Global.NCC2015.My.Resources.Resources.Close_Window_24
        Me.despesasQuitBtn.Location = New System.Drawing.Point(722, 507)
        Me.despesasQuitBtn.Name = "despesasQuitBtn"
        Me.despesasQuitBtn.Size = New System.Drawing.Size(50, 50)
        Me.despesasQuitBtn.TabIndex = 19
        Me.despesasQuitBtn.UseVisualStyleBackColor = False
        '
        'Ncc_2015DataSet
        '
        Me.Ncc_2015DataSet.DataSetName = "ncc_2015DataSet"
        Me.Ncc_2015DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Loo_expenseBindingSource
        '
        Me.Loo_expenseBindingSource.DataMember = "loo_expense"
        Me.Loo_expenseBindingSource.DataSource = Me.Ncc_2015DataSet
        '
        'Loo_expenseTableAdapter
        '
        Me.Loo_expenseTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.loo_expense_typeTableAdapter = Nothing
        Me.TableAdapterManager.loo_expenseTableAdapter = Me.Loo_expenseTableAdapter
        Me.TableAdapterManager.loo_imageTableAdapter = Nothing
        Me.TableAdapterManager.loo_medicTableAdapter = Nothing
        Me.TableAdapterManager.loo_partner_classTableAdapter = Nothing
        Me.TableAdapterManager.loo_partner_timetableTableAdapter = Nothing
        Me.TableAdapterManager.loo_partnerTableAdapter = Nothing
        Me.TableAdapterManager.loo_paymentTableAdapter = Nothing
        Me.TableAdapterManager.loo_sysTableAdapter = Nothing
        Me.TableAdapterManager.loo_userTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = NCC2015.ncc_2015DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Loo_expenseDataGridView
        '
        Me.Loo_expenseDataGridView.AllowUserToAddRows = False
        Me.Loo_expenseDataGridView.AllowUserToDeleteRows = False
        Me.Loo_expenseDataGridView.AutoGenerateColumns = False
        Me.Loo_expenseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Loo_expenseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Loo_expenseDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Loo_expenseDataGridView.DataSource = Me.Loo_expenseBindingSource
        Me.Loo_expenseDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.Loo_expenseDataGridView.Name = "Loo_expenseDataGridView"
        Me.Loo_expenseDataGridView.ReadOnly = True
        Me.Loo_expenseDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.Loo_expenseDataGridView.Size = New System.Drawing.Size(792, 493)
        Me.Loo_expenseDataGridView.TabIndex = 21
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "expense_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "expense_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "expense_type"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tipo de Despesa"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "expense_value"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Valor"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "expense_date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Data"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'despesas_proveitos_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(792, 569)
        Me.ControlBox = False
        Me.Controls.Add(Me.Loo_expenseDataGridView)
        Me.Controls.Add(Me.despesas)
        Me.Controls.Add(Me.despesasQuitBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "despesas_proveitos_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loomart - SocGest | Despesas e Proveitos"
        CType(Me.Ncc_2015DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Loo_expenseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Loo_expenseDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents despesasQuitBtn As Button
    Friend WithEvents despesas As Button
    Friend WithEvents Ncc_2015DataSet As ncc_2015DataSet
    Friend WithEvents Loo_expenseBindingSource As BindingSource
    Friend WithEvents Loo_expenseTableAdapter As ncc_2015DataSetTableAdapters.loo_expenseTableAdapter
    Friend WithEvents TableAdapterManager As ncc_2015DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Loo_expenseDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
