VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form FrameGrabber 
   BorderStyle     =   0  'None
   ClientHeight    =   3060
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   13965
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   204
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   931
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame framTabs 
      BorderStyle     =   0  'None
      Height          =   2940
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   13575
      Begin VB.TextBox mmoFrameCaptureLog 
         BackColor       =   &H00C0C0C0&
         Height          =   2295
         Left            =   10680
         MultiLine       =   -1  'True
         TabIndex        =   42
         Text            =   "FrameGrabber.frx":0000
         Top             =   360
         Width           =   2895
      End
      Begin VB.Frame Frame11 
         Caption         =   "Zoom size"
         Height          =   1335
         Left            =   9480
         TabIndex        =   38
         Top             =   240
         Width           =   1095
         Begin VB.TextBox edtCaptureZoomSize 
            BackColor       =   &H00C0C0C0&
            Height          =   285
            Left            =   480
            TabIndex        =   40
            Text            =   "100%"
            Top             =   720
            Width           =   495
         End
         Begin VB.CommandButton btnResetCaptureZoomSize 
            Caption         =   "rst"
            Height          =   255
            Left            =   480
            TabIndex        =   39
            Top             =   360
            Width           =   495
         End
         Begin MSComctlLib.Slider tbrCaptureZoomSize 
            Height          =   1040
            Left            =   80
            TabIndex        =   41
            Top             =   195
            Width           =   280
            _ExtentX        =   503
            _ExtentY        =   1826
            _Version        =   393216
            Orientation     =   1
            Max             =   300
            TickFrequency   =   30
         End
      End
      Begin VB.Frame framAutoFileName 
         Caption         =   "file names are generated automatically on a..."
         Height          =   1200
         Left            =   0
         TabIndex        =   32
         Top             =   1700
         Width           =   3495
         Begin VB.Frame rdgAutoFileName 
            Height          =   945
            Left            =   120
            TabIndex        =   34
            Top             =   200
            Width           =   1695
            Begin VB.OptionButton rdgAutoFileName3 
               Caption         =   "counter from 0"
               Height          =   255
               Left            =   120
               TabIndex        =   47
               Tag             =   "2"
               Top             =   640
               Width           =   1480
            End
            Begin VB.OptionButton rdgAutoFileName1 
               Caption         =   "sequential basis"
               Height          =   255
               Left            =   120
               TabIndex        =   36
               Tag             =   "0"
               Top             =   160
               Width           =   1455
            End
            Begin VB.OptionButton rdgAutoFileName2 
               Caption         =   "time basis"
               Height          =   255
               Left            =   120
               TabIndex        =   35
               Tag             =   "1"
               Top             =   400
               Width           =   1455
            End
         End
         Begin VB.TextBox edtAVIAutoFilePrefix 
            Height          =   285
            Left            =   1920
            TabIndex        =   33
            Top             =   600
            Width           =   1095
         End
         Begin VB.Label Label1 
            Caption         =   "prefix for file names:"
            Height          =   255
            Left            =   1920
            TabIndex        =   37
            Top             =   360
            Width           =   1455
         End
      End
      Begin VB.Frame grbBurstMode 
         Caption         =   "burst-mode frame capture to... "
         Height          =   1420
         Left            =   3600
         TabIndex        =   22
         Top             =   1240
         Width           =   5775
         Begin VB.TextBox edtBurstInterval 
            Height          =   285
            Left            =   120
            TabIndex        =   29
            Text            =   "0"
            Top             =   1000
            Width           =   615
         End
         Begin VB.TextBox edtBurstCount 
            Height          =   285
            Left            =   120
            TabIndex        =   28
            Text            =   "3"
            Top             =   640
            Width           =   615
         End
         Begin VB.CommandButton btnBurstModeTBitmap 
            Caption         =   "TBitmap"
            Height          =   255
            Left            =   120
            TabIndex        =   27
            Top             =   260
            Width           =   975
         End
         Begin VB.CommandButton btnBurstModeBMPFile 
            Caption         =   "BMP file"
            Height          =   255
            Left            =   1200
            TabIndex        =   26
            Top             =   260
            Width           =   975
         End
         Begin VB.CommandButton btnBurstModeJPEGFile 
            Caption         =   "JPEG file"
            Height          =   255
            Left            =   2280
            TabIndex        =   25
            Top             =   260
            Width           =   975
         End
         Begin VB.CommandButton btnBurstModeStop 
            Caption         =   "Stop"
            Height          =   255
            Left            =   4440
            TabIndex        =   24
            Top             =   260
            Width           =   975
         End
         Begin VB.CommandButton btnBurstModeClipboard 
            Caption         =   "Clipboard"
            Height          =   255
            Left            =   3360
            TabIndex        =   23
            Top             =   260
            Width           =   975
         End
         Begin VB.Label Label35 
            Caption         =   "number of frames to skip for each frame captured"
            Height          =   255
            Left            =   840
            TabIndex        =   31
            Top             =   1020
            Width           =   3615
         End
         Begin VB.Label Label34 
            AutoSize        =   -1  'True
            Caption         =   "number of frames to capture  (0 = capture frames indefinitely)"
            Height          =   195
            Left            =   840
            TabIndex        =   30
            Top             =   660
            Width           =   4260
         End
      End
      Begin VB.Frame grbOneShot 
         Caption         =   "one-shot frame capture to..."
         Height          =   975
         Left            =   3600
         TabIndex        =   15
         Top             =   240
         Width           =   5775
         Begin VB.CommandButton btnOneShotJPEGFile 
            Caption         =   "JPEG file"
            Height          =   255
            Left            =   2280
            TabIndex        =   21
            Top             =   260
            Width           =   975
         End
         Begin VB.CommandButton btnOneShotBMPFile 
            Caption         =   "BMP file"
            Height          =   255
            Left            =   1200
            TabIndex        =   20
            Top             =   260
            Width           =   975
         End
         Begin VB.CommandButton btnOneShotTBitmap 
            Caption         =   "TBitmap"
            Height          =   255
            Left            =   120
            TabIndex        =   19
            Top             =   260
            Width           =   975
         End
         Begin VB.CheckBox chkUseThisFileName 
            Caption         =   "don't generate file name automatically, use instead:"
            Height          =   255
            Left            =   120
            TabIndex        =   18
            Top             =   600
            Width           =   4215
         End
         Begin VB.CommandButton btnOneShotClipboard 
            Caption         =   "Clipboard"
            Height          =   255
            Left            =   3360
            TabIndex        =   17
            Top             =   260
            Width           =   975
         End
         Begin VB.TextBox edtUseThisFileName 
            Enabled         =   0   'False
            Height          =   285
            Left            =   4080
            TabIndex        =   16
            Text            =   "CapFile01"
            Top             =   600
            Width           =   1575
         End
      End
      Begin VB.Frame rgdFrameGrabberFormat 
         Caption         =   "frame grabber format"
         Height          =   1215
         Left            =   1440
         TabIndex        =   8
         Top             =   240
         Width           =   2055
         Begin VB.OptionButton rgdFrameGrabberFormat6 
            Caption         =   "RGB8"
            Height          =   255
            Left            =   1050
            TabIndex        =   14
            Tag             =   "5"
            Top             =   840
            Width           =   975
         End
         Begin VB.OptionButton rgdFrameGrabberFormat5 
            Caption         =   "RGB555"
            Height          =   255
            Left            =   1050
            TabIndex        =   13
            Tag             =   "4"
            Top             =   540
            Width           =   975
         End
         Begin VB.OptionButton rgdFrameGrabberFormat4 
            Caption         =   "RGB565"
            Height          =   255
            Left            =   1050
            TabIndex        =   12
            Tag             =   "3"
            Top             =   240
            Width           =   975
         End
         Begin VB.OptionButton rgdFrameGrabberFormat3 
            Caption         =   "RGB24"
            Height          =   255
            Left            =   120
            TabIndex        =   11
            Tag             =   "2"
            Top             =   840
            Width           =   975
         End
         Begin VB.OptionButton rgdFrameGrabberFormat2 
            Caption         =   "RGB32"
            Height          =   255
            Left            =   120
            TabIndex        =   10
            Tag             =   "1"
            Top             =   540
            Width           =   975
         End
         Begin VB.OptionButton rgdFrameGrabberFormat1 
            Caption         =   "default"
            Height          =   255
            Left            =   120
            TabIndex        =   9
            Tag             =   "0"
            Top             =   240
            Width           =   975
         End
      End
      Begin VB.Frame rgdFrameGrabber 
         Caption         =   "Frame grabber"
         ForeColor       =   &H8000000D&
         Height          =   1455
         Left            =   0
         TabIndex        =   3
         Top             =   240
         Width           =   1335
         Begin VB.OptionButton rgdFrameGrabber4 
            Caption         =   "disabled"
            ForeColor       =   &H00C00000&
            Height          =   255
            Left            =   60
            TabIndex        =   7
            Tag             =   "3"
            Top             =   1080
            Width           =   1215
         End
         Begin VB.OptionButton rgdFrameGrabber3 
            Caption         =   "capture"
            ForeColor       =   &H00C00000&
            Height          =   255
            Left            =   60
            TabIndex        =   6
            Tag             =   "2"
            Top             =   800
            Width           =   1095
         End
         Begin VB.OptionButton rgdFrameGrabber2 
            Caption         =   "preview"
            ForeColor       =   &H00C00000&
            Height          =   255
            Left            =   60
            TabIndex        =   5
            Tag             =   "1"
            Top             =   520
            Width           =   1245
         End
         Begin VB.OptionButton rgdFrameGrabber1 
            Caption         =   "both streams"
            ForeColor       =   &H00C00000&
            Height          =   255
            Left            =   60
            TabIndex        =   4
            Tag             =   "0"
            Top             =   240
            Width           =   1215
         End
      End
      Begin VB.TextBox edtFrameGrabberCaptureHeight 
         Height          =   285
         Left            =   9480
         TabIndex        =   2
         Top             =   2360
         Width           =   1060
      End
      Begin VB.TextBox edtFrameGrabberCaptureWidth 
         Height          =   285
         Left            =   9480
         TabIndex        =   1
         Top             =   1820
         Width           =   1060
      End
      Begin VB.Label Label32 
         AutoSize        =   -1  'True
         Caption         =   "Frame grabber"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Left            =   0
         TabIndex        =   46
         Top             =   0
         Width           =   1230
      End
      Begin VB.Label Label33 
         AutoSize        =   -1  'True
         Caption         =   $"FrameGrabber.frx":000A
         Height          =   195
         Left            =   1680
         TabIndex        =   45
         Top             =   0
         Width           =   9465
      End
      Begin VB.Label Label2 
         Caption         =   "capture height:"
         Height          =   255
         Left            =   9480
         TabIndex        =   44
         Top             =   2140
         Width           =   1095
      End
      Begin VB.Label Label3 
         Caption         =   "capture width:"
         Height          =   255
         Left            =   9480
         TabIndex        =   43
         Top             =   1600
         Width           =   1095
      End
   End
