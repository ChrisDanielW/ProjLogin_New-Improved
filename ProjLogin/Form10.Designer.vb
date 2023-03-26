<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form10))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cont_bt = New System.Windows.Forms.Button()
        Me.card_lbl = New System.Windows.Forms.Label()
        Me.MoneyBags = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.close_bt = New System.Windows.Forms.PictureBox()
        Me.mini_bt = New System.Windows.Forms.PictureBox()
        Me.fexit_bt = New System.Windows.Forms.PictureBox()
        Me.tprice_lbl = New System.Windows.Forms.Label()
        Me.phone_lbl = New System.Windows.Forms.Label()
        Me.email_lbl = New System.Windows.Forms.Label()
        Me.id_lbl = New System.Windows.Forms.Label()
        Me.name_lbl = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.price_list = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.item_list = New System.Windows.Forms.ListBox()
        Me.Panel1.SuspendLayout()
        CType(Me.close_bt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mini_bt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fexit_bt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.tprice_lbl)
        Me.Panel1.Controls.Add(Me.cont_bt)
        Me.Panel1.Controls.Add(Me.phone_lbl)
        Me.Panel1.Controls.Add(Me.card_lbl)
        Me.Panel1.Controls.Add(Me.MoneyBags)
        Me.Panel1.Controls.Add(Me.email_lbl)
        Me.Panel1.Controls.Add(Me.id_lbl)
        Me.Panel1.Controls.Add(Me.name_lbl)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.price_list)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.item_list)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(12, 80)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1062, 445)
        Me.Panel1.TabIndex = 49
        '
        'cont_bt
        '
        Me.cont_bt.BackColor = System.Drawing.Color.Silver
        Me.cont_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cont_bt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cont_bt.ForeColor = System.Drawing.Color.Black
        Me.cont_bt.Location = New System.Drawing.Point(931, 400)
        Me.cont_bt.Name = "cont_bt"
        Me.cont_bt.Size = New System.Drawing.Size(116, 29)
        Me.cont_bt.TabIndex = 48
        Me.cont_bt.Text = "Finalize Order"
        Me.cont_bt.UseVisualStyleBackColor = False
        '
        'card_lbl
        '
        Me.card_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.card_lbl.AutoSize = True
        Me.card_lbl.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.card_lbl.ForeColor = System.Drawing.Color.White
        Me.card_lbl.Location = New System.Drawing.Point(151, 401)
        Me.card_lbl.Name = "card_lbl"
        Me.card_lbl.Size = New System.Drawing.Size(121, 28)
        Me.card_lbl.TabIndex = 47
        Me.card_lbl.Text = "Placeholder"
        '
        'MoneyBags
        '
        Me.MoneyBags.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MoneyBags.AutoSize = True
        Me.MoneyBags.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MoneyBags.ForeColor = System.Drawing.Color.White
        Me.MoneyBags.Location = New System.Drawing.Point(18, 399)
        Me.MoneyBags.Name = "MoneyBags"
        Me.MoneyBags.Size = New System.Drawing.Size(129, 30)
        Me.MoneyBags.TabIndex = 39
        Me.MoneyBags.Text = "Credit Card:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 53)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Checkout"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(216, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 40)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "BIlling"
        '
        'close_bt
        '
        Me.close_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.close_bt.Image = CType(resources.GetObject("close_bt.Image"), System.Drawing.Image)
        Me.close_bt.Location = New System.Drawing.Point(1040, 12)
        Me.close_bt.Name = "close_bt"
        Me.close_bt.Size = New System.Drawing.Size(34, 30)
        Me.close_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.close_bt.TabIndex = 27
        Me.close_bt.TabStop = False
        '
        'mini_bt
        '
        Me.mini_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mini_bt.Image = CType(resources.GetObject("mini_bt.Image"), System.Drawing.Image)
        Me.mini_bt.Location = New System.Drawing.Point(999, 12)
        Me.mini_bt.Name = "mini_bt"
        Me.mini_bt.Size = New System.Drawing.Size(35, 30)
        Me.mini_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mini_bt.TabIndex = 28
        Me.mini_bt.TabStop = False
        '
        'fexit_bt
        '
        Me.fexit_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fexit_bt.Image = CType(resources.GetObject("fexit_bt.Image"), System.Drawing.Image)
        Me.fexit_bt.Location = New System.Drawing.Point(958, 12)
        Me.fexit_bt.Name = "fexit_bt"
        Me.fexit_bt.Size = New System.Drawing.Size(35, 30)
        Me.fexit_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fexit_bt.TabIndex = 29
        Me.fexit_bt.TabStop = False
        '
        'tprice_lbl
        '
        Me.tprice_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tprice_lbl.AutoSize = True
        Me.tprice_lbl.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tprice_lbl.ForeColor = System.Drawing.Color.White
        Me.tprice_lbl.Location = New System.Drawing.Point(801, 342)
        Me.tprice_lbl.Name = "tprice_lbl"
        Me.tprice_lbl.Size = New System.Drawing.Size(125, 28)
        Me.tprice_lbl.TabIndex = 59
        Me.tprice_lbl.Text = "Placeholder"
        '
        'phone_lbl
        '
        Me.phone_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.phone_lbl.AutoSize = True
        Me.phone_lbl.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.phone_lbl.ForeColor = System.Drawing.Color.White
        Me.phone_lbl.Location = New System.Drawing.Point(190, 173)
        Me.phone_lbl.Name = "phone_lbl"
        Me.phone_lbl.Size = New System.Drawing.Size(122, 28)
        Me.phone_lbl.TabIndex = 58
        Me.phone_lbl.Text = "Placeholder"
        '
        'email_lbl
        '
        Me.email_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.email_lbl.AutoSize = True
        Me.email_lbl.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.email_lbl.ForeColor = System.Drawing.Color.White
        Me.email_lbl.Location = New System.Drawing.Point(190, 121)
        Me.email_lbl.Name = "email_lbl"
        Me.email_lbl.Size = New System.Drawing.Size(122, 28)
        Me.email_lbl.TabIndex = 57
        Me.email_lbl.Text = "Placeholder"
        '
        'id_lbl
        '
        Me.id_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.id_lbl.AutoSize = True
        Me.id_lbl.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.id_lbl.ForeColor = System.Drawing.Color.White
        Me.id_lbl.Location = New System.Drawing.Point(190, 70)
        Me.id_lbl.Name = "id_lbl"
        Me.id_lbl.Size = New System.Drawing.Size(122, 28)
        Me.id_lbl.TabIndex = 56
        Me.id_lbl.Text = "Placeholder"
        '
        'name_lbl
        '
        Me.name_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.name_lbl.AutoSize = True
        Me.name_lbl.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.name_lbl.ForeColor = System.Drawing.Color.White
        Me.name_lbl.Location = New System.Drawing.Point(190, 20)
        Me.name_lbl.Name = "name_lbl"
        Me.name_lbl.Size = New System.Drawing.Size(122, 28)
        Me.name_lbl.TabIndex = 55
        Me.name_lbl.Text = "Placeholder"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(524, 340)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(271, 30)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Total Amount to be paid:"
        '
        'price_list
        '
        Me.price_list.BackColor = System.Drawing.Color.MidnightBlue
        Me.price_list.ForeColor = System.Drawing.Color.White
        Me.price_list.FormattingEnabled = True
        Me.price_list.ItemHeight = 20
        Me.price_list.Location = New System.Drawing.Point(687, 225)
        Me.price_list.Name = "price_list"
        Me.price_list.Size = New System.Drawing.Size(239, 104)
        Me.price_list.TabIndex = 53
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(24, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 30)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Email Addresss:"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(97, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 30)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "User ID:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(110, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 30)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Name:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(21, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 30)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Phone Number:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 30)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Items Purchased:"
        '
        'item_list
        '
        Me.item_list.BackColor = System.Drawing.Color.MidnightBlue
        Me.item_list.ForeColor = System.Drawing.Color.White
        Me.item_list.FormattingEnabled = True
        Me.item_list.ItemHeight = 20
        Me.item_list.Location = New System.Drawing.Point(192, 225)
        Me.item_list.Name = "item_list"
        Me.item_list.Size = New System.Drawing.Size(466, 104)
        Me.item_list.TabIndex = 47
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1086, 537)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.fexit_bt)
        Me.Controls.Add(Me.mini_bt)
        Me.Controls.Add(Me.close_bt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form10"
        Me.Text = "Form10"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.close_bt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mini_bt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fexit_bt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents tprice_lbl As Label
    Friend WithEvents cont_bt As Button
    Friend WithEvents phone_lbl As Label
    Friend WithEvents card_lbl As Label
    Friend WithEvents MoneyBags As Label
    Friend WithEvents email_lbl As Label
    Friend WithEvents id_lbl As Label
    Friend WithEvents name_lbl As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents price_list As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents item_list As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents close_bt As PictureBox
    Friend WithEvents mini_bt As PictureBox
    Friend WithEvents fexit_bt As PictureBox
End Class
