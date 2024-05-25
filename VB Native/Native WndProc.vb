            Case WM_NCCALCSIZE
                Dim RECT As NativeMethods.NCCALCSIZE_PARAMS = Marshal.PtrToStructure(Of NativeMethods.NCCALCSIZE_PARAMS)(m.LParam)
                If WindowState = FormWindowState.Maximized Then
                    RECT.rgrc(0).Left += 8
                    RECT.rgrc(0).Top += 8
                    RECT.rgrc(0).Right -= 8
                    RECT.rgrc(0).Bottom -= 8
                End If
                RECT.rgrc(1).Left += RECT.rgrc(0).Left
                RECT.rgrc(1).Top += RECT.rgrc(0).Top
                RECT.rgrc(1).Right -= RECT.rgrc(0).Right
                RECT.rgrc(1).Bottom -= RECT.rgrc(0).Bottom
                Marshal.StructureToPtr(RECT, m.LParam, True)