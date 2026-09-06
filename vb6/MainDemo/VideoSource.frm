VERSION 5.00
Begin VB.Form VideoSource 
   BorderStyle     =   0  'None
   ClientHeight    =   3345
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   14010
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   223
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   934
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   Begin VB.Timer timActivate 
      Enabled         =   0   'False
      Interval        =   10
      Left            =   0
      Top             =   2760
   End
   Begin VB.Frame framTabs 
      BorderStyle     =   0  'None
      Height          =   2700
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   13575
      Begin VB.Frame grbVsScreenRecording 
         Caption         =   "video source = screen recording"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   915
         Left            =   5280
         TabIndex        =   53
         Top             =   1800
         Width           =   6375
         Begin VB.CheckBox chkScreenRecordingWindow 
            Caption         =   "exact"
            Height          =   255
            Left            =   5520
            TabIndex        =   59
            Top             =   480
            Width           =   735
         End
         Begin VB.CheckBox chkScreenRecordingWithCursor 
            Caption         =   "with cursor"
            Height          =   375
            Left            =   120
            TabIndex        =   58
            Top             =   360
            Width           =   855
         End
         Begin VB.CommandButton btnMonitorNumber 
            Caption         =   "info?"
            Height          =   320
            Left            =   1560
            TabIndex        =   57
            Top             =   480
            Width           =   615
         End
         Begin VB.TextBox edtMonitorNumber 
            Height          =   320
            Left            =   1080
            TabIndex        =   56
            Top             =   480
            Width           =   495
         End
         Begin VB.TextBox edtScreenRecordingWindow 
            Height          =   320
            Left            =   2400
            TabIndex        =   55
            Text            =   "TVideoGrabber demo"
            Top             =   480
            Width           =   2655
         End
         Begin VB.CommandButton btnScreenRecordingWindow 
            Caption         =   "ok"
            Height          =   320
            Left            =   5040
            TabIndex        =   54
            Top             =   480
            Width           =   375
         End
         Begin VB.Label lblEnumerateWindows 
            Alignment       =   2  'Center
            ForeColor       =   &H80000010&
            Height          =   195
            Left            =   5960
            TabIndex        =   63
            Top             =   240
            Width           =   340
         End
         Begin VB.Label Label1 
            AutoSize        =   -1  'True
            Caption         =   "use this window (or an empty string for full screen)"
            Height          =   195
            Index           =   38
            Left            =   2400
            TabIndex        =   60
            Top             =   240
            Width           =   3495
         End
         Begin VB.Label Label1 
            Caption         =   "monitor number"
            Height          =   255
            Index           =   37
            Left            =   1080
            TabIndex        =   61
            Top             =   240
            Width           =   1455
         End
      End
      Begin VB.Frame Frame1 
         Caption         =   "VIDEO SOURCE"
         Height          =   680
         Index           =   0
         Left            =   0
         TabIndex        =   51
         Top             =   0
         Width           =   2415
         Begin VB.ComboBox cboVideoSource 
            Height          =   315
            Left            =   120
            TabIndex        =   52
            Top             =   260
            Width           =   2175
         End
      End
      Begin VB.Frame grbPreview 
         Caption         =   "Preview"
         Height          =   675
         Left            =   2520
         TabIndex        =   48
         Top             =   0
         Width           =   2055
         Begin VB.CommandButton btnStopPreview 
            Caption         =   "stop"
            Height          =   360
            Left            =   1080
            TabIndex        =   49
            Top             =   220
            Width           =   855
         End
         Begin VB.CommandButton btnStartPreview 
            Height          =   360
            Left            =   120
            TabIndex        =   50
            Top             =   220
            Width           =   855
            ForeColor       =   255
            Caption         =   "start"
            Size            =   "1508;635"
            FontEffects     =   1073741825
            FontHeight      =   165
            FontCharSet     =   0
            FontPitchAndFamily=   2
            ParagraphAlign  =   3
            FontWeight      =   700
         End
      End
      Begin VB.Frame grbFrameRate 
         Caption         =   "Frame rate"
         Height          =   675
         Left            =   4680
         TabIndex        =   44
         Top             =   0
         Width           =   1575
         Begin VB.TextBox edtFrameRate 
            Height          =   285
            Left            =   120
            TabIndex        =   47
            Text            =   "0"
            Top             =   240
            Width           =   495
         End
         Begin VB.CommandButton btnFrameRateHelp 
            Caption         =   "?"
            Height          =   255
            Left            =   1080
            TabIndex        =   46
            Top             =   240
            Width           =   375
         End
         Begin VB.CommandButton btnFrameRate 
            Caption         =   "ok"
            Height          =   255
            Left            =   720
            TabIndex        =   45
            Top             =   240
            Width           =   375
         End
      End
      Begin VB.Frame grbVsVideoCaptureDevice 
         Caption         =   "video source = video capture device"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   1125
         Left            =   0
         TabIndex        =   31
         Top             =   690
         Width           =   8535
         Begin VB.Frame Frame1 
            Caption         =   "multiplexed inputs"
            Height          =   855
            Index           =   1
            Left            =   6240
            TabIndex        =   37
            Top             =   120
            Width           =   2175
            Begin VB.CheckBox chkMultiplexedInputEmulation 
               Caption         =   "emulation"
               Height          =   255
               Left            =   120
               TabIndex        =   39
               Top             =   480
               Width           =   1935
            End
            Begin VB.CheckBox chk4InputsLayout 
               Caption         =   "enable 4 inputs layout"
               Height          =   255
               Left            =   120
               TabIndex        =   38
               Top             =   240
               Width           =   1935
            End
         End
         Begin VB.ComboBox cboVideoDevices 
            Height          =   315
            Left            =   120
            TabIndex        =   36
            Text            =   "SELECT FIRST A VIDEO CAPTURE DEVICE IN THIS LIST"
            Top             =   230
            Width           =   5895
         End
         Begin VB.ComboBox cboVideoInputs 
            Height          =   315
            Left            =   120
            TabIndex        =   35
            Top             =   740
            Width           =   1335
         End
         Begin VB.ComboBox cboVideoSizes 
            Height          =   315
            Left            =   1560
            TabIndex        =   34
            Top             =   740
            Width           =   1215
         End
         Begin VB.ComboBox cboVideoSubtypes 
            Height          =   315
            Left            =   2880
            TabIndex        =   33
            Top             =   740
            Width           =   1335
         End
         Begin VB.ComboBox cboAnalogVideoStandard 
            Height          =   315
            Left            =   4320
            TabIndex        =   32
            Top             =   740
            Width           =   1695
         End
         Begin VB.Label Label1 
            Caption         =   "video input"
            Height          =   255
            Index           =   1
            Left            =   120
            TabIndex        =   43
            Top             =   560
            Width           =   975
         End
         Begin VB.Label Label1 
            AutoSize        =   -1  'True
            Caption         =   "video subtype"
            Height          =   195
            Index           =   11
            Left            =   2880
            TabIndex        =   42
            Top             =   560
            Width           =   990
         End
         Begin VB.Label Label1 
            AutoSize        =   -1  'True
            Caption         =   "video size"
            Height          =   195
            Index           =   22
            Left            =   1560
            TabIndex        =   41
            Top             =   560
            Width           =   705
         End
         Begin VB.Label Label1 
            Caption         =   "analog video standard"
            Height          =   255
            Index           =   33
            Left            =   4320
            TabIndex        =   40
            Top             =   560
            Width           =   1815
         End
      End
      Begin VB.Frame grbVsFileOrUrl 
         Caption         =   "video source = file or URL"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   915
         Left            =   0
         TabIndex        =   23
         Top             =   1800
         Width           =   5175
         Begin VB.TextBox edtSourceFileOrUrl_Password 
            Height          =   285
            Left            =   2880
            TabIndex        =   28
            Top             =   560
            Width           =   855
         End
         Begin VB.TextBox edtSourceFileOrUrl_UserName 
            Height          =   285
            Left            =   1080
            TabIndex        =   27
            Top             =   560
            Width           =   855
         End
         Begin VB.CommandButton btnSelectFileOrUrl 
            Caption         =   "open"
            Height          =   255
            Left            =   120
            TabIndex        =   26
            Top             =   220
            Width           =   855
         End
         Begin VB.TextBox edtVideoSourceFileOrUrl 
            Height          =   285
            Left            =   1080
            TabIndex        =   25
            Text            =   "mms://www.datastead.com/demo/demo.wmv"
            Top             =   220
            Width           =   3975
         End
         Begin VB.CommandButton btnDemoUrl 
            Caption         =   "demo URL?"
            Height          =   280
            Left            =   3840
            TabIndex        =   24
            Top             =   560
            Width           =   1215
         End
         Begin VB.Label Label1 
            Alignment       =   1  'Right Justify
            Caption         =   "user name:"
            Height          =   255
            Index           =   42
            Left            =   160
            TabIndex        =   30
            Top             =   580
            Width           =   855
         End
         Begin VB.Label Label1 
            Alignment       =   1  'Right Justify
            Caption         =   "password:"
            Height          =   255
            Index           =   43
            Left            =   1960
            TabIndex        =   29
            Top             =   580
            Width           =   855
         End
      End
      Begin VB.Frame grbPreferredVideoSizes 
         Caption         =   "preferred video sizes (examples)"
         Height          =   1575
         Left            =   8640
         TabIndex        =   10
         Top             =   240
         Width           =   3015
         Begin VB.OptionButton rdgPreferredVideoSize1 
            Caption         =   "device sizes"
            Height          =   195
            Left            =   120
            TabIndex        =   22
            Tag             =   "0"
            Top             =   230
            Value           =   -1  'True
            Width           =   1455
         End
         Begin VB.OptionButton rdgPreferredVideoSize2 
            Caption         =   "88x60"
            Height          =   195
            Left            =   120
            TabIndex        =   21
            Tag             =   "1"
            Top             =   450
            Width           =   1455
         End
         Begin VB.OptionButton rdgPreferredVideoSize3 
            Caption         =   "88x72"
            Height          =   195
            Left            =   120
            TabIndex        =   20
            Tag             =   "2"
            Top             =   670
            Width           =   1455
         End
         Begin VB.OptionButton rdgPreferredVideoSize4 
            Caption         =   "180x120"
            Height          =   195
            Left            =   120
            TabIndex        =   19
            Tag             =   "3"
            Top             =   890
            Width           =   1455
         End
         Begin VB.OptionButton rdgPreferredVideoSize5 
            Caption         =   "180x144"
            Height          =   195
            Left            =   120
            TabIndex        =   18
            Tag             =   "4"
            Top             =   1110
            Width           =   1455
         End
         Begin VB.OptionButton rdgPreferredVideoSize6 
            Caption         =   "320x240"
            Height          =   195
            Left            =   120
            TabIndex        =   17
            Tag             =   "5"
            Top             =   1330
            Width           =   1455
         End
         Begin VB.OptionButton rdgPreferredVideoSize7 
            Caption         =   "352x288"
            Height          =   195
            Left            =   1560
            TabIndex        =   16
            Tag             =   "6"
            Top             =   230
            Width           =   1095
         End
         Begin VB.OptionButton rdgPreferredVideoSize10 
            Caption         =   "640x480"
            Height          =   195
            Left            =   1560
            TabIndex        =   15
            Tag             =   "9"
            Top             =   450
            Width           =   1100
         End
         Begin VB.OptionButton rdgPreferredVideoSize11 
            Caption         =   "720x480"
            Height          =   195
            Left            =   1560
            TabIndex        =   14
            Tag             =   "10"
            Top             =   670
            Width           =   1100
         End
         Begin VB.CheckBox chkStretchPreferredVideoSize 
            Alignment       =   1  'Right Justify
            Caption         =   "stretch"
            Height          =   195
            Left            =   2040
            TabIndex        =   13
            Top             =   1320
            Width           =   855
         End
         Begin VB.OptionButton rdgPreferredVideoSize12 
            Caption         =   "720x576"
            Height          =   195
            Left            =   1560
            TabIndex        =   12
            Tag             =   "11"
            Top             =   890
            Width           =   1100
         End
         Begin VB.OptionButton rdgPreferredVideoSize13 
            Caption         =   "768x576"
            Height          =   195
            Left            =   1560
            TabIndex        =   11
            Tag             =   "12"
            Top             =   1110
            Width           =   1100
         End
      End
      Begin VB.Frame grbVideoDevicesDialogs 
         Caption         =   "video device dialogs"
         Height          =   2415
         Left            =   11760
         TabIndex        =   3
         Top             =   240
         Width           =   1815
         Begin VB.CommandButton btnDeviceDialog 
            Caption         =   "device"
            Height          =   255
            Left            =   240
            TabIndex        =   9
            Top             =   240
            Width           =   1335
         End
         Begin VB.CommandButton btnStreamDialog 
            Caption         =   "stream"
            Height          =   255
            Left            =   240
            TabIndex        =   8
            Top             =   600
            Width           =   1335
         End
         Begin VB.CommandButton btnCameraControlDialog 
            Caption         =   "camera control"
            Height          =   255
            Left            =   240
            TabIndex        =   7
            Top             =   960
            Width           =   1335
         End
         Begin VB.CommandButton btnVideoQualityDialog 
            Caption         =   "video quality"
            Height          =   255
            Left            =   240
            TabIndex        =   6
            Top             =   1320
            Width           =   1335
         End
         Begin VB.CommandButton btnVideoControlDialog 
            Caption         =   "video control"
            Height          =   255
            Left            =   240
            TabIndex        =   5
            Top             =   1680
            Width           =   1335
         End
         Begin VB.CommandButton btnSpecialControlDialog 
            Caption         =   "special controls"
            Height          =   255
            Left            =   240
            TabIndex        =   4
            Top             =   2040
            Width           =   1335
         End
      End
      Begin VB.CheckBox chkAutoRefreshPreview 
         Caption         =   "Auto refresh preview"
         Height          =   255
         Left            =   6480
         TabIndex        =   2
         Top             =   260
         Width           =   1815
      End
      Begin VB.CheckBox chkReduceDVFrameRate 
         Caption         =   "half DV frame rate"
         Height          =   255
         Left            =   6480
         TabIndex        =   1
         Top             =   480
         Width           =   1695
      End
      Begin VB.Label Label1 
         Caption         =   "to programmatically select an item by name in a list, use the FindIndexInListByName function"
         ForeColor       =   &H80000010&
         Height          =   255
         Index           =   4
         Left            =   6960
         TabIndex        =   62
         Top             =   0
         Width           =   6495
      End
   End
