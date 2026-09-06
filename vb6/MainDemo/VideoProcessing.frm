VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form VideoProcessing 
   BorderStyle     =   0  'None
   ClientHeight    =   3165
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   13875
   ControlBox      =   0   'False
   FillStyle       =   0  'Solid
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   211
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   925
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame framTabs 
      BorderStyle     =   0  'None
      Height          =   2700
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   13575
      Begin VB.Frame grbSoftwareVideoProcessing 
         Caption         =   "Software video processing"
         Height          =   2655
         Left            =   0
         TabIndex        =   27
         Top             =   0
         Width           =   7095
         Begin VB.VScrollBar vscVideoPixelization 
            Height          =   300
            Left            =   3120
            Max             =   -1
            Min             =   -100
            TabIndex        =   51
            Top             =   2160
            Value           =   -1
            Width           =   255
         End
         Begin VB.TextBox edtVideoPixelization 
            Height          =   300
            Left            =   2760
            Locked          =   -1  'True
            TabIndex        =   50
            Text            =   "1"
            Top             =   2160
            Width           =   375
         End
         Begin VB.CheckBox chkInvertColors 
            Caption         =   "inv. colors"
            Height          =   255
            Left            =   3800
            TabIndex        =   49
            Top             =   1400
            Width           =   1215
         End
         Begin VB.CheckBox chkGreyScale 
            Caption         =   "greyscale"
            Height          =   195
            Left            =   3800
            TabIndex        =   48
            Top             =   2240
            Width           =   1095
         End
         Begin VB.CheckBox chkFlipHorizontal 
            Caption         =   "flip horz."
            Height          =   195
            Left            =   3800
            TabIndex        =   47
            Top             =   1960
            Width           =   975
         End
         Begin VB.CheckBox chkFlipVertical 
            Caption         =   "flip vert."
            Height          =   240
            Left            =   3800
            TabIndex        =   46
            Top             =   1680
            Width           =   855
         End
         Begin VB.Frame rdgDeinterlacing 
            Caption         =   "Deinterlacing"
            Height          =   1095
            Left            =   3600
            TabIndex        =   42
            Top             =   240
            Width           =   1455
            Begin VB.OptionButton rdgDeinterlacing1 
               Caption         =   "disabled"
               Height          =   255
               Left            =   200
               TabIndex        =   45
               Tag             =   "0"
               Top             =   240
               Width           =   975
            End
            Begin VB.OptionButton rdgDeinterlacing2 
               Caption         =   "half-size"
               Height          =   255
               Left            =   200
               TabIndex        =   44
               Tag             =   "1"
               Top             =   480
               Width           =   975
            End
            Begin VB.OptionButton rdgDeinterlacing3 
               Caption         =   "full size"
               Height          =   255
               Left            =   200
               TabIndex        =   43
               Tag             =   "2"
               Top             =   720
               Width           =   975
            End
         End
         Begin VB.Frame rdgVideoRotation 
            Caption         =   "Video rotation (in degrees)"
            Height          =   1815
            Left            =   120
            TabIndex        =   29
            Top             =   240
            Width           =   3375
            Begin VB.TextBox edtVideoRotation 
               Height          =   300
               Left            =   2400
               TabIndex        =   40
               Text            =   "45.5"
               Top             =   1440
               Width           =   615
            End
            Begin VB.OptionButton rdgVideoRotation10 
               Caption         =   "custom mirror"
               Height          =   255
               Left            =   1680
               TabIndex        =   39
               Tag             =   "9"
               Top             =   1200
               Width           =   1335
            End
            Begin VB.OptionButton rdgVideoRotation9 
               Caption         =   "custom angle"
               Height          =   255
               Left            =   220
               TabIndex        =   38
               Tag             =   "8"
               Top             =   1200
               Width           =   1335
            End
            Begin VB.OptionButton rdgVideoRotation4 
               Caption         =   "270"
               Height          =   255
               Left            =   220
               TabIndex        =   37
               Tag             =   "3"
               Top             =   960
               Width           =   615
            End
            Begin VB.OptionButton rdgVideoRotation2 
               Caption         =   "90"
               Height          =   255
               Left            =   220
               TabIndex        =   36
               Tag             =   "1"
               Top             =   480
               Width           =   615
            End
            Begin VB.OptionButton rdgVideoRotation3 
               Caption         =   "180"
               Height          =   255
               Left            =   220
               TabIndex        =   35
               Tag             =   "2"
               Top             =   720
               Width           =   615
            End
            Begin VB.OptionButton rdgVideoRotation1 
               Caption         =   "0"
               Height          =   255
               Left            =   220
               TabIndex        =   34
               Tag             =   "0"
               Top             =   240
               Width           =   615
            End
            Begin VB.OptionButton rdgVideoRotation5 
               Caption         =   "0 mirror"
               Height          =   255
               Left            =   1680
               TabIndex        =   33
               Tag             =   "4"
               Top             =   240
               Width           =   975
            End
            Begin VB.OptionButton rdgVideoRotation6 
               Caption         =   "90 mirror"
               Height          =   255
               Left            =   1680
               TabIndex        =   32
               Tag             =   "5"
               Top             =   480
               Width           =   975
            End
            Begin VB.OptionButton rdgVideoRotation7 
               Caption         =   "180 mirror"
               Height          =   255
               Left            =   1680
               TabIndex        =   31
               Tag             =   "6"
               Top             =   720
               Width           =   1215
            End
            Begin VB.OptionButton rdgVideoRotation8 
               Caption         =   "270 mirror"
               Height          =   255
               Left            =   1680
               TabIndex        =   30
               Tag             =   "7"
               Top             =   960
               Width           =   1215
            End
            Begin VB.Label Label7 
               Alignment       =   1  'Right Justify
               Caption         =   "custom rotation angle (<=360)"
               Height          =   255
               Left            =   120
               TabIndex        =   41
               Top             =   1480
               Width           =   2175
            End
         End
         Begin VB.CommandButton btnResetAll 
            Caption         =   "reset all"
            Height          =   375
            Left            =   120
            TabIndex        =   28
            Top             =   2160
            Width           =   1335
         End
         Begin MSComctlLib.Slider tbrBrightness 
            Height          =   2200
            Left            =   5400
            TabIndex        =   52
            Top             =   135
            Width           =   300
            _ExtentX        =   529
            _ExtentY        =   3889
            _Version        =   393216
            Orientation     =   1
            Min             =   -128
            Max             =   128
            TickStyle       =   2
            TickFrequency   =   0
         End
         Begin MSComctlLib.Slider tbrContrast 
            Height          =   2200
            Left            =   5760
            TabIndex        =   53
            Top             =   135
            Width           =   300
            _ExtentX        =   529
            _ExtentY        =   3889
            _Version        =   393216
            Orientation     =   1
            Min             =   -128
            Max             =   128
            TickStyle       =   2
            TickFrequency   =   0
         End
         Begin MSComctlLib.Slider tbrSaturation 
            Height          =   2200
            Left            =   6120
            TabIndex        =   54
            Top             =   135
            Width           =   300
            _ExtentX        =   529
            _ExtentY        =   3889
            _Version        =   393216
            Orientation     =   1
            Min             =   -64
            Max             =   64
            TickStyle       =   2
            TickFrequency   =   0
         End
         Begin MSComctlLib.Slider tbrHue 
            Height          =   2200
            Left            =   6480
            TabIndex        =   55
            Top             =   135
            Width           =   300
            _ExtentX        =   529
            _ExtentY        =   3889
            _Version        =   393216
            Orientation     =   1
            Min             =   -180
            Max             =   180
            TickStyle       =   2
            TickFrequency   =   0
         End
         Begin VB.Label lblSWVideoProcessingRequiresFrameGrabber 
            AutoSize        =   -1  'True
            Caption         =   "the frame grabber must be enabled"
            ForeColor       =   &H000000FF&
            Height          =   195
            Left            =   2400
            TabIndex        =   58
            Top             =   0
            Visible         =   0   'False
            Width           =   2460
         End
         Begin VB.Label Label6 
            Alignment       =   1  'Right Justify
            Caption         =   "pixelization"
            Height          =   255
            Left            =   1680
            TabIndex        =   57
            Top             =   2205
            Width           =   975
         End
         Begin VB.Label Label1 
            AutoSize        =   -1  'True
            Caption         =   "bright  cont.  sat.  hue"
            Height          =   195
            Left            =   5280
            TabIndex        =   56
            Top             =   2280
            Width           =   1545
         End
      End
      Begin VB.Frame grbCropping 
         Caption         =   "Cropping"
         Height          =   1935
         Left            =   9600
         TabIndex        =   13
         Top             =   0
         Width           =   3975
         Begin VB.CommandButton btnCroppingZoomReset 
            Caption         =   "reset"
            Height          =   255
            Left            =   120
            TabIndex        =   18
            Top             =   1440
            Width           =   615
         End
         Begin VB.TextBox edtCroppingHeight 
            Height          =   285
            Left            =   2400
            TabIndex        =   17
            Top             =   480
            Width           =   735
         End
         Begin VB.TextBox edtCroppingWidth 
            Height          =   285
            Left            =   2400
            TabIndex        =   16
            Top             =   160
            Width           =   735
         End
         Begin VB.CheckBox chkCroppingOutbounds 
            Caption         =   "out bounds"
            Height          =   255
            Left            =   120
            TabIndex        =   15
            Top             =   520
            Width           =   1095
         End
         Begin VB.CheckBox chkCroppingEnabled 
            Caption         =   "enabled"
            Height          =   255
            Left            =   120
            TabIndex        =   14
            Top             =   240
            Width           =   975
         End
         Begin MSComctlLib.Slider trkCroppingX 
            Height          =   300
            Left            =   1560
            TabIndex        =   19
            Top             =   1440
            Width           =   1815
            _ExtentX        =   3201
            _ExtentY        =   529
            _Version        =   393216
            Max             =   30000
            TickFrequency   =   3000
         End
         Begin MSComctlLib.Slider trkCroppingY 
            Height          =   1695
            Left            =   3480
            TabIndex        =   20
            Top             =   120
            Width           =   300
            _ExtentX        =   529
            _ExtentY        =   2990
            _Version        =   393216
            Orientation     =   1
            Max             =   30000
            TickFrequency   =   3000
         End
         Begin MSComctlLib.Slider trkCroppingZoom 
            Height          =   255
            Left            =   120
            TabIndex        =   21
            Top             =   1080
            Width           =   2895
            _ExtentX        =   5106
            _ExtentY        =   450
            _Version        =   393216
            Max             =   1000
            TickFrequency   =   50
         End
         Begin VB.Label Label4 
            Alignment       =   1  'Right Justify
            Caption         =   "area height:"
            Height          =   255
            Left            =   1480
            TabIndex        =   26
            Top             =   555
            Width           =   855
         End
         Begin VB.Label Label3 
            Alignment       =   1  'Right Justify
            Caption         =   "area width:"
            Height          =   255
            Left            =   1480
            TabIndex        =   25
            Top             =   195
            Width           =   855
         End
         Begin VB.Label Label34 
            Caption         =   "cropping zoom"
            Height          =   255
            Left            =   120
            TabIndex        =   24
            Top             =   860
            Width           =   1695
         End
         Begin VB.Label Label33 
            AutoSize        =   -1  'True
            Caption         =   "Y pos"
            Height          =   195
            Left            =   3000
            TabIndex        =   23
            Top             =   840
            Width           =   405
         End
         Begin VB.Label Label32 
            Alignment       =   1  'Right Justify
            Caption         =   "X pos"
            Height          =   255
            Left            =   960
            TabIndex        =   22
            Top             =   1440
            Width           =   495
         End
      End
      Begin VB.Frame grpVMR9Adjust 
         Caption         =   "VMR9 image adjustment"
         Height          =   1935
         Left            =   7200
         TabIndex        =   5
         Top             =   0
         Width           =   2295
         Begin VB.CheckBox vmr9FixRange 
            Height          =   375
            Left            =   240
            TabIndex        =   6
            Top             =   480
            Value           =   1  'Checked
            Width           =   255
         End
         Begin MSComctlLib.Slider tbrVMR9Brightness 
            Height          =   1455
            Left            =   720
            TabIndex        =   7
            Top             =   240
            Width           =   300
            _ExtentX        =   529
            _ExtentY        =   2566
            _Version        =   393216
            Orientation     =   1
            Min             =   -128
            Max             =   128
            TickStyle       =   2
            TickFrequency   =   0
         End
         Begin MSComctlLib.Slider tbrVMR9Contrast 
            Height          =   1455
            Left            =   1080
            TabIndex        =   8
            Top             =   240
            Width           =   300
            _ExtentX        =   529
            _ExtentY        =   2566
            _Version        =   393216
            Orientation     =   1
            Min             =   -128
            Max             =   128
            TickStyle       =   2
            TickFrequency   =   0
         End
         Begin MSComctlLib.Slider tbrVMR9Saturation 
            Height          =   1455
            Left            =   1440
            TabIndex        =   9
            Top             =   240
            Width           =   300
            _ExtentX        =   529
            _ExtentY        =   2566
            _Version        =   393216
            Orientation     =   1
            Min             =   -64
            Max             =   64
            TickStyle       =   2
            TickFrequency   =   0
         End
         Begin MSComctlLib.Slider tbrVMR9Hue 
            Height          =   1455
            Left            =   1800
            TabIndex        =   10
            Top             =   240
            Width           =   300
            _ExtentX        =   529
            _ExtentY        =   2566
            _Version        =   393216
            Orientation     =   1
            Min             =   -180
            Max             =   180
            TickStyle       =   2
            TickFrequency   =   0
         End
         Begin VB.Shape shpVMR9Adjust 
            BackColor       =   &H000000FF&
            FillColor       =   &H000000FF&
            FillStyle       =   0  'Solid
            Height          =   135
            Left            =   240
            Shape           =   5  'Rounded Square
            Top             =   1680
            Width           =   135
         End
         Begin VB.Label Label5 
            Alignment       =   2  'Center
            Caption         =   "fix range"
            Height          =   375
            Left            =   120
            TabIndex        =   12
            Top             =   795
            Width           =   495
            WordWrap        =   -1  'True
         End
         Begin VB.Label Label2 
            AutoSize        =   -1  'True
            Caption         =   "bright  cont.  sat.  hue"
            Height          =   195
            Left            =   600
            TabIndex        =   11
            Top             =   1635
            Width           =   1545
         End
      End
      Begin VB.Frame grbDetectVideoSignal 
         Caption         =   "Detect video signal (adjustable)"
         Height          =   690
         Left            =   7200
         TabIndex        =   1
         Top             =   1960
         Width           =   6355
         Begin VB.OptionButton rdgDetectVideoSignalDisabled 
            Caption         =   "disabled"
            Height          =   255
            Left            =   240
            TabIndex        =   4
            Top             =   260
            Value           =   -1  'True
            Width           =   975
         End
         Begin VB.OptionButton rdgConnexantbluescreen 
            Caption         =   "Conexant blue screen"
            Height          =   255
            Left            =   4200
            TabIndex        =   3
            Top             =   260
            Width           =   2055
         End
         Begin VB.OptionButton rdgNoVideoSignal 
            Caption         =   "no signal (dark screen)"
            Height          =   255
            Left            =   2040
            TabIndex        =   2
            Top             =   260
            Width           =   1935
         End
      End
   End
