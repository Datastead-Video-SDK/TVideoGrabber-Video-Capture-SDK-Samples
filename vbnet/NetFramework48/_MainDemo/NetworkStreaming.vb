Option Strict Off
Option Explicit On
Friend Class NetworkStreaming
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
    Private WithEvents groupBox3 As GroupBox
    Private WithEvents btnNDIStreamingClientView As Button
    Private WithEvents btnNDIClientHelp As Button
    Private WithEvents label3 As Label
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents btnNDIStreamingOK As Button
    Private WithEvents edtNDISessionName As TextBox
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label2 As Label
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btnResumeStreaming As Button
    Private WithEvents btnPauseStreaming As Button
    Private WithEvents btnMultipurposeUDPStreaming As Button
    Private WithEvents chkAudioStreamingEnabled As CheckBox
    Private WithEvents chkVideoStreamingEnabled As CheckBox
    Private WithEvents label1 As Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NetworkStreaming))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnNDIStreamingClientView = New System.Windows.Forms.Button()
        Me.btnNDIClientHelp = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnNDIStreamingOK = New System.Windows.Forms.Button()
        Me.edtNDISessionName = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnResumeStreaming = New System.Windows.Forms.Button()
        Me.btnPauseStreaming = New System.Windows.Forms.Button()
        Me.btnMultipurposeUDPStreaming = New System.Windows.Forms.Button()
        Me.chkAudioStreamingEnabled = New System.Windows.Forms.CheckBox()
        Me.chkVideoStreamingEnabled = New System.Windows.Forms.CheckBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.groupBox3.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Fuchsia
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.btnNDIStreamingClientView)
        Me.groupBox3.Controls.Add(Me.btnNDIClientHelp)
        Me.groupBox3.Location = New System.Drawing.Point(642, 146)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(417, 60)
        Me.groupBox3.TabIndex = 14
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "client side: (from a 2nd MainDemo.exe)"
        '
        'btnNDIStreamingClientView
        '
        Me.btnNDIStreamingClientView.Location = New System.Drawing.Point(5, 21)
        Me.btnNDIStreamingClientView.Name = "btnNDIStreamingClientView"
        Me.btnNDIStreamingClientView.Size = New System.Drawing.Size(60, 26)
        Me.btnNDIStreamingClientView.TabIndex = 1
        Me.btnNDIStreamingClientView.Text = "View"
        Me.btnNDIStreamingClientView.UseVisualStyleBackColor = True
        '
        'btnNDIClientHelp
        '
        Me.btnNDIClientHelp.Location = New System.Drawing.Point(78, 21)
        Me.btnNDIClientHelp.Name = "btnNDIClientHelp"
        Me.btnNDIClientHelp.Size = New System.Drawing.Size(38, 26)
        Me.btnNDIClientHelp.TabIndex = 0
        Me.btnNDIClientHelp.Text = "?"
        Me.btnNDIClientHelp.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(639, 9)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(295, 17)
        Me.label3.TabIndex = 13
        Me.label3.Text = "NDI (requires the Datastead NDI filters)"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.btnNDIStreamingOK)
        Me.groupBox2.Controls.Add(Me.edtNDISessionName)
        Me.groupBox2.Controls.Add(Me.label5)
        Me.groupBox2.Controls.Add(Me.label4)
        Me.groupBox2.Location = New System.Drawing.Point(642, 29)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(417, 111)
        Me.groupBox2.TabIndex = 12
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "server side: "
        '
        'btnNDIStreamingOK
        '
        Me.btnNDIStreamingOK.Location = New System.Drawing.Point(17, 39)
        Me.btnNDIStreamingOK.Name = "btnNDIStreamingOK"
        Me.btnNDIStreamingOK.Size = New System.Drawing.Size(48, 34)
        Me.btnNDIStreamingOK.TabIndex = 3
        Me.btnNDIStreamingOK.Text = "OK"
        Me.btnNDIStreamingOK.UseVisualStyleBackColor = True
        '
        'edtNDISessionName
        '
        Me.edtNDISessionName.Location = New System.Drawing.Point(132, 18)
        Me.edtNDISessionName.Name = "edtNDISessionName"
        Me.edtNDISessionName.Size = New System.Drawing.Size(140, 23)
        Me.edtNDISessionName.TabIndex = 2
        Me.edtNDISessionName.Text = "MYSTREAM"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(71, 43)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(263, 16)
        Me.label5.TabIndex = 1
        Me.label5.Text = "(then, start e.g. the preview or playback)"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(17, 20)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(99, 16)
        Me.label4.TabIndex = 0
        Me.label4.Text = "session name:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(187, 9)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(415, 17)
        Me.label2.TabIndex = 11
        Me.label2.Text = "Encoder (requires the Datastead Multipurpose Encoder)"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btnResumeStreaming)
        Me.groupBox1.Controls.Add(Me.btnPauseStreaming)
        Me.groupBox1.Controls.Add(Me.btnMultipurposeUDPStreaming)
        Me.groupBox1.Location = New System.Drawing.Point(184, 29)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(452, 143)
        Me.groupBox1.TabIndex = 10
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Examples"
        '
        'btnResumeStreaming
        '
        Me.btnResumeStreaming.Location = New System.Drawing.Point(223, 52)
        Me.btnResumeStreaming.Name = "btnResumeStreaming"
        Me.btnResumeStreaming.Size = New System.Drawing.Size(150, 29)
        Me.btnResumeStreaming.TabIndex = 2
        Me.btnResumeStreaming.Text = "resume streaming"
        Me.btnResumeStreaming.UseVisualStyleBackColor = True
        '
        'btnPauseStreaming
        '
        Me.btnPauseStreaming.Location = New System.Drawing.Point(56, 52)
        Me.btnPauseStreaming.Name = "btnPauseStreaming"
        Me.btnPauseStreaming.Size = New System.Drawing.Size(145, 29)
        Me.btnPauseStreaming.TabIndex = 1
        Me.btnPauseStreaming.Text = "pause streaming"
        Me.btnPauseStreaming.UseVisualStyleBackColor = True
        '
        'btnMultipurposeUDPStreaming
        '
        Me.btnMultipurposeUDPStreaming.Location = New System.Drawing.Point(6, 20)
        Me.btnMultipurposeUDPStreaming.Name = "btnMultipurposeUDPStreaming"
        Me.btnMultipurposeUDPStreaming.Size = New System.Drawing.Size(440, 23)
        Me.btnMultipurposeUDPStreaming.TabIndex = 0
        Me.btnMultipurposeUDPStreaming.Text = "UDP streaming 2Mb/s, destination : udp://@239.255.0.1:10124"
        Me.btnMultipurposeUDPStreaming.UseVisualStyleBackColor = True
        '
        'chkAudioStreamingEnabled
        '
        Me.chkAudioStreamingEnabled.AutoSize = True
        Me.chkAudioStreamingEnabled.Location = New System.Drawing.Point(7, 49)
        Me.chkAudioStreamingEnabled.Name = "chkAudioStreamingEnabled"
        Me.chkAudioStreamingEnabled.Size = New System.Drawing.Size(120, 20)
        Me.chkAudioStreamingEnabled.TabIndex = 9
        Me.chkAudioStreamingEnabled.Text = "audio enabled"
        Me.chkAudioStreamingEnabled.UseVisualStyleBackColor = True
        '
        'chkVideoStreamingEnabled
        '
        Me.chkVideoStreamingEnabled.AutoSize = True
        Me.chkVideoStreamingEnabled.Checked = True
        Me.chkVideoStreamingEnabled.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVideoStreamingEnabled.Location = New System.Drawing.Point(8, 16)
        Me.chkVideoStreamingEnabled.Name = "chkVideoStreamingEnabled"
        Me.chkVideoStreamingEnabled.Size = New System.Drawing.Size(119, 20)
        Me.chkVideoStreamingEnabled.TabIndex = 8
        Me.chkVideoStreamingEnabled.Text = "video enabled"
        Me.chkVideoStreamingEnabled.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(153, 177)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(483, 16)
        Me.label1.TabIndex = 15
        Me.label1.Text = "FOR MORE EXAMPLES PLEASE CONTACT US at support@datastead.com"
        '
        'NetworkStreaming
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.ClientSize = New System.Drawing.Size(1421, 356)
        Me.ControlBox = False
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.chkAudioStreamingEnabled)
        Me.Controls.Add(Me.chkVideoStreamingEnabled)
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NetworkStreaming"
        Me.ShowInTaskbar = False
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Public Sub RefreshControls()
    End Sub

    Private m_MultipurposeUDPStreamingID As Long = -1

    Private Sub NetworkStreaming_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Visible Then
            RefreshControls()
        End If
    End Sub

    Private Sub btnNDIClientHelp_Click(sender As Object, e As EventArgs) Handles btnNDIClientHelp.Click
        MessageBox.Show("select ""NewTek NDI Video"" in the ""video devices"" list and click ""Start Preview""")
    End Sub

    Private Sub btnNDIStreamingOK_Click(sender As Object, e As EventArgs) Handles btnNDIStreamingOK.Click
        If chkVideoStreamingEnabled.Checked And chkVideoStreamingEnabled.Checked Then
            MainForm.DefInstance.VideoGrabber1.NetworkStreamingType = VidGrab.TNetworkStreamingType.nst_AudioVideoStreaming
        ElseIf (chkVideoStreamingEnabled.Checked) Then
            MainForm.DefInstance.VideoGrabber1.NetworkStreamingType = VidGrab.TNetworkStreamingType.nst_VideoStreaming
        ElseIf (chkAudioStreamingEnabled.Checked) Then
            MainForm.DefInstance.VideoGrabber1.NetworkStreamingType = VidGrab.TNetworkStreamingType.nst_AudioStreaming
        End If
        MainForm.DefInstance.VideoGrabber1.NDIName = edtNDISessionName.Text
        MainForm.DefInstance.VideoGrabber1.NetworkStreaming = VidGrab.TNetworkStreaming.ns_NDI
        AddLog(MainForm.DefInstance.mmoLog, "NDI streaming enabled")

    End Sub

    Private Sub btnPauseStreaming_Click(sender As Object, e As EventArgs) Handles btnPauseStreaming.Click
        MainForm.DefInstance.VideoGrabber1.Encoder_Pause(m_MultipurposeUDPStreamingID)
    End Sub

    Private Sub btnResumeStreaming_Click(sender As Object, e As EventArgs) Handles btnResumeStreaming.Click
        MainForm.DefInstance.VideoGrabber1.Encoder_Resume(m_MultipurposeUDPStreamingID)
    End Sub

    Private Sub btnMultipurposeUDPStreaming_Click(sender As Object, e As EventArgs) Handles btnMultipurposeUDPStreaming.Click
        If m_MultipurposeUDPStreamingID = -1 Then
            m_MultipurposeUDPStreamingID = MainForm.DefInstance.VideoGrabber1.Encoders_CreateInstanceForStreaming("udp://239.255.0.1:10124")
        End If
        If m_MultipurposeUDPStreamingID > -1 Then
            ' uncomment one of the lines below to use a specific codec, e.g.:
            ' MainForm.DefInstance.VideoGrabber1.Encoder_SetStr (FMultipurposeUDPStreamingID, TEncoder_str.Enc_Video_Codec, "hevc")
            ' MainForm.DefInstance.VideoGrabber1.Encoder_SetStr (FMultipurposeUDPStreamingID, TEncoder_str.Enc_Video_Codec, "h264")

            MainForm.DefInstance.VideoGrabber1.Encoder_SetInt(m_MultipurposeUDPStreamingID, VidGrab.TEncoder_int.Enc_Video_Enabled_bool, 1)
            MainForm.DefInstance.VideoGrabber1.Encoder_SetInt(m_MultipurposeUDPStreamingID, VidGrab.TEncoder_int.Enc_Audio_Enabled_bool, 1)
            If Not chkVideoStreamingEnabled.Checked Then
                MainForm.DefInstance.VideoGrabber1.Encoder_SetInt(m_MultipurposeUDPStreamingID, VidGrab.TEncoder_int.Enc_Video_Enabled_bool, 0)
            End If
            If Not chkAudioStreamingEnabled.Checked Then
                MainForm.DefInstance.VideoGrabber1.Encoder_SetInt(m_MultipurposeUDPStreamingID, VidGrab.TEncoder_int.Enc_Audio_Enabled_bool, 0)
            End If
            MainForm.DefInstance.VideoGrabber1.Encoder_SetInt(m_MultipurposeUDPStreamingID, VidGrab.TEncoder_int.Enc_Video_BitRate_kb, 2000)
            MainForm.DefInstance.VideoGrabber1.Encoder_SetInt(m_MultipurposeUDPStreamingID, VidGrab.TEncoder_int.Enc_Video_rc_MinBitRate_kb, 1800)
            MainForm.DefInstance.VideoGrabber1.Encoder_SetInt(m_MultipurposeUDPStreamingID, VidGrab.TEncoder_int.Enc_Video_rc_MaxBitRate_kb, 2200)
            MainForm.DefInstance.VideoGrabber1.Encoder_SetInt(m_MultipurposeUDPStreamingID, VidGrab.TEncoder_int.Enc_Video_IDR_Interval, 30)
            ' uncomment to enable the GPU encoder, if (available for h264 Or hevc
            ' MainForm.DefInstance.VideoGrabber1.Encoder_SetInt (FStreamingEncoderId, VidGrab.TEncoder_int.Enc_Video_GPU_Encoder, LongInt (TEncoder_int.Enc_GPU_Auto))  // Or specify directly Enc_GPU_Intel_QSV, Enc_GPU_NVidia_NVENC Or Enc_GPU_AMD_AMF
            MainForm.DefInstance.VideoGrabber1.Encoder_SetInt(m_MultipurposeUDPStreamingID, VidGrab.TEncoder_int.Enc_IsActive_bool, 1)
        End If
    End Sub
End Class
