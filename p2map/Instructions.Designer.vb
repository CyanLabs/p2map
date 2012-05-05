<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Instructions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Instructions))
        Me.RTBInstructions = New System.Windows.Forms.RichTextBox()
        Me.BTNCloseInstructions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RTBInstructions
        '
        Me.RTBInstructions.Dock = System.Windows.Forms.DockStyle.Top
        Me.RTBInstructions.Location = New System.Drawing.Point(0, 0)
        Me.RTBInstructions.Name = "RTBInstructions"
        Me.RTBInstructions.ReadOnly = True
        Me.RTBInstructions.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.RTBInstructions.Size = New System.Drawing.Size(222, 193)
        Me.RTBInstructions.TabIndex = 0
        Me.RTBInstructions.Text = resources.GetString("RTBInstructions.Text")
        Me.RTBInstructions.WordWrap = False
        '
        'BTNCloseInstructions
        '
        Me.BTNCloseInstructions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BTNCloseInstructions.Location = New System.Drawing.Point(0, 188)
        Me.BTNCloseInstructions.Name = "BTNCloseInstructions"
        Me.BTNCloseInstructions.Size = New System.Drawing.Size(222, 23)
        Me.BTNCloseInstructions.TabIndex = 1
        Me.BTNCloseInstructions.Text = "Close Instructions"
        Me.BTNCloseInstructions.UseVisualStyleBackColor = True
        '
        'Instructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(222, 211)
        Me.ControlBox = False
        Me.Controls.Add(Me.BTNCloseInstructions)
        Me.Controls.Add(Me.RTBInstructions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Instructions"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Instructions"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RTBInstructions As System.Windows.Forms.RichTextBox
    Friend WithEvents BTNCloseInstructions As System.Windows.Forms.Button
End Class
