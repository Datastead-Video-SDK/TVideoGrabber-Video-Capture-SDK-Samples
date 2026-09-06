VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form Audio 
   BorderStyle     =   0  'None
   ClientHeight    =   3135
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   13935
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   209
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   929
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
      Begin VB.Frame framAudioRendering 
         Caption         =   "AUDIO rendering / recording / streaming ONLY  (you can activate the streaming in the ""network streaming"" tab)"
         Height          =   735
         Left            =   4920
         TabIndex        =   26
         Top             =   0
         Width           =   8655
         Begin VB.CommandButton Command1 
            Caption         =   "start rendering"
            Height          =   255
            Left            =   120
            TabIndex        =   32
            Top             =   360
            Width           =   1335
         End
         Begin VB.CommandButton Command2 
            Caption         =   "record WAV"
            Height          =   255
            Left            =   1560
            TabIndex        =   31
            Top             =   360
            Width           =   1095
         End
         Begin VB.CommandButton Command3 
            Caption         =   "stop"
            Height          =   255
            Left            =   5160
            TabIndex        =   30
            Top             =   360
            Width           =   975
         End
         Begin VB.CommandButton Command4 
            Caption         =   "record WMA"
            Height          =   255
            Left            =   3960
            TabIndex        =   29
            Top             =   360
            Width           =   1095
         End
         Begin VB.CommandButton Command5 
            Caption         =   "record MP3"
            Height          =   255
            Left            =   2760
            TabIndex        =   28
            Top             =   360
            Width           =   1095
         End
         Begin VB.CheckBox chkAudioFromVideoCaptureDevice 
            Caption         =   "use the audio out of the video capyure device, if any"
            Height          =   375
            Left            =   6240
            TabIndex        =   27
            Top             =   240
            Width           =   2295
         End
      End
      Begin VB.CheckBox chkRenderAudioDevice 
         Caption         =   "AUDIO DEVICE RENDERING"
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
         TabIndex        =   25
         Top             =   120
         Width           =   4095
      End
      Begin VB.Frame Frame1 
         Caption         =   "VU-meters"
         Height          =   525
         Index           =   2
         Left            =   5280
         TabIndex        =   21
         Top             =   720
         Width           =   3735
         Begin VB.OptionButton rdgVUbargraph 
            Caption         =   "bargraph"
            Height          =   255
            Left            =   2520
            TabIndex        =   24
            Top             =   200
            Width           =   1095
         End
         Begin VB.OptionButton rdgVUAnalog 
            Caption         =   "analog"
            Height          =   255
            Left            =   1440
            TabIndex        =   23
            Top             =   200
            Width           =   975
         End
         Begin VB.OptionButton rdgVUDisabled 
            Caption         =   "disabled"
            Height          =   255
            Left            =   120
            TabIndex        =   22
            Top             =   200
            Value           =   -1  'True
            Width           =   1095
         End
      End
      Begin VB.Frame grbAudioCaptureDevice 
         Caption         =   "Audio capture device"
         Height          =   2145
         Left            =   0
         TabIndex        =   10
         Top             =   480
         Width           =   4815
         Begin VB.ComboBox cboAudioDevices 
            Height          =   315
            Left            =   1080
            TabIndex        =   14
            Text            =   "SELECT AN AUDIO CAPTURE DEVICE IN THIS LIST"
            Top             =   240
            Width           =   3615
         End
         Begin VB.ComboBox cboAudioInputs 
            Height          =   315
            Left            =   120
            TabIndex        =   13
            Top             =   600
            Width           =   1815
         End
         Begin VB.CheckBox chkAudioInputMono 
            Caption         =   "mono"
            Height          =   255
            Left            =   2280
            TabIndex        =   12
            Top             =   600
            Width           =   975
         End
         Begin VB.CommandButton btnAudioDeviceDilaog 
            Caption         =   "device dialog"
            Height          =   255
            Left            =   3480
            TabIndex        =   11
            Top             =   600
            Width           =   1215
         End
         Begin MSComctlLib.Slider tbrAudioInputLevel 
            Height          =   255
            Left            =   1800
            TabIndex        =   15
            Top             =   1440
            Width           =   2655
            _ExtentX        =   4683
            _ExtentY        =   450
            _Version        =   393216
            Max             =   65535
            TickFrequency   =   7300
         End
         Begin MSComctlLib.Slider tbrAudioInputBalance 
            Height          =   255
            Left            =   1800
            TabIndex        =   16
            Top             =   1760
            Width           =   2655
            _ExtentX        =   4683
            _ExtentY        =   450
            _Version        =   393216
            Min             =   -32767
            Max             =   32768
            TickFrequency   =   7300
         End
         Begin VB.Label Label1 
            Caption         =   "audio input"
            Height          =   255
            Index           =   39
            Left            =   120
            TabIndex        =   20
            Top             =   360
            Width           =   975
         End
         Begin VB.Label Label1 
            Alignment       =   1  'Right Justify
            Caption         =   "audio input level"
            Height          =   255
            Index           =   3
            Left            =   360
            TabIndex        =   19
            Top             =   1440
            Width           =   1335
         End
         Begin VB.Label Label1 
            Alignment       =   1  'Right Justify
            Caption         =   "audio input balance"
            Height          =   255
            Index           =   5
            Left            =   240
            TabIndex        =   18
            Top             =   1760
            Width           =   1455
         End
         Begin VB.Label Label1 
            Caption         =   "to programmatically select an item by name in a list, use the FindIndexInListByName function"
            ForeColor       =   &H80000010&
            Height          =   375
            Index           =   6
            Left            =   120
            TabIndex        =   17
            Top             =   960
            Width           =   4455
            WordWrap        =   -1  'True
         End
      End
      Begin VB.Frame grbAudioRendering 
         Caption         =   "audio renderer (default = -1)"
         Height          =   1905
         Left            =   9480
         TabIndex        =   3
         Top             =   720
         Width           =   4095
         Begin VB.ComboBox cboAudioRenderers 
            Height          =   315
            Left            =   840
            TabIndex        =   5
            Text            =   "default (AudioRenderer = -1)"
            Top             =   240
            Width           =   3135
         End
         Begin VB.CheckBox chkMuteAudioRendering 
            Caption         =   "mute"
            Height          =   255
            Left            =   120
            TabIndex        =   4
            Top             =   240
            Width           =   735
         End
         Begin MSComctlLib.Slider tbrAudioVolume 
            Height          =   255
            Left            =   120
            TabIndex        =   6
            Top             =   840
            Width           =   3855
            _ExtentX        =   6800
            _ExtentY        =   450
            _Version        =   393216
            Max             =   65535
            TickFrequency   =   7300
         End
         Begin MSComctlLib.Slider tbrAudioBalance 
            Height          =   255
            Left            =   120
            TabIndex        =   7
            Top             =   1440
            Width           =   3855
            _ExtentX        =   6800
            _ExtentY        =   450
            _Version        =   393216
            Min             =   -32767
            Max             =   32768
            TickFrequency   =   7300
         End
         Begin VB.Label Label1 
            Caption         =   "volume"
            Height          =   255
            Index           =   7
            Left            =   240
            TabIndex        =   9
            Top             =   600
            Width           =   975
         End
         Begin VB.Label Label1 
            Caption         =   "balance"
            Height          =   255
            Index           =   8
            Left            =   240
            TabIndex        =   8
            Top             =   1200
            Width           =   2055
         End
      End
      Begin VB.PictureBox picVUmeterLeft 
         Height          =   1215
         Left            =   5280
         ScaleHeight     =   1155
         ScaleWidth      =   1755
         TabIndex        =   2
         Top             =   1320
         Width           =   1815
      End
      Begin VB.PictureBox picVUmeterRight 
         Height          =   1215
         Left            =   7200
         ScaleHeight     =   1155
         ScaleWidth      =   1755
         TabIndex        =   1
         Top             =   1320
         Width           =   1815
      End
   End