End
Attribute VB_Name = "VideoProcessing"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit





Private Sub edtVideoRotation_Change()
    If IsNumeric(edtVideoRotation.Text) Then
        If Val(edtVideoRotation.Text) >= 0 And Val(edtVideoRotation.Text) <= 360 Then
            MainForm.VideoGrabberVB61.VideoProcessing_RotationCustomAngle = Val(edtVideoRotation.Text)
        End If
    End If
End Sub

Private Sub Form_Unload(Cancel As Integer)
   If Not MainForm.CanUnload Then
      Hide
      Cancel = True
   End If
End Sub

Private Sub btnCroppingZoomReset_Click()
   trkCroppingZoom.Value = 100
   trkCroppingZoom_Click
End Sub

Private Sub btnResetAll_Click()
   rdgVideoRotation1.Value = Checked
   rdgDeinterlacing1.Value = Checked
   tbrBrightness.Value = 0
   tbrBrightness_Click
   tbrContrast.Value = 0
   tbrContrast_Click
   tbrSaturation.Value = 0
   tbrSaturation_Click
   tbrHue.Value = 0
   tbrHue_Click
   chkGreyScale.Value = Unchecked
   chkInvertColors.Value = Unchecked
   chkFlipVertical.Value = Unchecked
   chkFlipHorizontal.Value = Unchecked
