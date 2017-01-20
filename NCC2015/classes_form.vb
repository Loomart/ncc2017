Public Class classes_form

    Dim partnerId As Integer = 0
    Dim dataBaseConn As database_manager = New database_manager
    Dim main As Windows.Forms.Form
    Enum classes
        bebe
        crianca
        adulto
        manutencao
        hidro
    End Enum
    Sub New(partner_id As Integer, mf As Windows.Forms.Form)
        ' This call is required by the designer.
        InitializeComponent()
        partnerId = partner_id
        main = mf
        main.Hide()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub classesQuitBtn_Click(sender As Object, e As EventArgs) Handles classesQuitBtn.Click
        Me.Close()
        main.Show()
    End Sub

    Private Sub classBebeBtn_Click(sender As Object, e As EventArgs) Handles classBebeBtn.Click
        dataBaseConn.addClassToPartner(partnerId, 1)
        Me.Close()
        main.Show()
    End Sub

    Private Sub classCriancaBtn_Click(sender As Object, e As EventArgs) Handles classCriancaBtn.Click
        dataBaseConn.addClassToPartner(partnerId, 2)
        Me.Close()
        main.Show()
    End Sub

    Private Sub classAdultoBtn_Click(sender As Object, e As EventArgs) Handles classAdultoBtn.Click
        dataBaseConn.addClassToPartner(partnerId, 3)
        Me.Close()
        main.Show()
    End Sub

    Private Sub classManutencaoBtn_Click(sender As Object, e As EventArgs) Handles classManutencaoBtn.Click
        dataBaseConn.addClassToPartner(partnerId, 4)
        Me.Close()
        main.Show()
    End Sub

    Private Sub classHidroBtn_Click(sender As Object, e As EventArgs) Handles classHidroBtn.Click
        dataBaseConn.addClassToPartner(partnerId, 5)
        Me.Close()
        main.Show()
    End Sub

    Private Sub classes_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim class_id = dataBaseConn.getPartnerClassId(partnerId)
        Dim class_name As String = ""
        If class_id > 0 Then
            class_name = dataBaseConn.getPartnerClassName(class_id)
            classNameLbl.Text = "A classe atual é " & class_name
        Else
            classNameLbl.Text = ""
        End If
    End Sub
End Class