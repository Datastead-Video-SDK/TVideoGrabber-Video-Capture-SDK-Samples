VERSION 5.00
Begin VB.Form TransparentWindow 
   Caption         =   "transparent window"
   ClientHeight    =   1695
   ClientLeft      =   120
   ClientTop       =   420
   ClientWidth     =   5055
   LinkTopic       =   "Form1"
   ScaleHeight     =   1695
   ScaleWidth      =   5055
   StartUpPosition =   3  'Windows Default
   Begin VB.Label LabelTransparentWindow 
      Alignment       =   2  'Center
      Caption         =   "transparent window"
      BeginProperty Font 
         Name            =   "Arial Black"
         Size            =   14.25
         Charset         =   0
         Weight          =   900
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   615
      Left            =   0
      TabIndex        =   0
      Top             =   480
      Width           =   5055
   End
End
Attribute VB_Name = "TransparentWindow"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