End
Attribute VB_Name = "VideoSource"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub btnMonitorNumber_Click()
    
    MsgBox "-1 = full desktop, 0 = 1st monitor, 1 = 2nd monitor, etc...", _
            vbOKOnly, _
            "DataStead TVideoGrabber VB 6 OCX Demo"
    
End Sub

Private Sub btnScreenRecordingWindow_Click()
    
    MainForm.VideoGrabberVB61.SetWindowRecordingByName edtScreenRecordingWindow.Text, (chkScreenRecordingWindow.Value = 1)
    '
    ' recording window may be designated by name, class or handle by calling EnumerateWindows, which
    '  causes visible window info to be returned in the OnEnumerateWindows event
    ' recording window may then be set by handle rather than name with SetWindowRecordingByHandle
    '
    MainForm.SetEnumerateWindows edtScreenRecordingWindow.Text, (chkScreenRecordingWindow.Value = 1)
    If strScreenRecordingWindow <> "" Then
        MainForm.VideoGrabberVB61.EnumerateWindows
    End If
    
End Sub

Public Sub Form_Activate()
    If MainForm.VideoGrabberVB61.VideoDevice = -1 Then
        cboVideoDevices.Text = "SELECT FIRST A VIDEO CAPTURE DEVICE IN THIS LIST"
    End If
