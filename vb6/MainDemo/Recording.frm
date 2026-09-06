VERSION 5.00
Begin VB.Form Recording 
   BorderStyle     =   0  'None
   ClientHeight    =   3216
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   13920
   LinkTopic       =   "Form1"
   ScaleHeight     =   268
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   1160
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame framTabs 
      BorderStyle     =   0  'None
      Height          =   3060
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   13575
      Begin VB.Frame rdgRecordingTimer 
         Caption         =   "recording timer"
         Height          =   1200
         Left            =   3000
         TabIndex        =   47
         Tag             =   "rdgRecordingTimer"
         Top             =   660
         Width           =   2895
         Begin VB.OptionButton rdgRecordingTimer4 
            Caption         =   "start after..."
            Height          =   195
            Left            =   1680
            TabIndex        =   54
            Tag             =   "3"
            Top             =   480
            Width           =   1095
         End
         Begin VB.OptionButton rdgRecordingTimer3 
            Caption         =   "stop after..."
            Height          =   195
            Left            =   1680
            TabIndex        =   53
            Tag             =   "2"
            Top             =   240
            Width           =   1095
         End
         Begin VB.OptionButton rdgRecordingTimer2 
            Caption         =   "new file every..."
            Height          =   195
            Left            =   120
            TabIndex        =   52
            Tag             =   "1"
            Top             =   480
            Width           =   1575
         End
         Begin VB.OptionButton rdgRecordingTimer1 
            Caption         =   "disabled"
            Height          =   195
            Left            =   120
            TabIndex        =   51
            Tag             =   "0"
            Top             =   240
            Width           =   1455
         End
         Begin VB.CheckBox chkScreenRecordWindow 
            Caption         =   "e.g. source = screen window"
            Enabled         =   0   'False
            Height          =   375
            Left            =   1440
            TabIndex        =   50
            Top             =   740
            Value           =   1  'Checked
            Width           =   1365
         End
         Begin VB.TextBox edtRecordingTimer 
            Height          =   285
            Left            =   120
            TabIndex        =   48
            Text            =   "0"
            Top             =   800
            Width           =   495
         End
         Begin VB.Label lblRecordingTimer 
            AutoSize        =   -1  'True
            Caption         =   "seconds"
            Height          =   195
            Left            =   660
            TabIndex        =   49
            Top             =   810
            Width           =   600
         End
      End
      Begin VB.CommandButton btnMoreInfo 
         Caption         =   "?"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   7.8
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   2520
         TabIndex        =   5
         Top             =   960
         Width           =   330
      End
      Begin VB.Frame rdgRecordingSize 
         Caption         =   "recording size"
         Height          =   950
         Left            =   7680
         TabIndex        =   38
         Top             =   1320
         Width           =   1335
         Begin VB.OptionButton rdgRecordingSize1 
            Caption         =   "default"
            Height          =   195
            Left            =   80
            TabIndex        =   41
            Tag             =   "0"
            Top             =   220
            Width           =   1095
         End
         Begin VB.OptionButton rdgRecordingSize2 
            Caption         =   "half size"
            Height          =   195
            Left            =   80
            TabIndex        =   40
            Tag             =   "1"
            Top             =   440
            Width           =   1095
         End
         Begin VB.OptionButton rdgRecordingSize3 
            Caption         =   "quarter size"
            Height          =   195
            Left            =   80
            TabIndex        =   39
            Tag             =   "2"
            Top             =   660
            Width           =   1215
         End
      End
      Begin VB.CommandButton btnCreatePreallocFileNow 
         Caption         =   "create preallocated file now"
         Height          =   255
         Left            =   3720
         TabIndex        =   37
         Top             =   2420
         Width           =   2175
      End
      Begin VB.TextBox edtPreallocSize 
         Height          =   285
         Left            =   2400
         TabIndex        =   36
         Text            =   "100"
         Top             =   2420
         Width           =   540
      End
      Begin VB.CheckBox chkPreallocFile 
         Caption         =   "use preallocated capture file:"
         Height          =   255
         Left            =   0
         TabIndex        =   35
         Top             =   2420
         Width           =   2415
      End
      Begin VB.CheckBox chkOpenDML 
         Caption         =   "OpenDML format (avi 2.0, captured file > 1 Gb)"
         Height          =   255
         Left            =   0
         TabIndex        =   34
         Top             =   2160
         Width           =   3735
      End
      Begin VB.TextBox edtRecordingFileName 
         Height          =   285
         Left            =   3840
         TabIndex        =   33
         Text            =   "CaptureFile01.wmv"
         Top             =   1900
         Width           =   2055
      End
      Begin VB.CheckBox chkAVISaveToThisFile 
         Caption         =   "do not generate file names automatically, save to:"
         Height          =   255
         Left            =   0
         TabIndex        =   32
         Top             =   1900
         Width           =   3855
      End
      Begin VB.CheckBox chkPreserveNativeFormat 
         Caption         =   "RECORD IN NATIVE FORMAT"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   7.8
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   0
         TabIndex        =   31
         Top             =   720
         Width           =   3015
      End
      Begin VB.ComboBox cboAudioFormats 
         Height          =   315
         Left            =   0
         TabIndex        =   30
         Top             =   1500
         Width           =   2895
      End
      Begin VB.CheckBox chkAudioRecording 
         Caption         =   "enable audio recording"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   7.8
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   0
         TabIndex        =   29
         Top             =   1000
         Width           =   2415
      End
      Begin VB.Frame Frame1 
         Caption         =   "video and audio compression"
         Height          =   2030
         Index           =   4
         Left            =   9120
         TabIndex        =   14
         Top             =   240
         Width           =   4455
         Begin VB.Frame rdgCompressMode 
            Caption         =   "compression mode"
            Height          =   855
            Left            =   2760
            TabIndex        =   23
            Top             =   160
            Width           =   1575
            Begin VB.OptionButton rdgCompressMode1 
               Caption         =   "no"
               Height          =   195
               Left            =   120
               TabIndex        =   26
               Tag             =   "0"
               Top             =   200
               Width           =   855
            End
            Begin VB.OptionButton rdgCompressMode3 
               Caption         =   "after capture"
               Height          =   195
               Left            =   120
               TabIndex        =   25
               Tag             =   "2"
               Top             =   600
               Width           =   1215
            End
            Begin VB.OptionButton rdgCompressMode2 
               Caption         =   "on the fly"
               Height          =   195
               Left            =   120
               TabIndex        =   24
               Tag             =   "1"
               Top             =   400
               Width           =   1215
            End
         End
         Begin VB.Frame rdgCompressType 
            Caption         =   "compression type"
            Height          =   855
            Left            =   2760
            TabIndex        =   19
            Top             =   1080
            Width           =   1575
            Begin VB.OptionButton rdgCompressType2 
               Caption         =   "audio"
               Height          =   195
               Left            =   120
               TabIndex        =   22
               Tag             =   "1"
               Top             =   400
               Width           =   1215
            End
            Begin VB.OptionButton rdgCompressType3 
               Caption         =   "audio + video"
               Height          =   195
               Left            =   120
               TabIndex        =   21
               Tag             =   "2"
               Top             =   600
               Width           =   1400
            End
            Begin VB.OptionButton rdgCompressType1 
               Caption         =   "video"
               Height          =   195
               Left            =   120
               TabIndex        =   20
               Tag             =   "0"
               Top             =   200
               Width           =   855
            End
         End
         Begin VB.ComboBox cboVideoCompressors 
            Height          =   315
            Left            =   120
            TabIndex        =   18
            Top             =   440
            Width           =   2535
         End
         Begin VB.CommandButton btnVideoCompressorSettings 
            Caption         =   "settings"
            Height          =   255
            Left            =   1440
            TabIndex        =   17
            Top             =   800
            Width           =   1215
         End
         Begin VB.ComboBox cboAudioCompressors 
            Height          =   315
            Left            =   120
            TabIndex        =   16
            Top             =   1320
            Width           =   2535
         End
         Begin VB.CommandButton btnAudioCompressorSettings 
            Caption         =   "settings"
            Height          =   255
            Left            =   1440
            TabIndex        =   15
            Top             =   1680
            Width           =   1215
         End
         Begin VB.Label Label1 
            Caption         =   "video compressor"
            Height          =   255
            Index           =   2
            Left            =   120
            TabIndex        =   28
            Top             =   220
            Width           =   1695
         End
         Begin VB.Label Label1 
            Caption         =   "audio compressor"
            Height          =   255
            Index           =   30
            Left            =   120
            TabIndex        =   27
            Top             =   1100
            Width           =   1695
         End
      End
      Begin VB.Frame grbAVIPauseResume 
         Caption         =   "pause/resume"
         Height          =   1040
         Left            =   6000
         TabIndex        =   8
         Top             =   180
         Width           =   3015
         Begin VB.CheckBox chkRecordingPauseCreatesNewFile 
            Caption         =   "pause creates new file"
            Height          =   255
            Left            =   60
            TabIndex        =   13
            Top             =   460
            Width           =   2085
         End
         Begin VB.CheckBox chkRecordingCanPause 
            Caption         =   "recording can pause"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   7.8
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Left            =   60
            TabIndex        =   12
            Top             =   220
            Width           =   2205
         End
         Begin VB.CommandButton btnPauseRecording 
            Caption         =   "pause"
            Height          =   255
            Left            =   2160
            TabIndex        =   11
            Top             =   160
            Width           =   735
         End
         Begin VB.CheckBox chkPauseResumeOnMotionDetection 
            Caption         =   "pause/resume on motion detection"
            Height          =   255
            Left            =   60
            TabIndex        =   10
            Top             =   700
            Width           =   2895
         End
         Begin VB.CommandButton btnResumeRecording 
            Caption         =   "resume"
            Height          =   255
            Left            =   2160
            TabIndex        =   9
            Top             =   400
            Width           =   735
         End
      End
      Begin VB.CommandButton btnRenewRecordingFile 
         Caption         =   "new file during recording"
         Height          =   355
         Left            =   3960
         TabIndex        =   7
         Top             =   260
         Width           =   1935
      End
      Begin VB.CommandButton btnStopRecording 
         Caption         =   "stop"
         Height          =   355
         Left            =   3120
         TabIndex        =   6
         Top             =   260
         Width           =   735
      End
      Begin VB.Frame rdgRecordingMethod 
         Caption         =   "recording method"
         Height          =   1540
         Left            =   6000
         TabIndex        =   1
         Top             =   1200
         Width           =   1575
         Begin VB.OptionButton rdgRecordingMetho6 
            Caption         =   "MP4"
            Height          =   255
            Left            =   80
            TabIndex        =   59
            Tag             =   "5"
            Top             =   1250
            Width           =   855
         End
         Begin VB.OptionButton rdgRecordingMethod5 
            Caption         =   "FLV"
            Height          =   255
            Left            =   80
            TabIndex        =   58
            Tag             =   "4"
            Top             =   1050
            Width           =   795
         End
         Begin VB.OptionButton rdgRecordingMethod4 
            Caption         =   "MKV"
            Height          =   255
            Left            =   80
            TabIndex        =   55
            Tag             =   "3"
            Top             =   850
            Width           =   795
         End
         Begin VB.OptionButton rdgRecordingMethod1 
            Caption         =   "AVI or MPEG"
            Height          =   255
            Left            =   80
            TabIndex        =   4
            Tag             =   "0"
            Top             =   200
            Width           =   1335
         End
         Begin VB.OptionButton rdgRecordingMethod2 
            Caption         =   "ASF (1)"
            Height          =   255
            Left            =   80
            TabIndex        =   3
            Tag             =   "1"
            Top             =   420
            Width           =   855
         End
         Begin VB.OptionButton rdgRecordingMethod3 
            Caption         =   "Send to DV (2)"
            Height          =   255
            Left            =   80
            TabIndex        =   2
            Tag             =   "2"
            Top             =   640
            Width           =   1400
         End
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         Caption         =   "(2) recording sent to a DV camcorder"
         Height          =   195
         Index           =   31
         Left            =   8520
         TabIndex        =   57
         Top             =   2610
         Width           =   2610
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         Caption         =   "(1) settings located on the ""network streaming"" tab"
         Height          =   195
         Index           =   32
         Left            =   8520
         TabIndex        =   56
         Top             =   2400
         Width           =   3585
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         Caption         =   $"Recording.frx":0000
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   7.8
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   36
         Left            =   0
         TabIndex        =   46
         Top             =   0
         Width           =   11595
      End
      Begin VB.Label Label1 
         Caption         =   "Mb (size)"
         Height          =   255
         Index           =   35
         Left            =   3000
         TabIndex        =   45
         Top             =   2420
         Width           =   735
      End
      Begin VB.Label Label1 
         Caption         =   "audio format:"
         Height          =   255
         Index           =   34
         Left            =   0
         TabIndex        =   44
         Top             =   1300
         Width           =   975
      End
      Begin VB.CommandButton btnStartRecordingImmediately 
         Height          =   360
         Left            =   0
         TabIndex        =   43
         Top             =   260
         Width           =   1575
         ForeColor       =   255
         Caption         =   "start (immediately)"
         Size            =   "2778;635"
         FontHeight      =   165
         FontCharSet     =   0
         FontPitchAndFamily=   2
         ParagraphAlign  =   3
      End
      Begin VB.CommandButton btnStartRecordingControlled 
         Height          =   360
         Left            =   1680
         TabIndex        =   42
         Top             =   260
         Width           =   1335
         ForeColor       =   255
         Caption         =   "start (controlled)"
         Size            =   "2355;635"
         FontHeight      =   165
         FontCharSet     =   0
         FontPitchAndFamily=   2
         ParagraphAlign  =   3
      End
   End
