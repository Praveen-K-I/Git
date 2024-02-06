Public Class Business_Logic
    Dim data_layer As New Data_layer

    Dim User As String
    Dim pwd As String
    Public Shared userBusinesInfo As New userData
    Public Function Get_UserData()
        userBusinesInfo = data_layer.Get_UserData(User, pwd)
        Return userBusinesInfo
    End Function
    Public Function Get_GridData()
        Return data_layer.Get_GridData()
    End Function
    Public Sub Insert_WorkLog(ByVal workLog As workLogData)

        data_layer.Insert_WorkLog(workLog)
    End Sub
    Public Property set_User() As String
        Get

        End Get
        Set(ByVal value As String)
            User = value
        End Set
    End Property
    Public Property set_Password() As String
        Get

        End Get
        Set(ByVal value As String)
            pwd = value
        End Set
    End Property



End Class
