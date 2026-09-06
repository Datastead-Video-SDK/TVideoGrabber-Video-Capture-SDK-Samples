Option Strict Off
Option Explicit On 
Friend Class VideoFromJPEGsorBitmaps
    Inherits SubForm ' SubForm is declared in VBUtil and inherits from System.Windows.Forms.Form
    'Unlike normal Form, it is not destroyed when closed, unless MainForm is being destroyed too.

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents edtVideoFromJPEGsorBitmaps As System.Windows.Forms.TextBox
    Friend WithEvents btnStartPreview As System.Windows.Forms.Button
    Friend WithEvents btnStopPreview As System.Windows.Forms.Button
    Friend WithEvents grbVideoFromJPEGsorBitmaps As System.Windows.Forms.GroupBox
    Friend WithEvents chkLoopIndefinitely As System.Windows.Forms.CheckBox
    Friend WithEvents btnBrowseFolders As System.Windows.Forms.Button
    Friend WithEvents edtSourceFolder As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents rbFromBMPorJPEGfiles As System.Windows.Forms.RadioButton
    Friend WithEvents rbFromPictureBox As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblFirstSelectJPEGsOrBitmaps As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VideoFromJPEGsorBitmaps))
        Me.edtVideoFromJPEGsorBitmaps = New System.Windows.Forms.TextBox
        Me.btnStartPreview = New System.Windows.Forms.Button
        Me.btnStopPreview = New System.Windows.Forms.Button
        Me.grbVideoFromJPEGsorBitmaps = New System.Windows.Forms.GroupBox
        Me.chkLoopIndefinitely = New System.Windows.Forms.CheckBox
        Me.btnBrowseFolders = New System.Windows.Forms.Button
        Me.edtSourceFolder = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.rbFromBMPorJPEGfiles = New System.Windows.Forms.RadioButton
        Me.rbFromPictureBox = New System.Windows.Forms.RadioButton
        Me.lblFirstSelectJPEGsOrBitmaps = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.grbVideoFromJPEGsorBitmaps.SuspendLayout()
#If Not VS2003 Then
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
#End If
        Me.SuspendLayout()
        '
        'edtVideoFromJPEGsorBitmaps
        '
        Me.edtVideoFromJPEGsorBitmaps.BackColor = System.Drawing.Color.Silver
        Me.edtVideoFromJPEGsorBitmaps.Location = New System.Drawing.Point(595, 6)
        Me.edtVideoFromJPEGsorBitmaps.Multiline = True
        Me.edtVideoFromJPEGsorBitmaps.Name = "edtVideoFromJPEGsorBitmaps"
        Me.edtVideoFromJPEGsorBitmaps.ReadOnly = True
        Me.edtVideoFromJPEGsorBitmaps.Size = New System.Drawing.Size(315, 170)
        Me.edtVideoFromJPEGsorBitmaps.TabIndex = 29
        Me.edtVideoFromJPEGsorBitmaps.Text = resources.GetString("edtVideoFromJPEGsorBitmaps.Text")
        '
        'btnStartPreview
        '
        Me.btnStartPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartPreview.Location = New System.Drawing.Point(362, 69)
        Me.btnStartPreview.Name = "btnStartPreview"
        Me.btnStartPreview.Size = New System.Drawing.Size(88, 24)
        Me.btnStartPreview.TabIndex = 37
        Me.btnStartPreview.Text = "Start preview"
        '
        'btnStopPreview
        '
        Me.btnStopPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStopPreview.Location = New System.Drawing.Point(456, 69)
        Me.btnStopPreview.Name = "btnStopPreview"
        Me.btnStopPreview.Size = New System.Drawing.Size(88, 24)
        Me.btnStopPreview.TabIndex = 59
        Me.btnStopPreview.Text = "Stop preview"
        '
        'grbVideoFromJPEGsorBitmaps
        '
        Me.grbVideoFromJPEGsorBitmaps.Controls.Add(Me.btnStopPreview)
        Me.grbVideoFromJPEGsorBitmaps.Controls.Add(Me.btnStartPreview)
        Me.grbVideoFromJPEGsorBitmaps.Controls.Add(Me.chkLoopIndefinitely)
        Me.grbVideoFromJPEGsorBitmaps.Controls.Add(Me.btnBrowseFolders)
        Me.grbVideoFromJPEGsorBitmaps.Controls.Add(Me.edtSourceFolder)
        Me.grbVideoFromJPEGsorBitmaps.Controls.Add(Me.Label1)
        Me.grbVideoFromJPEGsorBitmaps.Controls.Add(Me.PictureBox4)
        Me.grbVideoFromJPEGsorBitmaps.Controls.Add(Me.PictureBox3)
        Me.grbVideoFromJPEGsorBitmaps.Controls.Add(Me.PictureBox2)
        Me.grbVideoFromJPEGsorBitmaps.Controls.Add(Me.PictureBox1)
        Me.grbVideoFromJPEGsorBitmaps.Controls.Add(Me.rbFromBMPorJPEGfiles)
        Me.grbVideoFromJPEGsorBitmaps.Controls.Add(Me.rbFromPictureBox)
        Me.grbVideoFromJPEGsorBitmaps.Controls.Add(Me.lblFirstSelectJPEGsOrBitmaps)
        Me.grbVideoFromJPEGsorBitmaps.Controls.Add(Me.Label2)
        Me.grbVideoFromJPEGsorBitmaps.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbVideoFromJPEGsorBitmaps.Location = New System.Drawing.Point(4, 0)
        Me.grbVideoFromJPEGsorBitmaps.Name = "grbVideoFromJPEGsorBitmaps"
        Me.grbVideoFromJPEGsorBitmaps.Size = New System.Drawing.Size(585, 176)
        Me.grbVideoFromJPEGsorBitmaps.TabIndex = 62
        Me.grbVideoFromJPEGsorBitmaps.TabStop = False
        Me.grbVideoFromJPEGsorBitmaps.Text = "Video from JPEGs or Bitmaps"
        '
        'chkLoopIndefinitely
        '
