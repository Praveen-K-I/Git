Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class Data_layer
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection(ConfigurationManager.AppSettings("connectionString"))
    Dim rdr As SqlDataReader
    Dim adptr As New SqlDataAdapter
    Dim Task_Id As Integer
    Dim User_Id As Integer
    Dim Days As Integer
    Dim Hours As Integer
    Dim Minutes As Integer
    Dim User As String
    Dim pwd As String
    Public Shared userInfo As New userData

    Public Function Get_UserData()
        Try

            cmd.Connection = GetMy_Connnection()

            ' Stored procedure method also we can use here , but  using  the code as follows due to time limitation
            cmd.CommandText = "Select * from tblUser where UserName='" & User & "' and Password='" & pwd & "'"
            rdr = cmd.ExecuteReader
            If rdr.HasRows = True Then
                rdr.Read()
                userInfo.set_UserId = rdr.Item(0)
                userInfo.set_UserName = rdr.Item(1)
            Else
                userInfo.set_UserId = 0
            End If
            rdr.Close()
            Return userInfo

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Information")
        End Try

    End Function
    Public Function GetMy_Connnection()

        Try
            If (con.State = ConnectionState.Closed) Then
                con.Open()

            End If
            Return con
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Information")
        Finally

        End Try


    End Function
    Public Function Get_GridData()
        Dim dt As New System.Data.DataTable
        cmd.Connection = GetMy_Connnection()
        cmd.CommandText = "Select Id,TaskDescription from tblTask where UserId=" & userInfo.set_UserId & ""
        adptr.SelectCommand = cmd
        adptr.Fill(dt)
        Return dt
    End Function
    Public Sub Insert_WorkLog()
        cmd.Connection = GetMy_Connnection()

        cmd.CommandText = "insert into tblWorkLog(TaskId,UserId,Days,Hours,Minutes) values(" &
            Task_Id & "," & User_Id & "," & Days & "," & Hours & "," & Minutes & ")"
        cmd.ExecuteNonQuery()

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
