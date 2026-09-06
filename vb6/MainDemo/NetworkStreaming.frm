VERSION 5.00
Begin VB.Form NetworkStreaming 
   BorderStyle     =   0  'None
   ClientHeight    =   3180
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   14100
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   212
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   940
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame framTabs 
      BorderStyle     =   0  'None
      Height          =   2700
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   13575
      Begin VB.Frame rdgNetworkStreamingType 
         Caption         =   "Type"
         Height          =   1140
         Left            =   3000
         TabIndex        =   46
         Top             =   0
         Width           =   1455
         Begin VB.OptionButton rdgNetworkStreamingType3 
            Caption         =   "Audio Only"
            Height          =   255
            Left            =   120
            TabIndex        =   49
            Tag             =   "2"
            Top             =   780
            Width           =   1215
         End
         Begin VB.OptionButton rdgNetworkStreamingType2 
            Caption         =   "Video Only"
            Height          =   255
            Left            =   120
            TabIndex        =   48
            Tag             =   "1"
            Top             =   520
            Width           =   1215
         End
         Begin VB.OptionButton rdgNetworkStreamingType1 
            Caption         =   "Audio Video"
            Height          =   195
            Left            =   120
            TabIndex        =   47
            Tag             =   "0"
            Top             =   280
            Width           =   1215
         End
      End
      Begin VB.Frame grbWMV9Profiles 
         Caption         =   "WMV 9 profiles"
         Height          =   735
         Left            =   10200
         TabIndex        =   43
         Top             =   0
         Width           =   3375
         Begin VB.TextBox edtWMV9profile 
            Height          =   345
            Left            =   960
            TabIndex        =   44
            Text            =   "<- select a WMV9 profile..."
            Top             =   240
            Width           =   2295
         End
         Begin VB.CommandButton btnWMV9profile 
            Height          =   375
            Left            =   120
            TabIndex        =   45
            Top             =   240
            Width           =   735
            PicturePosition =   262148
            Size            =   "1296;661"
            Picture         =   "NetworkStreaming.frx":0000
            FontHeight      =   165
            FontCharSet     =   0
            FontPitchAndFamily=   2
            ParagraphAlign  =   3
         End
      End
      Begin VB.Frame rdgNetworkStreaming 
         Caption         =   "Network streaming"
         Height          =   1140
         Left            =   0
         TabIndex        =   38
         Top             =   0
         Width           =   2895
         Begin VB.OptionButton rdgNetworkStreaming1 
            Caption         =   "disabled"
            Height          =   195
            Left            =   120
            TabIndex        =   42
            Tag             =   "0"
            Top             =   280
            Width           =   1935
         End
         Begin VB.OptionButton rdgNetworkStreaming2 
            Caption         =   "direct network streaming"
            Height          =   195
            Left            =   120
            TabIndex        =   41
            Tag             =   "1"
            Top             =   520
            Width           =   2175
         End
         Begin VB.OptionButton rdgNetworkStreaming3 
            Caption         =   "stream to a WM publishing point"
            Height          =   195
            Left            =   120
            TabIndex        =   40
            Tag             =   "2"
            Top             =   780
            Width           =   2655
         End
         Begin VB.CommandButton btnViewDirectNetworkStreaming 
            Caption         =   "view"
            Enabled         =   0   'False
            Height          =   295
            Left            =   2280
            TabIndex        =   39
            Top             =   440
            Width           =   495
         End
      End
      Begin VB.Frame grbDirectASFStreaming 
         Caption         =   "direct WMV network streaming"
         Height          =   780
         Left            =   0
         TabIndex        =   33
         Top             =   1200
         Width           =   4455
         Begin VB.TextBox edtNetworkPort 
            Height          =   285
            Left            =   1800
            TabIndex        =   35
            Text            =   "8080"
            Top             =   310
            Width           =   735
         End
         Begin VB.TextBox edtNetworkMaxUsers 
            Height          =   285
            Left            =   3720
            TabIndex        =   34
            Top             =   310
            Width           =   615
         End
         Begin VB.Label Label1 
            AutoSize        =   -1  'True
            Caption         =   "Port (0 = auto select):"
            Height          =   195
            Index           =   9
            Left            =   240
            TabIndex        =   37
            Top             =   330
            Width           =   1515
         End
         Begin VB.Label Label1 
            AutoSize        =   -1  'True
            Caption         =   "Max users:"
            Height          =   195
            Index           =   10
            Left            =   2880
            TabIndex        =   36
            Top             =   330
            Width           =   765
         End
      End
      Begin VB.Frame grbASFStreamingToWMServer 
         Caption         =   "stream to a WM publishing point with authentication (e.g. http://myserver.com:8080/mypublishingpoint)"
         Height          =   615
         Left            =   0
         TabIndex        =   26
         Top             =   2040
         Width           =   10095
         Begin VB.TextBox edtPublishingPoint_Password 
            Height          =   285
            Left            =   8760
            TabIndex        =   29
            Top             =   240
            Width           =   1095
         End
         Begin VB.TextBox edtPublishingPoint_UserName 
            Height          =   285
            Left            =   6720
            TabIndex        =   28
            Top             =   240
            Width           =   1095
         End
         Begin VB.TextBox edtPublishingPoint 
            Height          =   285
            Left            =   1440
            TabIndex        =   27
            Top             =   240
            Width           =   4095
         End
         Begin VB.Label Label1 
            Alignment       =   1  'Right Justify
            Caption         =   "publishing URL:"
            Height          =   255
            Index           =   21
            Left            =   120
            TabIndex        =   32
            Top             =   240
            Width           =   1215
         End
         Begin VB.Label Label1 
            Alignment       =   1  'Right Justify
            Caption         =   "password:"
            Height          =   255
            Index           =   40
            Left            =   7800
            TabIndex        =   31
            Top             =   240
            Width           =   855
         End
         Begin VB.Label Label1 
            Alignment       =   1  'Right Justify
            Caption         =   "user name:"
            Height          =   255
            Index           =   41
            Left            =   5760
            TabIndex        =   30
            Top             =   240
            Width           =   855
         End
      End
      Begin VB.Frame grbASFSettings 
         Caption         =   "WMV settings"
         Height          =   1980
         Left            =   4560
         TabIndex        =   6
         Top             =   0
         Width           =   5535
         Begin VB.Frame grbWMVprofile 
            Caption         =   "WMV"
            Height          =   855
            Left            =   2040
            TabIndex        =   15
            Top             =   360
            Width           =   1215
            Begin VB.OptionButton optWMV9profile 
               Caption         =   "WMV 9"
               Height          =   255
               Left            =   120
               TabIndex        =   17
               Top             =   480
               Width           =   975
            End
            Begin VB.OptionButton optWMV8profile 
               Caption         =   "WMV 8"
               Height          =   195
               Left            =   120
               TabIndex        =   16
               Top             =   240
               Width           =   975
            End
         End
         Begin VB.CheckBox chkASFFixedFrameRate 
            Caption         =   "fixed frame rate"
            Height          =   255
            Left            =   240
            TabIndex        =   14
            Top             =   1040
            Width           =   1455
         End
         Begin VB.ComboBox cmbASFDeinterlaceMode 
            Height          =   315
            ItemData        =   "NetworkStreaming.frx":0112
            Left            =   240
            List            =   "NetworkStreaming.frx":0128
            TabIndex        =   13
            Top             =   1560
            Width           =   3135
         End
         Begin VB.TextBox edtASFVideoWidth 
            Height          =   285
            Left            =   1200
            TabIndex        =   12
            Top             =   360
            Width           =   615
         End
         Begin VB.TextBox edtASFVideoBitRate 
            Height          =   285
            Left            =   4800
            TabIndex        =   11
            Top             =   360
            Width           =   615
         End
         Begin VB.TextBox edtASFVideoQuality 
            Height          =   285
            Left            =   4800
            TabIndex        =   10
            Top             =   720
            Width           =   615
         End
         Begin VB.TextBox edtASFVideoMaxKeyFrameSpacing 
            Height          =   285
            Left            =   4800
            TabIndex        =   9
            Top             =   1080
            Width           =   615
         End
         Begin VB.TextBox edtASFAudioChannels 
            Height          =   285
            Left            =   4800
            TabIndex        =   8
            Top             =   1440
            Width           =   615
         End
         Begin VB.TextBox edtASFVideoHeight 
            Height          =   285
            Left            =   1200
            TabIndex        =   7
            Top             =   720
            Width           =   615
         End
         Begin VB.Label Label1 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "video width:"
            Height          =   195
            Index           =   12
            Left            =   120
            TabIndex        =   25
            Top             =   480
            Width           =   1035
         End
         Begin VB.Label Label1 
            AutoSize        =   -1  'True
            Caption         =   "video bit rate:"
            Height          =   195
            Index           =   13
            Left            =   3720
            TabIndex        =   24
            Top             =   405
            Width           =   960
         End
         Begin VB.Label Label1 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "video height:"
            Height          =   195
            Index           =   14
            Left            =   120
            TabIndex        =   23
            Top             =   765
            Width           =   1035
         End
         Begin VB.Label Label1 
            AutoSize        =   -1  'True
            Caption         =   "video quality:"
            Height          =   195
            Index           =   15
            Left            =   3720
            TabIndex        =   22
            Top             =   765
            Width           =   930
         End
         Begin VB.Label Label1 
            AutoSize        =   -1  'True
            Caption         =   "key frame spacing:"
            Height          =   195
            Index           =   16
            Left            =   3360
            TabIndex        =   21
            Top             =   1125
            Width           =   1335
         End
         Begin VB.Label Label1 
            AutoSize        =   -1  'True
            Caption         =   "audio channels:"
            Height          =   195
            Index           =   17
            Left            =   3600
            TabIndex        =   20
            Top             =   1470
            Width           =   1125
         End
         Begin VB.Label Label1 
            AutoSize        =   -1  'True
            Caption         =   "deinterlace mode:"
            Height          =   195
            Index           =   18
            Left            =   240
            TabIndex        =   19
            Top             =   1320
            Width           =   1260
         End
         Begin VB.Label Label1 
            Caption         =   "(-1 = use deafult or profile value)"
            ForeColor       =   &H80000010&
            Height          =   255
            Index           =   20
            Left            =   1980
            TabIndex        =   18
            Top             =   120
            Width           =   2895
         End
      End
      Begin VB.Frame grbASFProfiles 
         Caption         =   "WMV 8 profiles"
         Height          =   1935
         Left            =   10200
         TabIndex        =   1
         Top             =   720
         Width           =   3375
         Begin VB.ListBox lsbProfiles 
            Height          =   1035
            Left            =   120
            TabIndex        =   4
            Top             =   840
            Width           =   3135
         End
         Begin VB.CommandButton btnShowProfilesList 
            Caption         =   "show WMV 8 profiles list"
            Height          =   255
            Left            =   120
            TabIndex        =   3
            Top             =   480
            Width           =   2655
         End
         Begin VB.TextBox edtProfileIndex 
            Height          =   285
            Left            =   2880
            TabIndex        =   2
            Top             =   240
            Width           =   375
         End
         Begin VB.Label Label1 
            AutoSize        =   -1  'True
            Caption         =   "index of current profile: (-1 = disabled)"
            Height          =   195
            Index           =   19
            Left            =   120
            TabIndex        =   5
            Top             =   240
            Width           =   2640
         End
      End
   End