End
Attribute VB_Name = "FrameGrabber"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit





Private Sub edtFrameGrabberCaptureHeight_Change()
    If IsNumeric(edtFrameGrabberCaptureHeight.Text) Then
        If Val(edtFrameGrabberCaptureHeight.Text) >= -1 Then
            MainForm.VideoGrabberVB61.FrameCaptureHeight = Val(edtFrameGrabberCaptureHeight.Text)
        End If
    End If
End Sub

Private Sub edtFrameGrabberCaptureWidth_Change()
    If IsNumeric(edtFrameGrabberCaptureWidth.Text) Then
        If Val(edtFrameGrabberCaptureWidth.Text) >= -1 Then
            MainForm.VideoGrabberVB61.FrameCaptureWidth = Val(edtFrameGrabberCaptureWidth.Text)
        End If
    End If
End Sub

Private Sub Form_Unload(Cancel As Integer)
   If Not MainForm.CanUnload Then
      Hide
      Cancel = True
   End If
End Sub

Private Sub btnBurstModeBMPFile_Click()
   MainForm.VideoGrabberVB61.BurstType = fc_BmpFile
   MainForm.VideoGrabberVB61.BurstMode = True
   ' The frame capture starts when BurstMode is set to True.
   ' If BurstCount = 0 the frame capture won"t stop.
   ' BMP file names will be generated automatically according to AutoFileName
   ' and AutoFilePrefix. They will be returned by the OnFrameCaptureCompleted event.
