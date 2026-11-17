Public Class Form1
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim username As String = admin.Text
        Dim password As String = txtpassword.Text
        If username = "admin" And password = "123" Then
            lblmessage.ForeColor = Color.Green
            lblmessage.Text = "Login Success"
        Else
            lblmessage.ForeColor = Color.Red
            lblmessage.Text = "Login Fail"

        End If
    End Sub
End Class
