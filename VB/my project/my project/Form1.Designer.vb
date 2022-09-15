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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.nameTextbox = New System.Windows.Forms.TextBox()
        Me.CCTextbox = New System.Windows.Forms.TextBox()
        Me.ExpTextbox = New System.Windows.Forms.TextBox()
        Me.EipTextbox = New System.Windows.Forms.TextBox()
        Me.AmtTextbox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Fee = New System.Windows.Forms.Label()
        Me.Lab = New System.Windows.Forms.Label()
        Me.feeTextbox = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(205, 102)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(190, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(118, 22)
        Me.TextBox1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(595, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(595, 267)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "CC#"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(595, 334)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Exp date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(595, 397)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "zip"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(595, 454)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Amount"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(0, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(72, 16)
        Me.LinkLabel1.TabIndex = 10
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "LinkLabel1"
        '
        'nameTextbox
        '
        Me.nameTextbox.Location = New System.Drawing.Point(656, 205)
        Me.nameTextbox.Name = "nameTextbox"
        Me.nameTextbox.Size = New System.Drawing.Size(100, 22)
        Me.nameTextbox.TabIndex = 11
        '
        'CCTextbox
        '
        Me.CCTextbox.Location = New System.Drawing.Point(656, 267)
        Me.CCTextbox.Name = "CCTextbox"
        Me.CCTextbox.Size = New System.Drawing.Size(100, 22)
        Me.CCTextbox.TabIndex = 12
        '
        'ExpTextbox
        '
        Me.ExpTextbox.Location = New System.Drawing.Point(656, 334)
        Me.ExpTextbox.Name = "ExpTextbox"
        Me.ExpTextbox.Size = New System.Drawing.Size(100, 22)
        Me.ExpTextbox.TabIndex = 13
        '
        'EipTextbox
        '
        Me.EipTextbox.Location = New System.Drawing.Point(656, 394)
        Me.EipTextbox.Name = "EipTextbox"
        Me.EipTextbox.Size = New System.Drawing.Size(100, 22)
        Me.EipTextbox.TabIndex = 14
        '
        'AmtTextbox
        '
        Me.AmtTextbox.Location = New System.Drawing.Point(656, 448)
        Me.AmtTextbox.Name = "AmtTextbox"
        Me.AmtTextbox.Size = New System.Drawing.Size(100, 22)
        Me.AmtTextbox.TabIndex = 15
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(99, 102)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(69, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "buy"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.my_project.My.Resources.Resources.paypal
        Me.PictureBox1.Location = New System.Drawing.Point(35, 176)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(440, 113)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Fee
        '
        Me.Fee.AutoSize = True
        Me.Fee.Location = New System.Drawing.Point(865, 208)
        Me.Fee.Name = "Fee"
        Me.Fee.Size = New System.Drawing.Size(0, 16)
        Me.Fee.TabIndex = 18
        '
        'Lab
        '
        Me.Lab.AutoSize = True
        Me.Lab.Location = New System.Drawing.Point(865, 205)
        Me.Lab.Name = "Lab"
        Me.Lab.Size = New System.Drawing.Size(31, 16)
        Me.Lab.TabIndex = 19
        Me.Lab.Text = "Fee"
        '
        'feeTextbox
        '
        Me.feeTextbox.Location = New System.Drawing.Point(920, 201)
        Me.feeTextbox.Name = "feeTextbox"
        Me.feeTextbox.Size = New System.Drawing.Size(100, 22)
        Me.feeTextbox.TabIndex = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1233, 502)
        Me.Controls.Add(Me.feeTextbox)
        Me.Controls.Add(Me.Lab)
        Me.Controls.Add(Me.Fee)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.AmtTextbox)
        Me.Controls.Add(Me.EipTextbox)
        Me.Controls.Add(Me.ExpTextbox)
        Me.Controls.Add(Me.CCTextbox)
        Me.Controls.Add(Me.nameTextbox)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents nameTextbox As TextBox
    Friend WithEvents CCTextbox As TextBox
    Friend WithEvents ExpTextbox As TextBox
    Friend WithEvents EipTextbox As TextBox
    Friend WithEvents AmtTextbox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Fee As Label
    Friend WithEvents Lab As Label
    Friend WithEvents feeTextbox As TextBox
End Class
