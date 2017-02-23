Public Class search_partner
    Dim alter_partner_form As altera_socio_form
    Dim dbm As database_manager = New database_manager

    Sub New(alter_partner As altera_socio_form)

        ' This call is required by the designer.
        InitializeComponent()
        alter_partner_form = alter_partner
        alter_partner_form.Hide()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        Dim partner As partner = Nothing
        If searchPartnerTxt.Text = "" Then
            MsgBox("Ha Ha esqueceste-te de preencher o número !")
        Else
            If dbm.existsPartner(Integer.Parse(searchPartnerTxt.Text)) Then
                partner = dbm.getPartner(Integer.Parse(searchPartnerTxt.Text))
                alter_partner_form.loadPartner(partner)
                alter_partner_form.partnerImageId = partner.partnerImageId
                alter_partner_form.Show()
                Me.Close()
            Else
                MsgBox("Sócio não existente.")
                searchPartnerTxt.ResetText()
            End If
        End If
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        alter_partner_form.Show()
        Me.Close()
    End Sub
End Class