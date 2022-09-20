Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intNumber As Integer
        intNumber = 27
        intNumber = intNumber + 1
        MessageBox.Show("Value of intNumber + 1 = " & intNumber.ToString, "Variables")
    End Sub
End Class
