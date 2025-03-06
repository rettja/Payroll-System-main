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
        Dim IDLabel As System.Windows.Forms.Label
        Dim EmployeesLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim BirthdayLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim AdressLabel As System.Windows.Forms.Label
        Dim Civil_StatusLabel As System.Windows.Forms.Label
        Dim WorkLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.EmployeeName = New System.Windows.Forms.TextBox()
        Me.Paid_EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.preview = New System.Windows.Forms.Button()
        Me.MonthlyWageTax = New System.Windows.Forms.TextBox()
        Me.Philhealth = New System.Windows.Forms.TextBox()
        Me.SSS = New System.Windows.Forms.TextBox()
        Me.Tab = New System.Windows.Forms.TabControl()
        Me.Database = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Payslip = New System.Windows.Forms.TextBox()
        Me.Insert = New System.Windows.Forms.Button()
        Me.save = New System.Windows.Forms.Button()
        Me.Add = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Taxpercent = New System.Windows.Forms.TextBox()
        Me.philhealthdeduc = New System.Windows.Forms.TextBox()
        Me.sssdeduc = New System.Windows.Forms.TextBox()
        Me.print = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Previous = New System.Windows.Forms.Button()
        Me.Next2 = New System.Windows.Forms.Button()
        Me.WorkTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Civil_StatusTextBox = New System.Windows.Forms.TextBox()
        Me.AdressTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.BirthdayTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeesID = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Employees_Unpaid_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeesTableAdapter = New Payroll_System.DatabaseDataSetTableAdapters.EmployeesTableAdapter()
        Me.TableAdapterManager = New Payroll_System.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.Paid_EmployeesTableAdapter = New Payroll_System.DatabaseDataSetTableAdapters.Paid_EmployeesTableAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        EmployeesLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        BirthdayLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        AdressLabel = New System.Windows.Forms.Label()
        Civil_StatusLabel = New System.Windows.Forms.Label()
        WorkLabel = New System.Windows.Forms.Label()
        CType(Me.Paid_EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab.SuspendLayout()
        Me.Database.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.EmployeesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Employees_Unpaid_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(6, 15)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 0
        IDLabel.Text = "ID:"
        '
        'EmployeesLabel
        '
        EmployeesLabel.AutoSize = True
        EmployeesLabel.Location = New System.Drawing.Point(59, 16)
        EmployeesLabel.Name = "EmployeesLabel"
        EmployeesLabel.Size = New System.Drawing.Size(61, 13)
        EmployeesLabel.TabIndex = 2
        EmployeesLabel.Text = "Employees:"
        AddHandler EmployeesLabel.Click, AddressOf Me.EmployeesLabel_Click
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(7, 55)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(29, 13)
        AgeLabel.TabIndex = 4
        AgeLabel.Text = "Age:"
        '
        'BirthdayLabel
        '
        BirthdayLabel.AutoSize = True
        BirthdayLabel.Location = New System.Drawing.Point(59, 55)
        BirthdayLabel.Name = "BirthdayLabel"
        BirthdayLabel.Size = New System.Drawing.Size(48, 13)
        BirthdayLabel.TabIndex = 6
        BirthdayLabel.Text = "Birthday:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(157, 55)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 8
        GenderLabel.Text = "Gender:"
        '
        'AdressLabel
        '
        AdressLabel.AutoSize = True
        AdressLabel.Location = New System.Drawing.Point(247, 15)
        AdressLabel.Name = "AdressLabel"
        AdressLabel.Size = New System.Drawing.Size(42, 13)
        AdressLabel.TabIndex = 10
        AdressLabel.Text = "Adress:"
        AddHandler AdressLabel.Click, AddressOf Me.AdressLabel_Click
        '
        'Civil_StatusLabel
        '
        Civil_StatusLabel.AutoSize = True
        Civil_StatusLabel.Location = New System.Drawing.Point(247, 55)
        Civil_StatusLabel.Name = "Civil_StatusLabel"
        Civil_StatusLabel.Size = New System.Drawing.Size(62, 13)
        Civil_StatusLabel.TabIndex = 12
        Civil_StatusLabel.Text = "Civil Status:"
        '
        'WorkLabel
        '
        WorkLabel.AutoSize = True
        WorkLabel.Location = New System.Drawing.Point(329, 58)
        WorkLabel.Name = "WorkLabel"
        WorkLabel.Size = New System.Drawing.Size(36, 13)
        WorkLabel.TabIndex = 14
        WorkLabel.Text = "Work:"
        '
        'EmployeeName
        '
        Me.EmployeeName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Paid_EmployeesBindingSource, "Name", True))
        Me.EmployeeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeName.Location = New System.Drawing.Point(27, 201)
        Me.EmployeeName.Multiline = True
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.ReadOnly = True
        Me.EmployeeName.ShortcutsEnabled = False
        Me.EmployeeName.Size = New System.Drawing.Size(204, 30)
        Me.EmployeeName.TabIndex = 100
        Me.EmployeeName.TabStop = False
        '
        'Paid_EmployeesBindingSource
        '
        Me.Paid_EmployeesBindingSource.DataMember = "Paid_Employees"
        Me.Paid_EmployeesBindingSource.DataSource = Me.DatabaseDataSet
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
        Me.Label2.Location = New System.Drawing.Point(24, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "EMPLOYEE NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(24, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "RATE PER HOUR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(24, 321)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "HOUR PER DAY"
        '
        'HourPerDay
        '
        Me.HourPerDay.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Paid_EmployeesBindingSource, "Hours", True))
        Me.HourPerDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HourPerDay.Location = New System.Drawing.Point(27, 341)
        Me.HourPerDay.Name = "HourPerDay"
        Me.HourPerDay.Size = New System.Drawing.Size(204, 30)
        Me.HourPerDay.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(24, 391)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "NO. OF DAYS WORKED"
        '
        'NumberOfDaysWorked
        '
        Me.NumberOfDaysWorked.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Paid_EmployeesBindingSource, "Days", True))
        Me.NumberOfDaysWorked.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfDaysWorked.Location = New System.Drawing.Point(27, 411)
        Me.NumberOfDaysWorked.Name = "NumberOfDaysWorked"
        Me.NumberOfDaysWorked.Size = New System.Drawing.Size(204, 30)
        Me.NumberOfDaysWorked.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(256, 569)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "TOTAL DEDUCTION"
        '
        'TotalDeduction
        '
        Me.TotalDeduction.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Paid_EmployeesBindingSource, "Total Deduction", True))
        Me.TotalDeduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalDeduction.Location = New System.Drawing.Point(259, 589)
        Me.TotalDeduction.Name = "TotalDeduction"
        Me.TotalDeduction.ReadOnly = True
        Me.TotalDeduction.ShortcutsEnabled = False
        Me.TotalDeduction.Size = New System.Drawing.Size(204, 30)
        Me.TotalDeduction.TabIndex = 100
        Me.TotalDeduction.TabStop = False
        '
        'GrossSalary1
        '
        Me.GrossSalary1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Paid_EmployeesBindingSource, "Gross salary", True))
        Me.GrossSalary1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrossSalary1.Location = New System.Drawing.Point(27, 589)
        Me.GrossSalary1.Name = "GrossSalary1"
        Me.GrossSalary1.ReadOnly = True
        Me.GrossSalary1.ShortcutsEnabled = False
        Me.GrossSalary1.Size = New System.Drawing.Size(204, 30)
        Me.GrossSalary1.TabIndex = 100
        Me.GrossSalary1.TabStop = False
        '
        'RatePerHour
        '
        Me.RatePerHour.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Paid_EmployeesBindingSource, "Pay", True))
        Me.RatePerHour.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RatePerHour.Location = New System.Drawing.Point(27, 270)
        Me.RatePerHour.Name = "RatePerHour"
        Me.RatePerHour.Size = New System.Drawing.Size(204, 30)
        Me.RatePerHour.TabIndex = 2
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
        Me.Label7.Location = New System.Drawing.Point(256, 321)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 17)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "SSS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(256, 250)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 17)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "PHIL HEALTH"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(256, 181)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(176, 17)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "TAX OF MONTHLY WAGE"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(490, 250)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 17)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "DEDUCTION"
        '
        'Deduction
        '
        Me.Deduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deduction.Location = New System.Drawing.Point(493, 270)
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
        Me.TextBox12.Location = New System.Drawing.Point(493, 270)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(204, 30)
        Me.TextBox12.TabIndex = 39
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(490, 181)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 17)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "GROSS SALARY"
        '
        'GrossSalary2
        '
        Me.GrossSalary2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrossSalary2.Location = New System.Drawing.Point(493, 201)
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
        Me.Label13.Location = New System.Drawing.Point(490, 569)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 17)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "NET SALARY"
        '
        'NetSalary
        '
        Me.NetSalary.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Paid_EmployeesBindingSource, "Net Salary", True))
        Me.NetSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetSalary.Location = New System.Drawing.Point(493, 589)
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
        Me.Button1.Location = New System.Drawing.Point(225, 659)
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
        Me.Label10.Location = New System.Drawing.Point(24, 461)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 17)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "OVERTIME HOURS"
        '
        'Overtime
        '
        Me.Overtime.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Paid_EmployeesBindingSource, "Overtime", True))
        Me.Overtime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Overtime.Location = New System.Drawing.Point(27, 481)
        Me.Overtime.Name = "Overtime"
        Me.Overtime.Size = New System.Drawing.Size(204, 30)
        Me.Overtime.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(24, 569)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(128, 17)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "GROSS SALARY"
        '
        'preview
        '
        Me.preview.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.preview.Location = New System.Drawing.Point(837, 625)
        Me.preview.Name = "preview"
        Me.preview.Size = New System.Drawing.Size(120, 31)
        Me.preview.TabIndex = 10
        Me.preview.Text = "Preview "
        Me.preview.UseVisualStyleBackColor = True
        '
        'MonthlyWageTax
        '
        Me.MonthlyWageTax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Paid_EmployeesBindingSource, "Tax Deduction", True))
        Me.MonthlyWageTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthlyWageTax.Location = New System.Drawing.Point(259, 201)
        Me.MonthlyWageTax.Name = "MonthlyWageTax"
        Me.MonthlyWageTax.ReadOnly = True
        Me.MonthlyWageTax.ShortcutsEnabled = False
        Me.MonthlyWageTax.Size = New System.Drawing.Size(204, 30)
        Me.MonthlyWageTax.TabIndex = 100
        Me.MonthlyWageTax.TabStop = False
        '
        'Philhealth
        '
        Me.Philhealth.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Paid_EmployeesBindingSource, "Philhealth Contribution", True))
        Me.Philhealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Philhealth.Location = New System.Drawing.Point(259, 270)
        Me.Philhealth.Name = "Philhealth"
        Me.Philhealth.ReadOnly = True
        Me.Philhealth.ShortcutsEnabled = False
        Me.Philhealth.Size = New System.Drawing.Size(204, 30)
        Me.Philhealth.TabIndex = 100
        Me.Philhealth.TabStop = False
        '
        'SSS
        '
        Me.SSS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Paid_EmployeesBindingSource, "SSS Contribution", True))
        Me.SSS.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SSS.Location = New System.Drawing.Point(259, 341)
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
        Me.Tab.Controls.Add(Me.TabPage2)
        Me.Tab.Location = New System.Drawing.Point(703, 75)
        Me.Tab.Name = "Tab"
        Me.Tab.SelectedIndex = 0
        Me.Tab.Size = New System.Drawing.Size(667, 544)
        Me.Tab.TabIndex = 49
        '
        'Database
        '
        Me.Database.AutoScroll = True
        Me.Database.Controls.Add(Me.DataGridView1)
        Me.Database.Location = New System.Drawing.Point(4, 22)
        Me.Database.Name = "Database"
        Me.Database.Padding = New System.Windows.Forms.Padding(3)
        Me.Database.Size = New System.Drawing.Size(659, 518)
        Me.Database.TabIndex = 0
        Me.Database.Text = "Database"
        Me.Database.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.DataGridView1.DataSource = Me.Paid_EmployeesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(642, 522)
        Me.DataGridView1.TabIndex = 100
        Me.DataGridView1.TabStop = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Name"
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
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Overtime"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Overtime"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Gross salary"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Gross salary"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Tax Deduction"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Tax Deduction"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Philhealth Contribution"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Philhealth Contribution"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "SSS Contribution"
        Me.DataGridViewTextBoxColumn11.HeaderText = "SSS Contribution"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Total Deduction"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Total Deduction"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Net Salary"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Net Salary"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.DarkGray
        Me.TabPage2.Controls.Add(Me.Payslip)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(659, 518)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Payslip"
        '
        'Payslip
        '
        Me.Payslip.Location = New System.Drawing.Point(0, 0)
        Me.Payslip.Multiline = True
        Me.Payslip.Name = "Payslip"
        Me.Payslip.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Payslip.Size = New System.Drawing.Size(663, 518)
        Me.Payslip.TabIndex = 0
        '
        'Insert
        '
        Me.Insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Insert.Location = New System.Drawing.Point(360, 659)
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(128, 53)
        Me.Insert.TabIndex = 8
        Me.Insert.Text = "INSERT"
        Me.Insert.UseVisualStyleBackColor = True
        '
        'save
        '
        Me.save.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.save.Location = New System.Drawing.Point(494, 659)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(128, 53)
        Me.save.TabIndex = 9
        Me.save.Text = "SAVE"
        Me.save.UseVisualStyleBackColor = True
        '
        'Add
        '
        Me.Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Add.Location = New System.Drawing.Point(88, 659)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(128, 53)
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
        'Taxpercent
        '
        Me.Taxpercent.BackColor = System.Drawing.Color.LightGray
        Me.Taxpercent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Taxpercent.Location = New System.Drawing.Point(439, 181)
        Me.Taxpercent.Name = "Taxpercent"
        Me.Taxpercent.Size = New System.Drawing.Size(24, 13)
        Me.Taxpercent.TabIndex = 51
        Me.Taxpercent.TabStop = False
        '
        'philhealthdeduc
        '
        Me.philhealthdeduc.BackColor = System.Drawing.Color.LightGray
        Me.philhealthdeduc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.philhealthdeduc.Location = New System.Drawing.Point(439, 250)
        Me.philhealthdeduc.Name = "philhealthdeduc"
        Me.philhealthdeduc.Size = New System.Drawing.Size(24, 13)
        Me.philhealthdeduc.TabIndex = 51
        Me.philhealthdeduc.TabStop = False
        '
        'sssdeduc
        '
        Me.sssdeduc.BackColor = System.Drawing.Color.LightGray
        Me.sssdeduc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.sssdeduc.Location = New System.Drawing.Point(439, 321)
        Me.sssdeduc.Name = "sssdeduc"
        Me.sssdeduc.Size = New System.Drawing.Size(24, 13)
        Me.sssdeduc.TabIndex = 51
        Me.sssdeduc.TabStop = False
        '
        'print
        '
        Me.print.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.print.Location = New System.Drawing.Point(1135, 625)
        Me.print.Name = "print"
        Me.print.Size = New System.Drawing.Size(120, 31)
        Me.print.TabIndex = 11
        Me.print.Text = "Print"
        Me.print.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Controls.Add(Me.Previous)
        Me.GroupBox1.Controls.Add(WorkLabel)
        Me.GroupBox1.Controls.Add(Me.Next2)
        Me.GroupBox1.Controls.Add(Me.WorkTextBox)
        Me.GroupBox1.Controls.Add(Civil_StatusLabel)
        Me.GroupBox1.Controls.Add(Me.Civil_StatusTextBox)
        Me.GroupBox1.Controls.Add(AdressLabel)
        Me.GroupBox1.Controls.Add(Me.AdressTextBox)
        Me.GroupBox1.Controls.Add(GenderLabel)
        Me.GroupBox1.Controls.Add(Me.GenderTextBox)
        Me.GroupBox1.Controls.Add(BirthdayLabel)
        Me.GroupBox1.Controls.Add(Me.BirthdayTextBox)
        Me.GroupBox1.Controls.Add(AgeLabel)
        Me.GroupBox1.Controls.Add(Me.AgeTextBox)
        Me.GroupBox1.Controls.Add(EmployeesLabel)
        Me.GroupBox1.Controls.Add(Me.EmployeesID)
        Me.GroupBox1.Controls.Add(IDLabel)
        Me.GroupBox1.Controls.Add(Me.IDTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(670, 103)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information"
        '
        'Previous
        '
        Me.Previous.Location = New System.Drawing.Point(522, 67)
        Me.Previous.Name = "Previous"
        Me.Previous.Size = New System.Drawing.Size(68, 26)
        Me.Previous.TabIndex = 101
        Me.Previous.Text = "Previous"
        Me.Previous.UseVisualStyleBackColor = True
        '
        'Next2
        '
        Me.Next2.Location = New System.Drawing.Point(596, 67)
        Me.Next2.Name = "Next2"
        Me.Next2.Size = New System.Drawing.Size(68, 26)
        Me.Next2.TabIndex = 101
        Me.Next2.Text = "Next"
        Me.Next2.UseVisualStyleBackColor = True
        '
        'WorkTextBox
        '
        Me.WorkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource1, "Work", True))
        Me.WorkTextBox.Location = New System.Drawing.Point(332, 71)
        Me.WorkTextBox.Name = "WorkTextBox"
        Me.WorkTextBox.Size = New System.Drawing.Size(184, 20)
        Me.WorkTextBox.TabIndex = 15
        '
        'EmployeesBindingSource1
        '
        Me.EmployeesBindingSource1.DataMember = "Employees"
        Me.EmployeesBindingSource1.DataSource = Me.DatabaseDataSet
        '
        'Civil_StatusTextBox
        '
        Me.Civil_StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource1, "Civil Status", True))
        Me.Civil_StatusTextBox.Location = New System.Drawing.Point(250, 71)
        Me.Civil_StatusTextBox.Name = "Civil_StatusTextBox"
        Me.Civil_StatusTextBox.Size = New System.Drawing.Size(76, 20)
        Me.Civil_StatusTextBox.TabIndex = 13
        '
        'AdressTextBox
        '
        Me.AdressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource1, "Adress", True))
        Me.AdressTextBox.Location = New System.Drawing.Point(250, 31)
        Me.AdressTextBox.Name = "AdressTextBox"
        Me.AdressTextBox.Size = New System.Drawing.Size(266, 20)
        Me.AdressTextBox.TabIndex = 11
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource1, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(166, 71)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(78, 20)
        Me.GenderTextBox.TabIndex = 9
        '
        'BirthdayTextBox
        '
        Me.BirthdayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource1, "Birthday", True))
        Me.BirthdayTextBox.Location = New System.Drawing.Point(62, 71)
        Me.BirthdayTextBox.Name = "BirthdayTextBox"
        Me.BirthdayTextBox.Size = New System.Drawing.Size(98, 20)
        Me.BirthdayTextBox.TabIndex = 7
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource1, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(10, 71)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(46, 20)
        Me.AgeTextBox.TabIndex = 5
        '
        'EmployeesID
        '
        Me.EmployeesID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource1, "Employees", True))
        Me.EmployeesID.Location = New System.Drawing.Point(62, 31)
        Me.EmployeesID.Name = "EmployeesID"
        Me.EmployeesID.Size = New System.Drawing.Size(182, 20)
        Me.EmployeesID.TabIndex = 3
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource1, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(10, 31)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(46, 20)
        Me.IDTextBox.TabIndex = 1
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
        Me.TableAdapterManager.Paid_EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Payroll_System.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Paid_EmployeesTableAdapter
        '
        Me.Paid_EmployeesTableAdapter.ClearBeforeFill = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.SteelBlue
        Me.Button4.BackgroundImage = Global.Payroll_System.My.Resources.Resources._5244832
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Button4.Location = New System.Drawing.Point(1329, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(41, 34)
        Me.Button4.TabIndex = 101
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.sssdeduc)
        Me.Controls.Add(Me.Button4)
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
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Paid_EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab.ResumeLayout(False)
        Me.Database.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.EmployeesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents EmployeesBindingSource As BindingSource
    Friend WithEvents preview As Button
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

    Friend WithEvents PhilhealthContributionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Public WithEvents SSS As TextBox
    Friend WithEvents Taxpercent As TextBox
    Friend WithEvents philhealthdeduc As TextBox
    Friend WithEvents sssdeduc As TextBox
    Friend WithEvents print As Button

    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoursDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DaysDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OvertimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GrossSalaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TaxDeductionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SSSContributionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDeductionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NetSalaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Employees_Unpaid_BindingSource As BindingSource
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents exit1 As Button
    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents EmployeesBindingSource1 As BindingSource
    Friend WithEvents EmployeesTableAdapter As DatabaseDataSetTableAdapters.EmployeesTableAdapter
    Friend WithEvents TableAdapterManager As DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents EmployeesID As TextBox
    Friend WithEvents BirthdayTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents AdressTextBox As TextBox
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents WorkTextBox As TextBox
    Friend WithEvents Civil_StatusTextBox As TextBox
    Friend WithEvents Paid_EmployeesBindingSource As BindingSource
    Friend WithEvents Paid_EmployeesTableAdapter As DatabaseDataSetTableAdapters.Paid_EmployeesTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
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
    Friend WithEvents Previous As Button
    Friend WithEvents Next2 As Button
    Friend WithEvents Button4 As Button
End Class
