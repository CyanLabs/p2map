<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Splash))
        Me.PRGSplash = New System.Windows.Forms.ProgressBar()
        Me.IMGSplash = New System.Windows.Forms.PictureBox()
        Me.TMRSplash = New System.Windows.Forms.Timer(Me.components)
        Me.LBLVersion = New System.Windows.Forms.Label()
        CType(Me.IMGSplash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PRGSplash
        '
        Me.PRGSplash.BackColor = System.Drawing.SystemColors.Control
        Me.PRGSplash.Location = New System.Drawing.Point(164, 117)
        Me.PRGSplash.MarqueeAnimationSpeed = 10
        Me.PRGSplash.Name = "PRGSplash"
        Me.PRGSplash.Size = New System.Drawing.Size(219, 13)
        Me.PRGSplash.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.PRGSplash.TabIndex = 0
        '
        'IMGSplash
        '
        Me.IMGSplash.BackColor = System.Drawing.Color.Transparent
        Me.IMGSplash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IMGSplash.Image = CType(resources.GetObject("IMGSplash.Image"), System.Drawing.Image)
        Me.IMGSplash.InitialImage = CType(resources.GetObject("IMGSplash.InitialImage"), System.Drawing.Image)
        Me.IMGSplash.Location = New System.Drawing.Point(0, 0)
        Me.IMGSplash.Name = "IMGSplash"
        Me.IMGSplash.Size = New System.Drawing.Size(456, 132)
        Me.IMGSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.IMGSplash.TabIndex = 1
        Me.IMGSplash.TabStop = False
        '
        'TMRSplash
        '
        Me.TMRSplash.Interval = 3000
        '
        'LBLVersion
        '
        Me.LBLVersion.AutoSize = True
        Me.LBLVersion.BackColor = System.Drawing.Color.Black
        Me.LBLVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLVersion.ForeColor = System.Drawing.Color.White
        Me.LBLVersion.Location = New System.Drawing.Point(66, 115)
        Me.LBLVersion.Name = "LBLVersion"
        Me.LBLVersion.Size = New System.Drawing.Size(92, 15)
        Me.LBLVersion.TabIndex = 2
        Me.LBLVersion.Text = "version X.X.X"
        Me.LBLVersion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(456, 132)
        Me.ControlBox = False
        Me.Controls.Add(Me.LBLVersion)
        Me.Controls.Add(Me.PRGSplash)
        Me.Controls.Add(Me.IMGSplash)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Splash"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        CType(Me.IMGSplash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PRGSplash As System.Windows.Forms.ProgressBar
    Friend WithEvents IMGSplash As System.Windows.Forms.PictureBox
    Friend WithEvents TMRSplash As System.Windows.Forms.Timer
    Friend WithEvents LBLVersion As System.Windows.Forms.Label

End Class
