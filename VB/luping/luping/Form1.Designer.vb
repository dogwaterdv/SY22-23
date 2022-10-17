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
        Me.components = New System.ComponentModel.Container()
        Me.Player = New System.Windows.Forms.PictureBox()
        Me.badguy1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.badguy1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Player
        '
        Me.Player.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Player.Location = New System.Drawing.Point(239, 155)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(100, 50)
        Me.Player.TabIndex = 0
        Me.Player.TabStop = False
        '
        'badguy1
        '
        Me.badguy1.Image = Global.luping.My.Resources.Resources.artworks_fV8CSqFpytuhzibu_KCvoIg_t500x500
        Me.badguy1.Location = New System.Drawing.Point(12, 26)
        Me.badguy1.Name = "badguy1"
        Me.badguy1.Size = New System.Drawing.Size(100, 73)
        Me.badguy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.badguy1.TabIndex = 1
        Me.badguy1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(710, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "forloop"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.badguy1)
        Me.Controls.Add(Me.Player)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.badguy1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Player As PictureBox
    Friend WithEvents badguy1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
End Class