End Sub

Private Sub Form_Load()
    
    With framTabs
        Me.Width = .Width
        Me.Height = .Height
    End With
    timActivate.Enabled = True
    
End Sub

Private Sub Form_Unload(Cancel As Integer)
   If Not MainForm.CanUnload Then
      Hide
      Cancel = True
   End If
End Sub

Private Sub btnStartPreview_Click()
   MainForm.VideoGrabberVB61.StartPreview
End Sub

Private Sub btnStopPreview_Click()
   MainForm.VideoGrabberVB61.StopPreview
End Sub

Private Sub btnDeviceDialog_Click()
   MainForm.VideoGrabberVB61.ShowDialog (dlg_VideoDevice)
   MainForm.RefreshVideoDeviceControls
End Sub

Private Sub btnStreamDialog_Click()
   ' WARNING: USUALLY, THIS DIALOG ALLOWS TO CHANGE ONLY 1 PARAMETER AT THE SAME TIME
   MainForm.VideoGrabberVB61.ShowDialog (dlg_StreamConfig)
   MainForm.VideoGrabberVB61_OnVideoDeviceSelected   ' to refresh the controls, if required
End Sub

Private Sub cboVideoSource_Click()
   MainForm.VideoGrabberVB61.VideoSource = cboVideoSource.ListIndex
   IPCamera.RefreshIPCameraControls
   Recording.RefreshRecordingControls
   VideoFromJPEGsorBitmaps.RefreshVideoFromJPEGsOrBitmapsControls