End Sub

Private Sub chkCroppingEnabled_Click()
   MainForm.VideoGrabberVB61.Cropping_Enabled = chkCroppingEnabled.Value = Checked
End Sub

Private Sub chkCroppingOutbounds_Click()
   MainForm.VideoGrabberVB61.Cropping_Outbounds = chkCroppingOutbounds.Value = Checked
End Sub

Private Sub chkFlipHorizontal_Click()
    MainForm.VideoGrabberVB61.VideoProcessing_FlipHorizontal = chkFlipHorizontal.Value = Checked
End Sub

Private Sub chkFlipVertical_Click()
    MainForm.VideoGrabberVB61.VideoProcessing_FlipVertical = chkFlipVertical.Value = Checked
End Sub

Private Sub chkGreyScale_Click()
    MainForm.VideoGrabberVB61.VideoProcessing_GrayScale = chkGreyScale.Value = Checked
End Sub

Private Sub chkInvertColors_Click()
    MainForm.VideoGrabberVB61.VideoProcessing_InvertColors = chkInvertColors.Value = Checked
End Sub

Private Sub edtCroppingHeight_Change()
    If IsNumeric(edtCroppingHeight.Text) Then
        MainForm.VideoGrabberVB61.Cropping_Height = edtCroppingHeight.Text
    End If
