﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GenderLabel As System.Windows.Forms.Label
        Dim AdressLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim Civil_StatusLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim BirthdayLabel As System.Windows.Forms.Label
        Dim WorkLabel As System.Windows.Forms.Label
        Dim EmployeesLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.EmployeeName = New System.Windows.Forms.TextBox()
        Me.PaidWorkersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New Payroll_System.DatabaseDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.HourPerDay = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumberOfDaysWorked = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TotalDeduction = New System.Windows.Forms.TextBox()
        Me.GrossSalary1 = New System.Windows.Forms.TextBox()
        Me.RatePerHour = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Deduction = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GrossSalary2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.NetSalary = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Overtime = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.MonthlyWageTax = New System.Windows.Forms.TextBox()
        Me.SSS = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Insert = New System.Windows.Forms.Button()
        Me.save = New System.Windows.Forms.Button()
        Me.Add = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Taxpercent = New System.Windows.Forms.TextBox()
        Me.EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.philhealthdeduc = New System.Windows.Forms.TextBox()
        Me.sssdeduc = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.exit1 = New System.Windows.Forms.Button()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.WorkersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdressTextBox = New System.Windows.Forms.TextBox()
        Me.Civil_StatusTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.WorkTextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.unpaidemployees = New System.Windows.Forms.TextBox()
        Me.BirthdayTextBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.preview = New System.Windows.Forms.Button()
        Me.print = New System.Windows.Forms.Button()
        Me.Philhealth = New System.Windows.Forms.TextBox()
        Me.Tab = New System.Windows.Forms.TabControl()
        Me.Database = New System.Windows.Forms.TabPage()
        Me.Paid_WorkersDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DaysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OvertimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrossSalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaxDeductionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SSSContributionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDedcutionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NetSalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaidWorkersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PayslipTab = New System.Windows.Forms.TabPage()
        Me.Payslip = New System.Windows.Forms.TextBox()
        Me.Employees_Unpaid_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New Payroll_System.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.TableAdapterManager1 = New Payroll_System.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.WorkersTableAdapter = New Payroll_System.DatabaseDataSetTableAdapters.WorkersTableAdapter()
        Me.Paid_WorkersTableAdapter = New Payroll_System.DatabaseDataSetTableAdapters.Paid_WorkersTableAdapter()
        GenderLabel = New System.Windows.Forms.Label()
        AdressLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        Civil_StatusLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        BirthdayLabel = New System.Windows.Forms.Label()
        WorkLabel = New System.Windows.Forms.Label()
        EmployeesLabel = New System.Windows.Forms.Label()
        CType(Me.PaidWorkersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.WorkersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Tab.SuspendLayout()
        Me.Database.SuspendLayout()
        CType(Me.Paid_WorkersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaidWorkersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PayslipTab.SuspendLayout()
        CType(Me.Employees_Unpaid_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(153, 52)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 8
        GenderLabel.Text = "Gender:"
        '
        'AdressLabel
        '
        AdressLabel.AutoSize = True
        AdressLabel.Location = New System.Drawing.Point(255, 13)
        AdressLabel.Name = "AdressLabel"
        AdressLabel.Size = New System.Drawing.Size(48, 13)
        AdressLabel.TabIndex = 10
        AdressLabel.Text = "Address:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(8, 52)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(29, 13)
        AgeLabel.TabIndex = 4
        AgeLabel.Text = "Age:"
        '
        'Civil_StatusLabel
        '
        Civil_StatusLabel.AutoSize = True
        Civil_StatusLabel.Location = New System.Drawing.Point(259, 52)
        Civil_StatusLabel.Name = "Civil_StatusLabel"
        Civil_StatusLabel.Size = New System.Drawing.Size(62, 13)
        Civil_StatusLabel.TabIndex = 12
        Civil_StatusLabel.Text = "Civil Status:"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(8, 13)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 0
        IDLabel.Text = "ID:"
        '
        'BirthdayLabel
        '
        BirthdayLabel.AutoSize = True
        BirthdayLabel.Location = New System.Drawing.Point(49, 52)
        BirthdayLabel.Name = "BirthdayLabel"
        BirthdayLabel.Size = New System.Drawing.Size(48, 13)
        BirthdayLabel.TabIndex = 6
        BirthdayLabel.Text = "Birthday:"
        '
        'WorkLabel
        '
        WorkLabel.AutoSize = True
        WorkLabel.Location = New System.Drawing.Point(365, 52)
        WorkLabel.Name = "WorkLabel"
        WorkLabel.Size = New System.Drawing.Size(36, 13)
        WorkLabel.TabIndex = 14
        WorkLabel.Text = "Work:"
        '
        'EmployeesLabel
        '
        EmployeesLabel.AutoSize = True
        EmployeesLabel.Location = New System.Drawing.Point(49, 13)
        EmployeesLabel.Name = "EmployeesLabel"
        EmployeesLabel.Size = New System.Drawing.Size(61, 13)
        EmployeesLabel.TabIndex = 2
        EmployeesLabel.Text = "Employees:"
        '
        'EmployeeName
        '
        Me.EmployeeName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaidWorkersBindingSource, "name", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.EmployeeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeName.Location = New System.Drawing.Point(7, 194)
        Me.EmployeeName.Multiline = True
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.ReadOnly = True
        Me.EmployeeName.ShortcutsEnabled = False
        Me.EmployeeName.Size = New System.Drawing.Size(204, 30)
        Me.EmployeeName.TabIndex = 100
        Me.EmployeeName.TabStop = False
        '
        'PaidWorkersBindingSource
        '
        Me.PaidWorkersBindingSource.DataMember = "Paid_Workers"
        Me.PaidWorkersBindingSource.DataSource = Me.DatabaseDataSet
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(4, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "EMPLOYEE NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(4, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "RATE PER HOUR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(4, 314)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "HOUR PER DAY"
        '
        'HourPerDay
        '
        Me.HourPerDay.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaidWorkersBindingSource, "Hours", True))
        Me.HourPerDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HourPerDay.Location = New System.Drawing.Point(7, 334)
        Me.HourPerDay.Name = "HourPerDay"
        Me.HourPerDay.Size = New System.Drawing.Size(204, 30)
        Me.HourPerDay.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(4, 384)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "NO. OF DAYS WORKED"
        '
        'NumberOfDaysWorked
        '
        Me.NumberOfDaysWorked.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaidWorkersBindingSource, "Days", True))
        Me.NumberOfDaysWorked.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfDaysWorked.Location = New System.Drawing.Point(7, 404)
        Me.NumberOfDaysWorked.Name = "NumberOfDaysWorked"
        Me.NumberOfDaysWorked.Size = New System.Drawing.Size(204, 30)
        Me.NumberOfDaysWorked.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(236, 562)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "TOTAL DEDUCTION"
        '
        'TotalDeduction
        '
        Me.TotalDeduction.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaidWorkersBindingSource, "Total_Dedcution", True))
        Me.TotalDeduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalDeduction.Location = New System.Drawing.Point(239, 582)
        Me.TotalDeduction.Name = "TotalDeduction"
        Me.TotalDeduction.ReadOnly = True
        Me.TotalDeduction.ShortcutsEnabled = False
        Me.TotalDeduction.Size = New System.Drawing.Size(204, 30)
        Me.TotalDeduction.TabIndex = 100
        Me.TotalDeduction.TabStop = False
        '
        'GrossSalary1
        '
        Me.GrossSalary1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaidWorkersBindingSource, "Gross_Salary", True))
        Me.GrossSalary1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrossSalary1.Location = New System.Drawing.Point(7, 582)
        Me.GrossSalary1.Name = "GrossSalary1"
        Me.GrossSalary1.ReadOnly = True
        Me.GrossSalary1.ShortcutsEnabled = False
        Me.GrossSalary1.Size = New System.Drawing.Size(204, 30)
        Me.GrossSalary1.TabIndex = 100
        Me.GrossSalary1.TabStop = False
        '
        'RatePerHour
        '
        Me.RatePerHour.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaidWorkersBindingSource, "Pay", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.RatePerHour.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RatePerHour.Location = New System.Drawing.Point(7, 263)
        Me.RatePerHour.Name = "RatePerHour"
        Me.RatePerHour.Size = New System.Drawing.Size(204, 30)
        Me.RatePerHour.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(236, 314)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 17)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "SSS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(236, 243)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 17)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "PHIL HEALTH"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(236, 174)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(176, 17)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "TAX OF MONTHLY WAGE"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(470, 243)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 17)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "DEDUCTION"
        '
        'Deduction
        '
        Me.Deduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deduction.Location = New System.Drawing.Point(473, 263)
        Me.Deduction.Name = "Deduction"
        Me.Deduction.ReadOnly = True
        Me.Deduction.ShortcutsEnabled = False
        Me.Deduction.Size = New System.Drawing.Size(204, 30)
        Me.Deduction.TabIndex = 100
        Me.Deduction.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(470, 174)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 17)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "GROSS SALARY"
        '
        'GrossSalary2
        '
        Me.GrossSalary2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrossSalary2.Location = New System.Drawing.Point(473, 194)
        Me.GrossSalary2.Name = "GrossSalary2"
        Me.GrossSalary2.ReadOnly = True
        Me.GrossSalary2.ShortcutsEnabled = False
        Me.GrossSalary2.Size = New System.Drawing.Size(204, 30)
        Me.GrossSalary2.TabIndex = 100
        Me.GrossSalary2.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(470, 562)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 17)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "NET SALARY"
        '
        'NetSalary
        '
        Me.NetSalary.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaidWorkersBindingSource, "Net_Salary", True))
        Me.NetSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetSalary.Location = New System.Drawing.Point(473, 582)
        Me.NetSalary.Name = "NetSalary"
        Me.NetSalary.ReadOnly = True
        Me.NetSalary.ShortcutsEnabled = False
        Me.NetSalary.Size = New System.Drawing.Size(204, 30)
        Me.NetSalary.TabIndex = 100
        Me.NetSalary.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Button1.Location = New System.Drawing.Point(205, 651)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 53)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "COMPUTE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(4, 454)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 17)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "OVERTIME HOURS"
        '
        'Overtime
        '
        Me.Overtime.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaidWorkersBindingSource, "Overtime", True))
        Me.Overtime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Overtime.Location = New System.Drawing.Point(7, 474)
        Me.Overtime.Name = "Overtime"
        Me.Overtime.Size = New System.Drawing.Size(204, 30)
        Me.Overtime.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(4, 562)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(128, 17)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "GROSS SALARY"
        '
        'MonthlyWageTax
        '
        Me.MonthlyWageTax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaidWorkersBindingSource, "Tax Deduction", True))
        Me.MonthlyWageTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthlyWageTax.Location = New System.Drawing.Point(239, 194)
        Me.MonthlyWageTax.Name = "MonthlyWageTax"
        Me.MonthlyWageTax.ReadOnly = True
        Me.MonthlyWageTax.ShortcutsEnabled = False
        Me.MonthlyWageTax.Size = New System.Drawing.Size(204, 30)
        Me.MonthlyWageTax.TabIndex = 100
        Me.MonthlyWageTax.TabStop = False
        '
        'SSS
        '
        Me.SSS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaidWorkersBindingSource, "SSS_Contribution", True))
        Me.SSS.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SSS.Location = New System.Drawing.Point(239, 334)
        Me.SSS.Name = "SSS"
        Me.SSS.ReadOnly = True
        Me.SSS.ShortcutsEnabled = False
        Me.SSS.Size = New System.Drawing.Size(204, 30)
        Me.SSS.TabIndex = 100
        Me.SSS.TabStop = False
        '
        'PrintDocument1
        '
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Impact", 33.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Khaki
        Me.Label17.Location = New System.Drawing.Point(0, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(330, 56)
        Me.Label17.TabIndex = 56
        Me.Label17.Text = "PAYROLL SYSTEM"
        '
        'Insert
        '
        Me.Insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Insert.Location = New System.Drawing.Point(340, 651)
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(128, 53)
        Me.Insert.TabIndex = 8
        Me.Insert.Text = "INSERT"
        Me.Insert.UseVisualStyleBackColor = True
        '
        'save
        '
        Me.save.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.save.Location = New System.Drawing.Point(474, 651)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(128, 53)
        Me.save.TabIndex = 9
        Me.save.Text = "SAVE"
        Me.save.UseVisualStyleBackColor = True
        '
        'Add
        '
        Me.Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Add.Location = New System.Drawing.Point(68, 651)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(128, 53)
        Me.Add.TabIndex = 1
        Me.Add.Text = "NEW"
        Me.Add.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Taxpercent
        '
        Me.Taxpercent.BackColor = System.Drawing.Color.LightGray
        Me.Taxpercent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Taxpercent.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Tax Deduction", True))
        Me.Taxpercent.Location = New System.Drawing.Point(419, 174)
        Me.Taxpercent.Name = "Taxpercent"
        Me.Taxpercent.Size = New System.Drawing.Size(24, 13)
        Me.Taxpercent.TabIndex = 51
        Me.Taxpercent.TabStop = False
        '
        'EmployeesBindingSource
        '
        Me.EmployeesBindingSource.DataMember = "Employees"
        Me.EmployeesBindingSource.DataSource = Me.DatabaseDataSet
        '
        'philhealthdeduc
        '
        Me.philhealthdeduc.BackColor = System.Drawing.Color.LightGray
        Me.philhealthdeduc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.philhealthdeduc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Philhealth Contribution", True))
        Me.philhealthdeduc.Location = New System.Drawing.Point(419, 243)
        Me.philhealthdeduc.Name = "philhealthdeduc"
        Me.philhealthdeduc.Size = New System.Drawing.Size(24, 13)
        Me.philhealthdeduc.TabIndex = 51
        Me.philhealthdeduc.TabStop = False
        '
        'sssdeduc
        '
        Me.sssdeduc.BackColor = System.Drawing.Color.LightGray
        Me.sssdeduc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.sssdeduc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "SSS Contribution", True))
        Me.sssdeduc.Location = New System.Drawing.Point(419, 314)
        Me.sssdeduc.Name = "sssdeduc"
        Me.sssdeduc.Size = New System.Drawing.Size(24, 13)
        Me.sssdeduc.TabIndex = 51
        Me.sssdeduc.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.exit1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1621, 50)
        Me.Panel1.TabIndex = 101
        '
        'exit1
        '
        Me.exit1.AutoSize = True
        Me.exit1.BackColor = System.Drawing.Color.SteelBlue
        Me.exit1.BackgroundImage = Global.Payroll_System.My.Resources.Resources._5244832
        Me.exit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.exit1.Dock = System.Windows.Forms.DockStyle.Right
        Me.exit1.FlatAppearance.BorderSize = 0
        Me.exit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exit1.Location = New System.Drawing.Point(1574, 0)
        Me.exit1.Name = "exit1"
        Me.exit1.Size = New System.Drawing.Size(47, 50)
        Me.exit1.TabIndex = 54
        Me.exit1.TabStop = False
        Me.exit1.UseVisualStyleBackColor = False
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkersBindingSource, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(156, 68)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GenderTextBox.TabIndex = 9
        Me.GenderTextBox.TabStop = False
        '
        'WorkersBindingSource
        '
        Me.WorkersBindingSource.DataMember = "Workers"
        Me.WorkersBindingSource.DataSource = Me.DatabaseDataSet
        '
        'AdressTextBox
        '
        Me.AdressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkersBindingSource, "Address", True))
        Me.AdressTextBox.Location = New System.Drawing.Point(262, 29)
        Me.AdressTextBox.Name = "AdressTextBox"
        Me.AdressTextBox.Size = New System.Drawing.Size(239, 20)
        Me.AdressTextBox.TabIndex = 11
        Me.AdressTextBox.TabStop = False
        '
        'Civil_StatusTextBox
        '
        Me.Civil_StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkersBindingSource, "Civil Status", True))
        Me.Civil_StatusTextBox.Location = New System.Drawing.Point(262, 68)
        Me.Civil_StatusTextBox.Name = "Civil_StatusTextBox"
        Me.Civil_StatusTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Civil_StatusTextBox.TabIndex = 13
        Me.Civil_StatusTextBox.TabStop = False
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkersBindingSource, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(11, 68)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(35, 20)
        Me.AgeTextBox.TabIndex = 5
        Me.AgeTextBox.TabStop = False
        '
        'WorkTextBox
        '
        Me.WorkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkersBindingSource, "Work", True))
        Me.WorkTextBox.Location = New System.Drawing.Point(368, 68)
        Me.WorkTextBox.Name = "WorkTextBox"
        Me.WorkTextBox.Size = New System.Drawing.Size(133, 20)
        Me.WorkTextBox.TabIndex = 15
        Me.WorkTextBox.TabStop = False
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkersBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(11, 29)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(35, 20)
        Me.IDTextBox.TabIndex = 1
        Me.IDTextBox.TabStop = False
        '
        'unpaidemployees
        '
        Me.unpaidemployees.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkersBindingSource, "Employees", True))
        Me.unpaidemployees.Location = New System.Drawing.Point(52, 29)
        Me.unpaidemployees.Name = "unpaidemployees"
        Me.unpaidemployees.Size = New System.Drawing.Size(199, 20)
        Me.unpaidemployees.TabIndex = 3
        Me.unpaidemployees.TabStop = False
        '
        'BirthdayTextBox
        '
        Me.BirthdayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkersBindingSource, "Birthday", True))
        Me.BirthdayTextBox.Location = New System.Drawing.Point(52, 68)
        Me.BirthdayTextBox.Name = "BirthdayTextBox"
        Me.BirthdayTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BirthdayTextBox.TabIndex = 7
        Me.BirthdayTextBox.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(585, 67)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 20)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Next"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(510, 67)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 20)
        Me.Button2.TabIndex = 16
        Me.Button2.TabStop = False
        Me.Button2.Text = "Previous"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(EmployeesLabel)
        Me.Panel2.Controls.Add(Me.BirthdayTextBox)
        Me.Panel2.Controls.Add(Me.unpaidemployees)
        Me.Panel2.Controls.Add(WorkLabel)
        Me.Panel2.Controls.Add(Me.IDTextBox)
        Me.Panel2.Controls.Add(BirthdayLabel)
        Me.Panel2.Controls.Add(Me.WorkTextBox)
        Me.Panel2.Controls.Add(IDLabel)
        Me.Panel2.Controls.Add(Civil_StatusLabel)
        Me.Panel2.Controls.Add(Me.AgeTextBox)
        Me.Panel2.Controls.Add(AgeLabel)
        Me.Panel2.Controls.Add(Me.Civil_StatusTextBox)
        Me.Panel2.Controls.Add(Me.AdressTextBox)
        Me.Panel2.Controls.Add(Me.GenderTextBox)
        Me.Panel2.Controls.Add(AdressLabel)
        Me.Panel2.Controls.Add(GenderLabel)
        Me.Panel2.Location = New System.Drawing.Point(1, 68)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(676, 100)
        Me.Panel2.TabIndex = 102
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.preview)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.print)
        Me.Panel3.Controls.Add(Me.sssdeduc)
        Me.Panel3.Controls.Add(Me.philhealthdeduc)
        Me.Panel3.Controls.Add(Me.MonthlyWageTax)
        Me.Panel3.Controls.Add(Me.Taxpercent)
        Me.Panel3.Controls.Add(Me.EmployeeName)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.RatePerHour)
        Me.Panel3.Controls.Add(Me.Overtime)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.save)
        Me.Panel3.Controls.Add(Me.HourPerDay)
        Me.Panel3.Controls.Add(Me.Insert)
        Me.Panel3.Controls.Add(Me.Philhealth)
        Me.Panel3.Controls.Add(Me.SSS)
        Me.Panel3.Controls.Add(Me.Add)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.NumberOfDaysWorked)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.NetSalary)
        Me.Panel3.Controls.Add(Me.TotalDeduction)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Deduction)
        Me.Panel3.Controls.Add(Me.GrossSalary1)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.GrossSalary2)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Tab)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1621, 726)
        Me.Panel3.TabIndex = 103
        '
        'preview
        '
        Me.preview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.preview.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.preview.Location = New System.Drawing.Point(1127, 673)
        Me.preview.Name = "preview"
        Me.preview.Size = New System.Drawing.Size(120, 31)
        Me.preview.TabIndex = 14
        Me.preview.Text = "Preview "
        Me.preview.UseVisualStyleBackColor = True
        '
        'print
        '
        Me.print.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.print.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.print.Location = New System.Drawing.Point(1268, 673)
        Me.print.Name = "print"
        Me.print.Size = New System.Drawing.Size(120, 31)
        Me.print.TabIndex = 15
        Me.print.Text = "Print"
        Me.print.UseVisualStyleBackColor = True
        '
        'Philhealth
        '
        Me.Philhealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Philhealth.Location = New System.Drawing.Point(239, 263)
        Me.Philhealth.Name = "Philhealth"
        Me.Philhealth.ReadOnly = True
        Me.Philhealth.ShortcutsEnabled = False
        Me.Philhealth.Size = New System.Drawing.Size(204, 30)
        Me.Philhealth.TabIndex = 100
        Me.Philhealth.TabStop = False
        '
        'Tab
        '
        Me.Tab.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab.Controls.Add(Me.Database)
        Me.Tab.Controls.Add(Me.PayslipTab)
        Me.Tab.Location = New System.Drawing.Point(925, 68)
        Me.Tab.Name = "Tab"
        Me.Tab.SelectedIndex = 0
        Me.Tab.Size = New System.Drawing.Size(683, 599)
        Me.Tab.TabIndex = 52
        '
        'Database
        '
        Me.Database.AutoScroll = True
        Me.Database.Controls.Add(Me.Paid_WorkersDataGridView)
        Me.Database.Location = New System.Drawing.Point(4, 22)
        Me.Database.Name = "Database"
        Me.Database.Padding = New System.Windows.Forms.Padding(3)
        Me.Database.Size = New System.Drawing.Size(675, 573)
        Me.Database.TabIndex = 0
        Me.Database.Text = "Database"
        Me.Database.UseVisualStyleBackColor = True
        '
        'Paid_WorkersDataGridView
        '
        Me.Paid_WorkersDataGridView.AutoGenerateColumns = False
        Me.Paid_WorkersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Paid_WorkersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.PayDataGridViewTextBoxColumn, Me.HoursDataGridViewTextBoxColumn, Me.DaysDataGridViewTextBoxColumn, Me.OvertimeDataGridViewTextBoxColumn, Me.GrossSalaryDataGridViewTextBoxColumn, Me.TaxDeductionDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn3, Me.SSSContributionDataGridViewTextBoxColumn, Me.TotalDedcutionDataGridViewTextBoxColumn, Me.NetSalaryDataGridViewTextBoxColumn})
        Me.Paid_WorkersDataGridView.DataSource = Me.PaidWorkersBindingSource1
        Me.Paid_WorkersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Paid_WorkersDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.Paid_WorkersDataGridView.Name = "Paid_WorkersDataGridView"
        Me.Paid_WorkersDataGridView.Size = New System.Drawing.Size(669, 567)
        Me.Paid_WorkersDataGridView.TabIndex = 0
        Me.Paid_WorkersDataGridView.TabStop = False
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'PayDataGridViewTextBoxColumn
        '
        Me.PayDataGridViewTextBoxColumn.DataPropertyName = "Pay"
        Me.PayDataGridViewTextBoxColumn.HeaderText = "Pay"
        Me.PayDataGridViewTextBoxColumn.MinimumWidth = 75
        Me.PayDataGridViewTextBoxColumn.Name = "PayDataGridViewTextBoxColumn"
        '
        'HoursDataGridViewTextBoxColumn
        '
        Me.HoursDataGridViewTextBoxColumn.DataPropertyName = "Hours"
        Me.HoursDataGridViewTextBoxColumn.HeaderText = "Hours"
        Me.HoursDataGridViewTextBoxColumn.MinimumWidth = 65
        Me.HoursDataGridViewTextBoxColumn.Name = "HoursDataGridViewTextBoxColumn"
        '
        'DaysDataGridViewTextBoxColumn
        '
        Me.DaysDataGridViewTextBoxColumn.DataPropertyName = "Days"
        Me.DaysDataGridViewTextBoxColumn.HeaderText = "Days"
        Me.DaysDataGridViewTextBoxColumn.MinimumWidth = 65
        Me.DaysDataGridViewTextBoxColumn.Name = "DaysDataGridViewTextBoxColumn"
        '
        'OvertimeDataGridViewTextBoxColumn
        '
        Me.OvertimeDataGridViewTextBoxColumn.DataPropertyName = "Overtime"
        Me.OvertimeDataGridViewTextBoxColumn.HeaderText = "Overtime"
        Me.OvertimeDataGridViewTextBoxColumn.MinimumWidth = 65
        Me.OvertimeDataGridViewTextBoxColumn.Name = "OvertimeDataGridViewTextBoxColumn"
        '
        'GrossSalaryDataGridViewTextBoxColumn
        '
        Me.GrossSalaryDataGridViewTextBoxColumn.DataPropertyName = "Gross_Salary"
        Me.GrossSalaryDataGridViewTextBoxColumn.HeaderText = "Gross_Salary"
        Me.GrossSalaryDataGridViewTextBoxColumn.MinimumWidth = 140
        Me.GrossSalaryDataGridViewTextBoxColumn.Name = "GrossSalaryDataGridViewTextBoxColumn"
        Me.GrossSalaryDataGridViewTextBoxColumn.Width = 140
        '
        'TaxDeductionDataGridViewTextBoxColumn
        '
        Me.TaxDeductionDataGridViewTextBoxColumn.DataPropertyName = "Tax Deduction"
        Me.TaxDeductionDataGridViewTextBoxColumn.HeaderText = "Tax Deduction"
        Me.TaxDeductionDataGridViewTextBoxColumn.MinimumWidth = 140
        Me.TaxDeductionDataGridViewTextBoxColumn.Name = "TaxDeductionDataGridViewTextBoxColumn"
        Me.TaxDeductionDataGridViewTextBoxColumn.Width = 140
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PhilHealth_Contribution"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PhilHealth_Contribution"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 140
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 140
        '
        'SSSContributionDataGridViewTextBoxColumn
        '
        Me.SSSContributionDataGridViewTextBoxColumn.DataPropertyName = "SSS_Contribution"
        Me.SSSContributionDataGridViewTextBoxColumn.HeaderText = "SSS_Contribution"
        Me.SSSContributionDataGridViewTextBoxColumn.MinimumWidth = 140
        Me.SSSContributionDataGridViewTextBoxColumn.Name = "SSSContributionDataGridViewTextBoxColumn"
        Me.SSSContributionDataGridViewTextBoxColumn.Width = 140
        '
        'TotalDedcutionDataGridViewTextBoxColumn
        '
        Me.TotalDedcutionDataGridViewTextBoxColumn.DataPropertyName = "Total_Dedcution"
        Me.TotalDedcutionDataGridViewTextBoxColumn.HeaderText = "Total_Dedcution"
        Me.TotalDedcutionDataGridViewTextBoxColumn.MinimumWidth = 140
        Me.TotalDedcutionDataGridViewTextBoxColumn.Name = "TotalDedcutionDataGridViewTextBoxColumn"
        Me.TotalDedcutionDataGridViewTextBoxColumn.Width = 140
        '
        'NetSalaryDataGridViewTextBoxColumn
        '
        Me.NetSalaryDataGridViewTextBoxColumn.DataPropertyName = "Net_Salary"
        Me.NetSalaryDataGridViewTextBoxColumn.HeaderText = "Net_Salary"
        Me.NetSalaryDataGridViewTextBoxColumn.MinimumWidth = 140
        Me.NetSalaryDataGridViewTextBoxColumn.Name = "NetSalaryDataGridViewTextBoxColumn"
        Me.NetSalaryDataGridViewTextBoxColumn.Width = 140
        '
        'PaidWorkersBindingSource1
        '
        Me.PaidWorkersBindingSource1.DataMember = "Paid_Workers"
        Me.PaidWorkersBindingSource1.DataSource = Me.DatabaseDataSet
        '
        'PayslipTab
        '
        Me.PayslipTab.BackColor = System.Drawing.Color.DarkGray
        Me.PayslipTab.Controls.Add(Me.Payslip)
        Me.PayslipTab.Location = New System.Drawing.Point(4, 22)
        Me.PayslipTab.Name = "PayslipTab"
        Me.PayslipTab.Padding = New System.Windows.Forms.Padding(3)
        Me.PayslipTab.Size = New System.Drawing.Size(675, 573)
        Me.PayslipTab.TabIndex = 1
        Me.PayslipTab.Text = "Payslip"
        '
        'Payslip
        '
        Me.Payslip.Location = New System.Drawing.Point(0, 0)
        Me.Payslip.Multiline = True
        Me.Payslip.Name = "Payslip"
        Me.Payslip.Size = New System.Drawing.Size(679, 573)
        Me.Payslip.TabIndex = 103
        '
        'Employees_Unpaid_BindingSource
        '
        Me.Employees_Unpaid_BindingSource.DataMember = "Employees(Unpaid)"
        Me.Employees_Unpaid_BindingSource.DataSource = Me.DatabaseDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.Employees_Unpaid_TableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.Paid_WorkersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Payroll_System.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WorkersTableAdapter = Nothing
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.AdminsTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.Employees_Unpaid_TableAdapter = Nothing
        Me.TableAdapterManager1.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager1.Paid_WorkersTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Payroll_System.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.WorkersTableAdapter = Nothing
        '
        'WorkersTableAdapter
        '
        Me.WorkersTableAdapter.ClearBeforeFill = True
        '
        'Paid_WorkersTableAdapter
        '
        Me.Paid_WorkersTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1620, 760)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PaidWorkersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.WorkersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Tab.ResumeLayout(False)
        Me.Database.ResumeLayout(False)
        CType(Me.Paid_WorkersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaidWorkersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PayslipTab.ResumeLayout(False)
        Me.PayslipTab.PerformLayout()
        CType(Me.Employees_Unpaid_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EmployeeName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents HourPerDay As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents NumberOfDaysWorked As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TotalDeduction As TextBox
    Friend WithEvents GrossSalary1 As TextBox
    Friend WithEvents RatePerHour As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Deduction As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GrossSalary2 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents NetSalary As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Overtime As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents EmployeesBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MonthlyWageTax As TextBox
    Friend WithEvents Insert As Button
    Friend WithEvents save As Button
    Friend WithEvents Add As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents TableAdapterManager1 As DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PhilhealthContributionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Public WithEvents SSS As TextBox
    Friend WithEvents Taxpercent As TextBox
    Friend WithEvents philhealthdeduc As TextBox
    Friend WithEvents sssdeduc As TextBox
    Friend WithEvents Employees_Unpaid_BindingSource As BindingSource
    Friend WithEvents exit1 As Button
    Friend WithEvents WorkersBindingSource As BindingSource
    Friend WithEvents WorkersTableAdapter As DatabaseDataSetTableAdapters.WorkersTableAdapter
    Friend WithEvents PaidWorkersBindingSource As BindingSource
    Friend WithEvents Paid_WorkersTableAdapter As DatabaseDataSetTableAdapters.Paid_WorkersTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents AdressTextBox As TextBox
    Friend WithEvents Civil_StatusTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents WorkTextBox As TextBox
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents unpaidemployees As TextBox
    Friend WithEvents BirthdayTextBox As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Public WithEvents Philhealth As TextBox
    Friend WithEvents print As Button
    Friend WithEvents Tab As TabControl
    Friend WithEvents Database As TabPage
    Friend WithEvents Paid_WorkersDataGridView As DataGridView
    Friend WithEvents PayslipTab As TabPage
    Friend WithEvents Payslip As TextBox
    Friend WithEvents preview As Button
    Friend WithEvents PaidWorkersBindingSource1 As BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoursDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DaysDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OvertimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GrossSalaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TaxDeductionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents SSSContributionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDedcutionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NetSalaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
