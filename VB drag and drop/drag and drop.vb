    ''' <summary>
    ''' 表示表單拖動前所截取的位置
    ''' </summary>
    Private Captured As Point?
    Private Sub PrbMain_MouseDown(sender As Object, e As MouseEventArgs) Handles PrbMain.MouseDown
        Dim CaptureMouse As Point = GetLocationOfClientWithCursor(sender, e)
        If CaptureMouse.X >= Border AndAlso CaptureMouse.X < ClientSize.Width - Border AndAlso CaptureMouse.Y >= BorderWithTitle AndAlso CaptureMouse.Y < ClientSize.Height - Border Then
            Return
        End If
        Captured = CaptureMouse
    End Sub

    Private Sub PrbMain_MouseMove(sender As Object, e As MouseEventArgs) Handles PrbMain.MouseMove
        If Captured.HasValue Then
            If WindowState = FormWindowState.Maximized Then
                WindowState = FormWindowState.Normal
            End If
            Dim LocationOfScreenWithCursor As Point = PointToScreen(GetLocationOfClientWithCursor(sender, e))
            '（Control.PointToScreen(p As Point) As Point 計算目前游標相對於螢幕的位置）
            Location = New Point(LocationOfScreenWithCursor.X - Captured.Value.X, LocationOfScreenWithCursor.Y - Captured.Value.Y)
            '（計算目前游標相對於表單的位置，即 目前游標相對於螢幕的位置 - 游標相對於表單的先前位置）
        End If
    End Sub

    Private Sub PrbMain_MouseUp(sender As Object, e As MouseEventArgs) Handles PrbMain.MouseUp
        Captured = Nothing
    End Sub
    Public Sub New()
        ' 設計工具需要此呼叫。
        InitializeComponent()
        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
        MinimumSize = Size
...
        Captured = Nothing
    End Sub
    Private Function GetLocationOfClient(Relative As Control) As Point
        Dim [Return] As New Point
        While Relative IsNot Me
            [Return] = New Point([Return].X + Relative.Location.X, [Return].Y + Relative.Location.Y)
            Relative = Relative.Parent
        End While
    End Function

    Private Function GetLocationOfClientWithCursor(sender As Object, e As MouseEventArgs) As Point
        If TypeOf sender IsNot Control Then
            Throw New BranchesShouldNotBeInstantiatedException()
        End If
        Dim LocationOfClient As Point = GetLocationOfClient(CType(sender, Control))
        Return New Point(LocationOfClient.X + e.Location.X, LocationOfClient.Y + e.Location.Y)
        '（計算某一控制項的游標相對於表單的位置，即 控制項在表單的位置 + 游標相對於控制項的位置）
    End Function