Imports VidGrabNoForm

Module Module1

    Private KeyRead As ConsoleKeyInfo
    Private VideoDeviceIndex As Integer

    Private WithEvents VideoGrabber As VideoGrabber = New VideoGrabber()

    Private Sub VideoGrabber_OnFrameCaptureCompleted(ByVal sender As Object, ByVal e As TOnFrameCaptureCompletedEventArgs) Handles VideoGrabber.OnFrameCaptureCompleted
        If e.success Then
            Console.WriteLine("frame successfully captured to: " + e.fileName)
        End If
    End Sub

    Private Sub VideoGrabber_OnInactive(ByVal sender As Object, ByVal e As System.EventArgs) Handles VideoGrabber.OnInactive
        Console.WriteLine("component inactive.")
    End Sub

    Private Sub VideoGrabber_OnPlayerEndOfStream(ByVal sender As Object, ByVal e As System.EventArgs) Handles VideoGrabber.OnPlayerEndOfStream
        Console.WriteLine("end of stream!")
    End Sub

    Private Sub VideoGrabber_OnPlayerOpened(ByVal sender As Object, ByVal e As System.EventArgs) Handles VideoGrabber.OnPlayerOpened
        Console.WriteLine("player opened!")
    End Sub

    Private Sub VideoGrabber_OnPreviewStarted(ByVal sender As Object, ByVal e As System.EventArgs) Handles VideoGrabber.OnPreviewStarted
        Console.WriteLine("preview started!")
    End Sub

    Private Sub ContinueUntilKeyPressedOrInactive()
        While (Not Console.KeyAvailable) And (VideoGrabber.CurrentState <> TCurrentState.cs_Down)
            VideoGrabber.ContinueProcessing()
        End While
        KeyRead = Console.ReadKey()
    End Sub

    Sub VideoCaptureDevicePreview()
        Console.WriteLine("List of the video capture devices:")
        Console.WriteLine("---------------------------------")
        Console.WriteLine(VideoGrabber.VideoDevices.ToString())
        Console.WriteLine("")
        Console.WriteLine("enter the index of the video capture device to use (between 0 and " + (VideoGrabber.VideoDevicesCount - 1).ToString() + ")")
        Console.WriteLine("or press enter to skip")
        VideoGrabber.VideoSource = TVideoSource.vs_VideoCaptureDevice

        KeyRead = Console.ReadKey()
        If KeyRead.KeyChar <> Convert.ToChar(13) Then
            Console.ReadKey() ' waits for the user to press "enter"
        End If

        VideoDeviceIndex = Convert.ToInt32(KeyRead.KeyChar) - 48

        If (VideoDeviceIndex >= 0) And (VideoDeviceIndex < VideoGrabber.VideoDevicesCount) Then
            VideoGrabber.VideoDevice = Convert.ToInt32(KeyRead.KeyChar) - 48 ' // e.g. ASCII code of the "1" key = 49;
            Console.WriteLine("starting preview...")
            VideoGrabber.StartPreview()

        ElseIf KeyRead.KeyChar <> Convert.ToChar(13) Then

            Console.WriteLine("invalid index")
        End If

        If (VideoGrabber.CurrentState = TCurrentState.cs_Preview) Then

            Console.WriteLine("")
            Console.WriteLine("press a key to capture a frame to a JPEG file in the current folder")

            ContinueUntilKeyPressedOrInactive()

            VideoGrabber.CaptureFrameSyncTo(TFrameCaptureDest.fc_JpegFile, "")

        End If

        Console.WriteLine("")
        Console.WriteLine("press a key to stop the preview...")

        ContinueUntilKeyPressedOrInactive()

        VideoGrabber.Stop()

    End Sub

    Sub ScreenCapture()
        VideoGrabber.VideoSource = TVideoSource.vs_ScreenRecording
        VideoGrabber.StartPreview()

        If (VideoGrabber.CurrentState = TCurrentState.cs_Preview) Then

            Console.WriteLine("")
            Console.WriteLine("press a key to capture a frame to a JPEG file in the current folder")

            ContinueUntilKeyPressedOrInactive()

            VideoGrabber.CaptureFrameSyncTo(TFrameCaptureDest.fc_JpegFile, "")

        End If

        Console.WriteLine("")
        Console.WriteLine("press a key to stop the preview...")

        ContinueUntilKeyPressedOrInactive()

        VideoGrabber.Stop()

    End Sub


    Sub OpenPlayer()
        Console.WriteLine("")
        Console.WriteLine("enter the file name of a video clip to play, or press enter to skip:")
        Dim PlayerFileName As String = Console.ReadLine()

        If PlayerFileName <> "" Then

            VideoGrabber.PlayerFileName = PlayerFileName
            VideoGrabber.OpenPlayer()
            If (VideoGrabber.CurrentState = TCurrentState.cs_Playback) Then
                Console.WriteLine("")
                Console.WriteLine("press a key to close the player")
                ContinueUntilKeyPressedOrInactive()
                VideoGrabber.ClosePlayer()
            Else
                Console.WriteLine("error: failed to open the player")
            End If
        End If

        ContinueUntilKeyPressedOrInactive()

        VideoGrabber.Stop()

    End Sub

    Sub Main()

        Console.Clear()

        VideoGrabber.Display_Embedded = False ' enables the display of the video window when the component has no parent


        'VideoCaptureDevicePreview()

        ScreenCapture()
        'OpenPlayer()

        Console.WriteLine("")
        Console.WriteLine("press a key to destroy the component")
        Console.ReadKey()

        VideoGrabber.Dispose()

    End Sub

End Module
