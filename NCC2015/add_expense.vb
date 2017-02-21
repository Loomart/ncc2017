Public Class add_expense

    Dim dbm As database_manager = New database_manager
    Dim gf As globalFunctions = New globalFunctions
    Dim expenses_form = New Form

    Sub New(ef As despesas_proveitos_form)

        ' This call is required by the designer.
        InitializeComponent()
        expenses_form = ef
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub add_expense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ncc_2015DataSet.loo_expense_type' table. You can move, or remove it, as needed.
        Me.Loo_expense_typeTableAdapter.Fill(Me.Ncc_2015DataSet.loo_expense_type)

    End Sub

    Private Sub addExpense_Click(sender As Object, e As EventArgs) Handles addExpense.Click
        dbm.insertExpense(addExpenseValueTxt.Text, addExpenseTypeCmb.SelectedValue, addExpenseDatePck.Value)
    End Sub

    Private Sub addExpenseValueTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles addExpenseValueTxt.KeyPress
        gf.strictNumbers(e)
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
        expenses_form.show
    End Sub
End Class