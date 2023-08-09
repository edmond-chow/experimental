Imports TicTacToeLibrary.Base
Imports System.Runtime.InteropServices
Friend Class Form
    Dim Showing As Boolean = True
    Dim WonCount As Integer = 0
    Dim TiedCount As Integer = 0
    Dim LostCount As Integer = 0
    Dim BaseString As String = ""
    Dim OutputString As String = ""
    Dim FirstOutput As Boolean = True
    Dim FirstBugs As Boolean = True
    Dim DebugMode As Boolean = False
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Basic.Title
        For Each arg As String In Environment.GetCommandLineArgs()
            If arg = "Debug" Then
                DebugMode = True
            End If
        Next
        If DebugMode = False Then
            dataName = "console"
        Else
            dataName = "debug"
        End If
        Win32.AllocConsole()
        Console.Clear()
        If DebugMode = False Then
            Console.Title = "TicTacToe Testing Console"
        Else
            Console.Title = "TicTacToe DebugMode Testing Console"
            Basic.ClickBase(TicTacToeBaseControl.D)
        End If
        Console.BackgroundColor = ConsoleColor.Black
        BaseString = "[Startup] on " + String.Format("{0:dd/MM/yyyy}", DateTime.Now) + " at " + String.Format("{0:HH:mm:ss}", DateTime.Now) + vbNewLine
        If My.Computer.FileSystem.FileExists(dataName + ".log") = True Then
            Try
                For Each Line As String In System.IO.File.ReadLines(dataName + ".log")
                    If Line.Contains("Won") = True Then
                        WonCount = WonCount + 1
                    End If
                    If Line.Contains("Tied") = True Then
                        TiedCount = TiedCount + 1
                    End If
                    If Line.Contains("Lost") = True Then
                        LostCount = LostCount + 1
                    End If
                Next
            Catch ex As System.IO.IOException
                End
            End Try
        End If
        Basic.AutoDebugging = True
        Basic.Lock = True
        Dim Rand As Integer = RndRemove(9, 1, Basic.GetRemoves())
        Basic.ClickBase(Rand)
    End Sub
    Private Sub Basic_Click(sender As Object, e As EventArgs) Handles Basic.TicTacToeClick
        Me.Text = Basic.Title
    End Sub
    Private Sub Basic_TicTacToeKeyDown(sender As Object, e As KeyEventArgs) Handles Basic.TicTacToeKeyDown
        Me.Text = Basic.Title
    End Sub
    Private Sub Basic_TicTacToeNewRound(sender As Object, e As TicTacToeRoundEventArgs) Handles Basic.TicTacToeNewRound
        If Basic.Round = 1 Then
            If Basic.Mode = TicTacToeMode.GeneralAttack Or Basic.Mode = TicTacToeMode.DebugAttack Then
                Console.ForegroundColor = ConsoleColor.DarkRed
                Console.Write("[Attacker]")
                OutputString = OutputString + "[Attacker]"
            Else
                Console.ForegroundColor = ConsoleColor.DarkMagenta
                Console.Write("[Defender]")
                OutputString = OutputString + "[Defender]"
            End If
            Console.Write(" ")
            OutputString = OutputString + " "
        End If
        If Basic.Round <= 9 Then
            If DebugMode = False Then
                If e.AIDetails = "(NonAI)" Then
                    Console.ForegroundColor = ConsoleColor.Yellow
                    Console.Write(CType(e.HasClicked, Integer).ToString)
                    OutputString = OutputString + CType(e.HasClicked, Integer).ToString
                Else
                    Console.ForegroundColor = ConsoleColor.Cyan
                    Console.Write(CType(e.HasClicked, Integer).ToString + "(" + e.AIDetails + ")")
                    OutputString = OutputString + CType(e.HasClicked, Integer).ToString + "(" + e.AIDetails + ")"
                End If
            Else
                If e.AIDetails = "([Debug]Player)" Then
                    Console.ForegroundColor = ConsoleColor.Yellow
                    Console.Write(CType(e.HasClicked, Integer).ToString + "(Player)")
                    OutputString = OutputString + CType(e.HasClicked, Integer).ToString + "(Player)"
                Else
                    Console.ForegroundColor = ConsoleColor.Cyan
                    Console.Write(CType(e.HasClicked, Integer).ToString + "(AI)")
                    OutputString = OutputString + CType(e.HasClicked, Integer).ToString + "(AI)"
                End If
            End If
            Console.Write(" > ")
            OutputString = OutputString + " > "
            Console.ForegroundColor = ConsoleColor.DarkGreen
        End If
    End Sub
    Private Sub TicTacToeTestingTimer_Tick(sender As Object, e As EventArgs) Handles TicTacToeTestingTimer.Tick
        Basic.ClickBase(TicTacToeBaseControl.ButtonChange)
        Dim Rand As Integer = RndRemove(9, 1, Basic.GetRemoves())
        Basic.ClickBase(Rand)
    End Sub
    Private Sub Basic_TicTacToeHasResult(sender As Object, e As TicTacToeResultEventArgs) Handles Basic.TicTacToeHasResult
        If e.Result = TicTacToeResult.Won Then
            WonCount = WonCount + 1
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Win")
            OutputString = OutputString + "Win"
        ElseIf e.Result = TicTacToeResult.Tied Then
            TiedCount = TiedCount + 1
            Console.ForegroundColor = ConsoleColor.Blue
            Console.WriteLine("Tied")
            OutputString = OutputString + "Tied"
        ElseIf e.Result = TicTacToeResult.Lost Then
            LostCount = LostCount + 1
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("Lost")
            OutputString = OutputString + "Lost"
        End If
        If e.Result = TicTacToeResult.Won Then
            BugsNext()
        End If
        BasicNext()
    End Sub
    Dim bugs As System.IO.StreamWriter
    Dim HasBugs As System.IO.StreamWriter
    Private Sub BugsNext()
        If DebugMode = False Then
            If FirstBugs = True Then
                Try
                    bugs = My.Computer.FileSystem.OpenTextFileWriter("bugs.log", True)
                    HasBugs = My.Computer.FileSystem.OpenTextFileWriter(".bugs", True)
                    System.IO.File.SetAttributes(".bugs", IO.FileAttributes.Hidden)
                    FirstBugs = False
                    bugs.WriteLine(BaseString + OutputString)
                Catch ex As System.IO.IOException
                    End
                End Try
            Else
                bugs.WriteLine(OutputString)
                bugs.Close()
                bugs = My.Computer.FileSystem.OpenTextFileWriter("bugs.log", True)
            End If
        End If
    End Sub
    Dim dataName As String = ""
    Dim data As System.IO.StreamWriter
    Dim HasData As System.IO.StreamWriter
    Private Sub BasicNext()
        If DebugMode = False Then
            Console.Title = "TicTacToe Testing Console (Game: " + (WonCount + TiedCount + LostCount).ToString + ")[Won: " + (WonCount / (WonCount + TiedCount + LostCount) * 100).ToString + "%, Tied: " + (TiedCount / (WonCount + TiedCount + LostCount) * 100).ToString + "%, Lost: " + (LostCount / (WonCount + TiedCount + LostCount) * 100).ToString + "%]"
            dataName = "console"
        Else
            Console.Title = "TicTacToe DebugMode Testing Console (Game: " + (WonCount + TiedCount + LostCount).ToString + ")[Won: " + (WonCount / (WonCount + TiedCount + LostCount) * 100).ToString + "%, Tied: " + (TiedCount / (WonCount + TiedCount + LostCount) * 100).ToString + "%, Lost: " + (LostCount / (WonCount + TiedCount + LostCount) * 100).ToString + "%]"
            dataName = "debug"
        End If
        If FirstOutput = True Then
            Try
                data = My.Computer.FileSystem.OpenTextFileWriter(dataName + ".log", True)
                HasData = My.Computer.FileSystem.OpenTextFileWriter("." + dataName, True)
                System.IO.File.SetAttributes("." + dataName, IO.FileAttributes.Hidden)
                FirstOutput = False
                data.WriteLine(BaseString + OutputString)
            Catch ex As System.IO.IOException
                End
            End Try
        Else
            data.WriteLine(OutputString)
            data.Close()
            data = My.Computer.FileSystem.OpenTextFileWriter(dataName + ".log", True)
        End If
        OutputString = ""
    End Sub
    Private Sub MyNotifyIcon_Click(sender As Object, e As EventArgs) Handles MyNotifyIcon.Click
        If Showing = True Then
            Me.Hide()
            Win32.ShowWindow(Win32.GetConsoleWindow(), Win32.SW_HIDE)
        Else
            Me.Show()
            Win32.ShowWindow(Win32.GetConsoleWindow(), Win32.SW_SHOW)
        End If
        Showing = Not Showing
    End Sub
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If System.Diagnostics.Process.GetProcessesByName("過三關").Count = 0 Then
            If My.Computer.FileSystem.FileExists("過三關.exe") = True Then
                System.Diagnostics.Process.Start("過三關.exe")
            End If
        End If
    End Sub
End Class
Friend Class Win32
    Public Const SW_HIDE As Integer = 0
    Public Const SW_SHOW As Integer = 5
    <DllImport("kernel32.dll")> Public Shared Function AllocConsole() As Boolean
    End Function
    <DllImport("kernel32.dll")> Public Shared Function FreeConsole() As Boolean
    End Function
    <DllImport("kernel32.dll")> Public Shared Function GetConsoleWindow() As IntPtr
    End Function
    <DllImport("user32.dll")> Public Shared Function ShowWindow(ByVal hWnd As IntPtr, ByVal nCmdShow As Integer) As Boolean
    End Function
End Class
