Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declare variable
        Dim strResults As String
        'Get the text from the TextBox
        strResults = txtString.Text
        'Display the length of the string
        MessageBox.Show(strResults.Length.ToString & " characters(s)",
        "Strings"
    End Sub
End Class
