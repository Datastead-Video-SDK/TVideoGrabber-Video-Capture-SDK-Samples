Option Strict Off
Option Explicit On 
Friend Class miscDVCommands
    Inherits SubForm ' SubForm is declared in VBUtil and inherits from System.Windows.Forms.Form
    'Unlike normal Form, it is not destroyed when closed, unless MainForm is being destroyed too.

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents grbDVCommands As System.Windows.Forms.GroupBox
    Friend WithEvents btnPlaySlowestRev As System.Windows.Forms.Button
    Friend WithEvents btnPlayFastestRev As System.Windows.Forms.Button
    Friend WithEvents btnPlaySlowestFwd As System.Windows.Forms.Button
    Friend WithEvents btnPlayFastestFwd As System.Windows.Forms.Button
    Friend WithEvents btnModeShuttle As System.Windows.Forms.Button
    Friend WithEvents btnStepRev As System.Windows.Forms.Button
    Friend WithEvents btnStepFwd As System.Windows.Forms.Button
    Friend WithEvents btnRecordStrobe As System.Windows.Forms.Button
    Friend WithEvents btnRecordFreeze As System.Windows.Forms.Button
    Friend WithEvents btnRecord As System.Windows.Forms.Button
    Friend WithEvents btnRew As System.Windows.Forms.Button
    Friend WithEvents btnFF As System.Windows.Forms.Button
    Friend WithEvents btnThaw As System.Windows.Forms.Button
    Friend WithEvents btnFreeze As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grbDVCommands = New System.Windows.Forms.GroupBox
        Me.btnPlaySlowestRev = New System.Windows.Forms.Button
        Me.btnPlayFastestRev = New System.Windows.Forms.Button
        Me.btnPlaySlowestFwd = New System.Windows.Forms.Button
        Me.btnPlayFastestFwd = New System.Windows.Forms.Button
        Me.btnModeShuttle = New System.Windows.Forms.Button
        Me.btnStepRev = New System.Windows.Forms.Button
        Me.btnStepFwd = New System.Windows.Forms.Button
        Me.btnRecordStrobe = New System.Windows.Forms.Button
        Me.btnRecordFreeze = New System.Windows.Forms.Button
        Me.btnRecord = New System.Windows.Forms.Button
        Me.btnRew = New System.Windows.Forms.Button
        Me.btnFF = New System.Windows.Forms.Button
        Me.btnThaw = New System.Windows.Forms.Button
        Me.btnFreeze = New System.Windows.Forms.Button
        Me.btnStop = New System.Windows.Forms.Button
        Me.btnPlay = New System.Windows.Forms.Button
        Me.grbDVCommands.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbDVCommands
        '
        Me.grbDVCommands.Controls.Add(Me.btnPlaySlowestRev)
        Me.grbDVCommands.Controls.Add(Me.btnPlayFastestRev)
        Me.grbDVCommands.Controls.Add(Me.btnPlaySlowestFwd)
        Me.grbDVCommands.Controls.Add(Me.btnPlayFastestFwd)
        Me.grbDVCommands.Controls.Add(Me.btnModeShuttle)
        Me.grbDVCommands.Controls.Add(Me.btnStepRev)
        Me.grbDVCommands.Controls.Add(Me.btnStepFwd)
        Me.grbDVCommands.Controls.Add(Me.btnRecordStrobe)
        Me.grbDVCommands.Controls.Add(Me.btnRecordFreeze)
        Me.grbDVCommands.Controls.Add(Me.btnRecord)
        Me.grbDVCommands.Controls.Add(Me.btnRew)
        Me.grbDVCommands.Controls.Add(Me.btnFF)
        Me.grbDVCommands.Controls.Add(Me.btnThaw)
        Me.grbDVCommands.Controls.Add(Me.btnFreeze)
        Me.grbDVCommands.Controls.Add(Me.btnStop)
        Me.grbDVCommands.Controls.Add(Me.btnPlay)
        Me.grbDVCommands.Location = New System.Drawing.Point(8, 8)
        Me.grbDVCommands.Name = "grbDVCommands"
        Me.grbDVCommands.Size = New System.Drawing.Size(528, 152)
        Me.grbDVCommands.TabIndex = 16
        Me.grbDVCommands.TabStop = False
        Me.grbDVCommands.Text = "Send DV commands"
        '
        'btnPlaySlowestRev
        '
        Me.btnPlaySlowestRev.Location = New System.Drawing.Point(400, 120)
        Me.btnPlaySlowestRev.Name = "btnPlaySlowestRev"
        Me.btnPlaySlowestRev.Size = New System.Drawing.Size(120, 24)
        Me.btnPlaySlowestRev.TabIndex = 31
        Me.btnPlaySlowestRev.Text = "Play slowest rev"
        '
        'btnPlayFastestRev
        '
        Me.btnPlayFastestRev.Location = New System.Drawing.Point(272, 120)
        Me.btnPlayFastestRev.Name = "btnPlayFastestRev"
        Me.btnPlayFastestRev.Size = New System.Drawing.Size(120, 24)
        Me.btnPlayFastestRev.TabIndex = 30
        Me.btnPlayFastestRev.Text = "Play fastest rev"
        '
        'btnPlaySlowestFwd
        '
        Me.btnPlaySlowestFwd.Location = New System.Drawing.Point(144, 120)
        Me.btnPlaySlowestFwd.Name = "btnPlaySlowestFwd"
        Me.btnPlaySlowestFwd.Size = New System.Drawing.Size(120, 24)
        Me.btnPlaySlowestFwd.TabIndex = 29
        Me.btnPlaySlowestFwd.Text = "Play slowest fwd"
        '
        'btnPlayFastestFwd
        '
        Me.btnPlayFastestFwd.Location = New System.Drawing.Point(16, 120)
        Me.btnPlayFastestFwd.Name = "btnPlayFastestFwd"
        Me.btnPlayFastestFwd.Size = New System.Drawing.Size(120, 24)
        Me.btnPlayFastestFwd.TabIndex = 28
        Me.btnPlayFastestFwd.Text = "Play fastest fwd"
        '
        'btnModeShuttle
        '
        Me.btnModeShuttle.Location = New System.Drawing.Point(400, 88)
        Me.btnModeShuttle.Name = "btnModeShuttle"
        Me.btnModeShuttle.Size = New System.Drawing.Size(120, 24)
        Me.btnModeShuttle.TabIndex = 27
        Me.btnModeShuttle.Text = "Mode Shhuttle"
        '
        'btnStepRev
        '
        Me.btnStepRev.Location = New System.Drawing.Point(272, 88)
        Me.btnStepRev.Name = "btnStepRev"
        Me.btnStepRev.Size = New System.Drawing.Size(120, 24)
        Me.btnStepRev.TabIndex = 26
        Me.btnStepRev.Text = "Step Rev"
        '
        'btnStepFwd
        '
        Me.btnStepFwd.Location = New System.Drawing.Point(144, 88)
        Me.btnStepFwd.Name = "btnStepFwd"
        Me.btnStepFwd.Size = New System.Drawing.Size(120, 24)
        Me.btnStepFwd.TabIndex = 25
        Me.btnStepFwd.Text = "Step Fwd"
        '
        'btnRecordStrobe
        '
        Me.btnRecordStrobe.Location = New System.Drawing.Point(16, 88)
        Me.btnRecordStrobe.Name = "btnRecordStrobe"
        Me.btnRecordStrobe.Size = New System.Drawing.Size(120, 24)
        Me.btnRecordStrobe.TabIndex = 24
        Me.btnRecordStrobe.Text = "Record strobe"
        '
        'btnRecordFreeze
        '
        Me.btnRecordFreeze.Location = New System.Drawing.Point(400, 56)
        Me.btnRecordFreeze.Name = "btnRecordFreeze"
        Me.btnRecordFreeze.Size = New System.Drawing.Size(120, 24)
        Me.btnRecordFreeze.TabIndex = 23
        Me.btnRecordFreeze.Text = "Record freeze"
        '
        'btnRecord
        '
        Me.btnRecord.Location = New System.Drawing.Point(272, 56)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(120, 24)
        Me.btnRecord.TabIndex = 22
        Me.btnRecord.Text = "Record"
        '
        'btnRew
        '
        Me.btnRew.Location = New System.Drawing.Point(144, 56)
        Me.btnRew.Name = "btnRew"
        Me.btnRew.Size = New System.Drawing.Size(120, 24)
        Me.btnRew.TabIndex = 21
        Me.btnRew.Text = "Rewind"
        '
        'btnFF
        '
        Me.btnFF.Location = New System.Drawing.Point(16, 56)
        Me.btnFF.Name = "btnFF"
        Me.btnFF.Size = New System.Drawing.Size(120, 24)
        Me.btnFF.TabIndex = 20
        Me.btnFF.Text = "FF"
        '
        'btnThaw
        '
        Me.btnThaw.Location = New System.Drawing.Point(400, 24)
        Me.btnThaw.Name = "btnThaw"
        Me.btnThaw.Size = New System.Drawing.Size(120, 24)
        Me.btnThaw.TabIndex = 19
        Me.btnThaw.Text = "Thaw"
        '
        'btnFreeze
        '
        Me.btnFreeze.Location = New System.Drawing.Point(272, 24)
        Me.btnFreeze.Name = "btnFreeze"
        Me.btnFreeze.Size = New System.Drawing.Size(120, 24)
        Me.btnFreeze.TabIndex = 18
        Me.btnFreeze.Text = "Freeze"
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(144, 24)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(120, 24)
        Me.btnStop.TabIndex = 17
        Me.btnStop.Text = "Stop"
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(16, 24)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(120, 24)
        Me.btnPlay.TabIndex = 16
        Me.btnPlay.Text = "Play"
        '
        'miscDVCommands
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(544, 165)
        Me.Controls.Add(Me.grbDVCommands)
        Me.Name = "miscDVCommands"
        Me.Text = "Send commands to the DV camcorder"
        Me.grbDVCommands.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub RefreshControls()
        grbDVCommands.Enabled = MainForm.DefInstance.VideoGrabber1.IsDigitalVideoIn
    End Sub

    Private Sub SendDVCommand(ByRef DvCommand As VidGrab.TDVCommand)
        If MainForm.DefInstance.VideoGrabber1.SendDVCommand(DvCommand) Then
            AddLog(MainForm.DefInstance.mmoLog, "DV command sent...")
        Else
            If (MainForm.DefInstance.VideoGrabber1.CurrentState <> VidGrab.TCurrentState.cs_Preview) And (MainForm.DefInstance.VideoGrabber1.CurrentState <> VidGrab.TCurrentState.cs_Recording) Then
                AddLog(MainForm.DefInstance.mmoLog, "DV command failed. Preview must be running!")
            Else
                AddLog(MainForm.DefInstance.mmoLog, "DV command failed.")
            End If
        End If
    End Sub


    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        SendDVCommand(VidGrab.TDVCommand.dv_Play)
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        SendDVCommand(VidGrab.TDVCommand.dv_Stop)
    End Sub

    Private Sub btnFreeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFreeze.Click
        SendDVCommand(VidGrab.TDVCommand.dv_Freeze)
    End Sub

    Private Sub btnThaw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThaw.Click
        SendDVCommand(VidGrab.TDVCommand.dv_Thaw)
    End Sub

    Private Sub btnFF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFF.Click
        SendDVCommand(VidGrab.TDVCommand.dv_Ff)
    End Sub

    Private Sub btnRew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRew.Click
        SendDVCommand(VidGrab.TDVCommand.dv_Rew)
    End Sub

    Private Sub btnRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecord.Click
        SendDVCommand(VidGrab.TDVCommand.dv_Record)
    End Sub

    Private Sub btnRecordFreeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecordFreeze.Click
        SendDVCommand(VidGrab.TDVCommand.dv_RecordFreeze)
    End Sub

    Private Sub btnRecordStrobe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecordStrobe.Click
        SendDVCommand(VidGrab.TDVCommand.dv_RecordStrobe)
    End Sub

    Private Sub btnStepFwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStepFwd.Click
        SendDVCommand(VidGrab.TDVCommand.dv_StepFwd)
    End Sub

    Private Sub btnStepRev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStepRev.Click
        SendDVCommand(VidGrab.TDVCommand.dv_StepRev)
    End Sub

    Private Sub btnModeShuttle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModeShuttle.Click
        SendDVCommand(VidGrab.TDVCommand.dv_ModeShuttle)
    End Sub

    Private Sub btnPlayFastestFwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlayFastestFwd.Click
        SendDVCommand(VidGrab.TDVCommand.dv_PlayFastestFwd)
    End Sub

    Private Sub btnPlaySlowestFwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlaySlowestFwd.Click
        SendDVCommand(VidGrab.TDVCommand.dv_PlaySlowestFwd)
    End Sub

    Private Sub btnPlayFastestRev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlayFastestRev.Click
        SendDVCommand(VidGrab.TDVCommand.dv_PlayFastestRev)
    End Sub

    Private Sub btnPlaySlowestRev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlaySlowestRev.Click
        SendDVCommand(VidGrab.TDVCommand.dv_PlaySlowestRev)
    End Sub

    Private Sub miscDVCommands_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Visible Then
            RefreshControls()
        End If
    End Sub
End Class
