Public Class frmDetail

    Private Sub frmDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lnkCopy.Parent = picTitleBack
        lnkVer.Parent = picTitleBack
        picClose.Parent = picTitleBack
        picTitle.Parent = picTitleBack
        lnkVer.Text = "v" + Split(Application.ProductVersion, ".")(0) + "." + Split(Application.ProductVersion, ".")(1) + "." + Split(Application.ProductVersion, ".")(2)

        'LinkLabel8.SetBounds(lnkCity.Location.X + lnkCity.Size.Width + 6, 73, LinkLabel8.Size.Width, LinkLabel8.Size.Height)
        'lnkPM.SetBounds(lnkCity.Location.X + lnkCity.Size.Width + 6, 91, lnkPM.Size.Width, lnkPM.Size.Height)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        frmSetting.Show()
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()
    End Sub
End Class