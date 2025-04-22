Imports System.Threading
Imports WinFrom_WebApi_Demo_Library
Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Public Class ASD

    Private Declare Sub ReleaseCapture Lib "user32" ()

    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As String) As Integer

    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2


    '/////////////////////////////////載入主界面時做的事////////////////////////////////////
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '/////////////////////注冊大漠插件/////////////////////////
        Dim app As String
        app = Application.StartupPath
        Shell("regsvr32 /s " & app & "\1.dll")
        'Shell("regsvr32 /s " & app & "\EyLogin.dll")

        'eyLogin = CreateObject("EyLoginSoft")
        'eyLogin.SetAppKey("6497F6CD4D9F42FD82FB4422C9B79D02")


        '//////////////////////////////////////////////////////////

        Me.TopMost = True

        '/////////////////////檢查大漠插件是否正常注冊/////////////////////////
        Try
            '要執行的動作 
            dm = CreateObject("dm.dmsoft")
        Catch exx As Exception
            'Catch ex As System.Net.WebException
            '擷取錯誤並顯示 
            MsgBox("錯誤訊息 ： 自動註冊DLL失敗 " & vbCrLf & "請確保壓縮檔完整解壓在同一資料夾 和資料夾名稱沒有空格",, "Error")
            Shell("regsvr32 /u /s " & app & "\1.dll")
            Shell(Application.StartupPath & "\re.bat")
            End
        End Try
        '/////////////////////注冊大漠插件/////////////////////////


        '///////////////////檢查大漠插件是否正常調用/////////////////////
        Dim ver
        dm = CreateObject("dm.dmsoft")
        ver = dm.ver()
        If ver = 0 Then
            MsgBox("当前大漠插件未能正常调用")
            Me.Close()
        Else

        End If
        '//////////////////////////////////////////////////////////////////


        '///////////////////檢查更新/////////////////////

        Dim VVer As New Ver("https://drive.google.com/uc?export=download&id=1vmgnpUqXpnt3u2xdu_dzMoBk_pM76CF7", "Ver")
        VVer.Ver()
        Select Case VVer.GetCheckConsequence '取得更新結果
            Case 0 '沒有更新
                Me.TopMost = True
                MsgBox("~目前是最新版本~" & vbCrLf & "此程式供免費使用" & vbCrLf & "切勿轉售" & vbCrLf & "使用任何輔助都有風險" & vbCrLf & "如使用此程式而被封鎖" & vbCrLf & "本人不負任何責任", MsgBoxStyle.Information)
            Case 1 '有更新
                Me.TopMost = True
                MsgBox("~有新版本！~" & vbCrLf & "目前版本號碼：" & VVer.GetMyVersion & vbCrLf & "最新版本號碼：" & VVer.GetCheckConsequenceNumber, MsgBoxStyle.Information)
                'MsgBox("可按最新版本下載 獲取下載網址")
                Dim ret1 = MsgBox("是否立即打開最新版本的下載頁面?", 4 + 32, "更新")
                If ret1 = 6 Then
                    Dim aaa As String = "http://w.eydata.net/a1a0b1d5d1229735"
                    Dim parameters1 As IDictionary(Of String, String) = New Dictionary(Of String, String)
                    parameters1.Add("0", 0)
                    Dim ret As String = WebPost.ApiPost(aaa, parameters1)
                    Process.Start(ret)
                Else
                    MsgBox("可按左上角的最新版本下載 打開下載網址", 0 + 64, "更新")
                End If
            Case 2 '更新失敗
                Me.TopMost = True
                MsgBox("獲取版本失敗！", MsgBoxStyle.Critical)

        End Select
        '//////////////////////////////////////////////////

        Label4.Text = "目前版本：" & VVer.GetMyVersion
        Label6.Text = "最新版本：" & VVer.GetCheckConsequenceNumber


        Dim RandomText As Integer
        Randomize()
        RandomText = Int((Rnd() * 999999999))
        Me.Text = Str(RandomText)
        dm = CreateObject("dm.dmsoft")
        hwnd = dm.FindWindow("", "Counter-Strike Online")
        dm.SetKeypadDelay("normal", 0)
        dm.SetKeypadDelay("windows", 0)
        dm.SetKeypadDelay("dx", 0)

        Dim parameters As IDictionary(Of String, String) = New Dictionary(Of String, String)
        ' 	退出登录(LogOut) url

        '////////////////////找cso視窗////////////////////////////
        If hwnd = 0 Then

            '//////////////不登入////////////////
            If GGGGG = 1 Then
            Else
                Dim url As String = "http://w.eydata.net/47d1f1eb475e5a05" '  这里改成自己的地址
                '  这里改成自己的参数名称
                parameters.Add("StatusCode", Me._statusCode)
                parameters.Add("UserName", Me._userName)
                If (WebPost.ApiPost(url, parameters) = "1") Then
                    ' 退出成功,清除本地状态码
                    OperateIniFile.WriteIniData("root", "code", "", "config.ini")
                Else
                    OperateIniFile.WriteIniData("root", "code", "", "config.ini")
                End If
            End If
            '/////////////////////////////////////

            MsgBox("CSO未開啟 !!")
            Shell("regsvr32 /u /s " & app & "\1.dll")
            Shell(Application.StartupPath & "\re.bat")
            End

        End If
        '/////////////////////////////////////////////////////////////

        '////////////////////////初始化////////////////////////

        dm.SetPath(Application.StartupPath)

        dm.SetDict(0, "a.txt")

        checkgame.Enabled = True

        runtime = 0
        runtimem = 0
        runtimeh = 0

        Me.Enabled = True

        dm.BindWindow(hwnd, "gdi2", "normal", "windows", 4)

        Me.TopMost = False

        Me.CenterToScreen()

        Show()

        dm.SetWindowState(hwnd, 5)

        AddKeyItem_LA(Key1)
        AddKeyItem_LA(Key2)
        AddKeyItem_LA(Key3)
        AddKeyItem_LA(Key4)
        AddKeyItem_LA(Key5)
        AddKeyItem_LA(Key6)
        AddKeyItem_LA(Key7)
        AddKeyItem_LA(Key8)
        AddKeyItem_LA(Key9)
        AddKeyItem_LA(Key10)
        AddKeyItem_LA(Key11)
        AddKeyItem_LA(Key12)
        AddKeyItem_LA(Key13)
        AddKeyItem_LA(Key14)



        AddKeyItem_LA2(ComboBox8)

        AddKeyItem_LA2(ComboBox11)
        AddKeyItem_LA2(ComboBox12)
        AddKeyItem_LA2(ComboBox13)
        AddKeyItem_LA2(ComboBox15)

        Thread1.Start() '蓋亞
        Thread2.Start() 'GS
        Thread3.Start() 'Desperado
        Thread4.Start() '湛盧BUG
        Thread5.Start() 'bj
        Thread6.Start() '極道滅殺
        Thread7.Start() 'SGS
        Thread8.Start() '後台掛機 / 掛災厄
        Thread9.Start() '瞬狙
        Thread10.Start() '刷槍
        Thread11.Start()

        'Thread99.Start() 'zombie


        Threadtime.Start()
        Me.ComboBox1.SelectedIndex = 0
        Me.ComboBox2.SelectedIndex = 0
        Me.ComboBox3.SelectedIndex = 0
        Me.ComboBox4.SelectedIndex = 0
        Me.ComboBox5.SelectedIndex = 0
        Me.ComboBox6.SelectedIndex = 0
        Me.ComboBox14.SelectedIndex = 0
        Me.ComboBox7.SelectedIndex = 0
        Me.ComboBox10.SelectedIndex = 0
        Me.ComboBox9.SelectedIndex = 0

        Me.刷槍1.SelectedIndex = 0



        ComboBox8.Text = "["

        'SetStyle(ControlStyles.UserPaint, True)
        'SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        'SetStyle(ControlStyles.DoubleBuffer, True)
        'SetStyle(ControlStyles.OptimizedDoubleBuffer, True)

        'TabControl1.DrawMode = TabDrawMode.OwnerDrawFixed
        'TabControl1.SizeMode = TabSizeMode.Fixed


        MenuStrip1.ForeColor = Color.Red
        MenuStrip1.Font = New Font("Microsoft JhengHei", 12.5F, FontStyle.Bold)
        'FromArgb(0, 188, 255)
        '////////////////////////////////////////////////////////////

        Dim UdMsg As String = OperateIniFile.ReadIniData("root", "udMsg", "", "config.ini")
        If (UdMsg = GetMyVersion3) Then

        Else
            updateInfo.Show()
        End If

        Form2.Show()

        Me.Text = System.Guid.NewGuid.ToString("N")

    End Sub
    '/////////////////////////////////////////////////////////////////////////


    Dim rndNum12345 As New Random()

    Dim _statusCode As String
    Dim _userName As String
    Dim upDateTime As Date

    Public Sub New(ByVal code As String, ByVal userName As String)

        Me._statusCode = code
        Me._userName = userName

        Me.upDateTime = DateTime.Now
        Me.InitializeComponent()

    End Sub


    Private Sub Form1_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        CheckBox8.CheckState = CheckState.Unchecked
        CheckBox21.CheckState = CheckState.Unchecked
        CheckBox28.CheckState = CheckState.Unchecked

        HotKeyPress.Enabled = False

        KeyOn1 = 0
        KeyOn2 = 0
        KeyOn3 = 0
        KeyOn4 = 0
        KeyOn5 = 0
        KeyOn6 = 0
        KeyOn7 = 0
        KeyOn8 = 0
        KeyOnF1 = 0
        KeyOnF2 = 0
        KeyOnF3 = 0
        KeyOnF4 = 0
        KeyOnF5 = 0
        KeyOnF6 = 0
        KeyOnF8 = 0
        chk_edit_on1.CheckState = CheckState.Unchecked
        chk_edit_on2.CheckState = CheckState.Unchecked
        chk_edit_on3.CheckState = CheckState.Unchecked
        chk_edit_on4.CheckState = CheckState.Unchecked
        chk_edit_on5.CheckState = CheckState.Unchecked

        dm.RightUp

        dm.LeftUp

        dm.KeyUpChar(cm8)


        If GGGGG = 1 Then
        Else
            Dim parameters As IDictionary(Of String, String) = New Dictionary(Of String, String)
            ' 	退出登录(LogOut) url
            Dim url As String = "http://w.eydata.net/47d1f1eb475e5a05" '  这里改成自己的地址
            '  这里改成自己的参数名称
            parameters.Add("StatusCode", Me._statusCode)
            parameters.Add("UserName", Me._userName)
            If (WebPost.ApiPost(url, parameters) = "1") Then
                ' 退出成功,清除本地状态码
                OperateIniFile.WriteIniData("root", "code", "", "config.ini")
            End If
        End If


        dm.SetWindowState(hwnd, 9)
        dm.SetWindowState(hwnd, 2)
        dm.SetWindowState(hwnd, 9)
        dm.UnBindWindow()

        Me.TopMost = True

        Dim app As String
        app = Application.StartupPath
        Shell("regsvr32 /u /s " & app & "\1.dll")

        Me.Hide()

        MsgBox("本次運作時間 : " & runtimeh & "時" & runtimem & "分" & runtime & "秒")

        Shell(Application.StartupPath & "\re.bat")

        End

    End Sub

    '=========================================================================================================================
    '=========================================================================================================================
    '=========================================================================================================================
    '=========================================================================================================================
    '=========================================================================================================================
    '=========================================================================================================================
    '=========================================================================================================================
    '=========================================================================================================================
    '=========================================================================================================================
    '=========================================================================================================================
    '=========================================================================================================================
    '     腳本
    '=========================================================================================================================

    '>>>>>>>>>>>>>>>>>>>>>蓋亞<<<<<<<<<<<<<<<<<<<
    Dim Thread1 As New Thread(AddressOf aa)
    Sub aa()
aa:
        If KeyOn1 = 1 Or KeyOnF1 = 1 Then
            If CheckBox1.CheckState = CheckState.Checked Then
                If 蓋亞 = "蓋亞" Then
                    dm.KeyDownChar(0)
                    dm.KeyUpChar(0)
                    dm.KeyDownChar("q")
                    dm.KeyDownChar(3)
                    dm.KeyUpChar("q")
                    dm.KeyUpChar(3)
                    dm.KeyDownChar(3)
                    MouseKey("R", "Down")
                    Threading.Thread.Sleep(time1)
                    MouseKey("R", "Up")
                    dm.KeyUpChar(3)
                    Threading.Thread.Sleep(time2)
                    GoTo aa
                End If
                If 蓋亞 = "刀戰蓋亞" Then
                    dm.KeyDownChar("j")
                    Threading.Thread.Sleep(time1 / 2)
                    dm.KeyUpChar("j")
                    Threading.Thread.Sleep(time1 / 2)
                    dm.KeyDownChar(3)
                    MouseKey("R", "Down")
                    Threading.Thread.Sleep(time2)
                    MouseKey("R", "Up")
                    dm.KeyUpChar(3)
                    GoTo aa
                End If
                If 蓋亞 = "蓋亞購買區" Then
                    dm.KeyPressChar("F2")
                    dm.KeyDownChar(3)
                    MouseKey("R", "Down")
                    Threading.Thread.Sleep(time1)
                    MouseKey("R", "Up")
                    dm.KeyUpChar(3)
                    Threading.Thread.Sleep(time2)
                    GoTo aa
                End If
            End If
        End If
        Threading.Thread.Sleep(time99456)
        GoTo aa
    End Sub
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<

    '>>>>>>>>>>>>>>>>>>>>>Desperado<<<<<<<<<<<<<<<<<<<
    Dim Thread3 As New Thread(AddressOf cc)
    Sub cc()
