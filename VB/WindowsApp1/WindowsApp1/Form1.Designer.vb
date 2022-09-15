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
        Me.totalTextBox = New System.Windows.Forms.TextBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.grandTotalLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'totalTextBox
        '
        Me.totalTextBox.Location = New System.Drawing.Point(306, 216)
        Me.totalTextBox.Name = "totalTextBox"
        Me.totalTextBox.Size = New System.Drawing.Size(100, 22)
        Me.totalTextBox.TabIndex = 0
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(306, 178)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(75, 23)
        Me.calcButton.TabIndex = 1
        Me.calcButton.Text = "Button1"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'grandTotalLabel
        '
        Me.grandTotalLabel.AutoSize = True
        Me.grandTotalLabel.Location = New System.Drawing.Point(303, 255)
        Me.grandTotalLabel.Name = "grandTotalLabel"
        Me.grandTotalLabel.Size = New System.Drawing.Size(48, 16)
        Me.grandTotalLabel.TabIndex = 2
        Me.grandTotalLabel.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grandTotalLabel)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.totalTextBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents totalTextBox As TextBox
    Friend WithEvents calcButton As Button
    Friend WithEvents grandTotalLabel As Label
End Class
