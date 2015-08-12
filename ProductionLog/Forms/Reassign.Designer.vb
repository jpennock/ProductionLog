<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reassign
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reassign))
        Me.FormSkin1 = New ProductionLog.FormSkin()
        Me.FlatButton2 = New ProductionLog.FlatButton()
        Me.QALabel = New System.Windows.Forms.Label()
        Me.EmpIDBox = New System.Windows.Forms.TextBox()
        Me.EmpComboBox = New System.Windows.Forms.ComboBox()
        Me.FlatButton1 = New ProductionLog.FlatButton()
        Me.JobIdLabel = New System.Windows.Forms.Label()
        Me.FormSkin1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.Gray
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatButton2)
        Me.FormSkin1.Controls.Add(Me.QALabel)
        Me.FormSkin1.Controls.Add(Me.EmpIDBox)
        Me.FormSkin1.Controls.Add(Me.EmpComboBox)
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Controls.Add(Me.JobIdLabel)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.SteelBlue
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(314, 103)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Re-Assign"
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.Maroon
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(142, 0)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(52, 21)
        Me.FlatButton2.TabIndex = 5
        Me.FlatButton2.Text = "Cancel"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'QALabel
        '
        Me.QALabel.AutoSize = True
        Me.QALabel.BackColor = System.Drawing.Color.Transparent
        Me.QALabel.ForeColor = System.Drawing.Color.White
        Me.QALabel.Location = New System.Drawing.Point(270, 21)
        Me.QALabel.Name = "QALabel"
        Me.QALabel.Size = New System.Drawing.Size(32, 21)
        Me.QALabel.TabIndex = 4
        Me.QALabel.Text = "QA"
        Me.QALabel.Visible = False
        '
        'EmpIDBox
        '
        Me.EmpIDBox.Location = New System.Drawing.Point(153, 64)
        Me.EmpIDBox.Name = "EmpIDBox"
        Me.EmpIDBox.ReadOnly = True
        Me.EmpIDBox.Size = New System.Drawing.Size(41, 29)
        Me.EmpIDBox.TabIndex = 3
        '
        'EmpComboBox
        '
        Me.EmpComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EmpComboBox.FormattingEnabled = True
        Me.EmpComboBox.Location = New System.Drawing.Point(12, 64)
        Me.EmpComboBox.Name = "EmpComboBox"
        Me.EmpComboBox.Size = New System.Drawing.Size(135, 29)
        Me.EmpComboBox.TabIndex = 2
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.SteelBlue
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(229, 64)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(79, 32)
        Me.FlatButton1.TabIndex = 1
        Me.FlatButton1.Text = "Assign"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'JobIdLabel
        '
        Me.JobIdLabel.AutoSize = True
        Me.JobIdLabel.BackColor = System.Drawing.Color.Transparent
        Me.JobIdLabel.ForeColor = System.Drawing.Color.White
        Me.JobIdLabel.Location = New System.Drawing.Point(273, 0)
        Me.JobIdLabel.Name = "JobIdLabel"
        Me.JobIdLabel.Size = New System.Drawing.Size(19, 21)
        Me.JobIdLabel.TabIndex = 0
        Me.JobIdLabel.Text = "0"
        '
        'Reassign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 103)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Reassign"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reassign"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As ProductionLog.FormSkin
    Friend WithEvents JobIdLabel As System.Windows.Forms.Label
    Friend WithEvents EmpIDBox As System.Windows.Forms.TextBox
    Friend WithEvents EmpComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FlatButton1 As ProductionLog.FlatButton
    Friend WithEvents QALabel As System.Windows.Forms.Label
    Friend WithEvents FlatButton2 As ProductionLog.FlatButton
End Class
