<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OttoMail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OttoMail))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CommandTimer = New System.Windows.Forms.Timer(Me.components)
        Me.BBTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1 = New ProductionLog.FormSkin()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BBSentList = New System.Windows.Forms.ListBox()
        Me.CheckLabel = New System.Windows.Forms.Label()
        Me.CommandLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CommandList = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FundingList = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FromList = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SubjectList = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RefreshButton = New ProductionLog.FlatButton()
        Me.FlatToggle1 = New ProductionLog.FlatToggle()
        Me.MCountLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ReplyList = New System.Windows.Forms.ListBox()
        Me.FormSkin1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'CommandTimer
        '
        Me.CommandTimer.Interval = 5000
        '
        'BBTimer
        '
        Me.BBTimer.Interval = 7500
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.Gray
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.ReplyList)
        Me.FormSkin1.Controls.Add(Me.Label9)
        Me.FormSkin1.Controls.Add(Me.Label8)
        Me.FormSkin1.Controls.Add(Me.BBSentList)
        Me.FormSkin1.Controls.Add(Me.CheckLabel)
        Me.FormSkin1.Controls.Add(Me.CommandLabel)
        Me.FormSkin1.Controls.Add(Me.Label7)
        Me.FormSkin1.Controls.Add(Me.Label6)
        Me.FormSkin1.Controls.Add(Me.CommandList)
        Me.FormSkin1.Controls.Add(Me.Label5)
        Me.FormSkin1.Controls.Add(Me.Label4)
        Me.FormSkin1.Controls.Add(Me.FundingList)
        Me.FormSkin1.Controls.Add(Me.Label3)
        Me.FormSkin1.Controls.Add(Me.FromList)
        Me.FormSkin1.Controls.Add(Me.Label2)
        Me.FormSkin1.Controls.Add(Me.SubjectList)
        Me.FormSkin1.Controls.Add(Me.Label1)
        Me.FormSkin1.Controls.Add(Me.RefreshButton)
        Me.FormSkin1.Controls.Add(Me.FlatToggle1)
        Me.FormSkin1.Controls.Add(Me.MCountLabel)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.SteelBlue
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(978, 454)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "OttoMail!"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(753, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 21)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "BB Sent:"
        '
        'BBSentList
        '
        Me.BBSentList.FormattingEnabled = True
        Me.BBSentList.ItemHeight = 21
        Me.BBSentList.Location = New System.Drawing.Point(757, 81)
        Me.BBSentList.Name = "BBSentList"
        Me.BBSentList.Size = New System.Drawing.Size(175, 172)
        Me.BBSentList.TabIndex = 16
        '
        'CheckLabel
        '
        Me.CheckLabel.AutoSize = True
        Me.CheckLabel.BackColor = System.Drawing.Color.Transparent
        Me.CheckLabel.ForeColor = System.Drawing.Color.White
        Me.CheckLabel.Location = New System.Drawing.Point(929, 21)
        Me.CheckLabel.Name = "CheckLabel"
        Me.CheckLabel.Size = New System.Drawing.Size(19, 21)
        Me.CheckLabel.TabIndex = 15
        Me.CheckLabel.Text = "0"
        '
        'CommandLabel
        '
        Me.CommandLabel.AutoSize = True
        Me.CommandLabel.BackColor = System.Drawing.Color.Transparent
        Me.CommandLabel.ForeColor = System.Drawing.Color.White
        Me.CommandLabel.Location = New System.Drawing.Point(929, 0)
        Me.CommandLabel.Name = "CommandLabel"
        Me.CommandLabel.Size = New System.Drawing.Size(19, 21)
        Me.CommandLabel.TabIndex = 14
        Me.CommandLabel.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(846, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 21)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "CheckMail:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(846, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 21)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Command:"
        '
        'CommandList
        '
        Me.CommandList.FormattingEnabled = True
        Me.CommandList.ItemHeight = 21
        Me.CommandList.Location = New System.Drawing.Point(554, 280)
        Me.CommandList.Name = "CommandList"
        Me.CommandList.Size = New System.Drawing.Size(175, 130)
        Me.CommandList.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(550, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 21)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Commands:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(550, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Funding Requests:"
        '
        'FundingList
        '
        Me.FundingList.FormattingEnabled = True
        Me.FundingList.ItemHeight = 21
        Me.FundingList.Location = New System.Drawing.Point(554, 81)
        Me.FundingList.Name = "FundingList"
        Me.FundingList.Size = New System.Drawing.Size(175, 172)
        Me.FundingList.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(550, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "What I think:"
        '
        'FromList
        '
        Me.FromList.FormattingEnabled = True
        Me.FromList.ItemHeight = 21
        Me.FromList.Location = New System.Drawing.Point(11, 81)
        Me.FromList.Name = "FromList"
        Me.FromList.Size = New System.Drawing.Size(276, 361)
        Me.FromList.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(12, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "From:"
        '
        'SubjectList
        '
        Me.SubjectList.FormattingEnabled = True
        Me.SubjectList.ItemHeight = 21
        Me.SubjectList.Location = New System.Drawing.Point(317, 81)
        Me.SubjectList.Name = "SubjectList"
        Me.SubjectList.Size = New System.Drawing.Size(211, 361)
        Me.SubjectList.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(317, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Subjects:"
        '
        'RefreshButton
        '
        Me.RefreshButton.BackColor = System.Drawing.Color.Transparent
        Me.RefreshButton.BaseColor = System.Drawing.Color.SteelBlue
        Me.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RefreshButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RefreshButton.Location = New System.Drawing.Point(182, 12)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Rounded = False
        Me.RefreshButton.Size = New System.Drawing.Size(77, 29)
        Me.RefreshButton.TabIndex = 2
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatToggle1
        '
        Me.FlatToggle1.BackColor = System.Drawing.Color.Transparent
        Me.FlatToggle1.Checked = False
        Me.FlatToggle1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatToggle1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatToggle1.Location = New System.Drawing.Point(100, 9)
        Me.FlatToggle1.Name = "FlatToggle1"
        Me.FlatToggle1.Options = ProductionLog.FlatToggle._Options.Style3
        Me.FlatToggle1.Size = New System.Drawing.Size(76, 33)
        Me.FlatToggle1.TabIndex = 1
        Me.FlatToggle1.Text = "FlatToggle1"
        '
        'MCountLabel
        '
        Me.MCountLabel.AutoSize = True
        Me.MCountLabel.BackColor = System.Drawing.Color.Transparent
        Me.MCountLabel.ForeColor = System.Drawing.Color.White
        Me.MCountLabel.Location = New System.Drawing.Point(265, 12)
        Me.MCountLabel.Name = "MCountLabel"
        Me.MCountLabel.Size = New System.Drawing.Size(0, 21)
        Me.MCountLabel.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(753, 256)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 21)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Reply:"
        '
        'ReplyList
        '
        Me.ReplyList.FormattingEnabled = True
        Me.ReplyList.ItemHeight = 21
        Me.ReplyList.Location = New System.Drawing.Point(757, 280)
        Me.ReplyList.Name = "ReplyList"
        Me.ReplyList.Size = New System.Drawing.Size(174, 130)
        Me.ReplyList.TabIndex = 19
        '
        'OttoMail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 454)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OttoMail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OttoMail"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As ProductionLog.FormSkin
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MCountLabel As System.Windows.Forms.Label
    Friend WithEvents FlatToggle1 As ProductionLog.FlatToggle
    Friend WithEvents RefreshButton As ProductionLog.FlatButton
    Friend WithEvents FromList As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SubjectList As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FundingList As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CommandList As System.Windows.Forms.ListBox
    Friend WithEvents CommandTimer As System.Windows.Forms.Timer
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CheckLabel As System.Windows.Forms.Label
    Friend WithEvents CommandLabel As System.Windows.Forms.Label
    Friend WithEvents BBSentList As System.Windows.Forms.ListBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BBTimer As System.Windows.Forms.Timer
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ReplyList As System.Windows.Forms.ListBox
End Class
