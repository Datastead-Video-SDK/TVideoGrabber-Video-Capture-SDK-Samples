VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Begin VB.Form Display 
   BorderStyle     =   0  'None
   Caption         =   "Display"
   ClientHeight    =   3150
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   13905
   ClipControls    =   0   'False
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   210
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   927
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame framTabs 
      BorderStyle     =   0  'None
      Height          =   2700
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   13575
      Begin VB.CheckBox chkTransparency 
         Caption         =   "transparency"
         Height          =   255
         Left            =   1920
         TabIndex        =   58
         Top             =   960
         Width           =   1935
      End
      Begin VB.CheckBox chkVideoVisibleWhenStopped 
         Caption         =   "keep video visible when stopped"
         Height          =   255
         Left            =   1920
         TabIndex        =   57
         Top             =   0
         Width           =   2775
      End
      Begin VB.CheckBox chk2ndVideoWindowActive 
         Caption         =   "2ND VIDEO WINDOW ACTIVE"
         Height          =   255
         Left            =   9840
         TabIndex        =   56
         Top             =   0
         Width           =   2775
      End
      Begin VB.Frame grb2ndVideoWindow 
         Caption         =   "main video window"
         Height          =   2415
         Left            =   8880
         TabIndex        =   36
         Top             =   240
         Width           =   4695
         Begin VB.CheckBox chk2ndVisible 
            Caption         =   "visible"
            Height          =   255
            Left            =   120
            TabIndex        =   53
            Top             =   240
            Width           =   975
         End
         Begin VB.CheckBox chk2ndUseVideoPort 
            Caption         =   "use video port"
            Height          =   255
            Left            =   1200
            TabIndex        =   52
            Top             =   480
            Width           =   1335
         End
         Begin VB.CheckBox chk2ndEmbedded 
            Caption         =   "embedded"
            Height          =   255
            Left            =   120
            TabIndex        =   51
            Top             =   480
            Width           =   1095
         End
         Begin VB.CheckBox chk2ndFullScreen 
            Caption         =   "full screen"
            Height          =   255
            Left            =   1200
            TabIndex        =   50
            Top             =   240
            Width           =   1335
         End
         Begin VB.CheckBox chk2ndMouseMovesWindow 
            Caption         =   "mouse moves window"
            Height          =   255
            Left            =   1200
            TabIndex        =   49
            Top             =   720
            Width           =   1935
         End
         Begin VB.CheckBox chk2ndStayOnTop 
            Caption         =   "stay on top"
            Height          =   255
            Left            =   120
            TabIndex        =   48
            Top             =   960
            Width           =   1095
         End
         Begin VB.CheckBox chk2ndAutoSize 
            Caption         =   "autosize"
            Height          =   255
            Left            =   120
            TabIndex        =   47
            Top             =   720
            Width           =   975
         End
         Begin VB.Frame rdg2ndDisplayedOn 
            Caption         =   "display on..."
            Height          =   855
            Left            =   3240
            TabIndex        =   44
            Top             =   120
            Width           =   1335
            Begin VB.OptionButton rdg2ndDisplayedOn1 
               Caption         =   "1st monitor"
               Height          =   255
               Left            =   120
               TabIndex        =   46
               Tag             =   "0"
               Top             =   240
               Width           =   1180
            End
            Begin VB.OptionButton rdg2ndDisplayedOn2 
               Caption         =   "2nd monitor"
               Height          =   255
               Left            =   120
               TabIndex        =   45
               Tag             =   "1"
               Top             =   480
               Width           =   1180
            End
         End
         Begin VB.CommandButton btnEG2ndNewLocation 
            Caption         =   "e.g. pos. 510, 10 (autosize)"
            Height          =   255
            Left            =   2400
            TabIndex        =   43
            Top             =   1080
            Width           =   2175
         End
         Begin VB.CommandButton btnEG2ndNewLocation2 
            Caption         =   "e.g. pos. 520,20 (480,200)"
            Height          =   255
            Left            =   2400
            TabIndex        =   42
            Top             =   1440
            Width           =   2175
         End
         Begin VB.Frame grb2AspectRatio 
            Caption         =   "aspect ratio"
            Height          =   1215
            Left            =   120
            TabIndex        =   37
            Top             =   1200
            Width           =   2175
            Begin VB.OptionButton rdg2Stretch 
               Caption         =   "stretch"
               Height          =   240
               Left            =   120
               TabIndex        =   41
               Tag             =   "2"
               Top             =   660
               Width           =   1635
            End
            Begin VB.OptionButton rdg2Pan 
               Caption         =   "pan-scan"
               Height          =   240
               Left            =   120
               TabIndex        =   40
               Tag             =   "3"
               Top             =   880
               Width           =   2025
            End
            Begin VB.OptionButton rdg2Box 
               Caption         =   "box (letterbox, pillarbox)"
               Height          =   240
               Left            =   120
               TabIndex        =   39
               Tag             =   "0"
               Top             =   220
               Width           =   2025
            End
            Begin VB.OptionButton rdg2NoResize 
               Caption         =   "no resize"
               Height          =   240
               Left            =   120
               TabIndex        =   38
               Tag             =   "1"
               Top             =   440
               Width           =   2025
            End
         End
         Begin MSComctlLib.Slider sld2ndPanScanRatio 
            Height          =   255
            Left            =   2280
            TabIndex        =   54
            Top             =   2040
            Width           =   1455
            _ExtentX        =   2566
            _ExtentY        =   450
            _Version        =   393216
            LargeChange     =   0
            Max             =   100
            TickFrequency   =   5
         End
         Begin VB.Label Label2 
            Caption         =   "pan-scan ratio (0-100)"
            Height          =   255
            Left            =   2400
            TabIndex        =   55
            Top             =   1800
            Width           =   1935
         End
      End
      Begin VB.Frame grbMainVideoWindow 
         Caption         =   "main video window"
         Height          =   2415
         Left            =   4200
         TabIndex        =   14
         Top             =   240
         Width           =   4575
         Begin VB.CommandButton btnTestPanScanHelp 
            Caption         =   "?"
            Height          =   255
            Left            =   4200
            TabIndex        =   33
            Top             =   2040
            Width           =   255
         End
         Begin VB.CommandButton btnTestPanScan 
            Caption         =   "test"
            Height          =   255
            Left            =   3720
            TabIndex        =   32
            Top             =   2040
            Width           =   495
         End
         Begin VB.CheckBox chk1stVisible 
            Caption         =   "visible"
            Height          =   255
            Left            =   120
            TabIndex        =   31
            Top             =   240
            Width           =   975
         End
         Begin VB.CommandButton btnEG1stNewLocation2 
            Caption         =   "e.g. pos. 20,20 (480,200)"
            Height          =   255
            Left            =   2400
            TabIndex        =   30
            Top             =   1440
            Width           =   2055
         End
         Begin VB.CommandButton btnEG1stNewLocation 
            Caption         =   "e.g. pos. 10, 10 (autosize)"
            Height          =   255
            Left            =   2400
            TabIndex        =   29
            Top             =   1080
            Width           =   2055
         End
         Begin VB.Frame rdg1stDisplayedOn 
            Caption         =   "display on..."
            Height          =   855
            Left            =   3120
            TabIndex        =   26
            Top             =   120
            Width           =   1335
            Begin VB.OptionButton rdg1stDisplayedOn2 
               Caption         =   "2nd monitor"
               Height          =   255
               Left            =   120
               TabIndex        =   28
               Tag             =   "1"
               Top             =   480
               Width           =   1180
            End
            Begin VB.OptionButton rdg1stDisplayedOn1 
               Caption         =   "1st monitor"
               Height          =   255
               Left            =   120
               TabIndex        =   27
               Tag             =   "0"
               Top             =   240
               Width           =   1180
            End
         End
         Begin VB.CheckBox chk1stAutoSize 
            Caption         =   "autosize"
            Height          =   255
            Left            =   120
            TabIndex        =   25
            Top             =   720
            Width           =   975
         End
         Begin VB.CheckBox chk1stStayOnTop 
            Caption         =   "stay on top"
            Height          =   255
            Left            =   120
            TabIndex        =   24
            Top             =   960
            Width           =   1095
         End
         Begin VB.CheckBox chk1stMouseMovesWindow 
            Caption         =   "mouse moves window"
            Height          =   255
            Left            =   1200
            TabIndex        =   23
            Top             =   720
            Width           =   1890
         End
         Begin VB.CheckBox chk1stFullScreen 
            Caption         =   "full screen"
            Height          =   255
            Left            =   1200
            TabIndex        =   22
            Top             =   240
            Width           =   1335
         End
         Begin VB.CheckBox chk1stUseVideoPort 
            Caption         =   "use video port"
            Height          =   255
            Left            =   1200
            TabIndex        =   21
            Top             =   480
            Width           =   1335
         End
         Begin VB.CheckBox chk1stEmbedded 
            Caption         =   "embedded"
            Height          =   255
            Left            =   120
            TabIndex        =   20
            Top             =   480
            Width           =   1095
         End
         Begin VB.Frame grb1AspectRatio 
            Caption         =   "aspect ratio"
            Height          =   1215
            Left            =   120
            TabIndex        =   15
            Top             =   1200
            Width           =   2175
            Begin VB.OptionButton rdg1NoResize 
               Caption         =   "no resize"
               Height          =   240
               Left            =   120
               TabIndex        =   19
               Tag             =   "1"
               Top             =   440
               Width           =   2025
            End
            Begin VB.OptionButton rdg1Stretch 
               Caption         =   "stretch"
               Height          =   240
               Left            =   120
               TabIndex        =   18
               Tag             =   "2"
               Top             =   660
               Width           =   1635
            End
            Begin VB.OptionButton rdg1Box 
               Caption         =   "box (letterbox, pillarbox)"
               Height          =   240
               Left            =   120
               TabIndex        =   17
               Tag             =   "0"
               Top             =   220
               Width           =   2025
            End
            Begin VB.OptionButton rdg1Pan 
               Caption         =   "pan-scan"
               Height          =   240
               Left            =   120
               TabIndex        =   16
               Tag             =   "3"
               Top             =   880
               Width           =   2025
            End
         End
         Begin MSComctlLib.Slider sld1stPanScanRatio 
            Height          =   255
            Left            =   2280
            TabIndex        =   34
            Top             =   2040
            Width           =   1455
            _ExtentX        =   2566
            _ExtentY        =   450
            _Version        =   393216
            Max             =   100
            TickFrequency   =   5
         End
         Begin VB.Label Label1 
            Caption         =   "pan-scan ratio (0-100)"
            Height          =   255
            Left            =   2400
            TabIndex        =   35
            Top             =   1800
            Width           =   1935
         End
      End
      Begin VB.CheckBox chk1stVideoWindowActive 
         Caption         =   "MAIN VIDEO WINDOW ACTIVE"
         Height          =   255
         Left            =   5160
         TabIndex        =   13
         Top             =   0
         Width           =   2775
      End
      Begin VB.CheckBox chkSetLogo 
         Caption         =   "show logo, e.g.:"
         Height          =   255
         Left            =   1920
         TabIndex        =   12
         Top             =   1200
         Width           =   1455
      End
      Begin VB.CheckBox chkBorder 
         Caption         =   "border"
         Height          =   255
         Left            =   1920
         TabIndex        =   11
         Top             =   720
         Width           =   855
      End
      Begin VB.CheckBox chkChangeCursor 
         Caption         =   "change cursor (e.g. cross)"
         Height          =   255
         Left            =   1920
         TabIndex        =   10
         Top             =   480
         Width           =   2175
      End
      Begin VB.Frame rdgVideoRenderer 
         Caption         =   "video renderer"
         Height          =   2295
         Left            =   0
         TabIndex        =   2
         Top             =   0
         Width           =   1815
         Begin VB.OptionButton rdgVideoRenderer2 
            Caption         =   "EVR"
            Height          =   255
            Left            =   120
            TabIndex        =   59
            Tag             =   "1"
            Top             =   480
            Width           =   1455
         End
         Begin VB.OptionButton rdgVideoRenderer7 
            Caption         =   "Recording Priority"
            Height          =   255
            Left            =   120
            TabIndex        =   9
            Tag             =   "6"
            Top             =   1680
            Width           =   1575
         End
         Begin VB.OptionButton rdgVideoRenderer6 
            Caption         =   "Overlay"
            Height          =   255
            Left            =   120
            TabIndex        =   8
            Tag             =   "5"
            Top             =   1440
            Width           =   1455
         End
         Begin VB.OptionButton rdgVideoRenderer5 
            Caption         =   "Standard"
            Height          =   255
            Left            =   120
            TabIndex        =   7
            Tag             =   "4"
            Top             =   1200
            Width           =   1455
         End
         Begin VB.OptionButton rdgVideoRenderer1 
            Caption         =   "Auto Select"
            Height          =   255
            Left            =   120
            TabIndex        =   6
            Tag             =   "0"
            Top             =   240
            Width           =   1440
         End
         Begin VB.OptionButton rdgVideoRenderer4 
            Caption         =   "VMR7"
            Height          =   255
            Left            =   120
            TabIndex        =   5
            Tag             =   "3"
            Top             =   960
            Width           =   1455
         End
         Begin VB.OptionButton rdgVideoRenderer3 
            Caption         =   "VMR9"
            Height          =   255
            Left            =   120
            TabIndex        =   4
            Tag             =   "2"
            Top             =   720
            Width           =   1455
         End
         Begin VB.OptionButton rdgVideoRenderer8 
            Caption         =   "None (saves cpu)"
            Height          =   255
            Left            =   120
            TabIndex        =   3
            Tag             =   "7"
            Top             =   1920
            Width           =   1575
         End
      End
      Begin VB.CheckBox chkAdjustPixelAspectRatio 
         Caption         =   "adjust pixel aspect ratio"
         Height          =   255
         Left            =   1920
         TabIndex        =   1
         Top             =   240
         Width           =   2175
      End
      Begin VB.Image imgLogo 
         Height          =   1080
         Left            =   2040
         Picture         =   "Display.frx":0000
         Stretch         =   -1  'True
         Top             =   1560
         Width           =   1440
      End
   End
