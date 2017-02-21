<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_expense
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_expense))
        Me.addExpenseValueTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.addExpenseDatePck = New System.Windows.Forms.DateTimePicker()
        Me.addExpenseTypeCmb = New System.Windows.Forms.ComboBox()
        Me.LooexpensetypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ncc_2015DataSet = New NCC2015.ncc_2015DataSet()
        Me.Loo_expense_typeTableAdapter = New NCC2015.ncc_2015DataSetTableAdapters.loo_expense_typeTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.addExpense = New System.Windows.Forms.Button()
        Me.closeBtn = New System.Windows.Forms.Button()
        CType(Me.LooexpensetypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ncc_2015DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'addExpenseValueTxt
        '
        Me.addExpenseValueTxt.Location = New System.Drawing.Point(90, 51)
        Me.addExpenseValueTxt.Name = "addExpenseValueTxt"
        Me.addExpenseValueTxt.Size = New System.Drawing.Size(285, 20)
        Me.addExpenseValueTxt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Valor:"
        '
        'addExpenseDatePck
        '
        Me.addExpenseDatePck.Location = New System.Drawing.Point(90, 143)
        Me.addExpenseDatePck.Name = "addExpenseDatePck"
        Me.addExpenseDatePck.Size = New System.Drawing.Size(285, 20)
        Me.addExpenseDatePck.TabIndex = 2
        '
        'addExpenseTypeCmb
        '
        Me.addExpenseTypeCmb.DataSource = Me.LooexpensetypeBindingSource
        Me.addExpenseTypeCmb.DisplayMember = "expense_type_name"
        Me.addExpenseTypeCmb.FormattingEnabled = True
        Me.addExpenseTypeCmb.Location = New System.Drawing.Point(90, 96)
        Me.addExpenseTypeCmb.Name = "addExpenseTypeCmb"
        Me.addExpenseTypeCmb.Size = New System.Drawing.Size(285, 21)
        Me.addExpenseTypeCmb.TabIndex = 3
        Me.addExpenseTypeCmb.ValueMember = "expense_type_id"
        '
        'LooexpensetypeBindingSource
        '
        Me.LooexpensetypeBindingSource.DataMember = "loo_expense_type"
        Me.LooexpensetypeBindingSource.DataSource = Me.Ncc_2015DataSet
        '
        'Ncc_2015DataSet
        '
        Me.Ncc_2015DataSet.DataSetName = "ncc_2015DataSet"
        Me.Ncc_2015DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Loo_expense_typeTableAdapter
        '
        Me.Loo_expense_typeTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tipo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Data:"
        '
        'addExpense
        '
        Me.addExpense.BackColor = System.Drawing.SystemColors.Menu
        Me.addExpense.Image = CType(resources.GetObject("addExpense.Image"), System.Drawing.Image)
        Me.addExpense.Location = New System.Drawing.Point(269, 204)
        Me.addExpense.Name = "addExpense"
        Me.addExpense.Size = New System.Drawing.Size(50, 50)
        Me.addExpense.TabIndex = 6
        Me.addExpense.UseVisualStyleBackColor = False
        '
        'closeBtn
        '
        Me.closeBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.closeBtn.Image = CType(resources.GetObject("closeBtn.Image"), System.Drawing.Image)
        Me.closeBtn.Location = New System.Drawing.Point(325, 204)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(50, 50)
        Me.closeBtn.TabIndex = 7
        Me.closeBtn.UseVisualStyleBackColor = False
        '
        'add_expense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(420, 271)
        Me.ControlBox = False
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.addExpense)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.addExpenseTypeCmb)
        Me.Controls.Add(Me.addExpenseDatePck)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.addExpenseValueTxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "add_expense"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loomart - SocGest | Despesas"
        CType(Me.LooexpensetypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ncc_2015DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents addExpenseValueTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents addExpenseDatePck As DateTimePicker
    Friend WithEvents addExpenseTypeCmb As ComboBox
    Friend WithEvents Ncc_2015DataSet As ncc_2015DataSet
    Friend WithEvents LooexpensetypeBindingSource As BindingSource
    Friend WithEvents Loo_expense_typeTableAdapter As ncc_2015DataSetTableAdapters.loo_expense_typeTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents addExpense As Button
    Friend WithEvents closeBtn As Button
End Class
