VERSION 5.00
Begin VB.Form Player 
   BorderStyle     =   0  'None
   ClientHeight    =   3105
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   13995
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   207
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   933
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame framTabs 
      BorderStyle     =   0  'None
      Height          =   2700
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   13575
      Begin VB.CommandButton btnDVDInfo 
         Caption         =   "current DVD info?"
         Height          =   285
         Left            =   6480
         TabIndex        =   46
         Top             =   1000
         Width           =   1455
      End
      Begin VB.CommandButton btnOpenDVD 
         Caption         =   "Open a DVD"
         Height          =   285
         Left            =   4920
         TabIndex        =   45
         Top             =   1000
         Width           =   1455
      End
      Begin VB.CheckBox btnUseClock 
         Caption         =   "use clock"
         Height          =   255
         Left            =   2520
         TabIndex        =   34
         Top             =   1260
         Width           =   1095
      End
      Begin VB.CheckBox chkRefreshPausedDisplay 
         Caption         =   "refresh periodically paused display when the frame grabber is enabled (e.g. to apply graphic overlays)"
         Height          =   255
         Left            =   0
         TabIndex        =   33
         Top             =   2445
         Value           =   1  'Checked
         Width           =   7935
      End
      Begin VB.CheckBox chkPlayerAudioRendering 
         Caption         =   "render player audio"
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
         TabIndex        =   32
         Top             =   1000
         Width           =   2055
      End
      Begin VB.CheckBox btnAutoPlay 
         Caption         =   "auto start playing"
         Height          =   255
         Left            =   2520
         TabIndex        =   31
         Top             =   1000
         Width           =   1575
      End
      Begin VB.TextBox edtPlayerFastSeekSpeed 
         BackColor       =   &H80000004&
         Height          =   285
         Left            =   0
         TabIndex        =   30
         Text            =   "1"
         Top             =   2000
         Width           =   375
      End
      Begin VB.TextBox edtPlayerSpeedRatio 
         BackColor       =   &H80000004&
         Height          =   285
         Left            =   0
         TabIndex        =   29
         Text            =   "1"
         Top             =   1640
         Width           =   375
      End
      Begin VB.CommandButton btnPlayerOpenStreamingURL 
         Caption         =   "demo URL ?"
         Height          =   285
         Left            =   120
         TabIndex        =   28
         Top             =   660
         Width           =   1095
      End
      Begin VB.CommandButton btnPlayerCloseFile 
         Caption         =   "Close"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Left            =   7080
         TabIndex        =   27
         Top             =   240
         Width           =   855
      End
      Begin VB.CommandButton btnOpenLastClipPlayed 
         Caption         =   "Open last clip played"
         Height          =   285
         Left            =   1320
         TabIndex        =   26
         Top             =   660
         Width           =   1695
      End
      Begin VB.CommandButton btnOpenLastClipRecorded 
         Caption         =   "Last clip recorded"
         Height          =   285
         Left            =   3120
         TabIndex        =   25
         Top             =   660
         Width           =   1455
      End
      Begin VB.CommandButton btnPlayerOpenFile 
         Caption         =   "Open"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Left            =   6120
         TabIndex        =   24
         Top             =   240
         Width           =   855
      End
      Begin VB.CommandButton btnClipDuration 
         Caption         =   "duration?"
         Height          =   285
         Left            =   7080
         TabIndex        =   23
         Top             =   660
         Width           =   855
      End
      Begin VB.TextBox edtPlayerClipFileName 
         Height          =   360
         Left            =   1680
         TabIndex        =   22
         Text            =   "Choose a video or audio clip..."
         Top             =   240
         Width           =   4335
      End
      Begin VB.CommandButton btnGeneralInfo 
         Caption         =   "general info?"
         Height          =   285
         Left            =   4680
         TabIndex        =   21
         Top             =   660
         Width           =   1095
      End
      Begin VB.CommandButton btnHeaderInfo 
         Caption         =   "header info?"
         Height          =   285
         Left            =   5880
         TabIndex        =   20
         Top             =   660
         Width           =   1095
      End
      Begin VB.Frame grbPlaylist 
         Caption         =   "Playlist"
         Height          =   2395
         Left            =   8040
         TabIndex        =   10
         Top             =   240
         Width           =   5535
         Begin VB.CommandButton btnPlaylistClose 
            Caption         =   "Close"
            Height          =   255
            Left            =   4680
            TabIndex        =   19
            Top             =   240
            Width           =   690
         End
         Begin VB.CommandButton btnPlaylistStop 
            Caption         =   "Stop after current"
            Height          =   255
            Left            =   3240
            TabIndex        =   18
            Top             =   240
            Width           =   1410
         End
         Begin VB.CommandButton btnPlaylistPrevious 
            Caption         =   "Previous"
            Height          =   255
            Left            =   2400
            TabIndex        =   17
            Top             =   240
            Width           =   810
         End
         Begin VB.CommandButton btnPlaylistNext 
            Caption         =   "Next"
            Height          =   255
            Left            =   1680
            TabIndex        =   16
            Top             =   240
            Width           =   690
         End
         Begin VB.CommandButton btnPlaylistPlay 
            Caption         =   "Play"
            Height          =   255
            Left            =   960
            TabIndex        =   15
            Top             =   240
            Width           =   690
         End
         Begin VB.CheckBox chkPlaylistRandom 
            Caption         =   "Random"
            Height          =   255
            Left            =   120
            TabIndex        =   14
            Top             =   940
            Width           =   950
         End
         Begin VB.CheckBox chkPlaylistLoop 
            Caption         =   "Loop"
            Height          =   255
            Left            =   120
            TabIndex        =   13
            Top             =   585
            Width           =   735
         End
         Begin VB.ListBox lstPlaylist 
            Height          =   1620
            Left            =   1080
            TabIndex        =   12
            Top             =   585
            Width           =   4335
         End
         Begin VB.CommandButton btnPlaylistAdd 
            Caption         =   "Add..."
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
            Left            =   120
            TabIndex        =   11
            Top             =   240
            Width           =   810
         End
      End
      Begin VB.CheckBox chkLoopPlayer 
         Caption         =   "loop (repeat indefinitely)"
         Height          =   255
         Left            =   0
         TabIndex        =   9
         Top             =   1260
         Width           =   2055
      End
      Begin VB.CommandButton btnOpenAtFrames 
         Caption         =   "Open at frames ->"
         Height          =   320
         Left            =   2520
         TabIndex        =   8
         Top             =   1560
         Width           =   1455
      End
      Begin VB.CommandButton btnOpenAtTimes 
         Caption         =   "Open at times ->"
         Height          =   320
         Left            =   2520
         TabIndex        =   7
         Top             =   1920
         Width           =   1455
      End
      Begin VB.TextBox edtOpenAtFramesStart 
         Height          =   320
         Left            =   4080
         TabIndex        =   6
         Top             =   1560
         Width           =   1065
      End
      Begin VB.TextBox edtOpenAtTimesStart 
         Height          =   320
         Left            =   4080
         TabIndex        =   5
         Top             =   1920
         Width           =   1065
      End
      Begin VB.TextBox edtOpenAtFramesStop 
         Height          =   320
         Left            =   5220
         TabIndex        =   4
         Top             =   1560
         Width           =   1065
      End
      Begin VB.TextBox edtOpenAtTimesStop 
         Height          =   320
         Left            =   5220
         TabIndex        =   3
         Top             =   1920
         Width           =   1065
      End
      Begin VB.CheckBox chkKeepBounds 
         Caption         =   "keep bounds"
         Height          =   255
         Left            =   6375
         TabIndex        =   2
         Top             =   1600
         Width           =   1575
      End
      Begin VB.CheckBox chkReopenIfOpened 
         Caption         =   "reopen (if opened)"
         Height          =   255
         Left            =   6375
         TabIndex        =   1
         Top             =   1960
         Width           =   1620
      End
      Begin VB.Label Label31 
         Caption         =   "ff/rewind speed ratio"
         Height          =   255
         Left            =   720
         TabIndex        =   44
         Top             =   2000
         Width           =   1575
      End
      Begin VB.Label Label30 
         Caption         =   "normal play speed ratio"
         Height          =   255
         Left            =   720
         TabIndex        =   43
         Top             =   1640
         Width           =   1695
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         Caption         =   $"Player.frx":0000
         ForeColor       =   &H80000010&
         Height          =   195
         Index           =   45
         Left            =   1905
         TabIndex        =   40
         Top             =   0
         Width           =   11520
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         Caption         =   "Player functions"
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
         Index           =   44
         Left            =   0
         TabIndex        =   39
         Top             =   0
         Width           =   1860
      End
      Begin VB.Label Label2 
         Caption         =   "(times are expressed in 100ns units e.g. 3 seconds - 30000000)"
         ForeColor       =   &H80000010&
         Height          =   255
         Left            =   2520
         TabIndex        =   38
         Top             =   2240
         Width           =   5415
      End
      Begin VB.Label Label3 
         Caption         =   "start(*)"
         Height          =   255
         Left            =   4080
         TabIndex        =   37
         Top             =   1340
         Width           =   1065
      End
      Begin VB.Label Label4 
         Caption         =   "stop(*)         (*default = -1)"
         Height          =   255
         Left            =   5220
         TabIndex        =   36
         Top             =   1340
         Width           =   2415
      End
      Begin VB.CommandButton btnChooseClip 
         Height          =   360
         Left            =   120
         TabIndex        =   35
         Top             =   240
         Width           =   1455
         Caption         =   "Choose a clip"
         PicturePosition =   327683
         Size            =   "2566;635"
         Picture         =   "Player.frx":009A
         FontHeight      =   165
         FontCharSet     =   0
         FontPitchAndFamily=   2
         ParagraphAlign  =   3
      End
   End
