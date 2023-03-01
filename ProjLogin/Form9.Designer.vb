<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.itemlist = New System.Windows.Forms.ListBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.info_txt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cont_bt = New System.Windows.Forms.Button()
        Me.fexit_bt = New System.Windows.Forms.PictureBox()
        Me.mini_bt = New System.Windows.Forms.PictureBox()
        Me.close_bt = New System.Windows.Forms.PictureBox()
        Me.del_bt = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.fexit_bt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mini_bt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.close_bt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 53)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "CART"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'itemlist
        '
        Me.itemlist.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.itemlist.BackColor = System.Drawing.Color.Navy
        Me.itemlist.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.itemlist.ForeColor = System.Drawing.Color.White
        Me.itemlist.FormattingEnabled = True
        Me.itemlist.ItemHeight = 20
        Me.itemlist.Location = New System.Drawing.Point(3, 3)
        Me.itemlist.Name = "itemlist"
        Me.itemlist.Size = New System.Drawing.Size(477, 220)
        Me.itemlist.TabIndex = 22
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Navy
        Me.FlowLayoutPanel1.Controls.Add(Me.itemlist)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 92)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(494, 231)
        Me.FlowLayoutPanel1.TabIndex = 24
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.info_txt)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(530, 92)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(568, 231)
        Me.Panel2.TabIndex = 25
        '
        'info_txt
        '
        Me.info_txt.BackColor = System.Drawing.Color.Black
        Me.info_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.info_txt.ForeColor = System.Drawing.Color.White
        Me.info_txt.Location = New System.Drawing.Point(10, 62)
        Me.info_txt.Multiline = True
        Me.info_txt.Name = "info_txt"
        Me.info_txt.PlaceholderText = "Click on any of your items"
        Me.info_txt.ReadOnly = True
        Me.info_txt.Size = New System.Drawing.Size(555, 166)
        Me.info_txt.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(179, 38)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Information:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cont_bt
        '
        Me.cont_bt.AutoSize = True
        Me.cont_bt.BackColor = System.Drawing.Color.Silver
        Me.cont_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cont_bt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cont_bt.ForeColor = System.Drawing.Color.Black
        Me.cont_bt.Location = New System.Drawing.Point(935, 344)
        Me.cont_bt.Name = "cont_bt"
        Me.cont_bt.Size = New System.Drawing.Size(163, 30)
        Me.cont_bt.TabIndex = 29
        Me.cont_bt.Text = "Proceed to Chekout"
        Me.cont_bt.UseVisualStyleBackColor = False
        '
        'fexit_bt
        '
        Me.fexit_bt.Image = CType(resources.GetObject("fexit_bt.Image"), System.Drawing.Image)
        Me.fexit_bt.Location = New System.Drawing.Point(982, 12)
        Me.fexit_bt.Name = "fexit_bt"
        Me.fexit_bt.Size = New System.Drawing.Size(35, 30)
        Me.fexit_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fexit_bt.TabIndex = 32
        Me.fexit_bt.TabStop = False
        '
        'mini_bt
        '
        Me.mini_bt.Image = CType(resources.GetObject("mini_bt.Image"), System.Drawing.Image)
        Me.mini_bt.Location = New System.Drawing.Point(1023, 12)
        Me.mini_bt.Name = "mini_bt"
        Me.mini_bt.Size = New System.Drawing.Size(35, 30)
        Me.mini_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mini_bt.TabIndex = 31
        Me.mini_bt.TabStop = False
        '
        'close_bt
        '
        Me.close_bt.Image = CType(resources.GetObject("close_bt.Image"), System.Drawing.Image)
        Me.close_bt.Location = New System.Drawing.Point(1064, 12)
        Me.close_bt.Name = "close_bt"
        Me.close_bt.Size = New System.Drawing.Size(34, 30)
        Me.close_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.close_bt.TabIndex = 30
        Me.close_bt.TabStop = False
        '
        'del_bt
        '
        Me.del_bt.AutoSize = True
        Me.del_bt.BackColor = System.Drawing.Color.Silver
        Me.del_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.del_bt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.del_bt.ForeColor = System.Drawing.Color.Black
        Me.del_bt.Location = New System.Drawing.Point(12, 329)
        Me.del_bt.Name = "del_bt"
        Me.del_bt.Size = New System.Drawing.Size(135, 30)
        Me.del_bt.TabIndex = 33
        Me.del_bt.Text = "Delete from cart"
        Me.del_bt.UseVisualStyleBackColor = False
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(1110, 385)
        Me.Controls.Add(Me.del_bt)
        Me.Controls.Add(Me.fexit_bt)
        Me.Controls.Add(Me.mini_bt)
        Me.Controls.Add(Me.close_bt)
        Me.Controls.Add(Me.cont_bt)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form9"
        Me.Text = "Form9"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.fexit_bt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mini_bt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.close_bt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents itemlist As ListBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents info_txt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cont_bt As Button
    Friend WithEvents fexit_bt As PictureBox
    Friend WithEvents mini_bt As PictureBox
    Friend WithEvents close_bt As PictureBox
    Friend WithEvents del_bt As Button
End Class
