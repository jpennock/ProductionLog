<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileCabinetPopup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FileCabinetPopup))
        Me.FormSkin1 = New ProductionLog.FormSkin()
        Me.OtherButton = New ProductionLog.FlatButton()
        Me.StartButton = New ProductionLog.FlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EmpIDLabel = New System.Windows.Forms.Label()
        Me.JobCheckListBox = New System.Windows.Forms.CheckedListBox()
        Me.XButton = New ProductionLog.FlatButton()
        Me.FormSkin1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.Gray
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.OtherButton)
        Me.FormSkin1.Controls.Add(Me.StartButton)
        Me.FormSkin1.Controls.Add(Me.Label1)
        Me.FormSkin1.Controls.Add(Me.EmpIDLabel)
        Me.FormSkin1.Controls.Add(Me.JobCheckListBox)
        Me.FormSkin1.Controls.Add(Me.XButton)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.SteelBlue
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(519, 226)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Available Jobs:"
        '
        'OtherButton
        '
        Me.OtherButton.BackColor = System.Drawing.Color.Transparent
        Me.OtherButton.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.OtherButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OtherButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.OtherButton.Location = New System.Drawing.Point(259, 188)
        Me.OtherButton.Name = "OtherButton"
        Me.OtherButton.Rounded = False
        Me.OtherButton.Size = New System.Drawing.Size(123, 32)
        Me.OtherButton.TabIndex = 7
        Me.OtherButton.Text = "Request Update"
        Me.OtherButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.Color.Transparent
        Me.StartButton.BaseColor = System.Drawing.Color.SteelBlue
        Me.StartButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StartButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.StartButton.Location = New System.Drawing.Point(132, 188)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Rounded = False
        Me.StartButton.Size = New System.Drawing.Size(106, 32)
        Me.StartButton.TabIndex = 6
        Me.StartButton.Text = "Start Jobs"
        Me.StartButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(128, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Select the Jobs you are working on."
        '
        'EmpIDLabel
        '
        Me.EmpIDLabel.AutoSize = True
        Me.EmpIDLabel.BackColor = System.Drawing.Color.Transparent
        Me.EmpIDLabel.ForeColor = System.Drawing.Color.White
        Me.EmpIDLabel.Location = New System.Drawing.Point(488, 23)
        Me.EmpIDLabel.Name = "EmpIDLabel"
        Me.EmpIDLabel.Size = New System.Drawing.Size(19, 21)
        Me.EmpIDLabel.TabIndex = 4
        Me.EmpIDLabel.Text = "0"
        '
        'JobCheckListBox
        '
        Me.JobCheckListBox.CheckOnClick = True
        Me.JobCheckListBox.FormattingEnabled = True
        Me.JobCheckListBox.Location = New System.Drawing.Point(3, 53)
        Me.JobCheckListBox.Name = "JobCheckListBox"
        Me.JobCheckListBox.Size = New System.Drawing.Size(513, 100)
        Me.JobCheckListBox.TabIndex = 3
        '
        'XButton
        '
        Me.XButton.BackColor = System.Drawing.Color.Transparent
        Me.XButton.BaseColor = System.Drawing.Color.Red
        Me.XButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.XButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.XButton.Location = New System.Drawing.Point(492, 0)
        Me.XButton.Name = "XButton"
        Me.XButton.Rounded = False
        Me.XButton.Size = New System.Drawing.Size(27, 20)
        Me.XButton.TabIndex = 2
        Me.XButton.Text = "X"
        Me.XButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FileCabinetPopup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 226)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FileCabinetPopup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FileCabinetPopup"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As ProductionLog.FormSkin
    Friend WithEvents XButton As ProductionLog.FlatButton
    Friend WithEvents EmpIDLabel As System.Windows.Forms.Label
    Friend WithEvents JobCheckListBox As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OtherButton As ProductionLog.FlatButton
    Friend WithEvents StartButton As ProductionLog.FlatButton
End Class
