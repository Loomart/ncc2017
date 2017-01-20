Imports System.Data.SqlClient

Public Class view_timetable
    Dim dataBaseConn As database_manager = New database_manager
    Dim gf As globalFunctions = New globalFunctions
    Private partnerId As Integer = 1
    Dim main As Windows.Forms.Form


    Public Property partner_id() As Integer
        Get
            Return partnerId
        End Get
        Set(ByVal value As Integer)
            partnerId = value
        End Set
    End Property

    Sub New(partner_id As Integer, mf As Windows.Forms.Form)

        ' This call is required by the designer.
        InitializeComponent()
        partnerId = partner_id
        main = mf
        main.Hide()

    End Sub

    Private Sub timetableViewCloseBtn_Click(sender As Object, e As EventArgs) Handles timetableViewCloseBtn.Click
        Me.Close()
        main.Show()
    End Sub

    Private Sub view_timetable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataBaseConn.getTimeTable(timetableGridView, partnerId)
    End Sub

    Private Sub deleteRowBtn_Click(sender As Object, e As EventArgs) Handles deleteRowBtn.Click
        Dim selectedRow As DataGridViewRow
        Dim idToRemove As Integer
        If timetableGridView.SelectedRows.Count > 0 Then
            If gf.areYouSureWarning("eliminar horário") Then
                selectedRow = timetableGridView.SelectedRows(0)
                idToRemove = CInt(timetableGridView.Rows(selectedRow.Index).Cells(0).Value.ToString())
                timetableGridView.Rows.Remove(timetableGridView.SelectedRows(0))
                dataBaseConn.deleteTimetable(idToRemove)
            End If
        Else
            MessageBox.Show("Selecione pelo menos um registo.")
        End If
    End Sub
End Class