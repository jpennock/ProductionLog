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
        Me.MailTreeVIew = New System.Windows.Forms.TreeView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuccessLabel = New System.Windows.Forms.Label()
        Me.FlatButton1 = New ProductionLog.FlatButton()
        Me.DealerComboBox = New System.Windows.Forms.ComboBox()
        Me.TrackingNumberLabel = New System.Windows.Forms.Label()
        Me.TrackingTextBox = New System.Windows.Forms.TextBox()
        Me.RightClickMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormSkin1.SuspendLayout()
        Me.RightClickMenu.SuspendLayout()
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
        Me.FormSkin1.Controls.Add(Me.MailTreeVIew)
        Me.FormSkin1.Controls.Add(Me.Label1)
        Me.FormSkin1.Controls.Add(Me.SuccessLabel)
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Controls.Add(Me.DealerComboBox)
        Me.FormSkin1.Controls.Add(Me.TrackingNumberLabel)
        Me.FormSkin1.Controls.Add(Me.TrackingTextBox)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.SteelBlue
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(752, 584)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "The Mail"
        '
        'MailTreeVIew
        '
        Me.MailTreeVIew.ContextMenuStrip = Me.RightClickMenu
        Me.MailTreeVIew.Location = New System.Drawing.Point(281, 91)
        Me.MailTreeVIew.Name = "MailTreeVIew"
        Me.MailTreeVIew.Size = New System.Drawing.Size(388, 474)
        Me.MailTreeVIew.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(277, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Mail received:"
        '
        'SuccessLabel
        '
        Me.SuccessLabel.AutoSize = True
        Me.SuccessLabel.BackColor = System.Drawing.Color.DarkGreen
        Me.SuccessLabel.ForeColor = System.Drawing.Color.White
        Me.SuccessLabel.Location = New System.Drawing.Point(103, 196)
        Me.SuccessLabel.Name = "SuccessLabel"
        Me.SuccessLabel.Size = New System.Drawing.Size(55, 21)
        Me.SuccessLabel.TabIndex = 6
        Me.SuccessLabel.Text = "Added"
        Me.SuccessLabel.Visible = False
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.SteelBlue
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(80, 161)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(101, 32)
        Me.FlatButton1.TabIndex = 2
        Me.FlatButton1.Text = "Add"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'DealerComboBox
        '
        Me.DealerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DealerComboBox.FormattingEnabled = True
        Me.DealerComboBox.Location = New System.Drawing.Point(27, 126)
        Me.DealerComboBox.Name = "DealerComboBox"
        Me.DealerComboBox.Size = New System.Drawing.Size(212, 29)
        Me.DealerComboBox.TabIndex = 1
        '
        'TrackingNumberLabel
        '
        Me.TrackingNumberLabel.AutoSize = True
        Me.TrackingNumberLabel.BackColor = System.Drawing.Color.Transparent
        Me.TrackingNumberLabel.Location = New System.Drawing.Point(67, 59)
        Me.TrackingNumberLabel.Name = "TrackingNumberLabel"
        Me.TrackingNumberLabel.Size = New System.Drawing.Size(131, 21)
        Me.TrackingNumberLabel.TabIndex = 3
        Me.TrackingNumberLabel.Text = "Tracking Number"
        '
        'TrackingTextBox
        '
        Me.TrackingTextBox.Location = New System.Drawing.Point(27, 91)
        Me.TrackingTextBox.Name = "TrackingTextBox"
        Me.TrackingTextBox.Size = New System.Drawing.Size(212, 29)
        Me.TrackingTextBox.TabIndex = 0
        '
        'RightClickMenu
        '
        Me.RightClickMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveToolStripMenuItem})
        Me.RightClickMenu.Name = "RightClickMenu"
        Me.RightClickMenu.Size = New System.Drawing.Size(118, 26)
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'TheCIFR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 584)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TheCIFR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TheCIFR"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.RightClickMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SuccessTimer As System.Windows.Forms.Timer
    Friend WithEvents FormSkin1 As ProductionLog.FormSkin
    Friend WithEvents FlatButton1 As ProductionLog.FlatButton
    Friend WithEvents DealerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TrackingNumberLabel As System.Windows.Forms.Label
    Friend WithEvents TrackingTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SuccessLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MailTreeVIew As System.Windows.Forms.TreeView
    Friend WithEvents RightClickMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RemoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
