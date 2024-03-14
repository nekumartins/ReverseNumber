Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num, n As Long
        Label1.Text = ""
        Dim m As String
        If Long.TryParse(TextBox1.Text, num) Then
            While num <> 0
                n = num Mod 10
                m = n.ToString
                Label1.Text += m
                num = num \ 10
            End While
        Else
            MessageBox.Show("Please enter a valid number")
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
