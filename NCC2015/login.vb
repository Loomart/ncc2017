Public Class login_form
    Dim dbm As database_manager
    Dim user As user


    Private Sub login_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbm = New database_manager
        username_txt.Focus()
    End Sub

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        If (dbm.login(username_txt.Text, password_txt.Text)) Then
            dbm.resetGlobalPartnerState()
            user = dbm.getUser(dbm.userId)
            If (user.userAdmin) Then 'User to Manage ALL
                Dim main_form As New main_form
                main_form.Show()
                Me.Hide()
            ElseIf (user.userSuper) Then 'User to Manage Data and not User priviledges
                Dim main_form As New main_form
                main_form.admin_btn.Enabled = False
                main_form.Show()
                Me.Hide()
            Else 'User to check entrances
                Dim ventrada As New valida_entrada
                ventrada.Show()
                Me.Hide()
            End If
        Else
            MsgBox("Login Inválido.")
            username_txt.Text = ""
            password_txt.Text = ""
            username_txt.Focus()
        End If
    End Sub

    Private Sub sair_fake_login_btn_Click(sender As Object, e As EventArgs) Handles sair_fake_login_btn.Click
        End
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        MsgBox("Support: luisfigueira@outlook.com")
    End Sub

    Private Sub password_txt_KeyDown(sender As Object, e As KeyEventArgs) Handles password_txt.KeyDown
        If e.KeyCode = 13 Then
            login_btn.PerformClick()
        End If
    End Sub
End Class