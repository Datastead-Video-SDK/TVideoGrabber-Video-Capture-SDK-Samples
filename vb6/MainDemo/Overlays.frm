VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "comdlg32.ocx"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Begin VB.Form Overlays 
   BorderStyle     =   0  'None
   Caption         =   "Overlays"
   ClientHeight    =   4695
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   13875
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   313
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
      Begin VB.CheckBox chkModifyPixels 
         Caption         =   "modify pixels (e.g. change color)"
         Height          =   195
         Left            =   8520
         TabIndex        =   112
         Top             =   0
         Width           =   2655
      End
      Begin VB.Frame grbTextOverlay 
         Caption         =   "text overlay (up to 1000 different simultaneous text overlays)"
         Height          =   2660
         Left            =   0
         TabIndex        =   71
         Top             =   0
         Width           =   5415
         Begin VB.CommandButton cmdShadowColor 
            Caption         =   "color"
            Height          =   255
            Left            =   3580
            TabIndex        =   111
            Top             =   1230
            Width           =   560
         End
         Begin VB.Frame rdgTextOverlayShadow 
            Caption         =   "shadow direction"
            Height          =   1060
            Left            =   3840
            TabIndex        =   98
            Top             =   1500
            Width           =   1480
            Begin VB.OptionButton rdgTextOverlayShadow8 
               Caption         =   "n-w"
               Height          =   195
               Left            =   840
               TabIndex        =   106
               Tag             =   "7"
               Top             =   820
               Width           =   615
            End
            Begin VB.OptionButton rdgTextOverlayShadow4 
               Caption         =   "s-e"
               Height          =   195
               Left            =   120
               TabIndex        =   105
               Tag             =   "3"
               Top             =   820
               Width           =   615
            End
            Begin VB.OptionButton rdgTextOverlayShadow7 
               Caption         =   "w"
               Height          =   195
               Left            =   840
               TabIndex        =   104
               Tag             =   "6"
               Top             =   620
               Width           =   615
            End
            Begin VB.OptionButton rdgTextOverlayShadow3 
               Caption         =   "e"
               Height          =   195
               Left            =   120
               TabIndex        =   103
               Tag             =   "2"
               Top             =   620
               Width           =   615
            End
            Begin VB.OptionButton rdgTextOverlayShadow6 
               Caption         =   "s-w"
               Height          =   195
               Left            =   840
               TabIndex        =   102
               Tag             =   "5"
               Top             =   420
               Width           =   615
            End
            Begin VB.OptionButton rdgTextOverlayShadow2 
               Caption         =   "n-e"
               Height          =   195
               Left            =   120
               TabIndex        =   101
               Tag             =   "1"
               Top             =   420
               Width           =   615
            End
            Begin VB.OptionButton rdgTextOverlayShadow5 
               Caption         =   "s"
               Height          =   195
               Left            =   840
               TabIndex        =   100
               Tag             =   "4"
               Top             =   220
               Width           =   615
            End
            Begin VB.OptionButton rdgTextOverlayShadow1 
               Caption         =   "n"
               Height          =   195
               Left            =   120
               TabIndex        =   99
               Tag             =   "0"
               Top             =   220
               Width           =   615
            End
         End
         Begin VB.CheckBox chkTextOverlayShadow 
            Caption         =   "shadow"
            Height          =   255
            Left            =   4240
            TabIndex        =   97
            Top             =   1260
            Width           =   975
         End
         Begin VB.TextBox edtTextOverlayWidth 
            Height          =   285
            Left            =   3580
            TabIndex        =   96
            Text            =   "140"
            Top             =   700
            Width           =   495
         End
         Begin VB.TextBox edtTextOverlayTop 
            Height          =   285
            Left            =   3020
            TabIndex        =   95
            Text            =   "5"
            Top             =   1200
            Width           =   495
         End
         Begin VB.Frame rdgTextOverlayAlign 
            Caption         =   "Align"
            Height          =   855
            Left            =   4200
            TabIndex        =   90
            Top             =   400
            Width           =   1120
            Begin VB.OptionButton rdgTextOverlayAlign3 
               Caption         =   "right"
               Height          =   195
               Left            =   160
               TabIndex        =   93
               Tag             =   "2"
               Top             =   620
               Width           =   615
            End
            Begin VB.OptionButton rdgTextOverlayAlign2 
               Caption         =   "center"
               Height          =   195
               Left            =   160
               TabIndex        =   92
               Tag             =   "1"
               Top             =   420
               Width           =   800
            End
            Begin VB.OptionButton rdgTextOverlayAlign1 
               Caption         =   "left"
               Height          =   195
               Left            =   160
               TabIndex        =   91
               Tag             =   "0"
               Top             =   220
               Value           =   -1  'True
               Width           =   615
            End
         End
         Begin VB.CheckBox chkTextOverlayEnabled 
            Caption         =   "enabled"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00C00000&
            Height          =   255
            Left            =   3020
            TabIndex        =   89
            Top             =   220
            Width           =   1095
         End
         Begin VB.TextBox mmoTextOverlayString 
            Height          =   1600
            Left            =   80
            MultiLine       =   -1  'True
            ScrollBars      =   2  'Vertical
            TabIndex        =   88
            Top             =   960
            Width           =   2775
         End
         Begin VB.Frame grpTextSelector 
            Caption         =   "text selector (0 - n)  0 = default"
            Height          =   735
            Left            =   80
            TabIndex        =   77
            Top             =   200
            Width           =   2775
            Begin VB.OptionButton optTextSelector 
               Caption         =   "9"
               Height          =   255
               Index           =   9
               Left            =   2240
               TabIndex        =   87
               Tag             =   "9"
               Top             =   440
               Width           =   495
            End
            Begin VB.OptionButton optTextSelector 
               Caption         =   "8"
               Height          =   255
               Index           =   8
               Left            =   2240
               TabIndex        =   86
               Tag             =   "8"
               Top             =   200
               Width           =   495
            End
            Begin VB.OptionButton optTextSelector 
               Caption         =   "7"
               Height          =   255
               Index           =   7
               Left            =   1680
               TabIndex        =   85
               Tag             =   "7"
               Top             =   440
               Width           =   495
            End
            Begin VB.OptionButton optTextSelector 
               Caption         =   "6"
               Height          =   255
               Index           =   6
               Left            =   1680
               TabIndex        =   84
               Tag             =   "6"
               Top             =   200
               Width           =   495
            End
            Begin VB.OptionButton optTextSelector 
               Caption         =   "0"
               Height          =   255
               Index           =   0
               Left            =   120
               TabIndex        =   83
               Tag             =   "0"
               Top             =   200
               Width           =   495
            End
            Begin VB.OptionButton optTextSelector 
               Caption         =   "1"
               Height          =   255
               Index           =   1
               Left            =   120
               TabIndex        =   82
               Tag             =   "1"
               Top             =   440
               Width           =   495
            End
            Begin VB.OptionButton optTextSelector 
               Caption         =   "2"
               Height          =   255
               Index           =   2
               Left            =   640
               TabIndex        =   81
               Tag             =   "2"
               Top             =   200
               Width           =   495
            End
            Begin VB.OptionButton optTextSelector 
               Caption         =   "3"
               Height          =   255
               Index           =   3
               Left            =   640
               TabIndex        =   80
               Tag             =   "3"
               Top             =   440
               Width           =   495
            End
            Begin VB.OptionButton optTextSelector 
               Caption         =   "4"
               Height          =   255
               Index           =   4
               Left            =   1160
               TabIndex        =   79
               Tag             =   "4"
               Top             =   200
               Width           =   495
            End
            Begin VB.OptionButton optTextSelector 
               Caption         =   "5"
               Height          =   255
               Index           =   5
               Left            =   1160
               TabIndex        =   78
               Tag             =   "5"
               Top             =   440
               Width           =   495
            End
         End
         Begin VB.CheckBox chkTextOverlayTransparent 
            Caption         =   "transparent"
            Height          =   210
            Left            =   4200
            TabIndex        =   76
            Top             =   220
            Width           =   1095
         End
         Begin VB.CommandButton btnBackgroundColor 
            Caption         =   "bkgnd"
            Height          =   255
            Left            =   3000
            TabIndex        =   75
            Top             =   2280
            Width           =   735
         End
         Begin VB.CommandButton btnFontColor 
            Caption         =   "color"
            Height          =   255
            Left            =   3000
            TabIndex        =   74
            Top             =   2040
            Width           =   735
         End
         Begin VB.CommandButton btnCustomFont 
            Caption         =   "custom"
            Height          =   255
            Left            =   3000
            TabIndex        =   73
            Top             =   1800
            Width           =   735
         End
         Begin VB.CommandButton btnFontDialog 
            Caption         =   "font dlg"
            Height          =   255
            Left            =   3000
            TabIndex        =   72
            Top             =   1560
            Width           =   735
         End
         Begin VB.TextBox edtTextOverlayLeft 
            Height          =   285
            Left            =   3020
            TabIndex        =   94
            Text            =   "5"
            Top             =   700
            Width           =   495
         End
         Begin VB.Label Label45 
            Caption         =   "width"
            Height          =   255
            Left            =   3580
            TabIndex        =   109
            Top             =   510
            Width           =   495
         End
         Begin VB.Label Label44 
            Caption         =   "top"
            Height          =   255
            Left            =   3020
            TabIndex        =   108
            Top             =   1000
            Width           =   375
         End
         Begin VB.Label Label43 
            Caption         =   "left"
            Height          =   255
            Left            =   3020
            TabIndex        =   107
            Top             =   510
            Width           =   375
         End
      End
      Begin VB.Frame grbBitmapOverlay 
         Caption         =   "image overlay (up to 1000 different simultaneous image overlays)"
         Height          =   2420
         Left            =   5520
         TabIndex        =   34
         Top             =   240
         Width           =   5775
         Begin VB.CheckBox chkImageOverlayAlphaBlend 
            Caption         =   "alpha blend (0-255)"
            Height          =   255
            Left            =   120
            TabIndex        =   62
            Top             =   1120
            Width           =   1815
         End
         Begin VB.CommandButton btnImageOverlayPickupColorHelp 
            Caption         =   "?"
            Height          =   255
            Left            =   2400
            TabIndex        =   59
            Top             =   2080
            Width           =   375
         End
         Begin VB.CommandButton btnImageOverlayChromaKeyRGBHelp 
            Caption         =   "?"
            Height          =   255
            Left            =   5280
            TabIndex        =   58
            Top             =   2080
            Width           =   375
         End
         Begin VB.CommandButton btnImageOverlayChromaKeyRGB 
            Caption         =   "pickup chroma key color"
            Height          =   255
            Left            =   3000
            TabIndex        =   57
            Top             =   2080
            Width           =   2295
         End
         Begin VB.TextBox edtImageOverlayChromaKeyRGBValue 
            Height          =   285
            Left            =   4920
            TabIndex        =   56
            Text            =   "000000"
            Top             =   1760
            Width           =   735
         End
         Begin VB.TextBox edtImageOverlayTransparentColorValue 
            Height          =   285
            Left            =   2040
            TabIndex        =   55
            Text            =   "000000"
            Top             =   1760
            Width           =   735
         End
         Begin VB.CheckBox chkImageOverlayChromaKey 
            Caption         =   "chroma key"
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
            Left            =   2760
            TabIndex        =   54
            Top             =   1440
            Width           =   1335
         End
         Begin VB.TextBox edtImageOverlayTop 
            Height          =   285
            Left            =   4020
            TabIndex        =   53
            Text            =   "10"
            Top             =   940
            Width           =   495
         End
         Begin VB.TextBox edtImageOverlayLeft 
            Height          =   285
            Left            =   3460
            TabIndex        =   52
            Text            =   "10"
            Top             =   940
            Width           =   495
         End
         Begin VB.CheckBox chkImageOverlayEnabled 
            Caption         =   "enabled"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   700
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            ForeColor       =   &H00C00000&
            Height          =   255
            Left            =   2280
            TabIndex        =   51
            Top             =   720
            Width           =   1095
         End
         Begin VB.CheckBox chkImageOverlayTransparent 
            Caption         =   "transparent"
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
            TabIndex        =   50
            Top             =   1440
            Width           =   1335
         End
         Begin VB.CheckBox chkImageOverlayUseTransparentColor 
            Caption         =   "transparent RGB color"
            Height          =   255
            Left            =   120
            TabIndex        =   49
            Top             =   1760
            Width           =   1935
         End
         Begin VB.TextBox edtImageOverlayWidth 
            Height          =   285
            Left            =   4580
            TabIndex        =   48
            Text            =   "10"
            Top             =   940
            Width           =   495
         End
         Begin VB.TextBox edtImageOverlayHeight 
            Height          =   285
            Left            =   5140
            TabIndex        =   47
            Text            =   "10"
            Top             =   940
            Width           =   495
         End
         Begin VB.CommandButton btnImageOverlayPickupColor 
            Caption         =   "pickup transparent color"
            Height          =   255
            Left            =   120
            TabIndex        =   46
            Top             =   2080
            Width           =   2295
         End
         Begin VB.Frame grpImageSelector 
            Caption         =   "image selector (0 - n)  0 = default"
            Height          =   495
            Left            =   120
            TabIndex        =   35
            Top             =   180
            Width           =   5535
            Begin VB.OptionButton optImageSelector 
               Caption         =   "9"
               Height          =   255
               Index           =   9
               Left            =   4930
               TabIndex        =   45
               Tag             =   "9"
               Top             =   210
               Width           =   495
            End
            Begin VB.OptionButton optImageSelector 
               Caption         =   "8"
               Height          =   255
               Index           =   8
               Left            =   4400
               TabIndex        =   44
               Tag             =   "8"
               Top             =   210
               Width           =   495
            End
            Begin VB.OptionButton optImageSelector 
               Caption         =   "7"
               Height          =   255
               Index           =   7
               Left            =   3870
               TabIndex        =   43
               Tag             =   "7"
               Top             =   210
               Width           =   495
            End
            Begin VB.OptionButton optImageSelector 
               Caption         =   "6"
               Height          =   255
               Index           =   6
               Left            =   3340
               TabIndex        =   42
               Tag             =   "6"
               Top             =   210
               Width           =   495
            End
            Begin VB.OptionButton optImageSelector 
               Caption         =   "5"
               Height          =   255
               Index           =   5
               Left            =   2810
               TabIndex        =   41
               Tag             =   "5"
               Top             =   210
               Width           =   495
            End
            Begin VB.OptionButton optImageSelector 
               Caption         =   "4"
               Height          =   255
               Index           =   4
               Left            =   2280
               TabIndex        =   40
               Tag             =   "4"
               Top             =   210
               Width           =   495
            End
            Begin VB.OptionButton optImageSelector 
               Caption         =   "3"
               Height          =   255
               Index           =   3
               Left            =   1750
               TabIndex        =   39
               Tag             =   "3"
               Top             =   210
               Width           =   495
            End
            Begin VB.OptionButton optImageSelector 
               Caption         =   "2"
               Height          =   255
               Index           =   2
               Left            =   1220
               TabIndex        =   38
               Tag             =   "2"
               Top             =   210
               Width           =   495
            End
            Begin VB.OptionButton optImageSelector 
               Caption         =   "1"
               Height          =   255
               Index           =   1
               Left            =   690
               TabIndex        =   37
               Tag             =   "1"
               Top             =   210
               Width           =   495
            End
            Begin VB.OptionButton optImageSelector 
               Caption         =   "0"
               Height          =   255
               Index           =   0
               Left            =   160
               TabIndex        =   36
               Tag             =   "0"
               Top             =   210
               Width           =   495
            End
         End
         Begin MSComctlLib.Slider sldImageOverlayChromaKey 
            Height          =   255
            Left            =   4800
            TabIndex        =   60
            Top             =   1440
            Width           =   855
            _ExtentX        =   1508
            _ExtentY        =   450
            _Version        =   393216
            Min             =   -50
            Max             =   100
            TickFrequency   =   15
         End
         Begin MSComctlLib.Slider sldImageOverlayAlphaBlend 
            Height          =   255
            Left            =   1920
            TabIndex        =   61
            Top             =   1120
            Width           =   1215
            _ExtentX        =   2143
            _ExtentY        =   450
            _Version        =   393216
            Enabled         =   0   'False
            Max             =   255
            TickFrequency   =   26
         End
         Begin VB.Label Label7 
            Alignment       =   1  'Right Justify
            Caption         =   "chroma key RGB color"
            Height          =   255
            Left            =   3000
            TabIndex        =   70
            Top             =   1760
            Width           =   1815
         End
         Begin VB.Label Label6 
            Alignment       =   1  'Right Justify
            Caption         =   "leeway %"
            Height          =   255
            Left            =   4080
            TabIndex        =   69
            Top             =   1440
            Width           =   735
         End
         Begin VB.Label Label5 
            AutoSize        =   -1  'True
            Caption         =   "-1 width or height = image size"
            BeginProperty Font 
               Name            =   "MS Sans Serif"
               Size            =   8.25
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   -1  'True
               Strikethrough   =   0   'False
            EndProperty
            Height          =   195
            Left            =   3480
            TabIndex        =   68
            Top             =   1200
            Width           =   2220
         End
         Begin VB.CommandButton btnLoadImageOverlay 
            Height          =   360
            Left            =   120
            TabIndex        =   67
            Top             =   705
            Width           =   2055
            Caption         =   " select an image file..."
            PicturePosition =   327683
            Size            =   "3625;635"
            Picture         =   "Overlays.frx":0000
            FontHeight      =   165
            FontCharSet     =   0
            FontPitchAndFamily=   2
            ParagraphAlign  =   3
         End
         Begin VB.Label Label49 
            AutoSize        =   -1  'True
            Caption         =   "top"
            Height          =   195
            Left            =   4020
            TabIndex        =   66
            Top             =   720
            Width           =   225
         End
         Begin VB.Label Label48 
            AutoSize        =   -1  'True
            Caption         =   "left"
            Height          =   195
            Index           =   0
            Left            =   3460
            TabIndex        =   65
            Top             =   720
            Width           =   210
         End
         Begin VB.Label Label1 
            AutoSize        =   -1  'True
            Caption         =   "width"
            Height          =   195
            Index           =   0
            Left            =   4580
            TabIndex        =   64
            Top             =   720
            Width           =   375
         End
         Begin VB.Label edtImageOvlerlayHeight 
            AutoSize        =   -1  'True
            Caption         =   "height"
            Height          =   285
            Index           =   1
            Left            =   5140
            TabIndex        =   63
            Top             =   720
            Width           =   435
         End
      End
      Begin VB.Frame grpOverlayUsingDC 
         Caption         =   "Device Context overlay"
         Height          =   2655
         Left            =   11400
         TabIndex        =   11
         ToolTipText     =   "Line width"
         Top             =   0
         Width           =   2175
         Begin VB.CommandButton btnFreeHandErase 
            Caption         =   "X"
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
            Left            =   1800
            TabIndex        =   15
            ToolTipText     =   "Erase free hand drawing"
            Top             =   600
            Width           =   255
         End
         Begin VB.CheckBox chkFreeHandEnabled 
            Caption         =   """free hand"" mouse"
            Height          =   255
            Left            =   120
            TabIndex        =   14
            ToolTipText     =   "Activate ""free hand"" overlay drawing"
            Top             =   620
            Width           =   1935
         End
         Begin VB.TextBox edtDrawGridOverlayVideoWidthDivisor 
            Height          =   285
            Left            =   1560
            TabIndex        =   13
            Text            =   "0"
            ToolTipText     =   "Grid size is video width divided by this number"
            Top             =   1240
            Width           =   495
         End
         Begin VB.TextBox edtDrawCenteredCircleDiameter 
            Height          =   285
            Left            =   1560
            TabIndex        =   12
            Text            =   "0"
            ToolTipText     =   "circle diameter"
            Top             =   1930
            Width           =   495
         End
         Begin MSComctlLib.Slider sldFreeHandMouseDrawingStyle 
            Height          =   225
            Left            =   460
            TabIndex        =   16
            ToolTipText     =   "Line style"
            Top             =   880
            Width           =   520
            _ExtentX        =   926
            _ExtentY        =   397
            _Version        =   393216
            LargeChange     =   1
            Max             =   4
         End
         Begin MSComctlLib.Slider sldFreeHandMouseDrawingLineWidth 
            Height          =   225
            Left            =   1280
            TabIndex        =   17
            ToolTipText     =   "Line width"
            Top             =   880
            Width           =   520
            _ExtentX        =   926
            _ExtentY        =   397
            _Version        =   393216
            LargeChange     =   1
            Min             =   1
            Max             =   5
            SelStart        =   1
            Value           =   1
         End
         Begin MSComctlLib.Slider sldDrawGridOverlayStyle 
            Height          =   225
            Left            =   460
            TabIndex        =   18
            ToolTipText     =   "Line style"
            Top             =   1560
            Width           =   525
            _ExtentX        =   926
            _ExtentY        =   397
            _Version        =   393216
            LargeChange     =   1
            Max             =   4
         End
         Begin MSComctlLib.Slider sldDrawGridOverlayLineWidth 
            Height          =   225
            Left            =   1280
            TabIndex        =   19
            Top             =   1560
            Width           =   525
            _ExtentX        =   926
            _ExtentY        =   397
            _Version        =   393216
            LargeChange     =   1
            Min             =   1
            Max             =   5
            SelStart        =   1
            Value           =   1
         End
         Begin MSComctlLib.Slider sldDrawCenteredCircleStyle 
            Height          =   225
            Left            =   460
            TabIndex        =   20
            ToolTipText     =   "Line style"
            Top             =   2250
            Width           =   525
            _ExtentX        =   926
            _ExtentY        =   397
            _Version        =   393216
            LargeChange     =   1
            Max             =   4
         End
         Begin MSComctlLib.Slider sldDrawCenteredCircleLineWidth 
            Height          =   225
            Left            =   1280
            TabIndex        =   21
            ToolTipText     =   "Line width"
            Top             =   2250
            Width           =   525
            _ExtentX        =   926
            _ExtentY        =   397
            _Version        =   393216
            LargeChange     =   1
            Min             =   1
            Max             =   5
            SelStart        =   1
            Value           =   1
         End
         Begin VB.Label Label15 
            Alignment       =   1  'Right Justify
            Caption         =   "style"
            Height          =   255
            Left            =   80
            TabIndex        =   33
            Top             =   2250
            Width           =   375
         End
         Begin VB.Label Label14 
            Alignment       =   1  'Right Justify
            Caption         =   "line"
            Height          =   255
            Left            =   980
            TabIndex        =   32
            Top             =   2250
            Width           =   300
         End
         Begin VB.Label Label13 
            Alignment       =   1  'Right Justify
            Caption         =   "style"
            Height          =   255
            Left            =   80
            TabIndex        =   31
            Top             =   1560
            Width           =   375
         End
         Begin VB.Label Label12 
            Alignment       =   1  'Right Justify
            Caption         =   "line"
            Height          =   255
            Left            =   980
            TabIndex        =   30
            Top             =   1560
            Width           =   300
         End
         Begin VB.Label Label11 
            Alignment       =   1  'Right Justify
            Caption         =   "style"
            Height          =   255
            Left            =   80
            TabIndex        =   29
            Top             =   880
            Width           =   375
         End
         Begin VB.CommandButton btnDrawCenteredCircleColor 
            Height          =   255
            Left            =   1800
            TabIndex        =   28
            ToolTipText     =   "Set circle color"
            Top             =   2250
            Width           =   255
            BackColor       =   65280
            Size            =   "450;450"
            FontHeight      =   165
            FontCharSet     =   0
            FontPitchAndFamily=   2
            ParagraphAlign  =   3
         End
         Begin VB.CommandButton btnFreeHandMouseDrawingColor 
            Height          =   255
            Left            =   1800
            TabIndex        =   27
            ToolTipText     =   "Set free hand color"
            Top             =   890
            Width           =   255
            BackColor       =   255
            Size            =   "450;450"
            FontHeight      =   165
            FontCharSet     =   0
            FontPitchAndFamily=   2
            ParagraphAlign  =   3
         End
         Begin VB.CommandButton btnDrawGridOverlayColor 
            Height          =   255
            Left            =   1800
            TabIndex        =   26
            ToolTipText     =   "Set grid color"
            Top             =   1560
            Width           =   255
            BackColor       =   16711680
            Size            =   "450;450"
            FontHeight      =   165
            FontCharSet     =   0
            FontPitchAndFamily=   2
            ParagraphAlign  =   3
         End
         Begin VB.Shape shpFreeHandMouseDrawingColor 
            FillColor       =   &H0000FF00&
            FillStyle       =   0  'Solid
            Height          =   255
            Left            =   1800
            Shape           =   4  'Rounded Rectangle
            Top             =   890
            Width           =   255
         End
         Begin VB.Label Label9 
            Caption         =   "see event OnFrameOverlayUsingDC"
            ForeColor       =   &H00404040&
            Height          =   495
            Left            =   120
            TabIndex        =   25
            Top             =   200
            Width           =   1935
            WordWrap        =   -1  'True
         End
         Begin VB.Label Label8 
            Alignment       =   1  'Right Justify
            Caption         =   "grid: video width /"
            Height          =   255
            Left            =   135
            TabIndex        =   24
            Top             =   1290
            Width           =   1335
         End
         Begin VB.Label Label2 
            Alignment       =   1  'Right Justify
            Caption         =   "circle: diameter > 0 "
            Height          =   285
            Left            =   120
            TabIndex        =   23
            Top             =   1980
            Width           =   1335
            WordWrap        =   -1  'True
         End
         Begin VB.Label Label10 
            Alignment       =   1  'Right Justify
            Caption         =   "line"
            Height          =   255
            Left            =   980
            TabIndex        =   22
            Top             =   880
            Width           =   300
         End
      End
      Begin MSComDlg.CommonDialog dlgOverlay 
         Left            =   13080
         Top             =   1080
         _ExtentX        =   847
         _ExtentY        =   847
         _Version        =   393216
      End
      Begin VB.Label lblFrameOverlayRequiresFrameGrabber 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         Caption         =   "The frame grabber must be enabled"
         ForeColor       =   &H000000FF&
         Height          =   195
         Left            =   5565
         TabIndex        =   110
         Top             =   0
         Width           =   2520
      End
   End
   Begin VB.Frame grpShapeOverlay 
      Caption         =   "Shape overlay"
      Enabled         =   0   'False
      Height          =   1415
      Left            =   120
      TabIndex        =   1
      Top             =   3000
      Visible         =   0   'False
      Width           =   2175
      Begin VB.CheckBox chkShapeOverlay 
         Caption         =   "enabled"
         Enabled         =   0   'False
         Height          =   255
         Left            =   120
         TabIndex        =   6
         Top             =   380
         Width           =   900
      End
      Begin VB.TextBox Text1 
         Enabled         =   0   'False
         Height          =   285
         Left            =   580
         TabIndex        =   5
         Text            =   "10"
         Top             =   1020
         Width           =   440
      End
      Begin VB.TextBox Text2 
         Enabled         =   0   'False
         Height          =   285
         Left            =   80
         TabIndex        =   4
         Text            =   "10"
         Top             =   1020
         Width           =   440
      End
      Begin VB.TextBox Text3 
         Enabled         =   0   'False
         Height          =   285
         Left            =   1090
         TabIndex        =   3
         Text            =   "60"
         Top             =   1020
         Width           =   440
      End
      Begin VB.TextBox Text4 
         Enabled         =   0   'False
         Height          =   285
         Left            =   1600
         TabIndex        =   2
         Text            =   "40"
         Top             =   1020
         Width           =   440
      End
      Begin VB.Label Label4 
         AutoSize        =   -1  'True
         Caption         =   "top"
         Height          =   195
         Left            =   580
         TabIndex        =   10
         Top             =   800
         Width           =   225
      End
      Begin VB.Label Label48 
         AutoSize        =   -1  'True
         Caption         =   "left"
         Height          =   195
         Index           =   1
         Left            =   80
         TabIndex        =   9
         Top             =   800
         Width           =   210
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         Caption         =   "width"
         Height          =   195
         Index           =   1
         Left            =   1090
         TabIndex        =   8
         Top             =   800
         Width           =   375
      End
      Begin VB.Label edtImageOvlerlayHeight 
         AutoSize        =   -1  'True
         Caption         =   "height"
         Height          =   285
         Index           =   0
         Left            =   1600
         TabIndex        =   7
         Top             =   800
         Width           =   435
      End
      Begin VB.Shape shpShapeOverlay 
         FillColor       =   &H000000FF&
         FillStyle       =   5  'Downward Diagonal
         Height          =   495
         Left            =   1080
         Shape           =   4  'Rounded Rectangle
         Top             =   260
         Width           =   975
      End
   End
End
Attribute VB_Name = "Overlays"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit





Private Sub btnDrawCenteredCircleColor_Click()
    Dim FontColor As Long

    If GetColorFromDialog(dlgOverlay, FontColor) Then
        MainForm.DrawCenteredCircleColor = FontColor   ' used from the OnFrameOverlayUsingDC event to draw a circle over video frames
        btnDrawCenteredCircleColor.BackColor = FontColor
    End If
End Sub

Private Sub btnDrawGridOverlayColor_Click()
    Dim FontColor As Long

    If GetColorFromDialog(dlgOverlay, FontColor) Then
        MainForm.DrawGridOverlayColor = FontColor
        btnDrawGridOverlayColor.BackColor = FontColor
    End If
End Sub

Private Sub btnImageOverlayChromaKeyRGB_Click()
   If MainForm.PickupTransparentColor_LastRGBPixelValueAtMousePosition <> -1 Then
      MainForm.VideoGrabberVB61.ImageOverlay_ChromaKeyRGBColor = MainForm.PickupTransparentColor_LastRGBPixelValueAtMousePosition
      edtImageOverlayChromaKeyRGBValue.Text = MainForm.PickupTransparentColor_LastRGBPixelValueAtMousePosition
   End If
End Sub

Private Sub btnImageOverlayChromaKeyRGBHelp_Click()
        MsgBox "while the preview is running:" & vbCrLf & "- load the image overlay" & vbCrLf & "- enable ""chroma key""" & vbCrLf & "- in the video window, click on the video frame on the color of the overlayed image you want to be chroma key\n- click on 'pickup chroma key color'", _
            vbOKOnly, _
            "DataStead TVideoGrabber VB 6 OCX Demo"