End Sub

Private Sub edtCroppingWidth_Change()
    If IsNumeric(edtCroppingWidth.Text) Then
        MainForm.VideoGrabberVB61.Cropping_Width = edtCroppingWidth.Text
    End If
End Sub

Private Sub rdgConnexantbluescreen_Click()
    MainForm.VideoProcessing_DetectConnexantBlueScreen = True
    MainForm.VideoProcessing_DetectNoVideoSignal = False
End Sub

Private Sub rdgDeinterlacing1_Click()
    MainForm.VideoGrabberVB61.VideoProcessing_Deinterlacing = di_Disabled
End Sub

Private Sub rdgDeinterlacing2_Click()
    MainForm.VideoGrabberVB61.VideoProcessing_Deinterlacing = di_HalfSize
End Sub

Private Sub rdgDeinterlacing3_Click()
    MainForm.VideoGrabberVB61.VideoProcessing_Deinterlacing = di_FullSize
End Sub

Private Sub rdgDetectVideoSignalDisabled_Click()
    MainForm.VideoProcessing_DetectNoVideoSignal = False
    MainForm.VideoProcessing_DetectConnexantBlueScreen = False
End Sub

Private Sub rdgNoVideoSignal_Click()
    MainForm.VideoProcessing_DetectNoVideoSignal = True
    MainForm.VideoProcessing_DetectConnexantBlueScreen = False