End
Attribute VB_Name = "Recording"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit


Private Sub Form_Load()
    With framTabs
        Me.Width = .Width
        Me.Height = .Height
    End With
End Sub

Private Sub Form_Unload(Cancel As Integer)
   If Not MainForm.CanUnload Then
      Hide
      Cancel = True
   End If
End Sub

Private Sub Form_Activate()
    RefreshRecordingControls
End Sub

Public Sub RefreshRecordingControls()
    Recording.chkScreenRecordWindow.Enabled = IIf(MainForm.VideoGrabberVB61.VideoSource = vs_ScreenRecording, True, False)
    Recording.chkScreenRecordWindow.ToolTipText = "When VideoSource = vs_ScreenRecording, and SetWindowRecordingByName has been invoked, checking " & _
            "chkScreenRecordWindow will demonstrate how to make the source window the " & _
            "top window before StartRecording"
End Sub

Private Sub btnAudioCompressorSettings_Click()
   MainForm.VideoGrabberVB61.ShowDialog (dlg_AudioCompressor)
End Sub

Private Sub btnCreatePreallocFileNow_Click()
   MainForm.VideoGrabberVB61.CreatePreallocCapFile
End Sub

Private Sub btnMoreInfo_Click()
   MsgBox ("Means that the recording stream will not be uncompressed." & vbCrLf & _
           "" & vbCrLf & _
           "MUST BE ENABLED:" & vbCrLf & _
           "- to record hardware-encoded MPEG" & vbCrLf & _
           "- to record or DV devices in native DV format" & vbCrLf & _
           "- to record the DV date/time into the video clip and retrieve it during playback" & vbCrLf & _
           "" & vbCrLf & _
           "MUST BE DISABLED:" & vbCrLf & _
           "- to record the text and graphics overlays into the video clip, and retrieve them during playback"), _
            vbOKOnly, _
            "DataStead TVideoGrabber VB 6 OCX Demo"
