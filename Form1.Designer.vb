<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.EmployeeName = New System.Windows.Forms.TextBox()
        Me.EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Deduction = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GrossSalary2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.NetSalary = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Overtime = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.print = New System.Windows.Forms.Button()
        Me.MonthlyWageTax = New System.Windows.Forms.TextBox()
        Me.Philhealth = New System.Windows.Forms.TextBox()
        Me.SSS = New System.Windows.Forms.TextBox()
        Me.Tab = New System.Windows.Forms.TabControl()
        Me.Database = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DaysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OvertimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrossSalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaxDeductionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhilhealthContributionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SSSContributionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDeductionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NetSalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Payslip = New System.Windows.Forms.TextBox()
        Me.Insert = New System.Windows.Forms.Button()
        Me.save = New System.Windows.Forms.Button()
        Me.Add = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.AUlogo = New System.Windows.Forms.PictureBox()
        Me.EmployeesTableAdapter = New Payroll_System.DatabaseDataSetTableAdapters.EmployeesTableAdapter()
        Me.TableAdapterManager = New Payroll_System.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.TableAdapterManager1 = New Payroll_System.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.Taxpercent = New System.Windows.Forms.TextBox()
        Me.philhealthdeduc = New System.Windows.Forms.TextBox()
        Me.sssdeduc = New System.Windows.Forms.TextBox()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab.SuspendLayout()
        Me.Database.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.AUlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmployeeName
        '
        Me.EmployeeName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Name", True))
        Me.EmployeeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeName.Location = New System.Drawing.Point(24, 104)
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.Size = New System.Drawing.Size(204, 30)
        Me.EmployeeName.TabIndex = 2
        '
        'EmployeesBindingSource
        '
        Me.EmployeesBindingSource.DataMember = "Employees"
        Me.EmployeesBindingSource.DataSource = Me.DatabaseDataSet
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
        Me.Label2.Location = New System.Drawing.Point(21, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "EMPLOYEE NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(21, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "RATE PER HOUR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(21, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "HOUR PER DAY"
        '
        'HourPerDay
        '
        Me.HourPerDay.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Hours", True))
        Me.HourPerDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HourPerDay.Location = New System.Drawing.Point(24, 244)
        Me.HourPerDay.Name = "HourPerDay"
        Me.HourPerDay.Size = New System.Drawing.Size(204, 30)
        Me.HourPerDay.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(21, 294)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "NO. OF DAYS WORKED"
        '
        'NumberOfDaysWorked
        '
        Me.NumberOfDaysWorked.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Days", True))
        Me.NumberOfDaysWorked.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfDaysWorked.Location = New System.Drawing.Point(24, 314)
        Me.NumberOfDaysWorked.Name = "NumberOfDaysWorked"
        Me.NumberOfDaysWorked.Size = New System.Drawing.Size(204, 30)
        Me.NumberOfDaysWorked.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(253, 472)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "TOTAL DEDUCTION"
        '
        'TotalDeduction
        '
        Me.TotalDeduction.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Total Deduction", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.TotalDeduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalDeduction.Location = New System.Drawing.Point(256, 492)
        Me.TotalDeduction.Name = "TotalDeduction"
        Me.TotalDeduction.ReadOnly = True
        Me.TotalDeduction.Size = New System.Drawing.Size(204, 30)
        Me.TotalDeduction.TabIndex = 17
        '
        'GrossSalary1
        '
        Me.GrossSalary1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Gross salary", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.GrossSalary1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrossSalary1.Location = New System.Drawing.Point(24, 492)
        Me.GrossSalary1.Name = "GrossSalary1"
        Me.GrossSalary1.ReadOnly = True
        Me.GrossSalary1.Size = New System.Drawing.Size(204, 30)
        Me.GrossSalary1.TabIndex = 27
        '
        'RatePerHour
        '
        Me.RatePerHour.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Pay", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.RatePerHour.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RatePerHour.Location = New System.Drawing.Point(24, 173)
        Me.RatePerHour.Name = "RatePerHour"
        Me.RatePerHour.Size = New System.Drawing.Size(204, 30)
        Me.RatePerHour.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1370, 69)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PAYROLL SYSTEM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(253, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 17)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "SSS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(253, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 17)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "PHIL HEALTH"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(253, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(176, 17)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "TAX OF MONTHLY WAGE"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(487, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 17)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "DEDUCTION"
        '
        'Deduction
        '
        Me.Deduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deduction.Location = New System.Drawing.Point(490, 173)
        Me.Deduction.Name = "Deduction"
        Me.Deduction.ReadOnly = True
        Me.Deduction.Size = New System.Drawing.Size(204, 30)
        Me.Deduction.TabIndex = 38
        '
        'TextBox12
        '
        Me.TextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(490, 173)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(204, 30)
        Me.TextBox12.TabIndex = 39
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(487, 84)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 17)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "GROSS SALARY"
        '
        'GrossSalary2
        '
        Me.GrossSalary2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrossSalary2.Location = New System.Drawing.Point(490, 104)
        Me.GrossSalary2.Name = "GrossSalary2"
        Me.GrossSalary2.ReadOnly = True
        Me.GrossSalary2.Size = New System.Drawing.Size(204, 30)
        Me.GrossSalary2.TabIndex = 36
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(487, 472)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 17)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "NET SALARY"
        '
        'NetSalary
        '
        Me.NetSalary.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Net Salary", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.NetSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetSalary.Location = New System.Drawing.Point(490, 492)
        Me.NetSalary.Name = "NetSalary"
        Me.NetSalary.ReadOnly = True
        Me.NetSalary.Size = New System.Drawing.Size(204, 30)
        Me.NetSalary.TabIndex = 43
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Button1.Location = New System.Drawing.Point(256, 553)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(204, 53)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "COMPUTE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(21, 364)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 17)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "OVERTIME HOURS"
        '
        'Overtime
        '
        Me.Overtime.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Overtime", True))
        Me.Overtime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Overtime.Location = New System.Drawing.Point(24, 384)
        Me.Overtime.Name = "Overtime"
        Me.Overtime.Size = New System.Drawing.Size(204, 30)
        Me.Overtime.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(21, 472)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(128, 17)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "GROSS SALARY"
        '
        'print
        '
        Me.print.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.print.Location = New System.Drawing.Point(1064, 553)
        Me.print.Name = "print"
        Me.print.Size = New System.Drawing.Size(204, 53)
        Me.print.TabIndex = 10
        Me.print.Text = "Print"
        Me.print.UseVisualStyleBackColor = True
        '
        'MonthlyWageTax
        '
        Me.MonthlyWageTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthlyWageTax.Location = New System.Drawing.Point(256, 104)
        Me.MonthlyWageTax.Name = "MonthlyWageTax"
        Me.MonthlyWageTax.ReadOnly = True
        Me.MonthlyWageTax.Size = New System.Drawing.Size(204, 30)
        Me.MonthlyWageTax.TabIndex = 46
        '
        'Philhealth
        '
        Me.Philhealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Philhealth.Location = New System.Drawing.Point(256, 173)
        Me.Philhealth.Name = "Philhealth"
        Me.Philhealth.ReadOnly = True
        Me.Philhealth.Size = New System.Drawing.Size(204, 30)
        Me.Philhealth.TabIndex = 47
        '
        'SSS
        '
        Me.SSS.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SSS.Location = New System.Drawing.Point(256, 244)
        Me.SSS.Name = "SSS"
        Me.SSS.ReadOnly = True
        Me.SSS.Size = New System.Drawing.Size(204, 30)
        Me.SSS.TabIndex = 48
        '
        'Tab
        '
        Me.Tab.Controls.Add(Me.Database)
        Me.Tab.Controls.Add(Me.TabPage2)
        Me.Tab.Location = New System.Drawing.Point(767, 104)
        Me.Tab.Name = "Tab"
        Me.Tab.SelectedIndex = 0
        Me.Tab.Size = New System.Drawing.Size(555, 418)
        Me.Tab.TabIndex = 49
        '
        'Database
        '
        Me.Database.Controls.Add(Me.DataGridView1)
        Me.Database.Location = New System.Drawing.Point(4, 22)
        Me.Database.Name = "Database"
        Me.Database.Padding = New System.Windows.Forms.Padding(3)
        Me.Database.Size = New System.Drawing.Size(547, 392)
        Me.Database.TabIndex = 0
        Me.Database.Text = "Database"
        Me.Database.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.PayDataGridViewTextBoxColumn, Me.HoursDataGridViewTextBoxColumn, Me.DaysDataGridViewTextBoxColumn, Me.OvertimeDataGridViewTextBoxColumn, Me.GrossSalaryDataGridViewTextBoxColumn, Me.TaxDeductionDataGridViewTextBoxColumn, Me.PhilhealthContributionDataGridViewTextBoxColumn, Me.SSSContributionDataGridViewTextBoxColumn, Me.TotalDeductionDataGridViewTextBoxColumn, Me.NetSalaryDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EmployeesBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(541, 386)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'PayDataGridViewTextBoxColumn
        '
        Me.PayDataGridViewTextBoxColumn.DataPropertyName = "Pay"
        Me.PayDataGridViewTextBoxColumn.HeaderText = "Pay"
        Me.PayDataGridViewTextBoxColumn.Name = "PayDataGridViewTextBoxColumn"
        '
        'HoursDataGridViewTextBoxColumn
        '
        Me.HoursDataGridViewTextBoxColumn.DataPropertyName = "Hours"
        Me.HoursDataGridViewTextBoxColumn.HeaderText = "Hours"
        Me.HoursDataGridViewTextBoxColumn.Name = "HoursDataGridViewTextBoxColumn"
        '
        'DaysDataGridViewTextBoxColumn
        '
        Me.DaysDataGridViewTextBoxColumn.DataPropertyName = "Days"
        Me.DaysDataGridViewTextBoxColumn.HeaderText = "Days"
        Me.DaysDataGridViewTextBoxColumn.Name = "DaysDataGridViewTextBoxColumn"
        '
        'OvertimeDataGridViewTextBoxColumn
        '
        Me.OvertimeDataGridViewTextBoxColumn.DataPropertyName = "Overtime"
        Me.OvertimeDataGridViewTextBoxColumn.HeaderText = "Overtime"
        Me.OvertimeDataGridViewTextBoxColumn.Name = "OvertimeDataGridViewTextBoxColumn"
        '
        'GrossSalaryDataGridViewTextBoxColumn
        '
        Me.GrossSalaryDataGridViewTextBoxColumn.DataPropertyName = "Gross salary"
        Me.GrossSalaryDataGridViewTextBoxColumn.HeaderText = "Gross salary"
        Me.GrossSalaryDataGridViewTextBoxColumn.Name = "GrossSalaryDataGridViewTextBoxColumn"
        '
        'TaxDeductionDataGridViewTextBoxColumn
        '
        Me.TaxDeductionDataGridViewTextBoxColumn.DataPropertyName = "Tax Deduction"
        Me.TaxDeductionDataGridViewTextBoxColumn.HeaderText = "Tax Deduction"
        Me.TaxDeductionDataGridViewTextBoxColumn.Name = "TaxDeductionDataGridViewTextBoxColumn"
        '
        'PhilhealthContributionDataGridViewTextBoxColumn
        '
        Me.PhilhealthContributionDataGridViewTextBoxColumn.DataPropertyName = "Philhealth contribution\"
        Me.PhilhealthContributionDataGridViewTextBoxColumn.HeaderText = "Philhealth contribution\"
        Me.PhilhealthContributionDataGridViewTextBoxColumn.Name = "PhilhealthContributionDataGridViewTextBoxColumn"
        '
        'SSSContributionDataGridViewTextBoxColumn
        '
        Me.SSSContributionDataGridViewTextBoxColumn.DataPropertyName = "SSS Contribution"
        Me.SSSContributionDataGridViewTextBoxColumn.HeaderText = "SSS Contribution"
        Me.SSSContributionDataGridViewTextBoxColumn.Name = "SSSContributionDataGridViewTextBoxColumn"
        '
        'TotalDeductionDataGridViewTextBoxColumn
        '
        Me.TotalDeductionDataGridViewTextBoxColumn.DataPropertyName = "Total Deduction"
        Me.TotalDeductionDataGridViewTextBoxColumn.HeaderText = "Total Deduction"
        Me.TotalDeductionDataGridViewTextBoxColumn.Name = "TotalDeductionDataGridViewTextBoxColumn"
        '
        'NetSalaryDataGridViewTextBoxColumn
        '
        Me.NetSalaryDataGridViewTextBoxColumn.DataPropertyName = "Net Salary"
        Me.NetSalaryDataGridViewTextBoxColumn.HeaderText = "Net Salary"
        Me.NetSalaryDataGridViewTextBoxColumn.Name = "NetSalaryDataGridViewTextBoxColumn"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.DarkGray
        Me.TabPage2.Controls.Add(Me.Payslip)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(547, 392)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Payslip"
        '
        'Payslip
        '
        Me.Payslip.Location = New System.Drawing.Point(6, 0)
        Me.Payslip.Multiline = True
        Me.Payslip.Name = "Payslip"
        Me.Payslip.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Payslip.Size = New System.Drawing.Size(535, 392)
        Me.Payslip.TabIndex = 0
        '
        'Insert
        '
        Me.Insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Insert.Location = New System.Drawing.Point(490, 553)
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(204, 53)
        Me.Insert.TabIndex = 8
        Me.Insert.Text = "INSERT"
        Me.Insert.UseVisualStyleBackColor = True
        '
        'save
        '
        Me.save.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.save.Location = New System.Drawing.Point(841, 553)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(204, 53)
        Me.save.TabIndex = 9
        Me.save.Text = "SAVE"
        Me.save.UseVisualStyleBackColor = True
        '
        'Add
        '
        Me.Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Add.Location = New System.Drawing.Point(24, 553)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(204, 53)
        Me.Add.TabIndex = 1
        Me.Add.Text = "NEW"
        Me.Add.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
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
        'AUlogo
        '
        Me.AUlogo.BackColor = System.Drawing.Color.SteelBlue
        Me.AUlogo.Image = Global.Payroll_System.My.Resources.Resources.download
        Me.AUlogo.Location = New System.Drawing.Point(5, 0)
        Me.AUlogo.Name = "AUlogo"
        Me.AUlogo.Size = New System.Drawing.Size(68, 69)
        Me.AUlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AUlogo.TabIndex = 50
        Me.AUlogo.TabStop = False
        '
        'EmployeesTableAdapter
        '
        Me.EmployeesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmployeesTableAdapter = Me.EmployeesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Payroll_System.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.AdminsTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Payroll_System.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Taxpercent
        '
        Me.Taxpercent.BackColor = System.Drawing.Color.LightGray
        Me.Taxpercent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Taxpercent.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Tax Deduction", True))
        Me.Taxpercent.Location = New System.Drawing.Point(436, 84)
        Me.Taxpercent.Name = "Taxpercent"
        Me.Taxpercent.Size = New System.Drawing.Size(24, 13)
        Me.Taxpercent.TabIndex = 51
        '
        'philhealthdeduc
        '
        Me.philhealthdeduc.BackColor = System.Drawing.Color.LightGray
        Me.philhealthdeduc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.philhealthdeduc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Tax Deduction", True))
        Me.philhealthdeduc.Location = New System.Drawing.Point(436, 153)
        Me.philhealthdeduc.Name = "philhealthdeduc"
        Me.philhealthdeduc.Size = New System.Drawing.Size(24, 13)
        Me.philhealthdeduc.TabIndex = 51
        '
        'sssdeduc
        '
        Me.sssdeduc.BackColor = System.Drawing.Color.LightGray
        Me.sssdeduc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.sssdeduc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Tax Deduction", True))
        Me.sssdeduc.Location = New System.Drawing.Point(436, 224)
        Me.sssdeduc.Name = "sssdeduc"
        Me.sssdeduc.Size = New System.Drawing.Size(24, 13)
        Me.sssdeduc.TabIndex = 51
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.sssdeduc)
        Me.Controls.Add(Me.philhealthdeduc)
        Me.Controls.Add(Me.Taxpercent)
        Me.Controls.Add(Me.AUlogo)
        Me.Controls.Add(Me.Tab)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Overtime)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.print)
        Me.Controls.Add(Me.Insert)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.NetSalary)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Deduction)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GrossSalary2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GrossSalary1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TotalDeduction)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.NumberOfDaysWorked)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SSS)
        Me.Controls.Add(Me.HourPerDay)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Philhealth)
        Me.Controls.Add(Me.RatePerHour)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MonthlyWageTax)
        Me.Controls.Add(Me.EmployeeName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Main"
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab.ResumeLayout(False)
        Me.Database.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.AUlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Deduction As TextBox
    Friend WithEvents TextBox12 As TextBox
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
    Friend WithEvents EmployeesTableAdapter As DatabaseDataSetTableAdapters.EmployeesTableAdapter
    Friend WithEvents TableAdapterManager As DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents print As Button
    Friend WithEvents MonthlyWageTax As TextBox
    Friend WithEvents Philhealth As TextBox
    Friend WithEvents Tab As TabControl
    Friend WithEvents Database As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Payslip As TextBox
    Friend WithEvents Insert As Button
    Friend WithEvents save As Button
    Friend WithEvents Add As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents AUlogo As PictureBox
    Friend WithEvents TableAdapterManager1 As DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoursDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DaysDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OvertimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GrossSalaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TaxDeductionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhilhealthContributionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SSSContributionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDeductionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NetSalaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Public WithEvents SSS As TextBox
    Friend WithEvents Taxpercent As TextBox
    Friend WithEvents philhealthdeduc As TextBox
    Friend WithEvents sssdeduc As TextBox
End Class