End
Attribute VB_Name = "Player"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub btnHowToOpenDVD_Click()
   MsgBox "enter the path to the .IFO folder, e.g. ""E:\VIDEO_TS"""
   edtPlayerClipFileName.Text = "E:\VIDEO_TS"
End Sub

Private Sub btnOpenDVD_Click()
   If edtPlayerClipFileName.Text = "Choose a video or audio clip..." Then
      MainForm.VideoGrabberVB61.PlayerFileName = "" ' this will use the default DVD
   Else
      MainForm.VideoGrabberVB61.PlayerFileName = edtPlayerClipFileName.Text
   End If
   If MainForm.VideoGrabberVB61.OpenDVD Then
        edtPlayerClipFileName.Text = MainForm.VideoGrabberVB61.PlayerFileName
   End If
End Sub

Private Sub btnDVDInfo_Click()
    Dim NumberOfTitles As Long
    Dim i As Long
    
    AddLog MainForm.mmoLog, "total DVD duration: " + Str(MainForm.VideoGrabberVB61.DVDInfo(edtPlayerClipFileName.Text, dvd_TotalDuration, 0))
    
    NumberOfTitles = MainForm.VideoGrabberVB61.DVDInfo(edtPlayerClipFileName.Text, dvd_NumberOfTitles, 0)
    AddLog MainForm.mmoLog, "number of titles: " + Str(MainForm.VideoGrabberVB61.DVDInfo(edtPlayerClipFileName.Text, dvd_NumberOfTitles, 0))
    
    For i = 1 To NumberOfTitles
        AddLog MainForm.mmoLog, "TITLE " + Str(i) + ":"
        AddLog MainForm.mmoLog, "duration in seconds: " + Str(MainForm.VideoGrabberVB61.DVDInfo(edtPlayerClipFileName.Text, dvd_TitleDuration, i))
        AddLog MainForm.mmoLog, "frame count: " + Str(MainForm.VideoGrabberVB61.DVDInfo(edtPlayerClipFileName.Text, dvd_TitleFrameCount, i))
        AddLog MainForm.mmoLog, "frame rate: " + Str(MainForm.VideoGrabberVB61.DVDInfo(edtPlayerClipFileName.Text, dvd_TitleFrameRate, i))
        AddLog MainForm.mmoLog, "video resolution X: " + Str(MainForm.VideoGrabberVB61.DVDInfo(edtPlayerClipFileName.Text, dvd_SourceResolutionX, i))
        AddLog MainForm.mmoLog, "video resolution Y: " + Str(MainForm.VideoGrabberVB61.DVDInfo(edtPlayerClipFileName.Text, dvd_SourceResolutionY, i))
    Next