End Sub

Private Sub btnPauseRecording_Click()
   MainForm.VideoGrabberVB61.PauseRecording
End Sub

Private Sub btnRenewRecordingFile_Click()
   If chkAVISaveToThisFile.Value = Checked Then
      MainForm.VideoGrabberVB61.RecordingFileName = edtRecordingFileName.Text
   Else
      ' keyword that indicates TVideoGrabber to generate a new recording file name automatically
      MainForm.VideoGrabberVB61.RecordingFileName = ""
   End If
   MainForm.VideoGrabberVB61.RecordToNewFileNow "", True
End Sub

Private Sub btnResumeRecording_Click()
   MainForm.VideoGrabberVB61.ResumeRecording
End Sub


Private Sub btnStartRecordingControlled_Click()
   If chkAVISaveToThisFile.Value = Checked Then
      MainForm.VideoGrabberVB61.RecordingFileName = edtRecordingFileName.Text
   Else
      MainForm.VideoGrabberVB61.RecordingFileName = ""
   End If

   MainForm.VideoGrabberVB61.HoldRecording = True
   MainForm.VideoGrabberVB61.StartRecording

   ' Enabling HoldRecording before calling StartRecording prevents the recording
   '  to start (when the recording graph is built) until the
   '  OnRecordingReadyToStart event is fired, where ResumeRecording must be invoked
   '  to commence recording, or StopRecording to cancel recording
   ' EXCEPTION: RecordingTimer = rt_StartRecording: recording is started
   '  after RecordingTimerInterval regardless of HoldRecording setting,
   '  and OnRecordingReadyToStart event is not fired
   
   If (MainForm.VideoGrabberVB61.RecordingTimer = rt_StartRecording) And (MainForm.VideoGrabberVB61.VideoSource = vs_ScreenRecording) And (Recording.chkScreenRecordWindow.Value = vbChecked) And (lngScreenRecordingWindow > 0) Then
      ' for screen recording of a window, this code will make it the top window before recording start;
      '  window handle was gathered by EnumerateWindows in OnEnumerateWindows
      ' (see demo procedures in VideoSource form btnScreenRecordingWindow and SetEnumerateWindows)
      SetWindowPos wenScreenRecordingWindow(lngScreenRecordingWindow - 1).WindowHandle, HWND_TOP, 0, 0, 0, 0, SWP_NOMOVE Or SWP_NOSIZE
   End If
   
