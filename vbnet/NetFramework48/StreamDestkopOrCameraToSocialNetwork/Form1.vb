Imports VidGrab

Public Class Form1

    Dim DesktopSourceId As Integer = -1
    Dim IPCameraSourceId As Integer = -1
    Dim StreamingEncoderId As Integer = -1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AssignListToComboBox(cboAudioDevices, VideoGrabberMixer.AudioDevices, VideoGrabberMixer.AudioDevice)
        cboAudioDevices.SelectedIndex = 0 ' first audio device selected by default
        VideoGrabberMixer.VideoSource = TVideoSource.vs_Mixer
        VideoGrabberMixer.FrameRate = 20
        VideoGrabberMixer.UseNearestVideoSize(1920, 1080, True)


        StreamingEncoderId = VideoGrabberMixer.Encoders_CreateInstanceForStreaming("rtmps://live-api-s.facebook.com:443/rtmp/FB-613202114689260-0-Ab068DGkxkj_cbioRuyTrK13")
        If (StreamingEncoderId = -1) Then
            ' error
        Else
            VideoGrabberMixer.Encoder_SetStr(StreamingEncoderId, VidGrab.TEncoder_str.Enc_Audio_Codec, "aac")
            VideoGrabberMixer.Encoder_SetInt(StreamingEncoderId, VidGrab.TEncoder_int.Enc_Audio_Enabled_bool, 1)
            VideoGrabberMixer.Encoder_SetInt(StreamingEncoderId, VidGrab.TEncoder_int.Enc_Audio_BitRate_kb, 64)
            VideoGrabberMixer.Encoder_SetInt(StreamingEncoderId, VidGrab.TEncoder_int.Enc_Audio_Channels, 2)
            VideoGrabberMixer.Encoder_SetInt(StreamingEncoderId, VidGrab.TEncoder_int.Enc_Audio_SamplesPerSec, 44100)


            VideoGrabberMixer.Encoder_SetStr(StreamingEncoderId, VidGrab.TEncoder_str.Enc_Video_Codec, "h264")
            VideoGrabberMixer.Encoder_SetInt(StreamingEncoderId, VidGrab.TEncoder_int.Enc_Video_Enabled_bool, 1)
            'VideoGrabberMixer.Encoder_SetInt(StreamingEncoderId, VidGrab.TEncoder_int.Enc_Video_BitRate_kb, 2500)
            'VideoGrabberMixer.Encoder_SetInt(StreamingEncoderId, VidGrab.TEncoder_int.Enc_Video_rc_MaxBitRate_kb, 2500)
            'VideoGrabberMixer.Encoder_SetInt(0, VidGrab.TEncoder_int.Enc_Video_rc_BufferSize_kb, 5000)
            VideoGrabberMixer.Encoder_SetInt(StreamingEncoderId, VidGrab.TEncoder_int.Enc_Video_IDR_Interval, 30)
            VideoGrabberMixer.Encoder_SetInt(StreamingEncoderId, VidGrab.TEncoder_int.Enc_IsActive_bool, 1)
        End If

    End Sub

    Private Sub DesktopSource_Click(sender As Object, e As EventArgs) Handles DesktopSource.Click
        VideoGrabber1.VideoSource = TVideoSource.vs_ScreenRecording
        DesktopSourceId = VideoGrabberMixer.Mixer_AddToMixer(VideoGrabber1.UniqueID, 0, 0, 0, 0, 0, 0, False)
        VideoGrabber1.StartPreview()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        VideoGrabber2.VideoSource = TVideoSource.vs_IPCamera
        VideoGrabber2.IPCameraURL = IPCameraURL.Text
        IPCameraSourceId = VideoGrabberMixer.Mixer_AddToMixer(VideoGrabber2.UniqueID, 0, 0, 0, 0, 0, 0, False)
        VideoGrabber2.StartPreview()

    End Sub

    Private Sub SelectSource()
        If rbSelectVideoSource1.Checked Then
            VideoGrabberMixer.Mixer_Activation(IPCameraSourceId, False)
            VideoGrabberMixer.Mixer_Activation(DesktopSourceId, True)
        ElseIf rbSelectVideoSource2.Checked Then
            VideoGrabberMixer.Mixer_Activation(DesktopSourceId, False)
            VideoGrabberMixer.Mixer_Activation(IPCameraSourceId, True)
        End If
    End Sub
    Private Sub rbSelectVideoSource1_CheckedChanged(sender As Object, e As EventArgs) Handles rbSelectVideoSource1.CheckedChanged
        SelectSource()
    End Sub

    Private Sub rbSelectVideoSource2_CheckedChanged(sender As Object, e As EventArgs) Handles rbSelectVideoSource2.CheckedChanged
        SelectSource()
    End Sub

    Private Sub cboAudioDevices_SelectedIndexChanged(sender As Object, e As EventArgs)
        VideoGrabberMixer.AudioDevice = cboAudioDevices.SelectedIndex
    End Sub

    Private Sub VideoGrabber1_OnLog(sender As Object, e As TOnLogEventArgs) Handles VideoGrabber1.OnLog
        AddLog(mmoLog, "screen: [" & e.severity & "] " & e.infoMsg)
    End Sub

    Private Sub VideoGrabber2_OnLog(sender As Object, e As TOnLogEventArgs) Handles VideoGrabber2.OnLog
        AddLog(mmoLog, "rtsp: [" & e.severity & "] " & e.infoMsg)
    End Sub

    Private Sub VideoGrabberMixer_OnLog(sender As Object, e As TOnLogEventArgs) Handles VideoGrabberMixer.OnLog
        AddLog(mmoLog, "mixer: [" & e.severity & "] " & e.infoMsg)
    End Sub

    Private Sub btnStartMixer_Click(sender As Object, e As EventArgs) Handles btnStartMixer.Click
        If chkWithoutAudio.Checked Then
            VideoGrabberMixer.AudioSource = TAudioSource.as_Silent
        Else
            VideoGrabberMixer.AudioSource = TAudioSource.as_Default
            VideoGrabberMixer.AudioDevice = cboAudioDevices.SelectedIndex
        End If
        SelectSource()
        VideoGrabberMixer.StartPreview()
    End Sub

    Private Sub btnStopMixer_Click(sender As Object, e As EventArgs) Handles btnStopMixer.Click
        VideoGrabberMixer.StopPreview()
    End Sub

    Private Sub rtp(sender As Object, e As EventArgs) Handles IPCameraURL.TextChanged

    End Sub
End Class
