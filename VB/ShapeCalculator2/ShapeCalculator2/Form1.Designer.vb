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
        Me.ScaleAreaTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.volumeTextBox = New System.Windows.Forms.TextBox()
        Me.heightTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CylinderTrackBar = New System.Windows.Forms.TrackBar()
        Me.areaTextBox = New System.Windows.Forms.TextBox()
        Me.CylinderTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.CylinderTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(105, 104)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(530, 293)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ScaleAreaTextBox)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.volumeTextBox)
        Me.TabPage1.Controls.Add(Me.heightTextBox)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.CylinderTrackBar)
        Me.TabPage1.Controls.Add(Me.areaTextBox)
        Me.TabPage1.Controls.Add(Me.CylinderTextBox)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(522, 264)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ScaleAreaTextBox
        '
        Me.ScaleAreaTextBox.Location = New System.Drawing.Point(326, 164)
        Me.ScaleAreaTextBox.Name = "ScaleAreaTextBox"
        Me.ScaleAreaTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ScaleAreaTextBox.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(242, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ScaleArea"
        '
        'volumeTextBox
        '
        Me.volumeTextBox.Location = New System.Drawing.Point(112, 165)
        Me.volumeTextBox.Name = "volumeTextBox"
        Me.volumeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.volumeTextBox.TabIndex = 8
        '
        'heightTextBox
        '
        Me.heightTextBox.Location = New System.Drawing.Point(111, 205)
        Me.heightTextBox.Name = "heightTextBox"
        Me.heightTextBox.Size = New System.Drawing.Size(100, 22)
        Me.heightTextBox.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "volume"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Height"
        '
        'CylinderTrackBar
        '
        Me.CylinderTrackBar.Location = New System.Drawing.Point(167, 51)
        Me.CylinderTrackBar.Name = "CylinderTrackBar"
        Me.CylinderTrackBar.Size = New System.Drawing.Size(104, 56)
        Me.CylinderTrackBar.TabIndex = 4
        '
        'areaTextBox
        '
        Me.areaTextBox.Location = New System.Drawing.Point(284, 208)
        Me.areaTextBox.Name = "areaTextBox"
        Me.areaTextBox.Size = New System.Drawing.Size(100, 22)
        Me.areaTextBox.TabIndex = 3
        '
        'CylinderTextBox
        '
        Me.CylinderTextBox.Location = New System.Drawing.Point(167, 23)
        Me.CylinderTextBox.Name = "CylinderTextBox"
        Me.CylinderTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CylinderTextBox.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(242, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Area"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(105, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cylinder"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(522, 264)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
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
        CType(Me.CylinderTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents CylinderTrackBar As TrackBar
    Friend WithEvents areaTextBox As TextBox
    Friend WithEvents CylinderTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents volumeTextBox As TextBox
    Friend WithEvents heightTextBox As TextBox
    Friend WithEvents ScaleAreaTextBox As TextBox
    Friend WithEvents Label5 As Label
End Class
