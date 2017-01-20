Public Class medic_form
    Dim main As Windows.Forms.Form
    Dim partner_id As Integer = 0
    Dim dbm As database_manager = New database_manager
    Dim m As New medic
    Dim isUpdate As Boolean = False

    Sub New(partnerId As Integer, mf As Windows.Forms.Form)

        ' This call is required by the designer.
        InitializeComponent()
        partner_id = partnerId
        main = mf
        main.Hide()

    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        main.Show()
        Me.Close()
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        If isUpdate Then
            m.medicCardNumber = Me.medicCardTxt.Text
            m.medicEntity = Me.medicEntityTxt.Text
            dbm.updateMedic(m)
        Else
            m.medicId = dbm.getMedicLastId()
            m.medicCardNumber = Me.medicCardTxt.Text
            m.medicEntity = Me.medicEntityTxt.Text
            m.medicPartnerId = partner_id
            dbm.saveMedic(m)
        End If
    End Sub

    Private Sub medic_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        m = dbm.getMedicPartner(partner_id)
        If m IsNot Nothing Then
            isUpdate = True
            Me.medicCardTxt.Text = m.medicCardNumber
            Me.medicEntityTxt.Text = m.medicEntity
        End If
    End Sub
End Class