End
Attribute VB_Name = "Display"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

' VB 6 form revision bringing metrics in line with DataStead DLL Demo, BorderStyle and Display_AutoSize handling,
'  and resultant requisite code


Private boolPanScan As Boolean
Private PanScanVGWidth As Long
Private PanScanVGHeight As Long



Private Sub btnTestPanScan_Click()

    
    ' embedding VideoGrabberVB61 and disabling Display_AutoSize and AdjustPixelAspectRatio
    chk1stEmbedded.Value = 1                ' enable VideoGrabberVB61.Display_Embedded
    chkAdjustPixelAspectRatio.Value = 0     ' disable AdjustPixelAspectRatio
    chk1stAutoSize.Value = 0                ' disable Display_AutoSize
    
    ' disabling Display_AutoSize alone will not restore actual video Width and Height
    '  without using StopPreview and changing Width or Height values...
    ' however, altering BorderStyle with Display_AutoSize disabled will dynamically
    '  retore the video size to the control Width and Height
    ' with Display_AutoSize disabled, resize the video to control Width and Height
    '  size by changing and then restoring BorderStyle (if Display_Embedded):
    MainForm.VideoGrabberVB61.BorderStyle = IIf(MainForm.VideoGrabberVB61.BorderStyle = bsNone, bsSingle, bsNone)
    MainForm.VideoGrabberVB61.BorderStyle = IIf(MainForm.VideoGrabberVB61.BorderStyle = bsNone, bsSingle, bsNone)
    ' for pan / scan demonstration, change actual Width and Height to a
    '  16 x 9 aspect ratio, or restore to initial Width and Height
    If boolPanScan Then
        MainForm.VideoGrabberVB61.Width = PanScanVGWidth
        MainForm.VideoGrabberVB61.Height = PanScanVGHeight
    Else
        PanScanVGWidth = MainForm.VideoGrabberVB61.Width
        PanScanVGHeight = MainForm.VideoGrabberVB61.Height
        MainForm.VideoGrabberVB61.Width = MainForm.VideoGrabberVB61.Height * (16 / 9)
    End If
    boolPanScan = Not boolPanScan
    
    ' setting Display_AspectRatio to ar_PanScan (pan and scan)
    rdg1Pan.Value = True
    
    
