Imports System.Threading

Public Class valida_entrada
    Dim dbm As database_manager = New database_manager
    Dim gf As New globalFunctions
    Dim socio As partner
    Private Sub darEntrada()
        Dim nc As String = ""
        Try
            If solicitar() Then
                nc = lerCartao()
                If nc <> "" Then
                    If (validaEntrada(nc)) Then
                        If socio.partnerState And socio.partnerMonth = CInt(Today.Month) Then
                            reasonLbl.Text = "O socio está ativo. "
                            If dbm.isValidDay(socio.partnerNumber) Then
                                Me.BackColor = Color.Green
                                partnerPictureBox.Image = dbm.getImage(socio.partnerImageId)
                                partnerNameLbl.Text = socio.partnerName
                                partnerClassLbl.Text = dbm.getPartnerClassName(socio.partnerClass)
                                gf.logNcc("Socio - " & socio.partnerName & " deu entrada com sucesso.")
                                rf_beep(0, 25)
                                rf_light(0, 2)
                                Me.Refresh()
                                Thread.Sleep(5000)
                                rf_light(0, 0)
                                reasonLbl.Text = ""
                                partnerPictureBox.Image = Nothing
                                partnerNameLbl.Text = ""
                                partnerClassLbl.Text = ""
                                Me.BackColor = Color.CornflowerBlue
                                Me.Refresh()
                            Else
                                reasonLbl.Text = reasonLbl.Text & " Hora ou dia inválido. Contacte a Direção."
                                Me.BackColor = Color.Red
                                Me.Refresh()
                                rf_beep(0, 100)
                                rf_light(0, 1)
                                Me.Refresh()
                                Thread.Sleep(5000)
                                rf_light(0, 0)
                                reasonLbl.Text = ""
                                Me.BackColor = Color.CornflowerBlue
                                Me.Refresh()
                            End If


                        Else
                            reasonLbl.Text = "O socio está inativo. Talvez não tenha renovado a cota."
                            Me.BackColor = Color.Red
                            Me.Refresh()
                            rf_beep(0, 100)
                            rf_light(0, 1)
                            Me.Refresh()
                            Thread.Sleep(5000)
                            rf_light(0, 0)
                            reasonLbl.Text = ""
                            Me.BackColor = Color.CornflowerBlue
                            Me.Refresh()
                        End If
                    Else
                        reasonLbl.Text = "O cartão é inválido. Por favor tente reescrever o cartao. "
                        Me.BackColor = Color.Red
                        Me.Refresh()
                        rf_beep(0, 100)
                        rf_light(0, 1)
                        Me.Refresh()
                        Thread.Sleep(5000)
                        rf_light(0, 0)
                        reasonLbl.Text = ""
                        Me.BackColor = Color.CornflowerBlue
                        Me.Refresh()
                    End If
                End If
            End If
        Catch ex As Exception
        End Try

    End Sub

    Public Function solicitar() As Boolean
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
            'MessageBox.Show("Abrir Porta Falhou !")
            gf.logNcc("Abrir Porta Falhou !")
            Return False
        End If
        'Request
        i = rf_request(0, &H52S, CByte(j))
        If (i <> 0) Then
            'MessageBox.Show("Pedido sem sucesso!")
            gf.logNcc("Pedido sem sucesso!")
            Return False
        End If
        'Anticollision
        i = rf_anticoll(0, 4, buf1(0), b1)
        If (i <> 0) Then
            'MessageBox.Show("Anti-colisao Falhou!")
            gf.logNcc("Anti-colisao Falhou!")
            Return False
        End If
        s1 = ""
        For i = 0 To b1 - 1
            s1 = s1 & Microsoft.VisualBasic.Right("00" & Hex(buf1(i)), 2)
        Next i

        'Select card
        i = rf_select(0, buf1(0), 4, b1)
        If (i <> 0) Then
            'MessageBox.Show("Falha na selecao do cartao!")
            gf.logNcc("Falha na selecao do cartao!")
            Return False
        End If
        Return True
    End Function

    Public Function lerCartao() As String
        Dim i, m As Integer
        Dim buf1(200) As Byte
        Dim buf2(200) As Byte
        Dim s1 As String
        Dim b2, b1, b3 As Byte
        s1 = "FFFFFFFFFFFF"
        For i = 0 To 5
            buf1(i) = CByte(Val("&H" & Mid(s1, i * 2 + 1, 2)))
        Next i
        m = 4
        b1 = &H60S
        b3 = CByte(m)
        'Authentication
        i = rf_M1_authentication2(0, b1, b3, buf1(0))
        If (i <> 0) Then
            'MessageBox.Show("Falha na autenticacao")
            gf.logNcc("Falha na autenticacao")
            Return ""
        End If
        'Read card
        i = rf_M1_read(0, b3, buf2(0), b2)
        If (i <> 0) Then
            'MessageBox.Show("Falha ao ler o cartao!")
            gf.logNcc("Falha ao ler o cartao!")
            Return ""
        End If
        s1 = ""
        For i = 0 To b2 - 1
            s1 = s1 & Microsoft.VisualBasic.Right("00" & Hex(buf2(i)), 2)
        Next i

        Return s1

    End Function

    Private Function validaEntrada(cardNumber As String) As Boolean
        Dim myValue As New Object
        If dbm.isValid(cardNumber) Then
            socio = dbm.getPartnerByCard(CInt(cardNumber))
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub updateIntervalTimer_Tick(sender As Object, e As EventArgs) Handles updateIntervalTimer.Tick
        darEntrada()
    End Sub

    Private Sub validaQuitBtn_Click(sender As Object, e As EventArgs) Handles validaQuitBtn.Click
        End
    End Sub
End Class