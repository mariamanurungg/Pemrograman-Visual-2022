Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        MessageBox.Show("Hello, " & TextBox1.Text & "Welcome to visual basic", "hello message")

    End Sub
End Class