End Sub



Private Sub rdgRecordingTimer1_Click()
    MainForm.VideoGrabberVB61.RecordingTimer = rt_Disabled
End Sub

Private Sub rdgRecordingTimer2_Click()
    MainForm.VideoGrabberVB61.RecordingTimer = rt_RecordToNewFile
End Sub

Private Sub rdgRecordingTimer3_Click()
    MainForm.VideoGrabberVB61.RecordingTimer = rt_StopRecording
End Sub

Private Sub rdgRecordingTimer4_Click()
    MainForm.VideoGrabberVB61.RecordingTimer = rt_StartRecording
End Sub

Private Sub edtRecordingTimer_Change()
    If Val(edtRecordingTimer.Text) > 0 Then
        MainForm.VideoGrabberVB61.RecordingTimerInterval = Val(edtRecordingTimer.Text)
    Else
        MainForm.VideoGrabberVB61.RecordingTimerInterval = 0
    End If
End Sub

Private Sub chkScreenRecordWindow_Click()
    ' for source = screen demonstration purposes, if:
    ' - VideoSource = vs_ScreenRecording
    ' - source window handle is identified with VideoSource form btnScreenRecordingWindow
    '   via EnumerateWindows and OnEnumerateWindows event (SetEnumerateWindows demo procedure)
    ' - chkScreenRecordWindow is enabled
    ' source window will be made top window at recording start (using API SetWindowPos),
    '  see Recording form btnStartRecordingImmediately and btnStartRecordingControlled,
    '  and events OnEnumerateWindows, OnRecordingReadyToStart
