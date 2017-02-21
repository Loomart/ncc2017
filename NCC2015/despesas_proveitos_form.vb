Public Class despesas_proveitos_form

    Dim main As main_form


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

    Private Sub Loo_expenseBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Loo_expenseBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Ncc_2015DataSet)

    End Sub

    Private Sub despesas_proveitos_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ncc_2015DataSet.loo_expense' table. You can move, or remove it, as needed.
        Me.Loo_expenseTableAdapter.Fill(Me.Ncc_2015DataSet.loo_expense)

    End Sub
End Class