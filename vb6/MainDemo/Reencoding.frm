VERSION 5.00
Begin VB.Form Reencoding 
   BorderStyle     =   0  'None
   Caption         =   "Reencoding"
   ClientHeight    =   3180
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   13935
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   212
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   929
   ShowInTaskbar   =   0   'False
   Begin VB.Frame framTabs 
      BorderStyle     =   0  'None
      Height          =   2700
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   13575
      Begin VB.TextBox edtSourceVideoClip 
         Height          =   360
         Left            =   3840
         TabIndex        =   29
         Text            =   "http://www.datastead.com/demo/demo.wmv"
         Top             =   0
         Width           =   3615
      End
      Begin VB.TextBox edtDestinationVideoClip 
         Height          =   360
         Left            =   3840
         TabIndex        =   28
         Text            =   "c:\TVideoGrabberEval\capture.wmv"
         Top             =   420
         Width           =   3615
      End
      Begin VB.Frame grbStartStopTime 
         Caption         =   "START / STOP (optional)  "
         Height          =   1750
         Left            =   0
         TabIndex        =   13
         Top             =   920
         Width           =   7455
         Begin VB.CommandButton btnDuration 
            Caption         =   "source duration and/or frame count?"
            Height          =   340
            Left            =   120
            TabIndex        =   20
            Top             =   520
            Width           =   3495
         End
         Begin VB.TextBox edtStopTime 
            Height          =   340
            Left            =   3720
            TabIndex        =   19
            Top             =   1320
            Width           =   1455
         End
         Begin VB.TextBox edtStartTime 
            Height          =   340
            Left            =   3720
            TabIndex        =   18
            Top             =   920
            Width           =   1455
         End
         Begin VB.TextBox edtDuration 
            BackColor       =   &H00C0C0C0&
            Height          =   340
            Left            =   3720
            TabIndex        =   17
            Top             =   520
            Width           =   1455
         End
         Begin VB.TextBox edtStartFrame 
            Height          =   340
            Left            =   5760
            TabIndex        =   16
            Top             =   920
            Width           =   1335
         End
         Begin VB.TextBox edtStopFrame 
            Height          =   340
            Left            =   5760
            TabIndex        =   15
            Top             =   1320
            Width           =   1335
         End
         Begin VB.TextBox edtFrameCount 
            BackColor       =   &H00C0C0C0&
            Height          =   340
            Left            =   5760
            TabIndex        =   14
            Top             =   520
            Width           =   1335
         End
         Begin VB.Label Label36 
            AutoSize        =   -1  'True
            Caption         =   "Times are expressed in 100ns units, e.g. 2 seconds = 20000000"
            ForeColor       =   &H00800000&
            Height          =   195
            Left            =   2280
            TabIndex        =   27
            Top             =   0
            Width           =   4515
         End
         Begin VB.Label Label35 
            AutoSize        =   -1  'True
            Caption         =   "STOP position (-1 = end of source clip) :"
            Height          =   195
            Left            =   855
            TabIndex        =   26
            Top             =   1365
            Width           =   2820
         End
         Begin VB.Label Label34 
            AutoSize        =   -1  'True
            Caption         =   "START position (-1 = beginning of source clip) :"
            Height          =   195
            Left            =   345
            TabIndex        =   25
            Top             =   960
            Width           =   3345
         End
         Begin VB.Label Label1 
            AutoSize        =   -1  'True
            Caption         =   "SPECIFY"
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
            Index           =   0
            Left            =   2520
            TabIndex        =   24
            Top             =   285
            Width           =   780
         End
         Begin VB.Label Label1 
            AutoSize        =   -1  'True
            Caption         =   "the TIME (in 100ns units)"
            Height          =   195
            Index           =   1
            Left            =   3360
            TabIndex        =   23
            Top             =   285
            Width           =   1770
         End
         Begin VB.Label Label1 
            AutoSize        =   -1  'True
            Caption         =   "OR"
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
            Index           =   2
            Left            =   5205
            TabIndex        =   22
            Top             =   285
            Width           =   285
         End
         Begin VB.Label Label1 
            AutoSize        =   -1  'True
            Caption         =   "the FRAME NUMBER"
            Height          =   195
            Index           =   3
            Left            =   5520
            TabIndex        =   21
            Top             =   285
            Width           =   1575
         End
      End
      Begin VB.Frame grbReencodingSettings 
         Caption         =   "reencoding settings"
         Height          =   1960
         Left            =   7560
         TabIndex        =   6
         Top             =   0
         Width           =   6015
         Begin VB.CheckBox chkUseCurrentAudioCompressor 
            Caption         =   "use the current audio compressor (selected in the ""recording"" tab)"
            Height          =   255
            Left            =   160
            TabIndex        =   12
            Top             =   1230
            Width           =   5175
         End
         Begin VB.CheckBox chkIncludeVideoStream 
            Caption         =   "includes the video stream"
            Height          =   255
            Left            =   160
            TabIndex        =   11
            Top             =   610
            Width           =   2175
         End
         Begin VB.CheckBox chkUseCurrentVideoCompressor 
            Caption         =   "use the current video compressor (selected in the ""recording"" tab)"
            Height          =   255
            Left            =   160
            TabIndex        =   10
            Top             =   920
            Width           =   5175
         End
         Begin VB.CheckBox chkIncludeAudioStream 
            Caption         =   "includes the audio stream"
            Height          =   255
            Left            =   2640
            TabIndex        =   9
            Top             =   610
            Width           =   2175
         End
         Begin VB.CheckBox chkUseFrameGrabber 
            Caption         =   "use the frame grabber (allows text/graphics overlays, video processing...)"
            Height          =   255
            Left            =   160
            TabIndex        =   8
            Top             =   1540
            Width           =   5500
         End
         Begin VB.CheckBox chkWMVOutput 
            Caption         =   "WMV output  (Windows Media Video)"
            Height          =   255
            Left            =   160
            TabIndex        =   7
            Top             =   300
            Width           =   5175
         End
      End
      Begin VB.Frame rdgReencodingMethod 
         Caption         =   "reencoding method"
         Height          =   640
         Left            =   7560
         TabIndex        =   3
         Top             =   2020
         Width           =   2775
         Begin VB.OptionButton rdgReencodingMethod2 
            Caption         =   "ASF (WMV)"
            Height          =   195
            Left            =   1440
            TabIndex        =   5
            Tag             =   "1"
            Top             =   280
            Width           =   1215
         End
         Begin VB.OptionButton rdgReencodingMethod1 
            Caption         =   "AVI / MPEG"
            Height          =   195
            Left            =   120
            TabIndex        =   4
            Tag             =   "0"
            Top             =   280
            Width           =   1215
         End
      End
      Begin VB.CommandButton btnStartReencoding 
         Caption         =   "Start"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   320
         Left            =   10800
         TabIndex        =   2
         Top             =   2160
         Width           =   1215
      End
      Begin VB.CommandButton btnStopReencoding 
         Caption         =   "Stop"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   320
         Left            =   12120
         TabIndex        =   1
         Top             =   2160
         Width           =   1215
      End
      Begin VB.Label Label2 
         Caption         =   "Reencoding"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   0
         TabIndex        =   33
         Top             =   0
         Width           =   1215
      End
      Begin VB.CommandButton btnSourceVideoClip 
         Height          =   360
         Left            =   1560
         TabIndex        =   32
         Top             =   0
         Width           =   2175
         Caption         =   "  source video clip..."
         PicturePosition =   327683
         Size            =   "3836;635"
         Picture         =   "Reencoding.frx":0000
         FontHeight      =   165
         FontCharSet     =   0
         FontPitchAndFamily=   2
         ParagraphAlign  =   3
      End
      Begin VB.Label Label32 
         AutoSize        =   -1  'True
         Caption         =   "(extension will be "".wmv"" if WMV output enabled)"
         Height          =   195
         Left            =   240
         TabIndex        =   31
         Top             =   645
         Width           =   3495
      End
      Begin VB.Label Label33 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         Caption         =   "file name for the new video clip:"
         Height          =   195
         Left            =   1515
         TabIndex        =   30
         Top             =   405
         Width           =   2235
      End
   End
