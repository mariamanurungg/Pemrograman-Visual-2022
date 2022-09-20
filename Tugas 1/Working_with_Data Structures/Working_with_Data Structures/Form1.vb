Public Class Form1
    Private Sub btnArrayElement_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Clear the list
        ClearList()
        'Declare an array
        Dim strFriends(4) As String
        'Populate the array
        strFriends(0) = "Wendy"
        strFriends(1) = "Harriet"
        strFriends(2) = "Jay"
        strFriends(3) = "Michelle"
        strFriends(4) = "Richard"
        'Add the first array item to the list
        lstFriends.Items.Add(strFriends(0))
    End Sub

    Private Sub ClearList()
        'Clear the list
        lstFriends.Items.Clear()
    End Sub
End Class
