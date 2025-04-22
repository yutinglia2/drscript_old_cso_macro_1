Public Class Form21
    Private Sub Form21_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddKeyItem_LA2(ModeKey1)
        AddKeyItem_LA2(ModeKey2)
        ModeKey1.Text = "["
        ModeKey2.Text = "]"
    End Sub

    '>>>>>>>>>>>>>>>>>>>>KeyPress<<<<<<<<<<<<<<<<<<<<'
    Private Sub Key_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ModeKey1.KeyPress, ModeKey2.KeyPress
        e.Handled = True
    End Sub
    '>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        mkey1 = ModeKey1.Text
        mkey2 = ModeKey2.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form11.Show()
    End Sub

End Class

