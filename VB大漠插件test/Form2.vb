Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        Me.TopMost = True
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dim webAddress As String
        webAddress = "https://bingfeng.tw/thread-545178-1-1.html"
        Process.Start(webAddress)
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim webAddress2 As String
        webAddress2 = "https://www.facebook.com/yutinglia"
        Process.Start(webAddress2)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim webAddress3 As String
        webAddress3 = "https://www.youtube.com/user/lyutinglial/videos?view_as=subscriber"
        Process.Start(webAddress3)
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Dim webAddress4 As String
        webAddress4 = "https://sites.google.com/view/yutinglia/home/drscript"
        Process.Start(webAddress4)
    End Sub
End Class