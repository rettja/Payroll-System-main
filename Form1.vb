Public Class Form1

    Dim ans As Integer
    Dim deduc As Integer
    Dim tax As Integer
    Dim phil As Integer
    Dim s As Integer
    Dim net As Integer
    Dim ot As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ans = (((HourPerDay.Text * NumberOfDaysWorked.Text) * RatePerHour.Text) + ot)
            FormatCurrency(RatePerHour.Text)
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
        Catch ex As Exception
            MessageBox.Show("Please fill up the requirements correctly")
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Paid_Workers' table. You can move, or remove it, as needed.
        Me.Paid_WorkersTableAdapter.Fill(Me.DatabaseDataSet.Paid_Workers)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Workers' table. You can move, or remove it, as needed.
        Me.WorkersTableAdapter.Fill(Me.DatabaseDataSet.Workers)
        'TODO: This line of code loads data into the 'DatabaseDataSet._Employees_Unpaid_' table. You can move, or remove it, as needed.
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles preview.Click
        Dim line As String = "---------------------------------------------------------------------------------------------------------------------------------------------------"
        Try
            Payslip.Text = ""
            Payslip.AppendText(line + vbNewLine)
            Payslip.AppendText("                                                      Arellano University Andres Bonifacio Campus" + vbNewLine)
            Payslip.AppendText("====================================================================================" + vbNewLine)
            Payslip.AppendText("                                                                                     Payslip                                                                       " + vbNewLine)
            Payslip.AppendText("====================================================================================" + vbNewLine)
            Payslip.AppendText("" + vbNewLine)
            Payslip.AppendText("Employee:                                                                                                                                  " + EmployeeName.Text + vbNewLine)
            Payslip.AppendText("" + vbNewLine)
            Payslip.AppendText("" + vbNewLine)
            Payslip.AppendText("Hourly Pay:                                                                                                                                 " + FormatCurrency(RatePerHour.Text) + vbNewLine)
            Payslip.AppendText("" + vbNewLine)
            Payslip.AppendText("" + vbNewLine)
            Payslip.AppendText("Work Hours:                                                                                                                                 " + HourPerDay.Text + (" Hours") + vbNewLine)
            Payslip.AppendText("" + vbNewLine)
            Payslip.AppendText("" + vbNewLine)
            Payslip.AppendText("Days worked:                                                                                                                               " + NumberOfDaysWorked.Text + (" Days") + vbNewLine)
            Payslip.AppendText("" + vbNewLine)
            Payslip.AppendText("" + vbNewLine)
            Payslip.AppendText("Overtime:                                                                                                                                      " + Overtime.Text + (" Hours") + vbNewLine)
            Payslip.AppendText("" + vbNewLine)
            Payslip.AppendText("" + vbNewLine)
            Payslip.AppendText("Gross Salary:                                                                                                                              " + FormatCurrency(GrossSalary1.Text) + vbNewLine)
            Payslip.AppendText("" + vbNewLine)
            Payslip.AppendText("====================================================================================" + vbNewLine)
            Payslip.AppendText("                                                                                  Deductions                                                                     " + vbNewLine)
            Payslip.AppendText("====================================================================================" + vbNewLine)
            Payslip.AppendText("" + vbNewLine)
            Payslip.AppendText("Tax:                                                                                                                                                 " + Taxpercent.Text + vbNewLine)
            Payslip.AppendText("Tax Contribution:                                                                                                                         " + FormatCurrency(MonthlyWageTax.Text) + vbNewLine)
            Payslip.AppendText("" + vbNewLine)
            Payslip.AppendText("" + vbNewLine)
            Payslip.AppendText("Philhealth:                                                                                                                                       " + philhealthdeduc.Text + vbNewLine)
            Payslip.AppendText("Philhealth Contribution:                                                                                                               " + FormatCurrency(Philhealth.Text) + vbNewLine)
            Payslip.AppendText("" + vbNewLine)
            Payslip.AppendText("" + vbNewLine)
            Payslip.AppendText("Philhealth:                                                                                                                                       " + sssdeduc.Text + vbNewLine)
            Payslip.AppendText("Philhealth Contribution:                                                                                                               " + FormatCurrency(SSS.Text) + vbNewLine)
            Payslip.AppendText("" + vbNewLine)
            Payslip.AppendText("" + vbNewLine)
            Payslip.AppendText("Total Deduction:                                                                                                                            " + FormatCurrency(TotalDeduction.Text) + vbNewLine)
            Payslip.AppendText("" + vbNewLine)
            Payslip.AppendText("====================================================================================" + vbNewLine)
            Payslip.AppendText("                                                                                  Net salary                                                                    " + vbNewLine)
            Payslip.AppendText("====================================================================================" + vbNewLine)
            Payslip.AppendText("" + vbNewLine)
            Payslip.AppendText("Net salary:                                                                                                                                    " + FormatCurrency(NetSalary.Text) + vbNewLine)
            Payslip.AppendText("" + vbNewLine)
            Payslip.AppendText("====================================================================================" + vbNewLine)
            Payslip.AppendText("                                                                              DATE & Time                                                                  " + vbNewLine)
            Payslip.AppendText("                                                                      " + Date.Now + vbNewLine)
            Payslip.AppendText("====================================================================================" + vbNewLine)
            Payslip.AppendText("                                                                           __________________                                                                  " + vbNewLine)
            Payslip.AppendText("                                                                               Signature                                                                  " + vbNewLine)




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
        Catch ex As Exception
            MessageBox.Show("Please fill-up the requirements correctly")

        End Try

    End Sub

    Private Sub print_Click(sender As Object, e As EventArgs) Handles print.Click
        Me.TopMost() = True
        PrintPreviewDialog1.ShowDialog(Payslip)
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        PaidWorkersBindingSource .AddNew()
        EmployeeName.Clear()
        EmployeeName.Text = unpaidemployees.Text
    End Sub

    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles Insert.Click
        PaidWorkersBindingSource.EndEdit()
        Paid_WorkersTableAdapter.Update(DatabaseDataSet.Paid_Workers)
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(Payslip.Text, Font, Brushes.Black, 140, 140)
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Try
            PaidWorkersBindingSource.EndEdit()
            Paid_WorkersTableAdapter.Update(DatabaseDataSet.Paid_Workers)

            Employees_Unpaid_BindingSource.RemoveCurrent()
            MessageBox.Show("Saved successfully")
        Catch ex As Exception
            MessageBox.Show("Not Saved")
        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WorkersBindingSource.MoveNext()
        EmployeeName.Text = unpaidemployees.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WorkersBindingSource.MovePrevious()
        EmployeeName.Text = unpaidemployees.Text
    End Sub

    Private Sub exit1_Click(sender As Object, e As EventArgs) Handles exit1.Click
        Application.Exit()
    End Sub

End Class