End Sub

Private Sub btnTestPanScanHelp_Click()
    
    MsgBox "Test Display_AspectRatio settings with Display_AutoSize disabled:" & vbCrLf & vbCrLf & _
            "With Display_AutoSize = False and AdjustPixelAspectRatio= False, the Display_AspectRatio setting" & vbCrLf & _
            "  determines how the video is displayed within the control Width and Height properties:" & vbCrLf & _
            "  ar_Box: video appears in full with correct aspect ratio (e.g. letterbox)" & vbCrLf & _
            "  ar_NoResize: video appears in ""native"" size with correct aspect ratio" & vbCrLf & _
            "  ar_Stretch: video is stretched to fill the control, regardless of correct aspect ratio" & vbCrLf & _
            "  ar_PanScan: Display_PanScanRatio (0-100) determines setting between ""letterbox"" and ""pan-scan""" & vbCrLf & vbCrLf & _
            "(see Help: ""User guide.Display - Dual display.Video window"")", _
            vbOKOnly, _
            "DataStead TVideoGrabber VB 6 OCX Demo"
    
End Sub

Private Sub Form_Unload(Cancel As Integer)
   If Not MainForm.CanUnload Then
      Hide
      Cancel = True
   End If
End Sub

Public Sub RefreshDisplayOptions()

   ' this procedure is called each time a setting of this form is changed,
   ' to show what features can be used, according to their respective states

   ' NOTE: duplicating 2 times all the components of this form for the 2 windows
   ' is not very efficient, this has been done only for a better readability.

   
   chk1stVisible.Value = -MainForm.VideoGrabberVB61.Display_Visible
   chk1stVideoWindowActive.Value = -MainForm.VideoGrabberVB61.Display_Active
   chk1stEmbedded.Value = -MainForm.VideoGrabberVB61.Display_Embedded
   chk1stFullScreen.Value = -MainForm.VideoGrabberVB61.Display_FullScreen
   chk1stStayOnTop.Value = -MainForm.VideoGrabberVB61.Display_StayOnTop
   chk1stUseVideoPort.Value = -MainForm.VideoGrabberVB61.Display_VideoPortEnabled
   chk1stMouseMovesWindow.Value = -MainForm.VideoGrabberVB61.Display_MouseMovesWindow
   chk1stAutoSize.Value = -MainForm.VideoGrabberVB61.Display_AutoSize
   SetOptionButtonByIndex rdg1stDisplayedOn, MainForm.VideoGrabberVB61.Display_Monitor
   SetOptionButtonByIndex grb1AspectRatio, MainForm.VideoGrabberVB61.Display_AspectRatio
   sld1stPanScanRatio.Value = MainForm.VideoGrabberVB61.Display_PanScanRatio

   EnableOrDisableFrameControls grbMainVideoWindow, MainForm.VideoGrabberVB61.Display_Active
   grbMainVideoWindow.Enabled = MainForm.VideoGrabberVB61.Display_Active

   If MainForm.VideoGrabberVB61.Display_Active Then
      chk1stStayOnTop.Enabled = (Not MainForm.VideoGrabberVB61.Display_Embedded) Or MainForm.VideoGrabberVB61.Display_FullScreen
      chk1stMouseMovesWindow.Enabled = Not MainForm.VideoGrabberVB61.Display_Embedded
      rdg1stDisplayedOn.Enabled = Not MainForm.VideoGrabberVB61.Display_Embedded
      btnEG1stNewLocation.Enabled = Not MainForm.VideoGrabberVB61.Display_Embedded
      btnEG1stNewLocation2.Enabled = Not MainForm.VideoGrabberVB61.Display_Embedded
      chk1stUseVideoPort.Enabled = MainForm.VideoGrabberVB61.IsVideoPortAvailable
   End If

   chk2ndVisible.Value = -MainForm.VideoGrabberVB61.DualDisplay_Visible
   chk2ndVideoWindowActive.Value = -MainForm.VideoGrabberVB61.DualDisplay_Active
   chk2ndEmbedded.Value = -MainForm.VideoGrabberVB61.DualDisplay_Embedded
   chk2ndFullScreen.Value = -MainForm.VideoGrabberVB61.DualDisplay_FullScreen
   chk2ndStayOnTop.Value = -MainForm.VideoGrabberVB61.DualDisplay_StayOnTop
   chk2ndUseVideoPort.Value = -MainForm.VideoGrabberVB61.DualDisplay_VideoPortEnabled
   chk2ndMouseMovesWindow.Value = -MainForm.VideoGrabberVB61.DualDisplay_MouseMovesWindow
   chk2ndAutoSize.Value = -MainForm.VideoGrabberVB61.DualDisplay_AutoSize
   SetOptionButtonByIndex rdg2ndDisplayedOn, MainForm.VideoGrabberVB61.DualDisplay_Monitor
   SetOptionButtonByIndex grb2AspectRatio, MainForm.VideoGrabberVB61.DualDisplay_AspectRatio
   sld2ndPanScanRatio.Value = MainForm.VideoGrabberVB61.DualDisplay_PanScanRatio

   EnableOrDisableFrameControls grb2ndVideoWindow, MainForm.VideoGrabberVB61.DualDisplay_Active
   grb2ndVideoWindow.Enabled = MainForm.VideoGrabberVB61.DualDisplay_Active

   If MainForm.VideoGrabberVB61.DualDisplay_Active Then
      chk2ndStayOnTop.Enabled = (Not MainForm.VideoGrabberVB61.DualDisplay_Embedded) Or MainForm.VideoGrabberVB61.DualDisplay_FullScreen
      chk2ndMouseMovesWindow.Enabled = Not MainForm.VideoGrabberVB61.DualDisplay_Embedded
      rdg2ndDisplayedOn.Enabled = Not MainForm.VideoGrabberVB61.DualDisplay_Embedded
      btnEG2ndNewLocation.Enabled = Not MainForm.VideoGrabberVB61.DualDisplay_Embedded
      btnEG2ndNewLocation.Enabled = Not MainForm.VideoGrabberVB61.DualDisplay_Embedded
      chk2ndUseVideoPort.Enabled = MainForm.VideoGrabberVB61.IsVideoPortAvailable
   End If