End Sub

Private Sub btnUseClock_Click()
    MainForm.VideoGrabberVB61.UseClock = (btnUseClock.Value = Checked)
End Sub

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


Private Sub btnAutoPlay_Click()
    MainForm.VideoGrabberVB61.AutoStartPlayer = (btnAutoPlay.Value = Checked)
End Sub

Private Sub chkLoopPlayer_Click()
'    MainForm.VideoGrabberVB61
End Sub

Private Sub btnChooseClip_Click()
    MainForm.dlgOpen.CancelError = True
    MainForm.dlgOpen.Filter = OPEN_MEDIA_FILES_EXTENDED
    On Error GoTo Cancelled
    MainForm.dlgOpen.ShowOpen
    edtPlayerClipFileName.Text = MainForm.dlgOpen.FileName
Cancelled:
End Sub

Private Sub btnClipDuration_Click()
    Dim AVIDuration As Variant
    Dim AVIFrameCount As Variant
    If MainForm.VideoGrabberVB61.AVIDuration(edtPlayerClipFileName.Text, AVIDuration, AVIFrameCount) Then
      AddLog MainForm.mmoLog, "Duration: " + Str(AVIDuration)
      AddLog MainForm.mmoLog, "Frame count: " + Str(AVIFrameCount)
    Else
      AddLog MainForm.mmoLog, "failed to get AVIDuration information"
    End If
