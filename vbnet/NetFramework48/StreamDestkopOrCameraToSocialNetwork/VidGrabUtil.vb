Option Strict Off
Option Explicit On

Imports System.Windows.Forms
imports System.IO
Imports System.Runtime.InteropServices
Imports System.Collections.Generic
Imports System.Text.RegularExpressions

Module VidGrabUtil

    Public Const MAX_PATH As Short = 260
    Public Const MAXDWORD As Short = &HFFFFS
    Public Const FILE_ATTRIBUTE_ARCHIVE As Short = &H20S
    Public Const FILE_ATTRIBUTE_DIRECTORY As Short = &H10S
    Public Const FILE_ATTRIBUTE_HIDDEN As Short = &H2S
    Public Const FILE_ATTRIBUTE_NORMAL As Short = &H80S
    Public Const FILE_ATTRIBUTE_READONLY As Short = &H1S
    Public Const FILE_ATTRIBUTE_SYSTEM As Short = &H4S
    Public Const FILE_ATTRIBUTE_TEMPORARY As Short = &H100S
    Public Const ERROR_NO_MORE_FILES As Short = 18
    Public Const INVALID_HANDLE_VALUE As Short = -1
    Public Const SRCCOPY As Int32 = &HCC0020
    Public Const OPEN_COMPRESSOR_FILES As String = "Compressor saved settings (*.txt)|*.txt"

    Public Const AUDIO_CLIPS As String = "*.mp3;*.wav;*.wma;*.mid"
    Public Const VIDEO_CLIPS As String = "*.mp*;*.vro;*.avi;*.asf;*.wmv;*.vob;*.avs;*.mov;*.divx;*.mp4;*.mts;*.3gp;*.swf;*.m2v;*.mkv;*.flv;*.webm;*.ts;*.m4v;*.mp4v;*.ogg;*.amv;*.rm;*.m2t*"
    Public Const IMAGE_FILES As String = "*.jpg;*.jpeg;*.jpe;*.bmp;*.gif;*.png"
    Public Const OPEN_MEDIA_FILES As String = "All media files|" + VIDEO_CLIPS + AUDIO_CLIPS + IMAGE_FILES _
                    & "|Video clips|" + VIDEO_CLIPS _
                    & "|Audio clips|" + AUDIO_CLIPS
    Public Const OPEN_MEDIA_FILES_EXTENDED As String = OPEN_MEDIA_FILES _
                    & "|Image files|" + IMAGE_FILES
    Public Const OPEN_PICTURE_FILES As String = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif;*.tiff;*.wmf;*.emf;*.exf;*.jpe;*.jpeg"
    Public Const OPEN_PROFILES As String = "WMV9 profiles (*.prx)|*.prx"
    Public Const OPEN_COMPRESSOR_SETTINGS As String = "Compressor saved settings (*.txt)|*.txt"


    Public Structure FILETIME
        Dim dwLowDateTime As Integer
        Dim dwHighDateTime As Integer
    End Structure


    Public Declare Function GetFileAttributes Lib "kernel32" Alias "GetFileAttributesA" (ByVal lpFileName As String) As Integer
    Public Declare Sub CopyMemory Lib "kernel32" Alias "RtlMoveMemory" (ByRef pDestination As Object, ByRef pSource As Object, ByVal nBytes As Integer)
    Public Declare Sub ZeroMemory Lib "kernel32" Alias "RtlZeroMemory" (ByVal pDestination As Integer, ByVal Length As Integer)
    Public Declare Function LoadImage Lib "user32" Alias "LoadImageA" (ByVal hInst As Integer, ByVal lpsz As String, ByVal un1 As Integer, ByVal n1 As Integer, ByVal n2 As Integer, ByVal un2 As Integer) As Integer
    Public Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As IntPtr, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer
    Public Declare Function Beep Lib "kernel32" Alias "Beep" (ByVal dwFreq As Integer, ByVal dwDuration As Integer) As Integer
    Public Declare Function DeleteObject Lib "gdi32" (ByVal hObject As IntPtr) As Boolean


    Public Const LR_CREATEDIBSECTION As Short = &H2000S
    Public Const LR_DEFAULTCOLOR As Short = &H0S
    Public Const LR_DEFAULTSIZE As Short = &H40S
    Public Const LR_LOADFROMFILE As Short = &H10S

    Public Sub AddLog(ByRef TxtBox As TextBox, ByRef Line As String)
        TxtBox.AppendText(Environment.NewLine + Line)
    End Sub


    Public Sub SetRadioButtonInGroupUsingTag(ByRef FrameName As Control, ByRef Indx As Short)
        Dim Ctrl As Control

        For Each Ctrl In FrameName.Controls
            If TypeOf Ctrl Is RadioButton Then
                If Ctrl.Tag = Indx Then
                    DirectCast(Ctrl, RadioButton).Checked = True
                End If
            End If
        Next Ctrl
    End Sub

    Public Function CRLFDelimitedStringToIList(ByVal CRLFString As String) As IList(Of String)
        Dim list As IList(Of String) = New List(Of String)

        If Not String.IsNullOrEmpty(CRLFString) Then ' checking "CRLFString != NULL" is required!
            Dim lines As String() = Regex.Split(CRLFString, "\r\n")
            Dim line As String
            For Each line In lines
                list.Add(line)
            Next line
        End If
        Return list
    End Function

    Public Sub LoadTextBox(ByRef Dest As ListBox, ByRef CRLFString As String)
        Dest.Items.Clear()
        Dim ListItems As IList(Of String) = CRLFDelimitedStringToIList(CRLFString)
        Dim line As String
        For Each line In ListItems
            Dest.Items.Add(line)
        Next line
    End Sub

    Public Sub AssignListToComboBox(ByRef Dest As ComboBox, ByRef CRLFString As String, ByRef Indx As Integer, Optional ByRef MaxIndxLimit As Integer = 0)
        Dest.Items.Clear()
        Dim ListItems As IList(Of String) = CRLFDelimitedStringToIList(CRLFString)
        Dim line As String
        For Each line In ListItems
            Dest.Items.Add(line)
        Next line
        If (Indx >= 0) And (Indx < Dest.Items.Count) Then
            Dest.SelectedIndex = Indx
        Else
            Dest.SelectedIndex = -1
        End If
    End Sub

    Public Function CreateBitmapHandleFromPictureBox(ByVal PbCtrl As PictureBox) As Bitmap
        Dim bmp As Bitmap = New Bitmap(PbCtrl.ClientRectangle.Width, PbCtrl.ClientRectangle.Height)
        Dim gMem As Graphics = Graphics.FromImage(bmp)

        gMem.DrawImageUnscaled(PbCtrl.Image, New Point(0, 0))
        gMem.Dispose()

        CreateBitmapHandleFromPictureBox = bmp
    End Function

    Class VideoFromImagesFileList
        Inherits ArrayList

        Private m_CurrentIndex As Integer
        Private m_CurrentFolder As String
        Private m_LoopIndefinitely As Boolean

        Public Sub VideoFromImagesFileList()

            m_CurrentFolder = ""
            m_CurrentIndex = 0
            m_LoopIndefinitely = False
        End Sub

        Public Function ReinitFolder(ByVal Folder As String, ByVal FileType As String, ByVal LoopIndefinitely As Boolean) As Boolean
            m_CurrentFolder = Folder.Trim()
            If m_CurrentFolder = "" Then
                m_CurrentFolder = Directory.GetCurrentDirectory()
            End If
            Me.Clear()
            m_CurrentIndex = 0
            Dim di As DirectoryInfo = New DirectoryInfo(m_CurrentFolder)
            If di.Exists Then
                Dim fileInfoArray() As FileInfo = di.GetFiles(FileType)
                Me.AddRange(fileInfoArray)
                ReinitFolder = Me.Count > 0
                m_LoopIndefinitely = LoopIndefinitely
            Else
                ReinitFolder = False
            End If

        End Function

        Public Function FirstImageFile() As String

            m_CurrentIndex = -1
            FirstImageFile = NextImageFile()
        End Function

        Public Function NextImageFile() As String

            m_CurrentIndex = m_CurrentIndex + 1
            If Me.Count = 0 Then
                NextImageFile = ""
                Exit Function
            ElseIf (m_CurrentIndex >= Me.Count) And m_LoopIndefinitely Then
                m_CurrentIndex = 0
            End If
            NextImageFile = m_CurrentFolder & "\" & Me(m_CurrentIndex).ToString()
        End Function
    End Class

End Module
