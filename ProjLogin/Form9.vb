﻿Imports System.Runtime.InteropServices
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

    'Dim cart() As Integer = AllPub.Cart
    Dim ShowInfo As Boolean = True
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cart.Length > 0 Then
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
        Else
            info_txt.Text = "There are no items in your cart"
            ShowInfo = False
        End If

    End Sub

    Private Sub itemlist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles itemlist.SelectedIndexChanged
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
End Class