<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeamLead
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TeamLead))
        Me.SuccessTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1 = New ProductionLog.FormSkin()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.SuccessLabel = New System.Windows.Forms.Label()
        Me.RefreshButton = New System.Windows.Forms.PictureBox()
        Me.FlatButton1 = New ProductionLog.FlatButton()
        Me.EmpIDLabel = New System.Windows.Forms.Label()
        Me.FlatTabControl1 = New ProductionLog.FlatTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.FlatGroupBox1 = New ProductionLog.FlatGroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlatGroupBox2 = New ProductionLog.FlatGroupBox()
        Me.JobCommentBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.JobAssignButton = New ProductionLog.FlatButton()
        Me.QuantityBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.EmployeeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.JobComboBox = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DealerComboBox = New System.Windows.Forms.ComboBox()
        Me.BatchIDLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.FlatGroupBox3 = New ProductionLog.FlatGroupBox()
        Me.QAReassignButton = New ProductionLog.FlatButton()
        Me.QAEmployeeList = New System.Windows.Forms.ListBox()
        Me.QAList = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FlatGroupBox4 = New ProductionLog.FlatGroupBox()
        Me.WFReassignButton = New ProductionLog.FlatButton()
        Me.WFEmployeeList = New System.Windows.Forms.ListBox()
        Me.WorkFlowList = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.FlatGroupBox7 = New ProductionLog.FlatGroupBox()
        Me.FlatButton4 = New ProductionLog.FlatButton()
        Me.FlatButton3 = New ProductionLog.FlatButton()
        Me.MonitorEmpList = New System.Windows.Forms.ListBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.FlatGroupBox5 = New ProductionLog.FlatGroupBox()
        Me.FlatButton2 = New ProductionLog.FlatButton()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.EmailBox = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.EmpLastBox = New System.Windows.Forms.TextBox()
        Me.EmpFirstBox = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FlatGroupBox6 = New ProductionLog.FlatGroupBox()
        Me.OccurrenceButton = New ProductionLog.FlatButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.OccurrenceDate = New System.Windows.Forms.DateTimePicker()
        Me.OccurrenceCommentBox = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.OccurrenceEmployeeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.OccurrenceComboBox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.ClockAndLogList = New System.Windows.Forms.ListBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.OpenJobsList = New System.Windows.Forms.ListBox()
        Me.FormSkin1.SuspendLayout()
        CType(Me.RefreshButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlatTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.FlatGroupBox1.SuspendLayout()
        Me.FlatGroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.FlatGroupBox3.SuspendLayout()
        Me.FlatGroupBox4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.FlatGroupBox7.SuspendLayout()
        Me.FlatGroupBox5.SuspendLayout()
        Me.FlatGroupBox6.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'SuccessTimer
        '
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.Gray
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.Label24)
        Me.FormSkin1.Controls.Add(Me.SuccessLabel)
        Me.FormSkin1.Controls.Add(Me.RefreshButton)
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Controls.Add(Me.EmpIDLabel)
        Me.FormSkin1.Controls.Add(Me.FlatTabControl1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.SteelBlue
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(866, 546)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Team Lead"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label24.Location = New System.Drawing.Point(123, 13)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(63, 21)
        Me.Label24.TabIndex = 27
        Me.Label24.Text = "Refresh"
        '
        'SuccessLabel
        '
        Me.SuccessLabel.AutoSize = True
        Me.SuccessLabel.BackColor = System.Drawing.Color.Green
        Me.SuccessLabel.ForeColor = System.Drawing.Color.White
        Me.SuccessLabel.Location = New System.Drawing.Point(361, 9)
        Me.SuccessLabel.Name = "SuccessLabel"
        Me.SuccessLabel.Size = New System.Drawing.Size(64, 21)
        Me.SuccessLabel.TabIndex = 26
        Me.SuccessLabel.Text = "Success"
        Me.SuccessLabel.Visible = False
        '
        'RefreshButton
        '
        Me.RefreshButton.BackColor = System.Drawing.Color.Transparent
        Me.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RefreshButton.Image = CType(resources.GetObject("RefreshButton.Image"), System.Drawing.Image)
        Me.RefreshButton.Location = New System.Drawing.Point(190, 11)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(27, 27)
        Me.RefreshButton.TabIndex = 25
        Me.RefreshButton.TabStop = False
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.Maroon
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.ForeColor = System.Drawing.Color.White
        Me.FlatButton1.Location = New System.Drawing.Point(839, 0)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(27, 22)
        Me.FlatButton1.TabIndex = 2
        Me.FlatButton1.Text = "X"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'EmpIDLabel
        '
        Me.EmpIDLabel.AutoSize = True
        Me.EmpIDLabel.BackColor = System.Drawing.Color.Transparent
        Me.EmpIDLabel.ForeColor = System.Drawing.Color.White
        Me.EmpIDLabel.Location = New System.Drawing.Point(844, 25)
        Me.EmpIDLabel.Name = "EmpIDLabel"
        Me.EmpIDLabel.Size = New System.Drawing.Size(19, 21)
        Me.EmpIDLabel.TabIndex = 1
        Me.EmpIDLabel.Text = "0"
        '
        'FlatTabControl1
        '
        Me.FlatTabControl1.ActiveColor = System.Drawing.Color.Gray
        Me.FlatTabControl1.Controls.Add(Me.TabPage1)
        Me.FlatTabControl1.Controls.Add(Me.TabPage2)
        Me.FlatTabControl1.Controls.Add(Me.TabPage3)
        Me.FlatTabControl1.Controls.Add(Me.TabPage4)
        Me.FlatTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatTabControl1.ItemSize = New System.Drawing.Size(120, 40)
        Me.FlatTabControl1.Location = New System.Drawing.Point(0, 49)
        Me.FlatTabControl1.Name = "FlatTabControl1"
        Me.FlatTabControl1.SelectedIndex = 0
        Me.FlatTabControl1.Size = New System.Drawing.Size(863, 497)
        Me.FlatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.FlatGroupBox1)
        Me.TabPage1.Controls.Add(Me.FlatGroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(855, 449)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Create"
        '
        'FlatGroupBox1
        '
        Me.FlatGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox1.BaseColor = System.Drawing.Color.Gray
        Me.FlatGroupBox1.Controls.Add(Me.Label13)
        Me.FlatGroupBox1.Controls.Add(Me.Label1)
        Me.FlatGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox1.ForeColor = System.Drawing.Color.White
        Me.FlatGroupBox1.Location = New System.Drawing.Point(361, 27)
        Me.FlatGroupBox1.Name = "FlatGroupBox1"
        Me.FlatGroupBox1.ShowText = True
        Me.FlatGroupBox1.Size = New System.Drawing.Size(330, 359)
        Me.FlatGroupBox1.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(97, 163)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(130, 19)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Under Construction"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "QA Jobs"
        '
        'FlatGroupBox2
        '
        Me.FlatGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox2.BaseColor = System.Drawing.Color.Gray
        Me.FlatGroupBox2.Controls.Add(Me.JobCommentBox)
        Me.FlatGroupBox2.Controls.Add(Me.Label12)
        Me.FlatGroupBox2.Controls.Add(Me.JobAssignButton)
        Me.FlatGroupBox2.Controls.Add(Me.QuantityBox)
        Me.FlatGroupBox2.Controls.Add(Me.Label11)
        Me.FlatGroupBox2.Controls.Add(Me.EmployeeComboBox)
        Me.FlatGroupBox2.Controls.Add(Me.Label10)
        Me.FlatGroupBox2.Controls.Add(Me.JobComboBox)
        Me.FlatGroupBox2.Controls.Add(Me.Label9)
        Me.FlatGroupBox2.Controls.Add(Me.Label8)
        Me.FlatGroupBox2.Controls.Add(Me.DealerComboBox)
        Me.FlatGroupBox2.Controls.Add(Me.BatchIDLabel)
        Me.FlatGroupBox2.Controls.Add(Me.Label7)
        Me.FlatGroupBox2.Controls.Add(Me.Label2)
        Me.FlatGroupBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox2.ForeColor = System.Drawing.Color.White
        Me.FlatGroupBox2.Location = New System.Drawing.Point(8, 27)
        Me.FlatGroupBox2.Name = "FlatGroupBox2"
        Me.FlatGroupBox2.ShowText = True
        Me.FlatGroupBox2.Size = New System.Drawing.Size(326, 359)
        Me.FlatGroupBox2.TabIndex = 4
        '
        'JobCommentBox
        '
        Me.JobCommentBox.Location = New System.Drawing.Point(29, 307)
        Me.JobCommentBox.Name = "JobCommentBox"
        Me.JobCommentBox.Size = New System.Drawing.Size(165, 25)
        Me.JobCommentBox.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(26, 285)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 19)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Comment:"
        '
        'JobAssignButton
        '
        Me.JobAssignButton.BackColor = System.Drawing.Color.Transparent
        Me.JobAssignButton.BaseColor = System.Drawing.Color.Green
        Me.JobAssignButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.JobAssignButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.JobAssignButton.Location = New System.Drawing.Point(222, 51)
        Me.JobAssignButton.Name = "JobAssignButton"
        Me.JobAssignButton.Rounded = False
        Me.JobAssignButton.Size = New System.Drawing.Size(80, 32)
        Me.JobAssignButton.TabIndex = 11
        Me.JobAssignButton.Text = "Assign"
        Me.JobAssignButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'QuantityBox
        '
        Me.QuantityBox.Location = New System.Drawing.Point(30, 257)
        Me.QuantityBox.Name = "QuantityBox"
        Me.QuantityBox.Size = New System.Drawing.Size(44, 25)
        Me.QuantityBox.TabIndex = 10
        Me.QuantityBox.Text = "1"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 235)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 19)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Quantity:"
        '
        'EmployeeComboBox
        '
        Me.EmployeeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EmployeeComboBox.FormattingEnabled = True
        Me.EmployeeComboBox.Location = New System.Drawing.Point(27, 207)
        Me.EmployeeComboBox.Name = "EmployeeComboBox"
        Me.EmployeeComboBox.Size = New System.Drawing.Size(167, 25)
        Me.EmployeeComboBox.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 185)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 19)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Employee:"
        '
        'JobComboBox
        '
        Me.JobComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.JobComboBox.FormattingEnabled = True
        Me.JobComboBox.Location = New System.Drawing.Point(27, 157)
        Me.JobComboBox.Name = "JobComboBox"
        Me.JobComboBox.Size = New System.Drawing.Size(167, 25)
        Me.JobComboBox.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 19)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Job Type:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 19)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Dealer:"
        '
        'DealerComboBox
        '
        Me.DealerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DealerComboBox.FormattingEnabled = True
        Me.DealerComboBox.Location = New System.Drawing.Point(27, 107)
        Me.DealerComboBox.Name = "DealerComboBox"
        Me.DealerComboBox.Size = New System.Drawing.Size(167, 25)
        Me.DealerComboBox.TabIndex = 3
        '
        'BatchIDLabel
        '
        Me.BatchIDLabel.AutoSize = True
        Me.BatchIDLabel.Location = New System.Drawing.Point(89, 51)
        Me.BatchIDLabel.Name = "BatchIDLabel"
        Me.BatchIDLabel.Size = New System.Drawing.Size(67, 19)
        Me.BatchIDLabel.TabIndex = 2
        Me.BatchIDLabel.Text = "MANUAL"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 19)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "BatchID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Workflow Jobs"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.FlatGroupBox3)
        Me.TabPage2.Controls.Add(Me.FlatGroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(855, 449)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Assign"
        '
        'FlatGroupBox3
        '
        Me.FlatGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox3.BaseColor = System.Drawing.Color.Gray
        Me.FlatGroupBox3.Controls.Add(Me.QAReassignButton)
        Me.FlatGroupBox3.Controls.Add(Me.QAEmployeeList)
        Me.FlatGroupBox3.Controls.Add(Me.QAList)
        Me.FlatGroupBox3.Controls.Add(Me.Label3)
        Me.FlatGroupBox3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox3.ForeColor = System.Drawing.Color.White
        Me.FlatGroupBox3.Location = New System.Drawing.Point(416, 27)
        Me.FlatGroupBox3.Name = "FlatGroupBox3"
        Me.FlatGroupBox3.ShowText = True
        Me.FlatGroupBox3.Size = New System.Drawing.Size(402, 395)
        Me.FlatGroupBox3.TabIndex = 3
        '
        'QAReassignButton
        '
        Me.QAReassignButton.BackColor = System.Drawing.Color.Transparent
        Me.QAReassignButton.BaseColor = System.Drawing.Color.Green
        Me.QAReassignButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.QAReassignButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.QAReassignButton.Location = New System.Drawing.Point(270, 321)
        Me.QAReassignButton.Name = "QAReassignButton"
        Me.QAReassignButton.Rounded = False
        Me.QAReassignButton.Size = New System.Drawing.Size(106, 32)
        Me.QAReassignButton.TabIndex = 4
        Me.QAReassignButton.Text = "Re-Assign"
        Me.QAReassignButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'QAEmployeeList
        '
        Me.QAEmployeeList.FormattingEnabled = True
        Me.QAEmployeeList.ItemHeight = 17
        Me.QAEmployeeList.Location = New System.Drawing.Point(228, 43)
        Me.QAEmployeeList.Name = "QAEmployeeList"
        Me.QAEmployeeList.Size = New System.Drawing.Size(148, 225)
        Me.QAEmployeeList.TabIndex = 3
        '
        'QAList
        '
        Me.QAList.FormattingEnabled = True
        Me.QAList.ItemHeight = 17
        Me.QAList.Location = New System.Drawing.Point(32, 43)
        Me.QAList.Name = "QAList"
        Me.QAList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.QAList.Size = New System.Drawing.Size(190, 310)
        Me.QAList.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "QA Jobs"
        '
        'FlatGroupBox4
        '
        Me.FlatGroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox4.BaseColor = System.Drawing.Color.Gray
        Me.FlatGroupBox4.Controls.Add(Me.WFReassignButton)
        Me.FlatGroupBox4.Controls.Add(Me.WFEmployeeList)
        Me.FlatGroupBox4.Controls.Add(Me.WorkFlowList)
        Me.FlatGroupBox4.Controls.Add(Me.Label4)
        Me.FlatGroupBox4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox4.ForeColor = System.Drawing.Color.White
        Me.FlatGroupBox4.Location = New System.Drawing.Point(8, 27)
        Me.FlatGroupBox4.Name = "FlatGroupBox4"
        Me.FlatGroupBox4.ShowText = True
        Me.FlatGroupBox4.Size = New System.Drawing.Size(402, 395)
        Me.FlatGroupBox4.TabIndex = 2
        '
        'WFReassignButton
        '
        Me.WFReassignButton.BackColor = System.Drawing.Color.Transparent
        Me.WFReassignButton.BaseColor = System.Drawing.Color.Green
        Me.WFReassignButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WFReassignButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.WFReassignButton.Location = New System.Drawing.Point(261, 321)
        Me.WFReassignButton.Name = "WFReassignButton"
        Me.WFReassignButton.Rounded = False
        Me.WFReassignButton.Size = New System.Drawing.Size(106, 32)
        Me.WFReassignButton.TabIndex = 3
        Me.WFReassignButton.Text = "Re-Assign"
        Me.WFReassignButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'WFEmployeeList
        '
        Me.WFEmployeeList.FormattingEnabled = True
        Me.WFEmployeeList.ItemHeight = 17
        Me.WFEmployeeList.Location = New System.Drawing.Point(219, 43)
        Me.WFEmployeeList.Name = "WFEmployeeList"
        Me.WFEmployeeList.Size = New System.Drawing.Size(148, 225)
        Me.WFEmployeeList.TabIndex = 2
        '
        'WorkFlowList
        '
        Me.WorkFlowList.FormattingEnabled = True
        Me.WorkFlowList.ItemHeight = 17
        Me.WorkFlowList.Location = New System.Drawing.Point(27, 43)
        Me.WorkFlowList.Name = "WorkFlowList"
        Me.WorkFlowList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.WorkFlowList.Size = New System.Drawing.Size(186, 310)
        Me.WorkFlowList.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Workflow Jobs"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.FlatGroupBox7)
        Me.TabPage3.Controls.Add(Me.FlatGroupBox5)
        Me.TabPage3.Controls.Add(Me.FlatGroupBox6)
        Me.TabPage3.Location = New System.Drawing.Point(4, 44)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(855, 449)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Manage"
        '
        'FlatGroupBox7
        '
        Me.FlatGroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox7.BaseColor = System.Drawing.Color.Gray
        Me.FlatGroupBox7.Controls.Add(Me.FlatButton4)
        Me.FlatGroupBox7.Controls.Add(Me.FlatButton3)
        Me.FlatGroupBox7.Controls.Add(Me.MonitorEmpList)
        Me.FlatGroupBox7.Controls.Add(Me.Label27)
        Me.FlatGroupBox7.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox7.Location = New System.Drawing.Point(254, 27)
        Me.FlatGroupBox7.Name = "FlatGroupBox7"
        Me.FlatGroupBox7.ShowText = True
        Me.FlatGroupBox7.Size = New System.Drawing.Size(218, 343)
        Me.FlatGroupBox7.TabIndex = 4
        '
        'FlatButton4
        '
        Me.FlatButton4.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton4.BaseColor = System.Drawing.Color.SteelBlue
        Me.FlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton4.Location = New System.Drawing.Point(107, 288)
        Me.FlatButton4.Name = "FlatButton4"
        Me.FlatButton4.Rounded = False
        Me.FlatButton4.Size = New System.Drawing.Size(77, 32)
        Me.FlatButton4.TabIndex = 12
        Me.FlatButton4.Text = "Remove"
        Me.FlatButton4.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton3
        '
        Me.FlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton3.BaseColor = System.Drawing.Color.Green
        Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton3.Location = New System.Drawing.Point(17, 288)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Rounded = False
        Me.FlatButton3.Size = New System.Drawing.Size(73, 32)
        Me.FlatButton3.TabIndex = 10
        Me.FlatButton3.Text = "Add"
        Me.FlatButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'MonitorEmpList
        '
        Me.MonitorEmpList.FormattingEnabled = True
        Me.MonitorEmpList.ItemHeight = 17
        Me.MonitorEmpList.Location = New System.Drawing.Point(17, 57)
        Me.MonitorEmpList.Name = "MonitorEmpList"
        Me.MonitorEmpList.Size = New System.Drawing.Size(176, 225)
        Me.MonitorEmpList.TabIndex = 11
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(13, 21)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(59, 19)
        Me.Label27.TabIndex = 10
        Me.Label27.Text = "Monitor"
        '
        'FlatGroupBox5
        '
        Me.FlatGroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox5.BaseColor = System.Drawing.Color.Gray
        Me.FlatGroupBox5.Controls.Add(Me.FlatButton2)
        Me.FlatGroupBox5.Controls.Add(Me.Label23)
        Me.FlatGroupBox5.Controls.Add(Me.Label22)
        Me.FlatGroupBox5.Controls.Add(Me.EmailBox)
        Me.FlatGroupBox5.Controls.Add(Me.Label21)
        Me.FlatGroupBox5.Controls.Add(Me.Label20)
        Me.FlatGroupBox5.Controls.Add(Me.Label19)
        Me.FlatGroupBox5.Controls.Add(Me.EmpLastBox)
        Me.FlatGroupBox5.Controls.Add(Me.EmpFirstBox)
        Me.FlatGroupBox5.Controls.Add(Me.Label14)
        Me.FlatGroupBox5.Controls.Add(Me.Label5)
        Me.FlatGroupBox5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox5.ForeColor = System.Drawing.Color.White
        Me.FlatGroupBox5.Location = New System.Drawing.Point(478, 27)
        Me.FlatGroupBox5.Name = "FlatGroupBox5"
        Me.FlatGroupBox5.ShowText = True
        Me.FlatGroupBox5.Size = New System.Drawing.Size(361, 343)
        Me.FlatGroupBox5.TabIndex = 3
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.Green
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(135, 207)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(73, 32)
        Me.FlatButton2.TabIndex = 10
        Me.FlatButton2.Text = "OK"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(20, 288)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(323, 19)
        Me.Label23.TabIndex = 9
        Me.Label23.Text = "asking them to reply with their desired PIN number"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(29, 269)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(284, 19)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "The employee will receive an email soon after"
        '
        'EmailBox
        '
        Me.EmailBox.Location = New System.Drawing.Point(22, 161)
        Me.EmailBox.Name = "EmailBox"
        Me.EmailBox.Size = New System.Drawing.Size(291, 25)
        Me.EmailBox.TabIndex = 7
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(18, 127)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(44, 19)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "Email:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(178, 67)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(77, 19)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "Last Name:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(18, 67)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(78, 19)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "First Name:"
        '
        'EmpLastBox
        '
        Me.EmpLastBox.Location = New System.Drawing.Point(182, 89)
        Me.EmpLastBox.Name = "EmpLastBox"
        Me.EmpLastBox.Size = New System.Drawing.Size(131, 25)
        Me.EmpLastBox.TabIndex = 3
        '
        'EmpFirstBox
        '
        Me.EmpFirstBox.Location = New System.Drawing.Point(22, 89)
        Me.EmpFirstBox.Name = "EmpFirstBox"
        Me.EmpFirstBox.Size = New System.Drawing.Size(131, 25)
        Me.EmpFirstBox.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(18, 21)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 19)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "New Employee"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 19)
        Me.Label5.TabIndex = 0
        '
        'FlatGroupBox6
        '
        Me.FlatGroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox6.BaseColor = System.Drawing.Color.Gray
        Me.FlatGroupBox6.Controls.Add(Me.OccurrenceButton)
        Me.FlatGroupBox6.Controls.Add(Me.Label18)
        Me.FlatGroupBox6.Controls.Add(Me.OccurrenceDate)
        Me.FlatGroupBox6.Controls.Add(Me.OccurrenceCommentBox)
        Me.FlatGroupBox6.Controls.Add(Me.Label17)
        Me.FlatGroupBox6.Controls.Add(Me.OccurrenceEmployeeComboBox)
        Me.FlatGroupBox6.Controls.Add(Me.Label16)
        Me.FlatGroupBox6.Controls.Add(Me.Label15)
        Me.FlatGroupBox6.Controls.Add(Me.OccurrenceComboBox)
        Me.FlatGroupBox6.Controls.Add(Me.Label6)
        Me.FlatGroupBox6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox6.ForeColor = System.Drawing.Color.White
        Me.FlatGroupBox6.Location = New System.Drawing.Point(8, 27)
        Me.FlatGroupBox6.Name = "FlatGroupBox6"
        Me.FlatGroupBox6.ShowText = True
        Me.FlatGroupBox6.Size = New System.Drawing.Size(244, 343)
        Me.FlatGroupBox6.TabIndex = 2
        '
        'OccurrenceButton
        '
        Me.OccurrenceButton.BackColor = System.Drawing.Color.Transparent
        Me.OccurrenceButton.BaseColor = System.Drawing.Color.Green
        Me.OccurrenceButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OccurrenceButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.OccurrenceButton.Location = New System.Drawing.Point(27, 287)
        Me.OccurrenceButton.Name = "OccurrenceButton"
        Me.OccurrenceButton.Rounded = False
        Me.OccurrenceButton.Size = New System.Drawing.Size(73, 32)
        Me.OccurrenceButton.TabIndex = 9
        Me.OccurrenceButton.Text = "Log"
        Me.OccurrenceButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(23, 220)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(114, 19)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Occurrence Date:"
        '
        'OccurrenceDate
        '
        Me.OccurrenceDate.CustomFormat = "yyyy-MM-dd"
        Me.OccurrenceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.OccurrenceDate.Location = New System.Drawing.Point(27, 242)
        Me.OccurrenceDate.Name = "OccurrenceDate"
        Me.OccurrenceDate.Size = New System.Drawing.Size(97, 25)
        Me.OccurrenceDate.TabIndex = 7
        '
        'OccurrenceCommentBox
        '
        Me.OccurrenceCommentBox.Location = New System.Drawing.Point(27, 189)
        Me.OccurrenceCommentBox.Name = "OccurrenceCommentBox"
        Me.OccurrenceCommentBox.Size = New System.Drawing.Size(156, 25)
        Me.OccurrenceCommentBox.TabIndex = 6
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(23, 167)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 19)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "Comment:"
        '
        'OccurrenceEmployeeComboBox
        '
        Me.OccurrenceEmployeeComboBox.FormattingEnabled = True
        Me.OccurrenceEmployeeComboBox.Location = New System.Drawing.Point(27, 139)
        Me.OccurrenceEmployeeComboBox.Name = "OccurrenceEmployeeComboBox"
        Me.OccurrenceEmployeeComboBox.Size = New System.Drawing.Size(156, 25)
        Me.OccurrenceEmployeeComboBox.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(23, 117)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 19)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Employee:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(23, 67)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 19)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Type:"
        '
        'OccurrenceComboBox
        '
        Me.OccurrenceComboBox.FormattingEnabled = True
        Me.OccurrenceComboBox.Items.AddRange(New Object() {"Absence", "Arrived Late", "Left Early"})
        Me.OccurrenceComboBox.Location = New System.Drawing.Point(27, 89)
        Me.OccurrenceComboBox.Name = "OccurrenceComboBox"
        Me.OccurrenceComboBox.Size = New System.Drawing.Size(156, 25)
        Me.OccurrenceComboBox.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Occurrences"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.Label26)
        Me.TabPage4.Controls.Add(Me.ClockAndLogList)
        Me.TabPage4.Controls.Add(Me.Label25)
        Me.TabPage4.Controls.Add(Me.OpenJobsList)
        Me.TabPage4.Location = New System.Drawing.Point(4, 44)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(855, 449)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "View"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label26.Location = New System.Drawing.Point(596, 6)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(221, 19)
        Me.Label26.TabIndex = 4
        Me.Label26.Text = "Employees Clocked and Logged in:"
        '
        'ClockAndLogList
        '
        Me.ClockAndLogList.FormattingEnabled = True
        Me.ClockAndLogList.ItemHeight = 17
        Me.ClockAndLogList.Location = New System.Drawing.Point(600, 28)
        Me.ClockAndLogList.Name = "ClockAndLogList"
        Me.ClockAndLogList.Size = New System.Drawing.Size(176, 225)
        Me.ClockAndLogList.TabIndex = 3
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label25.Location = New System.Drawing.Point(8, 6)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(74, 19)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "Open Jobs"
        '
        'OpenJobsList
        '
        Me.OpenJobsList.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.OpenJobsList.FormattingEnabled = True
        Me.OpenJobsList.ItemHeight = 20
        Me.OpenJobsList.Location = New System.Drawing.Point(8, 28)
        Me.OpenJobsList.Name = "OpenJobsList"
        Me.OpenJobsList.Size = New System.Drawing.Size(586, 364)
        Me.OpenJobsList.TabIndex = 0
        '
        'TeamLead
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 546)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TeamLead"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TeamLead"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        CType(Me.RefreshButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlatTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.FlatGroupBox1.ResumeLayout(False)
        Me.FlatGroupBox1.PerformLayout()
        Me.FlatGroupBox2.ResumeLayout(False)
        Me.FlatGroupBox2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.FlatGroupBox3.ResumeLayout(False)
        Me.FlatGroupBox3.PerformLayout()
        Me.FlatGroupBox4.ResumeLayout(False)
        Me.FlatGroupBox4.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.FlatGroupBox7.ResumeLayout(False)
        Me.FlatGroupBox7.PerformLayout()
        Me.FlatGroupBox5.ResumeLayout(False)
        Me.FlatGroupBox5.PerformLayout()
        Me.FlatGroupBox6.ResumeLayout(False)
        Me.FlatGroupBox6.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As ProductionLog.FormSkin
    Friend WithEvents FlatTabControl1 As ProductionLog.FlatTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents FlatGroupBox3 As ProductionLog.FlatGroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FlatGroupBox4 As ProductionLog.FlatGroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FlatGroupBox5 As ProductionLog.FlatGroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FlatGroupBox6 As ProductionLog.FlatGroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents FlatGroupBox1 As ProductionLog.FlatGroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FlatGroupBox2 As ProductionLog.FlatGroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BatchIDLabel As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents EmpIDLabel As System.Windows.Forms.Label
    Friend WithEvents FlatButton1 As ProductionLog.FlatButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DealerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents JobComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents EmployeeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents QuantityBox As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents JobAssignButton As ProductionLog.FlatButton
    Friend WithEvents JobCommentBox As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents QAList As System.Windows.Forms.ListBox
    Friend WithEvents WorkFlowList As System.Windows.Forms.ListBox
    Friend WithEvents RefreshButton As System.Windows.Forms.PictureBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents QAEmployeeList As System.Windows.Forms.ListBox
    Friend WithEvents WFEmployeeList As System.Windows.Forms.ListBox
    Friend WithEvents WFReassignButton As ProductionLog.FlatButton
    Friend WithEvents QAReassignButton As ProductionLog.FlatButton
    Friend WithEvents OccurrenceComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents OccurrenceEmployeeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents OccurrenceCommentBox As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents OccurrenceDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents OccurrenceButton As ProductionLog.FlatButton
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents EmpLastBox As System.Windows.Forms.TextBox
    Friend WithEvents EmpFirstBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailBox As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents FlatButton2 As ProductionLog.FlatButton
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents SuccessLabel As System.Windows.Forms.Label
    Friend WithEvents SuccessTimer As System.Windows.Forms.Timer
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents OpenJobsList As System.Windows.Forms.ListBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents ClockAndLogList As System.Windows.Forms.ListBox
    Friend WithEvents FlatGroupBox7 As ProductionLog.FlatGroupBox
    Friend WithEvents MonitorEmpList As System.Windows.Forms.ListBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents FlatButton3 As ProductionLog.FlatButton
    Friend WithEvents FlatButton4 As ProductionLog.FlatButton
End Class
