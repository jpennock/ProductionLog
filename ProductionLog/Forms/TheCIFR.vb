Imports System.Text
Imports MySql.Data.MySqlClient

Public Class TheCIFR
    Dim SqlConnectionString As String = "Server=192.168.1.34; Database=TimeLog; User id=clerk; Password=12345; Convert zero datetime=True;" 'NUC Database 'CONVERT ZERO DATE TIME NEEDED FOR CIFR
    Dim ActiveTable As New DataTable 'Public for searching purposes
    Dim InactiveTable As New DataTable 'Public for searching purposes
    Dim SuccessSeconds As Integer = 0

    Private Sub TheCIFR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            EmpIDLabel.Text = Clerk.EmployeeID.Text
            JobIDLabel.Text = Clerk.IDBox.Text
            DealerNameLabel.Text = Clerk.DealerBox.Text
            Dim DealerNumber As String = "SELECT DealerID from Dealername where Dealership='" & DealerNameLabel.Text & "'"
            Dim DealerTable As New DataTable
            Dim DealerAdapt As New MySqlDataAdapter(DealerNumber, SqlConnectionString)
            DealerAdapt.Fill(DealerTable)
            DealerIDLabel.Text = DealerTable.Rows(0)(0)
            If Clerk.BatchIDLabel.Text <> "" Then
                For i = 0 To Clerk.BatchComboBox.Items.Count - 1
                    JobVinList.Items.Add(Clerk.BatchComboBox.Items(i))
                Next
            End If
        Catch ex As Exception
            SendError.Show()
            SendError.EmpIDLabel.Text = EmpIDLabel.Text
            SendError.ErrorRTB.Text = ex.ToString
        End Try
        Try
            Dim QueryActive As String = "SELECT Stock,CustomerName,DateSold,DateReceived,TitleAppReceipt,DateTitleAppReceiptRcvd,Title,DateTitleReceived,DealerasLienholder,TitleChainCorrect,BuyerSellerSigned,Stamped,AssignedToPL,DownPayment,AmountFinanced,NumberofPayments,PaymentType,VIN,Year,Make,Model,VehicleType,Miles,BuyersOrder,Warranty,BuyersGuide,CreditReport,OpenBankruptcy,DriversLicense,Insurance,GPSInstalled,GPSDisclosure,Arbitration,CoSigner,ConsentAuth,CreditAPP,CustomerPhone,Comments FROM autostarcifr where dealerid='" & DealerIDLabel.Text & "' AND Active='1' ORDER BY DateReceived ASC"
            Dim ActiveAdapt As New MySqlDataAdapter(QueryActive, SqlConnectionString)
            ActiveAdapt.Fill(ActiveTable)
            If ActiveTable.Rows.Count > 0 Then

                ActiveDGV.DataSource = ActiveTable
                ActiveDGV.AutoResizeColumns()
            End If
        Catch ex As Exception
            SendError.Show()
            SendError.EmpIDLabel.Text = EmpIDLabel.Text
            SendError.ErrorRTB.Text = ex.ToString
        End Try
        Try
            Dim QueryInactive As String = "SELECT Stock,CustomerName,DateSold,DateReceived,TitleAppReceipt,DateTitleAppReceiptRcvd,Title,DateTitleReceived,DealerasLienholder,TitleChainCorrect,BuyerSellerSigned,Stamped,AssignedToPL,DownPayment,AmountFinanced,NumberofPayments,PaymentType,VIN,Year,Make,Model,VehicleType,Miles,BuyersOrder,Warranty,BuyersGuide,CreditReport,OpenBankruptcy,DriversLicense,Insurance,GPSInstalled,GPSDisclosure,Arbitration,CoSigner,ConsentAuth,CreditAPP,CustomerPhone,Comments FROM autostarcifr where dealerid='" & DealerIDLabel.Text & "' AND Active='0'"
            Dim Inactiveadapt As New MySqlDataAdapter(QueryInactive, SqlConnectionString)
            Inactiveadapt.Fill(InactiveTable)
            If InactiveTable.Rows.Count > 0 Then
                InactiveDGV.DataSource = InactiveTable
                InactiveDGV.AutoResizeColumns()
                InactiveDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            End If
        Catch ex As Exception
            SendError.Show()
            SendError.EmpIDLabel.Text = EmpIDLabel.Text
            SendError.ErrorRTB.Text = ex.ToString
        End Try

    End Sub

    Private Sub ActvVINRadio_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ActvStockRadio_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ActvNameRadio_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ActvStockBox_TextChanged(sender As Object, e As EventArgs) Handles ActvStockBox.TextChanged
        If ActvStockBox.Text = "" Then
            ActiveTable.DefaultView.RowFilter = "stock like '%" & ActvStockBox.Text & "%'"
            ActiveDGV.DataSource = ActiveTable
            Exit Sub
        End If
        Try
            ActvNameBox.Text = ""
            ActvVINBox.Text = ""
            ActiveTable.DefaultView.RowFilter = "stock like '%" & ActvStockBox.Text & "%'"
            ActiveDGV.DataSource = ActiveTable
        Catch ex As Exception
            SendError.Show()
            SendError.EmpIDLabel.Text = EmpIDLabel.Text
            SendError.ErrorRTB.Text = ex.ToString
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ActvVINBox_TextChanged(sender As Object, e As EventArgs) Handles ActvVINBox.TextChanged
        If ActvVINBox.Text = "" Then
            ActiveTable.DefaultView.RowFilter = "vin like '%" & ActvVINBox.Text & "%'"
            ActiveDGV.DataSource = ActiveTable
            Exit Sub
        End If
        Try
            ActvStockBox.Text = ""
            ActvNameBox.Text = ""
            ActiveTable.DefaultView.RowFilter = "vin like '%" & ActvVINBox.Text & "%'"
            ActiveDGV.DataSource = ActiveTable
        Catch ex As Exception
            SendError.Show()
            SendError.EmpIDLabel.Text = EmpIDLabel.Text
            SendError.ErrorRTB.Text = ex.ToString
        End Try
    End Sub

    Private Sub ActvNameBox_TextChanged(sender As Object, e As EventArgs) Handles ActvNameBox.TextChanged
        If ActvNameBox.Text = "" Then
            ActiveTable.DefaultView.RowFilter = "customername like '%" & ActvNameBox.Text & "%'"
            ActiveDGV.DataSource = ActiveTable
            Exit Sub
        End If
        Try
            ActvStockBox.Text = ""
            ActvVINBox.Text = ""
            ActiveTable.DefaultView.RowFilter = "customername like '%" & ActvNameBox.Text & "%'"
            ActiveDGV.DataSource = ActiveTable
        Catch ex As Exception
            SendError.Show()
            SendError.EmpIDLabel.Text = EmpIDLabel.Text
            SendError.ErrorRTB.Text = ex.ToString
        End Try
    End Sub

    Private Sub JobVinList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles JobVinList.SelectedIndexChanged
        ActvVINBox.Text = JobVinList.Items(JobVinList.SelectedIndex).ToString
    End Sub

    Private Sub DoneButton_Click(sender As Object, e As EventArgs) Handles DoneButton.Click
        If MsgBox("Are you sure you'd like to finish? (This will end the job)", vbYesNo, "Are you sure?") = MsgBoxResult.Yes Then
            EndJob.Show()
            Me.Dispose()
        End If
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Try 'SAVE THE INFO
            Dim QueryBuilt As New StringBuilder
            For i = 0 To EditedList.Items.Count - 1
                ActvVINBox.Text = EditedList.Items(i)
                QueryBuilt.Clear()
                QueryBuilt.Append("UPDATE Autostarcifr SET ")
                For c = 0 To ActiveDGV.Columns.Count - 1
                    QueryBuilt.Append(ActiveDGV.Columns(c).Name & "=")
                    QueryBuilt.Append("'" & ActiveDGV.Rows(0).Cells(c).Value & "'")
                    If c < ActiveDGV.Columns.Count - 1 Then
                        QueryBuilt.Append(",")
                    End If
                Next
                QueryBuilt.Append("where VIN='" & EditedList.Items(i) & "'")
                MsgBox(QueryBuilt.ToString)
                Using Connection As New MySqlConnection(SqlConnectionString)
                    Dim Update As New MySqlCommand(QueryBuilt.ToString, Connection)
                    Connection.Open()
                    Update.ExecuteNonQuery()
                    Connection.Close()
                End Using
            Next
            EditedList.Items.Clear()
        Catch ex As Exception
            SendError.Show()
            SendError.EmpIDLabel.Text = EmpIDLabel.Text
            SendError.ErrorRTB.Text = ex.ToString
        End Try
    End Sub

    Private Sub ActiveDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ActiveDGV.CellContentClick

    End Sub

    Private Sub ActiveDGV_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles ActiveDGV.CellValueChanged
        Dim CellX As Integer = ActiveDGV.CurrentCellAddress.X
        Dim CellY As Integer = ActiveDGV.CurrentCellAddress.Y
        Try
            If EditedList.Items.Contains(ActiveDGV.Rows(CellY).Cells(17).Value) Then
                Exit Sub
            Else
                EditedList.Items.Add(ActiveDGV.Rows(CellY).Cells(17).Value)
            End If
        Catch ex As Exception
            SendError.Show()
            SendError.EmpIDLabel.Text = EmpIDLabel.Text
            SendError.ErrorRTB.Text = ex.ToString
        End Try

    End Sub

    Private Sub ActiveDGV_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles ActiveDGV.DataError
        MsgBox(ActiveDGV.CurrentCell.Value & " this doesn't fit the type of data required in this cell", vbOK, "Oops!")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        Try
            EditedList.Items.Remove(EditedList.SelectedIndex)
        Catch ex As Exception
            SendError.Show()
            SendError.EmpIDLabel.Text = EmpIDLabel.Text
            SendError.ErrorRTB.Text = ex.ToString
        End Try
    End Sub

    Private Sub SuccessTimer_Tick(sender As Object, e As EventArgs) Handles SuccessTimer.Tick
        Try
            If SuccessSeconds >= 5 Then
                SuccessLabel.Visible = False
                SuccessSeconds = 0
                SuccessTimer.Stop()
            Else
                SuccessLabel.Visible = True
                SuccessSeconds += 1
            End If
        Catch ex As Exception
            SendError.Show()
            SendError.EmpIDLabel.Text = EmpIDLabel.Text
            SendError.ErrorRTB.Text = ex.ToString
        End Try
    End Sub

    Private Sub EditedList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EditedList.SelectedIndexChanged
        ActvVINBox.Text = EditedList.SelectedItem.ToString
    End Sub
End Class