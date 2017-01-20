Public Class medic
    Dim dbm As New database_manager
    Private medic_id As Integer
    Public Property medicId() As Integer
        Get
            Return medic_id
        End Get
        Set(ByVal value As Integer)
            medic_id = value
        End Set
    End Property
    Private medic_card_number As String
    Public Property medicCardNumber() As String
        Get
            Return medic_card_number
        End Get
        Set(ByVal value As String)
            medic_card_number = value
        End Set
    End Property
    Private medic_entity As String
    Public Property medicEntity() As String
        Get
            Return medic_entity
        End Get
        Set(ByVal value As String)
            medic_entity = value
        End Set
    End Property
    Private medic_partner_id As Integer
    Public Property medicPartnerId() As Integer
        Get
            Return medic_partner_id
        End Get
        Set(ByVal value As Integer)
            medic_partner_id = value
        End Set
    End Property
    Sub New(medicId As Integer, cardNumber As String, medicEntity As String, medicPartnerId As Integer)
        medic_id = medicId
        medic_card_number = cardNumber
        medic_entity = medicEntity
        medic_partner_id = medicPartnerId
    End Sub
    Sub New()

    End Sub
    Public Sub save()
        dbm.saveMedic(Me)
    End Sub

    Public Sub update()
        dbm.updateMedic(Me)
    End Sub
End Class
