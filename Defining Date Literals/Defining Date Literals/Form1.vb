Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declare variable
        Dim dteResults As Date
        'Set a date and time
        dteResults = #1/1/2010 8:01:00 AM#
        'Display the date and time
        MessageBox.Show(dteResults.ToLongDateString & " " &
        dteResults.ToLongTimeString, "Date Demo")
    End Sub
End Class
