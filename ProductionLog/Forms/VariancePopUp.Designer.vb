<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VariancePopUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VariancePopUp))
        Me.FormSkin1 = New ProductionLog.FormSkin()
        Me.SaveButton = New ProductionLog.FlatButton()
        Me.FirstLien = New System.Windows.Forms.CheckBox()
        Me.InsuranceCap = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.FloorInsurance = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LandlordWaiver = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.OriginalStockCert = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.A940AnnualUnemployment = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.A941QuarterlyPayroll = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MonthlyInternalFinancialStatements = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AnnualPFS = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AnnualPersonalTaxReturns = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AnnualTaxReturns = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.YearEndAuditedFinancials = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.InternalYearEndFinancials = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DealerComboBox = New System.Windows.Forms.ComboBox()
        Me.FlatButton1 = New ProductionLog.FlatButton()
        Me.FormSkin1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.Gray
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.SaveButton)
        Me.FormSkin1.Controls.Add(Me.FirstLien)
        Me.FormSkin1.Controls.Add(Me.InsuranceCap)
        Me.FormSkin1.Controls.Add(Me.Label12)
        Me.FormSkin1.Controls.Add(Me.FloorInsurance)
        Me.FormSkin1.Controls.Add(Me.Label11)
        Me.FormSkin1.Controls.Add(Me.LandlordWaiver)
        Me.FormSkin1.Controls.Add(Me.Label10)
        Me.FormSkin1.Controls.Add(Me.OriginalStockCert)
        Me.FormSkin1.Controls.Add(Me.Label9)
        Me.FormSkin1.Controls.Add(Me.A940AnnualUnemployment)
        Me.FormSkin1.Controls.Add(Me.Label8)
        Me.FormSkin1.Controls.Add(Me.A941QuarterlyPayroll)
        Me.FormSkin1.Controls.Add(Me.Label7)
        Me.FormSkin1.Controls.Add(Me.MonthlyInternalFinancialStatements)
        Me.FormSkin1.Controls.Add(Me.Label6)
        Me.FormSkin1.Controls.Add(Me.AnnualPFS)
        Me.FormSkin1.Controls.Add(Me.Label5)
        Me.FormSkin1.Controls.Add(Me.AnnualPersonalTaxReturns)
        Me.FormSkin1.Controls.Add(Me.Label4)
        Me.FormSkin1.Controls.Add(Me.AnnualTaxReturns)
        Me.FormSkin1.Controls.Add(Me.Label3)
        Me.FormSkin1.Controls.Add(Me.YearEndAuditedFinancials)
        Me.FormSkin1.Controls.Add(Me.Label2)
        Me.FormSkin1.Controls.Add(Me.InternalYearEndFinancials)
        Me.FormSkin1.Controls.Add(Me.Label1)
        Me.FormSkin1.Controls.Add(Me.DealerComboBox)
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.Red
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(540, 505)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Compliance"
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.Transparent
        Me.SaveButton.BaseColor = System.Drawing.Color.DarkGreen
        Me.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveButton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.SaveButton.Location = New System.Drawing.Point(471, 470)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Rounded = False
        Me.SaveButton.Size = New System.Drawing.Size(66, 32)
        Me.SaveButton.TabIndex = 29
        Me.SaveButton.Text = "Save"
        Me.SaveButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FirstLien
        '
        Me.FirstLien.AutoSize = True
        Me.FirstLien.BackColor = System.Drawing.Color.Transparent
        Me.FirstLien.Location = New System.Drawing.Point(298, 165)
        Me.FirstLien.Name = "FirstLien"
        Me.FirstLien.Size = New System.Drawing.Size(92, 25)
        Me.FirstLien.TabIndex = 28
        Me.FirstLien.Text = "First Lien"
        Me.FirstLien.UseVisualStyleBackColor = False
        '
        'InsuranceCap
        '
        Me.InsuranceCap.AutoSize = True
        Me.InsuranceCap.BackColor = System.Drawing.Color.Transparent
        Me.InsuranceCap.Location = New System.Drawing.Point(298, 134)
        Me.InsuranceCap.Name = "InsuranceCap"
        Me.InsuranceCap.Size = New System.Drawing.Size(127, 25)
        Me.InsuranceCap.TabIndex = 27
        Me.InsuranceCap.Text = "Insurance Cap"
        Me.InsuranceCap.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(298, 421)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 21)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Floor Insurance"
        '
        'FloorInsurance
        '
        Me.FloorInsurance.CustomFormat = "yyyy-MM-dd"
        Me.FloorInsurance.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FloorInsurance.Location = New System.Drawing.Point(298, 445)
        Me.FloorInsurance.Name = "FloorInsurance"
        Me.FloorInsurance.ShowCheckBox = True
        Me.FloorInsurance.Size = New System.Drawing.Size(132, 29)
        Me.FloorInsurance.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(298, 365)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 21)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Landlord Waiver"
        '
        'LandlordWaiver
        '
        Me.LandlordWaiver.CustomFormat = "yyyy-MM-dd"
        Me.LandlordWaiver.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LandlordWaiver.Location = New System.Drawing.Point(298, 389)
        Me.LandlordWaiver.Name = "LandlordWaiver"
        Me.LandlordWaiver.ShowCheckBox = True
        Me.LandlordWaiver.Size = New System.Drawing.Size(132, 29)
        Me.LandlordWaiver.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(298, 309)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(141, 21)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Original Stock Cert"
        '
        'OriginalStockCert
        '
        Me.OriginalStockCert.CustomFormat = "yyyy-MM-dd"
        Me.OriginalStockCert.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.OriginalStockCert.Location = New System.Drawing.Point(298, 333)
        Me.OriginalStockCert.Name = "OriginalStockCert"
        Me.OriginalStockCert.ShowCheckBox = True
        Me.OriginalStockCert.Size = New System.Drawing.Size(132, 29)
        Me.OriginalStockCert.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(298, 253)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(202, 21)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "940 Annual Unemployment"
        '
        'A940AnnualUnemployment
        '
        Me.A940AnnualUnemployment.CustomFormat = "yyyy-MM-dd"
        Me.A940AnnualUnemployment.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.A940AnnualUnemployment.Location = New System.Drawing.Point(298, 277)
        Me.A940AnnualUnemployment.Name = "A940AnnualUnemployment"
        Me.A940AnnualUnemployment.ShowCheckBox = True
        Me.A940AnnualUnemployment.Size = New System.Drawing.Size(132, 29)
        Me.A940AnnualUnemployment.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(298, 197)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(159, 21)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "941 Quarterly Payroll"
        '
        'A941QuarterlyPayroll
        '
        Me.A941QuarterlyPayroll.CustomFormat = "yyyy-MM-dd"
        Me.A941QuarterlyPayroll.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.A941QuarterlyPayroll.Location = New System.Drawing.Point(298, 221)
        Me.A941QuarterlyPayroll.Name = "A941QuarterlyPayroll"
        Me.A941QuarterlyPayroll.ShowCheckBox = True
        Me.A941QuarterlyPayroll.Size = New System.Drawing.Size(132, 29)
        Me.A941QuarterlyPayroll.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(12, 421)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(272, 21)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Monthly Internal Financial Statements"
        '
        'MonthlyInternalFinancialStatements
        '
        Me.MonthlyInternalFinancialStatements.CustomFormat = "yyyy-MM-dd"
        Me.MonthlyInternalFinancialStatements.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MonthlyInternalFinancialStatements.Location = New System.Drawing.Point(12, 445)
        Me.MonthlyInternalFinancialStatements.Name = "MonthlyInternalFinancialStatements"
        Me.MonthlyInternalFinancialStatements.ShowCheckBox = True
        Me.MonthlyInternalFinancialStatements.Size = New System.Drawing.Size(132, 29)
        Me.MonthlyInternalFinancialStatements.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(12, 365)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 21)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Annual PFS"
        '
        'AnnualPFS
        '
        Me.AnnualPFS.CustomFormat = "yyyy-MM-dd"
        Me.AnnualPFS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.AnnualPFS.Location = New System.Drawing.Point(12, 389)
        Me.AnnualPFS.Name = "AnnualPFS"
        Me.AnnualPFS.ShowCheckBox = True
        Me.AnnualPFS.Size = New System.Drawing.Size(132, 29)
        Me.AnnualPFS.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(12, 309)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 21)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Annual Personal Tax Returns"
        '
        'AnnualPersonalTaxReturns
        '
        Me.AnnualPersonalTaxReturns.CustomFormat = "yyyy-MM-dd"
        Me.AnnualPersonalTaxReturns.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.AnnualPersonalTaxReturns.Location = New System.Drawing.Point(12, 333)
        Me.AnnualPersonalTaxReturns.Name = "AnnualPersonalTaxReturns"
        Me.AnnualPersonalTaxReturns.ShowCheckBox = True
        Me.AnnualPersonalTaxReturns.Size = New System.Drawing.Size(132, 29)
        Me.AnnualPersonalTaxReturns.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(12, 253)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 21)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Annual Tax Returns"
        '
        'AnnualTaxReturns
        '
        Me.AnnualTaxReturns.CustomFormat = "yyyy-MM-dd"
        Me.AnnualTaxReturns.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.AnnualTaxReturns.Location = New System.Drawing.Point(12, 277)
        Me.AnnualTaxReturns.Name = "AnnualTaxReturns"
        Me.AnnualTaxReturns.ShowCheckBox = True
        Me.AnnualTaxReturns.Size = New System.Drawing.Size(132, 29)
        Me.AnnualTaxReturns.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Year End Audited Financials"
        '
        'YearEndAuditedFinancials
        '
        Me.YearEndAuditedFinancials.CustomFormat = "yyyy-MM-dd"
        Me.YearEndAuditedFinancials.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.YearEndAuditedFinancials.Location = New System.Drawing.Point(12, 221)
        Me.YearEndAuditedFinancials.Name = "YearEndAuditedFinancials"
        Me.YearEndAuditedFinancials.ShowCheckBox = True
        Me.YearEndAuditedFinancials.Size = New System.Drawing.Size(132, 29)
        Me.YearEndAuditedFinancials.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(12, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Internal Year End Financials"
        '
        'InternalYearEndFinancials
        '
        Me.InternalYearEndFinancials.CustomFormat = "yyyy-MM-dd"
        Me.InternalYearEndFinancials.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.InternalYearEndFinancials.Location = New System.Drawing.Point(12, 165)
        Me.InternalYearEndFinancials.Name = "InternalYearEndFinancials"
        Me.InternalYearEndFinancials.ShowCheckBox = True
        Me.InternalYearEndFinancials.Size = New System.Drawing.Size(132, 29)
        Me.InternalYearEndFinancials.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Dealership:"
        '
        'DealerComboBox
        '
        Me.DealerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DealerComboBox.FormattingEnabled = True
        Me.DealerComboBox.Location = New System.Drawing.Point(12, 80)
        Me.DealerComboBox.Name = "DealerComboBox"
        Me.DealerComboBox.Size = New System.Drawing.Size(161, 29)
        Me.DealerComboBox.TabIndex = 3
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.Red
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatButton1.Location = New System.Drawing.Point(488, 3)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(43, 19)
        Me.FlatButton1.TabIndex = 2
        Me.FlatButton1.Text = "Done"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'VariancePopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 505)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VariancePopUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VariancePopUp"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As ProductionLog.FormSkin
    Friend WithEvents FlatButton1 As ProductionLog.FlatButton
    Friend WithEvents DealerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents InternalYearEndFinancials As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents FloorInsurance As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LandlordWaiver As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents OriginalStockCert As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents A940AnnualUnemployment As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents A941QuarterlyPayroll As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents MonthlyInternalFinancialStatements As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents AnnualPFS As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AnnualPersonalTaxReturns As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AnnualTaxReturns As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents YearEndAuditedFinancials As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FirstLien As System.Windows.Forms.CheckBox
    Friend WithEvents InsuranceCap As System.Windows.Forms.CheckBox
    Friend WithEvents SaveButton As ProductionLog.FlatButton
End Class
