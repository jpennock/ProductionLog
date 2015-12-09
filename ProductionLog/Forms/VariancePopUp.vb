Imports System.Text
Imports MySql.Data.MySqlClient
Public Class VariancePopUp


    Dim SqlConnectionString As String = "Server=192.168.1.34; Database=TimeLogDB; User id=clerk; Password=12345;" 'NUC Database
    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Me.Dispose()
    End Sub

    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub

    Private Sub VariancePopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim FillQuery As String = "Select Dealership from dealername order by Dealership ASC"
            Dim FillAdapt As New MySqlDataAdapter(FillQuery, SqlConnectionString)
            Dim FillTable As New DataTable
            FillAdapt.Fill(FillTable)

            For i = 1 To FillTable.Rows.Count - 1
                With DealerComboBox
                    .Items.Add(FillTable.Rows(i)(0))
                End With
            Next

        Catch ex As Exception
            MsgBox("Couldn't load the dealerships.. " & ex.ToString)
        End Try
    End Sub

    Private Sub DealerComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DealerComboBox.SelectedIndexChanged
        Try
            'MsgBox(DealerComboBox.SelectedItem.ToString) 'this will let me know if I chose the right value for the query below :)
            Dim Query As String = "Select internalyearendfinancials,yearendauditedfinancials,annualtaxreturns,annualpersonaltaxreturns,annualpfs,monthlyinternalfinancialstatements,941quarterlypayroll,940annualunemployment,originalstockcert,landlordwaiver,floorinsurance,insurancecap from dealername where dealership='" & DealerComboBox.SelectedItem.ToString & "'"
            Dim QueryAdapt As New MySqlDataAdapter(Query, SqlConnectionString)
            Dim QueryTable As New DataTable
            QueryAdapt.Fill(QueryTable)
            Try
                If IsDBNull(QueryTable.Rows(0)(0)) Then
                    InternalYearEndFinancials.Checked = False
                Else
                    InternalYearEndFinancials.Value = QueryTable.Rows(0)(0)
                End If

                If IsDBNull(QueryTable.Rows(0)(1)) Then
                    YearEndAuditedFinancials.Checked = False
                Else
                    YearEndAuditedFinancials.Value = QueryTable.Rows(0)(1)
                End If

                If IsDBNull(QueryTable.Rows(0)(2)) Then
                    AnnualTaxReturns.Checked = False
                Else
                    AnnualTaxReturns.Value = QueryTable.Rows(0)(2)
                End If

                If IsDBNull(QueryTable.Rows(0)(3)) Then
                    AnnualPersonalTaxReturns.Checked = False
                Else
                    AnnualPersonalTaxReturns.Value = QueryTable.Rows(0)(3)
                End If

                If IsDBNull(QueryTable.Rows(0)(4)) Then
                    AnnualPFS.Checked = False
                Else
                    AnnualPFS.Value = QueryTable.Rows(0)(4)
                End If

                If IsDBNull(QueryTable.Rows(0)(5)) Then
                    MonthlyInternalFinancialStatements.Checked = False
                Else
                    MonthlyInternalFinancialStatements.Value = QueryTable.Rows(0)(5)
                End If

                If IsDBNull(QueryTable.Rows(0)(6)) Then
                    A941QuarterlyPayroll.Checked = False
                Else
                    A941QuarterlyPayroll.Value = QueryTable.Rows(0)(6)
                End If

                If IsDBNull(QueryTable.Rows(0)(7)) Then
                    A940AnnualUnemployment.Checked = False
                Else
                    A940AnnualUnemployment.Value = QueryTable.Rows(0)(7)
                End If

                If IsDBNull(QueryTable.Rows(0)(8)) Then
                    OriginalStockCert.Checked = False
                Else
                    OriginalStockCert.Value = QueryTable.Rows(0)(8)
                End If

                If IsDBNull(QueryTable.Rows(0)(9)) Then
                    LandlordWaiver.Checked = False
                Else
                    LandlordWaiver.Value = QueryTable.Rows(0)(9)
                End If

                If IsDBNull(QueryTable.Rows(0)(10)) Then
                    FloorInsurance.Checked = False
                Else
                    'TO DO figure this out
                End If

                If IsDBNull(QueryTable.Rows(0)(10)) Then
                    InsuranceCap.Checked = False
                Else
                    'TO DO figure this out
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            Dim QueryBuilt As New StringBuilder
            QueryBuilt.Append("Update dealername SET  ") 'TO DO loop through the controls/objects and grab their values
        Catch ex As Exception

        End Try
    End Sub
End Class