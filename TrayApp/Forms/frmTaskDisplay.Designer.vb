<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTaskDisplay
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.lblStartTime = New System.Windows.Forms.Label()
        Me.MyNotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimerTicks = New System.Windows.Forms.Label()
        Me.lblTaskDescription = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStart.Image = Global.TrackTask.My.Resources.Resources.start_icon3
        Me.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStart.Location = New System.Drawing.Point(50, 41)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(66, 32)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnPause
        '
        Me.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPause.Image = Global.TrackTask.My.Resources.Resources.Pause1
        Me.btnPause.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPause.Location = New System.Drawing.Point(317, 41)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(66, 32)
        Me.btnPause.TabIndex = 1
        Me.btnPause.Text = "Pause"
        Me.btnPause.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStop.Image = Global.TrackTask.My.Resources.Resources._stop
        Me.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStop.Location = New System.Drawing.Point(184, 170)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(66, 32)
        Me.btnStop.TabIndex = 2
        Me.btnStop.Text = "Stop"
        Me.btnStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'lblStartTime
        '
        Me.lblStartTime.AutoSize = True
        Me.lblStartTime.Location = New System.Drawing.Point(12, 42)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(62, 13)
        Me.lblStartTime.TabIndex = 3
        Me.lblStartTime.Text = "lblStartTime"
        Me.lblStartTime.Visible = False
        '
        'MyNotifyIcon
        '
        Me.MyNotifyIcon.Text = "NotifyIcon1"
        Me.MyNotifyIcon.Visible = True
        '
        'Timer1
        '
        '
        'lblTimerTicks
        '
        Me.lblTimerTicks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTimerTicks.AutoSize = True
        Me.lblTimerTicks.BackColor = System.Drawing.Color.Transparent
        Me.lblTimerTicks.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimerTicks.Location = New System.Drawing.Point(175, 112)
        Me.lblTimerTicks.Name = "lblTimerTicks"
        Me.lblTimerTicks.Size = New System.Drawing.Size(103, 18)
        Me.lblTimerTicks.TabIndex = 4
        Me.lblTimerTicks.Text = "TimerTicks"
        Me.lblTimerTicks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTaskDescription
        '
        Me.lblTaskDescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTaskDescription.AutoSize = True
        Me.lblTaskDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblTaskDescription.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaskDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTaskDescription.Location = New System.Drawing.Point(153, 25)
        Me.lblTaskDescription.Name = "lblTaskDescription"
        Me.lblTaskDescription.Size = New System.Drawing.Size(148, 18)
        Me.lblTaskDescription.TabIndex = 5
        Me.lblTaskDescription.Text = "TaskDescription"
        Me.lblTaskDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.TrackTask.My.Resources.Resources.background1
        Me.Panel1.Controls.Add(Me.lblTaskDescription)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(438, 66)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.TrackTask.My.Resources.Resources.background1
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 281)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(438, 66)
        Me.Panel2.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.TrackTask.My.Resources.Resources.background1
        Me.Panel3.Controls.Add(Me.btnStart)
        Me.Panel3.Controls.Add(Me.btnPause)
        Me.Panel3.Controls.Add(Me.btnStop)
        Me.Panel3.Controls.Add(Me.lblTimerTicks)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 66)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(438, 215)
        Me.Panel3.TabIndex = 8
        '
        'frmTaskDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 347)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblStartTime)
        Me.Name = "frmTaskDisplay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TaskDisplay"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnPause As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents lblStartTime As Label
    Friend WithEvents MyNotifyIcon As NotifyIcon
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lblTimerTicks As Label
    Friend WithEvents lblTaskDescription As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