End Sub

Private Sub chkFreeHandEnabled_Click()
    ' tested in MainForm -> OnMouseDown, OnMouseUp and OnMouseMove vents
End Sub

Private Sub chkImageOverlayChromaKey_Click()
    MainForm.VideoGrabberVB61.ImageOverlay_ChromaKey = chkImageOverlayChromaKey.Value = Checked
End Sub

Private Sub chkModifyPixels_Click()
   MainForm.Overlays_chkModifyPixelsEnabled = (chkModifyPixels.Value = Checked)
End Sub

Private Sub chkShapeOverlay_Click()
    '  MainForm.VideoGrabberVB61.ShapeOverlayEnabled = (chkShapeOverlay.Value = 1)
End Sub

Private Sub Command1_Click()

End Sub

Private Sub edtImageOverlayChromaKeyRGBValue_Change()
    If IsNumeric(edtImageOverlayChromaKeyRGBValue.Text) Then
        MainForm.VideoGrabberVB61.ImageOverlay_ChromaKeyRGBColor = edtImageOverlayChromaKeyRGBValue.Text
    End If
End Sub

Private Sub grpShapeOverlay_Click()
    MsgBox "ShapeOverlay is not available in .OCX versions", _
            vbOKOnly, _
            "DataStead TVideoGrabber VB 6 OCX Demo"