End Sub

Private Sub cboAnalogVideoStandard_Click()
   MainForm.VideoGrabberVB61.AnalogVideoStandard = cboAnalogVideoStandard.ListIndex
End Sub

Public Sub cboVideoDevices_Click()
   MainForm.VideoGrabberVB61.VideoDevice = cboVideoDevices.ListIndex
   ' when selecting another video device, the OnVideoDeviceSelected event occurs.
   ' be sure to refresh all your device-dependent controls from this event.
End Sub

Private Sub cboVideoInputs_Click()
   MainForm.VideoGrabberVB61.VideoInput = cboVideoInputs.ListIndex
End Sub

Private Sub cboVideoSizes_Click()
   MainForm.VideoGrabberVB61.VideoSize = cboVideoSizes.ListIndex
End Sub

Private Sub cboVideoSubtypes_Click()
   MainForm.VideoGrabberVB61.VideoSubtype = cboVideoSubtypes.ListIndex
End Sub

Private Sub chk4InputsLayout_Click()
   If chk4InputsLayout.Value = Checked Then
      MainForm.VideoGrabberVB61.MultiplexedRole = mr_MultiplexedMosaic4
   Else
      MainForm.VideoGrabberVB61.MultiplexedRole = mr_NotMultiplexed
   End If
End Sub