End Sub

Private Sub btnStartRecordingImmediately_Click()
   If chkAVISaveToThisFile.Value = Checked Then
      MainForm.VideoGrabberVB61.RecordingFileName = edtRecordingFileName.Text
   Else
      MainForm.VideoGrabberVB61.RecordingFileName = ""
   End If
   ' Enabling HoldRecording before calling StartRecording prevents the recording
   '  to start (when the recording graph is built) until the
   '  OnRecordingReadyToStart event is fired, where ResumeRecording must be invoked
   '  to commence recording, or StopRecording to cancel recording
   ' EXCEPTION: RecordingTimer = rt_StartRecording: recording is started
   '  after RecordingTimerInterval regardless of HoldRecording setting,
   '  and OnRecordingReadyToStart event is not fired
   MainForm.VideoGrabberVB61.HoldRecording = False
   If (MainForm.VideoGrabberVB61.VideoSource = vs_ScreenRecording) And (Recording.chkScreenRecordWindow.Value = vbChecked) And (lngScreenRecordingWindow > 0) Then
      ' for screen recording of a window, this code will make it the top window before recording start;
      '  window handle was gathered by EnumerateWindows in OnEnumerateWindows
      ' (see demo procedures in VideoSource form btnScreenRecordingWindow and SetEnumerateWindows)
      SetWindowPos wenScreenRecordingWindow(lngScreenRecordingWindow - 1).WindowHandle, HWND_TOP, 0, 0, 0, 0, SWP_NOMOVE Or SWP_NOSIZE
   End If
   MainForm.VideoGrabberVB61.StartRecording
End Sub


Private Sub btnStopRecording_Click()
   MainForm.VideoGrabberVB61.StopRecording
