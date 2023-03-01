Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class Form5


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

    Dim itm_id As String
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        itm_id = ItemID
        Dim connString As String = "datasource=localhost; uid=root; pwd=Chs55432; database=plitdb"
        Dim con As New MySqlConnection(connString)
        con.Open()
        Dim cmd As New MySqlCommand("SELECT * from catalogue where itm_id = @v1", con)
        cmd.Parameters.AddWithValue("@v1", itm_id)
        Using dr As MySqlDataReader = cmd.ExecuteReader
            If dr.Read() Then
                Display_name.Text = dr.GetString("itm_name")
                price_lbl.Text = "Rs. " + dr.GetInt32("itm_price").ToString
                os_txt.Text = dr.GetString("i_os")
                ram_txt.Text = dr.GetString("i_ram")
                storage_txt.Text = dr.GetInt32("i_storage")
                cpu_txt.Text = dr.GetString("i_cpu")
                rate_lbl.Text = dr.GetInt32("i_rate").ToString + "/10"
                If dr.GetString("i_gpu") = "NA" Then
                    gpu_txt.Visible = False
                    gpu_lbl.Visible = False
                Else
                    gpu_txt.Text = dr.GetString("i_gpu")
                End If
            End If
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form6.Show()
        Me.Close()
    End Sub
End Class