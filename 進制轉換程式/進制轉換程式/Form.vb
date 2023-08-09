Imports NumberSystemsConversion
Imports NumberSystemsConversion.NumberSystemsConversionCalculator
Public Class Form
    Dim x As Boolean = False
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxAns.ScrollBars = ScrollBars.Vertical
        keys0.Enabled = True
        keys1.Enabled = True
        keys2.Enabled = True
        keys3.Enabled = True
        keys4.Enabled = True
        keys5.Enabled = True
        keys6.Enabled = True
        keys7.Enabled = True
        keys8.Enabled = True
        keys9.Enabled = True
        ButtonDel.Enabled = False
    End Sub
    Private Sub ButtonEXE_Click(sender As Object, e As EventArgs) Handles ButtonEXE.Click
        If x = False Then
            x = True
            If TextBoxBase.Text > 36 Then
                TextBoxBase.Text = 36
            End If
            If TextBoxBase.Text < 2 Then
                TextBoxBase.Text = 2
            End If
            If TextBoxNumber.Text = "0" Then
                ButtonDel.Enabled = False
            Else
                ButtonDel.Enabled = True
            End If
            If TextBoxNumber.Text = TextBoxNumber.Text.Replace(".", "") Then
                keysDot.Enabled = True
            Else
                keysDot.Enabled = False
            End If
            keys0.Enabled = False
            keys1.Enabled = False
            keys2.Enabled = False
            keys3.Enabled = False
            keys4.Enabled = False
            keys5.Enabled = False
            keys6.Enabled = False
            keys7.Enabled = False
            keys8.Enabled = False
            keys9.Enabled = False
            keysA.Enabled = False
            keysB.Enabled = False
            keysC.Enabled = False
            keysD.Enabled = False
            keysE.Enabled = False
            keysF.Enabled = False
            keysG.Enabled = False
            keysH.Enabled = False
            keysI.Enabled = False
            keysJ.Enabled = False
            keysK.Enabled = False
            keysL.Enabled = False
            keysM.Enabled = False
            keysN.Enabled = False
            keysO.Enabled = False
            keysP.Enabled = False
            keysQ.Enabled = False
            keysR.Enabled = False
            keysS.Enabled = False
            keysT.Enabled = False
            keysU.Enabled = False
            keysV.Enabled = False
            keysW.Enabled = False
            keysX.Enabled = False
            keysY.Enabled = False
            keysZ.Enabled = False
            If TextBoxBase.Text >= 1 Then
                keys0.Enabled = True
            End If
            If TextBoxBase.Text >= 2 Then
                keys1.Enabled = True
            End If
            If TextBoxBase.Text >= 3 Then
                keys2.Enabled = True
            End If
            If TextBoxBase.Text >= 4 Then
                keys3.Enabled = True
            End If
            If TextBoxBase.Text >= 5 Then
                keys4.Enabled = True
            End If
            If TextBoxBase.Text >= 6 Then
                keys5.Enabled = True
            End If
            If TextBoxBase.Text >= 7 Then
                keys6.Enabled = True
            End If
            If TextBoxBase.Text >= 8 Then
                keys7.Enabled = True
            End If
            If TextBoxBase.Text >= 9 Then
                keys8.Enabled = True
            End If
            If TextBoxBase.Text >= 10 Then
                keys9.Enabled = True
            End If
            If TextBoxBase.Text >= 11 Then
                keysA.Enabled = True
            End If
            If TextBoxBase.Text >= 12 Then
                keysB.Enabled = True
            End If
            If TextBoxBase.Text >= 13 Then
                keysC.Enabled = True
            End If
            If TextBoxBase.Text >= 14 Then
                keysD.Enabled = True
            End If
            If TextBoxBase.Text >= 15 Then
                keysE.Enabled = True
            End If
            If TextBoxBase.Text >= 16 Then
                keysF.Enabled = True
            End If
            If TextBoxBase.Text >= 17 Then
                keysG.Enabled = True
            End If
            If TextBoxBase.Text >= 18 Then
                keysH.Enabled = True
            End If
            If TextBoxBase.Text >= 19 Then
                keysI.Enabled = True
            End If
            If TextBoxBase.Text >= 20 Then
                keysJ.Enabled = True
            End If
            If TextBoxBase.Text >= 21 Then
                keysK.Enabled = True
            End If
            If TextBoxBase.Text >= 22 Then
                keysL.Enabled = True
            End If
            If TextBoxBase.Text >= 23 Then
                keysM.Enabled = True
            End If
            If TextBoxBase.Text >= 24 Then
                keysN.Enabled = True
            End If
            If TextBoxBase.Text >= 25 Then
                keysO.Enabled = True
            End If
            If TextBoxBase.Text >= 26 Then
                keysP.Enabled = True
            End If
            If TextBoxBase.Text >= 27 Then
                keysQ.Enabled = True
            End If
            If TextBoxBase.Text >= 28 Then
                keysR.Enabled = True
            End If
            If TextBoxBase.Text >= 29 Then
                keysS.Enabled = True
            End If
            If TextBoxBase.Text >= 30 Then
                keysT.Enabled = True
            End If
            If TextBoxBase.Text >= 31 Then
                keysU.Enabled = True
            End If
            If TextBoxBase.Text >= 32 Then
                keysV.Enabled = True
            End If
            If TextBoxBase.Text >= 33 Then
                keysW.Enabled = True
            End If
            If TextBoxBase.Text >= 34 Then
                keysX.Enabled = True
            End If
            If TextBoxBase.Text >= 35 Then
                keysY.Enabled = True
            End If
            If TextBoxBase.Text >= 36 Then
                keysZ.Enabled = True
            End If
        Else
            keysDot.Enabled = False
            If TextBoxBase.Text = "0" Then
                ButtonDel.Enabled = False
            Else
                ButtonDel.Enabled = True
            End If
            x = False
            keys0.Enabled = True
            keys1.Enabled = True
            keys2.Enabled = True
            keys3.Enabled = True
            keys4.Enabled = True
            keys5.Enabled = True
            keys6.Enabled = True
            keys7.Enabled = True
            keys8.Enabled = True
            keys9.Enabled = True
            keysA.Enabled = False
            keysB.Enabled = False
            keysC.Enabled = False
            keysD.Enabled = False
            keysE.Enabled = False
            keysF.Enabled = False
            keysG.Enabled = False
            keysH.Enabled = False
            keysI.Enabled = False
            keysJ.Enabled = False
            keysK.Enabled = False
            keysL.Enabled = False
            keysM.Enabled = False
            keysN.Enabled = False
            keysO.Enabled = False
            keysP.Enabled = False
            keysQ.Enabled = False
            keysR.Enabled = False
            keysS.Enabled = False
            keysT.Enabled = False
            keysU.Enabled = False
            keysV.Enabled = False
            keysW.Enabled = False
            keysX.Enabled = False
            keysY.Enabled = False
            keysZ.Enabled = False
            Dim z As Integer
            TextBoxAns.Text = ""
            For z = 2 To 36
                Try
                    TextBoxAns.Text += Convert(New Number(TextBoxNumber.Text, TextBoxBase.Text), z).ToString + vbNewLine
                Catch ex As Exception
                    TextBoxAns.Text += "Base " + z.ToString + " Overflow Exception" + vbNewLine
                End Try
            Next
        End If
    End Sub
    Private Sub ButtonDel_Click(sender As Object, e As EventArgs) Handles ButtonDel.Click
        If x = False Then
            TextBoxBase.Text = TextBoxBase.Text.Remove(TextBoxBase.Text.Length - 1)
            If TextBoxBase.Text = "" Then
                ButtonDel.Enabled = False
                TextBoxBase.Text = "0"
            End If
        Else
            TextBoxNumber.Text = TextBoxNumber.Text.Remove(TextBoxNumber.Text.Length - 1)
            If TextBoxNumber.Text = "" Then
                ButtonDel.Enabled = False
                TextBoxNumber.Text = "0"
            End If
            Output()
            If TextBoxNumber.Text = TextBoxNumber.Text.Replace(".", "") Then
                keysDot.Enabled = True
            Else
                keysDot.Enabled = False
            End If
        End If
    End Sub
    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        x = False
        keysDot.Enabled = True
        keys0.Enabled = True
        keys1.Enabled = True
        keys2.Enabled = True
        keys3.Enabled = True
        keys4.Enabled = True
        keys5.Enabled = True
        keys6.Enabled = True
        keys7.Enabled = True
        keys8.Enabled = True
        keys9.Enabled = True
        keysA.Enabled = False
        keysB.Enabled = False
        keysC.Enabled = False
        keysD.Enabled = False
        keysE.Enabled = False
        keysF.Enabled = False
        keysG.Enabled = False
        keysH.Enabled = False
        keysI.Enabled = False
        keysJ.Enabled = False
        keysK.Enabled = False
        keysL.Enabled = False
        keysM.Enabled = False
        keysN.Enabled = False
        keysO.Enabled = False
        keysP.Enabled = False
        keysQ.Enabled = False
        keysR.Enabled = False
        keysS.Enabled = False
        keysT.Enabled = False
        keysU.Enabled = False
        keysV.Enabled = False
        keysW.Enabled = False
        keysX.Enabled = False
        keysY.Enabled = False
        keysZ.Enabled = False
        ButtonDel.Enabled = False
        TextBoxBase.Text = "0"
        TextBoxNumber.Text = "0"
        TextBoxAns.Text = ""
    End Sub
    Private Sub keysDot_Click(sender As Object, e As EventArgs) Handles keysDot.Click
        TextBoxNumber.Text += "."
        keysDot.Enabled = False
    End Sub
    Public Function Output(str As String) As Boolean
        Dim B As Boolean = True

        ButtonDel.Enabled = True
        If x = False Then
            If TextBoxBase.Text = "0" Then
                TextBoxBase.Text = ""
            End If
            TextBoxBase.Text += str
        Else
            If TextBoxNumber.Text = "0" Then
                TextBoxNumber.Text = ""
            End If
            TextBoxNumber.Text += str
            B = Output()
        End If
        Return B
    End Function
    Public Function Output() As Boolean
        Dim B As Boolean = True
        Dim z As Integer
        TextBoxAns.Text = ""
        For z = 2 To 36
            Try
                TextBoxAns.Text += Convert(New Number(TextBoxNumber.Text, TextBoxBase.Text), z).ToString + vbNewLine
            Catch ex As Exception
                TextBoxAns.Text += "Base " + z.ToString + " Overflow Exception" + vbNewLine
                B = False
            End Try
        Next
        Return B
    End Function
    Private Sub keys0_Click(sender As Object, e As EventArgs) Handles keys0.Click
        Output("0")
    End Sub
    Private Sub keys1_Click(sender As Object, e As EventArgs) Handles keys1.Click
        Output("1")
    End Sub
    Private Sub keys2_Click(sender As Object, e As EventArgs) Handles keys2.Click
        Output("2")
    End Sub
    Private Sub keys3_Click(sender As Object, e As EventArgs) Handles keys3.Click
        Output("3")
    End Sub
    Private Sub keys4_Click(sender As Object, e As EventArgs) Handles keys4.Click
        Output("4")
    End Sub
    Private Sub keys5_Click(sender As Object, e As EventArgs) Handles keys5.Click
        Output("5")
    End Sub
    Private Sub keys6_Click(sender As Object, e As EventArgs) Handles keys6.Click
        Output("6")
    End Sub
    Private Sub keys7_Click(sender As Object, e As EventArgs) Handles keys7.Click
        Output("7")
    End Sub
    Private Sub keys8_Click(sender As Object, e As EventArgs) Handles keys8.Click
        Output("8")
    End Sub
    Private Sub keys9_Click(sender As Object, e As EventArgs) Handles keys9.Click
        Output("9")
    End Sub
    Private Sub keysA_Click(sender As Object, e As EventArgs) Handles keysA.Click
        Output("A")
    End Sub
    Private Sub keysB_Click(sender As Object, e As EventArgs) Handles keysB.Click
        Output("B")
    End Sub
    Private Sub keysC_Click(sender As Object, e As EventArgs) Handles keysC.Click
        Output("C")
    End Sub
    Private Sub keysD_Click(sender As Object, e As EventArgs) Handles keysD.Click
        Output("D")
    End Sub
    Private Sub keysE_Click(sender As Object, e As EventArgs) Handles keysE.Click
        Output("E")
    End Sub
    Private Sub keysF_Click(sender As Object, e As EventArgs) Handles keysF.Click
        Output("F")
    End Sub
    Private Sub keysG_Click(sender As Object, e As EventArgs) Handles keysG.Click
        Output("G")
    End Sub
    Private Sub keysH_Click(sender As Object, e As EventArgs) Handles keysH.Click
        Output("H")
    End Sub
    Private Sub keysI_Click(sender As Object, e As EventArgs) Handles keysI.Click
        Output("I")
    End Sub
    Private Sub keysJ_Click(sender As Object, e As EventArgs) Handles keysJ.Click
        Output("J")
    End Sub
    Private Sub keysK_Click(sender As Object, e As EventArgs) Handles keysK.Click
        Output("K")
    End Sub
    Private Sub keysL_Click(sender As Object, e As EventArgs) Handles keysL.Click
        Output("L")
    End Sub
    Private Sub keysM_Click(sender As Object, e As EventArgs) Handles keysM.Click
        Output("M")
    End Sub
    Private Sub keysN_Click(sender As Object, e As EventArgs) Handles keysN.Click
        Output("N")
    End Sub
    Private Sub keysO_Click(sender As Object, e As EventArgs) Handles keysO.Click
        Output("O")
    End Sub
    Private Sub keysP_Click(sender As Object, e As EventArgs) Handles keysP.Click
        Output("P")
    End Sub
    Private Sub keysQ_Click(sender As Object, e As EventArgs) Handles keysQ.Click
        Output("Q")
    End Sub
    Private Sub keysR_Click(sender As Object, e As EventArgs) Handles keysR.Click
        Output("R")
    End Sub
    Private Sub keysS_Click(sender As Object, e As EventArgs) Handles keysS.Click
        Output("S")
    End Sub
    Private Sub keysT_Click(sender As Object, e As EventArgs) Handles keysT.Click
        Output("T")
    End Sub
    Private Sub keysU_Click(sender As Object, e As EventArgs) Handles keysU.Click
        Output("U")
    End Sub
    Private Sub keysV_Click(sender As Object, e As EventArgs) Handles keysV.Click
        Output("V")
    End Sub
    Private Sub keysW_Click(sender As Object, e As EventArgs) Handles keysW.Click
        Output("W")
    End Sub
    Private Sub keysX_Click(sender As Object, e As EventArgs) Handles keysX.Click
        Output("X")
    End Sub
    Private Sub keysY_Click(sender As Object, e As EventArgs) Handles keysY.Click
        Output("Y")
    End Sub
    Private Sub keysZ_Click(sender As Object, e As EventArgs) Handles keysZ.Click
        Output("Z")
    End Sub
End Class
