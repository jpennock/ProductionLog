<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainParent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainParent))
        Me.OpenF = New System.Windows.Forms.OpenFileDialog()
        Me.FormSkin1 = New ProductionLog.FormSkin()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.UploadButton = New ProductionLog.FlatButton()
        Me.FileButton = New ProductionLog.FlatButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.UploadDGV = New System.Windows.Forms.DataGridView()
        Me.FlatButton1 = New ProductionLog.FlatButton()
        Me.FormSkin1.SuspendLayout()
        CType(Me.UploadDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenF
        '
        Me.OpenF.FileName = "OpenFileDialog1"
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.Gray
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Controls.Add(Me.ProgressBar1)
        Me.FormSkin1.Controls.Add(Me.UploadButton)
        Me.FormSkin1.Controls.Add(Me.FileButton)
        Me.FormSkin1.Controls.Add(Me.ComboBox1)
        Me.FormSkin1.Controls.Add(Me.CheckedListBox1)
        Me.FormSkin1.Controls.Add(Me.UploadDGV)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.Red
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(960, 659)
        Me.FormSkin1.TabIndex = 1
        Me.FormSkin1.Text = "VIN Uploader"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(731, 329)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(204, 23)
        Me.ProgressBar1.TabIndex = 5
        '
        'UploadButton
        '
        Me.UploadButton.BackColor = System.Drawing.Color.Transparent
        Me.UploadButton.BaseColor = System.Drawing.Color.SteelBlue
        Me.UploadButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UploadButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.UploadButton.Location = New System.Drawing.Point(774, 291)
        Me.UploadButton.Name = "UploadButton"
        Me.UploadButton.Rounded = False
        Me.UploadButton.Size = New System.Drawing.Size(106, 32)
        Me.UploadButton.TabIndex = 4
        Me.UploadButton.Text = "Upload VINS"
        Me.UploadButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FileButton
        '
        Me.FileButton.BackColor = System.Drawing.Color.Transparent
        Me.FileButton.BaseColor = System.Drawing.Color.SteelBlue
        Me.FileButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FileButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FileButton.Location = New System.Drawing.Point(774, 108)
        Me.FileButton.Name = "FileButton"
        Me.FileButton.Rounded = False
        Me.FileButton.Size = New System.Drawing.Size(106, 32)
        Me.FileButton.TabIndex = 3
        Me.FileButton.Text = "Select File"
        Me.FileButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(731, 53)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(204, 29)
        Me.ComboBox1.TabIndex = 2
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(731, 166)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(204, 100)
        Me.CheckedListBox1.TabIndex = 1
        '
        'UploadDGV
        '
        Me.UploadDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UploadDGV.Location = New System.Drawing.Point(3, 53)
        Me.UploadDGV.Name = "UploadDGV"
        Me.UploadDGV.Size = New System.Drawing.Size(696, 603)
        Me.UploadDGV.TabIndex = 0
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.Red
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(774, 468)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(106, 32)
        Me.FlatButton1.TabIndex = 6
        Me.FlatButton1.Text = "Upload CIFR"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'MainParent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 659)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "MainParent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Primalend Production Log"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        CType(Me.UploadDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As ProductionLog.FormSkin
    Friend WithEvents UploadDGV As System.Windows.Forms.DataGridView
    Friend WithEvents FileButton As ProductionLog.FlatButton
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents OpenF As System.Windows.Forms.OpenFileDialog
    Friend WithEvents UploadButton As ProductionLog.FlatButton
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents FlatButton1 As ProductionLog.FlatButton

End Class
