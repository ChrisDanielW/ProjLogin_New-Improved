Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class Form12

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
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub

    Private Sub report_bt_Click(sender As Object, e As EventArgs) Handles report_bt.Click
        Dim aid As String
        aid = InputBox("Enter your Admin ID")
        Dim con As New MySqlConnection("datasource=localhost; uid=root; pwd=Chs55432; database=plitdb; AllowUserVariables=True")
        con.Open()
        Dim cmd As New MySqlCommand("SELECT * from adm_login WHERE adm_id = @v1", con)
        cmd.Parameters.AddWithValue("@v1", aid)
        Dim dr As MySqlDataReader = cmd.ExecuteReader()
        If dr.Read Then
            If dr.GetString("adm_id") = aid Then
                Dim apd As String
                apd = InputBox("Enter your password")
                If dr.GetString("adm_pwd") = apd Then
                    MessageBox.Show("Authentication successful")
                    dr.Close()
                    con.Close()
                    cmd.Parameters.Clear()
                    Form13.Show()
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
            MessageBox.Show("The Admin ID entered does not exist")
        End If
    End Sub
End Class