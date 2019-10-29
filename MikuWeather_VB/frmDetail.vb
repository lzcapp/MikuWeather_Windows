Public Class FrmDetail
    Private Sub frmDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lnkCopy.Parent = picTitleBack
        lnkVer.Parent = picTitleBack
        picClose.Parent = picTitleBack
        picTitle.Parent = picTitleBack
        lnkVer.Text = "v" + Split(Application.ProductVersion, ".")(0) + "." + Split(Application.ProductVersion, ".")(1) +
                      "." + Split(Application.ProductVersion, ".")(2)
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Close()
    End Sub
End Class