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
        Me.BBComboBox = New System.Windows.Forms.ComboBox()
        Me.EmpIDLabel = New System.Windows.Forms.Label()
        Me.DealershipLabel = New System.Windows.Forms.Label()
        Me.MiniButton = New ProductionLog.FlatButton()
        Me.FlatClose1 = New ProductionLog.FlatClose()
        Me.FormSkin1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Palantiri
        '
        Me.Palantiri.Enabled = True
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.Gray
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.BBComboBox)
        Me.FormSkin1.Controls.Add(Me.EmpIDLabel)
        Me.FormSkin1.Controls.Add(Me.DealershipLabel)
        Me.FormSkin1.Controls.Add(Me.MiniButton)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.Red
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(289, 60)
        Me.FormSkin1.TabIndex = 0
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
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(271, 0)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 0
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
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
    Friend WithEvents FlatClose1 As ProductionLog.FlatClose
    Friend WithEvents Palantiri As System.Windows.Forms.Timer
    Friend WithEvents DealershipLabel As System.Windows.Forms.Label
    Friend WithEvents EmpIDLabel As System.Windows.Forms.Label
    Friend WithEvents BBComboBox As System.Windows.Forms.ComboBox
End Class
