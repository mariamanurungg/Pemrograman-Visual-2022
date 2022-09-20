Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Set number, divide numbers, and display results
        dblNumber = 12
        dblNumber /= 7
        'Display the results without formatting
        MessageBox.Show("Division test without formatting. " &
        dblNumber.ToString, "Floating Points")
        'Display the results with formatting
        MessageBox.Show("Division test with formatting. " & String.Format("{0:n3}", dblNumber), "Floating Points")
    End Sub
End Class
