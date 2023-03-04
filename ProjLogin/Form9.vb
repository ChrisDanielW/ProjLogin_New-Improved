Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class Form9

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

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        del_bt.Visible = False
        Fill()
        If itemlist.Items.Count = 0 Then
            info_txt.Text = "There are no items in your cart"
        End If
    End Sub

    Private Sub itemlist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles itemlist.SelectedIndexChanged
        del_bt.Visible = True
        Dim item_sel As String = itemlist.SelectedItem.ToString()
        Dim connString As String = "datasource=localhost; uid=root; pwd=Chs55432; database=plitdb"
        Dim con As New MySqlConnection(connString)
        Dim cmd As New MySqlCommand("SELECT * from catalogue where itm_name = @v1", con)
        cmd.Parameters.AddWithValue("@v1", item_sel)
        con.Open()
        Using dr As MySqlDataReader = cmd.ExecuteReader
            If dr.Read() Then
                info_txt.Text = "Name: " + dr.GetString("itm_name") + vbCrLf +
                                "ID: " + dr.GetInt32("itm_id").ToString() + vbCrLf +
                                "Price: Rs. " + dr.GetInt32("itm_price").ToString()
            End If
        End Using
        con.Close()
        cmd.Parameters.Clear()
    End Sub

    Private Sub del_bt_Click(sender As Object, e As EventArgs) Handles del_bt.Click
        If MsgBox("Are you sure you want to delete this item from your cart", vbQuestion Or vbYesNo Or vbDefaultButton2, "Item Deletion") = vbYes Then
            Dim n As Integer = AllPub.Cart.Length()
            Dim j As Integer = itemlist.SelectedIndex
            Array.Copy(AllPub.Cart, j + 1, AllPub.Cart, j, n - j - 1)
            Array.Resize(AllPub.Cart, AllPub.Cart.Length - 1)
            del_bt.Visible = False
            info_txt.Text = ""
            MessageBox.Show("Item Deleted")
            itemlist.Items.Clear()
            Fill()
            If itemlist.Items.Count = 0 Then
                info_txt.Text = "There are no items in your cart"
            End If
        End If
    End Sub

    Private Sub Fill()
        Dim connString As String = "datasource=localhost; uid=root; pwd=Chs55432; database=plitdb"
        Dim con As New MySqlConnection(connString)
        Dim cmd As New MySqlCommand
        cmd.Connection = con
        con.Open()
        For i2 As Integer = 0 To AllPub.Cart.Length - 1
            cmd.CommandText = "SELECT * from catalogue where itm_id = @v1"
            cmd.Parameters.AddWithValue("@v1", AllPub.Cart(i2))
            Using dr As MySqlDataReader = cmd.ExecuteReader
                If dr.Read() Then
                    itemlist.Items.Add(dr.GetString("itm_name"))
                End If
            End Using
            cmd.Parameters.Clear()
        Next
        con.Close()
    End Sub

    Private Sub cont_bt_Click(sender As Object, e As EventArgs) Handles cont_bt.Click

        If itemlist.Items.Count = 0 Then
            MessageBox.Show("There are no items in your cart")

        ElseIf MsgBox("Do you wish to proceed to checkout with the items currently in your cart?)", vbQuestion Or vbYesNo Or vbDefaultButton2, "Proceed to Checkout") = vbYes Then
            Dim connString As String = "datasource=localhost; uid=root; pwd=Chs55432; database=plitdb"
            Dim con As New MySqlConnection(connString)
            Dim cmd As New MySqlCommand
            cmd.Connection = con
            Dim rnd As New Random()
            Dim itmid, itmprice, totprice, orderid As Integer
            totprice = 0
            Dim usid, usname, itmname, usphone As String 'crcard no next form
            usid = UserID
            Dim numbers As List(Of Integer) = Enumerable.Range(1000, 9000).ToList()
            numbers = numbers.OrderBy(Function() rnd.Next()).ToList()
            con.Open()
            MessageBox.Show(itemlist.Items.Count)
            For i2 As Integer = 0 To itemlist.Items.Count - 1
                cmd.CommandText = "SELECT * from catalogue where itm_id = @v1"
                cmd.Parameters.AddWithValue("@v1", AllPub.Cart(i2))
                Using dr As MySqlDataReader = cmd.ExecuteReader
                    If dr.Read() Then
                        itmid = AllPub.Cart(i2)
                        itmprice = dr.GetInt32("itm_price")
                        totprice += itmprice
                        orderid = numbers(i2)
                        itmname = dr.GetString("itm_name")
                    End If
                End Using
                cmd.Parameters.Clear()
                cmd.CommandText = "INSERT into checkout (itm_id, itm_price, order_id, itm_name) values (@v1, @v2, @v3, @v5); UPDATE checkout set total_price = @v4"
                cmd.Parameters.AddWithValue("@v1", itmid)
                cmd.Parameters.AddWithValue("@v2", itmprice)
                cmd.Parameters.AddWithValue("@v3", orderid)
                cmd.Parameters.AddWithValue("@v4", totprice)
                cmd.Parameters.AddWithValue("@v5", itmname)
                cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()
                cmd.CommandText = "SELECT * from user_reg where us_id = @v1"
                cmd.Parameters.AddWithValue("@v1", usid)
                Using dr As MySqlDataReader = cmd.ExecuteReader
                    If dr.Read() Then
                        usname = dr.GetString("us_name")
                        usphone = dr.GetString("us_phone")
                    End If
                End Using
                cmd.CommandText = "UPDATE checkout set us_id = @v1, us_name = @v2, us_phone = @v3"
                cmd.Parameters.AddWithValue("@v2", usname)
                cmd.Parameters.AddWithValue("@v3", usphone)
                cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()
            Next
            con.Close()
            Form7.Show()
            Me.Close()

        End If

    End Sub

End Class