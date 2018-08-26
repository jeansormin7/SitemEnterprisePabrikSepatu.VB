<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listBarang
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tanggalpick = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.createPengajuanProduksi = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.jumlahBarangText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.jenisBarangText = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.tanggalPengajuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenisBarnag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stokBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BunifuSeparator3 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.jenis_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stok_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tableRaw = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.jenisR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.tableRaw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tanggalpick
        '
        Me.tanggalpick.BackColor = System.Drawing.Color.White
        Me.tanggalpick.BorderRadius = 0
        Me.tanggalpick.ForeColor = System.Drawing.Color.Black
        Me.tanggalpick.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.tanggalpick.FormatCustom = Nothing
        Me.tanggalpick.Location = New System.Drawing.Point(170, 116)
        Me.tanggalpick.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tanggalpick.Name = "tanggalpick"
        Me.tanggalpick.Size = New System.Drawing.Size(344, 34)
        Me.tanggalpick.TabIndex = 63
        Me.tanggalpick.Value = New Date(2017, 12, 6, 23, 49, 43, 301)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 22)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Tanggal Produksi"
        '
        'createPengajuanProduksi
        '
        Me.createPengajuanProduksi.BackColor = System.Drawing.SystemColors.HotTrack
        Me.createPengajuanProduksi.Font = New System.Drawing.Font("Bell MT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createPengajuanProduksi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.createPengajuanProduksi.Location = New System.Drawing.Point(851, 147)
        Me.createPengajuanProduksi.Name = "createPengajuanProduksi"
        Me.createPengajuanProduksi.Size = New System.Drawing.Size(153, 46)
        Me.createPengajuanProduksi.TabIndex = 61
        Me.createPengajuanProduksi.Text = "Create"
        Me.createPengajuanProduksi.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(15, 470)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(486, 32)
        Me.Panel2.TabIndex = 60
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bell MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(106, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(207, 27)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "List Jumlah Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(548, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 22)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Jumlah Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 22)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Jenis Barang"
        '
        'jumlahBarangText
        '
        Me.jumlahBarangText.BackColor = System.Drawing.Color.Gainsboro
        Me.jumlahBarangText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.jumlahBarangText.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.jumlahBarangText.ForeColor = System.Drawing.Color.Black
        Me.jumlahBarangText.HintForeColor = System.Drawing.Color.Empty
        Me.jumlahBarangText.HintText = ""
        Me.jumlahBarangText.isPassword = False
        Me.jumlahBarangText.LineFocusedColor = System.Drawing.Color.Black
        Me.jumlahBarangText.LineIdleColor = System.Drawing.Color.Black
        Me.jumlahBarangText.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.jumlahBarangText.LineThickness = 3
        Me.jumlahBarangText.Location = New System.Drawing.Point(677, 70)
        Me.jumlahBarangText.Margin = New System.Windows.Forms.Padding(4)
        Me.jumlahBarangText.Name = "jumlahBarangText"
        Me.jumlahBarangText.Size = New System.Drawing.Size(327, 33)
        Me.jumlahBarangText.TabIndex = 55
        Me.jumlahBarangText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'jenisBarangText
        '
        Me.jenisBarangText.BackColor = System.Drawing.Color.Transparent
        Me.jenisBarangText.BorderRadius = 3
        Me.jenisBarangText.DisabledColor = System.Drawing.Color.Gray
        Me.jenisBarangText.ForeColor = System.Drawing.Color.Black
        Me.jenisBarangText.Items = New String(-1) {}
        Me.jenisBarangText.Location = New System.Drawing.Point(170, 68)
        Me.jenisBarangText.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.jenisBarangText.Name = "jenisBarangText"
        Me.jenisBarangText.NomalColor = System.Drawing.Color.Gainsboro
        Me.jenisBarangText.onHoverColor = System.Drawing.Color.Silver
        Me.jenisBarangText.selectedIndex = -1
        Me.jenisBarangText.Size = New System.Drawing.Size(344, 35)
        Me.jenisBarangText.TabIndex = 54
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(10, 35)
        Me.BunifuSeparator2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(994, 13)
        Me.BunifuSeparator2.TabIndex = 52
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tanggalPengajuan, Me.jenisBarnag, Me.stokBarang, Me.status})
        Me.DataGridView2.Location = New System.Drawing.Point(15, 236)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(997, 149)
        Me.DataGridView2.TabIndex = 59
        '
        'tanggalPengajuan
        '
        Me.tanggalPengajuan.HeaderText = "Tanggal Pengajuan Produksi"
        Me.tanggalPengajuan.Name = "tanggalPengajuan"
        Me.tanggalPengajuan.Width = 250
        '
        'jenisBarnag
        '
        Me.jenisBarnag.HeaderText = "Jenis Barang"
        Me.jenisBarnag.Name = "jenisBarnag"
        Me.jenisBarnag.Width = 200
        '
        'stokBarang
        '
        Me.stokBarang.HeaderText = "Stok Barang"
        Me.stokBarang.Name = "stokBarang"
        Me.stokBarang.Width = 200
        '
        'status
        '
        Me.status.HeaderText = "Status Pengajuan Prosuksi"
        Me.status.Name = "status"
        Me.status.Width = 250
        '
        'BunifuSeparator3
        '
        Me.BunifuSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator3.LineThickness = 1
        Me.BunifuSeparator3.Location = New System.Drawing.Point(15, 392)
        Me.BunifuSeparator3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuSeparator3.Name = "BunifuSeparator3"
        Me.BunifuSeparator3.Size = New System.Drawing.Size(997, 10)
        Me.BunifuSeparator3.TabIndex = 58
        Me.BunifuSeparator3.Transparency = 255
        Me.BunifuSeparator3.Vertical = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bell MT", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 31)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Permintaan Produksi Barang"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(15, 441)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(997, 10)
        Me.BunifuSeparator1.TabIndex = 49
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.jenis_barang, Me.stok_barang})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(15, 499)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(486, 195)
        Me.DataGridView1.TabIndex = 50
        '
        'jenis_barang
        '
        Me.jenis_barang.HeaderText = "Jenis Barang"
        Me.jenis_barang.Name = "jenis_barang"
        Me.jenis_barang.Width = 200
        '
        'stok_barang
        '
        Me.stok_barang.HeaderText = "Stok Barang"
        Me.stok_barang.Name = "stok_barang"
        Me.stok_barang.Width = 200
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bell MT", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 406)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 31)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "List Barang"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(15, 209)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 32)
        Me.Panel1.TabIndex = 64
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bell MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(325, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(336, 27)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "List Pengajuan Produksi Barang"
        '
        'tableRaw
        '
        Me.tableRaw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tableRaw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.jenisR, Me.stok})
        Me.tableRaw.Location = New System.Drawing.Point(552, 499)
        Me.tableRaw.Name = "tableRaw"
        Me.tableRaw.RowTemplate.Height = 24
        Me.tableRaw.Size = New System.Drawing.Size(452, 195)
        Me.tableRaw.TabIndex = 65
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Location = New System.Drawing.Point(552, 470)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(452, 32)
        Me.Panel3.TabIndex = 61
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bell MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(87, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(269, 27)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "List Jumlah Raw Material"
        '
        'jenisR
        '
        Me.jenisR.HeaderText = "Jenis Raw Material"
        Me.jenisR.Name = "jenisR"
        Me.jenisR.Width = 210
        '
        'stok
        '
        Me.stok.HeaderText = "Stok Raw Material"
        Me.stok.Name = "stok"
        Me.stok.Width = 200
        '
        'listBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.tableRaw)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tanggalpick)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.createPengajuanProduksi)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.jumlahBarangText)
        Me.Controls.Add(Me.jenisBarangText)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.BunifuSeparator3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "listBarang"
        Me.Size = New System.Drawing.Size(1019, 754)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tableRaw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tanggalpick As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Label7 As Label
    Friend WithEvents createPengajuanProduksi As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents jumlahBarangText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents jenisBarangText As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents tanggalPengajuan As DataGridViewTextBoxColumn
    Friend WithEvents jenisBarnag As DataGridViewTextBoxColumn
    Friend WithEvents stokBarang As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents BunifuSeparator3 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents stok_barang As DataGridViewTextBoxColumn
    Friend WithEvents jenis_barang As DataGridViewTextBoxColumn
    Friend WithEvents tableRaw As DataGridView
    Friend WithEvents jenisR As DataGridViewTextBoxColumn
    Friend WithEvents stok As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label8 As Label
End Class
