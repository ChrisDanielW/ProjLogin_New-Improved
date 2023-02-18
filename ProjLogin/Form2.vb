Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class Form2

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

    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader
    Dim Con = New MySqlConnection

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connString As String
        connString = "datasource=localhost; uid=root; pwd=Chs55432; database=plitdb"
        Try
            Con.ConnectionString = connString
            Con.Open()
            MessageBox.Show("connected")
        Catch ex As Exception
            MessageBox.Show("Error connecting to database." & ex.Message)
            Application.Exit()
        End Try
    End Sub

    Private Sub Minimize(sender As Object, e As EventArgs) Handles mini_bt.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CloseForm(sender As Object, e As EventArgs) Handles close_bt.Click
        Me.Hide()
    End Sub

    Private Sub ExitForm(sender As Object, e As EventArgs) Handles fexit_bt.Click
        If MsgBox("Are you sure you want to exit? (closes all forms)", vbQuestion Or vbYesNo Or vbDefaultButton2, "Full Exit") = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub switchusreg_bt_Click(sender As Object, e As EventArgs) Handles switchusreg_bt.Click
        If MsgBox("Are you sure you want to switch to user options?", vbQuestion Or vbYesNo Or vbDefaultButton2, "Switching to user") = vbYes Then
            Form1.Show()
            Me.Close()
        End If
    End Sub
End Class