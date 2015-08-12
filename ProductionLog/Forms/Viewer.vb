Imports System.Data.OleDb
Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.Net.Mail

Public Class Viewer
    'Dim ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\pcpserver\pl_share\PrimaLend\Collateral Management\Updates\Timelog.accdb" 'Shared DB file
    Dim SqlConnectionString As String = "Server=192.168.1.34; Database=TimeLog; User id=clerk; Password=12345;" 'NUC Database
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)



    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Me.Dispose()
    End Sub

    Private Sub Viewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TimeLogDBDataSet.jakcjarcifr' table. You can move, or remove it, as needed.
        Me.JakcjarcifrTableAdapter.Fill(Me.TimeLogDBDataSet.jakcjarcifr)
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs)


    End Sub
   
    Private Sub JakcjarcifrBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles JakcjarcifrBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.JakcjarcifrBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TimeLogDBDataSet)
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click

    End Sub

    Private Sub ToolStripTextBox1_Click_1(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click

    End Sub

    Private Sub ToolStripTextBox1_TextChanged(sender As Object, e As EventArgs) Handles ToolStripTextBox1.TextChanged
        Try
            Me.JakcjarcifrBindingSource.Filter = "VIN Like '%" & ToolStripTextBox1.Text & "%'"

        Catch ex As Exception

        End Try
    End Sub
End Class