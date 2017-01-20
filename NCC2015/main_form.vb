Public Class main_form
    Dim actualForm As Form

    Private Sub adiciona_socio_btn_Click(sender As Object, e As EventArgs) Handles adiciona_socio_btn.Click
        actualForm = New adiciona_socio_form(Me)
        actualForm.Show()
    End Sub

    Private Sub altera_socio_btn_Click(sender As Object, e As EventArgs) Handles altera_socio_btn.Click
        actualForm = New altera_socio_form(Me)
        Try
            actualForm.Show()
        Catch ex As Exception
            MessageBox.Show("Deve Introduzir sócios antes de aceder a esta funcionalidade.")
        End Try
    End Sub

    Private Sub ficha_incricao_btn_Click(sender As Object, e As EventArgs) Handles ficha_incricao_btn.Click
        actualForm = New ficha_inscricao_form(1, Me)
        actualForm.Show()
    End Sub

    Private Sub classes_btn_Click(sender As Object, e As EventArgs) Handles classes_btn.Click
        actualForm = New list_classes(Me)
        actualForm.Show()
    End Sub

    Private Sub depesas_proveitos_btn_Click(sender As Object, e As EventArgs) Handles depesas_proveitos_btn.Click
        actualForm = New despesas_proveitos_form(Me)
        actualForm.Show()
    End Sub

    Private Sub pagamentos_btn_Click(sender As Object, e As EventArgs) Handles pagamentos_btn.Click
        actualForm = New pagamentos_form(Me)
        actualForm.Show()
    End Sub

    Private Sub sair_btn_Click(sender As Object, e As EventArgs) Handles sair_btn.Click
        End
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        End
    End Sub

    Private Sub admin_btn_Click(sender As Object, e As EventArgs) Handles admin_btn.Click
        actualForm = New configCard(Me)
        actualForm.Show()
    End Sub
End Class