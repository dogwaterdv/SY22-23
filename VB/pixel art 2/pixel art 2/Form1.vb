Imports System.Security.Cryptography.X509Certificates

Public Class Form1
    Private Sub grid_Click(sender As Object, e As EventArgs) Handles grid.Click
        For index = 1 To 100
            Dim p As PictureBox
            p = Controls("picturebox" & index)
            p.BorderStyle = BorderStyle.FixedSingle
        Next
    End Sub

    Private Sub Clearbutton_Click(sender As Object, e As EventArgs) Handles red.Click
        Clear()
    End Sub
End Class