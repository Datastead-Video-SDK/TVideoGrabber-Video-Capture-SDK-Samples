Attribute VB_Name = "VidGrabUtil"
Option Explicit

Public Type RGBTRIPLE
    rgbtRed As Byte
    rgbtGreen As Byte
    rgbtBlue As Byte
End Type

Public Type RGBQUAD
    rgbBlue As Byte
    rgbGreen As Byte
    rgbRed As Byte
    rgbReserved As Byte
End Type

Public Type TFrameInfo
      FrameTime As Double
      FrameTime_TotalMin As Double
      FrameTime_TotalSec As Double
      FrameTime_TotalHs As Double
      FrameNumber As Double
      DroppedFrameCount As Long
      FrameTime_Hour As Long
      FrameTime_Min As Long
      FrameTime_Sec As Long
      FrameTime_Hs As Long
      DVTimeCode_IsAvailable As Long
      DVTimeCode_Hour As Long
      DVTimeCode_Min As Long
      DVTimeCode_Sec As Long
      DVTimeCode_Ff As Long
      DVTimeCode_TrackNumber As Long
      DVDateTime_IsAvailable As Long
      DVDateTime_Year As Long
      DVDateTime_Month As Long
      DVDateTime_Day As Long
      DVDateTime_Hour As Long
      DVDateTime_Min As Long
      DVDateTime_Sec As Long
      CurrentState As TxCurrentState
      GraphState As TxGraphState
      PlayerState As TxPlayerState
      Reserved0 As Long
      Reserved1 As Long
      Reserved2 As Long
End Type

Public Type TFrameBitmapInfo
      BitmapWidth As Long
      BitmapHeight As Long
      BitmapBitsPerPixel As Long
      BitmapLineSize As Long
      BitmapSize As Long
      BitmapPlanes As Long
      BitmapHandle As Long
      BitmapDataPtr As Long
      BitmapDC As Long
      CurrentXMouseLocation As Long
      CurrentYMouseLocation As Long
      LastXMouseDownLocation As Long
      LastYMouseDownLocation As Long
      IsMouseDown As Boolean
      LastMouseButtonClicked As TxMouseButton
End Type


Public Type PictDesc
    cbSizeofStruct As Long
    picType As Long
    hImage As Long
    xExt As Long
    yExt As Long
End Type

Public Type Guid
    Data1 As Long
    Data2 As Integer
    Data3 As Integer
    Data4(0 To 7) As Byte
End Type

Public Type RECT
    Left As Long
    Top As Long
    Right As Long
    Bottom As Long
End Type

Public Type FORM_TWIPS
    CaptionY As Long
    FrameX As Long
    FrameY As Long
End Type

Public Type BITMAP '14 bytes
        bmType As Long
        bmWidth As Long
        bmHeight As Long
        bmWidthBytes As Long
        bmPlanes As Integer
        bmBitsPixel As Integer
        bmBits As Long
End Type

Public Type BITMAPINFOHEADER
       biSize As Long
       biWidth As Long
       biHeight As Long
       biPlanes As Integer
       biBitCount As Integer
       biCompression As Long
       biSizeImage As Long
       biXPelsPerMeter As Long
       biYPelsPerMeter As Long
       biClrUsed As Long
       biClrImportant As Long
End Type


Public Type BITMAPINFO
       bmiHeader As BITMAPINFOHEADER
       bmiColors As RGBQUAD
End Type

Public Type DIBSECTION
   dsBm As BITMAP
   dsBmih As BITMAPINFOHEADER
   dsBitfields(0 To 2) As Long
   dshSection As Long
   dsOffset As Integer
   dsOffset2 As Integer
End Type

Public Const MAX_PATH = 260
Public Const MAXDWORD = &HFFFF
Public Const FILE_ATTRIBUTE_ARCHIVE = &H20
Public Const FILE_ATTRIBUTE_DIRECTORY = &H10
Public Const FILE_ATTRIBUTE_HIDDEN = &H2
Public Const FILE_ATTRIBUTE_NORMAL = &H80
Public Const FILE_ATTRIBUTE_READONLY = &H1
Public Const FILE_ATTRIBUTE_SYSTEM = &H4
Public Const FILE_ATTRIBUTE_TEMPORARY = &H100
Public Const ERROR_NO_MORE_FILES = 18
Public Const INVALID_HANDLE_VALUE = -1

