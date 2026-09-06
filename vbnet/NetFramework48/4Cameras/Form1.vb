Imports VidGrab

Public Class Form1

    Const VGCOUNT = 6
    Const VGWIDTH = 400
    Const VGHEIGHT = 240
    Const GRIDTOP = 100
    Const GRIDLEFT = 100

    Dim VideoGrabbers(VGCOUNT) As VideoGrabber

    Private Sub btnStartPreview_Click(sender As Object, e As EventArgs) Handles btnStartPreview.Click
        For i As Integer = 0 To VGCOUNT - 1
            Dim IPCameraAsSource As Boolean = True
            If i = 0 Then ' using the 1st component for the USB grabber
                VideoGrabbers(i).VideoSource = TVideoSource.vs_VideoCaptureDevice
                VideoGrabbers(i).VideoDevice = VideoGrabbers(i).VideoDeviceIndex("c922 Pro Stream Webcam")
            Else
                VideoGrabbers(i).VideoSource = TVideoSource.vs_IPCamera
                VideoGrabbers(i).IPCameraURL = "rtsp://root:admin@192.168.1.25/axis-media/media.amp?videocodec=h264"
            End If

            VideoGrabbers(i).SetTextOverlay_Left(0, 10)
            VideoGrabbers(i).SetTextOverlay_Top(0, 10)
            VideoGrabbers(i).SetTextOverlay_String(0, "first overlay")
            VideoGrabbers(i).SetTextOverlay_Enabled(0, True)

            VideoGrabbers(i).SetTextOverlay_Left(1, 20)
            VideoGrabbers(i).SetTextOverlay_Top(1, 20)
            VideoGrabbers(i).SetTextOverlay_String(1, "second overlay")
            VideoGrabbers(i).SetTextOverlay_Enabled(1, True)

            VideoGrabbers(i).StartPreview()
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim xCount As Integer = 0
        Dim yCount As Integer = 0

        For i As Integer = 0 To VGCOUNT - 1
            VideoGrabbers(i) = New VideoGrabber()
            VideoGrabbers(i).Width = VGWIDTH
            VideoGrabbers(i).Height = VGHEIGHT
            VideoGrabbers(i).Left = GRIDTOP + (yCount * (VGWIDTH + 10))
            VideoGrabbers(i).Top = GRIDLEFT + (xCount * (VGHEIGHT + 10))
            Me.Controls.Add(VideoGrabbers(i))
            yCount = yCount + 1
            If yCount = 3 Then
                yCount = 0
                xCount = xCount + 1
            End If

            'AddHandler B.Click, AddressOf Button_Click
        Next

    End Sub

End Class
