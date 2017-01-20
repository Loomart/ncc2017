Public Class ficha_inscricao_form
    Dim dbm As New database_manager
    Dim partnerId As Integer = 1
    Dim main As Windows.Forms.Form

    Sub New(partner_id As Integer, mf As Windows.Forms.Form)

        ' This call is required by the designer.
        InitializeComponent()
        partnerId = partner_id
        main = mf
        main.Hide()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ficha_inscricao_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Loo_sysTableAdapter.Fill(Me.Ncc_2015DataSet.loo_sys)
        'TODO: This line of code loads data into the 'Ncc_2015DataSet.partner_info' table. You can move, or remove it, as needed.

        fillTables()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub previousBtn_Click(sender As Object, e As EventArgs) Handles previousBtn.Click
        partnerId = dbm.getPreviousPartnerId(Integer.Parse(Me.posTxt.Text))
        fillTables()

    End Sub

    Private Sub nextBtn_Click(sender As Object, e As EventArgs) Handles nextBtn.Click
        partnerId = dbm.getFollowingPartnerId(Integer.Parse(Me.posTxt.Text))
        fillTables()

    End Sub

    Private Sub fillTables()
        Dim partner As partner
        partner = dbm.getPartner(partnerId)
        If partner.partnerParent = 0 Then

        End If
        Me.posTxt.Text = partnerId.ToString
        Me.Partner_infoTableAdapter.Fill(Me.Ncc_2015DataSet.partner_info, partnerId)
        Me.loo_partner_timetable1TableAdapter.Fill(Me.Ncc_2015DataSet.loo_partner_timetable1, partnerId)
        'todo load data
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        partnerId = Integer.Parse(Me.posTxt.Text)
        fillTables()
    End Sub

    Private Sub ficha_inscricao_form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        main.Show()
    End Sub
End Class