Attribute VB_Name = "modMainForm"
Option Explicit

Public Type WINDOW_ENUM
    WindowHandle As Long
    WindowName As String
    WindowClass As String
End Type

Public lngScreenRecordingWindow As Long
Public strScreenRecordingWindow As String
Public boolScreenRecordingWindow As Boolean
Public wenScreenRecordingWindow() As WINDOW_ENUM

Public VideoFromBitmapUsePictureBoxHandle() As Long