aa:
        If KeyOn3 = 1 Or KeyOnF3 = 1 Then
            If CheckBox3.CheckState = CheckState.Checked Then
                If Desperado = "Desperado左鍵" Then
                    MouseKey("L", "Down")
                    Threading.Thread.Sleep(time5)
                    MouseKey("L", "Up")
                    Threading.Thread.Sleep(time6 / 2)
                    MouseKey("R", "Down")
                    Threading.Thread.Sleep(time6 / 2)
                    MouseKey("R", "Up")
                    GoTo aa
                End If
                If Desperado = "Desperado右鍵" Then
                    MouseKey("R", "Down")
                    Threading.Thread.Sleep(time5)
                    MouseKey("R", "Up")
                    Threading.Thread.Sleep(time6 / 2)
                    MouseKey("L", "Down")
                    Threading.Thread.Sleep(time6 / 2)
                    MouseKey("L", "Up")
                    GoTo aa
                End If
                If Desperado = "Desperado左右鍵" Then
                    MouseKey("L", "Down")
                    Threading.Thread.Sleep(time5)
                    MouseKey("L", "Up")
                    Threading.Thread.Sleep(time6 / 2)
                    MouseKey("R", "Down")
                    Threading.Thread.Sleep(time5)
                    MouseKey("R", "Up")
                    Threading.Thread.Sleep(time6 / 2)
                    GoTo aa
                End If
            End If
        End If
        Threading.Thread.Sleep(time99456)
        GoTo aa
    End Sub
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<

    '>>>>>>>>>>>>>>>>>>>>>GS<<<<<<<<<<<<<<<<<<<
    Dim Thread2 As New Thread(AddressOf bb)
    Sub bb()
aa:
        If KeyOn2 = 1 Or KeyOnF2 = 1 Then
            If CheckBox2.CheckState = CheckState.Checked Then

                If GS123 = "有基因GS" Or GS123 = "無基因GS" Or GS123 = "有基因GS2" Or GS123 = "無基因GS2" Or GS123 = "通用GS" Then
                    dm.KeyDownChar("ctrl")
                    Threading.Thread.Sleep(time3)
                    dm.KeyUpChar("ctrl")
                    Threading.Thread.Sleep(time4)
                    GoTo aa
                End If

                If GS123 = "滾輪下有基因GS" Or GS123 = "滾輪下無基因GS" Then
                    Threading.Thread.Sleep(time3)
                    dm.WheelDown()
                    Threading.Thread.Sleep(time4)
                    GoTo aa
                End If

                If GS123 = "滾輪上有基因GS" Or GS123 = "滾輪上無基因GS" Then
                    Threading.Thread.Sleep(time3)
                    dm.WheelUp()
                    Threading.Thread.Sleep(time4)
                    GoTo aa
                End If

            End If
        End If
        Threading.Thread.Sleep(time99456)
        GoTo aa
    End Sub
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<

    '>>>>>>>>>>>>>>>>>>>>>SGS<<<<<<<<<<<<<<<<<<<
    Dim Thread7 As New Thread(AddressOf gg)
    Sub gg()
aa:
        If KeyOn6 = 1 Or KeyOnF6 = 1 Then
            If CheckBox7.CheckState = CheckState.Checked Then
                dm.KeyDownChar("ctrl")
                Threading.Thread.Sleep(time13)
                dm.KeyUpChar("ctrl")
                Threading.Thread.Sleep(time14)
                dm.KeyDownChar("ctrl")
                Threading.Thread.Sleep(time15)
                dm.KeyUpChar("ctrl")
                Threading.Thread.Sleep(time16)
                GoTo aa
            End If
        End If
        Threading.Thread.Sleep(time99456)
        GoTo aa
    End Sub
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<

    '>>>>>>>>>>>>>>>>>>>>>湛盧BUG<<<<<<<<<<<<<<<<<<<
    Dim Thread4 As New Thread(AddressOf dd)
    Sub dd()
aa:
        If KeyOn4 = 1 Or KeyOnF4 = 1 Then
            If CheckBox4.CheckState = CheckState.Checked Then
                If 湛盧BUG = "湛盧BUG+0連發" Then
                    MouseKey("R", "Down")
                    Threading.Thread.Sleep(5)
                    MouseKey("R", "Up")
                    MouseKey("L", "Down")
                    Threading.Thread.Sleep(time7)
                    MouseKey("L", "Up")
                    Threading.Thread.Sleep(time8)
f1gg:
                    MouseKey("R", "Down")

                    Threading.Thread.Sleep(time9)

                    MouseKey("R", "Up")

                    Threading.Thread.Sleep(time10)

                    If KeyOn4 = 0 And KeyOnF4 = 0 Then
                        GoTo aa
                    End If

                    GoTo f1gg
                End If
                If 湛盧BUG = "湛盧BUG+3連發" Then
                    MouseKey("R", "Down")
                    Threading.Thread.Sleep(5)
                    MouseKey("R", "Up")
                    MouseKey("L", "Down")
                    Threading.Thread.Sleep(time7)
                    MouseKey("L", "Up")
                    Threading.Thread.Sleep(time8)
f1ag:
                    MouseKey("R", "Down")

                    Threading.Thread.Sleep(time9)

                    MouseKey("R", "Up")

                    Threading.Thread.Sleep(time10)

                    If KeyOn4 = 0 And KeyOnF4 = 0 Then
                        GoTo aa
                    End If

                    GoTo f1ag
                End If
                GoTo aa
            End If
        End If
        Threading.Thread.Sleep(time99456)
        GoTo aa
    End Sub
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<

    'rb code
    Sub rbcode124()

        Dim rb512
        Dim fuck5123
        Dim shit4214
        Dim fkcso214

        rb512 = 45643
        fuck5123 = "12r45123423"
        shit4214 = 56413131536465136
        fkcso214 = 64586123148496

    End Sub

    '>>>>>>>>>>>>>>>>>>>>>極道滅殺<<<<<<<<<<<<<<<<<<<
    Dim Thread6 As New Thread(AddressOf ff)
    Sub ff()
aa:
        If KeyOn5 = 1 Or KeyOnF5 = 1 Then
            If CheckBox6.CheckState = CheckState.Checked Then
                If 極道滅殺 = "極道滅殺動作藍刀" Then
                    dm.KeyDownChar("j")
                    Threading.Thread.Sleep(time12 / 2)
                    dm.KeyUpChar("j")
                    Threading.Thread.Sleep(time12 / 2)
                    dm.KeyDownChar("3")
                    MouseKey("L", "Down")
                    Threading.Thread.Sleep(time11)
                    MouseKey("L", "Up")
                    dm.KeyUpChar("3")
                    GoTo aa
                End If
                If 極道滅殺 = "極道滅殺動作黃刀" Then
                    dm.KeyDownChar("j")
                    Threading.Thread.Sleep(time12 / 2)
                    dm.KeyUpChar("j")
                    Threading.Thread.Sleep(time12 / 2)
                    dm.KeyDownChar("3")
                    MouseKey("R", "Down")
                    Threading.Thread.Sleep(time11)
                    MouseKey("R", "Up")
                    dm.KeyUpChar("3")
                    GoTo aa
                End If
                If 極道滅殺 = "極道滅殺黃刀快砍" Then
                    dm.KeyDownChar("q")
                    dm.KeyUpChar("q")
                    dm.KeyDownChar("3")
                    MouseKey("R", "Down")
                    Threading.Thread.Sleep(time11)
                    MouseKey("R", "Up")
                    dm.KeyUpChar("3")
                    Threading.Thread.Sleep(time12)
                    GoTo aa
                End If
                If 極道滅殺 = "極道滅殺藍購買區" Then
                    dm.KeyDownChar("3")
                    MouseKey("L", "Down")
                    Threading.Thread.Sleep(time11)
                    MouseKey("L", "Up")
                    dm.KeyUpChar("3")
                    dm.KeyPressChar("F2")
                    Threading.Thread.Sleep(time12)
                    GoTo aa
                End If

                '極道滅殺藍購買區
            End If
        End If
        Threading.Thread.Sleep(time99456)
        GoTo aa
    End Sub
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<

    '>>>>>>>>>>>>>>>>>>>>>刷槍<<<<<<<<<<<<<<<<<<<
    Dim Thread10 As New Thread(AddressOf ii)
    Sub ii()
aa:
        If KeyOn8 = 1 Or KeyOnF8 = 1 Then
            If CheckBox10.CheckState = CheckState.Checked Then
                If 刷槍 = "洗槍左鍵(龍炮)" Then

                    MouseKey("L", "Down")
                    Threading.Thread.Sleep(time22)
                    MouseKey("L", "Up")
                    dm.KeyDownChar("g")
                    dm.KeyUpChar("g")
                    dm.KeyDownChar("f2")
                    Threading.Thread.Sleep(50)
                    dm.KeyUpChar("f2")
                    Threading.Thread.Sleep(time21)

                    GoTo aa
                End If
                If 刷槍 = "洗槍右鍵(轉輪)" Then

                    MouseKey("R", "Down")
                    Threading.Thread.Sleep(time22)
                    MouseKey("R", "Up")
                    dm.KeyDownChar("g")
                    dm.KeyUpChar("g")
                    dm.KeyDownChar("f2")
                    Threading.Thread.Sleep(50)
                    dm.KeyUpChar("f2")
                    Threading.Thread.Sleep(time21)

                    GoTo aa
                End If
            End If
        End If
        Threading.Thread.Sleep(time99456)
        GoTo aa
    End Sub
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<

    '>>>>>>>>>>>>>>>>>>>>>閃擊斯特恩<<<<<<<<<<<<<<<<<<<
    Dim Thread11 As New Thread(AddressOf ab)
    Sub ab()
aa:
        If KeyOn9 = 1 Or KeyOnF9 = 1 Then

            If CheckBox35.CheckState = CheckState.Checked Then

                dm.KeyDownChar("r")
                Threading.Thread.Sleep(閃t1)
                dm.KeyUpChar("r")
                Threading.Thread.Sleep(20)
                dm.KeyDownChar("q")
                dm.KeyUpChar("q")
                dm.KeyDownChar("1")
                dm.KeyUpChar("1")
                Threading.Thread.Sleep(閃t2)

                GoTo aa

            End If

        End If

        Threading.Thread.Sleep(time99456)
        GoTo aa
    End Sub
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<

    '>>>>>>>>>>>>>>>>>>>>>瞬狙<<<<<<<<<<<<<<<<<<<
    Dim Thread9 As New Thread(AddressOf kk)
    Sub kk()
aa:
        If KeyOn7 = 1 Then
            If CheckBox9.CheckState = CheckState.Checked Then
                MouseKey("R", "Down")
                Threading.Thread.Sleep(time19)
                MouseKey("R", "Up")
                MouseKey("L", "Down")
                Threading.Thread.Sleep(time20)
                MouseKey("L", "Up")
                dm.KeyDownChar("q")
                dm.KeyUpChar("q")
                dm.KeyDownChar("q")
                dm.KeyUpChar("q")
            End If
        End If
        Threading.Thread.Sleep(time99456)
        GoTo aa
    End Sub
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<

    '=========================================================================================================================
    '=========================================================================================================================
    '=========================================================================================================================
    '=========================================================================================================================

    '///////////////////////////////////////////////閃燈/////////////////////////////
    Private Sub CheckBox23_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox23.CheckedChanged
        If CheckBox23.CheckState = CheckState.Checked Then
            F.Enabled = True
        Else
            F.Enabled = False
        End If
    End Sub

    Private Sub F_Tick(sender As Object, e As EventArgs) Handles F.Tick
        F.Interval = TextBox17.Text
        If GetAsyncKeyState(Keys.F) <> 0 Then
            dm.KeyPressChar("F")
        End If
    End Sub
    '/////////////////////////////////////////////////////////////////////////////////////

    '///////////////////////////////////////////////連抽//////////////////////////////////////////
    Private Sub ttt_Tick(sender As Object, e As EventArgs) Handles ttt.Tick
        ttt.Interval = TextBox18.Text
        If CheckBox27.CheckState = CheckState.Checked Then
            If GetAsyncKeyState(Keys.Enter) <> 0 Then
                dm.LeftClick
            End If
        End If
    End Sub

    Private Sub CheckBox27_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox27.CheckedChanged
        If CheckBox27.CheckState = CheckState.Checked Then
            ttt.Enabled = True
        Else
            ttt.Enabled = False
        End If
    End Sub
    '////////////////////////////////////////////////////////////////////////////////////////////

    '///////////////////////////////////////////////////////透明化///////////////////////////////////////////////////
    Private Sub CheckBox26_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox26.CheckedChanged
        If CheckBox26.CheckState = CheckState.Checked Then
            Timer12.Enabled = True
        Else
            Timer12.Enabled = False
            dm.SetWindowTransparent(hwnd, 255)
        End If
    End Sub
    Private Sub Timer12_Tick(sender As Object, e As EventArgs) Handles Timer12.Tick
        Dim aaaff = TrackBar1
        dm.SetWindowTransparent(hwnd, aaaff)
    End Sub
    '//////////////////////////////////////////////////////////////////////////////////////////////////////

    '////////////////////////////////////////////////頂置CSO////////////////////////////////////////////////
    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged
        If CheckBox12.CheckState = CheckState.Checked Then
            dm.SetWindowState(hwnd, 8)
        Else
            dm.SetWindowState(hwnd, 9)
        End If
    End Sub
    '////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////頂置程式//////////////////////////////////////////////////
    Private Sub CheckBox13_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox13.CheckedChanged
        If CheckBox13.CheckState = CheckState.Checked Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub
    '/////////////////////////////////////////////////////////////////////////////////////////////////////////

    '///////////////////////////////////////jump///////////////////////////////////////////
    Dim Thread5 As New System.Threading.Thread(AddressOf ee)
    Sub ee()
aab:
        If CheckBox5.CheckState = CheckState.Unchecked Then
            Threading.Thread.Sleep(500)
            GoTo aab
        Else
