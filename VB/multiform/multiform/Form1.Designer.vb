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
        Me.ATextBox = New System.Windows.Forms.TextBox()
        Me.BTextBox = New System.Windows.Forms.TextBox()
        Me.CTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Getvalues = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ATextBox
        '
        Me.ATextBox.Location = New System.Drawing.Point(287, 80)
        Me.ATextBox.Name = "ATextBox"
        Me.ATextBox.Size = New System.Drawing.Size(100, 22)
        Me.ATextBox.TabIndex = 0
        '
        'BTextBox
        '
        Me.BTextBox.Location = New System.Drawing.Point(287, 196)
        Me.BTextBox.Name = "BTextBox"
        Me.BTextBox.Size = New System.Drawing.Size(100, 22)
        Me.BTextBox.TabIndex = 1
        '
        'CTextBox
        '
        Me.CTextBox.Location = New System.Drawing.Point(287, 302)
        Me.CTextBox.Name = "CTextBox"
        Me.CTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(157, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(157, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(157, 308)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Label3"
        '
        'Getvalues
        '
        Me.Getvalues.Location = New System.Drawing.Point(455, 78)
        Me.Getvalues.Name = "Getvalues"
        Me.Getvalues.Size = New System.Drawing.Size(89, 26)
        Me.Getvalues.TabIndex = 6
        Me.Getvalues.Text = "Get Values"
        Me.Getvalues.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(455, 301)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Form2"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(455, 195)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Form3"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 533)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Getvalues)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CTextBox)
        Me.Controls.Add(Me.BTextBox)
        Me.Controls.Add(Me.ATextBox)
        Me.Name = "Form1"
        Me.Text = "Multiform"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ATextBox As TextBox
    Friend WithEvents BTextBox As TextBox
    Friend WithEvents CTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Getvalues As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
