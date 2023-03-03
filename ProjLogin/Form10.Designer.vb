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
        Me.fexit_bt = New System.Windows.Forms.PictureBox()
        Me.mini_bt = New System.Windows.Forms.PictureBox()
        Me.close_bt = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.fexit_bt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mini_bt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.close_bt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fexit_bt
        '
        Me.fexit_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fexit_bt.Image = CType(resources.GetObject("fexit_bt.Image"), System.Drawing.Image)
        Me.fexit_bt.Location = New System.Drawing.Point(982, 12)
        Me.fexit_bt.Name = "fexit_bt"
        Me.fexit_bt.Size = New System.Drawing.Size(35, 30)
        Me.fexit_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fexit_bt.TabIndex = 29
        Me.fexit_bt.TabStop = False
        '
        'mini_bt
        '
        Me.mini_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mini_bt.Image = CType(resources.GetObject("mini_bt.Image"), System.Drawing.Image)
        Me.mini_bt.Location = New System.Drawing.Point(1023, 12)
        Me.mini_bt.Name = "mini_bt"
        Me.mini_bt.Size = New System.Drawing.Size(35, 30)
        Me.mini_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mini_bt.TabIndex = 28
        Me.mini_bt.TabStop = False
        '
        'close_bt
        '
        Me.close_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.close_bt.Image = CType(resources.GetObject("close_bt.Image"), System.Drawing.Image)
        Me.close_bt.Location = New System.Drawing.Point(1064, 12)
        Me.close_bt.Name = "close_bt"
        Me.close_bt.Size = New System.Drawing.Size(34, 30)
        Me.close_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.close_bt.TabIndex = 27
        Me.close_bt.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(216, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 40)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Order Summary"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(12, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 53)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Checkout"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1110, 700)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.fexit_bt)
        Me.Controls.Add(Me.mini_bt)
        Me.Controls.Add(Me.close_bt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form10"
        Me.Text = "Form10"
        CType(Me.fexit_bt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mini_bt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.close_bt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fexit_bt As PictureBox
    Friend WithEvents mini_bt As PictureBox
    Friend WithEvents close_bt As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
