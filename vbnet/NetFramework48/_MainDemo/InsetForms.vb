Option Strict Off
Option Explicit On
Module InsetForms

    Public Structure WINDOW_ENUM
        Dim WindowHandle As IntPtr
        Dim WindowName As String
        Dim WindowClass As String
    End Structure

    Public lngScreenRecordingWindow As Integer
    Public strScreenRecordingWindow As String
    Public boolScreenRecordingWindow As Boolean
    Public wenScreenRecordingWindow() As WINDOW_ENUM

    Public Structure INSET_RECT
        Dim InSetLeft As Integer
        Dim InSetTop As Integer
        Dim InSetRight As Integer
        Dim InSetBottom As Integer
    End Structure

    Public frmInsetForm As Form

    Public Const HWND_TOP As Short = 0
    Public Const WS_CHILD As Integer = &H40000000
    Public Const GWL_HWNDPARENT As Short = (-8)
    Public Const GWL_STYLE As Short = (-16)
    Public Const SWP_NOSIZE As Short = &H1
    Public Const SWP_NOMOVE As Short = &H2
    Public Const SWP_NOACTIVATE As Short = &H10S
    Public Const SWP_NOZORDER As Short = &H4S
    Public Const SWP_SHOWWINDOW As Short = &H40S

    Public Declare Function GetClientRect Lib "USER32" (ByVal hwnd As IntPtr, ByRef lpRect As INSET_RECT) As Integer
    Public Declare Function GetWindowLong Lib "USER32" Alias "GetWindowLongA" (ByVal hwnd As IntPtr, ByVal nIndex As Integer) As Integer
    Public Declare Function SetWindowLong Lib "USER32" Alias "SetWindowLongA" (ByVal hwnd As IntPtr, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
    Public Declare Function GetParent Lib "USER32" (ByVal hwnd As IntPtr) As Integer
    Public Declare Function SetParent Lib "USER32" (ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As Integer
    Public Declare Function SetWindowPos Lib "USER32" (ByVal hwnd As IntPtr, ByVal hWndInsertAfter As IntPtr, ByVal X As Integer, ByVal Y As Integer, ByVal cX As Integer, ByVal cY As Integer, ByVal wFlags As Integer) As Integer
    Private rctRect As INSET_RECT


    Public Sub InsetForm(ByRef ChildForm As System.Windows.Forms.Form, ByRef InsetHWnd As IntPtr)


        Dim lngStyle As Integer

        'ChildForm must be initialized; if it isn't, initialize with 
        ChildForm.Hide()

        'Change style to child window, set ChildForm's parent, set parent hWnd
        lngStyle = GetWindowLong(ChildForm.Handle, GWL_STYLE) Or WS_CHILD
        SetWindowLong(ChildForm.Handle, GWL_STYLE, lngStyle)
        SetParent(ChildForm.Handle, InsetHWnd)

        'Get dimensions of the inset area
        GetClientRect(InsetHWnd, rctRect)

        'Show the inset ChildForm
        SetWindowPos(ChildForm.Handle, HWND_TOP, 0, 0, rctRect.InSetRight, rctRect.InSetBottom, SWP_NOZORDER Or SWP_NOACTIVATE Or SWP_SHOWWINDOW)

        'end revision

    End Sub
End Module