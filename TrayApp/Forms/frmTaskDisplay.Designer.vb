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
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(100, 84)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnPause
        '
        Me.btnPause.Location = New System.Drawing.Point(336, 84)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(75, 23)
        Me.btnPause.TabIndex = 1
        Me.btnPause.Text = "Pause"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(220, 202)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 2
        Me.btnStop.Text = "Stop"
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
        Me.lblTimerTicks.AutoSize = True
        Me.lblTimerTicks.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimerTicks.Location = New System.Drawing.Point(217, 147)
        Me.lblTimerTicks.Name = "lblTimerTicks"
        Me.lblTimerTicks.Size = New System.Drawing.Size(103, 18)
        Me.lblTimerTicks.TabIndex = 4
        Me.lblTimerTicks.Text = "TimerTicks"
        '
        'lblTaskDescription
        '
        Me.lblTaskDescription.AutoSize = True
        Me.lblTaskDescription.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaskDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTaskDescription.Location = New System.Drawing.Point(182, 37)
        Me.lblTaskDescription.Name = "lblTaskDescription"
        Me.lblTaskDescription.Size = New System.Drawing.Size(148, 18)
        Me.lblTaskDescription.TabIndex = 5
        Me.lblTaskDescription.Text = "TaskDescription"
        '
        'frmTaskDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 341)
        Me.Controls.Add(Me.lblTaskDescription)
        Me.Controls.Add(Me.lblTimerTicks)
        Me.Controls.Add(Me.lblStartTime)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "frmTaskDisplay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TaskDisplay"
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
End Class