Public Const OPEN_PICTURE_FILES = "Pictures (*.bmp;*.gif;*.jpg;*.tif;*.wmf;*.png;*.exf;*.emf)|*.bmp;*.gif;*.jpg;*.tif;*.wmf;*.png;*.emf;*.exf"
Public Const OPEN_MEDIA_FILES = "Clips (*.mp*;*.vro;*.avi;*.wav;*.asf;*.wmv;*.vob;*.avs;*.mov;*.divx;*.mid;*.mp4;*.mts;*.3gp;*.swf;*.m2v;*.mkv;*.flv)|*.mp*;*.vro;*.avi;*.wav;*.asf;*.wmv;*.vob;*.avs;*.mov;*.divx;*.mid;*.mp4;*.mts;*.3gp;*.swf;*.m2v;*.mkv;*.flv"
Public Const OPEN_MEDIA_FILES_EXTENDED = "Clips and Pictures (*.mp*;*.vro;*.avi;*.wav;*.asf;*.wmv;*.vob;*.avs;*.mov;*.divx;*.mid;*.mp4;*.mts;*.3gp;*.swf;*.m2v;*.mkv;*.flv;*.bmp;*.gif;*.jpg;*.tif;*.wmf)|*.mp*;*.vro;*.avi;*.wav;*.asf;*.wmv;*.vob;*.avs;*.mov;*.divx;*.mid;*.mp4;*.mts;*.3gp;*.swf;*.m2v;*.mkv;*.flv;*.bmp;*.gif;*.jpg;*.tif;*.wmf"
Public Const OPEN_WMV9_PROFILE_FILES = "WMV 9 Profile (*.prx) | *.prx"

Public Type FILETIME
    dwLowDateTime As Long
    dwHighDateTime As Long
End Type

Public Type WIN32_FIND_DATA
    dwFileAttributes As Long
    ftCreationTime As FILETIME
    ftLastAccessTime As FILETIME
    ftLastWriteTime As FILETIME
    nFileSizeHigh As Long
    nFileSizeLow As Long
    dwReserved0 As Long
    dwReserved1 As Long
    cFileName As String * MAX_PATH
    cAlternate As String * 14
End Type

Public Type TFileSearch
   Handle As Long
   Opened As Boolean
   Path As String
   Data As WIN32_FIND_DATA
End Type


Public Type FONTSPECS
    FontName As String
    FontSize As Long
    FontItalic As Boolean
    FontBold As Boolean
    FontUnderline As Boolean
    FontStrikeThru As Boolean
End Type


Public Const LF_FACESIZE = 32

Public Const FW_NORMAL = 400
Public Const FW_BOLD = 700

Public Type LOGFONT
    lfHeight As Long
    lfWidth As Long
    lfEscapement As Long
    lfOrientation As Long
    lfWeight As Long
    lfItalic As Byte
    lfUnderline As Byte
    lfStrikeOut As Byte
    lfCharSet As Byte
    lfOutPrecision As Byte
    lfClipPrecision As Byte
    lfQuality As Byte
    lfPitchAndFamily As Byte
    lfFaceName As String * LF_FACESIZE
End Type

