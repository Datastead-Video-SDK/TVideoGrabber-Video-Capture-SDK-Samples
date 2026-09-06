Option Strict Off
Option Explicit On
Friend Class FrameGrabber
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
    Public WithEvents mmoFrameCaptureLog As System.Windows.Forms.TextBox
    Public WithEvents btnResetCaptureZoomSize As System.Windows.Forms.Button
    Public WithEvents edtCaptureZoomSize As System.Windows.Forms.TextBox
    Public WithEvents Frame11 As System.Windows.Forms.GroupBox
    Public WithEvents edtAVIAutoFilePrefix As System.Windows.Forms.TextBox
    Public WithEvents rdgAutoFileName1 As System.Windows.Forms.RadioButton
    Public WithEvents rdgAutoFileName2 As System.Windows.Forms.RadioButton
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents rdgAutoFileName As System.Windows.Forms.GroupBox
    Public WithEvents btnBurstModeStop As System.Windows.Forms.Button
    Public WithEvents btnBurstModeJPEGFile As System.Windows.Forms.Button
    Public WithEvents btnBurstModeBMPFile As System.Windows.Forms.Button
    Public WithEvents btnBurstModeTBitmap As System.Windows.Forms.Button
    Public WithEvents edtBurstCount As System.Windows.Forms.TextBox
    Public WithEvents edtBurstInterval As System.Windows.Forms.TextBox
    Public WithEvents Label34 As System.Windows.Forms.Label
    Public WithEvents Label35 As System.Windows.Forms.Label
    Public WithEvents grbBurstMode As System.Windows.Forms.GroupBox
    Public WithEvents chkUseThisFileName As System.Windows.Forms.CheckBox
    Public WithEvents edtUseThisFileName As System.Windows.Forms.TextBox
    Public WithEvents btnOneShotTBitmap As System.Windows.Forms.Button
    Public WithEvents btnOneShotBMPFile As System.Windows.Forms.Button
    Public WithEvents btnOneShotJPEGFile As System.Windows.Forms.Button
    Public WithEvents grbOneShot As System.Windows.Forms.GroupBox
    Public WithEvents rgdFrameGrabberFormat As System.Windows.Forms.GroupBox
    Public WithEvents rgdFrameGrabber As System.Windows.Forms.GroupBox
    Public WithEvents Label32 As System.Windows.Forms.Label
    Public WithEvents Label33 As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents tbrCaptureZoomSize As System.Windows.Forms.TrackBar
    Public WithEvents btnOneShotClipboard As System.Windows.Forms.Button
    Public WithEvents btnBurstModeClipboard As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents edtFrameCaptureWidth As System.Windows.Forms.TextBox
    Friend WithEvents edtFrameCaptureHeight As System.Windows.Forms.TextBox
    Public WithEvents rgdFrameGrabberBothStreams As System.Windows.Forms.RadioButton
    Public WithEvents rgdFrameGrabberPreviewStream As System.Windows.Forms.RadioButton
    Public WithEvents rgdFrameGrabberCaptureStream As System.Windows.Forms.RadioButton
    Public WithEvents rgdFrameGrabberDisabled As System.Windows.Forms.RadioButton
    Public WithEvents rgdFrameGrabberFormatDefault As System.Windows.Forms.RadioButton
    Public WithEvents rgdFrameGrabberFormatRGB32 As System.Windows.Forms.RadioButton
    Public WithEvents rgdFrameGrabberFormatRGB24 As System.Windows.Forms.RadioButton
    Public WithEvents rgdFrameGrabberFormat565 As System.Windows.Forms.RadioButton
    Public WithEvents rgdFrameGrabberFormatRGB555 As System.Windows.Forms.RadioButton
    Friend WithEvents rdgAutoFileName3 As System.Windows.Forms.RadioButton
    Public WithEvents rgdFrameGrabberFormatRGB8 As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.mmoFrameCaptureLog = New System.Windows.Forms.TextBox
        Me.Frame11 = New System.Windows.Forms.GroupBox
        Me.tbrCaptureZoomSize = New System.Windows.Forms.TrackBar
        Me.btnResetCaptureZoomSize = New System.Windows.Forms.Button
        Me.edtCaptureZoomSize = New System.Windows.Forms.TextBox
        Me.rdgAutoFileName = New System.Windows.Forms.GroupBox
        Me.rdgAutoFileName3 = New System.Windows.Forms.RadioButton
        Me.edtAVIAutoFilePrefix = New System.Windows.Forms.TextBox
        Me.rdgAutoFileName1 = New System.Windows.Forms.RadioButton
        Me.rdgAutoFileName2 = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.grbBurstMode = New System.Windows.Forms.GroupBox
        Me.btnBurstModeClipboard = New System.Windows.Forms.Button
        Me.btnBurstModeStop = New System.Windows.Forms.Button
        Me.btnBurstModeJPEGFile = New System.Windows.Forms.Button
        Me.btnBurstModeBMPFile = New System.Windows.Forms.Button
        Me.btnBurstModeTBitmap = New System.Windows.Forms.Button
        Me.edtBurstCount = New System.Windows.Forms.TextBox
        Me.edtBurstInterval = New System.Windows.Forms.TextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.grbOneShot = New System.Windows.Forms.GroupBox
        Me.edtUseThisFileName = New System.Windows.Forms.TextBox
        Me.btnOneShotClipboard = New System.Windows.Forms.Button
        Me.chkUseThisFileName = New System.Windows.Forms.CheckBox
        Me.btnOneShotTBitmap = New System.Windows.Forms.Button
        Me.btnOneShotBMPFile = New System.Windows.Forms.Button
        Me.btnOneShotJPEGFile = New System.Windows.Forms.Button
        Me.rgdFrameGrabberFormat = New System.Windows.Forms.GroupBox
        Me.rgdFrameGrabberFormatRGB8 = New System.Windows.Forms.RadioButton
        Me.rgdFrameGrabberFormatRGB555 = New System.Windows.Forms.RadioButton
        Me.rgdFrameGrabberFormatDefault = New System.Windows.Forms.RadioButton
        Me.rgdFrameGrabberFormatRGB32 = New System.Windows.Forms.RadioButton
        Me.rgdFrameGrabberFormatRGB24 = New System.Windows.Forms.RadioButton
        Me.rgdFrameGrabberFormat565 = New System.Windows.Forms.RadioButton
        Me.rgdFrameGrabber = New System.Windows.Forms.GroupBox
        Me.rgdFrameGrabberPreviewStream = New System.Windows.Forms.RadioButton
        Me.rgdFrameGrabberCaptureStream = New System.Windows.Forms.RadioButton
        Me.rgdFrameGrabberDisabled = New System.Windows.Forms.RadioButton
        Me.rgdFrameGrabberBothStreams = New System.Windows.Forms.RadioButton
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.edtFrameCaptureWidth = New System.Windows.Forms.TextBox
        Me.edtFrameCaptureHeight = New System.Windows.Forms.TextBox
        Me.Frame11.SuspendLayout()
        CType(Me.tbrCaptureZoomSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rdgAutoFileName.SuspendLayout()
        Me.grbBurstMode.SuspendLayout()
        Me.grbOneShot.SuspendLayout()
        Me.rgdFrameGrabberFormat.SuspendLayout()
        Me.rgdFrameGrabber.SuspendLayout()
        Me.SuspendLayout()
        '
        'mmoFrameCaptureLog
        '
        Me.mmoFrameCaptureLog.AcceptsReturn = True
        Me.mmoFrameCaptureLog.BackColor = System.Drawing.Color.Silver
        Me.mmoFrameCaptureLog.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.mmoFrameCaptureLog.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mmoFrameCaptureLog.ForeColor = System.Drawing.SystemColors.WindowText
        Me.mmoFrameCaptureLog.Location = New System.Drawing.Point(864, 20)
        Me.mmoFrameCaptureLog.MaxLength = 0
        Me.mmoFrameCaptureLog.Multiline = True
        Me.mmoFrameCaptureLog.Name = "mmoFrameCaptureLog"
        Me.mmoFrameCaptureLog.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mmoFrameCaptureLog.Size = New System.Drawing.Size(230, 200)
        Me.mmoFrameCaptureLog.TabIndex = 36
        Me.mmoFrameCaptureLog.Text = "  log:"
        '
        'Frame11
        '
        Me.Frame11.BackColor = System.Drawing.SystemColors.Control
        Me.Frame11.Controls.Add(Me.tbrCaptureZoomSize)
        Me.Frame11.Controls.Add(Me.btnResetCaptureZoomSize)
        Me.Frame11.Controls.Add(Me.edtCaptureZoomSize)
        Me.Frame11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame11.Location = New System.Drawing.Point(761, 20)
        Me.Frame11.Name = "Frame11"
        Me.Frame11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame11.Size = New System.Drawing.Size(96, 109)
        Me.Frame11.TabIndex = 32
        Me.Frame11.TabStop = False
        Me.Frame11.Text = "zoom size"
        '
        'tbrCaptureZoomSize
        '
        Me.tbrCaptureZoomSize.AutoSize = False
        Me.tbrCaptureZoomSize.Location = New System.Drawing.Point(10, 20)
        Me.tbrCaptureZoomSize.Maximum = 300
        Me.tbrCaptureZoomSize.Name = "tbrCaptureZoomSize"
        Me.tbrCaptureZoomSize.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbrCaptureZoomSize.Size = New System.Drawing.Size(19, 83)
        Me.tbrCaptureZoomSize.TabIndex = 35
        Me.tbrCaptureZoomSize.TickFrequency = 30
        '
        'btnResetCaptureZoomSize
        '
        Me.btnResetCaptureZoomSize.BackColor = System.Drawing.SystemColors.Control
        Me.btnResetCaptureZoomSize.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnResetCaptureZoomSize.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetCaptureZoomSize.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnResetCaptureZoomSize.Location = New System.Drawing.Point(38, 30)
        Me.btnResetCaptureZoomSize.Name = "btnResetCaptureZoomSize"
        Me.btnResetCaptureZoomSize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnResetCaptureZoomSize.Size = New System.Drawing.Size(46, 27)
        Me.btnResetCaptureZoomSize.TabIndex = 34
        Me.btnResetCaptureZoomSize.Text = "rst"
        Me.btnResetCaptureZoomSize.UseVisualStyleBackColor = False
        '
        'edtCaptureZoomSize
        '
        Me.edtCaptureZoomSize.AcceptsReturn = True
        Me.edtCaptureZoomSize.BackColor = System.Drawing.Color.Silver
        Me.edtCaptureZoomSize.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtCaptureZoomSize.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtCaptureZoomSize.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtCaptureZoomSize.Location = New System.Drawing.Point(38, 64)
        Me.edtCaptureZoomSize.MaxLength = 0
        Me.edtCaptureZoomSize.Name = "edtCaptureZoomSize"
        Me.edtCaptureZoomSize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtCaptureZoomSize.Size = New System.Drawing.Size(46, 23)
        Me.edtCaptureZoomSize.TabIndex = 33
        Me.edtCaptureZoomSize.Text = "100%"
        '
        'rdgAutoFileName
        '
        Me.rdgAutoFileName.BackColor = System.Drawing.SystemColors.Control
        Me.rdgAutoFileName.Controls.Add(Me.rdgAutoFileName3)
        Me.rdgAutoFileName.Controls.Add(Me.edtAVIAutoFilePrefix)
        Me.rdgAutoFileName.Controls.Add(Me.rdgAutoFileName1)
        Me.rdgAutoFileName.Controls.Add(Me.rdgAutoFileName2)
        Me.rdgAutoFileName.Controls.Add(Me.Label1)
        Me.rdgAutoFileName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgAutoFileName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgAutoFileName.Location = New System.Drawing.Point(5, 140)
        Me.rdgAutoFileName.Name = "rdgAutoFileName"
        Me.rdgAutoFileName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgAutoFileName.Size = New System.Drawing.Size(300, 94)
        Me.rdgAutoFileName.TabIndex = 29
        Me.rdgAutoFileName.TabStop = False
        Me.rdgAutoFileName.Text = "file names are generated automatically on a..."
        '
        'rdgAutoFileName3
        '
        Me.rdgAutoFileName3.AutoSize = True
        Me.rdgAutoFileName3.Location = New System.Drawing.Point(19, 64)
        Me.rdgAutoFileName3.Name = "rdgAutoFileName3"
        Me.rdgAutoFileName3.Size = New System.Drawing.Size(163, 20)
        Me.rdgAutoFileName3.TabIndex = 39
        Me.rdgAutoFileName3.TabStop = True
        Me.rdgAutoFileName3.Tag = "2"
        Me.rdgAutoFileName3.Text = "counter (start from 0)"
        '
        'edtAVIAutoFilePrefix
        '
        Me.edtAVIAutoFilePrefix.AcceptsReturn = True
        Me.edtAVIAutoFilePrefix.BackColor = System.Drawing.SystemColors.Window
        Me.edtAVIAutoFilePrefix.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtAVIAutoFilePrefix.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtAVIAutoFilePrefix.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtAVIAutoFilePrefix.Location = New System.Drawing.Point(156, 37)
        Me.edtAVIAutoFilePrefix.MaxLength = 0
        Me.edtAVIAutoFilePrefix.Name = "edtAVIAutoFilePrefix"
        Me.edtAVIAutoFilePrefix.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtAVIAutoFilePrefix.Size = New System.Drawing.Size(95, 23)
        Me.edtAVIAutoFilePrefix.TabIndex = 37
        '
        'rdgAutoFileName1
        '
        Me.rdgAutoFileName1.BackColor = System.Drawing.SystemColors.Control
        Me.rdgAutoFileName1.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgAutoFileName1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgAutoFileName1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgAutoFileName1.Location = New System.Drawing.Point(19, 20)
        Me.rdgAutoFileName1.Name = "rdgAutoFileName1"
        Me.rdgAutoFileName1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgAutoFileName1.Size = New System.Drawing.Size(126, 21)
        Me.rdgAutoFileName1.TabIndex = 31
        Me.rdgAutoFileName1.TabStop = True
        Me.rdgAutoFileName1.Tag = "0"
        Me.rdgAutoFileName1.Text = "sequential basis"
        Me.rdgAutoFileName1.UseVisualStyleBackColor = False
        '
        'rdgAutoFileName2
        '
        Me.rdgAutoFileName2.BackColor = System.Drawing.SystemColors.Control
        Me.rdgAutoFileName2.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgAutoFileName2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgAutoFileName2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgAutoFileName2.Location = New System.Drawing.Point(19, 42)
        Me.rdgAutoFileName2.Name = "rdgAutoFileName2"
        Me.rdgAutoFileName2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgAutoFileName2.Size = New System.Drawing.Size(126, 21)
        Me.rdgAutoFileName2.TabIndex = 30
        Me.rdgAutoFileName2.TabStop = True
        Me.rdgAutoFileName2.Tag = "1"
        Me.rdgAutoFileName2.Text = "time basis"
        Me.rdgAutoFileName2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(152, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(138, 22)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "prefix for file names:"
        '
        'grbBurstMode
        '
        Me.grbBurstMode.BackColor = System.Drawing.SystemColors.Control
        Me.grbBurstMode.Controls.Add(Me.btnBurstModeClipboard)
        Me.grbBurstMode.Controls.Add(Me.btnBurstModeStop)
        Me.grbBurstMode.Controls.Add(Me.btnBurstModeJPEGFile)
        Me.grbBurstMode.Controls.Add(Me.btnBurstModeBMPFile)
        Me.grbBurstMode.Controls.Add(Me.btnBurstModeTBitmap)
        Me.grbBurstMode.Controls.Add(Me.edtBurstCount)
        Me.grbBurstMode.Controls.Add(Me.edtBurstInterval)
        Me.grbBurstMode.Controls.Add(Me.Label34)
        Me.grbBurstMode.Controls.Add(Me.Label35)
        Me.grbBurstMode.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbBurstMode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbBurstMode.Location = New System.Drawing.Point(312, 102)
        Me.grbBurstMode.Name = "grbBurstMode"
        Me.grbBurstMode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbBurstMode.Size = New System.Drawing.Size(442, 118)
        Me.grbBurstMode.TabIndex = 20
        Me.grbBurstMode.TabStop = False
        Me.grbBurstMode.Text = "burst-mode frame capture to... "
        '
        'btnBurstModeClipboard
        '
        Me.btnBurstModeClipboard.BackColor = System.Drawing.SystemColors.Control
        Me.btnBurstModeClipboard.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnBurstModeClipboard.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBurstModeClipboard.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBurstModeClipboard.Location = New System.Drawing.Point(269, 20)
        Me.btnBurstModeClipboard.Name = "btnBurstModeClipboard"
        Me.btnBurstModeClipboard.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnBurstModeClipboard.Size = New System.Drawing.Size(78, 27)
        Me.btnBurstModeClipboard.TabIndex = 29
        Me.btnBurstModeClipboard.Text = "Clipboard"
        Me.btnBurstModeClipboard.UseVisualStyleBackColor = False
        '
        'btnBurstModeStop
        '
        Me.btnBurstModeStop.BackColor = System.Drawing.SystemColors.Control
        Me.btnBurstModeStop.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnBurstModeStop.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBurstModeStop.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBurstModeStop.Location = New System.Drawing.Point(355, 20)
        Me.btnBurstModeStop.Name = "btnBurstModeStop"
        Me.btnBurstModeStop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnBurstModeStop.Size = New System.Drawing.Size(78, 27)
        Me.btnBurstModeStop.TabIndex = 26
        Me.btnBurstModeStop.Text = "Stop"
        Me.btnBurstModeStop.UseVisualStyleBackColor = False
        '
        'btnBurstModeJPEGFile
        '
        Me.btnBurstModeJPEGFile.BackColor = System.Drawing.SystemColors.Control
        Me.btnBurstModeJPEGFile.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnBurstModeJPEGFile.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBurstModeJPEGFile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBurstModeJPEGFile.Location = New System.Drawing.Point(182, 20)
        Me.btnBurstModeJPEGFile.Name = "btnBurstModeJPEGFile"
        Me.btnBurstModeJPEGFile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnBurstModeJPEGFile.Size = New System.Drawing.Size(78, 27)
        Me.btnBurstModeJPEGFile.TabIndex = 25
        Me.btnBurstModeJPEGFile.Text = "JPEG file"
        Me.btnBurstModeJPEGFile.UseVisualStyleBackColor = False
        '
        'btnBurstModeBMPFile
        '
        Me.btnBurstModeBMPFile.BackColor = System.Drawing.SystemColors.Control
        Me.btnBurstModeBMPFile.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnBurstModeBMPFile.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBurstModeBMPFile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBurstModeBMPFile.Location = New System.Drawing.Point(96, 20)
        Me.btnBurstModeBMPFile.Name = "btnBurstModeBMPFile"
        Me.btnBurstModeBMPFile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnBurstModeBMPFile.Size = New System.Drawing.Size(78, 27)
        Me.btnBurstModeBMPFile.TabIndex = 24
        Me.btnBurstModeBMPFile.Text = "BMP file"
        Me.btnBurstModeBMPFile.UseVisualStyleBackColor = False
        '
        'btnBurstModeTBitmap
        '
        Me.btnBurstModeTBitmap.BackColor = System.Drawing.SystemColors.Control
        Me.btnBurstModeTBitmap.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnBurstModeTBitmap.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBurstModeTBitmap.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBurstModeTBitmap.Location = New System.Drawing.Point(10, 20)
        Me.btnBurstModeTBitmap.Name = "btnBurstModeTBitmap"
        Me.btnBurstModeTBitmap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnBurstModeTBitmap.Size = New System.Drawing.Size(78, 27)
        Me.btnBurstModeTBitmap.TabIndex = 23
        Me.btnBurstModeTBitmap.Text = "TBitmap"
        Me.btnBurstModeTBitmap.UseVisualStyleBackColor = False
        '
        'edtBurstCount
        '
        Me.edtBurstCount.AcceptsReturn = True
        Me.edtBurstCount.BackColor = System.Drawing.SystemColors.Window
        Me.edtBurstCount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtBurstCount.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtBurstCount.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtBurstCount.Location = New System.Drawing.Point(10, 49)
        Me.edtBurstCount.MaxLength = 0
        Me.edtBurstCount.Name = "edtBurstCount"
        Me.edtBurstCount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtBurstCount.Size = New System.Drawing.Size(50, 23)
        Me.edtBurstCount.TabIndex = 22
        Me.edtBurstCount.Text = "3"
        '
        'edtBurstInterval
        '
        Me.edtBurstInterval.AcceptsReturn = True
        Me.edtBurstInterval.BackColor = System.Drawing.SystemColors.Window
        Me.edtBurstInterval.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtBurstInterval.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtBurstInterval.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtBurstInterval.Location = New System.Drawing.Point(10, 79)
        Me.edtBurstInterval.MaxLength = 0
        Me.edtBurstInterval.Name = "edtBurstInterval"
        Me.edtBurstInterval.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtBurstInterval.Size = New System.Drawing.Size(50, 23)
        Me.edtBurstInterval.TabIndex = 21
        Me.edtBurstInterval.Text = "0"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.SystemColors.Control
        Me.Label34.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label34.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label34.Location = New System.Drawing.Point(62, 52)
        Me.Label34.Name = "Label34"
        Me.Label34.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label34.Size = New System.Drawing.Size(395, 16)
        Me.Label34.TabIndex = 28
        Me.Label34.Text = "number of frames to capture  (0 = capture frames indefinitely)"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.SystemColors.Control
        Me.Label35.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label35.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label35.Location = New System.Drawing.Point(62, 81)
        Me.Label35.Name = "Label35"
        Me.Label35.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label35.Size = New System.Drawing.Size(320, 16)
        Me.Label35.TabIndex = 27
        Me.Label35.Text = "number of frames to skip for each frame captured"
        '
        'grbOneShot
        '
        Me.grbOneShot.BackColor = System.Drawing.SystemColors.Control
        Me.grbOneShot.Controls.Add(Me.edtUseThisFileName)
        Me.grbOneShot.Controls.Add(Me.btnOneShotClipboard)
        Me.grbOneShot.Controls.Add(Me.chkUseThisFileName)
        Me.grbOneShot.Controls.Add(Me.btnOneShotTBitmap)
        Me.grbOneShot.Controls.Add(Me.btnOneShotBMPFile)
        Me.grbOneShot.Controls.Add(Me.btnOneShotJPEGFile)
        Me.grbOneShot.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbOneShot.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbOneShot.Location = New System.Drawing.Point(312, 20)
        Me.grbOneShot.Name = "grbOneShot"
        Me.grbOneShot.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbOneShot.Size = New System.Drawing.Size(442, 82)
        Me.grbOneShot.TabIndex = 14
        Me.grbOneShot.TabStop = False
        Me.grbOneShot.Text = "one-shot frame capture to..."
        '
        'edtUseThisFileName
        '
        Me.edtUseThisFileName.AcceptsReturn = True
        Me.edtUseThisFileName.BackColor = System.Drawing.SystemColors.Window
        Me.edtUseThisFileName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtUseThisFileName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtUseThisFileName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtUseThisFileName.Location = New System.Drawing.Point(336, 49)
        Me.edtUseThisFileName.MaxLength = 0
        Me.edtUseThisFileName.Name = "edtUseThisFileName"
        Me.edtUseThisFileName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtUseThisFileName.Size = New System.Drawing.Size(97, 23)
        Me.edtUseThisFileName.TabIndex = 18
        Me.edtUseThisFileName.Text = "CapFile01"
        '
        'btnOneShotClipboard
        '
        Me.btnOneShotClipboard.BackColor = System.Drawing.SystemColors.Control
        Me.btnOneShotClipboard.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnOneShotClipboard.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOneShotClipboard.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnOneShotClipboard.Location = New System.Drawing.Point(269, 20)
        Me.btnOneShotClipboard.Name = "btnOneShotClipboard"
        Me.btnOneShotClipboard.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnOneShotClipboard.Size = New System.Drawing.Size(78, 27)
        Me.btnOneShotClipboard.TabIndex = 20
        Me.btnOneShotClipboard.Text = "Clipboard"
        Me.btnOneShotClipboard.UseVisualStyleBackColor = False
        '
        'chkUseThisFileName
        '
        Me.chkUseThisFileName.BackColor = System.Drawing.SystemColors.Control
        Me.chkUseThisFileName.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkUseThisFileName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseThisFileName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkUseThisFileName.Location = New System.Drawing.Point(10, 52)
        Me.chkUseThisFileName.Name = "chkUseThisFileName"
        Me.chkUseThisFileName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkUseThisFileName.Size = New System.Drawing.Size(336, 21)
        Me.chkUseThisFileName.TabIndex = 19
        Me.chkUseThisFileName.Text = "don't generate file name automatically, use instead:"
        Me.chkUseThisFileName.UseVisualStyleBackColor = False
        '
        'btnOneShotTBitmap
        '
        Me.btnOneShotTBitmap.BackColor = System.Drawing.SystemColors.Control
        Me.btnOneShotTBitmap.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnOneShotTBitmap.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOneShotTBitmap.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnOneShotTBitmap.Location = New System.Drawing.Point(10, 20)
        Me.btnOneShotTBitmap.Name = "btnOneShotTBitmap"
        Me.btnOneShotTBitmap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnOneShotTBitmap.Size = New System.Drawing.Size(78, 27)
        Me.btnOneShotTBitmap.TabIndex = 17
        Me.btnOneShotTBitmap.Text = "TBitmap"
        Me.btnOneShotTBitmap.UseVisualStyleBackColor = False
        '
        'btnOneShotBMPFile
        '
        Me.btnOneShotBMPFile.BackColor = System.Drawing.SystemColors.Control
        Me.btnOneShotBMPFile.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnOneShotBMPFile.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOneShotBMPFile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnOneShotBMPFile.Location = New System.Drawing.Point(96, 20)
        Me.btnOneShotBMPFile.Name = "btnOneShotBMPFile"
        Me.btnOneShotBMPFile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnOneShotBMPFile.Size = New System.Drawing.Size(78, 27)
        Me.btnOneShotBMPFile.TabIndex = 16
        Me.btnOneShotBMPFile.Text = "BMP file"
        Me.btnOneShotBMPFile.UseVisualStyleBackColor = False
        '
        'btnOneShotJPEGFile
        '
        Me.btnOneShotJPEGFile.BackColor = System.Drawing.SystemColors.Control
        Me.btnOneShotJPEGFile.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnOneShotJPEGFile.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOneShotJPEGFile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnOneShotJPEGFile.Location = New System.Drawing.Point(182, 20)
        Me.btnOneShotJPEGFile.Name = "btnOneShotJPEGFile"
        Me.btnOneShotJPEGFile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnOneShotJPEGFile.Size = New System.Drawing.Size(78, 27)
        Me.btnOneShotJPEGFile.TabIndex = 15
        Me.btnOneShotJPEGFile.Text = "JPEG file"
        Me.btnOneShotJPEGFile.UseVisualStyleBackColor = False
        '
        'rgdFrameGrabberFormat
        '
        Me.rgdFrameGrabberFormat.BackColor = System.Drawing.SystemColors.Control
        Me.rgdFrameGrabberFormat.Controls.Add(Me.rgdFrameGrabberFormatRGB8)
        Me.rgdFrameGrabberFormat.Controls.Add(Me.rgdFrameGrabberFormatRGB555)
        Me.rgdFrameGrabberFormat.Controls.Add(Me.rgdFrameGrabberFormatDefault)
        Me.rgdFrameGrabberFormat.Controls.Add(Me.rgdFrameGrabberFormatRGB32)
        Me.rgdFrameGrabberFormat.Controls.Add(Me.rgdFrameGrabberFormatRGB24)
        Me.rgdFrameGrabberFormat.Controls.Add(Me.rgdFrameGrabberFormat565)
        Me.rgdFrameGrabberFormat.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgdFrameGrabberFormat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rgdFrameGrabberFormat.Location = New System.Drawing.Point(134, 20)
        Me.rgdFrameGrabberFormat.Name = "rgdFrameGrabberFormat"
        Me.rgdFrameGrabberFormat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rgdFrameGrabberFormat.Size = New System.Drawing.Size(171, 98)
        Me.rgdFrameGrabberFormat.TabIndex = 7
        Me.rgdFrameGrabberFormat.TabStop = False
        Me.rgdFrameGrabberFormat.Text = "frame grabber format"
        '
        'rgdFrameGrabberFormatRGB8
        '
        Me.rgdFrameGrabberFormatRGB8.BackColor = System.Drawing.SystemColors.Control
        Me.rgdFrameGrabberFormatRGB8.Cursor = System.Windows.Forms.Cursors.Default
        Me.rgdFrameGrabberFormatRGB8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgdFrameGrabberFormatRGB8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rgdFrameGrabberFormatRGB8.Location = New System.Drawing.Point(83, 64)
        Me.rgdFrameGrabberFormatRGB8.Name = "rgdFrameGrabberFormatRGB8"
        Me.rgdFrameGrabberFormatRGB8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rgdFrameGrabberFormatRGB8.Size = New System.Drawing.Size(78, 21)
        Me.rgdFrameGrabberFormatRGB8.TabIndex = 8
        Me.rgdFrameGrabberFormatRGB8.TabStop = True
        Me.rgdFrameGrabberFormatRGB8.Tag = "5"
        Me.rgdFrameGrabberFormatRGB8.Text = "RGB8"
        Me.rgdFrameGrabberFormatRGB8.UseVisualStyleBackColor = False
        '
        'rgdFrameGrabberFormatRGB555
        '
        Me.rgdFrameGrabberFormatRGB555.BackColor = System.Drawing.SystemColors.Control
        Me.rgdFrameGrabberFormatRGB555.Cursor = System.Windows.Forms.Cursors.Default
        Me.rgdFrameGrabberFormatRGB555.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgdFrameGrabberFormatRGB555.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rgdFrameGrabberFormatRGB555.Location = New System.Drawing.Point(83, 42)
        Me.rgdFrameGrabberFormatRGB555.Name = "rgdFrameGrabberFormatRGB555"
        Me.rgdFrameGrabberFormatRGB555.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rgdFrameGrabberFormatRGB555.Size = New System.Drawing.Size(78, 21)
        Me.rgdFrameGrabberFormatRGB555.TabIndex = 9
        Me.rgdFrameGrabberFormatRGB555.TabStop = True
        Me.rgdFrameGrabberFormatRGB555.Tag = "4"
        Me.rgdFrameGrabberFormatRGB555.Text = "RGB555"
        Me.rgdFrameGrabberFormatRGB555.UseVisualStyleBackColor = False
        '
        'rgdFrameGrabberFormatDefault
        '
        Me.rgdFrameGrabberFormatDefault.BackColor = System.Drawing.SystemColors.Control
        Me.rgdFrameGrabberFormatDefault.Cursor = System.Windows.Forms.Cursors.Default
        Me.rgdFrameGrabberFormatDefault.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgdFrameGrabberFormatDefault.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rgdFrameGrabberFormatDefault.Location = New System.Drawing.Point(10, 20)
        Me.rgdFrameGrabberFormatDefault.Name = "rgdFrameGrabberFormatDefault"
        Me.rgdFrameGrabberFormatDefault.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rgdFrameGrabberFormatDefault.Size = New System.Drawing.Size(67, 21)
        Me.rgdFrameGrabberFormatDefault.TabIndex = 13
        Me.rgdFrameGrabberFormatDefault.TabStop = True
        Me.rgdFrameGrabberFormatDefault.Tag = "0"
        Me.rgdFrameGrabberFormatDefault.Text = "default"
        Me.rgdFrameGrabberFormatDefault.UseVisualStyleBackColor = False
        '
        'rgdFrameGrabberFormatRGB32
        '
        Me.rgdFrameGrabberFormatRGB32.BackColor = System.Drawing.SystemColors.Control
        Me.rgdFrameGrabberFormatRGB32.Cursor = System.Windows.Forms.Cursors.Default
        Me.rgdFrameGrabberFormatRGB32.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgdFrameGrabberFormatRGB32.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rgdFrameGrabberFormatRGB32.Location = New System.Drawing.Point(10, 42)
        Me.rgdFrameGrabberFormatRGB32.Name = "rgdFrameGrabberFormatRGB32"
        Me.rgdFrameGrabberFormatRGB32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rgdFrameGrabberFormatRGB32.Size = New System.Drawing.Size(78, 21)
        Me.rgdFrameGrabberFormatRGB32.TabIndex = 12
        Me.rgdFrameGrabberFormatRGB32.TabStop = True
        Me.rgdFrameGrabberFormatRGB32.Tag = "1"
        Me.rgdFrameGrabberFormatRGB32.Text = "RGB32"
        Me.rgdFrameGrabberFormatRGB32.UseVisualStyleBackColor = False
        '
        'rgdFrameGrabberFormatRGB24
        '
        Me.rgdFrameGrabberFormatRGB24.BackColor = System.Drawing.SystemColors.Control
        Me.rgdFrameGrabberFormatRGB24.Cursor = System.Windows.Forms.Cursors.Default
        Me.rgdFrameGrabberFormatRGB24.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgdFrameGrabberFormatRGB24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rgdFrameGrabberFormatRGB24.Location = New System.Drawing.Point(10, 64)
        Me.rgdFrameGrabberFormatRGB24.Name = "rgdFrameGrabberFormatRGB24"
        Me.rgdFrameGrabberFormatRGB24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rgdFrameGrabberFormatRGB24.Size = New System.Drawing.Size(78, 21)
        Me.rgdFrameGrabberFormatRGB24.TabIndex = 11
        Me.rgdFrameGrabberFormatRGB24.TabStop = True
        Me.rgdFrameGrabberFormatRGB24.Tag = "2"
        Me.rgdFrameGrabberFormatRGB24.Text = "RGB24"
        Me.rgdFrameGrabberFormatRGB24.UseVisualStyleBackColor = False
        '
        'rgdFrameGrabberFormat565
        '
        Me.rgdFrameGrabberFormat565.BackColor = System.Drawing.SystemColors.Control
        Me.rgdFrameGrabberFormat565.Cursor = System.Windows.Forms.Cursors.Default
        Me.rgdFrameGrabberFormat565.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgdFrameGrabberFormat565.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rgdFrameGrabberFormat565.Location = New System.Drawing.Point(83, 20)
        Me.rgdFrameGrabberFormat565.Name = "rgdFrameGrabberFormat565"
        Me.rgdFrameGrabberFormat565.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rgdFrameGrabberFormat565.Size = New System.Drawing.Size(78, 21)
        Me.rgdFrameGrabberFormat565.TabIndex = 10
        Me.rgdFrameGrabberFormat565.TabStop = True
        Me.rgdFrameGrabberFormat565.Tag = "3"
        Me.rgdFrameGrabberFormat565.Text = "RGB565"
        Me.rgdFrameGrabberFormat565.UseVisualStyleBackColor = False
        '
        'rgdFrameGrabber
        '
        Me.rgdFrameGrabber.BackColor = System.Drawing.SystemColors.Control
        Me.rgdFrameGrabber.Controls.Add(Me.rgdFrameGrabberPreviewStream)
        Me.rgdFrameGrabber.Controls.Add(Me.rgdFrameGrabberCaptureStream)
        Me.rgdFrameGrabber.Controls.Add(Me.rgdFrameGrabberDisabled)
        Me.rgdFrameGrabber.Controls.Add(Me.rgdFrameGrabberBothStreams)
        Me.rgdFrameGrabber.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgdFrameGrabber.ForeColor = System.Drawing.SystemColors.Highlight
        Me.rgdFrameGrabber.Location = New System.Drawing.Point(5, 20)
        Me.rgdFrameGrabber.Name = "rgdFrameGrabber"
        Me.rgdFrameGrabber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rgdFrameGrabber.Size = New System.Drawing.Size(122, 119)
        Me.rgdFrameGrabber.TabIndex = 0
        Me.rgdFrameGrabber.TabStop = False
        Me.rgdFrameGrabber.Text = "Frame grabber"
        '
        'rgdFrameGrabberPreviewStream
        '
        Me.rgdFrameGrabberPreviewStream.BackColor = System.Drawing.SystemColors.Control
        Me.rgdFrameGrabberPreviewStream.Cursor = System.Windows.Forms.Cursors.Default
        Me.rgdFrameGrabberPreviewStream.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgdFrameGrabberPreviewStream.ForeColor = System.Drawing.SystemColors.Highlight
        Me.rgdFrameGrabberPreviewStream.Location = New System.Drawing.Point(7, 43)
        Me.rgdFrameGrabberPreviewStream.Name = "rgdFrameGrabberPreviewStream"
        Me.rgdFrameGrabberPreviewStream.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rgdFrameGrabberPreviewStream.Size = New System.Drawing.Size(97, 21)
        Me.rgdFrameGrabberPreviewStream.TabIndex = 3
        Me.rgdFrameGrabberPreviewStream.TabStop = True
        Me.rgdFrameGrabberPreviewStream.Tag = "1"
        Me.rgdFrameGrabberPreviewStream.Text = "preview"
        Me.rgdFrameGrabberPreviewStream.UseVisualStyleBackColor = False
        '
        'rgdFrameGrabberCaptureStream
        '
        Me.rgdFrameGrabberCaptureStream.BackColor = System.Drawing.SystemColors.Control
        Me.rgdFrameGrabberCaptureStream.Cursor = System.Windows.Forms.Cursors.Default
        Me.rgdFrameGrabberCaptureStream.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgdFrameGrabberCaptureStream.ForeColor = System.Drawing.SystemColors.Highlight
        Me.rgdFrameGrabberCaptureStream.Location = New System.Drawing.Point(7, 66)
        Me.rgdFrameGrabberCaptureStream.Name = "rgdFrameGrabberCaptureStream"
        Me.rgdFrameGrabberCaptureStream.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rgdFrameGrabberCaptureStream.Size = New System.Drawing.Size(97, 21)
        Me.rgdFrameGrabberCaptureStream.TabIndex = 2
        Me.rgdFrameGrabberCaptureStream.TabStop = True
        Me.rgdFrameGrabberCaptureStream.Tag = "2"
        Me.rgdFrameGrabberCaptureStream.Text = "capture"
        Me.rgdFrameGrabberCaptureStream.UseVisualStyleBackColor = False
        '
        'rgdFrameGrabberDisabled
        '
        Me.rgdFrameGrabberDisabled.BackColor = System.Drawing.SystemColors.Control
        Me.rgdFrameGrabberDisabled.Cursor = System.Windows.Forms.Cursors.Default
        Me.rgdFrameGrabberDisabled.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgdFrameGrabberDisabled.ForeColor = System.Drawing.SystemColors.Highlight
        Me.rgdFrameGrabberDisabled.Location = New System.Drawing.Point(7, 90)
        Me.rgdFrameGrabberDisabled.Name = "rgdFrameGrabberDisabled"
        Me.rgdFrameGrabberDisabled.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rgdFrameGrabberDisabled.Size = New System.Drawing.Size(97, 21)
        Me.rgdFrameGrabberDisabled.TabIndex = 1
        Me.rgdFrameGrabberDisabled.TabStop = True
        Me.rgdFrameGrabberDisabled.Tag = "3"
        Me.rgdFrameGrabberDisabled.Text = "disabled"
        Me.rgdFrameGrabberDisabled.UseVisualStyleBackColor = False
        '
        'rgdFrameGrabberBothStreams
        '
        Me.rgdFrameGrabberBothStreams.BackColor = System.Drawing.SystemColors.Control
        Me.rgdFrameGrabberBothStreams.Cursor = System.Windows.Forms.Cursors.Default
        Me.rgdFrameGrabberBothStreams.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgdFrameGrabberBothStreams.ForeColor = System.Drawing.SystemColors.Highlight
        Me.rgdFrameGrabberBothStreams.Location = New System.Drawing.Point(7, 20)
        Me.rgdFrameGrabberBothStreams.Name = "rgdFrameGrabberBothStreams"
        Me.rgdFrameGrabberBothStreams.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rgdFrameGrabberBothStreams.Size = New System.Drawing.Size(107, 21)
        Me.rgdFrameGrabberBothStreams.TabIndex = 4
        Me.rgdFrameGrabberBothStreams.TabStop = True
        Me.rgdFrameGrabberBothStreams.Tag = "0"
        Me.rgdFrameGrabberBothStreams.Text = "both streams"
        Me.rgdFrameGrabberBothStreams.UseVisualStyleBackColor = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.SystemColors.Control
        Me.Label32.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label32.Location = New System.Drawing.Point(5, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label32.Size = New System.Drawing.Size(112, 16)
        Me.Label32.TabIndex = 6
        Me.Label32.Text = "Frame grabber"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.SystemColors.Control
        Me.Label33.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label33.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label33.Location = New System.Drawing.Point(139, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label33.Size = New System.Drawing.Size(860, 16)
        Me.Label33.TabIndex = 5
        Me.Label33.Text = "The frame grabber handles frame capture, frame overlay and video processing, so t" & _
            "hese features are not available when it is disabled. "
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(761, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "capture width:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(761, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 20)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "capture height:"
        '
        'edtFrameCaptureWidth
        '
        Me.edtFrameCaptureWidth.Location = New System.Drawing.Point(761, 150)
        Me.edtFrameCaptureWidth.Name = "edtFrameCaptureWidth"
        Me.edtFrameCaptureWidth.Size = New System.Drawing.Size(96, 23)
        Me.edtFrameCaptureWidth.TabIndex = 39
        '
        'edtFrameCaptureHeight
        '
        Me.edtFrameCaptureHeight.Location = New System.Drawing.Point(761, 196)
        Me.edtFrameCaptureHeight.Name = "edtFrameCaptureHeight"
        Me.edtFrameCaptureHeight.Size = New System.Drawing.Size(96, 23)
        Me.edtFrameCaptureHeight.TabIndex = 40
        '
        'FrameGrabber
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.ClientSize = New System.Drawing.Size(1113, 243)
        Me.ControlBox = False
        Me.Controls.Add(Me.edtFrameCaptureHeight)
        Me.Controls.Add(Me.edtFrameCaptureWidth)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Frame11)
        Me.Controls.Add(Me.mmoFrameCaptureLog)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.rdgAutoFileName)
        Me.Controls.Add(Me.grbBurstMode)
        Me.Controls.Add(Me.grbOneShot)
        Me.Controls.Add(Me.rgdFrameGrabberFormat)
        Me.Controls.Add(Me.rgdFrameGrabber)
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrameGrabber"
        Me.ShowInTaskbar = False
        Me.Frame11.ResumeLayout(False)
        Me.Frame11.PerformLayout()
        CType(Me.tbrCaptureZoomSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rdgAutoFileName.ResumeLayout(False)
        Me.rdgAutoFileName.PerformLayout()
        Me.grbBurstMode.ResumeLayout(False)
        Me.grbBurstMode.PerformLayout()
        Me.grbOneShot.ResumeLayout(False)
        Me.grbOneShot.PerformLayout()
        Me.rgdFrameGrabberFormat.ResumeLayout(False)
        Me.rgdFrameGrabber.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Public Sub RefreshControls()
        SetRadioButtonInGroupUsingTag((rgdFrameGrabber), MainForm.DefInstance.VideoGrabber1.FrameGrabber)
        SetRadioButtonInGroupUsingTag((rgdFrameGrabberFormat), MainForm.DefInstance.VideoGrabber1.FrameGrabberRGBFormat)
        SetRadioButtonInGroupUsingTag((rdgAutoFileName), MainForm.DefInstance.VideoGrabber1.AutoFileName)

        edtAVIAutoFilePrefix.Text = MainForm.DefInstance.VideoGrabber1.AutoFilePrefix

        edtBurstCount.Text = MainForm.DefInstance.VideoGrabber1.BurstCount
        edtBurstInterval.Text = MainForm.DefInstance.VideoGrabber1.BurstInterval
        tbrCaptureZoomSize.Value = MainForm.DefInstance.VideoGrabber1.FrameCaptureZoomSize
        edtFrameCaptureWidth.Text = MainForm.DefInstance.VideoGrabber1.FrameCaptureWidth.ToString
        edtFrameCaptureHeight.Text = MainForm.DefInstance.VideoGrabber1.FrameCaptureHeight.ToString
    End Sub

    Private Sub btnBurstModeBMPFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBurstModeBMPFile.Click
        MainForm.DefInstance.VideoGrabber1.BurstType = VidGrab.TFrameCaptureDest.fc_BmpFile
        MainForm.DefInstance.VideoGrabber1.BurstMode = True
        ' The frame capture starts when BurstMode is set to True.
        ' If BurstCount = 0 the frame capture won"t stop.
        ' BMP file names will be generated automatically according to AutoFileName
        ' and AutoFilePrefix. They will be returned by the OnFrameCaptureCompleted event.
    End Sub

    Private Sub btnBurstModeJPEGFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBurstModeJPEGFile.Click
        MainForm.DefInstance.VideoGrabber1.BurstType = VidGrab.TFrameCaptureDest.fc_JpegFile
        MainForm.DefInstance.VideoGrabber1.BurstMode = True
        ' The frame capture starts when BurstMode is set to True.
        ' If BurstCount = 0 the frame capture won"t stop.
        ' JPEG file names will be generated automatically according to AutoFileName
        ' and AutoFilePrefix. They will be returned by the OnFrameCaptureCompleted event.
    End Sub

    Private Sub btnBurstModeClipboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBurstModeClipboard.Click
        MainForm.DefInstance.VideoGrabber1.BurstType = VidGrab.TFrameCaptureDest.fc_Clipboard
        MainForm.DefInstance.VideoGrabber1.BurstMode = True
        ' The frame capture starts when BurstMode is set to True.
        ' If BurstCount = 0 the frame capture won"t stop.
        ' Captured frames will be returned by the OnFrameCaptureCompleted event.
    End Sub

    Private Sub btnBurstModeStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBurstModeStop.Click
        MainForm.DefInstance.VideoGrabber1.BurstMode = False
    End Sub

    Private Sub btnBurstModeTBitmap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBurstModeTBitmap.Click
        MainForm.DefInstance.VideoGrabber1.BurstType = VidGrab.TFrameCaptureDest.fc_TBitmap
        MainForm.DefInstance.VideoGrabber1.BurstMode = True
        ' The frame capture starts when BurstMode is set to True.
        ' If BurstCount = 0 the frame capture won"t stop.
        ' Captured frames will be returned by the OnFrameCaptureCompleted event.
    End Sub

    Private Sub btnOneShotBMPFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOneShotBMPFile.Click
        If chkUseThisFileName.Checked Then
            MainForm.DefInstance.VideoGrabber1.CaptureFrameTo(VidGrab.TFrameCaptureDest.fc_BmpFile, edtUseThisFileName.Text)
        Else
            MainForm.DefInstance.VideoGrabber1.CaptureFrameTo(VidGrab.TFrameCaptureDest.fc_BmpFile, "")
        End If
        ' note 1: passing an empty file name let TVideoGrabber generate it automatically in the StoragePath directory
        ' note 2: using CaptureFrameSyncTo instead of CaptureFrameTo waits for frame capture completion and returns true upon success

    End Sub

    Private Sub btnOneShotJPEGFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOneShotJPEGFile.Click
        If chkUseThisFileName.Checked Then
            MainForm.DefInstance.VideoGrabber1.CaptureFrameTo(VidGrab.TFrameCaptureDest.fc_JpegFile, edtUseThisFileName.Text)
        Else
            MainForm.DefInstance.VideoGrabber1.CaptureFrameTo(VidGrab.TFrameCaptureDest.fc_JpegFile, "")
        End If
        ' note 1: passing an empty file name let TVideoGrabber generate it automatically in the StoragePath directory
        ' note 2: using CaptureFrameSyncTo instead of CaptureFrameTo waits for frame capture completion and returns true upon success
    End Sub

    Private Sub btnOneShotClipboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOneShotClipboard.Click
        MainForm.DefInstance.VideoGrabber1.CaptureFrameTo(VidGrab.TFrameCaptureDest.fc_Clipboard, "")
    End Sub

    Private Sub btnOneShotTBitmap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOneShotTBitmap.Click
        MainForm.DefInstance.VideoGrabber1.CaptureFrameTo(VidGrab.TFrameCaptureDest.fc_TBitmap, "")
    End Sub

    Private Sub chkUseThisFileName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUseThisFileName.CheckedChanged
        edtUseThisFileName.Enabled = chkUseThisFileName.Checked
    End Sub

    Private Sub edtAVIAutoFilePrefix_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtAVIAutoFilePrefix.TextChanged
        MainForm.DefInstance.VideoGrabber1.AutoFilePrefix = edtAVIAutoFilePrefix.Text
    End Sub

    Private Sub edtBurstCount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtBurstCount.TextChanged
        If IsNumeric(edtBurstCount.Text) Then
            MainForm.DefInstance.VideoGrabber1.BurstCount = edtBurstCount.Text
        End If
    End Sub

    Private Sub edtBurstInterval_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtBurstInterval.TextChanged
        If IsNumeric(edtBurstInterval.Text) Then
            MainForm.DefInstance.VideoGrabber1.BurstInterval = edtBurstInterval.Text
        End If
    End Sub

    Private Sub rdgAutoFileName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgAutoFileName1.CheckedChanged, rdgAutoFileName2.CheckedChanged, rdgAutoFileName3.CheckedChanged
        If CType(sender, RadioButton).Checked Then
            MainForm.DefInstance.VideoGrabber1.AutoFileName = sender.tag
        End If
    End Sub

    Private Sub rgdFrameGrabber_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgdFrameGrabberBothStreams.CheckedChanged, rgdFrameGrabberPreviewStream.CheckedChanged, rgdFrameGrabberCaptureStream.CheckedChanged, rgdFrameGrabberDisabled.CheckedChanged
        If CType(sender, RadioButton).Checked Then
            MainForm.DefInstance.VideoGrabber1.FrameGrabber = sender.tag
            'Me.RefreshControls()
        End If
    End Sub

    Private Sub rgdFrameGrabberRGBFormat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgdFrameGrabberFormatDefault.CheckedChanged, rgdFrameGrabberFormatRGB32.CheckedChanged, rgdFrameGrabberFormatRGB24.CheckedChanged, rgdFrameGrabberFormat565.CheckedChanged, rgdFrameGrabberFormatRGB555.CheckedChanged, rgdFrameGrabberFormatRGB8.CheckedChanged
        If CType(sender, RadioButton).Checked Then
            MainForm.DefInstance.VideoGrabber1.FrameGrabberRGBFormat = sender.tag
        End If
    End Sub

    Private Sub btnResetCaptureZoomSize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetCaptureZoomSize.Click
        tbrCaptureZoomSize.Value = 100
        MainForm.DefInstance.VideoGrabber1.FrameCaptureZoomSize = tbrCaptureZoomSize.Value
        edtCaptureZoomSize.Text = tbrCaptureZoomSize.Value.ToString & "%"
        tbrCaptureZoomSize.Refresh()
    End Sub

    Private Sub tbrCaptureZoomSize_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrCaptureZoomSize.Scroll
        MainForm.DefInstance.VideoGrabber1.FrameCaptureZoomSize = tbrCaptureZoomSize.Value
        edtCaptureZoomSize.Text = tbrCaptureZoomSize.Value.ToString & "%"
    End Sub

    Private Sub edtFrameCaptureWidth_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtFrameCaptureWidth.TextChanged
        If IsNumeric(edtFrameCaptureWidth.Text) Then
            MainForm.DefInstance.VideoGrabber1.FrameCaptureWidth = edtFrameCaptureWidth.Text
        End If
    End Sub

    Private Sub edtFrameCaptureHeight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtFrameCaptureHeight.TextChanged
        If IsNumeric(edtFrameCaptureHeight.Text) Then
            MainForm.DefInstance.VideoGrabber1.FrameCaptureHeight = edtFrameCaptureHeight.Text
        End If
    End Sub

    Private Sub FrameGrabber_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Visible Then
            RefreshControls()
        End If
    End Sub
End Class
