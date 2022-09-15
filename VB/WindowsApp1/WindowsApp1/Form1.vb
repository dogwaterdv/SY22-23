Public Class Form1
    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click

        'Declares a variable called total
        Dim total As Decimal
        'Gets the value from the form and puts it in total
        Decimal.TryParse(totalTextBox.Text, total)

        'Get the tip amount from user
        Dim tip As Decimal
        Decimal.TryParse()

        'Does a calculation
        Dim grandTotal As Decimal
        grandTotal = total * (1 + tip)

        'This displays the result as a currency with two decimal places
        grandTotalLabel.Text = grandTotal.ToString("C2")

    End Sub
End Class