End Sub


Private Sub btnGeneralInfo_Click()
   Dim Duration As Variant
   Dim FrameCount As Variant
   Dim VideoWidth As Variant
   Dim VideoHeight As Variant
   Dim VideoFrameRateFps As Variant
   Dim AvgBitRate As Variant
   Dim AudioChannels As Variant
   Dim AudioSamplesPerSec As Variant
   Dim AudioBitsPerSample As Variant
   Dim VideoCodec As Variant
   Dim AudioCodec As Variant
   Dim DurationAsDouble As Double
   Dim AvgBitRateInKbs As Long
   
   If MainForm.VideoGrabberVB61.AVIInfo(edtPlayerClipFileName.Text, Duration, FrameCount, VideoWidth, VideoHeight, VideoFrameRateFps, AvgBitRate, AudioChannels, AudioSamplesPerSec, AudioBitsPerSample, VideoCodec, AudioCodec) Then
      DurationAsDouble = Duration
      AvgBitRateInKbs = AvgBitRate / 1024
      AddLog MainForm.mmoLog, ""
      AddLog MainForm.mmoLog, edtPlayerClipFileName.Text + ":"
      AddLog MainForm.mmoLog, "duration (in 100ns units): " + Format(DurationAsDouble / 10000000, "0.00")
      AddLog MainForm.mmoLog, "frame count: " + Str(FrameCount)
      AddLog MainForm.mmoLog, "video width: " + Str(VideoWidth)
      AddLog MainForm.mmoLog, "video height: " + Str(VideoHeight)
      AddLog MainForm.mmoLog, "video frame rate (fps): " + Format(VideoFrameRateFps, "0.00")
      AddLog MainForm.mmoLog, "average bit rate (kb/s): " + Str(AvgBitRateInKbs)
      AddLog MainForm.mmoLog, "audio channels: " + Str(AudioChannels)
      AddLog MainForm.mmoLog, "audio samples/sec: " + Str(AudioSamplesPerSec)
      AddLog MainForm.mmoLog, "audio bits per sample: " + Str(AudioBitsPerSample)
      AddLog MainForm.mmoLog, "video codec: " + VideoCodec
      AddLog MainForm.mmoLog, "audio codec: " + AudioCodec
   Else
      AddLog MainForm.mmoLog, edtPlayerClipFileName.Text + " not found."
   End If
