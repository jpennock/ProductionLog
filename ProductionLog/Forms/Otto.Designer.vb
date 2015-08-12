<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Otto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Otto))
        Me.OttoFindTimer = New System.Windows.Forms.Timer(Me.components)
        Me.OttoAssignTimer = New System.Windows.Forms.Timer(Me.components)
        Me.OttoBrain3Timer = New System.Windows.Forms.Timer(Me.components)
        Me.SuccessTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TitleAuditTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1 = New ProductionLog.FormSkin()
        Me.MailButton = New ProductionLog.FlatButton()
        Me.OttoThoughtPicture = New System.Windows.Forms.PictureBox()
        Me.FlatTabControl1 = New ProductionLog.FlatTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CleanCycleLabel = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Brain3StatusLabel = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.AssignCycleLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.FindCycleLabel = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LoggedInList = New System.Windows.Forms.ListBox()
        Me.ClockedInList = New System.Windows.Forms.ListBox()
        Me.AssignCurrentStatusLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FindCurrentStatusLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.FlatButton2 = New ProductionLog.FlatButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SLOWList = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OKList = New System.Windows.Forms.ListBox()
        Me.MonitorList = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.SuccessLabel = New System.Windows.Forms.Label()
        Me.FlatButton1 = New ProductionLog.FlatButton()
        Me.LogTextBox = New System.Windows.Forms.RichTextBox()
        Me.OttoToggle = New ProductionLog.FlatToggle()
        Me.FormSkin1.SuspendLayout()
        CType(Me.OttoThoughtPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlatTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'OttoFindTimer
        '
        Me.OttoFindTimer.Interval = 1000
        '
        'OttoAssignTimer
        '
        Me.OttoAssignTimer.Interval = 5000
        '
        'OttoBrain3Timer
        '
        Me.OttoBrain3Timer.Interval = 10000
        '
        'SuccessTimer
        '
        '
        'TitleAuditTimer
        '
        Me.TitleAuditTimer.Interval = 1000
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.Gray
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.MailButton)
        Me.FormSkin1.Controls.Add(Me.OttoThoughtPicture)
        Me.FormSkin1.Controls.Add(Me.FlatTabControl1)
        Me.FormSkin1.Controls.Add(Me.OttoToggle)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.SteelBlue
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(560, 328)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Otto, The Auto Assigner"
        '
        'MailButton
        '
        Me.MailButton.BackColor = System.Drawing.Color.Transparent
        Me.MailButton.BaseColor = System.Drawing.Color.SteelBlue
        Me.MailButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MailButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MailButton.Location = New System.Drawing.Point(507, 3)
        Me.MailButton.Name = "MailButton"
        Me.MailButton.Rounded = False
        Me.MailButton.Size = New System.Drawing.Size(46, 32)
        Me.MailButton.TabIndex = 3
        Me.MailButton.Text = "Mail"
        Me.MailButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'OttoThoughtPicture
        '
        Me.OttoThoughtPicture.BackColor = System.Drawing.Color.Transparent
        Me.OttoThoughtPicture.Image = CType(resources.GetObject("OttoThoughtPicture.Image"), System.Drawing.Image)
        Me.OttoThoughtPicture.Location = New System.Drawing.Point(285, 0)
        Me.OttoThoughtPicture.Name = "OttoThoughtPicture"
        Me.OttoThoughtPicture.Size = New System.Drawing.Size(197, 50)
        Me.OttoThoughtPicture.TabIndex = 2
        Me.OttoThoughtPicture.TabStop = False
        Me.OttoThoughtPicture.Visible = False
        '
        'FlatTabControl1
        '
        Me.FlatTabControl1.ActiveColor = System.Drawing.Color.Gray
        Me.FlatTabControl1.Controls.Add(Me.TabPage1)
        Me.FlatTabControl1.Controls.Add(Me.TabPage2)
        Me.FlatTabControl1.Controls.Add(Me.TabPage3)
        Me.FlatTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatTabControl1.ItemSize = New System.Drawing.Size(120, 40)
        Me.FlatTabControl1.Location = New System.Drawing.Point(3, 51)
        Me.FlatTabControl1.Name = "FlatTabControl1"
        Me.FlatTabControl1.SelectedIndex = 0
        Me.FlatTabControl1.Size = New System.Drawing.Size(557, 274)
        Me.FlatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.CleanCycleLabel)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Brain3StatusLabel)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.AssignCycleLabel)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.FindCycleLabel)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.LoggedInList)
        Me.TabPage1.Controls.Add(Me.ClockedInList)
        Me.TabPage1.Controls.Add(Me.AssignCurrentStatusLabel)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.FindCurrentStatusLabel)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(549, 226)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Current Activity"
        '
        'CleanCycleLabel
        '
        Me.CleanCycleLabel.AutoSize = True
        Me.CleanCycleLabel.ForeColor = System.Drawing.Color.White
        Me.CleanCycleLabel.Location = New System.Drawing.Point(95, 203)
        Me.CleanCycleLabel.Name = "CleanCycleLabel"
        Me.CleanCycleLabel.Size = New System.Drawing.Size(0, 19)
        Me.CleanCycleLabel.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(7, 202)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 19)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Clean Cycles:"
        '
        'Brain3StatusLabel
        '
        Me.Brain3StatusLabel.AutoSize = True
        Me.Brain3StatusLabel.ForeColor = System.Drawing.Color.White
        Me.Brain3StatusLabel.Location = New System.Drawing.Point(90, 50)
        Me.Brain3StatusLabel.Name = "Brain3StatusLabel"
        Me.Brain3StatusLabel.Size = New System.Drawing.Size(0, 19)
        Me.Brain3StatusLabel.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(6, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 19)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Brain Half 3:"
        '
        'AssignCycleLabel
        '
        Me.AssignCycleLabel.AutoSize = True
        Me.AssignCycleLabel.ForeColor = System.Drawing.Color.White
        Me.AssignCycleLabel.Location = New System.Drawing.Point(95, 184)
        Me.AssignCycleLabel.Name = "AssignCycleLabel"
        Me.AssignCycleLabel.Size = New System.Drawing.Size(0, 19)
        Me.AssignCycleLabel.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(6, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 19)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Assign Cycles:"
        '
        'FindCycleLabel
        '
        Me.FindCycleLabel.AutoSize = True
        Me.FindCycleLabel.ForeColor = System.Drawing.Color.White
        Me.FindCycleLabel.Location = New System.Drawing.Point(81, 168)
        Me.FindCycleLabel.Name = "FindCycleLabel"
        Me.FindCycleLabel.Size = New System.Drawing.Size(0, 19)
        Me.FindCycleLabel.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(6, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 19)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Find Cycles:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(432, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 19)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Who's logged in?"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(312, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Who's clocked in?"
        '
        'LoggedInList
        '
        Me.LoggedInList.FormattingEnabled = True
        Me.LoggedInList.ItemHeight = 17
        Me.LoggedInList.Location = New System.Drawing.Point(436, 98)
        Me.LoggedInList.Name = "LoggedInList"
        Me.LoggedInList.Size = New System.Drawing.Size(105, 123)
        Me.LoggedInList.TabIndex = 5
        '
        'ClockedInList
        '
        Me.ClockedInList.FormattingEnabled = True
        Me.ClockedInList.ItemHeight = 17
        Me.ClockedInList.Location = New System.Drawing.Point(316, 98)
        Me.ClockedInList.Name = "ClockedInList"
        Me.ClockedInList.Size = New System.Drawing.Size(105, 123)
        Me.ClockedInList.TabIndex = 4
        '
        'AssignCurrentStatusLabel
        '
        Me.AssignCurrentStatusLabel.AutoSize = True
        Me.AssignCurrentStatusLabel.ForeColor = System.Drawing.Color.White
        Me.AssignCurrentStatusLabel.Location = New System.Drawing.Point(90, 31)
        Me.AssignCurrentStatusLabel.Name = "AssignCurrentStatusLabel"
        Me.AssignCurrentStatusLabel.Size = New System.Drawing.Size(0, 19)
        Me.AssignCurrentStatusLabel.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(6, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 19)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Brain Half 2:"
        '
        'FindCurrentStatusLabel
        '
        Me.FindCurrentStatusLabel.AutoSize = True
        Me.FindCurrentStatusLabel.ForeColor = System.Drawing.Color.White
        Me.FindCurrentStatusLabel.Location = New System.Drawing.Point(90, 12)
        Me.FindCurrentStatusLabel.Name = "FindCurrentStatusLabel"
        Me.FindCurrentStatusLabel.Size = New System.Drawing.Size(0, 19)
        Me.FindCurrentStatusLabel.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Brain Half 1:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.FlatButton2)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.SLOWList)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.OKList)
        Me.TabPage2.Controls.Add(Me.MonitorList)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(549, 226)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Overwatch"
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.SteelBlue
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(508, 194)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(41, 32)
        Me.FlatButton2.TabIndex = 7
        Me.FlatButton2.Text = "R"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(367, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "SLOW"
        '
        'SLOWList
        '
        Me.SLOWList.FormattingEnabled = True
        Me.SLOWList.ItemHeight = 17
        Me.SLOWList.Location = New System.Drawing.Point(371, 28)
        Me.SLOWList.Name = "SLOWList"
        Me.SLOWList.Size = New System.Drawing.Size(132, 174)
        Me.SLOWList.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(192, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "OK"
        '
        'OKList
        '
        Me.OKList.FormattingEnabled = True
        Me.OKList.ItemHeight = 17
        Me.OKList.Location = New System.Drawing.Point(196, 28)
        Me.OKList.Name = "OKList"
        Me.OKList.Size = New System.Drawing.Size(141, 174)
        Me.OKList.TabIndex = 3
        '
        'MonitorList
        '
        Me.MonitorList.FormattingEnabled = True
        Me.MonitorList.ItemHeight = 17
        Me.MonitorList.Location = New System.Drawing.Point(10, 28)
        Me.MonitorList.Name = "MonitorList"
        Me.MonitorList.Size = New System.Drawing.Size(159, 174)
        Me.MonitorList.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Who is being monitored?"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.SuccessLabel)
        Me.TabPage3.Controls.Add(Me.FlatButton1)
        Me.TabPage3.Controls.Add(Me.LogTextBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 44)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(549, 226)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "LOG"
        '
        'SuccessLabel
        '
        Me.SuccessLabel.AutoSize = True
        Me.SuccessLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SuccessLabel.Location = New System.Drawing.Point(475, 167)
        Me.SuccessLabel.Name = "SuccessLabel"
        Me.SuccessLabel.Size = New System.Drawing.Size(55, 19)
        Me.SuccessLabel.TabIndex = 2
        Me.SuccessLabel.Text = "Success"
        Me.SuccessLabel.Visible = False
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.DarkGreen
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(461, 189)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(85, 32)
        Me.FlatButton1.TabIndex = 1
        Me.FlatButton1.Text = "Export"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'LogTextBox
        '
        Me.LogTextBox.Location = New System.Drawing.Point(3, 3)
        Me.LogTextBox.Name = "LogTextBox"
        Me.LogTextBox.ReadOnly = True
        Me.LogTextBox.Size = New System.Drawing.Size(456, 218)
        Me.LogTextBox.TabIndex = 0
        Me.LogTextBox.Text = ""
        '
        'OttoToggle
        '
        Me.OttoToggle.BackColor = System.Drawing.Color.Transparent
        Me.OttoToggle.Checked = False
        Me.OttoToggle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OttoToggle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.OttoToggle.Location = New System.Drawing.Point(203, 12)
        Me.OttoToggle.Name = "OttoToggle"
        Me.OttoToggle.Options = ProductionLog.FlatToggle._Options.Style3
        Me.OttoToggle.Size = New System.Drawing.Size(76, 33)
        Me.OttoToggle.TabIndex = 0
        Me.OttoToggle.Text = "FlatToggle1"
        '
        'Otto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 328)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Otto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Otto"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        CType(Me.OttoThoughtPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlatTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As ProductionLog.FormSkin
    Friend WithEvents OttoToggle As ProductionLog.FlatToggle
    Friend WithEvents OttoFindTimer As System.Windows.Forms.Timer
    Friend WithEvents FlatTabControl1 As ProductionLog.FlatTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OttoThoughtPicture As System.Windows.Forms.PictureBox
    Friend WithEvents FindCurrentStatusLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OttoAssignTimer As System.Windows.Forms.Timer
    Friend WithEvents AssignCurrentStatusLabel As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LoggedInList As System.Windows.Forms.ListBox
    Friend WithEvents ClockedInList As System.Windows.Forms.ListBox
    Friend WithEvents AssignCycleLabel As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents FindCycleLabel As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Brain3StatusLabel As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents OttoBrain3Timer As System.Windows.Forms.Timer
    Friend WithEvents CleanCycleLabel As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents LogTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents FlatButton1 As ProductionLog.FlatButton
    Friend WithEvents SuccessLabel As System.Windows.Forms.Label
    Friend WithEvents SuccessTimer As System.Windows.Forms.Timer
    Friend WithEvents MailButton As ProductionLog.FlatButton
    Friend WithEvents MonitorList As System.Windows.Forms.ListBox
    Friend WithEvents OKList As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SLOWList As System.Windows.Forms.ListBox
    Friend WithEvents FlatButton2 As ProductionLog.FlatButton
    Friend WithEvents TitleAuditTimer As System.Windows.Forms.Timer
End Class
