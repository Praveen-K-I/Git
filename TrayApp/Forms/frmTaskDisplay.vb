Public Class frmTaskDisplay

    Dim task_Data As New taskData
    Dim glblMyNotifyobj As New NotifyIcon
    Dim showCount As Integer = 0
    Dim data_layer As New Data_layer


    Private Sub frmTaskDisplay_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        If Me.WindowState = FormWindowState.Minimized Then

            Hide()

            glblMyNotifyobj = MyNotifyIcon
            glblMyNotifyobj.Visible = True

            glblMyNotifyobj.Icon = TrackTask.My.Resources.Window
            glblMyNotifyobj.BalloonTipText = lblStartTime.Text

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        
        Dim starttime As DateTime = lblStartTime.Text
        Dim lblRecTimertick As DateTime


        If btnStart.Enabled = True Then
            If (lblTimerTicks.Text <> "TimerTicks") Then
                lblRecTimertick = Convert.ToDateTime(lblTimerTicks.Text)
                lblStartTime.Text = DateTime.Now.Subtract(Convert.ToDateTime(lblRecTimertick.ToShortTimeString).TimeOfDay)
                starttime = lblStartTime.Text

            End If


        End If

        btnStart.Enabled = False



        lblTimerTicks.Text = String.Format("{0} : {1} : {2}", (DateTime.Now - starttime).Hours, (DateTime.Now - starttime).Minutes, (DateTime.Now - starttime).Seconds)


        glblMyNotifyobj.Text = lblTimerTicks.Text

    End Sub

    Private Sub MyNotifyIcon_MouseMove(sender As Object, e As MouseEventArgs) Handles MyNotifyIcon.MouseMove

        If showCount = 0 Then

            glblMyNotifyobj.BalloonTipText = lblTimerTicks.Text
            MyNotifyIcon.ShowBalloonTip(1)
            showCount += 1

        End If
    End Sub
    Public Property task_Info() As taskData
        Get
            Return task_Data
        End Get
        Set(ByVal value As taskData)
            task_Data = value
        End Set
    End Property


    Private Sub MyNotifyIcon_BalloonTipClicked(sender As Object, e As EventArgs) Handles MyNotifyIcon.BalloonTipClicked

        showCount = 0

    End Sub

    Private Sub MyNotifyIcon_BalloonTipClosed(sender As Object, e As EventArgs) Handles MyNotifyIcon.BalloonTipClosed

        showCount = 0

    End Sub

    Private Sub MyNotifyIcon_Click(sender As Object, e As EventArgs) Handles MyNotifyIcon.Click

        Show()

        Me.WindowState = FormWindowState.Normal
        glblMyNotifyobj.Visible = False
        showCount = 0

    End Sub

    Private Sub frmTaskDisplay_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        frmTaskSelection.Show()

    End Sub

    Private Sub frmTaskDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblTaskDescription.Text = task_Data.set_Task_Name

    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click

        Dim starttime As DateTime = lblStartTime.Text
        Hide()
        Try

            data_layer.set_Days = String.Format("{0}", DateTime.Now.Subtract(starttime).Days)
            data_layer.set_Hours = String.Format("{0}", (DateTime.Now - starttime).Hours)
            data_layer.set_Minutes = String.Format("{0}", (DateTime.Now - starttime).Minutes)
            data_layer.set_UserId = task_Data.set_UserId
            data_layer.set_TaskId = task_Data.set_TaskId
            If (data_layer.set_Days + data_layer.set_Hours + data_layer.set_Minutes <> 0) Then
                data_layer.Insert_WorkLog()
            End If

            frmTaskSelection.Show()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Information")

        End Try

    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click

        Timer1.Stop()
        btnStart.Enabled = True
        btnPause.Enabled = False
        btnStop.Enabled = False

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Timer1.Start()
        btnPause.Enabled = True
        btnStop.Enabled = True

    End Sub
End Class