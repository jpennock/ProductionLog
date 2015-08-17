<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DBA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DBA))
        Me.SuccessTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1 = New ProductionLog.FormSkin()
        Me.BatchIDLabel = New System.Windows.Forms.Label()
        Me.Count = New System.Windows.Forms.Label()
        Me.CountBox = New System.Windows.Forms.TextBox()
        Me.BatchIDNameLabel = New System.Windows.Forms.Label()
        Me.FlatButton2 = New ProductionLog.FlatButton()
        Me.SuccessLabel = New System.Windows.Forms.Label()
        Me.AddButton = New ProductionLog.FlatButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CollateralComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DealershipComboBox = New System.Windows.Forms.ComboBox()
        Me.CollateralList = New System.Windows.Forms.ListBox()
        Me.VinTextBox = New System.Windows.Forms.TextBox()
        Me.FullVinComboBox = New System.Windows.Forms.ComboBox()
        Me.FlatButton1 = New ProductionLog.FlatButton()
        Me.FormSkin1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SuccessTimer
        '
        Me.SuccessTimer.Interval = 1000
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.Gray
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.BatchIDLabel)
        Me.FormSkin1.Controls.Add(Me.Count)
        Me.FormSkin1.Controls.Add(Me.CountBox)
        Me.FormSkin1.Controls.Add(Me.BatchIDNameLabel)
        Me.FormSkin1.Controls.Add(Me.FlatButton2)
        Me.FormSkin1.Controls.Add(Me.SuccessLabel)
        Me.FormSkin1.Controls.Add(Me.AddButton)
        Me.FormSkin1.Controls.Add(Me.Label3)
        Me.FormSkin1.Controls.Add(Me.Label2)
        Me.FormSkin1.Controls.Add(Me.CollateralComboBox)
        Me.FormSkin1.Controls.Add(Me.Label1)
        Me.FormSkin1.Controls.Add(Me.DealershipComboBox)
        Me.FormSkin1.Controls.Add(Me.CollateralList)
        Me.FormSkin1.Controls.Add(Me.VinTextBox)
        Me.FormSkin1.Controls.Add(Me.FullVinComboBox)
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.SteelBlue
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(444, 341)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Collateral Reception"
        '
        'BatchIDLabel
        '
        Me.BatchIDLabel.AutoSize = True
        Me.BatchIDLabel.BackColor = System.Drawing.Color.Transparent
        Me.BatchIDLabel.Location = New System.Drawing.Point(13, 250)
        Me.BatchIDLabel.Name = "BatchIDLabel"
        Me.BatchIDLabel.Size = New System.Drawing.Size(0, 21)
        Me.BatchIDLabel.TabIndex = 19
        '
        'Count
        '
        Me.Count.AutoSize = True
        Me.Count.BackColor = System.Drawing.Color.Transparent
        Me.Count.Location = New System.Drawing.Point(13, 276)
        Me.Count.Name = "Count"
        Me.Count.Size = New System.Drawing.Size(52, 21)
        Me.Count.TabIndex = 18
        Me.Count.Text = "Count"
        '
        'CountBox
        '
        Me.CountBox.Location = New System.Drawing.Point(16, 303)
        Me.CountBox.Name = "CountBox"
        Me.CountBox.Size = New System.Drawing.Size(46, 29)
        Me.CountBox.TabIndex = 17
        '
        'BatchIDNameLabel
        '
        Me.BatchIDNameLabel.AutoSize = True
        Me.BatchIDNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.BatchIDNameLabel.Location = New System.Drawing.Point(12, 221)
        Me.BatchIDNameLabel.Name = "BatchIDNameLabel"
        Me.BatchIDNameLabel.Size = New System.Drawing.Size(63, 21)
        Me.BatchIDNameLabel.TabIndex = 16
        Me.BatchIDNameLabel.Text = "BatchID"
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.DarkRed
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(130, 266)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(68, 31)
        Me.FlatButton2.TabIndex = 15
        Me.FlatButton2.Text = "Remove"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'SuccessLabel
        '
        Me.SuccessLabel.AutoSize = True
        Me.SuccessLabel.BackColor = System.Drawing.Color.LightGreen
        Me.SuccessLabel.Location = New System.Drawing.Point(237, 9)
        Me.SuccessLabel.Name = "SuccessLabel"
        Me.SuccessLabel.Size = New System.Drawing.Size(69, 21)
        Me.SuccessLabel.TabIndex = 14
        Me.SuccessLabel.Text = "Success!"
        Me.SuccessLabel.Visible = False
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.Transparent
        Me.AddButton.BaseColor = System.Drawing.Color.SteelBlue
        Me.AddButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AddButton.Location = New System.Drawing.Point(131, 300)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Rounded = False
        Me.AddButton.Size = New System.Drawing.Size(67, 32)
        Me.AddButton.TabIndex = 13
        Me.AddButton.Text = "Add List"
        Me.AddButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "VIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(12, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Collateral"
        '
        'CollateralComboBox
        '
        Me.CollateralComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CollateralComboBox.FormattingEnabled = True
        Me.CollateralComboBox.Location = New System.Drawing.Point(12, 132)
        Me.CollateralComboBox.Name = "CollateralComboBox"
        Me.CollateralComboBox.Size = New System.Drawing.Size(171, 29)
        Me.CollateralComboBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Dealership"
        '
        'DealershipComboBox
        '
        Me.DealershipComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DealershipComboBox.FormattingEnabled = True
        Me.DealershipComboBox.Location = New System.Drawing.Point(12, 73)
        Me.DealershipComboBox.Name = "DealershipComboBox"
        Me.DealershipComboBox.Size = New System.Drawing.Size(171, 29)
        Me.DealershipComboBox.TabIndex = 4
        '
        'CollateralList
        '
        Me.CollateralList.FormattingEnabled = True
        Me.CollateralList.ItemHeight = 21
        Me.CollateralList.Location = New System.Drawing.Point(204, 221)
        Me.CollateralList.Name = "CollateralList"
        Me.CollateralList.Size = New System.Drawing.Size(235, 109)
        Me.CollateralList.TabIndex = 3
        '
        'VinTextBox
        '
        Me.VinTextBox.Location = New System.Drawing.Point(12, 188)
        Me.VinTextBox.Name = "VinTextBox"
        Me.VinTextBox.Size = New System.Drawing.Size(171, 29)
        Me.VinTextBox.TabIndex = 2
        '
        'FullVinComboBox
        '
        Me.FullVinComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.FullVinComboBox.FormattingEnabled = True
        Me.FullVinComboBox.Location = New System.Drawing.Point(204, 71)
        Me.FullVinComboBox.Name = "FullVinComboBox"
        Me.FullVinComboBox.Size = New System.Drawing.Size(235, 147)
        Me.FullVinComboBox.TabIndex = 1
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.DarkRed
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(385, 0)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(59, 27)
        Me.FlatButton1.TabIndex = 0
        Me.FlatButton1.Text = "Done"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'DBA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 341)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DBA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Collateral Reception"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As ProductionLog.FormSkin
    Friend WithEvents FlatButton1 As ProductionLog.FlatButton
    Friend WithEvents FullVinComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CollateralList As System.Windows.Forms.ListBox
    Friend WithEvents VinTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DealershipComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CollateralComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FlatButton2 As ProductionLog.FlatButton
    Friend WithEvents SuccessLabel As System.Windows.Forms.Label
    Friend WithEvents AddButton As ProductionLog.FlatButton
    Friend WithEvents SuccessTimer As System.Windows.Forms.Timer
    Friend WithEvents BatchIDNameLabel As System.Windows.Forms.Label
    Friend WithEvents Count As System.Windows.Forms.Label
    Friend WithEvents CountBox As System.Windows.Forms.TextBox
    Friend WithEvents BatchIDLabel As System.Windows.Forms.Label
End Class
