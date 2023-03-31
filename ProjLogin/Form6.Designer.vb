<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.mini_bt = New System.Windows.Forms.PictureBox()
        Me.close_bt = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.back_bt = New System.Windows.Forms.Button()
        Me.addcrt_bt = New System.Windows.Forms.Button()
        Me.itmrat_lbl = New System.Windows.Forms.Label()
        Me.sysrat_lbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.verd_txt = New System.Windows.Forms.TextBox()
        Me.fexit_bt = New System.Windows.Forms.PictureBox()
        CType(Me.mini_bt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.close_bt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.fexit_bt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mini_bt
        '
        Me.mini_bt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mini_bt.Image = CType(resources.GetObject("mini_bt.Image"), System.Drawing.Image)
        Me.mini_bt.Location = New System.Drawing.Point(1023, 12)
        Me.mini_bt.Name = "mini_bt"
        Me.mini_bt.Size = New System.Drawing.Size(35, 30)
        Me.mini_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mini_bt.TabIndex = 15
        Me.mini_bt.TabStop = False
        '
        'close_bt
        '
        Me.close_bt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.close_bt.Image = CType(resources.GetObject("close_bt.Image"), System.Drawing.Image)
        Me.close_bt.Location = New System.Drawing.Point(1064, 12)
        Me.close_bt.Name = "close_bt"
        Me.close_bt.Size = New System.Drawing.Size(34, 30)
        Me.close_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.close_bt.TabIndex = 14
        Me.close_bt.TabStop = False
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
        Me.Label3.Size = New System.Drawing.Size(391, 53)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Compatibility Check"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.BlueViolet
        Me.Panel1.Controls.Add(Me.back_bt)
        Me.Panel1.Controls.Add(Me.addcrt_bt)
        Me.Panel1.Controls.Add(Me.itmrat_lbl)
        Me.Panel1.Controls.Add(Me.sysrat_lbl)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Location = New System.Drawing.Point(23, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1064, 550)
        Me.Panel1.TabIndex = 19
        '
        'back_bt
        '
        Me.back_bt.BackColor = System.Drawing.Color.Silver
        Me.back_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.back_bt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.back_bt.ForeColor = System.Drawing.Color.Black
        Me.back_bt.Location = New System.Drawing.Point(899, 503)
        Me.back_bt.Name = "back_bt"
        Me.back_bt.Size = New System.Drawing.Size(148, 29)
        Me.back_bt.TabIndex = 28
        Me.back_bt.Text = "Back to catalogue"
        Me.back_bt.UseVisualStyleBackColor = False
        '
        'addcrt_bt
        '
        Me.addcrt_bt.BackColor = System.Drawing.Color.Silver
        Me.addcrt_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.addcrt_bt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.addcrt_bt.ForeColor = System.Drawing.Color.Black
        Me.addcrt_bt.Location = New System.Drawing.Point(615, 503)
        Me.addcrt_bt.Name = "addcrt_bt"
        Me.addcrt_bt.Size = New System.Drawing.Size(277, 29)
        Me.addcrt_bt.TabIndex = 27
        Me.addcrt_bt.Text = "Add to cart and go back to catalogue"
        Me.addcrt_bt.UseVisualStyleBackColor = False
        '
        'itmrat_lbl
        '
        Me.itmrat_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.itmrat_lbl.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.itmrat_lbl.ForeColor = System.Drawing.Color.Black
        Me.itmrat_lbl.Location = New System.Drawing.Point(623, 86)
        Me.itmrat_lbl.Name = "itmrat_lbl"
        Me.itmrat_lbl.Size = New System.Drawing.Size(183, 67)
        Me.itmrat_lbl.TabIndex = 24
        Me.itmrat_lbl.Text = "Rating"
        Me.itmrat_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'sysrat_lbl
        '
        Me.sysrat_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.sysrat_lbl.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.sysrat_lbl.ForeColor = System.Drawing.Color.Black
        Me.sysrat_lbl.Location = New System.Drawing.Point(276, 86)
        Me.sysrat_lbl.Name = "sysrat_lbl"
        Me.sysrat_lbl.Size = New System.Drawing.Size(183, 67)
        Me.sysrat_lbl.TabIndex = 23
        Me.sysrat_lbl.Text = "Rating"
        Me.sysrat_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(590, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(244, 56)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Item Rating"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(215, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(296, 56)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "System Rating"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(1063, 293)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(391, 53)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Compatibility Check"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Indigo
        Me.FlowLayoutPanel1.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel1.Controls.Add(Me.verd_txt)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(16, 204)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1031, 256)
        Me.FlowLayoutPanel1.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 46)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Verdict"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'verd_txt
        '
        Me.verd_txt.BackColor = System.Drawing.Color.Indigo
        Me.verd_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.verd_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.verd_txt.ForeColor = System.Drawing.Color.White
        Me.verd_txt.Location = New System.Drawing.Point(3, 49)
        Me.verd_txt.Multiline = True
        Me.verd_txt.Name = "verd_txt"
        Me.verd_txt.ReadOnly = True
        Me.verd_txt.Size = New System.Drawing.Size(1010, 188)
        Me.verd_txt.TabIndex = 27
        Me.verd_txt.Text = "PlaceHolder"
        '
        'fexit_bt
        '
        Me.fexit_bt.Image = CType(resources.GetObject("fexit_bt.Image"), System.Drawing.Image)
        Me.fexit_bt.Location = New System.Drawing.Point(982, 12)
        Me.fexit_bt.Name = "fexit_bt"
        Me.fexit_bt.Size = New System.Drawing.Size(35, 30)
        Me.fexit_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fexit_bt.TabIndex = 31
        Me.fexit_bt.TabStop = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.ClientSize = New System.Drawing.Size(1110, 638)
        Me.Controls.Add(Me.fexit_bt)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.mini_bt)
        Me.Controls.Add(Me.close_bt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form6"
        Me.Text = "Form6"
        CType(Me.mini_bt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.close_bt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.fexit_bt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mini_bt As PictureBox
    Friend WithEvents close_bt As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents itmrat_lbl As Label
    Friend WithEvents sysrat_lbl As Label
    Friend WithEvents back_bt As Button
    Friend WithEvents addcrt_bt As Button
    Friend WithEvents fexit_bt As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents verd_txt As TextBox
End Class