End Sub

Private Sub btnHeaderInfo_Click()
   AddLog MainForm.mmoLog, ""
   AddLog MainForm.mmoLog, edtPlayerClipFileName.Text + " headers:"
   AddLog MainForm.mmoLog, "Title: " + MainForm.VideoGrabberVB61.AVIHeaderInfo(edtPlayerClipFileName.Text, ha_Title)
   AddLog MainForm.mmoLog, "Description: " + MainForm.VideoGrabberVB61.AVIHeaderInfo(edtPlayerClipFileName.Text, ha_Description)
   AddLog MainForm.mmoLog, "Author: " + MainForm.VideoGrabberVB61.AVIHeaderInfo(edtPlayerClipFileName.Text, ha_Author)
   AddLog MainForm.mmoLog, "Copyright: " + MainForm.VideoGrabberVB61.AVIHeaderInfo(edtPlayerClipFileName.Text, ha_Copyright)
   AddLog MainForm.mmoLog, "Album Artist: " + MainForm.VideoGrabberVB61.AVIHeaderInfo(edtPlayerClipFileName.Text, ha_AlbumArtist)
   AddLog MainForm.mmoLog, "Album Title: " + MainForm.VideoGrabberVB61.AVIHeaderInfo(edtPlayerClipFileName.Text, ha_AlbumTitle)
   AddLog MainForm.mmoLog, "Composer: " + MainForm.VideoGrabberVB61.AVIHeaderInfo(edtPlayerClipFileName.Text, ha_Composer)
   AddLog MainForm.mmoLog, "Content Distributor: " + MainForm.VideoGrabberVB61.AVIHeaderInfo(edtPlayerClipFileName.Text, ha_ContentDistributor)
   AddLog MainForm.mmoLog, "Director: " + MainForm.VideoGrabberVB61.AVIHeaderInfo(edtPlayerClipFileName.Text, ha_Director)
   AddLog MainForm.mmoLog, "Encoding Time: " + MainForm.VideoGrabberVB61.AVIHeaderInfo(edtPlayerClipFileName.Text, ha_EncodingTime)
   AddLog MainForm.mmoLog, "Genre: " + MainForm.VideoGrabberVB61.AVIHeaderInfo(edtPlayerClipFileName.Text, ha_Genre)
   AddLog MainForm.mmoLog, "Language: " + MainForm.VideoGrabberVB61.AVIHeaderInfo(edtPlayerClipFileName.Text, ha_Language)
   AddLog MainForm.mmoLog, "Parental Rating: " + MainForm.VideoGrabberVB61.AVIHeaderInfo(edtPlayerClipFileName.Text, ha_ParentalRating)
   AddLog MainForm.mmoLog, "Producer: " + MainForm.VideoGrabberVB61.AVIHeaderInfo(edtPlayerClipFileName.Text, ha_Producer)
   AddLog MainForm.mmoLog, "Provider: " + MainForm.VideoGrabberVB61.AVIHeaderInfo(edtPlayerClipFileName.Text, ha_Provider)
   AddLog MainForm.mmoLog, "ToolName: " + MainForm.VideoGrabberVB61.AVIHeaderInfo(edtPlayerClipFileName.Text, ha_ToolName)
   AddLog MainForm.mmoLog, "Tool Version: " + MainForm.VideoGrabberVB61.AVIHeaderInfo(edtPlayerClipFileName.Text, ha_ToolVersion)
   AddLog MainForm.mmoLog, "Writer: " + MainForm.VideoGrabberVB61.AVIHeaderInfo(edtPlayerClipFileName.Text, ha_Writer)

End Sub

Private Sub btnOpenLastClipPlayed_Click()
    MainForm.VideoGrabberVB61.PlayerFileName = MainForm.VideoGrabberVB61.Last_Clip_Played
    MainForm.VideoGrabberVB61.OpenPlayer
End Sub

Private Sub btnOpenLastClipRecorded_Click()
    MainForm.VideoGrabberVB61.PlayerFileName = MainForm.VideoGrabberVB61.Last_Recording_FileName
    MainForm.VideoGrabberVB61.OpenPlayer
