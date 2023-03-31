Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class Form10

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

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim name, email, phone, uid, iname As String
        Dim iprice, tprice As Integer
        Dim connString As String = "datasource=localhost; uid=root; pwd=Chs55432; database=plitdb"
        Dim con As New MySqlConnection(connString)
        Dim cmd As New MySqlCommand("SELECT * from checkout", con)
        con.Open()
        Using dr As MySqlDataReader = cmd.ExecuteReader
            If dr.Read() Then
                name = dr.GetString("us_name")
                phone = dr.GetString("us_phone")
                uid = dr.GetString("us_id")
                tprice = dr.GetInt32("total_price")
            End If
        End Using
        cmd.CommandText = "SELECT * from user_reg where us_id = @v1"
        cmd.Parameters.AddWithValue("@v1", uid)
        Using dr3 As MySqlDataReader = cmd.ExecuteReader
            If dr3.Read() Then
                email = dr3.GetString("us_email")
            End If
        End Using
        cmd.Parameters.Clear()

        name_lbl.Text = name
        email_lbl.Text = email
        id_lbl.Text = uid
        phone_lbl.Text = phone

        Dim ord As Integer
        For i As Integer = 0 To orders.Length
            If orders(i) = -1 Then
                Exit For
            End If
            ord = orders(i)
            cmd.CommandText = "SELECT * from checkout where order_id = @v1"
            cmd.Parameters.AddWithValue("@v1", ord)
            Using dr2 As MySqlDataReader = cmd.ExecuteReader
                If dr2.Read() Then
                    iname = dr2.GetString("itm_name")
                    iprice = dr2.GetInt32("itm_price")
                End If
            End Using
            item_list.Items.Add(iname)
            price_list.Items.Add(iprice)
            cmd.Parameters.Clear()
        Next
        tprice_lbl.Text = "Rs. " + tprice.ToString
        con.Close()

        If AllPub.ccno = "-1" Then
            MoneyBags.Visible = False
            card_lbl.Visible = False
        Else
            card_lbl.Text = AllPub.ccno
        End If

        AllPub.ino = item_list.Items.Count

    End Sub

    Private Sub cont_bt_Click(sender As Object, e As EventArgs) Handles cont_bt.Click
        Form12.Show()
        Me.Close()
    End Sub
End Class