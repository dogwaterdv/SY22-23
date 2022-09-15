Public Class Form1
    Dim num1 As Decimal
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button11.Click, Button10.Click, Button1.Click
        displayTextbox.Text = displayTextbox.Text + sender.text
    End Sub

    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles Button12.Click
        displayTextbox.Clear()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Decimal.TryParse(displayTextbox.Text, num1)
        If Oper Then
            displayTextbox.Clear()
    End Sub
End Class
