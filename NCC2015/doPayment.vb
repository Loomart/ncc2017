Public Class doPayment
    Dim main As altera_socio_form
    Dim partnerToPay As partner
    Dim gf As globalFunctions = New globalFunctions
    Dim dataBaseConn As database_manager = New database_manager

    Sub New(mf As altera_socio_form, p As partner)

        ' This call is required by the designer.
        InitializeComponent()
        main = mf
        main.Hide()
        partnerToPay = p
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub paymentValueTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles paymentValueTxt.KeyPress
        gf.strictNumbers(e)
    End Sub


    Private Sub paymentQuitBtn_Click(sender As Object, e As EventArgs) Handles paymentQuitBtn.Click
        Me.Close()
        main.Show()
    End Sub

    Private Sub paymentSaveBtn_Click(sender As Object, e As EventArgs) Handles paymentSaveBtn.Click
        If Integer.Parse(paymentValueTxt.Text) > 0 Then
            partnerToPay.partnerMonth = CInt(Today.Month)
            partnerToPay.partnerState = True
            partnerToPay.update()
            'check if payment exists
            If dataBaseConn.hasPayed(partnerToPay.partnerNumber, partnerToPay.partnerMonth) Then
                If (gf.areYouSureWarning("sobrepor o pagamento existente")) Then
                    dataBaseConn.setPaymentValue(partnerToPay.partnerNumber, Integer.Parse(paymentValueTxt.Text), partnerToPay.partnerMonth)
                    MsgBox("Pagamento alterado com sucesso !")
                End If
            Else
                Dim pay As New payment
                pay.paymentPartner = partnerToPay
                pay.paymentValue = Integer.Parse(paymentValueTxt.Text)
                pay.save()
                MsgBox("Pagamento criado com sucesso !")
            End If
            Me.Close()
            main.Show()
        Else
            MsgBox("Deve introduzir um valor !")
        End If

    End Sub

    Private Sub doPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim value As Integer = 0
        value = dataBaseConn.getLastPayment(partnerToPay.partnerNumber)
        paymentValueTxt.Text = value.ToString
    End Sub
End Class