End
Attribute VB_Name = "NetworkStreaming"
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


Private Sub btnShowProfilesList_Click()
    LoadTextBox lsbProfiles, MainForm.VideoGrabberVB61.ASFProfiles
End Sub

Private Sub btnViewDirectNetworkStreaming_Click()
    Dim SW_SHOW As Integer
    SW_SHOW = 5
    If MainForm.VideoGrabberVB61.StreamingURL <> "" Then
       ShellExecute 0, "open", MainForm.VideoGrabberVB61.StreamingURL, "", "", SW_SHOW
    End If
End Sub

Private Sub btnWMV9profile_Click()
    MainForm.dlgOpen.CancelError = True
    MainForm.dlgOpen.Filter = OPEN_WMV9_PROFILE_FILES
    On Error GoTo Cancelled
    MainForm.dlgOpen.ShowOpen
    MainForm.VideoGrabberVB61.ASFProfileFromCustomFile = MainForm.dlgOpen.FileName
    edtWMV9profile.Text = MainForm.dlgOpen.FileName
Cancelled:
End Sub

Private Sub chkASFFixedFrameRate_Click()
    MainForm.VideoGrabberVB61.ASFFixedFrameRate = chkASFFixedFrameRate.Value = Checked
End Sub

Private Sub cmbASFDeinterlaceMode_Change()
    MainForm.VideoGrabberVB61.ASFDeinterlaceMode = cmbASFDeinterlaceMode.ListIndex
