Public Class Login

    Private Declare Sub ReleaseCapture Lib "user32" ()

    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As String) As Integer

    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    Dim uName As String = OperateIniFile.ReadIniData("root", "name", "", "config.ini")
    Dim uPwd As String = OperateIniFile.ReadIniData("root", "pwd", "", "config.ini")

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        If (uName.Length > 0) Then
            Label1.Text = "Auto Login"
            autoLogin()
        Else
            Label1.Text = "Auto Register"
            autoRe()
        End If
    End Sub

    Function autoLogin()
        Label1.Text = "Auto Login"
        If Login() <> 1 Then
            Label1.Text = "Retry Auto Login" & "Error : " & fret
            MsgBox("Retry Auto Login" & "Error : " & fret)
            If Login() <> 1 Then
                Label1.Text = "No Login"
                MsgBox("No Login")
                NoLogin()
            End If
        End If
        Return 1
    End Function

    Dim fret As String = "Error"

    Function autoRe()
        Label1.Text = "Auto Register"
        If RegisterAc() <> 1 Then
            Label1.Text = "Retry Auto Register" & "Error : " & fret
            MsgBox("Retry Auto Register" & "Error : " & fret)
            If RegisterAc() <> 1 Then
                Label1.Text = "No Login"
                MsgBox("No Login")
                NoLogin()
            Else
                autoLogin()
            End If
        Else
            autoLogin()
        End If
        Return 1
    End Function

    Private Sub Form_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        Shell(Application.StartupPath & "\re.bat")
    End Sub


    Public ReadOnly Property GetMyVersion2() As String '取得程式的版本號碼(格式：X.X.X)
        Get
            Return My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build '取得版本號碼
        End Get
    End Property

    Function Login()
        Dim url As String = "http://w.eydata.net/07dbbb2bf9709ffb" ' 这里改成自己的地址
        Dim parameters As IDictionary(Of String, String) = New Dictionary(Of String, String)
        Try
            Dim code As String = OperateIniFile.ReadIniData("root", "code", "", "config.ini")
            Dim upName As String = OperateIniFile.ReadIniData("root", "upName", "", "config.ini")
            If ((code.Length > 0) AndAlso (upName.Length > 0)) Then
                ' 	退出登录(LogOut) url
                Dim logOutUrl As String = "http://w.eydata.net/47d1f1eb475e5a05" ' 这里改成自己的地址
                '  这里改成自己的参数名称
                parameters.Add("StatusCode", code)
                parameters.Add("UserName", upName)
                WebPost.ApiPost(logOutUrl, parameters)
                parameters.Clear()
            End If
            '  这里改成自己的参数名称

            Dim ver = GetMyVersion2
            parameters.Add("UserName", uName.Trim)
            parameters.Add("UserPwd", uPwd)
            parameters.Add("Version", ver)
            parameters.Add("Mac", "")
            Dim ret As String = WebPost.ApiPost(url, parameters)
            If (ret.Length = &H20) Then
                OperateIniFile.WriteIniData("root", "code", ret, "config.ini")
                OperateIniFile.WriteIniData("root", "upName", uName.Trim, "config.ini")

                OperateIniFile.WriteIniData("root", "name", uName, "config.ini")
                OperateIniFile.WriteIniData("root", "pwd", uPwd, "config.ini")

                Dim asddddd As New ASD(ret, uName.Trim)
                MyBase.Hide()
                asddddd.Show()
                Return 1
            Else
                fret = ret
                Return ret
            End If
        Catch exception1 As Exception
            Return 0
        End Try
    End Function

    Function RegisterAc()
        Dim url As String = "http://w.eydata.net/ac4263338f6b9e90" ' 这里改成自己的地址
        Dim parameters As IDictionary(Of String, String) = New Dictionary(Of String, String)
        Try
            '  这里改成自己的参数名称

            Dim rdt As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
            Dim rdn As New Random
            Dim rdx As String = rdt.Substring(rdn.Next(1, rdt.Length), 1)
            Dim rda As String = rdx & System.Guid.NewGuid.ToString("N").Substring(0, 15)
            uName = rda
            uPwd = rda

            parameters.Add("UserName", rda.Trim)
            parameters.Add("UserPwd", rda)
            parameters.Add("Email", rda & "@AutoSys.com")
            parameters.Add("Mac", "")
            Dim ret As String = WebPost.ApiPost(url, parameters)
            If (ret = "1") Then
                Return 1
            Else
                fret = ret
                Return ret
            End If
        Catch exception1 As Exception
            Return 0
        End Try
    End Function

    Function NoLogin()
        Dim asd As New ASD(0, 0)
        MyBase.Hide()
        asd.Show()
        GGGGG = 1
    End Function

    Dim timer As String = 60

    Private Sub PMD(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Shell(Application.StartupPath & "\re.bat")
        End
    End Sub

End Class