Private Sub chkMultiplexedInputEmulation_Click()
   MainForm.VideoGrabberVB61.MultiplexedInputEmulation = chkMultiplexedInputEmulation.Value = Checked
End Sub

Private Sub chkAutoRefreshPreview_Click()
   MainForm.VideoGrabberVB61.AutoRefreshPreview = -chkAutoRefreshPreview.Value
End Sub

Private Sub chkReduceDVFrameRate_Click()
   MainForm.VideoGrabberVB61.DVReduceFrameRate = chkReduceDVFrameRate.Value = Checked
End Sub

Private Sub rdgPreferredVideoSize1_Click()
    MainForm.VideoGrabberVB61.UseNearestVideoSize 0, 0, chkStretchPreferredVideoSize.Value = Checked ' disables the nearest size feature, uses the device's VideoSize index in the VideoSizes list
    cboVideoSizes.Enabled = True
End Sub

Private Sub rdgPreferredVideoSize2_Click()
    MainForm.VideoGrabberVB61.UseNearestVideoSize 88, 60, chkStretchPreferredVideoSize.Value = Checked
    cboVideoSizes.Enabled = False
End Sub

Private Sub rdgPreferredVideoSize3_Click()
    MainForm.VideoGrabberVB61.UseNearestVideoSize 88, 72, chkStretchPreferredVideoSize.Value = Checked
    cboVideoSizes.Enabled = False
End Sub

Private Sub rdgPreferredVideoSize4_Click()
    MainForm.VideoGrabberVB61.UseNearestVideoSize 180, 120, chkStretchPreferredVideoSize.Value = Checked
    cboVideoSizes.Enabled = False
End Sub

Private Sub rdgPreferredVideoSize5_Click()
    MainForm.VideoGrabberVB61.UseNearestVideoSize 180, 144, chkStretchPreferredVideoSize.Value = Checked
    cboVideoSizes.Enabled = False
End Sub

Private Sub rdgPreferredVideoSize6_Click()
    MainForm.VideoGrabberVB61.UseNearestVideoSize 320, 240, chkStretchPreferredVideoSize.Value = Checked
    cboVideoSizes.Enabled = False
