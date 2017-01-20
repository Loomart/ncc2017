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

End Class