Imports System.Text.RegularExpressions

Public Class altera_socio_form
    Dim dataBaseConn As database_manager = New database_manager
    Dim gf As globalFunctions = New globalFunctions
    Dim main As Windows.Forms.Form
    Dim cc As New configCard
    Dim partner As New partner
    Dim saveImage As Boolean = False
    Dim filepath As String = ""
    Dim fileExtension As String = ""

    Sub New(mf As Windows.Forms.Form)

        ' This call is required by the designer.
        InitializeComponent()
        main = mf
        main.Hide()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub partnerImageBox_Click(sender As Object, e As EventArgs) Handles partnerModifyImageBox.Click
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
            partnerModifyImageBox.Image = System.Drawing.Bitmap.FromFile(filePath)
            saveImage = True
        End If
    End Sub

    Private Sub partnerQuitBtn_Click(sender As Object, e As EventArgs) Handles partnerModifyQuitBtn.Click
        main.Show()
        Me.Close()
    End Sub

    Private Sub partnerSaveBtn_Click(sender As Object, e As EventArgs) Handles partnerModifySaveBtn.Click
        Dim partner As New partner
        Dim partnerSon As New partner
        If (partnerModifyIdTxt.Text = "") Then
            partner.partnerNumber = 0
        Else
            partner.partnerNumber = Integer.Parse(partnerModifyIdTxt.Text)
        End If
        partner.partnerIsCompetition = partnerModifyCompetitionChk.Checked
        partner.partnerState = activeChk.Checked
        partner.partnerName = partnerModifyNameTxt.Text
        partner.partnerBirthDate = partnerModifyBirthDateDfl.Value
        partner.partnerGender = partnerModifyGenderCbx.SelectedIndex.ToString
        partner.partnerCC = partnerModifyCCTxt.Text
        partner.partnerAddress = partnerModifyAddressTxt.Text
        partner.partnerPostal = partnerModifyPostalTxt.Text
        partner.partnerCity = partnerModifyCityTxt.Text
        If (partnerModifyPhoneTxt.Text = "") Then
            partner.partnerPhone = ""
        Else
            partner.partnerPhone = partnerModifyPhoneTxt.Text
        End If
        If (partnerModifyMobileTxt.Text = "") Then
            partner.partnerMobile = ""
        Else
            partner.partnerMobile = partnerModifyMobileTxt.Text
        End If
        If Not gf.validateEmail(partnerModifyEmailTxt.Text) Then
            MsgBox("O Email inserido não é valido")
            Exit Sub
        End If
        partner.partnerEmail = partnerModifyEmailTxt.Text
        partner.partnerObs = partnerModifyObsTxt.Text
        partner.partnerNif = partnerModifyNifTxt.Text
        partnerSon = dataBaseConn.isParent(partner.partnerNumber)
        If partnerSon IsNot Nothing Then
            partner.partnerParent = partnerSon.partnerNumber
        End If

        Try
            If saveImage Then
                partner.partnerImageId = dataBaseConn.saveImage(filepath, fileExtension)
            End If
            partner.update()
            MsgBox("Sócio atualizado com sucesso.")
        Catch ex As Exception
            MsgBox("Sócio não atualizado. Por favor contacte suporte.")
        End Try


    End Sub

    Private Sub resetForm()
        partnerModifyIdTxt.Clear()
        partnerModifyIdTxt.Enabled = True
        partnerModifyNameTxt.Clear()
        partnerModifyBirthDateDfl.ResetText()
        partnerModifyGenderCbx.ResetText()
        partnerModifyCCTxt.Clear()
        partnerModifyAddressTxt.Clear()
        partnerModifyPostalTxt.Clear()
        partnerModifyCityTxt.Clear()
        partnerModifyPhoneTxt.Clear()
        partnerModifyMobileTxt.Clear()
        partnerModifyEmailTxt.Clear()
        partnerModifyImageBox.Image = Nothing
        partnerModifyObsTxt.Clear()
    End Sub

    Private Sub partnerClearBtn_Click(sender As Object, e As EventArgs) Handles partnerModifyClearBtn.Click
        Dim lastPartnerId As Integer = dataBaseConn.getPartnerLastId
        If (partnerModifyIdTxt.Text <> "") Then
            If (gf.areYouSureWarning("eliminar sócio")) Then
                Try
                    dataBaseConn.deletePartner(Integer.Parse(partnerModifyIdTxt.Text))
                    MessageBox.Show("Socio eliminado com sucesso.")
                    lastPartnerId = dataBaseConn.getPartnerLastId
                Catch ex As Exception
                    MessageBox.Show("Problema encontrado ao tentar eliminar o sócio.")
                End Try
            End If
            If lastPartnerId > 0 Then
                loadPartner(dataBaseConn.getPartner(lastPartnerId))
            Else
                Me.Close()
            End If

        End If

    End Sub

    Private Sub partnerIdTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles partnerModifyIdTxt.KeyPress
        gf.strictNumbers(e)
    End Sub

    Private Sub partnerPhoneTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles partnerModifyPhoneTxt.KeyPress
        gf.strictNumbers(e)
    End Sub

    Private Sub partnerMobileTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles partnerModifyMobileTxt.KeyPress
        gf.strictNumbers(e)
    End Sub

    Private Sub altera_socio_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lastPartnerId As Integer = dataBaseConn.getPartnerLastId
        If lastPartnerId > 0 Then
            partner = dataBaseConn.getPartner(lastPartnerId)
            loadPartner(partner)
        Else
            Me.Dispose()
        End If
    End Sub

    Public Sub loadPartner(partner As partner)
        Dim img As Bitmap = Nothing
        partnerModifyIdTxt.Text = partner.partnerNumber.ToString
        partnerModifyIdTxt.Enabled = False
        partnerModifyCompetitionChk.Checked = partner.partnerIsCompetition
        activeChk.Checked = partner.partnerState
        partnerModifyNameTxt.Text = partner.partnerName
        partnerModifyBirthDateDfl.Value = partner.partnerBirthDate
        partnerModifyGenderCbx.SelectedIndex = CInt(partner.partnerGender)
        partnerModifyCCTxt.Text = partner.partnerCC
        partnerModifyAddressTxt.Text = partner.partnerAddress
        partnerModifyPostalTxt.Text = partner.partnerPostal
        partnerModifyCityTxt.Text = partner.partnerCity
        partnerModifyPhoneTxt.Text = partner.partnerPhone.ToString
        partnerModifyMobileTxt.Text = partner.partnerMobile.ToString
        partnerModifyEmailTxt.Text = partner.partnerEmail
        partnerModifyObsTxt.Text = partner.partnerObs
        partnerModifyNifTxt.Text = partner.partnerNif
        img = dataBaseConn.getImage(partner.partnerImageId)
        If img Is Nothing Then
            partnerModifyImageBox.Image = New Bitmap(My.Resources.blankAvatart)
        Else
            partnerModifyImageBox.Image = img
        End If
        alterPaymentBtn.Enabled = Not dataBaseConn.hasPayed(partner.partnerNumber, partner.partnerMonth)
    End Sub

    Private Sub partnerAddTimetableBtn_Click(sender As Object, e As EventArgs) Handles partnerAddTimetableBtn.Click
        Dim tt As Form
        If (partnerModifyIdTxt.Text <> "") Then
            tt = New add_timetable(Integer.Parse(partnerModifyIdTxt.Text), Me)
            tt.Show()
        End If
    End Sub

    Private Sub partnerNextBtn_Click(sender As Object, e As EventArgs) Handles partnerNextBtn.Click
        Dim partner As New partner
        If partnerModifyIdTxt.Text = "" Then
            partner = dataBaseConn.getPartner(dataBaseConn.getPartnerLastId)
        Else
            partner = dataBaseConn.getPartner(dataBaseConn.getFollowingPartnerId(Integer.Parse(partnerModifyIdTxt.Text)))
        End If

        If (partner.partnerNumber > 0) Then
            loadPartner(partner)
        End If
    End Sub

    Private Sub partnerBackBtn_Click(sender As Object, e As EventArgs) Handles partnerBackBtn.Click
        Dim partner As New partner
        If partnerModifyIdTxt.Text = "" Then
            partner = dataBaseConn.getPartner(dataBaseConn.getPartnerLastId)
        Else
            partner = dataBaseConn.getPartner(dataBaseConn.getPreviousPartnerId(Integer.Parse(partnerModifyIdTxt.Text)))
        End If
        If (partner.partnerNumber > 0) Then
            loadPartner(partner)
        End If
    End Sub

    Private Sub partnerModifyGetIdBtn_Click(sender As Object, e As EventArgs)
        Dim partner As New partner
        partner = dataBaseConn.getPartner(dataBaseConn.getPartnerLastId)
        If partner.partnerNumber > 0 Then
            loadPartner(partner)
        Else
            MessageBox.Show("Não existem Sócios guardados.")
            resetForm()
        End If
    End Sub

    Private Sub partnerModifyAddClass_Click(sender As Object, e As EventArgs) Handles partnerModifyAddClass.Click
        Dim cf As Form
        If (partnerModifyIdTxt.Text <> "") Then
            cf = New classes_form(Integer.Parse(partnerModifyIdTxt.Text), Me)
            cf.Show()
        End If
    End Sub

    Private Sub partnerModifyNifTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles partnerModifyNifTxt.KeyPress
        gf.strictNumbers(e)
    End Sub

    Private Sub addParentBtn_Click(sender As Object, e As EventArgs) Handles addParentBtn.Click
        Dim parent_form As adiciona_socio_form
        parent_form = New adiciona_socio_form(Integer.Parse(partnerModifyIdTxt.Text), Me)
        parent_form.Show()
    End Sub

    Private Sub partnerModifyReportBtn_Click(sender As Object, e As EventArgs) Handles partnerModifyReportBtn.Click
        Dim report_form As ficha_inscricao_form
        report_form = New ficha_inscricao_form(Integer.Parse(partnerModifyIdTxt.Text), Me)
        report_form.Show()
    End Sub

    Private Sub searchSocioBtn_Click(sender As Object, e As EventArgs) Handles searchSocioBtn.Click
        Dim search_partner_form As search_partner
        search_partner_form = New search_partner(Me)
        search_partner_form.Show()
    End Sub

    Private Sub addMedicBtn_Click(sender As Object, e As EventArgs) Handles addMedicBtn.Click
        Dim medic_form As medic_form
        medic_form = New medic_form(CInt(partnerModifyIdTxt.Text), Me)
        medic_form.Show()
    End Sub

    Private Sub alterCardCreateBtn_Click(sender As Object, e As EventArgs) Handles alterCardCreateBtn.Click
        Try
            solicita()
            escreve()
            dataBaseConn.addCardToPartner(Integer.Parse(partnerModifyIdTxt.Text))
            parar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub solicita()
        Dim port, i, baud As Integer
        Dim j As Short
        Dim buf1(200) As Byte
        Dim b1 As Byte
        Dim s1 As String
        port = 5
        baud = 19200
        'Open Port
        i = rf_init_com(port, baud)
        If (i <> 0) Then
            Throw New Exception("Abrir Porta Falhou !")
            Exit Sub
        End If
        'Request
        i = rf_request(0, &H52S, CByte(j))
        If (i <> 0) Then
            Throw New Exception("Pedido sem sucesso!")
            Exit Sub
        End If
        'Anticollision
        i = rf_anticoll(0, 4, buf1(0), b1)
        If (i <> 0) Then
            Throw New Exception("Anti-colisao Falhou!")
            Exit Sub
        End If
        s1 = ""
        For i = 0 To b1 - 1
            s1 = s1 & Microsoft.VisualBasic.Right("00" & Hex(buf1(i)), 2)
        Next i
        'Select card
        i = rf_select(0, buf1(0), 4, b1)
        If (i <> 0) Then
            Throw New Exception("Falha na selecao do cartao!")
            Exit Sub
        End If
    End Sub

    Private Sub escreve()
        Dim i, m As Integer
        Dim buf1(200) As Byte
        Dim buf2(200) As Byte
        Dim s1 As String
        Dim b1, b3 As Byte
        s1 = "FFFFFFFFFFFF"
        For i = 0 To 5
            buf1(i) = CByte(Val("&H" & Mid(s1, i * 2 + 1, 2)))
        Next i
        m = 4
        b1 = &H60S
        s1 = Trim(partnerModifyIdTxt.Text)
        s1 = cc.preparaPalavra(s1)
        For i = 0 To 15
            buf2(i) = CByte(Val("&H" & Mid(s1, i * 2 + 1, 2)))
        Next i
        'Authentication
        b3 = CByte(m)
        i = rf_M1_authentication2(0, b1, b3, buf1(0))
        If (i <> 0) Then
            Throw New Exception("Falha na autenticacao!")
            Exit Sub
        End If
        'Write card
        i = rf_M1_write(0, b3, buf2(0))
        If (i <> 0) Then
            Throw New Exception("Falha na escrita do cartao")
            Exit Sub
        End If
    End Sub

    Private Sub parar()
        Dim i As Integer
        i = rf_halt(0)
        If (i <> 0) Then
            Throw New Exception("Falha na paragem!")
            Exit Sub
        End If
        MessageBox.Show("Cartao criado com sucesso")
    End Sub

    Private Sub alterPaymentBtn_Click(sender As Object, e As EventArgs) Handles alterPaymentBtn.Click
        Dim payment_form As doPayment

        payment_form = New doPayment(Me, dataBaseConn.getPartner(Integer.Parse(partnerModifyIdTxt.Text)))
        payment_form.Show()
    End Sub
End Class