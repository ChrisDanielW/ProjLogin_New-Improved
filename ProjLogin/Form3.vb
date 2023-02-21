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
    End Sub

    Public HasGPU As Boolean
    Public SysRate As Double

    Private Sub int_rad_CheckedChanged(sender As Object, e As EventArgs) Handles int_rad.CheckedChanged, ded_rad.CheckedChanged
        If int_rad.Checked = True Then
            HasGPU = False
            gpu_ded.Visible = False
        ElseIf ded_rad.Checked = True Then
            HasGPU = True
            gpu_ded.Visible = True
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
                SysRate += 1
            ElseIf cpumfct_txt.Text = "Intel i5" Then
                SysRate += 1.5
            Else
                SysRate += 2.5
            End If

            If cpugen_txt.Text = "1st" Or cpugen_txt.Text = "2nd" Or cpugen_txt.Text = "3rd" Then
                SysRate += 0
            ElseIf cpugen_txt.Text = "4th" Or cpugen_txt.Text = "5th" Or cpugen_txt.Text = "6th" Then
                SysRate += 1
            ElseIf cpugen_txt.Text = "7th" Or cpugen_txt.Text = "8th" Or cpugen_txt.Text = "9th" Then
                SysRate += 2
            ElseIf cpugen_txt.Text = "10th" Or cpugen_txt.Text = "11th" Then
                SysRate += 2.5
            Else
                SysRate += 3
            End If
        End If

        If HasAMD = True Then
            If cpumfct_txt.Text = "AMD Ryzen 3" Then
                SysRate += 1
            ElseIf cpumfct_txt.Text = "AMD Ryzen 5" Then
                SysRate += 1.5
            Else
                SysRate += 2.5
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

        sysrate_lbl.Text = SysRate.ToString("0.0") + "/10"

    End Sub

End Class