End Sub

Private Sub btnBurstModeClipboard_Click()
   MainForm.VideoGrabberVB61.BurstType = fc_Clipboard
   MainForm.VideoGrabberVB61.BurstMode = True
   ' The frame capture starts when BurstMode is set to True.
   ' If BurstCount = 0 the frame capture won"t stop.
   ' Captured frames will be returned by the OnFrameCaptureCompleted event.
End Sub

Private Sub btnBurstModeJPEGFile_Click()
   MainForm.VideoGrabberVB61.BurstType = fc_JpegFile
   MainForm.VideoGrabberVB61.BurstMode = True
   ' The frame capture starts when BurstMode is set to True.
   ' If BurstCount = 0 the frame capture won"t stop.
   ' JPEG file names will be generated automatically according to AutoFileName
   ' and AutoFilePrefix. They will be returned by the OnFrameCaptureCompleted event.
End Sub

Private Sub btnBurstModeStop_Click()
   MainForm.VideoGrabberVB61.BurstMode = False
End Sub

Private Sub btnBurstModeTBitmap_Click()
   MainForm.VideoGrabberVB61.BurstType = fc_TBitmap
   MainForm.VideoGrabberVB61.BurstMode = True
   ' The frame capture starts when BurstMode is set to True.
   ' If BurstCount = 0 the frame capture won"t stop.
   ' Captured frames will be returned by the OnFrameCaptureCompleted event.
End Sub

