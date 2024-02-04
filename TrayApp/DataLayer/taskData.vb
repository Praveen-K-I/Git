Public Class taskData

    Dim User_Id As Integer
    Dim Task_id As Integer
    Dim Task_Name As String
    Public Property set_UserId() As Integer
        Get
            Return User_Id
        End Get
        Set(ByVal value As Integer)
            User_Id = value
        End Set
    End Property
    Public Property set_TaskId() As Integer
        Get
            Return Task_id
        End Get
        Set(ByVal value As Integer)
            Task_id = value
        End Set
    End Property
    Public Property set_Task_Name() As String
        Get
            Return Task_Name
        End Get
        Set(ByVal value As String)
            Task_Name = value
        End Set
    End Property
End Class
