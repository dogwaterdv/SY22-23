Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim age As Integer
        Integer.TryParse(TextBox1.Text, age)
        Label.Text = age
        If age > 17 Then
            Label1.Text = "you can write"
            Label1.Text = "you cant write"


        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Label1.Text = "thanks for donating"
        Else
            Label1.Text
        End If
    End Sub
End Class