End Sub

Private Sub sldImageOverlayChromaKey_scroll()
    MainForm.VideoGrabberVB61.ImageOverlay_ChromaKeyLeewayPercent = sldImageOverlayChromaKey.Value
End Sub

Private Sub Form_Load()
    ReloadTextSettings
End Sub

Private Sub Form_Unload(Cancel As Integer)
   If Not MainForm.CanUnload Then
      Hide
      Cancel = True
   End If
End Sub


Private Sub btnCustomFont_Click()
    Dim FontSpec As FONTSPECS
    MainForm.VideoGrabberVB61.TextOverlay_Font = CreateFontFromSpecs("Courier New", 12, False, False, False, 0, FontSpec)
    MainForm.VideoGrabberVB61.TextOverlay_FontColor = &HFFFFFF
    With mmoTextOverlayString
        .FontName = FontSpec.FontName
        .FontSize = FontSpec.FontSize
        .FontItalic = FontSpec.FontItalic
        .FontBold = FontSpec.FontBold
        .FontUnderline = FontSpec.FontUnderline
        .FontStrikeThru = FontSpec.FontStrikeThru
        .ForeColor = &HFFFFFF
        .BackColor = &HA0A0A0
    End With
End Sub

Private Sub btnFontDialog_Click()
    Dim FontHandle As Long
    Dim FontColor As Long
    Dim FontSpec As FONTSPECS
    
    If CreateFontFromDialog(dlgOverlay, FontHandle, FontColor, FontSpec) Then
        MainForm.VideoGrabberVB61.TextOverlay_Font = FontHandle
        MainForm.VideoGrabberVB61.TextOverlay_FontColor = FontColor
        With mmoTextOverlayString
            .FontName = FontSpec.FontName
            .FontSize = FontSpec.FontSize
            .FontItalic = FontSpec.FontItalic
            .FontBold = FontSpec.FontBold
            .FontUnderline = FontSpec.FontUnderline
            .FontStrikeThru = FontSpec.FontStrikeThru
            .ForeColor = FontColor
        End With
    End If
