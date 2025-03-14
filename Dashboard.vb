Imports System.Data.OleDb

Public Class Dashboard

    Private Function AuthenticateUser(username As String, password As String) As Boolean
        Dim storedPassword As String = GetStoredPassword(username)
        Return storedPassword IsNot Nothing AndAlso storedPassword = password
    End Function

    Public Sub HandleLogin(username As String, password As String)
        Dim isAuthenticated As Boolean = AuthenticateUser(username, password)
        If isAuthenticated Then
            Me.Show()
        Else
            MessageBox.Show("Invalid credentials. Please try again.")
        End If
    End Sub

    Private Function GetStoredPassword(username As String) As String
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database.accdb;"
        Using connection As New OleDbConnection(connectionString)
            Try
                connection.Open()
                Dim command As New OleDbCommand("SELECT Password FROM Users WHERE Username = @username", connection)
                command.Parameters.AddWithValue("@username", username)
                Dim result As Object = command.ExecuteScalar()
                If result IsNot Nothing Then
                    Return result.ToString()
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
        Return Nothing
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form1 As New Form1()
        form1.Show()
    End Sub

    Private Sub exit1_Click(sender As Object, e As EventArgs) Handles exit1.Click, Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form3 As New Form3()
        form3.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class
