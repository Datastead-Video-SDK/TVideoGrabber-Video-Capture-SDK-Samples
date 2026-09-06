Option Strict Off
Option Explicit On 
Friend Class Audio
    Inherits Form

#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents chkMuteAudioRendering As System.Windows.Forms.CheckBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents grbAudioRendering As System.Windows.Forms.GroupBox
    Public WithEvents cboAudioDevices As System.Windows.Forms.ComboBox
    Public WithEvents cboAudioInputs As System.Windows.Forms.ComboBox
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents grbAudioCaptureDevice As System.Windows.Forms.GroupBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Public WithEvents tbrAudioVolume As System.Windows.Forms.TrackBar
    Public WithEvents tbrAudioBalance As System.Windows.Forms.TrackBar
    Public WithEvents tbrAudioInputLevel As System.Windows.Forms.TrackBar
    Public WithEvents tbrAudioInputBalance As System.Windows.Forms.TrackBar
    Friend WithEvents cboAudioRenderers As System.Windows.Forms.ComboBox
    Friend WithEvents grbVuMeters As System.Windows.Forms.GroupBox
    Friend WithEvents rdgVUDisabled As System.Windows.Forms.RadioButton
    Friend WithEvents rdgVUAnalog As System.Windows.Forms.RadioButton
    Friend WithEvents rdgVUBargraph As System.Windows.Forms.RadioButton
    Friend WithEvents pnlVUMeterLeft As System.Windows.Forms.Panel
    Friend WithEvents pnlVUMeterRight As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnStartAudioRendering As System.Windows.Forms.Button
    Friend WithEvents btnStartWavRecording As System.Windows.Forms.Button
    Friend WithEvents btnSartMP3Recording As System.Windows.Forms.Button
    Friend WithEvents btnStartWMVRecording As System.Windows.Forms.Button
    Friend WithEvents btnStopAudio As System.Windows.Forms.Button
    Friend WithEvents chkUseAudioOfVideoCaptureDevice As System.Windows.Forms.CheckBox
    Public WithEvents chkRenderAudioDevice As System.Windows.Forms.CheckBox
    Private WithEvents btnBargraphOverlay As System.Windows.Forms.Button
    Private WithEvents grbAudioSource As System.Windows.Forms.GroupBox
    Private WithEvents rdgAudioSourceDefaultSpeakerRecording As System.Windows.Forms.RadioButton
    Private WithEvents rdgAudioSourceSpeakerOutput As System.Windows.Forms.RadioButton
    Private WithEvents rdgAudioSourceExternal As System.Windows.Forms.RadioButton
    Private WithEvents rdgAudioSourceDefault As System.Windows.Forms.RadioButton
    Friend WithEvents btnAudioDeviceDialog As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grbAudioRendering = New System.Windows.Forms.GroupBox()
        Me.cboAudioRenderers = New System.Windows.Forms.ComboBox()
        Me.tbrAudioVolume = New System.Windows.Forms.TrackBar()
        Me.tbrAudioBalance = New System.Windows.Forms.TrackBar()
        Me.chkMuteAudioRendering = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grbAudioCaptureDevice = New System.Windows.Forms.GroupBox()
        Me.btnAudioDeviceDialog = New System.Windows.Forms.Button()
        Me.tbrAudioInputLevel = New System.Windows.Forms.TrackBar()
        Me.tbrAudioInputBalance = New System.Windows.Forms.TrackBar()
        Me.cboAudioDevices = New System.Windows.Forms.ComboBox()
        Me.cboAudioInputs = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.grbVuMeters = New System.Windows.Forms.GroupBox()
        Me.rdgVUBargraph = New System.Windows.Forms.RadioButton()
        Me.rdgVUAnalog = New System.Windows.Forms.RadioButton()
        Me.rdgVUDisabled = New System.Windows.Forms.RadioButton()
        Me.pnlVUMeterLeft = New System.Windows.Forms.Panel()
        Me.pnlVUMeterRight = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnStopAudio = New System.Windows.Forms.Button()
        Me.btnStartWMVRecording = New System.Windows.Forms.Button()
        Me.btnSartMP3Recording = New System.Windows.Forms.Button()
        Me.btnStartWavRecording = New System.Windows.Forms.Button()
        Me.btnStartAudioRendering = New System.Windows.Forms.Button()
        Me.chkUseAudioOfVideoCaptureDevice = New System.Windows.Forms.CheckBox()
        Me.chkRenderAudioDevice = New System.Windows.Forms.CheckBox()
        Me.btnBargraphOverlay = New System.Windows.Forms.Button()
        Me.grbAudioSource = New System.Windows.Forms.GroupBox()
        Me.rdgAudioSourceDefaultSpeakerRecording = New System.Windows.Forms.RadioButton()
        Me.rdgAudioSourceSpeakerOutput = New System.Windows.Forms.RadioButton()
        Me.rdgAudioSourceExternal = New System.Windows.Forms.RadioButton()
        Me.rdgAudioSourceDefault = New System.Windows.Forms.RadioButton()
        Me.grbAudioRendering.SuspendLayout()
        CType(Me.tbrAudioVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrAudioBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbAudioCaptureDevice.SuspendLayout()
        CType(Me.tbrAudioInputLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrAudioInputBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbVuMeters.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grbAudioSource.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbAudioRendering
        '
        Me.grbAudioRendering.BackColor = System.Drawing.SystemColors.Control
        Me.grbAudioRendering.Controls.Add(Me.cboAudioRenderers)
        Me.grbAudioRendering.Controls.Add(Me.tbrAudioVolume)
        Me.grbAudioRendering.Controls.Add(Me.tbrAudioBalance)
        Me.grbAudioRendering.Controls.Add(Me.chkMuteAudioRendering)
        Me.grbAudioRendering.Controls.Add(Me.Label5)
        Me.grbAudioRendering.Controls.Add(Me.Label6)
        Me.grbAudioRendering.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbAudioRendering.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbAudioRendering.Location = New System.Drawing.Point(763, 59)
        Me.grbAudioRendering.Name = "grbAudioRendering"
        Me.grbAudioRendering.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbAudioRendering.Size = New System.Drawing.Size(364, 156)
        Me.grbAudioRendering.TabIndex = 10
        Me.grbAudioRendering.TabStop = False
        Me.grbAudioRendering.Text = "audio rendering"
        '
        'cboAudioRenderers
        '
        Me.cboAudioRenderers.Location = New System.Drawing.Point(78, 18)
        Me.cboAudioRenderers.Name = "cboAudioRenderers"
        Me.cboAudioRenderers.Size = New System.Drawing.Size(242, 24)
        Me.cboAudioRenderers.TabIndex = 18
        Me.cboAudioRenderers.Text = "default (AudioRenderer = -1)"
        '
        'tbrAudioVolume
        '
        Me.tbrAudioVolume.AutoSize = False
        Me.tbrAudioVolume.Location = New System.Drawing.Point(14, 69)
        Me.tbrAudioVolume.Maximum = 65535
        Me.tbrAudioVolume.Name = "tbrAudioVolume"
        Me.tbrAudioVolume.Size = New System.Drawing.Size(306, 22)
        Me.tbrAudioVolume.TabIndex = 17
        Me.tbrAudioVolume.TickFrequency = 7300
        '
        'tbrAudioBalance
        '
        Me.tbrAudioBalance.AutoSize = False
        Me.tbrAudioBalance.Location = New System.Drawing.Point(14, 117)
        Me.tbrAudioBalance.Maximum = 32767
        Me.tbrAudioBalance.Minimum = -32768
        Me.tbrAudioBalance.Name = "tbrAudioBalance"
        Me.tbrAudioBalance.Size = New System.Drawing.Size(306, 22)
        Me.tbrAudioBalance.TabIndex = 17
        Me.tbrAudioBalance.TickFrequency = 7300
        '
        'chkMuteAudioRendering
        '
        Me.chkMuteAudioRendering.BackColor = System.Drawing.SystemColors.Control
        Me.chkMuteAudioRendering.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkMuteAudioRendering.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMuteAudioRendering.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkMuteAudioRendering.Location = New System.Drawing.Point(14, 21)
        Me.chkMuteAudioRendering.Name = "chkMuteAudioRendering"
        Me.chkMuteAudioRendering.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkMuteAudioRendering.Size = New System.Drawing.Size(80, 22)
        Me.chkMuteAudioRendering.TabIndex = 12
        Me.chkMuteAudioRendering.Text = "mute"
        Me.chkMuteAudioRendering.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(19, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(117, 21)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "volume"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(19, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(117, 21)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "balance"
        '
        'grbAudioCaptureDevice
        '
        Me.grbAudioCaptureDevice.BackColor = System.Drawing.SystemColors.Control
        Me.grbAudioCaptureDevice.Controls.Add(Me.btnAudioDeviceDialog)
        Me.grbAudioCaptureDevice.Controls.Add(Me.tbrAudioInputLevel)
        Me.grbAudioCaptureDevice.Controls.Add(Me.tbrAudioInputBalance)
        Me.grbAudioCaptureDevice.Controls.Add(Me.cboAudioDevices)
        Me.grbAudioCaptureDevice.Controls.Add(Me.cboAudioInputs)
        Me.grbAudioCaptureDevice.Controls.Add(Me.Label7)
        Me.grbAudioCaptureDevice.Controls.Add(Me.Label8)
        Me.grbAudioCaptureDevice.Controls.Add(Me.Label9)
        Me.grbAudioCaptureDevice.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbAudioCaptureDevice.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbAudioCaptureDevice.Location = New System.Drawing.Point(3, 104)
        Me.grbAudioCaptureDevice.Name = "grbAudioCaptureDevice"
        Me.grbAudioCaptureDevice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbAudioCaptureDevice.Size = New System.Drawing.Size(385, 111)
        Me.grbAudioCaptureDevice.TabIndex = 0
        Me.grbAudioCaptureDevice.TabStop = False
        Me.grbAudioCaptureDevice.Text = "Audio capture device (if default selected above)"
        '
        'btnAudioDeviceDialog
        '
        Me.btnAudioDeviceDialog.Location = New System.Drawing.Point(300, 18)
        Me.btnAudioDeviceDialog.Name = "btnAudioDeviceDialog"
        Me.btnAudioDeviceDialog.Size = New System.Drawing.Size(78, 28)
        Me.btnAudioDeviceDialog.TabIndex = 19
        Me.btnAudioDeviceDialog.Text = "dialog"
        '
        'tbrAudioInputLevel
        '
        Me.tbrAudioInputLevel.AutoSize = False
        Me.tbrAudioInputLevel.Location = New System.Drawing.Point(234, 51)
        Me.tbrAudioInputLevel.Maximum = 65535
        Me.tbrAudioInputLevel.Name = "tbrAudioInputLevel"
        Me.tbrAudioInputLevel.Size = New System.Drawing.Size(144, 23)
        Me.tbrAudioInputLevel.TabIndex = 17
        Me.tbrAudioInputLevel.TickFrequency = 7300
        '
        'tbrAudioInputBalance
        '
        Me.tbrAudioInputBalance.AutoSize = False
        Me.tbrAudioInputBalance.Location = New System.Drawing.Point(234, 81)
        Me.tbrAudioInputBalance.Maximum = 32767
        Me.tbrAudioInputBalance.Minimum = -32768
        Me.tbrAudioInputBalance.Name = "tbrAudioInputBalance"
        Me.tbrAudioInputBalance.Size = New System.Drawing.Size(144, 22)
        Me.tbrAudioInputBalance.TabIndex = 17
        Me.tbrAudioInputBalance.TickFrequency = 7300
        '
        'cboAudioDevices
        '
        Me.cboAudioDevices.BackColor = System.Drawing.SystemColors.Window
        Me.cboAudioDevices.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboAudioDevices.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAudioDevices.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboAudioDevices.Location = New System.Drawing.Point(3, 21)
        Me.cboAudioDevices.Name = "cboAudioDevices"
        Me.cboAudioDevices.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboAudioDevices.Size = New System.Drawing.Size(283, 24)
        Me.cboAudioDevices.TabIndex = 4
        Me.cboAudioDevices.Text = "SELECT AN AUDIO CAPTURE DEVICE IN THIS LIST"
        '
        'cboAudioInputs
        '
        Me.cboAudioInputs.BackColor = System.Drawing.SystemColors.Window
        Me.cboAudioInputs.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboAudioInputs.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAudioInputs.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboAudioInputs.Location = New System.Drawing.Point(3, 76)
        Me.cboAudioInputs.Name = "cboAudioInputs"
        Me.cboAudioInputs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboAudioInputs.Size = New System.Drawing.Size(153, 24)
        Me.cboAudioInputs.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(3, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(78, 21)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "audio input"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(169, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(60, 23)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "level"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(160, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(69, 22)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "balance"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'grbVuMeters
        '
        Me.grbVuMeters.Controls.Add(Me.rdgVUBargraph)
        Me.grbVuMeters.Controls.Add(Me.rdgVUAnalog)
        Me.grbVuMeters.Controls.Add(Me.rdgVUDisabled)
        Me.grbVuMeters.Location = New System.Drawing.Point(394, 66)
        Me.grbVuMeters.Name = "grbVuMeters"
        Me.grbVuMeters.Size = New System.Drawing.Size(240, 44)
        Me.grbVuMeters.TabIndex = 11
        Me.grbVuMeters.TabStop = False
        Me.grbVuMeters.Text = "VU-Meters"
        '
        'rdgVUBargraph
        '
        Me.rdgVUBargraph.Location = New System.Drawing.Point(154, 20)
        Me.rdgVUBargraph.Name = "rdgVUBargraph"
        Me.rdgVUBargraph.Size = New System.Drawing.Size(92, 22)
        Me.rdgVUBargraph.TabIndex = 2
        Me.rdgVUBargraph.Tag = "2"
        Me.rdgVUBargraph.Text = "bargraph"
        '
        'rdgVUAnalog
        '
        Me.rdgVUAnalog.Location = New System.Drawing.Point(89, 21)
        Me.rdgVUAnalog.Name = "rdgVUAnalog"
        Me.rdgVUAnalog.Size = New System.Drawing.Size(78, 22)
        Me.rdgVUAnalog.TabIndex = 1
        Me.rdgVUAnalog.Tag = "1"
        Me.rdgVUAnalog.Text = "analog"
        '
        'rdgVUDisabled
        '
        Me.rdgVUDisabled.Checked = True
        Me.rdgVUDisabled.Location = New System.Drawing.Point(7, 20)
        Me.rdgVUDisabled.Name = "rdgVUDisabled"
        Me.rdgVUDisabled.Size = New System.Drawing.Size(87, 22)
        Me.rdgVUDisabled.TabIndex = 0
        Me.rdgVUDisabled.TabStop = True
        Me.rdgVUDisabled.Tag = "0"
        Me.rdgVUDisabled.Text = "disabled"
        '
        'pnlVUMeterLeft
        '
        Me.pnlVUMeterLeft.AccessibleName = ""
        Me.pnlVUMeterLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlVUMeterLeft.Location = New System.Drawing.Point(394, 116)
        Me.pnlVUMeterLeft.Name = "pnlVUMeterLeft"
        Me.pnlVUMeterLeft.Size = New System.Drawing.Size(145, 99)
        Me.pnlVUMeterLeft.TabIndex = 12
        '
        'pnlVUMeterRight
        '
        Me.pnlVUMeterRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlVUMeterRight.Location = New System.Drawing.Point(547, 116)
        Me.pnlVUMeterRight.Name = "pnlVUMeterRight"
        Me.pnlVUMeterRight.Size = New System.Drawing.Size(145, 99)
        Me.pnlVUMeterRight.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnStopAudio)
        Me.GroupBox1.Controls.Add(Me.btnStartWMVRecording)
        Me.GroupBox1.Controls.Add(Me.btnSartMP3Recording)
        Me.GroupBox1.Controls.Add(Me.btnStartWavRecording)
        Me.GroupBox1.Controls.Add(Me.btnStartAudioRendering)
        Me.GroupBox1.Controls.Add(Me.chkUseAudioOfVideoCaptureDevice)
        Me.GroupBox1.Location = New System.Drawing.Point(398, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(729, 60)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "AUDIO rendering / recording / streaming ONLY  (you can activate the streaming in " &
    "the ""network streaming"" tab)"
        '
        'btnStopAudio
        '
        Me.btnStopAudio.Location = New System.Drawing.Point(420, 22)
        Me.btnStopAudio.Name = "btnStopAudio"
        Me.btnStopAudio.Size = New System.Drawing.Size(60, 30)
        Me.btnStopAudio.TabIndex = 4
        Me.btnStopAudio.Text = "stop"
        '
        'btnStartWMVRecording
        '
        Me.btnStartWMVRecording.Location = New System.Drawing.Point(317, 22)
        Me.btnStartWMVRecording.Name = "btnStartWMVRecording"
        Me.btnStartWMVRecording.Size = New System.Drawing.Size(96, 30)
        Me.btnStartWMVRecording.TabIndex = 3
        Me.btnStartWMVRecording.Text = "record WMV"
        '
        'btnSartMP3Recording
        '
        Me.btnSartMP3Recording.Location = New System.Drawing.Point(223, 22)
        Me.btnSartMP3Recording.Name = "btnSartMP3Recording"
        Me.btnSartMP3Recording.Size = New System.Drawing.Size(87, 30)
        Me.btnSartMP3Recording.TabIndex = 2
        Me.btnSartMP3Recording.Text = "record MP3"
        '
        'btnStartWavRecording
        '
        Me.btnStartWavRecording.Location = New System.Drawing.Point(120, 22)
        Me.btnStartWavRecording.Name = "btnStartWavRecording"
        Me.btnStartWavRecording.Size = New System.Drawing.Size(96, 30)
        Me.btnStartWavRecording.TabIndex = 1
        Me.btnStartWavRecording.Text = "record WAV"
        '
        'btnStartAudioRendering
        '
        Me.btnStartAudioRendering.Location = New System.Drawing.Point(7, 22)
        Me.btnStartAudioRendering.Name = "btnStartAudioRendering"
        Me.btnStartAudioRendering.Size = New System.Drawing.Size(106, 30)
        Me.btnStartAudioRendering.TabIndex = 0
        Me.btnStartAudioRendering.Text = "start rendering"
        '
        'chkUseAudioOfVideoCaptureDevice
        '
        Me.chkUseAudioOfVideoCaptureDevice.Location = New System.Drawing.Point(487, 15)
        Me.chkUseAudioOfVideoCaptureDevice.Name = "chkUseAudioOfVideoCaptureDevice"
        Me.chkUseAudioOfVideoCaptureDevice.Size = New System.Drawing.Size(198, 43)
        Me.chkUseAudioOfVideoCaptureDevice.TabIndex = 5
        Me.chkUseAudioOfVideoCaptureDevice.Text = "use the audio out of the video capture device, if any"
        '
        'chkRenderAudioDevice
        '
        Me.chkRenderAudioDevice.BackColor = System.Drawing.SystemColors.Control
        Me.chkRenderAudioDevice.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkRenderAudioDevice.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRenderAudioDevice.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkRenderAudioDevice.Location = New System.Drawing.Point(119, 0)
        Me.chkRenderAudioDevice.Name = "chkRenderAudioDevice"
        Me.chkRenderAudioDevice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkRenderAudioDevice.Size = New System.Drawing.Size(232, 22)
        Me.chkRenderAudioDevice.TabIndex = 19
        Me.chkRenderAudioDevice.Text = "AUDIO DEVICE RENDERING"
        Me.chkRenderAudioDevice.UseVisualStyleBackColor = False
        '
        'btnBargraphOverlay
        '
        Me.btnBargraphOverlay.Location = New System.Drawing.Point(647, 66)
        Me.btnBargraphOverlay.Name = "btnBargraphOverlay"
        Me.btnBargraphOverlay.Size = New System.Drawing.Size(114, 47)
        Me.btnBargraphOverlay.TabIndex = 31
        Me.btnBargraphOverlay.Text = "bargraph overlay"
        Me.btnBargraphOverlay.UseVisualStyleBackColor = True
        '
        'grbAudioSource
        '
        Me.grbAudioSource.Controls.Add(Me.rdgAudioSourceDefaultSpeakerRecording)
        Me.grbAudioSource.Controls.Add(Me.rdgAudioSourceSpeakerOutput)
        Me.grbAudioSource.Controls.Add(Me.rdgAudioSourceExternal)
        Me.grbAudioSource.Controls.Add(Me.rdgAudioSourceDefault)
        Me.grbAudioSource.Location = New System.Drawing.Point(3, 22)
        Me.grbAudioSource.Name = "grbAudioSource"
        Me.grbAudioSource.Size = New System.Drawing.Size(386, 74)
        Me.grbAudioSource.TabIndex = 32
        Me.grbAudioSource.TabStop = False
        Me.grbAudioSource.Text = "audio source"
        '
        'rdgAudioSourceDefaultSpeakerRecording
        '
        Me.rdgAudioSourceDefaultSpeakerRecording.AutoSize = True
        Me.rdgAudioSourceDefaultSpeakerRecording.Location = New System.Drawing.Point(95, 44)
        Me.rdgAudioSourceDefaultSpeakerRecording.Name = "rdgAudioSourceDefaultSpeakerRecording"
        Me.rdgAudioSourceDefaultSpeakerRecording.Size = New System.Drawing.Size(289, 20)
        Me.rdgAudioSourceDefaultSpeakerRecording.TabIndex = 3
        Me.rdgAudioSourceDefaultSpeakerRecording.Text = "default audio source + speaker recording"
        Me.rdgAudioSourceDefaultSpeakerRecording.UseVisualStyleBackColor = True
        '
        'rdgAudioSourceSpeakerOutput
        '
        Me.rdgAudioSourceSpeakerOutput.AutoSize = True
        Me.rdgAudioSourceSpeakerOutput.Location = New System.Drawing.Point(95, 21)
        Me.rdgAudioSourceSpeakerOutput.Name = "rdgAudioSourceSpeakerOutput"
        Me.rdgAudioSourceSpeakerOutput.Size = New System.Drawing.Size(124, 20)
        Me.rdgAudioSourceSpeakerOutput.TabIndex = 2
        Me.rdgAudioSourceSpeakerOutput.Text = "speaker output"
        Me.rdgAudioSourceSpeakerOutput.UseVisualStyleBackColor = True
        '
        'rdgAudioSourceExternal
        '
        Me.rdgAudioSourceExternal.AutoSize = True
        Me.rdgAudioSourceExternal.Location = New System.Drawing.Point(6, 44)
        Me.rdgAudioSourceExternal.Name = "rdgAudioSourceExternal"
        Me.rdgAudioSourceExternal.Size = New System.Drawing.Size(79, 20)
        Me.rdgAudioSourceExternal.TabIndex = 1
        Me.rdgAudioSourceExternal.Text = "external"
        Me.rdgAudioSourceExternal.UseVisualStyleBackColor = True
        '
        'rdgAudioSourceDefault
        '
        Me.rdgAudioSourceDefault.AutoSize = True
        Me.rdgAudioSourceDefault.Checked = True
        Me.rdgAudioSourceDefault.Location = New System.Drawing.Point(6, 21)
        Me.rdgAudioSourceDefault.Name = "rdgAudioSourceDefault"
        Me.rdgAudioSourceDefault.Size = New System.Drawing.Size(72, 20)
        Me.rdgAudioSourceDefault.TabIndex = 0
        Me.rdgAudioSourceDefault.TabStop = True
        Me.rdgAudioSourceDefault.Text = "default"
        Me.rdgAudioSourceDefault.UseVisualStyleBackColor = True
        '
        'Audio
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.ClientSize = New System.Drawing.Size(1198, 275)
        Me.ControlBox = False
        Me.Controls.Add(Me.grbAudioSource)
        Me.Controls.Add(Me.btnBargraphOverlay)
        Me.Controls.Add(Me.chkRenderAudioDevice)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pnlVUMeterRight)
        Me.Controls.Add(Me.pnlVUMeterLeft)
        Me.Controls.Add(Me.grbVuMeters)
        Me.Controls.Add(Me.grbAudioRendering)
        Me.Controls.Add(Me.grbAudioCaptureDevice)
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Audio"
        Me.ShowInTaskbar = False
        Me.grbAudioRendering.ResumeLayout(False)
        CType(Me.tbrAudioVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrAudioBalance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbAudioCaptureDevice.ResumeLayout(False)
        CType(Me.tbrAudioInputLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrAudioInputBalance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbVuMeters.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.grbAudioSource.ResumeLayout(False)
        Me.grbAudioSource.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public Sub RefreshControls()

        AssignListToComboBox(cboAudioDevices, MainForm.DefInstance.VideoGrabber1.AudioDevices, MainForm.DefInstance.VideoGrabber1.AudioDevice)

        If MainForm.DefInstance.VideoGrabber1.AudioDevice >= 0 Then ' if an audio capture device has been selected
            AssignListToComboBox(cboAudioInputs, MainForm.DefInstance.VideoGrabber1.AudioInputs, MainForm.DefInstance.VideoGrabber1.AudioInput)
        End If

        tbrAudioInputLevel.Value = MainForm.DefInstance.VideoGrabber1.AudioInputLevel
        tbrAudioInputBalance.Value = MainForm.DefInstance.VideoGrabber1.AudioInputBalance
        
        AssignListToComboBox(cboAudioRenderers, MainForm.DefInstance.VideoGrabber1.AudioRenderers, MainForm.DefInstance.VideoGrabber1.AudioRenderer)

        chkRenderAudioDevice.Checked = MainForm.DefInstance.VideoGrabber1.AudioDeviceRendering
        chkMuteAudioRendering.Checked = MainForm.DefInstance.VideoGrabber1.MuteAudioRendering

        If MainForm.DefInstance.VideoGrabber1.AudioDevice = -1 Then
            cboAudioDevices.Text = "SELECT AND AUDIO CAPTURE DEVICE IN THIS LIST"
        End If
        If MainForm.DefInstance.VideoGrabber1.AudioRenderer = -1 Then
            cboAudioRenderers.Text = "default (AudioRenderer = -1)"
        End If
    End Sub

    Private Sub cboAudioDevices_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAudioDevices.SelectedIndexChanged
        MainForm.DefInstance.VideoGrabber1.AudioDevice = cboAudioDevices.SelectedIndex
    End Sub

    Private Sub btnAudioDeviceDialog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAudioDeviceDialog.Click
        MainForm.DefInstance.VideoGrabber1.ShowDialog(VidGrab.TDialog.dlg_AudioDevice)
    End Sub

    Private Sub cboAudioInputs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAudioInputs.SelectedIndexChanged
        MainForm.DefInstance.VideoGrabber1.AudioInput = cboAudioInputs.SelectedIndex
    End Sub

    Private Sub chkRenderAudioDevice_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRenderAudioDevice.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.AudioDeviceRendering = chkRenderAudioDevice.Checked
    End Sub

    Private Sub chkMuteAudioRendering_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMuteAudioRendering.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.MuteAudioRendering = chkMuteAudioRendering.Checked
    End Sub

    Private Sub cboAudioRenderers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAudioRenderers.SelectedIndexChanged
        MainForm.DefInstance.VideoGrabber1.AudioRenderer = cboAudioRenderers.SelectedIndex
    End Sub

    Private Sub tbrAudioVolume_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrAudioVolume.Scroll
        MainForm.DefInstance.VideoGrabber1.AudioVolume = tbrAudioVolume.Value
    End Sub

    Private Sub tbrAudioInputLevel_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrAudioInputLevel.Scroll
        MainForm.DefInstance.VideoGrabber1.AudioInputLevel = tbrAudioInputLevel.Value
    End Sub

    Private Sub tbrAudioInputBalance_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrAudioInputBalance.Scroll
        MainForm.DefInstance.VideoGrabber1.AudioInputBalance = tbrAudioInputBalance.Value
    End Sub

    Private Sub tbrAudioBalance_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrAudioBalance.Scroll
        MainForm.DefInstance.VideoGrabber1.AudioBalance = tbrAudioBalance.Value
    End Sub

    Private Sub rdgVUMeters_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgVUDisabled.CheckedChanged, rdgVUAnalog.CheckedChanged, rdgVUBargraph.CheckedChanged
        Const VU_LEFT As Integer = 0
        Const VU_RIGHT As Integer = 1

        If CType(sender, RadioButton).Checked Then
            Select Case sender.Tag
                Case 0
                    MainForm.DefInstance.VideoGrabber1.VuMeter = VidGrab.TVuMeter.vu_Disabled
                    MainForm.DefInstance.VideoGrabber1.SetVUMeterSetting(VU_LEFT, VidGrab.TVUMeterSetting.vu_Handle, 0)
                    MainForm.DefInstance.VideoGrabber1.SetVUMeterSetting(VU_RIGHT, VidGrab.TVUMeterSetting.vu_Handle, 0)
                Case 1
                    MainForm.DefInstance.VideoGrabber1.VuMeter = VidGrab.TVuMeter.vu_Analog

                    pnlVUMeterLeft.Width = (pnlVUMeterLeft.Height * 4) / 3
                    pnlVUMeterRight.Width = (pnlVUMeterRight.Height * 4) / 3

                    MainForm.DefInstance.VideoGrabber1.SetVUMeterSetting(VU_LEFT, VidGrab.TVUMeterSetting.vu_BkgndColor, 0)
                    MainForm.DefInstance.VideoGrabber1.SetVUMeterSetting(VU_RIGHT, VidGrab.TVUMeterSetting.vu_BkgndColor, 0)
                    MainForm.DefInstance.VideoGrabber1.SetVUMeterSetting(VU_LEFT, VidGrab.TVUMeterSetting.vu_Handle, Convert.ToUInt32(pnlVUMeterLeft.Handle.ToInt32))
                    MainForm.DefInstance.VideoGrabber1.SetVUMeterSetting(VU_RIGHT, VidGrab.TVUMeterSetting.vu_Handle, Convert.ToUInt32(pnlVUMeterRight.Handle.ToInt32))
                Case 2
                    MainForm.DefInstance.VideoGrabber1.VuMeter = VidGrab.TVuMeter.vu_Bargraph

                    pnlVUMeterLeft.Width = (pnlVUMeterLeft.Height * 2) / 10
                    pnlVUMeterRight.Width = (pnlVUMeterRight.Height * 2) / 10

                    MainForm.DefInstance.VideoGrabber1.SetVUMeterSetting(VU_LEFT, VidGrab.TVUMeterSetting.vu_BkgndColor, &H404040)
                    MainForm.DefInstance.VideoGrabber1.SetVUMeterSetting(VU_RIGHT, VidGrab.TVUMeterSetting.vu_BkgndColor, &H404040)
                    MainForm.DefInstance.VideoGrabber1.SetVUMeterSetting(VU_LEFT, VidGrab.TVUMeterSetting.vu_Handle, Convert.ToUInt32(pnlVUMeterLeft.Handle.ToInt32))
                    MainForm.DefInstance.VideoGrabber1.SetVUMeterSetting(VU_RIGHT, VidGrab.TVUMeterSetting.vu_Handle, Convert.ToUInt32(pnlVUMeterRight.Handle.ToInt32))
            End Select
        End If
    End Sub

    Private Sub btnBargraphOverlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBargraphOverlay.Click

        MainForm.DefInstance.VideoGrabber1.SetVUMeterSetting(2, VidGrab.TVUMeterSetting.vu_OverlayLeft, Convert.ToUInt32(10))
        MainForm.DefInstance.VideoGrabber1.SetVUMeterSetting(3, VidGrab.TVUMeterSetting.vu_OverlayLeft, Convert.ToUInt32(140))

        For i As ULong = 2 To 3
            MainForm.DefInstance.VideoGrabber1.SetVuMeter_Enabled(Convert.ToInt32(i), VidGrab.TVuMeter.vu_BargraphOverlay)
            MainForm.DefInstance.VideoGrabber1.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_Transparent, Convert.ToUInt32(1))
            MainForm.DefInstance.VideoGrabber1.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_OverlayTop, Convert.ToUInt32(10))
            MainForm.DefInstance.VideoGrabber1.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_OverlayWidth, Convert.ToUInt32(100))
            MainForm.DefInstance.VideoGrabber1.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_OverlayHeight, Convert.ToUInt32(60))
            MainForm.DefInstance.VideoGrabber1.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_BkgndColor, Convert.ToUInt32(&H800000))
            MainForm.DefInstance.VideoGrabber1.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_NormalColor, Convert.ToUInt32(&H80))
            MainForm.DefInstance.VideoGrabber1.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_WarningColor, Convert.ToUInt32(&HA5FF))
            MainForm.DefInstance.VideoGrabber1.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_PeakColor, Convert.ToUInt32(&HFFFF))
            MainForm.DefInstance.VideoGrabber1.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_WarningPercent, Convert.ToUInt32(20))
            MainForm.DefInstance.VideoGrabber1.SetVUMeterSetting(i, VidGrab.TVUMeterSetting.vu_PeakPercent, Convert.ToUInt32(40))
        Next

    End Sub

    Private Sub btnStartAudioRendering_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartAudioRendering.Click
        MainForm.DefInstance.VideoGrabber1.StartAudioRendering()
        If Not MainForm.DefInstance.VideoGrabber1.AudioDeviceRendering Then
            If btnStartAudioRendering.Tag Is Nothing Then
                btnStartAudioRendering.Tag = 1 ' to show the popup only one time
                MsgBox("StartAudioRendering acts as 'preview', e.g. for the VU-Meters, if AudioDeviceRendering (on the left) is not enabled, the audio will not be heard in the speakers")
            End If
        End If
    End Sub

    Private Sub btnStartWavRecording_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartWavRecording.Click
        MainForm.DefInstance.VideoGrabber1.CompressionMode = VidGrab.TCompressionMode.cm_NoCompression
        MainForm.DefInstance.VideoGrabber1.RecordingMethod = VidGrab.TRecordingMethod.rm_AVI
        MainForm.DefInstance.VideoGrabber1.StartAudioRecording()
    End Sub

    Private Sub btnSartMP3Recording_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSartMP3Recording.Click
        MainForm.DefInstance.VideoGrabber1.CompressionMode = VidGrab.TCompressionMode.cm_CompressOnTheFly
        MainForm.DefInstance.VideoGrabber1.CompressionType = VidGrab.TCompressionType.ct_Audio
        MainForm.DefInstance.VideoGrabber1.RecordingMethod = VidGrab.TRecordingMethod.rm_AVI
        MainForm.DefInstance.VideoGrabber1.AudioCompressor = MainForm.DefInstance.VideoGrabber1.FindIndexInListByName(MainForm.DefInstance.VideoGrabber1.AudioCompressors, "LAME Audio Encoder", False, True)
        If MainForm.DefInstance.VideoGrabber1.AudioCompressor = -1 Then
            MsgBox("The LAME 3.99.5 DirectShow Filter is required, download it from https://www.rarewares.org/mp3-lame-dshow-acm.php and register lame.ax with regsvr32.exe")
        Else
            MainForm.DefInstance.VideoGrabber1.StartAudioRecording()
        End If
    End Sub

    Private Sub btnStartWMVRecording_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartWMVRecording.Click
        MainForm.DefInstance.VideoGrabber1.CompressionMode = VidGrab.TCompressionMode.cm_NoCompression
        MainForm.DefInstance.VideoGrabber1.RecordingMethod = VidGrab.TRecordingMethod.rm_ASF
        MainForm.DefInstance.VideoGrabber1.StartAudioRecording()
    End Sub

    Private Sub btnStopAudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopAudio.Click
        MainForm.DefInstance.VideoGrabber1.Stop()
    End Sub

    Private Sub chkUseAudioOfVideoCaptureDevice_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUseAudioOfVideoCaptureDevice.CheckedChanged
        If chkUseAudioOfVideoCaptureDevice.Checked Then
            MainForm.DefInstance.VideoGrabber1.VideoDevice = 0 ' in this demo, by default we choose the 1st
        Else
            MainForm.DefInstance.VideoGrabber1.VideoDevice = -1 ' this deactivates the video capture device
        End If
    End Sub

    Private Sub Audio_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Visible Then
            RefreshControls()
        End If
    End Sub

    Private Sub rdgAudioSourceDefault_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgAudioSourceDefault.CheckedChanged
        If rdgAudioSourceDefault.Checked Then
            MainForm.DefInstance.VideoGrabber1.AudioSource = VidGrab.TAudioSource.as_Default
        End If
    End Sub

    Private Sub rdgAudioSourceExternal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgAudioSourceExternal.CheckedChanged
        If rdgAudioSourceExternal.Checked Then
            MainForm.DefInstance.VideoGrabber1.AudioSource = VidGrab.TAudioSource.as_UseExternalAudio
        End If
    End Sub

    Private Sub rdgAudioSourceSpeakerOutput_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgAudioSourceSpeakerOutput.CheckedChanged
        If rdgAudioSourceSpeakerOutput.Checked Then
            MainForm.DefInstance.VideoGrabber1.AudioSource = VidGrab.TAudioSource.as_SpeakerOutput
        End If
    End Sub

    Private Sub rdgAudioSourceDefaultSpeakerRecording_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgAudioSourceDefaultSpeakerRecording.CheckedChanged
        If rdgAudioSourceDefaultSpeakerRecording.Checked Then
            MainForm.DefInstance.VideoGrabber1.AudioSource = VidGrab.TAudioSource.as_DefaultWithSpeakerRecording
        End If
    End Sub
End Class
