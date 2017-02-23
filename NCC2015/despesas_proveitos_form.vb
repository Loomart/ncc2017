Public Class despesas_proveitos_form

    Dim main As main_form
    Dim dbm As database_manager = New database_manager
    Dim gf As globalFunctions = New globalFunctions


    Sub New(mf As main_form)

        ' This call is required by the designer.
        InitializeComponent()
        main = mf
        main.Hide()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub despesasQuitBtn_Click(sender As Object, e As EventArgs) Handles despesasQuitBtn.Click
        Me.Close()
        main.Show()
    End Sub

    Private Sub despesas_Click(sender As Object, e As EventArgs) Handles despesas.Click
        Dim df As add_expense = New add_expense(Me)
        df.Show()
        Me.Hide()
    End Sub

    Private Sub despesas_proveitos_form_Layout(sender As Object, e As LayoutEventArgs) Handles MyBase.Layout
        Me.ExpenseTableAdapter.Fill(Me.Ncc_2015DataSet.expense)
    End Sub

    Private Sub expenseDeleteBtn_Click(sender As Object, e As EventArgs) Handles expenseDeleteBtn.Click
        Dim selectedRow As DataGridViewRow
        Dim idToRemove As Integer
        If ExpenseDataGridView.SelectedRows.Count > 0 Then
            If gf.areYouSureWarning("eliminar despesa") Then
                selectedRow = ExpenseDataGridView.SelectedRows(0)
                idToRemove = CInt(ExpenseDataGridView.Rows(selectedRow.Index).Cells(0).Value.ToString())
                ExpenseDataGridView.Rows.Remove(ExpenseDataGridView.SelectedRows(0))
                dbm.deleteExpense(idToRemove)
            End If
        Else
            MessageBox.Show("Selecione pelo menos um registo.")
        End If
    End Sub
End Class