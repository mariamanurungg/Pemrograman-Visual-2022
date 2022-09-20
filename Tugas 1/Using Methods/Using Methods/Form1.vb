Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Call your method
        SayHello()
    End Sub
    Private Sub SayHello()
        'Display a message box
        MessageBox.Show("Hello World!", "Three Buttons")
    End Sub
End Class
