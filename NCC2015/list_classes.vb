Public Class list_classes

    Dim dataBaseConn As database_manager = New database_manager
    Dim main As main_form

    Sub New(mf As main_form)

        ' This call is required by the designer.
        InitializeComponent()
        main = mf
        main.Hide()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub listClassBebe_Click(sender As Object, e As EventArgs) Handles listClassBebe.Click
        loadClassList(1)
    End Sub

    Private Sub listClassCrianca_Click(sender As Object, e As EventArgs) Handles listClassCrianca.Click
        loadClassList(2)
    End Sub

    Private Sub listClassAdulto_Click(sender As Object, e As EventArgs) Handles listClassAdulto.Click
        loadClassList(3)
    End Sub

    Private Sub listClassManutencao_Click(sender As Object, e As EventArgs) Handles listClassManutencao.Click
        loadClassList(4)
    End Sub

    Private Sub listClassHidro_Click(sender As Object, e As EventArgs) Handles listClassHidro.Click
        loadClassList(5)
    End Sub

    Private Sub listClassCompeticao_Click(sender As Object, e As EventArgs) Handles listClassCompeticao.Click
        loadClassList(0)
    End Sub

    Private Sub loadClassList(class_id As Integer)
        Dim classForm As New class_list(class_id)
        classForm.Show()
    End Sub

    Private Sub listClassesQuitBtn_Click(sender As Object, e As EventArgs) Handles listClassesQuitBtn.Click
        Me.Close()
        main.Show()
    End Sub
End Class