End Sub

Private Sub btnFontColor_Click()
    Dim FontColor As Long

    If GetColorFromDialog(dlgOverlay, FontColor) Then
        MainForm.VideoGrabberVB61.TextOverlay_FontColor = FontColor
        mmoTextOverlayString.ForeColor = FontColor
    End If
End Sub

Private Sub btnBackgroundColor_Click()
    Dim BkColor As Long

    If GetColorFromDialog(dlgOverlay, BkColor) Then
        MainForm.VideoGrabberVB61.TextOverlay_BkColor = BkColor
        mmoTextOverlayString.BackColor = BkColor
    End If
End Sub


Private Sub btnImageOverlayPickupColor_Click()
   If MainForm.PickupTransparentColor_LastRGBPixelValueAtMousePosition <> -1 Then
      MainForm.VideoGrabberVB61.ImageOverlay_TransparentColorValue = MainForm.PickupTransparentColor_LastRGBPixelValueAtMousePosition
      edtImageOverlayTransparentColorValue.Text = MainForm.PickupTransparentColor_LastRGBPixelValueAtMousePosition
   End If
End Sub

Private Sub btnImageOverlayPickupColorHelp_Click()
        MsgBox "while the preview is running:" & vbCrLf & "- load the image overlay" & vbCrLf & "- enable ""transparent"" and ""transparent RGB color""" & vbCrLf & "- in the video window, click on the video frame on the color of the overlayed image you want to be transparent\n- click on 'pickup transparent color'", _
            vbOKOnly, _
            "DataStead TVideoGrabber VB 6 OCX Demo"
