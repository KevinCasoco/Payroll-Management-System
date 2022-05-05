<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payroll
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payroll))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PayrollBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceiptDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceiptDataSet = New Payroll_Management_System.ReceiptDataSet()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PayrollDataSet = New Payroll_Management_System.PayrollDataSet()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.txtGross = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.txtSSS = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPagIbig = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPhilhealth = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNetpay = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.EmployeeTableAdapter = New Payroll_Management_System.PayrollDataSetTableAdapters.EmployeeTableAdapter()
        Me.cmbLastName = New System.Windows.Forms.ComboBox()
        Me.cmbPosition = New System.Windows.Forms.ComboBox()
        Me.cmbFirstName = New System.Windows.Forms.ComboBox()
        Me.PayrollTableAdapter = New Payroll_Management_System.ReceiptDataSetTableAdapters.PayrollTableAdapter()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EMPLOYEEIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POSITIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RATEPERDAYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WORKINGDAYSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GROSSPAYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SSSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PHILHEALTHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAGIBIGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NETPAYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALARYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATABASE = New System.Windows.Forms.TabControl()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.TableAdapterManager = New Payroll_Management_System.PayrollDataSetTableAdapters.TableAdapterManager()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblLogOut = New System.Windows.Forms.Label()
        Me.lblEmployee = New System.Windows.Forms.Label()
        Me.lblSystem = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        CType(Me.PayrollBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiptDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiptDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrollDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DATABASE.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EMPLOYEE ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(84, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "LAST NAME:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(84, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "FIRST NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(84, 330)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "POSITION:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(84, 388)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "RATE PER DAY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(84, 439)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(223, 22)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "NO OF WORKING DAYS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(632, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 22)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "GROSS PAY"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PayrollBindingSource, "EMPLOYEE ID", True))
        Me.ComboBox1.DataSource = Me.EmployeeBindingSource
        Me.ComboBox1.DisplayMember = "EMPLOYEE ID"
        Me.ComboBox1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(323, 160)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 30)
        Me.ComboBox1.TabIndex = 10
        Me.ComboBox1.ValueMember = "EMPLOYEE ID"
        '
        'PayrollBindingSource
        '
        Me.PayrollBindingSource.DataMember = "Payroll"
        Me.PayrollBindingSource.DataSource = Me.ReceiptDataSetBindingSource
        '
        'ReceiptDataSetBindingSource
        '
        Me.ReceiptDataSetBindingSource.DataSource = Me.ReceiptDataSet
        Me.ReceiptDataSetBindingSource.Position = 0
        '
        'ReceiptDataSet
        '
        Me.ReceiptDataSet.DataSetName = "ReceiptDataSet"
        Me.ReceiptDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.PayrollDataSet
        '
        'PayrollDataSet
        '
        Me.PayrollDataSet.DataSetName = "PayrollDataSet"
        Me.PayrollDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtRate
        '
        Me.txtRate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PayrollBindingSource, "RATE PER DAY", True))
        Me.txtRate.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.Location = New System.Drawing.Point(323, 381)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(200, 29)
        Me.txtRate.TabIndex = 16
        '
        'txtDays
        '
        Me.txtDays.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PayrollBindingSource, "WORKING DAYS", True))
        Me.txtDays.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDays.Location = New System.Drawing.Point(323, 441)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(200, 29)
        Me.txtDays.TabIndex = 17
        '
        'txtGross
        '
        Me.txtGross.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PayrollBindingSource, "GROSS PAY", True))
        Me.txtGross.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGross.Location = New System.Drawing.Point(846, 167)
        Me.txtGross.Name = "txtGross"
        Me.txtGross.Size = New System.Drawing.Size(200, 29)
        Me.txtGross.TabIndex = 18
        '
        'btnCompute
        '
        Me.btnCompute.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.Image = CType(resources.GetObject("btnCompute.Image"), System.Drawing.Image)
        Me.btnCompute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCompute.Location = New System.Drawing.Point(1163, 408)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(118, 62)
        Me.btnCompute.TabIndex = 23
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'txtSSS
        '
        Me.txtSSS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PayrollBindingSource, "SSS", True))
        Me.txtSSS.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSSS.Location = New System.Drawing.Point(846, 220)
        Me.txtSSS.Name = "txtSSS"
        Me.txtSSS.Size = New System.Drawing.Size(200, 29)
        Me.txtSSS.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(632, 228)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 22)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "SSS"
        '
        'txtPagIbig
        '
        Me.txtPagIbig.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PayrollBindingSource, "PAG IBIG", True))
        Me.txtPagIbig.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPagIbig.Location = New System.Drawing.Point(846, 338)
        Me.txtPagIbig.Name = "txtPagIbig"
        Me.txtPagIbig.Size = New System.Drawing.Size(200, 29)
        Me.txtPagIbig.TabIndex = 28
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(632, 334)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 22)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "PAG IBIG"
        '
        'txtPhilhealth
        '
        Me.txtPhilhealth.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PayrollBindingSource, "PHILHEALTH", True))
        Me.txtPhilhealth.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhilhealth.Location = New System.Drawing.Point(846, 280)
        Me.txtPhilhealth.Name = "txtPhilhealth"
        Me.txtPhilhealth.Size = New System.Drawing.Size(200, 29)
        Me.txtPhilhealth.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(632, 277)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(129, 22)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "PHILHEALTH"
        '
        'txtNetpay
        '
        Me.txtNetpay.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PayrollBindingSource, "NET PAY", True))
        Me.txtNetpay.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetpay.Location = New System.Drawing.Point(846, 385)
        Me.txtNetpay.Name = "txtNetpay"
        Me.txtNetpay.Size = New System.Drawing.Size(200, 29)
        Me.txtNetpay.TabIndex = 32
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(628, 388)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 22)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "NET PAY"
        '
        'txtSalary
        '
        Me.txtSalary.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PayrollBindingSource, "SALARY", True))
        Me.txtSalary.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalary.Location = New System.Drawing.Point(846, 441)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(200, 29)
        Me.txtSalary.TabIndex = 34
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(628, 439)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 22)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "SALARY"
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(1163, 326)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(118, 62)
        Me.btnDelete.TabIndex = 37
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(1332, 158)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(118, 62)
        Me.btnSave.TabIndex = 36
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(1163, 160)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(118, 62)
        Me.btnAdd.TabIndex = 35
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(1332, 330)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(116, 62)
        Me.btnClose.TabIndex = 38
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'cmbLastName
        '
        Me.cmbLastName.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PayrollBindingSource, "LAST NAME", True))
        Me.cmbLastName.DataSource = Me.EmployeeBindingSource
        Me.cmbLastName.DisplayMember = "LAST NAME"
        Me.cmbLastName.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLastName.FormattingEnabled = True
        Me.cmbLastName.Location = New System.Drawing.Point(323, 212)
        Me.cmbLastName.Name = "cmbLastName"
        Me.cmbLastName.Size = New System.Drawing.Size(200, 30)
        Me.cmbLastName.TabIndex = 40
        Me.cmbLastName.ValueMember = "LAST NAME"
        '
        'cmbPosition
        '
        Me.cmbPosition.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PayrollBindingSource, "POSITION", True))
        Me.cmbPosition.DataSource = Me.EmployeeBindingSource
        Me.cmbPosition.DisplayMember = "POSITION"
        Me.cmbPosition.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPosition.FormattingEnabled = True
        Me.cmbPosition.Location = New System.Drawing.Point(323, 326)
        Me.cmbPosition.Name = "cmbPosition"
        Me.cmbPosition.Size = New System.Drawing.Size(200, 30)
        Me.cmbPosition.TabIndex = 41
        Me.cmbPosition.ValueMember = "POSITION"
        '
        'cmbFirstName
        '
        Me.cmbFirstName.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PayrollBindingSource, "FIRST NAME", True))
        Me.cmbFirstName.DataSource = Me.EmployeeBindingSource
        Me.cmbFirstName.DisplayMember = "FIRST NAME"
        Me.cmbFirstName.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFirstName.FormattingEnabled = True
        Me.cmbFirstName.Location = New System.Drawing.Point(323, 270)
        Me.cmbFirstName.Name = "cmbFirstName"
        Me.cmbFirstName.Size = New System.Drawing.Size(200, 30)
        Me.cmbFirstName.TabIndex = 42
        Me.cmbFirstName.ValueMember = "FIRST NAME"
        '
        'PayrollTableAdapter
        '
        Me.PayrollTableAdapter.ClearBeforeFill = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(1334, 408)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(116, 62)
        Me.btnPrint.TabIndex = 43
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.RichTextBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1476, 314)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "RECEIPT"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox1.Location = New System.Drawing.Point(336, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(610, 311)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1476, 314)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "DATABASE"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.MintCream
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(79, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(79, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EMPLOYEEIDDataGridViewTextBoxColumn, Me.LASTNAMEDataGridViewTextBoxColumn, Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.POSITIONDataGridViewTextBoxColumn, Me.RATEPERDAYDataGridViewTextBoxColumn, Me.WORKINGDAYSDataGridViewTextBoxColumn, Me.GROSSPAYDataGridViewTextBoxColumn, Me.SSSDataGridViewTextBoxColumn, Me.PHILHEALTHDataGridViewTextBoxColumn, Me.PAGIBIGDataGridViewTextBoxColumn, Me.NETPAYDataGridViewTextBoxColumn, Me.SALARYDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PayrollBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LemonChiffon
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1503, 314)
        Me.DataGridView1.TabIndex = 40
        '
        'EMPLOYEEIDDataGridViewTextBoxColumn
        '
        Me.EMPLOYEEIDDataGridViewTextBoxColumn.DataPropertyName = "EMPLOYEE ID"
        Me.EMPLOYEEIDDataGridViewTextBoxColumn.HeaderText = "EMPLOYEE ID"
        Me.EMPLOYEEIDDataGridViewTextBoxColumn.Name = "EMPLOYEEIDDataGridViewTextBoxColumn"
        '
        'LASTNAMEDataGridViewTextBoxColumn
        '
        Me.LASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LAST NAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.HeaderText = "LAST NAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.Name = "LASTNAMEDataGridViewTextBoxColumn"
        '
        'FIRSTNAMEDataGridViewTextBoxColumn
        '
        Me.FIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRST NAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FIRST NAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.Name = "FIRSTNAMEDataGridViewTextBoxColumn"
        '
        'POSITIONDataGridViewTextBoxColumn
        '
        Me.POSITIONDataGridViewTextBoxColumn.DataPropertyName = "POSITION"
        Me.POSITIONDataGridViewTextBoxColumn.HeaderText = "POSITION"
        Me.POSITIONDataGridViewTextBoxColumn.Name = "POSITIONDataGridViewTextBoxColumn"
        '
        'RATEPERDAYDataGridViewTextBoxColumn
        '
        Me.RATEPERDAYDataGridViewTextBoxColumn.DataPropertyName = "RATE PER DAY"
        Me.RATEPERDAYDataGridViewTextBoxColumn.HeaderText = "RATE PER DAY"
        Me.RATEPERDAYDataGridViewTextBoxColumn.Name = "RATEPERDAYDataGridViewTextBoxColumn"
        '
        'WORKINGDAYSDataGridViewTextBoxColumn
        '
        Me.WORKINGDAYSDataGridViewTextBoxColumn.DataPropertyName = "WORKING DAYS"
        Me.WORKINGDAYSDataGridViewTextBoxColumn.HeaderText = "WORKING DAYS"
        Me.WORKINGDAYSDataGridViewTextBoxColumn.Name = "WORKINGDAYSDataGridViewTextBoxColumn"
        '
        'GROSSPAYDataGridViewTextBoxColumn
        '
        Me.GROSSPAYDataGridViewTextBoxColumn.DataPropertyName = "GROSS PAY"
        Me.GROSSPAYDataGridViewTextBoxColumn.HeaderText = "GROSS PAY"
        Me.GROSSPAYDataGridViewTextBoxColumn.Name = "GROSSPAYDataGridViewTextBoxColumn"
        '
        'SSSDataGridViewTextBoxColumn
        '
        Me.SSSDataGridViewTextBoxColumn.DataPropertyName = "SSS"
        Me.SSSDataGridViewTextBoxColumn.HeaderText = "SSS"
        Me.SSSDataGridViewTextBoxColumn.Name = "SSSDataGridViewTextBoxColumn"
        '
        'PHILHEALTHDataGridViewTextBoxColumn
        '
        Me.PHILHEALTHDataGridViewTextBoxColumn.DataPropertyName = "PHILHEALTH"
        Me.PHILHEALTHDataGridViewTextBoxColumn.HeaderText = "PHILHEALTH"
        Me.PHILHEALTHDataGridViewTextBoxColumn.Name = "PHILHEALTHDataGridViewTextBoxColumn"
        '
        'PAGIBIGDataGridViewTextBoxColumn
        '
        Me.PAGIBIGDataGridViewTextBoxColumn.DataPropertyName = "PAG IBIG"
        Me.PAGIBIGDataGridViewTextBoxColumn.HeaderText = "PAG IBIG"
        Me.PAGIBIGDataGridViewTextBoxColumn.Name = "PAGIBIGDataGridViewTextBoxColumn"
        '
        'NETPAYDataGridViewTextBoxColumn
        '
        Me.NETPAYDataGridViewTextBoxColumn.DataPropertyName = "NET PAY"
        Me.NETPAYDataGridViewTextBoxColumn.HeaderText = "NET PAY"
        Me.NETPAYDataGridViewTextBoxColumn.Name = "NETPAYDataGridViewTextBoxColumn"
        '
        'SALARYDataGridViewTextBoxColumn
        '
        Me.SALARYDataGridViewTextBoxColumn.DataPropertyName = "SALARY"
        Me.SALARYDataGridViewTextBoxColumn.HeaderText = "SALARY"
        Me.SALARYDataGridViewTextBoxColumn.Name = "SALARYDataGridViewTextBoxColumn"
        '
        'DATABASE
        '
        Me.DATABASE.AccessibleName = ""
        Me.DATABASE.Controls.Add(Me.TabPage1)
        Me.DATABASE.Controls.Add(Me.TabPage2)
        Me.DATABASE.Location = New System.Drawing.Point(59, 519)
        Me.DATABASE.Name = "DATABASE"
        Me.DATABASE.SelectedIndex = 0
        Me.DATABASE.Size = New System.Drawing.Size(1484, 340)
        Me.DATABASE.TabIndex = 44
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmployeeTableAdapter = Me.EmployeeTableAdapter
        Me.TableAdapterManager.UpdateOrder = Payroll_Management_System.PayrollDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lblLogOut)
        Me.Panel1.Controls.Add(Me.lblEmployee)
        Me.Panel1.Controls.Add(Me.lblSystem)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1594, 100)
        Me.Panel1.TabIndex = 45
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(1305, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(139, 84)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 42
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(977, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(139, 84)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 41
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(55, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'lblLogOut
        '
        Me.lblLogOut.AutoSize = True
        Me.lblLogOut.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogOut.Location = New System.Drawing.Point(1445, 28)
        Me.lblLogOut.Name = "lblLogOut"
        Me.lblLogOut.Size = New System.Drawing.Size(141, 32)
        Me.lblLogOut.TabIndex = 39
        Me.lblLogOut.Text = "LOG OUT"
        '
        'lblEmployee
        '
        Me.lblEmployee.AutoSize = True
        Me.lblEmployee.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployee.Location = New System.Drawing.Point(1135, 28)
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(164, 32)
        Me.lblEmployee.TabIndex = 38
        Me.lblEmployee.Text = "EMPLOYEE"
        '
        'lblSystem
        '
        Me.lblSystem.AutoSize = True
        Me.lblSystem.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystem.Location = New System.Drawing.Point(200, 28)
        Me.lblSystem.Name = "lblSystem"
        Me.lblSystem.Size = New System.Drawing.Size(620, 32)
        Me.lblSystem.TabIndex = 37
        Me.lblSystem.Text = "EMPLOYEE PAYROLL MANAGEMENT SYSTEM"
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Image = CType(resources.GetObject("btnNext.Image"), System.Drawing.Image)
        Me.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNext.Location = New System.Drawing.Point(1332, 238)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(116, 62)
        Me.btnNext.TabIndex = 47
        Me.btnNext.Text = "NEXT"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Image = CType(resources.GetObject("btnPrevious.Image"), System.Drawing.Image)
        Me.btnPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrevious.Location = New System.Drawing.Point(1163, 240)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(118, 62)
        Me.btnPrevious.TabIndex = 46
        Me.btnPrevious.Text = "PREVIOUS"
        Me.btnPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(1298, 499)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(78, 19)
        Me.lblSearch.TabIndex = 49
        Me.lblSearch.Text = "SEARCH"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(1391, 496)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(152, 26)
        Me.txtSearch.TabIndex = 48
        '
        'Payroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1600, 881)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DATABASE)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.cmbFirstName)
        Me.Controls.Add(Me.cmbPosition)
        Me.Controls.Add(Me.cmbLastName)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtNetpay)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtPhilhealth)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtPagIbig)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtSSS)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtGross)
        Me.Controls.Add(Me.txtDays)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Payroll"
        Me.Text = "Payroll"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PayrollBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiptDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiptDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrollDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DATABASE.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents txtDays As System.Windows.Forms.TextBox
    Friend WithEvents txtGross As System.Windows.Forms.TextBox
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents txtSSS As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPagIbig As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPhilhealth As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNetpay As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents PayrollDataSet As Payroll_Management_System.PayrollDataSet
    Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeTableAdapter As Payroll_Management_System.PayrollDataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents cmbLastName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFirstName As System.Windows.Forms.ComboBox
    Friend WithEvents ReceiptDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReceiptDataSet As Payroll_Management_System.ReceiptDataSet
    Friend WithEvents PayrollBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PayrollTableAdapter As Payroll_Management_System.ReceiptDataSetTableAdapters.PayrollTableAdapter
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents EMPLOYEEIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LASTNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POSITIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RATEPERDAYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WORKINGDAYSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GROSSPAYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SSSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PHILHEALTHDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PAGIBIGDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NETPAYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SALARYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DATABASE As System.Windows.Forms.TabControl
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents cmbPosition As System.Windows.Forms.ComboBox
    Friend WithEvents TableAdapterManager As Payroll_Management_System.PayrollDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblLogOut As System.Windows.Forms.Label
    Friend WithEvents lblEmployee As System.Windows.Forms.Label
    Friend WithEvents lblSystem As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
End Class
