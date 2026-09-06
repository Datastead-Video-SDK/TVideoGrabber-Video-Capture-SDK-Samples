Option Strict Off
Option Explicit On
Friend Class VideoProcessing
    Inherits Form

#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents btnResetAll As System.Windows.Forms.Button
    Public WithEvents rdgVideoRotation As System.Windows.Forms.GroupBox
    Public WithEvents rdgDeinterlacing As System.Windows.Forms.GroupBox
    Public WithEvents chkFlipVertical As System.Windows.Forms.CheckBox
    Public WithEvents chkFlipHorizontal As System.Windows.Forms.CheckBox
    Public WithEvents chkGreyScale As System.Windows.Forms.CheckBox
    Public WithEvents chkInvertColors As System.Windows.Forms.CheckBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents grbSoftwareVideoProcessing As System.Windows.Forms.GroupBox
    Public WithEvents chkCroppingEnabled As System.Windows.Forms.CheckBox
    Public WithEvents chkCroppingOutbounds As System.Windows.Forms.CheckBox
    Public WithEvents edtCroppingWidth As System.Windows.Forms.TextBox
    Public WithEvents edtCroppingHeight As System.Windows.Forms.TextBox
    Public WithEvents btnCroppingZoomReset As System.Windows.Forms.Button
    Public WithEvents Label32 As System.Windows.Forms.Label
    Public WithEvents Label33 As System.Windows.Forms.Label
    Public WithEvents Label34 As System.Windows.Forms.Label
    Public WithEvents Label35 As System.Windows.Forms.Label
    Public WithEvents Label36 As System.Windows.Forms.Label
    Public WithEvents grbCropping As System.Windows.Forms.GroupBox
    Public WithEvents vmr9FixRange As System.Windows.Forms.CheckBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents grbVMR9Adjust As System.Windows.Forms.GroupBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents tbrBrightness As System.Windows.Forms.TrackBar
    Friend WithEvents tbrContrast As System.Windows.Forms.TrackBar
    Friend WithEvents tbrSaturation As System.Windows.Forms.TrackBar
    Friend WithEvents tbrHue As System.Windows.Forms.TrackBar
    Friend WithEvents trkCroppingX As System.Windows.Forms.TrackBar
    Friend WithEvents trkCroppingY As System.Windows.Forms.TrackBar
    Friend WithEvents trkCroppingZoom As System.Windows.Forms.TrackBar
    Friend WithEvents tbrVMR9Hue As System.Windows.Forms.TrackBar
    Friend WithEvents tbrVMR9Saturation As System.Windows.Forms.TrackBar
    Friend WithEvents tbrVMR9Contrast As System.Windows.Forms.TrackBar
    Friend WithEvents tbrVMR9Brightness As System.Windows.Forms.TrackBar
    Friend WithEvents updVideoPixelization As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents rdgVideoRotation9 As System.Windows.Forms.RadioButton
    Public WithEvents rdgVideoRotation8 As System.Windows.Forms.RadioButton
    Public WithEvents rdgVideoRotation7 As System.Windows.Forms.RadioButton
    Public WithEvents rdgVideoRotation6 As System.Windows.Forms.RadioButton
    Public WithEvents rdgVideoRotation5 As System.Windows.Forms.RadioButton
    Public WithEvents rdgVideoRotation4 As System.Windows.Forms.RadioButton
    Public WithEvents rdgVideoRotation0 As System.Windows.Forms.RadioButton
    Public WithEvents rdgVideoRotation2 As System.Windows.Forms.RadioButton
    Public WithEvents rdgVideoRotation1 As System.Windows.Forms.RadioButton
    Public WithEvents rdgVideoRotation3 As System.Windows.Forms.RadioButton
    Public WithEvents rdgDeinterlacingFullSize As System.Windows.Forms.RadioButton
    Public WithEvents rdgDeinterlacingHalfSize As System.Windows.Forms.RadioButton
    Friend WithEvents edtCustomRotationAngle As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents grbDetectVideoSignal As System.Windows.Forms.GroupBox
    Friend WithEvents rdgDetectVideoSignalDisabled As System.Windows.Forms.RadioButton
    Friend WithEvents rdgConnexantbluescreen As System.Windows.Forms.RadioButton
    Friend WithEvents rdgNoVideoSignal As System.Windows.Forms.RadioButton
    Friend WithEvents lblVMR9Available As System.Windows.Forms.Label
    Friend WithEvents lblSWVideoProcessingRequiresFrameGrabber As System.Windows.Forms.Label
    Public WithEvents rdgDeinterlacingDisabled As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grbSoftwareVideoProcessing = New System.Windows.Forms.GroupBox
        Me.lblSWVideoProcessingRequiresFrameGrabber = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.updVideoPixelization = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.tbrHue = New System.Windows.Forms.TrackBar
        Me.tbrSaturation = New System.Windows.Forms.TrackBar
        Me.tbrContrast = New System.Windows.Forms.TrackBar
        Me.tbrBrightness = New System.Windows.Forms.TrackBar
        Me.btnResetAll = New System.Windows.Forms.Button
        Me.rdgVideoRotation = New System.Windows.Forms.GroupBox
        Me.edtCustomRotationAngle = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.rdgVideoRotation9 = New System.Windows.Forms.RadioButton
        Me.rdgVideoRotation7 = New System.Windows.Forms.RadioButton
        Me.rdgVideoRotation6 = New System.Windows.Forms.RadioButton
        Me.rdgVideoRotation5 = New System.Windows.Forms.RadioButton
        Me.rdgVideoRotation4 = New System.Windows.Forms.RadioButton
        Me.rdgVideoRotation0 = New System.Windows.Forms.RadioButton
        Me.rdgVideoRotation2 = New System.Windows.Forms.RadioButton
        Me.rdgVideoRotation1 = New System.Windows.Forms.RadioButton
        Me.rdgVideoRotation3 = New System.Windows.Forms.RadioButton
        Me.rdgVideoRotation8 = New System.Windows.Forms.RadioButton
        Me.rdgDeinterlacing = New System.Windows.Forms.GroupBox
        Me.rdgDeinterlacingFullSize = New System.Windows.Forms.RadioButton
        Me.rdgDeinterlacingHalfSize = New System.Windows.Forms.RadioButton
        Me.rdgDeinterlacingDisabled = New System.Windows.Forms.RadioButton
        Me.chkFlipVertical = New System.Windows.Forms.CheckBox
        Me.chkFlipHorizontal = New System.Windows.Forms.CheckBox
        Me.chkInvertColors = New System.Windows.Forms.CheckBox
        Me.chkGreyScale = New System.Windows.Forms.CheckBox
        Me.grbCropping = New System.Windows.Forms.GroupBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.trkCroppingZoom = New System.Windows.Forms.TrackBar
        Me.trkCroppingY = New System.Windows.Forms.TrackBar
        Me.trkCroppingX = New System.Windows.Forms.TrackBar
        Me.chkCroppingEnabled = New System.Windows.Forms.CheckBox
        Me.chkCroppingOutbounds = New System.Windows.Forms.CheckBox
        Me.edtCroppingWidth = New System.Windows.Forms.TextBox
        Me.edtCroppingHeight = New System.Windows.Forms.TextBox
        Me.btnCroppingZoomReset = New System.Windows.Forms.Button
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.grbVMR9Adjust = New System.Windows.Forms.GroupBox
        Me.lblVMR9Available = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.tbrVMR9Hue = New System.Windows.Forms.TrackBar
        Me.tbrVMR9Saturation = New System.Windows.Forms.TrackBar
        Me.tbrVMR9Contrast = New System.Windows.Forms.TrackBar
        Me.tbrVMR9Brightness = New System.Windows.Forms.TrackBar
        Me.vmr9FixRange = New System.Windows.Forms.CheckBox
        Me.grbDetectVideoSignal = New System.Windows.Forms.GroupBox
        Me.rdgConnexantbluescreen = New System.Windows.Forms.RadioButton
        Me.rdgNoVideoSignal = New System.Windows.Forms.RadioButton
        Me.rdgDetectVideoSignalDisabled = New System.Windows.Forms.RadioButton
        Me.grbSoftwareVideoProcessing.SuspendLayout()
        CType(Me.updVideoPixelization, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrHue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrSaturation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrContrast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrBrightness, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rdgVideoRotation.SuspendLayout()
        Me.rdgDeinterlacing.SuspendLayout()
        Me.grbCropping.SuspendLayout()
        CType(Me.trkCroppingZoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkCroppingY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkCroppingX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbVMR9Adjust.SuspendLayout()
        CType(Me.tbrVMR9Hue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrVMR9Saturation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrVMR9Contrast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrVMR9Brightness, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDetectVideoSignal.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbSoftwareVideoProcessing
        '
        Me.grbSoftwareVideoProcessing.BackColor = System.Drawing.SystemColors.Control
        Me.grbSoftwareVideoProcessing.Controls.Add(Me.lblSWVideoProcessingRequiresFrameGrabber)
        Me.grbSoftwareVideoProcessing.Controls.Add(Me.Label1)
        Me.grbSoftwareVideoProcessing.Controls.Add(Me.updVideoPixelization)
        Me.grbSoftwareVideoProcessing.Controls.Add(Me.Label3)
        Me.grbSoftwareVideoProcessing.Controls.Add(Me.tbrHue)
        Me.grbSoftwareVideoProcessing.Controls.Add(Me.tbrSaturation)
        Me.grbSoftwareVideoProcessing.Controls.Add(Me.tbrContrast)
        Me.grbSoftwareVideoProcessing.Controls.Add(Me.tbrBrightness)
        Me.grbSoftwareVideoProcessing.Controls.Add(Me.btnResetAll)
        Me.grbSoftwareVideoProcessing.Controls.Add(Me.rdgVideoRotation)
        Me.grbSoftwareVideoProcessing.Controls.Add(Me.rdgDeinterlacing)
        Me.grbSoftwareVideoProcessing.Controls.Add(Me.chkFlipVertical)
        Me.grbSoftwareVideoProcessing.Controls.Add(Me.chkFlipHorizontal)
        Me.grbSoftwareVideoProcessing.Controls.Add(Me.chkInvertColors)
        Me.grbSoftwareVideoProcessing.Controls.Add(Me.chkGreyScale)
        Me.grbSoftwareVideoProcessing.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbSoftwareVideoProcessing.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbSoftwareVideoProcessing.Location = New System.Drawing.Point(5, 0)
        Me.grbSoftwareVideoProcessing.Name = "grbSoftwareVideoProcessing"
        Me.grbSoftwareVideoProcessing.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbSoftwareVideoProcessing.Size = New System.Drawing.Size(567, 218)
        Me.grbSoftwareVideoProcessing.TabIndex = 21
        Me.grbSoftwareVideoProcessing.TabStop = False
        Me.grbSoftwareVideoProcessing.Text = "Software video processing"
        '
        'lblSWVideoProcessingRequiresFrameGrabber
        '
        Me.lblSWVideoProcessingRequiresFrameGrabber.AutoSize = True
        Me.lblSWVideoProcessingRequiresFrameGrabber.ForeColor = System.Drawing.Color.Red
        Me.lblSWVideoProcessingRequiresFrameGrabber.Location = New System.Drawing.Point(206, 0)
        Me.lblSWVideoProcessingRequiresFrameGrabber.Name = "lblSWVideoProcessingRequiresFrameGrabber"
        Me.lblSWVideoProcessingRequiresFrameGrabber.Size = New System.Drawing.Size(231, 16)
        Me.lblSWVideoProcessingRequiresFrameGrabber.TabIndex = 47
        Me.lblSWVideoProcessingRequiresFrameGrabber.Text = "the frame grabber must be enabled"
        Me.lblSWVideoProcessingRequiresFrameGrabber.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(408, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(158, 16)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "bright  contr. satur.  hue"
        '
        'updVideoPixelization
        '
        Me.updVideoPixelization.Location = New System.Drawing.Point(353, 161)
        Me.updVideoPixelization.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.updVideoPixelization.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.updVideoPixelization.Name = "updVideoPixelization"
        Me.updVideoPixelization.Size = New System.Drawing.Size(48, 23)
        Me.updVideoPixelization.TabIndex = 45
        Me.updVideoPixelization.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(275, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "pixellization:"
        '
        'tbrHue
        '
        Me.tbrHue.AutoSize = False
        Me.tbrHue.Location = New System.Drawing.Point(533, 21)
        Me.tbrHue.Maximum = 180
        Me.tbrHue.Minimum = -180
        Me.tbrHue.Name = "tbrHue"
        Me.tbrHue.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbrHue.Size = New System.Drawing.Size(21, 165)
        Me.tbrHue.TabIndex = 44
        Me.tbrHue.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'tbrSaturation
        '
        Me.tbrSaturation.AutoSize = False
        Me.tbrSaturation.Location = New System.Drawing.Point(497, 22)
        Me.tbrSaturation.Maximum = 64
        Me.tbrSaturation.Minimum = -64
        Me.tbrSaturation.Name = "tbrSaturation"
        Me.tbrSaturation.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbrSaturation.Size = New System.Drawing.Size(21, 164)
        Me.tbrSaturation.TabIndex = 43
        Me.tbrSaturation.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'tbrContrast
        '
        Me.tbrContrast.AutoSize = False
        Me.tbrContrast.Location = New System.Drawing.Point(461, 22)
        Me.tbrContrast.Maximum = 128
        Me.tbrContrast.Minimum = -128
        Me.tbrContrast.Name = "tbrContrast"
        Me.tbrContrast.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbrContrast.Size = New System.Drawing.Size(21, 164)
        Me.tbrContrast.TabIndex = 42
        Me.tbrContrast.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'tbrBrightness
        '
        Me.tbrBrightness.AutoSize = False
        Me.tbrBrightness.Location = New System.Drawing.Point(425, 22)
        Me.tbrBrightness.Maximum = 128
        Me.tbrBrightness.Minimum = -128
        Me.tbrBrightness.Name = "tbrBrightness"
        Me.tbrBrightness.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbrBrightness.Size = New System.Drawing.Size(21, 164)
        Me.tbrBrightness.TabIndex = 41
        Me.tbrBrightness.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'btnResetAll
        '
        Me.btnResetAll.BackColor = System.Drawing.SystemColors.Control
        Me.btnResetAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnResetAll.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnResetAll.Location = New System.Drawing.Point(20, 26)
        Me.btnResetAll.Name = "btnResetAll"
        Me.btnResetAll.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnResetAll.Size = New System.Drawing.Size(132, 26)
        Me.btnResetAll.TabIndex = 39
        Me.btnResetAll.Text = "reset all"
        Me.btnResetAll.UseVisualStyleBackColor = False
        '
        'rdgVideoRotation
        '
        Me.rdgVideoRotation.BackColor = System.Drawing.SystemColors.Control
        Me.rdgVideoRotation.Controls.Add(Me.edtCustomRotationAngle)
        Me.rdgVideoRotation.Controls.Add(Me.Label4)
        Me.rdgVideoRotation.Controls.Add(Me.rdgVideoRotation9)
        Me.rdgVideoRotation.Controls.Add(Me.rdgVideoRotation7)
        Me.rdgVideoRotation.Controls.Add(Me.rdgVideoRotation6)
        Me.rdgVideoRotation.Controls.Add(Me.rdgVideoRotation5)
        Me.rdgVideoRotation.Controls.Add(Me.rdgVideoRotation4)
        Me.rdgVideoRotation.Controls.Add(Me.rdgVideoRotation0)
        Me.rdgVideoRotation.Controls.Add(Me.rdgVideoRotation2)
        Me.rdgVideoRotation.Controls.Add(Me.rdgVideoRotation1)
        Me.rdgVideoRotation.Controls.Add(Me.rdgVideoRotation3)
        Me.rdgVideoRotation.Controls.Add(Me.rdgVideoRotation8)
        Me.rdgVideoRotation.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgVideoRotation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgVideoRotation.Location = New System.Drawing.Point(10, 59)
        Me.rdgVideoRotation.Name = "rdgVideoRotation"
        Me.rdgVideoRotation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgVideoRotation.Size = New System.Drawing.Size(258, 151)
        Me.rdgVideoRotation.TabIndex = 30
        Me.rdgVideoRotation.TabStop = False
        Me.rdgVideoRotation.Text = "Video rotation (in degrees)"
        '
        'edtCustomRotationAngle
        '
        Me.edtCustomRotationAngle.Location = New System.Drawing.Point(200, 118)
        Me.edtCustomRotationAngle.Name = "edtCustomRotationAngle"
        Me.edtCustomRotationAngle.Size = New System.Drawing.Size(48, 23)
        Me.edtCustomRotationAngle.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(212, 16)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "custom rotation angle (<= 360°):"
        '
        'rdgVideoRotation9
        '
        Me.rdgVideoRotation9.BackColor = System.Drawing.SystemColors.Control
        Me.rdgVideoRotation9.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgVideoRotation9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgVideoRotation9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgVideoRotation9.Location = New System.Drawing.Point(114, 94)
        Me.rdgVideoRotation9.Name = "rdgVideoRotation9"
        Me.rdgVideoRotation9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgVideoRotation9.Size = New System.Drawing.Size(134, 20)
        Me.rdgVideoRotation9.TabIndex = 40
        Me.rdgVideoRotation9.TabStop = True
        Me.rdgVideoRotation9.Tag = "9"
        Me.rdgVideoRotation9.Text = "custom ° mirror"
        Me.rdgVideoRotation9.UseVisualStyleBackColor = False
        '
        'rdgVideoRotation7
        '
        Me.rdgVideoRotation7.BackColor = System.Drawing.SystemColors.Control
        Me.rdgVideoRotation7.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgVideoRotation7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgVideoRotation7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgVideoRotation7.Location = New System.Drawing.Point(114, 74)
        Me.rdgVideoRotation7.Name = "rdgVideoRotation7"
        Me.rdgVideoRotation7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgVideoRotation7.Size = New System.Drawing.Size(97, 21)
        Me.rdgVideoRotation7.TabIndex = 38
        Me.rdgVideoRotation7.TabStop = True
        Me.rdgVideoRotation7.Tag = "7"
        Me.rdgVideoRotation7.Text = "270° mirror"
        Me.rdgVideoRotation7.UseVisualStyleBackColor = False
        '
        'rdgVideoRotation6
        '
        Me.rdgVideoRotation6.BackColor = System.Drawing.SystemColors.Control
        Me.rdgVideoRotation6.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgVideoRotation6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgVideoRotation6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgVideoRotation6.Location = New System.Drawing.Point(114, 54)
        Me.rdgVideoRotation6.Name = "rdgVideoRotation6"
        Me.rdgVideoRotation6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgVideoRotation6.Size = New System.Drawing.Size(97, 21)
        Me.rdgVideoRotation6.TabIndex = 37
        Me.rdgVideoRotation6.TabStop = True
        Me.rdgVideoRotation6.Tag = "6"
        Me.rdgVideoRotation6.Text = "180° mirror"
        Me.rdgVideoRotation6.UseVisualStyleBackColor = False
        '
        'rdgVideoRotation5
        '
        Me.rdgVideoRotation5.BackColor = System.Drawing.SystemColors.Control
        Me.rdgVideoRotation5.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgVideoRotation5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgVideoRotation5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgVideoRotation5.Location = New System.Drawing.Point(114, 34)
        Me.rdgVideoRotation5.Name = "rdgVideoRotation5"
        Me.rdgVideoRotation5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgVideoRotation5.Size = New System.Drawing.Size(96, 21)
        Me.rdgVideoRotation5.TabIndex = 36
        Me.rdgVideoRotation5.TabStop = True
        Me.rdgVideoRotation5.Tag = "5"
        Me.rdgVideoRotation5.Text = "90° mirror"
        Me.rdgVideoRotation5.UseVisualStyleBackColor = False
        '
        'rdgVideoRotation4
        '
        Me.rdgVideoRotation4.BackColor = System.Drawing.SystemColors.Control
        Me.rdgVideoRotation4.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgVideoRotation4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgVideoRotation4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgVideoRotation4.Location = New System.Drawing.Point(114, 15)
        Me.rdgVideoRotation4.Name = "rdgVideoRotation4"
        Me.rdgVideoRotation4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgVideoRotation4.Size = New System.Drawing.Size(97, 21)
        Me.rdgVideoRotation4.TabIndex = 35
        Me.rdgVideoRotation4.TabStop = True
        Me.rdgVideoRotation4.Tag = "4"
        Me.rdgVideoRotation4.Text = "0° mirror"
        Me.rdgVideoRotation4.UseVisualStyleBackColor = False
        '
        'rdgVideoRotation0
        '
        Me.rdgVideoRotation0.BackColor = System.Drawing.SystemColors.Control
        Me.rdgVideoRotation0.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgVideoRotation0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgVideoRotation0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgVideoRotation0.Location = New System.Drawing.Point(29, 15)
        Me.rdgVideoRotation0.Name = "rdgVideoRotation0"
        Me.rdgVideoRotation0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgVideoRotation0.Size = New System.Drawing.Size(49, 21)
        Me.rdgVideoRotation0.TabIndex = 34
        Me.rdgVideoRotation0.TabStop = True
        Me.rdgVideoRotation0.Tag = "0"
        Me.rdgVideoRotation0.Text = "0°"
        Me.rdgVideoRotation0.UseVisualStyleBackColor = False
        '
        'rdgVideoRotation2
        '
        Me.rdgVideoRotation2.BackColor = System.Drawing.SystemColors.Control
        Me.rdgVideoRotation2.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgVideoRotation2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgVideoRotation2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgVideoRotation2.Location = New System.Drawing.Point(29, 54)
        Me.rdgVideoRotation2.Name = "rdgVideoRotation2"
        Me.rdgVideoRotation2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgVideoRotation2.Size = New System.Drawing.Size(57, 21)
        Me.rdgVideoRotation2.TabIndex = 33
        Me.rdgVideoRotation2.TabStop = True
        Me.rdgVideoRotation2.Tag = "2"
        Me.rdgVideoRotation2.Text = "180°"
        Me.rdgVideoRotation2.UseVisualStyleBackColor = False
        '
        'rdgVideoRotation1
        '
        Me.rdgVideoRotation1.BackColor = System.Drawing.SystemColors.Control
        Me.rdgVideoRotation1.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgVideoRotation1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgVideoRotation1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgVideoRotation1.Location = New System.Drawing.Point(29, 34)
        Me.rdgVideoRotation1.Name = "rdgVideoRotation1"
        Me.rdgVideoRotation1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgVideoRotation1.Size = New System.Drawing.Size(49, 21)
        Me.rdgVideoRotation1.TabIndex = 32
        Me.rdgVideoRotation1.TabStop = True
        Me.rdgVideoRotation1.Tag = "1"
        Me.rdgVideoRotation1.Text = "90°"
        Me.rdgVideoRotation1.UseVisualStyleBackColor = False
        '
        'rdgVideoRotation3
        '
        Me.rdgVideoRotation3.BackColor = System.Drawing.SystemColors.Control
        Me.rdgVideoRotation3.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgVideoRotation3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgVideoRotation3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgVideoRotation3.Location = New System.Drawing.Point(29, 74)
        Me.rdgVideoRotation3.Name = "rdgVideoRotation3"
        Me.rdgVideoRotation3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgVideoRotation3.Size = New System.Drawing.Size(57, 21)
        Me.rdgVideoRotation3.TabIndex = 31
        Me.rdgVideoRotation3.TabStop = True
        Me.rdgVideoRotation3.Tag = "3"
        Me.rdgVideoRotation3.Text = "270°"
        Me.rdgVideoRotation3.UseVisualStyleBackColor = False
        '
        'rdgVideoRotation8
        '
        Me.rdgVideoRotation8.BackColor = System.Drawing.SystemColors.Control
        Me.rdgVideoRotation8.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgVideoRotation8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgVideoRotation8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgVideoRotation8.Location = New System.Drawing.Point(29, 94)
        Me.rdgVideoRotation8.Name = "rdgVideoRotation8"
        Me.rdgVideoRotation8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgVideoRotation8.Size = New System.Drawing.Size(115, 20)
        Me.rdgVideoRotation8.TabIndex = 39
        Me.rdgVideoRotation8.TabStop = True
        Me.rdgVideoRotation8.Tag = "8"
        Me.rdgVideoRotation8.Text = "custom °"
        Me.rdgVideoRotation8.UseVisualStyleBackColor = False
        '
        'rdgDeinterlacing
        '
        Me.rdgDeinterlacing.BackColor = System.Drawing.SystemColors.Control
        Me.rdgDeinterlacing.Controls.Add(Me.rdgDeinterlacingFullSize)
        Me.rdgDeinterlacing.Controls.Add(Me.rdgDeinterlacingHalfSize)
        Me.rdgDeinterlacing.Controls.Add(Me.rdgDeinterlacingDisabled)
        Me.rdgDeinterlacing.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgDeinterlacing.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgDeinterlacing.Location = New System.Drawing.Point(275, 59)
        Me.rdgDeinterlacing.Name = "rdgDeinterlacing"
        Me.rdgDeinterlacing.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgDeinterlacing.Size = New System.Drawing.Size(126, 89)
        Me.rdgDeinterlacing.TabIndex = 26
        Me.rdgDeinterlacing.TabStop = False
        Me.rdgDeinterlacing.Text = "deinterlacing"
        '
        'rdgDeinterlacingFullSize
        '
        Me.rdgDeinterlacingFullSize.BackColor = System.Drawing.SystemColors.Control
        Me.rdgDeinterlacingFullSize.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgDeinterlacingFullSize.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgDeinterlacingFullSize.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgDeinterlacingFullSize.Location = New System.Drawing.Point(19, 59)
        Me.rdgDeinterlacingFullSize.Name = "rdgDeinterlacingFullSize"
        Me.rdgDeinterlacingFullSize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgDeinterlacingFullSize.Size = New System.Drawing.Size(97, 22)
        Me.rdgDeinterlacingFullSize.TabIndex = 29
        Me.rdgDeinterlacingFullSize.TabStop = True
        Me.rdgDeinterlacingFullSize.Tag = "2"
        Me.rdgDeinterlacingFullSize.Text = "full size"
        Me.rdgDeinterlacingFullSize.UseVisualStyleBackColor = False
        '
        'rdgDeinterlacingHalfSize
        '
        Me.rdgDeinterlacingHalfSize.BackColor = System.Drawing.SystemColors.Control
        Me.rdgDeinterlacingHalfSize.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgDeinterlacingHalfSize.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgDeinterlacingHalfSize.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgDeinterlacingHalfSize.Location = New System.Drawing.Point(19, 39)
        Me.rdgDeinterlacingHalfSize.Name = "rdgDeinterlacingHalfSize"
        Me.rdgDeinterlacingHalfSize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgDeinterlacingHalfSize.Size = New System.Drawing.Size(97, 23)
        Me.rdgDeinterlacingHalfSize.TabIndex = 28
        Me.rdgDeinterlacingHalfSize.TabStop = True
        Me.rdgDeinterlacingHalfSize.Tag = "1"
        Me.rdgDeinterlacingHalfSize.Text = "half-size"
        Me.rdgDeinterlacingHalfSize.UseVisualStyleBackColor = False
        '
        'rdgDeinterlacingDisabled
        '
        Me.rdgDeinterlacingDisabled.BackColor = System.Drawing.SystemColors.Control
        Me.rdgDeinterlacingDisabled.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgDeinterlacingDisabled.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgDeinterlacingDisabled.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgDeinterlacingDisabled.Location = New System.Drawing.Point(19, 20)
        Me.rdgDeinterlacingDisabled.Name = "rdgDeinterlacingDisabled"
        Me.rdgDeinterlacingDisabled.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgDeinterlacingDisabled.Size = New System.Drawing.Size(97, 22)
        Me.rdgDeinterlacingDisabled.TabIndex = 27
        Me.rdgDeinterlacingDisabled.TabStop = True
        Me.rdgDeinterlacingDisabled.Tag = "0"
        Me.rdgDeinterlacingDisabled.Text = "disabled"
        Me.rdgDeinterlacingDisabled.UseVisualStyleBackColor = False
        '
        'chkFlipVertical
        '
        Me.chkFlipVertical.BackColor = System.Drawing.SystemColors.Control
        Me.chkFlipVertical.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkFlipVertical.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFlipVertical.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkFlipVertical.Location = New System.Drawing.Point(294, 20)
        Me.chkFlipVertical.Name = "chkFlipVertical"
        Me.chkFlipVertical.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkFlipVertical.Size = New System.Drawing.Size(97, 21)
        Me.chkFlipVertical.TabIndex = 25
        Me.chkFlipVertical.Text = "flip vertical"
        Me.chkFlipVertical.UseVisualStyleBackColor = False
        '
        'chkFlipHorizontal
        '
        Me.chkFlipHorizontal.BackColor = System.Drawing.SystemColors.Control
        Me.chkFlipHorizontal.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkFlipHorizontal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFlipHorizontal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkFlipHorizontal.Location = New System.Drawing.Point(294, 39)
        Me.chkFlipHorizontal.Name = "chkFlipHorizontal"
        Me.chkFlipHorizontal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkFlipHorizontal.Size = New System.Drawing.Size(107, 21)
        Me.chkFlipHorizontal.TabIndex = 24
        Me.chkFlipHorizontal.Text = "flip horizontal"
        Me.chkFlipHorizontal.UseVisualStyleBackColor = False
        '
        'chkInvertColors
        '
        Me.chkInvertColors.BackColor = System.Drawing.SystemColors.Control
        Me.chkInvertColors.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkInvertColors.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInvertColors.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkInvertColors.Location = New System.Drawing.Point(182, 39)
        Me.chkInvertColors.Name = "chkInvertColors"
        Me.chkInvertColors.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkInvertColors.Size = New System.Drawing.Size(117, 21)
        Me.chkInvertColors.TabIndex = 22
        Me.chkInvertColors.Text = "inverted colors"
        Me.chkInvertColors.UseVisualStyleBackColor = False
        '
        'chkGreyScale
        '
        Me.chkGreyScale.BackColor = System.Drawing.SystemColors.Control
        Me.chkGreyScale.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkGreyScale.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGreyScale.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkGreyScale.Location = New System.Drawing.Point(182, 20)
        Me.chkGreyScale.Name = "chkGreyScale"
        Me.chkGreyScale.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkGreyScale.Size = New System.Drawing.Size(116, 21)
        Me.chkGreyScale.TabIndex = 23
        Me.chkGreyScale.Text = "greyscale"
        Me.chkGreyScale.UseVisualStyleBackColor = False
        '
        'grbCropping
        '
        Me.grbCropping.BackColor = System.Drawing.SystemColors.Control
        Me.grbCropping.Controls.Add(Me.Label32)
        Me.grbCropping.Controls.Add(Me.trkCroppingZoom)
        Me.grbCropping.Controls.Add(Me.trkCroppingY)
        Me.grbCropping.Controls.Add(Me.trkCroppingX)
        Me.grbCropping.Controls.Add(Me.chkCroppingEnabled)
        Me.grbCropping.Controls.Add(Me.chkCroppingOutbounds)
        Me.grbCropping.Controls.Add(Me.edtCroppingWidth)
        Me.grbCropping.Controls.Add(Me.edtCroppingHeight)
        Me.grbCropping.Controls.Add(Me.btnCroppingZoomReset)
        Me.grbCropping.Controls.Add(Me.Label33)
        Me.grbCropping.Controls.Add(Me.Label34)
        Me.grbCropping.Controls.Add(Me.Label35)
        Me.grbCropping.Controls.Add(Me.Label36)
        Me.grbCropping.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbCropping.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbCropping.Location = New System.Drawing.Point(774, 1)
        Me.grbCropping.Name = "grbCropping"
        Me.grbCropping.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbCropping.Size = New System.Drawing.Size(311, 159)
        Me.grbCropping.TabIndex = 6
        Me.grbCropping.TabStop = False
        Me.grbCropping.Text = "Cropping"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.SystemColors.Control
        Me.Label32.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label32.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label32.Location = New System.Drawing.Point(103, 126)
        Me.Label32.Name = "Label32"
        Me.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label32.Size = New System.Drawing.Size(43, 16)
        Me.Label32.TabIndex = 19
        Me.Label32.Text = "X pos"
        '
        'trkCroppingZoom
        '
        Me.trkCroppingZoom.AutoSize = False
        Me.trkCroppingZoom.Location = New System.Drawing.Point(13, 90)
        Me.trkCroppingZoom.Maximum = 1000
        Me.trkCroppingZoom.Name = "trkCroppingZoom"
        Me.trkCroppingZoom.Size = New System.Drawing.Size(221, 24)
        Me.trkCroppingZoom.TabIndex = 47
        Me.trkCroppingZoom.TickFrequency = 50
        Me.trkCroppingZoom.Value = 100
        '
        'trkCroppingY
        '
        Me.trkCroppingY.AutoSize = False
        Me.trkCroppingY.Location = New System.Drawing.Point(275, 14)
        Me.trkCroppingY.Maximum = 30000
        Me.trkCroppingY.Name = "trkCroppingY"
        Me.trkCroppingY.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.trkCroppingY.Size = New System.Drawing.Size(24, 137)
        Me.trkCroppingY.TabIndex = 46
        Me.trkCroppingY.TickFrequency = 3000
        '
        'trkCroppingX
        '
        Me.trkCroppingX.AutoSize = False
        Me.trkCroppingX.Location = New System.Drawing.Point(142, 122)
        Me.trkCroppingX.Maximum = 30000
        Me.trkCroppingX.Name = "trkCroppingX"
        Me.trkCroppingX.Size = New System.Drawing.Size(126, 24)
        Me.trkCroppingX.TabIndex = 20
        Me.trkCroppingX.TickFrequency = 3000
        '
        'chkCroppingEnabled
        '
        Me.chkCroppingEnabled.BackColor = System.Drawing.SystemColors.Control
        Me.chkCroppingEnabled.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkCroppingEnabled.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCroppingEnabled.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkCroppingEnabled.Location = New System.Drawing.Point(13, 20)
        Me.chkCroppingEnabled.Name = "chkCroppingEnabled"
        Me.chkCroppingEnabled.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkCroppingEnabled.Size = New System.Drawing.Size(78, 21)
        Me.chkCroppingEnabled.TabIndex = 12
        Me.chkCroppingEnabled.Text = "enabled"
        Me.chkCroppingEnabled.UseVisualStyleBackColor = False
        '
        'chkCroppingOutbounds
        '
        Me.chkCroppingOutbounds.BackColor = System.Drawing.SystemColors.Control
        Me.chkCroppingOutbounds.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkCroppingOutbounds.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCroppingOutbounds.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkCroppingOutbounds.Location = New System.Drawing.Point(13, 46)
        Me.chkCroppingOutbounds.Name = "chkCroppingOutbounds"
        Me.chkCroppingOutbounds.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkCroppingOutbounds.Size = New System.Drawing.Size(96, 20)
        Me.chkCroppingOutbounds.TabIndex = 11
        Me.chkCroppingOutbounds.Text = "out bounds"
        Me.chkCroppingOutbounds.UseVisualStyleBackColor = False
        '
        'edtCroppingWidth
        '
        Me.edtCroppingWidth.AcceptsReturn = True
        Me.edtCroppingWidth.BackColor = System.Drawing.SystemColors.Window
        Me.edtCroppingWidth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtCroppingWidth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtCroppingWidth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtCroppingWidth.Location = New System.Drawing.Point(191, 16)
        Me.edtCroppingWidth.MaxLength = 0
        Me.edtCroppingWidth.Name = "edtCroppingWidth"
        Me.edtCroppingWidth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtCroppingWidth.Size = New System.Drawing.Size(59, 23)
        Me.edtCroppingWidth.TabIndex = 10
        '
        'edtCroppingHeight
        '
        Me.edtCroppingHeight.AcceptsReturn = True
        Me.edtCroppingHeight.BackColor = System.Drawing.SystemColors.Window
        Me.edtCroppingHeight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtCroppingHeight.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtCroppingHeight.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtCroppingHeight.Location = New System.Drawing.Point(191, 46)
        Me.edtCroppingHeight.MaxLength = 0
        Me.edtCroppingHeight.Name = "edtCroppingHeight"
        Me.edtCroppingHeight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtCroppingHeight.Size = New System.Drawing.Size(59, 23)
        Me.edtCroppingHeight.TabIndex = 9
        '
        'btnCroppingZoomReset
        '
        Me.btnCroppingZoomReset.BackColor = System.Drawing.SystemColors.Control
        Me.btnCroppingZoomReset.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCroppingZoomReset.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCroppingZoomReset.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCroppingZoomReset.Location = New System.Drawing.Point(13, 124)
        Me.btnCroppingZoomReset.Name = "btnCroppingZoomReset"
        Me.btnCroppingZoomReset.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCroppingZoomReset.Size = New System.Drawing.Size(78, 26)
        Me.btnCroppingZoomReset.TabIndex = 7
        Me.btnCroppingZoomReset.Text = "reset"
        Me.btnCroppingZoomReset.UseVisualStyleBackColor = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.SystemColors.Control
        Me.Label33.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label33.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label33.Location = New System.Drawing.Point(236, 76)
        Me.Label33.Name = "Label33"
        Me.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label33.Size = New System.Drawing.Size(44, 16)
        Me.Label33.TabIndex = 18
        Me.Label33.Text = "Y pos"
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.SystemColors.Control
        Me.Label34.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label34.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label34.Location = New System.Drawing.Point(10, 73)
        Me.Label34.Name = "Label34"
        Me.Label34.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label34.Size = New System.Drawing.Size(96, 21)
        Me.Label34.TabIndex = 17
        Me.Label34.Text = "cropping zoom"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.SystemColors.Control
        Me.Label35.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label35.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label35.Location = New System.Drawing.Point(116, 21)
        Me.Label35.Name = "Label35"
        Me.Label35.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label35.Size = New System.Drawing.Size(73, 16)
        Me.Label35.TabIndex = 16
        Me.Label35.Text = "area width"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.SystemColors.Control
        Me.Label36.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label36.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label36.Location = New System.Drawing.Point(116, 48)
        Me.Label36.Name = "Label36"
        Me.Label36.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label36.Size = New System.Drawing.Size(80, 16)
        Me.Label36.TabIndex = 15
        Me.Label36.Text = "area height"
        '
        'grbVMR9Adjust
        '
        Me.grbVMR9Adjust.BackColor = System.Drawing.SystemColors.Control
        Me.grbVMR9Adjust.Controls.Add(Me.lblVMR9Available)
        Me.grbVMR9Adjust.Controls.Add(Me.Label2)
        Me.grbVMR9Adjust.Controls.Add(Me.Label5)
        Me.grbVMR9Adjust.Controls.Add(Me.tbrVMR9Hue)
        Me.grbVMR9Adjust.Controls.Add(Me.tbrVMR9Saturation)
        Me.grbVMR9Adjust.Controls.Add(Me.tbrVMR9Contrast)
        Me.grbVMR9Adjust.Controls.Add(Me.tbrVMR9Brightness)
        Me.grbVMR9Adjust.Controls.Add(Me.vmr9FixRange)
        Me.grbVMR9Adjust.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbVMR9Adjust.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbVMR9Adjust.Location = New System.Drawing.Point(581, 0)
        Me.grbVMR9Adjust.Name = "grbVMR9Adjust"
        Me.grbVMR9Adjust.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbVMR9Adjust.Size = New System.Drawing.Size(183, 160)
        Me.grbVMR9Adjust.TabIndex = 0
        Me.grbVMR9Adjust.TabStop = False
        Me.grbVMR9Adjust.Text = "VMR9 image adjustment"
        '
        'lblVMR9Available
        '
        Me.lblVMR9Available.BackColor = System.Drawing.Color.Red
        Me.lblVMR9Available.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVMR9Available.Location = New System.Drawing.Point(20, 111)
        Me.lblVMR9Available.Name = "lblVMR9Available"
        Me.lblVMR9Available.Size = New System.Drawing.Size(12, 12)
        Me.lblVMR9Available.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(52, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(138, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "bright cont. sat.  hue"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 32)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "fix" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "range"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbrVMR9Hue
        '
        Me.tbrVMR9Hue.AutoSize = False
        Me.tbrVMR9Hue.Location = New System.Drawing.Point(155, 16)
        Me.tbrVMR9Hue.Maximum = 180
        Me.tbrVMR9Hue.Minimum = -180
        Me.tbrVMR9Hue.Name = "tbrVMR9Hue"
        Me.tbrVMR9Hue.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbrVMR9Hue.Size = New System.Drawing.Size(21, 124)
        Me.tbrVMR9Hue.TabIndex = 48
        Me.tbrVMR9Hue.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'tbrVMR9Saturation
        '
        Me.tbrVMR9Saturation.AutoSize = False
        Me.tbrVMR9Saturation.Location = New System.Drawing.Point(126, 16)
        Me.tbrVMR9Saturation.Maximum = 64
        Me.tbrVMR9Saturation.Minimum = -64
        Me.tbrVMR9Saturation.Name = "tbrVMR9Saturation"
        Me.tbrVMR9Saturation.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbrVMR9Saturation.Size = New System.Drawing.Size(22, 124)
        Me.tbrVMR9Saturation.TabIndex = 47
        Me.tbrVMR9Saturation.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'tbrVMR9Contrast
        '
        Me.tbrVMR9Contrast.AutoSize = False
        Me.tbrVMR9Contrast.Location = New System.Drawing.Point(97, 16)
        Me.tbrVMR9Contrast.Maximum = 128
        Me.tbrVMR9Contrast.Minimum = -128
        Me.tbrVMR9Contrast.Name = "tbrVMR9Contrast"
        Me.tbrVMR9Contrast.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbrVMR9Contrast.Size = New System.Drawing.Size(22, 124)
        Me.tbrVMR9Contrast.TabIndex = 46
        Me.tbrVMR9Contrast.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'tbrVMR9Brightness
        '
        Me.tbrVMR9Brightness.AutoSize = False
        Me.tbrVMR9Brightness.Location = New System.Drawing.Point(68, 16)
        Me.tbrVMR9Brightness.Maximum = 128
        Me.tbrVMR9Brightness.Minimum = -128
        Me.tbrVMR9Brightness.Name = "tbrVMR9Brightness"
        Me.tbrVMR9Brightness.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbrVMR9Brightness.Size = New System.Drawing.Size(22, 124)
        Me.tbrVMR9Brightness.TabIndex = 45
        Me.tbrVMR9Brightness.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'vmr9FixRange
        '
        Me.vmr9FixRange.BackColor = System.Drawing.SystemColors.Control
        Me.vmr9FixRange.Checked = True
        Me.vmr9FixRange.CheckState = System.Windows.Forms.CheckState.Checked
        Me.vmr9FixRange.Cursor = System.Windows.Forms.Cursors.Default
        Me.vmr9FixRange.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vmr9FixRange.ForeColor = System.Drawing.SystemColors.ControlText
        Me.vmr9FixRange.Location = New System.Drawing.Point(18, 26)
        Me.vmr9FixRange.Name = "vmr9FixRange"
        Me.vmr9FixRange.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.vmr9FixRange.Size = New System.Drawing.Size(24, 26)
        Me.vmr9FixRange.TabIndex = 1
        Me.vmr9FixRange.UseVisualStyleBackColor = False
        '
        'grbDetectVideoSignal
        '
        Me.grbDetectVideoSignal.Controls.Add(Me.rdgConnexantbluescreen)
        Me.grbDetectVideoSignal.Controls.Add(Me.rdgNoVideoSignal)
        Me.grbDetectVideoSignal.Controls.Add(Me.rdgDetectVideoSignalDisabled)
        Me.grbDetectVideoSignal.Location = New System.Drawing.Point(581, 161)
        Me.grbDetectVideoSignal.Name = "grbDetectVideoSignal"
        Me.grbDetectVideoSignal.Size = New System.Drawing.Size(504, 57)
        Me.grbDetectVideoSignal.TabIndex = 22
        Me.grbDetectVideoSignal.TabStop = False
        Me.grbDetectVideoSignal.Text = "Detect video signal (adjustable)"
        '
        'rdgConnexantbluescreen
        '
        Me.rdgConnexantbluescreen.AutoSize = True
        Me.rdgConnexantbluescreen.Location = New System.Drawing.Point(335, 25)
        Me.rdgConnexantbluescreen.Name = "rdgConnexantbluescreen"
        Me.rdgConnexantbluescreen.Size = New System.Drawing.Size(167, 20)
        Me.rdgConnexantbluescreen.TabIndex = 2
        Me.rdgConnexantbluescreen.Text = "Conexant blue screen"
        '
        'rdgNoVideoSignal
        '
        Me.rdgNoVideoSignal.AutoSize = True
        Me.rdgNoVideoSignal.Location = New System.Drawing.Point(138, 25)
        Me.rdgNoVideoSignal.Name = "rdgNoVideoSignal"
        Me.rdgNoVideoSignal.Size = New System.Drawing.Size(175, 20)
        Me.rdgNoVideoSignal.TabIndex = 1
        Me.rdgNoVideoSignal.Text = "no signal (dark screen)"
        '
        'rdgDetectVideoSignalDisabled
        '
        Me.rdgDetectVideoSignalDisabled.AutoSize = True
        Me.rdgDetectVideoSignalDisabled.Checked = True
        Me.rdgDetectVideoSignalDisabled.Location = New System.Drawing.Point(30, 25)
        Me.rdgDetectVideoSignalDisabled.Name = "rdgDetectVideoSignalDisabled"
        Me.rdgDetectVideoSignalDisabled.Size = New System.Drawing.Size(82, 20)
        Me.rdgDetectVideoSignalDisabled.TabIndex = 0
        Me.rdgDetectVideoSignalDisabled.TabStop = True
        Me.rdgDetectVideoSignalDisabled.Text = "disabled"
        '
        'VideoProcessing
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.ClientSize = New System.Drawing.Size(1093, 223)
        Me.ControlBox = False
        Me.Controls.Add(Me.grbDetectVideoSignal)
        Me.Controls.Add(Me.grbSoftwareVideoProcessing)
        Me.Controls.Add(Me.grbCropping)
        Me.Controls.Add(Me.grbVMR9Adjust)
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VideoProcessing"
        Me.ShowInTaskbar = False
        Me.grbSoftwareVideoProcessing.ResumeLayout(False)
        Me.grbSoftwareVideoProcessing.PerformLayout()
        CType(Me.updVideoPixelization, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrHue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrSaturation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrContrast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrBrightness, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rdgVideoRotation.ResumeLayout(False)
        Me.rdgVideoRotation.PerformLayout()
        Me.rdgDeinterlacing.ResumeLayout(False)
        Me.grbCropping.ResumeLayout(False)
        Me.grbCropping.PerformLayout()
        CType(Me.trkCroppingZoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkCroppingY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkCroppingX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbVMR9Adjust.ResumeLayout(False)
        Me.grbVMR9Adjust.PerformLayout()
        CType(Me.tbrVMR9Hue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrVMR9Saturation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrVMR9Contrast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrVMR9Brightness, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDetectVideoSignal.ResumeLayout(False)
        Me.grbDetectVideoSignal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
#End Region

    Public Sub RefreshControls()
        SetRadioButtonInGroupUsingTag((rdgVideoRotation), MainForm.DefInstance.VideoGrabber1.VideoProcessing_Rotation)
        edtCustomRotationAngle.Text = MainForm.DefInstance.VideoGrabber1.VideoProcessing_RotationCustomAngle

        SetRadioButtonInGroupUsingTag((rdgDeinterlacing), MainForm.DefInstance.VideoGrabber1.VideoProcessing_Deinterlacing)

        updVideoPixelization.Value = MainForm.DefInstance.VideoGrabber1.VideoProcessing_Pixellization()

        tbrBrightness.Value = MainForm.DefInstance.VideoGrabber1.VideoProcessing_Brightness
        tbrContrast.Value = MainForm.DefInstance.VideoGrabber1.VideoProcessing_Contrast
        tbrSaturation.Value = MainForm.DefInstance.VideoGrabber1.VideoProcessing_Saturation
        tbrHue.Value = MainForm.DefInstance.VideoGrabber1.VideoProcessing_Hue

        chkGreyScale.Checked = MainForm.DefInstance.VideoGrabber1.VideoProcessing_GrayScale
        chkInvertColors.Checked = MainForm.DefInstance.VideoGrabber1.VideoProcessing_InvertColors
        chkFlipVertical.Checked = MainForm.DefInstance.VideoGrabber1.VideoProcessing_FlipVertical
        chkFlipHorizontal.Checked = MainForm.DefInstance.VideoGrabber1.VideoProcessing_FlipHorizontal

        chkCroppingEnabled.Checked = MainForm.DefInstance.VideoGrabber1.Cropping_Enabled
        chkCroppingOutbounds.Checked = MainForm.DefInstance.VideoGrabber1.Cropping_Outbounds
        edtCroppingWidth.Text = MainForm.DefInstance.VideoGrabber1.Cropping_Width
        edtCroppingHeight.Text = MainForm.DefInstance.VideoGrabber1.Cropping_Height
        trkCroppingZoom.Value = MainForm.DefInstance.VideoGrabber1.Cropping_Zoom * 100

        ' trkCroppingX.Max and trkCroppingY.Max are will be set from the OnResizeVideo event
        trkCroppingY.Value = MainForm.DefInstance.VideoGrabber1.Cropping_Y
        trkCroppingX.Value = MainForm.DefInstance.VideoGrabber1.Cropping_X

        lblSWVideoProcessingRequiresFrameGrabber.Visible = IIf(MainForm.DefInstance.VideoGrabber1.FrameGrabber = VidGrab.TFrameGrabber.fg_Disabled, True, False)

        RefreshVMR9Processing()

    End Sub

    Public Sub RefreshVMR9Processing()
        Dim MinValue As Long, MaxValue As Long, StepSize As Long, DefaultValue As Long, CurrentValue As Long

        lblVMR9Available.BackColor = Color.Red
        If MainForm.DefInstance.VideoGrabber1.IsVMR9ImageAdjustmentAvailable(True) Then
            With tbrVMR9Brightness
                .Enabled = MainForm.DefInstance.VideoGrabber1.GetVMR9ImageAdjustmentBounds(True, VidGrab.TVMR9ImageAdjustment.vmr9_Brightness, MinValue, MaxValue, StepSize, DefaultValue, CurrentValue)
                If .Enabled Then
                    .Minimum = MinValue
                    .Maximum = MaxValue
                    .SmallChange = StepSize
                    .LargeChange = StepSize
                    .Value = CurrentValue
                    lblVMR9Available.BackColor = Color.Green
                Else
                    .Value = .Minimum + ((.Maximum - .Minimum) / 2)
                End If
            End With
            With tbrVMR9Contrast
                .Enabled = MainForm.DefInstance.VideoGrabber1.GetVMR9ImageAdjustmentBounds(True, VidGrab.TVMR9ImageAdjustment.vmr9_Contrast, MinValue, MaxValue, StepSize, DefaultValue, CurrentValue)
                If .Enabled Then
                    .Minimum = MinValue
                    .Maximum = MaxValue
                    .SmallChange = StepSize
                    .LargeChange = StepSize
                    .Value = CurrentValue
                    lblVMR9Available.BackColor = Color.Green
                Else
                    .Value = .Minimum + ((.Maximum - .Minimum) / 2)
                End If
            End With
            With tbrVMR9Hue
                .Enabled = MainForm.DefInstance.VideoGrabber1.GetVMR9ImageAdjustmentBounds(True, VidGrab.TVMR9ImageAdjustment.vmr9_Hue, MinValue, MaxValue, StepSize, DefaultValue, CurrentValue)
                If .Enabled Then
                    .Minimum = MinValue
                    .Maximum = MaxValue
                    .SmallChange = StepSize
                    .LargeChange = StepSize
                    .Value = CurrentValue
                    lblVMR9Available.BackColor = Color.Green
                Else
                    .Value = .Minimum + ((.Maximum - .Minimum) / 2)
                End If
            End With
            With tbrVMR9Saturation
                .Enabled = MainForm.DefInstance.VideoGrabber1.GetVMR9ImageAdjustmentBounds(True, VidGrab.TVMR9ImageAdjustment.vmr9_Saturation, MinValue, MaxValue, StepSize, DefaultValue, CurrentValue)
                If .Enabled Then
                    .Minimum = MinValue
                    .Maximum = MaxValue
                    .SmallChange = StepSize
                    .LargeChange = StepSize
                    .Value = CurrentValue
                    lblVMR9Available.BackColor = Color.Green
                Else
                    .Value = .Minimum + ((.Maximum - .Minimum) / 2)
                End If
            End With
        Else
            tbrVMR9Brightness.Enabled = False
            tbrVMR9Contrast.Enabled = False
            tbrVMR9Hue.Enabled = False
            tbrVMR9Saturation.Enabled = False
        End If

    End Sub

    Private Sub btnCroppingZoomReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCroppingZoomReset.Click
        trkCroppingZoom.Value = 100
        MainForm.DefInstance.VideoGrabber1.Cropping_Zoom = trkCroppingZoom.Value / 100
    End Sub

    Private Sub btnResetAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetAll.Click
        rdgVideoRotation0.Checked = True
        rdgDeinterlacingDisabled.Checked = True
        tbrBrightness.Value = 0
        MainForm.DefInstance.VideoGrabber1.VideoProcessing_Brightness = -tbrBrightness.Value
        tbrContrast.Value = 0
        MainForm.DefInstance.VideoGrabber1.VideoProcessing_Contrast = -tbrContrast.Value
        tbrSaturation.Value = 0
        MainForm.DefInstance.VideoGrabber1.VideoProcessing_Saturation = -tbrSaturation.Value
        tbrHue.Value = 0
        MainForm.DefInstance.VideoGrabber1.VideoProcessing_Hue = -tbrHue.Value
        chkGreyScale.Checked = System.Windows.Forms.CheckState.Unchecked
        chkInvertColors.Checked = System.Windows.Forms.CheckState.Unchecked
        chkFlipVertical.Checked = System.Windows.Forms.CheckState.Unchecked
        chkFlipHorizontal.Checked = System.Windows.Forms.CheckState.Unchecked
    End Sub

    Private Sub chkCroppingEnabled_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCroppingEnabled.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.Cropping_Enabled = chkCroppingEnabled.Checked
    End Sub

    Private Sub chkCroppingOutbounds_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCroppingOutbounds.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.Cropping_Outbounds = chkCroppingOutbounds.Checked
    End Sub

    Private Sub chkFlipHorizontal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFlipHorizontal.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.VideoProcessing_FlipHorizontal = chkFlipHorizontal.Checked
    End Sub

    Private Sub chkFlipVertical_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFlipVertical.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.VideoProcessing_FlipVertical = chkFlipVertical.Checked
    End Sub

    Private Sub chkGreyScale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGreyScale.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.VideoProcessing_GrayScale = chkGreyScale.Checked
    End Sub

    Private Sub chkInvertColors_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkInvertColors.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.VideoProcessing_InvertColors = chkInvertColors.Checked
    End Sub

    Private Sub edtCroppingHeight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtCroppingHeight.TextChanged
        If IsNumeric(edtCroppingHeight.Text) Then
            MainForm.DefInstance.VideoGrabber1.Cropping_Height = edtCroppingHeight.Text
        End If
    End Sub

    Private Sub edtCroppingWidth_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtCroppingWidth.TextChanged
        If IsNumeric(edtCroppingWidth.Text) Then
            MainForm.DefInstance.VideoGrabber1.Cropping_Width = edtCroppingWidth.Text
        End If
    End Sub

    Private Sub rdgDeinterlacing_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgDeinterlacingDisabled.CheckedChanged, rdgDeinterlacingHalfSize.CheckedChanged, rdgDeinterlacingFullSize.CheckedChanged
        If CType(sender, RadioButton).Checked Then
            MainForm.DefInstance.VideoGrabber1.VideoProcessing_Deinterlacing = sender.Tag
        End If
    End Sub

    Private Sub rdgVideoRotation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgVideoRotation0.CheckedChanged, rdgVideoRotation1.CheckedChanged, rdgVideoRotation2.CheckedChanged, rdgVideoRotation3.CheckedChanged, rdgVideoRotation4.CheckedChanged, rdgVideoRotation5.CheckedChanged, rdgVideoRotation6.CheckedChanged, rdgVideoRotation7.CheckedChanged, rdgVideoRotation8.CheckedChanged, rdgVideoRotation9.CheckedChanged
        If CType(sender, RadioButton).Checked Then
            MainForm.DefInstance.VideoGrabber1.VideoProcessing_Rotation = sender.Tag
        End If
    End Sub

    Private Sub trkCroppingX_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkCroppingX.Scroll
        ' trkCroppingX.Max and trkCroppingY.Max are set from the OnResizeVideo event
        MainForm.DefInstance.VideoGrabber1.Cropping_X = trkCroppingX.Value
    End Sub

    Private Sub trkCroppingY_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkCroppingY.Scroll
        ' trkCroppingX.Max and trkCroppingY.Max are set from the OnResizeVideo event
        MainForm.DefInstance.VideoGrabber1.Cropping_Y = trkCroppingY.Value
    End Sub

    Private Sub trkCroppingZoom_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trkCroppingZoom.Scroll
        MainForm.DefInstance.VideoGrabber1.Cropping_Zoom = trkCroppingZoom.Value / 100
    End Sub

    Private Sub edtCustomRotationAngle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtCustomRotationAngle.TextChanged
        If IsNumeric(edtCustomRotationAngle.Text) Then
            MainForm.DefInstance.VideoGrabber1.VideoProcessing_RotationCustomAngle = edtCustomRotationAngle.Text
        End If
    End Sub

    Private Sub VideoProcessing_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Visible Then
            RefreshControls()
        End If
    End Sub

    Private Sub rdgDetectVideoSignalDisabled_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgDetectVideoSignalDisabled.CheckedChanged
        MainForm.DefInstance.VideoProcessing_DetectNoVideoSignal = False
        MainForm.DefInstance.VideoProcessing_DetectConnexantBlueScreen = False
    End Sub

    Private Sub rdgNoVideoSignal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgNoVideoSignal.CheckedChanged
        MainForm.DefInstance.VideoProcessing_DetectNoVideoSignal = True
        MainForm.DefInstance.VideoProcessing_DetectConnexantBlueScreen = False
    End Sub

    Private Sub rdgConnexantbluescreen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgConnexantbluescreen.CheckedChanged
        MainForm.DefInstance.VideoProcessing_DetectConnexantBlueScreen = True
        MainForm.DefInstance.VideoProcessing_DetectNoVideoSignal = False
    End Sub

    Private Sub vmr9FixRange_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vmr9FixRange.CheckedChanged
        ' fixes a possible problem of constrast and saturation range with some video decoders, passed to the SetVMR9ImageAdjustmentValue function below
    End Sub

    Private Sub tbrBrightness_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrBrightness.Scroll
        MainForm.DefInstance.VideoGrabber1.VideoProcessing_Brightness = -tbrBrightness.Value
    End Sub

    Private Sub tbrContrast_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrContrast.Scroll
        MainForm.DefInstance.VideoGrabber1.VideoProcessing_Contrast = -tbrContrast.Value
    End Sub

    Private Sub tbrSaturation_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrSaturation.Scroll
        MainForm.DefInstance.VideoGrabber1.VideoProcessing_Saturation = -tbrSaturation.Value
    End Sub

    Private Sub tbrHue_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrHue.Scroll
        MainForm.DefInstance.VideoGrabber1.VideoProcessing_Hue = -tbrHue.Value
    End Sub

    Private Sub tbrVMR9Brightness_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrVMR9Brightness.Scroll
        MainForm.DefInstance.VideoGrabber1.SetVMR9ImageAdjustmentValue(True, VidGrab.TVMR9ImageAdjustment.vmr9_Brightness, tbrVMR9Brightness.Value, False)
    End Sub

    Private Sub tbrVMR9Contrast_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrVMR9Contrast.Scroll
        MainForm.DefInstance.VideoGrabber1.SetVMR9ImageAdjustmentValue(True, VidGrab.TVMR9ImageAdjustment.vmr9_Contrast, tbrVMR9Contrast.Value, vmr9FixRange.Checked)
    End Sub

    Private Sub tbrVMR9Saturation_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrVMR9Saturation.Scroll
        MainForm.DefInstance.VideoGrabber1.SetVMR9ImageAdjustmentValue(True, VidGrab.TVMR9ImageAdjustment.vmr9_Saturation, tbrVMR9Saturation.Value, vmr9FixRange.Checked)
    End Sub

    Private Sub tbrVMR9Hue_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrVMR9Hue.Scroll
        MainForm.DefInstance.VideoGrabber1.SetVMR9ImageAdjustmentValue(True, VidGrab.TVMR9ImageAdjustment.vmr9_Hue, tbrVMR9Hue.Value, False)
    End Sub

    Private Sub updVideoPixelization_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updVideoPixelization.ValueChanged
        MainForm.DefInstance.VideoGrabber1.VideoProcessing_Pixellization() = updVideoPixelization.Value
    End Sub
End Class
