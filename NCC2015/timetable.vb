Public Class timetable
    Dim dbm As New database_manager
    Dim monday As Integer = 0
    Dim tuesday As Integer = 1
    Dim wednesday As Integer = 2
    Dim thursday As Integer = 3
    Dim friday As Integer = 4
    Dim saturday As Integer = 5
    Dim sunday As Integer = 6
    
    Private timetable_day As Integer
    Public Property day() As Integer
        Get
            Return timetable_day
        End Get
        Set(ByVal value As Integer)
            timetable_day = value
        End Set
    End Property
    Private timetable_since_hour As String
    Public Property since_hour() As String
        Get
            Return timetable_since_hour
        End Get
        Set(ByVal value As String)
            timetable_since_hour = value
        End Set
    End Property
    Private timetable_since_minutes As String
    Public Property since_minutes() As String
        Get
            Return timetable_since_minutes
        End Get
        Set(ByVal value As String)
            timetable_since_minutes = value
        End Set
    End Property
    Private timetable_to_hour As String
    Public Property to_hour() As String
        Get
            Return timetable_to_hour
        End Get
        Set(ByVal value As String)
            timetable_to_hour = value
        End Set
    End Property
    Private timetable_to_minutes As String
    Public Property to_minutes() As String
        Get
            Return timetable_to_minutes
        End Get
        Set(ByVal value As String)
            timetable_to_minutes = value
        End Set
    End Property
    Private timetable_partner_id As Integer
    Public Property partner_id() As Integer
        Get
            Return timetable_partner_id
        End Get
        Set(ByVal value As Integer)
            timetable_partner_id = value
        End Set
    End Property

    Sub New()

    End Sub

    Public Sub save()
        dbm.saveTimetable(Me)
    End Sub

    Public Sub update()
        dbm.updateTimetable(Me)
    End Sub



End Class
