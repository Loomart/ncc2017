Public Class adiciona_socio_form
    Dim dataBaseConn As database_manager = New database_manager
    Dim gf As globalFunctions = New globalFunctions
    Dim partner_id As Integer = 0
    Dim partner_parent As partner
    Dim isParent As Boolean = False
    Dim savedImage As Boolean = False
    Dim main As Windows.Forms.Form
    Dim saveImage As Boolean = False
    Dim filepath As String = ""
    Dim fileExtension As String = ""
    Dim imageId As Integer = 0

    Sub New(partnerId As Integer, mf As Windows.Forms.Form)

        ' This call is required by the designer.
        InitializeComponent()
        partner_parent = dataBaseConn.hasParent(partnerId)
        isParent = True
        partner_id = partnerId
        If partner_parent IsNot Nothing Then
            'lets fill the form
            Me.partnerIdTxt.Text = partner_parent.partnerNumber.ToString
            Me.partnerNameTxt.Text = partner_parent.partnerName
            Me.partnerBirthDateDfl.Value = partner_parent.partnerBirthDate
            Me.partnerGenderCbx.SelectedIndex = CInt(partner_parent.partnerGender)
            Me.partnerCCTxt.Text = partner_parent.partnerCC
            Me.partnerAddressTxt.Text = partner_parent.partnerAddress
            Me.partnerPostalTxt.Text = partner_parent.partnerPostal
            Me.partnerCityTxt.Text = partner_parent.partnerCity
            Me.partnerPhoneTxt.Text = partner_parent.partnerPhone.ToString
            Me.partnerMobileTxt.Text = partner_parent.partnerMobile.ToString
            Me.partnerEmailTxt.Text = partner_parent.partnerEmail
            Me.partnerObsTxt.Text = partner_parent.partnerObs
            Me.partnerNifTxt.Text = partner_parent.partnerNif
            Me.partnerImageBox.Image = dataBaseConn.getImage(partner_parent.partnerImageId)
        End If
        ' Add any initialization after the InitializeComponent() call.
        main = mf
        main.Hide()

    End Sub

    Sub New(mf As main_form)

        ' This call is required by the designer.
        InitializeComponent()
        main = mf
        main.Hide()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub partnerImageBox_Click(sender As Object, e As EventArgs) Handles partnerImageBox.Click
        'Set the filter
        openImageDialog.Filter = "Ficheiros de Imagem |*.jpg;*.png;*.bmp;*.gif"
        'Set default directory
        openImageDialog.InitialDirectory = "C:\"
        'Clear the file name
        openImageDialog.FileName = ""

        'Show it
        If openImageDialog.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            'get the image name
            filepath = openImageDialog.FileName
            fileExtension = System.IO.Path.GetExtension(filepath)
            'Create a new Bitmap and display it
            partnerImageBox.Image = System.Drawing.Bitmap.FromFile(filepath)
            saveImage = True
        End If
    End Sub

    Private Sub partnerQuitBtn_Click(sender As Object, e As EventArgs) Handles partnerQuitBtn.Click
        main.Show()
        Me.Close()
    End Sub

    Private Sub partnerSaveBtn_Click(sender As Object, e As EventArgs) Handles partnerSaveBtn.Click
        Dim partner As New partner
        If isParent And partnerIdTxt.Text = "" Then
            dataBaseConn.removeParentFromPartner(partner_id)
        Else
            If (partnerIdTxt.Text = "") Then
                partner.partnerNumber = 0
            Else
                partner.partnerNumber = Integer.Parse(partnerIdTxt.Text)
            End If
            If filepath <> "" Then
                imageId = dataBaseConn.saveImage(filepath, fileExtension)
            End If
            If savedImage Then
                partner.partnerImageId = imageId
            End If
            If isParent Then
                partner.partnerImageId = imageId
            End If
            If (partnerIdTxt.Text = "") Then
                MsgBox("Não pode adicionar um sócio sem número")
                Exit Sub
            End If
            partner.partnerIsCompetition = isCompetitionChk.Checked
            partner.partnerState = addSocioActiveChk.Checked
            partner.partnerName = partnerNameTxt.Text
            partner.partnerBirthDate = partnerBirthDateDfl.Value
            partner.partnerGender = partnerGenderCbx.SelectedIndex.ToString
            partner.partnerCC = partnerCCTxt.Text
            partner.partnerAddress = partnerAddressTxt.Text
            partner.partnerPostal = partnerPostalTxt.Text
            partner.partnerCity = partnerCityTxt.Text
            partner.partnerPhone = partnerPhoneTxt.Text
            partner.partnerMobile = partnerMobileTxt.Text
            If Not gf.validateEmail(partnerEmailTxt.Text) Then
                MsgBox("O Email inserido não é valido.")
                Exit Sub
            End If
            partner.partnerEmail = partnerEmailTxt.Text
            partner.partnerObs = partnerObsTxt.Text
            partner.partnerNif = partnerNifTxt.Text
            If isParent Then
                dataBaseConn.addParentToPartner(partner_id, Integer.Parse(partnerIdTxt.Text))
                partner.partnerParent = 0
            Else
                partner.partnerParent = 0
            End If
            partner.partnerCard = gf.preparaNumeroCartao(partner.partnerNumber.ToString)
            If partner.partnerNumber = 0 Then
                MsgBox("O número de sócio não é valido.")
            ElseIf dataBaseConn.getPartner(partner.partnerNumber) Is Nothing Or isParent Then
                If isParent Then
                    partner.update()
                    MsgBox("Sócio atualizado com sucesso.")
                Else
                    partner.save()
                    MsgBox("Sócio criado com sucesso.")
                End If
                If partner_id > 0 Then
                    Me.Dispose()
                    main.Show()
                Else
                    resetForm()
                End If
            Else
                MsgBox("Sócio com este número ja existe.")
            End If
        End If

    End Sub

    Private Sub resetForm()
        partnerIdTxt.Clear()
        partnerIdTxt.Enabled = True
        addSocioActiveChk.Checked = False
        isCompetitionChk.Checked = False
        partnerNameTxt.Clear()
        partnerBirthDateDfl.ResetText()
        partnerGenderCbx.ResetText()
        partnerCCTxt.Clear()
        partnerAddressTxt.Clear()
        partnerPostalTxt.Clear()
        partnerCityTxt.Clear()
        partnerPhoneTxt.Clear()
        partnerMobileTxt.Clear()
        partnerEmailTxt.Clear()
        partnerImageBox.Image = Nothing
        partnerObsTxt.Clear()
        partnerNifTxt.Clear()
    End Sub

    Private Sub partnerClearBtn_Click(sender As Object, e As EventArgs) Handles partnerClearBtn.Click
        resetForm()
    End Sub

    Private Sub partnerGetIdBtn_Click(sender As Object, e As EventArgs) Handles partnerGetIdBtn.Click
        Dim lastPartnerId As Integer = dataBaseConn.getPartnerLastId
        If lastPartnerId = 0 Or lastPartnerId = -1 Then
            partnerIdTxt.Text = 1.ToString
        ElseIf lastPartnerId > 0 Then
            partnerIdTxt.Text = (lastPartnerId + 1).ToString
        End If
        partnerIdTxt.Enabled = False
    End Sub

    Private Sub partnerIdTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles partnerIdTxt.KeyPress
        gf.strictNumbers(e)
    End Sub

    Private Sub partnerPhoneTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles partnerPhoneTxt.KeyPress
        gf.strictNumbers(e)
    End Sub

    Private Sub partnerMobileTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles partnerMobileTxt.KeyPress
        gf.strictNumbers(e)
    End Sub

    Private Sub partnerNifTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles partnerNifTxt.KeyPress
        gf.strictNumbers(e)
    End Sub

    Private Sub partnerIdTxt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles partnerIdTxt.LostFocus
        If isParent Then
            If partnerIdTxt.Text = "" Then
                If partnerNameTxt.Text.Length > 0 Then
                    MsgBox("Para aplicar as alterações é necessário guardar !")
                End If
                resetForm()
            Else
                If dataBaseConn.existsPartner(CInt(partnerIdTxt.Text)) Then
                    loadPartnerParent(CInt(partnerIdTxt.Text))
                Else
                    MsgBox("O sócio com esse número não existe. Tente outra vez por favor.")
                    resetForm()
                End If
            End If
        End If
    End Sub

    Private Sub loadPartnerParent(partnerId As Integer)
        Dim partner As partner
        partner = dataBaseConn.getPartner(partnerId)
        partner_parent = partner
        If partner IsNot Nothing Then
            Me.partnerIdTxt.Text = partner.partnerNumber.ToString
            Me.partnerNameTxt.Text = partner.partnerName
            Me.partnerBirthDateDfl.Value = partner.partnerBirthDate
            Me.partnerGenderCbx.SelectedIndex = CInt(partner.partnerGender)
            Me.partnerCCTxt.Text = partner.partnerCC
            Me.partnerAddressTxt.Text = partner.partnerAddress
            Me.partnerPostalTxt.Text = partner.partnerPostal
            Me.partnerCityTxt.Text = partner.partnerCity
            Me.partnerPhoneTxt.Text = partner.partnerPhone.ToString
            Me.partnerMobileTxt.Text = partner.partnerMobile.ToString
            Me.partnerEmailTxt.Text = partner.partnerEmail
            Me.partnerObsTxt.Text = partner.partnerObs
            Me.partnerNifTxt.Text = partner.partnerNif
            Me.partnerImageBox.Image = dataBaseConn.getImage(partner.partnerImageId)
            Me.addSocioActiveChk.Checked = partner.partnerState
            Me.isCompetitionChk.Checked = partner.partnerIsCompetition
        End If
    End Sub

    Private Sub adiciona_socio_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        partnerImageBox.Image = New Bitmap(My.Resources.blankAvatart)
    End Sub
End Class