End Sub

Private Sub btnEG1stNewLocation_Click()
   MainForm.VideoGrabberVB61.Display_AutoSize = True  ' the component"s video size will be used
   MainForm.VideoGrabberVB61.Display_Embedded = False ' detach from component
   MainForm.VideoGrabberVB61.Display_SetLocation 10, 10, 320, 240 ' 320 and 240 are not used because of AutoSize above
   RefreshDisplayOptions
End Sub

Private Sub btnEG1stNewLocation2_Click()
   MainForm.VideoGrabberVB61.Display_AutoSize = False ' we will specify the size below
   MainForm.VideoGrabberVB61.Display_Embedded = False ' detach from component
   MainForm.VideoGrabberVB61.Display_SetLocation 20, 20, 480, 200 ' new size: 480 x 360
   RefreshDisplayOptions
End Sub

Private Sub btnEG2ndNewLocation_Click()
   MainForm.VideoGrabberVB61.DualDisplay_AutoSize = True  ' the component"s video size will be used
   MainForm.VideoGrabberVB61.DualDisplay_Embedded = False ' detach from component
   MainForm.VideoGrabberVB61.DualDisplay_SetLocation 510, 10, 320, 240 ' 320 and 240 are not used because of AutoSize above
   RefreshDisplayOptions

