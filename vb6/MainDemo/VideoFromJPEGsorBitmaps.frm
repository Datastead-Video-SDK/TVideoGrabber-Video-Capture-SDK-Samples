VERSION 5.00
Begin VB.Form VideoFromJPEGsorBitmaps 
   BorderStyle     =   0  'None
   ClientHeight    =   3390
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   13980
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   226
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   932
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame framTabs 
      BorderStyle     =   0  'None
      Height          =   2700
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   13575
      Begin VB.TextBox txtVideoFromJPEGsorBitmaps 
         BackColor       =   &H00C0C0C0&
         Height          =   2535
         Left            =   8880
         MultiLine       =   -1  'True
         TabIndex        =   2
         Text            =   "VideoFromJPEGsorBitmaps.frx":0000
         Top             =   120
         Width           =   4695
      End
      Begin VB.Frame grbVideoFromJPEGsorBitmaps 
         Caption         =   "Video from JPEGs or Bitmaps"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   2655
         Left            =   0
         TabIndex        =   1
         Top             =   0
         Width           =   8775
         Begin VB.CommandButton btnStopPreview 
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
            Height          =   425
            Left            =   6720
            TabIndex        =   15
            Top             =   960
            Width           =   1335
         End
         Begin VB.CommandButton btnStartPreview 
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
            Height          =   425
            Left            =   5280
            TabIndex        =   14
            Top             =   960
            Width           =   1335
         End
         Begin VB.CheckBox chkLoopIndefinitely 
            Caption         =   "loop indefinitely"
            Height          =   255
            Left            =   3240
            TabIndex        =   13
            Top             =   1800
            Width           =   1815
         End
         Begin VB.CommandButton btnBrowseFolders 
            Caption         =   "..."
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   325
            Left            =   8160
            TabIndex        =   12
            Top             =   2100
            Width           =   375
         End
         Begin VB.TextBox edtSourceFolder 
            Height          =   325
            Left            =   3240
            TabIndex        =   11
            Top             =   2100
            Width           =   4935
         End
         Begin VB.PictureBox PictureBox 
            Appearance      =   0  'Flat
            AutoSize        =   -1  'True
            BackColor       =   &H80000005&
            BorderStyle     =   0  'None
            ForeColor       =   &H80000008&
            Height          =   750
            Index           =   3
            Left            =   2880
            Picture         =   "VideoFromJPEGsorBitmaps.frx":010A
            ScaleHeight     =   750
            ScaleWidth      =   750
            TabIndex        =   9
            Top             =   850
            Width           =   750
         End
         Begin VB.PictureBox PictureBox 
            Appearance      =   0  'Flat
            AutoSize        =   -1  'True
            BackColor       =   &H80000005&
            BorderStyle     =   0  'None
            ForeColor       =   &H80000008&
            Height          =   750
            Index           =   2
            Left            =   2040
            Picture         =   "VideoFromJPEGsorBitmaps.frx":1EFC
            ScaleHeight     =   750
            ScaleWidth      =   750
            TabIndex        =   8
            Top             =   850
            Width           =   750
         End
         Begin VB.PictureBox PictureBox 
            Appearance      =   0  'Flat
            AutoSize        =   -1  'True
            BackColor       =   &H80000005&
            BorderStyle     =   0  'None
            ForeColor       =   &H80000008&
            Height          =   750
            Index           =   1
            Left            =   1200
            Picture         =   "VideoFromJPEGsorBitmaps.frx":3CEE
            ScaleHeight     =   750
            ScaleWidth      =   750
            TabIndex        =   7
            Top             =   850
            Width           =   750
         End
         Begin VB.PictureBox PictureBox 
            Appearance      =   0  'Flat
            AutoSize        =   -1  'True
            BackColor       =   &H80000005&
            BorderStyle     =   0  'None
            ForeColor       =   &H80000008&
            Height          =   750
            Index           =   0
            Left            =   360
            Picture         =   "VideoFromJPEGsorBitmaps.frx":5AE0
            ScaleHeight     =   750
            ScaleWidth      =   750
            TabIndex        =   6
            Top             =   850
            Width           =   750
         End
         Begin VB.OptionButton rbFromBMPorJPEGfiles 
            Caption         =   "from BMP or JPEG files:"
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
            Left            =   240
            TabIndex        =   5
            Top             =   1880
            Width           =   3615
         End
         Begin VB.OptionButton rbFromPictureBox 
            Caption         =   "from PictureBox images, e.g.:"
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
            Left            =   240
            TabIndex        =   4
            Top             =   550
            Width           =   3375
         End
         Begin VB.Label Label2 
            AutoSize        =   -1  'True
            Caption         =   "Start / Stop Preview"
            Height          =   195
            Left            =   5280
            TabIndex        =   16
            Top             =   720
            Width           =   1440
         End
         Begin VB.Label Label1 
            Alignment       =   1  'Right Justify
            AutoSize        =   -1  'True
            Caption         =   "source folder of the BMP or JPEG files:"
            Height          =   195
            Left            =   420
            TabIndex        =   10
            Top             =   2160
            Width           =   2745
         End
         Begin VB.Label lblFirstSelectJPEGsOrBitmaps 
            AutoSize        =   -1  'True
            Caption         =   "first select VideoSource = vs_JPEGsOrBitmaps in the Video Sources list of the  ""video source"" tab"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H000000FF&
            Height          =   195
            Left            =   120
            TabIndex        =   3
            Top             =   240
            Width           =   8385
         End
      End
   End
