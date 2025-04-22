Public Class Form8
    Dim v() As String
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()

        For i = 0 To V.Length - 1
            If V(i).Length > 0 Then
                ListBox1.Items.Add(V(i))
            End If
        Next

        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
        ComboBox4.SelectedIndex = 0
        ComboBox5.SelectedIndex = 0

        MsgBox("編輯完成後請記得儲存   主程式需手動重新讀取編輯後的檔案")

    End Sub



    Public Sub New(ByVal code() As String)

        v = code

        ' 設計工具需要此呼叫。
        InitializeComponent()
        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If ComboBox1.Text = "按," Then
                ListBox1.Items.Add("按下," & ComboBox2.Text)
                ListBox1.Items.Add("放開," & ComboBox2.Text)
            Else
                ListBox1.Items.Add(ComboBox1.Text & ComboBox2.Text)
            End If
        Catch
            MsgBox("失敗  請檢查指令沒有錯誤")
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If TextBox1.TextLength <> 0 Then
                ListBox1.Items.Add("延遲," & TextBox1.Text)
            End If
        Catch
            MsgBox("失敗  請檢查指令沒有錯誤")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim v As Integer = ListBox1.SelectedIndex
            If v >= 0 Then
                If ComboBox1.Text = "按," Then
                    ListBox1.Items.Insert(v, "按下," & ComboBox2.Text)
                    ListBox1.Items.Insert(v, "放開," & ComboBox2.Text)
                Else
                    ListBox1.Items.Insert(v, ComboBox1.Text & ComboBox2.Text)
                End If
            End If
        Catch
            MsgBox("失敗  請檢查指令沒有錯誤")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim v As Integer = ListBox1.SelectedIndex
            If TextBox1.TextLength <> 0 Then
                If v >= 0 Then
                    ListBox1.Items.Insert(v, "延遲," & TextBox1.Text)
                End If
            End If
        Catch
            MsgBox("失敗  請檢查指令沒有錯誤")
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            If ComboBox4.Text = "按mouse," Then
                ListBox1.Items.Add("按下mouse," & ComboBox3.Text)
                ListBox1.Items.Add("放開mouse," & ComboBox3.Text)
            Else
                ListBox1.Items.Add(ComboBox4.Text & ComboBox3.Text)
            End If
        Catch
            MsgBox("失敗  請檢查指令沒有錯誤")
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Dim v As Integer = ListBox1.SelectedIndex
            If v >= 0 Then
                If ComboBox4.Text = "按mouse," Then
                    ListBox1.Items.Insert(v, "按下mouse," & ComboBox3.Text)
                    ListBox1.Items.Insert(v, "放開mouse," & ComboBox3.Text)
                Else
                    ListBox1.Items.Insert(v, ComboBox4.Text & ComboBox3.Text)
                End If
            End If
        Catch
            MsgBox("失敗  請檢查指令沒有錯誤")
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim v As Integer = ListBox1.SelectedIndex
        If v >= 0 Then
            ListBox1.Items.RemoveAt(v)
        End If
    End Sub

    Private Sub Key_KeyPress2(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        e.Handled = True
        TextBox2.Text = e.KeyChar
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Try
            If TextBox2.Text.Length <> 0 Then
                If ComboBox5.Text = "按," Then
                    ListBox1.Items.Add("按下," & TextBox2.Text)
                    ListBox1.Items.Add("放開," & TextBox2.Text)
                Else
                    ListBox1.Items.Add(ComboBox5.Text & TextBox2.Text)
                End If
            End If
        Catch
            MsgBox("失敗  請檢查指令沒有錯誤")
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            If TextBox2.Text.Length <> 0 Then
                Dim v As Integer = ListBox1.SelectedIndex
                If v >= 0 Then
                    If ComboBox5.Text = "按," Then
                        ListBox1.Items.Insert(v, "按下," & TextBox2.Text)
                        ListBox1.Items.Insert(v, "放開," & TextBox2.Text)
                    Else
                        ListBox1.Items.Insert(v, ComboBox5.Text & TextBox2.Text)
                    End If
                End If
            End If
        Catch
            MsgBox("失敗  請檢查指令沒有錯誤")
        End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If ListBox1.Items.Count <> 0 Then
            Dim v As Integer = ListBox1.SelectedIndex
            If v > 0 Then
                Dim i = ListBox1.Items(v)
                ListBox1.Items.RemoveAt(v)
                ListBox1.Items.Insert(v - 1, i)
                ListBox1.SelectedIndex = v - 1
            End If
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If ListBox1.Items.Count <> 0 Then
            Dim v As Integer = ListBox1.SelectedIndex
            If v < ListBox1.Items.Count - 1 Then
                Dim i = ListBox1.Items(v)
                ListBox1.Items.RemoveAt(v)
                ListBox1.Items.Insert(v + 1, i)
                ListBox1.SelectedIndex = v + 1
            End If
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Try
            If TextBox3.Text.Length <> 0 And TextBox4.Text.Length <> 0 Then
                ListBox1.Items.Add("滑鼠移到," & TextBox3.Text & "," & TextBox4.Text)
            End If
        Catch
            MsgBox("失敗  請檢查指令沒有錯誤")
        End Try
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Try
            If TextBox3.Text.Length <> 0 And TextBox4.Text.Length <> 0 Then
                Dim v As Integer = ListBox1.SelectedIndex
                If v >= 0 Then
                    ListBox1.Items.Insert(v, "滑鼠移到," & TextBox3.Text & "," & TextBox4.Text)
                End If
            End If
        Catch
            MsgBox("失敗  請檢查指令沒有錯誤")
        End Try
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If TextBox5.Text.Length <> 0 And TextBox6.Text.Length <> 0 Then
            ListBox1.Items.Add("相對移動," & TextBox5.Text & "," & TextBox6.Text)
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Try
            If TextBox5.Text.Length <> 0 And TextBox6.Text.Length <> 0 Then
                Dim v As Integer = ListBox1.SelectedIndex
                If v >= 0 Then
                    ListBox1.Items.Insert(v, "相對移動," & TextBox5.Text & "," & TextBox6.Text)
                End If

            End If
        Catch
            MsgBox("失敗  請檢查指令沒有錯誤")
        End Try
    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim save As New System.Windows.Forms.SaveFileDialog
        save.InitialDirectory = System.IO.Directory.GetParent(Application.StartupPath).FullName
        save.FileName = "A"
        save.Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*"
        If save.ShowDialog = Windows.Forms.DialogResult.OK Then
            MessageBox.Show(save.FileName)
            My.Computer.FileSystem.WriteAllText(save.FileName, "", False)
            Dim i = 0
aa:
            Try
                Dim item = ListBox1.Items.Item(i)
                My.Computer.FileSystem.WriteAllText(save.FileName, item & vbCrLf, True)
            Catch
                GoTo bb
            End Try
            i += 1
            GoTo aa
bb:
        End If
    End Sub
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim open As New System.Windows.Forms.OpenFileDialog
        open.InitialDirectory = System.IO.Directory.GetParent(Application.StartupPath).FullName
        open.Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*"
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(open.FileName)
            Dim V = Split(fileReader, vbCrLf)
            Dim i = 0
            ListBox1.Items.Clear()
aa:
            Try
                ListBox1.Items.Add(V(i))
            Catch
                ListBox1.Items.RemoveAt(ListBox1.Items.Count - 1)
                GoTo bb
            End Try
            i += 1
            GoTo aa
        End If
bb:
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Try
            If TextBox7.Text.Length <> 0 Then
                If TextBox7.Text < ListBox1.Items.Count Then
                    ListBox1.Items.Add("跳轉到," & TextBox7.Text)
                End If
            End If
        Catch
            MsgBox("失敗  請檢查指令沒有錯誤")
        End Try
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Try
            If TextBox7.Text.Length <> 0 Then
                Dim v As Integer = ListBox1.SelectedIndex
                If v >= 0 Then
                    If TextBox7.Text < ListBox1.Items.Count Then
                        ListBox1.Items.Insert(v, "跳轉到," & TextBox7.Text)
                    End If
                End If
            End If
        Catch
            MsgBox("失敗  請檢查指令沒有錯誤")
        End Try
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Try
            If TextBox8.Text.Length <> 0 And TextBox9.Text.Length <> 0 Then
                If TextBox8.Text < ListBox1.Items.Count Then
                    ListBox1.Items.Add("跳轉到*次數," & TextBox8.Text & "," & TextBox9.Text)
                End If
            End If
        Catch
            MsgBox("失敗  請檢查指令沒有錯誤")
        End Try
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Try
            If TextBox8.Text.Length <> 0 And TextBox9.Text.Length <> 0 Then
                Dim v As Integer = ListBox1.SelectedIndex
                If v >= 0 Then
                    If TextBox8.Text < ListBox1.Items.Count Then
                        ListBox1.Items.Insert(v, "跳轉到*次數," & TextBox8.Text & "," & TextBox9.Text)
                    End If
                End If
            End If
        Catch
            MsgBox("失敗  請檢查指令沒有錯誤")
        End Try
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Try
            If TextBox10.Text.Length <> 0 And TextBox11.Text.Length <> 0 Then
                If TextBox11.Text > TextBox10.Text Then
                    ListBox1.Items.Add("隨機延遲," & TextBox10.Text & "," & TextBox11.Text)
                End If
            End If
        Catch
            MsgBox("失敗  請檢查指令沒有錯誤")
        End Try
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Try
            If TextBox10.Text.Length <> 0 And TextBox11.Text.Length <> 0 Then
                Dim v As Integer = ListBox1.SelectedIndex
                If v >= 0 Then
                    If TextBox11.Text > TextBox10.Text Then
                        ListBox1.Items.Insert(v, "隨機延遲," & TextBox10.Text & "," & TextBox11.Text)
                    End If
                End If
            End If
        Catch
            MsgBox("失敗  請檢查指令沒有錯誤")
        End Try
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Dim i = 1
        If ListBox1.Items.Count <> 0 Then
            ListBox1.Items.Insert(0, "防呆開啟")
aa:
            Try
                If ListBox1.Items.Item(i) = "防呆開啟" Or ListBox1.Items.Item(i) = "防呆關閉" Then
                    ListBox1.Items.RemoveAt(i)
                    i += 1
                Else
                    i += 1
                End If
                GoTo aa
            Catch ex As Exception
                i = 1
            End Try
        End If
        If ListBox1.Items.Count = 0 Then
            ListBox1.Items.Add("防呆開啟")
        End If
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        Dim i = 1
        If ListBox1.Items.Count <> 0 Then
            ListBox1.Items.Insert(0, "防呆關閉")
aa:
            Try
                If ListBox1.Items.Item(i) = "防呆關閉" Or ListBox1.Items.Item(i) = "防呆開啟" Then
                    ListBox1.Items.RemoveAt(i)
                    i += 1
                Else
                    i += 1
                End If
                GoTo aa
            Catch ex As Exception
                i = 1
            End Try
        End If
        If ListBox1.Items.Count = 0 Then
            ListBox1.Items.Add("防呆關閉")
        End If
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs)
        Dim i = 1
        If ListBox1.Items.Count <> 0 Then
            ListBox1.Items.Insert(0, "精準模式開啟")
