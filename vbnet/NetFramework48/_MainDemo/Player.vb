Option Strict Off
Option Explicit On
Friend Class Player
    Inherits Form

#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
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
    Public WithEvents btnChooseClip As System.Windows.Forms.Button
    Public WithEvents btnClipDuration As System.Windows.Forms.Button
    Public WithEvents btnPlayerOpenFile As System.Windows.Forms.Button
    Public WithEvents btnOpenLastClipRecorded As System.Windows.Forms.Button
    Public WithEvents btnOpenLastClipPlayed As System.Windows.Forms.Button
    Public WithEvents btnPlayerCloseFile As System.Windows.Forms.Button
    Public WithEvents btnPlayerOpenStreamingURL As System.Windows.Forms.Button
    Public WithEvents btnAutoPlay As System.Windows.Forms.CheckBox
    Public WithEvents chkPlayerAudioRendering As System.Windows.Forms.CheckBox
    Public WithEvents chkRefreshPausedDisplay As System.Windows.Forms.CheckBox
    Public WithEvents Label31 As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents updPlayerSpeedRatio As System.Windows.Forms.NumericUpDown
    Friend WithEvents updPlayerFastSeekSpeed As System.Windows.Forms.NumericUpDown
    Public WithEvents btnClipGeneralInfo As System.Windows.Forms.Button
    Public WithEvents btnHeaderInfo As System.Windows.Forms.Button
    Public WithEvents edtPlayerFileName As System.Windows.Forms.TextBox
    Friend WithEvents chkUseClock As System.Windows.Forms.CheckBox
    Friend WithEvents btnOpenDVD As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPlaylistAdd As System.Windows.Forms.Button
    Friend WithEvents btnPlaylistPlay As System.Windows.Forms.Button
    Friend WithEvents btnPlaylistNext As System.Windows.Forms.Button
    Friend WithEvents btnPlaylistPrevious As System.Windows.Forms.Button
    Friend WithEvents btnPlaylistStopAfterCurrent As System.Windows.Forms.Button
    Friend WithEvents btnPlaylistClose As System.Windows.Forms.Button
    Friend WithEvents chkPlaylistLoop As System.Windows.Forms.CheckBox
    Friend WithEvents chkPlaylistRandom As System.Windows.Forms.CheckBox
    Friend WithEvents lstPlaylist As System.Windows.Forms.ListBox
    Public WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents chkReopen As System.Windows.Forms.CheckBox
    Friend WithEvents chkKeepBounds As System.Windows.Forms.CheckBox
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents btnOpenAtFrames As System.Windows.Forms.Button
    Friend WithEvents btnOpenAtTimes As System.Windows.Forms.Button
    Friend WithEvents txtStopTime As System.Windows.Forms.TextBox
    Friend WithEvents txtStartTime As System.Windows.Forms.TextBox
    Friend WithEvents txtStopFrame As System.Windows.Forms.TextBox
    Friend WithEvents txtStartFrame As System.Windows.Forms.TextBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents updSpeedRadioValue As System.Windows.Forms.TextBox
    Private WithEvents rdgHwAccel_d3d11 As System.Windows.Forms.RadioButton
    Private WithEvents rdgHwAccel_DXVA2 As System.Windows.Forms.RadioButton
    Private WithEvents rdgHwAccel_QuickSync As System.Windows.Forms.RadioButton
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents rdgHwAccel_CUDA As System.Windows.Forms.RadioButton
    Private WithEvents rdgHwAccel_none As System.Windows.Forms.RadioButton
    Friend WithEvents chkLoop As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Player))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnChooseClip = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.edtPlayerFileName = New System.Windows.Forms.TextBox
        Me.btnClipDuration = New System.Windows.Forms.Button
        Me.btnPlayerOpenFile = New System.Windows.Forms.Button
        Me.btnOpenLastClipRecorded = New System.Windows.Forms.Button
        Me.btnOpenLastClipPlayed = New System.Windows.Forms.Button
        Me.btnPlayerCloseFile = New System.Windows.Forms.Button
        Me.btnPlayerOpenStreamingURL = New System.Windows.Forms.Button
        Me.btnAutoPlay = New System.Windows.Forms.CheckBox
        Me.chkPlayerAudioRendering = New System.Windows.Forms.CheckBox
        Me.chkRefreshPausedDisplay = New System.Windows.Forms.CheckBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.updPlayerSpeedRatio = New System.Windows.Forms.NumericUpDown
        Me.updPlayerFastSeekSpeed = New System.Windows.Forms.NumericUpDown
        Me.btnClipGeneralInfo = New System.Windows.Forms.Button
        Me.btnHeaderInfo = New System.Windows.Forms.Button
        Me.chkUseClock = New System.Windows.Forms.CheckBox
        Me.btnOpenDVD = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lstPlaylist = New System.Windows.Forms.ListBox
        Me.chkPlaylistRandom = New System.Windows.Forms.CheckBox
        Me.chkPlaylistLoop = New System.Windows.Forms.CheckBox
        Me.btnPlaylistClose = New System.Windows.Forms.Button
        Me.btnPlaylistStopAfterCurrent = New System.Windows.Forms.Button
        Me.btnPlaylistPrevious = New System.Windows.Forms.Button
        Me.btnPlaylistNext = New System.Windows.Forms.Button
        Me.btnPlaylistPlay = New System.Windows.Forms.Button
        Me.btnPlaylistAdd = New System.Windows.Forms.Button
        Me.Label30 = New System.Windows.Forms.Label
        Me.chkReopen = New System.Windows.Forms.CheckBox
        Me.chkKeepBounds = New System.Windows.Forms.CheckBox
        Me.label3 = New System.Windows.Forms.Label
        Me.btnOpenAtFrames = New System.Windows.Forms.Button
        Me.btnOpenAtTimes = New System.Windows.Forms.Button
        Me.txtStopTime = New System.Windows.Forms.TextBox
        Me.txtStartTime = New System.Windows.Forms.TextBox
        Me.txtStopFrame = New System.Windows.Forms.TextBox
        Me.txtStartFrame = New System.Windows.Forms.TextBox
        Me.label2 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.chkLoop = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.updSpeedRadioValue = New System.Windows.Forms.TextBox
        Me.rdgHwAccel_d3d11 = New System.Windows.Forms.RadioButton
        Me.rdgHwAccel_DXVA2 = New System.Windows.Forms.RadioButton
        Me.rdgHwAccel_QuickSync = New System.Windows.Forms.RadioButton
        Me.groupBox2 = New System.Windows.Forms.GroupBox
        Me.rdgHwAccel_CUDA = New System.Windows.Forms.RadioButton
        Me.rdgHwAccel_none = New System.Windows.Forms.RadioButton
        CType(Me.updPlayerSpeedRatio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updPlayerFastSeekSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnChooseClip
        '
        Me.btnChooseClip.BackColor = System.Drawing.SystemColors.Control
        Me.btnChooseClip.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnChooseClip.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseClip.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnChooseClip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChooseClip.ImageIndex = 0
        Me.btnChooseClip.ImageList = Me.ImageList1
        Me.btnChooseClip.Location = New System.Drawing.Point(14, 20)
        Me.btnChooseClip.Name = "btnChooseClip"
        Me.btnChooseClip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnChooseClip.Size = New System.Drawing.Size(129, 27)
        Me.btnChooseClip.TabIndex = 29
        Me.btnChooseClip.Text = "select a clip..."
        Me.btnChooseClip.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnChooseClip.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Fuchsia
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'edtPlayerFileName
        '
        Me.edtPlayerFileName.AcceptsReturn = True
        Me.edtPlayerFileName.BackColor = System.Drawing.SystemColors.Window
        Me.edtPlayerFileName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtPlayerFileName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtPlayerFileName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtPlayerFileName.Location = New System.Drawing.Point(150, 20)
        Me.edtPlayerFileName.MaxLength = 0
        Me.edtPlayerFileName.Name = "edtPlayerFileName"
        Me.edtPlayerFileName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtPlayerFileName.Size = New System.Drawing.Size(337, 23)
        Me.edtPlayerFileName.TabIndex = 28
        Me.edtPlayerFileName.Text = "Choose a video or audio clip..."
        '
        'btnClipDuration
        '
        Me.btnClipDuration.BackColor = System.Drawing.SystemColors.Control
        Me.btnClipDuration.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnClipDuration.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClipDuration.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClipDuration.Location = New System.Drawing.Point(564, 52)
        Me.btnClipDuration.Name = "btnClipDuration"
        Me.btnClipDuration.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClipDuration.Size = New System.Drawing.Size(76, 26)
        Me.btnClipDuration.TabIndex = 27
        Me.btnClipDuration.Text = "duration?"
        Me.btnClipDuration.UseVisualStyleBackColor = False
        '
        'btnPlayerOpenFile
        '
        Me.btnPlayerOpenFile.BackColor = System.Drawing.SystemColors.Control
        Me.btnPlayerOpenFile.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnPlayerOpenFile.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayerOpenFile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPlayerOpenFile.Location = New System.Drawing.Point(494, 20)
        Me.btnPlayerOpenFile.Name = "btnPlayerOpenFile"
        Me.btnPlayerOpenFile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPlayerOpenFile.Size = New System.Drawing.Size(69, 27)
        Me.btnPlayerOpenFile.TabIndex = 14
        Me.btnPlayerOpenFile.Text = "Open"
        Me.btnPlayerOpenFile.UseVisualStyleBackColor = False
        '
        'btnOpenLastClipRecorded
        '
        Me.btnOpenLastClipRecorded.BackColor = System.Drawing.SystemColors.Control
        Me.btnOpenLastClipRecorded.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnOpenLastClipRecorded.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenLastClipRecorded.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnOpenLastClipRecorded.Location = New System.Drawing.Point(227, 52)
        Me.btnOpenLastClipRecorded.Name = "btnOpenLastClipRecorded"
        Me.btnOpenLastClipRecorded.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnOpenLastClipRecorded.Size = New System.Drawing.Size(126, 26)
        Me.btnOpenLastClipRecorded.TabIndex = 13
        Me.btnOpenLastClipRecorded.Text = "Last clip recorded"
        Me.btnOpenLastClipRecorded.UseVisualStyleBackColor = False
        '
        'btnOpenLastClipPlayed
        '
        Me.btnOpenLastClipPlayed.BackColor = System.Drawing.SystemColors.Control
        Me.btnOpenLastClipPlayed.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnOpenLastClipPlayed.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenLastClipPlayed.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnOpenLastClipPlayed.Location = New System.Drawing.Point(109, 52)
        Me.btnOpenLastClipPlayed.Name = "btnOpenLastClipPlayed"
        Me.btnOpenLastClipPlayed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnOpenLastClipPlayed.Size = New System.Drawing.Size(112, 26)
        Me.btnOpenLastClipPlayed.TabIndex = 12
        Me.btnOpenLastClipPlayed.Text = "Last clip played"
        Me.btnOpenLastClipPlayed.UseVisualStyleBackColor = False
        '
        'btnPlayerCloseFile
        '
        Me.btnPlayerCloseFile.BackColor = System.Drawing.SystemColors.Control
        Me.btnPlayerCloseFile.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnPlayerCloseFile.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayerCloseFile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPlayerCloseFile.Location = New System.Drawing.Point(571, 20)
        Me.btnPlayerCloseFile.Name = "btnPlayerCloseFile"
        Me.btnPlayerCloseFile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPlayerCloseFile.Size = New System.Drawing.Size(69, 27)
        Me.btnPlayerCloseFile.TabIndex = 11
        Me.btnPlayerCloseFile.Text = "Close"
        Me.btnPlayerCloseFile.UseVisualStyleBackColor = False
        '
        'btnPlayerOpenStreamingURL
        '
        Me.btnPlayerOpenStreamingURL.BackColor = System.Drawing.SystemColors.Control
        Me.btnPlayerOpenStreamingURL.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnPlayerOpenStreamingURL.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayerOpenStreamingURL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPlayerOpenStreamingURL.Location = New System.Drawing.Point(14, 52)
        Me.btnPlayerOpenStreamingURL.Name = "btnPlayerOpenStreamingURL"
        Me.btnPlayerOpenStreamingURL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPlayerOpenStreamingURL.Size = New System.Drawing.Size(88, 26)
        Me.btnPlayerOpenStreamingURL.TabIndex = 10
        Me.btnPlayerOpenStreamingURL.Text = "demo URL?"
        Me.btnPlayerOpenStreamingURL.UseVisualStyleBackColor = False
        '
        'btnAutoPlay
        '
        Me.btnAutoPlay.BackColor = System.Drawing.SystemColors.Control
        Me.btnAutoPlay.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAutoPlay.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAutoPlay.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAutoPlay.Location = New System.Drawing.Point(206, 82)
        Me.btnAutoPlay.Name = "btnAutoPlay"
        Me.btnAutoPlay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAutoPlay.Size = New System.Drawing.Size(135, 21)
        Me.btnAutoPlay.TabIndex = 7
        Me.btnAutoPlay.Text = "auto start playing"
        Me.btnAutoPlay.UseVisualStyleBackColor = False
        '
        'chkPlayerAudioRendering
        '
        Me.chkPlayerAudioRendering.BackColor = System.Drawing.SystemColors.Control
        Me.chkPlayerAudioRendering.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkPlayerAudioRendering.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPlayerAudioRendering.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkPlayerAudioRendering.Location = New System.Drawing.Point(5, 82)
        Me.chkPlayerAudioRendering.Name = "chkPlayerAudioRendering"
        Me.chkPlayerAudioRendering.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkPlayerAudioRendering.Size = New System.Drawing.Size(162, 21)
        Me.chkPlayerAudioRendering.TabIndex = 6
        Me.chkPlayerAudioRendering.Text = "render player audio"
        Me.chkPlayerAudioRendering.UseVisualStyleBackColor = False
        '
        'chkRefreshPausedDisplay
        '
        Me.chkRefreshPausedDisplay.BackColor = System.Drawing.SystemColors.Control
        Me.chkRefreshPausedDisplay.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkRefreshPausedDisplay.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRefreshPausedDisplay.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkRefreshPausedDisplay.Location = New System.Drawing.Point(5, 201)
        Me.chkRefreshPausedDisplay.Name = "chkRefreshPausedDisplay"
        Me.chkRefreshPausedDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkRefreshPausedDisplay.Size = New System.Drawing.Size(627, 21)
        Me.chkRefreshPausedDisplay.TabIndex = 5
        Me.chkRefreshPausedDisplay.Text = "refresh periodically paused display when the frame grabber is enabled (e.g. to ap" & _
            "ply graphic overlays)"
        Me.chkRefreshPausedDisplay.UseVisualStyleBackColor = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.SystemColors.Control
        Me.Label31.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label31.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label31.Location = New System.Drawing.Point(55, 170)
        Me.Label31.Name = "Label31"
        Me.Label31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label31.Size = New System.Drawing.Size(144, 16)
        Me.Label31.TabIndex = 15
        Me.Label31.Text = "ff / rewind speed ratio"
        '
        'updPlayerSpeedRatio
        '
        Me.updPlayerSpeedRatio.BackColor = System.Drawing.Color.Silver
        Me.updPlayerSpeedRatio.Location = New System.Drawing.Point(35, 135)
        Me.updPlayerSpeedRatio.Name = "updPlayerSpeedRatio"
        Me.updPlayerSpeedRatio.Size = New System.Drawing.Size(20, 23)
        Me.updPlayerSpeedRatio.TabIndex = 30
        Me.updPlayerSpeedRatio.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'updPlayerFastSeekSpeed
        '
        Me.updPlayerFastSeekSpeed.BackColor = System.Drawing.Color.Silver
        Me.updPlayerFastSeekSpeed.Location = New System.Drawing.Point(5, 167)
        Me.updPlayerFastSeekSpeed.Name = "updPlayerFastSeekSpeed"
        Me.updPlayerFastSeekSpeed.Size = New System.Drawing.Size(50, 23)
        Me.updPlayerFastSeekSpeed.TabIndex = 31
        Me.updPlayerFastSeekSpeed.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnClipGeneralInfo
        '
        Me.btnClipGeneralInfo.BackColor = System.Drawing.SystemColors.Control
        Me.btnClipGeneralInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnClipGeneralInfo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClipGeneralInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClipGeneralInfo.Location = New System.Drawing.Point(360, 52)
        Me.btnClipGeneralInfo.Name = "btnClipGeneralInfo"
        Me.btnClipGeneralInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClipGeneralInfo.Size = New System.Drawing.Size(96, 26)
        Me.btnClipGeneralInfo.TabIndex = 32
        Me.btnClipGeneralInfo.Text = "general info?"
        Me.btnClipGeneralInfo.UseVisualStyleBackColor = False
        '
        'btnHeaderInfo
        '
        Me.btnHeaderInfo.BackColor = System.Drawing.SystemColors.Control
        Me.btnHeaderInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnHeaderInfo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHeaderInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnHeaderInfo.Location = New System.Drawing.Point(463, 52)
        Me.btnHeaderInfo.Name = "btnHeaderInfo"
        Me.btnHeaderInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnHeaderInfo.Size = New System.Drawing.Size(94, 26)
        Me.btnHeaderInfo.TabIndex = 33
        Me.btnHeaderInfo.Text = "header info?"
        Me.btnHeaderInfo.UseVisualStyleBackColor = False
        '
        'chkUseClock
        '
        Me.chkUseClock.Location = New System.Drawing.Point(206, 103)
        Me.chkUseClock.Name = "chkUseClock"
        Me.chkUseClock.Size = New System.Drawing.Size(87, 20)
        Me.chkUseClock.TabIndex = 34
        Me.chkUseClock.Text = "use clock"
        '
        'btnOpenDVD
        '
        Me.btnOpenDVD.Location = New System.Drawing.Point(362, 82)
        Me.btnOpenDVD.Name = "btnOpenDVD"
        Me.btnOpenDVD.Size = New System.Drawing.Size(125, 26)
        Me.btnOpenDVD.TabIndex = 35
        Me.btnOpenDVD.Text = "Open DVD"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstPlaylist)
        Me.GroupBox1.Controls.Add(Me.chkPlaylistRandom)
        Me.GroupBox1.Controls.Add(Me.chkPlaylistLoop)
        Me.GroupBox1.Controls.Add(Me.btnPlaylistClose)
        Me.GroupBox1.Controls.Add(Me.btnPlaylistStopAfterCurrent)
        Me.GroupBox1.Controls.Add(Me.btnPlaylistPrevious)
        Me.GroupBox1.Controls.Add(Me.btnPlaylistNext)
        Me.GroupBox1.Controls.Add(Me.btnPlaylistPlay)
        Me.GroupBox1.Controls.Add(Me.btnPlaylistAdd)
        Me.GroupBox1.Location = New System.Drawing.Point(648, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 144)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Playlist"
        '
        'lstPlaylist
        '
        Me.lstPlaylist.ItemHeight = 16
        Me.lstPlaylist.Location = New System.Drawing.Point(90, 57)
        Me.lstPlaylist.Name = "lstPlaylist"
        Me.lstPlaylist.Size = New System.Drawing.Size(344, 84)
        Me.lstPlaylist.TabIndex = 8
        '
        'chkPlaylistRandom
        '
        Me.chkPlaylistRandom.Location = New System.Drawing.Point(10, 86)
        Me.chkPlaylistRandom.Name = "chkPlaylistRandom"
        Me.chkPlaylistRandom.Size = New System.Drawing.Size(86, 20)
        Me.chkPlaylistRandom.TabIndex = 7
        Me.chkPlaylistRandom.Text = "Random"
        '
        'chkPlaylistLoop
        '
        Me.chkPlaylistLoop.Location = New System.Drawing.Point(10, 57)
        Me.chkPlaylistLoop.Name = "chkPlaylistLoop"
        Me.chkPlaylistLoop.Size = New System.Drawing.Size(67, 19)
        Me.chkPlaylistLoop.TabIndex = 6
        Me.chkPlaylistLoop.Text = "Loop"
        '
        'btnPlaylistClose
        '
        Me.btnPlaylistClose.Location = New System.Drawing.Point(383, 18)
        Me.btnPlaylistClose.Name = "btnPlaylistClose"
        Me.btnPlaylistClose.Size = New System.Drawing.Size(51, 29)
        Me.btnPlaylistClose.TabIndex = 5
        Me.btnPlaylistClose.Text = "Close"
        '
        'btnPlaylistStopAfterCurrent
        '
        Me.btnPlaylistStopAfterCurrent.Location = New System.Drawing.Point(256, 18)
        Me.btnPlaylistStopAfterCurrent.Name = "btnPlaylistStopAfterCurrent"
        Me.btnPlaylistStopAfterCurrent.Size = New System.Drawing.Size(122, 30)
        Me.btnPlaylistStopAfterCurrent.TabIndex = 4
        Me.btnPlaylistStopAfterCurrent.Text = "Stop after current"
        '
        'btnPlaylistPrevious
        '
        Me.btnPlaylistPrevious.Location = New System.Drawing.Point(178, 18)
        Me.btnPlaylistPrevious.Name = "btnPlaylistPrevious"
        Me.btnPlaylistPrevious.Size = New System.Drawing.Size(73, 30)
        Me.btnPlaylistPrevious.TabIndex = 3
        Me.btnPlaylistPrevious.Text = "Previous"
        '
        'btnPlaylistNext
        '
        Me.btnPlaylistNext.Location = New System.Drawing.Point(125, 18)
        Me.btnPlaylistNext.Name = "btnPlaylistNext"
        Me.btnPlaylistNext.Size = New System.Drawing.Size(48, 30)
        Me.btnPlaylistNext.TabIndex = 2
        Me.btnPlaylistNext.Text = "Next"
        '
        'btnPlaylistPlay
        '
        Me.btnPlaylistPlay.Location = New System.Drawing.Point(72, 18)
        Me.btnPlaylistPlay.Name = "btnPlaylistPlay"
        Me.btnPlaylistPlay.Size = New System.Drawing.Size(48, 30)
        Me.btnPlaylistPlay.TabIndex = 1
        Me.btnPlaylistPlay.Text = "Play"
        '
        'btnPlaylistAdd
        '
        Me.btnPlaylistAdd.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlaylistAdd.Location = New System.Drawing.Point(10, 20)
        Me.btnPlaylistAdd.Name = "btnPlaylistAdd"
        Me.btnPlaylistAdd.Size = New System.Drawing.Size(57, 28)
        Me.btnPlaylistAdd.TabIndex = 0
        Me.btnPlaylistAdd.Text = "Add..."
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.SystemColors.Control
        Me.Label30.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label30.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label30.Location = New System.Drawing.Point(55, 138)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label30.Size = New System.Drawing.Size(156, 16)
        Me.Label30.TabIndex = 50
        Me.Label30.Text = "normal play speed ratio"
        '
        'chkReopen
        '
        Me.chkReopen.Location = New System.Drawing.Point(511, 161)
        Me.chkReopen.Name = "chkReopen"
        Me.chkReopen.Size = New System.Drawing.Size(139, 22)
        Me.chkReopen.TabIndex = 92
        Me.chkReopen.Text = "reopen (if opened)"
        '
        'chkKeepBounds
        '
        Me.chkKeepBounds.Checked = True
        Me.chkKeepBounds.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkKeepBounds.Location = New System.Drawing.Point(511, 132)
        Me.chkKeepBounds.Name = "chkKeepBounds"
        Me.chkKeepBounds.Size = New System.Drawing.Size(125, 22)
        Me.chkKeepBounds.TabIndex = 91
        Me.chkKeepBounds.Text = "keep bounds"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.ForeColor = System.Drawing.Color.Gray
        Me.label3.Location = New System.Drawing.Point(203, 182)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(411, 16)
        Me.label3.TabIndex = 89
        Me.label3.Text = "(times are expressed in 100ns units e.g. 3 seconds - 30000000)"
        '
        'btnOpenAtFrames
        '
        Me.btnOpenAtFrames.Location = New System.Drawing.Point(206, 128)
        Me.btnOpenAtFrames.Name = "btnOpenAtFrames"
        Me.btnOpenAtFrames.Size = New System.Drawing.Size(122, 25)
        Me.btnOpenAtFrames.TabIndex = 88
        Me.btnOpenAtFrames.Text = "open at frames ->"
        '
        'btnOpenAtTimes
        '
        Me.btnOpenAtTimes.Location = New System.Drawing.Point(206, 158)
        Me.btnOpenAtTimes.Name = "btnOpenAtTimes"
        Me.btnOpenAtTimes.Size = New System.Drawing.Size(122, 24)
        Me.btnOpenAtTimes.TabIndex = 87
        Me.btnOpenAtTimes.Text = "open at times ->"
        '
        'txtStopTime
        '
        Me.txtStopTime.Location = New System.Drawing.Point(421, 158)
        Me.txtStopTime.Name = "txtStopTime"
        Me.txtStopTime.Size = New System.Drawing.Size(85, 23)
        Me.txtStopTime.TabIndex = 86
        '
        'txtStartTime
        '
        Me.txtStartTime.Location = New System.Drawing.Point(331, 158)
        Me.txtStartTime.Name = "txtStartTime"
        Me.txtStartTime.Size = New System.Drawing.Size(85, 23)
        Me.txtStartTime.TabIndex = 85
        '
        'txtStopFrame
        '
        Me.txtStopFrame.Location = New System.Drawing.Point(421, 128)
        Me.txtStopFrame.Name = "txtStopFrame"
        Me.txtStopFrame.Size = New System.Drawing.Size(85, 23)
        Me.txtStopFrame.TabIndex = 84
        '
        'txtStartFrame
        '
        Me.txtStartFrame.Location = New System.Drawing.Point(331, 128)
        Me.txtStartFrame.Name = "txtStartFrame"
        Me.txtStartFrame.Size = New System.Drawing.Size(85, 23)
        Me.txtStartFrame.TabIndex = 83
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(421, 111)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(211, 17)
        Me.label2.TabIndex = 94
        Me.label2.Text = "stop (*)                  (* default = -1)"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(331, 111)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(58, 17)
        Me.label1.TabIndex = 93
        Me.label1.Text = "start (*)"
        '
        'chkLoop
        '
        Me.chkLoop.Location = New System.Drawing.Point(5, 103)
        Me.chkLoop.Name = "chkLoop"
        Me.chkLoop.Size = New System.Drawing.Size(173, 20)
        Me.chkLoop.TabIndex = 95
        Me.chkLoop.Text = "loop (repeat indefinitely)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 16)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "Player functions"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(157, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(922, 15)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "to use only the player, disable the live video and audio capture devices by setii" & _
            "ng VideoDevice = -1 and AudioDevice = -1 (""video source"" and ""audio"")"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(494, 81)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 26)
        Me.Button1.TabIndex = 98
        Me.Button1.Text = "current DVD info ?"
        '
        'updSpeedRadioValue
        '
        Me.updSpeedRadioValue.BackColor = System.Drawing.Color.Silver
        Me.updSpeedRadioValue.Location = New System.Drawing.Point(5, 134)
        Me.updSpeedRadioValue.Name = "updSpeedRadioValue"
        Me.updSpeedRadioValue.Size = New System.Drawing.Size(30, 23)
        Me.updSpeedRadioValue.TabIndex = 135
        '
        'rdgHwAccel_d3d11
        '
        Me.rdgHwAccel_d3d11.AutoSize = True
        Me.rdgHwAccel_d3d11.Location = New System.Drawing.Point(362, 22)
        Me.rdgHwAccel_d3d11.Name = "rdgHwAccel_d3d11"
        Me.rdgHwAccel_d3d11.Size = New System.Drawing.Size(68, 20)
        Me.rdgHwAccel_d3d11.TabIndex = 4
        Me.rdgHwAccel_d3d11.Text = "d3d11"
        Me.rdgHwAccel_d3d11.UseVisualStyleBackColor = True
        '
        'rdgHwAccel_DXVA2
        '
        Me.rdgHwAccel_DXVA2.AutoSize = True
        Me.rdgHwAccel_DXVA2.Location = New System.Drawing.Point(267, 22)
        Me.rdgHwAccel_DXVA2.Name = "rdgHwAccel_DXVA2"
        Me.rdgHwAccel_DXVA2.Size = New System.Drawing.Size(72, 20)
        Me.rdgHwAccel_DXVA2.TabIndex = 3
        Me.rdgHwAccel_DXVA2.Text = "DXVA2"
        Me.rdgHwAccel_DXVA2.UseVisualStyleBackColor = True
        '
        'rdgHwAccel_QuickSync
        '
        Me.rdgHwAccel_QuickSync.AutoSize = True
        Me.rdgHwAccel_QuickSync.Location = New System.Drawing.Point(155, 22)
        Me.rdgHwAccel_QuickSync.Name = "rdgHwAccel_QuickSync"
        Me.rdgHwAccel_QuickSync.Size = New System.Drawing.Size(96, 20)
        Me.rdgHwAccel_QuickSync.TabIndex = 2
        Me.rdgHwAccel_QuickSync.Text = "QuickSync"
        Me.rdgHwAccel_QuickSync.UseVisualStyleBackColor = True
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.rdgHwAccel_d3d11)
        Me.groupBox2.Controls.Add(Me.rdgHwAccel_DXVA2)
        Me.groupBox2.Controls.Add(Me.rdgHwAccel_QuickSync)
        Me.groupBox2.Controls.Add(Me.rdgHwAccel_CUDA)
        Me.groupBox2.Controls.Add(Me.rdgHwAccel_none)
        Me.groupBox2.Location = New System.Drawing.Point(649, 167)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(442, 54)
        Me.groupBox2.TabIndex = 136
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Hardware acceleration of video decoding"
        '
        'rdgHwAccel_CUDA
        '
        Me.rdgHwAccel_CUDA.AutoSize = True
        Me.rdgHwAccel_CUDA.Location = New System.Drawing.Point(73, 22)
        Me.rdgHwAccel_CUDA.Name = "rdgHwAccel_CUDA"
        Me.rdgHwAccel_CUDA.Size = New System.Drawing.Size(67, 20)
        Me.rdgHwAccel_CUDA.TabIndex = 1
        Me.rdgHwAccel_CUDA.Text = "CUDA"
        Me.rdgHwAccel_CUDA.UseVisualStyleBackColor = True
        '
        'rdgHwAccel_none
        '
        Me.rdgHwAccel_none.AutoSize = True
        Me.rdgHwAccel_none.Checked = True
        Me.rdgHwAccel_none.Location = New System.Drawing.Point(6, 22)
        Me.rdgHwAccel_none.Name = "rdgHwAccel_none"
        Me.rdgHwAccel_none.Size = New System.Drawing.Size(61, 20)
        Me.rdgHwAccel_none.TabIndex = 0
        Me.rdgHwAccel_none.TabStop = True
        Me.rdgHwAccel_none.Text = "none"
        Me.rdgHwAccel_none.UseVisualStyleBackColor = True
        '
        'Player
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.ClientSize = New System.Drawing.Size(1151, 233)
        Me.ControlBox = False
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.updSpeedRadioValue)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnChooseClip)
        Me.Controls.Add(Me.btnOpenAtFrames)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chkLoop)
        Me.Controls.Add(Me.chkReopen)
        Me.Controls.Add(Me.chkKeepBounds)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.btnOpenAtTimes)
        Me.Controls.Add(Me.txtStopTime)
        Me.Controls.Add(Me.txtStartTime)
        Me.Controls.Add(Me.txtStopFrame)
        Me.Controls.Add(Me.txtStartFrame)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.btnOpenDVD)
        Me.Controls.Add(Me.chkUseClock)
        Me.Controls.Add(Me.btnHeaderInfo)
        Me.Controls.Add(Me.btnClipGeneralInfo)
        Me.Controls.Add(Me.updPlayerFastSeekSpeed)
        Me.Controls.Add(Me.updPlayerSpeedRatio)
        Me.Controls.Add(Me.edtPlayerFileName)
        Me.Controls.Add(Me.btnClipDuration)
        Me.Controls.Add(Me.btnPlayerOpenFile)
        Me.Controls.Add(Me.btnOpenLastClipRecorded)
        Me.Controls.Add(Me.btnOpenLastClipPlayed)
        Me.Controls.Add(Me.btnPlayerCloseFile)
        Me.Controls.Add(Me.btnPlayerOpenStreamingURL)
        Me.Controls.Add(Me.btnAutoPlay)
        Me.Controls.Add(Me.chkPlayerAudioRendering)
        Me.Controls.Add(Me.chkRefreshPausedDisplay)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Player"
        Me.ShowInTaskbar = False
        CType(Me.updPlayerSpeedRatio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updPlayerFastSeekSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Public Sub RefreshControls()
        updPlayerSpeedRatio.Value = MainForm.DefInstance.VideoGrabber1.PlayerSpeedRatio * 10
        updPlayerFastSeekSpeed.Value = MainForm.DefInstance.VideoGrabber1.PlayerFastSeekSpeedRatio
        btnAutoPlay.Checked = MainForm.DefInstance.VideoGrabber1.AutoStartPlayer
        chkPlayerAudioRendering.Checked = MainForm.DefInstance.VideoGrabber1.PlayerAudioRendering
        chkUseClock.Checked = MainForm.DefInstance.VideoGrabber1.UseClock
        chkRefreshPausedDisplay.Checked = MainForm.DefInstance.VideoGrabber1.PlayerRefreshPausedDisplay
    End Sub

    Private Sub btnAutoPlay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutoPlay.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.AutoStartPlayer = btnAutoPlay.Checked
    End Sub

    Private Sub btnChooseClip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChooseClip.Click
        Dim dlgOpen As OpenFileDialog = New OpenFileDialog

        dlgOpen.Filter = OPEN_MEDIA_FILES
        If dlgOpen.ShowDialog = Windows.Forms.DialogResult.OK Then
            edtPlayerFileName.Text = dlgOpen.FileName
        End If
    End Sub

    Private Sub btnClipDuration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClipDuration.Click
        Dim AVIDuration As Double
        Dim AVIFrameCount As Double
        If MainForm.DefInstance.VideoGrabber1.AVIDuration(edtPlayerFileName.Text, AVIDuration, AVIFrameCount) Then
            AddLog(MainForm.DefInstance.mmoLog, "Duration: " & AVIDuration.ToString)
            AddLog(MainForm.DefInstance.mmoLog, "Frame count: " & AVIFrameCount.ToString)
        Else
            AddLog(MainForm.DefInstance.mmoLog, "failed to get AVIDuration information")
        End If
    End Sub

    Private Sub btnClipGeneralInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClipGeneralInfo.Click
        Dim AVIDuration As Double
        Dim AVIFrameCount As Double
        Dim VideoWidth As Long
        Dim VideoHeight As Long
        Dim VideoCodec As String
        Dim AudioCodec As String
        Dim VideoFrameRateFps As Double
        Dim AvgBitRate As Long
        Dim AudioChannels As Long
        Dim AudioSamplesPerSec As Long
        Dim AudioBitsPerSample As Long

        VideoCodec = ""
        AudioCodec = ""

        If MainForm.DefInstance.VideoGrabber1.AVIInfo(edtPlayerFileName.Text, AVIDuration, AVIFrameCount, VideoWidth, VideoHeight, VideoFrameRateFps, AvgBitRate, AudioChannels, AudioSamplesPerSec, AudioBitsPerSample, VideoCodec, AudioCodec) Then
            AddLog(MainForm.DefInstance.mmoLog, edtPlayerFileName.Text & ":")
            AddLog(MainForm.DefInstance.mmoLog, "duration (in sec): " & AVIDuration.ToString)
            AddLog(MainForm.DefInstance.mmoLog, "frame count: " & AVIFrameCount.ToString)
            AddLog(MainForm.DefInstance.mmoLog, "video width: " & VideoWidth.ToString)
            AddLog(MainForm.DefInstance.mmoLog, "video height: " & VideoHeight.ToString)
            AddLog(MainForm.DefInstance.mmoLog, "video frame rate (fps): " & VideoFrameRateFps.ToString)
            AddLog(MainForm.DefInstance.mmoLog, "average bit rate (kb/s): " & Str(AvgBitRate \ 1024))
            AddLog(MainForm.DefInstance.mmoLog, "audio channels: " & AudioChannels.ToString)
            AddLog(MainForm.DefInstance.mmoLog, "audio samples/sec: " & AudioSamplesPerSec.ToString)
            AddLog(MainForm.DefInstance.mmoLog, "audio bits per sample: " & AudioBitsPerSample.ToString)
            AddLog(MainForm.DefInstance.mmoLog, "video codec: " & VideoCodec)
            AddLog(MainForm.DefInstance.mmoLog, "audio codec: " & AudioCodec)
        Else
            AddLog(MainForm.DefInstance.mmoLog, "clip not found.")
        End If
    End Sub

    Private Sub btnOpenLastClipPlayed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenLastClipPlayed.Click
        If MainForm.DefInstance.VideoGrabber1.Last_Clip_Played <> "" Then
            edtPlayerFileName.Text = MainForm.DefInstance.VideoGrabber1.Last_Clip_Played
            MainForm.DefInstance.VideoGrabber1.PlayerFileName = edtPlayerFileName.Text
            MainForm.DefInstance.VideoGrabber1.OpenPlayer()
        End If
    End Sub

    Private Sub btnOpenLastClipRecorded_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenLastClipRecorded.Click
        If MainForm.DefInstance.VideoGrabber1.Last_Recording_FileName <> "" Then
            edtPlayerFileName.Text = MainForm.DefInstance.VideoGrabber1.Last_Recording_FileName
            MainForm.DefInstance.VideoGrabber1.PlayerFileName = edtPlayerFileName.Text
            MainForm.DefInstance.VideoGrabber1.OpenPlayer()
        End If
    End Sub

    Private Sub btnPlayerCloseFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlayerCloseFile.Click
        MainForm.DefInstance.VideoGrabber1.ClosePlayer()
    End Sub

    Private Sub btnPlayerOpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlayerOpenFile.Click
        MainForm.DefInstance.VideoGrabber1.PlayerFileName = edtPlayerFileName.Text
        MainForm.DefInstance.VideoGrabber1.OpenPlayer()
    End Sub

    Private Sub btnPlayerOpenStreamingURL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlayerOpenStreamingURL.Click
        edtPlayerFileName.Text = "mms://www.datastead.com/demo/demo.wmv"
    End Sub

    Private Sub chkPlayerAudioRendering_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPlayerAudioRendering.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.PlayerAudioRendering = chkPlayerAudioRendering.Checked
    End Sub

    Private Sub chkRefreshPausedDisplay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRefreshPausedDisplay.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.PlayerRefreshPausedDisplay = chkRefreshPausedDisplay.Checked
    End Sub

    Private Sub updPlayerSpeedRatio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updPlayerSpeedRatio.ValueChanged
        MainForm.DefInstance.VideoGrabber1.PlayerSpeedRatio = updPlayerSpeedRatio.Value / 10
        updSpeedRadioValue.Text = MainForm.DefInstance.VideoGrabber1.PlayerSpeedRatio.ToString("0.0")
    End Sub

    Private Sub updPlayerFastSeekSpeed_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updPlayerFastSeekSpeed.ValueChanged
        MainForm.DefInstance.VideoGrabber1.PlayerFastSeekSpeedRatio = updPlayerFastSeekSpeed.Value
    End Sub

    Private Sub btnHeaderInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHeaderInfo.Click
        AddLog(MainForm.DefInstance.mmoLog, "")
        AddLog(MainForm.DefInstance.mmoLog, edtPlayerFileName.Text + " headers:")
        AddLog(MainForm.DefInstance.mmoLog, "Title: " + MainForm.DefInstance.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Title))
        AddLog(MainForm.DefInstance.mmoLog, "Description: " + MainForm.DefInstance.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Description))
        AddLog(MainForm.DefInstance.mmoLog, "Author: " + MainForm.DefInstance.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Author))
        AddLog(MainForm.DefInstance.mmoLog, "Copyright: " + MainForm.DefInstance.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Copyright))
        AddLog(MainForm.DefInstance.mmoLog, "Album Artist: " + MainForm.DefInstance.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_AlbumArtist))
        AddLog(MainForm.DefInstance.mmoLog, "Album Title: " + MainForm.DefInstance.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_AlbumTitle))
        AddLog(MainForm.DefInstance.mmoLog, "Composer: " + MainForm.DefInstance.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Composer))
        AddLog(MainForm.DefInstance.mmoLog, "Content Distributor: " + MainForm.DefInstance.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_ContentDistributor))
        AddLog(MainForm.DefInstance.mmoLog, "Director: " + MainForm.DefInstance.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Director))
        AddLog(MainForm.DefInstance.mmoLog, "Encoding Time: " + MainForm.DefInstance.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_EncodingTime))
        AddLog(MainForm.DefInstance.mmoLog, "Genre: " + MainForm.DefInstance.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Genre))
        AddLog(MainForm.DefInstance.mmoLog, "Language: " + MainForm.DefInstance.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Language))
        AddLog(MainForm.DefInstance.mmoLog, "Parental Rating: " + MainForm.DefInstance.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_ParentalRating))
        AddLog(MainForm.DefInstance.mmoLog, "Producer: " + MainForm.DefInstance.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Producer))
        AddLog(MainForm.DefInstance.mmoLog, "Provider: " + MainForm.DefInstance.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Provider))
        AddLog(MainForm.DefInstance.mmoLog, "ToolName: " + MainForm.DefInstance.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_ToolName))
        AddLog(MainForm.DefInstance.mmoLog, "Tool Version: " + MainForm.DefInstance.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_ToolVersion))
        AddLog(MainForm.DefInstance.mmoLog, "Writer: " + MainForm.DefInstance.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Writer))

    End Sub

    Private Sub chkUseClock_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUseClock.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.UseClock = chkUseClock.Checked
    End Sub

    Private Sub chkLoop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLoop.CheckedChanged
        ' the code is in the VideoGrabber1_OnPlayerEndOfStream event of MainForm
    End Sub

    Private Sub btnPlaylistAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlaylistAdd.Click

        Dim fd As New OpenFileDialog
        Dim i As Integer

        fd.Filter = OPEN_MEDIA_FILES_EXTENDED
        fd.Multiselect = True
        If fd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            For i = 0 To fd.FileNames.Length - 1
                MainForm.DefInstance.VideoGrabber1.Playlist(VidGrab.TPlaylist.pl_Add, fd.FileNames.GetValue(i))
                lstPlaylist.Items.Add(fd.FileNames.GetValue(i))
            Next
        End If
    End Sub

    Private Sub btnPlaylistPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlaylistPlay.Click
        MainForm.DefInstance.VideoGrabber1.Playlist(VidGrab.TPlaylist.pl_Play, "")
    End Sub

    Private Sub btnPlaylistNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlaylistNext.Click
        MainForm.DefInstance.VideoGrabber1.Playlist(VidGrab.TPlaylist.pl_Next, "")
    End Sub

    Private Sub btnPlaylistPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlaylistPrevious.Click
        MainForm.DefInstance.VideoGrabber1.Playlist(VidGrab.TPlaylist.pl_Previous, "")
    End Sub

    Private Sub btnPlaylistStopAfterCurrent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlaylistStopAfterCurrent.Click
        MainForm.DefInstance.VideoGrabber1.Playlist(VidGrab.TPlaylist.pl_Stop, "")
    End Sub

    Private Sub btnPlaylistClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlaylistClose.Click
        MainForm.DefInstance.VideoGrabber1.ClosePlayer()
    End Sub

    Private Sub chkPlaylistLoop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPlaylistLoop.CheckedChanged
        If chkPlaylistLoop.Checked Then
            MainForm.DefInstance.VideoGrabber1.Playlist(VidGrab.TPlaylist.pl_Loop, "")
        Else
            MainForm.DefInstance.VideoGrabber1.Playlist(VidGrab.TPlaylist.pl_NoLoop, "")
        End If
    End Sub

    Private Sub chkPlaylistRandom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPlaylistRandom.CheckedChanged
        If chkPlaylistRandom.Checked Then
            MainForm.DefInstance.VideoGrabber1.Playlist(VidGrab.TPlaylist.pl_Random, "")
        Else
            MainForm.DefInstance.VideoGrabber1.Playlist(VidGrab.TPlaylist.pl_Sequential, "")
        End If
    End Sub

    Private Sub btnOpenAtFrames_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenAtFrames.Click
        MainForm.DefInstance.VideoGrabber1.PlayerFileName = edtPlayerFileName.Text
        If IsNumeric(txtStartFrame.Text) And IsNumeric(txtStopFrame.Text) Then
            MainForm.DefInstance.VideoGrabber1.OpenPlayerAtFramePositions(Convert.ToDouble(txtStartFrame.Text), Convert.ToDouble(txtStopFrame.Text), chkKeepBounds.Checked, chkReopen.Checked)
        End If
    End Sub

    Private Sub btnOpenAtTimes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenAtTimes.Click
        MainForm.DefInstance.VideoGrabber1.PlayerFileName = edtPlayerFileName.Text
        If IsNumeric(txtStartTime.Text) And IsNumeric(txtStopTime.Text) Then
            MainForm.DefInstance.VideoGrabber1.OpenPlayerAtTimePositions(Convert.ToDouble(txtStartTime.Text), Convert.ToDouble(txtStopTime.Text), chkKeepBounds.Checked, chkReopen.Checked)
        End If
    End Sub

    Private Sub Player_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Visible Then
            RefreshControls()
        End If
    End Sub

    Private Sub btnOpenDVD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenDVD.Click
        If edtPlayerFileName.Text = "Choose a video or audio clip..." Then
            MainForm.DefInstance.VideoGrabber1.PlayerFileName = ""  ' this will use the default DVD
        Else
            MainForm.DefInstance.VideoGrabber1.PlayerFileName = edtPlayerFileName.Text
        End If
        If MainForm.DefInstance.VideoGrabber1.OpenDVD() Then
            edtPlayerFileName.Text = MainForm.DefInstance.VideoGrabber1.PlayerFileName ' to reflect the real DVD file path used
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim NumberOfTitles As Long
        Dim i As Long

        AddLog(MainForm.DefInstance.mmoLog, "total DVD duration: " + Str(MainForm.DefInstance.VideoGrabber1.DVDInfo(edtPlayerFileName.Text, VidGrab.TDVDInfoType.dvd_TotalDuration, 0)))

        NumberOfTitles = MainForm.DefInstance.VideoGrabber1.DVDInfo(edtPlayerFileName.Text, VidGrab.TDVDInfoType.dvd_NumberOfTitles, 0)
        AddLog(MainForm.DefInstance.mmoLog, "number of titles: " + Str(MainForm.DefInstance.VideoGrabber1.DVDInfo(edtPlayerFileName.Text, VidGrab.TDVDInfoType.dvd_NumberOfTitles, 0)))

        For i = 1 To NumberOfTitles
            AddLog(MainForm.DefInstance.mmoLog, "TITLE " + Str(i) + ":")
            AddLog(MainForm.DefInstance.mmoLog, "duration in seconds: " + Str(MainForm.DefInstance.VideoGrabber1.DVDInfo(edtPlayerFileName.Text, VidGrab.TDVDInfoType.dvd_TotalDuration, i)))
            AddLog(MainForm.DefInstance.mmoLog, "frame count: " + Str(MainForm.DefInstance.VideoGrabber1.DVDInfo(edtPlayerFileName.Text, VidGrab.TDVDInfoType.dvd_TitleFrameCount, i)))
            AddLog(MainForm.DefInstance.mmoLog, "frame rate: " + Str(MainForm.DefInstance.VideoGrabber1.DVDInfo(edtPlayerFileName.Text, VidGrab.TDVDInfoType.dvd_TitleFrameRate, i)))
            AddLog(MainForm.DefInstance.mmoLog, "video resolution X: " + Str(MainForm.DefInstance.VideoGrabber1.DVDInfo(edtPlayerFileName.Text, VidGrab.TDVDInfoType.dvd_SourceResolutionX, i)))
            AddLog(MainForm.DefInstance.mmoLog, "video resolution Y: " + Str(MainForm.DefInstance.VideoGrabber1.DVDInfo(edtPlayerFileName.Text, VidGrab.TDVDInfoType.dvd_SourceResolutionY, i)))
        Next

    End Sub

    Private Sub rdgHwAccel_none_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgHwAccel_none.CheckedChanged
        If rdgHwAccel_none.Checked Then
            MainForm.DefInstance.VideoGrabber1.PlayerHwAccel = VidGrab.THwAccel.hw_None
        End If
    End Sub

    Private Sub rdgHwAccel_CUDA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgHwAccel_CUDA.CheckedChanged
        If rdgHwAccel_CUDA.Checked Then
            MainForm.DefInstance.VideoGrabber1.PlayerHwAccel = VidGrab.THwAccel.hw_Cuda
        End If
    End Sub

    Private Sub rdgHwAccel_QuickSync_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgHwAccel_QuickSync.CheckedChanged
        If rdgHwAccel_QuickSync.Checked Then
            MainForm.DefInstance.VideoGrabber1.PlayerHwAccel = VidGrab.THwAccel.hw_QuickSync
        End If
    End Sub

    Private Sub rdgHwAccel_DXVA2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgHwAccel_DXVA2.CheckedChanged
        If rdgHwAccel_DXVA2.Checked Then
            MainForm.DefInstance.VideoGrabber1.PlayerHwAccel = VidGrab.THwAccel.hw_Dxva2
        End If
    End Sub

    Private Sub rdgHwAccel_d3d11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgHwAccel_d3d11.CheckedChanged
        If rdgHwAccel_d3d11.Checked Then
            MainForm.DefInstance.VideoGrabber1.PlayerHwAccel = VidGrab.THwAccel.hw_d3d11
        End If
    End Sub
End Class