End Sub

Private Sub btnEG2ndNewLocation2_Click()
   MainForm.VideoGrabberVB61.DualDisplay_AutoSize = False ' we will specify the size below
   MainForm.VideoGrabberVB61.DualDisplay_Embedded = False ' detach from component
   MainForm.VideoGrabberVB61.DualDisplay_SetLocation 520, 30, 480, 200 ' new size: 480 x 360
   RefreshDisplayOptions
End Sub

Private Sub chkAdjustPixelAspectRatio_Click()
   MainForm.VideoGrabberVB61.AdjustPixelAspectRatio = chkAdjustPixelAspectRatio.Value = Checked
   RefreshDisplayOptions
End Sub

Private Sub chk1stAutoSize_Click()
    MainForm.VideoGrabberVB61.Display_AutoSize = (chk1stAutoSize.Value = Checked)
    RefreshDisplayOptions
   
    
    ' disabling Display_AutoSize alone will not restore actual video Width and Height
    '  without using StopPreview and changing Width or Height values;
    ' however, altering BorderStyle with Display_AutoSize disabled will dynamically
    '  retore the video size to the control Width and Height
    ' with Display_AutoSize disabled, resize the video to control Width and Height
    '  size by changing and then restoring BorderStyle (if Display_Embedded):
    If Not MainForm.VideoGrabberVB61.Display_AutoSize Then
        MainForm.VideoGrabberVB61.BorderStyle = IIf(MainForm.VideoGrabberVB61.BorderStyle = bsNone, bsSingle, bsNone)
        MainForm.VideoGrabberVB61.BorderStyle = IIf(MainForm.VideoGrabberVB61.BorderStyle = bsNone, bsSingle, bsNone)
    End If
    