End Sub

Private Sub rdgVideoRotation1_Click()
    MainForm.VideoGrabberVB61.VideoProcessing_Rotation = rt_0_deg
End Sub

Private Sub rdgVideoRotation2_Click()
    MainForm.VideoGrabberVB61.VideoProcessing_Rotation = rt_90_deg
End Sub

Private Sub rdgVideoRotation3_Click()
    MainForm.VideoGrabberVB61.VideoProcessing_Rotation = rt_180_deg
End Sub

Private Sub rdgVideoRotation4_Click()
    MainForm.VideoGrabberVB61.VideoProcessing_Rotation = rt_270_deg
End Sub

Private Sub rdgVideoRotation5_Click()
    MainForm.VideoGrabberVB61.VideoProcessing_Rotation = rt_0_deg_mirror
End Sub

Private Sub rdgVideoRotation6_Click()
    MainForm.VideoGrabberVB61.VideoProcessing_Rotation = rt_90_deg_mirror
End Sub

Private Sub rdgVideoRotation7_Click()
    MainForm.VideoGrabberVB61.VideoProcessing_Rotation = rt_180_deg_mirror
End Sub

Private Sub rdgVideoRotation8_Click()
    MainForm.VideoGrabberVB61.VideoProcessing_Rotation = rt_270_deg_mirror
