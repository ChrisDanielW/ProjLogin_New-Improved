Imports MySql.Data.MySqlClient

Public Class Form9

    Dim cart As Integer() = Form6.cart
    Dim ShowInfo As Boolean = True
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cart.Length = 0 Then
            info_txt.Text = "There are no items in your cart"
            ShowInfo = False
        Else
            Dim connString As String = "datasource=localhost; uid=root; pwd=Chs55432; database=plitdb"
            Dim con As New MySqlConnection(connString)
            Dim cmd As New MySqlCommand
            cmd.Connection = con
            con.Open()
            For i As Integer = 0 To cart.Length
                cmd.CommandText = "SELECT * from catalogue where itm_id = @v1"
                cmd.Parameters.AddWithValue("@v1", cart(i))
                Using dr As MySqlDataReader = cmd.ExecuteReader
                    If dr.Read() Then
                        itemlist.Items.Add(dr.GetString("itm_name"))
                    End If
                End Using
                cmd.Parameters.Clear()
            Next
            con.Close()
        End If
    End Sub

    Private Sub itemlist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles itemlist.SelectedIndexChanged
        Dim item_sel As String = itemlist.SelectedValue
        Dim connString As String = "datasource=localhost; uid=root; pwd=Chs55432; database=plitdb"
        Dim con As New MySqlConnection(connString)
        Dim cmd As New MySqlCommand("SELECT * from catalogue where itm_name = @v1", con)
        cmd.Parameters.AddWithValue("@v1", item_sel)
        con.Open()
        Using dr As MySqlDataReader = cmd.ExecuteReader
            info_txt.Text = "Name: " + dr.GetString("itm_name") + vbCrLf +
                            "ID: " + dr.GetInt32("itm_id") + vbCrLf +
                            "Price: " + dr.GetInt32("itm_price")
        End Using
        con.Close()
        cmd.Parameters.Clear()
    End Sub
End Class