End Sub

Private Sub chk1stVisible_Click()
    MainForm.VideoGrabberVB61.Display_Visible = (chk1stVisible.Value = Checked)
End Sub

Private Sub chk1stEmbedded_Click()
   MainForm.VideoGrabberVB61.Display_Embedded = chk1stEmbedded.Value = Checked
   RefreshDisplayOptions
End Sub

Private Sub chk1stFullScreen_Click()
   MainForm.VideoGrabberVB61.Display_FullScreen = chk1stFullScreen.Value = Checked
   RefreshDisplayOptions
End Sub

Private Sub chk1stMouseMovesWindow_Click()
   MainForm.VideoGrabberVB61.Display_MouseMovesWindow = chk1stMouseMovesWindow.Value = Checked
   RefreshDisplayOptions
End Sub

Private Sub chk1stStayOnTop_Click()
   MainForm.VideoGrabberVB61.Display_StayOnTop = chk1stStayOnTop.Value = Checked
   RefreshDisplayOptions
End Sub

Private Sub chk1stUseVideoPort_Click()
   MainForm.VideoGrabberVB61.Display_VideoPortEnabled = chk1stUseVideoPort.Value = Checked
   RefreshDisplayOptions
End Sub

Private Sub chk1stVideoWindowActive_Click()
   MainForm.VideoGrabberVB61.Display_Active = chk1stVideoWindowActive.Value = Checked
   RefreshDisplayOptions
