Option Strict Off
Option Explicit On
Friend Class SnapForm
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
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents SnapImage As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SnapImage = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'SnapImage
        '
        Me.SnapImage.Location = New System.Drawing.Point(8, 8)
        Me.SnapImage.Name = "SnapImage"
        Me.SnapImage.Size = New System.Drawing.Size(288, 224)
        Me.SnapImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.SnapImage.TabIndex = 0
        Me.SnapImage.TabStop = False
        '
        'SnapForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(299, 237)
        Me.Controls.Add(Me.SnapImage)
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "SnapForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Captured frame"
        Me.ResumeLayout(False)

    End Sub
#End Region

    ' this form is invoked by the OnFrameCaptureCompleted event to display the captured frame

    Private Sub SnapImage_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles SnapImage.Resize
        Me.Width = SnapImage.Width + 25
        Me.Height = SnapImage.Height + 40
    End Sub
End Class