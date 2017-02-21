Public Class pagamentos_form
    Dim main As main_form

    Sub New(mf As main_form)

        ' This call is required by the designer.
        InitializeComponent()
        main = mf
        main.Hide()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub pagamentos_form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        main.Show()
    End Sub

    Private Sub pagamentosQuitBtn_Click(sender As Object, e As EventArgs) Handles pagamentosQuitBtn.Click
        Me.Close()
        main.Show()
    End Sub

    Private Sub Loo_paymentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Loo_paymentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Ncc_2015DataSet)

    End Sub

    Private Sub pagamentos_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ncc_2015DataSet.loo_payment' table. You can move, or remove it, as needed.
        Me.Loo_paymentTableAdapter.Fill(Me.Ncc_2015DataSet.loo_payment)

    End Sub
End Class