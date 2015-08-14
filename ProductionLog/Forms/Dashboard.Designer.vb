<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.StillHere = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1 = New ProductionLog.FormSkin()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.FlatButton1 = New ProductionLog.FlatButton()
        Me.ViewButton = New ProductionLog.FlatButton()
        Me.IDLabel = New System.Windows.Forms.Label()
        Me.FlatMini1 = New ProductionLog.FlatMini()
        Me.FlatClose1 = New ProductionLog.FlatClose()
        Me.OttoButton = New ProductionLog.FlatButton()
        Me.WhiteboardButton = New ProductionLog.FlatButton()
        Me.ManagerButton = New ProductionLog.FlatButton()
        Me.CollateralButton = New ProductionLog.FlatButton()
        Me.FormSkin1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StillHere
        '
        Me.StillHere.Enabled = True
        Me.StillHere.Interval = 1000
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.Gray
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.VersionLabel)
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Controls.Add(Me.ViewButton)
        Me.FormSkin1.Controls.Add(Me.IDLabel)
        Me.FormSkin1.Controls.Add(Me.FlatMini1)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Controls.Add(Me.OttoButton)
        Me.FormSkin1.Controls.Add(Me.WhiteboardButton)
        Me.FormSkin1.Controls.Add(Me.ManagerButton)
        Me.FormSkin1.Controls.Add(Me.CollateralButton)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.Red
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(468, 107)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Production Log"
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.BackColor = System.Drawing.Color.Transparent
        Me.VersionLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VersionLabel.ForeColor = System.Drawing.Color.White
        Me.VersionLabel.Location = New System.Drawing.Point(1, 0)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(31, 13)
        Me.VersionLabel.TabIndex = 9
        Me.VersionLabel.Text = "0.5.7"
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.SteelBlue
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(47, 0)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(48, 19)
        Me.FlatButton1.TabIndex = 8
        Me.FlatButton1.Text = "TEST"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ViewButton
        '
        Me.ViewButton.BackColor = System.Drawing.Color.Transparent
        Me.ViewButton.BaseColor = System.Drawing.Color.Green
        Me.ViewButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ViewButton.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ViewButton.Location = New System.Drawing.Point(348, 3)
        Me.ViewButton.Name = "ViewButton"
        Me.ViewButton.Rounded = False
        Me.ViewButton.Size = New System.Drawing.Size(68, 18)
        Me.ViewButton.TabIndex = 7
        Me.ViewButton.Text = "Viewer"
        Me.ViewButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'IDLabel
        '
        Me.IDLabel.AutoSize = True
        Me.IDLabel.BackColor = System.Drawing.Color.Transparent
        Me.IDLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.IDLabel.ForeColor = System.Drawing.Color.White
        Me.IDLabel.Location = New System.Drawing.Point(448, 24)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(17, 19)
        Me.IDLabel.TabIndex = 6
        Me.IDLabel.Text = "0"
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(423, 3)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 5
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(447, 3)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 4
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'OttoButton
        '
        Me.OttoButton.BackColor = System.Drawing.Color.Transparent
        Me.OttoButton.BaseColor = System.Drawing.Color.SteelBlue
        Me.OttoButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OttoButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.OttoButton.Location = New System.Drawing.Point(348, 61)
        Me.OttoButton.Name = "OttoButton"
        Me.OttoButton.Rounded = False
        Me.OttoButton.Size = New System.Drawing.Size(106, 32)
        Me.OttoButton.TabIndex = 3
        Me.OttoButton.Text = "Otto"
        Me.OttoButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'WhiteboardButton
        '
        Me.WhiteboardButton.BackColor = System.Drawing.Color.Transparent
        Me.WhiteboardButton.BaseColor = System.Drawing.Color.SteelBlue
        Me.WhiteboardButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WhiteboardButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.WhiteboardButton.Location = New System.Drawing.Point(236, 61)
        Me.WhiteboardButton.Name = "WhiteboardButton"
        Me.WhiteboardButton.Rounded = False
        Me.WhiteboardButton.Size = New System.Drawing.Size(106, 32)
        Me.WhiteboardButton.TabIndex = 2
        Me.WhiteboardButton.Text = "Pull Requests"
        Me.WhiteboardButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ManagerButton
        '
        Me.ManagerButton.BackColor = System.Drawing.Color.Transparent
        Me.ManagerButton.BaseColor = System.Drawing.Color.SteelBlue
        Me.ManagerButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ManagerButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ManagerButton.Location = New System.Drawing.Point(124, 61)
        Me.ManagerButton.Name = "ManagerButton"
        Me.ManagerButton.Rounded = False
        Me.ManagerButton.Size = New System.Drawing.Size(106, 32)
        Me.ManagerButton.TabIndex = 1
        Me.ManagerButton.Text = "Team Lead"
        Me.ManagerButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'CollateralButton
        '
        Me.CollateralButton.BackColor = System.Drawing.Color.Transparent
        Me.CollateralButton.BaseColor = System.Drawing.Color.SteelBlue
        Me.CollateralButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CollateralButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CollateralButton.Location = New System.Drawing.Point(12, 61)
        Me.CollateralButton.Name = "CollateralButton"
        Me.CollateralButton.Rounded = False
        Me.CollateralButton.Size = New System.Drawing.Size(106, 32)
        Me.CollateralButton.TabIndex = 0
        Me.CollateralButton.Text = "Work Queue"
        Me.CollateralButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 107)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As ProductionLog.FormSkin
    Friend WithEvents CollateralButton As ProductionLog.FlatButton
    Friend WithEvents WhiteboardButton As ProductionLog.FlatButton
    Friend WithEvents ManagerButton As ProductionLog.FlatButton
    Friend WithEvents OttoButton As ProductionLog.FlatButton
    Friend WithEvents FlatMini1 As ProductionLog.FlatMini
    Friend WithEvents FlatClose1 As ProductionLog.FlatClose
    Friend WithEvents StillHere As System.Windows.Forms.Timer
    Friend WithEvents IDLabel As System.Windows.Forms.Label
    Friend WithEvents ViewButton As ProductionLog.FlatButton
    Friend WithEvents FlatButton1 As ProductionLog.FlatButton
    Friend WithEvents VersionLabel As System.Windows.Forms.Label
End Class
