Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declare variables
        Dim dteStartDate As Date
        Dim dteChangedDate As Date
        'Start in the year 2400
        dteStartDate = #7/09/2022#
        'Add a day and display the results
        dteChangedDate = dteStartDate.AddDays(1)
        MessageBox.Show(dteChangedDate.ToLongDateString, "Date Demo")
        'Add some months and display the results
        dteChangedDate = dteStartDate.AddMonths(6)
        MessageBox.Show(dteChangedDate.ToLongDateString, "Date Demo")
        'Subtract a year and display the results
        dteChangedDate = dteStartDate.AddYears(-1)
        MessageBox.Show(dteChangedDate.ToLongDateString, "Date Demo")
    End Sub
End Class
