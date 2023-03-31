<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form16
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form16))
        Me.fexit_bt = New System.Windows.Forms.PictureBox()
        Me.mini_bt = New System.Windows.Forms.PictureBox()
        Me.close_bt = New System.Windows.Forms.PictureBox()
        Me.back_pic = New System.Windows.Forms.PictureBox()
        Me.back_bt = New System.Windows.Forms.Button()
        Me.UserTab = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.del_bt = New System.Windows.Forms.Button()
        Me.add_bt = New System.Windows.Forms.Button()
        Me.edit_bt = New System.Windows.Forms.Button()
        Me.phone_txt = New System.Windows.Forms.TextBox()
        Me.id_txt = New System.Windows.Forms.TextBox()
        Me.name_txt = New System.Windows.Forms.TextBox()
        Me.pwd_txt = New System.Windows.Forms.TextBox()
        Me.email_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.clear_bt = New System.Windows.Forms.Button()
        CType(Me.fexit_bt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mini_bt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.close_bt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.back_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserTab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fexit_bt
        '
        Me.fexit_bt.Image = CType(resources.GetObject("fexit_bt.Image"), System.Drawing.Image)
        Me.fexit_bt.Location = New System.Drawing.Point(1171, 12)
        Me.fexit_bt.Name = "fexit_bt"
        Me.fexit_bt.Size = New System.Drawing.Size(35, 30)
        Me.fexit_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fexit_bt.TabIndex = 37
        Me.fexit_bt.TabStop = False
        '
        'mini_bt
        '
        Me.mini_bt.Image = CType(resources.GetObject("mini_bt.Image"), System.Drawing.Image)
        Me.mini_bt.Location = New System.Drawing.Point(1212, 12)
        Me.mini_bt.Name = "mini_bt"
        Me.mini_bt.Size = New System.Drawing.Size(35, 30)
        Me.mini_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mini_bt.TabIndex = 36
        Me.mini_bt.TabStop = False
        '
        'close_bt
        '
        Me.close_bt.Image = CType(resources.GetObject("close_bt.Image"), System.Drawing.Image)
        Me.close_bt.Location = New System.Drawing.Point(1253, 12)
        Me.close_bt.Name = "close_bt"
        Me.close_bt.Size = New System.Drawing.Size(34, 30)
        Me.close_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.close_bt.TabIndex = 35
        Me.close_bt.TabStop = False
        '
        'back_pic
        '
        Me.back_pic.Image = CType(resources.GetObject("back_pic.Image"), System.Drawing.Image)
        Me.back_pic.Location = New System.Drawing.Point(1052, 431)
        Me.back_pic.Name = "back_pic"
        Me.back_pic.Size = New System.Drawing.Size(49, 42)
        Me.back_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.back_pic.TabIndex = 38
        Me.back_pic.TabStop = False
        '
        'back_bt
        '
        Me.back_bt.BackColor = System.Drawing.Color.Transparent
        Me.back_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.back_bt.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.back_bt.Location = New System.Drawing.Point(1045, 425)
        Me.back_bt.Name = "back_bt"
        Me.back_bt.Size = New System.Drawing.Size(242, 53)
        Me.back_bt.TabIndex = 39
        Me.back_bt.Text = "Back to Options"
        Me.back_bt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.back_bt.UseVisualStyleBackColor = False
        '
        'UserTab
        '
        Me.UserTab.BackgroundColor = System.Drawing.Color.Brown
        Me.UserTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserTab.Location = New System.Drawing.Point(23, 92)
        Me.UserTab.Name = "UserTab"
        Me.UserTab.RowHeadersWidth = 51
        Me.UserTab.RowTemplate.Height = 29
        Me.UserTab.Size = New System.Drawing.Size(663, 386)
        Me.UserTab.TabIndex = 40
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
        Me.Label1.Size = New System.Drawing.Size(319, 53)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "User Credentials"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'del_bt
        '
        Me.del_bt.AutoSize = True
        Me.del_bt.BackColor = System.Drawing.Color.Black
        Me.del_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.del_bt.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.del_bt.ForeColor = System.Drawing.Color.White
        Me.del_bt.Location = New System.Drawing.Point(707, 434)
        Me.del_bt.Name = "del_bt"
        Me.del_bt.Size = New System.Drawing.Size(256, 44)
        Me.del_bt.TabIndex = 42
        Me.del_bt.Text = "DELETE A USER ACCOUNT"
        Me.del_bt.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.del_bt.UseVisualStyleBackColor = False
        '
        'add_bt
        '
        Me.add_bt.BackColor = System.Drawing.Color.Black
        Me.add_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.add_bt.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.add_bt.ForeColor = System.Drawing.Color.White
        Me.add_bt.Location = New System.Drawing.Point(707, 268)
        Me.add_bt.Name = "add_bt"
        Me.add_bt.Size = New System.Drawing.Size(84, 44)
        Me.add_bt.TabIndex = 43
        Me.add_bt.Text = "ADD"
        Me.add_bt.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.add_bt.UseVisualStyleBackColor = False
        '
        'edit_bt
        '
        Me.edit_bt.BackColor = System.Drawing.Color.Black
        Me.edit_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.edit_bt.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.edit_bt.ForeColor = System.Drawing.Color.White
        Me.edit_bt.Location = New System.Drawing.Point(816, 268)
        Me.edit_bt.Name = "edit_bt"
        Me.edit_bt.Size = New System.Drawing.Size(84, 44)
        Me.edit_bt.TabIndex = 44
        Me.edit_bt.Text = "EDIT"
        Me.edit_bt.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.edit_bt.UseVisualStyleBackColor = False
        '
        'phone_txt
        '
        Me.phone_txt.BackColor = System.Drawing.Color.Maroon
        Me.phone_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.phone_txt.ForeColor = System.Drawing.Color.White
        Me.phone_txt.Location = New System.Drawing.Point(707, 224)
        Me.phone_txt.Name = "phone_txt"
        Me.phone_txt.Size = New System.Drawing.Size(371, 27)
        Me.phone_txt.TabIndex = 45
        '
        'id_txt
        '
        Me.id_txt.BackColor = System.Drawing.Color.Black
        Me.id_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.id_txt.ForeColor = System.Drawing.Color.White
        Me.id_txt.Location = New System.Drawing.Point(707, 92)
        Me.id_txt.Name = "id_txt"
        Me.id_txt.ReadOnly = True
        Me.id_txt.Size = New System.Drawing.Size(371, 27)
        Me.id_txt.TabIndex = 46
        '
        'name_txt
        '
        Me.name_txt.BackColor = System.Drawing.Color.Maroon
        Me.name_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.name_txt.ForeColor = System.Drawing.Color.White
        Me.name_txt.Location = New System.Drawing.Point(707, 125)
        Me.name_txt.Name = "name_txt"
        Me.name_txt.Size = New System.Drawing.Size(371, 27)
        Me.name_txt.TabIndex = 48
        '
        'pwd_txt
        '
        Me.pwd_txt.BackColor = System.Drawing.Color.Maroon
        Me.pwd_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pwd_txt.ForeColor = System.Drawing.Color.White
        Me.pwd_txt.Location = New System.Drawing.Point(707, 158)
        Me.pwd_txt.Name = "pwd_txt"
        Me.pwd_txt.Size = New System.Drawing.Size(371, 27)
        Me.pwd_txt.TabIndex = 49
        '
        'email_txt
        '
        Me.email_txt.BackColor = System.Drawing.Color.Maroon
        Me.email_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.email_txt.ForeColor = System.Drawing.Color.White
        Me.email_txt.Location = New System.Drawing.Point(707, 191)
        Me.email_txt.Name = "email_txt"
        Me.email_txt.Size = New System.Drawing.Size(371, 27)
        Me.email_txt.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(1084, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 32)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(1084, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 32)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(1084, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 32)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(1084, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 32)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Email Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(1084, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(177, 32)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Phone Number"
        '
        'clear_bt
        '
        Me.clear_bt.BackColor = System.Drawing.Color.Black
        Me.clear_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.clear_bt.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.clear_bt.ForeColor = System.Drawing.Color.White
        Me.clear_bt.Location = New System.Drawing.Point(925, 268)
        Me.clear_bt.Name = "clear_bt"
        Me.clear_bt.Size = New System.Drawing.Size(84, 44)
        Me.clear_bt.TabIndex = 56
        Me.clear_bt.Text = "CLEAR"
        Me.clear_bt.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.clear_bt.UseVisualStyleBackColor = False
        '
        'Form16
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(1299, 497)
        Me.Controls.Add(Me.clear_bt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.email_txt)
        Me.Controls.Add(Me.pwd_txt)
        Me.Controls.Add(Me.name_txt)
        Me.Controls.Add(Me.id_txt)
        Me.Controls.Add(Me.phone_txt)
        Me.Controls.Add(Me.edit_bt)
        Me.Controls.Add(Me.add_bt)
        Me.Controls.Add(Me.del_bt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UserTab)
        Me.Controls.Add(Me.back_pic)
        Me.Controls.Add(Me.back_bt)
        Me.Controls.Add(Me.fexit_bt)
        Me.Controls.Add(Me.mini_bt)
        Me.Controls.Add(Me.close_bt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form16"
        Me.Text = "Form16"
        CType(Me.fexit_bt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mini_bt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.close_bt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.back_pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserTab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fexit_bt As PictureBox
    Friend WithEvents mini_bt As PictureBox
    Friend WithEvents close_bt As PictureBox
    Friend WithEvents back_pic As PictureBox
    Friend WithEvents back_bt As Button
    Friend WithEvents UserTab As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents del_bt As Button
    Friend WithEvents add_bt As Button
    Friend WithEvents edit_bt As Button
    Friend WithEvents phone_txt As TextBox
    Friend WithEvents id_txt As TextBox
    Friend WithEvents name_txt As TextBox
    Friend WithEvents pwd_txt As TextBox
    Friend WithEvents email_txt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents clear_bt As Button
End Class