End Sub

Private Sub chk2ndAutoSize_Click()
   MainForm.VideoGrabberVB61.DualDisplay_AutoSize = chk2ndAutoSize.Value = Checked
   RefreshDisplayOptions
   
    
    ' disabling DualDisplay_AutoSize alone will not restore actual video Width and Height
    '  without using StopPreview and changing Width or Height values;
    ' however, altering BorderStyle with DualDisplay_AutoSize disabled will dynamically
    '  retore the video size to the control Width and Height
    ' with DualDisplay_AutoSize disabled, resize the video to control Width and Height
    '  size by changing and then restoring BorderStyle (if DualDisplay_Embedded):
    If Not MainForm.VideoGrabberVB61.DualDisplay_AutoSize Then
        MainForm.VideoGrabberVB61.BorderStyle = IIf(MainForm.VideoGrabberVB61.BorderStyle = bsNone, bsSingle, bsNone)
        MainForm.VideoGrabberVB61.BorderStyle = IIf(MainForm.VideoGrabberVB61.BorderStyle = bsNone, bsSingle, bsNone)
    End If
    
End Sub

Private Sub chk2ndVisible_Click()
    MainForm.VideoGrabberVB61.DualDisplay_Visible = (chk2ndVisible.Value = Checked)
End Sub

Private Sub chk2ndEmbedded_Click()
   MainForm.VideoGrabberVB61.DualDisplay_Embedded = chk2ndEmbedded.Value = Checked
   RefreshDisplayOptions
End Sub

Private Sub chk2ndFullScreen_Click()
   MainForm.VideoGrabberVB61.DualDisplay_FullScreen = chk2ndFullScreen.Value = Checked
   RefreshDisplayOptions
End Sub

Private Sub chk2ndMouseMovesWindow_Click()
   MainForm.VideoGrabberVB61.DualDisplay_MouseMovesWindow = chk2ndMouseMovesWindow.Value = Checked
   RefreshDisplayOptions
End Sub

Private Sub chk2ndStayOnTop_Click()
   MainForm.VideoGrabberVB61.DualDisplay_StayOnTop = chk2ndStayOnTop.Value = Checked
   RefreshDisplayOptions
End Sub

Private Sub chk2ndUseVideoPort_Click()
   MainForm.VideoGrabberVB61.DualDisplay_VideoPortEnabled = chk2ndUseVideoPort.Value = Checked
   RefreshDisplayOptions
End Sub

Private Sub chk2ndVideoWindowActive_Click()
   MainForm.VideoGrabberVB61.DualDisplay_Active = chk2ndVideoWindowActive.Value = Checked
   RefreshDisplayOptions
End Sub

Private Sub chkBorder_Click()
   If chkBorder.Value = Checked Then
      MainForm.VideoGrabberVB61.BorderStyle = bsSingle
   Else
      MainForm.VideoGrabberVB61.BorderStyle = bsNone
   End If
End Sub

Private Sub chkChangeCursor_Click()
   Select Case chkChangeCursor.Value
      Case Checked
         MainForm.VideoGrabberVB61.VideoCursor = cr_cross
      Case Unchecked
         MainForm.VideoGrabberVB61.VideoCursor = cr_Default
   End Select
End Sub

Private Sub chkSetLogo_Click()
   Select Case chkSetLogo.Value
      Case Checked
'         imgLogo.Visible = False
      
         MainForm.VideoGrabberVB61.SetLogoFromHBitmap (imgLogo.Picture.Handle)
         MainForm.VideoGrabberVB61.LogoLayout = lg_Stretched
         MainForm.VideoGrabberVB61.LogoDisplayed = True
       Case Unchecked
         MainForm.VideoGrabberVB61.LogoDisplayed = False
         
