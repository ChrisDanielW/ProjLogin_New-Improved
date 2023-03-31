Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class Form13

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

    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim name, uid, card As String
        Dim ino As Integer = AllPub.ino
        Dim connString As String = "datasource=localhost; uid=root; pwd=Chs55432; database=plitdb"
        Dim con As New MySqlConnection(connString)
        Dim cmd As New MySqlCommand("SELECT * from checkout", con)
        Dim ad As New MySqlDataAdapter(cmd)
        Dim datatable As New DataTable
        con.Open()
        ad.Fill(datatable)
        FullOrder.DataSource = datatable
        Using dr As MySqlDataReader = cmd.ExecuteReader
            If dr.Read() Then
                name = dr.GetString("us_name")
                uid = dr.GetString("us_id")
                card = dr.GetString("crcard_no")
            End If
        End Using
        con.Close()
        uid_lbl.Text = uid
        name_lbl.Text = name
        ino_lbl.Text = ino
        If card = "-1" Then
            card_lbl.Text = "NA"
        Else
            card_lbl.Text = card
        End If
    End Sub

End Class