End Sub

Private Sub btnLoadImageOverlay_Click()
    MainForm.dlgOpen.CancelError = True
    MainForm.dlgOpen.DefaultExt = OPEN_PICTURE_FILES
    On Error GoTo Cancelled
    MainForm.dlgOpen.ShowOpen
    MainForm.VideoGrabberVB61.SetImageOverlayFromImageFile (MainForm.dlgOpen.FileName)
Cancelled:
End Sub

Private Sub chkImageOverlayEnabled_Click()
        MainForm.VideoGrabberVB61.ImageOverlayEnabled = chkImageOverlayEnabled.Value = Checked
End Sub

Private Sub chkImageOverlayUseTransparentColor_Click()
        MainForm.VideoGrabberVB61.ImageOverlay_UseTransparentColor = chkImageOverlayUseTransparentColor.Value = Checked
End Sub

Private Sub chkImageOverlayAlphaBlend_Click()
     MainForm.VideoGrabberVB61.ImageOverlay_AlphaBlend = (chkImageOverlayAlphaBlend.Value = Checked)
     sldImageOverlayAlphaBlend.Enabled = (chkImageOverlayAlphaBlend.Value = Checked)
End Sub

Private Sub sldImageOverlayAlphaBlend_Scroll()
    MainForm.VideoGrabberVB61.ImageOverlay_AlphaBlendValue = sldImageOverlayAlphaBlend.Value
