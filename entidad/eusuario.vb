Public Class eusuario
    Private users As String
    Private password As String
    Private nivel As String

    Public Property _users
        Get
            Return users
        End Get
        Set(value)
            users = value
        End Set
    End Property

    Public Property _password
        Get
            Return password
        End Get
        Set(value)
            password = value
        End Set
    End Property

    Public Property _nivel
        Get
            Return nivel
        End Get
        Set(value)
            nivel = value
        End Set
    End Property

    Public Sub New()

    End Sub

End Class
