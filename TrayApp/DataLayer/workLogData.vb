Public Class workLogData
    Dim Task_Id As Integer
    Dim User_Id As Integer
    Dim Days As Integer
    Dim Hours As Integer
    Dim Minutes As Integer


    Public Property set_TaskId() As Integer
        Get
            Return Task_Id
        End Get
        Set(ByVal value As Integer)
            Task_Id = value
        End Set
    End Property
    Public Property set_UserId() As Integer
        Get
            Return User_Id
        End Get
        Set(ByVal value As Integer)
            User_Id = value
        End Set
    End Property
    Public Property set_Days() As Integer
        Get
            Return Days
        End Get
        Set(ByVal value As Integer)
            Days = value
        End Set
    End Property

    Public Property set_Hours() As Integer
        Get
            Return Hours
        End Get
        Set(ByVal value As Integer)
            Hours = value
        End Set
    End Property
    Public Property set_Minutes() As Integer
        Get
            Return Minutes
        End Get
        Set(ByVal value As Integer)
            Minutes = value
        End Set
    End Property
End Class
