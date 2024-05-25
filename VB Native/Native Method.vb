    Private Class NativeMethods

        <DllImport("gdi32.dll")>
        Public Shared Function CreateRectRgn(nLeftRect As Integer, nTopRect As Integer, nRightRect As Integer, nBottomRect As Integer) As IntPtr
        End Function

        <DllImport("user32.dll")>
        Public Shared Function SetWindowRgn(hWnd As IntPtr, hRgn As IntPtr, bRedraw As Boolean) As Integer
        End Function

        <DllImport("user32.dll")>
        Public Shared Function GetWindowRgn(hWnd As IntPtr, hRgn As IntPtr) As Integer
        End Function

        <DllImport("gdi32.dll")>
        Public Shared Function GetRgnBox(hRgn As IntPtr, ByRef lprc As RECT) As Boolean
        End Function

        <DllImport("user32.dll")>
        Public Shared Function IsWindowVisible(hWnd As IntPtr) As Boolean
        End Function

        <DllImport("gdi32.dll")>
        Public Shared Function DeleteObject(hObj As IntPtr) As Boolean
        End Function

        <StructLayout(LayoutKind.Sequential)>
        Public Structure RECT

            Public Left As Integer
            Public Top As Integer
            Public Right As Integer
            Public Bottom As Integer

        End Structure

        <StructLayout(LayoutKind.Sequential)>
        Public Structure NCCALCSIZE_PARAMS
            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)>
            Public rgrc As RECT()
            Public lppos As WINDOWPOS
        End Structure

        <StructLayout(LayoutKind.Sequential)>
        Public Structure WINDOWPOS

            Public hWnd As IntPtr
            Public hWndInsertAfter As IntPtr
            Public x As Integer
            Public y As Integer
            Public cx As Integer
            Public cy As Integer
            Public flags As UInteger

        End Structure

    End Class