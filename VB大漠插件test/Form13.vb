Public Class Form13
    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim webAddress As String
        webAddress = "https://github.com/yutinglia/test1"
        Process.Start(webAddress)
    End Sub

End Class