End Sub

Private Sub btnPlayerCloseFile_Click()
    MainForm.VideoGrabberVB61.ClosePlayer
End Sub

Private Sub btnPlayerOpenFile_Click()
    MainForm.VideoGrabberVB61.PlayerFileName = edtPlayerClipFileName.Text
    MainForm.VideoGrabberVB61.OpenPlayer
End Sub

Private Sub btnPlayerOpenStreamingURL_Click()
    edtPlayerClipFileName.Text = "mms://www.datastead.com/demo/demo.wmv"
End Sub

Private Sub btnOpenAtFrames_Click()
    MainForm.VideoGrabberVB61.OpenPlayerAtFramePositions CDbl(edtOpenAtFramesStart.Text), CDbl(edtOpenAtFramesStop.Text), _
            (chkKeepBounds.Value = 1), (chkReopenIfOpened.Value = 1)
End Sub

Private Sub btnOpenAtTimes_Click()
    MainForm.VideoGrabberVB61.OpenPlayerAtTimePositions CDbl(edtOpenAtTimesStart.Text), CDbl(edtOpenAtTimesStop.Text), _
            (chkKeepBounds.Value = 1), (chkReopenIfOpened.Value = 1)
End Sub

Private Sub btnPlaylistAdd_Click()
    MainForm.dlgOpen.CancelError = True
    MainForm.dlgOpen.FileName = "*.mpg;*.mpeg;*.vro;*.avi;*.wav;*.mp3;*.asf;*.wmv;*.vob;*.jpg;*.bmp;*.gif"
    On Error GoTo Cancelled
    MainForm.dlgOpen.ShowOpen
    MainForm.VideoGrabberVB61.Playlist pl_Add, MainForm.dlgOpen.FileName
    lstPlaylist.AddItem (MainForm.dlgOpen.FileName)
Cancelled:
End Sub

Private Sub btnPlaylistClose_Click()
   MainForm.VideoGrabberVB61.ClosePlayer
End Sub

Private Sub btnPlaylistNext_Click()
      MainForm.VideoGrabberVB61.Playlist pl_Next, ""
End Sub

Private Sub btnPlaylistPlay_Click()
      MainForm.VideoGrabberVB61.Playlist pl_Play, ""
End Sub

Private Sub btnPlaylistPrevious_Click()
      MainForm.VideoGrabberVB61.Playlist pl_Previous, ""
End Sub

Private Sub btnPlaylistStop_Click()
      MainForm.VideoGrabberVB61.Playlist pl_Stop, ""
End Sub

Private Sub chkPlayerAudioRendering_Click()
    MainForm.VideoGrabberVB61.PlayerAudioRendering = (chkPlayerAudioRendering.Value = Checked)
End Sub

Private Sub chkPlaylistLoop_Click()
   If chkPlaylistLoop.Value = Checked Then
      MainForm.VideoGrabberVB61.Playlist pl_Loop, ""
   Else
      MainForm.VideoGrabberVB61.Playlist pl_NoLoop, ""
   End If
End Sub

Private Sub chkPlaylistRandom_Click()
   If chkPlaylistLoop.Value = Checked Then
      MainForm.VideoGrabberVB61.Playlist pl_Random, ""
   Else
      MainForm.VideoGrabberVB61.Playlist pl_Sequential, ""
   End If
End Sub

Private Sub chkRefreshPausedDisplay_Click()
    MainForm.VideoGrabberVB61.PlayerRefreshPausedDisplay = chkRefreshPausedDisplay.Value = Checked
End Sub

Private Sub rdgDVPlaybackSize1_Click()
    MainForm.VideoGrabberVB61.PlayerDVSize = dv_Full
End Sub

Private Sub rdgDVPlaybackSize2_Click()
    MainForm.VideoGrabberVB61.PlayerDVSize = dv_Half
End Sub

Private Sub rdgDVPlaybackSize4_Click()
    MainForm.VideoGrabberVB61.PlayerDVSize = dv_DC
End Sub