'         imgLogo.Visible = True
       
    End Select
End Sub

Private Sub chkTransparency_Click()
   TransparentWindow.BackColor = MainForm.VideoGrabberVB61.ColorKey
   TransparentWindow.LabelTransparentWindow.BackColor = MainForm.VideoGrabberVB61.ColorKey
   MainForm.VideoGrabberVB61.SetWindowTransparency TransparentWindow.hwnd, True, False, 0
   MainForm.VideoGrabberVB61.ColorKeyEnabled = True
   TransparentWindow.Show
End Sub

Private Sub chkVideoVisibleWhenStopped_Click()
   MainForm.VideoGrabberVB61.VideoVisibleWhenStopped = chkVideoVisibleWhenStopped.Value
End Sub

Private Sub rdg1Box_Click()
   MainForm.VideoGrabberVB61.Display_AspectRatio = ar_Box
End Sub

Private Sub rdg1NoResize_Click()
   MainForm.VideoGrabberVB61.Display_AspectRatio = ar_NoResize
End Sub

Private Sub rdg1Pan_Click()
   MainForm.VideoGrabberVB61.Display_AspectRatio = ar_PanScan
End Sub

Private Sub rdg1Stretch_Click()
   MainForm.VideoGrabberVB61.Display_AspectRatio = ar_Stretch
End Sub

Private Sub sld1stPanScanRatio_Scroll()
    MainForm.VideoGrabberVB61.Display_PanScanRatio = sld1stPanScanRatio.Value
End Sub

Private Sub rdg1stDisplayedOn1_Click()
   MainForm.VideoGrabberVB61.Display_Monitor = 0
   RefreshDisplayOptions
End Sub

Private Sub rdg1stDisplayedOn2_Click()
   MainForm.VideoGrabberVB61.Display_Monitor = 1
   RefreshDisplayOptions
End Sub

Private Sub rdg2ndDisplayedOn1_Click()
   MainForm.VideoGrabberVB61.DualDisplay_Monitor = 0
   RefreshDisplayOptions
End Sub

Private Sub rdg2ndDisplayedOn2_Click()
   MainForm.VideoGrabberVB61.DualDisplay_Monitor = 1
   RefreshDisplayOptions
End Sub

Private Sub rdg2Box_Click()
   MainForm.VideoGrabberVB61.DualDisplay_AspectRatio = ar_Box
End Sub

Private Sub rdg2NoResize_Click()
   MainForm.VideoGrabberVB61.DualDisplay_AspectRatio = ar_NoResize
End Sub

Private Sub rdg2Pan_Click()
   MainForm.VideoGrabberVB61.DualDisplay_AspectRatio = ar_PanScan
End Sub

Private Sub rdg2Stretch_Click()
   MainForm.VideoGrabberVB61.DualDisplay_AspectRatio = ar_Stretch
End Sub

Private Sub sld2ndPanScanRatio_Scroll()
    MainForm.VideoGrabberVB61.DualDisplay_PanScanRatio = sld2ndPanScanRatio.Value
End Sub

Private Sub rdgVideoRenderer1_Click()
   MainForm.VideoGrabberVB61.VideoRenderer = vr_AutoSelect
End Sub

Private Sub rdgVideoRenderer2_Click()
   MainForm.VideoGrabberVB61.VideoRenderer = vr_EVR
End Sub

Private Sub rdgVideoRenderer3_Click()
   MainForm.VideoGrabberVB61.VideoRenderer = vr_VMR9
End Sub

Private Sub rdgVideoRenderer4_Click()
   MainForm.VideoGrabberVB61.VideoRenderer = vr_VMR7
End Sub

Private Sub rdgVideoRenderer5_Click()
   MainForm.VideoGrabberVB61.VideoRenderer = vr_StandardRenderer
End Sub

Private Sub rdgVideoRenderer6_Click()
   MainForm.VideoGrabberVB61.VideoRenderer = vr_OverlayRenderer
End Sub

Private Sub rdgVideoRenderer7_Click()
    MainForm.VideoGrabberVB61.VideoRenderer = vr_RecordingPriority
End Sub

Private Sub rdgVideoRenderer8_Click()
    MainForm.VideoGrabberVB61.VideoRenderer = vr_None
End Sub


