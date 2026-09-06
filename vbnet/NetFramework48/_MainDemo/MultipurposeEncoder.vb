Option Strict Off
Option Explicit On
Friend Class MultipurposeEncoder
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

    Private Const ENCODER_RECORDING_ID As Int32 = 0 ' always use 0 For Default encoder (used When invoking StartRecording())

    Private WithEvents tbcMPE As TabControl
    Private WithEvents tbpDatasteadEncoder As TabPage
    Private WithEvents label10 As Label
    Private WithEvents tbxExtraParameters As TextBox
    Private WithEvents grbMPEAudio As GroupBox
    Private WithEvents label12 As Label
    Private WithEvents label11 As Label
    Private WithEvents edtDatasteadEncoder_Audio_BitRate_kb As TextBox
    Private WithEvents edtDatasteadEncoder_Audio_SamplesPerSecond As TextBox
    Private WithEvents grbMPEVideo As GroupBox
    Private WithEvents label9 As Label
    Private WithEvents label8 As Label
    Private WithEvents label7 As Label
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents rgbMPERateControl As GroupBox
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents edtDatasteadEncoder_Video_rc_BufferSize_kb As TextBox
    Private WithEvents edtDatasteadEncoder_Video_rc_MaxBitRate_kb As TextBox
    Private WithEvents edtDatasteadEncoder_Video_rc_MinBitRate_kb As TextBox
    Private WithEvents cmbGPUEncoder As ComboBox
    Private WithEvents edtDatasteadEncoder_Video_ThreadCount As TextBox
    Private WithEvents edtDatasteadEncoder_Video_MaxBframes As TextBox
    Private WithEvents edtDatasteadEncoder_Video_IDRInterval As TextBox
    Private WithEvents edtDatasteadEncoder_Video_Bitrate_kb As TextBox
    Private WithEvents edtDatasteadEncoder_CodecName As TextBox
    Private WithEvents tbxDatasteadEncoderInfo As TextBox
    Private WithEvents tbpMPECommandLine As TabPage
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents btnStopMPEReencoding As Button
    Private WithEvents btnStartMPEReencoding As Button
    Private WithEvents edtMPEReencoding As TextBox
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents edtMPEStreaming As TextBox
    Private WithEvents chkMPEStreaming As CheckBox
    Private WithEvents grbMPERecord As GroupBox
    Private WithEvents edtMPERecording As TextBox
    Private WithEvents chkMPERecording As CheckBox

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MultipurposeEncoder))
        Me.tbcMPE = New System.Windows.Forms.TabControl()
        Me.tbpDatasteadEncoder = New System.Windows.Forms.TabPage()
        Me.label10 = New System.Windows.Forms.Label()
        Me.tbxExtraParameters = New System.Windows.Forms.TextBox()
        Me.grbMPEAudio = New System.Windows.Forms.GroupBox()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.edtDatasteadEncoder_Audio_BitRate_kb = New System.Windows.Forms.TextBox()
        Me.edtDatasteadEncoder_Audio_SamplesPerSecond = New System.Windows.Forms.TextBox()
        Me.grbMPEVideo = New System.Windows.Forms.GroupBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.rgbMPERateControl = New System.Windows.Forms.GroupBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.edtDatasteadEncoder_Video_rc_BufferSize_kb = New System.Windows.Forms.TextBox()
        Me.edtDatasteadEncoder_Video_rc_MaxBitRate_kb = New System.Windows.Forms.TextBox()
        Me.edtDatasteadEncoder_Video_rc_MinBitRate_kb = New System.Windows.Forms.TextBox()
        Me.cmbGPUEncoder = New System.Windows.Forms.ComboBox()
        Me.edtDatasteadEncoder_Video_ThreadCount = New System.Windows.Forms.TextBox()
        Me.edtDatasteadEncoder_Video_MaxBframes = New System.Windows.Forms.TextBox()
        Me.edtDatasteadEncoder_Video_IDRInterval = New System.Windows.Forms.TextBox()
        Me.edtDatasteadEncoder_Video_Bitrate_kb = New System.Windows.Forms.TextBox()
        Me.edtDatasteadEncoder_CodecName = New System.Windows.Forms.TextBox()
        Me.tbxDatasteadEncoderInfo = New System.Windows.Forms.TextBox()
        Me.tbpMPECommandLine = New System.Windows.Forms.TabPage()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnStopMPEReencoding = New System.Windows.Forms.Button()
        Me.btnStartMPEReencoding = New System.Windows.Forms.Button()
        Me.edtMPEReencoding = New System.Windows.Forms.TextBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.edtMPEStreaming = New System.Windows.Forms.TextBox()
        Me.chkMPEStreaming = New System.Windows.Forms.CheckBox()
        Me.grbMPERecord = New System.Windows.Forms.GroupBox()
        Me.edtMPERecording = New System.Windows.Forms.TextBox()
        Me.chkMPERecording = New System.Windows.Forms.CheckBox()
        Me.tbcMPE.SuspendLayout()
        Me.tbpDatasteadEncoder.SuspendLayout()
        Me.grbMPEAudio.SuspendLayout()
        Me.grbMPEVideo.SuspendLayout()
        Me.rgbMPERateControl.SuspendLayout()
        Me.tbpMPECommandLine.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.grbMPERecord.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcMPE
        '
        Me.tbcMPE.Controls.Add(Me.tbpDatasteadEncoder)
        Me.tbcMPE.Controls.Add(Me.tbpMPECommandLine)
        Me.tbcMPE.Location = New System.Drawing.Point(1, 12)
        Me.tbcMPE.Name = "tbcMPE"
        Me.tbcMPE.SelectedIndex = 0
        Me.tbcMPE.Size = New System.Drawing.Size(1402, 240)
        Me.tbcMPE.TabIndex = 1
        '
        'tbpDatasteadEncoder
        '
        Me.tbpDatasteadEncoder.Controls.Add(Me.label10)
        Me.tbpDatasteadEncoder.Controls.Add(Me.tbxExtraParameters)
        Me.tbpDatasteadEncoder.Controls.Add(Me.grbMPEAudio)
        Me.tbpDatasteadEncoder.Controls.Add(Me.grbMPEVideo)
        Me.tbpDatasteadEncoder.Controls.Add(Me.tbxDatasteadEncoderInfo)
        Me.tbpDatasteadEncoder.Location = New System.Drawing.Point(4, 25)
        Me.tbpDatasteadEncoder.Name = "tbpDatasteadEncoder"
        Me.tbpDatasteadEncoder.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpDatasteadEncoder.Size = New System.Drawing.Size(1394, 211)
        Me.tbpDatasteadEncoder.TabIndex = 0
        Me.tbpDatasteadEncoder.Text = "Datastead Encoder"
        Me.tbpDatasteadEncoder.UseVisualStyleBackColor = True
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(931, 99)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(120, 17)
        Me.label10.TabIndex = 5
        Me.label10.Text = "Extra parameters:"
        '
        'tbxExtraParameters
        '
        Me.tbxExtraParameters.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxExtraParameters.Location = New System.Drawing.Point(931, 119)
        Me.tbxExtraParameters.Multiline = True
        Me.tbxExtraParameters.Name = "tbxExtraParameters"
        Me.tbxExtraParameters.Size = New System.Drawing.Size(294, 74)
        Me.tbxExtraParameters.TabIndex = 4
        '
        'grbMPEAudio
        '
        Me.grbMPEAudio.Controls.Add(Me.label12)
        Me.grbMPEAudio.Controls.Add(Me.label11)
        Me.grbMPEAudio.Controls.Add(Me.edtDatasteadEncoder_Audio_BitRate_kb)
        Me.grbMPEAudio.Controls.Add(Me.edtDatasteadEncoder_Audio_SamplesPerSecond)
        Me.grbMPEAudio.Location = New System.Drawing.Point(931, 0)
        Me.grbMPEAudio.Name = "grbMPEAudio"
        Me.grbMPEAudio.Size = New System.Drawing.Size(294, 96)
        Me.grbMPEAudio.TabIndex = 3
        Me.grbMPEAudio.TabStop = False
        Me.grbMPEAudio.Text = "Audio: "
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(69, 49)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(177, 17)
        Me.label12.TabIndex = 5
        Me.label12.Text = "Bit rate (kbps) e.g. 64, 128"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(69, 21)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(225, 17)
        Me.label11.TabIndex = 4
        Me.label11.Text = "samples per sec (44100, 22050...)"
        '
        'edtDatasteadEncoder_Audio_BitRate_kb
        '
        Me.edtDatasteadEncoder_Audio_BitRate_kb.Location = New System.Drawing.Point(6, 49)
        Me.edtDatasteadEncoder_Audio_BitRate_kb.Name = "edtDatasteadEncoder_Audio_BitRate_kb"
        Me.edtDatasteadEncoder_Audio_BitRate_kb.Size = New System.Drawing.Size(57, 22)
        Me.edtDatasteadEncoder_Audio_BitRate_kb.TabIndex = 3
        '
        'edtDatasteadEncoder_Audio_SamplesPerSecond
        '
        Me.edtDatasteadEncoder_Audio_SamplesPerSecond.Location = New System.Drawing.Point(6, 21)
        Me.edtDatasteadEncoder_Audio_SamplesPerSecond.Name = "edtDatasteadEncoder_Audio_SamplesPerSecond"
        Me.edtDatasteadEncoder_Audio_SamplesPerSecond.Size = New System.Drawing.Size(57, 22)
        Me.edtDatasteadEncoder_Audio_SamplesPerSecond.TabIndex = 2
        '
        'grbMPEVideo
        '
        Me.grbMPEVideo.Controls.Add(Me.label9)
        Me.grbMPEVideo.Controls.Add(Me.label8)
        Me.grbMPEVideo.Controls.Add(Me.label7)
        Me.grbMPEVideo.Controls.Add(Me.label6)
        Me.grbMPEVideo.Controls.Add(Me.label5)
        Me.grbMPEVideo.Controls.Add(Me.label4)
        Me.grbMPEVideo.Controls.Add(Me.rgbMPERateControl)
        Me.grbMPEVideo.Controls.Add(Me.cmbGPUEncoder)
        Me.grbMPEVideo.Controls.Add(Me.edtDatasteadEncoder_Video_ThreadCount)
        Me.grbMPEVideo.Controls.Add(Me.edtDatasteadEncoder_Video_MaxBframes)
        Me.grbMPEVideo.Controls.Add(Me.edtDatasteadEncoder_Video_IDRInterval)
        Me.grbMPEVideo.Controls.Add(Me.edtDatasteadEncoder_Video_Bitrate_kb)
        Me.grbMPEVideo.Controls.Add(Me.edtDatasteadEncoder_CodecName)
        Me.grbMPEVideo.Location = New System.Drawing.Point(246, 0)
        Me.grbMPEVideo.Name = "grbMPEVideo"
        Me.grbMPEVideo.Size = New System.Drawing.Size(679, 200)
        Me.grbMPEVideo.TabIndex = 1
        Me.grbMPEVideo.TabStop = False
        Me.grbMPEVideo.Text = "Video: "
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(168, 21)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(401, 17)
        Me.label9.TabIndex = 12
        Me.label9.Text = "Codec name, e.g. ""h264"", ""hevc"", ""mpeg4"" or empty for default"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(168, 161)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(97, 17)
        Me.label8.TabIndex = 11
        Me.label8.Text = "Bit rate (kbps)"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(168, 133)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(320, 17)
        Me.label7.TabIndex = 10
        Me.label7.Text = "Thread count, 1 by default (4 by default for h264)"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(168, 105)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(176, 17)
        Me.label6.TabIndex = 9
        Me.label6.Text = "Max B-frames, 0 by default"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(168, 77)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(178, 17)
        Me.label5.TabIndex = 8
        Me.label5.Text = "IDR Interval (GOP), e.g. 30"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(168, 49)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(97, 17)
        Me.label4.TabIndex = 7
        Me.label4.Text = "Bit rate (kbps)"
        '
        'rgbMPERateControl
        '
        Me.rgbMPERateControl.Controls.Add(Me.label3)
        Me.rgbMPERateControl.Controls.Add(Me.label2)
        Me.rgbMPERateControl.Controls.Add(Me.label1)
        Me.rgbMPERateControl.Controls.Add(Me.edtDatasteadEncoder_Video_rc_BufferSize_kb)
        Me.rgbMPERateControl.Controls.Add(Me.edtDatasteadEncoder_Video_rc_MaxBitRate_kb)
        Me.rgbMPERateControl.Controls.Add(Me.edtDatasteadEncoder_Video_rc_MinBitRate_kb)
        Me.rgbMPERateControl.Location = New System.Drawing.Point(488, 77)
        Me.rgbMPERateControl.Name = "rgbMPERateControl"
        Me.rgbMPERateControl.Size = New System.Drawing.Size(191, 112)
        Me.rgbMPERateControl.TabIndex = 6
        Me.rgbMPERateControl.TabStop = False
        Me.rgbMPERateControl.Text = "rate control: (kbps)"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(91, 79)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(79, 17)
        Me.label3.TabIndex = 8
        Me.label3.Text = "buffer size*"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(91, 53)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(81, 17)
        Me.label2.TabIndex = 7
        Me.label2.Text = "max bit rate"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(91, 23)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(78, 17)
        Me.label1.TabIndex = 6
        Me.label1.Text = "min bit rate"
        '
        'edtDatasteadEncoder_Video_rc_BufferSize_kb
        '
        Me.edtDatasteadEncoder_Video_rc_BufferSize_kb.Location = New System.Drawing.Point(6, 76)
        Me.edtDatasteadEncoder_Video_rc_BufferSize_kb.Name = "edtDatasteadEncoder_Video_rc_BufferSize_kb"
        Me.edtDatasteadEncoder_Video_rc_BufferSize_kb.Size = New System.Drawing.Size(67, 22)
        Me.edtDatasteadEncoder_Video_rc_BufferSize_kb.TabIndex = 5
        '
        'edtDatasteadEncoder_Video_rc_MaxBitRate_kb
        '
        Me.edtDatasteadEncoder_Video_rc_MaxBitRate_kb.Location = New System.Drawing.Point(6, 48)
        Me.edtDatasteadEncoder_Video_rc_MaxBitRate_kb.Name = "edtDatasteadEncoder_Video_rc_MaxBitRate_kb"
        Me.edtDatasteadEncoder_Video_rc_MaxBitRate_kb.Size = New System.Drawing.Size(67, 22)
        Me.edtDatasteadEncoder_Video_rc_MaxBitRate_kb.TabIndex = 4
        '
        'edtDatasteadEncoder_Video_rc_MinBitRate_kb
        '
        Me.edtDatasteadEncoder_Video_rc_MinBitRate_kb.Location = New System.Drawing.Point(6, 20)
        Me.edtDatasteadEncoder_Video_rc_MinBitRate_kb.Name = "edtDatasteadEncoder_Video_rc_MinBitRate_kb"
        Me.edtDatasteadEncoder_Video_rc_MinBitRate_kb.Size = New System.Drawing.Size(67, 22)
        Me.edtDatasteadEncoder_Video_rc_MinBitRate_kb.TabIndex = 3
        '
        'cmbGPUEncoder
        '
        Me.cmbGPUEncoder.FormattingEnabled = True
        Me.cmbGPUEncoder.Items.AddRange(New Object() {"None", "Auto", "Intel_QSV", "NVidia_NVENC", "AMD_AMF"})
        Me.cmbGPUEncoder.Location = New System.Drawing.Point(59, 158)
        Me.cmbGPUEncoder.Name = "cmbGPUEncoder"
        Me.cmbGPUEncoder.Size = New System.Drawing.Size(103, 24)
        Me.cmbGPUEncoder.TabIndex = 5
        '
        'edtDatasteadEncoder_Video_ThreadCount
        '
        Me.edtDatasteadEncoder_Video_ThreadCount.Location = New System.Drawing.Point(59, 130)
        Me.edtDatasteadEncoder_Video_ThreadCount.Name = "edtDatasteadEncoder_Video_ThreadCount"
        Me.edtDatasteadEncoder_Video_ThreadCount.Size = New System.Drawing.Size(103, 22)
        Me.edtDatasteadEncoder_Video_ThreadCount.TabIndex = 4
        '
        'edtDatasteadEncoder_Video_MaxBframes
        '
        Me.edtDatasteadEncoder_Video_MaxBframes.Location = New System.Drawing.Point(59, 102)
        Me.edtDatasteadEncoder_Video_MaxBframes.Name = "edtDatasteadEncoder_Video_MaxBframes"
        Me.edtDatasteadEncoder_Video_MaxBframes.Size = New System.Drawing.Size(103, 22)
        Me.edtDatasteadEncoder_Video_MaxBframes.TabIndex = 3
        '
        'edtDatasteadEncoder_Video_IDRInterval
        '
        Me.edtDatasteadEncoder_Video_IDRInterval.Location = New System.Drawing.Point(59, 74)
        Me.edtDatasteadEncoder_Video_IDRInterval.Name = "edtDatasteadEncoder_Video_IDRInterval"
        Me.edtDatasteadEncoder_Video_IDRInterval.Size = New System.Drawing.Size(103, 22)
        Me.edtDatasteadEncoder_Video_IDRInterval.TabIndex = 2
        '
        'edtDatasteadEncoder_Video_Bitrate_kb
        '
        Me.edtDatasteadEncoder_Video_Bitrate_kb.Location = New System.Drawing.Point(59, 46)
        Me.edtDatasteadEncoder_Video_Bitrate_kb.Name = "edtDatasteadEncoder_Video_Bitrate_kb"
        Me.edtDatasteadEncoder_Video_Bitrate_kb.Size = New System.Drawing.Size(103, 22)
        Me.edtDatasteadEncoder_Video_Bitrate_kb.TabIndex = 1
        '
        'edtDatasteadEncoder_CodecName
        '
        Me.edtDatasteadEncoder_CodecName.Location = New System.Drawing.Point(59, 18)
        Me.edtDatasteadEncoder_CodecName.Name = "edtDatasteadEncoder_CodecName"
        Me.edtDatasteadEncoder_CodecName.Size = New System.Drawing.Size(103, 22)
        Me.edtDatasteadEncoder_CodecName.TabIndex = 0
        '
        'tbxDatasteadEncoderInfo
        '
        Me.tbxDatasteadEncoderInfo.Location = New System.Drawing.Point(5, 0)
        Me.tbxDatasteadEncoderInfo.Multiline = True
        Me.tbxDatasteadEncoderInfo.Name = "tbxDatasteadEncoderInfo"
        Me.tbxDatasteadEncoderInfo.Size = New System.Drawing.Size(235, 200)
        Me.tbxDatasteadEncoderInfo.TabIndex = 0
        '
        'tbpMPECommandLine
        '
        Me.tbpMPECommandLine.Controls.Add(Me.groupBox2)
        Me.tbpMPECommandLine.Controls.Add(Me.groupBox1)
        Me.tbpMPECommandLine.Controls.Add(Me.grbMPERecord)
        Me.tbpMPECommandLine.Location = New System.Drawing.Point(4, 25)
        Me.tbpMPECommandLine.Name = "tbpMPECommandLine"
        Me.tbpMPECommandLine.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpMPECommandLine.Size = New System.Drawing.Size(1394, 211)
        Me.tbpMPECommandLine.TabIndex = 1
        Me.tbpMPECommandLine.Text = "Command line encoder"
        Me.tbpMPECommandLine.UseVisualStyleBackColor = True
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.btnStopMPEReencoding)
        Me.groupBox2.Controls.Add(Me.btnStartMPEReencoding)
        Me.groupBox2.Controls.Add(Me.edtMPEReencoding)
        Me.groupBox2.Location = New System.Drawing.Point(6, 131)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(1225, 55)
        Me.groupBox2.TabIndex = 5
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Direct transcoding: replace these sample file names by the real files to process," &
    " specify more FFmpeg settings if needed, then click ""Start MPE reencoding"""
        '
        'btnStopMPEReencoding
        '
        Me.btnStopMPEReencoding.Location = New System.Drawing.Point(1168, 20)
        Me.btnStopMPEReencoding.Name = "btnStopMPEReencoding"
        Me.btnStopMPEReencoding.Size = New System.Drawing.Size(50, 27)
        Me.btnStopMPEReencoding.TabIndex = 3
        Me.btnStopMPEReencoding.Text = "Stop"
        Me.btnStopMPEReencoding.UseVisualStyleBackColor = True
        '
        'btnStartMPEReencoding
        '
        Me.btnStartMPEReencoding.Location = New System.Drawing.Point(1012, 20)
        Me.btnStartMPEReencoding.Name = "btnStartMPEReencoding"
        Me.btnStartMPEReencoding.Size = New System.Drawing.Size(151, 27)
        Me.btnStartMPEReencoding.TabIndex = 2
        Me.btnStartMPEReencoding.Text = "Start MPE reencoding"
        Me.btnStartMPEReencoding.UseVisualStyleBackColor = True
        '
        'edtMPEReencoding
        '
        Me.edtMPEReencoding.Location = New System.Drawing.Point(7, 22)
        Me.edtMPEReencoding.Name = "edtMPEReencoding"
        Me.edtMPEReencoding.Size = New System.Drawing.Size(997, 22)
        Me.edtMPEReencoding.TabIndex = 1
        Me.edtMPEReencoding.Text = "ffmpegLGPL.exe -i ""c:\folder\ClipToReencode.avi"" -f mp4 ""c:\folder\ClipReencodedT" &
    "oMP4.mp4"""
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.edtMPEStreaming)
        Me.groupBox1.Controls.Add(Me.chkMPEStreaming)
        Me.groupBox1.Location = New System.Drawing.Point(6, 68)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(1225, 56)
        Me.groupBox1.TabIndex = 4
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "STREAMING: enable it then start the preview in the ""video source"" tab or recordin" &
    "g in the ""Recording"" tab        (note: it supersedes ALL the streaming settings " &
    "of the ""WM Streaming"" tab)"
        '
        'edtMPEStreaming
        '
        Me.edtMPEStreaming.Location = New System.Drawing.Point(84, 23)
        Me.edtMPEStreaming.Name = "edtMPEStreaming"
        Me.edtMPEStreaming.Size = New System.Drawing.Size(1134, 22)
        Me.edtMPEStreaming.TabIndex = 1
        Me.edtMPEStreaming.Text = resources.GetString("edtMPEStreaming.Text")
        '
        'chkMPEStreaming
        '
        Me.chkMPEStreaming.AutoSize = True
        Me.chkMPEStreaming.Location = New System.Drawing.Point(14, 23)
        Me.chkMPEStreaming.Name = "chkMPEStreaming"
        Me.chkMPEStreaming.Size = New System.Drawing.Size(73, 21)
        Me.chkMPEStreaming.TabIndex = 0
        Me.chkMPEStreaming.Text = "enable"
        Me.chkMPEStreaming.UseVisualStyleBackColor = True
        '
        'grbMPERecord
        '
        Me.grbMPERecord.Controls.Add(Me.edtMPERecording)
        Me.grbMPERecord.Controls.Add(Me.chkMPERecording)
        Me.grbMPERecord.Location = New System.Drawing.Point(6, 6)
        Me.grbMPERecord.Name = "grbMPERecord"
        Me.grbMPERecord.Size = New System.Drawing.Size(1225, 55)
        Me.grbMPERecord.TabIndex = 3
        Me.grbMPERecord.TabStop = False
        Me.grbMPERecord.Text = "RECORDING: enable it then start the recording in the ""Recording"" tab         (not" &
    "e: it supersedes ALL the compression and codec settings of the ""Recording"" tab)"
        '
        'edtMPERecording
        '
        Me.edtMPERecording.Location = New System.Drawing.Point(84, 23)
        Me.edtMPERecording.Name = "edtMPERecording"
        Me.edtMPERecording.Size = New System.Drawing.Size(1134, 22)
        Me.edtMPERecording.TabIndex = 1
        Me.edtMPERecording.Text = "ffmpegLGPL.exe -re -i %PIPE% -c:v h264 -threads 8 -profile:v baseline -loopfilter" &
    " 0 -b:v 10M -an -f mp4 %FILENAME%"
        '
        'chkMPERecording
        '
        Me.chkMPERecording.AutoSize = True
        Me.chkMPERecording.Location = New System.Drawing.Point(14, 23)
        Me.chkMPERecording.Name = "chkMPERecording"
        Me.chkMPERecording.Size = New System.Drawing.Size(73, 21)
        Me.chkMPERecording.TabIndex = 0
        Me.chkMPERecording.Text = "enable"
        Me.chkMPERecording.UseVisualStyleBackColor = True
        '
        'MultipurposeEncoder
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(1491, 359)
        Me.ControlBox = False
        Me.Controls.Add(Me.tbcMPE)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MultipurposeEncoder"
        Me.ShowInTaskbar = False
        Me.tbcMPE.ResumeLayout(False)
        Me.tbpDatasteadEncoder.ResumeLayout(False)
        Me.tbpDatasteadEncoder.PerformLayout()
        Me.grbMPEAudio.ResumeLayout(False)
        Me.grbMPEAudio.PerformLayout()
        Me.grbMPEVideo.ResumeLayout(False)
        Me.grbMPEVideo.PerformLayout()
        Me.rgbMPERateControl.ResumeLayout(False)
        Me.rgbMPERateControl.PerformLayout()
        Me.tbpMPECommandLine.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.grbMPERecord.ResumeLayout(False)
        Me.grbMPERecord.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub RefreshControls()
        tbxDatasteadEncoderInfo.Text = "To use this mode, in the ""recording"" tab, select:" & Environment.NewLine & "- ""Datastead Multipurpose Encoder"" as compressor" & Environment.NewLine & "- CompressionMode = cm_CompressOnTheFly" & Environment.NewLine & "" & Environment.NewLine & "The format (e.g. mp4, avi, flv, etc...) is determined by the extension of the RecordingFileName, or by the RecordingMethod property if generated automatically."
    End Sub

    Private Sub MultipurposeEncoder_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Visible Then
            RefreshControls()
        End If
    End Sub

    Private Sub edtMPERecording_TextChanged(sender As Object, e As EventArgs) Handles edtMPERecording.TextChanged
        MainForm.DefInstance.VideoGrabber1.SetMultipurposeEncoderSettings(VidGrab.TMultipurposeEncoderInstance.mpe_Recording, edtMPERecording.Text)
    End Sub

    Private Sub edtMPEStreaming_TextChanged(sender As Object, e As EventArgs) Handles edtMPEStreaming.TextChanged
        MainForm.DefInstance.VideoGrabber1.SetMultipurposeEncoderSettings(VidGrab.TMultipurposeEncoderInstance.mpe_Streaming, edtMPEStreaming.Text)
    End Sub

    Private Sub edtMPEReencoding_TextChanged(sender As Object, e As EventArgs) Handles edtMPEReencoding.TextChanged
        MainForm.DefInstance.VideoGrabber1.SetMultipurposeEncoderSettings(VidGrab.TMultipurposeEncoderInstance.mpe_Reencoding, edtMPEReencoding.Text)
    End Sub

    Private Sub chkMPERecording_CheckedChanged(sender As Object, e As EventArgs) Handles chkMPERecording.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.EnableMultipurposeEncoder(VidGrab.TMultipurposeEncoderInstance.mpe_Recording, chkMPERecording.Checked)
        edtMPERecording_TextChanged(edtMPERecording, e) ' to apply the eventual default recording settings of the demo, if unchanged
    End Sub


    Private Sub chkMPEStreaming_CheckedChanged(sender As Object, e As EventArgs) Handles chkMPEStreaming.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.EnableMultipurposeEncoder(VidGrab.TMultipurposeEncoderInstance.mpe_Streaming, chkMPEStreaming.Checked)
        edtMPEStreaming_TextChanged(edtMPEStreaming, e) ' to apply the eventual default Streaming settings of the demo, if unchanged
    End Sub

    Private Sub btnStartMPEReencoding_Click(sender As Object, e As EventArgs) Handles btnStartMPEReencoding.Click
        MainForm.DefInstance.VideoGrabber1.EnableMultipurposeEncoder(VidGrab.TMultipurposeEncoderInstance.mpe_Reencoding, True)
        edtMPEStreaming_TextChanged(edtMPEReencoding, e) ' to apply the eventual default Reencoding settings of the demo, if unchanged
        MainForm.DefInstance.VideoGrabber1.StartReencoding()
    End Sub

    Private Sub btnStopMPEReencoding_Click(sender As Object, e As EventArgs) Handles btnStopMPEReencoding.Click
        MainForm.DefInstance.VideoGrabber1.Stop()
    End Sub

    Private Sub edtDatasteadEncoder_CodecName_TextChanged(sender As Object, e As EventArgs) Handles edtDatasteadEncoder_CodecName.TextChanged
        MainForm.DefInstance.VideoGrabber1.Encoder_SetStr(ENCODER_RECORDING_ID, VidGrab.TEncoder_str.Enc_Video_Codec, edtDatasteadEncoder_CodecName.Text)
    End Sub

    Private Sub edtDatasteadEncoder_Video_Bitrate_kb_TextChanged(sender As Object, e As EventArgs) Handles edtDatasteadEncoder_Video_Bitrate_kb.TextChanged
        If IsNumeric(edtDatasteadEncoder_Video_Bitrate_kb.Text) Then
            MainForm.DefInstance.VideoGrabber1.Encoder_SetInt(ENCODER_RECORDING_ID, VidGrab.TEncoder_int.Enc_Video_BitRate_kb, Convert.ToInt32(edtDatasteadEncoder_Video_Bitrate_kb.Text))
        End If
    End Sub

    Private Sub edtDatasteadEncoder_Video_IDRInterval_TextChanged(sender As Object, e As EventArgs) Handles edtDatasteadEncoder_Video_IDRInterval.TextChanged
        If IsNumeric(edtDatasteadEncoder_Video_IDRInterval.Text) Then
            MainForm.DefInstance.VideoGrabber1.Encoder_SetInt(ENCODER_RECORDING_ID, VidGrab.TEncoder_int.Enc_Video_IDR_Interval, Convert.ToInt32(edtDatasteadEncoder_Video_IDRInterval.Text))
        End If
    End Sub

    Private Sub edtDatasteadEncoder_Video_MaxBframes_TextChanged(sender As Object, e As EventArgs) Handles edtDatasteadEncoder_Video_MaxBframes.TextChanged
        If IsNumeric(edtDatasteadEncoder_Video_MaxBframes.Text) Then
            MainForm.DefInstance.VideoGrabber1.Encoder_SetInt(ENCODER_RECORDING_ID, VidGrab.TEncoder_int.Enc_Video_Max_BFrames, Convert.ToInt32(edtDatasteadEncoder_Video_MaxBframes.Text))
        End If
    End Sub

    Private Sub edtDatasteadEncoder_Video_ThreadCount_TextChanged(sender As Object, e As EventArgs) Handles edtDatasteadEncoder_Video_ThreadCount.TextChanged
        If IsNumeric(edtDatasteadEncoder_Video_ThreadCount.Text) Then
            MainForm.DefInstance.VideoGrabber1.Encoder_SetInt(ENCODER_RECORDING_ID, VidGrab.TEncoder_int.Enc_Video_Thread_Count, Convert.ToInt32(edtDatasteadEncoder_Video_ThreadCount.Text))
        End If
    End Sub

    Private Sub cmbGPUEncoder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGPUEncoder.SelectedIndexChanged
        MainForm.DefInstance.VideoGrabber1.Encoder_SetInt(ENCODER_RECORDING_ID, VidGrab.TEncoder_int.Enc_Video_GPU_Encoder, cmbGPUEncoder.SelectedIndex)
    End Sub

    Private Sub edtDatasteadEncoder_Video_rc_MinBitRate_kb_TextChanged(sender As Object, e As EventArgs) Handles edtDatasteadEncoder_Video_rc_MinBitRate_kb.TextChanged
        If IsNumeric(edtDatasteadEncoder_Video_rc_MinBitRate_kb.Text) Then
            MainForm.DefInstance.VideoGrabber1.Encoder_SetInt(ENCODER_RECORDING_ID, VidGrab.TEncoder_int.Enc_Video_rc_MinBitRate_kb, Convert.ToInt32(edtDatasteadEncoder_Video_rc_MinBitRate_kb.Text))
        End If
    End Sub

    Private Sub edtDatasteadEncoder_Video_rc_MaxBitRate_kb_TextChanged(sender As Object, e As EventArgs) Handles edtDatasteadEncoder_Video_rc_MaxBitRate_kb.TextChanged
        If IsNumeric(edtDatasteadEncoder_Video_rc_MaxBitRate_kb.Text) Then
            MainForm.DefInstance.VideoGrabber1.Encoder_SetInt(ENCODER_RECORDING_ID, VidGrab.TEncoder_int.Enc_Video_rc_MaxBitRate_kb, Convert.ToInt32(edtDatasteadEncoder_Video_rc_MaxBitRate_kb.Text))
        End If
    End Sub

    Private Sub edtDatasteadEncoder_Video_rc_BufferSize_kb_TextChanged(sender As Object, e As EventArgs) Handles edtDatasteadEncoder_Video_rc_BufferSize_kb.TextChanged
        If IsNumeric(edtDatasteadEncoder_Video_rc_BufferSize_kb.Text) Then
            MainForm.DefInstance.VideoGrabber1.Encoder_SetInt(ENCODER_RECORDING_ID, VidGrab.TEncoder_int.Enc_Video_rc_BufferSize_kb, Convert.ToInt32(edtDatasteadEncoder_Video_rc_BufferSize_kb.Text))
        End If
    End Sub

    Private Sub edtDatasteadEncoder_Audio_SamplesPerSecond_TextChanged(sender As Object, e As EventArgs) Handles edtDatasteadEncoder_Audio_SamplesPerSecond.TextChanged
        If IsNumeric(edtDatasteadEncoder_Audio_SamplesPerSecond.Text) Then
            MainForm.DefInstance.VideoGrabber1.Encoder_SetInt(ENCODER_RECORDING_ID, VidGrab.TEncoder_int.Enc_Audio_SamplesPerSec, Convert.ToInt32(edtDatasteadEncoder_Audio_SamplesPerSecond.Text))
        End If
    End Sub

    Private Sub edtDatasteadEncoder_Audio_BitRate_kb_TextChanged(sender As Object, e As EventArgs) Handles edtDatasteadEncoder_Audio_BitRate_kb.TextChanged
        If IsNumeric(edtDatasteadEncoder_Audio_BitRate_kb.Text) Then
            MainForm.DefInstance.VideoGrabber1.Encoder_SetInt(ENCODER_RECORDING_ID, VidGrab.TEncoder_int.Enc_Audio_BitRate_kb, Convert.ToInt32(edtDatasteadEncoder_Audio_BitRate_kb.Text))
        End If
    End Sub

    Private Sub tbxExtraParameters_TextChanged(sender As Object, e As EventArgs) Handles tbxExtraParameters.TextChanged
        MainForm.DefInstance.VideoGrabber1.Encoder_SetStr(ENCODER_RECORDING_ID, VidGrab.TEncoder_str.Enc_Extra_Parameters, tbxExtraParameters.Text)
    End Sub
End Class
