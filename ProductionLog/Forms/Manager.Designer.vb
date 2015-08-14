<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Manager))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Clients")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Funding Requested")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Borrowing Base")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("DO NOT FUND")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Contracts")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Contract Exceptions")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Contract Modifications")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Contract Titles")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Floor Titles")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Auction Slips")
        Me.ManagementTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuccessTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1 = New ProductionLog.FormSkin()
        Me.NewsLabel = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.WorkTree = New System.Windows.Forms.TreeView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ScheduleTreeview = New System.Windows.Forms.TreeView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CollateralTreeView = New System.Windows.Forms.TreeView()
        Me.CollatDayLabel = New System.Windows.Forms.Label()
        Me.XButton = New ProductionLog.FlatButton()
        Me.FormSkin1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ManagementTimer
        '
        Me.ManagementTimer.Interval = 5000
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.Black
        Me.FormSkin1.BorderColor = System.Drawing.Color.Black
        Me.FormSkin1.Controls.Add(Me.NewsLabel)
        Me.FormSkin1.Controls.Add(Me.PictureBox3)
        Me.FormSkin1.Controls.Add(Me.PictureBox2)
        Me.FormSkin1.Controls.Add(Me.WorkTree)
        Me.FormSkin1.Controls.Add(Me.Label1)
        Me.FormSkin1.Controls.Add(Me.ScheduleTreeview)
        Me.FormSkin1.Controls.Add(Me.Label2)
        Me.FormSkin1.Controls.Add(Me.CollateralTreeView)
        Me.FormSkin1.Controls.Add(Me.CollatDayLabel)
        Me.FormSkin1.Controls.Add(Me.XButton)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.Red
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormSkin1.HeaderColor = System.Drawing.Color.Black
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(1600, 900)
        Me.FormSkin1.TabIndex = 0
        '
        'NewsLabel
        '
        Me.NewsLabel.AutoSize = True
        Me.NewsLabel.BackColor = System.Drawing.Color.Transparent
        Me.NewsLabel.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewsLabel.ForeColor = System.Drawing.Color.Transparent
        Me.NewsLabel.Location = New System.Drawing.Point(637, 865)
        Me.NewsLabel.Name = "NewsLabel"
        Me.NewsLabel.Size = New System.Drawing.Size(380, 32)
        Me.NewsLabel.TabIndex = 45
        Me.NewsLabel.Text = "Possible News Text in this ZONE"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Black
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox3.TabIndex = 44
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(670, 689)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(564, 109)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 43
        Me.PictureBox2.TabStop = False
        '
        'WorkTree
        '
        Me.WorkTree.BackColor = System.Drawing.Color.LightGray
        Me.WorkTree.ForeColor = System.Drawing.Color.Black
        Me.WorkTree.Location = New System.Drawing.Point(948, 41)
        Me.WorkTree.Name = "WorkTree"
        TreeNode1.Name = "ClientNode"
        TreeNode1.Text = "Clients"
        Me.WorkTree.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.WorkTree.Size = New System.Drawing.Size(286, 619)
        Me.WorkTree.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(944, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 21)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Accounts Being Serviced:"
        '
        'ScheduleTreeview
        '
        Me.ScheduleTreeview.BackColor = System.Drawing.Color.LightGray
        Me.ScheduleTreeview.ForeColor = System.Drawing.Color.Black
        Me.ScheduleTreeview.Location = New System.Drawing.Point(656, 41)
        Me.ScheduleTreeview.Name = "ScheduleTreeview"
        TreeNode2.Name = "FundingRequestNode"
        TreeNode2.Text = "Funding Requested"
        TreeNode3.Name = "BorrowingBaseNode"
        TreeNode3.Text = "Borrowing Base"
        TreeNode4.Name = "FrozenNode"
        TreeNode4.Text = "DO NOT FUND"
        Me.ScheduleTreeview.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode3, TreeNode4})
        Me.ScheduleTreeview.Size = New System.Drawing.Size(286, 619)
        Me.ScheduleTreeview.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(652, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 21)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Schedule:"
        '
        'CollateralTreeView
        '
        Me.CollateralTreeView.BackColor = System.Drawing.Color.LightGray
        Me.CollateralTreeView.ForeColor = System.Drawing.Color.Black
        Me.CollateralTreeView.Location = New System.Drawing.Point(372, 41)
        Me.CollateralTreeView.Name = "CollateralTreeView"
        TreeNode5.Name = "ContractNode"
        TreeNode5.Text = "Contracts"
        TreeNode6.Name = "ContractExNode"
        TreeNode6.Text = "Contract Exceptions"
        TreeNode7.Name = "ContractModNode"
        TreeNode7.Text = "Contract Modifications"
        TreeNode8.Name = "ContractTitleNode"
        TreeNode8.Text = "Contract Titles"
        TreeNode9.Name = "FloorTitleNode"
        TreeNode9.Text = "Floor Titles"
        TreeNode10.Name = "AuctionSlipNode"
        TreeNode10.Text = "Auction Slips"
        Me.CollateralTreeView.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9, TreeNode10})
        Me.CollateralTreeView.Size = New System.Drawing.Size(278, 806)
        Me.CollateralTreeView.TabIndex = 38
        '
        'CollatDayLabel
        '
        Me.CollatDayLabel.AutoSize = True
        Me.CollatDayLabel.BackColor = System.Drawing.Color.Transparent
        Me.CollatDayLabel.ForeColor = System.Drawing.Color.White
        Me.CollatDayLabel.Location = New System.Drawing.Point(368, 17)
        Me.CollatDayLabel.Name = "CollatDayLabel"
        Me.CollatDayLabel.Size = New System.Drawing.Size(211, 21)
        Me.CollatDayLabel.TabIndex = 37
        Me.CollatDayLabel.Text = "Collateral Received Today:"
        '
        'XButton
        '
        Me.XButton.BackColor = System.Drawing.Color.Transparent
        Me.XButton.BaseColor = System.Drawing.Color.Black
        Me.XButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.XButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.XButton.Location = New System.Drawing.Point(1577, 0)
        Me.XButton.Name = "XButton"
        Me.XButton.Rounded = False
        Me.XButton.Size = New System.Drawing.Size(23, 17)
        Me.XButton.TabIndex = 36
        Me.XButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1600, 900)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Manager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manager"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As ProductionLog.FormSkin
    Friend WithEvents ManagementTimer As System.Windows.Forms.Timer
    Friend WithEvents SuccessTimer As System.Windows.Forms.Timer
    Friend WithEvents XButton As ProductionLog.FlatButton
    Friend WithEvents ScheduleTreeview As System.Windows.Forms.TreeView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CollateralTreeView As System.Windows.Forms.TreeView
    Friend WithEvents CollatDayLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents WorkTree As System.Windows.Forms.TreeView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents NewsLabel As System.Windows.Forms.Label
End Class
