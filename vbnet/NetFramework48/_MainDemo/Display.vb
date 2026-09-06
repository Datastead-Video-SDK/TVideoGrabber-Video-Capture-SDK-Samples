Option Strict Off
Option Explicit On
Friend Class Display
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
    Public WithEvents btnNewLocation2 As System.Windows.Forms.Button
    Public WithEvents btnNewLocation As System.Windows.Forms.Button
    Public WithEvents chkAutoSize As System.Windows.Forms.CheckBox
    Public WithEvents chkStayOnTop As System.Windows.Forms.CheckBox
    Public WithEvents chkMouseMovesWindow As System.Windows.Forms.CheckBox
    Public WithEvents chkEmbedded As System.Windows.Forms.CheckBox
    Friend WithEvents rdgAspectRatio As System.Windows.Forms.GroupBox
    Friend WithEvents rdgDisplayAspectRatioPanScan As System.Windows.Forms.RadioButton
    Friend WithEvents rdgDisplayAspectRatioStretch As System.Windows.Forms.RadioButton
    Friend WithEvents rdgDisplayAspectRatioPan As System.Windows.Forms.RadioButton
    Friend WithEvents rdgDisplayAspectRatioBox As System.Windows.Forms.RadioButton
    Friend WithEvents chkVisible As System.Windows.Forms.CheckBox
    Friend WithEvents tbrPanScan As System.Windows.Forms.TrackBar
    Public WithEvents chkUseVideoPort As System.Windows.Forms.CheckBox
    Public WithEvents chkFullScreen As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnTestPanScanHelp As System.Windows.Forms.Button
    Friend WithEvents btnTestPanScan As System.Windows.Forms.Button
    Private WithEvents txtDisplayMonitor As System.Windows.Forms.TextBox
    Private WithEvents lblMonitorNumber As System.Windows.Forms.Label
    Friend WithEvents tbrAlphablend As System.Windows.Forms.TrackBar
    Private WithEvents chkAlphablend As System.Windows.Forms.CheckBox
    Private WithEvents txtTransparentColor As System.Windows.Forms.TextBox
    Private WithEvents chkTransparentColor As System.Windows.Forms.CheckBox
    Public WithEvents grbMainVideoWindow As System.Windows.Forms.GroupBox
    Private WithEvents chkDisplayActive As System.Windows.Forms.CheckBox
    Private WithEvents rdgSelectDisplay0 As System.Windows.Forms.RadioButton
    Private WithEvents rdgSelectDisplay1 As System.Windows.Forms.RadioButton
    Private WithEvents rdgSelectDisplay2 As System.Windows.Forms.RadioButton
    Private WithEvents rdgSelectDisplay3 As System.Windows.Forms.RadioButton
    Private WithEvents rdgSelectDisplay4 As System.Windows.Forms.RadioButton
    Private WithEvents rdgSelectDisplay5 As System.Windows.Forms.RadioButton
    Private WithEvents rdgSelectDisplay6 As System.Windows.Forms.RadioButton
    Private WithEvents rdgSelectDisplay7 As System.Windows.Forms.RadioButton
    Private WithEvents rdgSelectDisplay8 As System.Windows.Forms.RadioButton
    Private WithEvents rdgSelectDisplay9 As System.Windows.Forms.RadioButton
    Private WithEvents rdgDisplaySelected As System.Windows.Forms.GroupBox
    Friend WithEvents chkBlackMagicOutput As System.Windows.Forms.CheckBox
    Public WithEvents chkAdjustPixelAspectRatio As System.Windows.Forms.CheckBox
    Friend WithEvents chkVideoVisibleWhenStopped As System.Windows.Forms.CheckBox
    Friend WithEvents rdgVideoRendererRecPriority As System.Windows.Forms.RadioButton
    Public WithEvents rdgVideoRendererVMR9 As System.Windows.Forms.RadioButton
    Public WithEvents rdgVideoRendererVMR7 As System.Windows.Forms.RadioButton
    Public WithEvents rdgVideoRendererAutoSelect As System.Windows.Forms.RadioButton
    Public WithEvents rdgVideoRendererStandard As System.Windows.Forms.RadioButton
    Public WithEvents rdgVideoRendererOverlay As System.Windows.Forms.RadioButton
    Friend WithEvents rdgVideoRendererNone As System.Windows.Forms.RadioButton
    Public WithEvents rdgVideoRendererEVR As System.Windows.Forms.RadioButton
    Public WithEvents rdgVideoRenderer As System.Windows.Forms.GroupBox
    Private WithEvents rdgVideoRendererMadVR As System.Windows.Forms.RadioButton
    Friend WithEvents chkTransparency As System.Windows.Forms.CheckBox
    Public WithEvents imgLogo As System.Windows.Forms.PictureBox
    Public WithEvents chkChangeCursor As System.Windows.Forms.CheckBox
    Public WithEvents chkBorder As System.Windows.Forms.CheckBox
    Public WithEvents chkSetLogo As System.Windows.Forms.CheckBox
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Display))
        Me.btnNewLocation2 = New System.Windows.Forms.Button
        Me.btnNewLocation = New System.Windows.Forms.Button
        Me.chkAutoSize = New System.Windows.Forms.CheckBox
        Me.chkStayOnTop = New System.Windows.Forms.CheckBox
        Me.chkMouseMovesWindow = New System.Windows.Forms.CheckBox
        Me.chkEmbedded = New System.Windows.Forms.CheckBox
        Me.rdgAspectRatio = New System.Windows.Forms.GroupBox
        Me.rdgDisplayAspectRatioPanScan = New System.Windows.Forms.RadioButton
        Me.rdgDisplayAspectRatioStretch = New System.Windows.Forms.RadioButton
        Me.rdgDisplayAspectRatioPan = New System.Windows.Forms.RadioButton
        Me.rdgDisplayAspectRatioBox = New System.Windows.Forms.RadioButton
        Me.chkVisible = New System.Windows.Forms.CheckBox
        Me.tbrPanScan = New System.Windows.Forms.TrackBar
        Me.chkUseVideoPort = New System.Windows.Forms.CheckBox
        Me.chkFullScreen = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnTestPanScanHelp = New System.Windows.Forms.Button
        Me.btnTestPanScan = New System.Windows.Forms.Button
        Me.txtDisplayMonitor = New System.Windows.Forms.TextBox
        Me.lblMonitorNumber = New System.Windows.Forms.Label
        Me.tbrAlphablend = New System.Windows.Forms.TrackBar
        Me.chkAlphablend = New System.Windows.Forms.CheckBox
        Me.txtTransparentColor = New System.Windows.Forms.TextBox
        Me.chkTransparentColor = New System.Windows.Forms.CheckBox
        Me.grbMainVideoWindow = New System.Windows.Forms.GroupBox
        Me.chkDisplayActive = New System.Windows.Forms.CheckBox
        Me.rdgSelectDisplay0 = New System.Windows.Forms.RadioButton
        Me.rdgSelectDisplay1 = New System.Windows.Forms.RadioButton
        Me.rdgSelectDisplay2 = New System.Windows.Forms.RadioButton
        Me.rdgSelectDisplay3 = New System.Windows.Forms.RadioButton
        Me.rdgSelectDisplay4 = New System.Windows.Forms.RadioButton
        Me.rdgSelectDisplay5 = New System.Windows.Forms.RadioButton
        Me.rdgSelectDisplay6 = New System.Windows.Forms.RadioButton
        Me.rdgSelectDisplay7 = New System.Windows.Forms.RadioButton
        Me.rdgSelectDisplay8 = New System.Windows.Forms.RadioButton
        Me.rdgSelectDisplay9 = New System.Windows.Forms.RadioButton
        Me.rdgDisplaySelected = New System.Windows.Forms.GroupBox
        Me.chkBlackMagicOutput = New System.Windows.Forms.CheckBox
        Me.chkAdjustPixelAspectRatio = New System.Windows.Forms.CheckBox
        Me.chkVideoVisibleWhenStopped = New System.Windows.Forms.CheckBox
        Me.rdgVideoRendererRecPriority = New System.Windows.Forms.RadioButton
        Me.rdgVideoRendererVMR9 = New System.Windows.Forms.RadioButton
        Me.rdgVideoRendererVMR7 = New System.Windows.Forms.RadioButton
        Me.rdgVideoRendererAutoSelect = New System.Windows.Forms.RadioButton
        Me.rdgVideoRendererStandard = New System.Windows.Forms.RadioButton
        Me.rdgVideoRendererOverlay = New System.Windows.Forms.RadioButton
        Me.rdgVideoRendererNone = New System.Windows.Forms.RadioButton
        Me.rdgVideoRendererEVR = New System.Windows.Forms.RadioButton
        Me.rdgVideoRenderer = New System.Windows.Forms.GroupBox
        Me.rdgVideoRendererMadVR = New System.Windows.Forms.RadioButton
        Me.chkTransparency = New System.Windows.Forms.CheckBox
        Me.imgLogo = New System.Windows.Forms.PictureBox
        Me.chkChangeCursor = New System.Windows.Forms.CheckBox
        Me.chkBorder = New System.Windows.Forms.CheckBox
        Me.chkSetLogo = New System.Windows.Forms.CheckBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.rdgAspectRatio.SuspendLayout()
        CType(Me.tbrPanScan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrAlphablend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbMainVideoWindow.SuspendLayout()
        Me.rdgDisplaySelected.SuspendLayout()
        Me.rdgVideoRenderer.SuspendLayout()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNewLocation2
        '
        Me.btnNewLocation2.BackColor = System.Drawing.SystemColors.Control
        Me.btnNewLocation2.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnNewLocation2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewLocation2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNewLocation2.Location = New System.Drawing.Point(419, 113)
        Me.btnNewLocation2.Name = "btnNewLocation2"
        Me.btnNewLocation2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnNewLocation2.Size = New System.Drawing.Size(168, 26)
        Me.btnNewLocation2.TabIndex = 11
        Me.btnNewLocation2.Text = "location 20,20 (480,200)"
        Me.btnNewLocation2.UseVisualStyleBackColor = False
        '
        'btnNewLocation
        '
        Me.btnNewLocation.BackColor = System.Drawing.SystemColors.Control
        Me.btnNewLocation.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnNewLocation.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewLocation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNewLocation.Location = New System.Drawing.Point(419, 142)
        Me.btnNewLocation.Name = "btnNewLocation"
        Me.btnNewLocation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnNewLocation.Size = New System.Drawing.Size(168, 25)
        Me.btnNewLocation.TabIndex = 12
        Me.btnNewLocation.Text = "location 10,10 (autosize)"
        Me.btnNewLocation.UseVisualStyleBackColor = False
        '
        'chkAutoSize
        '
        Me.chkAutoSize.BackColor = System.Drawing.SystemColors.Control
        Me.chkAutoSize.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAutoSize.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAutoSize.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAutoSize.Location = New System.Drawing.Point(95, 17)
        Me.chkAutoSize.Name = "chkAutoSize"
        Me.chkAutoSize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAutoSize.Size = New System.Drawing.Size(96, 21)
        Me.chkAutoSize.TabIndex = 16
        Me.chkAutoSize.Text = "autosize"
        Me.chkAutoSize.UseVisualStyleBackColor = False
        '
        'chkStayOnTop
        '
        Me.chkStayOnTop.BackColor = System.Drawing.SystemColors.Control
        Me.chkStayOnTop.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkStayOnTop.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkStayOnTop.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkStayOnTop.Location = New System.Drawing.Point(368, 17)
        Me.chkStayOnTop.Name = "chkStayOnTop"
        Me.chkStayOnTop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkStayOnTop.Size = New System.Drawing.Size(106, 21)
        Me.chkStayOnTop.TabIndex = 17
        Me.chkStayOnTop.Text = "stay on top"
        Me.chkStayOnTop.UseVisualStyleBackColor = False
        '
        'chkMouseMovesWindow
        '
        Me.chkMouseMovesWindow.BackColor = System.Drawing.SystemColors.Control
        Me.chkMouseMovesWindow.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkMouseMovesWindow.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMouseMovesWindow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkMouseMovesWindow.Location = New System.Drawing.Point(198, 17)
        Me.chkMouseMovesWindow.Name = "chkMouseMovesWindow"
        Me.chkMouseMovesWindow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkMouseMovesWindow.Size = New System.Drawing.Size(163, 21)
        Me.chkMouseMovesWindow.TabIndex = 18
        Me.chkMouseMovesWindow.Text = "mouse moves window"
        Me.chkMouseMovesWindow.UseVisualStyleBackColor = False
        '
        'chkEmbedded
        '
        Me.chkEmbedded.BackColor = System.Drawing.SystemColors.Control
        Me.chkEmbedded.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkEmbedded.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEmbedded.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkEmbedded.Location = New System.Drawing.Point(10, 37)
        Me.chkEmbedded.Name = "chkEmbedded"
        Me.chkEmbedded.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkEmbedded.Size = New System.Drawing.Size(127, 25)
        Me.chkEmbedded.TabIndex = 22
        Me.chkEmbedded.Text = "embedded"
        Me.chkEmbedded.UseVisualStyleBackColor = False
        '
        'rdgAspectRatio
        '
        Me.rdgAspectRatio.Controls.Add(Me.rdgDisplayAspectRatioPanScan)
        Me.rdgAspectRatio.Controls.Add(Me.rdgDisplayAspectRatioStretch)
        Me.rdgAspectRatio.Controls.Add(Me.rdgDisplayAspectRatioPan)
        Me.rdgAspectRatio.Controls.Add(Me.rdgDisplayAspectRatioBox)
        Me.rdgAspectRatio.Location = New System.Drawing.Point(10, 66)
        Me.rdgAspectRatio.Name = "rdgAspectRatio"
        Me.rdgAspectRatio.Size = New System.Drawing.Size(111, 103)
        Me.rdgAspectRatio.TabIndex = 23
        Me.rdgAspectRatio.TabStop = False
        Me.rdgAspectRatio.Text = "aspect ratio"
        '
        'rdgDisplayAspectRatioPanScan
        '
        Me.rdgDisplayAspectRatioPanScan.AutoSize = True
        Me.rdgDisplayAspectRatioPanScan.Location = New System.Drawing.Point(10, 76)
        Me.rdgDisplayAspectRatioPanScan.Name = "rdgDisplayAspectRatioPanScan"
        Me.rdgDisplayAspectRatioPanScan.Size = New System.Drawing.Size(88, 20)
        Me.rdgDisplayAspectRatioPanScan.TabIndex = 3
        Me.rdgDisplayAspectRatioPanScan.Tag = "3"
        Me.rdgDisplayAspectRatioPanScan.Text = "pan-scan"
        '
        'rdgDisplayAspectRatioStretch
        '
        Me.rdgDisplayAspectRatioStretch.AutoSize = True
        Me.rdgDisplayAspectRatioStretch.Location = New System.Drawing.Point(10, 57)
        Me.rdgDisplayAspectRatioStretch.Name = "rdgDisplayAspectRatioStretch"
        Me.rdgDisplayAspectRatioStretch.Size = New System.Drawing.Size(72, 20)
        Me.rdgDisplayAspectRatioStretch.TabIndex = 2
        Me.rdgDisplayAspectRatioStretch.Tag = "2"
        Me.rdgDisplayAspectRatioStretch.Text = "stretch"
        '
        'rdgDisplayAspectRatioPan
        '
        Me.rdgDisplayAspectRatioPan.AutoSize = True
        Me.rdgDisplayAspectRatioPan.Location = New System.Drawing.Point(10, 37)
        Me.rdgDisplayAspectRatioPan.Name = "rdgDisplayAspectRatioPan"
        Me.rdgDisplayAspectRatioPan.Size = New System.Drawing.Size(86, 20)
        Me.rdgDisplayAspectRatioPan.TabIndex = 1
        Me.rdgDisplayAspectRatioPan.Tag = "1"
        Me.rdgDisplayAspectRatioPan.Text = "no resize"
        '
        'rdgDisplayAspectRatioBox
        '
        Me.rdgDisplayAspectRatioBox.Location = New System.Drawing.Point(10, 17)
        Me.rdgDisplayAspectRatioBox.Name = "rdgDisplayAspectRatioBox"
        Me.rdgDisplayAspectRatioBox.Size = New System.Drawing.Size(51, 20)
        Me.rdgDisplayAspectRatioBox.TabIndex = 0
        Me.rdgDisplayAspectRatioBox.Tag = "0"
        Me.rdgDisplayAspectRatioBox.Text = "box"
        '
        'chkVisible
        '
        Me.chkVisible.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVisible.Location = New System.Drawing.Point(10, 17)
        Me.chkVisible.Name = "chkVisible"
        Me.chkVisible.Size = New System.Drawing.Size(84, 21)
        Me.chkVisible.TabIndex = 24
        Me.chkVisible.Text = "visible"
        '
        'tbrPanScan
        '
        Me.tbrPanScan.AutoSize = False
        Me.tbrPanScan.Location = New System.Drawing.Point(132, 138)
        Me.tbrPanScan.Maximum = 100
        Me.tbrPanScan.Name = "tbrPanScan"
        Me.tbrPanScan.Size = New System.Drawing.Size(170, 24)
        Me.tbrPanScan.TabIndex = 26
        Me.tbrPanScan.TickFrequency = 10
        Me.tbrPanScan.Value = 50
        '
        'chkUseVideoPort
        '
        Me.chkUseVideoPort.BackColor = System.Drawing.SystemColors.Control
        Me.chkUseVideoPort.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkUseVideoPort.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseVideoPort.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkUseVideoPort.Location = New System.Drawing.Point(466, 17)
        Me.chkUseVideoPort.Name = "chkUseVideoPort"
        Me.chkUseVideoPort.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkUseVideoPort.Size = New System.Drawing.Size(114, 21)
        Me.chkUseVideoPort.TabIndex = 21
        Me.chkUseVideoPort.Text = "use video port"
        Me.chkUseVideoPort.UseVisualStyleBackColor = False
        '
        'chkFullScreen
        '
        Me.chkFullScreen.BackColor = System.Drawing.SystemColors.Control
        Me.chkFullScreen.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkFullScreen.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFullScreen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkFullScreen.Location = New System.Drawing.Point(198, 37)
        Me.chkFullScreen.Name = "chkFullScreen"
        Me.chkFullScreen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkFullScreen.Size = New System.Drawing.Size(96, 21)
        Me.chkFullScreen.TabIndex = 19
        Me.chkFullScreen.Text = "full screen"
        Me.chkFullScreen.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "pan-scan (0..100)"
        '
        'btnTestPanScanHelp
        '
        Me.btnTestPanScanHelp.Location = New System.Drawing.Point(307, 142)
        Me.btnTestPanScanHelp.Name = "btnTestPanScanHelp"
        Me.btnTestPanScanHelp.Size = New System.Drawing.Size(22, 25)
        Me.btnTestPanScanHelp.TabIndex = 28
        Me.btnTestPanScanHelp.Text = "?"
        '
        'btnTestPanScan
        '
        Me.btnTestPanScan.Location = New System.Drawing.Point(310, 113)
        Me.btnTestPanScan.Name = "btnTestPanScan"
        Me.btnTestPanScan.Size = New System.Drawing.Size(98, 26)
        Me.btnTestPanScan.TabIndex = 27
        Me.btnTestPanScan.Text = "test pan-scan"
        '
        'txtDisplayMonitor
        '
        Me.txtDisplayMonitor.Location = New System.Drawing.Point(535, 50)
        Me.txtDisplayMonitor.Name = "txtDisplayMonitor"
        Me.txtDisplayMonitor.Size = New System.Drawing.Size(45, 23)
        Me.txtDisplayMonitor.TabIndex = 29
        '
        'lblMonitorNumber
        '
        Me.lblMonitorNumber.AutoSize = True
        Me.lblMonitorNumber.Location = New System.Drawing.Point(371, 54)
        Me.lblMonitorNumber.Name = "lblMonitorNumber"
        Me.lblMonitorNumber.Size = New System.Drawing.Size(172, 16)
        Me.lblMonitorNumber.TabIndex = 30
        Me.lblMonitorNumber.Text = "assign to monitor number:"
        '
        'tbrAlphablend
        '
        Me.tbrAlphablend.AutoSize = False
        Me.tbrAlphablend.Location = New System.Drawing.Point(132, 91)
        Me.tbrAlphablend.Maximum = 255
        Me.tbrAlphablend.Name = "tbrAlphablend"
        Me.tbrAlphablend.Size = New System.Drawing.Size(170, 25)
        Me.tbrAlphablend.TabIndex = 31
        Me.tbrAlphablend.TickFrequency = 10
        Me.tbrAlphablend.Value = 180
        '
        'chkAlphablend
        '
        Me.chkAlphablend.AutoSize = True
        Me.chkAlphablend.Location = New System.Drawing.Point(138, 69)
        Me.chkAlphablend.Name = "chkAlphablend"
        Me.chkAlphablend.Size = New System.Drawing.Size(177, 20)
        Me.chkAlphablend.TabIndex = 32
        Me.chkAlphablend.Text = "alphablending: (0..255)"
        Me.chkAlphablend.UseVisualStyleBackColor = True
        '
        'txtTransparentColor
        '
        Me.txtTransparentColor.Location = New System.Drawing.Point(504, 82)
        Me.txtTransparentColor.Name = "txtTransparentColor"
        Me.txtTransparentColor.Size = New System.Drawing.Size(74, 23)
        Me.txtTransparentColor.TabIndex = 33
        '
        'chkTransparentColor
        '
        Me.chkTransparentColor.AutoSize = True
        Me.chkTransparentColor.Location = New System.Drawing.Point(329, 84)
        Me.chkTransparentColor.Name = "chkTransparentColor"
        Me.chkTransparentColor.Size = New System.Drawing.Size(176, 20)
        Me.chkTransparentColor.TabIndex = 34
        Me.chkTransparentColor.Text = "transparent RGB color:"
        Me.chkTransparentColor.UseVisualStyleBackColor = True
        '
        'grbMainVideoWindow
        '
        Me.grbMainVideoWindow.BackColor = System.Drawing.SystemColors.Control
        Me.grbMainVideoWindow.Controls.Add(Me.chkTransparentColor)
        Me.grbMainVideoWindow.Controls.Add(Me.txtTransparentColor)
        Me.grbMainVideoWindow.Controls.Add(Me.chkAlphablend)
        Me.grbMainVideoWindow.Controls.Add(Me.tbrAlphablend)
        Me.grbMainVideoWindow.Controls.Add(Me.lblMonitorNumber)
        Me.grbMainVideoWindow.Controls.Add(Me.txtDisplayMonitor)
        Me.grbMainVideoWindow.Controls.Add(Me.btnTestPanScan)
        Me.grbMainVideoWindow.Controls.Add(Me.btnTestPanScanHelp)
        Me.grbMainVideoWindow.Controls.Add(Me.Label1)
        Me.grbMainVideoWindow.Controls.Add(Me.chkFullScreen)
        Me.grbMainVideoWindow.Controls.Add(Me.chkUseVideoPort)
        Me.grbMainVideoWindow.Controls.Add(Me.tbrPanScan)
        Me.grbMainVideoWindow.Controls.Add(Me.chkVisible)
        Me.grbMainVideoWindow.Controls.Add(Me.rdgAspectRatio)
        Me.grbMainVideoWindow.Controls.Add(Me.chkEmbedded)
        Me.grbMainVideoWindow.Controls.Add(Me.chkMouseMovesWindow)
        Me.grbMainVideoWindow.Controls.Add(Me.chkStayOnTop)
        Me.grbMainVideoWindow.Controls.Add(Me.chkAutoSize)
        Me.grbMainVideoWindow.Controls.Add(Me.btnNewLocation)
        Me.grbMainVideoWindow.Controls.Add(Me.btnNewLocation2)
        Me.grbMainVideoWindow.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbMainVideoWindow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbMainVideoWindow.Location = New System.Drawing.Point(551, 52)
        Me.grbMainVideoWindow.Name = "grbMainVideoWindow"
        Me.grbMainVideoWindow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbMainVideoWindow.Size = New System.Drawing.Size(587, 194)
        Me.grbMainVideoWindow.TabIndex = 57
        Me.grbMainVideoWindow.TabStop = False
        Me.grbMainVideoWindow.Text = "display settings:"
        '
        'chkDisplayActive
        '
        Me.chkDisplayActive.AutoSize = True
        Me.chkDisplayActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDisplayActive.Location = New System.Drawing.Point(374, 91)
        Me.chkDisplayActive.Name = "chkDisplayActive"
        Me.chkDisplayActive.Size = New System.Drawing.Size(173, 21)
        Me.chkDisplayActive.TabIndex = 58
        Me.chkDisplayActive.Text = "DISPLAY ACTIVE ->"
        Me.chkDisplayActive.UseVisualStyleBackColor = True
        '
        'rdgSelectDisplay0
        '
        Me.rdgSelectDisplay0.AutoSize = True
        Me.rdgSelectDisplay0.Checked = True
        Me.rdgSelectDisplay0.Location = New System.Drawing.Point(32, 20)
        Me.rdgSelectDisplay0.Name = "rdgSelectDisplay0"
        Me.rdgSelectDisplay0.Size = New System.Drawing.Size(37, 20)
        Me.rdgSelectDisplay0.TabIndex = 0
        Me.rdgSelectDisplay0.TabStop = True
        Me.rdgSelectDisplay0.Tag = "0"
        Me.rdgSelectDisplay0.Text = "0"
        Me.rdgSelectDisplay0.UseVisualStyleBackColor = True
        '
        'rdgSelectDisplay1
        '
        Me.rdgSelectDisplay1.AutoSize = True
        Me.rdgSelectDisplay1.Location = New System.Drawing.Point(96, 20)
        Me.rdgSelectDisplay1.Name = "rdgSelectDisplay1"
        Me.rdgSelectDisplay1.Size = New System.Drawing.Size(37, 20)
        Me.rdgSelectDisplay1.TabIndex = 1
        Me.rdgSelectDisplay1.Tag = "1"
        Me.rdgSelectDisplay1.Text = "1"
        Me.rdgSelectDisplay1.UseVisualStyleBackColor = True
        '
        'rdgSelectDisplay2
        '
        Me.rdgSelectDisplay2.AutoSize = True
        Me.rdgSelectDisplay2.Location = New System.Drawing.Point(156, 20)
        Me.rdgSelectDisplay2.Name = "rdgSelectDisplay2"
        Me.rdgSelectDisplay2.Size = New System.Drawing.Size(37, 20)
        Me.rdgSelectDisplay2.TabIndex = 2
        Me.rdgSelectDisplay2.Tag = "2"
        Me.rdgSelectDisplay2.Text = "2"
        Me.rdgSelectDisplay2.UseVisualStyleBackColor = True
        '
        'rdgSelectDisplay3
        '
        Me.rdgSelectDisplay3.AutoSize = True
        Me.rdgSelectDisplay3.Location = New System.Drawing.Point(216, 20)
        Me.rdgSelectDisplay3.Name = "rdgSelectDisplay3"
        Me.rdgSelectDisplay3.Size = New System.Drawing.Size(37, 20)
        Me.rdgSelectDisplay3.TabIndex = 3
        Me.rdgSelectDisplay3.Tag = "3"
        Me.rdgSelectDisplay3.Text = "3"
        Me.rdgSelectDisplay3.UseVisualStyleBackColor = True
        '
        'rdgSelectDisplay4
        '
        Me.rdgSelectDisplay4.AutoSize = True
        Me.rdgSelectDisplay4.Location = New System.Drawing.Point(276, 20)
        Me.rdgSelectDisplay4.Name = "rdgSelectDisplay4"
        Me.rdgSelectDisplay4.Size = New System.Drawing.Size(37, 20)
        Me.rdgSelectDisplay4.TabIndex = 4
        Me.rdgSelectDisplay4.Tag = "4"
        Me.rdgSelectDisplay4.Text = "4"
        Me.rdgSelectDisplay4.UseVisualStyleBackColor = True
        '
        'rdgSelectDisplay5
        '
        Me.rdgSelectDisplay5.AutoSize = True
        Me.rdgSelectDisplay5.Location = New System.Drawing.Point(336, 20)
        Me.rdgSelectDisplay5.Name = "rdgSelectDisplay5"
        Me.rdgSelectDisplay5.Size = New System.Drawing.Size(37, 20)
        Me.rdgSelectDisplay5.TabIndex = 5
        Me.rdgSelectDisplay5.Tag = "5"
        Me.rdgSelectDisplay5.Text = "5"
        Me.rdgSelectDisplay5.UseVisualStyleBackColor = True
        '
        'rdgSelectDisplay6
        '
        Me.rdgSelectDisplay6.AutoSize = True
        Me.rdgSelectDisplay6.Location = New System.Drawing.Point(396, 20)
        Me.rdgSelectDisplay6.Name = "rdgSelectDisplay6"
        Me.rdgSelectDisplay6.Size = New System.Drawing.Size(37, 20)
        Me.rdgSelectDisplay6.TabIndex = 6
        Me.rdgSelectDisplay6.Tag = "6"
        Me.rdgSelectDisplay6.Text = "6"
        Me.rdgSelectDisplay6.UseVisualStyleBackColor = True
        '
        'rdgSelectDisplay7
        '
        Me.rdgSelectDisplay7.AutoSize = True
        Me.rdgSelectDisplay7.Location = New System.Drawing.Point(456, 20)
        Me.rdgSelectDisplay7.Name = "rdgSelectDisplay7"
        Me.rdgSelectDisplay7.Size = New System.Drawing.Size(37, 20)
        Me.rdgSelectDisplay7.TabIndex = 7
        Me.rdgSelectDisplay7.Tag = "7"
        Me.rdgSelectDisplay7.Text = "7"
        Me.rdgSelectDisplay7.UseVisualStyleBackColor = True
        '
        'rdgSelectDisplay8
        '
        Me.rdgSelectDisplay8.AutoSize = True
        Me.rdgSelectDisplay8.Location = New System.Drawing.Point(516, 20)
        Me.rdgSelectDisplay8.Name = "rdgSelectDisplay8"
        Me.rdgSelectDisplay8.Size = New System.Drawing.Size(37, 20)
        Me.rdgSelectDisplay8.TabIndex = 8
        Me.rdgSelectDisplay8.Tag = "8"
        Me.rdgSelectDisplay8.Text = "8"
        Me.rdgSelectDisplay8.UseVisualStyleBackColor = True
        '
        'rdgSelectDisplay9
        '
        Me.rdgSelectDisplay9.AutoSize = True
        Me.rdgSelectDisplay9.Location = New System.Drawing.Point(576, 20)
        Me.rdgSelectDisplay9.Name = "rdgSelectDisplay9"
        Me.rdgSelectDisplay9.Size = New System.Drawing.Size(37, 20)
        Me.rdgSelectDisplay9.TabIndex = 9
        Me.rdgSelectDisplay9.Tag = "9"
        Me.rdgSelectDisplay9.Text = "9"
        Me.rdgSelectDisplay9.UseVisualStyleBackColor = True
        '
        'rdgDisplaySelected
        '
        Me.rdgDisplaySelected.Controls.Add(Me.rdgSelectDisplay9)
        Me.rdgDisplaySelected.Controls.Add(Me.rdgSelectDisplay8)
        Me.rdgDisplaySelected.Controls.Add(Me.rdgSelectDisplay7)
        Me.rdgDisplaySelected.Controls.Add(Me.rdgSelectDisplay6)
        Me.rdgDisplaySelected.Controls.Add(Me.rdgSelectDisplay5)
        Me.rdgDisplaySelected.Controls.Add(Me.rdgSelectDisplay4)
        Me.rdgDisplaySelected.Controls.Add(Me.rdgSelectDisplay3)
        Me.rdgDisplaySelected.Controls.Add(Me.rdgSelectDisplay2)
        Me.rdgDisplaySelected.Controls.Add(Me.rdgSelectDisplay1)
        Me.rdgDisplaySelected.Controls.Add(Me.rdgSelectDisplay0)
        Me.rdgDisplaySelected.Location = New System.Drawing.Point(520, 7)
        Me.rdgDisplaySelected.Name = "rdgDisplaySelected"
        Me.rdgDisplaySelected.Size = New System.Drawing.Size(619, 47)
        Me.rdgDisplaySelected.TabIndex = 59
        Me.rdgDisplaySelected.TabStop = False
        Me.rdgDisplaySelected.Text = "display # selected:"
        '
        'chkBlackMagicOutput
        '
        Me.chkBlackMagicOutput.Location = New System.Drawing.Point(232, 7)
        Me.chkBlackMagicOutput.Name = "chkBlackMagicOutput"
        Me.chkBlackMagicOutput.Size = New System.Drawing.Size(192, 21)
        Me.chkBlackMagicOutput.TabIndex = 42
        Me.chkBlackMagicOutput.Text = "BlackMagic Decklink output"
        '
        'chkAdjustPixelAspectRatio
        '
        Me.chkAdjustPixelAspectRatio.BackColor = System.Drawing.SystemColors.Control
        Me.chkAdjustPixelAspectRatio.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAdjustPixelAspectRatio.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAdjustPixelAspectRatio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAdjustPixelAspectRatio.Location = New System.Drawing.Point(232, 47)
        Me.chkAdjustPixelAspectRatio.Name = "chkAdjustPixelAspectRatio"
        Me.chkAdjustPixelAspectRatio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAdjustPixelAspectRatio.Size = New System.Drawing.Size(181, 21)
        Me.chkAdjustPixelAspectRatio.TabIndex = 41
        Me.chkAdjustPixelAspectRatio.Text = "adjust pixel aspect ratio"
        Me.chkAdjustPixelAspectRatio.UseVisualStyleBackColor = False
        '
        'chkVideoVisibleWhenStopped
        '
        Me.chkVideoVisibleWhenStopped.Location = New System.Drawing.Point(232, 27)
        Me.chkVideoVisibleWhenStopped.Name = "chkVideoVisibleWhenStopped"
        Me.chkVideoVisibleWhenStopped.Size = New System.Drawing.Size(192, 21)
        Me.chkVideoVisibleWhenStopped.TabIndex = 40
        Me.chkVideoVisibleWhenStopped.Text = "video visible when stopped"
        '
        'rdgVideoRendererRecPriority
        '
        Me.rdgVideoRendererRecPriority.AutoSize = True
        Me.rdgVideoRendererRecPriority.Location = New System.Drawing.Point(10, 164)
        Me.rdgVideoRendererRecPriority.Name = "rdgVideoRendererRecPriority"
        Me.rdgVideoRendererRecPriority.Size = New System.Drawing.Size(136, 20)
        Me.rdgVideoRendererRecPriority.TabIndex = 44
        Me.rdgVideoRendererRecPriority.Tag = "6"
        Me.rdgVideoRendererRecPriority.Text = "recording priority"
        '
        'rdgVideoRendererVMR9
        '
        Me.rdgVideoRendererVMR9.BackColor = System.Drawing.SystemColors.Control
        Me.rdgVideoRendererVMR9.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgVideoRendererVMR9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgVideoRendererVMR9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgVideoRendererVMR9.Location = New System.Drawing.Point(10, 70)
        Me.rdgVideoRendererVMR9.Name = "rdgVideoRendererVMR9"
        Me.rdgVideoRendererVMR9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgVideoRendererVMR9.Size = New System.Drawing.Size(78, 21)
        Me.rdgVideoRendererVMR9.TabIndex = 38
        Me.rdgVideoRendererVMR9.TabStop = True
        Me.rdgVideoRendererVMR9.Tag = "2"
        Me.rdgVideoRendererVMR9.Text = "VMR9"
        Me.rdgVideoRendererVMR9.UseVisualStyleBackColor = False
        '
        'rdgVideoRendererVMR7
        '
        Me.rdgVideoRendererVMR7.BackColor = System.Drawing.SystemColors.Control
        Me.rdgVideoRendererVMR7.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgVideoRendererVMR7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgVideoRendererVMR7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgVideoRendererVMR7.Location = New System.Drawing.Point(10, 94)
        Me.rdgVideoRendererVMR7.Name = "rdgVideoRendererVMR7"
        Me.rdgVideoRendererVMR7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgVideoRendererVMR7.Size = New System.Drawing.Size(78, 20)
        Me.rdgVideoRendererVMR7.TabIndex = 39
        Me.rdgVideoRendererVMR7.TabStop = True
        Me.rdgVideoRendererVMR7.Tag = "3"
        Me.rdgVideoRendererVMR7.Text = "VMR7"
        Me.rdgVideoRendererVMR7.UseVisualStyleBackColor = False
        '
        'rdgVideoRendererAutoSelect
        '
        Me.rdgVideoRendererAutoSelect.BackColor = System.Drawing.SystemColors.Control
        Me.rdgVideoRendererAutoSelect.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgVideoRendererAutoSelect.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgVideoRendererAutoSelect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgVideoRendererAutoSelect.Location = New System.Drawing.Point(10, 23)
        Me.rdgVideoRendererAutoSelect.Name = "rdgVideoRendererAutoSelect"
        Me.rdgVideoRendererAutoSelect.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgVideoRendererAutoSelect.Size = New System.Drawing.Size(96, 21)
        Me.rdgVideoRendererAutoSelect.TabIndex = 40
        Me.rdgVideoRendererAutoSelect.TabStop = True
        Me.rdgVideoRendererAutoSelect.Tag = "0"
        Me.rdgVideoRendererAutoSelect.Text = "auto select"
        Me.rdgVideoRendererAutoSelect.UseVisualStyleBackColor = False
        '
        'rdgVideoRendererStandard
        '
        Me.rdgVideoRendererStandard.BackColor = System.Drawing.SystemColors.Control
        Me.rdgVideoRendererStandard.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgVideoRendererStandard.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgVideoRendererStandard.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgVideoRendererStandard.Location = New System.Drawing.Point(10, 117)
        Me.rdgVideoRendererStandard.Name = "rdgVideoRendererStandard"
        Me.rdgVideoRendererStandard.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgVideoRendererStandard.Size = New System.Drawing.Size(87, 21)
        Me.rdgVideoRendererStandard.TabIndex = 41
        Me.rdgVideoRendererStandard.TabStop = True
        Me.rdgVideoRendererStandard.Tag = "4"
        Me.rdgVideoRendererStandard.Text = "standard"
        Me.rdgVideoRendererStandard.UseVisualStyleBackColor = False
        '
        'rdgVideoRendererOverlay
        '
        Me.rdgVideoRendererOverlay.BackColor = System.Drawing.SystemColors.Control
        Me.rdgVideoRendererOverlay.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgVideoRendererOverlay.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgVideoRendererOverlay.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgVideoRendererOverlay.Location = New System.Drawing.Point(10, 140)
        Me.rdgVideoRendererOverlay.Name = "rdgVideoRendererOverlay"
        Me.rdgVideoRendererOverlay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgVideoRendererOverlay.Size = New System.Drawing.Size(76, 21)
        Me.rdgVideoRendererOverlay.TabIndex = 42
        Me.rdgVideoRendererOverlay.TabStop = True
        Me.rdgVideoRendererOverlay.Tag = "5"
        Me.rdgVideoRendererOverlay.Text = "overlay"
        Me.rdgVideoRendererOverlay.UseVisualStyleBackColor = False
        '
        'rdgVideoRendererNone
        '
        Me.rdgVideoRendererNone.Location = New System.Drawing.Point(107, 22)
        Me.rdgVideoRendererNone.Name = "rdgVideoRendererNone"
        Me.rdgVideoRendererNone.Size = New System.Drawing.Size(96, 21)
        Me.rdgVideoRendererNone.TabIndex = 43
        Me.rdgVideoRendererNone.Tag = "7"
        Me.rdgVideoRendererNone.Text = "none"
        '
        'rdgVideoRendererEVR
        '
        Me.rdgVideoRendererEVR.BackColor = System.Drawing.SystemColors.Control
        Me.rdgVideoRendererEVR.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgVideoRendererEVR.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgVideoRendererEVR.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgVideoRendererEVR.Location = New System.Drawing.Point(10, 47)
        Me.rdgVideoRendererEVR.Name = "rdgVideoRendererEVR"
        Me.rdgVideoRendererEVR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgVideoRendererEVR.Size = New System.Drawing.Size(78, 21)
        Me.rdgVideoRendererEVR.TabIndex = 46
        Me.rdgVideoRendererEVR.TabStop = True
        Me.rdgVideoRendererEVR.Tag = "1"
        Me.rdgVideoRendererEVR.Text = "EVR"
        Me.rdgVideoRendererEVR.UseVisualStyleBackColor = False
        '
        'rdgVideoRenderer
        '
        Me.rdgVideoRenderer.BackColor = System.Drawing.SystemColors.Control
        Me.rdgVideoRenderer.Controls.Add(Me.rdgVideoRendererMadVR)
        Me.rdgVideoRenderer.Controls.Add(Me.rdgVideoRendererEVR)
        Me.rdgVideoRenderer.Controls.Add(Me.rdgVideoRendererNone)
        Me.rdgVideoRenderer.Controls.Add(Me.rdgVideoRendererOverlay)
        Me.rdgVideoRenderer.Controls.Add(Me.rdgVideoRendererStandard)
        Me.rdgVideoRenderer.Controls.Add(Me.rdgVideoRendererAutoSelect)
        Me.rdgVideoRenderer.Controls.Add(Me.rdgVideoRendererVMR7)
        Me.rdgVideoRenderer.Controls.Add(Me.rdgVideoRendererVMR9)
        Me.rdgVideoRenderer.Controls.Add(Me.rdgVideoRendererRecPriority)
        Me.rdgVideoRenderer.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgVideoRenderer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgVideoRenderer.Location = New System.Drawing.Point(5, 0)
        Me.rdgVideoRenderer.Name = "rdgVideoRenderer"
        Me.rdgVideoRenderer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgVideoRenderer.Size = New System.Drawing.Size(209, 220)
        Me.rdgVideoRenderer.TabIndex = 39
        Me.rdgVideoRenderer.TabStop = False
        Me.rdgVideoRenderer.Text = "video renderer"
        '
        'rdgVideoRendererMadVR
        '
        Me.rdgVideoRendererMadVR.AutoSize = True
        Me.rdgVideoRendererMadVR.Location = New System.Drawing.Point(107, 48)
        Me.rdgVideoRendererMadVR.Name = "rdgVideoRendererMadVR"
        Me.rdgVideoRendererMadVR.Size = New System.Drawing.Size(75, 20)
        Me.rdgVideoRendererMadVR.TabIndex = 47
        Me.rdgVideoRendererMadVR.TabStop = True
        Me.rdgVideoRendererMadVR.Text = "madVR"
        Me.rdgVideoRendererMadVR.UseVisualStyleBackColor = True
        '
        'chkTransparency
        '
        Me.chkTransparency.Location = New System.Drawing.Point(232, 106)
        Me.chkTransparency.Name = "chkTransparency"
        Me.chkTransparency.Size = New System.Drawing.Size(115, 21)
        Me.chkTransparency.TabIndex = 38
        Me.chkTransparency.Text = "transparency"
        '
        'imgLogo
        '
        Me.imgLogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgLogo.Image = CType(resources.GetObject("imgLogo.Image"), System.Drawing.Image)
        Me.imgLogo.Location = New System.Drawing.Point(232, 155)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(85, 62)
        Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgLogo.TabIndex = 37
        Me.imgLogo.TabStop = False
        '
        'chkChangeCursor
        '
        Me.chkChangeCursor.BackColor = System.Drawing.SystemColors.Control
        Me.chkChangeCursor.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkChangeCursor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkChangeCursor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkChangeCursor.Location = New System.Drawing.Point(232, 66)
        Me.chkChangeCursor.Name = "chkChangeCursor"
        Me.chkChangeCursor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkChangeCursor.Size = New System.Drawing.Size(192, 21)
        Me.chkChangeCursor.TabIndex = 6
        Me.chkChangeCursor.Text = "change cursor (e.g.: cross)"
        Me.chkChangeCursor.UseVisualStyleBackColor = False
        '
        'chkBorder
        '
        Me.chkBorder.BackColor = System.Drawing.SystemColors.Control
        Me.chkBorder.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkBorder.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBorder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkBorder.Location = New System.Drawing.Point(232, 86)
        Me.chkBorder.Name = "chkBorder"
        Me.chkBorder.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkBorder.Size = New System.Drawing.Size(115, 21)
        Me.chkBorder.TabIndex = 7
        Me.chkBorder.Text = "border"
        Me.chkBorder.UseVisualStyleBackColor = False
        '
        'chkSetLogo
        '
        Me.chkSetLogo.BackColor = System.Drawing.SystemColors.Control
        Me.chkSetLogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSetLogo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSetLogo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSetLogo.Location = New System.Drawing.Point(232, 134)
        Me.chkSetLogo.Name = "chkSetLogo"
        Me.chkSetLogo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSetLogo.Size = New System.Drawing.Size(162, 21)
        Me.chkSetLogo.TabIndex = 8
        Me.chkSetLogo.Text = "show logo, e.g.:"
        Me.chkSetLogo.UseVisualStyleBackColor = False
        '
        'Display
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.ClientSize = New System.Drawing.Size(1147, 254)
        Me.ControlBox = False
        Me.Controls.Add(Me.rdgDisplaySelected)
        Me.Controls.Add(Me.chkDisplayActive)
        Me.Controls.Add(Me.grbMainVideoWindow)
        Me.Controls.Add(Me.chkBlackMagicOutput)
        Me.Controls.Add(Me.chkAdjustPixelAspectRatio)
        Me.Controls.Add(Me.chkVideoVisibleWhenStopped)
        Me.Controls.Add(Me.rdgVideoRenderer)
        Me.Controls.Add(Me.chkTransparency)
        Me.Controls.Add(Me.chkSetLogo)
        Me.Controls.Add(Me.chkBorder)
        Me.Controls.Add(Me.chkChangeCursor)
        Me.Controls.Add(Me.imgLogo)
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Display"
        Me.ShowInTaskbar = False
        Me.rdgAspectRatio.ResumeLayout(False)
        Me.rdgAspectRatio.PerformLayout()
        CType(Me.tbrPanScan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrAlphablend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbMainVideoWindow.ResumeLayout(False)
        Me.grbMainVideoWindow.PerformLayout()
        Me.rdgDisplaySelected.ResumeLayout(False)
        Me.rdgDisplaySelected.PerformLayout()
        Me.rdgVideoRenderer.ResumeLayout(False)
        Me.rdgVideoRenderer.PerformLayout()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
    Dim RefreshingDisplayOptions As Boolean = False

    Private frmTransparentWindow As TransparentWindow


    Private boolPanScan As Boolean
    Private PanScanVGWidth As Long
    Private PanScanVGHeight As Long
    Private FDisplaySelected As Long = 0


    Private Sub Display_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmTransparentWindow = New TransparentWindow
    End Sub

    Public Sub RefreshControls()
        chkDisplayActive.Checked = MainForm.DefInstance.VideoGrabber1.GetDisplayActive(FDisplaySelected)
        chkVisible.Checked = MainForm.DefInstance.VideoGrabber1.GetDisplayVisible(FDisplaySelected)
        chkEmbedded.Checked = MainForm.DefInstance.VideoGrabber1.GetDisplayEmbedded(FDisplaySelected)
        chkFullScreen.Checked = MainForm.DefInstance.VideoGrabber1.GetDisplayFullScreen(FDisplaySelected)
        chkStayOnTop.Checked = MainForm.DefInstance.VideoGrabber1.GetDisplayStayOnTop(FDisplaySelected)
        chkUseVideoPort.Checked = MainForm.DefInstance.VideoGrabber1.GetDisplayVideoPortEnabled(FDisplaySelected)
        chkMouseMovesWindow.Checked = MainForm.DefInstance.VideoGrabber1.GetDisplayMouseMovesWindow(FDisplaySelected)
        chkAutoSize.Checked = MainForm.DefInstance.VideoGrabber1.GetDisplayAutoSize(FDisplaySelected)
        SetRadioButtonInGroupUsingTag(rdgAspectRatio, MainForm.DefInstance.VideoGrabber1.GetDisplayAspectRatio(FDisplaySelected))
        tbrPanScan.Value = MainForm.DefInstance.VideoGrabber1.GetDisplayPanScanRatio(FDisplaySelected)
        chkAlphablend.Checked = MainForm.DefInstance.VideoGrabber1.GetDisplayAlphaBlendEnabled(FDisplaySelected)
        tbrAlphablend.Value = MainForm.DefInstance.VideoGrabber1.GetDisplayAlphaBlendValue(FDisplaySelected)
        chkTransparentColor.Checked = MainForm.DefInstance.VideoGrabber1.GetDisplayTransparentColorEnabled(FDisplaySelected)
        txtTransparentColor.Text = MainForm.DefInstance.VideoGrabber1.GetDisplayTransparentColorValue(FDisplaySelected).ToString()
        txtDisplayMonitor.Text = MainForm.DefInstance.VideoGrabber1.GetDisplayMonitor(FDisplaySelected).ToString()

        SetRadioButtonInGroupUsingTag((rdgVideoRenderer), MainForm.DefInstance.VideoGrabber1.VideoRenderer)

        chkBorder.Checked = IIf(MainForm.DefInstance.VideoGrabber1.BorderStyle = VidGrab.TBorderStyle.bsSingle, System.Windows.Forms.CheckState.Checked, System.Windows.Forms.CheckState.Unchecked)
        chkAdjustPixelAspectRatio.Checked = MainForm.DefInstance.VideoGrabber1.AdjustPixelAspectRatio

        grbMainVideoWindow.Enabled = MainForm.DefInstance.VideoGrabber1.GetDisplayActive(FDisplaySelected)

        If MainForm.DefInstance.VideoGrabber1.GetDisplayActive(FDisplaySelected) Then
            chkStayOnTop.Enabled = (Not MainForm.DefInstance.VideoGrabber1.GetDisplayEmbedded(FDisplaySelected)) Or MainForm.DefInstance.VideoGrabber1.GetDisplayFullScreen(FDisplaySelected)
            lblMonitorNumber.Enabled = Not MainForm.DefInstance.VideoGrabber1.GetDisplayEmbedded(FDisplaySelected)
            txtDisplayMonitor.Enabled = Not MainForm.DefInstance.VideoGrabber1.GetDisplayEmbedded(FDisplaySelected)
            chkMouseMovesWindow.Enabled = Not MainForm.DefInstance.VideoGrabber1.GetDisplayEmbedded(FDisplaySelected)
            btnNewLocation.Enabled = Not MainForm.DefInstance.VideoGrabber1.GetDisplayEmbedded(FDisplaySelected)
            btnNewLocation2.Enabled = Not MainForm.DefInstance.VideoGrabber1.GetDisplayEmbedded(FDisplaySelected)
            chkUseVideoPort.Enabled = MainForm.DefInstance.VideoGrabber1.IsVideoPortAvailable
            chkAlphablend.Enabled = Not MainForm.DefInstance.VideoGrabber1.GetDisplayEmbedded(FDisplaySelected)
            chkTransparentColor.Enabled = Not MainForm.DefInstance.VideoGrabber1.GetDisplayEmbedded(FDisplaySelected)
        End If

    End Sub

    Private Sub rdgVideoRenderer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgVideoRendererAutoSelect.CheckedChanged
        If CType(sender, RadioButton).Checked Then
            MainForm.DefInstance.VideoGrabber1.VideoRenderer = sender.tag
        End If
    End Sub

    Private Sub btnNewLocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewLocation.Click
        MainForm.DefInstance.VideoGrabber1.SetDisplayAutoSize(FDisplaySelected, True) ' the component"s video size will be used
        MainForm.DefInstance.VideoGrabber1.SetDisplayEmbedded(FDisplaySelected, False) ' detach from component
        MainForm.DefInstance.VideoGrabber1.SetDisplayLocation(FDisplaySelected, 10, 10, 320, 240) ' 320 and 240 are not used because of AutoSize above
        RefreshControls()
    End Sub

    Private Sub btnNewLocation2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewLocation2.Click
        MainForm.DefInstance.VideoGrabber1.SetDisplayAutoSize(FDisplaySelected, False) ' we will specify the size below
        MainForm.DefInstance.VideoGrabber1.SetDisplayEmbedded(FDisplaySelected, False) ' detach from component
        MainForm.DefInstance.VideoGrabber1.SetDisplayLocation(FDisplaySelected, 20, 20, 480, 200) ' new size: 480 x 360
        RefreshControls()
    End Sub

    Private Sub Display_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Visible Then
            RefreshControls()
        End If

    End Sub

    Private Sub rdgSelectDisplay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgSelectDisplay0.CheckedChanged
        If CType(sender, RadioButton).Checked Then
            FDisplaySelected = Convert.ToInt32(sender.tag())
            RefreshControls()
        End If
    End Sub

    Private Sub chkAutoSize_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAutoSize.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.SetDisplayAutoSize(FDisplaySelected, chkAutoSize.Checked)
        RefreshControls()


        ' disabling Display_AutoSize alone will not restore previously set video Width 
        '  and Height...for demonstration purposes, Width and Height are here restored
        '  to initial IDE MainForm_Load values if Display_AutoSize has been disabled:
        If Not MainForm.DefInstance.VideoGrabber1.GetDisplayAutoSize(FDisplaySelected) Then
            If MainForm.DefInstance.VideoGrabber1.GetDisplayEmbedded(FDisplaySelected) Then
                MainForm.DefInstance.VideoGrabber1.Width = MainForm.DefInstance.StartupVGWidth
                MainForm.DefInstance.VideoGrabber1.Height = MainForm.DefInstance.StartupVGHeight
            Else
                MainForm.DefInstance.VideoGrabber1.SetDisplayWidth(FDisplaySelected, MainForm.DefInstance.StartupVGWidth)
                MainForm.DefInstance.VideoGrabber1.SetDisplayHeight(FDisplaySelected, MainForm.DefInstance.StartupVGHeight)
            End If
        End If

    End Sub

    Private Sub chkVisible_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVisible.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.SetDisplayVisible(FDisplaySelected, chkVisible.Checked)
    End Sub

    Private Sub chkEmbedded_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEmbedded.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.SetDisplayEmbedded(FDisplaySelected, chkEmbedded.Checked)
        RefreshControls()
    End Sub

    Private Sub chkFullScreen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFullScreen.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.SetDisplayFullScreen(FDisplaySelected, chkFullScreen.Checked)
        RefreshControls()
    End Sub

    Private Sub chkMouseMovesWindow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMouseMovesWindow.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.SetDisplayMouseMovesWindow(FDisplaySelected, chkMouseMovesWindow.Checked)
        RefreshControls()
    End Sub

    Private Sub chkStayOnTop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStayOnTop.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.SetDisplayStayOnTop(FDisplaySelected, chkStayOnTop.Checked)
        RefreshControls()
    End Sub

    Private Sub chkUseVideoPort_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUseVideoPort.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.SetDisplayVideoPortEnabled(FDisplaySelected, chkUseVideoPort.Checked)
        RefreshControls()
    End Sub

    Private Sub rdgDisplayAspectRatio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgDisplayAspectRatioBox.CheckedChanged
        If CType(sender, RadioButton).Checked Then
            MainForm.DefInstance.VideoGrabber1.SetDisplayAspectRatio(FDisplaySelected, sender.tag)
        End If
    End Sub

    Private Sub chkBlackMagicOutput_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBlackMagicOutput.CheckedChanged
        If chkBlackMagicOutput.Checked Then
            MainForm.DefInstance.VideoGrabber1.VideoRendererExternal = VidGrab.TVideoRendererExternal.vre_BlackMagic_Decklink
        Else
            MainForm.DefInstance.VideoGrabber1.VideoRendererExternal = VidGrab.TVideoRendererExternal.vre_None
        End If
    End Sub

    Private Sub chkVideoVisibleWhenStopped_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVideoVisibleWhenStopped.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.VideoVisibleWhenStopped = chkVideoVisibleWhenStopped.Checked
    End Sub

    Private Sub chkAdjustPixelAspectRatio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAdjustPixelAspectRatio.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.AdjustPixelAspectRatio = chkAdjustPixelAspectRatio.Checked
    End Sub

    Private Sub chkBorder_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBorder.CheckedChanged
#If Not VS2003 Then
        If chkBorder.Checked Then
            MainForm.DefInstance.VideoGrabber1.BorderStyle = VidGrab.TBorderStyle.bsSingle
        Else
            MainForm.DefInstance.VideoGrabber1.BorderStyle = VidGrab.TBorderStyle.bsNone
        End If
#End If
    End Sub

    Private Sub chkChangeCursor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkChangeCursor.CheckedChanged
        Select Case chkChangeCursor.Checked
            Case True
                MainForm.DefInstance.VideoGrabber1.VideoCursor = VidGrab.TCursors.cr_cross
            Case False
                MainForm.DefInstance.VideoGrabber1.VideoCursor = VidGrab.TCursors.cr_Default
        End Select
    End Sub

    Private Sub rdgDisplayedOnMonitor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CType(sender, RadioButton).Checked Then
            MainForm.DefInstance.VideoGrabber1.SetDisplayMonitor(FDisplaySelected, sender.tag)
            RefreshControls()
        End If
    End Sub

    Private Sub chkDisplayActive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDisplayActive.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.SetDisplayActive(FDisplaySelected, chkDisplayActive.Checked)
        RefreshControls()
    End Sub

    Private Sub chkSetLogo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSetLogo.CheckedChanged
        Select Case chkSetLogo.Checked
            Case True
                Dim TempBmp As Bitmap = CreateBitmapHandleFromPictureBox(imgLogo)
                MainForm.DefInstance.VideoGrabber1.SetLogoFromHBitmap(TempBmp.GetHbitmap)
                MainForm.DefInstance.VideoGrabber1.LogoLayout = VidGrab.TLogoLayout.lg_Stretched
                MainForm.DefInstance.VideoGrabber1.LogoDisplayed = True
            Case False
                MainForm.DefInstance.VideoGrabber1.LogoDisplayed = False
        End Select
    End Sub

    Private Sub chkTransparency_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTransparency.CheckedChanged
        frmTransparentWindow.TransparencyKey = Color.FromArgb(MainForm.DefInstance.VideoGrabber1.ColorKey)
        frmTransparentWindow.BackColor = ColorTranslator.FromWin32 (frmTransparentWindow.TransparencyKey.ToArgb())
        frmTransparentWindow.TransparentLabel.ForeColor = Color.Red
        frmTransparentWindow.Show()
    End Sub


    Private Sub tbrPanScan_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrPanScan.Scroll
        MainForm.DefInstance.VideoGrabber1.SetDisplayPanScanRatio(FDisplaySelected, tbrPanScan.Value)
    End Sub

    Private Sub tbrAlphaBlend_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrAlphablend.Scroll
        MainForm.DefInstance.VideoGrabber1.SetDisplayAlphaBlendValue(FDisplaySelected, tbrAlphablend.Value)
    End Sub

    Private Sub btnTestPanScan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestPanScan.Click


        chkEmbedded.Checked = True
        MainForm.DefInstance.VideoGrabber1.SetDisplayEmbedded(FDisplaySelected, True)
        chkAdjustPixelAspectRatio.Checked = False
        MainForm.DefInstance.VideoGrabber1.AdjustPixelAspectRatio = False
        chkAutoSize.Checked = False
        MainForm.DefInstance.VideoGrabber1.SetDisplayAutoSize(FDisplaySelected, False)

        ' disabling Display_AutoSize alone will not restore previously set video Width 
        '  and Height...for demonstration purposes, Width and Height are here restored
        '  to initial IDE MainForm_Load values if Display_AutoSize is enabled
        If Not MainForm.DefInstance.VideoGrabber1.GetDisplayAutoSize(FDisplaySelected) Then
            If MainForm.DefInstance.VideoGrabber1.GetDisplayEmbedded(FDisplaySelected) Then
                MainForm.DefInstance.VideoGrabber1.Width = MainForm.DefInstance.StartupVGWidth
                MainForm.DefInstance.VideoGrabber1.Height = MainForm.DefInstance.StartupVGHeight
            Else
                MainForm.DefInstance.VideoGrabber1.SetDisplayWidth(FDisplaySelected, MainForm.DefInstance.StartupVGWidth)
                MainForm.DefInstance.VideoGrabber1.SetDisplayHeight(FDisplaySelected, MainForm.DefInstance.StartupVGHeight)
            End If
        End If

        ' for pan / scan demonstration, change video Width and Height to a
        '  16 x 9 aspect ratio, or restore to pre-demonstration Width and Height
        If boolPanScan Then
            MainForm.DefInstance.VideoGrabber1.Width = PanScanVGWidth
            MainForm.DefInstance.VideoGrabber1.Height = PanScanVGHeight
        Else
            PanScanVGWidth = MainForm.DefInstance.VideoGrabber1.Width
            PanScanVGHeight = MainForm.DefInstance.VideoGrabber1.Height
            MainForm.DefInstance.VideoGrabber1.Width = MainForm.DefInstance.VideoGrabber1.Height * (16 / 9)
        End If
        boolPanScan = Not boolPanScan

        ' setting Display_AspectRatio to ar_PanScan (pan and scan)
        rdgDisplayAspectRatioPanScan.Checked = True
        MainForm.DefInstance.VideoGrabber1.SetDisplayAspectRatio(FDisplaySelected, VidGrab.TAspectRatio.ar_PanScan)


    End Sub

    Private Sub btnTestPanScanHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestPanScanHelp.Click

        MessageBox.Show("Test Display_AspectRatio settings with Display_AutoSize disabled:" & vbCrLf & vbCrLf & _
                "With Display_AutoSize = False and AdjustPixelAspectRatio= False, the Display_AspectRatio setting" & vbCrLf & _
                "  determines how the video is displayed within the control Width and Height properties:" & vbCrLf & _
                "  ar_Box: video appears in full with correct aspect ratio (e.g. letterbox)" & vbCrLf & _
                "  ar_NoResize: video appears in ""native"" size with correct aspect ratio" & vbCrLf & _
                "  ar_Stretch: video is stretched to fill the control, regardless of correct aspect ratio" & vbCrLf & _
                "  ar_PanScan: Display_PanScanRatio (0-100) determines setting between ""letterbox"" and ""pan-scan""" & vbCrLf & vbCrLf & _
                "(see Help: ""User guide.Display - Dual display.Video window"")", _
                "DataStead TVideoGrabber VB.NET OCX Demo", MessageBoxButtons.OK)

    End Sub


End Class
