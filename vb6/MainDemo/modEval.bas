Attribute VB_Name = "modEval"
Option Explicit

Public boolStopEval As Boolean



Private Sub VideoGrabberVB61_OnInactive()
    AddLog mmoLog, "(done.)"
    
    If Not boolStopEval Then
        VideoGrabberVB61.StartPreview
    End If
    
End Sub

Private Sub btnStartPreview_Click()

    'eval
    boolStopEval = False

   MainForm.VideoGrabberVB61.StartPreview
End Sub

Private Sub btnStopPreview_Click()

    'eval
    boolStopEval = True

   MainForm.VideoGrabberVB61.StopPreview
End Sub


