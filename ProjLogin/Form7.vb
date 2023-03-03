Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ccno_lbl.Visible = False
        ccno_txt.Visible = False
        next_bt.Visible = False
    End Sub

    Private Sub cash_rad_CheckedChanged(sender As Object, e As EventArgs) Handles cash_rad.CheckedChanged
        next_bt.Visible = True
    End Sub
    Private Sub card_rad_CheckedChanged(sender As Object, e As EventArgs) Handles card_rad.CheckedChanged
        next_bt.Visible = True
        ccno_lbl.Visible = True
        ccno_txt.Visible = True
        AllPub.ccno = ccno_txt.Text
    End Sub

    Private Sub next_bt_Click(sender As Object, e As EventArgs) Handles next_bt.Click

    End Sub
End Class