End Sub

Private Sub rdgPreferredVideoSize7_Click()
    MainForm.VideoGrabberVB61.UseNearestVideoSize 352, 288, chkStretchPreferredVideoSize.Value = Checked
    cboVideoSizes.Enabled = False
End Sub

Private Sub rdgPreferredVideoSize8_Click()
    MainForm.VideoGrabberVB61.UseNearestVideoSize 360, 240, chkStretchPreferredVideoSize.Value = Checked
    cboVideoSizes.Enabled = False
End Sub

Private Sub rdgPreferredVideoSize9_Click()
    MainForm.VideoGrabberVB61.UseNearestVideoSize 360, 288, chkStretchPreferredVideoSize.Value = Checked
    cboVideoSizes.Enabled = False
End Sub

Private Sub rdgPreferredVideoSize10_Click()
    MainForm.VideoGrabberVB61.UseNearestVideoSize 640, 480, chkStretchPreferredVideoSize.Value = Checked
    cboVideoSizes.Enabled = False
End Sub

Private Sub rdgPreferredVideoSize11_Click()
    MainForm.VideoGrabberVB61.UseNearestVideoSize 720, 480, chkStretchPreferredVideoSize.Value = Checked
    cboVideoSizes.Enabled = False
End Sub

Private Sub rdgPreferredVideoSize12_Click()
    MainForm.VideoGrabberVB61.UseNearestVideoSize 720, 576, chkStretchPreferredVideoSize.Value = Checked
    cboVideoSizes.Enabled = False
End Sub

Private Sub rdgPreferredVideoSize13_Click()
    MainForm.VideoGrabberVB61.UseNearestVideoSize 768, 576, chkStretchPreferredVideoSize.Value = Checked
    cboVideoSizes.Enabled = False
End Sub

Private Sub btnFrameRate_Click()
   Dim Value As Double
   
   MainForm.VideoGrabberVB61.FrameRate = VideoSource.edtFrameRate.Text

   If MainForm.VideoGrabberVB61.CurrentState = cs_Preview Then
      AddLog MainForm.mmoLog, "current frame rate: " + Format(MainForm.VideoGrabberVB61.CurrentFrameRate, "0.00") + " fps."
   End If
End Sub

Private Sub btnFrameRateHelp_Click()
    
    MsgBox """0"" means that the default frame rate of the device will be used." & vbCrLf & _
            "After the OnPreviewStarted or OnRecordingStarted event occurs," & vbCrLf & _
            "its value is available in the CurrentFrameRate property.", _
            vbOKOnly, _
            "DataStead TVideoGrabber VB 6 OCX Demo"
    
End Sub

Private Sub btnSelectFileOrUrl_Click()
    MainForm.dlgOpen.CancelError = True
    MainForm.dlgOpen.Filter = OPEN_MEDIA_FILES
    On Error GoTo Cancelled
    MainForm.dlgOpen.ShowOpen
    edtVideoSourceFileOrUrl.Text = MainForm.dlgOpen.FileName
Cancelled:
End Sub

Private Sub btnDemoUrl_Click()
    edtVideoSourceFileOrUrl.Text = "mms://www.datastead.com/demo/demo.wmv"
End Sub

Private Sub chkScreenRecordingWithCursor_Click()
   MainForm.VideoGrabberVB61.ScreenRecordingWithCursor = (chkScreenRecordingWithCursor = Checked)
End Sub

Private Sub edtSourceFileOrUrl_Password_Change()
   MainForm.VideoGrabberVB61.SetAuthentication at_StreamingUrl, edtSourceFileOrUrl_UserName.Text, edtSourceFileOrUrl_Password.Text
End Sub

Private Sub edtSourceFileOrUrl_UserName_Change()
   MainForm.VideoGrabberVB61.SetAuthentication at_StreamingUrl, edtSourceFileOrUrl_UserName.Text, edtSourceFileOrUrl_Password.Text
End Sub

Private Sub edtVideoSourceFileOrUrl_Change()
   MainForm.VideoGrabberVB61.VideoSource_FileOrURL = edtVideoSourceFileOrUrl.Text
End Sub


Private Sub timActivate_Timer()
    timActivate.Enabled = False
    Form_Activate
End Sub

