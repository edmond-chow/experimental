    ''' <summary>
    ''' 進行 Windows 視窗的參數設置
    ''' </summary>
    ''' <returns></returns>
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim Params As CreateParams = MyBase.CreateParams
            Dim Frames() As StackFrame = New StackTrace().GetFrames()
            For Each Frame As StackFrame In Frames
                If Frame.GetMethod().Name = ".ctor" AndAlso Frame.GetMethod().DeclaringType = GetType(FrmMain) Then
                    Return Params
                End If
            Next
            If Progress = False Then
                Const WS_EX_COMPOSITED As Integer = &H2000000
                Params.ExStyle = Params.ExStyle Or WS_EX_COMPOSITED
            End If
            Return Params
        End Get
    End Property