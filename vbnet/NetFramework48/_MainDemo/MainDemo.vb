
Imports System.Runtime.InteropServices

Friend Class MainForm
    Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()

        If m_vb6FormDefInstance Is Nothing Then
            If m_InitializingDefInstance Then
                m_vb6FormDefInstance = Me
            Else
                Try
                    'For the start-up form, the first instance created is the default instance.
                    If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
                        m_vb6FormDefInstance = Me
                    End If
                Catch
                End Try
            End If
        End If

        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        While ProcessingNextFrameNeeded
            Application.DoEvents()
        End While

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
    Public WithEvents mmoLog As System.Windows.Forms.TextBox
    Public WithEvents edtAdditionalInfo As System.Windows.Forms.TextBox
    Public WithEvents edtFrameCount As System.Windows.Forms.TextBox
    Public WithEvents edtStoragePath As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents mnuExit As System.Windows.Forms.MenuItem
    Public WithEvents mnuFile As System.Windows.Forms.MenuItem
    Public WithEvents mnuAbout As System.Windows.Forms.MenuItem
    Public MainMenu1 As System.Windows.Forms.MainMenu
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents VideoGrabber1 As VidGrab.VideoGrabber
    Friend WithEvents tbcTabs As System.Windows.Forms.TabControl
    Friend WithEvents tbpVideoSource As System.Windows.Forms.TabPage
    Friend WithEvents tbpIPCameras As System.Windows.Forms.TabPage
    Friend WithEvents tbpAudio As System.Windows.Forms.TabPage
    Friend WithEvents tbpRecording As System.Windows.Forms.TabPage
    Friend WithEvents tbpNetworkStreaming As System.Windows.Forms.TabPage
    Friend WithEvents tbpPlayer As System.Windows.Forms.TabPage
    Friend WithEvents tbpFrameGrabber As System.Windows.Forms.TabPage
    Friend WithEvents tbpMotionDetection As System.Windows.Forms.TabPage
    Friend WithEvents tbpOverlays As System.Windows.Forms.TabPage
    Friend WithEvents tbpVideoProcessing As System.Windows.Forms.TabPage
    Friend WithEvents tbpDisplay As System.Windows.Forms.TabPage
    Friend WithEvents tbpReencoding As System.Windows.Forms.TabPage
    Friend WithEvents gbPlayerControl As System.Windows.Forms.GroupBox
    Friend WithEvents tbrPlayer As System.Windows.Forms.TrackBar
    Public WithEvents btnFastFwd As System.Windows.Forms.Button
    Public WithEvents btnFastRew As System.Windows.Forms.Button
    Public WithEvents btnPlay As System.Windows.Forms.Button
    Public WithEvents btnStop As System.Windows.Forms.Button
    Public WithEvents btnPause As System.Windows.Forms.Button
    Public WithEvents btnPlayBackwards As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents tbpMultipurposeEncoder As System.Windows.Forms.TabPage
    Friend WithEvents chkPlayerTrackBarSynchrone As System.Windows.Forms.CheckBox
    Public WithEvents btnFrameStep As System.Windows.Forms.Button
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents tbrZoomY As System.Windows.Forms.TrackBar
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents tbrZoomX As System.Windows.Forms.TrackBar
    Friend WithEvents tbrZoom As System.Windows.Forms.TrackBar
    Friend WithEvents AutoSizeInfo As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnFastFwd = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnFastRew = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnPlayBackwards = New System.Windows.Forms.Button()
        Me.btnFrameStep = New System.Windows.Forms.Button()
        Me.mmoLog = New System.Windows.Forms.TextBox()
        Me.edtAdditionalInfo = New System.Windows.Forms.TextBox()
        Me.edtFrameCount = New System.Windows.Forms.TextBox()
        Me.edtStoragePath = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuExit = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.mnuAbout = New System.Windows.Forms.MenuItem()
        Me.tbcTabs = New System.Windows.Forms.TabControl()
        Me.tbpVideoSource = New System.Windows.Forms.TabPage()
        Me.tbpIPCameras = New System.Windows.Forms.TabPage()
        Me.tbpAudio = New System.Windows.Forms.TabPage()
        Me.tbpRecording = New System.Windows.Forms.TabPage()
        Me.tbpMultipurposeEncoder = New System.Windows.Forms.TabPage()
        Me.tbpNetworkStreaming = New System.Windows.Forms.TabPage()
        Me.tbpPlayer = New System.Windows.Forms.TabPage()
        Me.tbpFrameGrabber = New System.Windows.Forms.TabPage()
        Me.tbpMotionDetection = New System.Windows.Forms.TabPage()
        Me.tbpOverlays = New System.Windows.Forms.TabPage()
        Me.tbpVideoProcessing = New System.Windows.Forms.TabPage()
        Me.tbpDisplay = New System.Windows.Forms.TabPage()
        Me.tbpReencoding = New System.Windows.Forms.TabPage()
        Me.gbPlayerControl = New System.Windows.Forms.GroupBox()
        Me.tbrPlayer = New System.Windows.Forms.TrackBar()
        Me.chkPlayerTrackBarSynchrone = New System.Windows.Forms.CheckBox()
        Me.tbrZoomY = New System.Windows.Forms.TrackBar()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.tbrZoomX = New System.Windows.Forms.TrackBar()
        Me.tbrZoom = New System.Windows.Forms.TrackBar()
        Me.AutoSizeInfo = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.VideoGrabber1 = New VidGrab.VideoGrabber()
        Me.tbcTabs.SuspendLayout()
        Me.gbPlayerControl.SuspendLayout()
        CType(Me.tbrPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrZoomY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrZoomX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrZoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFastFwd
        '
        Me.btnFastFwd.BackColor = System.Drawing.SystemColors.Control
        Me.btnFastFwd.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnFastFwd.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFastFwd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFastFwd.ImageIndex = 0
        Me.btnFastFwd.ImageList = Me.ImageList1
        Me.btnFastFwd.Location = New System.Drawing.Point(278, 20)
        Me.btnFastFwd.Name = "btnFastFwd"
        Me.btnFastFwd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnFastFwd.Size = New System.Drawing.Size(39, 27)
        Me.btnFastFwd.TabIndex = 32
        Me.ToolTip1.SetToolTip(Me.btnFastFwd, "Fast Forward")
        Me.btnFastFwd.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Silver
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        '
        'btnFastRew
        '
        Me.btnFastRew.BackColor = System.Drawing.SystemColors.Control
        Me.btnFastRew.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnFastRew.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFastRew.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFastRew.ImageIndex = 1
        Me.btnFastRew.ImageList = Me.ImageList1
        Me.btnFastRew.Location = New System.Drawing.Point(233, 20)
        Me.btnFastRew.Name = "btnFastRew"
        Me.btnFastRew.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnFastRew.Size = New System.Drawing.Size(38, 27)
        Me.btnFastRew.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.btnFastRew, "Rewind")
        Me.btnFastRew.UseVisualStyleBackColor = False
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.SystemColors.Control
        Me.btnPlay.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnPlay.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPlay.ImageIndex = 2
        Me.btnPlay.ImageList = Me.ImageList1
        Me.btnPlay.Location = New System.Drawing.Point(142, 20)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPlay.Size = New System.Drawing.Size(38, 27)
        Me.btnPlay.TabIndex = 30
        Me.ToolTip1.SetToolTip(Me.btnPlay, "Play")
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.SystemColors.Control
        Me.btnStop.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnStop.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStop.ImageIndex = 3
        Me.btnStop.ImageList = Me.ImageList1
        Me.btnStop.Location = New System.Drawing.Point(52, 20)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnStop.Size = New System.Drawing.Size(38, 27)
        Me.btnStop.TabIndex = 29
        Me.ToolTip1.SetToolTip(Me.btnStop, "Stop")
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'btnPause
        '
        Me.btnPause.BackColor = System.Drawing.SystemColors.Control
        Me.btnPause.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnPause.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPause.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPause.ImageIndex = 4
        Me.btnPause.ImageList = Me.ImageList1
        Me.btnPause.Location = New System.Drawing.Point(96, 20)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPause.Size = New System.Drawing.Size(38, 27)
        Me.btnPause.TabIndex = 28
        Me.ToolTip1.SetToolTip(Me.btnPause, "Pause")
        Me.btnPause.UseVisualStyleBackColor = False
        '
        'btnPlayBackwards
        '
        Me.btnPlayBackwards.BackColor = System.Drawing.SystemColors.Control
        Me.btnPlayBackwards.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnPlayBackwards.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayBackwards.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPlayBackwards.ImageIndex = 5
        Me.btnPlayBackwards.ImageList = Me.ImageList1
        Me.btnPlayBackwards.Location = New System.Drawing.Point(7, 20)
        Me.btnPlayBackwards.Name = "btnPlayBackwards"
        Me.btnPlayBackwards.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPlayBackwards.Size = New System.Drawing.Size(39, 27)
        Me.btnPlayBackwards.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.btnPlayBackwards, "Play Reverse")
        Me.btnPlayBackwards.UseVisualStyleBackColor = False
        '
        'btnFrameStep
        '
        Me.btnFrameStep.BackColor = System.Drawing.SystemColors.Control
        Me.btnFrameStep.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnFrameStep.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrameStep.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFrameStep.ImageIndex = 6
        Me.btnFrameStep.ImageList = Me.ImageList1
        Me.btnFrameStep.Location = New System.Drawing.Point(187, 20)
        Me.btnFrameStep.Name = "btnFrameStep"
        Me.btnFrameStep.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnFrameStep.Size = New System.Drawing.Size(39, 27)
        Me.btnFrameStep.TabIndex = 33
        Me.ToolTip1.SetToolTip(Me.btnFrameStep, "Play")
        Me.btnFrameStep.UseVisualStyleBackColor = False
        '
        'mmoLog
        '
        Me.mmoLog.AcceptsReturn = True
        Me.mmoLog.BackColor = System.Drawing.SystemColors.Window
        Me.mmoLog.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.mmoLog.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mmoLog.ForeColor = System.Drawing.SystemColors.WindowText
        Me.mmoLog.Location = New System.Drawing.Point(7, 430)
        Me.mmoLog.MaxLength = 0
        Me.mmoLog.Multiline = True
        Me.mmoLog.Name = "mmoLog"
        Me.mmoLog.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mmoLog.Size = New System.Drawing.Size(250, 375)
        Me.mmoLog.TabIndex = 17
        '
        'edtAdditionalInfo
        '
        Me.edtAdditionalInfo.AcceptsReturn = True
        Me.edtAdditionalInfo.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.edtAdditionalInfo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtAdditionalInfo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtAdditionalInfo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtAdditionalInfo.Location = New System.Drawing.Point(7, 400)
        Me.edtAdditionalInfo.MaxLength = 0
        Me.edtAdditionalInfo.Name = "edtAdditionalInfo"
        Me.edtAdditionalInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtAdditionalInfo.Size = New System.Drawing.Size(250, 23)
        Me.edtAdditionalInfo.TabIndex = 16
        '
        'edtFrameCount
        '
        Me.edtFrameCount.AcceptsReturn = True
        Me.edtFrameCount.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.edtFrameCount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtFrameCount.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtFrameCount.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtFrameCount.Location = New System.Drawing.Point(7, 370)
        Me.edtFrameCount.MaxLength = 0
        Me.edtFrameCount.Name = "edtFrameCount"
        Me.edtFrameCount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtFrameCount.Size = New System.Drawing.Size(250, 23)
        Me.edtFrameCount.TabIndex = 15
        '
        'edtStoragePath
        '
        Me.edtStoragePath.AcceptsReturn = True
        Me.edtStoragePath.BackColor = System.Drawing.SystemColors.Window
        Me.edtStoragePath.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtStoragePath.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtStoragePath.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtStoragePath.Location = New System.Drawing.Point(7, 341)
        Me.edtStoragePath.MaxLength = 0
        Me.edtStoragePath.Name = "edtStoragePath"
        Me.edtStoragePath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtStoragePath.Size = New System.Drawing.Size(250, 23)
        Me.edtStoragePath.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(7, 321)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "storage path:"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.MenuItem1, Me.mnuAbout})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuExit})
        Me.mnuFile.Text = "File"
        '
        'mnuExit
        '
        Me.mnuExit.Index = 0
        Me.mnuExit.Text = "Exit"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 1
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2})
        Me.MenuItem1.Text = "Options"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "Reset video capture device settings"
        '
        'mnuAbout
        '
        Me.mnuAbout.Index = 2
        Me.mnuAbout.Text = "About"
        '
        'tbcTabs
        '
        Me.tbcTabs.Controls.Add(Me.tbpVideoSource)
        Me.tbcTabs.Controls.Add(Me.tbpIPCameras)
        Me.tbcTabs.Controls.Add(Me.tbpAudio)
        Me.tbcTabs.Controls.Add(Me.tbpRecording)
        Me.tbcTabs.Controls.Add(Me.tbpMultipurposeEncoder)
        Me.tbcTabs.Controls.Add(Me.tbpNetworkStreaming)
        Me.tbcTabs.Controls.Add(Me.tbpPlayer)
        Me.tbcTabs.Controls.Add(Me.tbpFrameGrabber)
        Me.tbcTabs.Controls.Add(Me.tbpMotionDetection)
        Me.tbcTabs.Controls.Add(Me.tbpOverlays)
        Me.tbcTabs.Controls.Add(Me.tbpVideoProcessing)
        Me.tbcTabs.Controls.Add(Me.tbpDisplay)
        Me.tbcTabs.Controls.Add(Me.tbpReencoding)
        Me.tbcTabs.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcTabs.Location = New System.Drawing.Point(7, 2)
        Me.tbcTabs.Name = "tbcTabs"
        Me.tbcTabs.Padding = New System.Drawing.Point(5, 3)
        Me.tbcTabs.SelectedIndex = 0
        Me.tbcTabs.Size = New System.Drawing.Size(1235, 259)
        Me.tbcTabs.TabIndex = 58
        '
        'tbpVideoSource
        '
        Me.tbpVideoSource.Location = New System.Drawing.Point(4, 25)
        Me.tbpVideoSource.Name = "tbpVideoSource"
        Me.tbpVideoSource.Size = New System.Drawing.Size(1227, 230)
        Me.tbpVideoSource.TabIndex = 0
        Me.tbpVideoSource.Text = "video source"
        '
        'tbpIPCameras
        '
        Me.tbpIPCameras.Location = New System.Drawing.Point(4, 25)
        Me.tbpIPCameras.Name = "tbpIPCameras"
        Me.tbpIPCameras.Size = New System.Drawing.Size(1227, 230)
        Me.tbpIPCameras.TabIndex = 1
        Me.tbpIPCameras.Text = "IP cameras"
        '
        'tbpAudio
        '
        Me.tbpAudio.Location = New System.Drawing.Point(4, 25)
        Me.tbpAudio.Name = "tbpAudio"
        Me.tbpAudio.Size = New System.Drawing.Size(1227, 230)
        Me.tbpAudio.TabIndex = 2
        Me.tbpAudio.Text = "audio"
        '
        'tbpRecording
        '
        Me.tbpRecording.Location = New System.Drawing.Point(4, 25)
        Me.tbpRecording.Name = "tbpRecording"
        Me.tbpRecording.Size = New System.Drawing.Size(1227, 230)
        Me.tbpRecording.TabIndex = 3
        Me.tbpRecording.Text = "recording"
        '
        'tbpMultipurposeEncoder
        '
        Me.tbpMultipurposeEncoder.Location = New System.Drawing.Point(4, 25)
        Me.tbpMultipurposeEncoder.Name = "tbpMultipurposeEncoder"
        Me.tbpMultipurposeEncoder.Size = New System.Drawing.Size(1227, 230)
        Me.tbpMultipurposeEncoder.TabIndex = 13
        Me.tbpMultipurposeEncoder.Text = "Multipurpose Encoder"
        '
        'tbpNetworkStreaming
        '
        Me.tbpNetworkStreaming.Location = New System.Drawing.Point(4, 25)
        Me.tbpNetworkStreaming.Name = "tbpNetworkStreaming"
        Me.tbpNetworkStreaming.Size = New System.Drawing.Size(1227, 230)
        Me.tbpNetworkStreaming.TabIndex = 4
        Me.tbpNetworkStreaming.Text = "streaming"
        '
        'tbpPlayer
        '
        Me.tbpPlayer.Location = New System.Drawing.Point(4, 25)
        Me.tbpPlayer.Name = "tbpPlayer"
        Me.tbpPlayer.Size = New System.Drawing.Size(1227, 230)
        Me.tbpPlayer.TabIndex = 5
        Me.tbpPlayer.Text = "player"
        '
        'tbpFrameGrabber
        '
        Me.tbpFrameGrabber.Location = New System.Drawing.Point(4, 25)
        Me.tbpFrameGrabber.Name = "tbpFrameGrabber"
        Me.tbpFrameGrabber.Size = New System.Drawing.Size(1227, 230)
        Me.tbpFrameGrabber.TabIndex = 6
        Me.tbpFrameGrabber.Text = "frame grabber"
        '
        'tbpMotionDetection
        '
        Me.tbpMotionDetection.Location = New System.Drawing.Point(4, 25)
        Me.tbpMotionDetection.Name = "tbpMotionDetection"
        Me.tbpMotionDetection.Size = New System.Drawing.Size(1227, 230)
        Me.tbpMotionDetection.TabIndex = 7
        Me.tbpMotionDetection.Text = "motion detection"
        '
        'tbpOverlays
        '
        Me.tbpOverlays.Location = New System.Drawing.Point(4, 25)
        Me.tbpOverlays.Name = "tbpOverlays"
        Me.tbpOverlays.Size = New System.Drawing.Size(1227, 230)
        Me.tbpOverlays.TabIndex = 8
        Me.tbpOverlays.Text = "overlays"
        '
        'tbpVideoProcessing
        '
        Me.tbpVideoProcessing.Location = New System.Drawing.Point(4, 25)
        Me.tbpVideoProcessing.Name = "tbpVideoProcessing"
        Me.tbpVideoProcessing.Size = New System.Drawing.Size(1227, 230)
        Me.tbpVideoProcessing.TabIndex = 9
        Me.tbpVideoProcessing.Text = "video processing"
        '
        'tbpDisplay
        '
        Me.tbpDisplay.Location = New System.Drawing.Point(4, 25)
        Me.tbpDisplay.Name = "tbpDisplay"
        Me.tbpDisplay.Size = New System.Drawing.Size(1227, 230)
        Me.tbpDisplay.TabIndex = 10
        Me.tbpDisplay.Text = "display"
        '
        'tbpReencoding
        '
        Me.tbpReencoding.Location = New System.Drawing.Point(4, 25)
        Me.tbpReencoding.Name = "tbpReencoding"
        Me.tbpReencoding.Size = New System.Drawing.Size(1227, 230)
        Me.tbpReencoding.TabIndex = 11
        Me.tbpReencoding.Text = "reencoding"
        '
        'gbPlayerControl
        '
        Me.gbPlayerControl.Controls.Add(Me.btnFrameStep)
        Me.gbPlayerControl.Controls.Add(Me.btnFastFwd)
        Me.gbPlayerControl.Controls.Add(Me.btnFastRew)
        Me.gbPlayerControl.Controls.Add(Me.btnPlay)
        Me.gbPlayerControl.Controls.Add(Me.btnPause)
        Me.gbPlayerControl.Controls.Add(Me.btnPlayBackwards)
        Me.gbPlayerControl.Controls.Add(Me.tbrPlayer)
        Me.gbPlayerControl.Controls.Add(Me.btnStop)
        Me.gbPlayerControl.Location = New System.Drawing.Point(7, 263)
        Me.gbPlayerControl.Name = "gbPlayerControl"
        Me.gbPlayerControl.Size = New System.Drawing.Size(1114, 55)
        Me.gbPlayerControl.TabIndex = 59
        Me.gbPlayerControl.TabStop = False
        Me.gbPlayerControl.Text = "player control"
        '
        'tbrPlayer
        '
        Me.tbrPlayer.AutoSize = False
        Me.tbrPlayer.Location = New System.Drawing.Point(324, 17)
        Me.tbrPlayer.Name = "tbrPlayer"
        Me.tbrPlayer.Size = New System.Drawing.Size(781, 37)
        Me.tbrPlayer.TabIndex = 20
        '
        'chkPlayerTrackBarSynchrone
        '
        Me.chkPlayerTrackBarSynchrone.Location = New System.Drawing.Point(973, 323)
        Me.chkPlayerTrackBarSynchrone.Name = "chkPlayerTrackBarSynchrone"
        Me.chkPlayerTrackBarSynchrone.Size = New System.Drawing.Size(203, 22)
        Me.chkPlayerTrackBarSynchrone.TabIndex = 60
        Me.chkPlayerTrackBarSynchrone.Text = "player trackbar synchrone"
        '
        'tbrZoomY
        '
        Me.tbrZoomY.AutoSize = False
        Me.tbrZoomY.Location = New System.Drawing.Point(259, 384)
        Me.tbrZoomY.Maximum = 20000
        Me.tbrZoomY.Minimum = 1000
        Me.tbrZoomY.Name = "tbrZoomY"
        Me.tbrZoomY.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbrZoomY.Size = New System.Drawing.Size(22, 391)
        Me.tbrZoomY.TabIndex = 74
        Me.tbrZoomY.Value = 1000
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(260, 364)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(20, 16)
        Me.label4.TabIndex = 73
        Me.label4.Text = "Y:"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(260, 336)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(105, 33)
        Me.label3.TabIndex = 72
        Me.label3.Text = "zoom center X:"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbrZoomX
        '
        Me.tbrZoomX.AutoSize = False
        Me.tbrZoomX.Location = New System.Drawing.Point(350, 347)
        Me.tbrZoomX.Maximum = 20000
        Me.tbrZoomX.Minimum = 1000
        Me.tbrZoomX.Name = "tbrZoomX"
        Me.tbrZoomX.Size = New System.Drawing.Size(580, 19)
        Me.tbrZoomX.TabIndex = 71
        Me.tbrZoomX.Value = 1000
        '
        'tbrZoom
        '
        Me.tbrZoom.AutoSize = False
        Me.tbrZoom.Location = New System.Drawing.Point(299, 308)
        Me.tbrZoom.Maximum = 20000
        Me.tbrZoom.Minimum = 1000
        Me.tbrZoom.Name = "tbrZoom"
        Me.tbrZoom.Size = New System.Drawing.Size(644, 32)
        Me.tbrZoom.TabIndex = 70
        Me.tbrZoom.Value = 1000
        '
        'AutoSizeInfo
        '
        Me.AutoSizeInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.AutoSizeInfo.Location = New System.Drawing.Point(295, 369)
        Me.AutoSizeInfo.Name = "AutoSizeInfo"
        Me.AutoSizeInfo.Size = New System.Drawing.Size(903, 25)
        Me.AutoSizeInfo.TabIndex = 75
        Me.AutoSizeInfo.Text = "the component will resize automatically because SetDisplayAutoSize(index, true) i" &
    "s enabled in the Form_Load event (default = disabled)"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(256, 305)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(50, 33)
        Me.label2.TabIndex = 76
        Me.label2.Text = "ZOOM:"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VideoGrabber1
        '
        Me.VideoGrabber1.AdjustOverlayAspectRatio = True
        Me.VideoGrabber1.AdjustPixelAspectRatio = True
        Me.VideoGrabber1.Aero = VidGrab.TAero.ae_Default
        Me.VideoGrabber1.AnalogVideoStandard = -1
        Me.VideoGrabber1.ApplicationPriority = VidGrab.TApplicationPriority.ap_default
        Me.VideoGrabber1.ASFAudioBitRate = -1
        Me.VideoGrabber1.ASFAudioChannels = -1
        Me.VideoGrabber1.ASFBufferWindow = -1
        Me.VideoGrabber1.ASFDeinterlaceMode = VidGrab.TASFDeinterlaceMode.adm_NotInterlaced
        Me.VideoGrabber1.ASFDirectStreamingKeepClientsConnected = False
        Me.VideoGrabber1.ASFFixedFrameRate = True
        Me.VideoGrabber1.ASFMediaServerPublishingPoint = ""
        Me.VideoGrabber1.ASFMediaServerRemovePublishingPointAfterDisconnect = False
        Me.VideoGrabber1.ASFMediaServerTemplatePublishingPoint = ""
        Me.VideoGrabber1.ASFNetworkMaxUsers = 5
        Me.VideoGrabber1.ASFNetworkPort = 0
        Me.VideoGrabber1.ASFProfile = -1
        Me.VideoGrabber1.ASFProfileFromCustomFile = ""
        Me.VideoGrabber1.ASFProfileVersion = VidGrab.TASFProfileVersion.apv_ProfileVersion_8
        Me.VideoGrabber1.ASFVideoBitRate = -1
        Me.VideoGrabber1.ASFVideoFrameRate = 0R
        Me.VideoGrabber1.ASFVideoHeight = -1
        Me.VideoGrabber1.ASFVideoMaxKeyFrameSpacing = -1
        Me.VideoGrabber1.ASFVideoQuality = -1
        Me.VideoGrabber1.ASFVideoWidth = -1
        Me.VideoGrabber1.AspectRatioToUse = -1.0R
        Me.VideoGrabber1.AssociateAudioAndVideoDevices = False
        Me.VideoGrabber1.AudioBalance = 0
        Me.VideoGrabber1.AudioChannelRenderMode = VidGrab.TAudioChannelRenderMode.acrm_PassThru
        Me.VideoGrabber1.AudioCompressor = 0
        Me.VideoGrabber1.AudioDevice = -1
        Me.VideoGrabber1.AudioDeviceRendering = False
        Me.VideoGrabber1.AudioFormat = VidGrab.TAudioFormat.af_default
        Me.VideoGrabber1.AudioInput = -1
        Me.VideoGrabber1.AudioInputBalance = 0
        Me.VideoGrabber1.AudioInputLevel = 65535
        Me.VideoGrabber1.AudioInputMono = False
        Me.VideoGrabber1.AudioPeakEvent = True
        Me.VideoGrabber1.AudioRecording = False
        Me.VideoGrabber1.AudioRenderer = -1
        Me.VideoGrabber1.AudioSource = VidGrab.TAudioSource.as_Default
        Me.VideoGrabber1.AudioStreamNumber = -1
        Me.VideoGrabber1.AudioSyncAdjustment = 0
        Me.VideoGrabber1.AudioSyncAdjustmentEnabled = False
        Me.VideoGrabber1.AudioVolume = 32767
        Me.VideoGrabber1.AutoConnectRelatedPins = True
        Me.VideoGrabber1.AutoFileName = VidGrab.TAutoFileName.fn_Sequential
        Me.VideoGrabber1.AutoFileNameDateTimeFormat = "yymmdd_hhmmss_zzz"
        Me.VideoGrabber1.AutoFileNameMinDigits = 6
        Me.VideoGrabber1.AutoFilePrefix = "vg"
        Me.VideoGrabber1.AutoFileSuffix = ""
        Me.VideoGrabber1.AutoRefreshPreview = False
        Me.VideoGrabber1.AutoStartPlayer = True
        Me.VideoGrabber1.AVIDurationUpdated = True
        Me.VideoGrabber1.AVIFormatOpenDML = True
        Me.VideoGrabber1.AVIFormatOpenDMLCompatibilityIndex = True
        Me.VideoGrabber1.BackColor = System.Drawing.Color.DarkGray
        Me.VideoGrabber1.BackgroundColor = 0
        Me.VideoGrabber1.BufferCount = -1
        Me.VideoGrabber1.BurstCount = 3
        Me.VideoGrabber1.BurstInterval = 0
        Me.VideoGrabber1.BurstMode = False
        Me.VideoGrabber1.BurstType = VidGrab.TFrameCaptureDest.fc_TBitmap
        Me.VideoGrabber1.BusyCursor = VidGrab.TCursors.cr_HourGlass
        Me.VideoGrabber1.CameraControlSettings = True
        Me.VideoGrabber1.CaptureFileExt = ""
        Me.VideoGrabber1.ColorKey = 1048592
        Me.VideoGrabber1.ColorKeyEnabled = False
        Me.VideoGrabber1.CompressionMode = VidGrab.TCompressionMode.cm_CompressOnTheFly
        Me.VideoGrabber1.CompressionType = VidGrab.TCompressionType.ct_Video
        Me.VideoGrabber1.Cropping_Enabled = False
        Me.VideoGrabber1.Cropping_Height = 120
        Me.VideoGrabber1.Cropping_Outbounds = True
        Me.VideoGrabber1.Cropping_Width = 160
        Me.VideoGrabber1.Cropping_X = 0
        Me.VideoGrabber1.Cropping_Y = 0
        Me.VideoGrabber1.Cropping_Zoom = 1.0R
        Me.VideoGrabber1.Display_Active = True
        Me.VideoGrabber1.Display_AlphaBlendEnabled = False
        Me.VideoGrabber1.Display_AlphaBlendValue = 180
        Me.VideoGrabber1.Display_AspectRatio = VidGrab.TAspectRatio.ar_Box
        Me.VideoGrabber1.Display_AutoSize = False
        Me.VideoGrabber1.Display_Embedded = True
        Me.VideoGrabber1.Display_Embedded_FitParent = False
        Me.VideoGrabber1.Display_FullScreen = False
        Me.VideoGrabber1.Display_Height = 720
        Me.VideoGrabber1.Display_Left = 10
        Me.VideoGrabber1.Display_Monitor = 0
        Me.VideoGrabber1.Display_MouseMovesWindow = True
        Me.VideoGrabber1.Display_PanScanRatio = 50
        Me.VideoGrabber1.Display_StayOnTop = False
        Me.VideoGrabber1.Display_Top = 10
        Me.VideoGrabber1.Display_TransparentColorEnabled = False
        Me.VideoGrabber1.Display_TransparentColorValue = 255
        Me.VideoGrabber1.Display_VideoPortEnabled = True
        Me.VideoGrabber1.Display_Visible = True
        Me.VideoGrabber1.Display_Width = 1280
        Me.VideoGrabber1.DoubleBuffered = False
        Me.VideoGrabber1.DroppedFramesPollingInterval = -1
        Me.VideoGrabber1.DualDisplay_Active = False
        Me.VideoGrabber1.DualDisplay_AlphaBlendEnabled = False
        Me.VideoGrabber1.DualDisplay_AlphaBlendValue = 180
        Me.VideoGrabber1.DualDisplay_AspectRatio = VidGrab.TAspectRatio.ar_Box
        Me.VideoGrabber1.DualDisplay_AutoSize = False
        Me.VideoGrabber1.DualDisplay_Embedded = False
        Me.VideoGrabber1.DualDisplay_Embedded_FitParent = False
        Me.VideoGrabber1.DualDisplay_FullScreen = False
        Me.VideoGrabber1.DualDisplay_Height = 720
        Me.VideoGrabber1.DualDisplay_Left = 20
        Me.VideoGrabber1.DualDisplay_Monitor = 0
        Me.VideoGrabber1.DualDisplay_MouseMovesWindow = True
        Me.VideoGrabber1.DualDisplay_PanScanRatio = 50
        Me.VideoGrabber1.DualDisplay_StayOnTop = False
        Me.VideoGrabber1.DualDisplay_Top = 400
        Me.VideoGrabber1.DualDisplay_TransparentColorEnabled = False
        Me.VideoGrabber1.DualDisplay_TransparentColorValue = 255
        Me.VideoGrabber1.DualDisplay_VideoPortEnabled = False
        Me.VideoGrabber1.DualDisplay_Visible = True
        Me.VideoGrabber1.DualDisplay_Width = 1280
        Me.VideoGrabber1.DVDateTimeEnabled = True
        Me.VideoGrabber1.DVDiscontinuityMinimumInterval = 3
        Me.VideoGrabber1.DVDTitle = 0
        Me.VideoGrabber1.DVEncoder_VideoFormat = VidGrab.TDVVideoFormat.dvf_DVSD
        Me.VideoGrabber1.DVEncoder_VideoResolution = VidGrab.TDVSize.dv_Full
        Me.VideoGrabber1.DVEncoder_VideoStandard = VidGrab.TDVVideoStandard.dvs_Default
        Me.VideoGrabber1.DVRecordingInNativeFormatSeparatesStreams = False
        Me.VideoGrabber1.DVReduceFrameRate = False
        Me.VideoGrabber1.DVRgb219 = False
        Me.VideoGrabber1.DVTimeCodeEnabled = False
        Me.VideoGrabber1.EventNotificationSynchrone = True
        Me.VideoGrabber1.ExtraDLLPath = ""
        Me.VideoGrabber1.FixFlickerOrBlackCapture = False
        Me.VideoGrabber1.FrameCaptureHeight = -1
        Me.VideoGrabber1.FrameCaptureWidth = -1
        Me.VideoGrabber1.FrameCaptureWithoutOverlay = False
        Me.VideoGrabber1.FrameCaptureZoomSize = 100
        Me.VideoGrabber1.FrameGrabber = VidGrab.TFrameGrabber.fg_BothStreams
        Me.VideoGrabber1.FrameGrabberRGBFormat = VidGrab.TFrameGrabberRGBFormat.fgf_Default
        Me.VideoGrabber1.FrameNumberStartsFromZero = False
        Me.VideoGrabber1.FrameRate = 0R
        Me.VideoGrabber1.FrameRateDivider = 0
        Me.VideoGrabber1.GetLastFrameWaitTimeoutMs = 0
        Me.VideoGrabber1.HoldRecording = False
        Me.VideoGrabber1.ImageOverlay_AlphaBlend = False
        Me.VideoGrabber1.ImageOverlay_AlphaBlendValue = 180
        Me.VideoGrabber1.ImageOverlay_ChromaKey = False
        Me.VideoGrabber1.ImageOverlay_ChromaKeyLeewayPercent = 25
        Me.VideoGrabber1.ImageOverlay_ChromaKeyRGBColor = 0
        Me.VideoGrabber1.ImageOverlay_Height = -1
        Me.VideoGrabber1.ImageOverlay_LeftLocation = 10
        Me.VideoGrabber1.ImageOverlay_RotationAngle = 0R
        Me.VideoGrabber1.ImageOverlay_StretchToVideoSize = False
        Me.VideoGrabber1.ImageOverlay_TargetDisplay = -1
        Me.VideoGrabber1.ImageOverlay_TopLocation = 10
        Me.VideoGrabber1.ImageOverlay_Transparent = False
        Me.VideoGrabber1.ImageOverlay_TransparentColorValue = 0
        Me.VideoGrabber1.ImageOverlay_UseTransparentColor = False
        Me.VideoGrabber1.ImageOverlay_VideoAlignment = VidGrab.TVideoAlignment.oa_LeftTop
        Me.VideoGrabber1.ImageOverlay_Width = -1
        Me.VideoGrabber1.ImageOverlayEnabled = False
        Me.VideoGrabber1.ImageOverlaySelector = 0
        Me.VideoGrabber1.IPCameraURL = ""
        Me.VideoGrabber1.JPEGPerformance = VidGrab.TJPEGPerformance.jpBestQuality
        Me.VideoGrabber1.JPEGProgressiveDisplay = False
        Me.VideoGrabber1.JPEGQuality = 100
        Me.VideoGrabber1.LicenseString = "N/A"
        Me.VideoGrabber1.Location = New System.Drawing.Point(288, 391)
        Me.VideoGrabber1.LogoDisplayed = False
        Me.VideoGrabber1.LogoLayout = VidGrab.TLogoLayout.lg_Stretched
        Me.VideoGrabber1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.VideoGrabber1.MixAudioSamples_CurrentSourceLevel = 100
        Me.VideoGrabber1.MixAudioSamples_ExternalSourceLevel = 100
        Me.VideoGrabber1.Mixer_MosaicColumns = 1
        Me.VideoGrabber1.Mixer_MosaicLines = 1
        Me.VideoGrabber1.MotionDetector_CompareBlue = True
        Me.VideoGrabber1.MotionDetector_CompareGreen = True
        Me.VideoGrabber1.MotionDetector_CompareRed = True
        Me.VideoGrabber1.MotionDetector_Enabled = False
        Me.VideoGrabber1.MotionDetector_GreyScale = False
        Me.VideoGrabber1.MotionDetector_Grid = "5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555" &
    "555555 5555555555 5555555555"
        Me.VideoGrabber1.MotionDetector_MaxDetectionsPerSecond = 0R
        Me.VideoGrabber1.MotionDetector_ReduceCPULoad = 1
        Me.VideoGrabber1.MotionDetector_ReduceVideoNoise = False
        Me.VideoGrabber1.MotionDetector_Triggered = False
        Me.VideoGrabber1.MouseWheelEventEnabled = True
        Me.VideoGrabber1.MpegStreamType = VidGrab.TMpegStreamType.mpst_Default
        Me.VideoGrabber1.MultiplexedInputEmulation = True
        Me.VideoGrabber1.MultiplexedRole = VidGrab.TMultiplexedRole.mr_NotMultiplexed
        Me.VideoGrabber1.MultiplexedStabilizationDelay = 100
        Me.VideoGrabber1.MultiplexedSwitchDelay = 0
        Me.VideoGrabber1.Multiplexer = -1
        Me.VideoGrabber1.MuteAudioRendering = False
        Me.VideoGrabber1.Name = "VideoGrabber1"
        Me.VideoGrabber1.NDIBandwidthType = VidGrab.TNDIBandwidthType.nbt_HighestBandwidth
        Me.VideoGrabber1.NDIGroups = ""
        Me.VideoGrabber1.NDIName = "DATASTEAD_UNNAMED_SOURCE"
        Me.VideoGrabber1.NDIReceiveTimeoutMs = 5000
        Me.VideoGrabber1.NetworkStreaming = VidGrab.TNetworkStreaming.ns_Disabled
        Me.VideoGrabber1.NetworkStreamingType = VidGrab.TNetworkStreamingType.nst_AudioVideoStreaming
        Me.VideoGrabber1.NormalCursor = VidGrab.TCursors.cr_Default
        Me.VideoGrabber1.NotificationMethod = VidGrab.TNotificationMethod.nm_Thread
        Me.VideoGrabber1.NotificationPriority = VidGrab.TThreadPriority.tpNormal
        Me.VideoGrabber1.NotificationSleepTime = -1
        Me.VideoGrabber1.OnFrameBitmapEventSynchrone = False
        Me.VideoGrabber1.OpenURLAsync = True
        Me.VideoGrabber1.OverlayAfterTransform = False
        Me.VideoGrabber1.OwnerObject = Nothing
        Me.VideoGrabber1.PlayerAudioRendering = True
        Me.VideoGrabber1.PlayerDuration = CType(1, Long)
        Me.VideoGrabber1.PlayerDVSize = VidGrab.TDVSize.dv_Full
        Me.VideoGrabber1.PlayerFastSeekSpeedRatio = 4
        Me.VideoGrabber1.PlayerFileName = ""
        Me.VideoGrabber1.PlayerForcedCodec = ""
        Me.VideoGrabber1.PlayerFramePosition = CType(1, Long)
        Me.VideoGrabber1.PlayerHwAccel = VidGrab.THwAccel.hw_None
        Me.VideoGrabber1.PlayerRefreshPausedDisplay = False
        Me.VideoGrabber1.PlayerRefreshPausedDisplayFrameRate = 0R
        Me.VideoGrabber1.PlayerSpeedRatio = 1.0R
        Me.VideoGrabber1.PlayerSpeedRatioConstantAudioPitch = True
        Me.VideoGrabber1.PlayerTimePosition = CType(0, Long)
        Me.VideoGrabber1.PlayerTrackBarSynchrone = False
        Me.VideoGrabber1.PlaylistIndex = 0
        Me.VideoGrabber1.PreallocCapFileCopiedAfterRecording = True
        Me.VideoGrabber1.PreallocCapFileEnabled = False
        Me.VideoGrabber1.PreallocCapFileName = ""
        Me.VideoGrabber1.PreallocCapFileSizeInMB = 100
        Me.VideoGrabber1.PreviewZoomSize = 100
        Me.VideoGrabber1.QuickDeviceInitialization = False
        Me.VideoGrabber1.RawAudioSampleCapture = False
        Me.VideoGrabber1.RawCaptureAsyncEvent = True
        Me.VideoGrabber1.RawSampleCaptureLocation = VidGrab.TRawSampleCaptureLocation.rl_SourceFormat
        Me.VideoGrabber1.RawVideoSampleCapture = False
        Me.VideoGrabber1.RecordingAudioBitRate = -1
        Me.VideoGrabber1.RecordingBacktimedFramesCount = 0
        Me.VideoGrabber1.RecordingCanPause = False
        Me.VideoGrabber1.RecordingFileName = ""
        Me.VideoGrabber1.RecordingFileSizeMaxInMB = 0
        Me.VideoGrabber1.RecordingInNativeFormat = True
        Me.VideoGrabber1.RecordingMethod = VidGrab.TRecordingMethod.rm_AVI
        Me.VideoGrabber1.RecordingOnMotion_Enabled = False
        Me.VideoGrabber1.RecordingOnMotion_MotionThreshold = 0R
        Me.VideoGrabber1.RecordingOnMotion_NoMotionPauseDelayMs = 5000
        Me.VideoGrabber1.RecordingPauseCreatesNewFile = False
        Me.VideoGrabber1.RecordingSize = VidGrab.TRecordingSize.rs_Default
        Me.VideoGrabber1.RecordingTimer = VidGrab.TRecordingTimer.rt_Disabled
        Me.VideoGrabber1.RecordingTimerInterval = 60
        Me.VideoGrabber1.RecordingVideoBitRate = -1
        Me.VideoGrabber1.Reencoding_IncludeAudioStream = True
        Me.VideoGrabber1.Reencoding_IncludeVideoStream = True
        Me.VideoGrabber1.Reencoding_Method = VidGrab.TRecordingMethod.rm_ASF
        Me.VideoGrabber1.Reencoding_NewVideoClip = ""
        Me.VideoGrabber1.Reencoding_SourceVideoClip = ""
        Me.VideoGrabber1.Reencoding_StartFrame = CType(-1, Long)
        Me.VideoGrabber1.Reencoding_StartTime = CType(-1, Long)
        Me.VideoGrabber1.Reencoding_StopFrame = CType(-1, Long)
        Me.VideoGrabber1.Reencoding_StopTime = CType(-1, Long)
        Me.VideoGrabber1.Reencoding_UseAudioCompressor = False
        Me.VideoGrabber1.Reencoding_UseFrameGrabber = True
        Me.VideoGrabber1.Reencoding_UseVideoCompressor = False
        Me.VideoGrabber1.Reencoding_WMVOutput = False
        Me.VideoGrabber1.ScreenRecordingLayeredWindows = False
        Me.VideoGrabber1.ScreenRecordingMonitor = 0
        Me.VideoGrabber1.ScreenRecordingNonVisibleWindows = False
        Me.VideoGrabber1.ScreenRecordingSizePercent = 100
        Me.VideoGrabber1.ScreenRecordingThroughClipboard = False
        Me.VideoGrabber1.ScreenRecordingWithCursor = True
        Me.VideoGrabber1.SendToDV_DeviceIndex = -1
        Me.VideoGrabber1.Size = New System.Drawing.Size(718, 404)
        Me.VideoGrabber1.SpeakerBalance = 0
        Me.VideoGrabber1.SpeakerControl = False
        Me.VideoGrabber1.SpeakerVolume = 65535
        Me.VideoGrabber1.StoragePath = "C:\Users\Michel_2\AppData\Local\Temp\"
        Me.VideoGrabber1.StoreDeviceSettingsInRegistry = True
        Me.VideoGrabber1.StreamInterface_Format = "mpegts"
        Me.VideoGrabber1.StreamInterface_FrameRate = 0R
        Me.VideoGrabber1.StreamInterface_IsRealTime = True
        Me.VideoGrabber1.SyncCommands = True
        Me.VideoGrabber1.SynchronizationRole = VidGrab.TSynchronizationRole.sr_Master
        Me.VideoGrabber1.Synchronized = False
        Me.VideoGrabber1.SyncPreview = VidGrab.TSyncPreview.sp_Auto
        Me.VideoGrabber1.TabIndex = 20
        Me.VideoGrabber1.TextOverlay_Align = VidGrab.TTextOverlayAlign.tf_Left
        Me.VideoGrabber1.TextOverlay_AlphaBlend = False
        Me.VideoGrabber1.TextOverlay_AlphaBlendValue = 180
        Me.VideoGrabber1.TextOverlay_BkColor = 16777215
        Me.VideoGrabber1.TextOverlay_Enabled = False
        'TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
        Me.VideoGrabber1.TextOverlay_FontColor = 16776960
        Me.VideoGrabber1.TextOverlay_FontSize = 12
        Me.VideoGrabber1.TextOverlay_GradientColor = 8388608
        Me.VideoGrabber1.TextOverlay_GradientMode = VidGrab.TTextOverlayGradientMode.gm_Disabled
        Me.VideoGrabber1.TextOverlay_HighResFont = True
        Me.VideoGrabber1.TextOverlay_Left = 0
        Me.VideoGrabber1.TextOverlay_Orientation = VidGrab.TTextOrientation.to_Horizontal
        Me.VideoGrabber1.TextOverlay_Right = -1
        Me.VideoGrabber1.TextOverlay_Scrolling = False
        Me.VideoGrabber1.TextOverlay_ScrollingSpeed = 1
        Me.VideoGrabber1.TextOverlay_Selector = 0
        Me.VideoGrabber1.TextOverlay_Shadow = True
        Me.VideoGrabber1.TextOverlay_ShadowColor = 0
        Me.VideoGrabber1.TextOverlay_ShadowDirection = VidGrab.TCardinalDirection.cd_SouthEast
        Me.VideoGrabber1.TextOverlay_String = resources.GetString("VideoGrabber1.TextOverlay_String")
        Me.VideoGrabber1.TextOverlay_TargetDisplay = -1
        Me.VideoGrabber1.TextOverlay_Top = 0
        Me.VideoGrabber1.TextOverlay_Transparent = True
        Me.VideoGrabber1.TextOverlay_VideoAlignment = VidGrab.TVideoAlignment.oa_LeftTop
        Me.VideoGrabber1.ThirdPartyDeinterlacer = ""
        Me.VideoGrabber1.TranslateMouseCoordinates = True
        Me.VideoGrabber1.TunerFrequency = -1
        Me.VideoGrabber1.TunerMode = VidGrab.TTunerMode.tm_TVTuner
        Me.VideoGrabber1.TVChannel = 0
        Me.VideoGrabber1.TVCountryCode = 0
        Me.VideoGrabber1.TVTunerInputType = VidGrab.TTunerInputType.TunerInputCable
        Me.VideoGrabber1.TVUseFrequencyOverrides = False
        Me.VideoGrabber1.UseClock = True
        Me.VideoGrabber1.v360_AspectRatio = 0R
        Me.VideoGrabber1.v360_Enabled = False
        Me.VideoGrabber1.v360_MasterAngle = VidGrab.Tv360_Angle.v360_fov_Horizontal
        Me.VideoGrabber1.v360_MouseAction = VidGrab.TV360_MouseAction.ma_MouseMove
        Me.VideoGrabber1.v360_MouseActionPercent = 10
        Me.VideoGrabber1.VCRHorizontalLocking = False
        Me.VideoGrabber1.Version = "v15.2.4.6 (build 4470.221020) - Copyright (c)2022 Datastead"
        Me.VideoGrabber1.VideoCompression_DataRate = -1
        Me.VideoGrabber1.VideoCompression_KeyFrameRate = 15
        Me.VideoGrabber1.VideoCompression_PFramesPerKeyFrame = 0
        Me.VideoGrabber1.VideoCompression_Quality = 1.0R
        Me.VideoGrabber1.VideoCompression_WindowSize = -1
        Me.VideoGrabber1.VideoCompressor = 0
        Me.VideoGrabber1.VideoControlSettings = True
        Me.VideoGrabber1.VideoCursor = VidGrab.TCursors.cr_Default
        Me.VideoGrabber1.VideoDelay = CType(0, Long)
        Me.VideoGrabber1.VideoDevice = -1
        Me.VideoGrabber1.VideoFormat = -1
        Me.VideoGrabber1.VideoFromImages_BitmapsSortedBy = VidGrab.TFileSort.fs_TimeAsc
        Me.VideoGrabber1.VideoFromImages_RepeatIndefinitely = False
        Me.VideoGrabber1.VideoFromImages_SourceDirectory = "C:\Users\Michel_2\AppData\Local\Temp\"
        Me.VideoGrabber1.VideoFromImages_TemporaryFile = "SetOfBitmaps01.dat"
        Me.VideoGrabber1.VideoInput = -1
        Me.VideoGrabber1.VideoProcessing_Brightness = 0
        Me.VideoGrabber1.VideoProcessing_Contrast = 0
        Me.VideoGrabber1.VideoProcessing_Deinterlacing = VidGrab.TVideoDeinterlacing.di_Disabled
        Me.VideoGrabber1.VideoProcessing_FlipHorizontal = False
        Me.VideoGrabber1.VideoProcessing_FlipVertical = False
        Me.VideoGrabber1.VideoProcessing_GrayScale = False
        Me.VideoGrabber1.VideoProcessing_Hue = 0
        Me.VideoGrabber1.VideoProcessing_InvertColors = False
        Me.VideoGrabber1.VideoProcessing_Pixellization = 1
        Me.VideoGrabber1.VideoProcessing_Rotation = VidGrab.TVideoRotation.rt_0_deg
        Me.VideoGrabber1.VideoProcessing_RotationCustomAngle = 45.5R
        Me.VideoGrabber1.VideoProcessing_Saturation = 0
        Me.VideoGrabber1.VideoQualitySettings = True
        Me.VideoGrabber1.VideoRenderer = VidGrab.TVideoRenderer.vr_AutoSelect
        Me.VideoGrabber1.VideoRendererExternal = VidGrab.TVideoRendererExternal.vre_None
        Me.VideoGrabber1.VideoRendererExternalIndex = -1
        Me.VideoGrabber1.VideoRendererPriority = VidGrab.TVideoRendererPriority.vrp_Auto
        Me.VideoGrabber1.VideoSize = -1
        Me.VideoGrabber1.VideoSource = VidGrab.TVideoSource.vs_VideoCaptureDevice
        Me.VideoGrabber1.VideoSource_FileOrURL = ""
        Me.VideoGrabber1.VideoSource_FileOrURL_StartTime = CType(-1, Long)
        Me.VideoGrabber1.VideoSource_FileOrURL_StopTime = CType(-1, Long)
        Me.VideoGrabber1.VideoStreamNumber = -1
        Me.VideoGrabber1.VideoSubtype = -1
        Me.VideoGrabber1.VideoVisibleWhenStopped = False
        Me.VideoGrabber1.VirtualAudioStreamControl = -1
        Me.VideoGrabber1.VirtualVideoStreamControl = -1
        Me.VideoGrabber1.VuMeter = VidGrab.TVuMeter.vu_Disabled
        Me.VideoGrabber1.WebcamStillCaptureButton = VidGrab.TWebcamStillCaptureButton.wb_Disabled
        Me.VideoGrabber1.ZoomCoeff = 1000
        Me.VideoGrabber1.ZoomXCenter = 0
        Me.VideoGrabber1.ZoomYCenter = 0
        '
        'MainForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.ClientSize = New System.Drawing.Size(1276, 802)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.tbrZoomY)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.tbrZoomX)
        Me.Controls.Add(Me.tbrZoom)
        Me.Controls.Add(Me.AutoSizeInfo)
        Me.Controls.Add(Me.chkPlayerTrackBarSynchrone)
        Me.Controls.Add(Me.gbPlayerControl)
        Me.Controls.Add(Me.tbcTabs)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.VideoGrabber1)
        Me.Controls.Add(Me.mmoLog)
        Me.Controls.Add(Me.edtAdditionalInfo)
        Me.Controls.Add(Me.edtFrameCount)
        Me.Controls.Add(Me.edtStoragePath)
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(11, 30)
        Me.Menu = Me.MainMenu1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataStead Software - TVideoGrabber demo"
        Me.tbcTabs.ResumeLayout(False)
        Me.gbPlayerControl.ResumeLayout(False)
        CType(Me.tbrPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrZoomY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrZoomX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrZoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
#Region "Create MainForm default instance"
    Private Shared m_vb6FormDefInstance As MainForm
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As MainForm
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New MainForm
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As MainForm)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region

    Public Class FreeHandDrawing
        Public Const CMAXCOORDINATESARRAY As Short = 5000
        Public MAXCOORDINATESARRAY As Short = CMAXCOORDINATESARRAY
        Public DrawingEnabled As Boolean = False
        Public iArrayCoordinates As Integer = 0
        Public ArrayCoordinates(CMAXCOORDINATESARRAY + 1) As System.Drawing.Rectangle

        Protected Overrides Sub Finalize()
            MyBase.Finalize()
        End Sub
    End Class

    ' used in the image overlay sample, to pickup a transparent color on the video frame at the last mouse click location
    Public Class PickupColor
        Public MustGetRGBPixel As Boolean = False
        Public LastRGBPixelValueAtMousePosition As Long = -1
        Public MouseXVideoPosition As Integer = 0
        Public MouseYVideoPosition As Integer = 0
    End Class


    Public frmOverlays_edtDrawGrid As Long
    Public frmOverlays_btnDrawGridColor As Color
    Public frmOverlays_btnFreeHandColor As Color

    Public VideoProcessing_DetectNoVideoSignal As Boolean
    Public VideoProcessing_DetectConnexantBlueScreen As Boolean

    Public OldVideoSignalState As Boolean


    Public VideoFromImages As VideoFromImagesFileList

    Public cFreeHandDrawing As FreeHandDrawing
    Public cPickupColor As PickupColor

    Private LastKBWrittenReportTime As Double

    Public frmInsetForm As System.Windows.Forms.Form

    Private StartupWidth As Integer
    Private StartupHeight As Integer
    Private iCountPictureBox As Integer


    Public StartupVGWidth As Integer
    Public StartupVGHeight As Integer


    Public frmVideoSource As VideoSource
    Private frmIPCamera As IPCamera
    Private frmAudio As Audio
    Private frmDisplay As Display
    Private frmFrameGrabber As FrameGrabber
    Private frmMotionDetection As MotionDetection
    Private frmNetworkStreaming As NetworkStreaming
    Private frmOverlays As Overlays
    Private frmPlayer As Player
    Public frmRecording As Recording
    Private frmReencoding As Reencoding
    Private frmSnapform As SnapForm
    Private frmVideoProcessing As VideoProcessing
    Private frmMultipurposeEncoder As MultipurposeEncoder


    Public brushMotionRatio As Brush
    Public boolMotionRatio As Boolean


    Private ProcessingNextFrameNeeded As Boolean = False

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        VideoFromImages = New VideoFromImagesFileList

        iCountPictureBox = 0

        StartupWidth = Width
        StartupHeight = Height


        frmOverlays_edtDrawGrid = 0
        frmOverlays_btnDrawGridColor = Color.Blue
        frmOverlays_btnFreeHandColor = Color.Red

        StartupVGWidth = VideoGrabber1.Width
        StartupVGHeight = VideoGrabber1.Height

        VideoGrabber1.StoragePath = System.IO.Directory.GetCurrentDirectory()
        VideoGrabber1.Display_AspectRatio = VidGrab.TAspectRatio.ar_Box ' preserves the display aspect ratio
        VideoGrabber1.AutoRefreshPreview = True ' the preview will restart automatically when changing device properties (e.g. video size, analog video standard, etc...)

        edtStoragePath.Text = VideoGrabber1.StoragePath

        cFreeHandDrawing = New FreeHandDrawing
        cPickupColor = New PickupColor

        LastKBWrittenReportTime = 0

        frmVideoSource = New VideoSource
        frmIPCamera = New IPCamera
        frmAudio = New Audio
        frmDisplay = New Display
        frmFrameGrabber = New FrameGrabber
        frmMotionDetection = New MotionDetection
        frmMultipurposeEncoder = New MultipurposeEncoder
        frmNetworkStreaming = New NetworkStreaming
        frmOverlays = New Overlays
        frmPlayer = New Player
        frmRecording = New Recording
        frmReencoding = New Reencoding
        frmSnapform = New SnapForm
        frmVideoProcessing = New VideoProcessing

        AddHandler frmVideoSource.FormClosing, AddressOf SubFormClosing
        AddHandler frmIPCamera.FormClosing, AddressOf SubFormClosing
        AddHandler frmAudio.FormClosing, AddressOf SubFormClosing
        AddHandler frmDisplay.FormClosing, AddressOf SubFormClosing
        AddHandler frmFrameGrabber.FormClosing, AddressOf SubFormClosing
        AddHandler frmMotionDetection.FormClosing, AddressOf SubFormClosing
        AddHandler frmMultipurposeEncoder.FormClosing, AddressOf SubFormClosing
        AddHandler frmNetworkStreaming.FormClosing, AddressOf SubFormClosing
        AddHandler frmOverlays.FormClosing, AddressOf SubFormClosing
        AddHandler frmPlayer.FormClosing, AddressOf SubFormClosing
        AddHandler frmRecording.FormClosing, AddressOf SubFormClosing
        AddHandler frmReencoding.FormClosing, AddressOf SubFormClosing
        AddHandler frmVideoProcessing.FormClosing, AddressOf SubFormClosing

        RefreshControls()


        tbcTabs.SelectedTab = tbpVideoSource
        SelectInsetForm(tbcTabs)


    End Sub

    Private Sub SubFormClosing(sender As Object, e As FormClosingEventArgs)
        e.Cancel = True
    End Sub

    Public Sub RefreshControls()
        frmVideoSource.RefreshControls()
        frmIPCamera.RefreshControls()
        frmAudio.RefreshControls()
        frmDisplay.RefreshControls()
        frmFrameGrabber.RefreshControls()
        frmMotionDetection.RefreshControls()
        frmNetworkStreaming.RefreshControls()
        frmOverlays.RefreshControls()
        frmPlayer.RefreshControls()
        frmRecording.RefreshControls()
        frmReencoding.RefreshControls()
        frmVideoProcessing.RefreshControls()
        frmMultipurposeEncoder.RefreshControls()
    End Sub

    Private Sub tbcTabs_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbcTabs.SelectedIndexChanged
        SelectInsetForm(tbcTabs)
    End Sub

    Private Sub SelectInsetForm(ByVal Tabs As TabControl)

        If Not frmInsetForm Is Nothing Then
            frmInsetForm.Close()
        End If

        Select Case Tabs.SelectedTab.Name
            Case "tbpVideoSource"
                frmInsetForm = frmVideoSource
            Case "tbpIPCameras"
                frmInsetForm = frmIPCamera
            Case "tbpAudio"
                frmInsetForm = frmAudio
            Case "tbpRecording"
                frmInsetForm = frmRecording
            Case "tbpMultipurposeEncoder"
                frmInsetForm = frmMultipurposeEncoder
            Case "tbpNetworkStreaming"
                frmInsetForm = frmNetworkStreaming
            Case "tbpPlayer"
                frmInsetForm = frmPlayer
            Case "tbpFrameGrabber"
                frmInsetForm = frmFrameGrabber
            Case "tbpMotionDetection"
                frmInsetForm = frmMotionDetection
            Case "tbpOverlays"
                frmInsetForm = frmOverlays
            Case "tbpVideoProcessing"
                frmInsetForm = frmVideoProcessing
            Case "tbpDisplay"
                frmInsetForm = frmDisplay
            Case "tbpReencoding"
                frmInsetForm = frmReencoding
        End Select

        If Not frmInsetForm Is Nothing Then
            InsetForms.InsetForm(frmInsetForm, Tabs.SelectedTab.Handle)
            frmInsetForm.Show()
        End If

    End Sub



    Public Sub SetEnumerateWindows(ByVal WindowName As String, ByVal ExactMatch As Boolean)
        ReDim wenScreenRecordingWindow(0)
        lngScreenRecordingWindow = 0
        strScreenRecordingWindow = WindowName
        boolScreenRecordingWindow = ExactMatch
        If strScreenRecordingWindow = "" Then
            frmVideoSource.lblEnumerateWindows.Text = ""
        Else
            frmVideoSource.lblEnumerateWindows.Text = CStr(lngScreenRecordingWindow)
        End If
    End Sub

    Private Sub VideoGrabber1_OnEnumerateWindows(ByVal sender As Object, ByVal e As VidGrab.TOnEnumerateWindowsEventArgs) Handles VideoGrabber1.OnEnumerateWindows
        ' EnumerateWindows begins gathering of visible windows
        ' Demo proc SetEnumerateWindows initializes array wenScreenRecordingWindow(),
        '  called in OnRecordingReadyToStart event, which is instigated by
        '  enabling HoldRecording before calling StartRecording
        '  (see btnStartRecordingControlled in Recording form)
        Dim b As Boolean
        If (LCase(strScreenRecordingWindow) = LCase(e.windowName)) Then
            b = True
        ElseIf (Not boolScreenRecordingWindow) And InStr(1, LCase(e.windowName), LCase(strScreenRecordingWindow)) > 0 Then
            b = True
        Else
            b = False
        End If
        If b Then
            ReDim Preserve wenScreenRecordingWindow(lngScreenRecordingWindow)
            With wenScreenRecordingWindow(lngScreenRecordingWindow)
                .WindowHandle = e.windowHandle
                .WindowClass = e.windowClass
                .WindowName = e.windowName
            End With
            lngScreenRecordingWindow = lngScreenRecordingWindow + 1

            frmVideoSource.lblEnumerateWindows.Text = CStr(lngScreenRecordingWindow)

        End If
    End Sub


    Private Sub VideoGrabber1_OnVideoDeviceSelected(ByVal sender As Object, ByVal e As System.EventArgs) Handles VideoGrabber1.OnVideoDeviceSelected
        RefreshControls() ' updates all the ComboBox lists and controls, especially those that depend of the video capture device (like VideoInputs, VideoSubtypes, etc...)
    End Sub

    Private Sub VideoGrabber1_OnAudioDeviceSelected(ByVal sender As Object, ByVal e As System.EventArgs) Handles VideoGrabber1.OnAudioDeviceSelected
        RefreshControls() ' updates all the ComboBox lists and controls, especially those that depend of the audio capture device (like AudioInputs, etc...)
    End Sub


    Private Sub VideoGrabber1_OnFrameBitmap(ByVal sender As System.Object, ByVal e As VidGrab.TOnFrameBitmapEventArgs) Handles VideoGrabber1.OnFrameBitmap

        ' please read the (*) comment at the bottom of this page

