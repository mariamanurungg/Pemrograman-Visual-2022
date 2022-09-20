Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declare Variable
        Dim intNumer As Integer

        'Set number, add numer, and display results
        intNumer = 16
        intNumer = intNumer + 8
        MessageBox.Show("Addition test." & intNumer.ToString, "Integer Math")

        'Set number, subtract numer, and display results
        intNumer = 24
        intNumer = intNumer — 2
        MessageBox.Show("Subtraction test. " & intNumer.ToString, "Integer Math")

        'Set number, multiply numer, and display results
        intNumer = 6
        intNumer = intNumer * 10
        MessageBox.Show("Multiplication test. " & intNumer.ToString, "Integer Math")

        'Set numer, divide numbers, and display results
        intNumer = 12
        intNumer = CType (intNumer / 6, Integer)
        MessageBox.Show("Division test. " & intNumer.ToString, "Integer Math")

    End Sub
End Class
