Public Class MainForm
    Dim SkipALine As String = ""
    Private Sub Calculation()
        ValListBox.Items.Clear()
        Dim P As Integer = ComboBoxA.Text
        Dim ThisString As Integer = TextBoxA.Text
        Dim Ten As Integer = 10
        Dim q18m = ThisString Mod (Ten ^ 18)
        Dim q18 = ThisString \ (Ten ^ 18)
        Dim q17m = q18m Mod (Ten ^ 17)
        Dim q17 = q18m \ (Ten ^ 17)
        Dim q16m = q17m Mod (Ten ^ 16)
        Dim q16 = q17m \ (Ten ^ 16)
        Dim q15m = q16m Mod (Ten ^ 15)
        Dim q15 = q16m \ (Ten ^ 15)
        Dim q14m = q15m Mod (Ten ^ 14)
        Dim q14 = q15m \ (Ten ^ 14)
        Dim q13m = q14m Mod (Ten ^ 13)
        Dim q13 = q14m \ (Ten ^ 13)
        Dim q12m = q13m Mod (Ten ^ 12)
        Dim q12 = q13m \ (Ten ^ 12)
        Dim q11m = q12m Mod (Ten ^ 11)
        Dim q11 = q12m \ (Ten ^ 11)
        Dim q10m = q11m Mod (Ten ^ 10)
        Dim q10 = q11m \ (Ten ^ 10)
        Dim q9m = q10m Mod (Ten ^ 9)
        Dim q9 = q10m \ (Ten ^ 9)
        Dim q8m = q9m Mod (Ten ^ 8)
        Dim q8 = q9m \ (Ten ^ 8)
        Dim q7m = q8m Mod (Ten ^ 7)
        Dim q7 = q8m \ (Ten ^ 7)
        Dim q6m = q7m Mod (Ten ^ 6)
        Dim q6 = q7m \ (Ten ^ 6)
        Dim q5m = q6m Mod (Ten ^ 5)
        Dim q5 = q6m \ (Ten ^ 5)
        Dim q4m = q5m Mod (Ten ^ 4)
        Dim q4 = q5m \ (Ten ^ 4)
        Dim q3m = q4m Mod (Ten ^ 3)
        Dim q3 = q4m \ (Ten ^ 3)
        Dim q2m = q3m Mod (Ten ^ 2)
        Dim q2 = q3m \ (Ten ^ 2)
        Dim q1m = q2m Mod (Ten ^ 1)
        Dim q1 = q2m \ (Ten ^ 1)
        Dim q0m = q1m Mod (Ten ^ 0)
        Dim q0 = q1m \ (Ten ^ 0)
        Dim Line_1 As String = "+ " + q17.ToString + " * " + P.ToString + " ^ 17 "
        Dim Line_2 As String = "+ " + q16.ToString + " * " + P.ToString + " ^ 16 "
        Dim Line_3 As String = "+ " + q15.ToString + " * " + P.ToString + " ^ 15 "
        Dim Line_4 As String = "+ " + q14.ToString + " * " + P.ToString + " ^ 14 "
        Dim Line_5 As String = "+ " + q13.ToString + " * " + P.ToString + " ^ 13 "
        Dim Line_6 As String = "+ " + q12.ToString + " * " + P.ToString + " ^ 12 "
        Dim Line_7 As String = "+ " + q11.ToString + " * " + P.ToString + " ^ 11 "
        Dim Line_8 As String = "+ " + q10.ToString + " * " + P.ToString + " ^ 10 "
        Dim Line_9 As String = "+ " + q9.ToString + " * " + P.ToString + " ^ 9 "
        Dim Line_10 As String = "+ " + q8.ToString + " * " + P.ToString + " ^ 8 "
        Dim Line_11 As String = "+ " + q7.ToString + " * " + P.ToString + " ^ 7 "
        Dim Line_12 As String = "+ " + q6.ToString + " * " + P.ToString + " ^ 6 "
        Dim Line_13 As String = "+ " + q5.ToString + " * " + P.ToString + " ^ 5 "
        Dim Line_14 As String = "+ " + q4.ToString + " * " + P.ToString + " ^ 4 "
        Dim Line_15 As String = "+ " + q3.ToString + " * " + P.ToString + " ^ 3 "
        Dim Line_16 As String = "+ " + q2.ToString + " * " + P.ToString + " ^ 2 "
        Dim Line_17 As String = "+ " + q1.ToString + " * " + P.ToString + " ^ 1 "
        Dim Line_18 As String = "+ " + q0.ToString + " * " + P.ToString + " ^ 0 "
        ValListBox.Items.Add(Line_1)
        ValListBox.Items.Add(Line_2)
        ValListBox.Items.Add(Line_3)
        ValListBox.Items.Add(Line_4)
        ValListBox.Items.Add(Line_5)
        ValListBox.Items.Add(Line_6)
        ValListBox.Items.Add(Line_7)
        ValListBox.Items.Add(Line_8)
        ValListBox.Items.Add(Line_9)
        ValListBox.Items.Add(Line_10)
        ValListBox.Items.Add(Line_11)
        ValListBox.Items.Add(Line_12)
        ValListBox.Items.Add(Line_13)
        ValListBox.Items.Add(Line_14)
        ValListBox.Items.Add(Line_15)
        ValListBox.Items.Add(Line_16)
        ValListBox.Items.Add(Line_17)
        ValListBox.Items.Add(Line_18)
        Dim Dec As Double = q18 * (P ^ 18) + q17 * (P ^ 17) + q16 * (P ^ 16) + q15 * (P ^ 15) + q14 * (P ^ 14) + q13 * (P ^ 13) + q12 * (P ^ 12) + q11 * (P ^ 11) + q10 * (P ^ 10) + q9 * (P ^ 9) + q8 * (P ^ 8) + q7 * (P ^ 7) + q6 * (P ^ 6) + q5 * (P ^ 5) + q4 * (P ^ 4) + q3 * (P ^ 3) + q2 * (P ^ 2) + q1 * (P ^ 1) + q0 * (P ^ 0)
        Dim Line2 As String = "= " + Dec.ToString + "(Dec)"
        ValListBox.Items.Add(Line2)
        ValListBox.Items.Add(SkipALine)
        Dim Y As Integer = ComboBoxB.Text
        Dim Decx As Integer = Math.Round(Val(Dec - 0.49), 0)
        If Decx < (Y ^ 18) Then
            Dim x17m As String = Decx Mod (Y ^ 17)
            Dim x17 As String = Decx \ (Y ^ 17)
            Dim Line3 As String = Decx.ToString + " ÷ " + Y.ToString + " ^ 17 = " + x17.ToString + " ... " + x17m.ToString
            ValListBox.Items.Add(Line3)
            Dim x16m As String = x17m Mod (Y ^ 16)
            Dim x16 As String = x17m \ (Y ^ 16)
            Dim Line4 As String = x17m.ToString + " ÷ " + Y.ToString + " ^ 16 = " + x16.ToString + " ... " + x16m.ToString
            ValListBox.Items.Add(Line4)
            Dim x15m As String = x16m Mod (Y ^ 15)
            Dim x15 As String = x16m \ (Y ^ 15)
            Dim Line5 As String = x16m.ToString + " ÷ " + Y.ToString + " ^ 15 = " + x15.ToString + " ... " + x15m.ToString
            ValListBox.Items.Add(Line5)
            Dim x14m As String = x15m Mod (Y ^ 14)
            Dim x14 As String = x15m \ (Y ^ 14)
            Dim Line6 As String = x15m.ToString + " ÷ " + Y.ToString + " ^ 14 = " + x14.ToString + " ... " + x14m.ToString
            ValListBox.Items.Add(Line6)
            Dim x13m As String = x14m Mod (Y ^ 13)
            Dim x13 As String = x14m \ (Y ^ 13)
            Dim Line7 As String = x14m.ToString + " ÷ " + Y.ToString + " ^ 13 = " + x13.ToString + " ... " + x13m.ToString
            ValListBox.Items.Add(Line7)
            Dim x12m As String = x13m Mod (Y ^ 12)
            Dim x12 As String = x13m \ (Y ^ 12)
            Dim Line8 As String = x13m.ToString + " ÷ " + Y.ToString + " ^ 12 = " + x12.ToString + " ... " + x12m.ToString
            ValListBox.Items.Add(Line8)
            Dim x11m As String = x12m Mod (Y ^ 11)
            Dim x11 As String = x12m \ (Y ^ 11)
            Dim Line9 As String = x12m.ToString + " ÷ " + Y.ToString + " ^ 11 = " + x11.ToString + " ... " + x11m.ToString
            ValListBox.Items.Add(Line9)
            Dim x10m As String = x11m Mod (Y ^ 10)
            Dim x10 As String = x11m \ (Y ^ 10)
            Dim Line10 As String = x11m.ToString + " ÷ " + Y.ToString + " ^ 10 = " + x10.ToString + " ... " + x10m.ToString
            ValListBox.Items.Add(Line10)
            Dim x9m As String = x10m Mod (Y ^ 9)
            Dim x9 As String = x10m \ (Y ^ 9)
            Dim Line11 As String = x10m.ToString + " ÷ " + Y.ToString + " ^ 9 = " + x9.ToString + " ... " + x9m.ToString
            ValListBox.Items.Add(Line11)
            Dim x8m As String = x9m Mod (Y ^ 8)
            Dim x8 As String = x9m \ (Y ^ 8)
            Dim Line12 As String = x9m.ToString + " ÷ " + Y.ToString + " ^ 8 = " + x8.ToString + " ... " + x8m.ToString
            ValListBox.Items.Add(Line12)
            Dim x7m As String = x8m Mod (Y ^ 7)
            Dim x7 As String = x8m \ (Y ^ 7)
            Dim Line13 As String = x8m.ToString + " ÷ " + Y.ToString + " ^ 7 = " + x7.ToString + " ... " + x7m.ToString
            ValListBox.Items.Add(Line13)
            Dim x6m As String = x7m Mod (Y ^ 6)
            Dim x6 As String = x7m \ (Y ^ 6)
            Dim Line14 As String = x7m.ToString + " ÷ " + Y.ToString + " ^ 6 = " + x6.ToString + " ... " + x6m.ToString
            ValListBox.Items.Add(Line14)
            Dim x5m As String = x6m Mod (Y ^ 5)
            Dim x5 As String = x6m \ (Y ^ 5)
            Dim Line15 As String = x6m.ToString + " ÷ " + Y.ToString + " ^ 5 = " + x5.ToString + " ... " + x5m.ToString
            ValListBox.Items.Add(Line15)
            Dim x4m As String = x5m Mod (Y ^ 4)
            Dim x4 As String = x5m \ (Y ^ 4)
            Dim Line16 As String = x5m.ToString + " ÷ " + Y.ToString + " ^ 4 = " + x4.ToString + " ... " + x4m.ToString
            ValListBox.Items.Add(Line16)
            Dim x3m As String = x4m Mod (Y ^ 3)
            Dim x3 As String = x4m \ (Y ^ 3)
            Dim Line17 As String = x4m.ToString + " ÷ " + Y.ToString + " ^ 3 = " + x3.ToString + " ... " + x3m.ToString
            ValListBox.Items.Add(Line17)
            Dim x2m As String = x3m Mod (Y ^ 2)
            Dim x2 As String = x3m \ (Y ^ 2)
            Dim Line18 As String = x3m.ToString + " ÷ " + Y.ToString + " ^ 2 = " + x2.ToString + " ... " + x2m.ToString
            ValListBox.Items.Add(Line18)
            Dim x1m As String = x2m Mod (Y ^ 1)
            Dim x1 As String = x2m \ (Y ^ 1)
            Dim Line19 As String = x2m.ToString + " ÷ " + Y.ToString + " ^ 1 = " + x1.ToString + " ... " + x1m.ToString
            ValListBox.Items.Add(Line19)
            Dim x0m As String = x1m Mod (Y ^ 0)
            Dim x0 As String = x1m \ (Y ^ 0)
            Dim Line20 As String = x1m.ToString + " ÷ " + Y.ToString + " ^ 0 = " + x0.ToString + " ... " + x0m.ToString
            ValListBox.Items.Add(Line20)
            Dim Z As String = x17.ToString + x16.ToString + x15.ToString + " " + x14.ToString + x13.ToString + x12.ToString + " " + x11.ToString + x10.ToString + x9.ToString + " " + x8.ToString + x7.ToString + x6.ToString + " " + x5.ToString + x4.ToString + x3.ToString + " " + x2.ToString + x1.ToString + x0.ToString
            TextBoxB.Text = Z.ToString
        Else
            TextBoxB.Text = "Math Error"
        End If
    End Sub
    Dim Clicked As Integer = 1
    Private Sub Clicked9Action(sender, e)
        If Clicked = 9 Then
            key0.Enabled = False
            key1.Enabled = False
            key2.Enabled = False
            key3.Enabled = False
            key4.Enabled = False
            key5.Enabled = False
            key6.Enabled = False
            key7.Enabled = False
            key8.Enabled = False
            key9.Enabled = False
        End If
    End Sub
    Private Sub key0_Click(sender As Object, e As EventArgs) Handles key0.Click
        If TextBoxA.Text = "0" Then
            TextBoxA.Text = Nothing
            Clicked = Clicked - 1
        End If
        TextBoxA.Text = TextBoxA.Text.ToString + "0"
        Clicked = Clicked + 1
        Calculation()
        Clicked9Action(sender, e)
    End Sub
    Private Sub key1_Click(sender As Object, e As EventArgs) Handles key1.Click
        If TextBoxA.Text = "0" Then
            TextBoxA.Text = Nothing
            Clicked = Clicked - 1
        End If
        TextBoxA.Text = TextBoxA.Text.ToString + "1"
        Clicked = Clicked + 1
        Calculation()
        Clicked9Action(sender, e)
    End Sub
    Private Sub key2_Click(sender As Object, e As EventArgs) Handles key2.Click
        If TextBoxA.Text = "0" Then
            TextBoxA.Text = Nothing
            Clicked = Clicked - 1
        End If
        TextBoxA.Text = TextBoxA.Text.ToString + "2"
        Clicked = Clicked + 1
        Calculation()
        Clicked9Action(sender, e)
    End Sub
    Private Sub key3_Click(sender As Object, e As EventArgs) Handles key3.Click
        If TextBoxA.Text = "0" Then
            TextBoxA.Text = Nothing
            Clicked = Clicked - 1
        End If
        TextBoxA.Text = TextBoxA.Text.ToString + "3"
        Clicked = Clicked + 1
        Calculation()
        Clicked9Action(sender, e)
    End Sub
    Private Sub key4_Click(sender As Object, e As EventArgs) Handles key4.Click
        If TextBoxA.Text = "0" Then
            TextBoxA.Text = Nothing
            Clicked = Clicked - 1
        End If
        TextBoxA.Text = TextBoxA.Text.ToString + "4"
        Clicked = Clicked + 1
        Calculation()
        Clicked9Action(sender, e)
    End Sub
    Private Sub key5_Click(sender As Object, e As EventArgs) Handles key5.Click
        If TextBoxA.Text = "0" Then
            TextBoxA.Text = Nothing
            Clicked = Clicked - 1
        End If
        TextBoxA.Text = TextBoxA.Text.ToString + "5"
        Clicked = Clicked + 1
        Calculation()
        Clicked9Action(sender, e)
    End Sub
    Private Sub key6_Click(sender As Object, e As EventArgs) Handles key6.Click
        If TextBoxA.Text = "0" Then
            TextBoxA.Text = Nothing
            Clicked = Clicked - 1
        End If
        TextBoxA.Text = TextBoxA.Text.ToString + "6"
        Clicked = Clicked + 1
        Calculation()
        Clicked9Action(sender, e)
    End Sub
    Private Sub key7_Click(sender As Object, e As EventArgs) Handles key7.Click
        If TextBoxA.Text = "0" Then
            TextBoxA.Text = Nothing
            Clicked = Clicked - 1
        End If
        TextBoxA.Text = TextBoxA.Text.ToString + "7"
        Clicked = Clicked + 1
        Calculation()
        Clicked9Action(sender, e)
    End Sub
    Private Sub key8_Click(sender As Object, e As EventArgs) Handles key8.Click
        If TextBoxA.Text = "0" Then
            TextBoxA.Text = Nothing
            Clicked = Clicked - 1
        End If
        TextBoxA.Text = TextBoxA.Text.ToString + "8"
        Clicked = Clicked + 1
        Calculation()
        Clicked9Action(sender, e)
    End Sub
    Private Sub key9_Click(sender As Object, e As EventArgs) Handles key9.Click
        If TextBoxA.Text = "0" Then
            TextBoxA.Text = Nothing
            Clicked = Clicked - 1
        End If
        TextBoxA.Text = TextBoxA.Text.ToString + "9"
        Clicked = Clicked + 1
        Calculation()
        Clicked9Action(sender, e)
    End Sub
    Private Sub KeyEnabled()
        If ComboBoxA.Text = 1 Then
            key0.Enabled = True
            key1.Enabled = False
            key2.Enabled = False
            key3.Enabled = False
            key4.Enabled = False
            key5.Enabled = False
            key6.Enabled = False
            key7.Enabled = False
            key8.Enabled = False
            key9.Enabled = False
        End If
        If ComboBoxA.Text = 2 Then
            key0.Enabled = True
            key1.Enabled = True
            key2.Enabled = False
            key3.Enabled = False
            key4.Enabled = False
            key5.Enabled = False
            key6.Enabled = False
            key7.Enabled = False
            key8.Enabled = False
            key9.Enabled = False
        End If
        If ComboBoxA.Text = 3 Then
            key0.Enabled = True
            key1.Enabled = True
            key2.Enabled = True
            key3.Enabled = False
            key4.Enabled = False
            key5.Enabled = False
            key6.Enabled = False
            key7.Enabled = False
            key8.Enabled = False
            key9.Enabled = False
        End If
        If ComboBoxA.Text = 4 Then
            key0.Enabled = True
            key1.Enabled = True
            key2.Enabled = True
            key3.Enabled = True
            key4.Enabled = False
            key5.Enabled = False
            key6.Enabled = False
            key7.Enabled = False
            key8.Enabled = False
            key9.Enabled = False
        End If
        If ComboBoxA.Text = 5 Then
            key0.Enabled = True
            key1.Enabled = True
            key2.Enabled = True
            key3.Enabled = True
            key4.Enabled = True
            key5.Enabled = False
            key6.Enabled = False
            key7.Enabled = False
            key8.Enabled = False
            key9.Enabled = False
        End If
        If ComboBoxA.Text = 6 Then
            key0.Enabled = True
            key1.Enabled = True
            key2.Enabled = True
            key3.Enabled = True
            key4.Enabled = True
            key5.Enabled = True
            key6.Enabled = False
            key7.Enabled = False
            key8.Enabled = False
            key9.Enabled = False
        End If
        If ComboBoxA.Text = 7 Then
            key0.Enabled = True
            key1.Enabled = True
            key2.Enabled = True
            key3.Enabled = True
            key4.Enabled = True
            key5.Enabled = True
            key6.Enabled = True
            key7.Enabled = False
            key8.Enabled = False
            key9.Enabled = False
        End If
        If ComboBoxA.Text = 8 Then
            key0.Enabled = True
            key1.Enabled = True
            key2.Enabled = True
            key3.Enabled = True
            key4.Enabled = True
            key5.Enabled = True
            key6.Enabled = True
            key7.Enabled = True
            key8.Enabled = False
            key9.Enabled = False
        End If
        If ComboBoxA.Text = 9 Then
            key0.Enabled = True
            key1.Enabled = True
            key2.Enabled = True
            key3.Enabled = True
            key4.Enabled = True
            key5.Enabled = True
            key6.Enabled = True
            key7.Enabled = True
            key8.Enabled = True
            key9.Enabled = False
        End If
        If ComboBoxA.Text = 10 Then
            key0.Enabled = True
            key1.Enabled = True
            key2.Enabled = True
            key3.Enabled = True
            key4.Enabled = True
            key5.Enabled = True
            key6.Enabled = True
            key7.Enabled = True
            key8.Enabled = True
            key9.Enabled = True
        End If
        Reset.Enabled = True
    End Sub
    Private Sub ComboBoxA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxA.SelectedIndexChanged
        TextBoxA.Text = "0"
        TextBoxB.Text = "0"
        If ComboBoxB.Text = Nothing = False Then
            KeyEnabled()
            Clicked = 1
        End If
        ValListBox.Items.Clear()
        ValListBox.Items.Add("(Nothing)")
    End Sub
    Dim KeyEnabledBoolean As Boolean = True
    Private Sub ComboBoxB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxB.SelectedIndexChanged
        If ComboBoxA.Text = Nothing = False Then
            If KeyEnabledBoolean = True Then
                KeyEnabled()
                KeyEnabledBoolean = False
            End If
            Calculation()
        End If
    End Sub
    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        TextBoxA.Text = "0"
        TextBoxB.Text = "0"
        KeyEnabled()
        Clicked = 1
        ValListBox.Items.Clear()
        ValListBox.Items.Add("(Nothing)")
    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimumSize = Me.Size
        MyTabControl.SelectedTab = BestFunctionPage
    End Sub
    Private Sub MainForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    End Sub
    Private Sub ButtonInputX_Click(sender As Object, e As EventArgs) Handles ButtonInputX.Click
        TextBoxInput.Text = "X"
    End Sub
    Private Sub ButtonInputY_Click(sender As Object, e As EventArgs) Handles ButtonInputY.Click
        TextBoxInput.Text = "Y"
    End Sub
    Private Sub ButtonInputZ_Click(sender As Object, e As EventArgs) Handles ButtonInputZ.Click
        TextBoxInput.Text = "Z"
    End Sub
    Private Sub ComboBoxValue_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxValue.SelectedIndexChanged
        TextBoxX.Text = 0
        TextBoxY.Text = 0
        TextBoxZ.Text = 0
        If ComboBoxCalculationResults.Text = Nothing = False Then
            KeysEnabled()
        End If
        MyListBox.Items.Clear()
        MyListBox.Items.Add("(Nothing)")
    End Sub
    Private Sub ComboBoxCalculationResults_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCalculationResults.SelectedIndexChanged
        If ComboBoxValue.Text = Nothing = False Then
            KeysEnabled()
            C()
        End If
    End Sub
    Private Sub KeysEnabled()
        TextBoxInput.Enabled = True
        ButtonInputX.Enabled = True
        ButtonInputY.Enabled = True
        ButtonInputZ.Enabled = True
        ButtonReset.Enabled = True
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
        If ComboBoxValue.Text = 2 Then
            keys0.Enabled = True
            keys1.Enabled = True
        End If
        If ComboBoxValue.Text = 3 Then
            keys0.Enabled = True
            keys1.Enabled = True
            keys2.Enabled = True
        End If
        If ComboBoxValue.Text = 4 Then
            keys0.Enabled = True
            keys1.Enabled = True
            keys2.Enabled = True
            keys3.Enabled = True
        End If
        If ComboBoxValue.Text = 5 Then
            keys0.Enabled = True
            keys1.Enabled = True
            keys2.Enabled = True
            keys3.Enabled = True
            keys4.Enabled = True
        End If
        If ComboBoxValue.Text = 6 Then
            keys0.Enabled = True
            keys1.Enabled = True
            keys2.Enabled = True
            keys3.Enabled = True
            keys4.Enabled = True
            keys5.Enabled = True
        End If
        If ComboBoxValue.Text = 7 Then
            keys0.Enabled = True
            keys1.Enabled = True
            keys2.Enabled = True
            keys3.Enabled = True
            keys4.Enabled = True
            keys5.Enabled = True
            keys6.Enabled = True
        End If
        If ComboBoxValue.Text = 8 Then
            keys0.Enabled = True
            keys1.Enabled = True
            keys2.Enabled = True
            keys3.Enabled = True
            keys4.Enabled = True
            keys5.Enabled = True
            keys6.Enabled = True
            keys7.Enabled = True
        End If
        If ComboBoxValue.Text = 9 Then
            keys0.Enabled = True
            keys1.Enabled = True
            keys2.Enabled = True
            keys3.Enabled = True
            keys4.Enabled = True
            keys5.Enabled = True
            keys6.Enabled = True
            keys7.Enabled = True
            keys8.Enabled = True
        End If
        If ComboBoxValue.Text = 10 Then
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
        End If
        If ComboBoxValue.Text = 11 Then
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
            keysA.Enabled = True
        End If
        If ComboBoxValue.Text = 12 Then
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
            keysA.Enabled = True
            keysB.Enabled = True
        End If
        If ComboBoxValue.Text = 13 Then
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
            keysA.Enabled = True
            keysB.Enabled = True
            keysC.Enabled = True
        End If
        If ComboBoxValue.Text = 14 Then
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
            keysA.Enabled = True
            keysB.Enabled = True
            keysC.Enabled = True
            keysD.Enabled = True
        End If
        If ComboBoxValue.Text = 15 Then
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
            keysA.Enabled = True
            keysB.Enabled = True
            keysC.Enabled = True
            keysD.Enabled = True
            keysE.Enabled = True
        End If
        If ComboBoxValue.Text = 16 Then
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
            keysA.Enabled = True
            keysB.Enabled = True
            keysC.Enabled = True
            keysD.Enabled = True
            keysE.Enabled = True
            keysF.Enabled = True
        End If
        If ComboBoxValue.Text = 17 Then
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
            keysA.Enabled = True
            keysB.Enabled = True
            keysC.Enabled = True
            keysD.Enabled = True
            keysE.Enabled = True
            keysF.Enabled = True
            keysG.Enabled = True
        End If
        If ComboBoxValue.Text = 18 Then
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
            keysA.Enabled = True
            keysB.Enabled = True
            keysC.Enabled = True
            keysD.Enabled = True
            keysE.Enabled = True
            keysF.Enabled = True
            keysG.Enabled = True
            keysH.Enabled = True
        End If
        If ComboBoxValue.Text = 19 Then
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
            keysA.Enabled = True
            keysB.Enabled = True
            keysC.Enabled = True
            keysD.Enabled = True
            keysE.Enabled = True
            keysF.Enabled = True
            keysG.Enabled = True
            keysH.Enabled = True
            keysI.Enabled = True
        End If
        If ComboBoxValue.Text = 20 Then
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
            keysA.Enabled = True
            keysB.Enabled = True
            keysC.Enabled = True
            keysD.Enabled = True
            keysE.Enabled = True
            keysF.Enabled = True
            keysG.Enabled = True
            keysH.Enabled = True
            keysI.Enabled = True
            keysJ.Enabled = True
        End If
        If ComboBoxValue.Text = 21 Then
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
            keysA.Enabled = True
            keysB.Enabled = True
            keysC.Enabled = True
            keysD.Enabled = True
            keysE.Enabled = True
            keysF.Enabled = True
            keysG.Enabled = True
            keysH.Enabled = True
            keysI.Enabled = True
            keysJ.Enabled = True
            keysK.Enabled = True
        End If
        If ComboBoxValue.Text = 22 Then
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
            keysA.Enabled = True
            keysB.Enabled = True
            keysC.Enabled = True
            keysD.Enabled = True
            keysE.Enabled = True
            keysF.Enabled = True
            keysG.Enabled = True
            keysH.Enabled = True
            keysI.Enabled = True
            keysJ.Enabled = True
            keysK.Enabled = True
            keysL.Enabled = True
        End If
        If ComboBoxValue.Text = 23 Then
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
            keysA.Enabled = True
            keysB.Enabled = True
            keysC.Enabled = True
            keysD.Enabled = True
            keysE.Enabled = True
            keysF.Enabled = True
            keysG.Enabled = True
            keysH.Enabled = True
            keysI.Enabled = True
            keysJ.Enabled = True
            keysK.Enabled = True
            keysL.Enabled = True
            keysM.Enabled = True
        End If
        If ComboBoxValue.Text = 24 Then
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
            keysA.Enabled = True
            keysB.Enabled = True
            keysC.Enabled = True
            keysD.Enabled = True
            keysE.Enabled = True
            keysF.Enabled = True
            keysG.Enabled = True
            keysH.Enabled = True
            keysI.Enabled = True
            keysJ.Enabled = True
            keysK.Enabled = True
            keysL.Enabled = True
            keysM.Enabled = True
            keysN.Enabled = True
        End If
        If ComboBoxValue.Text = 25 Then
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
            keysA.Enabled = True
            keysB.Enabled = True
            keysC.Enabled = True
            keysD.Enabled = True
            keysE.Enabled = True
            keysF.Enabled = True
            keysG.Enabled = True
            keysH.Enabled = True
            keysI.Enabled = True
            keysJ.Enabled = True
            keysK.Enabled = True
            keysL.Enabled = True
            keysM.Enabled = True
            keysN.Enabled = True
            keysO.Enabled = True
        End If
        If ComboBoxValue.Text = 26 Then
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
            keysA.Enabled = True
            keysB.Enabled = True
            keysC.Enabled = True
            keysD.Enabled = True
            keysE.Enabled = True
            keysF.Enabled = True
            keysG.Enabled = True
            keysH.Enabled = True
            keysI.Enabled = True
            keysJ.Enabled = True
            keysK.Enabled = True
            keysL.Enabled = True
            keysM.Enabled = True
            keysN.Enabled = True
            keysO.Enabled = True
            keysP.Enabled = True
        End If
        If ComboBoxValue.Text = 27 Then
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
            keysA.Enabled = True
            keysB.Enabled = True
            keysC.Enabled = True
            keysD.Enabled = True
            keysE.Enabled = True
            keysF.Enabled = True
            keysG.Enabled = True
            keysH.Enabled = True
            keysI.Enabled = True
            keysJ.Enabled = True
            keysK.Enabled = True
            keysL.Enabled = True
            keysM.Enabled = True
            keysN.Enabled = True
            keysO.Enabled = True
            keysP.Enabled = True
            keysQ.Enabled = True
        End If
        If ComboBoxValue.Text = 28 Then
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
            keysA.Enabled = True
            keysB.Enabled = True
            keysC.Enabled = True
            keysD.Enabled = True
            keysE.Enabled = True
            keysF.Enabled = True
            keysG.Enabled = True
            keysH.Enabled = True
            keysI.Enabled = True
            keysJ.Enabled = True
            keysK.Enabled = True
            keysL.Enabled = True
            keysM.Enabled = True
            keysN.Enabled = True
            keysO.Enabled = True
            keysP.Enabled = True
            keysQ.Enabled = True
            keysR.Enabled = True
        End If
        If ComboBoxValue.Text = 29 Then
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
            keysA.Enabled = True
            keysB.Enabled = True
            keysC.Enabled = True
            keysD.Enabled = True
            keysE.Enabled = True
            keysF.Enabled = True
            keysG.Enabled = True
            keysH.Enabled = True
            keysI.Enabled = True
            keysJ.Enabled = True
            keysK.Enabled = True
            keysL.Enabled = True
            keysM.Enabled = True
            keysN.Enabled = True
            keysO.Enabled = True
            keysP.Enabled = True
            keysQ.Enabled = True
            keysR.Enabled = True
            keysS.Enabled = True
        End If
        If ComboBoxValue.Text = 30 Then
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
            keysA.Enabled = True
            keysB.Enabled = True
            keysC.Enabled = True
            keysD.Enabled = True
            keysE.Enabled = True
            keysF.Enabled = True
            keysG.Enabled = True
            keysH.Enabled = True
            keysI.Enabled = True
            keysJ.Enabled = True
            keysK.Enabled = True
            keysL.Enabled = True
            keysM.Enabled = True
            keysN.Enabled = True
            keysO.Enabled = True
            keysP.Enabled = True
            keysQ.Enabled = True
            keysR.Enabled = True
            keysS.Enabled = True
            keysT.Enabled = True
        End If
        If ComboBoxValue.Text = 31 Then
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
            keysA.Enabled = True
            keysB.Enabled = True
            keysC.Enabled = True
            keysD.Enabled = True
            keysE.Enabled = True
            keysF.Enabled = True
            keysG.Enabled = True
            keysH.Enabled = True
            keysI.Enabled = True
            keysJ.Enabled = True
            keysK.Enabled = True
            keysL.Enabled = True
            keysM.Enabled = True
            keysN.Enabled = True
            keysO.Enabled = True
            keysP.Enabled = True
            keysQ.Enabled = True
            keysR.Enabled = True
            keysS.Enabled = True
            keysT.Enabled = True
            keysU.Enabled = True
        End If
        If ComboBoxValue.Text = 32 Then
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
            keysA.Enabled = True
            keysB.Enabled = True
            keysC.Enabled = True
            keysD.Enabled = True
            keysE.Enabled = True
            keysF.Enabled = True
            keysG.Enabled = True
            keysH.Enabled = True
            keysI.Enabled = True
            keysJ.Enabled = True
            keysK.Enabled = True
            keysL.Enabled = True
            keysM.Enabled = True
            keysN.Enabled = True
            keysO.Enabled = True
            keysP.Enabled = True
            keysQ.Enabled = True
            keysR.Enabled = True
            keysS.Enabled = True
            keysT.Enabled = True
            keysU.Enabled = True
            keysV.Enabled = True
        End If
        If ComboBoxValue.Text = 33 Then
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
            keysA.Enabled = True
            keysB.Enabled = True
            keysC.Enabled = True
            keysD.Enabled = True
            keysE.Enabled = True
            keysF.Enabled = True
            keysG.Enabled = True
            keysH.Enabled = True
            keysI.Enabled = True
            keysJ.Enabled = True
            keysK.Enabled = True
            keysL.Enabled = True
            keysM.Enabled = True
            keysN.Enabled = True
            keysO.Enabled = True
            keysP.Enabled = True
            keysQ.Enabled = True
            keysR.Enabled = True
            keysS.Enabled = True
            keysT.Enabled = True
            keysU.Enabled = True
            keysV.Enabled = True
            keysW.Enabled = True
        End If
        If ComboBoxValue.Text = 34 Then
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
            keysA.Enabled = True
            keysB.Enabled = True
            keysC.Enabled = True
            keysD.Enabled = True
            keysE.Enabled = True
            keysF.Enabled = True
            keysG.Enabled = True
            keysH.Enabled = True
            keysI.Enabled = True
            keysJ.Enabled = True
            keysK.Enabled = True
            keysL.Enabled = True
            keysM.Enabled = True
            keysN.Enabled = True
            keysO.Enabled = True
            keysP.Enabled = True
            keysQ.Enabled = True
            keysR.Enabled = True
            keysS.Enabled = True
            keysT.Enabled = True
            keysU.Enabled = True
            keysV.Enabled = True
            keysW.Enabled = True
            keysX.Enabled = True
        End If
        If ComboBoxValue.Text = 35 Then
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
            keysA.Enabled = True
            keysB.Enabled = True
            keysC.Enabled = True
            keysD.Enabled = True
            keysE.Enabled = True
            keysF.Enabled = True
            keysG.Enabled = True
            keysH.Enabled = True
            keysI.Enabled = True
            keysJ.Enabled = True
            keysK.Enabled = True
            keysL.Enabled = True
            keysM.Enabled = True
            keysN.Enabled = True
            keysO.Enabled = True
            keysP.Enabled = True
            keysQ.Enabled = True
            keysR.Enabled = True
            keysS.Enabled = True
            keysT.Enabled = True
            keysU.Enabled = True
            keysV.Enabled = True
            keysW.Enabled = True
            keysX.Enabled = True
            keysY.Enabled = True
        End If
        If ComboBoxValue.Text = 36 Then
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
            keysA.Enabled = True
            keysB.Enabled = True
            keysC.Enabled = True
            keysD.Enabled = True
            keysE.Enabled = True
            keysF.Enabled = True
            keysG.Enabled = True
            keysH.Enabled = True
            keysI.Enabled = True
            keysJ.Enabled = True
            keysK.Enabled = True
            keysL.Enabled = True
            keysM.Enabled = True
            keysN.Enabled = True
            keysO.Enabled = True
            keysP.Enabled = True
            keysQ.Enabled = True
            keysR.Enabled = True
            keysS.Enabled = True
            keysT.Enabled = True
            keysU.Enabled = True
            keysV.Enabled = True
            keysW.Enabled = True
            keysX.Enabled = True
            keysY.Enabled = True
            keysZ.Enabled = True
        End If
    End Sub
    Private Sub C()
        MyListBox.Items.Clear()
        Dim SZ As String = TextBoxZ.Text
        Dim SY As String = TextBoxY.Text
        Dim SX As String = TextBoxX.Text
        If TextBoxZ.Text = "A" Then
            TextBoxZ.Text = "10"
        ElseIf TextBoxZ.Text = "B" Then
            TextBoxZ.Text = "11"
        ElseIf TextBoxZ.Text = "C" Then
            TextBoxZ.Text = "12"
        ElseIf TextBoxZ.Text = "D" Then
            TextBoxZ.Text = "13"
        ElseIf TextBoxZ.Text = "E" Then
            TextBoxZ.Text = "14"
        ElseIf TextBoxZ.Text = "F" Then
            TextBoxZ.Text = "15"
        ElseIf TextBoxZ.Text = "G" Then
            TextBoxZ.Text = "16"
        ElseIf TextBoxZ.Text = "H" Then
            TextBoxZ.Text = "17"
        ElseIf TextBoxZ.Text = "I" Then
            TextBoxZ.Text = "18"
        ElseIf TextBoxZ.Text = "J" Then
            TextBoxZ.Text = "19"
        ElseIf TextBoxZ.Text = "K" Then
            TextBoxZ.Text = "20"
        ElseIf TextBoxZ.Text = "L" Then
            TextBoxZ.Text = "21"
        ElseIf TextBoxZ.Text = "M" Then
            TextBoxZ.Text = "22"
        ElseIf TextBoxZ.Text = "N" Then
            TextBoxZ.Text = "23"
        ElseIf TextBoxZ.Text = "O" Then
            TextBoxZ.Text = "24"
        ElseIf TextBoxZ.Text = "P" Then
            TextBoxZ.Text = "25"
        ElseIf TextBoxZ.Text = "Q" Then
            TextBoxZ.Text = "26"
        ElseIf TextBoxZ.Text = "R" Then
            TextBoxZ.Text = "27"
        ElseIf TextBoxZ.Text = "S" Then
            TextBoxZ.Text = "28"
        ElseIf TextBoxZ.Text = "T" Then
            TextBoxZ.Text = "29"
        ElseIf TextBoxZ.Text = "U" Then
            TextBoxZ.Text = "30"
        ElseIf TextBoxZ.Text = "V" Then
            TextBoxZ.Text = "31"
        ElseIf TextBoxZ.Text = "W" Then
            TextBoxZ.Text = "32"
        ElseIf TextBoxZ.Text = "X" Then
            TextBoxZ.Text = "33"
        ElseIf TextBoxZ.Text = "Y" Then
            TextBoxZ.Text = "34"
        ElseIf TextBoxZ.Text = "Z" Then
            TextBoxZ.Text = "35"
        End If
        If TextBoxY.Text = "A" Then
            TextBoxY.Text = "10"
        ElseIf TextBoxY.Text = "B" Then
            TextBoxY.Text = "11"
        ElseIf TextBoxY.Text = "C" Then
            TextBoxY.Text = "12"
        ElseIf TextBoxY.Text = "D" Then
            TextBoxY.Text = "13"
        ElseIf TextBoxY.Text = "E" Then
            TextBoxY.Text = "14"
        ElseIf TextBoxY.Text = "F" Then
            TextBoxY.Text = "15"
        ElseIf TextBoxY.Text = "G" Then
            TextBoxY.Text = "16"
        ElseIf TextBoxY.Text = "H" Then
            TextBoxY.Text = "17"
        ElseIf TextBoxY.Text = "I" Then
            TextBoxY.Text = "18"
        ElseIf TextBoxY.Text = "J" Then
            TextBoxY.Text = "19"
        ElseIf TextBoxY.Text = "K" Then
            TextBoxY.Text = "20"
        ElseIf TextBoxY.Text = "L" Then
            TextBoxY.Text = "21"
        ElseIf TextBoxY.Text = "M" Then
            TextBoxY.Text = "22"
        ElseIf TextBoxY.Text = "N" Then
            TextBoxY.Text = "23"
        ElseIf TextBoxY.Text = "O" Then
            TextBoxY.Text = "24"
        ElseIf TextBoxY.Text = "P" Then
            TextBoxY.Text = "25"
        ElseIf TextBoxY.Text = "Q" Then
            TextBoxY.Text = "26"
        ElseIf TextBoxY.Text = "R" Then
            TextBoxY.Text = "27"
        ElseIf TextBoxY.Text = "S" Then
            TextBoxY.Text = "28"
        ElseIf TextBoxY.Text = "T" Then
            TextBoxY.Text = "29"
        ElseIf TextBoxY.Text = "U" Then
            TextBoxY.Text = "30"
        ElseIf TextBoxY.Text = "V" Then
            TextBoxY.Text = "31"
        ElseIf TextBoxY.Text = "W" Then
            TextBoxY.Text = "32"
        ElseIf TextBoxY.Text = "X" Then
            TextBoxY.Text = "33"
        ElseIf TextBoxY.Text = "Y" Then
            TextBoxY.Text = "34"
        ElseIf TextBoxY.Text = "Z" Then
            TextBoxY.Text = "35"
        End If
        If TextBoxX.Text = "A" Then
            TextBoxX.Text = "10"
        ElseIf TextBoxX.Text = "B" Then
            TextBoxX.Text = "11"
        ElseIf TextBoxX.Text = "C" Then
            TextBoxX.Text = "12"
        ElseIf TextBoxX.Text = "D" Then
            TextBoxX.Text = "13"
        ElseIf TextBoxX.Text = "E" Then
            TextBoxX.Text = "14"
        ElseIf TextBoxX.Text = "F" Then
            TextBoxX.Text = "15"
        ElseIf TextBoxX.Text = "G" Then
            TextBoxX.Text = "16"
        ElseIf TextBoxX.Text = "H" Then
            TextBoxX.Text = "17"
        ElseIf TextBoxX.Text = "I" Then
            TextBoxX.Text = "18"
        ElseIf TextBoxX.Text = "J" Then
            TextBoxX.Text = "19"
        ElseIf TextBoxX.Text = "K" Then
            TextBoxX.Text = "20"
        ElseIf TextBoxX.Text = "L" Then
            TextBoxX.Text = "21"
        ElseIf TextBoxX.Text = "M" Then
            TextBoxX.Text = "22"
        ElseIf TextBoxX.Text = "N" Then
            TextBoxX.Text = "23"
        ElseIf TextBoxX.Text = "O" Then
            TextBoxX.Text = "24"
        ElseIf TextBoxX.Text = "P" Then
            TextBoxX.Text = "25"
        ElseIf TextBoxX.Text = "Q" Then
            TextBoxX.Text = "26"
        ElseIf TextBoxX.Text = "R" Then
            TextBoxX.Text = "27"
        ElseIf TextBoxX.Text = "S" Then
            TextBoxX.Text = "28"
        ElseIf TextBoxX.Text = "T" Then
            TextBoxX.Text = "29"
        ElseIf TextBoxX.Text = "U" Then
            TextBoxX.Text = "30"
        ElseIf TextBoxX.Text = "V" Then
            TextBoxX.Text = "31"
        ElseIf TextBoxX.Text = "W" Then
            TextBoxX.Text = "32"
        ElseIf TextBoxX.Text = "X" Then
            TextBoxX.Text = "33"
        ElseIf TextBoxX.Text = "Y" Then
            TextBoxX.Text = "34"
        ElseIf TextBoxX.Text = "Z" Then
            TextBoxX.Text = "35"
        End If
        Dim P As Integer = ComboBoxValue.Text
        Dim Dec = (TextBoxZ.Text) * (P ^ 2) + (TextBoxY.Text) * (P ^ 1) + (TextBoxX.Text) * (P ^ 0)
        Dim Line1 As String = TextBoxZ.Text.ToString + " * " + P.ToString + " ^ 2 " + " + " + TextBoxY.Text.ToString + " * " + P.ToString + " ^ 1 " + " + " + TextBoxX.Text.ToString + " * " + P.ToString + " ^ 0 "
        MyListBox.Items.Add(Line1)
        Dim Line2 As String = "= " + Dec.ToString + "(Dec)"
        MyListBox.Items.Add(Line2)
        TextBoxZ.Text = SZ.ToString
        TextBoxY.Text = SY.ToString
        TextBoxX.Text = SX.ToString
        MyListBox.Items.Add(SkipALine)
        Dim Y As Integer = ComboBoxCalculationResults.Text
        If ComboBoxCalculationResults.Text <= 12 Then
            If Dec < (Y ^ 18) Then
                Dim x17m As String = Dec Mod (Y ^ 17)
                Dim x17 As String = Dec \ (Y ^ 17)
                Dim Line3 As String = Dec.ToString + " ÷ " + Y.ToString + " ^ 17 = " + x17.ToString + " ... " + x17m.ToString
                MyListBox.Items.Add(Line3)
                Dim x16m As String = x17m Mod (Y ^ 16)
                Dim x16 As String = x17m \ (Y ^ 16)
                Dim Line4 As String = x17m.ToString + " ÷ " + Y.ToString + " ^ 16 = " + x16.ToString + " ... " + x16m.ToString
                MyListBox.Items.Add(Line4)
                Dim x15m As String = x16m Mod (Y ^ 15)
                Dim x15 As String = x16m \ (Y ^ 15)
                Dim Line5 As String = x16m.ToString + " ÷ " + Y.ToString + " ^ 15 = " + x15.ToString + " ... " + x15m.ToString
                MyListBox.Items.Add(Line5)
                Dim x14m As String = x15m Mod (Y ^ 14)
                Dim x14 As String = x15m \ (Y ^ 14)
                Dim Line6 As String = x15m.ToString + " ÷ " + Y.ToString + " ^ 14 = " + x14.ToString + " ... " + x14m.ToString
                MyListBox.Items.Add(Line6)
                Dim x13m As String = x14m Mod (Y ^ 13)
                Dim x13 As String = x14m \ (Y ^ 13)
                Dim Line7 As String = x14m.ToString + " ÷ " + Y.ToString + " ^ 13 = " + x13.ToString + " ... " + x13m.ToString
                MyListBox.Items.Add(Line7)
                Dim x12m As String = x13m Mod (Y ^ 12)
                Dim x12 As String = x13m \ (Y ^ 12)
                Dim Line8 As String = x13m.ToString + " ÷ " + Y.ToString + " ^ 12 = " + x12.ToString + " ... " + x12m.ToString
                MyListBox.Items.Add(Line8)
                Dim x11m As String = x12m Mod (Y ^ 11)
                Dim x11 As String = x12m \ (Y ^ 11)
                Dim Line9 As String = x12m.ToString + " ÷ " + Y.ToString + " ^ 11 = " + x11.ToString + " ... " + x11m.ToString
                MyListBox.Items.Add(Line9)
                Dim x10m As String = x11m Mod (Y ^ 10)
                Dim x10 As String = x11m \ (Y ^ 10)
                Dim Line10 As String = x11m.ToString + " ÷ " + Y.ToString + " ^ 10 = " + x10.ToString + " ... " + x10m.ToString
                MyListBox.Items.Add(Line10)
                Dim x9m As String = x10m Mod (Y ^ 9)
                Dim x9 As String = x10m \ (Y ^ 9)
                Dim Line11 As String = x10m.ToString + " ÷ " + Y.ToString + " ^ 9 = " + x9.ToString + " ... " + x9m.ToString
                MyListBox.Items.Add(Line11)
                Dim x8m As String = x9m Mod (Y ^ 8)
                Dim x8 As String = x9m \ (Y ^ 8)
                Dim Line12 As String = x9m.ToString + " ÷ " + Y.ToString + " ^ 8 = " + x8.ToString + " ... " + x8m.ToString
                MyListBox.Items.Add(Line12)
                Dim x7m As String = x8m Mod (Y ^ 7)
                Dim x7 As String = x8m \ (Y ^ 7)
                Dim Line13 As String = x8m.ToString + " ÷ " + Y.ToString + " ^ 7 = " + x7.ToString + " ... " + x7m.ToString
                MyListBox.Items.Add(Line13)
                Dim x6m As String = x7m Mod (Y ^ 6)
                Dim x6 As String = x7m \ (Y ^ 6)
                Dim Line14 As String = x7m.ToString + " ÷ " + Y.ToString + " ^ 6 = " + x6.ToString + " ... " + x6m.ToString
                MyListBox.Items.Add(Line14)
                Dim x5m As String = x6m Mod (Y ^ 5)
                Dim x5 As String = x6m \ (Y ^ 5)
                Dim Line15 As String = x6m.ToString + " ÷ " + Y.ToString + " ^ 5 = " + x5.ToString + " ... " + x5m.ToString
                MyListBox.Items.Add(Line15)
                Dim x4m As String = x5m Mod (Y ^ 4)
                Dim x4 As String = x5m \ (Y ^ 4)
                Dim Line16 As String = x5m.ToString + " ÷ " + Y.ToString + " ^ 4 = " + x4.ToString + " ... " + x4m.ToString
                MyListBox.Items.Add(Line16)
                Dim x3m As String = x4m Mod (Y ^ 3)
                Dim x3 As String = x4m \ (Y ^ 3)
                Dim Line17 As String = x4m.ToString + " ÷ " + Y.ToString + " ^ 3 = " + x3.ToString + " ... " + x3m.ToString
                MyListBox.Items.Add(Line17)
                Dim x2m As String = x3m Mod (Y ^ 2)
                Dim x2 As String = x3m \ (Y ^ 2)
                Dim Line18 As String = x3m.ToString + " ÷ " + Y.ToString + " ^ 2 = " + x2.ToString + " ... " + x2m.ToString
                MyListBox.Items.Add(Line18)
                Dim x1m As String = x2m Mod (Y ^ 1)
                Dim x1 As String = x2m \ (Y ^ 1)
                Dim Line19 As String = x2m.ToString + " ÷ " + Y.ToString + " ^ 1 = " + x1.ToString + " ... " + x1m.ToString
                MyListBox.Items.Add(Line19)
                Dim x0m As String = x1m Mod (Y ^ 0)
                Dim x0 As String = x1m \ (Y ^ 0)
                Dim Line20 As String = x1m.ToString + " ÷ " + Y.ToString + " ^ 0 = " + x0.ToString + " ... " + x0m.ToString
                MyListBox.Items.Add(Line20)
                If x17 = 10 Then
                    x17 = "A"
                ElseIf x17 = 11 Then
                    x17 = "B"
                ElseIf x17 = 12 Then
                    x17 = "C"
                ElseIf x17 = 13 Then
                    x17 = "D"
                ElseIf x17 = 14 Then
                    x17 = "E"
                ElseIf x17 = 15 Then
                    x17 = "F"
                ElseIf x17 = 16 Then
                    x17 = "G"
                ElseIf x17 = 17 Then
                    x17 = "H"
                ElseIf x17 = 18 Then
                    x17 = "I"
                ElseIf x17 = 19 Then
                    x17 = "J"
                ElseIf x17 = 20 Then
                    x17 = "K"
                ElseIf x17 = 21 Then
                    x17 = "L"
                ElseIf x17 = 22 Then
                    x17 = "M"
                ElseIf x17 = 23 Then
                    x17 = "N"
                ElseIf x17 = 24 Then
                    x17 = "O"
                ElseIf x17 = 25 Then
                    x17 = "P"
                ElseIf x17 = 26 Then
                    x17 = "Q"
                ElseIf x17 = 27 Then
                    x17 = "R"
                ElseIf x17 = 28 Then
                    x17 = "S"
                ElseIf x17 = 29 Then
                    x17 = "T"
                ElseIf x17 = 30 Then
                    x17 = "U"
                ElseIf x17 = 31 Then
                    x17 = "V"
                ElseIf x17 = 32 Then
                    x17 = "W"
                ElseIf x17 = 33 Then
                    x17 = "X"
                ElseIf x17 = 34 Then
                    x17 = "Y"
                ElseIf x17 = 35 Then
                    x17 = "Z"
                End If
                If x16 = 10 Then
                    x16 = "A"
                ElseIf x16 = 11 Then
                    x16 = "B"
                ElseIf x16 = 12 Then
                    x16 = "C"
                ElseIf x16 = 13 Then
                    x16 = "D"
                ElseIf x16 = 14 Then
                    x16 = "E"
                ElseIf x16 = 15 Then
                    x16 = "F"
                ElseIf x16 = 16 Then
                    x16 = "G"
                ElseIf x16 = 17 Then
                    x16 = "H"
                ElseIf x16 = 18 Then
                    x16 = "I"
                ElseIf x16 = 19 Then
                    x16 = "J"
                ElseIf x16 = 20 Then
                    x16 = "K"
                ElseIf x16 = 21 Then
                    x16 = "L"
                ElseIf x16 = 22 Then
                    x16 = "M"
                ElseIf x16 = 23 Then
                    x16 = "N"
                ElseIf x16 = 24 Then
                    x16 = "O"
                ElseIf x16 = 25 Then
                    x16 = "P"
                ElseIf x16 = 26 Then
                    x16 = "Q"
                ElseIf x16 = 27 Then
                    x16 = "R"
                ElseIf x16 = 28 Then
                    x16 = "S"
                ElseIf x16 = 29 Then
                    x16 = "T"
                ElseIf x16 = 30 Then
                    x16 = "U"
                ElseIf x16 = 31 Then
                    x16 = "V"
                ElseIf x16 = 32 Then
                    x16 = "W"
                ElseIf x16 = 33 Then
                    x16 = "X"
                ElseIf x16 = 34 Then
                    x16 = "Y"
                ElseIf x16 = 35 Then
                    x16 = "Z"
                End If
                If x15 = 10 Then
                    x15 = "A"
                ElseIf x15 = 11 Then
                    x15 = "B"
                ElseIf x15 = 12 Then
                    x15 = "C"
                ElseIf x15 = 13 Then
                    x15 = "D"
                ElseIf x15 = 14 Then
                    x15 = "E"
                ElseIf x15 = 15 Then
                    x15 = "F"
                ElseIf x15 = 16 Then
                    x15 = "G"
                ElseIf x15 = 17 Then
                    x15 = "H"
                ElseIf x15 = 18 Then
                    x15 = "I"
                ElseIf x15 = 19 Then
                    x15 = "J"
                ElseIf x15 = 20 Then
                    x15 = "K"
                ElseIf x15 = 21 Then
                    x15 = "L"
                ElseIf x15 = 22 Then
                    x15 = "M"
                ElseIf x15 = 23 Then
                    x15 = "N"
                ElseIf x15 = 24 Then
                    x15 = "O"
                ElseIf x15 = 25 Then
                    x15 = "P"
                ElseIf x15 = 26 Then
                    x15 = "Q"
                ElseIf x15 = 27 Then
                    x15 = "R"
                ElseIf x15 = 28 Then
                    x15 = "S"
                ElseIf x15 = 29 Then
                    x15 = "T"
                ElseIf x15 = 30 Then
                    x15 = "U"
                ElseIf x15 = 31 Then
                    x15 = "V"
                ElseIf x15 = 32 Then
                    x15 = "W"
                ElseIf x15 = 33 Then
                    x15 = "X"
                ElseIf x15 = 34 Then
                    x15 = "Y"
                ElseIf x15 = 35 Then
                    x15 = "Z"
                End If
                If x14 = 10 Then
                    x14 = "A"
                ElseIf x14 = 11 Then
                    x14 = "B"
                ElseIf x14 = 12 Then
                    x14 = "C"
                ElseIf x14 = 13 Then
                    x14 = "D"
                ElseIf x14 = 14 Then
                    x14 = "E"
                ElseIf x14 = 15 Then
                    x14 = "F"
                ElseIf x14 = 16 Then
                    x14 = "G"
                ElseIf x14 = 17 Then
                    x14 = "H"
                ElseIf x14 = 18 Then
                    x14 = "I"
                ElseIf x14 = 19 Then
                    x14 = "J"
                ElseIf x14 = 20 Then
                    x14 = "K"
                ElseIf x14 = 21 Then
                    x14 = "L"
                ElseIf x14 = 22 Then
                    x14 = "M"
                ElseIf x14 = 23 Then
                    x14 = "N"
                ElseIf x14 = 24 Then
                    x14 = "O"
                ElseIf x14 = 25 Then
                    x14 = "P"
                ElseIf x14 = 26 Then
                    x14 = "Q"
                ElseIf x14 = 27 Then
                    x14 = "R"
                ElseIf x14 = 28 Then
                    x14 = "S"
                ElseIf x14 = 29 Then
                    x14 = "T"
                ElseIf x14 = 30 Then
                    x14 = "U"
                ElseIf x14 = 31 Then
                    x14 = "V"
                ElseIf x14 = 32 Then
                    x14 = "W"
                ElseIf x14 = 33 Then
                    x14 = "X"
                ElseIf x14 = 34 Then
                    x14 = "Y"
                ElseIf x14 = 35 Then
                    x14 = "Z"
                End If
                If x13 = 10 Then
                    x13 = "A"
                ElseIf x13 = 11 Then
                    x13 = "B"
                ElseIf x13 = 12 Then
                    x13 = "C"
                ElseIf x13 = 13 Then
                    x13 = "D"
                ElseIf x13 = 14 Then
                    x13 = "E"
                ElseIf x13 = 15 Then
                    x13 = "F"
                ElseIf x13 = 16 Then
                    x13 = "G"
                ElseIf x13 = 17 Then
                    x13 = "H"
                ElseIf x13 = 18 Then
                    x13 = "I"
                ElseIf x13 = 19 Then
                    x13 = "J"
                ElseIf x13 = 20 Then
                    x13 = "K"
                ElseIf x13 = 21 Then
                    x13 = "L"
                ElseIf x13 = 22 Then
                    x13 = "M"
                ElseIf x13 = 23 Then
                    x13 = "N"
                ElseIf x13 = 24 Then
                    x13 = "O"
                ElseIf x13 = 25 Then
                    x13 = "P"
                ElseIf x13 = 26 Then
                    x13 = "Q"
                ElseIf x13 = 27 Then
                    x13 = "R"
                ElseIf x13 = 28 Then
                    x13 = "S"
                ElseIf x13 = 29 Then
                    x13 = "T"
                ElseIf x13 = 30 Then
                    x13 = "U"
                ElseIf x13 = 31 Then
                    x13 = "V"
                ElseIf x13 = 32 Then
                    x13 = "W"
                ElseIf x13 = 33 Then
                    x13 = "X"
                ElseIf x13 = 34 Then
                    x13 = "Y"
                ElseIf x13 = 35 Then
                    x13 = "Z"
                End If
                If x12 = 10 Then
                    x12 = "A"
                ElseIf x12 = 11 Then
                    x12 = "B"
                ElseIf x12 = 12 Then
                    x12 = "C"
                ElseIf x12 = 13 Then
                    x12 = "D"
                ElseIf x12 = 14 Then
                    x12 = "E"
                ElseIf x12 = 15 Then
                    x12 = "F"
                ElseIf x12 = 16 Then
                    x12 = "G"
                ElseIf x12 = 17 Then
                    x12 = "H"
                ElseIf x12 = 18 Then
                    x12 = "I"
                ElseIf x12 = 19 Then
                    x12 = "J"
                ElseIf x12 = 20 Then
                    x12 = "K"
                ElseIf x12 = 21 Then
                    x12 = "L"
                ElseIf x12 = 22 Then
                    x12 = "M"
                ElseIf x12 = 23 Then
                    x12 = "N"
                ElseIf x12 = 24 Then
                    x12 = "O"
                ElseIf x12 = 25 Then
                    x12 = "P"
                ElseIf x12 = 26 Then
                    x12 = "Q"
                ElseIf x12 = 27 Then
                    x12 = "R"
                ElseIf x12 = 28 Then
                    x12 = "S"
                ElseIf x12 = 29 Then
                    x12 = "T"
                ElseIf x12 = 30 Then
                    x12 = "U"
                ElseIf x12 = 31 Then
                    x12 = "V"
                ElseIf x12 = 32 Then
                    x12 = "W"
                ElseIf x12 = 33 Then
                    x12 = "X"
                ElseIf x12 = 34 Then
                    x12 = "Y"
                ElseIf x12 = 35 Then
                    x12 = "Z"
                End If
                If x11 = 10 Then
                    x11 = "A"
                ElseIf x11 = 11 Then
                    x11 = "B"
                ElseIf x11 = 12 Then
                    x11 = "C"
                ElseIf x11 = 13 Then
                    x11 = "D"
                ElseIf x11 = 14 Then
                    x11 = "E"
                ElseIf x11 = 15 Then
                    x11 = "F"
                ElseIf x11 = 16 Then
                    x11 = "G"
                ElseIf x11 = 17 Then
                    x11 = "H"
                ElseIf x11 = 18 Then
                    x11 = "I"
                ElseIf x11 = 19 Then
                    x11 = "J"
                ElseIf x11 = 20 Then
                    x11 = "K"
                ElseIf x11 = 21 Then
                    x11 = "L"
                ElseIf x11 = 22 Then
                    x11 = "M"
                ElseIf x11 = 23 Then
                    x11 = "N"
                ElseIf x11 = 24 Then
                    x11 = "O"
                ElseIf x11 = 25 Then
                    x11 = "P"
                ElseIf x11 = 26 Then
                    x11 = "Q"
                ElseIf x11 = 27 Then
                    x11 = "R"
                ElseIf x11 = 28 Then
                    x11 = "S"
                ElseIf x11 = 29 Then
                    x11 = "T"
                ElseIf x11 = 30 Then
                    x11 = "U"
                ElseIf x11 = 31 Then
                    x11 = "V"
                ElseIf x11 = 32 Then
                    x11 = "W"
                ElseIf x11 = 33 Then
                    x11 = "X"
                ElseIf x11 = 34 Then
                    x11 = "Y"
                ElseIf x11 = 35 Then
                    x11 = "Z"
                End If
                If x10 = 10 Then
                    x10 = "A"
                ElseIf x10 = 11 Then
                    x10 = "B"
                ElseIf x10 = 12 Then
                    x10 = "C"
                ElseIf x10 = 13 Then
                    x10 = "D"
                ElseIf x10 = 14 Then
                    x10 = "E"
                ElseIf x10 = 15 Then
                    x10 = "F"
                ElseIf x10 = 16 Then
                    x10 = "G"
                ElseIf x10 = 17 Then
                    x10 = "H"
                ElseIf x10 = 18 Then
                    x10 = "I"
                ElseIf x10 = 19 Then
                    x10 = "J"
                ElseIf x10 = 20 Then
                    x10 = "K"
                ElseIf x10 = 21 Then
                    x10 = "L"
                ElseIf x10 = 22 Then
                    x10 = "M"
                ElseIf x10 = 23 Then
                    x10 = "N"
                ElseIf x10 = 24 Then
                    x10 = "O"
                ElseIf x10 = 25 Then
                    x10 = "P"
                ElseIf x10 = 26 Then
                    x10 = "Q"
                ElseIf x10 = 27 Then
                    x10 = "R"
                ElseIf x10 = 28 Then
                    x10 = "S"
                ElseIf x10 = 29 Then
                    x10 = "T"
                ElseIf x10 = 30 Then
                    x10 = "U"
                ElseIf x10 = 31 Then
                    x10 = "V"
                ElseIf x10 = 32 Then
                    x10 = "W"
                ElseIf x10 = 33 Then
                    x10 = "X"
                ElseIf x10 = 34 Then
                    x10 = "Y"
                ElseIf x10 = 35 Then
                    x10 = "Z"
                End If
                If x9 = 10 Then
                    x9 = "A"
                ElseIf x9 = 11 Then
                    x9 = "B"
                ElseIf x9 = 12 Then
                    x9 = "C"
                ElseIf x9 = 13 Then
                    x9 = "D"
                ElseIf x9 = 14 Then
                    x9 = "E"
                ElseIf x9 = 15 Then
                    x9 = "F"
                ElseIf x9 = 16 Then
                    x9 = "G"
                ElseIf x9 = 17 Then
                    x9 = "H"
                ElseIf x9 = 18 Then
                    x9 = "I"
                ElseIf x9 = 19 Then
                    x9 = "J"
                ElseIf x9 = 20 Then
                    x9 = "K"
                ElseIf x9 = 21 Then
                    x9 = "L"
                ElseIf x9 = 22 Then
                    x9 = "M"
                ElseIf x9 = 23 Then
                    x9 = "N"
                ElseIf x9 = 24 Then
                    x9 = "O"
                ElseIf x9 = 25 Then
                    x9 = "P"
                ElseIf x9 = 26 Then
                    x9 = "Q"
                ElseIf x9 = 27 Then
                    x9 = "R"
                ElseIf x9 = 28 Then
                    x9 = "S"
                ElseIf x9 = 29 Then
                    x9 = "T"
                ElseIf x9 = 30 Then
                    x9 = "U"
                ElseIf x9 = 31 Then
                    x9 = "V"
                ElseIf x9 = 32 Then
                    x9 = "W"
                ElseIf x9 = 33 Then
                    x9 = "X"
                ElseIf x9 = 34 Then
                    x9 = "Y"
                ElseIf x9 = 35 Then
                    x9 = "Z"
                End If
                If x8 = 10 Then
                    x8 = "A"
                ElseIf x8 = 11 Then
                    x8 = "B"
                ElseIf x8 = 12 Then
                    x8 = "C"
                ElseIf x8 = 13 Then
                    x8 = "D"
                ElseIf x8 = 14 Then
                    x8 = "E"
                ElseIf x8 = 15 Then
                    x8 = "F"
                ElseIf x8 = 16 Then
                    x8 = "G"
                ElseIf x8 = 17 Then
                    x8 = "H"
                ElseIf x8 = 18 Then
                    x8 = "I"
                ElseIf x8 = 19 Then
                    x8 = "J"
                ElseIf x8 = 20 Then
                    x8 = "K"
                ElseIf x8 = 21 Then
                    x8 = "L"
                ElseIf x8 = 22 Then
                    x8 = "M"
                ElseIf x8 = 23 Then
                    x8 = "N"
                ElseIf x8 = 24 Then
                    x8 = "O"
                ElseIf x8 = 25 Then
                    x8 = "P"
                ElseIf x8 = 26 Then
                    x8 = "Q"
                ElseIf x8 = 27 Then
                    x8 = "R"
                ElseIf x8 = 28 Then
                    x8 = "S"
                ElseIf x8 = 29 Then
                    x8 = "T"
                ElseIf x8 = 30 Then
                    x8 = "U"
                ElseIf x8 = 31 Then
                    x8 = "V"
                ElseIf x8 = 32 Then
                    x8 = "W"
                ElseIf x8 = 33 Then
                    x8 = "X"
                ElseIf x8 = 34 Then
                    x8 = "Y"
                ElseIf x8 = 35 Then
                    x8 = "Z"
                End If
                If x7 = 10 Then
                    x7 = "A"
                ElseIf x7 = 11 Then
                    x7 = "B"
                ElseIf x7 = 12 Then
                    x7 = "C"
                ElseIf x7 = 13 Then
                    x7 = "D"
                ElseIf x7 = 14 Then
                    x7 = "E"
                ElseIf x7 = 15 Then
                    x7 = "F"
                ElseIf x7 = 16 Then
                    x7 = "G"
                ElseIf x7 = 17 Then
                    x7 = "H"
                ElseIf x7 = 18 Then
                    x7 = "I"
                ElseIf x7 = 19 Then
                    x7 = "J"
                ElseIf x7 = 20 Then
                    x7 = "K"
                ElseIf x7 = 21 Then
                    x7 = "L"
                ElseIf x7 = 22 Then
                    x7 = "M"
                ElseIf x7 = 23 Then
                    x7 = "N"
                ElseIf x7 = 24 Then
                    x7 = "O"
                ElseIf x7 = 25 Then
                    x7 = "P"
                ElseIf x7 = 26 Then
                    x7 = "Q"
                ElseIf x7 = 27 Then
                    x7 = "R"
                ElseIf x7 = 28 Then
                    x7 = "S"
                ElseIf x7 = 29 Then
                    x7 = "T"
                ElseIf x7 = 30 Then
                    x7 = "U"
                ElseIf x7 = 31 Then
                    x7 = "V"
                ElseIf x7 = 32 Then
                    x7 = "W"
                ElseIf x7 = 33 Then
                    x7 = "X"
                ElseIf x7 = 34 Then
                    x7 = "Y"
                ElseIf x7 = 35 Then
                    x7 = "Z"
                End If
                If x6 = 10 Then
                    x6 = "A"
                ElseIf x6 = 11 Then
                    x6 = "B"
                ElseIf x6 = 12 Then
                    x6 = "C"
                ElseIf x6 = 13 Then
                    x6 = "D"
                ElseIf x6 = 14 Then
                    x6 = "E"
                ElseIf x6 = 15 Then
                    x6 = "F"
                ElseIf x6 = 16 Then
                    x6 = "G"
                ElseIf x6 = 17 Then
                    x6 = "H"
                ElseIf x6 = 18 Then
                    x6 = "I"
                ElseIf x6 = 19 Then
                    x6 = "J"
                ElseIf x6 = 20 Then
                    x6 = "K"
                ElseIf x6 = 21 Then
                    x6 = "L"
                ElseIf x6 = 22 Then
                    x6 = "M"
                ElseIf x6 = 23 Then
                    x6 = "N"
                ElseIf x6 = 24 Then
                    x6 = "O"
                ElseIf x6 = 25 Then
                    x6 = "P"
                ElseIf x6 = 26 Then
                    x6 = "Q"
                ElseIf x6 = 27 Then
                    x6 = "R"
                ElseIf x6 = 28 Then
                    x6 = "S"
                ElseIf x6 = 29 Then
                    x6 = "T"
                ElseIf x6 = 30 Then
                    x6 = "U"
                ElseIf x6 = 31 Then
                    x6 = "V"
                ElseIf x6 = 32 Then
                    x6 = "W"
                ElseIf x6 = 33 Then
                    x6 = "X"
                ElseIf x6 = 34 Then
                    x6 = "Y"
                ElseIf x6 = 35 Then
                    x6 = "Z"
                End If
                If x5 = 10 Then
                    x5 = "A"
                ElseIf x5 = 11 Then
                    x5 = "B"
                ElseIf x5 = 12 Then
                    x5 = "C"
                ElseIf x5 = 13 Then
                    x5 = "D"
                ElseIf x5 = 14 Then
                    x5 = "E"
                ElseIf x5 = 15 Then
                    x5 = "F"
                ElseIf x5 = 16 Then
                    x5 = "G"
                ElseIf x5 = 17 Then
                    x5 = "H"
                ElseIf x5 = 18 Then
                    x5 = "I"
                ElseIf x5 = 19 Then
                    x5 = "J"
                ElseIf x5 = 20 Then
                    x5 = "K"
                ElseIf x5 = 21 Then
                    x5 = "L"
                ElseIf x5 = 22 Then
                    x5 = "M"
                ElseIf x5 = 23 Then
                    x5 = "N"
                ElseIf x5 = 24 Then
                    x5 = "O"
                ElseIf x5 = 25 Then
                    x5 = "P"
                ElseIf x5 = 26 Then
                    x5 = "Q"
                ElseIf x5 = 27 Then
                    x5 = "R"
                ElseIf x5 = 28 Then
                    x5 = "S"
                ElseIf x5 = 29 Then
                    x5 = "T"
                ElseIf x5 = 30 Then
                    x5 = "U"
                ElseIf x5 = 31 Then
                    x5 = "V"
                ElseIf x5 = 32 Then
                    x5 = "W"
                ElseIf x5 = 33 Then
                    x5 = "X"
                ElseIf x5 = 34 Then
                    x5 = "Y"
                ElseIf x5 = 35 Then
                    x5 = "Z"
                End If
                If x4 = 10 Then
                    x4 = "A"
                ElseIf x4 = 11 Then
                    x4 = "B"
                ElseIf x4 = 12 Then
                    x4 = "C"
                ElseIf x4 = 13 Then
                    x4 = "D"
                ElseIf x4 = 14 Then
                    x4 = "E"
                ElseIf x4 = 15 Then
                    x4 = "F"
                ElseIf x4 = 16 Then
                    x4 = "G"
                ElseIf x4 = 17 Then
                    x4 = "H"
                ElseIf x4 = 18 Then
                    x4 = "I"
                ElseIf x4 = 19 Then
                    x4 = "J"
                ElseIf x4 = 20 Then
                    x4 = "K"
                ElseIf x4 = 21 Then
                    x4 = "L"
                ElseIf x4 = 22 Then
                    x4 = "M"
                ElseIf x4 = 23 Then
                    x4 = "N"
                ElseIf x4 = 24 Then
                    x4 = "O"
                ElseIf x4 = 25 Then
                    x4 = "P"
                ElseIf x4 = 26 Then
                    x4 = "Q"
                ElseIf x4 = 27 Then
                    x4 = "R"
                ElseIf x4 = 28 Then
                    x4 = "S"
                ElseIf x4 = 29 Then
                    x4 = "T"
                ElseIf x4 = 30 Then
                    x4 = "U"
                ElseIf x4 = 31 Then
                    x4 = "V"
                ElseIf x4 = 32 Then
                    x4 = "W"
                ElseIf x4 = 33 Then
                    x4 = "X"
                ElseIf x4 = 34 Then
                    x4 = "Y"
                ElseIf x4 = 35 Then
                    x4 = "Z"
                End If
                If x3 = 10 Then
                    x3 = "A"
                ElseIf x3 = 11 Then
                    x3 = "B"
                ElseIf x3 = 12 Then
                    x3 = "C"
                ElseIf x3 = 13 Then
                    x3 = "D"
                ElseIf x3 = 14 Then
                    x3 = "E"
                ElseIf x3 = 15 Then
                    x3 = "F"
                ElseIf x3 = 16 Then
                    x3 = "G"
                ElseIf x3 = 17 Then
                    x3 = "H"
                ElseIf x3 = 18 Then
                    x3 = "I"
                ElseIf x3 = 19 Then
                    x3 = "J"
                ElseIf x3 = 20 Then
                    x3 = "K"
                ElseIf x3 = 21 Then
                    x3 = "L"
                ElseIf x3 = 22 Then
                    x3 = "M"
                ElseIf x3 = 23 Then
                    x3 = "N"
                ElseIf x3 = 24 Then
                    x3 = "O"
                ElseIf x3 = 25 Then
                    x3 = "P"
                ElseIf x3 = 26 Then
                    x3 = "Q"
                ElseIf x3 = 27 Then
                    x3 = "R"
                ElseIf x3 = 28 Then
                    x3 = "S"
                ElseIf x3 = 29 Then
                    x3 = "T"
                ElseIf x3 = 30 Then
                    x3 = "U"
                ElseIf x3 = 31 Then
                    x3 = "V"
                ElseIf x3 = 32 Then
                    x3 = "W"
                ElseIf x3 = 33 Then
                    x3 = "X"
                ElseIf x3 = 34 Then
                    x3 = "Y"
                ElseIf x3 = 35 Then
                    x3 = "Z"
                End If
                If x2 = 10 Then
                    x2 = "A"
                ElseIf x2 = 11 Then
                    x2 = "B"
                ElseIf x2 = 12 Then
                    x2 = "C"
                ElseIf x2 = 13 Then
                    x2 = "D"
                ElseIf x2 = 14 Then
                    x2 = "E"
                ElseIf x2 = 15 Then
                    x2 = "F"
                ElseIf x2 = 16 Then
                    x2 = "G"
                ElseIf x2 = 17 Then
                    x2 = "H"
                ElseIf x2 = 18 Then
                    x2 = "I"
                ElseIf x2 = 19 Then
                    x2 = "J"
                ElseIf x2 = 20 Then
                    x2 = "K"
                ElseIf x2 = 21 Then
                    x2 = "L"
                ElseIf x2 = 22 Then
                    x2 = "M"
                ElseIf x2 = 23 Then
                    x2 = "N"
                ElseIf x2 = 24 Then
                    x2 = "O"
                ElseIf x2 = 25 Then
                    x2 = "P"
                ElseIf x2 = 26 Then
                    x2 = "Q"
                ElseIf x2 = 27 Then
                    x2 = "R"
                ElseIf x2 = 28 Then
                    x2 = "S"
                ElseIf x2 = 29 Then
                    x2 = "T"
                ElseIf x2 = 30 Then
                    x2 = "U"
                ElseIf x2 = 31 Then
                    x2 = "V"
                ElseIf x2 = 32 Then
                    x2 = "W"
                ElseIf x2 = 33 Then
                    x2 = "X"
                ElseIf x2 = 34 Then
                    x2 = "Y"
                ElseIf x2 = 35 Then
                    x2 = "Z"
                End If
                If x1 = 10 Then
                    x1 = "A"
                ElseIf x1 = 11 Then
                    x1 = "B"
                ElseIf x1 = 12 Then
                    x1 = "C"
                ElseIf x1 = 13 Then
                    x1 = "D"
                ElseIf x1 = 14 Then
                    x1 = "E"
                ElseIf x1 = 15 Then
                    x1 = "F"
                ElseIf x1 = 16 Then
                    x1 = "G"
                ElseIf x1 = 17 Then
                    x1 = "H"
                ElseIf x1 = 18 Then
                    x1 = "I"
                ElseIf x1 = 19 Then
                    x1 = "J"
                ElseIf x1 = 20 Then
                    x1 = "K"
                ElseIf x1 = 21 Then
                    x1 = "L"
                ElseIf x1 = 22 Then
                    x1 = "M"
                ElseIf x1 = 23 Then
                    x1 = "N"
                ElseIf x1 = 24 Then
                    x1 = "O"
                ElseIf x1 = 25 Then
                    x1 = "P"
                ElseIf x1 = 26 Then
                    x1 = "Q"
                ElseIf x1 = 27 Then
                    x1 = "R"
                ElseIf x1 = 28 Then
                    x1 = "S"
                ElseIf x1 = 29 Then
                    x1 = "T"
                ElseIf x1 = 30 Then
                    x1 = "U"
                ElseIf x1 = 31 Then
                    x1 = "V"
                ElseIf x1 = 32 Then
                    x1 = "W"
                ElseIf x1 = 33 Then
                    x1 = "X"
                ElseIf x1 = 34 Then
                    x1 = "Y"
                ElseIf x1 = 35 Then
                    x1 = "Z"
                End If
                If x0 = 10 Then
                    x0 = "A"
                ElseIf x0 = 11 Then
                    x0 = "B"
                ElseIf x0 = 12 Then
                    x0 = "C"
                ElseIf x0 = 13 Then
                    x0 = "D"
                ElseIf x0 = 14 Then
                    x0 = "E"
                ElseIf x0 = 15 Then
                    x0 = "F"
                ElseIf x0 = 16 Then
                    x0 = "G"
                ElseIf x0 = 17 Then
                    x0 = "H"
                ElseIf x0 = 18 Then
                    x0 = "I"
                ElseIf x0 = 19 Then
                    x0 = "J"
                ElseIf x0 = 20 Then
                    x0 = "K"
                ElseIf x0 = 21 Then
                    x0 = "L"
                ElseIf x0 = 22 Then
                    x0 = "M"
                ElseIf x0 = 23 Then
                    x0 = "N"
                ElseIf x0 = 24 Then
                    x0 = "O"
                ElseIf x0 = 25 Then
                    x0 = "P"
                ElseIf x0 = 26 Then
                    x0 = "Q"
                ElseIf x0 = 27 Then
                    x0 = "R"
                ElseIf x0 = 28 Then
                    x0 = "S"
                ElseIf x0 = 29 Then
                    x0 = "T"
                ElseIf x0 = 30 Then
                    x0 = "U"
                ElseIf x0 = 31 Then
                    x0 = "V"
                ElseIf x0 = 32 Then
                    x0 = "W"
                ElseIf x0 = 33 Then
                    x0 = "X"
                ElseIf x0 = 34 Then
                    x0 = "Y"
                ElseIf x0 = 35 Then
                    x0 = "Z"
                End If
                Dim Z As String = x17.ToString + x16.ToString + x15.ToString + " " + x14.ToString + x13.ToString + x12.ToString + " " + x11.ToString + x10.ToString + x9.ToString + " " + x8.ToString + x7.ToString + x6.ToString + " " + x5.ToString + x4.ToString + x3.ToString + " " + x2.ToString + x1.ToString + x0.ToString
                TextBoxCalculationResults.Text = Z.ToString
            Else
                TextBoxCalculationResults.Text = "Math Error"
            End If
        ElseIf ComboBoxCalculationResults.Text <= 24 Then
            If Dec < (Y ^ 12) Then
                Dim x11m As String = Dec Mod (Y ^ 11)
                Dim x11 As String = Dec \ (Y ^ 11)
                Dim Line9 As String = Dec.ToString + " ÷ " + Y.ToString + " ^ 11 = " + x11.ToString + " ... " + x11m.ToString
                MyListBox.Items.Add(Line9)
                Dim x10m As String = x11m Mod (Y ^ 10)
                Dim x10 As String = x11m \ (Y ^ 10)
                Dim Line10 As String = x11m.ToString + " ÷ " + Y.ToString + " ^ 10 = " + x10.ToString + " ... " + x10m.ToString
                MyListBox.Items.Add(Line10)
                Dim x9m As String = x10m Mod (Y ^ 9)
                Dim x9 As String = x10m \ (Y ^ 9)
                Dim Line11 As String = x10m.ToString + " ÷ " + Y.ToString + " ^ 9 = " + x9.ToString + " ... " + x9m.ToString
                MyListBox.Items.Add(Line11)
                Dim x8m As String = x9m Mod (Y ^ 8)
                Dim x8 As String = x9m \ (Y ^ 8)
                Dim Line12 As String = x9m.ToString + " ÷ " + Y.ToString + " ^ 8 = " + x8.ToString + " ... " + x8m.ToString
                MyListBox.Items.Add(Line12)
                Dim x7m As String = x8m Mod (Y ^ 7)
                Dim x7 As String = x8m \ (Y ^ 7)
                Dim Line13 As String = x8m.ToString + " ÷ " + Y.ToString + " ^ 7 = " + x7.ToString + " ... " + x7m.ToString
                MyListBox.Items.Add(Line13)
                Dim x6m As String = x7m Mod (Y ^ 6)
                Dim x6 As String = x7m \ (Y ^ 6)
                Dim Line14 As String = x7m.ToString + " ÷ " + Y.ToString + " ^ 6 = " + x6.ToString + " ... " + x6m.ToString
                MyListBox.Items.Add(Line14)
                Dim x5m As String = x6m Mod (Y ^ 5)
                Dim x5 As String = x6m \ (Y ^ 5)
                Dim Line15 As String = x6m.ToString + " ÷ " + Y.ToString + " ^ 5 = " + x5.ToString + " ... " + x5m.ToString
                MyListBox.Items.Add(Line15)
                Dim x4m As String = x5m Mod (Y ^ 4)
                Dim x4 As String = x5m \ (Y ^ 4)
                Dim Line16 As String = x5m.ToString + " ÷ " + Y.ToString + " ^ 4 = " + x4.ToString + " ... " + x4m.ToString
                MyListBox.Items.Add(Line16)
                Dim x3m As String = x4m Mod (Y ^ 3)
                Dim x3 As String = x4m \ (Y ^ 3)
                Dim Line17 As String = x4m.ToString + " ÷ " + Y.ToString + " ^ 3 = " + x3.ToString + " ... " + x3m.ToString
                MyListBox.Items.Add(Line17)
                Dim x2m As String = x3m Mod (Y ^ 2)
                Dim x2 As String = x3m \ (Y ^ 2)
                Dim Line18 As String = x3m.ToString + " ÷ " + Y.ToString + " ^ 2 = " + x2.ToString + " ... " + x2m.ToString
                MyListBox.Items.Add(Line18)
                Dim x1m As String = x2m Mod (Y ^ 1)
                Dim x1 As String = x2m \ (Y ^ 1)
                Dim Line19 As String = x2m.ToString + " ÷ " + Y.ToString + " ^ 1 = " + x1.ToString + " ... " + x1m.ToString
                MyListBox.Items.Add(Line19)
                Dim x0m As String = x1m Mod (Y ^ 0)
                Dim x0 As String = x1m \ (Y ^ 0)
                Dim Line20 As String = x1m.ToString + " ÷ " + Y.ToString + " ^ 0 = " + x0.ToString + " ... " + x0m.ToString
                MyListBox.Items.Add(Line20)
                If x11 = 10 Then
                    x11 = "A"
                ElseIf x11 = 11 Then
                    x11 = "B"
                ElseIf x11 = 12 Then
                    x11 = "C"
                ElseIf x11 = 13 Then
                    x11 = "D"
                ElseIf x11 = 14 Then
                    x11 = "E"
                ElseIf x11 = 15 Then
                    x11 = "F"
                ElseIf x11 = 16 Then
                    x11 = "G"
                ElseIf x11 = 17 Then
                    x11 = "H"
                ElseIf x11 = 18 Then
                    x11 = "I"
                ElseIf x11 = 19 Then
                    x11 = "J"
                ElseIf x11 = 20 Then
                    x11 = "K"
                ElseIf x11 = 21 Then
                    x11 = "L"
                ElseIf x11 = 22 Then
                    x11 = "M"
                ElseIf x11 = 23 Then
                    x11 = "N"
                ElseIf x11 = 24 Then
                    x11 = "O"
                ElseIf x11 = 25 Then
                    x11 = "P"
                ElseIf x11 = 26 Then
                    x11 = "Q"
                ElseIf x11 = 27 Then
                    x11 = "R"
                ElseIf x11 = 28 Then
                    x11 = "S"
                ElseIf x11 = 29 Then
                    x11 = "T"
                ElseIf x11 = 30 Then
                    x11 = "U"
                ElseIf x11 = 31 Then
                    x11 = "V"
                ElseIf x11 = 32 Then
                    x11 = "W"
                ElseIf x11 = 33 Then
                    x11 = "X"
                ElseIf x11 = 34 Then
                    x11 = "Y"
                ElseIf x11 = 35 Then
                    x11 = "Z"
                End If
                If x10 = 10 Then
                    x10 = "A"
                ElseIf x10 = 11 Then
                    x10 = "B"
                ElseIf x10 = 12 Then
                    x10 = "C"
                ElseIf x10 = 13 Then
                    x10 = "D"
                ElseIf x10 = 14 Then
                    x10 = "E"
                ElseIf x10 = 15 Then
                    x10 = "F"
                ElseIf x10 = 16 Then
                    x10 = "G"
                ElseIf x10 = 17 Then
                    x10 = "H"
                ElseIf x10 = 18 Then
                    x10 = "I"
                ElseIf x10 = 19 Then
                    x10 = "J"
                ElseIf x10 = 20 Then
                    x10 = "K"
                ElseIf x10 = 21 Then
                    x10 = "L"
                ElseIf x10 = 22 Then
                    x10 = "M"
                ElseIf x10 = 23 Then
                    x10 = "N"
                ElseIf x10 = 24 Then
                    x10 = "O"
                ElseIf x10 = 25 Then
                    x10 = "P"
                ElseIf x10 = 26 Then
                    x10 = "Q"
                ElseIf x10 = 27 Then
                    x10 = "R"
                ElseIf x10 = 28 Then
                    x10 = "S"
                ElseIf x10 = 29 Then
                    x10 = "T"
                ElseIf x10 = 30 Then
                    x10 = "U"
                ElseIf x10 = 31 Then
                    x10 = "V"
                ElseIf x10 = 32 Then
                    x10 = "W"
                ElseIf x10 = 33 Then
                    x10 = "X"
                ElseIf x10 = 34 Then
                    x10 = "Y"
                ElseIf x10 = 35 Then
                    x10 = "Z"
                End If
                If x9 = 10 Then
                    x9 = "A"
                ElseIf x9 = 11 Then
                    x9 = "B"
                ElseIf x9 = 12 Then
                    x9 = "C"
                ElseIf x9 = 13 Then
                    x9 = "D"
                ElseIf x9 = 14 Then
                    x9 = "E"
                ElseIf x9 = 15 Then
                    x9 = "F"
                ElseIf x9 = 16 Then
                    x9 = "G"
                ElseIf x9 = 17 Then
                    x9 = "H"
                ElseIf x9 = 18 Then
                    x9 = "I"
                ElseIf x9 = 19 Then
                    x9 = "J"
                ElseIf x9 = 20 Then
                    x9 = "K"
                ElseIf x9 = 21 Then
                    x9 = "L"
                ElseIf x9 = 22 Then
                    x9 = "M"
                ElseIf x9 = 23 Then
                    x9 = "N"
                ElseIf x9 = 24 Then
                    x9 = "O"
                ElseIf x9 = 25 Then
                    x9 = "P"
                ElseIf x9 = 26 Then
                    x9 = "Q"
                ElseIf x9 = 27 Then
                    x9 = "R"
                ElseIf x9 = 28 Then
                    x9 = "S"
                ElseIf x9 = 29 Then
                    x9 = "T"
                ElseIf x9 = 30 Then
                    x9 = "U"
                ElseIf x9 = 31 Then
                    x9 = "V"
                ElseIf x9 = 32 Then
                    x9 = "W"
                ElseIf x9 = 33 Then
                    x9 = "X"
                ElseIf x9 = 34 Then
                    x9 = "Y"
                ElseIf x9 = 35 Then
                    x9 = "Z"
                End If
                If x8 = 10 Then
                    x8 = "A"
                ElseIf x8 = 11 Then
                    x8 = "B"
                ElseIf x8 = 12 Then
                    x8 = "C"
                ElseIf x8 = 13 Then
                    x8 = "D"
                ElseIf x8 = 14 Then
                    x8 = "E"
                ElseIf x8 = 15 Then
                    x8 = "F"
                ElseIf x8 = 16 Then
                    x8 = "G"
                ElseIf x8 = 17 Then
                    x8 = "H"
                ElseIf x8 = 18 Then
                    x8 = "I"
                ElseIf x8 = 19 Then
                    x8 = "J"
                ElseIf x8 = 20 Then
                    x8 = "K"
                ElseIf x8 = 21 Then
                    x8 = "L"
                ElseIf x8 = 22 Then
                    x8 = "M"
                ElseIf x8 = 23 Then
                    x8 = "N"
                ElseIf x8 = 24 Then
                    x8 = "O"
                ElseIf x8 = 25 Then
                    x8 = "P"
                ElseIf x8 = 26 Then
                    x8 = "Q"
                ElseIf x8 = 27 Then
                    x8 = "R"
                ElseIf x8 = 28 Then
                    x8 = "S"
                ElseIf x8 = 29 Then
                    x8 = "T"
                ElseIf x8 = 30 Then
                    x8 = "U"
                ElseIf x8 = 31 Then
                    x8 = "V"
                ElseIf x8 = 32 Then
                    x8 = "W"
                ElseIf x8 = 33 Then
                    x8 = "X"
                ElseIf x8 = 34 Then
                    x8 = "Y"
                ElseIf x8 = 35 Then
                    x8 = "Z"
                End If
                If x7 = 10 Then
                    x7 = "A"
                ElseIf x7 = 11 Then
                    x7 = "B"
                ElseIf x7 = 12 Then
                    x7 = "C"
                ElseIf x7 = 13 Then
                    x7 = "D"
                ElseIf x7 = 14 Then
                    x7 = "E"
                ElseIf x7 = 15 Then
                    x7 = "F"
                ElseIf x7 = 16 Then
                    x7 = "G"
                ElseIf x7 = 17 Then
                    x7 = "H"
                ElseIf x7 = 18 Then
                    x7 = "I"
                ElseIf x7 = 19 Then
                    x7 = "J"
                ElseIf x7 = 20 Then
                    x7 = "K"
                ElseIf x7 = 21 Then
                    x7 = "L"
                ElseIf x7 = 22 Then
                    x7 = "M"
                ElseIf x7 = 23 Then
                    x7 = "N"
                ElseIf x7 = 24 Then
                    x7 = "O"
                ElseIf x7 = 25 Then
                    x7 = "P"
                ElseIf x7 = 26 Then
                    x7 = "Q"
                ElseIf x7 = 27 Then
                    x7 = "R"
                ElseIf x7 = 28 Then
                    x7 = "S"
                ElseIf x7 = 29 Then
                    x7 = "T"
                ElseIf x7 = 30 Then
                    x7 = "U"
                ElseIf x7 = 31 Then
                    x7 = "V"
                ElseIf x7 = 32 Then
                    x7 = "W"
                ElseIf x7 = 33 Then
                    x7 = "X"
                ElseIf x7 = 34 Then
                    x7 = "Y"
                ElseIf x7 = 35 Then
                    x7 = "Z"
                End If
                If x6 = 10 Then
                    x6 = "A"
                ElseIf x6 = 11 Then
                    x6 = "B"
                ElseIf x6 = 12 Then
                    x6 = "C"
                ElseIf x6 = 13 Then
                    x6 = "D"
                ElseIf x6 = 14 Then
                    x6 = "E"
                ElseIf x6 = 15 Then
                    x6 = "F"
                ElseIf x6 = 16 Then
                    x6 = "G"
                ElseIf x6 = 17 Then
                    x6 = "H"
                ElseIf x6 = 18 Then
                    x6 = "I"
                ElseIf x6 = 19 Then
                    x6 = "J"
                ElseIf x6 = 20 Then
                    x6 = "K"
                ElseIf x6 = 21 Then
                    x6 = "L"
                ElseIf x6 = 22 Then
                    x6 = "M"
                ElseIf x6 = 23 Then
                    x6 = "N"
                ElseIf x6 = 24 Then
                    x6 = "O"
                ElseIf x6 = 25 Then
                    x6 = "P"
                ElseIf x6 = 26 Then
                    x6 = "Q"
                ElseIf x6 = 27 Then
                    x6 = "R"
                ElseIf x6 = 28 Then
                    x6 = "S"
                ElseIf x6 = 29 Then
                    x6 = "T"
                ElseIf x6 = 30 Then
                    x6 = "U"
                ElseIf x6 = 31 Then
                    x6 = "V"
                ElseIf x6 = 32 Then
                    x6 = "W"
                ElseIf x6 = 33 Then
                    x6 = "X"
                ElseIf x6 = 34 Then
                    x6 = "Y"
                ElseIf x6 = 35 Then
                    x6 = "Z"
                End If
                If x5 = 10 Then
                    x5 = "A"
                ElseIf x5 = 11 Then
                    x5 = "B"
                ElseIf x5 = 12 Then
                    x5 = "C"
                ElseIf x5 = 13 Then
                    x5 = "D"
                ElseIf x5 = 14 Then
                    x5 = "E"
                ElseIf x5 = 15 Then
                    x5 = "F"
                ElseIf x5 = 16 Then
                    x5 = "G"
                ElseIf x5 = 17 Then
                    x5 = "H"
                ElseIf x5 = 18 Then
                    x5 = "I"
                ElseIf x5 = 19 Then
                    x5 = "J"
                ElseIf x5 = 20 Then
                    x5 = "K"
                ElseIf x5 = 21 Then
                    x5 = "L"
                ElseIf x5 = 22 Then
                    x5 = "M"
                ElseIf x5 = 23 Then
                    x5 = "N"
                ElseIf x5 = 24 Then
                    x5 = "O"
                ElseIf x5 = 25 Then
                    x5 = "P"
                ElseIf x5 = 26 Then
                    x5 = "Q"
                ElseIf x5 = 27 Then
                    x5 = "R"
                ElseIf x5 = 28 Then
                    x5 = "S"
                ElseIf x5 = 29 Then
                    x5 = "T"
                ElseIf x5 = 30 Then
                    x5 = "U"
                ElseIf x5 = 31 Then
                    x5 = "V"
                ElseIf x5 = 32 Then
                    x5 = "W"
                ElseIf x5 = 33 Then
                    x5 = "X"
                ElseIf x5 = 34 Then
                    x5 = "Y"
                ElseIf x5 = 35 Then
                    x5 = "Z"
                End If
                If x4 = 10 Then
                    x4 = "A"
                ElseIf x4 = 11 Then
                    x4 = "B"
                ElseIf x4 = 12 Then
                    x4 = "C"
                ElseIf x4 = 13 Then
                    x4 = "D"
                ElseIf x4 = 14 Then
                    x4 = "E"
                ElseIf x4 = 15 Then
                    x4 = "F"
                ElseIf x4 = 16 Then
                    x4 = "G"
                ElseIf x4 = 17 Then
                    x4 = "H"
                ElseIf x4 = 18 Then
                    x4 = "I"
                ElseIf x4 = 19 Then
                    x4 = "J"
                ElseIf x4 = 20 Then
                    x4 = "K"
                ElseIf x4 = 21 Then
                    x4 = "L"
                ElseIf x4 = 22 Then
                    x4 = "M"
                ElseIf x4 = 23 Then
                    x4 = "N"
                ElseIf x4 = 24 Then
                    x4 = "O"
                ElseIf x4 = 25 Then
                    x4 = "P"
                ElseIf x4 = 26 Then
                    x4 = "Q"
                ElseIf x4 = 27 Then
                    x4 = "R"
                ElseIf x4 = 28 Then
                    x4 = "S"
                ElseIf x4 = 29 Then
                    x4 = "T"
                ElseIf x4 = 30 Then
                    x4 = "U"
                ElseIf x4 = 31 Then
                    x4 = "V"
                ElseIf x4 = 32 Then
                    x4 = "W"
                ElseIf x4 = 33 Then
                    x4 = "X"
                ElseIf x4 = 34 Then
                    x4 = "Y"
                ElseIf x4 = 35 Then
                    x4 = "Z"
                End If
                If x3 = 10 Then
                    x3 = "A"
                ElseIf x3 = 11 Then
                    x3 = "B"
                ElseIf x3 = 12 Then
                    x3 = "C"
                ElseIf x3 = 13 Then
                    x3 = "D"
                ElseIf x3 = 14 Then
                    x3 = "E"
                ElseIf x3 = 15 Then
                    x3 = "F"
                ElseIf x3 = 16 Then
                    x3 = "G"
                ElseIf x3 = 17 Then
                    x3 = "H"
                ElseIf x3 = 18 Then
                    x3 = "I"
                ElseIf x3 = 19 Then
                    x3 = "J"
                ElseIf x3 = 20 Then
                    x3 = "K"
                ElseIf x3 = 21 Then
                    x3 = "L"
                ElseIf x3 = 22 Then
                    x3 = "M"
                ElseIf x3 = 23 Then
                    x3 = "N"
                ElseIf x3 = 24 Then
                    x3 = "O"
                ElseIf x3 = 25 Then
                    x3 = "P"
                ElseIf x3 = 26 Then
                    x3 = "Q"
                ElseIf x3 = 27 Then
                    x3 = "R"
                ElseIf x3 = 28 Then
                    x3 = "S"
                ElseIf x3 = 29 Then
                    x3 = "T"
                ElseIf x3 = 30 Then
                    x3 = "U"
                ElseIf x3 = 31 Then
                    x3 = "V"
                ElseIf x3 = 32 Then
                    x3 = "W"
                ElseIf x3 = 33 Then
                    x3 = "X"
                ElseIf x3 = 34 Then
                    x3 = "Y"
                ElseIf x3 = 35 Then
                    x3 = "Z"
                End If
                If x2 = 10 Then
                    x2 = "A"
                ElseIf x2 = 11 Then
                    x2 = "B"
                ElseIf x2 = 12 Then
                    x2 = "C"
                ElseIf x2 = 13 Then
                    x2 = "D"
                ElseIf x2 = 14 Then
                    x2 = "E"
                ElseIf x2 = 15 Then
                    x2 = "F"
                ElseIf x2 = 16 Then
                    x2 = "G"
                ElseIf x2 = 17 Then
                    x2 = "H"
                ElseIf x2 = 18 Then
                    x2 = "I"
                ElseIf x2 = 19 Then
                    x2 = "J"
                ElseIf x2 = 20 Then
                    x2 = "K"
                ElseIf x2 = 21 Then
                    x2 = "L"
                ElseIf x2 = 22 Then
                    x2 = "M"
                ElseIf x2 = 23 Then
                    x2 = "N"
                ElseIf x2 = 24 Then
                    x2 = "O"
                ElseIf x2 = 25 Then
                    x2 = "P"
                ElseIf x2 = 26 Then
                    x2 = "Q"
                ElseIf x2 = 27 Then
                    x2 = "R"
                ElseIf x2 = 28 Then
                    x2 = "S"
                ElseIf x2 = 29 Then
                    x2 = "T"
                ElseIf x2 = 30 Then
                    x2 = "U"
                ElseIf x2 = 31 Then
                    x2 = "V"
                ElseIf x2 = 32 Then
                    x2 = "W"
                ElseIf x2 = 33 Then
                    x2 = "X"
                ElseIf x2 = 34 Then
                    x2 = "Y"
                ElseIf x2 = 35 Then
                    x2 = "Z"
                End If
                If x1 = 10 Then
                    x1 = "A"
                ElseIf x1 = 11 Then
                    x1 = "B"
                ElseIf x1 = 12 Then
                    x1 = "C"
                ElseIf x1 = 13 Then
                    x1 = "D"
                ElseIf x1 = 14 Then
                    x1 = "E"
                ElseIf x1 = 15 Then
                    x1 = "F"
                ElseIf x1 = 16 Then
                    x1 = "G"
                ElseIf x1 = 17 Then
                    x1 = "H"
                ElseIf x1 = 18 Then
                    x1 = "I"
                ElseIf x1 = 19 Then
                    x1 = "J"
                ElseIf x1 = 20 Then
                    x1 = "K"
                ElseIf x1 = 21 Then
                    x1 = "L"
                ElseIf x1 = 22 Then
                    x1 = "M"
                ElseIf x1 = 23 Then
                    x1 = "N"
                ElseIf x1 = 24 Then
                    x1 = "O"
                ElseIf x1 = 25 Then
                    x1 = "P"
                ElseIf x1 = 26 Then
                    x1 = "Q"
                ElseIf x1 = 27 Then
                    x1 = "R"
                ElseIf x1 = 28 Then
                    x1 = "S"
                ElseIf x1 = 29 Then
                    x1 = "T"
                ElseIf x1 = 30 Then
                    x1 = "U"
                ElseIf x1 = 31 Then
                    x1 = "V"
                ElseIf x1 = 32 Then
                    x1 = "W"
                ElseIf x1 = 33 Then
                    x1 = "X"
                ElseIf x1 = 34 Then
                    x1 = "Y"
                ElseIf x1 = 35 Then
                    x1 = "Z"
                End If
                If x0 = 10 Then
                    x0 = "A"
                ElseIf x0 = 11 Then
                    x0 = "B"
                ElseIf x0 = 12 Then
                    x0 = "C"
                ElseIf x0 = 13 Then
                    x0 = "D"
                ElseIf x0 = 14 Then
                    x0 = "E"
                ElseIf x0 = 15 Then
                    x0 = "F"
                ElseIf x0 = 16 Then
                    x0 = "G"
                ElseIf x0 = 17 Then
                    x0 = "H"
                ElseIf x0 = 18 Then
                    x0 = "I"
                ElseIf x0 = 19 Then
                    x0 = "J"
                ElseIf x0 = 20 Then
                    x0 = "K"
                ElseIf x0 = 21 Then
                    x0 = "L"
                ElseIf x0 = 22 Then
                    x0 = "M"
                ElseIf x0 = 23 Then
                    x0 = "N"
                ElseIf x0 = 24 Then
                    x0 = "O"
                ElseIf x0 = 25 Then
                    x0 = "P"
                ElseIf x0 = 26 Then
                    x0 = "Q"
                ElseIf x0 = 27 Then
                    x0 = "R"
                ElseIf x0 = 28 Then
                    x0 = "S"
                ElseIf x0 = 29 Then
                    x0 = "T"
                ElseIf x0 = 30 Then
                    x0 = "U"
                ElseIf x0 = 31 Then
                    x0 = "V"
                ElseIf x0 = 32 Then
                    x0 = "W"
                ElseIf x0 = 33 Then
                    x0 = "X"
                ElseIf x0 = 34 Then
                    x0 = "Y"
                ElseIf x0 = 35 Then
                    x0 = "Z"
                End If
                Dim Z As String = x11.ToString + x10.ToString + x9.ToString + " " + x8.ToString + x7.ToString + x6.ToString + " " + x5.ToString + x4.ToString + x3.ToString + " " + x2.ToString + x1.ToString + x0.ToString
                TextBoxCalculationResults.Text = Z.ToString
            Else
                TextBoxCalculationResults.Text = "Math Error"
            End If
        ElseIf ComboBoxCalculationResults.Text <= 36 Then
            If Dec < (Y ^ 6) Then
                Dim x5m As String = Dec Mod (Y ^ 5)
                Dim x5 As String = Dec \ (Y ^ 5)
                Dim Line15 As String = Dec.ToString + " ÷ " + Y.ToString + " ^ 5 = " + x5.ToString + " ... " + x5m.ToString
                MyListBox.Items.Add(Line15)
                Dim x4m As String = x5m Mod (Y ^ 4)
                Dim x4 As String = x5m \ (Y ^ 4)
                Dim Line16 As String = x5m.ToString + " ÷ " + Y.ToString + " ^ 4 = " + x4.ToString + " ... " + x4m.ToString
                MyListBox.Items.Add(Line16)
                Dim x3m As String = x4m Mod (Y ^ 3)
                Dim x3 As String = x4m \ (Y ^ 3)
                Dim Line17 As String = x4m.ToString + " ÷ " + Y.ToString + " ^ 3 = " + x3.ToString + " ... " + x3m.ToString
                MyListBox.Items.Add(Line17)
                Dim x2m As String = x3m Mod (Y ^ 2)
                Dim x2 As String = x3m \ (Y ^ 2)
                Dim Line18 As String = x3m.ToString + " ÷ " + Y.ToString + " ^ 2 = " + x2.ToString + " ... " + x2m.ToString
                MyListBox.Items.Add(Line18)
                Dim x1m As String = x2m Mod (Y ^ 1)
                Dim x1 As String = x2m \ (Y ^ 1)
                Dim Line19 As String = x2m.ToString + " ÷ " + Y.ToString + " ^ 1 = " + x1.ToString + " ... " + x1m.ToString
                MyListBox.Items.Add(Line19)
                Dim x0m As String = x1m Mod (Y ^ 0)
                Dim x0 As String = x1m \ (Y ^ 0)
                Dim Line20 As String = x1m.ToString + " ÷ " + Y.ToString + " ^ 0 = " + x0.ToString + " ... " + x0m.ToString
                MyListBox.Items.Add(Line20)
                If x5 = 10 Then
                    x5 = "A"
                ElseIf x5 = 11 Then
                    x5 = "B"
                ElseIf x5 = 12 Then
                    x5 = "C"
                ElseIf x5 = 13 Then
                    x5 = "D"
                ElseIf x5 = 14 Then
                    x5 = "E"
                ElseIf x5 = 15 Then
                    x5 = "F"
                ElseIf x5 = 16 Then
                    x5 = "G"
                ElseIf x5 = 17 Then
                    x5 = "H"
                ElseIf x5 = 18 Then
                    x5 = "I"
                ElseIf x5 = 19 Then
                    x5 = "J"
                ElseIf x5 = 20 Then
                    x5 = "K"
                ElseIf x5 = 21 Then
                    x5 = "L"
                ElseIf x5 = 22 Then
                    x5 = "M"
                ElseIf x5 = 23 Then
                    x5 = "N"
                ElseIf x5 = 24 Then
                    x5 = "O"
                ElseIf x5 = 25 Then
                    x5 = "P"
                ElseIf x5 = 26 Then
                    x5 = "Q"
                ElseIf x5 = 27 Then
                    x5 = "R"
                ElseIf x5 = 28 Then
                    x5 = "S"
                ElseIf x5 = 29 Then
                    x5 = "T"
                ElseIf x5 = 30 Then
                    x5 = "U"
                ElseIf x5 = 31 Then
                    x5 = "V"
                ElseIf x5 = 32 Then
                    x5 = "W"
                ElseIf x5 = 33 Then
                    x5 = "X"
                ElseIf x5 = 34 Then
                    x5 = "Y"
                ElseIf x5 = 35 Then
                    x5 = "Z"
                End If
                If x4 = 10 Then
                    x4 = "A"
                ElseIf x4 = 11 Then
                    x4 = "B"
                ElseIf x4 = 12 Then
                    x4 = "C"
                ElseIf x4 = 13 Then
                    x4 = "D"
                ElseIf x4 = 14 Then
                    x4 = "E"
                ElseIf x4 = 15 Then
                    x4 = "F"
                ElseIf x4 = 16 Then
                    x4 = "G"
                ElseIf x4 = 17 Then
                    x4 = "H"
                ElseIf x4 = 18 Then
                    x4 = "I"
                ElseIf x4 = 19 Then
                    x4 = "J"
                ElseIf x4 = 20 Then
                    x4 = "K"
                ElseIf x4 = 21 Then
                    x4 = "L"
                ElseIf x4 = 22 Then
                    x4 = "M"
                ElseIf x4 = 23 Then
                    x4 = "N"
                ElseIf x4 = 24 Then
                    x4 = "O"
                ElseIf x4 = 25 Then
                    x4 = "P"
                ElseIf x4 = 26 Then
                    x4 = "Q"
                ElseIf x4 = 27 Then
                    x4 = "R"
                ElseIf x4 = 28 Then
                    x4 = "S"
                ElseIf x4 = 29 Then
                    x4 = "T"
                ElseIf x4 = 30 Then
                    x4 = "U"
                ElseIf x4 = 31 Then
                    x4 = "V"
                ElseIf x4 = 32 Then
                    x4 = "W"
                ElseIf x4 = 33 Then
                    x4 = "X"
                ElseIf x4 = 34 Then
                    x4 = "Y"
                ElseIf x4 = 35 Then
                    x4 = "Z"
                End If
                If x3 = 10 Then
                    x3 = "A"
                ElseIf x3 = 11 Then
                    x3 = "B"
                ElseIf x3 = 12 Then
                    x3 = "C"
                ElseIf x3 = 13 Then
                    x3 = "D"
                ElseIf x3 = 14 Then
                    x3 = "E"
                ElseIf x3 = 15 Then
                    x3 = "F"
                ElseIf x3 = 16 Then
                    x3 = "G"
                ElseIf x3 = 17 Then
                    x3 = "H"
                ElseIf x3 = 18 Then
                    x3 = "I"
                ElseIf x3 = 19 Then
                    x3 = "J"
                ElseIf x3 = 20 Then
                    x3 = "K"
                ElseIf x3 = 21 Then
                    x3 = "L"
                ElseIf x3 = 22 Then
                    x3 = "M"
                ElseIf x3 = 23 Then
                    x3 = "N"
                ElseIf x3 = 24 Then
                    x3 = "O"
                ElseIf x3 = 25 Then
                    x3 = "P"
                ElseIf x3 = 26 Then
                    x3 = "Q"
                ElseIf x3 = 27 Then
                    x3 = "R"
                ElseIf x3 = 28 Then
                    x3 = "S"
                ElseIf x3 = 29 Then
                    x3 = "T"
                ElseIf x3 = 30 Then
                    x3 = "U"
                ElseIf x3 = 31 Then
                    x3 = "V"
                ElseIf x3 = 32 Then
                    x3 = "W"
                ElseIf x3 = 33 Then
                    x3 = "X"
                ElseIf x3 = 34 Then
                    x3 = "Y"
                ElseIf x3 = 35 Then
                    x3 = "Z"
                End If
                If x2 = 10 Then
                    x2 = "A"
                ElseIf x2 = 11 Then
                    x2 = "B"
                ElseIf x2 = 12 Then
                    x2 = "C"
                ElseIf x2 = 13 Then
                    x2 = "D"
                ElseIf x2 = 14 Then
                    x2 = "E"
                ElseIf x2 = 15 Then
                    x2 = "F"
                ElseIf x2 = 16 Then
                    x2 = "G"
                ElseIf x2 = 17 Then
                    x2 = "H"
                ElseIf x2 = 18 Then
                    x2 = "I"
                ElseIf x2 = 19 Then
                    x2 = "J"
                ElseIf x2 = 20 Then
                    x2 = "K"
                ElseIf x2 = 21 Then
                    x2 = "L"
                ElseIf x2 = 22 Then
                    x2 = "M"
                ElseIf x2 = 23 Then
                    x2 = "N"
                ElseIf x2 = 24 Then
                    x2 = "O"
                ElseIf x2 = 25 Then
                    x2 = "P"
                ElseIf x2 = 26 Then
                    x2 = "Q"
                ElseIf x2 = 27 Then
                    x2 = "R"
                ElseIf x2 = 28 Then
                    x2 = "S"
                ElseIf x2 = 29 Then
                    x2 = "T"
                ElseIf x2 = 30 Then
                    x2 = "U"
                ElseIf x2 = 31 Then
                    x2 = "V"
                ElseIf x2 = 32 Then
                    x2 = "W"
                ElseIf x2 = 33 Then
                    x2 = "X"
                ElseIf x2 = 34 Then
                    x2 = "Y"
                ElseIf x2 = 35 Then
                    x2 = "Z"
                End If
                If x1 = 10 Then
                    x1 = "A"
                ElseIf x1 = 11 Then
                    x1 = "B"
                ElseIf x1 = 12 Then
                    x1 = "C"
                ElseIf x1 = 13 Then
                    x1 = "D"
                ElseIf x1 = 14 Then
                    x1 = "E"
                ElseIf x1 = 15 Then
                    x1 = "F"
                ElseIf x1 = 16 Then
                    x1 = "G"
                ElseIf x1 = 17 Then
                    x1 = "H"
                ElseIf x1 = 18 Then
                    x1 = "I"
                ElseIf x1 = 19 Then
                    x1 = "J"
                ElseIf x1 = 20 Then
                    x1 = "K"
                ElseIf x1 = 21 Then
                    x1 = "L"
                ElseIf x1 = 22 Then
                    x1 = "M"
                ElseIf x1 = 23 Then
                    x1 = "N"
                ElseIf x1 = 24 Then
                    x1 = "O"
                ElseIf x1 = 25 Then
                    x1 = "P"
                ElseIf x1 = 26 Then
                    x1 = "Q"
                ElseIf x1 = 27 Then
                    x1 = "R"
                ElseIf x1 = 28 Then
                    x1 = "S"
                ElseIf x1 = 29 Then
                    x1 = "T"
                ElseIf x1 = 30 Then
                    x1 = "U"
                ElseIf x1 = 31 Then
                    x1 = "V"
                ElseIf x1 = 32 Then
                    x1 = "W"
                ElseIf x1 = 33 Then
                    x1 = "X"
                ElseIf x1 = 34 Then
                    x1 = "Y"
                ElseIf x1 = 35 Then
                    x1 = "Z"
                End If
                If x0 = 10 Then
                    x0 = "A"
                ElseIf x0 = 11 Then
                    x0 = "B"
                ElseIf x0 = 12 Then
                    x0 = "C"
                ElseIf x0 = 13 Then
                    x0 = "D"
                ElseIf x0 = 14 Then
                    x0 = "E"
                ElseIf x0 = 15 Then
                    x0 = "F"
                ElseIf x0 = 16 Then
                    x0 = "G"
                ElseIf x0 = 17 Then
                    x0 = "H"
                ElseIf x0 = 18 Then
                    x0 = "I"
                ElseIf x0 = 19 Then
                    x0 = "J"
                ElseIf x0 = 20 Then
                    x0 = "K"
                ElseIf x0 = 21 Then
                    x0 = "L"
                ElseIf x0 = 22 Then
                    x0 = "M"
                ElseIf x0 = 23 Then
                    x0 = "N"
                ElseIf x0 = 24 Then
                    x0 = "O"
                ElseIf x0 = 25 Then
                    x0 = "P"
                ElseIf x0 = 26 Then
                    x0 = "Q"
                ElseIf x0 = 27 Then
                    x0 = "R"
                ElseIf x0 = 28 Then
                    x0 = "S"
                ElseIf x0 = 29 Then
                    x0 = "T"
                ElseIf x0 = 30 Then
                    x0 = "U"
                ElseIf x0 = 31 Then
                    x0 = "V"
                ElseIf x0 = 32 Then
                    x0 = "W"
                ElseIf x0 = 33 Then
                    x0 = "X"
                ElseIf x0 = 34 Then
                    x0 = "Y"
                ElseIf x0 = 35 Then
                    x0 = "Z"
                End If
                Dim Z As String = x5.ToString + x4.ToString + x3.ToString + " " + x2.ToString + x1.ToString + x0.ToString
                TextBoxCalculationResults.Text = Z.ToString
            Else
                TextBoxCalculationResults.Text = "Math Error"
            End If
        End If
    End Sub
    Private Sub keys0_Click(sender As Object, e As EventArgs) Handles keys0.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "0"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "0"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "0"
        End If
        C()
    End Sub
    Private Sub keys1_Click(sender As Object, e As EventArgs) Handles keys1.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "1"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "1"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "1"
        End If
        C()
    End Sub
    Private Sub keys2_Click(sender As Object, e As EventArgs) Handles keys2.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "2"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "2"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "2"
        End If
        C()
    End Sub
    Private Sub keys3_Click(sender As Object, e As EventArgs) Handles keys3.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "3"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "3"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "3"
        End If
        C()
    End Sub
    Private Sub keys4_Click(sender As Object, e As EventArgs) Handles keys4.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "4"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "4"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "4"
        End If
        C()
    End Sub
    Private Sub keys5_Click(sender As Object, e As EventArgs) Handles keys5.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "5"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "5"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "5"
        End If
        C()
    End Sub
    Private Sub keys6_Click(sender As Object, e As EventArgs) Handles keys6.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "6"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "6"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "6"
        End If
        C()
    End Sub
    Private Sub keys7_Click(sender As Object, e As EventArgs) Handles keys7.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "7"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "7"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "7"
        End If
        C()
    End Sub
    Private Sub keys8_Click(sender As Object, e As EventArgs) Handles keys8.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "8"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "8"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "8"
        End If
        C()
    End Sub
    Private Sub keys9_Click(sender As Object, e As EventArgs) Handles keys9.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "9"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "9"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "9"
        End If
        C()
    End Sub
    Private Sub keysA_Click(sender As Object, e As EventArgs) Handles keysA.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "A"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "A"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "A"
        End If
        C()
    End Sub
    Private Sub keysB_Click(sender As Object, e As EventArgs) Handles keysB.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "B"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "B"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "B"
        End If
        C()
    End Sub
    Private Sub keysC_Click(sender As Object, e As EventArgs) Handles keysC.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "C"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "C"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "C"
        End If
        C()
    End Sub
    Private Sub keysD_Click(sender As Object, e As EventArgs) Handles keysD.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "D"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "D"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "D"
        End If
        C()
    End Sub
    Private Sub keysE_Click(sender As Object, e As EventArgs) Handles keysE.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "E"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "E"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "E"
        End If
        C()
    End Sub
    Private Sub keysF_Click(sender As Object, e As EventArgs) Handles keysF.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "F"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "F"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "F"
        End If
        C()
    End Sub
    Private Sub keysG_Click(sender As Object, e As EventArgs) Handles keysG.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "G"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "G"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "G"
        End If
        C()
    End Sub
    Private Sub keysH_Click(sender As Object, e As EventArgs) Handles keysH.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "H"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "H"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "H"
        End If
        C()
    End Sub
    Private Sub keysI_Click(sender As Object, e As EventArgs) Handles keysI.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "I"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "I"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "I"
        End If
        C()
    End Sub
    Private Sub keysJ_Click(sender As Object, e As EventArgs) Handles keysJ.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "J"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "J"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "J"
        End If
        C()
    End Sub
    Private Sub keysK_Click(sender As Object, e As EventArgs) Handles keysK.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "K"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "K"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "K"
        End If
        C()
    End Sub
    Private Sub keysL_Click(sender As Object, e As EventArgs) Handles keysL.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "L"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "L"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "L"
        End If
        C()
    End Sub
    Private Sub keysM_Click(sender As Object, e As EventArgs) Handles keysM.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "M"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "M"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "M"
        End If
        C()
    End Sub
    Private Sub keysN_Click(sender As Object, e As EventArgs) Handles keysN.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "N"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "N"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "N"
        End If
        C()
    End Sub
    Private Sub keysO_Click(sender As Object, e As EventArgs) Handles keysO.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "O"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "O"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "O"
        End If
        C()
    End Sub
    Private Sub keysP_Click(sender As Object, e As EventArgs) Handles keysP.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "P"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "P"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "P"
        End If
        C()
    End Sub
    Private Sub keysQ_Click(sender As Object, e As EventArgs) Handles keysQ.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "Q"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "Q"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "Q"
        End If
        C()
    End Sub
    Private Sub keysR_Click(sender As Object, e As EventArgs) Handles keysR.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "R"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "R"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "R"
        End If
        C()
    End Sub
    Private Sub keysS_Click(sender As Object, e As EventArgs) Handles keysS.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "S"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "S"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "S"
        End If
        C()
    End Sub
    Private Sub keysT_Click(sender As Object, e As EventArgs) Handles keysT.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "T"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "T"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "T"
        End If
        C()
    End Sub
    Private Sub keysU_Click(sender As Object, e As EventArgs) Handles keysU.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "U"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "U"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "U"
        End If
        C()
    End Sub
    Private Sub keysV_Click(sender As Object, e As EventArgs) Handles keysV.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "V"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "V"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "V"
        End If
        C()
    End Sub
    Private Sub keysW_Click(sender As Object, e As EventArgs) Handles keysW.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "W"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "W"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "W"
        End If
        C()
    End Sub
    Private Sub keysX_Click(sender As Object, e As EventArgs) Handles keysX.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "X"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "X"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "X"
        End If
        C()
    End Sub
    Private Sub keysY_Click(sender As Object, e As EventArgs) Handles keysY.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "Y"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "Y"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "Y"
        End If
        C()
    End Sub
    Private Sub keysZ_Click(sender As Object, e As EventArgs) Handles keysZ.Click
        If TextBoxInput.Text = "Z" Then
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = "Z"
        End If
        If TextBoxInput.Text = "Y" Then
            TextBoxX.Text = TextBoxZ.Text
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = "Z"
        End If
        If TextBoxInput.Text = "X" Then
            TextBoxZ.Text = TextBoxY.Text
            TextBoxY.Text = TextBoxX.Text
            TextBoxX.Text = "Z"
        End If
        C()
    End Sub
    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        TextBoxX.Text = 0
        TextBoxY.Text = 0
        TextBoxZ.Text = 0
        TextBoxCalculationResults.Text = 0
        TextBoxInput.Text = "X"
        MyListBox.Items.Clear()
        MyListBox.Items.Add("(Nothing)")
    End Sub
    Dim V As Integer = 1
    Private Sub k0_Click(sender As Object, e As EventArgs) Handles k0.Click
        If V = 64 = False Then
            If TextboxHex.Text = "0x 0" And Val(TextBoxBin.Text) = 0 Then
                TextboxHex.Text = "0x "
                TextBoxBin.Text = Nothing
                V = 0
            End If
            TextboxHex.Text = TextboxHex.Text.ToString + "0"
            TextBoxBin.Text = TextBoxBin.Text.ToString + " 0000"
            V = V + 1
        End If
    End Sub
    Private Sub k1_Click(sender As Object, e As EventArgs) Handles k1.Click
        If V = 64 = False Then
            If TextboxHex.Text = "0x 0" And Val(TextBoxBin.Text) = 0 Then
                TextboxHex.Text = "0x "
                TextBoxBin.Text = Nothing
                V = 0
            End If
            TextboxHex.Text = TextboxHex.Text.ToString + "1"
            TextBoxBin.Text = TextBoxBin.Text.ToString + " 0001"
            V = V + 1
        End If
    End Sub
    Private Sub k2_Click(sender As Object, e As EventArgs) Handles k2.Click
        If V = 64 = False Then
            If TextboxHex.Text = "0x 0" And Val(TextBoxBin.Text) = 0 Then
                TextboxHex.Text = "0x "
                TextBoxBin.Text = Nothing
                V = 0
            End If
            TextboxHex.Text = TextboxHex.Text.ToString + "2"
            TextBoxBin.Text = TextBoxBin.Text.ToString + " 0010"
            V = V + 1
        End If
    End Sub
    Private Sub k3_Click(sender As Object, e As EventArgs) Handles k3.Click
        If V = 64 = False Then
            If TextboxHex.Text = "0x 0" And Val(TextBoxBin.Text) = 0 Then
                TextboxHex.Text = "0x "
                TextBoxBin.Text = Nothing
                V = 0
            End If
            TextboxHex.Text = TextboxHex.Text.ToString + "3"
            TextBoxBin.Text = TextBoxBin.Text.ToString + " 0011"
            V = V + 1
        End If
    End Sub
    Private Sub k4_Click(sender As Object, e As EventArgs) Handles k4.Click
        If V = 64 = False Then
            If TextboxHex.Text = "0x 0" And Val(TextBoxBin.Text) = 0 Then
                TextboxHex.Text = "0x "
                TextBoxBin.Text = Nothing
                V = 0
            End If
            TextboxHex.Text = TextboxHex.Text.ToString + "4"
            TextBoxBin.Text = TextBoxBin.Text.ToString + " 0100"
            V = V + 1
        End If
    End Sub
    Private Sub k5_Click(sender As Object, e As EventArgs) Handles k5.Click
        If V = 64 = False Then
            If TextboxHex.Text = "0x 0" And Val(TextBoxBin.Text) = 0 Then
                TextboxHex.Text = "0x "
                TextBoxBin.Text = Nothing
                V = 0
            End If
            TextboxHex.Text = TextboxHex.Text.ToString + "5"
            TextBoxBin.Text = TextBoxBin.Text.ToString + " 0101"
            V = V + 1
        End If
    End Sub
    Private Sub k6_Click(sender As Object, e As EventArgs) Handles k6.Click
        If V = 64 = False Then
            If TextboxHex.Text = "0x 0" And Val(TextBoxBin.Text) = 0 Then
                TextboxHex.Text = "0x "
                TextBoxBin.Text = Nothing
                V = 0
            End If
            TextboxHex.Text = TextboxHex.Text.ToString + "6"
            TextBoxBin.Text = TextBoxBin.Text.ToString + " 0110"
            V = V + 1
        End If
    End Sub
    Private Sub k7_Click(sender As Object, e As EventArgs) Handles k7.Click
        If V = 64 = False Then
            If TextboxHex.Text = "0x 0" And Val(TextBoxBin.Text) = 0 Then
                TextboxHex.Text = "0x "
                TextBoxBin.Text = Nothing
                V = 0
            End If
            TextboxHex.Text = TextboxHex.Text.ToString + "7"
            TextBoxBin.Text = TextBoxBin.Text.ToString + " 0111"
            V = V + 1
        End If
    End Sub
    Private Sub k8_Click(sender As Object, e As EventArgs) Handles k8.Click
        If V = 64 = False Then
            If TextboxHex.Text = "0x 0" And Val(TextBoxBin.Text) = 0 Then
                TextboxHex.Text = "0x "
                TextBoxBin.Text = Nothing
                V = 0
            End If
            TextboxHex.Text = TextboxHex.Text.ToString + "8"
            TextBoxBin.Text = TextBoxBin.Text.ToString + " 1000"
            V = V + 1
        End If
    End Sub
    Private Sub k9_Click(sender As Object, e As EventArgs) Handles k9.Click
        If V = 64 = False Then
            If TextboxHex.Text = "0x 0" And Val(TextBoxBin.Text) = 0 Then
                TextboxHex.Text = "0x "
                TextBoxBin.Text = Nothing
                V = 0
            End If
            TextboxHex.Text = TextboxHex.Text.ToString + "9"
            TextBoxBin.Text = TextBoxBin.Text.ToString + " 1001"
            V = V + 1
        End If
    End Sub
    Private Sub kA_Click(sender As Object, e As EventArgs) Handles kA.Click
        If V = 64 = False Then
            If TextboxHex.Text = "0x 0" And Val(TextBoxBin.Text) = 0 Then
                TextboxHex.Text = "0x "
                TextBoxBin.Text = Nothing
                V = 0
            End If
            TextboxHex.Text = TextboxHex.Text.ToString + "A"
            TextBoxBin.Text = TextBoxBin.Text.ToString + " 1010"
            V = V + 1
        End If
    End Sub
    Private Sub kB_Click(sender As Object, e As EventArgs) Handles kB.Click
        If V = 64 = False Then
            If TextboxHex.Text = "0x 0" And Val(TextBoxBin.Text) = 0 Then
                TextboxHex.Text = "0x "
                TextBoxBin.Text = Nothing
                V = 0
            End If
            TextboxHex.Text = TextboxHex.Text.ToString + "B"
            TextBoxBin.Text = TextBoxBin.Text.ToString + " 1011"
            V = V + 1
        End If
    End Sub
    Private Sub kC_Click(sender As Object, e As EventArgs) Handles kC.Click
        If V = 64 = False Then
            If TextboxHex.Text = "0x 0" And Val(TextBoxBin.Text) = 0 Then
                TextboxHex.Text = "0x "
                TextBoxBin.Text = Nothing
                V = 0
            End If
            TextboxHex.Text = TextboxHex.Text.ToString + "C"
            TextBoxBin.Text = TextBoxBin.Text.ToString + " 1100"
            V = V + 1
        End If
    End Sub
    Private Sub kD_Click(sender As Object, e As EventArgs) Handles kD.Click
        If V = 64 = False Then
            If TextboxHex.Text = "0x 0" And Val(TextBoxBin.Text) = 0 Then
                TextboxHex.Text = "0x "
                TextBoxBin.Text = Nothing
                V = 0
            End If
            TextboxHex.Text = TextboxHex.Text.ToString + "D"
            TextBoxBin.Text = TextBoxBin.Text.ToString + " 1101"
            V = V + 1
        End If
    End Sub
    Private Sub kE_Click(sender As Object, e As EventArgs) Handles kE.Click
        If V = 64 = False Then
            If TextboxHex.Text = "0x 0" And Val(TextBoxBin.Text) = 0 Then
                TextboxHex.Text = "0x "
                TextBoxBin.Text = Nothing
                V = 0
            End If
            TextboxHex.Text = TextboxHex.Text.ToString + "E"
            TextBoxBin.Text = TextBoxBin.Text.ToString + " 1110"
            V = V + 1
        End If
    End Sub
    Private Sub kF_Click(sender As Object, e As EventArgs) Handles kF.Click
        If V = 64 = False Then
            If TextboxHex.Text = "0x 0" And Val(TextBoxBin.Text) = 0 Then
                TextboxHex.Text = "0x "
                TextBoxBin.Text = Nothing
                V = 0
            End If
            TextboxHex.Text = TextboxHex.Text.ToString + "F"
            TextBoxBin.Text = TextBoxBin.Text.ToString + " 1111"
            V = V + 1
        End If
    End Sub
    Private Sub Button_Reset_Click(sender As Object, e As EventArgs) Handles Button_Reset.Click
        TextboxHex.Text = "0x 0"
        TextBoxBin.Text = "0"
    End Sub
    Dim V2 As Integer = 1
    Private Sub k02_Click(sender As Object, e As EventArgs) Handles k02.Click
        If V2 = 64 = False Then
            If Val(TextBoxBin2.Text) = 0 And TextBoxHex2.Text = "0x 0" Then
                TextBoxHex2.Text = "0x "
                TextBoxBin2.Text = Nothing
                V2 = 0
            End If
            TextBoxHex2.Text = TextBoxHex2.Text.ToString + "0"
            TextBoxBin2.Text = TextBoxBin2.Text.ToString + " 0000"
            V2 = V2 + 1
        End If
    End Sub
    Private Sub k12_Click(sender As Object, e As EventArgs) Handles k12.Click
        If V2 = 64 = False Then
            If Val(TextBoxBin2.Text) = 0 And TextBoxHex2.Text = "0x 0" Then
                TextBoxHex2.Text = "0x "
                TextBoxBin2.Text = Nothing
                V2 = 0
            End If
            TextBoxHex2.Text = TextBoxHex2.Text.ToString + "1"
            TextBoxBin2.Text = TextBoxBin2.Text.ToString + " 0001"
            V2 = V2 + 1
        End If
    End Sub
    Private Sub k22_Click(sender As Object, e As EventArgs) Handles k22.Click
        If V2 = 64 = False Then
            If Val(TextBoxBin2.Text) = 0 And TextBoxHex2.Text = "0x 0" Then
                TextBoxHex2.Text = "0x "
                TextBoxBin2.Text = Nothing
                V2 = 0
            End If
            TextBoxHex2.Text = TextBoxHex2.Text.ToString + "2"
            TextBoxBin2.Text = TextBoxBin2.Text.ToString + " 0010"
            V2 = V2 + 1
        End If
    End Sub
    Private Sub k32_Click(sender As Object, e As EventArgs) Handles k32.Click
        If V2 = 64 = False Then
            If Val(TextBoxBin2.Text) = 0 And TextBoxHex2.Text = "0x 0" Then
                TextBoxHex2.Text = "0x "
                TextBoxBin2.Text = Nothing
                V2 = 0
            End If
            TextBoxHex2.Text = TextBoxHex2.Text.ToString + "3"
            TextBoxBin2.Text = TextBoxBin2.Text.ToString + " 0011"
            V2 = V2 + 1
        End If
    End Sub
    Private Sub k42_Click(sender As Object, e As EventArgs) Handles k42.Click
        If V2 = 64 = False Then
            If Val(TextBoxBin2.Text) = 0 And TextBoxHex2.Text = "0x 0" Then
                TextBoxHex2.Text = "0x "
                TextBoxBin2.Text = Nothing
                V2 = 0
            End If
            TextBoxHex2.Text = TextBoxHex2.Text.ToString + "4"
            TextBoxBin2.Text = TextBoxBin2.Text.ToString + " 0100"
            V2 = V2 + 1
        End If
    End Sub
    Private Sub k52_Click(sender As Object, e As EventArgs) Handles k52.Click
        If V2 = 64 = False Then
            If Val(TextBoxBin2.Text) = 0 And TextBoxHex2.Text = "0x 0" Then
                TextBoxHex2.Text = "0x "
                TextBoxBin2.Text = Nothing
                V2 = 0
            End If
            TextBoxHex2.Text = TextBoxHex2.Text.ToString + "5"
            TextBoxBin2.Text = TextBoxBin2.Text.ToString + " 0101"
            V2 = V2 + 1
        End If
    End Sub
    Private Sub k62_Click(sender As Object, e As EventArgs) Handles k62.Click
        If V2 = 64 = False Then
            If Val(TextBoxBin2.Text) = 0 And TextBoxHex2.Text = "0x 0" Then
                TextBoxHex2.Text = "0x "
                TextBoxBin2.Text = Nothing
                V2 = 0
            End If
            TextBoxHex2.Text = TextBoxHex2.Text.ToString + "6"
            TextBoxBin2.Text = TextBoxBin2.Text.ToString + " 0110"
            V2 = V2 + 1
        End If
    End Sub
    Private Sub k72_Click(sender As Object, e As EventArgs) Handles k72.Click
        If V2 = 64 = False Then
            If Val(TextBoxBin2.Text) = 0 And TextBoxHex2.Text = "0x 0" Then
                TextBoxHex2.Text = "0x "
                TextBoxBin2.Text = Nothing
                V2 = 0
            End If
            TextBoxHex2.Text = TextBoxHex2.Text.ToString + "7"
            TextBoxBin2.Text = TextBoxBin2.Text.ToString + " 0111"
            V2 = V2 + 1
        End If
    End Sub
    Private Sub k82_Click(sender As Object, e As EventArgs) Handles k82.Click
        If V2 = 64 = False Then
            If Val(TextBoxBin2.Text) = 0 And TextBoxHex2.Text = "0x 0" Then
                TextBoxHex2.Text = "0x "
                TextBoxBin2.Text = Nothing
                V2 = 0
            End If
            TextBoxHex2.Text = TextBoxHex2.Text.ToString + "8"
            TextBoxBin2.Text = TextBoxBin2.Text.ToString + " 1000"
            V2 = V2 + 1
        End If
    End Sub
    Private Sub k92_Click(sender As Object, e As EventArgs) Handles k92.Click
        If V2 = 64 = False Then
            If Val(TextBoxBin2.Text) = 0 And TextBoxHex2.Text = "0x 0" Then
                TextBoxHex2.Text = "0x "
                TextBoxBin2.Text = Nothing
                V2 = 0
            End If
            TextBoxHex2.Text = TextBoxHex2.Text.ToString + "9"
            TextBoxBin2.Text = TextBoxBin2.Text.ToString + " 1001"
            V2 = V2 + 1
        End If
    End Sub
    Private Sub kA2_Click(sender As Object, e As EventArgs) Handles kA2.Click
        If V2 = 64 = False Then
            If Val(TextBoxBin2.Text) = 0 And TextBoxHex2.Text = "0x 0" Then
                TextBoxHex2.Text = "0x "
                TextBoxBin2.Text = Nothing
                V2 = 0
            End If
            TextBoxHex2.Text = TextBoxHex2.Text.ToString + "A"
            TextBoxBin2.Text = TextBoxBin2.Text.ToString + " 1010"
            V2 = V2 + 1
        End If
    End Sub
    Private Sub kB2_Click(sender As Object, e As EventArgs) Handles kB2.Click
        If V2 = 64 = False Then
            If Val(TextBoxBin2.Text) = 0 And TextBoxHex2.Text = "0x 0" Then
                TextBoxHex2.Text = "0x "
                TextBoxBin2.Text = Nothing
                V2 = 0
            End If
            TextBoxHex2.Text = TextBoxHex2.Text.ToString + "B"
            TextBoxBin2.Text = TextBoxBin2.Text.ToString + " 1011"
            V2 = V2 + 1
        End If
    End Sub
    Private Sub kC2_Click(sender As Object, e As EventArgs) Handles kC2.Click
        If V2 = 64 = False Then
            If Val(TextBoxBin2.Text) = 0 And TextBoxHex2.Text = "0x 0" Then
                TextBoxHex2.Text = "0x "
                TextBoxBin2.Text = Nothing
                V2 = 0
            End If
            TextBoxHex2.Text = TextBoxHex2.Text.ToString + "C"
            TextBoxBin2.Text = TextBoxBin2.Text.ToString + " 1100"
            V2 = V2 + 1
        End If
    End Sub
    Private Sub kD2_Click(sender As Object, e As EventArgs) Handles kD2.Click
        If V2 = 64 = False Then
            If Val(TextBoxBin2.Text) = 0 And TextBoxHex2.Text = "0x 0" Then
                TextBoxHex2.Text = "0x "
                TextBoxBin2.Text = Nothing
                V2 = 0
            End If
            TextBoxHex2.Text = TextBoxHex2.Text.ToString + "D"
            TextBoxBin2.Text = TextBoxBin2.Text.ToString + " 1101"
            V2 = V2 + 1
        End If
    End Sub
    Private Sub kE2_Click(sender As Object, e As EventArgs) Handles kE2.Click
        If V2 = 64 = False Then
            If Val(TextBoxBin2.Text) = 0 And TextBoxHex2.Text = "0x 0" Then
                TextBoxHex2.Text = "0x "
                TextBoxBin2.Text = Nothing
                V2 = 0
            End If
            TextBoxHex2.Text = TextBoxHex2.Text.ToString + "E"
            TextBoxBin2.Text = TextBoxBin2.Text.ToString + " 1110"
            V2 = V2 + 1
        End If
    End Sub
    Private Sub kF2_Click(sender As Object, e As EventArgs) Handles kF2.Click
        If V2 = 64 = False Then
            If Val(TextBoxBin2.Text) = 0 And TextBoxHex2.Text = "0x 0" Then
                TextBoxHex2.Text = "0x "
                TextBoxBin2.Text = Nothing
                V2 = 0
            End If
            TextBoxHex2.Text = TextBoxHex2.Text.ToString + "F"
            TextBoxBin2.Text = TextBoxBin2.Text.ToString + " 1111"
            V2 = V2 + 1
        End If
    End Sub
    Private Sub Button_Reset2_Click(sender As Object, e As EventArgs) Handles Button_Reset2.Click
        TextBoxHex2.Text = "0x 0"
        TextBoxBin2.Text = "0"
    End Sub
    Private Sub dReset_Click(sender As Object, e As EventArgs) Handles dReset.Click
        Me._A.Text = 0
        Me._B.Text = 0
        C1 = 1
    End Sub
    Dim C1 As Integer = 1
    Private Sub d0_Click(sender As Object, e As EventArgs) Handles d0.Click
        If C1 = 64 = False Then
            If Me._A.Text = "0" And Me._B.Text = "0" Then
                Me._A.Text = Nothing
                Me._B.Text = Nothing
                C1 = 0
            End If
            Me._A.Text = Me._A.Text + "0"
            Me._B.Text = Me._B.Text + " 000"
            C1 = C1 + 1
        End If
    End Sub
    Private Sub d1_Click(sender As Object, e As EventArgs) Handles d1.Click
        If C1 = 64 = False Then
            If Me._A.Text = "0" And Me._B.Text = "0" Then
                Me._A.Text = Nothing
                Me._B.Text = Nothing
                C1 = 0
            End If
            Me._A.Text = Me._A.Text + "1"
            Me._B.Text = Me._B.Text + " 001"
            C1 = C1 + 1
        End If
    End Sub
    Private Sub d2_Click(sender As Object, e As EventArgs) Handles d2.Click
        If C1 = 64 = False Then
            If Me._A.Text = "0" And Me._B.Text = "0" Then
                Me._A.Text = Nothing
                Me._B.Text = Nothing
                C1 = 0
            End If
            Me._A.Text = Me._A.Text + "2"
            Me._B.Text = Me._B.Text + " 010"
            C1 = C1 + 1
        End If
    End Sub
    Private Sub d3_Click(sender As Object, e As EventArgs) Handles d3.Click
        If C1 = 64 = False Then
            If Me._A.Text = "0" And Me._B.Text = "0" Then
                Me._A.Text = Nothing
                Me._B.Text = Nothing
                C1 = 0
            End If
            Me._A.Text = Me._A.Text + "3"
            Me._B.Text = Me._B.Text + " 011"
            C1 = C1 + 1
        End If
    End Sub
    Private Sub d4_Click(sender As Object, e As EventArgs) Handles d4.Click
        If C1 = 64 = False Then
            If Me._A.Text = "0" And Me._B.Text = "0" Then
                Me._A.Text = Nothing
                Me._B.Text = Nothing
                C1 = 0
            End If
            Me._A.Text = Me._A.Text + "4"
            Me._B.Text = Me._B.Text + " 100"
            C1 = C1 + 1
        End If
    End Sub
    Private Sub d5_Click(sender As Object, e As EventArgs) Handles d5.Click
        If C1 = 64 = False Then
            If Me._A.Text = "0" And Me._B.Text = "0" Then
                Me._A.Text = Nothing
                Me._B.Text = Nothing
                C1 = 0
            End If
            Me._A.Text = Me._A.Text + "5"
            Me._B.Text = Me._B.Text + " 101"
            C1 = C1 + 1
        End If
    End Sub
    Private Sub d6_Click(sender As Object, e As EventArgs) Handles d6.Click
        If C1 = 64 = False Then
            If Me._A.Text = "0" And Me._B.Text = "0" Then
                Me._A.Text = Nothing
                Me._B.Text = Nothing
                C1 = 0
            End If
            Me._A.Text = Me._A.Text + "6"
            Me._B.Text = Me._B.Text + " 110"
            C1 = C1 + 1
        End If
    End Sub
    Private Sub d7_Click(sender As Object, e As EventArgs) Handles d7.Click
        If C1 = 64 = False Then
            If Me._A.Text = "0" And Me._B.Text = "0" Then
                Me._A.Text = Nothing
                Me._B.Text = Nothing
                C1 = 0
            End If
            Me._A.Text = Me._A.Text + "7"
            Me._B.Text = Me._B.Text + " 111"
            C1 = C1 + 1
        End If
    End Sub
    Private Sub eReset_Click(sender As Object, e As EventArgs) Handles eReset.Click
        Me._D.Text = 0
        Me._C.Text = 0
        C2 = 1
    End Sub
    Dim C2 As Integer = 1
    Private Sub e0_Click(sender As Object, e As EventArgs) Handles e0.Click
        If C2 = 64 = False Then
            If Me._D.Text = "0" And Me._C.Text = "0" Then
                Me._D.Text = Nothing
                Me._C.Text = Nothing
                C2 = 0
            End If
            Me._D.Text = Me._D.Text + "0"
            Me._C.Text = Me._C.Text + " 000"
            C2 = C2 + 1
        End If
    End Sub
    Private Sub e1_Click(sender As Object, e As EventArgs) Handles e1.Click
        If C2 = 64 = False Then
            If Me._D.Text = "0" And Me._C.Text = "0" Then
                Me._D.Text = Nothing
                Me._C.Text = Nothing
                C2 = 0
            End If
            Me._D.Text = Me._D.Text + "1"
            Me._C.Text = Me._C.Text + " 001"
            C2 = C2 + 1
        End If
    End Sub
    Private Sub e2_Click(sender As Object, e As EventArgs) Handles e2.Click
        If C2 = 64 = False Then
            If Me._D.Text = "0" And Me._C.Text = "0" Then
                Me._D.Text = Nothing
                Me._C.Text = Nothing
                C2 = 0
            End If
            Me._D.Text = Me._D.Text + "2"
            Me._C.Text = Me._C.Text + " 010"
            C2 = C2 + 1
        End If
    End Sub
    Private Sub e3_Click(sender As Object, e As EventArgs) Handles e3.Click
        If C2 = 64 = False Then
            If Me._D.Text = "0" And Me._C.Text = "0" Then
                Me._D.Text = Nothing
                Me._C.Text = Nothing
                C2 = 0
            End If
            Me._D.Text = Me._D.Text + "3"
            Me._C.Text = Me._C.Text + " 011"
            C2 = C2 + 1
        End If
    End Sub
    Private Sub e4_Click(sender As Object, e As EventArgs) Handles e4.Click
        If C2 = 64 = False Then
            If Me._D.Text = "0" And Me._C.Text = "0" Then
                Me._D.Text = Nothing
                Me._C.Text = Nothing
                C2 = 0
            End If
            Me._D.Text = Me._D.Text + "4"
            Me._C.Text = Me._C.Text + " 100"
            C2 = C2 + 1
        End If
    End Sub
    Private Sub e5_Click(sender As Object, e As EventArgs) Handles e5.Click
        If C2 = 64 = False Then
            If Me._D.Text = "0" And Me._C.Text = "0" Then
                Me._D.Text = Nothing
                Me._C.Text = Nothing
                C2 = 0
            End If
            Me._D.Text = Me._D.Text + "5"
            Me._C.Text = Me._C.Text + " 101"
            C2 = C2 + 1
        End If
    End Sub
    Private Sub e6_Click(sender As Object, e As EventArgs) Handles e6.Click
        If C2 = 64 = False Then
            If Me._D.Text = "0" And Me._C.Text = "0" Then
                Me._D.Text = Nothing
                Me._C.Text = Nothing
                C2 = 0
            End If
            Me._D.Text = Me._D.Text + "6"
            Me._C.Text = Me._C.Text + " 110"
            C2 = C2 + 1
        End If
    End Sub
    Private Sub e7_Click(sender As Object, e As EventArgs) Handles e7.Click
        If C2 = 64 = False Then
            If Me._D.Text = "0" And Me._C.Text = "0" Then
                Me._D.Text = Nothing
                Me._C.Text = Nothing
                C2 = 0
            End If
            Me._D.Text = Me._D.Text + "7"
            Me._C.Text = Me._C.Text + " 111"
            C2 = C2 + 1
        End If
    End Sub
    Private Sub MyTabControl_Click(sender As Object, e As EventArgs) Handles MyTabControl.Click
        MainForm_Resize(sender, e)
    End Sub
    Private Sub xA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles xA.SelectedIndexChanged
        If xA.SelectedIndex = 0 Then
            A16.Items.Clear()
            A16.Items.Add("0")
            A16.Items.Add("1")
            A15.Items.Clear()
            A15.Items.Add("0")
            A15.Items.Add("1")
            A14.Items.Clear()
            A14.Items.Add("0")
            A14.Items.Add("1")
            A13.Items.Clear()
            A13.Items.Add("0")
            A13.Items.Add("1")
            A12.Items.Clear()
            A12.Items.Add("0")
            A12.Items.Add("1")
            A11.Items.Clear()
            A11.Items.Add("0")
            A11.Items.Add("1")
            A10.Items.Clear()
            A10.Items.Add("0")
            A10.Items.Add("1")
            A9.Items.Clear()
            A9.Items.Add("0")
            A9.Items.Add("1")
            A8.Items.Clear()
            A8.Items.Add("0")
            A8.Items.Add("1")
            A7.Items.Clear()
            A7.Items.Add("0")
            A7.Items.Add("1")
            A6.Items.Clear()
            A6.Items.Add("0")
            A6.Items.Add("1")
            A5.Items.Clear()
            A5.Items.Add("0")
            A5.Items.Add("1")
            A4.Items.Clear()
            A4.Items.Add("0")
            A4.Items.Add("1")
            A3.Items.Clear()
            A3.Items.Add("0")
            A3.Items.Add("1")
            A2.Items.Clear()
            A2.Items.Add("0")
            A2.Items.Add("1")
            A1.Items.Clear()
            A1.Items.Add("0")
            A1.Items.Add("1")
        ElseIf xA.SelectedIndex = 1 Then
            A16.Items.Clear()
            A16.Items.Add("0")
            A16.Items.Add("1")
            A16.Items.Add("2")
            A16.Items.Add("3")
            A15.Items.Clear()
            A15.Items.Add("0")
            A15.Items.Add("1")
            A15.Items.Add("2")
            A15.Items.Add("3")
            A14.Items.Clear()
            A14.Items.Add("0")
            A14.Items.Add("1")
            A14.Items.Add("2")
            A14.Items.Add("3")
            A13.Items.Clear()
            A13.Items.Add("0")
            A13.Items.Add("1")
            A13.Items.Add("2")
            A13.Items.Add("3")
            A12.Items.Clear()
            A12.Items.Add("0")
            A12.Items.Add("1")
            A12.Items.Add("2")
            A12.Items.Add("3")
            A11.Items.Clear()
            A11.Items.Add("0")
            A11.Items.Add("1")
            A11.Items.Add("2")
            A11.Items.Add("3")
            A10.Items.Clear()
            A10.Items.Add("0")
            A10.Items.Add("1")
            A10.Items.Add("2")
            A10.Items.Add("3")
            A9.Items.Clear()
            A9.Items.Add("0")
            A9.Items.Add("1")
            A9.Items.Add("2")
            A9.Items.Add("3")
            A8.Items.Clear()
            A8.Items.Add("0")
            A8.Items.Add("1")
            A8.Items.Add("2")
            A8.Items.Add("3")
            A7.Items.Clear()
            A7.Items.Add("0")
            A7.Items.Add("1")
            A7.Items.Add("2")
            A7.Items.Add("3")
            A6.Items.Clear()
            A6.Items.Add("0")
            A6.Items.Add("1")
            A6.Items.Add("2")
            A6.Items.Add("3")
            A5.Items.Clear()
            A5.Items.Add("0")
            A5.Items.Add("1")
            A5.Items.Add("2")
            A5.Items.Add("3")
            A4.Items.Clear()
            A4.Items.Add("0")
            A4.Items.Add("1")
            A4.Items.Add("2")
            A4.Items.Add("3")
            A3.Items.Clear()
            A3.Items.Add("0")
            A3.Items.Add("1")
            A3.Items.Add("2")
            A3.Items.Add("3")
            A2.Items.Clear()
            A2.Items.Add("0")
            A2.Items.Add("1")
            A2.Items.Add("2")
            A2.Items.Add("3")
            A1.Items.Clear()
            A1.Items.Add("0")
            A1.Items.Add("1")
            A1.Items.Add("2")
            A1.Items.Add("3")
        ElseIf xA.SelectedIndex = 2 Then
            A16.Items.Clear()
            A16.Items.Add("0")
            A16.Items.Add("1")
            A16.Items.Add("2")
            A16.Items.Add("3")
            A16.Items.Add("4")
            A16.Items.Add("5")
            A16.Items.Add("6")
            A16.Items.Add("7")
            A15.Items.Clear()
            A15.Items.Add("0")
            A15.Items.Add("1")
            A15.Items.Add("2")
            A15.Items.Add("3")
            A15.Items.Add("4")
            A15.Items.Add("5")
            A15.Items.Add("6")
            A15.Items.Add("7")
            A14.Items.Clear()
            A14.Items.Add("0")
            A14.Items.Add("1")
            A14.Items.Add("2")
            A14.Items.Add("3")
            A14.Items.Add("4")
            A14.Items.Add("5")
            A14.Items.Add("6")
            A14.Items.Add("7")
            A13.Items.Clear()
            A13.Items.Add("0")
            A13.Items.Add("1")
            A13.Items.Add("2")
            A13.Items.Add("3")
            A13.Items.Add("4")
            A13.Items.Add("5")
            A13.Items.Add("6")
            A13.Items.Add("7")
            A12.Items.Clear()
            A12.Items.Add("0")
            A12.Items.Add("1")
            A12.Items.Add("2")
            A12.Items.Add("3")
            A12.Items.Add("4")
            A12.Items.Add("5")
            A12.Items.Add("6")
            A12.Items.Add("7")
            A11.Items.Clear()
            A11.Items.Add("0")
            A11.Items.Add("1")
            A11.Items.Add("2")
            A11.Items.Add("3")
            A11.Items.Add("4")
            A11.Items.Add("5")
            A11.Items.Add("6")
            A11.Items.Add("7")
            A10.Items.Clear()
            A10.Items.Add("0")
            A10.Items.Add("1")
            A10.Items.Add("2")
            A10.Items.Add("3")
            A10.Items.Add("4")
            A10.Items.Add("5")
            A10.Items.Add("6")
            A10.Items.Add("7")
            A9.Items.Clear()
            A9.Items.Add("0")
            A9.Items.Add("1")
            A9.Items.Add("2")
            A9.Items.Add("3")
            A9.Items.Add("4")
            A9.Items.Add("5")
            A9.Items.Add("6")
            A9.Items.Add("7")
            A8.Items.Clear()
            A8.Items.Add("0")
            A8.Items.Add("1")
            A8.Items.Add("2")
            A8.Items.Add("3")
            A8.Items.Add("4")
            A8.Items.Add("5")
            A8.Items.Add("6")
            A8.Items.Add("7")
            A7.Items.Clear()
            A7.Items.Add("0")
            A7.Items.Add("1")
            A7.Items.Add("2")
            A7.Items.Add("3")
            A7.Items.Add("4")
            A7.Items.Add("5")
            A7.Items.Add("6")
            A7.Items.Add("7")
            A6.Items.Clear()
            A6.Items.Add("0")
            A6.Items.Add("1")
            A6.Items.Add("2")
            A6.Items.Add("3")
            A6.Items.Add("4")
            A6.Items.Add("5")
            A6.Items.Add("6")
            A6.Items.Add("7")
            A5.Items.Clear()
            A5.Items.Add("0")
            A5.Items.Add("1")
            A5.Items.Add("2")
            A5.Items.Add("3")
            A5.Items.Add("4")
            A5.Items.Add("5")
            A5.Items.Add("6")
            A5.Items.Add("7")
            A4.Items.Clear()
            A4.Items.Add("0")
            A4.Items.Add("1")
            A4.Items.Add("2")
            A4.Items.Add("3")
            A4.Items.Add("4")
            A4.Items.Add("5")
            A4.Items.Add("6")
            A4.Items.Add("7")
            A3.Items.Clear()
            A3.Items.Add("0")
            A3.Items.Add("1")
            A3.Items.Add("2")
            A3.Items.Add("3")
            A3.Items.Add("4")
            A3.Items.Add("5")
            A3.Items.Add("6")
            A3.Items.Add("7")
            A2.Items.Clear()
            A2.Items.Add("0")
            A2.Items.Add("1")
            A2.Items.Add("2")
            A2.Items.Add("3")
            A2.Items.Add("4")
            A2.Items.Add("5")
            A2.Items.Add("6")
            A2.Items.Add("7")
            A1.Items.Clear()
            A1.Items.Add("0")
            A1.Items.Add("1")
            A1.Items.Add("2")
            A1.Items.Add("3")
            A1.Items.Add("4")
            A1.Items.Add("5")
            A1.Items.Add("6")
            A1.Items.Add("7")
        ElseIf xA.SelectedIndex = 3 Then
            A16.Items.Clear()
            A16.Items.Add("0")
            A16.Items.Add("1")
            A16.Items.Add("2")
            A16.Items.Add("3")
            A16.Items.Add("4")
            A16.Items.Add("5")
            A16.Items.Add("6")
            A16.Items.Add("7")
            A16.Items.Add("8")
            A16.Items.Add("9")
            A16.Items.Add("A")
            A16.Items.Add("B")
            A16.Items.Add("C")
            A16.Items.Add("D")
            A16.Items.Add("E")
            A16.Items.Add("F")
            A15.Items.Clear()
            A15.Items.Add("0")
            A15.Items.Add("1")
            A15.Items.Add("2")
            A15.Items.Add("3")
            A15.Items.Add("4")
            A15.Items.Add("5")
            A15.Items.Add("6")
            A15.Items.Add("7")
            A15.Items.Add("8")
            A15.Items.Add("9")
            A15.Items.Add("A")
            A15.Items.Add("B")
            A15.Items.Add("C")
            A15.Items.Add("D")
            A15.Items.Add("E")
            A15.Items.Add("F")
            A14.Items.Clear()
            A14.Items.Add("0")
            A14.Items.Add("1")
            A14.Items.Add("2")
            A14.Items.Add("3")
            A14.Items.Add("4")
            A14.Items.Add("5")
            A14.Items.Add("6")
            A14.Items.Add("7")
            A14.Items.Add("8")
            A14.Items.Add("9")
            A14.Items.Add("A")
            A14.Items.Add("B")
            A14.Items.Add("C")
            A14.Items.Add("D")
            A14.Items.Add("E")
            A14.Items.Add("F")
            A13.Items.Clear()
            A13.Items.Add("0")
            A13.Items.Add("1")
            A13.Items.Add("2")
            A13.Items.Add("3")
            A13.Items.Add("4")
            A13.Items.Add("5")
            A13.Items.Add("6")
            A13.Items.Add("7")
            A13.Items.Add("8")
            A13.Items.Add("9")
            A13.Items.Add("A")
            A13.Items.Add("B")
            A13.Items.Add("C")
            A13.Items.Add("D")
            A13.Items.Add("E")
            A13.Items.Add("F")
            A12.Items.Clear()
            A12.Items.Add("0")
            A12.Items.Add("1")
            A12.Items.Add("2")
            A12.Items.Add("3")
            A12.Items.Add("4")
            A12.Items.Add("5")
            A12.Items.Add("6")
            A12.Items.Add("7")
            A12.Items.Add("8")
            A12.Items.Add("9")
            A12.Items.Add("A")
            A12.Items.Add("B")
            A12.Items.Add("C")
            A12.Items.Add("D")
            A12.Items.Add("E")
            A12.Items.Add("F")
            A11.Items.Clear()
            A11.Items.Add("0")
            A11.Items.Add("1")
            A11.Items.Add("2")
            A11.Items.Add("3")
            A11.Items.Add("4")
            A11.Items.Add("5")
            A11.Items.Add("6")
            A11.Items.Add("7")
            A11.Items.Add("8")
            A11.Items.Add("9")
            A11.Items.Add("A")
            A11.Items.Add("B")
            A11.Items.Add("C")
            A11.Items.Add("D")
            A11.Items.Add("E")
            A11.Items.Add("F")
            A10.Items.Clear()
            A10.Items.Add("0")
            A10.Items.Add("1")
            A10.Items.Add("2")
            A10.Items.Add("3")
            A10.Items.Add("4")
            A10.Items.Add("5")
            A10.Items.Add("6")
            A10.Items.Add("7")
            A10.Items.Add("8")
            A10.Items.Add("9")
            A10.Items.Add("A")
            A10.Items.Add("B")
            A10.Items.Add("C")
            A10.Items.Add("D")
            A10.Items.Add("E")
            A10.Items.Add("F")
            A9.Items.Clear()
            A9.Items.Add("0")
            A9.Items.Add("1")
            A9.Items.Add("2")
            A9.Items.Add("3")
            A9.Items.Add("4")
            A9.Items.Add("5")
            A9.Items.Add("6")
            A9.Items.Add("7")
            A9.Items.Add("8")
            A9.Items.Add("9")
            A9.Items.Add("A")
            A9.Items.Add("B")
            A9.Items.Add("C")
            A9.Items.Add("D")
            A9.Items.Add("E")
            A9.Items.Add("F")
            A8.Items.Clear()
            A8.Items.Add("0")
            A8.Items.Add("1")
            A8.Items.Add("2")
            A8.Items.Add("3")
            A8.Items.Add("4")
            A8.Items.Add("5")
            A8.Items.Add("6")
            A8.Items.Add("7")
            A8.Items.Add("8")
            A8.Items.Add("9")
            A8.Items.Add("A")
            A8.Items.Add("B")
            A8.Items.Add("C")
            A8.Items.Add("D")
            A8.Items.Add("E")
            A8.Items.Add("F")
            A7.Items.Clear()
            A7.Items.Add("0")
            A7.Items.Add("1")
            A7.Items.Add("2")
            A7.Items.Add("3")
            A7.Items.Add("4")
            A7.Items.Add("5")
            A7.Items.Add("6")
            A7.Items.Add("7")
            A7.Items.Add("8")
            A7.Items.Add("9")
            A7.Items.Add("A")
            A7.Items.Add("B")
            A7.Items.Add("C")
            A7.Items.Add("D")
            A7.Items.Add("E")
            A7.Items.Add("F")
            A6.Items.Clear()
            A6.Items.Add("0")
            A6.Items.Add("1")
            A6.Items.Add("2")
            A6.Items.Add("3")
            A6.Items.Add("4")
            A6.Items.Add("5")
            A6.Items.Add("6")
            A6.Items.Add("7")
            A6.Items.Add("8")
            A6.Items.Add("9")
            A6.Items.Add("A")
            A6.Items.Add("B")
            A6.Items.Add("C")
            A6.Items.Add("D")
            A6.Items.Add("E")
            A6.Items.Add("F")
            A5.Items.Clear()
            A5.Items.Add("0")
            A5.Items.Add("1")
            A5.Items.Add("2")
            A5.Items.Add("3")
            A5.Items.Add("4")
            A5.Items.Add("5")
            A5.Items.Add("6")
            A5.Items.Add("7")
            A5.Items.Add("8")
            A5.Items.Add("9")
            A5.Items.Add("A")
            A5.Items.Add("B")
            A5.Items.Add("C")
            A5.Items.Add("D")
            A5.Items.Add("E")
            A5.Items.Add("F")
            A4.Items.Clear()
            A4.Items.Add("0")
            A4.Items.Add("1")
            A4.Items.Add("2")
            A4.Items.Add("3")
            A4.Items.Add("4")
            A4.Items.Add("5")
            A4.Items.Add("6")
            A4.Items.Add("7")
            A4.Items.Add("8")
            A4.Items.Add("9")
            A4.Items.Add("A")
            A4.Items.Add("B")
            A4.Items.Add("C")
            A4.Items.Add("D")
            A4.Items.Add("E")
            A4.Items.Add("F")
            A3.Items.Clear()
            A3.Items.Add("0")
            A3.Items.Add("1")
            A3.Items.Add("2")
            A3.Items.Add("3")
            A3.Items.Add("4")
            A3.Items.Add("5")
            A3.Items.Add("6")
            A3.Items.Add("7")
            A3.Items.Add("8")
            A3.Items.Add("9")
            A3.Items.Add("A")
            A3.Items.Add("B")
            A3.Items.Add("C")
            A3.Items.Add("D")
            A3.Items.Add("E")
            A3.Items.Add("F")
            A2.Items.Clear()
            A2.Items.Add("0")
            A2.Items.Add("1")
            A2.Items.Add("2")
            A2.Items.Add("3")
            A2.Items.Add("4")
            A2.Items.Add("5")
            A2.Items.Add("6")
            A2.Items.Add("7")
            A2.Items.Add("8")
            A2.Items.Add("9")
            A2.Items.Add("A")
            A2.Items.Add("B")
            A2.Items.Add("C")
            A2.Items.Add("D")
            A2.Items.Add("E")
            A2.Items.Add("F")
            A1.Items.Clear()
            A1.Items.Add("0")
            A1.Items.Add("1")
            A1.Items.Add("2")
            A1.Items.Add("3")
            A1.Items.Add("4")
            A1.Items.Add("5")
            A1.Items.Add("6")
            A1.Items.Add("7")
            A1.Items.Add("8")
            A1.Items.Add("9")
            A1.Items.Add("A")
            A1.Items.Add("B")
            A1.Items.Add("C")
            A1.Items.Add("D")
            A1.Items.Add("E")
            A1.Items.Add("F")
        End If
        A16.Enabled = True
        A16.SelectedIndex = 0
        A15.Enabled = True
        A15.SelectedIndex = 0
        A14.Enabled = True
        A14.SelectedIndex = 0
        A13.Enabled = True
        A13.SelectedIndex = 0
        A12.Enabled = True
        A12.SelectedIndex = 0
        A11.Enabled = True
        A11.SelectedIndex = 0
        A10.Enabled = True
        A10.SelectedIndex = 0
        A9.Enabled = True
        A9.SelectedIndex = 0
        A8.Enabled = True
        A8.SelectedIndex = 0
        A7.Enabled = True
        A7.SelectedIndex = 0
        A6.Enabled = True
        A6.SelectedIndex = 0
        A5.Enabled = True
        A5.SelectedIndex = 0
        A4.Enabled = True
        A4.SelectedIndex = 0
        A3.Enabled = True
        A3.SelectedIndex = 0
        A2.Enabled = True
        A2.SelectedIndex = 0
        A1.Enabled = True
        A1.SelectedIndex = 0
        ButtonEXE.Enabled = True
    End Sub
    Private Sub CNow()
        Dim Y As Integer
        If xA.SelectedIndex = 0 Then
            Y = 2
        ElseIf xA.SelectedIndex = 1 Then
            Y = 4
        ElseIf xA.SelectedIndex = 2 Then
            Y = 8
        ElseIf xA.SelectedIndex = 3 Then
            Y = 16
        End If
        Dim x16 = A16.Text
        Dim x15 = A15.Text
        Dim x14 = A14.Text
        Dim x13 = A13.Text
        Dim x12 = A12.Text
        Dim x11 = A11.Text
        Dim x10 = A10.Text
        Dim x9 = A9.Text
        Dim x8 = A8.Text
        Dim x7 = A7.Text
        Dim x6 = A6.Text
        Dim x5 = A5.Text
        Dim x4 = A4.Text
        Dim x3 = A3.Text
        Dim x2 = A2.Text
        Dim x1 = A1.Text
        If x16 = "A" Then
            x16 = 10
        ElseIf x16 = "B" Then
            x16 = 11
        ElseIf x16 = "C" Then
            x16 = 12
        ElseIf x16 = "D" Then
            x16 = 13
        ElseIf x16 = "E" Then
            x16 = 14
        ElseIf x16 = "F" Then
            x16 = 15
        End If
        If x15 = "A" Then
            x15 = 10
        ElseIf x15 = "B" Then
            x15 = 11
        ElseIf x15 = "C" Then
            x15 = 12
        ElseIf x15 = "D" Then
            x15 = 13
        ElseIf x15 = "E" Then
            x15 = 14
        ElseIf x15 = "F" Then
            x15 = 15
        End If
        If x14 = "A" Then
            x14 = 10
        ElseIf x14 = "B" Then
            x14 = 11
        ElseIf x14 = "C" Then
            x14 = 12
        ElseIf x14 = "D" Then
            x14 = 13
        ElseIf x14 = "E" Then
            x14 = 14
        ElseIf x14 = "F" Then
            x14 = 15
        End If
        If x13 = "A" Then
            x13 = 10
        ElseIf x13 = "B" Then
            x13 = 11
        ElseIf x13 = "C" Then
            x13 = 12
        ElseIf x13 = "D" Then
            x13 = 13
        ElseIf x13 = "E" Then
            x13 = 14
        ElseIf x13 = "F" Then
            x13 = 15
        End If
        If x12 = "A" Then
            x12 = 10
        ElseIf x12 = "B" Then
            x12 = 11
        ElseIf x12 = "C" Then
            x12 = 12
        ElseIf x12 = "D" Then
            x12 = 13
        ElseIf x12 = "E" Then
            x12 = 14
        ElseIf x12 = "F" Then
            x12 = 15
        End If
        If x11 = "A" Then
            x11 = 10
        ElseIf x11 = "B" Then
            x11 = 11
        ElseIf x11 = "C" Then
            x11 = 12
        ElseIf x11 = "D" Then
            x11 = 13
        ElseIf x11 = "E" Then
            x11 = 14
        ElseIf x11 = "F" Then
            x11 = 15
        End If
        If x10 = "A" Then
            x10 = 10
        ElseIf x10 = "B" Then
            x10 = 11
        ElseIf x10 = "C" Then
            x10 = 12
        ElseIf x10 = "D" Then
            x10 = 13
        ElseIf x10 = "E" Then
            x10 = 14
        ElseIf x10 = "F" Then
            x10 = 15
        End If
        If x9 = "A" Then
            x9 = 10
        ElseIf x9 = "B" Then
            x9 = 11
        ElseIf x9 = "C" Then
            x9 = 12
        ElseIf x9 = "D" Then
            x9 = 13
        ElseIf x9 = "E" Then
            x9 = 14
        ElseIf x9 = "F" Then
            x9 = 15
        End If
        If x8 = "A" Then
            x8 = 10
        ElseIf x8 = "B" Then
            x8 = 11
        ElseIf x8 = "C" Then
            x8 = 12
        ElseIf x8 = "D" Then
            x8 = 13
        ElseIf x8 = "E" Then
            x8 = 14
        ElseIf x8 = "F" Then
            x8 = 15
        End If
        If x7 = "A" Then
            x7 = 10
        ElseIf x7 = "B" Then
            x7 = 11
        ElseIf x7 = "C" Then
            x7 = 12
        ElseIf x7 = "D" Then
            x7 = 13
        ElseIf x7 = "E" Then
            x7 = 14
        ElseIf x7 = "F" Then
            x7 = 15
        End If
        If x6 = "A" Then
            x6 = 10
        ElseIf x6 = "B" Then
            x6 = 11
        ElseIf x6 = "C" Then
            x6 = 12
        ElseIf x6 = "D" Then
            x6 = 13
        ElseIf x6 = "E" Then
            x6 = 14
        ElseIf x6 = "F" Then
            x6 = 15
        End If
        If x5 = "A" Then
            x5 = 10
        ElseIf x5 = "B" Then
            x5 = 11
        ElseIf x5 = "C" Then
            x5 = 12
        ElseIf x5 = "D" Then
            x5 = 13
        ElseIf x5 = "E" Then
            x5 = 14
        ElseIf x5 = "F" Then
            x5 = 15
        End If
        If x4 = "A" Then
            x4 = 10
        ElseIf x4 = "B" Then
            x4 = 11
        ElseIf x4 = "C" Then
            x4 = 12
        ElseIf x4 = "D" Then
            x4 = 13
        ElseIf x4 = "E" Then
            x4 = 14
        ElseIf x4 = "F" Then
            x4 = 15
        End If
        If x3 = "A" Then
            x3 = 10
        ElseIf x3 = "B" Then
            x3 = 11
        ElseIf x3 = "C" Then
            x3 = 12
        ElseIf x3 = "D" Then
            x3 = 13
        ElseIf x3 = "E" Then
            x3 = 14
        ElseIf x3 = "F" Then
            x3 = 15
        End If
        If x2 = "A" Then
            x2 = 10
        ElseIf x2 = "B" Then
            x2 = 11
        ElseIf x2 = "C" Then
            x2 = 12
        ElseIf x2 = "D" Then
            x2 = 13
        ElseIf x2 = "E" Then
            x2 = 14
        ElseIf x2 = "F" Then
            x2 = 15
        End If
        If x1 = "A" Then
            x1 = 10
        ElseIf x1 = "B" Then
            x1 = 11
        ElseIf x1 = "C" Then
            x1 = 12
        ElseIf x1 = "D" Then
            x1 = 13
        ElseIf x1 = "E" Then
            x1 = 14
        ElseIf x1 = "F" Then
            x1 = 15
        End If
        Dim Dec = x16 * (Y ^ 15) + x15 * (Y ^ 14) + x14 * (Y ^ 13) + x13 * (Y ^ 12) + x12 * (Y ^ 11) + x11 * (Y ^ 10) + x10 * (Y ^ 9) + x9 * (Y ^ 8) + x8 * (Y ^ 7) + x7 * (Y ^ 6) + x6 * (Y ^ 5) + x5 * (Y ^ 4) + x4 * (Y ^ 3) + x3 * (Y ^ 2) + x2 * (Y ^ 1) + x1 * (Y ^ 0)
        TextBoxR.Text = Dec.ToString
        CNowListBox.Items.Clear()
        Dim T16 As String = x16.ToString + " * ( " + Y.ToString + " ^ 15 )"
        Dim T15 As String = x15.ToString + " * ( " + Y.ToString + " ^ 14 )"
        Dim T14 As String = x14.ToString + " * ( " + Y.ToString + " ^ 13 )"
        Dim T13 As String = x13.ToString + " * ( " + Y.ToString + " ^ 12 )"
        Dim T12 As String = x12.ToString + " * ( " + Y.ToString + " ^ 11 )"
        Dim T11 As String = x11.ToString + " * ( " + Y.ToString + " ^ 10 )"
        Dim T10 As String = x10.ToString + " * ( " + Y.ToString + " ^ 9 )"
        Dim T9 As String = x9.ToString + " * ( " + Y.ToString + " ^ 8 )"
        Dim T8 As String = x8.ToString + " * ( " + Y.ToString + " ^ 7 )"
        Dim T7 As String = x7.ToString + " * ( " + Y.ToString + " ^ 6 )"
        Dim T6 As String = x6.ToString + " * ( " + Y.ToString + " ^ 5 )"
        Dim T5 As String = x5.ToString + " * ( " + Y.ToString + " ^ 4 )"
        Dim T4 As String = x4.ToString + " * ( " + Y.ToString + " ^ 3 )"
        Dim T3 As String = x3.ToString + " * ( " + Y.ToString + " ^ 2 )"
        Dim T2 As String = x2.ToString + " * ( " + Y.ToString + " ^ 1 )"
        Dim T1 As String = x1.ToString + " * ( " + Y.ToString + " ^ 0 )"
        Dim L0 As String = " = "
        Dim L1 As String = " + " + T16.ToString
        Dim L2 As String = " + " + T15.ToString
        Dim L3 As String = " + " + T14.ToString
        Dim L4 As String = " + " + T13.ToString
        Dim L5 As String = " + " + T12.ToString
        Dim L6 As String = " + " + T11.ToString
        Dim L7 As String = " + " + T10.ToString
        Dim L8 As String = " + " + T9.ToString
        Dim L9 As String = " + " + T8.ToString
        Dim L10 As String = " + " + T7.ToString
        Dim L11 As String = " + " + T6.ToString
        Dim L12 As String = " + " + T5.ToString
        Dim L13 As String = " + " + T4.ToString
        Dim L14 As String = " + " + T3.ToString
        Dim L15 As String = " + " + T2.ToString
        Dim L16 As String = " + " + T1.ToString
        CNowListBox.Items.Add(L0.ToString)
        CNowListBox.Items.Add(L1.ToString)
        CNowListBox.Items.Add(L2.ToString)
        CNowListBox.Items.Add(L3.ToString)
        CNowListBox.Items.Add(L4.ToString)
        CNowListBox.Items.Add(L5.ToString)
        CNowListBox.Items.Add(L6.ToString)
        CNowListBox.Items.Add(L7.ToString)
        CNowListBox.Items.Add(L8.ToString)
        CNowListBox.Items.Add(L9.ToString)
        CNowListBox.Items.Add(L10.ToString)
        CNowListBox.Items.Add(L11.ToString)
        CNowListBox.Items.Add(L12.ToString)
        CNowListBox.Items.Add(L13.ToString)
        CNowListBox.Items.Add(L14.ToString)
        CNowListBox.Items.Add(L15.ToString)
        CNowListBox.Items.Add(L16.ToString)
    End Sub
    Private Sub ButtonEXE_Click(sender As Object, e As EventArgs) Handles ButtonEXE.Click
        CNow()
    End Sub
    Private Sub o4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles o4.SelectedIndexChanged
        If o4.Text = Nothing = False And o3.Text = Nothing = False And o2.Text = Nothing = False And o1.Text = Nothing = False Then
            oEXE.Enabled = True
        End If
    End Sub
    Private Sub o3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles o3.SelectedIndexChanged
        If o4.Text = Nothing = False And o3.Text = Nothing = False And o2.Text = Nothing = False And o1.Text = Nothing = False Then
            oEXE.Enabled = True
        End If
    End Sub
    Private Sub o2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles o2.SelectedIndexChanged
        If o4.Text = Nothing = False And o3.Text = Nothing = False And o2.Text = Nothing = False And o1.Text = Nothing = False Then
            oEXE.Enabled = True
        End If
    End Sub
    Private Sub o1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles o1.SelectedIndexChanged
        If o4.Text = Nothing = False And o3.Text = Nothing = False And o2.Text = Nothing = False And o1.Text = Nothing = False Then
            oEXE.Enabled = True
        End If
    End Sub
    Dim OctToHexClicked As Integer = 1
    Private Sub oEXE_Click(sender As Object, e As EventArgs) Handles oEXE.Click
        If OctToHexClicked = 64 = False Then
            If Oct1.Text = "0" Then
                OctToHexClicked = 0
                Oct1.Text = Nothing
                Hex1.Text = Nothing
            End If
            OctToHex()
        End If
    End Sub
    Private Sub OctToHex()
        OctToHexClicked = OctToHexClicked + 1
        Dim T As String = o4.Text.ToString + o3.Text.ToString + o2.Text.ToString + o1.Text.ToString
        Oct1.Text = Oct1.Text.ToString + " " + (T.ToString).ToString
        Dim Dec = o4.Text * (8 ^ 3) + o3.Text * (8 ^ 2) + o2.Text * (8 ^ 1) + o1.Text * (8 ^ 0)
        Dim x2m As String = Dec Mod (16 ^ 2)
        Dim x2 As String = Dec \ (16 ^ 2)
        Dim x1m As String = x2m Mod (16 ^ 1)
        Dim x1 As String = x2m \ (16 ^ 1)
        Dim x0m As String = x1m Mod (16 ^ 0)
        Dim x0 As String = x1m \ (16 ^ 0)
        If x2 = 10 Then
            x2 = "A"
        ElseIf x2 = 11 Then
            x2 = "B"
        ElseIf x2 = 12 Then
            x2 = "C"
        ElseIf x2 = 13 Then
            x2 = "D"
        ElseIf x2 = 14 Then
            x2 = "E"
        ElseIf x2 = 15 Then
            x2 = "F"
        End If
        If x1 = 10 Then
            x1 = "A"
        ElseIf x1 = 11 Then
            x1 = "B"
        ElseIf x1 = 12 Then
            x1 = "C"
        ElseIf x1 = 13 Then
            x1 = "D"
        ElseIf x1 = 14 Then
            x1 = "E"
        ElseIf x1 = 15 Then
            x1 = "F"
        End If
        If x0 = 10 Then
            x0 = "A"
        ElseIf x0 = 11 Then
            x0 = "B"
        ElseIf x0 = 12 Then
            x0 = "C"
        ElseIf x0 = 13 Then
            x0 = "D"
        ElseIf x0 = 14 Then
            x0 = "E"
        ElseIf x0 = 15 Then
            x0 = "F"
        End If
        Dim Z As String = " " + x2.ToString + x1.ToString + x0.ToString
        Hex1.Text = Hex1.Text.ToString + Z.ToString
        oList.Items.Add(T.ToString + " = " + Z.ToString)
    End Sub
    Private Sub oReset_Click(sender As Object, e As EventArgs) Handles oReset.Click
        Oct1.Text = 0
        Hex1.Text = 0
        OctToHexClicked = 1
        oList.Items.Clear()
    End Sub
    Private Sub h3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles h3.SelectedIndexChanged
        If h3.Text = Nothing = False And h2.Text = Nothing = False And h1.Text = Nothing = False Then
            hEXE.Enabled = True
        End If
    End Sub
    Private Sub h2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles h2.SelectedIndexChanged
        If h3.Text = Nothing = False And h2.Text = Nothing = False And h1.Text = Nothing = False Then
            hEXE.Enabled = True
        End If
    End Sub
    Private Sub h1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles h1.SelectedIndexChanged
        If h3.Text = Nothing = False And h2.Text = Nothing = False And h1.Text = Nothing = False Then
            hEXE.Enabled = True
        End If
    End Sub
    Dim HexToOctClicked As Integer = 1
    Private Sub hEXE_Click(sender As Object, e As EventArgs) Handles hEXE.Click
        If HexToOctClicked = 64 = False Then
            If Hex2.Text = "0" Then
                HexToOctClicked = 0
                Oct2.Text = Nothing
                Hex2.Text = Nothing
            End If
            HexToOct()
        End If
    End Sub
    Private Sub HexToOct()
        HexToOctClicked = HexToOctClicked + 1
        Dim T As String = h3.Text.ToString + h2.Text.ToString + h1.Text.ToString
        Hex2.Text = Hex2.Text.ToString + " " + (T.ToString).ToString
        Dim t3 = h3.Text.ToString
        If t3 = "A" Then
            t3 = 10
        ElseIf t3 = "B" Then
            t3 = 11
        ElseIf t3 = "C" Then
            t3 = 12
        ElseIf t3 = "D" Then
            t3 = 13
        ElseIf t3 = "E" Then
            t3 = 14
        ElseIf t3 = "F" Then
            t3 = 15
        End If
        Dim t2 = h2.Text.ToString
        If t2 = "A" Then
            t2 = 10
        ElseIf t2 = "B" Then
            t2 = 11
        ElseIf t2 = "C" Then
            t2 = 12
        ElseIf t2 = "D" Then
            t2 = 13
        ElseIf t2 = "E" Then
            t2 = 14
        ElseIf t2 = "F" Then
            t2 = 15
        End If
        Dim t1 = h1.Text.ToString
        If t1 = "A" Then
            t1 = 10
        ElseIf t1 = "B" Then
            t1 = 11
        ElseIf t1 = "C" Then
            t1 = 12
        ElseIf t1 = "D" Then
            t1 = 13
        ElseIf t1 = "E" Then
            t1 = 14
        ElseIf t1 = "F" Then
            t1 = 15
        End If
        Dim Dec = t3 * (16 ^ 2) + t2 * (16 ^ 1) + t1 * (16 ^ 0)
        Dim x3m As String = Dec Mod (8 ^ 3)
        Dim x3 As String = Dec \ (8 ^ 3)
        Dim x2m As String = x3m Mod (8 ^ 2)
        Dim x2 As String = x3m \ (8 ^ 2)
        Dim x1m As String = x2m Mod (8 ^ 1)
        Dim x1 As String = x2m \ (8 ^ 1)
        Dim x0m As String = x1m Mod (8 ^ 0)
        Dim x0 As String = x1m \ (8 ^ 0)
        Dim Z As String = " " + x3.ToString + x2.ToString + x1.ToString + x0.ToString
        Oct2.Text = Oct2.Text.ToString + Z.ToString
        hList.Items.Add(T.ToString + " = " + Z.ToString)
    End Sub
    Private Sub hReset_Click(sender As Object, e As EventArgs) Handles hReset.Click
        Oct2.Text = 0
        Hex2.Text = 0
        HexToOctClicked = 1
        hList.Items.Clear()
    End Sub
    Dim bqclicked As Integer = 1
    Private Sub bqk1_Click(sender As Object, e As EventArgs) Handles bqk1.Click
        If bqclicked = 64 = False Then
            If bqq.Text = 0 Then
                bqb.Text = Nothing
                bqq.Text = Nothing
                bqclicked = 0
            End If
            bqb.Text = bqb.Text.ToString + " 00"
            bqq.Text = bqq.Text.ToString.ToString + "0"
            bqclicked = bqclicked + 1
        End If
    End Sub
    Private Sub bqk2_Click(sender As Object, e As EventArgs) Handles bqk2.Click
        If bqclicked = 64 = False Then
            If bqq.Text = 0 Then
                bqb.Text = Nothing
                bqq.Text = Nothing
                bqclicked = 0
            End If
            bqb.Text = bqb.Text.ToString + " 01"
            bqq.Text = bqq.Text.ToString + "1"
            bqclicked = bqclicked + 1
        End If
    End Sub
    Private Sub bqk3_Click(sender As Object, e As EventArgs) Handles bqk3.Click
        If bqclicked = 64 = False Then
            If bqq.Text = 0 Then
                bqb.Text = Nothing
                bqq.Text = Nothing
                bqclicked = 0
            End If
            bqb.Text = bqb.Text.ToString + " 10"
            bqq.Text = bqq.Text.ToString + "2"
            bqclicked = bqclicked + 1
        End If
    End Sub
    Private Sub bqk4_Click(sender As Object, e As EventArgs) Handles bqk4.Click
        If bqclicked = 64 = False Then
            If bqq.Text = 0 Then
                bqb.Text = Nothing
                bqq.Text = Nothing
                bqclicked = 0
            End If
            bqb.Text = bqb.Text.ToString + " 11"
            bqq.Text = bqq.Text.ToString + "3"
            bqclicked = bqclicked + 1
        End If
    End Sub
    Private Sub bqR_Click(sender As Object, e As EventArgs) Handles bqR.Click
        bqb.Text = 0
        bqq.Text = 0
        bqclicked = 1
    End Sub
    Dim qbclicked As Integer = 1
    Private Sub qbk1_Click(sender As Object, e As EventArgs) Handles qbk1.Click
        If qbclicked = 64 = False Then
            If qbq.Text = 0 Then
                qbq.Text = Nothing
                qbb.Text = Nothing
                qbclicked = 0
            End If
            qbq.Text = qbq.Text.ToString + "0"
            qbb.Text = qbb.Text.ToString + " 00"
            qbclicked = qbclicked + 1
        End If
    End Sub
    Private Sub qbk2_Click(sender As Object, e As EventArgs) Handles qbk2.Click
        If qbclicked = 64 = False Then
            If qbq.Text = 0 Then
                qbq.Text = Nothing
                qbb.Text = Nothing
                qbclicked = 0
            End If
            qbq.Text = qbq.Text.ToString + "1"
            qbb.Text = qbb.Text.ToString + " 01"
            qbclicked = qbclicked + 1
        End If
    End Sub
    Private Sub qbk3_Click(sender As Object, e As EventArgs) Handles qbk3.Click
        If qbclicked = 64 = False Then
            If qbq.Text = 0 Then
                qbq.Text = Nothing
                qbb.Text = Nothing
                qbclicked = 0
            End If
            qbq.Text = qbq.Text.ToString + "2"
            qbb.Text = qbb.Text.ToString + " 10"
            qbclicked = qbclicked + 1
        End If
    End Sub
    Private Sub qbk4_Click(sender As Object, e As EventArgs) Handles qbk4.Click
        If qbclicked = 64 = False Then
            If qbq.Text = 0 Then
                qbq.Text = Nothing
                qbb.Text = Nothing
                qbclicked = 0
            End If
            qbq.Text = qbq.Text.ToString + "3"
            qbb.Text = qbb.Text.ToString + " 11"
            qbclicked = qbclicked + 1
        End If
    End Sub
    Private Sub qbR_Click(sender As Object, e As EventArgs) Handles qbR.Click
        qbq.Text = 0
        qbb.Text = 0
        qbclicked = 1
    End Sub
    Dim hqclicked As Integer = 1
    Private Sub hqk1_Click(sender As Object, e As EventArgs) Handles hqk1.Click
        If hqclicked = 64 = False Then
            If hqh.Text.ToString = "0" Then
                hqh.Text = Nothing
                hqq.Text = Nothing
                hqclicked = 0
            End If
            hqh.Text = hqh.Text.ToString + "0"
            hqq.Text = hqq.Text.ToString + " 00"
            hqclicked = hqclicked + 1
        End If
    End Sub
    Private Sub hqk2_Click(sender As Object, e As EventArgs) Handles hqk2.Click
        If hqclicked = 64 = False Then
            If hqh.Text.ToString = "0" Then
                hqh.Text = Nothing
                hqq.Text = Nothing
                hqclicked = 0
            End If
            hqh.Text = hqh.Text.ToString + "1"
            hqq.Text = hqq.Text.ToString + " 01"
            hqclicked = hqclicked + 1
        End If
    End Sub
    Private Sub hqk3_Click(sender As Object, e As EventArgs) Handles hqk3.Click
        If hqclicked = 64 = False Then
            If hqh.Text.ToString = "0" Then
                hqh.Text = Nothing
                hqq.Text = Nothing
                hqclicked = 0
            End If
            hqh.Text = hqh.Text.ToString + "2"
            hqq.Text = hqq.Text.ToString + " 02"
            hqclicked = hqclicked + 1
        End If
    End Sub
    Private Sub hqk4_Click(sender As Object, e As EventArgs) Handles hqk4.Click
        If hqclicked = 64 = False Then
            If hqh.Text.ToString = "0" Then
                hqh.Text = Nothing
                hqq.Text = Nothing
                hqclicked = 0
            End If
            hqh.Text = hqh.Text.ToString + "3"
            hqq.Text = hqq.Text.ToString + " 03"
            hqclicked = hqclicked + 1
        End If
    End Sub
    Private Sub hqk5_Click(sender As Object, e As EventArgs) Handles hqk5.Click
        If hqclicked = 64 = False Then
            If hqh.Text.ToString = "0" Then
                hqh.Text = Nothing
                hqq.Text = Nothing
                hqclicked = 0
            End If
            hqh.Text = hqh.Text.ToString + "4"
            hqq.Text = hqq.Text.ToString + " 10"
            hqclicked = hqclicked + 1
        End If
    End Sub
    Private Sub hqk6_Click(sender As Object, e As EventArgs) Handles hqk6.Click
        If hqclicked = 64 = False Then
            If hqh.Text.ToString = "0" Then
                hqh.Text = Nothing
                hqq.Text = Nothing
                hqclicked = 0
            End If
            hqh.Text = hqh.Text.ToString + "5"
            hqq.Text = hqq.Text.ToString + " 11"
            hqclicked = hqclicked + 1
        End If
    End Sub
    Private Sub hqk7_Click(sender As Object, e As EventArgs) Handles hqk7.Click
        If hqclicked = 64 = False Then
            If hqh.Text.ToString = "0" Then
                hqh.Text = Nothing
                hqq.Text = Nothing
                hqclicked = 0
            End If
            hqh.Text = hqh.Text.ToString + "6"
            hqq.Text = hqq.Text.ToString + " 12"
            hqclicked = hqclicked + 1
        End If
    End Sub
    Private Sub hqk8_Click(sender As Object, e As EventArgs) Handles hqk8.Click
        If hqclicked = 64 = False Then
            If hqh.Text.ToString = "0" Then
                hqh.Text = Nothing
                hqq.Text = Nothing
                hqclicked = 0
            End If
            hqh.Text = hqh.Text.ToString + "7"
            hqq.Text = hqq.Text.ToString + " 13"
            hqclicked = hqclicked + 1
        End If
    End Sub
    Private Sub hqk9_Click(sender As Object, e As EventArgs) Handles hqk9.Click
        If hqclicked = 64 = False Then
            If hqh.Text.ToString = "0" Then
                hqh.Text = Nothing
                hqq.Text = Nothing
                hqclicked = 0
            End If
            hqh.Text = hqh.Text.ToString + "8"
            hqq.Text = hqq.Text.ToString + " 20"
            hqclicked = hqclicked + 1
        End If
    End Sub
    Private Sub hqk10_Click(sender As Object, e As EventArgs) Handles hqk10.Click
        If hqclicked = 64 = False Then
            If hqh.Text.ToString = "0" Then
                hqh.Text = Nothing
                hqq.Text = Nothing
                hqclicked = 0
            End If
            hqh.Text = hqh.Text.ToString + "9"
            hqq.Text = hqq.Text.ToString + " 21"
            hqclicked = hqclicked + 1
        End If
    End Sub
    Private Sub hqk11_Click(sender As Object, e As EventArgs) Handles hqk11.Click
        If hqclicked = 64 = False Then
            If hqh.Text.ToString = "0" Then
                hqh.Text = Nothing
                hqq.Text = Nothing
                hqclicked = 0
            End If
            hqh.Text = hqh.Text.ToString + "A"
            hqq.Text = hqq.Text.ToString + " 22"
            hqclicked = hqclicked + 1
        End If
    End Sub
    Private Sub hqk12_Click(sender As Object, e As EventArgs) Handles hqk12.Click
        If hqclicked = 64 = False Then
            If hqh.Text.ToString = "0" Then
                hqh.Text = Nothing
                hqq.Text = Nothing
                hqclicked = 0
            End If
            hqh.Text = hqh.Text.ToString + "B"
            hqq.Text = hqq.Text.ToString + " 23"
            hqclicked = hqclicked + 1
        End If
    End Sub
    Private Sub hqk13_Click(sender As Object, e As EventArgs) Handles hqk13.Click
        If hqclicked = 64 = False Then
            If hqh.Text.ToString = "0" Then
                hqh.Text = Nothing
                hqq.Text = Nothing
                hqclicked = 0
            End If
            hqh.Text = hqh.Text.ToString + "C"
            hqq.Text = hqq.Text.ToString + " 30"
            hqclicked = hqclicked + 1
        End If
    End Sub
    Private Sub hqk14_Click(sender As Object, e As EventArgs) Handles hqk14.Click
        If hqclicked = 64 = False Then
            If hqh.Text.ToString = "0" Then
                hqh.Text = Nothing
                hqq.Text = Nothing
                hqclicked = 0
            End If
            hqh.Text = hqh.Text.ToString + "D"
            hqq.Text = hqq.Text.ToString + " 31"
            hqclicked = hqclicked + 1
        End If
    End Sub
    Private Sub hqk15_Click(sender As Object, e As EventArgs) Handles hqk15.Click
        If hqclicked = 64 = False Then
            If hqh.Text.ToString = "0" Then
                hqh.Text = Nothing
                hqq.Text = Nothing
                hqclicked = 0
            End If
            hqh.Text = hqh.Text.ToString + "E"
            hqq.Text = hqq.Text.ToString + " 32"
            hqclicked = hqclicked + 1
        End If
    End Sub
    Private Sub hqk16_Click(sender As Object, e As EventArgs) Handles hqk16.Click
        If hqclicked = 64 = False Then
            If hqh.Text.ToString = "0" Then
                hqh.Text = Nothing
                hqq.Text = Nothing
                hqclicked = 0
            End If
            hqh.Text = hqh.Text.ToString + "F"
            hqq.Text = hqq.Text.ToString + " 33"
            hqclicked = hqclicked + 1
        End If
    End Sub
    Private Sub hqR_Click(sender As Object, e As EventArgs) Handles hqR.Click
        hqh.Text = 0
        hqq.Text = 0
        hqclicked = 1
    End Sub
    Dim qhclicked As Integer = 1
    Private Sub qhk1_Click(sender As Object, e As EventArgs) Handles qhk1.Click
        If qhclicked = 64 = False Then
            If qhh.Text.ToString = "0" Then
                qhq.Text = Nothing
                qhh.Text = Nothing
                qhclicked = 0
            End If
            qhq.Text = qhq.Text.ToString + " 00"
            qhh.Text = qhh.Text.ToString + "0"
            qhclicked = qhclicked + 1
        End If
    End Sub
    Private Sub qhk2_Click(sender As Object, e As EventArgs) Handles qhk2.Click
        If qhclicked = 64 = False Then
            If qhh.Text.ToString = "0" Then
                qhq.Text = Nothing
                qhh.Text = Nothing
                qhclicked = 0
            End If
            qhq.Text = qhq.Text.ToString + " 01"
            qhh.Text = qhh.Text.ToString + "1"
            qhclicked = qhclicked + 1
        End If
    End Sub
    Private Sub qhk3_Click(sender As Object, e As EventArgs) Handles qhk3.Click
        If qhclicked = 64 = False Then
            If qhh.Text.ToString = "0" Then
                qhq.Text = Nothing
                qhh.Text = Nothing
                qhclicked = 0
            End If
            qhq.Text = qhq.Text.ToString + " 02"
            qhh.Text = qhh.Text.ToString + "2"
            qhclicked = qhclicked + 1
        End If
    End Sub
    Private Sub qhk4_Click(sender As Object, e As EventArgs) Handles qhk4.Click
        If qhclicked = 64 = False Then
            If qhh.Text.ToString = "0" Then
                qhq.Text = Nothing
                qhh.Text = Nothing
                qhclicked = 0
            End If
            qhq.Text = qhq.Text.ToString + " 03"
            qhh.Text = qhh.Text.ToString + "3"
            qhclicked = qhclicked + 1
        End If
    End Sub
    Private Sub qhk5_Click(sender As Object, e As EventArgs) Handles qhk5.Click
        If qhclicked = 64 = False Then
            If qhh.Text.ToString = "0" Then
                qhq.Text = Nothing
                qhh.Text = Nothing
                qhclicked = 0
            End If
            qhq.Text = qhq.Text.ToString + " 10"
            qhh.Text = qhh.Text.ToString + "4"
            qhclicked = qhclicked + 1
        End If
    End Sub
    Private Sub qhk6_Click(sender As Object, e As EventArgs) Handles qhk6.Click
        If qhclicked = 64 = False Then
            If qhh.Text.ToString = "0" Then
                qhq.Text = Nothing
                qhh.Text = Nothing
                qhclicked = 0
            End If
            qhq.Text = qhq.Text.ToString + " 11"
            qhh.Text = qhh.Text.ToString + "5"
            qhclicked = qhclicked + 1
        End If
    End Sub
    Private Sub qhk7_Click(sender As Object, e As EventArgs) Handles qhk7.Click
        If qhclicked = 64 = False Then
            If qhh.Text.ToString = "0" Then
                qhq.Text = Nothing
                qhh.Text = Nothing
                qhclicked = 0
            End If
            qhq.Text = qhq.Text.ToString + " 12"
            qhh.Text = qhh.Text.ToString + "6"
            qhclicked = qhclicked + 1
        End If
    End Sub
    Private Sub qhk8_Click(sender As Object, e As EventArgs) Handles qhk8.Click
        If qhclicked = 64 = False Then
            If qhh.Text.ToString = "0" Then
                qhq.Text = Nothing
                qhh.Text = Nothing
                qhclicked = 0
            End If
            qhq.Text = qhq.Text.ToString + " 13"
            qhh.Text = qhh.Text.ToString + "7"
            qhclicked = qhclicked + 1
        End If
    End Sub
    Private Sub qhk9_Click(sender As Object, e As EventArgs) Handles qhk9.Click
        If qhclicked = 64 = False Then
            If qhh.Text.ToString = "0" Then
                qhq.Text = Nothing
                qhh.Text = Nothing
                qhclicked = 0
            End If
            qhq.Text = qhq.Text.ToString + " 20"
            qhh.Text = qhh.Text.ToString + "8"
            qhclicked = qhclicked + 1
        End If
    End Sub
    Private Sub qhk10_Click(sender As Object, e As EventArgs) Handles qhk10.Click
        If qhclicked = 64 = False Then
            If qhh.Text.ToString = "0" Then
                qhq.Text = Nothing
                qhh.Text = Nothing
                qhclicked = 0
            End If
            qhq.Text = qhq.Text.ToString + " 21"
            qhh.Text = qhh.Text.ToString + "9"
            qhclicked = qhclicked + 1
        End If
    End Sub
    Private Sub qhk11_Click(sender As Object, e As EventArgs) Handles qhk11.Click
        If qhclicked = 64 = False Then
            If qhh.Text.ToString = "0" Then
                qhq.Text = Nothing
                qhh.Text = Nothing
                qhclicked = 0
            End If
            qhq.Text = qhq.Text.ToString + " 22"
            qhh.Text = qhh.Text.ToString + "A"
            qhclicked = qhclicked + 1
        End If
    End Sub
    Private Sub qhk12_Click(sender As Object, e As EventArgs) Handles qhk12.Click
        If qhclicked = 64 = False Then
            If qhh.Text.ToString = "0" Then
                qhq.Text = Nothing
                qhh.Text = Nothing
                qhclicked = 0
            End If
            qhq.Text = qhq.Text.ToString + " 23"
            qhh.Text = qhh.Text.ToString + "B"
            qhclicked = qhclicked + 1
        End If
    End Sub
    Private Sub qhk13_Click(sender As Object, e As EventArgs) Handles qhk13.Click
        If qhclicked = 64 = False Then
            If qhh.Text.ToString = "0" Then
                qhq.Text = Nothing
                qhh.Text = Nothing
                qhclicked = 0
            End If
            qhq.Text = qhq.Text.ToString + " 30"
            qhh.Text = qhh.Text.ToString + "C"
            qhclicked = qhclicked + 1
        End If
    End Sub
    Private Sub qhk14_Click(sender As Object, e As EventArgs) Handles qhk14.Click
        If qhclicked = 64 = False Then
            If qhh.Text.ToString = "0" Then
                qhq.Text = Nothing
                qhh.Text = Nothing
                qhclicked = 0
            End If
            qhq.Text = qhq.Text.ToString + " 31"
            qhh.Text = qhh.Text.ToString + "D"
            qhclicked = qhclicked + 1
        End If
    End Sub
    Private Sub qhk15_Click(sender As Object, e As EventArgs) Handles qhk15.Click
        If qhclicked = 64 = False Then
            If qhh.Text.ToString = "0" Then
                qhq.Text = Nothing
                qhh.Text = Nothing
                qhclicked = 0
            End If
            qhq.Text = qhq.Text.ToString + " 32"
            qhh.Text = qhh.Text.ToString + "E"
            qhclicked = qhclicked + 1
        End If
    End Sub
    Private Sub qhk16_Click(sender As Object, e As EventArgs) Handles qhk16.Click
        If qhclicked = 64 = False Then
            If qhh.Text.ToString = "0" Then
                qhq.Text = Nothing
                qhh.Text = Nothing
                qhclicked = 0
            End If
            qhq.Text = qhq.Text.ToString + " 33"
            qhh.Text = qhh.Text.ToString + "F"
            qhclicked = qhclicked + 1
        End If
    End Sub
    Private Sub qhR_Click(sender As Object, e As EventArgs) Handles qhR.Click
        qhq.Text = 0
        qhh.Text = 0
        qhclicked = 1
    End Sub
    Private Sub qok1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles qok1.SelectedIndexChanged
        If qok1.Text = Nothing = False And qok2.Text = Nothing = False And qok3.Text = Nothing = False Then
            qoEXE.Enabled = True
        End If
    End Sub
    Private Sub qok2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles qok2.SelectedIndexChanged
        If qok1.Text = Nothing = False And qok2.Text = Nothing = False And qok3.Text = Nothing = False Then
            qoEXE.Enabled = True
        End If
    End Sub
    Private Sub qok3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles qok3.SelectedIndexChanged
        If qok1.Text = Nothing = False And qok2.Text = Nothing = False And qok3.Text = Nothing = False Then
            qoEXE.Enabled = True
        End If
    End Sub
    Dim qoClicked As Integer = 1
    Private Sub qoCNow()
        qoClicked = qoClicked + 1
        Dim T As String = qok1.Text.ToString + qok2.Text.ToString + qok3.Text.ToString
        qoq.Text = qoq.Text.ToString + " " + (T.ToString).ToString
        Dim t3 = qok1.Text.ToString
        Dim t2 = qok2.Text.ToString
        Dim t1 = qok3.Text.ToString
        Dim Dec = t3 * (4 ^ 2) + t2 * (4 ^ 1) + t1 * (4 ^ 0)
        Dim x1m As String = Dec Mod (8 ^ 1)
        Dim x1 As String = Dec \ (8 ^ 1)
        Dim x0m As String = x1m Mod (8 ^ 0)
        Dim x0 As String = x1m \ (8 ^ 0)
        Dim Z As String = " " + x1.ToString + x0.ToString
        qoo.Text = qoo.Text.ToString + Z.ToString
        qoListBox.Items.Add(T.ToString + " = " + Z.ToString)
    End Sub
    Private Sub qoEXE_Click(sender As Object, e As EventArgs) Handles qoEXE.Click
        If qoClicked = 64 = False Then
            If Val(qoq.Text) = 0 Then
                qoClicked = 0
                qoq.Text = Nothing
                qoo.Text = Nothing
            End If
            qoCNow()
        End If
    End Sub
    Private Sub qoR_Click(sender As Object, e As EventArgs) Handles qoR.Click
        qoq.Text = 0
        qoo.Text = 0
        qoClicked = 1
        qoListBox.Items.Clear()
    End Sub
    Private Sub oqk1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles oqk1.SelectedIndexChanged
        If oqk1.Text = Nothing = False And oqk2.Text = Nothing = False Then
            oqEXE.Enabled = True
        End If
    End Sub
    Private Sub oqk2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles oqk2.SelectedIndexChanged
        If oqk1.Text = Nothing = False And oqk2.Text = Nothing = False Then
            oqEXE.Enabled = True
        End If
    End Sub
    Dim oqClicked As Integer = 1
    Private Sub oqCNow()
        qoClicked = qoClicked + 1
        Dim T As String = oqk1.Text.ToString + oqk2.Text.ToString
        oqo.Text = oqo.Text.ToString + " " + (T.ToString).ToString
        Dim t3 = oqk1.Text.ToString
        Dim t2 = oqk2.Text.ToString
        Dim Dec = t3 * (8 ^ 1) + t2 * (8 ^ 0)
        Dim x2m As String = Dec Mod (4 ^ 2)
        Dim x2 As String = Dec \ (4 ^ 2)
        Dim x1m As String = x2m Mod (4 ^ 1)
        Dim x1 As String = x2m \ (4 ^ 1)
        Dim x0m As String = x1m Mod (4 ^ 0)
        Dim x0 As String = x1m \ (4 ^ 0)
        Dim Z As String = " " + x2.ToString + x1.ToString + x0.ToString
        oqq.Text = oqq.Text.ToString + Z.ToString
        oqListBox.Items.Add(T.ToString + " = " + Z.ToString)
    End Sub
    Private Sub oqEXE_Click(sender As Object, e As EventArgs) Handles oqEXE.Click
        If oqClicked = 64 = False Then
            If Val(oqo.Text) = 0 Then
                oqClicked = 0
                oqo.Text = Nothing
                oqq.Text = Nothing
            End If
            oqCNow()
        End If
    End Sub
    Private Sub oqR_Click(sender As Object, e As EventArgs) Handles oqR.Click
        oqo.Text = 0
        oqq.Text = 0
        oqClicked = 1
        oqListBox.Items.Clear()
    End Sub
    Private Sub MyTabControl_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles MyTabControl.MouseDoubleClick
        If MyTabControl.Multiline = False Then
            MyTabControl.Multiline = True
            Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Else
            MyTabControl.Multiline = False
            Me.BackColor = System.Drawing.SystemColors.Control
        End If
    End Sub
    Private Sub RedTrackBar_Scroll(sender As Object, e As EventArgs) Handles RedTrackBar.Scroll
        RedDomainUpDown.Text = RedTrackBar.Value
        ColorPictureBox.BackColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value)
        xC()
    End Sub
    Private Sub GreenTrackBar_Scroll(sender As Object, e As EventArgs) Handles GreenTrackBar.Scroll
        GreenDomainUpDown.Text = GreenTrackBar.Value
        ColorPictureBox.BackColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value)
        xC()
    End Sub
    Private Sub BuleTrackBar_Scroll(sender As Object, e As EventArgs) Handles BlueTrackBar.Scroll
        BlueDomainUpDown.Text = BlueTrackBar.Value
        ColorPictureBox.BackColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value)
        xC()
    End Sub
    Private Sub RedDomainUpDown_SelectedItemChanged(sender As Object, e As EventArgs) Handles RedDomainUpDown.SelectedItemChanged
        RedDomainUpDown.Text = Val(RedDomainUpDown.Text)
        RedTrackBar.Value = RedDomainUpDown.Text
        ColorPictureBox.BackColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value)
        xC()
    End Sub
    Private Sub GreenDomainUpDown_SelectedItemChanged(sender As Object, e As EventArgs) Handles GreenDomainUpDown.SelectedItemChanged
        GreenDomainUpDown.Text = Val(GreenDomainUpDown.Text)
        GreenTrackBar.Value = GreenDomainUpDown.Text
        ColorPictureBox.BackColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value)
        xC()
    End Sub
    Private Sub BlueDomainUpDown_SelectedItemChanged(sender As Object, e As EventArgs) Handles BlueDomainUpDown.SelectedItemChanged
        BlueDomainUpDown.Text = Val(BlueDomainUpDown.Text)
        BlueTrackBar.Value = BlueDomainUpDown.Text
        ColorPictureBox.BackColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value)
        xC()
    End Sub
    Private Sub xC()
        Dim SRed As Integer = RedTrackBar.Value
        Dim SGreen As Integer = GreenTrackBar.Value
        Dim SBlue As Integer = BlueTrackBar.Value
        Dim SRedx = Convert.ToString(SRed, 16)
        Dim SGreenx = Convert.ToString(SGreen, 16)
        Dim SBluex = Convert.ToString(SBlue, 16)
        TabPage_Color.Text = "Color = ( " + SRedx.ToString + " , " + SGreenx.ToString + " , " + SBluex.ToString + " )"
    End Sub
End Class
