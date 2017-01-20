Imports System.IO
Imports System.Text.RegularExpressions

Public Class globalFunctions

    Dim dbm As database_manager
    Public Function validateEmail(emailAddress As String) As Boolean
        ' Dim email As New Regex("^(?<user>[^@]+)@(?<host>.+)$")
        If (emailAddress = "") Then
            Return True
        End If
        Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        If email.IsMatch(emailAddress) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function areYouSureWarning(mensagem As String) As Boolean
        Dim message, title As String
        Dim myValue As MsgBoxResult
        ' Set prompt.
        message = "Tem a certeza que deseja " & mensagem & " ?"
        ' Set title.
        title = "Aviso"
        ' Display message, title, and default value.
        myValue = MsgBox(message, MsgBoxStyle.OkCancel, title)
        If myValue = MsgBoxResult.Cancel Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub strictNumbers(e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Por Favor introduza unicamente números.")
            e.Handled = True
        End If
    End Sub

    Public Sub logNcc(logMessage As String)
        Using w As StreamWriter = File.AppendText("c:\log.txt")
            w.Write(vbCrLf + "Log Entry : ")
            w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
            DateTime.Now.ToLongDateString())
            w.WriteLine("  :")
            w.WriteLine("  :{0}", logMessage)
            w.WriteLine("-------------------------------")
        End Using

        'Using r As StreamReader = File.OpenText("log.txt")
        '    Dim line As String
        '    line = r.ReadLine()
        '    While Not (line Is Nothing)
        '        Console.WriteLine(line)
        '        line = r.ReadLine()
        '    End While
        'End Using
    End Sub

    Public Function preparaNumeroCartao(ByVal num As String) As String
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
End Class
