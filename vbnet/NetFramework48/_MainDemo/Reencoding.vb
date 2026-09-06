Option Strict Off
Option Explicit On
Friend Class Reencoding
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
    Public WithEvents btnStopReencoding As System.Windows.Forms.Button
    Public WithEvents btnStartReencoding As System.Windows.Forms.Button
    Public WithEvents rdgReencodingMethod1 As System.Windows.Forms.RadioButton
    Public WithEvents rdgReencodingMethod2 As System.Windows.Forms.RadioButton
    Public WithEvents rdgReencodingMethod As System.Windows.Forms.GroupBox
    Public WithEvents chkWMVOutput As System.Windows.Forms.CheckBox
    Public WithEvents chkUseFrameGrabber As System.Windows.Forms.CheckBox
    Public WithEvents chkIncludeAudioStream As System.Windows.Forms.CheckBox
    Public WithEvents chkUseCurrentVideoCompressor As System.Windows.Forms.CheckBox
    Public WithEvents chkIncludeVideoStream As System.Windows.Forms.CheckBox
    Public WithEvents chkUseCurrentAudioCompressor As System.Windows.Forms.CheckBox
    Public WithEvents grbReencodingSettings As System.Windows.Forms.GroupBox
    Public WithEvents edtDuration As System.Windows.Forms.TextBox
    Public WithEvents edtStartTime As System.Windows.Forms.TextBox
    Public WithEvents edtStopTime As System.Windows.Forms.TextBox
    Public WithEvents btnDuration As System.Windows.Forms.Button
    Public WithEvents grbStartStopTime As System.Windows.Forms.GroupBox
    Public WithEvents edtDestinationVideoClip As System.Windows.Forms.TextBox
    Public WithEvents edtSourceVideoClip As System.Windows.Forms.TextBox
    Public WithEvents btnSourceVideoClip As System.Windows.Forms.Button
    Public WithEvents Label33 As System.Windows.Forms.Label
    Public WithEvents Label32 As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents edtStartFrame As System.Windows.Forms.TextBox
    Public WithEvents edtStopFrame As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents edtFrameCount As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reencoding))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnStopReencoding = New System.Windows.Forms.Button
        Me.btnStartReencoding = New System.Windows.Forms.Button
        Me.rdgReencodingMethod = New System.Windows.Forms.GroupBox
        Me.rdgReencodingMethod2 = New System.Windows.Forms.RadioButton
        Me.rdgReencodingMethod1 = New System.Windows.Forms.RadioButton
        Me.grbReencodingSettings = New System.Windows.Forms.GroupBox
        Me.chkWMVOutput = New System.Windows.Forms.CheckBox
        Me.chkUseFrameGrabber = New System.Windows.Forms.CheckBox
        Me.chkIncludeAudioStream = New System.Windows.Forms.CheckBox
        Me.chkUseCurrentVideoCompressor = New System.Windows.Forms.CheckBox
        Me.chkIncludeVideoStream = New System.Windows.Forms.CheckBox
        Me.chkUseCurrentAudioCompressor = New System.Windows.Forms.CheckBox
        Me.grbStartStopTime = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.edtStartFrame = New System.Windows.Forms.TextBox
        Me.edtStopFrame = New System.Windows.Forms.TextBox
        Me.edtFrameCount = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.edtDuration = New System.Windows.Forms.TextBox
        Me.edtStartTime = New System.Windows.Forms.TextBox
        Me.edtStopTime = New System.Windows.Forms.TextBox
        Me.btnDuration = New System.Windows.Forms.Button
        Me.edtDestinationVideoClip = New System.Windows.Forms.TextBox
        Me.edtSourceVideoClip = New System.Windows.Forms.TextBox
        Me.btnSourceVideoClip = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.rdgReencodingMethod.SuspendLayout()
        Me.grbReencodingSettings.SuspendLayout()
        Me.grbStartStopTime.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStopReencoding
        '
        Me.btnStopReencoding.BackColor = System.Drawing.SystemColors.Control
        Me.btnStopReencoding.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnStopReencoding.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStopReencoding.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStopReencoding.Location = New System.Drawing.Point(966, 178)
        Me.btnStopReencoding.Name = "btnStopReencoding"
        Me.btnStopReencoding.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnStopReencoding.Size = New System.Drawing.Size(97, 31)
        Me.btnStopReencoding.TabIndex = 23
        Me.btnStopReencoding.Text = "Stop"
        Me.btnStopReencoding.UseVisualStyleBackColor = False
        '
        'btnStartReencoding
        '
        Me.btnStartReencoding.BackColor = System.Drawing.SystemColors.Control
        Me.btnStartReencoding.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnStartReencoding.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartReencoding.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStartReencoding.Location = New System.Drawing.Point(862, 178)
        Me.btnStartReencoding.Name = "btnStartReencoding"
        Me.btnStartReencoding.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnStartReencoding.Size = New System.Drawing.Size(97, 31)
        Me.btnStartReencoding.TabIndex = 22
        Me.btnStartReencoding.Text = "Start"
        Me.btnStartReencoding.UseVisualStyleBackColor = False
        '
        'rdgReencodingMethod
        '
        Me.rdgReencodingMethod.BackColor = System.Drawing.SystemColors.Control
        Me.rdgReencodingMethod.Controls.Add(Me.rdgReencodingMethod2)
        Me.rdgReencodingMethod.Controls.Add(Me.rdgReencodingMethod1)
        Me.rdgReencodingMethod.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgReencodingMethod.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgReencodingMethod.Location = New System.Drawing.Point(610, 166)
        Me.rdgReencodingMethod.Name = "rdgReencodingMethod"
        Me.rdgReencodingMethod.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgReencodingMethod.Size = New System.Drawing.Size(222, 53)
        Me.rdgReencodingMethod.TabIndex = 19
        Me.rdgReencodingMethod.TabStop = False
        Me.rdgReencodingMethod.Text = "reencoding method"
        '
        'rdgReencodingMethod2
        '
        Me.rdgReencodingMethod2.BackColor = System.Drawing.SystemColors.Control
        Me.rdgReencodingMethod2.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgReencodingMethod2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgReencodingMethod2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgReencodingMethod2.Location = New System.Drawing.Point(109, 17)
        Me.rdgReencodingMethod2.Name = "rdgReencodingMethod2"
        Me.rdgReencodingMethod2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgReencodingMethod2.Size = New System.Drawing.Size(106, 31)
        Me.rdgReencodingMethod2.TabIndex = 20
        Me.rdgReencodingMethod2.TabStop = True
        Me.rdgReencodingMethod2.Tag = "1"
        Me.rdgReencodingMethod2.Text = "ASF (WMV)"
        Me.rdgReencodingMethod2.UseVisualStyleBackColor = False
        '
        'rdgReencodingMethod1
        '
        Me.rdgReencodingMethod1.BackColor = System.Drawing.SystemColors.Control
        Me.rdgReencodingMethod1.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgReencodingMethod1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgReencodingMethod1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgReencodingMethod1.Location = New System.Drawing.Point(10, 20)
        Me.rdgReencodingMethod1.Name = "rdgReencodingMethod1"
        Me.rdgReencodingMethod1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgReencodingMethod1.Size = New System.Drawing.Size(116, 21)
        Me.rdgReencodingMethod1.TabIndex = 21
        Me.rdgReencodingMethod1.TabStop = True
        Me.rdgReencodingMethod1.Tag = "0"
        Me.rdgReencodingMethod1.Text = "AVI / MPEG"
        Me.rdgReencodingMethod1.UseVisualStyleBackColor = False
        '
        'grbReencodingSettings
        '
        Me.grbReencodingSettings.BackColor = System.Drawing.SystemColors.Control
        Me.grbReencodingSettings.Controls.Add(Me.chkWMVOutput)
        Me.grbReencodingSettings.Controls.Add(Me.chkUseFrameGrabber)
        Me.grbReencodingSettings.Controls.Add(Me.chkIncludeAudioStream)
        Me.grbReencodingSettings.Controls.Add(Me.chkUseCurrentVideoCompressor)
        Me.grbReencodingSettings.Controls.Add(Me.chkIncludeVideoStream)
        Me.grbReencodingSettings.Controls.Add(Me.chkUseCurrentAudioCompressor)
        Me.grbReencodingSettings.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbReencodingSettings.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbReencodingSettings.Location = New System.Drawing.Point(608, 0)
        Me.grbReencodingSettings.Name = "grbReencodingSettings"
        Me.grbReencodingSettings.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbReencodingSettings.Size = New System.Drawing.Size(482, 162)
        Me.grbReencodingSettings.TabIndex = 12
        Me.grbReencodingSettings.TabStop = False
        Me.grbReencodingSettings.Text = "reencoding settings"
        '
        'chkWMVOutput
        '
        Me.chkWMVOutput.BackColor = System.Drawing.SystemColors.Control
        Me.chkWMVOutput.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkWMVOutput.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWMVOutput.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkWMVOutput.Location = New System.Drawing.Point(13, 23)
        Me.chkWMVOutput.Name = "chkWMVOutput"
        Me.chkWMVOutput.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkWMVOutput.Size = New System.Drawing.Size(431, 21)
        Me.chkWMVOutput.TabIndex = 18
        Me.chkWMVOutput.Text = "WMV output  (Windows Media Video)"
        Me.chkWMVOutput.UseVisualStyleBackColor = False
        '
        'chkUseFrameGrabber
        '
        Me.chkUseFrameGrabber.BackColor = System.Drawing.SystemColors.Control
        Me.chkUseFrameGrabber.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkUseFrameGrabber.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseFrameGrabber.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkUseFrameGrabber.Location = New System.Drawing.Point(13, 127)
        Me.chkUseFrameGrabber.Name = "chkUseFrameGrabber"
        Me.chkUseFrameGrabber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkUseFrameGrabber.Size = New System.Drawing.Size(463, 21)
        Me.chkUseFrameGrabber.TabIndex = 17
        Me.chkUseFrameGrabber.Text = "use the frame grabber (allows text/graphics overlays, video processing...)"
        Me.chkUseFrameGrabber.UseVisualStyleBackColor = False
        '
        'chkIncludeAudioStream
        '
        Me.chkIncludeAudioStream.BackColor = System.Drawing.SystemColors.Control
        Me.chkIncludeAudioStream.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkIncludeAudioStream.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIncludeAudioStream.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkIncludeAudioStream.Location = New System.Drawing.Point(230, 49)
        Me.chkIncludeAudioStream.Name = "chkIncludeAudioStream"
        Me.chkIncludeAudioStream.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkIncludeAudioStream.Size = New System.Drawing.Size(192, 21)
        Me.chkIncludeAudioStream.TabIndex = 16
        Me.chkIncludeAudioStream.Text = "includes the audio stream"
        Me.chkIncludeAudioStream.UseVisualStyleBackColor = False
        '
        'chkUseCurrentVideoCompressor
        '
        Me.chkUseCurrentVideoCompressor.BackColor = System.Drawing.SystemColors.Control
        Me.chkUseCurrentVideoCompressor.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkUseCurrentVideoCompressor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseCurrentVideoCompressor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkUseCurrentVideoCompressor.Location = New System.Drawing.Point(13, 75)
        Me.chkUseCurrentVideoCompressor.Name = "chkUseCurrentVideoCompressor"
        Me.chkUseCurrentVideoCompressor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkUseCurrentVideoCompressor.Size = New System.Drawing.Size(414, 21)
        Me.chkUseCurrentVideoCompressor.TabIndex = 15
        Me.chkUseCurrentVideoCompressor.Text = "use the current video compressor (selected in the ""recording"" tab)"
        Me.chkUseCurrentVideoCompressor.UseVisualStyleBackColor = False
        '
        'chkIncludeVideoStream
        '
        Me.chkIncludeVideoStream.BackColor = System.Drawing.SystemColors.Control
        Me.chkIncludeVideoStream.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkIncludeVideoStream.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIncludeVideoStream.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkIncludeVideoStream.Location = New System.Drawing.Point(13, 49)
        Me.chkIncludeVideoStream.Name = "chkIncludeVideoStream"
        Me.chkIncludeVideoStream.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkIncludeVideoStream.Size = New System.Drawing.Size(183, 21)
        Me.chkIncludeVideoStream.TabIndex = 14
        Me.chkIncludeVideoStream.Text = "includes the video stream"
        Me.chkIncludeVideoStream.UseVisualStyleBackColor = False
        '
        'chkUseCurrentAudioCompressor
        '
        Me.chkUseCurrentAudioCompressor.BackColor = System.Drawing.SystemColors.Control
        Me.chkUseCurrentAudioCompressor.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkUseCurrentAudioCompressor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUseCurrentAudioCompressor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkUseCurrentAudioCompressor.Location = New System.Drawing.Point(13, 101)
        Me.chkUseCurrentAudioCompressor.Name = "chkUseCurrentAudioCompressor"
        Me.chkUseCurrentAudioCompressor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkUseCurrentAudioCompressor.Size = New System.Drawing.Size(414, 21)
        Me.chkUseCurrentAudioCompressor.TabIndex = 13
        Me.chkUseCurrentAudioCompressor.Text = "use the current audio compressor (selected in the ""recording"" tab)"
        Me.chkUseCurrentAudioCompressor.UseVisualStyleBackColor = False
        '
        'grbStartStopTime
        '
        Me.grbStartStopTime.BackColor = System.Drawing.SystemColors.Control
        Me.grbStartStopTime.Controls.Add(Me.Label8)
        Me.grbStartStopTime.Controls.Add(Me.Label6)
        Me.grbStartStopTime.Controls.Add(Me.Label5)
        Me.grbStartStopTime.Controls.Add(Me.edtStartFrame)
        Me.grbStartStopTime.Controls.Add(Me.edtStopFrame)
        Me.grbStartStopTime.Controls.Add(Me.edtFrameCount)
        Me.grbStartStopTime.Controls.Add(Me.Label4)
        Me.grbStartStopTime.Controls.Add(Me.Label3)
        Me.grbStartStopTime.Controls.Add(Me.Label2)
        Me.grbStartStopTime.Controls.Add(Me.Label1)
        Me.grbStartStopTime.Controls.Add(Me.edtDuration)
        Me.grbStartStopTime.Controls.Add(Me.edtStartTime)
        Me.grbStartStopTime.Controls.Add(Me.edtStopTime)
        Me.grbStartStopTime.Controls.Add(Me.btnDuration)
        Me.grbStartStopTime.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbStartStopTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbStartStopTime.Location = New System.Drawing.Point(5, 75)
        Me.grbStartStopTime.Name = "grbStartStopTime"
        Me.grbStartStopTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbStartStopTime.Size = New System.Drawing.Size(596, 144)
        Me.grbStartStopTime.TabIndex = 5
        Me.grbStartStopTime.TabStop = False
        Me.grbStartStopTime.Text = "START / STOP   (optional)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(192, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(412, 16)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Times are expressed in 100ns units, e.g. 3 seconds = 30000000"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(80, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(211, 16)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "STOP position (-1 = end of clip):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(256, 16)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "START position (-1 = beginning of clip):"
        '
        'edtStartFrame
        '
        Me.edtStartFrame.AcceptsReturn = True
        Me.edtStartFrame.BackColor = System.Drawing.SystemColors.Window
        Me.edtStartFrame.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtStartFrame.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtStartFrame.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtStartFrame.Location = New System.Drawing.Point(442, 75)
        Me.edtStartFrame.MaxLength = 0
        Me.edtStartFrame.Name = "edtStartFrame"
        Me.edtStartFrame.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtStartFrame.Size = New System.Drawing.Size(127, 23)
        Me.edtStartFrame.TabIndex = 31
        Me.edtStartFrame.Text = "-1"
        '
        'edtStopFrame
        '
        Me.edtStopFrame.AcceptsReturn = True
        Me.edtStopFrame.BackColor = System.Drawing.SystemColors.Window
        Me.edtStopFrame.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtStopFrame.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtStopFrame.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtStopFrame.Location = New System.Drawing.Point(442, 108)
        Me.edtStopFrame.MaxLength = 0
        Me.edtStopFrame.Name = "edtStopFrame"
        Me.edtStopFrame.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtStopFrame.Size = New System.Drawing.Size(127, 23)
        Me.edtStopFrame.TabIndex = 30
        Me.edtStopFrame.Text = "-1"
        '
        'edtFrameCount
        '
        Me.edtFrameCount.AcceptsReturn = True
        Me.edtFrameCount.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.edtFrameCount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtFrameCount.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtFrameCount.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtFrameCount.Location = New System.Drawing.Point(442, 42)
        Me.edtFrameCount.MaxLength = 0
        Me.edtFrameCount.Name = "edtFrameCount"
        Me.edtFrameCount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtFrameCount.Size = New System.Drawing.Size(127, 23)
        Me.edtFrameCount.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(438, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 16)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "the FRAME NUMBER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(410, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "OR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(260, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "the TIME (in 100ns units)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(203, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "SPECIFY"
        '
        'edtDuration
        '
        Me.edtDuration.AcceptsReturn = True
        Me.edtDuration.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.edtDuration.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtDuration.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtDuration.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtDuration.Location = New System.Drawing.Point(280, 42)
        Me.edtDuration.MaxLength = 0
        Me.edtDuration.Name = "edtDuration"
        Me.edtDuration.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtDuration.Size = New System.Drawing.Size(127, 23)
        Me.edtDuration.TabIndex = 24
        '
        'edtStartTime
        '
        Me.edtStartTime.AcceptsReturn = True
        Me.edtStartTime.BackColor = System.Drawing.SystemColors.Window
        Me.edtStartTime.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtStartTime.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtStartTime.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtStartTime.Location = New System.Drawing.Point(280, 75)
        Me.edtStartTime.MaxLength = 0
        Me.edtStartTime.Name = "edtStartTime"
        Me.edtStartTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtStartTime.Size = New System.Drawing.Size(127, 23)
        Me.edtStartTime.TabIndex = 8
        Me.edtStartTime.Text = "-1"
        '
        'edtStopTime
        '
        Me.edtStopTime.AcceptsReturn = True
        Me.edtStopTime.BackColor = System.Drawing.SystemColors.Window
        Me.edtStopTime.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtStopTime.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtStopTime.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtStopTime.Location = New System.Drawing.Point(280, 108)
        Me.edtStopTime.MaxLength = 0
        Me.edtStopTime.Name = "edtStopTime"
        Me.edtStopTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtStopTime.Size = New System.Drawing.Size(127, 23)
        Me.edtStopTime.TabIndex = 7
        Me.edtStopTime.Text = "-1"
        '
        'btnDuration
        '
        Me.btnDuration.BackColor = System.Drawing.SystemColors.Control
        Me.btnDuration.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDuration.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDuration.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDuration.Location = New System.Drawing.Point(24, 42)
        Me.btnDuration.Name = "btnDuration"
        Me.btnDuration.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDuration.Size = New System.Drawing.Size(248, 24)
        Me.btnDuration.TabIndex = 6
        Me.btnDuration.Text = "source duration and/or frame count?"
        Me.btnDuration.UseVisualStyleBackColor = False
        '
        'edtDestinationVideoClip
        '
        Me.edtDestinationVideoClip.AcceptsReturn = True
        Me.edtDestinationVideoClip.BackColor = System.Drawing.SystemColors.Window
        Me.edtDestinationVideoClip.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtDestinationVideoClip.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtDestinationVideoClip.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtDestinationVideoClip.Location = New System.Drawing.Point(312, 37)
        Me.edtDestinationVideoClip.MaxLength = 0
        Me.edtDestinationVideoClip.Name = "edtDestinationVideoClip"
        Me.edtDestinationVideoClip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtDestinationVideoClip.Size = New System.Drawing.Size(289, 23)
        Me.edtDestinationVideoClip.TabIndex = 2
        '
        'edtSourceVideoClip
        '
        Me.edtSourceVideoClip.AcceptsReturn = True
        Me.edtSourceVideoClip.BackColor = System.Drawing.SystemColors.Window
        Me.edtSourceVideoClip.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtSourceVideoClip.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtSourceVideoClip.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtSourceVideoClip.Location = New System.Drawing.Point(312, 2)
        Me.edtSourceVideoClip.MaxLength = 0
        Me.edtSourceVideoClip.Name = "edtSourceVideoClip"
        Me.edtSourceVideoClip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtSourceVideoClip.Size = New System.Drawing.Size(289, 23)
        Me.edtSourceVideoClip.TabIndex = 1
        '
        'btnSourceVideoClip
        '
        Me.btnSourceVideoClip.BackColor = System.Drawing.SystemColors.Control
        Me.btnSourceVideoClip.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSourceVideoClip.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSourceVideoClip.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSourceVideoClip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSourceVideoClip.ImageIndex = 0
        Me.btnSourceVideoClip.ImageList = Me.ImageList1
        Me.btnSourceVideoClip.Location = New System.Drawing.Point(130, 0)
        Me.btnSourceVideoClip.Name = "btnSourceVideoClip"
        Me.btnSourceVideoClip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSourceVideoClip.Size = New System.Drawing.Size(174, 27)
        Me.btnSourceVideoClip.TabIndex = 0
        Me.btnSourceVideoClip.Text = " source video clip..."
        Me.btnSourceVideoClip.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSourceVideoClip.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Fuchsia
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.SystemColors.Control
        Me.Label33.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label33.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label33.Location = New System.Drawing.Point(121, 33)
        Me.Label33.Name = "Label33"
        Me.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label33.Size = New System.Drawing.Size(206, 16)
        Me.Label33.TabIndex = 4
        Me.Label33.Text = "file name for the new video clip:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.SystemColors.Control
        Me.Label32.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label32.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label32.Location = New System.Drawing.Point(17, 53)
        Me.Label32.Name = "Label32"
        Me.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label32.Size = New System.Drawing.Size(312, 16)
        Me.Label32.TabIndex = 3
        Me.Label32.Text = "(extension will be "".wmv"" if WMV output enabled)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 16)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Reencoding"
        '
        'Reencoding
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1106, 233)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnStopReencoding)
        Me.Controls.Add(Me.btnStartReencoding)
        Me.Controls.Add(Me.rdgReencodingMethod)
        Me.Controls.Add(Me.grbReencodingSettings)
        Me.Controls.Add(Me.grbStartStopTime)
        Me.Controls.Add(Me.edtDestinationVideoClip)
        Me.Controls.Add(Me.edtSourceVideoClip)
        Me.Controls.Add(Me.btnSourceVideoClip)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label32)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Reencoding"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.rdgReencodingMethod.ResumeLayout(False)
        Me.grbReencodingSettings.ResumeLayout(False)
        Me.grbStartStopTime.ResumeLayout(False)
        Me.grbStartStopTime.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Public Sub RefreshControls()
        SetRadioButtonInGroupUsingTag((rdgReencodingMethod), MainForm.DefInstance.VideoGrabber1.Reencoding_Method)
        chkWMVOutput.Checked = MainForm.DefInstance.VideoGrabber1.Reencoding_WMVOutput
        chkIncludeVideoStream.Checked = MainForm.DefInstance.VideoGrabber1.Reencoding_IncludeVideoStream
        chkIncludeAudioStream.Checked = MainForm.DefInstance.VideoGrabber1.Reencoding_IncludeAudioStream
        chkUseFrameGrabber.Checked = MainForm.DefInstance.VideoGrabber1.Reencoding_UseFrameGrabber
        chkUseCurrentVideoCompressor.Checked = MainForm.DefInstance.VideoGrabber1.Reencoding_UseVideoCompressor
        chkUseCurrentAudioCompressor.Checked = MainForm.DefInstance.VideoGrabber1.Reencoding_UseAudioCompressor
        edtStartTime.Text = MainForm.DefInstance.VideoGrabber1.Reencoding_StartTime
        edtStopTime.Text = MainForm.DefInstance.VideoGrabber1.Reencoding_StopTime
    End Sub

    Private Sub btnDuration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDuration.Click
        Dim AVIDuration As Double
        Dim AVIFrameCount As Double

        If MainForm.DefInstance.VideoGrabber1.AVIDuration(edtSourceVideoClip.Text, AVIDuration, AVIFrameCount) Then
            edtDuration.Text = AVIDuration.ToString
            edtFrameCount.Text = AVIFrameCount.ToString
        End If
    End Sub

    Private Sub btnSourceVideoClip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSourceVideoClip.Click

        Dim dlgOpen As OpenFileDialog = New OpenFileDialog

        edtSourceVideoClip.Text = ""
        dlgOpen.Filter = OPEN_MEDIA_FILES
        If dlgOpen.ShowDialog = Windows.Forms.DialogResult.OK Then
            edtSourceVideoClip.Text = dlgOpen.FileName
        End If
    End Sub

    Private Sub btnStartReencoding_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartReencoding.Click

        MainForm.DefInstance.VideoGrabber1.Reencoding_SourceVideoClip = edtSourceVideoClip.Text
        MainForm.DefInstance.VideoGrabber1.Reencoding_NewVideoClip = edtDestinationVideoClip.Text

        MainForm.DefInstance.VideoGrabber1.Reencoding_WMVOutput = chkWMVOutput.Checked
        MainForm.DefInstance.VideoGrabber1.Reencoding_IncludeVideoStream = chkIncludeVideoStream.Checked
        MainForm.DefInstance.VideoGrabber1.Reencoding_IncludeAudioStream = chkIncludeAudioStream.Checked
        MainForm.DefInstance.VideoGrabber1.Reencoding_UseFrameGrabber = chkUseFrameGrabber.Checked
        MainForm.DefInstance.VideoGrabber1.Reencoding_UseVideoCompressor = chkUseCurrentVideoCompressor.Checked
        MainForm.DefInstance.VideoGrabber1.Reencoding_UseAudioCompressor = chkUseCurrentAudioCompressor.Checked

        If rdgReencodingMethod1.Checked Then
            MainForm.DefInstance.VideoGrabber1.Reencoding_Method = VidGrab.TRecordingMethod.rm_AVI
        End If

        If rdgReencodingMethod2.Checked Then
            MainForm.DefInstance.VideoGrabber1.Reencoding_Method = VidGrab.TRecordingMethod.rm_ASF
        End If

        If IsNumeric(edtStartTime.Text) Then
            MainForm.DefInstance.VideoGrabber1.Reencoding_StartTime = edtStartTime.Text
        End If

        If IsNumeric(edtStopTime.Text) Then
            MainForm.DefInstance.VideoGrabber1.Reencoding_StopTime = edtStopTime.Text
        End If

        If IsNumeric(edtStartFrame.Text) Then
            MainForm.DefInstance.VideoGrabber1.Reencoding_StartFrame = edtStartFrame.Text
        End If

        If IsNumeric(edtStopFrame.Text) Then
            MainForm.DefInstance.VideoGrabber1.Reencoding_StopFrame = edtStopFrame.Text
        End If

        MainForm.DefInstance.VideoGrabber1.StartReencoding()
    End Sub

    Private Sub btnStopReencoding_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopReencoding.Click
        MainForm.DefInstance.VideoGrabber1.Stop()
    End Sub

    Private Sub Reencoding_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Visible Then
            RefreshControls()
        End If
    End Sub

End Class
