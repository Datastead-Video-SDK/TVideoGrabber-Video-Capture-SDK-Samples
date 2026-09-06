Attribute VB_Name = "modInsetForm"
Option Explicit

Private Type RECT
    Left As Long
    Top As Long
    Right As Long
    Bottom As Long
End Type

Public Const HWND_TOP = 0
Public Const WS_CHILD = &H40000000
Public Const GWL_HWNDPARENT = (-8)
Public Const GWL_STYLE = (-16)
Public Const SWP_NOSIZE = &H1
Public Const SWP_NOMOVE = &H2
Public Const SWP_NOZORDER = &H4
Public Const SWP_NOACTIVATE = &H10
Public Const SWP_SHOWWINDOW = &H40
Public Declare Function GetClientRect Lib "user32" (ByVal hwnd As Long, lpRect As RECT) As Long
Public Declare Function GetWindowLong Lib "user32" Alias "GetWindowLongA" (ByVal hwnd As Long, ByVal nIndex As Long) As Long
Public Declare Function SetWindowLong Lib "user32" Alias "SetWindowLongA" (ByVal hwnd As Long, ByVal nIndex As Long, ByVal dwNewLong As Long) As Long
Public Declare Function GetParent Lib "user32" (ByVal hwnd As Long) As Long
Public Declare Function SetParent Lib "user32" (ByVal hWndChild As Long, ByVal hWndNewParent As Long) As Long
Public Declare Function SetWindowPos Lib "user32" (ByVal hwnd As Long, ByVal hWndInsertAfter As Long, ByVal X As Long, ByVal Y As Long, ByVal cX As Long, ByVal cY As Long, ByVal wFlags As Long) As Long
Public rctRect As RECT

Public Sub InsetForm(ChildForm As Form, InsetHWnd As Long)
    
    
    Dim lngStyle As Long
    
    'Load ChildForm (see Form_Load of passed ChildForm)
    ChildForm.Hide

    'Change style to child window, set ChildForm's parent, set parent hWnd
    lngStyle = GetWindowLong(ChildForm.hwnd, GWL_STYLE) Or WS_CHILD
    SetWindowLong ChildForm.hwnd, GWL_STYLE, lngStyle
    SetParent ChildForm.hwnd, InsetHWnd
    SetWindowLong ChildForm.hwnd, GWL_HWNDPARENT, InsetHWnd
        
    'Get dimensions of the inset area
    GetClientRect InsetHWnd, rctRect

    'Show the inset ChildForm
    SetWindowPos ChildForm.hwnd, HWND_TOP, 0&, 0&, rctRect.Right, rctRect.Bottom, SWP_NOZORDER Or SWP_NOACTIVATE Or SWP_SHOWWINDOW
    'end revision
    
End Sub


