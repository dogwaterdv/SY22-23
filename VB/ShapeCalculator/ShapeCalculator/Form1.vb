Public Class Form1
    Private Sub calculate()
        Dim length As Integer
        Dim width As Integer
        Integer.TryParse(LengthTextBox.Text, length)
        Integer.TryParse(WidthTextBox.Text, width)
        AreaTextBox.Text = RectangleArea(length, width)
        PerimeterTextBox.Text = RectanglePerimeter(length, width)
    End Sub
    Function RectangleArea(l As Integer, w As Integer) As Integer
    Return l * w
End Function
    Function RectanglePerimeter(l As Integer, w As Integer) As Integer
        Return 2 * l + 2 * w
    End Function

    Private Sub LengthTrackBar_Scroll(sender As Object, e As EventArgs) Handles LengthTrackBar.Scroll
        LengthTextBox.Text = LengthTrackBar.Value
    End Sub

    Private Sub WidthTrackBar_Scroll(sender As Object, e As EventArgs) Handles WidthTrackBar.Scroll
        WidthTextBox.Text = WidthTrackBar.Value
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles WidthTextBox.TextChanged, LengthTextBox.TextChanged
        calculate()
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles radiusTrackBar.Scroll
        RadiusTextBox.Text = radiusTrackBar.Value
    End Sub
    Function circleArea(r As Integer) As Decimal
        Return Math.PI * r * r
    End Function
    Function circumference(r As Integer) As Decimal
        Return Math.PI * 2 * r
    End Function

    Private Sub RadiusTextBox_TextChanged(sender As Object, e As EventArgs) Handles RadiusTextBox.TextChanged
        Dim radius As Integer
        Integer.TryParse(RadiusTextBox.Text, radius)

        circleareaTextBox.Text = circleArea(radius).ToString("N2")
        circumferenceTextBox.Text = circumference(radius).ToString("N2")
    End Sub
End Class
