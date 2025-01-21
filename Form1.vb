Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If textBox1.Text = "harryden" And textBox2.Text = "cp00" Then
            MessageBox.Show("Welcome Admin")


            textBox1.Text = ""
            textBox2.Text = ""
            Hide()
            Home.ShowDialog()

        Else
            MessageBox.Show("login fail")
        End If

    End Sub
End Class
