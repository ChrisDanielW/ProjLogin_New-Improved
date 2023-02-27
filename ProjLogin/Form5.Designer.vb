<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.mini_bt = New System.Windows.Forms.PictureBox()
        Me.close_bt = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.price_lbl = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Display_name = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.storage_txt = New System.Windows.Forms.TextBox()
        Me.gpu_lbl = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gpu_txt = New System.Windows.Forms.TextBox()
        Me.cpu_txt = New System.Windows.Forms.TextBox()
        Me.ram_txt = New System.Windows.Forms.TextBox()
        Me.os_txt = New System.Windows.Forms.TextBox()
        Me.fexit_bt = New System.Windows.Forms.PictureBox()
        Me.rate_lbl = New System.Windows.Forms.Label()
        CType(Me.mini_bt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.close_bt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.fexit_bt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mini_bt
        '
        Me.mini_bt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mini_bt.Image = CType(resources.GetObject("mini_bt.Image"), System.Drawing.Image)
        Me.mini_bt.Location = New System.Drawing.Point(874, 12)
        Me.mini_bt.Name = "mini_bt"
        Me.mini_bt.Size = New System.Drawing.Size(35, 30)
        Me.mini_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mini_bt.TabIndex = 13
        Me.mini_bt.TabStop = False
        '
        'close_bt
        '
        Me.close_bt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.close_bt.Image = CType(resources.GetObject("close_bt.Image"), System.Drawing.Image)
        Me.close_bt.Location = New System.Drawing.Point(915, 12)
        Me.close_bt.Name = "close_bt"
        Me.close_bt.Size = New System.Drawing.Size(34, 30)
        Me.close_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.close_bt.TabIndex = 12
        Me.close_bt.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(25, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 53)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Requirements"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Indigo
        Me.Panel1.Controls.Add(Me.rate_lbl)
        Me.Panel1.Controls.Add(Me.price_lbl)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Display_name)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(23, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(910, 385)
        Me.Panel1.TabIndex = 15
        '
        'price_lbl
        '
        Me.price_lbl.AutoSize = True
        Me.price_lbl.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.price_lbl.ForeColor = System.Drawing.Color.White
        Me.price_lbl.Location = New System.Drawing.Point(740, 134)
        Me.price_lbl.Name = "price_lbl"
        Me.price_lbl.Size = New System.Drawing.Size(145, 32)
        Me.price_lbl.TabIndex = 18
        Me.price_lbl.Text = "PlaceHolder"
        Me.price_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(792, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 40)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Price:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Display_name
        '
        Me.Display_name.AutoSize = True
        Me.Display_name.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 13.9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Display_name.ForeColor = System.Drawing.Color.White
        Me.Display_name.Location = New System.Drawing.Point(45, 26)
        Me.Display_name.Name = "Display_name"
        Me.Display_name.Size = New System.Drawing.Size(83, 32)
        Me.Display_name.TabIndex = 24
        Me.Display_name.Text = "Label7"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Silver
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(798, 334)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 29)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Next"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(705, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 40)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Item Rating:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.storage_txt)
        Me.GroupBox1.Controls.Add(Me.gpu_lbl)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.gpu_txt)
        Me.GroupBox1.Controls.Add(Me.cpu_txt)
        Me.GroupBox1.Controls.Add(Me.ram_txt)
        Me.GroupBox1.Controls.Add(Me.os_txt)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(45, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(597, 270)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Requirements"
        '
        'storage_txt
        '
        Me.storage_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.storage_txt.ForeColor = System.Drawing.Color.White
        Me.storage_txt.Location = New System.Drawing.Point(236, 128)
        Me.storage_txt.Name = "storage_txt"
        Me.storage_txt.ReadOnly = True
        Me.storage_txt.Size = New System.Drawing.Size(313, 27)
        Me.storage_txt.TabIndex = 17
        '
        'gpu_lbl
        '
        Me.gpu_lbl.AutoSize = True
        Me.gpu_lbl.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.gpu_lbl.ForeColor = System.Drawing.Color.White
        Me.gpu_lbl.Location = New System.Drawing.Point(31, 207)
        Me.gpu_lbl.Name = "gpu_lbl"
        Me.gpu_lbl.Size = New System.Drawing.Size(199, 23)
        Me.gpu_lbl.TabIndex = 12
        Me.gpu_lbl.Text = "Graphics Processing Unit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(42, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(188, 23)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Central Processing Unit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(161, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 23)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Storage"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(182, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "RAM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(83, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Operating System"
        '
        'gpu_txt
        '
        Me.gpu_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gpu_txt.ForeColor = System.Drawing.Color.White
        Me.gpu_txt.Location = New System.Drawing.Point(236, 210)
        Me.gpu_txt.Name = "gpu_txt"
        Me.gpu_txt.ReadOnly = True
        Me.gpu_txt.Size = New System.Drawing.Size(313, 27)
        Me.gpu_txt.TabIndex = 5
        '
        'cpu_txt
        '
        Me.cpu_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cpu_txt.ForeColor = System.Drawing.Color.White
        Me.cpu_txt.Location = New System.Drawing.Point(236, 168)
        Me.cpu_txt.Name = "cpu_txt"
        Me.cpu_txt.ReadOnly = True
        Me.cpu_txt.Size = New System.Drawing.Size(313, 27)
        Me.cpu_txt.TabIndex = 4
        '
        'ram_txt
        '
        Me.ram_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ram_txt.ForeColor = System.Drawing.Color.White
        Me.ram_txt.Location = New System.Drawing.Point(236, 88)
        Me.ram_txt.Name = "ram_txt"
        Me.ram_txt.ReadOnly = True
        Me.ram_txt.Size = New System.Drawing.Size(313, 27)
        Me.ram_txt.TabIndex = 1
        '
        'os_txt
        '
        Me.os_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.os_txt.ForeColor = System.Drawing.Color.White
        Me.os_txt.Location = New System.Drawing.Point(236, 46)
        Me.os_txt.Name = "os_txt"
        Me.os_txt.ReadOnly = True
        Me.os_txt.Size = New System.Drawing.Size(313, 27)
        Me.os_txt.TabIndex = 0
        '
        'fexit_bt
        '
        Me.fexit_bt.Image = CType(resources.GetObject("fexit_bt.Image"), System.Drawing.Image)
        Me.fexit_bt.Location = New System.Drawing.Point(833, 12)
        Me.fexit_bt.Name = "fexit_bt"
        Me.fexit_bt.Size = New System.Drawing.Size(35, 30)
        Me.fexit_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fexit_bt.TabIndex = 25
        Me.fexit_bt.TabStop = False
        '
        'rate_lbl
        '
        Me.rate_lbl.AutoSize = True
        Me.rate_lbl.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rate_lbl.ForeColor = System.Drawing.Color.White
        Me.rate_lbl.Location = New System.Drawing.Point(740, 236)
        Me.rate_lbl.Name = "rate_lbl"
        Me.rate_lbl.Size = New System.Drawing.Size(145, 32)
        Me.rate_lbl.TabIndex = 26
        Me.rate_lbl.Text = "PlaceHolder"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(961, 492)
        Me.Controls.Add(Me.fexit_bt)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mini_bt)
        Me.Controls.Add(Me.close_bt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.mini_bt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.close_bt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.fexit_bt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mini_bt As PictureBox
    Friend WithEvents close_bt As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents storage_txt As TextBox
    Friend WithEvents gpu_lbl As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents gpu_txt As TextBox
    Friend WithEvents cpu_txt As TextBox
    Friend WithEvents ram_txt As TextBox
    Friend WithEvents os_txt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents fexit_bt As PictureBox
    Friend WithEvents Display_name As Label
    Friend WithEvents price_lbl As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents rate_lbl As Label
End Class