End
Attribute VB_Name = "VideoFromJPEGsorBitmaps"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit





Private Sub Form_Activate()
    RefreshVideoFromJPEGsOrBitmapsControls
End Sub

Public Sub RefreshVideoFromJPEGsOrBitmapsControls()
   lblFirstSelectJPEGsOrBitmaps.Visible = (MainForm.VideoGrabberVB61.VideoSource <> vs_JPEGsOrBitmaps)
   chkLoopIndefinitely.Value = IIf(MainForm.VideoFromBitmapSourceLoop, 1, 0)
End Sub

Private Sub chkLoopIndefinitely_Click()
    MainForm.VideoFromBitmapSourceLoop = (chkLoopIndefinitely.Value = 1)
End Sub

Private Sub btnStartPreview_Click()
    Dim i As Long
    Dim BMPorJPEGFile As String
    Dim VideoFromBitmapSearch As TFileSearch
    
    With MainForm
        If .VideoGrabberVB61.VideoSource <> vs_JPEGsOrBitmaps Then
            MsgBox "Video Source must be set to ""Video From JPEGs Or Bitmaps""", _
                    vbOKOnly, "DataStead TVideoGrabber VB 6 OCX Demo"
            MainForm.VideoGrabberVB61.VideoSource = vs_JPEGsOrBitmaps
            AddLog MainForm.mmoLog, "VideoSource set to ""vs_JPEGsOrBitmaps"""
            RefreshVideoFromJPEGsOrBitmapsControls
        End If
        
        .VideoFromBitmapUsePictureBox = rbFromPictureBox.Value
        
        If .VideoFromBitmapUsePictureBox Then
            ReDim VideoFromBitmapUsePictureBoxHandle(PictureBox.ubound)
            For i = 0 To PictureBox.ubound
                VideoFromBitmapUsePictureBoxHandle(i) = PictureBox(i).Picture.Handle
            Next i
            .VideoFromBitmapUsePictureBoxCt = 0
            .VideoGrabberVB61.StartPreview
        Else
            
            .VideoFromBitmapSourceFolder = edtSourceFolder.Text
                
            BMPorJPEGFile = FileSearch_FirstFile(.VideoFromBitmapSourceFolder, "*.bmp", VideoFromBitmapSearch)
            If BMPorJPEGFile = "" Then ' if no BMP files, let's try JPEG files
                BMPorJPEGFile = FileSearch_FirstFile(.VideoFromBitmapSourceFolder, "*.jpg", VideoFromBitmapSearch)
            End If
            If BMPorJPEGFile = "" Then
                MsgBox "no bitmap files found in the specified directory!" & vbCrLf & vbCrLf & _
                        "Capture a set of frames to BMP or JPEG files first, e.g. by using the frame grabber in burst mode.", _
                        vbOKOnly, "DataStead TVideoGrabber VB 6 OCX Demo"
            Else
                FileSearch_Close VideoFromBitmapSearch
                .VideoGrabberVB61.StartPreview
            End If
        End If
    End With
End Sub

Private Sub btnStopPreview_Click()
    MainForm.VideoGrabberVB61.Stop
End Sub

Private Sub btnBrowseFolders_Click()
    Dim i As Long
    Dim pth As String
    MainForm.dlgOpen.CancelError = True
    MainForm.dlgOpen.FileName = "(folder)"
    On Error GoTo Cancelled
    MainForm.dlgOpen.ShowOpen
    pth = MainForm.dlgOpen.FileName
    For i = Len(pth) To 1 Step -1
        If Mid(pth, i, 1) = "\" Or Mid(pth, i, 1) = ":" Then
            Exit For
        End If
    Next i
    If i = 0 Then Exit Sub
    edtSourceFolder.Text = Left(pth, i)
Cancelled:
End Sub

Private Sub rbFromPictureBox_Click()
    chkLoopIndefinitely.Enabled = False
End Sub

Private Sub rbFromBMPorJPEGfiles_Click()
    chkLoopIndefinitely.Enabled = True
End Sub


