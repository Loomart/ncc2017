Public Class partner
    Dim dbm As New database_manager
    Private partner_number As Integer = 0
    Public Property partnerNumber() As Integer
        Get
            Return partner_number
        End Get
        Set(ByVal value As Integer)
            partner_number = value
        End Set
    End Property
    Private partner_name As String = ""
    Public Property partnerName() As String
        Get
            Return partner_name
        End Get
        Set(ByVal value As String)
            partner_name = value
        End Set
    End Property
    Private partner_birthdate As Date = Date.FromOADate(1900 - 1 - 1)
    Public Property partnerBirthDate() As Date
        Get
            Return partner_birthdate
        End Get
        Set(ByVal value As Date)
            partner_birthdate = value
        End Set
    End Property
    Private partner_add_date As Date = Date.UtcNow
    Public Property partnerAddDate() As Date
        Get
            Return partner_add_date
        End Get
        Set(ByVal value As Date)
            partner_add_date = value
        End Set
    End Property
    Private partner_gender As Integer = 0
    Public Property partnerGender() As String
        Get
            Return partner_gender.ToString
        End Get
        Set(ByVal value As String)
            partner_gender = CInt(value)
        End Set
    End Property
    Private partner_cc As String = "0"
    Public Property partnerCC() As String
        Get
            Return partner_cc
        End Get
        Set(ByVal value As String)
            partner_cc = value
        End Set
    End Property
    Private partner_address As String = ""
    Public Property partnerAddress() As String
        Get
            Return partner_address
        End Get
        Set(ByVal value As String)
            partner_address = value
        End Set
    End Property
    Private partner_postal As String = ""
    Public Property partnerPostal() As String
        Get
            Return partner_postal
        End Get
        Set(ByVal value As String)
            partner_postal = value
        End Set
    End Property
    Private partner_city As String = ""
    Public Property partnerCity() As String
        Get
            Return partner_city
        End Get
        Set(ByVal value As String)
            partner_city = value
        End Set
    End Property
    Private partner_phone As String = "0"
    Public Property partnerPhone() As String
        Get
            Return partner_phone
        End Get
        Set(ByVal value As String)
            partner_phone = value
        End Set
    End Property
    Private partner_mobile As String = "0"
    Public Property partnerMobile() As String
        Get
            Return partner_mobile
        End Get
        Set(ByVal value As String)
            partner_mobile = value
        End Set
    End Property
    Private partner_email As String = ""
    Public Property partnerEmail() As String
        Get
            Return partner_email
        End Get
        Set(ByVal value As String)
            partner_email = value
        End Set
    End Property
    Private partner_parent As Integer = 0
    Public Property partnerParent() As Integer
        Get
            Return partner_parent
        End Get
        Set(ByVal value As Integer)
            partner_parent = value
        End Set
    End Property
    Private partner_is_competition As Boolean = False
    Public Property partnerIsCompetition() As Boolean
        Get
            Return partner_is_competition
        End Get
        Set(ByVal value As Boolean)
            partner_is_competition = value
        End Set
    End Property
    Private partner_image_id As Integer = 0
    Public Property partnerImageId() As Integer
        Get
            Return partner_image_id
        End Get
        Set(ByVal value As Integer)
            partner_image_id = value
        End Set
    End Property
    Private partner_card As String = "0"
    Public Property partnerCard() As String
        Get
            Return partner_card
        End Get
        Set(ByVal value As String)
            partner_card = value
        End Set
    End Property
    Private partner_state As Boolean = False
    Public Property partnerState() As Boolean
        Get
            Return partner_state
        End Get
        Set(ByVal value As Boolean)
            partner_state = value
        End Set
    End Property
    Private partner_month As Integer = 0
    Public Property partnerMonth() As Integer
        Get
            Return partner_month
        End Get
        Set(ByVal value As Integer)
            partner_month = value
        End Set
    End Property
    Private partner_obs As String = ""
    Public Property partnerObs() As String
        Get
            Return partner_obs
        End Get
        Set(ByVal value As String)
            partner_obs = value
        End Set
    End Property
    Private partner_nif As String
    Public Property partnerNif() As String
        Get
            Return partner_nif
        End Get
        Set(ByVal value As String)
            partner_nif = value
        End Set
    End Property
    Private partner_class As Integer
    Public Property partnerClass() As Integer
        Get
            Return partner_class
        End Get
        Set(ByVal value As Integer)
            partner_class = value
        End Set
    End Property

    Sub New()

    End Sub


    'Sub New(partner_id As Integer, partner_name As String, partner_birthdate As Date, partner_add_date As Date, partner_gender As Integer, partner_cc As Integer, partner_address As String, partner_postal As String, partner_city As String, partner_phone As Integer, partner_mobile As Integer, partner_email As String, partner_parent As Integer, partner_is_competition As Boolean, partner_image_id As Integer, partner_card As String, partner_state As Boolean, partner_month As Integer, partner_obs As String)
    '    partnerNumber = partner_id
    '    partnerName = partner_name
    '    partnerBirthDate = partner_birthdate
    '    partnerAddDate = partner_add_date
    '    partnerGender = partner_gender
    '    partnerCC = partner_cc
    '    partnerAddress = partner_address
    '    partnerPostal = partner_postal
    '    partnerCity = partner_city
    '    partnerPhone = partner_phone
    '    partnerMobile = partner_mobile
    '    partnerEmail = partner_email
    '    partnerParent = partner_parent
    '    partnerIsCompetition = partner_is_competition
    '    partnerImageId = partner_image_id
    '    partnerCard = partner_card
    '    partnerState = partner_state
    '    partnerMonth = partner_month
    '    partnerObs = partner_obs
    'End Sub

    Public Sub save()
        dbm.savePartner(Me)
    End Sub

    Public Sub update()
        dbm.updatePartner(Me)
    End Sub

End Class