#If VS2003 Then
        Dim FrameInfo As VidGrab.TFrameInfo = CType(Marshal.PtrToStructure(New IntPtr(CType(e.frameInfo.ToString(), Integer)), GetType(VidGrab.TFrameInfo)), VidGrab.TFrameInfo)
        Dim FrameBitmap As VidGrab.TFrameBitmapInfo = CType(Marshal.PtrToStructure(New IntPtr(CType(e.bitmapInfo.ToString(), Integer)), GetType(VidGrab.TFrameBitmapInfo)), VidGrab.TFrameBitmapInfo)
#Else
        Dim FrameInfo As VidGrab.TFrameInfo = CType(Marshal.PtrToStructure(CType(e.frameInfo, IntPtr), GetType(VidGrab.TFrameInfo)), VidGrab.TFrameInfo)
        Dim FrameBitmap As VidGrab.TFrameBitmapInfo = CType(Marshal.PtrToStructure(CType(e.bitmapInfo, IntPtr), GetType(VidGrab.TFrameBitmapInfo)), VidGrab.TFrameBitmapInfo)
#End If


        ' -----------------------------------------------------------
        ' CopyFrameToBitmapDemo(FrameBitmap);  // CopyFrameToBitmapDemo shows how to make a copy of the current video frame, just uncomment this line to use it
        ' -----------------------------------------------------------

        ' GRID DRAWING
        ' ============

        If frmOverlays_edtDrawGrid > 1 Then

            Dim MyGraphics As Graphics = Graphics.FromHdcInternal(FrameBitmap.bitmapDC)
            Dim b As SolidBrush = New SolidBrush(frmOverlays_btnDrawGridColor)

            Dim VideoGrabberWidth As Integer = VideoGrabber1.VideoWidth
            Dim VideoGrabberHeight As Integer = VideoGrabber1.VideoHeight

            Dim xStep As Integer = CType(VideoGrabberWidth / frmOverlays_edtDrawGrid, Integer)
            Dim yStep As Integer = xStep

            Dim xLocation As Integer = xStep
            Dim yLocation As Integer = yStep

            While xLocation < VideoGrabberWidth
                MyGraphics.FillRectangle(b, xLocation, 0, 1, VideoGrabberHeight)
                xLocation += xStep
            End While

            While yLocation < VideoGrabberHeight
                MyGraphics.FillRectangle(b, 0, yLocation, VideoGrabberWidth, 1)
                yLocation += yStep
            End While

            MyGraphics.Dispose()
        End If

        ' FREE HAND DRAWING
        ' ============

        If cFreeHandDrawing.iArrayCoordinates > 0 Then ' see the VideoGrabberMouse... events

            Dim MyGraphics As Graphics = Graphics.FromHdcInternal(FrameBitmap.bitmapDC)
            Dim p As Pen = New Pen(frmOverlays_btnFreeHandColor)
            Dim b As SolidBrush = New SolidBrush(frmOverlays_btnFreeHandColor)

            Dim LastX As Integer = 0
            Dim LastY As Integer = 0
            Dim i As Integer

            For i = 0 To cFreeHandDrawing.iArrayCoordinates - 1
                If cFreeHandDrawing.ArrayCoordinates(i).Width = 0 Then '// Width is used as boolean to know if it is a MoveTo or a LineTo
                    LastX = cFreeHandDrawing.ArrayCoordinates(i).X
                    LastY = cFreeHandDrawing.ArrayCoordinates(i).Y
                    MyGraphics.FillRectangle(b, LastX, LastY, 1, 1)
                Else
                    MyGraphics.DrawLine(p, LastX, LastY, cFreeHandDrawing.ArrayCoordinates(i).X, cFreeHandDrawing.ArrayCoordinates(i).Y)
                    LastX = cFreeHandDrawing.ArrayCoordinates(i).X
                    LastY = cFreeHandDrawing.ArrayCoordinates(i).Y
                End If
            Next

            MyGraphics.Dispose()

        End If

        ' VIDEO SIGNAL DETECTION
        ' ============

        Dim NewVideoSignalState As Boolean

        NewVideoSignalState = OldVideoSignalState

        If VideoProcessing_DetectNoVideoSignal Then
            NewVideoSignalState = VideoGrabber1.IsVideoSignalDetected(False, True, 30, 30, 30, True)
        ElseIf VideoProcessing_DetectConnexantBlueScreen Then
            NewVideoSignalState = VideoGrabber1.IsVideoSignalDetected(True, False, 0, 0, 0, False)
        End If

        If NewVideoSignalState <> OldVideoSignalState Then
            OldVideoSignalState = NewVideoSignalState
            If NewVideoSignalState Then
                AddLog(mmoLog, "Video signal is back")
            Else
                AddLog(mmoLog, "VIDEO SIGNAL LOST")
            End If
        End If


        ' used in the image overlay sample, to pickup a transparent color on the video frame at the last mouse click location
        If cPickupColor.MustGetRGBPixel Then
            cPickupColor.MustGetRGBPixel = False
            cPickupColor.LastRGBPixelValueAtMousePosition = VideoGrabber1.GetRGBPixelAt(cPickupColor.MouseXVideoPosition, cPickupColor.MouseYVideoPosition)
        End If
    End Sub

    Private Sub VideoGrabber1_OnFrameProgress2(ByVal sender As System.Object, ByVal e As VidGrab.TOnFrameProgress2EventArgs) Handles VideoGrabber1.OnFrameProgress2

