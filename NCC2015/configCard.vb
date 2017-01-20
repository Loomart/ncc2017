Public Class configCard
    Dim main As Windows.Forms.Form

    Sub New(mf As Windows.Forms.Form)

        ' This call is required by the designer.
        InitializeComponent()
        main = mf
        main.Hide()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Function preparaPalavra(ByVal num As String) As String
        Dim palavra As String = ""
        Dim tamanhoNumero As Integer = num.Length
        Dim tamanhoPalavra As Integer = 32
        tamanhoPalavra = tamanhoPalavra - tamanhoNumero
        For i As Integer = 1 To tamanhoPalavra
            palavra = palavra + "0"
        Next
        palavra = palavra + num
        Return palavra
    End Function

    Private Sub requestConfBtn_Click(sender As Object, e As EventArgs) Handles requestConfBtn.Click
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
            MessageBox.Show("Abrir Porta Falhou !")
            dataConfLbl.Text = "Abrir Porta Falhou !"
            Exit Sub
        End If
        'Request
        i = rf_request(0, &H52S, CByte(j))
        If (i <> 0) Then
            MessageBox.Show("Pedido sem sucesso!")
            dataConfLbl.Text = "Pedido sem sucesso!"
            Exit Sub
        End If
        'Anticollision
        i = rf_anticoll(0, 4, buf1(0), b1)
        If (i <> 0) Then
            MessageBox.Show("Anti-colisao Falhou!")
            dataConfLbl.Text = "Anti-colisao Falhou!"
            Exit Sub
        End If
        s1 = ""
        For i = 0 To b1 - 1
            s1 = s1 & Microsoft.VisualBasic.Right("00" & Hex(buf1(i)), 2)
        Next i
        serialConfLbl.Text = s1
        'Select card
        i = rf_select(0, buf1(0), 4, b1)
        If (i <> 0) Then
            MessageBox.Show("Falha na selecao do cartao!")
            dataConfLbl.Text = "Falha na selecao do cartao!"
            Exit Sub
        End If
        MessageBox.Show("Sucesso na selecao do cartao!")
        dataConfLbl.Text = "Sucesso na selecao do cartao!"
    End Sub

    Private Sub readConfBtn_Click(sender As Object, e As EventArgs) Handles readConfBtn.Click
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
            MessageBox.Show("Falha na autenticacao")
            dataConfLbl.Text = "Falha na autenticacao"
            Exit Sub
        End If
        'Read card
        i = rf_M1_read(0, b3, buf2(0), b2)
        If (i <> 0) Then
            MessageBox.Show("Falha ao ler o cartao!")
            dataConfLbl.Text = "Falha ao ler o cartao!"
            Exit Sub
        End If
        s1 = ""
        For i = 0 To b2 - 1
            s1 = s1 & Microsoft.VisualBasic.Right("00" & Hex(buf2(i)), 2)
        Next i
        numConfTxt.Text = s1
        MessageBox.Show("Sucesso na leitura!")
        dataConfLbl.Text = "Sucesso na leitura!"
    End Sub

    Private Sub writeConfBtn_Click(sender As Object, e As EventArgs) Handles writeConfBtn.Click
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
        s1 = Trim(numConfTxt.Text)
        s1 = preparaPalavra(s1)
        For i = 0 To 15
            buf2(i) = CByte(Val("&H" & Mid(s1, i * 2 + 1, 2)))
        Next i
        'Authentication
        b3 = CByte(m)
        i = rf_M1_authentication2(0, b1, b3, buf1(0))
        If (i <> 0) Then
            dataConfLbl.Text = "Falha na autenticacao!"
            Exit Sub
        End If
        'Write card
        i = rf_M1_write(0, b3, buf2(0))
        If (i <> 0) Then
            dataConfLbl.Text = "Falha na escrita do cartao"
            Exit Sub
        End If

        dataConfLbl.Text = "Escrita com sucesso!"
    End Sub

    Private Sub stopConfBtn_Click(sender As Object, e As EventArgs) Handles stopConfBtn.Click
        Dim i As Integer
        i = rf_halt(0)
        If (i <> 0) Then
            MessageBox.Show("Falha na paragem!")
            dataConfLbl.Text = "Falha na paragem!"
            Exit Sub
        End If
        MessageBox.Show("Paragem com sucesso")
        dataConfLbl.Text = "Paragem com sucesso"
    End Sub

    Private Sub cfgQuitBtn_Click(sender As Object, e As EventArgs) Handles cfgQuitBtn.Click
        Me.Close()
        main.Show()
    End Sub


End Class