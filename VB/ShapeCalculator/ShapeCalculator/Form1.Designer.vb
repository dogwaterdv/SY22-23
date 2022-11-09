<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.WidthTrackBar = New System.Windows.Forms.TrackBar()
        Me.LengthTrackBar = New System.Windows.Forms.TrackBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PerimeterTextBox = New System.Windows.Forms.TextBox()
        Me.AreaTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.WidthTextBox = New System.Windows.Forms.TextBox()
        Me.LengthTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SurfaceAreaTextBox = New System.Windows.Forms.TextBox()
        Me.VolumeTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.radiusTrackBar = New System.Windows.Forms.TrackBar()
        Me.circumferenceTextBox = New System.Windows.Forms.TextBox()
        Me.circleareaTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RadiusTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.WidthTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LengthTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.radiusTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(112, 46)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(572, 326)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.WidthTrackBar)
        Me.TabPage1.Controls.Add(Me.LengthTrackBar)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.PerimeterTextBox)
        Me.TabPage1.Controls.Add(Me.AreaTextBox)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.WidthTextBox)
        Me.TabPage1.Controls.Add(Me.LengthTextBox)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(564, 297)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Rectangle"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'WidthTrackBar
        '
        Me.WidthTrackBar.Location = New System.Drawing.Point(331, 43)
        Me.WidthTrackBar.Name = "WidthTrackBar"
        Me.WidthTrackBar.Size = New System.Drawing.Size(104, 56)
        Me.WidthTrackBar.TabIndex = 10
        '
        'LengthTrackBar
        '
        Me.LengthTrackBar.Location = New System.Drawing.Point(72, 43)
        Me.LengthTrackBar.Name = "LengthTrackBar"
        Me.LengthTrackBar.Size = New System.Drawing.Size(98, 56)
        Me.LengthTrackBar.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "perimeter"
        '
        'PerimeterTextBox
        '
        Me.PerimeterTextBox.Location = New System.Drawing.Point(73, 156)
        Me.PerimeterTextBox.Name = "PerimeterTextBox"
        Me.PerimeterTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PerimeterTextBox.TabIndex = 6
        '
        'AreaTextBox
        '
        Me.AreaTextBox.Location = New System.Drawing.Point(74, 113)
        Me.AreaTextBox.Name = "AreaTextBox"
        Me.AreaTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AreaTextBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Area"
        '
        'WidthTextBox
        '
        Me.WidthTextBox.Location = New System.Drawing.Point(331, 12)
        Me.WidthTextBox.Name = "WidthTextBox"
        Me.WidthTextBox.Size = New System.Drawing.Size(100, 22)
        Me.WidthTextBox.TabIndex = 3
        '
        'LengthTextBox
        '
        Me.LengthTextBox.Location = New System.Drawing.Point(72, 15)
        Me.LengthTextBox.Name = "LengthTextBox"
        Me.LengthTextBox.Size = New System.Drawing.Size(100, 22)
        Me.LengthTextBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(274, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Width"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Length"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SurfaceAreaTextBox)
        Me.TabPage2.Controls.Add(Me.VolumeTextBox)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.radiusTrackBar)
        Me.TabPage2.Controls.Add(Me.circumferenceTextBox)
        Me.TabPage2.Controls.Add(Me.circleareaTextBox)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.RadiusTextBox)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(564, 297)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Cirlce"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SurfaceAreaTextBox
        '
        Me.SurfaceAreaTextBox.Location = New System.Drawing.Point(376, 210)
        Me.SurfaceAreaTextBox.Name = "SurfaceAreaTextBox"
        Me.SurfaceAreaTextBox.Size = New System.Drawing.Size(100, 22)
        Me.SurfaceAreaTextBox.TabIndex = 10
        '
        'VolumeTextBox
        '
        Me.VolumeTextBox.Location = New System.Drawing.Point(352, 150)
        Me.VolumeTextBox.Name = "VolumeTextBox"
        Me.VolumeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.VolumeTextBox.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(274, 210)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Surface Area:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(274, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Volume:"
        '
        'radiusTrackBar
        '
        Me.radiusTrackBar.Location = New System.Drawing.Point(120, 70)
        Me.radiusTrackBar.Name = "radiusTrackBar"
        Me.radiusTrackBar.Size = New System.Drawing.Size(104, 56)
        Me.radiusTrackBar.TabIndex = 6
        '
        'circumferenceTextBox
        '
        Me.circumferenceTextBox.Location = New System.Drawing.Point(120, 204)
        Me.circumferenceTextBox.Name = "circumferenceTextBox"
        Me.circumferenceTextBox.Size = New System.Drawing.Size(100, 22)
        Me.circumferenceTextBox.TabIndex = 5
        '
        'circleareaTextBox
        '
        Me.circleareaTextBox.Location = New System.Drawing.Point(124, 157)
        Me.circleareaTextBox.Name = "circleareaTextBox"
        Me.circleareaTextBox.Size = New System.Drawing.Size(100, 22)
        Me.circleareaTextBox.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 16)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Perimeter:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(53, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Area:"
        '
        'RadiusTextBox
        '
        Me.RadiusTextBox.Location = New System.Drawing.Point(120, 30)
        Me.RadiusTextBox.Name = "RadiusTextBox"
        Me.RadiusTextBox.Size = New System.Drawing.Size(100, 22)
        Me.RadiusTextBox.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Radius:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.WidthTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LengthTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.radiusTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents PerimeterTextBox As TextBox
    Friend WithEvents AreaTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents WidthTextBox As TextBox
    Friend WithEvents LengthTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents WidthTrackBar As TrackBar
    Friend WithEvents LengthTrackBar As TrackBar
    Friend WithEvents circumferenceTextBox As TextBox
    Friend WithEvents circleareaTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents RadiusTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents radiusTrackBar As TrackBar
    Friend WithEvents SurfaceAreaTextBox As TextBox
    Friend WithEvents VolumeTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
End Class