End
Attribute VB_Name = "Audio"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit




Private Const VU_LEFT As Integer = 0
Private Const VU_RIGHT As Integer = 1

Public Sub Form_Activate()
    If MainForm.VideoGrabberVB61.AudioDevice = -1 Then
        cboAudioDevices.Text = "SELECT AN AUDIO CAPTURE DEVICE IN THIS LIST"
    End If
    If MainForm.VideoGrabberVB61.AudioRenderer = -1 Then
        cboAudioRenderers.Text = "default (AudioRenderer = -1)"
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


Private Sub cboAudioDevices_Click()
   MainForm.VideoGrabberVB61.AudioDevice = cboAudioDevices.ListIndex
End Sub

Private Sub btnAudioDeviceDilaog_Click()
    MainForm.VideoGrabberVB61.ShowDialog dlg_AudioDevice
End Sub

Private Sub cboAudioInputs_Click()
   MainForm.VideoGrabberVB61.AudioInput = cboAudioInputs.ListIndex
End Sub

Private Sub cboAudioRenderers_Click()
   MainForm.VideoGrabberVB61.AudioRenderer = cboAudioRenderers.ListIndex
End Sub

Private Sub chkAudioInputMono_Click()
   MainForm.VideoGrabberVB61.AudioInputMono = chkAudioInputMono = Checked
