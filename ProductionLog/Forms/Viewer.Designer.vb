<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Viewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Viewer))
        Dim PaymentTypeLabel As System.Windows.Forms.Label
        Dim NumberOfPaymentsLabel As System.Windows.Forms.Label
        Dim AmountFinancedLabel As System.Windows.Forms.Label
        Dim DownPaymentLabel As System.Windows.Forms.Label
        Dim SaleorLeaseLabel As System.Windows.Forms.Label
        Dim StateofResidenceLabel As System.Windows.Forms.Label
        Dim ModelLabel As System.Windows.Forms.Label
        Dim MakeLabel As System.Windows.Forms.Label
        Dim YearLabel As System.Windows.Forms.Label
        Dim VINLabel As System.Windows.Forms.Label
        Dim DateReceivedLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim DateTitleReceivedLabel As System.Windows.Forms.Label
        Dim PledgedToLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim LoanDateLabel As System.Windows.Forms.Label
        Dim NewLoanNumLabel As System.Windows.Forms.Label
        Dim CustomerNameLabel As System.Windows.Forms.Label
        Me.JakcjarcifrBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.JakcjarcifrBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.JakcjarcifrBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TimeLogDBDataSet = New ProductionLog.TimeLogDBDataSet()
        Me.JakcjarcifrTableAdapter = New ProductionLog.TimeLogDBDataSetTableAdapters.jakcjarcifrTableAdapter()
        Me.TableAdapterManager = New ProductionLog.TimeLogDBDataSetTableAdapters.TableAdapterManager()
        Me.FormSkin1 = New ProductionLog.FormSkin()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PaymentTypeTextBox = New System.Windows.Forms.TextBox()
        Me.NumberOfPaymentsTextBox = New System.Windows.Forms.TextBox()
        Me.AmountFinancedTextBox = New System.Windows.Forms.TextBox()
        Me.DownPaymentTextBox = New System.Windows.Forms.TextBox()
        Me.SaleorLeaseTextBox = New System.Windows.Forms.TextBox()
        Me.StateofResidenceComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ModelTextBox = New System.Windows.Forms.TextBox()
        Me.MakeTextBox = New System.Windows.Forms.TextBox()
        Me.YearTextBox = New System.Windows.Forms.TextBox()
        Me.VINTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateReceivedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TitleComboBox = New System.Windows.Forms.ComboBox()
        Me.DateTitleReceivedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AssignedToPLCheckBox = New System.Windows.Forms.CheckBox()
        Me.StampedCheckBox = New System.Windows.Forms.CheckBox()
        Me.BuyerSellerSignedCheckBox = New System.Windows.Forms.CheckBox()
        Me.PledgedToTextBox = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.LoanDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NewLoanNumTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.DealerNameLabel = New System.Windows.Forms.Label()
        Me.DealerIDLabel = New System.Windows.Forms.Label()
        Me.EmpIDLabel = New System.Windows.Forms.Label()
        Me.FlatButton1 = New ProductionLog.FlatButton()
        PaymentTypeLabel = New System.Windows.Forms.Label()
        NumberOfPaymentsLabel = New System.Windows.Forms.Label()
        AmountFinancedLabel = New System.Windows.Forms.Label()
        DownPaymentLabel = New System.Windows.Forms.Label()
        SaleorLeaseLabel = New System.Windows.Forms.Label()
        StateofResidenceLabel = New System.Windows.Forms.Label()
        ModelLabel = New System.Windows.Forms.Label()
        MakeLabel = New System.Windows.Forms.Label()
        YearLabel = New System.Windows.Forms.Label()
        VINLabel = New System.Windows.Forms.Label()
        DateReceivedLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        DateTitleReceivedLabel = New System.Windows.Forms.Label()
        PledgedToLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        LoanDateLabel = New System.Windows.Forms.Label()
        NewLoanNumLabel = New System.Windows.Forms.Label()
        CustomerNameLabel = New System.Windows.Forms.Label()
        CType(Me.JakcjarcifrBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.JakcjarcifrBindingNavigator.SuspendLayout()
        CType(Me.JakcjarcifrBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeLogDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormSkin1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'JakcjarcifrBindingNavigator
        '
        Me.JakcjarcifrBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.JakcjarcifrBindingNavigator.BindingSource = Me.JakcjarcifrBindingSource
        Me.JakcjarcifrBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.JakcjarcifrBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.JakcjarcifrBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.JakcjarcifrBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.JakcjarcifrBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.ToolStripTextBox1})
        Me.JakcjarcifrBindingNavigator.Location = New System.Drawing.Point(0, 644)
        Me.JakcjarcifrBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.JakcjarcifrBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.JakcjarcifrBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.JakcjarcifrBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.JakcjarcifrBindingNavigator.Name = "JakcjarcifrBindingNavigator"
        Me.JakcjarcifrBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.JakcjarcifrBindingNavigator.Size = New System.Drawing.Size(970, 25)
        Me.JakcjarcifrBindingNavigator.TabIndex = 1
        Me.JakcjarcifrBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'JakcjarcifrBindingNavigatorSaveItem
        '
        Me.JakcjarcifrBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.JakcjarcifrBindingNavigatorSaveItem.Image = CType(resources.GetObject("JakcjarcifrBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.JakcjarcifrBindingNavigatorSaveItem.Name = "JakcjarcifrBindingNavigatorSaveItem"
        Me.JakcjarcifrBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.JakcjarcifrBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(67, 22)
        Me.ToolStripLabel1.Text = "SEARCH VIN"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'JakcjarcifrBindingSource
        '
        Me.JakcjarcifrBindingSource.DataMember = "jakcjarcifr"
        Me.JakcjarcifrBindingSource.DataSource = Me.TimeLogDBDataSet
        '
        'TimeLogDBDataSet
        '
        Me.TimeLogDBDataSet.DataSetName = "TimeLogDBDataSet"
        Me.TimeLogDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JakcjarcifrTableAdapter
        '
        Me.JakcjarcifrTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.batchTableAdapter = Nothing
        Me.TableAdapterManager.bugtrackerTableAdapter = Nothing
        Me.TableAdapterManager.contactlistTableAdapter = Nothing
        Me.TableAdapterManager.dealernameTableAdapter = Nothing
        Me.TableAdapterManager.employeeTableAdapter = Nothing
        Me.TableAdapterManager.extensionsTableAdapter = Nothing
        Me.TableAdapterManager.jackjaruploadarchiveTableAdapter = Nothing
        Me.TableAdapterManager.jackjaruploadTableAdapter = Nothing
        Me.TableAdapterManager.jakcjarcifrTableAdapter = Me.JakcjarcifrTableAdapter
        Me.TableAdapterManager.jobnameTableAdapter = Nothing
        Me.TableAdapterManager.metricsTableAdapter = Nothing
        Me.TableAdapterManager.occurrencesTableAdapter = Nothing
        Me.TableAdapterManager.pinsTableAdapter = Nothing
        Me.TableAdapterManager.qaTableAdapter = Nothing
        Me.TableAdapterManager.timeclockTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProductionLog.TimeLogDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.workflowTableAdapter = Nothing
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.Gray
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.GroupBox3)
        Me.FormSkin1.Controls.Add(StateofResidenceLabel)
        Me.FormSkin1.Controls.Add(Me.StateofResidenceComboBox)
        Me.FormSkin1.Controls.Add(Me.GroupBox2)
        Me.FormSkin1.Controls.Add(Me.GroupBox1)
        Me.FormSkin1.Controls.Add(PledgedToLabel)
        Me.FormSkin1.Controls.Add(Me.PledgedToTextBox)
        Me.FormSkin1.Controls.Add(LocationLabel)
        Me.FormSkin1.Controls.Add(Me.LocationTextBox)
        Me.FormSkin1.Controls.Add(LoanDateLabel)
        Me.FormSkin1.Controls.Add(Me.LoanDateDateTimePicker)
        Me.FormSkin1.Controls.Add(NewLoanNumLabel)
        Me.FormSkin1.Controls.Add(Me.NewLoanNumTextBox)
        Me.FormSkin1.Controls.Add(CustomerNameLabel)
        Me.FormSkin1.Controls.Add(Me.CustomerNameTextBox)
        Me.FormSkin1.Controls.Add(Me.DealerNameLabel)
        Me.FormSkin1.Controls.Add(Me.DealerIDLabel)
        Me.FormSkin1.Controls.Add(Me.EmpIDLabel)
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.SteelBlue
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(970, 669)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "CIFR"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(PaymentTypeLabel)
        Me.GroupBox3.Controls.Add(Me.PaymentTypeTextBox)
        Me.GroupBox3.Controls.Add(NumberOfPaymentsLabel)
        Me.GroupBox3.Controls.Add(Me.NumberOfPaymentsTextBox)
        Me.GroupBox3.Controls.Add(AmountFinancedLabel)
        Me.GroupBox3.Controls.Add(Me.AmountFinancedTextBox)
        Me.GroupBox3.Controls.Add(DownPaymentLabel)
        Me.GroupBox3.Controls.Add(Me.DownPaymentTextBox)
        Me.GroupBox3.Controls.Add(SaleorLeaseLabel)
        Me.GroupBox3.Controls.Add(Me.SaleorLeaseTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 434)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(299, 200)
        Me.GroupBox3.TabIndex = 36
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sale Info"
        '
        'PaymentTypeLabel
        '
        PaymentTypeLabel.AutoSize = True
        PaymentTypeLabel.Location = New System.Drawing.Point(59, 166)
        PaymentTypeLabel.Name = "PaymentTypeLabel"
        PaymentTypeLabel.Size = New System.Drawing.Size(111, 21)
        PaymentTypeLabel.TabIndex = 8
        PaymentTypeLabel.Text = "Payment Type:"
        '
        'PaymentTypeTextBox
        '
        Me.PaymentTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JakcjarcifrBindingSource, "PaymentType", True))
        Me.PaymentTypeTextBox.Location = New System.Drawing.Point(176, 163)
        Me.PaymentTypeTextBox.Name = "PaymentTypeTextBox"
        Me.PaymentTypeTextBox.Size = New System.Drawing.Size(100, 29)
        Me.PaymentTypeTextBox.TabIndex = 9
        '
        'NumberOfPaymentsLabel
        '
        NumberOfPaymentsLabel.AutoSize = True
        NumberOfPaymentsLabel.Location = New System.Drawing.Point(6, 130)
        NumberOfPaymentsLabel.Name = "NumberOfPaymentsLabel"
        NumberOfPaymentsLabel.Size = New System.Drawing.Size(164, 21)
        NumberOfPaymentsLabel.TabIndex = 6
        NumberOfPaymentsLabel.Text = "Number Of Payments:"
        '
        'NumberOfPaymentsTextBox
        '
        Me.NumberOfPaymentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JakcjarcifrBindingSource, "NumberOfPayments", True))
        Me.NumberOfPaymentsTextBox.Location = New System.Drawing.Point(176, 127)
        Me.NumberOfPaymentsTextBox.Name = "NumberOfPaymentsTextBox"
        Me.NumberOfPaymentsTextBox.Size = New System.Drawing.Size(100, 29)
        Me.NumberOfPaymentsTextBox.TabIndex = 7
        '
        'AmountFinancedLabel
        '
        AmountFinancedLabel.AutoSize = True
        AmountFinancedLabel.Location = New System.Drawing.Point(35, 99)
        AmountFinancedLabel.Name = "AmountFinancedLabel"
        AmountFinancedLabel.Size = New System.Drawing.Size(135, 21)
        AmountFinancedLabel.TabIndex = 4
        AmountFinancedLabel.Text = "Amount Financed:"
        '
        'AmountFinancedTextBox
        '
        Me.AmountFinancedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JakcjarcifrBindingSource, "AmountFinanced", True))
        Me.AmountFinancedTextBox.Location = New System.Drawing.Point(176, 90)
        Me.AmountFinancedTextBox.Name = "AmountFinancedTextBox"
        Me.AmountFinancedTextBox.Size = New System.Drawing.Size(100, 29)
        Me.AmountFinancedTextBox.TabIndex = 5
        '
        'DownPaymentLabel
        '
        DownPaymentLabel.AutoSize = True
        DownPaymentLabel.Location = New System.Drawing.Point(51, 64)
        DownPaymentLabel.Name = "DownPaymentLabel"
        DownPaymentLabel.Size = New System.Drawing.Size(119, 21)
        DownPaymentLabel.TabIndex = 2
        DownPaymentLabel.Text = "Down Payment:"
        '
        'DownPaymentTextBox
        '
        Me.DownPaymentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JakcjarcifrBindingSource, "DownPayment", True))
        Me.DownPaymentTextBox.Location = New System.Drawing.Point(176, 56)
        Me.DownPaymentTextBox.Name = "DownPaymentTextBox"
        Me.DownPaymentTextBox.Size = New System.Drawing.Size(100, 29)
        Me.DownPaymentTextBox.TabIndex = 3
        '
        'SaleorLeaseLabel
        '
        SaleorLeaseLabel.AutoSize = True
        SaleorLeaseLabel.Location = New System.Drawing.Point(83, 25)
        SaleorLeaseLabel.Name = "SaleorLeaseLabel"
        SaleorLeaseLabel.Size = New System.Drawing.Size(87, 21)
        SaleorLeaseLabel.TabIndex = 0
        SaleorLeaseLabel.Text = "Sale/Lease:"
        '
        'SaleorLeaseTextBox
        '
        Me.SaleorLeaseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JakcjarcifrBindingSource, "SaleorLease", True))
        Me.SaleorLeaseTextBox.Location = New System.Drawing.Point(176, 22)
        Me.SaleorLeaseTextBox.Name = "SaleorLeaseTextBox"
        Me.SaleorLeaseTextBox.Size = New System.Drawing.Size(33, 29)
        Me.SaleorLeaseTextBox.TabIndex = 1
        '
        'StateofResidenceLabel
        '
        StateofResidenceLabel.AutoSize = True
        StateofResidenceLabel.BackColor = System.Drawing.Color.Transparent
        StateofResidenceLabel.Location = New System.Drawing.Point(413, 356)
        StateofResidenceLabel.Name = "StateofResidenceLabel"
        StateofResidenceLabel.Size = New System.Drawing.Size(140, 21)
        StateofResidenceLabel.TabIndex = 34
        StateofResidenceLabel.Text = "State of Residence:"
        '
        'StateofResidenceComboBox
        '
        Me.StateofResidenceComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JakcjarcifrBindingSource, "StateofResidence", True))
        Me.StateofResidenceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StateofResidenceComboBox.FormattingEnabled = True
        Me.StateofResidenceComboBox.Items.AddRange(New Object() {"", "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        Me.StateofResidenceComboBox.Location = New System.Drawing.Point(553, 353)
        Me.StateofResidenceComboBox.Name = "StateofResidenceComboBox"
        Me.StateofResidenceComboBox.Size = New System.Drawing.Size(56, 29)
        Me.StateofResidenceComboBox.TabIndex = 35
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(ModelLabel)
        Me.GroupBox2.Controls.Add(Me.ModelTextBox)
        Me.GroupBox2.Controls.Add(MakeLabel)
        Me.GroupBox2.Controls.Add(Me.MakeTextBox)
        Me.GroupBox2.Controls.Add(YearLabel)
        Me.GroupBox2.Controls.Add(Me.YearTextBox)
        Me.GroupBox2.Controls.Add(VINLabel)
        Me.GroupBox2.Controls.Add(Me.VINTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 255)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(338, 173)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Vehicle Info"
        '
        'ModelLabel
        '
        ModelLabel.AutoSize = True
        ModelLabel.Location = New System.Drawing.Point(6, 127)
        ModelLabel.Name = "ModelLabel"
        ModelLabel.Size = New System.Drawing.Size(57, 21)
        ModelLabel.TabIndex = 6
        ModelLabel.Text = "Model:"
        '
        'ModelTextBox
        '
        Me.ModelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JakcjarcifrBindingSource, "Model", True))
        Me.ModelTextBox.Location = New System.Drawing.Point(75, 130)
        Me.ModelTextBox.Name = "ModelTextBox"
        Me.ModelTextBox.ReadOnly = True
        Me.ModelTextBox.Size = New System.Drawing.Size(100, 29)
        Me.ModelTextBox.TabIndex = 7
        '
        'MakeLabel
        '
        MakeLabel.AutoSize = True
        MakeLabel.Location = New System.Drawing.Point(6, 98)
        MakeLabel.Name = "MakeLabel"
        MakeLabel.Size = New System.Drawing.Size(51, 21)
        MakeLabel.TabIndex = 4
        MakeLabel.Text = "Make:"
        '
        'MakeTextBox
        '
        Me.MakeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JakcjarcifrBindingSource, "Make", True))
        Me.MakeTextBox.Location = New System.Drawing.Point(75, 95)
        Me.MakeTextBox.Name = "MakeTextBox"
        Me.MakeTextBox.ReadOnly = True
        Me.MakeTextBox.Size = New System.Drawing.Size(100, 29)
        Me.MakeTextBox.TabIndex = 5
        '
        'YearLabel
        '
        YearLabel.AutoSize = True
        YearLabel.Location = New System.Drawing.Point(6, 68)
        YearLabel.Name = "YearLabel"
        YearLabel.Size = New System.Drawing.Size(44, 21)
        YearLabel.TabIndex = 2
        YearLabel.Text = "Year:"
        '
        'YearTextBox
        '
        Me.YearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JakcjarcifrBindingSource, "Year", True))
        Me.YearTextBox.Location = New System.Drawing.Point(75, 61)
        Me.YearTextBox.Name = "YearTextBox"
        Me.YearTextBox.ReadOnly = True
        Me.YearTextBox.Size = New System.Drawing.Size(62, 29)
        Me.YearTextBox.TabIndex = 3
        '
        'VINLabel
        '
        VINLabel.AutoSize = True
        VINLabel.Location = New System.Drawing.Point(6, 36)
        VINLabel.Name = "VINLabel"
        VINLabel.Size = New System.Drawing.Size(39, 21)
        VINLabel.TabIndex = 0
        VINLabel.Text = "VIN:"
        '
        'VINTextBox
        '
        Me.VINTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JakcjarcifrBindingSource, "VIN", True))
        Me.VINTextBox.Location = New System.Drawing.Point(75, 28)
        Me.VINTextBox.Name = "VINTextBox"
        Me.VINTextBox.ReadOnly = True
        Me.VINTextBox.Size = New System.Drawing.Size(247, 29)
        Me.VINTextBox.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(DateReceivedLabel)
        Me.GroupBox1.Controls.Add(Me.DateReceivedDateTimePicker)
        Me.GroupBox1.Controls.Add(TitleLabel)
        Me.GroupBox1.Controls.Add(Me.TitleComboBox)
        Me.GroupBox1.Controls.Add(DateTitleReceivedLabel)
        Me.GroupBox1.Controls.Add(Me.DateTitleReceivedDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.AssignedToPLCheckBox)
        Me.GroupBox1.Controls.Add(Me.StampedCheckBox)
        Me.GroupBox1.Controls.Add(Me.BuyerSellerSignedCheckBox)
        Me.GroupBox1.Location = New System.Drawing.Point(411, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(210, 291)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Big 5"
        '
        'DateReceivedLabel
        '
        DateReceivedLabel.AutoSize = True
        DateReceivedLabel.Location = New System.Drawing.Point(2, 25)
        DateReceivedLabel.Name = "DateReceivedLabel"
        DateReceivedLabel.Size = New System.Drawing.Size(111, 21)
        DateReceivedLabel.TabIndex = 34
        DateReceivedLabel.Text = "Date Received:"
        '
        'DateReceivedDateTimePicker
        '
        Me.DateReceivedDateTimePicker.CustomFormat = "yyyy-MM-dd"
        Me.DateReceivedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.JakcjarcifrBindingSource, "DateReceived", True))
        Me.DateReceivedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateReceivedDateTimePicker.Location = New System.Drawing.Point(6, 55)
        Me.DateReceivedDateTimePicker.Name = "DateReceivedDateTimePicker"
        Me.DateReceivedDateTimePicker.Size = New System.Drawing.Size(123, 29)
        Me.DateReceivedDateTimePicker.TabIndex = 35
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(6, 191)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(42, 21)
        TitleLabel.TabIndex = 33
        TitleLabel.Text = "Title:"
        '
        'TitleComboBox
        '
        Me.TitleComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JakcjarcifrBindingSource, "Title", True))
        Me.TitleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TitleComboBox.FormattingEnabled = True
        Me.TitleComboBox.Items.AddRange(New Object() {"", "A", "T", "LR", "E", "N"})
        Me.TitleComboBox.Location = New System.Drawing.Point(54, 188)
        Me.TitleComboBox.Name = "TitleComboBox"
        Me.TitleComboBox.Size = New System.Drawing.Size(42, 29)
        Me.TitleComboBox.TabIndex = 34
        '
        'DateTitleReceivedLabel
        '
        DateTitleReceivedLabel.AutoSize = True
        DateTitleReceivedLabel.Location = New System.Drawing.Point(6, 225)
        DateTitleReceivedLabel.Name = "DateTitleReceivedLabel"
        DateTitleReceivedLabel.Size = New System.Drawing.Size(178, 21)
        DateTitleReceivedLabel.TabIndex = 32
        DateTitleReceivedLabel.Text = "Date Title/App Received:"
        '
        'DateTitleReceivedDateTimePicker
        '
        Me.DateTitleReceivedDateTimePicker.CustomFormat = "yyy-MM-dd"
        Me.DateTitleReceivedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.JakcjarcifrBindingSource, "DateTitleReceived", True))
        Me.DateTitleReceivedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTitleReceivedDateTimePicker.Location = New System.Drawing.Point(10, 249)
        Me.DateTitleReceivedDateTimePicker.Name = "DateTitleReceivedDateTimePicker"
        Me.DateTitleReceivedDateTimePicker.Size = New System.Drawing.Size(119, 29)
        Me.DateTitleReceivedDateTimePicker.TabIndex = 33
        '
        'AssignedToPLCheckBox
        '
        Me.AssignedToPLCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.AssignedToPLCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.JakcjarcifrBindingSource, "AssignedToPL", True))
        Me.AssignedToPLCheckBox.Location = New System.Drawing.Point(6, 151)
        Me.AssignedToPLCheckBox.Name = "AssignedToPLCheckBox"
        Me.AssignedToPLCheckBox.Size = New System.Drawing.Size(104, 35)
        Me.AssignedToPLCheckBox.TabIndex = 31
        Me.AssignedToPLCheckBox.Text = "Assigned"
        Me.AssignedToPLCheckBox.UseVisualStyleBackColor = False
        '
        'StampedCheckBox
        '
        Me.StampedCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.StampedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.JakcjarcifrBindingSource, "Stamped", True))
        Me.StampedCheckBox.Location = New System.Drawing.Point(6, 124)
        Me.StampedCheckBox.Name = "StampedCheckBox"
        Me.StampedCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.StampedCheckBox.TabIndex = 30
        Me.StampedCheckBox.Text = "Stamped"
        Me.StampedCheckBox.UseVisualStyleBackColor = False
        '
        'BuyerSellerSignedCheckBox
        '
        Me.BuyerSellerSignedCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.BuyerSellerSignedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.JakcjarcifrBindingSource, "BuyerSellerSigned", True))
        Me.BuyerSellerSignedCheckBox.Location = New System.Drawing.Point(6, 94)
        Me.BuyerSellerSignedCheckBox.Name = "BuyerSellerSignedCheckBox"
        Me.BuyerSellerSignedCheckBox.Size = New System.Drawing.Size(168, 24)
        Me.BuyerSellerSignedCheckBox.TabIndex = 29
        Me.BuyerSellerSignedCheckBox.Text = "Buyer Seller Signed"
        Me.BuyerSellerSignedCheckBox.UseVisualStyleBackColor = False
        '
        'PledgedToLabel
        '
        PledgedToLabel.AutoSize = True
        PledgedToLabel.BackColor = System.Drawing.Color.Transparent
        PledgedToLabel.Location = New System.Drawing.Point(42, 220)
        PledgedToLabel.Name = "PledgedToLabel"
        PledgedToLabel.Size = New System.Drawing.Size(90, 21)
        PledgedToLabel.TabIndex = 31
        PledgedToLabel.Text = "Pledged To:"
        '
        'PledgedToTextBox
        '
        Me.PledgedToTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JakcjarcifrBindingSource, "PledgedTo", True))
        Me.PledgedToTextBox.Location = New System.Drawing.Point(138, 220)
        Me.PledgedToTextBox.Name = "PledgedToTextBox"
        Me.PledgedToTextBox.ReadOnly = True
        Me.PledgedToTextBox.Size = New System.Drawing.Size(134, 29)
        Me.PledgedToTextBox.TabIndex = 32
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.BackColor = System.Drawing.Color.Transparent
        LocationLabel.Location = New System.Drawing.Point(62, 182)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(72, 21)
        LocationLabel.TabIndex = 27
        LocationLabel.Text = "Location:"
        '
        'LocationTextBox
        '
        Me.LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JakcjarcifrBindingSource, "Location", True))
        Me.LocationTextBox.Location = New System.Drawing.Point(138, 182)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.ReadOnly = True
        Me.LocationTextBox.Size = New System.Drawing.Size(100, 29)
        Me.LocationTextBox.TabIndex = 28
        '
        'LoanDateLabel
        '
        LoanDateLabel.AutoSize = True
        LoanDateLabel.BackColor = System.Drawing.Color.Transparent
        LoanDateLabel.Location = New System.Drawing.Point(49, 142)
        LoanDateLabel.Name = "LoanDateLabel"
        LoanDateLabel.Size = New System.Drawing.Size(83, 21)
        LoanDateLabel.TabIndex = 26
        LoanDateLabel.Text = "Loan Date:"
        '
        'LoanDateDateTimePicker
        '
        Me.LoanDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.JakcjarcifrBindingSource, "LoanDate", True))
        Me.LoanDateDateTimePicker.Enabled = False
        Me.LoanDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.LoanDateDateTimePicker.Location = New System.Drawing.Point(138, 142)
        Me.LoanDateDateTimePicker.Name = "LoanDateDateTimePicker"
        Me.LoanDateDateTimePicker.Size = New System.Drawing.Size(113, 29)
        Me.LoanDateDateTimePicker.TabIndex = 27
        '
        'NewLoanNumLabel
        '
        NewLoanNumLabel.AutoSize = True
        NewLoanNumLabel.BackColor = System.Drawing.Color.Transparent
        NewLoanNumLabel.Location = New System.Drawing.Point(12, 59)
        NewLoanNumLabel.Name = "NewLoanNumLabel"
        NewLoanNumLabel.Size = New System.Drawing.Size(122, 21)
        NewLoanNumLabel.TabIndex = 25
        NewLoanNumLabel.Text = "New Loan Num:"
        '
        'NewLoanNumTextBox
        '
        Me.NewLoanNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JakcjarcifrBindingSource, "NewLoanNum", True))
        Me.NewLoanNumTextBox.Location = New System.Drawing.Point(138, 59)
        Me.NewLoanNumTextBox.Name = "NewLoanNumTextBox"
        Me.NewLoanNumTextBox.ReadOnly = True
        Me.NewLoanNumTextBox.Size = New System.Drawing.Size(173, 29)
        Me.NewLoanNumTextBox.TabIndex = 26
        '
        'CustomerNameLabel
        '
        CustomerNameLabel.AutoSize = True
        CustomerNameLabel.BackColor = System.Drawing.Color.Transparent
        CustomerNameLabel.Location = New System.Drawing.Point(7, 103)
        CustomerNameLabel.Name = "CustomerNameLabel"
        CustomerNameLabel.Size = New System.Drawing.Size(127, 21)
        CustomerNameLabel.TabIndex = 24
        CustomerNameLabel.Text = "Customer Name:"
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JakcjarcifrBindingSource, "CustomerName", True))
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(138, 103)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.ReadOnly = True
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(253, 29)
        Me.CustomerNameTextBox.TabIndex = 25
        '
        'DealerNameLabel
        '
        Me.DealerNameLabel.AutoSize = True
        Me.DealerNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.DealerNameLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DealerNameLabel.ForeColor = System.Drawing.Color.White
        Me.DealerNameLabel.Location = New System.Drawing.Point(114, 18)
        Me.DealerNameLabel.Name = "DealerNameLabel"
        Me.DealerNameLabel.Size = New System.Drawing.Size(63, 17)
        Me.DealerNameLabel.TabIndex = 6
        Me.DealerNameLabel.Text = "JAKC/JAR"
        '
        'DealerIDLabel
        '
        Me.DealerIDLabel.AutoSize = True
        Me.DealerIDLabel.BackColor = System.Drawing.Color.Transparent
        Me.DealerIDLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DealerIDLabel.ForeColor = System.Drawing.Color.White
        Me.DealerIDLabel.Location = New System.Drawing.Point(76, 18)
        Me.DealerIDLabel.Name = "DealerIDLabel"
        Me.DealerIDLabel.Size = New System.Drawing.Size(15, 17)
        Me.DealerIDLabel.TabIndex = 5
        Me.DealerIDLabel.Text = "0"
        '
        'EmpIDLabel
        '
        Me.EmpIDLabel.AutoSize = True
        Me.EmpIDLabel.BackColor = System.Drawing.Color.Transparent
        Me.EmpIDLabel.ForeColor = System.Drawing.Color.White
        Me.EmpIDLabel.Location = New System.Drawing.Point(943, 27)
        Me.EmpIDLabel.Name = "EmpIDLabel"
        Me.EmpIDLabel.Size = New System.Drawing.Size(19, 21)
        Me.EmpIDLabel.TabIndex = 4
        Me.EmpIDLabel.Text = "0"
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.DarkRed
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(945, 1)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(25, 22)
        Me.FlatButton1.TabIndex = 2
        Me.FlatButton1.Text = "X"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 669)
        Me.Controls.Add(Me.JakcjarcifrBindingNavigator)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Viewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Viewer"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.JakcjarcifrBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.JakcjarcifrBindingNavigator.ResumeLayout(False)
        Me.JakcjarcifrBindingNavigator.PerformLayout()
        CType(Me.JakcjarcifrBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeLogDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FormSkin1 As ProductionLog.FormSkin
    Friend WithEvents FlatButton1 As ProductionLog.FlatButton
    Friend WithEvents EmpIDLabel As System.Windows.Forms.Label
    Friend WithEvents DealerNameLabel As System.Windows.Forms.Label
    Friend WithEvents DealerIDLabel As System.Windows.Forms.Label
    Friend WithEvents TimeLogDBDataSet As ProductionLog.TimeLogDBDataSet
    Friend WithEvents JakcjarcifrBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JakcjarcifrTableAdapter As ProductionLog.TimeLogDBDataSetTableAdapters.jakcjarcifrTableAdapter
    Friend WithEvents TableAdapterManager As ProductionLog.TimeLogDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents JakcjarcifrBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents JakcjarcifrBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CustomerNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NewLoanNumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LoanDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents LocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PledgedToTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AssignedToPLCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents StampedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BuyerSellerSignedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTitleReceivedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ModelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MakeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents YearTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VINTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents TitleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DateReceivedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents StateofResidenceComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PaymentTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumberOfPaymentsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AmountFinancedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DownPaymentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SaleorLeaseTextBox As System.Windows.Forms.TextBox
End Class
