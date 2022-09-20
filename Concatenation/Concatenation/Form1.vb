Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declare variables
        Dim strResults As String
        Dim strOne As String
        Dim strTwo As String
        'Set the string values
        strOne = "Hello"
        strTwo = " World!"
        'Concatenate the strings
        strResults = strOne & strTwo
        'Display the results
        MessageBox.Show(strResults, "Strings")
    End Sub
End Class
