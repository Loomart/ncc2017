Public Class class_list

    Dim class_id As Integer = 0
    Public Property classDataGridView As DataGridView

    Sub New(classId As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        class_id = classId
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub listClassCloseBtn_Click(sender As Object, e As EventArgs) Handles listClassCloseBtn.Click
        Me.Close()
    End Sub

    Private Sub class_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Loo_partner_class1TableAdapter.Fill(Me.Ncc_2015DataSet.loo_partner_class1, class_id)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub
End Class