Public Class Form1

    Dim ans As Integer
    Dim deduc As Integer
    Dim tax As Integer
    Dim phil As Integer
    Dim s As Integer
    Dim net As Integer
    Dim ot As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ans = (((HourPerDay.Text * NumberOfDaysWorked.Text) * RatePerHour.Text) + ot)
        GrossSalary1.Text = ans
        GrossSalary2.Text = ans
        tax = ans * 0.15
        MonthlyWageTax.Text = tax
        phil = ans * 0.05
        PhilHealth.Text = phil
        s = ans * 0.02
        SSS.Text = s
        ot = RatePerHour.Text * 3 * 2.3 * Overtime.Text


        deduc = tax + phil + s
        TotalDeduction.Text = deduc
        Deduction.Text = deduc

        net = GrossSalary2.Text - Deduction.Text
        NetSalary.Text = net
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.DatabaseDataSet.Employees)

    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        HourPerDay.Clear()
        RatePerHour.Clear()
        NumberOfDaysWorked.Clear()
        MonthlyWageTax.Clear()
        PhilHealth.Clear()
        SSS.Clear()

        EmployeesBindingSource.MoveNext()
    End Sub

    Private Sub RatePerHour_TextChanged(sender As Object, e As EventArgs) Handles RatePerHour.TextChanged, Philhealth.TextChanged

    End Sub

End Class
