<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Whiteboard
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Funding Requested")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Borrowing Base")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Contracts")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Contract Exceptions")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Contract Modifications")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Contract Titles")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Floor Titles")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Auction Slips")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Whiteboard))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1 = New ProductionLog.FormSkin()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.UpdateTrackBar = New System.Windows.Forms.TrackBar()
        Me.MinDateLabel = New System.Windows.Forms.Label()
        Me.FlatMini1 = New ProductionLog.FlatMini()
        Me.Updatinglabel = New System.Windows.Forms.Label()
        Me.RefreshButton = New ProductionLog.FlatButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.JobsTreeView = New System.Windows.Forms.TreeView()
        Me.FlatButton1 = New ProductionLog.FlatButton()
        Me.ScheduleTreeview = New System.Windows.Forms.TreeView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CollateralTreeView = New System.Windows.Forms.TreeView()
        Me.CollatDayLabel = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReAssignToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormSkin1.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UpdateTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 30000
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.Gray
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.Label4)
        Me.FormSkin1.Controls.Add(Me.Label1)
        Me.FormSkin1.Controls.Add(Me.TrackBar1)
        Me.FormSkin1.Controls.Add(Me.UpdateTrackBar)
        Me.FormSkin1.Controls.Add(Me.MinDateLabel)
        Me.FormSkin1.Controls.Add(Me.FlatMini1)
        Me.FormSkin1.Controls.Add(Me.Updatinglabel)
        Me.FormSkin1.Controls.Add(Me.RefreshButton)
        Me.FormSkin1.Controls.Add(Me.Label3)
        Me.FormSkin1.Controls.Add(Me.JobsTreeView)
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Controls.Add(Me.ScheduleTreeview)
        Me.FormSkin1.Controls.Add(Me.Label2)
        Me.FormSkin1.Controls.Add(Me.CollateralTreeView)
        Me.FormSkin1.Controls.Add(Me.CollatDayLabel)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.SteelBlue
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(1136, 845)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "The Board"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(404, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Seconds"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Label1.Location = New System.Drawing.Point(221, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Days"
        '
        'TrackBar1
        '
        Me.TrackBar1.BackColor = System.Drawing.Color.Gray
        Me.TrackBar1.LargeChange = 2
        Me.TrackBar1.Location = New System.Drawing.Point(191, 50)
        Me.TrackBar1.Maximum = 7
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(94, 45)
        Me.TrackBar1.TabIndex = 12
        Me.TrackBar1.Value = 1
        '
        'UpdateTrackBar
        '
        Me.UpdateTrackBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.UpdateTrackBar.Location = New System.Drawing.Point(379, 6)
        Me.UpdateTrackBar.Maximum = 12
        Me.UpdateTrackBar.Minimum = 1
        Me.UpdateTrackBar.Name = "UpdateTrackBar"
        Me.UpdateTrackBar.Size = New System.Drawing.Size(104, 45)
        Me.UpdateTrackBar.TabIndex = 11
        Me.UpdateTrackBar.Value = 3
        '
        'MinDateLabel
        '
        Me.MinDateLabel.AutoSize = True
        Me.MinDateLabel.BackColor = System.Drawing.Color.Transparent
        Me.MinDateLabel.Location = New System.Drawing.Point(461, 69)
        Me.MinDateLabel.Name = "MinDateLabel"
        Me.MinDateLabel.Size = New System.Drawing.Size(98, 21)
        Me.MinDateLabel.TabIndex = 10
        Me.MinDateLabel.Text = "Oldest Date: "
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(1089, 6)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 9
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Updatinglabel
        '
        Me.Updatinglabel.AutoSize = True
        Me.Updatinglabel.BackColor = System.Drawing.Color.Transparent
        Me.Updatinglabel.ForeColor = System.Drawing.Color.White
        Me.Updatinglabel.Location = New System.Drawing.Point(112, 15)
        Me.Updatinglabel.Name = "Updatinglabel"
        Me.Updatinglabel.Size = New System.Drawing.Size(212, 21)
        Me.Updatinglabel.TabIndex = 8
        Me.Updatinglabel.Text = "Refreshing every 30 seconds."
        '
        'RefreshButton
        '
        Me.RefreshButton.BackColor = System.Drawing.Color.Transparent
        Me.RefreshButton.BaseColor = System.Drawing.Color.SteelBlue
        Me.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RefreshButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RefreshButton.Location = New System.Drawing.Point(996, 579)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Rounded = False
        Me.RefreshButton.Size = New System.Drawing.Size(106, 32)
        Me.RefreshButton.TabIndex = 7
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(334, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Jobs Outstanding"
        '
        'JobsTreeView
        '
        Me.JobsTreeView.Location = New System.Drawing.Point(338, 92)
        Me.JobsTreeView.Name = "JobsTreeView"
        Me.JobsTreeView.Size = New System.Drawing.Size(465, 748)
        Me.JobsTreeView.TabIndex = 5
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.Red
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(1113, 0)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(23, 24)
        Me.FlatButton1.TabIndex = 4
        Me.FlatButton1.Text = "X"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ScheduleTreeview
        '
        Me.ScheduleTreeview.Location = New System.Drawing.Point(809, 92)
        Me.ScheduleTreeview.Name = "ScheduleTreeview"
        TreeNode1.Name = "FundingRequestNode"
        TreeNode1.Text = "Funding Requested"
        TreeNode2.Name = "BorrowingBaseNode"
        TreeNode2.Text = "Borrowing Base"
        Me.ScheduleTreeview.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Me.ScheduleTreeview.Size = New System.Drawing.Size(293, 481)
        Me.ScheduleTreeview.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(805, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Schedule:"
        '
        'CollateralTreeView
        '
        Me.CollateralTreeView.Location = New System.Drawing.Point(25, 95)
        Me.CollateralTreeView.Name = "CollateralTreeView"
        TreeNode3.Name = "ContractNode"
        TreeNode3.Text = "Contracts"
        TreeNode4.Name = "ContractExNode"
        TreeNode4.Text = "Contract Exceptions"
        TreeNode5.Name = "ContractModNode"
        TreeNode5.Text = "Contract Modifications"
        TreeNode6.Name = "ContractTitleNode"
        TreeNode6.Text = "Contract Titles"
        TreeNode7.Name = "FloorTitleNode"
        TreeNode7.Text = "Floor Titles"
        TreeNode8.Name = "AuctionSlipNode"
        TreeNode8.Text = "Auction Slips"
        Me.CollateralTreeView.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7, TreeNode8})
        Me.CollateralTreeView.Size = New System.Drawing.Size(278, 745)
        Me.CollateralTreeView.TabIndex = 1
        '
        'CollatDayLabel
        '
        Me.CollatDayLabel.AutoSize = True
        Me.CollatDayLabel.BackColor = System.Drawing.Color.Transparent
        Me.CollatDayLabel.Location = New System.Drawing.Point(21, 71)
        Me.CollatDayLabel.Name = "CollatDayLabel"
        Me.CollatDayLabel.Size = New System.Drawing.Size(125, 21)
        Me.CollatDayLabel.TabIndex = 0
        Me.CollatDayLabel.Text = "Collateral Today:"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReAssignToolStripMenuItem, Me.CopyToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 70)
        '
        'ReAssignToolStripMenuItem
        '
        Me.ReAssignToolStripMenuItem.Name = "ReAssignToolStripMenuItem"
        Me.ReAssignToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReAssignToolStripMenuItem.Text = "Re-Assign"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'Whiteboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1136, 845)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Whiteboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Whiteboard"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UpdateTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As ProductionLog.FormSkin
    Friend WithEvents CollateralTreeView As System.Windows.Forms.TreeView
    Friend WithEvents CollatDayLabel As System.Windows.Forms.Label
    Friend WithEvents ScheduleTreeview As System.Windows.Forms.TreeView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FlatButton1 As ProductionLog.FlatButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents JobsTreeView As System.Windows.Forms.TreeView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RefreshButton As ProductionLog.FlatButton
    Friend WithEvents Updatinglabel As System.Windows.Forms.Label
    Friend WithEvents FlatMini1 As ProductionLog.FlatMini
    Friend WithEvents MinDateLabel As System.Windows.Forms.Label
    Friend WithEvents UpdateTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ReAssignToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
