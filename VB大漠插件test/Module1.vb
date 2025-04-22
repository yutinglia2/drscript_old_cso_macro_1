Module Module1

    Public ReadOnly Property GetMyVersion3() As String '取得程式的版本號碼(格式：X.X.X)
        Get
            Return My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build '取得版本號碼
        End Get
    End Property

    Public dm As Object

    Public eyLogin As Object

    Public hwnd As Object

    Public GGGGG As Object

    Public KeySet As Object

    Public OnSet As Object

    Public KeyOn1, KeyOnF1, KeyOn2, KeyOnF2, KeyOn3, KeyOnF3, KeyOn4, KeyOnF4, KeyOn5, KeyOnF5, KeyOn6, KeyOnF6, KeyOn7, KeyOn8, KeyOnF8, KeyOn9, KeyOnF9, KeyOn10, KeyOnF10, KeyOn11, KeyOnF11, KeyOn12, KeyOnF12, KeyOn13, KeyOnF13, KeyOn14, KeyOnF14 As Object

    Public time1, time2, time3, time4, 蓋亞, Desperado, time5, time6, 湛盧BUG, time7, time8, time9, time10, 極道滅殺, time11, time12, time13, time14, time15, time16, qwe, time17, time18, time19, time20, 刷槍, time21, time22, GS123, 閃t1, 閃t2 As String

    Public timerv As Integer = 20

    Public timerv2 As Integer = 100

    Public timeim As Integer

    Public 人物

    Public 買武器 = 1

    Public time99456 As Integer = 200

    Public 精準度 = 0.7

    Public room狀態 = "房間外" ' "房間內"  "房間外"  "STUDIO"  "客制"  "遊戲中"  "獎勵"  "確認"  "選擇兵種"

    Public mode, modee As String

    Public name1, name2, cm7, cm8 As String

    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As UInt32) As Short

    Public runtime, runtimeh, runtimem As String

    Public mkey1 As String = "["
    Public mkey2 As String = "]"

    Public mkey3 As String = "["
    Public mkey4 As String = "["
    Public mkey5 As String = "["
    Public mkey6 As String = "["

    '>>>>>>>>>>>>>>>>>>>>按鍵資料<<<<<<<<<<<<<<<<<<<<'
    Dim strKey() As String = {"None", "Enter", "Shift", "Ctrl", "Alt", "Space", "PageUp", "PageDown", "Insert", "Delete", "Home", "End", "Left", "Up", "Right", "Down", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "ESCAPE", "滑鼠中鍵", "滑鼠側鍵1", "滑鼠側鍵2"}
    Private Const WM_KEYDOWN As Integer = &H100
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    '>>>>>>>>>>>>>>>>>>>>按鍵資料2<<<<<<<<<<<<<<<<<<<<'
    Dim strKey2() As String = {"None", "Enter", "Shift", "Ctrl", "Alt", "Space", "PageUp", "PageDown", "Insert", "Delete", "Home", "End", "Left", "Up", "Right", "Down", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "ESCAPE", "[", "]", ",", ".", ";", "'", "-", "="}
    Private Const WM_KEYDOWN2 As Integer = &H100
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    '>>>>>>>>>>>>>>>>>>>>將所有按鍵加入至ComboBox2<<<<<<<<<<<<<<<<<<<<'
    Public Sub AddKeyItem_LA2(ByVal cbo As ComboBox)
        cbo.Items.Clear()
        For i = 0 To strKey2.Length - 1
            cbo.Items.Add(strKey2(i))
        Next
        cbo.SelectedIndex = 0
    End Sub
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    '>>>>>>>>>>>>>>>>>>>>後台判定<<<<<<<<<<<<<<<<<<<<'
    Public Function MouseKey(ByVal LR As String, ByVal DU As String)
        If mode = 1 Then
            Select Case LR
                Case "L"
                    Select Case DU
                        Case "Down"
                            dm.LeftDown
                        Case "Up"
                            dm.LeftUp
                    End Select
                Case "R"
                    Select Case DU
                        Case "Down"
                            dm.RightDown
                        Case "Up"
                            dm.RightUp
                    End Select
                    Return 0
            End Select
        End If
        If mode = 2 Then
            Select Case LR
                Case "L"
                    Select Case DU
                        Case "Down"
                            dm.KeyDownChar(mkey1)
                        Case "Up"
                            dm.KeyUpChar(mkey1)
                    End Select
                Case "R"
                    Select Case DU
                        Case "Down"
                            dm.KeyDownChar(mkey2)
                        Case "Up"
                            dm.KeyUpChar(mkey2)
                    End Select
                    Return 0
            End Select
        End If
    End Function
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    '/////////////////////////////購買護甲///////////////////////////////
    Public Function 購買護甲()
        dm.KeyPressChar("b")
        Threading.Thread.Sleep(50)
        dm.KeyPressChar("8")
        Threading.Thread.Sleep(50)

        dm.KeyPressChar(qwe)

        Threading.Thread.Sleep(50)
        dm.KeyPressChar("0")
        dm.KeyPressChar("0")
        Threading.Thread.Sleep(50)
        dm.MoveTo(513, 422)
        Threading.Thread.Sleep(50)
        dm.LeftClick
        dm.KeyPressChar("0")
        dm.KeyPressChar("0")
    End Function
    '///////////////////////////////////////////////////////////////////////
    '/////////////////////////////LeftClick///////////////////////////////
    Public Function LeftClick()
        dm.LeftDown
        Threading.Thread.Sleep(50)
        dm.LeftUp
    End Function
    '///////////////////////////////////////////////////////////////////////
    '/////////////////////////////MouseMoveR///////////////////////////////
    Public Function MouseMoveR()
        dm.MoveR(50, 50)
        Threading.Thread.Sleep(time17)
        dm.MoveR(-50, -50)
        Threading.Thread.Sleep(time17)
    End Function
    '///////////////////////////////////////////////////////////////////////

    Public Function tea(ByVal a As Integer)
        Select Case a
            Case 1
                Return "武器腳本"
            Case 2
                Return "武器腳本2"
            Case 3
                Return "KZ腳本"
            Case 4
                Return "後台掛機"
            Case 5
                Return "掛機設定"
            Case 6
                Return "其他功能"
            Case 7
                Return "腳本設定"
        End Select
    End Function

    '>>>>>>>>>>>>>>>>>>>>熱鍵判定<<<<<<<<<<<<<<<<<<<<'
    Public Function GetKey(ByVal KeyType As String, ByVal KeyCode As String)
        Dim code As UInt32 = toKeyValue(KeyCode)
        Dim onoff As String = 0
        Select Case KeyType
            Case "Press"
                If GetAsyncKeyState(code) <> 0 Then
                    Return 1
                End If
                If GetAsyncKeyState(code) = 0 Then
                    Return 0
                End If
            Case "On"
                If GetAsyncKeyState(code) <> 0 Then
                    Do Until GetAsyncKeyState(code) = 0
                    Loop
                    Return 1
                End If
            Case "Off"
                If GetAsyncKeyState(code) <> 0 Then
                    Return 0
                End If
            Case Else
                Return 0
        End Select
    End Function

    Public Function GetKeyOff(ByVal KeyCode As String, ByVal vvvKey As String)
        Dim code As UInt32 = toKeyValue(KeyCode)
        If vvvKey = 0 Then
            If GetAsyncKeyState(code) <> 0 Then
                Return 0
            End If
        End If

    End Function
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    '>>>>>>>>>>>>>>>>>>>>蓋亞模式判定<<<<<<<<<<<<<<<<<<<<'
    Dim kp As String
    Dim kp2 As String
    Public Function OnOffCheck(ByVal OnOff As String, ByVal Key As String, ByVal vvKey As String)
        Select Case OnOff
            Case "Press"
                If GetKey("Press", Key) = 1 Then
                    kp = 1
                End If
                If GetKey("Press", Key) = 0 Then
                    kp = 0
                End If
            Case "On"
                If kp2 = 0 Then
                    If GetKey("On", Key) = 1 Then
                        kp2 = 1
                    End If
                End If
            Case "Off"
                If kp2 = 1 Then
                    If GetKey("On", Key) = 1 Then
                        kp2 = 0
                    End If
                End If
        End Select
        Select Case vvKey
            Case "KeyOn1"
                KeyOn1 = kp
            Case "KeyOnF1"
                KeyOnF1 = kp2
        End Select
    End Function
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'
    '>>>>>>>>>>>>>>>>>>>>GS模式判定<<<<<<<<<<<<<<<<<<<<'
    Dim kp3 As String
    Dim kp4 As String
    Public Function OnOffCheck2(ByVal OnOff As String, ByVal Key As String, ByVal vvKey As String)
        Select Case OnOff
            Case "Press"
                If GetKey("Press", Key) = 1 Then
                    kp3 = 1
                End If
                If GetKey("Press", Key) = 0 Then
                    kp3 = 0
                End If
            Case "On"
                If kp4 = 0 Then
                    If GetKey("On", Key) = 1 Then
                        kp4 = 1
                    End If
                End If
            Case "Off"
                If kp4 = 1 Then
                    If GetKey("On", Key) = 1 Then
                        kp4 = 0
                    End If
                End If
        End Select
        Select Case vvKey
            Case "KeyOn2"
                KeyOn2 = kp3
            Case "KeyOnF2"
                KeyOnF2 = kp4
        End Select
    End Function
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'
    '>>>>>>>>>>>>>>>>>>>>Desperado模式判定<<<<<<<<<<<<<<<<<<<<'
    Dim kp5 As String
    Dim kp6 As String
    Public Function OnOffCheck3(ByVal OnOff As String, ByVal Key As String, ByVal vvKey As String)
        Select Case OnOff
            Case "Press"
                If GetKey("Press", Key) = 1 Then
                    kp5 = 1
                End If
                If GetKey("Press", Key) = 0 Then
                    kp5 = 0
                End If
            Case "On"
                If kp6 = 0 Then
                    If GetKey("On", Key) = 1 Then
                        kp6 = 1
                    End If
                End If
            Case "Off"
                If kp6 = 1 Then
                    If GetKey("On", Key) = 1 Then
                        kp6 = 0
                    End If
                End If
        End Select
        Select Case vvKey
            Case "KeyOn3"
                KeyOn3 = kp5
            Case "KeyOnF3"
                KeyOnF3 = kp6
        End Select
    End Function
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'
    '>>>>>>>>>>>>>>>>>>>>Desperado模式判定<<<<<<<<<<<<<<<<<<<<'
    Dim kp7 As String
    Dim kp8 As String
    Public Function OnOffCheck4(ByVal OnOff As String, ByVal Key As String, ByVal vvKey As String)
        Select Case OnOff
            Case "Press"
                If GetKey("Press", Key) = 1 Then
                    kp7 = 1
                End If
                If GetKey("Press", Key) = 0 Then
                    kp7 = 0
                End If
            Case "On"
                If kp8 = 0 Then
                    If GetKey("On", Key) = 1 Then
                        kp8 = 1
                    End If
                End If
            Case "Off"
                If kp8 = 1 Then
                    If GetKey("On", Key) = 1 Then
                        kp8 = 0
                    End If
                End If
        End Select
        Select Case vvKey
            Case "KeyOn4"
                KeyOn4 = kp7
            Case "KeyOnF4"
                KeyOnF4 = kp8
        End Select
    End Function
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'
    '>>>>>>>>>>>>>>>>>>>>極道滅殺模式判定<<<<<<<<<<<<<<<<<<<<'
    Dim kp9 As String
    Dim kp10 As String
    Public Function OnOffCheck5(ByVal OnOff As String, ByVal Key As String, ByVal vvKey As String)
        Select Case OnOff
            Case "Press"
                If GetKey("Press", Key) = 1 Then
                    kp9 = 1
                End If
                If GetKey("Press", Key) = 0 Then
                    kp9 = 0
                End If
            Case "On"
                If kp10 = 0 Then
                    If GetKey("On", Key) = 1 Then
                        kp10 = 1
                    End If
                End If
            Case "Off"
                If kp10 = 1 Then
                    If GetKey("On", Key) = 1 Then
                        kp10 = 0
                    End If
                End If
        End Select
        Select Case vvKey
            Case "KeyOn5"
                KeyOn5 = kp9
            Case "KeyOnF5"
                KeyOnF5 = kp10
        End Select
    End Function
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'
    '>>>>>>>>>>>>>>>>>>>>SGS模式判定<<<<<<<<<<<<<<<<<<<<'
    Dim kp11 As String
    Dim kp12 As String
    Public Function OnOffCheck6(ByVal OnOff As String, ByVal Key As String, ByVal vvKey As String)
        Select Case OnOff
            Case "Press"
                If GetKey("Press", Key) = 1 Then
                    kp11 = 1
                End If
                If GetKey("Press", Key) = 0 Then
                    kp11 = 0
                End If
            Case "On"
                If kp12 = 0 Then
                    If GetKey("On", Key) = 1 Then
                        kp12 = 1
                    End If
                End If
            Case "Off"
                If kp12 = 1 Then
                    If GetKey("On", Key) = 1 Then
                        kp12 = 0
                    End If
                End If
        End Select
        Select Case vvKey
            Case "KeyOn6"
                KeyOn6 = kp11
            Case "KeyOnF6"
                KeyOnF6 = kp12
        End Select
    End Function
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'
    '>>>>>>>>>>>>>>>>>>>>刷槍模式判定<<<<<<<<<<<<<<<<<<<<'
    Dim kp14 As String
    Dim kp15 As String
    Public Function OnOffCheck8(ByVal OnOff As String, ByVal Key As String, ByVal vvKey As String)
        Select Case OnOff
            Case "Press"
                If GetKey("Press", Key) = 1 Then
                    kp14 = 1
                End If
                If GetKey("Press", Key) = 0 Then
                    kp14 = 0
                End If
            Case "On"
                If kp15 = 0 Then
                    If GetKey("On", Key) = 1 Then
                        kp15 = 1
                    End If
                End If
            Case "Off"
                If kp15 = 1 Then
                    If GetKey("On", Key) = 1 Then
                        kp15 = 0
                    End If
                End If
        End Select
        Select Case vvKey
            Case "KeyOn8"
                KeyOn8 = kp14
            Case "KeyOnF8"
                KeyOnF8 = kp15
        End Select
    End Function
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    '>>>>>>>>>>>>>>>>>>>>閃擊斯特恩模式判定<<<<<<<<<<<<<<<<<<<<'
    Dim kp16 As String
    Dim kp17 As String
    Public Function OnOffCheck9(ByVal OnOff As String, ByVal Key As String, ByVal vvKey As String)
        Select Case OnOff
            Case "Press"
                If GetKey("Press", Key) = 1 Then
                    kp16 = 1
                End If
                If GetKey("Press", Key) = 0 Then
                    kp16 = 0
                End If
            Case "On"
                If kp17 = 0 Then
                    If GetKey("On", Key) = 1 Then
                        kp17 = 1
                    End If
                End If
            Case "Off"
                If kp17 = 1 Then
                    If GetKey("On", Key) = 1 Then
                        kp17 = 0
                    End If
                End If
        End Select
        Select Case vvKey
            Case "KeyOn9"
                KeyOn9 = kp16
            Case "KeyOnF9"
                KeyOnF9 = kp17
        End Select
    End Function
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    '>>>>>>>>>>>>>>>>>>>>瞬狙模式判定<<<<<<<<<<<<<<<<<<<<'
    Dim kp13 As String
    Public Function OnOffCheck7(ByVal OnOff As String, ByVal Key As String, ByVal vvKey As String)
        Select Case OnOff
            Case "Press"
                If GetKey("Press", Key) = 1 Then
                    kp13 = 1
                End If
                If GetKey("Press", Key) = 0 Then
                    kp13 = 0
                End If
        End Select
        Select Case vvKey
            Case "KeyOn7"
                KeyOn7 = kp13
        End Select
    End Function
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    '>>>>>>>>>>>>>>>>>>>>edit1模式判定<<<<<<<<<<<<<<<<<<<<'
    Dim kp18 As String
    Dim kp19 As String
    Public Function OnOffCheck10(ByVal OnOff As String, ByVal Key As String, ByVal vvKey As String)
        Select Case OnOff
            Case "Press"
                If GetKey("Press", Key) = 1 Then
                    kp18 = 1
                End If
                If GetKey("Press", Key) = 0 Then
                    kp18 = 0
                End If
            Case "On"
                If kp19 = 0 Then
                    If GetKey("On", Key) = 1 Then
                        kp19 = 1
                    End If
                End If
            Case "Off"
                If kp19 = 1 Then
                    If GetKey("On", Key) = 1 Then
                        kp19 = 0
                    End If
                End If
        End Select
        Select Case vvKey
            Case "KeyOn10"
                KeyOn10 = kp18
            Case "KeyOnF10"
                KeyOnF10 = kp19
        End Select
    End Function
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    '>>>>>>>>>>>>>>>>>>>>edit2模式判定<<<<<<<<<<<<<<<<<<<<'
    Dim kp20 As String
    Dim kp21 As String
    Public Function OnOffCheck11(ByVal OnOff As String, ByVal Key As String, ByVal vvKey As String)
        Select Case OnOff
            Case "Press"
                If GetKey("Press", Key) = 1 Then
                    kp20 = 1
                End If
                If GetKey("Press", Key) = 0 Then
                    kp20 = 0
                End If
            Case "On"
                If kp21 = 0 Then
                    If GetKey("On", Key) = 1 Then
                        kp21 = 1
                    End If
                End If
            Case "Off"
                If kp21 = 1 Then
                    If GetKey("On", Key) = 1 Then
                        kp21 = 0
                    End If
                End If
        End Select
        Select Case vvKey
            Case "KeyOn11"
                KeyOn11 = kp20
            Case "KeyOnF11"
                KeyOnF11 = kp21
        End Select
    End Function
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    '>>>>>>>>>>>>>>>>>>>>edit3模式判定<<<<<<<<<<<<<<<<<<<<'
    Dim kp22 As String
    Dim kp23 As String
    Public Function OnOffCheck12(ByVal OnOff As String, ByVal Key As String, ByVal vvKey As String)
        Select Case OnOff
            Case "Press"
                If GetKey("Press", Key) = 1 Then
                    kp22 = 1
                End If
                If GetKey("Press", Key) = 0 Then
                    kp22 = 0
                End If
            Case "On"
                If kp23 = 0 Then
                    If GetKey("On", Key) = 1 Then
                        kp23 = 1
                    End If
                End If
            Case "Off"
                If kp23 = 1 Then
                    If GetKey("On", Key) = 1 Then
                        kp23 = 0
                    End If
                End If
        End Select
        Select Case vvKey
            Case "KeyOn12"
                KeyOn12 = kp22
            Case "KeyOnF12"
                KeyOnF12 = kp23
        End Select
    End Function
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    '>>>>>>>>>>>>>>>>>>>>edit4模式判定<<<<<<<<<<<<<<<<<<<<'
    Dim kp24 As String
    Dim kp25 As String
    Public Function OnOffCheck13(ByVal OnOff As String, ByVal Key As String, ByVal vvKey As String)
        Select Case OnOff
            Case "Press"
                If GetKey("Press", Key) = 1 Then
                    kp24 = 1
                End If
                If GetKey("Press", Key) = 0 Then
                    kp24 = 0
                End If
            Case "On"
                If kp25 = 0 Then
                    If GetKey("On", Key) = 1 Then
                        kp25 = 1
                    End If
                End If
            Case "Off"
                If kp25 = 1 Then
                    If GetKey("On", Key) = 1 Then
                        kp25 = 0
                    End If
                End If
        End Select
        Select Case vvKey
            Case "KeyOn13"
                KeyOn13 = kp24
            Case "KeyOnF13"
                KeyOnF13 = kp25
        End Select
    End Function
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    '>>>>>>>>>>>>>>>>>>>>edit5模式判定<<<<<<<<<<<<<<<<<<<<'
    Dim kp26 As String
    Dim kp27 As String
    Public Function OnOffCheck14(ByVal OnOff As String, ByVal Key As String, ByVal vvKey As String)
        Select Case OnOff
            Case "Press"
                If GetKey("Press", Key) = 1 Then
                    kp26 = 1
                End If
                If GetKey("Press", Key) = 0 Then
                    kp26 = 0
                End If
            Case "On"
                If kp27 = 0 Then
                    If GetKey("On", Key) = 1 Then
                        kp27 = 1
                    End If
                End If
            Case "Off"
                If kp27 = 1 Then
                    If GetKey("On", Key) = 1 Then
                        kp27 = 0
                    End If
                End If
        End Select
        Select Case vvKey
            Case "KeyOn14"
                KeyOn14 = kp26
            Case "KeyOnF14"
                KeyOnF14 = kp27
        End Select
    End Function
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'



    '>>>>>>>>>>>>>>>>>>>>KeyCode<<<<<<<<<<<<<<<<<<<<'
    Private Function toKeyValue(ByVal KeyCode As String) As Integer
        Dim intKey() As Integer = {0, &HD, &H10, &H11, &H12, &H20, &H21, &H22, &H2D, &H2E, &H24, &H23, &H25, &H26, &H27, &H28, &H30, &H31, &H32, &H33, &H34, &H35, &H36, &H37, &H38, &H39, &H41, &H42, &H43, &H44, &H45, &H46, &H47, &H48, &H49, &H4A, &H4B, &H4C, &H4D, &H4E, &H4F, &H50, &H51, &H52, &H53, &H54, &H55, &H56, &H57, &H58, &H59, &H5A, &H70, &H71, &H72, &H73, &H74, &H75, &H76, &H77, &H78, &H79, &H7A, &H7B, &H1B, &H4, &H5, &H6, &HDB, &HDD, &H1, &H2}
        For i = 0 To strKey.Length - 1
            If strKey(i) = KeyCode Then Return intKey(i)
        Next
        Return False
    End Function
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    '>>>>>>>>>>>>>>>>>>>>將所有按鍵加入至ComboBox<<<<<<<<<<<<<<<<<<<<'
    Public Sub AddKeyItem_LA(ByVal cbo As ComboBox)
        cbo.Items.Clear()
        For i = 0 To strKey.Length - 1
            cbo.Items.Add(strKey(i))
        Next
        cbo.SelectedIndex = 0
    End Sub
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    '>>>>>>>>>>>>>>>>>>>>僅能輸入數字<<<<<<<<<<<<<<<<<<<<'
    Public Sub OnlyNumber_LA(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 8, 48 To 57, 46
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'






    Public Function fedit(ByVal aab() As String)
        'If AAb(0) = "防呆開啟" Then
        '    CheckBox2.CheckState = CheckState.Checked
        'End If
        'If AAb(0) = "精準模式開啟" Then
        '    CheckBox3.CheckState = CheckState.Checked
        'End If
        'If AAb(0) = "防呆關閉" Then
        '    CheckBox2.CheckState = CheckState.Unchecked
        'End If
        'If AAb(0) = "精準模式關閉" Then
        '    CheckBox3.CheckState = CheckState.Unchecked
        'End If

        Dim rndNum123 As New Random()

        Select Case aab(0)
                Case "N"
                    Return 0
                Case "按下"
                    dm.KeyDownChar(aab(1))
                Case "放開"
                    dm.KeyUpChar(aab(1))
                Case "延遲"
                    Threading.Thread.Sleep(aab(1))
                Case "隨機延遲"
                    Threading.Thread.Sleep(rndNum123.Next(aab(1), aab(2)))
                Case "按下mouse"
                    Select Case aab(1)
                        Case "左"
                            dm.LeftDown
                        Case "右"
                            dm.RightDown
                    End Select
                Case "放開mouse"
                    Select Case aab(1)
                        Case "左"
                            dm.LeftUp
                        Case "右"
                            dm.RightUp
                    End Select

                Case "滑鼠移到"
                    dm.MoveTo(aab(1), aab(2))
                Case "相對移動"
                    dm.MoveR(aab(1), aab(2))
                Case "滾輪上"
                    dm.WheelUp
                Case "滾輪下"
                    dm.WheelDown

                Case Else
                    Return 0
            End Select

            Return 1
    End Function


End Module
