<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clerk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clerk))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Funding")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("BB")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Collateral")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("QA")
        Me.LoginSuccessTimer = New System.Windows.Forms.Timer(Me.components)
        Me.QueueTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1 = New ProductionLog.FormSkin()
        Me.ReAssignLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.InAJobLabel = New System.Windows.Forms.Label()
        Me.JobTreeView = New System.Windows.Forms.TreeView()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.Reassignbutton = New ProductionLog.FlatButton()
        Me.FlatMini1 = New ProductionLog.FlatMini()
        Me.AutoRefreshToggle = New ProductionLog.FlatToggle()
        Me.QaJobsRadio = New System.Windows.Forms.RadioButton()
        Me.MyJobsRadio = New System.Windows.Forms.RadioButton()
        Me.VarianceCheckBox = New System.Windows.Forms.CheckBox()
        Me.ActualQuantityBox = New System.Windows.Forms.TextBox()
        Me.AQtyLabel = New System.Windows.Forms.Label()
        Me.IDBox = New System.Windows.Forms.TextBox()
        Me.BatchIDLabel = New System.Windows.Forms.Label()
        Me.BatchComboBox = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ShowButton = New ProductionLog.FlatButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LogoutButton = New ProductionLog.FlatButton()
        Me.SuccessLabel = New System.Windows.Forms.Label()
        Me.EmployeeID = New System.Windows.Forms.Label()
        Me.ClockTimeLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ClockOutButton = New ProductionLog.FlatButton()
        Me.ClockInButton = New ProductionLog.FlatButton()
        Me.QuantityBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.JobBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DealerBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LoginButton = New ProductionLog.FlatButton()
        Me.EndButton = New ProductionLog.FlatButton()
        Me.QAList = New System.Windows.Forms.ListBox()
        Me.StartButton = New ProductionLog.FlatButton()
        Me.JobList = New System.Windows.Forms.ListBox()
        Me.FlatButton1 = New ProductionLog.FlatButton()
        Me.FormSkin1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoginSuccessTimer
        '
        '
        'QueueTimer
        '
        Me.QueueTimer.Interval = 10000
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.Gray
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Controls.Add(Me.ReAssignLabel)
        Me.FormSkin1.Controls.Add(Me.Label1)
        Me.FormSkin1.Controls.Add(Me.PictureBox2)
        Me.FormSkin1.Controls.Add(Me.InAJobLabel)
        Me.FormSkin1.Controls.Add(Me.JobTreeView)
        Me.FormSkin1.Controls.Add(Me.DateLabel)
        Me.FormSkin1.Controls.Add(Me.Reassignbutton)
        Me.FormSkin1.Controls.Add(Me.FlatMini1)
        Me.FormSkin1.Controls.Add(Me.AutoRefreshToggle)
        Me.FormSkin1.Controls.Add(Me.QaJobsRadio)
        Me.FormSkin1.Controls.Add(Me.MyJobsRadio)
        Me.FormSkin1.Controls.Add(Me.VarianceCheckBox)
        Me.FormSkin1.Controls.Add(Me.ActualQuantityBox)
        Me.FormSkin1.Controls.Add(Me.AQtyLabel)
        Me.FormSkin1.Controls.Add(Me.IDBox)
        Me.FormSkin1.Controls.Add(Me.BatchIDLabel)
        Me.FormSkin1.Controls.Add(Me.BatchComboBox)
        Me.FormSkin1.Controls.Add(Me.Label10)
        Me.FormSkin1.Controls.Add(Me.ShowButton)
        Me.FormSkin1.Controls.Add(Me.Label9)
        Me.FormSkin1.Controls.Add(Me.PictureBox1)
        Me.FormSkin1.Controls.Add(Me.Label8)
        Me.FormSkin1.Controls.Add(Me.LogoutButton)
        Me.FormSkin1.Controls.Add(Me.SuccessLabel)
        Me.FormSkin1.Controls.Add(Me.EmployeeID)
        Me.FormSkin1.Controls.Add(Me.ClockTimeLabel)
        Me.FormSkin1.Controls.Add(Me.Label7)
        Me.FormSkin1.Controls.Add(Me.ClockOutButton)
        Me.FormSkin1.Controls.Add(Me.ClockInButton)
        Me.FormSkin1.Controls.Add(Me.QuantityBox)
        Me.FormSkin1.Controls.Add(Me.Label6)
        Me.FormSkin1.Controls.Add(Me.JobBox)
        Me.FormSkin1.Controls.Add(Me.Label5)
        Me.FormSkin1.Controls.Add(Me.Label4)
        Me.FormSkin1.Controls.Add(Me.DealerBox)
        Me.FormSkin1.Controls.Add(Me.Label3)
        Me.FormSkin1.Controls.Add(Me.LoginButton)
        Me.FormSkin1.Controls.Add(Me.EndButton)
        Me.FormSkin1.Controls.Add(Me.QAList)
        Me.FormSkin1.Controls.Add(Me.StartButton)
        Me.FormSkin1.Controls.Add(Me.JobList)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.Red
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(520, 374)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Work Queue"
        '
        'ReAssignLabel
        '
        Me.ReAssignLabel.AutoSize = True
        Me.ReAssignLabel.BackColor = System.Drawing.Color.Transparent
        Me.ReAssignLabel.Location = New System.Drawing.Point(407, 24)
        Me.ReAssignLabel.Name = "ReAssignLabel"
        Me.ReAssignLabel.Size = New System.Drawing.Size(19, 21)
        Me.ReAssignLabel.TabIndex = 43
        Me.ReAssignLabel.Text = "0"
        Me.ReAssignLabel.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(449, 322)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 15)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Copy VINs"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(421, 314)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(23, 23)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 41
        Me.PictureBox2.TabStop = False
        '
        'InAJobLabel
        '
        Me.InAJobLabel.AutoSize = True
        Me.InAJobLabel.BackColor = System.Drawing.Color.Transparent
        Me.InAJobLabel.Location = New System.Drawing.Point(430, 24)
        Me.InAJobLabel.Name = "InAJobLabel"
        Me.InAJobLabel.Size = New System.Drawing.Size(45, 21)
        Me.InAJobLabel.TabIndex = 40
        Me.InAJobLabel.Text = "False"
        Me.InAJobLabel.Visible = False
        '
        'JobTreeView
        '
        Me.JobTreeView.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JobTreeView.Location = New System.Drawing.Point(101, 88)
        Me.JobTreeView.Name = "JobTreeView"
        TreeNode1.Name = "FundingNode"
        TreeNode1.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode1.Text = "Funding"
        TreeNode2.Name = "BBNode"
        TreeNode2.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode2.Text = "BB"
        TreeNode3.Name = "CollateralNode"
        TreeNode3.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode3.Text = "Collateral"
        TreeNode4.Name = "QANode"
        TreeNode4.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode4.Text = "QA"
        Me.JobTreeView.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4})
        Me.JobTreeView.Size = New System.Drawing.Size(183, 273)
        Me.JobTreeView.TabIndex = 39
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.BackColor = System.Drawing.Color.Transparent
        Me.DateLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLabel.Location = New System.Drawing.Point(408, 260)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(0, 17)
        Me.DateLabel.TabIndex = 38
        '
        'Reassignbutton
        '
        Me.Reassignbutton.BackColor = System.Drawing.Color.Transparent
        Me.Reassignbutton.BaseColor = System.Drawing.Color.Green
        Me.Reassignbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Reassignbutton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Reassignbutton.Location = New System.Drawing.Point(299, 60)
        Me.Reassignbutton.Name = "Reassignbutton"
        Me.Reassignbutton.Rounded = False
        Me.Reassignbutton.Size = New System.Drawing.Size(93, 32)
        Me.Reassignbutton.TabIndex = 37
        Me.Reassignbutton.Text = "Re-Assign"
        Me.Reassignbutton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(499, 24)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 36
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.FlatMini1.Visible = False
        '
        'AutoRefreshToggle
        '
        Me.AutoRefreshToggle.BackColor = System.Drawing.Color.Transparent
        Me.AutoRefreshToggle.Checked = False
        Me.AutoRefreshToggle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AutoRefreshToggle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.AutoRefreshToggle.Location = New System.Drawing.Point(3, 336)
        Me.AutoRefreshToggle.Name = "AutoRefreshToggle"
        Me.AutoRefreshToggle.Options = ProductionLog.FlatToggle._Options.Style1
        Me.AutoRefreshToggle.Size = New System.Drawing.Size(76, 33)
        Me.AutoRefreshToggle.TabIndex = 35
        '
        'QaJobsRadio
        '
        Me.QaJobsRadio.AutoSize = True
        Me.QaJobsRadio.BackColor = System.Drawing.Color.Gray
        Me.QaJobsRadio.Location = New System.Drawing.Point(528, 118)
        Me.QaJobsRadio.Name = "QaJobsRadio"
        Me.QaJobsRadio.Size = New System.Drawing.Size(111, 25)
        Me.QaJobsRadio.TabIndex = 34
        Me.QaJobsRadio.Text = "My QA Jobs"
        Me.QaJobsRadio.UseVisualStyleBackColor = False
        '
        'MyJobsRadio
        '
        Me.MyJobsRadio.AutoSize = True
        Me.MyJobsRadio.BackColor = System.Drawing.Color.Gray
        Me.MyJobsRadio.Checked = True
        Me.MyJobsRadio.Location = New System.Drawing.Point(528, 95)
        Me.MyJobsRadio.Name = "MyJobsRadio"
        Me.MyJobsRadio.Size = New System.Drawing.Size(85, 25)
        Me.MyJobsRadio.TabIndex = 33
        Me.MyJobsRadio.TabStop = True
        Me.MyJobsRadio.Text = "My Jobs"
        Me.MyJobsRadio.UseVisualStyleBackColor = False
        '
        'VarianceCheckBox
        '
        Me.VarianceCheckBox.AutoCheck = False
        Me.VarianceCheckBox.AutoSize = True
        Me.VarianceCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.VarianceCheckBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VarianceCheckBox.Location = New System.Drawing.Point(294, 343)
        Me.VarianceCheckBox.Name = "VarianceCheckBox"
        Me.VarianceCheckBox.Size = New System.Drawing.Size(77, 21)
        Me.VarianceCheckBox.TabIndex = 32
        Me.VarianceCheckBox.Text = "Variance"
        Me.VarianceCheckBox.UseVisualStyleBackColor = False
        Me.VarianceCheckBox.Visible = False
        '
        'ActualQuantityBox
        '
        Me.ActualQuantityBox.BackColor = System.Drawing.Color.Gray
        Me.ActualQuantityBox.Location = New System.Drawing.Point(358, 255)
        Me.ActualQuantityBox.Name = "ActualQuantityBox"
        Me.ActualQuantityBox.ReadOnly = True
        Me.ActualQuantityBox.Size = New System.Drawing.Size(44, 29)
        Me.ActualQuantityBox.TabIndex = 31
        Me.ActualQuantityBox.Visible = False
        '
        'AQtyLabel
        '
        Me.AQtyLabel.AutoSize = True
        Me.AQtyLabel.BackColor = System.Drawing.Color.Transparent
        Me.AQtyLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AQtyLabel.Location = New System.Drawing.Point(355, 233)
        Me.AQtyLabel.Name = "AQtyLabel"
        Me.AQtyLabel.Size = New System.Drawing.Size(120, 21)
        Me.AQtyLabel.TabIndex = 30
        Me.AQtyLabel.Text = "Actual Quantity:"
        Me.AQtyLabel.Visible = False
        '
        'IDBox
        '
        Me.IDBox.BackColor = System.Drawing.Color.Gray
        Me.IDBox.Location = New System.Drawing.Point(333, 98)
        Me.IDBox.Name = "IDBox"
        Me.IDBox.ReadOnly = True
        Me.IDBox.Size = New System.Drawing.Size(41, 29)
        Me.IDBox.TabIndex = 29
        '
        'BatchIDLabel
        '
        Me.BatchIDLabel.AutoSize = True
        Me.BatchIDLabel.BackColor = System.Drawing.Color.Transparent
        Me.BatchIDLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BatchIDLabel.Location = New System.Drawing.Point(367, 287)
        Me.BatchIDLabel.Name = "BatchIDLabel"
        Me.BatchIDLabel.Size = New System.Drawing.Size(0, 19)
        Me.BatchIDLabel.TabIndex = 28
        '
        'BatchComboBox
        '
        Me.BatchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BatchComboBox.FormattingEnabled = True
        Me.BatchComboBox.Location = New System.Drawing.Point(294, 308)
        Me.BatchComboBox.Name = "BatchComboBox"
        Me.BatchComboBox.Size = New System.Drawing.Size(121, 29)
        Me.BatchComboBox.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(294, 286)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 19)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Batch Info:"
        '
        'ShowButton
        '
        Me.ShowButton.BackColor = System.Drawing.Color.Transparent
        Me.ShowButton.BaseColor = System.Drawing.Color.Tomato
        Me.ShowButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ShowButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ShowButton.Location = New System.Drawing.Point(407, 350)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Rounded = False
        Me.ShowButton.Size = New System.Drawing.Size(110, 21)
        Me.ShowButton.TabIndex = 25
        Me.ShowButton.Text = "Log Collateral"
        Me.ShowButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ShowButton.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(0, 268)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 15)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Refresh Now"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 286)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(0, 318)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 15)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Auto Refresh"
        '
        'LogoutButton
        '
        Me.LogoutButton.BackColor = System.Drawing.Color.Transparent
        Me.LogoutButton.BaseColor = System.Drawing.Color.Tomato
        Me.LogoutButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogoutButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LogoutButton.Location = New System.Drawing.Point(11, 60)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Rounded = False
        Me.LogoutButton.Size = New System.Drawing.Size(80, 24)
        Me.LogoutButton.TabIndex = 20
        Me.LogoutButton.Text = "Log Out"
        Me.LogoutButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.LogoutButton.Visible = False
        '
        'SuccessLabel
        '
        Me.SuccessLabel.AutoSize = True
        Me.SuccessLabel.BackColor = System.Drawing.Color.LightGreen
        Me.SuccessLabel.Location = New System.Drawing.Point(12, 90)
        Me.SuccessLabel.Name = "SuccessLabel"
        Me.SuccessLabel.Size = New System.Drawing.Size(69, 21)
        Me.SuccessLabel.TabIndex = 19
        Me.SuccessLabel.Text = "Success!"
        Me.SuccessLabel.Visible = False
        '
        'EmployeeID
        '
        Me.EmployeeID.AutoSize = True
        Me.EmployeeID.BackColor = System.Drawing.Color.Transparent
        Me.EmployeeID.ForeColor = System.Drawing.Color.White
        Me.EmployeeID.Location = New System.Drawing.Point(460, 1)
        Me.EmployeeID.Name = "EmployeeID"
        Me.EmployeeID.Size = New System.Drawing.Size(19, 21)
        Me.EmployeeID.TabIndex = 18
        Me.EmployeeID.Text = "0"
        '
        'ClockTimeLabel
        '
        Me.ClockTimeLabel.AutoSize = True
        Me.ClockTimeLabel.BackColor = System.Drawing.Color.Transparent
        Me.ClockTimeLabel.Location = New System.Drawing.Point(7, 200)
        Me.ClockTimeLabel.Name = "ClockTimeLabel"
        Me.ClockTimeLabel.Size = New System.Drawing.Size(0, 21)
        Me.ClockTimeLabel.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(7, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 21)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Clocked In:"
        '
        'ClockOutButton
        '
        Me.ClockOutButton.BackColor = System.Drawing.Color.Transparent
        Me.ClockOutButton.BaseColor = System.Drawing.Color.SteelBlue
        Me.ClockOutButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClockOutButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ClockOutButton.Location = New System.Drawing.Point(12, 152)
        Me.ClockOutButton.Name = "ClockOutButton"
        Me.ClockOutButton.Rounded = False
        Me.ClockOutButton.Size = New System.Drawing.Size(80, 24)
        Me.ClockOutButton.TabIndex = 15
        Me.ClockOutButton.Text = "Clock Out"
        Me.ClockOutButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ClockInButton
        '
        Me.ClockInButton.BackColor = System.Drawing.Color.Transparent
        Me.ClockInButton.BaseColor = System.Drawing.Color.SteelBlue
        Me.ClockInButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClockInButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ClockInButton.Location = New System.Drawing.Point(12, 122)
        Me.ClockInButton.Name = "ClockInButton"
        Me.ClockInButton.Rounded = False
        Me.ClockInButton.Size = New System.Drawing.Size(80, 24)
        Me.ClockInButton.TabIndex = 14
        Me.ClockInButton.Text = "Clock In"
        Me.ClockInButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'QuantityBox
        '
        Me.QuantityBox.BackColor = System.Drawing.Color.Gray
        Me.QuantityBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.QuantityBox.ForeColor = System.Drawing.Color.Black
        Me.QuantityBox.Location = New System.Drawing.Point(294, 254)
        Me.QuantityBox.Name = "QuantityBox"
        Me.QuantityBox.ReadOnly = True
        Me.QuantityBox.Size = New System.Drawing.Size(37, 29)
        Me.QuantityBox.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(290, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Quantity:"
        '
        'JobBox
        '
        Me.JobBox.BackColor = System.Drawing.Color.Gray
        Me.JobBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.JobBox.ForeColor = System.Drawing.Color.Black
        Me.JobBox.Location = New System.Drawing.Point(294, 200)
        Me.JobBox.Name = "JobBox"
        Me.JobBox.ReadOnly = True
        Me.JobBox.Size = New System.Drawing.Size(190, 29)
        Me.JobBox.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(294, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Job:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(294, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Dealership:"
        '
        'DealerBox
        '
        Me.DealerBox.BackColor = System.Drawing.Color.Gray
        Me.DealerBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.DealerBox.ForeColor = System.Drawing.Color.Black
        Me.DealerBox.Location = New System.Drawing.Point(294, 146)
        Me.DealerBox.Name = "DealerBox"
        Me.DealerBox.ReadOnly = True
        Me.DealerBox.Size = New System.Drawing.Size(190, 29)
        Me.DealerBox.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Underline)
        Me.Label3.Location = New System.Drawing.Point(294, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Job: "
        '
        'LoginButton
        '
        Me.LoginButton.BackColor = System.Drawing.Color.Transparent
        Me.LoginButton.BaseColor = System.Drawing.Color.DarkOliveGreen
        Me.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LoginButton.Location = New System.Drawing.Point(12, 60)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Rounded = False
        Me.LoginButton.Size = New System.Drawing.Size(80, 24)
        Me.LoginButton.TabIndex = 6
        Me.LoginButton.Text = "Login"
        Me.LoginButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.LoginButton.Visible = False
        '
        'EndButton
        '
        Me.EndButton.BackColor = System.Drawing.Color.Transparent
        Me.EndButton.BaseColor = System.Drawing.Color.SteelBlue
        Me.EndButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EndButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.EndButton.Location = New System.Drawing.Point(398, 95)
        Me.EndButton.Name = "EndButton"
        Me.EndButton.Rounded = False
        Me.EndButton.Size = New System.Drawing.Size(106, 32)
        Me.EndButton.TabIndex = 3
        Me.EndButton.Text = "End"
        Me.EndButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'QAList
        '
        Me.QAList.BackColor = System.Drawing.Color.Silver
        Me.QAList.Enabled = False
        Me.QAList.FormattingEnabled = True
        Me.QAList.ItemHeight = 21
        Me.QAList.Location = New System.Drawing.Point(526, 150)
        Me.QAList.Name = "QAList"
        Me.QAList.Size = New System.Drawing.Size(110, 109)
        Me.QAList.TabIndex = 2
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.Color.Transparent
        Me.StartButton.BaseColor = System.Drawing.Color.SteelBlue
        Me.StartButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StartButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.StartButton.Location = New System.Drawing.Point(398, 60)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Rounded = False
        Me.StartButton.Size = New System.Drawing.Size(106, 32)
        Me.StartButton.TabIndex = 1
        Me.StartButton.Text = "Start"
        Me.StartButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'JobList
        '
        Me.JobList.BackColor = System.Drawing.Color.Silver
        Me.JobList.FormattingEnabled = True
        Me.JobList.ItemHeight = 21
        Me.JobList.Location = New System.Drawing.Point(526, 265)
        Me.JobList.Name = "JobList"
        Me.JobList.Size = New System.Drawing.Size(110, 109)
        Me.JobList.TabIndex = 0
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.Red
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(493, -3)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(27, 25)
        Me.FlatButton1.TabIndex = 44
        Me.FlatButton1.Text = "X"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Clerk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 374)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Clerk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clerk"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As ProductionLog.FormSkin
    Friend WithEvents StartButton As ProductionLog.FlatButton
    Friend WithEvents JobList As System.Windows.Forms.ListBox
    Friend WithEvents EndButton As ProductionLog.FlatButton
    Friend WithEvents QAList As System.Windows.Forms.ListBox
    Friend WithEvents LoginButton As ProductionLog.FlatButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DealerBox As System.Windows.Forms.TextBox
    Friend WithEvents JobBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents QuantityBox As System.Windows.Forms.TextBox
    Friend WithEvents ClockInButton As ProductionLog.FlatButton
    Friend WithEvents ClockOutButton As ProductionLog.FlatButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ClockTimeLabel As System.Windows.Forms.Label
    Friend WithEvents EmployeeID As System.Windows.Forms.Label
    Friend WithEvents SuccessLabel As System.Windows.Forms.Label
    Friend WithEvents LoginSuccessTimer As System.Windows.Forms.Timer
    Friend WithEvents QueueTimer As System.Windows.Forms.Timer
    Friend WithEvents LogoutButton As ProductionLog.FlatButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ShowButton As ProductionLog.FlatButton
    Friend WithEvents BatchComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BatchIDLabel As System.Windows.Forms.Label
    Friend WithEvents IDBox As System.Windows.Forms.TextBox
    Friend WithEvents ActualQuantityBox As System.Windows.Forms.TextBox
    Friend WithEvents AQtyLabel As System.Windows.Forms.Label
    Friend WithEvents VarianceCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents QaJobsRadio As System.Windows.Forms.RadioButton
    Friend WithEvents MyJobsRadio As System.Windows.Forms.RadioButton
    Friend WithEvents AutoRefreshToggle As ProductionLog.FlatToggle
    Friend WithEvents FlatMini1 As ProductionLog.FlatMini
    Friend WithEvents Reassignbutton As ProductionLog.FlatButton
    Friend WithEvents DateLabel As System.Windows.Forms.Label
    Friend WithEvents JobTreeView As System.Windows.Forms.TreeView
    Friend WithEvents InAJobLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ReAssignLabel As System.Windows.Forms.Label
    Friend WithEvents FlatButton1 As ProductionLog.FlatButton
End Class
