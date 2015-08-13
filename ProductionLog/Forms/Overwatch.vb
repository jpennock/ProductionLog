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
'
Public Class Overwatch
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
    End Function

    Public Function MakeNormal()
        SetWindowPos(Me.Handle(), HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOMOVE Or SWP_NOSIZE)
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
        MakeTopMost()
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
        If InExcel = True And InBB = True Then
            SetLabelText(DealershipLabel, CurrentBB)
        ElseIf InExcel = True And InBB = False Then
            SetLabelText(DealershipLabel, "Excel")
        ElseIf InYahoo = True Then
            SetLabelText(DealershipLabel, "Yahoo?")
        ElseIf InExcel = False Then
            SetLabelText(DealershipLabel, "")
        End If
    End Sub
    Public Sub Scan()
        Dim KVPList As New List(Of String)()
        Dim FileList As New List(Of String)()
        While 1
            'Palantir, the seer stone. Try and watch what excel files are being accessed to make workflow a bit simpler for the clerks/account managers.
            'For every process running
            KVPList.Clear()
            FileList.Clear()
            CheckTable.Clear()
            If BBComboBox.Items.Count > 0 Then
                For i = 0 To BBComboBox.Items.Count - 1
                    CheckTable.Rows.Add(BBComboBox.Items(i).ToString)
                    CheckTable.Rows(i)(1) = "f"
                Next
            End If
            If FileCheckTable.Rows.Count > 0 Then
                For i = 0 To FileCheckTable.Rows.Count - 1
                    FileCheckTable.Rows(i)(1) = "f"
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
                        FileCheckTable.Rows.Add(tosplit(0).ToString.Trim)
                    End If
                Next
            Next
            If KVPList.Contains("excel") Then
                InExcel = True
                For i = 0 To FileTable.Rows.Count - 2
                    If FileList.Contains(FileTable(i)(0).ToString) Then
                        'If BBComboBox.Items.Contains(FileTable(i)(0).ToString) Then 'check to see if you need to add the excel file open to the combobox.
                        'Else
                        '    AddComboItem(BBComboBox, FileTable(i)(0).ToString)
                        'End If
                        If CheckTable.Rows.Count > 0 Then
                            For c = 0 To CheckTable.Rows.Count - 1
                                Dim checkit As String = CheckTable.Rows(c)(0).ToString
                                For FC = 0 To FileTable.Rows.Count - 1
                                    If checkit = FileCheckTable(FC)(0).ToString Then
                                        FileCheckTable(FC)(1) = "t"
                                        CheckTable.Rows(c)(1) = "t"
                                    End If
                                Next
                            Next
                            For R = FileCheckTable.Rows.Count - 1 To 0 Step -1
                                If FileCheckTable.Rows(R)(1) = "t" Then
                                Else
                                    FileCheckTable.Rows.RemoveAt(R)
                                End If
                            Next
                            For R = CheckTable.Rows.Count - 1 To 0 Step -1
                                'MsgBox(CheckTable.Rows(R)(1).ToString)
                                If CheckTable.Rows(R)(1) = "t" Then
                                Else
                                    RemoveComboItem(BBComboBox, R)
                                End If
                            Next

                        Else
                            AddComboItem(BBComboBox, FileCheckTable(i)(0).ToString)
                        End If
                        'CurrentBB = FileTable(i)(0)
                        InBB = True
                        GoTo SLEEPYTIME
                    Else
                        InBB = False
                    End If
                Next
            ElseIf KVPList.Contains("Yahoo") Then

            Else
                InExcel = False
                InYahoo = False
            End If
SLEEPYTIME:
            'Counter += 1
            Thread.Sleep(1000)
        End While
    End Sub

    Public Sub AddComboItem(ByVal ComboObject As ComboBox, ByVal Value As String)
        If ComboObject.InvokeRequired Then
            Dim dlg As New AddComboItemDelegate(AddressOf AddComboItem)
            Me.Invoke(dlg, ComboObject, Value)
        Else
            ComboObject.Items.Add(Value)
            ComboObject.SelectedIndex = ComboObject.Items.Count - 1
        End If
    End Sub

    Public Sub RemoveComboItem(ByVal ComboObject As ComboBox, ByVal Index As Integer)
        If ComboObject.InvokeRequired Then
            Dim dlg As New RemoveComboItemDelegate(AddressOf RemoveComboItem)
            Me.Invoke(dlg, ComboObject, Index)
        Else
            ComboObject.Items.RemoveAt(Index)
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

    Private Sub MiniButton_Click(sender As Object, e As EventArgs) Handles MiniButton.Click
        MsgBox(Counter)
    End Sub
End Class