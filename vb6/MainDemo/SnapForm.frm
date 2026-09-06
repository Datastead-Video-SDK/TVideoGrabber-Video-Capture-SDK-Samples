VERSION 5.00
Begin VB.Form SnapForm 
   AutoRedraw      =   -1  'True
   Caption         =   "Form1"
   ClientHeight    =   3420
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   4485
   LinkTopic       =   "Form1"
   ScaleHeight     =   3420
   ScaleWidth      =   4485
   Begin VB.PictureBox SnapImage 
      AutoRedraw      =   -1  'True
      Height          =   3300
      Left            =   0
      ScaleHeight     =   3240
      ScaleWidth      =   4320
      TabIndex        =   0
      Top             =   0
      Width           =   4380
   End
End
Attribute VB_Name = "SnapForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
' this form is invoked by the OnFrameCaptureCompleted event to display the captured frame

Private Sub Form_Unload(Cancel As Integer)
   If Not MainForm.CanUnload Then
      Hide
      Cancel = True
   End If
End Sub

