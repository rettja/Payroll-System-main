Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Dim ans As Integer
    Dim deduc As Integer
    Dim net As Integer
    Dim ot As Integer

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles GrossSalary2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ans = (((HourPerDay.Text * NumberOfDaysWorked.Text) * RatePerHour.Text) + ot)
        GrossSalary1.Text = ans
        GrossSalary2.Text = ans
        tax.Text = ans * 0.15
        phil.Text = ans * 0.05
        s.Text = ans * 0.02
        ot = RatePerHour.Text * 3 * 2.3 * Overtime.Text


        deduc = tax.Text + phil.Text + s.Text
        TotalDeduction.Text = deduc
        Deduction.Text = deduc

        net = GrossSalary2.Text - Deduction.Text
        NetSalary.Text = net
    End Sub


End Class