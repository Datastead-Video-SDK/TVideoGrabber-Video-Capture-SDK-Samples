Option Strict Off
Option Explicit On
Friend Class Overlays
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
    Public WithEvents mmoTextOverlayString As System.Windows.Forms.TextBox
    Public WithEvents chkTextOverlayEnabled As System.Windows.Forms.CheckBox
    Public WithEvents edtTextOverlayLeft As System.Windows.Forms.TextBox
    Public WithEvents edtTextOverlayTop As System.Windows.Forms.TextBox
    Public WithEvents chkTextOverlayTransparent As System.Windows.Forms.CheckBox
    Public WithEvents Label43 As System.Windows.Forms.Label
    Public WithEvents Label44 As System.Windows.Forms.Label
    Public WithEvents Label45 As System.Windows.Forms.Label
    Public WithEvents grbTextOverlay As System.Windows.Forms.GroupBox
    Public WithEvents chkFreeHandEnabled As System.Windows.Forms.CheckBox
    Public WithEvents btnFreeHandErase As System.Windows.Forms.Button
    Public WithEvents grbFreeHand As System.Windows.Forms.GroupBox
    Public WithEvents Label48 As System.Windows.Forms.Label
    Public WithEvents Label49 As System.Windows.Forms.Label
    Public WithEvents grbBitmapOverlay As System.Windows.Forms.GroupBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents chkTextOverlayShadow As System.Windows.Forms.CheckBox
    Friend WithEvents btnSelectFontColor As System.Windows.Forms.Button
    Friend WithEvents btnSelectFont As System.Windows.Forms.Button
    Friend WithEvents grbOverlaySelector As System.Windows.Forms.GroupBox
    Friend WithEvents btnBackColor As System.Windows.Forms.Button
    Friend WithEvents btnImageOverlayFromFile As System.Windows.Forms.Button
    Friend WithEvents chkImageOverlayAlphaBlend As System.Windows.Forms.CheckBox
    Friend WithEvents chkImageOverlayUseTransparentColor As System.Windows.Forms.CheckBox
    Public WithEvents chkImageOverlayEnabled As System.Windows.Forms.CheckBox
    Public WithEvents chkImageOverlayTransparent As System.Windows.Forms.CheckBox
    Friend WithEvents edtImageOverlayTransparentColorValue As System.Windows.Forms.TextBox
    Friend WithEvents TextSelector4 As System.Windows.Forms.RadioButton
    Friend WithEvents TextSelector2 As System.Windows.Forms.RadioButton
    Friend WithEvents TextSelector1 As System.Windows.Forms.RadioButton
    Friend WithEvents TextSelector0 As System.Windows.Forms.RadioButton
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpImageOverlaySelector As System.Windows.Forms.GroupBox
    Friend WithEvents ImageSelector9 As System.Windows.Forms.RadioButton
    Friend WithEvents ImageSelector8 As System.Windows.Forms.RadioButton
    Friend WithEvents ImageSelector7 As System.Windows.Forms.RadioButton
    Friend WithEvents ImageSelector6 As System.Windows.Forms.RadioButton
    Friend WithEvents ImageSelector5 As System.Windows.Forms.RadioButton
    Friend WithEvents ImageSelector4 As System.Windows.Forms.RadioButton
    Friend WithEvents ImageSelector3 As System.Windows.Forms.RadioButton
    Friend WithEvents ImageSelector2 As System.Windows.Forms.RadioButton
    Friend WithEvents ImageSelector1 As System.Windows.Forms.RadioButton
    Friend WithEvents ImageSelector0 As System.Windows.Forms.RadioButton
    Friend WithEvents TextSelector3 As System.Windows.Forms.RadioButton
    Public WithEvents edtImageOverlayWidth As System.Windows.Forms.TextBox
    Public WithEvents edtImageOverlayHeight As System.Windows.Forms.TextBox
    Public WithEvents edtImageOverlayLeft As System.Windows.Forms.TextBox
    Public WithEvents edtImageOverlayTop As System.Windows.Forms.TextBox
    Public WithEvents edtTextOverlayRight As System.Windows.Forms.TextBox
    Friend WithEvents tbrImageOverlayAlphaBlending As System.Windows.Forms.TrackBar
    Friend WithEvents btnImageOverlayPickupTransparentColorHelp As System.Windows.Forms.Button
    Friend WithEvents btnImageOverlayPickupTransparentColor As System.Windows.Forms.Button
    Public WithEvents chkImageOverlayChromaKey As System.Windows.Forms.CheckBox
    Friend WithEvents edtImageOverlayChromaKeyColorValue As System.Windows.Forms.TextBox
    Friend WithEvents tbrChromaKeyLeeway As System.Windows.Forms.TrackBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSelectShadowColor As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnFreeHandColor As System.Windows.Forms.Button
    Friend WithEvents btnDrawGridColor As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents edtDrawGrid As System.Windows.Forms.TextBox
    Friend WithEvents btnPIP As System.Windows.Forms.Button
    Private WithEvents chkTextOverlayScrolling As System.Windows.Forms.CheckBox
    Public WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents edtTextOverlayScrollingSpeed As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rdgTextOverlayAlign As System.Windows.Forms.GroupBox
    Public WithEvents rdgTextOverlayAlignRight As System.Windows.Forms.RadioButton
    Public WithEvents rdgTextOverlayAlignCenter As System.Windows.Forms.RadioButton
    Public WithEvents rdgTextOverlayAlignLeft As System.Windows.Forms.RadioButton
    Friend WithEvents btnTargetDisplayHelp As System.Windows.Forms.Button
    Friend WithEvents edtTextOverlayTargetDisplay As System.Windows.Forms.TextBox
    Public WithEvents label8 As System.Windows.Forms.Label
    Public WithEvents chkHighResFont As System.Windows.Forms.CheckBox
    Friend WithEvents btn2TargetDisplayHelp As System.Windows.Forms.Button
    Friend WithEvents edtImageOverlayTargetDisplay As System.Windows.Forms.TextBox
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents chkAdjustOverlayAspectRatio As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Overlays))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnFreeHandColor = New System.Windows.Forms.Button
        Me.btnDrawGridColor = New System.Windows.Forms.Button
        Me.edtDrawGrid = New System.Windows.Forms.TextBox
        Me.edtTextOverlayTargetDisplay = New System.Windows.Forms.TextBox
        Me.edtImageOverlayTargetDisplay = New System.Windows.Forms.TextBox
        Me.grbTextOverlay = New System.Windows.Forms.GroupBox
        Me.btnTargetDisplayHelp = New System.Windows.Forms.Button
        Me.label8 = New System.Windows.Forms.Label
        Me.chkHighResFont = New System.Windows.Forms.CheckBox
        Me.mmoTextOverlayString = New System.Windows.Forms.TextBox
        Me.rdgTextOverlayAlign = New System.Windows.Forms.GroupBox
        Me.rdgTextOverlayAlignRight = New System.Windows.Forms.RadioButton
        Me.rdgTextOverlayAlignCenter = New System.Windows.Forms.RadioButton
        Me.rdgTextOverlayAlignLeft = New System.Windows.Forms.RadioButton
        Me.chkTextOverlayScrolling = New System.Windows.Forms.CheckBox
        Me.label7 = New System.Windows.Forms.Label
        Me.edtTextOverlayScrollingSpeed = New System.Windows.Forms.TextBox
        Me.edtTextOverlayLeft = New System.Windows.Forms.TextBox
        Me.btnSelectShadowColor = New System.Windows.Forms.Button
        Me.grbOverlaySelector = New System.Windows.Forms.GroupBox
        Me.TextSelector4 = New System.Windows.Forms.RadioButton
        Me.TextSelector3 = New System.Windows.Forms.RadioButton
        Me.TextSelector2 = New System.Windows.Forms.RadioButton
        Me.TextSelector1 = New System.Windows.Forms.RadioButton
        Me.TextSelector0 = New System.Windows.Forms.RadioButton
        Me.btnBackColor = New System.Windows.Forms.Button
        Me.btnSelectFontColor = New System.Windows.Forms.Button
        Me.chkTextOverlayShadow = New System.Windows.Forms.CheckBox
        Me.btnSelectFont = New System.Windows.Forms.Button
        Me.chkTextOverlayEnabled = New System.Windows.Forms.CheckBox
        Me.edtTextOverlayTop = New System.Windows.Forms.TextBox
        Me.edtTextOverlayRight = New System.Windows.Forms.TextBox
        Me.chkTextOverlayTransparent = New System.Windows.Forms.CheckBox
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.chkAdjustOverlayAspectRatio = New System.Windows.Forms.CheckBox
        Me.grbFreeHand = New System.Windows.Forms.GroupBox
        Me.chkFreeHandEnabled = New System.Windows.Forms.CheckBox
        Me.btnFreeHandErase = New System.Windows.Forms.Button
        Me.grbBitmapOverlay = New System.Windows.Forms.GroupBox
        Me.btn2TargetDisplayHelp = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.tbrChromaKeyLeeway = New System.Windows.Forms.TrackBar
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.edtImageOverlayChromaKeyColorValue = New System.Windows.Forms.TextBox
        Me.chkImageOverlayChromaKey = New System.Windows.Forms.CheckBox
        Me.tbrImageOverlayAlphaBlending = New System.Windows.Forms.TrackBar
        Me.btnImageOverlayPickupTransparentColorHelp = New System.Windows.Forms.Button
        Me.btnImageOverlayPickupTransparentColor = New System.Windows.Forms.Button
        Me.grpImageOverlaySelector = New System.Windows.Forms.GroupBox
        Me.ImageSelector9 = New System.Windows.Forms.RadioButton
        Me.ImageSelector8 = New System.Windows.Forms.RadioButton
        Me.ImageSelector7 = New System.Windows.Forms.RadioButton
        Me.ImageSelector6 = New System.Windows.Forms.RadioButton
        Me.ImageSelector5 = New System.Windows.Forms.RadioButton
        Me.ImageSelector4 = New System.Windows.Forms.RadioButton
        Me.ImageSelector3 = New System.Windows.Forms.RadioButton
        Me.ImageSelector2 = New System.Windows.Forms.RadioButton
        Me.ImageSelector1 = New System.Windows.Forms.RadioButton
        Me.ImageSelector0 = New System.Windows.Forms.RadioButton
        Me.edtImageOverlayWidth = New System.Windows.Forms.TextBox
        Me.edtImageOverlayHeight = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.edtImageOverlayTransparentColorValue = New System.Windows.Forms.TextBox
        Me.btnImageOverlayFromFile = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.chkImageOverlayAlphaBlend = New System.Windows.Forms.CheckBox
        Me.chkImageOverlayUseTransparentColor = New System.Windows.Forms.CheckBox
        Me.chkImageOverlayEnabled = New System.Windows.Forms.CheckBox
        Me.chkImageOverlayTransparent = New System.Windows.Forms.CheckBox
        Me.edtImageOverlayLeft = New System.Windows.Forms.TextBox
        Me.edtImageOverlayTop = New System.Windows.Forms.TextBox
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnPIP = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.grbTextOverlay.SuspendLayout()
        Me.rdgTextOverlayAlign.SuspendLayout()
        Me.grbOverlaySelector.SuspendLayout()
        Me.grbFreeHand.SuspendLayout()
        Me.grbBitmapOverlay.SuspendLayout()
        CType(Me.tbrChromaKeyLeeway, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrImageOverlayAlphaBlending, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpImageOverlaySelector.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFreeHandColor
        '
        Me.btnFreeHandColor.Location = New System.Drawing.Point(96, 21)
        Me.btnFreeHandColor.Name = "btnFreeHandColor"
        Me.btnFreeHandColor.Size = New System.Drawing.Size(19, 27)
        Me.btnFreeHandColor.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.btnFreeHandColor, "select ""free hand"" drawng color from a color dialog")
        '
        'btnDrawGridColor
        '
        Me.btnDrawGridColor.Location = New System.Drawing.Point(756, 32)
        Me.btnDrawGridColor.Name = "btnDrawGridColor"
        Me.btnDrawGridColor.Size = New System.Drawing.Size(19, 25)
        Me.btnDrawGridColor.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.btnDrawGridColor, "select grid color from a color dialog")
        '
        'edtDrawGrid
        '
        Me.edtDrawGrid.Location = New System.Drawing.Point(774, 32)
        Me.edtDrawGrid.Name = "edtDrawGrid"
        Me.edtDrawGrid.Size = New System.Drawing.Size(30, 23)
        Me.edtDrawGrid.TabIndex = 44
        Me.edtDrawGrid.Text = "0"
        Me.ToolTip1.SetToolTip(Me.edtDrawGrid, "enter a number between 2 and 100 to activate grid drawing")
        '
        'edtTextOverlayTargetDisplay
        '
        Me.edtTextOverlayTargetDisplay.Location = New System.Drawing.Point(206, 16)
        Me.edtTextOverlayTargetDisplay.Name = "edtTextOverlayTargetDisplay"
        Me.edtTextOverlayTargetDisplay.Size = New System.Drawing.Size(30, 23)
        Me.edtTextOverlayTargetDisplay.TabIndex = 51
        Me.edtTextOverlayTargetDisplay.Text = "-1"
        Me.ToolTip1.SetToolTip(Me.edtTextOverlayTargetDisplay, "enter a number between 2 and 100 to activate grid drawing")
        '
        'edtImageOverlayTargetDisplay
        '
        Me.edtImageOverlayTargetDisplay.Location = New System.Drawing.Point(521, 128)
        Me.edtImageOverlayTargetDisplay.Name = "edtImageOverlayTargetDisplay"
        Me.edtImageOverlayTargetDisplay.Size = New System.Drawing.Size(30, 23)
        Me.edtImageOverlayTargetDisplay.TabIndex = 54
        Me.edtImageOverlayTargetDisplay.Text = "-1"
        Me.ToolTip1.SetToolTip(Me.edtImageOverlayTargetDisplay, "enter a number between 2 and 100 to activate grid drawing")
        '
        'grbTextOverlay
        '
        Me.grbTextOverlay.BackColor = System.Drawing.SystemColors.Control
        Me.grbTextOverlay.Controls.Add(Me.btnTargetDisplayHelp)
        Me.grbTextOverlay.Controls.Add(Me.edtTextOverlayTargetDisplay)
        Me.grbTextOverlay.Controls.Add(Me.label8)
        Me.grbTextOverlay.Controls.Add(Me.chkHighResFont)
        Me.grbTextOverlay.Controls.Add(Me.mmoTextOverlayString)
        Me.grbTextOverlay.Controls.Add(Me.rdgTextOverlayAlign)
        Me.grbTextOverlay.Controls.Add(Me.chkTextOverlayScrolling)
        Me.grbTextOverlay.Controls.Add(Me.label7)
        Me.grbTextOverlay.Controls.Add(Me.edtTextOverlayScrollingSpeed)
        Me.grbTextOverlay.Controls.Add(Me.edtTextOverlayLeft)
        Me.grbTextOverlay.Controls.Add(Me.btnSelectShadowColor)
        Me.grbTextOverlay.Controls.Add(Me.grbOverlaySelector)
        Me.grbTextOverlay.Controls.Add(Me.btnBackColor)
        Me.grbTextOverlay.Controls.Add(Me.btnSelectFontColor)
        Me.grbTextOverlay.Controls.Add(Me.chkTextOverlayShadow)
        Me.grbTextOverlay.Controls.Add(Me.btnSelectFont)
        Me.grbTextOverlay.Controls.Add(Me.chkTextOverlayEnabled)
        Me.grbTextOverlay.Controls.Add(Me.edtTextOverlayTop)
        Me.grbTextOverlay.Controls.Add(Me.edtTextOverlayRight)
        Me.grbTextOverlay.Controls.Add(Me.chkTextOverlayTransparent)
        Me.grbTextOverlay.Controls.Add(Me.Label44)
        Me.grbTextOverlay.Controls.Add(Me.Label45)
        Me.grbTextOverlay.Controls.Add(Me.Label43)
        Me.grbTextOverlay.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbTextOverlay.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbTextOverlay.Location = New System.Drawing.Point(5, 0)
        Me.grbTextOverlay.Name = "grbTextOverlay"
        Me.grbTextOverlay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbTextOverlay.Size = New System.Drawing.Size(433, 219)
        Me.grbTextOverlay.TabIndex = 16
        Me.grbTextOverlay.TabStop = False
        Me.grbTextOverlay.Text = "text overlays:"
        '
        'btnTargetDisplayHelp
        '
        Me.btnTargetDisplayHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnTargetDisplayHelp.Location = New System.Drawing.Point(244, 15)
        Me.btnTargetDisplayHelp.Name = "btnTargetDisplayHelp"
        Me.btnTargetDisplayHelp.Size = New System.Drawing.Size(32, 26)
        Me.btnTargetDisplayHelp.TabIndex = 52
        Me.btnTargetDisplayHelp.Text = "?"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.BackColor = System.Drawing.SystemColors.Control
        Me.label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.label8.Location = New System.Drawing.Point(103, 21)
        Me.label8.Name = "label8"
        Me.label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label8.Size = New System.Drawing.Size(111, 16)
        Me.label8.TabIndex = 50
        Me.label8.Text = "target display: "
        '
        'chkHighResFont
        '
        Me.chkHighResFont.BackColor = System.Drawing.SystemColors.Control
        Me.chkHighResFont.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkHighResFont.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHighResFont.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkHighResFont.Location = New System.Drawing.Point(10, 39)
        Me.chkHighResFont.Name = "chkHighResFont"
        Me.chkHighResFont.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkHighResFont.Size = New System.Drawing.Size(171, 25)
        Me.chkHighResFont.TabIndex = 49
        Me.chkHighResFont.Text = "high resolution font"
        Me.chkHighResFont.UseVisualStyleBackColor = False
        '
        'mmoTextOverlayString
        '
        Me.mmoTextOverlayString.AcceptsReturn = True
        Me.mmoTextOverlayString.BackColor = System.Drawing.SystemColors.Window
        Me.mmoTextOverlayString.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.mmoTextOverlayString.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mmoTextOverlayString.ForeColor = System.Drawing.SystemColors.WindowText
        Me.mmoTextOverlayString.Location = New System.Drawing.Point(7, 133)
        Me.mmoTextOverlayString.MaxLength = 0
        Me.mmoTextOverlayString.Multiline = True
        Me.mmoTextOverlayString.Name = "mmoTextOverlayString"
        Me.mmoTextOverlayString.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mmoTextOverlayString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.mmoTextOverlayString.Size = New System.Drawing.Size(217, 76)
        Me.mmoTextOverlayString.TabIndex = 26
        '
        'rdgTextOverlayAlign
        '
        Me.rdgTextOverlayAlign.Controls.Add(Me.rdgTextOverlayAlignRight)
        Me.rdgTextOverlayAlign.Controls.Add(Me.rdgTextOverlayAlignCenter)
        Me.rdgTextOverlayAlign.Controls.Add(Me.rdgTextOverlayAlignLeft)
        Me.rdgTextOverlayAlign.Location = New System.Drawing.Point(235, 140)
        Me.rdgTextOverlayAlign.Name = "rdgTextOverlayAlign"
        Me.rdgTextOverlayAlign.Size = New System.Drawing.Size(193, 45)
        Me.rdgTextOverlayAlign.TabIndex = 48
        Me.rdgTextOverlayAlign.TabStop = False
        '
        'rdgTextOverlayAlignRight
        '
        Me.rdgTextOverlayAlignRight.AutoSize = True
        Me.rdgTextOverlayAlignRight.BackColor = System.Drawing.SystemColors.Control
        Me.rdgTextOverlayAlignRight.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgTextOverlayAlignRight.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgTextOverlayAlignRight.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgTextOverlayAlignRight.Location = New System.Drawing.Point(131, 17)
        Me.rdgTextOverlayAlignRight.Name = "rdgTextOverlayAlignRight"
        Me.rdgTextOverlayAlignRight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgTextOverlayAlignRight.Size = New System.Drawing.Size(57, 20)
        Me.rdgTextOverlayAlignRight.TabIndex = 22
        Me.rdgTextOverlayAlignRight.TabStop = True
        Me.rdgTextOverlayAlignRight.Tag = "2"
        Me.rdgTextOverlayAlignRight.Text = "right"
        Me.rdgTextOverlayAlignRight.UseVisualStyleBackColor = False
        '
        'rdgTextOverlayAlignCenter
        '
        Me.rdgTextOverlayAlignCenter.AutoSize = True
        Me.rdgTextOverlayAlignCenter.BackColor = System.Drawing.SystemColors.Control
        Me.rdgTextOverlayAlignCenter.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgTextOverlayAlignCenter.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgTextOverlayAlignCenter.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgTextOverlayAlignCenter.Location = New System.Drawing.Point(62, 17)
        Me.rdgTextOverlayAlignCenter.Name = "rdgTextOverlayAlignCenter"
        Me.rdgTextOverlayAlignCenter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgTextOverlayAlignCenter.Size = New System.Drawing.Size(69, 20)
        Me.rdgTextOverlayAlignCenter.TabIndex = 23
        Me.rdgTextOverlayAlignCenter.TabStop = True
        Me.rdgTextOverlayAlignCenter.Tag = "1"
        Me.rdgTextOverlayAlignCenter.Text = "center"
        Me.rdgTextOverlayAlignCenter.UseVisualStyleBackColor = False
        '
        'rdgTextOverlayAlignLeft
        '
        Me.rdgTextOverlayAlignLeft.AutoSize = True
        Me.rdgTextOverlayAlignLeft.BackColor = System.Drawing.SystemColors.Control
        Me.rdgTextOverlayAlignLeft.Checked = True
        Me.rdgTextOverlayAlignLeft.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdgTextOverlayAlignLeft.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdgTextOverlayAlignLeft.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdgTextOverlayAlignLeft.Location = New System.Drawing.Point(10, 17)
        Me.rdgTextOverlayAlignLeft.Name = "rdgTextOverlayAlignLeft"
        Me.rdgTextOverlayAlignLeft.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdgTextOverlayAlignLeft.Size = New System.Drawing.Size(48, 20)
        Me.rdgTextOverlayAlignLeft.TabIndex = 24
        Me.rdgTextOverlayAlignLeft.TabStop = True
        Me.rdgTextOverlayAlignLeft.Tag = "0"
        Me.rdgTextOverlayAlignLeft.Text = "left"
        Me.rdgTextOverlayAlignLeft.UseVisualStyleBackColor = False
        '
        'chkTextOverlayScrolling
        '
        Me.chkTextOverlayScrolling.AutoSize = True
        Me.chkTextOverlayScrolling.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTextOverlayScrolling.Location = New System.Drawing.Point(232, 188)
        Me.chkTextOverlayScrolling.Name = "chkTextOverlayScrolling"
        Me.chkTextOverlayScrolling.Size = New System.Drawing.Size(91, 20)
        Me.chkTextOverlayScrolling.TabIndex = 42
        Me.chkTextOverlayScrolling.Text = "scrolling"
        Me.chkTextOverlayScrolling.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkTextOverlayScrolling.UseVisualStyleBackColor = True
        '
        'label7
        '
        Me.label7.BackColor = System.Drawing.SystemColors.Control
        Me.label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.label7.Location = New System.Drawing.Point(277, 188)
        Me.label7.Name = "label7"
        Me.label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label7.Size = New System.Drawing.Size(118, 22)
        Me.label7.TabIndex = 41
        Me.label7.Text = "-> speed(+-)"
        Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'edtTextOverlayScrollingSpeed
        '
        Me.edtTextOverlayScrollingSpeed.Location = New System.Drawing.Point(395, 187)
        Me.edtTextOverlayScrollingSpeed.Name = "edtTextOverlayScrollingSpeed"
        Me.edtTextOverlayScrollingSpeed.Size = New System.Drawing.Size(37, 23)
        Me.edtTextOverlayScrollingSpeed.TabIndex = 40
        '
        'edtTextOverlayLeft
        '
        Me.edtTextOverlayLeft.AcceptsReturn = True
        Me.edtTextOverlayLeft.BackColor = System.Drawing.SystemColors.Window
        Me.edtTextOverlayLeft.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtTextOverlayLeft.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtTextOverlayLeft.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtTextOverlayLeft.Location = New System.Drawing.Point(235, 114)
        Me.edtTextOverlayLeft.MaxLength = 0
        Me.edtTextOverlayLeft.Name = "edtTextOverlayLeft"
        Me.edtTextOverlayLeft.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtTextOverlayLeft.Size = New System.Drawing.Size(40, 23)
        Me.edtTextOverlayLeft.TabIndex = 20
        Me.edtTextOverlayLeft.Text = "5"
        '
        'btnSelectShadowColor
        '
        Me.btnSelectShadowColor.Location = New System.Drawing.Point(318, 63)
        Me.btnSelectShadowColor.Name = "btnSelectShadowColor"
        Me.btnSelectShadowColor.Size = New System.Drawing.Size(103, 24)
        Me.btnSelectShadowColor.TabIndex = 36
        Me.btnSelectShadowColor.Text = "shadow color"
        '
        'grbOverlaySelector
        '
        Me.grbOverlaySelector.Controls.Add(Me.TextSelector4)
        Me.grbOverlaySelector.Controls.Add(Me.TextSelector3)
        Me.grbOverlaySelector.Controls.Add(Me.TextSelector2)
        Me.grbOverlaySelector.Controls.Add(Me.TextSelector1)
        Me.grbOverlaySelector.Controls.Add(Me.TextSelector0)
        Me.grbOverlaySelector.Location = New System.Drawing.Point(7, 90)
        Me.grbOverlaySelector.Name = "grbOverlaySelector"
        Me.grbOverlaySelector.Size = New System.Drawing.Size(217, 40)
        Me.grbOverlaySelector.TabIndex = 34
        Me.grbOverlaySelector.TabStop = False
        Me.grbOverlaySelector.Text = "text selector [0 - n]  0 = default"
        '
        'TextSelector4
        '
        Me.TextSelector4.Location = New System.Drawing.Point(170, 17)
        Me.TextSelector4.Name = "TextSelector4"
        Me.TextSelector4.Size = New System.Drawing.Size(29, 20)
        Me.TextSelector4.TabIndex = 4
        Me.TextSelector4.Tag = "4"
        Me.TextSelector4.Text = "4"
        '
        'TextSelector3
        '
        Me.TextSelector3.Location = New System.Drawing.Point(132, 17)
        Me.TextSelector3.Name = "TextSelector3"
        Me.TextSelector3.Size = New System.Drawing.Size(29, 20)
        Me.TextSelector3.TabIndex = 3
        Me.TextSelector3.Tag = "3"
        Me.TextSelector3.Text = "3"
        '
        'TextSelector2
        '
        Me.TextSelector2.Location = New System.Drawing.Point(94, 17)
        Me.TextSelector2.Name = "TextSelector2"
        Me.TextSelector2.Size = New System.Drawing.Size(28, 20)
        Me.TextSelector2.TabIndex = 2
        Me.TextSelector2.Tag = "2"
        Me.TextSelector2.Text = "2"
        '
        'TextSelector1
        '
        Me.TextSelector1.Location = New System.Drawing.Point(55, 17)
        Me.TextSelector1.Name = "TextSelector1"
        Me.TextSelector1.Size = New System.Drawing.Size(29, 20)
        Me.TextSelector1.TabIndex = 1
        Me.TextSelector1.Tag = "1"
        Me.TextSelector1.Text = "1"
        '
        'TextSelector0
        '
        Me.TextSelector0.Location = New System.Drawing.Point(17, 17)
        Me.TextSelector0.Name = "TextSelector0"
        Me.TextSelector0.Size = New System.Drawing.Size(29, 20)
        Me.TextSelector0.TabIndex = 0
        Me.TextSelector0.Tag = "0"
        Me.TextSelector0.Text = "0"
        '
        'btnBackColor
        '
        Me.btnBackColor.Location = New System.Drawing.Point(373, 27)
        Me.btnBackColor.Name = "btnBackColor"
        Me.btnBackColor.Size = New System.Drawing.Size(61, 26)
        Me.btnBackColor.TabIndex = 33
        Me.btnBackColor.Text = "bkgnd"
        '
        'btnSelectFontColor
        '
        Me.btnSelectFontColor.Location = New System.Drawing.Point(305, 27)
        Me.btnSelectFontColor.Name = "btnSelectFontColor"
        Me.btnSelectFontColor.Size = New System.Drawing.Size(61, 26)
        Me.btnSelectFontColor.TabIndex = 32
        Me.btnSelectFontColor.Text = "color"
        '
        'chkTextOverlayShadow
        '
        Me.chkTextOverlayShadow.Location = New System.Drawing.Point(235, 68)
        Me.chkTextOverlayShadow.Name = "chkTextOverlayShadow"
        Me.chkTextOverlayShadow.Size = New System.Drawing.Size(81, 18)
        Me.chkTextOverlayShadow.TabIndex = 31
        Me.chkTextOverlayShadow.Text = "shadow"
        '
        'btnSelectFont
        '
        Me.btnSelectFont.Location = New System.Drawing.Point(371, 114)
        Me.btnSelectFont.Name = "btnSelectFont"
        Me.btnSelectFont.Size = New System.Drawing.Size(61, 26)
        Me.btnSelectFont.TabIndex = 30
        Me.btnSelectFont.Text = "font dlg"
        '
        'chkTextOverlayEnabled
        '
        Me.chkTextOverlayEnabled.BackColor = System.Drawing.SystemColors.Control
        Me.chkTextOverlayEnabled.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkTextOverlayEnabled.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTextOverlayEnabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkTextOverlayEnabled.Location = New System.Drawing.Point(10, 21)
        Me.chkTextOverlayEnabled.Name = "chkTextOverlayEnabled"
        Me.chkTextOverlayEnabled.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkTextOverlayEnabled.Size = New System.Drawing.Size(86, 21)
        Me.chkTextOverlayEnabled.TabIndex = 25
        Me.chkTextOverlayEnabled.Text = "enabled"
        Me.chkTextOverlayEnabled.UseVisualStyleBackColor = False
        '
        'edtTextOverlayTop
        '
        Me.edtTextOverlayTop.AcceptsReturn = True
        Me.edtTextOverlayTop.BackColor = System.Drawing.SystemColors.Window
        Me.edtTextOverlayTop.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtTextOverlayTop.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtTextOverlayTop.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtTextOverlayTop.Location = New System.Drawing.Point(330, 114)
        Me.edtTextOverlayTop.MaxLength = 0
        Me.edtTextOverlayTop.Name = "edtTextOverlayTop"
        Me.edtTextOverlayTop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtTextOverlayTop.Size = New System.Drawing.Size(40, 23)
        Me.edtTextOverlayTop.TabIndex = 19
        Me.edtTextOverlayTop.Text = "5"
        '
        'edtTextOverlayRight
        '
        Me.edtTextOverlayRight.AcceptsReturn = True
        Me.edtTextOverlayRight.BackColor = System.Drawing.SystemColors.Window
        Me.edtTextOverlayRight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtTextOverlayRight.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtTextOverlayRight.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtTextOverlayRight.Location = New System.Drawing.Point(281, 114)
        Me.edtTextOverlayRight.MaxLength = 0
        Me.edtTextOverlayRight.Name = "edtTextOverlayRight"
        Me.edtTextOverlayRight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtTextOverlayRight.Size = New System.Drawing.Size(39, 23)
        Me.edtTextOverlayRight.TabIndex = 18
        Me.edtTextOverlayRight.Text = "-1"
        '
        'chkTextOverlayTransparent
        '
        Me.chkTextOverlayTransparent.BackColor = System.Drawing.SystemColors.Control
        Me.chkTextOverlayTransparent.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkTextOverlayTransparent.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTextOverlayTransparent.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkTextOverlayTransparent.Location = New System.Drawing.Point(126, 66)
        Me.chkTextOverlayTransparent.Name = "chkTextOverlayTransparent"
        Me.chkTextOverlayTransparent.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkTextOverlayTransparent.Size = New System.Drawing.Size(98, 20)
        Me.chkTextOverlayTransparent.TabIndex = 17
        Me.chkTextOverlayTransparent.Text = "transparent"
        Me.chkTextOverlayTransparent.UseVisualStyleBackColor = False
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.SystemColors.Control
        Me.Label44.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label44.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label44.Location = New System.Drawing.Point(330, 98)
        Me.Label44.Name = "Label44"
        Me.Label44.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label44.Size = New System.Drawing.Size(40, 18)
        Me.Label44.TabIndex = 28
        Me.Label44.Text = "top"
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.SystemColors.Control
        Me.Label45.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label45.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label45.Location = New System.Drawing.Point(281, 98)
        Me.Label45.Name = "Label45"
        Me.Label45.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label45.Size = New System.Drawing.Size(43, 21)
        Me.Label45.TabIndex = 27
        Me.Label45.Text = "right"
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.SystemColors.Control
        Me.Label43.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label43.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label43.Location = New System.Drawing.Point(235, 98)
        Me.Label43.Name = "Label43"
        Me.Label43.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label43.Size = New System.Drawing.Size(40, 21)
        Me.Label43.TabIndex = 29
        Me.Label43.Text = "left"
        '
        'chkAdjustOverlayAspectRatio
        '
        Me.chkAdjustOverlayAspectRatio.AutoSize = True
        Me.chkAdjustOverlayAspectRatio.BackColor = System.Drawing.SystemColors.Control
        Me.chkAdjustOverlayAspectRatio.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAdjustOverlayAspectRatio.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAdjustOverlayAspectRatio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkAdjustOverlayAspectRatio.Location = New System.Drawing.Point(724, 7)
        Me.chkAdjustOverlayAspectRatio.Name = "chkAdjustOverlayAspectRatio"
        Me.chkAdjustOverlayAspectRatio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAdjustOverlayAspectRatio.Size = New System.Drawing.Size(216, 20)
        Me.chkAdjustOverlayAspectRatio.TabIndex = 43
        Me.chkAdjustOverlayAspectRatio.Text = "adjust overlay aspect ratio"
        Me.chkAdjustOverlayAspectRatio.UseVisualStyleBackColor = False
        '
        'grbFreeHand
        '
        Me.grbFreeHand.BackColor = System.Drawing.SystemColors.Control
        Me.grbFreeHand.Controls.Add(Me.chkFreeHandEnabled)
        Me.grbFreeHand.Controls.Add(Me.btnFreeHandErase)
        Me.grbFreeHand.Controls.Add(Me.btnFreeHandColor)
        Me.grbFreeHand.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbFreeHand.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbFreeHand.Location = New System.Drawing.Point(445, 0)
        Me.grbFreeHand.Name = "grbFreeHand"
        Me.grbFreeHand.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbFreeHand.Size = New System.Drawing.Size(251, 60)
        Me.grbFreeHand.TabIndex = 13
        Me.grbFreeHand.TabStop = False
        Me.grbFreeHand.Text = """free hand"" mouse overlay USING DC"
        '
        'chkFreeHandEnabled
        '
        Me.chkFreeHandEnabled.BackColor = System.Drawing.SystemColors.Control
        Me.chkFreeHandEnabled.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkFreeHandEnabled.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFreeHandEnabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkFreeHandEnabled.Location = New System.Drawing.Point(12, 25)
        Me.chkFreeHandEnabled.Name = "chkFreeHandEnabled"
        Me.chkFreeHandEnabled.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkFreeHandEnabled.Size = New System.Drawing.Size(78, 21)
        Me.chkFreeHandEnabled.TabIndex = 15
        Me.chkFreeHandEnabled.Text = "enabled"
        Me.chkFreeHandEnabled.UseVisualStyleBackColor = False
        '
        'btnFreeHandErase
        '
        Me.btnFreeHandErase.BackColor = System.Drawing.SystemColors.Control
        Me.btnFreeHandErase.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnFreeHandErase.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFreeHandErase.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFreeHandErase.Location = New System.Drawing.Point(115, 21)
        Me.btnFreeHandErase.Name = "btnFreeHandErase"
        Me.btnFreeHandErase.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnFreeHandErase.Size = New System.Drawing.Size(125, 27)
        Me.btnFreeHandErase.TabIndex = 14
        Me.btnFreeHandErase.Text = "erase drawing"
        Me.btnFreeHandErase.UseVisualStyleBackColor = False
        '
        'grbBitmapOverlay
        '
        Me.grbBitmapOverlay.BackColor = System.Drawing.SystemColors.Control
        Me.grbBitmapOverlay.Controls.Add(Me.btn2TargetDisplayHelp)
        Me.grbBitmapOverlay.Controls.Add(Me.edtImageOverlayTargetDisplay)
        Me.grbBitmapOverlay.Controls.Add(Me.Label9)
        Me.grbBitmapOverlay.Controls.Add(Me.tbrChromaKeyLeeway)
        Me.grbBitmapOverlay.Controls.Add(Me.Label4)
        Me.grbBitmapOverlay.Controls.Add(Me.Label3)
        Me.grbBitmapOverlay.Controls.Add(Me.edtImageOverlayChromaKeyColorValue)
        Me.grbBitmapOverlay.Controls.Add(Me.chkImageOverlayChromaKey)
        Me.grbBitmapOverlay.Controls.Add(Me.tbrImageOverlayAlphaBlending)
        Me.grbBitmapOverlay.Controls.Add(Me.btnImageOverlayPickupTransparentColorHelp)
        Me.grbBitmapOverlay.Controls.Add(Me.btnImageOverlayPickupTransparentColor)
        Me.grbBitmapOverlay.Controls.Add(Me.grpImageOverlaySelector)
        Me.grbBitmapOverlay.Controls.Add(Me.edtImageOverlayWidth)
        Me.grbBitmapOverlay.Controls.Add(Me.edtImageOverlayHeight)
        Me.grbBitmapOverlay.Controls.Add(Me.Label1)
        Me.grbBitmapOverlay.Controls.Add(Me.Label2)
        Me.grbBitmapOverlay.Controls.Add(Me.edtImageOverlayTransparentColorValue)
        Me.grbBitmapOverlay.Controls.Add(Me.btnImageOverlayFromFile)
        Me.grbBitmapOverlay.Controls.Add(Me.chkImageOverlayAlphaBlend)
        Me.grbBitmapOverlay.Controls.Add(Me.chkImageOverlayUseTransparentColor)
        Me.grbBitmapOverlay.Controls.Add(Me.chkImageOverlayEnabled)
        Me.grbBitmapOverlay.Controls.Add(Me.chkImageOverlayTransparent)
        Me.grbBitmapOverlay.Controls.Add(Me.edtImageOverlayLeft)
        Me.grbBitmapOverlay.Controls.Add(Me.edtImageOverlayTop)
        Me.grbBitmapOverlay.Controls.Add(Me.Label48)
        Me.grbBitmapOverlay.Controls.Add(Me.Label49)
        Me.grbBitmapOverlay.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbBitmapOverlay.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbBitmapOverlay.Location = New System.Drawing.Point(445, 58)
        Me.grbBitmapOverlay.Name = "grbBitmapOverlay"
        Me.grbBitmapOverlay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbBitmapOverlay.Size = New System.Drawing.Size(647, 161)
        Me.grbBitmapOverlay.TabIndex = 0
        Me.grbBitmapOverlay.TabStop = False
        Me.grbBitmapOverlay.Text = "image overlay"
        '
        'btn2TargetDisplayHelp
        '
        Me.btn2TargetDisplayHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn2TargetDisplayHelp.Location = New System.Drawing.Point(558, 127)
        Me.btn2TargetDisplayHelp.Name = "btn2TargetDisplayHelp"
        Me.btn2TargetDisplayHelp.Size = New System.Drawing.Size(32, 26)
        Me.btn2TargetDisplayHelp.TabIndex = 55
        Me.btn2TargetDisplayHelp.Text = "?"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(418, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(111, 16)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "target display: "
        '
        'tbrChromaKeyLeeway
        '
        Me.tbrChromaKeyLeeway.AutoSize = False
        Me.tbrChromaKeyLeeway.Location = New System.Drawing.Point(520, 101)
        Me.tbrChromaKeyLeeway.Maximum = 100
        Me.tbrChromaKeyLeeway.Name = "tbrChromaKeyLeeway"
        Me.tbrChromaKeyLeeway.Size = New System.Drawing.Size(105, 20)
        Me.tbrChromaKeyLeeway.TabIndex = 44
        Me.tbrChromaKeyLeeway.TickFrequency = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(400, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 16)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "chroma key RGB color:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(400, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 20)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "chroma key leeway (0..100%)"
        '
        'edtImageOverlayChromaKeyColorValue
        '
        Me.edtImageOverlayChromaKeyColorValue.Location = New System.Drawing.Point(552, 75)
        Me.edtImageOverlayChromaKeyColorValue.Name = "edtImageOverlayChromaKeyColorValue"
        Me.edtImageOverlayChromaKeyColorValue.Size = New System.Drawing.Size(67, 23)
        Me.edtImageOverlayChromaKeyColorValue.TabIndex = 41
        Me.edtImageOverlayChromaKeyColorValue.Text = "0"
        '
        'chkImageOverlayChromaKey
        '
        Me.chkImageOverlayChromaKey.BackColor = System.Drawing.SystemColors.Control
        Me.chkImageOverlayChromaKey.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkImageOverlayChromaKey.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkImageOverlayChromaKey.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkImageOverlayChromaKey.Location = New System.Drawing.Point(403, 55)
        Me.chkImageOverlayChromaKey.Name = "chkImageOverlayChromaKey"
        Me.chkImageOverlayChromaKey.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkImageOverlayChromaKey.Size = New System.Drawing.Size(141, 25)
        Me.chkImageOverlayChromaKey.TabIndex = 39
        Me.chkImageOverlayChromaKey.Text = "chroma key"
        Me.chkImageOverlayChromaKey.UseVisualStyleBackColor = False
        '
        'tbrImageOverlayAlphaBlending
        '
        Me.tbrImageOverlayAlphaBlending.AutoSize = False
        Me.tbrImageOverlayAlphaBlending.Location = New System.Drawing.Point(253, 101)
        Me.tbrImageOverlayAlphaBlending.Maximum = 255
        Me.tbrImageOverlayAlphaBlending.Name = "tbrImageOverlayAlphaBlending"
        Me.tbrImageOverlayAlphaBlending.Size = New System.Drawing.Size(115, 20)
        Me.tbrImageOverlayAlphaBlending.TabIndex = 38
        Me.tbrImageOverlayAlphaBlending.TickFrequency = 26
        '
        'btnImageOverlayPickupTransparentColorHelp
        '
        Me.btnImageOverlayPickupTransparentColorHelp.Location = New System.Drawing.Point(331, 126)
        Me.btnImageOverlayPickupTransparentColorHelp.Name = "btnImageOverlayPickupTransparentColorHelp"
        Me.btnImageOverlayPickupTransparentColorHelp.Size = New System.Drawing.Size(33, 25)
        Me.btnImageOverlayPickupTransparentColorHelp.TabIndex = 37
        Me.btnImageOverlayPickupTransparentColorHelp.Text = "?"
        '
        'btnImageOverlayPickupTransparentColor
        '
        Me.btnImageOverlayPickupTransparentColor.Location = New System.Drawing.Point(139, 126)
        Me.btnImageOverlayPickupTransparentColor.Name = "btnImageOverlayPickupTransparentColor"
        Me.btnImageOverlayPickupTransparentColor.Size = New System.Drawing.Size(185, 25)
        Me.btnImageOverlayPickupTransparentColor.TabIndex = 36
        Me.btnImageOverlayPickupTransparentColor.Text = "pick up transparent color"
        '
        'grpImageOverlaySelector
        '
        Me.grpImageOverlaySelector.Controls.Add(Me.ImageSelector9)
        Me.grpImageOverlaySelector.Controls.Add(Me.ImageSelector8)
        Me.grpImageOverlaySelector.Controls.Add(Me.ImageSelector7)
        Me.grpImageOverlaySelector.Controls.Add(Me.ImageSelector6)
        Me.grpImageOverlaySelector.Controls.Add(Me.ImageSelector5)
        Me.grpImageOverlaySelector.Controls.Add(Me.ImageSelector4)
        Me.grpImageOverlaySelector.Controls.Add(Me.ImageSelector3)
        Me.grpImageOverlaySelector.Controls.Add(Me.ImageSelector2)
        Me.grpImageOverlaySelector.Controls.Add(Me.ImageSelector1)
        Me.grpImageOverlaySelector.Controls.Add(Me.ImageSelector0)
        Me.grpImageOverlaySelector.Location = New System.Drawing.Point(234, 14)
        Me.grpImageOverlaySelector.Name = "grpImageOverlaySelector"
        Me.grpImageOverlaySelector.Size = New System.Drawing.Size(404, 41)
        Me.grpImageOverlaySelector.TabIndex = 35
        Me.grpImageOverlaySelector.TabStop = False
        Me.grpImageOverlaySelector.Text = "image selector [0..9] 0 = default"
        '
        'ImageSelector9
        '
        Me.ImageSelector9.Location = New System.Drawing.Point(362, 18)
        Me.ImageSelector9.Name = "ImageSelector9"
        Me.ImageSelector9.Size = New System.Drawing.Size(29, 20)
        Me.ImageSelector9.TabIndex = 9
        Me.ImageSelector9.Tag = "9"
        Me.ImageSelector9.Text = "9"
        '
        'ImageSelector8
        '
        Me.ImageSelector8.Location = New System.Drawing.Point(324, 18)
        Me.ImageSelector8.Name = "ImageSelector8"
        Me.ImageSelector8.Size = New System.Drawing.Size(29, 20)
        Me.ImageSelector8.TabIndex = 8
        Me.ImageSelector8.Tag = "8"
        Me.ImageSelector8.Text = "8"
        '
        'ImageSelector7
        '
        Me.ImageSelector7.Location = New System.Drawing.Point(286, 18)
        Me.ImageSelector7.Name = "ImageSelector7"
        Me.ImageSelector7.Size = New System.Drawing.Size(28, 20)
        Me.ImageSelector7.TabIndex = 7
        Me.ImageSelector7.Tag = "7"
        Me.ImageSelector7.Text = "7"
        '
        'ImageSelector6
        '
        Me.ImageSelector6.Location = New System.Drawing.Point(247, 18)
        Me.ImageSelector6.Name = "ImageSelector6"
        Me.ImageSelector6.Size = New System.Drawing.Size(29, 20)
        Me.ImageSelector6.TabIndex = 6
        Me.ImageSelector6.Tag = "6"
        Me.ImageSelector6.Text = "6"
        '
        'ImageSelector5
        '
        Me.ImageSelector5.Location = New System.Drawing.Point(209, 18)
        Me.ImageSelector5.Name = "ImageSelector5"
        Me.ImageSelector5.Size = New System.Drawing.Size(29, 20)
        Me.ImageSelector5.TabIndex = 5
        Me.ImageSelector5.Tag = "5"
        Me.ImageSelector5.Text = "5"
        '
        'ImageSelector4
        '
        Me.ImageSelector4.Location = New System.Drawing.Point(173, 18)
        Me.ImageSelector4.Name = "ImageSelector4"
        Me.ImageSelector4.Size = New System.Drawing.Size(29, 20)
        Me.ImageSelector4.TabIndex = 4
        Me.ImageSelector4.Tag = "4"
        Me.ImageSelector4.Text = "4"
        '
        'ImageSelector3
        '
        Me.ImageSelector3.Location = New System.Drawing.Point(134, 18)
        Me.ImageSelector3.Name = "ImageSelector3"
        Me.ImageSelector3.Size = New System.Drawing.Size(29, 20)
        Me.ImageSelector3.TabIndex = 3
        Me.ImageSelector3.Tag = "3"
        Me.ImageSelector3.Text = "3"
        '
        'ImageSelector2
        '
        Me.ImageSelector2.Location = New System.Drawing.Point(96, 18)
        Me.ImageSelector2.Name = "ImageSelector2"
        Me.ImageSelector2.Size = New System.Drawing.Size(29, 20)
        Me.ImageSelector2.TabIndex = 2
        Me.ImageSelector2.Tag = "2"
        Me.ImageSelector2.Text = "2"
        '
        'ImageSelector1
        '
        Me.ImageSelector1.Location = New System.Drawing.Point(58, 18)
        Me.ImageSelector1.Name = "ImageSelector1"
        Me.ImageSelector1.Size = New System.Drawing.Size(28, 20)
        Me.ImageSelector1.TabIndex = 1
        Me.ImageSelector1.Tag = "1"
        Me.ImageSelector1.Text = "1"
        '
        'ImageSelector0
        '
        Me.ImageSelector0.Location = New System.Drawing.Point(19, 18)
        Me.ImageSelector0.Name = "ImageSelector0"
        Me.ImageSelector0.Size = New System.Drawing.Size(29, 20)
        Me.ImageSelector0.TabIndex = 0
        Me.ImageSelector0.Tag = "0"
        Me.ImageSelector0.Text = "0"
        '
        'edtImageOverlayWidth
        '
        Me.edtImageOverlayWidth.AcceptsReturn = True
        Me.edtImageOverlayWidth.BackColor = System.Drawing.SystemColors.Window
        Me.edtImageOverlayWidth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtImageOverlayWidth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtImageOverlayWidth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtImageOverlayWidth.Location = New System.Drawing.Point(23, 117)
        Me.edtImageOverlayWidth.MaxLength = 0
        Me.edtImageOverlayWidth.Name = "edtImageOverlayWidth"
        Me.edtImageOverlayWidth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtImageOverlayWidth.Size = New System.Drawing.Size(39, 23)
        Me.edtImageOverlayWidth.TabIndex = 19
        Me.edtImageOverlayWidth.Text = "-1"
        '
        'edtImageOverlayHeight
        '
        Me.edtImageOverlayHeight.AcceptsReturn = True
        Me.edtImageOverlayHeight.BackColor = System.Drawing.SystemColors.Window
        Me.edtImageOverlayHeight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtImageOverlayHeight.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtImageOverlayHeight.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtImageOverlayHeight.Location = New System.Drawing.Point(73, 117)
        Me.edtImageOverlayHeight.MaxLength = 0
        Me.edtImageOverlayHeight.Name = "edtImageOverlayHeight"
        Me.edtImageOverlayHeight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtImageOverlayHeight.Size = New System.Drawing.Size(40, 23)
        Me.edtImageOverlayHeight.TabIndex = 18
        Me.edtImageOverlayHeight.Text = "-1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(22, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "width"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(70, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "height"
        '
        'edtImageOverlayTransparentColorValue
        '
        Me.edtImageOverlayTransparentColorValue.Location = New System.Drawing.Point(296, 75)
        Me.edtImageOverlayTransparentColorValue.Name = "edtImageOverlayTransparentColorValue"
        Me.edtImageOverlayTransparentColorValue.Size = New System.Drawing.Size(68, 23)
        Me.edtImageOverlayTransparentColorValue.TabIndex = 17
        Me.edtImageOverlayTransparentColorValue.Text = "0"
        '
        'btnImageOverlayFromFile
        '
        Me.btnImageOverlayFromFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImageOverlayFromFile.ImageIndex = 0
        Me.btnImageOverlayFromFile.ImageList = Me.ImageList1
        Me.btnImageOverlayFromFile.Location = New System.Drawing.Point(92, 18)
        Me.btnImageOverlayFromFile.Name = "btnImageOverlayFromFile"
        Me.btnImageOverlayFromFile.Size = New System.Drawing.Size(132, 30)
        Me.btnImageOverlayFromFile.TabIndex = 16
        Me.btnImageOverlayFromFile.Text = " load image..."
        Me.btnImageOverlayFromFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Fuchsia
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'chkImageOverlayAlphaBlend
        '
        Me.chkImageOverlayAlphaBlend.Location = New System.Drawing.Point(139, 98)
        Me.chkImageOverlayAlphaBlend.Name = "chkImageOverlayAlphaBlend"
        Me.chkImageOverlayAlphaBlend.Size = New System.Drawing.Size(127, 20)
        Me.chkImageOverlayAlphaBlend.TabIndex = 14
        Me.chkImageOverlayAlphaBlend.Text = "alpha blending (0..255):"
        '
        'chkImageOverlayUseTransparentColor
        '
        Me.chkImageOverlayUseTransparentColor.Location = New System.Drawing.Point(139, 76)
        Me.chkImageOverlayUseTransparentColor.Name = "chkImageOverlayUseTransparentColor"
        Me.chkImageOverlayUseTransparentColor.Size = New System.Drawing.Size(167, 22)
        Me.chkImageOverlayUseTransparentColor.TabIndex = 12
        Me.chkImageOverlayUseTransparentColor.Text = "use transparent color:"
        '
        'chkImageOverlayEnabled
        '
        Me.chkImageOverlayEnabled.BackColor = System.Drawing.SystemColors.Control
        Me.chkImageOverlayEnabled.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkImageOverlayEnabled.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkImageOverlayEnabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkImageOverlayEnabled.Location = New System.Drawing.Point(10, 20)
        Me.chkImageOverlayEnabled.Name = "chkImageOverlayEnabled"
        Me.chkImageOverlayEnabled.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkImageOverlayEnabled.Size = New System.Drawing.Size(86, 21)
        Me.chkImageOverlayEnabled.TabIndex = 6
        Me.chkImageOverlayEnabled.Text = "enabled"
        Me.chkImageOverlayEnabled.UseVisualStyleBackColor = False
        '
        'chkImageOverlayTransparent
        '
        Me.chkImageOverlayTransparent.BackColor = System.Drawing.SystemColors.Control
        Me.chkImageOverlayTransparent.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkImageOverlayTransparent.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkImageOverlayTransparent.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkImageOverlayTransparent.Location = New System.Drawing.Point(139, 55)
        Me.chkImageOverlayTransparent.Name = "chkImageOverlayTransparent"
        Me.chkImageOverlayTransparent.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkImageOverlayTransparent.Size = New System.Drawing.Size(157, 25)
        Me.chkImageOverlayTransparent.TabIndex = 5
        Me.chkImageOverlayTransparent.Text = "transparent"
        Me.chkImageOverlayTransparent.UseVisualStyleBackColor = False
        '
        'edtImageOverlayLeft
        '
        Me.edtImageOverlayLeft.AcceptsReturn = True
        Me.edtImageOverlayLeft.BackColor = System.Drawing.SystemColors.Window
        Me.edtImageOverlayLeft.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtImageOverlayLeft.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtImageOverlayLeft.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtImageOverlayLeft.Location = New System.Drawing.Point(23, 73)
        Me.edtImageOverlayLeft.MaxLength = 0
        Me.edtImageOverlayLeft.Name = "edtImageOverlayLeft"
        Me.edtImageOverlayLeft.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtImageOverlayLeft.Size = New System.Drawing.Size(39, 23)
        Me.edtImageOverlayLeft.TabIndex = 4
        Me.edtImageOverlayLeft.Text = "10"
        '
        'edtImageOverlayTop
        '
        Me.edtImageOverlayTop.AcceptsReturn = True
        Me.edtImageOverlayTop.BackColor = System.Drawing.SystemColors.Window
        Me.edtImageOverlayTop.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtImageOverlayTop.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtImageOverlayTop.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtImageOverlayTop.Location = New System.Drawing.Point(73, 73)
        Me.edtImageOverlayTop.MaxLength = 0
        Me.edtImageOverlayTop.Name = "edtImageOverlayTop"
        Me.edtImageOverlayTop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtImageOverlayTop.Size = New System.Drawing.Size(40, 23)
        Me.edtImageOverlayTop.TabIndex = 3
        Me.edtImageOverlayTop.Text = "10"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.BackColor = System.Drawing.SystemColors.Control
        Me.Label48.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label48.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label48.Location = New System.Drawing.Point(22, 57)
        Me.Label48.Name = "Label48"
        Me.Label48.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label48.Size = New System.Drawing.Size(27, 16)
        Me.Label48.TabIndex = 10
        Me.Label48.Text = "left"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.BackColor = System.Drawing.SystemColors.Control
        Me.Label49.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label49.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label49.Location = New System.Drawing.Point(70, 57)
        Me.Label49.Name = "Label49"
        Me.Label49.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label49.Size = New System.Drawing.Size(28, 16)
        Me.Label49.TabIndex = 9
        Me.Label49.Text = "top"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(804, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 16)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "facets"
        '
        'btnPIP
        '
        Me.btnPIP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPIP.ImageIndex = 0
        Me.btnPIP.ImageList = Me.ImageList1
        Me.btnPIP.Location = New System.Drawing.Point(850, 28)
        Me.btnPIP.Name = "btnPIP"
        Me.btnPIP.Size = New System.Drawing.Size(272, 32)
        Me.btnPIP.TabIndex = 45
        Me.btnPIP.Text = "PIP from another TVideoGrabber control"
        Me.btnPIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(720, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 16)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "grid:"
        '
        'Overlays
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1131, 235)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkAdjustOverlayAspectRatio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnDrawGridColor)
        Me.Controls.Add(Me.btnPIP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.edtDrawGrid)
        Me.Controls.Add(Me.grbTextOverlay)
        Me.Controls.Add(Me.grbFreeHand)
        Me.Controls.Add(Me.grbBitmapOverlay)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Overlays"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.grbTextOverlay.ResumeLayout(False)
        Me.grbTextOverlay.PerformLayout()
        Me.rdgTextOverlayAlign.ResumeLayout(False)
        Me.rdgTextOverlayAlign.PerformLayout()
        Me.grbOverlaySelector.ResumeLayout(False)
        Me.grbFreeHand.ResumeLayout(False)
        Me.grbBitmapOverlay.ResumeLayout(False)
        Me.grbBitmapOverlay.PerformLayout()
        CType(Me.tbrChromaKeyLeeway, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrImageOverlayAlphaBlending, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpImageOverlaySelector.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
    Dim FFontSize As Integer = 12
    Dim PIPVideoGrabber As VidGrab.VideoGrabber
    Dim m_ImageOverlayIndex As Integer = 0
    Dim m_TextOverlayIndex As Integer = 0

    Public Sub RefreshControls()
        btnDrawGridColor.BackColor = MainForm.DefInstance.frmOverlays_btnDrawGridColor
        btnFreeHandColor.BackColor = MainForm.DefInstance.frmOverlays_btnFreeHandColor
        chkAdjustOverlayAspectRatio.Checked = MainForm.DefInstance.VideoGrabber1.AdjustOverlayAspectRatio
    End Sub

    Private Sub Overlays_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextSelector0.Checked = True
        ImageSelector0.Checked = True
    End Sub

    Private Sub chkTextOverlayEnabled_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTextOverlayEnabled.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.SetTextOverlay_String(m_TextOverlayIndex, mmoTextOverlayString.Text)
        MainForm.DefInstance.VideoGrabber1.SetTextOverlay_Enabled(m_TextOverlayIndex, chkTextOverlayEnabled.Checked)
    End Sub

    Private Sub chkHighResFont_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHighResFont.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.SetTextOverlay_HighResFont(m_TextOverlayIndex, chkHighResFont.Checked)
    End Sub

    Private Sub edtTextOverlayTargetDisplay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtTextOverlayTargetDisplay.TextChanged
        If IsNumeric(edtTextOverlayTargetDisplay.Text) Then
            MainForm.DefInstance.VideoGrabber1.SetTextOverlay_TargetDisplay(m_TextOverlayIndex, edtTextOverlayTargetDisplay.Text)
        End If
    End Sub

    Private Sub chkAdjustOverlayAspectRatio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAdjustOverlayAspectRatio.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.AdjustOverlayAspectRatio = chkAdjustOverlayAspectRatio.Checked
    End Sub

    Private Sub chkTextOverlayTransparent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTextOverlayTransparent.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.SetTextOverlay_Transparent(m_TextOverlayIndex, chkTextOverlayTransparent.Checked)
    End Sub

    Private Sub chkTextOverlayShadow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTextOverlayShadow.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.SetTextOverlay_Shadow(m_TextOverlayIndex, chkTextOverlayShadow.Checked)
    End Sub

    Private Sub btnSelectShadowColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectShadowColor.Click
        Dim cd As New ColorDialog
        If cd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            MainForm.DefInstance.VideoGrabber1.SetTextOverlay_ShadowColor(m_TextOverlayIndex, ColorTranslator.ToWin32(cd.Color))
        End If
    End Sub

    Private Sub edtTextOverlayTop_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtTextOverlayTop.TextChanged
        If IsNumeric(edtTextOverlayTop.Text) Then
            MainForm.DefInstance.VideoGrabber1.SetTextOverlay_Top(m_TextOverlayIndex, edtTextOverlayTop.Text)
        End If
    End Sub

    Private Sub edtTextOverlayRight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtTextOverlayRight.TextChanged
        If IsNumeric(edtTextOverlayRight.Text) Then
            MainForm.DefInstance.VideoGrabber1.SetTextOverlay_Right(m_TextOverlayIndex, edtTextOverlayRight.Text)
        End If
    End Sub

    Private Sub edtTextOverlayLeft_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtTextOverlayLeft.TextChanged
        If IsNumeric(edtTextOverlayLeft.Text) Then
            MainForm.DefInstance.VideoGrabber1.SetTextOverlay_Left(m_TextOverlayIndex, edtTextOverlayLeft.Text)
        End If
    End Sub

    Private Sub mmoTextOverlayString_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mmoTextOverlayString.TextChanged
        MainForm.DefInstance.VideoGrabber1.SetTextOverlay_String(m_TextOverlayIndex, mmoTextOverlayString.Text)
    End Sub

    Private Sub rdgTextOverlayAlign_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdgTextOverlayAlignCenter.CheckedChanged
        If CType(sender, RadioButton).Checked Then
            MainForm.DefInstance.VideoGrabber1.SetTextOverlay_Align(m_TextOverlayIndex, sender.Tag)
        End If
    End Sub

    Private Overloads Sub btnSelectFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectFont.Click
        Dim fd As New FontDialog
        If fd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            MainForm.DefInstance.VideoGrabber1.SetTextOverlay_Font(m_TextOverlayIndex, fd.Font.ToHfont())
        End If
    End Sub

    Private Sub btnSelectFontColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectFontColor.Click
        Dim cd As New ColorDialog
        If cd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            MainForm.DefInstance.VideoGrabber1.SetTextOverlay_FontColor(m_TextOverlayIndex, ColorTranslator.ToWin32(cd.Color))
        End If
    End Sub

    Private Sub btnBackColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackColor.Click
        Dim cd As New ColorDialog
        If cd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            MainForm.DefInstance.VideoGrabber1.SetTextOverlay_BkColor(m_TextOverlayIndex, ColorTranslator.ToWin32(cd.Color))
        End If
    End Sub

    Private Sub chkTextOverlayScrolling_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTextOverlayScrolling.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.SetTextOverlay_Scrolling(m_TextOverlayIndex, chkTextOverlayScrolling.Checked)
    End Sub

    Private Sub edtTextOverlayScrollingSpeed_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtTextOverlayScrollingSpeed.TextChanged
        If IsNumeric(edtTextOverlayScrollingSpeed.Text) Then
            MainForm.DefInstance.VideoGrabber1.SetTextOverlay_ScrollingSpeed(m_TextOverlayIndex, edtTextOverlayScrollingSpeed.Text)
        End If
    End Sub

    Private Sub TextSelector_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextSelector4.CheckedChanged, TextSelector2.CheckedChanged, TextSelector1.CheckedChanged, TextSelector0.CheckedChanged, TextSelector3.CheckedChanged
        If CType(sender, RadioButton).Checked Then
            m_TextOverlayIndex = sender.Tag

            ' as we have selected another set, let's reload the corresponding values
            chkTextOverlayEnabled.Checked = MainForm.DefInstance.VideoGrabber1.GetTextOverlay_Enabled(m_TextOverlayIndex)
            chkHighResFont.Checked = MainForm.DefInstance.VideoGrabber1.GetTextOverlay_HighResFont(m_TextOverlayIndex)
            edtTextOverlayTargetDisplay.Text = MainForm.DefInstance.VideoGrabber1.GetTextOverlay_TargetDisplay(m_TextOverlayIndex).ToString()

            mmoTextOverlayString.Text = MainForm.DefInstance.VideoGrabber1.GetTextOverlay_String(m_TextOverlayIndex)
            edtTextOverlayLeft.Text = MainForm.DefInstance.VideoGrabber1.GetTextOverlay_Left(m_TextOverlayIndex).ToString
            edtTextOverlayTop.Text = MainForm.DefInstance.VideoGrabber1.GetTextOverlay_Top(m_TextOverlayIndex).ToString
            edtTextOverlayRight.Text = MainForm.DefInstance.VideoGrabber1.GetTextOverlay_Right(m_TextOverlayIndex).ToString
            edtTextOverlayScrollingSpeed.Text = MainForm.DefInstance.VideoGrabber1.GetTextOverlay_ScrollingSpeed(m_TextOverlayIndex)

            SetRadioButtonInGroupUsingTag(rdgTextOverlayAlign, MainForm.DefInstance.VideoGrabber1.GetTextOverlay_Align(m_TextOverlayIndex))
            chkTextOverlayTransparent.Checked = MainForm.DefInstance.VideoGrabber1.GetTextOverlay_Transparent(m_TextOverlayIndex)
            chkTextOverlayShadow.Checked = MainForm.DefInstance.VideoGrabber1.GetTextOverlay_Shadow(m_TextOverlayIndex)
            chkTextOverlayScrolling.Checked = MainForm.DefInstance.VideoGrabber1.GetTextOverlay_Scrolling(m_TextOverlayIndex)
        End If
    End Sub

    Private Sub btnPIP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPIP.Click
        Dim dlgOpen As OpenFileDialog = New OpenFileDialog
        dlgOpen.Filter = OPEN_MEDIA_FILES
        If dlgOpen.ShowDialog = Windows.Forms.DialogResult.OK Then
            If PIPVideoGrabber Is Nothing Then
                PIPVideoGrabber = New VidGrab.VideoGrabber()
                Me.Controls.Add(Me.PIPVideoGrabber)
                PIPVideoGrabber.VideoRenderer = VidGrab.TVideoRenderer.vr_None
                PIPVideoGrabber.Visible = False
                MainForm.DefInstance.VideoGrabber1.Mixer_SetupPIPFromSource(PIPVideoGrabber.UniqueID, 0, 0, 0, 0, True, 10, 10, 200, 150, False)
            End If
            PIPVideoGrabber.PlayerFileName = dlgOpen.FileName
            PIPVideoGrabber.OpenPlayer()
        End If
    End Sub

    Private Sub btnBitmapOverlayFromFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImageOverlayFromFile.Click
        Dim fd As New OpenFileDialog

        fd.Filter = OPEN_PICTURE_FILES
        If fd.ShowDialog = Windows.Forms.DialogResult.OK Then
            MainForm.DefInstance.VideoGrabber1.SetImageOverlayFromImageFile2(m_ImageOverlayIndex, fd.FileName)
        End If
    End Sub

    Private Sub Overlays_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Visible Then
            RefreshControls()
        End If
    End Sub

    Private Sub ImageSelector_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImageSelector0.CheckedChanged, ImageSelector1.CheckedChanged, ImageSelector2.CheckedChanged, ImageSelector3.CheckedChanged, ImageSelector4.CheckedChanged, ImageSelector5.CheckedChanged, ImageSelector6.CheckedChanged, ImageSelector7.CheckedChanged, ImageSelector8.CheckedChanged, ImageSelector9.CheckedChanged
        m_ImageOverlayIndex = sender.Tag

        chkImageOverlayEnabled.Checked = MainForm.DefInstance.VideoGrabber1.GetImageOverlay_Enabled(m_ImageOverlayIndex)
        edtImageOverlayTargetDisplay.Text = MainForm.DefInstance.VideoGrabber1.GetImageOverlay_TargetDisplay(m_ImageOverlayIndex).ToString()
        edtImageOverlayLeft.Text = MainForm.DefInstance.VideoGrabber1.GetImageOverlay_LeftLocation(m_ImageOverlayIndex).ToString()
        edtImageOverlayTop.Text = MainForm.DefInstance.VideoGrabber1.GetImageOverlay_TopLocation(m_ImageOverlayIndex).ToString()
        edtImageOverlayWidth.Text = MainForm.DefInstance.VideoGrabber1.GetImageOverlay_Width(m_ImageOverlayIndex).ToString()
        edtImageOverlayHeight.Text = MainForm.DefInstance.VideoGrabber1.GetImageOverlay_Height(m_ImageOverlayIndex).ToString()

        chkImageOverlayTransparent.Checked = MainForm.DefInstance.VideoGrabber1.GetImageOverlay_Transparent(m_ImageOverlayIndex)
        chkImageOverlayUseTransparentColor.Checked = MainForm.DefInstance.VideoGrabber1.GetImageOverlay_UseTransparentColor(m_ImageOverlayIndex)
        edtImageOverlayTransparentColorValue.Text = "&H" + MainForm.DefInstance.VideoGrabber1.GetImageOverlay_TransparentColorValue(m_ImageOverlayIndex).ToString("X000000")
        chkImageOverlayAlphaBlend.Checked = MainForm.DefInstance.VideoGrabber1.GetImageOverlay_AlphaBlend(m_ImageOverlayIndex)
        tbrImageOverlayAlphaBlending.Value = MainForm.DefInstance.VideoGrabber1.GetImageOverlay_AlphaBlendValue(m_ImageOverlayIndex)

        chkImageOverlayChromaKey.Checked = MainForm.DefInstance.VideoGrabber1.GetImageOverlay_ChromaKey(m_ImageOverlayIndex)
        edtImageOverlayChromaKeyColorValue.Text = "&H" + MainForm.DefInstance.VideoGrabber1.GetImageOverlay_ChromaKeyRGBColor(m_ImageOverlayIndex).ToString("X000000")
        tbrChromaKeyLeeway.Value = MainForm.DefInstance.VideoGrabber1.GetImageOverlay_ChromaKeyLeewayPercent(m_ImageOverlayIndex)
    End Sub

    Private Sub chkImageOverlayEnabled_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkImageOverlayEnabled.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.SetImageOverlay_Enabled(m_ImageOverlayIndex, chkImageOverlayEnabled.Checked)
    End Sub

    Private Sub edtImageOverlayTargetDisplay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtImageOverlayTargetDisplay.TextChanged
        If IsNumeric(edtImageOverlayTargetDisplay.Text) Then
            MainForm.DefInstance.VideoGrabber1.SetImageOverlay_TargetDisplay(m_ImageOverlayIndex, edtImageOverlayTargetDisplay.Text)
        End If
    End Sub

    Private Sub edtImageOverlayLeft_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtImageOverlayLeft.TextChanged
        If IsNumeric(edtImageOverlayLeft.Text) Then
            MainForm.DefInstance.VideoGrabber1.SetImageOverlay_LeftLocation(m_ImageOverlayIndex, edtImageOverlayLeft.Text)
        End If
    End Sub

    Private Sub edtImageOverlayTop_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtImageOverlayTop.TextChanged
        If IsNumeric(edtImageOverlayTop.Text) Then
            MainForm.DefInstance.VideoGrabber1.SetImageOverlay_TopLocation(m_ImageOverlayIndex, edtImageOverlayTop.Text)
        End If
    End Sub

    Private Sub edtImageOverlayWidth_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtImageOverlayWidth.TextChanged
        If IsNumeric(edtImageOverlayWidth.Text) Then
            MainForm.DefInstance.VideoGrabber1.SetImageOverlay_Width(m_ImageOverlayIndex, edtImageOverlayWidth.Text)
        End If
    End Sub

    Private Sub edtImageOverlayHeight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtImageOverlayHeight.TextChanged
        If IsNumeric(edtImageOverlayHeight.Text) Then
            MainForm.DefInstance.VideoGrabber1.SetImageOverlay_Height(m_ImageOverlayIndex, edtImageOverlayHeight.Text)
        End If
    End Sub

    Private Sub chkImageOverlayTransparent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkImageOverlayTransparent.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.SetImageOverlay_Transparent(m_ImageOverlayIndex, chkImageOverlayTransparent.Checked)
    End Sub

    Private Sub btnImageOverlayPickupColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImageOverlayPickupTransparentColor.Click
        If MainForm.DefInstance.cPickupColor.LastRGBPixelValueAtMousePosition <> -1 Then
            MainForm.DefInstance.VideoGrabber1.SetImageOverlay_TransparentColorValue(m_ImageOverlayIndex, MainForm.DefInstance.cPickupColor.LastRGBPixelValueAtMousePosition)
            edtImageOverlayTransparentColorValue.Text = "&H" + MainForm.DefInstance.cPickupColor.LastRGBPixelValueAtMousePosition.ToString("X000000")
        End If
    End Sub

    Private Sub btnImageOverlayPickupHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImageOverlayPickupTransparentColorHelp.Click
        MessageBox.Show("while the preview is running:" & vbCrLf & "- load the image overlay" & vbCrLf & "- enable 'transparent' and 'use transp. color value'" & vbCrLf & "- in the video window, click on the video frame on the color of the overlayed image you want to be transparent" & vbCrLf & "- click on 'pickup the transparent color' to select it as transparent color", _
                "DataStead TVideoGrabber VB.NET OCX Demo", MessageBoxButtons.OK)
    End Sub

    Private Sub chkImageOverlayUseTransparentColor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkImageOverlayUseTransparentColor.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.SetImageOverlay_UseTransparentColor(m_ImageOverlayIndex, chkImageOverlayUseTransparentColor.Checked)
    End Sub

    Private Sub edtImageOverlayTransparentColorValue_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtImageOverlayTransparentColorValue.TextChanged
        If IsNumeric(edtImageOverlayTransparentColorValue.Text) Then
            MainForm.DefInstance.VideoGrabber1.SetImageOverlay_TransparentColorValue(m_ImageOverlayIndex, edtImageOverlayTransparentColorValue.Text)
        End If
    End Sub

    Private Sub chkImageOverlayAlphaBlend_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkImageOverlayAlphaBlend.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.SetImageOverlay_AlphaBlend(m_ImageOverlayIndex, chkImageOverlayAlphaBlend.Checked)
    End Sub

    Private Sub tbrImageOverlayAlphaBlending_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrImageOverlayAlphaBlending.Scroll
        MainForm.DefInstance.VideoGrabber1.SetImageOverlay_AlphaBlendValue(m_ImageOverlayIndex, tbrImageOverlayAlphaBlending.Value)
    End Sub

    Private Sub chkImageOverlayChromaKey_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkImageOverlayChromaKey.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.SetImageOverlay_ChromaKey(m_ImageOverlayIndex, chkImageOverlayChromaKey.Checked)
    End Sub

    Private Sub edtImageOverlayChromaKeyColorValue_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtImageOverlayChromaKeyColorValue.TextChanged
        If IsNumeric(edtImageOverlayChromaKeyColorValue.Text) Then
            MainForm.DefInstance.VideoGrabber1.SetImageOverlay_ChromaKeyRGBColor(m_ImageOverlayIndex, edtImageOverlayChromaKeyColorValue.Text)
        End If
    End Sub

    Private Sub tbrChromaKeyLeeway_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrChromaKeyLeeway.Scroll
        MainForm.DefInstance.VideoGrabber1.SetImageOverlay_ChromaKeyLeewayPercent(m_ImageOverlayIndex, tbrChromaKeyLeeway.Value)
    End Sub

    Private Sub chkFreeHandEnabled_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFreeHandEnabled.CheckedChanged
        ' the sample code is located in the OnMouse... events and the overlay is performed in the OnFrameBitmap event of MainForm
    End Sub

    Private Sub btnFreeHandErase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFreeHandErase.Click
        MainForm.DefInstance.cFreeHandDrawing.iArrayCoordinates = 0
        MainForm.DefInstance.VideoGrabber1.RefreshPlayerOverlays()
    End Sub

    Private Sub btnFreeHandColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFreeHandColor.Click
        Dim cd As New ColorDialog
        If cd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            MainForm.DefInstance.frmOverlays_btnFreeHandColor = cd.Color
            btnFreeHandColor.BackColor = cd.Color
        End If
    End Sub


    Private Sub edtDrawGrid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtDrawGrid.TextChanged
        Select Case Val(edtDrawGrid.Text)
            Case Is > 100
                MainForm.DefInstance.frmOverlays_edtDrawGrid = 100
            Case Is > 1
                MainForm.DefInstance.frmOverlays_edtDrawGrid = Val(edtDrawGrid.Text)
            Case Else
                MainForm.DefInstance.frmOverlays_edtDrawGrid = 0
        End Select
        ' frmOverlays_edtDrawGrid is tested in the OnFrameOverlayUsingDC event of MainForm
    End Sub

    Private Sub btnDrawGridColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDrawGridColor.Click
        Dim cd As New ColorDialog
        If cd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            MainForm.DefInstance.frmOverlays_btnDrawGridColor = cd.Color
            btnDrawGridColor.BackColor = cd.Color
        End If
    End Sub

    Private Sub ShowTargetDisplayInfo()
        MessageBox.Show("SetTextOverlay_TargetDisplay / SetImageOverlay_TargetDisplay determines how the overlay is be applied (*):" & vbCrLf & _
         "" & vbCrLf & _
         "TargetDisplay = -1: OVERLAY APPLIED TO THE VIDEO FRAME" & vbCrLf & _
         "advantage: the overlay can applied on the recording if RecordingInNativeFormat is disabled" & vbCrLf & _
         "disadvantage: if the frame is stretched (e.g. full screen display) the overlay is stretched as well" & vbCrLf & _
         "" & vbCrLf & _
         "TargetDisplay = -2: OVERLAY APPLIED TO ALL THE VIDEO WINDOWS but not to the video frames (recorded or captured)" & vbCrLf & _
         "advantage: when stretching the video windows (e.g. full screen display), the overlays are not stretched" & vbCrLf & _
         "disadvantage: it is applied the same way on all the renderers (e.g. if DualDisplay or more renderers are enabled)" & vbCrLf & _
         "" & vbCrLf & _
         "TargetDisplay = n (in the 0..9 range): OVERLAY APPLIED TO THE SPECIFIED DISPLAY WINDOW" & vbCrLf & _
         "advantage: when more than 1 renderer is used, it is possible to display this overlay only one the specified renderer" & vbCrLf & _
         "The TargetDisplay value corresponds to the index of the display window in the ""Display"" tab (0 for the default, 1 for the 2nd, 2 for the 3rd, etc...)" & vbCrLf & _
         "(look at the SetDisplayActive function in the user guide for more information about multiple display windows)" & vbCrLf & _
         "" & vbCrLf & _
         "(*) notes:" & vbCrLf & _
         "- TargetDisplay <> -1 REQUIRES VideoRenderer to be set to vr_Auto or vr_RecordingPriority" & vbCrLf & _
         "- to quick see what happens when changing TargetDisplay, go to theDisplay tab, activate e.g. 4 or 5 video windows and try -1, -2, 0, 1, 2, 3, 4, 5 as TargetDisplay value")
    End Sub

    Private Sub btnTargetDisplayHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTargetDisplayHelp.Click
        ShowTargetDisplayInfo()
    End Sub

    Private Sub btn2TargetDisplayHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2TargetDisplayHelp.Click
        ShowTargetDisplayInfo()
    End Sub
End Class