End Sub

Private Sub edtASFAudioChannels_Change()
    If IsNumeric(edtASFAudioChannels.Text) Then
        MainForm.VideoGrabberVB61.ASFAudioChannels = edtASFAudioChannels.Text
    End If
End Sub

Private Sub edtASFVideoBitRate_Change()
    If IsNumeric(edtASFVideoBitRate.Text) Then
'        If edtASFVideoBitRate.Text > 0 Then
            MainForm.VideoGrabberVB61.ASFVideoBitRate = edtASFVideoBitRate.Text
'        End If
    End If
End Sub

Private Sub edtASFVideoHeight_Change()
    If IsNumeric(edtASFVideoHeight.Text) Then
'        If edtASFVideoHeight.Text > 0 Then
            MainForm.VideoGrabberVB61.ASFVideoHeight = edtASFVideoHeight.Text
'        End If
    End If
End Sub

Private Sub edtASFVideoMaxKeyFrameSpacing_Change()
    If IsNumeric(edtASFVideoMaxKeyFrameSpacing.Text) Then
        MainForm.VideoGrabberVB61.ASFVideoMaxKeyFrameSpacing = edtASFVideoMaxKeyFrameSpacing.Text
    End If
End Sub

Private Sub edtASFVideoQuality_Change()
    If IsNumeric(edtASFVideoQuality.Text) Then
