Public Class user
    Public user_id As Integer
    Public Property userId() As Integer
        Get
            Return user_id
        End Get
        Set(ByVal value As Integer)
            user_id = value
        End Set
    End Property

    Public user_name As String
    Public Property userName() As String
        Get
            Return user_name
        End Get
        Set(ByVal value As String)
            user_name = value
        End Set
    End Property

    Public user_email As String
    Public Property userEmail() As String
        Get
            Return user_email
        End Get
        Set(ByVal value As String)
            user_email = value
        End Set
    End Property

    Public user_super As Boolean
    Public Property userSuper() As Boolean
        Get
            Return user_super
        End Get
        Set(ByVal value As Boolean)
            user_super = value
        End Set
    End Property
    Public user_admin As Boolean
    Public Property userAdmin() As Boolean
        Get
            Return user_admin
        End Get
        Set(ByVal value As Boolean)
            user_admin = value
        End Set
    End Property

    Sub New(ByVal userId As Integer, ByVal userName As String, ByVal userEmail As String, ByVal userSuper As Boolean, ByVal userAdmin As Boolean)
        user_id = userId
        user_name = userName
        user_email = userEmail
        user_super = userSuper
        user_admin = userAdmin
    End Sub
    Sub New()

    End Sub

End Class
