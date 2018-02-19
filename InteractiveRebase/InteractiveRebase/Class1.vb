Public NotInheritable Class SampleClass
    Private _firstName As String
    Public Property FirstName() As String
        Get
            Return _firstName
        End Get
        Set(ByVal value As String)
            _firstName = value
        End Set
    End Property

    Private _lastname As String
    Public Property LastName() As String
        Get
            Return _lastname
        End Get
        Set(ByVal value As String)
            _lastname = value
        End Set
    End Property

    Private _lastname As String
    Public Property LastName() As String
        Get
            Return _lastname
        End Get
        Set(ByVal value As String)
            _lastname = value
        End Set
    End Property

    Function DisplayName() As String
        Dim prefix As String
        prefix = "Name: "
        Return prefix & _firstName & " " & _lastname
    End Function

End Class