End Sub
Private Sub chkImageOverlayTransparent_Click()
    MainForm.VideoGrabberVB61.ImageOverlay_Transparent = chkImageOverlayTransparent.Value = Checked
End Sub

Private Sub chkTextOverlayEnabled_Click()
   MainForm.VideoGrabberVB61.TextOverlay_String = mmoTextOverlayString.Text
   MainForm.VideoGrabberVB61.TextOverlay_Enabled = chkTextOverlayEnabled.Value = Checked
End Sub

Private Sub chkTextOverlayTransparent_Click()
   MainForm.VideoGrabberVB61.TextOverlay_Transparent = chkTextOverlayTransparent.Value = Checked
End Sub

Private Sub chkTextOverlayShadow_Click()
    MainForm.VideoGrabberVB61.TextOverlay_Shadow = (chkTextOverlayShadow.Value = 1)
End Sub

Private Sub cmdShadowColor_Click()
    Dim FontColor As Long

    If GetColorFromDialog(dlgOverlay, FontColor) Then
        MainForm.VideoGrabberVB61.TextOverlay_ShadowColor = FontColor
    End If
End Sub

Private Sub btnFreeHandMouseDrawingColor_Click()
    Dim FontColor As Long

    If GetColorFromDialog(dlgOverlay, FontColor) Then
        MainForm.FreeHandMouseDrawingColor = FontColor   ' used from the OnFrameOverlayUsingDC event to draw free hand over video frames
        btnFreeHandMouseDrawingColor.BackColor = FontColor
    End If
