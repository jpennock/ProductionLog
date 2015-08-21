<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Overwatch
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
        Me.Palantiri = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1 = New ProductionLog.FormSkin()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.FlatClose1 = New ProductionLog.FlatClose()
        Me.MinimizeLabel = New System.Windows.Forms.Label()
        Me.ExpandButton = New System.Windows.Forms.Button()
        Me.BBComboBox = New System.Windows.Forms.ComboBox()
        Me.EmpIDLabel = New System.Windows.Forms.Label()
        Me.DealershipLabel = New System.Windows.Forms.Label()
        Me.MiniButton = New ProductionLog.FlatButton()
        Me.FlatButton1 = New ProductionLog.FlatButton()
        Me.FormSkin1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Palantiri
        '
        Me.Palantiri.Enabled = True
        Me.Palantiri.Interval = 1000
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.Gray
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Controls.Add(Me.Label1)
        Me.FormSkin1.Controls.Add(Me.CheckedListBox1)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Controls.Add(Me.MinimizeLabel)
        Me.FormSkin1.Controls.Add(Me.ExpandButton)
        Me.FormSkin1.Controls.Add(Me.BBComboBox)
        Me.FormSkin1.Controls.Add(Me.EmpIDLabel)
        Me.FormSkin1.Controls.Add(Me.DealershipLabel)
        Me.FormSkin1.Controls.Add(Me.MiniButton)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.SteelBlue
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(289, 60)
        Me.FormSkin1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(98, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 21)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "CIFR Jobs"
        Me.Label1.Visible = False
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.BackColor = System.Drawing.Color.Gray
        Me.CheckedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(1, 86)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(286, 146)
        Me.CheckedListBox1.TabIndex = 8
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(270, 0)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 7
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'MinimizeLabel
        '
        Me.MinimizeLabel.AutoSize = True
        Me.MinimizeLabel.BackColor = System.Drawing.Color.Transparent
        Me.MinimizeLabel.ForeColor = System.Drawing.Color.Black
        Me.MinimizeLabel.Location = New System.Drawing.Point(58, 566)
        Me.MinimizeLabel.Name = "MinimizeLabel"
        Me.MinimizeLabel.Size = New System.Drawing.Size(164, 21)
        Me.MinimizeLabel.TabIndex = 6
        Me.MinimizeLabel.Text = "Click here to minimize"
        Me.MinimizeLabel.Visible = False
        '
        'ExpandButton
        '
        Me.ExpandButton.BackColor = System.Drawing.Color.Black
        Me.ExpandButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExpandButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ExpandButton.Location = New System.Drawing.Point(0, 50)
        Me.ExpandButton.Name = "ExpandButton"
        Me.ExpandButton.Size = New System.Drawing.Size(289, 10)
        Me.ExpandButton.TabIndex = 5
        Me.ExpandButton.Text = "VVV"
        Me.ExpandButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ExpandButton.UseVisualStyleBackColor = False
        '
        'BBComboBox
        '
        Me.BBComboBox.BackColor = System.Drawing.Color.Gray
        Me.BBComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BBComboBox.FormattingEnabled = True
        Me.BBComboBox.Location = New System.Drawing.Point(29, 10)
        Me.BBComboBox.Name = "BBComboBox"
        Me.BBComboBox.Size = New System.Drawing.Size(158, 29)
        Me.BBComboBox.TabIndex = 4
        '
        'EmpIDLabel
        '
        Me.EmpIDLabel.AutoSize = True
        Me.EmpIDLabel.BackColor = System.Drawing.Color.Transparent
        Me.EmpIDLabel.ForeColor = System.Drawing.Color.White
        Me.EmpIDLabel.Location = New System.Drawing.Point(269, 23)
        Me.EmpIDLabel.Name = "EmpIDLabel"
        Me.EmpIDLabel.Size = New System.Drawing.Size(19, 21)
        Me.EmpIDLabel.TabIndex = 3
        Me.EmpIDLabel.Text = "0"
        '
        'DealershipLabel
        '
        Me.DealershipLabel.AutoSize = True
        Me.DealershipLabel.BackColor = System.Drawing.Color.Transparent
        Me.DealershipLabel.ForeColor = System.Drawing.Color.Transparent
        Me.DealershipLabel.Location = New System.Drawing.Point(25, 14)
        Me.DealershipLabel.Name = "DealershipLabel"
        Me.DealershipLabel.Size = New System.Drawing.Size(0, 21)
        Me.DealershipLabel.TabIndex = 2
        '
        'MiniButton
        '
        Me.MiniButton.BackColor = System.Drawing.Color.Transparent
        Me.MiniButton.BaseColor = System.Drawing.Color.Teal
        Me.MiniButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MiniButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MiniButton.Location = New System.Drawing.Point(242, 0)
        Me.MiniButton.Name = "MiniButton"
        Me.MiniButton.Rounded = False
        Me.MiniButton.Size = New System.Drawing.Size(23, 18)
        Me.MiniButton.TabIndex = 1
        Me.MiniButton.Text = "_"
        Me.MiniButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(83, 238)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(104, 32)
        Me.FlatButton1.TabIndex = 10
        Me.FlatButton1.Text = "End Selected"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Overwatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 60)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Overwatch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Overwatch"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As ProductionLog.FormSkin
    Friend WithEvents MiniButton As ProductionLog.FlatButton
    Friend WithEvents Palantiri As System.Windows.Forms.Timer
    Friend WithEvents DealershipLabel As System.Windows.Forms.Label
    Friend WithEvents EmpIDLabel As System.Windows.Forms.Label
    Friend WithEvents BBComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ExpandButton As System.Windows.Forms.Button
    Friend WithEvents MinimizeLabel As System.Windows.Forms.Label
    Friend WithEvents FlatClose1 As ProductionLog.FlatClose
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents FlatButton1 As ProductionLog.FlatButton
End Class
