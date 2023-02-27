Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Form1

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

    '//Full Exit Button Message
    Private Sub ExitForm(sender As Object, e As EventArgs) Handles fexit_bt.Click
        If MsgBox("Are you sure you want to exit? (closes all forms)", vbQuestion Or vbYesNo Or vbDefaultButton2, "Full Exit") = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Continues(sender As Object, e As EventArgs) Handles cont_bt.Click
        Dim repcred As Boolean = False
        Dim connString As String = "datasource=localhost; uid=root; pwd=Chs55432; database=plitdb"
        Dim con As New MySqlConnection(connString)
        con.Open()
        Dim cmd As New MySqlCommand("SELECT * from user_reg where us_id = @r1 or us_email = @r2 or us_phone = @r3", con)
        cmd.Parameters.AddWithValue("@r1", us_id_txt.Text)
        cmd.Parameters.AddWithValue("@r2", us_email_txt.Text)
        cmd.Parameters.AddWithValue("@r3", us_phno_txt.Text)
        Dim dr As MySqlDataReader = cmd.ExecuteReader()
        If dr.HasRows Then
            repcred = True
        End If
        dr.Close()
        con.Close()
        cmd.Parameters.Clear()
        If us_email_txt.Text = "" Or us_id_txt.Text = "" Or us_phno_txt.Text = "" Or us_pwd_txt.Text = "" Or us_name_txt.Text = "" Then
            MessageBox.Show("Please fill all your details")
        ElseIf repcred = True Then
            MessageBox.Show("The ID, email address and/or phone number entered seem(s) to already exist in our database")
        Else
            cmd.CommandText = "INSERT into user_reg (us_id, us_pwd, us_name, us_email, us_phone) values (@v1, @v2, @v3, @v4, @v5);
                               INSERT into user_login values (@v1, @v2)"
            cmd.Parameters.AddWithValue("@v1", us_id_txt.Text)
            cmd.Parameters.AddWithValue("@v2", us_pwd_txt.Text)
            cmd.Parameters.AddWithValue("@v3", us_name_txt.Text)
            cmd.Parameters.AddWithValue("@v4", us_email_txt.Text)
            cmd.Parameters.AddWithValue("@v5", us_phno_txt.Text)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Account created")
            cmd.Parameters.Clear()
            Form8.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub AdminSwitch(sender As Object, e As EventArgs) Handles switchadmin_bt.Click
        If MsgBox("Are you sure you want to switch to admin options?", vbQuestion Or vbYesNo Or vbDefaultButton2, "Swicthing to Admin") = vbYes Then
            Form2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub clear_bt_Click(sender As Object, e As EventArgs) Handles clear_bt.Click
        us_email_txt.Text = ""
        us_id_txt.Text = ""
        us_phno_txt.Text = ""
        us_pwd_txt.Text = ""
        us_name_txt.Text = ""
    End Sub

    Private Sub switchuslog_bt_Click(sender As Object, e As EventArgs) Handles switchuslog_bt.Click
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles us_name_txt.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = vbBack Or e.KeyChar = " " Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub email_KeyPres(sender As Object, e As KeyPressEventArgs) Handles us_email_txt.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = vbBack Or e.KeyChar = "@" Or Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
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

    Private Sub Phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles us_phno_txt.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = vbBack Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class
