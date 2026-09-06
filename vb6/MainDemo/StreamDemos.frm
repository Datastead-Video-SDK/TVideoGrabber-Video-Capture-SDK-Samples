VERSION 5.00
Begin VB.Form StreamDemos 
   BorderStyle     =   0  'None
   ClientHeight    =   3480
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   13992
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   290
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   1166
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame Frame4 
      Caption         =   "cilent side (from a 2nd MainDemo.exe):"
      Height          =   720
      Left            =   5760
      TabIndex        =   27
      Top             =   2040
      Width           =   4092
      Begin VB.CommandButton btnViewNDIStreamingHelp 
         Caption         =   "?"
         Height          =   372
         Left            =   720
         TabIndex        =   30
         Top             =   240
         Width           =   252
      End
      Begin VB.CommandButton btnNDIStreamingClientView 
         Caption         =   "View"
         Height          =   372
         Left            =   120
         TabIndex        =   29
         Top             =   240
         Width           =   492
      End
      Begin VB.TextBox edtNDIClientURL 
         Height          =   288
         Left            =   1080
         TabIndex        =   28
         Text            =   "udp://"
         Top             =   270
         Width           =   2892
      End
   End
   Begin VB.Frame Frame3 
      Caption         =   "cilent side (from a 2nd MainDemo.exe):"
      Height          =   720
      Left            =   1920
      TabIndex        =   24
      Top             =   2040
      Width           =   3732
      Begin VB.TextBox edtUDPStreamingURL 
         Height          =   288
         Left            =   960
         TabIndex        =   26
         Text            =   "udp://"
         Top             =   270
         Width           =   2652
      End
      Begin VB.CommandButton btnUDPStreamingClientView 
         Caption         =   "View"
         Height          =   372
         Left            =   120
         TabIndex        =   25
         Top             =   240
         Width           =   732
      End
   End
   Begin VB.CommandButton btnStreamingHelp 
      Caption         =   "help"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   7.8
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   252
      Left            =   120
      TabIndex        =   23
      Top             =   1080
      Width           =   852
   End
   Begin VB.CheckBox chkAudioEnabled 
      Caption         =   "audio enabled"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   7.8
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   252
      Left            =   120
      TabIndex        =   22
      Top             =   720
      Width           =   1692
   End
   Begin VB.CheckBox chkVideoEnabled 
      Caption         =   "video enabled"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   7.8
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   252
      Left            =   120
      TabIndex        =   21
      Top             =   360
      Value           =   1  'Checked
      Width           =   1692
   End
   Begin VB.Frame Frame2 
      Caption         =   "server side:"
      Height          =   1812
      Left            =   5760
      TabIndex        =   5
      Top             =   180
      Width           =   4092
      Begin VB.TextBox edtNDISessionName 
         Height          =   288
         Left            =   1320
         TabIndex        =   20
         Text            =   "MYSTREAM"
         Top             =   360
         Width           =   1812
      End
      Begin VB.CommandButton btnNDIStreamingOK 
         Caption         =   "OK"
         Height          =   372
         Left            =   120
         TabIndex        =   17
         Top             =   1320
         Width           =   372
      End
      Begin VB.Label Label11 
         Caption         =   "session name:"
         Height          =   252
         Left            =   120
         TabIndex        =   19
         Top             =   360
         Width           =   1092
      End
      Begin VB.Label Label10 
         Caption         =   "(then, start e.g. the preview or playback)"
         Height          =   252
         Left            =   600
         TabIndex        =   18
         Top             =   1440
         Width           =   2892
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "server side:"
      Height          =   1812
      Left            =   1920
      TabIndex        =   4
      Top             =   180
      Width           =   3732
      Begin VB.CommandButton btnUpdStreamingOK 
         Caption         =   "OK"
         Height          =   372
         Left            =   120
         TabIndex        =   15
         Top             =   1320
         Width           =   372
      End
      Begin VB.CheckBox chkLogToFile 
         Caption         =   "log to file in the current folder"
         Height          =   252
         Left            =   120
         TabIndex        =   14
         Top             =   960
         Width           =   3132
      End
      Begin VB.TextBox edtDestinationPort 
         Height          =   288
         Left            =   3000
         TabIndex        =   12
         Text            =   "10124"
         Top             =   600
         Width           =   612
      End
      Begin VB.TextBox edtDestinationIP 
         Height          =   288
         Left            =   1200
         TabIndex        =   11
         Text            =   "127.0.0.1"
         Top             =   600
         Width           =   1092
      End
      Begin VB.TextBox edtAudioBitRate 
         Height          =   288
         Left            =   3000
         TabIndex        =   8
         Text            =   "128"
         Top             =   240
         Width           =   612
      End
      Begin VB.TextBox edtVideoBitRate 
         Height          =   288
         Left            =   1560
         TabIndex        =   7
         Text            =   "2000"
         Top             =   240
         Width           =   732
      End
      Begin VB.Label Label9 
         Caption         =   "(then, start e.g. the preview or playback)"
         Height          =   252
         Left            =   600
         TabIndex        =   16
         Top             =   1440
         Width           =   2892
      End
      Begin VB.Label Label8 
         Caption         =   "port:"
         Height          =   252
         Left            =   2520
         TabIndex        =   13
         Top             =   600
         Width           =   492
      End
      Begin VB.Label Label7 
         Caption         =   "destination IP:"
         Height          =   252
         Left            =   120
         TabIndex        =   10
         Top             =   600
         Width           =   1092
      End
      Begin VB.Label Label6 
         Caption         =   "audio:"
         Height          =   252
         Left            =   2520
         TabIndex        =   9
         Top             =   240
         Width           =   492
      End
      Begin VB.Label Label5 
         Caption         =   "bitrate (kb/s) video:"
         Height          =   252
         Left            =   120
         TabIndex        =   6
         Top             =   240
         Width           =   1452
      End
   End
   Begin VB.Label Label4 
      Caption         =   "NDI (requires the Datastead NDI filters)"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   7.8
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   252
      Left            =   6120
      TabIndex        =   3
      Top             =   0
      Width           =   3372
   End
   Begin VB.Label Label3 
      Caption         =   "UDP (requires the Multipurpose Encoder)"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   7.8
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   252
      Left            =   2040
      TabIndex        =   2
      Top             =   0
      Width           =   3492
   End
   Begin VB.Label Label2 
      Caption         =   "STREAMING DEMOS"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   7.8
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   252
      Left            =   0
      TabIndex        =   1
      Top             =   0
      Width           =   1812
   End
   Begin VB.Label Label1 
      Caption         =   "STREAMING DEMOS"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   7.8
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000013&
      Height          =   252
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   2052
   End