Public Declare Function CreateFontIndirect Lib "gdi32" Alias "CreateFontIndirectA" (lpLogFont As LOGFONT) As Long
Public Declare Function CreateCompatibleDC Lib "gdi32" (ByVal hdc As Long) As Long
Public Declare Function GetObject Lib "gdi32" Alias "GetObjectA" (ByVal hObject As Long, ByVal nCount As Long, lpObject As Any) As Long
Public Declare Function SelectObject Lib "gdi32" (ByVal hdc As Long, ByVal hObject As Long) As Long
Public Declare Function DeleteObject Lib "gdi32.dll" (ByVal hObject As Long) As Long
Public Declare Function BitBlt Lib "gdi32" (ByVal hDestDC As Long, ByVal X As Long, ByVal Y As Long, ByVal nWidth As Long, ByVal nHeight As Long, ByVal hSrcDC As Long, ByVal xSrc As Long, ByVal ySrc As Long, ByVal dwRop As Long) As Long
Public Declare Function StretchBlt Lib "gdi32" (ByVal hdc As Long, ByVal X As Long, ByVal Y As Long, ByVal nWidth As Long, ByVal nHeight As Long, ByVal hSrcDC As Long, ByVal xSrc As Long, ByVal ySrc As Long, ByVal nSrcWidth As Long, ByVal nSrcHeight As Long, ByVal dwRop As Long) As Long
Public Declare Function DeleteDC Lib "gdi32" (ByVal hdc As Long) As Long
Public Declare Function SaveDC Lib "gdi32" (ByVal hdc As Long) As Long
Public Declare Function RestoreDC Lib "gdi32" (ByVal hdc As Long, ByVal nSavedDC As Long) As Long
Public Declare Function SetPixel Lib "gdi32" (ByVal hdc As Long, ByVal X As Long, ByVal Y As Long, ByVal crColor As Long) As Long
Public Declare Function LineTo Lib "gdi32" (ByVal hdc As Long, ByVal X As Long, ByVal Y As Long) As Long
Public Declare Function MoveToEx Lib "gdi32" (ByVal hdc As Long, ByVal X As Long, ByVal Y As Long, ByRef lpPoint As POINTAPI) As Long
Public Declare Function Ellipse Lib "gdi32" (ByVal hdc As Long, ByVal LeftRect As Long, ByVal TopRect As Long, ByVal RightRect As Long, ByVal BottomRect As Long) As Long
Public Declare Function GetStockObject Lib "gdi32" (ByVal nIndex As Long) As Long
Public Declare Function GdiFlush Lib "gdi32" () As Long
Public Declare Function CreateDIBSection Lib "gdi32" (ByVal hdc As Long, ByRef pBitmapInfo As BITMAPINFOHEADER, ByVal un As Long, ppBits As Long, ByVal hdl As Long, ByVal dw As Long) As Long
Public Declare Function CreatePen Lib "gdi32" (ByVal nPenStyle As Long, ByVal nWidth As Long, ByVal crColor As Long) As Long
Public Declare Function FindFirstFile Lib "kernel32" Alias "FindFirstFileA" (ByVal lpFileName As String, ByRef lpFindFileData As WIN32_FIND_DATA) As Long
Public Declare Function FindNextFile Lib "kernel32" Alias "FindNextFileA" (ByVal hFindFile As Long, ByRef lpFindFileData As WIN32_FIND_DATA) As Long
Public Declare Function GetFileAttributes Lib "kernel32" Alias "GetFileAttributesA" (ByVal lpFileName As String) As Long
Public Declare Function FindClose Lib "kernel32" (ByVal hFindFile As Long) As Long
Public Declare Sub CopyMemory Lib "kernel32" Alias "RtlMoveMemory" (ByVal pDestination As Long, ByVal pSource As Long, ByVal nBytes As Long)
Public Declare Sub ZeroMemory Lib "kernel32" Alias "RtlZeroMemory" (ByVal pDestination As Long, ByVal Length As Long)
Public Declare Function OleCreatePictureIndirect Lib "olepro32.dll" (lpPictDesc As PictDesc, riid As Guid, ByVal fPictureOwnsHandle As Long, IPic As IPicture) As Long
Public Declare Function LoadImage Lib "user32" Alias "LoadImageA" (ByVal hInst As Long, ByVal lpsz As String, ByVal un1 As Long, ByVal n1 As Long, ByVal n2 As Long, ByVal un2 As Long) As Long
Public Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long
Public Declare Function GetTickCount Lib "kernel32.dll" () As Long

Public Const SM_CXFRAME As Long = 32
Public Const SM_CYFRAME As Long = 33
Public Const SM_CYCAPTION As Long = 4
Public Declare Function GetSystemMetrics Lib "user32" (ByVal nIndex As Integer) As Long

Public Const LR_CREATEDIBSECTION = &H2000
Public Const LR_DEFAULTCOLOR = &H0
Public Const LR_DEFAULTSIZE = &H40
Public Const LR_LOADFROMFILE = &H10

Public Const PS_SOLID       As Long = 0
Public Const PS_DASH        As Long = 1
Public Const PS_DOT         As Long = 2
Public Const PS_DASHDOT     As Long = 3
Public Const PS_DASHDOTDOT  As Long = 4
Public Const PS_NULL        As Long = 5
Public Const PS_INSIDEFRAME As Long = 6
Public Const PS_USERSTYLE   As Long = 7
Public Const PS_ALTERNATE   As Long = 8
Public Const PS_STYLE_MASK  As Long = &HF