End
Attribute VB_Name = "Reencoding"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit





Private Sub edtStartTime_Change()
'    MainForm.VideoGrabberVB61.Reencoding_WMVOutput
End Sub

Private Sub Form_Unload(Cancel As Integer)
   If Not MainForm.CanUnload Then
      Hide
      Cancel = True
   End If
End Sub

Private Sub btnDuration_Click()
    Dim Duration As Double
    Dim FrameCount As Double
'    Dim VideoWidth As Long
'    Dim VideoHeight As Long
'    Dim VideoFrameRateFps As Long
'    Dim AvgBitRate As Long
'    Dim AudioChannels As Long
'    Dim AudioSamplesPerSec As Long
'    Dim AudioBitsPerSample As Long
'    Dim VideoCodec As String
'    Dim AudioCodec As String
    
    If MainForm.VideoGrabberVB61.AVIDuration(edtSourceVideoClip.Text, Duration, FrameCount) Then
'    If MainForm.VideoGrabberVB61.AVIInfo(edtSourceVideoClip.Text, Duration, FrameCount, VideoWidth, VideoHeight, VideoFrameRateFps, AvgBitRate, AudioChannels, AudioSamplesPerSec, AudioBitsPerSample, VideoCodec, AudioCodec) Then
        edtDuration.Text = Duration
        edtFrameCount.Text = FrameCount
    End If
    
