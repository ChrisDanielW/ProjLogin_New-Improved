Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class Form3

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

    Private Sub cpu_lbl_hover(sender As Object, e As EventArgs) Handles cpu_lbl.MouseHover
        descrip_txt.Text = "A central processing unit (CPU), also called a central processor, main processor or just processor, is the electronic circuitry that executes instructions comprising a computer program. It is essentially the brain of your computer. Please enter your CPU's manufacturer and sub brand as well as its generation in the provided inputs."
    End Sub
    Private Sub os_lbl_hover(sender As Object, e As EventArgs) Handles os_lbl.MouseHover
        descrip_txt.Text = "An operating system (OS) is system software that manages computer hardware, software resources, and provides common services for computer programs. Please enter your operating system in the provided input."
    End Sub
    Private Sub ram_lbl_hover(sender As Object, e As EventArgs) Handles ram_lbl.MouseHover
        descrip_txt.Text = "RAM (Random Access Memory) is the hardware in a computing device where the operating system (OS), application programs and data in current use are kept so they can be quickly reached by the device's processor. RAM is your computer's main or primary memory. Please enter your system's total RAM in the provided input."
    End Sub
    Private Sub storage_lbl_hover(sender As Object, e As EventArgs) Handles storage_lbl.MouseHover
        descrip_txt.Text = "Computer data storage is a technology consisting of computer components and recording media that are used to retain digital data. It is a core function and fundamental component of computers. Please enter your system's total as well as used storage in the provided inputs."
    End Sub
    Private Sub gpu_lbl_hover(sender As Object, e As EventArgs) Handles gpu_lbl.MouseHover
        descrip_txt.Text = "A graphics processing unit (GPU) is a specialized electronic circuit designed to manipulate and alter memory to accelerate the creation of images in a frame buffer intended for output to a display device. Please enter the name of your GPU in the provided input"
    End Sub
    Private Sub hoverrefresh(sender As Object, e As EventArgs) Handles GroupBox1.MouseHover
        descrip_txt.Text = ""
    End Sub


    Dim HasIntel As Boolean
    Dim HasAMD As Boolean
    Private Sub cpumfct_txt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cpumfct_txt.SelectedIndexChanged
        HasIntel = False
        HasAMD = False
        cpugen_txt.Items.Clear()
        If cpumfct_txt.Text = "Intel i3" Or cpumfct_txt.Text = "Intel i5" Or cpumfct_txt.Text = "Intel i7" Then
            HasIntel = True
            cpugen_txt.Items.Add("1st")
            cpugen_txt.Items.Add("2nd")
            cpugen_txt.Items.Add("3rd")
            cpugen_txt.Items.Add("4th")
            cpugen_txt.Items.Add("5th")
            cpugen_txt.Items.Add("6th")
            cpugen_txt.Items.Add("7th")
            cpugen_txt.Items.Add("8th")
            cpugen_txt.Items.Add("9th")
            cpugen_txt.Items.Add("10th")
            cpugen_txt.Items.Add("11th")
            cpugen_txt.Items.Add("12th")
            cpugen_txt.Items.Add("13th")
        ElseIf cpumfct_txt.Text = "AMD Ryzen 3" Or cpumfct_txt.Text = "AMD Ryzen 5" Or cpumfct_txt.Text = "AMD Ryzen 7" Then
            HasAMD = True
            cpugen_txt.Items.Add("1st")
            cpugen_txt.Items.Add("2nd")
            cpugen_txt.Items.Add("3rd")
            cpugen_txt.Items.Add("4th")
            cpugen_txt.Items.Add("5th")
            cpugen_txt.Items.Add("6th")
            cpugen_txt.Items.Add("7th")
        End If
        If HasIntel = False And HasAMD = False Then
            cpugen_txt.Text = "-1"
        End If
    End Sub

    Public HasGPU As Boolean
    Public SysRate As Double = -1

    Private Sub int_rad_CheckedChanged(sender As Object, e As EventArgs) Handles int_rad.CheckedChanged, ded_rad.CheckedChanged
        If int_rad.Checked = True Then
            HasGPU = False
            gpu_ded.Visible = False
            gpu_ded_lbl.Visible = False
        ElseIf ded_rad.Checked = True Then
            HasGPU = True
            gpu_ded.Visible = True
            gpu_ded_lbl.Visible = True
        End If
    End Sub

    Private Sub calc_bt_Click(sender As Object, e As EventArgs) Handles calc_bt.Click

        SysRate = 0
        sysrate_lbl.Text = ""

        If HasGPU = True Then
            SysRate += 3
        End If

        If ram_box.Text = "2" Then
            SysRate += 0.5
        ElseIf ram_box.Text = "4" Then
            SysRate += 1
        ElseIf ram_box.Text = "8" Or "12" Then
            SysRate += 1.5
        ElseIf ram_box.Text = "16" Then
            SysRate += 2
        Else
            SysRate += 2.5
        End If

        If HasIntel = True Then
            If cpumfct_txt.Text = "Intel i3" Then
                SysRate += 0.5
            ElseIf cpumfct_txt.Text = "Intel i5" Then
                SysRate += 1
            Else
                SysRate += 2
            End If

            If cpugen_txt.Text = "1st" Or cpugen_txt.Text = "2nd" Or cpugen_txt.Text = "3rd" Then
                SysRate += 0
            ElseIf cpugen_txt.Text = "4th" Or cpugen_txt.Text = "5th" Or cpugen_txt.Text = "6th" Or cpugen_txt.Text = "7th " Then
                SysRate += 1
            ElseIf cpugen_txt.Text = "8th" Or cpugen_txt.Text = "9th" Or cpugen_txt.Text = "10th" Then
                SysRate += 2
            Else
                SysRate += 3
            End If
        End If

        If HasAMD = True Then
            If cpumfct_txt.Text = "AMD Ryzen 3" Then
                SysRate += 0.5
            ElseIf cpumfct_txt.Text = "AMD Ryzen 5" Then
                SysRate += 1
            Else
                SysRate += 2
            End If

            If cpugen_txt.Text = "1st" Or cpugen_txt.Text = "2nd" Then
                SysRate += 1
            ElseIf cpugen_txt.Text = "3rd" Or cpugen_txt.Text = "4th" Or cpugen_txt.Text = "5th" Then
                SysRate += 2
            Else
                SysRate += 3
            End If
        End If

        If HasAMD = False And HasIntel = False Then
            SysRate += 0.5
        End If

        sysrate_lbl.Text = SysRate.ToString + "/10"

        cont_bt.Visible = True

    End Sub

    Dim remStore As Integer

    Private Sub clear_bt_Click(sender As Object, e As EventArgs) Handles clear_bt.Click
        os_txt.Text = ""
        ram_box.Text = ""
        cpumfct_txt.Text = ""
        cpugen_txt.Text = ""
        storage_tot_txt.Text = ""
        storage_use_txt.Text = ""
        gpu_int.Text = ""
        gpu_ded.Text = ""
        int_rad.Checked = False
        ded_rad.Checked = False
        sysrate_lbl.Text = ""
        cont_bt.Visible = False
        remStore = 0
    End Sub

    Private Sub cont_bt_Click(sender As Object, e As EventArgs) Handles cont_bt.Click
        Dim CanEdit As Boolean = True
        If os_txt.Text = "" Or
           ram_box.Text = "" Or
           cpumfct_txt.Text = "" Or
           cpugen_txt.Text = "" Or
           storage_tot_txt.Text = "" Or
           storage_use_txt.Text = "" Or
           gpu_int.Text = "" Or
           gpu_ded.Text = "" Or
           (int_rad.Checked = False And
           ded_rad.Checked = False) Then
            MessageBox.Show("Please enter all the required details")
        ElseIf SysRate = -1 Or SysRate = 0 Then
            MessageBox.Show("Please calculate your system's rating")
        Else
            remStore = Convert.ToInt32(storage_tot_txt.Text) - Convert.ToInt32(storage_use_txt.Text)
            Dim connString As String = "datasource=localhost; uid=root; pwd=Chs55432; database=plitdb"
            Dim con As New MySqlConnection(connString)
            con.Open()
            Dim cmd As New MySqlCommand("SELECT * from systemspec where us_id = @r1", con)
            cmd.Parameters.AddWithValue("@r1", us_id)
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            If dr.HasRows Then
                If MsgBox("A system already seems to be registered under your user ID, would you like to edit it?", vbQuestion Or vbYesNo Or vbDefaultButton2, "Full Exit") = vbNo Then
                    CanEdit = False
                    skip_bt.Visible = True
                    dr.Close()
                Else
                    dr.Close()
                    cmd.CommandText = "DELETE from systemspec where us_id = @r1"
                    cmd.ExecuteNonQuery()
                End If
            End If
            con.Close()
            cmd.Parameters.Clear()
            If CanEdit = True Then
                cmd.CommandText = "INSERT into systemspec (us_id, s_os, s_storage, use_storage, rem_storage, s_ram, s_gpu, s_rate, s_cpugen, s_cpumfct) values (@v1, @v2, @v3, @v4, @v5, @v6, @v7, @v8, @v9, @v10)"
                cmd.Parameters.AddWithValue("@v1", us_id)
                cmd.Parameters.AddWithValue("@v2", os_txt.Text)
                cmd.Parameters.AddWithValue("@v3", Convert.ToInt32(storage_tot_txt.Text))
                cmd.Parameters.AddWithValue("@v4", Convert.ToInt32(storage_use_txt.Text))
                cmd.Parameters.AddWithValue("@v5", remStore)
                cmd.Parameters.AddWithValue("@v6", Convert.ToInt32(ram_box.Text))
                cmd.Parameters.AddWithValue("@v7", gpu_ded.Text)
                cmd.Parameters.AddWithValue("@v8", SysRate)
                cmd.Parameters.AddWithValue("@v9", cpugen_txt.Text)
                cmd.Parameters.AddWithValue("@v10", cpumfct_txt.Text)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                cmd.Parameters.Clear()
            Else
                MessageBox.Show("System registration cancelled")
            End If
        End If
    End Sub

    Dim us_id As String
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        us_id = Form8.UserID
        skip_bt.Visible = False
        cont_bt.Visible = False
        gpu_ded.Visible = False
        gpu_ded_lbl.Visible = False
    End Sub
End Class