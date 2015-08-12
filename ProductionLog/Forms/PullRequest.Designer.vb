<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PullRequest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PullRequest))
        Me.FormSkin1 = New ProductionLog.FormSkin()
        Me.IDLabel = New System.Windows.Forms.Label()
        Me.SuccessLabel = New System.Windows.Forms.Label()
        Me.DateReturnPick = New System.Windows.Forms.DateTimePicker()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.FlatButton3 = New ProductionLog.FlatButton()
        Me.FlatButton2 = New ProductionLog.FlatButton()
        Me.EditList = New System.Windows.Forms.ListBox()
        Me.FlatButton1 = New ProductionLog.FlatButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Vin6Box = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorLabel = New System.Windows.Forms.Label()
        Me.PullDGV = New System.Windows.Forms.DataGridView()
        Me.SuccessTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1.SuspendLayout()
        CType(Me.PullDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.Gray
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.IDLabel)
        Me.FormSkin1.Controls.Add(Me.SuccessLabel)
        Me.FormSkin1.Controls.Add(Me.DateReturnPick)
        Me.FormSkin1.Controls.Add(Me.CheckBox1)
        Me.FormSkin1.Controls.Add(Me.FlatButton3)
        Me.FormSkin1.Controls.Add(Me.FlatButton2)
        Me.FormSkin1.Controls.Add(Me.EditList)
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Controls.Add(Me.Label2)
        Me.FormSkin1.Controls.Add(Me.Vin6Box)
        Me.FormSkin1.Controls.Add(Me.Label1)
        Me.FormSkin1.Controls.Add(Me.ErrorLabel)
        Me.FormSkin1.Controls.Add(Me.PullDGV)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.SteelBlue
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(861, 420)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Pull Requests"
        '
        'IDLabel
        '
        Me.IDLabel.AutoSize = True
        Me.IDLabel.BackColor = System.Drawing.Color.Transparent
        Me.IDLabel.ForeColor = System.Drawing.Color.White
        Me.IDLabel.Location = New System.Drawing.Point(839, 24)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(19, 21)
        Me.IDLabel.TabIndex = 12
        Me.IDLabel.Text = "0"
        '
        'SuccessLabel
        '
        Me.SuccessLabel.AutoSize = True
        Me.SuccessLabel.BackColor = System.Drawing.Color.LimeGreen
        Me.SuccessLabel.Location = New System.Drawing.Point(697, 394)
        Me.SuccessLabel.Name = "SuccessLabel"
        Me.SuccessLabel.Size = New System.Drawing.Size(69, 21)
        Me.SuccessLabel.TabIndex = 11
        Me.SuccessLabel.Text = "Success!"
        Me.SuccessLabel.Visible = False
        '
        'DateReturnPick
        '
        Me.DateReturnPick.CustomFormat = "yyyy-MM-dd"
        Me.DateReturnPick.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateReturnPick.Location = New System.Drawing.Point(742, 355)
        Me.DateReturnPick.Name = "DateReturnPick"
        Me.DateReturnPick.Size = New System.Drawing.Size(112, 29)
        Me.DateReturnPick.TabIndex = 10
        Me.DateReturnPick.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CheckBox1.Location = New System.Drawing.Point(701, 326)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(153, 23)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Change Return Date"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'FlatButton3
        '
        Me.FlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton3.BaseColor = System.Drawing.Color.SteelBlue
        Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton3.Location = New System.Drawing.Point(774, 394)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Rounded = False
        Me.FlatButton3.Size = New System.Drawing.Size(84, 23)
        Me.FlatButton3.TabIndex = 8
        Me.FlatButton3.Text = "Save"
        Me.FlatButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.DarkRed
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(770, 239)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(84, 23)
        Me.FlatButton2.TabIndex = 7
        Me.FlatButton2.Text = "Remove"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'EditList
        '
        Me.EditList.FormattingEnabled = True
        Me.EditList.ItemHeight = 21
        Me.EditList.Location = New System.Drawing.Point(770, 82)
        Me.EditList.Name = "EditList"
        Me.EditList.Size = New System.Drawing.Size(84, 151)
        Me.EditList.TabIndex = 6
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.Red
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(814, 0)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(47, 21)
        Me.FlatButton1.TabIndex = 5
        Me.FlatButton1.Text = "Done"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(773, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Changed"
        '
        'Vin6Box
        '
        Me.Vin6Box.Location = New System.Drawing.Point(754, 291)
        Me.Vin6Box.Name = "Vin6Box"
        Me.Vin6Box.Size = New System.Drawing.Size(100, 29)
        Me.Vin6Box.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(805, 267)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "VIN 6"
        '
        'ErrorLabel
        '
        Me.ErrorLabel.AutoSize = True
        Me.ErrorLabel.BackColor = System.Drawing.Color.Red
        Me.ErrorLabel.ForeColor = System.Drawing.Color.White
        Me.ErrorLabel.Location = New System.Drawing.Point(129, 16)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(45, 21)
        Me.ErrorLabel.TabIndex = 1
        Me.ErrorLabel.Text = "Error"
        Me.ErrorLabel.Visible = False
        '
        'PullDGV
        '
        Me.PullDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PullDGV.Location = New System.Drawing.Point(3, 56)
        Me.PullDGV.Name = "PullDGV"
        Me.PullDGV.RowHeadersVisible = False
        Me.PullDGV.Size = New System.Drawing.Size(665, 352)
        Me.PullDGV.TabIndex = 0
        '
        'SuccessTimer
        '
        '
        'PullRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 420)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PullRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PullRequest"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        CType(Me.PullDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PullDGV As System.Windows.Forms.DataGridView
    Friend WithEvents ErrorLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Vin6Box As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FlatButton1 As ProductionLog.FlatButton
    Friend WithEvents EditList As System.Windows.Forms.ListBox
    Friend WithEvents FlatButton2 As ProductionLog.FlatButton
    Friend WithEvents FlatButton3 As ProductionLog.FlatButton
    Friend WithEvents FormSkin1 As ProductionLog.FormSkin
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents DateReturnPick As System.Windows.Forms.DateTimePicker
    Friend WithEvents SuccessLabel As System.Windows.Forms.Label
    Friend WithEvents SuccessTimer As System.Windows.Forms.Timer
    Friend WithEvents IDLabel As System.Windows.Forms.Label
End Class
