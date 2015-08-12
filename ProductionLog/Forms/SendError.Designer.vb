<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SendError
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SendError))
        Me.ErrorRTB = New System.Windows.Forms.RichTextBox()
        Me.CommentBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SendButton = New System.Windows.Forms.Button()
        Me.NoButton = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.EmpIDLabel = New System.Windows.Forms.Label()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ErrorRTB
        '
        Me.ErrorRTB.Location = New System.Drawing.Point(12, 58)
        Me.ErrorRTB.Name = "ErrorRTB"
        Me.ErrorRTB.Size = New System.Drawing.Size(494, 206)
        Me.ErrorRTB.TabIndex = 0
        Me.ErrorRTB.Text = ""
        '
        'CommentBox
        '
        Me.CommentBox.Location = New System.Drawing.Point(12, 303)
        Me.CommentBox.Name = "CommentBox"
        Me.CommentBox.Size = New System.Drawing.Size(494, 20)
        Me.CommentBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(427, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Something went wrong. Please help Joe out by sending this"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(160, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "error report to his log!"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 284)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(477, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "A brief description of what you were doing (please no commas or single quotes)"
        '
        'SendButton
        '
        Me.SendButton.Location = New System.Drawing.Point(224, 329)
        Me.SendButton.Name = "SendButton"
        Me.SendButton.Size = New System.Drawing.Size(75, 23)
        Me.SendButton.TabIndex = 5
        Me.SendButton.Text = "Send it!"
        Me.SendButton.UseVisualStyleBackColor = True
        '
        'NoButton
        '
        Me.NoButton.Location = New System.Drawing.Point(431, 329)
        Me.NoButton.Name = "NoButton"
        Me.NoButton.Size = New System.Drawing.Size(75, 23)
        Me.NoButton.TabIndex = 6
        Me.NoButton.Text = "No thanks!"
        Me.NoButton.UseVisualStyleBackColor = True
        Me.NoButton.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(425, 35)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(78, 17)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Connected"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'EmpIDLabel
        '
        Me.EmpIDLabel.AutoSize = True
        Me.EmpIDLabel.Location = New System.Drawing.Point(9, 39)
        Me.EmpIDLabel.Name = "EmpIDLabel"
        Me.EmpIDLabel.Size = New System.Drawing.Size(13, 13)
        Me.EmpIDLabel.TabIndex = 8
        Me.EmpIDLabel.Text = "0"
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.Location = New System.Drawing.Point(9, 338)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(13, 13)
        Me.VersionLabel.TabIndex = 9
        Me.VersionLabel.Text = "0"
        '
        'SendError
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 362)
        Me.ControlBox = False
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.EmpIDLabel)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.NoButton)
        Me.Controls.Add(Me.SendButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CommentBox)
        Me.Controls.Add(Me.ErrorRTB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SendError"
        Me.Text = "Uh oh!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ErrorRTB As System.Windows.Forms.RichTextBox
    Friend WithEvents CommentBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SendButton As System.Windows.Forms.Button
    Friend WithEvents NoButton As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents EmpIDLabel As System.Windows.Forms.Label
    Friend WithEvents VersionLabel As System.Windows.Forms.Label
End Class
