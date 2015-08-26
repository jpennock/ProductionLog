Imports System
Imports System.IO
Imports System.Collections
Imports System.Text
Imports System.Data.OleDb
Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Imports System.Threading

'Definitely the most ambitious workflow project to date, all of these DLLIMPORTS and PID functions are to watch what people are doing program wise and try to guess what jobs are being done
'based on that information. Otto will attempt to verify which job is being performed, but other than that, hopefully the clerks/acct managers won't have to worry about
'assigning themselves the jobs and actively open them. I will still probably have them finish the job.. Unless I see them close the window.
'7/8/15 I'm going to attempt to do this through multithreading. We will see how bad it ends up :)
'7/9/15 Multithreading is a success. THE PALANTIR IS ACTIVE, THEY ARE NOT ALL ACCOUNTED FOR.
'Some obvious issues thus far: Opening multiple excel windows. The program currently only sees and holds on to the first one it finds, I am trying to work on a dropbox idea that may help
'with how things are handled, but I'm not sure if that will really work. The best way to handle this is only allow one job at a time.
'as of 8/6/15 the drop box is mostly functional, but it can't seem to clear out the programs that are exited.
'8/18/15 The watching code is working fully. It always knows what excel file you are in and which one you close out of. 

Public Class Overwatch
    Dim TimerInt As Integer = 0
    Dim inJob As Boolean = False
    Dim IsTopMost As Boolean = False
    Dim SqlConnectionString As String = "Server=192.168.1.34; Database=TimeLogDB; User id=clerk; Password=12345;" 'NUC Database <--Being used now
    Dim FileQuery As String = "SELECT BBFileName,Dealership from Dealername" 'Get the borrowing base file names
    Dim FileTable As New DataTable 'this table will hold the bb file names
    Dim FileAdapt As New MySqlDataAdapter(FileQuery, SqlConnectionString) 'This is the adapter to get the BB file names (use this to fill the table)
    Public Palintir_Thread As Thread
    Dim InExcel As Boolean = False 'Are you in excel?
    Dim FileName As String = "" 'What is the file name that you are working in?
    Dim Counter As Integer = 0
    Dim CurrentBB As String = "" 'This should hold the filename better.
    Dim InBB As Boolean = False
    Dim InYahoo As Boolean = False
    Dim WindowList As New List(Of String)
    Dim CheckTable As New DataTable 'I'm going to try and fill this with the data in combo box and then use it to verify what should and shouldn't be in the drop box.
    Dim FileCheckTable As New DataTable 'Check the file list?

    <DllImport("user32.dll", SetLastError:=True)> _
    Private Shared Function SetWindowPos(ByVal hWnd As IntPtr, ByVal hWndInsertAfter As IntPtr, ByVal X As Integer, ByVal Y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal uFlags As Integer) As Boolean
    End Function

    Private Const SWP_NOSIZE As Integer = &H1
    Private Const SWP_NOMOVE As Integer = &H2

    Private Shared ReadOnly HWND_TOPMOST As New IntPtr(-1)
    Private Shared ReadOnly HWND_NOTOPMOST As New IntPtr(-2)

    Public Function MakeTopMost()
        SetWindowPos(Me.Handle(), HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE Or SWP_NOSIZE)
        IsTopMost = True
        Return Nothing
    End Function

    Public Function MakeNormal()
        SetWindowPos(Me.Handle(), HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOMOVE Or SWP_NOSIZE)
        IsTopMost = False
        Return Nothing
    End Function

    <DllImport("USER32.DLL")> _
    Private Shared Function GetShellWindow() As IntPtr
    End Function

    <DllImport("USER32.DLL")> _
    Private Shared Function GetWindowText(ByVal hWnd As IntPtr, ByVal lpString As StringBuilder, ByVal nMaxCount As Integer) As Integer
    End Function

    <DllImport("USER32.DLL")> _
    Private Shared Function GetWindowTextLength(ByVal hWnd As IntPtr) As Integer
    End Function

    <DllImport("user32.dll", SetLastError:=True)> _
    Private Shared Function GetWindowThreadProcessId(ByVal hWnd As IntPtr, <Out()> ByRef lpdwProcessId As UInt32) As UInt32
    End Function

    <DllImport("USER32.DLL")> _
    Private Shared Function IsWindowVisible(ByVal hWnd As IntPtr) As Boolean
    End Function

    Private Delegate Function EnumWindowsProc(ByVal hWnd As IntPtr, ByVal lParam As Integer) As Boolean

    <DllImport("USER32.DLL")> _
    Private Shared Function EnumWindows(ByVal enumFunc As EnumWindowsProc, ByVal lParam As Integer) As Boolean
    End Function

    Public Delegate Sub SetLabelTextDelegate(ByVal LabelObject As Label, ByVal Value As String)
    Public Delegate Sub AddComboItemDelegate(ByVal ComboObject As ComboBox, ByVal Value As String)
    Public Delegate Sub RemoveComboItemDelegate(ByVal ComboObject As ComboBox, ByVal Index As Integer)
    Public Delegate Sub CheckMessagesDelegate(ByVal IDBox As TextBox, ID As String)

    Private hShellWindow As IntPtr = GetShellWindow()
    Private dictWindows As New Dictionary(Of IntPtr, String)
    Private currentProcessID As Integer

    Private Function enumWindowsInternal(ByVal hWnd As IntPtr, ByVal lParam As Integer) As Boolean
        If (hWnd <> hShellWindow) Then
            Dim windowPid As UInt32
            If Not IsWindowVisible(hWnd) Then
                Return True
            End If
            Dim length As Integer = GetWindowTextLength(hWnd)
            If (length = 0) Then
                Return True
            End If
            GetWindowThreadProcessId(hWnd, windowPid)
            If (windowPid <> currentProcessID) Then
                Return True
            End If
            Dim stringBuilder As New System.Text.StringBuilder(length)
            GetWindowText(hWnd, stringBuilder, (length + 1))
            dictWindows.Add(hWnd, stringBuilder.ToString)
        End If
        Return True
    End Function
    Public Function GetOpenWindowsFromPID(ByVal processID As Integer) As IDictionary(Of IntPtr, String)
        dictWindows.Clear()
        currentProcessID = processID
        EnumWindows(AddressOf enumWindowsInternal, 0)
        Return dictWindows
    End Function
    Private Sub Overwatch_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim scr = Screen.FromPoint(Me.Location)
        Me.Location = New Point(scr.WorkingArea.Right - Me.Width, scr.WorkingArea.Top)

        Dim InJobQuery As String = "SELECT JobID From Workflow where empid='" & EmpIDLabel.Text & "' and job like '%CIFR%' and datestarted is not null and datecompleted is null"
        Dim InJobTable As New DataTable
        Dim InJobAdapt As New MySqlDataAdapter(InJobQuery, SqlConnectionString)
        InJobAdapt.Fill(InJobTable)
        If InJobTable.Rows.Count > 0 Then
            inJob = True
        End If
        MakeTopMost()
        IsTopMost = True
        FileAdapt.Fill(FileTable) 'Hopefully you won't have to fill this one more than once per load. I'll make sure that is the case through some tests
        CheckTable.Columns.Add("Name")
        CheckTable.Columns.Add("Remove")
        FileCheckTable.Columns.Add("Name")
        FileCheckTable.Columns.Add("Remove")
        Palintir_Thread = New Thread(AddressOf Scan)
        Palintir_Thread.IsBackground = True
        Palintir_Thread.Start()
    End Sub
    Private Sub Palantiri_Tick(sender As Object, e As EventArgs) Handles Palantiri.Tick
        If Me.Size.Height > 60 And TimerInt < 3 Then
            MinimizeLabel.Visible = True
            TimerInt += 1
        Else
            Palantiri.Stop()
            MinimizeLabel.Visible = False
        End If
    End Sub
    Public Sub Scan()
        'Filetable is a one time fill table that shows what the BB names should be. Use this to check to see if the excel file opened is one of our BBs
        'Checktable will be the data in the combo box, to verify if these windows are still open.
        'FileCheckTable is the table that I will use to verify the name of the BB opened with the names of the BBs in the database. 
        'This one can change, since it should just be what is currently opened.
        Dim KVPList As New List(Of String)()
        Dim FileList As New List(Of String)()
        While 1
            Dim ISAM As Boolean = False 'This part checks to see if you are an account manager. If you are, then it won't open the showjob window, since that will get really annoying.
            Dim AMQuery As String = "select * from accountmanager where empid=" & EmpIDLabel.Text & " and isactive = 1"
            Dim AMAdapt As New MySqlDataAdapter(AMQuery, SqlConnectionString)
            Dim AMtable As New DataTable
            AMAdapt.Fill(AMtable)
            If AMtable.Rows.Count > 0 Then
                inJob = True
            Else
                inJob = False
            End If
            'Palantir, the seer stone. Try and watch what excel files are being accessed to make workflow a bit simpler for the clerks/account managers.
            'For every process running
            KVPList.Clear()
            FileList.Clear()
            CheckTable.Clear()
            FileCheckTable.Clear()
            If BBComboBox.Items.Count > 0 Then
                For i = 0 To BBComboBox.Items.Count - 1
                    CheckTable.Rows.Add({BBComboBox.Items(i).ToString, "f"})
                Next
            End If
            For Each P As Process In Process.GetProcesses
                'Get a list of ALL of the open windows associated with the process   
                Dim windows As IDictionary(Of IntPtr, String) = GetOpenWindowsFromPID(P.Id)
                For Each kvp As KeyValuePair(Of IntPtr, String) In windows
                    'Dim NowTime As String = DateTime.Now.ToString("HH:mm:ss")
                    'Dim NowDate As String = DateTime.Now.ToString("yyyy-MM-dd")
                    'Dim InsertLog As String = "INSERT INTO Palantir (EmpID,Date,Time,Window) VALUES ('" & EmpIDLabel.Text & "','" & NowDate & "','" & NowTime & "','" & kvp.Value.ToString & "');"
                    'Using TheConnection As New MySqlConnection(SqlConnectionString)
                    '    Dim InsertCommand As New MySqlCommand(InsertLog, TheConnection)
                    '    TheConnection.Open()
                    '    InsertCommand.ExecuteNonQuery()
                    '    TheConnection.Close()
                    'End Using
                    'If WindowList.Contains(kvp.Value.ToString) Then
                    'Else
                    '    WindowList.Add(kvp.Value.ToString)
                    'End If
                    Dim tosplit() As String = kvp.Value.ToString.Split(New Char() {"-"c})
                    If tosplit.Count > 1 Then
                        KVPList.Add(tosplit(1).ToString.Trim.ToLower)
                        KVPList.Add(tosplit(0).ToString.Trim.ToLower)
                        FileList.Add(tosplit(0).ToString.Trim)
                        FileCheckTable.Rows.Add({tosplit(0).ToString.Trim, "f"}) 'I'll try using F to start showing that it shouldn't be added to the list? Then if it qualifies, add it to the list, otherwise leave it alone.
                    End If
                Next
            Next
            If KVPList.Contains("excel") Or KVPList.Contains("access") Then
                For i = 0 To FileCheckTable.Rows.Count - 1 'first check which ones match the BB database.
                    For bb = 0 To FileTable.Rows.Count - 1
                        If FileCheckTable.Rows(i)(0).ToString = FileTable.Rows(bb)(0).ToString Then
                            FileCheckTable.Rows(i)(1) = "b" 'if they have a b, work from there.
                            FileCheckTable.Rows(i)(0) = FileTable.Rows(bb)(1).ToString
                        End If
                    Next
                Next
                If CheckTable.Rows.Count > 0 Then
                    For i = CheckTable.Rows.Count - 1 To 0 Step -1 'check this list against the current combo box contents (backwards for no reason. I was going to try and delete it right away, but that wouldn't work :( )
                        For ck = 0 To FileCheckTable.Rows.Count - 1
                            If CheckTable.Rows(i)(0) = FileCheckTable.Rows(ck)(0) Then
                                CheckTable.Rows(i)(1) = "t" 't for true. If true, I'll leave it in. If the F is still there, toast.
                            End If
                        Next
                    Next
                    For i = CheckTable.Rows.Count - 1 To 0 Step -1 'use this one to remove any checktable item that is marked f still, proving that you aren't currently open in any of those windows
                        If CheckTable.Rows(i)(1) = "f" Then
                            ' MsgBox("remove")
                            'JobEnd(CheckTable.Rows(i)(0).ToString) 'This only works of there are more than one BBs open. I'll see what else I can do 8/21/15
                            RemoveComboItem(BBComboBox, i)
                        End If
                    Next
                End If
                For i = 0 To FileCheckTable.Rows.Count - 1
                    If FileCheckTable.Rows(i)(1) = "b" Then
                        'MsgBox("add")
                        AddComboItem(BBComboBox, FileCheckTable.Rows(i)(0).ToString)
                    End If
                Next
                InExcel = True
            Else
                RemoveComboItem(BBComboBox, 0) 'the index here will have to be dynamic in order to properly remove the item.
                InExcel = False
            End If
            If Me.Size.Height <= 60 Then
                Dim MessageQ As String = "Select * from messages where empid=" & EmpIDLabel.Text & " and isread=0"
                Dim MessageT As New DataTable
                Dim MessageA As New MySqlDataAdapter(MessageQ, SqlConnectionString)
                MessageA.Fill(MessageT)
                If MessageT.Rows.Count > 0 Then
                    CheckMessages(IDTextBox, MessageT.Rows(0)(0).ToString)
                End If
            End If
