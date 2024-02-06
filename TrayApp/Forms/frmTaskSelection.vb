Public Class frmTaskSelection

    Dim data_layer As New Data_layer
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim task_Data As New taskData

        Hide()
        Try

            task_Data.set_TaskId = DataGridView1.CurrentRow.Cells(0).Value
            task_Data.set_UserId = Data_layer.userInfo.set_UserId
            task_Data.set_Task_Name = DataGridView1.CurrentRow.Cells(1).Value

            frmTaskDisplay.Text = "Task Of " & Data_layer.userInfo.set_UserName
            frmTaskDisplay.task_Info = task_Data
            frmTaskDisplay.Show()
            frmTaskDisplay.Timer1.Start()
            frmTaskDisplay.lblStartTime.Text = DateTime.Now

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Information")

        End Try


    End Sub
    Private Sub frmTaskSelection_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        frmLogin.Show()

    End Sub

    Private Sub frmTaskSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1.DataSource = data_layer.Get_GridData()
        If DataGridView1.DataSource IsNot Nothing Then
            DataGridView1.Columns(1).Width = 300
        End If

    End Sub
End Class