aa:
            Try
                If ListBox1.Items.Item(i) = "精準模式開啟" Or ListBox1.Items.Item(i) = "精準模式關閉" Then
                    ListBox1.Items.RemoveAt(i)
                    i += 1
                Else
                    i += 1
                End If
                GoTo aa
            Catch ex As Exception
                i = 1
            End Try
        End If
        If ListBox1.Items.Count = 0 Then
            ListBox1.Items.Add("精準模式開啟")
        End If
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs)
        Dim i = 1
        If ListBox1.Items.Count <> 0 Then
            ListBox1.Items.Insert(0, "精準模式關閉")
aa:
            Try
                If ListBox1.Items.Item(i) = "精準模式關閉" Or ListBox1.Items.Item(i) = "精準模式開啟" Then
                    ListBox1.Items.RemoveAt(i)
                    i += 1
                Else
                    i += 1
                End If
                GoTo aa
            Catch ex As Exception
                i = 1
            End Try
        End If
        If ListBox1.Items.Count = 0 Then
            ListBox1.Items.Add("精準模式關閉")
        End If
    End Sub

    Private Sub lst1SC(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim v As Integer = ListBox1.SelectedIndex
        If v >= 0 Then
            Label1.Text = "選取的為第" & v & "行"
        Else
            Label1.Text = "選取的為第N行"
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Form10.Show()
    End Sub

End Class