<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form13
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form13))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fexit_bt = New System.Windows.Forms.PictureBox()
        Me.mini_bt = New System.Windows.Forms.PictureBox()
        Me.close_bt = New System.Windows.Forms.PictureBox()
        Me.FullOrder = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ino_lbl = New System.Windows.Forms.Label()
        Me.name_lbl = New System.Windows.Forms.Label()
        Me.card_lbl = New System.Windows.Forms.Label()
        Me.uid_lbl = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.fexit_bt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mini_bt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.close_bt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FullOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 63)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Report"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'fexit_bt
        '
        Me.fexit_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fexit_bt.Image = CType(resources.GetObject("fexit_bt.Image"), System.Drawing.Image)
        Me.fexit_bt.Location = New System.Drawing.Point(982, 12)
        Me.fexit_bt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.fexit_bt.Name = "fexit_bt"
        Me.fexit_bt.Size = New System.Drawing.Size(35, 30)
        Me.fexit_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fexit_bt.TabIndex = 38
        Me.fexit_bt.TabStop = False
        '
        'mini_bt
        '
        Me.mini_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mini_bt.Image = CType(resources.GetObject("mini_bt.Image"), System.Drawing.Image)
        Me.mini_bt.Location = New System.Drawing.Point(1023, 12)
        Me.mini_bt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mini_bt.Name = "mini_bt"
        Me.mini_bt.Size = New System.Drawing.Size(35, 30)
        Me.mini_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mini_bt.TabIndex = 37
        Me.mini_bt.TabStop = False
        '
        'close_bt
        '
        Me.close_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.close_bt.Image = CType(resources.GetObject("close_bt.Image"), System.Drawing.Image)
        Me.close_bt.Location = New System.Drawing.Point(1064, 12)
        Me.close_bt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.close_bt.Name = "close_bt"
        Me.close_bt.Size = New System.Drawing.Size(34, 30)
        Me.close_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.close_bt.TabIndex = 36
        Me.close_bt.TabStop = False
        '
        'FullOrder
        '
        Me.FullOrder.BackgroundColor = System.Drawing.Color.Brown
        Me.FullOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FullOrder.Location = New System.Drawing.Point(21, 88)
        Me.FullOrder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FullOrder.Name = "FullOrder"
        Me.FullOrder.RowHeadersWidth = 51
        Me.FullOrder.RowTemplate.Height = 29
        Me.FullOrder.Size = New System.Drawing.Size(1057, 404)
        Me.FullOrder.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(21, 508)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(378, 40)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Number of items purchased:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(21, 588)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(231, 40)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Customer Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(21, 628)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 40)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Credit Card:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(191, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(241, 45)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Order Overview"
        '
        'ino_lbl
        '
        Me.ino_lbl.AutoSize = True
        Me.ino_lbl.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.ino_lbl.Location = New System.Drawing.Point(391, 508)
        Me.ino_lbl.Name = "ino_lbl"
        Me.ino_lbl.Size = New System.Drawing.Size(165, 40)
        Me.ino_lbl.TabIndex = 44
        Me.ino_lbl.Text = "Placeholder"
        '
        'name_lbl
        '
        Me.name_lbl.AutoSize = True
        Me.name_lbl.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.name_lbl.Location = New System.Drawing.Point(243, 588)
        Me.name_lbl.Name = "name_lbl"
        Me.name_lbl.Size = New System.Drawing.Size(165, 40)
        Me.name_lbl.TabIndex = 45
        Me.name_lbl.Text = "Placeholder"
        '
        'card_lbl
        '
        Me.card_lbl.AutoSize = True
        Me.card_lbl.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.card_lbl.Location = New System.Drawing.Point(181, 628)
        Me.card_lbl.Name = "card_lbl"
        Me.card_lbl.Size = New System.Drawing.Size(165, 40)
        Me.card_lbl.TabIndex = 46
        Me.card_lbl.Text = "Placeholder"
        '
        'uid_lbl
        '
        Me.uid_lbl.AutoSize = True
        Me.uid_lbl.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.uid_lbl.Location = New System.Drawing.Point(197, 548)
        Me.uid_lbl.Name = "uid_lbl"
        Me.uid_lbl.Size = New System.Drawing.Size(165, 40)
        Me.uid_lbl.TabIndex = 48
        Me.uid_lbl.Text = "Placeholder"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(21, 548)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 40)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Customer ID:"
        '
        'Form13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(1110, 700)
        Me.Controls.Add(Me.uid_lbl)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.card_lbl)
        Me.Controls.Add(Me.name_lbl)
        Me.Controls.Add(Me.ino_lbl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FullOrder)
        Me.Controls.Add(Me.fexit_bt)
        Me.Controls.Add(Me.mini_bt)
        Me.Controls.Add(Me.close_bt)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form13"
        Me.Text = "Form13"
        CType(Me.fexit_bt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mini_bt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.close_bt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FullOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents fexit_bt As PictureBox
    Friend WithEvents mini_bt As PictureBox
    Friend WithEvents close_bt As PictureBox
    Friend WithEvents FullOrder As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ino_lbl As Label
    Friend WithEvents name_lbl As Label
    Friend WithEvents card_lbl As Label
    Friend WithEvents uid_lbl As Label
    Friend WithEvents Label7 As Label
End Class
