﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declare and set a variable
        Dim intNumber As Integer = 27
        'Here's where you make a decision,
        'and tell the user what happened
        If intNumber = 27 Then
            MessageBox.Show("'intNumber' is, indeed, 27!", "Simple If")
        End If
    End Sub
End Class