Public Const NULL_BRUSH As Long = 5

Public Type POINTAPI
        X As Long
        Y As Long
End Type

Public CamN


Public Function AddLog(TxtBox As TextBox, Line As String)
   TxtBox.Text = TxtBox.Text + vbCrLf + Line
   TxtBox.SelStart = Len(TxtBox.Text)
End Function

Public Function CreateFontFromSpecs(FontName As String, FontSize As Long, Bold As Boolean, Italic As Boolean, UnderLine As Boolean, Angle As Double, FontSpec As FONTSPECS) As Long
    Dim FontData As LOGFONT
     
    ZeroMemory VarPtr(FontData), Len(FontData)
    
    With FontData
        .lfFaceName = Mid$(FontName, 1, LF_FACESIZE - 1) & Chr$(0)
        .lfWeight = IIf(Bold, FW_BOLD, FW_NORMAL)
        .lfHeight = (FontSize * -20) / Screen.TwipsPerPixelY
        .lfItalic = IIf(Italic, 1, 0)
        .lfUnderline = IIf(UnderLine, 1, 0)
        .lfEscapement = Angle * 10
    End With
    With FontSpec
        .FontName = FontName
        .FontSize = FontSize
        .FontItalic = Italic
        .FontBold = Bold
        .FontUnderline = UnderLine
        .FontStrikeThru = False
    End With
    
    CreateFontFromSpecs = CreateFontIndirect(FontData)

End Function

Public Function CreateFontFromDialog(FontDlg As CommonDialog, FontHandle As Long, ByRef FontColor As Long, FontSpec As FONTSPECS) As Boolean
    Dim FontData  As LOGFONT
    
    FontDlg.Flags = cdlCFEffects Or cdlCFBoth
    
    CreateFontFromDialog = False
    
    FontDlg.ShowFont
    
    If Err.Number <> 0 Then
        Err = 0
    Else
        ZeroMemory VarPtr(FontData), Len(FontData)
        With FontData
            .lfFaceName = Mid$(FontDlg.FontName, 1, LF_FACESIZE - 1) & Chr$(0)
            .lfWeight = IIf(FontDlg.FontBold, FW_BOLD, FW_NORMAL)
            .lfHeight = (FontDlg.FontSize * -20) / Screen.TwipsPerPixelY
            .lfItalic = IIf(FontDlg.FontItalic, 1, 0)
            .lfUnderline = IIf(FontDlg.FontUnderline, 1, 0)
        End With
        With FontSpec
            .FontName = FontDlg.FontName
            .FontSize = FontDlg.FontSize
            .FontItalic = FontDlg.FontItalic
            .FontBold = FontDlg.FontBold
            .FontUnderline = FontDlg.FontUnderline
            .FontStrikeThru = FontDlg.FontStrikeThru
        End With
    
        FontHandle = CreateFontIndirect(FontData)
        FontColor = FontDlg.Color
        
        CreateFontFromDialog = True
    End If

End Function

Public Function GetColorFromDialog(ColorDlg As CommonDialog, ByRef Color As Long) As Boolean
    
    With ColorDlg
        .Flags = cdlCCRGBInit
        .ShowColor
        If Err.Number <> 0 Then
            Err = 0
        Else
            Color = .Color
            GetColorFromDialog = True
        End If
    End With

End Function

Public Function BitmapToPicture(ByVal hBmp As Long) As IPicture

    If (hBmp = 0) Then Exit Function
    
    Dim oNewPic As Picture, tPicConv As PictDesc, IGuid As Guid
    
    With tPicConv
    .cbSizeofStruct = Len(tPicConv)
    .picType = vbPicTypeBitmap
    .hImage = hBmp
    End With
    
    With IGuid
    .Data1 = &H20400
    .Data4(0) = &HC0
    .Data4(7) = &H46
    End With
    
    OleCreatePictureIndirect tPicConv, IGuid, True, oNewPic
    
    Set BitmapToPicture = oNewPic
    
End Function

