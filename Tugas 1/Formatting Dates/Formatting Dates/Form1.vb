Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declare variable
        Dim dteResults As Date
        'Get the current date and time
        dteResults = Now
        'Display the various date properties
        MessageBox.Show("Month: " & dteResults.Month, "Date Demo")
        MessageBox.Show("Day: " & dteResults.Day, "Date Demo")
        MessageBox.Show("Year: " & dteResults.Year, "Date Demo")
        MessageBox.Show("Hour: " & dteResults.Hour, "Date Demo")
        MessageBox.Show("Minute: " & dteResults.Minute, "Date Demo")
        MessageBox.Show("Second: " & dteResults.Second, "Date Demo")
        MessageBox.Show("Day of week: " & dteResults.DayOfWeek, "Date Demo")
        MessageBox.Show("Day of year: " & dteResults.DayOfYear, "Date Demo")
    End Sub
End Class
