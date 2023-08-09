Friend Class Form
    Dim IsTesting As Boolean = False
    Dim dataName As String = ""
    Dim temp As String = ".TicTacToe"
    Dim tempData As System.IO.StreamWriter
    Private Sub Form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        tempData.Close()
    End Sub
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Basic.Title
        If System.Diagnostics.Process.GetProcessesByName("TicTacToeConsole").Count <> 0 Then
            IsTesting = True
        End If
    End Sub
    Private Sub Basic_Click(sender As Object, e As EventArgs) Handles Basic.TicTacToeClick
        Me.Text = Basic.Title
    End Sub
    Private Sub Basic_TicTacToeKeyDown(sender As Object, e As KeyEventArgs) Handles Basic.TicTacToeKeyDown
        Me.Text = Basic.Title
        If e.KeyCode = Keys.A And My.Computer.FileSystem.FileExists("TicTacToeConsole.exe") = True And System.Diagnostics.Process.GetProcessesByName("TicTacToeConsole").Count = 0 Then
            If Basic.Mode = TicTacToeLibrary.Base.TicTacToeMode.DebugAttack Or Basic.Mode = TicTacToeLibrary.Base.TicTacToeMode.DebugDefend Then
                System.Diagnostics.Process.Start("TicTacToeConsole.exe", "Debug")
            Else
                System.Diagnostics.Process.Start("TicTacToeConsole.exe")
            End If
            IsTesting = True
        End If
    End Sub
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If IsTesting = True Then
            Me.Hide()
            If System.Diagnostics.Process.GetProcessesByName("TicTacToeConsole").Count = 0 Then
                IsTesting = False
                Dim BaseString = "[Shutdown] on " + String.Format("{0:dd/MM/yyyy}", DateTime.Now) + " at " + String.Format("{0:HH:mm:ss}", DateTime.Now)
                Dim Shutdown As Boolean = False
                If My.Computer.FileSystem.FileExists(".console") = True Then
                    My.Computer.FileSystem.DeleteFile(".console")
                    dataName = "console"
                    Shutdown = True
                End If
                If My.Computer.FileSystem.FileExists(".debug") = True Then
                    My.Computer.FileSystem.DeleteFile(".debug")
                    dataName = "debug"
                    Shutdown = True
                End If
                If Shutdown = True Then
                    Dim data As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(dataName + ".log", True)
                    data.WriteLine(BaseString)
                    data.Close()
                    If My.Computer.FileSystem.FileExists(".bugs") And dataName <> "debug" Then
                        My.Computer.FileSystem.DeleteFile(".bugs")
                        Dim bugs As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("bugs.log", True)
                        bugs.WriteLine(BaseString)
                        bugs.Close()
                    End If
                End If
            End If
        Else
            Me.Show()
            If System.Diagnostics.Process.GetProcessesByName("TicTacToeConsole").Count <> 0 Then
                IsTesting = True
            End If
        End If
    End Sub
    Private Sub Basic_TicTacToeStartUp(sender As Object, e As TicTacToeLibrary.Base.TicTacToeStartUpEventArgs) Handles Basic.TicTacToeStartUp
        Try
            Dim Lines() As String = System.IO.File.ReadAllLines(temp)
            Dim Mode As TicTacToeLibrary.Base.TicTacToeMode = CType(CType(Lines(0), Integer), TicTacToeLibrary.Base.TicTacToeMode)
            Dim Player(Lines.Length - 2) As TicTacToeLibrary.Base.TicTacToeBaseControl
            For i As Integer = 0 To Lines.Length - 2
                Player(i) = CType(CType(Lines(i + 1), Integer), TicTacToeLibrary.Base.TicTacToeBaseControl)
            Next
            Basic.SetBase(Mode, Player)
            Me.Text = Basic.Title
        Catch ex As System.IO.FileNotFoundException
            GoTo AbnormalBase
        Catch ex As System.IO.IOException
            End
        Catch ex As System.InvalidCastException
            GoTo Abnormal
        Catch ex As System.IndexOutOfRangeException
            GoTo Abnormal
        Catch ex As System.OutOfMemoryException
            GoTo Abnormal
        End Try
        GoTo General
Abnormal:
        My.Computer.FileSystem.DeleteFile(temp)
AbnormalBase:
        tempData = My.Computer.FileSystem.OpenTextFileWriter(temp, True)
        System.IO.File.SetAttributes(temp, IO.FileAttributes.Hidden)
        tempData.Write(CType(Basic.Mode, Integer).ToString)
        tempData.Close()
General:
        tempData = My.Computer.FileSystem.OpenTextFileWriter(temp, True)
        System.IO.File.SetAttributes(temp, IO.FileAttributes.Hidden)
    End Sub
    Private Sub Basic_TicTacToeNewGame(sender As Object, e As TicTacToeLibrary.Base.TicTacToeGameEventArgs) Handles Basic.TicTacToeNewGame
        tempData.Close()
        My.Computer.FileSystem.DeleteFile(temp)
        tempData = My.Computer.FileSystem.OpenTextFileWriter(temp, True)
        System.IO.File.SetAttributes(temp, IO.FileAttributes.Hidden)
        tempData.Write(CType(e.Mode, Integer).ToString)
        tempData.Close()
        tempData = My.Computer.FileSystem.OpenTextFileWriter(temp, True)
    End Sub
    Private Sub Basic_TicTacToeNewRound(sender As Object, e As TicTacToeLibrary.Base.TicTacToeRoundEventArgs) Handles Basic.TicTacToeNewRound
        tempData.WriteLine()
        tempData.Write(CType(e.HasClicked, Integer).ToString)
        tempData.Close()
        tempData = My.Computer.FileSystem.OpenTextFileWriter(temp, True)
    End Sub
End Class
