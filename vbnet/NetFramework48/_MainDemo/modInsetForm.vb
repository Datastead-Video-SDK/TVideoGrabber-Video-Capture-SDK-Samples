Option Strict Off
Option Explicit On
Module modInsetForm
	
	Public Structure INSET_RECT
		'UPGRADE_NOTE: Left was upgraded to Left_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Left_Renamed As Integer
		Dim Top As Integer
		'UPGRADE_NOTE: Right was upgraded to Right_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Right_Renamed As Integer
		Dim Bottom As Integer
    End Structure

    Public frmInsetForm As Form

	Public Const HWND_TOP As Short = 0
	Public Const WS_CHILD As Integer = &H40000000
	Public Const GWL_HWNDPARENT As Short = (-8)
	Public Const GWL_STYLE As Short = (-16)
	Public Const SWP_NOACTIVATE As Short = &H10s
	Public Const SWP_NOZORDER As Short = &H4s
	Public Const SWP_SHOWWINDOW As Short = &H40s
	'UPGRADE_WARNING: Structure INSET_RECT may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Public Declare Function GetClientRect Lib "USER32" (ByVal hwnd As IntPtr, ByRef lpRect As INSET_RECT) As Integer
	Public Declare Function GetWindowLong Lib "USER32"  Alias "GetWindowLongA"(ByVal hwnd As IntPtr, ByVal nIndex As Integer) As Integer
	Public Declare Function SetWindowLong Lib "USER32"  Alias "SetWindowLongA"(ByVal hwnd As IntPtr, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
	Public Declare Function GetParent Lib "USER32" (ByVal hwnd As IntPtr) As Integer
	Public Declare Function SetParent Lib "USER32" (ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As Integer
	Public Declare Function SetWindowPos Lib "USER32" (ByVal hwnd As IntPtr, ByVal hWndInsertAfter As IntPtr, ByVal X As Integer, ByVal Y As Integer, ByVal cX As Integer, ByVal cY As Integer, ByVal wFlags As Integer) As Integer
	Private rctRect As INSET_RECT
	

    Public Sub InsetForm(ByRef ChildForm As System.Windows.Forms.Form, ByRef Insethwnd As IntPtr)

        
        Dim lngStyle As Integer

        'Load ChildForm (see Form_Load of passed ChildForm)
        'ChildForm.Hide()

        'Change style to child window, set ChildForm's parent, set parent hWnd
        lngStyle = GetWindowLong(ChildForm.Handle, GWL_STYLE) Or WS_CHILD
        SetWindowLong(ChildForm.Handle, GWL_STYLE, lngStyle)
        SetParent(ChildForm.Handle, InsetHWnd)
        SetWindowLong(ChildForm.Handle, GWL_HWNDPARENT, InsetHWnd)

        'Get dimensions of the inset area
        GetClientRect(InsetHWnd, rctRect)

        'Show the inset ChildForm
        SetWindowPos(ChildForm.Handle, HWND_TOP, 6, 6, rctRect.Right_Renamed, rctRect.Bottom, SWP_NOZORDER Or SWP_NOACTIVATE Or SWP_SHOWWINDOW)

        'end revision

    End Sub
End Module