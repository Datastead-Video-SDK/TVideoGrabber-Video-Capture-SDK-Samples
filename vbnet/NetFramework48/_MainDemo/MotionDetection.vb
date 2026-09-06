Option Strict Off
Option Explicit On
Friend Class MotionDetection
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
    Public WithEvents imgMotionDetected As System.Windows.Forms.PictureBox
    Public WithEvents chkMotionDetectionEnabled As System.Windows.Forms.CheckBox
    Public WithEvents chkReduceVideoNoise As System.Windows.Forms.CheckBox
    Public WithEvents btnShowGridDialog As System.Windows.Forms.Button
    Public WithEvents chkCompareRed As System.Windows.Forms.CheckBox
    Public WithEvents chk_GreyScale As System.Windows.Forms.CheckBox
    Public WithEvents chkCompareBlue As System.Windows.Forms.CheckBox
    Public WithEvents chkCompareGreen As System.Windows.Forms.CheckBox
    Public WithEvents edtGrid As System.Windows.Forms.TextBox
    Public WithEvents Label39 As System.Windows.Forms.Label
    Public WithEvents lblGridValid As System.Windows.Forms.Label
    Public WithEvents grbGridString As System.Windows.Forms.GroupBox
    Public WithEvents btnApplyGridSize As System.Windows.Forms.Button
    Public WithEvents Label41 As System.Windows.Forms.Label
    Public WithEvents Frame13 As System.Windows.Forms.GroupBox
    Public WithEvents btnSetCellsSensitivity As System.Windows.Forms.Button
    Public WithEvents Label42 As System.Windows.Forms.Label
    Public WithEvents Frame14 As System.Windows.Forms.GroupBox
    Public WithEvents edtMaxMotionXY As System.Windows.Forms.TextBox
    Public WithEvents edtMaxMotionCoord As System.Windows.Forms.TextBox
    Public WithEvents grbXYMaxMotion As System.Windows.Forms.GroupBox
    Public WithEvents edtMotionRatio As System.Windows.Forms.TextBox
    Public WithEvents grbMotionRatio As System.Windows.Forms.GroupBox
    Public WithEvents mmoSensitivityGrid As System.Windows.Forms.TextBox
    Public WithEvents mmoMotionGrid As System.Windows.Forms.TextBox
    Public WithEvents Label36 As System.Windows.Forms.Label
    Public WithEvents lblMotionDetectorRequiresFrameGrabber As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents updGlobalGridSensitivity As System.Windows.Forms.NumericUpDown
    Friend WithEvents updGridColCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents updGridRowCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents updYCell As System.Windows.Forms.NumericUpDown
    Friend WithEvents updXCell As System.Windows.Forms.NumericUpDown
    Friend WithEvents updCellSensitivity As System.Windows.Forms.NumericUpDown
    Friend WithEvents chk_triggered As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_TriggerNow As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.imgMotionDetected = New System.Windows.Forms.PictureBox
        Me.chkMotionDetectionEnabled = New System.Windows.Forms.CheckBox
        Me.chkReduceVideoNoise = New System.Windows.Forms.CheckBox
        Me.btnShowGridDialog = New System.Windows.Forms.Button
        Me.chkCompareRed = New System.Windows.Forms.CheckBox
        Me.chk_GreyScale = New System.Windows.Forms.CheckBox
        Me.chkCompareBlue = New System.Windows.Forms.CheckBox
        Me.chkCompareGreen = New System.Windows.Forms.CheckBox
        Me.grbGridString = New System.Windows.Forms.GroupBox
        Me.updGlobalGridSensitivity = New System.Windows.Forms.NumericUpDown
        Me.edtGrid = New System.Windows.Forms.TextBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.lblGridValid = New System.Windows.Forms.Label
        Me.Frame13 = New System.Windows.Forms.GroupBox
        Me.updGridRowCount = New System.Windows.Forms.NumericUpDown
        Me.updGridColCount = New System.Windows.Forms.NumericUpDown
        Me.btnApplyGridSize = New System.Windows.Forms.Button
        Me.Label41 = New System.Windows.Forms.Label
        Me.Frame14 = New System.Windows.Forms.GroupBox
        Me.updCellSensitivity = New System.Windows.Forms.NumericUpDown
        Me.updYCell = New System.Windows.Forms.NumericUpDown
        Me.updXCell = New System.Windows.Forms.NumericUpDown
        Me.btnSetCellsSensitivity = New System.Windows.Forms.Button
        Me.Label42 = New System.Windows.Forms.Label
        Me.grbXYMaxMotion = New System.Windows.Forms.GroupBox
        Me.edtMaxMotionXY = New System.Windows.Forms.TextBox
        Me.edtMaxMotionCoord = New System.Windows.Forms.TextBox
        Me.grbMotionRatio = New System.Windows.Forms.GroupBox
        Me.edtMotionRatio = New System.Windows.Forms.TextBox
        Me.mmoSensitivityGrid = New System.Windows.Forms.TextBox
        Me.mmoMotionGrid = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.lblMotionDetectorRequiresFrameGrabber = New System.Windows.Forms.Label
        Me.chk_triggered = New System.Windows.Forms.CheckBox
        Me.btn_TriggerNow = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.imgMotionDetected, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbGridString.SuspendLayout()
        CType(Me.updGlobalGridSensitivity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame13.SuspendLayout()
        CType(Me.updGridRowCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updGridColCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame14.SuspendLayout()
        CType(Me.updCellSensitivity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updYCell, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updXCell, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbXYMaxMotion.SuspendLayout()
        Me.grbMotionRatio.SuspendLayout()
        Me.SuspendLayout()
        '
        'imgMotionDetected
        '
        Me.imgMotionDetected.BackColor = System.Drawing.SystemColors.Control
        Me.imgMotionDetected.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.imgMotionDetected.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgMotionDetected.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imgMotionDetected.ForeColor = System.Drawing.SystemColors.ControlText
        Me.imgMotionDetected.Location = New System.Drawing.Point(490, 0)
        Me.imgMotionDetected.Name = "imgMotionDetected"
        Me.imgMotionDetected.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.imgMotionDetected.Size = New System.Drawing.Size(135, 100)
        Me.imgMotionDetected.TabIndex = 38
        Me.imgMotionDetected.TabStop = False
        '
        'chkMotionDetectionEnabled
        '
        Me.chkMotionDetectionEnabled.BackColor = System.Drawing.SystemColors.Control
        Me.chkMotionDetectionEnabled.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkMotionDetectionEnabled.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMotionDetectionEnabled.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkMotionDetectionEnabled.Location = New System.Drawing.Point(5, 27)
        Me.chkMotionDetectionEnabled.Name = "chkMotionDetectionEnabled"
        Me.chkMotionDetectionEnabled.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkMotionDetectionEnabled.Size = New System.Drawing.Size(230, 21)
        Me.chkMotionDetectionEnabled.TabIndex = 34
        Me.chkMotionDetectionEnabled.Text = "ENABLE MOTION DETECTION"
        Me.chkMotionDetectionEnabled.UseVisualStyleBackColor = False
        '
        'chkReduceVideoNoise
        '
        Me.chkReduceVideoNoise.BackColor = System.Drawing.SystemColors.Control
        Me.chkReduceVideoNoise.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkReduceVideoNoise.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReduceVideoNoise.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkReduceVideoNoise.Location = New System.Drawing.Point(226, 27)
        Me.chkReduceVideoNoise.Name = "chkReduceVideoNoise"
        Me.chkReduceVideoNoise.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkReduceVideoNoise.Size = New System.Drawing.Size(153, 21)
        Me.chkReduceVideoNoise.TabIndex = 33
        Me.chkReduceVideoNoise.Text = "reduce video noise"
        Me.chkReduceVideoNoise.UseVisualStyleBackColor = False
        '
        'btnShowGridDialog
        '
        Me.btnShowGridDialog.BackColor = System.Drawing.SystemColors.Control
        Me.btnShowGridDialog.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnShowGridDialog.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowGridDialog.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnShowGridDialog.Location = New System.Drawing.Point(361, 0)
        Me.btnShowGridDialog.Name = "btnShowGridDialog"
        Me.btnShowGridDialog.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnShowGridDialog.Size = New System.Drawing.Size(123, 25)
        Me.btnShowGridDialog.TabIndex = 32
        Me.btnShowGridDialog.Text = "show grid dialog"
        Me.btnShowGridDialog.UseVisualStyleBackColor = False
        '
        'chkCompareRed
        '
        Me.chkCompareRed.BackColor = System.Drawing.SystemColors.Control
        Me.chkCompareRed.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkCompareRed.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCompareRed.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkCompareRed.Location = New System.Drawing.Point(116, 49)
        Me.chkCompareRed.Name = "chkCompareRed"
        Me.chkCompareRed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkCompareRed.Size = New System.Drawing.Size(59, 21)
        Me.chkCompareRed.TabIndex = 31
        Me.chkCompareRed.Text = "red"
        Me.chkCompareRed.UseVisualStyleBackColor = False
        '
        'chk_GreyScale
        '
        Me.chk_GreyScale.BackColor = System.Drawing.SystemColors.Control
        Me.chk_GreyScale.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk_GreyScale.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_GreyScale.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk_GreyScale.Location = New System.Drawing.Point(299, 49)
        Me.chk_GreyScale.Name = "chk_GreyScale"
        Me.chk_GreyScale.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chk_GreyScale.Size = New System.Drawing.Size(96, 21)
        Me.chk_GreyScale.TabIndex = 30
        Me.chk_GreyScale.Text = "greyscale"
        Me.chk_GreyScale.UseVisualStyleBackColor = False
        '
        'chkCompareBlue
        '
        Me.chkCompareBlue.BackColor = System.Drawing.SystemColors.Control
        Me.chkCompareBlue.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkCompareBlue.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCompareBlue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkCompareBlue.Location = New System.Drawing.Point(239, 49)
        Me.chkCompareBlue.Name = "chkCompareBlue"
        Me.chkCompareBlue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkCompareBlue.Size = New System.Drawing.Size(55, 21)
        Me.chkCompareBlue.TabIndex = 29
        Me.chkCompareBlue.Text = "blue"
        Me.chkCompareBlue.UseVisualStyleBackColor = False
        '
        'chkCompareGreen
        '
        Me.chkCompareGreen.BackColor = System.Drawing.SystemColors.Control
        Me.chkCompareGreen.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkCompareGreen.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCompareGreen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkCompareGreen.Location = New System.Drawing.Point(170, 47)
        Me.chkCompareGreen.Name = "chkCompareGreen"
        Me.chkCompareGreen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkCompareGreen.Size = New System.Drawing.Size(76, 24)
        Me.chkCompareGreen.TabIndex = 28
        Me.chkCompareGreen.Text = "green"
        Me.chkCompareGreen.UseVisualStyleBackColor = False
        '
        'grbGridString
        '
        Me.grbGridString.BackColor = System.Drawing.SystemColors.Control
        Me.grbGridString.Controls.Add(Me.updGlobalGridSensitivity)
        Me.grbGridString.Controls.Add(Me.edtGrid)
        Me.grbGridString.Controls.Add(Me.Label39)
        Me.grbGridString.Controls.Add(Me.lblGridValid)
        Me.grbGridString.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbGridString.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbGridString.Location = New System.Drawing.Point(5, 71)
        Me.grbGridString.Name = "grbGridString"
        Me.grbGridString.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbGridString.Size = New System.Drawing.Size(480, 71)
        Me.grbGridString.TabIndex = 23
        Me.grbGridString.TabStop = False
        Me.grbGridString.Text = "grid string"
        '
        'updGlobalGridSensitivity
        '
        Me.updGlobalGridSensitivity.Location = New System.Drawing.Point(68, 34)
        Me.updGlobalGridSensitivity.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.updGlobalGridSensitivity.Name = "updGlobalGridSensitivity"
        Me.updGlobalGridSensitivity.Size = New System.Drawing.Size(20, 23)
        Me.updGlobalGridSensitivity.TabIndex = 28
        Me.updGlobalGridSensitivity.Tag = "0"
        '
        'edtGrid
        '
        Me.edtGrid.AcceptsReturn = True
        Me.edtGrid.BackColor = System.Drawing.SystemColors.Window
        Me.edtGrid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtGrid.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtGrid.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtGrid.Location = New System.Drawing.Point(86, 34)
        Me.edtGrid.MaxLength = 0
        Me.edtGrid.Name = "edtGrid"
        Me.edtGrid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtGrid.Size = New System.Drawing.Size(384, 23)
        Me.edtGrid.TabIndex = 24
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.SystemColors.Control
        Me.Label39.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label39.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label39.Location = New System.Drawing.Point(66, 17)
        Me.Label39.Name = "Label39"
        Me.Label39.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label39.Size = New System.Drawing.Size(90, 16)
        Me.Label39.TabIndex = 27
        Me.Label39.Text = "sensitivity +/-"
        '
        'lblGridValid
        '
        Me.lblGridValid.BackColor = System.Drawing.SystemColors.Control
        Me.lblGridValid.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblGridValid.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGridValid.ForeColor = System.Drawing.Color.Gray
        Me.lblGridValid.Location = New System.Drawing.Point(7, 32)
        Me.lblGridValid.Name = "lblGridValid"
        Me.lblGridValid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblGridValid.Size = New System.Drawing.Size(54, 17)
        Me.lblGridValid.TabIndex = 25
        Me.lblGridValid.Text = "valid"
        Me.lblGridValid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frame13
        '
        Me.Frame13.BackColor = System.Drawing.SystemColors.Control
        Me.Frame13.Controls.Add(Me.updGridRowCount)
        Me.Frame13.Controls.Add(Me.updGridColCount)
        Me.Frame13.Controls.Add(Me.btnApplyGridSize)
        Me.Frame13.Controls.Add(Me.Label41)
        Me.Frame13.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame13.Location = New System.Drawing.Point(5, 142)
        Me.Frame13.Name = "Frame13"
        Me.Frame13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame13.Size = New System.Drawing.Size(164, 76)
        Me.Frame13.TabIndex = 16
        Me.Frame13.TabStop = False
        Me.Frame13.Text = "grid size"
        '
        'updGridRowCount
        '
        Me.updGridRowCount.Location = New System.Drawing.Point(64, 39)
        Me.updGridRowCount.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.updGridRowCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.updGridRowCount.Name = "updGridRowCount"
        Me.updGridRowCount.Size = New System.Drawing.Size(48, 23)
        Me.updGridRowCount.TabIndex = 22
        Me.updGridRowCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'updGridColCount
        '
        Me.updGridColCount.Location = New System.Drawing.Point(10, 39)
        Me.updGridColCount.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.updGridColCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.updGridColCount.Name = "updGridColCount"
        Me.updGridColCount.Size = New System.Drawing.Size(48, 23)
        Me.updGridColCount.TabIndex = 21
        Me.updGridColCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnApplyGridSize
        '
        Me.btnApplyGridSize.BackColor = System.Drawing.SystemColors.Control
        Me.btnApplyGridSize.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnApplyGridSize.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApplyGridSize.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnApplyGridSize.Location = New System.Drawing.Point(118, 39)
        Me.btnApplyGridSize.Name = "btnApplyGridSize"
        Me.btnApplyGridSize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnApplyGridSize.Size = New System.Drawing.Size(38, 27)
        Me.btnApplyGridSize.TabIndex = 17
        Me.btnApplyGridSize.Text = "OK"
        Me.btnApplyGridSize.UseVisualStyleBackColor = False
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.SystemColors.Control
        Me.Label41.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label41.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label41.Location = New System.Drawing.Point(10, 20)
        Me.Label41.Name = "Label41"
        Me.Label41.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label41.Size = New System.Drawing.Size(126, 21)
        Me.Label41.TabIndex = 20
        Me.Label41.Text = "col count/row count"
        '
        'Frame14
        '
        Me.Frame14.BackColor = System.Drawing.SystemColors.Control
        Me.Frame14.Controls.Add(Me.updCellSensitivity)
        Me.Frame14.Controls.Add(Me.updYCell)
        Me.Frame14.Controls.Add(Me.updXCell)
        Me.Frame14.Controls.Add(Me.btnSetCellsSensitivity)
        Me.Frame14.Controls.Add(Me.Label42)
        Me.Frame14.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame14.Location = New System.Drawing.Point(176, 142)
        Me.Frame14.Name = "Frame14"
        Me.Frame14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame14.Size = New System.Drawing.Size(239, 76)
        Me.Frame14.TabIndex = 7
        Me.Frame14.TabStop = False
        Me.Frame14.Text = "cells sensitivity  (0 based index)"
        '
        'updCellSensitivity
        '
        Me.updCellSensitivity.Location = New System.Drawing.Point(122, 39)
        Me.updCellSensitivity.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.updCellSensitivity.Name = "updCellSensitivity"
        Me.updCellSensitivity.Size = New System.Drawing.Size(48, 23)
        Me.updCellSensitivity.TabIndex = 25
        Me.updCellSensitivity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'updYCell
        '
        Me.updYCell.Location = New System.Drawing.Point(67, 39)
        Me.updYCell.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.updYCell.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.updYCell.Name = "updYCell"
        Me.updYCell.Size = New System.Drawing.Size(48, 23)
        Me.updYCell.TabIndex = 24
        Me.updYCell.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'updXCell
        '
        Me.updXCell.Location = New System.Drawing.Point(10, 39)
        Me.updXCell.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.updXCell.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.updXCell.Name = "updXCell"
        Me.updXCell.Size = New System.Drawing.Size(48, 23)
        Me.updXCell.TabIndex = 23
        Me.updXCell.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnSetCellsSensitivity
        '
        Me.btnSetCellsSensitivity.BackColor = System.Drawing.SystemColors.Control
        Me.btnSetCellsSensitivity.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSetCellsSensitivity.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetCellsSensitivity.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSetCellsSensitivity.Location = New System.Drawing.Point(178, 39)
        Me.btnSetCellsSensitivity.Name = "btnSetCellsSensitivity"
        Me.btnSetCellsSensitivity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSetCellsSensitivity.Size = New System.Drawing.Size(51, 27)
        Me.btnSetCellsSensitivity.TabIndex = 9
        Me.btnSetCellsSensitivity.Text = "SET"
        Me.btnSetCellsSensitivity.UseVisualStyleBackColor = False
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.SystemColors.Control
        Me.Label42.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label42.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label42.Location = New System.Drawing.Point(7, 20)
        Me.Label42.Name = "Label42"
        Me.Label42.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label42.Size = New System.Drawing.Size(230, 16)
        Me.Label42.TabIndex = 13
        Me.Label42.Text = "X cell       Y cell     sensitivity (0 .. 9)"
        '
        'grbXYMaxMotion
        '
        Me.grbXYMaxMotion.BackColor = System.Drawing.SystemColors.Control
        Me.grbXYMaxMotion.Controls.Add(Me.edtMaxMotionXY)
        Me.grbXYMaxMotion.Controls.Add(Me.edtMaxMotionCoord)
        Me.grbXYMaxMotion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbXYMaxMotion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbXYMaxMotion.Location = New System.Drawing.Point(422, 164)
        Me.grbXYMaxMotion.Name = "grbXYMaxMotion"
        Me.grbXYMaxMotion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbXYMaxMotion.Size = New System.Drawing.Size(203, 54)
        Me.grbXYMaxMotion.TabIndex = 4
        Me.grbXYMaxMotion.TabStop = False
        Me.grbXYMaxMotion.Text = "max motion location"
        '
        'edtMaxMotionXY
        '
        Me.edtMaxMotionXY.AcceptsReturn = True
        Me.edtMaxMotionXY.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.edtMaxMotionXY.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtMaxMotionXY.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtMaxMotionXY.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtMaxMotionXY.Location = New System.Drawing.Point(11, 21)
        Me.edtMaxMotionXY.MaxLength = 0
        Me.edtMaxMotionXY.Name = "edtMaxMotionXY"
        Me.edtMaxMotionXY.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtMaxMotionXY.Size = New System.Drawing.Size(78, 23)
        Me.edtMaxMotionXY.TabIndex = 6
        '
        'edtMaxMotionCoord
        '
        Me.edtMaxMotionCoord.AcceptsReturn = True
        Me.edtMaxMotionCoord.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.edtMaxMotionCoord.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtMaxMotionCoord.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtMaxMotionCoord.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtMaxMotionCoord.Location = New System.Drawing.Point(96, 21)
        Me.edtMaxMotionCoord.MaxLength = 0
        Me.edtMaxMotionCoord.Name = "edtMaxMotionCoord"
        Me.edtMaxMotionCoord.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtMaxMotionCoord.Size = New System.Drawing.Size(97, 23)
        Me.edtMaxMotionCoord.TabIndex = 5
        '
        'grbMotionRatio
        '
        Me.grbMotionRatio.BackColor = System.Drawing.SystemColors.Control
        Me.grbMotionRatio.Controls.Add(Me.edtMotionRatio)
        Me.grbMotionRatio.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbMotionRatio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbMotionRatio.Location = New System.Drawing.Point(490, 106)
        Me.grbMotionRatio.Name = "grbMotionRatio"
        Me.grbMotionRatio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbMotionRatio.Size = New System.Drawing.Size(135, 55)
        Me.grbMotionRatio.TabIndex = 2
        Me.grbMotionRatio.TabStop = False
        Me.grbMotionRatio.Text = "global motion ratio"
        '
        'edtMotionRatio
        '
        Me.edtMotionRatio.AcceptsReturn = True
        Me.edtMotionRatio.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.edtMotionRatio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.edtMotionRatio.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtMotionRatio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.edtMotionRatio.Location = New System.Drawing.Point(40, 22)
        Me.edtMotionRatio.MaxLength = 0
        Me.edtMotionRatio.Name = "edtMotionRatio"
        Me.edtMotionRatio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.edtMotionRatio.Size = New System.Drawing.Size(86, 23)
        Me.edtMotionRatio.TabIndex = 3
        '
        'mmoSensitivityGrid
        '
        Me.mmoSensitivityGrid.AcceptsReturn = True
        Me.mmoSensitivityGrid.BackColor = System.Drawing.SystemColors.Window
        Me.mmoSensitivityGrid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.mmoSensitivityGrid.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mmoSensitivityGrid.ForeColor = System.Drawing.SystemColors.WindowText
        Me.mmoSensitivityGrid.Location = New System.Drawing.Point(632, 0)
        Me.mmoSensitivityGrid.MaxLength = 0
        Me.mmoSensitivityGrid.Multiline = True
        Me.mmoSensitivityGrid.Name = "mmoSensitivityGrid"
        Me.mmoSensitivityGrid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mmoSensitivityGrid.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.mmoSensitivityGrid.Size = New System.Drawing.Size(228, 218)
        Me.mmoSensitivityGrid.TabIndex = 1
        Me.mmoSensitivityGrid.WordWrap = False
        '
        'mmoMotionGrid
        '
        Me.mmoMotionGrid.AcceptsReturn = True
        Me.mmoMotionGrid.BackColor = System.Drawing.SystemColors.Window
        Me.mmoMotionGrid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.mmoMotionGrid.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mmoMotionGrid.ForeColor = System.Drawing.SystemColors.WindowText
        Me.mmoMotionGrid.Location = New System.Drawing.Point(868, 0)
        Me.mmoMotionGrid.MaxLength = 0
        Me.mmoMotionGrid.Multiline = True
        Me.mmoMotionGrid.Name = "mmoMotionGrid"
        Me.mmoMotionGrid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mmoMotionGrid.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.mmoMotionGrid.Size = New System.Drawing.Size(228, 218)
        Me.mmoMotionGrid.TabIndex = 0
        Me.mmoMotionGrid.WordWrap = False
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.SystemColors.Control
        Me.Label36.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label36.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label36.Location = New System.Drawing.Point(5, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label36.Size = New System.Drawing.Size(128, 16)
        Me.Label36.TabIndex = 37
        Me.Label36.Text = "Motion detection"
        '
        'lblMotionDetectorRequiresFrameGrabber
        '
        Me.lblMotionDetectorRequiresFrameGrabber.AutoSize = True
        Me.lblMotionDetectorRequiresFrameGrabber.BackColor = System.Drawing.SystemColors.Control
        Me.lblMotionDetectorRequiresFrameGrabber.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMotionDetectorRequiresFrameGrabber.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotionDetectorRequiresFrameGrabber.ForeColor = System.Drawing.Color.Red
        Me.lblMotionDetectorRequiresFrameGrabber.Location = New System.Drawing.Point(146, 0)
        Me.lblMotionDetectorRequiresFrameGrabber.Name = "lblMotionDetectorRequiresFrameGrabber"
        Me.lblMotionDetectorRequiresFrameGrabber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMotionDetectorRequiresFrameGrabber.Size = New System.Drawing.Size(207, 16)
        Me.lblMotionDetectorRequiresFrameGrabber.TabIndex = 36
        Me.lblMotionDetectorRequiresFrameGrabber.Text = "frame grabber must be enabled"
        '
        'chk_triggered
        '
        Me.chk_triggered.Location = New System.Drawing.Point(398, 27)
        Me.chk_triggered.Name = "chk_triggered"
        Me.chk_triggered.Size = New System.Drawing.Size(87, 21)
        Me.chk_triggered.TabIndex = 39
        Me.chk_triggered.Text = "triggered"
        '
        'btn_TriggerNow
        '
        Me.btn_TriggerNow.Location = New System.Drawing.Point(394, 48)
        Me.btn_TriggerNow.Name = "btn_TriggerNow"
        Me.btn_TriggerNow.Size = New System.Drawing.Size(90, 25)
        Me.btn_TriggerNow.TabIndex = 40
        Me.btn_TriggerNow.Text = "trigger now"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 16)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "detection method:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MotionDetection
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.ClientSize = New System.Drawing.Size(1121, 239)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_TriggerNow)
        Me.Controls.Add(Me.chk_GreyScale)
        Me.Controls.Add(Me.chkCompareBlue)
        Me.Controls.Add(Me.chkCompareGreen)
        Me.Controls.Add(Me.chkCompareRed)
        Me.Controls.Add(Me.btnShowGridDialog)
        Me.Controls.Add(Me.chkReduceVideoNoise)
        Me.Controls.Add(Me.chk_triggered)
        Me.Controls.Add(Me.imgMotionDetected)
        Me.Controls.Add(Me.chkMotionDetectionEnabled)
        Me.Controls.Add(Me.grbGridString)
        Me.Controls.Add(Me.Frame13)
        Me.Controls.Add(Me.Frame14)
        Me.Controls.Add(Me.grbXYMaxMotion)
        Me.Controls.Add(Me.grbMotionRatio)
        Me.Controls.Add(Me.mmoSensitivityGrid)
        Me.Controls.Add(Me.mmoMotionGrid)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.lblMotionDetectorRequiresFrameGrabber)
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MotionDetection"
        Me.ShowInTaskbar = False
        CType(Me.imgMotionDetected, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbGridString.ResumeLayout(False)
        Me.grbGridString.PerformLayout()
        CType(Me.updGlobalGridSensitivity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame13.ResumeLayout(False)
        CType(Me.updGridRowCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updGridColCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame14.ResumeLayout(False)
        Me.Frame14.PerformLayout()
        CType(Me.updCellSensitivity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updYCell, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updXCell, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbXYMaxMotion.ResumeLayout(False)
        Me.grbXYMaxMotion.PerformLayout()
        Me.grbMotionRatio.ResumeLayout(False)
        Me.grbMotionRatio.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Public Sub RefreshControls()
        chkMotionDetectionEnabled.Checked = MainForm.DefInstance.VideoGrabber1.MotionDetector_Enabled
        chkCompareRed.Checked = MainForm.DefInstance.VideoGrabber1.MotionDetector_CompareRed
        chkCompareGreen.Checked = MainForm.DefInstance.VideoGrabber1.MotionDetector_CompareGreen
        chkCompareBlue.Checked = MainForm.DefInstance.VideoGrabber1.MotionDetector_CompareBlue
        chk_GreyScale.Checked = MainForm.DefInstance.VideoGrabber1.MotionDetector_GreyScale
        chkReduceVideoNoise.Checked = MainForm.DefInstance.VideoGrabber1.MotionDetector_ReduceVideoNoise
        edtGrid.Text = MainForm.DefInstance.VideoGrabber1.MotionDetector_Grid
        mmoSensitivityGrid.Text = MainForm.DefInstance.VideoGrabber1.MotionDetector_Get2DTextGrid
        updGridColCount.Value = MainForm.DefInstance.VideoGrabber1.MotionDetector_GridXCount
        updGridRowCount.Value = MainForm.DefInstance.VideoGrabber1.MotionDetector_GridYCount
        lblMotionDetectorRequiresFrameGrabber.Visible = IIf(MainForm.DefInstance.VideoGrabber1.FrameGrabber = VidGrab.TFrameGrabber.fg_Disabled, True, False)
    End Sub

    Private Sub btnApplyGridSize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApplyGridSize.Click
        MainForm.DefInstance.VideoGrabber1.MotionDetector_SetGridSize(updGridColCount.Value, updGridRowCount.Value)
        edtGrid.Text = MainForm.DefInstance.VideoGrabber1.MotionDetector_Grid
        mmoSensitivityGrid.Text = MainForm.DefInstance.VideoGrabber1.MotionDetector_Get2DTextGrid
    End Sub

    Private Sub btnSetCellsSensitivity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetCellsSensitivity.Click
        MainForm.DefInstance.VideoGrabber1.MotionDetector_SetCellSensitivity(updXCell.Text, updYCell.Text, updCellSensitivity.Text)
        edtGrid.Text = MainForm.DefInstance.VideoGrabber1.MotionDetector_Grid
        mmoSensitivityGrid.Text = MainForm.DefInstance.VideoGrabber1.MotionDetector_Get2DTextGrid
    End Sub

    Private Sub btnShowGridDialog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowGridDialog.Click
        If (MainForm.DefInstance.VideoGrabber1.CurrentState <> VidGrab.TCurrentState.cs_Preview) And (MainForm.DefInstance.VideoGrabber1.CurrentState <> VidGrab.TCurrentState.cs_Recording) Then
            MsgBox("you should start preview or recording to see the video frame under the grid")
        End If
        If Not MainForm.DefInstance.VideoGrabber1.MotionDetector_Enabled Then
            MsgBox("you should enable the motion detector first (MotionDetector_Enabled = true) to see the video frame under the grid")
        End If
        If (MainForm.DefInstance.VideoGrabber1.MotionDetector_GridXCount > 30) Or (MainForm.DefInstance.VideoGrabber1.MotionDetector_GridYCount > 30) Then
            MsgBox("the grid will be too dense to be edited through the dialog, you should use SetGridCell")
        End If
        MainForm.DefInstance.VideoGrabber1.MotionDetector_ShowGridDialog()
        edtGrid.Text = MainForm.DefInstance.VideoGrabber1.MotionDetector_Grid
        mmoSensitivityGrid.Text = MainForm.DefInstance.VideoGrabber1.MotionDetector_Get2DTextGrid
    End Sub

    Private Sub chk_triggered_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_triggered.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.MotionDetector_Triggered = chk_triggered.Checked
    End Sub

    Private Sub btn_TriggerNow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_TriggerNow.Click
        MainForm.DefInstance.VideoGrabber1.MotionDetector_TriggerNow()
    End Sub

    Private Sub chk_GreyScale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_GreyScale.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.MotionDetector_GreyScale = chk_GreyScale.Checked
    End Sub

    Private Sub chkCompareBlue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCompareBlue.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.MotionDetector_CompareBlue = chkCompareBlue.Checked
    End Sub

    Private Sub chkCompareGreen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCompareGreen.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.MotionDetector_CompareGreen = chkCompareGreen.Checked
    End Sub

    Private Sub chkCompareRed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCompareRed.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.MotionDetector_CompareRed = chkCompareRed.Checked
    End Sub

    Private Sub chkMotionDetectionEnabled_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMotionDetectionEnabled.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.MotionDetector_Enabled = chkMotionDetectionEnabled.Checked
        MainForm.DefInstance.MotionDetected = False
    End Sub

    Private Sub chkReduceVideoNoise_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkReduceVideoNoise.CheckedChanged
        MainForm.DefInstance.VideoGrabber1.MotionDetector_ReduceVideoNoise = chkReduceVideoNoise.Checked
    End Sub

    Private Sub edtGrid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtGrid.TextChanged
        MainForm.DefInstance.VideoGrabber1.MotionDetector_Grid = edtGrid.Text
        With lblGridValid
            If MainForm.DefInstance.VideoGrabber1.MotionDetector_IsGridValid Then
                .Text = "valid"
                .ForeColor = Color.Green
            Else
                .Text = "invalid"
                .ForeColor = Color.Red
            End If
            mmoSensitivityGrid.Text = MainForm.DefInstance.VideoGrabber1.MotionDetector_Get2DTextGrid
        End With
    End Sub

    Private Sub updGlobalGridSensitivity_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updGlobalGridSensitivity.ValueChanged
        If updGlobalGridSensitivity.Value > updGlobalGridSensitivity.Tag Then
            MainForm.DefInstance.VideoGrabber1.MotionDetector_GloballyIncOrDecSensitivity(1)
        Else
            MainForm.DefInstance.VideoGrabber1.MotionDetector_GloballyIncOrDecSensitivity(-1)
        End If
        updGlobalGridSensitivity.Tag = updGlobalGridSensitivity.Value
        edtGrid.Text = MainForm.DefInstance.VideoGrabber1.MotionDetector_Grid
    End Sub

    Private Sub MotionDetection_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Visible Then
            RefreshControls()
        End If
    End Sub

    Private Sub grbMotionRatio_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles grbMotionRatio.Paint
        
        Dim g As Graphics = e.Graphics
        With MainForm.DefInstance
            g.FillEllipse(IIf(.boolMotionRatio, .brushMotionRatio, Brushes.DarkGreen), 10, 20, 15, 15)
            g.DrawEllipse(Pens.Blue, 10, 20, 15, 15)
        End With

    End Sub

End Class
