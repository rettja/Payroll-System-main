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
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GrossSalary2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.NetSalary = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Overtime = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.preview = New System.Windows.Forms.Button()
        Me.MonthlyWageTax = New System.Windows.Forms.TextBox()
        Me.Philhealth = New System.Windows.Forms.TextBox()
        Me.SSS = New System.Windows.Forms.TextBox()
        Me.Tab = New System.Windows.Forms.TabControl()
        Me.Database = New System.Windows.Forms.TabPage()
        Me.Paid_WorkersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayslipTab = New System.Windows.Forms.TabPage()
        Me.PrintPreviewControl1 = New System.Windows.Forms.PrintPreviewControl()
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
        Me.print = New System.Windows.Forms.Button()
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
        Me.Employees_Unpaid_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New Payroll_System.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.TableAdapterManager1 = New Payroll_System.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.WorkersTableAdapter = New Payroll_System.DatabaseDataSetTableAdapters.WorkersTableAdapter()
        Me.Paid_WorkersTableAdapter = New Payroll_System.DatabaseDataSetTableAdapters.Paid_WorkersTableAdapter()
        Me.Payslip = New System.Windows.Forms.TextBox()
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
        Me.Tab.SuspendLayout()
        Me.Database.SuspendLayout()
        CType(Me.Paid_WorkersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PayslipTab.SuspendLayout()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.WorkersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
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
        Me.EmployeeName.Location = New System.Drawing.Point(18, 200)
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
        Me.Label2.Location = New System.Drawing.Point(15, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "EMPLOYEE NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(15, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "RATE PER HOUR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(15, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "HOUR PER DAY"
        '
        'HourPerDay
        '
        Me.HourPerDay.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaidWorkersBindingSource, "Hours", True))
        Me.HourPerDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HourPerDay.Location = New System.Drawing.Point(18, 340)
        Me.HourPerDay.Name = "HourPerDay"
        Me.HourPerDay.Size = New System.Drawing.Size(204, 30)
        Me.HourPerDay.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(15, 390)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "NO. OF DAYS WORKED"
        '
        'NumberOfDaysWorked
        '
        Me.NumberOfDaysWorked.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaidWorkersBindingSource, "Days", True))
        Me.NumberOfDaysWorked.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfDaysWorked.Location = New System.Drawing.Point(18, 410)
        Me.NumberOfDaysWorked.Name = "NumberOfDaysWorked"
        Me.NumberOfDaysWorked.Size = New System.Drawing.Size(204, 30)
        Me.NumberOfDaysWorked.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(247, 568)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "TOTAL DEDUCTION"
        '
        'TotalDeduction
        '
        Me.TotalDeduction.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaidWorkersBindingSource, "Total_Dedcution", True))
        Me.TotalDeduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalDeduction.Location = New System.Drawing.Point(250, 588)
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
        Me.GrossSalary1.Location = New System.Drawing.Point(18, 588)
        Me.GrossSalary1.Name = "GrossSalary1"
        Me.GrossSalary1.ReadOnly = True
        Me.GrossSalary1.ShortcutsEnabled = False
        Me.GrossSalary1.Size = New System.Drawing.Size(204, 30)
        Me.GrossSalary1.TabIndex = 100
        Me.GrossSalary1.TabStop = False
        '
        'RatePerHour
        '
        Me.RatePerHour.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaidWorkersBindingSource, "Pay", True))
        Me.RatePerHour.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RatePerHour.Location = New System.Drawing.Point(18, 269)
        Me.RatePerHour.Name = "RatePerHour"
        Me.RatePerHour.Size = New System.Drawing.Size(204, 30)
        Me.RatePerHour.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(247, 320)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 17)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "SSS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(247, 249)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 17)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "PHIL HEALTH"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(247, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(176, 17)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "TAX OF MONTHLY WAGE"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(481, 249)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 17)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "DEDUCTION"
        '
        'Deduction
        '
        Me.Deduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deduction.Location = New System.Drawing.Point(484, 269)
        Me.Deduction.Name = "Deduction"
        Me.Deduction.ReadOnly = True
        Me.Deduction.ShortcutsEnabled = False
        Me.Deduction.Size = New System.Drawing.Size(204, 30)
        Me.Deduction.TabIndex = 100
        Me.Deduction.TabStop = False
        '
        'TextBox12
        '
        Me.TextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(484, 269)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(204, 30)
        Me.TextBox12.TabIndex = 39
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(481, 180)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 17)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "GROSS SALARY"
        '
        'GrossSalary2
        '
        Me.GrossSalary2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrossSalary2.Location = New System.Drawing.Point(484, 200)
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
        Me.Label13.Location = New System.Drawing.Point(481, 568)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 17)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "NET SALARY"
        '
        'NetSalary
        '
        Me.NetSalary.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaidWorkersBindingSource, "Net_Salary", True))
        Me.NetSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetSalary.Location = New System.Drawing.Point(484, 588)
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
        Me.Button1.Location = New System.Drawing.Point(216, 657)
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
        Me.Label10.Location = New System.Drawing.Point(15, 460)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 17)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "OVERTIME HOURS"
        '
        'Overtime
        '
        Me.Overtime.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaidWorkersBindingSource, "Overtime", True))
        Me.Overtime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Overtime.Location = New System.Drawing.Point(18, 480)
        Me.Overtime.Name = "Overtime"
        Me.Overtime.Size = New System.Drawing.Size(204, 30)
        Me.Overtime.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(15, 568)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(128, 17)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "GROSS SALARY"
        '
        'preview
        '
        Me.preview.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.preview.Location = New System.Drawing.Point(828, 624)
        Me.preview.Name = "preview"
        Me.preview.Size = New System.Drawing.Size(120, 31)
        Me.preview.TabIndex = 10
        Me.preview.Text = "Preview "
        Me.preview.UseVisualStyleBackColor = True
        '
        'MonthlyWageTax
        '
        Me.MonthlyWageTax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaidWorkersBindingSource, "Tax Deduction", True))
        Me.MonthlyWageTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthlyWageTax.Location = New System.Drawing.Point(250, 200)
        Me.MonthlyWageTax.Name = "MonthlyWageTax"
        Me.MonthlyWageTax.ReadOnly = True
        Me.MonthlyWageTax.ShortcutsEnabled = False
        Me.MonthlyWageTax.Size = New System.Drawing.Size(204, 30)
        Me.MonthlyWageTax.TabIndex = 100
        Me.MonthlyWageTax.TabStop = False
        '
        'Philhealth
        '
        Me.Philhealth.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaidWorkersBindingSource, "PhilHealth_Contribution", True))
        Me.Philhealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Philhealth.Location = New System.Drawing.Point(250, 269)
        Me.Philhealth.Name = "Philhealth"
        Me.Philhealth.ReadOnly = True
        Me.Philhealth.ShortcutsEnabled = False
        Me.Philhealth.Size = New System.Drawing.Size(204, 30)
        Me.Philhealth.TabIndex = 100
        Me.Philhealth.TabStop = False
        '
        'SSS
        '
        Me.SSS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaidWorkersBindingSource, "SSS_Contribution", True))
        Me.SSS.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SSS.Location = New System.Drawing.Point(250, 340)
        Me.SSS.Name = "SSS"
        Me.SSS.ReadOnly = True
        Me.SSS.ShortcutsEnabled = False
        Me.SSS.Size = New System.Drawing.Size(204, 30)
        Me.SSS.TabIndex = 100
        Me.SSS.TabStop = False
        '
        'Tab
        '
        Me.Tab.Controls.Add(Me.Database)
        Me.Tab.Controls.Add(Me.PayslipTab)
        Me.Tab.Location = New System.Drawing.Point(694, 74)
        Me.Tab.Name = "Tab"
        Me.Tab.SelectedIndex = 0
        Me.Tab.Size = New System.Drawing.Size(667, 544)
        Me.Tab.TabIndex = 49
        '
        'Database
        '
        Me.Database.AutoScroll = True
        Me.Database.Controls.Add(Me.Paid_WorkersDataGridView)
        Me.Database.Location = New System.Drawing.Point(4, 22)
        Me.Database.Name = "Database"
        Me.Database.Padding = New System.Windows.Forms.Padding(3)
        Me.Database.Size = New System.Drawing.Size(659, 518)
        Me.Database.TabIndex = 0
        Me.Database.Text = "Database"
        Me.Database.UseVisualStyleBackColor = True
        '
        'Paid_WorkersDataGridView
        '
        Me.Paid_WorkersDataGridView.AutoGenerateColumns = False
        Me.Paid_WorkersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Paid_WorkersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.Paid_WorkersDataGridView.DataSource = Me.PaidWorkersBindingSource
        Me.Paid_WorkersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Paid_WorkersDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.Paid_WorkersDataGridView.Name = "Paid_WorkersDataGridView"
        Me.Paid_WorkersDataGridView.Size = New System.Drawing.Size(653, 512)
        Me.Paid_WorkersDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Pay"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Pay"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Hours"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Hours"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Days"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Days"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Regular_Holiday"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Regular_Holiday"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Special_Holiday"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Special_Holiday"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Overtime"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Overtime"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Gross_Salary"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Gross_Salary"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Tax Deduction"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Tax Deduction"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "PhilHealth_Contribution"
        Me.DataGridViewTextBoxColumn12.HeaderText = "PhilHealth_Contribution"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "SSS_Contribution"
        Me.DataGridViewTextBoxColumn13.HeaderText = "SSS_Contribution"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Total_Dedcution"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Total_Dedcution"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Net_Salary"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Net_Salary"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'PayslipTab
        '
        Me.PayslipTab.BackColor = System.Drawing.Color.DarkGray
        Me.PayslipTab.Controls.Add(Me.PrintPreviewControl1)
        Me.PayslipTab.Controls.Add(Me.Payslip)
        Me.PayslipTab.Location = New System.Drawing.Point(4, 22)
        Me.PayslipTab.Name = "PayslipTab"
        Me.PayslipTab.Padding = New System.Windows.Forms.Padding(3)
        Me.PayslipTab.Size = New System.Drawing.Size(659, 518)
        Me.PayslipTab.TabIndex = 1
        Me.PayslipTab.Text = "Payslip"
        '
        'PrintPreviewControl1
        '
        Me.PrintPreviewControl1.AutoZoom = False
        Me.PrintPreviewControl1.Document = Me.PrintDocument1
        Me.PrintPreviewControl1.Location = New System.Drawing.Point(4, 1)
        Me.PrintPreviewControl1.Name = "PrintPreviewControl1"
        Me.PrintPreviewControl1.Size = New System.Drawing.Size(659, 517)
        Me.PrintPreviewControl1.TabIndex = 0
        Me.PrintPreviewControl1.Zoom = 0.7431137724550898R
        '
        'PrintDocument1
        '
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Agency FB", 33.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(588, -4)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(224, 53)
        Me.Label17.TabIndex = 56
        Me.Label17.Text = "Payroll System"
        '
        'Insert
        '
        Me.Insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Insert.Location = New System.Drawing.Point(351, 657)
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(128, 53)
        Me.Insert.TabIndex = 8
        Me.Insert.Text = "INSERT"
        Me.Insert.UseVisualStyleBackColor = True
        '
        'save
        '
        Me.save.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.save.Location = New System.Drawing.Point(485, 657)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(128, 53)
        Me.save.TabIndex = 9
        Me.save.Text = "SAVE"
        Me.save.UseVisualStyleBackColor = True
        '
        'Add
        '
        Me.Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Add.Location = New System.Drawing.Point(79, 657)
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
        Me.Taxpercent.Location = New System.Drawing.Point(430, 180)
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
        Me.philhealthdeduc.Location = New System.Drawing.Point(430, 249)
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
        Me.sssdeduc.Location = New System.Drawing.Point(430, 320)
        Me.sssdeduc.Name = "sssdeduc"
        Me.sssdeduc.Size = New System.Drawing.Size(24, 13)
        Me.sssdeduc.TabIndex = 51
        Me.sssdeduc.TabStop = False
        '
        'print
        '
        Me.print.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.print.Location = New System.Drawing.Point(1126, 624)
        Me.print.Name = "print"
        Me.print.Size = New System.Drawing.Size(120, 31)
        Me.print.TabIndex = 11
        Me.print.Text = "Print"
        Me.print.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.exit1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1472, 49)
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
        Me.exit1.Location = New System.Drawing.Point(1425, 0)
        Me.exit1.Name = "exit1"
        Me.exit1.Size = New System.Drawing.Size(47, 49)
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
        Me.Button2.Location = New System.Drawing.Point(504, 67)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 20)
        Me.Button2.TabIndex = 16
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
        Me.Panel2.Location = New System.Drawing.Point(12, 74)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(676, 100)
        Me.Panel2.TabIndex = 102
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
        'Payslip
        '
        Me.Payslip.Location = New System.Drawing.Point(256, 173)
        Me.Payslip.Name = "Payslip"
        Me.Payslip.Size = New System.Drawing.Size(100, 20)
        Me.Payslip.TabIndex = 103
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1472, 760)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.sssdeduc)
        Me.Controls.Add(Me.philhealthdeduc)
        Me.Controls.Add(Me.Taxpercent)
        Me.Controls.Add(Me.Tab)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Overtime)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.print)
        Me.Controls.Add(Me.preview)
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
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PaidWorkersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab.ResumeLayout(False)
        Me.Database.ResumeLayout(False)
        CType(Me.Paid_WorkersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PayslipTab.ResumeLayout(False)
        Me.PayslipTab.PerformLayout()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.WorkersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Employees_Unpaid_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TableAdapterManager As DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents preview As Button
    Friend WithEvents MonthlyWageTax As TextBox
    Friend WithEvents Philhealth As TextBox
    Friend WithEvents Tab As TabControl
    Friend WithEvents Database As TabPage
    Friend WithEvents PayslipTab As TabPage
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
    Friend WithEvents print As Button
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
    Friend WithEvents Paid_WorkersDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents PrintPreviewControl1 As PrintPreviewControl
    Friend WithEvents Payslip As TextBox
End Class
