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
#If DEBUG Then
            DataRemove()
#End If
        End Sub
        Private Sub MyApplication_Shutdown(sender As Object, e As EventArgs) Handles Me.Shutdown
#If DEBUG Then
            DataRemove()
#End If
        End Sub
#If DEBUG Then
        Private Sub DataRemove()
            If My.Computer.FileSystem.FileExists(".TicTacToe") = True Then
                My.Computer.FileSystem.DeleteFile(".TicTacToe")
            End If
            If My.Computer.FileSystem.FileExists("console.log") = True Then
                My.Computer.FileSystem.DeleteFile("console.log")
            End If
            If My.Computer.FileSystem.FileExists("debug.log") = True Then
                My.Computer.FileSystem.DeleteFile("debug.log")
            End If
            If My.Computer.FileSystem.FileExists("bugs.log") = True Then
                My.Computer.FileSystem.DeleteFile("bugs.log")
            End If
        End Sub
#End If
    End Class
End Namespace
