<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowQuery
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShowQuery))
        Me.ResultsDGV = New System.Windows.Forms.DataGridView()
        Me.FormSkin1 = New ProductionLog.FormSkin()
        Me.FlatButton1 = New ProductionLog.FlatButton()
        Me.VINCheckList = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ResultsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormSkin1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ResultsDGV
        '
        Me.ResultsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ResultsDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResultsDGV.Location = New System.Drawing.Point(0, 0)
        Me.ResultsDGV.Name = "ResultsDGV"
        Me.ResultsDGV.Size = New System.Drawing.Size(306, 269)
        Me.ResultsDGV.TabIndex = 0
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.Gray
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Controls.Add(Me.VINCheckList)
        Me.FormSkin1.Controls.Add(Me.Label1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.Red
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(306, 269)
        Me.FormSkin1.TabIndex = 1
        Me.FormSkin1.Text = "Missing Items"
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.SteelBlue
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(127, 234)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(54, 32)
        Me.FlatButton1.TabIndex = 1
        Me.FlatButton1.Text = "OK"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'VINCheckList
        '
        Me.VINCheckList.CheckOnClick = True
        Me.VINCheckList.FormattingEnabled = True
        Me.VINCheckList.Location = New System.Drawing.Point(14, 83)
        Me.VINCheckList.Name = "VINCheckList"
        Me.VINCheckList.Size = New System.Drawing.Size(280, 148)
        Me.VINCheckList.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(50, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 21)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Which VINs were missing?"
        '
        'ShowQuery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 269)
        Me.Controls.Add(Me.FormSkin1)
        Me.Controls.Add(Me.ResultsDGV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ShowQuery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Query Results"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.ResultsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ResultsDGV As System.Windows.Forms.DataGridView
    Friend WithEvents FormSkin1 As ProductionLog.FormSkin
    Friend WithEvents FlatButton1 As ProductionLog.FlatButton
    Friend WithEvents VINCheckList As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