End Sub

Private Sub rdgVideoRotation9_Click()
    MainForm.VideoGrabberVB61.VideoProcessing_Rotation = rt_custom_angle
End Sub

Private Sub rdgVideoRotation10_Click()
    MainForm.VideoGrabberVB61.VideoProcessing_Rotation = rt_custom_angle_mirror
End Sub

Private Sub vscVideoPixelization_Change()
    edtVideoPixelization.Text = Abs(vscVideoPixelization.Value)
End Sub

Private Sub edtVideoPixelization_Change()
    MainForm.VideoGrabberVB61.VideoProcessing_Pixellization = Val(edtVideoPixelization.Text)
    vscVideoPixelization.Value = -MainForm.VideoGrabberVB61.VideoProcessing_Pixellization
End Sub

Private Sub tbrBrightness_Click()
   MainForm.VideoGrabberVB61.VideoProcessing_Brightness = -tbrBrightness.Value
End Sub

Private Sub tbrContrast_Click()
   MainForm.VideoGrabberVB61.VideoProcessing_Contrast = -tbrContrast.Value
End Sub

Private Sub tbrHue_Click()
   MainForm.VideoGrabberVB61.VideoProcessing_Hue = -tbrHue.Value
End Sub

Private Sub tbrSaturation_Click()
   MainForm.VideoGrabberVB61.VideoProcessing_Saturation = -tbrSaturation.Value
End Sub

