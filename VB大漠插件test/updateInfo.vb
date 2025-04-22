Public Class updateInfo

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            OperateIniFile.WriteIniData("root", "udMsg", GetMyVersion3, "config.ini")
        Else
            OperateIniFile.WriteIniData("root", "udMsg", "", "config.ini")
        End If
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim UdMsg As String = OperateIniFile.ReadIniData("root", "udMsg", "", "config.ini")
        If (UdMsg = GetMyVersion3) Then
            CheckBox1.CheckState = CheckState.Checked
        End If
        Me.TopMost = True
        Label2.Text = GetMyVersion3
    End Sub

End Class