End Sub

Private Sub btnVideoCompressorSettings_Click()
   MainForm.VideoGrabberVB61.ShowDialog (dlg_VideoCompressor)
End Sub

Private Sub cboAudioCompressors_Click()
   MainForm.VideoGrabberVB61.AudioCompressor = cboAudioCompressors.ListIndex
End Sub

Private Sub cboAudioFormats_Click()
   MainForm.VideoGrabberVB61.AudioFormat = cboAudioFormats.ListIndex
End Sub

Private Sub cboVideoCompressors_Click()
   MainForm.VideoGrabberVB61.VideoCompressor = cboVideoCompressors.ListIndex
End Sub

Private Sub chkAudioRecording_Click()
   MainForm.VideoGrabberVB61.AudioRecording = chkAudioRecording.Value = Checked
   MainForm.RefreshVideoDeviceControls
End Sub

Private Sub chkOpenDML_Click()
   MainForm.VideoGrabberVB61.AVIFormatOpenDML = chkOpenDML.Value = Checked
End Sub

Private Sub chkPreallocFile_Click()
   MainForm.VideoGrabberVB61.PreallocCapFileEnabled = chkPreallocFile.Value = Checked
End Sub

Private Sub chkPreserveNativeFormat_Click()
   MainForm.VideoGrabberVB61.RecordingInNativeFormat = chkPreserveNativeFormat.Value = Checked
End Sub

Private Sub chkRecordingCanPause_Click()
   MainForm.VideoGrabberVB61.RecordingCanPause = chkRecordingCanPause.Value = Checked
   MainForm.RefreshVideoDeviceControls
End Sub

Private Sub chkRecordingPauseCreatesNewFile_Click()
   MainForm.VideoGrabberVB61.RecordingPauseCreatesNewFile = chkRecordingPauseCreatesNewFile.Value = Checked
End Sub

Private Sub edtPreallocSize_Change()
   If IsNumeric(edtPreallocSize.Text) Then
      MainForm.VideoGrabberVB61.PreallocCapFileSizeInMB = edtPreallocSize.Text
    End If
End Sub

Private Sub rdgCompressMode1_Click()
   MainForm.VideoGrabberVB61.CompressionMode = cm_NoCompression
   MainForm.RefreshVideoDeviceControls
End Sub

Private Sub rdgCompressMode2_Click()
   MainForm.VideoGrabberVB61.CompressionMode = cm_CompressOnTheFly
   MainForm.RefreshVideoDeviceControls
End Sub

Private Sub rdgCompressMode3_Click()
   MainForm.VideoGrabberVB61.CompressionMode = cm_CompressAfterRecording
   MainForm.RefreshVideoDeviceControls
End Sub

Private Sub rdgCompressType1_Click()
   MainForm.VideoGrabberVB61.CompressionType = ct_Video
End Sub

Private Sub rdgCompressType2_Click()
   MainForm.VideoGrabberVB61.CompressionType = ct_Audio
End Sub

Private Sub rdgCompressType3_Click()
   MainForm.VideoGrabberVB61.CompressionType = ct_AudioVideo
End Sub

Private Sub rdgRecordingMethod1_Click()
   MainForm.VideoGrabberVB61.RecordingMethod = rm_AVI
   MainForm.RefreshVideoDeviceControls
End Sub

Private Sub rdgRecordingMethod2_Click()
   MainForm.VideoGrabberVB61.RecordingMethod = rm_ASF
   MainForm.RefreshVideoDeviceControls
End Sub

Private Sub rdgRecordingMethod3_Click()
   MainForm.VideoGrabberVB61.RecordingMethod = rm_SendToDV
   MainForm.RefreshVideoDeviceControls
End Sub

Private Sub rdgRecordingMethod4_Click()
   MainForm.VideoGrabberVB61.RecordingMethod = rm_MKV
   MainForm.RefreshVideoDeviceControls
End Sub

Private Sub rdgRecordingMethod5_Click()
   MainForm.VideoGrabberVB61.RecordingMethod = rm_FLV
   MainForm.RefreshVideoDeviceControls
End Sub

Private Sub rdgRecordingMetho6_Click()
   MainForm.VideoGrabberVB61.RecordingMethod = rm_MP4
   MainForm.RefreshVideoDeviceControls
End Sub




