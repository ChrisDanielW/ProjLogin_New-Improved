<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form11))
        Me.user_pic = New System.Windows.Forms.PictureBox()
        Me.user_bt = New System.Windows.Forms.Button()
        Me.sys_pic = New System.Windows.Forms.PictureBox()
        Me.sys_bt = New System.Windows.Forms.Button()
        Me.item_pic = New System.Windows.Forms.PictureBox()
        Me.item_bt = New System.Windows.Forms.Button()
        Me.fexit_bt = New System.Windows.Forms.PictureBox()
        Me.mini_bt = New System.Windows.Forms.PictureBox()
        Me.close_bt = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.user_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sys_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fexit_bt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mini_bt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.close_bt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'user_pic
        '
        Me.user_pic.Image = CType(resources.GetObject("user_pic.Image"), System.Drawing.Image)
        Me.user_pic.Location = New System.Drawing.Point(90, 231)
        Me.user_pic.Name = "user_pic"
        Me.user_pic.Size = New System.Drawing.Size(246, 220)
        Me.user_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.user_pic.TabIndex = 26
        Me.user_pic.TabStop = False
        '
        'user_bt
        '
        Me.user_bt.BackColor = System.Drawing.Color.Transparent
        Me.user_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.user_bt.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.user_bt.Location = New System.Drawing.Point(74, 213)
        Me.user_bt.Name = "user_bt"
        Me.user_bt.Size = New System.Drawing.Size(275, 274)
        Me.user_bt.TabIndex = 27
        Me.user_bt.Text = "User Credentials"
        Me.user_bt.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.user_bt.UseVisualStyleBackColor = False
        '
        'sys_pic
        '
        Me.sys_pic.Image = CType(resources.GetObject("sys_pic.Image"), System.Drawing.Image)
        Me.sys_pic.Location = New System.Drawing.Point(434, 231)
        Me.sys_pic.Name = "sys_pic"
        Me.sys_pic.Size = New System.Drawing.Size(246, 220)
        Me.sys_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.sys_pic.TabIndex = 28
        Me.sys_pic.TabStop = False
        '
        'sys_bt
        '
        Me.sys_bt.BackColor = System.Drawing.Color.Transparent
        Me.sys_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.sys_bt.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.sys_bt.Location = New System.Drawing.Point(418, 213)
        Me.sys_bt.Name = "sys_bt"
        Me.sys_bt.Size = New System.Drawing.Size(275, 274)
        Me.sys_bt.TabIndex = 29
        Me.sys_bt.Text = "System Specifications"
        Me.sys_bt.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.sys_bt.UseVisualStyleBackColor = False
        '
        'item_pic
        '
        Me.item_pic.Image = CType(resources.GetObject("item_pic.Image"), System.Drawing.Image)
        Me.item_pic.Location = New System.Drawing.Point(777, 231)
        Me.item_pic.Name = "item_pic"
        Me.item_pic.Size = New System.Drawing.Size(246, 220)
        Me.item_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.item_pic.TabIndex = 30
        Me.item_pic.TabStop = False
        '
        'item_bt
        '
        Me.item_bt.BackColor = System.Drawing.Color.Transparent
        Me.item_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.item_bt.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.item_bt.Location = New System.Drawing.Point(761, 213)
        Me.item_bt.Name = "item_bt"
        Me.item_bt.Size = New System.Drawing.Size(275, 274)
        Me.item_bt.TabIndex = 31
        Me.item_bt.Text = "Item Details"
        Me.item_bt.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.item_bt.UseVisualStyleBackColor = False
        '
        'fexit_bt
        '
        Me.fexit_bt.Image = CType(resources.GetObject("fexit_bt.Image"), System.Drawing.Image)
        Me.fexit_bt.Location = New System.Drawing.Point(982, 12)
        Me.fexit_bt.Name = "fexit_bt"
        Me.fexit_bt.Size = New System.Drawing.Size(35, 30)
        Me.fexit_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fexit_bt.TabIndex = 34
        Me.fexit_bt.TabStop = False
        '
        'mini_bt
        '
        Me.mini_bt.Image = CType(resources.GetObject("mini_bt.Image"), System.Drawing.Image)
        Me.mini_bt.Location = New System.Drawing.Point(1023, 12)
        Me.mini_bt.Name = "mini_bt"
        Me.mini_bt.Size = New System.Drawing.Size(35, 30)
        Me.mini_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mini_bt.TabIndex = 33
        Me.mini_bt.TabStop = False
        '
        'close_bt
        '
        Me.close_bt.Image = CType(resources.GetObject("close_bt.Image"), System.Drawing.Image)
        Me.close_bt.Location = New System.Drawing.Point(1064, 12)
        Me.close_bt.Name = "close_bt"
        Me.close_bt.Size = New System.Drawing.Size(34, 30)
        Me.close_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.close_bt.TabIndex = 32
        Me.close_bt.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 53)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Admin Options"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(1110, 700)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fexit_bt)
        Me.Controls.Add(Me.mini_bt)
        Me.Controls.Add(Me.close_bt)
        Me.Controls.Add(Me.item_pic)
        Me.Controls.Add(Me.item_bt)
        Me.Controls.Add(Me.sys_pic)
        Me.Controls.Add(Me.sys_bt)
        Me.Controls.Add(Me.user_pic)
        Me.Controls.Add(Me.user_bt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form11"
        Me.Text = "Form11"
        CType(Me.user_pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sys_pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item_pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fexit_bt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mini_bt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.close_bt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents user_pic As PictureBox
    Friend WithEvents user_bt As Button
    Friend WithEvents sys_pic As PictureBox
    Friend WithEvents sys_bt As Button
    Friend WithEvents item_pic As PictureBox
    Friend WithEvents item_bt As Button
    Friend WithEvents fexit_bt As PictureBox
    Friend WithEvents mini_bt As PictureBox
    Friend WithEvents close_bt As PictureBox
    Friend WithEvents Label1 As Label
End Class