End Sub

Private Sub chkMuteAudioRendering_Click()
   MainForm.VideoGrabberVB61.MuteAudioRendering = chkMuteAudioRendering = Checked
End Sub

Private Sub chkRenderAudioDevice_Click()
   MainForm.VideoGrabberVB61.AudioDeviceRendering = chkRenderAudioDevice.Value = Checked
End Sub

Private Sub rdgVUAnalog_Click()
    MainForm.VideoGrabberVB61.VuMeter = vu_Analog
    MainForm.VideoGrabberVB61.SetVUMeterSetting VU_LEFT, vu_BkgndColor, 0 'clBlack ' VU_LEFT = 0, VU_RIGHT = 1
    MainForm.VideoGrabberVB61.SetVUMeterSetting VU_RIGHT, vu_BkgndColor, 0 'clBlack
    MainForm.VideoGrabberVB61.SetVUMeterSetting VU_LEFT, vu_Handle, picVUmeterLeft.hwnd
    MainForm.VideoGrabberVB61.SetVUMeterSetting VU_RIGHT, vu_Handle, picVUmeterRight.hwnd
End Sub

Private Sub rdgVUbargraph_Click()
    MainForm.VideoGrabberVB61.VuMeter = vu_Bargraph
    MainForm.VideoGrabberVB61.SetVUMeterSetting VU_LEFT, vu_BkgndColor, &H404040 ' VU_LEFT = 0, VU_RIGHT = 1
    MainForm.VideoGrabberVB61.SetVUMeterSetting VU_RIGHT, vu_BkgndColor, &H404040
    MainForm.VideoGrabberVB61.SetVUMeterSetting VU_LEFT, vu_Handle, picVUmeterLeft.hwnd
    MainForm.VideoGrabberVB61.SetVUMeterSetting VU_RIGHT, vu_Handle, picVUmeterRight.hwnd
End Sub

Private Sub rdgVUDisabled_Click()
    MainForm.VideoGrabberVB61.VuMeter = vu_Disabled
    MainForm.VideoGrabberVB61.SetVUMeterSetting VU_LEFT, vu_Handle, 0 ' VU_LEFT = 0, VU_RIGHT = 1
    MainForm.VideoGrabberVB61.SetVUMeterSetting VU_RIGHT, vu_Handle, 0
End Sub

Private Sub tbrAudioBalance_Click()
   MainForm.VideoGrabberVB61.AudioBalance = tbrAudioBalance.Value
End Sub

Private Sub tbrAudioInputBalance_Click()
   MainForm.VideoGrabberVB61.AudioInputBalance = tbrAudioInputBalance.Value
End Sub

Private Sub tbrAudioInputLevel_Click()
   MainForm.VideoGrabberVB61.AudioInputLevel = tbrAudioInputLevel.Value
End Sub

Private Sub tbrAudioVolume_Click()
   MainForm.VideoGrabberVB61.AudioVolume = tbrAudioVolume.Value
End Sub

Private Sub timActivate_Timer()
    timActivate.Enabled = False
    Form_Activate
End Sub
