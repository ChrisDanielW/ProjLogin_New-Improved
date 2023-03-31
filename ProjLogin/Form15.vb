Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class Form15


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

    Private Sub Reset()
        ItemTab.EndEdit()
        ItemTab.DataSource = Nothing
        Fill()
    End Sub

    Private Sub Fill()
        Dim connString As String = "datasource=localhost; uid=root; pwd=Chs55432; database=plitdb"
        Dim con As New MySqlConnection(connString)
        con.Open()
        Dim cmd As New MySqlCommand("SELECT * from systemspec", con)
        Dim ad As New MySqlDataAdapter(cmd)
        Dim datatable As New DataTable
        ad.Fill(datatable)
        ItemTab.DataSource = datatable
    End Sub

    Private Sub ItemTab_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ItemTab.CellContentClick
        Dim ri As Integer = e.RowIndex
        If ri >= 0 Then
            uid_txt.Text = ItemTab.Rows(ri).Cells("us_id").Value.ToString()
            os_txt.Text = ItemTab.Rows(ri).Cells("s_os").Value.ToString()
            sstor_txt.Text = ItemTab.Rows(ri).Cells("s_storage").Value.ToString()
            ustor_txt.Text = ItemTab.Rows(ri).Cells("use_storage").Value.ToString()
            rstor_txt.Text = ItemTab.Rows(ri).Cells("rem_storage").Value.ToString()
            ram_txt.Text = ItemTab.Rows(ri).Cells("s_ram").Value.ToString()
            gpu_txt.Text = ItemTab.Rows(ri).Cells("s_gpu").Value.ToString()
            rate_txt.Text = ItemTab.Rows(ri).Cells("s_rate").Value.ToString()
            cpu_gen.Text = ItemTab.Rows(ri).Cells("s_cpugen").Value.ToString()
            cpubrand_txt.Text = ItemTab.Rows(ri).Cells("s_cpumfct").Value.ToString()
        End If
    End Sub

    Private Sub back_bt_Click(sender As Object, e As EventArgs) Handles back_bt.Click, back_pic.Click
        Form11.Show()
        Me.Close()
    End Sub

    Private Sub edit_bt_Click(sender As Object, e As EventArgs) Handles edit_bt.Click
        If uid_txt.Text = "" Or os_txt.Text = "" Or sstor_txt.Text = "" Or ustor_txt.Text = "" Or rstor_txt.Text = "" Or ram_txt.Text = "" Or gpu_txt.Text = "" Or rate_txt.Text = "" Or cpubrand_txt.Text = "" Or cpu_gen.Text = "" Then
            MessageBox.Show("Make sure all columns are specified")
        Else
            Dim connString As String = "datasource=localhost; uid=root; pwd=Chs55432; database=plitdb"
            Dim con As New MySqlConnection(connString)
            Dim cmd As New MySqlCommand("UPDATE systemspec set s_os = @v1, s_storage = @v2, use_storage = @v3, rem_storage = @v4, s_ram = @v5, s_gpu = @v6, s_rate = @v7, s_cpugen = @v8, s_cpumfct = @v9 where us_id = @v10", con)
            cmd.Parameters.AddWithValue("@v1", os_txt.Text)
            cmd.Parameters.AddWithValue("@v2", sstor_txt.Text)
            cmd.Parameters.AddWithValue("@v3", ustor_txt.Text)
            cmd.Parameters.AddWithValue("@v4", rstor_txt.Text)
            cmd.Parameters.AddWithValue("@v5", ram_txt.Text)
            cmd.Parameters.AddWithValue("@v6", gpu_txt.Text)
            cmd.Parameters.AddWithValue("@v7", rate_txt.Text)
            cmd.Parameters.AddWithValue("@v8", cpu_gen.Text)
            cmd.Parameters.AddWithValue("@v9", cpubrand_txt.Text)
            cmd.Parameters.AddWithValue("@v10", uid_txt.Text)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Successfully Edited System")
            Reset()
        End If
    End Sub

End Class