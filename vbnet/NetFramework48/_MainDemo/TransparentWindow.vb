Public Class TransparentWindow
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
    Friend WithEvents TransparentLabel As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TransparentLabel = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'TransparentLabel
        '
        Me.TransparentLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TransparentLabel.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransparentLabel.Location = New System.Drawing.Point(19, 37)
        Me.TransparentLabel.Name = "TransparentLabel"
        Me.TransparentLabel.Size = New System.Drawing.Size(409, 46)
        Me.TransparentLabel.TabIndex = 1
        Me.TransparentLabel.Text = "transparent window"
        Me.TransparentLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TransparentWindow
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(448, 100)
        Me.Controls.Add(Me.TransparentLabel)
        Me.Name = "TransparentWindow"
        Me.Text = "transparent window"
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
