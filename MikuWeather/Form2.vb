Public Class FrmMsg
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LinkLabel3.Text = StrMsgTitle + "：" + StrMsg
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()
    End Sub
End Class