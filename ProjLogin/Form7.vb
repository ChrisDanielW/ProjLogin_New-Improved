Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Header
Imports MySql.Data.MySqlClient

Public Class Form7


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

    Dim cash As Boolean = False
    Dim card As Boolean = False
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ccno_lbl.Visible = False
        ccno_txt.Visible = False
        next_bt.Visible = False
    End Sub

    Private Sub cash_rad_CheckedChanged(sender As Object, e As EventArgs) Handles cash_rad.CheckedChanged
        next_bt.Visible = True
        ccno_lbl.Visible = False
        ccno_txt.Visible = False
        cash = True
        card = False
    End Sub
    Private Sub card_rad_CheckedChanged(sender As Object, e As EventArgs) Handles card_rad.CheckedChanged
        next_bt.Visible = True
        ccno_lbl.Visible = True
        ccno_txt.Visible = True
        card = True
        cash = False
    End Sub

    Private Sub next_bt_Click(sender As Object, e As EventArgs) Handles next_bt.Click
        If card = True Then
            AllPub.ccno = ccno_txt.Text
        Else
            AllPub.ccno = "-1"
        End If
        Dim cred As String = AllPub.ccno
        Dim connString As String = "datasource=localhost; uid=root; pwd=Chs55432; database=plitdb"
        Dim con As New MySqlConnection(connString)
        Dim cmd As New MySqlCommand("UPDATE checkout set crcard_no = @v1", con)
        cmd.Parameters.AddWithValue("@v1", cred)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        Form10.Show()
        Me.Close()
    End Sub
End Class