End Sub

Private Sub btnFreeHandErase_Click()
   MainForm.iFreeHandMouseDrawing = 0
   MainForm.VideoGrabberVB61.RefreshPlayerOverlays
End Sub

Private Sub sldFreeHandMouseDrawingLineWidth_Scroll()
    MainForm.FreeHandMouseDrawingLineWidth = sldFreeHandMouseDrawingLineWidth.Value
End Sub

Private Sub sldFreeHandMouseDrawingStyle_Scroll()
    MainForm.FreeHandMouseDrawingStyle = sldFreeHandMouseDrawingStyle.Value
End Sub

Private Sub edtDrawGridOverlayVideoWidthDivisor_Change()
    If IsNumeric(Me.edtDrawGridOverlayVideoWidthDivisor.Text) Then
        MainForm.DrawGridOverlayVideoWidthDivisor = Val(Me.edtDrawGridOverlayVideoWidthDivisor.Text)   ' used from the OnFrameOverlayUsingDC event to draw a grid over video frames
    End If
End Sub

Private Sub sldDrawGridOverlayLineWidth_Scroll()
    MainForm.DrawGridOverlayLineWidth = sldDrawGridOverlayLineWidth.Value
End Sub

Private Sub sldDrawGridOverlayStyle_Scroll()
    MainForm.DrawGridOverlayStyle = sldDrawGridOverlayStyle.Value
End Sub

Private Sub edtDrawCenteredCircleDiameter_Change()
    If IsNumeric(edtDrawCenteredCircleDiameter.Text) Then
        MainForm.DrawCenteredCircleDiameter = edtDrawCenteredCircleDiameter.Text ' used from the OnFrameOverlayUsingDC event to draw a circle over video frames
    End If
End Sub

Private Sub sldDrawCenteredCircleLineWidth_Click()
    MainForm.DrawCenteredCircleLineWidth = sldDrawCenteredCircleLineWidth.Value
End Sub

Private Sub sldDrawCenteredCircleStyle_Click()
    MainForm.DrawCenteredCircleStyle = sldDrawCenteredCircleStyle.Value
End Sub

Private Sub edtImageOverlayHeight_Change()
        If IsNumeric(edtImageOverlayHeight.Text) Then
            MainForm.VideoGrabberVB61.ImageOverlay_Height = edtImageOverlayHeight.Text
        End If
End Sub

Private Sub edtImageOverlayTransparentColorValue_Change()
        If IsNumeric(edtImageOverlayTransparentColorValue.Text) Then
            MainForm.VideoGrabberVB61.ImageOverlay_TransparentColorValue = edtImageOverlayTransparentColorValue.Text
        End If
End Sub

Private Sub edtImageOverlayLeft_Change()
        If IsNumeric(edtImageOverlayLeft.Text) Then
            MainForm.VideoGrabberVB61.ImageOverlay_LeftLocation = edtImageOverlayLeft.Text
        End If
End Sub

Private Sub edtImageOverlayTop_Change()
        If IsNumeric(edtImageOverlayTop.Text) Then
            MainForm.VideoGrabberVB61.ImageOverlay_TopLocation = edtImageOverlayTop.Text
        End If
End Sub

Private Sub edtImageOverlayWidth_Change()
        If IsNumeric(edtImageOverlayWidth.Text) Then
            MainForm.VideoGrabberVB61.ImageOverlay_Width = edtImageOverlayWidth.Text
        End If
End Sub