#If Not VS2003 Then
        Me.chkLoopIndefinitely.AutoSize = True
#End If
        Me.chkLoopIndefinitely.Checked = True
        Me.chkLoopIndefinitely.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLoopIndefinitely.Enabled = False
        Me.chkLoopIndefinitely.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLoopIndefinitely.Location = New System.Drawing.Point(222, 121)
        Me.chkLoopIndefinitely.Name = "chkLoopIndefinitely"
        Me.chkLoopIndefinitely.Size = New System.Drawing.Size(98, 17)
        Me.chkLoopIndefinitely.TabIndex = 72
        Me.chkLoopIndefinitely.Text = "loop indefinitely"
        '
        'btnBrowseFolders
        '
        Me.btnBrowseFolders.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseFolders.Location = New System.Drawing.Point(545, 141)
        Me.btnBrowseFolders.Name = "btnBrowseFolders"
        Me.btnBrowseFolders.Size = New System.Drawing.Size(27, 22)
        Me.btnBrowseFolders.TabIndex = 71
        Me.btnBrowseFolders.Text = "..."
        '
        'edtSourceFolder
        '
        Me.edtSourceFolder.Location = New System.Drawing.Point(222, 141)
        Me.edtSourceFolder.Name = "edtSourceFolder"
        Me.edtSourceFolder.Size = New System.Drawing.Size(327, 20)
        Me.edtSourceFolder.TabIndex = 70
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 13)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "source folder of the BMP or JPEG files:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(194, 59)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 68
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(138, 59)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 67
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(82, 59)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 66
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(26, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 65
        Me.PictureBox1.TabStop = False
        '
        'rbFromBMPorJPEGfiles
        '
        Me.rbFromBMPorJPEGfiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFromBMPorJPEGfiles.Location = New System.Drawing.Point(15, 121)
        Me.rbFromBMPorJPEGfiles.Name = "rbFromBMPorJPEGfiles"
        Me.rbFromBMPorJPEGfiles.Size = New System.Drawing.Size(152, 21)
        Me.rbFromBMPorJPEGfiles.TabIndex = 64
        Me.rbFromBMPorJPEGfiles.Text = "from BMP or JPEG files:"
        '
        'rbFromPictureBox
        '
        Me.rbFromPictureBox.Checked = True
        Me.rbFromPictureBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFromPictureBox.Location = New System.Drawing.Point(15, 35)
        Me.rbFromPictureBox.Name = "rbFromPictureBox"
        Me.rbFromPictureBox.Size = New System.Drawing.Size(192, 24)
        Me.rbFromPictureBox.TabIndex = 63
        Me.rbFromPictureBox.TabStop = True
        Me.rbFromPictureBox.Text = "from PictureBox images, e.g.:"
        '
        'lblFirstSelectJPEGsOrBitmaps
        '
        Me.lblFirstSelectJPEGsOrBitmaps.AutoSize = True
        Me.lblFirstSelectJPEGsOrBitmaps.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstSelectJPEGsOrBitmaps.ForeColor = System.Drawing.Color.Red
        Me.lblFirstSelectJPEGsOrBitmaps.Location = New System.Drawing.Point(8, 17)
        Me.lblFirstSelectJPEGsOrBitmaps.Name = "lblFirstSelectJPEGsOrBitmaps"
        Me.lblFirstSelectJPEGsOrBitmaps.Size = New System.Drawing.Size(565, 13)
        Me.lblFirstSelectJPEGsOrBitmaps.TabIndex = 62
        Me.lblFirstSelectJPEGsOrBitmaps.Text = "first select VideoSource = vs_JPEGsOrBitmaps in the Video Sources list of the  ""v" & _
            "ideo source"" tab"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(359, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Start / Stop Preview"
        '
        'VideoFromJPEGsorBitmaps
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1046, 297)
        Me.ControlBox = False
        Me.Controls.Add(Me.grbVideoFromJPEGsorBitmaps)
        Me.Controls.Add(Me.edtVideoFromJPEGsorBitmaps)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VideoFromJPEGsorBitmaps"
        Me.ShowInTaskbar = False
        Me.grbVideoFromJPEGsorBitmaps.ResumeLayout(False)
        Me.grbVideoFromJPEGsorBitmaps.PerformLayout()
#If Not VS2003 Then
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
#End If
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Sub RefreshControls()
        lblFirstSelectJPEGsOrBitmaps.Visible = (MainForm.DefInstance.VideoGrabber1.VideoSource <> VidGrab.TVideoSource.vs_JPEGsOrBitmaps)
    End Sub

    Private Sub VideoFromJPEGsorBitmaps_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Visible Then
            RefreshControls()
        End If
    End Sub

    Private Sub btnStartPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartPreview.Click

        Dim ImageFileFound As Boolean

        If MainForm.DefInstance.VideoGrabber1.VideoSource <> VidGrab.TVideoSource.vs_JPEGsOrBitmaps Then
            MessageBox.Show("Video Source must be set to ""Video From JPEGs Or Bitmaps""", _
                    "DataStead TVideoGrabber VB 6 OCX Demo", MessageBoxButtons.OK)
            MainForm.DefInstance.VideoGrabber1.VideoSource = VidGrab.TVideoSource.vs_JPEGsOrBitmaps
            AddLog(MainForm.DefInstance.mmoLog, "VideoSource set to ""vs_JPEGsOrBitmaps""")
            RefreshControls()
        End If

        MainForm.DefInstance.VideoFromImagesUsePictureBox = rbFromPictureBox.Checked

        If MainForm.DefInstance.VideoFromImagesUsePictureBox Then
            MainForm.DefInstance.VideoGrabber1.StartPreview()
        Else
            ImageFileFound = MainForm.DefInstance.VideoFromImages.ReinitFolder(edtSourceFolder.Text, "*.bmp", chkLoopIndefinitely.Checked)
            If Not ImageFileFound Then
                ImageFileFound = MainForm.DefInstance.VideoFromImages.ReinitFolder(edtSourceFolder.Text, "*.jpg", chkLoopIndefinitely.Checked)
            End If
            If ImageFileFound Then
                MainForm.DefInstance.VideoGrabber1.StartPreview()
            Else
                MessageBox.Show("no bitmap files found in the specified directory!" & vbCrLf & vbCrLf & _
                        "Capture a set of frames to BMP or JPEG files first, e.g. by using the frame grabber in burst mode.", _
                        "DataStead TVideoGrabber VB.NET OCX Demo", MessageBoxButtons.OK)
            End If
        End If
    End Sub

    Private Sub btnStopPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopPreview.Click
        MainForm.DefInstance.VideoGrabber1.Stop()
    End Sub

    
    Private Sub btnBrowseFolders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseFolders.Click
        Dim FolderBrowser As New FolderBrowserDialog
        FolderBrowser.ShowDialog()
        edtSourceFolder.Text = FolderBrowser.SelectedPath
    End Sub
    

    Private Sub rbFromPictureBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFromPictureBox.CheckedChanged
        chkLoopIndefinitely.Enabled = False
    End Sub

    Private Sub rbFromBMPorJPEGfiles_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFromBMPorJPEGfiles.CheckedChanged
        chkLoopIndefinitely.Enabled = True
    End Sub

End Class
