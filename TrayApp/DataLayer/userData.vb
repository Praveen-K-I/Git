Public Class userData
    Dim User_Id As Integer
    Dim User_Name As String
    Public Property set_UserId() As Integer
        Get
            Return User_Id
        End Get
        Set(ByVal value As Integer)
            User_Id = value
        End Set
    End Property
    Public Property set_UserName() As String
        Get
            Return User_Name
        End Get
        Set(ByVal value As String)
            User_Name = value
        End Set
    End Property
End Class
