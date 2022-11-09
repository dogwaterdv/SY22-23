Public Class Form1
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles CylinderTrackBar.Scroll
        CylinderTextBox.Text = CylinderTrackBar.Value
    End Sub

    Private Sub CylinderTextBox_TextChanged(sender As Object, e As EventArgs) Handles CylinderTextBox.TextChanged
        Dim cylinder As Integer
        Integer.TryParse(CylinderTextBox.Text, cylinder)



    End Sub
    Function circleArea(r As Integer) As Decimal
        'formula is pie * r squared
        Return r * r * Math.PI
    End Function
End Class
