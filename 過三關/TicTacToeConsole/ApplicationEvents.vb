Imports System.Text.RegularExpressions
Namespace My
    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private Sub MyApplication_Startup(sender As Object, e As ApplicationServices.StartupEventArgs) Handles Me.Startup
            If System.Diagnostics.Process.GetProcessesByName("過三關").Count = 0 Then
                If My.Computer.FileSystem.FileExists("過三關.exe") = True Then
                    System.Diagnostics.Process.Start("過三關.exe")
                End If
                End
            Else
                For i As Integer = 0 To System.Diagnostics.Process.GetProcessesByName("過三關").Count - 1
                    If New Regex("過三關.exe$").Replace(System.Diagnostics.Process.GetProcessesByName("過三關")(i).MainModule.FileName, "") <>
                       New Regex("TicTacToeConsole.exe$").Replace(System.Diagnostics.Process.GetCurrentProcess.MainModule.FileName, "") Then
                        End
                    End If
                Next
            End If
        End Sub
    End Class
End Namespace
