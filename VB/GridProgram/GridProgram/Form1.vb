Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For row = 0 To 40
            For col = 0 To 40
                CreatePicture(PictureBox1, row, col)
            Next
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For row = 0 To 40
            For col = 0 To 40
                GetPicture(row, col).BackColor = Color.Green
            Next
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For row = 0 To 20
            For col = 0 To 40
                GetPicture(row, col).BackColor = Color.Blue

            Next

        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For row = 0 To 40
            For col = 0 To 20
                GetPicture(row, col).BackColor = Color.Red

            Next

        Next

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For row = 0 To 40 Step 2
            For col = 0 To 20
                GetPicture(row, col).BackColor = Color.Yellow
            Next
        Next

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        For row = 0 To 40 Step 2
            For col = 0 To 40 Step 2
                GetPicture(row, col).BackColor = Color.Red
            Next
        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        For row = 0 To 40
            For col = 0 To 40
                If col < row Then
                    GetPicture(row, col).BackColor = Color.Aqua
                End If
            Next
        Next

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ColorDialog1.showdialog()
        sender.Backcolor = ColorDialog1.Color
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        For row = 0 To 40
            For col = 0 To 40
                If row < col Then
                    GetPicture(row, col).BackColor = Color.Yellow
                End If
            Next
        Next
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        For row = 0 To 15
            For col = 0 To 18
                GetPicture(row, col).BackColor = Color.Purple
            Next
        Next
    End Sub

    Private Sub picture_Click(sender As Object, e As EventArgs) Handles picture.Click
        GetPicture(5, 5).BackColor = Color.Pink
        GetPicture(4, 5).BackColor = Color.Pink
        GetPicture(3, 5).BackColor = Color.Pink
        GetPicture(2, 5).BackColor = Color.Pink
        GetPicture(20, 8).BackColor = Color.Pink
        GetPicture(20, 9).BackColor = Color.Pink
        GetPicture(20, 10).BackColor = Color.Pink
        GetPicture(20, 11).BackColor = Color.Pink
        GetPicture(20, 12).BackColor = Color.Pink
        GetPicture(20, 13).BackColor = Color.Pink
        GetPicture(20, 14).BackColor = Color.Pink
        GetPicture(20, 15).BackColor = Color.Pink
        GetPicture(20, 16).BackColor = Color.Pink
        GetPicture(20, 17).BackColor = Color.Pink
        GetPicture(20, 18).BackColor = Color.Pink
        GetPicture(20, 19).BackColor = Color.Pink
        GetPicture(20, 20).BackColor = Color.Pink
        GetPicture(20, 21).BackColor = Color.Pink
        GetPicture(20, 22).BackColor = Color.Pink
        GetPicture(20, 23).BackColor = Color.Pink
        GetPicture(20, 24).BackColor = Color.Pink
        GetPicture(20, 25).BackColor = Color.Pink
        GetPicture(20, 26).BackColor = Color.Pink
        GetPicture(20, 27).BackColor = Color.Pink
        GetPicture(20, 28).BackColor = Color.Pink
        GetPicture(3, 30).BackColor = Color.Pink
        GetPicture(5, 30).BackColor = Color.Pink
        GetPicture(6, 30).BackColor = Color.Pink
        GetPicture(7, 30).BackColor = Color.Pink





    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        For col = 1 To 30
            For row = 0 To 35
                GetPicture(row, col).BackColor = Color.Black
            Next
        Next
    End Sub
End Class
