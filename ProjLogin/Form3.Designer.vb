<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.sysrate_lbl = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.descrip_txt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cpugen_txt = New System.Windows.Forms.ComboBox()
        Me.cpumfct_txt = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cpugen_lbl = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ram_box = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.os_txt = New System.Windows.Forms.ComboBox()
        Me.clear_bt = New System.Windows.Forms.Button()
        Me.calc_bt = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.storage_use_txt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ded_rad = New System.Windows.Forms.RadioButton()
        Me.int_rad = New System.Windows.Forms.RadioButton()
        Me.gpu_lbl = New System.Windows.Forms.Label()
        Me.cpu_lbl = New System.Windows.Forms.Label()
        Me.storage_lbl = New System.Windows.Forms.Label()
        Me.ram_lbl = New System.Windows.Forms.Label()
        Me.os_lbl = New System.Windows.Forms.Label()
        Me.gpu_ded = New System.Windows.Forms.TextBox()
        Me.gpu_int = New System.Windows.Forms.TextBox()
        Me.storage_tot_txt = New System.Windows.Forms.TextBox()
        Me.fexit_bt = New System.Windows.Forms.PictureBox()
        Me.mini_bt = New System.Windows.Forms.PictureBox()
        Me.close_bt = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.fexit_bt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mini_bt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.close_bt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(19, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(314, 27)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fill in these particulars to continue"
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
        Me.Label1.Size = New System.Drawing.Size(418, 53)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "System Specifications"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.sysrate_lbl)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(21, 126)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1064, 550)
        Me.Panel1.TabIndex = 10
        '
        'sysrate_lbl
        '
        Me.sysrate_lbl.AutoSize = True
        Me.sysrate_lbl.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.sysrate_lbl.ForeColor = System.Drawing.Color.White
        Me.sysrate_lbl.Location = New System.Drawing.Point(896, 436)
        Me.sysrate_lbl.Name = "sysrate_lbl"
        Me.sysrate_lbl.Size = New System.Drawing.Size(71, 28)
        Me.sysrate_lbl.TabIndex = 21
        Me.sysrate_lbl.Text = "Rating"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Silver
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(925, 499)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 29)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Continue"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(679, 427)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(211, 40)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "System Rating"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel2.Controls.Add(Me.descrip_txt)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(652, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(385, 328)
        Me.Panel2.TabIndex = 18
        '
        'descrip_txt
        '
        Me.descrip_txt.BackColor = System.Drawing.Color.MidnightBlue
        Me.descrip_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.descrip_txt.ForeColor = System.Drawing.Color.White
        Me.descrip_txt.Location = New System.Drawing.Point(10, 62)
        Me.descrip_txt.Multiline = True
        Me.descrip_txt.Name = "descrip_txt"
        Me.descrip_txt.PlaceholderText = "Click on any configuration to learn more about it"
        Me.descrip_txt.ReadOnly = True
        Me.descrip_txt.Size = New System.Drawing.Size(367, 253)
        Me.descrip_txt.TabIndex = 12
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
        Me.Label10.Size = New System.Drawing.Size(175, 38)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Description:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cpugen_txt)
        Me.GroupBox1.Controls.Add(Me.cpumfct_txt)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.cpugen_lbl)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.ram_box)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.os_txt)
        Me.GroupBox1.Controls.Add(Me.clear_bt)
        Me.GroupBox1.Controls.Add(Me.calc_bt)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.storage_use_txt)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.ded_rad)
        Me.GroupBox1.Controls.Add(Me.int_rad)
        Me.GroupBox1.Controls.Add(Me.gpu_lbl)
        Me.GroupBox1.Controls.Add(Me.cpu_lbl)
        Me.GroupBox1.Controls.Add(Me.storage_lbl)
        Me.GroupBox1.Controls.Add(Me.ram_lbl)
        Me.GroupBox1.Controls.Add(Me.os_lbl)
        Me.GroupBox1.Controls.Add(Me.gpu_ded)
        Me.GroupBox1.Controls.Add(Me.gpu_int)
        Me.GroupBox1.Controls.Add(Me.storage_tot_txt)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(21, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(597, 516)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Specifications"
        '
        'cpugen_txt
        '
        Me.cpugen_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cpugen_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cpugen_txt.ForeColor = System.Drawing.Color.White
        Me.cpugen_txt.FormattingEnabled = True
        Me.cpugen_txt.Location = New System.Drawing.Point(254, 306)
        Me.cpugen_txt.Name = "cpugen_txt"
        Me.cpugen_txt.Size = New System.Drawing.Size(59, 28)
        Me.cpugen_txt.TabIndex = 33
        '
        'cpumfct_txt
        '
        Me.cpumfct_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cpumfct_txt.ForeColor = System.Drawing.Color.White
        Me.cpumfct_txt.FormattingEnabled = True
        Me.cpumfct_txt.Items.AddRange(New Object() {"AMD Athlon", "AMD Ryzen 3", "AMD Ryzen 5", "AMD Ryzen 7", "Intel Pentium", "Intel i3", "Intel i5", "Intel i7"})
        Me.cpumfct_txt.Location = New System.Drawing.Point(254, 262)
        Me.cpumfct_txt.Name = "cpumfct_txt"
        Me.cpumfct_txt.Size = New System.Drawing.Size(313, 28)
        Me.cpumfct_txt.TabIndex = 32
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(358, 191)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(28, 20)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "GB"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(358, 155)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(28, 20)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "GB"
        '
        'cpugen_lbl
        '
        Me.cpugen_lbl.AutoSize = True
        Me.cpugen_lbl.ForeColor = System.Drawing.Color.White
        Me.cpugen_lbl.Location = New System.Drawing.Point(166, 306)
        Me.cpugen_lbl.Name = "cpugen_lbl"
        Me.cpugen_lbl.Size = New System.Drawing.Size(82, 20)
        Me.cpugen_lbl.TabIndex = 29
        Me.cpugen_lbl.Text = "Generation"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(77, 268)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(171, 20)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Manufacturer/Sub Brand"
        '
        'ram_box
        '
        Me.ram_box.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ram_box.DisplayMember = "Integer"
        Me.ram_box.ForeColor = System.Drawing.Color.White
        Me.ram_box.FormattingEnabled = True
        Me.ram_box.Items.AddRange(New Object() {"2", "4", "6", "8", "12", "16", "24", "32"})
        Me.ram_box.Location = New System.Drawing.Point(254, 81)
        Me.ram_box.Name = "ram_box"
        Me.ram_box.Size = New System.Drawing.Size(59, 28)
        Me.ram_box.TabIndex = 26
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(319, 87)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(28, 20)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "GB"
        '
        'os_txt
        '
        Me.os_txt.AllowDrop = True
        Me.os_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.os_txt.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.os_txt.ForeColor = System.Drawing.Color.White
        Me.os_txt.FormattingEnabled = True
        Me.os_txt.Items.AddRange(New Object() {"Windows 7", "Windows 8", "Windows 8.1", "Windows 10", "Windows 11"})
        Me.os_txt.Location = New System.Drawing.Point(254, 39)
        Me.os_txt.Name = "os_txt"
        Me.os_txt.Size = New System.Drawing.Size(313, 28)
        Me.os_txt.TabIndex = 24
        '
        'clear_bt
        '
        Me.clear_bt.BackColor = System.Drawing.Color.LightGray
        Me.clear_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.clear_bt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.clear_bt.ForeColor = System.Drawing.Color.Black
        Me.clear_bt.Location = New System.Drawing.Point(311, 471)
        Me.clear_bt.Name = "clear_bt"
        Me.clear_bt.Size = New System.Drawing.Size(94, 29)
        Me.clear_bt.TabIndex = 20
        Me.clear_bt.Text = "Clear"
        Me.clear_bt.UseVisualStyleBackColor = False
        '
        'calc_bt
        '
        Me.calc_bt.BackColor = System.Drawing.Color.Silver
        Me.calc_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.calc_bt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.calc_bt.ForeColor = System.Drawing.Color.Black
        Me.calc_bt.Location = New System.Drawing.Point(422, 471)
        Me.calc_bt.Name = "calc_bt"
        Me.calc_bt.Size = New System.Drawing.Size(135, 29)
        Me.calc_bt.TabIndex = 19
        Me.calc_bt.Text = "Calculate Rating"
        Me.calc_bt.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(160, 435)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 20)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Dedicated"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(160, 399)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 20)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Integrated"
        '
        'storage_use_txt
        '
        Me.storage_use_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.storage_use_txt.ForeColor = System.Drawing.Color.White
        Me.storage_use_txt.Location = New System.Drawing.Point(254, 188)
        Me.storage_use_txt.Name = "storage_use_txt"
        Me.storage_use_txt.Size = New System.Drawing.Size(98, 27)
        Me.storage_use_txt.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(206, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Total"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(206, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Used"
        '
        'ded_rad
        '
        Me.ded_rad.AutoSize = True
        Me.ded_rad.ForeColor = System.Drawing.Color.White
        Me.ded_rad.Location = New System.Drawing.Point(381, 356)
        Me.ded_rad.Name = "ded_rad"
        Me.ded_rad.Size = New System.Drawing.Size(186, 24)
        Me.ded_rad.TabIndex = 14
        Me.ded_rad.TabStop = True
        Me.ded_rad.Text = "Integrated + Dedicated"
        Me.ded_rad.UseVisualStyleBackColor = True
        '
        'int_rad
        '
        Me.int_rad.AutoSize = True
        Me.int_rad.ForeColor = System.Drawing.Color.White
        Me.int_rad.Location = New System.Drawing.Point(244, 355)
        Me.int_rad.Name = "int_rad"
        Me.int_rad.Size = New System.Drawing.Size(131, 24)
        Me.int_rad.TabIndex = 13
        Me.int_rad.TabStop = True
        Me.int_rad.Text = "Integrated only"
        Me.int_rad.UseVisualStyleBackColor = True
        '
        'gpu_lbl
        '
        Me.gpu_lbl.AutoSize = True
        Me.gpu_lbl.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.gpu_lbl.ForeColor = System.Drawing.Color.White
        Me.gpu_lbl.Location = New System.Drawing.Point(30, 356)
        Me.gpu_lbl.Name = "gpu_lbl"
        Me.gpu_lbl.Size = New System.Drawing.Size(199, 23)
        Me.gpu_lbl.TabIndex = 12
        Me.gpu_lbl.Text = "Graphics Processing Unit"
        '
        'cpu_lbl
        '
        Me.cpu_lbl.AutoSize = True
        Me.cpu_lbl.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cpu_lbl.ForeColor = System.Drawing.Color.White
        Me.cpu_lbl.Location = New System.Drawing.Point(60, 230)
        Me.cpu_lbl.Name = "cpu_lbl"
        Me.cpu_lbl.Size = New System.Drawing.Size(188, 23)
        Me.cpu_lbl.TabIndex = 11
        Me.cpu_lbl.Text = "Central Processing Unit"
        '
        'storage_lbl
        '
        Me.storage_lbl.AutoSize = True
        Me.storage_lbl.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.storage_lbl.ForeColor = System.Drawing.Color.White
        Me.storage_lbl.Location = New System.Drawing.Point(179, 117)
        Me.storage_lbl.Name = "storage_lbl"
        Me.storage_lbl.Size = New System.Drawing.Size(69, 23)
        Me.storage_lbl.TabIndex = 8
        Me.storage_lbl.Text = "Storage"
        '
        'ram_lbl
        '
        Me.ram_lbl.AutoSize = True
        Me.ram_lbl.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ram_lbl.ForeColor = System.Drawing.Color.White
        Me.ram_lbl.Location = New System.Drawing.Point(200, 81)
        Me.ram_lbl.Name = "ram_lbl"
        Me.ram_lbl.Size = New System.Drawing.Size(48, 23)
        Me.ram_lbl.TabIndex = 7
        Me.ram_lbl.Text = "RAM"
        '
        'os_lbl
        '
        Me.os_lbl.AutoSize = True
        Me.os_lbl.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.os_lbl.ForeColor = System.Drawing.Color.White
        Me.os_lbl.Location = New System.Drawing.Point(101, 39)
        Me.os_lbl.Name = "os_lbl"
        Me.os_lbl.Size = New System.Drawing.Size(147, 23)
        Me.os_lbl.TabIndex = 6
        Me.os_lbl.Text = "Operating System"
        '
        'gpu_ded
        '
        Me.gpu_ded.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gpu_ded.ForeColor = System.Drawing.Color.White
        Me.gpu_ded.Location = New System.Drawing.Point(244, 435)
        Me.gpu_ded.Name = "gpu_ded"
        Me.gpu_ded.Size = New System.Drawing.Size(323, 27)
        Me.gpu_ded.TabIndex = 5
        '
        'gpu_int
        '
        Me.gpu_int.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gpu_int.ForeColor = System.Drawing.Color.White
        Me.gpu_int.Location = New System.Drawing.Point(244, 399)
        Me.gpu_int.Name = "gpu_int"
        Me.gpu_int.Size = New System.Drawing.Size(323, 27)
        Me.gpu_int.TabIndex = 3
        '
        'storage_tot_txt
        '
        Me.storage_tot_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.storage_tot_txt.ForeColor = System.Drawing.Color.White
        Me.storage_tot_txt.Location = New System.Drawing.Point(254, 152)
        Me.storage_tot_txt.Name = "storage_tot_txt"
        Me.storage_tot_txt.Size = New System.Drawing.Size(98, 27)
        Me.storage_tot_txt.TabIndex = 2
        '
        'fexit_bt
        '
        Me.fexit_bt.Image = CType(resources.GetObject("fexit_bt.Image"), System.Drawing.Image)
        Me.fexit_bt.Location = New System.Drawing.Point(982, 12)
        Me.fexit_bt.Name = "fexit_bt"
        Me.fexit_bt.Size = New System.Drawing.Size(35, 30)
        Me.fexit_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fexit_bt.TabIndex = 23
        Me.fexit_bt.TabStop = False
        '
        'mini_bt
        '
        Me.mini_bt.Image = CType(resources.GetObject("mini_bt.Image"), System.Drawing.Image)
        Me.mini_bt.Location = New System.Drawing.Point(1023, 12)
        Me.mini_bt.Name = "mini_bt"
        Me.mini_bt.Size = New System.Drawing.Size(35, 30)
        Me.mini_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mini_bt.TabIndex = 22
        Me.mini_bt.TabStop = False
        '
        'close_bt
        '
        Me.close_bt.Image = CType(resources.GetObject("close_bt.Image"), System.Drawing.Image)
        Me.close_bt.Location = New System.Drawing.Point(1064, 12)
        Me.close_bt.Name = "close_bt"
        Me.close_bt.Size = New System.Drawing.Size(34, 30)
        Me.close_bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.close_bt.TabIndex = 21
        Me.close_bt.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1110, 700)
        Me.Controls.Add(Me.fexit_bt)
        Me.Controls.Add(Me.mini_bt)
        Me.Controls.Add(Me.close_bt)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.fexit_bt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mini_bt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.close_bt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents gpu_ded As TextBox
    Friend WithEvents gpu_int As TextBox
    Friend WithEvents storage_tot_txt As TextBox
    Friend WithEvents os_lbl As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents descrip_txt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents storage_use_txt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ded_rad As RadioButton
    Friend WithEvents int_rad As RadioButton
    Friend WithEvents gpu_lbl As Label
    Friend WithEvents cpu_lbl As Label
    Friend WithEvents storage_lbl As Label
    Friend WithEvents ram_lbl As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents clear_bt As Button
    Friend WithEvents calc_bt As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents sysrate_lbl As Label
    Friend WithEvents fexit_bt As PictureBox
    Friend WithEvents mini_bt As PictureBox
    Friend WithEvents close_bt As PictureBox
    Friend WithEvents os_txt As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents cpugen_lbl As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents ram_box As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cpumfct_txt As ComboBox
    Friend WithEvents cpugen_txt As ComboBox
End Class
