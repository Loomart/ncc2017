Public Class payment
    Dim dbm As New database_manager

    Private payment_day As Date = Date.UtcNow
    Public Property paymentDay() As Date
        Get
            Return payment_day
        End Get
        Set(ByVal value As Date)
            payment_day = value
        End Set
    End Property
    Private payment_value As Int32
    Public Property paymentValue() As Int32
        Get
            Return payment_value
        End Get
        Set(ByVal value As Int32)
            payment_value = value
        End Set
    End Property
    Private payment_partner As partner
    Public Property paymentPartner() As partner
        Get
            Return payment_partner
        End Get
        Set(ByVal value As partner)
            payment_partner = value
        End Set
    End Property

    Sub New()

    End Sub

    Public Sub save()
        dbm.savePayment(Me)
    End Sub

    Public Sub update()
        dbm.updatePayment(Me)
    End Sub


End Class
