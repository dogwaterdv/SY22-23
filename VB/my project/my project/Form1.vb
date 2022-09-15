Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim amaount As Decimal
        Decimal.TryParse(moneybox.text, amount)
        nameTextbox.Clear()
        CCTextbox.Clear()
        ExpTextbox.Clear()
        EipTextbox.Clear()
        AmtTextbox.Clear()
        feeTextbox1.Text = amount


    End Sub
End Class