a:
            If CheckBox5.CheckState = CheckState.Checked Then
                If GetAsyncKeyState(Keys.Space) <> 0 Then
                    dm.KeyPressChar("space")
                    Threading.Thread.Sleep(time18)
                End If
                If GetAsyncKeyState(Keys.Space) <> 0 Then
                    GoTo aab
                End If
                Threading.Thread.Sleep(time18)
                GoTo a
            End If
        End If
        Threading.Thread.Sleep(time99456)
        GoTo aab
    End Sub
    '////////////////////////////////////////////////////////////////////////

    '=========================================================================================================================
    '=========================================================================================================================
    '=========================================================================================================================
    '=========================================================================================================================
    '=========================================================================================================================
    '=========================================================================================================================
    '=========================================================================================================================
    '=========================================================================================================================
    '=========================================================================================================================
    '=========================================================================================================================
    '=========================================================================================================================
    '=========================================================================================================================
    '=========================================================================================================================
    '=========================================================================================================================

    '>>>>>>>>>>>>>>>>>>>>KeyPress<<<<<<<<<<<<<<<<<<<<'
    Private Sub Key_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Key7.KeyPress, Key6.KeyPress, Key5.KeyPress, Key4.KeyPress, Key3.KeyPress, Key2.KeyPress, Key1.KeyPress, ComboBox8.KeyPress, ComboBox15.KeyPress, ComboBox14.KeyPress, ComboBox13.KeyPress, ComboBox12.KeyPress, ComboBox11.KeyPress

        e.Handled = True

    End Sub
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<

    '////////////////////////////////////////////////
    '>>>>>>>>>>>>>>>>>>>>熱鍵<<<<<<<<<<<<<<<<<<<<'
    Private Sub HotKeyPress_Tick(sender As Object, e As EventArgs) Handles HotKeyPress.Tick
        HotKeyPress.Interval = timerv

        '>>>>>>>>>>>>>>>>>>>>蓋亞熱鍵<<<<<<<<<<<<<<<<<<<<'
        If Key1P.Checked Then
            OnOffCheck("Press", Key1.Text, "KeyOn1")
        End If
        If Key1O.Checked Then
            OnOffCheck("On", Key1.Text, "KeyOnF1")
        End If
        If Key1O.Checked Then
            OnOffCheck("Off", Key1.Text, "KeyOnF1")
        End If
        '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

        '>>>>>>>>>>>>>>>>>>>>GS熱鍵<<<<<<<<<<<<<<<<<<<<'
        If Key2P.Checked Then
            OnOffCheck2("Press", Key2.Text, "KeyOn2")
        End If
        If Key2O.Checked Then
            OnOffCheck2("On", Key2.Text, "KeyOnF2")
        End If
        If Key2O.Checked Then
            OnOffCheck2("Off", Key2.Text, "KeyOnF2")
        End If
        '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

        '>>>>>>>>>>>>>>>>>>>>Desperado熱鍵<<<<<<<<<<<<<<<<<<<<'
        If Key3P.Checked Then
            OnOffCheck3("Press", Key3.Text, "KeyOn3")
        End If
        If Key3O.Checked Then
            OnOffCheck3("On", Key3.Text, "KeyOnF3")
        End If
        If Key3O.Checked Then
            OnOffCheck3("Off", Key3.Text, "KeyOnF3")
        End If
        '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

        '>>>>>>>>>>>>>>>>>>>>湛盧BUG熱鍵<<<<<<<<<<<<<<<<<<<<'
        If Key4P.Checked Then
            OnOffCheck4("Press", Key4.Text, "KeyOn4")
        End If
        If Key4O.Checked Then
            OnOffCheck4("On", Key4.Text, "KeyOnF4")
        End If
        If Key4O.Checked Then
            OnOffCheck4("Off", Key4.Text, "KeyOnF4")
        End If
        '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

        '>>>>>>>>>>>>>>>>>>>>極道滅殺熱鍵<<<<<<<<<<<<<<<<<<<<'
        If Key5P.Checked Then
            OnOffCheck5("Press", Key5.Text, "KeyOn5")
        End If
        If Key5O.Checked Then
            OnOffCheck5("On", Key5.Text, "KeyOnF5")
        End If
        If Key5O.Checked Then
            OnOffCheck5("Off", Key5.Text, "KeyOnF5")
        End If
        '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

        '>>>>>>>>>>>>>>>>>>>>SGS熱鍵<<<<<<<<<<<<<<<<<<<<'
        If Key6P.Checked Then
            OnOffCheck6("Press", Key6.Text, "KeyOn6")
        End If
        If Key6O.Checked Then
            OnOffCheck6("On", Key6.Text, "KeyOnF6")
        End If
        If Key6O.Checked Then
            OnOffCheck6("Off", Key6.Text, "KeyOnF6")
        End If
        '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

        '>>>>>>>>>>>>>>>>>>>>刷槍熱鍵<<<<<<<<<<<<<<<<<<<<'
        If Key8P.Checked Then
            OnOffCheck8("Press", Key8.Text, "KeyOn8")
        End If
        If Key8O.Checked Then
            OnOffCheck8("On", Key8.Text, "KeyOnF8")
        End If
        If Key8O.Checked Then
            OnOffCheck8("Off", Key8.Text, "KeyOnF8")
        End If
        '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

        '>>>>>>>>>>>>>>>>>>>>閃擊斯特恩熱鍵<<<<<<<<<<<<<<<<<<<<'
        If Key9P.Checked Then
            OnOffCheck9("Press", Key9.Text, "KeyOn9")
        End If
        If Key9O.Checked Then
            OnOffCheck9("On", Key9.Text, "KeyOnF9")
        End If
        If Key9O.Checked Then
            OnOffCheck9("Off", Key9.Text, "KeyOnF9")
        End If
        '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

        '>>>>>>>>>>>>>>>>>>>>瞬狙熱鍵<<<<<<<<<<<<<<<<<<<<'
        OnOffCheck7("Press", Key7.Text, "KeyOn7")
        '//////////////////////////////////////////////////

        '>>>>>>>>>>>>>>>>>>>>edit1熱鍵<<<<<<<<<<<<<<<<<<<<'
        If Key10P.Checked Then
            OnOffCheck10("Press", Key10.Text, "KeyOn10")
        End If
        If Key10O.Checked Then
            OnOffCheck10("On", Key10.Text, "KeyOnF10")
        End If
        If Key10O.Checked Then
            OnOffCheck10("Off", Key10.Text, "KeyOnF10")
        End If
        '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

        '>>>>>>>>>>>>>>>>>>>>edit2熱鍵<<<<<<<<<<<<<<<<<<<<'
        If Key11P.Checked Then
            OnOffCheck11("Press", Key11.Text, "KeyOn11")
        End If
        If Key11O.Checked Then
            OnOffCheck11("On", Key11.Text, "KeyOnF11")
        End If
        If Key11O.Checked Then
            OnOffCheck11("Off", Key11.Text, "KeyOnF11")
        End If
        '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

        '>>>>>>>>>>>>>>>>>>>>edit3熱鍵<<<<<<<<<<<<<<<<<<<<'
        If Key12P.Checked Then
            OnOffCheck12("Press", Key12.Text, "KeyOn12")
        End If
        If Key12O.Checked Then
            OnOffCheck12("On", Key12.Text, "KeyOnF12")
        End If
        If Key12O.Checked Then
            OnOffCheck12("Off", Key12.Text, "KeyOnF12")
        End If
        '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

        '>>>>>>>>>>>>>>>>>>>>edit4熱鍵<<<<<<<<<<<<<<<<<<<<'
        If Key13P.Checked Then
            OnOffCheck13("Press", Key13.Text, "KeyOn13")
        End If
        If Key13O.Checked Then
            OnOffCheck13("On", Key13.Text, "KeyOnF13")
        End If
        If Key13O.Checked Then
            OnOffCheck13("Off", Key13.Text, "KeyOnF13")
        End If
        '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

        '>>>>>>>>>>>>>>>>>>>>edit5熱鍵<<<<<<<<<<<<<<<<<<<<'
        If Key14P.Checked Then
            OnOffCheck14("Press", Key14.Text, "KeyOn14")
        End If
        If Key14O.Checked Then
            OnOffCheck14("On", Key14.Text, "KeyOnF14")
        End If
        If Key14O.Checked Then
            OnOffCheck14("Off", Key14.Text, "KeyOnF14")
        End If
        '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'


        If GetAsyncKeyState(Keys.ControlKey) <> 0 And GetAsyncKeyState(Keys.F12) <> 0 Then
            dm.SetWindowState(hwnd, 1)
            dm.BindWindow(hwnd, "gdi2", "dx", "dx", 4)
            CheckBox21.Enabled = True
            Button6.Enabled = False
            modee = 1
            mode1.Enabled = False
            mode2.Enabled = False
            CheckBox21.Enabled = True
            CheckBox20.Enabled = True
            CheckBox19.Enabled = True
            CheckBox18.Enabled = True
            CheckBox30.Enabled = True
            CheckBox17.Enabled = True
            CheckBox16.Enabled = True
            CheckBox15.Enabled = True
            CheckBox14.Enabled = True
        End If

        If GetAsyncKeyState(Keys.F11) <> 0 And GetAsyncKeyState(Keys.F12) <> 0 Then
            CheckBox21.CheckState = CheckState.Unchecked
        End If

        If GetAsyncKeyState(Keys.ControlKey) <> 0 And GetAsyncKeyState(Keys.F11) <> 0 Then
            CheckBox21.CheckState = CheckState.Unchecked
            If mode1.Checked Then
                dm.BindWindow(hwnd, "gdi2", "normal", "windows", 4)
            End If
            If mode2.Checked Then
                dm.BindWindow(hwnd, "gdi2", "windows", "windows", 4)
            End If
            dm.KeyUpChar("w")
            dm.KeyUpChar("right")
            Button6.Enabled = True
            CheckBox21.Enabled = False
            CheckBox21.CheckState = False
            modee = 0
            mode1.Enabled = True
            mode2.Enabled = True
            CheckBox21.Enabled = False
            CheckBox20.Enabled = False
            CheckBox19.Enabled = False
            CheckBox18.Enabled = False
            CheckBox17.Enabled = False
            CheckBox16.Enabled = False
            CheckBox15.Enabled = False
            CheckBox14.Enabled = False
            CheckBox30.Enabled = False
            CheckBox21.CheckState = False
            CheckBox20.CheckState = False
            CheckBox19.CheckState = False
            CheckBox18.CheckState = False
            CheckBox30.CheckState = False
            CheckBox17.CheckState = False
            CheckBox16.CheckState = False
            CheckBox15.CheckState = False
            CheckBox14.CheckState = False
        End If

    End Sub
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'
    '/////////////////////////////////////////////////

    '>>>>>>>>>>>>>>>>>>>>變數<<<<<<<<<<<<<<<<<<<<'
    Private Sub Vvv_Tick(sender As Object, e As EventArgs) Handles Vvv.Tick

        Vvv.Interval = timerv2

        If TextBox1.TextLength = 0 Then
            TextBox1.Text = 0
        End If
        If TextBox2.TextLength = 0 Then
            TextBox2.Text = 0
        End If
        If TextBox3.TextLength = 0 Then
            TextBox3.Text = 0
        End If
        If TextBox4.TextLength = 0 Then
            TextBox4.Text = 0
        End If
        If TextBox5.TextLength = 0 Then
            TextBox5.Text = 0
        End If
        If TextBox6.TextLength = 0 Then
            TextBox6.Text = 0
        End If
        If TextBox7.TextLength = 0 Then
            TextBox7.Text = 0
        End If
        If TextBox8.TextLength = 0 Then
            TextBox8.Text = 0
        End If
        If TextBox9.TextLength = 0 Then
            TextBox9.Text = 0
        End If
        If TextBox10.TextLength = 0 Then
            TextBox10.Text = 0
        End If
        If TextBox11.TextLength = 0 Then
            TextBox11.Text = 0
        End If
        If TextBox12.TextLength = 0 Then
            TextBox12.Text = 0
        End If
        If TextBox13.TextLength = 0 Then
            TextBox13.Text = 0
        End If
        If TextBox14.TextLength = 0 Then
            TextBox14.Text = 0
        End If
        If TextBox15.TextLength = 0 Then
            TextBox15.Text = 0
        End If
        If TextBox16.TextLength = 0 Then
            TextBox16.Text = 0
        End If
        If TextBox17.TextLength = 0 Then
            TextBox17.Text = 0
        End If
        If TextBox18.TextLength = 0 Then
            TextBox18.Text = 0
        End If
        If TextBox19.TextLength = 0 Then
            TextBox19.Text = 0
        End If
        If TextBox20.TextLength = 0 Then
            TextBox20.Text = 0
        End If
        time1 = TextBox1.Text
        time2 = TextBox2.Text
        time3 = TextBox4.Text
        time4 = TextBox3.Text
        time5 = TextBox6.Text
        time6 = TextBox5.Text
        time7 = TextBox8.Text
        time8 = TextBox7.Text
        time9 = TextBox10.Text
        time10 = TextBox9.Text
        time11 = TextBox12.Text
        time12 = TextBox11.Text
        time13 = TextBox14.Text
        time14 = TextBox13.Text
        time15 = TextBox16.Text
        time16 = TextBox15.Text
        time17 = TextBox19.Text
        time18 = TextBox20.Text
        time19 = TextBox22.Text
        time20 = TextBox21.Text
        time21 = TextBox24.Text
        time22 = TextBox23.Text
        timerv = TrackBar2.Value
        timerv2 = TrackBar3.Value
        cm7 = ComboBox7.Text
        cm8 = ComboBox8.Text
        蓋亞 = ComboBox1.Text
        qwe = ComboBox14.Text
        Desperado = ComboBox2.Text
        湛盧BUG = ComboBox3.Text
        極道滅殺 = ComboBox4.Text
        刷槍 = 刷槍1.Text
        GS123 = ComboBox5.Text
        閃t1 = txt閃t1.Text
        閃t2 = txt閃t2.Text
        人物 = ComboBox9.Text
        買武器 = ComboBox10.Text


        mkey3 = ComboBox11.Text
        mkey4 = ComboBox12.Text
        mkey5 = ComboBox13.Text
        mkey6 = ComboBox15.Text

        If modee = 1 Then
            mode = 3
        Else
            If mode1.Checked Then
                mode = 1
            End If
            If mode2.Checked Then
                mode = 2
            End If
        End If
        If mode = 1 Then
            Label15.Text = "模式:前台"
        End If
        If mode = 2 Then
            Label15.Text = "模式:後台"
        End If
        If mode = 3 Then
            Label15.Text = "後台掛機"
        End If

    End Sub
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    'rb code
    Sub rbcode()

        Dim rb
        Dim fuck
        Dim shit
        Dim fkcso

        rb = 915643
        fuck = "awd4165"
        shit = "894wafaw321"
        fkcso = 153498643213

    End Sub

    '>>>>>>>>>>>>>>>>>>>>OnlyNumber<<<<<<<<<<<<<<<<<<<<'
    Private Sub txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox9.KeyPress, TextBox8.KeyPress, TextBox7.KeyPress, TextBox6.KeyPress, TextBox5.KeyPress, TextBox4.KeyPress, TextBox3.KeyPress, TextBox29.KeyPress, TextBox28.KeyPress, TextBox27.KeyPress, TextBox26.KeyPress, TextBox25.KeyPress, TextBox20.KeyPress, TextBox2.KeyPress, TextBox18.KeyPress, TextBox17.KeyPress, TextBox16.KeyPress, TextBox15.KeyPress, TextBox14.KeyPress, TextBox13.KeyPress, TextBox12.KeyPress, TextBox11.KeyPress, TextBox10.KeyPress, TextBox1.KeyPress
        OnlyNumber_LA(e)
    End Sub
    Private Sub txt_KeyPress1(ByVal sender As Object, ByVal e1 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If (TextBox1.Text.IndexOf(".") >= 0 And e1.KeyChar = ".") Then e1.Handled = True
    End Sub
    Private Sub txt_KeyPress2(ByVal sender As Object, ByVal e2 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If (TextBox2.Text.IndexOf(".") >= 0 And e2.KeyChar = ".") Then e2.Handled = True
    End Sub
    Private Sub txt_KeyPress3(ByVal sender As Object, ByVal e3 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If (TextBox3.Text.IndexOf(".") >= 0 And e3.KeyChar = ".") Then e3.Handled = True
    End Sub
    Private Sub txt_KeyPress4(ByVal sender As Object, ByVal e4 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If (TextBox4.Text.IndexOf(".") >= 0 And e4.KeyChar = ".") Then e4.Handled = True
    End Sub
    Private Sub txt_KeyPress5(ByVal sender As Object, ByVal e5 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If (TextBox5.Text.IndexOf(".") >= 0 And e5.KeyChar = ".") Then e5.Handled = True
    End Sub
    Private Sub txt_KeyPress6(ByVal sender As Object, ByVal e6 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If (TextBox6.Text.IndexOf(".") >= 0 And e6.KeyChar = ".") Then e6.Handled = True
    End Sub
    Private Sub txt_KeyPress7(ByVal sender As Object, ByVal e7 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        If (TextBox7.Text.IndexOf(".") >= 0 And e7.KeyChar = ".") Then e7.Handled = True
    End Sub
    Private Sub txt_KeyPress8(ByVal sender As Object, ByVal e8 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox8.KeyPress
        If (TextBox8.Text.IndexOf(".") >= 0 And e8.KeyChar = ".") Then e8.Handled = True
    End Sub
    Private Sub txt_KeyPress9(ByVal sender As Object, ByVal e9 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox9.KeyPress
        If (TextBox9.Text.IndexOf(".") >= 0 And e9.KeyChar = ".") Then e9.Handled = True
    End Sub
    Private Sub txt_KeyPress10(ByVal sender As Object, ByVal e10 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox10.KeyPress
        If (TextBox10.Text.IndexOf(".") >= 0 And e10.KeyChar = ".") Then e10.Handled = True
    End Sub
    Private Sub txt_KeyPress11(ByVal sender As Object, ByVal e11 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox11.KeyPress
        If (TextBox11.Text.IndexOf(".") >= 0 And e11.KeyChar = ".") Then e11.Handled = True
    End Sub
    Private Sub txt_KeyPress12(ByVal sender As Object, ByVal e12 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox12.KeyPress
        If (TextBox12.Text.IndexOf(".") >= 0 And e12.KeyChar = ".") Then e12.Handled = True
    End Sub
    Private Sub txt_KeyPress13(ByVal sender As Object, ByVal e13 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox13.KeyPress
        If (TextBox13.Text.IndexOf(".") >= 0 And e13.KeyChar = ".") Then e13.Handled = True
    End Sub
    Private Sub txt_KeyPress14(ByVal sender As Object, ByVal e14 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox14.KeyPress
        If (TextBox14.Text.IndexOf(".") >= 0 And e14.KeyChar = ".") Then e14.Handled = True
    End Sub
    Private Sub txt_KeyPress15(ByVal sender As Object, ByVal e15 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox15.KeyPress
        If (TextBox15.Text.IndexOf(".") >= 0 And e15.KeyChar = ".") Then e15.Handled = True
    End Sub
    Private Sub txt_KeyPress16(ByVal sender As Object, ByVal e16 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox16.KeyPress
        If (TextBox16.Text.IndexOf(".") >= 0 And e16.KeyChar = ".") Then e16.Handled = True
    End Sub
    Private Sub txt_KeyPress17(ByVal sender As Object, ByVal e17 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox17.KeyPress
        If (TextBox17.Text.IndexOf(".") >= 0 And e17.KeyChar = ".") Then e17.Handled = True
    End Sub
    Private Sub txt_KeyPress18(ByVal sender As Object, ByVal e18 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox18.KeyPress
        If (TextBox18.Text.IndexOf(".") >= 0 And e18.KeyChar = ".") Then e18.Handled = True
    End Sub
    Private Sub txt_KeyPress19(ByVal sender As Object, ByVal e19 As System.Windows.Forms.KeyPressEventArgs)
        If (TextBox19.Text.IndexOf(".") >= 0 And e19.KeyChar = ".") Then e19.Handled = True
    End Sub
    Private Sub txt_KeyPress20(ByVal sender As Object, ByVal e20 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox20.KeyPress
        If (TextBox20.Text.IndexOf(".") >= 0 And e20.KeyChar = ".") Then e20.Handled = True
    End Sub
    Private Sub txt_KeyPress25(ByVal sender As Object, ByVal e25 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox25.KeyPress
        If (TextBox21.Text.IndexOf(".") >= 0 And e25.KeyChar = ".") Then e25.Handled = True
    End Sub
    Private Sub txt_KeyPress26(ByVal sender As Object, ByVal e26 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox26.KeyPress
        If (TextBox22.Text.IndexOf(".") >= 0 And e26.KeyChar = ".") Then e26.Handled = True
    End Sub
    Private Sub txt_KeyPress27(ByVal sender As Object, ByVal e27 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox27.KeyPress
        If (TextBox23.Text.IndexOf(".") >= 0 And e27.KeyChar = ".") Then e27.Handled = True
    End Sub
    Private Sub txt_KeyPress28(ByVal sender As Object, ByVal e28 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox28.KeyPress
        If (TextBox24.Text.IndexOf(".") >= 0 And e28.KeyChar = ".") Then e28.Handled = True
    End Sub
    Private Sub txt_KeyPress29(ByVal sender As Object, ByVal e29 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox29.KeyPress
        If (TextBox25.Text.IndexOf(".") >= 0 And e29.KeyChar = ".") Then e29.Handled = True
    End Sub
    Private Sub txt_KeyPress30(ByVal sender As Object, ByVal e30 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox29.KeyPress
        If (txt閃t1.Text.IndexOf(".") >= 0 And e30.KeyChar = ".") Then e30.Handled = True
    End Sub
    Private Sub txt_KeyPress31(ByVal sender As Object, ByVal e31 As System.Windows.Forms.KeyPressEventArgs) Handles TextBox29.KeyPress
        If (txt閃t2.Text.IndexOf(".") >= 0 And e31.KeyChar = ".") Then e31.Handled = True
    End Sub

    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'


    '>>>>>>>>>>>>>>>>>>>>熱鍵偵測速度<<<<<<<<<<<<<<<<<<<<'
    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        Label2.Text = TrackBar2.Value & "豪秒"
        timerv = TrackBar2.Value
    End Sub
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    '>>>>>>>>>>>>>>>>>>>>變數更新速度<<<<<<<<<<<<<<<<<<<<'
    Private Sub TrackBar3_Scroll(sender As Object, e As EventArgs) Handles TrackBar3.Scroll
        Label9.Text = TrackBar3.Value & "豪秒"
        timerv2 = TrackBar3.Value
    End Sub
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    Dim endtime1 As Integer = 0

    Sub stop123()

        CheckBox8.CheckState = CheckState.Unchecked
        CheckBox21.CheckState = CheckState.Unchecked
        CheckBox28.CheckState = CheckState.Unchecked

        KeyOn1 = 0
        KeyOn2 = 0
        KeyOn3 = 0
        KeyOn4 = 0
        KeyOn5 = 0
        KeyOn6 = 0
        KeyOn7 = 0
        KeyOn8 = 0
        KeyOnF1 = 0
        KeyOnF2 = 0
        KeyOnF3 = 0
        KeyOnF4 = 0
        KeyOnF5 = 0
        KeyOnF6 = 0
        KeyOnF8 = 0

        dm.RightUp

        dm.LeftUp

        dm.KeyUpChar(cm8)
    End Sub

    '>>>>>>>>>>>>>>>>>>>>關閉熱鍵偵測<<<<<<<<<<<<<<<<<<<<'
    Private Sub EndCheck_Tick(sender As Object, e As EventArgs) Handles EndCheck.Tick
        If GetAsyncKeyState(Keys.F9) <> 0 And GetAsyncKeyState(Keys.F10) <> 0 Then

            endtime1 += 1

            If endtime1 > 0 Then
                stop123()
            End If

            Label5.Text = "程式關閉計時 : " & endtime1

            If endtime1 = 10 Then

                EndCheck.Enabled = False

                CheckBox8.CheckState = CheckState.Unchecked
                CheckBox21.CheckState = CheckState.Unchecked
                CheckBox28.CheckState = CheckState.Unchecked

                HotKeyPress.Enabled = False

                KeyOn1 = 0
                KeyOn2 = 0
                KeyOn3 = 0
                KeyOn4 = 0
                KeyOn5 = 0
                KeyOn6 = 0
                KeyOn7 = 0
                KeyOn8 = 0
                KeyOnF1 = 0
                KeyOnF2 = 0
                KeyOnF3 = 0
                KeyOnF4 = 0
                KeyOnF5 = 0
                KeyOnF6 = 0
                KeyOnF8 = 0

                dm.RightUp

                dm.LeftUp

                dm.KeyUpChar(cm8)

                Me.Close()

            End If
        Else
            endtime1 = 0
            Label5.Text = "按住F9+F10關閉"
        End If


        timeim = rndNum12345.Next(300, 500)


    End Sub
    '>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<'

    '//////////////////////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////RandomText//////////////////////////////////////////////////////
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub RandomText_Tick(sender As Object, e As EventArgs) Handles RandomText.Tick

        Me.Text = System.Guid.NewGuid.ToString("N")

    End Sub

    Private Function RandonInt(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim iRnd As Integer

        Randomize()
        iRnd = CInt(Int((Max - Min + 1) * Rnd()))
        Return iRnd + Min
    End Function

    ''' <summary> 
    ''' 取得亂數字串。 
    ''' </summary> 
    ''' <param name="Format">字串格式化。A: 表示大寫英文字母; a: 表示小寫英文字母; 1: 表示數字。</param> 
    Private Function RandonStr(ByVal Format As String) As String
        Dim N1 As Integer
        Dim sText As String
        Dim sChar As String
        Dim iCharCode As Integer

        sText = String.Empty
        For N1 = 0 To Format.Length - 1
            sChar = Format.Substring(N1, 1)
            If sChar = "A" Then
                'A-Z 的 ASCII 是 65-90 
                iCharCode = RandonInt(65, 90)
            ElseIf sChar = "a" Then
                'a-z 的 ASCII 是 97-122 
                iCharCode = RandonInt(97, 122)
            ElseIf sChar = "1" Then
                '0-9 的 ASCII 是 48-57 
                iCharCode = RandonInt(48, 57)
            End If
            sText = sText + Chr(iCharCode)
        Next
        Return sText
    End Function
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////

    '//////////////////////////////////////checkgame////////////////////////////////

    Dim r = 0
    Dim checkCount = 0
    Dim checkHwnd

    Private Sub checkgame_Tick(sender As Object, e As EventArgs) Handles checkgame.Tick

        If CheckBox29.CheckState = CheckState.Checked Then
            checkHwnd = dm.GetWindowState(hwnd, 0)
            If checkHwnd = 0 Then
                checkCount += 1
            Else
                checkCount = 0
            End If
            If checkCount >= 2 Then
                checkgame.Enabled = False
                Me.Close()
            End If
        End If

        Label31.Text = runtimeh & "時" & runtimem & "分" & runtime & "秒"

    End Sub
    '////////////////////////////////////////////////////////////////////////////////////

    '//////////////////////////////後台按鍵設定/////////////////////////////////////
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form21.Show()
    End Sub
    '////////////////////////////////////////////////////////////////////////////////////

    '///////////////////////////////////後台Bind設定/////////////////////////////////////
    Private Sub mode_Checked(sender As Object, e As EventArgs) Handles mode2.CheckedChanged
        If mode1.Checked Then
            dm.BindWindow(hwnd, "gdi2", "normal", "windows", 4)
        End If
        If mode2.Checked Then
            dm.BindWindow(hwnd, "gdi2", "windows", "windows", 4)
        End If
    End Sub
    '//////////////////////////////////////////////////////////////////////////////////

    '///////////////////////////////////////////Menu///////////////////////////////////////////

    Private Sub 最新版本下載ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 最新版本下載ToolStripMenuItem.Click
        Dim aaa As String = "http://w.eydata.net/a1a0b1d5d1229735"
        Dim parameters As IDictionary(Of String, String) = New Dictionary(Of String, String)
        parameters.Add("0", 0)
        Dim ret As String = WebPost.ApiPost(aaa, parameters)
        Process.Start(ret)
    End Sub
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////

    '/////////////////////////////////////////ComboBox/////////////////////////////////////////////
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If 湛盧BUG = "湛盧BUG+0連發" Then
            TextBox8.Text = 2380
            TextBox7.Text = 300
            TextBox10.Text = 200
            TextBox9.Text = 320
        End If
        If 湛盧BUG = "湛盧BUG+3連發" Then
            TextBox8.Text = 2390
            TextBox7.Text = 300
            TextBox10.Text = 160
            TextBox9.Text = 280
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If 蓋亞 = "蓋亞" Then
            TextBox1.Text = 370
            TextBox2.Text = 280
        End If
        If 蓋亞 = "刀戰蓋亞" Then
            TextBox1.Text = 370
            TextBox2.Text = 280
        End If
        If 蓋亞 = "蓋亞購買區" Then
            TextBox1.Text = 500
            TextBox2.Text = 50
        End If
    End Sub
    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        If 極道滅殺 = "極道滅殺動作藍刀" Then
            TextBox12.Text = 660
            TextBox11.Text = 200
        End If
        If 極道滅殺 = "極道滅殺動作黃刀" Then
            TextBox12.Text = 460
            TextBox11.Text = 200
        End If
        If 極道滅殺 = "極道滅殺黃刀快砍" Then
            TextBox12.Text = 200
            TextBox11.Text = 20
        End If
        If 極道滅殺 = "極道滅殺藍購買區" Then
            TextBox12.Text = 700
            TextBox11.Text = 20
        End If
    End Sub
    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        '滾輪下GS
        If ComboBox5.Text = "滾輪下有基因GS" Then
            TextBox4.Text = 0
            TextBox3.Text = 242
        End If
        If ComboBox5.Text = "滾輪下無基因GS" Then
            TextBox4.Text = 0
            TextBox3.Text = 221
        End If
        If ComboBox5.Text = "滾輪上有基因GS" Then
            TextBox4.Text = 0
            TextBox3.Text = 242
        End If
        If ComboBox5.Text = "滾輪上無基因GS" Then
            TextBox4.Text = 0
            TextBox3.Text = 221
        End If
        If ComboBox5.Text = "有基因GS" Then
            TextBox4.Text = 0
            TextBox3.Text = 242
        End If
        If ComboBox5.Text = "無基因GS" Then
            TextBox4.Text = 0
            TextBox3.Text = 221
        End If
        If ComboBox5.Text = "有基因GS2" Then
            TextBox4.Text = 10
            TextBox3.Text = 232
        End If
        If ComboBox5.Text = "無基因GS2" Then
            TextBox4.Text = 10
            TextBox3.Text = 211
        End If
        If ComboBox5.Text = "通用GS" Then
            TextBox4.Text = 10
            TextBox3.Text = 40
        End If
    End Sub
    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        If ComboBox6.Text = "有基因SGS" Then
            TextBox14.Text = 10
            TextBox13.Text = 50
            TextBox16.Text = 200
            TextBox15.Text = 100
        End If
        If ComboBox6.Text = "無基因SGS" Then
            TextBox14.Text = 10
            TextBox13.Text = 50
            TextBox16.Text = 200
            TextBox15.Text = 70
        End If
        If ComboBox6.Text = "通用SGS" Then
            TextBox14.Text = 10
            TextBox13.Text = 50
            TextBox16.Text = 50
            TextBox15.Text = 50
        End If
    End Sub
    '////////////////////////////////////////////////////////////////////////////////////////////////////
    '/////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////


    '////////////////////////////////////////登入人數////////////////////////////////////
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim aasddd As String = "http://w.eydata.net/77613e36e3e154b8" ' 这里改成自己的地址
        Dim parameters As IDictionary(Of String, String) = New Dictionary(Of String, String)
        '  这里改成自己的参数名称
        parameters.Add("UserName", Me._userName)
        parameters.Add("Type", 3)
        Dim ret As String = WebPost.ApiPost(aasddd, parameters)
        Label13.Text = ret
    End Sub
    '//////////////////////////////////////////////////////////////////////////////////////

    '//////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////////////////////////////////////////////
    '/////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////後台掛機 / 掛災厄///////////////
    '鎖定
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Vvv.Interval = 5000
        HotKeyPress.Interval = 500
        EndCheck.Interval = 500

        time99456 = 10000

        dm.SetWindowState(hwnd, 1)
        dm.BindWindow(hwnd, "gdi2", "dx", "dx", 4)
        CheckBox21.Enabled = True
        Button6.Enabled = False
        modee = 1
        mode1.Enabled = False
        mode2.Enabled = False
        CheckBox21.Enabled = True
        CheckBox20.Enabled = True
        CheckBox19.Enabled = True
        CheckBox18.Enabled = True
        afkKey.Enabled = True

        狀態.Enabled = True
    End Sub

    '解鎖
    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Vvv.Interval = 200
        HotKeyPress.Interval = 100
        EndCheck.Interval = 100

        time99456 = 200

        If mode1.Checked Then
            dm.BindWindow(hwnd, "gdi2", "normal", "windows", 4)
        End If
        If mode2.Checked Then
            dm.BindWindow(hwnd, "gdi2", "windows", "windows", 4)
        End If
        dm.KeyUpChar("w")
        dm.KeyUpChar("right")
        Button6.Enabled = True
        CheckBox21.Enabled = False
        CheckBox21.CheckState = False
        modee = 0
        mode1.Enabled = True
        mode2.Enabled = True
        CheckBox21.Enabled = False
        CheckBox20.Enabled = False
        CheckBox19.Enabled = False
        CheckBox18.Enabled = False
        afkKey.Enabled = False

        CheckBox21.CheckState = False
        CheckBox20.CheckState = False
        CheckBox19.CheckState = False
        CheckBox18.CheckState = False
        CheckBox30.CheckState = False

        狀態.Enabled = False
    End Sub
    '護甲位置
    Private Sub ComboBox14_SelectedIndexChanged(sender As Object, e As EventArgs)
        qwe = ComboBox14.Text
    End Sub

    Sub SSSss()
        Dim x
        Dim y
        dm.FindColor(650, 620, 870, 680, "7d4c00-000000", 0.95, 3, x, y)
        If x >= 0 And y >= 0 Then
            dm.MoveTo(x, y)
            Threading.Thread.Sleep(100)
            LeftClick()
            Threading.Thread.Sleep(100)
        End If
    End Sub


    Dim hhh = 0
    '>>>>>>>>>>>>>>>>>>>>>自動開始/結算<<<<<<<<<<<<<<<<<<<
    Dim Thread8 As New Thread(AddressOf hh)
    Sub hh()
aa:
        If CheckBox21.CheckState = CheckState.Unchecked Then
            If hhh = 1 Then
                dm.KeyUpChar("h")
                dm.KeyUpChar("alt")
                hhh = 0
            End If
        End If
        If CheckBox30.CheckState = CheckState.Unchecked Then

            room狀態 = "遊戲中"

            If CheckBox21.CheckState = CheckState.Checked Then
                '////////////////////////////////////////////////////////////

                If CheckBox31.CheckState = CheckState.Checked Then
                    Dim dmret3 = dm.GetWindowState(hwnd, 6)
                    If dmret3 = 1 Then
                        Threading.Thread.Sleep(1000)
                        GoTo aa
                    End If
                End If

                If CheckBox28.CheckState = CheckState.Checked Then dm.KeyUpChar(cm8)

                att()

                If CheckBox24.CheckState = CheckState.Checked Then
                    dm.KeyDownChar("h")
                    dm.KeyDownChar("alt")
                    hhh = 1
                End If

                att()

                Threading.Thread.Sleep(100)
                If CheckBox17.CheckState = CheckState.Checked Then
                    購買護甲()
                End If

                Threading.Thread.Sleep(100)
                dm.MoveTo(927, 540)

                If CheckBox24.CheckState = CheckState.Unchecked Then
                    dm.KeyPressChar("0")
                    If CheckBox50.Checked Then dm.KeyPressChar("g")
                End If

                att()

                If CheckBox24.CheckState = CheckState.Checked Then

                    dm.KeyDownChar("h")
                    hhh = 1
                    dm.KeyPressChar("0")
                End If

                Threading.Thread.Sleep(100)
                LeftClick()

                att()

                Threading.Thread.Sleep(100)
                dm.MoveTo(705, 620)
                Threading.Thread.Sleep(100)
                LeftClick()

                att()

                If CheckBox24.CheckState = CheckState.Checked Then
                    Threading.Thread.Sleep(100)
                    dm.MoveTo(510, 420)
                    Threading.Thread.Sleep(100)
                    LeftClick()

                    dm.KeyPressChar("0")
                End If

                att()

                Threading.Thread.Sleep(100)
                dm.MoveTo(620, 570)

                att()

                Threading.Thread.Sleep(100)
                LeftClick()
                Threading.Thread.Sleep(100)

                att()

                If CheckBox24.CheckState = CheckState.Checked Then

                    dm.KeyDownChar("h")
                    hhh = 1

                    dm.KeyPressChar("0")
                End If

                att()

                If CheckBox24.CheckState = CheckState.Unchecked Then
                    dm.KeyPressChar("0")
                    If CheckBox50.Checked Then dm.KeyPressChar("g")
                End If

                dm.MoveTo(200, 650)
                Threading.Thread.Sleep(100)
                LeftClick()
                Threading.Thread.Sleep(100)

                dm.MoveTo(643, 606)
                Threading.Thread.Sleep(100)
                LeftClick()
                Threading.Thread.Sleep(100)

                att()

                If CheckBox16.CheckState = CheckState.Checked Then
                    dm.KeyPressChar("5")
                End If
                If CheckBox15.CheckState = CheckState.Checked Then
                    dm.KeyPressChar("6")
                End If
                If CheckBox14.CheckState = CheckState.Checked Then
                    dm.KeyPressChar("R")
                End If

                If CheckBox24.CheckState = CheckState.Checked Then

                    dm.KeyDownChar("h")
                    hhh = 1

                    dm.KeyPressChar("0")
                End If

                att()


                If CheckBox17.CheckState = CheckState.Checked Then
                    購買護甲()
                End If

                If CheckBox18.CheckState = CheckState.Checked Then
                    dm.MoveTo(985, 210)
                    Threading.Thread.Sleep(50)
                    LeftClick()
                    Threading.Thread.Sleep(50)
                    dm.MoveTo(985, 230)
                    Threading.Thread.Sleep(50)
                    LeftClick()
                    Threading.Thread.Sleep(50)
                    dm.MoveTo(985, 250)
                    Threading.Thread.Sleep(50)
                    LeftClick()
                    Threading.Thread.Sleep(50)
                    dm.MoveTo(985, 270)
                    Threading.Thread.Sleep(50)
                    LeftClick()
                    Threading.Thread.Sleep(50)
                    dm.MoveTo(985, 290)
                    Threading.Thread.Sleep(50)
                    LeftClick()
                    Threading.Thread.Sleep(50)
                    dm.MoveTo(985, 310)
                    Threading.Thread.Sleep(50)
                    LeftClick()
                    Threading.Thread.Sleep(50)
                    dm.MoveTo(985, 330)
                    Threading.Thread.Sleep(50)
                    LeftClick()
                    Threading.Thread.Sleep(50)
                    dm.MoveTo(985, 350)
                    Threading.Thread.Sleep(50)
                    LeftClick()
                    Threading.Thread.Sleep(50)
                    dm.MoveTo(985, 370)
                    Threading.Thread.Sleep(50)
                    LeftClick()
                    Threading.Thread.Sleep(50)
                    dm.MoveTo(985, 390)
                    Threading.Thread.Sleep(50)
                    LeftClick()
                    Threading.Thread.Sleep(50)
                    dm.MoveTo(985, 410)
                    Threading.Thread.Sleep(50)
                    LeftClick()
                    Threading.Thread.Sleep(50)
                    dm.MoveTo(985, 430)
                    Threading.Thread.Sleep(50)
                    LeftClick()
                    Threading.Thread.Sleep(50)
                    dm.MoveTo(985, 450)
                    Threading.Thread.Sleep(50)
                    LeftClick()
                    Threading.Thread.Sleep(50)
                End If

                If CheckBox24.CheckState = CheckState.Checked Then

                    dm.KeyDownChar("h")
                    hhh = 1

                    dm.KeyPressChar("0")
                End If

                att()

                If CheckBox25.Checked Then 選殭屍()


                If CheckBox16.CheckState = CheckState.Checked Then
                    dm.KeyPressChar("5")
                End If
                If CheckBox15.CheckState = CheckState.Checked Then
                    dm.KeyPressChar("6")
                End If
                If CheckBox14.CheckState = CheckState.Checked Then
                    dm.KeyPressChar("R")
                End If

                If CheckBox17.CheckState = CheckState.Checked Then
                    購買護甲()
                End If

                att()

                dm.MoveTo(906, 700)
                Threading.Thread.Sleep(100)

                If CheckBox24.CheckState = CheckState.Checked Then

                    dm.KeyDownChar("h")
                    hhh = 1

                    dm.KeyPressChar("0")
                End If

                att()

                LeftClick()
                Threading.Thread.Sleep(100)
                dm.MoveTo(515, 400)
                Threading.Thread.Sleep(100)

                If CheckBox24.CheckState = CheckState.Checked Then

                    dm.KeyDownChar("h")
                    hhh = 1

                    dm.KeyPressChar("0")
                End If

                LeftClick()
                Threading.Thread.Sleep(100)
                If CheckBox17.CheckState = CheckState.Checked Then
                    購買護甲()
                End If

                '///////////////////////////////////////////////////////////////

                If CheckBox24.CheckState = CheckState.Checked Then

                    dm.KeyDownChar("h")
                    dm.KeyUpChar("h")
                    dm.KeyDownChar("alt")
                    hhh = 1

                    dm.KeyPressChar("0")
                End If

                If CheckBox28.CheckState = CheckState.Checked Then dm.KeyUpChar(cm8)

                GoTo aa
            End If
        End If

        '///////////////////////// 狀態 //////////////////////
        '///////////////////////// 狀態 //////////////////////
        '///////////////////////// 狀態 //////////////////////
        '///////////////////////// 狀態 //////////////////////
        If CheckBox30.CheckState = CheckState.Checked Then

            If CheckBox21.CheckState = CheckState.Checked Then
                '////////////////////////////////////////////////////////////

                If CheckBox31.CheckState = CheckState.Checked Then
                    Dim dmret3 = dm.GetWindowState(hwnd, 6)
                    If dmret3 = 1 Then
                        Threading.Thread.Sleep(1000)
                        GoTo aa
                    End If
                End If

                If room狀態 = "房間內" Then
                    Threading.Thread.Sleep(1000)
                    If room狀態 = "房間內" Then
                        Threading.Thread.Sleep(timeim)
                        dm.MoveTo(927, 540)
                        Threading.Thread.Sleep(timeim)
                        LeftClick()
                        Threading.Thread.Sleep(2000)
                        GoTo aa
                    End If
                End If

                If room狀態 = "客制" Then
                    Threading.Thread.Sleep(2000)
                    If room狀態 = "客制" Then
                        Threading.Thread.Sleep(2000)
                        SSSss()
                        Threading.Thread.Sleep(1000)
                        GoTo aa
                    End If
                End If

                '"買武器"
                If room狀態 = "買武器" Then
                    Threading.Thread.Sleep(500)
                    If room狀態 = "買武器" Then
                        Threading.Thread.Sleep(500)
                        GoTo aa
                    End If
                End If


                If room狀態 = "STUDIO" Then
                    Threading.Thread.Sleep(2000)
                    If room狀態 = "STUDIO" Then
                        SSSss()
                        Threading.Thread.Sleep(1000)
                        GoTo aa
                    End If
                End If

                If room狀態 = "選擇兵種" Then
                    Threading.Thread.Sleep(1000)
                    If room狀態 = "選擇兵種" Then
                        dm.KeyPressChar(人物)
                        Threading.Thread.Sleep(500)
                        GoTo aa
                    End If
                End If

                If room狀態 = "確認" Then
                    Threading.Thread.Sleep(2000)
                    GoTo aa
                End If

                If room狀態 = "英雄" Then
                    Threading.Thread.Sleep(1000)
                    GoTo aa
                End If

                '            If room狀態 = "載入中" Then
                '                Threading.Thread.Sleep(2000)
                '                If room狀態 = "載入中" Then
                'bb:
                '                    Threading.Thread.Sleep(2000)
                '                    SSSss()
                '                    Threading.Thread.Sleep(timeim)
                '                    If room狀態 = "遊戲中" Then
                '                        Threading.Thread.Sleep(500)
                '                        dm.KeyPressChar("0")
                '                        Threading.Thread.Sleep(timeim)
                '                        GoTo aa
                '                    End If
                '                    GoTo bb
                '                End If
                '            End If






                If room狀態 = "遊戲中" Then

                    If CheckBox24.CheckState = CheckState.Checked Then
                        dm.KeyDownChar("h")
                        dm.KeyDownChar("alt")
                        hhh = 1
                    End If

                    LeftClick()

                    If CheckBox24.CheckState = CheckState.Unchecked Then
                        If CheckBox50.Checked Then dm.KeyPressChar("g")
                    End If
                    If CheckBox16.CheckState = CheckState.Checked Then
                        dm.KeyPressChar("5")
                    End If
                    If CheckBox15.CheckState = CheckState.Checked Then
                        dm.KeyPressChar("6")
                    End If
                    If CheckBox14.CheckState = CheckState.Checked Then
                        dm.KeyPressChar("R")
                    End If

                    If CheckBox24.CheckState = CheckState.Checked Then
                        dm.KeyDownChar("h")
                    End If

                    If CheckBox28.CheckState = CheckState.Checked Then dm.KeyUpChar(cm8)

                    att()

                    If CheckBox28.CheckState = CheckState.Checked Then
                        ghfas = 1

                        dm.KeyPressChar("e")
                        dm.KeyPressChar(cm8)

                    End If

                    If CheckBox24.CheckState = CheckState.Checked Then
                        dm.KeyDownChar("h")
                    End If

                    LeftClick()

                    dm.MoveR(10, 10)

                    Threading.Thread.Sleep(timeim)

                    dm.MoveR(-10, -10)

                    Threading.Thread.Sleep(timeim)

                    If CheckBox28.CheckState = CheckState.Checked Then
                        ghfas = 1

                        dm.KeyPressChar("e")
                        dm.KeyPressChar(cm8)
                    End If

                    If CheckBox24.CheckState = CheckState.Checked Then
                        dm.KeyDownChar("h")
                    End If

                    att()

                    If CheckBox24.CheckState = CheckState.Unchecked Then
                        If CheckBox50.Checked Then dm.KeyPressChar("g")
                    End If
                    If CheckBox16.CheckState = CheckState.Checked Then
                        dm.KeyPressChar("5")
                    End If
                    If CheckBox15.CheckState = CheckState.Checked Then
                        dm.KeyPressChar("6")
                    End If
                    If CheckBox14.CheckState = CheckState.Checked Then
                        dm.KeyPressChar("R")
                    End If

                    If CheckBox28.CheckState = CheckState.Checked Then
                        ghfas = 1

                        dm.KeyPressChar("e")
                        dm.KeyPressChar(cm8)
                    End If

                    att()

                    If CheckBox24.CheckState = CheckState.Checked Then
                        dm.KeyDownChar("h")
                    End If

                    Threading.Thread.Sleep(timeim)

                    att()

                    If CheckBox17.CheckState = CheckState.Checked Then
                        購買護甲()
                        Threading.Thread.Sleep(timeim)
                    End If

                    att()

                    Threading.Thread.Sleep(timeim)

                    LeftClick()

                    If CheckBox28.CheckState = CheckState.Checked Then
                        ghfas = 1

                        dm.KeyPressChar("e")
                        dm.KeyPressChar(cm8)
                    End If

                    att()

                    If CheckBox24.CheckState = CheckState.Unchecked Then
                        If CheckBox50.Checked Then dm.KeyPressChar("g")
                    End If
                    If CheckBox16.CheckState = CheckState.Checked Then
                        dm.KeyPressChar("5")
                    End If
                    If CheckBox15.CheckState = CheckState.Checked Then
                        dm.KeyPressChar("6")
                    End If
                    If CheckBox14.CheckState = CheckState.Checked Then
                        dm.KeyPressChar("R")
                    End If

                    LeftClick()

                    att()

                    If CheckBox24.CheckState = CheckState.Checked Then
                        Threading.Thread.Sleep(timeim)
                        dm.MoveTo(510, 420)
                        Threading.Thread.Sleep(timeim)
                        LeftClick()
                        Threading.Thread.Sleep(10)
                    End If

                    att()

                    'dm.MoveTo(200, 650)
                    'Threading.Thread.Sleep(timeim)
                    'LeftClick()
                    'Threading.Thread.Sleep(timeim)

                    If CheckBox25.CheckState = CheckState.Checked Then
                        Threading.Thread.Sleep(100)
                        選殭屍()
                        Threading.Thread.Sleep(timeim)
                    End If

                    att()

                    Threading.Thread.Sleep(timeim)

                    If CheckBox24.CheckState = CheckState.Checked Then

                        dm.KeyDownChar("h")
                        dm.KeyUpChar("h")
                        dm.KeyDownChar("alt")
                        hhh = 1

                        dm.KeyDownChar("h")
                    End If

                    Threading.Thread.Sleep(timeim)

                    If CheckBox28.CheckState = CheckState.Checked Then dm.KeyUpChar(cm8)

                    GoTo aa

                End If


                If room狀態 = "獎勵" Then
                    Threading.Thread.Sleep(1000)
                    If room狀態 = "獎勵" Then

                        If CheckBox18.CheckState = CheckState.Checked Then
                            dm.MoveTo(985, 210)
                            Threading.Thread.Sleep(50)
                            LeftClick()
                            Threading.Thread.Sleep(50)
                            dm.MoveTo(985, 230)
                            Threading.Thread.Sleep(50)
                            LeftClick()
                            Threading.Thread.Sleep(50)
                            dm.MoveTo(985, 250)
                            Threading.Thread.Sleep(50)
                            LeftClick()
                            Threading.Thread.Sleep(50)
                            dm.MoveTo(985, 270)
                            Threading.Thread.Sleep(50)
                            LeftClick()
                            Threading.Thread.Sleep(50)
                            dm.MoveTo(985, 290)
                            Threading.Thread.Sleep(50)
                            LeftClick()
                            Threading.Thread.Sleep(50)
                            dm.MoveTo(985, 310)
                            Threading.Thread.Sleep(50)
                            LeftClick()
                            Threading.Thread.Sleep(50)
                            dm.MoveTo(985, 330)
                            Threading.Thread.Sleep(50)
                            LeftClick()
                            Threading.Thread.Sleep(50)
                            dm.MoveTo(985, 350)
                            Threading.Thread.Sleep(50)
                            LeftClick()
                            Threading.Thread.Sleep(50)
                            dm.MoveTo(985, 370)
                            Threading.Thread.Sleep(50)
                            LeftClick()
                            Threading.Thread.Sleep(50)
                            dm.MoveTo(985, 390)
                            Threading.Thread.Sleep(50)
                            LeftClick()
                            Threading.Thread.Sleep(50)
                            dm.MoveTo(985, 410)
                            Threading.Thread.Sleep(50)
                            LeftClick()
                            Threading.Thread.Sleep(50)
                            dm.MoveTo(985, 430)
                            Threading.Thread.Sleep(50)
                            LeftClick()
                            Threading.Thread.Sleep(50)
                            dm.MoveTo(985, 450)
                            Threading.Thread.Sleep(50)
                            LeftClick()
                            Threading.Thread.Sleep(50)
                        End If

                        'Threading.Thread.Sleep(timeim)
                        'dm.MoveTo(620, 570)
                        'Threading.Thread.Sleep(timeim)
                        'LeftClick()
                        'Threading.Thread.Sleep(timeim)

                        'dm.MoveTo(643, 606)
                        'Threading.Thread.Sleep(timeim)
                        'LeftClick()
                        'Threading.Thread.Sleep(timeim)

                        dm.MoveTo(906, 700)
                        Threading.Thread.Sleep(timeim)
                        LeftClick()
                        Threading.Thread.Sleep(timeim)

                        'dm.MoveTo(515, 400)
                        'Threading.Thread.Sleep(timeim)
                        'LeftClick()
                        'Threading.Thread.Sleep(timeim)

                    End If



                End If

            End If

        End If



        If CheckBox8.CheckState = CheckState.Checked Then
            MouseMoveR()
            Threading.Thread.Sleep(100)
            GoTo aa
        End If


        Threading.Thread.Sleep(100)


        GoTo aa
    End Sub

    Private Sub Timer1_Tick_2(sender As Object, e As EventArgs) Handles afkKey.Tick
        If CheckBox21.CheckState = CheckState.Checked Then
            If CheckBox28.CheckState = CheckState.Checked Then
                ghfas = 1
                dm.KeyPressChar("e")
                dm.KeyPressChar(cm8)
            End If
            If CheckBox34.CheckState = CheckState.Checked Then
                If mkey3 IsNot "None" Then
                    dm.KeyPressChar(mkey3)
                End If
                If mkey4 IsNot "None" Then
                    dm.KeyPressChar(mkey4)
                End If
                If mkey5 IsNot "None" Then
                    dm.KeyPressChar(mkey5)
                End If
                If mkey6 IsNot "None" Then
                    dm.KeyPressChar(mkey6)
                End If
            End If
        End If
    End Sub

    Sub att()
        If CheckBox21.CheckState = CheckState.Checked Then
            If CheckBox28.CheckState = CheckState.Checked Then
                ghfas = 1
                dm.KeyPressChar("e")
                dm.KeyPressChar(cm8)
            End If
            If CheckBox34.CheckState = CheckState.Checked Then
                If mkey3 IsNot "None" Then
                    dm.KeyPressChar(mkey3)
                End If
                If mkey4 IsNot "None" Then
                    dm.KeyPressChar(mkey4)
                End If
                If mkey5 IsNot "None" Then
                    dm.KeyPressChar(mkey5)
                End If
                If mkey6 IsNot "None" Then
                    dm.KeyPressChar(mkey6)
                End If
            End If
        End If
    End Sub


    Private Sub TrackBar4_Scroll(sender As Object, e As EventArgs) Handles TrackBar4.Scroll
        Label39.Text = TrackBar4.Value / 10
        精準度 = TrackBar4.Value / 10
    End Sub

    Sub 選殭屍()
        If CheckBox21.CheckState = CheckState.Checked Then

            If CheckBox25.CheckState = CheckState.Checked Then

                dm.KeyPressChar("e")

                Select Case cm7
                    Case "M1(一般殭屍)"

                        dm.KeyPressChar("b")
                        dm.KeyPressChar("e")
                        dm.KeyPressChar("M")
                        Threading.Thread.Sleep(150)
                        dm.KeyPressChar("1")
                        Threading.Thread.Sleep(1121)
                    Case "M2(莎拉)"

                        dm.KeyPressChar("b")
                        dm.KeyPressChar("e")
                        dm.KeyPressChar("M")
                        Threading.Thread.Sleep(150)
                        dm.KeyPressChar("2")
                        Threading.Thread.Sleep(1121)
                    Case "M3(達叔)"

                        dm.KeyPressChar("b")
                        dm.KeyPressChar("e")
                        dm.KeyPressChar("M")
                        Threading.Thread.Sleep(150)
                        dm.KeyPressChar("3")
                        Threading.Thread.Sleep(1121)
                    Case "M4(庫卡)"

                        dm.KeyPressChar("b")
                        dm.KeyPressChar("e")
                        dm.KeyPressChar("M")
                        Threading.Thread.Sleep(150)
                        dm.KeyPressChar("4")
                        Threading.Thread.Sleep(1121)
                    Case "M5(法蘭克)"

                        dm.KeyPressChar("b")
                        dm.KeyPressChar("e")
                        dm.KeyPressChar("M")
                        Threading.Thread.Sleep(150)
                        dm.KeyPressChar("5")
                        Threading.Thread.Sleep(1121)
                    Case "M6(雷比亞進化體)"

                        dm.KeyPressChar("b")
                        dm.KeyPressChar("e")
                        dm.KeyPressChar("M")
                        Threading.Thread.Sleep(150)
                        dm.KeyPressChar("6")
                        Threading.Thread.Sleep(1121)
                    Case "M7(殘暴雷比亞)"

                        dm.KeyPressChar("b")
                        dm.KeyPressChar("e")
                        dm.KeyPressChar("M")
                        Threading.Thread.Sleep(150)
                        dm.KeyPressChar("7")
                        Threading.Thread.Sleep(1121)
                    Case "M8(笆蒂)"

                        dm.KeyPressChar("b")
                        dm.KeyPressChar("e")
                        dm.KeyPressChar("M")
                        Threading.Thread.Sleep(150)
                        dm.KeyPressChar("8")
                        Threading.Thread.Sleep(1121)
                    Case "M9(薩旦)"

                        dm.KeyPressChar("b")
                        dm.KeyPressChar("e")
                        dm.KeyPressChar("M")
                        Threading.Thread.Sleep(150)
                        dm.KeyPressChar("9")
                        Threading.Thread.Sleep(1121)
                    Case "M+1(江姜)"

                        dm.KeyPressChar("b")
                        dm.KeyPressChar("e")
                        dm.KeyPressChar("M")
                        Threading.Thread.Sleep(150)
                        dm.KeyDownChar("=")
                        Threading.Thread.Sleep(150)
                        dm.KeyUpChar("=")
                        dm.KeyPressChar("=")
                        dm.KeyPressChar("=")
                        Threading.Thread.Sleep(150)
                        dm.KeyPressChar("=")
                        dm.KeyPressChar("=")
                        dm.KeyPressChar("1")
                        Threading.Thread.Sleep(1121)
                    Case "M+2(保羅獄長)"

                        dm.KeyPressChar("b")
                        dm.KeyPressChar("e")
                        dm.KeyPressChar("M")
                        Threading.Thread.Sleep(150)
                        dm.KeyDownChar("=")
                        Threading.Thread.Sleep(150)
                        dm.KeyUpChar("=")
                        dm.KeyPressChar("=")
                        dm.KeyPressChar("=")
                        Threading.Thread.Sleep(150)
                        dm.KeyPressChar("=")
                        dm.KeyPressChar("=")
                        dm.KeyPressChar("2")
                        Threading.Thread.Sleep(1121)
                    Case "M+3(血腥瑪麗)"

                        dm.KeyPressChar("b")
                        dm.KeyPressChar("e")
                        dm.KeyPressChar("M")
                        Threading.Thread.Sleep(150)
                        dm.KeyDownChar("=")
                        Threading.Thread.Sleep(150)
                        dm.KeyUpChar("=")
                        dm.KeyPressChar("=")
                        dm.KeyPressChar("=")
                        Threading.Thread.Sleep(150)
                        dm.KeyPressChar("=")
                        dm.KeyPressChar("=")
                        dm.KeyPressChar("3")
                        Threading.Thread.Sleep(1121)
                    Case "M+4(機械女娃)"

                        dm.KeyPressChar("b")
                        dm.KeyPressChar("e")
                        dm.KeyPressChar("M")
                        Threading.Thread.Sleep(150)
                        dm.KeyDownChar("=")
                        Threading.Thread.Sleep(150)
                        dm.KeyUpChar("=")
                        dm.KeyPressChar("=")
                        dm.KeyPressChar("=")
                        Threading.Thread.Sleep(150)
                        dm.KeyPressChar("=")
                        dm.KeyPressChar("=")
                        dm.KeyPressChar("4")
                        Threading.Thread.Sleep(1121)
                    Case "M+5(黑闇哥德)"

                        dm.KeyPressChar("b")
                        dm.KeyPressChar("e")
                        dm.KeyPressChar("M")
                        Threading.Thread.Sleep(150)
                        dm.KeyDownChar("=")
                        Threading.Thread.Sleep(150)
                        dm.KeyUpChar("=")
                        dm.KeyPressChar("=")
                        dm.KeyPressChar("=")
                        Threading.Thread.Sleep(150)
                        dm.KeyPressChar("=")
                        dm.KeyPressChar("=")
                        dm.KeyPressChar("5")
                        Threading.Thread.Sleep(1121)

                    Case "M+6(魅魔莉麗絲)"

                        dm.KeyPressChar("b")
                        dm.KeyPressChar("e")
                        dm.KeyPressChar("M")
                        Threading.Thread.Sleep(150)
                        dm.KeyDownChar("=")
                        Threading.Thread.Sleep(150)
                        dm.KeyUpChar("=")
                        dm.KeyPressChar("=")
                        dm.KeyPressChar("=")
                        Threading.Thread.Sleep(150)
                        dm.KeyPressChar("=")
                        dm.KeyPressChar("=")
                        dm.KeyPressChar("6")
                        Threading.Thread.Sleep(1121)
                            '魔神蚩尤
                    Case "M+7(魔神蚩尤)"

                        dm.KeyPressChar("b")
                        dm.KeyPressChar("e")
                        dm.KeyPressChar("M")
                        Threading.Thread.Sleep(150)
                        dm.KeyDownChar("=")
                        Threading.Thread.Sleep(150)
                        dm.KeyUpChar("=")
                        dm.KeyPressChar("=")
                        dm.KeyPressChar("=")
                        Threading.Thread.Sleep(150)
                        dm.KeyPressChar("=")
                        dm.KeyPressChar("=")
                        dm.KeyPressChar("7")
                        Threading.Thread.Sleep(1121)
                    Case "M+8(隨機)"

                        dm.KeyPressChar("b")
                        dm.KeyPressChar("e")
                        dm.KeyPressChar("M")
                        Threading.Thread.Sleep(150)
                        dm.KeyDownChar("=")
                        Threading.Thread.Sleep(150)
                        dm.KeyUpChar("=")
                        dm.KeyPressChar("=")
                        dm.KeyPressChar("=")
                        Threading.Thread.Sleep(150)
                        dm.KeyPressChar("=")
                        dm.KeyPressChar("=")
                        dm.KeyPressChar("8")
                        Threading.Thread.Sleep(1121)
                End Select
            End If
        End If


    End Sub

    Dim ghfas

    Dim Threadtime As New Thread(AddressOf timetime)
    Sub timetime()
aa:

        runtime += 1
        If runtime = 60 Then
            runtime = 0
            runtimem += 1
        End If
        If runtimem = 60 Then
            runtimem = 0
            runtimeh += 1
        End If

        Threading.Thread.Sleep(1000)

        GoTo aa
    End Sub


    Dim wd As Boolean = False
    '     jump wd
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles 跳.Tick


        If room狀態 = "遊戲中" Then

            If CheckBox21.CheckState = CheckState.Checked Then
                If CheckBox20.CheckState = CheckState.Checked Then
                    dm.KeyPressChar("space")
                End If
                If CheckBox19.CheckState = CheckState.Checked Then
                    dm.KeyDownChar("w")
                    dm.KeyDownChar("right")
                    wd = True
                End If
                If CheckBox19.CheckState = CheckState.Unchecked Then
                    If mode = 3 And wd = True Then
                        dm.KeyUpChar("w")
                        dm.KeyUpChar("right")
                        wd = False
                    End If
                End If
            End If
        End If


        If CheckBox8.CheckState = CheckState.Checked Then
            CheckBox21.Enabled = False
            CheckBox21.CheckState = False
        Else
            If mode = 3 Then
                CheckBox21.Enabled = True
            Else
                CheckBox21.Enabled = False
            End If
        End If
        If CheckBox21.CheckState = CheckState.Checked Then
            CheckBox8.Enabled = False
            CheckBox8.CheckState = False
        Else
            CheckBox8.Enabled = True
        End If


    End Sub



    Private Sub 狀態_Tick(sender As Object, e As EventArgs) Handles 狀態.Tick

        If CheckBox30.CheckState = CheckState.Checked Then

            Dim dmret = dm.GetWindowState(hwnd, 3)
            If dmret = 1 Then
                dm.SetWindowState(hwnd, 1)
            End If

            Dim intX
            Dim intY
            dm.FindStr(20, 75, 75, 100, "遊戲室", "A1A1A1-0E0E0E|9F9F9F-212121", 精準度, intX, intY)

            Dim intX3
            Dim intY3
            dm.FindStrFast(830, 585, 880, 610, "觀戰者", "DADED2-25212D|9F9F9F-212121", 0.2, intX3, intY3)

            If intX >= 0 And intY >= 0 And intY3 >= 0 And intX3 >= 0 Then
                Label29.Text = "房間內"
                room狀態 = "房間內"
            Else

                Dim intX4
                Dim intY4
                dm.FindStrFast(10, 15, 45, 35, "客制", "DADED2-25212D|9F9F9F-212121", 精準度, intX4, intY4)

                If intX4 >= 0 And intY4 >= 0 Then
                    Label29.Text = "客制"
                    room狀態 = "客制"
                Else

                    Dim intX5
                    Dim intY5
                    dm.FindStrFast(10, 15, 100, 35, "STUDIO", "DADED2-25212D|A08887-333334", 精準度, intX5, intY5)

                    If intX5 >= 0 And intY5 >= 0 Then
                        Label29.Text = "STUDIO"
                        room狀態 = "STUDIO"

                    Else

                        Dim intX6
                        Dim intY6
                        dm.FindStrFast(465, 55, 555, 85, "選擇兵種", "DADED2-25212D|9F9F9F-212121", 精準度, intX6, intY6)

                        If intX6 >= 0 And intY6 >= 0 Then
                            Label29.Text = "選擇兵種"
                            room狀態 = "選擇兵種"

                        Else

                            Dim intX7
                            Dim intY7
                            dm.FindStrFast(85, 520, 170, 550, "獎勵", "b@171717-040404|151515-212121", 精準度, intX7, intY7)

                            If intX7 >= 0 And intY7 >= 0 Then
                                Label29.Text = "獎勵"
                                room狀態 = "獎勵"

                            Else

                                Dim intX8
                                Dim intY8
                                dm.FindStrFast(480, 390, 800, 660, "確認", "898989-171717|a4a4a4-090909", 精準度, intX8, intY8)

                                If intX8 >= 0 And intY8 >= 0 Then
                                    Label29.Text = "確認"
                                    room狀態 = "確認"

                                    If CheckBox21.CheckState = CheckState.Checked Then
                                        dm.MoveTo(intX8, intY8)
                                        Threading.Thread.Sleep(100)
                                        LeftClick()
                                        Threading.Thread.Sleep(100)
                                    End If

                                Else
                                    Dim intX9
                                    Dim intY9
                                    dm.FindStrFast(450, 550, 510, 570, "買武器", "F3F5F4-060606|F1F2F1-070808|C1C1C1-191919", 精準度, intX9, intY9)
                                    If intX9 >= 0 And intY9 >= 0 Then
                                        Label29.Text = "買武器"
                                        room狀態 = "買武器"
                                        If CheckBox21.CheckState = CheckState.Checked Then
                                            dm.KeyPressChar(買武器)
                                            Threading.Thread.Sleep(100)
                                        End If

                                    Else

                                        Dim intX10
                                        Dim intY10
                                        dm.FindStrFast(50, 640, 90, 660, "英雄", "C1C1C1-191919", 精準度, intX10, intY10)
                                        If intX10 >= 0 And intY10 >= 0 Then
                                            Label29.Text = "英雄"
                                            room狀態 = "英雄"
                                            If CheckBox21.CheckState = CheckState.Checked Then
                                                dm.KeyPressChar("esc")
                                                Threading.Thread.Sleep(100)
                                            End If
                                        Else

                                            Label29.Text = "遊戲中"
                                            room狀態 = "遊戲中"
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub



    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<'>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<'>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<'>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<'>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<


    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<'>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<'>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<'>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<'>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<
    Dim rndNum123 As New Random()
    Dim aadfg As Integer
    Dim aadfg2 As Integer
    Dim aadfgg As Integer
    Dim aadfgg2 As Integer
    Dim aadfggg As Integer
    Dim aadfggg2 As Integer
    Private Sub RB_Tick(sender As Object, e As EventArgs) Handles RB.Tick
        If TextBox25.TextLength = 0 Then
            TextBox25.Text = 0
        End If
        If TextBox26.TextLength = 0 Then
            TextBox26.Text = 0
        End If
        If TextBox27.TextLength = 0 Then
            TextBox27.Text = 0
        End If
        If TextBox28.TextLength = 0 Then
            TextBox28.Text = 0
        End If
        If TextBox29.TextLength = 0 Then
            TextBox29.Text = 0
        End If
        RB.Interval = TextBox29.Text
        aadfgg = TextBox26.Text
        aadfgg2 = TextBox25.Text
        aadfggg = TextBox28.Text
        aadfggg2 = TextBox27.Text
        If aadfgg > aadfgg2 Then
            TextBox25.Text = aadfgg + 1
        End If
        If aadfggg > aadfggg2 Then
            TextBox27.Text = aadfggg + 1
        End If
        If CheckBox11.CheckState = CheckState.Checked Then
            If CheckBox22.CheckState = CheckState.Checked Then
                aadfg = rndNum123.Next(aadfgg, aadfgg2)
                aadfg2 = rndNum123.Next(aadfggg, aadfggg2)
                TextBox1.Text = aadfg + rndNum123.NextDouble()
                TextBox2.Text = aadfg2 + rndNum123.NextDouble()
            Else
                aadfg = rndNum123.Next(aadfgg, aadfgg2)
                aadfg2 = rndNum123.Next(aadfggg, aadfggg2)
                TextBox1.Text = aadfg
                TextBox2.Text = aadfg2
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Form11.Show()
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form4.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Form11.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub MenuStrip1_MD(sender As Object, e As MouseEventArgs) Handles MenuStrip1.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Dim ii123 As Integer
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        ii123 = TabControl1.SelectedIndex
        TabControl1.Refresh()
    End Sub

    Private Sub Label_MD(sender As Object, e As MouseEventArgs) Handles Label8.MouseDown, Label6.MouseDown, Label4.MouseDown, Label13.MouseDown, Label11.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Sub rrrb()
        Dim rawra
        Dim awr43654
        Dim awta
        Dim a4614awd

        rawra = 14504504534
        awr43654 = 5466655434512345
        awta = 1241567543
        a4614awd = 54687278131534

    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles RbCodeRun.Tick
        rbcode()
        rbcode124()
        rrrb()
    End Sub

    Private Sub 更新記錄ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 更新記錄ToolStripMenuItem.Click
        updateInfo.Show()
    End Sub

    Private Sub 關於ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 關於ToolStripMenuItem.Click
        Form2.Show()
    End Sub


    Private Sub Btn_load_1_Click(sender As Object, e As EventArgs) Handles btn_load_1.Click
        Dim open As New System.Windows.Forms.OpenFileDialog
        open.InitialDirectory = System.IO.Directory.GetParent(Application.StartupPath).FullName
        open.Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*"
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(open.FileName)
            Dim V = Split(fileReader, vbCrLf)
            vSave1 = V
            edit_lst1.Items.Clear()

            For i = 0 To V.Length - 1
                If V(i).Length > 0 Then
                    edit_lst1.Items.Add(V(i))
                End If
            Next

        End If

    End Sub

    Private Sub Btn_load_2_Click(sender As Object, e As EventArgs) Handles btn_load_2.Click
        Dim open As New System.Windows.Forms.OpenFileDialog
        open.InitialDirectory = System.IO.Directory.GetParent(Application.StartupPath).FullName
        open.Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*"
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(open.FileName)
            Dim V = Split(fileReader, vbCrLf)
            vSave2 = V
            edit_lst2.Items.Clear()

            For i = 0 To V.Length - 1
                If V(i).Length > 0 Then
                    edit_lst2.Items.Add(V(i))
                End If
            Next

        End If

    End Sub

    Private Sub Btn_load_3_Click(sender As Object, e As EventArgs) Handles btn_load_3.Click
        Dim open As New System.Windows.Forms.OpenFileDialog
        open.InitialDirectory = System.IO.Directory.GetParent(Application.StartupPath).FullName
        open.Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*"
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(open.FileName)
            Dim V = Split(fileReader, vbCrLf)
            vSave3 = V
            edit_lst3.Items.Clear()

            For i = 0 To V.Length - 1
                If V(i).Length > 0 Then
                    edit_lst3.Items.Add(V(i))
                End If
            Next

        End If

    End Sub

    Private Sub Btn_load_4_Click(sender As Object, e As EventArgs) Handles btn_load_4.Click
        Dim open As New System.Windows.Forms.OpenFileDialog
        open.InitialDirectory = System.IO.Directory.GetParent(Application.StartupPath).FullName
        open.Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*"
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(open.FileName)
            Dim V = Split(fileReader, vbCrLf)
            vSave4 = V
            edit_lst4.Items.Clear()

            For i = 0 To V.Length - 1
                If V(i).Length > 0 Then
                    edit_lst4.Items.Add(V(i))
                End If
            Next

        End If

    End Sub

    Private Sub Btn_load_5_Click(sender As Object, e As EventArgs) Handles btn_load_5.Click
        Dim open As New System.Windows.Forms.OpenFileDialog
        open.InitialDirectory = System.IO.Directory.GetParent(Application.StartupPath).FullName
        open.Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*"
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(open.FileName)
            Dim V = Split(fileReader, vbCrLf)
            vSave5 = V
            edit_lst5.Items.Clear()

            For i = 0 To V.Length - 1
                If V(i).Length > 0 Then
                    edit_lst5.Items.Add(V(i))
                End If
            Next

        End If

    End Sub


    Dim vSave1() As String = {"", ""}
    Dim vSave2() As String = {"", ""}
    Dim vSave3() As String = {"", ""}
    Dim vSave4() As String = {"", ""}
    Dim vSave5() As String = {"", ""}

    Private Sub Btn_edit_1_Click(sender As Object, e As EventArgs) Handles btn_edit_1.Click
        If vSave1.Length > 0 Then
            Dim eedit As New Form8(vSave1)
            eedit.Show()
        End If
    End Sub
    Private Sub Btn_edit_2_Click(sender As Object, e As EventArgs) Handles btn_edit_2.Click
        If vSave2.Length > 0 Then
            Dim eedit As New Form8(vSave2)
            eedit.Show()
        End If
    End Sub

    Private Sub Btn_edit_3_Click(sender As Object, e As EventArgs) Handles btn_edit_3.Click
        If vSave3.Length > 0 Then
            Dim eedit As New Form8(vSave3)
            eedit.Show()
        End If
    End Sub

    Private Sub Btn_edit_4_Click(sender As Object, e As EventArgs) Handles btn_edit_4.Click
        If vSave4.Length > 0 Then
            Dim eedit As New Form8(vSave4)
            eedit.Show()
        End If
    End Sub

    Private Sub Btn_edit_5_Click(sender As Object, e As EventArgs) Handles btn_edit_5.Click
        If vSave5.Length > 0 Then
            Dim eedit As New Form8(vSave5)
            eedit.Show()
        End If
    End Sub

    Dim ThreadEdit1 As New System.Threading.Thread(AddressOf edit1)
    Sub edit1()

        Do
            Try
                If chk_edit_on1.Checked Then
                    If KeyOn10 = 1 Or KeyOnF10 = 1 Or chkOf1.Checked Then
                        Dim off = 0
                        Dim i = 0
                        Dim ii As Integer = 0
                        Do While i <= edit_lst1.Items.Count - 1
                            Dim AAb = Split(edit_lst1.Items.Item(i), ",")
                            Select Case AAb(0)
                                Case "防呆開啟"
                                    off = 1
                                    i += 1
                                Case "跳轉到"
                                    i = AAb(1)
                                    i += 1
                                Case "跳轉到*次數"
                                    If ii < AAb(2) Then
                                        i = AAb(1)
                                        ii += 1
                                    ElseIf ii = AAb(2) Then
                                        ii = 0
                                        i += 1
                                    End If
                                Case Else
                                    fedit(AAb)
                                    i += 1
                            End Select
                        Loop
                        If off = 1 Then
                            For ii = 0 To edit_lst1.Items.Count - 1
                                Dim v = Split(edit_lst1.Items.Item(ii), ",")
                                Select Case v(0)
                                    Case "按下"
                                        dm.KeyUpChar(v(1))
                                    Case "放開"
                                        dm.KeyUpChar(v(1))
                                    Case Else

                                End Select
                                dm.LeftUp
                                dm.RightUp
                            Next
                        End If
                    Else
                        Threading.Thread.Sleep(100)
                    End If
                Else
                    Threading.Thread.Sleep(100)
                End If
            Catch
                MsgBox("運行失敗  請檢查指令沒有錯誤")
                chk_edit_on1.Enabled = False
            End Try
        Loop

    End Sub

    Dim ThreadEdit2 As New System.Threading.Thread(AddressOf edit2)
    Sub edit2()

        Do
            Try
                If chk_edit_on2.Checked Then
                    If KeyOn11 = 1 Or KeyOnF11 = 1 Or chkOf2.Checked Then
                        Dim off = 0
                        Dim i = 0
                        Dim ii As Integer = 0
                        Do While i <= edit_lst2.Items.Count - 1
                            Dim AAb = Split(edit_lst2.Items.Item(i), ",")
                            Select Case AAb(0)
                                Case "防呆開啟"
                                    off = 1
                                    i += 1
                                Case "跳轉到"
                                    i = AAb(1)
                                    i += 1
                                Case "跳轉到*次數"
                                    If ii < AAb(2) Then
                                        i = AAb(1)
                                        ii += 1
                                    ElseIf ii = AAb(2) Then
                                        ii = 0
                                        i += 1
                                    End If
                                Case Else
                                    fedit(AAb)
                                    i += 1
                            End Select
                        Loop
                        If off = 1 Then
                            For ii = 0 To edit_lst2.Items.Count - 1
                                Dim v = Split(edit_lst2.Items.Item(ii), ",")
                                Select Case v(0)
                                    Case "按下"
                                        dm.KeyUpChar(v(1))
                                    Case "放開"
                                        dm.KeyUpChar(v(1))
                                    Case Else

                                End Select
                                dm.LeftUp
                                dm.RightUp
                            Next
                        End If
                    Else
                        Threading.Thread.Sleep(100)
                    End If
                Else
                    Threading.Thread.Sleep(100)
                End If
            Catch
                MsgBox("運行失敗  請檢查指令沒有錯誤")
                chk_edit_on2.Enabled = False
            End Try
        Loop

    End Sub

    Dim ThreadEdit3 As New System.Threading.Thread(AddressOf edit3)
    Sub edit3()

        Do
            Try
                If chk_edit_on3.Checked Then
                    If KeyOn12 = 1 Or KeyOnF12 = 1 Or chkOf3.Checked Then
                        Dim off = 0
                        Dim i = 0
                        Dim ii As Integer = 0
                        Do While i <= edit_lst3.Items.Count - 1
                            Dim AAb = Split(edit_lst3.Items.Item(i), ",")
                            Select Case AAb(0)
                                Case "防呆開啟"
                                    off = 1
                                    i += 1
                                Case "跳轉到"
                                    i = AAb(1)
                                    i += 1
                                Case "跳轉到*次數"
                                    If ii < AAb(2) Then
                                        i = AAb(1)
                                        ii += 1
                                    ElseIf ii = AAb(2) Then
                                        ii = 0
                                        i += 1
                                    End If
                                Case Else
                                    fedit(AAb)
                                    i += 1
                            End Select
                        Loop
                        If off = 1 Then
                            For ii = 0 To edit_lst3.Items.Count - 1
                                Dim v = Split(edit_lst3.Items.Item(ii), ",")
                                Select Case v(0)
                                    Case "按下"
                                        dm.KeyUpChar(v(1))
                                    Case "放開"
                                        dm.KeyUpChar(v(1))
                                    Case Else

                                End Select
                                dm.LeftUp
                                dm.RightUp
                            Next
                        End If
                    Else
                        Threading.Thread.Sleep(100)
                    End If
                Else
                    Threading.Thread.Sleep(100)
                End If
            Catch
                MsgBox("運行失敗  請檢查指令沒有錯誤")
                chk_edit_on3.Enabled = False
            End Try
        Loop

    End Sub

    Dim ThreadEdit4 As New System.Threading.Thread(AddressOf edit4)
    Sub edit4()

        Do
            Try
                If chk_edit_on4.Checked Then
                    If KeyOn13 = 1 Or KeyOnF13 = 1 Or chkOf4.Checked Then
                        Dim off = 0
                        Dim i = 0
                        Dim ii As Integer = 0
                        Do While i <= edit_lst4.Items.Count - 1
                            Dim AAb = Split(edit_lst4.Items.Item(i), ",")
                            Select Case AAb(0)
                                Case "防呆開啟"
                                    off = 1
                                    i += 1
                                Case "跳轉到"
                                    i = AAb(1)
                                    i += 1
                                Case "跳轉到*次數"
                                    If ii < AAb(2) Then
                                        i = AAb(1)
                                        ii += 1
                                    ElseIf ii = AAb(2) Then
                                        ii = 0
                                        i += 1
                                    End If
                                Case Else
                                    fedit(AAb)
                                    i += 1
                            End Select
                        Loop
                        If off = 1 Then
                            For ii = 0 To edit_lst4.Items.Count - 1
                                Dim v = Split(edit_lst4.Items.Item(ii), ",")
                                Select Case v(0)
                                    Case "按下"
                                        dm.KeyUpChar(v(1))
                                    Case "放開"
                                        dm.KeyUpChar(v(1))
                                    Case Else

                                End Select
                                dm.LeftUp
                                dm.RightUp
                            Next
                        End If
                    Else
                        Threading.Thread.Sleep(100)
                    End If
                Else
                    Threading.Thread.Sleep(100)
                End If
            Catch
                MsgBox("運行失敗  請檢查指令沒有錯誤")
                chk_edit_on4.Enabled = False
            End Try
        Loop

    End Sub

    Dim ThreadEdit5 As New System.Threading.Thread(AddressOf edit5)
    Sub edit5()

        Do
            Try
                If chk_edit_on5.Checked Then
                    If KeyOn14 = 1 Or KeyOnF14 = 1 Or chkOf5.Checked Then
                        Dim off = 0
                        Dim i = 0
                        Dim ii As Integer = 0
                        Do While i <= edit_lst5.Items.Count - 1
                            Dim AAb = Split(edit_lst5.Items.Item(i), ",")
                            Select Case AAb(0)
                                Case "防呆開啟"
                                    off = 1
                                    i += 1
                                Case "跳轉到"
                                    i = AAb(1)
                                    i += 1
                                Case "跳轉到*次數"
                                    If ii < AAb(2) Then
                                        i = AAb(1)
                                        ii += 1
                                    ElseIf ii = AAb(2) Then
                                        ii = 0
                                        i += 1
                                    End If
                                Case Else
                                    fedit(AAb)
                                    i += 1
                            End Select
                        Loop
                        If off = 1 Then
                            For ii = 0 To edit_lst5.Items.Count - 1
                                Dim v = Split(edit_lst5.Items.Item(ii), ",")
                                Select Case v(0)
                                    Case "按下"
                                        dm.KeyUpChar(v(1))
                                    Case "放開"
                                        dm.KeyUpChar(v(1))
                                    Case Else

                                End Select
                                dm.LeftUp
                                dm.RightUp
                            Next
                        End If
                    Else
                        Threading.Thread.Sleep(100)
                    End If
                Else
                    Threading.Thread.Sleep(100)
                End If
            Catch
                MsgBox("運行失敗  請檢查指令沒有錯誤")
                chk_edit_on5.Enabled = False
            End Try
        Loop

    End Sub




    Private Sub chk_edit1_CheckedChanged(sender As Object, e As EventArgs) Handles chk_edit1.CheckedChanged
        ThreadEdit1.Start()
        chk_edit1.Enabled = False
        chk_edit_on1.Enabled = True
    End Sub

    Private Sub chk_edit2_CheckedChanged(sender As Object, e As EventArgs) Handles chk_edit2.CheckedChanged
        ThreadEdit2.Start()
        chk_edit2.Enabled = False
        chk_edit_on2.Enabled = True
    End Sub

    Private Sub chk_edit3_CheckedChanged(sender As Object, e As EventArgs) Handles chk_edit3.CheckedChanged
        ThreadEdit3.Start()
        chk_edit3.Enabled = False
        chk_edit_on3.Enabled = True
    End Sub

    Private Sub chk_edit4_CheckedChanged(sender As Object, e As EventArgs) Handles chk_edit4.CheckedChanged
        ThreadEdit4.Start()
        chk_edit4.Enabled = False
        chk_edit_on4.Enabled = True
    End Sub

    Private Sub chk_edit5_CheckedChanged(sender As Object, e As EventArgs) Handles chk_edit5.CheckedChanged
        ThreadEdit5.Start()
        chk_edit5.Enabled = False
        chk_edit_on5.Enabled = True
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Form12.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Form13.Show()
    End Sub




    '卡空   卡空   卡空   卡空   卡空   卡空
    'Private Sub test_Tick(sender As Object, e As EventArgs) Handles test.Tick
    '    If GetAsyncKeyState(Keys.R) Then
    '        dm.UnBindWindow()
    '        Dim wx1, wy1, wx2, wy2, ww, wh
    '        dm.GetClientRect(hwnd, wx1, wy1, wx2, wy2)
    '        dm.GetClientSize(hwnd, ww, wh)
    '        'MsgBox(wx1 & " " & wy1 & " " & wx2 & " " & wy2 & " " & ww & " " & wh)
    '        dm.KeyDownChar("ctrl")
    '        Threading.Thread.Sleep(100)
    '        dm.LeftClick
    '        Threading.Thread.Sleep(10)
    '        dm.KeyPressChar("g")
    '        Threading.Thread.Sleep(700)
    '        dm.RightDown
    '        Threading.Thread.Sleep(800)
    '        dm.RightUp
    '        dm.LeftDown
    '        Threading.Thread.Sleep(600)
    '        dm.LeftUp
    '        dm.KeyUpChar("ctrl")
    '        Threading.Thread.Sleep(5)
    '        dm.KeyPressChar("space")
    '        dm.KeyPressChar("h")
    '        Threading.Thread.Sleep(10)
    '        dm.MoveTo(wx1 + ww - 5, wy1 - 10)
    '        Threading.Thread.Sleep(30)
    '        dm.LeftDown
    '        Threading.Thread.Sleep(30)
    '        dm.MoveTo(wx1 + ww / 2, wy1 + 100)
    '        Threading.Thread.Sleep(3100)
    '        dm.LeftUp
    '        dm.LeftClick
    '        Threading.Thread.Sleep(10)
    '        dm.KeyPressChar("h")
    '    End If
    'End Sub




    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<'>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<'>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<'>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<'>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<


    'Threading.Thread.Sleep()

End Class
