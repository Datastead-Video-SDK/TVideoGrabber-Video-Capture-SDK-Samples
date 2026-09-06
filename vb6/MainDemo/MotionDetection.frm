VERSION 5.00
Begin VB.Form MotionDetection 
   BorderStyle     =   0  'None
   ClientHeight    =   3255
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   14070
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   217
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   938
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame framTabs 
      BorderStyle     =   0  'None
      Height          =   2700
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   13575
      Begin VB.CommandButton btnMotionDetectionTriggerNow 
         Caption         =   "trigger now"
         Height          =   255
         Left            =   4920
         TabIndex        =   38
         Top             =   600
         Width           =   975
      End
      Begin VB.CheckBox chkMotionDetectionTriggered 
         Caption         =   "triggered"
         Height          =   255
         Left            =   4920
         TabIndex        =   37
         Top             =   320
         Width           =   975
      End
      Begin VB.TextBox mmoMotionGrid 
         BeginProperty Font 
            Name            =   "Courier New"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   2650
         Left            =   10680
         MultiLine       =   -1  'True
         ScrollBars      =   3  'Both
         TabIndex        =   36
         Top             =   0
         Width           =   2895
      End
      Begin VB.TextBox mmoSensitivityGrid 
         BeginProperty Font 
            Name            =   "Courier New"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   2650
         Left            =   7680
         MultiLine       =   -1  'True
         ScrollBars      =   3  'Both
         TabIndex        =   35
         Top             =   0
         Width           =   2895
      End
      Begin VB.Frame grbMotionRatio 
         Caption         =   "Global motion ratio"
         Height          =   615
         Left            =   6000
         TabIndex        =   33
         Top             =   1380
         Width           =   1575
         Begin VB.TextBox edtMotionRatio 
            BackColor       =   &H00C0C0C0&
            Height          =   285
            Left            =   480
            TabIndex        =   34
            Top             =   240
            Width           =   975
         End
         Begin VB.Shape shpMotionRatio 
            BackColor       =   &H00004000&
            BackStyle       =   1  'Opaque
            Height          =   240
            Left            =   120
            Shape           =   3  'Circle
            Top             =   240
            Width           =   240
         End
      End
      Begin VB.Frame grbXYMaxMotion 
         Caption         =   "max motion location"
         Height          =   630
         Left            =   5040
         TabIndex        =   30
         Top             =   2020
         Width           =   2535
         Begin VB.TextBox edtMaxMotionCoord 
            BackColor       =   &H00C0C0C0&
            Height          =   285
            Left            =   1200
            TabIndex        =   32
            Top             =   240
            Width           =   1215
         End
         Begin VB.TextBox edtMaxMotionXY 
            BackColor       =   &H00C0C0C0&
            Height          =   285
            Left            =   120
            TabIndex        =   31
            Top             =   240
            Width           =   975
         End
      End
      Begin VB.Frame Frame14 
         Caption         =   "cells sensitivity  (0 based index)"
         Height          =   930
         Left            =   2160
         TabIndex        =   21
         Top             =   1720
         Width           =   2775
         Begin VB.TextBox edtCellSensitivity 
            Height          =   320
            Left            =   1470
            TabIndex        =   25
            Text            =   "10"
            Top             =   480
            Width           =   450
         End
         Begin VB.CommandButton btnSetCellsSensitivity 
            Caption         =   "SET"
            Height          =   320
            Left            =   2160
            TabIndex        =   24
            Top             =   480
            Width           =   495
         End
         Begin VB.TextBox edtYCell 
            Height          =   320
            Left            =   800
            TabIndex        =   23
            Text            =   "10"
            Top             =   480
            Width           =   450
         End
         Begin VB.TextBox edtXCell 
            Height          =   320
            Left            =   120
            TabIndex        =   22
            Text            =   "10"
            Top             =   480
            Width           =   450
         End
         Begin VB.Label Label42 
            AutoSize        =   -1  'True
            Caption         =   "X cell       Y cell    sensitivity (0 .. 9)"
            Height          =   195
            Left            =   120
            TabIndex        =   28
            Top             =   240
            Width           =   2565
         End
      End
      Begin VB.Frame Frame13 
         Caption         =   "grid size"
         Height          =   930
         Left            =   0
         TabIndex        =   14
         Top             =   1720
         Width           =   2055
         Begin VB.CommandButton btnApplyGridSize 
            Caption         =   "OK"
            Height          =   320
            Left            =   1560
            TabIndex        =   17
            Top             =   480
            Width           =   375
         End
         Begin VB.TextBox edtGridRowCount 
            Height          =   320
            Left            =   840
            TabIndex        =   16
            Text            =   "10"
            Top             =   480
            Width           =   495
         End
         Begin VB.TextBox edtGridColCount 
            Height          =   320
            Left            =   120
            TabIndex        =   15
            Text            =   "10"
            Top             =   480
            Width           =   495
         End
         Begin VB.Label Label41 
            Caption         =   "col count/row count"
            Height          =   255
            Left            =   120
            TabIndex        =   20
            Top             =   240
            Width           =   1575
         End
      End
      Begin VB.Frame grbGridString 
         Caption         =   "grid string"
         Height          =   855
         Left            =   0
         TabIndex        =   9
         Top             =   840
         Width           =   5895
         Begin VB.TextBox edtGrid 
            Height          =   285
            Left            =   1080
            TabIndex        =   10
            Top             =   480
            Width           =   4695
         End
         Begin VB.Shape shpGridValid 
            FillColor       =   &H00A0A0A0&
            FillStyle       =   0  'Solid
            Height          =   240
            Left            =   180
            Shape           =   4  'Rounded Rectangle
            Top             =   440
            Width           =   200
         End
         Begin VB.Label lblGridValid 
            AutoSize        =   -1  'True
            Caption         =   "valid"
            Height          =   195
            Left            =   450
            TabIndex        =   12
            Top             =   480
            Width           =   435
         End
         Begin VB.Label Label39 
            AutoSize        =   -1  'True
            Caption         =   "sensitivity +/-"
            Height          =   195
            Left            =   840
            TabIndex        =   11
            Top             =   240
            Width           =   930
         End
      End
      Begin VB.CheckBox chkCompareGreen 
         Caption         =   "green"
         Height          =   255
         Left            =   2160
         TabIndex        =   8
         Top             =   600
         Width           =   735
      End
      Begin VB.CheckBox chkCompareBlue 
         Caption         =   "blue"
         Height          =   255
         Left            =   3000
         TabIndex        =   7
         Top             =   600
         Width           =   615
      End
      Begin VB.CheckBox chk_GreyScale 
         Caption         =   "greyscale"
         Height          =   255
         Left            =   3720
         TabIndex        =   6
         Top             =   600
         Width           =   975
      End
      Begin VB.CheckBox chkCompareRed 
         Caption         =   "red"
         Height          =   255
         Left            =   1460
         TabIndex        =   5
         Top             =   600
         Width           =   615
      End
      Begin VB.CommandButton btnShowGridDialog 
         Caption         =   "show grid dialog"
         Height          =   255
         Left            =   4560
         TabIndex        =   4
         Top             =   0
         Width           =   1335
      End
      Begin VB.CheckBox chkReduceVideoNoise 
         Caption         =   "reduce video noise"
         Height          =   255
         Left            =   2760
         TabIndex        =   3
         Top             =   300
         Width           =   1695
      End
      Begin VB.CheckBox chkMotionDetectionEnabled 
         Caption         =   "ENABLE MOTION DETECTION"
         Height          =   255
         Left            =   0
         TabIndex        =   2
         Top             =   300
         Width           =   2655
      End
      Begin VB.PictureBox imgMotionDetected 
         Height          =   1215
         Left            =   6000
         ScaleHeight     =   77
         ScaleMode       =   3  'Pixel
         ScaleWidth      =   101
         TabIndex        =   1
         Top             =   0
         Width           =   1575
      End
      Begin VB.Label Label38 
         Height          =   195
         Left            =   0
         TabIndex        =   41
         Top             =   600
         Width           =   1290
         VariousPropertyBits=   276824091
         Caption         =   "detection method:"
         Size            =   "2275;344"
         FontHeight      =   165
         FontCharSet     =   0
         FontPitchAndFamily=   2
      End
      Begin VB.Label lblMotionDetectorRequiresFrameGrabber 
         AutoSize        =   -1  'True
         Caption         =   "The frame grabber must be enabled"
         ForeColor       =   &H000000FF&
         Height          =   195
         Left            =   1680
         TabIndex        =   40
         Top             =   0
         Width           =   2520
      End
      Begin VB.Label Label36 
         AutoSize        =   -1  'True
         Caption         =   "Motion detection"
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
         TabIndex        =   39
         Top             =   0
         Width           =   1440
      End
   End
