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
End Class