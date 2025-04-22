Public Class Form10
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim x
        Dim y
        dm.GetCursorPos(x, y)
        Label2.Text = "x" & x
        Label3.Text = "y" & y
        If GetAsyncKeyState(Keys.MButton) <> 0 Then
            TextBox1.Text = x
            TextBox2.Text = y
        End If
    End Sub

End Class