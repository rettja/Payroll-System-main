Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Paid_Workers' table. You can move, or remove it, as needed.
        Me.Paid_WorkersTableAdapter.Fill(Me.DatabaseDataSet.Paid_Workers)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Workers' table. You can move, or remove it, as needed.
        Me.WorkersTableAdapter.Fill(Me.DatabaseDataSet.Workers)

    End Sub

    Private Sub exit1_Click(sender As Object, e As EventArgs) Handles exit1.Click
        Close()
    End Sub

End Class