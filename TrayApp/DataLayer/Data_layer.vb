Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class Data_layer
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection(ConfigurationManager.AppSettings("connectionString"))
    Dim rdr As SqlDataReader
    Dim adptr As New SqlDataAdapter

    Public Shared userInfo As New userData

    Public Function Get_UserData(ByVal User As String, ByVal pwd As String)
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
    Public Sub Insert_WorkLog(ByVal workLog As workLogData)
        cmd.Connection = GetMy_Connnection()

        cmd.CommandText = "insert into tblWorkLog(TaskId,UserId,Days,Hours,Minutes) values(" &
            workLog.set_TaskId & "," & workLog.set_UserId & "," & workLog.set_Days & "," & workLog.set_Hours & "," & workLog.set_Minutes & ")"
        cmd.ExecuteNonQuery()

    End Sub

End Class
