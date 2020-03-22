Partial Class RatingPickerControl
    Inherits System.Windows.Forms.Panel

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Star1 = New System.Windows.Forms.PictureBox
        Me.Star2 = New System.Windows.Forms.PictureBox
        Me.Star3 = New System.Windows.Forms.PictureBox
        Me.Star4 = New System.Windows.Forms.PictureBox
        Me.Star5 = New System.Windows.Forms.PictureBox
        CType(Me.Star1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Star2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Star3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Star4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Star5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Star1
        '
        Me.Star1.Location = New System.Drawing.Point(0, 0)
        Me.Star1.Name = "Star1"
        Me.Star1.Size = New System.Drawing.Size(16, 16)
        Me.Star1.TabIndex = 0
        Me.Star1.TabStop = False
        '
        'Star2
        '
        Me.Star2.Location = New System.Drawing.Point(16, 0)
        Me.Star2.Name = "Star2"
        Me.Star2.Size = New System.Drawing.Size(16, 16)
        Me.Star2.TabIndex = 1
        Me.Star2.TabStop = False
        '
        'Star3
        '
        Me.Star3.Location = New System.Drawing.Point(32, 0)
        Me.Star3.Name = "Star3"
        Me.Star3.Size = New System.Drawing.Size(16, 16)
        Me.Star3.TabIndex = 2
        Me.Star3.TabStop = False
        '
        'Star4
        '
        Me.Star4.Location = New System.Drawing.Point(48, 0)
        Me.Star4.Name = "Star4"
        Me.Star4.Size = New System.Drawing.Size(16, 16)
        Me.Star4.TabIndex = 3
        Me.Star4.TabStop = False
        '
        'Star5
        '
        Me.Star5.Location = New System.Drawing.Point(64, 0)
        Me.Star5.Name = "Star5"
        Me.Star5.Size = New System.Drawing.Size(16, 16)
        Me.Star5.TabIndex = 4
        Me.Star5.TabStop = False
        '
        'RatingPickerControl
        '
        Me.Controls.Add(Me.Star5)
        Me.Controls.Add(Me.Star4)
        Me.Controls.Add(Me.Star3)
        Me.Controls.Add(Me.Star2)
        Me.Controls.Add(Me.Star1)
        Me.Name = "RatingPickerControl"
        Me.Size = New System.Drawing.Size(80, 16)
        CType(Me.Star1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Star2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Star3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Star4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Star5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Protected Friend WithEvents Star1 As System.Windows.Forms.PictureBox
    Protected Friend WithEvents Star2 As System.Windows.Forms.PictureBox
    Protected Friend WithEvents Star3 As System.Windows.Forms.PictureBox
    Protected Friend WithEvents Star4 As System.Windows.Forms.PictureBox
    Protected Friend WithEvents Star5 As System.Windows.Forms.PictureBox

End Class
