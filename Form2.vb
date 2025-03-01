Public Class Form2
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles exit1.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Login.Click
        ' Retrieve the username and password from the text boxes
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        ' Create an instance of the Dashboard form
        Dim dashboard As New Dashboard()

        ' Validate the credentials using the HandleLogin method
        dashboard.HandleLogin(username, password)

        ' If the credentials are valid, the Dashboard form will be shown
        ' Optionally, hide the current form
        If dashboard.Visible Then
            Me.Hide()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles AUlogo.Click

    End Sub
End Class
