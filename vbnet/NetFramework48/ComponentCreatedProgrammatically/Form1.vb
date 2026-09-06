Public Class Form1
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents btnCreateComponent As System.Windows.Forms.Button
    Friend WithEvents btnDestroyComponent As System.Windows.Forms.Button
    Friend WithEvents btnStopPreview As System.Windows.Forms.Button
    Friend WithEvents btnStartPreview As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnCreateComponent = New System.Windows.Forms.Button
        Me.btnDestroyComponent = New System.Windows.Forms.Button
        Me.btnStopPreview = New System.Windows.Forms.Button
        Me.btnStartPreview = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnCreateComponent
        '
        Me.btnCreateComponent.Location = New System.Drawing.Point(16, 8)
        Me.btnCreateComponent.Name = "btnCreateComponent"
        Me.btnCreateComponent.Size = New System.Drawing.Size(128, 24)
        Me.btnCreateComponent.TabIndex = 0
        Me.btnCreateComponent.Text = "1. Create component"
        '
        'btnDestroyComponent
        '
        Me.btnDestroyComponent.Location = New System.Drawing.Point(424, 8)
        Me.btnDestroyComponent.Name = "btnDestroyComponent"
        Me.btnDestroyComponent.Size = New System.Drawing.Size(128, 24)
        Me.btnDestroyComponent.TabIndex = 1
        Me.btnDestroyComponent.Text = "4. Destroy component"
        '
        'btnStopPreview
        '
        Me.btnStopPreview.Location = New System.Drawing.Point(288, 8)
        Me.btnStopPreview.Name = "btnStopPreview"
        Me.btnStopPreview.Size = New System.Drawing.Size(128, 24)
        Me.btnStopPreview.TabIndex = 2
        Me.btnStopPreview.Text = "3. Stop preview"
        '
        'btnStartPreview
        '
        Me.btnStartPreview.Location = New System.Drawing.Point(152, 8)
        Me.btnStartPreview.Name = "btnStartPreview"
        Me.btnStartPreview.Size = New System.Drawing.Size(128, 24)
        Me.btnStartPreview.TabIndex = 3
        Me.btnStartPreview.Text = "2. Start preview"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1072, 788)
        Me.Controls.Add(Me.btnStartPreview)
        Me.Controls.Add(Me.btnStopPreview)
        Me.Controls.Add(Me.btnDestroyComponent)
        Me.Controls.Add(Me.btnCreateComponent)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private VideoGrabber As VidGrab.VideoGrabber

    Private Sub OnPreviewStarted(ByVal sender As Object, ByVal e As System.EventArgs)
        MessageBox.Show("preview started")
    End Sub

    Private Sub OnInactive(ByVal sender As Object, ByVal e As System.EventArgs)
        MessageBox.Show("done")
    End Sub

    Private Sub btnCreateComponent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateComponent.Click
        If Me.VideoGrabber Is Nothing Then
            Me.VideoGrabber = New VidGrab.VideoGrabber

            Me.VideoGrabber.Parent = Me
            Me.VideoGrabber.Left = 10
            Me.VideoGrabber.Top = 50
            
            AddHandler VideoGrabber.OnPreviewStarted, AddressOf OnPreviewStarted
            AddHandler VideoGrabber.OnInactive, AddressOf OnInactive
        Else
            MessageBox.Show("already created")
        End If
    End Sub

    Private Sub btnStartPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartPreview.Click
        If Not Me.VideoGrabber Is Nothing Then
            Me.VideoGrabber.StartPreview()
        Else
            MessageBox.Show("first create the component")
        End If
    End Sub

    Private Sub btnStopPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopPreview.Click
        If Not Me.VideoGrabber Is Nothing Then
            Me.VideoGrabber.Stop()
        Else
            MessageBox.Show("first create the component")
        End If
    End Sub

    Private Sub btnDestroyComponent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDestroyComponent.Click
        If Not Me.VideoGrabber Is Nothing Then
            Me.VideoGrabber.Dispose()
            Me.VideoGrabber = Nothing
        Else
            MessageBox.Show("component not yet created")
        End If
    End Sub
End Class