End Sub

Private Sub btnSourceVideoClip_Click()
    edtSourceVideoClip.Text = ""
    MainForm.dlgOpen.CancelError = True
    MainForm.dlgOpen.Filter = OPEN_MEDIA_FILES
    On Error GoTo Cancelled
    MainForm.dlgOpen.ShowOpen
    edtSourceVideoClip.Text = MainForm.dlgOpen.FileName
Cancelled:
End Sub

Private Sub btnStartReencoding_Click()
    MainForm.VideoGrabberVB61.Reencoding_SourceVideoClip = edtSourceVideoClip.Text
    MainForm.VideoGrabberVB61.Reencoding_NewVideoClip = edtDestinationVideoClip.Text

    MainForm.VideoGrabberVB61.Reencoding_WMVOutput = chkWMVOutput.Value = Checked
    MainForm.VideoGrabberVB61.Reencoding_IncludeVideoStream = chkIncludeVideoStream.Value = Checked
    MainForm.VideoGrabberVB61.Reencoding_IncludeAudioStream = chkIncludeAudioStream.Value = Checked
    MainForm.VideoGrabberVB61.Reencoding_UseFrameGrabber = chkUseFrameGrabber.Value = Checked
    MainForm.VideoGrabberVB61.Reencoding_UseVideoCompressor = chkUseCurrentVideoCompressor.Value = Checked
    MainForm.VideoGrabberVB61.Reencoding_UseAudioCompressor = chkUseCurrentAudioCompressor.Value = Checked
    
    If rdgReencodingMethod1.Value = True Then
        MainForm.VideoGrabberVB61.Reencoding_Method = rm_AVI
    ElseIf rdgReencodingMethod2.Value = True Then
        MainForm.VideoGrabberVB61.Reencoding_Method = rm_ASF
    End If
    
    If IsNumeric(edtStartTime.Text) Then
        MainForm.VideoGrabberVB61.Reencoding_StartTime = edtStartTime.Text
    End If
    
    If IsNumeric(edtStopTime.Text) Then
        MainForm.VideoGrabberVB61.Reencoding_StopTime = edtStopTime.Text
    End If
    
    If IsNumeric(edtStartFrame.Text) Then
        MainForm.VideoGrabberVB61.Reencoding_StartFrame = edtStartTime.Text
    End If
    
    If IsNumeric(edtStopFrame.Text) Then
        MainForm.VideoGrabberVB61.Reencoding_StopFrame = edtStopTime.Text
    End If

    MainForm.VideoGrabberVB61.StartReencoding
End Sub

Private Sub btnStopReencoding_Click()
   MainForm.VideoGrabberVB61.StopReencoding
End Sub