'        If edtASFVideoQuality.Text >= 0 Then
            MainForm.VideoGrabberVB61.ASFVideoQuality = edtASFVideoQuality.Text
'        End If
    End If
End Sub

Private Sub edtASFVideoWidth_Change()
    If IsNumeric(edtASFVideoWidth.Text) Then
'        If edtASFVideoWidth.Text > 0 Then
            MainForm.VideoGrabberVB61.ASFVideoWidth = edtASFVideoWidth.Text
'        End If
    End If
End Sub

Private Sub edtNetworkMaxUsers_Change()
    If IsNumeric(edtNetworkMaxUsers.Text) Then
        If edtNetworkMaxUsers.Text > 0 Then
            MainForm.VideoGrabberVB61.ASFNetworkMaxUsers = edtNetworkMaxUsers.Text
        End If
    End If
End Sub

Private Sub edtNetworkPort_Change()
    If IsNumeric(edtNetworkPort.Text) Then
        If edtNetworkPort.Text >= 0 Then
            MainForm.VideoGrabberVB61.ASFNetworkPort = edtNetworkPort.Text
        End If
    End If
End Sub

Private Sub edtProfileIndex_Change()
    If IsNumeric(edtProfileIndex.Text) Then
        MainForm.VideoGrabberVB61.ASFProfile = edtProfileIndex.Text
    End If
End Sub

Private Sub edtPublishingPoint_Change()
   MainForm.VideoGrabberVB61.ASFMediaServerPublishingPoint = edtPublishingPoint.Text
End Sub

Private Sub edtPublishingPoint_Password_Change()
    MainForm.VideoGrabberVB61.SetAuthentication at_PublishingPoint, edtPublishingPoint_UserName.Text, edtPublishingPoint_Password.Text
End Sub

Private Sub edtPublishingPoint_UserName_Change()
    MainForm.VideoGrabberVB61.SetAuthentication at_PublishingPoint, edtPublishingPoint_UserName.Text, edtPublishingPoint_Password.Text
End Sub

Private Sub lsbProfiles_Click()
    If lsbProfiles.ListCount > 0 Then
        MainForm.VideoGrabberVB61.ASFProfile = lsbProfiles.ListIndex
        edtProfileIndex.Text = MainForm.VideoGrabberVB61.ASFProfile
    End If
End Sub

Private Sub optWMV8profile_Click()
    MainForm.VideoGrabberVB61.ASFProfileVersion = apv_ProfileVersion_8
End Sub

Private Sub optWMV9profile_Click()
    MainForm.VideoGrabberVB61.ASFProfileVersion = apv_ProfileVersion_9
End Sub

Private Sub rdgNetworkStreaming1_Click()
    MainForm.VideoGrabberVB61.NetworkStreaming = ns_Disabled
    btnViewDirectNetworkStreaming.Enabled = False
    rdgNetworkStreamingType1.Enabled = False
    rdgNetworkStreamingType2.Enabled = False
    rdgNetworkStreamingType3.Enabled = False
End Sub

Private Sub rdgNetworkStreaming2_Click()
    MainForm.VideoGrabberVB61.NetworkStreaming = ns_ASFDirectNetworkStreaming
    btnViewDirectNetworkStreaming.Enabled = True
    rdgNetworkStreamingType1.Enabled = True
    rdgNetworkStreamingType2.Enabled = True
    rdgNetworkStreamingType3.Enabled = True
End Sub

Private Sub rdgNetworkStreaming3_Click()
    MainForm.VideoGrabberVB61.NetworkStreaming = ns_ASFStreamingToPublishingPoint
    btnViewDirectNetworkStreaming.Enabled = False
    rdgNetworkStreamingType1.Enabled = False
    rdgNetworkStreamingType2.Enabled = False
    rdgNetworkStreamingType3.Enabled = False
End Sub

Private Sub rdgNetworkStreamingType1_Click()
    MainForm.VideoGrabberVB61.NetworkStreamingType = nst_AudioVideoStreaming
End Sub

Private Sub rdgNetworkStreamingType2_Click()
    MainForm.VideoGrabberVB61.NetworkStreamingType = nst_VideoStreaming
End Sub

Private Sub rdgNetworkStreamingType3_Click()
    MainForm.VideoGrabberVB61.NetworkStreamingType = nst_AudioStreaming
End Sub


