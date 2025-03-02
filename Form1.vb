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
        GrossSalary1.Text = FormatCurrency(ans)
        GrossSalary2.Text = FormatCurrency(ans)
        If GrossSalary1.Text <= 250000 Then
            tax = ans * 0
            Taxpercent.Text = "0%"
        ElseIf GrossSalary1.Text >= 250000 Or GrossSalary1.Text <= 400000 Then
            tax = ans * 0.15
            Taxpercent.Text = "15%"
        ElseIf GrossSalary1.Text >= 400000 Or GrossSalary1.Text <= 800000 Then
            tax = ans * 0.2
            Taxpercent.Text = "20%"
        ElseIf GrossSalary1.Text >= 800000 Or GrossSalary1.Text <= 2000000 Then
            tax = ans * 0.25
            Taxpercent.Text = "25%"
        ElseIf GrossSalary1.Text >= 2000000 Or GrossSalary1.Text <= 8000000 Then
            tax = ans * 0.3
            Taxpercent.Text = "30%"
        ElseIf GrossSalary1.Text > 800000 Then
            tax = ans * 0.35
            Taxpercent.Text = "35%"
        End If
        MonthlyWageTax.Text = FormatCurrency(tax)
        phil = ans * 0.05
        Philhealth.Text = FormatCurrency(phil)
        s = ans * 0.14
        SSS.Text = FormatCurrency(s)
        ot = RatePerHour.Text * 3 * 2.3 * Overtime.Text

        deduc = Val(tax) + Val(phil) + Val(s)
        TotalDeduction.Text = FormatCurrency(deduc)
        Deduction.Text = FormatCurrency(deduc)

        net = GrossSalary2.Text - Deduction.Text
        NetSalary.Text = FormatCurrency(net)

        philhealthdeduc.Text = "5%"
        sssdeduc.Text = "14%"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.DatabaseDataSet.Employees)
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles print.Click
        Payslip.Text = ""
        Payslip.Text = vbNewLine
        Payslip.Text = vbNewLine
        Payslip.Text = vbNewLine
        Payslip.Text = vbNewLine
        Payslip.Text = vbNewLine
        Payslip.Text = vbNewLine
        Payslip.Text = vbNewLine
        Payslip.Text = vbNewLine
        Payslip.Text = vbNewLine
        Payslip.Text = "Ang tagal gumawa ng resibo hahahahahhahahahahhahahah -"
        PrintPreviewDialog1.ShowDialog()


        HourPerDay.Clear()
        RatePerHour.Clear()
        NumberOfDaysWorked.Clear()
        Overtime.Clear()
        MonthlyWageTax.Clear()
        Philhealth.Clear()
        SSS.Clear()
        Deduction.Clear()
        TotalDeduction.Clear()
        GrossSalary1.Clear()
        GrossSalary2.Clear()
        NetSalary.Clear()
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        EmployeesBindingSource.AddNew()
        EmployeeName.Clear()
    End Sub

    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles Insert.Click
        EmployeesBindingSource.EndEdit()
        EmployeesTableAdapter.Update(DatabaseDataSet.Employees)
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(Payslip.Text, Font, Brushes.Black, 120, 120)
        e.Graphics.DrawImage(AUlogo.Image, 120, 130, AUlogo.Image.Width - 10, AUlogo.Image.Height - 15)
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Try
            EmployeesBindingSource.EndEdit()
            EmployeesTableAdapter.Update(DatabaseDataSet.Employees)
            MessageBox.Show("Saved successfully")
        Catch ex As Exception
            MessageBox.Show("Not Saved")
        End Try
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.EmployeesTableAdapter.FillBy(Me.DatabaseDataSet.Employees)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