End
Attribute VB_Name = "MotionDetection"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit





Private Sub Form_Unload(Cancel As Integer)
   If Not MainForm.CanUnload Then
      Hide
      Cancel = True
   End If
End Sub

Private Sub btnApplyGridSize_Click()
    If IsNumeric(edtGridColCount.Text) And IsNumeric(edtGridRowCount.Text) Then
        MainForm.VideoGrabberVB61.MotionDetector_SetGridSize edtGridColCount.Text, edtGridRowCount.Text
        edtGrid.Text = MainForm.VideoGrabberVB61.MotionDetector_Grid
        mmoSensitivityGrid.Text = MainForm.VideoGrabberVB61.MotionDetector_Get2DTextGrid
    End If
End Sub

Private Sub btnSetCellsSensitivity_Click()
    If IsNumeric(edtXCell.Text) And IsNumeric(edtYCell.Text) And IsNumeric(edtCellSensitivity.Text) Then
        MainForm.VideoGrabberVB61.MotionDetector_SetCellSensitivity edtXCell.Text, edtYCell.Text, edtCellSensitivity.Text
        edtGrid.Text = MainForm.VideoGrabberVB61.MotionDetector_Grid
        mmoSensitivityGrid.Text = MainForm.VideoGrabberVB61.MotionDetector_Get2DTextGrid
    End If
