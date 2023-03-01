Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class Form6
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

    Dim f8 As New Form8()
    Dim us_id As String
    Dim itm_id As Integer
    Dim s_os As String
    Dim s_rate As Integer
    Dim HasGPU As Boolean
    Dim s_storage As Integer
    Dim i_rate As Integer
    Dim NeedsGPU As Boolean
    Dim i_storage As Integer
    Dim i_os As String
    'Public cart(50) As Integer
    'Dim i As Integer = 0

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        addcrt_bt.Visible = False

        us_id = UserID
        itm_id = ItemID
        Dim connString As String = "datasource=localhost; uid=root; pwd=Chs55432; database=plitdb"
        Dim con As New MySqlConnection(connString)
        con.Open()
        Dim cmd As New MySqlCommand("SELECT * from systemspec where us_id = @r1", con)
        cmd.Parameters.AddWithValue("@r1", us_id)
        Dim dr1 As MySqlDataReader = cmd.ExecuteReader
        If dr1.Read Then
            s_rate = dr1.GetInt32("s_rate")
            If dr1.GetString("s_gpu") = "NA" Then
                HasGPU = False
            Else
                HasGPU = True
            End If
            s_storage = dr1.GetInt32("rem_storage")
            s_os = dr1.GetString("s_os")
        End If
        dr1.Close()
        cmd.Parameters.Clear()
        cmd.CommandText = "SELECT * from catalogue where itm_id = @v1"
        cmd.Parameters.AddWithValue("@v1", itm_id)
        Dim dr2 As MySqlDataReader = cmd.ExecuteReader
        If dr2.Read Then
            i_rate = dr2.GetInt32("i_rate")
            If dr2.GetString("i_gpu") = "NA" Then
                NeedsGPU = False
            Else
                NeedsGPU = True
            End If
            i_storage = dr2.GetInt32("i_storage")
            i_os = dr2.GetString("i_os")
        End If
        dr2.Close()
        cmd.Parameters.Clear()
        con.Close()

        sysrat_lbl.Text = s_rate
        itmrat_lbl.Text = i_rate
        Dim sver, iver As Integer
        If s_os = "Windows 11" Or s_os = "Windows 10" Then
            sver = 9
        Else
            sver = Integer.Parse(s_os.Chars(8))
        End If
        If i_os = "Windows 10" Then
            iver = 9
        Else
            iver = Integer.Parse(s_os.Chars(8))
        End If

        If sver < iver Then
            verd_txt.Text = s_os.ToString + " is not supported by this product. Upgrade to a newer version of Windows"
        Else
            If s_storage < i_storage Then
                verd_txt.Text = "Your system lacks sufficient storage to install and properly run this product."
            Else
                If NeedsGPU = True Then
                    If HasGPU = True Then
                        If s_rate < i_rate Then
                            verd_txt.Text = "Your system is incapable of optimally running this product"
                        ElseIf s_rate = i_rate Then
                            verd_txt.Text = "Your system (just) meets the product's requirements"
                            addcrt_bt.Visible = True
                        Else
                            verd_txt.Text = "Your system should be able to run this product"
                            addcrt_bt.Visible = True
                        End If
                    Else
                        If s_rate < i_rate Then
                            verd_txt.Text = "Your system is incapable of optimally running this product"
                        ElseIf s_rate = i_rate Then
                            verd_txt.Text = "Your system appears to just meet the product's requirements but considering it's specifications and it's lack of a graphics card, it is not recommended to consider running this software on it. Try again after adding a dedicated graphics card to your system"
                        Else
                            verd_txt.Text = "Your system should be able to run this product. Consider adding a graphics card to your system to achieve optimal better performance"
                            addcrt_bt.Visible = True
                        End If
                    End If
                Else
                    If s_rate < i_rate Then
                        verd_txt.Text = "Your system is incapable of optimally running this product"
                    ElseIf s_rate = i_rate Then
                        verd_txt.Text = "Your system (just) meets the product's requirements"
                        addcrt_bt.Visible = True
                    Else
                        verd_txt.Text = "Your system should be able to run this product"
                        addcrt_bt.Visible = True
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub addcrt_bt_Click(sender As Object, e As EventArgs) Handles addcrt_bt.Click
        AllPub.Cart(AllPub.ind) = itm_id
        AllPub.ind += 1
        Form5.Close()
        Me.Close()
    End Sub

    Private Sub back_bt_Click(sender As Object, e As EventArgs) Handles back_bt.Click
        Form5.Close()
        Me.Close()
    End Sub

End Class