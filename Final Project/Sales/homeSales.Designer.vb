<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class homeSales
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.jenisBarangText = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.teleponText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.alamatText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.jumlahText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tanggalText = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuSeparator3 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tableSalesOrder = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenis_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamat_costumer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telepon_costumer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status_bayar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.tableSalesOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(27, 46)
        Me.BunifuSeparator2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(940, 10)
        Me.BunifuSeparator2.TabIndex = 41
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bell MT", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(229, 31)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Create Sales Order"
        '
        'jenisBarangText
        '
        Me.jenisBarangText.BackColor = System.Drawing.Color.Transparent
        Me.jenisBarangText.BorderRadius = 3
        Me.jenisBarangText.DisabledColor = System.Drawing.Color.Gray
        Me.jenisBarangText.ForeColor = System.Drawing.Color.Black
        Me.jenisBarangText.Items = New String(-1) {}
        Me.jenisBarangText.Location = New System.Drawing.Point(216, 146)
        Me.jenisBarangText.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.jenisBarangText.Name = "jenisBarangText"
        Me.jenisBarangText.NomalColor = System.Drawing.Color.Gainsboro
        Me.jenisBarangText.onHoverColor = System.Drawing.Color.Silver
        Me.jenisBarangText.selectedIndex = -1
        Me.jenisBarangText.Size = New System.Drawing.Size(268, 35)
        Me.jenisBarangText.TabIndex = 60
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(25, 159)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 22)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "Jenis Barang"
        '
        'teleponText
        '
        Me.teleponText.BackColor = System.Drawing.Color.Gainsboro
        Me.teleponText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.teleponText.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.teleponText.ForeColor = System.Drawing.Color.Black
        Me.teleponText.HintForeColor = System.Drawing.Color.Empty
        Me.teleponText.HintText = ""
        Me.teleponText.isPassword = False
        Me.teleponText.LineFocusedColor = System.Drawing.Color.Black
        Me.teleponText.LineIdleColor = System.Drawing.Color.Black
        Me.teleponText.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.teleponText.LineThickness = 3
        Me.teleponText.Location = New System.Drawing.Point(711, 148)
        Me.teleponText.Margin = New System.Windows.Forms.Padding(4)
        Me.teleponText.Name = "teleponText"
        Me.teleponText.Size = New System.Drawing.Size(256, 33)
        Me.teleponText.TabIndex = 58
        Me.teleponText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'alamatText
        '
        Me.alamatText.BackColor = System.Drawing.Color.Gainsboro
        Me.alamatText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.alamatText.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.alamatText.ForeColor = System.Drawing.Color.Black
        Me.alamatText.HintForeColor = System.Drawing.Color.Empty
        Me.alamatText.HintText = ""
        Me.alamatText.isPassword = False
        Me.alamatText.LineFocusedColor = System.Drawing.Color.Black
        Me.alamatText.LineIdleColor = System.Drawing.Color.Black
        Me.alamatText.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.alamatText.LineThickness = 3
        Me.alamatText.Location = New System.Drawing.Point(711, 94)
        Me.alamatText.Margin = New System.Windows.Forms.Padding(4)
        Me.alamatText.Name = "alamatText"
        Me.alamatText.Size = New System.Drawing.Size(256, 33)
        Me.alamatText.TabIndex = 57
        Me.alamatText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'jumlahText
        '
        Me.jumlahText.BackColor = System.Drawing.Color.Gainsboro
        Me.jumlahText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.jumlahText.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.jumlahText.ForeColor = System.Drawing.Color.Black
        Me.jumlahText.HintForeColor = System.Drawing.Color.Empty
        Me.jumlahText.HintText = ""
        Me.jumlahText.isPassword = False
        Me.jumlahText.LineFocusedColor = System.Drawing.Color.Black
        Me.jumlahText.LineIdleColor = System.Drawing.Color.Black
        Me.jumlahText.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.jumlahText.LineThickness = 3
        Me.jumlahText.Location = New System.Drawing.Point(216, 207)
        Me.jumlahText.Margin = New System.Windows.Forms.Padding(4)
        Me.jumlahText.Name = "jumlahText"
        Me.jumlahText.Size = New System.Drawing.Size(268, 33)
        Me.jumlahText.TabIndex = 56
        Me.jumlahText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Font = New System.Drawing.Font("Bell MT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(826, 242)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 46)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "Create"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'tanggalText
        '
        Me.tanggalText.BackColor = System.Drawing.Color.White
        Me.tanggalText.BorderRadius = 0
        Me.tanggalText.ForeColor = System.Drawing.Color.Black
        Me.tanggalText.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.tanggalText.FormatCustom = Nothing
        Me.tanggalText.Location = New System.Drawing.Point(216, 81)
        Me.tanggalText.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tanggalText.Name = "tanggalText"
        Me.tanggalText.Size = New System.Drawing.Size(268, 46)
        Me.tanggalText.TabIndex = 54
        Me.tanggalText.Value = New Date(2017, 12, 6, 23, 49, 43, 301)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(546, 159)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(148, 22)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "Telepon Costumer"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(546, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(145, 22)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Alamat Costumer"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(25, 218)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 22)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Jumlah Barang"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 22)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Tanggal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bell MT", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 326)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 31)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "List Sales Order"
        '
        'BunifuSeparator3
        '
        Me.BunifuSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator3.LineThickness = 1
        Me.BunifuSeparator3.Location = New System.Drawing.Point(27, 361)
        Me.BunifuSeparator3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuSeparator3.Name = "BunifuSeparator3"
        Me.BunifuSeparator3.Size = New System.Drawing.Size(947, 10)
        Me.BunifuSeparator3.TabIndex = 62
        Me.BunifuSeparator3.Transparency = 255
        Me.BunifuSeparator3.Vertical = False
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(27, 312)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(949, 10)
        Me.BunifuSeparator1.TabIndex = 61
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(29, 389)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(950, 32)
        Me.Panel1.TabIndex = 66
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bell MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(397, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 27)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "List Sales Order"
        '
        'tableSalesOrder
        '
        Me.tableSalesOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tableSalesOrder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.tanggal, Me.jenis_barang, Me.jumlah_barang, Me.alamat_costumer, Me.telepon_costumer, Me.status_bayar})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tableSalesOrder.DefaultCellStyle = DataGridViewCellStyle1
        Me.tableSalesOrder.Location = New System.Drawing.Point(29, 416)
        Me.tableSalesOrder.Name = "tableSalesOrder"
        Me.tableSalesOrder.RowTemplate.Height = 24
        Me.tableSalesOrder.Size = New System.Drawing.Size(950, 249)
        Me.tableSalesOrder.TabIndex = 65
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.Width = 50
        '
        'tanggal
        '
        Me.tanggal.HeaderText = "Tanggal"
        Me.tanggal.Name = "tanggal"
        '
        'jenis_barang
        '
        Me.jenis_barang.HeaderText = "Jenis Barang"
        Me.jenis_barang.Name = "jenis_barang"
        '
        'jumlah_barang
        '
        Me.jumlah_barang.HeaderText = "Jumlah Barang"
        Me.jumlah_barang.Name = "jumlah_barang"
        '
        'alamat_costumer
        '
        Me.alamat_costumer.HeaderText = "Alamat Costumer"
        Me.alamat_costumer.Name = "alamat_costumer"
        Me.alamat_costumer.Width = 105
        '
        'telepon_costumer
        '
        Me.telepon_costumer.HeaderText = "No Hp"
        Me.telepon_costumer.Name = "telepon_costumer"
        '
        'status_bayar
        '
        Me.status_bayar.HeaderText = "Status"
        Me.status_bayar.Name = "status_bayar"
        '
        'homeSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tableSalesOrder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BunifuSeparator3)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.jenisBarangText)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.teleponText)
        Me.Controls.Add(Me.alamatText)
        Me.Controls.Add(Me.jumlahText)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tanggalText)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.Label7)
        Me.Name = "homeSales"
        Me.Size = New System.Drawing.Size(1019, 692)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tableSalesOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label7 As Label
    Friend WithEvents jenisBarangText As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label12 As Label
    Friend WithEvents teleponText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents alamatText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents jumlahText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Button1 As Button
    Friend WithEvents tanggalText As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuSeparator3 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents tableSalesOrder As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents tanggal As DataGridViewTextBoxColumn
    Friend WithEvents jenis_barang As DataGridViewTextBoxColumn
    Friend WithEvents jumlah_barang As DataGridViewTextBoxColumn
    Friend WithEvents alamat_costumer As DataGridViewTextBoxColumn
    Friend WithEvents telepon_costumer As DataGridViewTextBoxColumn
    Friend WithEvents status_bayar As DataGridViewTextBoxColumn
End Class