Public Sub SetOptionButtonByIndex(FrameName As Control, Indx As Integer)
   
   Dim Ctrl As Control
   
    For Each Ctrl In FrameName.Parent.Controls
     If TypeOf Ctrl Is OptionButton Then
       If Ctrl.Container = FrameName Then
                If Ctrl.Tag = Indx Then
                    Ctrl.Value = True
                End If
        End If
    End If
    Next
End Sub

Public Sub EnableOrDisableFrameControls(FrameName As Control, EnableChkBox As Boolean)
   Dim Ctrl As Control
   Dim ChkBox As CheckBox
   
    For Each Ctrl In FrameName.Parent.Controls
     If TypeOf Ctrl Is CheckBox Then
        Set ChkBox = Ctrl
        If ChkBox.Container Is FrameName Then
          ChkBox.Enabled = EnableChkBox
        End If
     End If
    Next
End Sub

Public Sub LoadTextBox(ByRef Dest As ListBox, Source As String)
    Dim Startpos As Long
    Dim Endpos As Long
    
    Startpos = 1
    
    Dest.Clear
    Endpos = InStr(Startpos, Source, vbCr)
    While (Endpos <> 0)
        Dest.AddItem Mid(Source, Startpos, Endpos - Startpos)
        Startpos = Endpos + 2 ' skip CR/LF
        Endpos = InStr(Startpos, Source, vbCr)
    Wend
End Sub

Public Sub AssignListToComboBox(ByRef Dest As ComboBox, Source As String, Indx As Long, Optional MaxIndxLimit As Long)
    Dim Startpos As Long
    Dim Endpos As Long
    Dim MaxIndxCount As Long
    Dim Finished As Boolean
    Dim Line As String
    
    Startpos = 1
    
    If MaxIndxLimit > 0 Then
       MaxIndxCount = MaxIndxLimit
    Else
       MaxIndxCount = 99999
    End If
    
    Dest.Clear
    Finished = False
    While Not Finished
        Endpos = InStr(Startpos, Source, vbCr)
        If Startpos < Len(Source) Then
            If Endpos > 0 Then
                Line = Mid(Source, Startpos, Endpos - Startpos)
            Else
                Line = Mid(Source, Startpos, Len(Source) - Startpos + 1)
                Finished = True
            End If
            If Line <> "" Then
                Dest.AddItem Line
            Else
                Finished = True
            End If
        Else
            Finished = True
        End If
        Startpos = Endpos + 2 ' skip next CR/LF
        MaxIndxCount = MaxIndxCount - 1
    Wend
    
    If (Indx >= 0) And (Indx < Dest.ListCount) Then
       Dest.ListIndex = Indx
    End If
End Sub

Public Sub FileSearch_Close(ByRef FileSearch As TFileSearch)
    If FileSearch.Opened Then
        FindClose (FileSearch.Handle)
        FileSearch.Opened = False
    End If
End Sub

Public Function FileSearch_FirstFile(ByVal SearchPath As String, ByVal FileKind As String, ByRef FileSearch As TFileSearch) As String
    
    FileSearch_FirstFile = ""
    
    FileSearch_Close FileSearch ' let's close any previous opened search
        
    If Len(SearchPath) > 0 Then ' let's add a trailing slash if required
        If Right$(SearchPath, 1) = "\" Then
            FileSearch.Path = SearchPath
        Else
            FileSearch.Path = SearchPath + "\"
        End If
    Else
        FileSearch.Path = ".\"
    End If
        
    FileSearch.Handle = FindFirstFile(FileSearch.Path + FileKind, FileSearch.Data)
    If FileSearch.Handle <> INVALID_HANDLE_VALUE Then
        FileSearch_FirstFile = FileSearch.Path + FileSearch.Data.cFileName
        FileSearch.Opened = True
    End If
End Function

Public Function FileSearch_NextFile(ByRef FileSearch As TFileSearch) As String
    
    FileSearch_NextFile = ""
        If FileSearch.Opened Then
        If FindNextFile(FileSearch.Handle, FileSearch.Data) <> 0 Then
            FileSearch_NextFile = FileSearch.Path + FileSearch.Data.cFileName
        Else
            FileSearch_Close FileSearch
        End If
    End If
End Function

Public Function PixelsToFormScaleMode(Pixels As Long, FormScaleMode As Long) As Long
    PixelsToFormScaleMode = 0
End Function

