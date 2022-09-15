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
        Me.porscheButton = New System.Windows.Forms.Button()
        Me.displayPictureBox = New System.Windows.Forms.PictureBox()
        Me.porschePictureBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.namelabel = New System.Windows.Forms.Label()
        Me.topspeedlabel = New System.Windows.Forms.Label()
        Me.costlabel = New System.Windows.Forms.Label()
        Me.porschelabel = New System.Windows.Forms.Label()
        CType(Me.displayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.porschePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'porscheButton
        '
        Me.porscheButton.Location = New System.Drawing.Point(35, 311)
        Me.porscheButton.Name = "porscheButton"
        Me.porscheButton.Size = New System.Drawing.Size(89, 23)
        Me.porscheButton.TabIndex = 0
        Me.porscheButton.Text = "porsche 918"
        Me.porscheButton.UseVisualStyleBackColor = True
        '
        'displayPictureBox
        '
        Me.displayPictureBox.Location = New System.Drawing.Point(0, 1)
        Me.displayPictureBox.Name = "displayPictureBox"
        Me.displayPictureBox.Size = New System.Drawing.Size(265, 129)
        Me.displayPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.displayPictureBox.TabIndex = 1
        Me.displayPictureBox.TabStop = False
        '
        'porschePictureBox
        '
        Me.porschePictureBox.Location = New System.Drawing.Point(27, 354)
        Me.porschePictureBox.Name = "porschePictureBox"
        Me.porschePictureBox.Size = New System.Drawing.Size(97, 36)
        Me.porschePictureBox.TabIndex = 2
        Me.porschePictureBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(288, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(287, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "top speed:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(287, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "cost:"
        '
        'namelabel
        '
        Me.namelabel.AutoSize = True
        Me.namelabel.Location = New System.Drawing.Point(415, 9)
        Me.namelabel.Name = "namelabel"
        Me.namelabel.Size = New System.Drawing.Size(0, 16)
        Me.namelabel.TabIndex = 6
        '
        'topspeedlabel
        '
        Me.topspeedlabel.AutoSize = True
        Me.topspeedlabel.Location = New System.Drawing.Point(415, 63)
        Me.topspeedlabel.Name = "topspeedlabel"
        Me.topspeedlabel.Size = New System.Drawing.Size(48, 16)
        Me.topspeedlabel.TabIndex = 7
        Me.topspeedlabel.Text = "Label4"
        '
        'costlabel
        '
        Me.costlabel.AutoSize = True
        Me.costlabel.Location = New System.Drawing.Point(415, 114)
        Me.costlabel.Name = "costlabel"
        Me.costlabel.Size = New System.Drawing.Size(48, 16)
        Me.costlabel.TabIndex = 8
        Me.costlabel.Text = "Label4"
        '
        'porschelabel
        '
        Me.porschelabel.AutoSize = True
        Me.porschelabel.Location = New System.Drawing.Point(415, 9)
        Me.porschelabel.Name = "porschelabel"
        Me.porschelabel.Size = New System.Drawing.Size(48, 16)
        Me.porschelabel.TabIndex = 9
        Me.porschelabel.Text = "Label4"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.porschelabel)
        Me.Controls.Add(Me.costlabel)
        Me.Controls.Add(Me.topspeedlabel)
        Me.Controls.Add(Me.namelabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.porschePictureBox)
        Me.Controls.Add(Me.displayPictureBox)
        Me.Controls.Add(Me.porscheButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.displayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.porschePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents porscheButton As Button
    Friend WithEvents displayPictureBox As PictureBox
    Friend WithEvents porschePictureBox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents namelabel As Label
    Friend WithEvents costlabel As Label
    Friend WithEvents topspeedlabel As Label
    Friend WithEvents porschelabel As Label
End Class