End
Attribute VB_Name = "StreamDemos"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub btnNDIStreamingClientView_Click()
   MainForm.VideoGrabberVB61.PlayerFileName = edtNDIClientURL.Text
   MainForm.VideoGrabberVB61.OpenPlayer

End Sub

Private Sub btnViewNDIStreamingHelp_Click()
   MsgBox ("This option open the NDI stream through the Datastead NDI filters." & vbCrLf & vbCrLf & "Alternatively, if there is only one NDI source, it is possible to use the ""NewTek NDI Video"" virtual capture device in the ""video capture devices"" list.")

End Sub

Private Sub Form_Load()
   edtDestinationIP_Change
   edtNDISessionName_Change
End Sub


Private Sub btnNDIStreamingOK_Click()
   MainForm.VideoGrabberVB61.NetworkStreaming = ns_NDI
   If (chkVideoEnabled.Value = vbChecked) And (chkAudioEnabled.Value = vbChecked) Then
      MainForm.VideoGrabberVB61.NetworkStreamingType = nst_AudioVideoStreaming
   ElseIf chkVideoEnabled.Value = vbChecked Then
      MainForm.VideoGrabberVB61.NetworkStreamingType = nst_VideoStreaming
   Else
      MainForm.VideoGrabberVB61.NetworkStreamingType = nst_AudioStreaming
   End If
   MainForm.VideoGrabberVB61.NDIName = edtNDISessionName.Text
   AddLog MainForm.mmoLog, "NDI streaming enabled"

End Sub

Private Sub btnUDPStreamingClientView_Click()
   Dim URL As String
   URL = "udp://" & edtDestinationIP.Text & ":" & edtDestinationPort.Text
   MainForm.VideoGrabberVB61.VideoSource = vs_IPCamera
   MainForm.VideoGrabberVB61.IPCameraURL = URL
   MainForm.VideoGrabberVB61.StartPreview

End Sub

Private Sub btnUpdStreamingOK_Click()
   Dim MPEConfig As String
   MPEConfig = MainForm.VideoGrabberVB61.MultipurposeEncoder_QuickConfigure_UDPStreaming_H264(chkLogToFile.Value, chkVideoEnabled.Value, chkAudioEnabled.Value, edtDestinationIP.Text, edtDestinationPort.Text, edtVideoBitRate.Text, edtAudioBitRate.Text)
   If MPEConfig = "" Then
      AddLog MainForm.mmoLog, "something is wrong in these settings"
   End
   Else
      AddLog MainForm.mmoLog, "Multipurpose streaming enabled:"
      AddLog MainForm.mmoLog, ""
      AddLog MainForm.mmoLog, MPEConfig
   End If

End Sub

Private Sub edtDestinationIP_Change()
   edtUDPStreamingURL.Text = "udp://" & edtDestinationIP.Text & ":" + edtDestinationPort.Text
End Sub

Private Sub edtDestinationPort_Change()
   edtDestinationIP_Change
End Sub

Private Sub edtNDISessionName_Change()
edtNDIClientURL.Text = "ndi://" & Environ$("COMPUTERNAME") & "(" & edtNDISessionName.Text & ")"
End Sub

Private Sub Form_Unload(Cancel As Integer)
   If Not MainForm.CanUnload Then
      Hide
      Cancel = True
   End If
End Sub

Private Sub btnStreamingHelp_Click()
   MsgBox ("1. set/modify the streaming settings, click ""OK""" & vbCrLf & vbCrLf & _
   "2. go to the ""video source"" tab and start preview, or open the player" & vbCrLf & vbCrLf & _
   "3. at this point, if there were no error, this first instance of MainDemo.exe is acting as server and streaming to the network" & vbCrLf & vbCrLf & _
   "5. copy the URL in the clipboard for the client side" & vbCrLf & vbCrLf & _
   "4. run a second instance of MainDemo.exe " & vbCrLf & vbCrLf & _
   "5. paste the client URL copied from the 1st instance in the corresponding edit field, then click ""view""")
End Sub

