<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EndJob
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EndJob))
        Me.FormSkin1 = New ProductionLog.FormSkin()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CommentBox = New System.Windows.Forms.TextBox()
        Me.VarianceLabel = New System.Windows.Forms.Label()
        Me.QaLabel = New System.Windows.Forms.Label()
        Me.BatchLabel = New System.Windows.Forms.Label()
        Me.EmpIDLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.JobQuantityBox = New System.Windows.Forms.TextBox()
        Me.JobBox = New System.Windows.Forms.TextBox()
        Me.DealerBox = New System.Windows.Forms.TextBox()
        Me.JobIDBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlatGroupBox1 = New ProductionLog.FlatGroupBox()
        Me.QtyCompleteLabel = New System.Windows.Forms.Label()
        Me.PartialQuantityLabel = New System.Windows.Forms.Label()
        Me.PartialQuantityBox = New System.Windows.Forms.TextBox()
        Me.PartialRadioButton = New System.Windows.Forms.RadioButton()
        Me.CompleteRadioButton = New System.Windows.Forms.RadioButton()
        Me.Big3RadioButton = New System.Windows.Forms.RadioButton()
        Me.FinishButton = New ProductionLog.FlatButton()
        Me.FormSkin1.SuspendLayout()
        Me.FlatGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.Gray
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.Label1)
        Me.FormSkin1.Controls.Add(Me.CommentBox)
        Me.FormSkin1.Controls.Add(Me.VarianceLabel)
        Me.FormSkin1.Controls.Add(Me.QaLabel)
        Me.FormSkin1.Controls.Add(Me.BatchLabel)
        Me.FormSkin1.Controls.Add(Me.EmpIDLabel)
        Me.FormSkin1.Controls.Add(Me.Label6)
        Me.FormSkin1.Controls.Add(Me.JobQuantityBox)
        Me.FormSkin1.Controls.Add(Me.JobBox)
        Me.FormSkin1.Controls.Add(Me.DealerBox)
        Me.FormSkin1.Controls.Add(Me.JobIDBox)
        Me.FormSkin1.Controls.Add(Me.Label5)
        Me.FormSkin1.Controls.Add(Me.Label4)
        Me.FormSkin1.Controls.Add(Me.Label3)
        Me.FormSkin1.Controls.Add(Me.Label2)
        Me.FormSkin1.Controls.Add(Me.FlatGroupBox1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.SteelBlue
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(518, 271)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "End Job"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(31, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 21)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Comments"
        '
        'CommentBox
        '
        Me.CommentBox.Location = New System.Drawing.Point(32, 226)
        Me.CommentBox.Name = "CommentBox"
        Me.CommentBox.Size = New System.Drawing.Size(210, 29)
        Me.CommentBox.TabIndex = 17
        '
        'VarianceLabel
        '
        Me.VarianceLabel.AutoSize = True
        Me.VarianceLabel.BackColor = System.Drawing.Color.Brown
        Me.VarianceLabel.ForeColor = System.Drawing.Color.White
        Me.VarianceLabel.Location = New System.Drawing.Point(396, 194)
        Me.VarianceLabel.Name = "VarianceLabel"
        Me.VarianceLabel.Size = New System.Drawing.Size(70, 21)
        Me.VarianceLabel.TabIndex = 16
        Me.VarianceLabel.Text = "Variance"
        Me.VarianceLabel.Visible = False
        '
        'QaLabel
        '
        Me.QaLabel.AutoSize = True
        Me.QaLabel.BackColor = System.Drawing.Color.Transparent
        Me.QaLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QaLabel.ForeColor = System.Drawing.Color.White
        Me.QaLabel.Location = New System.Drawing.Point(458, 12)
        Me.QaLabel.Name = "QaLabel"
        Me.QaLabel.Size = New System.Drawing.Size(0, 17)
        Me.QaLabel.TabIndex = 15
        '
        'BatchLabel
        '
        Me.BatchLabel.AutoSize = True
        Me.BatchLabel.BackColor = System.Drawing.Color.Transparent
        Me.BatchLabel.Location = New System.Drawing.Point(390, 199)
        Me.BatchLabel.Name = "BatchLabel"
        Me.BatchLabel.Size = New System.Drawing.Size(0, 21)
        Me.BatchLabel.TabIndex = 14
        '
        'EmpIDLabel
        '
        Me.EmpIDLabel.AutoSize = True
        Me.EmpIDLabel.BackColor = System.Drawing.Color.Transparent
        Me.EmpIDLabel.ForeColor = System.Drawing.Color.White
        Me.EmpIDLabel.Location = New System.Drawing.Point(491, 9)
        Me.EmpIDLabel.Name = "EmpIDLabel"
        Me.EmpIDLabel.Size = New System.Drawing.Size(19, 21)
        Me.EmpIDLabel.TabIndex = 13
        Me.EmpIDLabel.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(304, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(180, 21)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Current Job Information:"
        '
        'JobQuantityBox
        '
        Me.JobQuantityBox.Location = New System.Drawing.Point(344, 191)
        Me.JobQuantityBox.Name = "JobQuantityBox"
        Me.JobQuantityBox.ReadOnly = True
        Me.JobQuantityBox.Size = New System.Drawing.Size(40, 29)
        Me.JobQuantityBox.TabIndex = 11
        '
        'JobBox
        '
        Me.JobBox.Location = New System.Drawing.Point(344, 154)
        Me.JobBox.Name = "JobBox"
        Me.JobBox.ReadOnly = True
        Me.JobBox.Size = New System.Drawing.Size(166, 29)
        Me.JobBox.TabIndex = 10
        '
        'DealerBox
        '
        Me.DealerBox.Location = New System.Drawing.Point(344, 116)
        Me.DealerBox.Name = "DealerBox"
        Me.DealerBox.ReadOnly = True
        Me.DealerBox.Size = New System.Drawing.Size(140, 29)
        Me.DealerBox.TabIndex = 9
        '
        'JobIDBox
        '
        Me.JobIDBox.Location = New System.Drawing.Point(344, 81)
        Me.JobIDBox.Name = "JobIDBox"
        Me.JobIDBox.ReadOnly = True
        Me.JobIDBox.Size = New System.Drawing.Size(40, 29)
        Me.JobIDBox.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(270, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 21)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Quantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(304, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Job"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(285, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Job ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(285, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Dealer"
        '
        'FlatGroupBox1
        '
        Me.FlatGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatGroupBox1.Controls.Add(Me.QtyCompleteLabel)
        Me.FlatGroupBox1.Controls.Add(Me.PartialQuantityLabel)
        Me.FlatGroupBox1.Controls.Add(Me.PartialQuantityBox)
        Me.FlatGroupBox1.Controls.Add(Me.PartialRadioButton)
        Me.FlatGroupBox1.Controls.Add(Me.CompleteRadioButton)
        Me.FlatGroupBox1.Controls.Add(Me.Big3RadioButton)
        Me.FlatGroupBox1.Controls.Add(Me.FinishButton)
        Me.FlatGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox1.Location = New System.Drawing.Point(23, 66)
        Me.FlatGroupBox1.Name = "FlatGroupBox1"
        Me.FlatGroupBox1.ShowText = True
        Me.FlatGroupBox1.Size = New System.Drawing.Size(240, 146)
        Me.FlatGroupBox1.TabIndex = 2
        Me.FlatGroupBox1.Text = "Complete?"
        '
        'QtyCompleteLabel
        '
        Me.QtyCompleteLabel.AutoSize = True
        Me.QtyCompleteLabel.ForeColor = System.Drawing.Color.White
        Me.QtyCompleteLabel.Location = New System.Drawing.Point(142, 31)
        Me.QtyCompleteLabel.Name = "QtyCompleteLabel"
        Me.QtyCompleteLabel.Size = New System.Drawing.Size(63, 19)
        Me.QtyCompleteLabel.TabIndex = 6
        Me.QtyCompleteLabel.Text = "Quantity"
        Me.QtyCompleteLabel.Visible = False
        '
        'PartialQuantityLabel
        '
        Me.PartialQuantityLabel.AutoSize = True
        Me.PartialQuantityLabel.ForeColor = System.Drawing.Color.White
        Me.PartialQuantityLabel.Location = New System.Drawing.Point(142, 50)
        Me.PartialQuantityLabel.Name = "PartialQuantityLabel"
        Me.PartialQuantityLabel.Size = New System.Drawing.Size(76, 19)
        Me.PartialQuantityLabel.TabIndex = 5
        Me.PartialQuantityLabel.Text = "Completed"
        Me.PartialQuantityLabel.Visible = False
        '
        'PartialQuantityBox
        '
        Me.PartialQuantityBox.Location = New System.Drawing.Point(92, 39)
        Me.PartialQuantityBox.Name = "PartialQuantityBox"
        Me.PartialQuantityBox.Size = New System.Drawing.Size(44, 25)
        Me.PartialQuantityBox.TabIndex = 4
        Me.PartialQuantityBox.Visible = False
        '
        'PartialRadioButton
        '
        Me.PartialRadioButton.AutoSize = True
        Me.PartialRadioButton.ForeColor = System.Drawing.Color.White
        Me.PartialRadioButton.Location = New System.Drawing.Point(21, 39)
        Me.PartialRadioButton.Name = "PartialRadioButton"
        Me.PartialRadioButton.Size = New System.Drawing.Size(65, 23)
        Me.PartialRadioButton.TabIndex = 3
        Me.PartialRadioButton.Text = "Partial"
        Me.PartialRadioButton.UseVisualStyleBackColor = True
        '
        'CompleteRadioButton
        '
        Me.CompleteRadioButton.AutoSize = True
        Me.CompleteRadioButton.Checked = True
        Me.CompleteRadioButton.ForeColor = System.Drawing.Color.White
        Me.CompleteRadioButton.Location = New System.Drawing.Point(21, 97)
        Me.CompleteRadioButton.Name = "CompleteRadioButton"
        Me.CompleteRadioButton.Size = New System.Drawing.Size(86, 23)
        Me.CompleteRadioButton.TabIndex = 2
        Me.CompleteRadioButton.TabStop = True
        Me.CompleteRadioButton.Text = "Complete"
        Me.CompleteRadioButton.UseVisualStyleBackColor = True
        '
        'Big3RadioButton
        '
        Me.Big3RadioButton.AutoSize = True
        Me.Big3RadioButton.BackColor = System.Drawing.Color.Transparent
        Me.Big3RadioButton.ForeColor = System.Drawing.Color.White
        Me.Big3RadioButton.Location = New System.Drawing.Point(21, 68)
        Me.Big3RadioButton.Name = "Big3RadioButton"
        Me.Big3RadioButton.Size = New System.Drawing.Size(58, 23)
        Me.Big3RadioButton.TabIndex = 1
        Me.Big3RadioButton.Text = "Big 5"
        Me.Big3RadioButton.UseVisualStyleBackColor = False
        '
        'FinishButton
        '
        Me.FinishButton.BackColor = System.Drawing.Color.Transparent
        Me.FinishButton.BaseColor = System.Drawing.Color.SteelBlue
        Me.FinishButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FinishButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FinishButton.Location = New System.Drawing.Point(160, 97)
        Me.FinishButton.Name = "FinishButton"
        Me.FinishButton.Rounded = False
        Me.FinishButton.Size = New System.Drawing.Size(59, 32)
        Me.FinishButton.TabIndex = 3
        Me.FinishButton.Text = "Finish"
        Me.FinishButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'EndJob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 271)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EndJob"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EndJob"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.FlatGroupBox1.ResumeLayout(False)
        Me.FlatGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As ProductionLog.FormSkin
    Friend WithEvents FinishButton As ProductionLog.FlatButton
    Friend WithEvents FlatGroupBox1 As ProductionLog.FlatGroupBox
    Friend WithEvents PartialQuantityLabel As System.Windows.Forms.Label
    Friend WithEvents PartialQuantityBox As System.Windows.Forms.TextBox
    Friend WithEvents PartialRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CompleteRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Big3RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents JobQuantityBox As System.Windows.Forms.TextBox
    Friend WithEvents JobBox As System.Windows.Forms.TextBox
    Friend WithEvents DealerBox As System.Windows.Forms.TextBox
    Friend WithEvents JobIDBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents EmpIDLabel As System.Windows.Forms.Label
    Friend WithEvents BatchLabel As System.Windows.Forms.Label
    Friend WithEvents QtyCompleteLabel As System.Windows.Forms.Label
    Friend WithEvents QaLabel As System.Windows.Forms.Label
    Friend WithEvents VarianceLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CommentBox As System.Windows.Forms.TextBox
End Class
