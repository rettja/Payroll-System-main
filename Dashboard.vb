﻿Public Class Dashboard

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


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim form1 As New Form1()

        form1.Show()
    End Sub


    Private Function GetStoredPassword(username As String) As String
        If username = "Francisco" Then

            Return "Nicosupot"
        End If
        Return Nothing
    End Function
End Class
