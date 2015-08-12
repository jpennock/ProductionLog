<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TheCIFR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TheCIFR))
        Me.SuccessTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1 = New ProductionLog.FormSkin()
        Me.SuccessLabel = New System.Windows.Forms.Label()
        Me.DealerNameLabel = New System.Windows.Forms.Label()
        Me.FlatTabControl1 = New ProductionLog.FlatTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.FlatButton2 = New ProductionLog.FlatButton()
        Me.EditedList = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.JobIDLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.JobVinList = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ActvVINBox = New System.Windows.Forms.TextBox()
        Me.ActvStockBox = New System.Windows.Forms.TextBox()
        Me.ActvNameBox = New System.Windows.Forms.TextBox()
        Me.ActiveDGV = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.InactvVINBox = New System.Windows.Forms.TextBox()
        Me.InactvStockBox = New System.Windows.Forms.TextBox()
        Me.InactvNameBox = New System.Windows.Forms.TextBox()
        Me.InactiveDGV = New System.Windows.Forms.DataGridView()
        Me.DealerIDLabel = New System.Windows.Forms.Label()
        Me.FlatButton1 = New ProductionLog.FlatButton()
        Me.DoneButton = New ProductionLog.FlatButton()
        Me.EmpIDLabel = New System.Windows.Forms.Label()
        Me.FormSkin1.SuspendLayout()
        Me.FlatTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.ActiveDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.InactiveDGV, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.FormSkin1.Controls.Add(Me.SuccessLabel)
        Me.FormSkin1.Controls.Add(Me.DealerNameLabel)
        Me.FormSkin1.Controls.Add(Me.FlatTabControl1)
        Me.FormSkin1.Controls.Add(Me.DealerIDLabel)
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Controls.Add(Me.DoneButton)
        Me.FormSkin1.Controls.Add(Me.EmpIDLabel)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.SteelBlue
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(1032, 592)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "CIFR"
        '
        'SuccessLabel
        '
        Me.SuccessLabel.AutoSize = True
        Me.SuccessLabel.BackColor = System.Drawing.Color.Green
        Me.SuccessLabel.ForeColor = System.Drawing.Color.White
        Me.SuccessLabel.Location = New System.Drawing.Point(483, 4)
        Me.SuccessLabel.Name = "SuccessLabel"
        Me.SuccessLabel.Size = New System.Drawing.Size(64, 21)
        Me.SuccessLabel.TabIndex = 13
        Me.SuccessLabel.Text = "Success"
        Me.SuccessLabel.Visible = False
        '
        'DealerNameLabel
        '
        Me.DealerNameLabel.AutoSize = True
        Me.DealerNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.DealerNameLabel.ForeColor = System.Drawing.Color.White
        Me.DealerNameLabel.Location = New System.Drawing.Point(98, 15)
        Me.DealerNameLabel.Name = "DealerNameLabel"
        Me.DealerNameLabel.Size = New System.Drawing.Size(45, 21)
        Me.DealerNameLabel.TabIndex = 5
        Me.DealerNameLabel.Text = "Error"
        '
        'FlatTabControl1
        '
        Me.FlatTabControl1.ActiveColor = System.Drawing.Color.Gray
        Me.FlatTabControl1.Controls.Add(Me.TabPage1)
        Me.FlatTabControl1.Controls.Add(Me.TabPage2)
        Me.FlatTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatTabControl1.ItemSize = New System.Drawing.Size(120, 40)
        Me.FlatTabControl1.Location = New System.Drawing.Point(0, 50)
        Me.FlatTabControl1.Name = "FlatTabControl1"
        Me.FlatTabControl1.SelectedIndex = 0
        Me.FlatTabControl1.Size = New System.Drawing.Size(1032, 542)
        Me.FlatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.FlatButton2)
        Me.TabPage1.Controls.Add(Me.EditedList)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.JobIDLabel)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.JobVinList)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.ActvVINBox)
        Me.TabPage1.Controls.Add(Me.ActvStockBox)
        Me.TabPage1.Controls.Add(Me.ActvNameBox)
        Me.TabPage1.Controls.Add(Me.ActiveDGV)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1024, 494)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Active"
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.DarkRed
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(870, 251)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(78, 22)
        Me.FlatButton2.TabIndex = 16
        Me.FlatButton2.Text = "Remove"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'EditedList
        '
        Me.EditedList.FormattingEnabled = True
        Me.EditedList.ItemHeight = 17
        Me.EditedList.Location = New System.Drawing.Point(871, 155)
        Me.EditedList.Name = "EditedList"
        Me.EditedList.Size = New System.Drawing.Size(125, 89)
        Me.EditedList.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(868, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 19)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Edited Items"
        '
        'JobIDLabel
        '
        Me.JobIDLabel.AutoSize = True
        Me.JobIDLabel.ForeColor = System.Drawing.Color.White
        Me.JobIDLabel.Location = New System.Drawing.Point(869, 117)
        Me.JobIDLabel.Name = "JobIDLabel"
        Me.JobIDLabel.Size = New System.Drawing.Size(17, 19)
        Me.JobIDLabel.TabIndex = 6
        Me.JobIDLabel.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(867, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 19)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "VINs in Job:"
        '
        'JobVinList
        '
        Me.JobVinList.FormattingEnabled = True
        Me.JobVinList.ItemHeight = 17
        Me.JobVinList.Location = New System.Drawing.Point(872, 25)
        Me.JobVinList.Name = "JobVinList"
        Me.JobVinList.Size = New System.Drawing.Size(125, 89)
        Me.JobVinList.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(866, 432)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Search By VIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(866, 382)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Search By Stock"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(866, 332)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Search By Name"
        '
        'ActvVINBox
        '
        Me.ActvVINBox.Location = New System.Drawing.Point(871, 454)
        Me.ActvVINBox.Name = "ActvVINBox"
        Me.ActvVINBox.Size = New System.Drawing.Size(126, 25)
        Me.ActvVINBox.TabIndex = 6
        '
        'ActvStockBox
        '
        Me.ActvStockBox.Location = New System.Drawing.Point(870, 404)
        Me.ActvStockBox.Name = "ActvStockBox"
        Me.ActvStockBox.Size = New System.Drawing.Size(126, 25)
        Me.ActvStockBox.TabIndex = 4
        '
        'ActvNameBox
        '
        Me.ActvNameBox.Location = New System.Drawing.Point(870, 354)
        Me.ActvNameBox.Name = "ActvNameBox"
        Me.ActvNameBox.Size = New System.Drawing.Size(127, 25)
        Me.ActvNameBox.TabIndex = 1
        '
        'ActiveDGV
        '
        Me.ActiveDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ActiveDGV.Location = New System.Drawing.Point(0, 0)
        Me.ActiveDGV.Name = "ActiveDGV"
        Me.ActiveDGV.RowHeadersVisible = False
        Me.ActiveDGV.Size = New System.Drawing.Size(832, 494)
        Me.ActiveDGV.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.InactvVINBox)
        Me.TabPage2.Controls.Add(Me.InactvStockBox)
        Me.TabPage2.Controls.Add(Me.InactvNameBox)
        Me.TabPage2.Controls.Add(Me.InactiveDGV)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1024, 494)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Inactive"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(866, 432)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 19)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Search By VIN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(866, 382)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Search By Stock"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(866, 332)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 19)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Search By Name"
        '
        'InactvVINBox
        '
        Me.InactvVINBox.Location = New System.Drawing.Point(871, 454)
        Me.InactvVINBox.Name = "InactvVINBox"
        Me.InactvVINBox.Size = New System.Drawing.Size(126, 25)
        Me.InactvVINBox.TabIndex = 12
        '
        'InactvStockBox
        '
        Me.InactvStockBox.Enabled = False
        Me.InactvStockBox.Location = New System.Drawing.Point(870, 404)
        Me.InactvStockBox.Name = "InactvStockBox"
        Me.InactvStockBox.Size = New System.Drawing.Size(126, 25)
        Me.InactvStockBox.TabIndex = 10
        '
        'InactvNameBox
        '
        Me.InactvNameBox.Enabled = False
        Me.InactvNameBox.Location = New System.Drawing.Point(870, 354)
        Me.InactvNameBox.Name = "InactvNameBox"
        Me.InactvNameBox.Size = New System.Drawing.Size(127, 25)
        Me.InactvNameBox.TabIndex = 7
        '
        'InactiveDGV
        '
        Me.InactiveDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InactiveDGV.Location = New System.Drawing.Point(0, 0)
        Me.InactiveDGV.Name = "InactiveDGV"
        Me.InactiveDGV.RowHeadersVisible = False
        Me.InactiveDGV.Size = New System.Drawing.Size(832, 494)
        Me.InactiveDGV.TabIndex = 1
        '
        'DealerIDLabel
        '
        Me.DealerIDLabel.AutoSize = True
        Me.DealerIDLabel.BackColor = System.Drawing.Color.Transparent
        Me.DealerIDLabel.ForeColor = System.Drawing.Color.White
        Me.DealerIDLabel.Location = New System.Drawing.Point(64, 15)
        Me.DealerIDLabel.Name = "DealerIDLabel"
        Me.DealerIDLabel.Size = New System.Drawing.Size(19, 21)
        Me.DealerIDLabel.TabIndex = 3
        Me.DealerIDLabel.Text = "0"
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.DarkGreen
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(877, 0)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(75, 25)
        Me.FlatButton1.TabIndex = 12
        Me.FlatButton1.Text = "Save"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'DoneButton
        '
        Me.DoneButton.BackColor = System.Drawing.Color.Transparent
        Me.DoneButton.BaseColor = System.Drawing.Color.Maroon
        Me.DoneButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DoneButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.DoneButton.Location = New System.Drawing.Point(980, 0)
        Me.DoneButton.Name = "DoneButton"
        Me.DoneButton.Rounded = False
        Me.DoneButton.Size = New System.Drawing.Size(52, 22)
        Me.DoneButton.TabIndex = 1
        Me.DoneButton.Text = "Done"
        Me.DoneButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'EmpIDLabel
        '
        Me.EmpIDLabel.AutoSize = True
        Me.EmpIDLabel.BackColor = System.Drawing.Color.Transparent
        Me.EmpIDLabel.ForeColor = System.Drawing.Color.White
        Me.EmpIDLabel.Location = New System.Drawing.Point(983, 26)
        Me.EmpIDLabel.Name = "EmpIDLabel"
        Me.EmpIDLabel.Size = New System.Drawing.Size(19, 21)
        Me.EmpIDLabel.TabIndex = 0
        Me.EmpIDLabel.Text = "0"
        '
        'TheCIFR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 592)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TheCIFR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TheCIFR"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.FlatTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.ActiveDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.InactiveDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As ProductionLog.FormSkin
    Friend WithEvents EmpIDLabel As System.Windows.Forms.Label
    Friend WithEvents DoneButton As ProductionLog.FlatButton
    Friend WithEvents DealerIDLabel As System.Windows.Forms.Label
    Friend WithEvents FlatTabControl1 As ProductionLog.FlatTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ActiveDGV As System.Windows.Forms.DataGridView
    Friend WithEvents InactiveDGV As System.Windows.Forms.DataGridView
    Friend WithEvents ActvNameBox As System.Windows.Forms.TextBox
    Friend WithEvents ActvVINBox As System.Windows.Forms.TextBox
    Friend WithEvents ActvStockBox As System.Windows.Forms.TextBox
    Friend WithEvents InactvVINBox As System.Windows.Forms.TextBox
    Friend WithEvents InactvStockBox As System.Windows.Forms.TextBox
    Friend WithEvents InactvNameBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DealerNameLabel As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents JobVinList As System.Windows.Forms.ListBox
    Friend WithEvents JobIDLabel As System.Windows.Forms.Label
    Friend WithEvents FlatButton1 As ProductionLog.FlatButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents FlatButton2 As ProductionLog.FlatButton
    Friend WithEvents EditedList As System.Windows.Forms.ListBox
    Friend WithEvents SuccessLabel As System.Windows.Forms.Label
    Friend WithEvents SuccessTimer As System.Windows.Forms.Timer
End Class