SLEEPYTIME:
            'Counter += 1
            Thread.Sleep(500)
        End While
    End Sub

    Public Sub AddComboItem(ByVal ComboObject As ComboBox, ByVal Value As String)
        If Not ComboObject.Items.Contains(Value) Then
            If ComboObject.InvokeRequired Then
                Dim dlg As New AddComboItemDelegate(AddressOf AddComboItem)
                Me.Invoke(dlg, ComboObject, Value)
            Else
                ComboObject.Items.Add(Value)
                ComboObject.SelectedIndex = ComboObject.Items.Count - 1
                If inJob = False Then
                    ShowJobs()
                End If
            End If
        End If
    End Sub

    Public Sub RemoveComboItem(ByVal ComboObject As ComboBox, ByVal Index As Integer)
        If ComboObject.Items.Count > 0 Then
            If ComboObject.InvokeRequired Then
                Dim dlg As New RemoveComboItemDelegate(AddressOf RemoveComboItem)
                Me.Invoke(dlg, ComboObject, Index)
            Else
                JobEnd(ComboObject.Items(Index).ToString)
                ComboObject.Items.RemoveAt(Index)
            End If
        End If
    End Sub

    Public Sub SetLabelText(ByVal LabelObject As Label, ByVal Value As String)
        If LabelObject.InvokeRequired Then
            Dim dlg As New SetLabelTextDelegate(AddressOf SetLabelText)
            Me.Invoke(dlg, New Object() {Value})
        Else
            LabelObject.Text = Value
        End If
    End Sub
    Private Sub MiniButton_Click(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ExpandButton.Click
        Try
            If IDTextBox.Text = "" Then
                Exit Sub
            End If
            Using connector As New MySqlConnection(SqlConnectionString)
                Dim UpdateQ As String = "update messages set isread=1 where uniqueid=" & IDTextBox.Text
                Dim UpdateCommand As New MySqlCommand(UpdateQ, connector)
                connector.Open()
                UpdateCommand.ExecuteNonQuery()
                connector.Close()
            End Using
            Me.Size = New Size(Me.Size.Width, 60)
            'ExpandButton.Location = New Point(103, 50)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BBComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BBComboBox.SelectedIndexChanged

    End Sub

    Private Sub BBComboBox_TextChanged(sender As Object, e As EventArgs) Handles BBComboBox.TextChanged

    End Sub

    Public Function ShowJobs() 'I can get things to interact and change the actual overwatch form, but I can't get other forms to pop up or do what I need. :( 8/18/15 Fixed 8/19/15
        FileCabinetPopup.Show()
        'Try
        '    Dim JobTable As New DataTable
        '    Dim JobQuery As String = "SELECT JobID,BatchID,DateAssigned,Dealer,Job,Quantity From workflow where dealer='" & BBComboBox.Items(BBComboBox.SelectedIndex).ToString & "' and job like '%CIFR%' and datecompleted is null"
        '    Dim JobAdapt As New MySqlDataAdapter(JobQuery, SqlConnectionString)
        '    JobAdapt.Fill(JobTable)
        '    If JobTable.Rows.Count > 1 Then 'If there is more than one CIFR job available.
        '        FileCabinetPopup.Show()
        '        For i = 0 To JobTable.Rows.Count - 1
        '            FileCabinetPopup.JobCheckListBox.Items.Add(JobTable.Rows(i)(0).ToString & "-" & JobTable.Rows(i)(1).ToString & "-" & JobTable.Rows(i)(3) & "-" & JobTable.Rows(i)(4).ToString)
        '        Next
        '        For c = FileCabinetPopup.JobCheckListBox.Items.Count - 1 To 0 Step -1
        '            FileCabinetPopup.JobCheckListBox.SetItemChecked(c, True)
        '        Next

        '    ElseIf JobTable.Rows.Count = 1 Then 'If there is only the one CIFR job available, assign that one.
        '        MsgBox("Just one")
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try
        'Try
        '    TimerInt = 0
        '    Palantiri.Start()
        '    Me.Size = New Size(Me.Size.Width, 600)
        '    FileCabinetPopup.Show()
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try
        Return Nothing
    End Function
    Public Function JobEnd(ByVal Dealer As String) 'This now only works with ONE dealership. I'll refine it as time goes on. 8/21/15.
        'MsgBox("Test : " & Dealer)
        Return Nothing
    End Function
    Private Sub FlatClose1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExpandButton_MouseHover(sender As Object, e As EventArgs) Handles ExpandButton.MouseHover

    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Public Function CheckMessages(ByVal IDBox As TextBox, ByVal ID As String)
        If IDBox.InvokeRequired Then
            Dim dlg As New CheckMessagesDelegate(AddressOf CheckMessages)
            Me.Invoke(dlg, IDBox, ID)
        Else
            IDBox.Text = ID
        End If
        Return Nothing
    End Function

    Private Sub IDTextBox_TextChanged(sender As Object, e As EventArgs) Handles IDTextBox.TextChanged
        Try
            Dim BodyQ As String = "Select MessageBody from messages where uniqueid=" & IDTextBox.Text
            Dim BodyA As New MySqlDataAdapter(BodyQ, SqlConnectionString)
            Dim BodyT As New DataTable
            BodyA.Fill(BodyT)
            MessageBodyTextBox.Text = BodyT.Rows(0)(0).ToString
            Me.Size = New Size(Me.Size.Width, 250)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class