Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Google.Protobuf.Collections
Imports MySql.Data.MySqlClient

Public Class Form16

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

    Private Sub Form16_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fill()
    End Sub

    Private Sub UserTab_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UserTab.CellContentClick
        Dim ri As Integer = e.RowIndex
        If ri >= 0 Then
            phone_txt.Text = UserTab.Rows(ri).Cells("us_phone").Value.ToString()
            name_txt.Text = UserTab.Rows(ri).Cells("us_name").Value.ToString()
            id_txt.Text = UserTab.Rows(ri).Cells("us_id").Value.ToString()
            pwd_txt.Text = UserTab.Rows(ri).Cells("us_pwd").Value.ToString()
            email_txt.Text = UserTab.Rows(ri).Cells("us_email").Value.ToString()
        End If
    End Sub

    Private Sub Fill()
        Dim connString As String = "datasource=localhost; uid=root; pwd=Chs55432; database=plitdb"
        Dim con As New MySqlConnection(connString)
        con.Open()
        Dim cmd As New MySqlCommand("SELECT * from user_reg", con)
        Dim ad As New MySqlDataAdapter(cmd)
        Dim datatable As New DataTable
        ad.Fill(datatable)
        UserTab.DataSource = datatable
    End Sub

    Private Sub del_bt_Click(sender As Object, e As EventArgs) Handles del_bt.Click
        Dim uid As String
        Dim exists As Boolean = False
        uid = InputBox("Enter the User ID of the account to be deleted")
        Dim connString As String = "datasource=localhost; uid=root; pwd=Chs55432; database=plitdb"
        Dim con As New MySqlConnection(connString)
        Dim cmd As New MySqlCommand("SELECT * from user_reg where us_id = @v1", con)
        cmd.Parameters.AddWithValue("@v1", uid)
        con.Open()
        Using dr As MySqlDataReader = cmd.ExecuteReader
            If dr.Read() Then
                exists = True
            End If
        End Using
        If exists = True Then
            cmd.CommandText = "DELETE from user_reg where us_id = @v1"
            cmd.ExecuteNonQuery()
            MessageBox.Show("User Account Deleted")
            Reset()
        ElseIf uid = "" Then
            MessageBox.Show("Cancelled")
        Else
            MessageBox.Show("Invalid ID")
        End If
        con.Close()
        cmd.Parameters.Clear()
    End Sub

    Private Sub back_bt_Click(sender As Object, e As EventArgs) Handles back_bt.Click, back_pic.Click
        Form11.Show()
        Me.Close()
    End Sub

    Private Sub Reset()
        UserTab.EndEdit()
        UserTab.DataSource = Nothing
        Fill()
    End Sub

    Private Sub edit_bt_Click(sender As Object, e As EventArgs) Handles edit_bt.Click
        If id_txt.Text = "" Or name_txt.Text = "" Or phone_txt.Text = "" Or email_txt.Text = "" Or pwd_txt.Text = "" Then
            MessageBox.Show("Make sure all columns are specified")
        Else
            Dim connString As String = "datasource=localhost; uid=root; pwd=Chs55432; database=plitdb"
            Dim con As New MySqlConnection(connString)
            Dim cmd As New MySqlCommand("UPDATE user_reg set us_name = @v2, us_phone = @v3, us_pwd = @v4, us_email = @v5 where us_id = @v1", con)
            cmd.Parameters.AddWithValue("@v1", id_txt.Text)
            cmd.Parameters.AddWithValue("@v2", name_txt.Text)
            cmd.Parameters.AddWithValue("@v3", phone_txt.Text)
            cmd.Parameters.AddWithValue("@v4", pwd_txt.Text)
            cmd.Parameters.AddWithValue("@v5", email_txt.Text)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Successfully Edited Account")
            Reset()
        End If
    End Sub

    Private Sub add_bt_Click(sender As Object, e As EventArgs) Handles add_bt.Click
        If name_txt.Text = "" Or phone_txt.Text = "" Or email_txt.Text = "" Or pwd_txt.Text = "" Then
            MessageBox.Show("Make sure all columns are specified")
        Else
            Dim uid As String
            uid = InputBox("Enter the ID of the new user")
            If uid = "" Then
                MessageBox.Show("Cancelled")
            Else
                Dim exists As Boolean = False
                Dim connString As String = "datasource=localhost; uid=root; pwd=Chs55432; database=plitdb"
                Dim con As New MySqlConnection(connString)
                Dim cmd As New MySqlCommand("SELECT * from user_reg where us_id = @v1 or us_email = @v5 or us_phone = @v3", con)
                cmd.Parameters.AddWithValue("@v1", id_txt.Text)
                cmd.Parameters.AddWithValue("@v2", name_txt.Text)
                cmd.Parameters.AddWithValue("@v3", phone_txt.Text)
                cmd.Parameters.AddWithValue("@v4", pwd_txt.Text)
                cmd.Parameters.AddWithValue("@v5", email_txt.Text)
                con.Open()
                Using dr As MySqlDataReader = cmd.ExecuteReader
                    If dr.Read() Then
                        exists = True
                    End If
                End Using
                con.Close()
                If exists = True Then
                    MessageBox.Show("Make sure there are no conflicts with existing accounts")
                    clear()
                Else
                    cmd.CommandText = "INSERT into user_reg (us_id, us_name, us_phone, us_pwd, us_email) values (@v1, @v2, @v3, @v4, @v5)"
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MessageBox.Show("Successfully Added Account ")
                    Reset()
                End If
                cmd.Parameters.Clear()
            End If
        End If
    End Sub

    Private Sub clear()
        id_txt.Text = ""
        name_txt.Text = ""
        phone_txt.Text = ""
        email_txt.Text = ""
        pwd_txt.Text = ""
    End Sub

    Private Sub clear_bt_Click(sender As Object, e As EventArgs) Handles clear_bt.Click
        clear()
    End Sub
End Class