Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices

Public Class Form14
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

    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fill()
    End Sub

    Private Sub Reset()
        ItemTab.EndEdit()
        ItemTab.DataSource = Nothing
        Fill()
    End Sub

    Private Sub Fill()
        Dim connString As String = "datasource=localhost; uid=root; pwd=Chs55432; database=plitdb"
        Dim con As New MySqlConnection(connString)
        con.Open()
        Dim cmd As New MySqlCommand("SELECT * from catalogue", con)
        Dim ad As New MySqlDataAdapter(cmd)
        Dim datatable As New DataTable
        ad.Fill(datatable)
        ItemTab.DataSource = datatable
    End Sub

    Private Sub ItemTab_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ItemTab.CellContentClick
        Dim ri As Integer = e.RowIndex
        If ri >= 0 Then
            id_txt.Text = ItemTab.Rows(ri).Cells("itm_id").Value.ToString()
            os_txt.Text = ItemTab.Rows(ri).Cells("i_os").Value.ToString()
            stor_txt.Text = ItemTab.Rows(ri).Cells("i_storage").Value.ToString()
            cpu_txt.Text = ItemTab.Rows(ri).Cells("i_cpu").Value.ToString()
            ram_txt.Text = ItemTab.Rows(ri).Cells("i_ram").Value.ToString()
            gpu_txt.Text = ItemTab.Rows(ri).Cells("i_gpu").Value.ToString()
            rate_txt.Text = ItemTab.Rows(ri).Cells("i_rate").Value.ToString()
            price_txt.Text = ItemTab.Rows(ri).Cells("itm_price").Value.ToString()
            name_txt.Text = ItemTab.Rows(ri).Cells("itm_name").Value.ToString()
        End If
    End Sub

    Private Sub edit_bt_Click(sender As Object, e As EventArgs) Handles edit_bt.Click
        If id_txt.Text = "" Or os_txt.Text = "" Or stor_txt.Text = "" Or ram_txt.Text = "" Or cpu_txt.Text = "" Or gpu_txt.Text = "" Or rate_txt.Text = "" Or name_txt.Text = "" Or price_txt.Text = "" Then
            MessageBox.Show("Make sure all columns are specified")
        Else
            Dim connString As String = "datasource=localhost; uid=root; pwd=Chs55432; database=plitdb"
            Dim con As New MySqlConnection(connString)
            Dim cmd As New MySqlCommand("UPDATE catalogue set i_os = @v1, i_storage = @v2, i_ram = @v3, i_cpu = @v4, i_gpu = @v6, i_rate = @v7, itm_price = @v8, itm_name = @v9  where itm_id = @v10", con)
            cmd.Parameters.AddWithValue("@v1", os_txt.Text)
            cmd.Parameters.AddWithValue("@v2", stor_txt.Text)
            cmd.Parameters.AddWithValue("@v3", ram_txt.Text)
            cmd.Parameters.AddWithValue("@v4", cpu_txt.Text)
            cmd.Parameters.AddWithValue("@v6", gpu_txt.Text)
            cmd.Parameters.AddWithValue("@v7", rate_txt.Text)
            cmd.Parameters.AddWithValue("@v8", price_txt.Text)
            cmd.Parameters.AddWithValue("@v9", name_txt.Text)
            cmd.Parameters.AddWithValue("@v10", id_txt.Text)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Successfully Edited Item")
            Reset()
        End If
    End Sub

    Private Sub back_bt_Click(sender As Object, e As EventArgs) Handles back_bt.Click, back_pic.Click
        Form11.Show()
        Me.Close()
    End Sub
End Class