Private Sub edtTextOverlayLeft_Change()
    If IsNumeric(edtTextOverlayLeft.Text) Then
        MainForm.VideoGrabberVB61.TextOverlay_Left = edtTextOverlayLeft.Text
    End If
End Sub

Private Sub edtTextOverlayTop_Change()
    If IsNumeric(edtTextOverlayLeft.Text) Then
        MainForm.VideoGrabberVB61.TextOverlay_Top = edtTextOverlayTop.Text
    End If
End Sub

Private Sub edtTextOverlayWidth_Change()
    If IsNumeric(edtTextOverlayWidth.Text) Then
        MainForm.VideoGrabberVB61.TextOverlay_Right = edtTextOverlayLeft.Text
    End If
End Sub

Private Sub ReloadImageSettings()
    chkImageOverlayEnabled.Value = MainForm.VideoGrabberVB61.ImageOverlayEnabled
    edtImageOverlayLeft.Text = MainForm.VideoGrabberVB61.ImageOverlay_LeftLocation
    edtImageOverlayTop.Text = MainForm.VideoGrabberVB61.ImageOverlay_TopLocation
    edtImageOverlayWidth.Text = MainForm.VideoGrabberVB61.ImageOverlay_Width
    edtImageOverlayHeight.Text = MainForm.VideoGrabberVB61.ImageOverlay_Height
    chkImageOverlayTransparent.Value = MainForm.VideoGrabberVB61.ImageOverlay_Transparent
    chkImageOverlayUseTransparentColor.Value = MainForm.VideoGrabberVB61.ImageOverlay_UseTransparentColor
    edtImageOverlayTransparentColorValue.Text = MainForm.VideoGrabberVB61.ImageOverlay_TransparentColorValue
    chkImageOverlayAlphaBlend.Value = MainForm.VideoGrabberVB61.ImageOverlay_AlphaBlend
    sldImageOverlayAlphaBlend.Value = MainForm.VideoGrabberVB61.ImageOverlay_AlphaBlendValue
    chkImageOverlayChromaKey.Value = MainForm.VideoGrabberVB61.ImageOverlay_ChromaKey
    sldImageOverlayChromaKey.Value = MainForm.VideoGrabberVB61.ImageOverlay_ChromaKeyLeewayPercent
    edtImageOverlayChromaKeyRGBValue.Text = MainForm.VideoGrabberVB61.ImageOverlay_ChromaKeyRGBColor
End Sub

Private Sub optImageSelector_Click(Index As Integer)
    MainForm.VideoGrabberVB61.ImageOverlaySelector = Index
    ReloadImageSettings
End Sub

Private Sub mmoTextOverlayString_Change()
    MainForm.VideoGrabberVB61.TextOverlay_String = mmoTextOverlayString.Text
End Sub

Private Sub rdgTextOverlayAlign1_Click()
   MainForm.VideoGrabberVB61.TextOverlay_Align = tf_Left
   mmoTextOverlayString.Alignment = 0
End Sub

Private Sub rdgTextOverlayAlign2_Click()
   MainForm.VideoGrabberVB61.TextOverlay_Align = tf_Center
   mmoTextOverlayString.Alignment = 2
End Sub

Private Sub rdgTextOverlayAlign3_Click()
   MainForm.VideoGrabberVB61.TextOverlay_Align = tf_Right
   mmoTextOverlayString.Alignment = 1
End Sub

Private Sub ReloadTextSettings()
    ' as we have selected another set, let's reload the corresponding values
    chkTextOverlayEnabled.Value = IIf(MainForm.VideoGrabberVB61.TextOverlay_Enabled, Checked, Unchecked)
    mmoTextOverlayString.Text = MainForm.VideoGrabberVB61.TextOverlay_String
    edtTextOverlayLeft.Text = MainForm.VideoGrabberVB61.TextOverlay_Left
    edtTextOverlayTop.Text = MainForm.VideoGrabberVB61.TextOverlay_Top
    edtTextOverlayWidth.Text = MainForm.VideoGrabberVB61.TextOverlay_Right
    chkTextOverlayTransparent.Value = IIf(MainForm.VideoGrabberVB61.TextOverlay_Transparent, Checked, Unchecked)
    SetOptionButtonByIndex rdgTextOverlayAlign, MainForm.VideoGrabberVB61.TextOverlay_Align
    chkTextOverlayShadow.Value = IIf(MainForm.VideoGrabberVB61.TextOverlay_Shadow, Checked, Unchecked)
    SetOptionButtonByIndex rdgTextOverlayShadow, MainForm.VideoGrabberVB61.TextOverlay_ShadowDirection
End Sub

Private Sub optTextSelector_Click(Index As Integer)
    MainForm.VideoGrabberVB61.TextOverlay_Selector = Index
    ReloadTextSettings
End Sub

Private Sub rdgTextOverlayShadow1_Click()
    MainForm.VideoGrabberVB61.TextOverlay_ShadowDirection = cd_North
End Sub

Private Sub rdgTextOverlayShadow2_Click()
    MainForm.VideoGrabberVB61.TextOverlay_ShadowDirection = cd_NorthEast
End Sub

Private Sub rdgTextOverlayShadow3_Click()
    MainForm.VideoGrabberVB61.TextOverlay_ShadowDirection = cd_East
End Sub

Private Sub rdgTextOverlayShadow4_Click()
    MainForm.VideoGrabberVB61.TextOverlay_ShadowDirection = cd_SouthEast
End Sub

Private Sub rdgTextOverlayShadow5_Click()
    MainForm.VideoGrabberVB61.TextOverlay_ShadowDirection = cd_South
End Sub

Private Sub rdgTextOverlayShadow6_Click()
    MainForm.VideoGrabberVB61.TextOverlay_ShadowDirection = cd_SouthWest
End Sub

Private Sub rdgTextOverlayShadow7_Click()
    MainForm.VideoGrabberVB61.TextOverlay_ShadowDirection = cd_West
End Sub

Private Sub rdgTextOverlayShadow8_Click()
    MainForm.VideoGrabberVB61.TextOverlay_ShadowDirection = cd_NorthWest
End Sub

Private Sub VScroll1_Change()

End Sub
