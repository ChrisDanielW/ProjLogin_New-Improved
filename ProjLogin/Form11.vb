Imports System.Runtime.InteropServices

Public Class Form11

    Public Const WM_NCLBUTTONDOWN As Integer = 161
    Public Const HT_CAPTION As Integer = 2

    <DllImport("User32")> Private Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    <DllImport("User32")> Private Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub GetsDragged(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If (e.Button = MouseButtons.Left) Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub Minimize(sender As Object, e As EventArgs) Handles mini_bt.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CloseForm(sender As Object, e As EventArgs) Handles close_bt.Click
        Me.Close()
    End Sub

    Private Sub ExitForm(sender As Object, e As EventArgs) Handles fexit_bt.Click
        If MsgBox("Are you sure you want to exit? (closes all forms)", vbQuestion Or vbYesNo Or vbDefaultButton2, "Full Exit") = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub user_bt_Click(sender As Object, e As EventArgs) Handles user_bt.Click, user_pic.Click
        Form16.Show()
        Me.Close()
    End Sub

    Private Sub sys_bt_Click(sender As Object, e As EventArgs) Handles sys_bt.Click, sys_pic.Click
        Form15.Show()
        Me.Close()
    End Sub

    Private Sub item_pic_Click(sender As Object, e As EventArgs) Handles item_pic.Click, item_bt.Click
        Form14.Show()
        Me.Close()
    End Sub

End Class