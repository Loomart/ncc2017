<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class despesas_proveitos_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(despesas_proveitos_form))
        Me.despesas = New System.Windows.Forms.Button()
        Me.despesasQuitBtn = New System.Windows.Forms.Button()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ExpenseDataGridView = New System.Windows.Forms.DataGridView()
        Me.expenseDeleteBtn = New System.Windows.Forms.Button()
        Me.ExpenseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ncc_2015DataSet = New NCC2015.ncc_2015DataSet()
        Me.ExpenseTableAdapter = New NCC2015.ncc_2015DataSetTableAdapters.expenseTableAdapter()
        Me.TableAdapterManager = New NCC2015.ncc_2015DataSetTableAdapters.TableAdapterManager()
        Me.expense_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ExpenseDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpenseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ncc_2015DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'despesas
        '
        Me.despesas.BackColor = System.Drawing.SystemColors.Menu
        Me.despesas.Image = CType(resources.GetObject("despesas.Image"), System.Drawing.Image)
        Me.despesas.Location = New System.Drawing.Point(666, 507)
        Me.despesas.Name = "despesas"
        Me.despesas.Size = New System.Drawing.Size(50, 50)
        Me.despesas.TabIndex = 20
        Me.despesas.UseVisualStyleBackColor = False
        '
        'despesasQuitBtn
        '
        Me.despesasQuitBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.despesasQuitBtn.Image = CType(resources.GetObject("despesasQuitBtn.Image"), System.Drawing.Image)
        Me.despesasQuitBtn.Location = New System.Drawing.Point(722, 507)
        Me.despesasQuitBtn.Name = "despesasQuitBtn"
        Me.despesasQuitBtn.Size = New System.Drawing.Size(50, 50)
        Me.despesasQuitBtn.TabIndex = 19
        Me.despesasQuitBtn.UseVisualStyleBackColor = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'ExpenseDataGridView
        '
        Me.ExpenseDataGridView.AllowUserToAddRows = False
        Me.ExpenseDataGridView.AllowUserToDeleteRows = False
        Me.ExpenseDataGridView.AutoGenerateColumns = False
        Me.ExpenseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ExpenseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ExpenseDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.expense_id, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.ExpenseDataGridView.DataSource = Me.ExpenseBindingSource
        Me.ExpenseDataGridView.Location = New System.Drawing.Point(1, 1)
        Me.ExpenseDataGridView.Name = "ExpenseDataGridView"
        Me.ExpenseDataGridView.ReadOnly = True
        Me.ExpenseDataGridView.Size = New System.Drawing.Size(791, 500)
        Me.ExpenseDataGridView.TabIndex = 21
        '
        'expenseDeleteBtn
        '
        Me.expenseDeleteBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.expenseDeleteBtn.Image = Global.NCC2015.My.Resources.Resources.Delete_24
        Me.expenseDeleteBtn.Location = New System.Drawing.Point(610, 507)
        Me.expenseDeleteBtn.Name = "expenseDeleteBtn"
        Me.expenseDeleteBtn.Size = New System.Drawing.Size(50, 50)
        Me.expenseDeleteBtn.TabIndex = 22
        Me.expenseDeleteBtn.UseVisualStyleBackColor = False
        '
        'ExpenseBindingSource
        '
        Me.ExpenseBindingSource.DataMember = "expense"
        Me.ExpenseBindingSource.DataSource = Me.Ncc_2015DataSet
        '
        'Ncc_2015DataSet
        '
        Me.Ncc_2015DataSet.DataSetName = "ncc_2015DataSet"
        Me.Ncc_2015DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExpenseTableAdapter
        '
        Me.ExpenseTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.loo_expense_typeTableAdapter = Nothing
        Me.TableAdapterManager.loo_expenseTableAdapter = Nothing
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
        'expense_id
        '
        Me.expense_id.DataPropertyName = "expense_id"
        Me.expense_id.HeaderText = "expense_id"
        Me.expense_id.Name = "expense_id"
        Me.expense_id.ReadOnly = True
        Me.expense_id.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "expense_type_name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "expense_value"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Valor"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "expense_date"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Data"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'despesas_proveitos_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(792, 577)
        Me.ControlBox = False
        Me.Controls.Add(Me.expenseDeleteBtn)
        Me.Controls.Add(Me.ExpenseDataGridView)
        Me.Controls.Add(Me.despesas)
        Me.Controls.Add(Me.despesasQuitBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "despesas_proveitos_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loomart - SocGest | Despesas e Proveitos"
        CType(Me.ExpenseDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpenseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ncc_2015DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents despesasQuitBtn As Button
    Friend WithEvents despesas As Button
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Ncc_2015DataSet As ncc_2015DataSet
    Friend WithEvents ExpenseBindingSource As BindingSource
    Friend WithEvents ExpenseTableAdapter As ncc_2015DataSetTableAdapters.expenseTableAdapter
    Friend WithEvents TableAdapterManager As ncc_2015DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ExpenseDataGridView As DataGridView
    Friend WithEvents expenseDeleteBtn As Button
    Friend WithEvents expense_id As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
