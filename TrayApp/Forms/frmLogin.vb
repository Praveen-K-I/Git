Public Class frmLogin
    Dim data_layer As New Data_layer
    Dim user_Data As New userData
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        data_layer.set_User = txtUser.Text.Trim()
            data_layer.set_Password = txtPass.Text.Trim()

            user_Data = data_layer.Get_UserData()

            If user_Data.set_UserId = 0 Then

                MsgBox("Invalid user name or password", MsgBoxStyle.Critical, "Informartion")

            Else

                frmTaskSelection.Show()
                Me.Hide()

            End If


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        End

    End Sub
End Class