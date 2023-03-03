Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Module AllPub
    Public UserID As String
    Public ItemID As Integer
    Public Cart(50) As Integer
    Public ind As Integer = 0
    Public ccno As String
End Module
Public Class Form8

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

    Private Sub Continues(sender As Object, e As EventArgs) Handles cont_bt.Click

        If us_id_txt.Text = "" Or us_pwd_txt.Text = "" Then
            MessageBox.Show("Please fill all your details")
        Else
            Dim con As New MySqlConnection("datasource=localhost; uid=root; pwd=Chs55432; database=plitdb; AllowUserVariables=True")
            con.Open()
            Dim cmd As New MySqlCommand("SELECT * from user_login WHERE us_id = @v1", con)
            cmd.Parameters.AddWithValue("@v1", us_id_txt.Text)
            Dim dr As MySqlDataReader = cmd.ExecuteReader()
            If dr.Read Then
                If dr.GetString("us_id") = us_id_txt.Text Then
                    If dr.GetString("us_pwd") = us_pwd_txt.Text Then
                        MessageBox.Show("Login Successful")
                        UserID = dr.GetString("us_id")
                        dr.Close()
                        con.Close()
                        cmd.Parameters.Clear()
                        Form3.Show()
                        Me.Close()
                    Else
                        MessageBox.Show("The password you entered is incorrect")
                        dr.Close()
                        con.Close()
                        cmd.Parameters.Clear()
                    End If
                End If
            Else
                dr.Close()
                con.Close()
                cmd.Parameters.Clear()
                MessageBox.Show("The User ID entered does not exist")
            End If
        End If

    End Sub

    Private Sub clear_bt_Click(sender As Object, e As EventArgs) Handles clear_bt.Click
        us_id_txt.Text = ""
        us_pwd_txt.Text = ""
    End Sub

    Private Sub switchreg_bt_Click(sender As Object, e As EventArgs) Handles switchreg_bt.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub ID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles us_id_txt.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = vbBack Or e.KeyChar = "-" Or e.KeyChar = "_" Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles us_pwd_txt.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = vbBack Or e.KeyChar = "-" Or e.KeyChar = "_" Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class