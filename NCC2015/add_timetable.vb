Imports System.Text.RegularExpressions

Public Class add_timetable

    Dim partnerId As Integer = 0
    Dim main As Windows.Forms.Form

    Sub New(partner_id As Integer, mf As Windows.Forms.Form)

        ' This call is required by the designer.
        InitializeComponent()
        partnerId = partner_id
        main = mf
        main.Hide()

    End Sub

    Private Sub timetableSaveBtn_Click(sender As Object, e As EventArgs) Handles timetableSaveBtn.Click
        If timetableDayCmb.SelectedIndex = -1 Or timetableFromCmb.SelectedItem Is Nothing Or timetableToCmb.SelectedItem Is Nothing Then
            MsgBox("Deve preencher os campos antes de guardar o horário.", MsgBoxStyle.OkOnly, "")
        Else
            Dim tt As New timetable
            tt.day = timetableDayCmb.SelectedIndex
            Dim since() As String = Regex.Split(timetableFromCmb.SelectedItem.ToString, "(:)")
            Dim until() As String = Regex.Split(timetableToCmb.SelectedItem.ToString, "(:)")
            tt.since_hour = since(0)
            tt.since_minutes = since(2)
            tt.to_hour = until(0)
            tt.to_minutes = until(2)
            tt.partner_id = partnerId
            tt.save()
            MsgBox("Horário guardado com sucesso !", MsgBoxStyle.OkOnly, "")
        End If


    End Sub


    Private Sub timetableQuitBtn_Click(sender As Object, e As EventArgs) Handles timetableQuitBtn.Click
        Me.Close()
        main.Show()
    End Sub

    Private Sub timetableViewBtn_Click(sender As Object, e As EventArgs) Handles timetableViewBtn.Click
        Dim viewTimetableForm As New view_timetable(partnerId, Me)
        viewTimetableForm.partner_id = partnerId
        viewTimetableForm.Show()
    End Sub
End Class