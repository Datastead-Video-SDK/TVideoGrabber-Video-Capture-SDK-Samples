VERSION 5.00
Begin VB.Form IPCamera 
   BorderStyle     =   0  'None
   ClientHeight    =   3168
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   13932
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   264
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   1161
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
      Begin VB.CommandButton btnIPCamera 
         Caption         =   "e.g. URL of a public IP camera currently available (just copy the URL and paste it below)"
         Height          =   255
         Left            =   3000
         TabIndex        =   13
         Top             =   240
         Width           =   6855
      End
      Begin VB.TextBox edtIPCameraURL 
         Height          =   320
         Left            =   3000
         TabIndex        =   12
         Text            =   "enter the MJPG or JPG URL of the IP camera"
         Top             =   560
         Width           =   6855
      End
      Begin VB.TextBox edtIPCamConnectionTimeout 
         Height          =   320
         Left            =   3000
         TabIndex        =   11
         Text            =   "10000"
         Top             =   920
         Width           =   1005
      End
      Begin VB.TextBox edtIPCamReceiveTimeout 
         Height          =   320
         Left            =   3000
         TabIndex        =   10
         Text            =   "5000"
         Top             =   1280
         Width           =   1005
      End
      Begin VB.CommandButton btnIPCamStartPreview 
         Caption         =   "Start Preview"
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
         Left            =   3000
         TabIndex        =   9
         Top             =   1660
         Width           =   1695
      End
      Begin VB.Frame Frame1 
         Caption         =   "if authentication needed:"
         Height          =   615
         Index           =   3
         Left            =   5040
         TabIndex        =   4
         Top             =   1320
         Width           =   4815
         Begin VB.TextBox edtIPCamPassword 
            Height          =   285
            Left            =   3480
            TabIndex        =   6
            Top             =   240
            Width           =   1215
         End
         Begin VB.TextBox edtIPCamUserName 
            Height          =   285
            Left            =   1080
            TabIndex        =   5
            Top             =   240
            Width           =   1215
         End
         Begin VB.Label Label1 
            Alignment       =   1  'Right Justify
            Caption         =   "password:"
            Height          =   255
            Index           =   23
            Left            =   2520
            TabIndex        =   8
            Top             =   240
            Width           =   855
         End
         Begin VB.Label Label1 
            Alignment       =   1  'Right Justify
            Caption         =   "user name:"
            Height          =   255
            Index           =   24
            Left            =   120
            TabIndex        =   7
            Top             =   240
            Width           =   855
         End
      End
      Begin VB.TextBox edtSnapshotFileLocation 
         Height          =   285
         Left            =   5040
         TabIndex        =   3
         Text            =   "snapshot.jpg"
         Top             =   2040
         Width           =   4095
      End
      Begin VB.CommandButton btnONVIFSnapshot 
         Caption         =   "SNAP"
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
         Left            =   9120
         TabIndex        =   2
         Top             =   2040
         Width           =   735
      End
      Begin VB.TextBox txtIPCamera 
         BackColor       =   &H00C0C0C0&
         Height          =   2655
         Left            =   9960
         MultiLine       =   -1  'True
         TabIndex        =   1
         Text            =   "IPCamera.frx":0000
         Top             =   0
         Width           =   3615
      End
      Begin VB.Label Label1 
         Caption         =   "e.g. for Axis PTZ commands, replace the last word of the sample command above with ""home"", ""up"", ""down"", ""left"" or ""right"""
         Height          =   255
         Index           =   29
         Left            =   240
         TabIndex        =   19
         Top             =   2400
         Width           =   9615
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         Caption         =   "ONVIF snapshot (enter in the URL ""onvif://ipadress)  "
         Height          =   255
         Index           =   28
         Left            =   0
         TabIndex        =   18
         Top             =   2040
         Width           =   4935
      End
      Begin VB.Label lblFirstSelectIPCamera 
         Caption         =   "first select VideoSource = vs_IPCamera in the Video Sources list of the  ""video source"" tab"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   7.8
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   255
         Left            =   0
         TabIndex        =   17
         Top             =   0
         Width           =   8775
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         Caption         =   "URL of the IP camera (MJPG or JPG):"
         Height          =   255
         Index           =   27
         Left            =   0
         TabIndex        =   16
         Top             =   600
         Width           =   2895
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         Caption         =   "Connection timeout  (in milliseconds):"
         Height          =   255
         Index           =   26
         Left            =   240
         TabIndex        =   15
         Top             =   960
         Width           =   2655
      End
      Begin VB.Label Label1 
         Alignment       =   1  'Right Justify
         Caption         =   "Receive timeout (in milliseconds):"
         Height          =   255
         Index           =   25
         Left            =   480
         TabIndex        =   14
         Top             =   1320
         Width           =   2415
      End
   End
End
Attribute VB_Name = "IPCamera"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit


Private Sub btnONVIFSnapshot_Click()
   MainForm.VideoGrabberVB61.OpenURLAsync = True
   MainForm.VideoGrabberVB61.SetAuthentication at_IPCamera, edtIPCamUserName.Text, edtIPCamPassword.Text
   MainForm.VideoGrabberVB61.IPCameraURL = edtIPCameraURL.Text
   MainForm.VideoGrabberVB61.ONVIFSnapShot True, True, edtSnapshotFileLocation
End Sub

Private Sub Form_Activate()
    RefreshIPCameraControls
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

Public Sub RefreshIPCameraControls()
    lblFirstSelectIPCamera.Visible = (MainForm.VideoGrabberVB61.VideoSource <> vs_IPCamera)
End Sub

Private Sub btnIPCamera_Click()
        Dim SW_SHOW As Integer
        SW_SHOW = 5
        ShellExecute 0, "open", "http://www.datastead.com/demo/IPCam.htm", "", "", SW_SHOW
End Sub

Private Sub btnIPCamStartPreview_Click()
        If MainForm.VideoGrabberVB61.VideoSource <> vs_IPCamera Then
            MainForm.VideoGrabberVB61.VideoSource = vs_IPCamera
            AddLog MainForm.mmoLog, "VideoSource set to ""vs_IPCamera"""
        End If
        MainForm.VideoGrabberVB61.StartPreview
End Sub

Private Sub edtIPCamConnectionTimeout_Change()
        If IsNumeric(edtIPCamConnectionTimeout.Text) Then
            MainForm.VideoGrabberVB61.SetIPCameraSetting ips_ConnectionTimeout, edtIPCamConnectionTimeout.Text
        End If
End Sub

Private Sub edtIPCameraURL_Change()
        MainForm.VideoGrabberVB61.IPCameraURL = edtIPCameraURL.Text
End Sub

Private Sub edtIPCamPassword_Change()
        MainForm.VideoGrabberVB61.SetAuthentication at_IPCamera, edtIPCamUserName.Text, edtIPCamPassword.Text
End Sub

Private Sub edtIPCamReceiveTimeout_Change()
        If (IsNumeric(edtIPCamReceiveTimeout.Text)) Then
            MainForm.VideoGrabberVB61.SetIPCameraSetting ips_ReceiveTimeout, edtIPCamReceiveTimeout.Text
        End If
End Sub

Private Sub edtIPCamUserName_Change()
        MainForm.VideoGrabberVB61.SetAuthentication at_IPCamera, edtIPCamUserName.Text, edtIPCamPassword.Text
End Sub

Private Sub timActivate_Timer()
    timActivate.Enabled = False
    Form_Activate
End Sub