Private Sub btnOneShotBMPFile_Click()
   If chkUseThisFileName.Value = Checked Then
      MainForm.VideoGrabberVB61.CaptureFrameTo fc_BmpFile, edtUseThisFileName.Text
   Else
      MainForm.VideoGrabberVB61.CaptureFrameTo fc_BmpFile, ""
   End If
   ' note 1: passing an empty file name let TVideoGrabber generate it automatically in the StoragePath directory
   ' note 2: using CaptureFrameSyncTo instead of CaptureFrameTo waits for frame capture completion and returns true upon success

End Sub

Private Sub btnOneShotClipboard_Click()
   MainForm.VideoGrabberVB61.CaptureFrameTo fc_Clipboard, ""
End Sub

Private Sub btnOneShotJPEGFile_Click()
   If chkUseThisFileName.Value = Checked Then
    MainForm.VideoGrabberVB61.CaptureFrameTo fc_JpegFile, edtUseThisFileName.Text
   Else
      MainForm.VideoGrabberVB61.CaptureFrameTo fc_JpegFile, ""
   End If
   ' note 1: passing an empty file name let TVideoGrabber generate it automatically in the StoragePath directory
   ' note 2: using CaptureFrameSyncTo instead of CaptureFrameTo waits for frame capture completion and returns true upon success

End Sub

Private Sub btnOneShotTBitmap_Click()
   MainForm.VideoGrabberVB61.CaptureFrameTo fc_TBitmap, ""
End Sub

Private Sub btnResetCaptureZoomSize_Click()
   tbrCaptureZoomSize.Value = 100
   tbrCaptureZoomSize_Scroll
End Sub

Private Sub chkUseThisFileName_Click()
   edtUseThisFileName.Enabled = chkUseThisFileName.Value = Checked
End Sub

Private Sub edtAVIAutoFilePrefix_Change()
   MainForm.VideoGrabberVB61.AutoFilePrefix = edtAVIAutoFilePrefix.Text
End Sub

Private Sub edtBurstCount_Change()
    If IsNumeric(edtBurstCount.Text) Then
        MainForm.VideoGrabberVB61.BurstCount = edtBurstCount.Text
    End If
End Sub

Private Sub edtBurstInterval_Change()
    If IsNumeric(edtBurstInterval.Text) Then
        MainForm.VideoGrabberVB61.BurstInterval = edtBurstInterval.Text
    End If
End Sub

Private Sub rdgAutoFileName1_Click()
   MainForm.VideoGrabberVB61.AutoFileName = fn_Sequential
End Sub

Private Sub rdgAutoFileName2_Click()
   MainForm.VideoGrabberVB61.AutoFileName = fn_DateTime
End Sub

Private Sub rdgAutoFileName3_Click()
   MainForm.VideoGrabberVB61.AutoFileName = fn_Counter
End Sub

Private Sub rgdFrameGrabber1_Click()
   MainForm.VideoGrabberVB61.FrameGrabber = fg_BothStreams
   MainForm.RefreshVideoDeviceControls
End Sub

Private Sub rgdFrameGrabber2_Click()
   MainForm.VideoGrabberVB61.FrameGrabber = fg_PreviewStream
   MainForm.RefreshVideoDeviceControls
End Sub

Private Sub rgdFrameGrabber3_Click()
   MainForm.VideoGrabberVB61.FrameGrabber = fg_CaptureStream
   MainForm.RefreshVideoDeviceControls
End Sub

Private Sub rgdFrameGrabber4_Click()
   MainForm.VideoGrabberVB61.FrameGrabber = fg_Disabled
   MainForm.RefreshVideoDeviceControls
End Sub

Private Sub rgdFrameGrabberFormat1_Click()
   MainForm.VideoGrabberVB61.FrameGrabberRGBFormat = fgf_Default
End Sub

Private Sub rgdFrameGrabberFormat2_Click()
   MainForm.VideoGrabberVB61.FrameGrabberRGBFormat = fgf_RGB32
End Sub

Private Sub rgdFrameGrabberFormat3_Click()
   MainForm.VideoGrabberVB61.FrameGrabberRGBFormat = fgf_RGB24
End Sub

Private Sub rgdFrameGrabberFormat4_Click()
   MainForm.VideoGrabberVB61.FrameGrabberRGBFormat = fgf_RGB565
End Sub

Private Sub rgdFrameGrabberFormat5_Click()
   MainForm.VideoGrabberVB61.FrameGrabberRGBFormat = fgf_RGB555
End Sub

Private Sub rgdFrameGrabberFormat6_Click()
   MainForm.VideoGrabberVB61.FrameGrabberRGBFormat = fgf_RGB8
End Sub

Private Sub tbrCaptureZoomSize_Scroll()
   MainForm.VideoGrabberVB61.FrameCaptureZoomSize = tbrCaptureZoomSize.Value
   edtCaptureZoomSize.Text = Str(tbrCaptureZoomSize.Value) + "%"
End Sub
