<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CollateralLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CollateralLog))
        Me.SuccessTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1 = New ProductionLog.FormSkin()
        Me.ManualToggleCheckBox = New System.Windows.Forms.CheckBox()
        Me.ReceivedDateCheckBox = New System.Windows.Forms.CheckBox()
        Me.ReceivedDateTime = New System.Windows.Forms.DateTimePicker()
        Me.FlatButton2 = New ProductionLog.FlatButton()
        Me.MyCountBox = New System.Windows.Forms.TextBox()
        Me.ListCountBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TutorialPicture = New System.Windows.Forms.PictureBox()
        Me.FlatButton1 = New ProductionLog.FlatButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CollateralBox = New System.Windows.Forms.TextBox()
        Me.CollateralList = New System.Windows.Forms.ListBox()
        Me.SuccessLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CollateralComboBox = New System.Windows.Forms.ComboBox()
        Me.BatchLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DealershipComboBox = New System.Windows.Forms.ComboBox()
        Me.AddButton = New ProductionLog.FlatButton()
        Me.DoneButton = New ProductionLog.FlatButton()
        Me.FormSkin1.SuspendLayout()
        CType(Me.TutorialPicture, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.FormSkin1.Controls.Add(Me.ManualToggleCheckBox)
        Me.FormSkin1.Controls.Add(Me.ReceivedDateCheckBox)
        Me.FormSkin1.Controls.Add(Me.ReceivedDateTime)
        Me.FormSkin1.Controls.Add(Me.FlatButton2)
        Me.FormSkin1.Controls.Add(Me.MyCountBox)
        Me.FormSkin1.Controls.Add(Me.ListCountBox)
        Me.FormSkin1.Controls.Add(Me.Label7)
        Me.FormSkin1.Controls.Add(Me.Label6)
        Me.FormSkin1.Controls.Add(Me.Label5)
        Me.FormSkin1.Controls.Add(Me.TutorialPicture)
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Controls.Add(Me.Label4)
        Me.FormSkin1.Controls.Add(Me.CollateralBox)
        Me.FormSkin1.Controls.Add(Me.CollateralList)
        Me.FormSkin1.Controls.Add(Me.SuccessLabel)
        Me.FormSkin1.Controls.Add(Me.Label3)
        Me.FormSkin1.Controls.Add(Me.Label2)
        Me.FormSkin1.Controls.Add(Me.CollateralComboBox)
        Me.FormSkin1.Controls.Add(Me.BatchLabel)
        Me.FormSkin1.Controls.Add(Me.Label1)
        Me.FormSkin1.Controls.Add(Me.DealershipComboBox)
        Me.FormSkin1.Controls.Add(Me.AddButton)
        Me.FormSkin1.Controls.Add(Me.DoneButton)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.SteelBlue
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(402, 273)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Collateral Log"
        '
        'ManualToggleCheckBox
        '
        Me.ManualToggleCheckBox.AutoSize = True
        Me.ManualToggleCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.ManualToggleCheckBox.Checked = True
        Me.ManualToggleCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ManualToggleCheckBox.ForeColor = System.Drawing.Color.White
        Me.ManualToggleCheckBox.Location = New System.Drawing.Point(132, 1)
        Me.ManualToggleCheckBox.Name = "ManualToggleCheckBox"
        Me.ManualToggleCheckBox.Size = New System.Drawing.Size(112, 25)
        Me.ManualToggleCheckBox.TabIndex = 22
        Me.ManualToggleCheckBox.Text = "Auto Assign"
        Me.ManualToggleCheckBox.UseVisualStyleBackColor = False
        '
        'ReceivedDateCheckBox
        '
        Me.ReceivedDateCheckBox.AutoSize = True
        Me.ReceivedDateCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.ReceivedDateCheckBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReceivedDateCheckBox.Location = New System.Drawing.Point(122, 206)
        Me.ReceivedDateCheckBox.Name = "ReceivedDateCheckBox"
        Me.ReceivedDateCheckBox.Size = New System.Drawing.Size(180, 21)
        Me.ReceivedDateCheckBox.TabIndex = 21
        Me.ReceivedDateCheckBox.Text = "Received date NOT Today"
        Me.ReceivedDateCheckBox.UseVisualStyleBackColor = False
        '
        'ReceivedDateTime
        '
        Me.ReceivedDateTime.CustomFormat = "yyy-MM-dd"
        Me.ReceivedDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ReceivedDateTime.Location = New System.Drawing.Point(7, 238)
        Me.ReceivedDateTime.Name = "ReceivedDateTime"
        Me.ReceivedDateTime.Size = New System.Drawing.Size(109, 29)
        Me.ReceivedDateTime.TabIndex = 20
        Me.ReceivedDateTime.Visible = False
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.SteelBlue
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatButton2.Location = New System.Drawing.Point(182, 169)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(67, 17)
        Me.FlatButton2.TabIndex = 19
        Me.FlatButton2.Text = "Re-Count"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'MyCountBox
        '
        Me.MyCountBox.Location = New System.Drawing.Point(191, 132)
        Me.MyCountBox.Name = "MyCountBox"
        Me.MyCountBox.Size = New System.Drawing.Size(48, 29)
        Me.MyCountBox.TabIndex = 18
        '
        'ListCountBox
        '
        Me.ListCountBox.Location = New System.Drawing.Point(193, 76)
        Me.ListCountBox.Name = "ListCountBox"
        Me.ListCountBox.ReadOnly = True
        Me.ListCountBox.Size = New System.Drawing.Size(46, 29)
        Me.ListCountBox.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(189, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 21)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Count"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(183, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 21)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "List Count"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(276, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Help!"
        '
        'TutorialPicture
        '
        Me.TutorialPicture.BackColor = System.Drawing.Color.Transparent
        Me.TutorialPicture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TutorialPicture.Image = CType(resources.GetObject("TutorialPicture.Image"), System.Drawing.Image)
        Me.TutorialPicture.Location = New System.Drawing.Point(323, 4)
        Me.TutorialPicture.Name = "TutorialPicture"
        Me.TutorialPicture.Size = New System.Drawing.Size(17, 17)
        Me.TutorialPicture.TabIndex = 13
        Me.TutorialPicture.TabStop = False
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.DarkRed
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(258, 238)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(68, 31)
        Me.FlatButton1.TabIndex = 12
        Me.FlatButton1.Text = "Remove"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(8, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 21)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "VIN6"
        '
        'CollateralBox
        '
        Me.CollateralBox.Location = New System.Drawing.Point(7, 201)
        Me.CollateralBox.Name = "CollateralBox"
        Me.CollateralBox.Size = New System.Drawing.Size(109, 29)
        Me.CollateralBox.TabIndex = 10
        '
        'CollateralList
        '
        Me.CollateralList.FormattingEnabled = True
        Me.CollateralList.ItemHeight = 21
        Me.CollateralList.Location = New System.Drawing.Point(263, 52)
        Me.CollateralList.Name = "CollateralList"
        Me.CollateralList.Size = New System.Drawing.Size(136, 151)
        Me.CollateralList.TabIndex = 9
        '
        'SuccessLabel
        '
        Me.SuccessLabel.AutoSize = True
        Me.SuccessLabel.BackColor = System.Drawing.Color.LightGreen
        Me.SuccessLabel.Location = New System.Drawing.Point(178, 248)
        Me.SuccessLabel.Name = "SuccessLabel"
        Me.SuccessLabel.Size = New System.Drawing.Size(69, 21)
        Me.SuccessLabel.TabIndex = 8
        Me.SuccessLabel.Text = "Success!"
        Me.SuccessLabel.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(3, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Collateral Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(3, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Dealership"
        '
        'CollateralComboBox
        '
        Me.CollateralComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CollateralComboBox.FormattingEnabled = True
        Me.CollateralComboBox.Location = New System.Drawing.Point(3, 131)
        Me.CollateralComboBox.Name = "CollateralComboBox"
        Me.CollateralComboBox.Size = New System.Drawing.Size(161, 29)
        Me.CollateralComboBox.TabIndex = 5
        '
        'BatchLabel
        '
        Me.BatchLabel.AutoSize = True
        Me.BatchLabel.BackColor = System.Drawing.Color.Transparent
        Me.BatchLabel.ForeColor = System.Drawing.Color.White
        Me.BatchLabel.Location = New System.Drawing.Point(222, 29)
        Me.BatchLabel.Name = "BatchLabel"
        Me.BatchLabel.Size = New System.Drawing.Size(0, 21)
        Me.BatchLabel.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(152, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Batch ID:"
        '
        'DealershipComboBox
        '
        Me.DealershipComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DealershipComboBox.FormattingEnabled = True
        Me.DealershipComboBox.Location = New System.Drawing.Point(3, 76)
        Me.DealershipComboBox.Name = "DealershipComboBox"
        Me.DealershipComboBox.Size = New System.Drawing.Size(161, 29)
        Me.DealershipComboBox.TabIndex = 2
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.Transparent
        Me.AddButton.BaseColor = System.Drawing.Color.SteelBlue
        Me.AddButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AddButton.Location = New System.Drawing.Point(332, 238)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Rounded = False
        Me.AddButton.Size = New System.Drawing.Size(67, 32)
        Me.AddButton.TabIndex = 1
        Me.AddButton.Text = "Add List"
        Me.AddButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'DoneButton
        '
        Me.DoneButton.BackColor = System.Drawing.Color.Transparent
        Me.DoneButton.BaseColor = System.Drawing.Color.DarkRed
        Me.DoneButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DoneButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.DoneButton.Location = New System.Drawing.Point(349, 0)
        Me.DoneButton.Name = "DoneButton"
        Me.DoneButton.Rounded = False
        Me.DoneButton.Size = New System.Drawing.Size(53, 21)
        Me.DoneButton.TabIndex = 0
        Me.DoneButton.Text = "Done"
        Me.DoneButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'CollateralLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 273)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CollateralLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CollateralLog"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        CType(Me.TutorialPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As ProductionLog.FormSkin
    Friend WithEvents DealershipComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AddButton As ProductionLog.FlatButton
    Friend WithEvents DoneButton As ProductionLog.FlatButton
    Friend WithEvents BatchLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CollateralComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SuccessLabel As System.Windows.Forms.Label
    Friend WithEvents SuccessTimer As System.Windows.Forms.Timer
    Friend WithEvents CollateralList As System.Windows.Forms.ListBox
    Friend WithEvents FlatButton1 As ProductionLog.FlatButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CollateralBox As System.Windows.Forms.TextBox
    Friend WithEvents TutorialPicture As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MyCountBox As System.Windows.Forms.TextBox
    Friend WithEvents ListCountBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents FlatButton2 As ProductionLog.FlatButton
    Friend WithEvents ReceivedDateCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ReceivedDateTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents ManualToggleCheckBox As System.Windows.Forms.CheckBox
End Class