Public Sub RefreshVMR9Processing()
    Dim MinValue As Long, MaxValue As Long, StepSize As Long, DefaultValue As Long, CurrentValue  As Long

    shpVMR9Adjust.FillColor = vbRed
    If MainForm.VideoGrabberVB61.IsVMR9ImageAdjustmentAvailable(True) Then
        With tbrVMR9Brightness
            .Enabled = MainForm.VideoGrabberVB61.GetVMR9ImageAdjustmentBounds(True, vmr9_Brightness, MinValue, MaxValue, StepSize, DefaultValue, CurrentValue)
            If .Enabled Then
                .Min = MinValue
                .Max = MaxValue + 1
                .SmallChange = StepSize
                .LargeChange = StepSize
                .Value = CurrentValue
                shpVMR9Adjust.FillColor = vbGreen
            Else
                .Value = .Min + ((.Max - .Min) / 2)
            End If
        End With
        With tbrVMR9Contrast
            .Enabled = MainForm.VideoGrabberVB61.GetVMR9ImageAdjustmentBounds(True, vmr9_Contrast, MinValue, MaxValue, StepSize, DefaultValue, CurrentValue)
            If .Enabled Then
                .Min = MinValue
                .Max = MaxValue + 1
                .SmallChange = StepSize
                .LargeChange = StepSize
                .Value = CurrentValue
                shpVMR9Adjust.FillColor = vbGreen
            Else
                .Value = .Min + ((.Max - .Min) / 2)
            End If
        End With
        With tbrVMR9Hue
            .Enabled = MainForm.VideoGrabberVB61.GetVMR9ImageAdjustmentBounds(True, vmr9_Hue, MinValue, MaxValue, StepSize, DefaultValue, CurrentValue)
            If .Enabled Then
                .Min = MinValue
                .Max = MaxValue + 1
                .SmallChange = StepSize
                .LargeChange = StepSize
                .Value = CurrentValue
                shpVMR9Adjust.FillColor = vbGreen
            Else
                .Value = .Min + ((.Max - .Min) / 2)
            End If
        End With
        With tbrVMR9Saturation
            .Enabled = MainForm.VideoGrabberVB61.GetVMR9ImageAdjustmentBounds(True, vmr9_Saturation, MinValue, MaxValue, StepSize, DefaultValue, CurrentValue)
            If .Enabled Then
                .Min = MinValue
                .Max = MaxValue + 1
                .SmallChange = StepSize
                .LargeChange = StepSize
                .Value = CurrentValue
                shpVMR9Adjust.FillColor = vbGreen
            Else
                .Value = .Min + ((.Max - .Min) / 2)
            End If
        End With
    Else
        tbrVMR9Brightness.Enabled = False
        tbrVMR9Contrast.Enabled = False
        tbrVMR9Hue.Enabled = False
        tbrVMR9Saturation.Enabled = False
    End If

End Sub

Private Sub vmr9FixRange_Click()
   ' fixes a possible problem of constrast and saturation range with some video decoders, passed to the SetVMR9ImageAdjustmentValue function below
End Sub

Private Sub tbrVMR9Brightness_Click()
   MainForm.VideoGrabberVB61.SetVMR9ImageAdjustmentValue True, vmr9_Brightness, tbrVMR9Brightness.Value, False
End Sub

Private Sub tbrVMR9Contrast_Click()
   MainForm.VideoGrabberVB61.SetVMR9ImageAdjustmentValue True, vmr9_Contrast, tbrVMR9Contrast.Value, vmr9FixRange.Value = Checked
End Sub

Private Sub tbrVMR9Hue_Click()
   MainForm.VideoGrabberVB61.SetVMR9ImageAdjustmentValue True, vmr9_Hue, tbrVMR9Hue.Value, False
End Sub

Private Sub tbrVMR9Saturation_Click()
   MainForm.VideoGrabberVB61.SetVMR9ImageAdjustmentValue True, vmr9_Saturation, tbrVMR9Saturation.Value, vmr9FixRange.Value = Checked
End Sub

Private Sub trkCroppingX_Click()
   ' trkCroppingX.Max and trkCroppingY.Max are set from the OnResizeVideo event
   MainForm.VideoGrabberVB61.Cropping_X = trkCroppingX.Value
End Sub

Private Sub trkCroppingY_Click()
   ' trkCroppingX.Max and trkCroppingY.Max are set from the OnResizeVideo event
   MainForm.VideoGrabberVB61.Cropping_Y = trkCroppingY.Value
End Sub

Private Sub trkCroppingZoom_Click()
   MainForm.VideoGrabberVB61.Cropping_Zoom = trkCroppingZoom.Value / 100
End Sub