End Sub

Private Sub btnShowGridDialog_Click()
    If (MainForm.VideoGrabberVB61.CurrentState <> cs_Preview) And (MainForm.VideoGrabberVB61.CurrentState <> cs_Recording) Then
        MsgBox "you should start preview or recording to see the video frame under the grid", _
            vbOKOnly, _
            "DataStead TVideoGrabber VB 6 OCX Demo"
    End If
    If Not MainForm.VideoGrabberVB61.MotionDetector_Enabled Then
       MsgBox "you should enable the motion detector first (MotionDetector_Enabled = true) to see the video frame under the grid", _
            vbOKOnly, _
            "DataStead TVideoGrabber VB 6 OCX Demo"
    End If
    If (MainForm.VideoGrabberVB61.MotionDetector_GridXCount > 30) Or (MainForm.VideoGrabberVB61.MotionDetector_GridYCount > 30) Then
       MsgBox "the grid will be too dense to be edited through the dialog, you should use SetGridCell", _
            vbOKOnly, _
            "DataStead TVideoGrabber VB 6 OCX Demo"
    End If
    MainForm.VideoGrabberVB61.MotionDetector_ShowGridDialog
    edtGrid.Text = MainForm.VideoGrabberVB61.MotionDetector_Grid
    mmoSensitivityGrid.Text = MainForm.VideoGrabberVB61.MotionDetector_Get2DTextGrid
End Sub

Private Sub chk_GreyScale_Click()
   MainForm.VideoGrabberVB61.MotionDetector_GreyScale = chk_GreyScale.Value = Checked
End Sub

Private Sub chkCompareBlue_Click()
   MainForm.VideoGrabberVB61.MotionDetector_CompareBlue = chkCompareBlue.Value = Checked
End Sub

Private Sub chkCompareGreen_Click()
   MainForm.VideoGrabberVB61.MotionDetector_CompareGreen = chkCompareGreen.Value = Checked
End Sub

Private Sub chkCompareRed_Click()
   MainForm.VideoGrabberVB61.MotionDetector_CompareRed = chkCompareRed.Value = Checked
End Sub

Private Sub chkMotionDetectionEnabled_Click()
   MainForm.VideoGrabberVB61.MotionDetector_Enabled = chkMotionDetectionEnabled.Value = Checked
End Sub

Private Sub chkReduceVideoNoise_Click()
   MainForm.VideoGrabberVB61.MotionDetector_ReduceVideoNoise = chkReduceVideoNoise.Value = Checked
End Sub

Private Sub btnMotionDetectionTriggerNow_Click()
    MainForm.VideoGrabberVB61.MotionDetector_TriggerNow
End Sub

Private Sub chkMotionDetectionTriggered_Click()
    MainForm.VideoGrabberVB61.MotionDetector_Triggered = (chkMotionDetectionTriggered.Value = 1)
End Sub

Private Sub edtGrid_Change()
   MainForm.VideoGrabberVB61.MotionDetector_Grid = edtGrid.Text
   If MainForm.VideoGrabberVB61.MotionDetector_IsGridValid Then
'      lblGridValid.Caption = "valid"
      shpGridValid.FillColor = RGB(0, 255, 0)
   Else
'      lblGridValid.Caption = "INVALID!"
      shpGridValid.FillColor = RGB(255, 0, 0)
   End If
   mmoSensitivityGrid.Text = MainForm.VideoGrabberVB61.MotionDetector_Get2DTextGrid
End Sub


