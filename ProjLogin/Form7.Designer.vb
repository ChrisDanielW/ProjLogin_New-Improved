<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cash_rad = New System.Windows.Forms.RadioButton()
        Me.card_rad = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ccno_lbl = New System.Windows.Forms.Label()
        Me.ccno_txt = New System.Windows.Forms.TextBox()
        Me.next_bt = New System.Windows.Forms.Button()
        Me.fexit_bt = New System.Windows.Forms.PictureBox()
        Me.mini_bt = New System.Windows.Forms.PictureBox()
        Me.close_bt = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.fexit_bt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mini_bt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.close_bt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(12, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 53)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Checkout"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(216, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 40)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Fill in these details first"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.ccno_lbl)
        Me.Panel1.Controls.Add(Me.ccno_txt)
        Me.Panel1.Location = New System.Drawing.Point(15, 94)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(740, 250)
        Me.Panel1.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cash_rad)
        Me.GroupBox1.Controls.Add(Me.card_rad)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(57, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(201, 151)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment methods"
        '
        'cash_rad
        '
        Me.cash_rad.AutoSize = True
        Me.cash_rad.ForeColor = System.Drawing.Color.White
        Me.cash_rad.Location = New System.Drawing.Point(65, 43)
        Me.cash_rad.Name = "cash_rad"
        Me.cash_rad.Size = New System.Drawing.Size(61, 24)
        Me.cash_rad.TabIndex = 27
        Me.cash_rad.TabStop = True
        Me.cash_rad.Text = "Cash"
        Me.cash_rad.UseVisualStyleBackColor = True
        '
        'card_rad
        '
        Me.card_rad.AutoSize = True
        Me.card_rad.ForeColor = System.Drawing.Color.White
        Me.card_rad.Location = New System.Drawing.Point(65, 96)
        Me.card_rad.Name = "card_rad"
        Me.card_rad.Size = New System.Drawing.Size(61, 24)
        Me.card_rad.TabIndex = 28
        Me.card_rad.TabStop = True
        Me.card_rad.Text = "Card"
        Me.card_rad.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(109, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 20)
        Me.Label4.TabIndex = 33
        '
        'ccno_lbl
        '
        Me.ccno_lbl.AutoSize = True
        Me.ccno_lbl.ForeColor = System.Drawing.Color.White
        Me.ccno_lbl.Location = New System.Drawing.Point(297, 114)
        Me.ccno_lbl.Name = "ccno_lbl"
        Me.ccno_lbl.Size = New System.Drawing.Size(137, 20)
        Me.ccno_lbl.TabIndex = 32
        Me.ccno_lbl.Text = "Credit card number"
        Me.ccno_lbl.Visible = False
        '
        'ccno_txt
        '
        Me.ccno_txt.BackColor = System.Drawing.Color.Navy
        Me.ccno_txt.ForeColor = System.Drawing.Color.White
        Me.ccno_txt.Location = New System.Drawing.Point(440, 111)
        Me.ccno_txt.Name = "ccno_txt"
        Me.ccno_txt.Size = New System.Drawing.Size(265, 27)
        Me.ccno_txt.TabIndex = 30
        Me.ccno_txt.Visible = False
        '
        'next_bt
        '
        Me.next_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.next_bt.BackColor = System.Drawing.Color.Silver
        Me.next_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.next_bt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.next_bt.ForeColor = System.Drawing.Color.Black
        Me.next_bt.Location = New System.Drawing.Point(661, 350)
        Me.next_bt.Name = "next_bt"
        Me.next_bt.Size = New System.Drawing.Size(94, 29)
        Me.next_bt.TabIndex = 22
        Me.next_bt.Text = "Continue"
        Me.next_bt.UseVisualStyleBackColor = False
        '
        'fexit_bt
        '
        Me.fexit_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fexit_bt.Image = CType(resources.GetObject("fexit_bt.Image"), System.Drawing.Image)
        Me.fexit_bt.Location = New System.Drawing.Point(654, 10)
        Me.fexit_bt.Name = "fexit_bt"
        Me.fexit_bt.Size = New System.Drawing.Size(35, 30)
        Me.fexit_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fexit_bt.TabIndex = 26
        Me.fexit_bt.TabStop = False
        '
        'mini_bt
        '
        Me.mini_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mini_bt.Image = CType(resources.GetObject("mini_bt.Image"), System.Drawing.Image)
        Me.mini_bt.Location = New System.Drawing.Point(695, 10)
        Me.mini_bt.Name = "mini_bt"
        Me.mini_bt.Size = New System.Drawing.Size(35, 30)
        Me.mini_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mini_bt.TabIndex = 25
        Me.mini_bt.TabStop = False
        '
        'close_bt
        '
        Me.close_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.close_bt.Image = CType(resources.GetObject("close_bt.Image"), System.Drawing.Image)
        Me.close_bt.Location = New System.Drawing.Point(736, 10)
        Me.close_bt.Name = "close_bt"
        Me.close_bt.Size = New System.Drawing.Size(34, 30)
        Me.close_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.close_bt.TabIndex = 24
        Me.close_bt.TabStop = False
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(782, 404)
        Me.Controls.Add(Me.fexit_bt)
        Me.Controls.Add(Me.mini_bt)
        Me.Controls.Add(Me.close_bt)
        Me.Controls.Add(Me.next_bt)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form7"
        Me.Text = "Form7"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.fexit_bt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mini_bt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.close_bt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cash_rad As RadioButton
    Friend WithEvents card_rad As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents ccno_lbl As Label
    Friend WithEvents ccno_txt As TextBox
    Friend WithEvents next_bt As Button
    Friend WithEvents fexit_bt As PictureBox
    Friend WithEvents mini_bt As PictureBox
    Friend WithEvents close_bt As PictureBox
End Class
