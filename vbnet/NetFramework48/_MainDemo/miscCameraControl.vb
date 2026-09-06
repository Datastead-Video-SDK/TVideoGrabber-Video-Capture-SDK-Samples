Friend Class miscCameraControl
    Inherits Form


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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbrZoom As System.Windows.Forms.TrackBar
    Friend WithEvents tbrIris As System.Windows.Forms.TrackBar
    Friend WithEvents tbrExposure As System.Windows.Forms.TrackBar
    Friend WithEvents tbrFocus As System.Windows.Forms.TrackBar
    Friend WithEvents tbrTilt As System.Windows.Forms.TrackBar
    Friend WithEvents tbrRoll As System.Windows.Forms.TrackBar
    Friend WithEvents tbrPan As System.Windows.Forms.TrackBar
    Friend WithEvents btnZoom As System.Windows.Forms.Button
    Friend WithEvents btnPan As System.Windows.Forms.Button
    Friend WithEvents btnTilt As System.Windows.Forms.Button
    Friend WithEvents btnRoll As System.Windows.Forms.Button
    Friend WithEvents btnExposure As System.Windows.Forms.Button
    Friend WithEvents btnIris As System.Windows.Forms.Button
    Friend WithEvents btnFocus As System.Windows.Forms.Button
    Friend WithEvents chkZoom As System.Windows.Forms.CheckBox
    Friend WithEvents chkPan As System.Windows.Forms.CheckBox
    Friend WithEvents chkTilt As System.Windows.Forms.CheckBox
    Friend WithEvents chkRoll As System.Windows.Forms.CheckBox
    Friend WithEvents chkExposure As System.Windows.Forms.CheckBox
    Friend WithEvents chkIris As System.Windows.Forms.CheckBox
    Friend WithEvents chkFocus As System.Windows.Forms.CheckBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.tbrZoom = New System.Windows.Forms.TrackBar
        Me.tbrIris = New System.Windows.Forms.TrackBar
        Me.tbrExposure = New System.Windows.Forms.TrackBar
        Me.tbrFocus = New System.Windows.Forms.TrackBar
        Me.tbrTilt = New System.Windows.Forms.TrackBar
        Me.tbrRoll = New System.Windows.Forms.TrackBar
        Me.tbrPan = New System.Windows.Forms.TrackBar
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnZoom = New System.Windows.Forms.Button
        Me.btnPan = New System.Windows.Forms.Button
        Me.btnTilt = New System.Windows.Forms.Button
        Me.btnRoll = New System.Windows.Forms.Button
        Me.btnExposure = New System.Windows.Forms.Button
        Me.btnIris = New System.Windows.Forms.Button
        Me.btnFocus = New System.Windows.Forms.Button
        Me.chkZoom = New System.Windows.Forms.CheckBox
        Me.chkPan = New System.Windows.Forms.CheckBox
        Me.chkTilt = New System.Windows.Forms.CheckBox
        Me.chkRoll = New System.Windows.Forms.CheckBox
        Me.chkExposure = New System.Windows.Forms.CheckBox
        Me.chkIris = New System.Windows.Forms.CheckBox
        Me.chkFocus = New System.Windows.Forms.CheckBox
        Me.btnClose = New System.Windows.Forms.Button
        CType(Me.tbrZoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrIris, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrExposure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrFocus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrTilt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrRoll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrPan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbrZoom
        '
        Me.tbrZoom.Location = New System.Drawing.Point(29, 28)
        Me.tbrZoom.Name = "tbrZoom"
        Me.tbrZoom.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbrZoom.Size = New System.Drawing.Size(56, 212)
        Me.tbrZoom.TabIndex = 0
        Me.tbrZoom.Tag = "0"
        Me.tbrZoom.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'tbrIris
        '
        Me.tbrIris.Location = New System.Drawing.Point(365, 28)
        Me.tbrIris.Name = "tbrIris"
        Me.tbrIris.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbrIris.Size = New System.Drawing.Size(56, 212)
        Me.tbrIris.TabIndex = 1
        Me.tbrIris.Tag = "5"
        Me.tbrIris.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'tbrExposure
        '
        Me.tbrExposure.Location = New System.Drawing.Point(298, 28)
        Me.tbrExposure.Name = "tbrExposure"
        Me.tbrExposure.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbrExposure.Size = New System.Drawing.Size(56, 212)
        Me.tbrExposure.TabIndex = 2
        Me.tbrExposure.Tag = "4"
        Me.tbrExposure.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'tbrFocus
        '
        Me.tbrFocus.Location = New System.Drawing.Point(432, 28)
        Me.tbrFocus.Name = "tbrFocus"
        Me.tbrFocus.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbrFocus.Size = New System.Drawing.Size(56, 212)
        Me.tbrFocus.TabIndex = 3
        Me.tbrFocus.Tag = "6"
        Me.tbrFocus.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'tbrTilt
        '
        Me.tbrTilt.Location = New System.Drawing.Point(163, 28)
        Me.tbrTilt.Name = "tbrTilt"
        Me.tbrTilt.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbrTilt.Size = New System.Drawing.Size(56, 212)
        Me.tbrTilt.TabIndex = 4
        Me.tbrTilt.Tag = "2"
        Me.tbrTilt.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'tbrRoll
        '
        Me.tbrRoll.Location = New System.Drawing.Point(230, 28)
        Me.tbrRoll.Name = "tbrRoll"
        Me.tbrRoll.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbrRoll.Size = New System.Drawing.Size(56, 212)
        Me.tbrRoll.TabIndex = 5
        Me.tbrRoll.Tag = "3"
        Me.tbrRoll.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'tbrPan
        '
        Me.tbrPan.Location = New System.Drawing.Point(96, 28)
        Me.tbrPan.Name = "tbrPan"
        Me.tbrPan.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbrPan.Size = New System.Drawing.Size(56, 212)
        Me.tbrPan.TabIndex = 6
        Me.tbrPan.Tag = "1"
        Me.tbrPan.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(106, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "pan"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(182, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "tilt"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(240, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "roll"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(288, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "exposure"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(384, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "iris"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(442, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 19)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "focus"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(38, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 19)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "zoom"
        '
        'btnZoom
        '
        Me.btnZoom.Location = New System.Drawing.Point(29, 249)
        Me.btnZoom.Name = "btnZoom"
        Me.btnZoom.Size = New System.Drawing.Size(68, 32)
        Me.btnZoom.TabIndex = 15
        Me.btnZoom.Tag = "0"
        Me.btnZoom.Text = "default"
        '
        'btnPan
        '
        Me.btnPan.Location = New System.Drawing.Point(96, 249)
        Me.btnPan.Name = "btnPan"
        Me.btnPan.Size = New System.Drawing.Size(69, 32)
        Me.btnPan.TabIndex = 16
        Me.btnPan.Tag = "1"
        Me.btnPan.Text = "default"
        '
        'btnTilt
        '
        Me.btnTilt.Location = New System.Drawing.Point(163, 249)
        Me.btnTilt.Name = "btnTilt"
        Me.btnTilt.Size = New System.Drawing.Size(69, 32)
        Me.btnTilt.TabIndex = 17
        Me.btnTilt.Tag = "2"
        Me.btnTilt.Text = "default"
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(230, 249)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(69, 32)
        Me.btnRoll.TabIndex = 18
        Me.btnRoll.Tag = "3"
        Me.btnRoll.Text = "default"
        '
        'btnExposure
        '
        Me.btnExposure.Location = New System.Drawing.Point(298, 249)
        Me.btnExposure.Name = "btnExposure"
        Me.btnExposure.Size = New System.Drawing.Size(68, 32)
        Me.btnExposure.TabIndex = 19
        Me.btnExposure.Tag = "4"
        Me.btnExposure.Text = "default"
        '
        'btnIris
        '
        Me.btnIris.Location = New System.Drawing.Point(365, 249)
        Me.btnIris.Name = "btnIris"
        Me.btnIris.Size = New System.Drawing.Size(68, 32)
        Me.btnIris.TabIndex = 20
        Me.btnIris.Tag = "5"
        Me.btnIris.Text = "default"
        '
        'btnFocus
        '
        Me.btnFocus.Location = New System.Drawing.Point(432, 249)
        Me.btnFocus.Name = "btnFocus"
        Me.btnFocus.Size = New System.Drawing.Size(69, 32)
        Me.btnFocus.TabIndex = 21
        Me.btnFocus.Tag = "6"
        Me.btnFocus.Text = "default"
        '
        'chkZoom
        '
        Me.chkZoom.Location = New System.Drawing.Point(28, 298)
        Me.chkZoom.Name = "chkZoom"
        Me.chkZoom.Size = New System.Drawing.Size(69, 18)
        Me.chkZoom.TabIndex = 22
        Me.chkZoom.Tag = "0"
        Me.chkZoom.Text = "auto"
        '
        'chkPan
        '
        Me.chkPan.Location = New System.Drawing.Point(95, 298)
        Me.chkPan.Name = "chkPan"
        Me.chkPan.Size = New System.Drawing.Size(70, 18)
        Me.chkPan.TabIndex = 23
        Me.chkPan.Tag = "1"
        Me.chkPan.Text = "auto"
        '
        'chkTilt
        '
        Me.chkTilt.Location = New System.Drawing.Point(162, 298)
        Me.chkTilt.Name = "chkTilt"
        Me.chkTilt.Size = New System.Drawing.Size(70, 18)
        Me.chkTilt.TabIndex = 24
        Me.chkTilt.Tag = "2"
        Me.chkTilt.Text = "auto"
        '
        'chkRoll
        '
        Me.chkRoll.Location = New System.Drawing.Point(229, 298)
        Me.chkRoll.Name = "chkRoll"
        Me.chkRoll.Size = New System.Drawing.Size(70, 18)
        Me.chkRoll.TabIndex = 25
        Me.chkRoll.Tag = "3"
        Me.chkRoll.Text = "auto"
        '
        'chkExposure
        '
        Me.chkExposure.Location = New System.Drawing.Point(297, 298)
        Me.chkExposure.Name = "chkExposure"
        Me.chkExposure.Size = New System.Drawing.Size(69, 18)
        Me.chkExposure.TabIndex = 26
        Me.chkExposure.Tag = "4"
        Me.chkExposure.Text = "auto"
        '
        'chkIris
        '
        Me.chkIris.Location = New System.Drawing.Point(364, 298)
        Me.chkIris.Name = "chkIris"
        Me.chkIris.Size = New System.Drawing.Size(69, 18)
        Me.chkIris.TabIndex = 27
        Me.chkIris.Tag = "5"
        Me.chkIris.Text = "auto"
        '
        'chkFocus
        '
        Me.chkFocus.Location = New System.Drawing.Point(431, 298)
        Me.chkFocus.Name = "chkFocus"
        Me.chkFocus.Size = New System.Drawing.Size(70, 18)
        Me.chkFocus.TabIndex = 28
        Me.chkFocus.Tag = "6"
        Me.chkFocus.Text = "auto"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(211, 323)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(87, 28)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "Close"
        '
        'miscCameraControl
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(536, 370)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.chkFocus)
        Me.Controls.Add(Me.chkIris)
        Me.Controls.Add(Me.chkExposure)
        Me.Controls.Add(Me.chkRoll)
        Me.Controls.Add(Me.chkTilt)
        Me.Controls.Add(Me.chkPan)
        Me.Controls.Add(Me.chkZoom)
        Me.Controls.Add(Me.btnFocus)
        Me.Controls.Add(Me.btnIris)
        Me.Controls.Add(Me.btnExposure)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.btnTilt)
        Me.Controls.Add(Me.btnPan)
        Me.Controls.Add(Me.btnZoom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbrPan)
        Me.Controls.Add(Me.tbrRoll)
        Me.Controls.Add(Me.tbrTilt)
        Me.Controls.Add(Me.tbrFocus)
        Me.Controls.Add(Me.tbrExposure)
        Me.Controls.Add(Me.tbrIris)
        Me.Controls.Add(Me.tbrZoom)
        Me.Name = "miscCameraControl"
        Me.Text = "miscCameraControl"
        CType(Me.tbrZoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrIris, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrExposure, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrFocus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrTilt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrRoll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrPan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Structure SettingGroup
        Dim tbrValue As TrackBar
        Dim chkAuto As CheckBox
        Dim btnDefault As Button
    End Structure

    Dim FSettingGroup(7) As SettingGroup

    Public Sub RefreshControls()
        InitTrackBar(chkPan, btnPan, tbrPan, VidGrab.TCameraControl.cc_Pan)
        InitTrackBar(chkTilt, btnTilt, tbrTilt, VidGrab.TCameraControl.cc_Tilt)
        InitTrackBar(chkRoll, btnRoll, tbrRoll, VidGrab.TCameraControl.cc_Roll)
        InitTrackBar(chkZoom, btnZoom, tbrZoom, VidGrab.TCameraControl.cc_Zoom)
        InitTrackBar(chkExposure, btnExposure, tbrExposure, VidGrab.TCameraControl.cc_Exposure)
        InitTrackBar(chkIris, btnIris, tbrIris, VidGrab.TCameraControl.cc_Iris)
        InitTrackBar(chkFocus, btnFocus, tbrFocus, VidGrab.TCameraControl.cc_Focus)
    End Sub

    Private Sub InitTrackBar(ByRef chkAuto As CheckBox, ByRef btnDefault As Button, ByRef tbrValue As TrackBar, ByVal Setting As VidGrab.TCameraControl)

        tbrValue.Tag = Setting

        AddHandler tbrValue.Scroll, AddressOf tbrSetValue
        AddHandler btnDefault.Click, AddressOf btnSetDefault
        AddHandler chkAuto.CheckedChanged, AddressOf tbrSetValue

        tbrValue.Tag = Setting
        chkAuto.Tag = Setting
        btnDefault.Tag = Setting

        FSettingGroup(Setting).tbrValue = tbrValue
        FSettingGroup(Setting).chkAuto = chkAuto
        FSettingGroup(Setting).btnDefault = btnDefault

        If Not MainForm.DefInstance.VideoGrabber1.IsCameraControlSettingAvailable(Setting) Then
            tbrValue.Enabled = False
            tbrValue.TickFrequency = 0
            tbrValue.Minimum = 0
            tbrValue.Maximum = 1
            tbrValue.Value = 1
            chkAuto.Enabled = False
            btnDefault.Enabled = False
        Else
            chkAuto.Enabled = True
            chkAuto.Checked = MainForm.DefInstance.VideoGrabber1.CameraControlAuto(Setting)
            tbrValue.Enabled = Not chkAuto.Checked
            btnDefault.Enabled = Not chkAuto.Checked
            Dim MinValue As Integer = MainForm.DefInstance.VideoGrabber1.CameraControlMin(Setting)
            Dim MaxValue As Integer = MainForm.DefInstance.VideoGrabber1.CameraControlMax(Setting)
            Dim CurrentValue As Integer = MainForm.DefInstance.VideoGrabber1.CameraControlValue(Setting)

            tbrValue.Minimum = MinValue
            tbrValue.Maximum = MaxValue
            tbrValue.Value = CurrentValue
            tbrValue.TickFrequency = MainForm.DefInstance.VideoGrabber1.CameraControlStep(Setting)
        End If
    End Sub

    Private Sub tbrSetValue(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrZoom.Scroll, chkZoom.CheckedChanged

        Dim ct As Control = DirectCast(sender, Control)
        Dim Setting As VidGrab.TCameraControl = DirectCast(ct.Tag, VidGrab.TCameraControl)

        MainForm.DefInstance.VideoGrabber1.SetCameraControl(Setting, FSettingGroup(Setting).chkAuto.Checked, False, FSettingGroup(Setting).tbrValue.Value)
        FSettingGroup(Setting).tbrValue.Enabled = Not FSettingGroup(Setting).chkAuto.Checked
        FSettingGroup(Setting).btnDefault.Enabled = Not FSettingGroup(Setting).chkAuto.Checked
    End Sub

    Private Sub btnSetDefault(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZoom.Click

        Dim ct As Control = DirectCast(sender, Control)
        Dim Setting As VidGrab.TCameraControl = DirectCast(ct.Tag, VidGrab.TCameraControl)

        MainForm.DefInstance.VideoGrabber1.SetCameraControl(Setting, FSettingGroup(Setting).chkAuto.Checked, True, FSettingGroup(Setting).tbrValue.Value)
        FSettingGroup(Setting).tbrValue.Value = MainForm.DefInstance.VideoGrabber1.CameraControlValue(Setting)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub miscCameraControl_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Visible Then
            RefreshControls()
        End If

    End Sub
End Class