#If VS2003 Then
        Dim FrameInfo As VidGrab.TFrameInfo = CType(Marshal.PtrToStructure(New IntPtr(CType(e.frameInfo.ToString(), Integer)), GetType(VidGrab.TFrameInfo)), VidGrab.TFrameInfo)
#Else
        Dim FrameInfo As VidGrab.TFrameInfo = CType(Marshal.PtrToStructure(CType(e.frameInfo, IntPtr), GetType(VidGrab.TFrameInfo)), VidGrab.TFrameInfo)
#End If

        If FrameInfo.currentState = VidGrab.TCurrentState.cs_Playback Then ' we don't include the dropped frames during playback
            edtFrameCount.Text = String.Format("frame: {0} time:{1:00}:{2:00}:{3:00}:{4:00}", FrameInfo.frameNumber, FrameInfo.frameTime_Hour, FrameInfo.frameTime_Min, FrameInfo.frameTime_Sec, FrameInfo.frameTime_Hs)
        Else
            edtFrameCount.Text = String.Format("frame: {0} dropped:{1} time:{2:00}:{3:00}:{4:00}:{5:00}", FrameInfo.frameNumber, FrameInfo.droppedFrameCount, FrameInfo.frameTime_Hour, FrameInfo.frameTime_Min, FrameInfo.frameTime_Sec, FrameInfo.frameTime_Hs)
        End If

        If (FrameInfo.NTPFrameTime > 0) Then
            edtAdditionalInfo.Text = String.Format("ntp frame time (100ns): {0}", FrameInfo.NTPFrameTime)
        End If

        If VideoGrabber1.CurrentState = VidGrab.TCurrentState.cs_Recording Then
            If (FrameInfo.frameTime - LastKBWrittenReportTime) > 50000000 Then  ' every 5 seconds
                LastKBWrittenReportTime = FrameInfo.frameTime
                AddLog(mmoLog, "written to disk: " & VideoGrabber1.RecordingKBytesWrittenToDisk.ToString() & " KB")
            End If
        End If

    End Sub

    Private Sub VideoGrabber1_OnFrameCaptureCompleted(ByVal sender As Object, ByVal e As VidGrab.TOnFrameCaptureCompletedEventArgs) Handles VideoGrabber1.OnFrameCaptureCompleted
        If e.success Then
            AddLog((frmFrameGrabber.mmoFrameCaptureLog), "frame #" & e.frameNumber.ToString & " captured")
        End If

        Select Case e.destType
            '______ bmp or jpeg file
            Case VidGrab.TFrameCaptureDest.fc_JpegFile, VidGrab.TFrameCaptureDest.fc_BmpFile
                If e.success Then
                    AddLog((frmFrameGrabber.mmoFrameCaptureLog), e.fileName)
                Else
                    AddLog((frmFrameGrabber.mmoFrameCaptureLog), "error: failed to create " & e.fileName)
                End If

                '______ memory bitmap
            Case VidGrab.TFrameCaptureDest.fc_TBitmap
                If frmSnapform.IsDisposed Then
                    frmSnapform = New SnapForm()
                End If
                If Not frmSnapform.Visible Then
                    frmSnapform.Show()
                End If
                If Not frmSnapform.SnapImage.Image Is Nothing Then
                    frmSnapform.SnapImage.Image.Dispose()
                End If
                frmSnapform.SnapImage.Image = Image.FromHbitmap(e.frameBitmapHandle)
        End Select
    End Sub

    Private Sub VideoGrabber1_OnCopyPreallocDataCompleted(ByVal sender As Object, ByVal e As VidGrab.TOnSourceFileToDestFileCompletedEventArgs) Handles VideoGrabber1.OnCopyPreallocDataCompleted
        If e.success Then
            AddLog(mmoLog, " successfully copied to " & e.destFile & ".")
        Else
            AddLog(mmoLog, "ERROR: Failed to copy " & e.sourceFile & " to " & e.destFile & "!")
        End If
    End Sub

    Private Sub VideoGrabber1_OnCopyPreallocDataProgress(ByVal sender As Object, ByVal e As VidGrab.TOnProgressEventArgs) Handles VideoGrabber1.OnCopyPreallocDataProgress
        AddLog(mmoLog, "copying data: " & e.percent.ToString & "% completed.")
    End Sub

    Private Sub VideoGrabber1_OnCopyPreallocDataStarted(ByVal sender As Object, ByVal e As VidGrab.TOnSourceFileToDestFileStartedEventArgs) Handles VideoGrabber1.OnCopyPreallocDataStarted
        AddLog(mmoLog, "copying data from " & e.sourceFile & " to " & e.destFile & "...")
    End Sub

    Private Sub VideoGrabber1_OnCreatePreallocFileCompleted(ByVal sender As Object, ByVal e As VidGrab.TOnCreatePreallocatedFileCompletedEventArgs) Handles VideoGrabber1.OnCreatePreallocFileCompleted
        If e.success Then
            AddLog(mmoLog, "preallocated file " & e.fileName & " successfully created.")
        Else
            AddLog(mmoLog, "ERROR: Failed to preallocate " & e.fileName)
        End If
    End Sub

    Private Sub VideoGrabber1_OnCreatePreallocFileProgress(ByVal sender As Object, ByVal e As VidGrab.TOnProgressEventArgs) Handles VideoGrabber1.OnCreatePreallocFileProgress
        AddLog(mmoLog, e.percent.ToString & "% of preallocated file completed")
    End Sub

    Private Sub VideoGrabber1_OnCreatePreallocFileStarted(ByVal sender As Object, ByVal e As VidGrab.TOnFileNotificationEventArgs) Handles VideoGrabber1.OnCreatePreallocFileStarted
        AddLog(mmoLog, "preallocating file " & e.fileName & "...")
    End Sub

    Private Sub VideoGrabber1_OnDeviceArrivalOrRemoval(ByVal sender As Object, ByVal e As VidGrab.TOnDeviceArrivalOrRemovalEventArgs) Handles VideoGrabber1.OnDeviceArrivalOrRemoval
        Dim AudioOrVideoDevice As String

        If e.isVideoDevice Then
            AudioOrVideoDevice = "video device "
        Else
            AudioOrVideoDevice = "audio device "
        End If
        If e.isDeviceArrival Then
            AddLog(mmoLog, AudioOrVideoDevice & " arrival:")
        Else
            AddLog(mmoLog, AudioOrVideoDevice & " removal:")
        End If
        AddLog(mmoLog, e.deviceName)
        If e.isVideoDevice Then
            AssignListToComboBox(frmVideoSource.cboVideoDevices, VideoGrabber1.VideoDevices, VideoGrabber1.VideoDevice)
        Else
            AssignListToComboBox(frmAudio.cboAudioDevices, VideoGrabber1.AudioDevices, VideoGrabber1.AudioDevice)
        End If
    End Sub

    Private Sub VideoGrabber1_OnDeviceLost(ByVal sender As Object, ByVal e As System.EventArgs) Handles VideoGrabber1.OnDeviceLost
        AddLog(mmoLog, "DEVICE LOST!")
        AssignListToComboBox(frmVideoSource.cboVideoDevices, VideoGrabber1.VideoDevices, VideoGrabber1.VideoDevice)
        AssignListToComboBox(frmAudio.cboAudioDevices, VideoGrabber1.AudioDevices, VideoGrabber1.AudioDevice)
    End Sub

    Private Sub VideoGrabber1_OnDirectNetworkStreamingHostUrl(ByVal sender As Object, ByVal e As VidGrab.TOnDirectNetworkStreamingHostUrlEventArgs) Handles VideoGrabber1.OnDirectNetworkStreamingHostUrl
        AddLog(mmoLog, "streaming URL: " & e.hostUrl)
        AddLog(mmoLog, "streaming host: " & e.hostName)
        AddLog(mmoLog, "streaming port: " & e.hostPort.ToString)
    End Sub

    Private Sub VideoGrabber1_OnDiskFull(ByVal sender As Object, ByVal e As System.EventArgs) Handles VideoGrabber1.OnDiskFull
        AddLog(mmoLog, "DISK FULL!")
    End Sub

    Private Sub VideoGrabber1_OnDVCommandCompleted(ByVal sender As Object, ByVal e As VidGrab.TOnDVCommandCompletedEventArgs) Handles VideoGrabber1.OnDVCommandCompleted
        AddLog(mmoLog, "camcorder state: " & e.newStateLabel)
    End Sub

    Private Sub VideoGrabber1_OnDVDiscontinuity(ByVal sender As Object, ByVal e As VidGrab.TOnDVDiscontinuityEventArgs) Handles VideoGrabber1.OnDVDiscontinuity
        ' SAMPLE CODE 1: creates a new file during recording when a discontinuity in the DV date/time is detected (uncommend the 2 lines below)
        ' e.deliverNewFrame = False
        ' VideoGrabber1.RecordToNewFileNow

        ' SAMPLE CODE 2: stops the recording when a discontinuity in the DV date/time is detected (uncommend the 2 lines below)
        ' e.deliverNewFrame = False
        ' VideoGrabber1.Stop

        ' Important: from this event you should not perform any actions with the potential to block, such as
        ' holding a critical section or waiting on another thread. Also, do not call any GDI or USER32.DLL APIs.
    End Sub

    Private Sub VideoGrabber1_OnLog(ByVal sender As Object, ByVal e As VidGrab.TOnLogEventArgs) Handles VideoGrabber1.OnLog
        AddLog(mmoLog, "[" & e.severity & "] " & e.infoMsg)
    End Sub

    Private Sub VideoGrabber1_OnMotionDetected(ByVal sender As Object, ByVal e As VidGrab.TOnMotionDetectedEventArgs) Handles VideoGrabber1.OnMotionDetected
        Dim MaxMotionXLocation As Integer
        Dim MaxMotionYLocation As Integer

        frmMotionDetection.edtMotionRatio.Text = VideoGrabber1.MotionDetector_GlobalMotionRatio.ToString("0.000")

        MotionDetected = True

        frmMotionDetection.edtMaxMotionXY.Text = "x:" & e.maxMotionCellX.ToString & " y:" & e.maxMotionCellY.ToString

        If VideoGrabber1.MotionDetector_GetCellLocation(e.maxMotionCellX, e.maxMotionCellY, MaxMotionXLocation, MaxMotionYLocation) Then ' the 2 last parameters are passed by ref
            frmMotionDetection.edtMaxMotionCoord.Text = "x: " & MaxMotionXLocation.ToString & "  y: " & MaxMotionYLocation.ToString
        End If

        frmMotionDetection.mmoMotionGrid.Text = VideoGrabber1.MotionDetector_Get2DTextMotion

        Dim FrameBitmap As IntPtr = VideoGrabber1.GetLastFrameAsHBITMAP(0, False, 0, 0, 0, 0, frmMotionDetection.imgMotionDetected.Width, frmMotionDetection.imgMotionDetected.Height, 32)
        If Not FrameBitmap.Equals(IntPtr.Zero) Then
            frmMotionDetection.imgMotionDetected.Image = Image.FromHbitmap(FrameBitmap)
            DeleteObject(FrameBitmap)
        End If

    End Sub

    Private Sub VideoGrabber1_OnMotionNotDetected(ByVal sender As Object, ByVal e As VidGrab.TOnMotionNotDetectedEventArgs) Handles VideoGrabber1.OnMotionNotDetected
        frmMotionDetection.edtMotionRatio.Text = ""

        MotionDetected = False

        frmMotionDetection.mmoMotionGrid.Text = VideoGrabber1.MotionDetector_Get2DTextMotion
    End Sub


    Public Property MotionDetected() As Boolean
        Get
            Return boolMotionRatio
        End Get
        Set(ByVal value As Boolean)
            boolMotionRatio = value
            If boolMotionRatio Then
                brushMotionRatio = Brushes.SpringGreen
            Else
                brushMotionRatio = Brushes.DarkGreen
            End If
            frmMotionDetection.grbMotionRatio.Refresh()
        End Set
    End Property


    Private Sub VideoGrabber1_OnMouseDown(ByVal sender As Object, ByVal e As VidGrab.TOnVideoMouseUpDownEventArgs) Handles VideoGrabber1.OnMouseDown
        If e.videoWindow <> -1 Then ' if the video is displayed
            If frmOverlays.chkFreeHandEnabled.Checked Then
                If cFreeHandDrawing.iArrayCoordinates < cFreeHandDrawing.MAXCOORDINATESARRAY Then
                    cFreeHandDrawing.ArrayCoordinates(cFreeHandDrawing.iArrayCoordinates).X = e.x
                    cFreeHandDrawing.ArrayCoordinates(cFreeHandDrawing.iArrayCoordinates).Y = e.y
                    cFreeHandDrawing.ArrayCoordinates(cFreeHandDrawing.iArrayCoordinates).Width = 0 ' Width is used as boolean to know if it is a MoveTo or a LineTo
                    cFreeHandDrawing.iArrayCoordinates = cFreeHandDrawing.iArrayCoordinates + 1
                    cFreeHandDrawing.DrawingEnabled = True
                    VideoGrabber1.RefreshPlayerOverlays()
                End If
            End If
        End If
    End Sub

    Private Sub VideoGrabber1_OnMouseMove(ByVal sender As Object, ByVal e As VidGrab.TOnVideoMouseMoveEventArgs) Handles VideoGrabber1.OnMouseMove
        If e.videoWindow <> -1 Then ' if the video is displayed
            If cFreeHandDrawing.DrawingEnabled Then
                If cFreeHandDrawing.iArrayCoordinates < cFreeHandDrawing.MAXCOORDINATESARRAY Then
                    cFreeHandDrawing.ArrayCoordinates(cFreeHandDrawing.iArrayCoordinates).X = e.x
                    cFreeHandDrawing.ArrayCoordinates(cFreeHandDrawing.iArrayCoordinates).Y = e.y
                    cFreeHandDrawing.ArrayCoordinates(cFreeHandDrawing.iArrayCoordinates).Width = 1 ' Width is used as boolean to know if it is a MoveTo or a LineTo
                    cFreeHandDrawing.iArrayCoordinates = cFreeHandDrawing.iArrayCoordinates + 1
                    VideoGrabber1.RefreshPlayerOverlays()
                End If
            End If
        End If
    End Sub

    Private Sub VideoGrabber1_OnMouseUp(ByVal sender As Object, ByVal e As VidGrab.TOnVideoMouseUpDownEventArgs) Handles VideoGrabber1.OnMouseUp
        cFreeHandDrawing.DrawingEnabled = False

        ' used in the image overlay sample, to pickup a transparent color on the video frame at the last mouse click location
        cPickupColor.LastRGBPixelValueAtMousePosition = 0
        cPickupColor.MouseXVideoPosition = e.x
        cPickupColor.MouseYVideoPosition = e.y
        cPickupColor.MustGetRGBPixel = True
        VideoGrabber1.RefreshPlayerOverlays()
    End Sub

    Private Sub VideoGrabber1_OnPlayerOpened(ByVal sender As Object, ByVal e As System.EventArgs) Handles VideoGrabber1.OnPlayerOpened
        tbrPlayer.Minimum = 1
        tbrPlayer.TickFrequency = 1
        tbrPlayer.Maximum = CType(VideoGrabber1.PlayerFrameCount, Integer)

        AddLog(mmoLog, "")
        AddLog(mmoLog, "playing " + VideoGrabber1.PlayerFileName)

        If (VideoGrabber1.IsPlayerVideoStreamAvailable = VidGrab.TTriState.ts_True) Then
            AddLog(mmoLog, "this clip has a video stream")
        ElseIf (VideoGrabber1.IsPlayerVideoStreamAvailable = VidGrab.TTriState.ts_False) Then
            AddLog(mmoLog, "this clip does not have video")
        End If
        If (VideoGrabber1.IsPlayerAudioStreamAvailable = VidGrab.TTriState.ts_True) Then
            AddLog(mmoLog, "this clip has a Audio stream")
        ElseIf (VideoGrabber1.IsPlayerAudioStreamAvailable = VidGrab.TTriState.ts_False) Then
            AddLog(mmoLog, "this clip does not have Audio")
        End If

        AddLog(mmoLog, "")
        AddLog(mmoLog, "video codec: " + VideoGrabber1.PlayerVideoCodec)
        AddLog(mmoLog, "audio codec: " + VideoGrabber1.PlayerAudioCodec)
        AddLog(mmoLog, "")
        Dim PlayerDuration As Double = VideoGrabber1.PlayerDuration / 10000000
        AddLog(mmoLog, "Duration: " + PlayerDuration.ToString("0.00"))
        AddLog(mmoLog, "Frame count: " + VideoGrabber1.PlayerFrameCount.ToString())
        AddLog(mmoLog, "Frame rate: " + VideoGrabber1.PlayerFrameRate.ToString("0.00"))
        AddLog(mmoLog, "size:" + VideoGrabber1.VideoWidth.ToString() + "x" + VideoGrabber1.VideoHeight.ToString())

        If (VideoGrabber1.IsPlaylistActive()) Then
            frmPlayer.lstPlaylist.SelectedIndex = VideoGrabber1.PlaylistIndex
        End If

    End Sub

    Private Sub VideoGrabber1_OnPlayerEndOfStream(ByVal sender As Object, ByVal e As System.EventArgs) Handles VideoGrabber1.OnPlayerEndOfStream
        AddLog(mmoLog, "end of stream.")
        If frmPlayer.chkLoop.Checked Then
            VideoGrabber1.RunPlayer()
        End If
    End Sub

    Private Sub VideoGrabber1_OnPlayerUpdateTrackbarPosition(ByVal sender As Object, ByVal e As VidGrab.TOnFrameProgressEventArgs) Handles VideoGrabber1.OnPlayerUpdateTrackbarPosition
        tbrPlayer.Value = CType(VideoGrabber1.PlayerFramePosition, Integer)
    End Sub

    Private Sub btnFastFwd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFastFwd.Click
        VideoGrabber1.FastForwardPlayer()
    End Sub

    Private Sub btnFastRew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFastRew.Click
        VideoGrabber1.RewindPlayer()
    End Sub

    Private Sub btnPause_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPause.Click
        VideoGrabber1.PausePlayer()
    End Sub

    Private Sub btnPlay_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        VideoGrabber1.RunPlayer()
    End Sub

    Private Sub btnFrameStep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrameStep.Click
        VideoGrabber1.PlayerFrameStep(1)
    End Sub

    Private Sub btnPlayBackwards_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlayBackwards.Click
        VideoGrabber1.RunPlayerBackwards()
    End Sub

    Private Sub btnStop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStop.Click
        VideoGrabber1.StopPlayer()
    End Sub

    Private Sub VideoGrabber1_OnPreviewStarted(ByVal sender As Object, ByVal e As System.EventArgs) Handles VideoGrabber1.OnPreviewStarted
        AddLog(mmoLog, "")
        AddLog(mmoLog, "video size: " & VideoGrabber1.VideoWidth.ToString & " x" & VideoGrabber1.VideoHeight.ToString)
        AddLog(mmoLog, "display size: " & VideoGrabber1.Display_VideoWidth.ToString & " x" & VideoGrabber1.Display_VideoHeight.ToString)
        AddLog(mmoLog, "current frame rate: " & VideoGrabber1.CurrentFrameRate.ToString("0.00") & " fps.")
        AddLog(mmoLog, "")
    End Sub

    Private Sub VideoGrabber1_OnRecordingPaused(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VideoGrabber1.OnRecordingPaused
        AddLog(mmoLog, "recording paused...")
    End Sub

    Private Sub VideoGrabber1_OnRecordingCompleted(ByVal sender As Object, ByVal e As VidGrab.TOnRecordingCompletedEventArgs) Handles VideoGrabber1.OnRecordingCompleted
        If e.success Then
            AddLog(mmoLog, " successfully created.")
            AddLog(mmoLog, "size: " & VideoGrabber1.RecordingKBytesWrittenToDisk.ToString() & " KB")
        Else
            AddLog(mmoLog, "recording failed.")
        End If
        frmRecording.btnRenewRecordingFile.Enabled = False
    End Sub

    Private Sub VideoGrabber1_OnRecordingReadyToStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles VideoGrabber1.OnRecordingReadyToStart

        ' Enabling HoldRecording before calling StartRecording prevents the recording
        '  to start (when the recording graph is built) until the
        '  OnRecordingReadyToStart event is fired, where ResumeRecording must be invoked
        '  to commence recording, or StopRecording to cancel recording
        ' EXCEPTION: RecordingTimer = rt_StartRecording: recording is started
        '  after RecordingTimerInterval regardless of HoldRecording setting,
        '  and OnRecordingReadyToStart event is not fired
        If MessageBox.Show("""StartRecording"" was initiated with ""HoldRecording"" enabled," & vbCrLf &
                 "firing the ""OnRecordingReadyToStart"" event." & vbCrLf & vbCrLf &
                 "Ready to start recording!",
                 "DataStead TVideoGrabber VB.NET OCX Demo", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            If (MainForm.DefInstance.VideoGrabber1.VideoSource = VidGrab.TVideoSource.vs_ScreenRecording) And (frmRecording.chkScreenRecordWindow.Checked = True) And (lngScreenRecordingWindow > 0) Then
                ' for screen recording of a window, this code will make it the top window before recording start;
                '  window handle was gathered by EnumerateWindows in OnEnumerateWindows
                ' (see demo procedures in VideoSource form btnScreenRecordingWindow and SetEnumerateWindows)
                InsetForms.SetWindowPos(CType(wenScreenRecordingWindow(lngScreenRecordingWindow - 1).WindowHandle, IntPtr), CType(InsetForms.HWND_TOP, IntPtr), 0, 0, 0, 0, SWP_NOMOVE Or SWP_NOSIZE)
            End If
            VideoGrabber1.ResumeRecording()
        Else
            VideoGrabber1.Stop()
        End If

    End Sub

    Private Sub VideoGrabber1_OnRecordingStarted(ByVal sender As Object, ByVal e As VidGrab.TOnFileNotificationEventArgs) Handles VideoGrabber1.OnRecordingStarted
        AddLog(mmoLog, "recording to " & e.fileName & ":")
        AddLog(mmoLog, VideoGrabber1.RecordingWidth.ToString & " x" & VideoGrabber1.RecordingHeight.ToString)
        AddLog(mmoLog, "current frame rate: " & VideoGrabber1.CurrentFrameRate.ToString("0.0") & " fps.")
        frmRecording.btnRenewRecordingFile.Enabled = True
        LastKBWrittenReportTime = 0
    End Sub

    Private Sub VideoGrabber1_OnReencodingCompleted(ByVal sender As Object, ByVal e As VidGrab.TOnSourceFileToDestFileCompletedEventArgs) Handles VideoGrabber1.OnReencodingCompleted
        If e.success Then
            AddLog(mmoLog, " successfully reencoded to " & e.destFile)
        Else
            AddLog(mmoLog, "Failed to reencode " & e.sourceFile & " to " & e.destFile)
        End If
    End Sub

    Private Sub VideoGrabber1_OnReencodingProgress(ByVal sender As Object, ByVal e As VidGrab.TOnProgressEventArgs) Handles VideoGrabber1.OnReencodingProgress
        AddLog(mmoLog, e.percent.ToString & "% completed...")
    End Sub

    Private Sub VideoGrabber1_OnReencodingStarted(ByVal sender As Object, ByVal e As VidGrab.TOnSourceFileToDestFileStartedEventArgs) Handles VideoGrabber1.OnReencodingStarted
        AddLog(mmoLog, "reencoding " & e.sourceFile & " to " & e.destFile & "...")
    End Sub

    Private Sub VideoGrabber1_OnReinitializing(ByVal sender As Object, ByVal e As System.EventArgs) Handles VideoGrabber1.OnReinitializing
        mmoLog.Text = ""
    End Sub

    Private Sub VideoGrabber1_OnResize(ByVal sender As Object, ByVal e As System.EventArgs) 'Handles VideoGrabber1.OnResize
        Dim NewWidth As Integer
        Dim NewHeight As Integer

        NewWidth = VideoGrabber1.Left + VideoGrabber1.VideoWidth + 30
        NewHeight = VideoGrabber1.Top + VideoGrabber1.VideoHeight + 60
        If ((NewWidth >= Width) Or (NewHeight >= Height)) Then
            If NewWidth < StartupWidth Then
                Width = StartupWidth
            Else
                Width = NewWidth
            End If
            If NewHeight < StartupHeight Then
                Height = StartupHeight
            Else
                Height = NewHeight
            End If
        Else
            If NewWidth < StartupWidth Then
                Width = StartupWidth
            End If
            If NewHeight < StartupHeight Then
                Height = StartupHeight
            End If
        End If
    End Sub

    Private Sub VideoGrabber1_OnResizeVideo(ByVal sender As Object, ByVal e As VidGrab.TOnResizeVideoEventArgs) 'Handles VideoGrabber1.OnResizeVideo
        If Not IsNothing(frmVideoProcessing) Then ' frmVideoProcessing may not have been yet created
            frmVideoProcessing.trkCroppingX.Maximum = VideoGrabber1.Cropping_XMax
            frmVideoProcessing.trkCroppingX.TickFrequency = (frmVideoProcessing.trkCroppingX.Maximum \ 10)
            frmVideoProcessing.trkCroppingY.Maximum = VideoGrabber1.Cropping_YMax
            frmVideoProcessing.trkCroppingY.TickFrequency = (frmVideoProcessing.trkCroppingY.Maximum \ 10)
        End If
    End Sub

    Private Sub bxVideoGrabber1_OnVideoFromBitmapsNextFrameNeeded(ByVal sender As Object, ByVal e As VidGrab.TOnVideoFromBitmapsNextFrameNeededEventArgs) Handles VideoGrabber1.OnVideoFromBitmapsNextFrameNeeded

        ' you can pass to this event:
        ' - either the path to a BMP file or a JPEG file (this is the case in this example)
        ' - either a the HBITMAP handle of a bitmap

        ' also see help "Video clip built from a fixed set of BMP files or JPEG files"
        ProcessingNextFrameNeeded = True

        Dim EndOfData As Boolean

        ' FirstSample is true the first time the event occurs (useful to know e.g. when a file search must be restarted from the beginning)
        Dim ImageFile As String
        If e.firstSample Then
            ImageFile = VideoFromImages.FirstImageFile
            If ImageFile = "" Then ' if no BMP file found, let's try JPEG files
                EndOfData = True
            End If
        Else
            ImageFile = VideoFromImages.NextImageFile
            If ImageFile = "" Then
                EndOfData = True
            End If
        End If
        VideoGrabber1.SendImageToVideoFromBitmaps(ImageFile, IntPtr.Zero, False, EndOfData)

        ProcessingNextFrameNeeded = False

    End Sub

    Private Sub VideoGrabber1_OnClientConnection(ByVal sender As Object, ByVal e As VidGrab.TOnClientConnectionEventArgs) Handles VideoGrabber1.OnClientConnection
        If e.connected Then
            AddLog(mmoLog, "client connected: " + e.clientInfo)
        Else
            AddLog(mmoLog, "client disconnected: " + e.clientInfo)
        End If
    End Sub

    Private Sub edtStoragePath_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtStoragePath.TextChanged
        VideoGrabber1.StoragePath = edtStoragePath.Text
    End Sub

    Private Sub mnuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbout.Click
        VideoGrabber1.About()
    End Sub

    Public Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub VideoGrabber1_OnGraphBuilt(ByVal sender As Object, ByVal e As System.EventArgs) Handles VideoGrabber1.OnGraphBuilt
        AutoSizeInfo.Visible = False

        tbrZoomX.Minimum = -(VideoGrabber1.VideoWidth \ 2)
        tbrZoomX.Maximum = VideoGrabber1.VideoWidth \ 2
        tbrZoomY.Minimum = -(VideoGrabber1.VideoHeight \ 2)
        tbrZoomY.Maximum = VideoGrabber1.VideoHeight \ 2

    End Sub

    Private Sub VideoGrabber1_OnInactive(ByVal sender As Object, ByVal e As System.EventArgs) Handles VideoGrabber1.OnInactive
        AddLog(mmoLog, "(done.)")
    End Sub

    Private Sub tbrPlayer_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrPlayer.Scroll
        VideoGrabber1.PlayerFramePosition = tbrPlayer.Value
    End Sub

    Private Sub chkPlayerTrackbarSynchrone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPlayerTrackBarSynchrone.CheckedChanged
        VideoGrabber1.PlayerTrackBarSynchrone = chkPlayerTrackBarSynchrone.Checked
    End Sub

    Private Sub tbrPlayer_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbrPlayer.MouseDown
        VideoGrabber1.NotifyPlayerTrackbarAction(VidGrab.TTrackbarAction.tba_MouseDown)
    End Sub

    Private Sub tbrPlayer_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbrPlayer.MouseUp
        VideoGrabber1.NotifyPlayerTrackbarAction(VidGrab.TTrackbarAction.tba_MouseUp)
    End Sub

    Private Sub tbrPlayer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbrPlayer.KeyDown
        VideoGrabber1.NotifyPlayerTrackbarAction(VidGrab.TTrackbarAction.tba_KeyDown)
    End Sub

    Private Sub tbrPlayer_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbrPlayer.KeyUp
        VideoGrabber1.NotifyPlayerTrackbarAction(VidGrab.TTrackbarAction.tba_KeyUp)
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        VideoGrabber1.ResetVideoDeviceSettings()
    End Sub

    Private Sub tbrZoom_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrZoom.Scroll
        VideoGrabber1.ZoomCoeff = tbrZoom.Value
    End Sub

    Private Sub tbrZoomX_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrZoomX.Scroll
        VideoGrabber1.ZoomXCenter = tbrZoomX.Value
    End Sub

    Private Sub tbrZoomY_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrZoomY.Scroll
        VideoGrabber1.ZoomYCenter = tbrZoomY.Value
    End Sub

End Class

'(*) From this event you should not perform any actions with the potential to block:
'    1. do not hold a critical section or wait on another thread,
'    2. do not call any GDI or USER32.DLL APIs that might cause a window to move,
'    3. do not invoke component properties that send messages, e.g. do not read the ItemIndex property
'       of a ListBox component. If you need to read a such property, set an intermediary variable when
'       the property changes, and then read the intermediary variable from this event.
