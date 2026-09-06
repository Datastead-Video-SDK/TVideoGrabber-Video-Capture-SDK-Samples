Option Strict Off
Option Explicit On
Friend Class IPCamera
    Inherits Form


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

    Private WithEvents groupBox4 As GroupBox
    Private WithEvents tabControl1 As TabControl
    Private WithEvents tabPage1 As TabPage
    Private WithEvents label15 As Label
    Private WithEvents chkStopOnRelease As CheckBox
    Private WithEvents btnContinousPTZStop As Button
    Private WithEvents button1 As Button
    Private WithEvents edtPTZDurationMs As TextBox
    Private WithEvents label10 As Label
    Private WithEvents btnContinousPtzZoomOut As Button
    Private WithEvents btnContinousPtzZoomIn As Button
    Private WithEvents btnContinousPtzPanLeft As Button
    Private WithEvents btnContinousPtzPanRight As Button
    Private WithEvents btnContinousPtzTiltDown As Button
    Private WithEvents label7 As Label
    Private WithEvents label8 As Label
    Private WithEvents btnContinousPtzTiltUp As Button
    Private WithEvents tabPage2 As TabPage
    Private WithEvents btnPTZActualiseTrackbars As Button
    Friend WithEvents tbrAbsolutePTZTilt As TrackBar
    Private WithEvents label13 As Label
    Private WithEvents label12 As Label
    Friend WithEvents tbrAbsolutePTZZoom As TrackBar
    Private WithEvents label11 As Label
    Friend WithEvents tbrAbsolutePTZPan As TrackBar
    Private WithEvents tabPage3 As TabPage
    Private WithEvents txtPTZRelativeMove As TextBox
    Private WithEvents label18 As Label
    Private WithEvents btnRelativeZoomOut As Button
    Private WithEvents btnRelativeZoomIn As Button
    Private WithEvents btnRelativePanLeft As Button
    Private WithEvents btnRelativePanRight As Button
    Private WithEvents btnRelativeTiltDown As Button
    Private WithEvents label16 As Label
    Private WithEvents label17 As Label
    Private WithEvents btnRelativeTiltUp As Button
    Private WithEvents button2 As Button
    Friend WithEvents tbrPTZSpeedRatio As TrackBar
    Private WithEvents label14 As Label
    Private WithEvents chkUseExternalAudioforRTSP As CheckBox
    Private WithEvents txtBacktimedRecordingSeconds As TextBox
    Friend WithEvents label2 As Label
    Public WithEvents edtIPCamPassword As TextBox
    Friend WithEvents label1 As Label
    Public WithEvents edtIPCamUserName As TextBox
    Private WithEvents chkBacktimedRecording As CheckBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Private WithEvents label6 As Label
    Friend WithEvents btnIPCamStartMP4Recording As Button
    Friend WithEvents btnIPCamStop As Button
    Private WithEvents chkOpenURLAsync As CheckBox
    Friend WithEvents edtIPCamReceiveTimeout As TextBox
    Friend WithEvents edtIPCamConnectionTimeout As TextBox
    Friend WithEvents edtIPCameraURL As TextBox
    Friend WithEvents label5 As Label
    Friend WithEvents label4 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents btnIPCamStartPreview As Button
    Friend WithEvents lblFirstSelectIPCamera As Label
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents rdbIrCutFilterDisabled As System.Windows.Forms.RadioButton
    Private WithEvents rdbIrCutFilterEnabled As System.Windows.Forms.RadioButton
    Private WithEvents rdbIrCutFilterAuto As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As Label

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IPCamera))
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.button2 = New System.Windows.Forms.Button()
        Me.btnContinousPTZStop = New System.Windows.Forms.Button()
        Me.label14 = New System.Windows.Forms.Label()
        Me.tbrPTZSpeedRatio = New System.Windows.Forms.TrackBar()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.label15 = New System.Windows.Forms.Label()
        Me.chkStopOnRelease = New System.Windows.Forms.CheckBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.edtPTZDurationMs = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.btnContinousPtzZoomOut = New System.Windows.Forms.Button()
        Me.btnContinousPtzZoomIn = New System.Windows.Forms.Button()
        Me.btnContinousPtzPanLeft = New System.Windows.Forms.Button()
        Me.btnContinousPtzPanRight = New System.Windows.Forms.Button()
        Me.btnContinousPtzTiltDown = New System.Windows.Forms.Button()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.btnContinousPtzTiltUp = New System.Windows.Forms.Button()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.btnPTZActualiseTrackbars = New System.Windows.Forms.Button()
        Me.tbrAbsolutePTZTilt = New System.Windows.Forms.TrackBar()
        Me.label13 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.tbrAbsolutePTZZoom = New System.Windows.Forms.TrackBar()
        Me.label11 = New System.Windows.Forms.Label()
        Me.tbrAbsolutePTZPan = New System.Windows.Forms.TrackBar()
        Me.tabPage3 = New System.Windows.Forms.TabPage()
        Me.txtPTZRelativeMove = New System.Windows.Forms.TextBox()
        Me.label18 = New System.Windows.Forms.Label()
        Me.btnRelativeZoomOut = New System.Windows.Forms.Button()
        Me.btnRelativeZoomIn = New System.Windows.Forms.Button()
        Me.btnRelativePanLeft = New System.Windows.Forms.Button()
        Me.btnRelativePanRight = New System.Windows.Forms.Button()
        Me.btnRelativeTiltDown = New System.Windows.Forms.Button()
        Me.label16 = New System.Windows.Forms.Label()
        Me.label17 = New System.Windows.Forms.Label()
        Me.btnRelativeTiltUp = New System.Windows.Forms.Button()
        Me.chkUseExternalAudioforRTSP = New System.Windows.Forms.CheckBox()
        Me.txtBacktimedRecordingSeconds = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.edtIPCamPassword = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.edtIPCamUserName = New System.Windows.Forms.TextBox()
        Me.chkBacktimedRecording = New System.Windows.Forms.CheckBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.btnIPCamStartMP4Recording = New System.Windows.Forms.Button()
        Me.btnIPCamStop = New System.Windows.Forms.Button()
        Me.chkOpenURLAsync = New System.Windows.Forms.CheckBox()
        Me.edtIPCamReceiveTimeout = New System.Windows.Forms.TextBox()
        Me.edtIPCamConnectionTimeout = New System.Windows.Forms.TextBox()
        Me.edtIPCameraURL = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.btnIPCamStartPreview = New System.Windows.Forms.Button()
        Me.lblFirstSelectIPCamera = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbIrCutFilterDisabled = New System.Windows.Forms.RadioButton()
        Me.rdbIrCutFilterEnabled = New System.Windows.Forms.RadioButton()
        Me.rdbIrCutFilterAuto = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.groupBox4.SuspendLayout()
        CType(Me.tbrPTZSpeedRatio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.tabPage2.SuspendLayout()
        CType(Me.tbrAbsolutePTZTilt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrAbsolutePTZZoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrAbsolutePTZPan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPage3.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox4
        '
        Me.groupBox4.Controls.Add(Me.button2)
        Me.groupBox4.Controls.Add(Me.btnContinousPTZStop)
        Me.groupBox4.Controls.Add(Me.label14)
        Me.groupBox4.Controls.Add(Me.tbrPTZSpeedRatio)
        Me.groupBox4.Controls.Add(Me.tabControl1)
        Me.groupBox4.Location = New System.Drawing.Point(779, 0)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(420, 163)
        Me.groupBox4.TabIndex = 116
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "PTZ"
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(377, 19)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(22, 22)
        Me.button2.TabIndex = 89
        Me.button2.Text = "?"
        Me.button2.UseVisualStyleBackColor = True
        '
        'btnContinousPTZStop
        '
        Me.btnContinousPTZStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinousPTZStop.Location = New System.Drawing.Point(290, 72)
        Me.btnContinousPTZStop.Name = "btnContinousPTZStop"
        Me.btnContinousPTZStop.Size = New System.Drawing.Size(109, 85)
        Me.btnContinousPTZStop.TabIndex = 26
        Me.btnContinousPTZStop.Text = "STOP"
        Me.btnContinousPTZStop.UseVisualStyleBackColor = True
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Location = New System.Drawing.Point(320, 20)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(51, 17)
        Me.label14.TabIndex = 90
        Me.label14.Text = "speed:"
        '
        'tbrPTZSpeedRatio
        '
        Me.tbrPTZSpeedRatio.AutoSize = False
        Me.tbrPTZSpeedRatio.Location = New System.Drawing.Point(290, 44)
        Me.tbrPTZSpeedRatio.Maximum = 100
        Me.tbrPTZSpeedRatio.Name = "tbrPTZSpeedRatio"
        Me.tbrPTZSpeedRatio.Size = New System.Drawing.Size(115, 24)
        Me.tbrPTZSpeedRatio.TabIndex = 91
        Me.tbrPTZSpeedRatio.TickFrequency = 26
        Me.tbrPTZSpeedRatio.Value = 100
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Controls.Add(Me.tabPage3)
        Me.tabControl1.Location = New System.Drawing.Point(49, 12)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(235, 145)
        Me.tabControl1.TabIndex = 93
        '
        'tabPage1
        '
        Me.tabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.tabPage1.Controls.Add(Me.label15)
        Me.tabPage1.Controls.Add(Me.chkStopOnRelease)
        Me.tabPage1.Controls.Add(Me.button1)
        Me.tabPage1.Controls.Add(Me.edtPTZDurationMs)
        Me.tabPage1.Controls.Add(Me.label10)
        Me.tabPage1.Controls.Add(Me.btnContinousPtzZoomOut)
        Me.tabPage1.Controls.Add(Me.btnContinousPtzZoomIn)
        Me.tabPage1.Controls.Add(Me.btnContinousPtzPanLeft)
        Me.tabPage1.Controls.Add(Me.btnContinousPtzPanRight)
        Me.tabPage1.Controls.Add(Me.btnContinousPtzTiltDown)
        Me.tabPage1.Controls.Add(Me.label7)
        Me.tabPage1.Controls.Add(Me.label8)
        Me.tabPage1.Controls.Add(Me.btnContinousPtzTiltUp)
        Me.tabPage1.Location = New System.Drawing.Point(4, 25)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(227, 116)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Continuous"
        '
        'label15
        '
        Me.label15.Location = New System.Drawing.Point(6, 74)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(144, 17)
        Me.label15.TabIndex = 15
        Me.label15.Text = "0 = continuous move"
        '
        'chkStopOnRelease
        '
        Me.chkStopOnRelease.AutoSize = True
        Me.chkStopOnRelease.Checked = True
        Me.chkStopOnRelease.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkStopOnRelease.Location = New System.Drawing.Point(6, 91)
        Me.chkStopOnRelease.Name = "chkStopOnRelease"
        Me.chkStopOnRelease.Size = New System.Drawing.Size(135, 21)
        Me.chkStopOnRelease.TabIndex = 27
        Me.chkStopOnRelease.Text = "mouse up = stop"
        Me.chkStopOnRelease.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(145, 51)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(23, 24)
        Me.button1.TabIndex = 25
        Me.button1.Text = "?"
        Me.button1.UseVisualStyleBackColor = True
        '
        'edtPTZDurationMs
        '
        Me.edtPTZDurationMs.Location = New System.Drawing.Point(102, 53)
        Me.edtPTZDurationMs.Name = "edtPTZDurationMs"
        Me.edtPTZDurationMs.Size = New System.Drawing.Size(39, 22)
        Me.edtPTZDurationMs.TabIndex = 24
        Me.edtPTZDurationMs.Text = "0"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(3, 56)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(92, 17)
        Me.label10.TabIndex = 23
        Me.label10.Text = "duration(ms):"
        '
        'btnContinousPtzZoomOut
        '
        Me.btnContinousPtzZoomOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinousPtzZoomOut.Location = New System.Drawing.Point(176, 25)
        Me.btnContinousPtzZoomOut.Name = "btnContinousPtzZoomOut"
        Me.btnContinousPtzZoomOut.Size = New System.Drawing.Size(22, 22)
        Me.btnContinousPtzZoomOut.TabIndex = 22
        Me.btnContinousPtzZoomOut.Text = "<"
        Me.btnContinousPtzZoomOut.UseVisualStyleBackColor = True
        '
        'btnContinousPtzZoomIn
        '
        Me.btnContinousPtzZoomIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinousPtzZoomIn.Location = New System.Drawing.Point(197, 25)
        Me.btnContinousPtzZoomIn.Name = "btnContinousPtzZoomIn"
        Me.btnContinousPtzZoomIn.Size = New System.Drawing.Size(22, 22)
        Me.btnContinousPtzZoomIn.TabIndex = 21
        Me.btnContinousPtzZoomIn.Text = ">"
        Me.btnContinousPtzZoomIn.UseVisualStyleBackColor = True
        '
        'btnContinousPtzPanLeft
        '
        Me.btnContinousPtzPanLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinousPtzPanLeft.Location = New System.Drawing.Point(78, 13)
        Me.btnContinousPtzPanLeft.Name = "btnContinousPtzPanLeft"
        Me.btnContinousPtzPanLeft.Size = New System.Drawing.Size(22, 22)
        Me.btnContinousPtzPanLeft.TabIndex = 20
        Me.btnContinousPtzPanLeft.Text = "<"
        Me.btnContinousPtzPanLeft.UseVisualStyleBackColor = True
        '
        'btnContinousPtzPanRight
        '
        Me.btnContinousPtzPanRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinousPtzPanRight.Location = New System.Drawing.Point(121, 13)
        Me.btnContinousPtzPanRight.Name = "btnContinousPtzPanRight"
        Me.btnContinousPtzPanRight.Size = New System.Drawing.Size(22, 22)
        Me.btnContinousPtzPanRight.TabIndex = 19
        Me.btnContinousPtzPanRight.Text = ">"
        Me.btnContinousPtzPanRight.UseVisualStyleBackColor = True
        '
        'btnContinousPtzTiltDown
        '
        Me.btnContinousPtzTiltDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinousPtzTiltDown.Location = New System.Drawing.Point(99, 25)
        Me.btnContinousPtzTiltDown.Name = "btnContinousPtzTiltDown"
        Me.btnContinousPtzTiltDown.Size = New System.Drawing.Size(22, 22)
        Me.btnContinousPtzTiltDown.TabIndex = 18
        Me.btnContinousPtzTiltDown.Text = "v"
        Me.btnContinousPtzTiltDown.UseVisualStyleBackColor = True
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(171, 5)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(48, 17)
        Me.label7.TabIndex = 17
        Me.label7.Text = "Zoom:"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(14, 16)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(60, 17)
        Me.label8.TabIndex = 16
        Me.label8.Text = "Pan/Tilt:"
        '
        'btnContinousPtzTiltUp
        '
        Me.btnContinousPtzTiltUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinousPtzTiltUp.Location = New System.Drawing.Point(99, 2)
        Me.btnContinousPtzTiltUp.Name = "btnContinousPtzTiltUp"
        Me.btnContinousPtzTiltUp.Size = New System.Drawing.Size(22, 22)
        Me.btnContinousPtzTiltUp.TabIndex = 14
        Me.btnContinousPtzTiltUp.Text = "^"
        Me.btnContinousPtzTiltUp.UseVisualStyleBackColor = True
        '
        'tabPage2
        '
        Me.tabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.tabPage2.Controls.Add(Me.btnPTZActualiseTrackbars)
        Me.tabPage2.Controls.Add(Me.tbrAbsolutePTZTilt)
        Me.tabPage2.Controls.Add(Me.label13)
        Me.tabPage2.Controls.Add(Me.label12)
        Me.tabPage2.Controls.Add(Me.tbrAbsolutePTZZoom)
        Me.tabPage2.Controls.Add(Me.label11)
        Me.tabPage2.Controls.Add(Me.tbrAbsolutePTZPan)
        Me.tabPage2.Location = New System.Drawing.Point(4, 25)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(227, 116)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "Absolute"
        '
        'btnPTZActualiseTrackbars
        '
        Me.btnPTZActualiseTrackbars.Location = New System.Drawing.Point(9, 9)
        Me.btnPTZActualiseTrackbars.Name = "btnPTZActualiseTrackbars"
        Me.btnPTZActualiseTrackbars.Size = New System.Drawing.Size(144, 26)
        Me.btnPTZActualiseTrackbars.TabIndex = 53
        Me.btnPTZActualiseTrackbars.Text = "actualise trackbars"
        Me.btnPTZActualiseTrackbars.UseVisualStyleBackColor = True
        '
        'tbrAbsolutePTZTilt
        '
        Me.tbrAbsolutePTZTilt.AutoSize = False
        Me.tbrAbsolutePTZTilt.Location = New System.Drawing.Point(188, 3)
        Me.tbrAbsolutePTZTilt.Maximum = 100
        Me.tbrAbsolutePTZTilt.Minimum = -100
        Me.tbrAbsolutePTZTilt.Name = "tbrAbsolutePTZTilt"
        Me.tbrAbsolutePTZTilt.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbrAbsolutePTZTilt.Size = New System.Drawing.Size(23, 109)
        Me.tbrAbsolutePTZTilt.TabIndex = 52
        Me.tbrAbsolutePTZTilt.TickFrequency = 26
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(169, 49)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(26, 17)
        Me.label13.TabIndex = 51
        Me.label13.Text = "tilt:"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(9, 70)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(46, 17)
        Me.label12.TabIndex = 50
        Me.label12.Text = "zoom:"
        '
        'tbrAbsolutePTZZoom
        '
        Me.tbrAbsolutePTZZoom.AutoSize = False
        Me.tbrAbsolutePTZZoom.Location = New System.Drawing.Point(3, 90)
        Me.tbrAbsolutePTZZoom.Maximum = 50
        Me.tbrAbsolutePTZZoom.Name = "tbrAbsolutePTZZoom"
        Me.tbrAbsolutePTZZoom.Size = New System.Drawing.Size(143, 25)
        Me.tbrAbsolutePTZZoom.TabIndex = 49
        Me.tbrAbsolutePTZZoom.TickFrequency = 26
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(9, 34)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(36, 17)
        Me.label11.TabIndex = 48
        Me.label11.Text = "pan:"
        '
        'tbrAbsolutePTZPan
        '
        Me.tbrAbsolutePTZPan.AutoSize = False
        Me.tbrAbsolutePTZPan.Location = New System.Drawing.Point(6, 50)
        Me.tbrAbsolutePTZPan.Maximum = 100
        Me.tbrAbsolutePTZPan.Minimum = -100
        Me.tbrAbsolutePTZPan.Name = "tbrAbsolutePTZPan"
        Me.tbrAbsolutePTZPan.Size = New System.Drawing.Size(140, 23)
        Me.tbrAbsolutePTZPan.TabIndex = 47
        Me.tbrAbsolutePTZPan.TickFrequency = 26
        '
        'tabPage3
        '
        Me.tabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.tabPage3.Controls.Add(Me.txtPTZRelativeMove)
        Me.tabPage3.Controls.Add(Me.label18)
        Me.tabPage3.Controls.Add(Me.btnRelativeZoomOut)
        Me.tabPage3.Controls.Add(Me.btnRelativeZoomIn)
        Me.tabPage3.Controls.Add(Me.btnRelativePanLeft)
        Me.tabPage3.Controls.Add(Me.btnRelativePanRight)
        Me.tabPage3.Controls.Add(Me.btnRelativeTiltDown)
        Me.tabPage3.Controls.Add(Me.label16)
        Me.tabPage3.Controls.Add(Me.label17)
        Me.tabPage3.Controls.Add(Me.btnRelativeTiltUp)
        Me.tabPage3.Location = New System.Drawing.Point(4, 25)
        Me.tabPage3.Name = "tabPage3"
        Me.tabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage3.Size = New System.Drawing.Size(227, 116)
        Me.tabPage3.TabIndex = 2
        Me.tabPage3.Text = "Relative"
        '
        'txtPTZRelativeMove
        '
        Me.txtPTZRelativeMove.Location = New System.Drawing.Point(112, 6)
        Me.txtPTZRelativeMove.Name = "txtPTZRelativeMove"
        Me.txtPTZRelativeMove.Size = New System.Drawing.Size(39, 22)
        Me.txtPTZRelativeMove.TabIndex = 32
        Me.txtPTZRelativeMove.Text = "0,01"
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.Location = New System.Drawing.Point(13, 9)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(96, 17)
        Me.label18.TabIndex = 31
        Me.label18.Text = "relative move:"
        '
        'btnRelativeZoomOut
        '
        Me.btnRelativeZoomOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRelativeZoomOut.Location = New System.Drawing.Point(160, 43)
        Me.btnRelativeZoomOut.Name = "btnRelativeZoomOut"
        Me.btnRelativeZoomOut.Size = New System.Drawing.Size(22, 22)
        Me.btnRelativeZoomOut.TabIndex = 30
        Me.btnRelativeZoomOut.Text = "<"
        Me.btnRelativeZoomOut.UseVisualStyleBackColor = True
        '
        'btnRelativeZoomIn
        '
        Me.btnRelativeZoomIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRelativeZoomIn.Location = New System.Drawing.Point(181, 43)
        Me.btnRelativeZoomIn.Name = "btnRelativeZoomIn"
        Me.btnRelativeZoomIn.Size = New System.Drawing.Size(22, 22)
        Me.btnRelativeZoomIn.TabIndex = 29
        Me.btnRelativeZoomIn.Text = ">"
        Me.btnRelativeZoomIn.UseVisualStyleBackColor = True
        '
        'btnRelativePanLeft
        '
        Me.btnRelativePanLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRelativePanLeft.Location = New System.Drawing.Point(70, 40)
        Me.btnRelativePanLeft.Name = "btnRelativePanLeft"
        Me.btnRelativePanLeft.Size = New System.Drawing.Size(22, 22)
        Me.btnRelativePanLeft.TabIndex = 28
        Me.btnRelativePanLeft.Text = "<"
        Me.btnRelativePanLeft.UseVisualStyleBackColor = True
        '
        'btnRelativePanRight
        '
        Me.btnRelativePanRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRelativePanRight.Location = New System.Drawing.Point(113, 40)
        Me.btnRelativePanRight.Name = "btnRelativePanRight"
        Me.btnRelativePanRight.Size = New System.Drawing.Size(22, 22)
        Me.btnRelativePanRight.TabIndex = 27
        Me.btnRelativePanRight.Text = ">"
        Me.btnRelativePanRight.UseVisualStyleBackColor = True
        '
        'btnRelativeTiltDown
        '
        Me.btnRelativeTiltDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRelativeTiltDown.Location = New System.Drawing.Point(91, 52)
        Me.btnRelativeTiltDown.Name = "btnRelativeTiltDown"
        Me.btnRelativeTiltDown.Size = New System.Drawing.Size(22, 22)
        Me.btnRelativeTiltDown.TabIndex = 26
        Me.btnRelativeTiltDown.Text = "v"
        Me.btnRelativeTiltDown.UseVisualStyleBackColor = True
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Location = New System.Drawing.Point(157, 25)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(48, 17)
        Me.label16.TabIndex = 25
        Me.label16.Text = "Zoom:"
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Location = New System.Drawing.Point(6, 43)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(60, 17)
        Me.label17.TabIndex = 24
        Me.label17.Text = "Pan/Tilt:"
        '
        'btnRelativeTiltUp
        '
        Me.btnRelativeTiltUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRelativeTiltUp.Location = New System.Drawing.Point(91, 29)
        Me.btnRelativeTiltUp.Name = "btnRelativeTiltUp"
        Me.btnRelativeTiltUp.Size = New System.Drawing.Size(22, 22)
        Me.btnRelativeTiltUp.TabIndex = 23
        Me.btnRelativeTiltUp.Text = "^"
        Me.btnRelativeTiltUp.UseVisualStyleBackColor = True
        '
        'chkUseExternalAudioforRTSP
        '
        Me.chkUseExternalAudioforRTSP.AutoSize = True
        Me.chkUseExternalAudioforRTSP.Location = New System.Drawing.Point(254, 18)
        Me.chkUseExternalAudioforRTSP.Name = "chkUseExternalAudioforRTSP"
        Me.chkUseExternalAudioforRTSP.Size = New System.Drawing.Size(323, 21)
        Me.chkUseExternalAudioforRTSP.TabIndex = 115
        Me.chkUseExternalAudioforRTSP.Text = "use the selected audio device as audio source"
        Me.chkUseExternalAudioforRTSP.UseVisualStyleBackColor = True
        '
        'txtBacktimedRecordingSeconds
        '
        Me.txtBacktimedRecordingSeconds.Location = New System.Drawing.Point(742, 72)
        Me.txtBacktimedRecordingSeconds.Name = "txtBacktimedRecordingSeconds"
        Me.txtBacktimedRecordingSeconds.Size = New System.Drawing.Size(31, 22)
        Me.txtBacktimedRecordingSeconds.TabIndex = 114
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(405, 94)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(72, 22)
        Me.label2.TabIndex = 113
        Me.label2.Text = "password:"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'edtIPCamPassword
        '
        Me.edtIPCamPassword.Location = New System.Drawing.Point(408, 112)
        Me.edtIPCamPassword.Name = "edtIPCamPassword"
        Me.edtIPCamPassword.Size = New System.Drawing.Size(69, 22)
        Me.edtIPCamPassword.TabIndex = 112
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(335, 94)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(67, 16)
        Me.label1.TabIndex = 111
        Me.label1.Text = "user:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'edtIPCamUserName
        '
        Me.edtIPCamUserName.Location = New System.Drawing.Point(337, 112)
        Me.edtIPCamUserName.Name = "edtIPCamUserName"
        Me.edtIPCamUserName.Size = New System.Drawing.Size(65, 22)
        Me.edtIPCamUserName.TabIndex = 110
        '
        'chkBacktimedRecording
        '
        Me.chkBacktimedRecording.AutoSize = True
        Me.chkBacktimedRecording.Location = New System.Drawing.Point(395, 74)
        Me.chkBacktimedRecording.Name = "chkBacktimedRecording"
        Me.chkBacktimedRecording.Size = New System.Drawing.Size(353, 21)
        Me.chkBacktimedRecording.TabIndex = 109
        Me.chkBacktimedRecording.Text = "backtimed recording duration (pre-roll), in seconds:"
        Me.chkBacktimedRecording.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(11, 140)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(723, 77)
        Me.RichTextBox1.TabIndex = 108
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(11, 109)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(310, 17)
        Me.label6.TabIndex = 107
        Me.label6.Text = "(other recording settings in the ""Recording"" tab)"
        '
        'btnIPCamStartMP4Recording
        '
        Me.btnIPCamStartMP4Recording.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIPCamStartMP4Recording.Location = New System.Drawing.Point(197, 72)
        Me.btnIPCamStartMP4Recording.Name = "btnIPCamStartMP4Recording"
        Me.btnIPCamStartMP4Recording.Size = New System.Drawing.Size(186, 25)
        Me.btnIPCamStartMP4Recording.TabIndex = 106
        Me.btnIPCamStartMP4Recording.Text = "Start MP4 recording"
        '
        'btnIPCamStop
        '
        Me.btnIPCamStop.Location = New System.Drawing.Point(125, 72)
        Me.btnIPCamStop.Name = "btnIPCamStop"
        Me.btnIPCamStop.Size = New System.Drawing.Size(66, 25)
        Me.btnIPCamStop.TabIndex = 105
        Me.btnIPCamStop.Text = "Stop"
        '
        'chkOpenURLAsync
        '
        Me.chkOpenURLAsync.AutoSize = True
        Me.chkOpenURLAsync.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOpenURLAsync.Location = New System.Drawing.Point(7, 19)
        Me.chkOpenURLAsync.Name = "chkOpenURLAsync"
        Me.chkOpenURLAsync.Size = New System.Drawing.Size(248, 21)
        Me.chkOpenURLAsync.TabIndex = 104
        Me.chkOpenURLAsync.Text = "open the URL asynchronously"
        Me.chkOpenURLAsync.UseVisualStyleBackColor = True
        '
        'edtIPCamReceiveTimeout
        '
        Me.edtIPCamReceiveTimeout.Location = New System.Drawing.Point(614, 112)
        Me.edtIPCamReceiveTimeout.Name = "edtIPCamReceiveTimeout"
        Me.edtIPCamReceiveTimeout.Size = New System.Drawing.Size(80, 22)
        Me.edtIPCamReceiveTimeout.TabIndex = 99
        Me.edtIPCamReceiveTimeout.Text = "5000"
        '
        'edtIPCamConnectionTimeout
        '
        Me.edtIPCamConnectionTimeout.Location = New System.Drawing.Point(483, 112)
        Me.edtIPCamConnectionTimeout.Name = "edtIPCamConnectionTimeout"
        Me.edtIPCamConnectionTimeout.Size = New System.Drawing.Size(98, 22)
        Me.edtIPCamConnectionTimeout.TabIndex = 98
        Me.edtIPCamConnectionTimeout.Text = "10000"
        '
        'edtIPCameraURL
        '
        Me.edtIPCameraURL.Location = New System.Drawing.Point(72, 44)
        Me.edtIPCameraURL.Name = "edtIPCameraURL"
        Me.edtIPCameraURL.Size = New System.Drawing.Size(600, 22)
        Me.edtIPCameraURL.TabIndex = 97
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(611, 94)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(148, 19)
        Me.label5.TabIndex = 103
        Me.label5.Text = "receive timeout (ms):"
        Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(483, 94)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(132, 22)
        Me.label4.TabIndex = 102
        Me.label4.Text = "conn. timeout (ms):"
        Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(7, 46)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(59, 18)
        Me.label3.TabIndex = 101
        Me.label3.Text = "URL:"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'btnIPCamStartPreview
        '
        Me.btnIPCamStartPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIPCamStartPreview.Location = New System.Drawing.Point(8, 72)
        Me.btnIPCamStartPreview.Name = "btnIPCamStartPreview"
        Me.btnIPCamStartPreview.Size = New System.Drawing.Size(111, 25)
        Me.btnIPCamStartPreview.TabIndex = 100
        Me.btnIPCamStartPreview.Text = "Start preview"
        '
        'lblFirstSelectIPCamera
        '
        Me.lblFirstSelectIPCamera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstSelectIPCamera.ForeColor = System.Drawing.Color.Red
        Me.lblFirstSelectIPCamera.Location = New System.Drawing.Point(4, 0)
        Me.lblFirstSelectIPCamera.Name = "lblFirstSelectIPCamera"
        Me.lblFirstSelectIPCamera.Size = New System.Drawing.Size(654, 16)
        Me.lblFirstSelectIPCamera.TabIndex = 96
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.rdbIrCutFilterDisabled)
        Me.groupBox1.Controls.Add(Me.rdbIrCutFilterEnabled)
        Me.groupBox1.Controls.Add(Me.rdbIrCutFilterAuto)
        Me.groupBox1.Location = New System.Drawing.Point(791, 177)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(387, 40)
        Me.groupBox1.TabIndex = 117
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "IR Cut filter of Axis cameras"
        '
        'rdbIrCutFilterDisabled
        '
        Me.rdbIrCutFilterDisabled.AutoSize = True
        Me.rdbIrCutFilterDisabled.Location = New System.Drawing.Point(299, 14)
        Me.rdbIrCutFilterDisabled.Name = "rdbIrCutFilterDisabled"
        Me.rdbIrCutFilterDisabled.Size = New System.Drawing.Size(82, 21)
        Me.rdbIrCutFilterDisabled.TabIndex = 2
        Me.rdbIrCutFilterDisabled.TabStop = True
        Me.rdbIrCutFilterDisabled.Text = "disabled"
        Me.rdbIrCutFilterDisabled.UseVisualStyleBackColor = True
        '
        'rdbIrCutFilterEnabled
        '
        Me.rdbIrCutFilterEnabled.AutoSize = True
        Me.rdbIrCutFilterEnabled.Location = New System.Drawing.Point(213, 14)
        Me.rdbIrCutFilterEnabled.Name = "rdbIrCutFilterEnabled"
        Me.rdbIrCutFilterEnabled.Size = New System.Drawing.Size(80, 21)
        Me.rdbIrCutFilterEnabled.TabIndex = 1
        Me.rdbIrCutFilterEnabled.TabStop = True
        Me.rdbIrCutFilterEnabled.Text = "enabled"
        Me.rdbIrCutFilterEnabled.UseVisualStyleBackColor = True
        '
        'rdbIrCutFilterAuto
        '
        Me.rdbIrCutFilterAuto.AutoSize = True
        Me.rdbIrCutFilterAuto.Location = New System.Drawing.Point(150, 14)
        Me.rdbIrCutFilterAuto.Name = "rdbIrCutFilterAuto"
        Me.rdbIrCutFilterAuto.Size = New System.Drawing.Size(57, 21)
        Me.rdbIrCutFilterAuto.TabIndex = 0
        Me.rdbIrCutFilterAuto.TabStop = True
        Me.rdbIrCutFilterAuto.Text = "auto"
        Me.rdbIrCutFilterAuto.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(5, -1)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(654, 16)
        Me.Label9.TabIndex = 118
        Me.Label9.Text = "first select VideoSource = vs_IPCamera in the Video Sources list of the  ""video s" &
    "ource"" tab"
        '
        'IPCamera
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(1209, 228)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.groupBox4)
        Me.Controls.Add(Me.chkUseExternalAudioforRTSP)
        Me.Controls.Add(Me.txtBacktimedRecordingSeconds)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.edtIPCamPassword)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.edtIPCamUserName)
        Me.Controls.Add(Me.chkBacktimedRecording)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.btnIPCamStartMP4Recording)
        Me.Controls.Add(Me.btnIPCamStop)
        Me.Controls.Add(Me.chkOpenURLAsync)
        Me.Controls.Add(Me.edtIPCamReceiveTimeout)
        Me.Controls.Add(Me.edtIPCamConnectionTimeout)
        Me.Controls.Add(Me.edtIPCameraURL)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.btnIPCamStartPreview)
        Me.Controls.Add(Me.lblFirstSelectIPCamera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IPCamera"
        Me.ShowInTaskbar = False
        Me.Text = "IPCamera"
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox4.PerformLayout()
        CType(Me.tbrPTZSpeedRatio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tabPage1.PerformLayout()
        Me.tabPage2.ResumeLayout(False)
        Me.tabPage2.PerformLayout()
        CType(Me.tbrAbsolutePTZTilt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrAbsolutePTZZoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrAbsolutePTZPan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPage3.ResumeLayout(False)
        Me.tabPage3.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Sub RefreshControls()
        lblFirstSelectIPCamera.Visible = (MainForm.DefInstance.VideoGrabber1.VideoSource <> VidGrab.TVideoSource.vs_IPCamera)
    End Sub

    Private Sub btnIPCamera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim SW_SHOW As Int32
        SW_SHOW = 5

        ShellExecute(0, "open", "http://www.datastead.com/demo/IPCam.htm", "", "", SW_SHOW)
    End Sub

    Private Sub edtIPCameraURL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MainForm.DefInstance.VideoGrabber1.IPCameraURL = edtIPCameraURL.Text
    End Sub

    Private Sub edtIPCamUserName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtIPCamUserName.TextChanged
        MainForm.DefInstance.VideoGrabber1.SetAuthentication(VidGrab.TAuthenticationType.at_IPCamera, edtIPCamUserName.Text, edtIPCamPassword.Text)
    End Sub

    Private Sub edtIPCamPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtIPCamPassword.TextChanged
        MainForm.DefInstance.VideoGrabber1.SetAuthentication(VidGrab.TAuthenticationType.at_IPCamera, edtIPCamUserName.Text, edtIPCamPassword.Text)
    End Sub

    Private Sub edtIPCamConnectionTimeout_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtIPCamConnectionTimeout.TextChanged
        If IsNumeric(edtIPCamConnectionTimeout.Text) Then
            MainForm.DefInstance.VideoGrabber1.SetIPCameraSetting(VidGrab.TIPCameraSetting.ips_ConnectionTimeout, Convert.ToInt32(edtIPCamConnectionTimeout.Text))
        End If
    End Sub

    Private Sub edtIPCamReceiveTimeout_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtIPCamReceiveTimeout.TextChanged
        If (IsNumeric(edtIPCamReceiveTimeout.Text)) Then
            MainForm.DefInstance.VideoGrabber1.SetIPCameraSetting(VidGrab.TIPCameraSetting.ips_ReceiveTimeout, Convert.ToInt32(edtIPCamReceiveTimeout.Text))
        End If
    End Sub

    Private Sub btnIPCamStartPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIPCamStartPreview.Click
        If MainForm.DefInstance.VideoGrabber1.VideoSource <> VidGrab.TVideoSource.vs_IPCamera Then
            MainForm.DefInstance.VideoGrabber1.VideoSource = VidGrab.TVideoSource.vs_IPCamera
            AddLog(MainForm.DefInstance.mmoLog, "VideoSource set to ""vs_IPCamera""")
        End If
        MainForm.DefInstance.VideoGrabber1.IPCameraURL = edtIPCameraURL.Text
        MainForm.DefInstance.VideoGrabber1.StartPreview()
    End Sub

    Private Sub btnIPCamStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIPCamStop.Click
        MainForm.DefInstance.VideoGrabber1.Stop()
    End Sub

    Private Sub chkUseExternalAudioforRTSP_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkUseExternalAudioforRTSP.CheckedChanged
        If chkUseExternalAudioforRTSP.Checked Then
            MainForm.DefInstance.VideoGrabber1.AudioSource = VidGrab.TAudioSource.as_UseExternalAudio
        Else
            MainForm.DefInstance.VideoGrabber1.AudioSource = VidGrab.TAudioSource.as_Default
        End If
    End Sub

    Private Sub btnIPCamStartMP4Recording_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIPCamStartMP4Recording.Click
        If MainForm.DefInstance.VideoGrabber1.VideoSource <> VidGrab.TVideoSource.vs_IPCamera Then
            MainForm.DefInstance.VideoGrabber1.VideoSource = VidGrab.TVideoSource.vs_IPCamera
            AddLog(MainForm.DefInstance.mmoLog, "VideoSource set to ""vs_IPCamera""")
        End If
        MainForm.DefInstance.frmRecording.rdgRecordingMethodMP4.Checked = True

        If chkBacktimedRecording.Checked Then
            Dim BacktimedRecordingDurationInSeconds As Integer = 10
            If Integer.TryParse(txtBacktimedRecordingSeconds.Text, BacktimedRecordingDurationInSeconds) Then
                If BacktimedRecordingDurationInSeconds > 0 Then
                    ' to activate a pre-roll of 5 seconds on the RTSP filter add ">backtimed=5" at the end of the RTSP URL
                    MainForm.DefInstance.VideoGrabber1.IPCameraURL = edtIPCameraURL.Text + ">backtimed=" + BacktimedRecordingDurationInSeconds.ToString()
                    MainForm.DefInstance.VideoGrabber1.HoldRecording = True ' To start the recording In "preview mode", ready To start the recording When VideoGrabber.ResumeRecording will be invoked
                End If
            End If
        End If


        MainForm.DefInstance.VideoGrabber1.StartRecording()
    End Sub

    Private Sub chkOpenURLAsync_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOpenURLAsync.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.OpenURLAsync = chkOpenURLAsync.Checked
    End Sub

    Private Sub IPCamera_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Visible Then
            RefreshControls()
        End If
    End Sub


    Private Sub tbrPTZSpeedRatio_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles tbrPTZSpeedRatio.Scroll
        m_PTZSpeedRatio = tbrPTZSpeedRatio.Value / 100
    End Sub

    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
        MessageBox.Show("The 'PTZ speed adjustment' and 'absolute PTZ move' capabilities are not supported by all the brands/models of ONVIF cameras")
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        MessageBox.Show("Duration of the motion expressed in milliseconds." & vbNewLine & "0 = continuous move" & vbNewLine & vbNewLine & "Note: some cameras may not support a motion duration and move continuously even if a duration is specified." & vbNewLine & "In this case invoke StartMove(), wait the desired duration with a timer then invoke StopMove()")
    End Sub

    Dim m_PTZSpeedRatio As Double = 1
    Dim m_UpdatingPTZTrackbars As Boolean = False
    Dim m_PTZMoveDurationMs As Integer = 300
    Dim m_PTZRelativeMove As Double = 0.01
    Private Sub edtPTZDurationMs_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles edtPTZDurationMs.TextChanged
        Integer.TryParse(edtPTZDurationMs.Text, m_PTZMoveDurationMs)
    End Sub

    Private Sub StartContinousPTZMove(ByVal PTZType As String, ByVal OppositeDirection As Boolean)

        If MainForm.DefInstance.VideoGrabber1.ONVIFPTZStartMove(PTZType, OppositeDirection, m_PTZSpeedRatio, m_PTZMoveDurationMs) Then

            AddLog(MainForm.DefInstance.mmoLog, "continuous move started")

        Else

            AddLog(MainForm.DefInstance.mmoLog, "PTZ move command failed, verify that this camera supports ONVIF and start the camera with an " & vbNewLine & "ONVIF://user:password@IPADDRESS URL syntax")
        End If
    End Sub

    Private Sub StopContinousPTZMove()
        MainForm.DefInstance.VideoGrabber1.ONVIFPTZStopMove("Pan")
        MainForm.DefInstance.VideoGrabber1.ONVIFPTZStopMove("Tilt")
        MainForm.DefInstance.VideoGrabber1.ONVIFPTZStopMove("Zoom")
    End Sub


    Private Sub btnPTZStop_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnContinousPTZStop.Click
        StopContinousPTZMove()
    End Sub

    Private Sub ContinuousPtzButtons_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles btnContinousPtzTiltUp.MouseUp, btnContinousPtzZoomOut.MouseUp, btnContinousPtzZoomIn.MouseUp, btnContinousPtzTiltDown.MouseUp, btnContinousPtzPanRight.MouseUp, btnContinousPtzPanLeft.MouseUp
        If chkStopOnRelease.Checked Then
            StopContinousPTZMove()
        End If
    End Sub

    Public Class PTZTypes

        Public Shared Pan As String = "Pan"
        Public Shared Tilt As String = "Tilt"
        Public Shared Zoom As String = "Zoom"
    End Class

    Private Sub btnContinousPtzTiltUp_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles btnContinousPtzTiltUp.MouseDown
        StartContinousPTZMove(PTZTypes.Tilt, False)

    End Sub

    Private Sub btnContinousPtzTiltDown_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles btnContinousPtzTiltDown.MouseDown
        StartContinousPTZMove(PTZTypes.Tilt, True)

    End Sub

    Private Sub btnContinousPtzPanLeft_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles btnContinousPtzPanLeft.MouseDown
        StartContinousPTZMove(PTZTypes.Pan, False)

    End Sub

    Private Sub btnContinousPtzPanRight_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles btnContinousPtzPanRight.MouseDown
        StartContinousPTZMove(PTZTypes.Pan, True)

    End Sub

    Private Sub btnContinousPtzZoomOut_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles btnContinousPtzZoomOut.MouseDown
        StartContinousPTZMove(PTZTypes.Zoom, False)

    End Sub

    Private Sub btnContinousPtzZoomIn_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles btnContinousPtzZoomIn.MouseDown
        StartContinousPTZMove(PTZTypes.Zoom, True)

    End Sub

    Private Sub btnPTZActualiseTrackbars_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPTZActualiseTrackbars.Click
        Dim dPan_Min, dPan_Max As Double
        Dim dTilt_Min, dTilt_Max As Double
        Dim dZoom_Min, dZoom_Max As Double

        If MainForm.DefInstance.VideoGrabber1.ONVIFPTZGetLimits(dPan_Min, dPan_Max, dTilt_Min, dTilt_Max, dZoom_Min, dZoom_Max) Then

            ' let's multiply by 100, the trackbars are in the 0..100 range, and the PTZ values must be in the 0.0 ... 1.0 range

            tbrAbsolutePTZPan.Minimum = Convert.ToInt32(dPan_Min * 100.0)
            tbrAbsolutePTZPan.Maximum = Convert.ToInt32(dPan_Max * 100.0)
            tbrAbsolutePTZTilt.Minimum = Convert.ToInt32(dTilt_Min * 100.0)
            tbrAbsolutePTZTilt.Maximum = Convert.ToInt32(dTilt_Max * 100.0)
            tbrAbsolutePTZZoom.Minimum = Convert.ToInt32(dZoom_Min * 100.0)
            tbrAbsolutePTZZoom.Maximum = Convert.ToInt32(dZoom_Max * 100.0)
            tbrPTZSpeedRatio.Minimum = 0
            tbrPTZSpeedRatio.Maximum = 100
            tbrPTZSpeedRatio.Value = Convert.ToInt32(m_PTZSpeedRatio * 100.0)

            Dim dPan, dTilt, dZoom As Double
            Dim UTCTime As Double
            Dim IsMoving As Integer

            If MainForm.DefInstance.VideoGrabber1.ONVIFPTZGetPosition(dPan, dTilt, dZoom, UTCTime, IsMoving) Then

                m_UpdatingPTZTrackbars = True
                tbrAbsolutePTZPan.Value = Convert.ToInt32(dPan * 100.0)
                tbrAbsolutePTZTilt.Value = Convert.ToInt32(dTilt * 100.0)
                tbrAbsolutePTZZoom.Value = Convert.ToInt32(dZoom * 100.0)
                m_UpdatingPTZTrackbars = False
            End If
        End If

    End Sub

    Private Sub DoPTZAbsolute()

        If Not m_UpdatingPTZTrackbars Then

            ' let's divide by 100, the trackbars are in the 0..100 range, and the PTZ values must be in the 0.0 ... 1.0 range
            Dim dPan As Double = Convert.ToDouble(tbrAbsolutePTZPan.Value) / 100
            Dim dTilt As Double = Convert.ToDouble(tbrAbsolutePTZTilt.Value) / 100
            Dim dZoom As Double = Convert.ToDouble(tbrAbsolutePTZZoom.Value) / 100

            If MainForm.DefInstance.VideoGrabber1.ONVIFPTZSetPosition(dPan, dTilt, dZoom, m_PTZSpeedRatio, False) Then

                AddLog(MainForm.DefInstance.mmoLog, "absolute PTZ move Ok")

            Else

                AddLog(MainForm.DefInstance.mmoLog, "absolute PTZ move command failed, verify that this camera supports ONVIF and has the absolute PTZ feature.  The camera must be started with an 'ONVIF://user:password@IPADDRESS' URL syntax")
            End If
        End If
    End Sub

    Private Sub DoPTZRelative(ByVal dPan As Double, ByVal dTilt As Double, ByVal dZoom As Double)
        If MainForm.DefInstance.VideoGrabber1.ONVIFPTZSetPosition(dPan, dTilt, dZoom, m_PTZSpeedRatio, True) Then

            AddLog(MainForm.DefInstance.mmoLog, "relative PTZ move Ok")

        Else

            AddLog(MainForm.DefInstance.mmoLog, "relative PTZ move command failed, verify that this camera supports ONVIF and has the absolute PTZ feature.  The camera must be started with an 'ONVIF://user:password@IPADDRESS' URL syntax")
        End If
    End Sub

    Private Sub tbrAbsolutePTZ_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles tbrAbsolutePTZPan.MouseUp, tbrAbsolutePTZTilt.MouseUp, tbrAbsolutePTZZoom.MouseUp
        DoPTZAbsolute()
    End Sub

    Private Sub txtPTZRelativeMove_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtPTZRelativeMove.TextChanged
        Double.TryParse(txtPTZRelativeMove.Text, m_PTZRelativeMove)
    End Sub

    Private Sub btnRelativeTiltUp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRelativeTiltUp.Click
        DoPTZRelative(0, m_PTZRelativeMove, 0)
    End Sub

    Private Sub btnRelativeTiltDown_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRelativeTiltDown.Click
        DoPTZRelative(0, -m_PTZRelativeMove, 0)
    End Sub

    Private Sub btnRelativePanLeft_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRelativePanLeft.Click
        DoPTZRelative(m_PTZRelativeMove, 0, 0)
    End Sub

    Private Sub btnRelativePanRight_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRelativePanRight.Click
        DoPTZRelative(-m_PTZRelativeMove, 0, 0)
    End Sub

    Private Sub btnRelativeZoomOut_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRelativeZoomOut.Click
        DoPTZRelative(0, 0, -m_PTZRelativeMove)
    End Sub

    Private Sub btnRelativeZoomIn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRelativeZoomIn.Click
        DoPTZRelative(0, 0, m_PTZRelativeMove)

    End Sub

    Private Sub rdbIrCutFilterAuto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbIrCutFilterAuto.CheckedChanged
        If rdbIrCutFilterAuto.Checked Then
            MainForm.DefInstance.VideoGrabber1.ONVIF_SetStr("RTSP_Source_Axis_IrCutFilter_str", "auto")
        End If
    End Sub

    Private Sub rdbIrCutFilterEnabled_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbIrCutFilterEnabled.CheckedChanged
        If rdbIrCutFilterEnabled.Checked Then
            MainForm.DefInstance.VideoGrabber1.ONVIF_SetStr("RTSP_Source_Axis_IrCutFilter_str", "enabled")
        End If
    End Sub

    Private Sub rdbIrCutFilterDisabled_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbIrCutFilterDisabled.CheckedChanged
        If rdbIrCutFilterDisabled.Checked Then
            MainForm.DefInstance.VideoGrabber1.ONVIF_SetStr("RTSP_Source_Axis_IrCutFilter_str", "disabled")
        End If
    End Sub
End Class
